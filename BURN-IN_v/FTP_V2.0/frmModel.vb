Option Strict Off
Option Explicit On
Friend Class frmModel
	Inherits System.Windows.Forms.Form
	Private Sub cmdfrmtcp_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles cmdfrmtcp.Click
		If cblModel.Text = "" Then
			MsgBox("Please choose model first !")
			Exit Sub
		Else
		End If
		
		'FrmMain.txtMappingModel.Text = frmModel.cblModel.Text
		
		'''''''''''''''''''''''''''''''''''''''''''''''''''''''''''write model name
		Dim FileNumber As Integer
		Dim fname As String
		
		FileNumber = FreeFile
		
        fname = My.Computer.FileSystem.CurrentDirectory & "\write_model.txt"

        FileOpen(FileNumber, fname, OpenMode.Output)
        PrintLine(FileNumber, cblModel.Text)
        FileClose(FileNumber)
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        '    Dim FileNo
        '    Dim strString As String
        '    FileNo = FreeFile()
        '
        '    Open App.Path & "\write_model.txt" For Input As #FileNo
        '    While Not EOF(FileNo)
        '        Line Input #FileNo, strString
        '        cblModel.Text (cblModel.Text & strString)
        '    Wend
        '    Close #FileNo

        frmtcp.Show()
        Exit Sub
    End Sub

    Private Sub frmModel_Load(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles MyBase.Load
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''Select model name
        Dim FileNo As Object
        Dim strString As String
        'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileNo = FreeFile()

        'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileOpen(FileNo, My.Computer.FileSystem.CurrentDirectory & "\model_CPU5200.txt", OpenMode.Input)
        'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        While Not EOF(FileNo)
            'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            strString = LineInput(FileNo)
            cblModel.Items.Add((cblModel.Text & strString))
        End While
        'UPGRADE_WARNING: 無法解析物件 FileNo 的預設屬性。 按一下以取得詳細資訊: 'ms-help://MS.VSCC.v90/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        FileClose(FileNo)
    End Sub
End Class