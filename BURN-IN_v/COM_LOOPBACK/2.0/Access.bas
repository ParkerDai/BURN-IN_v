Attribute VB_Name = "Access"
Option Explicit

Public Const LB_SETHORIZONTALEXTENT = &H194
Declare Function SendMessage _
        Lib "user32" _
        Alias "SendMessageA" (ByVal hwnd As Long, _
                              ByVal wMsg As Long, _
                              ByVal wParam As Long, _
                              lParam As Any) As Long
Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long)  '---------add by Elle

Global Const CMD_2ACC = &H63
'--- ACCESS Command Set ------------
Global Const CMD_ADD_COMP = "A"
Global Const CMD_DEL_COMP = "F"
Global Const CMD_QRY_COMP = "C"
Global Const CMD_ADD_ID = "E"
Global Const CMD_DEL_ID = "V"
Global Const CMD_QRY_ID = "Q"
Global Const CMD_SET_GROUP = "Z"
Global Const CMD_SET_HOLIDAY = "J"
Global Const CMD_SET_ALARM = "X"
Global Const CMD_OPEN_LUCK_TIME = "U"
Global Const CMD_ALOW_OPEN_TIME = "P"
Global Const CMD_SET_TIME = "D"
Global Const CMD_READER_MODE = "M"
Global Const CMD_OPEN_DOOR = "O"
Global Const CMD_GET_RECD = "L"
Global Const CMD_SCHEDULE = "S"

Global Const CMD_ACK_GOOD = "G"

'--- Access Timeout ----------------
Global Const CNST_DAY_SEC = 86400
Global Const CNST_TIMEOUT_ACC = 3        'Sec

'--- Menu Function Constant --------
Global Const MENU_ADD_ID = 1
Global Const MENU_SET_GROUP = 2
Global Const MENU_SET_HOLIDAY = 3
Global Const MENU_QUERY_ID = 4
Global Const MENU_LOG_LIST = 5

Global AckFlag As Boolean        'after send command, waitting Acc ack
Global MenuFlag  As String
Global AccRptData As String

Global FileName As String
Global OldDrive As String      'Declare on Module
Global OldPath As String       'Declare on Module

Public Const MAX_COM_PORT   As Integer = 31
Public iRx(MAX_COM_PORT)    As Long
Public iTx(MAX_COM_PORT)    As Long
Public iLoss(MAX_COM_PORT)  As Long
Public iError(MAX_COM_PORT) As Long

Sub LoadForm(Ctrl As Object)
    Load Ctrl
    Ctrl.Show
    
End Sub

Sub FillList2(cbo As Control, lbl As Variant, strdelimiter As String)
    '----------------------------------------------------------------------------
    ' .Parsing a string to a LIST, the delimiter is '^'
    ' .cbo: the LIST
    ' .lbl: the input string
    '----------------------------------------------------------------------------
    Dim i As Integer, lasti As Integer, deli_len As Integer

    cbo.Clear
    deli_len = Len(strdelimiter)
    i = 1

    Do
        lasti = i
        '---Match "^" in string: &lbl[lasti]
        i = InStr(lasti, lbl, strdelimiter)

        If i = 0 Then       '---No match, the last one
            '---string: &lbl[lasti], and remove starting & ending blank
            cbo.AddItem Trim$(Mid(lbl, lasti))

            Exit Do

            'ElseIf i = lasti Then
            'ignore
        Else
            cbo.AddItem Trim$(Mid(lbl, lasti, i - lasti))
        End If

        i = i + deli_len
    Loop

End Sub

Sub TxtSetFocus(Entity As Control)

    On Error Resume Next
    
    Entity.Enabled = True
    Entity.SelStart = 0
    Entity.SelLength = Len(Entity.Text)
    Entity.SetFocus
End Sub

Sub SendAutoRptAck(Wsock As WinSock, TranId As Integer, AccCmd As String)
    Dim str     As String, addr As String
    Dim datalen As Integer
    Dim data(9) As Byte
    
    data(0) = 10        'length_L
    data(1) = 0         'length_H
    data(2) = &H60      'Message TYpe
    data(3) = TranId
    data(4) = 0
    data(5) = 0
    data(6) = &H63      'subCmd
    data(7) = 0         'subNode
    data(8) = Asc(AccCmd)  'AccCmd
    data(9) = Asc("3")       'Move Next record
    
    Wsock.SendData data

End Sub

Sub lerror(LstCtrl As ListBox, MsgStr As String)

    LstCtrl.AddItem Format(Date, "mm/dd") & " " & Format(Time, "hh:mm:ss") & MsgStr
    LstCtrl.ListIndex = LstCtrl.ListCount - 1
    
    lerror2 FrmMain.TxtLogFile, MsgStr

End Sub

Sub lerror2(fname As String, Data1 As String)
    Dim fnum
    Dim date1, time1 As String
    
    On Error GoTo LERR99
    
    fnum = FreeFile
    date1 = Format(Date, "MM/DD")
    time1 = Format(Time, "HH:MM:SS")

    Open fname For Append As fnum
    Print #fnum, date1 & " " & time1; " " & Data1
    'Print #fnum, time1; " " & Data1
    Close #fnum
    
    Exit Sub

LERR99:
    MsgBox "Log File Error: " & Error
    
End Sub

