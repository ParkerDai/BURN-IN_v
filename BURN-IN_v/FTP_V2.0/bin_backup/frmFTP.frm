VERSION 5.00
Object = "{48E59290-9880-11CF-9754-00AA00C00908}#1.0#0"; "MSINET.OCX"
Begin VB.Form frmFTP 
   Caption         =   "Form1"
   ClientHeight    =   2640
   ClientLeft      =   9585
   ClientTop       =   7425
   ClientWidth     =   5430
   LinkTopic       =   "Form1"
   ScaleHeight     =   2640
   ScaleWidth      =   5430
   Begin VB.Timer Timer11 
      Left            =   240
      Top             =   1320
   End
   Begin VB.Timer Timer2 
      Left            =   240
      Top             =   720
   End
   Begin VB.CommandButton cmdEnd2 
      BackColor       =   &H00C0FFFF&
      Caption         =   "刪除檔案"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1080
      Style           =   1  '圖片外觀
      TabIndex        =   11
      Top             =   2160
      UseMaskColor    =   -1  'True
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CommandButton cmdDownload2 
      Caption         =   "載入測試檔案"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1440
      TabIndex        =   10
      Top             =   1440
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton cmdDownload 
      Caption         =   "載入測試檔案"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1920
      TabIndex        =   9
      Top             =   1440
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton cmdConnect 
      BackColor       =   &H00FFC0C0&
      Caption         =   "載檔"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   480
      Left            =   4080
      Style           =   1  '圖片外觀
      TabIndex        =   8
      Top             =   1320
      Width           =   1245
   End
   Begin VB.CommandButton cmdDisconnect 
      BackColor       =   &H00C0E0FF&
      Caption         =   "中斷"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   480
      Left            =   2640
      Style           =   1  '圖片外觀
      TabIndex        =   7
      Top             =   1320
      Width           =   1245
   End
   Begin VB.TextBox txtPass 
      Alignment       =   2  '置中對齊
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4080
      TabIndex        =   4
      Top             =   720
      Width           =   1215
   End
   Begin VB.TextBox txtUser 
      Alignment       =   2  '置中對齊
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00400040&
      Height          =   375
      Left            =   4080
      TabIndex        =   3
      Text            =   "root"
      Top             =   120
      Width           =   1215
   End
   Begin VB.TextBox txtFirstmappIp 
      Alignment       =   2  '置中對齊
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00400040&
      Height          =   405
      Left            =   480
      TabIndex        =   1
      Text            =   "10.0.50.100"
      Top             =   120
      Width           =   1815
   End
   Begin VB.CommandButton cmdEnd 
      BackColor       =   &H00C0C0FF&
      Caption         =   "刪除檔案"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   4080
      Style           =   1  '圖片外觀
      TabIndex        =   0
      Top             =   2040
      Width           =   1215
   End
   Begin InetCtlsObjects.Inet Inet1 
      Left            =   1680
      Top             =   720
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
      Protocol        =   2
      RemoteHost      =   "10.0.50.100"
      RemotePort      =   21
      URL             =   "ftp://admin@10.0.50.100"
      UserName        =   "admin"
   End
   Begin VB.Label lblUser 
      Caption         =   "User Name:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2640
      TabIndex        =   6
      Top             =   120
      Width           =   1455
   End
   Begin VB.Label lblPassword 
      Caption         =   "Password:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   2760
      TabIndex        =   5
      Top             =   720
      Width           =   1215
   End
   Begin VB.Label Label18 
      Caption         =   "IP:"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   12
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000000&
      Height          =   375
      Left            =   120
      TabIndex        =   2
      Top             =   120
      Width           =   375
   End
End
Attribute VB_Name = "frmFTP"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Dim terminal1 As Boolean
Dim test_page_counter As Integer
Dim test_rs232_flag As Integer
Const comm_output_delay = 800 'evan 50 800
Dim settint_page_counter As Long
Dim get_data As String
Dim next_mac_string As String
Dim module1_option As String
Dim module2_option As String
Dim module1_oen_port_option As String
Dim module2_oen_port_option As String
Dim ip1 As String
Dim ip2 As String
Dim ip3 As String
Dim ip4 As String
Dim lan1_timer As Integer
Dim lan_timer As Integer
Dim ur_timer As Integer
Dim time_flg As Boolean
Dim timer5_flg As Boolean
Dim xx As Integer
Dim strOper As String
Dim dl_counter As Integer
Dim timer55_flg As Boolean
Dim testcount As Integer
Dim ftpconn As Integer
Dim RcvCnt As Long
Private Sub atop_timer(input_time As Integer)
    
    Timer2.Interval = input_time
    Timer2.Enabled = True
    time_flg = False
    
    
      Timer11.Interval = input_time
    Timer11.Enabled = True
    time_flg = False
    
    Do
        DoEvents
        DoEvents
    Loop Until time_flg = True
    
End Sub

Private Sub cmdConnect_Click()
ftpconn = 0
On Error GoTo ConError
'    cmdConnect.Enabled = False

 With Inet1
       .RemoteHost = txtFirstmappIp.Text
       .URL = txtFirstmappIp.Text
       .Protocol = icFTP
       .UserName = txtUser.Text
       .Password = txtPass.Text
    End With
        strOper = "Dir"
        Inet1.Execute , strOper
        cmdDownload_Click
    Exit Sub

ConError:
'
'    MsgBox "無法與" & txtFirstmappIp.Text & "取得連線！"
'    cmdConnect.Caption = "與待測物連線"
'    cmdConnect.Enabled = True
'    cmdDisconnect.Enabled = True
End Sub

Private Sub cmdDisconnect_Click()
On Error GoTo ConError

 ftpconn = 0
 atop_timer (3000)
   Inet1.Execute , "Quit"
  cmdConnect.Enabled = True
ConError:
End Sub

Private Sub cmdDownload_Click()
While ftpconn = 0
 DoEvents
 Wend
 
' cmdConnect.Enabled = False
 strOper = "GetFile"
 Inet1.Execute , "Put user.sh /mnt/jffs2/user.sh"
'  atop_timer (800)
' Inet1.Execute , "Put atop_testd /mnt/jffs2/atop_testd"
  atop_timer (800)

'MsgBox "載入 user.sh 成功!", vbOKOnly + vbExclamation, "注意"
cmdDownload2_Click
End Sub

Private Sub cmdDownload2_Click()
While ftpconn = 0
 DoEvents
 Wend
 
' cmdConnect.Enabled = False
 strOper = "GetFile"
' Inet1.Execute , "Put user.sh /mnt/jffs2/user.sh"
'  atop_timer (800)
 Inet1.Execute , "Put atop_tcp_server /mnt/jffs2/atop_tcp_server"
  'atop_timer (800)

MsgBox "載入成功！請將待測物電源重新開啟!", vbOKOnly + vbExclamation, "注意"
End Sub


Private Sub cmdEnd_Click()
Dim i As Long
Dim tftp As Variant
Dim tmpfile As Variant

On Error GoTo ConError
'  While ftpconn = 0
'  DoEvents
'  Wend

  ftpconn = 0
  With Inet1
     .RemoteHost = txtFirstmappIp.Text
     .URL = txtFirstmappIp.Text
     .Protocol = icFTP
     .UserName = txtUser.Text
     .Password = txtPass.Text
  End With
  strOper = "Dir"
  Inet1.Execute , strOper

  While ftpconn = 0
  DoEvents
  Wend
  
Inet1.Execute , "Delete /mnt/jffs2/user.sh"
atop_timer (800)
'Inet1.Execute , "Delete /mnt/jffs2/atop_tcp_server"
'atop_timer (600)
cmdEnd2_Click

ConError:
End Sub

Private Sub Frame1_DragDrop(Source As Control, X As Single, Y As Single)

End Sub

Private Sub cmdEnd2_Click()
Dim i As Long
Dim tftp As Variant
Dim tmpfile As Variant

On Error GoTo ConError


  ftpconn = 0
  With Inet1
     .RemoteHost = txtFirstmappIp.Text
     .URL = txtFirstmappIp.Text
     .Protocol = icFTP
     .UserName = txtUser.Text
     .Password = txtPass.Text
  End With
  strOper = "Dir"
  Inet1.Execute , strOper
  
'  While ftpconn = 0
'  DoEvents
'  Wend
  
'Inet1.Execute , "Delete /mnt/jffs2/user.sh"
atop_timer (600)
Inet1.Execute , "Delete /mnt/jffs2/atop_tcp_server"
atop_timer (600)
MsgBox "刪除檔案成功！", vbOKOnly + vbExclamation, "注意"
ConError:
Exit Sub
End Sub

Private Sub Inet1_StateChanged(ByVal State As Integer)
 Select Case State
 
        Case 4
            cmdDownload.Enabled = True
            cmdDisconnect.Enabled = True
            txtFirstmappIp.Enabled = False
            txtUser.Enabled = False
            txtPass.Enabled = False
        Case 11
'            If InStr(Inet1.ResponseInfo, "No such file") > 0 Or _
'                InStr(Inet1.ResponseInfo, "No such file or directory") Then
'                txtReceivedataC.Text = "已清除測試檔案!"
'            Else
'                MsgBox Inet1.ResponseInfo
'            End If
        Case 10
            cmdConnect.Enabled = True
            cmdDownload.Enabled = False
            cmdDisconnect.Enabled = False
            txtFirstmappIp.Enabled = False
            txtUser.Enabled = False
            txtPass.Enabled = False
        Case 12
            If LCase(strOper) = "dir" Then
'                InetGetDir
                'MsgBox "已經與主機連線！"
                ftpconn = 1
'                cmdConnect.Enabled = False
             cmdDisconnect.Enabled = True
            End If
    End Select
    Debug.Print "狀態常數：" & State & " 訊息內容：" & Inet1.ResponseInfo
End Sub

Private Sub Timer11_Timer()
 time_flg = True
   Timer11.Enabled = False
End Sub

Private Sub Timer2_Timer()
   time_flg = True
    Timer2.Enabled = False
End Sub


