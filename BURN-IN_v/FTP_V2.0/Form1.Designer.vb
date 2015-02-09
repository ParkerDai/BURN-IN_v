<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmtcp
#Region "Windows Form 設計工具產生的程式碼 "
	<System.Diagnostics.DebuggerNonUserCode()> Public Sub New()
		MyBase.New()
		'此為 Windows Form 設計工具所需的呼叫。
		InitializeComponent()
	End Sub
	'Form 覆寫 Dispose 以清除元件清單。
	<System.Diagnostics.DebuggerNonUserCode()> Protected Overloads Overrides Sub Dispose(ByVal Disposing As Boolean)
		If Disposing Then
			If Not components Is Nothing Then
				components.Dispose()
			End If
		End If
		MyBase.Dispose(Disposing)
	End Sub
	'為 Windows Form 設計工具的必要項
	Private components As System.ComponentModel.IContainer
	Public ToolTip1 As System.Windows.Forms.ToolTip
	Public WithEvents cmdToCmdAPFile As System.Windows.Forms.Button
	Public WithEvents cmdDefault As System.Windows.Forms.Button
	Public WithEvents cmdCallFTP As System.Windows.Forms.Button
	Public WithEvents Timer55 As System.Windows.Forms.Timer
	Public WithEvents txtUser As System.Windows.Forms.TextBox
	Public WithEvents txtPass As System.Windows.Forms.TextBox
	Public WithEvents cmdDownload As System.Windows.Forms.Button
	Public WithEvents cmdConnect As System.Windows.Forms.Button
	Public WithEvents cmdDisconnect As System.Windows.Forms.Button
	Public WithEvents Inet1 As AxInetCtlsObjects.AxInet
	Public WithEvents cmdCalltest As System.Windows.Forms.Button
	Public WithEvents cmdFTP As System.Windows.Forms.Button
	Public WithEvents lstDev As System.Windows.Forms.ListBox
	Public WithEvents cmdToCmdFile As System.Windows.Forms.Button
	Public WithEvents lstMsgT5 As System.Windows.Forms.ListBox
	Public WithEvents lstMsgT4 As System.Windows.Forms.ListBox
	Public WithEvents cmdStartTest As System.Windows.Forms.Button
	Public WithEvents lstMsg As System.Windows.Forms.ListBox
	Public WithEvents lstMsgT3 As System.Windows.Forms.ListBox
    Public WithEvents cmdStopTest As System.Windows.Forms.Button
	Public WithEvents lstMsgT2 As System.Windows.Forms.ListBox
	Public WithEvents Timer3 As System.Windows.Forms.Timer
	Public WithEvents lstMsgT1 As System.Windows.Forms.ListBox
	Public WithEvents Timer2 As System.Windows.Forms.Timer
	Public WithEvents udpTest As AxMSWinsockLib.AxWinsock
	Public WithEvents Timer1 As System.Windows.Forms.Timer
    Public WithEvents udpClient As AxMSWinsockLib.AxWinsock
	Public WithEvents tcpClient As AxMSWinsockLib.AxWinsock
	Public WithEvents lstMsgT6 As System.Windows.Forms.ListBox
	Public WithEvents lbDevDefaultCnt As System.Windows.Forms.Label
	Public WithEvents lblUser As System.Windows.Forms.Label
	Public WithEvents lblPassword As System.Windows.Forms.Label
	Public WithEvents lbDevDownload As System.Windows.Forms.Label
	Public WithEvents lbDevNormalCnt As System.Windows.Forms.Label
	Public WithEvents lbDevTestCnt As System.Windows.Forms.Label
	Public WithEvents lbSelDevMAC As System.Windows.Forms.Label
	Public WithEvents lbSelDevIP As System.Windows.Forms.Label
    '注意: 以下為 Windows Form 設計工具所需的程序
    '可以使用 Windows Form 設計工具進行修改。
    '請不要使用程式碼編輯器進行修改。
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmtcp))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cmdToCmdAPFile = New System.Windows.Forms.Button
        Me.cmdDefault = New System.Windows.Forms.Button
        Me.cmdCallFTP = New System.Windows.Forms.Button
        Me.Timer55 = New System.Windows.Forms.Timer(Me.components)
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.cmdDownload = New System.Windows.Forms.Button
        Me.cmdConnect = New System.Windows.Forms.Button
        Me.cmdDisconnect = New System.Windows.Forms.Button
        Me.cmdCalltest = New System.Windows.Forms.Button
        Me.cmdFTP = New System.Windows.Forms.Button
        Me.lstDev = New System.Windows.Forms.ListBox
        Me.cmdToCmdFile = New System.Windows.Forms.Button
        Me.lstMsgT5 = New System.Windows.Forms.ListBox
        Me.lstMsgT4 = New System.Windows.Forms.ListBox
        Me.cmdStartTest = New System.Windows.Forms.Button
        Me.lstMsg = New System.Windows.Forms.ListBox
        Me.lstMsgT3 = New System.Windows.Forms.ListBox
        Me.cmdStopTest = New System.Windows.Forms.Button
        Me.lstMsgT2 = New System.Windows.Forms.ListBox
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.lstMsgT1 = New System.Windows.Forms.ListBox
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lstMsgT6 = New System.Windows.Forms.ListBox
        Me.lbDevDefaultCnt = New System.Windows.Forms.Label
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.lbDevDownload = New System.Windows.Forms.Label
        Me.lbDevNormalCnt = New System.Windows.Forms.Label
        Me.lbDevTestCnt = New System.Windows.Forms.Label
        Me.lbSelDevMAC = New System.Windows.Forms.Label
        Me.lbSelDevIP = New System.Windows.Forms.Label
        Me.cdlFileOpen = New System.Windows.Forms.OpenFileDialog
        Me.Command4 = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.cmdInvite = New System.Windows.Forms.Button
        Me.cmdChgIP = New System.Windows.Forms.Button
        Me.Button3 = New System.Windows.Forms.Button
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbDevSetCnt = New System.Windows.Forms.Label
        Me.lbDevCnt = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdTemp = New System.Windows.Forms.Button
        Me.cmdArp = New System.Windows.Forms.Button
        Me.Frame4 = New System.Windows.Forms.GroupBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Inet1 = New AxInetCtlsObjects.AxInet
        Me.udpTest = New AxMSWinsockLib.AxWinsock
        Me.udpClient = New AxMSWinsockLib.AxWinsock
        Me.tcpClient = New AxMSWinsockLib.AxWinsock
        Me.Frame1.SuspendLayout()
        Me.Frame4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.Inet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udpTest, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.udpClient, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tcpClient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdToCmdAPFile
        '
        Me.cmdToCmdAPFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdToCmdAPFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdToCmdAPFile.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdToCmdAPFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdToCmdAPFile.Location = New System.Drawing.Point(9, 87)
        Me.cmdToCmdAPFile.Name = "cmdToCmdAPFile"
        Me.cmdToCmdAPFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdToCmdAPFile.Size = New System.Drawing.Size(197, 33)
        Me.cmdToCmdAPFile.TabIndex = 32
        Me.cmdToCmdAPFile.Text = "To Cmd File (AP)"
        Me.cmdToCmdAPFile.UseVisualStyleBackColor = False
        '
        'cmdDefault
        '
        Me.cmdDefault.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdDefault.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDefault.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDefault.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDefault.Location = New System.Drawing.Point(345, 153)
        Me.cmdDefault.Name = "cmdDefault"
        Me.cmdDefault.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDefault.Size = New System.Drawing.Size(145, 49)
        Me.cmdDefault.TabIndex = 9
        Me.cmdDefault.Text = "Set to Default"
        Me.cmdDefault.UseVisualStyleBackColor = False
        Me.cmdDefault.Visible = False
        '
        'cmdCallFTP
        '
        Me.cmdCallFTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCallFTP.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCallFTP.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCallFTP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCallFTP.Location = New System.Drawing.Point(7, 115)
        Me.cmdCallFTP.Name = "cmdCallFTP"
        Me.cmdCallFTP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCallFTP.Size = New System.Drawing.Size(221, 49)
        Me.cmdCallFTP.TabIndex = 31
        Me.cmdCallFTP.Text = "Call FTP tool"
        Me.cmdCallFTP.UseVisualStyleBackColor = False
        '
        'Timer55
        '
        Me.Timer55.Interval = 1
        '
        'txtUser
        '
        Me.txtUser.AcceptsReturn = True
        Me.txtUser.BackColor = System.Drawing.SystemColors.Window
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtUser.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtUser.Location = New System.Drawing.Point(392, 528)
        Me.txtUser.MaxLength = 0
        Me.txtUser.Name = "txtUser"
        Me.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUser.Size = New System.Drawing.Size(81, 27)
        Me.txtUser.TabIndex = 28
        Me.txtUser.Text = "admin"
        Me.txtUser.Visible = False
        '
        'txtPass
        '
        Me.txtPass.AcceptsReturn = True
        Me.txtPass.BackColor = System.Drawing.SystemColors.Window
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.txtPass.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPass.Location = New System.Drawing.Point(392, 560)
        Me.txtPass.MaxLength = 0
        Me.txtPass.Name = "txtPass"
        Me.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPass.Size = New System.Drawing.Size(81, 27)
        Me.txtPass.TabIndex = 27
        Me.txtPass.Visible = False
        '
        'cmdDownload
        '
        Me.cmdDownload.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDownload.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDownload.Enabled = False
        Me.cmdDownload.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdDownload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDownload.Location = New System.Drawing.Point(128, 536)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDownload.Size = New System.Drawing.Size(49, 33)
        Me.cmdDownload.TabIndex = 26
        Me.cmdDownload.Text = "載入測試檔案"
        Me.cmdDownload.UseVisualStyleBackColor = False
        Me.cmdDownload.Visible = False
        '
        'cmdConnect
        '
        Me.cmdConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConnect.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConnect.Location = New System.Drawing.Point(160, 528)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConnect.Size = New System.Drawing.Size(123, 40)
        Me.cmdConnect.TabIndex = 25
        Me.cmdConnect.Text = "開始"
        Me.cmdConnect.UseVisualStyleBackColor = False
        Me.cmdConnect.Visible = False
        '
        'cmdDisconnect
        '
        Me.cmdDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdDisconnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDisconnect.Enabled = False
        Me.cmdDisconnect.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.cmdDisconnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDisconnect.Location = New System.Drawing.Point(16, 528)
        Me.cmdDisconnect.Name = "cmdDisconnect"
        Me.cmdDisconnect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDisconnect.Size = New System.Drawing.Size(123, 40)
        Me.cmdDisconnect.TabIndex = 24
        Me.cmdDisconnect.Text = "中斷"
        Me.cmdDisconnect.UseVisualStyleBackColor = False
        Me.cmdDisconnect.Visible = False
        '
        'cmdCalltest
        '
        Me.cmdCalltest.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdCalltest.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdCalltest.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCalltest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdCalltest.Location = New System.Drawing.Point(7, 37)
        Me.cmdCalltest.Name = "cmdCalltest"
        Me.cmdCalltest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdCalltest.Size = New System.Drawing.Size(106, 33)
        Me.cmdCalltest.TabIndex = 22
        Me.cmdCalltest.Text = "Loopback Test"
        Me.cmdCalltest.UseVisualStyleBackColor = False
        '
        'cmdFTP
        '
        Me.cmdFTP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.cmdFTP.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdFTP.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdFTP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdFTP.Location = New System.Drawing.Point(344, 152)
        Me.cmdFTP.Name = "cmdFTP"
        Me.cmdFTP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdFTP.Size = New System.Drawing.Size(145, 49)
        Me.cmdFTP.TabIndex = 20
        Me.cmdFTP.Text = "Download test file"
        Me.cmdFTP.UseVisualStyleBackColor = False
        Me.cmdFTP.Visible = False
        '
        'lstDev
        '
        Me.lstDev.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lstDev.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstDev.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lstDev.ForeColor = System.Drawing.Color.Blue
        Me.lstDev.ItemHeight = 12
        Me.lstDev.Location = New System.Drawing.Point(8, 8)
        Me.lstDev.Name = "lstDev"
        Me.lstDev.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstDev.Size = New System.Drawing.Size(329, 436)
        Me.lstDev.Sorted = True
        Me.lstDev.TabIndex = 19
        '
        'cmdToCmdFile
        '
        Me.cmdToCmdFile.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdToCmdFile.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdToCmdFile.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdToCmdFile.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdToCmdFile.Location = New System.Drawing.Point(9, 29)
        Me.cmdToCmdFile.Name = "cmdToCmdFile"
        Me.cmdToCmdFile.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdToCmdFile.Size = New System.Drawing.Size(197, 33)
        Me.cmdToCmdFile.TabIndex = 18
        Me.cmdToCmdFile.Text = "To Cmd File (Kernel)"
        Me.cmdToCmdFile.UseVisualStyleBackColor = False
        '
        'lstMsgT5
        '
        Me.lstMsgT5.BackColor = System.Drawing.SystemColors.Window
        Me.lstMsgT5.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstMsgT5.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMsgT5.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstMsgT5.ItemHeight = 16
        Me.lstMsgT5.Location = New System.Drawing.Point(32, 320)
        Me.lstMsgT5.Name = "lstMsgT5"
        Me.lstMsgT5.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstMsgT5.Size = New System.Drawing.Size(273, 68)
        Me.lstMsgT5.TabIndex = 16
        Me.lstMsgT5.Visible = False
        '
        'lstMsgT4
        '
        Me.lstMsgT4.BackColor = System.Drawing.SystemColors.Window
        Me.lstMsgT4.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstMsgT4.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMsgT4.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstMsgT4.ItemHeight = 16
        Me.lstMsgT4.Location = New System.Drawing.Point(256, 440)
        Me.lstMsgT4.Name = "lstMsgT4"
        Me.lstMsgT4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstMsgT4.Size = New System.Drawing.Size(65, 20)
        Me.lstMsgT4.TabIndex = 13
        Me.lstMsgT4.Visible = False
        '
        'cmdStartTest
        '
        Me.cmdStartTest.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStartTest.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStartTest.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStartTest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStartTest.Location = New System.Drawing.Point(16, 408)
        Me.cmdStartTest.Name = "cmdStartTest"
        Me.cmdStartTest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStartTest.Size = New System.Drawing.Size(145, 25)
        Me.cmdStartTest.TabIndex = 11
        Me.cmdStartTest.Text = "Start Testing"
        Me.cmdStartTest.UseVisualStyleBackColor = False
        Me.cmdStartTest.Visible = False
        '
        'lstMsg
        '
        Me.lstMsg.BackColor = System.Drawing.SystemColors.Window
        Me.lstMsg.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstMsg.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lstMsg.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstMsg.ItemHeight = 12
        Me.lstMsg.Location = New System.Drawing.Point(8, 488)
        Me.lstMsg.Name = "lstMsg"
        Me.lstMsg.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstMsg.Size = New System.Drawing.Size(561, 64)
        Me.lstMsg.TabIndex = 10
        Me.lstMsg.Visible = False
        '
        'lstMsgT3
        '
        Me.lstMsgT3.BackColor = System.Drawing.SystemColors.Window
        Me.lstMsgT3.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstMsgT3.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMsgT3.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstMsgT3.ItemHeight = 16
        Me.lstMsgT3.Location = New System.Drawing.Point(256, 408)
        Me.lstMsgT3.Name = "lstMsgT3"
        Me.lstMsgT3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstMsgT3.Size = New System.Drawing.Size(65, 20)
        Me.lstMsgT3.TabIndex = 7
        Me.lstMsgT3.Visible = False
        '
        'cmdStopTest
        '
        Me.cmdStopTest.BackColor = System.Drawing.SystemColors.Control
        Me.cmdStopTest.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdStopTest.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdStopTest.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdStopTest.Location = New System.Drawing.Point(16, 440)
        Me.cmdStopTest.Name = "cmdStopTest"
        Me.cmdStopTest.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdStopTest.Size = New System.Drawing.Size(145, 25)
        Me.cmdStopTest.TabIndex = 4
        Me.cmdStopTest.Text = "Stop Testing"
        Me.cmdStopTest.UseVisualStyleBackColor = False
        Me.cmdStopTest.Visible = False
        '
        'lstMsgT2
        '
        Me.lstMsgT2.BackColor = System.Drawing.SystemColors.Window
        Me.lstMsgT2.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstMsgT2.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMsgT2.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstMsgT2.ItemHeight = 16
        Me.lstMsgT2.Location = New System.Drawing.Point(8, 96)
        Me.lstMsgT2.Name = "lstMsgT2"
        Me.lstMsgT2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstMsgT2.Size = New System.Drawing.Size(273, 68)
        Me.lstMsgT2.TabIndex = 3
        Me.lstMsgT2.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 1
        '
        'lstMsgT1
        '
        Me.lstMsgT1.BackColor = System.Drawing.SystemColors.Window
        Me.lstMsgT1.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstMsgT1.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstMsgT1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstMsgT1.ItemHeight = 16
        Me.lstMsgT1.Location = New System.Drawing.Point(8, 16)
        Me.lstMsgT1.Name = "lstMsgT1"
        Me.lstMsgT1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstMsgT1.Size = New System.Drawing.Size(273, 68)
        Me.lstMsgT1.Sorted = True
        Me.lstMsgT1.TabIndex = 2
        Me.lstMsgT1.Visible = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'lstMsgT6
        '
        Me.lstMsgT6.BackColor = System.Drawing.SystemColors.Window
        Me.lstMsgT6.Cursor = System.Windows.Forms.Cursors.Default
        Me.lstMsgT6.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lstMsgT6.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstMsgT6.ItemHeight = 15
        Me.lstMsgT6.Location = New System.Drawing.Point(8, 176)
        Me.lstMsgT6.Name = "lstMsgT6"
        Me.lstMsgT6.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lstMsgT6.Size = New System.Drawing.Size(273, 64)
        Me.lstMsgT6.TabIndex = 23
        Me.lstMsgT6.Visible = False
        '
        'lbDevDefaultCnt
        '
        Me.lbDevDefaultCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lbDevDefaultCnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDevDefaultCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbDevDefaultCnt.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDevDefaultCnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDevDefaultCnt.Location = New System.Drawing.Point(496, 152)
        Me.lbDevDefaultCnt.Name = "lbDevDefaultCnt"
        Me.lbDevDefaultCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbDevDefaultCnt.Size = New System.Drawing.Size(73, 49)
        Me.lbDevDefaultCnt.TabIndex = 17
        Me.lbDevDefaultCnt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbDevDefaultCnt.Visible = False
        '
        'lblUser
        '
        Me.lblUser.BackColor = System.Drawing.SystemColors.Control
        Me.lblUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUser.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUser.Location = New System.Drawing.Point(296, 528)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUser.Size = New System.Drawing.Size(89, 25)
        Me.lblUser.TabIndex = 30
        Me.lblUser.Text = "User Name:"
        Me.lblUser.Visible = False
        '
        'lblPassword
        '
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Control
        Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassword.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPassword.Location = New System.Drawing.Point(312, 560)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassword.Size = New System.Drawing.Size(81, 17)
        Me.lblPassword.TabIndex = 29
        Me.lblPassword.Text = "Password:"
        Me.lblPassword.Visible = False
        '
        'lbDevDownload
        '
        Me.lbDevDownload.BackColor = System.Drawing.SystemColors.Control
        Me.lbDevDownload.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDevDownload.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbDevDownload.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDevDownload.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDevDownload.Location = New System.Drawing.Point(496, 152)
        Me.lbDevDownload.Name = "lbDevDownload"
        Me.lbDevDownload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbDevDownload.Size = New System.Drawing.Size(73, 49)
        Me.lbDevDownload.TabIndex = 21
        Me.lbDevDownload.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lbDevDownload.Visible = False
        '
        'lbDevNormalCnt
        '
        Me.lbDevNormalCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lbDevNormalCnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDevNormalCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbDevNormalCnt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDevNormalCnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbDevNormalCnt.Location = New System.Drawing.Point(176, 440)
        Me.lbDevNormalCnt.Name = "lbDevNormalCnt"
        Me.lbDevNormalCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbDevNormalCnt.Size = New System.Drawing.Size(73, 25)
        Me.lbDevNormalCnt.TabIndex = 15
        Me.lbDevNormalCnt.Visible = False
        '
        'lbDevTestCnt
        '
        Me.lbDevTestCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lbDevTestCnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDevTestCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbDevTestCnt.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDevTestCnt.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbDevTestCnt.Location = New System.Drawing.Point(176, 408)
        Me.lbDevTestCnt.Name = "lbDevTestCnt"
        Me.lbDevTestCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbDevTestCnt.Size = New System.Drawing.Size(73, 25)
        Me.lbDevTestCnt.TabIndex = 14
        Me.lbDevTestCnt.Visible = False
        '
        'lbSelDevMAC
        '
        Me.lbSelDevMAC.BackColor = System.Drawing.SystemColors.Control
        Me.lbSelDevMAC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSelDevMAC.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbSelDevMAC.Font = New System.Drawing.Font("新細明體", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.lbSelDevMAC.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbSelDevMAC.Location = New System.Drawing.Point(360, 552)
        Me.lbSelDevMAC.Name = "lbSelDevMAC"
        Me.lbSelDevMAC.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbSelDevMAC.Size = New System.Drawing.Size(177, 33)
        Me.lbSelDevMAC.TabIndex = 12
        Me.lbSelDevMAC.Visible = False
        '
        'lbSelDevIP
        '
        Me.lbSelDevIP.BackColor = System.Drawing.SystemColors.Control
        Me.lbSelDevIP.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbSelDevIP.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbSelDevIP.Font = New System.Drawing.Font("Times New Roman", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSelDevIP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lbSelDevIP.Location = New System.Drawing.Point(248, 552)
        Me.lbSelDevIP.Name = "lbSelDevIP"
        Me.lbSelDevIP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbSelDevIP.Size = New System.Drawing.Size(105, 33)
        Me.lbSelDevIP.TabIndex = 8
        Me.lbSelDevIP.Visible = False
        '
        'Command4
        '
        Me.Command4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Command4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Command4.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Command4.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Command4.Location = New System.Drawing.Point(122, 36)
        Me.Command4.Name = "Command4"
        Me.Command4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Command4.Size = New System.Drawing.Size(106, 33)
        Me.Command4.TabIndex = 50
        Me.Command4.Text = "Cross Test"
        Me.Command4.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.BackColor = System.Drawing.SystemColors.Control
        Me.Frame1.Controls.Add(Me.txtPassword)
        Me.Frame1.Controls.Add(Me.cmdInvite)
        Me.Frame1.Controls.Add(Me.cmdChgIP)
        Me.Frame1.Controls.Add(Me.Button3)
        Me.Frame1.Controls.Add(Me.Label3)
        Me.Frame1.Controls.Add(Me.lbDevSetCnt)
        Me.Frame1.Controls.Add(Me.lbDevCnt)
        Me.Frame1.Controls.Add(Me.Label4)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Frame1.Location = New System.Drawing.Point(341, 16)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(235, 113)
        Me.Frame1.TabIndex = 51
        Me.Frame1.TabStop = False
        Me.Frame1.Text = " Device Setting "
        '
        'txtPassword
        '
        Me.txtPassword.AcceptsReturn = True
        Me.txtPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPassword.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPassword.Location = New System.Drawing.Point(160, 152)
        Me.txtPassword.MaxLength = 0
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPassword.Size = New System.Drawing.Size(65, 32)
        Me.txtPassword.TabIndex = 52
        Me.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtPassword.Visible = False
        '
        'cmdInvite
        '
        Me.cmdInvite.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdInvite.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdInvite.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdInvite.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdInvite.Location = New System.Drawing.Point(8, 32)
        Me.cmdInvite.Name = "cmdInvite"
        Me.cmdInvite.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdInvite.Size = New System.Drawing.Size(145, 33)
        Me.cmdInvite.TabIndex = 29
        Me.cmdInvite.Text = "INVITE"
        Me.cmdInvite.UseVisualStyleBackColor = False
        '
        'cmdChgIP
        '
        Me.cmdChgIP.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdChgIP.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdChgIP.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdChgIP.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdChgIP.Location = New System.Drawing.Point(8, 72)
        Me.cmdChgIP.Name = "cmdChgIP"
        Me.cmdChgIP.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdChgIP.Size = New System.Drawing.Size(145, 33)
        Me.cmdChgIP.TabIndex = 28
        Me.cmdChgIP.Text = "Change IP"
        Me.cmdChgIP.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Button3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button3.Enabled = False
        Me.Button3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button3.Location = New System.Drawing.Point(8, 112)
        Me.Button3.Name = "Button3"
        Me.Button3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button3.Size = New System.Drawing.Size(145, 33)
        Me.Button3.TabIndex = 27
        Me.Button3.Text = "Set to Default"
        Me.Button3.UseVisualStyleBackColor = False
        Me.Button3.Visible = False
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label3.Location = New System.Drawing.Point(48, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(97, 25)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Password :"
        Me.Label3.Visible = False
        '
        'lbDevSetCnt
        '
        Me.lbDevSetCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lbDevSetCnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDevSetCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbDevSetCnt.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDevSetCnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDevSetCnt.Location = New System.Drawing.Point(160, 72)
        Me.lbDevSetCnt.Name = "lbDevSetCnt"
        Me.lbDevSetCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbDevSetCnt.Size = New System.Drawing.Size(65, 33)
        Me.lbDevSetCnt.TabIndex = 34
        Me.lbDevSetCnt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbDevCnt
        '
        Me.lbDevCnt.BackColor = System.Drawing.SystemColors.Control
        Me.lbDevCnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbDevCnt.Cursor = System.Windows.Forms.Cursors.Default
        Me.lbDevCnt.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbDevCnt.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbDevCnt.Location = New System.Drawing.Point(160, 32)
        Me.lbDevCnt.Name = "lbDevCnt"
        Me.lbDevCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbDevCnt.Size = New System.Drawing.Size(65, 33)
        Me.lbDevCnt.TabIndex = 31
        Me.lbDevCnt.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.SystemColors.Control
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Enabled = False
        Me.Label4.Font = New System.Drawing.Font("Arial", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(160, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(65, 33)
        Me.Label4.TabIndex = 30
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Label4.Visible = False
        '
        'cmdTemp
        '
        Me.cmdTemp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdTemp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdTemp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdTemp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdTemp.Location = New System.Drawing.Point(122, 76)
        Me.cmdTemp.Name = "cmdTemp"
        Me.cmdTemp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdTemp.Size = New System.Drawing.Size(106, 33)
        Me.cmdTemp.TabIndex = 53
        Me.cmdTemp.Text = "Temp Clean"
        Me.cmdTemp.UseVisualStyleBackColor = False
        '
        'cmdArp
        '
        Me.cmdArp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdArp.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdArp.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdArp.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdArp.Location = New System.Drawing.Point(7, 76)
        Me.cmdArp.Name = "cmdArp"
        Me.cmdArp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdArp.Size = New System.Drawing.Size(106, 33)
        Me.cmdArp.TabIndex = 52
        Me.cmdArp.Text = "ARP Clean"
        Me.cmdArp.UseVisualStyleBackColor = False
        '
        'Frame4
        '
        Me.Frame4.BackColor = System.Drawing.SystemColors.Control
        Me.Frame4.Controls.Add(Me.GroupBox1)
        Me.Frame4.Controls.Add(Me.cmdCalltest)
        Me.Frame4.Controls.Add(Me.cmdTemp)
        Me.Frame4.Controls.Add(Me.cmdCallFTP)
        Me.Frame4.Controls.Add(Me.cmdArp)
        Me.Frame4.Controls.Add(Me.Command4)
        Me.Frame4.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Frame4.Location = New System.Drawing.Point(344, 140)
        Me.Frame4.Name = "Frame4"
        Me.Frame4.Padding = New System.Windows.Forms.Padding(0)
        Me.Frame4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame4.Size = New System.Drawing.Size(235, 306)
        Me.Frame4.TabIndex = 56
        Me.Frame4.TabStop = False
        Me.Frame4.Text = " Application"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Controls.Add(Me.cmdToCmdFile)
        Me.GroupBox1.Controls.Add(Me.cmdToCmdAPFile)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GroupBox1.Location = New System.Drawing.Point(6, 174)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(0)
        Me.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GroupBox1.Size = New System.Drawing.Size(219, 129)
        Me.GroupBox1.TabIndex = 54
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = " Download FW"
        '
        'Inet1
        '
        Me.Inet1.Enabled = True
        Me.Inet1.Location = New System.Drawing.Point(528, 408)
        Me.Inet1.Name = "Inet1"
        Me.Inet1.OcxState = CType(resources.GetObject("Inet1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Inet1.Size = New System.Drawing.Size(38, 38)
        Me.Inet1.TabIndex = 33
        '
        'udpTest
        '
        Me.udpTest.Enabled = True
        Me.udpTest.Location = New System.Drawing.Point(456, 408)
        Me.udpTest.Name = "udpTest"
        Me.udpTest.OcxState = CType(resources.GetObject("udpTest.OcxState"), System.Windows.Forms.AxHost.State)
        Me.udpTest.Size = New System.Drawing.Size(28, 28)
        Me.udpTest.TabIndex = 34
        '
        'udpClient
        '
        Me.udpClient.Enabled = True
        Me.udpClient.Location = New System.Drawing.Point(424, 408)
        Me.udpClient.Name = "udpClient"
        Me.udpClient.OcxState = CType(resources.GetObject("udpClient.OcxState"), System.Windows.Forms.AxHost.State)
        Me.udpClient.Size = New System.Drawing.Size(28, 28)
        Me.udpClient.TabIndex = 35
        '
        'tcpClient
        '
        Me.tcpClient.Enabled = True
        Me.tcpClient.Location = New System.Drawing.Point(488, 408)
        Me.tcpClient.Name = "tcpClient"
        Me.tcpClient.OcxState = CType(resources.GetObject("tcpClient.OcxState"), System.Windows.Forms.AxHost.State)
        Me.tcpClient.Size = New System.Drawing.Size(28, 28)
        Me.tcpClient.TabIndex = 36
        '
        'frmtcp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(588, 491)
        Me.Controls.Add(Me.Frame4)
        Me.Controls.Add(Me.Frame1)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.cmdDefault)
        Me.Controls.Add(Me.cmdDisconnect)
        Me.Controls.Add(Me.Inet1)
        Me.Controls.Add(Me.lstDev)
        Me.Controls.Add(Me.lstMsgT5)
        Me.Controls.Add(Me.lstMsgT4)
        Me.Controls.Add(Me.cmdStartTest)
        Me.Controls.Add(Me.lstMsg)
        Me.Controls.Add(Me.lstMsgT3)
        Me.Controls.Add(Me.cmdStopTest)
        Me.Controls.Add(Me.lstMsgT2)
        Me.Controls.Add(Me.lstMsgT1)
        Me.Controls.Add(Me.udpTest)
        Me.Controls.Add(Me.udpClient)
        Me.Controls.Add(Me.tcpClient)
        Me.Controls.Add(Me.lstMsgT6)
        Me.Controls.Add(Me.lbDevDefaultCnt)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.lbDevDownload)
        Me.Controls.Add(Me.lbDevNormalCnt)
        Me.Controls.Add(Me.lbDevTestCnt)
        Me.Controls.Add(Me.lbSelDevMAC)
        Me.Controls.Add(Me.lbSelDevIP)
        Me.Controls.Add(Me.cmdFTP)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Font = New System.Drawing.Font("新細明體", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.Location = New System.Drawing.Point(100, 100)
        Me.MaximizeBox = False
        Me.Name = "frmtcp"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CPU:POWERPC_5200 ORT-TEST V1.0 (for 10.0.50.x / 192.168.x.x )"
        Me.Frame1.ResumeLayout(False)
        Me.Frame1.PerformLayout()
        Me.Frame4.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.Inet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udpTest, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.udpClient, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tcpClient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents cdlFileOpen As System.Windows.Forms.OpenFileDialog
    Public WithEvents Command4 As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents txtPassword As System.Windows.Forms.TextBox
    Public WithEvents cmdInvite As System.Windows.Forms.Button
    Public WithEvents cmdChgIP As System.Windows.Forms.Button
    Public WithEvents Button3 As System.Windows.Forms.Button
    Public WithEvents Label3 As System.Windows.Forms.Label
    Public WithEvents lbDevSetCnt As System.Windows.Forms.Label
    Public WithEvents lbDevCnt As System.Windows.Forms.Label
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents cmdTemp As System.Windows.Forms.Button
    Public WithEvents cmdArp As System.Windows.Forms.Button
    Public WithEvents Frame4 As System.Windows.Forms.GroupBox
    Public WithEvents GroupBox1 As System.Windows.Forms.GroupBox
#End Region
End Class