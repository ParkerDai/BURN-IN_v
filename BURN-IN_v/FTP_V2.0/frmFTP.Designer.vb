<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmFTP
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
	Public WithEvents Timer11 As System.Windows.Forms.Timer
	Public WithEvents Timer2 As System.Windows.Forms.Timer
	Public WithEvents cmdEnd2 As System.Windows.Forms.Button
	Public WithEvents cmdDownload2 As System.Windows.Forms.Button
	Public WithEvents cmdDownload As System.Windows.Forms.Button
	Public WithEvents cmdConnect As System.Windows.Forms.Button
	Public WithEvents cmdDisconnect As System.Windows.Forms.Button
	Public WithEvents txtPass As System.Windows.Forms.TextBox
	Public WithEvents txtUser As System.Windows.Forms.TextBox
	Public WithEvents txtFirstmappIp As System.Windows.Forms.TextBox
	Public WithEvents cmdEnd As System.Windows.Forms.Button
	Public WithEvents Inet1 As AxInetCtlsObjects.AxInet
	Public WithEvents lblUser As System.Windows.Forms.Label
	Public WithEvents lblPassword As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	'注意: 以下為 Windows Form 設計工具所需的程序
	'可以使用 Windows Form 設計工具進行修改。
	'請不要使用程式碼編輯器進行修改。
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmFTP))
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Timer11 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.cmdEnd2 = New System.Windows.Forms.Button
        Me.cmdDownload2 = New System.Windows.Forms.Button
        Me.cmdDownload = New System.Windows.Forms.Button
        Me.cmdConnect = New System.Windows.Forms.Button
        Me.cmdDisconnect = New System.Windows.Forms.Button
        Me.txtPass = New System.Windows.Forms.TextBox
        Me.txtUser = New System.Windows.Forms.TextBox
        Me.txtFirstmappIp = New System.Windows.Forms.TextBox
        Me.cmdEnd = New System.Windows.Forms.Button
        Me.lblUser = New System.Windows.Forms.Label
        Me.lblPassword = New System.Windows.Forms.Label
        Me.Label18 = New System.Windows.Forms.Label
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.RadioButton1 = New System.Windows.Forms.RadioButton
        Me.RadioButton2 = New System.Windows.Forms.RadioButton
        Me.RadioButton3 = New System.Windows.Forms.RadioButton
        Me.Inet1 = New AxInetCtlsObjects.AxInet
        Me.cmbModelname = New System.Windows.Forms.ComboBox
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.Inet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer11
        '
        Me.Timer11.Interval = 1
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'cmdEnd2
        '
        Me.cmdEnd2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdEnd2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnd2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnd2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnd2.Location = New System.Drawing.Point(16, 277)
        Me.cmdEnd2.Name = "cmdEnd2"
        Me.cmdEnd2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnd2.Size = New System.Drawing.Size(81, 33)
        Me.cmdEnd2.TabIndex = 11
        Me.cmdEnd2.Text = "刪除檔案"
        Me.cmdEnd2.UseVisualStyleBackColor = False
        Me.cmdEnd2.Visible = False
        '
        'cmdDownload2
        '
        Me.cmdDownload2.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDownload2.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDownload2.Enabled = False
        Me.cmdDownload2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDownload2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDownload2.Location = New System.Drawing.Point(103, 280)
        Me.cmdDownload2.Name = "cmdDownload2"
        Me.cmdDownload2.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDownload2.Size = New System.Drawing.Size(25, 33)
        Me.cmdDownload2.TabIndex = 10
        Me.cmdDownload2.Text = "載入測試檔案"
        Me.cmdDownload2.UseVisualStyleBackColor = False
        Me.cmdDownload2.Visible = False
        '
        'cmdDownload
        '
        Me.cmdDownload.BackColor = System.Drawing.SystemColors.Control
        Me.cmdDownload.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDownload.Enabled = False
        Me.cmdDownload.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDownload.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDownload.Location = New System.Drawing.Point(198, 179)
        Me.cmdDownload.Name = "cmdDownload"
        Me.cmdDownload.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDownload.Size = New System.Drawing.Size(25, 33)
        Me.cmdDownload.TabIndex = 9
        Me.cmdDownload.Text = "載入測試檔案"
        Me.cmdDownload.UseVisualStyleBackColor = False
        Me.cmdDownload.Visible = False
        '
        'cmdConnect
        '
        Me.cmdConnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmdConnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdConnect.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdConnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdConnect.Location = New System.Drawing.Point(37, 130)
        Me.cmdConnect.Name = "cmdConnect"
        Me.cmdConnect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdConnect.Size = New System.Drawing.Size(98, 32)
        Me.cmdConnect.TabIndex = 8
        Me.cmdConnect.Text = "載入檔案"
        Me.cmdConnect.UseVisualStyleBackColor = False
        '
        'cmdDisconnect
        '
        Me.cmdDisconnect.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdDisconnect.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdDisconnect.Enabled = False
        Me.cmdDisconnect.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdDisconnect.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdDisconnect.Location = New System.Drawing.Point(382, 281)
        Me.cmdDisconnect.Name = "cmdDisconnect"
        Me.cmdDisconnect.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdDisconnect.Size = New System.Drawing.Size(98, 32)
        Me.cmdDisconnect.TabIndex = 7
        Me.cmdDisconnect.Text = "中斷連線"
        Me.cmdDisconnect.UseVisualStyleBackColor = False
        '
        'txtPass
        '
        Me.txtPass.AcceptsReturn = True
        Me.txtPass.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPass.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtPass.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPass.Location = New System.Drawing.Point(333, 87)
        Me.txtPass.MaxLength = 0
        Me.txtPass.Name = "txtPass"
        Me.txtPass.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPass.Size = New System.Drawing.Size(88, 26)
        Me.txtPass.TabIndex = 4
        Me.txtPass.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtUser
        '
        Me.txtUser.AcceptsReturn = True
        Me.txtUser.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtUser.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUser.Location = New System.Drawing.Point(120, 87)
        Me.txtUser.MaxLength = 0
        Me.txtUser.Name = "txtUser"
        Me.txtUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtUser.Size = New System.Drawing.Size(88, 26)
        Me.txtUser.TabIndex = 3
        Me.txtUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFirstmappIp
        '
        Me.txtFirstmappIp.AcceptsReturn = True
        Me.txtFirstmappIp.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtFirstmappIp.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtFirstmappIp.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstmappIp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtFirstmappIp.Location = New System.Drawing.Point(234, 284)
        Me.txtFirstmappIp.MaxLength = 0
        Me.txtFirstmappIp.Name = "txtFirstmappIp"
        Me.txtFirstmappIp.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFirstmappIp.Size = New System.Drawing.Size(121, 26)
        Me.txtFirstmappIp.TabIndex = 1
        Me.txtFirstmappIp.Text = "10.0.50.100"
        Me.txtFirstmappIp.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmdEnd
        '
        Me.cmdEnd.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmdEnd.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdEnd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEnd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdEnd.Location = New System.Drawing.Point(156, 130)
        Me.cmdEnd.Name = "cmdEnd"
        Me.cmdEnd.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdEnd.Size = New System.Drawing.Size(98, 33)
        Me.cmdEnd.TabIndex = 0
        Me.cmdEnd.Text = "刪除檔案"
        Me.cmdEnd.UseVisualStyleBackColor = False
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.SystemColors.Control
        Me.lblUser.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblUser.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblUser.Location = New System.Drawing.Point(15, 90)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblUser.Size = New System.Drawing.Size(99, 19)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "User Name:"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.BackColor = System.Drawing.SystemColors.Control
        Me.lblPassword.Cursor = System.Windows.Forms.Cursors.Default
        Me.lblPassword.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPassword.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblPassword.Location = New System.Drawing.Point(235, 90)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblPassword.Size = New System.Drawing.Size(92, 19)
        Me.lblPassword.TabIndex = 5
        Me.lblPassword.Text = "Password:"
        '
        'Label18
        '
        Me.Label18.BackColor = System.Drawing.SystemColors.Control
        Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label18.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(203, 288)
        Me.Label18.Name = "Label18"
        Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label18.Size = New System.Drawing.Size(25, 25)
        Me.Label18.TabIndex = 2
        Me.Label18.Text = "IP:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(205, 325)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 12)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Label1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(200, 313)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 12)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Label2"
        '
        'ListBox1
        '
        Me.ListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ListBox1.Font = New System.Drawing.Font("新細明體", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(12, 177)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(429, 68)
        Me.ListBox1.TabIndex = 15
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(37, 55)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(109, 16)
        Me.RadioButton1.TabIndex = 16
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Burn-In檔案載入"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(152, 55)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(95, 16)
        Me.RadioButton2.TabIndex = 17
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "出廠檔案載入"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(253, 55)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(148, 16)
        Me.RadioButton3.TabIndex = 18
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "SE7816 CPU_Burnin載入"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Inet1
        '
        Me.Inet1.Enabled = True
        Me.Inet1.Location = New System.Drawing.Point(156, 280)
        Me.Inet1.Name = "Inet1"
        Me.Inet1.OcxState = CType(resources.GetObject("Inet1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Inet1.Size = New System.Drawing.Size(38, 38)
        Me.Inet1.TabIndex = 12
        '
        'cmbModelname
        '
        Me.cmbModelname.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.cmbModelname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbModelname.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbModelname.FormattingEnabled = True
        Me.cmbModelname.Items.AddRange(New Object() {"C1402", "C1502", "MB5416", "SE1402", "SE1504", "SE1902", "SE1904", "SE5016", "SE5116", "SE5302", "SE5404", "SE5516", "SE7116", "SE7202", "SE7402", "SE7404", "SE7416", "SE7816-256M", "SE7816-512M"})
        Me.cmbModelname.Location = New System.Drawing.Point(133, 12)
        Me.cmbModelname.Name = "cmbModelname"
        Me.cmbModelname.Size = New System.Drawing.Size(202, 27)
        Me.cmbModelname.Sorted = True
        Me.cmbModelname.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 19)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Model name :"
        '
        'frmFTP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(455, 257)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbModelname)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdEnd2)
        Me.Controls.Add(Me.cmdDownload2)
        Me.Controls.Add(Me.cmdDownload)
        Me.Controls.Add(Me.cmdConnect)
        Me.Controls.Add(Me.cmdDisconnect)
        Me.Controls.Add(Me.txtPass)
        Me.Controls.Add(Me.txtUser)
        Me.Controls.Add(Me.txtFirstmappIp)
        Me.Controls.Add(Me.cmdEnd)
        Me.Controls.Add(Me.Inet1)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.lblPassword)
        Me.Controls.Add(Me.Label18)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Location = New System.Drawing.Point(400, 250)
        Me.MaximizeBox = False
        Me.Name = "frmFTP"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "Burn-In FTP Download Tool V2.0"
        CType(Me.Inet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents cmbModelname As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
#End Region
End Class