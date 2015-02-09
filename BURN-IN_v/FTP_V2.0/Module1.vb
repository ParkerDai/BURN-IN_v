Option Strict Off
Option Explicit On
Module Module1
	
	Public Const UDP_INVITE_PORT As Integer = 55954
	Public Const UDP_TEST_PORT As Integer = 55950
	
	Public Const DEVICE_MAX As Short = 300
	
	Public DA(DEVICE_MAX - 1, 2) As String
	Public DA1(DEVICE_MAX - 1, 20) As String
	'Global DA2(DEVICE_MAX - 1, 20) As String
	Public DA2(DEVICE_MAX - 1, 21) As String '---update 2006/08/08
	
	Public DevCount As Short
	Public DevSetCount As Short
	Public DevTestCount As Short
	Public DevNormalCount As Short
	Public DevDefaultCount As Short
	
	Public ProcStep As Short
	
	
	Function GetInviteReply(ByRef tmpv As Object) As String
		Dim tmpstr As String
		Dim tmpMac, tmpIP, tmpNetmask, tmpModel As String
		Dim i, j As Short
		
		On Error GoTo GetInviteReply_99
		
		'---get ip
		'UPGRADE_WARNING: 無法解析物件 tmpv(15) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: 無法解析物件 tmpv(14) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: 無法解析物件 tmpv(13) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tmpstr = tmpv(12) & "." & tmpv(13) & "." & tmpv(14) & "." & tmpv(15)
		'MsgBoxT tmpstr
		tmpIP = tmpstr
		
		'---get netmask
		'UPGRADE_WARNING: 無法解析物件 tmpv(239) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: 無法解析物件 tmpv(238) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: 無法解析物件 tmpv(237) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		tmpstr = tmpv(236) & "." & tmpv(237) & "." & tmpv(238) & "." & tmpv(239)
		tmpNetmask = tmpstr
		
		'---get mac
		tmpstr = ldump41(tmpv, 28, 6)
		tmpMac = tmpstr
		
		'---get model
		tmpstr = HexOp31(tmpv, 44, 16)
		tmpModel = Trim(tmpstr)
		
		For i = 0 To DevCount - 1
			If DA2(i, 2) = tmpMac Then '---MAC already recorded
				If DA2(i, 0) = tmpIP Then
                    Exit Function '---IP is the same then not necessary to be updated
				Else
					Exit For '---update it
				End If
			End If
		Next i
		
		If i = DevCount Then '---a new device
			If DevCount >= DEVICE_MAX Then
				Exit Function '---device count overflow
			End If
		End If
		
		DA2(i, 0) = tmpIP
		DA2(i, 1) = tmpNetmask
		DA2(i, 2) = tmpMac
		
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 3) = tmpv(12) '---IP
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 4) = tmpv(13)
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 5) = tmpv(14)
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 6) = tmpv(15)
		
		DA2(i, 7) = tmpModel '---model name
		DA2(i, 8) = CStr(ProcStep)
		
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 9) = tmpv(28) '---mac
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 10) = tmpv(29)
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 11) = tmpv(30)
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 12) = tmpv(31)
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 13) = tmpv(32)
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 14) = tmpv(33)
		
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 15) = tmpv(236) '---netmask
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 16) = tmpv(237)
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 17) = tmpv(238)
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 18) = tmpv(239)
		
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 19) = tmpv(26) '---last 2 bytes of gateway
		'UPGRADE_WARNING: 無法解析物件 tmpv() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		DA2(i, 20) = tmpv(27)
		
		DA2(i, 21) = "" '---add 2006/08/08, as status
		
		If ProcStep = 0 Then '---Invite step
			DevCount = DevCount + 1
			frmtcp.cmdChgIP.Enabled = True
			frmtcp.cmdDefault.Enabled = True
			
			'           MsgBoxT DA2(i, 0) & "---" & DA2(i, 1) & "---" & DA2(i, 2) & "---" & "OK"
			
			DA2(i, 21) = "Invite OK" '---add 2006/08/08
			tmpstr = ShowDev(i)
			MsgBoxT1(tmpstr)
			
			UpdateDevListStatus(i) '---add 2006/08/08
			
			frmtcp.lbDevCnt.Text = CStr(DevCount)
			
		ElseIf ProcStep = 1 Then  '---In set step
			'UPGRADE_WARNING: 無法解析物件 tmpv(15) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: 無法解析物件 tmpv(33) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: 無法解析物件 tmpv(14) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: 無法解析物件 tmpv(32) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If tmpv(32) = tmpv(14) And tmpv(33) = tmpv(15) Then '---last 2 bytes, mac=ip
				DevSetCount = DevSetCount + 1 '---this is configured ip
				frmtcp.cmdStartTest.Enabled = True
				
				
				DA2(i, 21) = "Change IP OK" '---add 2006/08/08
				tmpstr = ShowDev(i)
				MsgBoxT2(tmpstr)
				
				UpdateDevListStatus(i) '---add 2006/08/08
				
				frmtcp.lbDevSetCnt.Text = CStr(DevDefaultCount) 'Evan "= DevSetCount" exchange "= DevDefaultCount" 2007/10/18
				
				If DevSetCount = DevCount Then
					frmtcp.cmdChgIP.Enabled = True
				End If
			End If
			
		ElseIf ProcStep = 4 Then  '---Invite step
			'UPGRADE_WARNING: 無法解析物件 tmpv(15) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: 無法解析物件 tmpv(14) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: 無法解析物件 tmpv(13) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			'UPGRADE_WARNING: 無法解析物件 tmpv(12) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			If (tmpv(12) = 10 And tmpv(13) = 0 And tmpv(14) = 50 And tmpv(15) = 100) Or (tmpv(12) = 192 And tmpv(13) = 168 And tmpv(14) = 1 And tmpv(15) = 1) Then
				DevDefaultCount = DevDefaultCount + 1 '---this is configured ip
				
				DA2(i, 21) = "Set Default IP OK" '---add 2006/08/08
				tmpstr = ShowDev(i)
				MsgBoxT5(tmpstr)
				
				UpdateDevListStatus(i) '---add 2006/08/08
				
				frmtcp.lbDevDefaultCnt.Text = CStr(DevDefaultCount)
			End If
		End If
		Exit Function
		
GetInviteReply_99: 
		Exit Function
		Resume 
	End Function
	
	Function SendConfig(ByRef ndx As Short) As Short
		Dim bdata(300 - 1) As Byte
		
		frmtcp.udpClient.RemoteHost = "255.255.255.255"
		frmtcp.udpClient.RemotePort = UDP_INVITE_PORT
		
		'---configure IP
		bdata(0) = 0
		bdata(1) = 1
		bdata(2) = 6
		bdata(4) = &H92
		bdata(5) = &HDA
		
		'---old IP
		bdata(12) = CByte(DA2(ndx, 3))
		bdata(13) = CByte(DA2(ndx, 4))
		bdata(14) = CByte(DA2(ndx, 5))
		bdata(15) = CByte(DA2(ndx, 6))
		
		'---old MAC
		bdata(28) = CByte(DA2(ndx, 9))
		bdata(29) = CByte(DA2(ndx, 10))
		bdata(30) = CByte(DA2(ndx, 11))
		bdata(31) = CByte(DA2(ndx, 12))
		bdata(32) = CByte(DA2(ndx, 13))
		bdata(33) = CByte(DA2(ndx, 14))
		
		Select Case (DA2(ndx, 4))
			Case CStr(0)
				'---new IP
				bdata(16) = 10
				bdata(17) = 0
				bdata(18) = CByte(DA2(ndx, 13))
				bdata(19) = CByte(DA2(ndx, 14))
				
				'---new Getway
				bdata(24) = 10
				bdata(25) = 0
				bdata(26) = 0
				bdata(27) = 254
				
				'---new Netmask
				bdata(236) = 255
				bdata(237) = 255
				bdata(238) = 0
				bdata(239) = 0
				
			Case CStr(168)
				'---new IP
				bdata(16) = 192
				bdata(17) = 168
				bdata(18) = CByte(DA2(ndx, 13))
				bdata(19) = CByte(DA2(ndx, 14))
				
				'---new Gteway
				bdata(24) = 192
				bdata(25) = 168
				bdata(26) = 1
				bdata(27) = 254
				
				'---new Netmask
				bdata(236) = 255
				bdata(237) = 255
				bdata(238) = 0
				bdata(239) = 0
				
			Case Else
				Exit Function
		End Select
		
		bdata(70) = 2
		
		'---suppose user/password is default: "admin "
		bdata(71) = Asc("a")
		bdata(72) = Asc("d")
		bdata(73) = Asc("m")
		bdata(74) = Asc("i")
		bdata(75) = Asc("n")
		bdata(76) = Asc(" ")
		
		bdata(255) = &HFF
		
		frmtcp.udpClient.SendData(bdata)
	End Function
	
	Function SendConfigDefault(ByRef ndx As Short) As Short
		Dim bdata(300 - 1) As Byte
		
		frmtcp.udpClient.RemoteHost = "255.255.255.255"
		frmtcp.udpClient.RemotePort = UDP_INVITE_PORT
		
		'---configure IP
		bdata(0) = 0
		bdata(1) = 1
		bdata(2) = 6
		bdata(4) = &H92
		bdata(5) = &HDA
		
		'---old IP
		bdata(12) = CByte(DA2(ndx, 3))
		bdata(13) = CByte(DA2(ndx, 4))
		bdata(14) = CByte(DA2(ndx, 5))
		bdata(15) = CByte(DA2(ndx, 6))
		
		'---old MAC
		bdata(28) = CByte(DA2(ndx, 9))
		bdata(29) = CByte(DA2(ndx, 10))
		bdata(30) = CByte(DA2(ndx, 11))
		bdata(31) = CByte(DA2(ndx, 12))
		bdata(32) = CByte(DA2(ndx, 13))
		bdata(33) = CByte(DA2(ndx, 14))
		
		Select Case (DA2(ndx, 4))
			Case CStr(0)
				'---new IP
				bdata(16) = 10
				bdata(17) = 0
				bdata(18) = 50
				bdata(19) = 100
				
				'---new Gteway
				bdata(24) = 10
				bdata(25) = 0
				bdata(26) = 0
				bdata(27) = 254
				
				'---new Netmask
				bdata(236) = 255
				bdata(237) = 255
				bdata(238) = 0
				bdata(239) = 0
				
			Case CStr(168)
				'---new IP
				bdata(16) = 192
				bdata(17) = 168
				bdata(18) = 1
				bdata(19) = 1
				
				'---new Gteway
				bdata(24) = 192
				bdata(25) = 168
				bdata(26) = 1
				bdata(27) = 254
				
				'---new Netmask
				bdata(236) = 255
				bdata(237) = 255
				bdata(238) = 255
				bdata(239) = 0
				
			Case Else
				Exit Function
		End Select
		
		bdata(70) = 2
		
		'---suppose user/password is default: "admin "
		bdata(71) = Asc("a")
		bdata(72) = Asc("d")
		bdata(73) = Asc("m")
		bdata(74) = Asc("i")
		bdata(75) = Asc("n")
		bdata(76) = Asc(" ")
		
		bdata(255) = &HFF
		
		frmtcp.udpClient.SendData(bdata)
	End Function
	
	Function SendRuninMode(ByRef ndx As Short) As Short
		Dim ret As Short
		Dim tmpstr As String
		Dim bdata(21 - 1) As Byte
		
		If ndx < 0 Then
			frmtcp.udpTest.RemoteHost = "255.255.255.255" '---broadcast
		Else
			frmtcp.udpTest.RemoteHost = DA2(ndx, 0) '---remote IP
		End If
		frmtcp.udpTest.RemotePort = UDP_TEST_PORT
		
		'---configure IP
		bdata(0) = 2 '---header, leading code
		bdata(1) = 1 '---cmd type, set run-in mode
		bdata(2) = 16 '---length
		tmpstr = frmtcp.udpTest.LocalIP '---local IP
		'ret = str2buf(tmpstr, bdata, 3)
		bdata(3 + 15) = 1 '---run-in mode
		'bdata(3 + 16) = GetCRC(bdata, 1, 2 + 16)
		bdata(3 + 17) = 3
		
		frmtcp.udpTest.SendData(bdata)
	End Function
	
	Function SendNormalMode(ByRef ndx As Short) As Short
		Dim ret As Short
		Dim tmpstr As String
		Dim bdata(21 - 1) As Byte
		
		If ndx < 0 Then
			frmtcp.udpTest.RemoteHost = "255.255.255.255" '---broadcast
		Else
			frmtcp.udpTest.RemoteHost = DA2(ndx, 0) '---remote IP
		End If
		frmtcp.udpTest.RemotePort = UDP_TEST_PORT
		
		'---configure IP
		bdata(0) = 2 '---header, leading code
		bdata(1) = 3 '---cmd type, set normal mode
		bdata(2) = 16 '---length
		tmpstr = frmtcp.udpTest.LocalIP '---local IP
		ret = str2buf(tmpstr, bdata, 3)
		bdata(3 + 15) = 0 '---normal mode
		bdata(3 + 16) = GetCRC(bdata, 1, 2 + 16)
		bdata(3 + 17) = 3
		
		frmtcp.udpTest.SendData(bdata)
		'tmpstr = ldump4(bdata, 0, 21)
		'MsgBox2 tmpstr
	End Function
	
	Function ShowDev(ByRef ndx As Short) As String
		'---model + mac + ip
		'ShowDev = DA2(ndx, 7) & "---" & DA2(ndx, 2) & "---" & DA2(ndx, 0) & "---" & "OK"
		'ShowDev = DA2(ndx, 2) & "---" & DA2(ndx, 0) & "---" & DA2(ndx, 7) & "---" & "OK"
		ShowDev = DA2(ndx, 2) & "---" & DA2(ndx, 0) & "---" & DA2(ndx, 7) & "---" & DA2(ndx, 21) '---update 2006/08/08
	End Function
	
	Function ShowDev2(ByRef ndx As Short, ByRef msg As String) As String
		'---model + mac + ip
		ShowDev2 = DA2(ndx, 2) & "---" & DA2(ndx, 0) & "---" & DA2(ndx, 7) & "---" & msg
	End Function
	
	'---add 2006/08/08
	Function ClearDevStatus() As Short
		Dim i As Short
		
		For i = 0 To DevCount - 1
			DA2(i, 21) = ""
		Next i
	End Function
	
	Function ShowDevStatus() As Short
		Dim i As Short
		Dim tmpstr As String
        Dim lst As ListBox
		
		lst = frmtcp.lstDev
		
		'UPGRADE_WARNING: 無法解析物件 lst.Clear 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lst.Items.Clear()
		For i = 0 To DevCount - 1
			tmpstr = ShowDev(i)
			'UPGRADE_WARNING: 無法解析物件 lst.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            lst.Items.Add(tmpstr)
		Next i
	End Function
	
	Function UpdateDevListStatus(ByRef dev_ndx As Short) As Short
		Dim i As Short
		Dim tmpstr As String
        Dim lst As ListBox
		Dim mac As String
		
		On Error GoTo UpdateDevListStatus_99
		
		mac = DA2(dev_ndx, 2)
		tmpstr = ShowDev(dev_ndx)
		lst = frmtcp.lstDev
		
		'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

        For i = 0 To lst.Items.Count - 1
            'UPGRADE_WARNING: 無法解析物件 lst.List 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If mac = Left(lst.Items(i), 12) Then
                'UPGRADE_WARNING: 無法解析物件 lst.List 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
                lst.Items(i) = tmpstr
                Exit Function
            End If
        Next i
		'UPGRADE_WARNING: 無法解析物件 lst.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lst.Items.Add(tmpstr)
		Exit Function
		
UpdateDevListStatus_99: 
		MsgBox("UpdateDevListStatus err=" & ErrorToString())
		Exit Function
		Resume 
	End Function
End Module