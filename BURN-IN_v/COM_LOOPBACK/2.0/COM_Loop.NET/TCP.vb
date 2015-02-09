Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class FrmMain
	Inherits System.Windows.Forms.Form
	'Update:
	'  2004/08/12: update packet's sequential number to hex string
	
	'---------------------Evan Exchanged 2 value became 7 (and below) value (for COM3~COM8 of socket) 2007/10/22
	Dim socket(7) As Integer
	Dim StartDate As String
	Dim StartTime As String
	
	Dim LossCnt(7) As String
	Dim OldLoss(7) As String
	Dim BaseIntval(7) As Short
	
	Dim RcvDataBuf(7) As String
	Dim RcvMode(7) As Short
	
	Dim IntervalSecMax(7) As Integer
	Dim IntervalSecCnt(7) As Integer
	
	'---------------------Evan Exchanged end 2007/10/22
	
	Const RCV_PERIOD As Short = 1 'When SendInterval>0, Send Data On Time
	Const RCV_TIMEOUT As Short = 2 'When SendInterval=0, Send Data Real Time
	
	'Const LEN_PKET_HEAD = 5        'Packet Header:"AAA" + PketNo_Low(1) + PketNo_High(1)
	Const LEN_PKET_HEAD As Short = 7 'Packet Header:"AAA" + hex(PketNo)(4byte)
	Const CODE_PKET_HEAD As String = "AAA"
	Dim GetIP() As String '--------add by Elle
	Dim COMs As Short '--------add by Elle
	Public iShow_Port As Short '------add by Elle
	Dim FFFF_getpkno As Integer '-----add by Elle
	Dim Send_data(7) As String '-----add by Elle
	Dim Receive_data(7) As String '-----add by Elle
	Dim OK_flg(7) As Boolean '--------add by Elle
	Dim multiple(7) As Short '--------add by Elle
	
	
	Private Sub clean_arp() 'Evan added 2007/10/22
		
		Dim ip1 As String
		Dim ip2 As String
		Dim RetVal As Object
		
		On Error Resume Next
		'UPGRADE_WARNING: 無法解析物件 RetVal 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RetVal = Shell("arp -d", 0)
		'    'RetVal = Shell("arp -d 10.0.50.100", 3)
		'    'RetVal = Shell("arp -d 192.168.1.1", 3)
		'
		'    RetVal = Shell("arp -d " & ip1, 0)
		'    RetVal = Shell("arp -d " & ip2, 0)
		''    RetVal = Shell("arp -d " & ip3, 0)
		''    RetVal = Shell("arp -d " & ip4, 0)
		'    RetVal = Shell("arp -d 10.0.50.100", 0)
		'    RetVal = Shell("arp -d 192.168.1.1", 0)
		''    RetVal = Shell("arp -d 10.0.50.102", 0)
		''    RetVal = Shell("arp -d 10.0.50.103", 0)
	End Sub
	
	Private Sub CmdBrow_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdBrow.Click
		
		' MenuFlag = MENU_LOG_LIST
		' LoadForm FrmFile
		
	End Sub
	
	Private Sub CmdClrCnt_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdClrCnt.Click
		Dim Index As Short = CmdClrCnt.GetIndex(eventSender) '------clear data
		Dim MsgStr As String
		
		'    If OptTestMode(0).Value = False And Index = 1 Then Exit Sub  'Cross Test    '-------comma by Elle
		
		'--- Log Clear Data ----
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & " Clear Counter " & Index + 1 & ": " & " Send=" & TxtCntSendTal(Index).Text & ", Send OK=" & TxtCntSend(Index).Text & ", Receive=" & TxtCntRcv(Index).Text & ", Total Loss=" & TxtCntLoss(Index).Text
		lerror(List1, MsgStr)
		
		TxtCntSendTal(Index).Text = "0"
		TxtCntSend(Index).Text = "0"
		TxtCntRcv(Index).Text = "0"
		TxtCntLoss(Index).Text = "0"
		
	End Sub
	
	Private Sub cmdClrList_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdClrList.Click
		List1.Items.Clear()
		txtListCnt.Text = CStr(0)
		
	End Sub
	
	Private Sub cmdCnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCnect.Click
		Dim Index As Short = cmdCnect.GetIndex(eventSender)
		
		Dim MsgStr As String
		Const STR_CONNECT As String = "Connect"
		Const STR_DISCONNECT As String = "Disconnect"
		
		On Error GoTo ERRCMD
		
		clean_arp() 'Evan added 2007/10/22
		
		If cmdCnect(Index).Text = STR_CONNECT Then 'COnnect
			cmdCnect(Index).Text = STR_DISCONNECT
			Winsock1(Index).Close()
			TxtSendPketTal(Index).Text = "0" 'Evan added 2007/10/23
			TxtRcvPket(Index).Text = "0" 'Evan added 2007/10/23
			
			If 1 Or OptTcpUdp(0).Checked = True Then
				Winsock1(Index).Protocol = MSWinsockLib.ProtocolConstants.sckTCPProtocol
				Winsock1(Index).RemoteHost = txtip(Index).Text
				Winsock1(Index).RemotePort = CInt(txtPort(Index).Text)
				Winsock1(Index).LocalPort = CInt(txtLocalPort(Index).Text)
				Winsock1(Index).Connect()
			Else
				Winsock1(Index).Protocol = MSWinsockLib.ProtocolConstants.sckUDPProtocol
				Winsock1(Index).RemoteHost = txtip(Index).Text
				Winsock1(Index).RemotePort = CInt(txtPort(Index).Text)
				Winsock1(Index).Bind(txtLocalPort(Index))
			End If
			
			CmdClrCnt(Index).PerformClick()
			
		Else 'Disconnect
			If InStr(CmdSendBeg(Index).Text, "Stop") > 0 Then 'On Sending,Stop It
				CmdSendBeg(Index).PerformClick()
			End If
			Winsock1(Index).Close()
			cmdCnect(Index).Text = STR_CONNECT
			txtLocalPort(Index).Text = CStr(0)
			CmdSendBeg(Index).Enabled = False
			
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & Index + 1 & " Close OK!"
			lerror(List1, MsgStr)
		End If
		
		'--- Check Test mode -------
		'---------------------below change by Elle---------------------------
		'    If OptTestMode(0).Value = False Then        'Cross Test  '----comma by Elle
		'        If Index = 0 Then cmdCnect_Click 1                   '----comma by Elle
		'    End If                                                   '----comma by Elle
		'---------------------upper change by Elle---------------------------
		
		'--- Maintain Enable OptTestMode ------
		If cmdCnect(0).Text = STR_CONNECT And cmdCnect(1).Text = STR_CONNECT And cmdCnect(2).Text = STR_CONNECT And cmdCnect(3).Text = STR_CONNECT And cmdCnect(4).Text = STR_CONNECT And cmdCnect(5).Text = STR_CONNECT And cmdCnect(6).Text = STR_CONNECT And cmdCnect(7).Text = STR_CONNECT Then 'Evan added cmdCnect(2) ~ cmdCnect(7) (for COM3~COM8) 2007/10/22
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
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & "CmdCnect Err: " & ErrorToString()
		lerror(List1, MsgStr)
	End Sub
	
	
	Private Sub cmdComtesttotal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdComtesttotal.Click 'Evan added
		''
		''CmdSendBeg_Click (0)
		''CmdSendBeg_Click (1)
		''CmdSendBeg_Click (2)
		''CmdSendBeg_Click (3)
		''CmdSendBeg_Click (4)
		''CmdSendBeg_Click (5)
		''CmdSendBeg_Click (6)
		''CmdSendBeg_Click (7)
		''
		''cmdContotal.Enabled = False
		''TxtSendIntvaltoall.Enabled = False
		''TxtSendDataLentoall.Enabled = False
		''cmdComtesttotal.Caption = "Stop to all"
		''
		''    If CmdSendBeg(0).Caption = "Start 1" And CmdSendBeg(1).Caption = "Start 2" And CmdSendBeg(2).Caption = "Start 3" And CmdSendBeg(3).Caption = "Start 4" And CmdSendBeg(4).Caption = "Start 5" And CmdSendBeg(5).Caption = "Start 6" And CmdSendBeg(6).Caption = "Start 7" And CmdSendBeg(7).Caption = "Start 8" Then
		''       cmdComtesttotal.Caption = "Start to all"
		''       cmdContotal.Enabled = True
		''       TxtSendIntvaltoall.Enabled = True
		''       TxtSendDataLentoall.Enabled = True
		''    End If
		'If txtMappingModel.Text = "CE5101-16" Then
		'
		'  CmdSendBeg_Click (0)
		'  cmdContotal.Enabled = False
		'    TxtSendIntvaltoall.Enabled = False
		'    TxtSendDataLentoall.Enabled = False
		'    cmdComtesttotal.Caption = "Stop to all"
		'
		'    If CmdSendBeg(0).Caption = "Start 1" Then
		'       cmdComtesttotal.Caption = "Start to all"
		'       cmdContotal.Enabled = True
		'       TxtSendIntvaltoall.Enabled = True
		'       TxtSendDataLentoall.Enabled = True
		'    Exit Sub
		'    End If
		'
		'
		'
		'End If
		'
		'
		'If txtMappingModel.Text = "SE1402" Or txtMappingModel.Text = "SE7202" Or txtMappingModel.Text = "SE7402" Or txtMappingModel.Text = "C1402" Or txtMappingModel.Text = "C1502" Or txtMappingModel.Text = "SE5302" Then
		'
		'    CmdSendBeg_Click (0)
		'    CmdSendBeg_Click (1)
		'
		'    cmdContotal.Enabled = False
		'    TxtSendIntvaltoall.Enabled = False
		'    TxtSendDataLentoall.Enabled = False
		'    cmdComtesttotal.Caption = "Stop to all"
		'
		'    If CmdSendBeg(0).Caption = "Start 1" And CmdSendBeg(1).Caption = "Start 2" Then
		'       cmdComtesttotal.Caption = "Start to all"
		'       cmdContotal.Enabled = True
		'       TxtSendIntvaltoall.Enabled = True
		'       TxtSendDataLentoall.Enabled = True
		'    Exit Sub
		'    End If
		'End If
		'
		'If txtMappingModel.Text = "SE1404" Or txtMappingModel.Text = "SE5404" Or txtMappingModel.Text = "SE7404" Or txtMappingModel.Text = "CS514" Or txtMappingModel.Text = "MG514" Or txtMappingModel.Text = "Xport514" Then
		'    CmdSendBeg_Click (0)
		'    CmdSendBeg_Click (1)
		'    CmdSendBeg_Click (2)
		'    CmdSendBeg_Click (3)
		'    cmdContotal.Enabled = False
		'    TxtSendIntvaltoall.Enabled = False
		'    TxtSendDataLentoall.Enabled = False
		'    cmdComtesttotal.Caption = "Stop to all"
		'
		'    If CmdSendBeg(0).Caption = "Start 1" And CmdSendBeg(1).Caption = "Start 2" And CmdSendBeg(2).Caption = "Start 3" And CmdSendBeg(3).Caption = "Start 4" Then
		'       cmdComtesttotal.Caption = "Start to all"
		'       cmdContotal.Enabled = True
		'       TxtSendIntvaltoall.Enabled = True
		'       TxtSendDataLentoall.Enabled = True
		'    Exit Sub
		'    End If
		'End If
		'
		'
		'
		'
		'
		'
		''If txtMappingModel.Text = "SE1404" Or txtMappingModel.Text = "SE5404" Or txtMappingModel.Text = "SE7404" Or txtMappingModel.Text = "CS514" Or txtMappingModel.Text = "MG514" Or txtMappingModel.Text = "Xport514" Then
		''    CmdSendBeg_Click (0)
		''    CmdSendBeg_Click (1)
		''    CmdSendBeg_Click (2)
		''    CmdSendBeg_Click (3)
		''
		''    cmdContotal.Enabled = False
		''    TxtSendIntvaltoall.Enabled = False
		''    TxtSendDataLentoall.Enabled = False
		''    cmdComtesttotal.Caption = "Stop to all"
		''
		''    If CmdSendBeg(0).Caption = "Start 1" And CmdSendBeg(1).Caption = "Start 2" And CmdSendBeg(2).Caption = "Start 3" And CmdSendBeg(3).Caption = "Start 4" Then
		''       cmdComtesttotal.Caption = "Start to all"
		''       cmdContotal.Enabled = True
		''       TxtSendIntvaltoall.Enabled = True
		''       TxtSendDataLentoall.Enabled = True
		''    Exit Sub
		''    End If
		''End If
		'
		'If txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "SE7816" Or txtMappingModel.Text = "SE5016" Or txtMappingModel.Text = "SE5116" Or txtMappingModel.Text = "SE5516-IDE" Or txtMappingModel.Text = "SE5008" Or txtMappingModel.Text = "SE6108" Or txtMappingModel.Text = "CS518" Or txtMappingModel.Text = "MG518" Or txtMappingModel.Text = "Xport518" Or txtMappingModel.Text = "SE6116" Or txtMappingModel.Text = "SE1416" Or txtMappingModel.Text = "SE5416" Or txtMappingModel.Text = "SE6416" Or txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "CS516" Or txtMappingModel.Text = "MG516" Or txtMappingModel.Text = "Xport516" Then
		'' If txtMappingModel.Text = "SE5008" Or txtMappingModel.Text = "SE6108" Or txtMappingModel.Text = "CS518" Or txtMappingModel.Text = "MG518" Or txtMappingModel.Text = "Xport518" Or txtMappingModel.Text = "SE5016" Or txtMappingModel.Text = "SE5116" Or txtMappingModel.Text = "SE6116" Or txtMappingModel.Text = "SE1416" Or txtMappingModel.Text = "SE5416" Or txtMappingModel.Text = "SE6416" Or txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "CS516" Or txtMappingModel.Text = "MG516" Or txtMappingModel.Text = "Xport516" Then
		'
		'    CmdSendBeg_Click (0)
		'    CmdSendBeg_Click (1)
		'    CmdSendBeg_Click (2)
		'    CmdSendBeg_Click (3)
		'    CmdSendBeg_Click (4)
		'    CmdSendBeg_Click (5)
		'    CmdSendBeg_Click (6)
		'    CmdSendBeg_Click (7)
		'
		'    cmdContotal.Enabled = False
		'    TxtSendIntvaltoall.Enabled = False
		'    TxtSendDataLentoall.Enabled = False
		'    cmdComtesttotal.Caption = "Stop to all"
		'
		'    If CmdSendBeg(0).Caption = "Start 1" And CmdSendBeg(1).Caption = "Start 2" And CmdSendBeg(2).Caption = "Start 3" And CmdSendBeg(3).Caption = "Start 4" And CmdSendBeg(4).Caption = "Start 5" And CmdSendBeg(5).Caption = "Start 6" And CmdSendBeg(6).Caption = "Start 7" And CmdSendBeg(7).Caption = "Start 8" Then
		'       cmdComtesttotal.Caption = "Start to all"
		'       cmdContotal.Enabled = True
		'       TxtSendIntvaltoall.Enabled = True
		'       TxtSendDataLentoall.Enabled = True
		'    Exit Sub
		'    End If
		'End If
		
		'-----------------------------------below add by Elle-----------------------------------------------
		Dim conn_all, begin As Object
		Dim even As Short
		Dim send_flg As Boolean
		
		send_flg = True
		'UPGRADE_WARNING: 無法解析物件 conn_all 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		conn_all = COMs * UBound(GetIP) '--------all connection
		even = 0
		
		
		If OptTestMode(1).Checked = True Then '-------cross loopback
			'UPGRADE_WARNING: 無法解析物件 conn_all 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For begin = 0 To conn_all - 1
				'UPGRADE_WARNING: 無法解析物件 begin 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				'UPGRADE_WARNING: Mod 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				If begin Mod 2 = 0 Then
					'UPGRADE_WARNING: 無法解析物件 begin 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					CmdSendBeg_Click(CmdSendBeg.Item(begin), New System.EventArgs())
					
					'UPGRADE_WARNING: 無法解析物件 begin 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					If CmdSendBeg(begin).Text = "Start " & begin + 1 Then
						send_flg = False
					End If
				End If
			Next begin
		Else '---------com loopback
			'UPGRADE_WARNING: 無法解析物件 conn_all 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			For begin = 0 To conn_all - 1
				'UPGRADE_WARNING: 無法解析物件 begin 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				CmdSendBeg_Click(CmdSendBeg.Item(begin), New System.EventArgs())
				
				'UPGRADE_WARNING: 無法解析物件 begin 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
				If CmdSendBeg(begin).Text = "Start " & begin + 1 Then
					send_flg = False
				End If
			Next begin
		End If
		
		
		cmdContotal.Enabled = False
		TxtSendIntvaltoall.Enabled = False
		TxtSendDataLentoall.Enabled = False
		cmdComtesttotal.Text = "Stop to all"
		
		If send_flg = False Then
			cmdComtesttotal.Text = "Start to all"
			cmdContotal.Enabled = True
			TxtSendIntvaltoall.Enabled = True
			TxtSendDataLentoall.Enabled = True
			Exit Sub
		End If
		
		'-----------------------------------upper add by Elle-----------------------------------------------
		
	End Sub
	Private Sub cmdContotal_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdContotal.Click 'Evan added 2007/10/22
		
		''    clean_arp 'Evan added
		''
		''    cmdCnect_Click (0)
		''    cmdCnect_Click (1)
		''    cmdCnect_Click (2)
		''    cmdCnect_Click (3)
		''    cmdCnect_Click (4)
		''    cmdCnect_Click (5)
		''    cmdCnect_Click (6)
		''    cmdCnect_Click (7)
		''
		''
		''    If cmdCnect(0).Caption = "Connect" And cmdCnect(1).Caption = "Connect" And cmdCnect(2).Caption = "Connect" And cmdCnect(3).Caption = "Connect" And cmdCnect(4).Caption = "Connect" And cmdCnect(5).Caption = "Connect" And cmdCnect(6).Caption = "Connect" And cmdCnect(7).Caption = "Connect" Then
		''           cmdContotal.Caption = "Connect to all"
		''           cmdComtesttotal.Enabled = False
		''    End If
		''
		''
		''    If cmdCnect(0).Caption = "Disconnect" And cmdCnect(1).Caption = "Disconnect" And cmdCnect(2).Caption = "Disconnect" And cmdCnect(3).Caption = "Disconnect" And cmdCnect(4).Caption = "Disconnect" And cmdCnect(5).Caption = "Disconnect" And cmdCnect(6).Caption = "Disconnect" And cmdCnect(7).Caption = "Disconnect" Then
		''           cmdContotal.Caption = "Disconnect to all"
		''           cmdComtesttotal.Enabled = True
		''    End If
		''
		'    clean_arp 'Evan added
		'
		'
		'If txtMappingModel.Text = "CE5101-16" Then
		'    cmdCnect_Click (0)
		'
		'
		'    If cmdCnect(0).Caption = "Connect" Then
		'           cmdContotal.Caption = "Connect to all"
		'           cmdComtesttotal.Enabled = False
		'    Exit Sub
		'    End If
		'
		'    If cmdCnect(0).Caption = "Disconnect" Then
		'           cmdContotal.Caption = "Disconnect to all"
		'           cmdComtesttotal.Enabled = True
		'    Exit Sub
		'    End If
		'End If
		'
		'
		''If txtMappingModel.Text = "GW21S-MEGA" Then
		'
		'If txtMappingModel.Text = "SE1402" Or txtMappingModel.Text = "SE7202" Or txtMappingModel.Text = "SE7402" Or txtMappingModel.Text = "C1402" Or txtMappingModel.Text = "C1502" Or txtMappingModel.Text = "SE5302" Then
		'    cmdCnect_Click (0)
		'    cmdCnect_Click (1)
		'
		'    If cmdCnect(0).Caption = "Connect" And cmdCnect(1).Caption = "Connect" Then
		'           cmdContotal.Caption = "Connect to all"
		'           cmdComtesttotal.Enabled = False
		'    Exit Sub
		'    End If
		'
		'    If cmdCnect(0).Caption = "Disconnect" And cmdCnect(1).Caption = "Disconnect" Then
		'           cmdContotal.Caption = "Disconnect to all"
		'           cmdComtesttotal.Enabled = True
		'    Exit Sub
		'    End If
		'End If
		'
		'If txtMappingModel.Text = "SE1404" Or txtMappingModel.Text = "SE5404" Or txtMappingModel.Text = "SE7404" Or txtMappingModel.Text = "CS514" Or txtMappingModel.Text = "MG514" Or txtMappingModel.Text = "Xport514" Then
		'    cmdCnect_Click (0)
		'    cmdCnect_Click (1)
		'    cmdCnect_Click (2)
		'    cmdCnect_Click (3)
		'
		'    If cmdCnect(0).Caption = "Connect" And cmdCnect(1).Caption = "Connect" And cmdCnect(2).Caption = "Connect" And cmdCnect(3).Caption = "Connect" Then
		'           cmdContotal.Caption = "Connect to all"
		'           cmdComtesttotal.Enabled = False
		'    Exit Sub
		'    End If
		'    If cmdCnect(0).Caption = "Disconnect" And cmdCnect(1).Caption = "Disconnect" And cmdCnect(2).Caption = "Disconnect" And cmdCnect(3).Caption = "Disconnect" Then
		'           cmdContotal.Caption = "Disconnect to all"
		'           cmdComtesttotal.Enabled = True
		'    Exit Sub
		'    End If
		'End If
		'
		'If txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "SE7816" Or txtMappingModel.Text = "SE5016" Or txtMappingModel.Text = "SE5116" Or txtMappingModel.Text = "SE5516-IDE" Or txtMappingModel.Text = "SE5008" Or txtMappingModel.Text = "SE6108" Or txtMappingModel.Text = "CS518" Or txtMappingModel.Text = "MG518" Or txtMappingModel.Text = "Xport518" Or txtMappingModel.Text = "SE6116" Or txtMappingModel.Text = "SE1416" Or txtMappingModel.Text = "SE5416" Or txtMappingModel.Text = "SE6416" Or txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "CS516" Or txtMappingModel.Text = "MG516" Or txtMappingModel.Text = "Xport516" Then
		''If txtMappingModel.Text = "SE5008" Or txtMappingModel.Text = "SE6108" Or txtMappingModel.Text = "CS518" Or txtMappingModel.Text = "MG518" Or txtMappingModel.Text = "Xport518" Or txtMappingModel.Text = "SE5016" Or txtMappingModel.Text = "SE5116" Or txtMappingModel.Text = "SE6116" Or txtMappingModel.Text = "SE1416" Or txtMappingModel.Text = "SE5416" Or txtMappingModel.Text = "SE6416" Or txtMappingModel.Text = "SE7416" Or txtMappingModel.Text = "CS516" Or txtMappingModel.Text = "MG516" Or txtMappingModel.Text = "Xport516" Then
		'    cmdCnect_Click (0)
		'    cmdCnect_Click (1)
		'    cmdCnect_Click (2)
		'    cmdCnect_Click (3)
		'    cmdCnect_Click (4)
		'    cmdCnect_Click (5)
		'    cmdCnect_Click (6)
		'    cmdCnect_Click (7)
		'
		'   If cmdCnect(0).Caption = "Connect" And cmdCnect(1).Caption = "Connect" And cmdCnect(2).Caption = "Connect" And cmdCnect(3).Caption = "Connect" And cmdCnect(4).Caption = "Connect" And cmdCnect(5).Caption = "Connect" And cmdCnect(6).Caption = "Connect" And cmdCnect(7).Caption = "Connect" Then
		'           cmdContotal.Caption = "Connect to all"
		'           cmdComtesttotal.Enabled = False
		'    Exit Sub
		'    End If
		'    If cmdCnect(0).Caption = "Disconnect" And cmdCnect(1).Caption = "Disconnect" And cmdCnect(2).Caption = "Disconnect" And cmdCnect(3).Caption = "Disconnect" And cmdCnect(4).Caption = "Disconnect" And cmdCnect(5).Caption = "Disconnect" And cmdCnect(6).Caption = "Disconnect" And cmdCnect(7).Caption = "Disconnect" Then
		'           cmdContotal.Caption = "Disconnect to all"
		'           cmdComtesttotal.Enabled = True
		'    Exit Sub
		'    End If
		'End If
		
		'-----------------------------------below add by Elle---------------------------------------------------
		'Dim conn_all, begin As Integer
		'Dim conn_fail_flg, conn_close_flg As Boolean
		'
		'conn_fail_flg = False
		'conn_close_flg = False
		'conn_all = COMs * UBound(GetIP)     '--------all connection
		''conn_all = COMs * IP_num
		'
		'For begin = 0 To conn_all - 1
		'    cmdCnect_Click (begin)
		'
		'    If cmdCnect(begin).Caption = "Connect" Then
		'    Else
		'        conn_fail_flg = True
		'    End If
		'
		'    If cmdCnect(begin).Caption = "Disconnect" Then
		'    Else
		'        conn_close_flg = True
		'    End If
		'Next begin
		'
		'If OptTestMode(1).Value = True Then
		'    CmdSendBeg(3).Visible = False
		'    CmdSendBeg(5).Visible = False
		'    CmdSendBeg(7).Visible = False
		'Else
		'    CmdSendBeg(1).Visible = True
		'    CmdSendBeg(3).Visible = True
		'    CmdSendBeg(5).Visible = True
		'    CmdSendBeg(7).Visible = True
		'End If
		'
		'If conn_fail_flg = False Then
		'    cmdContotal.Caption = "Connect to all"
		'    cmdComtesttotal.Enabled = False
		'    Exit Sub
		'End If
		'
		'If conn_close_flg = False Then
		'    cmdContotal.Caption = "Disconnect to all"
		'    cmdComtesttotal.Enabled = True
		'    Exit Sub
		'End If
		'-----------------------------------upper add by Elle---------------------------------------------------
		
		'-----------------------------------below new connect to all--------------------------------------------------
		Dim conn_all As Object
		Dim begin As Short
		Dim conn_fail_flg As Object
		Dim conn_close_flg As Boolean
		Dim MsgStr As String
		Const STR_CONNECT As String = "Connect"
		Const STR_DISCONNECT As String = "Disconnect"
		'UPGRADE_WARNING: 無法解析物件 conn_fail_flg 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		conn_fail_flg = False
		conn_close_flg = False
		'UPGRADE_WARNING: 無法解析物件 conn_all 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		conn_all = COMs * UBound(GetIP) '--------all connection
		'conn_all = COMs * IP_num
		
		'UPGRADE_WARNING: 無法解析物件 conn_all 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For begin = 0 To conn_all - 1
			If cmdCnect(begin).Text = STR_CONNECT Then 'COnnect
				cmdCnect(begin).Text = STR_DISCONNECT
				TxtSendPketTal(begin).Text = "0" 'Evan added 2007/10/23
				TxtRcvPket(begin).Text = "0" 'Evan added 2007/10/23
				Winsock1(begin).Protocol = MSWinsockLib.ProtocolConstants.sckTCPProtocol
				Winsock1(begin).RemoteHost = txtip(begin).Text
				Winsock1(begin).RemotePort = CInt(txtPort(begin).Text)
				Winsock1(begin).LocalPort = CInt(txtLocalPort(begin).Text)
				Winsock1(begin).Connect()
				CmdClrCnt(begin).PerformClick()
				
			Else 'Disconnect
				If InStr(CmdSendBeg(begin).Text, "Stop") > 0 Then 'On Sending,Stop It
					CmdSendBeg(begin).PerformClick()
				End If
				Winsock1(begin).Close()
				cmdCnect(begin).Text = STR_CONNECT
				txtLocalPort(begin).Text = CStr(0)
				CmdSendBeg(begin).Enabled = False
				
				cmdContotal.Text = "Connect to all"
				cmdComtesttotal.Enabled = False
				
				MsgStr = " " & "IP :" & " " & txtip(begin).Text & " COM " & begin + 1 & " Close OK!"
				lerror(List1, MsgStr)
				
			End If
		Next begin
		
		tmr_winsock.Enabled = True
		tmr_winsock.Interval = 1000
		
		If OptTestMode(1).Checked = True Then
			CmdSendBeg(3).Visible = False
			CmdSendBeg(5).Visible = False
			CmdSendBeg(7).Visible = False
		Else
			CmdSendBeg(1).Visible = True
			CmdSendBeg(3).Visible = True
			CmdSendBeg(5).Visible = True
			CmdSendBeg(7).Visible = True
		End If
		
		'-----------------------------------upper new connect to all--------------------------------------------------
		
	End Sub
	Private Sub cmdListen_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdListen.Click
		Winsock1(1).LocalPort = CInt(txtPort(1).Text)
		Winsock1(1).Listen()
		txtLocalPort(1).Text = CStr(Winsock1(1).LocalPort)
		
	End Sub
	
	Private Sub CmdSaveList_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSaveList.Click
		Dim tmpstr, MsgStr, op As String
		Dim Index, i, lens As Short
		
		For i = 0 To List1.Items.Count - 1
			op = VB6.GetItemString(List1, i)
			Index = CShort(VB.Left(op, 1))
			op = Mid(op, 5)
			'head = Left(List1.Text, 4)
			'data = Mid(List1.Text, 29)
			lens = unldump(op, tmpstr)
			'txtMsg = head & retstr
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & Index & ": " & tmpstr & "--" & op
			lerror2(TxtLogFile.Text, MsgStr)
		Next 
		
		
	End Sub
	
	Private Sub cmdSend_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSend.Click
		Dim data() As Byte
		Dim str1, addr As String
		Dim Index, datalen As Short
		Dim ret As Short
		
		str1 = "\63\" & VB.Right("0" & TxtSubNode.Text, 2) & txtData.Text
		datalen = Len(str1)
		ReDim data(datalen)
		datalen = HexIpB(str1, data, 0)
		addr = txtDaport.Text
		Index = Val(TxtID.Text)
		'    ret = SendDapData2(Winsock1(Index), addr, Data(), datalen + 1) '+1 include 0
		ret = SendDapData0(Winsock1(Index), addr, data, datalen) '+1 include 0
		
		'Winsock1(Index).SendData str1
		'Timer2.Enabled = True
		
	End Sub
	
	Private Sub Text4_Change(ByRef Index As Short)
		
	End Sub
	
	Private Sub Command1_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Command1.Click
		
		Timer1.Enabled = False
		Timer1.Enabled = True
		
	End Sub
	
	Private Sub cmdSend2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdSend2.Click
		Dim data() As Byte
		Dim str1, addr As String
		Dim Index, datalen As Short
		Dim ret As Short
		
		On Error Resume Next
		
		str1 = txtData2.Text
		datalen = Len(str1)
		ReDim data(datalen)
		datalen = HexIpB(str1, data, 0)
		ReDim Preserve data(datalen - 1)
		'    addr = txtDaport2
		Index = Val(txtId2.Text)
		'    ret = SendDapData2(Winsock1(Index), addr, Data(), datalen + 1) '+1 include 0
		'ret = SendDapData0(Winsock1(Index), addr, Data(), datalen) '+1 include 0
		Winsock1(Index).SendData(data)
		
	End Sub
	
	Private Sub CmdSendBeg_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles CmdSendBeg.Click
		Dim Index As Short = CmdSendBeg.GetIndex(eventSender)
		Const STR_START As String = "Start "
		Const STR_STOP As String = "Stop "
		Dim MsgStr As String
		Dim Interval As Integer
		Dim datalen, tmpLen As Short
		Dim data() As Byte
		Dim PketNo As Integer
		
		On Error GoTo ERRCMD
		
		
		If InStr(CmdSendBeg(Index).Text, STR_START) > 0 Then 'START
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & Index + 1 & " Send Start: Interval=" & TxtSendIntval(Index).Text & ", DataLen=" & TxtSendDataLen(Index).Text
			CmdSendBeg(Index).Text = STR_STOP & Index + 1
			
			Interval = Val(TxtSendIntval(Index).Text)
			If Interval = 0 Then 'Wait Time Out
				RcvMode(Index) = RCV_TIMEOUT
				Interval = 3000 'Wait 3000ms, Check Loss
				RcvDataBuf(Index) = TxtSendData(Index).Text
			Else 'Send On time
				RcvMode(Index) = RCV_PERIOD
			End If
			
			If Interval > 30000 Then
				IntervalSecMax(Index) = Interval / 1000
				IntervalSecCnt(Index) = 1
				Interval = 1000
			Else
				IntervalSecMax(Index) = 0
			End If
			
			'UPGRADE_WARNING: 計時器屬性 TmrSend.Interval 其值不可以為零。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
			TmrSend(Index).Interval = Interval
			
			TmrSend(Index).Enabled = True
			
			'TmrRate.Enabled = True
			TxtSendIntval(Index).Enabled = False
			TxtSendDataLen(Index).Enabled = False
			TxtSendData(Index).Enabled = False
			
			'if opttestmode(0).Value= then
			cmdCnect(Index).Enabled = False
			
			'        '---------below add by Elle-------------
			'        If OptTestMode(1).Value = True Then    '--------For Cross Test
			'            cmdCnect(Index + 1).Enabled = False
			'        End If
			'        '---------upper add by Elle-------------
			
			If RcvMode(Index) = RCV_TIMEOUT Then
				WSendData(Index, TxtSendData(Index).Text)
				RcvDataBuf(Index) = ""
			End If
			
		Else
			'--- Log Rate Data ----
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & " Traffic " & Index + 1 & ": " & " Send=" & LabSend(Index).Text & ", Receive=" & LabRcv(Index).Text & ", Loss=" & LabLoss(Index).Text
			lerror(List1, MsgStr)
			
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & Index + 1 & " Send Stop:  Send=" & TxtCntSendTal(Index).Text & ", Send OK=" & TxtCntSend(Index).Text & ", Receive=" & TxtCntRcv(Index).Text & ", Total Loss=" & TxtCntLoss(Index).Text & ", SendPket=" & TxtSendPketTal(Index).Text & ", RcvPket=" & TxtRcvPket(Index).Text
			lerror(List1, MsgStr)
			
			CmdSendBeg(Index).Text = STR_START & Index + 1
			TmrSend(Index).Enabled = False
			'TmrRate.Enabled = False
			TxtSendIntval(Index).Enabled = True
			TxtSendDataLen(Index).Enabled = True
			TxtSendData(Index).Enabled = True
			cmdCnect(Index).Enabled = True
			Exit Sub
		End If
		
		lerror(List1, MsgStr)
		
		Exit Sub
		
ERRCMD: 
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & "  COM " & Index + 1 & "   CmdSendBeg Err:   " & ErrorToString()
		lerror(List1, MsgStr)
		Exit Sub
		Resume 
	End Sub
	
	Sub WSendData(ByRef Index As Short, ByRef DataStr As String)
		Dim PketNo As Integer
		Dim datalen, tmpLen As Short
		Dim data() As Byte
		Dim tmpstr As String
		
		PketNo = CDbl(TxtSendPketTal(Index).Text) + 1
		'If PketNo > 65535 Then PketNo = 0      '2 bytes for PketNo
		PketNo = PketNo And &HFFFF '2 bytes for PketNo, update to hex string, 2004/08/12
		
		TxtSendPketTal(Index).Text = CStr(PketNo)
		
		datalen = Len(TxtSendData(Index).Text) + LEN_PKET_HEAD
		ReDim data(datalen - 1)
		tmpLen = HexIpB(TxtSendData(Index).Text, data, LEN_PKET_HEAD)
		tmpLen = HexIpB(CODE_PKET_HEAD, data, 0)
		
		'data(3) = PketNo Mod 256          'PketNo_Low
		'data(4) = PketNo \ 256            'PketNo_High
		tmpstr = VB.Right(Hex(&H10000 + PketNo), 4) 'update to hex string, 2004/08/12
		data(3) = Asc(Mid(tmpstr, 1, 1)) 'PketNo_High
		data(4) = Asc(Mid(tmpstr, 2, 1))
		data(5) = Asc(Mid(tmpstr, 3, 1))
		data(6) = Asc(Mid(tmpstr, 4, 1))
		
		'Debug.Print "PketNo=" & PketNo
		
		'------------below add by Elle (for pingpong)-----------------
		Send_data(Index) = CODE_PKET_HEAD & tmpstr & DataStr
		'------------upper add by Elle (for pingpong)-----------------
		
		Winsock1(Index).SendData(data)
		
		TxtCntSendTal(Index).Text = CStr(CDbl(TxtCntSendTal(Index).Text) + datalen)
		iTx(Index) = iTx(Index) + datalen '------------add by Elle
		iLoss(Index) = iTx(Index) - iRx(Index) '------------add by Elle
		
		
	End Sub
	
	
	
	
	
	
	Private Sub Command2_Click()
		MsgBox2(" Send=" & TxtCntSendTal(0).Text & ", Send OK=" & TxtCntSend(0).Text & ", Receive=" & TxtCntRcv(0).Text & ", Total Loss=" & TxtCntLoss(0).Text)
		
		CmdSendBeg_Click(CmdSendBeg.Item(0), New System.EventArgs())
		cmdCnect_Click(cmdCnect.Item(0), New System.EventArgs())
		cmdCnect_Click(cmdCnect.Item(0), New System.EventArgs())
		CmdSendBeg_Click(CmdSendBeg.Item(0), New System.EventArgs())
	End Sub
	
	Private Sub FrmMain_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
		Me.Text = txtip(0).Text
		''''''''''''''''''''''''''''''''''''''''''''''added below for read model at 2008/11/28
		Dim FileNo As Object
		Dim strString As String
		Dim content As String
		Dim com_16, node, intip, intcom, intport, com_16add As Object
		Dim i As Short '----------add by Elle
		Dim close_conn As Object
		Dim disable_conn As Short
		Dim atc_flg As Boolean '-------add by Elle
		'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileNo = FreeFile
		
		'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(FileNo, My.Application.Info.DirectoryPath & "\write_model.txt", OpenMode.Input)
		'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		While Not EOF(FileNo)
			'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			strString = LineInput(FileNo)
			
			txtMappingModel.Text = strString
		End While
		'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(FileNo)
		'----------------------below add by Elle----------------------------
		On Error GoTo ErrorHandle
		
		If OptTestMode(0).Checked = True Then '---------------------use color to know which mode(com loopback / cross loopback)
			Me.Text = Me.Text & " (V" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & ")" & " Standard --- COM Loopback"
			Me.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			labTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label32.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label33.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label18.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			OptTestMode(0).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			OptTestMode(1).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			chk_pingpong.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			chk_stopsend.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label12.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label5.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label19.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label15.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label16.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label17.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			For i = 0 To 7
				Label20(i).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
				Label24(i).BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Next i
			Label28.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label29.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label23.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label27.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label26.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
			Label25.BackColor = System.Drawing.ColorTranslator.FromOle(&HFFFFC0)
		ElseIf OptTestMode(1).Checked = True Then 
			Me.Text = Me.Text & " (V" & My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & ")" & " Standard --- Cross Loopback"
			Me.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			labTime.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label32.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label33.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label18.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			OptTestMode(0).BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			OptTestMode(1).BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			chk_pingpong.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			chk_stopsend.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label12.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label5.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label19.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label15.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label16.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label17.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			For i = 0 To 7
				Label20(i).BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
				Label24(i).BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Next i
			Label28.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label29.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label23.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label27.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label26.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
			Label25.BackColor = System.Drawing.ColorTranslator.FromOle(&HC0E0FF)
		End If
		
		
		
		'If Left(strString, 3) = "atc" Then
		atc_flg = True
		'    strString = Replace(strString, "atc", "")
		'-------------------add for atc----------------------------------------------------------
		If strString = "GW21S-256" Or strString = "GW21S-MEGA" Or strString = "CE5101-16" Then
			COMs = 1 '----------for 1 ports
		ElseIf strString = "SE5302" Or strString = "C1502" Or strString = "SE1402" Or strString = "SE7404" Or InStr(strString, "SE7402") Or strString = "SE7202" Or strString = "SE102" Then 
			COMs = 2 '-----------for 2 ports
		ElseIf strString = "GW2204S-MEGAV2" Or strString = "SE5404" Or InStr(strString, "SE1504") Or strString = "SE7404-M1" Then 
			COMs = 4 '------------for 4 ports
		ElseIf strString = "GW2208S-MEGAV2" Then 
			COMs = 8 '------------for 8 ports
		ElseIf strString = "SE5016" Or strString = "SE5116" Or strString = "SE5116 (for 2 LAN)" Or strString = "SE5516-IDE" Or strString = "MB5416" Then 
			COMs = 8 '--------for 16 ports
		ElseIf strString = "SE7416" Or InStr(strString, "SE7816") Then 
			COMs = 8 '------------for 32 ports
		Else
			MsgBox("不支援的型號")
		End If
		'------------------------upper for ATC product
		'------------------------below for standard product--------------------------------------------
		'Else
		'    atc_flg = False
		'    If InStr(strString, "001") > 0 Or InStr(strString, "5110") > 0 Or InStr(strString, "400") > 0 Then
		''        Portn.Text = "_1"
		'        COMs = 1
		'    ElseIf InStr(strString, "02") > 0 Or InStr(strString, "5120") > 0 Or InStr(strString, "PC") > 0 Or InStr(strString, "512") > 0 Or InStr(strString, "GW81") > 0 Then
		''        Portn.Text = "_2"
		'        COMs = 2
		'    ElseIf InStr(strString, "04") > 0 Or InStr(strString, "514") Then 'CS MG 514
		''        Portn.Text = "_3"
		'        COMs = 4
		'    ElseIf InStr(strString, "08") > 0 Then
		''        Portn.Text = "_4"
		'        COMs = 8
		'    ElseIf InStr(strString, "16") > 0 Then
		''        Portn.Text = "_5"
		'        COMs = 8       '--------the max connections ->8, use 2 windows to connect 16 ports
		'    ElseIf InStr(strString, "32") > 0 Then
		''        Portn.Text = "_6"
		'        COMs = 8       '--------the max connection ->8, use 4 windows to connect 32 ports
		'    ElseIf InStr(strString, "5300") > 0 Then 'for ew5300
		''        Portn.Text = "_0"
		'        COMs = 0
		''    ElseIf InStr(strString, "06") > 0 Then 'for ew5300
		'''        Portn.Text = "_0"
		''        COMs = 6
		'    Else
		'        MsgBox ("不支援的型號")
		'        'cblModelname.Text = ""
		'    End If
		'End If
		
		
		
		'    Dim test As String
		'    test = "-10.0.111.100"
		'    GetIP = Split(test, "-")
		
		Dim test As String
		If VB.Command() = "" Then '-------avoid that user open this exe directly
			test = "-10.0.50.100" '-----------assign default IP
			GetIP = Split(test, "-")
		Else
			GetIP = Split(VB.Command(), "-")
		End If
		
		'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		node = 0 '--------initual
		
		If UBound(GetIP) * Val(CStr(COMs)) < 8 Then '-----------enable /disable object
			For disable_conn = 7 To UBound(GetIP) * Val(CStr(COMs)) Step -1
				txtip(disable_conn).Visible = False
				txtPort(disable_conn).Visible = False
				cmdCnect(disable_conn).Visible = False
				TxtSendIntval(disable_conn).Visible = False
				TxtSendDataLen(disable_conn).Visible = False
				CmdSendBeg(disable_conn).Visible = False
				TxtCntSendTal(disable_conn).Visible = False
				TxtCntSend(disable_conn).Visible = False
				TxtCntRcv(disable_conn).Visible = False
				TxtCntLoss(disable_conn).Visible = False
				Label20(disable_conn).Visible = False
				LabSend(disable_conn).Visible = False
				LabRcv(disable_conn).Visible = False
				LabLoss(disable_conn).Visible = False
				Label24(disable_conn).Visible = False
				TxtSendPketTal(disable_conn).Visible = False
				TxtSendPket(disable_conn).Visible = False
				TxtRcvPket(disable_conn).Visible = False
			Next disable_conn
			
			'----------------------------below (hide useless object)------------------------
			If UBound(GetIP) * Val(CStr(COMs)) = 1 Or UBound(GetIP) * Val(CStr(COMs)) = 2 Then
				Label31.Visible = False
				txtStatus67.Visible = False
				
				Label30.Visible = False
				txtStatus45.Visible = False
				
				Label21.Visible = False
				txtStatus23.Visible = False
			ElseIf UBound(GetIP) * Val(CStr(COMs)) = 3 Or UBound(GetIP) * Val(CStr(COMs)) = 4 Then 
				Label31.Visible = False
				txtStatus67.Visible = False
				
				Label30.Visible = False
				txtStatus45.Visible = False
			ElseIf UBound(GetIP) * Val(CStr(COMs)) = 5 Or UBound(GetIP) * Val(CStr(COMs)) = 6 Then 
				Label31.Visible = False
				txtStatus67.Visible = False
			ElseIf UBound(GetIP) * Val(CStr(COMs)) = 7 Or UBound(GetIP) * Val(CStr(COMs)) = 8 Then 
				
			End If
			'------------------------upper (hide useless object)---------------------------
			
		End If
		
		'                MsgBox "current model= " & strString
		
		
		If atc_flg = True Then
			'--------------------------below for ATC product------------------------------------
			For intip = 1 To UBound(GetIP) '-------at first,GetIP(0)=" "
				
				If strString = "SE5016" Or strString = "SE5116" Or strString = "SE5116 (for 2 LAN)" Or strString = "SE5516-IDE" Or strString = "MB5416" Then '----------16 connection
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intport = 0 + node To COMs - 1 + node '--------assign Port
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						com_16 = Val(VB.Right(GetIP(intip), 1)) '-------add more than 8 ports
						'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If com_16 = 0 Then
							'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							com_16add = 0 * 8
							'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf com_16 = 8 Then 
							'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							com_16add = 1 * 8
						End If
						'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 intport 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtPort(intport).Text = com_16add + 4660 + intport - node
					Next intport
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intcom = 0 + node To COMs - 1 + node '---------assign IP
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If VB.Right(GetIP(intip), 2) = " 0" Then
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							GetIP(intip) = Replace(GetIP(intip), " 0", "")
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf VB.Right(GetIP(intip), 2) = " 8" Then 
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							GetIP(intip) = Replace(GetIP(intip), " 8", "")
						End If
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtip(intcom).Text = GetIP(intip)
					Next intcom
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					node = node + Val(CStr(COMs))
					
				ElseIf strString = "SE7416" Or InStr(strString, "SE7816") Then  '---------32 port
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intport = 0 + node To COMs - 1 + node '--------assign Port
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						com_16 = Val(VB.Right(GetIP(intip), 2)) '-------add more than 8 ports
						'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If com_16 = 0 Then
							'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							com_16add = 0 * 8
							'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf com_16 = 8 Then 
							'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							com_16add = 1 * 8
							'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf com_16 = 16 Then 
							'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							com_16add = 2 * 8
							'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf com_16 = 24 Then 
							'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							com_16add = 3 * 8
						End If
						'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 intport 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtPort(intport).Text = com_16add + 4660 + intport - node
					Next intport
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intcom = 0 + node To COMs - 1 + node '---------assign IP
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If VB.Right(GetIP(intip), 2) = " 0" Then
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							GetIP(intip) = Replace(GetIP(intip), " 0", "")
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf VB.Right(GetIP(intip), 2) = " 8" Then 
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							GetIP(intip) = Replace(GetIP(intip), " 8", "")
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf VB.Right(GetIP(intip), 2) = "16" Then 
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							GetIP(intip) = Replace(GetIP(intip), " 16", "")
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf VB.Right(GetIP(intip), 2) = "24" Then 
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							GetIP(intip) = Replace(GetIP(intip), " 24", "")
						End If
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtip(intcom).Text = GetIP(intip)
					Next intcom
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					node = node + Val(CStr(COMs))
					
				Else
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intcom = 0 + node To COMs - 1 + node '---------assign IP
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtip(intcom).Text = GetIP(intip)
					Next intcom
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intport = 0 + node To COMs - 1 + node '--------assign Port
						'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 intport 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtPort(intport).Text = 4660 + intport - node
					Next intport
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					node = node + Val(CStr(COMs))
				End If
			Next intip
		Else
			'---------------------------below for Standard product-----------------------------------------
			For intip = 1 To UBound(GetIP) '-------at first,GetIP(0)=" "
				
				If InStr(strString, "16") > 0 Then '----------16 connection
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intport = 0 + node To COMs - 1 + node '--------assign Port
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						com_16 = Val(VB.Right(GetIP(intip), 1)) '-------add more than 8 ports
						'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If com_16 = 0 Then
							'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							com_16add = 0 * 8
							'UPGRADE_WARNING: 無法解析物件 com_16 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf com_16 = 8 Then 
							'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							com_16add = 1 * 8
						End If
						'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 intport 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 com_16add 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtPort(intport).Text = com_16add + 4660 + intport - node
					Next intport
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intcom = 0 + node To COMs - 1 + node '---------assign IP
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						If VB.Right(GetIP(intip), 2) = " 0" Then
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							GetIP(intip) = Replace(GetIP(intip), " 0", "")
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						ElseIf VB.Right(GetIP(intip), 2) = " 8" Then 
							'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
							GetIP(intip) = Replace(GetIP(intip), " 8", "")
						End If
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtip(intcom).Text = GetIP(intip)
					Next intcom
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					node = node + Val(CStr(COMs))
					
				Else
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intcom = 0 + node To COMs - 1 + node '---------assign IP
						'UPGRADE_WARNING: 無法解析物件 intip 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtip(intcom).Text = GetIP(intip)
					Next intcom
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					For intport = 0 + node To COMs - 1 + node '--------assign Port
						'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						'UPGRADE_WARNING: 無法解析物件 intport 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
						txtPort(intport).Text = 4660 + intport - node
					Next intport
					
					'UPGRADE_WARNING: 無法解析物件 node 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
					node = node + Val(CStr(COMs))
				End If
			Next intip
		End If
		
		
		If OptTestMode(1).Checked = True Then '--------user select "Cross Test" and hide COM2/4/6/8
			CmdSendBeg(1).Visible = False
			CmdSendBeg(3).Visible = False
			CmdSendBeg(5).Visible = False
			CmdSendBeg(7).Visible = False
		Else
			CmdSendBeg(1).Visible = True
			CmdSendBeg(3).Visible = True
			CmdSendBeg(5).Visible = True
			CmdSendBeg(7).Visible = True
		End If
		'----------------------upper add by Elle----------------------------
		
		''''''''''''''''''''''''''''''''''''''''''''''added upper at 2008/11/28
		
		
		Call SendMessage(List1.Handle.ToInt32, LB_SETHORIZONTALEXTENT, 2000, 0)
		TxtLogFile.Text = My.Application.Info.DirectoryPath & "\" & VB6.Format(Today, "YYYYMMDD") & ".TXT"
		TxtLogFile.SelectionStart = Len(TxtLogFile.Text)
		
		
		TxtSendDataLen_TextChanged(TxtSendDataLen.Item(0), New System.EventArgs())
		TxtSendDataLen_TextChanged(TxtSendDataLen.Item(1), New System.EventArgs())
		TxtSendDataLen_TextChanged(TxtSendDataLen.Item(2), New System.EventArgs()) 'Evan added 2007/10/22
		TxtSendDataLen_TextChanged(TxtSendDataLen.Item(3), New System.EventArgs()) 'Evan added 2007/10/22
		TxtSendDataLen_TextChanged(TxtSendDataLen.Item(4), New System.EventArgs()) 'Evan added 2007/10/22
		TxtSendDataLen_TextChanged(TxtSendDataLen.Item(5), New System.EventArgs()) 'Evan added 2007/10/22
		TxtSendDataLen_TextChanged(TxtSendDataLen.Item(6), New System.EventArgs()) 'Evan added 2007/10/22
		TxtSendDataLen_TextChanged(TxtSendDataLen.Item(7), New System.EventArgs()) 'Evan added 2007/10/22
		
		StartDate = CStr(Today)
		StartTime = CStr(TimeOfDay)
		
		FFFF_getpkno = 0 '------------test pkno add by Elle (test ok and then erase this )
		'--------------below add by Elle (ping pong)
		OK_flg(0) = True
		OK_flg(1) = True
		OK_flg(2) = True
		OK_flg(3) = True
		OK_flg(4) = True
		OK_flg(5) = True
		OK_flg(6) = True
		OK_flg(7) = True
		'-------------upper add by Elle (ping pong)
		
		Exit Sub
		
ErrorHandle: 
		MsgBox("Form_Load= " & ErrorToString())
		
	End Sub
	
	Private Sub FrmMain_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
		
		End
		
	End Sub
	
	
	'UPGRADE_WARNING: 初始化表單時可能會引發事件 List1.SelectedIndexChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub List1_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles List1.SelectedIndexChanged
		Dim head, data As String
		Dim retstr As String
		Dim lens As Short
		
		txtListCnt.Text = CStr(List1.SelectedIndex + 1)
		If List1.Items.Count > 32000 Then
			List1.Items.RemoveAt(0)
		End If
		
		Exit Sub
		
		head = VB.Left(List1.Text, 4)
		data = Mid(List1.Text, 29)
		lens = unldump(data, retstr)
		txtMsg.Text = head & retstr
		ToolTip1.SetToolTip(List1, List1.Text)
		
		
	End Sub
	
	Public Sub MnuAddId_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuAddId.Click
		
		'MenuFlag = CMD_ADD_ID
		'FrmMain.Enabled = False
		'LoadForm FrmSet
		
	End Sub
	
	Public Sub MnuGroup_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuGroup.Click
		
		MenuFlag = CMD_SET_GROUP
		Me.Enabled = False
		'LoadForm FrmSet
		
	End Sub
	
	Public Sub MnuHoliday_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuHoliday.Click
		
		MenuFlag = CMD_SET_HOLIDAY
		Me.Enabled = False
		'LoadForm FrmSet
		
	End Sub
	
	Public Sub MnuQryComp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuQryComp.Click
		
		MenuFlag = CMD_QRY_COMP
		Me.Enabled = False
		' LoadForm FrmSet
		
	End Sub
	
	Public Sub MnuQryId_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuQryId.Click
		
		MenuFlag = CMD_QRY_ID
		Me.Enabled = False
		' LoadForm FrmSet
		
	End Sub
	
	Public Sub MnuQryRealT_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuQryRealT.Click
		
		MenuFlag = CMD_GET_RECD
		Me.Enabled = False
		'LoadForm FrmSet
		
	End Sub
	
	Public Sub MnuSchedule_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuSchedule.Click
		
		MenuFlag = CMD_SCHEDULE
		Me.Enabled = False
		' LoadForm FrmSet
		
	End Sub
	
	Public Sub MnuSetComp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuSetComp.Click
		
		MenuFlag = CMD_ADD_COMP
		Me.Enabled = False
		'LoadForm FrmSet
		
	End Sub
	
	Public Sub MnuSetTime_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MnuSetTime.Click
		Dim data() As Byte
		Dim TimeStr, str1, tmpstr As String
		Dim addr, DateStr As String
		Dim Index, datalen As Short
		Dim ret, i, week As Short
		Dim ErrCnt, OkCnt, Cnt As Short
		Dim Start, nowTime As Integer
		Dim TimeoutFlag As Boolean
		
		Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
		
		'---  Send command ---------
		TimeoutFlag = False
		Cnt = 1
		'CMD: "D"+<Mode>1+<Date>9+<Time>6
		'<Mode>: 1 -> Query Time
		'        2 -> Set Current Time
		'<Date>: YYYYMMDDW
		'<Time>: HHMMSS
		'----  Get Time Zone -----------
		DateStr = VB6.Format(Today, "yyyymmdd")
		i = CShort(VB6.Format(Today, "w"))
		week = i - 1
		If week = 0 Then week = 7
		DateStr = DateStr & Trim(Str(week))
		TimeStr = VB6.Format(TimeOfDay, "hhmmss")
		
		str1 = "\63\" & VB.Right("0" & TxtSubNode.Text, 2) & CMD_SET_TIME & "2" & DateStr & TimeStr
		datalen = Len(str1)
		ReDim data(datalen)
		datalen = HexIpB(str1, data, 0)
		addr = Me.txtDaport.Text
		Index = Val(Me.TxtID.Text)
		ret = SendDapData0(Me.Winsock1(Index), addr, data, datalen) '+1 include 0
		
		'----- Waitting Response ------------------
		AckFlag = False
		Start = VB.Timer()
		Do While (AckFlag = False)
			nowTime = VB.Timer()
			If nowTime < Start Then nowTime = nowTime + CNST_DAY_SEC
			If nowTime > (Start + CNST_TIMEOUT_ACC) Then 'timeout
				AckFlag = True
				TimeoutFlag = True
			End If
			
			System.Windows.Forms.Application.DoEvents()
		Loop 
		'------ Record Result -----------------
		If TimeoutFlag Then 'timeout
			ErrCnt = ErrCnt + 1
			TimeoutFlag = False
		Else 'Ack OK
			OkCnt = OkCnt + 1
		End If
		
		'---- Report Result ------------
		tmpstr = "Total: " & Cnt & ",  OK: " & OkCnt & ",   Err: " & ErrCnt
		MsgBox("Set Time: " & tmpstr)
		'StatusBar1.Panels.Item(1) = tmpstr
		
		Me.Cursor = System.Windows.Forms.Cursors.Default
		
		
	End Sub
	
	'UPGRADE_WARNING: 初始化表單時可能會引發事件 OptTestMode.CheckedChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub OptTestMode_CheckedChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles OptTestMode.CheckedChanged
		If eventSender.Checked Then
			Dim Index As Short = OptTestMode.GetIndex(eventSender)
			
			'    If Index = 0 Then       'Loopback Test
			'        cmdCnect(1).Visible = True
			'        LabLoop(0).Visible = True
			'        LabLoop(1).Visible = True
			'
			'        TxtSendIntval(1).Visible = True
			'        TxtSendDataLen(1).Visible = True
			'        CmdSendBeg(1).Visible = True
			'        TxtCntSend(1).Visible = True
			'        TxtCntSendTal(1).Visible = True
			'        TxtCntRcv(1).Visible = True
			'        TxtCntLoss(1).Visible = True
			'        LabSend(1).Visible = True
			'        LabRcv(1).Visible = True
			'        LabLoss(1).Visible = True
			'        Label20(1).Visible = True
			'        Label22(1).Visible = True
			'        Label24(1).Visible = True
			'        TxtSendPketTal(1).Visible = True
			'        TxtSendPket(1).Visible = True
			'        TxtRcvPket(1).Visible = True
			'
			'        '-------------------------------------------Evan added below 2007/10/22
			'        TxtSendIntval(2).Visible = True
			'        TxtSendDataLen(2).Visible = True
			'        CmdSendBeg(2).Visible = True
			'        TxtCntSend(2).Visible = True
			'        TxtCntSendTal(2).Visible = True
			'        TxtCntRcv(2).Visible = True
			'        TxtCntLoss(2).Visible = True
			'        LabSend(2).Visible = True
			'        LabRcv(2).Visible = True
			'        LabLoss(2).Visible = True
			'        TxtSendPketTal(2).Visible = True
			'        TxtSendPket(2).Visible = True
			'        TxtRcvPket(2).Visible = True
			'        Label24(2).Visible = True
			'
			'        TxtSendIntval(3).Visible = True
			'        TxtSendDataLen(3).Visible = True
			'        CmdSendBeg(3).Visible = True
			'        TxtCntSend(3).Visible = True
			'        TxtCntSendTal(3).Visible = True
			'        TxtCntRcv(3).Visible = True
			'        TxtCntLoss(3).Visible = True
			'        LabSend(3).Visible = True
			'        LabRcv(3).Visible = True
			'        LabLoss(3).Visible = True
			'        TxtSendPketTal(3).Visible = True
			'        TxtSendPket(3).Visible = True
			'        TxtRcvPket(3).Visible = True
			'        Label24(3).Visible = True
			'
			'        TxtSendIntval(4).Visible = True
			'        TxtSendDataLen(4).Visible = True
			'        CmdSendBeg(4).Visible = True
			'        TxtCntSend(4).Visible = True
			'        TxtCntSendTal(4).Visible = True
			'        TxtCntRcv(4).Visible = True
			'        TxtCntLoss(4).Visible = True
			'        LabSend(4).Visible = True
			'        LabRcv(4).Visible = True
			'        LabLoss(4).Visible = True
			'        TxtSendPketTal(4).Visible = True
			'        TxtSendPket(4).Visible = True
			'        TxtRcvPket(4).Visible = True
			'        Label24(4).Visible = True
			'
			'        TxtSendIntval(5).Visible = True
			'        TxtSendDataLen(5).Visible = True
			'        CmdSendBeg(5).Visible = True
			'        TxtCntSend(5).Visible = True
			'        TxtCntSendTal(5).Visible = True
			'        TxtCntRcv(5).Visible = True
			'        TxtCntLoss(5).Visible = True
			'        LabSend(5).Visible = True
			'        LabRcv(5).Visible = True
			'        LabLoss(5).Visible = True
			'        TxtSendPketTal(5).Visible = True
			'        TxtSendPket(5).Visible = True
			'        TxtRcvPket(5).Visible = True
			'        Label24(5).Visible = True
			'
			'        TxtSendIntval(6).Visible = True
			'        TxtSendDataLen(6).Visible = True
			'        CmdSendBeg(6).Visible = True
			'        TxtCntSend(6).Visible = True
			'        TxtCntSendTal(6).Visible = True
			'        TxtCntRcv(6).Visible = True
			'        TxtCntLoss(6).Visible = True
			'        LabSend(6).Visible = True
			'        LabRcv(6).Visible = True
			'        LabLoss(6).Visible = True
			'        TxtSendPketTal(6).Visible = True
			'        TxtSendPket(6).Visible = True
			'        TxtRcvPket(6).Visible = True
			'        Label24(6).Visible = True
			'
			'        TxtSendIntval(7).Visible = True
			'        TxtSendDataLen(7).Visible = True
			'        CmdSendBeg(7).Visible = True
			'        TxtCntSend(7).Visible = True
			'        TxtCntSendTal(7).Visible = True
			'        TxtCntRcv(7).Visible = True
			'        TxtCntLoss(7).Visible = True
			'        LabSend(7).Visible = True
			'        LabRcv(7).Visible = True
			'        LabLoss(7).Visible = True
			'        TxtSendPketTal(7).Visible = True
			'        TxtSendPket(7).Visible = True
			'        TxtRcvPket(7).Visible = True
			'        Label24(7).Visible = True
			'
			'        TxtSendIntval(8).Visible = True
			'        TxtSendDataLen(8).Visible = True
			'        CmdSendBeg(8).Visible = True
			'        TxtCntSend(8).Visible = True
			'        TxtCntSendTal(8).Visible = True
			'        TxtCntRcv(8).Visible = True
			'        TxtCntLoss(8).Visible = True
			'        LabSend(8).Visible = True
			'        LabRcv(8).Visible = True
			'        LabLoss(8).Visible = True
			'        TxtSendPketTal(8).Visible = True
			'        TxtSendPket(8).Visible = True
			'        TxtRcvPket(8).Visible = True
			'        Label24(8).Visible = True
			'        '-------------------------------------------Evan added end 2007/10/22
			'
			'    Else                    'Cross Test
			'        'cmdCnect(1).Visible = False
			'        LabLoop(0).Visible = False
			'        LabLoop(1).Visible = False
			'
			'        TxtSendIntval(1).Visible = False
			'        TxtSendDataLen(1).Visible = False
			'        CmdSendBeg(1).Visible = False
			'        TxtCntSend(1).Visible = False
			'        TxtCntSendTal(1).Visible = False
			'        TxtCntRcv(1).Visible = False
			'        TxtCntLoss(1).Visible = False
			'        LabSend(1).Visible = False
			'        LabRcv(1).Visible = False
			'        LabLoss(1).Visible = False
			'        Label20(1).Visible = False
			'        Label22(1).Visible = False
			'        Label24(1).Visible = False
			'        TxtSendPketTal(1).Visible = False
			'        TxtSendPket(1).Visible = False
			'        TxtRcvPket(1).Visible = False
			'
			'    End If
			
			'----------------------below add by Elle-------------------------
			If Index = 1 Then
				CmdSendBeg(1).Visible = False
				CmdSendBeg(3).Visible = False
				CmdSendBeg(5).Visible = False
				CmdSendBeg(7).Visible = False
			Else
				CmdSendBeg(1).Visible = True
				CmdSendBeg(3).Visible = True
				CmdSendBeg(5).Visible = True
				CmdSendBeg(7).Visible = True
			End If
			'----------------------upper add by Elle-------------------------
			
		End If
	End Sub
	
	
	
	Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
		Dim tmpstr As String
		Dim tmpstr23 As String 'Evan added 2007/10/22
		Dim tmpstr45 As String 'Evan added 2007/10/22
		Dim tmpstr67 As String 'Evan added 2007/10/22
		
		Dim Index As Short
		Static FileName As String
		
		On Error Resume Next
		
		labTime.Text = TimeString
		
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		tmpstr = Winsock1(0).CtlState & Chr(13) & Chr(10) '"    "
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		tmpstr = tmpstr & Winsock1(1).CtlState
		txtStatus.Text = tmpstr
		
		tmpstr = VB6.Format(Today, "YYYYMMDD")
		
		If tmpstr <> FileName Then
			FileName = tmpstr
			TxtLogFile.Text = My.Application.Info.DirectoryPath & "\" & FileName & ".TXT"
			'TxtLogFile.SelStart = Len(TxtLogFile)
		End If
		
		'--------below add by Elle-----------------
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		If OptTestMode(1).Visible = True And Winsock1(0).CtlState = 7 And Winsock1(1).CtlState = 7 Then
			CmdSendBeg(0).Enabled = True
		End If
		'--------upper add by Elle-----------------
		
		'------------------------------------------------------------''Evan added below 2007/10/22
		
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		tmpstr23 = Winsock1(2).CtlState & Chr(13) & Chr(10) '"    "
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		tmpstr23 = tmpstr23 & Winsock1(3).CtlState
		txtStatus23.Text = tmpstr23
		
		tmpstr23 = VB6.Format(Today, "YYYYMMDD")
		
		If tmpstr23 <> FileName Then
			FileName = tmpstr23
			TxtLogFile.Text = My.Application.Info.DirectoryPath & "\" & FileName & ".TXT"
			'TxtLogFile.SelStart = Len(TxtLogFile)
		End If
		
		'--------------below add by Elle-------------------
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		If OptTestMode(1).Checked = True And Winsock1(2).CtlState = 7 And Winsock1(3).CtlState = 7 Then
			CmdSendBeg(2).Enabled = True
		End If
		'--------------upper add by Elle-------------------
		'-------------------------------------------------------------------------------'
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		tmpstr45 = Winsock1(4).CtlState & Chr(13) & Chr(10) '"    "
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		tmpstr45 = tmpstr45 & Winsock1(5).CtlState
		txtStatus45.Text = tmpstr45
		
		tmpstr45 = VB6.Format(Today, "YYYYMMDD")
		
		If tmpstr45 <> FileName Then
			FileName = tmpstr45
			TxtLogFile.Text = My.Application.Info.DirectoryPath & "\" & FileName & ".TXT"
			'TxtLogFile.SelStart = Len(TxtLogFile)
		End If
		
		'-----------below add by Elle-----------------------
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		If OptTestMode(1).Checked = True And Winsock1(4).CtlState = 7 And Winsock1(5).CtlState = 7 Then
			CmdSendBeg(4).Enabled = True
		End If
		'-----------upper add by Elle-----------------------
		
		'-------------------------------------------------------------------------------'
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		tmpstr67 = Winsock1(6).CtlState & Chr(13) & Chr(10) '"    "
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		tmpstr67 = tmpstr67 & Winsock1(7).CtlState
		txtStatus67.Text = tmpstr67
		
		tmpstr67 = VB6.Format(Today, "YYYYMMDD")
		
		If tmpstr67 <> FileName Then
			FileName = tmpstr67
			TxtLogFile.Text = My.Application.Info.DirectoryPath & "\" & FileName & ".TXT"
			'TxtLogFile.SelStart = Len(TxtLogFile)
		End If
		
		'--------------below add by Elle------------------------
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		If OptTestMode(1).Checked = True And Winsock1(6).CtlState = 7 And Winsock1(7).CtlState = 7 Then
			CmdSendBeg(6).Enabled = True
		End If
		'--------------upper add by Elle------------------------
		
		'------------------------------------------------------------'Evan added end 2007/10/22
		
		Exit Sub
		
		With List1
			Index = .Items.Count - 1
			If tmpstr <> VB6.GetItemString(List1, Index) Then
				.Items.Add(tmpstr)
				.SelectedIndex = Index + 1
			End If
		End With
		
	End Sub
	
	Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
		Dim tmpstr As String
		Dim tmpVal As Short
		Dim Sstr, Hstr, Mstr, Dstr As String
		
		'  On Error GoTo ErrorHandle
		
		Label9.Text = VB6.Format(Now, "yyyy/mm/dd hh:mm:ss")
		
		'UPGRADE_WARNING: DateDiff 行為可能會不同。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6B38EC3F-686D-4B2E-B5A5-9E8E7A762E32"'
		tmpVal = DateDiff(Microsoft.VisualBasic.DateInterval.Day, CDate(StartDate), Today)
		Dstr = IIf(tmpVal > 0, tmpVal, tmpVal)
		tmpVal = Hour(TimeOfDay) - Hour(CDate(StartTime))
		Hstr = VB.Right("0" & IIf(tmpVal >= 0, tmpVal, 24 + tmpVal), 2)
		tmpVal = Minute(TimeOfDay) - Minute(CDate(StartTime))
		Mstr = VB.Right("0" & IIf(tmpVal >= 0, tmpVal, 60 + tmpVal), 2)
		tmpVal = Second(TimeOfDay) - Second(CDate(StartTime))
		Sstr = VB.Right("0" & IIf(tmpVal >= 0, tmpVal, 60 + tmpVal), 2)
		LabRunTime.Text = Dstr & " Day " & Hstr & ":" & Mstr & ":" & Sstr
		
		'  Exit Sub
		'
		'ErrorHandle:
		'  MsgBox "Timer2_Timer= " & Error
		
	End Sub
	
	
	Private Sub tmr_subtract_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmr_subtract.Tick
		'MAX_COM_PORT
		Dim i As Short
		For i = 0 To 7
			TxtCntLoss(i).Text = CStr(Val(TxtCntSend(i).Text) - Val(TxtCntRcv(i).Text))
		Next i
	End Sub
	
	Private Sub tmr_winsock_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles tmr_winsock.Tick
		Dim conn_all As Object
		Dim begin As Short
		Dim conn_flg As Boolean
		'UPGRADE_WARNING: 無法解析物件 conn_all 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		conn_all = COMs * UBound(GetIP) '--------all connection
		conn_flg = True
		
		'UPGRADE_WARNING: 無法解析物件 conn_all 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For begin = 0 To conn_all - 1
			'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			If Winsock1(begin).CtlState = 7 Then
				conn_flg = True
			Else
				conn_flg = False
			End If
		Next begin
		
		If conn_flg = True Then
			cmdContotal.Text = "Disconnect to all"
			cmdComtesttotal.Enabled = True
			tmr_winsock.Enabled = False
			'UPGRADE_WARNING: 計時器屬性 tmr_winsock.Interval 其值不可以為零。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
			tmr_winsock.Interval = 0
		Else
			cmdContotal.Text = "Connect to all"
			cmdComtesttotal.Enabled = False
		End If
		
	End Sub
	
	Private Sub TmrRate_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TmrRate.Tick
		Static OldCntSend(8) As String 'Evan Exchanged 2 value became 8 value (for COM3~COM8) 2007/10/22
		Static OldCntRcv(8) As String 'Evan Exchanged 2 value became 8 value (for COM3~COM8) 2007/10/22
		Static OldCntLoss(8) As String 'Evan Exchanged 2 value became 8 value (for COM3~COM8) 2007/10/22
		Static TimeCnt As Short
		Dim tmpLong As Integer
		Dim i, TestMode As Short
		
		Const SAMPLE_TIME As Short = 1 'Unit: Sec
		
		TimeCnt = TimeCnt + 1
		If TimeCnt < SAMPLE_TIME Then Exit Sub
		TimeCnt = 0
		
		'-----------below comma by Elle------------------------
		'--- Check Test Mode -------
		'    If OptTestMode(0).Value = True Then     'Loopback
		'        TestMode = 7 'Evan Exchanged 1 value became 7 value (for COM3~COM8) 2007/10/22
		'    Else
		'        TestMode = 0
		'    End If
		'------------upper comma by Elle-----------------------
		'----------------below add by Elle-------------------------
		If OptTestMode(1).Checked = True Then
			'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			If Winsock1(0).CtlState = 7 And Winsock1(1).CtlState = 7 And Winsock1(2).CtlState = 7 And Winsock1(3).CtlState = 7 And Winsock1(4).CtlState = 7 And Winsock1(5).CtlState = 7 And Winsock1(6).CtlState = 7 And Winsock1(7).CtlState = 7 Then
				TestMode = 7
				'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			ElseIf Winsock1(0).CtlState = 7 And Winsock1(1).CtlState = 7 And Winsock1(2).CtlState = 7 And Winsock1(3).CtlState = 7 And Winsock1(4).CtlState = 7 And Winsock1(5).CtlState = 7 Then 
				TestMode = 5
				'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			ElseIf Winsock1(0).CtlState = 7 And Winsock1(1).CtlState = 7 And Winsock1(2).CtlState = 7 And Winsock1(3).CtlState = 7 Then 
				TestMode = 3
				'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			ElseIf Winsock1(0).CtlState = 7 And Winsock1(1).CtlState = 7 Then 
				TestMode = 1
			End If
		Else
			TestMode = 7
		End If
		'----------------upper add by Elle-------------------------
		
		
		For i = 0 To TestMode
			'--- Initial Value -----
			If OldCntSend(i) = "" Then OldCntSend(i) = "0"
			If OldCntRcv(i) = "" Then OldCntRcv(i) = "0"
			If OldCntLoss(i) = "" Then OldCntLoss(i) = "0"
			
			'---- Check Send Rate ----------
			'    tmpLong = TxtCntSend - OldCntSend
			If Val(TxtSendIntval(i).Text) > 0 Then
				LabSend(i).Text = CStr((Val(TxtSendDataLen(i).Text) * 1000) / CDbl(TxtSendIntval(i).Text)) 'tmpLong / SAMPLE_TIME
				'OldCntSend = TxtCntSend
			End If
			'---- Check Receive Rate ----------
			tmpLong = CDbl(TxtCntRcv(i).Text) - CDbl(OldCntRcv(i))
			LabRcv(i).Text = CStr(tmpLong / SAMPLE_TIME)
			OldCntRcv(i) = TxtCntRcv(i).Text
			
			'---- Check Loss Rate ----------
			tmpLong = CDbl(TxtCntLoss(i).Text) - CDbl(OldCntLoss(i))
			LabLoss(i).Text = CStr(tmpLong / SAMPLE_TIME)
			OldCntLoss(i) = TxtCntLoss(i).Text
			
		Next 
		
		
	End Sub
	
	Private Sub TmrSend_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TmrSend.Tick
		Dim Index As Short = TmrSend.GetIndex(eventSender)
		Dim MsgStr, ErrStr As String
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
		
		ChcekLoss(Index)
		
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & TxtSendData(Index).Text
		
		If RcvMode(Index) = RCV_TIMEOUT Then
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & RcvDataBuf(Index)
			'''RcvDataBuf(Index) = ""
		Else
			'        WSendData Index, MsgStr
		End If
		'----------------------------below add by Elle (pingpong)-------------------------------
		Dim idx As Short
		
		If chk_pingpong.CheckState = 1 Then '-----------do ping pong
			multiple(Index) = multiple(Index) + 1 '------ No data then wait 5*interval
			'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
			If Winsock1(Index).CtlState = 7 Then
				
				If OptTestMode(1).Checked = True Then '------------------------------For Corss LoopBack
					If Index Mod 2 = 0 Then
						
						If Send_data(Index) <> Receive_data(Index) Then
							OK_flg(Index) = False
							If multiple(Index) <= 5 Then
								'--------Don't send data anymore
							Else
								multiple(Index) = 1
								If CDbl(TxtCntSendTal(Index).Text) - CDbl(TxtCntSend(Index).Text) < 100 * CInt(1024) Then 'add if at 2004/04/10
									WSendData(Index, TxtSendData(Index).Text) '-------------Send data > &<
								End If
							End If
							
						Else
							multiple(Index) = 1
							If CDbl(TxtCntSendTal(Index).Text) - CDbl(TxtCntSend(Index).Text) < 100 * CInt(1024) Then 'add if at 2004/04/10
								WSendData(Index, TxtSendData(Index).Text) '-------------Send data > &<
							End If
						End If
						
					End If
				Else '-----------------------------------For Com LoopBack
					If Send_data(Index) <> Receive_data(Index) Then
						OK_flg(Index) = False
						If multiple(Index) <= 5 Then
							'--------Don't send data anymore
						Else
							multiple(Index) = 1
							If CDbl(TxtCntSendTal(Index).Text) - CDbl(TxtCntSend(Index).Text) < 100 * CInt(1024) Then 'add if at 2004/04/10
								WSendData(Index, TxtSendData(Index).Text) '-------------Send data > &<
							End If
						End If
						
					Else
						multiple(Index) = 1
						If CDbl(TxtCntSendTal(Index).Text) - CDbl(TxtCntSend(Index).Text) < 100 * CInt(1024) Then 'add if at 2004/04/10
							WSendData(Index, TxtSendData(Index).Text) '-------------Send data > &<
						End If
					End If
				End If
				
			End If
		Else
			If OptTestMode(1).Checked = True Then '----------send data only 0,2,4,6
				If idx Mod 2 = 0 Then
					If CDbl(TxtCntSendTal(Index).Text) - CDbl(TxtCntSend(Index).Text) < 100 * CInt(1024) Then 'add if at 2004/04/10
						WSendData(Index, TxtSendData(Index).Text) '-------------Send data > &<
					End If
				End If
			Else
				If CDbl(TxtCntSendTal(Index).Text) - CDbl(TxtCntSend(Index).Text) < 100 * CInt(1024) Then 'add if at 2004/04/10
					WSendData(Index, TxtSendData(Index).Text) '-------------Send data > &<
				End If
			End If
		End If
		'----------------------------upper add by Elle (pingpong)-------------------------------
		
		'    If TxtCntSendTal(Index) - TxtCntSend(Index) < 100 * CLng(1024) Then   'add if at 2004/04/10  comma by Elle
		'    WSendData Index, TxtSendData(Index)        '-------------Send data > &<    comma by Elle
		'    End If                                     '------------------------comma by Elle
		
		'If OptTestMode(0).Value = False Then    'Cross Test
		'Winsock1(Index).SendData MsgStr
		'End If
		
		'TxtCntSendTal(Index) = TxtCntSendTal(Index) + Len(MsgStr)
		
		ErrMsg(Index) = ""
		
		'List1.AddItem "Send :" & Len(TxtSendData)
		
		Exit Sub
		
err99: 
		
		ErrStr = ErrorToString()
		If ErrMsg(Index) = ErrStr Then Exit Sub 'Only Log Error Message One Times
		ErrMsg(Index) = ErrStr
		
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & "  COM " & Index + 1 & "   TmrSend Error: " & ErrStr
		lerror(List1, MsgStr)
		
	End Sub
	
	Private Sub ChcekLoss(ByRef Index As Short)
		Dim MsgStr As String
		Dim i As Short
		
		On Error GoTo err99
		
		'If OptTestMode(0).Value = True Then         'LoopBack Test
		'    Index = 1
		'Else
		'    Index = 0
		'End If
		
		TxtCntLoss(Index).Text = CStr(Val(TxtCntSend(Index).Text) - Val(TxtCntRcv(Index).Text))
		Exit Sub
		
		i = Index
		'For i = 0 To Index
		If TxtCntLoss(i).Text <> "0" Then
			If LossCnt(i) <> TxtCntLoss(i).Text Then
				MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & i + 1 & " Loss=" & CDbl(TxtCntLoss(i).Text) - CDbl(LossCnt(i)) & " Send=" & TxtCntSendTal(i).Text & ", Send OK=" & TxtCntSend(i).Text & ", Receive=" & TxtCntRcv(i).Text & ", Total Loss=" & TxtCntLoss(i).Text
				lerror(List1, MsgStr)
				LossCnt(i) = TxtCntLoss(i).Text
				OldLoss(i) = TxtCntLoss(i).Text
				
			End If
		Else
			LossCnt(i) = "0"
			'--- Check Full Data Receive --------
			If OldLoss(i) <> "0" Then
				MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & i + 1 & " Full Receive:" & " Send=" & TxtCntSendTal(i).Text & ", Send OK=" & TxtCntSend(i).Text & ", Receive=" & TxtCntRcv(i).Text & ", Total Loss=" & TxtCntLoss(i).Text
				lerror(List1, MsgStr)
				OldLoss(i) = TxtCntLoss(i).Text
			End If
		End If
		'Next
		Exit Sub
		
err99: 
		
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & "  COM " & Index + 1 & " CheckLoss Error: " & ErrorToString()
		lerror(List1, MsgStr)
		
	End Sub
	
	
	'UPGRADE_WARNING: 初始化表單時可能會引發事件 TxtCntLoss.TextChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TxtCntLoss_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtCntLoss.TextChanged
		Dim Index As Short = TxtCntLoss.GetIndex(eventSender) '-------add by Elle
		Dim error_msg As String
		If Val(TxtCntLoss(Index).Text) > Val(TxtSendDataLen(Index).Text) Then
			error_msg = " " & "IP :" & " " & txtip(Index).Text & "  COM " & Index + 1 & "   Total Loss : " & TxtCntLoss(Index).Text
			lerror(List1, error_msg)
		End If
	End Sub
	
	Private Sub TxtCntLoss_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtCntLoss.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = TxtCntLoss.GetIndex(eventSender)
		KeyAscii = 0
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtCntRcv_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtCntRcv.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = TxtCntRcv.GetIndex(eventSender)
		KeyAscii = 0
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub TxtCntSend_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtCntSend.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = TxtCntSend.GetIndex(eventSender)
		
		KeyAscii = 0
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	
	Private Sub TxtCntSendTal_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtCntSendTal.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = TxtCntSendTal.GetIndex(eventSender)
		
		KeyAscii = 0
		
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: 初始化表單時可能會引發事件 txtip.TextChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub txtip_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles txtip.TextChanged
		Dim Index As Short = txtip.GetIndex(eventSender)
		
		Me.Text = txtip(0).Text 'Evan added 2007/10/24
		
		'--------------------------------------------------------Evan added below (for COM3~COM8 of IP address) 2007/10/24  comma by Elle
		'    If Index = 0 Then
		'        txtip(1).Text = txtip(0).Text
		'        txtip(2).Text = txtip(1).Text
		'        txtip(3).Text = txtip(2).Text
		'        txtip(4).Text = txtip(3).Text
		'        txtip(5).Text = txtip(4).Text
		'        txtip(6).Text = txtip(5).Text
		'        txtip(7).Text = txtip(6).Text
		''    Else
		''        txtip(0).Text = txtip(1).Text
		'    End If
		'--------------------------------------------------------Evan added end 2007/10/24      comma by Elle
		
		
		'    If Index = 0 Then
		'        txtip(1).Text = txtip(0).Text
		'    Else
		'        txtip(0).Text = txtip(1).Text
		'    End If
		
		
	End Sub
	
	
	Private Sub TxtRcvPket_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtRcvPket.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = TxtRcvPket.GetIndex(eventSender)
		
		KeyAscii = 0
		
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	'UPGRADE_WARNING: 初始化表單時可能會引發事件 TxtSendDataLen.TextChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TxtSendDataLen_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtSendDataLen.TextChanged
		Dim Index As Short = TxtSendDataLen.GetIndex(eventSender)
		'Const STR_DATA = "1234567890"
		Dim i As Short
		Dim tmpstr, MsgStr As String
		
		On Error GoTo ERRCMD
		
		tmpstr = ""
		For i = 1 To Val(TxtSendDataLen(Index).Text) - LEN_PKET_HEAD
			tmpstr = tmpstr & (i Mod 10)
		Next i
		
		TxtSendData(Index).Text = tmpstr '------send content of data
		
		Exit Sub
		
		
ERRCMD: 
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & "TxtSendDataLen Err: " & ErrorToString()
		lerror(List1, MsgStr)
	End Sub
	
	'UPGRADE_WARNING: 初始化表單時可能會引發事件 TxtSendDataLentoall.TextChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TxtSendDataLentoall_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtSendDataLentoall.TextChanged
		
		TxtSendDataLen(0).Text = TxtSendDataLentoall.Text
		TxtSendDataLen(1).Text = TxtSendDataLentoall.Text
		TxtSendDataLen(2).Text = TxtSendDataLentoall.Text
		TxtSendDataLen(3).Text = TxtSendDataLentoall.Text
		TxtSendDataLen(4).Text = TxtSendDataLentoall.Text
		TxtSendDataLen(5).Text = TxtSendDataLentoall.Text
		TxtSendDataLen(6).Text = TxtSendDataLentoall.Text
		TxtSendDataLen(7).Text = TxtSendDataLentoall.Text
		
	End Sub
	
	'UPGRADE_WARNING: 初始化表單時可能會引發事件 TxtSendIntvaltoall.TextChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
	Private Sub TxtSendIntvaltoall_TextChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles TxtSendIntvaltoall.TextChanged 'Evan added
		
		TxtSendIntval(0).Text = TxtSendIntvaltoall.Text
		TxtSendIntval(1).Text = TxtSendIntvaltoall.Text
		TxtSendIntval(2).Text = TxtSendIntvaltoall.Text
		TxtSendIntval(3).Text = TxtSendIntvaltoall.Text
		TxtSendIntval(4).Text = TxtSendIntvaltoall.Text
		TxtSendIntval(5).Text = TxtSendIntvaltoall.Text
		TxtSendIntval(6).Text = TxtSendIntvaltoall.Text
		TxtSendIntval(7).Text = TxtSendIntvaltoall.Text
	End Sub
	
	Private Sub TxtSendPketTal_KeyPress(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.KeyPressEventArgs) Handles TxtSendPketTal.KeyPress
		Dim KeyAscii As Short = Asc(eventArgs.KeyChar)
		Dim Index As Short = TxtSendPketTal.GetIndex(eventSender)
		
		KeyAscii = 0
		
		eventArgs.KeyChar = Chr(KeyAscii)
		If KeyAscii = 0 Then
			eventArgs.Handled = True
		End If
	End Sub
	
	Private Sub Winsock1_CloseEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Winsock1.CloseEvent
		Dim Index As Short = Winsock1.GetIndex(eventSender)
		Dim MsgStr As String
		
		Winsock1(Index).Close()
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & Index + 1 & " Close Complete!"
		lerror(List1, MsgStr)
		
		'Exit Sub
		
		If InStr(CmdSendBeg(Index).Text, "Stop") > 0 Then
			CmdSendBeg(Index).PerformClick()
		End If
		
		CmdSendBeg(Index).Enabled = False
		
	End Sub
	
	Private Sub Winsock1_ConnectEvent(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Winsock1.ConnectEvent
		Dim Index As Short = Winsock1.GetIndex(eventSender)
		Dim ret, optval As Short
		Dim sck As Integer
		Dim MsgStr, tmpstr As String
		
		iRx(Index) = 0 '------add by Elle
		iTx(Index) = 0 '------add by Elle
		iLoss(Index) = 0 '------add by Elle
		
		If OptTestMode(0).Checked = True Then 'Loopback Test
			tmpstr = " Loopback Test "
		Else
			tmpstr = " Cross Test "
		End If
		
		
		
		txtLocalPort(Index).Text = CStr(Winsock1(Index).LocalPort)
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & Index + 1 & tmpstr & "Connect OK! (" & Winsock1(Index).RemoteHost & ")"
		lerror(List1, MsgStr)
		
		
		'-------below add by Elle -----------------
		If OptTestMode(1).Checked = True Then
			CmdSendBeg(Index).Enabled = False
		Else
			CmdSendBeg(Index).Enabled = True
		End If
		'-------upper add by Elle------------------
		
		'    CmdSendBeg(Index).Enabled = True       '-------comma by Elle
		
		sck = Winsock1(Index).SocketHandle
		socket(Index) = sck
		optval = -1
		'    ret = setsockopt(socket(Index), SOL_SOCKET, SO_KEEPALIVE, optval, 2)
		
		'Timer2.Enabled = False
		
	End Sub
	
	Private Sub Winsock1_ConnectionRequest(ByVal eventSender As System.Object, ByVal eventArgs As AxMSWinsockLib.DMSWinsockControlEvents_ConnectionRequestEvent) Handles Winsock1.ConnectionRequest
		Dim Index As Short = Winsock1.GetIndex(eventSender)
		MsgBox(Index & "  DAP Connection Request")
		'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
		If Winsock1(Index).CtlState <> MSWinsockLib.StateConstants.sckClosed Then Winsock1(Index).Close()
		'接受具有 requestID 參數的
		'連線。
		Winsock1(Index).Accept(eventArgs.requestID)
		
		
		iRx(Index) = 0 '------add by Elle
		iTx(Index) = 0 '------add by Elle
		iLoss(Index) = 0 '------add by Elle
	End Sub
	
	Function CheckRcvData(ByRef Index As Short, ByRef DataStr As String) As Boolean
		Dim idx, ret As Short
		
		'Debug.Print DataStr
		CheckRcvData = False
		'--- Check Total Length ------
		If Len(DataStr) <> CDbl(TxtSendDataLen(Index).Text) Then Exit Function 'Receive Fail
		
		'--- Check Packet Head -------
		idx = InStr(DataStr, CODE_PKET_HEAD)
		If idx <= 0 Then Exit Function 'Format Error
		
		'--- Check Packket Data Content ----
		If Mid(DataStr, LEN_PKET_HEAD + 1) <> TxtSendData(Index).Text Then Exit Function 'Data Error
		
		'--- Data Format Exact -------
		CheckRcvData = True
		
	End Function
	
	Private Sub Winsock1_DataArrival(ByVal eventSender As System.Object, ByVal eventArgs As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles Winsock1.DataArrival
		Dim Index As Short = Winsock1.GetIndex(eventSender)
		Dim DataStr, tmpstr, op, HeadStr As String
		Dim ret, i As Integer
		Dim lens, idx As Short
		Dim flag As Boolean
		Dim GoodStr, OldData, AccCmd As String
		Dim DapData() As Byte
		Dim tran_id As Short
		Dim MsgStr As String
		Dim tmpNo As Integer
		Static GetHeadFlag(7) As Boolean
		Static Pket_No(7) As Integer
		Dim pkno As Integer '-----------add by Elle
		
		Const POS_TRAN_ID As Short = 4 'tran_id
		Const POS_CMD_ACCCMD As Short = 9 'Acc_Cmd:Sub-Sub-Cmd
		Const POS_CMD_GOOD As Short = 10 '"G" data position
		
		On Error GoTo ERRCMD
		
		flag = False
		
		ReDim DapData(eventArgs.bytesTotal)
		
		
		If OptTestMode(0).Checked = True Then 'LoopBack Test
			idx = Index
		Else
			idx = Index '----------orginal-> idx=0 change by Elle
			
		End If
		
		
		
		Winsock1(Index).GetData(DapData, VariantType.Byte)
		lens = eventArgs.bytesTotal
		
		DataStr = Bin2Str(DapData, 0, lens)
		
		
		'----------below add by Elle-------------------
		'       If lens > Val(TxtSendDataLentoall.Text) Then
		'       Debug.Print "Stop"
		'       End If
		'----------upper add by Elle-------------------
		
		'-------------------------------------------------------------------------------------------------
#If 1 Then
		RcvDataBuf(idx) = RcvDataBuf(idx) & DataStr
DATA_NEXT: 
		If Len(RcvDataBuf(idx)) < CDbl(TxtSendDataLen(idx).Text) Then Exit Sub 'Have Head, Data Pket Not Rcv Finish
		
		ret = InStr(RcvDataBuf(idx), CODE_PKET_HEAD) 'Check Have Head in Data
		If ret <> 1 Then 'no head, ignore the data
			If ret = 0 Then 'no head, ignore the data
				OldData = RcvDataBuf(idx)
				RcvDataBuf(idx) = ""
			Else
				OldData = VB.Left(RcvDataBuf(idx), ret - 1)
				RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret) 'Save Old Data
			End If
			
DATA_ERR: 
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & idx + 1 & "    Data Error: Garbage Data=" & OldData & ", Old PketNo=" & Hex(CInt(TxtRcvPket(idx).Text))
			lerror(List1, MsgStr)
			Exit Sub
		End If
		
#If 0 Then
		'UPGRADE_NOTE: #If #EndIf 區塊沒有升級，因為運算式 0 評估不為 True 或尚未評估。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
		tmpNo = AscW(Mid(RcvDataBuf(idx), 5, 1))                        'New PketNo Low
		tmpNo = AscW(Mid(RcvDataBuf(idx), 4, 1)) + tmpNo * &H100        'New PketNo High
		'Pket_No(idx) = tmpNo
#Else
		tmpNo = CInt("&H" & Mid(RcvDataBuf(idx), 4, 4)) 'update 2004/08/12, seq no. is a hex string
#End If
		
		ret = CInt(TxtSendDataLen(idx).Text)
		OldData = VB.Left(RcvDataBuf(idx), ret)
		'        Debug.Print "OldData= " & OldData    '----------add by Elle
		RcvDataBuf(idx) = Mid(RcvDataBuf(idx), ret + 1)
		
		'--- Check Data Format ------
		flag = CheckRcvData(idx, OldData)
		If flag = True Then 'Format Exact
			TxtRcvPket(idx).Text = CStr(tmpNo)
			TxtCntRcv(idx).Text = CStr(CDbl(TxtCntRcv(idx).Text) + Len(OldData))
		Else
			GoTo DATA_ERR
		End If
		
		'-------------------------------------------------------------------------------------------------
#Else
		'UPGRADE_NOTE: #If #EndIf 區塊沒有升級，因為運算式 Else 評估不為 True 或尚未評估。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
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
		MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & idx + 1 & "    Data Error: Old PketNo=" & (tmpNo) & ", OldData=" & OldData & _
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
		MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & idx + 1 & " Data Error: Garbage Data=" & OldData & ", New PketNo=" & Hex(tmpNo)
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
		If flag Then 'Receive Format Exact
			' Debug.Print "tmpNo=" & tmpNo
			ret = tmpNo - Pket_No(idx) 'New-Old
			If ret > 1 Then 'Packet Loss
#If 1 Then
				MsgStr = " " & "IP :" & " " & txtip(Index).Text & "  COM " & idx + 1 & ",   " & CStr(ret) & " Packet Loss: " & CStr(Pket_No(idx) + 1) & "," & CStr(tmpNo)
				lerror(List1, MsgStr)
#Else
				'UPGRADE_NOTE: #If #EndIf 區塊沒有升級，因為運算式 Else 評估不為 True 或尚未評估。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
				For i = 1 To ret - 1
				MsgStr = " " & "IP :" & " " & txtip(Index) & "  COM " & idx + 1 & " Packet Loss: PketNo=" & Pket_No(idx) + i
				lerror List1, MsgStr
				Next i
#End If
			ElseIf ret <= 0 Then 
				MsgStr = " " & "IP :" & " " & txtip(Index).Text & " COM " & idx + 1 & " Packet Reverse: Old PketNo=" & Pket_No(idx) & ", New PketNo=" & tmpNo
				lerror(List1, MsgStr)
			End If
			
			Pket_No(idx) = tmpNo
			If RcvMode(idx) = RCV_TIMEOUT Then 'Time Out Mode
				'tmpstr = Bin2Str(DapData, 0, lens)
				'RcvDataBuf(idx) = RcvDataBuf(idx) & tmpstr
				If 1 Then 'Len(RcvDataBuf(idx)) >= TxtSendDataLen(idx) Then   'Receive Finish
					If TmrSend(idx).Enabled = True Then 'On Sending
						WSendData(idx, TxtSendData(idx).Text)
						'Winsock1(idx).SendData RcvDataBuf(idx)
						TxtCntSendTal(idx).Text = CStr(CDbl(TxtCntSendTal(idx).Text) + Len(RcvDataBuf(idx)))
						'RcvDataBuf(idx) = ""
						'--- Reset Timer Counter ------
						TmrSend(idx).Enabled = False
						TmrSend(idx).Enabled = True
					End If
				End If
			End If
		End If
		
		
		'List1.AddItem "Rcv :" & lens
		
		TxtCntLoss(idx).Text = CStr(CDbl(TxtCntSend(idx).Text) - CDbl(TxtCntRcv(idx).Text))
		
		
		'-----------------below add by Elle------------------------
		Receive_data(Index) = OldData
		
		
		If OptTestMode(1).Checked = True Then '-------for cross test
			If idx Mod 2 <> 0 Then
				
				'            If Len(DataStr) <> Val(TxtSendDataLentoall.Text) Then
				'                Debug.Print " Stop  "
				'            End If
				
				'                Debug.Print "Loop real send data= " & OldData
				
				Winsock1(idx).SendData(OldData)
				TxtCntSendTal(idx).Text = CStr(Val(TxtCntSendTal(idx).Text) + Len(OldData))
				
				'-------below (elle want to know pkno = FFFF)--------------
				If Mid(OldData, 4, 4) = "FFFF" Then
					FFFF_getpkno = FFFF_getpkno + 1
					Debug.Print("OldData= " & OldData)
					Debug.Print(TimeOfDay & "    FFFF--> Count= " & FFFF_getpkno) '---------more than FFFF
					TxtSendPketTal(idx).Text = CStr(65535 * FFFF_getpkno) '-------comma by Elle (bytes limits to 00000~FFFFF )
					
				Else
					pkno = CInt("&H" & Mid(OldData, 4, 4)) '-------comma by Elle (bytes limits to 00000~FFFF)
					TxtSendPketTal(idx).Text = CStr(65535 * FFFF_getpkno + pkno) '-------comma by Elle (bytes limits to 00000~FFFFF )
				End If
				'-------upper (elle want to know pkno=FFFF)----------------
				
				'                pkno = CLng("&H" & Mid(OldData, 4, 4))       '-------comma by Elle (bytes limits to 00000~FFFF)
				'                TxtSendPketTal(idx).Text = pkno              '-------comma by Elle (bytes limits to 00000~FFFFF )
			End If
		End If
		'------------------upper add by Elle-----------------------
		
		If Len(RcvDataBuf(idx)) <> 0 Then
			GoTo DATA_NEXT
		Else
			'---------below add by Elle------------------
			If OptTestMode(1).Checked = True And idx = 1 Or idx = 3 Or idx = 5 Or idx = 7 Then '----select "Cross Test" and COM1/3/5/7
			Else
				If InStr(CmdSendBeg(idx).Text, "Start") > 0 Then 'Press Stop
					'--- Check Full Data Receive --------
					If flag Then 'TxtCntLoss(idx) = "0" And OldLoss(idx) <> "0" Then
						
						MsgStr = " " & "IP :" & " " & txtip(Index).Text & "  COM " & idx + 1 & " Full Receive:" & " Send=" & TxtCntSendTal(idx).Text & ", Send OK=" & TxtCntSend(idx).Text & ", Receive=" & TxtCntRcv(idx).Text & ", Total Loss=" & TxtCntLoss(idx).Text & ", SendPket=" & TxtSendPketTal(idx).Text & ", RcvPket=" & TxtRcvPket(idx).Text
						lerror(List1, MsgStr)
						OldLoss(idx) = TxtCntLoss(idx).Text '------there is value of Loss
					Else
						OldLoss(idx) = TxtCntLoss(idx).Text
					End If
				End If
				
			End If
			'---------upper add by Elle------------------
			
			'---------------------------------below comma by Elle-------------------------------------
			'            If InStr(CmdSendBeg(idx).Caption, "Start") > 0 Then   'Press Stop
			'                '--- Check Full Data Receive --------
			'                If flag Then    'TxtCntLoss(idx) = "0" And OldLoss(idx) <> "0" Then
			'
			'                    MsgStr = " " & "IP :" & " " & txtip(Index) & " COM " & idx + 1 & " Full Receive:" & " Send=" & TxtCntSendTal(idx) & ", Send OK=" & _
			''                            TxtCntSend(idx) & ", Receive=" & TxtCntRcv(idx) & ", Total Loss=" & TxtCntLoss(idx) & _
			''                            ", SendPket=" & TxtSendPketTal(idx) & ", RcvPket=" & TxtRcvPket(idx)
			'                    lerror List1, MsgStr
			'                    OldLoss(idx) = TxtCntLoss(idx)     '------there is value of Loss
			'                Else
			'                    OldLoss(idx) = TxtCntLoss(idx)
			'                End If
			'            End If
			'---------------------------------upper comma by Elle---------------------------------------
		End If
		
		Exit Sub
		
		Resume 
		
ERRCMD: 
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & "  COM " & Index + 1 & "    Winsock1.DataArrival Err: " & Err.Number & " " & ErrorToString()
		Debug.Print("Error= " & Err.Description)
		lerror(List1, MsgStr)
		If chk_stopsend.CheckState = 1 Then '---------when the state of com happen "Type mismatch", stop sending
			If InStr(MsgStr, " 13 ") > 0 Then
				
				If OptTestMode(1).Checked = True Then
					'UPGRADE_WARNING: Mod 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
					If Val(CStr(Index)) Mod 2 = 0 Then '-------For Cross test (stop two connections)
						Winsock1(Index).Close()
						Winsock1(Index + 1).Close()
						TmrSend(Index).Enabled = False
					Else
						Winsock1(Index).Close()
						Winsock1(Index - 1).Close()
						TmrSend(Index - 1).Enabled = False
					End If
				Else '--------For LoopBack test (stop one connection)
					Winsock1(Index).Close()
					TmrSend(Index).Enabled = False
				End If
				
			End If
		End If
		Exit Sub
	End Sub
	
	Private Sub Winsock1_Error(ByVal eventSender As System.Object, ByVal eventArgs As AxMSWinsockLib.DMSWinsockControlEvents_ErrorEvent) Handles Winsock1.Error
		Dim Index As Short = Winsock1.GetIndex(eventSender)
		On Error Resume Next
		Dim MsgStr As String
		MsgStr = " " & "IP :" & " " & txtip(Index).Text & "   COM " & Index + 1 & " Winsock Error: (" & eventArgs.Number & ") " & eventArgs.Description & " Send=" & TxtCntSendTal(Index).Text & ", Send OK=" & TxtCntSend(Index).Text & ", Receive=" & TxtCntRcv(Index).Text & ", Total Loss=" & TxtCntLoss(Index).Text
		lerror(List1, MsgStr)
		'Simon added
		MsgBox("IP :" & txtip(Index).Text & " " & " COM " & Index + 1 & "  " & "can't connect !", MsgBoxStyle.Critical) 'added on 2009/09/21
		'        If Index Mod 2 = 0 Then
		'        CmdSendBeg_Click (Index)
		'        cmdCnect_Click (Index)
		'        cmdCnect_Click (Index)
		'        cmdCnect_Click (Index + 1)
		'        cmdCnect_Click (Index + 1)
		'        CmdSendBeg_Click (Index)
		'        Else
		'        CmdSendBeg_Click (Index - 1)
		'        cmdCnect_Click (Index - 1)
		'        cmdCnect_Click (Index - 1)
		'        cmdCnect_Click (Index)
		'        cmdCnect_Click (Index)
		'        CmdSendBeg_Click (Index - 1)
		'        End If
	End Sub
	
	Private Sub Winsock1_SendComplete(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Winsock1.SendComplete
		Dim Index As Short = Winsock1.GetIndex(eventSender)
		'        MsgBox Index & "  DAP SendComplete"
		
		
	End Sub
	
	Private Sub Winsock1_SendProgress(ByVal eventSender As System.Object, ByVal eventArgs As AxMSWinsockLib.DMSWinsockControlEvents_SendProgressEvent) Handles Winsock1.SendProgress
		Dim Index As Short = Winsock1.GetIndex(eventSender)
		' List1.AddItem Index & "  DAP SendProgress " & bytesSent & ", " & bytesRemaining
		Dim MsgStr As String
		
		TxtCntSend(Index).Text = CStr(CDbl(TxtCntSend(Index).Text) + eventArgs.bytesSent) '---------sendbyte
		
		'--- Check Remaind Counter ----
		If eventArgs.bytesRemaining > 0 Then 'Have Remaining
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & "  COM " & Index + 1 & " WinsockSend Remaind: Sending=" & eventArgs.bytesSent & ", Remaining=" & eventArgs.bytesRemaining
			lerror(List1, MsgStr)
			
			MsgStr = " " & "IP :" & " " & txtip(Index).Text & "  COM " & Index + 1 & " Send=" & TxtCntSendTal(Index).Text & ", Send OK=" & TxtCntSend(Index).Text & ", Receive=" & TxtCntRcv(Index).Text & ", Total Loss=" & TxtCntLoss(Index).Text
			lerror(List1, MsgStr)
		End If
		
	End Sub
End Class