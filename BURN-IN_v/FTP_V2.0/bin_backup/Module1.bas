Attribute VB_Name = "Module1"
Option Explicit

Global Const UDP_INVITE_PORT = 55954
Global Const UDP_TEST_PORT = 55950

Global Const DEVICE_MAX = 300

Global DA(DEVICE_MAX - 1, 2) As String
Global DA1(DEVICE_MAX - 1, 20) As String
'Global DA2(DEVICE_MAX - 1, 20) As String
Global DA2(DEVICE_MAX - 1, 21) As String        '---update 2006/08/08

Global DevCount As Integer
Global DevSetCount As Integer
Global DevTestCount As Integer
Global DevNormalCount As Integer
Global DevDefaultCount As Integer

Global ProcStep As Integer


Function GetInviteReply(tmpv As Variant) As String
    Dim tmpstr As String
    Dim tmpIP As String, tmpNetmask As String, tmpMac As String, tmpModel As String
    Dim i As Integer, j As Integer
    
    On Error GoTo GetInviteReply_99
    
    '---get ip
    tmpstr = tmpv(12) & "." & tmpv(13) & "." & tmpv(14) & "." & tmpv(15)
    'MsgBoxT tmpstr
    tmpIP = tmpstr
    
    '---get netmask
    tmpstr = tmpv(236) & "." & tmpv(237) & "." & tmpv(238) & "." & tmpv(239)
    tmpNetmask = tmpstr
    
    '---get mac
    tmpstr = ldump41(tmpv, 28, 6)
    tmpMac = tmpstr
    
    '---get model
    tmpstr = HexOp31(tmpv, 44, 16)
    tmpModel = Trim(tmpstr)
    
    For i = 0 To DevCount - 1
        If DA2(i, 2) = tmpMac Then           '---MAC already recorded
            If DA2(i, 0) = tmpIP Then
                Exit Function               '---IP is the same then not necessary to be updated
            Else
                Exit For                    '---update it
            End If
        End If
    Next i
    
    If i = DevCount Then                    '---a new device
        If DevCount >= DEVICE_MAX Then
            Exit Function                   '---device count overflow
        End If
    End If
    
    DA2(i, 0) = tmpIP
    DA2(i, 1) = tmpNetmask
    DA2(i, 2) = tmpMac
    
    DA2(i, 3) = tmpv(12)        '---IP
    DA2(i, 4) = tmpv(13)
    DA2(i, 5) = tmpv(14)
    DA2(i, 6) = tmpv(15)
    
    DA2(i, 7) = tmpModel        '---model name
    DA2(i, 8) = ProcStep
    
    DA2(i, 9) = tmpv(28)        '---mac
    DA2(i, 10) = tmpv(29)
    DA2(i, 11) = tmpv(30)
    DA2(i, 12) = tmpv(31)
    DA2(i, 13) = tmpv(32)
    DA2(i, 14) = tmpv(33)
    
    DA2(i, 15) = tmpv(236)      '---netmask
    DA2(i, 16) = tmpv(237)
    DA2(i, 17) = tmpv(238)
    DA2(i, 18) = tmpv(239)
    
    DA2(i, 19) = tmpv(26)       '---last 2 bytes of gateway
    DA2(i, 20) = tmpv(27)
    
    DA2(i, 21) = ""             '---add 2006/08/08, as status
    
    If ProcStep = 0 Then        '---Invite step
        DevCount = DevCount + 1
        frmtcp.cmdChgIP.Enabled = True
        frmtcp.cmdDefault.Enabled = True

'           MsgBoxT DA2(i, 0) & "---" & DA2(i, 1) & "---" & DA2(i, 2) & "---" & "OK"
        
        DA2(i, 21) = "Invite OK"                   '---add 2006/08/08
        tmpstr = ShowDev(i)
        MsgBoxT1 tmpstr
                    
        UpdateDevListStatus i               '---add 2006/08/08
        
        frmtcp.lbDevCnt.Caption = DevCount
    
    ElseIf ProcStep = 1 Then        '---In set step
        If tmpv(32) = tmpv(14) And tmpv(33) = tmpv(15) Then     '---last 2 bytes, mac=ip
            DevSetCount = DevSetCount + 1       '---this is configured ip
            frmtcp.cmdStartTest.Enabled = True
           
           
            DA2(i, 21) = "Change IP OK"  '---add 2006/08/08
            tmpstr = ShowDev(i)
            MsgBoxT2 tmpstr
            
            UpdateDevListStatus i               '---add 2006/08/08
            
            frmtcp.lbDevSetCnt.Caption = DevDefaultCount 'Evan "= DevSetCount" exchange "= DevDefaultCount" 2007/10/18
            
            If DevSetCount = DevCount Then
                frmtcp.cmdChgIP.Enabled = True
            End If
        End If
    
    ElseIf ProcStep = 4 Then        '---Invite step
        If (tmpv(12) = 10 And tmpv(13) = 0 And tmpv(14) = 50 And tmpv(15) = 100) Or (tmpv(12) = 192 And tmpv(13) = 168 And tmpv(14) = 1 And tmpv(15) = 1) Then
            DevDefaultCount = DevDefaultCount + 1       '---this is configured ip
            
            DA2(i, 21) = "Set Default IP OK"                   '---add 2006/08/08
            tmpstr = ShowDev(i)
            MsgBoxT5 tmpstr
            
            UpdateDevListStatus i               '---add 2006/08/08
            
            frmtcp.lbDevDefaultCnt.Caption = DevDefaultCount
        End If
    End If
    Exit Function
    
GetInviteReply_99:
    Exit Function
    Resume
End Function

Function SendConfig(ndx As Integer) As Integer
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
    bdata(12) = DA2(ndx, 3)
    bdata(13) = DA2(ndx, 4)
    bdata(14) = DA2(ndx, 5)
    bdata(15) = DA2(ndx, 6)
        
    '---old MAC
    bdata(28) = DA2(ndx, 9)
    bdata(29) = DA2(ndx, 10)
    bdata(30) = DA2(ndx, 11)
    bdata(31) = DA2(ndx, 12)
    bdata(32) = DA2(ndx, 13)
    bdata(33) = DA2(ndx, 14)
    
    Select Case (DA2(ndx, 4))
    Case 0:
        '---new IP
        bdata(16) = 10
        bdata(17) = 0
        bdata(18) = DA2(ndx, 13)
        bdata(19) = DA2(ndx, 14)
        
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
    
    Case 168:
        '---new IP
        bdata(16) = 192
        bdata(17) = 168
        bdata(18) = DA2(ndx, 13)
        bdata(19) = DA2(ndx, 14)
        
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
    
    frmtcp.udpClient.SendData bdata
End Function

Function SendConfigDefault(ndx As Integer) As Integer
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
    bdata(12) = DA2(ndx, 3)
    bdata(13) = DA2(ndx, 4)
    bdata(14) = DA2(ndx, 5)
    bdata(15) = DA2(ndx, 6)
        
    '---old MAC
    bdata(28) = DA2(ndx, 9)
    bdata(29) = DA2(ndx, 10)
    bdata(30) = DA2(ndx, 11)
    bdata(31) = DA2(ndx, 12)
    bdata(32) = DA2(ndx, 13)
    bdata(33) = DA2(ndx, 14)
    
    Select Case (DA2(ndx, 4))
    Case 0:
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
    
    Case 168:
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
    
    frmtcp.udpClient.SendData bdata
End Function

Function SendRuninMode(ndx As Integer) As Integer
    Dim ret As Integer
    Dim tmpstr As String
    Dim bdata(21 - 1) As Byte

    If ndx < 0 Then
        frmtcp.udpTest.RemoteHost = "255.255.255.255"     '---broadcast
    Else
        frmtcp.udpTest.RemoteHost = DA2(ndx, 0)           '---remote IP
    End If
    frmtcp.udpTest.RemotePort = UDP_TEST_PORT
   
    '---configure IP
    bdata(0) = 2                    '---header, leading code
    bdata(1) = 1                    '---cmd type, set run-in mode
    bdata(2) = 16                   '---length
    tmpstr = frmtcp.udpTest.LocalIP       '---local IP
    'ret = str2buf(tmpstr, bdata, 3)
    bdata(3 + 15) = 1               '---run-in mode
    'bdata(3 + 16) = GetCRC(bdata, 1, 2 + 16)
    bdata(3 + 17) = 3
    
    frmtcp.udpTest.SendData bdata
End Function

Function SendNormalMode(ndx As Integer) As Integer
    Dim ret As Integer
    Dim tmpstr As String
    Dim bdata(21 - 1) As Byte

    If ndx < 0 Then
        frmtcp.udpTest.RemoteHost = "255.255.255.255"     '---broadcast
    Else
        frmtcp.udpTest.RemoteHost = DA2(ndx, 0)           '---remote IP
    End If
    frmtcp.udpTest.RemotePort = UDP_TEST_PORT
   
    '---configure IP
    bdata(0) = 2                    '---header, leading code
    bdata(1) = 3                    '---cmd type, set normal mode
    bdata(2) = 16                   '---length
    tmpstr = frmtcp.udpTest.LocalIP       '---local IP
    ret = str2buf(tmpstr, bdata, 3)
    bdata(3 + 15) = 0               '---normal mode
    bdata(3 + 16) = GetCRC(bdata, 1, 2 + 16)
    bdata(3 + 17) = 3
    
    frmtcp.udpTest.SendData bdata
    'tmpstr = ldump4(bdata, 0, 21)
    'MsgBox2 tmpstr
End Function

Function ShowDev(ndx As Integer) As String
    '---model + mac + ip
    'ShowDev = DA2(ndx, 7) & "---" & DA2(ndx, 2) & "---" & DA2(ndx, 0) & "---" & "OK"
    'ShowDev = DA2(ndx, 2) & "---" & DA2(ndx, 0) & "---" & DA2(ndx, 7) & "---" & "OK"
    ShowDev = DA2(ndx, 2) & "---" & DA2(ndx, 0) & "---" & DA2(ndx, 7) & "---" & DA2(ndx, 21)       '---update 2006/08/08
End Function

Function ShowDev2(ndx As Integer, msg As String) As String
    '---model + mac + ip
    ShowDev2 = DA2(ndx, 2) & "---" & DA2(ndx, 0) & "---" & DA2(ndx, 7) & "---" & msg
End Function

'---add 2006/08/08
Function ClearDevStatus() As Integer
    Dim i As Integer
    
    For i = 0 To DevCount - 1
        DA2(i, 21) = ""
    Next i
End Function

Function ShowDevStatus() As Integer
    Dim i As Integer
    Dim tmpstr As String
    Dim lst As Object
    
    Set lst = frmtcp.lstDev
    
    lst.Clear
    For i = 0 To DevCount - 1
        tmpstr = ShowDev(i)
        lst.AddItem tmpstr
    Next i
End Function

Function UpdateDevListStatus(dev_ndx As Integer) As Integer
    Dim i As Integer
    Dim tmpstr As String
    Dim lst As Object
    Dim mac As String

    On Error GoTo UpdateDevListStatus_99
    
    mac = DA2(dev_ndx, 2)
    tmpstr = ShowDev(dev_ndx)
    Set lst = frmtcp.lstDev
    
    For i = 0 To lst.ListCount - 1
        If mac = Left(lst.List(i), 12) Then
            lst.List(i) = tmpstr
            Exit Function
        End If
    Next i
    lst.AddItem tmpstr
    Exit Function
    
UpdateDevListStatus_99:
    MsgBox "UpdateDevListStatus err=" + Error
    Exit Function
    Resume
End Function


