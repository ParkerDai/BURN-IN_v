<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> Partial Class FrmMain
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
	Public WithEvents MnuSetComp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuAddId As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuSchedule As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuGroup As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuHoliday As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuSetTime As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuSet As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuQryComp As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuQryId As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuNULL1 As System.Windows.Forms.ToolStripSeparator
	Public WithEvents MnuQryRealT As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MnuQuery As System.Windows.Forms.ToolStripMenuItem
	Public WithEvents MainMenu1 As System.Windows.Forms.MenuStrip
	Public WithEvents chk_stopsend As System.Windows.Forms.CheckBox
	Public WithEvents tmr_winsock As System.Windows.Forms.Timer
	Public WithEvents chk_pingpong As System.Windows.Forms.CheckBox
	Public WithEvents tmr_subtract As System.Windows.Forms.Timer
	Public WithEvents txtMappingModel As System.Windows.Forms.TextBox
	Public WithEvents TxtSendDataLentoall As System.Windows.Forms.TextBox
	Public WithEvents TxtSendIntvaltoall As System.Windows.Forms.TextBox
	Public WithEvents cmdComtesttotal As System.Windows.Forms.Button
	Public WithEvents cmdContotal As System.Windows.Forms.Button
	Public WithEvents _CmdClrCnt_7 As System.Windows.Forms.Button
	Public WithEvents _CmdClrCnt_6 As System.Windows.Forms.Button
	Public WithEvents _CmdClrCnt_5 As System.Windows.Forms.Button
	Public WithEvents _CmdClrCnt_4 As System.Windows.Forms.Button
	Public WithEvents _TmrSend_7 As System.Windows.Forms.Timer
	Public WithEvents _TmrSend_6 As System.Windows.Forms.Timer
	Public WithEvents _TxtRcvPket_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPket_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPketTal_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSendTal_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSend_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntRcv_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntLoss_7 As System.Windows.Forms.TextBox
	Public WithEvents _CmdSendBeg_7 As System.Windows.Forms.Button
	Public WithEvents _TxtSendDataLen_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendIntval_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendData_7 As System.Windows.Forms.TextBox
	Public WithEvents _TxtRcvPket_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPket_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPketTal_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSendTal_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSend_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntRcv_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntLoss_6 As System.Windows.Forms.TextBox
	Public WithEvents _CmdSendBeg_6 As System.Windows.Forms.Button
	Public WithEvents _TxtSendDataLen_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendIntval_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendData_6 As System.Windows.Forms.TextBox
	Public WithEvents _TxtRcvPket_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPket_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPketTal_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSendTal_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSend_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntRcv_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntLoss_5 As System.Windows.Forms.TextBox
	Public WithEvents _CmdSendBeg_5 As System.Windows.Forms.Button
	Public WithEvents _TxtSendDataLen_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendIntval_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendData_5 As System.Windows.Forms.TextBox
	Public WithEvents _TxtRcvPket_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPket_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPketTal_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSendTal_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSend_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntRcv_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntLoss_4 As System.Windows.Forms.TextBox
	Public WithEvents _CmdSendBeg_4 As System.Windows.Forms.Button
	Public WithEvents _TxtSendDataLen_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendIntval_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendData_4 As System.Windows.Forms.TextBox
	Public WithEvents _TxtRcvPket_3 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPket_3 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPketTal_3 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSendTal_3 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSend_3 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntRcv_3 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntLoss_3 As System.Windows.Forms.TextBox
	Public WithEvents _CmdSendBeg_3 As System.Windows.Forms.Button
	Public WithEvents _TxtSendDataLen_3 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendIntval_3 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendData_3 As System.Windows.Forms.TextBox
	Public WithEvents _TmrSend_5 As System.Windows.Forms.Timer
	Public WithEvents _TmrSend_4 As System.Windows.Forms.Timer
	Public WithEvents _CmdClrCnt_3 As System.Windows.Forms.Button
	Public WithEvents _TmrSend_3 As System.Windows.Forms.Timer
	Public WithEvents Timer1 As System.Windows.Forms.Timer
	Public WithEvents _TxtSendData_2 As System.Windows.Forms.TextBox
	Public WithEvents _TmrSend_2 As System.Windows.Forms.Timer
	Public WithEvents _CmdClrCnt_2 As System.Windows.Forms.Button
	Public WithEvents _TxtSendIntval_2 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendDataLen_2 As System.Windows.Forms.TextBox
	Public WithEvents _CmdSendBeg_2 As System.Windows.Forms.Button
	Public WithEvents _TxtCntLoss_2 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntRcv_2 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSend_2 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSendTal_2 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPketTal_2 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPket_2 As System.Windows.Forms.TextBox
	Public WithEvents _TxtRcvPket_2 As System.Windows.Forms.TextBox
	Public WithEvents _TxtRcvPket_1 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPket_1 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPketTal_1 As System.Windows.Forms.TextBox
	Public WithEvents _TxtRcvPket_0 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPket_0 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendPketTal_0 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSendTal_0 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSendTal_1 As System.Windows.Forms.TextBox
	Public WithEvents _CmdClrCnt_1 As System.Windows.Forms.Button
	Public WithEvents _TmrSend_1 As System.Windows.Forms.Timer
	Public WithEvents _TxtCntSend_1 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntRcv_1 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntLoss_1 As System.Windows.Forms.TextBox
	Public WithEvents _CmdSendBeg_1 As System.Windows.Forms.Button
	Public WithEvents _TxtSendDataLen_1 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendIntval_1 As System.Windows.Forms.TextBox
	Public WithEvents TmrRate As System.Windows.Forms.Timer
	Public WithEvents Timer2 As System.Windows.Forms.Timer
	Public WithEvents _TxtCntLoss_0 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntRcv_0 As System.Windows.Forms.TextBox
	Public WithEvents _TxtCntSend_0 As System.Windows.Forms.TextBox
	Public WithEvents _CmdSendBeg_0 As System.Windows.Forms.Button
	Public WithEvents _TmrSend_0 As System.Windows.Forms.Timer
	Public WithEvents _TxtSendData_0 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendDataLen_0 As System.Windows.Forms.TextBox
	Public WithEvents _TxtSendIntval_0 As System.Windows.Forms.TextBox
	Public WithEvents cmdClrList As System.Windows.Forms.Button
	Public WithEvents _txtip_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtip_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtip_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtip_5 As System.Windows.Forms.TextBox
	Public WithEvents _txtip_6 As System.Windows.Forms.TextBox
	Public WithEvents _txtip_7 As System.Windows.Forms.TextBox
	Public WithEvents txtStatus67 As System.Windows.Forms.TextBox
	Public WithEvents _cmdCnect_7 As System.Windows.Forms.Button
	Public WithEvents _txtLocalPort_7 As System.Windows.Forms.TextBox
	Public WithEvents _txtPort_7 As System.Windows.Forms.TextBox
	Public WithEvents _cmdCnect_6 As System.Windows.Forms.Button
	Public WithEvents _txtLocalPort_6 As System.Windows.Forms.TextBox
	Public WithEvents _txtPort_6 As System.Windows.Forms.TextBox
	Public WithEvents _cmdCnect_5 As System.Windows.Forms.Button
	Public WithEvents _txtPort_5 As System.Windows.Forms.TextBox
	Public WithEvents txtStatus45 As System.Windows.Forms.TextBox
	Public WithEvents _cmdCnect_4 As System.Windows.Forms.Button
	Public WithEvents _txtLocalPort_4 As System.Windows.Forms.TextBox
	Public WithEvents _txtPort_4 As System.Windows.Forms.TextBox
	Public WithEvents _cmdCnect_3 As System.Windows.Forms.Button
	Public WithEvents _txtPort_3 As System.Windows.Forms.TextBox
	Public WithEvents _Winsock1_3 As AxMSWinsockLib.AxWinsock
	Public WithEvents _Winsock1_2 As AxMSWinsockLib.AxWinsock
	Public WithEvents _Winsock1_0 As AxMSWinsockLib.AxWinsock
	Public WithEvents _Winsock1_1 As AxMSWinsockLib.AxWinsock
	Public WithEvents txtStatus23 As System.Windows.Forms.TextBox
	Public WithEvents _txtPort_2 As System.Windows.Forms.TextBox
	Public WithEvents _txtLocalPort_2 As System.Windows.Forms.TextBox
	Public WithEvents _cmdCnect_2 As System.Windows.Forms.Button
	Public WithEvents txtStatus As System.Windows.Forms.TextBox
	Public WithEvents _cmdCnect_0 As System.Windows.Forms.Button
	Public WithEvents _cmdCnect_1 As System.Windows.Forms.Button
	Public WithEvents _txtip_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtip_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtLocalPort_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtLocalPort_1 As System.Windows.Forms.TextBox
	Public WithEvents _txtPort_0 As System.Windows.Forms.TextBox
	Public WithEvents _txtPort_1 As System.Windows.Forms.TextBox
	Public WithEvents cmdListen As System.Windows.Forms.Button
	Public WithEvents _txtLocalPort_3 As System.Windows.Forms.TextBox
	Public WithEvents _txtLocalPort_5 As System.Windows.Forms.TextBox
	Public WithEvents _Winsock1_4 As AxMSWinsockLib.AxWinsock
	Public WithEvents _Winsock1_5 As AxMSWinsockLib.AxWinsock
	Public WithEvents _Winsock1_6 As AxMSWinsockLib.AxWinsock
	Public WithEvents _Winsock1_7 As AxMSWinsockLib.AxWinsock
	Public WithEvents Label31 As System.Windows.Forms.Label
	Public WithEvents Label30 As System.Windows.Forms.Label
	Public WithEvents Label21 As System.Windows.Forms.Label
	Public WithEvents _LabLoop_2 As System.Windows.Forms.Label
	Public WithEvents _LabLoop_1 As System.Windows.Forms.Label
	Public WithEvents _LabLoop_0 As System.Windows.Forms.Label
	Public WithEvents _Label1_0 As System.Windows.Forms.Label
	Public WithEvents _Label1_1 As System.Windows.Forms.Label
	Public WithEvents Label6 As System.Windows.Forms.Label
	Public WithEvents Frame1 As System.Windows.Forms.GroupBox
	Public WithEvents _OptTcpUdp_1 As System.Windows.Forms.RadioButton
	Public WithEvents _OptTcpUdp_0 As System.Windows.Forms.RadioButton
	Public WithEvents List1 As System.Windows.Forms.CheckedListBox
	Public WithEvents _CmdClrCnt_0 As System.Windows.Forms.Button
	Public WithEvents _TxtSendData_1 As System.Windows.Forms.TextBox
	Public WithEvents _OptTestMode_0 As System.Windows.Forms.RadioButton
	Public WithEvents _OptTestMode_1 As System.Windows.Forms.RadioButton
	Public WithEvents ChkXOnOff As System.Windows.Forms.CheckBox
	Public WithEvents ChkRecdAck As System.Windows.Forms.CheckBox
	Public WithEvents Command1 As System.Windows.Forms.Button
	Public WithEvents CmdBrow As System.Windows.Forms.Button
	Public WithEvents TxtLogFile As System.Windows.Forms.TextBox
	Public WithEvents ChkRemote As System.Windows.Forms.CheckBox
	Public WithEvents txtData As System.Windows.Forms.TextBox
	Public WithEvents cmdSend As System.Windows.Forms.Button
	Public WithEvents txtDaport As System.Windows.Forms.TextBox
	Public WithEvents txtListCnt As System.Windows.Forms.TextBox
	Public WithEvents txtId2 As System.Windows.Forms.TextBox
	Public WithEvents cmdSend2 As System.Windows.Forms.Button
	Public WithEvents txtData2 As System.Windows.Forms.TextBox
	Public WithEvents txtMsg As System.Windows.Forms.TextBox
	Public WithEvents TxtID As System.Windows.Forms.TextBox
	Public WithEvents TxtSubNode As System.Windows.Forms.TextBox
	Public WithEvents CmdSaveList As System.Windows.Forms.Button
	Public WithEvents Label32 As System.Windows.Forms.Label
	Public WithEvents Label33 As System.Windows.Forms.Label
	Public WithEvents _Label20_7 As System.Windows.Forms.Label
	Public WithEvents _LabRcv_7 As System.Windows.Forms.Label
	Public WithEvents _LabLoss_7 As System.Windows.Forms.Label
	Public WithEvents _Label24_7 As System.Windows.Forms.Label
	Public WithEvents _LabSend_7 As System.Windows.Forms.Label
	Public WithEvents _Label20_6 As System.Windows.Forms.Label
	Public WithEvents _LabRcv_6 As System.Windows.Forms.Label
	Public WithEvents _LabLoss_6 As System.Windows.Forms.Label
	Public WithEvents _Label24_6 As System.Windows.Forms.Label
	Public WithEvents _LabSend_6 As System.Windows.Forms.Label
	Public WithEvents _Label20_5 As System.Windows.Forms.Label
	Public WithEvents _LabRcv_5 As System.Windows.Forms.Label
	Public WithEvents _LabLoss_5 As System.Windows.Forms.Label
	Public WithEvents _Label24_5 As System.Windows.Forms.Label
	Public WithEvents _LabSend_5 As System.Windows.Forms.Label
	Public WithEvents _Label20_4 As System.Windows.Forms.Label
	Public WithEvents _LabRcv_4 As System.Windows.Forms.Label
	Public WithEvents _LabLoss_4 As System.Windows.Forms.Label
	Public WithEvents _Label24_4 As System.Windows.Forms.Label
	Public WithEvents _LabSend_4 As System.Windows.Forms.Label
	Public WithEvents _Label20_3 As System.Windows.Forms.Label
	Public WithEvents _LabRcv_3 As System.Windows.Forms.Label
	Public WithEvents _LabLoss_3 As System.Windows.Forms.Label
	Public WithEvents _Label24_3 As System.Windows.Forms.Label
	Public WithEvents _LabSend_3 As System.Windows.Forms.Label
	Public WithEvents Label29 As System.Windows.Forms.Label
	Public WithEvents Label28 As System.Windows.Forms.Label
	Public WithEvents Label27 As System.Windows.Forms.Label
	Public WithEvents Label26 As System.Windows.Forms.Label
	Public WithEvents Label25 As System.Windows.Forms.Label
	Public WithEvents Label23 As System.Windows.Forms.Label
	Public WithEvents _LabSend_2 As System.Windows.Forms.Label
	Public WithEvents _Label24_2 As System.Windows.Forms.Label
	Public WithEvents _LabLoss_2 As System.Windows.Forms.Label
	Public WithEvents _Label22_2 As System.Windows.Forms.Label
	Public WithEvents _LabRcv_2 As System.Windows.Forms.Label
	Public WithEvents _Label20_2 As System.Windows.Forms.Label
	Public WithEvents Label19 As System.Windows.Forms.Label
	Public WithEvents _LabSend_1 As System.Windows.Forms.Label
	Public WithEvents _Label20_1 As System.Windows.Forms.Label
	Public WithEvents _LabRcv_1 As System.Windows.Forms.Label
	Public WithEvents _LabLoss_1 As System.Windows.Forms.Label
	Public WithEvents _Label24_1 As System.Windows.Forms.Label
	Public WithEvents _LabLoss_0 As System.Windows.Forms.Label
	Public WithEvents _LabRcv_0 As System.Windows.Forms.Label
	Public WithEvents _Label20_0 As System.Windows.Forms.Label
	Public WithEvents _LabSend_0 As System.Windows.Forms.Label
	Public WithEvents LabRunTime As System.Windows.Forms.Label
	Public WithEvents Label18 As System.Windows.Forms.Label
	Public WithEvents Label17 As System.Windows.Forms.Label
	Public WithEvents Label16 As System.Windows.Forms.Label
	Public WithEvents Label15 As System.Windows.Forms.Label
	Public WithEvents Label13 As System.Windows.Forms.Label
	Public WithEvents Label12 As System.Windows.Forms.Label
	Public WithEvents Label5 As System.Windows.Forms.Label
	Public WithEvents Label8 As System.Windows.Forms.Label
	Public WithEvents labTime As System.Windows.Forms.Label
	Public WithEvents _Label22_0 As System.Windows.Forms.Label
	Public WithEvents _Label24_0 As System.Windows.Forms.Label
	Public WithEvents _Label22_1 As System.Windows.Forms.Label
	Public WithEvents Label14 As System.Windows.Forms.Label
	Public WithEvents Label10 As System.Windows.Forms.Label
	Public WithEvents Label11 As System.Windows.Forms.Label
	Public WithEvents Label9 As System.Windows.Forms.Label
	Public WithEvents Label7 As System.Windows.Forms.Label
	Public WithEvents Label4 As System.Windows.Forms.Label
	Public WithEvents Label3 As System.Windows.Forms.Label
	Public WithEvents _Label2_0 As System.Windows.Forms.Label
	Public WithEvents CmdClrCnt As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents CmdSendBeg As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents LabLoop As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents LabLoss As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents LabRcv As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents LabSend As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label1 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label2 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label20 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label22 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents Label24 As Microsoft.VisualBasic.Compatibility.VB6.LabelArray
	Public WithEvents OptTcpUdp As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents OptTestMode As Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray
	Public WithEvents TmrSend As Microsoft.VisualBasic.Compatibility.VB6.TimerArray
	Public WithEvents TxtCntLoss As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtCntRcv As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtCntSend As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtCntSendTal As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtRcvPket As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtSendData As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtSendDataLen As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtSendIntval As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtSendPket As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents TxtSendPketTal As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents Winsock1 As AxWinsockArray
	Public WithEvents cmdCnect As Microsoft.VisualBasic.Compatibility.VB6.ButtonArray
	Public WithEvents txtLocalPort As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtPort As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	Public WithEvents txtip As Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray
	'注意: 以下為 Windows Form 設計工具所需的程序
	'可以使用 Windows Form 設計工具進行修改。
	'請不要使用程式碼編輯器進行修改。
	<System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
		Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(FrmMain))
		Me.components = New System.ComponentModel.Container()
		Me.ToolTip1 = New System.Windows.Forms.ToolTip(components)
		Me.MainMenu1 = New System.Windows.Forms.MenuStrip
		Me.MnuSet = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuSetComp = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuAddId = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuSchedule = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuGroup = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuHoliday = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuSetTime = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuQuery = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuQryComp = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuQryId = New System.Windows.Forms.ToolStripMenuItem
		Me.MnuNULL1 = New System.Windows.Forms.ToolStripSeparator
		Me.MnuQryRealT = New System.Windows.Forms.ToolStripMenuItem
		Me.chk_stopsend = New System.Windows.Forms.CheckBox
		Me.tmr_winsock = New System.Windows.Forms.Timer(components)
		Me.chk_pingpong = New System.Windows.Forms.CheckBox
		Me.tmr_subtract = New System.Windows.Forms.Timer(components)
		Me.txtMappingModel = New System.Windows.Forms.TextBox
		Me.TxtSendDataLentoall = New System.Windows.Forms.TextBox
		Me.TxtSendIntvaltoall = New System.Windows.Forms.TextBox
		Me.cmdComtesttotal = New System.Windows.Forms.Button
		Me.cmdContotal = New System.Windows.Forms.Button
		Me._CmdClrCnt_7 = New System.Windows.Forms.Button
		Me._CmdClrCnt_6 = New System.Windows.Forms.Button
		Me._CmdClrCnt_5 = New System.Windows.Forms.Button
		Me._CmdClrCnt_4 = New System.Windows.Forms.Button
		Me._TmrSend_7 = New System.Windows.Forms.Timer(components)
		Me._TmrSend_6 = New System.Windows.Forms.Timer(components)
		Me._TxtRcvPket_7 = New System.Windows.Forms.TextBox
		Me._TxtSendPket_7 = New System.Windows.Forms.TextBox
		Me._TxtSendPketTal_7 = New System.Windows.Forms.TextBox
		Me._TxtCntSendTal_7 = New System.Windows.Forms.TextBox
		Me._TxtCntSend_7 = New System.Windows.Forms.TextBox
		Me._TxtCntRcv_7 = New System.Windows.Forms.TextBox
		Me._TxtCntLoss_7 = New System.Windows.Forms.TextBox
		Me._CmdSendBeg_7 = New System.Windows.Forms.Button
		Me._TxtSendDataLen_7 = New System.Windows.Forms.TextBox
		Me._TxtSendIntval_7 = New System.Windows.Forms.TextBox
		Me._TxtSendData_7 = New System.Windows.Forms.TextBox
		Me._TxtRcvPket_6 = New System.Windows.Forms.TextBox
		Me._TxtSendPket_6 = New System.Windows.Forms.TextBox
		Me._TxtSendPketTal_6 = New System.Windows.Forms.TextBox
		Me._TxtCntSendTal_6 = New System.Windows.Forms.TextBox
		Me._TxtCntSend_6 = New System.Windows.Forms.TextBox
		Me._TxtCntRcv_6 = New System.Windows.Forms.TextBox
		Me._TxtCntLoss_6 = New System.Windows.Forms.TextBox
		Me._CmdSendBeg_6 = New System.Windows.Forms.Button
		Me._TxtSendDataLen_6 = New System.Windows.Forms.TextBox
		Me._TxtSendIntval_6 = New System.Windows.Forms.TextBox
		Me._TxtSendData_6 = New System.Windows.Forms.TextBox
		Me._TxtRcvPket_5 = New System.Windows.Forms.TextBox
		Me._TxtSendPket_5 = New System.Windows.Forms.TextBox
		Me._TxtSendPketTal_5 = New System.Windows.Forms.TextBox
		Me._TxtCntSendTal_5 = New System.Windows.Forms.TextBox
		Me._TxtCntSend_5 = New System.Windows.Forms.TextBox
		Me._TxtCntRcv_5 = New System.Windows.Forms.TextBox
		Me._TxtCntLoss_5 = New System.Windows.Forms.TextBox
		Me._CmdSendBeg_5 = New System.Windows.Forms.Button
		Me._TxtSendDataLen_5 = New System.Windows.Forms.TextBox
		Me._TxtSendIntval_5 = New System.Windows.Forms.TextBox
		Me._TxtSendData_5 = New System.Windows.Forms.TextBox
		Me._TxtRcvPket_4 = New System.Windows.Forms.TextBox
		Me._TxtSendPket_4 = New System.Windows.Forms.TextBox
		Me._TxtSendPketTal_4 = New System.Windows.Forms.TextBox
		Me._TxtCntSendTal_4 = New System.Windows.Forms.TextBox
		Me._TxtCntSend_4 = New System.Windows.Forms.TextBox
		Me._TxtCntRcv_4 = New System.Windows.Forms.TextBox
		Me._TxtCntLoss_4 = New System.Windows.Forms.TextBox
		Me._CmdSendBeg_4 = New System.Windows.Forms.Button
		Me._TxtSendDataLen_4 = New System.Windows.Forms.TextBox
		Me._TxtSendIntval_4 = New System.Windows.Forms.TextBox
		Me._TxtSendData_4 = New System.Windows.Forms.TextBox
		Me._TxtRcvPket_3 = New System.Windows.Forms.TextBox
		Me._TxtSendPket_3 = New System.Windows.Forms.TextBox
		Me._TxtSendPketTal_3 = New System.Windows.Forms.TextBox
		Me._TxtCntSendTal_3 = New System.Windows.Forms.TextBox
		Me._TxtCntSend_3 = New System.Windows.Forms.TextBox
		Me._TxtCntRcv_3 = New System.Windows.Forms.TextBox
		Me._TxtCntLoss_3 = New System.Windows.Forms.TextBox
		Me._CmdSendBeg_3 = New System.Windows.Forms.Button
		Me._TxtSendDataLen_3 = New System.Windows.Forms.TextBox
		Me._TxtSendIntval_3 = New System.Windows.Forms.TextBox
		Me._TxtSendData_3 = New System.Windows.Forms.TextBox
		Me._TmrSend_5 = New System.Windows.Forms.Timer(components)
		Me._TmrSend_4 = New System.Windows.Forms.Timer(components)
		Me._CmdClrCnt_3 = New System.Windows.Forms.Button
		Me._TmrSend_3 = New System.Windows.Forms.Timer(components)
		Me.Timer1 = New System.Windows.Forms.Timer(components)
		Me._TxtSendData_2 = New System.Windows.Forms.TextBox
		Me._TmrSend_2 = New System.Windows.Forms.Timer(components)
		Me._CmdClrCnt_2 = New System.Windows.Forms.Button
		Me._TxtSendIntval_2 = New System.Windows.Forms.TextBox
		Me._TxtSendDataLen_2 = New System.Windows.Forms.TextBox
		Me._CmdSendBeg_2 = New System.Windows.Forms.Button
		Me._TxtCntLoss_2 = New System.Windows.Forms.TextBox
		Me._TxtCntRcv_2 = New System.Windows.Forms.TextBox
		Me._TxtCntSend_2 = New System.Windows.Forms.TextBox
		Me._TxtCntSendTal_2 = New System.Windows.Forms.TextBox
		Me._TxtSendPketTal_2 = New System.Windows.Forms.TextBox
		Me._TxtSendPket_2 = New System.Windows.Forms.TextBox
		Me._TxtRcvPket_2 = New System.Windows.Forms.TextBox
		Me._TxtRcvPket_1 = New System.Windows.Forms.TextBox
		Me._TxtSendPket_1 = New System.Windows.Forms.TextBox
		Me._TxtSendPketTal_1 = New System.Windows.Forms.TextBox
		Me._TxtRcvPket_0 = New System.Windows.Forms.TextBox
		Me._TxtSendPket_0 = New System.Windows.Forms.TextBox
		Me._TxtSendPketTal_0 = New System.Windows.Forms.TextBox
		Me._TxtCntSendTal_0 = New System.Windows.Forms.TextBox
		Me._TxtCntSendTal_1 = New System.Windows.Forms.TextBox
		Me._CmdClrCnt_1 = New System.Windows.Forms.Button
		Me._TmrSend_1 = New System.Windows.Forms.Timer(components)
		Me._TxtCntSend_1 = New System.Windows.Forms.TextBox
		Me._TxtCntRcv_1 = New System.Windows.Forms.TextBox
		Me._TxtCntLoss_1 = New System.Windows.Forms.TextBox
		Me._CmdSendBeg_1 = New System.Windows.Forms.Button
		Me._TxtSendDataLen_1 = New System.Windows.Forms.TextBox
		Me._TxtSendIntval_1 = New System.Windows.Forms.TextBox
		Me.TmrRate = New System.Windows.Forms.Timer(components)
		Me.Timer2 = New System.Windows.Forms.Timer(components)
		Me._TxtCntLoss_0 = New System.Windows.Forms.TextBox
		Me._TxtCntRcv_0 = New System.Windows.Forms.TextBox
		Me._TxtCntSend_0 = New System.Windows.Forms.TextBox
		Me._CmdSendBeg_0 = New System.Windows.Forms.Button
		Me._TmrSend_0 = New System.Windows.Forms.Timer(components)
		Me._TxtSendData_0 = New System.Windows.Forms.TextBox
		Me._TxtSendDataLen_0 = New System.Windows.Forms.TextBox
		Me._TxtSendIntval_0 = New System.Windows.Forms.TextBox
		Me.cmdClrList = New System.Windows.Forms.Button
		Me.Frame1 = New System.Windows.Forms.GroupBox
		Me._txtip_2 = New System.Windows.Forms.TextBox
		Me._txtip_3 = New System.Windows.Forms.TextBox
		Me._txtip_4 = New System.Windows.Forms.TextBox
		Me._txtip_5 = New System.Windows.Forms.TextBox
		Me._txtip_6 = New System.Windows.Forms.TextBox
		Me._txtip_7 = New System.Windows.Forms.TextBox
		Me.txtStatus67 = New System.Windows.Forms.TextBox
		Me._cmdCnect_7 = New System.Windows.Forms.Button
		Me._txtLocalPort_7 = New System.Windows.Forms.TextBox
		Me._txtPort_7 = New System.Windows.Forms.TextBox
		Me._cmdCnect_6 = New System.Windows.Forms.Button
		Me._txtLocalPort_6 = New System.Windows.Forms.TextBox
		Me._txtPort_6 = New System.Windows.Forms.TextBox
		Me._cmdCnect_5 = New System.Windows.Forms.Button
		Me._txtPort_5 = New System.Windows.Forms.TextBox
		Me.txtStatus45 = New System.Windows.Forms.TextBox
		Me._cmdCnect_4 = New System.Windows.Forms.Button
		Me._txtLocalPort_4 = New System.Windows.Forms.TextBox
		Me._txtPort_4 = New System.Windows.Forms.TextBox
		Me._cmdCnect_3 = New System.Windows.Forms.Button
		Me._txtPort_3 = New System.Windows.Forms.TextBox
		Me._Winsock1_3 = New AxMSWinsockLib.AxWinsock
		Me._Winsock1_2 = New AxMSWinsockLib.AxWinsock
		Me._Winsock1_0 = New AxMSWinsockLib.AxWinsock
		Me._Winsock1_1 = New AxMSWinsockLib.AxWinsock
		Me.txtStatus23 = New System.Windows.Forms.TextBox
		Me._txtPort_2 = New System.Windows.Forms.TextBox
		Me._txtLocalPort_2 = New System.Windows.Forms.TextBox
		Me._cmdCnect_2 = New System.Windows.Forms.Button
		Me.txtStatus = New System.Windows.Forms.TextBox
		Me._cmdCnect_0 = New System.Windows.Forms.Button
		Me._cmdCnect_1 = New System.Windows.Forms.Button
		Me._txtip_0 = New System.Windows.Forms.TextBox
		Me._txtip_1 = New System.Windows.Forms.TextBox
		Me._txtLocalPort_0 = New System.Windows.Forms.TextBox
		Me._txtLocalPort_1 = New System.Windows.Forms.TextBox
		Me._txtPort_0 = New System.Windows.Forms.TextBox
		Me._txtPort_1 = New System.Windows.Forms.TextBox
		Me.cmdListen = New System.Windows.Forms.Button
		Me._txtLocalPort_3 = New System.Windows.Forms.TextBox
		Me._txtLocalPort_5 = New System.Windows.Forms.TextBox
		Me._Winsock1_4 = New AxMSWinsockLib.AxWinsock
		Me._Winsock1_5 = New AxMSWinsockLib.AxWinsock
		Me._Winsock1_6 = New AxMSWinsockLib.AxWinsock
		Me._Winsock1_7 = New AxMSWinsockLib.AxWinsock
		Me.Label31 = New System.Windows.Forms.Label
		Me.Label30 = New System.Windows.Forms.Label
		Me.Label21 = New System.Windows.Forms.Label
		Me._LabLoop_2 = New System.Windows.Forms.Label
		Me._LabLoop_1 = New System.Windows.Forms.Label
		Me._LabLoop_0 = New System.Windows.Forms.Label
		Me._Label1_0 = New System.Windows.Forms.Label
		Me._Label1_1 = New System.Windows.Forms.Label
		Me.Label6 = New System.Windows.Forms.Label
		Me._OptTcpUdp_1 = New System.Windows.Forms.RadioButton
		Me._OptTcpUdp_0 = New System.Windows.Forms.RadioButton
		Me.List1 = New System.Windows.Forms.CheckedListBox
		Me._CmdClrCnt_0 = New System.Windows.Forms.Button
		Me._TxtSendData_1 = New System.Windows.Forms.TextBox
		Me._OptTestMode_0 = New System.Windows.Forms.RadioButton
		Me._OptTestMode_1 = New System.Windows.Forms.RadioButton
		Me.ChkXOnOff = New System.Windows.Forms.CheckBox
		Me.ChkRecdAck = New System.Windows.Forms.CheckBox
		Me.Command1 = New System.Windows.Forms.Button
		Me.CmdBrow = New System.Windows.Forms.Button
		Me.TxtLogFile = New System.Windows.Forms.TextBox
		Me.ChkRemote = New System.Windows.Forms.CheckBox
		Me.txtData = New System.Windows.Forms.TextBox
		Me.cmdSend = New System.Windows.Forms.Button
		Me.txtDaport = New System.Windows.Forms.TextBox
		Me.txtListCnt = New System.Windows.Forms.TextBox
		Me.txtId2 = New System.Windows.Forms.TextBox
		Me.cmdSend2 = New System.Windows.Forms.Button
		Me.txtData2 = New System.Windows.Forms.TextBox
		Me.txtMsg = New System.Windows.Forms.TextBox
		Me.TxtID = New System.Windows.Forms.TextBox
		Me.TxtSubNode = New System.Windows.Forms.TextBox
		Me.CmdSaveList = New System.Windows.Forms.Button
		Me.Label32 = New System.Windows.Forms.Label
		Me.Label33 = New System.Windows.Forms.Label
		Me._Label20_7 = New System.Windows.Forms.Label
		Me._LabRcv_7 = New System.Windows.Forms.Label
		Me._LabLoss_7 = New System.Windows.Forms.Label
		Me._Label24_7 = New System.Windows.Forms.Label
		Me._LabSend_7 = New System.Windows.Forms.Label
		Me._Label20_6 = New System.Windows.Forms.Label
		Me._LabRcv_6 = New System.Windows.Forms.Label
		Me._LabLoss_6 = New System.Windows.Forms.Label
		Me._Label24_6 = New System.Windows.Forms.Label
		Me._LabSend_6 = New System.Windows.Forms.Label
		Me._Label20_5 = New System.Windows.Forms.Label
		Me._LabRcv_5 = New System.Windows.Forms.Label
		Me._LabLoss_5 = New System.Windows.Forms.Label
		Me._Label24_5 = New System.Windows.Forms.Label
		Me._LabSend_5 = New System.Windows.Forms.Label
		Me._Label20_4 = New System.Windows.Forms.Label
		Me._LabRcv_4 = New System.Windows.Forms.Label
		Me._LabLoss_4 = New System.Windows.Forms.Label
		Me._Label24_4 = New System.Windows.Forms.Label
		Me._LabSend_4 = New System.Windows.Forms.Label
		Me._Label20_3 = New System.Windows.Forms.Label
		Me._LabRcv_3 = New System.Windows.Forms.Label
		Me._LabLoss_3 = New System.Windows.Forms.Label
		Me._Label24_3 = New System.Windows.Forms.Label
		Me._LabSend_3 = New System.Windows.Forms.Label
		Me.Label29 = New System.Windows.Forms.Label
		Me.Label28 = New System.Windows.Forms.Label
		Me.Label27 = New System.Windows.Forms.Label
		Me.Label26 = New System.Windows.Forms.Label
		Me.Label25 = New System.Windows.Forms.Label
		Me.Label23 = New System.Windows.Forms.Label
		Me._LabSend_2 = New System.Windows.Forms.Label
		Me._Label24_2 = New System.Windows.Forms.Label
		Me._LabLoss_2 = New System.Windows.Forms.Label
		Me._Label22_2 = New System.Windows.Forms.Label
		Me._LabRcv_2 = New System.Windows.Forms.Label
		Me._Label20_2 = New System.Windows.Forms.Label
		Me.Label19 = New System.Windows.Forms.Label
		Me._LabSend_1 = New System.Windows.Forms.Label
		Me._Label20_1 = New System.Windows.Forms.Label
		Me._LabRcv_1 = New System.Windows.Forms.Label
		Me._LabLoss_1 = New System.Windows.Forms.Label
		Me._Label24_1 = New System.Windows.Forms.Label
		Me._LabLoss_0 = New System.Windows.Forms.Label
		Me._LabRcv_0 = New System.Windows.Forms.Label
		Me._Label20_0 = New System.Windows.Forms.Label
		Me._LabSend_0 = New System.Windows.Forms.Label
		Me.LabRunTime = New System.Windows.Forms.Label
		Me.Label18 = New System.Windows.Forms.Label
		Me.Label17 = New System.Windows.Forms.Label
		Me.Label16 = New System.Windows.Forms.Label
		Me.Label15 = New System.Windows.Forms.Label
		Me.Label13 = New System.Windows.Forms.Label
		Me.Label12 = New System.Windows.Forms.Label
		Me.Label5 = New System.Windows.Forms.Label
		Me.Label8 = New System.Windows.Forms.Label
		Me.labTime = New System.Windows.Forms.Label
		Me._Label22_0 = New System.Windows.Forms.Label
		Me._Label24_0 = New System.Windows.Forms.Label
		Me._Label22_1 = New System.Windows.Forms.Label
		Me.Label14 = New System.Windows.Forms.Label
		Me.Label10 = New System.Windows.Forms.Label
		Me.Label11 = New System.Windows.Forms.Label
		Me.Label9 = New System.Windows.Forms.Label
		Me.Label7 = New System.Windows.Forms.Label
		Me.Label4 = New System.Windows.Forms.Label
		Me.Label3 = New System.Windows.Forms.Label
		Me._Label2_0 = New System.Windows.Forms.Label
		Me.CmdClrCnt = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.CmdSendBeg = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.LabLoop = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.LabLoss = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.LabRcv = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.LabSend = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.Label1 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.Label2 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.Label20 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.Label22 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.Label24 = New Microsoft.VisualBasic.Compatibility.VB6.LabelArray(components)
		Me.OptTcpUdp = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.OptTestMode = New Microsoft.VisualBasic.Compatibility.VB6.RadioButtonArray(components)
		Me.TmrSend = New Microsoft.VisualBasic.Compatibility.VB6.TimerArray(components)
		Me.TxtCntLoss = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtCntRcv = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtCntSend = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtCntSendTal = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtRcvPket = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtSendData = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtSendDataLen = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtSendIntval = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtSendPket = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.TxtSendPketTal = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.Winsock1 = New AxWinsockArray(components)
		Me.cmdCnect = New Microsoft.VisualBasic.Compatibility.VB6.ButtonArray(components)
		Me.txtLocalPort = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtPort = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.txtip = New Microsoft.VisualBasic.Compatibility.VB6.TextBoxArray(components)
		Me.MainMenu1.SuspendLayout()
		Me.Frame1.SuspendLayout()
		Me.SuspendLayout()
		Me.ToolTip1.Active = True
		CType(Me._Winsock1_3, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Winsock1_2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Winsock1_0, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Winsock1_1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Winsock1_4, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Winsock1_5, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Winsock1_6, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me._Winsock1_7, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CmdClrCnt, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.CmdSendBeg, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LabLoop, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LabLoss, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LabRcv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.LabSend, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OptTcpUdp, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.OptTestMode, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TmrSend, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtCntLoss, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtCntRcv, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtCntSend, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtCntSendTal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtRcvPket, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtSendData, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtSendDataLen, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtSendIntval, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtSendPket, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.TxtSendPketTal, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.Winsock1, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.cmdCnect, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtLocalPort, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtPort, System.ComponentModel.ISupportInitialize).BeginInit()
		CType(Me.txtip, System.ComponentModel.ISupportInitialize).BeginInit()
		Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
		Me.Text = "Serial Loopback"
		Me.ClientSize = New System.Drawing.Size(953, 758)
		Me.Location = New System.Drawing.Point(38, 30)
		Me.Icon = CType(resources.GetObject("FrmMain.Icon"), System.Drawing.Icon)
		Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
		Me.BackColor = System.Drawing.SystemColors.Control
		Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
		Me.ControlBox = True
		Me.Enabled = True
		Me.KeyPreview = False
		Me.MaximizeBox = True
		Me.MinimizeBox = True
		Me.Cursor = System.Windows.Forms.Cursors.Default
		Me.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ShowInTaskbar = True
		Me.HelpButton = False
		Me.WindowState = System.Windows.Forms.FormWindowState.Normal
		Me.Name = "FrmMain"
		Me.MnuSet.Name = "MnuSet"
		Me.MnuSet.Text = "&Setting"
		Me.MnuSet.Visible = False
		Me.MnuSet.Checked = False
		Me.MnuSet.Enabled = True
		Me.MnuSetComp.Name = "MnuSetComp"
		Me.MnuSetComp.Text = "&Company Code"
		Me.MnuSetComp.Checked = False
		Me.MnuSetComp.Enabled = True
		Me.MnuSetComp.Visible = True
		Me.MnuAddId.Name = "MnuAddId"
		Me.MnuAddId.Text = "&Add ID"
		Me.MnuAddId.Checked = False
		Me.MnuAddId.Enabled = True
		Me.MnuAddId.Visible = True
		Me.MnuSchedule.Name = "MnuSchedule"
		Me.MnuSchedule.Text = "Reader &Schedule"
		Me.MnuSchedule.Checked = False
		Me.MnuSchedule.Enabled = True
		Me.MnuSchedule.Visible = True
		Me.MnuGroup.Name = "MnuGroup"
		Me.MnuGroup.Text = "&Group"
		Me.MnuGroup.Checked = False
		Me.MnuGroup.Enabled = True
		Me.MnuGroup.Visible = True
		Me.MnuHoliday.Name = "MnuHoliday"
		Me.MnuHoliday.Text = "&Holiday"
		Me.MnuHoliday.Checked = False
		Me.MnuHoliday.Enabled = True
		Me.MnuHoliday.Visible = True
		Me.MnuSetTime.Name = "MnuSetTime"
		Me.MnuSetTime.Text = "Current &Time"
		Me.MnuSetTime.Checked = False
		Me.MnuSetTime.Enabled = True
		Me.MnuSetTime.Visible = True
		Me.MnuQuery.Name = "MnuQuery"
		Me.MnuQuery.Text = "&Query"
		Me.MnuQuery.Visible = False
		Me.MnuQuery.Checked = False
		Me.MnuQuery.Enabled = True
		Me.MnuQryComp.Name = "MnuQryComp"
		Me.MnuQryComp.Text = "&Company Code"
		Me.MnuQryComp.Checked = False
		Me.MnuQryComp.Enabled = True
		Me.MnuQryComp.Visible = True
		Me.MnuQryId.Name = "MnuQryId"
		Me.MnuQryId.Text = "Card &ID"
		Me.MnuQryId.Checked = False
		Me.MnuQryId.Enabled = True
		Me.MnuQryId.Visible = True
		Me.MnuNULL1.Enabled = True
		Me.MnuNULL1.Visible = True
		Me.MnuNULL1.Name = "MnuNULL1"
		Me.MnuQryRealT.Name = "MnuQryRealT"
		Me.MnuQryRealT.Text = "&Realtime Data"
		Me.MnuQryRealT.Checked = False
		Me.MnuQryRealT.Enabled = True
		Me.MnuQryRealT.Visible = True
		Me.chk_stopsend.Text = "Stop connecting (Type mismatch). Test again."
		Me.chk_stopsend.ForeColor = System.Drawing.Color.Red
		Me.chk_stopsend.Size = New System.Drawing.Size(297, 17)
		Me.chk_stopsend.Location = New System.Drawing.Point(352, 72)
		Me.chk_stopsend.TabIndex = 242
		Me.chk_stopsend.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chk_stopsend.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chk_stopsend.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chk_stopsend.BackColor = System.Drawing.SystemColors.Control
		Me.chk_stopsend.CausesValidation = True
		Me.chk_stopsend.Enabled = True
		Me.chk_stopsend.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk_stopsend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk_stopsend.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chk_stopsend.TabStop = True
		Me.chk_stopsend.Visible = True
		Me.chk_stopsend.Name = "chk_stopsend"
		Me.tmr_winsock.Enabled = False
		Me.tmr_winsock.Interval = 1000
		Me.chk_pingpong.Text = "PingPong"
		Me.chk_pingpong.Size = New System.Drawing.Size(89, 17)
		Me.chk_pingpong.Location = New System.Drawing.Point(264, 72)
		Me.chk_pingpong.TabIndex = 241
		Me.chk_pingpong.CheckState = System.Windows.Forms.CheckState.Checked
		Me.chk_pingpong.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.chk_pingpong.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.chk_pingpong.BackColor = System.Drawing.SystemColors.Control
		Me.chk_pingpong.CausesValidation = True
		Me.chk_pingpong.Enabled = True
		Me.chk_pingpong.ForeColor = System.Drawing.SystemColors.ControlText
		Me.chk_pingpong.Cursor = System.Windows.Forms.Cursors.Default
		Me.chk_pingpong.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.chk_pingpong.Appearance = System.Windows.Forms.Appearance.Normal
		Me.chk_pingpong.TabStop = True
		Me.chk_pingpong.Visible = True
		Me.chk_pingpong.Name = "chk_pingpong"
		Me.tmr_subtract.Interval = 500
		Me.tmr_subtract.Enabled = True
		Me.txtMappingModel.AutoSize = False
		Me.txtMappingModel.BackColor = System.Drawing.Color.FromARGB(255, 192, 192)
		Me.txtMappingModel.Size = New System.Drawing.Size(105, 33)
		Me.txtMappingModel.Location = New System.Drawing.Point(264, 184)
		Me.txtMappingModel.TabIndex = 240
		Me.txtMappingModel.Visible = False
		Me.txtMappingModel.AcceptsReturn = True
		Me.txtMappingModel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMappingModel.CausesValidation = True
		Me.txtMappingModel.Enabled = True
		Me.txtMappingModel.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMappingModel.HideSelection = True
		Me.txtMappingModel.ReadOnly = False
		Me.txtMappingModel.Maxlength = 0
		Me.txtMappingModel.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMappingModel.MultiLine = False
		Me.txtMappingModel.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMappingModel.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMappingModel.TabStop = True
		Me.txtMappingModel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMappingModel.Name = "txtMappingModel"
		Me.TxtSendDataLentoall.AutoSize = False
		Me.TxtSendDataLentoall.Size = New System.Drawing.Size(57, 18)
		Me.TxtSendDataLentoall.Location = New System.Drawing.Point(384, 40)
		Me.TxtSendDataLentoall.TabIndex = 237
		Me.TxtSendDataLentoall.Text = "1400"
		Me.TxtSendDataLentoall.AcceptsReturn = True
		Me.TxtSendDataLentoall.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtSendDataLentoall.BackColor = System.Drawing.SystemColors.Window
		Me.TxtSendDataLentoall.CausesValidation = True
		Me.TxtSendDataLentoall.Enabled = True
		Me.TxtSendDataLentoall.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtSendDataLentoall.HideSelection = True
		Me.TxtSendDataLentoall.ReadOnly = False
		Me.TxtSendDataLentoall.Maxlength = 0
		Me.TxtSendDataLentoall.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtSendDataLentoall.MultiLine = False
		Me.TxtSendDataLentoall.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtSendDataLentoall.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtSendDataLentoall.TabStop = True
		Me.TxtSendDataLentoall.Visible = True
		Me.TxtSendDataLentoall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtSendDataLentoall.Name = "TxtSendDataLentoall"
		Me.TxtSendIntvaltoall.AutoSize = False
		Me.TxtSendIntvaltoall.Size = New System.Drawing.Size(57, 18)
		Me.TxtSendIntvaltoall.Location = New System.Drawing.Point(184, 40)
		Me.TxtSendIntvaltoall.TabIndex = 236
		Me.TxtSendIntvaltoall.Text = "1000"
		Me.TxtSendIntvaltoall.AcceptsReturn = True
		Me.TxtSendIntvaltoall.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtSendIntvaltoall.BackColor = System.Drawing.SystemColors.Window
		Me.TxtSendIntvaltoall.CausesValidation = True
		Me.TxtSendIntvaltoall.Enabled = True
		Me.TxtSendIntvaltoall.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtSendIntvaltoall.HideSelection = True
		Me.TxtSendIntvaltoall.ReadOnly = False
		Me.TxtSendIntvaltoall.Maxlength = 0
		Me.TxtSendIntvaltoall.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtSendIntvaltoall.MultiLine = False
		Me.TxtSendIntvaltoall.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtSendIntvaltoall.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtSendIntvaltoall.TabStop = True
		Me.TxtSendIntvaltoall.Visible = True
		Me.TxtSendIntvaltoall.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtSendIntvaltoall.Name = "TxtSendIntvaltoall"
		Me.cmdComtesttotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdComtesttotal.BackColor = System.Drawing.Color.FromARGB(255, 192, 255)
		Me.cmdComtesttotal.Text = "Start to all"
		Me.cmdComtesttotal.Enabled = False
		Me.cmdComtesttotal.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cmdComtesttotal.Size = New System.Drawing.Size(81, 25)
		Me.cmdComtesttotal.Location = New System.Drawing.Point(592, 32)
		Me.cmdComtesttotal.TabIndex = 235
		Me.cmdComtesttotal.CausesValidation = True
		Me.cmdComtesttotal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdComtesttotal.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdComtesttotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdComtesttotal.TabStop = True
		Me.cmdComtesttotal.Name = "cmdComtesttotal"
		Me.cmdContotal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdContotal.BackColor = System.Drawing.Color.FromARGB(128, 255, 255)
		Me.cmdContotal.Text = "Connect to all"
		Me.cmdContotal.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cmdContotal.Size = New System.Drawing.Size(121, 25)
		Me.cmdContotal.Location = New System.Drawing.Point(464, 32)
		Me.cmdContotal.TabIndex = 234
		Me.cmdContotal.CausesValidation = True
		Me.cmdContotal.Enabled = True
		Me.cmdContotal.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdContotal.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdContotal.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdContotal.TabStop = True
		Me.cmdContotal.Name = "cmdContotal"
		Me._CmdClrCnt_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdClrCnt_7.Text = "Clear Counter"
		Me._CmdClrCnt_7.Size = New System.Drawing.Size(33, 17)
		Me._CmdClrCnt_7.Location = New System.Drawing.Point(448, 40)
		Me._CmdClrCnt_7.TabIndex = 233
		Me._CmdClrCnt_7.Visible = False
		Me._CmdClrCnt_7.BackColor = System.Drawing.SystemColors.Control
		Me._CmdClrCnt_7.CausesValidation = True
		Me._CmdClrCnt_7.Enabled = True
		Me._CmdClrCnt_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdClrCnt_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdClrCnt_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdClrCnt_7.TabStop = True
		Me._CmdClrCnt_7.Name = "_CmdClrCnt_7"
		Me._CmdClrCnt_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdClrCnt_6.Text = "Clear Counter"
		Me._CmdClrCnt_6.Size = New System.Drawing.Size(33, 17)
		Me._CmdClrCnt_6.Location = New System.Drawing.Point(416, 40)
		Me._CmdClrCnt_6.TabIndex = 232
		Me._CmdClrCnt_6.Visible = False
		Me._CmdClrCnt_6.BackColor = System.Drawing.SystemColors.Control
		Me._CmdClrCnt_6.CausesValidation = True
		Me._CmdClrCnt_6.Enabled = True
		Me._CmdClrCnt_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdClrCnt_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdClrCnt_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdClrCnt_6.TabStop = True
		Me._CmdClrCnt_6.Name = "_CmdClrCnt_6"
		Me._CmdClrCnt_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdClrCnt_5.Text = "Clear Counter"
		Me._CmdClrCnt_5.Size = New System.Drawing.Size(33, 17)
		Me._CmdClrCnt_5.Location = New System.Drawing.Point(384, 40)
		Me._CmdClrCnt_5.TabIndex = 231
		Me._CmdClrCnt_5.Visible = False
		Me._CmdClrCnt_5.BackColor = System.Drawing.SystemColors.Control
		Me._CmdClrCnt_5.CausesValidation = True
		Me._CmdClrCnt_5.Enabled = True
		Me._CmdClrCnt_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdClrCnt_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdClrCnt_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdClrCnt_5.TabStop = True
		Me._CmdClrCnt_5.Name = "_CmdClrCnt_5"
		Me._CmdClrCnt_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdClrCnt_4.Text = "Clear Counter"
		Me._CmdClrCnt_4.Size = New System.Drawing.Size(33, 17)
		Me._CmdClrCnt_4.Location = New System.Drawing.Point(352, 40)
		Me._CmdClrCnt_4.TabIndex = 230
		Me._CmdClrCnt_4.Visible = False
		Me._CmdClrCnt_4.BackColor = System.Drawing.SystemColors.Control
		Me._CmdClrCnt_4.CausesValidation = True
		Me._CmdClrCnt_4.Enabled = True
		Me._CmdClrCnt_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdClrCnt_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdClrCnt_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdClrCnt_4.TabStop = True
		Me._CmdClrCnt_4.Name = "_CmdClrCnt_4"
		Me._TmrSend_7.Enabled = False
		Me._TmrSend_7.Interval = 1
		Me._TmrSend_6.Enabled = False
		Me._TmrSend_6.Interval = 1
		Me._TxtRcvPket_7.AutoSize = False
		Me._TxtRcvPket_7.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtRcvPket_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtRcvPket_7.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtRcvPket_7.Size = New System.Drawing.Size(57, 25)
		Me._TxtRcvPket_7.Location = New System.Drawing.Point(864, 556)
		Me._TxtRcvPket_7.TabIndex = 219
		Me._TxtRcvPket_7.Text = "0"
		Me._TxtRcvPket_7.AcceptsReturn = True
		Me._TxtRcvPket_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtRcvPket_7.CausesValidation = True
		Me._TxtRcvPket_7.Enabled = True
		Me._TxtRcvPket_7.HideSelection = True
		Me._TxtRcvPket_7.ReadOnly = False
		Me._TxtRcvPket_7.Maxlength = 0
		Me._TxtRcvPket_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtRcvPket_7.MultiLine = False
		Me._TxtRcvPket_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtRcvPket_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtRcvPket_7.TabStop = True
		Me._TxtRcvPket_7.Visible = True
		Me._TxtRcvPket_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtRcvPket_7.Name = "_TxtRcvPket_7"
		Me._TxtSendPket_7.AutoSize = False
		Me._TxtSendPket_7.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPket_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPket_7.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPket_7.Location = New System.Drawing.Point(864, 524)
		Me._TxtSendPket_7.TabIndex = 218
		Me._TxtSendPket_7.Text = "0"
		Me._TxtSendPket_7.Visible = False
		Me._TxtSendPket_7.AcceptsReturn = True
		Me._TxtSendPket_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPket_7.CausesValidation = True
		Me._TxtSendPket_7.Enabled = True
		Me._TxtSendPket_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendPket_7.HideSelection = True
		Me._TxtSendPket_7.ReadOnly = False
		Me._TxtSendPket_7.Maxlength = 0
		Me._TxtSendPket_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPket_7.MultiLine = False
		Me._TxtSendPket_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPket_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPket_7.TabStop = True
		Me._TxtSendPket_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPket_7.Name = "_TxtSendPket_7"
		Me._TxtSendPketTal_7.AutoSize = False
		Me._TxtSendPketTal_7.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPketTal_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPketTal_7.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtSendPketTal_7.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPketTal_7.Location = New System.Drawing.Point(864, 492)
		Me._TxtSendPketTal_7.TabIndex = 217
		Me._TxtSendPketTal_7.Text = "0"
		Me._TxtSendPketTal_7.AcceptsReturn = True
		Me._TxtSendPketTal_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPketTal_7.CausesValidation = True
		Me._TxtSendPketTal_7.Enabled = True
		Me._TxtSendPketTal_7.HideSelection = True
		Me._TxtSendPketTal_7.ReadOnly = False
		Me._TxtSendPketTal_7.Maxlength = 0
		Me._TxtSendPketTal_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPketTal_7.MultiLine = False
		Me._TxtSendPketTal_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPketTal_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPketTal_7.TabStop = True
		Me._TxtSendPketTal_7.Visible = True
		Me._TxtSendPketTal_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPketTal_7.Name = "_TxtSendPketTal_7"
		Me._TxtCntSendTal_7.AutoSize = False
		Me._TxtCntSendTal_7.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSendTal_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSendTal_7.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._TxtCntSendTal_7.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSendTal_7.Location = New System.Drawing.Point(728, 492)
		Me._TxtCntSendTal_7.TabIndex = 216
		Me._TxtCntSendTal_7.Text = "0"
		Me._TxtCntSendTal_7.AcceptsReturn = True
		Me._TxtCntSendTal_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSendTal_7.CausesValidation = True
		Me._TxtCntSendTal_7.Enabled = True
		Me._TxtCntSendTal_7.HideSelection = True
		Me._TxtCntSendTal_7.ReadOnly = False
		Me._TxtCntSendTal_7.Maxlength = 0
		Me._TxtCntSendTal_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSendTal_7.MultiLine = False
		Me._TxtCntSendTal_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSendTal_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSendTal_7.TabStop = True
		Me._TxtCntSendTal_7.Visible = True
		Me._TxtCntSendTal_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSendTal_7.Name = "_TxtCntSendTal_7"
		Me._TxtCntSend_7.AutoSize = False
		Me._TxtCntSend_7.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSend_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSend_7.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntSend_7.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSend_7.Location = New System.Drawing.Point(728, 524)
		Me._TxtCntSend_7.TabIndex = 215
		Me._TxtCntSend_7.Text = "0"
		Me._TxtCntSend_7.AcceptsReturn = True
		Me._TxtCntSend_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSend_7.CausesValidation = True
		Me._TxtCntSend_7.Enabled = True
		Me._TxtCntSend_7.HideSelection = True
		Me._TxtCntSend_7.ReadOnly = False
		Me._TxtCntSend_7.Maxlength = 0
		Me._TxtCntSend_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSend_7.MultiLine = False
		Me._TxtCntSend_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSend_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSend_7.TabStop = True
		Me._TxtCntSend_7.Visible = True
		Me._TxtCntSend_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSend_7.Name = "_TxtCntSend_7"
		Me._TxtCntRcv_7.AutoSize = False
		Me._TxtCntRcv_7.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntRcv_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntRcv_7.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntRcv_7.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntRcv_7.Location = New System.Drawing.Point(728, 556)
		Me._TxtCntRcv_7.TabIndex = 214
		Me._TxtCntRcv_7.Text = "0"
		Me._TxtCntRcv_7.AcceptsReturn = True
		Me._TxtCntRcv_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntRcv_7.CausesValidation = True
		Me._TxtCntRcv_7.Enabled = True
		Me._TxtCntRcv_7.HideSelection = True
		Me._TxtCntRcv_7.ReadOnly = False
		Me._TxtCntRcv_7.Maxlength = 0
		Me._TxtCntRcv_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntRcv_7.MultiLine = False
		Me._TxtCntRcv_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntRcv_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntRcv_7.TabStop = True
		Me._TxtCntRcv_7.Visible = True
		Me._TxtCntRcv_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntRcv_7.Name = "_TxtCntRcv_7"
		Me._TxtCntLoss_7.AutoSize = False
		Me._TxtCntLoss_7.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntLoss_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntLoss_7.ForeColor = System.Drawing.Color.Red
		Me._TxtCntLoss_7.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntLoss_7.Location = New System.Drawing.Point(728, 584)
		Me._TxtCntLoss_7.TabIndex = 213
		Me._TxtCntLoss_7.Text = "0"
		Me._TxtCntLoss_7.AcceptsReturn = True
		Me._TxtCntLoss_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntLoss_7.CausesValidation = True
		Me._TxtCntLoss_7.Enabled = True
		Me._TxtCntLoss_7.HideSelection = True
		Me._TxtCntLoss_7.ReadOnly = False
		Me._TxtCntLoss_7.Maxlength = 0
		Me._TxtCntLoss_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntLoss_7.MultiLine = False
		Me._TxtCntLoss_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntLoss_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntLoss_7.TabStop = True
		Me._TxtCntLoss_7.Visible = True
		Me._TxtCntLoss_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntLoss_7.Name = "_TxtCntLoss_7"
		Me._CmdSendBeg_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdSendBeg_7.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._CmdSendBeg_7.Text = "Start COM8"
		Me._CmdSendBeg_7.Enabled = False
		Me._CmdSendBeg_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdSendBeg_7.Size = New System.Drawing.Size(81, 25)
		Me._CmdSendBeg_7.Location = New System.Drawing.Point(728, 460)
		Me._CmdSendBeg_7.TabIndex = 212
		Me._CmdSendBeg_7.CausesValidation = True
		Me._CmdSendBeg_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdSendBeg_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdSendBeg_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdSendBeg_7.TabStop = True
		Me._CmdSendBeg_7.Name = "_CmdSendBeg_7"
		Me._TxtSendDataLen_7.AutoSize = False
		Me._TxtSendDataLen_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendDataLen_7.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendDataLen_7.Location = New System.Drawing.Point(808, 432)
		Me._TxtSendDataLen_7.TabIndex = 211
		Me._TxtSendDataLen_7.Text = "10"
		Me._TxtSendDataLen_7.AcceptsReturn = True
		Me._TxtSendDataLen_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendDataLen_7.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendDataLen_7.CausesValidation = True
		Me._TxtSendDataLen_7.Enabled = True
		Me._TxtSendDataLen_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendDataLen_7.HideSelection = True
		Me._TxtSendDataLen_7.ReadOnly = False
		Me._TxtSendDataLen_7.Maxlength = 0
		Me._TxtSendDataLen_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendDataLen_7.MultiLine = False
		Me._TxtSendDataLen_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendDataLen_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendDataLen_7.TabStop = True
		Me._TxtSendDataLen_7.Visible = True
		Me._TxtSendDataLen_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendDataLen_7.Name = "_TxtSendDataLen_7"
		Me._TxtSendIntval_7.AutoSize = False
		Me._TxtSendIntval_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendIntval_7.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendIntval_7.Location = New System.Drawing.Point(808, 408)
		Me._TxtSendIntval_7.TabIndex = 210
		Me._TxtSendIntval_7.Text = "1000"
		Me.ToolTip1.SetToolTip(Me._TxtSendIntval_7, "=0: waiting response; >0: period sending")
		Me._TxtSendIntval_7.AcceptsReturn = True
		Me._TxtSendIntval_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendIntval_7.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendIntval_7.CausesValidation = True
		Me._TxtSendIntval_7.Enabled = True
		Me._TxtSendIntval_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendIntval_7.HideSelection = True
		Me._TxtSendIntval_7.ReadOnly = False
		Me._TxtSendIntval_7.Maxlength = 0
		Me._TxtSendIntval_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendIntval_7.MultiLine = False
		Me._TxtSendIntval_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendIntval_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendIntval_7.TabStop = True
		Me._TxtSendIntval_7.Visible = True
		Me._TxtSendIntval_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendIntval_7.Name = "_TxtSendIntval_7"
		Me._TxtSendData_7.AutoSize = False
		Me._TxtSendData_7.Size = New System.Drawing.Size(193, 25)
		Me._TxtSendData_7.Location = New System.Drawing.Point(728, 608)
		Me._TxtSendData_7.TabIndex = 209
		Me._TxtSendData_7.Visible = False
		Me._TxtSendData_7.AcceptsReturn = True
		Me._TxtSendData_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendData_7.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendData_7.CausesValidation = True
		Me._TxtSendData_7.Enabled = True
		Me._TxtSendData_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendData_7.HideSelection = True
		Me._TxtSendData_7.ReadOnly = False
		Me._TxtSendData_7.Maxlength = 0
		Me._TxtSendData_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendData_7.MultiLine = False
		Me._TxtSendData_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendData_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendData_7.TabStop = True
		Me._TxtSendData_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendData_7.Name = "_TxtSendData_7"
		Me._TxtRcvPket_6.AutoSize = False
		Me._TxtRcvPket_6.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtRcvPket_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtRcvPket_6.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtRcvPket_6.Size = New System.Drawing.Size(57, 25)
		Me._TxtRcvPket_6.Location = New System.Drawing.Point(864, 320)
		Me._TxtRcvPket_6.TabIndex = 203
		Me._TxtRcvPket_6.Text = "0"
		Me._TxtRcvPket_6.AcceptsReturn = True
		Me._TxtRcvPket_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtRcvPket_6.CausesValidation = True
		Me._TxtRcvPket_6.Enabled = True
		Me._TxtRcvPket_6.HideSelection = True
		Me._TxtRcvPket_6.ReadOnly = False
		Me._TxtRcvPket_6.Maxlength = 0
		Me._TxtRcvPket_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtRcvPket_6.MultiLine = False
		Me._TxtRcvPket_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtRcvPket_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtRcvPket_6.TabStop = True
		Me._TxtRcvPket_6.Visible = True
		Me._TxtRcvPket_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtRcvPket_6.Name = "_TxtRcvPket_6"
		Me._TxtSendPket_6.AutoSize = False
		Me._TxtSendPket_6.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPket_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPket_6.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPket_6.Location = New System.Drawing.Point(864, 288)
		Me._TxtSendPket_6.TabIndex = 202
		Me._TxtSendPket_6.Text = "0"
		Me._TxtSendPket_6.Visible = False
		Me._TxtSendPket_6.AcceptsReturn = True
		Me._TxtSendPket_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPket_6.CausesValidation = True
		Me._TxtSendPket_6.Enabled = True
		Me._TxtSendPket_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendPket_6.HideSelection = True
		Me._TxtSendPket_6.ReadOnly = False
		Me._TxtSendPket_6.Maxlength = 0
		Me._TxtSendPket_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPket_6.MultiLine = False
		Me._TxtSendPket_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPket_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPket_6.TabStop = True
		Me._TxtSendPket_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPket_6.Name = "_TxtSendPket_6"
		Me._TxtSendPketTal_6.AutoSize = False
		Me._TxtSendPketTal_6.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPketTal_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPketTal_6.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtSendPketTal_6.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPketTal_6.Location = New System.Drawing.Point(864, 256)
		Me._TxtSendPketTal_6.TabIndex = 201
		Me._TxtSendPketTal_6.Text = "0"
		Me._TxtSendPketTal_6.AcceptsReturn = True
		Me._TxtSendPketTal_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPketTal_6.CausesValidation = True
		Me._TxtSendPketTal_6.Enabled = True
		Me._TxtSendPketTal_6.HideSelection = True
		Me._TxtSendPketTal_6.ReadOnly = False
		Me._TxtSendPketTal_6.Maxlength = 0
		Me._TxtSendPketTal_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPketTal_6.MultiLine = False
		Me._TxtSendPketTal_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPketTal_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPketTal_6.TabStop = True
		Me._TxtSendPketTal_6.Visible = True
		Me._TxtSendPketTal_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPketTal_6.Name = "_TxtSendPketTal_6"
		Me._TxtCntSendTal_6.AutoSize = False
		Me._TxtCntSendTal_6.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSendTal_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSendTal_6.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._TxtCntSendTal_6.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSendTal_6.Location = New System.Drawing.Point(728, 256)
		Me._TxtCntSendTal_6.TabIndex = 200
		Me._TxtCntSendTal_6.Text = "0"
		Me._TxtCntSendTal_6.AcceptsReturn = True
		Me._TxtCntSendTal_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSendTal_6.CausesValidation = True
		Me._TxtCntSendTal_6.Enabled = True
		Me._TxtCntSendTal_6.HideSelection = True
		Me._TxtCntSendTal_6.ReadOnly = False
		Me._TxtCntSendTal_6.Maxlength = 0
		Me._TxtCntSendTal_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSendTal_6.MultiLine = False
		Me._TxtCntSendTal_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSendTal_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSendTal_6.TabStop = True
		Me._TxtCntSendTal_6.Visible = True
		Me._TxtCntSendTal_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSendTal_6.Name = "_TxtCntSendTal_6"
		Me._TxtCntSend_6.AutoSize = False
		Me._TxtCntSend_6.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSend_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSend_6.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntSend_6.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSend_6.Location = New System.Drawing.Point(728, 288)
		Me._TxtCntSend_6.TabIndex = 199
		Me._TxtCntSend_6.Text = "0"
		Me._TxtCntSend_6.AcceptsReturn = True
		Me._TxtCntSend_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSend_6.CausesValidation = True
		Me._TxtCntSend_6.Enabled = True
		Me._TxtCntSend_6.HideSelection = True
		Me._TxtCntSend_6.ReadOnly = False
		Me._TxtCntSend_6.Maxlength = 0
		Me._TxtCntSend_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSend_6.MultiLine = False
		Me._TxtCntSend_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSend_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSend_6.TabStop = True
		Me._TxtCntSend_6.Visible = True
		Me._TxtCntSend_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSend_6.Name = "_TxtCntSend_6"
		Me._TxtCntRcv_6.AutoSize = False
		Me._TxtCntRcv_6.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntRcv_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntRcv_6.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntRcv_6.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntRcv_6.Location = New System.Drawing.Point(728, 320)
		Me._TxtCntRcv_6.TabIndex = 198
		Me._TxtCntRcv_6.Text = "0"
		Me._TxtCntRcv_6.AcceptsReturn = True
		Me._TxtCntRcv_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntRcv_6.CausesValidation = True
		Me._TxtCntRcv_6.Enabled = True
		Me._TxtCntRcv_6.HideSelection = True
		Me._TxtCntRcv_6.ReadOnly = False
		Me._TxtCntRcv_6.Maxlength = 0
		Me._TxtCntRcv_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntRcv_6.MultiLine = False
		Me._TxtCntRcv_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntRcv_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntRcv_6.TabStop = True
		Me._TxtCntRcv_6.Visible = True
		Me._TxtCntRcv_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntRcv_6.Name = "_TxtCntRcv_6"
		Me._TxtCntLoss_6.AutoSize = False
		Me._TxtCntLoss_6.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntLoss_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntLoss_6.ForeColor = System.Drawing.Color.Red
		Me._TxtCntLoss_6.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntLoss_6.Location = New System.Drawing.Point(728, 352)
		Me._TxtCntLoss_6.TabIndex = 197
		Me._TxtCntLoss_6.Text = "0"
		Me._TxtCntLoss_6.AcceptsReturn = True
		Me._TxtCntLoss_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntLoss_6.CausesValidation = True
		Me._TxtCntLoss_6.Enabled = True
		Me._TxtCntLoss_6.HideSelection = True
		Me._TxtCntLoss_6.ReadOnly = False
		Me._TxtCntLoss_6.Maxlength = 0
		Me._TxtCntLoss_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntLoss_6.MultiLine = False
		Me._TxtCntLoss_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntLoss_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntLoss_6.TabStop = True
		Me._TxtCntLoss_6.Visible = True
		Me._TxtCntLoss_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntLoss_6.Name = "_TxtCntLoss_6"
		Me._CmdSendBeg_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdSendBeg_6.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._CmdSendBeg_6.Text = "Start COM7"
		Me._CmdSendBeg_6.Enabled = False
		Me._CmdSendBeg_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdSendBeg_6.Size = New System.Drawing.Size(81, 25)
		Me._CmdSendBeg_6.Location = New System.Drawing.Point(728, 224)
		Me._CmdSendBeg_6.TabIndex = 196
		Me._CmdSendBeg_6.CausesValidation = True
		Me._CmdSendBeg_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdSendBeg_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdSendBeg_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdSendBeg_6.TabStop = True
		Me._CmdSendBeg_6.Name = "_CmdSendBeg_6"
		Me._TxtSendDataLen_6.AutoSize = False
		Me._TxtSendDataLen_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendDataLen_6.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendDataLen_6.Location = New System.Drawing.Point(808, 200)
		Me._TxtSendDataLen_6.TabIndex = 195
		Me._TxtSendDataLen_6.Text = "10"
		Me._TxtSendDataLen_6.AcceptsReturn = True
		Me._TxtSendDataLen_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendDataLen_6.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendDataLen_6.CausesValidation = True
		Me._TxtSendDataLen_6.Enabled = True
		Me._TxtSendDataLen_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendDataLen_6.HideSelection = True
		Me._TxtSendDataLen_6.ReadOnly = False
		Me._TxtSendDataLen_6.Maxlength = 0
		Me._TxtSendDataLen_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendDataLen_6.MultiLine = False
		Me._TxtSendDataLen_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendDataLen_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendDataLen_6.TabStop = True
		Me._TxtSendDataLen_6.Visible = True
		Me._TxtSendDataLen_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendDataLen_6.Name = "_TxtSendDataLen_6"
		Me._TxtSendIntval_6.AutoSize = False
		Me._TxtSendIntval_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendIntval_6.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendIntval_6.Location = New System.Drawing.Point(808, 176)
		Me._TxtSendIntval_6.TabIndex = 194
		Me._TxtSendIntval_6.Text = "1000"
		Me.ToolTip1.SetToolTip(Me._TxtSendIntval_6, "=0: waiting response; >0: period sending")
		Me._TxtSendIntval_6.AcceptsReturn = True
		Me._TxtSendIntval_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendIntval_6.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendIntval_6.CausesValidation = True
		Me._TxtSendIntval_6.Enabled = True
		Me._TxtSendIntval_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendIntval_6.HideSelection = True
		Me._TxtSendIntval_6.ReadOnly = False
		Me._TxtSendIntval_6.Maxlength = 0
		Me._TxtSendIntval_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendIntval_6.MultiLine = False
		Me._TxtSendIntval_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendIntval_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendIntval_6.TabStop = True
		Me._TxtSendIntval_6.Visible = True
		Me._TxtSendIntval_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendIntval_6.Name = "_TxtSendIntval_6"
		Me._TxtSendData_6.AutoSize = False
		Me._TxtSendData_6.Size = New System.Drawing.Size(193, 25)
		Me._TxtSendData_6.Location = New System.Drawing.Point(728, 376)
		Me._TxtSendData_6.TabIndex = 193
		Me._TxtSendData_6.Visible = False
		Me._TxtSendData_6.AcceptsReturn = True
		Me._TxtSendData_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendData_6.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendData_6.CausesValidation = True
		Me._TxtSendData_6.Enabled = True
		Me._TxtSendData_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendData_6.HideSelection = True
		Me._TxtSendData_6.ReadOnly = False
		Me._TxtSendData_6.Maxlength = 0
		Me._TxtSendData_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendData_6.MultiLine = False
		Me._TxtSendData_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendData_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendData_6.TabStop = True
		Me._TxtSendData_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendData_6.Name = "_TxtSendData_6"
		Me._TxtRcvPket_5.AutoSize = False
		Me._TxtRcvPket_5.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtRcvPket_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtRcvPket_5.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtRcvPket_5.Size = New System.Drawing.Size(57, 25)
		Me._TxtRcvPket_5.Location = New System.Drawing.Point(656, 556)
		Me._TxtRcvPket_5.TabIndex = 187
		Me._TxtRcvPket_5.Text = "0"
		Me._TxtRcvPket_5.AcceptsReturn = True
		Me._TxtRcvPket_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtRcvPket_5.CausesValidation = True
		Me._TxtRcvPket_5.Enabled = True
		Me._TxtRcvPket_5.HideSelection = True
		Me._TxtRcvPket_5.ReadOnly = False
		Me._TxtRcvPket_5.Maxlength = 0
		Me._TxtRcvPket_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtRcvPket_5.MultiLine = False
		Me._TxtRcvPket_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtRcvPket_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtRcvPket_5.TabStop = True
		Me._TxtRcvPket_5.Visible = True
		Me._TxtRcvPket_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtRcvPket_5.Name = "_TxtRcvPket_5"
		Me._TxtSendPket_5.AutoSize = False
		Me._TxtSendPket_5.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPket_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPket_5.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPket_5.Location = New System.Drawing.Point(656, 524)
		Me._TxtSendPket_5.TabIndex = 186
		Me._TxtSendPket_5.Text = "0"
		Me._TxtSendPket_5.Visible = False
		Me._TxtSendPket_5.AcceptsReturn = True
		Me._TxtSendPket_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPket_5.CausesValidation = True
		Me._TxtSendPket_5.Enabled = True
		Me._TxtSendPket_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendPket_5.HideSelection = True
		Me._TxtSendPket_5.ReadOnly = False
		Me._TxtSendPket_5.Maxlength = 0
		Me._TxtSendPket_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPket_5.MultiLine = False
		Me._TxtSendPket_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPket_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPket_5.TabStop = True
		Me._TxtSendPket_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPket_5.Name = "_TxtSendPket_5"
		Me._TxtSendPketTal_5.AutoSize = False
		Me._TxtSendPketTal_5.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPketTal_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPketTal_5.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtSendPketTal_5.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPketTal_5.Location = New System.Drawing.Point(656, 492)
		Me._TxtSendPketTal_5.TabIndex = 185
		Me._TxtSendPketTal_5.Text = "0"
		Me._TxtSendPketTal_5.AcceptsReturn = True
		Me._TxtSendPketTal_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPketTal_5.CausesValidation = True
		Me._TxtSendPketTal_5.Enabled = True
		Me._TxtSendPketTal_5.HideSelection = True
		Me._TxtSendPketTal_5.ReadOnly = False
		Me._TxtSendPketTal_5.Maxlength = 0
		Me._TxtSendPketTal_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPketTal_5.MultiLine = False
		Me._TxtSendPketTal_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPketTal_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPketTal_5.TabStop = True
		Me._TxtSendPketTal_5.Visible = True
		Me._TxtSendPketTal_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPketTal_5.Name = "_TxtSendPketTal_5"
		Me._TxtCntSendTal_5.AutoSize = False
		Me._TxtCntSendTal_5.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSendTal_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSendTal_5.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._TxtCntSendTal_5.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSendTal_5.Location = New System.Drawing.Point(520, 492)
		Me._TxtCntSendTal_5.TabIndex = 184
		Me._TxtCntSendTal_5.Text = "0"
		Me._TxtCntSendTal_5.AcceptsReturn = True
		Me._TxtCntSendTal_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSendTal_5.CausesValidation = True
		Me._TxtCntSendTal_5.Enabled = True
		Me._TxtCntSendTal_5.HideSelection = True
		Me._TxtCntSendTal_5.ReadOnly = False
		Me._TxtCntSendTal_5.Maxlength = 0
		Me._TxtCntSendTal_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSendTal_5.MultiLine = False
		Me._TxtCntSendTal_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSendTal_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSendTal_5.TabStop = True
		Me._TxtCntSendTal_5.Visible = True
		Me._TxtCntSendTal_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSendTal_5.Name = "_TxtCntSendTal_5"
		Me._TxtCntSend_5.AutoSize = False
		Me._TxtCntSend_5.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSend_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSend_5.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntSend_5.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSend_5.Location = New System.Drawing.Point(520, 524)
		Me._TxtCntSend_5.TabIndex = 183
		Me._TxtCntSend_5.Text = "0"
		Me._TxtCntSend_5.AcceptsReturn = True
		Me._TxtCntSend_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSend_5.CausesValidation = True
		Me._TxtCntSend_5.Enabled = True
		Me._TxtCntSend_5.HideSelection = True
		Me._TxtCntSend_5.ReadOnly = False
		Me._TxtCntSend_5.Maxlength = 0
		Me._TxtCntSend_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSend_5.MultiLine = False
		Me._TxtCntSend_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSend_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSend_5.TabStop = True
		Me._TxtCntSend_5.Visible = True
		Me._TxtCntSend_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSend_5.Name = "_TxtCntSend_5"
		Me._TxtCntRcv_5.AutoSize = False
		Me._TxtCntRcv_5.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntRcv_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntRcv_5.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntRcv_5.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntRcv_5.Location = New System.Drawing.Point(520, 556)
		Me._TxtCntRcv_5.TabIndex = 182
		Me._TxtCntRcv_5.Text = "0"
		Me._TxtCntRcv_5.AcceptsReturn = True
		Me._TxtCntRcv_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntRcv_5.CausesValidation = True
		Me._TxtCntRcv_5.Enabled = True
		Me._TxtCntRcv_5.HideSelection = True
		Me._TxtCntRcv_5.ReadOnly = False
		Me._TxtCntRcv_5.Maxlength = 0
		Me._TxtCntRcv_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntRcv_5.MultiLine = False
		Me._TxtCntRcv_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntRcv_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntRcv_5.TabStop = True
		Me._TxtCntRcv_5.Visible = True
		Me._TxtCntRcv_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntRcv_5.Name = "_TxtCntRcv_5"
		Me._TxtCntLoss_5.AutoSize = False
		Me._TxtCntLoss_5.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntLoss_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntLoss_5.ForeColor = System.Drawing.Color.Red
		Me._TxtCntLoss_5.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntLoss_5.Location = New System.Drawing.Point(520, 584)
		Me._TxtCntLoss_5.TabIndex = 181
		Me._TxtCntLoss_5.Text = "0"
		Me._TxtCntLoss_5.AcceptsReturn = True
		Me._TxtCntLoss_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntLoss_5.CausesValidation = True
		Me._TxtCntLoss_5.Enabled = True
		Me._TxtCntLoss_5.HideSelection = True
		Me._TxtCntLoss_5.ReadOnly = False
		Me._TxtCntLoss_5.Maxlength = 0
		Me._TxtCntLoss_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntLoss_5.MultiLine = False
		Me._TxtCntLoss_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntLoss_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntLoss_5.TabStop = True
		Me._TxtCntLoss_5.Visible = True
		Me._TxtCntLoss_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntLoss_5.Name = "_TxtCntLoss_5"
		Me._CmdSendBeg_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdSendBeg_5.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._CmdSendBeg_5.Text = "Start COM6"
		Me._CmdSendBeg_5.Enabled = False
		Me._CmdSendBeg_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdSendBeg_5.Size = New System.Drawing.Size(81, 25)
		Me._CmdSendBeg_5.Location = New System.Drawing.Point(520, 460)
		Me._CmdSendBeg_5.TabIndex = 180
		Me._CmdSendBeg_5.CausesValidation = True
		Me._CmdSendBeg_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdSendBeg_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdSendBeg_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdSendBeg_5.TabStop = True
		Me._CmdSendBeg_5.Name = "_CmdSendBeg_5"
		Me._TxtSendDataLen_5.AutoSize = False
		Me._TxtSendDataLen_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendDataLen_5.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendDataLen_5.Location = New System.Drawing.Point(600, 432)
		Me._TxtSendDataLen_5.TabIndex = 179
		Me._TxtSendDataLen_5.Text = "10"
		Me._TxtSendDataLen_5.AcceptsReturn = True
		Me._TxtSendDataLen_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendDataLen_5.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendDataLen_5.CausesValidation = True
		Me._TxtSendDataLen_5.Enabled = True
		Me._TxtSendDataLen_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendDataLen_5.HideSelection = True
		Me._TxtSendDataLen_5.ReadOnly = False
		Me._TxtSendDataLen_5.Maxlength = 0
		Me._TxtSendDataLen_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendDataLen_5.MultiLine = False
		Me._TxtSendDataLen_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendDataLen_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendDataLen_5.TabStop = True
		Me._TxtSendDataLen_5.Visible = True
		Me._TxtSendDataLen_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendDataLen_5.Name = "_TxtSendDataLen_5"
		Me._TxtSendIntval_5.AutoSize = False
		Me._TxtSendIntval_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendIntval_5.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendIntval_5.Location = New System.Drawing.Point(600, 408)
		Me._TxtSendIntval_5.TabIndex = 178
		Me._TxtSendIntval_5.Text = "1000"
		Me.ToolTip1.SetToolTip(Me._TxtSendIntval_5, "=0: waiting response; >0: period sending")
		Me._TxtSendIntval_5.AcceptsReturn = True
		Me._TxtSendIntval_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendIntval_5.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendIntval_5.CausesValidation = True
		Me._TxtSendIntval_5.Enabled = True
		Me._TxtSendIntval_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendIntval_5.HideSelection = True
		Me._TxtSendIntval_5.ReadOnly = False
		Me._TxtSendIntval_5.Maxlength = 0
		Me._TxtSendIntval_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendIntval_5.MultiLine = False
		Me._TxtSendIntval_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendIntval_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendIntval_5.TabStop = True
		Me._TxtSendIntval_5.Visible = True
		Me._TxtSendIntval_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendIntval_5.Name = "_TxtSendIntval_5"
		Me._TxtSendData_5.AutoSize = False
		Me._TxtSendData_5.Size = New System.Drawing.Size(193, 25)
		Me._TxtSendData_5.Location = New System.Drawing.Point(520, 608)
		Me._TxtSendData_5.TabIndex = 177
		Me._TxtSendData_5.Visible = False
		Me._TxtSendData_5.AcceptsReturn = True
		Me._TxtSendData_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendData_5.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendData_5.CausesValidation = True
		Me._TxtSendData_5.Enabled = True
		Me._TxtSendData_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendData_5.HideSelection = True
		Me._TxtSendData_5.ReadOnly = False
		Me._TxtSendData_5.Maxlength = 0
		Me._TxtSendData_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendData_5.MultiLine = False
		Me._TxtSendData_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendData_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendData_5.TabStop = True
		Me._TxtSendData_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendData_5.Name = "_TxtSendData_5"
		Me._TxtRcvPket_4.AutoSize = False
		Me._TxtRcvPket_4.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtRcvPket_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtRcvPket_4.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtRcvPket_4.Size = New System.Drawing.Size(57, 25)
		Me._TxtRcvPket_4.Location = New System.Drawing.Point(656, 320)
		Me._TxtRcvPket_4.TabIndex = 171
		Me._TxtRcvPket_4.Text = "0"
		Me._TxtRcvPket_4.AcceptsReturn = True
		Me._TxtRcvPket_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtRcvPket_4.CausesValidation = True
		Me._TxtRcvPket_4.Enabled = True
		Me._TxtRcvPket_4.HideSelection = True
		Me._TxtRcvPket_4.ReadOnly = False
		Me._TxtRcvPket_4.Maxlength = 0
		Me._TxtRcvPket_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtRcvPket_4.MultiLine = False
		Me._TxtRcvPket_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtRcvPket_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtRcvPket_4.TabStop = True
		Me._TxtRcvPket_4.Visible = True
		Me._TxtRcvPket_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtRcvPket_4.Name = "_TxtRcvPket_4"
		Me._TxtSendPket_4.AutoSize = False
		Me._TxtSendPket_4.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPket_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPket_4.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPket_4.Location = New System.Drawing.Point(656, 288)
		Me._TxtSendPket_4.TabIndex = 170
		Me._TxtSendPket_4.Text = "0"
		Me._TxtSendPket_4.Visible = False
		Me._TxtSendPket_4.AcceptsReturn = True
		Me._TxtSendPket_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPket_4.CausesValidation = True
		Me._TxtSendPket_4.Enabled = True
		Me._TxtSendPket_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendPket_4.HideSelection = True
		Me._TxtSendPket_4.ReadOnly = False
		Me._TxtSendPket_4.Maxlength = 0
		Me._TxtSendPket_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPket_4.MultiLine = False
		Me._TxtSendPket_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPket_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPket_4.TabStop = True
		Me._TxtSendPket_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPket_4.Name = "_TxtSendPket_4"
		Me._TxtSendPketTal_4.AutoSize = False
		Me._TxtSendPketTal_4.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPketTal_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPketTal_4.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtSendPketTal_4.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPketTal_4.Location = New System.Drawing.Point(656, 256)
		Me._TxtSendPketTal_4.TabIndex = 169
		Me._TxtSendPketTal_4.Text = "0"
		Me._TxtSendPketTal_4.AcceptsReturn = True
		Me._TxtSendPketTal_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPketTal_4.CausesValidation = True
		Me._TxtSendPketTal_4.Enabled = True
		Me._TxtSendPketTal_4.HideSelection = True
		Me._TxtSendPketTal_4.ReadOnly = False
		Me._TxtSendPketTal_4.Maxlength = 0
		Me._TxtSendPketTal_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPketTal_4.MultiLine = False
		Me._TxtSendPketTal_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPketTal_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPketTal_4.TabStop = True
		Me._TxtSendPketTal_4.Visible = True
		Me._TxtSendPketTal_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPketTal_4.Name = "_TxtSendPketTal_4"
		Me._TxtCntSendTal_4.AutoSize = False
		Me._TxtCntSendTal_4.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSendTal_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSendTal_4.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._TxtCntSendTal_4.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSendTal_4.Location = New System.Drawing.Point(520, 256)
		Me._TxtCntSendTal_4.TabIndex = 168
		Me._TxtCntSendTal_4.Text = "0"
		Me._TxtCntSendTal_4.AcceptsReturn = True
		Me._TxtCntSendTal_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSendTal_4.CausesValidation = True
		Me._TxtCntSendTal_4.Enabled = True
		Me._TxtCntSendTal_4.HideSelection = True
		Me._TxtCntSendTal_4.ReadOnly = False
		Me._TxtCntSendTal_4.Maxlength = 0
		Me._TxtCntSendTal_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSendTal_4.MultiLine = False
		Me._TxtCntSendTal_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSendTal_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSendTal_4.TabStop = True
		Me._TxtCntSendTal_4.Visible = True
		Me._TxtCntSendTal_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSendTal_4.Name = "_TxtCntSendTal_4"
		Me._TxtCntSend_4.AutoSize = False
		Me._TxtCntSend_4.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSend_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSend_4.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntSend_4.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSend_4.Location = New System.Drawing.Point(520, 288)
		Me._TxtCntSend_4.TabIndex = 167
		Me._TxtCntSend_4.Text = "0"
		Me._TxtCntSend_4.AcceptsReturn = True
		Me._TxtCntSend_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSend_4.CausesValidation = True
		Me._TxtCntSend_4.Enabled = True
		Me._TxtCntSend_4.HideSelection = True
		Me._TxtCntSend_4.ReadOnly = False
		Me._TxtCntSend_4.Maxlength = 0
		Me._TxtCntSend_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSend_4.MultiLine = False
		Me._TxtCntSend_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSend_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSend_4.TabStop = True
		Me._TxtCntSend_4.Visible = True
		Me._TxtCntSend_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSend_4.Name = "_TxtCntSend_4"
		Me._TxtCntRcv_4.AutoSize = False
		Me._TxtCntRcv_4.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntRcv_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntRcv_4.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntRcv_4.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntRcv_4.Location = New System.Drawing.Point(520, 320)
		Me._TxtCntRcv_4.TabIndex = 166
		Me._TxtCntRcv_4.Text = "0"
		Me._TxtCntRcv_4.AcceptsReturn = True
		Me._TxtCntRcv_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntRcv_4.CausesValidation = True
		Me._TxtCntRcv_4.Enabled = True
		Me._TxtCntRcv_4.HideSelection = True
		Me._TxtCntRcv_4.ReadOnly = False
		Me._TxtCntRcv_4.Maxlength = 0
		Me._TxtCntRcv_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntRcv_4.MultiLine = False
		Me._TxtCntRcv_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntRcv_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntRcv_4.TabStop = True
		Me._TxtCntRcv_4.Visible = True
		Me._TxtCntRcv_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntRcv_4.Name = "_TxtCntRcv_4"
		Me._TxtCntLoss_4.AutoSize = False
		Me._TxtCntLoss_4.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntLoss_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntLoss_4.ForeColor = System.Drawing.Color.Red
		Me._TxtCntLoss_4.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntLoss_4.Location = New System.Drawing.Point(520, 352)
		Me._TxtCntLoss_4.TabIndex = 165
		Me._TxtCntLoss_4.Text = "0"
		Me._TxtCntLoss_4.AcceptsReturn = True
		Me._TxtCntLoss_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntLoss_4.CausesValidation = True
		Me._TxtCntLoss_4.Enabled = True
		Me._TxtCntLoss_4.HideSelection = True
		Me._TxtCntLoss_4.ReadOnly = False
		Me._TxtCntLoss_4.Maxlength = 0
		Me._TxtCntLoss_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntLoss_4.MultiLine = False
		Me._TxtCntLoss_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntLoss_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntLoss_4.TabStop = True
		Me._TxtCntLoss_4.Visible = True
		Me._TxtCntLoss_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntLoss_4.Name = "_TxtCntLoss_4"
		Me._CmdSendBeg_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdSendBeg_4.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._CmdSendBeg_4.Text = "Start COM5"
		Me._CmdSendBeg_4.Enabled = False
		Me._CmdSendBeg_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdSendBeg_4.Size = New System.Drawing.Size(81, 25)
		Me._CmdSendBeg_4.Location = New System.Drawing.Point(520, 224)
		Me._CmdSendBeg_4.TabIndex = 164
		Me._CmdSendBeg_4.CausesValidation = True
		Me._CmdSendBeg_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdSendBeg_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdSendBeg_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdSendBeg_4.TabStop = True
		Me._CmdSendBeg_4.Name = "_CmdSendBeg_4"
		Me._TxtSendDataLen_4.AutoSize = False
		Me._TxtSendDataLen_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendDataLen_4.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendDataLen_4.Location = New System.Drawing.Point(600, 200)
		Me._TxtSendDataLen_4.TabIndex = 163
		Me._TxtSendDataLen_4.Text = "10"
		Me._TxtSendDataLen_4.AcceptsReturn = True
		Me._TxtSendDataLen_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendDataLen_4.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendDataLen_4.CausesValidation = True
		Me._TxtSendDataLen_4.Enabled = True
		Me._TxtSendDataLen_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendDataLen_4.HideSelection = True
		Me._TxtSendDataLen_4.ReadOnly = False
		Me._TxtSendDataLen_4.Maxlength = 0
		Me._TxtSendDataLen_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendDataLen_4.MultiLine = False
		Me._TxtSendDataLen_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendDataLen_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendDataLen_4.TabStop = True
		Me._TxtSendDataLen_4.Visible = True
		Me._TxtSendDataLen_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendDataLen_4.Name = "_TxtSendDataLen_4"
		Me._TxtSendIntval_4.AutoSize = False
		Me._TxtSendIntval_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendIntval_4.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendIntval_4.Location = New System.Drawing.Point(600, 176)
		Me._TxtSendIntval_4.TabIndex = 162
		Me._TxtSendIntval_4.Text = "1000"
		Me.ToolTip1.SetToolTip(Me._TxtSendIntval_4, "=0: waiting response; >0: period sending")
		Me._TxtSendIntval_4.AcceptsReturn = True
		Me._TxtSendIntval_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendIntval_4.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendIntval_4.CausesValidation = True
		Me._TxtSendIntval_4.Enabled = True
		Me._TxtSendIntval_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendIntval_4.HideSelection = True
		Me._TxtSendIntval_4.ReadOnly = False
		Me._TxtSendIntval_4.Maxlength = 0
		Me._TxtSendIntval_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendIntval_4.MultiLine = False
		Me._TxtSendIntval_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendIntval_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendIntval_4.TabStop = True
		Me._TxtSendIntval_4.Visible = True
		Me._TxtSendIntval_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendIntval_4.Name = "_TxtSendIntval_4"
		Me._TxtSendData_4.AutoSize = False
		Me._TxtSendData_4.Size = New System.Drawing.Size(193, 25)
		Me._TxtSendData_4.Location = New System.Drawing.Point(520, 376)
		Me._TxtSendData_4.TabIndex = 161
		Me._TxtSendData_4.Visible = False
		Me._TxtSendData_4.AcceptsReturn = True
		Me._TxtSendData_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendData_4.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendData_4.CausesValidation = True
		Me._TxtSendData_4.Enabled = True
		Me._TxtSendData_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendData_4.HideSelection = True
		Me._TxtSendData_4.ReadOnly = False
		Me._TxtSendData_4.Maxlength = 0
		Me._TxtSendData_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendData_4.MultiLine = False
		Me._TxtSendData_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendData_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendData_4.TabStop = True
		Me._TxtSendData_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendData_4.Name = "_TxtSendData_4"
		Me._TxtRcvPket_3.AutoSize = False
		Me._TxtRcvPket_3.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtRcvPket_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtRcvPket_3.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtRcvPket_3.Size = New System.Drawing.Size(57, 25)
		Me._TxtRcvPket_3.Location = New System.Drawing.Point(448, 556)
		Me._TxtRcvPket_3.TabIndex = 155
		Me._TxtRcvPket_3.Text = "0"
		Me._TxtRcvPket_3.AcceptsReturn = True
		Me._TxtRcvPket_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtRcvPket_3.CausesValidation = True
		Me._TxtRcvPket_3.Enabled = True
		Me._TxtRcvPket_3.HideSelection = True
		Me._TxtRcvPket_3.ReadOnly = False
		Me._TxtRcvPket_3.Maxlength = 0
		Me._TxtRcvPket_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtRcvPket_3.MultiLine = False
		Me._TxtRcvPket_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtRcvPket_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtRcvPket_3.TabStop = True
		Me._TxtRcvPket_3.Visible = True
		Me._TxtRcvPket_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtRcvPket_3.Name = "_TxtRcvPket_3"
		Me._TxtSendPket_3.AutoSize = False
		Me._TxtSendPket_3.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPket_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPket_3.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPket_3.Location = New System.Drawing.Point(448, 524)
		Me._TxtSendPket_3.TabIndex = 154
		Me._TxtSendPket_3.Text = "0"
		Me._TxtSendPket_3.Visible = False
		Me._TxtSendPket_3.AcceptsReturn = True
		Me._TxtSendPket_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPket_3.CausesValidation = True
		Me._TxtSendPket_3.Enabled = True
		Me._TxtSendPket_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendPket_3.HideSelection = True
		Me._TxtSendPket_3.ReadOnly = False
		Me._TxtSendPket_3.Maxlength = 0
		Me._TxtSendPket_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPket_3.MultiLine = False
		Me._TxtSendPket_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPket_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPket_3.TabStop = True
		Me._TxtSendPket_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPket_3.Name = "_TxtSendPket_3"
		Me._TxtSendPketTal_3.AutoSize = False
		Me._TxtSendPketTal_3.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPketTal_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPketTal_3.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtSendPketTal_3.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPketTal_3.Location = New System.Drawing.Point(448, 492)
		Me._TxtSendPketTal_3.TabIndex = 153
		Me._TxtSendPketTal_3.Text = "0"
		Me._TxtSendPketTal_3.AcceptsReturn = True
		Me._TxtSendPketTal_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPketTal_3.CausesValidation = True
		Me._TxtSendPketTal_3.Enabled = True
		Me._TxtSendPketTal_3.HideSelection = True
		Me._TxtSendPketTal_3.ReadOnly = False
		Me._TxtSendPketTal_3.Maxlength = 0
		Me._TxtSendPketTal_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPketTal_3.MultiLine = False
		Me._TxtSendPketTal_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPketTal_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPketTal_3.TabStop = True
		Me._TxtSendPketTal_3.Visible = True
		Me._TxtSendPketTal_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPketTal_3.Name = "_TxtSendPketTal_3"
		Me._TxtCntSendTal_3.AutoSize = False
		Me._TxtCntSendTal_3.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSendTal_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSendTal_3.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._TxtCntSendTal_3.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSendTal_3.Location = New System.Drawing.Point(312, 492)
		Me._TxtCntSendTal_3.TabIndex = 152
		Me._TxtCntSendTal_3.Text = "0"
		Me._TxtCntSendTal_3.AcceptsReturn = True
		Me._TxtCntSendTal_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSendTal_3.CausesValidation = True
		Me._TxtCntSendTal_3.Enabled = True
		Me._TxtCntSendTal_3.HideSelection = True
		Me._TxtCntSendTal_3.ReadOnly = False
		Me._TxtCntSendTal_3.Maxlength = 0
		Me._TxtCntSendTal_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSendTal_3.MultiLine = False
		Me._TxtCntSendTal_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSendTal_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSendTal_3.TabStop = True
		Me._TxtCntSendTal_3.Visible = True
		Me._TxtCntSendTal_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSendTal_3.Name = "_TxtCntSendTal_3"
		Me._TxtCntSend_3.AutoSize = False
		Me._TxtCntSend_3.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSend_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSend_3.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntSend_3.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSend_3.Location = New System.Drawing.Point(312, 524)
		Me._TxtCntSend_3.TabIndex = 151
		Me._TxtCntSend_3.Text = "0"
		Me._TxtCntSend_3.AcceptsReturn = True
		Me._TxtCntSend_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSend_3.CausesValidation = True
		Me._TxtCntSend_3.Enabled = True
		Me._TxtCntSend_3.HideSelection = True
		Me._TxtCntSend_3.ReadOnly = False
		Me._TxtCntSend_3.Maxlength = 0
		Me._TxtCntSend_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSend_3.MultiLine = False
		Me._TxtCntSend_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSend_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSend_3.TabStop = True
		Me._TxtCntSend_3.Visible = True
		Me._TxtCntSend_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSend_3.Name = "_TxtCntSend_3"
		Me._TxtCntRcv_3.AutoSize = False
		Me._TxtCntRcv_3.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntRcv_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntRcv_3.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntRcv_3.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntRcv_3.Location = New System.Drawing.Point(312, 556)
		Me._TxtCntRcv_3.TabIndex = 150
		Me._TxtCntRcv_3.Text = "0"
		Me._TxtCntRcv_3.AcceptsReturn = True
		Me._TxtCntRcv_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntRcv_3.CausesValidation = True
		Me._TxtCntRcv_3.Enabled = True
		Me._TxtCntRcv_3.HideSelection = True
		Me._TxtCntRcv_3.ReadOnly = False
		Me._TxtCntRcv_3.Maxlength = 0
		Me._TxtCntRcv_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntRcv_3.MultiLine = False
		Me._TxtCntRcv_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntRcv_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntRcv_3.TabStop = True
		Me._TxtCntRcv_3.Visible = True
		Me._TxtCntRcv_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntRcv_3.Name = "_TxtCntRcv_3"
		Me._TxtCntLoss_3.AutoSize = False
		Me._TxtCntLoss_3.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntLoss_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntLoss_3.ForeColor = System.Drawing.Color.Red
		Me._TxtCntLoss_3.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntLoss_3.Location = New System.Drawing.Point(312, 584)
		Me._TxtCntLoss_3.TabIndex = 149
		Me._TxtCntLoss_3.Text = "0"
		Me._TxtCntLoss_3.AcceptsReturn = True
		Me._TxtCntLoss_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntLoss_3.CausesValidation = True
		Me._TxtCntLoss_3.Enabled = True
		Me._TxtCntLoss_3.HideSelection = True
		Me._TxtCntLoss_3.ReadOnly = False
		Me._TxtCntLoss_3.Maxlength = 0
		Me._TxtCntLoss_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntLoss_3.MultiLine = False
		Me._TxtCntLoss_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntLoss_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntLoss_3.TabStop = True
		Me._TxtCntLoss_3.Visible = True
		Me._TxtCntLoss_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntLoss_3.Name = "_TxtCntLoss_3"
		Me._CmdSendBeg_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdSendBeg_3.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._CmdSendBeg_3.Text = "Start COM4"
		Me._CmdSendBeg_3.Enabled = False
		Me._CmdSendBeg_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdSendBeg_3.Size = New System.Drawing.Size(81, 25)
		Me._CmdSendBeg_3.Location = New System.Drawing.Point(312, 460)
		Me._CmdSendBeg_3.TabIndex = 148
		Me._CmdSendBeg_3.CausesValidation = True
		Me._CmdSendBeg_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdSendBeg_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdSendBeg_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdSendBeg_3.TabStop = True
		Me._CmdSendBeg_3.Name = "_CmdSendBeg_3"
		Me._TxtSendDataLen_3.AutoSize = False
		Me._TxtSendDataLen_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendDataLen_3.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendDataLen_3.Location = New System.Drawing.Point(392, 432)
		Me._TxtSendDataLen_3.TabIndex = 147
		Me._TxtSendDataLen_3.Text = "10"
		Me._TxtSendDataLen_3.AcceptsReturn = True
		Me._TxtSendDataLen_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendDataLen_3.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendDataLen_3.CausesValidation = True
		Me._TxtSendDataLen_3.Enabled = True
		Me._TxtSendDataLen_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendDataLen_3.HideSelection = True
		Me._TxtSendDataLen_3.ReadOnly = False
		Me._TxtSendDataLen_3.Maxlength = 0
		Me._TxtSendDataLen_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendDataLen_3.MultiLine = False
		Me._TxtSendDataLen_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendDataLen_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendDataLen_3.TabStop = True
		Me._TxtSendDataLen_3.Visible = True
		Me._TxtSendDataLen_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendDataLen_3.Name = "_TxtSendDataLen_3"
		Me._TxtSendIntval_3.AutoSize = False
		Me._TxtSendIntval_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendIntval_3.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendIntval_3.Location = New System.Drawing.Point(392, 408)
		Me._TxtSendIntval_3.TabIndex = 146
		Me._TxtSendIntval_3.Text = "1000"
		Me.ToolTip1.SetToolTip(Me._TxtSendIntval_3, "=0: waiting response; >0: period sending")
		Me._TxtSendIntval_3.AcceptsReturn = True
		Me._TxtSendIntval_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendIntval_3.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendIntval_3.CausesValidation = True
		Me._TxtSendIntval_3.Enabled = True
		Me._TxtSendIntval_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendIntval_3.HideSelection = True
		Me._TxtSendIntval_3.ReadOnly = False
		Me._TxtSendIntval_3.Maxlength = 0
		Me._TxtSendIntval_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendIntval_3.MultiLine = False
		Me._TxtSendIntval_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendIntval_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendIntval_3.TabStop = True
		Me._TxtSendIntval_3.Visible = True
		Me._TxtSendIntval_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendIntval_3.Name = "_TxtSendIntval_3"
		Me._TxtSendData_3.AutoSize = False
		Me._TxtSendData_3.Size = New System.Drawing.Size(193, 25)
		Me._TxtSendData_3.Location = New System.Drawing.Point(312, 608)
		Me._TxtSendData_3.TabIndex = 145
		Me._TxtSendData_3.Visible = False
		Me._TxtSendData_3.AcceptsReturn = True
		Me._TxtSendData_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendData_3.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendData_3.CausesValidation = True
		Me._TxtSendData_3.Enabled = True
		Me._TxtSendData_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendData_3.HideSelection = True
		Me._TxtSendData_3.ReadOnly = False
		Me._TxtSendData_3.Maxlength = 0
		Me._TxtSendData_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendData_3.MultiLine = False
		Me._TxtSendData_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendData_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendData_3.TabStop = True
		Me._TxtSendData_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendData_3.Name = "_TxtSendData_3"
		Me._TmrSend_5.Enabled = False
		Me._TmrSend_5.Interval = 1
		Me._TmrSend_4.Enabled = False
		Me._TmrSend_4.Interval = 1
		Me._CmdClrCnt_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdClrCnt_3.Text = "Clear Counter"
		Me._CmdClrCnt_3.Size = New System.Drawing.Size(33, 17)
		Me._CmdClrCnt_3.Location = New System.Drawing.Point(320, 40)
		Me._CmdClrCnt_3.TabIndex = 128
		Me._CmdClrCnt_3.Visible = False
		Me._CmdClrCnt_3.BackColor = System.Drawing.SystemColors.Control
		Me._CmdClrCnt_3.CausesValidation = True
		Me._CmdClrCnt_3.Enabled = True
		Me._CmdClrCnt_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdClrCnt_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdClrCnt_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdClrCnt_3.TabStop = True
		Me._CmdClrCnt_3.Name = "_CmdClrCnt_3"
		Me._TmrSend_3.Enabled = False
		Me._TmrSend_3.Interval = 1
		Me.Timer1.Interval = 1000
		Me.Timer1.Enabled = True
		Me._TxtSendData_2.AutoSize = False
		Me._TxtSendData_2.Size = New System.Drawing.Size(193, 25)
		Me._TxtSendData_2.Location = New System.Drawing.Point(312, 376)
		Me._TxtSendData_2.TabIndex = 115
		Me._TxtSendData_2.Visible = False
		Me._TxtSendData_2.AcceptsReturn = True
		Me._TxtSendData_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendData_2.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendData_2.CausesValidation = True
		Me._TxtSendData_2.Enabled = True
		Me._TxtSendData_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendData_2.HideSelection = True
		Me._TxtSendData_2.ReadOnly = False
		Me._TxtSendData_2.Maxlength = 0
		Me._TxtSendData_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendData_2.MultiLine = False
		Me._TxtSendData_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendData_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendData_2.TabStop = True
		Me._TxtSendData_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendData_2.Name = "_TxtSendData_2"
		Me._TmrSend_2.Enabled = False
		Me._TmrSend_2.Interval = 1
		Me._CmdClrCnt_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdClrCnt_2.Text = "Clear Counter"
		Me._CmdClrCnt_2.Size = New System.Drawing.Size(33, 17)
		Me._CmdClrCnt_2.Location = New System.Drawing.Point(288, 40)
		Me._CmdClrCnt_2.TabIndex = 113
		Me._CmdClrCnt_2.Visible = False
		Me._CmdClrCnt_2.BackColor = System.Drawing.SystemColors.Control
		Me._CmdClrCnt_2.CausesValidation = True
		Me._CmdClrCnt_2.Enabled = True
		Me._CmdClrCnt_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdClrCnt_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdClrCnt_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdClrCnt_2.TabStop = True
		Me._CmdClrCnt_2.Name = "_CmdClrCnt_2"
		Me._TxtSendIntval_2.AutoSize = False
		Me._TxtSendIntval_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendIntval_2.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendIntval_2.Location = New System.Drawing.Point(392, 172)
		Me._TxtSendIntval_2.TabIndex = 106
		Me._TxtSendIntval_2.Text = "1000"
		Me.ToolTip1.SetToolTip(Me._TxtSendIntval_2, "=0: waiting response; >0: period sending")
		Me._TxtSendIntval_2.AcceptsReturn = True
		Me._TxtSendIntval_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendIntval_2.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendIntval_2.CausesValidation = True
		Me._TxtSendIntval_2.Enabled = True
		Me._TxtSendIntval_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendIntval_2.HideSelection = True
		Me._TxtSendIntval_2.ReadOnly = False
		Me._TxtSendIntval_2.Maxlength = 0
		Me._TxtSendIntval_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendIntval_2.MultiLine = False
		Me._TxtSendIntval_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendIntval_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendIntval_2.TabStop = True
		Me._TxtSendIntval_2.Visible = True
		Me._TxtSendIntval_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendIntval_2.Name = "_TxtSendIntval_2"
		Me._TxtSendDataLen_2.AutoSize = False
		Me._TxtSendDataLen_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendDataLen_2.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendDataLen_2.Location = New System.Drawing.Point(392, 200)
		Me._TxtSendDataLen_2.TabIndex = 105
		Me._TxtSendDataLen_2.Text = "10"
		Me._TxtSendDataLen_2.AcceptsReturn = True
		Me._TxtSendDataLen_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendDataLen_2.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendDataLen_2.CausesValidation = True
		Me._TxtSendDataLen_2.Enabled = True
		Me._TxtSendDataLen_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendDataLen_2.HideSelection = True
		Me._TxtSendDataLen_2.ReadOnly = False
		Me._TxtSendDataLen_2.Maxlength = 0
		Me._TxtSendDataLen_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendDataLen_2.MultiLine = False
		Me._TxtSendDataLen_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendDataLen_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendDataLen_2.TabStop = True
		Me._TxtSendDataLen_2.Visible = True
		Me._TxtSendDataLen_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendDataLen_2.Name = "_TxtSendDataLen_2"
		Me._CmdSendBeg_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdSendBeg_2.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._CmdSendBeg_2.Text = "Start COM3"
		Me._CmdSendBeg_2.Enabled = False
		Me._CmdSendBeg_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdSendBeg_2.Size = New System.Drawing.Size(81, 25)
		Me._CmdSendBeg_2.Location = New System.Drawing.Point(312, 224)
		Me._CmdSendBeg_2.TabIndex = 104
		Me._CmdSendBeg_2.CausesValidation = True
		Me._CmdSendBeg_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdSendBeg_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdSendBeg_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdSendBeg_2.TabStop = True
		Me._CmdSendBeg_2.Name = "_CmdSendBeg_2"
		Me._TxtCntLoss_2.AutoSize = False
		Me._TxtCntLoss_2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntLoss_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntLoss_2.ForeColor = System.Drawing.Color.Red
		Me._TxtCntLoss_2.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntLoss_2.Location = New System.Drawing.Point(312, 352)
		Me._TxtCntLoss_2.TabIndex = 103
		Me._TxtCntLoss_2.Text = "0"
		Me._TxtCntLoss_2.AcceptsReturn = True
		Me._TxtCntLoss_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntLoss_2.CausesValidation = True
		Me._TxtCntLoss_2.Enabled = True
		Me._TxtCntLoss_2.HideSelection = True
		Me._TxtCntLoss_2.ReadOnly = False
		Me._TxtCntLoss_2.Maxlength = 0
		Me._TxtCntLoss_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntLoss_2.MultiLine = False
		Me._TxtCntLoss_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntLoss_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntLoss_2.TabStop = True
		Me._TxtCntLoss_2.Visible = True
		Me._TxtCntLoss_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntLoss_2.Name = "_TxtCntLoss_2"
		Me._TxtCntRcv_2.AutoSize = False
		Me._TxtCntRcv_2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntRcv_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntRcv_2.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntRcv_2.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntRcv_2.Location = New System.Drawing.Point(312, 320)
		Me._TxtCntRcv_2.TabIndex = 102
		Me._TxtCntRcv_2.Text = "0"
		Me._TxtCntRcv_2.AcceptsReturn = True
		Me._TxtCntRcv_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntRcv_2.CausesValidation = True
		Me._TxtCntRcv_2.Enabled = True
		Me._TxtCntRcv_2.HideSelection = True
		Me._TxtCntRcv_2.ReadOnly = False
		Me._TxtCntRcv_2.Maxlength = 0
		Me._TxtCntRcv_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntRcv_2.MultiLine = False
		Me._TxtCntRcv_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntRcv_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntRcv_2.TabStop = True
		Me._TxtCntRcv_2.Visible = True
		Me._TxtCntRcv_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntRcv_2.Name = "_TxtCntRcv_2"
		Me._TxtCntSend_2.AutoSize = False
		Me._TxtCntSend_2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSend_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSend_2.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntSend_2.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSend_2.Location = New System.Drawing.Point(312, 288)
		Me._TxtCntSend_2.TabIndex = 101
		Me._TxtCntSend_2.Text = "0"
		Me._TxtCntSend_2.AcceptsReturn = True
		Me._TxtCntSend_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSend_2.CausesValidation = True
		Me._TxtCntSend_2.Enabled = True
		Me._TxtCntSend_2.HideSelection = True
		Me._TxtCntSend_2.ReadOnly = False
		Me._TxtCntSend_2.Maxlength = 0
		Me._TxtCntSend_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSend_2.MultiLine = False
		Me._TxtCntSend_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSend_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSend_2.TabStop = True
		Me._TxtCntSend_2.Visible = True
		Me._TxtCntSend_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSend_2.Name = "_TxtCntSend_2"
		Me._TxtCntSendTal_2.AutoSize = False
		Me._TxtCntSendTal_2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSendTal_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSendTal_2.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._TxtCntSendTal_2.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSendTal_2.Location = New System.Drawing.Point(312, 256)
		Me._TxtCntSendTal_2.TabIndex = 100
		Me._TxtCntSendTal_2.Text = "0"
		Me._TxtCntSendTal_2.AcceptsReturn = True
		Me._TxtCntSendTal_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSendTal_2.CausesValidation = True
		Me._TxtCntSendTal_2.Enabled = True
		Me._TxtCntSendTal_2.HideSelection = True
		Me._TxtCntSendTal_2.ReadOnly = False
		Me._TxtCntSendTal_2.Maxlength = 0
		Me._TxtCntSendTal_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSendTal_2.MultiLine = False
		Me._TxtCntSendTal_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSendTal_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSendTal_2.TabStop = True
		Me._TxtCntSendTal_2.Visible = True
		Me._TxtCntSendTal_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSendTal_2.Name = "_TxtCntSendTal_2"
		Me._TxtSendPketTal_2.AutoSize = False
		Me._TxtSendPketTal_2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPketTal_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPketTal_2.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtSendPketTal_2.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPketTal_2.Location = New System.Drawing.Point(448, 256)
		Me._TxtSendPketTal_2.TabIndex = 99
		Me._TxtSendPketTal_2.Text = "0"
		Me._TxtSendPketTal_2.AcceptsReturn = True
		Me._TxtSendPketTal_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPketTal_2.CausesValidation = True
		Me._TxtSendPketTal_2.Enabled = True
		Me._TxtSendPketTal_2.HideSelection = True
		Me._TxtSendPketTal_2.ReadOnly = False
		Me._TxtSendPketTal_2.Maxlength = 0
		Me._TxtSendPketTal_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPketTal_2.MultiLine = False
		Me._TxtSendPketTal_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPketTal_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPketTal_2.TabStop = True
		Me._TxtSendPketTal_2.Visible = True
		Me._TxtSendPketTal_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPketTal_2.Name = "_TxtSendPketTal_2"
		Me._TxtSendPket_2.AutoSize = False
		Me._TxtSendPket_2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPket_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPket_2.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPket_2.Location = New System.Drawing.Point(448, 288)
		Me._TxtSendPket_2.TabIndex = 98
		Me._TxtSendPket_2.Text = "0"
		Me._TxtSendPket_2.Visible = False
		Me._TxtSendPket_2.AcceptsReturn = True
		Me._TxtSendPket_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPket_2.CausesValidation = True
		Me._TxtSendPket_2.Enabled = True
		Me._TxtSendPket_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendPket_2.HideSelection = True
		Me._TxtSendPket_2.ReadOnly = False
		Me._TxtSendPket_2.Maxlength = 0
		Me._TxtSendPket_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPket_2.MultiLine = False
		Me._TxtSendPket_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPket_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPket_2.TabStop = True
		Me._TxtSendPket_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPket_2.Name = "_TxtSendPket_2"
		Me._TxtRcvPket_2.AutoSize = False
		Me._TxtRcvPket_2.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtRcvPket_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtRcvPket_2.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtRcvPket_2.Size = New System.Drawing.Size(57, 25)
		Me._TxtRcvPket_2.Location = New System.Drawing.Point(448, 320)
		Me._TxtRcvPket_2.TabIndex = 97
		Me._TxtRcvPket_2.Text = "0"
		Me._TxtRcvPket_2.AcceptsReturn = True
		Me._TxtRcvPket_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtRcvPket_2.CausesValidation = True
		Me._TxtRcvPket_2.Enabled = True
		Me._TxtRcvPket_2.HideSelection = True
		Me._TxtRcvPket_2.ReadOnly = False
		Me._TxtRcvPket_2.Maxlength = 0
		Me._TxtRcvPket_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtRcvPket_2.MultiLine = False
		Me._TxtRcvPket_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtRcvPket_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtRcvPket_2.TabStop = True
		Me._TxtRcvPket_2.Visible = True
		Me._TxtRcvPket_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtRcvPket_2.Name = "_TxtRcvPket_2"
		Me._TxtRcvPket_1.AutoSize = False
		Me._TxtRcvPket_1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtRcvPket_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtRcvPket_1.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtRcvPket_1.Size = New System.Drawing.Size(57, 25)
		Me._TxtRcvPket_1.Location = New System.Drawing.Point(240, 552)
		Me._TxtRcvPket_1.TabIndex = 91
		Me._TxtRcvPket_1.Text = "0"
		Me._TxtRcvPket_1.AcceptsReturn = True
		Me._TxtRcvPket_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtRcvPket_1.CausesValidation = True
		Me._TxtRcvPket_1.Enabled = True
		Me._TxtRcvPket_1.HideSelection = True
		Me._TxtRcvPket_1.ReadOnly = False
		Me._TxtRcvPket_1.Maxlength = 0
		Me._TxtRcvPket_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtRcvPket_1.MultiLine = False
		Me._TxtRcvPket_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtRcvPket_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtRcvPket_1.TabStop = True
		Me._TxtRcvPket_1.Visible = True
		Me._TxtRcvPket_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtRcvPket_1.Name = "_TxtRcvPket_1"
		Me._TxtSendPket_1.AutoSize = False
		Me._TxtSendPket_1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPket_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPket_1.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPket_1.Location = New System.Drawing.Point(240, 520)
		Me._TxtSendPket_1.TabIndex = 90
		Me._TxtSendPket_1.Text = "0"
		Me._TxtSendPket_1.Visible = False
		Me._TxtSendPket_1.AcceptsReturn = True
		Me._TxtSendPket_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPket_1.CausesValidation = True
		Me._TxtSendPket_1.Enabled = True
		Me._TxtSendPket_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendPket_1.HideSelection = True
		Me._TxtSendPket_1.ReadOnly = False
		Me._TxtSendPket_1.Maxlength = 0
		Me._TxtSendPket_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPket_1.MultiLine = False
		Me._TxtSendPket_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPket_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPket_1.TabStop = True
		Me._TxtSendPket_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPket_1.Name = "_TxtSendPket_1"
		Me._TxtSendPketTal_1.AutoSize = False
		Me._TxtSendPketTal_1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPketTal_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPketTal_1.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtSendPketTal_1.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPketTal_1.Location = New System.Drawing.Point(240, 488)
		Me._TxtSendPketTal_1.TabIndex = 89
		Me._TxtSendPketTal_1.Text = "0"
		Me._TxtSendPketTal_1.AcceptsReturn = True
		Me._TxtSendPketTal_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPketTal_1.CausesValidation = True
		Me._TxtSendPketTal_1.Enabled = True
		Me._TxtSendPketTal_1.HideSelection = True
		Me._TxtSendPketTal_1.ReadOnly = False
		Me._TxtSendPketTal_1.Maxlength = 0
		Me._TxtSendPketTal_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPketTal_1.MultiLine = False
		Me._TxtSendPketTal_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPketTal_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPketTal_1.TabStop = True
		Me._TxtSendPketTal_1.Visible = True
		Me._TxtSendPketTal_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPketTal_1.Name = "_TxtSendPketTal_1"
		Me._TxtRcvPket_0.AutoSize = False
		Me._TxtRcvPket_0.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtRcvPket_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtRcvPket_0.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtRcvPket_0.Size = New System.Drawing.Size(57, 25)
		Me._TxtRcvPket_0.Location = New System.Drawing.Point(240, 320)
		Me._TxtRcvPket_0.TabIndex = 88
		Me._TxtRcvPket_0.Text = "0"
		Me._TxtRcvPket_0.AcceptsReturn = True
		Me._TxtRcvPket_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtRcvPket_0.CausesValidation = True
		Me._TxtRcvPket_0.Enabled = True
		Me._TxtRcvPket_0.HideSelection = True
		Me._TxtRcvPket_0.ReadOnly = False
		Me._TxtRcvPket_0.Maxlength = 0
		Me._TxtRcvPket_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtRcvPket_0.MultiLine = False
		Me._TxtRcvPket_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtRcvPket_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtRcvPket_0.TabStop = True
		Me._TxtRcvPket_0.Visible = True
		Me._TxtRcvPket_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtRcvPket_0.Name = "_TxtRcvPket_0"
		Me._TxtSendPket_0.AutoSize = False
		Me._TxtSendPket_0.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPket_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPket_0.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPket_0.Location = New System.Drawing.Point(240, 288)
		Me._TxtSendPket_0.TabIndex = 87
		Me._TxtSendPket_0.Text = "0"
		Me._TxtSendPket_0.Visible = False
		Me._TxtSendPket_0.AcceptsReturn = True
		Me._TxtSendPket_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPket_0.CausesValidation = True
		Me._TxtSendPket_0.Enabled = True
		Me._TxtSendPket_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendPket_0.HideSelection = True
		Me._TxtSendPket_0.ReadOnly = False
		Me._TxtSendPket_0.Maxlength = 0
		Me._TxtSendPket_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPket_0.MultiLine = False
		Me._TxtSendPket_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPket_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPket_0.TabStop = True
		Me._TxtSendPket_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPket_0.Name = "_TxtSendPket_0"
		Me._TxtSendPketTal_0.AutoSize = False
		Me._TxtSendPketTal_0.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtSendPketTal_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendPketTal_0.ForeColor = System.Drawing.Color.FromARGB(128, 128, 0)
		Me._TxtSendPketTal_0.Size = New System.Drawing.Size(57, 25)
		Me._TxtSendPketTal_0.Location = New System.Drawing.Point(240, 256)
		Me._TxtSendPketTal_0.TabIndex = 86
		Me._TxtSendPketTal_0.Text = "0"
		Me._TxtSendPketTal_0.AcceptsReturn = True
		Me._TxtSendPketTal_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendPketTal_0.CausesValidation = True
		Me._TxtSendPketTal_0.Enabled = True
		Me._TxtSendPketTal_0.HideSelection = True
		Me._TxtSendPketTal_0.ReadOnly = False
		Me._TxtSendPketTal_0.Maxlength = 0
		Me._TxtSendPketTal_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendPketTal_0.MultiLine = False
		Me._TxtSendPketTal_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendPketTal_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendPketTal_0.TabStop = True
		Me._TxtSendPketTal_0.Visible = True
		Me._TxtSendPketTal_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendPketTal_0.Name = "_TxtSendPketTal_0"
		Me._TxtCntSendTal_0.AutoSize = False
		Me._TxtCntSendTal_0.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSendTal_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSendTal_0.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._TxtCntSendTal_0.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSendTal_0.Location = New System.Drawing.Point(104, 256)
		Me._TxtCntSendTal_0.TabIndex = 84
		Me._TxtCntSendTal_0.Text = "0"
		Me._TxtCntSendTal_0.AcceptsReturn = True
		Me._TxtCntSendTal_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSendTal_0.CausesValidation = True
		Me._TxtCntSendTal_0.Enabled = True
		Me._TxtCntSendTal_0.HideSelection = True
		Me._TxtCntSendTal_0.ReadOnly = False
		Me._TxtCntSendTal_0.Maxlength = 0
		Me._TxtCntSendTal_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSendTal_0.MultiLine = False
		Me._TxtCntSendTal_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSendTal_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSendTal_0.TabStop = True
		Me._TxtCntSendTal_0.Visible = True
		Me._TxtCntSendTal_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSendTal_0.Name = "_TxtCntSendTal_0"
		Me._TxtCntSendTal_1.AutoSize = False
		Me._TxtCntSendTal_1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSendTal_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSendTal_1.ForeColor = System.Drawing.Color.FromARGB(0, 0, 128)
		Me._TxtCntSendTal_1.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSendTal_1.Location = New System.Drawing.Point(104, 488)
		Me._TxtCntSendTal_1.TabIndex = 83
		Me._TxtCntSendTal_1.Text = "0"
		Me._TxtCntSendTal_1.AcceptsReturn = True
		Me._TxtCntSendTal_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSendTal_1.CausesValidation = True
		Me._TxtCntSendTal_1.Enabled = True
		Me._TxtCntSendTal_1.HideSelection = True
		Me._TxtCntSendTal_1.ReadOnly = False
		Me._TxtCntSendTal_1.Maxlength = 0
		Me._TxtCntSendTal_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSendTal_1.MultiLine = False
		Me._TxtCntSendTal_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSendTal_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSendTal_1.TabStop = True
		Me._TxtCntSendTal_1.Visible = True
		Me._TxtCntSendTal_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSendTal_1.Name = "_TxtCntSendTal_1"
		Me._CmdClrCnt_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdClrCnt_1.Text = "Clear Counter"
		Me._CmdClrCnt_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdClrCnt_1.Size = New System.Drawing.Size(33, 17)
		Me._CmdClrCnt_1.Location = New System.Drawing.Point(256, 40)
		Me._CmdClrCnt_1.TabIndex = 82
		Me._CmdClrCnt_1.Visible = False
		Me._CmdClrCnt_1.BackColor = System.Drawing.SystemColors.Control
		Me._CmdClrCnt_1.CausesValidation = True
		Me._CmdClrCnt_1.Enabled = True
		Me._CmdClrCnt_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdClrCnt_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdClrCnt_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdClrCnt_1.TabStop = True
		Me._CmdClrCnt_1.Name = "_CmdClrCnt_1"
		Me._TmrSend_1.Enabled = False
		Me._TmrSend_1.Interval = 1
		Me._TxtCntSend_1.AutoSize = False
		Me._TxtCntSend_1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSend_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSend_1.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntSend_1.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSend_1.Location = New System.Drawing.Point(104, 520)
		Me._TxtCntSend_1.TabIndex = 74
		Me._TxtCntSend_1.Text = "0"
		Me._TxtCntSend_1.AcceptsReturn = True
		Me._TxtCntSend_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSend_1.CausesValidation = True
		Me._TxtCntSend_1.Enabled = True
		Me._TxtCntSend_1.HideSelection = True
		Me._TxtCntSend_1.ReadOnly = False
		Me._TxtCntSend_1.Maxlength = 0
		Me._TxtCntSend_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSend_1.MultiLine = False
		Me._TxtCntSend_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSend_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSend_1.TabStop = True
		Me._TxtCntSend_1.Visible = True
		Me._TxtCntSend_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSend_1.Name = "_TxtCntSend_1"
		Me._TxtCntRcv_1.AutoSize = False
		Me._TxtCntRcv_1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntRcv_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntRcv_1.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntRcv_1.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntRcv_1.Location = New System.Drawing.Point(104, 552)
		Me._TxtCntRcv_1.TabIndex = 73
		Me._TxtCntRcv_1.Text = "0"
		Me._TxtCntRcv_1.AcceptsReturn = True
		Me._TxtCntRcv_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntRcv_1.CausesValidation = True
		Me._TxtCntRcv_1.Enabled = True
		Me._TxtCntRcv_1.HideSelection = True
		Me._TxtCntRcv_1.ReadOnly = False
		Me._TxtCntRcv_1.Maxlength = 0
		Me._TxtCntRcv_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntRcv_1.MultiLine = False
		Me._TxtCntRcv_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntRcv_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntRcv_1.TabStop = True
		Me._TxtCntRcv_1.Visible = True
		Me._TxtCntRcv_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntRcv_1.Name = "_TxtCntRcv_1"
		Me._TxtCntLoss_1.AutoSize = False
		Me._TxtCntLoss_1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntLoss_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntLoss_1.ForeColor = System.Drawing.Color.Red
		Me._TxtCntLoss_1.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntLoss_1.Location = New System.Drawing.Point(104, 584)
		Me._TxtCntLoss_1.TabIndex = 72
		Me._TxtCntLoss_1.Text = "0"
		Me._TxtCntLoss_1.AcceptsReturn = True
		Me._TxtCntLoss_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntLoss_1.CausesValidation = True
		Me._TxtCntLoss_1.Enabled = True
		Me._TxtCntLoss_1.HideSelection = True
		Me._TxtCntLoss_1.ReadOnly = False
		Me._TxtCntLoss_1.Maxlength = 0
		Me._TxtCntLoss_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntLoss_1.MultiLine = False
		Me._TxtCntLoss_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntLoss_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntLoss_1.TabStop = True
		Me._TxtCntLoss_1.Visible = True
		Me._TxtCntLoss_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntLoss_1.Name = "_TxtCntLoss_1"
		Me._CmdSendBeg_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdSendBeg_1.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._CmdSendBeg_1.Text = "Start COM2"
		Me._CmdSendBeg_1.Enabled = False
		Me._CmdSendBeg_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdSendBeg_1.Size = New System.Drawing.Size(81, 25)
		Me._CmdSendBeg_1.Location = New System.Drawing.Point(8, 456)
		Me._CmdSendBeg_1.TabIndex = 71
		Me._CmdSendBeg_1.CausesValidation = True
		Me._CmdSendBeg_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdSendBeg_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdSendBeg_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdSendBeg_1.TabStop = True
		Me._CmdSendBeg_1.Name = "_CmdSendBeg_1"
		Me._TxtSendDataLen_1.AutoSize = False
		Me._TxtSendDataLen_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendDataLen_1.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendDataLen_1.Location = New System.Drawing.Point(184, 432)
		Me._TxtSendDataLen_1.TabIndex = 70
		Me._TxtSendDataLen_1.Text = "10"
		Me._TxtSendDataLen_1.AcceptsReturn = True
		Me._TxtSendDataLen_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendDataLen_1.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendDataLen_1.CausesValidation = True
		Me._TxtSendDataLen_1.Enabled = True
		Me._TxtSendDataLen_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendDataLen_1.HideSelection = True
		Me._TxtSendDataLen_1.ReadOnly = False
		Me._TxtSendDataLen_1.Maxlength = 0
		Me._TxtSendDataLen_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendDataLen_1.MultiLine = False
		Me._TxtSendDataLen_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendDataLen_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendDataLen_1.TabStop = True
		Me._TxtSendDataLen_1.Visible = True
		Me._TxtSendDataLen_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendDataLen_1.Name = "_TxtSendDataLen_1"
		Me._TxtSendIntval_1.AutoSize = False
		Me._TxtSendIntval_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendIntval_1.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendIntval_1.Location = New System.Drawing.Point(184, 404)
		Me._TxtSendIntval_1.TabIndex = 69
		Me._TxtSendIntval_1.Text = "1000"
		Me.ToolTip1.SetToolTip(Me._TxtSendIntval_1, "=0: waiting response; >0: period sending")
		Me._TxtSendIntval_1.AcceptsReturn = True
		Me._TxtSendIntval_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendIntval_1.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendIntval_1.CausesValidation = True
		Me._TxtSendIntval_1.Enabled = True
		Me._TxtSendIntval_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendIntval_1.HideSelection = True
		Me._TxtSendIntval_1.ReadOnly = False
		Me._TxtSendIntval_1.Maxlength = 0
		Me._TxtSendIntval_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendIntval_1.MultiLine = False
		Me._TxtSendIntval_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendIntval_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendIntval_1.TabStop = True
		Me._TxtSendIntval_1.Visible = True
		Me._TxtSendIntval_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendIntval_1.Name = "_TxtSendIntval_1"
		Me.TmrRate.Interval = 1000
		Me.TmrRate.Enabled = True
		Me.Timer2.Interval = 500
		Me.Timer2.Enabled = True
		Me._TxtCntLoss_0.AutoSize = False
		Me._TxtCntLoss_0.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntLoss_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntLoss_0.ForeColor = System.Drawing.Color.Red
		Me._TxtCntLoss_0.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntLoss_0.Location = New System.Drawing.Point(104, 352)
		Me._TxtCntLoss_0.TabIndex = 55
		Me._TxtCntLoss_0.Text = "0"
		Me._TxtCntLoss_0.AcceptsReturn = True
		Me._TxtCntLoss_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntLoss_0.CausesValidation = True
		Me._TxtCntLoss_0.Enabled = True
		Me._TxtCntLoss_0.HideSelection = True
		Me._TxtCntLoss_0.ReadOnly = False
		Me._TxtCntLoss_0.Maxlength = 0
		Me._TxtCntLoss_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntLoss_0.MultiLine = False
		Me._TxtCntLoss_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntLoss_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntLoss_0.TabStop = True
		Me._TxtCntLoss_0.Visible = True
		Me._TxtCntLoss_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntLoss_0.Name = "_TxtCntLoss_0"
		Me._TxtCntRcv_0.AutoSize = False
		Me._TxtCntRcv_0.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntRcv_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntRcv_0.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntRcv_0.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntRcv_0.Location = New System.Drawing.Point(104, 320)
		Me._TxtCntRcv_0.TabIndex = 53
		Me._TxtCntRcv_0.Text = "0"
		Me._TxtCntRcv_0.AcceptsReturn = True
		Me._TxtCntRcv_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntRcv_0.CausesValidation = True
		Me._TxtCntRcv_0.Enabled = True
		Me._TxtCntRcv_0.HideSelection = True
		Me._TxtCntRcv_0.ReadOnly = False
		Me._TxtCntRcv_0.Maxlength = 0
		Me._TxtCntRcv_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntRcv_0.MultiLine = False
		Me._TxtCntRcv_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntRcv_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntRcv_0.TabStop = True
		Me._TxtCntRcv_0.Visible = True
		Me._TxtCntRcv_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntRcv_0.Name = "_TxtCntRcv_0"
		Me._TxtCntSend_0.AutoSize = False
		Me._TxtCntSend_0.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me._TxtCntSend_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtCntSend_0.ForeColor = System.Drawing.Color.Blue
		Me._TxtCntSend_0.Size = New System.Drawing.Size(73, 25)
		Me._TxtCntSend_0.Location = New System.Drawing.Point(104, 288)
		Me._TxtCntSend_0.TabIndex = 51
		Me._TxtCntSend_0.Text = "0"
		Me._TxtCntSend_0.AcceptsReturn = True
		Me._TxtCntSend_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtCntSend_0.CausesValidation = True
		Me._TxtCntSend_0.Enabled = True
		Me._TxtCntSend_0.HideSelection = True
		Me._TxtCntSend_0.ReadOnly = False
		Me._TxtCntSend_0.Maxlength = 0
		Me._TxtCntSend_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtCntSend_0.MultiLine = False
		Me._TxtCntSend_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtCntSend_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtCntSend_0.TabStop = True
		Me._TxtCntSend_0.Visible = True
		Me._TxtCntSend_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtCntSend_0.Name = "_TxtCntSend_0"
		Me._CmdSendBeg_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdSendBeg_0.BackColor = System.Drawing.Color.FromARGB(192, 192, 255)
		Me._CmdSendBeg_0.Text = "Start COM1"
		Me._CmdSendBeg_0.Enabled = False
		Me._CmdSendBeg_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdSendBeg_0.Size = New System.Drawing.Size(81, 25)
		Me._CmdSendBeg_0.Location = New System.Drawing.Point(8, 224)
		Me._CmdSendBeg_0.TabIndex = 49
		Me._CmdSendBeg_0.CausesValidation = True
		Me._CmdSendBeg_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdSendBeg_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdSendBeg_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdSendBeg_0.TabStop = True
		Me._CmdSendBeg_0.Name = "_CmdSendBeg_0"
		Me._TmrSend_0.Enabled = False
		Me._TmrSend_0.Interval = 1
		Me._TxtSendData_0.AutoSize = False
		Me._TxtSendData_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendData_0.Size = New System.Drawing.Size(193, 24)
		Me._TxtSendData_0.Location = New System.Drawing.Point(104, 376)
		Me._TxtSendData_0.TabIndex = 47
		Me._TxtSendData_0.Visible = False
		Me._TxtSendData_0.AcceptsReturn = True
		Me._TxtSendData_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendData_0.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendData_0.CausesValidation = True
		Me._TxtSendData_0.Enabled = True
		Me._TxtSendData_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendData_0.HideSelection = True
		Me._TxtSendData_0.ReadOnly = False
		Me._TxtSendData_0.Maxlength = 0
		Me._TxtSendData_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendData_0.MultiLine = False
		Me._TxtSendData_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendData_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendData_0.TabStop = True
		Me._TxtSendData_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendData_0.Name = "_TxtSendData_0"
		Me._TxtSendDataLen_0.AutoSize = False
		Me._TxtSendDataLen_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendDataLen_0.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendDataLen_0.Location = New System.Drawing.Point(184, 200)
		Me._TxtSendDataLen_0.TabIndex = 46
		Me._TxtSendDataLen_0.Text = "10"
		Me._TxtSendDataLen_0.AcceptsReturn = True
		Me._TxtSendDataLen_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendDataLen_0.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendDataLen_0.CausesValidation = True
		Me._TxtSendDataLen_0.Enabled = True
		Me._TxtSendDataLen_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendDataLen_0.HideSelection = True
		Me._TxtSendDataLen_0.ReadOnly = False
		Me._TxtSendDataLen_0.Maxlength = 0
		Me._TxtSendDataLen_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendDataLen_0.MultiLine = False
		Me._TxtSendDataLen_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendDataLen_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendDataLen_0.TabStop = True
		Me._TxtSendDataLen_0.Visible = True
		Me._TxtSendDataLen_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendDataLen_0.Name = "_TxtSendDataLen_0"
		Me._TxtSendIntval_0.AutoSize = False
		Me._TxtSendIntval_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendIntval_0.Size = New System.Drawing.Size(57, 21)
		Me._TxtSendIntval_0.Location = New System.Drawing.Point(184, 176)
		Me._TxtSendIntval_0.TabIndex = 45
		Me._TxtSendIntval_0.Text = "1000"
		Me.ToolTip1.SetToolTip(Me._TxtSendIntval_0, "=0: waiting response; >0: period sending")
		Me._TxtSendIntval_0.AcceptsReturn = True
		Me._TxtSendIntval_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendIntval_0.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendIntval_0.CausesValidation = True
		Me._TxtSendIntval_0.Enabled = True
		Me._TxtSendIntval_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendIntval_0.HideSelection = True
		Me._TxtSendIntval_0.ReadOnly = False
		Me._TxtSendIntval_0.Maxlength = 0
		Me._TxtSendIntval_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendIntval_0.MultiLine = False
		Me._TxtSendIntval_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendIntval_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendIntval_0.TabStop = True
		Me._TxtSendIntval_0.Visible = True
		Me._TxtSendIntval_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendIntval_0.Name = "_TxtSendIntval_0"
		Me.cmdClrList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdClrList.BackColor = System.Drawing.Color.FromARGB(255, 192, 192)
		Me.cmdClrList.Text = "Clear List"
		Me.cmdClrList.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.cmdClrList.Size = New System.Drawing.Size(65, 33)
		Me.cmdClrList.Location = New System.Drawing.Point(872, 664)
		Me.cmdClrList.TabIndex = 29
		Me.cmdClrList.CausesValidation = True
		Me.cmdClrList.Enabled = True
		Me.cmdClrList.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdClrList.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdClrList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdClrList.TabStop = True
		Me.cmdClrList.Name = "cmdClrList"
		Me.Frame1.Size = New System.Drawing.Size(937, 81)
		Me.Frame1.Location = New System.Drawing.Point(8, 88)
		Me.Frame1.TabIndex = 11
		Me.Frame1.BackColor = System.Drawing.SystemColors.Control
		Me.Frame1.Enabled = True
		Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Frame1.Visible = True
		Me.Frame1.Padding = New System.Windows.Forms.Padding(0)
		Me.Frame1.Name = "Frame1"
		Me._txtip_2.AutoSize = False
		Me._txtip_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtip_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtip_2.Size = New System.Drawing.Size(73, 25)
		Me._txtip_2.Location = New System.Drawing.Point(256, 16)
		Me._txtip_2.TabIndex = 94
		Me._txtip_2.Text = "10.0.50.100"
		Me._txtip_2.AcceptsReturn = True
		Me._txtip_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtip_2.CausesValidation = True
		Me._txtip_2.Enabled = True
		Me._txtip_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtip_2.HideSelection = True
		Me._txtip_2.ReadOnly = False
		Me._txtip_2.Maxlength = 0
		Me._txtip_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtip_2.MultiLine = False
		Me._txtip_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtip_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtip_2.TabStop = True
		Me._txtip_2.Visible = True
		Me._txtip_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtip_2.Name = "_txtip_2"
		Me._txtip_3.AutoSize = False
		Me._txtip_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtip_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtip_3.Size = New System.Drawing.Size(73, 25)
		Me._txtip_3.Location = New System.Drawing.Point(256, 48)
		Me._txtip_3.TabIndex = 225
		Me._txtip_3.Text = "10.0.50.100"
		Me._txtip_3.AcceptsReturn = True
		Me._txtip_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtip_3.CausesValidation = True
		Me._txtip_3.Enabled = True
		Me._txtip_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtip_3.HideSelection = True
		Me._txtip_3.ReadOnly = False
		Me._txtip_3.Maxlength = 0
		Me._txtip_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtip_3.MultiLine = False
		Me._txtip_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtip_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtip_3.TabStop = True
		Me._txtip_3.Visible = True
		Me._txtip_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtip_3.Name = "_txtip_3"
		Me._txtip_4.AutoSize = False
		Me._txtip_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtip_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtip_4.Size = New System.Drawing.Size(73, 25)
		Me._txtip_4.Location = New System.Drawing.Point(488, 16)
		Me._txtip_4.TabIndex = 226
		Me._txtip_4.Text = "10.0.50.100"
		Me._txtip_4.AcceptsReturn = True
		Me._txtip_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtip_4.CausesValidation = True
		Me._txtip_4.Enabled = True
		Me._txtip_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtip_4.HideSelection = True
		Me._txtip_4.ReadOnly = False
		Me._txtip_4.Maxlength = 0
		Me._txtip_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtip_4.MultiLine = False
		Me._txtip_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtip_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtip_4.TabStop = True
		Me._txtip_4.Visible = True
		Me._txtip_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtip_4.Name = "_txtip_4"
		Me._txtip_5.AutoSize = False
		Me._txtip_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtip_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtip_5.Size = New System.Drawing.Size(73, 25)
		Me._txtip_5.Location = New System.Drawing.Point(488, 48)
		Me._txtip_5.TabIndex = 227
		Me._txtip_5.Text = "10.0.50.100"
		Me._txtip_5.AcceptsReturn = True
		Me._txtip_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtip_5.CausesValidation = True
		Me._txtip_5.Enabled = True
		Me._txtip_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtip_5.HideSelection = True
		Me._txtip_5.ReadOnly = False
		Me._txtip_5.Maxlength = 0
		Me._txtip_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtip_5.MultiLine = False
		Me._txtip_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtip_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtip_5.TabStop = True
		Me._txtip_5.Visible = True
		Me._txtip_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtip_5.Name = "_txtip_5"
		Me._txtip_6.AutoSize = False
		Me._txtip_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtip_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtip_6.Size = New System.Drawing.Size(73, 25)
		Me._txtip_6.Location = New System.Drawing.Point(712, 16)
		Me._txtip_6.TabIndex = 228
		Me._txtip_6.Text = "10.0.50.100"
		Me._txtip_6.AcceptsReturn = True
		Me._txtip_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtip_6.CausesValidation = True
		Me._txtip_6.Enabled = True
		Me._txtip_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtip_6.HideSelection = True
		Me._txtip_6.ReadOnly = False
		Me._txtip_6.Maxlength = 0
		Me._txtip_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtip_6.MultiLine = False
		Me._txtip_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtip_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtip_6.TabStop = True
		Me._txtip_6.Visible = True
		Me._txtip_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtip_6.Name = "_txtip_6"
		Me._txtip_7.AutoSize = False
		Me._txtip_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtip_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtip_7.Size = New System.Drawing.Size(73, 25)
		Me._txtip_7.Location = New System.Drawing.Point(712, 48)
		Me._txtip_7.TabIndex = 229
		Me._txtip_7.Text = "10.0.50.100"
		Me._txtip_7.AcceptsReturn = True
		Me._txtip_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtip_7.CausesValidation = True
		Me._txtip_7.Enabled = True
		Me._txtip_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtip_7.HideSelection = True
		Me._txtip_7.ReadOnly = False
		Me._txtip_7.Maxlength = 0
		Me._txtip_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtip_7.MultiLine = False
		Me._txtip_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtip_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtip_7.TabStop = True
		Me._txtip_7.Visible = True
		Me._txtip_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtip_7.Name = "_txtip_7"
		Me.txtStatus67.AutoSize = False
		Me.txtStatus67.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtStatus67.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.txtStatus67.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStatus67.ForeColor = System.Drawing.Color.FromARGB(0, 128, 0)
		Me.txtStatus67.Size = New System.Drawing.Size(25, 49)
		Me.txtStatus67.Location = New System.Drawing.Point(904, 24)
		Me.txtStatus67.MultiLine = True
		Me.txtStatus67.TabIndex = 144
		Me.txtStatus67.AcceptsReturn = True
		Me.txtStatus67.CausesValidation = True
		Me.txtStatus67.Enabled = True
		Me.txtStatus67.HideSelection = True
		Me.txtStatus67.ReadOnly = False
		Me.txtStatus67.Maxlength = 0
		Me.txtStatus67.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStatus67.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStatus67.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStatus67.TabStop = True
		Me.txtStatus67.Visible = True
		Me.txtStatus67.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStatus67.Name = "txtStatus67"
		Me._cmdCnect_7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdCnect_7.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me._cmdCnect_7.Text = "Connect"
		Me._cmdCnect_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdCnect_7.Size = New System.Drawing.Size(73, 25)
		Me._cmdCnect_7.Location = New System.Drawing.Point(824, 48)
		Me._cmdCnect_7.TabIndex = 142
		Me._cmdCnect_7.CausesValidation = True
		Me._cmdCnect_7.Enabled = True
		Me._cmdCnect_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCnect_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCnect_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCnect_7.TabStop = True
		Me._cmdCnect_7.Name = "_cmdCnect_7"
		Me._txtLocalPort_7.AutoSize = False
		Me._txtLocalPort_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtLocalPort_7.Size = New System.Drawing.Size(17, 25)
		Me._txtLocalPort_7.Location = New System.Drawing.Point(880, 48)
		Me._txtLocalPort_7.TabIndex = 141
		Me._txtLocalPort_7.Text = "0"
		Me._txtLocalPort_7.Visible = False
		Me._txtLocalPort_7.AcceptsReturn = True
		Me._txtLocalPort_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtLocalPort_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtLocalPort_7.CausesValidation = True
		Me._txtLocalPort_7.Enabled = True
		Me._txtLocalPort_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtLocalPort_7.HideSelection = True
		Me._txtLocalPort_7.ReadOnly = False
		Me._txtLocalPort_7.Maxlength = 0
		Me._txtLocalPort_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtLocalPort_7.MultiLine = False
		Me._txtLocalPort_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtLocalPort_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtLocalPort_7.TabStop = True
		Me._txtLocalPort_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtLocalPort_7.Name = "_txtLocalPort_7"
		Me._txtPort_7.AutoSize = False
		Me._txtPort_7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtPort_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPort_7.Size = New System.Drawing.Size(33, 25)
		Me._txtPort_7.Location = New System.Drawing.Point(784, 48)
		Me._txtPort_7.TabIndex = 140
		Me._txtPort_7.Text = "4667"
		Me._txtPort_7.AcceptsReturn = True
		Me._txtPort_7.BackColor = System.Drawing.SystemColors.Window
		Me._txtPort_7.CausesValidation = True
		Me._txtPort_7.Enabled = True
		Me._txtPort_7.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPort_7.HideSelection = True
		Me._txtPort_7.ReadOnly = False
		Me._txtPort_7.Maxlength = 0
		Me._txtPort_7.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPort_7.MultiLine = False
		Me._txtPort_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPort_7.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPort_7.TabStop = True
		Me._txtPort_7.Visible = True
		Me._txtPort_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPort_7.Name = "_txtPort_7"
		Me._cmdCnect_6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdCnect_6.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me._cmdCnect_6.Text = "Connect"
		Me._cmdCnect_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdCnect_6.Size = New System.Drawing.Size(73, 25)
		Me._cmdCnect_6.Location = New System.Drawing.Point(824, 16)
		Me._cmdCnect_6.TabIndex = 139
		Me._cmdCnect_6.CausesValidation = True
		Me._cmdCnect_6.Enabled = True
		Me._cmdCnect_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCnect_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCnect_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCnect_6.TabStop = True
		Me._cmdCnect_6.Name = "_cmdCnect_6"
		Me._txtLocalPort_6.AutoSize = False
		Me._txtLocalPort_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtLocalPort_6.Size = New System.Drawing.Size(17, 25)
		Me._txtLocalPort_6.Location = New System.Drawing.Point(880, 16)
		Me._txtLocalPort_6.TabIndex = 138
		Me._txtLocalPort_6.Text = "0"
		Me._txtLocalPort_6.Visible = False
		Me._txtLocalPort_6.AcceptsReturn = True
		Me._txtLocalPort_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtLocalPort_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtLocalPort_6.CausesValidation = True
		Me._txtLocalPort_6.Enabled = True
		Me._txtLocalPort_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtLocalPort_6.HideSelection = True
		Me._txtLocalPort_6.ReadOnly = False
		Me._txtLocalPort_6.Maxlength = 0
		Me._txtLocalPort_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtLocalPort_6.MultiLine = False
		Me._txtLocalPort_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtLocalPort_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtLocalPort_6.TabStop = True
		Me._txtLocalPort_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtLocalPort_6.Name = "_txtLocalPort_6"
		Me._txtPort_6.AutoSize = False
		Me._txtPort_6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtPort_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPort_6.Size = New System.Drawing.Size(33, 25)
		Me._txtPort_6.Location = New System.Drawing.Point(784, 16)
		Me._txtPort_6.TabIndex = 137
		Me._txtPort_6.Text = "4666"
		Me._txtPort_6.AcceptsReturn = True
		Me._txtPort_6.BackColor = System.Drawing.SystemColors.Window
		Me._txtPort_6.CausesValidation = True
		Me._txtPort_6.Enabled = True
		Me._txtPort_6.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPort_6.HideSelection = True
		Me._txtPort_6.ReadOnly = False
		Me._txtPort_6.Maxlength = 0
		Me._txtPort_6.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPort_6.MultiLine = False
		Me._txtPort_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPort_6.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPort_6.TabStop = True
		Me._txtPort_6.Visible = True
		Me._txtPort_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPort_6.Name = "_txtPort_6"
		Me._cmdCnect_5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdCnect_5.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me._cmdCnect_5.Text = "Connect"
		Me._cmdCnect_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdCnect_5.Size = New System.Drawing.Size(73, 25)
		Me._cmdCnect_5.Location = New System.Drawing.Point(600, 48)
		Me._cmdCnect_5.TabIndex = 135
		Me._cmdCnect_5.CausesValidation = True
		Me._cmdCnect_5.Enabled = True
		Me._cmdCnect_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCnect_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCnect_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCnect_5.TabStop = True
		Me._cmdCnect_5.Name = "_cmdCnect_5"
		Me._txtPort_5.AutoSize = False
		Me._txtPort_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtPort_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPort_5.Size = New System.Drawing.Size(33, 25)
		Me._txtPort_5.Location = New System.Drawing.Point(560, 48)
		Me._txtPort_5.TabIndex = 133
		Me._txtPort_5.Text = "4665"
		Me._txtPort_5.AcceptsReturn = True
		Me._txtPort_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtPort_5.CausesValidation = True
		Me._txtPort_5.Enabled = True
		Me._txtPort_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPort_5.HideSelection = True
		Me._txtPort_5.ReadOnly = False
		Me._txtPort_5.Maxlength = 0
		Me._txtPort_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPort_5.MultiLine = False
		Me._txtPort_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPort_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPort_5.TabStop = True
		Me._txtPort_5.Visible = True
		Me._txtPort_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPort_5.Name = "_txtPort_5"
		Me.txtStatus45.AutoSize = False
		Me.txtStatus45.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtStatus45.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.txtStatus45.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStatus45.ForeColor = System.Drawing.Color.FromARGB(0, 128, 0)
		Me.txtStatus45.Size = New System.Drawing.Size(25, 49)
		Me.txtStatus45.Location = New System.Drawing.Point(680, 24)
		Me.txtStatus45.MultiLine = True
		Me.txtStatus45.TabIndex = 132
		Me.txtStatus45.AcceptsReturn = True
		Me.txtStatus45.CausesValidation = True
		Me.txtStatus45.Enabled = True
		Me.txtStatus45.HideSelection = True
		Me.txtStatus45.ReadOnly = False
		Me.txtStatus45.Maxlength = 0
		Me.txtStatus45.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStatus45.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStatus45.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStatus45.TabStop = True
		Me.txtStatus45.Visible = True
		Me.txtStatus45.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStatus45.Name = "txtStatus45"
		Me._cmdCnect_4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdCnect_4.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me._cmdCnect_4.Text = "Connect"
		Me._cmdCnect_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdCnect_4.Size = New System.Drawing.Size(73, 25)
		Me._cmdCnect_4.Location = New System.Drawing.Point(600, 16)
		Me._cmdCnect_4.TabIndex = 131
		Me._cmdCnect_4.CausesValidation = True
		Me._cmdCnect_4.Enabled = True
		Me._cmdCnect_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCnect_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCnect_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCnect_4.TabStop = True
		Me._cmdCnect_4.Name = "_cmdCnect_4"
		Me._txtLocalPort_4.AutoSize = False
		Me._txtLocalPort_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtLocalPort_4.Size = New System.Drawing.Size(17, 25)
		Me._txtLocalPort_4.Location = New System.Drawing.Point(672, 16)
		Me._txtLocalPort_4.TabIndex = 130
		Me._txtLocalPort_4.Text = "0"
		Me._txtLocalPort_4.Visible = False
		Me._txtLocalPort_4.AcceptsReturn = True
		Me._txtLocalPort_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtLocalPort_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtLocalPort_4.CausesValidation = True
		Me._txtLocalPort_4.Enabled = True
		Me._txtLocalPort_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtLocalPort_4.HideSelection = True
		Me._txtLocalPort_4.ReadOnly = False
		Me._txtLocalPort_4.Maxlength = 0
		Me._txtLocalPort_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtLocalPort_4.MultiLine = False
		Me._txtLocalPort_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtLocalPort_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtLocalPort_4.TabStop = True
		Me._txtLocalPort_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtLocalPort_4.Name = "_txtLocalPort_4"
		Me._txtPort_4.AutoSize = False
		Me._txtPort_4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtPort_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPort_4.Size = New System.Drawing.Size(33, 25)
		Me._txtPort_4.Location = New System.Drawing.Point(560, 16)
		Me._txtPort_4.TabIndex = 129
		Me._txtPort_4.Text = "4664"
		Me._txtPort_4.AcceptsReturn = True
		Me._txtPort_4.BackColor = System.Drawing.SystemColors.Window
		Me._txtPort_4.CausesValidation = True
		Me._txtPort_4.Enabled = True
		Me._txtPort_4.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPort_4.HideSelection = True
		Me._txtPort_4.ReadOnly = False
		Me._txtPort_4.Maxlength = 0
		Me._txtPort_4.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPort_4.MultiLine = False
		Me._txtPort_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPort_4.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPort_4.TabStop = True
		Me._txtPort_4.Visible = True
		Me._txtPort_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPort_4.Name = "_txtPort_4"
		Me._cmdCnect_3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdCnect_3.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me._cmdCnect_3.Text = "Connect"
		Me._cmdCnect_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdCnect_3.Size = New System.Drawing.Size(73, 25)
		Me._cmdCnect_3.Location = New System.Drawing.Point(376, 48)
		Me._cmdCnect_3.TabIndex = 127
		Me._cmdCnect_3.CausesValidation = True
		Me._cmdCnect_3.Enabled = True
		Me._cmdCnect_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCnect_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCnect_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCnect_3.TabStop = True
		Me._cmdCnect_3.Name = "_cmdCnect_3"
		Me._txtPort_3.AutoSize = False
		Me._txtPort_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtPort_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPort_3.Size = New System.Drawing.Size(41, 25)
		Me._txtPort_3.Location = New System.Drawing.Point(328, 48)
		Me._txtPort_3.TabIndex = 125
		Me._txtPort_3.Text = "4663"
		Me._txtPort_3.AcceptsReturn = True
		Me._txtPort_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtPort_3.CausesValidation = True
		Me._txtPort_3.Enabled = True
		Me._txtPort_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPort_3.HideSelection = True
		Me._txtPort_3.ReadOnly = False
		Me._txtPort_3.Maxlength = 0
		Me._txtPort_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPort_3.MultiLine = False
		Me._txtPort_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPort_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPort_3.TabStop = True
		Me._txtPort_3.Visible = True
		Me._txtPort_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPort_3.Name = "_txtPort_3"
		_Winsock1_3.OcxState = CType(resources.GetObject("_Winsock1_3.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Winsock1_3.Location = New System.Drawing.Point(352, 64)
		Me._Winsock1_3.Name = "_Winsock1_3"
		_Winsock1_2.OcxState = CType(resources.GetObject("_Winsock1_2.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Winsock1_2.Location = New System.Drawing.Point(320, 64)
		Me._Winsock1_2.Name = "_Winsock1_2"
		_Winsock1_0.OcxState = CType(resources.GetObject("_Winsock1_0.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Winsock1_0.Location = New System.Drawing.Point(24, 64)
		Me._Winsock1_0.Name = "_Winsock1_0"
		_Winsock1_1.OcxState = CType(resources.GetObject("_Winsock1_1.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Winsock1_1.Location = New System.Drawing.Point(56, 64)
		Me._Winsock1_1.Name = "_Winsock1_1"
		Me.txtStatus23.AutoSize = False
		Me.txtStatus23.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtStatus23.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.txtStatus23.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStatus23.ForeColor = System.Drawing.Color.FromARGB(0, 128, 0)
		Me.txtStatus23.Size = New System.Drawing.Size(25, 49)
		Me.txtStatus23.Location = New System.Drawing.Point(456, 24)
		Me.txtStatus23.MultiLine = True
		Me.txtStatus23.TabIndex = 114
		Me.txtStatus23.AcceptsReturn = True
		Me.txtStatus23.CausesValidation = True
		Me.txtStatus23.Enabled = True
		Me.txtStatus23.HideSelection = True
		Me.txtStatus23.ReadOnly = False
		Me.txtStatus23.Maxlength = 0
		Me.txtStatus23.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStatus23.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStatus23.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStatus23.TabStop = True
		Me.txtStatus23.Visible = True
		Me.txtStatus23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStatus23.Name = "txtStatus23"
		Me._txtPort_2.AutoSize = False
		Me._txtPort_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtPort_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPort_2.Size = New System.Drawing.Size(41, 25)
		Me._txtPort_2.Location = New System.Drawing.Point(328, 16)
		Me._txtPort_2.TabIndex = 96
		Me._txtPort_2.Text = "4662"
		Me._txtPort_2.AcceptsReturn = True
		Me._txtPort_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtPort_2.CausesValidation = True
		Me._txtPort_2.Enabled = True
		Me._txtPort_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPort_2.HideSelection = True
		Me._txtPort_2.ReadOnly = False
		Me._txtPort_2.Maxlength = 0
		Me._txtPort_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPort_2.MultiLine = False
		Me._txtPort_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPort_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPort_2.TabStop = True
		Me._txtPort_2.Visible = True
		Me._txtPort_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPort_2.Name = "_txtPort_2"
		Me._txtLocalPort_2.AutoSize = False
		Me._txtLocalPort_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtLocalPort_2.Size = New System.Drawing.Size(17, 25)
		Me._txtLocalPort_2.Location = New System.Drawing.Point(464, 16)
		Me._txtLocalPort_2.TabIndex = 95
		Me._txtLocalPort_2.Text = "0"
		Me._txtLocalPort_2.Visible = False
		Me._txtLocalPort_2.AcceptsReturn = True
		Me._txtLocalPort_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtLocalPort_2.BackColor = System.Drawing.SystemColors.Window
		Me._txtLocalPort_2.CausesValidation = True
		Me._txtLocalPort_2.Enabled = True
		Me._txtLocalPort_2.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtLocalPort_2.HideSelection = True
		Me._txtLocalPort_2.ReadOnly = False
		Me._txtLocalPort_2.Maxlength = 0
		Me._txtLocalPort_2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtLocalPort_2.MultiLine = False
		Me._txtLocalPort_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtLocalPort_2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtLocalPort_2.TabStop = True
		Me._txtLocalPort_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtLocalPort_2.Name = "_txtLocalPort_2"
		Me._cmdCnect_2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdCnect_2.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me._cmdCnect_2.Text = "Connect"
		Me._cmdCnect_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdCnect_2.Size = New System.Drawing.Size(73, 25)
		Me._cmdCnect_2.Location = New System.Drawing.Point(376, 16)
		Me._cmdCnect_2.TabIndex = 93
		Me._cmdCnect_2.CausesValidation = True
		Me._cmdCnect_2.Enabled = True
		Me._cmdCnect_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCnect_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCnect_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCnect_2.TabStop = True
		Me._cmdCnect_2.Name = "_cmdCnect_2"
		Me.txtStatus.AutoSize = False
		Me.txtStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me.txtStatus.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.txtStatus.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.txtStatus.ForeColor = System.Drawing.Color.FromARGB(0, 128, 0)
		Me.txtStatus.Size = New System.Drawing.Size(25, 49)
		Me.txtStatus.Location = New System.Drawing.Point(224, 24)
		Me.txtStatus.MultiLine = True
		Me.txtStatus.TabIndex = 40
		Me.txtStatus.AcceptsReturn = True
		Me.txtStatus.CausesValidation = True
		Me.txtStatus.Enabled = True
		Me.txtStatus.HideSelection = True
		Me.txtStatus.ReadOnly = False
		Me.txtStatus.Maxlength = 0
		Me.txtStatus.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtStatus.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtStatus.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtStatus.TabStop = True
		Me.txtStatus.Visible = True
		Me.txtStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtStatus.Name = "txtStatus"
		Me._cmdCnect_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdCnect_0.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me._cmdCnect_0.Text = "Connect"
		Me._cmdCnect_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdCnect_0.Size = New System.Drawing.Size(73, 25)
		Me._cmdCnect_0.Location = New System.Drawing.Point(144, 16)
		Me._cmdCnect_0.TabIndex = 20
		Me._cmdCnect_0.CausesValidation = True
		Me._cmdCnect_0.Enabled = True
		Me._cmdCnect_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCnect_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCnect_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCnect_0.TabStop = True
		Me._cmdCnect_0.Name = "_cmdCnect_0"
		Me._cmdCnect_1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._cmdCnect_1.BackColor = System.Drawing.Color.FromARGB(192, 255, 192)
		Me._cmdCnect_1.Text = "Connect"
		Me._cmdCnect_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._cmdCnect_1.Size = New System.Drawing.Size(73, 25)
		Me._cmdCnect_1.Location = New System.Drawing.Point(144, 48)
		Me._cmdCnect_1.TabIndex = 14
		Me._cmdCnect_1.CausesValidation = True
		Me._cmdCnect_1.Enabled = True
		Me._cmdCnect_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._cmdCnect_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._cmdCnect_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._cmdCnect_1.TabStop = True
		Me._cmdCnect_1.Name = "_cmdCnect_1"
		Me._txtip_0.AutoSize = False
		Me._txtip_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtip_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtip_0.Size = New System.Drawing.Size(73, 25)
		Me._txtip_0.Location = New System.Drawing.Point(24, 16)
		Me._txtip_0.TabIndex = 18
		Me._txtip_0.Text = "10.0.50.100"
		Me._txtip_0.AcceptsReturn = True
		Me._txtip_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtip_0.CausesValidation = True
		Me._txtip_0.Enabled = True
		Me._txtip_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtip_0.HideSelection = True
		Me._txtip_0.ReadOnly = False
		Me._txtip_0.Maxlength = 0
		Me._txtip_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtip_0.MultiLine = False
		Me._txtip_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtip_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtip_0.TabStop = True
		Me._txtip_0.Visible = True
		Me._txtip_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtip_0.Name = "_txtip_0"
		Me._txtip_1.AutoSize = False
		Me._txtip_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtip_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtip_1.Size = New System.Drawing.Size(73, 25)
		Me._txtip_1.Location = New System.Drawing.Point(24, 48)
		Me._txtip_1.TabIndex = 12
		Me._txtip_1.Text = "10.0.50.100"
		Me._txtip_1.AcceptsReturn = True
		Me._txtip_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtip_1.CausesValidation = True
		Me._txtip_1.Enabled = True
		Me._txtip_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtip_1.HideSelection = True
		Me._txtip_1.ReadOnly = False
		Me._txtip_1.Maxlength = 0
		Me._txtip_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtip_1.MultiLine = False
		Me._txtip_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtip_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtip_1.TabStop = True
		Me._txtip_1.Visible = True
		Me._txtip_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtip_1.Name = "_txtip_1"
		Me._txtLocalPort_0.AutoSize = False
		Me._txtLocalPort_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtLocalPort_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtLocalPort_0.Size = New System.Drawing.Size(17, 25)
		Me._txtLocalPort_0.Location = New System.Drawing.Point(264, 16)
		Me._txtLocalPort_0.TabIndex = 17
		Me._txtLocalPort_0.Text = "0"
		Me._txtLocalPort_0.Visible = False
		Me._txtLocalPort_0.AcceptsReturn = True
		Me._txtLocalPort_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtLocalPort_0.CausesValidation = True
		Me._txtLocalPort_0.Enabled = True
		Me._txtLocalPort_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtLocalPort_0.HideSelection = True
		Me._txtLocalPort_0.ReadOnly = False
		Me._txtLocalPort_0.Maxlength = 0
		Me._txtLocalPort_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtLocalPort_0.MultiLine = False
		Me._txtLocalPort_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtLocalPort_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtLocalPort_0.TabStop = True
		Me._txtLocalPort_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtLocalPort_0.Name = "_txtLocalPort_0"
		Me._txtLocalPort_1.AutoSize = False
		Me._txtLocalPort_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtLocalPort_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtLocalPort_1.Size = New System.Drawing.Size(25, 25)
		Me._txtLocalPort_1.Location = New System.Drawing.Point(264, 48)
		Me._txtLocalPort_1.TabIndex = 16
		Me._txtLocalPort_1.Text = "0"
		Me._txtLocalPort_1.Visible = False
		Me._txtLocalPort_1.AcceptsReturn = True
		Me._txtLocalPort_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtLocalPort_1.CausesValidation = True
		Me._txtLocalPort_1.Enabled = True
		Me._txtLocalPort_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtLocalPort_1.HideSelection = True
		Me._txtLocalPort_1.ReadOnly = False
		Me._txtLocalPort_1.Maxlength = 0
		Me._txtLocalPort_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtLocalPort_1.MultiLine = False
		Me._txtLocalPort_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtLocalPort_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtLocalPort_1.TabStop = True
		Me._txtLocalPort_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtLocalPort_1.Name = "_txtLocalPort_1"
		Me._txtPort_0.AutoSize = False
		Me._txtPort_0.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtPort_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPort_0.Size = New System.Drawing.Size(41, 25)
		Me._txtPort_0.Location = New System.Drawing.Point(96, 16)
		Me._txtPort_0.TabIndex = 19
		Me._txtPort_0.Text = "4660"
		Me._txtPort_0.AcceptsReturn = True
		Me._txtPort_0.BackColor = System.Drawing.SystemColors.Window
		Me._txtPort_0.CausesValidation = True
		Me._txtPort_0.Enabled = True
		Me._txtPort_0.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPort_0.HideSelection = True
		Me._txtPort_0.ReadOnly = False
		Me._txtPort_0.Maxlength = 0
		Me._txtPort_0.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPort_0.MultiLine = False
		Me._txtPort_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPort_0.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPort_0.TabStop = True
		Me._txtPort_0.Visible = True
		Me._txtPort_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPort_0.Name = "_txtPort_0"
		Me._txtPort_1.AutoSize = False
		Me._txtPort_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
		Me._txtPort_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtPort_1.Size = New System.Drawing.Size(41, 25)
		Me._txtPort_1.Location = New System.Drawing.Point(96, 48)
		Me._txtPort_1.TabIndex = 13
		Me._txtPort_1.Text = "4661"
		Me._txtPort_1.AcceptsReturn = True
		Me._txtPort_1.BackColor = System.Drawing.SystemColors.Window
		Me._txtPort_1.CausesValidation = True
		Me._txtPort_1.Enabled = True
		Me._txtPort_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtPort_1.HideSelection = True
		Me._txtPort_1.ReadOnly = False
		Me._txtPort_1.Maxlength = 0
		Me._txtPort_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtPort_1.MultiLine = False
		Me._txtPort_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtPort_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtPort_1.TabStop = True
		Me._txtPort_1.Visible = True
		Me._txtPort_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtPort_1.Name = "_txtPort_1"
		Me.cmdListen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdListen.Text = "Listen"
		Me.cmdListen.Size = New System.Drawing.Size(49, 25)
		Me.cmdListen.Location = New System.Drawing.Point(264, 56)
		Me.cmdListen.TabIndex = 15
		Me.cmdListen.Visible = False
		Me.cmdListen.BackColor = System.Drawing.SystemColors.Control
		Me.cmdListen.CausesValidation = True
		Me.cmdListen.Enabled = True
		Me.cmdListen.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdListen.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdListen.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdListen.TabStop = True
		Me.cmdListen.Name = "cmdListen"
		Me._txtLocalPort_3.AutoSize = False
		Me._txtLocalPort_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtLocalPort_3.Size = New System.Drawing.Size(17, 25)
		Me._txtLocalPort_3.Location = New System.Drawing.Point(480, 48)
		Me._txtLocalPort_3.TabIndex = 126
		Me._txtLocalPort_3.Text = "0"
		Me._txtLocalPort_3.Visible = False
		Me._txtLocalPort_3.AcceptsReturn = True
		Me._txtLocalPort_3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtLocalPort_3.BackColor = System.Drawing.SystemColors.Window
		Me._txtLocalPort_3.CausesValidation = True
		Me._txtLocalPort_3.Enabled = True
		Me._txtLocalPort_3.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtLocalPort_3.HideSelection = True
		Me._txtLocalPort_3.ReadOnly = False
		Me._txtLocalPort_3.Maxlength = 0
		Me._txtLocalPort_3.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtLocalPort_3.MultiLine = False
		Me._txtLocalPort_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtLocalPort_3.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtLocalPort_3.TabStop = True
		Me._txtLocalPort_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtLocalPort_3.Name = "_txtLocalPort_3"
		Me._txtLocalPort_5.AutoSize = False
		Me._txtLocalPort_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._txtLocalPort_5.Size = New System.Drawing.Size(17, 25)
		Me._txtLocalPort_5.Location = New System.Drawing.Point(672, 48)
		Me._txtLocalPort_5.TabIndex = 134
		Me._txtLocalPort_5.Text = "0"
		Me._txtLocalPort_5.Visible = False
		Me._txtLocalPort_5.AcceptsReturn = True
		Me._txtLocalPort_5.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._txtLocalPort_5.BackColor = System.Drawing.SystemColors.Window
		Me._txtLocalPort_5.CausesValidation = True
		Me._txtLocalPort_5.Enabled = True
		Me._txtLocalPort_5.ForeColor = System.Drawing.SystemColors.WindowText
		Me._txtLocalPort_5.HideSelection = True
		Me._txtLocalPort_5.ReadOnly = False
		Me._txtLocalPort_5.Maxlength = 0
		Me._txtLocalPort_5.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._txtLocalPort_5.MultiLine = False
		Me._txtLocalPort_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._txtLocalPort_5.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._txtLocalPort_5.TabStop = True
		Me._txtLocalPort_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._txtLocalPort_5.Name = "_txtLocalPort_5"
		_Winsock1_4.OcxState = CType(resources.GetObject("_Winsock1_4.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Winsock1_4.Location = New System.Drawing.Point(528, 64)
		Me._Winsock1_4.Name = "_Winsock1_4"
		_Winsock1_5.OcxState = CType(resources.GetObject("_Winsock1_5.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Winsock1_5.Location = New System.Drawing.Point(560, 64)
		Me._Winsock1_5.Name = "_Winsock1_5"
		_Winsock1_6.OcxState = CType(resources.GetObject("_Winsock1_6.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Winsock1_6.Location = New System.Drawing.Point(736, 64)
		Me._Winsock1_6.Name = "_Winsock1_6"
		_Winsock1_7.OcxState = CType(resources.GetObject("_Winsock1_7.OcxState"), System.Windows.Forms.AxHost.State)
		Me._Winsock1_7.Location = New System.Drawing.Point(768, 64)
		Me._Winsock1_7.Name = "_Winsock1_7"
		Me.Label31.Text = "Status :"
		Me.Label31.Size = New System.Drawing.Size(33, 17)
		Me.Label31.Location = New System.Drawing.Point(904, 8)
		Me.Label31.TabIndex = 143
		Me.Label31.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label31.BackColor = System.Drawing.SystemColors.Control
		Me.Label31.Enabled = True
		Me.Label31.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label31.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label31.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label31.UseMnemonic = True
		Me.Label31.Visible = True
		Me.Label31.AutoSize = False
		Me.Label31.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label31.Name = "Label31"
		Me.Label30.Text = "Status :"
		Me.Label30.Size = New System.Drawing.Size(33, 17)
		Me.Label30.Location = New System.Drawing.Point(680, 8)
		Me.Label30.TabIndex = 136
		Me.Label30.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label30.BackColor = System.Drawing.SystemColors.Control
		Me.Label30.Enabled = True
		Me.Label30.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label30.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label30.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label30.UseMnemonic = True
		Me.Label30.Visible = True
		Me.Label30.AutoSize = False
		Me.Label30.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label30.Name = "Label30"
		Me.Label21.Text = "Status :"
		Me.Label21.Size = New System.Drawing.Size(33, 17)
		Me.Label21.Location = New System.Drawing.Point(456, 8)
		Me.Label21.TabIndex = 118
		Me.Label21.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label21.BackColor = System.Drawing.SystemColors.Control
		Me.Label21.Enabled = True
		Me.Label21.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label21.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label21.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label21.UseMnemonic = True
		Me.Label21.Visible = True
		Me.Label21.AutoSize = False
		Me.Label21.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label21.Name = "Label21"
		Me._LabLoop_2.Text = "IP"
		Me._LabLoop_2.Size = New System.Drawing.Size(49, 17)
		Me._LabLoop_2.Location = New System.Drawing.Point(312, 40)
		Me._LabLoop_2.TabIndex = 116
		Me._LabLoop_2.Visible = False
		Me._LabLoop_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoop_2.BackColor = System.Drawing.SystemColors.Control
		Me._LabLoop_2.Enabled = True
		Me._LabLoop_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoop_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoop_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoop_2.UseMnemonic = True
		Me._LabLoop_2.AutoSize = False
		Me._LabLoop_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._LabLoop_2.Name = "_LabLoop_2"
		Me._LabLoop_1.Text = "GW 2 :"
		Me._LabLoop_1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoop_1.Size = New System.Drawing.Size(57, 17)
		Me._LabLoop_1.Location = New System.Drawing.Point(24, 48)
		Me._LabLoop_1.TabIndex = 68
		Me._LabLoop_1.Visible = False
		Me._LabLoop_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoop_1.BackColor = System.Drawing.SystemColors.Control
		Me._LabLoop_1.Enabled = True
		Me._LabLoop_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoop_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoop_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoop_1.UseMnemonic = True
		Me._LabLoop_1.AutoSize = False
		Me._LabLoop_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._LabLoop_1.Name = "_LabLoop_1"
		Me._LabLoop_0.Text = "IP:"
		Me._LabLoop_0.Font = New System.Drawing.Font("Arial", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoop_0.ForeColor = System.Drawing.Color.Black
		Me._LabLoop_0.Size = New System.Drawing.Size(25, 17)
		Me._LabLoop_0.Location = New System.Drawing.Point(8, 16)
		Me._LabLoop_0.TabIndex = 67
		Me._LabLoop_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoop_0.BackColor = System.Drawing.SystemColors.Control
		Me._LabLoop_0.Enabled = True
		Me._LabLoop_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoop_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoop_0.UseMnemonic = True
		Me._LabLoop_0.Visible = True
		Me._LabLoop_0.AutoSize = False
		Me._LabLoop_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._LabLoop_0.Name = "_LabLoop_0"
		Me._Label1_0.Text = "Send To GW 1 :"
		Me._Label1_0.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_0.Size = New System.Drawing.Size(9, 17)
		Me._Label1_0.Location = New System.Drawing.Point(8, 24)
		Me._Label1_0.TabIndex = 22
		Me._Label1_0.Visible = False
		Me._Label1_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_0.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_0.Enabled = True
		Me._Label1_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_0.UseMnemonic = True
		Me._Label1_0.AutoSize = False
		Me._Label1_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_0.Name = "_Label1_0"
		Me._Label1_1.Text = "Receive From GW 2 :"
		Me._Label1_1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label1_1.Size = New System.Drawing.Size(9, 17)
		Me._Label1_1.Location = New System.Drawing.Point(8, 48)
		Me._Label1_1.TabIndex = 21
		Me._Label1_1.Visible = False
		Me._Label1_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label1_1.BackColor = System.Drawing.SystemColors.Control
		Me._Label1_1.Enabled = True
		Me._Label1_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label1_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label1_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label1_1.UseMnemonic = True
		Me._Label1_1.AutoSize = False
		Me._Label1_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label1_1.Name = "_Label1_1"
		Me.Label6.Text = "Status :"
		Me.Label6.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.Label6.Size = New System.Drawing.Size(41, 17)
		Me.Label6.Location = New System.Drawing.Point(224, 8)
		Me.Label6.TabIndex = 41
		Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label6.BackColor = System.Drawing.SystemColors.Control
		Me.Label6.Enabled = True
		Me.Label6.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label6.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label6.UseMnemonic = True
		Me.Label6.Visible = True
		Me.Label6.AutoSize = False
		Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label6.Name = "Label6"
		Me._OptTcpUdp_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptTcpUdp_1.Text = "UDP"
		Me._OptTcpUdp_1.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._OptTcpUdp_1.Size = New System.Drawing.Size(49, 12)
		Me._OptTcpUdp_1.Location = New System.Drawing.Point(128, 88)
		Me._OptTcpUdp_1.TabIndex = 9
		Me._OptTcpUdp_1.Visible = False
		Me._OptTcpUdp_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptTcpUdp_1.BackColor = System.Drawing.SystemColors.Control
		Me._OptTcpUdp_1.CausesValidation = True
		Me._OptTcpUdp_1.Enabled = True
		Me._OptTcpUdp_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptTcpUdp_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptTcpUdp_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptTcpUdp_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptTcpUdp_1.TabStop = True
		Me._OptTcpUdp_1.Checked = False
		Me._OptTcpUdp_1.Name = "_OptTcpUdp_1"
		Me._OptTcpUdp_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptTcpUdp_0.Text = "TCP"
		Me._OptTcpUdp_0.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me._OptTcpUdp_0.Size = New System.Drawing.Size(65, 12)
		Me._OptTcpUdp_0.Location = New System.Drawing.Point(48, 96)
		Me._OptTcpUdp_0.TabIndex = 8
		Me._OptTcpUdp_0.Visible = False
		Me._OptTcpUdp_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptTcpUdp_0.BackColor = System.Drawing.SystemColors.Control
		Me._OptTcpUdp_0.CausesValidation = True
		Me._OptTcpUdp_0.Enabled = True
		Me._OptTcpUdp_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptTcpUdp_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptTcpUdp_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptTcpUdp_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptTcpUdp_0.TabStop = True
		Me._OptTcpUdp_0.Checked = False
		Me._OptTcpUdp_0.Name = "_OptTcpUdp_0"
		Me.List1.BackColor = System.Drawing.Color.FromARGB(255, 255, 192)
		Me.List1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.List1.ForeColor = System.Drawing.Color.FromARGB(128, 128, 128)
		Me.List1.Size = New System.Drawing.Size(857, 166)
		Me.List1.Location = New System.Drawing.Point(8, 640)
		Me.List1.TabIndex = 0
		Me.List1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.List1.CausesValidation = True
		Me.List1.Enabled = True
		Me.List1.IntegralHeight = True
		Me.List1.Cursor = System.Windows.Forms.Cursors.Default
		Me.List1.SelectionMode = System.Windows.Forms.SelectionMode.One
		Me.List1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.List1.Sorted = False
		Me.List1.TabStop = True
		Me.List1.Visible = True
		Me.List1.MultiColumn = False
		Me.List1.Name = "List1"
		Me._CmdClrCnt_0.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me._CmdClrCnt_0.Text = "Clear Counter"
		Me._CmdClrCnt_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._CmdClrCnt_0.Size = New System.Drawing.Size(33, 17)
		Me._CmdClrCnt_0.Location = New System.Drawing.Point(224, 40)
		Me._CmdClrCnt_0.TabIndex = 58
		Me._CmdClrCnt_0.Visible = False
		Me._CmdClrCnt_0.BackColor = System.Drawing.SystemColors.Control
		Me._CmdClrCnt_0.CausesValidation = True
		Me._CmdClrCnt_0.Enabled = True
		Me._CmdClrCnt_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._CmdClrCnt_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._CmdClrCnt_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._CmdClrCnt_0.TabStop = True
		Me._CmdClrCnt_0.Name = "_CmdClrCnt_0"
		Me._TxtSendData_1.AutoSize = False
		Me._TxtSendData_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._TxtSendData_1.Size = New System.Drawing.Size(201, 25)
		Me._TxtSendData_1.Location = New System.Drawing.Point(104, 608)
		Me._TxtSendData_1.TabIndex = 81
		Me._TxtSendData_1.Visible = False
		Me._TxtSendData_1.AcceptsReturn = True
		Me._TxtSendData_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me._TxtSendData_1.BackColor = System.Drawing.SystemColors.Window
		Me._TxtSendData_1.CausesValidation = True
		Me._TxtSendData_1.Enabled = True
		Me._TxtSendData_1.ForeColor = System.Drawing.SystemColors.WindowText
		Me._TxtSendData_1.HideSelection = True
		Me._TxtSendData_1.ReadOnly = False
		Me._TxtSendData_1.Maxlength = 0
		Me._TxtSendData_1.Cursor = System.Windows.Forms.Cursors.IBeam
		Me._TxtSendData_1.MultiLine = False
		Me._TxtSendData_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._TxtSendData_1.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me._TxtSendData_1.TabStop = True
		Me._TxtSendData_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._TxtSendData_1.Name = "_TxtSendData_1"
		Me._OptTestMode_0.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptTestMode_0.Text = "Loopback Test"
		Me._OptTestMode_0.Enabled = False
		Me._OptTestMode_0.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptTestMode_0.Size = New System.Drawing.Size(121, 25)
		Me._OptTestMode_0.Location = New System.Drawing.Point(16, 64)
		Me._OptTestMode_0.TabIndex = 65
		Me._OptTestMode_0.Checked = True
		Me._OptTestMode_0.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptTestMode_0.BackColor = System.Drawing.SystemColors.Control
		Me._OptTestMode_0.CausesValidation = True
		Me._OptTestMode_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptTestMode_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptTestMode_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptTestMode_0.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptTestMode_0.TabStop = True
		Me._OptTestMode_0.Visible = True
		Me._OptTestMode_0.Name = "_OptTestMode_0"
		Me._OptTestMode_1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptTestMode_1.Text = "Cross Test"
		Me._OptTestMode_1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._OptTestMode_1.Size = New System.Drawing.Size(97, 25)
		Me._OptTestMode_1.Location = New System.Drawing.Point(160, 64)
		Me._OptTestMode_1.TabIndex = 66
		Me.ToolTip1.SetToolTip(Me._OptTestMode_1, "Switch to loopback mode (x to x+1)")
		Me._OptTestMode_1.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me._OptTestMode_1.BackColor = System.Drawing.SystemColors.Control
		Me._OptTestMode_1.CausesValidation = True
		Me._OptTestMode_1.Enabled = True
		Me._OptTestMode_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._OptTestMode_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._OptTestMode_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._OptTestMode_1.Appearance = System.Windows.Forms.Appearance.Normal
		Me._OptTestMode_1.TabStop = True
		Me._OptTestMode_1.Checked = False
		Me._OptTestMode_1.Visible = True
		Me._OptTestMode_1.Name = "_OptTestMode_1"
		Me.ChkXOnOff.Text = "Don't Care Xon/off"
		Me.ChkXOnOff.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.ChkXOnOff.Size = New System.Drawing.Size(153, 26)
		Me.ChkXOnOff.Location = New System.Drawing.Point(352, 96)
		Me.ChkXOnOff.TabIndex = 92
		Me.ChkXOnOff.CheckState = System.Windows.Forms.CheckState.Checked
		Me.ChkXOnOff.Visible = False
		Me.ChkXOnOff.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ChkXOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkXOnOff.BackColor = System.Drawing.SystemColors.Control
		Me.ChkXOnOff.CausesValidation = True
		Me.ChkXOnOff.Enabled = True
		Me.ChkXOnOff.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkXOnOff.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkXOnOff.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkXOnOff.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkXOnOff.TabStop = True
		Me.ChkXOnOff.Name = "ChkXOnOff"
		Me.ChkRecdAck.Text = "ACK Access Record"
		Me.ChkRecdAck.Size = New System.Drawing.Size(129, 17)
		Me.ChkRecdAck.Location = New System.Drawing.Point(208, 96)
		Me.ChkRecdAck.TabIndex = 36
		Me.ChkRecdAck.Visible = False
		Me.ChkRecdAck.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ChkRecdAck.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkRecdAck.BackColor = System.Drawing.SystemColors.Control
		Me.ChkRecdAck.CausesValidation = True
		Me.ChkRecdAck.Enabled = True
		Me.ChkRecdAck.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkRecdAck.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkRecdAck.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkRecdAck.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkRecdAck.TabStop = True
		Me.ChkRecdAck.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkRecdAck.Name = "ChkRecdAck"
		Me.Command1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.Command1.Text = "Clear List"
		Me.Command1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Command1.Size = New System.Drawing.Size(57, 25)
		Me.Command1.Location = New System.Drawing.Point(448, 352)
		Me.Command1.TabIndex = 107
		Me.Command1.Visible = False
		Me.Command1.BackColor = System.Drawing.SystemColors.Control
		Me.Command1.CausesValidation = True
		Me.Command1.Enabled = True
		Me.Command1.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Command1.Cursor = System.Windows.Forms.Cursors.Default
		Me.Command1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Command1.TabStop = True
		Me.Command1.Name = "Command1"
		Me.CmdBrow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdBrow.Text = "..."
		Me.CmdBrow.Font = New System.Drawing.Font("Arial Black", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.CmdBrow.Size = New System.Drawing.Size(25, 20)
		Me.CmdBrow.Location = New System.Drawing.Point(776, 688)
		Me.CmdBrow.TabIndex = 38
		Me.CmdBrow.Visible = False
		Me.CmdBrow.BackColor = System.Drawing.SystemColors.Control
		Me.CmdBrow.CausesValidation = True
		Me.CmdBrow.Enabled = True
		Me.CmdBrow.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdBrow.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdBrow.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdBrow.TabStop = True
		Me.CmdBrow.Name = "CmdBrow"
		Me.TxtLogFile.AutoSize = False
		Me.TxtLogFile.Size = New System.Drawing.Size(89, 19)
		Me.TxtLogFile.Location = New System.Drawing.Point(680, 688)
		Me.TxtLogFile.TabIndex = 37
		Me.TxtLogFile.Visible = False
		Me.TxtLogFile.AcceptsReturn = True
		Me.TxtLogFile.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtLogFile.BackColor = System.Drawing.SystemColors.Window
		Me.TxtLogFile.CausesValidation = True
		Me.TxtLogFile.Enabled = True
		Me.TxtLogFile.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtLogFile.HideSelection = True
		Me.TxtLogFile.ReadOnly = False
		Me.TxtLogFile.Maxlength = 0
		Me.TxtLogFile.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtLogFile.MultiLine = False
		Me.TxtLogFile.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtLogFile.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtLogFile.TabStop = True
		Me.TxtLogFile.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtLogFile.Name = "TxtLogFile"
		Me.ChkRemote.Text = "Show Remote IP"
		Me.ChkRemote.Size = New System.Drawing.Size(81, 28)
		Me.ChkRemote.Location = New System.Drawing.Point(816, 632)
		Me.ChkRemote.TabIndex = 31
		Me.ChkRemote.Visible = False
		Me.ChkRemote.CheckAlign = System.Drawing.ContentAlignment.MiddleLeft
		Me.ChkRemote.FlatStyle = System.Windows.Forms.FlatStyle.Standard
		Me.ChkRemote.BackColor = System.Drawing.SystemColors.Control
		Me.ChkRemote.CausesValidation = True
		Me.ChkRemote.Enabled = True
		Me.ChkRemote.ForeColor = System.Drawing.SystemColors.ControlText
		Me.ChkRemote.Cursor = System.Windows.Forms.Cursors.Default
		Me.ChkRemote.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.ChkRemote.Appearance = System.Windows.Forms.Appearance.Normal
		Me.ChkRemote.TabStop = True
		Me.ChkRemote.CheckState = System.Windows.Forms.CheckState.Unchecked
		Me.ChkRemote.Name = "ChkRemote"
		Me.txtData.AutoSize = False
		Me.txtData.Size = New System.Drawing.Size(33, 25)
		Me.txtData.Location = New System.Drawing.Point(624, 632)
		Me.txtData.TabIndex = 4
		Me.txtData.Text = "D1"
		Me.txtData.Visible = False
		Me.txtData.AcceptsReturn = True
		Me.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtData.BackColor = System.Drawing.SystemColors.Window
		Me.txtData.CausesValidation = True
		Me.txtData.Enabled = True
		Me.txtData.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtData.HideSelection = True
		Me.txtData.ReadOnly = False
		Me.txtData.Maxlength = 0
		Me.txtData.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtData.MultiLine = False
		Me.txtData.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtData.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtData.TabStop = True
		Me.txtData.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtData.Name = "txtData"
		Me.cmdSend.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSend.Text = "&Send"
		Me.cmdSend.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cmdSend.Size = New System.Drawing.Size(33, 25)
		Me.cmdSend.Location = New System.Drawing.Point(664, 632)
		Me.cmdSend.TabIndex = 2
		Me.cmdSend.Visible = False
		Me.cmdSend.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSend.CausesValidation = True
		Me.cmdSend.Enabled = True
		Me.cmdSend.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSend.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSend.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSend.TabStop = True
		Me.cmdSend.Name = "cmdSend"
		Me.txtDaport.AutoSize = False
		Me.txtDaport.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtDaport.Size = New System.Drawing.Size(17, 25)
		Me.txtDaport.Location = New System.Drawing.Point(568, 632)
		Me.txtDaport.TabIndex = 3
		Me.txtDaport.Text = "1"
		Me.txtDaport.Visible = False
		Me.txtDaport.AcceptsReturn = True
		Me.txtDaport.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtDaport.BackColor = System.Drawing.SystemColors.Window
		Me.txtDaport.CausesValidation = True
		Me.txtDaport.Enabled = True
		Me.txtDaport.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtDaport.HideSelection = True
		Me.txtDaport.ReadOnly = False
		Me.txtDaport.Maxlength = 0
		Me.txtDaport.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtDaport.MultiLine = False
		Me.txtDaport.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtDaport.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtDaport.TabStop = True
		Me.txtDaport.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtDaport.Name = "txtDaport"
		Me.txtListCnt.AutoSize = False
		Me.txtListCnt.Size = New System.Drawing.Size(41, 18)
		Me.txtListCnt.Location = New System.Drawing.Point(552, 688)
		Me.txtListCnt.TabIndex = 10
		Me.txtListCnt.Visible = False
		Me.txtListCnt.AcceptsReturn = True
		Me.txtListCnt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtListCnt.BackColor = System.Drawing.SystemColors.Window
		Me.txtListCnt.CausesValidation = True
		Me.txtListCnt.Enabled = True
		Me.txtListCnt.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtListCnt.HideSelection = True
		Me.txtListCnt.ReadOnly = False
		Me.txtListCnt.Maxlength = 0
		Me.txtListCnt.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtListCnt.MultiLine = False
		Me.txtListCnt.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtListCnt.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtListCnt.TabStop = True
		Me.txtListCnt.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtListCnt.Name = "txtListCnt"
		Me.txtId2.AutoSize = False
		Me.txtId2.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtId2.Size = New System.Drawing.Size(25, 25)
		Me.txtId2.Location = New System.Drawing.Point(552, 656)
		Me.txtId2.TabIndex = 23
		Me.txtId2.Text = "0"
		Me.txtId2.Visible = False
		Me.txtId2.AcceptsReturn = True
		Me.txtId2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtId2.BackColor = System.Drawing.SystemColors.Window
		Me.txtId2.CausesValidation = True
		Me.txtId2.Enabled = True
		Me.txtId2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtId2.HideSelection = True
		Me.txtId2.ReadOnly = False
		Me.txtId2.Maxlength = 0
		Me.txtId2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtId2.MultiLine = False
		Me.txtId2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtId2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtId2.TabStop = True
		Me.txtId2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtId2.Name = "txtId2"
		Me.cmdSend2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.cmdSend2.Text = "S&end"
		Me.cmdSend2.Font = New System.Drawing.Font("新細明體", 9!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.cmdSend2.Size = New System.Drawing.Size(33, 25)
		Me.cmdSend2.Location = New System.Drawing.Point(856, 656)
		Me.cmdSend2.TabIndex = 24
		Me.cmdSend2.Visible = False
		Me.cmdSend2.BackColor = System.Drawing.SystemColors.Control
		Me.cmdSend2.CausesValidation = True
		Me.cmdSend2.Enabled = True
		Me.cmdSend2.ForeColor = System.Drawing.SystemColors.ControlText
		Me.cmdSend2.Cursor = System.Windows.Forms.Cursors.Default
		Me.cmdSend2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.cmdSend2.TabStop = True
		Me.cmdSend2.Name = "cmdSend2"
		Me.txtData2.AutoSize = False
		Me.txtData2.Size = New System.Drawing.Size(265, 25)
		Me.txtData2.Location = New System.Drawing.Point(584, 656)
		Me.txtData2.TabIndex = 25
		Me.txtData2.Text = "\07\00\80\00\99\99R"
		Me.txtData2.Visible = False
		Me.txtData2.AcceptsReturn = True
		Me.txtData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtData2.BackColor = System.Drawing.SystemColors.Window
		Me.txtData2.CausesValidation = True
		Me.txtData2.Enabled = True
		Me.txtData2.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtData2.HideSelection = True
		Me.txtData2.ReadOnly = False
		Me.txtData2.Maxlength = 0
		Me.txtData2.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtData2.MultiLine = False
		Me.txtData2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtData2.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtData2.TabStop = True
		Me.txtData2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtData2.Name = "txtData2"
		Me.txtMsg.AutoSize = False
		Me.txtMsg.Font = New System.Drawing.Font("新細明體", 12!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.txtMsg.Size = New System.Drawing.Size(105, 25)
		Me.txtMsg.Location = New System.Drawing.Point(704, 632)
		Me.txtMsg.TabIndex = 30
		Me.txtMsg.Visible = False
		Me.txtMsg.AcceptsReturn = True
		Me.txtMsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.txtMsg.BackColor = System.Drawing.SystemColors.Window
		Me.txtMsg.CausesValidation = True
		Me.txtMsg.Enabled = True
		Me.txtMsg.ForeColor = System.Drawing.SystemColors.WindowText
		Me.txtMsg.HideSelection = True
		Me.txtMsg.ReadOnly = False
		Me.txtMsg.Maxlength = 0
		Me.txtMsg.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.txtMsg.MultiLine = False
		Me.txtMsg.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.txtMsg.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.txtMsg.TabStop = True
		Me.txtMsg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.txtMsg.Name = "txtMsg"
		Me.TxtID.AutoSize = False
		Me.TxtID.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.TxtID.Size = New System.Drawing.Size(17, 25)
		Me.TxtID.Location = New System.Drawing.Point(544, 632)
		Me.TxtID.TabIndex = 33
		Me.TxtID.Text = "0"
		Me.TxtID.Visible = False
		Me.TxtID.AcceptsReturn = True
		Me.TxtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtID.BackColor = System.Drawing.SystemColors.Window
		Me.TxtID.CausesValidation = True
		Me.TxtID.Enabled = True
		Me.TxtID.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtID.HideSelection = True
		Me.TxtID.ReadOnly = False
		Me.TxtID.Maxlength = 0
		Me.TxtID.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtID.MultiLine = False
		Me.TxtID.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtID.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtID.TabStop = True
		Me.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtID.Name = "TxtID"
		Me.TxtSubNode.AutoSize = False
		Me.TxtSubNode.Font = New System.Drawing.Font("新細明體", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.TxtSubNode.Size = New System.Drawing.Size(25, 25)
		Me.TxtSubNode.Location = New System.Drawing.Point(592, 632)
		Me.TxtSubNode.TabIndex = 35
		Me.TxtSubNode.Text = "01"
		Me.TxtSubNode.Visible = False
		Me.TxtSubNode.AcceptsReturn = True
		Me.TxtSubNode.TextAlign = System.Windows.Forms.HorizontalAlignment.Left
		Me.TxtSubNode.BackColor = System.Drawing.SystemColors.Window
		Me.TxtSubNode.CausesValidation = True
		Me.TxtSubNode.Enabled = True
		Me.TxtSubNode.ForeColor = System.Drawing.SystemColors.WindowText
		Me.TxtSubNode.HideSelection = True
		Me.TxtSubNode.ReadOnly = False
		Me.TxtSubNode.Maxlength = 0
		Me.TxtSubNode.Cursor = System.Windows.Forms.Cursors.IBeam
		Me.TxtSubNode.MultiLine = False
		Me.TxtSubNode.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.TxtSubNode.ScrollBars = System.Windows.Forms.ScrollBars.None
		Me.TxtSubNode.TabStop = True
		Me.TxtSubNode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.TxtSubNode.Name = "TxtSubNode"
		Me.CmdSaveList.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
		Me.CmdSaveList.Text = "Save List"
		Me.CmdSaveList.Size = New System.Drawing.Size(73, 17)
		Me.CmdSaveList.Location = New System.Drawing.Point(808, 688)
		Me.CmdSaveList.TabIndex = 39
		Me.CmdSaveList.Visible = False
		Me.CmdSaveList.BackColor = System.Drawing.SystemColors.Control
		Me.CmdSaveList.CausesValidation = True
		Me.CmdSaveList.Enabled = True
		Me.CmdSaveList.ForeColor = System.Drawing.SystemColors.ControlText
		Me.CmdSaveList.Cursor = System.Windows.Forms.Cursors.Default
		Me.CmdSaveList.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.CmdSaveList.TabStop = True
		Me.CmdSaveList.Name = "CmdSaveList"
		Me.Label32.Text = "Sending Interval (ms) to all :"
		Me.Label32.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label32.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.Label32.Size = New System.Drawing.Size(137, 17)
		Me.Label32.Location = New System.Drawing.Point(128, 24)
		Me.Label32.TabIndex = 238
		Me.Label32.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label32.BackColor = System.Drawing.SystemColors.Control
		Me.Label32.Enabled = True
		Me.Label32.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label32.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label32.UseMnemonic = True
		Me.Label32.Visible = True
		Me.Label32.AutoSize = False
		Me.Label32.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label32.Name = "Label32"
		Me.Label33.Text = "Sending Data Length (bytes) to all :"
		Me.Label33.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label33.ForeColor = System.Drawing.Color.FromARGB(128, 0, 0)
		Me.Label33.Size = New System.Drawing.Size(177, 17)
		Me.Label33.Location = New System.Drawing.Point(288, 24)
		Me.Label33.TabIndex = 239
		Me.Label33.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label33.BackColor = System.Drawing.SystemColors.Control
		Me.Label33.Enabled = True
		Me.Label33.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label33.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label33.UseMnemonic = True
		Me.Label33.Visible = True
		Me.Label33.AutoSize = False
		Me.Label33.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label33.Name = "Label33"
		Me._Label20_7.Text = "Rate: (bytes/sec)"
		Me._Label20_7.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label20_7.Size = New System.Drawing.Size(49, 33)
		Me._Label20_7.Location = New System.Drawing.Point(808, 492)
		Me._Label20_7.TabIndex = 224
		Me._Label20_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label20_7.BackColor = System.Drawing.SystemColors.Control
		Me._Label20_7.Enabled = True
		Me._Label20_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label20_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label20_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label20_7.UseMnemonic = True
		Me._Label20_7.Visible = True
		Me._Label20_7.AutoSize = False
		Me._Label20_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label20_7.Name = "_Label20_7"
		Me._LabRcv_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabRcv_7.Size = New System.Drawing.Size(41, 25)
		Me._LabRcv_7.Location = New System.Drawing.Point(808, 556)
		Me._LabRcv_7.TabIndex = 223
		Me._LabRcv_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabRcv_7.BackColor = System.Drawing.Color.Transparent
		Me._LabRcv_7.Enabled = True
		Me._LabRcv_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabRcv_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabRcv_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabRcv_7.UseMnemonic = True
		Me._LabRcv_7.Visible = True
		Me._LabRcv_7.AutoSize = False
		Me._LabRcv_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabRcv_7.Name = "_LabRcv_7"
		Me._LabLoss_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoss_7.Size = New System.Drawing.Size(41, 25)
		Me._LabLoss_7.Location = New System.Drawing.Point(808, 584)
		Me._LabLoss_7.TabIndex = 222
		Me._LabLoss_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoss_7.BackColor = System.Drawing.Color.Transparent
		Me._LabLoss_7.Enabled = True
		Me._LabLoss_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoss_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoss_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoss_7.UseMnemonic = True
		Me._LabLoss_7.Visible = True
		Me._LabLoss_7.AutoSize = False
		Me._LabLoss_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabLoss_7.Name = "_LabLoss_7"
		Me._Label24_7.Text = "Packet No."
		Me._Label24_7.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label24_7.Size = New System.Drawing.Size(57, 17)
		Me._Label24_7.Location = New System.Drawing.Point(864, 476)
		Me._Label24_7.TabIndex = 221
		Me._Label24_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label24_7.BackColor = System.Drawing.SystemColors.Control
		Me._Label24_7.Enabled = True
		Me._Label24_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label24_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label24_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label24_7.UseMnemonic = True
		Me._Label24_7.Visible = True
		Me._Label24_7.AutoSize = False
		Me._Label24_7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label24_7.Name = "_Label24_7"
		Me._LabSend_7.Text = "0"
		Me._LabSend_7.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabSend_7.Size = New System.Drawing.Size(41, 25)
		Me._LabSend_7.Location = New System.Drawing.Point(808, 524)
		Me._LabSend_7.TabIndex = 220
		Me._LabSend_7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabSend_7.BackColor = System.Drawing.Color.Transparent
		Me._LabSend_7.Enabled = True
		Me._LabSend_7.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabSend_7.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabSend_7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabSend_7.UseMnemonic = True
		Me._LabSend_7.Visible = True
		Me._LabSend_7.AutoSize = False
		Me._LabSend_7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabSend_7.Name = "_LabSend_7"
		Me._Label20_6.Text = "Rate: (bytes/sec)"
		Me._Label20_6.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label20_6.Size = New System.Drawing.Size(49, 25)
		Me._Label20_6.Location = New System.Drawing.Point(808, 256)
		Me._Label20_6.TabIndex = 208
		Me._Label20_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label20_6.BackColor = System.Drawing.SystemColors.Control
		Me._Label20_6.Enabled = True
		Me._Label20_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label20_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label20_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label20_6.UseMnemonic = True
		Me._Label20_6.Visible = True
		Me._Label20_6.AutoSize = False
		Me._Label20_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label20_6.Name = "_Label20_6"
		Me._LabRcv_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabRcv_6.Size = New System.Drawing.Size(41, 25)
		Me._LabRcv_6.Location = New System.Drawing.Point(808, 320)
		Me._LabRcv_6.TabIndex = 207
		Me._LabRcv_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabRcv_6.BackColor = System.Drawing.Color.Transparent
		Me._LabRcv_6.Enabled = True
		Me._LabRcv_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabRcv_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabRcv_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabRcv_6.UseMnemonic = True
		Me._LabRcv_6.Visible = True
		Me._LabRcv_6.AutoSize = False
		Me._LabRcv_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabRcv_6.Name = "_LabRcv_6"
		Me._LabLoss_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoss_6.Size = New System.Drawing.Size(41, 25)
		Me._LabLoss_6.Location = New System.Drawing.Point(808, 352)
		Me._LabLoss_6.TabIndex = 206
		Me._LabLoss_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoss_6.BackColor = System.Drawing.Color.Transparent
		Me._LabLoss_6.Enabled = True
		Me._LabLoss_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoss_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoss_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoss_6.UseMnemonic = True
		Me._LabLoss_6.Visible = True
		Me._LabLoss_6.AutoSize = False
		Me._LabLoss_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabLoss_6.Name = "_LabLoss_6"
		Me._Label24_6.Text = "Packet No."
		Me._Label24_6.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label24_6.Size = New System.Drawing.Size(57, 17)
		Me._Label24_6.Location = New System.Drawing.Point(864, 240)
		Me._Label24_6.TabIndex = 205
		Me._Label24_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label24_6.BackColor = System.Drawing.SystemColors.Control
		Me._Label24_6.Enabled = True
		Me._Label24_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label24_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label24_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label24_6.UseMnemonic = True
		Me._Label24_6.Visible = True
		Me._Label24_6.AutoSize = False
		Me._Label24_6.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label24_6.Name = "_Label24_6"
		Me._LabSend_6.Text = "0"
		Me._LabSend_6.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabSend_6.Size = New System.Drawing.Size(41, 25)
		Me._LabSend_6.Location = New System.Drawing.Point(808, 288)
		Me._LabSend_6.TabIndex = 204
		Me._LabSend_6.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabSend_6.BackColor = System.Drawing.Color.Transparent
		Me._LabSend_6.Enabled = True
		Me._LabSend_6.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabSend_6.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabSend_6.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabSend_6.UseMnemonic = True
		Me._LabSend_6.Visible = True
		Me._LabSend_6.AutoSize = False
		Me._LabSend_6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabSend_6.Name = "_LabSend_6"
		Me._Label20_5.Text = "Rate: (bytes/sec)"
		Me._Label20_5.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label20_5.Size = New System.Drawing.Size(49, 33)
		Me._Label20_5.Location = New System.Drawing.Point(600, 492)
		Me._Label20_5.TabIndex = 192
		Me._Label20_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label20_5.BackColor = System.Drawing.SystemColors.Control
		Me._Label20_5.Enabled = True
		Me._Label20_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label20_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label20_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label20_5.UseMnemonic = True
		Me._Label20_5.Visible = True
		Me._Label20_5.AutoSize = False
		Me._Label20_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label20_5.Name = "_Label20_5"
		Me._LabRcv_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabRcv_5.Size = New System.Drawing.Size(41, 25)
		Me._LabRcv_5.Location = New System.Drawing.Point(600, 556)
		Me._LabRcv_5.TabIndex = 191
		Me._LabRcv_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabRcv_5.BackColor = System.Drawing.Color.Transparent
		Me._LabRcv_5.Enabled = True
		Me._LabRcv_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabRcv_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabRcv_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabRcv_5.UseMnemonic = True
		Me._LabRcv_5.Visible = True
		Me._LabRcv_5.AutoSize = False
		Me._LabRcv_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabRcv_5.Name = "_LabRcv_5"
		Me._LabLoss_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoss_5.Size = New System.Drawing.Size(41, 25)
		Me._LabLoss_5.Location = New System.Drawing.Point(600, 584)
		Me._LabLoss_5.TabIndex = 190
		Me._LabLoss_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoss_5.BackColor = System.Drawing.Color.Transparent
		Me._LabLoss_5.Enabled = True
		Me._LabLoss_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoss_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoss_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoss_5.UseMnemonic = True
		Me._LabLoss_5.Visible = True
		Me._LabLoss_5.AutoSize = False
		Me._LabLoss_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabLoss_5.Name = "_LabLoss_5"
		Me._Label24_5.Text = "Packet No."
		Me._Label24_5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label24_5.Size = New System.Drawing.Size(57, 17)
		Me._Label24_5.Location = New System.Drawing.Point(656, 476)
		Me._Label24_5.TabIndex = 189
		Me._Label24_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label24_5.BackColor = System.Drawing.SystemColors.Control
		Me._Label24_5.Enabled = True
		Me._Label24_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label24_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label24_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label24_5.UseMnemonic = True
		Me._Label24_5.Visible = True
		Me._Label24_5.AutoSize = False
		Me._Label24_5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label24_5.Name = "_Label24_5"
		Me._LabSend_5.Text = "0"
		Me._LabSend_5.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabSend_5.Size = New System.Drawing.Size(41, 25)
		Me._LabSend_5.Location = New System.Drawing.Point(600, 524)
		Me._LabSend_5.TabIndex = 188
		Me._LabSend_5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabSend_5.BackColor = System.Drawing.Color.Transparent
		Me._LabSend_5.Enabled = True
		Me._LabSend_5.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabSend_5.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabSend_5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabSend_5.UseMnemonic = True
		Me._LabSend_5.Visible = True
		Me._LabSend_5.AutoSize = False
		Me._LabSend_5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabSend_5.Name = "_LabSend_5"
		Me._Label20_4.Text = "Rate: (bytes/sec)"
		Me._Label20_4.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label20_4.Size = New System.Drawing.Size(49, 33)
		Me._Label20_4.Location = New System.Drawing.Point(600, 256)
		Me._Label20_4.TabIndex = 176
		Me._Label20_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label20_4.BackColor = System.Drawing.SystemColors.Control
		Me._Label20_4.Enabled = True
		Me._Label20_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label20_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label20_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label20_4.UseMnemonic = True
		Me._Label20_4.Visible = True
		Me._Label20_4.AutoSize = False
		Me._Label20_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label20_4.Name = "_Label20_4"
		Me._LabRcv_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabRcv_4.Size = New System.Drawing.Size(41, 25)
		Me._LabRcv_4.Location = New System.Drawing.Point(600, 320)
		Me._LabRcv_4.TabIndex = 175
		Me._LabRcv_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabRcv_4.BackColor = System.Drawing.Color.Transparent
		Me._LabRcv_4.Enabled = True
		Me._LabRcv_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabRcv_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabRcv_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabRcv_4.UseMnemonic = True
		Me._LabRcv_4.Visible = True
		Me._LabRcv_4.AutoSize = False
		Me._LabRcv_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabRcv_4.Name = "_LabRcv_4"
		Me._LabLoss_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoss_4.Size = New System.Drawing.Size(41, 25)
		Me._LabLoss_4.Location = New System.Drawing.Point(600, 352)
		Me._LabLoss_4.TabIndex = 174
		Me._LabLoss_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoss_4.BackColor = System.Drawing.Color.Transparent
		Me._LabLoss_4.Enabled = True
		Me._LabLoss_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoss_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoss_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoss_4.UseMnemonic = True
		Me._LabLoss_4.Visible = True
		Me._LabLoss_4.AutoSize = False
		Me._LabLoss_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabLoss_4.Name = "_LabLoss_4"
		Me._Label24_4.Text = "Packet No."
		Me._Label24_4.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label24_4.Size = New System.Drawing.Size(57, 17)
		Me._Label24_4.Location = New System.Drawing.Point(656, 240)
		Me._Label24_4.TabIndex = 173
		Me._Label24_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label24_4.BackColor = System.Drawing.SystemColors.Control
		Me._Label24_4.Enabled = True
		Me._Label24_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label24_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label24_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label24_4.UseMnemonic = True
		Me._Label24_4.Visible = True
		Me._Label24_4.AutoSize = False
		Me._Label24_4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label24_4.Name = "_Label24_4"
		Me._LabSend_4.Text = "0"
		Me._LabSend_4.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabSend_4.Size = New System.Drawing.Size(41, 25)
		Me._LabSend_4.Location = New System.Drawing.Point(600, 288)
		Me._LabSend_4.TabIndex = 172
		Me._LabSend_4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabSend_4.BackColor = System.Drawing.Color.Transparent
		Me._LabSend_4.Enabled = True
		Me._LabSend_4.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabSend_4.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabSend_4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabSend_4.UseMnemonic = True
		Me._LabSend_4.Visible = True
		Me._LabSend_4.AutoSize = False
		Me._LabSend_4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabSend_4.Name = "_LabSend_4"
		Me._Label20_3.Text = "Rate: (bytes/sec)"
		Me._Label20_3.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label20_3.Size = New System.Drawing.Size(49, 33)
		Me._Label20_3.Location = New System.Drawing.Point(392, 492)
		Me._Label20_3.TabIndex = 160
		Me._Label20_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label20_3.BackColor = System.Drawing.SystemColors.Control
		Me._Label20_3.Enabled = True
		Me._Label20_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label20_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label20_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label20_3.UseMnemonic = True
		Me._Label20_3.Visible = True
		Me._Label20_3.AutoSize = False
		Me._Label20_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label20_3.Name = "_Label20_3"
		Me._LabRcv_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabRcv_3.Size = New System.Drawing.Size(41, 25)
		Me._LabRcv_3.Location = New System.Drawing.Point(392, 556)
		Me._LabRcv_3.TabIndex = 159
		Me._LabRcv_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabRcv_3.BackColor = System.Drawing.Color.Transparent
		Me._LabRcv_3.Enabled = True
		Me._LabRcv_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabRcv_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabRcv_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabRcv_3.UseMnemonic = True
		Me._LabRcv_3.Visible = True
		Me._LabRcv_3.AutoSize = False
		Me._LabRcv_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabRcv_3.Name = "_LabRcv_3"
		Me._LabLoss_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoss_3.Size = New System.Drawing.Size(41, 25)
		Me._LabLoss_3.Location = New System.Drawing.Point(392, 584)
		Me._LabLoss_3.TabIndex = 158
		Me._LabLoss_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoss_3.BackColor = System.Drawing.Color.Transparent
		Me._LabLoss_3.Enabled = True
		Me._LabLoss_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoss_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoss_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoss_3.UseMnemonic = True
		Me._LabLoss_3.Visible = True
		Me._LabLoss_3.AutoSize = False
		Me._LabLoss_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabLoss_3.Name = "_LabLoss_3"
		Me._Label24_3.Text = "Packet No."
		Me._Label24_3.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label24_3.Size = New System.Drawing.Size(57, 17)
		Me._Label24_3.Location = New System.Drawing.Point(448, 476)
		Me._Label24_3.TabIndex = 157
		Me._Label24_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label24_3.BackColor = System.Drawing.SystemColors.Control
		Me._Label24_3.Enabled = True
		Me._Label24_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label24_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label24_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label24_3.UseMnemonic = True
		Me._Label24_3.Visible = True
		Me._Label24_3.AutoSize = False
		Me._Label24_3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label24_3.Name = "_Label24_3"
		Me._LabSend_3.Text = "0"
		Me._LabSend_3.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabSend_3.Size = New System.Drawing.Size(41, 25)
		Me._LabSend_3.Location = New System.Drawing.Point(392, 524)
		Me._LabSend_3.TabIndex = 156
		Me._LabSend_3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabSend_3.BackColor = System.Drawing.Color.Transparent
		Me._LabSend_3.Enabled = True
		Me._LabSend_3.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabSend_3.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabSend_3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabSend_3.UseMnemonic = True
		Me._LabSend_3.Visible = True
		Me._LabSend_3.AutoSize = False
		Me._LabSend_3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabSend_3.Name = "_LabSend_3"
		Me.Label29.Text = "Sending Data Length (bytes) :"
		Me.Label29.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label29.Size = New System.Drawing.Size(153, 17)
		Me.Label29.Location = New System.Drawing.Point(8, 432)
		Me.Label29.TabIndex = 124
		Me.Label29.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label29.BackColor = System.Drawing.SystemColors.Control
		Me.Label29.Enabled = True
		Me.Label29.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label29.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label29.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label29.UseMnemonic = True
		Me.Label29.Visible = True
		Me.Label29.AutoSize = False
		Me.Label29.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label29.Name = "Label29"
		Me.Label28.Text = "Sending Interval (ms) :"
		Me.Label28.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label28.Size = New System.Drawing.Size(113, 17)
		Me.Label28.Location = New System.Drawing.Point(8, 408)
		Me.Label28.TabIndex = 123
		Me.Label28.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label28.BackColor = System.Drawing.SystemColors.Control
		Me.Label28.Enabled = True
		Me.Label28.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label28.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label28.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label28.UseMnemonic = True
		Me.Label28.Visible = True
		Me.Label28.AutoSize = False
		Me.Label28.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label28.Name = "Label28"
		Me.Label27.Text = "Send Bytes :"
		Me.Label27.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label27.Size = New System.Drawing.Size(73, 17)
		Me.Label27.Location = New System.Drawing.Point(8, 520)
		Me.Label27.TabIndex = 122
		Me.Label27.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label27.BackColor = System.Drawing.SystemColors.Control
		Me.Label27.Enabled = True
		Me.Label27.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label27.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label27.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label27.UseMnemonic = True
		Me.Label27.Visible = True
		Me.Label27.AutoSize = False
		Me.Label27.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label27.Name = "Label27"
		Me.Label26.Text = "Receive Bytes :"
		Me.Label26.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label26.Size = New System.Drawing.Size(81, 17)
		Me.Label26.Location = New System.Drawing.Point(8, 552)
		Me.Label26.TabIndex = 121
		Me.Label26.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label26.BackColor = System.Drawing.SystemColors.Control
		Me.Label26.Enabled = True
		Me.Label26.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label26.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label26.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label26.UseMnemonic = True
		Me.Label26.Visible = True
		Me.Label26.AutoSize = False
		Me.Label26.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label26.Name = "Label26"
		Me.Label25.Text = "Total Loss :"
		Me.Label25.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label25.Size = New System.Drawing.Size(65, 17)
		Me.Label25.Location = New System.Drawing.Point(8, 584)
		Me.Label25.TabIndex = 120
		Me.Label25.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label25.BackColor = System.Drawing.SystemColors.Control
		Me.Label25.Enabled = True
		Me.Label25.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label25.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label25.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label25.UseMnemonic = True
		Me.Label25.Visible = True
		Me.Label25.AutoSize = False
		Me.Label25.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label25.Name = "Label25"
		Me.Label23.Text = "SendTotal Bytes :"
		Me.Label23.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label23.Size = New System.Drawing.Size(89, 17)
		Me.Label23.Location = New System.Drawing.Point(8, 488)
		Me.Label23.TabIndex = 119
		Me.Label23.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label23.BackColor = System.Drawing.SystemColors.Control
		Me.Label23.Enabled = True
		Me.Label23.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label23.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label23.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label23.UseMnemonic = True
		Me.Label23.Visible = True
		Me.Label23.AutoSize = False
		Me.Label23.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label23.Name = "Label23"
		Me._LabSend_2.Text = "0"
		Me._LabSend_2.Font = New System.Drawing.Font("新細明體", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabSend_2.Size = New System.Drawing.Size(41, 25)
		Me._LabSend_2.Location = New System.Drawing.Point(392, 288)
		Me._LabSend_2.TabIndex = 117
		Me._LabSend_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabSend_2.BackColor = System.Drawing.Color.Transparent
		Me._LabSend_2.Enabled = True
		Me._LabSend_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabSend_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabSend_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabSend_2.UseMnemonic = True
		Me._LabSend_2.Visible = True
		Me._LabSend_2.AutoSize = False
		Me._LabSend_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabSend_2.Name = "_LabSend_2"
		Me._Label24_2.Text = "Packet No."
		Me._Label24_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label24_2.Size = New System.Drawing.Size(57, 17)
		Me._Label24_2.Location = New System.Drawing.Point(448, 240)
		Me._Label24_2.TabIndex = 112
		Me._Label24_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label24_2.BackColor = System.Drawing.SystemColors.Control
		Me._Label24_2.Enabled = True
		Me._Label24_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label24_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label24_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label24_2.UseMnemonic = True
		Me._Label24_2.Visible = True
		Me._Label24_2.AutoSize = False
		Me._Label24_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label24_2.Name = "_Label24_2"
		Me._LabLoss_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoss_2.Size = New System.Drawing.Size(41, 25)
		Me._LabLoss_2.Location = New System.Drawing.Point(392, 352)
		Me._LabLoss_2.TabIndex = 111
		Me._LabLoss_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoss_2.BackColor = System.Drawing.Color.Transparent
		Me._LabLoss_2.Enabled = True
		Me._LabLoss_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoss_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoss_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoss_2.UseMnemonic = True
		Me._LabLoss_2.Visible = True
		Me._LabLoss_2.AutoSize = False
		Me._LabLoss_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabLoss_2.Name = "_LabLoss_2"
		Me._Label22_2.Text = "bytes/sec"
		Me._Label22_2.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label22_2.Size = New System.Drawing.Size(57, 25)
		Me._Label22_2.Location = New System.Drawing.Point(312, 248)
		Me._Label22_2.TabIndex = 110
		Me._Label22_2.Visible = False
		Me._Label22_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label22_2.BackColor = System.Drawing.SystemColors.Control
		Me._Label22_2.Enabled = True
		Me._Label22_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label22_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label22_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label22_2.UseMnemonic = True
		Me._Label22_2.AutoSize = False
		Me._Label22_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label22_2.Name = "_Label22_2"
		Me._LabRcv_2.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabRcv_2.Size = New System.Drawing.Size(41, 25)
		Me._LabRcv_2.Location = New System.Drawing.Point(392, 320)
		Me._LabRcv_2.TabIndex = 109
		Me._LabRcv_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabRcv_2.BackColor = System.Drawing.Color.Transparent
		Me._LabRcv_2.Enabled = True
		Me._LabRcv_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabRcv_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabRcv_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabRcv_2.UseMnemonic = True
		Me._LabRcv_2.Visible = True
		Me._LabRcv_2.AutoSize = False
		Me._LabRcv_2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabRcv_2.Name = "_LabRcv_2"
		Me._Label20_2.Text = "Rate: (bytes/sec)"
		Me._Label20_2.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label20_2.Size = New System.Drawing.Size(49, 41)
		Me._Label20_2.Location = New System.Drawing.Point(392, 256)
		Me._Label20_2.TabIndex = 108
		Me._Label20_2.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label20_2.BackColor = System.Drawing.SystemColors.Control
		Me._Label20_2.Enabled = True
		Me._Label20_2.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label20_2.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label20_2.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label20_2.UseMnemonic = True
		Me._Label20_2.Visible = True
		Me._Label20_2.AutoSize = False
		Me._Label20_2.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label20_2.Name = "_Label20_2"
		Me.Label19.Text = "SendTotal Bytes :"
		Me.Label19.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label19.Size = New System.Drawing.Size(89, 17)
		Me.Label19.Location = New System.Drawing.Point(8, 256)
		Me.Label19.TabIndex = 85
		Me.Label19.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label19.BackColor = System.Drawing.SystemColors.Control
		Me.Label19.Enabled = True
		Me.Label19.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label19.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label19.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label19.UseMnemonic = True
		Me.Label19.Visible = True
		Me.Label19.AutoSize = False
		Me.Label19.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label19.Name = "Label19"
		Me._LabSend_1.Text = "0"
		Me._LabSend_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabSend_1.Size = New System.Drawing.Size(41, 25)
		Me._LabSend_1.Location = New System.Drawing.Point(184, 520)
		Me._LabSend_1.TabIndex = 80
		Me._LabSend_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabSend_1.BackColor = System.Drawing.Color.Transparent
		Me._LabSend_1.Enabled = True
		Me._LabSend_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabSend_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabSend_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabSend_1.UseMnemonic = True
		Me._LabSend_1.Visible = True
		Me._LabSend_1.AutoSize = False
		Me._LabSend_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabSend_1.Name = "_LabSend_1"
		Me._Label20_1.Text = "Rate: (bytes/sec)"
		Me._Label20_1.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label20_1.Size = New System.Drawing.Size(49, 33)
		Me._Label20_1.Location = New System.Drawing.Point(184, 488)
		Me._Label20_1.TabIndex = 79
		Me._Label20_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label20_1.BackColor = System.Drawing.SystemColors.Control
		Me._Label20_1.Enabled = True
		Me._Label20_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label20_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label20_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label20_1.UseMnemonic = True
		Me._Label20_1.Visible = True
		Me._Label20_1.AutoSize = False
		Me._Label20_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label20_1.Name = "_Label20_1"
		Me._LabRcv_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabRcv_1.Size = New System.Drawing.Size(41, 25)
		Me._LabRcv_1.Location = New System.Drawing.Point(184, 552)
		Me._LabRcv_1.TabIndex = 78
		Me._LabRcv_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabRcv_1.BackColor = System.Drawing.Color.Transparent
		Me._LabRcv_1.Enabled = True
		Me._LabRcv_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabRcv_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabRcv_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabRcv_1.UseMnemonic = True
		Me._LabRcv_1.Visible = True
		Me._LabRcv_1.AutoSize = False
		Me._LabRcv_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabRcv_1.Name = "_LabRcv_1"
		Me._LabLoss_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoss_1.Size = New System.Drawing.Size(41, 25)
		Me._LabLoss_1.Location = New System.Drawing.Point(184, 584)
		Me._LabLoss_1.TabIndex = 76
		Me._LabLoss_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoss_1.BackColor = System.Drawing.Color.Transparent
		Me._LabLoss_1.Enabled = True
		Me._LabLoss_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoss_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoss_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoss_1.UseMnemonic = True
		Me._LabLoss_1.Visible = True
		Me._LabLoss_1.AutoSize = False
		Me._LabLoss_1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabLoss_1.Name = "_LabLoss_1"
		Me._Label24_1.Text = "Packet No."
		Me._Label24_1.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label24_1.Size = New System.Drawing.Size(57, 17)
		Me._Label24_1.Location = New System.Drawing.Point(240, 472)
		Me._Label24_1.TabIndex = 75
		Me._Label24_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label24_1.BackColor = System.Drawing.SystemColors.Control
		Me._Label24_1.Enabled = True
		Me._Label24_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label24_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label24_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label24_1.UseMnemonic = True
		Me._Label24_1.Visible = True
		Me._Label24_1.AutoSize = False
		Me._Label24_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label24_1.Name = "_Label24_1"
		Me._LabLoss_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabLoss_0.Size = New System.Drawing.Size(41, 25)
		Me._LabLoss_0.Location = New System.Drawing.Point(184, 352)
		Me._LabLoss_0.TabIndex = 63
		Me._LabLoss_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabLoss_0.BackColor = System.Drawing.Color.Transparent
		Me._LabLoss_0.Enabled = True
		Me._LabLoss_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabLoss_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabLoss_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabLoss_0.UseMnemonic = True
		Me._LabLoss_0.Visible = True
		Me._LabLoss_0.AutoSize = False
		Me._LabLoss_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabLoss_0.Name = "_LabLoss_0"
		Me._LabRcv_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabRcv_0.Size = New System.Drawing.Size(41, 25)
		Me._LabRcv_0.Location = New System.Drawing.Point(184, 320)
		Me._LabRcv_0.TabIndex = 61
		Me._LabRcv_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabRcv_0.BackColor = System.Drawing.Color.Transparent
		Me._LabRcv_0.Enabled = True
		Me._LabRcv_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabRcv_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabRcv_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabRcv_0.UseMnemonic = True
		Me._LabRcv_0.Visible = True
		Me._LabRcv_0.AutoSize = False
		Me._LabRcv_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabRcv_0.Name = "_LabRcv_0"
		Me._Label20_0.Text = "Rate: (bytes/sec)"
		Me._Label20_0.Font = New System.Drawing.Font("Arial", 6.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label20_0.Size = New System.Drawing.Size(49, 33)
		Me._Label20_0.Location = New System.Drawing.Point(184, 256)
		Me._Label20_0.TabIndex = 60
		Me._Label20_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label20_0.BackColor = System.Drawing.SystemColors.Control
		Me._Label20_0.Enabled = True
		Me._Label20_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label20_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label20_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label20_0.UseMnemonic = True
		Me._Label20_0.Visible = True
		Me._Label20_0.AutoSize = False
		Me._Label20_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label20_0.Name = "_Label20_0"
		Me._LabSend_0.Text = "0"
		Me._LabSend_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._LabSend_0.Size = New System.Drawing.Size(41, 25)
		Me._LabSend_0.Location = New System.Drawing.Point(184, 288)
		Me._LabSend_0.TabIndex = 59
		Me._LabSend_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._LabSend_0.BackColor = System.Drawing.Color.Transparent
		Me._LabSend_0.Enabled = True
		Me._LabSend_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._LabSend_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._LabSend_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._LabSend_0.UseMnemonic = True
		Me._LabSend_0.Visible = True
		Me._LabSend_0.AutoSize = False
		Me._LabSend_0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me._LabSend_0.Name = "_LabSend_0"
		Me.LabRunTime.TextAlign = System.Drawing.ContentAlignment.TopCenter
		Me.LabRunTime.Text = "0 Day 00:00:00"
		Me.LabRunTime.ForeColor = System.Drawing.Color.FromARGB(64, 0, 0)
		Me.LabRunTime.Size = New System.Drawing.Size(129, 25)
		Me.LabRunTime.Location = New System.Drawing.Point(808, 24)
		Me.LabRunTime.TabIndex = 57
		Me.LabRunTime.BackColor = System.Drawing.SystemColors.Control
		Me.LabRunTime.Enabled = True
		Me.LabRunTime.Cursor = System.Windows.Forms.Cursors.Default
		Me.LabRunTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.LabRunTime.UseMnemonic = True
		Me.LabRunTime.Visible = True
		Me.LabRunTime.AutoSize = False
		Me.LabRunTime.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
		Me.LabRunTime.Name = "LabRunTime"
		Me.Label18.Text = "Run Time :"
		Me.Label18.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label18.ForeColor = System.Drawing.Color.FromARGB(255, 128, 0)
		Me.Label18.Size = New System.Drawing.Size(113, 25)
		Me.Label18.Location = New System.Drawing.Point(704, 24)
		Me.Label18.TabIndex = 56
		Me.Label18.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label18.BackColor = System.Drawing.SystemColors.Control
		Me.Label18.Enabled = True
		Me.Label18.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label18.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label18.UseMnemonic = True
		Me.Label18.Visible = True
		Me.Label18.AutoSize = False
		Me.Label18.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label18.Name = "Label18"
		Me.Label17.Text = "Total Loss :"
		Me.Label17.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label17.Size = New System.Drawing.Size(65, 17)
		Me.Label17.Location = New System.Drawing.Point(8, 352)
		Me.Label17.TabIndex = 54
		Me.Label17.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label17.BackColor = System.Drawing.SystemColors.Control
		Me.Label17.Enabled = True
		Me.Label17.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label17.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label17.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label17.UseMnemonic = True
		Me.Label17.Visible = True
		Me.Label17.AutoSize = False
		Me.Label17.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label17.Name = "Label17"
		Me.Label16.Text = "Receive Bytes :"
		Me.Label16.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label16.Size = New System.Drawing.Size(81, 17)
		Me.Label16.Location = New System.Drawing.Point(8, 320)
		Me.Label16.TabIndex = 52
		Me.Label16.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label16.BackColor = System.Drawing.SystemColors.Control
		Me.Label16.Enabled = True
		Me.Label16.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label16.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label16.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label16.UseMnemonic = True
		Me.Label16.Visible = True
		Me.Label16.AutoSize = False
		Me.Label16.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label16.Name = "Label16"
		Me.Label15.Text = "Send Bytes :"
		Me.Label15.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label15.Size = New System.Drawing.Size(73, 17)
		Me.Label15.Location = New System.Drawing.Point(8, 288)
		Me.Label15.TabIndex = 50
		Me.Label15.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label15.BackColor = System.Drawing.SystemColors.Control
		Me.Label15.Enabled = True
		Me.Label15.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label15.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label15.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label15.UseMnemonic = True
		Me.Label15.Visible = True
		Me.Label15.AutoSize = False
		Me.Label15.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label15.Name = "Label15"
		Me.Label13.Text = "Sending Data :"
		Me.Label13.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label13.Size = New System.Drawing.Size(105, 17)
		Me.Label13.Location = New System.Drawing.Point(520, 104)
		Me.Label13.TabIndex = 44
		Me.Label13.Visible = False
		Me.Label13.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label13.BackColor = System.Drawing.SystemColors.Control
		Me.Label13.Enabled = True
		Me.Label13.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label13.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label13.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label13.UseMnemonic = True
		Me.Label13.AutoSize = False
		Me.Label13.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label13.Name = "Label13"
		Me.Label12.Text = "Sending Interval (ms) :"
		Me.Label12.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label12.Size = New System.Drawing.Size(113, 17)
		Me.Label12.Location = New System.Drawing.Point(8, 176)
		Me.Label12.TabIndex = 43
		Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label12.BackColor = System.Drawing.SystemColors.Control
		Me.Label12.Enabled = True
		Me.Label12.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label12.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label12.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label12.UseMnemonic = True
		Me.Label12.Visible = True
		Me.Label12.AutoSize = False
		Me.Label12.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label12.Name = "Label12"
		Me.Label5.Text = "Sending Data Length (bytes) :"
		Me.Label5.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label5.Size = New System.Drawing.Size(153, 17)
		Me.Label5.Location = New System.Drawing.Point(8, 200)
		Me.Label5.TabIndex = 42
		Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label5.BackColor = System.Drawing.SystemColors.Control
		Me.Label5.Enabled = True
		Me.Label5.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label5.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label5.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label5.UseMnemonic = True
		Me.Label5.Visible = True
		Me.Label5.AutoSize = False
		Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label5.Name = "Label5"
		Me.Label8.Text = "Label8"
		Me.Label8.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label8.Size = New System.Drawing.Size(1, 1)
		Me.Label8.Location = New System.Drawing.Point(152, 264)
		Me.Label8.TabIndex = 32
		Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label8.BackColor = System.Drawing.SystemColors.Control
		Me.Label8.Enabled = True
		Me.Label8.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label8.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label8.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label8.UseMnemonic = True
		Me.Label8.Visible = True
		Me.Label8.AutoSize = False
		Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label8.Name = "Label8"
		Me.labTime.Text = "Label5"
		Me.labTime.Font = New System.Drawing.Font("新細明體", 11.25!, System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
		Me.labTime.Size = New System.Drawing.Size(105, 17)
		Me.labTime.Location = New System.Drawing.Point(16, 32)
		Me.labTime.TabIndex = 7
		Me.labTime.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.labTime.BackColor = System.Drawing.SystemColors.Control
		Me.labTime.Enabled = True
		Me.labTime.ForeColor = System.Drawing.SystemColors.ControlText
		Me.labTime.Cursor = System.Windows.Forms.Cursors.Default
		Me.labTime.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.labTime.UseMnemonic = True
		Me.labTime.Visible = True
		Me.labTime.AutoSize = False
		Me.labTime.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.labTime.Name = "labTime"
		Me._Label22_0.Text = "bytes/sec"
		Me._Label22_0.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label22_0.Size = New System.Drawing.Size(57, 25)
		Me._Label22_0.Location = New System.Drawing.Point(232, 352)
		Me._Label22_0.TabIndex = 62
		Me._Label22_0.Visible = False
		Me._Label22_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label22_0.BackColor = System.Drawing.SystemColors.Control
		Me._Label22_0.Enabled = True
		Me._Label22_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label22_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label22_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label22_0.UseMnemonic = True
		Me._Label22_0.AutoSize = False
		Me._Label22_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label22_0.Name = "_Label22_0"
		Me._Label24_0.Text = "Packet No."
		Me._Label24_0.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label24_0.Size = New System.Drawing.Size(57, 17)
		Me._Label24_0.Location = New System.Drawing.Point(240, 240)
		Me._Label24_0.TabIndex = 64
		Me._Label24_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label24_0.BackColor = System.Drawing.SystemColors.Control
		Me._Label24_0.Enabled = True
		Me._Label24_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label24_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label24_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label24_0.UseMnemonic = True
		Me._Label24_0.Visible = True
		Me._Label24_0.AutoSize = False
		Me._Label24_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label24_0.Name = "_Label24_0"
		Me._Label22_1.Text = "bytes/sec"
		Me._Label22_1.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me._Label22_1.Size = New System.Drawing.Size(57, 25)
		Me._Label22_1.Location = New System.Drawing.Point(120, 504)
		Me._Label22_1.TabIndex = 77
		Me._Label22_1.Visible = False
		Me._Label22_1.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label22_1.BackColor = System.Drawing.SystemColors.Control
		Me._Label22_1.Enabled = True
		Me._Label22_1.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label22_1.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label22_1.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label22_1.UseMnemonic = True
		Me._Label22_1.AutoSize = False
		Me._Label22_1.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label22_1.Name = "_Label22_1"
		Me.Label14.Text = "Log To File :"
		Me.Label14.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
		Me.Label14.Size = New System.Drawing.Size(81, 17)
		Me.Label14.Location = New System.Drawing.Point(600, 688)
		Me.Label14.TabIndex = 48
		Me.Label14.Visible = False
		Me.Label14.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label14.BackColor = System.Drawing.SystemColors.Control
		Me.Label14.Enabled = True
		Me.Label14.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label14.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label14.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label14.UseMnemonic = True
		Me.Label14.AutoSize = False
		Me.Label14.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label14.Name = "Label14"
		Me.Label10.Text = "Subnode"
		Me.Label10.Size = New System.Drawing.Size(49, 17)
		Me.Label10.Location = New System.Drawing.Point(888, 640)
		Me.Label10.TabIndex = 34
		Me.Label10.Visible = False
		Me.Label10.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label10.BackColor = System.Drawing.SystemColors.Control
		Me.Label10.Enabled = True
		Me.Label10.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label10.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label10.UseMnemonic = True
		Me.Label10.AutoSize = False
		Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label10.Name = "Label10"
		Me.Label11.Text = "IP :0/1"
		Me.Label11.Size = New System.Drawing.Size(33, 17)
		Me.Label11.Location = New System.Drawing.Point(552, 664)
		Me.Label11.TabIndex = 28
		Me.Label11.Visible = False
		Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label11.BackColor = System.Drawing.SystemColors.Control
		Me.Label11.Enabled = True
		Me.Label11.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label11.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label11.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label11.UseMnemonic = True
		Me.Label11.AutoSize = False
		Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label11.Name = "Label11"
		Me.Label9.Text = "DATA :"
		Me.Label9.Size = New System.Drawing.Size(41, 17)
		Me.Label9.Location = New System.Drawing.Point(592, 640)
		Me.Label9.TabIndex = 27
		Me.Label9.Visible = False
		Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label9.BackColor = System.Drawing.SystemColors.Control
		Me.Label9.Enabled = True
		Me.Label9.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label9.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label9.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label9.UseMnemonic = True
		Me.Label9.AutoSize = False
		Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label9.Name = "Label9"
		Me.Label7.Text = "(CCB[6]\subCmd\subNode+Data)"
		Me.Label7.Size = New System.Drawing.Size(185, 17)
		Me.Label7.Location = New System.Drawing.Point(632, 664)
		Me.Label7.TabIndex = 26
		Me.Label7.Visible = False
		Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label7.BackColor = System.Drawing.SystemColors.Control
		Me.Label7.Enabled = True
		Me.Label7.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label7.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label7.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label7.UseMnemonic = True
		Me.Label7.AutoSize = False
		Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label7.Name = "Label7"
		Me.Label4.Text = "Port"
		Me.Label4.Size = New System.Drawing.Size(25, 17)
		Me.Label4.Location = New System.Drawing.Point(560, 592)
		Me.Label4.TabIndex = 6
		Me.Label4.Visible = False
		Me.Label4.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label4.BackColor = System.Drawing.SystemColors.Control
		Me.Label4.Enabled = True
		Me.Label4.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label4.UseMnemonic = True
		Me.Label4.AutoSize = False
		Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label4.Name = "Label4"
		Me.Label3.Text = "DATA :"
		Me.Label3.Size = New System.Drawing.Size(49, 17)
		Me.Label3.Location = New System.Drawing.Point(888, 632)
		Me.Label3.TabIndex = 5
		Me.Label3.Visible = False
		Me.Label3.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me.Label3.BackColor = System.Drawing.SystemColors.Control
		Me.Label3.Enabled = True
		Me.Label3.ForeColor = System.Drawing.SystemColors.ControlText
		Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
		Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me.Label3.UseMnemonic = True
		Me.Label3.AutoSize = False
		Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me.Label3.Name = "Label3"
		Me._Label2_0.Text = "IP"
		Me._Label2_0.Size = New System.Drawing.Size(17, 17)
		Me._Label2_0.Location = New System.Drawing.Point(544, 592)
		Me._Label2_0.TabIndex = 1
		Me._Label2_0.Visible = False
		Me._Label2_0.TextAlign = System.Drawing.ContentAlignment.TopLeft
		Me._Label2_0.BackColor = System.Drawing.SystemColors.Control
		Me._Label2_0.Enabled = True
		Me._Label2_0.ForeColor = System.Drawing.SystemColors.ControlText
		Me._Label2_0.Cursor = System.Windows.Forms.Cursors.Default
		Me._Label2_0.RightToLeft = System.Windows.Forms.RightToLeft.No
		Me._Label2_0.UseMnemonic = True
		Me._Label2_0.AutoSize = False
		Me._Label2_0.BorderStyle = System.Windows.Forms.BorderStyle.None
		Me._Label2_0.Name = "_Label2_0"
		Me.Controls.Add(chk_stopsend)
		Me.Controls.Add(chk_pingpong)
		Me.Controls.Add(txtMappingModel)
		Me.Controls.Add(TxtSendDataLentoall)
		Me.Controls.Add(TxtSendIntvaltoall)
		Me.Controls.Add(cmdComtesttotal)
		Me.Controls.Add(cmdContotal)
		Me.Controls.Add(_CmdClrCnt_7)
		Me.Controls.Add(_CmdClrCnt_6)
		Me.Controls.Add(_CmdClrCnt_5)
		Me.Controls.Add(_CmdClrCnt_4)
		Me.Controls.Add(_TxtRcvPket_7)
		Me.Controls.Add(_TxtSendPket_7)
		Me.Controls.Add(_TxtSendPketTal_7)
		Me.Controls.Add(_TxtCntSendTal_7)
		Me.Controls.Add(_TxtCntSend_7)
		Me.Controls.Add(_TxtCntRcv_7)
		Me.Controls.Add(_TxtCntLoss_7)
		Me.Controls.Add(_CmdSendBeg_7)
		Me.Controls.Add(_TxtSendDataLen_7)
		Me.Controls.Add(_TxtSendIntval_7)
		Me.Controls.Add(_TxtSendData_7)
		Me.Controls.Add(_TxtRcvPket_6)
		Me.Controls.Add(_TxtSendPket_6)
		Me.Controls.Add(_TxtSendPketTal_6)
		Me.Controls.Add(_TxtCntSendTal_6)
		Me.Controls.Add(_TxtCntSend_6)
		Me.Controls.Add(_TxtCntRcv_6)
		Me.Controls.Add(_TxtCntLoss_6)
		Me.Controls.Add(_CmdSendBeg_6)
		Me.Controls.Add(_TxtSendDataLen_6)
		Me.Controls.Add(_TxtSendIntval_6)
		Me.Controls.Add(_TxtSendData_6)
		Me.Controls.Add(_TxtRcvPket_5)
		Me.Controls.Add(_TxtSendPket_5)
		Me.Controls.Add(_TxtSendPketTal_5)
		Me.Controls.Add(_TxtCntSendTal_5)
		Me.Controls.Add(_TxtCntSend_5)
		Me.Controls.Add(_TxtCntRcv_5)
		Me.Controls.Add(_TxtCntLoss_5)
		Me.Controls.Add(_CmdSendBeg_5)
		Me.Controls.Add(_TxtSendDataLen_5)
		Me.Controls.Add(_TxtSendIntval_5)
		Me.Controls.Add(_TxtSendData_5)
		Me.Controls.Add(_TxtRcvPket_4)
		Me.Controls.Add(_TxtSendPket_4)
		Me.Controls.Add(_TxtSendPketTal_4)
		Me.Controls.Add(_TxtCntSendTal_4)
		Me.Controls.Add(_TxtCntSend_4)
		Me.Controls.Add(_TxtCntRcv_4)
		Me.Controls.Add(_TxtCntLoss_4)
		Me.Controls.Add(_CmdSendBeg_4)
		Me.Controls.Add(_TxtSendDataLen_4)
		Me.Controls.Add(_TxtSendIntval_4)
		Me.Controls.Add(_TxtSendData_4)
		Me.Controls.Add(_TxtRcvPket_3)
		Me.Controls.Add(_TxtSendPket_3)
		Me.Controls.Add(_TxtSendPketTal_3)
		Me.Controls.Add(_TxtCntSendTal_3)
		Me.Controls.Add(_TxtCntSend_3)
		Me.Controls.Add(_TxtCntRcv_3)
		Me.Controls.Add(_TxtCntLoss_3)
		Me.Controls.Add(_CmdSendBeg_3)
		Me.Controls.Add(_TxtSendDataLen_3)
		Me.Controls.Add(_TxtSendIntval_3)
		Me.Controls.Add(_TxtSendData_3)
		Me.Controls.Add(_CmdClrCnt_3)
		Me.Controls.Add(_TxtSendData_2)
		Me.Controls.Add(_CmdClrCnt_2)
		Me.Controls.Add(_TxtSendIntval_2)
		Me.Controls.Add(_TxtSendDataLen_2)
		Me.Controls.Add(_CmdSendBeg_2)
		Me.Controls.Add(_TxtCntLoss_2)
		Me.Controls.Add(_TxtCntRcv_2)
		Me.Controls.Add(_TxtCntSend_2)
		Me.Controls.Add(_TxtCntSendTal_2)
		Me.Controls.Add(_TxtSendPketTal_2)
		Me.Controls.Add(_TxtSendPket_2)
		Me.Controls.Add(_TxtRcvPket_2)
		Me.Controls.Add(_TxtRcvPket_1)
		Me.Controls.Add(_TxtSendPket_1)
		Me.Controls.Add(_TxtSendPketTal_1)
		Me.Controls.Add(_TxtRcvPket_0)
		Me.Controls.Add(_TxtSendPket_0)
		Me.Controls.Add(_TxtSendPketTal_0)
		Me.Controls.Add(_TxtCntSendTal_0)
		Me.Controls.Add(_TxtCntSendTal_1)
		Me.Controls.Add(_CmdClrCnt_1)
		Me.Controls.Add(_TxtCntSend_1)
		Me.Controls.Add(_TxtCntRcv_1)
		Me.Controls.Add(_TxtCntLoss_1)
		Me.Controls.Add(_CmdSendBeg_1)
		Me.Controls.Add(_TxtSendDataLen_1)
		Me.Controls.Add(_TxtSendIntval_1)
		Me.Controls.Add(_TxtCntLoss_0)
		Me.Controls.Add(_TxtCntRcv_0)
		Me.Controls.Add(_TxtCntSend_0)
		Me.Controls.Add(_CmdSendBeg_0)
		Me.Controls.Add(_TxtSendData_0)
		Me.Controls.Add(_TxtSendDataLen_0)
		Me.Controls.Add(_TxtSendIntval_0)
		Me.Controls.Add(cmdClrList)
		Me.Controls.Add(Frame1)
		Me.Controls.Add(_OptTcpUdp_1)
		Me.Controls.Add(_OptTcpUdp_0)
		Me.Controls.Add(List1)
		Me.Controls.Add(_CmdClrCnt_0)
		Me.Controls.Add(_TxtSendData_1)
		Me.Controls.Add(_OptTestMode_0)
		Me.Controls.Add(_OptTestMode_1)
		Me.Controls.Add(ChkXOnOff)
		Me.Controls.Add(ChkRecdAck)
		Me.Controls.Add(Command1)
		Me.Controls.Add(CmdBrow)
		Me.Controls.Add(TxtLogFile)
		Me.Controls.Add(ChkRemote)
		Me.Controls.Add(txtData)
		Me.Controls.Add(cmdSend)
		Me.Controls.Add(txtDaport)
		Me.Controls.Add(txtListCnt)
		Me.Controls.Add(txtId2)
		Me.Controls.Add(cmdSend2)
		Me.Controls.Add(txtData2)
		Me.Controls.Add(txtMsg)
		Me.Controls.Add(TxtID)
		Me.Controls.Add(TxtSubNode)
		Me.Controls.Add(CmdSaveList)
		Me.Controls.Add(Label32)
		Me.Controls.Add(Label33)
		Me.Controls.Add(_Label20_7)
		Me.Controls.Add(_LabRcv_7)
		Me.Controls.Add(_LabLoss_7)
		Me.Controls.Add(_Label24_7)
		Me.Controls.Add(_LabSend_7)
		Me.Controls.Add(_Label20_6)
		Me.Controls.Add(_LabRcv_6)
		Me.Controls.Add(_LabLoss_6)
		Me.Controls.Add(_Label24_6)
		Me.Controls.Add(_LabSend_6)
		Me.Controls.Add(_Label20_5)
		Me.Controls.Add(_LabRcv_5)
		Me.Controls.Add(_LabLoss_5)
		Me.Controls.Add(_Label24_5)
		Me.Controls.Add(_LabSend_5)
		Me.Controls.Add(_Label20_4)
		Me.Controls.Add(_LabRcv_4)
		Me.Controls.Add(_LabLoss_4)
		Me.Controls.Add(_Label24_4)
		Me.Controls.Add(_LabSend_4)
		Me.Controls.Add(_Label20_3)
		Me.Controls.Add(_LabRcv_3)
		Me.Controls.Add(_LabLoss_3)
		Me.Controls.Add(_Label24_3)
		Me.Controls.Add(_LabSend_3)
		Me.Controls.Add(Label29)
		Me.Controls.Add(Label28)
		Me.Controls.Add(Label27)
		Me.Controls.Add(Label26)
		Me.Controls.Add(Label25)
		Me.Controls.Add(Label23)
		Me.Controls.Add(_LabSend_2)
		Me.Controls.Add(_Label24_2)
		Me.Controls.Add(_LabLoss_2)
		Me.Controls.Add(_Label22_2)
		Me.Controls.Add(_LabRcv_2)
		Me.Controls.Add(_Label20_2)
		Me.Controls.Add(Label19)
		Me.Controls.Add(_LabSend_1)
		Me.Controls.Add(_Label20_1)
		Me.Controls.Add(_LabRcv_1)
		Me.Controls.Add(_LabLoss_1)
		Me.Controls.Add(_Label24_1)
		Me.Controls.Add(_LabLoss_0)
		Me.Controls.Add(_LabRcv_0)
		Me.Controls.Add(_Label20_0)
		Me.Controls.Add(_LabSend_0)
		Me.Controls.Add(LabRunTime)
		Me.Controls.Add(Label18)
		Me.Controls.Add(Label17)
		Me.Controls.Add(Label16)
		Me.Controls.Add(Label15)
		Me.Controls.Add(Label13)
		Me.Controls.Add(Label12)
		Me.Controls.Add(Label5)
		Me.Controls.Add(Label8)
		Me.Controls.Add(labTime)
		Me.Controls.Add(_Label22_0)
		Me.Controls.Add(_Label24_0)
		Me.Controls.Add(_Label22_1)
		Me.Controls.Add(Label14)
		Me.Controls.Add(Label10)
		Me.Controls.Add(Label11)
		Me.Controls.Add(Label9)
		Me.Controls.Add(Label7)
		Me.Controls.Add(Label4)
		Me.Controls.Add(Label3)
		Me.Controls.Add(_Label2_0)
		Me.Frame1.Controls.Add(_txtip_2)
		Me.Frame1.Controls.Add(_txtip_3)
		Me.Frame1.Controls.Add(_txtip_4)
		Me.Frame1.Controls.Add(_txtip_5)
		Me.Frame1.Controls.Add(_txtip_6)
		Me.Frame1.Controls.Add(_txtip_7)
		Me.Frame1.Controls.Add(txtStatus67)
		Me.Frame1.Controls.Add(_cmdCnect_7)
		Me.Frame1.Controls.Add(_txtLocalPort_7)
		Me.Frame1.Controls.Add(_txtPort_7)
		Me.Frame1.Controls.Add(_cmdCnect_6)
		Me.Frame1.Controls.Add(_txtLocalPort_6)
		Me.Frame1.Controls.Add(_txtPort_6)
		Me.Frame1.Controls.Add(_cmdCnect_5)
		Me.Frame1.Controls.Add(_txtPort_5)
		Me.Frame1.Controls.Add(txtStatus45)
		Me.Frame1.Controls.Add(_cmdCnect_4)
		Me.Frame1.Controls.Add(_txtLocalPort_4)
		Me.Frame1.Controls.Add(_txtPort_4)
		Me.Frame1.Controls.Add(_cmdCnect_3)
		Me.Frame1.Controls.Add(_txtPort_3)
		Me.Frame1.Controls.Add(_Winsock1_3)
		Me.Frame1.Controls.Add(_Winsock1_2)
		Me.Frame1.Controls.Add(_Winsock1_0)
		Me.Frame1.Controls.Add(_Winsock1_1)
		Me.Frame1.Controls.Add(txtStatus23)
		Me.Frame1.Controls.Add(_txtPort_2)
		Me.Frame1.Controls.Add(_txtLocalPort_2)
		Me.Frame1.Controls.Add(_cmdCnect_2)
		Me.Frame1.Controls.Add(txtStatus)
		Me.Frame1.Controls.Add(_cmdCnect_0)
		Me.Frame1.Controls.Add(_cmdCnect_1)
		Me.Frame1.Controls.Add(_txtip_0)
		Me.Frame1.Controls.Add(_txtip_1)
		Me.Frame1.Controls.Add(_txtLocalPort_0)
		Me.Frame1.Controls.Add(_txtLocalPort_1)
		Me.Frame1.Controls.Add(_txtPort_0)
		Me.Frame1.Controls.Add(_txtPort_1)
		Me.Frame1.Controls.Add(cmdListen)
		Me.Frame1.Controls.Add(_txtLocalPort_3)
		Me.Frame1.Controls.Add(_txtLocalPort_5)
		Me.Frame1.Controls.Add(_Winsock1_4)
		Me.Frame1.Controls.Add(_Winsock1_5)
		Me.Frame1.Controls.Add(_Winsock1_6)
		Me.Frame1.Controls.Add(_Winsock1_7)
		Me.Frame1.Controls.Add(Label31)
		Me.Frame1.Controls.Add(Label30)
		Me.Frame1.Controls.Add(Label21)
		Me.Frame1.Controls.Add(_LabLoop_2)
		Me.Frame1.Controls.Add(_LabLoop_1)
		Me.Frame1.Controls.Add(_LabLoop_0)
		Me.Frame1.Controls.Add(_Label1_0)
		Me.Frame1.Controls.Add(_Label1_1)
		Me.Frame1.Controls.Add(Label6)
		Me.CmdClrCnt.SetIndex(_CmdClrCnt_7, CType(7, Short))
		Me.CmdClrCnt.SetIndex(_CmdClrCnt_6, CType(6, Short))
		Me.CmdClrCnt.SetIndex(_CmdClrCnt_5, CType(5, Short))
		Me.CmdClrCnt.SetIndex(_CmdClrCnt_4, CType(4, Short))
		Me.CmdClrCnt.SetIndex(_CmdClrCnt_3, CType(3, Short))
		Me.CmdClrCnt.SetIndex(_CmdClrCnt_2, CType(2, Short))
		Me.CmdClrCnt.SetIndex(_CmdClrCnt_1, CType(1, Short))
		Me.CmdClrCnt.SetIndex(_CmdClrCnt_0, CType(0, Short))
		Me.CmdSendBeg.SetIndex(_CmdSendBeg_7, CType(7, Short))
		Me.CmdSendBeg.SetIndex(_CmdSendBeg_6, CType(6, Short))
		Me.CmdSendBeg.SetIndex(_CmdSendBeg_5, CType(5, Short))
		Me.CmdSendBeg.SetIndex(_CmdSendBeg_4, CType(4, Short))
		Me.CmdSendBeg.SetIndex(_CmdSendBeg_3, CType(3, Short))
		Me.CmdSendBeg.SetIndex(_CmdSendBeg_2, CType(2, Short))
		Me.CmdSendBeg.SetIndex(_CmdSendBeg_1, CType(1, Short))
		Me.CmdSendBeg.SetIndex(_CmdSendBeg_0, CType(0, Short))
		Me.LabLoop.SetIndex(_LabLoop_2, CType(2, Short))
		Me.LabLoop.SetIndex(_LabLoop_1, CType(1, Short))
		Me.LabLoop.SetIndex(_LabLoop_0, CType(0, Short))
		Me.LabLoss.SetIndex(_LabLoss_7, CType(7, Short))
		Me.LabLoss.SetIndex(_LabLoss_6, CType(6, Short))
		Me.LabLoss.SetIndex(_LabLoss_5, CType(5, Short))
		Me.LabLoss.SetIndex(_LabLoss_4, CType(4, Short))
		Me.LabLoss.SetIndex(_LabLoss_3, CType(3, Short))
		Me.LabLoss.SetIndex(_LabLoss_2, CType(2, Short))
		Me.LabLoss.SetIndex(_LabLoss_1, CType(1, Short))
		Me.LabLoss.SetIndex(_LabLoss_0, CType(0, Short))
		Me.LabRcv.SetIndex(_LabRcv_7, CType(7, Short))
		Me.LabRcv.SetIndex(_LabRcv_6, CType(6, Short))
		Me.LabRcv.SetIndex(_LabRcv_5, CType(5, Short))
		Me.LabRcv.SetIndex(_LabRcv_4, CType(4, Short))
		Me.LabRcv.SetIndex(_LabRcv_3, CType(3, Short))
		Me.LabRcv.SetIndex(_LabRcv_2, CType(2, Short))
		Me.LabRcv.SetIndex(_LabRcv_1, CType(1, Short))
		Me.LabRcv.SetIndex(_LabRcv_0, CType(0, Short))
		Me.LabSend.SetIndex(_LabSend_7, CType(7, Short))
		Me.LabSend.SetIndex(_LabSend_6, CType(6, Short))
		Me.LabSend.SetIndex(_LabSend_5, CType(5, Short))
		Me.LabSend.SetIndex(_LabSend_4, CType(4, Short))
		Me.LabSend.SetIndex(_LabSend_3, CType(3, Short))
		Me.LabSend.SetIndex(_LabSend_2, CType(2, Short))
		Me.LabSend.SetIndex(_LabSend_1, CType(1, Short))
		Me.LabSend.SetIndex(_LabSend_0, CType(0, Short))
		Me.Label1.SetIndex(_Label1_0, CType(0, Short))
		Me.Label1.SetIndex(_Label1_1, CType(1, Short))
		Me.Label2.SetIndex(_Label2_0, CType(0, Short))
		Me.Label20.SetIndex(_Label20_7, CType(7, Short))
		Me.Label20.SetIndex(_Label20_6, CType(6, Short))
		Me.Label20.SetIndex(_Label20_5, CType(5, Short))
		Me.Label20.SetIndex(_Label20_4, CType(4, Short))
		Me.Label20.SetIndex(_Label20_3, CType(3, Short))
		Me.Label20.SetIndex(_Label20_2, CType(2, Short))
		Me.Label20.SetIndex(_Label20_1, CType(1, Short))
		Me.Label20.SetIndex(_Label20_0, CType(0, Short))
		Me.Label22.SetIndex(_Label22_2, CType(2, Short))
		Me.Label22.SetIndex(_Label22_0, CType(0, Short))
		Me.Label22.SetIndex(_Label22_1, CType(1, Short))
		Me.Label24.SetIndex(_Label24_7, CType(7, Short))
		Me.Label24.SetIndex(_Label24_6, CType(6, Short))
		Me.Label24.SetIndex(_Label24_5, CType(5, Short))
		Me.Label24.SetIndex(_Label24_4, CType(4, Short))
		Me.Label24.SetIndex(_Label24_3, CType(3, Short))
		Me.Label24.SetIndex(_Label24_2, CType(2, Short))
		Me.Label24.SetIndex(_Label24_1, CType(1, Short))
		Me.Label24.SetIndex(_Label24_0, CType(0, Short))
		Me.OptTcpUdp.SetIndex(_OptTcpUdp_1, CType(1, Short))
		Me.OptTcpUdp.SetIndex(_OptTcpUdp_0, CType(0, Short))
		Me.OptTestMode.SetIndex(_OptTestMode_0, CType(0, Short))
		Me.OptTestMode.SetIndex(_OptTestMode_1, CType(1, Short))
		Me.TmrSend.SetIndex(_TmrSend_7, CType(7, Short))
		Me.TmrSend.SetIndex(_TmrSend_6, CType(6, Short))
		Me.TmrSend.SetIndex(_TmrSend_5, CType(5, Short))
		Me.TmrSend.SetIndex(_TmrSend_4, CType(4, Short))
		Me.TmrSend.SetIndex(_TmrSend_3, CType(3, Short))
		Me.TmrSend.SetIndex(_TmrSend_2, CType(2, Short))
		Me.TmrSend.SetIndex(_TmrSend_1, CType(1, Short))
		Me.TmrSend.SetIndex(_TmrSend_0, CType(0, Short))
		Me.TxtCntLoss.SetIndex(_TxtCntLoss_7, CType(7, Short))
		Me.TxtCntLoss.SetIndex(_TxtCntLoss_6, CType(6, Short))
		Me.TxtCntLoss.SetIndex(_TxtCntLoss_5, CType(5, Short))
		Me.TxtCntLoss.SetIndex(_TxtCntLoss_4, CType(4, Short))
		Me.TxtCntLoss.SetIndex(_TxtCntLoss_3, CType(3, Short))
		Me.TxtCntLoss.SetIndex(_TxtCntLoss_2, CType(2, Short))
		Me.TxtCntLoss.SetIndex(_TxtCntLoss_1, CType(1, Short))
		Me.TxtCntLoss.SetIndex(_TxtCntLoss_0, CType(0, Short))
		Me.TxtCntRcv.SetIndex(_TxtCntRcv_7, CType(7, Short))
		Me.TxtCntRcv.SetIndex(_TxtCntRcv_6, CType(6, Short))
		Me.TxtCntRcv.SetIndex(_TxtCntRcv_5, CType(5, Short))
		Me.TxtCntRcv.SetIndex(_TxtCntRcv_4, CType(4, Short))
		Me.TxtCntRcv.SetIndex(_TxtCntRcv_3, CType(3, Short))
		Me.TxtCntRcv.SetIndex(_TxtCntRcv_2, CType(2, Short))
		Me.TxtCntRcv.SetIndex(_TxtCntRcv_1, CType(1, Short))
		Me.TxtCntRcv.SetIndex(_TxtCntRcv_0, CType(0, Short))
		Me.TxtCntSend.SetIndex(_TxtCntSend_7, CType(7, Short))
		Me.TxtCntSend.SetIndex(_TxtCntSend_6, CType(6, Short))
		Me.TxtCntSend.SetIndex(_TxtCntSend_5, CType(5, Short))
		Me.TxtCntSend.SetIndex(_TxtCntSend_4, CType(4, Short))
		Me.TxtCntSend.SetIndex(_TxtCntSend_3, CType(3, Short))
		Me.TxtCntSend.SetIndex(_TxtCntSend_2, CType(2, Short))
		Me.TxtCntSend.SetIndex(_TxtCntSend_1, CType(1, Short))
		Me.TxtCntSend.SetIndex(_TxtCntSend_0, CType(0, Short))
		Me.TxtCntSendTal.SetIndex(_TxtCntSendTal_7, CType(7, Short))
		Me.TxtCntSendTal.SetIndex(_TxtCntSendTal_6, CType(6, Short))
		Me.TxtCntSendTal.SetIndex(_TxtCntSendTal_5, CType(5, Short))
		Me.TxtCntSendTal.SetIndex(_TxtCntSendTal_4, CType(4, Short))
		Me.TxtCntSendTal.SetIndex(_TxtCntSendTal_3, CType(3, Short))
		Me.TxtCntSendTal.SetIndex(_TxtCntSendTal_2, CType(2, Short))
		Me.TxtCntSendTal.SetIndex(_TxtCntSendTal_0, CType(0, Short))
		Me.TxtCntSendTal.SetIndex(_TxtCntSendTal_1, CType(1, Short))
		Me.TxtRcvPket.SetIndex(_TxtRcvPket_7, CType(7, Short))
		Me.TxtRcvPket.SetIndex(_TxtRcvPket_6, CType(6, Short))
		Me.TxtRcvPket.SetIndex(_TxtRcvPket_5, CType(5, Short))
		Me.TxtRcvPket.SetIndex(_TxtRcvPket_4, CType(4, Short))
		Me.TxtRcvPket.SetIndex(_TxtRcvPket_3, CType(3, Short))
		Me.TxtRcvPket.SetIndex(_TxtRcvPket_2, CType(2, Short))
		Me.TxtRcvPket.SetIndex(_TxtRcvPket_1, CType(1, Short))
		Me.TxtRcvPket.SetIndex(_TxtRcvPket_0, CType(0, Short))
		Me.TxtSendData.SetIndex(_TxtSendData_7, CType(7, Short))
		Me.TxtSendData.SetIndex(_TxtSendData_6, CType(6, Short))
		Me.TxtSendData.SetIndex(_TxtSendData_5, CType(5, Short))
		Me.TxtSendData.SetIndex(_TxtSendData_4, CType(4, Short))
		Me.TxtSendData.SetIndex(_TxtSendData_3, CType(3, Short))
		Me.TxtSendData.SetIndex(_TxtSendData_2, CType(2, Short))
		Me.TxtSendData.SetIndex(_TxtSendData_0, CType(0, Short))
		Me.TxtSendData.SetIndex(_TxtSendData_1, CType(1, Short))
		Me.TxtSendDataLen.SetIndex(_TxtSendDataLen_7, CType(7, Short))
		Me.TxtSendDataLen.SetIndex(_TxtSendDataLen_6, CType(6, Short))
		Me.TxtSendDataLen.SetIndex(_TxtSendDataLen_5, CType(5, Short))
		Me.TxtSendDataLen.SetIndex(_TxtSendDataLen_4, CType(4, Short))
		Me.TxtSendDataLen.SetIndex(_TxtSendDataLen_3, CType(3, Short))
		Me.TxtSendDataLen.SetIndex(_TxtSendDataLen_2, CType(2, Short))
		Me.TxtSendDataLen.SetIndex(_TxtSendDataLen_1, CType(1, Short))
		Me.TxtSendDataLen.SetIndex(_TxtSendDataLen_0, CType(0, Short))
		Me.TxtSendIntval.SetIndex(_TxtSendIntval_7, CType(7, Short))
		Me.TxtSendIntval.SetIndex(_TxtSendIntval_6, CType(6, Short))
		Me.TxtSendIntval.SetIndex(_TxtSendIntval_5, CType(5, Short))
		Me.TxtSendIntval.SetIndex(_TxtSendIntval_4, CType(4, Short))
		Me.TxtSendIntval.SetIndex(_TxtSendIntval_3, CType(3, Short))
		Me.TxtSendIntval.SetIndex(_TxtSendIntval_2, CType(2, Short))
		Me.TxtSendIntval.SetIndex(_TxtSendIntval_1, CType(1, Short))
		Me.TxtSendIntval.SetIndex(_TxtSendIntval_0, CType(0, Short))
		Me.TxtSendPket.SetIndex(_TxtSendPket_7, CType(7, Short))
		Me.TxtSendPket.SetIndex(_TxtSendPket_6, CType(6, Short))
		Me.TxtSendPket.SetIndex(_TxtSendPket_5, CType(5, Short))
		Me.TxtSendPket.SetIndex(_TxtSendPket_4, CType(4, Short))
		Me.TxtSendPket.SetIndex(_TxtSendPket_3, CType(3, Short))
		Me.TxtSendPket.SetIndex(_TxtSendPket_2, CType(2, Short))
		Me.TxtSendPket.SetIndex(_TxtSendPket_1, CType(1, Short))
		Me.TxtSendPket.SetIndex(_TxtSendPket_0, CType(0, Short))
		Me.TxtSendPketTal.SetIndex(_TxtSendPketTal_7, CType(7, Short))
		Me.TxtSendPketTal.SetIndex(_TxtSendPketTal_6, CType(6, Short))
		Me.TxtSendPketTal.SetIndex(_TxtSendPketTal_5, CType(5, Short))
		Me.TxtSendPketTal.SetIndex(_TxtSendPketTal_4, CType(4, Short))
		Me.TxtSendPketTal.SetIndex(_TxtSendPketTal_3, CType(3, Short))
		Me.TxtSendPketTal.SetIndex(_TxtSendPketTal_2, CType(2, Short))
		Me.TxtSendPketTal.SetIndex(_TxtSendPketTal_1, CType(1, Short))
		Me.TxtSendPketTal.SetIndex(_TxtSendPketTal_0, CType(0, Short))
		Me.Winsock1.SetIndex(_Winsock1_3, CType(3, Short))
		Me.Winsock1.SetIndex(_Winsock1_2, CType(2, Short))
		Me.Winsock1.SetIndex(_Winsock1_0, CType(0, Short))
		Me.Winsock1.SetIndex(_Winsock1_1, CType(1, Short))
		Me.Winsock1.SetIndex(_Winsock1_4, CType(4, Short))
		Me.Winsock1.SetIndex(_Winsock1_5, CType(5, Short))
		Me.Winsock1.SetIndex(_Winsock1_6, CType(6, Short))
		Me.Winsock1.SetIndex(_Winsock1_7, CType(7, Short))
		Me.cmdCnect.SetIndex(_cmdCnect_7, CType(7, Short))
		Me.cmdCnect.SetIndex(_cmdCnect_6, CType(6, Short))
		Me.cmdCnect.SetIndex(_cmdCnect_5, CType(5, Short))
		Me.cmdCnect.SetIndex(_cmdCnect_4, CType(4, Short))
		Me.cmdCnect.SetIndex(_cmdCnect_3, CType(3, Short))
		Me.cmdCnect.SetIndex(_cmdCnect_2, CType(2, Short))
		Me.cmdCnect.SetIndex(_cmdCnect_0, CType(0, Short))
		Me.cmdCnect.SetIndex(_cmdCnect_1, CType(1, Short))
		Me.txtLocalPort.SetIndex(_txtLocalPort_7, CType(7, Short))
		Me.txtLocalPort.SetIndex(_txtLocalPort_6, CType(6, Short))
		Me.txtLocalPort.SetIndex(_txtLocalPort_4, CType(4, Short))
		Me.txtLocalPort.SetIndex(_txtLocalPort_2, CType(2, Short))
		Me.txtLocalPort.SetIndex(_txtLocalPort_0, CType(0, Short))
		Me.txtLocalPort.SetIndex(_txtLocalPort_1, CType(1, Short))
		Me.txtLocalPort.SetIndex(_txtLocalPort_3, CType(3, Short))
		Me.txtLocalPort.SetIndex(_txtLocalPort_5, CType(5, Short))
		Me.txtPort.SetIndex(_txtPort_7, CType(7, Short))
		Me.txtPort.SetIndex(_txtPort_6, CType(6, Short))
		Me.txtPort.SetIndex(_txtPort_5, CType(5, Short))
		Me.txtPort.SetIndex(_txtPort_4, CType(4, Short))
		Me.txtPort.SetIndex(_txtPort_3, CType(3, Short))
		Me.txtPort.SetIndex(_txtPort_2, CType(2, Short))
		Me.txtPort.SetIndex(_txtPort_0, CType(0, Short))
		Me.txtPort.SetIndex(_txtPort_1, CType(1, Short))
		Me.txtip.SetIndex(_txtip_2, CType(2, Short))
		Me.txtip.SetIndex(_txtip_3, CType(3, Short))
		Me.txtip.SetIndex(_txtip_4, CType(4, Short))
		Me.txtip.SetIndex(_txtip_5, CType(5, Short))
		Me.txtip.SetIndex(_txtip_6, CType(6, Short))
		Me.txtip.SetIndex(_txtip_7, CType(7, Short))
		Me.txtip.SetIndex(_txtip_0, CType(0, Short))
		Me.txtip.SetIndex(_txtip_1, CType(1, Short))
		CType(Me.txtip, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtPort, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.txtLocalPort, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.cmdCnect, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Winsock1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtSendPketTal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtSendPket, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtSendIntval, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtSendDataLen, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtSendData, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtRcvPket, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtCntSendTal, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtCntSend, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtCntRcv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TxtCntLoss, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.TmrSend, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OptTestMode, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.OptTcpUdp, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LabSend, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LabRcv, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LabLoss, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.LabLoop, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CmdSendBeg, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me.CmdClrCnt, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Winsock1_7, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Winsock1_6, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Winsock1_5, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Winsock1_4, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Winsock1_1, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Winsock1_0, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Winsock1_2, System.ComponentModel.ISupportInitialize).EndInit()
		CType(Me._Winsock1_3, System.ComponentModel.ISupportInitialize).EndInit()
		MainMenu1.Items.AddRange(New System.Windows.Forms.ToolStripItem(){Me.MnuSet, Me.MnuQuery})
		MnuSet.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.MnuSetComp, Me.MnuAddId, Me.MnuSchedule, Me.MnuGroup, Me.MnuHoliday, Me.MnuSetTime})
		MnuQuery.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem(){Me.MnuQryComp, Me.MnuQryId, Me.MnuNULL1, Me.MnuQryRealT})
		Me.Controls.Add(MainMenu1)
		Me.MainMenu1.ResumeLayout(False)
		Me.Frame1.ResumeLayout(False)
		Me.ResumeLayout(False)
		Me.PerformLayout()
	End Sub
#End Region 
End Class