Option Strict Off
Option Explicit On
Module HexIp
	Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Integer) '延遲1/1000秒
	
	
	Public Function GetToken2(ByRef Buf As String, ByRef Delimit As Short, ByVal Position As Short) As String
		Dim Delimit_Start As Short
		Dim Delimit_End As Short
		
		On Error GoTo GetToken2_Error
		
		GetToken2 = ""
		Delimit_Start = 0
		Delimit_End = 0
		
		While Position > 0
			Delimit_Start = Delimit_End
			Delimit_End = InStr(Delimit_End + 1, Buf, Chr(Delimit))
			Position = Position - 1
		End While
		
		If Delimit_Start = 0 And Delimit_End = 0 Then Exit Function
		'UPGRADE_ISSUE: 不支援 LenB 函式。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="367764E5-F3F8-4E43-AC3E-7FE0B5E074E2"'
        If Delimit_End = 0 Then Delimit_End = System.Text.Encoding.Default.GetByteCount(Buf) + 1
        'If Delimit_End = 0 Then Delimit_End = LenB(Buf) + 1
		GetToken2 = Mid(Buf, Delimit_Start + 1, Delimit_End - Delimit_Start - 1)
		Exit Function
		
GetToken2_Error: 
		GetToken2 = ""
	End Function
	
	
	Sub sleep_doevents(ByRef i As Integer)
		While i > 0
			System.Windows.Forms.Application.DoEvents()
			i = i - 1
		End While
	End Sub
	
	Sub LogFile2(ByRef data As Object)
		Dim fname As String
		
        fname = My.Computer.FileSystem.CurrentDirectory & "\" & VB6.Format(Today, "YYYYMMDD") & ".TXT"
		LogFile(fname, data)
	End Sub
	
	Sub LogFile(ByRef fname As String, ByRef data As Object)
		Dim fnum As Object
		Dim flen As Integer
		Dim i, cnt, j As Short
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
		cnt = Len(data)
		j = 1
		For i = 1 To cnt
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
	
	Function AB_ErrMsg(ByRef ret As Short) As String
		Dim tmpstr As String
		
		Select Case ret
			Case -3
				tmpstr = "Parameter data is error !"
			Case -2
				tmpstr = "TCP is not created yet !"
			Case -1
				tmpstr = "DAP_ID out of range !"
			Case 0
				tmpstr = "Closed"
			Case 1
				tmpstr = "Open"
			Case 2
				tmpstr = "Listening"
			Case 3
				tmpstr = "Connection is Pending"
			Case 4
				tmpstr = "Resolving the host name"
			Case 5
				tmpstr = "Host is Resolved"
			Case 6
				tmpstr = "Waiting to Connect"
			Case 7
				tmpstr = "Connected ok "
			Case 8
				tmpstr = "Connection is closing"
			Case 9
				tmpstr = "State error has occurred"
			Case 10
				tmpstr = "Connection state is undetermined"
			Case Else
				tmpstr = "Unknown Error Code"
		End Select
		
		AB_ErrMsg = tmpstr
	End Function
	
	Sub MsgBox2(ByRef msg As String)
        Dim lst As Object
        Dim tmpstr As String

        lst = frmtcp.lstMsg
        tmpstr = TimeString & " " & msg

        'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If frmtcp.lstMsg.Items.Count >= 100 Then

            'UPGRADE_WARNING: 無法解析物件 lst.RemoveItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'lst.RemoveItem(0)
            frmtcp.lstMsg.Items.Remove(0)
        End If
        'UPGRADE_WARNING: 無法解析物件 lst.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmtcp.lstMsg.Items.Add(tmpstr)
        'UPGRADE_WARNING: 無法解析物件 lst.ListIndex 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmtcp.lstMsg.SelectedIndex = frmtcp.lstMsg.Items.Count - 1
        'lst.ListIndex = lst.ListCount - 1

        LogFile2(tmpstr & Chr(13) & Chr(10))
	End Sub
	
	Sub MsgBoxT1(ByRef msg As String)
        Dim lst As Object
        Dim TimeStr As String

        ' Modyfied by Nash
        ' Set lst = frmtcp.lstMsgT
        lst = frmtcp.lstMsgT1
        'timestr = Time$

        'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If frmtcp.lstMsgT1.Items.Count >= 100 Then
            'UPGRADE_WARNING: 無法解析物件 lst.RemoveItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            frmtcp.lstMsgT1.Items.Remove(0)
        End If
        'lst.AddItem timestr & " " & msg
        'UPGRADE_WARNING: 無法解析物件 lst.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmtcp.lstMsgT1.Items.Add(msg)
        'UPGRADE_WARNING: 無法解析物件 lst.ListIndex 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmtcp.lstMsgT1.SelectedIndex = frmtcp.lstMsgT1.Items.Count - 1
        'lst.ListIndex = frmtcp.lstMsgT1.Items.Count - 1
	End Sub
	
	' Add by Nash
	Sub MsgBoxT2(ByRef msg As String)
        Dim lst As Object
        Dim TimeStr As String

        lst = frmtcp.lstMsgT2
        'timestr = Time$

        'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If frmtcp.lstMsgT2.Items.Count >= 100 Then
            'UPGRADE_WARNING: 無法解析物件 lst.RemoveItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            frmtcp.lstMsgT2.Items.Remove(0)
        End If
        'lst.AddItem timestr & " " & msg
        'UPGRADE_WARNING: 無法解析物件 lst.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        frmtcp.lstMsgT2.Items.Add(msg)
        'UPGRADE_WARNING: 無法解析物件 lst.ListIndex 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: 無法解析物件 lst.ListCount 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'lst.ListIndex = lst.ListCount - 1
        frmtcp.lstMsgT2.SelectedIndex = frmtcp.lstMsgT2.Items.Count - 1
	End Sub
	
	' Add by Nash
	Sub MsgBoxT3(ByRef msg As String)
		''''    Dim lst As Object
		''''    Dim timestr As String
		''''
		''''    Set lst = frmtcp.lstMsgT3
		''''    'timestr = Time$
		''''
		''''    If lst.ListCount >= 100 Then
		''''        lst.RemoveItem 0
		''''    End If
		''''    'lst.AddItem timestr & " " & msg
		''''    lst.AddItem msg
		''''    lst.ListIndex = lst.ListCount - 1
	End Sub
	
	Sub MsgBoxT4(ByRef msg As String)
		'''    Dim lst As Object
		'''    Dim timestr As String
		'''
		'''    Set lst = frmtcp.lstMsgT4
		'''    'timestr = Time$
		'''
		'''    If lst.ListCount >= 100 Then
		'''        lst.RemoveItem 0
		'''    End If
		'''    'lst.AddItem timestr & " " & msg
		'''    lst.AddItem msg
		'''    lst.ListIndex = lst.ListCount - 1
	End Sub
	
	Sub MsgBoxT5(ByRef msg As String)
		'    Dim lst As Object
		'    Dim timestr As String
		'
		'    Set lst = frmtcp.lstMsgT5
		'    'timestr = Time$
		'
		'    If lst.ListCount >= 100 Then
		'        lst.RemoveItem 0
		'    End If
		'    'lst.AddItem timestr & " " & msg
		'    lst.AddItem msg
		'    lst.ListIndex = lst.ListCount - 1
	End Sub
	Sub MsgBoxT6(ByRef msg As String)
		'    Dim lst As Object
		'    Dim timestr As String
		'
		'    Set lst = frmtcp.lstMsgT6
		'    'timestr = Time$
		'
		'    If lst.ListCount >= 100 Then
		'        lst.RemoveItem 0
		'    End If
		'    'lst.AddItem timestr & " " & msg
		'    lst.AddItem msg
		'    lst.ListIndex = lst.ListCount - 1
	End Sub
	
	Function HexIp0(ByRef ip_str As String, ByRef op_str As String) As Short
		Dim start, cnt As Short
		Dim tmpstr As String
		
		op_str = ""
		start = 1
		cnt = 0
		Do 
			tmpstr = Mid(ip_str, start, 1)
			start = start + 1
			If tmpstr = "" Then Exit Do
			If tmpstr = "\" Then
				tmpstr = "&H"
				tmpstr = tmpstr & Mid(ip_str, start, 2)
				start = start + 2
				tmpstr = ChrW(Val(tmpstr))
			End If
			op_str = op_str & tmpstr
			cnt = cnt + 1
		Loop 
		HexIp0 = cnt
	End Function
	
	Function HexIpB(ByRef ip_str As String, ByRef op_str() As Byte, ByRef op_start As Short) As Short
		Dim start, cnt As Short
		Dim tmpstr As String
		Dim data As Short
		Dim data2 As Integer
		
		start = 1
		cnt = 0 + op_start
		Do 
			tmpstr = Mid(ip_str, start, 1)
			start = start + 1
			If tmpstr = "" Then Exit Do
			If tmpstr = "\" Then
				tmpstr = "&H" & Mid(ip_str, start, 2)
				start = start + 2
				op_str(cnt) = Val(tmpstr)
				cnt = cnt + 1
			Else
				data2 = Asc(tmpstr)
				If data2 < 0 Then data2 = data2 + 65536
				If data2 < 256 Then
					op_str(cnt) = (data2 Mod 256) And &HFF
					cnt = cnt + 1
				Else
					op_str(cnt) = (data2 \ 256) And &HFF
					cnt = cnt + 1
					op_str(cnt) = (data2 Mod 256) And &HFF
					cnt = cnt + 1
				End If
			End If
		Loop 
		HexIpB = cnt
		
	End Function
	
	Function HexOp0(ByRef ip_str As Object, ByRef cnt As Short, ByRef op_str As String) As Short
		Dim start As Short
		Dim tmpstr As String
		Dim ch As Short
		
		op_str = ""
		For start = 1 To cnt
			'UPGRADE_WARNING: 無法解析物件 ip_str 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ch = AscW(Mid(ip_str, start, 1))
			'If ch = 0 Or ch = &H5C Or ch > &H80 Then
			If ch < &H20 Or ch = &H5C Or ch >= &H80 Then
				tmpstr = Hex(ch)
				If Len(tmpstr) < 2 Then
					op_str = op_str & "\0" & tmpstr
				Else
					op_str = op_str & "\" & tmpstr
				End If
			Else
				op_str = op_str & ChrW(ch)
			End If
		Next start
	End Function
	
	Function HexOp2(ByRef ip_str As Object, ByRef cnt As Short) As String
		Dim ret As Short
		Dim op_str As String
		
		If cnt < 0 Then cnt = Len(ip_str)
		
		ret = HexOp0(ip_str, cnt, op_str)
		HexOp2 = op_str
	End Function
	
	Function HexOp3(ByRef ip_str As Object, ByRef start0 As Short, ByRef cnt As Short) As String
		Dim start As Short
		Dim tmpstr As String
		Dim ch As Short
		
		tmpstr = ""
		For start = 1 To cnt
			'UPGRADE_WARNING: 無法解析物件 ip_str() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ch = ip_str(start0 + start - 1)
			tmpstr = tmpstr & ChrW(ch)
		Next start
		HexOp3 = tmpstr
	End Function
	
	Function HexOp31(ByRef ip_str As Object, ByRef start0 As Short, ByRef cnt As Short) As String
		Dim start As Short
		Dim tmpstr As String
		Dim ch As Short
		
		tmpstr = ""
		For start = 1 To cnt
			'UPGRADE_WARNING: 無法解析物件 ip_str() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			ch = ip_str(start0 + start - 1)
			If ch = 0 Then Exit For
			tmpstr = tmpstr & ChrW(ch)
		Next start
		HexOp31 = tmpstr
	End Function
	
	Function ldump(ByRef ip_str As Object, ByRef op_str As Object) As Short
		Dim start As Short
		Dim tmpstr As String
		
		'UPGRADE_WARNING: 無法解析物件 op_str 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		op_str = ""
		start = 1
		Do 
			'UPGRADE_WARNING: 無法解析物件 ip_str 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tmpstr = Mid(ip_str, start, 1)
			start = start + 1
			If tmpstr = "" Then Exit Do
			tmpstr = Hex(AscW(tmpstr)) & " "
			If Len(tmpstr) < 3 Then
				tmpstr = "0" & tmpstr
			End If
			'UPGRADE_WARNING: 無法解析物件 op_str 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			op_str = op_str + tmpstr
		Loop 
		
	End Function
	
	Function ldump2(ByRef ip_str As String, ByRef cnt As Short) As String
		Dim ret, start As Short
		Dim tmpstr, op_str As String
		
		op_str = ""
		If cnt < 0 Then cnt = Len(ip_str)
		start = 1
		Do 
			tmpstr = Mid(ip_str, start, 1)
			start = start + 1
			If tmpstr = "" Then Exit Do
			tmpstr = Hex(AscW(tmpstr)) & " "
			If Len(tmpstr) < 3 Then
				tmpstr = "0" & tmpstr
			End If
			op_str = op_str & tmpstr
			
			If start > cnt Then Exit Do
		Loop 
		
		ldump2 = op_str
	End Function
	
	Function ldump3(ByRef ip_str() As Byte, ByRef start As Short, ByRef cnt As Short) As String
		Dim ret, i As Short
		Dim tmpstr, op_str As String
		
		op_str = ""
		For i = 0 To cnt - 1
			tmpstr = Hex(ip_str(start + i)) & " "
			If Len(tmpstr) < 3 Then
				tmpstr = "0" & tmpstr
			End If
			op_str = op_str & tmpstr
		Next i
		
		ldump3 = op_str
	End Function
	
	Function ldump4(ByRef ip_str As Object, ByRef start As Short, ByRef cnt As Short) As String
		Dim ret, i As Short
		Dim tmpstr, op_str As String
		
		op_str = ""
		For i = 0 To cnt - 1
			'UPGRADE_WARNING: 無法解析物件 ip_str() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tmpstr = Hex(ip_str(start + i)) & " "
			If Len(tmpstr) < 3 Then
				tmpstr = "0" & tmpstr
			End If
			op_str = op_str & tmpstr
		Next i
		
		ldump4 = op_str
	End Function
	
	Function ldump41(ByRef ip_str As Object, ByRef start As Short, ByRef cnt As Short) As String
		Dim ret, i As Short
		Dim tmpstr, op_str As String
		
		op_str = ""
		For i = 0 To cnt - 1
			'UPGRADE_WARNING: 無法解析物件 ip_str() 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tmpstr = Hex(ip_str(start + i))
            If tmpstr.Length < 2 Then
                tmpstr = "0" & tmpstr
            End If
			op_str = op_str & tmpstr
		Next i
		
		ldump41 = op_str
	End Function
	
	Function str2hex(ByRef tmpstr As Object) As String
		Dim cnt, i As Short
		Dim tmpstr2 As String
		
		cnt = Len(tmpstr)
		tmpstr2 = ""
		For i = 1 To cnt
			'UPGRADE_WARNING: 無法解析物件 tmpstr 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
			tmpstr2 = tmpstr2 & Hex(AscW(Mid(tmpstr, i, 1))) & " "
		Next i
		str2hex = tmpstr2
		
	End Function
	
	Function str2buf(ByRef tmpstr As String, ByRef op_buf() As Byte, ByRef start As Short) As Short
		Dim cnt, i As Short
		
		cnt = Len(tmpstr)
		For i = 1 To cnt
			op_buf(start + i - 1) = Asc(Mid(tmpstr, i, 1))
		Next i
		str2buf = cnt
	End Function
	
	Function GetCRC(ByRef ip_buf() As Byte, ByRef start As Short, ByRef cnt As Short) As Short
		Dim sum As Integer
		Dim i As Short
		
		For i = 1 To cnt
			sum = sum + ip_buf(start + i - 1)
		Next i
		sum = Not sum
		GetCRC = sum And &HFF
	End Function
	
    Function LstReadFile(ByRef lstCtrl As System.Windows.Forms.ListBox, ByRef fname As String, ByRef line_srt As Short, ByRef line_end As Short) As Object
        Dim fnum As Short ' ret = line count
        Dim line_no As Short
        Dim max_cnt As Short
        Dim Buf As String

        On Error GoTo err1

        line_no = 1
        max_cnt = 1000
        If line_end = 0 Then '0: default max_cnt
            line_end = max_cnt
        End If

        fnum = FreeFile()
        FileOpen(fnum, fname, OpenMode.Input, OpenAccess.Read, OpenShare.Shared)

        Do While Not EOF(fnum)
            If line_no >= line_srt Then
                Exit Do
            End If
            Buf = LineInput(fnum)
            line_no = line_no + 1
        Loop

        Do While Not EOF(fnum)
            Buf = LineInput(fnum)
            'UPGRADE_WARNING: 無法解析物件 lstCtrl.AddItem 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            lstCtrl.Items.Add(Buf)
            'lstCtrl.Text = lstCtrl.Text + buf + Chr$(13) + Chr$(10)
            If line_no >= line_end Or line_no - line_srt >= max_cnt - 1 Then
                Exit Do
            End If
            line_no = line_no + 1
        Loop

        FileClose(fnum)
        'UPGRADE_WARNING: 無法解析物件 LstReadFile 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        LstReadFile = line_no - line_srt + 1
        Exit Function

err1:
        MsgBox2("Error Code=" & Str(Err.Number) & Chr(13) & "Error Msg=" & ErrorToString())
        'UPGRADE_WARNING: 無法解析物件 LstReadFile 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        LstReadFile = 0
        Exit Function
    End Function
	
	Function GetToken(ByRef src As String, ByRef remain As String, ByRef deli As String) As String
		Dim i, j As Short
		Dim all As Short
		
		j = 1
		Do While Mid(src, j, 1) = deli
			j = j + 1
		Loop 
		
#If 1 Then
		'---Match "^" in string: &lbl[lasti]
		i = InStr(j, src, deli)
		If i = 0 Then '---No match, the last one
			GetToken = Mid(src, j)
			remain = ""
		Else
			GetToken = Mid(src, j, i - j)
			remain = Mid(src, i + 1)
		End If
#Else
		'UPGRADE_NOTE: #If #EndIf 區塊沒有升級，因為運算式 Else 評估不為 True 或尚未評估。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="27EE2C3C-05AF-4C04-B2AF-657B4FB6B5FC"'
		'---Match "^" in string: &lbl[lasti]
		i = InStr(1, src, deli)
		If i = 0 Then       '---No match, the last one
		GetToken = src
		remain = ""
		Else
		GetToken = Mid(src, 1, i - 1)
		remain = Mid(src, i + 1)
		End If
#End If
	End Function
End Module