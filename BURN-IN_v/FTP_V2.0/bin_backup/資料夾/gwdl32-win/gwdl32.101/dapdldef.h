//Filename:DAPDLDEF.H	 Header file of DAP downloading utility

#define     DEF_MSS	     1024
#define     DL_PORT	     0xda90
#define     NULL_ARG	     (char far *)0
#define    _OK		      0
#define    _ERR 	      1
#define    _PENDING	      2
#define    _YES 	      0
#define    _NO		      1
#define    _EXIT_ERR_1	      1
#define    _EXIT_ERR_2	      2
#define    _EXIT_ERR_3	      3
#define    _EXIT_ERR_4	      4
#define    _EXIT_ERR_5	      5
#define    _EXIT_ERR_6	      6
#define    _EXIT_ERR_7	      7
#define    _EXIT_ERR_8	      8
#define    _EXIT_ERR_9	      9
#define    _EXIT_ERR_10       10
#define    _EXIT_ERR_11       11
#define    _EXIT_ERR_12       12
//---------------------------------------------------------------------------
typedef  struct {		     /* DL data struct */
    unsigned short  dl_cmd ;
    unsigned long   start_addr;
    unsigned short  dl_len ;
    unsigned char   ccb_data[1024] ;
} DL_STRUCT ;

typedef  struct {		     /* SEG data struct */
    unsigned long   min_addr;
    unsigned long   max_addr;
} SEG_STRUCT ;

#define     _DL_HEADER	    8
#define     _DL_SUM	    2
#define     _MAX_FILES	    60
//---------------------------------------------------------------------------
#define     _DL_DATA_CMD    0
#define     _DL_END_CMD     1
#define     _DL_ACK_CMD     2
#define     _DL_ABORT_CMD   3
#define     _DL_IDPWD_CMD   4
#define     _DL_ACTIVE_CMD   5
#define     _DL_MAGIC_CMD   6
#define     _DL_LINUX_CMD   7
//---------------------------------------------------------------------------
#define    _RECORD_ADDR       1
#define    _RECORD_TYPE       3
#define    _RECORD_DATA       4
//----------------------------------------------------------------------------
#define	   _SEND_DATA_LEN     1024
