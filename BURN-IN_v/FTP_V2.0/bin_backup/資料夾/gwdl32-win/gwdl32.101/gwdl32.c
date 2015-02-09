#include <stdlib.h>

#include	<stdio.h>
//#include	  <dos.h>
#include	<string.h>
#include    <windows.h>
//#include <conio.h>
#include	"dapdldef.h"
#include    <memory.h>
//#include    <process.h>   /* for _beginthread			    */
#include <sys/stat.h>

//---------------------------------------------------------------------------
long GetIPaddr( char *) ;
int GetCodeName( stream, code, cod_len, name, nam_len);
int SendActive();
int SendMAGIC();
int SendDATA(int);

//---------------------------------------------------------------------------

char list1[1024];
char myidpwd[80];
int readpoint=0;
int handle;
int connect_f = _ERR ;
int send_f = _ERR ;
int recv_f = _ERR ;
int recv_len = 0 ;
int err_code = _EXIT_ERR_1 ;
unsigned char	recvbuf[DEF_MSS];
unsigned char	sendbuf[DEF_MSS];
int activeflag=0;

DL_STRUCT  dlccb ;
FILE	*fdcfg= NULL ;
FILE	*fdrom= NULL ;
FILE    *fdrom1= NULL ;
extern int wsk_ini() ;		   /* ret=0: ok, else: err */
extern int wsk_connect( unsigned short local_port, char *remote_ip, unsigned short remote_port);
extern int wsk_disconnect( int handle) ;
extern int HexProcess() ;
extern int SendEndCmd(int is_old) ;
extern char magic[16];
extern int resetflg;
int romsize,tmpsize;
struct stat buf;
int z;
long download_port;



//---------------------------------------------------------------------------
void print_usage()
{
		printf ( "Usage     : gwdl32 xxx.xxx.xxx.xxx filename username password\n" ) ;
		printf ( "Example   : gwdl32 10.0.50.100 linux.dld admin\n" ) ;
		printf ( "\r\n");
}
void get_password(char *pwd)
{
	char ch=0x00;
	int idx=0;
    printf("Password:");
	while(1)
	{
		ch=_getch();

		if((ch==0x0d)||(ch==0x0a)) break;
		if(ch==0x08)
		{
			if(idx>0)
			{
				printf("%c %c",0x08,0x08);
				idx--;
			}
		}else
		{
			printf("*");
			*(pwd+idx)=ch;
			idx++;
		}
	}
	printf("\n");
    *(pwd+idx)=0x00;
}

void get_userid(char *id)
{
	char ch=0x00;
	int idx=0;
    printf("Userid:");
	while(1)
	{
		ch=_getch();

		if(ch==0x0d) break;
		if(ch==0x08)
		{
			if(idx>0)
			{
				printf("%c %c",0x08,0x08);
				idx--;
			}
		}else
		{
			printf("%c",ch);
			*(id+idx)=ch;
			idx++;
		}
	}
	printf("\n");
    *(id+idx)=0x00;
}

void main( argc, argv )
int argc;
char *argv[];
{
    int     is_oldprotocol=0;
    int     dl_files = 0 ;
    long    remote_ip ;
	int     val,len ;

	int     iscfgfile=0;
	int     isyes_no=0;
	int     isforce_old=0;
	int     isargerror=0;

    int     paracnt;
	char    paraip[256];
	char    pararomfile[256];
	char    paraid[32];
	char    parapwd[32];
	int     i;
	char    ch;
    int     openromfail=0;

    printf("*****************************************************\n");
    printf("**   GWDL32 Download Utility V1.01                 **\n");
    printf("**   (C) 2003 ATOP Tech. Inc. All rights reserved  **\n");
    printf("*****************************************************\n");

	if(argc>2)
	{
		stat( argv[2], &buf ); 
		romsize=buf.st_size;
		tmpsize=romsize;
		//printf("%d",romsize);
	}

	i=argc-1;
	do
	{
		if(argv[i][0]!='-') 
		{
			paracnt=i;
			break;
		}else 
		{
			switch(argv[i][1])
			{
			case 'o':
			case 'O':
				isforce_old=1;
				break;
			case 'p':
			case 'P':
				//download_port=atol(argv[i+1]);
				//port_flg=TRUE;
				break;
			default:
				isargerror=1;
				break;
			}
			i--;
		}
	}while(i>0);

	if (( paracnt ==0 )||(isargerror)) 
	{
        print_usage();
		err_code = _EXIT_ERR_2 ;
		exit(err_code) ;
    }
reset:
    switch(paracnt)
	{

	case 2:   //gwdl ip_addr rom_file
	    strcpy(&paraip[0],argv[1]);
		strcpy(&pararomfile[0],argv[2]);
		strcpy(&paraid[0],"");
		strcpy(&parapwd[0],"");
		break;
	case 3:   //gwdl ip_addr rom_file userid
		      //the password will be set as null string 
	    strcpy(&paraip[0],argv[1]);
		strcpy(&pararomfile[0],argv[2]);
		strcpy(&paraid[0],argv[3]);
		strcpy(&parapwd[0],"");
		break;
	case 4:   //gwdl ip_addr rom_file userid password
	    strcpy(&paraip[0],argv[1]);
		strcpy(&pararomfile[0],argv[2]);
		strcpy(&paraid[0],argv[3]);
		strcpy(&parapwd[0],argv[4]);
		break;
	}


    if(isyes_no)
	{
		printf("Donload romfile %s to %s? (y/n)",pararomfile,paraip);
	    ch=_getch();
		printf("\r\n");
		if((ch!='y')&&(ch!='Y')) 
		{
			return;
		}
	}

/////////////////////////////////////////////////////////////////////////

    printf ( "\nConnecting %s", paraip ) ;
    remote_ip = GetIPaddr( paraip ) ;
    printf (" (%lx)\n", remote_ip ) ;

    connect_f = _PENDING ;

    if (wsk_ini()) {
		err_code = _EXIT_ERR_3 ;
		exit(err_code);
    }

	//if(port_flg=TRUE)
	//	handle = wsk_connect( 0, paraip, download_port);
	//else
		handle = wsk_connect( 0, paraip, DL_PORT) ;
    
	if ( handle<0) {
			err_code = _EXIT_ERR_3 ;
			exit(err_code);
	}
	connect_f = _OK ;
	memset(myidpwd,0,sizeof(myidpwd));

    if((strlen(paraid)==0))
	{
		if(isforce_old==0)
		{
			get_userid(&myidpwd[0]);
			len=strlen(myidpwd);
			if(len>0)	
			{
				myidpwd[len]=' ';
				get_password(&myidpwd[len+1]);
			}else
			{
				get_userid(&myidpwd[0]);
				len=strlen(myidpwd);
				if(len>0)	
				{
					myidpwd[len]=' ';
					get_password(&myidpwd[len+1]);
				}
			}
		}
	}else
	{
		sprintf(myidpwd,"%s %s",paraid,parapwd);
	}

    if((isforce_old)||(strlen(myidpwd)==0))
	{
        is_oldprotocol=1;  //no userid and password was inputed
	}else
	{
		is_oldprotocol=0;
	}
		
	if(is_oldprotocol)
	{
	    activeflag=1;
	}else 
	{
		if((fdrom1=fopen(argv[2],"rb"))==NULL)
		{
			printf( "%s not found\n", argv[2]);

		}
		else
		{
		fseek( fdrom1,tmpsize-16,SEEK_SET);
		fread( &magic, sizeof(char), 16, fdrom1);
		fclose(fdrom1);
		}
		SendMAGIC();
		if(resetflg==1)
		{
			int z;
			printf("Connect again");
			for(z=0;z<8;z++)
			{
				printf(".");
				Sleep(1300);
			}
			resetflg=0;
            wsk_disconnect(handle);
			goto reset;
		}
		val=SendActive();
		

		if(val==_ERR)
		{
			int kk;
			wsk_disconnect(handle);
			
			/*printf("Connect again");
			for(kk=0;kk<8;kk++)
			{
				printf(".");
				//Sleep(1000);
			}*/
			//goto reset;
		}else
		{
       		activeflag=1;
		}
	}
	
    for ( ; ; ) 
	{
		

		if ( connect_f == _ERR ) {
			wsk_disconnect(handle);
			if ( fdcfg != NULL )fclose( fdcfg ) ;
			if ( fdrom != NULL ) fclose(fdrom) ;
			err_code = _EXIT_ERR_4 ;
			exit( err_code ) ;
		}

		if(iscfgfile)  //if(dl_files==0) means alreay read a file into pararomfile
		{
			if((openromfail)||(dl_files>0))
			{
				if ( (GetCodeName( fdcfg, "Load", 4, pararomfile, 200 ) != _OK) || (dl_files >= _MAX_FILES) ) {
					printf( "\nTotal %d files downloaded\n", dl_files) ;
					if ( dl_files ) SendEndCmd(is_oldprotocol) ;
					wsk_disconnect(handle);
					fclose( fdcfg ) ;
					err_code = _OK ; //ok
					exit( err_code ) ;
				}
			}
		}else if(dl_files>0)
		{
			printf( "\nTotal %d files downloaded\n", dl_files) ;
			if ( dl_files ) SendEndCmd(is_oldprotocol) ;
			wsk_disconnect(handle);
			err_code = _OK ; //ok
			exit( err_code ) ;
		}

        openromfail=0;
 		if (( fdrom= fopen( pararomfile, "rb")) == NULL)  {
			printf( "%s not found\n", pararomfile) ;
			if(iscfgfile)
			{
				openromfail=1;
				continue ;
			}else
			{
				print_usage();
				err_code = _EXIT_ERR_2 ; //ok
				exit( err_code ) ;                 
			}
		}
		dl_files ++ ;
    
		if(activeflag==1)
		{
			//fdrom= fopen( pararomfile, "r");
			printf ( "\nDownloading %s\n", pararomfile ) ;
			//fread( list1, sizeof(char), romsize, fdrom );
			//send(handle,list1,romsize,0);  
			//printf("%d",romsize);
			do
			{
				fseek(fdrom,readpoint,SEEK_SET);
				if(romsize<_SEND_DATA_LEN)
				{
					fread( &list1, sizeof(char), romsize, fdrom );
					SendDATA(romsize);
					romsize-=_SEND_DATA_LEN;
				}
				else
				{
					fread( &list1, sizeof(char), _SEND_DATA_LEN, fdrom );
					SendDATA(_SEND_DATA_LEN);	
					romsize-=_SEND_DATA_LEN;
				}
				//printf("%d\n",readpoint);
				readpoint+=_SEND_DATA_LEN;
				//printf("...%d%c",(readpoint*100/tmpsize),'%');
				printf(".");
				
				//printf("%d\n",romsize);
			}while(romsize>0);


		}
		fclose ( fdrom ) ;
		fdrom = NULL ;
    }
}
//---------------------------------------------------------------------------
int GetCodeName( stream, code, cod_len, name, nam_len)
FILE *stream ;
char *code ;	 /* pointer to reason code string with no NULL */
int  cod_len ;	 /* length of code */
char *name ;	 /* copy <name> to *name fill blank if lenth < nam_len */
int  nam_len ;	 /* length of name */
{
   char  buf[256], *data, *ptr ;
   register int i, len ;

   while( NULL != fgets( buf, 256, stream)) {

	data = buf ;
	for ( ; *data==' '; data++) ;

	ptr = code ;
	for ( i=cod_len-1; i>=0 && (*data && *data!=' '); i--,data++,ptr++)
	if ( *data != *ptr) goto next ;

	if ( i<0) {
	    if ( *data != ' ') continue ;
	}
	else {
	    if ( *ptr != ' ') continue ;
	}

	for ( ; *data==' '; data++) ;

	len = strlen( data);				     /* 06/06/91*/
	if ( len==0) goto end ;

	if (data[ len -1] == '\r' || data[ len -1] == '\n')  /*  O'neil */
	    len--; /* skip the last char.: '\r', '\n' */

//	if( len < nam_len) {
//	    memcpy( name, data, len) ;
//	    memset( name + len, ' ', nam_len - len) ;
//	}
//	else {
//	   memcpy( name, data, nam_len) ;
//	}
	memcpy( name, data, len) ;
	name[len] = 0 ;
	return( _OK ) ;
next:
	continue ;
    }
end:
    return( _ERR ) ;
}
//---------------------------------------------------------------------------
long GetIPaddr( buf )
char	*buf ;
{
    long    ip_l, ip_h ;
    int     i, len ;

    len = strlen( buf) ;
    for ( i = 0 ; i < len ; i ++ ) if ( buf[i] == '.' ) buf[i] = 0 ;
    ip_l =(long)atoi(buf) & 0xff ;
    len = strlen( buf) + 1 ;
    ip_l += (long)((atoi(&buf[len])&0xff) << 8 ) ;
    len += strlen( &buf[len] ) + 1 ;
    ip_h =(long)atoi(&buf[len]) & 0xff ;
    len += strlen( &buf[len] ) + 1 ;
    ip_h += (long)((atoi(&buf[len])&0xff) << 8 ) ;
    return ( (ip_h << 16) + ip_l ) ;
}

#if 0
//---------------------------------------------------------------------------
ChkEsc()
{
    if ( kbhit() ) {
	if ( getch() == 0x1b ) {
	    SendAbortCmd() ;
	    tcp_disconnect(handle);
	    delayrou( 60,3 ) ;
	    if ( fdrom != NULL ) fclose( fdrom ) ;
	    fclose( fdcfg ) ;
	    exit( err_code ) ;
	}
    }
}
delayrou( sel, range )
int	sel, range ;
{
	union	REGS	call_regs, ret_regs ;
	int dh1,dh2;
	call_regs.x.ax=0x2c00;
	intdos( &call_regs, &ret_regs ) ;
	if( sel == 100 )  dh1 = ret_regs.x.dx & 0x00ff;
	else		  dh1 = ret_regs.x.dx >> 8 ;
	for(;;) {
		intdos( &call_regs, &ret_regs ) ;
		if( sel == 100 )  dh2 = ret_regs.x.dx & 0x00ff;
		else		  dh2 = ret_regs.x.dx >> 8 ;
		if( dh2 > dh1 && ( dh2 - dh1 >= range ) ) break;
		if( dh2 < dh1 && ( sel-dh1+dh2 >= range ) ) break;
	}
}
#endif

