VERSION 5.00
Object = "{248DD890-BB45-11CF-9ABC-0080C7E7B78D}#1.0#0"; "MSWINSCK.ocx"
Begin VB.Form FrmMain 
   Caption         =   "Serial Loopback"
   ClientHeight    =   10290
   ClientLeft      =   660
   ClientTop       =   645
   ClientWidth     =   14190
   Icon            =   "TCP.frx":0000
   LinkTopic       =   "Form1"
   ScaleHeight     =   10290
   ScaleWidth      =   14190
   Begin VB.TextBox txtMappingModel 
      BackColor       =   &H00C0C0FF&
      Height          =   495
      Left            =   4080
      TabIndex        =   240
      Top             =   1920
      Visible         =   0   'False
      Width           =   1575
   End
   Begin VB.TextBox TxtSendDataLentoall 
      Height          =   270
      Left            =   5760
      TabIndex        =   237
      Text            =   "1000"
      Top             =   240
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntvaltoall 
      Height          =   270
      Left            =   2760
      TabIndex        =   236
      Text            =   "100"
      Top             =   240
      Width           =   855
   End
   Begin VB.CommandButton cmdComtesttotal 
      BackColor       =   &H00FFC0FF&
      Caption         =   "Start to all"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8880
      Style           =   1  '圖片外觀
      TabIndex        =   235
      Top             =   120
      Width           =   1215
   End
   Begin VB.CommandButton cmdContotal 
      BackColor       =   &H00FFFF80&
      Caption         =   "Connect to all"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6960
      Style           =   1  '圖片外觀
      TabIndex        =   234
      Top             =   120
      Width           =   1815
   End
   Begin VB.CommandButton CmdClrCnt 
      Caption         =   "Clear Counter"
      Height          =   255
      Index           =   7
      Left            =   6720
      TabIndex        =   233
      Top             =   240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.CommandButton CmdClrCnt 
      Caption         =   "Clear Counter"
      Height          =   255
      Index           =   6
      Left            =   6240
      TabIndex        =   232
      Top             =   240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.CommandButton CmdClrCnt 
      Caption         =   "Clear Counter"
      Height          =   255
      Index           =   5
      Left            =   5760
      TabIndex        =   231
      Top             =   240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.CommandButton CmdClrCnt 
      Caption         =   "Clear Counter"
      Height          =   255
      Index           =   4
      Left            =   5280
      TabIndex        =   230
      Top             =   240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.Timer TmrSend 
      Index           =   7
      Left            =   10080
      Top             =   120
   End
   Begin VB.Timer TmrSend 
      Index           =   6
      Left            =   9720
      Top             =   120
   End
   Begin VB.TextBox TxtRcvPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   7
      Left            =   12960
      TabIndex        =   219
      Text            =   "0"
      Top             =   7620
      Width           =   855
   End
   Begin VB.TextBox TxtSendPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   7
      Left            =   12960
      TabIndex        =   218
      Text            =   "0"
      Top             =   7140
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox TxtSendPketTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   7
      Left            =   12960
      TabIndex        =   217
      Text            =   "0"
      Top             =   6660
      Width           =   855
   End
   Begin VB.TextBox TxtCntSendTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Index           =   7
      Left            =   10920
      TabIndex        =   216
      Text            =   "0"
      Top             =   6660
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSend 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   7
      Left            =   10920
      TabIndex        =   215
      Text            =   "0"
      Top             =   7140
      Width           =   1095
   End
   Begin VB.TextBox TxtCntRcv 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   7
      Left            =   10920
      TabIndex        =   214
      Text            =   "0"
      Top             =   7620
      Width           =   1095
   End
   Begin VB.TextBox TxtCntLoss 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Index           =   7
      Left            =   10920
      TabIndex        =   213
      Text            =   "0"
      Top             =   8040
      Width           =   1095
   End
   Begin VB.CommandButton CmdSendBeg 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Start COM8"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   7
      Left            =   10920
      Style           =   1  '圖片外觀
      TabIndex        =   212
      Top             =   6180
      Width           =   1215
   End
   Begin VB.TextBox TxtSendDataLen 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   7
      Left            =   12120
      TabIndex        =   211
      Text            =   "1000"
      Top             =   5760
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntval 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   7
      Left            =   12120
      TabIndex        =   210
      Text            =   "100"
      ToolTipText     =   "=0: waiting response; >0: period sending"
      Top             =   5400
      Width           =   855
   End
   Begin VB.TextBox TxtSendData 
      Height          =   375
      Index           =   7
      Left            =   10920
      TabIndex        =   209
      Top             =   8400
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.TextBox TxtRcvPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   6
      Left            =   12960
      TabIndex        =   203
      Text            =   "0"
      Top             =   4080
      Width           =   855
   End
   Begin VB.TextBox TxtSendPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   12960
      TabIndex        =   202
      Text            =   "0"
      Top             =   3600
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox TxtSendPketTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   6
      Left            =   12960
      TabIndex        =   201
      Text            =   "0"
      Top             =   3120
      Width           =   855
   End
   Begin VB.TextBox TxtCntSendTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Index           =   6
      Left            =   10920
      TabIndex        =   200
      Text            =   "0"
      Top             =   3120
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSend 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   6
      Left            =   10920
      TabIndex        =   199
      Text            =   "0"
      Top             =   3600
      Width           =   1095
   End
   Begin VB.TextBox TxtCntRcv 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   6
      Left            =   10920
      TabIndex        =   198
      Text            =   "0"
      Top             =   4080
      Width           =   1095
   End
   Begin VB.TextBox TxtCntLoss 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Index           =   6
      Left            =   10920
      TabIndex        =   197
      Text            =   "0"
      Top             =   4560
      Width           =   1095
   End
   Begin VB.CommandButton CmdSendBeg 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Start COM7"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   10920
      Style           =   1  '圖片外觀
      TabIndex        =   196
      Top             =   2640
      Width           =   1215
   End
   Begin VB.TextBox TxtSendDataLen 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   6
      Left            =   12120
      TabIndex        =   195
      Text            =   "1000"
      Top             =   2280
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntval 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   6
      Left            =   12120
      TabIndex        =   194
      Text            =   "100"
      ToolTipText     =   "=0: waiting response; >0: period sending"
      Top             =   1920
      Width           =   855
   End
   Begin VB.TextBox TxtSendData 
      Height          =   375
      Index           =   6
      Left            =   10920
      TabIndex        =   193
      Top             =   4920
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.TextBox TxtRcvPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   5
      Left            =   9840
      TabIndex        =   187
      Text            =   "0"
      Top             =   7620
      Width           =   855
   End
   Begin VB.TextBox TxtSendPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   9840
      TabIndex        =   186
      Text            =   "0"
      Top             =   7140
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox TxtSendPketTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   5
      Left            =   9840
      TabIndex        =   185
      Text            =   "0"
      Top             =   6660
      Width           =   855
   End
   Begin VB.TextBox TxtCntSendTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Index           =   5
      Left            =   7800
      TabIndex        =   184
      Text            =   "0"
      Top             =   6660
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSend 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   5
      Left            =   7800
      TabIndex        =   183
      Text            =   "0"
      Top             =   7140
      Width           =   1095
   End
   Begin VB.TextBox TxtCntRcv 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   5
      Left            =   7800
      TabIndex        =   182
      Text            =   "0"
      Top             =   7620
      Width           =   1095
   End
   Begin VB.TextBox TxtCntLoss 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Index           =   5
      Left            =   7800
      TabIndex        =   181
      Text            =   "0"
      Top             =   8040
      Width           =   1095
   End
   Begin VB.CommandButton CmdSendBeg 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Start COM6"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   7800
      Style           =   1  '圖片外觀
      TabIndex        =   180
      Top             =   6180
      Width           =   1215
   End
   Begin VB.TextBox TxtSendDataLen 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   5
      Left            =   9000
      TabIndex        =   179
      Text            =   "1000"
      Top             =   5760
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntval 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   5
      Left            =   9000
      TabIndex        =   178
      Text            =   "100"
      ToolTipText     =   "=0: waiting response; >0: period sending"
      Top             =   5400
      Width           =   855
   End
   Begin VB.TextBox TxtSendData 
      Height          =   375
      Index           =   5
      Left            =   7800
      TabIndex        =   177
      Top             =   8400
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.TextBox TxtRcvPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   4
      Left            =   9840
      TabIndex        =   171
      Text            =   "0"
      Top             =   4080
      Width           =   855
   End
   Begin VB.TextBox TxtSendPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   9840
      TabIndex        =   170
      Text            =   "0"
      Top             =   3600
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox TxtSendPketTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   4
      Left            =   9840
      TabIndex        =   169
      Text            =   "0"
      Top             =   3120
      Width           =   855
   End
   Begin VB.TextBox TxtCntSendTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Index           =   4
      Left            =   7800
      TabIndex        =   168
      Text            =   "0"
      Top             =   3120
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSend 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   4
      Left            =   7800
      TabIndex        =   167
      Text            =   "0"
      Top             =   3600
      Width           =   1095
   End
   Begin VB.TextBox TxtCntRcv 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   4
      Left            =   7800
      TabIndex        =   166
      Text            =   "0"
      Top             =   4080
      Width           =   1095
   End
   Begin VB.TextBox TxtCntLoss 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Index           =   4
      Left            =   7800
      TabIndex        =   165
      Text            =   "0"
      Top             =   4560
      Width           =   1095
   End
   Begin VB.CommandButton CmdSendBeg 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Start COM5"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   7800
      Style           =   1  '圖片外觀
      TabIndex        =   164
      Top             =   2640
      Width           =   1215
   End
   Begin VB.TextBox TxtSendDataLen 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   4
      Left            =   9000
      TabIndex        =   163
      Text            =   "1000"
      Top             =   2280
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntval 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   4
      Left            =   9000
      TabIndex        =   162
      Text            =   "100"
      ToolTipText     =   "=0: waiting response; >0: period sending"
      Top             =   1920
      Width           =   855
   End
   Begin VB.TextBox TxtSendData 
      Height          =   375
      Index           =   4
      Left            =   7800
      TabIndex        =   161
      Top             =   4920
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.TextBox TxtRcvPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   3
      Left            =   6720
      TabIndex        =   155
      Text            =   "0"
      Top             =   7620
      Width           =   855
   End
   Begin VB.TextBox TxtSendPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   6720
      TabIndex        =   154
      Text            =   "0"
      Top             =   7140
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox TxtSendPketTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   3
      Left            =   6720
      TabIndex        =   153
      Text            =   "0"
      Top             =   6660
      Width           =   855
   End
   Begin VB.TextBox TxtCntSendTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Index           =   3
      Left            =   4680
      TabIndex        =   152
      Text            =   "0"
      Top             =   6660
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSend 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   3
      Left            =   4680
      TabIndex        =   151
      Text            =   "0"
      Top             =   7140
      Width           =   1095
   End
   Begin VB.TextBox TxtCntRcv 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   3
      Left            =   4680
      TabIndex        =   150
      Text            =   "0"
      Top             =   7620
      Width           =   1095
   End
   Begin VB.TextBox TxtCntLoss 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Index           =   3
      Left            =   4680
      TabIndex        =   149
      Text            =   "0"
      Top             =   8040
      Width           =   1095
   End
   Begin VB.CommandButton CmdSendBeg 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Start COM4"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   4680
      Style           =   1  '圖片外觀
      TabIndex        =   148
      Top             =   6180
      Width           =   1215
   End
   Begin VB.TextBox TxtSendDataLen 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   3
      Left            =   5880
      TabIndex        =   147
      Text            =   "1000"
      Top             =   5760
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntval 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   3
      Left            =   5880
      TabIndex        =   146
      Text            =   "100"
      ToolTipText     =   "=0: waiting response; >0: period sending"
      Top             =   5400
      Width           =   855
   End
   Begin VB.TextBox TxtSendData 
      Height          =   375
      Index           =   3
      Left            =   4680
      TabIndex        =   145
      Top             =   8400
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.Timer TmrSend 
      Index           =   5
      Left            =   9360
      Top             =   120
   End
   Begin VB.Timer TmrSend 
      Index           =   4
      Left            =   9000
      Top             =   120
   End
   Begin VB.CommandButton CmdClrCnt 
      Caption         =   "Clear Counter"
      Height          =   255
      Index           =   3
      Left            =   4800
      TabIndex        =   128
      Top             =   240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.Timer TmrSend 
      Index           =   3
      Left            =   8640
      Top             =   120
   End
   Begin VB.Timer Timer1 
      Interval        =   1000
      Left            =   2400
      Top             =   240
   End
   Begin VB.TextBox TxtSendData 
      Height          =   375
      Index           =   2
      Left            =   4680
      TabIndex        =   115
      Top             =   4920
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.Timer TmrSend 
      Index           =   2
      Left            =   8280
      Top             =   120
   End
   Begin VB.CommandButton CmdClrCnt 
      Caption         =   "Clear Counter"
      Height          =   255
      Index           =   2
      Left            =   4320
      TabIndex        =   113
      Top             =   240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.TextBox TxtSendIntval 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   2
      Left            =   5880
      TabIndex        =   106
      Text            =   "100"
      ToolTipText     =   "=0: waiting response; >0: period sending"
      Top             =   1860
      Width           =   855
   End
   Begin VB.TextBox TxtSendDataLen 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   2
      Left            =   5880
      TabIndex        =   105
      Text            =   "1000"
      Top             =   2280
      Width           =   855
   End
   Begin VB.CommandButton CmdSendBeg 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Start COM3"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   4680
      Style           =   1  '圖片外觀
      TabIndex        =   104
      Top             =   2640
      Width           =   1215
   End
   Begin VB.TextBox TxtCntLoss 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Index           =   2
      Left            =   4680
      TabIndex        =   103
      Text            =   "0"
      Top             =   4560
      Width           =   1095
   End
   Begin VB.TextBox TxtCntRcv 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   2
      Left            =   4680
      TabIndex        =   102
      Text            =   "0"
      Top             =   4080
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSend 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   2
      Left            =   4680
      TabIndex        =   101
      Text            =   "0"
      Top             =   3600
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSendTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Index           =   2
      Left            =   4680
      TabIndex        =   100
      Text            =   "0"
      Top             =   3120
      Width           =   1095
   End
   Begin VB.TextBox TxtSendPketTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   2
      Left            =   6720
      TabIndex        =   99
      Text            =   "0"
      Top             =   3120
      Width           =   855
   End
   Begin VB.TextBox TxtSendPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   6720
      TabIndex        =   98
      Text            =   "0"
      Top             =   3600
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox TxtRcvPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   2
      Left            =   6720
      TabIndex        =   97
      Text            =   "0"
      Top             =   4080
      Width           =   855
   End
   Begin VB.TextBox TxtRcvPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   1
      Left            =   3600
      TabIndex        =   91
      Text            =   "0"
      Top             =   7560
      Width           =   855
   End
   Begin VB.TextBox TxtSendPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   3600
      TabIndex        =   90
      Text            =   "0"
      Top             =   7080
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox TxtSendPketTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   1
      Left            =   3600
      TabIndex        =   89
      Text            =   "0"
      Top             =   6600
      Width           =   855
   End
   Begin VB.TextBox TxtRcvPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   0
      Left            =   3600
      TabIndex        =   88
      Text            =   "0"
      Top             =   4080
      Width           =   855
   End
   Begin VB.TextBox TxtSendPket 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   3600
      TabIndex        =   87
      Text            =   "0"
      Top             =   3600
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.TextBox TxtSendPketTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00008080&
      Height          =   375
      Index           =   0
      Left            =   3600
      TabIndex        =   86
      Text            =   "0"
      Top             =   3120
      Width           =   855
   End
   Begin VB.TextBox TxtCntSendTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Index           =   0
      Left            =   1560
      TabIndex        =   84
      Text            =   "0"
      Top             =   3120
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSendTal 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00800000&
      Height          =   375
      Index           =   1
      Left            =   1560
      TabIndex        =   83
      Text            =   "0"
      Top             =   6600
      Width           =   1095
   End
   Begin VB.CommandButton CmdClrCnt 
      Caption         =   "Clear Counter"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   1
      Left            =   3840
      TabIndex        =   82
      Top             =   240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.Timer TmrSend 
      Index           =   1
      Left            =   7920
      Top             =   120
   End
   Begin VB.TextBox TxtCntSend 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   1
      Left            =   1560
      TabIndex        =   74
      Text            =   "0"
      Top             =   7080
      Width           =   1095
   End
   Begin VB.TextBox TxtCntRcv 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   1
      Left            =   1560
      TabIndex        =   73
      Text            =   "0"
      Top             =   7560
      Width           =   1095
   End
   Begin VB.TextBox TxtCntLoss 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Index           =   1
      Left            =   1560
      TabIndex        =   72
      Text            =   "0"
      Top             =   8040
      Width           =   1095
   End
   Begin VB.CommandButton CmdSendBeg 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Start COM2"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   120
      Style           =   1  '圖片外觀
      TabIndex        =   71
      Top             =   6120
      Width           =   1215
   End
   Begin VB.TextBox TxtSendDataLen 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   1
      Left            =   2760
      TabIndex        =   70
      Text            =   "1000"
      Top             =   5760
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntval 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   1
      Left            =   2760
      TabIndex        =   69
      Text            =   "100"
      ToolTipText     =   "=0: waiting response; >0: period sending"
      Top             =   5340
      Width           =   855
   End
   Begin VB.Timer TmrRate 
      Interval        =   1000
      Left            =   2880
      Top             =   240
   End
   Begin VB.Timer Timer2 
      Interval        =   500
      Left            =   1920
      Top             =   240
   End
   Begin VB.TextBox TxtCntLoss 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000000FF&
      Height          =   375
      Index           =   0
      Left            =   1560
      TabIndex        =   55
      Text            =   "0"
      Top             =   4560
      Width           =   1095
   End
   Begin VB.TextBox TxtCntRcv 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   0
      Left            =   1560
      TabIndex        =   53
      Text            =   "0"
      Top             =   4080
      Width           =   1095
   End
   Begin VB.TextBox TxtCntSend 
      BackColor       =   &H00C0FFFF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00FF0000&
      Height          =   375
      Index           =   0
      Left            =   1560
      TabIndex        =   51
      Text            =   "0"
      Top             =   3600
      Width           =   1095
   End
   Begin VB.CommandButton CmdSendBeg 
      BackColor       =   &H00FFC0C0&
      Caption         =   "Start COM1"
      Enabled         =   0   'False
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   120
      Style           =   1  '圖片外觀
      TabIndex        =   49
      Top             =   2640
      Width           =   1215
   End
   Begin VB.Timer TmrSend 
      Index           =   0
      Left            =   7560
      Top             =   120
   End
   Begin VB.TextBox TxtSendData 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   360
      Index           =   0
      Left            =   1560
      TabIndex        =   47
      Top             =   4920
      Visible         =   0   'False
      Width           =   2895
   End
   Begin VB.TextBox TxtSendDataLen 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   0
      Left            =   2760
      TabIndex        =   46
      Text            =   "1000"
      Top             =   2280
      Width           =   855
   End
   Begin VB.TextBox TxtSendIntval 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   315
      Index           =   0
      Left            =   2760
      TabIndex        =   45
      Text            =   "100"
      ToolTipText     =   "=0: waiting response; >0: period sending"
      Top             =   1860
      Width           =   855
   End
   Begin VB.CommandButton cmdClrList 
      BackColor       =   &H00C0C0FF&
      Caption         =   "Clear List"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Left            =   12960
      Style           =   1  '圖片外觀
      TabIndex        =   29
      Top             =   8880
      Width           =   975
   End
   Begin VB.Frame Frame1 
      Height          =   1215
      Left            =   120
      TabIndex        =   11
      Top             =   480
      Width           =   13935
      Begin VB.TextBox txtip 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   4680
         TabIndex        =   94
         Text            =   "10.0.50.100"
         Top             =   240
         Visible         =   0   'False
         Width           =   1335
      End
      Begin VB.TextBox txtip 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   4680
         TabIndex        =   225
         Text            =   "10.0.50.100"
         Top             =   720
         Visible         =   0   'False
         Width           =   1335
      End
      Begin VB.TextBox txtip 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   7560
         TabIndex        =   226
         Text            =   "10.0.50.100"
         Top             =   240
         Visible         =   0   'False
         Width           =   1335
      End
      Begin VB.TextBox txtip 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   7560
         TabIndex        =   227
         Text            =   "10.0.50.100"
         Top             =   720
         Visible         =   0   'False
         Width           =   1335
      End
      Begin VB.TextBox txtip 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   10560
         TabIndex        =   228
         Text            =   "10.0.50.100"
         Top             =   240
         Visible         =   0   'False
         Width           =   1335
      End
      Begin VB.TextBox txtip 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   10560
         TabIndex        =   229
         Text            =   "10.0.50.100"
         Top             =   720
         Visible         =   0   'False
         Width           =   1335
      End
      Begin VB.TextBox txtStatus67 
         Alignment       =   2  '置中對齊
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008000&
         Height          =   735
         Left            =   13200
         MultiLine       =   -1  'True
         TabIndex        =   144
         Top             =   360
         Width           =   495
      End
      Begin VB.CommandButton cmdCnect 
         BackColor       =   &H00C0FFC0&
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   11880
         Style           =   1  '圖片外觀
         TabIndex        =   142
         Top             =   720
         Width           =   1215
      End
      Begin VB.TextBox txtLocalPort 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   13200
         TabIndex        =   141
         Text            =   "0"
         Top             =   720
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.TextBox txtPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   7
         Left            =   11040
         TabIndex        =   140
         Text            =   "4667"
         Top             =   720
         Width           =   735
      End
      Begin VB.CommandButton cmdCnect 
         BackColor       =   &H00C0FFC0&
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   11880
         Style           =   1  '圖片外觀
         TabIndex        =   139
         Top             =   240
         Width           =   1215
      End
      Begin VB.TextBox txtLocalPort 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   13200
         TabIndex        =   138
         Text            =   "0"
         Top             =   240
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.TextBox txtPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   6
         Left            =   11040
         TabIndex        =   137
         Text            =   "4666"
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdCnect 
         BackColor       =   &H00C0FFC0&
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   8760
         Style           =   1  '圖片外觀
         TabIndex        =   135
         Top             =   720
         Width           =   1215
      End
      Begin VB.TextBox txtPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   7920
         TabIndex        =   133
         Text            =   "4665"
         Top             =   720
         Width           =   735
      End
      Begin VB.TextBox txtStatus45 
         Alignment       =   2  '置中對齊
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008000&
         Height          =   735
         Left            =   10080
         MultiLine       =   -1  'True
         TabIndex        =   132
         Top             =   360
         Width           =   495
      End
      Begin VB.CommandButton cmdCnect 
         BackColor       =   &H00C0FFC0&
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   8760
         Style           =   1  '圖片外觀
         TabIndex        =   131
         Top             =   240
         Width           =   1215
      End
      Begin VB.TextBox txtLocalPort 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   10080
         TabIndex        =   130
         Text            =   "0"
         Top             =   240
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.TextBox txtPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   4
         Left            =   7920
         TabIndex        =   129
         Text            =   "4664"
         Top             =   240
         Width           =   735
      End
      Begin VB.CommandButton cmdCnect 
         BackColor       =   &H00C0FFC0&
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   5640
         Style           =   1  '圖片外觀
         TabIndex        =   127
         Top             =   720
         Width           =   1215
      End
      Begin VB.TextBox txtPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   4800
         TabIndex        =   125
         Text            =   "4663"
         Top             =   720
         Width           =   735
      End
      Begin MSWinsockLib.Winsock Winsock1 
         Index           =   3
         Left            =   5280
         Top             =   960
         _ExtentX        =   741
         _ExtentY        =   741
         _Version        =   393216
      End
      Begin MSWinsockLib.Winsock Winsock1 
         Index           =   2
         Left            =   4800
         Top             =   960
         _ExtentX        =   741
         _ExtentY        =   741
         _Version        =   393216
      End
      Begin MSWinsockLib.Winsock Winsock1 
         Index           =   0
         Left            =   360
         Top             =   960
         _ExtentX        =   741
         _ExtentY        =   741
         _Version        =   393216
      End
      Begin MSWinsockLib.Winsock Winsock1 
         Index           =   1
         Left            =   840
         Top             =   960
         _ExtentX        =   741
         _ExtentY        =   741
         _Version        =   393216
      End
      Begin VB.TextBox txtStatus23 
         Alignment       =   2  '置中對齊
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008000&
         Height          =   735
         Left            =   6960
         MultiLine       =   -1  'True
         TabIndex        =   114
         Top             =   360
         Width           =   495
      End
      Begin VB.TextBox txtPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   4800
         TabIndex        =   96
         Text            =   "4662"
         Top             =   240
         Width           =   735
      End
      Begin VB.TextBox txtLocalPort 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   6960
         TabIndex        =   95
         Text            =   "0"
         Top             =   240
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.CommandButton cmdCnect 
         BackColor       =   &H00C0FFC0&
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   2
         Left            =   5640
         Style           =   1  '圖片外觀
         TabIndex        =   93
         Top             =   240
         Width           =   1215
      End
      Begin VB.TextBox txtStatus 
         Alignment       =   2  '置中對齊
         BackColor       =   &H00C0FFFF&
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9.75
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00008000&
         Height          =   735
         Left            =   3960
         MultiLine       =   -1  'True
         TabIndex        =   40
         Top             =   360
         Width           =   495
      End
      Begin VB.CommandButton cmdCnect 
         BackColor       =   &H00C0FFC0&
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   2640
         Style           =   1  '圖片外觀
         TabIndex        =   20
         Top             =   240
         Width           =   1215
      End
      Begin VB.CommandButton cmdCnect 
         BackColor       =   &H00C0FFC0&
         Caption         =   "Connect"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   2640
         Style           =   1  '圖片外觀
         TabIndex        =   14
         Top             =   720
         Width           =   1215
      End
      Begin VB.TextBox txtip 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   360
         TabIndex        =   18
         Text            =   "10.0.50.100"
         Top             =   240
         Width           =   1335
      End
      Begin VB.TextBox txtip 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   360
         TabIndex        =   12
         Text            =   "10.0.50.100"
         Top             =   720
         Visible         =   0   'False
         Width           =   1335
      End
      Begin VB.TextBox txtLocalPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   3960
         TabIndex        =   17
         Text            =   "0"
         Top             =   240
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.TextBox txtLocalPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   3960
         TabIndex        =   16
         Text            =   "0"
         Top             =   720
         Visible         =   0   'False
         Width           =   375
      End
      Begin VB.TextBox txtPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   0
         Left            =   1800
         TabIndex        =   19
         Text            =   "4660"
         Top             =   240
         Width           =   735
      End
      Begin VB.TextBox txtPort 
         Alignment       =   2  '置中對齊
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   1
         Left            =   1800
         TabIndex        =   13
         Text            =   "4661"
         Top             =   720
         Width           =   735
      End
      Begin VB.CommandButton cmdListen 
         Caption         =   "Listen"
         Height          =   375
         Left            =   3960
         TabIndex        =   15
         Top             =   840
         Visible         =   0   'False
         Width           =   735
      End
      Begin VB.TextBox txtLocalPort 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   3
         Left            =   7200
         TabIndex        =   126
         Text            =   "0"
         Top             =   720
         Visible         =   0   'False
         Width           =   255
      End
      Begin VB.TextBox txtLocalPort 
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   8.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   375
         Index           =   5
         Left            =   10080
         TabIndex        =   134
         Text            =   "0"
         Top             =   720
         Visible         =   0   'False
         Width           =   255
      End
      Begin MSWinsockLib.Winsock Winsock1 
         Index           =   4
         Left            =   7920
         Top             =   960
         _ExtentX        =   741
         _ExtentY        =   741
         _Version        =   393216
      End
      Begin MSWinsockLib.Winsock Winsock1 
         Index           =   5
         Left            =   8400
         Top             =   960
         _ExtentX        =   741
         _ExtentY        =   741
         _Version        =   393216
      End
      Begin MSWinsockLib.Winsock Winsock1 
         Index           =   6
         Left            =   11040
         Top             =   960
         _ExtentX        =   741
         _ExtentY        =   741
         _Version        =   393216
      End
      Begin MSWinsockLib.Winsock Winsock1 
         Index           =   7
         Left            =   11520
         Top             =   960
         _ExtentX        =   741
         _ExtentY        =   741
         _Version        =   393216
      End
      Begin VB.Label Label31 
         Caption         =   "Status :"
         Height          =   255
         Left            =   13200
         TabIndex        =   143
         Top             =   120
         Width           =   495
      End
      Begin VB.Label Label30 
         Caption         =   "Status :"
         Height          =   255
         Left            =   10080
         TabIndex        =   136
         Top             =   120
         Width           =   495
      End
      Begin VB.Label Label21 
         Caption         =   "Status :"
         Height          =   255
         Left            =   6960
         TabIndex        =   118
         Top             =   120
         Width           =   495
      End
      Begin VB.Label LabLoop 
         Caption         =   "IP"
         Height          =   255
         Index           =   2
         Left            =   4680
         TabIndex        =   116
         Top             =   600
         Visible         =   0   'False
         Width           =   735
      End
      Begin VB.Label LabLoop 
         Caption         =   "GW 2 :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   360
         TabIndex        =   68
         Top             =   720
         Visible         =   0   'False
         Width           =   855
      End
      Begin VB.Label LabLoop 
         Caption         =   "IP:"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   9
            Charset         =   0
            Weight          =   700
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         ForeColor       =   &H00000000&
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   67
         Top             =   240
         Width           =   375
      End
      Begin VB.Label Label1 
         Caption         =   "Send To GW 1 :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   0
         Left            =   120
         TabIndex        =   22
         Top             =   360
         Visible         =   0   'False
         Width           =   135
      End
      Begin VB.Label Label1 
         Caption         =   "Receive From GW 2 :"
         BeginProperty Font 
            Name            =   "Arial"
            Size            =   11.25
            Charset         =   0
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Index           =   1
         Left            =   120
         TabIndex        =   21
         Top             =   720
         Visible         =   0   'False
         Width           =   135
      End
      Begin VB.Label Label6 
         Caption         =   "Status :"
         BeginProperty Font 
            Name            =   "新細明體"
            Size            =   8.25
            Charset         =   136
            Weight          =   400
            Underline       =   0   'False
            Italic          =   0   'False
            Strikethrough   =   0   'False
         EndProperty
         Height          =   255
         Left            =   3960
         TabIndex        =   41
         Top             =   120
         Width           =   615
      End
   End
   Begin VB.OptionButton OptTcpUdp 
      Caption         =   "UDP"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   180
      Index           =   1
      Left            =   1920
      TabIndex        =   9
      Top             =   840
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.OptionButton OptTcpUdp 
      Caption         =   "TCP"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   180
      Index           =   0
      Left            =   720
      TabIndex        =   8
      Top             =   840
      Visible         =   0   'False
      Width           =   975
   End
   Begin VB.ListBox List1 
      BackColor       =   &H00C0E0FF&
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00808080&
      Height          =   1140
      Left            =   120
      Style           =   1  '項目包含核取方塊
      TabIndex        =   0
      Top             =   8880
      Width           =   12615
   End
   Begin VB.CommandButton CmdClrCnt 
      Caption         =   "Clear Counter"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   0
      Left            =   3360
      TabIndex        =   58
      Top             =   240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.TextBox TxtSendData 
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   1560
      TabIndex        =   81
      Top             =   8400
      Visible         =   0   'False
      Width           =   3015
   End
   Begin VB.OptionButton OptTestMode 
      Caption         =   "Loopback Test"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   360
      TabIndex        =   65
      Top             =   480
      Value           =   -1  'True
      Visible         =   0   'False
      Width           =   1935
   End
   Begin VB.OptionButton OptTestMode 
      Caption         =   "Cross Test"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   2640
      TabIndex        =   66
      Top             =   480
      Visible         =   0   'False
      Width           =   1935
   End
   Begin VB.CheckBox ChkXOnOff 
      Caption         =   "Don't Care Xon/off"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   390
      Left            =   5280
      TabIndex        =   92
      Top             =   480
      Value           =   1  '核取
      Visible         =   0   'False
      Width           =   2295
   End
   Begin VB.CheckBox ChkRecdAck 
      Caption         =   "ACK Access Record"
      Height          =   255
      Left            =   3120
      TabIndex        =   36
      Top             =   840
      Visible         =   0   'False
      Width           =   1935
   End
   Begin VB.CommandButton Command1 
      Caption         =   "Clear List"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   6720
      TabIndex        =   107
      Top             =   4560
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.CommandButton CmdBrow 
      Caption         =   "..."
      BeginProperty Font 
         Name            =   "Arial Black"
         Size            =   9.75
         Charset         =   0
         Weight          =   900
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   300
      Left            =   11640
      TabIndex        =   38
      Top             =   9960
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.TextBox TxtLogFile 
      Height          =   285
      Left            =   10200
      TabIndex        =   37
      Top             =   9960
      Visible         =   0   'False
      Width           =   1335
   End
   Begin VB.CheckBox ChkRemote 
      Caption         =   "Show Remote IP"
      Height          =   420
      Left            =   12240
      TabIndex        =   31
      Top             =   8760
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.TextBox txtData 
      Height          =   375
      Left            =   9360
      TabIndex        =   4
      Text            =   "D1"
      Top             =   8760
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.CommandButton cmdSend 
      Caption         =   "&Send"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   9960
      TabIndex        =   2
      Top             =   8760
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.TextBox txtDaport 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8520
      TabIndex        =   3
      Text            =   "1"
      Top             =   8760
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.TextBox txtListCnt 
      Height          =   270
      Left            =   8280
      TabIndex        =   10
      Top             =   9960
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.TextBox txtId2 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8280
      TabIndex        =   23
      Text            =   "0"
      Top             =   9480
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton cmdSend2 
      Caption         =   "S&end"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   12840
      TabIndex        =   24
      Top             =   9480
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.TextBox txtData2 
      Height          =   375
      Left            =   8760
      TabIndex        =   25
      Text            =   "\07\00\80\00\99\99R"
      Top             =   9480
      Visible         =   0   'False
      Width           =   3975
   End
   Begin VB.TextBox txtMsg 
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
      Left            =   10560
      TabIndex        =   30
      Top             =   8760
      Visible         =   0   'False
      Width           =   1575
   End
   Begin VB.TextBox TxtID 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8160
      TabIndex        =   33
      Text            =   "0"
      Top             =   8760
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.TextBox TxtSubNode 
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   9.75
         Charset         =   136
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Left            =   8880
      TabIndex        =   35
      Text            =   "01"
      Top             =   8760
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.CommandButton CmdSaveList 
      Caption         =   "Save List"
      Height          =   255
      Left            =   12120
      TabIndex        =   39
      Top             =   9960
      Visible         =   0   'False
      Width           =   1095
   End
   Begin VB.Label Label32 
      Caption         =   "Sending Interval (ms) to all :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   255
      Left            =   1920
      TabIndex        =   238
      Top             =   0
      Width           =   2055
   End
   Begin VB.Label Label33 
      Caption         =   "Sending Data Length (bytes) to all :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000080&
      Height          =   255
      Left            =   4320
      TabIndex        =   239
      Top             =   0
      Width           =   2655
   End
   Begin VB.Label Label20 
      Caption         =   "Rate: (bytes/sec)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   7
      Left            =   12120
      TabIndex        =   224
      Top             =   6660
      Width           =   735
   End
   Begin VB.Label LabRcv 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   7
      Left            =   12120
      TabIndex        =   223
      Top             =   7620
      Width           =   615
   End
   Begin VB.Label LabLoss 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   7
      Left            =   12120
      TabIndex        =   222
      Top             =   8040
      Width           =   615
   End
   Begin VB.Label Label24 
      Caption         =   "Packet No."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   7
      Left            =   12960
      TabIndex        =   221
      Top             =   6420
      Width           =   855
   End
   Begin VB.Label LabSend 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   7
      Left            =   12120
      TabIndex        =   220
      Top             =   7140
      Width           =   615
   End
   Begin VB.Label Label20 
      Caption         =   "Rate: (bytes/sec)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   12120
      TabIndex        =   208
      Top             =   3120
      Width           =   735
   End
   Begin VB.Label LabRcv 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   12120
      TabIndex        =   207
      Top             =   4080
      Width           =   615
   End
   Begin VB.Label LabLoss 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   12120
      TabIndex        =   206
      Top             =   4560
      Width           =   615
   End
   Begin VB.Label Label24 
      Caption         =   "Packet No."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   6
      Left            =   12960
      TabIndex        =   205
      Top             =   2880
      Width           =   855
   End
   Begin VB.Label LabSend 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   6
      Left            =   12120
      TabIndex        =   204
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label20 
      Caption         =   "Rate: (bytes/sec)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   5
      Left            =   9000
      TabIndex        =   192
      Top             =   6660
      Width           =   735
   End
   Begin VB.Label LabRcv 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   9000
      TabIndex        =   191
      Top             =   7620
      Width           =   615
   End
   Begin VB.Label LabLoss 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   9000
      TabIndex        =   190
      Top             =   8040
      Width           =   615
   End
   Begin VB.Label Label24 
      Caption         =   "Packet No."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   5
      Left            =   9840
      TabIndex        =   189
      Top             =   6420
      Width           =   855
   End
   Begin VB.Label LabSend 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   5
      Left            =   9000
      TabIndex        =   188
      Top             =   7140
      Width           =   615
   End
   Begin VB.Label Label20 
      Caption         =   "Rate: (bytes/sec)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   4
      Left            =   9000
      TabIndex        =   176
      Top             =   3120
      Width           =   735
   End
   Begin VB.Label LabRcv 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   9000
      TabIndex        =   175
      Top             =   4080
      Width           =   615
   End
   Begin VB.Label LabLoss 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   9000
      TabIndex        =   174
      Top             =   4560
      Width           =   615
   End
   Begin VB.Label Label24 
      Caption         =   "Packet No."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   4
      Left            =   9840
      TabIndex        =   173
      Top             =   2880
      Width           =   855
   End
   Begin VB.Label LabSend 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   4
      Left            =   9000
      TabIndex        =   172
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label20 
      Caption         =   "Rate: (bytes/sec)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   3
      Left            =   5880
      TabIndex        =   160
      Top             =   6660
      Width           =   735
   End
   Begin VB.Label LabRcv 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   5880
      TabIndex        =   159
      Top             =   7620
      Width           =   615
   End
   Begin VB.Label LabLoss 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   5880
      TabIndex        =   158
      Top             =   8040
      Width           =   615
   End
   Begin VB.Label Label24 
      Caption         =   "Packet No."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   3
      Left            =   6720
      TabIndex        =   157
      Top             =   6420
      Width           =   855
   End
   Begin VB.Label LabSend 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   3
      Left            =   5880
      TabIndex        =   156
      Top             =   7140
      Width           =   615
   End
   Begin VB.Label Label29 
      Caption         =   "Sending Data Length (bytes) :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   124
      Top             =   5760
      Width           =   2295
   End
   Begin VB.Label Label28 
      Caption         =   "Sending Interval (ms) :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   123
      Top             =   5400
      Width           =   1695
   End
   Begin VB.Label Label27 
      Caption         =   "Send Bytes :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   122
      Top             =   7080
      Width           =   1095
   End
   Begin VB.Label Label26 
      Caption         =   "Receive Bytes :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   121
      Top             =   7560
      Width           =   1215
   End
   Begin VB.Label Label25 
      Caption         =   "Total Loss :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   120
      Top             =   8040
      Width           =   975
   End
   Begin VB.Label Label23 
      Caption         =   "SendTotal Bytes :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   119
      Top             =   6600
      Width           =   1335
   End
   Begin VB.Label LabSend 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   5880
      TabIndex        =   117
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label Label24 
      Caption         =   "Packet No."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   2
      Left            =   6720
      TabIndex        =   112
      Top             =   2880
      Width           =   855
   End
   Begin VB.Label LabLoss 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   5880
      TabIndex        =   111
      Top             =   4560
      Width           =   615
   End
   Begin VB.Label Label22 
      Caption         =   "bytes/sec"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   4680
      TabIndex        =   110
      Top             =   3000
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label LabRcv 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   2
      Left            =   5880
      TabIndex        =   109
      Top             =   4080
      Width           =   615
   End
   Begin VB.Label Label20 
      Caption         =   "Rate: (bytes/sec)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   615
      Index           =   2
      Left            =   5880
      TabIndex        =   108
      Top             =   3120
      Width           =   735
   End
   Begin VB.Label Label19 
      Caption         =   "SendTotal Bytes :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   85
      Top             =   3120
      Width           =   1335
   End
   Begin VB.Label LabSend 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   2760
      TabIndex        =   80
      Top             =   7080
      Width           =   615
   End
   Begin VB.Label Label20 
      Caption         =   "Rate: (bytes/sec)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   1
      Left            =   2760
      TabIndex        =   79
      Top             =   6600
      Width           =   735
   End
   Begin VB.Label LabRcv 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   2760
      TabIndex        =   78
      Top             =   7560
      Width           =   615
   End
   Begin VB.Label LabLoss 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   2760
      TabIndex        =   76
      Top             =   8040
      Width           =   615
   End
   Begin VB.Label Label24 
      Caption         =   "Packet No."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   1
      Left            =   3600
      TabIndex        =   75
      Top             =   6360
      Width           =   855
   End
   Begin VB.Label LabLoss 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   2760
      TabIndex        =   63
      Top             =   4560
      Width           =   615
   End
   Begin VB.Label LabRcv 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   2760
      TabIndex        =   61
      Top             =   4080
      Width           =   615
   End
   Begin VB.Label Label20 
      Caption         =   "Rate: (bytes/sec)"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   6.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   495
      Index           =   0
      Left            =   2760
      TabIndex        =   60
      Top             =   3120
      Width           =   735
   End
   Begin VB.Label LabSend 
      BackStyle       =   0  '透明
      BorderStyle     =   1  '單線固定
      Caption         =   "0"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   2760
      TabIndex        =   59
      Top             =   3600
      Width           =   615
   End
   Begin VB.Label LabRunTime 
      Alignment       =   2  '置中對齊
      BorderStyle     =   1  '單線固定
      Caption         =   "0 Day 00:00:00"
      BeginProperty Font 
         Name            =   "MS Sans Serif"
         Size            =   12
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H00000040&
      Height          =   375
      Left            =   12120
      TabIndex        =   57
      Top             =   0
      Width           =   1935
   End
   Begin VB.Label Label18 
      Caption         =   "Run Time :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   14.25
         Charset         =   0
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      ForeColor       =   &H000080FF&
      Height          =   375
      Left            =   10560
      TabIndex        =   56
      Top             =   0
      Width           =   1695
   End
   Begin VB.Label Label17 
      Caption         =   "Total Loss :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   54
      Top             =   4560
      Width           =   975
   End
   Begin VB.Label Label16 
      Caption         =   "Receive Bytes :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   52
      Top             =   4080
      Width           =   1215
   End
   Begin VB.Label Label15 
      Caption         =   "Send Bytes :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   50
      Top             =   3600
      Width           =   1095
   End
   Begin VB.Label Label13 
      Caption         =   "Sending Data :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   7800
      TabIndex        =   44
      Top             =   1200
      Visible         =   0   'False
      Width           =   1575
   End
   Begin VB.Label Label12 
      Caption         =   "Sending Interval (ms) :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   43
      Top             =   1920
      Width           =   1695
   End
   Begin VB.Label Label5 
      Caption         =   "Sending Data Length (bytes) :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   42
      Top             =   2280
      Width           =   2295
   End
   Begin VB.Label Label8 
      Caption         =   "Label8"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   15
      Left            =   2280
      TabIndex        =   32
      Top             =   3600
      Width           =   15
   End
   Begin VB.Label labTime 
      Caption         =   "Label5"
      BeginProperty Font 
         Name            =   "新細明體"
         Size            =   11.25
         Charset         =   136
         Weight          =   700
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   120
      TabIndex        =   7
      Top             =   120
      Width           =   1575
   End
   Begin VB.Label Label22 
      Caption         =   "bytes/sec"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   0
      Left            =   3480
      TabIndex        =   62
      Top             =   4560
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label Label24 
      Caption         =   "Packet No."
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   8.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Index           =   0
      Left            =   3600
      TabIndex        =   64
      Top             =   2880
      Width           =   855
   End
   Begin VB.Label Label22 
      Caption         =   "bytes/sec"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   9.75
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   375
      Index           =   1
      Left            =   1800
      TabIndex        =   77
      Top             =   6840
      Visible         =   0   'False
      Width           =   855
   End
   Begin VB.Label Label14 
      Caption         =   "Log To File :"
      BeginProperty Font 
         Name            =   "Arial"
         Size            =   11.25
         Charset         =   0
         Weight          =   400
         Underline       =   0   'False
         Italic          =   0   'False
         Strikethrough   =   0   'False
      EndProperty
      Height          =   255
      Left            =   9000
      TabIndex        =   48
      Top             =   9960
      Visible         =   0   'False
      Width           =   1215
   End
   Begin VB.Label Label10 
      Caption         =   "Subnode"
      Height          =   255
      Left            =   8760
      TabIndex        =   34
      Top             =   8520
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.Label Label11 
      Caption         =   "IP :0/1"
      Height          =   255
      Left            =   8280
      TabIndex        =   28
      Top             =   9240
      Visible         =   0   'False
      Width           =   495
   End
   Begin VB.Label Label9 
      Caption         =   "DATA :"
      Height          =   255
      Left            =   8880
      TabIndex        =   27
      Top             =   9240
      Visible         =   0   'False
      Width           =   615
   End
   Begin VB.Label Label7 
      Caption         =   "(CCB[6]\subCmd\subNode+Data)"
      Height          =   255
      Left            =   9480
      TabIndex        =   26
      Top             =   9240
      Visible         =   0   'False
      Width           =   2775
   End
   Begin VB.Label Label4 
      Caption         =   "Port"
      Height          =   255
      Left            =   8400
      TabIndex        =   6
      Top             =   8520
      Visible         =   0   'False
      Width           =   375
   End
   Begin VB.Label Label3 
      Caption         =   "DATA :"
      Height          =   255
      Left            =   9480
      TabIndex        =   5
      Top             =   8520
      Visible         =   0   'False
      Width           =   735
   End
   Begin VB.Label Label2 
      Caption         =   "IP"
      Height          =   255
      Index           =   0
      Left            =   8160
      TabIndex        =   1
      Top             =   8520
      Visible         =   0   'False
      Width           =   255
   End
   Begin VB.Menu MnuSet 
      Caption         =   "&Setting"
      Visible         =   0   'False
      Begin VB.Menu MnuSetComp 
         Caption         =   "&Company Code"
      End
      Begin VB.Menu MnuAddId 
         Caption         =   "&Add ID"
      End
      Begin VB.Menu MnuSchedule 
         Caption         =   "Reader &Schedule"
      End
      Begin VB.Menu MnuGroup 
         Caption         =   "&Group"
      End
      Begin VB.Menu MnuHoliday 
         Caption         =   "&Holiday"
      End
      Begin VB.Menu MnuSetTime 
         Caption         =   "Current &Time"
      End
   End
   Begin VB.Menu MnuQuery 
      Caption         =   "&Query"
      Visible         =   0   'False
      Begin VB.Menu MnuQryComp 
         Caption         =   "&Company Code"
      End
      Begin VB.Menu MnuQryId 
         Caption         =   "Card &ID"
      End
      Begin VB.Menu MnuNULL1 
         Caption         =   "-"
      End
      Begin VB.Menu MnuQryRealT 
         Caption         =   "&Realtime Data"
      End
   End
End
Attribute VB_Name = "FrmMain"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
'Update:
'  2004/08/12: update packet's sequential number to hex string

Option Explicit
'---------------------Evan Exchanged 2 value became 7 (and below) value (for COM3~COM8 of socket) 2007/10/22
Dim socket(7) As Long
Dim StartDate As String
Dim StartTime As String

Dim LossCnt(7) As String
Dim OldLoss(7) As String
Dim BaseIntval(7) As Integer

Dim RcvDataBuf(7) As String
Dim RcvMode(7) As Integer

Dim IntervalSecMax(7) As Long, IntervalSecCnt(7) As Long

'---------------------Evan Exchanged end 2007/10/22

Const RCV_PERIOD = 1            'When SendInterval>0, Send Data On Time
Const RCV_TIMEOUT = 2           'When SendInterval=0, Send Data Real Time

'Const LEN_PKET_HEAD = 5        'Packet Header:"AAA" + PketNo_Low(1) + PketNo_High(1)
Const LEN_PKET_HEAD = 7         'Packet Header:"AAA" + hex(PketNo)(4byte)
Const CODE_PKET_HEAD = "AAA"



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
    RetVal = Shell("arp -d 10.0.50.100", 0)
    RetVal = Shell("arp -d 192.168.1.1", 0)
'    RetVal = Shell("arp -d 10.0.50.102", 0)
'    RetVal = Shell("arp -d 10.0.50.103", 0)
End Sub
Private Sub CmdBrow_Click()
    
   ' MenuFlag = MENU_LOG_LIST
   ' LoadForm FrmFile

End Sub

Private Sub CmdClrCnt_Click(Index As Integer)
    Dim MsgStr As String
    
    If OptTestMode(0).Value = False And Index = 1 Then Exit Sub  'Cross Test
    
    '--- Log Clear Data ----
    MsgStr = " Clear Counter " & Index + 1 & ": " & " Send=" & TxtCntSendTal(Index) & ", Send OK=" & TxtCntSend(Index) & ", Receive=" & TxtCntRcv(Index) & ", Total Loss=" & TxtCntLoss(Index)
    lerror List1, MsgStr
    
    TxtCntSendTal(Index) = "0"
    TxtCntSend(Index) = "0"
    TxtCntRcv(Index) = "0"
    TxtCntLoss(Index) = "0"
    
End Sub

Private Sub cmdClrList_Click()
    List1.Clear
    txtListCnt = 0
    
End Sub

Private Sub cmdCnect_Click(Index As Integer)
    
    Dim MsgStr As String
    Const STR_CONNECT = "Connect"
    Const STR_DISCONNECT = "Disconnect"
    
    On Error GoTo ERRCMD
    
    clean_arp 'Evan added 2007/10/22
    
    If cmdCnect(Index).Caption = STR_CONNECT Then       'COnnect
        cmdCnect(Index).Caption = STR_DISCONNECT
        Winsock1(Index).Close
        TxtSendPketTal(Index).Text = "0" 'Evan added 2007/10/23
        TxtRcvPket(Index).Text = "0" 'Evan added 2007/10/23
        
        If 1 Or OptTcpUdp(0).Value = True Then
            Winsock1(Index).Protocol = sckTCPProtocol
            Winsock1(Index).RemoteHost = txtip(Index)
            Winsock1(Index).RemotePort = txtPort(Index)
            Winsock1(Index).LocalPort = txtLocalPort(Index)
            Winsock1(Index).Connect
        Else
            Winsock1(Index).Protocol = sckUDPProtocol
            Winsock1(Index).RemoteHost = txtip(Index)
            Winsock1(Index).RemotePort = txtPort(Index)
            Winsock1(Index).Bind txtLocalPort(Index)
        End If
        
        CmdClrCnt(Index).Value = True
        
    Else                'Disconnect
        If InStr(CmdSendBeg(Index).Caption, "Stop") > 0 Then      'On Sending,Stop It
            CmdSendBeg(Index).Value = True
        End If
        Winsock1(Index).Close
        cmdCnect(Index).Caption = STR_CONNECT
        txtLocalPort(Index) = 0
        CmdSendBeg(Index).Enabled = False
    
        MsgStr = " COM " & Index + 1 & " Close OK!"
        lerror List1, MsgStr
    End If
    
    '--- Check Test mode -------
    If OptTestMode(0).Value = False Then        'Cross Test
        If Index = 0 Then cmdCnect_Click 1
    End If
    
    '--- Maintain Enable OptTestMode ------
    If cmdCnect(0).Caption = STR_CONNECT And cmdCnect(1).Caption = STR_CONNECT And cmdCnect(2).Caption = STR_CONNECT And cmdCnect(3).Caption = STR_CONNECT And cmdCnect(4).Caption = STR_CONNECT And cmdCnect(5).Caption = STR_CONNECT And cmdCnect(6).Caption = STR_CONNECT And cmdCnect(7).Caption = STR_CONNECT Then 'Evan added cmdCnect(2) ~ cmdCnect(7) (for COM3~COM8) 2007/10/22
        OptTestMode(0).Enabled = True
        OptTestMode(1).Enabled = True
    Else
        OptTestMode(0).Enabled = False
        OptTestMode(1).Enabled = False
    End If

    
'    cmdCnect(Index).Enabled = False
'    cmdDiscnect(Index).Enabled = True
    
   ' txtlocalport(Index) = Winsock1(Index).LocalPort

    Exit Sub

ERRCMD:
    MsgStr = "CmdCnect Err: " & Error
    lerror List1, MsgStr
End Sub


Private Sub cmdComtesttotal_Click() 'Evan added
If txtMappingModel.Text = "SE1402" Then
    CmdSendBeg_Click (0)
    CmdSendBeg_Click (1)

    cmdContotal.Enabled = False
    TxtSendIntvaltoall.Enabled = False
    TxtSendDataLentoall.Enabled = False
    cmdComtesttotal.Caption = "Stop to all"

    If CmdSendBeg(0).Caption = "Start 1" And CmdSendBeg(1).Caption = "Start 2" Then
       cmdComtesttotal.Caption = "Start to all"
       cmdContotal.Enabled = True
       TxtSendIntvaltoall.Enabled = True
       TxtSendDataLentoall.Enabled = True
    Exit Sub
    End If
    
    ElseIf txtMappingModel.Text = "SE1404" Or txtMappingModel.Text = "SE5404" Or txtMappingModel.Text = "SE7404" Or txtMappingModel.Text = "CS514" Or txtMappingModel.Text = "MG514" Or txtMappingModel.Text = "Xport514" Then
    CmdSendBeg_Click (0)
    CmdSendBeg_Click (1)
    CmdSendBeg_Click (2)
    CmdSendBeg_Click (3)
    
    cmdContotal.Enabled = False
    TxtSendIntvaltoall.Enabled = False
    TxtSendDataLentoall.Enabled = False
    cmdComtesttotal.Caption = "Stop to all"

    If CmdSendBeg(0).Caption = "Start 1" And CmdSendBeg(1).Caption = "Start 2" And CmdSendBeg(2).Caption = "Start 3" And CmdSendBeg(3).Caption = "Start 4" Then
       cmdComtesttotal.Caption = "Start to all"
       cmdContotal.Enabled = True
       TxtSendIntvaltoall.Enabled = True
       TxtSendDataLentoall.Enabled = True
    Exit Sub
    End If

    ElseIf txtMappingModel.Text = "SE5008" Or txtMappingModel.Text = "SE6108" Or txtMappingModel.Text = "CS518" Or txtMappingModel.Text = "MG518" Or txtMappingModel.Text = "Xport518" Or txtMappingModel.Text = "SE5016" Or txtMappingModel.Text = "SE5116" Or txtMappingModel.Text = "SE6116" Or txtMappingModel.Text = "SE1416" Or txtMappingModel.Text = "SE5416" Or txtMappingModel.Text = "SE6416" Or txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "CS516" Or txtMappingModel.Text = "MG516" Or txtMappingModel.Text = "Xport516" Then
  
CmdSendBeg_Click (0)
CmdSendBeg_Click (1)
CmdSendBeg_Click (2)
CmdSendBeg_Click (3)
CmdSendBeg_Click (4)
CmdSendBeg_Click (5)
CmdSendBeg_Click (6)
CmdSendBeg_Click (7)

cmdContotal.Enabled = False
TxtSendIntvaltoall.Enabled = False
TxtSendDataLentoall.Enabled = False
cmdComtesttotal.Caption = "Stop to all"

    If CmdSendBeg(0).Caption = "Start 1" And CmdSendBeg(1).Caption = "Start 2" And CmdSendBeg(2).Caption = "Start 3" And CmdSendBeg(3).Caption = "Start 4" And CmdSendBeg(4).Caption = "Start 5" And CmdSendBeg(5).Caption = "Start 6" And CmdSendBeg(6).Caption = "Start 7" And CmdSendBeg(7).Caption = "Start 8" Then
       cmdComtesttotal.Caption = "Start to all"
       cmdContotal.Enabled = True
       TxtSendIntvaltoall.Enabled = True
       TxtSendDataLentoall.Enabled = True
    Exit Sub
    End If

End If
End Sub

Private Sub cmdContotal_Click() 'Evan added 2007/10/22
            
    clean_arp 'Evan added
   If txtMappingModel.Text = "SE1402" Then
    cmdCnect_Click (0)
    cmdCnect_Click (1)
    
    If cmdCnect(0).Caption = "Connect" And cmdCnect(1).Caption = "Connect" Then
           cmdContotal.Caption = "Connect to all"
           cmdComtesttotal.Enabled = False
    Exit Sub
    End If
    
    If cmdCnect(0).Caption = "Disconnect" And cmdCnect(1).Caption = "Disconnect" Then
           cmdContotal.Caption = "Disconnect to all"
           cmdComtesttotal.Enabled = True
    Exit Sub
    End If
   End If
    
    If txtMappingModel.Text = "SE1404" Or txtMappingModel.Text = "SE5404" Or txtMappingModel.Text = "SE7404" Or txtMappingModel.Text = "CS514" Or txtMappingModel.Text = "MG514" Or txtMappingModel.Text = "Xport514" Then
    cmdCnect_Click (0)
    cmdCnect_Click (1)
    cmdCnect_Click (2)
    cmdCnect_Click (3)
    
    If cmdCnect(0).Caption = "Connect" And cmdCnect(1).Caption = "Connect" And cmdCnect(2).Caption = "Connect" And cmdCnect(3).Caption = "Connect" Then
           cmdContotal.Caption = "Connect to all"
           cmdComtesttotal.Enabled = False
    Exit Sub
    End If
    If cmdCnect(0).Caption = "Disconnect" And cmdCnect(1).Caption = "Disconnect" And cmdCnect(2).Caption = "Disconnect" And cmdCnect(3).Caption = "Disconnect" Then
           cmdContotal.Caption = "Disconnect to all"
           cmdComtesttotal.Enabled = True
    Exit Sub
    End If
    
    End If

    If txtMappingModel.Text = "SE5008" Or txtMappingModel.Text = "SE6108" Or txtMappingModel.Text = "CS518" Or txtMappingModel.Text = "MG518" Or txtMappingModel.Text = "Xport518" Or txtMappingModel.Text = "SE5016" Or txtMappingModel.Text = "SE5116" Or txtMappingModel.Text = "SE6116" Or txtMappingModel.Text = "SE1416" Or txtMappingModel.Text = "SE5416" Or txtMappingModel.Text = "SE6416" Or txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "CS516" Or txtMappingModel.Text = "MG516" Or txtMappingModel.Text = "Xport516" Then
    cmdCnect_Click (0)
    cmdCnect_Click (1)
    cmdCnect_Click (2)
    cmdCnect_Click (3)
    cmdCnect_Click (4)
    cmdCnect_Click (5)
    cmdCnect_Click (6)
    cmdCnect_Click (7)

    
    If cmdCnect(0).Caption = "Connect" And cmdCnect(1).Caption = "Connect" And cmdCnect(2).Caption = "Connect" And cmdCnect(3).Caption = "Connect" And cmdCnect(4).Caption = "Connect" And cmdCnect(5).Caption = "Connect" And cmdCnect(6).Caption = "Connect" And cmdCnect(7).Caption = "Connect" Then
           cmdContotal.Caption = "Connect to all"
           cmdComtesttotal.Enabled = False
    Exit Sub
    End If
    If cmdCnect(0).Caption = "Disconnect" And cmdCnect(1).Caption = "Disconnect" And cmdCnect(2).Caption = "Disconnect" And cmdCnect(3).Caption = "Disconnect" And cmdCnect(4).Caption = "Disconnect" And cmdCnect(5).Caption = "Disconnect" And cmdCnect(6).Caption = "Disconnect" And cmdCnect(7).Caption = "Disconnect" Then
           cmdContotal.Caption = "Disconnect to all"
           cmdComtesttotal.Enabled = True
    Exit Sub
    End If
   End If
End Sub













Private Sub cmdListen_Click()
    Winsock1(1).LocalPort = txtPort(1)
    Winsock1(1).Listen
    txtLocalPort(1) = Winsock1(1).LocalPort
    
End Sub

Private Sub CmdSaveList_Click()
    Dim MsgStr As String, tmpstr As String, op As String
    Dim i As Integer, Index As Integer, lens As Integer
    
    For i = 0 To List1.ListCount - 1
        op = List1.List(i)
        Index = Left(op, 1)
        op = Mid(op, 5)
    'head = Left(List1.Text, 4)
    'data = Mid(List1.Text, 29)
        lens = unldump(op, tmpstr)
        'txtMsg = head & retstr
        MsgStr = Index & ": " & tmpstr & "--" & op
        lerror2 TxtLogFile, MsgStr
    Next


End Sub

Private Sub cmdSend_Click()
    Dim data() As Byte
    Dim str1 As String, addr As String
    Dim Index As Integer, datalen As Integer
    Dim ret As Integer
    
    str1 = "\63\" & Right("0" & TxtSubNode, 2) & txtData
    datalen = Len(str1)
    ReDim data(datalen)
    datalen = HexIpB1(str1, data(), 0)
    addr = txtDaport
    Index = Val(TxtID)
'    ret = SendDapData2(Winsock1(Index), addr, Data(), datalen + 1) '+1 include 0
    ret = SendDapData0(Winsock1(Index), addr, data(), datalen) '+1 include 0
    
    'Winsock1(Index).SendData str1
    'Timer2.Enabled = True

End Sub

Private Sub Text4_Change(Index As Integer)

End Sub

Private Sub Command1_Click()
    
    Timer1.Enabled = False
    Timer1.Enabled = True
    
End Sub

Private Sub cmdSend2_Click()
    Dim data() As Byte
    Dim str1 As String, addr As String
    Dim Index As Integer, datalen As Integer
    Dim ret As Integer
    
    On Error Resume Next
    
    str1 = txtData2
    datalen = Len(str1)
    ReDim data(datalen)
    datalen = HexIpB1(str1, data(), 0)
    ReDim Preserve data(datalen - 1)
'    addr = txtDaport2
    Index = Val(txtId2)
'    ret = SendDapData2(Winsock1(Index), addr, Data(), datalen + 1) '+1 include 0
    'ret = SendDapData0(Winsock1(Index), addr, Data(), datalen) '+1 include 0
    Winsock1(Index).SendData data
    
End Sub

Private Sub CmdSendBeg_Click(Index As Integer)
    Const STR_START = "Start "
    Const STR_STOP = "Stop "
    Dim MsgStr As String
    Dim Interval As Long, datalen As Integer, tmpLen As Integer
    Dim data() As Byte
    Dim PketNo As Long
    
    On Error GoTo ERRCMD
    
    
    If InStr(CmdSendBeg(Index).Caption, STR_START) > 0 Then      'START
        MsgStr = " COM " & Index + 1 & " Send Start: Interval=" & TxtSendIntval(Index) & _
                ", DataLen=" & TxtSendDataLen(Index)
        CmdSendBeg(Index).Caption = STR_STOP & Index + 1
        
        Interval = Val(TxtSendIntval(Index))
        If Interval = 0 Then                'Wait Time Out
            RcvMode(Index) = RCV_TIMEOUT
            Interval = 3000                 'Wait 3000ms, Check Loss
            RcvDataBuf(Index) = TxtSendData(Index)
        Else                                'Send On time
            RcvMode(Index) = RCV_PERIOD
        End If
        
        If Interval > 30000 Then
            IntervalSecMax(Index) = Interval / 1000
            IntervalSecCnt(Index) = 1
            Interval = 1000
        Else
            IntervalSecMax(Index) = 0
        End If
        TmrSend(Index).Interval = Interval
        
        TmrSend(Index).Enabled = True
        'TmrRate.Enabled = True
        TxtSendIntval(Index).Enabled = False
        TxtSendDataLen(Index).Enabled = False
        TxtSendData(Index).Enabled = False
        
        'if opttestmode(0).Value= then
        cmdCnect(Index).Enabled = False
        
        If RcvMode(Index) = RCV_TIMEOUT Then
            WSendData Index, TxtSendData(Index)
            RcvDataBuf(Index) = ""
        End If

    Else
        '--- Log Rate Data ----
        MsgStr = " Traffic " & Index + 1 & ": " & " Send=" & LabSend(Index) & ", Receive=" & _
                LabRcv(Index) & ", Loss=" & LabLoss(Index)
        lerror List1, MsgStr
        
        MsgStr = " COM " & Index + 1 & " Send Stop:  Send=" & TxtCntSendTal(Index) & ", Send OK=" & _
                TxtCntSend(Index) & ", Receive=" & TxtCntRcv(Index) & ", Total Loss=" & TxtCntLoss(Index) & _
                ", SendPket=" & TxtSendPketTal(Index) & ", RcvPket=" & TxtRcvPket(Index)
        lerror List1, MsgStr
        
        CmdSendBeg(Index).Caption = STR_START & Index + 1
        TmrSend(Index).Enabled = False
        'TmrRate.Enabled = False
        TxtSendIntval(Index).Enabled = True
        TxtSendDataLen(Index).Enabled = True
        TxtSendData(Index).Enabled = True
        
        cmdCnect(Index).Enabled = True
    
    End If
    
    lerror List1, MsgStr
    
    Exit Sub
    
ERRCMD:
    MsgStr = "CmdSendBeg Err: " & Error
    lerror List1, MsgStr
    Exit Sub
    Resume
End Sub

Sub WSendData(Index As Integer, DataStr As String)
    Dim PketNo As Long
    Dim datalen As Integer, tmpLen As Integer
    Dim data() As Byte
    Dim tmpstr As String
    
    PketNo = TxtSendPketTal(Index) + 1
   'If PketNo > 65535 Then PketNo = 0      '2 bytes for PketNo
    PketNo = PketNo And &HFFFF             '2 bytes for PketNo, update to hex string, 2004/08/12
    
    TxtSendPketTal(Index) = PketNo
            
    datalen = Len(TxtSendData(Index)) + LEN_PKET_HEAD
    ReDim data(datalen - 1)
    tmpLen = HexIpB1(TxtSendData(Index), data(), LEN_PKET_HEAD)
    tmpLen = HexIpB1(CODE_PKET_HEAD, data(), 0)
   
   'data(3) = PketNo Mod 256          'PketNo_Low
   'data(4) = PketNo \ 256            'PketNo_High
    tmpstr = Right(Hex(&H10000 + PketNo), 4)          'update to hex string, 2004/08/12
    data(3) = Asc(Mid(tmpstr, 1, 1))  'PketNo_High
    data(4) = Asc(Mid(tmpstr, 2, 1))
    data(5) = Asc(Mid(tmpstr, 3, 1))
    data(6) = Asc(Mid(tmpstr, 4, 1))
    
    Debug.Print "PketNo=" & PketNo
    
    Winsock1(Index).SendData data
    TxtCntSendTal(Index) = TxtCntSendTal(Index) + datalen

End Sub

Private Sub Form_Load()

    Call SendMessage(List1.hWnd, LB_SETHORIZONTALEXTENT, 2000, ByVal 0&)
    TxtLogFile = App.Path & "\" & Format(Date, "YYYYMMDD") & ".TXT"
    TxtLogFile.SelStart = Len(TxtLogFile)
    
    Me.Caption = Me.Caption & " (V" & App.Major & "." & App.Minor & ")"
    
    TxtSendDataLen_Change 0
    TxtSendDataLen_Change 1
    TxtSendDataLen_Change 2 'Evan added 2007/10/22
    TxtSendDataLen_Change 3 'Evan added 2007/10/22
    TxtSendDataLen_Change 4 'Evan added 2007/10/22
    TxtSendDataLen_Change 5 'Evan added 2007/10/22
    TxtSendDataLen_Change 6 'Evan added 2007/10/22
    TxtSendDataLen_Change 7 'Evan added 2007/10/22
    
  StartDate = Date
  StartTime = Time

    
End Sub

Private Sub Form_Unload(Cancel As Integer)
    
    End
    
End Sub

Private Sub List1_Click()
    Dim head As String, data As String
    Dim retstr As String
    Dim lens As Integer
    
    txtListCnt = List1.ListIndex + 1
    If List1.ListCount > 32000 Then
        List1.RemoveItem 0
    End If
    
    Exit Sub
    
    head = Left(List1.Text, 4)
    data = Mid(List1.Text, 29)
    lens = unldump(data, retstr)
    txtMsg = head & retstr
    List1.ToolTipText = List1.Text
    
    
End Sub

Private Sub MnuAddId_Click()
    
    'MenuFlag = CMD_ADD_ID
    'FrmMain.Enabled = False
    'LoadForm FrmSet
    
End Sub

Private Sub MnuGroup_Click()
    
    MenuFlag = CMD_SET_GROUP
    FrmMain.Enabled = False
    'LoadForm FrmSet

End Sub

Private Sub MnuHoliday_Click()
    
    MenuFlag = CMD_SET_HOLIDAY
    FrmMain.Enabled = False
    'LoadForm FrmSet

End Sub

Private Sub MnuQryComp_Click()

    MenuFlag = CMD_QRY_COMP
    FrmMain.Enabled = False
   ' LoadForm FrmSet

End Sub

Private Sub MnuQryId_Click()

    MenuFlag = CMD_QRY_ID
    FrmMain.Enabled = False
   ' LoadForm FrmSet
    
End Sub

Private Sub MnuQryRealT_Click()

    MenuFlag = CMD_GET_RECD
    FrmMain.Enabled = False
    'LoadForm FrmSet

End Sub

Private Sub MnuSchedule_Click()
    
    MenuFlag = CMD_SCHEDULE
    FrmMain.Enabled = False
   ' LoadForm FrmSet

End Sub

Private Sub MnuSetComp_Click()
    
    MenuFlag = CMD_ADD_COMP
    FrmMain.Enabled = False
    'LoadForm FrmSet

End Sub

Private Sub MnuSetTime_Click()
    Dim data() As Byte
    Dim str1 As String, TimeStr As String, tmpstr As String
    Dim addr As String, DateStr As String
    Dim Index As Integer, datalen As Integer
    Dim i As Integer, ret As Integer, week As Integer
    Dim OkCnt As Integer, ErrCnt As Integer, Cnt As Integer
    Dim Start As Long, nowTime As Long, TimeoutFlag As Boolean
    
    FrmMain.MousePointer = vbHourglass
    
    '---  Send command ---------
    TimeoutFlag = False
    Cnt = 1
    'CMD: "D"+<Mode>1+<Date>9+<Time>6
    '<Mode>: 1 -> Query Time
    '        2 -> Set Current Time
    '<Date>: YYYYMMDDW
    '<Time>: HHMMSS
    '----  Get Time Zone -----------
    DateStr = Format(Date, "yyyymmdd")
    i = Format(Date, "w")
    week = i - 1
    If week = 0 Then week = 7
    DateStr = DateStr & Trim(Str(week))
    TimeStr = Format(Time, "hhmmss")
    
    str1 = "\63\" & Right("0" & TxtSubNode, 2) & CMD_SET_TIME & "2" & DateStr & TimeStr
    datalen = Len(str1)
    ReDim data(datalen)
    datalen = HexIpB1(str1, data(), 0)
    addr = FrmMain.txtDaport
    Index = Val(FrmMain.TxtID)
    ret = SendDapData0(FrmMain.Winsock1(Index), addr, data(), datalen)  '+1 include 0
        
    '----- Waitting Response ------------------
    AckFlag = False
    Start = Timer
    Do While (AckFlag = False)
        nowTime = Timer
        If nowTime < Start Then nowTime = nowTime + CNST_DAY_SEC
        If nowTime > (Start + CNST_TIMEOUT_ACC) Then    'timeout
            AckFlag = True
            TimeoutFlag = True
        End If
            
        DoEvents
    Loop
    '------ Record Result -----------------
    If TimeoutFlag Then         'timeout
        ErrCnt = ErrCnt + 1
        TimeoutFlag = False
    Else                        'Ack OK
        OkCnt = OkCnt + 1
    End If
        
    '---- Report Result ------------
    tmpstr = "Total: " & Cnt & ",  OK: " & OkCnt & ",   Err: " & ErrCnt
    MsgBox "Set Time: " & tmpstr
    'StatusBar1.Panels.Item(1) = tmpstr

    FrmMain.MousePointer = vbDefault
    

End Sub

Private Sub OptTestMode_Click(Index As Integer)
    
    If Index = 0 Then       'Loopback Test
        cmdCnect(1).Visible = True
        LabLoop(0).Visible = True
        LabLoop(1).Visible = True
        
        TxtSendIntval(1).Visible = True
        TxtSendDataLen(1).Visible = True
        CmdSendBeg(1).Visible = True
        TxtCntSend(1).Visible = True
        TxtCntSendTal(1).Visible = True
        TxtCntRcv(1).Visible = True
        TxtCntLoss(1).Visible = True
        LabSend(1).Visible = True
        LabRcv(1).Visible = True
        LabLoss(1).Visible = True
        Label20(1).Visible = True
        Label22(1).Visible = True
        Label24(1).Visible = True
        TxtSendPketTal(1).Visible = True
        TxtSendPket(1).Visible = True
        TxtRcvPket(1).Visible = True
        
        '-------------------------------------------Evan added below 2007/10/22
        TxtSendIntval(2).Visible = True
        TxtSendDataLen(2).Visible = True
        CmdSendBeg(2).Visible = True
        TxtCntSend(2).Visible = True
        TxtCntSendTal(2).Visible = True
        TxtCntRcv(2).Visible = True
        TxtCntLoss(2).Visible = True
        LabSend(2).Visible = True
        LabRcv(2).Visible = True
        LabLoss(2).Visible = True
        TxtSendPketTal(2).Visible = True
        TxtSendPket(2).Visible = True
        TxtRcvPket(2).Visible = True
        Label24(2).Visible = True
        
        TxtSendIntval(3).Visible = True
        TxtSendDataLen(3).Visible = True
        CmdSendBeg(3).Visible = True
        TxtCntSend(3).Visible = True
        TxtCntSendTal(3).Visible = True
        TxtCntRcv(3).Visible = True
        TxtCntLoss(3).Visible = True
        LabSend(3).Visible = True
        LabRcv(3).Visible = True
        LabLoss(3).Visible = True
        TxtSendPketTal(3).Visible = True
        TxtSendPket(3).Visible = True
        TxtRcvPket(3).Visible = True
        Label24(3).Visible = True
        
        TxtSendIntval(4).Visible = True
        TxtSendDataLen(4).Visible = True
        CmdSendBeg(4).Visible = True
        TxtCntSend(4).Visible = True
        TxtCntSendTal(4).Visible = True
        TxtCntRcv(4).Visible = True
        TxtCntLoss(4).Visible = True
        LabSend(4).Visible = True
        LabRcv(4).Visible = True
        LabLoss(4).Visible = True
        TxtSendPketTal(4).Visible = True
        TxtSendPket(4).Visible = True
        TxtRcvPket(4).Visible = True
        Label24(4).Visible = True
        
        TxtSendIntval(5).Visible = True
        TxtSendDataLen(5).Visible = True
        CmdSendBeg(5).Visible = True
        TxtCntSend(5).Visible = True
        TxtCntSendTal(5).Visible = True
        TxtCntRcv(5).Visible = True
        TxtCntLoss(5).Visible = True
        LabSend(5).Visible = True
        LabRcv(5).Visible = True
        LabLoss(5).Visible = True
        TxtSendPketTal(5).Visible = True
        TxtSendPket(5).Visible = True
        TxtRcvPket(5).Visible = True
        Label24(5).Visible = True
        
        TxtSendIntval(6).Visible = True
        TxtSendDataLen(6).Visible = True
        CmdSendBeg(6).Visible = True
        TxtCntSend(6).Visible = True
        TxtCntSendTal(6).Visible = True
        TxtCntRcv(6).Visible = True
        TxtCntLoss(6).Visible = True
        LabSend(6).Visible = True
        LabRcv(6).Visible = True
        LabLoss(6).Visible = True
        TxtSendPketTal(6).Visible = True
        TxtSendPket(6).Visible = True
        TxtRcvPket(6).Visible = True
        Label24(6).Visible = True
        
        TxtSendIntval(7).Visible = True
        TxtSendDataLen(7).Visible = True
        CmdSendBeg(7).Visible = True
        TxtCntSend(7).Visible = True
        TxtCntSendTal(7).Visible = True
        TxtCntRcv(7).Visible = True
        TxtCntLoss(7).Visible = True
        LabSend(7).Visible = True
        LabRcv(7).Visible = True
        LabLoss(7).Visible = True
        TxtSendPketTal(7).Visible = True
        TxtSendPket(7).Visible = True
        TxtRcvPket(7).Visible = True
        Label24(7).Visible = True
        
        TxtSendIntval(8).Visible = True
        TxtSendDataLen(8).Visible = True
        CmdSendBeg(8).Visible = True
        TxtCntSend(8).Visible = True
        TxtCntSendTal(8).Visible = True
        TxtCntRcv(8).Visible = True
        TxtCntLoss(8).Visible = True
        LabSend(8).Visible = True
        LabRcv(8).Visible = True
        LabLoss(8).Visible = True
        TxtSendPketTal(8).Visible = True
        TxtSendPket(8).Visible = True
        TxtRcvPket(8).Visible = True
        Label24(8).Visible = True
        '-------------------------------------------Evan added end 2007/10/22
        
    Else                    'Cross Test
        'cmdCnect(1).Visible = False
        LabLoop(0).Visible = False
        LabLoop(1).Visible = False
        
        TxtSendIntval(1).Visible = False
        TxtSendDataLen(1).Visible = False
        CmdSendBeg(1).Visible = False
        TxtCntSend(1).Visible = False
        TxtCntSendTal(1).Visible = False
        TxtCntRcv(1).Visible = False
        TxtCntLoss(1).Visible = False
        LabSend(1).Visible = False
        LabRcv(1).Visible = False
        LabLoss(1).Visible = False
        Label20(1).Visible = False
        Label22(1).Visible = False
        Label24(1).Visible = False
        TxtSendPketTal(1).Visible = False
        TxtSendPket(1).Visible = False
        TxtRcvPket(1).Visible = False
    
    End If
End Sub

Private Sub Timer1_Timer()
    Dim tmpstr As String
    Dim tmpstr23 As String 'Evan added 2007/10/22
    Dim tmpstr45 As String 'Evan added 2007/10/22
    Dim tmpstr67 As String 'Evan added 2007/10/22
    
    Dim Index As Integer
    Static FileName As String
    
    On Error Resume Next
    
    labTime = Time$

    tmpstr = Winsock1(0).State & Chr(13) & Chr(10) '"    "
    tmpstr = tmpstr & Winsock1(1).State
    txtStatus = tmpstr

    tmpstr = Format(Date, "YYYYMMDD")

        If tmpstr <> FileName Then
        FileName = tmpstr
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
'------------------------------------------------------------''Evan added below 2007/10/22
    tmpstr23 = Winsock1(2).State & Chr(13) & Chr(10) '"    "
    tmpstr23 = tmpstr23 & Winsock1(3).State
    txtStatus23 = tmpstr23

    tmpstr23 = Format(Date, "YYYYMMDD")

            If tmpstr23 <> FileName Then
        FileName = tmpstr23
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
 '-------------------------------------------------------------------------------'
        tmpstr45 = Winsock1(4).State & Chr(13) & Chr(10) '"    "
    tmpstr45 = tmpstr45 & Winsock1(5).State
    txtStatus45 = tmpstr45

    tmpstr45 = Format(Date, "YYYYMMDD")

            If tmpstr45 <> FileName Then
        FileName = tmpstr45
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If
 '-------------------------------------------------------------------------------'
        tmpstr67 = Winsock1(6).State & Chr(13) & Chr(10) '"    "
    tmpstr67 = tmpstr67 & Winsock1(7).State
    txtStatus67 = tmpstr67

    tmpstr67 = Format(Date, "YYYYMMDD")

            If tmpstr67 <> FileName Then
        FileName = tmpstr67
        TxtLogFile = App.Path & "\" & FileName & ".TXT"
        'TxtLogFile.SelStart = Len(TxtLogFile)
    End If


'------------------------------------------------------------'Evan added end 2007/10/22
     
    Exit Sub
    
    With List1
        Index = .ListCount - 1
        If tmpstr <> .List(Index) Then
            .AddItem tmpstr
            .ListIndex = Index + 1
        End If
    End With
    
End Sub

Private Sub Timer2_Timer()
  Dim tmpstr As String, tmpVal As Integer
  Dim Hstr As String, Mstr As String, Sstr As String, Dstr As String
  
  Label9.Caption = Format(Now, "yyyy/mm/dd hh:mm:ss")
  
  tmpVal = DateDiff("d", StartDate, Date)
  Dstr = IIf(tmpVal > 0, tmpVal, tmpVal)
  tmpVal = Hour(Time) - Hour(StartTime)
  Hstr = Right("0" & IIf(tmpVal >= 0, tmpVal, 24 + tmpVal), 2)
  tmpVal = Minute(Time) - Minute(StartTime)
  Mstr = Right("0" & IIf(tmpVal >= 0, tmpVal, 60 + tmpVal), 2)
  tmpVal = Second(Time) - Second(StartTime)
  Sstr = Right("0" & IIf(tmpVal >= 0, tmpVal, 60 + tmpVal), 2)
  LabRunTime = Dstr & " Day " & Hstr & ":" & Mstr & ":" & Sstr
  
  
End Sub

Private Sub TmrRate_Timer()
    Static OldCntSend(8) As String 'Evan Exchanged 2 value became 8 value (for COM3~COM8) 2007/10/22
    Static OldCntRcv(8) As String 'Evan Exchanged 2 value became 8 value (for COM3~COM8) 2007/10/22
    Static OldCntLoss(8) As String 'Evan Exchanged 2 value became 8 value (for COM3~COM8) 2007/10/22
    Static TimeCnt As Integer
    Dim tmpLong As Long, i As Integer, TestMode As Integer
    
    Const SAMPLE_TIME = 1        'Unit: Sec
    
    TimeCnt = TimeCnt + 1
    If TimeCnt < SAMPLE_TIME Then Exit Sub
    TimeCnt = 0
    
    '--- Check Test Mode -------
    If OptTestMode(0).Value = True Then     'Loopback
        TestMode = 7 'Evan Exchanged 1 value became 7 value (for COM3~COM8) 2007/10/22
    Else
        TestMode = 0
    End If
     
  For i = 0 To TestMode
    '--- Initial Value -----
    If OldCntSend(i) = "" Then OldCntSend(i) = "0"
    If OldCntRcv(i) = "" Then OldCntRcv(i) = "0"
    If OldCntLoss(i) = "" Then OldCntLoss(i) = "0"
    
    '---- Check Send Rate ----------
'    tmpLong = TxtCntSend - OldCntSend
If Val(TxtSendIntval(i)) > 0 Then
    LabSend(i).Caption = (Val(TxtSendDataLen(i)) * 1000) / TxtSendIntval(i) 'tmpLong / SAMPLE_TIME
    'OldCntSend = TxtCntSend
End If
    '---- Check Receive Rate ----------
    tmpLong = TxtCntRcv(i) - OldCntRcv(i)
    LabRcv(i).Caption = tmpLong / SAMPLE_TIME
    OldCntRcv(i) = TxtCntRcv(i)
    
    '---- Check Loss Rate ----------
    tmpLong = TxtCntLoss(i) - OldCntLoss(i)
    LabLoss(i).Caption = tmpLong / SAMPLE_TIME
    OldCntLoss(i) = TxtCntLoss(i)
    
  Next
    
    
End Sub

Private Sub TmrSend_Timer(Index As Integer)
    Dim MsgStr As String, ErrStr As String
    Static ErrMsg(7) As String 'Evan Exchanged 2 value became 7 (and below) value (for COM3~COM8 of socket) 2007/10/22
    
    On Error GoTo err99
    
    If IntervalSecMax(Index) Then
        IntervalSecCnt(Index) = IntervalSecCnt(Index) - 1
        If IntervalSecCnt(Index) Then
            Exit Sub
        Else
            IntervalSecCnt(Index) = IntervalSecMax(Index)
        End If
    End If
    
    ChcekLoss Index
    
    MsgStr = TxtSendData(Index)
    If RcvMode(Index) = RCV_TIMEOUT Then
        MsgStr = RcvDataBuf(Index)
        '''RcvDataBuf(Index) = ""
    Else
'        WSendData Index, MsgStr
    End If
    
    If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10
    WSendData Index, TxtSendData(Index)
    End If
    
    'If OptTestMode(0).Value = False Then    'Cross Test
        'Winsock1(Index).SendData MsgStr
    'End If
    
    'TxtCntSendTal(Index) = TxtCntSendTal(Index) + Len(MsgStr)
    
    ErrMsg(Index) = ""
   
   'List1.AddItem "Send :" & Len(TxtSendData)
    
  Exit Sub
  
err99:
  
    ErrStr = Error
    If ErrMsg(Index) = ErrStr Then Exit Sub         'Only Log Error Message One Times
    ErrMsg(Index) = ErrStr
    
    MsgStr = " COM " & Index + 1 & " TmrSend Error: " & ErrStr
    lerror List1, MsgStr

End Sub

Private Sub ChcekLoss(Index As Integer)
    Dim MsgStr As String
    Dim i As Integer
    
    On Error GoTo err99
    
    'If OptTestMode(0).Value = True Then         'LoopBack Test
    '    Index = 1
    'Else
    '    Index = 0
    'End If
    
    TxtCntLoss(Index) = TxtCntSend(Index) - TxtCntRcv(Index)
    Exit Sub
    
  i = Index
 'For i = 0 To Index
   If TxtCntLoss(i) <> "0" Then
        If LossCnt(i) <> TxtCntLoss(i) Then
            MsgStr = " COM " & i + 1 & " Loss=" & TxtCntLoss(i) - LossCnt(i) & " Send=" & TxtCntSendTal(i) & ", Send OK=" & TxtCntSend(i) & ", Receive=" & TxtCntRcv(i) & ", Total Loss=" & TxtCntLoss(i)
            lerror List1, MsgStr
            LossCnt(i) = TxtCntLoss(i)
            OldLoss(i) = TxtCntLoss(i)
            
        End If
    Else
        LossCnt(i) = "0"
        '--- Check Full Data Receive --------
        If OldLoss(i) <> "0" Then
            MsgStr = " COM " & i + 1 & " Full Receive:" & " Send=" & TxtCntSendTal(i) & ", Send OK=" & TxtCntSend(i) & ", Receive=" & TxtCntRcv(i) & ", Total Loss=" & TxtCntLoss(i)
            lerror List1, MsgStr
            OldLoss(i) = TxtCntLoss(i)
        End If
    End If
  'Next
  Exit Sub
  
err99:
     
    MsgStr = " COM " & Index + 1 & " CheckLoss Error: " & Error
    lerror List1, MsgStr

End Sub


Private Sub TxtCntLoss_KeyPress(Index As Integer, KeyAscii As Integer)
    KeyAscii = 0

End Sub

Private Sub TxtCntRcv_KeyPress(Index As Integer, KeyAscii As Integer)
    KeyAscii = 0

End Sub

Private Sub TxtCntSend_KeyPress(Index As Integer, KeyAscii As Integer)
    
    KeyAscii = 0
    
End Sub


Private Sub TxtCntSendTal_KeyPress(Index As Integer, KeyAscii As Integer)
    
    KeyAscii = 0


End Sub

Private Sub txtip_Change(Index As Integer)

FrmMain.Caption = txtip(0).Text 'Evan added 2007/10/24

'--------------------------------------------------------Evan added below (for COM3~COM8 of IP address) 2007/10/24
    If Index = 0 Then
        txtip(1).Text = txtip(0).Text
        txtip(2).Text = txtip(1).Text
        txtip(3).Text = txtip(2).Text
        txtip(4).Text = txtip(3).Text
        txtip(5).Text = txtip(4).Text
        txtip(6).Text = txtip(5).Text
        txtip(7).Text = txtip(6).Text
'    Else
'        txtip(0).Text = txtip(1).Text
    End If
'--------------------------------------------------------Evan added end 2007/10/24
    
    
'    If Index = 0 Then
'        txtip(1).Text = txtip(0).Text
'    Else
'        txtip(0).Text = txtip(1).Text
'    End If
    
    
End Sub

Private Sub txtMappingModel_Change()
If txtMappingModel.Text = "SE1402" Then

Label21.Visible = False
Label30.Visible = False
Label31.Visible = False

txtip(2).Visible = False
txtip(3).Visible = False
txtip(4).Visible = False
txtip(5).Visible = False
txtip(6).Visible = False
txtip(7).Visible = False

cmdCnect(2).Visible = False
cmdCnect(3).Visible = False
cmdCnect(4).Visible = False
cmdCnect(5).Visible = False
cmdCnect(6).Visible = False
cmdCnect(7).Visible = False

txtStatus23.Visible = False
txtStatus45.Visible = False
txtStatus67.Visible = False

TxtSendIntval(2).Visible = False
TxtSendIntval(3).Visible = False
TxtSendIntval(4).Visible = False
TxtSendIntval(5).Visible = False
TxtSendIntval(6).Visible = False
TxtSendIntval(7).Visible = False

TxtSendDataLen(2).Visible = False
TxtSendDataLen(3).Visible = False
TxtSendDataLen(4).Visible = False
TxtSendDataLen(5).Visible = False
TxtSendDataLen(6).Visible = False
TxtSendDataLen(7).Visible = False

CmdSendBeg(2).Visible = False
CmdSendBeg(3).Visible = False
CmdSendBeg(4).Visible = False
CmdSendBeg(5).Visible = False
CmdSendBeg(6).Visible = False
CmdSendBeg(7).Visible = False

Label24(2).Visible = False
Label24(3).Visible = False
Label24(4).Visible = False
Label24(5).Visible = False
Label24(6).Visible = False
Label24(7).Visible = False

TxtCntSendTal(2).Visible = False
TxtCntSendTal(3).Visible = False
TxtCntSendTal(4).Visible = False
TxtCntSendTal(5).Visible = False
TxtCntSendTal(6).Visible = False
TxtCntSendTal(7).Visible = False

TxtCntSend(2).Visible = False
TxtCntSend(3).Visible = False
TxtCntSend(4).Visible = False
TxtCntSend(5).Visible = False
TxtCntSend(6).Visible = False
TxtCntSend(7).Visible = False

TxtCntRcv(2).Visible = False
TxtCntRcv(3).Visible = False
TxtCntRcv(4).Visible = False
TxtCntRcv(5).Visible = False
TxtCntRcv(6).Visible = False
TxtCntRcv(7).Visible = False

TxtCntLoss(2).Visible = False
TxtCntLoss(3).Visible = False
TxtCntLoss(4).Visible = False
TxtCntLoss(5).Visible = False
TxtCntLoss(6).Visible = False
TxtCntLoss(7).Visible = False

Label20(2).Visible = False
Label20(3).Visible = False
Label20(4).Visible = False
Label20(5).Visible = False
Label20(6).Visible = False
Label20(7).Visible = False

LabSend(2).Visible = False
LabSend(3).Visible = False
LabSend(4).Visible = False
LabSend(5).Visible = False
LabSend(6).Visible = False
LabSend(7).Visible = False

LabRcv(2).Visible = False
LabRcv(3).Visible = False
LabRcv(4).Visible = False
LabRcv(5).Visible = False
LabRcv(6).Visible = False
LabRcv(7).Visible = False

LabLoss(2).Visible = False
LabLoss(3).Visible = False
LabLoss(4).Visible = False
LabLoss(5).Visible = False
LabLoss(6).Visible = False
LabLoss(7).Visible = False

TxtSendData(2).Visible = False
TxtSendData(3).Visible = False
TxtSendData(4).Visible = False
TxtSendData(5).Visible = False
TxtSendData(6).Visible = False
TxtSendData(7).Visible = False

txtPort(2).Visible = False
txtPort(3).Visible = False
txtPort(4).Visible = False
txtPort(5).Visible = False
txtPort(6).Visible = False
txtPort(7).Visible = False

TxtSendPketTal(2).Visible = False
TxtSendPketTal(3).Visible = False
TxtSendPketTal(4).Visible = False
TxtSendPketTal(5).Visible = False
TxtSendPketTal(6).Visible = False
TxtSendPketTal(7).Visible = False

TxtRcvPket(2).Visible = False
TxtRcvPket(3).Visible = False
TxtRcvPket(4).Visible = False
TxtRcvPket(5).Visible = False
TxtRcvPket(6).Visible = False
TxtRcvPket(7).Visible = False

End If

If txtMappingModel.Text = "SE1404" Or txtMappingModel.Text = "SE5404" Or txtMappingModel.Text = "SE7404" Or txtMappingModel.Text = "CS514" Or txtMappingModel.Text = "MG514" Or txtMappingModel.Text = "Xport514" Then

Label30.Visible = False
Label31.Visible = False

txtip(4).Visible = False
txtip(5).Visible = False
txtip(6).Visible = False
txtip(7).Visible = False

cmdCnect(4).Visible = False
cmdCnect(5).Visible = False
cmdCnect(6).Visible = False
cmdCnect(7).Visible = False

txtStatus45.Visible = False
txtStatus67.Visible = False

TxtSendIntval(4).Visible = False
TxtSendIntval(5).Visible = False
TxtSendIntval(6).Visible = False
TxtSendIntval(7).Visible = False

TxtSendDataLen(4).Visible = False
TxtSendDataLen(5).Visible = False
TxtSendDataLen(6).Visible = False
TxtSendDataLen(7).Visible = False

CmdSendBeg(4).Visible = False
CmdSendBeg(5).Visible = False
CmdSendBeg(6).Visible = False
CmdSendBeg(7).Visible = False

Label24(4).Visible = False
Label24(5).Visible = False
Label24(6).Visible = False
Label24(7).Visible = False

TxtCntSendTal(4).Visible = False
TxtCntSendTal(5).Visible = False
TxtCntSendTal(6).Visible = False
TxtCntSendTal(7).Visible = False

TxtCntSend(4).Visible = False
TxtCntSend(5).Visible = False
TxtCntSend(6).Visible = False
TxtCntSend(7).Visible = False

TxtCntRcv(4).Visible = False
TxtCntRcv(5).Visible = False
TxtCntRcv(6).Visible = False
TxtCntRcv(7).Visible = False

TxtCntLoss(4).Visible = False
TxtCntLoss(5).Visible = False
TxtCntLoss(6).Visible = False
TxtCntLoss(7).Visible = False

Label20(4).Visible = False
Label20(5).Visible = False
Label20(6).Visible = False
Label20(7).Visible = False

LabSend(4).Visible = False
LabSend(5).Visible = False
LabSend(6).Visible = False
LabSend(7).Visible = False

LabRcv(4).Visible = False
LabRcv(5).Visible = False
LabRcv(6).Visible = False
LabRcv(7).Visible = False

LabLoss(4).Visible = False
LabLoss(5).Visible = False
LabLoss(6).Visible = False
LabLoss(7).Visible = False

TxtSendData(4).Visible = False
TxtSendData(5).Visible = False
TxtSendData(6).Visible = False
TxtSendData(7).Visible = False

txtPort(4).Visible = False
txtPort(5).Visible = False
txtPort(6).Visible = False
txtPort(7).Visible = False

TxtSendPketTal(4).Visible = False
TxtSendPketTal(5).Visible = False
TxtSendPketTal(6).Visible = False
TxtSendPketTal(7).Visible = False

TxtRcvPket(4).Visible = False
TxtRcvPket(5).Visible = False
TxtRcvPket(6).Visible = False
TxtRcvPket(7).Visible = False

'ElseIf txtMappingModel.Text = "SE5008" Or txtMappingModel.Text = "SE6108" Or txtMappingModel.Text = "CS518" Or txtMappingModel.Text = "MG518" Or txtMappingModel.Text = "Xport518" Then
'
'ElseIf txtMappingModel.Text = "SE5016" Or txtMappingModel.Text = "SE5116" Or txtMappingModel.Text = "SE6116" Or txtMappingModel.Text = "SE1416" Or txtMappingModel.Text = "SE5416" Or txtMappingModel.Text = "SE6416" Or txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "CS516" Or txtMappingModel.Text = "MG516" Or txtMappingModel.Text = "Xport516" Then

End If

End Sub

Private Sub TxtRcvPket_KeyPress(Index As Integer, KeyAscii As Integer)
    
    KeyAscii = 0


End Sub

Private Sub TxtSendDataLen_Change(Index As Integer)
    'Const STR_DATA = "1234567890"
    Dim i As Integer
    Dim tmpstr As String, MsgStr As String
    
    On Error GoTo ERRCMD
    
    tmpstr = ""
    For i = 1 To Val(TxtSendDataLen(Index)) - LEN_PKET_HEAD
        tmpstr = tmpstr & (i Mod 10)
    Next i
    
    TxtSendData(Index) = tmpstr
    
    Exit Sub
    
ERRCMD:
    MsgStr = "TxtSendDataLen Err: " & Error
    lerror List1, MsgStr
End Sub

Private Sub TxtSendDataLentoall_Change()

TxtSendDataLen(0).Text = TxtSendDataLentoall.Text
TxtSendDataLen(1).Text = TxtSendDataLentoall.Text
TxtSendDataLen(2).Text = TxtSendDataLentoall.Text
TxtSendDataLen(3).Text = TxtSendDataLentoall.Text
TxtSendDataLen(4).Text = TxtSendDataLentoall.Text
TxtSendDataLen(5).Text = TxtSendDataLentoall.Text
TxtSendDataLen(6).Text = TxtSendDataLentoall.Text
TxtSendDataLen(7).Text = TxtSendDataLentoall.Text

End Sub

Private Sub TxtSendIntvaltoall_Change() 'Evan added

TxtSendIntval(0).Text = TxtSendIntvaltoall.Text
TxtSendIntval(1).Text = TxtSendIntvaltoall.Text
TxtSendIntval(2).Text = TxtSendIntvaltoall.Text
TxtSendIntval(3).Text = TxtSendIntvaltoall.Text
TxtSendIntval(4).Text = TxtSendIntvaltoall.Text
TxtSendIntval(5).Text = TxtSendIntvaltoall.Text
TxtSendIntval(6).Text = TxtSendIntvaltoall.Text
TxtSendIntval(7).Text = TxtSendIntvaltoall.Text
End Sub

Private Sub TxtSendPketTal_KeyPress(Index As Integer, KeyAscii As Integer)
    
    KeyAscii = 0

End Sub

Private Sub Winsock1_Close(Index As Integer)
    Dim MsgStr As String
    
    Winsock1(Index).Close
    MsgStr = " COM " & Index + 1 & " Close Complete!"
    lerror List1, MsgStr
    
    'Exit Sub
    
    If InStr(CmdSendBeg(Index).Caption, "Stop") > 0 Then
        CmdSendBeg(Index).Value = True
    End If
    
    CmdSendBeg(Index).Enabled = False
    
End Sub

Private Sub Winsock1_Connect(Index As Integer)
    Dim ret As Integer, optval As Integer
    Dim sck As Long, MsgStr As String, tmpstr As String
    
    
    If OptTestMode(0).Value = True Then     'Loopback Test
        tmpstr = " Loopback Test "
    Else
        tmpstr = " Cross Test "
    End If
    
    txtLocalPort(Index) = Winsock1(Index).LocalPort
    MsgStr = " COM " & Index + 1 & tmpstr & "Connect OK! (" & Winsock1(Index).RemoteHost & ")"
    lerror List1, MsgStr
    
    CmdSendBeg(Index).Enabled = True
    
    sck = Winsock1(Index).SocketHandle
    socket(Index) = sck
    optval = -1
'    ret = setsockopt(socket(Index), SOL_SOCKET, SO_KEEPALIVE, optval, 2)
    
    'Timer2.Enabled = False
    
End Sub

Private Sub Winsock1_ConnectionRequest(Index As Integer, ByVal requestID As Long)
    MsgBox Index & "  DAP Connection Request"
    If Winsock1(Index).State <> sckClosed Then _
    Winsock1(Index).Close
    '接受具有 requestID 參數的
    '連線。
    Winsock1(Index).Accept requestID

End Sub

Function CheckRcvData(Index As Integer, DataStr As String) As Boolean
    Dim idx As Integer, ret As Integer
    
        'Debug.Print DataStr
    CheckRcvData = False
    '--- Check Total Length ------
    If Len(DataStr) <> TxtSendDataLen(Index) Then Exit Function    'Receive Fail
    
    '--- Check Packet Head -------
    idx = InStr(DataStr, CODE_PKET_HEAD)
    If idx <= 0 Then Exit Function       'Format Error
        
    '--- Check Packket Data Content ----
    If Mid(DataStr, LEN_PKET_HEAD + 1) <> TxtSendData(Index) Then Exit Function    'Data Error
    
    '--- Data Format Exact -------
    CheckRcvData = True
    
End Function

Private Sub Winsock1_DataArrival(Index As Integer, ByVal bytesTotal As Long)
        Dim tmpstr As String, op As String, DataStr As String, HeadStr As String
        Dim ret As Long, lens As Integer, idx As Integer, i As Long
        Dim flag As Boolean
        Dim OldData As String, GoodStr As String, AccCmd As String
        Dim DapData() As Byte, tran_id As Integer
        Dim MsgStr As String
        Dim tmpNo As Long
        Static GetHeadFlag(7) As Boolean, Pket_No(7) As Long
        
        Const POS_TRAN_ID = 4           'tran_id
        Const POS_CMD_ACCCMD = 9        'Acc_Cmd:Sub-Sub-Cmd
        Const POS_CMD_GOOD = 10         '"G" data position
        
        On Error GoTo ERRCMD
        
        flag = False
        
        ReDim DapData(bytesTotal)
        
        If OptTestMode(0).Value = True Then         'LoopBack Test
            idx = Index
        Else
            idx = 0
        End If
        
        Winsock1(Index).GetData DapData, vbByte
        lens = bytesTotal
        
        DataStr = Bin2Str(DapData, 0, lens)

'-------------------------------------------------------------------------------------------------
#If 1 Then
        RcvDataBuf(idx) = RcvDataBuf(idx) & DataStr
DATA_NEXT:
        If Len(RcvDataBuf(idx)) < TxtSendDataLen(idx) Then Exit Sub     'Have Head, Data Pket Not Rcv Finish
                    
        ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data
        If ret <> 1 Then                 'no head, ignore the data
            If ret = 0 Then                 'no head, ignore the data
                OldData = RcvDataBuf(idx)
                RcvDataBuf(idx) = ""
            Else
                OldData = Left(RcvDataBuf(idx), ret - 1)
                RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)     'Save Old Data
            End If
            
DATA_ERR:
            MsgStr = " COM " & idx + 1 & " Data Error: Garbage Data=" & OldData & ", Old PketNo=" & Hex(TxtRcvPket(idx))
            lerror List1, MsgStr
            Exit Sub
        End If

#If 0 Then
        tmpNo = AscW(Mid(RcvDataBuf(idx), 5, 1))                        'New PketNo Low
        tmpNo = AscW(Mid(RcvDataBuf(idx), 4, 1)) + tmpNo * &H100        'New PketNo High
        'Pket_No(idx) = tmpNo
#Else
        tmpNo = CLng("&H" + Mid(RcvDataBuf(idx), 4, 4)) 'update 2004/08/12, seq no. is a hex string
#End If

        ret = TxtSendDataLen(idx)
        OldData = Left(RcvDataBuf(idx), ret)
        RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret + 1)
        
        '--- Check Data Format ------
        flag = CheckRcvData(idx, OldData)
        If flag = True Then             'Format Exact
            TxtRcvPket(idx) = tmpNo
            TxtCntRcv(idx) = TxtCntRcv(idx) + Len(OldData)
        Else
            GoTo DATA_ERR
        End If
        
'-------------------------------------------------------------------------------------------------
#Else
       If GetHeadFlag(idx) = True Then       'Already Got Head, Receive data
            RcvDataBuf(idx) = RcvDataBuf(idx) & DataStr
            ret = InStr(4, RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data
            '--- Head in Data --------
            If ret > 0 Then
                If Len(RcvDataBuf(idx)) < ret + LEN_PKET_HEAD Then Exit Sub      'Have Head, Data Pket Not Rcv Finish
                
                    
                OldData = Left(RcvDataBuf(idx), ret - 1)       'Get Old Data
                'tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 4, 1))      'New PketNo Low
                'tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 3, 1)) + Pket_No(idx) * &H100   'New PketNo High
                'tmpNo = Pket_No(idx)
                RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)
                '--- Check Old Data Recv Finish --------------
                If Len(OldData) >= TxtSendDataLen(idx) Then     'Receive Finish
                    ret = InStr(OldData, CODE_PKET_HEAD)        'Check Have Head in Data
                    '--- Check Need Don't Care Xon/off -----
                    If ChkXOnOff.Value = 1 Then             'Don't Care Xon/off
                        HeadStr = Mid(OldData, ret, LEN_PKET_HEAD)    'Get Heade String
                        OldData = Replace(OldData, Chr(&H11), "", LEN_PKET_HEAD + 1)  'Discard Head
                        OldData = HeadStr & Replace(OldData, Chr(&H13), "")         '&H11/&H13:Xon/Xoff
                    End If
                    
                    ret = InStr(OldData, CODE_PKET_HEAD)        'Check Have Head in Data
                    tmpNo = AscW(Mid(OldData, ret + 4, 1))      'New PketNo High
                    tmpNo = AscW(Mid(OldData, ret + 3, 1)) + tmpNo * &H100   'New PketNo Low
                    '--- Check Data Format ----------
                    flag = CheckRcvData(idx, OldData)
                    If flag = True Then             'Format Exact
                        TxtRcvPket(idx) = tmpNo
                        TxtCntRcv(idx) = TxtCntRcv(idx) + Len(OldData)
                    Else
                        GoTo DATA_ERR
                    End If
                Else                                            'Not Finish, Data Error
                
                    'RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)     'Get New Data
DATA_ERR:
                    MsgStr = " COM " & idx + 1 & " Data Error: Old PketNo=" & (tmpNo) & ", OldData=" & OldData & _
                            ", New PketNo=" & (Pket_No(idx)) & ", NewData=" & RcvDataBuf(idx)
                    lerror List1, MsgStr
                    
                    Exit Sub
                End If
            Else                'Head not in Data
                If Len(RcvDataBuf(idx)) >= TxtSendDataLen(idx) Then 'Receive Finish
                    '--- Check Data Format ----------
                    ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data
                    tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 4, 1))      'New PketNo Low
                    tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 3, 1)) + tmpNo * &H100 'New PketNo High
                    'Pket_No(idx) = tmpNo
                    OldData = Left(RcvDataBuf(idx), TxtSendDataLen(idx))
                    RcvDataBuf(idx) = Mid(RcvDataBuf(idx), TxtSendDataLen(idx) + 1)
                    'tmpNo = Pket_No(idx)
                    'Pket_No(idx) = 0
                    '--- Check Need Don't Care Xon/off -----
                    If ChkXOnOff.Value = 1 Then             'Don't Care Xon/off
                        HeadStr = Mid(OldData, 1, LEN_PKET_HEAD)    'Get Heade String
                        OldData = Replace(OldData, Chr(&H11), "", LEN_PKET_HEAD + 1)  'Discard Head
                        OldData = HeadStr & Replace(OldData, Chr(&H13), "")         '&H11/&H13:Xon/Xoff
                    End If
                    flag = CheckRcvData(idx, OldData)
                    If flag = True Then             'Format Exact
                        TxtRcvPket(idx) = tmpNo
                        TxtCntRcv(idx) = TxtCntRcv(idx) + Len(OldData)
                    Else
                        GoTo DATA_ERR
                    End If
                End If
            End If  'Head in Data
        Else                                'Un-got Data Head
            RcvDataBuf(idx) = RcvDataBuf(idx) & DataStr
            ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data
            If ret > 0 Then             'Have Head
                If Len(RcvDataBuf(idx)) < ret + LEN_PKET_HEAD Then Exit Sub      'Have Head, Data Pket Not Rcv Finish
                    
                tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 4, 1))      'New PketNo Low
                tmpNo = AscW(Mid(RcvDataBuf(idx), ret + 3, 1)) + tmpNo * &H100 'New PketNo High
                'Pket_No(idx) = tmpNo
                GetHeadFlag(idx) = True
                If ret > 1 Then                 'Log Error Data
                    OldData = Left(RcvDataBuf(idx), ret - 1)
                    'RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)     'Save Old Data
                    MsgStr = " COM " & idx + 1 & " Data Error: Garbage Data=" & OldData & ", New PketNo=" & Hex(tmpNo)
                    lerror List1, MsgStr
                End If
                '--- Chcek Have Next Packet ---------
                ret = InStr(4, RcvDataBuf(idx), CODE_PKET_HEAD)
                If ret = 0 Then                 'Only the Packet
                    OldData = RcvDataBuf(idx)
                     '--- Check Need Don't Care Xon/off -----
                    If ChkXOnOff.Value = 1 Then             'Don't Care Xon/off
                        HeadStr = Mid(OldData, 1, LEN_PKET_HEAD)    'Get Heade String
                        OldData = Replace(OldData, Chr(&H11), "", LEN_PKET_HEAD + 1)  'Discard Head
                        OldData = HeadStr & Replace(OldData, Chr(&H13), "")         '&H11/&H13:Xon/Xoff
                    End If
                    If Len(OldData) < TxtSendDataLen(idx) Then Exit Sub    'Receive UnFinish
                    RcvDataBuf(idx) = ""
                    GetHeadFlag(idx) = False
                Else                            'Have Next Packet
                    OldData = Left(RcvDataBuf(idx), ret - 1)
                    RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret)
                    '--- Check Need Don't Care Xon/off -----
                    If ChkXOnOff.Value = 1 Then             'Don't Care Xon/off
                        HeadStr = Mid(OldData, 1, LEN_PKET_HEAD)    'Get Heade String
                        OldData = Replace(OldData, Chr(&H11), "", LEN_PKET_HEAD + 1)  'Discard Head
                        OldData = HeadStr & Replace(OldData, Chr(&H13), "")         '&H11/&H13:Xon/Xoff
                    End If
                    ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD)       'Check Have Head in Data
                    
                End If
                '--- Check Data Format ------
                flag = CheckRcvData(idx, OldData)
                If flag = True Then             'Format Exact
                    TxtRcvPket(idx) = tmpNo
                    TxtCntRcv(idx) = TxtCntRcv(idx) + Len(OldData)
                End If
                
            Else
                GoTo DATA_ERR
            End If               'No Head
            
            
        End If
'-------------------------------------------------------------------------------------------------
#End If

        '--- Check Receive Packet No -------
        If flag Then            'Receive Format Exact
            Debug.Print "tmpNo=" & tmpNo
            ret = tmpNo - Pket_No(idx)      'New-Old
            If ret > 1 Then        'Packet Loss
#If 1 Then
                MsgStr = " COM " & idx + 1 & ", " + CStr(ret) + " Packet Loss: " & CStr(Pket_No(idx) + 1) & "," & CStr(tmpNo)
                lerror List1, MsgStr
#Else
                For i = 1 To ret - 1
                    MsgStr = " COM " & idx + 1 & " Packet Loss: PketNo=" & Pket_No(idx) + i
                    lerror List1, MsgStr
                Next i
#End If
            ElseIf ret <= 0 Then
                MsgStr = " COM " & idx + 1 & " Packet Reverse: Old PketNo=" & Pket_No(idx) & ", New PketNo=" & tmpNo
                lerror List1, MsgStr
            End If
            
            Pket_No(idx) = tmpNo
            If RcvMode(idx) = RCV_TIMEOUT Then      'Time Out Mode
                'tmpstr = Bin2Str(DapData, 0, lens)
                'RcvDataBuf(idx) = RcvDataBuf(idx) & tmpstr
                If 1 Then   'Len(RcvDataBuf(idx)) >= TxtSendDataLen(idx) Then   'Receive Finish
                    If TmrSend(idx).Enabled = True Then   'On Sending
                        WSendData idx, TxtSendData(idx)
                        'Winsock1(idx).SendData RcvDataBuf(idx)
                        TxtCntSendTal(idx) = TxtCntSendTal(idx) + Len(RcvDataBuf(idx))
                        'RcvDataBuf(idx) = ""
                        '--- Reset Timer Counter ------
                        TmrSend(idx).Enabled = False
                        TmrSend(idx).Enabled = True
                    End If
                End If
            End If
        End If

            
        'List1.AddItem "Rcv :" & lens
        
        TxtCntLoss(idx) = TxtCntSend(idx) - TxtCntRcv(idx)
        
        
        If Len(RcvDataBuf(idx)) <> 0 Then
            GoTo DATA_NEXT
        Else
            If InStr(CmdSendBeg(idx).Caption, "Start") > 0 Then   'Press Stop
                '--- Check Full Data Receive --------
                If flag Then    'TxtCntLoss(idx) = "0" And OldLoss(idx) <> "0" Then
                    MsgStr = " COM " & idx + 1 & " Full Receive:" & " Send=" & TxtCntSendTal(idx) & ", Send OK=" & _
                            TxtCntSend(idx) & ", Receive=" & TxtCntRcv(idx) & ", Total Loss=" & TxtCntLoss(idx) & _
                            ", SendPket=" & TxtSendPketTal(idx) & ", RcvPket=" & TxtRcvPket(idx)
                    lerror List1, MsgStr
                    OldLoss(idx) = TxtCntLoss(idx)
                Else
                    OldLoss(idx) = TxtCntLoss(idx)
                End If
            End If
        End If
                
        Exit Sub
        
        Resume
    
ERRCMD:
    MsgStr = "Winsock1.DataArrival Err: " & Error
    lerror List1, MsgStr

End Sub

Private Sub Winsock1_Error(Index As Integer, ByVal Number As Integer, Description As String, ByVal Scode As Long, ByVal Source As String, ByVal HelpFile As String, ByVal HelpContext As Long, CancelDisplay As Boolean)
        
    On Error Resume Next
    
    Dim MsgStr As String
    MsgStr = " COM " & Index + 1 & " Winsock Error: (" & Number & ") " & Description
    lerror List1, MsgStr

End Sub

Private Sub Winsock1_SendComplete(Index As Integer)
'        MsgBox Index & "  DAP SendComplete"
        

End Sub

Private Sub Winsock1_SendProgress(Index As Integer, ByVal bytesSent As Long, ByVal bytesRemaining As Long)
       ' List1.AddItem Index & "  DAP SendProgress " & bytesSent & ", " & bytesRemaining
    Dim MsgStr As String
    
    TxtCntSend(Index) = TxtCntSend(Index) + bytesSent
     
    '--- Check Remaind Counter ----
    If bytesRemaining > 0 Then          'Have Remaining
        MsgStr = " COM " & Index + 1 & " WinsockSend Remaind: Sending=" & bytesSent & ", Remaining=" & bytesRemaining
        lerror List1, MsgStr
        
        MsgStr = " COM " & Index + 1 & " Send=" & TxtCntSendTal(Index) & ", Send OK=" & TxtCntSend(Index) & ", Receive=" & TxtCntRcv(Index) & ", Total Loss=" & TxtCntLoss(Index)
        lerror List1, MsgStr
    End If
    
End Sub
