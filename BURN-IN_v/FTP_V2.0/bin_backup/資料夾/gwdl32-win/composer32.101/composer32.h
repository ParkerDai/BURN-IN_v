bool errflg,linuxflg,romfsflg,bflg,oflg,aflg;
FILE *f_rom,*f_bin,*f_img,*f_b;
int	tmp=0xff;;
long  linux_sdram,linux_flash,romfs_sdram,romfs_flash;
int tmp2;
int f_bin_size,f_img_size=0,f_b_size=0;
char *f_bin_buf,*f_img_buf,*f_b_buf;
struct stat buf;
int i;
