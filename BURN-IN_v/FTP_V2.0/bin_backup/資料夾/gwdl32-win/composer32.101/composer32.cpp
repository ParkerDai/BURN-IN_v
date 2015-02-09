#include <stdio.h>
#include <sys/stat.h>
#include <string.h>
#include <stdlib.h>
#include "composer32.h"

void print_usage()
{
		printf ( "Usage   : composer32 file1 file2 file3 [option] adder1 adder2 adder3 adder4\n" ) ;
		printf ( "-b      : bloader.bin -> bloader.dld\n" ) ;
		printf ( "-l      : linux.bin -> linux.dld\n" ) ;
		printf ( "-r      : romfs.img -> romfs.dld\n" ) ;
		printf ( "-l -r   : linux.bin+romfs.img -> linuxall.dld\n" ) ;
		printf ( "Example : composer32 linux.bin linux.dld -l 0 2 0 0\n" ) ;
		printf ( "\r\n");
}


void bfat(int x,int y)
{
///////////////////////////////////////////////////////////////////////
	//16-byte Linux FAT : 0x0000.0020~0x0000.002f
	
	tmp2=f_b_size+(16-f_b_size%16);//Byte 0~3:Byte count of linux.bin 
	if(f_b_size%16==0)
	{
		tmp2-=16;
	}
	
	
	fwrite(&tmp2,1,4,f_rom);
	//Byte 4~7:Physical starting address of Linux in SDRAM 
	fwrite(&x,1,4,f_rom);
	if(oflg)
	{
		tmp=0x00;
		for( i=0;i<3;i++)//Byte 8~11: Reserved.
		{
			fwrite(&tmp,1,1,f_rom);
		}
		tmp=0x01;
		fwrite(&tmp,1,1,f_rom);
		tmp=0xff;
	}
	else if(bflg)
	{
		for( i=0;i<4;i++)//Byte 8~11: Reserved.
		{
			fwrite(&tmp,1,1,f_rom);
		}
	}
	//Byte 12~15: Physical starting address of linux.bin in Flash. 
	fwrite(&y,1,4,f_rom);
}

void linuxfat(int x,int y)
{
///////////////////////////////////////////////////////////////////////
	//16-byte Linux FAT : 0x0000.0020~0x0000.002f
	
	tmp2=f_bin_size+(16-f_bin_size%16);//Byte 0~3:Byte count of linux.bin 
	if(f_bin_size%16==0)
	{
		tmp2-=16;
	}
	fwrite(&tmp2,1,4,f_rom);
	//sdram_address_linux;//Byte 4~7:Physical starting address of Linux in SDRAM 
	fwrite(&x,1,4,f_rom);
	for( i=0;i<4;i++)//Byte 8~11: Reserved.
	{
		fwrite(&tmp,1,1,f_rom);
	}
	//flash_offset*1024+64;//Byte 12~15: Physical starting address of linux.bin in Flash. 
	fwrite(&y,1,4,f_rom);
}

void romfsfat(int x,int y)
{
///////////////////////////////////////////////////////////////////////
	//16-byte ROMFS FAT : 0x0000.0030~0x0000.003f
	
	tmp2=f_img_size+(16-f_img_size%16);//Byte 0~3:Byte count of romfs.img
	if(f_img_size%16==0)
	{
		tmp2-=16;
	}
	fwrite(&tmp2,1,4,f_rom);
	//sdram_address_romfs;//Byte 4~7:Physical starting address of ROMFS in SDRAM 
	fwrite(&x,1,4,f_rom);
	for(i=0;i<4;i++)//Byte 8~11: Reserved.
	{
		fwrite(&tmp,1,1,f_rom);
	}
	fwrite(&y,1,4,f_rom);
}

void linux_bin()
{
///////////////////////////////////////////////////////////////////////
	//Linux.bin size=0x0014.0000-64B : 0x0000.0040~0x0013.ffff
	
	for(i=0;i<f_bin_size;i++)
	{
		fread( &f_bin_buf, sizeof(char), 1, f_bin );
		fwrite(&f_bin_buf,sizeof(char),1,f_rom);
	}
	if(f_bin_size%16<=15)
	{
		for( i=f_bin_size%16; i>0 && i<16 ;i++)
		{
			fwrite(&tmp,1,1,f_rom);
		}

	}

}

void romfs_img()
{
///////////////////////////////////////////////////////////////////////
	//ROMFS.img size=0x0028.0000 : 0x0014.0000~0x003b.ffff 
	
	for( i=0;i<f_img_size;i++)
	{
		fread( &f_img_buf, sizeof(char), 1, f_img );
		fwrite(&f_img_buf,sizeof(char),1,f_rom);
	}
	if(f_img_size%16<=15)
	{
		for( i=f_img_size%16; i>0 && i<16 ;i++)
		{
			fwrite(&tmp,1,1,f_rom);
		}
	}

}

void b_bin()
{
///////////////////////////////////////////////////////////////////////
	//ROMFS.img size=0x0028.0000 : 0x0014.0000~0x003b.ffff 
	
	for(i=0;i<f_b_size;i++)
	{
		fread( &f_b_buf, sizeof(char), 1, f_b );
		fwrite(&f_b_buf,sizeof(char),1,f_rom);
	}
	for(i=0 ; i < 128*1024-16-f_b_size ;i++)
	{
		fwrite(&tmp,1,1,f_rom);
	}

}

int main(int argc, char *argv[])
{
	errflg=false;
	linuxflg=false;
	romfsflg=false;
	bflg=false;
	oflg=false;
	aflg=false;

    printf("*****************************************************\n");
    printf("**   COMPOSER32  Utility V1.01                     **\n");
    printf("**   (C) 2003 ATOP Tech. Inc. All rights reserved  **\n");
    printf("*****************************************************\n");


	i=argc-1;
	do
	{
		if(argv[i][0]=='-')
		{
			switch(argv[i][1])
			{
			case 'l':
			case 'L':
				linuxflg=true;
				break;
			case 'r':
			case 'R':
				romfsflg=true;
				break;
			case 'b':
			case 'B':
				bflg=true;	
				break;
			case 'o':
			case 'O':
				oflg=true;
				break;
			case 'a':
			case 'A':
				aflg=true;
				break;
				

			default:
				errflg=true;
				break;
			}
		}

	i--;
	}while(i>0);



    int k;
	if(argc>2)
	{
		if(linuxflg && romfsflg)
		{
			
			
			//f_rom=fopen(argv[3],"wb");
			if((f_bin=fopen(argv[1],"rb"))==NULL)
			{
				printf( "%s not found\n", argv[1]);
				goto exit;
			}
			if((f_img=fopen(argv[2],"rb"))==NULL)
			{
				printf( "%s not found\n", argv[2]);
				fclose(f_bin);
				goto exit;
			}
			f_rom=fopen(argv[3],"wb");
			k=4;
			stat( argv[1], &buf ); 
			f_bin_size=buf.st_size;
			stat( argv[2], &buf ); 
			f_img_size=buf.st_size;
		}
		else if(linuxflg && !romfsflg)
		{
			if((f_bin=fopen(argv[1],"rb"))==NULL)
			{
				printf( "%s not found\n", argv[1]);
				goto exit;
			}
			f_rom=fopen(argv[2],"wb");
			k=3;
			stat( argv[1], &buf ); 
			f_bin_size=buf.st_size;
		}
		else if(!linuxflg && romfsflg)
		{
			
			if((f_img=fopen(argv[1],"rb"))==NULL)
			{
				printf( "%s not found\n", argv[1]);
				goto exit;
			}
			f_rom=fopen(argv[2],"wb");
			k=3;
			stat( argv[1], &buf ); 
			f_img_size=buf.st_size;
		}
		else if(aflg||bflg||oflg)
		{
			if((f_b=fopen(argv[1],"rb"))==NULL)
			{
				printf( "%s not found\n", argv[1]);
				goto exit;
			}
			f_rom=fopen(argv[2],"wb");
			k=3;
			stat( argv[1], &buf ); 
			f_b_size=buf.st_size;
		}

		//
		for(i=0;i<32;i++)
		{
			fwrite(&tmp,1,1,f_rom);
		}

		//if((k==4 && argc==10)||(k==3 && argc==8))
		//{
			linux_sdram=atol(argv[argc-4])<<16;
			linux_flash=atol(argv[argc-3])<<16;
			romfs_sdram=atol(argv[argc-2])<<16;
			romfs_flash=atol(argv[argc-1])<<16;
		//}
		/*else
		{
			printf("Parameter error\n",k);
			goto exit;
		}*/
		

		if(linuxflg && romfsflg)
		{	
			linuxfat(linux_sdram,linux_flash);
			romfsfat(romfs_sdram,romfs_flash);
			linux_bin();			
			///////////////////////////////////////////////////////////////////////	
			//16-byte Magic String : 0x0000.0000~0x0000.000f
			if(argv[k][0]=='-')
			{
				fwrite("ATOP Tech. Inc.",sizeof(char),15,f_rom);
				fwrite(&tmp,1,1,f_rom);
			}
			else
			{
				int j;
				for(j=0;j<16;j++)//count of argv[1]
				{
					if(argv[k][j]<=0x0f)
						break;
				}
				fwrite(argv[k],sizeof(char),j,f_rom);
							if(j<=15)
				{
					for(i=0;i<16-j;i++)
					{
						fwrite(&tmp,1,1,f_rom);
					}
				}
			}

			///////////////////////////////////////////////////////////////////////	
			for(i=0;i<32;i++)
			{
				fwrite(&tmp,1,1,f_rom);
			}
			///////////////////////////////////////////////////////////////////////				
			linuxfat(linux_sdram,linux_flash);
			romfsfat(romfs_sdram,romfs_flash);
			romfs_img();

		}
		else if(linuxflg && !romfsflg)
		{
			linuxfat(linux_sdram,linux_flash);
			romfsfat(romfs_sdram,romfs_flash);
			linux_bin();
		}
		else if(!linuxflg && romfsflg)
		{
			linuxfat(linux_sdram,linux_flash);
			romfsfat(romfs_sdram,romfs_flash);
			romfs_img();
		}
		else if(aflg)
		{
			fclose(f_rom);		
			f_rom=fopen(argv[2],"wb");
			b_bin();
		}
		else if(bflg||oflg)
		{
			fclose(f_rom);		
			f_rom=fopen(argv[2],"wb");
			for( i=0;i<16;i++)
			{
				fwrite(&tmp,1,1,f_rom);
			}
			bfat(linux_sdram,linux_flash);
			for( i=0;i<32;i++)
			{
				fwrite(&tmp,1,1,f_rom);
			}
			b_bin();
		}


			///////////////////////////////////////////////////////////////////////	
			//16-byte Magic String : 0x0000.0000~0x0000.000f
			if(argv[k][0]=='-')
			{
				fwrite("ATOP Tech. Inc.",sizeof(char),15,f_rom);
				fwrite(&tmp,1,1,f_rom);
			}
			else
			{
				int j;
				for(j=0;j<16;j++)//count of argv[1]
				{
					if(argv[k][j]<=0x0f)
						break;
				}
				fwrite(argv[k],sizeof(char),j,f_rom);
							if(j<=15)
				{
					for(i=0;i<16-j;i++)
					{
						fwrite(&tmp,1,1,f_rom);
					}
				}
			}
		if(linuxflg && romfsflg )
		{
			fclose(f_rom);
			fclose(f_bin);
			fclose(f_img);
		}
		else if(linuxflg && !romfsflg)
		{
			fclose(f_rom);
			fclose(f_bin);
		}
		else if(!linuxflg && romfsflg)
		{
			fclose(f_rom);
			fclose(f_img);
		}
		else if(aflg||bflg)
		{
			fclose(f_rom);
			fclose(f_b);
		}

	}
	else
	{
		print_usage();
	}
exit: 
	  return 0;
}