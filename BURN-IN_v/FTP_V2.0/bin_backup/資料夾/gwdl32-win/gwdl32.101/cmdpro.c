
//#include <windows.h>	   /* required for all Windows applications */
#include <winsock.h>
#include <stdio.h>	   /* for sprintf			    */
#include <string.h>	   /* for strlen			    */
#include <memory.h>
//#include <process.h>	   /* for _beginthread			    */

#include "dapdldef.h"
#define NO_FLAGS_SET	     0	/* Used with recv()/send()	    */
///////////////////////////////////////////////////
extern long GetIPaddr( char *) ;
//int GetCodeName( stream, code, cod_len, name, nam_len);
//int SendActive();


int resetflg=0;
int FileCheckSum();
extern char* list1;
extern int romsize;
extern int tmpsize;
extern print_usage();
int stradd=0;

int k;
///////////////////////////////////////////////////

#if 0
//---------------------------------------------------------------------------
void _loadds far connect_post( CMDBLK far *, void far * ) ;
void _loadds far send_post( CMDBLK far *, void far * ) ;
void _loadds far recv_post( CMDBLK far *, void far * ) ;
extern void far ChkEsc();
//---------------------------------------------------------------------------
#endif
extern char myidpwd[80];

extern int handle;
extern int connect_f ;
extern int send_f ;
extern int recv_f ;
extern int recv_len ;
extern int err_code ;
extern unsigned char   recvbuf[DEF_MSS];
extern unsigned char   sendbuf[DEF_MSS];
extern int activeflag;
extern DL_STRUCT  dlccb  ;
extern FILE    *fdrom ;
DL_STRUCT     *ptrrecv;

unsigned char rec_data[1024];
char magic[16];
//------------------------ ConvHex2Bin
unsigned char bin_value[45];
int  bin_value_count=0;
//------------------------ dlccb.dl_data counter
int dl_data_point=0;
//------------------------ sendendcmd
SEG_STRUCT seg_off_addr[_MAX_FILES];		 // store segment:offset addr.
int seg_off_point=0;			 // (segment:offset) pointer.
int num1_flag=0;			 // used get offset addr.
//------------------------ store a frame check sum
unsigned short dlccbsum=0x00;

int wsk_ini() { 	    /* ret=0: ok, else: err */
    int status; 	    /* Status Code */
    WSADATA WSAData;
    char szTemp[80];

    if ((status = WSAStartup(MAKEWORD(1,1), &WSAData)) == 0) {
//     printf( "%s,%s\n", WSAData.szDescription, WSAData.szSystemStatus);
    }
    else {
       sprintf(szTemp, "%d is the err", status);
       printf( "%s, %s\n", szTemp, "Error");
    }
    return( status) ;
}

int wsk_connect( u_short local_port, char *remote_ip, u_short remote_port)
{
    int     sock ;
    SOCKADDR_IN dest_sin;  /* DESTination Socket INternet */

    sock = socket( AF_INET, SOCK_STREAM, 0);
    if (sock == INVALID_SOCKET) {
	printf( "socket() failed\n");
	return( -1) ;
    }

    if (local_port) {
	dest_sin.sin_family = AF_INET;
	dest_sin.sin_addr.s_addr = 0 ;
	dest_sin.sin_port = htons(local_port);	/* Convert to network ordering */
	if ( bind( sock, (PSOCKADDR)&dest_sin, sizeof( dest_sin)) != 0) {
	    printf( "bind error\n") ;
	    return( -1) ;
	}
    }

    memset( (char *)&dest_sin, 0, sizeof(dest_sin)) ;
    dest_sin.sin_family = AF_INET;
    dest_sin.sin_addr.s_addr = GetIPaddr( remote_ip ) ;
    dest_sin.sin_port = htons(remote_port);  /* Convert to network ordering */

//  printf( "before connect\n") ;
//  getch() ;
//  printf( "wait to connect ...\n");
    if (connect( sock, (PSOCKADDR) &dest_sin, sizeof( dest_sin)) < 0) {
	closesocket( sock );
	printf( "connect() failed\n");
	print_usage();
	return( -1) ;
    }
//  printf( "connect() ok!\n");
//  getch() ;
    return( sock) ;
}

void wsk_disconnect( int handle)
{
    closesocket( handle);
	/*if(closesocket( handle)==0)
		printf("ok");
	else if(closesocket(handle)==SOCKET_ERROR )
		printf("error");*/
}

//*********************************************************************

int SendIDPwd()
{
    int     cnt, ret ;

	DL_STRUCT  tmpdlccb,*tmpptrrecv;
	char tmprecvbuf[1024];

#if 0
    tmpdlccb.dl_cmd=0x99;
#else
    tmpdlccb.dl_cmd=_DL_IDPWD_CMD;
#endif
	tmpdlccb.start_addr=0xffffffff;
//    tmpdlccb.dl_len=8;
//    tmpdlccb.ccb_data[tmpdlccb.dl_len]=dlccbsum;
//    tmpdlccb.ccb_data[tmpdlccb.dl_len+1]=dlccbsum>>8;

/*
	printf("\nUserid:");
	scanf("%s",myidpwd);
	len=strlen(myidpwd);
	myidpwd[len]=' ';
    get_password(&myidpwd[len+1]);
*/

	memcpy(tmpdlccb.ccb_data,myidpwd,strlen(myidpwd)+1);
    tmpdlccb.dl_len=strlen(myidpwd)+1;
    //printf("\n%s\n%d\n",myidpwd,strlen(myidpwd));
    send_f=_ERR;

    cnt = _DL_HEADER +tmpdlccb.dl_len;

    ret = send( handle, (unsigned char *)&tmpdlccb.dl_cmd, cnt, NO_FLAGS_SET );
    if (ret != cnt) {
		printf( "send error, cnt=%d, ret=%d\n", cnt, ret) ;
		connect_f=_ERR;
		return(_ERR);
    }

    ret = recv( handle ,(unsigned char far *)tmprecvbuf, sizeof(tmprecvbuf),
							NO_FLAGS_SET );
    if (ret <= 0) {
		printf( "receive error, ret=%d\n", ret) ;
		connect_f=_ERR;
		return(_ERR);
    }

    tmpptrrecv=(DL_STRUCT *)&tmprecvbuf;
    //printf("idpwd");	    
	switch(tmpptrrecv->dl_cmd)
	{
	case _DL_ACTIVE_CMD:
        if(ret!=8)printf ( "%s",tmpptrrecv->ccb_data);
		activeflag=1;

	    
	break;
	case _DL_ABORT_CMD:
		SendAbortCmd();
		wsk_disconnect(handle);
	break;

    default:
 		printf("\nDAP Response Cmd Error %d",tmpptrrecv->dl_cmd);
		err_code = _EXIT_ERR_9 ;
		connect_f=_ERR;
		return(_ERR);
    }
    return( 0) ;
}

//*********************************************************************

//*********************************************************************
int SendActive()
{
    int     cnt, ret ;
	DL_STRUCT  tmpdlccb,*tmpptrrecv;
	char tmprecvbuf[1024];

	
    tmpdlccb.dl_cmd=_DL_ACTIVE_CMD;
    tmpdlccb.dl_len=0;
	tmpdlccb.start_addr=0xffffffff;
//    tmpdlccb.ccb_data[tmpdlccb.dl_len]=dlccbsum;
//    tmpdlccb.ccb_data[tmpdlccb.dl_len+1]=dlccbsum>>8;

    send_f=_ERR;

    cnt = _DL_HEADER;

    ret = send( handle, (unsigned char *)&tmpdlccb.dl_cmd, cnt, NO_FLAGS_SET );
	//printf("send active\n");
    if (ret != cnt) {
		//printf( "send error, cnt=%d, ret=%d\n", cnt, ret) ;
		connect_f=_ERR;
		return(_ERR);
    }
    ret = recv( handle ,(unsigned char far *)tmprecvbuf, sizeof(tmprecvbuf),
							NO_FLAGS_SET );
	
	
    if (ret <= 0) {
		//printf( "receive error, ret=%d\n", ret) ;
		
		connect_f=_ERR;
		return(_ERR);
    }

    tmpptrrecv=(DL_STRUCT *)&tmprecvbuf;
    
	switch(tmpptrrecv->dl_cmd)
	{
	case _DL_IDPWD_CMD:
	    //printf("idpwd\n");
 	    if(ret!=8)printf ( "%s",tmpptrrecv->ccb_data);
	    SendIDPwd();
	break;

	case _DL_ACTIVE_CMD:
		//printf("active\n");
		if(ret!=8)printf ( "%s",tmpptrrecv->ccb_data);
		activeflag=1;
	break;
	case _DL_ABORT_CMD:
		//printf("abort\n");
		SendAbortCmd();
		wsk_disconnect(handle);
	break;

    default:
 		
		printf("\nDAP Response Cmd Error %d",tmpptrrecv->dl_cmd);
		err_code = _EXIT_ERR_9 ;
		connect_f=_ERR;
		return(_ERR);
    }
    return( 0) ;
}

int SendMAGIC()
{

	int     cnt, ret ;
	DL_STRUCT  tmpdlccb,*tmpptrrecv;
	char tmprecvbuf[1024];
    tmpdlccb.dl_cmd=_DL_MAGIC_CMD;
	//memcpy(magic,"ATOP Tech. Inc.",15);
	memcpy(tmpdlccb.ccb_data,magic,16);
	tmpdlccb.dl_len=16;
	tmpdlccb.start_addr=0xffffffff;
    //printf("\n%s\n%d\n",myidpwd,strlen(myidpwd));
	cnt = _DL_HEADER+tmpdlccb.dl_len;
    ret=send(handle,(unsigned char *)&tmpdlccb.dl_cmd,8+tmpdlccb.dl_len,0);
    if (ret != cnt) {
		//printf( "send error, cnt=%d, ret=%d\n", cnt, ret) ;
		connect_f=_ERR;
		return(_ERR);
    }
	ret=recv( handle ,(unsigned char far *)tmprecvbuf, sizeof(tmprecvbuf),
							NO_FLAGS_SET );

    if (ret <= 0) {
		//printf( "receive error, ret=%d\n", ret) ;
		
		connect_f=_ERR;
		return(_ERR);
    }

    //printf("magic\n");  
	tmpptrrecv=(DL_STRUCT *)&tmprecvbuf;
	switch(tmpptrrecv->dl_cmd)
	{
	case _DL_LINUX_CMD:
		wsk_disconnect(handle);
	    resetflg=1;
	break;
	case _DL_ABORT_CMD:
		SendAbortCmd();
		wsk_disconnect(handle);
	break;
	case _DL_MAGIC_CMD:
		memcpy(rec_data,&tmpptrrecv->ccb_data,tmpptrrecv->dl_len);
		
		if((strncmp(rec_data,tmpdlccb.ccb_data,tmpptrrecv->dl_len)>0)
			||(strncmp(rec_data,tmpdlccb.ccb_data,tmpptrrecv->dl_len)<0))
		{
			printf("Illegal magic string");
			SendEndCmd(1) ;
			wsk_disconnect(handle);
		}
		//wsk_disconnect(handle);
			
		
	break;
	


    default:
 		printf("\nDAP Response Cmd Error %d\n",tmpptrrecv->dl_cmd);
		wsk_disconnect(handle);
		err_code = _EXIT_ERR_9 ;
		connect_f=_ERR;
		return(_ERR);
    }
	return 0;
}

int SendDATA(int x)
{
	int     cnt, ret ;
	
	DL_STRUCT  tmpdlccb,*tmpptrrecv;
	char tmprecvbuf[1024];
    tmpdlccb.dl_cmd=_DL_DATA_CMD;
	
	
	tmpdlccb.dl_len=x;
	
	
	tmpdlccb.start_addr=stradd;
	stradd+=_SEND_DATA_LEN;
	memcpy(tmpdlccb.ccb_data,&list1,x);
	ret=send(handle,(unsigned char *)&tmpdlccb.dl_cmd,8+tmpdlccb.dl_len,0);
	cnt = _DL_HEADER+tmpdlccb.dl_len;
    if (ret != cnt) {
		//printf( "send error, cnt=%d, ret=%d\n", cnt, ret) ;
		connect_f=_ERR;
		return(_ERR);
    }

	ret=recv( handle ,(unsigned char far *)tmprecvbuf, sizeof(tmprecvbuf),
							NO_FLAGS_SET );
    if (ret <= 0) {
		//printf( "receive error, ret=%d\n", ret) ;
		
		connect_f=_ERR;
		return(_ERR);
    }

	tmpptrrecv=(DL_STRUCT *)&tmprecvbuf;
	switch(tmpptrrecv->dl_cmd)
	{
	case _DL_ACK_CMD:
		
	break;
	case _DL_END_CMD:

	break;


    default:
 		printf("\nDAP Response Cmd Error %d",tmpptrrecv->dl_cmd);
		err_code = _EXIT_ERR_9 ;
		connect_f=_ERR;
		return(_ERR);
    }

	//printf("DATA");
	//printf("%s\n",&list1);
	//send(handle,&list1,romsize,0);  


	return 0;
}

int SendEndCmd(int is_old)
{
	int cnt,ret;
	DL_STRUCT  tmpdlccb,*tmpptrrecv;
	char tmprecvbuf[1024];
    //printf("%d",tmpsize);
	tmpdlccb.dl_cmd=_DL_END_CMD;
	tmpdlccb.start_addr=tmpsize;
	
	tmpdlccb.dl_len=0;
	
	
	
	
	ret=send(handle,(unsigned char *)&tmpdlccb.dl_cmd,8+tmpdlccb.dl_len,0);
	cnt = _DL_HEADER;
    if (ret != cnt) {
		//printf( "send error, cnt=%d, ret=%d\n", cnt, ret) ;
		connect_f=_ERR;
		return(_ERR);
    }

	ret=recv( handle ,(unsigned char far *)tmprecvbuf, sizeof(tmprecvbuf),
							NO_FLAGS_SET );
    if (ret <= 0) {
		//printf( "receive error, ret=%d\n", ret) ;
		
		connect_f=_ERR;
		return(_ERR);
    }

	tmpptrrecv=(DL_STRUCT *)&tmprecvbuf;
	switch(tmpptrrecv->dl_cmd)
	{
	case _DL_ACK_CMD:
	case _DL_END_CMD:
		connect_f=_ERR;
		//wsk_disconnect(handle);
	break;


    default:
 		printf("\nDAP Response Cmd Error %d",tmpptrrecv->dl_cmd);
		err_code = _EXIT_ERR_9 ;
		connect_f=_ERR;
		return(_ERR);
    }

	//printf("DATA");
	//printf("%s\n",&list1);
	//send(handle,&list1,romsize,0);  


	return 0;
}


//*********************************************************************
int FileCheckSum()
{
    unsigned char now_value=0x00;
    unsigned char sum_result=0x00;
    int sum_ptr=0;

    while (sum_ptr < bin_value_count-1) { //(bin_value_count-1)->point check sum
	now_value += bin_value[sum_ptr];
	sum_ptr++;
    }
    if ((sum_result=(~now_value)+1)!=bin_value[bin_value_count-1]) {
	bin_value_count=0;
	dl_data_point=0;
	return(_ERR);    }
    else {
	return(_OK);
    }
}

//*********************************************************************

//*********************************************************************
int SendAbortCmd()
{
    int ret, cnt ;

    dlccb.dl_cmd=_DL_ABORT_CMD;
#if 0
    send_f=_ERR;
    tcp_send( handle, (unsigned char far *)&dlccb.dl_cmd, 2, send_post, (char far *)0);
    err_code = _EXIT_ERR_10 ;
#else
    cnt = 2 ;
    printf( "Send: Abort Command ...\n") ;

    ret = send( handle, (unsigned char far *)&dlccb.dl_cmd, cnt, NO_FLAGS_SET );
    if (ret != cnt) {
	printf( "send abort cmd error, cnt=%d, ret=%d\n", cnt, ret) ;
	connect_f = _ERR ;
	return( -1) ;
    }

//  ldumps( (unsigned char far *)&dlccb.dl_cmd, cnt) ;

#endif
    printf("\nAbort Downloading\n");
	return 0;
}

#if 0
//*********************************************************************
void  _loadds far  connect_post( cb, arg )
CMDBLK far  *cb;
void far *arg;
{
    if( cb->retcode != SUCCESS ) {
	connect_f = _ERR ;
	return;
    }
    connect_f = _OK;
}
//*********************************************************************
void _loadds far send_post( cb, arg )
CMDBLK	far  *cb;
void far *arg;
{
    if( cb->retcode != SUCCESS ) {
	connect_f = _ERR ;
	return;
    }
    send_f = _OK ;
}
//*********************************************************************
void _loadds far recv_post( cb, arg )
CMDBLK	far  *cb;
void far *arg;
{
    if( cb->retcode != SUCCESS ) {
	connect_f = _ERR ;
	return;
    }
    recv_len = cb->recvlen ;
    recv_f = _OK ;
}
#endif

ldumps( buf, cnt)
unsigned char *buf ;
int	cnt ;
{
    int     i ;

    if ( cnt < 0)   cnt = strlen( buf) ;
    for ( i=0; i<cnt; i++) {
	printf( "%02x ", buf[i]) ;
	if (( i&0xf) == 0xf)
	    printf( "\n") ;
    }
    printf( "\n") ;
    printf( "over\n") ;
}

