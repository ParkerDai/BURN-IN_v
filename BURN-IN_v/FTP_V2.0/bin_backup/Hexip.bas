Attribute VB_Name = "HexIp"
Declare Sub Sleep Lib "kernel32" (ByVal dwMilliseconds As Long) '©µ¿ð1/1000¬í

Option Explicit

Public Function GetToken2(Buf As String, Delimit As Integer, ByVal Position As Integer) As String
    Dim Delimit_Start As Integer
    Dim Delimit_End As Integer
    
    On Error GoTo GetToken2_Error
    
    GetToken2 = ""
    Delimit_Start = 0
    Delimit_End = 0
    
    While Position > 0
        Delimit_Start = Delimit_End
        Delimit_End = InStr(Delimit_End + 1, Buf, Chr(Delimit))
        Position = Position - 1
    Wend
    
    If Delimit_Start = 0 And Delimit_End = 0 Then Exit Function
    If Delimit_End = 0 Then Delimit_End = LenB(Buf) + 1
    GetToken2 = Mid(Buf, Delimit_Start + 1, Delimit_End - Delimit_Start - 1)
    Exit Function
    
GetToken2_Error:
    GetToken2 = ""
End Function


Sub sleep_doevents(i As Long)
    While i > 0
        DoEvents
        i = i - 1
    Wend
End Sub

Sub LogFile2(data As Variant)
    Dim fname As String
    
    fname = App.Path & "\" & Format(Date, "YYYYMMDD") & ".TXT"
    LogFile fname, data
End Sub

Sub LogFile(fname As String, data As Variant)
    Dim fnum
    Dim flen As Long
    Dim cnt As Integer, i As Integer, j As Integer
    Dim ch As Byte
    Dim data2 As Long
    
    On Error GoTo LogFile99
    
    If Dir(fname) = "" Then
        flen = 0
    Else
        flen = FileLen(fname)
    End If
    
    fnum = FreeFile
    Open fname For Binary As #fnum
    cnt = Len(data)
    j = 1
    For i = 1 To cnt
#If 0 Then
        ch = AscW(Mid(data, i, 1)) 'And &HFF
        Put #fnum, flen + i, ch
#Else
        data2 = Asc(Mid(data, i, 1))
        If data2 < 0 Then data2 = data2 + 65536
        If data2 < 256 Then
            ch = (data2 Mod 256) And &HFF
            Put #fnum, flen + j, ch
            j = j + 1
        Else
            ch = (data2 \ 256) And &HFF
            Put #fnum, flen + j, ch
            j = j + 1
            ch = (data2 Mod 256) And &HFF
            Put #fnum, flen + j, ch
            j = j + 1
        End If
#End If
    Next i
    Close #fnum
    Exit Sub
    
LogFile99:
    MsgBox "LogFile err=" & Error & ", filename=" & fname
    Exit Sub
    Resume
End Sub

Function AB_ErrMsg(ret As Integer) As String
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

Sub MsgBox2(msg As String)
    Dim lst As Object
    Dim tmpstr As String

    Set lst = frmtcp.lstMsg
    tmpstr = Time$ & " " & msg

    If lst.ListCount >= 100 Then
        lst.RemoveItem 0
    End If
    lst.AddItem tmpstr
    lst.ListIndex = lst.ListCount - 1

    LogFile2 tmpstr + Chr(13) + Chr(10)
End Sub

Sub MsgBoxT1(msg As String)
    Dim lst As Object
    Dim timestr As String

    ' Modyfied by Nash
    ' Set lst = frmtcp.lstMsgT
    Set lst = frmtcp.lstMsgT1
    'timestr = Time$

    If lst.ListCount >= 100 Then
        lst.RemoveItem 0
    End If
    'lst.AddItem timestr & " " & msg
    lst.AddItem msg
    lst.ListIndex = lst.ListCount - 1
End Sub

' Add by Nash
Sub MsgBoxT2(msg As String)
    Dim lst As Object
    Dim timestr As String
 
    Set lst = frmtcp.lstMsgT2
    'timestr = Time$

    If lst.ListCount >= 100 Then
        lst.RemoveItem 0
    End If
    'lst.AddItem timestr & " " & msg
    lst.AddItem msg
    lst.ListIndex = lst.ListCount - 1
End Sub

' Add by Nash
Sub MsgBoxT3(msg As String)
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

Sub MsgBoxT4(msg As String)
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

Sub MsgBoxT5(msg As String)
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
Sub MsgBoxT6(msg As String)
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

Function HexIp0(ip_str As String, op_str As String) As Integer
    Dim start As Integer, cnt As Integer
    Dim tmpstr As String

    op_str = ""
    start = 1
    cnt = 0
    Do
        tmpstr = Mid$(ip_str, start, 1)
        start = start + 1
        If tmpstr = "" Then Exit Do
        If tmpstr = "\" Then
            tmpstr = "&H"
            tmpstr = tmpstr + Mid$(ip_str, start, 2)
            start = start + 2
            tmpstr = ChrW(Val(tmpstr))
        End If
        op_str = op_str + tmpstr
        cnt = cnt + 1
    Loop
    HexIp0 = cnt
End Function

Function HexIpB(ip_str As String, op_str() As Byte, op_start As Integer) As Integer
    Dim start As Integer, cnt As Integer
    Dim tmpstr As String
    Dim data As Integer
    Dim data2 As Long
    
    start = 1
    cnt = 0 + op_start
    Do
        tmpstr = Mid$(ip_str, start, 1)
        start = start + 1
        If tmpstr = "" Then Exit Do
        If tmpstr = "\" Then
            tmpstr = "&H" & Mid$(ip_str, start, 2)
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

Function HexOp0(ip_str As Variant, cnt As Integer, op_str As String) As Integer
    Dim start As Integer
    Dim tmpstr As String
    Dim ch As Integer

    op_str = ""
    For start = 1 To cnt
        ch = AscW(Mid(ip_str, start, 1))
       'If ch = 0 Or ch = &H5C Or ch > &H80 Then
        If ch < &H20 Or ch = &H5C Or ch >= &H80 Then
            tmpstr = Hex(ch)
            If Len(tmpstr) < 2 Then
                op_str = op_str + "\0" + tmpstr
            Else
                op_str = op_str + "\" + tmpstr
            End If
        Else
            op_str = op_str + ChrW(ch)
        End If
    Next start
End Function

Function HexOp2(ip_str As Variant, cnt As Integer) As String
    Dim ret As Integer
    Dim op_str As String

    If cnt < 0 Then cnt = Len(ip_str)

    ret = HexOp0(ip_str, cnt, op_str)
    HexOp2 = op_str
End Function

Function HexOp3(ip_str As Variant, start0 As Integer, cnt As Integer) As String
    Dim start As Integer
    Dim tmpstr As String
    Dim ch As Integer

    tmpstr = ""
    For start = 1 To cnt
        ch = ip_str(start0 + start - 1)
        tmpstr = tmpstr + ChrW(ch)
    Next start
    HexOp3 = tmpstr
End Function

Function HexOp31(ip_str As Variant, start0 As Integer, cnt As Integer) As String
    Dim start As Integer
    Dim tmpstr As String
    Dim ch As Integer

    tmpstr = ""
    For start = 1 To cnt
        ch = ip_str(start0 + start - 1)
        If ch = 0 Then Exit For
        tmpstr = tmpstr + ChrW(ch)
    Next start
    HexOp31 = tmpstr
End Function

Function ldump(ip_str, op_str) As Integer
    Dim start As Integer
    Dim tmpstr As String

    op_str = ""
    start = 1
    Do
        tmpstr = Mid$(ip_str, start, 1)
        start = start + 1
        If tmpstr = "" Then Exit Do
        tmpstr = Hex$(AscW(tmpstr)) + " "
        If Len(tmpstr) < 3 Then
            tmpstr = "0" & tmpstr
        End If
        op_str = op_str + tmpstr
    Loop

End Function

Function ldump2(ip_str As String, cnt As Integer) As String
    Dim ret As Integer, start As Integer
    Dim tmpstr As String, op_str As String

    op_str = ""
    If cnt < 0 Then cnt = Len(ip_str)
    start = 1
    Do
        tmpstr = Mid$(ip_str, start, 1)
        start = start + 1
        If tmpstr = "" Then Exit Do
        tmpstr = Hex$(AscW(tmpstr)) + " "
        If Len(tmpstr) < 3 Then
            tmpstr = "0" & tmpstr
        End If
        op_str = op_str + tmpstr

        If start > cnt Then Exit Do
    Loop

    ldump2 = op_str
End Function

Function ldump3(ip_str() As Byte, start As Integer, cnt As Integer) As String
    Dim ret As Integer, i As Integer
    Dim tmpstr As String, op_str As String

    op_str = ""
    For i = 0 To cnt - 1
        tmpstr = Hex$(ip_str(start + i)) + " "
        If Len(tmpstr) < 3 Then
            tmpstr = "0" & tmpstr
        End If
        op_str = op_str + tmpstr
    Next i

    ldump3 = op_str
End Function

Function ldump4(ip_str As Variant, start As Integer, cnt As Integer) As String
    Dim ret As Integer, i As Integer
    Dim tmpstr As String, op_str As String

    op_str = ""
    For i = 0 To cnt - 1
        tmpstr = Hex$(ip_str(start + i)) + " "
        If Len(tmpstr) < 3 Then
            tmpstr = "0" & tmpstr
        End If
        op_str = op_str + tmpstr
    Next i

    ldump4 = op_str
End Function

Function ldump41(ip_str As Variant, start As Integer, cnt As Integer) As String
    Dim ret As Integer, i As Integer
    Dim tmpstr As String, op_str As String

    op_str = ""
    For i = 0 To cnt - 1
        tmpstr = Hex$(ip_str(start + i))
        If Len(tmpstr) < 2 Then
            tmpstr = "0" & tmpstr
        End If
        op_str = op_str + tmpstr
    Next i

    ldump41 = op_str
End Function

Function str2hex(tmpstr) As String
    Dim cnt As Integer, i As Integer
    Dim tmpstr2 As String

    cnt = Len(tmpstr)
    tmpstr2 = ""
    For i = 1 To cnt
        tmpstr2 = tmpstr2 + Hex(AscW(Mid(tmpstr, i, 1))) + " "
    Next i
    str2hex = tmpstr2

End Function

Function str2buf(tmpstr As String, op_buf() As Byte, start As Integer) As Integer
    Dim cnt As Integer, i As Integer

    cnt = Len(tmpstr)
    For i = 1 To cnt
        op_buf(start + i - 1) = Asc(Mid(tmpstr, i, 1))
    Next i
    str2buf = cnt
End Function

Function GetCRC(ip_buf() As Byte, start As Integer, cnt As Integer) As Integer
    Dim sum As Long, i As Integer

    For i = 1 To cnt
        sum = sum + ip_buf(start + i - 1)
    Next i
    sum = Not sum
    GetCRC = sum And &HFF
End Function

Function LstReadFile(lstCtrl As Control, fname As String, line_srt As Integer, line_end As Integer)
    Dim fnum As Integer                 ' ret = line count
    Dim line_no As Integer
    Dim max_cnt As Integer
    Dim Buf As String

    On Error GoTo err1

    line_no = 1
    max_cnt = 1000
    If line_end = 0 Then        '0: default max_cnt
        line_end = max_cnt
    End If

    fnum = FreeFile
    Open fname For Input Access Read Shared As fnum

    Do While Not EOF(fnum)
        If line_no >= line_srt Then
            Exit Do
        End If
        Line Input #fnum, Buf
        line_no = line_no + 1
    Loop

    Do While Not EOF(fnum)
        Line Input #fnum, Buf
        lstCtrl.AddItem Buf
        'lstCtrl.Text = lstCtrl.Text + buf + Chr$(13) + Chr$(10)
        If line_no >= line_end Or line_no - line_srt >= max_cnt - 1 Then
            Exit Do
        End If
        line_no = line_no + 1
    Loop

    Close #fnum
    LstReadFile = line_no - line_srt + 1
    Exit Function

err1:
    MsgBox2 "Error Code=" & Str(Err) & Chr$(13) & "Error Msg=" & Error
    LstReadFile = 0
    Exit Function
End Function

Function GetToken(src As String, remain As String, deli As String) As String
    Dim i As Integer, j As Integer
    Dim all As Integer

    j = 1
    Do While Mid(src, j, 1) = deli
        j = j + 1
    Loop

#If 1 Then
            '---Match "^" in string: &lbl[lasti]
    i = InStr(j, src, deli)
    If i = 0 Then       '---No match, the last one
        GetToken = Mid(src, j)
        remain = ""
    Else
        GetToken = Mid(src, j, i - j)
        remain = Mid(src, i + 1)
    End If
#Else
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

