Option Strict Off
Option Explicit On
Module DAP
	
	Public Const CCB_LEN As Short = 8
	
	Public Const CCB_LEN_L As Short = 0
	Public Const CCB_LEN_H As Short = 1
	Public Const CCB_MTYPE As Short = 2
	Public Const CCB_DNODE As Short = 3
	Public Const CCB_SNODE As Short = 4
	Public Const CCB_CTYPE As Short = 5
	Public Const CCB_SUBCMD As Short = 6
	Public Const CCB_SUBNODE As Short = 7
	Public Const CCB_DATA As Short = 8
	Sub MsgBox2(ByRef msg As String)
		Dim lst As Object
		Dim tmpstr As String
		
		lst = FrmMain.List1
		tmpstr = TimeString & " " & msg
		
		'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		If lst.ListCount >= 100 Then
			'UPGRADE_WARNING: 無法解析物件 lst.RemoveItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			lst.RemoveItem(0)
		End If
		'UPGRADE_WARNING: 無法解析物件 lst.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lst.AddItem(tmpstr)
		'UPGRADE_WARNING: 無法解析物件 lst.ListIndex 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		lst.ListIndex = lst.ListCount - 1
		
		LogFile2(tmpstr & Chr(13) & Chr(10))
	End Sub
	Sub LogFile2(ByRef data As Object)
		Dim fname As String
		
		fname = My.Application.Info.DirectoryPath & "\" & VB6.Format(Today, "YYYYMMDD") & ".TXT"
		LogFile(fname, data)
	End Sub
	Sub LogFile(ByRef fname As String, ByRef data As Object)
		Dim fnum As Object
		Dim flen As Integer
		Dim i, Cnt, j As Short
		Dim ch As Byte
		Dim data2 As Integer
		
		On Error GoTo LogFile99
		
		'UPGRADE_WARNING: Dir 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
		If Dir(fname) = "" Then
			flen = 0
		Else
			flen = FileLen(fname)
		End If
		
		'UPGRADE_WARNING: 無法解析物件 fnum 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		fnum = FreeFile
		'UPGRADE_WARNING: 無法解析物件 fnum 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileOpen(fnum, fname, OpenMode.Binary)
		Cnt = Len(data)
		j = 1
		For i = 1 To Cnt
#If 0 Then
			'UPGRADE_NOTE: #If #EndIf 區塊沒有升級，因為運算式 0 評估不為 True 或尚未評估。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
			ch = AscW(Mid(data, i, 1)) 'And &HFF
			Put #fnum, flen + i, ch
#Else
			'UPGRADE_WARNING: 無法解析物件 data 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			data2 = Asc(Mid(data, i, 1))
			If data2 < 0 Then data2 = data2 + 65536
			If data2 < 256 Then
				ch = (data2 Mod 256) And &HFF
				'UPGRADE_WARNING: 升級至 FilePut 的 Put 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				FilePut(CInt(fnum), ch, flen + j)
				j = j + 1
			Else
				ch = (data2 \ 256) And &HFF
				'UPGRADE_WARNING: 升級至 FilePut 的 Put 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				FilePut(CInt(fnum), ch, flen + j)
				j = j + 1
				ch = (data2 Mod 256) And &HFF
				'UPGRADE_WARNING: 升級至 FilePut 的 Put 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
				FilePut(CInt(fnum), ch, flen + j)
				j = j + 1
			End If
#End If
		Next i
		'UPGRADE_WARNING: 無法解析物件 fnum 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		FileClose(fnum)
		Exit Sub
		
LogFile99: 
		MsgBox("LogFile err=" & ErrorToString() & ", filename=" & fname)
		Exit Sub
		Resume 
	End Sub
	
	Function File2List(ByRef fname As String, ByRef ListName As System.Windows.Forms.Control) As Short
		Dim fno As Short
		Dim tmpstr As String
		
		On Error GoTo FILE2LIST99
		
		'UPGRADE_WARNING: 無法解析物件 ListName.Clear 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ListName.Clear()
		
		fno = FreeFile
		FileOpen(fno, fname, OpenMode.Input)
		Do While Not EOF(fno)
			Input(fno, tmpstr)
			'UPGRADE_WARNING: 無法解析物件 ListName.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ListName.AddItem(tmpstr)
		Loop 
		FileClose(fno)
		'UPGRADE_WARNING: 無法解析物件 ListName.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		File2List = ListName.ListCount
		
		Exit Function
		
FILE2LIST99: 
		MsgBox(ErrorToString())
		
	End Function
	
	Function GetDapData(ByRef WinSock As System.Windows.Forms.Control, ByRef addr As String, ByRef subcmd As Short, ByRef DapData As String) As Short
		'ret>0 : addr=DAP's port(1/2)+ABLELINK Device's subnode(00..FF)
		'        subcmd=ABLELINK Device's subcmd, DapData=data
		'ret<0 : no data
		' Dim WinSock As Control
		Dim subnode, port As Short
		Dim datalen As Short
		Dim ret As Integer
		'Dim dap1 As DAP
		Dim DapData1() As Byte
		
		' Set WinSock = FrmMain.Winsock1(Dap_Id)
		
		'ret = AB_GW_RcvMsg(Dap_id, dap1)
		'UPGRADE_WARNING: 無法解析物件 WinSock.BytesReceived 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		ret = WinSock.BytesReceived
		If ret < 1 Then 'No Data
			GetDapData = -1
			Exit Function
		End If
		ReDim DapData1(ret)
		'UPGRADE_WARNING: 無法解析物件 WinSock.GetData 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		WinSock.GetData(DapData1) 'dap1
		subnode = DapData1(CCB_SUBNODE)
		subcmd = DapData1(CCB_SUBCMD)
		port = DapData1(CCB_MTYPE)
		datalen = DapData1(CCB_LEN_H) * &H100 + DapData1(CCB_LEN_L) - CCB_LEN
		addr = Trim(Str(port - &H60 + 1)) & Right("00" & Trim(Hex(subnode)), 2)
		'MsgBox ldump3(qway_rcv.ccbdata(), 0, qway_rcv.ccblen - 6)
		'ret = BinCopy(qwaydata(), 0, dap1.ccbdata(), 0, dap1.ccblen - CCB_LEN)
		DapData = Bin2Str(DapData1, CCB_DATA, datalen)
		GetDapData = datalen
		
	End Function
	Function SendDapData(ByRef WinSock0 As System.Windows.Forms.Control, ByRef addr As String, ByRef subcmd As Short, ByRef Data2DapB() As Byte, ByRef datalen As Short) As Short
		'addr=DAP's port(1/2)+ABLELINK Device's subnode(00..FF)
		'subcmd=ABLELINK Device's subcmd
		'Dim WinSock0 As Control
		Dim port, subnode As Short
		Dim i, ret, j As Short
		Dim length, packsize As Short
		'Dim dap1 As DAP
		Dim Cnt, k As Short
		Dim DapData1() As Byte
		Dim Data1 As String
		
		On Error GoTo SENDERR99
		
		'Set WinSock0 = FrmMain.Winsock1(Dap_Id)
		
		ReDim DapData1(CCB_LEN + datalen - 1)
		If Len(addr) > 1 Then
			subnode = Val("&H" & Mid(addr, 2))
		End If
		port = CShort(Left(addr, 1))
		Select Case port
			Case CInt("1")
				DapData1(CCB_MTYPE) = &H60
			Case CInt("2")
				DapData1(CCB_MTYPE) = &H61
			Case Else
				DapData1(CCB_MTYPE) = &HFF
		End Select
		
		DapData1(CCB_DNODE) = 0
		DapData1(CCB_SNODE) = 0
		DapData1(CCB_CTYPE) = 0
		DapData1(CCB_SUBCMD) = subcmd
		DapData1(CCB_SUBNODE) = subnode
		
		'ReDim Data2DapB(200)
		'datalen = Str2Bin(Data2Dap, Data2DapB(), 0)
		'ReDim Preserve DapData1(CCB_LEN + Datalen)
		packsize = 160
		For i = 1 To datalen Step packsize
			Cnt = datalen - i + 1
			If Cnt > packsize Then Cnt = packsize
			'qway_snd.ccbdata(0) = subcmd
			'qway_snd.ccbdata(1) = subnode
			k = CCB_DATA '0
			ret = BinCopy(DapData1, k, Data2DapB, i - 1, Cnt)
			length = CCB_LEN + Cnt
			DapData1(CCB_LEN_H) = length \ &H100
			DapData1(CCB_LEN_L) = length Mod &H100
			
			'ret = AB_GW_SndMsg(Dap_id, dap1)
			'UPGRADE_WARNING: 無法解析物件 WinSock0.SendData 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WinSock0.SendData(DapData1) 'dap1
			'WinSock0.send data1    'dap1
			SendDapData = 1 'ret
			'If Send2Dap <> 0 Then
			'    Exit For
			'End If
		Next i
		Exit Function
		
SENDERR99: 
		MsgBox("Send Error: " & ErrorToString())
		
	End Function
	
	Function SendDapData0(ByRef WinSock0 As System.Windows.Forms.Control, ByRef addr As String, ByRef Data2DapB() As Byte, ByRef datalen As Short) As Short
		'addr=DAP's port(1/2)+ABLELINK Device's subnode(00..FF)
		'subcmd=ABLELINK Device's subcmd
		'Dim WinSock0 As Control
		Dim subnode, port, subcmd As Short
		Dim i, ret, j As Short
		Dim length, packsize As Short
		'Dim dap1 As DAP
		Dim k, Cnt, DataHead As Short
		Dim DapData1() As Byte
		Dim Data1 As String
		
		On Error GoTo SENDERR99
		
		'Set WinSock0 = FrmMain.Winsock1(Dap_Id)
		
		ReDim DapData1(CCB_LEN + datalen - 2 - 1)
		'If Len(addr) > 1 Then
		'subnode = Val("&H" & Mid(addr, 2))
		'End If
		port = CShort(Left(addr, 1))
		Select Case port
			Case CInt("1")
				DapData1(CCB_MTYPE) = &H60
			Case CInt("2")
				DapData1(CCB_MTYPE) = &H61
			Case Else
				DapData1(CCB_MTYPE) = &HFF
		End Select
		DataHead = 1
		If datalen > 0 Then
			subcmd = Data2DapB(0)
			DapData1(CCB_SUBCMD) = subcmd
			DataHead = 2
			If datalen > 1 Then
				subnode = Data2DapB(1)
				DapData1(CCB_SUBNODE) = subnode
				DataHead = 3
			End If
		End If
		
		DapData1(CCB_DNODE) = 0
		DapData1(CCB_SNODE) = 0
		DapData1(CCB_CTYPE) = 0
		
		'ReDim Data2DapB(200)
		'datalen = Str2Bin(Data2Dap, Data2DapB(), 0)
		'ReDim Preserve DapData1(CCB_LEN + Datalen)
		If DataHead > datalen Then 'No data only subCommand
			length = CCB_LEN - 2 + DataHead - 1
			DapData1(CCB_LEN_H) = length \ &H100
			DapData1(CCB_LEN_L) = length Mod &H100
			'UPGRADE_WARNING: 無法解析物件 WinSock0.SendData 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WinSock0.SendData(DapData1) 'dap1
			SendDapData0 = 1 'ret
			Exit Function
		End If
		'--- have data be send -----
		'packsize = 160
		packsize = 300
		For i = DataHead To datalen Step packsize
			Cnt = datalen - i + 1
			If Cnt > packsize Then Cnt = packsize
			'qway_snd.ccbdata(0) = subcmd
			'qway_snd.ccbdata(1) = subnode
			k = CCB_DATA '0
			ret = BinCopy(DapData1, k, Data2DapB, i - 1, Cnt)
			length = CCB_LEN + Cnt
			DapData1(CCB_LEN_H) = length \ &H100
			DapData1(CCB_LEN_L) = length Mod &H100
			
			'ret = AB_GW_SndMsg(Dap_id, dap1)
			'UPGRADE_WARNING: 無法解析物件 WinSock0.SendData 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WinSock0.SendData(DapData1) 'dap1
			'WinSock0.send data1    'dap1
			SendDapData0 = 1 'ret
			'If Send2Dap <> 0 Then
			'    Exit For
			'End If
		Next i
		Exit Function
		Resume 
		
SENDERR99: 
		MsgBox("Send Error: " & ErrorToString())
		
	End Function
	
	Function SendDapData2(ByRef WinSock0 As System.Windows.Forms.Control, ByRef addr As String, ByRef Data2DapB() As Byte, ByRef datalen As Short) As Short
		'SubCmd=0x60
		'addr=DAP's port(1/2)+ABLELINK Device's subnode(00..FF)
		'subcmd=ABLELINK Device's subcmd
		'Dim WinSock0 As Control
		Dim subnode, port, subcmd As Short
		Dim i, ret, j As Short
		Dim length, packsize As Short
		Dim Cnt, k As Short
		Dim DapData1() As Byte
		Dim Data1 As String
		
		On Error GoTo SENDERR99
		
		'Set WinSock0 = FrmMain.Winsock1(Dap_Id)
		
		ReDim DapData1(CCB_LEN + datalen - 1)
		If Len(addr) > 1 Then
			subnode = Val("&H" & Mid(addr, 2))
		End If
		port = CShort(Left(addr, 1))
		Select Case port
			Case CInt("1")
				DapData1(CCB_MTYPE) = &H60
			Case CInt("2")
				DapData1(CCB_MTYPE) = &H61
			Case Else
				DapData1(CCB_MTYPE) = &HFF
		End Select
		
		subcmd = &H60 'special command
		
		DapData1(CCB_DNODE) = 0
		DapData1(CCB_SNODE) = 0
		DapData1(CCB_CTYPE) = 0
		DapData1(CCB_SUBCMD) = subcmd
		DapData1(CCB_SUBNODE) = subnode
		
		packsize = 160
		For i = 1 To datalen Step packsize
			Cnt = datalen - i + 1
			If Cnt > packsize Then Cnt = packsize
			k = CCB_DATA '0
			ret = BinCopy(DapData1, k, Data2DapB, i - 1, Cnt)
			length = CCB_LEN + Cnt
			DapData1(CCB_LEN_H) = length \ &H100
			DapData1(CCB_LEN_L) = length Mod &H100
			
			'UPGRADE_WARNING: 無法解析物件 WinSock0.SendData 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			WinSock0.SendData(DapData1) 'dap1
			SendDapData2 = 1 'ret
		Next i
		Exit Function
		
SENDERR99: 
		MsgBox("Send Error: " & ErrorToString())
		
	End Function
	Function Bin2Str(ByRef bufbin() As Byte, ByRef Start As Short, ByRef Cnt As Object) As String
		Dim i As Short
		Dim bufstr As String
		Dim dataB As Byte
		
		
		'cnt = LenB(bufbin)
		'cnt = 3
		bufstr = ""
		'UPGRADE_WARNING: 無法解析物件 Cnt 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		For i = 0 To Cnt - 1
			'bufstr = bufstr + Chr$(AscB(MidB(bufbin, start + i, 1)))
			dataB = bufbin(Start + i)
			'If dataB = 0 Then dataB = &H20  '&H20=Space --> for show message
			bufstr = bufstr & ChrW(dataB)
		Next i
		
		Bin2Str = bufstr
	End Function
	
	Function unldump(ByRef indata As String, ByRef outdata As String) As Short
		'ldump data format: "xx xx xx xx xx ..."
		Dim tmpstr, retstr As String
		Dim othstr As String
		Dim idx, tmpint, strlen As Short
		
		othstr = indata
		retstr = ""
		strlen = 0
		Do 
			idx = InStr(othstr, " ")
			If idx = 3 Then
				tmpstr = "&H" & Left(othstr, idx - 1)
				If tmpstr = "&H00" Then tmpstr = "&H20"
				retstr = retstr & ChrW(CInt(tmpstr))
				othstr = Mid(othstr, idx + 1)
				strlen = strlen + 1
			Else
				If idx = 0 Then Exit Do
				othstr = Mid(othstr, idx + 1)
			End If
		Loop 
		
		outdata = retstr
		unldump = strlen
		
	End Function
	
	Function BinCopy(ByRef dstbuf() As Byte, ByRef dst_ndx As Short, ByRef srcbuf() As Byte, ByRef src_ndx As Short, ByRef Cnt As Short) As Short
		Dim i As Short
		
		For i = 0 To Cnt - 1
			dstbuf(dst_ndx + i) = srcbuf(src_ndx + i)
		Next i
		
		BinCopy = dst_ndx + Cnt
	End Function
	Function ldump3(ByRef ip_str() As Byte, ByRef Start As Short, ByRef Cnt As Short) As String
		Dim ret, i As Short
		Dim tmpstr, op_str As String
		
		op_str = ""
		For i = 0 To Cnt - 1
			tmpstr = Hex(ip_str(Start + i)) & " "
			If Len(tmpstr) < 3 Then
				tmpstr = "0" & tmpstr
			End If
			op_str = op_str & tmpstr
		Next i
		
		ldump3 = op_str
	End Function
	Function ldump(ByRef ip_str As Object, ByRef op_str As Object) As Short
		Dim Start As Short
		Dim tmpstr As String
		
		'UPGRADE_WARNING: 無法解析物件 op_str 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		op_str = ""
		Start = 1
		Do 
			'UPGRADE_WARNING: 無法解析物件 ip_str 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tmpstr = Mid(ip_str, Start, 1)
			Start = Start + 1
			If tmpstr = "" Then Exit Do
			tmpstr = Hex(Asc(tmpstr)) & " "
			If Len(tmpstr) < 3 Then
				tmpstr = "0" & tmpstr
			End If
			'UPGRADE_WARNING: 無法解析物件 op_str 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			op_str = op_str + tmpstr
		Loop 
		
	End Function
	Function Str2Byte(ByRef OpByte() As Byte, ByRef IpStr As String) As Short
		'ret=len OK, <0 err
		Dim lens, i As Short
		Dim Cnt As Short
		Dim Bytetmp As Byte
		Dim strtmp As String
		
		Cnt = 0
		lens = Len(IpStr)
		If (lens Mod 2) <> 0 Then 'format error
			Str2Byte = -1
			Exit Function
		End If
		For i = 1 To lens
			strtmp = Mid(IpStr, i, 1)
			'UPGRADE_WARNING: Mod 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			Bytetmp = (Val("&H" & strtmp) Mod 256) * &H10 'Hi byte
			i = i + 1
			strtmp = Mid(IpStr, i, 1)
			'UPGRADE_WARNING: Mod 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
			OpByte(Cnt) = CByte("&H" & Hex(Bytetmp + (Val("&H" & strtmp) Mod 256))) 'Lo byte
			Cnt = Cnt + 1
		Next i
		
		Str2Byte = Cnt
		
	End Function
	Function HexIpB(ByRef ip_str As String, ByRef op_str() As Byte, ByRef op_start As Short) As Short
		'translate String to Hex by byte.
		'can setting output start position; ret=byte array tail
		Dim Start, Cnt As Short
		Dim tmpstr As String
		Dim data As Short
		
		Start = 1
		Cnt = 0 + op_start
		Do 
			tmpstr = Mid(ip_str, Start, 1)
			Start = Start + 1
			If tmpstr = "" Then Exit Do
			If tmpstr = "\" Then
				tmpstr = "&H" & Mid(ip_str, Start, 2)
				Start = Start + 2
				op_str(Cnt) = Val(tmpstr)
				Cnt = Cnt + 1
			Else
				data = Asc(tmpstr)
				op_str(Cnt) = data Mod 256
				Cnt = Cnt + 1
				If data >= 256 Then
					op_str(Cnt) = data / 256
					Cnt = Cnt + 1
				End If
			End If
		Loop 
		HexIpB = Cnt
		
	End Function
End Module