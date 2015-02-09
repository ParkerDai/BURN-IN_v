Module Module2



    

    ' dwAccessType: 設定Internet連結的存取方式
    Public Const INTERNET_OPEN_TYPE_PRECONFIG As Short = 0
    Public Const INTERNET_OPEN_TYPE_DIRECT As Short = 1
    Public Const INTERNET_OPEN_TYPE_PROXY As Short = 3
    Public Const INTERNET_OPEN_TYPE_PRECONFIG_WITH_NO_AUTOPROXY As Short = 4

    ' dwFlags
    Public Const INTERNET_FLAG_FROM_CACHE As Integer = &H1000000
    Public Const INTERNET_FLAG_OFFLINE As Integer = &H1000000
    Public Const INTERNET_FLAG_MAKE_PERSISTENT As Integer = &H2000000
    Public Const INTERNET_FLAG_NO_CACHE_WRITE As Integer = &H4000000
    Public Const INTERNET_FLAG_ASYNC As Integer = &H10000000
    Public Const INTERNET_FLAG_EXISTING_CONNECT As Integer = &H20000000
    Public Const INTERNET_FLAG_PASSIVE As Integer = &H8000000

    ' nServerPort：設定Internet服務之通訊埠（port）
    Public Const INTERNET_DEFAULT_FTP_PORT As Short = 21
    Public Const INTERNET_DEFAULT_GOPHER_PORT As Short = 70
    Public Const INTERNET_DEFAULT_HTTP_PORT As Short = 80
    Public Const INTERNET_DEFAULT_HTTPS_PORT As Short = 443
    Public Const INTERNET_DEFAULT_SOCKS_PORT As Short = 1080
    Public Const INTERNET_INVALID_PORT_NUMBER As Short = 0

    ' dwService：設定Internet服務類型
    Public Const INTERNET_SERVICE_FTP As Short = 1
    Public Const INTERNET_SERVICE_GOPHER As Short = 2
    Public Const INTERNET_SERVICE_HTTP As Short = 3

    ' dwInternetFlags
    Public Const FTP_TRANSFER_TYPE_ASCII As Short = &H1S ' ASCII 模式
    Public Const FTP_TRANSFER_TYPE_BINARY As Short = &H2S ' Binary模式
    Public Const FTP_TRANSFER_TYPE_UNKNOWN As Short = &H0S ' 預設為Binary模式
    Public Const INTERNET_FLAG_TRANSFER_ASCII As Short = &H1S ' ASCII 模式
    Public Const INTERNET_FLAG_TRANSFER_BINARY As Short = &H2S ' Binary模式

    Public Const FILE_ATTRIBUTE_DIRECTORY As Short = &H10S
    Public Const FILE_ATTRIBUTE_ARCHIVE As Short = &H20S

    Public Declare Function InternetOpen Lib "wininet.dll" Alias "InternetOpenA" (ByVal lpszAgent As String, ByVal dwAccessType As Integer, ByVal lpszProxyName As String, ByVal lpszProxyBypass As String, ByVal dwFlags As Integer) As Integer

    Public Declare Function InternetConnect Lib "wininet.dll" Alias "InternetConnectA" (ByVal hInternetSession As Integer, ByVal lpszServerName As String, ByVal nServerPort As Short, ByVal lpszUsername As String, ByVal lpszPassword As String, ByVal dwService As Integer, ByVal dwFlags As Integer, ByVal dwContext As Integer) As Integer
    'Private Declare Function FtpFindFirstFile Lib "wininet.dll" Alias "FtpFindFirstFileA" (ByVal hFtpSession As Long, ByVal lpszSearchFile As String, ByVal lpFindFileData As WIN32_FIND_DATA, ByVal dwFlags As Long, ByVal dwContent As Long) As Long


    Public Declare Function InternetCloseHandle Lib "wininet.dll" (ByVal hInternet As Integer) As Boolean

    Public Declare Function FtpGetCurrentDirectory Lib "Wininet.dll" Alias "FtpGetCurrentDirectoryA" (ByVal hFtpSession As Integer, ByVal lpszCurrentDirectory As String, ByRef lpdwCurrentDirectory As Integer) As Boolean

    Public Declare Function FtpGetFile Lib "wininet.dll" Alias "FtpGetFileA" (ByVal hFtpSession As Integer, ByVal lpszRemoteFile As String, ByVal lpszNewFile As String, ByVal fFailIfExists As Boolean, ByVal dwLocalFlagsAndAttributes As Integer, ByVal dwInternetFlags As Integer, ByVal dwContext As Integer) As Boolean

    Public Declare Function FtpPutFile Lib "wininet.dll" Alias "FtpPutFileA" (ByVal hFtpSession As Integer, ByVal lpszLocalFile As String, ByVal lpszNewRemoteFile As String, ByVal dwInternetFlags As Integer, ByVal dwContext As Integer) As Boolean

    Public Declare Function FtpDeleteFile Lib "wininet.dll" Alias "FtpDeleteFileA" (ByVal hFtpSession As Integer, ByVal lpszFileName As String) As Boolean
    Public Declare Function FtpSetCurrentDirectory Lib "wininet.dll" Alias "FtpSetCurrentDirectoryA" (ByVal hFtpSession As Integer, ByVal lpszDirectory As String) As Boolean
    'Public Declare Function FtpFindFirstFile Lib "wininet.dll" Alias "FtpFindFirstFileA" (ByVal hConnect As Integer, ByVal lpFindFileData As WIN32_FIND_DATA, ByVal dwFlags As Integer, ByVal dwContext As Integer) As Integer
    Public Declare Function FtpFindFirstFile Lib "Wininet.dll" Alias "FtpFindFirstFileA" (ByVal hConnect As Long, ByVal lpszSearchFile As String, ByVal lpFindFileData As Object, ByVal dwFlags As Long, ByVal dwContext As Long) As Long


End Module
