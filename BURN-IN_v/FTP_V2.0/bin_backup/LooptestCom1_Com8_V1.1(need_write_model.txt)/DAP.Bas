Attribute VB_Name = "DAP"
Option Explicit

Public Const CCB_LEN = 8

Public Const CCB_LEN_L = 0
Public Const CCB_LEN_H = 1
Public Const CCB_MTYPE = 2
Public Const CCB_DNODE = 3
Public Const CCB_SNODE = 4
Public Const CCB_CTYPE = 5
Public Const CCB_SUBCMD = 6
Public Const CCB_SUBNODE = 7
Public Const CCB_DATA = 8


Function File2List(FName As String, ListName As Control) As Integer
    Dim fno As Integer
    Dim tmpstr As String
    
    On Error GoTo FILE2LIST99
    
    ListName.Clear
    
    fno = FreeFile
    Open FName For Input As #fno
    Do While Not EOF(fno)
        Input #fno, tmpstr
        ListName.AddItem tmpstr
    Loop
    Close #fno
    File2List = ListName.ListCount
    
    Exit Function
    
FILE2LIST99:
    MsgBox Error
    
End Function

Function GetDapData(WinSock As Control, addr As String, subcmd As Integer, DapData As String) As Integer
            'ret>0 : addr=DAP's port(1/2)+ABLELINK Device's subnode(00..FF)
            '        subcmd=ABLELINK Device's subcmd, DapData=data
            'ret<0 : no data
   ' Dim WinSock As Control
    Dim subnode As Integer, port As Integer
    Dim datalen As Integer, ret As Long
    'Dim dap1 As DAP
    Dim DapData1() As Byte
       
   ' Set WinSock = FrmMain.Winsock1(Dap_Id)
    
    'ret = AB_GW_RcvMsg(Dap_id, dap1)
    ret = WinSock.BytesReceived
    If ret < 1 Then            'No Data
        GetDapData = -1
        Exit Function
    End If
    ReDim DapData1(ret)
    WinSock.GetData DapData1 'dap1
    subnode = DapData1(CCB_SUBNODE)
    subcmd = DapData1(CCB_SUBCMD)
    port = DapData1(CCB_MTYPE)
    datalen = DapData1(CCB_LEN_H) * &H100 + DapData1(CCB_LEN_L) - CCB_LEN
    addr = Trim(str(port - &H60 + 1)) & Right("00" & Trim(Hex(subnode)), 2)
        'MsgBox ldump3(qway_rcv.ccbdata(), 0, qway_rcv.ccblen - 6)
        'ret = BinCopy(qwaydata(), 0, dap1.ccbdata(), 0, dap1.ccblen - CCB_LEN)
    DapData = Bin2Str(DapData1(), CCB_DATA, datalen)
    GetDapData = datalen

End Function
Function SendDapData(WinSock0 As Control, addr As String, subcmd As Integer, Data2DapB() As Byte, datalen As Integer) As Integer
                    'addr=DAP's port(1/2)+ABLELINK Device's subnode(00..FF)
                    'subcmd=ABLELINK Device's subcmd
    'Dim WinSock0 As Control
    Dim port As Integer, subnode As Integer
    Dim ret As Integer, i As Integer, j As Integer
    Dim length As Integer, packsize As Integer
    'Dim dap1 As DAP
    Dim Cnt As Integer, k As Integer
    Dim DapData1() As Byte
    Dim Data1 As String
    
    On Error GoTo SENDERR99
    
    'Set WinSock0 = FrmMain.Winsock1(Dap_Id)
    
    ReDim DapData1(CCB_LEN + datalen - 1)
    If Len(addr) > 1 Then
        subnode = Val("&H" & Mid(addr, 2))
    End If
    port = Left(addr, 1)
    Select Case port
    Case "1"
        DapData1(CCB_MTYPE) = &H60
    Case "2"
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
        k = CCB_DATA        '0
        ret = BinCopy(DapData1(), k, Data2DapB(), i - 1, Cnt)
        length = CCB_LEN + Cnt
        DapData1(CCB_LEN_H) = length \ &H100
        DapData1(CCB_LEN_L) = length Mod &H100
        
        'ret = AB_GW_SndMsg(Dap_id, dap1)
        WinSock0.SendData DapData1    'dap1
        'WinSock0.send data1    'dap1
        SendDapData = 1     'ret
        'If Send2Dap <> 0 Then
        '    Exit For
        'End If
    Next i
    Exit Function
    
SENDERR99:
    MsgBox "Send Error: " & Error
    
End Function

Function SendDapData0(WinSock0 As Control, addr As String, Data2DapB() As Byte, datalen As Integer) As Integer
                    'addr=DAP's port(1/2)+ABLELINK Device's subnode(00..FF)
                    'subcmd=ABLELINK Device's subcmd
    'Dim WinSock0 As Control
    Dim port As Integer, subnode As Integer, subcmd As Integer
    Dim ret As Integer, i As Integer, j As Integer
    Dim length As Integer, packsize As Integer
    'Dim dap1 As DAP
    Dim Cnt As Integer, k As Integer, DataHead As Integer
    Dim DapData1() As Byte
    Dim Data1 As String
    
    On Error GoTo SENDERR99
    
    'Set WinSock0 = FrmMain.Winsock1(Dap_Id)
    
    ReDim DapData1(CCB_LEN + datalen - 2 - 1)
    'If Len(addr) > 1 Then
        'subnode = Val("&H" & Mid(addr, 2))
    'End If
    port = Left(addr, 1)
    Select Case port
    Case "1"
        DapData1(CCB_MTYPE) = &H60
    Case "2"
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
    If DataHead > datalen Then  'No data only subCommand
        length = CCB_LEN - 2 + DataHead - 1
        DapData1(CCB_LEN_H) = length \ &H100
        DapData1(CCB_LEN_L) = length Mod &H100
        WinSock0.SendData DapData1    'dap1
        SendDapData0 = 1     'ret
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
        k = CCB_DATA        '0
        ret = BinCopy(DapData1(), k, Data2DapB(), i - 1, Cnt)
        length = CCB_LEN + Cnt
        DapData1(CCB_LEN_H) = length \ &H100
        DapData1(CCB_LEN_L) = length Mod &H100
        
        'ret = AB_GW_SndMsg(Dap_id, dap1)
        WinSock0.SendData DapData1    'dap1
        'WinSock0.send data1    'dap1
        SendDapData0 = 1     'ret
        'If Send2Dap <> 0 Then
        '    Exit For
        'End If
    Next i
    Exit Function
    Resume
    
SENDERR99:
    MsgBox "Send Error: " & Error
    
End Function

Function SendDapData2(WinSock0 As Control, addr As String, Data2DapB() As Byte, datalen As Integer) As Integer
                    'SubCmd=0x60
                    'addr=DAP's port(1/2)+ABLELINK Device's subnode(00..FF)
                    'subcmd=ABLELINK Device's subcmd
    'Dim WinSock0 As Control
    Dim port As Integer, subnode As Integer, subcmd As Integer
    Dim ret As Integer, i As Integer, j As Integer
    Dim length As Integer, packsize As Integer
    Dim Cnt As Integer, k As Integer
    Dim DapData1() As Byte
    Dim Data1 As String
    
    On Error GoTo SENDERR99
    
    'Set WinSock0 = FrmMain.Winsock1(Dap_Id)
    
    ReDim DapData1(CCB_LEN + datalen - 1)
    If Len(addr) > 1 Then
        subnode = Val("&H" & Mid(addr, 2))
    End If
    port = Left(addr, 1)
    Select Case port
    Case "1"
        DapData1(CCB_MTYPE) = &H60
    Case "2"
        DapData1(CCB_MTYPE) = &H61
    Case Else
        DapData1(CCB_MTYPE) = &HFF
    End Select
    
    subcmd = &H60              'special command
    
    DapData1(CCB_DNODE) = 0
    DapData1(CCB_SNODE) = 0
    DapData1(CCB_CTYPE) = 0
    DapData1(CCB_SUBCMD) = subcmd
    DapData1(CCB_SUBNODE) = subnode
    
    packsize = 160
    For i = 1 To datalen Step packsize
        Cnt = datalen - i + 1
        If Cnt > packsize Then Cnt = packsize
        k = CCB_DATA        '0
        ret = BinCopy(DapData1(), k, Data2DapB(), i - 1, Cnt)
        length = CCB_LEN + Cnt
        DapData1(CCB_LEN_H) = length \ &H100
        DapData1(CCB_LEN_L) = length Mod &H100
        
        WinSock0.SendData DapData1    'dap1
        SendDapData2 = 1     'ret
    Next i
    Exit Function
    
SENDERR99:
    MsgBox "Send Error: " & Error
    
End Function
Function Bin2Str(bufbin() As Byte, Start As Integer, Cnt) As String
    Dim i As Integer
    Dim bufstr As String
    Dim dataB As Byte

    
    'cnt = LenB(bufbin)
    'cnt = 3
    bufstr = ""
    For i = 0 To Cnt - 1
        'bufstr = bufstr + Chr$(AscB(MidB(bufbin, start + i, 1)))
        dataB = bufbin(Start + i)
        'If dataB = 0 Then dataB = &H20  '&H20=Space --> for show message
        bufstr = bufstr + ChrW$(dataB)
    Next i

    Bin2Str = bufstr
End Function

Function unldump(indata As String, outdata As String) As Integer
    'ldump data format: "xx xx xx xx xx ..."
    Dim tmpstr As String, retstr As String
    Dim othstr As String
    Dim tmpint As Integer, idx As Integer, strlen As Integer
        
    othstr = indata
    retstr = ""
    strlen = 0
    Do
        idx = InStr(othstr, " ")
        If idx = 3 Then
            tmpstr = "&H" & Left(othstr, idx - 1)
            If tmpstr = "&H00" Then tmpstr = "&H20"
            retstr = retstr & ChrW(tmpstr)
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

Function BinCopy(dstbuf() As Byte, dst_ndx As Integer, srcbuf() As Byte, src_ndx As Integer, Cnt As Integer) As Integer
    Dim i As Integer

    For i = 0 To Cnt - 1
        dstbuf(dst_ndx + i) = srcbuf(src_ndx + i)
    Next i

    BinCopy = dst_ndx + Cnt
End Function
Function ldump3(ip_str() As Byte, Start As Integer, Cnt As Integer) As String
    Dim ret As Integer, i As Integer
    Dim tmpstr As String, op_str As String

    op_str = ""
    For i = 0 To Cnt - 1
        tmpstr = Hex$(ip_str(Start + i)) + " "
        If Len(tmpstr) < 3 Then
            tmpstr = "0" & tmpstr
        End If
        op_str = op_str + tmpstr
    Next i

    ldump3 = op_str
End Function
Function ldump(ip_str, op_str) As Integer
    Dim Start As Integer
    Dim tmpstr As String

    op_str = ""
    Start = 1
    Do
        tmpstr = Mid$(ip_str, Start, 1)
        Start = Start + 1
        If tmpstr = "" Then Exit Do
        tmpstr = Hex$(Asc(tmpstr)) + " "
        If Len(tmpstr) < 3 Then
            tmpstr = "0" & tmpstr
        End If
        op_str = op_str + tmpstr
    Loop

End Function
Function Str2Byte(OpByte() As Byte, IpStr As String) As Integer
                    'ret=len OK, <0 err
    Dim lens As Integer, i As Integer
    Dim Cnt As Integer, Bytetmp As Byte
    Dim strtmp As String
    
    Cnt = 0
    lens = Len(IpStr)
    If (lens Mod 2) <> 0 Then       'format error
        Str2Byte = -1
        Exit Function
    End If
    For i = 1 To lens
        strtmp = Mid(IpStr, i, 1)
        Bytetmp = (Val("&H" & strtmp) Mod 256) * &H10      'Hi byte
        i = i + 1
        strtmp = Mid(IpStr, i, 1)
        OpByte(Cnt) = "&H" & Hex(Bytetmp + (Val("&H" & strtmp) Mod 256))          'Lo byte
        Cnt = Cnt + 1
    Next i
    
    Str2Byte = Cnt
        
End Function
Function HexIpB(ip_str As String, op_str() As Byte, op_start As Integer) As Integer
    'translate String to Hex by byte.
    'can setting output start position; ret=byte array tail
    Dim Start As Integer, Cnt As Integer
    Dim tmpstr As String
    Dim data As Integer

    Start = 1
    Cnt = 0 + op_start
    Do
        tmpstr = Mid$(ip_str, Start, 1)
        Start = Start + 1
        If tmpstr = "" Then Exit Do
        If tmpstr = "\" Then
            tmpstr = "&H" & Mid$(ip_str, Start, 2)
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


