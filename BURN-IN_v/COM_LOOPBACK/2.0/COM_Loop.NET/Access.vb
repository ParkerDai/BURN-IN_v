Option Strict Off
Option Explicit On
Module Access
	
	Public Const LB_SETHORIZONTALEXTENT As Integer = &H194
	'UPGRADE_ISSUE: 不支援宣告參數 'As Any'。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
	Declare Function SendMessage Lib "user32"  Alias "SendMessageA"(ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, ByRef lParam As Any) As Integer
	Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer) '---------add by Elle
	
	Public Const CMD_2ACC As Integer = &H63
	'--- ACCESS Command Set ------------
	Public Const CMD_ADD_COMP As String = "A"
	Public Const CMD_DEL_COMP As String = "F"
	Public Const CMD_QRY_COMP As String = "C"
	Public Const CMD_ADD_ID As String = "E"
	Public Const CMD_DEL_ID As String = "V"
	Public Const CMD_QRY_ID As String = "Q"
	Public Const CMD_SET_GROUP As String = "Z"
	Public Const CMD_SET_HOLIDAY As String = "J"
	Public Const CMD_SET_ALARM As String = "X"
	Public Const CMD_OPEN_LUCK_TIME As String = "U"
	Public Const CMD_ALOW_OPEN_TIME As String = "P"
	Public Const CMD_SET_TIME As String = "D"
	Public Const CMD_READER_MODE As String = "M"
	Public Const CMD_OPEN_DOOR As String = "O"
	Public Const CMD_GET_RECD As String = "L"
	Public Const CMD_SCHEDULE As String = "S"
	
	Public Const CMD_ACK_GOOD As String = "G"
	
	'--- Access Timeout ----------------
	Public Const CNST_DAY_SEC As Integer = 86400
	Public Const CNST_TIMEOUT_ACC As Short = 3 'Sec
	
	'--- Menu Function Constant --------
	Public Const MENU_ADD_ID As Short = 1
	Public Const MENU_SET_GROUP As Short = 2
	Public Const MENU_SET_HOLIDAY As Short = 3
	Public Const MENU_QUERY_ID As Short = 4
	Public Const MENU_LOG_LIST As Short = 5
	
	
	Public AckFlag As Boolean 'after send command, waitting Acc ack
	Public MenuFlag As String
	Public AccRptData As String
	
	Public FileName As String
	Public OldDrive As String 'Declare on Module
	Public OldPath As String 'Declare on Module
	
	Public Const MAX_COM_PORT As Short = 7 '---------add by Elle
	Public iRx(MAX_COM_PORT) As Integer '---------add by Elle
	Public iTx(MAX_COM_PORT) As Integer '---------add by Elle
	Public iLoss(MAX_COM_PORT) As Integer '---------add by Elle
	Public iError(MAX_COM_PORT) As Integer '---------add by Elle
	
	
	Sub LoadForm(ByRef Ctrl As Object)
		'UPGRADE_ISSUE: 不支援 Load 陳述式。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="B530EFF2-3132-48F8-B8BC-D88AF543D321"'
		Load(Ctrl)
		'UPGRADE_WARNING: 無法解析物件 Ctrl.Show 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Ctrl.Show()
		
	End Sub
	
	
	
	
	Sub FillList2(ByRef cbo As System.Windows.Forms.Control, ByRef lbl As Object, ByRef strdelimiter As String)
		'----------------------------------------------------------------------------
		' .Parsing a string to a LIST, the delimiter is '^'
		' .cbo: the LIST
		' .lbl: the input string
		'----------------------------------------------------------------------------
		Dim lasti, i, deli_len As Short
		
		'UPGRADE_WARNING: 無法解析物件 cbo.Clear 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		cbo.Clear()
		deli_len = Len(strdelimiter)
		i = 1
		Do 
			lasti = i
			'---Match "^" in string: &lbl[lasti]
			'UPGRADE_WARNING: 無法解析物件 lbl 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			i = InStr(lasti, lbl, strdelimiter)
			If i = 0 Then '---No match, the last one
				'---string: &lbl[lasti], and remove starting & ending blank
				'UPGRADE_WARNING: 無法解析物件 lbl 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: 無法解析物件 cbo.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cbo.AddItem(Trim(Mid(lbl, lasti)))
				Exit Do
				'ElseIf i = lasti Then
				'ignore
			Else
				'UPGRADE_WARNING: 無法解析物件 lbl 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: 無法解析物件 cbo.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				cbo.AddItem(Trim(Mid(lbl, lasti, i - lasti)))
			End If
			i = i + deli_len
		Loop 
	End Sub
	
	Sub TxtSetFocus(ByRef Entity As System.Windows.Forms.Control)
		On Error Resume Next
		
		Entity.Enabled = True
		'UPGRADE_WARNING: 無法解析物件 Entity.SelStart 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Entity.SelStart = 0
		'UPGRADE_WARNING: 無法解析物件 Entity.SelLength 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		Entity.SelLength = Len(Entity.Text)
		Entity.Focus()
	End Sub
	
	Sub SendAutoRptAck(ByRef Wsock As AxMSWinsockLib.AxWinsock, ByRef TranId As Short, ByRef AccCmd As String)
		'UPGRADE_NOTE: str 升級為 str_Renamed。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		Dim str_Renamed, addr As String
		Dim datalen As Short
		Dim data(9) As Byte
		
		data(0) = 10 'length_L
		data(1) = 0 'length_H
		data(2) = &H60 'Message TYpe
		data(3) = TranId
		data(4) = 0
		data(5) = 0
		data(6) = &H63 'subCmd
		data(7) = 0 'subNode
		data(8) = Asc(AccCmd) 'AccCmd
		data(9) = Asc("3") 'Move Next record
		
		Wsock.SendData(data)
		
	End Sub
	
	Sub lerror(ByRef LstCtrl As System.Windows.Forms.ListBox, ByRef MsgStr As String)
		
		LstCtrl.Items.Add(VB6.Format(Today, "mm/dd") & " " & VB6.Format(TimeOfDay, "hh:mm:ss") & MsgStr)
		LstCtrl.SelectedIndex = LstCtrl.Items.Count - 1
		
		lerror2((FrmMain.TxtLogFile).Text, MsgStr)
		
	End Sub
	
	Sub lerror2(ByRef fname As String, ByRef Data1 As String)
		Dim fnum As Object
		Dim date1 As Object
		Dim time1 As String
		
		On Error GoTo LERR99
		
		'UPGRADE_WARNING: 無法解析物件 fnum 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fnum = FreeFile
		'UPGRADE_WARNING: 無法解析物件 date1 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		date1 = VB6.Format(Today, "MM/DD")
		time1 = VB6.Format(TimeOfDay, "HH:MM:SS")
		
		'UPGRADE_WARNING: 無法解析物件 fnum 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(fnum, fname, OpenMode.Append)
		'UPGRADE_WARNING: 無法解析物件 date1 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: 無法解析物件 fnum 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		PrintLine(fnum, date1 & " " & time1 & " " & Data1)
		'Print #fnum, time1; " " & Data1
		'UPGRADE_WARNING: 無法解析物件 fnum 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(fnum)
		
		Exit Sub
LERR99: 
		MsgBox("Log File Error: " & ErrorToString())
		
	End Sub
End Module