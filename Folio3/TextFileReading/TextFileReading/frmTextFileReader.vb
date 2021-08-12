Public Class frmTextFileReader

    'Name:         Zach Smith
    'Start:        05 March 2020
    'Last Updated: 13 March 2020
    'Description:  This program locates, reads and then displays a external text file 

    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click

        If txtPath.Text = "" Or txtPath.Text = " " Then         'Validate is something has been entered
            MessageBox.Show("Enter valid txt file", "txt file reader", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If txtPath.Text <> "Mobile.txt" Then                    'validate is the right file is entered
                MessageBox.Show("Enter valid txt file", "txt file reader", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Dim FileName As String = txtPath.Text
                Dim ContactData As ListViewItem                'create contact data variable as type listviewitem
                Dim FileNum As Integer = FreeFile()
                Dim FirstName As String
                Dim LastName As String
                Dim MobileNumber As String
                FileOpen(FileNum, FileName, OpenMode.Input)    'open file

                Do Until EOF(FileNum)        'Reads file and alocates were each line goes till it reaches the end of the txt file
                    FirstName = LineInput(FileNum)
                    LastName = LineInput(FileNum)
                    MobileNumber = LineInput(FileNum)
                    ContactData = New ListViewItem
                    ContactData.Text = FirstName
                    ContactData.SubItems.Add(LastName)
                    Dim a As String = Mid(MobileNumber, 1, 4)
                    Dim b As String = Mid(MobileNumber, 5, 7)
                    Dim g As String = Mid(b, 1, 3)
                    Dim c As String = Mid(MobileNumber, 8, 10)
                    ContactData.SubItems.Add(Format(MobileNumber, a & " " & g & " " & c))
                    lvwContacts.Items.Add(ContactData)
                Loop

                FileClose(FileNum)                             'closes file when loop is finshed
                btnRead.Enabled = False

            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtPath.Clear()             'clears path to file and refreshes the list view
        txtPath.Focus()
        btnRead.Enabled = True
        lvwContacts.Items.Clear()

    End Sub

End Class
