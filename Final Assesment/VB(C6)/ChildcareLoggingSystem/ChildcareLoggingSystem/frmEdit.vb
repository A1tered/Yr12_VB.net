Public Class frmEdit
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        'valdation
        Dim result As DialogResult = MessageBox.Show("When using data base make sure not to tamper with the amount of lines present", "Data Base", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If result = DialogResult.No Then
            MessageBox.Show("The textfile was not displayed", "Data Base", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else      'load txtfile
            Dim FileName As String = "ChildCareDataBase.txt"
            Dim FileNum As Integer = FreeFile()
            Dim Tempstring As String = "", Templine As String
            FileOpen(FileNum, FileName, OpenMode.Input)

            Do Until EOF(FileNum)
                Templine = (LineInput(FileNum))
                Tempstring += Templine + vbCrLf
            Loop
            FileClose(FileNum)
            txtTextFile.Text = Tempstring

        End If

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        'validation that the text file is a multiple of 14
        Dim NOL As Integer = txtTextFile.Lines.Count
        If NOL Mod 14 <> 0 Then
            MessageBox.Show("Number of lines is not viable for the amount of fields needed, lines must be a multiple of 14. Remove final blank line if present", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'overwrites the textfile with the text present in the textbox
            Dim filename As String = "ChildCareDataBase.txt"
            Dim filenum As Integer = FreeFile()
            FileOpen(filenum, filename, OpenMode.Output)
            PrintLine(filenum, txtTextFile.Text)
            FileClose(filenum)
            btnEdit.Enabled = False
            btnLoad.Enabled = True
            txtTextFile.Text = txtTextFile.Text.Trim()
            txtTextFile.Clear()    'clears the text box
            MessageBox.Show("Changes Accepted", "Edit Mode", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If

    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Admin As New frmAdmin
        Admin.Show()
        Admin = Nothing
        Me.Hide()
    End Sub

End Class