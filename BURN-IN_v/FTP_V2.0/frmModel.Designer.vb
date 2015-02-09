<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class frmModel
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
	Public WithEvents cmdfrmtcp As System.Windows.Forms.Button
	Public WithEvents cblModel As System.Windows.Forms.ComboBox
	Public WithEvents lblModel As System.Windows.Forms.Label
	'注意: 以下為 Windows Form 設計工具所需的程序
	'可以使用 Windows Form 設計工具進行修改。
	'請不要使用程式碼編輯器進行修改。
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(frmModel))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.cmdfrmtcp = New System.Windows.Forms.Button
		Me.cblModel = New System.Windows.Forms.ComboBox
		Me.lblModel = New System.Windows.Forms.Label
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "CPU:5200 ORT-TEST Model Select V1.0"
		Me.ClientSize = New System.Drawing.Size(344, 50)
		Me.Location = New System.Drawing.Point(639, 252)
		Me.MaximizeBox = False
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "frmModel"
		Me.cmdfrmtcp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdfrmtcp.BackColor = System.Drawing.Color.FromARGB(255, 224, 192)
		Me.cmdfrmtcp.Text = "Call ORT-TEST"
		Me.cmdfrmtcp.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdfrmtcp.Size = New System.Drawing.Size(129, 25)
		Me.cmdfrmtcp.Location = New System.Drawing.Point(208, 16)
		Me.cmdfrmtcp.TabIndex = 1
		Me.cmdfrmtcp.CausesValidation = True
		Me.cmdfrmtcp.Enabled = True
		Me.cmdfrmtcp.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdfrmtcp.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdfrmtcp.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdfrmtcp.TabStop = True
		Me.cmdfrmtcp.Name = "cmdfrmtcp"
		Me.cblModel.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.cblModel.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cblModel.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me.cblModel.Size = New System.Drawing.Size(129, 27)
		Me.cblModel.Location = New System.Drawing.Point(72, 16)
		Me.cblModel.TabIndex = 0
		Me.cblModel.CausesValidation = True
		Me.cblModel.Enabled = True
		Me.cblModel.IntegralHeight = True
		Me.cblModel.Cursor = System.Windows.Forms.Cursors.Default
		Me.cblModel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cblModel.Sorted = False
		Me.cblModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
		Me.cblModel.TabStop = True
		Me.cblModel.Visible = True
		Me.cblModel.Name = "cblModel"
		Me.lblModel.Text = "Model :"
		Me.lblModel.Font = New System.Drawing.Font("Arial", 12!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.lblModel.Size = New System.Drawing.Size(57, 25)
		Me.lblModel.Location = New System.Drawing.Point(8, 16)
		Me.lblModel.TabIndex = 2
		Me.lblModel.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.lblModel.BackColor = System.Drawing.SystemColors.Control
		Me.lblModel.Enabled = True
		Me.lblModel.ForeColor = System.Drawing.SystemColors.ControlText
		Me.lblModel.Cursor = System.Windows.Forms.Cursors.Default
		Me.lblModel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.lblModel.UseMnemonic = True
		Me.lblModel.Visible = True
		Me.lblModel.AutoSize = False
		Me.lblModel.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.lblModel.Name = "lblModel"
		Me.Controls.Add(cmdfrmtcp)
		Me.Controls.Add(cblModel)
		Me.Controls.Add(lblModel)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class