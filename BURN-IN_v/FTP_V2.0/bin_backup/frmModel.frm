VERSION 5.00
Begin VB.Form frmModel 
   Caption         =   "CPU:5200 ORT-TEST Model Select V1.0"
   ClientHeight    =   750
   ClientLeft      =   9585
   ClientTop       =   3780
   ClientWidth     =   5160
   LinkTopic       =   "Form1"
   MaxButton       =   0   'False
   ScaleHeight     =   750
   ScaleWidth      =   5160
   Begin VB.CommandButton cmdfrmtcp 
      BackColor       =   &H00C0E0FF&
      Caption         =   "Call ORT-TEST"
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
      Left            =   3120
      MaskColor       =   &H80000000&
      Style           =   1  '圖片外觀
      TabIndex        =   1
      Top             =   240
      Width           =   1935
   End
   Begin VB.ComboBox cblModel 
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
      ForeColor       =   &H00800000&
      Height          =   405
      ItemData        =   "frmModel.frx":0000
      Left            =   1080
      List            =   "frmModel.frx":0002
      TabIndex        =   0
      Top             =   240
      Width           =   1935
   End
   Begin VB.Label lblModel 
      Caption         =   "Model :"
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
      Left            =   120
      TabIndex        =   2
      Top             =   240
      Width           =   855
   End
End
Attribute VB_Name = "frmModel"
Attribute VB_GlobalNameSpace = False
Attribute VB_Creatable = False
Attribute VB_PredeclaredId = True
Attribute VB_Exposed = False
Private Sub cmdfrmtcp_Click()
If cblModel.Text = "" Then
MsgBox ("Please choose model first !")
Exit Sub
Else
End If

'FrmMain.txtMappingModel.Text = frmModel.cblModel.Text
   
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''write model name
    Dim FileNumber As Long
    Dim fname As String

     FileNumber = FreeFile
    
     fname = App.Path & "\write_model.txt"
     
     Open fname For Output As #FileNumber
     Print #FileNumber, cblModel.Text
     Close #FileNumber
'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
            
'    Dim FileNo
'    Dim strString As String
'    FileNo = FreeFile()
'
'    Open App.Path & "\write_model.txt" For Input As #FileNo
'    While Not EOF(FileNo)
'        Line Input #FileNo, strString
'        cblModel.Text (cblModel.Text & strString)
'    Wend
'    Close #FileNo
     
frmtcp.Show
Exit Sub
End Sub

Private Sub Form_Load()
   '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Select model name
    Dim FileNo
    Dim strString As String
    FileNo = FreeFile()
    
    Open App.Path & "\model_CPU5200.txt" For Input As #FileNo
    While Not EOF(FileNo)
        Line Input #FileNo, strString
        cblModel.AddItem (cblModel.Text & strString)
    Wend
    Close #FileNo
End Sub
