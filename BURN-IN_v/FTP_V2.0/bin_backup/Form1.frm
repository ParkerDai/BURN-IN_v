VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.OCX"
Object = "{48E59290-9880-11CF-9754-00AA00C00908}#1.0#0"; "MSINET.OCX"
Begin VB.Form frmtcp 
   Caption         =   "CPU:5200  < ORT-TEST >"
   ClientHeight    =   6750
   ClientLeft      =   360
   ClientTop       =   3780
   ClientWidth     =   8700
   BeginProperty Font 
      Name            =   "新細明體"
      Size            =   15.75
      Charset         =   136
      Weight          =   700
      Underline       =   0   'False
      Italic          =   0   'False
      Strikethrough   =   0   'False
   EndProperty
   Icon            =   "Form1.frx":0000
   MaxButton       =   0   'False
   OLEDropMode     =   1  '手動
   ScaleHeight     =   6750
   ScaleWidth      =   8700
   Begin VB.CommandButton cmdToCmdAPFile 
      BackColor       =   &H00C0FFC0&
      Caption         =   "To Cmd File (AP)"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5160
      Style           =   1  '圖片外觀
      TabIndex        =   32
      Top             =   6120
      Width           =   3375
   End
   Begin VB.CommandButton cmdDefault 
      BackColor       =   &H00FFFFC0&
      Caption         =   "Set to Default"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   5160
      Style           =   1  '圖片外觀
      TabIndex        =   9
      Top             =   2280
      Width           =   2172
   End
   Begin VB.CommandButton cmdCallFTP 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Call FTP tool"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   5160
      Style           =   1  '圖片外觀
      TabIndex        =   31
      Top             =   3480
      Width           =   3375
   End
   Begin VB.Timer Timer55 
      Left            =   4920
      Top             =   6600
   End
   Begin VB.TextBox txtUser 
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
      Left            =   5880
      TabIndex        =   28
      Text            =   "admin"
      Top             =   7920
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.TextBox txtPass 
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
      Left            =   5880
      TabIndex        =   27
      Top             =   8400
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.CommandButton cmdDownload 
      Caption         =   "載入測試檔案"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   1920
      TabIndex        =   26
      Top             =   8040
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.CommandButton cmdConnect 
      BackColor       =   &H00C0FFFF&
      Caption         =   "開始"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   600
      Left            =   2400
      Style           =   1  '圖片外觀
      TabIndex        =   25
      Top             =   7920
      Visible         =   0   'False
      Width           =   1845
   End
   Begin VB.CommandButton cmdDisconnect 
      BackColor       =   &H00C0C0FF&
      Caption         =   "中斷"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   600
      Left            =   240
      Style           =   1  '圖片外觀
      TabIndex        =   24
      Top             =   7920
      Visible         =   0   'False
      Width           =   1845
   End
   Begin InetCtlsObjects.Inet Inet1 
      Left            =   7920
      Top             =   6120
      _ExtentX        =   1005
      _ExtentY        =   1005
      _Version        =   393216
   End
   Begin VB.CommandButton cmdCalltest 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Call Test tool"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   5160
      Style           =   1  '圖片外觀
      TabIndex        =   22
      Top             =   4440
      Width           =   3375
   End
   Begin VB.CommandButton cmdFTP 
      BackColor       =   &H0080C0FF&
      Caption         =   "Download test file"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   5160
      Style           =   1  '圖片外觀
      TabIndex        =   20
      Top             =   2280
      Visible         =   0   'False
      Width           =   2175
   End
   Begin VB.ListBox lstDev 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   6540
      ItemData        =   "Form1.frx":000C
      Left            =   120
      List            =   "Form1.frx":000E
      Sorted          =   -1  'True
      TabIndex        =   19
      Top             =   120
      Width           =   4935
   End
   Begin VB.CommandButton cmdToCmdFile 
      BackColor       =   &H00C0FFC0&
      Caption         =   "To Cmd File (Kernel)"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5160
      Style           =   1  '圖片外觀
      TabIndex        =   18
      Top             =   5520
      Width           =   3375
   End
   Begin VB.ListBox lstMsgT5 
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   10.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1020
      Left            =   480
      TabIndex        =   16
      Top             =   4800
      Visible         =   0   'False
      Width           =   4095
   End
   Begin VB.ListBox lstMsgT4 
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   10.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   3840
      TabIndex        =   13
      Top             =   6600
      Visible         =   0   'False
      Width           =   975
   End
   Begin VB.CommandButton cmdStartTest 
      Caption         =   "Start Testing"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   11
      Top             =   6120
      Visible         =   0   'False
      Width           =   2172
   End
   Begin VB.ListBox lstMsg 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   960
      Left            =   120
      TabIndex        =   10
      Top             =   7320
      Visible         =   0   'False
      Width           =   8415
   End
   Begin VB.ListBox lstMsgT3 
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   10.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   3840
      TabIndex        =   7
      Top             =   6120
      Visible         =   0   'False
      Width           =   975
   End
   Begin VB.CommandButton cmdChgIP 
      BackColor       =   &H00FFFFC0&
      Caption         =   "Change IP"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   5160
      Style           =   1  '圖片外觀
      TabIndex        =   6
      Top             =   1200
      Width           =   2172
   End
   Begin VB.CommandButton cmdStopTest 
      Caption         =   "Stop Testing"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   240
      TabIndex        =   4
      Top             =   6600
      Visible         =   0   'False
      Width           =   2172
   End
   Begin VB.ListBox lstMsgT2 
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   10.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1020
      Left            =   120
      TabIndex        =   3
      Top             =   1440
      Visible         =   0   'False
      Width           =   4095
   End
   Begin VB.Timer Timer3 
      Enabled         =   0   'False
      Left            =   5400
      Top             =   6120
   End
   Begin VB.ListBox lstMsgT1 
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   10.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   1020
      Left            =   120
      Sorted          =   -1  'True
      TabIndex        =   2
      Top             =   240
      Visible         =   0   'False
      Width           =   4095
   End
   Begin VB.Timer Timer2 
      Enabled         =   0   'False
      Left            =   4920
      Top             =   6120
   End
   Begin MSWinsockLib.Winsock udpTest 
      Left            =   6840
      Top             =   6120
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
      Protocol        =   1
   End
   Begin VB.Timer Timer1 
      Enabled         =   0   'False
      Left            =   5880
      Top             =   6120
   End
   Begin VB.CommandButton cmdInvite 
      BackColor       =   &H00FFFFC0&
      Caption         =   "INVITE"
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   735
      Left            =   5160
      Style           =   1  '圖片外觀
      TabIndex        =   0
      Top             =   120
      Width           =   2172
   End
   Begin MSWinsockLib.Winsock udpClient 
      Left            =   6360
      Top             =   6120
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
      Protocol        =   1
      LocalPort       =   55954
   End
   Begin MSWinsockLib.Winsock tcpClient 
      Left            =   7320
      Top             =   6120
      _ExtentX        =   741
      _ExtentY        =   741
      _Version        =   393216
   End
   Begin VB.ListBox lstMsgT6 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   11.25
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   960
      Left            =   120
      TabIndex        =   23
      Top             =   2640
      Visible         =   0   'False
      Width           =   4095
   End
   Begin VB.Label lbDevDefaultCnt 
      Alignment       =   2  '置中對齊
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000040&
      Height          =   735
      Left            =   7440
      TabIndex        =   17
      Top             =   2280
      Width           =   1095
   End
   Begin VB.Label lblUser 
      Caption         =   "User Name:"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   4440
      TabIndex        =   30
      Top             =   7920
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.Label lblPassword 
      Caption         =   "Password:"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   12
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   4680
      TabIndex        =   29
      Top             =   8400
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Label lbDevDownload 
      Alignment       =   2  '置中對齊
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000040&
      Height          =   735
      Left            =   7440
      TabIndex        =   21
      Top             =   2280
      Visible         =   0   'False
      Width           =   1095
   End
   Begin VB.Label lbDevNormalCnt 
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2640
      TabIndex        =   15
      Top             =   6600
      Visible         =   0   'False
      Width           =   1095
   End
   Begin VB.Label lbDevTestCnt 
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   2640
      TabIndex        =   14
      Top             =   6120
      Visible         =   0   'False
      Width           =   1095
   End
   Begin VB.Label lbSelDevMAC 
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   5400
      TabIndex        =   12
      Top             =   8280
      Visible         =   0   'False
      Width           =   2655
   End
   Begin VB.Label lbSelDevIP 
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   10.5
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   3720
      TabIndex        =   8
      Top             =   8280
      Visible         =   0   'False
      Width           =   1575
   End
   Begin VB.Label lbDevSetCnt 
      Alignment       =   2  '置中對齊
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000040&
      Height          =   735
      Left            =   7440
      TabIndex        =   5
      Top             =   1200
      Width           =   1095
   End
   Begin VB.Label lbDevCnt 
      Alignment       =   2  '置中對齊
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Times New Roman"
         Size            =   18
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000040&
      Height          =   735
      Left            =   7440
      TabIndex        =   1
      Top             =   120
      Width           =   1095
   End
End
Attribute VB_Name = "frmtcp"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Option Explicit

Dim reset_string As String

Dim dl_counter As Integer
Private Sub clean_arp() 'Evan added 2007/10/22


Dim ip1 As String
Dim ip2 As String
Dim RetVal As Variant

    On Error Resume Next
    'RetVal = Shell("arp -d 10.0.50.100", 3)
    'RetVal = Shell("arp -d 192.168.1.1", 3)
    
    RetVal = Shell("arp -d " & ip1, 0)
    RetVal = Shell("arp -d " & ip2, 0)
'    RetVal = Shell("arp -d " & ip3, 0)
'    RetVal = Shell("arp -d " & ip4, 0)

End Sub

Private Sub sw2001_download()
'
'Dim dl_counter As Integer
'
'    Timer55.Enabled = False
'    Timer55.Interval = 1000
'    Timer55.Enabled = True
'    timer55_flg = False
'    dl_counter = 20
'Do
'
'    sleep_doevents (100)
'
'    If timer55_flg = True Then
'        dl_counter = dl_counter - 1
'        cmdDownload.Caption = dl_counter
'        cmdConnect.Enabled = False
'        cmdConnect.Caption = dl_counter
'        timer55_flg = False
'        Timer55.Enabled = True
'    End If
'
'    If dl_counter < 1 Then
'        lstStatus.Clear
'        cmdConnect1.Enabled = True
'        cmdDownload.Caption = "載入測試檔案"
'        lstStatus.FontSize = 12
'        lstStatus.ForeColor = &H80FF&
'        Exit Sub
'    End If
'
'Loop

End Sub

Private Sub cmdCallFTP_Click()
Dim tftp As Variant

'tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)

frmFTP.Show
'tftp = Shell(App.Path & "\" & "FileZilla.exe", 1)
Close

End Sub

Private Sub cmdCalltest_Click()
Dim tp As Variant

'tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)
tp = Shell(App.Path & "\" & "LoopCom1_Com8_forCPU5200_v1_0.exe", 1)
Close

End Sub


Private Sub cmdConnect_Click()
'MsgBox2 "點選成品測試的開始按鍵"
''''''''''''''''''''''''''''''''''''''''''''''''''''for WLAN quality
'lblWANquality.Visible = False
' txtOct.Visible = False
' txtHex.Text = ""
''''''''''''''''''''''''''''''''''''''''''''''''''''
'txtOct.Text = ""
'lblMonitor.Visible = True
'udpClient.Close
'Timer22.Enabled = False
'
'ftpconn = 0
'
'lstStatus.Clear
'txtReceivedataC.Text = ""
'
' On Error GoTo ConError
'    cmdConnect.Enabled = False
'
'    With Inet1
'       .RemoteHost = txtIP.Text
'       .URL = txtIP.Text
'       .Protocol = icFTP
'       .UserName = txtUser.Text
'       .Password = txtPass.Text
'    End With
'
'    strOper = "Dir"
'    Inet1.Execute , strOper
'    cmdDownload_Click
'    Exit Sub
'
'ConError:
'
'    cmdConnect.Caption = "與待測物連線"
'    cmdConnect.Enabled = True
'    cmdDisconnect.Enabled = True
End Sub

Private Sub cmdDisconnect_Click()
' MsgBox2 "點選成品測試的(FTP)中斷按鍵"
'ShowAp.Text = ""
'ShowGateway.Text = ""
'ShowIpp.Text = ""
'ShowKennel.Text = ""
'ShowMacc.Text = ""
'ShowModel.Text = ""
'ShowSubnet.Text = ""
' ftpconn = 0
' atop_timer (2000)
'   Inet1.Execute , "Quit"
'  cmdConnect.Enabled = True
End Sub

Private Sub cmdDownload_Click()

' While ftpconn = 0
' DoEvents
' Wend
'
' cmdConnect.Enabled = False
' strOper = "GetFile"
' Inet1.Execute , "Put user.sh user.sh"
'  atop_timer (500)
' Inet1.Execute , "Put atop_testd atop_testd"
'
'MsgBox "載入成功！請按-'確定鍵'後將待測物電源重新開啟!", vbOKOnly + vbExclamation, "注意"
'              cmdDisconnect_Click 'evan added
'              cmdDisconnect.Enabled = False
'              cmdDownload.Enabled = False
'              lstStatus.FontSize = 12
'              lstStatus.ForeColor = &H80FF&
'              lstStatus.AddItem "等待測物重新開機結束..."
'              cmdConnect.Enabled = False
'              sw2001_download
''              cmdConnect1_Click
'              cmdConnect1.Caption = "測試前連線"
'              'cmdConnect1.Enabled = True
'' Inet1.Execute , "Delete user.sh"
'' Inet1.Execute , "Delete atop_testd"
'' Inet1.Execute , "Put devcpp.exe devcpp.exe"
End Sub


Private Sub cmdFTP_Click()
    
'''' Dim i As Integer
'''' Dim tmpstr As String
''''
''''    On Error GoTo cmdFTP_Click99
''''    cmdToCmdFile.Enabled = True
''''    ProcStep = 1
''''    DevSetCount = 0
''''
''''    ClearDevStatus     '---add 2006/08/08
''''    ShowDevStatus
''''
''''    lstMsgT6.Clear
'''''    lbDevCnt.Caption = "" 'Evan exchange
''''
''''    For i = 0 To DevCount - 1
''''    If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then
'''''        If DA2(I, 5) = DA2(I, 13) And DA2(I, 6) = DA2(I, 14) Then   '---last 2 bytes, mac=ip
''''            DevSetCount = DevSetCount + 1                           '---this is configured ip
''''            frmtcp.cmdStartTest.Enabled = True
''''
''''            'MsgBoxT2 DA2(i, 0) & "---" & DA2(i, 1) & "---" & DA2(i, 2) & "---" & "OK"
''''            DA2(i, 21) = "Download test file OK"                   '---add 2006/08/08
''''            tmpstr = ShowDev(i)
''''            MsgBoxT6 tmpstr
''''
''''            UpdateDevListStatus i               '---add 2006/08/08
''''        Else
''''            SendConfig i                    '---set to new unique IP
''''        End If
''''    Next i
''''
''''    frmtcp.lbDevDownload.Caption = DevSetCount
''''
''''    Timer1.Interval = 10000
''''    Timer1.Enabled = True
''''    'Timer1_Timer
''''
''''    Exit Sub
''''
''''cmdFTP_Click99:
''''    MsgBox2 "cmdFTP_Click() err=" + Error
''''    Exit Sub
''''    Resume
    
End Sub

Private Sub cmdInvite_Click()
    Dim file_no As Integer
    Dim i As Integer, j As Integer

    ProcStep = 0

    '-----Initial
    InitialCmd
    
    Timer1.Enabled = False
        
    For j = 0 To DEVICE_MAX - 1
        For i = 0 To 2
            DA(j, i) = ""
        Next i
    
        For i = 0 To 20
            DA1(j, i) = ""
        Next i
    
        For i = 0 To 20
            DA2(j, i) = ""
        Next i
    Next j
        
    ShowDevStatus
    
'----- send UDP request to invite all devices------------------------------
    Dim bdata(300 - 1) As Byte
            
    On Error GoTo cmdInvite99
    
'   sleep_doevents (300000)
    
    udpClient.Close
    udpClient.LocalPort = UDP_INVITE_PORT
    udpClient.Bind
    
    udpTest.Close
    udpTest.LocalPort = UDP_TEST_PORT
    udpTest.Bind
    
    Timer1.Interval = 3000
    Timer1.Enabled = True
    Timer1_Timer
    
    Exit Sub
    
cmdInvite99:
    MsgBox2 "cmdInvite() err=" + Error
End Sub

Private Sub cmdChgIP_Click()
    Dim i As Integer
    Dim tmpstr As String

    On Error GoTo cmdChgIP_Click99
    
    clean_arp 'evan added 2007/10/23
    
    cmdToCmdFile.Enabled = True
    ProcStep = 1
    DevSetCount = 0
    
    
    ClearDevStatus     '---add 2006/08/08
    ShowDevStatus
    
    lstMsgT2.Clear
    lbDevSetCnt.Caption = ""
        
    For i = 0 To DevCount - 1
    If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then
'        If DA2(I, 5) = DA2(I, 13) And DA2(I, 6) = DA2(I, 14) Then   '---last 2 bytes, mac=ip
            DevSetCount = DevSetCount + 1                           '---this is configured ip
            frmtcp.cmdStartTest.Enabled = True
            
            'MsgBoxT2 DA2(i, 0) & "---" & DA2(i, 1) & "---" & DA2(i, 2) & "---" & "OK"
            DA2(i, 21) = "Change IP OK"                   '---add 2006/08/08
            tmpstr = ShowDev(i)
            MsgBoxT2 tmpstr
            
            UpdateDevListStatus i               '---add 2006/08/08
        Else
            SendConfig i                    '---set to new unique IP
        End If
    Next i
    
    frmtcp.lbDevSetCnt.Caption = DevSetCount

    Timer1.Interval = 10000
    Timer1.Enabled = True
    'Timer1_Timer
    
    Exit Sub
    
cmdChgIP_Click99:
    MsgBox2 "cmdChgIP_Click() err=" + Error
    Exit Sub
    Resume
End Sub

Private Sub cmdStopTest_Click()
''''    Dim i As Integer
''''    Dim tmpstr As String
''''
''''    On Error GoTo cmdStopTest_Click99
''''
''''    ProcStep = 3
''''    DevNormalCount = 0
''''
''''    lstMsgT4.Clear
''''    lbDevNormalCnt.Caption = ""
''''
''''    SendNormalMode -1                    '---broadcast to normal mode
''''
''''    frmtcp.lbDevNormalCnt.Caption = DevNormalCount
''''
''''    Timer1.Interval = 10000
''''    Timer1.Enabled = True
''''    'Timer1_Timer
''''
''''    Exit Sub
''''
''''cmdStopTest_Click99:
''''    MsgBox2 "cmdStopTest_Click() err=" + Error
''''    Exit Sub
''''    Resume
End Sub

Private Sub cmdDefault_Click()
    Dim i As Integer
    Dim tmpstr As String

    On Error GoTo cmdDefault_Click99
    
    ProcStep = 4
    DevDefaultCount = 0
    
    For i = 0 To DevCount - 1
        If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then   '---last 2 bytes, mac=ip
            SendConfigDefault i                 '---set default
        Else
            DevDefaultCount = DevDefaultCount + 1
            
            DA2(i, 21) = "Set Default IP OK"                   '---add 2006/08/08
            tmpstr = ShowDev(i)
            MsgBoxT5 tmpstr
            
            UpdateDevListStatus i               '---add 2006/08/08
        End If
    Next i
    
    frmtcp.lbDevDefaultCnt.Caption = DevDefaultCount

    Timer1.Interval = 10000
    Timer1.Enabled = True
    'Timer1_Timer
    
    Exit Sub

cmdDefault_Click99:
    MsgBox2 "cmdDefault() err=" + Error
End Sub

Private Sub cmdStartTest_Click()
'''    Dim i As Integer
'''    Dim tmpstr As String
'''
'''    On Error GoTo cmdStartTest_Click99
'''
'''    ProcStep = 2
'''    DevTestCount = 0
'''
'''    lstMsgT3.Clear
'''
'''    lbDevTestCnt.Caption = ""
'''
'''    SendRuninMode -1                    '---broadcast to run-in mode
'''
'''    frmtcp.lbDevTestCnt.Caption = DevTestCount
'''
'''    Timer1.Interval = 10000
'''    Timer1.Enabled = True
'''    'Timer1_Timer
'''
'''    Exit Sub
'''
'''cmdStartTest_Click99:
'''    MsgBox2 "cmdStartTest_Click() err=" + Error
'''    Exit Sub
'''    Resume
End Sub


Private Sub cmdToCmdAPFile_Click()
    Dim tmpstr As String, fname As String
    Dim i As Integer
    Dim tftpa As Variant
    
    On Error GoTo cmdToCmdAPFile_Click99
    
'    clean_arp
    fname = App.Path & "\cmdAP"
    If Dir(fname, vbDirectory) = "" Then
        MkDir fname
    End If
    
    For i = 0 To DevCount - 1
        fname = App.Path & "\cmdAP\" & "runAP" & CStr(i) & ".bat"
        If Dir(fname) <> "" Then
            Kill fname
        End If
        
        tmpstr = "arp -d" + Chr(13) + Chr(10) + "mpc5200_dl_v2.exe " + "-r " + "linuxall-ap.img " + DA2(i, 0) + Chr(13) + Chr(10)
        'tmpstr = "ping " + DA2(i, 0) + " -t" + Chr(13) + Chr(10)
        
        LogFile fname, tmpstr
    Next i
    
    MsgBox "OK ! Generate " + CStr(DevCount) + " command files to 'cmdAP\'"
    
'    tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)
   tftpa = Shell(App.Path & "\cmdAP\" & "runAP" & CStr(i) & ".bat", 1)

'   tftp = Shell("C:\21s_mega_runin 0717\cmd\run0.cmd", 1)
    Exit Sub
    
cmdToCmdAPFile_Click99:
    MsgBox2 "cmdToCmdAPFile_Click() err=" + Error
    Exit Sub
    Resume
End Sub

Private Sub cmdToCmdFile_Click()
    Dim tmpstr As String, fname As String
    Dim i As Integer
    Dim tftp As Variant
    
    On Error GoTo cmdToCmdFile_Click99
    
'    clean_arp
    fname = App.Path & "\cmdKernel"
    If Dir(fname, vbDirectory) = "" Then
        MkDir fname
    End If
    
    For i = 0 To DevCount - 1
        fname = App.Path & "\cmdKernel\" & "runKernel" & CStr(i) & ".bat"
        If Dir(fname) <> "" Then
            Kill fname
        End If
        
        tmpstr = "arp -d" + Chr(13) + Chr(10) + "mpc5200_dl_v2.exe " + "-l " + "linuxall-kernel.img " + DA2(i, 0) + Chr(13) + Chr(10)
        'tmpstr = "ping " + DA2(i, 0) + " -t" + Chr(13) + Chr(10)
        
        LogFile fname, tmpstr
    Next i
    
    MsgBox "OK ! Generate " + CStr(DevCount) + " command files to 'cmdKernel\'"
    
'    tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)
   tftp = Shell(App.Path & "\cmdKernel\" & "runKernel" & CStr(i) & ".bat", 1)
   
'   tftp = Shell("C:\21s_mega_runin 0717\cmd\run0.cmd", 1)
    Exit Sub
    
cmdToCmdFile_Click99:
    MsgBox2 "cmdToCmdFile_Click() err=" + Error
    Exit Sub
    Resume
End Sub

Private Sub Command1_Click()

End Sub


Private Sub Form_Load()
    frmtcp.Caption = frmtcp.Caption & " (V" & App.Major & "." & App.Minor & ")"
    
    InitialCmd
    DevCount = 0
    
    MsgBox2 "Startup"
  
End Sub

Private Sub Form_Unload(Cancel As Integer)
    If udpClient.State = 7 Then
        udpClient.Close
    End If
    
    End
End Sub

Private Sub Inet1_StateChanged(ByVal State As Integer)
' Select Case State
'
'        Case 4
'            cmdDownload.Enabled = True
'            cmdDisconnect.Enabled = True
'            txtIP.Enabled = False
'            txtUser.Enabled = False
'            txtPass.Enabled = False
'        Case 11
''            If InStr(Inet1.ResponseInfo, "No such file") > 0 Or _
''                InStr(Inet1.ResponseInfo, "No such file or directory") Then
''                txtReceivedataC.Text = "已清除測試檔案!"
''            Else
''                MsgBox Inet1.ResponseInfo
''            End If
'        Case 10
'            cmdConnect.Enabled = True
'            cmdDownload.Enabled = False
'            cmdDisconnect.Enabled = False
'            txtIP.Enabled = False
'            txtUser.Enabled = False
'            txtPass.Enabled = False
'        Case 12
'            If LCase(strOper) = "dir" Then
''                InetGetDir
'                'MsgBox "已經與主機連線！"
'                ftpconn = 1
'                cmdConnect.Enabled = False
'             cmdDisconnect.Enabled = True
'            End If
'    End Select
'    Debug.Print "狀態常數：" & State & " 訊息內容：" & Inet1.ResponseInfo
End Sub

Private Sub lstMsgT1_dblClick()
    Dim tmpstr As String
    
    tmpstr = lstMsgT1.List(lstMsgT1.ListIndex)
    reset_string = tmpstr
    
    'ShowSelectDev tmpstr
End Sub

Private Sub lstMsgT2_DblClick()
    Dim tmpstr As String
    
    tmpstr = lstMsgT2.List(lstMsgT2.ListIndex)
    reset_string = tmpstr
    
    'ShowSelectDev tmpstr
End Sub

Private Sub lstMsgT3_DblClick()
    Dim tmpstr As String
    Dim ip_ndx As Integer, mask_ndx As Integer, mac_ndx As Integer, status_ndx As Integer
   
    tmpstr = lstMsgT3.List(lstMsgT3.ListIndex)
    reset_string = tmpstr
  
    'ShowSelectDev tmpstr
End Sub

Sub ShowSelectDev(tmpstr As String)
    Dim ip_ndx As Integer, mask_ndx As Integer, mac_ndx As Integer, status_ndx As Integer
    
    ip_ndx = InStr(tmpstr, " ") + 1
    mask_ndx = InStr(tmpstr, "---") + 3
    mac_ndx = mask_ndx + InStr(Mid(tmpstr, mask_ndx), "---") + 3 - 1
    status_ndx = mac_ndx + InStr(Mid(tmpstr, mac_ndx), "---") + 3 - 1
    
    'lbSelDevIP.Caption = Trim(Mid(tmpstr, ip_ndx, mask_ndx - ip_ndx - 3))
    'lbSelDevMAC.Caption = Trim(Mid(tmpstr, mac_ndx, status_ndx - mac_ndx - 3))
End Sub

Private Sub lstMsgT4_Click()
'''    Dim tmpstr As String
'''    Dim ip_ndx As Integer, mask_ndx As Integer, mac_ndx As Integer, status_ndx As Integer
'''
'''    tmpstr = lstMsgT4.List(lstMsgT4.ListIndex)
'''    reset_string = tmpstr
'''
'''    'ShowSelectDev tmpstr
End Sub

Private Sub lstMsgT5_Click()
'    Dim tmpstr As String
'    Dim ip_ndx As Integer, mask_ndx As Integer, mac_ndx As Integer, status_ndx As Integer
'
'    tmpstr = lstMsgT5.List(lstMsgT5.ListIndex)
'    reset_string = tmpstr
    
    'ShowSelectDev tmpstr
End Sub

Private Sub lstMsgT6_Click()
    Dim tmpstr As String
    
    tmpstr = lstMsgT6.List(lstMsgT6.ListIndex)
    reset_string = tmpstr
    
End Sub

Private Sub Timer1_Timer()
    Dim bdata(300 - 1) As Byte
    Dim i As Integer
    
    On Error GoTo Timer1_Timer99
                                                
    If ProcStep = 0 Then                                              '---auto invite
        udpClient.RemoteHost = "255.255.255.255"
        udpClient.RemotePort = UDP_INVITE_PORT
        bdata(0) = 2
        bdata(1) = 1
        bdata(2) = 6
        bdata(4) = &H92
        bdata(5) = &HDA
        udpClient.SendData bdata
    
    ElseIf ProcStep = 1 Then
        If DevSetCount <> DevCount Then
        For i = 0 To DevCount - 1
            If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then   '---last 2 bytes, mac=ip
                '---already changed
            Else
                SendConfig i
            End If
        Next i
        End If
    
    ElseIf ProcStep = 2 Then
        If DevTestCount <> DevCount Then
        For i = 0 To DevCount - 1
            If DA2(i, 8) <> 2 Then
                SendRuninMode i
            End If
        Next i
        End If
    
    ElseIf ProcStep = 3 Then
        If DevNormalCount <> DevCount Then
        For i = 0 To DevCount - 1
            If DA2(i, 8) <> 3 Then
                SendNormalMode i
            End If
        Next i
        End If
    
    ElseIf ProcStep = 4 Then
        If DevDefaultCount <> DevCount Then
        For i = 0 To DevCount - 1
            If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then   '---last 2 bytes, mac=ip
                SendConfigDefault i                 '---set default
            End If
        Next i
        End If
    End If
    
    Exit Sub

Timer1_Timer99:
    MsgBox2 "Timer1() err=" + Error
End Sub

Private Sub Timer2_Timer()
    Timer2.Enabled = False
End Sub

Private Sub Timer3_Timer()
    Timer3.Enabled = False
End Sub

Private Sub Timer55_Timer()
'timer55_flg = True
'    Timer55.Enabled = False
End Sub

Private Sub udpClient_DataArrival(ByVal bytesTotal As Long)
    Dim bdata(300 - 1, 0) As Byte
    Dim tmpv As Variant
    Dim tmpstr As String
    Dim Cnt As Integer, i As Integer
    Dim tmpIP As String, tmpNetmask As String, tmpMac As String
    
    On Error GoTo udpClient_DataArrival99
    
    udpClient.GetData tmpv
        
    If VarType(tmpv) = 0 Then   '= Empty
        Exit Sub
    End If
    
    Cnt = UBound(tmpv) + 1
    
    '----- data dispatch to process different data type
    If Cnt = 300 Then           '---maybe device manager protocol
        '---tmpv(0)=1: report msg after invite, =3:ack after configuring
'       If (tmpv(0) = 1 Or tmpv(0) = 3) And tmpv(1) = 1 And tmpv(2) = 6 And tmpv(4) = &H92 And tmpv(5) = &HDA Then
        If (tmpv(0) = 1 Or tmpv(0) = 3) And tmpv(4) = &H92 And tmpv(5) = &HDA Then
            GetInviteReply tmpv
            'Exit Sub

        '---other messages are ignored
        Else
            Exit Sub
        End If
    End If
    
    If Cnt < 300 Then
        Exit Sub
    End If
    
    'If udpClient.RemoteHostIP <> txtIP Then
    '    Exit Sub
    'End If
    
    'tmpstr = ldump4(tmpv, 0, cnt)
    'MsgBoxT udpClient.RemoteHostIP & tmpstr
        
    Exit Sub
    
udpClient_DataArrival99:
    MsgBox2 "udpClient_DataArrival() err=" + Error
    Exit Sub
    Resume
End Sub

Private Sub lstMsg_DblClick()
    MsgBox lstMsg.List(lstMsg.ListIndex)
End Sub

Private Sub udpTest_DataArrival(ByVal bytesTotal As Long)
    Dim bdata(300 - 1, 0) As Byte
    Dim tmpv As Variant
    Dim tmpstr As String
    Dim Cnt As Integer, i As Integer, j As Integer
    Dim tmpIP As String, tmpNetmask As String, tmpMac As String, tmpStatus As String
    
    On Error GoTo udpTest_DataArrival99
    
    udpTest.GetData tmpv
        
    If VarType(tmpv) = 0 Then   '= Empty
        Exit Sub
    End If
    
    Cnt = UBound(tmpv) + 1
    
    '----- data dispatch to process different data type
    If tmpv(0) = 2 Then             '---maybe device reply or report message
        If tmpv(1) = 2 Then         '---reply for setting run-in mode
            tmpstr = HexOp3(tmpv, 3, 51)
            MsgBox2 "To Run-in, " + tmpstr
            
            If ProcStep = 2 Then
                'tmpMac = ""
                'For i = 0 To 5
                '    tmpMac = tmpMac + Mid(tmpstr, 1 + 2 * i, 2) + " "
                'Next i
                'tmpMac = Trim(tmpMac)
                tmpMac = Left(tmpstr, 12)
                
                For i = 0 To DevCount - 1               '---search device by MAC
                    If DA2(i, 2) = tmpMac Then
                        Exit For
                    End If
                Next i
                
                If i = DevCount Then                    '---search not found
                    MsgBox2 "To Run-in, " + "unknown MAC: " + tmpMac
                    Exit Sub
                End If
                
                If DA2(i, 8) <> ProcStep Then
                    DA2(i, 8) = ProcStep
                    DevTestCount = DevTestCount + 1
                    frmtcp.cmdStopTest.Enabled = True
                    
                    DA2(i, 21) = "Change IP OK"                   '---add 2006/08/08
                    tmpstr = ShowDev(i)
                    MsgBoxT3 tmpstr
            
                    UpdateDevListStatus i               '---add 2006/08/08
                    
                    frmtcp.lbDevTestCnt.Caption = DevTestCount
                End If
            End If
            
        ElseIf tmpv(1) = 4 Then     '---reply for setting normal mode
            tmpstr = HexOp3(tmpv, 3, 51)
            MsgBox2 "To Normal, " + tmpstr
        
            If ProcStep = 3 Then
                'tmpMac = ""
                'For i = 0 To 5
                '    tmpMac = tmpMac + Mid(tmpstr, 1 + 3 * i, 2) + " "
                'Next i
                'tmpMac = Trim(tmpMac)
                tmpMac = Left(tmpstr, 12)
                
                For i = 0 To DevCount - 1               '---search device by MAC
                    If DA2(i, 2) = tmpMac Then
                        Exit For
                    End If
                Next i
                
                If i = DevCount Then                    '---search not found
                    MsgBox2 "To Normal, " + "unknown MAC: " + tmpMac
                    Exit Sub
                End If
                
                If DA2(i, 8) <> ProcStep Then
                    DA2(i, 8) = ProcStep
                    DevNormalCount = DevNormalCount + 1
                
                    DA2(i, 21) = "Stop test OK"                   '---add 2006/08/08
                    tmpstr = ShowDev(i)
                    MsgBoxT4 tmpstr
            
                    UpdateDevListStatus i               '---add 2006/08/08
                    
                    frmtcp.lbDevNormalCnt.Caption = DevNormalCount
                End If
            End If
            
        ElseIf tmpv(1) = 5 Then     '---report device status
            tmpstr = HexOp3(tmpv, 3, 12 + 16)
            tmpMac = Left(tmpstr, 12)
            tmpStatus = Mid(tmpstr, 13)
            
            MsgBox2 "Status, " + tmpMac + ",  " + tmpStatus + ", " + StatusDesc(tmpStatus)
         
            If ProcStep = 2 Then
                For i = 0 To DevCount - 1               '---search device by MAC
                    If DA2(i, 2) = tmpMac Then
                        Exit For
                    End If
                Next i
                
                If i = DevCount Then                    '---search not found
                    MsgBox2 "In Run-in, " + "unknown MAC: " + tmpMac
                    Exit Sub
                End If
            
                For j = 0 To lstDev.ListCount - 1               '---search device by MAC
                    If Left(lstDev.List(j), 12) = tmpMac Then
                        DA2(i, 21) = Format(Date, "YYYYMMDD") + " " + Time$ + ", " + StatusDesc(tmpStatus)                 '---add 2006/08/08
                        tmpstr = ShowDev2(i, DA2(i, 21))
                        lstDev.List(j) = tmpstr
                        
                        UpdateDevListStatus i               '---add 2006/08/08
                        
                        Exit For
                    End If
                Next j
            
            End If
        
        Else
            '---other messages are ignored
            Exit Sub
        End If
    End If
    
    Exit Sub
    
udpTest_DataArrival99:
    MsgBox2 "udpTest_DataArrival() err=" + Error
    Exit Sub
    Resume
End Sub

Sub InitialCmd()
    lstMsgT1.Clear
    lbDevCnt.Caption = ""
'    lbDevDownload.Caption = "" 'evan added 2007/10/19
    DevCount = 0
    
 
    lstMsgT2.Clear
    lbDevSetCnt.Caption = ""
    DevSetCount = 0
    
'
'    lstMsgT3.Clear
'    lbDevTestCnt.Caption = ""
'    DevTestCount = 0
'
'
'    lstMsgT4.Clear
'    lbDevNormalCnt.Caption = ""
'    DevNormalCount = 0
    
    
'    lstMsgT5.Clear
'    lbDevDefaultCnt.Caption = ""
'    DevDefaultCount = 0

'    lstMsgT6.Clear 'evan added 2007/10/19
'    lbDevDownload.Caption = "" 'evan added 2007/10/19
'    DevDefaultCount = 0 'evan added 2007/10/19
    
End Sub

Function StatusDesc(status As String) As String
    Dim tmpstr As String
    
    Select Case Left(status, 4)
    Case "0101"
        tmpstr = "Flash ok"
    Case "1101"
        tmpstr = "Serial ok"
    Case "0102"
        tmpstr = "Flash failed"
    Case "2101"
        tmpstr = "Serial failed"
    Case Else
        tmpstr = "Unknown Status"
    End Select

    StatusDesc = tmpstr
End Function
