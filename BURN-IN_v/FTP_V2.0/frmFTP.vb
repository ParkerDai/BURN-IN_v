Option Strict Off
Option Explicit On
Friend Class frmFTP
	Inherits System.Windows.Forms.Form
	Dim terminal1 As Boolean
	Dim test_page_counter As Short
	Dim test_rs232_flag As Short
	Const comm_output_delay As Short = 800 'evan 50 800
	Dim settint_page_counter As Integer
	Dim get_data As String
	Dim next_mac_string As String
	Dim module1_option As String
	Dim module2_option As String
	Dim module1_oen_port_option As String
	Dim module2_oen_port_option As String
	Dim ip1 As String
	Dim ip2 As String
	Dim ip3 As String
	Dim ip4 As String
	Dim lan1_timer As Short
	Dim lan_timer As Short
	Dim ur_timer As Short
	Dim time_flg As Boolean
	Dim timer5_flg As Boolean
	Dim xx As Short
	Dim strOper As String
	Dim dl_counter As Short
	Dim timer55_flg As Boolean
	Dim testcount As Short
	Dim ftpconn As Short
    Dim RcvCnt As Integer
    Dim DevCnt As Short
    Dim hInternet As Integer 'simon
    Dim hConnect As Integer 'simon
    Dim dwInternetFlags As Integer 'simon
    Dim download_Continuous As Boolean = True 'simon
    Dim delate_Continuos As Boolean = True 'simon
    Dim dev_num As Short
    Dim getip() As String
    Dim Model_name As String

    Dim tcp_server_232 As String
    Dim tcp_server_422 As String
    Dim tcp_server_485 As String
    Dim rs232_download As Boolean


    Private Sub atop_timer(ByRef input_time As Short)

        'UPGRADE_WARNING: 計時器屬性 Timer2.Interval 其值不可以為零。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
        Timer2.Interval = input_time
        Timer2.Enabled = True
        time_flg = False


        'UPGRADE_WARNING: 計時器屬性 Timer11.Interval 其值不可以為零。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="169ECF4A-1968-402D-B243-16603CC08604"'
        Timer11.Interval = input_time
        Timer11.Enabled = True
        time_flg = False

        Do
            System.Windows.Forms.Application.DoEvents()
            System.Windows.Forms.Application.DoEvents()
        Loop Until time_flg = True

    End Sub

    Private Sub cmdConnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdConnect.Click
        Dim tftp As Object
        'Dim tcp_server As String
        'tftp = Shell("C:\Program Files\SolarWinds\Free Tools\TFTP-Server.exe", 1)
        On Error GoTo ConError

        If cmbModelname.Text = String.Empty Then
            Exit Sub
        End If

        download_Continuous = True

        cmdConnect.Enabled = False
        cmdEnd.Enabled = False
        If RadioButton3.Checked = True Then

        Else
            If InStr(Model_name, "SE5016") Or InStr(Model_name, "SE5116") Or InStr(Model_name, "SE5302") Or InStr(Model_name, "SE5404") Or InStr(Model_name, "SE7416") Then
                rs232_download = True
                tcp_server_232 = "tcp_server232_idt"
                tcp_server_422 = "tcp_server422_idt"
                tcp_server_485 = "tcp_server485_idt"
            ElseIf InStr(Model_name, "MB5416") Then
                rs232_download = False
                tcp_server_232 = "tcp_server232_idt"
                tcp_server_422 = "tcp_server422_idt"
                tcp_server_485 = "tcp_server485_idt"
            ElseIf InStr(Model_name, "SE7202") Or InStr(Model_name, "SE7404") Or InStr(Model_name, "SE7402") Or InStr(Model_name, "SE1402") Then
                rs232_download = False
                tcp_server_422 = "tcp_server422_idt2"
                tcp_server_485 = "tcp_server485_idt2"
            ElseIf InStr(Model_name, "C1402") Or InStr(Model_name, "C1502") Then
                rs232_download = True
                tcp_server_232 = "tcp_server232_c1x02"
                tcp_server_422 = "tcp_server422_c1x02"
                tcp_server_485 = "tcp_server485_c1x02"
            ElseIf InStr(Model_name, "SE5516") Or InStr(Model_name, "SE1504") Then
                rs232_download = True
                tcp_server_232 = "tcp_server232_5200"
                tcp_server_422 = "tcp_server422_5200"
                tcp_server_485 = "tcp_server485_5200"
            ElseIf InStr(Model_name, "SE7816-256M") Then
                rs232_download = True
                tcp_server_232 = "tcp_server232_256m"
                tcp_server_422 = "tcp_server422_256m"
                tcp_server_485 = "tcp_server485_256m"
            ElseIf InStr(Model_name, "SE7816-512M") Or InStr(Model_name, "SE7116") Then
                rs232_download = True
                tcp_server_232 = "tcp_server232_512m"
                tcp_server_422 = "tcp_server422_512m"
                tcp_server_485 = "tcp_server485_512m"
            ElseIf InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then
                rs232_download = True
                tcp_server_232 = "atop_tcp_server232se190X131022"
                tcp_server_422 = ""
                tcp_server_485 = "atop_tcp_server485se190X131022"

                'ElseIf InStr(Model_name, "GW21S-256") Or InStr(Model_name, "GW21S-MEGA") Or InStr(Model_name, "GW2204S-MEGAV2") Or InStr(Model_name, "GW2208S-MEGAV2") Then
                '    tcp_server = "tcp_server_es3200"
                'ElseIf InStr(Model_name, "CE5101") Then
                '    tcp_server = "tcp_server_rdc"
                'ElseIf InStr(Model_name, "SE7202") Or InStr(Model_name, "SE7404") Or InStr(Model_name, "SE7402") Then
                '    rs232_download = False
                '    tcp_server_422 = "tcp_server422_idt"
                '    tcp_server_485 = "tcp_server485_idt"
            Else
                MsgBox("FTP Download不支援此型號:" & Model_name, MsgBoxStyle.Exclamation)
                ListBox1.Items.Clear()
                cmdConnect.Enabled = True
                cmdEnd.Enabled = True
                Exit Sub
            End If
        End If

        For dev_num = 1 To DevCnt
            'System.Windows.Forms.Application.DoEvents()
            hInternet = InternetOpen("FTP Application", INTERNET_OPEN_TYPE_DIRECT, Nothing, Nothing, INTERNET_FLAG_NO_CACHE_WRITE)
            ' If Internet Session Handle created OK
            ListBox1.Items.Clear()
            ListBox1.Items.Add(getip(dev_num) & "連線中...")
            System.Windows.Forms.Application.DoEvents()
            If (hInternet <> 0) Then
                ' FTP Service Handle
                If (txtUser.Text = "") And (txtPass.Text = "") Then
                    ' anonymous
                    hConnect = InternetConnect(hInternet, getip(dev_num), INTERNET_DEFAULT_FTP_PORT, Nothing, Nothing, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
                Else
                    hConnect = InternetConnect(hInternet, getip(dev_num), INTERNET_DEFAULT_FTP_PORT, txtUser.Text, txtPass.Text, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
                End If

                ' If internet connection created OK
                If (hConnect <> 0) Then
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add(getip(dev_num) & "載入檔案中...")
                    ftpconn = 1
                    If InStr(Model_name, "SE5302") Then
                        FtpSetCurrentDirectory(hConnect, "/flash")
                    ElseIf InStr(Model_name, "SE5516") Or InStr(Model_name, "SE1504") Or InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then
                        FtpSetCurrentDirectory(hConnect, "/mnt/jffs2")
                    Else
                        FtpSetCurrentDirectory(hConnect, "/jffs2")
                    End If
                    dwInternetFlags = FTP_TRANSFER_TYPE_BINARY
                    cmdDownload_Click(cmdDownload, New System.EventArgs())
                    If download_Continuous = False Then
                        cmdConnect.Enabled = True
                        cmdEnd.Enabled = True
                        InternetCloseHandle(hConnect)
                        hConnect = 0
                        InternetCloseHandle(hInternet)
                        hInternet = 0
                        Exit Sub
                    End If
                Else
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add(getip(dev_num) & "連線失敗!")
                    If dev_num <> DevCnt Then
                        If MsgBox("Service Session Error: " & getip(dev_num) & "連線失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                            'Timer1.Enabled = False
                        Else
                            cmdConnect.Enabled = True
                            cmdEnd.Enabled = True
                            Exit Sub
                        End If
                    Else
                        MsgBox("Service Session Error: " & getip(dev_num) & "連線失敗!", MsgBoxStyle.Exclamation)
                        cmdConnect.Enabled = True
                        cmdEnd.Enabled = True
                        Exit Sub
                    End If
                End If
            Else
                ListBox1.Items.Clear()
                ListBox1.Items.Add(getip(dev_num) & "連線失敗!")
                If dev_num <> DevCnt Then
                    If MsgBox("Internet Session Error: " & getip(dev_num) & "連線失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                        'Timer1.Enabled = False
                    Else
                        cmdConnect.Enabled = True
                        cmdEnd.Enabled = True
                        Exit Sub
                    End If
                Else
                    MsgBox("Internet Session Error: " & getip(dev_num) & "連線失敗!", MsgBoxStyle.Exclamation)
                    cmdConnect.Enabled = True
                    cmdEnd.Enabled = True
                    Exit Sub
                End If
            End If
            InternetCloseHandle(hConnect)
            hConnect = 0
            InternetCloseHandle(hInternet)
            hInternet = 0
        Next
        cmdConnect.Enabled = True
        cmdEnd.Enabled = True

ConError:
        cmdConnect.Enabled = True
        cmdEnd.Enabled = True
        '        ftpconn = 0

        '        'Timer1.Enabled = True

        '        System.Windows.Forms.Application.DoEvents()
        '        hInternet = InternetOpen("FTP Application", INTERNET_OPEN_TYPE_DIRECT, Nothing, Nothing, INTERNET_FLAG_NO_CACHE_WRITE)
        '        ' If Internet Session Handle created OK
        '        If (hInternet <> 0) Then

        '            ' FTP Service Handle
        '            If (txtUser.Text = "") And (txtPass.Text = "") Then
        '                ' anonymous

        '                hConnect = InternetConnect(hInternet, txtFirstmappIp.Text, INTERNET_DEFAULT_FTP_PORT, Nothing, Nothing, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
        '            Else

        '                hConnect = InternetConnect(hInternet, txtFirstmappIp.Text, INTERNET_DEFAULT_FTP_PORT, txtUser.Text, txtPass.Text, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)

        '            End If

        '            ' If internet connection created OK
        '            If (hConnect <> 0) Then
        '                ftpconn = 1
        '                FtpSetCurrentDirectory(hConnect, "/mnt/jffs2")
        '                dwInternetFlags = FTP_TRANSFER_TYPE_BINARY
        '                cmdDownload_Click(cmdDownload, New System.EventArgs())

        '            Else
        '                MsgBox("Service Session Error: 連線失敗!")
        '                'Timer1.Enabled = False
        '                Exit Sub
        '            End If
        '        Else
        '            MsgBox("Internet Session Error: 連線失敗!")
        '            'Timer1.Enabled = False
        '            Exit Sub
        '        End If
        '        cmdDisconnect.Enabled = True

        '        'Timer1.Enabled = False

        '        '      ftpconn = 0
        '        'On Error GoTo ConError
        '		'    cmdConnect.Enabled = False

        '        'With Inet1
        '        '	.RemoteHost = txtFirstmappIp.Text
        '        '	.URL = txtFirstmappIp.Text
        '        '	.Protocol = InetCtlsObjects.ProtocolConstants.icFTP
        '        '	.UserName = txtUser.Text
        '        '	.Password = txtPass.Text
        '        'End With



        '        'strOper = "Dir"
        '        'Inet1.Execute( , strOper)
        '        '      hInternet = InternetOpen("FTP Application", INTERNET_OPEN_TYPE_DIRECT, Nothing, Nothing, INTERNET_FLAG_NO_CACHE_WRITE)
        '        '      hConnect = InternetConnect(hInternet, txtFirstmappIp.Text, INTERNET_DEFAULT_FTP_PORT, txtUser.Text, txtPass.Text, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
        '        '      FtpSetCurrentDirectory(hConnect, "/mnt/jffs2")
        '        '      dwInternetFlags = FTP_TRANSFER_TYPE_BINARY



        '        '      cmdDownload_Click(cmdDownload, New System.EventArgs())
        '        'Exit Sub

        'ConError: 
        '		'
        '		'    MsgBox "無法與" & txtFirstmappIp.Text & "取得連線！"
        '		'    cmdConnect.Caption = "與待測物連線"
        '		'    cmdConnect.Enabled = True
        '		'    cmdDisconnect.Enabled = True
    End Sub

    Private Sub cmdDisconnect_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDisconnect.Click
        On Error GoTo ConError
        For dev_num = 0 To DevCnt
            ftpconn = 0
            If (hConnect <> 0) Then
                InternetCloseHandle(hConnect)
                hConnect = 0
            End If

            ' close internet session
            If (hInternet <> 0) Then
                InternetCloseHandle(hInternet)
                hInternet = 0
            End If

        Next
        cmdDisconnect.Enabled = False
        cmdConnect.Enabled = True

ConError:
    End Sub

    Private Sub cmdDownload_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDownload.Click
        Dim FtpPutFile_flag1 As Boolean = True    'user.sh
        Dim FtpPutFile_flag2 As Boolean = True    'rs232
        Dim FtpPutFile_flag3 As Boolean = True    'rs422
        Dim FtpPutFile_flag4 As Boolean = True    'rs485
        Dim FtpPutFile_flag5 As Boolean = True
        Dim FtpPutFile_flag6 As Boolean = True
        Dim FtpPutFile_flag7 As Boolean = True
        Dim FtpPutFile_flag8 As Boolean = True


        'Dim tcp_server As String
        'While ftpconn = 0
        '	System.Windows.Forms.Application.DoEvents()
        'End While
        ' cmdConnect.Enabled = False
        strOper = "GetFile"
        'Inet1.Execute( , "Put user.sh /mnt/jffs2/user.sh")

        If RadioButton3.Checked = True Then
            FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\se7816_cpu_burnin", "se7816_cpu_burnin", dwInternetFlags, 0)
            FtpPutFile_flag2 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\se7816_cpu_burnin.sh", "user.sh", dwInternetFlags, 0)
            If FtpPutFile_flag1 = False Or FtpPutFile_flag2 = False Then
                ListBox1.Items.Clear()
                ListBox1.Items.Add(getip(dev_num) & " 測試檔案載入失敗!")
                If dev_num <> DevCnt Then
                    If MsgBox(getip(dev_num) & " 測試檔案載入失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then

                    Else
                        'ListBox1.Items.Clear()
                        'ListBox1.Items.Add(getip(dev_num) & "檔案載入失敗!")
                        download_Continuous = False
                        Exit Sub
                    End If
                Else
                    MsgBox("Service Session Error: " & getip(dev_num) & " 測試檔案載入失敗!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If

        Else
            If InStr(Model_name, "SE7816-512M") Or InStr(Model_name, "SE7116") Then
                If RadioButton2.Checked = True Then
                    FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\nsc330_rs485_burnin_user.sh", "user.sh", dwInternetFlags, 0)
                    FtpPutFile_flag6 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & "330test", "330test", dwInternetFlags, 0)
                    FtpPutFile_flag7 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & "env.sh", "env.sh", dwInternetFlags, 0)
                    FtpPutFile_flag8 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & "profile", "profile", dwInternetFlags, 0)

                ElseIf RadioButton1.Checked = True Then    '2013/03 Rs422改成跑Rs485
                    FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\nsc330_rs485_burnin_user.sh", "user.sh", dwInternetFlags, 0)
                End If
                FtpPutFile_flag5 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\atop_cantcpsvr", "atop_cantcpsvr", dwInternetFlags, 0)
            Else
                If RadioButton2.Checked = True Then
                    'If InStr(Model_name, "SE7202") Or InStr(Model_name, "SE7404") Or InStr(Model_name, "SE7402") Then
                    '    FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\rs485_filter_user.sh", "user.sh", dwInternetFlags, 0)
                    'Else
                    If InStr(Model_name, "MB5416") Then
                    Else
                        FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\rs485_burnin_user.sh", "user.sh", dwInternetFlags, 0)
                    End If
                ElseIf RadioButton1.Checked = True Then
                    If InStr(Model_name, "SE1402") Then    '2013/03 Rs422改成跑Rs485
                        FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\rs485_filter_user.sh", "user.sh", dwInternetFlags, 0)
                    ElseIf InStr(Model_name, "SE7202") Or InStr(Model_name, "SE7404") Or InStr(Model_name, "SE7402") Then
                        FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\rs485_filter_user.sh", "user.sh", dwInternetFlags, 0)
                    ElseIf InStr(Model_name, "MB5416") Then
                        FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\mb5416_burnin_user.sh", "user.sh", dwInternetFlags, 0)
                    ElseIf InStr(Model_name, "SE7816-512M") Or InStr(Model_name, "SE7116") Then
                        FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\rs485_burnin_user_can.sh", "user.sh", dwInternetFlags, 0)   '2013/03     SE7816-512M增加跑Canbus
                    ElseIf InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then
                        FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\3352_user.sh", "user.sh", dwInternetFlags, 0)
                    Else
                        FtpPutFile_flag1 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\rs485_burnin_user.sh", "user.sh", dwInternetFlags, 0)
                    End If
                End If
            End If

            If rs232_download = True Then
                If InStr(Model_name, "SE7816-512M") Or InStr(Model_name, "SE7116") Then
                    FtpPutFile_flag2 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_232, "atop_tcp_server232512110808", dwInternetFlags, 0)
                ElseIf InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then
                    FtpPutFile_flag2 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_232, "tcp_server232", dwInternetFlags, 0)
                Else
                    FtpPutFile_flag2 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_232, "tcp_server232", dwInternetFlags, 0)
                End If
            End If

            If InStr(Model_name, "SE7816-512M") Or InStr(Model_name, "SE7116") Then
                FtpPutFile_flag3 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_422, "atop_tcp_server422512110808", dwInternetFlags, 0)
                FtpPutFile_flag4 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_485, "atop_tcp_server485512110808", dwInternetFlags, 0)
            ElseIf InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then
                FtpPutFile_flag3 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_422, "", dwInternetFlags, 0)
                FtpPutFile_flag4 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_485, "tcp_server485", dwInternetFlags, 0)
            Else
                If InStr(Model_name, "MB5416") Then
                    If RadioButton1.Checked = True Then
                        FtpPutFile_flag3 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_422, "tcp_server422", dwInternetFlags, 0)
                    End If
                Else
                    FtpPutFile_flag3 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_422, "tcp_server422", dwInternetFlags, 0)
                    FtpPutFile_flag4 = FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\" & tcp_server_485, "tcp_server485", dwInternetFlags, 0)
                End If
            End If

            If InStr(Model_name, "SE7816-512M") Or InStr(Model_name, "SE7116") Then
                If FtpPutFile_flag1 = False Or (rs232_download = True And FtpPutFile_flag2 = False) Or FtpPutFile_flag3 = False Or FtpPutFile_flag4 = False Or FtpPutFile_flag5 = False Or FtpPutFile_flag6 = False Or FtpPutFile_flag7 = False Or FtpPutFile_flag8 = False Then
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add(getip(dev_num) & " 測試檔案載入失敗!")

                    If dev_num <> DevCnt Then
                        If MsgBox(getip(dev_num) & " 測試檔案載入失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then

                        Else
                            'ListBox1.Items.Clear()
                            'ListBox1.Items.Add(getip(dev_num) & "檔案載入失敗!")
                            download_Continuous = False
                            Exit Sub
                        End If
                    Else
                        MsgBox("Service Session Error: " & getip(dev_num) & " 測試檔案載入失敗!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If
            ElseIf InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then    '暫時無rs422檔案需要載入，所以拿掉flag3
                If FtpPutFile_flag1 = False Or (rs232_download = True And FtpPutFile_flag2 = False) Or FtpPutFile_flag4 = False Then
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add(getip(dev_num) & " 測試檔案載入失敗!")

                    If dev_num <> DevCnt Then
                        If MsgBox(getip(dev_num) & " 測試檔案載入失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then

                        Else
                            'ListBox1.Items.Clear()
                            'ListBox1.Items.Add(getip(dev_num) & "檔案載入失敗!")
                            download_Continuous = False
                            Exit Sub
                        End If
                    Else
                        MsgBox("Service Session Error: " & getip(dev_num) & " 測試檔案載入失敗!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If
            Else
                If FtpPutFile_flag1 = False Or (rs232_download = True And FtpPutFile_flag2 = False) Or FtpPutFile_flag3 = False Or FtpPutFile_flag4 = False Then
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add(getip(dev_num) & " 測試檔案載入失敗!")

                    If dev_num <> DevCnt Then
                        If MsgBox(getip(dev_num) & " 測試檔案載入失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then

                        Else
                            'ListBox1.Items.Clear()
                            'ListBox1.Items.Add(getip(dev_num) & "檔案載入失敗!")
                            download_Continuous = False
                            Exit Sub
                        End If
                    Else
                        MsgBox("Service Session Error: " & getip(dev_num) & " 測試檔案載入失敗!", MsgBoxStyle.Exclamation)
                        Exit Sub
                    End If
                End If
            End If
        End If

        ListBox1.Items.Clear()
        ListBox1.Items.Add(getip(dev_num) & " 測試檔案載入完畢!")
        If dev_num = DevCnt Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("測試檔案已全部載入完畢，請將待測物電源重新開啟!")
        End If


        'MsgBox("檔案載入成功！請將待測物電源重新開啟!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "注意")

        'If FtpPutFile_flag = True Then
        'Else
        'End If
        '  atop_timer (800)
        ' Inet1.Execute , "Put atop_testd /mnt/jffs2/atop_testd"
        'atop_timer((800))

        'MsgBox "載入 user.sh 成功!", vbOKOnly + vbExclamation, "注意"
        'cmdDownload2_Click(cmdDownload2, New System.EventArgs())
    End Sub

    Private Sub cmdDownload2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdDownload2.Click
        'While ftpconn = 0
        '	System.Windows.Forms.Application.DoEvents()
        'End While

        ' cmdConnect.Enabled = False
        strOper = "GetFile"
        ' Inet1.Execute , "Put user.sh /mnt/jffs2/user.sh"
        '  atop_timer (800)
        FtpPutFile(hConnect, My.Computer.FileSystem.CurrentDirectory & "\atop_tcp_server", "atop_tcp_server", dwInternetFlags, 0)

        'Inet1.Execute(, "Put atop_tcp_server /mnt/jffs2/atop_tcp_server")
        'atop_timer (800)

        MsgBox("載入成功！請將待測物電源重新開啟!", MsgBoxStyle.OkOnly + MsgBoxStyle.Exclamation, "注意")
    End Sub

    Private Sub cmdEnd_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEnd.Click
        Dim FtpDelete_flag1, FtpDelete_flag2 As Boolean
        Dim i As Integer
        Dim tftp As Object
        Dim tmpfile As Object
        On Error GoTo ConError

        If cmbModelname.Text = String.Empty Then
            Exit Sub
        End If

        If MsgBox("確定是否要刪除檔案?", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.No Then
            Exit Sub
        End If
        delate_Continuos = True
        cmdConnect.Enabled = False
        cmdEnd.Enabled = False
        'If InStr(Model_name, "SE5016") Or InStr(Model_name, "SE5116") Or InStr(Model_name, "SE1402") Or InStr(Model_name, "SE5302") Or InStr(Model_name, "SE5404") Or InStr(Model_name, "SE7416") Then
        '    tcp_server = "tcp_server422_idt"

        'ElseIf InStr(Model_name, "SE5516") Or InStr(Model_name, "SE7816") Then
        '    tcp_server = "tcp_server422_powerpc"
        '    'ElseIf InStr(Model_name, "GW21S-256") Or InStr(Model_name, "GW21S-MEGA") Or InStr(Model_name, "GW2204S-MEGAV2") Or InStr(Model_name, "GW2208S-MEGAV2") Then
        '    '    tcp_server = "tcp_server_es3200"
        '    'ElseIf InStr(Model_name, "CE5101") Then
        '    '    tcp_server = "tcp_server_rdc"
        'ElseIf InStr(Model_name, "SE7202") Or InStr(Model_name, "SE7404") Or InStr(Model_name, "SE7402") Then
        '    tcp_server = "tcp_server485_idt"
        '    tcp_server = ""
        'Else
        '    MsgBox("FTP Download不支援此型號:" & Model_name, MsgBoxStyle.Question)
        '    ListBox1.Items.Clear()
        '    cmdConnect.Enabled = True
        '    cmdEnd.Enabled = True
        '    Exit Sub
        'End If


        If InStr(Model_name, "SE5516") Or InStr(Model_name, "SE1504") Or InStr(Model_name, "SE7816") Or InStr(Model_name, "SE7116") Or InStr(Model_name, "C1402") _
        Or InStr(Model_name, "C1502") Or InStr(Model_name, "SE5016") Or InStr(Model_name, "SE5116") Or InStr(Model_name, "SE5302") _
        Or InStr(Model_name, "SE5404") Or InStr(Model_name, "SE7416") Or InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then
            rs232_download = True
        ElseIf InStr(Model_name, "SE1402") Or InStr(Model_name, "SE7202") Or InStr(Model_name, "SE7404") Or InStr(Model_name, "SE7402") Or InStr(Model_name, "MB5416") Then
            rs232_download = False
        Else
            MsgBox("FTP Download不支援此型號:" & Model_name, MsgBoxStyle.Exclamation)
            ListBox1.Items.Clear()
            cmdConnect.Enabled = True
            cmdEnd.Enabled = True
            Exit Sub
        End If
        For dev_num = 1 To DevCnt
            System.Windows.Forms.Application.DoEvents()
            hInternet = InternetOpen("FTP Application", INTERNET_OPEN_TYPE_DIRECT, Nothing, Nothing, INTERNET_FLAG_NO_CACHE_WRITE)
            ' If Internet Session Handle created OK
            ListBox1.Items.Clear()
            ListBox1.Items.Add(getip(dev_num) & " 連線中...")
            If (hInternet <> 0) Then
                ' FTP Service Handle
                If (txtUser.Text = "") And (txtPass.Text = "") Then
                    ' anonymous
                    hConnect = InternetConnect(hInternet, getip(dev_num), INTERNET_DEFAULT_FTP_PORT, Nothing, Nothing, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
                Else
                    hConnect = InternetConnect(hInternet, getip(dev_num), INTERNET_DEFAULT_FTP_PORT, txtUser.Text, txtPass.Text, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
                End If
                ' If internet connection created OK
                If (hConnect <> 0) Then
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add(getip(dev_num) & " 刪除檔案中...")
                    ftpconn = 1
                    If InStr(Model_name, "SE5302") Then
                        FtpSetCurrentDirectory(hConnect, "/flash")
                    ElseIf InStr(Model_name, "SE5516") Or InStr(Model_name, "SE1504") Or InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then
                        FtpSetCurrentDirectory(hConnect, "/mnt/jffs2")
                    Else
                        FtpSetCurrentDirectory(hConnect, "/jffs2")
                    End If
                    dwInternetFlags = FTP_TRANSFER_TYPE_BINARY

                    cmdEnd2_Click(cmdEnd2, New System.EventArgs())
                    If delate_Continuos = False Then
                        cmdConnect.Enabled = True
                        cmdEnd.Enabled = True
                        InternetCloseHandle(hConnect)
                        hConnect = 0
                        InternetCloseHandle(hInternet)
                        hInternet = 0
                        Exit Sub
                    End If
                Else
                    ListBox1.Items.Clear()
                    ListBox1.Items.Add(getip(dev_num) & " 連線失敗!")
                    If dev_num <> DevCnt Then
                        If MsgBox("Service Session Error: " & getip(dev_num) & " 連線失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                            'Timer1.Enabled = False
                            'cmdConnect.Enabled = True
                        Else
                            cmdConnect.Enabled = True
                            cmdEnd.Enabled = True
                            Exit Sub
                        End If
                    Else
                        MsgBox("Service Session Error: " & getip(dev_num) & " 連線失敗!", MsgBoxStyle.Exclamation)
                        cmdConnect.Enabled = True
                        cmdEnd.Enabled = True
                        Exit Sub
                    End If
                End If

            Else
                ListBox1.Items.Clear()
                ListBox1.Items.Add(getip(dev_num) & "連線失敗!")
                If dev_num <> DevCnt Then
                    If MsgBox("Internet Session Error: " & getip(dev_num) & " 連線失敗!，您是否繼續下一台機器的連線?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                        'Timer1.Enabled = False
                    Else
                        cmdConnect.Enabled = True
                        cmdEnd.Enabled = True
                        Exit Sub
                    End If
                Else
                    MsgBox("Internet Session Error: " & getip(dev_num) & " 連線失敗!", MsgBoxStyle.Exclamation)
                    cmdConnect.Enabled = True
                    cmdEnd.Enabled = True
                    Exit Sub
                End If
            End If
            InternetCloseHandle(hConnect)
            hConnect = 0
            InternetCloseHandle(hInternet)
            hInternet = 0
        Next
        cmdConnect.Enabled = True
        cmdEnd.Enabled = True
        'cmdConnect.Enabled = True
        'ftpconn = 0
        'On Error GoTo ConError
        'hInternet = InternetOpen("FTP Application", INTERNET_OPEN_TYPE_DIRECT, Nothing, Nothing, INTERNET_FLAG_NO_CACHE_WRITE)
        '' If Internet Session Handle created OK
        'If (hInternet <> 0) Then

        '    ' FTP Service Handle
        '    If (txtUser.Text = "") And (txtPass.Text = "") Then
        '        ' anonymous

        '        hConnect = InternetConnect(hInternet, txtFirstmappIp.Text, INTERNET_DEFAULT_FTP_PORT, Nothing, Nothing, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
        '    Else
        '        hConnect = InternetConnect(hInternet, txtFirstmappIp.Text, INTERNET_DEFAULT_FTP_PORT, txtUser.Text, txtPass.Text, INTERNET_SERVICE_FTP, INTERNET_FLAG_EXISTING_CONNECT Or INTERNET_FLAG_PASSIVE, 0)
        '    End If

        '    ' If internet connection created OK
        '    If (hConnect <> 0) Then
        '        ftpconn = 1
        '        FtpSetCurrentDirectory(hConnect, "/mnt/jffs2")
        '        dwInternetFlags = FTP_TRANSFER_TYPE_BINARY
        '        FtpDeleteFile(hConnect, "user.sh")
        '        atop_timer((500))
        '        FtpDeleteFile(hConnect, "atop_tcp_server")

        '        FtpDeleteFile(hConnect, "")
        '        cmdEnd2_Click(cmdEnd2, New System.EventArgs())

        '    Else
        '        MsgBox("Service Session Error: 連線失敗!")
        '        Exit Sub
        '    End If
        'Else
        '    MsgBox("Internet Session Error: 連線失敗!")
        '    Exit Sub
        'End If
        'cmdDisconnect.Enabled = True

        ''      ftpconn = 0
        ''With Inet1
        ''	.RemoteHost = txtFirstmappIp.Text
        ''	.URL = txtFirstmappIp.Text
        ''	.Protocol = InetCtlsObjects.ProtocolConstants.icFTP
        ''	.UserName = txtUser.Text
        ''	.Password = txtPass.Text
        ''End With
        ''strOper = "Dir"
        ''Inet1.Execute( , strOper)

        ''While ftpconn = 0
        ''	System.Windows.Forms.Application.DoEvents()
        ''End While
        ''      FtpDeleteFile(hConnect, "user.sh")
        ''      'Inet1.Execute( , "Delete /mnt/jffs2/user.sh")
        ''atop_timer((800))
        ' ''Inet1.Execute , "Delete /mnt/jffs2/atop_tcp_server"
        ' ''atop_timer (600)
        ''cmdEnd2_Click(cmdEnd2, New System.EventArgs())

ConError:
    End Sub

    Private Sub Frame1_DragDrop(ByRef Source As System.Windows.Forms.Control, ByRef X As Single, ByRef Y As Single)

    End Sub

    Private Sub cmdEnd2_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdEnd2.Click
        Dim i As Integer
        Dim tftp As Object
        Dim tmpfile As Object
        Dim FtpDelete_flag1 As Boolean = True
        Dim FtpDelete_flag2 As Boolean = True
        Dim FtpDelete_flag3 As Boolean = True
        Dim FtpDelete_flag4 As Boolean = True
        Dim FtpDelete_flag5 As Boolean = True
        Dim FtpDelete_flag6 As Boolean = True
        Dim FtpDelete_flag7 As Boolean = True
        Dim FtpDelete_flag8 As Boolean = True
        On Error GoTo ConError

        If RadioButton3.Checked = True Then
            FtpDelete_flag1 = FtpDeleteFile(hConnect, "se7816_cpu_burnin")
            FtpDelete_flag2 = FtpDeleteFile(hConnect, "user.sh")
            If FtpDelete_flag1 = False Or FtpDelete_flag2 = False Then
                ListBox1.Items.Clear()
                ListBox1.Items.Add(getip(dev_num) & " 測試檔案刪除失敗!")
                If dev_num <> DevCnt Then
                    If MsgBox(getip(dev_num) & " 測試檔案刪除失敗!，您是否繼續下一台機器jffs2檔案的刪除?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    Else
                        'ListBox1.Items.Clear()
                        'ListBox1.Items.Add(getip(dev_num) & "檔案刪除失敗!")
                        delate_Continuos = False
                        Exit Sub
                    End If
                Else
                    MsgBox("Service Session Error: " & getip(dev_num) & " 測試檔案刪除失敗!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If

        ElseIf InStr(Model_name, "SE7816-512M") Or InStr(Model_name, "SE7116") Then
            FtpDelete_flag1 = FtpDeleteFile(hConnect, "user.sh")
            If rs232_download = True Then
                FtpDelete_flag2 = FtpDeleteFile(hConnect, "atop_tcp_server232512110808")
            End If
            FtpDelete_flag3 = FtpDeleteFile(hConnect, "atop_tcp_server422512110808")
            FtpDelete_flag4 = FtpDeleteFile(hConnect, "atop_tcp_server485512110808")
            FtpDelete_flag5 = FtpDeleteFile(hConnect, "atop_cantcpsvr")
            If RadioButton2.Checked = True Then
                FtpDelete_flag6 = FtpDeleteFile(hConnect, "330test")
                FtpDelete_flag7 = FtpDeleteFile(hConnect, "env.sh")
                FtpDelete_flag8 = FtpDeleteFile(hConnect, "profile")
            End If
            'MsgBox("1:" & FtpDelete_flag1 & "2:" & FtpDelete_flag2 & "3:" & FtpDelete_flag3 & "4:" & FtpDelete_flag4 & "5:" & FtpDelete_flag5 & "6:" & FtpDelete_flag6)
            If FtpDelete_flag1 = False Or (rs232_download = True And FtpDelete_flag2 = False) Or FtpDelete_flag3 = False Or FtpDelete_flag4 = False Or FtpDelete_flag5 = False Or FtpDelete_flag6 = False Or FtpDelete_flag7 = False Or FtpDelete_flag8 = False Then
                ListBox1.Items.Clear()
                ListBox1.Items.Add(getip(dev_num) & " 測試檔案刪除失敗!")
                If dev_num <> DevCnt Then
                    If MsgBox(getip(dev_num) & " 測試檔案刪除失敗!，您是否繼續下一台機器jffs2檔案的刪除?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    Else
                        'ListBox1.Items.Clear()
                        'ListBox1.Items.Add(getip(dev_num) & "檔案刪除失敗!")
                        delate_Continuos = False
                        Exit Sub
                    End If
                Else
                    MsgBox("Service Session Error: " & getip(dev_num) & " 測試檔案刪除失敗!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        ElseIf InStr(Model_name, "SE1904") Or InStr(Model_name, "SE1902") Then
            FtpDelete_flag1 = FtpDeleteFile(hConnect, "user.sh")
            If rs232_download = True Then
                FtpDelete_flag2 = FtpDeleteFile(hConnect, "tcp_server232")
            End If
            'FtpDelete_flag3 = FtpDeleteFile(hConnect, "tcp_server422")
            FtpDelete_flag4 = FtpDeleteFile(hConnect, "tcp_server485")
            If FtpDelete_flag1 = False Or (rs232_download = True And FtpDelete_flag2 = False) Or FtpDelete_flag4 = False Then
                ListBox1.Items.Clear()
                ListBox1.Items.Add(getip(dev_num) & " 測試檔案刪除失敗!")
                If dev_num <> DevCnt Then
                    If MsgBox(getip(dev_num) & " 測試檔案刪除失敗!，您是否繼續下一台機器jffs2檔案的刪除?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    Else
                        'ListBox1.Items.Clear()
                        'ListBox1.Items.Add(getip(dev_num) & "檔案刪除失敗!")
                        delate_Continuos = False
                        Exit Sub
                    End If
                Else
                    MsgBox("Service Session Error: " & getip(dev_num) & " 測試檔案刪除失敗!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        Else
            FtpDelete_flag1 = FtpDeleteFile(hConnect, "user.sh")
            If rs232_download = True Then
                FtpDelete_flag2 = FtpDeleteFile(hConnect, "tcp_server232")
            End If
            FtpDelete_flag3 = FtpDeleteFile(hConnect, "tcp_server422")
            If InStr(Model_name, "MB5416") Then
            Else
                FtpDelete_flag4 = FtpDeleteFile(hConnect, "tcp_server485")
            End If
            If FtpDelete_flag1 = False Or (rs232_download = True And FtpDelete_flag2 = False) Or FtpDelete_flag3 = False Or FtpDelete_flag4 = False Then
                ListBox1.Items.Clear()
                ListBox1.Items.Add(getip(dev_num) & " 測試檔案刪除失敗!")
                If dev_num <> DevCnt Then
                    If MsgBox(getip(dev_num) & " 測試檔案刪除失敗!，您是否繼續下一台機器jffs2檔案的刪除?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation) = MsgBoxResult.Yes Then
                    Else
                        'ListBox1.Items.Clear()
                        'ListBox1.Items.Add(getip(dev_num) & "檔案刪除失敗!")
                        delate_Continuos = False
                        Exit Sub
                    End If
                Else
                    MsgBox("Service Session Error: " & getip(dev_num) & " 測試檔案刪除失敗!", MsgBoxStyle.Exclamation)
                    Exit Sub
                End If
            End If
        End If

        ListBox1.Items.Clear()
        ListBox1.Items.Add(getip(dev_num) & " 測試檔案刪除完畢!")
        If dev_num = DevCnt Then
            ListBox1.Items.Clear()
            ListBox1.Items.Add("測試檔案已全部刪除完畢!")
        End If
        'cmdConnect.Enabled = True


        'ftpconn = 0
        'With Inet1
        '	.RemoteHost = txtFirstmappIp.Text
        '	.URL = txtFirstmappIp.Text
        '	.Protocol = InetCtlsObjects.ProtocolConstants.icFTP
        '	.UserName = txtUser.Text
        '	.Password = txtPass.Text
        'End With
        '      'strOper = "Dir"
        '      'Inet1.Execute( , strOper)

        ''  While ftpconn = 0
        ''  DoEvents
        ''  Wend

        ''Inet1.Execute , "Delete /mnt/jffs2/user.sh"
        'atop_timer((600))
        '      'Inet1.Execute( , "Delete /mnt/jffs2/atop_tcp_server")
        '      FtpDeleteFile(hConnect, "atop_tcp_server")
        '      atop_timer((600))
        'MsgBox("刪除檔案成功！", MsgBoxStyle.OKOnly + MsgBoxStyle.Exclamation, "注意")
ConError:
        Exit Sub
    End Sub

    Private Sub Inet1_StateChanged(ByVal eventSender As System.Object, ByVal eventArgs As AxInetCtlsObjects.DInetEvents_StateChangedEvent) Handles Inet1.StateChanged
        Select Case eventArgs.state

            Case 4
                cmdDownload.Enabled = True
                cmdDisconnect.Enabled = True
                txtFirstmappIp.Enabled = False
                txtUser.Enabled = False
                txtPass.Enabled = False
            Case 11
                '            If InStr(Inet1.ResponseInfo, "No such file") > 0 Or _
                ''                InStr(Inet1.ResponseInfo, "No such file or directory") Then
                '                txtReceivedataC.Text = "已清除測試檔案!"
                '            Else
                '                MsgBox Inet1.ResponseInfo
                '            End If
            Case 10
                cmdConnect.Enabled = True
                cmdDownload.Enabled = False
                cmdDisconnect.Enabled = False
                txtFirstmappIp.Enabled = False
                txtUser.Enabled = False
                txtPass.Enabled = False
            Case 12
                If LCase(strOper) = "dir" Then
                    '                InetGetDir
                    'MsgBox "已經與主機連線！"
                    ftpconn = 1
                    '                cmdConnect.Enabled = False
                    cmdDisconnect.Enabled = True
                End If
        End Select
        Debug.Print("狀態常數：" & eventArgs.state & " 訊息內容：" & Inet1.ResponseInfo)
    End Sub

    Private Sub Timer11_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer11.Tick
        time_flg = True
        Timer11.Enabled = False
    End Sub

    Private Sub Timer2_Tick(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles Timer2.Tick
        time_flg = True
        Timer2.Enabled = False
    End Sub

    Private Sub frmFTP_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim all_ip As String
        Dim Fileno As Object
        Try
            RadioButton1.Checked = True

            'Fileno = FreeFile()
            ''FileOpen(Fileno, My.Application.Info.DirectoryPath & "\Write_Model.txt", OpenMode.Input)
            'FileOpen(Fileno, My.Application.Info.DirectoryPath & "\Device_parameter" & "\write_model.txt", OpenMode.Input)
            'Model_name = LineInput(Fileno)
            'FileClose(Fileno)

            Fileno = FreeFile()
            FileOpen(Fileno, My.Application.Info.DirectoryPath & "\ftp_ip.ini", OpenMode.Input)
            all_ip = LineInput(Fileno)
            FileClose(Fileno)

            'all_ip = "-10.0.50.100"
            'all_ip = My.Application.CommandLineArgs(0)  '使用外部參數
            getip = Split(all_ip, "-")
            DevCnt = UBound(getip)

        Catch ex As ArgumentOutOfRangeException        '例外處理:索引超出範圍。必須為非負數且小於集合的大小。
            Console.WriteLine("Error: {0}", ex)
            MsgBox(ex.ToString, MsgBoxStyle.Exclamation)
        Finally
            Console.WriteLine("This statement is always executed.")
        End Try
    End Sub


    'Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
    '    System.Windows.Forms.Application.DoEvents()
    'End Sub

    Private Sub cmd_list_clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        ListBox1.Items.Clear()
    End Sub

    Private Sub cmbModelname_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbModelname.SelectedIndexChanged
        Model_name = cmbModelname.Text
    End Sub
End Class