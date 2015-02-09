Option Strict Off
Option Explicit On
Imports VB = Microsoft.VisualBasic
Friend Class frmtcp
	Inherits System.Windows.Forms.Form
    Dim reset_string As String
    Dim dl_counter As Short
    Dim Model_name As String 'simon add
    Dim RetVal(49) As Short '-------add by Elle
    Dim COMs As Short '-------add by Elle
    Dim hInternet As Integer 'simon
    Dim hConnect As Integer 'simon
    Dim dwInternetFlags As Integer 'simon
    Dim ftpconn As Short
	Private Sub clean_arp() 'Evan added 2007/10/22

		Dim ip1 As String
		Dim ip2 As String
		Dim RetVal As Object
		
		On Error Resume Next
		'RetVal = Shell("arp -d 10.0.50.100", 3)
		'RetVal = Shell("arp -d 192.168.1.1", 3)
		
		'UPGRADE_WARNING: 無法解析物件 RetVal 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RetVal = Shell("arp -d " & ip1, 0)
		'UPGRADE_WARNING: 無法解析物件 RetVal 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
		RetVal = Shell("arp -d " & ip2, 0)
		'    RetVal = Shell("arp -d " & ip3, 0)
		'    RetVal = Shell("arp -d " & ip4, 0)
		
	End Sub
	
	Private Sub sw2001_download()
		'
		'Dim dl_counter As Integer
		'
		'    Timer55.Enabled = False
		'    Timer55.Interval = 1000
		'    Timer55.Enabled = True
		'    timer55_flg = False
		'    dl_counter = 20
		'Do
		'
		'    sleep_doevents (100)
		'
		'    If timer55_flg = True Then
		'        dl_counter = dl_counter - 1
		'        cmdDownload.Caption = dl_counter
		'        cmdConnect.Enabled = False
		'        cmdConnect.Caption = dl_counter
		'        timer55_flg = False
		'        Timer55.Enabled = True
		'    End If
		'
		'    If dl_counter < 1 Then
		'        lstStatus.Clear
		'        cmdConnect1.Enabled = True
		'        cmdDownload.Caption = "載入測試檔案"
		'        lstStatus.FontSize = 12
		'        lstStatus.ForeColor = &H80FF&
		'        Exit Sub
		'    End If
		'
		'Loop
		
	End Sub
	
	Private Sub cmdCallFTP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCallFTP.Click
        Dim tftp As Object
		
        ''tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)
        '      Dim i As Short

        '      For i = 0 To CInt(lbDevCnt.Text) - 1

        '          hInternet = InternetOpen("FTP Application", INTERNET_OPEN_TYPE_DIRECT, Nothing, Nothing, INTERNET_FLAG_NO_CACHE_WRITE)
        '          ' If Internet Session Handle created OK
        '          If (hInternet <> 0) Then

        '              ' FTP Service Handle
        '              If (txtUser.Text = "") And (txtPass.Text = "") Then
        '                  ' anonymous

        '                  hConnect = InternetConnect(hInternet, DA2(i, 0), INTERNET_DEFAULT_FTP_PORT, Nothing, Nothing, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
        '              Else

        '                  hConnect = InternetConnect(hInternet, DA2(i, 0), INTERNET_DEFAULT_FTP_PORT, txtUser.Text, txtPass.Text, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)

        '              End If

        '              ' If internet connection created OK
        '              If (hConnect <> 0) Then
        '                  ftpconn = 1
        '                  FtpSetCurrentDirectory(hConnect, "/mnt/jffs2")
        '                  dwInternetFlags = FTP_TRANSFER_TYPE_BINARY
        '                  cmdDownload_Click(cmdDownload, New System.EventArgs())

        '              Else

        '                  If MsgBox("Service Session Error: " & DA2(i, 0) & "連線失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        '                      'Timer1.Enabled = False
        '                  Else
        '                      Exit Sub
        '                  End If
        '              End If
        '          Else
        '              If MsgBox("Internet Session Error: " & DA2(i, 0) & "連線失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then
        '                  'Timer1.Enabled = False
        '              Else
        '                  Exit Sub
        '              End If
        '              End If

        '     Next



        'Dim send_arg_ip As String
        'Dim dev_num As Short
        'For dev_num = 0 To Val(lbDevCnt.Text) - 1
        '    If dev_num = Val(lbDevCnt.Text) - 1 Then
        '        send_arg_ip = send_arg_ip & DA2(dev_num, 0)
        '        Exit For
        '    End If
        '    send_arg_ip = send_arg_ip & DA2(dev_num, 0) & "-"
        'Next dev_num

        'Shell("ftptest" & " " & send_arg_ip, 1)









        'frmFTP.Show()
        ''tftp = Shell(App.Path & "\" & "FileZilla.exe", 1)
        'FileClose()

    End Sub
	
	Private Sub cmdCalltest_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdCalltest.Click
        'Dim tp As Object

        '      'tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)
        ''UPGRADE_WARNING: 無法解析物件 tp 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'

        '      tp = Shell(My.Computer.FileSystem.CurrentDirectory & "\" & "LoopCom1_Com8_v1_4.exe", 1)






        Open_COMTest("COMLoopback_v1") '---------add by Elle
    End Sub


    Private Sub cmdConnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConnect.Click
        'MsgBox2 "點選成品測試的開始按鍵"
        ''''''''''''''''''''''''''''''''''''''''''''''''''''for WLAN quality
        'lblWANquality.Visible = False
        ' txtOct.Visible = False
        ' txtHex.Text = ""
        ''''''''''''''''''''''''''''''''''''''''''''''''''''
        'txtOct.Text = ""
        'lblMonitor.Visible = True
        'udpClient.Close
        'Timer22.Enabled = False
        '
        'ftpconn = 0
        '
        'lstStatus.Clear
        'txtReceivedataC.Text = ""
        '
        ' On Error GoTo ConError
        '    cmdConnect.Enabled = False
        '
        '    With Inet1
        '       .RemoteHost = txtIP.Text
        '       .URL = txtIP.Text
        '       .Protocol = icFTP
        '       .UserName = txtUser.Text
        '       .Password = txtPass.Text
        '    End With
        '
        '    strOper = "Dir"
        '    Inet1.Execute , strOper
        '    cmdDownload_Click
        '    Exit Sub
        '
        'ConError:
        '
        '    cmdConnect.Caption = "與待測物連線"
        '    cmdConnect.Enabled = True
        '    cmdDisconnect.Enabled = True
    End Sub

    Private Sub cmdDisconnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDisconnect.Click
        ' MsgBox2 "點選成品測試的(FTP)中斷按鍵"
        'ShowAp.Text = ""
        'ShowGateway.Text = ""
        'ShowIpp.Text = ""
        'ShowKennel.Text = ""
        'ShowMacc.Text = ""
        'ShowModel.Text = ""
        'ShowSubnet.Text = ""
        ' ftpconn = 0
        ' atop_timer (2000)
        '   Inet1.Execute , "Quit"
        '  cmdConnect.Enabled = True
    End Sub

    Private Sub cmdDownload_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDownload.Click

        ' While ftpconn = 0
        ' DoEvents
        ' Wend
        '
        ' cmdConnect.Enabled = False
        ' strOper = "GetFile"
        ' Inet1.Execute , "Put user.sh user.sh"
        '  atop_timer (500)
        ' Inet1.Execute , "Put atop_testd atop_testd"
        '
        'MsgBox "載入成功！請按-'確定鍵'後將待測物電源重新開啟!", vbOKOnly + vbExclamation, "注意"
        '              cmdDisconnect_Click 'evan added
        '              cmdDisconnect.Enabled = False
        '              cmdDownload.Enabled = False
        '              lstStatus.FontSize = 12
        '              lstStatus.ForeColor = &H80FF&
        '              lstStatus.AddItem "等待測物重新開機結束..."
        '              cmdConnect.Enabled = False
        '              sw2001_download
        ''              cmdConnect1_Click
        '              cmdConnect1.Caption = "測試前連線"
        '              'cmdConnect1.Enabled = True
        '' Inet1.Execute , "Delete user.sh"
        '' Inet1.Execute , "Delete atop_testd"
        '' Inet1.Execute , "Put devcpp.exe devcpp.exe"
    End Sub


    Private Sub cmdFTP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdFTP.Click

        '''' Dim i As Integer
        '''' Dim tmpstr As String
        ''''
        ''''    On Error GoTo cmdFTP_Click99
        ''''    cmdToCmdFile.Enabled = True
        ''''    ProcStep = 1
        ''''    DevSetCount = 0
        ''''
        ''''    ClearDevStatus     '---add 2006/08/08
        ''''    ShowDevStatus
        ''''
        ''''    lstMsgT6.Clear
        '''''    lbDevCnt.Caption = "" 'Evan exchange
        ''''
        ''''    For i = 0 To DevCount - 1
        ''''    If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then
        '''''        If DA2(I, 5) = DA2(I, 13) And DA2(I, 6) = DA2(I, 14) Then   '---last 2 bytes, mac=ip
        ''''            DevSetCount = DevSetCount + 1                           '---this is configured ip
        ''''            frmtcp.cmdStartTest.Enabled = True
        ''''
        ''''            'MsgBoxT2 DA2(i, 0) & "---" & DA2(i, 1) & "---" & DA2(i, 2) & "---" & "OK"
        ''''            DA2(i, 21) = "Download test file OK"                   '---add 2006/08/08
        ''''            tmpstr = ShowDev(i)
        ''''            MsgBoxT6 tmpstr
        ''''
        ''''            UpdateDevListStatus i               '---add 2006/08/08
        ''''        Else
        ''''            SendConfig i                    '---set to new unique IP
        ''''        End If
        ''''    Next i
        ''''
        ''''    frmtcp.lbDevDownload.Caption = DevSetCount
        ''''
        ''''    Timer1.Interval = 10000
        ''''    Timer1.Enabled = True
        ''''    'Timer1_Timer
        ''''
        ''''    Exit Sub
        ''''
        ''''cmdFTP_Click99:
        ''''    MsgBox2 "cmdFTP_Click() err=" + Error
        ''''    Exit Sub
        ''''    Resume

    End Sub

    '    Private Sub cmdInvite_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    '        Dim file_no As Short
    '        Dim i, j As Short

    '        ProcStep = 0

    '        '-----Initial
    '        InitialCmd()

    '        Timer1.Enabled = False

    '        For j = 0 To DEVICE_MAX - 1
    '            For i = 0 To 2
    '                DA(j, i) = ""
    '            Next i

    '            For i = 0 To 20
    '                DA1(j, i) = ""
    '            Next i

    '            For i = 0 To 20
    '                DA2(j, i) = ""
    '            Next i
    '        Next j

    '        ShowDevStatus()

    '        '----- send UDP request to invite all devices------------------------------
    '        Dim bdata(300 - 1) As Byte

    '        On Error GoTo cmdInvite99

    '        '   sleep_doevents (300000)

    '        udpClient.Close()
    '        udpClient.LocalPort = UDP_INVITE_PORT
    '        udpClient.Bind()

    '        udpTest.Close()
    '        udpTest.LocalPort = UDP_TEST_PORT
    '        udpTest.Bind()

    '        Timer1.Interval = 3000
    '        Timer1.Enabled = True
    '        Timer1_Tick(Timer1, New System.EventArgs())

    '        Exit Sub

    'cmdInvite99:
    '        MsgBox2("cmdInvite() err=" & ErrorToString())
    '    End Sub

    Private Sub cmdChgIP_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
        Dim i As Short
        Dim tmpstr As String

        On Error GoTo cmdChgIP_Click99

        clean_arp() 'evan added 2007/10/23

        cmdToCmdFile.Enabled = True
        ProcStep = 1
        DevSetCount = 0


        ClearDevStatus() '---add 2006/08/08
        ShowDevStatus()

        lstMsgT2.Items.Clear()
        lbDevSetCnt.Text = ""

        For i = 0 To DevCount - 1
            If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then
                '        If DA2(I, 5) = DA2(I, 13) And DA2(I, 6) = DA2(I, 14) Then   '---last 2 bytes, mac=ip
                DevSetCount = DevSetCount + 1 '---this is configured ip
                Me.cmdStartTest.Enabled = True

                'MsgBoxT2 DA2(i, 0) & "---" & DA2(i, 1) & "---" & DA2(i, 2) & "---" & "OK"
                DA2(i, 21) = "Change IP OK" '---add 2006/08/08
                tmpstr = ShowDev(i)
                MsgBoxT2(tmpstr)

                UpdateDevListStatus(i) '---add 2006/08/08
            Else
                SendConfig(i) '---set to new unique IP
            End If
        Next i

        Me.lbDevSetCnt.Text = CStr(DevSetCount)

        Timer1.Interval = 10000
        Timer1.Enabled = True
        'Timer1_Timer

        Exit Sub

cmdChgIP_Click99:
        MsgBox2("cmdChgIP_Click() err=" & ErrorToString())
        Exit Sub
        Resume
    End Sub

    Private Sub cmdStopTest_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStopTest.Click
        ''''    Dim i As Integer
        ''''    Dim tmpstr As String
        ''''
        ''''    On Error GoTo cmdStopTest_Click99
        ''''
        ''''    ProcStep = 3
        ''''    DevNormalCount = 0
        ''''
        ''''    lstMsgT4.Clear
        ''''    lbDevNormalCnt.Caption = ""
        ''''
        ''''    SendNormalMode -1                    '---broadcast to normal mode
        ''''
        ''''    frmtcp.lbDevNormalCnt.Caption = DevNormalCount
        ''''
        ''''    Timer1.Interval = 10000
        ''''    Timer1.Enabled = True
        ''''    'Timer1_Timer
        ''''
        ''''    Exit Sub
        ''''
        ''''cmdStopTest_Click99:
        ''''    MsgBox2 "cmdStopTest_Click() err=" + Error
        ''''    Exit Sub
        ''''    Resume
    End Sub

    Private Sub cmdDefault_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDefault.Click
        Dim i As Short
        Dim tmpstr As String

        On Error GoTo cmdDefault_Click99

        ProcStep = 4
        DevDefaultCount = 0

        For i = 0 To DevCount - 1
            If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then '---last 2 bytes, mac=ip
                SendConfigDefault(i) '---set default
            Else
                DevDefaultCount = DevDefaultCount + 1

                DA2(i, 21) = "Set Default IP OK" '---add 2006/08/08
                tmpstr = ShowDev(i)
                MsgBoxT5(tmpstr)

                UpdateDevListStatus(i) '---add 2006/08/08
            End If
        Next i

        Me.lbDevDefaultCnt.Text = CStr(DevDefaultCount)

        Timer1.Interval = 10000
        Timer1.Enabled = True
        'Timer1_Timer

        Exit Sub

cmdDefault_Click99:
        MsgBox2("cmdDefault() err=" & ErrorToString())
    End Sub

    Private Sub cmdStartTest_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdStartTest.Click
        '''    Dim i As Integer
        '''    Dim tmpstr As String
        '''
        '''    On Error GoTo cmdStartTest_Click99
        '''
        '''    ProcStep = 2
        '''    DevTestCount = 0
        '''
        '''    lstMsgT3.Clear
        '''
        '''    lbDevTestCnt.Caption = ""
        '''
        '''    SendRuninMode -1                    '---broadcast to run-in mode
        '''
        '''    frmtcp.lbDevTestCnt.Caption = DevTestCount
        '''
        '''    Timer1.Interval = 10000
        '''    Timer1.Enabled = True
        '''    'Timer1_Timer
        '''
        '''    Exit Sub
        '''
        '''cmdStartTest_Click99:
        '''    MsgBox2 "cmdStartTest_Click() err=" + Error
        '''    Exit Sub
        '''    Resume
    End Sub


    Private Sub cmdToCmdAPFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdToCmdAPFile.Click
        Dim tmpstr, fname As String
        Dim i As Short
        Dim tftp As Object
        Dim kernel_name As String
        On Error GoTo cmdToCmdFile_Click99
        cdlFileOpen.Filter = "資料檔 (*.img)|*.img|ALL | *.*"
        cdlFileOpen.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        cdlFileOpen.FileName = ""
        cdlFileOpen.ShowDialog()
        kernel_name = My.Computer.FileSystem.GetParentPath(cdlFileOpen.FileName) & "\" & My.Computer.FileSystem.GetName(cdlFileOpen.FileName)
        'If kernel_name = "" Then
        '    MsgBox("you are not select any kernel file")

        '    Exit Sub
        'End If

        '    clean_arp
        fname = My.Application.Info.DirectoryPath & "\" & Model_name & "_bat" & "\" & "Ap"

        If Dir(fname, FileAttribute.Directory) = "" Then
            MkDir(fname)

        Else
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(fname, FileIO.SearchOption.SearchAllSubDirectories, "runAp*")
                My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Next
        End If
        For i = 0 To DevCount - 1
            fname = My.Application.Info.DirectoryPath & "\" & Model_name & "_bat" & "\" & "Ap" & "\" & "runAp" & "_" & CStr(i) & ".bat"

            If Dir(fname) <> "" Then
                Kill(fname)
            End If
            tmpstr = "arp -d" & Chr(13) & Chr(10) & "mpc5200_dl_v2.exe " & "-l " & """" & kernel_name & """" & " " & DA2(i, 0) & Chr(13) & Chr(10)
            'tmpstr = "ping " + DA2(i, 0) + " -t" + Chr(13) + Chr(10)
            LogFile(fname, tmpstr)
        Next i

        MsgBox("OK ! Generate " & CStr(DevCount) & " command files to " & Model_name & "_bat")

        '    tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)
        'UPGRADE_WARNING: 無法解析物件 tftp 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'tftp = Shell(My.Application.Info.DirectoryPath & "\cmdKernel\" & "runKernel" & CStr(i) & ".bat", 1)

        '   tftp = Shell("C:\21s_mega_runin 0717\cmd\run0.cmd", 1)
        Exit Sub

cmdToCmdFile_Click99:
        MsgBox2("cmdToCmdFile_Click() err=" & ErrorToString())
        Exit Sub
        Resume
    End Sub

    Private Sub cmdToCmdFile_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdToCmdFile.Click
        Dim tmpstr, fname As String
        Dim i As Short
        Dim tftp As Object
        Dim kernel_name As String

        On Error GoTo cmdToCmdFile_Click99

        cdlFileOpen.Filter = "資料檔 (*.img)|*.img|ALL | *.*"
        cdlFileOpen.InitialDirectory = My.Computer.FileSystem.CurrentDirectory
        cdlFileOpen.FileName = ""
        cdlFileOpen.ShowDialog()
        kernel_name = My.Computer.FileSystem.GetParentPath(cdlFileOpen.FileName) & "\" & My.Computer.FileSystem.GetName(cdlFileOpen.FileName)
        'If kernel_name = "" Then
        '    MsgBox("you are not select any kernel file")

        '    Exit Sub
        'End If

        '    clean_arp
        fname = My.Application.Info.DirectoryPath & "\" & Model_name & "_bat" & "\" & "Kernel"

        If Dir(fname, FileAttribute.Directory) = "" Then
            MkDir(fname)

        Else
            For Each foundFile As String In My.Computer.FileSystem.GetFiles(fname, FileIO.SearchOption.SearchAllSubDirectories, "runKernel*")
                My.Computer.FileSystem.DeleteFile(foundFile, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)
            Next
        End If
        For i = 0 To DevCount - 1
            fname = My.Application.Info.DirectoryPath & "\" & Model_name & "_bat" & "\" & "Kernel" & "\" & "runKernel" & "_" & CStr(i) & ".bat"

            If Dir(fname) <> "" Then
                Kill(fname)
            End If
            tmpstr = "arp -d" & Chr(13) & Chr(10) & "mpc5200_dl_v2.exe " & "-l " & """" & kernel_name & """" & " " & DA2(i, 0) & Chr(13) & Chr(10)
            'tmpstr = "ping " + DA2(i, 0) + " -t" + Chr(13) + Chr(10)
            LogFile(fname, tmpstr)
        Next i

        MsgBox("OK ! Generate " & CStr(DevCount) & " command files to " & Model_name & "_bat")

        '    tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)
        'UPGRADE_WARNING: 無法解析物件 tftp 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'tftp = Shell(My.Application.Info.DirectoryPath & "\cmdKernel\" & "runKernel" & CStr(i) & ".bat", 1)

        '   tftp = Shell("C:\21s_mega_runin 0717\cmd\run0.cmd", 1)
        Exit Sub

cmdToCmdFile_Click99:
        MsgBox2("cmdToCmdFile_Click() err=" & ErrorToString())
        Exit Sub
        Resume
    End Sub

    Private Sub Command1_Click()

    End Sub


    Private Sub frmtcp_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        Dim Fileno As Object
        'frmtcp.Caption = frmtcp.Caption & " (V" & App.Major & "." & App.Minor & ")"
        InitialCmd()
        DevCount = 0
        MsgBox2("Startup")

        ''''''''''''''''''''''''''''''''''''''''''''''
        'Dim FileNoTimer4Intval As Object
        'Dim strStringTimer4Intval As String
        'Dim contentTimer4Intval As String

        ''UPGRADE_WARNING: 無法解析物件 FileNoTimer4Intval 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'FileNoTimer4Intval = FreeFile

        ''UPGRADE_WARNING: 無法解析物件 FileNoTimer4Intval 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'FileOpen(FileNoTimer4Intval, My.Application.Info.DirectoryPath & "\Device_Next_Intval.txt", OpenMode.Input)
        ''UPGRADE_WARNING: 無法解析物件 FileNoTimer4Intval 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'While Not EOF(FileNoTimer4Intval)
        '	'UPGRADE_WARNING: 無法解析物件 FileNoTimer4Intval 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        '	strStringTimer4Intval = LineInput(FileNoTimer4Intval)

        '	'UPGRADE_WARNING: 計時器屬性 Timer4.Interval 其值不可以為零。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
        '	Timer4.Interval = CInt(strStringTimer4Intval)

        'End While
        ''UPGRADE_WARNING: 無法解析物件 FileNoTimer4Intval 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'FileClose(FileNoTimer4Intval)

        ''''''''''''''''''''''''''''''''''''''''''''''
        Fileno = FreeFile()
        FileOpen(Fileno, My.Application.Info.DirectoryPath & "\Write_Model.txt", OpenMode.Input)
        Model_name = LineInput(Fileno)
        FileClose(Fileno)
        If InStr(Model_name, "5110") > 0 Or InStr(Model_name, "400") > 0 Or InStr(Model_name, "01") > 0 Then
            '        Portn.Text = "_1"
            COMs = 1
        ElseIf InStr(Model_name, "02") > 0 Or InStr(Model_name, "5120") > 0 Or InStr(Model_name, "PC") > 0 Or InStr(Model_name, "512") > 0 Or InStr(Model_name, "GW81") > 0 Then
            '        Portn.Text = "_2"
            COMs = 2
        ElseIf InStr(Model_name, "04") > 0 Or InStr(Model_name, "514") Then 'CS MG 514
            '        Portn.Text = "_3"
            COMs = 4
        ElseIf InStr(Model_name, "08") > 0 Or InStr(Model_name, "518") Then 'CS MG 518
            '        Portn.Text = "_4"

            COMs = 8
        ElseIf InStr(Model_name, "16") > 0 Then
            '        Portn.Text = "_5"
            COMs = 8       '--------the max connections ->8, use 2 windows to connect 16 ports
            If InStr(Model_name, "SE7816") > 0 Or InStr(Model_name, "SE7416") > 0 Then
                COMs = 8
            End If
        ElseIf InStr(Model_name, "32") > 0 Then
            '        Portn.Text = "_6"
            COMs = 8       '--------the max connection ->8, use 4 windows to connect 32 ports
        ElseIf InStr(Model_name, "5300") > 0 Then 'for ew5300
            '        Portn.Text = "_0"
            COMs = 0
            '    ElseIf InStr(Model_name, "06") > 0 Then 'for ew5300
            ''        Portn.Text = "_0"
            '        COMs = 6
        Else
            MsgBox("不支援的型號")
            'cblModelname.Text = ""
        End If
    End Sub

    Private Sub frmtcp_FormClosed(ByVal eventSender As System.Object, ByVal eventArgs As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'UPGRADE_NOTE: State 升級為 CtlState。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="A9E4979A-37FA-4718-9994-97DD76ED70A7"'
        If udpClient.CtlState = 7 Then
            udpClient.Close()
        End If

        End
    End Sub

    Private Sub Inet1_StateChanged(ByVal eventSender As System.Object, ByVal eventArgs As AxInetCtlsObjects.DInetEvents_StateChangedEvent) Handles Inet1.StateChanged
        ' Select Case State
        '
        '        Case 4
        '            cmdDownload.Enabled = True
        '            cmdDisconnect.Enabled = True
        '            txtIP.Enabled = False
        '            txtUser.Enabled = False
        '            txtPass.Enabled = False
        '        Case 11
        ''            If InStr(Inet1.ResponseInfo, "No such file") > 0 Or _
        '''                InStr(Inet1.ResponseInfo, "No such file or directory") Then
        ''                txtReceivedataC.Text = "已清除測試檔案!"
        ''            Else
        ''                MsgBox Inet1.ResponseInfo
        ''            End If
        '        Case 10
        '            cmdConnect.Enabled = True
        '            cmdDownload.Enabled = False
        '            cmdDisconnect.Enabled = False
        '            txtIP.Enabled = False
        '            txtUser.Enabled = False
        '            txtPass.Enabled = False
        '        Case 12
        '            If LCase(strOper) = "dir" Then
        ''                InetGetDir
        '                'MsgBox "已經與主機連線！"
        '                ftpconn = 1
        '                cmdConnect.Enabled = False
        '             cmdDisconnect.Enabled = True
        '            End If
        '    End Select
        '    Debug.Print "狀態常數：" & State & " 訊息內容：" & Inet1.ResponseInfo
    End Sub

    Private Sub lstMsgT1_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstMsgT1.DoubleClick
        Dim tmpstr As String

        tmpstr = VB6.GetItemString(lstMsgT1, lstMsgT1.SelectedIndex)
        reset_string = tmpstr

        'ShowSelectDev tmpstr
    End Sub

    Private Sub lstMsgT2_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstMsgT2.DoubleClick
        Dim tmpstr As String

        tmpstr = VB6.GetItemString(lstMsgT2, lstMsgT2.SelectedIndex)
        reset_string = tmpstr

        'ShowSelectDev tmpstr
    End Sub

    Private Sub lstMsgT3_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstMsgT3.DoubleClick
        Dim tmpstr As String
        Dim mac_ndx, ip_ndx, mask_ndx, status_ndx As Short

        tmpstr = VB6.GetItemString(lstMsgT3, lstMsgT3.SelectedIndex)
        reset_string = tmpstr

        'ShowSelectDev tmpstr
    End Sub

    Sub ShowSelectDev(ByRef tmpstr As String)
        Dim mac_ndx, ip_ndx, mask_ndx, status_ndx As Short

        ip_ndx = InStr(tmpstr, " ") + 1
        mask_ndx = InStr(tmpstr, "---") + 3
        mac_ndx = mask_ndx + InStr(Mid(tmpstr, mask_ndx), "---") + 3 - 1
        status_ndx = mac_ndx + InStr(Mid(tmpstr, mac_ndx), "---") + 3 - 1

        'lbSelDevIP.Caption = Trim(Mid(tmpstr, ip_ndx, mask_ndx - ip_ndx - 3))
        'lbSelDevMAC.Caption = Trim(Mid(tmpstr, mac_ndx, status_ndx - mac_ndx - 3))
    End Sub

    'UPGRADE_WARNING: 初始化表單時可能會引發事件 lstMsgT4.SelectedIndexChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstMsgT4_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstMsgT4.SelectedIndexChanged
        '''    Dim tmpstr As String
        '''    Dim ip_ndx As Integer, mask_ndx As Integer, mac_ndx As Integer, status_ndx As Integer
        '''
        '''    tmpstr = lstMsgT4.List(lstMsgT4.ListIndex)
        '''    reset_string = tmpstr
        '''
        '''    'ShowSelectDev tmpstr
    End Sub

    'UPGRADE_WARNING: 初始化表單時可能會引發事件 lstMsgT5.SelectedIndexChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstMsgT5_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstMsgT5.SelectedIndexChanged
        '    Dim tmpstr As String
        '    Dim ip_ndx As Integer, mask_ndx As Integer, mac_ndx As Integer, status_ndx As Integer
        '
        '    tmpstr = lstMsgT5.List(lstMsgT5.ListIndex)
        '    reset_string = tmpstr

        'ShowSelectDev tmpstr
    End Sub

    'UPGRADE_WARNING: 初始化表單時可能會引發事件 lstMsgT6.SelectedIndexChanged。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="88B12AE1-6DE0-48A0-86F1-60C0686C026A"'
    Private Sub lstMsgT6_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstMsgT6.SelectedIndexChanged
        Dim tmpstr As String

        tmpstr = VB6.GetItemString(lstMsgT6, lstMsgT6.SelectedIndex)
        reset_string = tmpstr

    End Sub

    Private Sub Timer1_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer1.Tick
        Dim bdata(300 - 1) As Byte
        Dim i As Short

        On Error GoTo Timer1_Timer99

        If ProcStep = 0 Then '---auto invite
            udpClient.RemoteHost = "255.255.255.255"
            udpClient.RemotePort = UDP_INVITE_PORT
            bdata(0) = 2
            bdata(1) = 1
            bdata(2) = 6
            bdata(4) = &H92
            bdata(5) = &HDA
            udpClient.SendData(bdata)

        ElseIf ProcStep = 1 Then
            If DevSetCount <> DevCount Then
                For i = 0 To DevCount - 1
                    If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then '---last 2 bytes, mac=ip
                        '---already changed
                    Else
                        SendConfig(i)
                    End If
                Next i
            End If

        ElseIf ProcStep = 2 Then
            If DevTestCount <> DevCount Then
                For i = 0 To DevCount - 1
                    If CDbl(DA2(i, 8)) <> 2 Then
                        SendRuninMode(i)
                    End If
                Next i
            End If

        ElseIf ProcStep = 3 Then
            If DevNormalCount <> DevCount Then
                For i = 0 To DevCount - 1
                    If CDbl(DA2(i, 8)) <> 3 Then
                        SendNormalMode(i)
                    End If
                Next i
            End If

        ElseIf ProcStep = 4 Then
            If DevDefaultCount <> DevCount Then
                For i = 0 To DevCount - 1
                    If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then '---last 2 bytes, mac=ip
                        SendConfigDefault(i) '---set default
                    End If
                Next i
            End If
        End If

        Exit Sub

Timer1_Timer99:
        MsgBox2("Timer1() err=" & ErrorToString())
    End Sub

    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
    End Sub

    Private Sub Timer3_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
    End Sub

    Private Sub Timer55_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer55.Tick
        'timer55_flg = True
        '    Timer55.Enabled = False
    End Sub

    Private Sub udpClient_DataArrival(ByVal eventSender As System.Object, ByVal eventArgs As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles udpClient.DataArrival
        Dim bdata(300 - 1, 0) As Byte
        Dim tmpv As Object
        Dim tmpstr As String
        Dim Cnt, i As Short
        Dim tmpNetmask, tmpIP, tmpMac As String

        On Error GoTo udpClient_DataArrival99

        udpClient.GetData(tmpv)

        'UPGRADE_WARNING: VarType 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If VarType(tmpv) = 0 Then '= Empty
            Exit Sub
        End If

        Cnt = UBound(tmpv) + 1

        '----- data dispatch to process different data type
        If Cnt = 300 Then '---maybe device manager protocol
            '---tmpv(0)=1: report msg after invite, =3:ack after configuring
            '       If (tmpv(0) = 1 Or tmpv(0) = 3) And tmpv(1) = 1 And tmpv(2) = 6 And tmpv(4) = &H92 And tmpv(5) = &HDA Then
            'UPGRADE_WARNING: 無法解析物件 tmpv(5) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: 無法解析物件 tmpv(4) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            'UPGRADE_WARNING: 無法解析物件 tmpv(0) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If (tmpv(0) = 1 Or tmpv(0) = 3) And tmpv(4) = &H92 And tmpv(5) = &HDA Then
                GetInviteReply(tmpv)
                'Exit Sub

                '---other messages are ignored
            Else
                Exit Sub
            End If
        End If

        If Cnt < 300 Then
            Exit Sub
        End If

        'If udpClient.RemoteHostIP <> txtIP Then
        '    Exit Sub
        'End If

        'tmpstr = ldump4(tmpv, 0, cnt)
        'MsgBoxT udpClient.RemoteHostIP & tmpstr

        Exit Sub

udpClient_DataArrival99:
        MsgBox2("udpClient_DataArrival() err=" & ErrorToString())
        Exit Sub
        Resume
    End Sub

    Private Sub lstMsg_DoubleClick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstMsg.DoubleClick
        MsgBox(VB6.GetItemString(lstMsg, lstMsg.SelectedIndex))
    End Sub

    Private Sub udpTest_DataArrival(ByVal eventSender As System.Object, ByVal eventArgs As AxMSWinsockLib.DMSWinsockControlEvents_DataArrivalEvent) Handles udpTest.DataArrival
        Dim bdata(300 - 1, 0) As Byte
        Dim tmpv As Object
        Dim tmpstr As String
        Dim i, Cnt, j As Short
        Dim tmpMac, tmpIP, tmpNetmask, tmpStatus As String

        On Error GoTo udpTest_DataArrival99

        udpTest.GetData(tmpv)

        'UPGRADE_WARNING: VarType 有新的行為。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="9B7D5ADD-D8FE-4819-A36C-6DEDAF088CC7"'
        If VarType(tmpv) = 0 Then '= Empty
            Exit Sub
        End If

        Cnt = UBound(tmpv) + 1

        '----- data dispatch to process different data type
        'UPGRADE_WARNING: 無法解析物件 tmpv(0) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If tmpv(0) = 2 Then '---maybe device reply or report message
            'UPGRADE_WARNING: 無法解析物件 tmpv(1) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            If tmpv(1) = 2 Then '---reply for setting run-in mode
                tmpstr = HexOp3(tmpv, 3, 51)
                MsgBox2("To Run-in, " & tmpstr)

                If ProcStep = 2 Then
                    'tmpMac = ""
                    'For i = 0 To 5
                    '    tmpMac = tmpMac + Mid(tmpstr, 1 + 2 * i, 2) + " "
                    'Next i
                    'tmpMac = Trim(tmpMac)
                    tmpMac = VB.Left(tmpstr, 12)

                    For i = 0 To DevCount - 1 '---search device by MAC
                        If DA2(i, 2) = tmpMac Then
                            Exit For
                        End If
                    Next i

                    If i = DevCount Then '---search not found
                        MsgBox2("To Run-in, " & "unknown MAC: " & tmpMac)
                        Exit Sub
                    End If

                    If CDbl(DA2(i, 8)) <> ProcStep Then
                        DA2(i, 8) = CStr(ProcStep)
                        DevTestCount = DevTestCount + 1
                        Me.cmdStopTest.Enabled = True

                        DA2(i, 21) = "Change IP OK" '---add 2006/08/08
                        tmpstr = ShowDev(i)
                        MsgBoxT3(tmpstr)

                        UpdateDevListStatus(i) '---add 2006/08/08

                        Me.lbDevTestCnt.Text = CStr(DevTestCount)
                    End If
                End If

                'UPGRADE_WARNING: 無法解析物件 tmpv(1) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ElseIf tmpv(1) = 4 Then  '---reply for setting normal mode
                tmpstr = HexOp3(tmpv, 3, 51)
                MsgBox2("To Normal, " & tmpstr)

                If ProcStep = 3 Then
                    'tmpMac = ""
                    'For i = 0 To 5
                    '    tmpMac = tmpMac + Mid(tmpstr, 1 + 3 * i, 2) + " "
                    'Next i
                    'tmpMac = Trim(tmpMac)
                    tmpMac = VB.Left(tmpstr, 12)

                    For i = 0 To DevCount - 1 '---search device by MAC
                        If DA2(i, 2) = tmpMac Then
                            Exit For
                        End If
                    Next i

                    If i = DevCount Then '---search not found
                        MsgBox2("To Normal, " & "unknown MAC: " & tmpMac)
                        Exit Sub
                    End If

                    If CDbl(DA2(i, 8)) <> ProcStep Then
                        DA2(i, 8) = CStr(ProcStep)
                        DevNormalCount = DevNormalCount + 1

                        DA2(i, 21) = "Stop test OK" '---add 2006/08/08
                        tmpstr = ShowDev(i)
                        MsgBoxT4(tmpstr)

                        UpdateDevListStatus(i) '---add 2006/08/08

                        Me.lbDevNormalCnt.Text = CStr(DevNormalCount)
                    End If
                End If

                'UPGRADE_WARNING: 無法解析物件 tmpv(1) 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            ElseIf tmpv(1) = 5 Then  '---report device status
                tmpstr = HexOp3(tmpv, 3, 12 + 16)
                tmpMac = VB.Left(tmpstr, 12)
                tmpStatus = Mid(tmpstr, 13)

                MsgBox2("Status, " & tmpMac & ",  " & tmpStatus & ", " & StatusDesc(tmpStatus))

                If ProcStep = 2 Then
                    For i = 0 To DevCount - 1 '---search device by MAC
                        If DA2(i, 2) = tmpMac Then
                            Exit For
                        End If
                    Next i

                    If i = DevCount Then '---search not found
                        MsgBox2("In Run-in, " & "unknown MAC: " & tmpMac)
                        Exit Sub
                    End If

                    For j = 0 To lstDev.Items.Count - 1 '---search device by MAC
                        If VB.Left(VB6.GetItemString(lstDev, j), 12) = tmpMac Then
                            DA2(i, 21) = VB6.Format(Today, "YYYYMMDD") & " " & TimeString & ", " & StatusDesc(tmpStatus) '---add 2006/08/08
                            tmpstr = ShowDev2(i, DA2(i, 21))
                            VB6.SetItemString(lstDev, j, tmpstr)

                            UpdateDevListStatus(i) '---add 2006/08/08

                            Exit For
                        End If
                    Next j

                End If

            Else
                '---other messages are ignored
                Exit Sub
            End If
        End If

        Exit Sub

udpTest_DataArrival99:
        MsgBox2("udpTest_DataArrival() err=" & ErrorToString())
        Exit Sub
        Resume
    End Sub

    Sub InitialCmd()
        lstMsgT1.Items.Clear()
        lbDevCnt.Text = ""
        '    lbDevDownload.Caption = "" 'evan added 2007/10/19
        DevCount = 0


        lstMsgT2.Items.Clear()
        lbDevSetCnt.Text = ""
        DevSetCount = 0

        '
        '    lstMsgT3.Clear
        '    lbDevTestCnt.Caption = ""
        '    DevTestCount = 0
        '
        '
        '    lstMsgT4.Clear
        '    lbDevNormalCnt.Caption = ""
        '    DevNormalCount = 0


        '    lstMsgT5.Clear
        '    lbDevDefaultCnt.Caption = ""
        '    DevDefaultCount = 0

        '    lstMsgT6.Clear 'evan added 2007/10/19
        '    lbDevDownload.Caption = "" 'evan added 2007/10/19
        '    DevDefaultCount = 0 'evan added 2007/10/19

    End Sub

    Function StatusDesc(ByRef status As String) As String
        Dim tmpstr As String

        Select Case VB.Left(status, 4)
            Case "0101"
                tmpstr = "Flash ok"
            Case "1101"
                tmpstr = "Serial ok"
            Case "0102"
                tmpstr = "Flash failed"
            Case "2101"
                tmpstr = "Serial failed"
            Case Else
                tmpstr = "Unknown Status"
        End Select

        StatusDesc = tmpstr
    End Function

    Private Sub Command4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Command4.Click
        'Dim tp2 As Object
        'Dim tp1 As Object

        ''tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)

        ''UPGRADE_WARNING: 無法解析物件 tp1 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        ''If Model_name = "SE5016" Or Model_name = "SE5116" Then
        'tp1 = Shell(My.Computer.FileSystem.CurrentDirectory & "\" & "TCP_COM_CROSS_1_8.exe", 1)
        ''UPGRADE_WARNING: 無法解析物件 tp2 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'tp2 = Shell(My.Computer.FileSystem.CurrentDirectory & "\" & "TCP_COM_CROSS_9_16.exe", 1)
        ''End If
        ''FileClose()
        ''FileClose()
        Open_COMTest("CrossLoopback_v1") '---------add by Elle

    End Sub

    Private Sub cmdInvite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInvite.Click
        Dim file_no As Short
        Dim i, j As Short

        ProcStep = 0

        '-----Initial
        InitialCmd()

        Timer1.Enabled = False

        For j = 0 To DEVICE_MAX - 1
            For i = 0 To 2
                DA(j, i) = ""
            Next i

            For i = 0 To 20
                DA1(j, i) = ""
            Next i

            For i = 0 To 20
                DA2(j, i) = ""
            Next i
        Next j

        ShowDevStatus()

        '----- send UDP request to invite all devices------------------------------
        Dim bdata(300 - 1) As Byte

        On Error GoTo cmdInvite99

        '   sleep_doevents (300000)

        udpClient.Close()
        udpClient.LocalPort = UDP_INVITE_PORT
        udpClient.Bind()

        udpTest.Close()
        udpTest.LocalPort = UDP_TEST_PORT
        udpTest.Bind()

        Timer1.Interval = 3000
        Timer1.Enabled = True
        Timer1_Tick(Timer1, New System.EventArgs())

        Exit Sub

cmdInvite99:
        MsgBox2("cmdInvite() err=" & ErrorToString())
    End Sub

    Private Sub cmdTemp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTemp.Click
        Dim tp_temp As Object

        'UPGRADE_WARNING: 無法解析物件 tp_temp 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tp_temp = Shell(My.Computer.FileSystem.CurrentDirectory & "\" & "temp_clean_tool_v1.0.exe", 1)

    End Sub

    Private Sub cmdArp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArp.Click
        Dim tp_arp As Object

        'UPGRADE_WARNING: 無法解析物件 tp_arp 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        tp_arp = Shell(My.Computer.FileSystem.CurrentDirectory & "\" & "arp_clean_tool_v1.0.exe", 1)
    End Sub

    Private Sub cmdChgIP_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChgIP.Click
        Dim i As Short
        Dim tmpstr As String

        On Error GoTo cmdChgIP_Click99

        clean_arp() 'evan added 2007/10/23

        cmdToCmdFile.Enabled = True
        ProcStep = 1
        DevSetCount = 0


        ClearDevStatus() '---add 2006/08/08
        ShowDevStatus()

        lstMsgT2.Items.Clear()
        lbDevSetCnt.Text = ""

        For i = 0 To DevCount - 1
            If DA2(i, 5) = DA2(i, 13) And DA2(i, 6) = DA2(i, 14) Then
                '        If DA2(I, 5) = DA2(I, 13) And DA2(I, 6) = DA2(I, 14) Then   '---last 2 bytes, mac=ip
                DevSetCount = DevSetCount + 1 '---this is configured ip
                Me.cmdStartTest.Enabled = True

                'MsgBoxT2 DA2(i, 0) & "---" & DA2(i, 1) & "---" & DA2(i, 2) & "---" & "OK"
                DA2(i, 21) = "Change IP OK" '---add 2006/08/08
                tmpstr = ShowDev(i)
                MsgBoxT2(tmpstr)

                UpdateDevListStatus(i) '---add 2006/08/08
            Else
                SendConfig(i) '---set to new unique IP
            End If
        Next i

        Me.lbDevSetCnt.Text = CStr(DevSetCount)

        Timer1.Interval = 10000
        Timer1.Enabled = True
        'Timer1_Timer

        Exit Sub

cmdChgIP_Click99:
        MsgBox2("cmdChgIP_Click() err=" & ErrorToString())
        Exit Sub
        Resume
    End Sub
    Function Open_COMTest(ByRef comtest As String) As String '---------user will operate exe
        Dim tp As Object
        Dim windows, conn, changenum, i, last As Object
        Dim fillblank As Short '---------add by Elle
        Dim IP As Object
        Dim LoopCom1_Com8 As String
        Dim source As String
        'Dim fs As New Scripting.FileSystemObject

        On Error GoTo ErrorHandle

        source = My.Computer.FileSystem.CurrentDirectory & "\Device_parameter\" & comtest & ".exe"
        LoopCom1_Com8 = My.Application.Info.DirectoryPath & "\" & comtest & ".exe"



        If My.Computer.FileSystem.FileExists(LoopCom1_Com8) Then
            'If fs.FileExists(LoopCom1_Com8) Then
        Else
            My.Computer.FileSystem.CopyFile(source, LoopCom1_Com8)
            '	fs.CopyFile(source, LoopCom1_Com8)
        End If
        'UPGRADE_WARNING: 無法解析物件 conn 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        conn = 0 '----initual
        'UPGRADE_WARNING: 無法解析物件 IP 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        IP = "" '----initual


        Select Case COMs

            Case 1
                fillblank = 8 '------count the connections
            Case 2
                fillblank = 4 '------count the connections
            Case 4
                fillblank = 2 '------count the connections
            Case 8
                fillblank = 1 '------count the connections
            Case 16
                fillblank = 1 '------count the connections
            Case 32
                fillblank = 1 '------count the connections
        End Select

        '-----below for more than 8 port------------
        If COMs = 16 Then '---------the most 8 connections in a window

            windows = fillblank * Val(lbDevCnt.Text)
        ElseIf COMs = 32 Then

            windows = fillblank * Val(lbDevCnt.Text)
        Else

            windows = COMs * Val(lbDevCnt.Text) / 8 '---number of connection / a max windows (All connections are more than 8 connections)


            If COMs * Val(lbDevCnt.Text) Mod 8 > 0 Then '----all connections are less than 8 connections

                windows = -Int(CDbl(-windows))
            End If
        End If
        '-----upper for more than 8 port------------

        'UPGRADE_WARNING: 無法解析物件 windows 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        For i = 1 To windows

            If COMs = 16 Then '----SE5416 / SE5016

                For changenum = conn To fillblank * i - 1

                    IP = "-" & DA2(changenum, 0)
                Next changenum

                conn = conn + fillblank

                RetVal(changenum) = Shell(LoopCom1_Com8 & " " & IP & " 0", 1)
                FileClose()

                RetVal(changenum) = Shell(LoopCom1_Com8 & " " & IP & " 8", 1)
                FileClose()
            ElseIf COMs = 32 Then

                For changenum = conn To fillblank * i - 1

                    IP = "-" & DA2(changenum, 0)
                Next changenum

                conn = conn + fillblank

                RetVal(changenum) = Shell(LoopCom1_Com8 & " " & IP & " 0", 1)
                FileClose()

                RetVal(changenum) = Shell(LoopCom1_Com8 & " " & IP & " 8", 1)
                FileClose()

                RetVal(changenum) = Shell(LoopCom1_Com8 & " " & IP & " 16", 1)
                FileClose()

                RetVal(changenum) = Shell(LoopCom1_Com8 & " " & IP & " 24", 1)
                FileClose()
            Else

                If windows = 1 Then
                    For changenum = 0 To Val(lbDevCnt.Text) - 1

                        IP = IP & "-" & DA2(changenum, 0)
                    Next changenum

                    RetVal(changenum) = Shell(LoopCom1_Com8 & " " & IP, 1)
                    FileClose()
                Else

                    If Val(lbDevCnt.Text) - (conn + 1) < fillblank Then '-----last device are less than fill_blank

                        For last = conn To Val(lbDevCnt.Text) - 1

                            IP = IP & "-" & DA2(last, 0)
                        Next last
                    Else

                        For changenum = conn To fillblank * i - 1

                            IP = IP & "-" & DA2(changenum, 0)
                        Next changenum

                    End If

                    conn = conn + fillblank

                    RetVal(changenum) = Shell(LoopCom1_Com8 & " " & IP, 1)
                    FileClose()
                End If

            End If


            IP = ""
        Next i

        Exit Function

ErrorHandle:
        MsgBox("Open_COMTest= " & ErrorToString())
    End Function

    Private Sub Frame1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Frame1.Enter

    End Sub
End Class