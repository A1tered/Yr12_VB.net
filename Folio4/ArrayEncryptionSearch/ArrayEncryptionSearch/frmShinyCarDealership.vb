Public Class frmShinyCarDealership

    'Name:         Zach Smith
    'Start:        20 May 2020
    'Last Updated: 29 May 2020
    'Description:  This program load up a document then searches car models

    'Name        Integer   2    Global   Maximun of 99 cars details
    'Index       Boolean   1    Global   A flag for when the car registration is found
    'Reg         String    6    Global   Car registration
    'Make        String    15   Global   Make of car
    'Model       String    10   Global   Model of car
    'Year_made   Integer   4    Global   Year manufacture of car
    'Odometer    Real      6.1  Global   Kilometers travelled by car
    'Cost        Real      6.2  Global   Cost of car with a maximum of $999,999.00

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        'Check if text input is blank, if yes display error message, else
        If txtPath.Text = "" Or txtPath.Text = " " Then
            MessageBox.Show("Enter the text file name", "ShinyCars", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            'Check if text input is not the correct text file, if yes, display error message, else
            If txtPath.Text <> "ShinyCars.txt" Then
                MessageBox.Show("The only file accepted is 'Shiny Cars.txt'", "ShinyCars", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else

                Dim FileName As String = "ShinyCars.txt"
                Dim CarData As ListViewItem               'Declare CarData variable as type ListViewItem
                Dim FileNum As Integer = FreeFile()
                Dim reg, make, model, year_made, odometer, cost As String     'Declare 6 variables (mobile must be string to work)
                FileOpen(1, FileName, OpenMode.Input)

                Do Until EOF(FileNum)                         'Read until the end of the file

                    reg = Decrypt(LineInput(FileNum))
                    make = Decrypt(LineInput(FileNum))
                    model = Decrypt(LineInput(FileNum))
                    year_made = Decrypt(LineInput(FileNum))
                    odometer = Decrypt(LineInput(FileNum))
                    cost = Decrypt(LineInput(FileNum))
                    CarData = New ListViewItem

                    'Registration is in the first column, Make is in the second column, Model is in the third column, Year is in the fourth column, Odometer is in the fifth column, Cost is in the sixth column
                    CarData.Text = reg
                    CarData.SubItems.Add(make)
                    CarData.SubItems.Add(model)
                    CarData.SubItems.Add(year_made)
                    CarData.SubItems.Add(Format(Val(odometer), "###,###.# km"))
                    CarData.SubItems.Add(Format(Val(cost), "$###,###.##"))
                    lvwCars.Items.Add(CarData)                               'Display the info from the textfile in to the listview

                Loop

                FileClose(FileNum)
                btnLoad.Enabled = False
                txtSearch.Text = ""
                txtSearch.Enabled = True

            End If
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPath.Clear()             'lears path to file and refreshes the list view
        txtPath.Focus()
        btnLoad.Enabled = True
        lvwCars.Items.Clear()
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        'Makes sure to select a full row
        lvwCars.FullRowSelect = True

        'Highlight the registration in the listview corresponding to the text in the textbox
        Dim i, strLength As Integer
        strLength = txtSearch.Text.Length
        lvwCars.SelectedItems.Clear()
        For i = 0 To lvwCars.Items.Count - 1
            If lvwCars.Items(i).Text.ToUpper.StartsWith(txtSearch.Text.ToUpper) Then
                lvwCars.Items(i).Selected = True
                lvwCars.Update()
            End If
        Next

    End Sub

    Function Decrypt(data As String)
        Dim Result = ""
        Dim EncryptionFactor As Integer = 3
        For Each letter As String In data
            Result += Chr(Asc(letter) + EncryptionFactor)
        Next
        Return Result
    End Function

End Class
