Public Class frmAdmin


    'Name:         Zach Smith
    'Start:        12 June 2020
    'Last Updated: 12 June 2020
    'Description:  This form will display the info of Staff and calculate hours done by each staff member for each day

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim FileName As String = "ChildCareDataBase.txt"
        Dim ContactData As ListViewItem                'create contact data variable as type listviewitem
        Dim FileNum As Integer = FreeFile()
        Dim LastName As String
        Dim FirstName As String
        Dim ID As String
        Dim Pass As String
        Dim TIMon, TOMon, TITues, TOTues, TIWed, TOWed, TIThur, TOThur, TIFri, TOFri As String
        Dim TITOMon, TITOTues, TITOWed, TITOThur, TITOFri, TITOWeek As Integer

        FileOpen(FileNum, FileName, OpenMode.Input)    'open file

        Do Until EOF(FileNum)        'Reads file and alocates were each line goes till it reaches the end of the txt file
            LastName = LineInput(FileNum)
            FirstName = LineInput(FileNum)
            ID = LineInput(FileNum)
            Pass = LineInput(FileNum)
            TIMon = LineInput(FileNum)
            TOMon = LineInput(FileNum)
            TITOMon = Int(TOMon) - Int(TIMon)
            TITues = LineInput(FileNum)
            TOTues = LineInput(FileNum)
            TITOTues = Int(TOTues) - Int(TITues)
            TIWed = LineInput(FileNum)
            TOWed = LineInput(FileNum)
            TITOWed = Int(TOWed) - Int(TIWed)
            TIThur = LineInput(FileNum)
            TOThur = LineInput(FileNum)
            TITOThur = Int(TOThur) - Int(TIThur)
            TIFri = LineInput(FileNum)
            TOFri = LineInput(FileNum)
            TITOFri = Int(TOFri) - Int(TIFri)
            TITOWeek = Int(TITOMon) + Int(TITOTues) + Int(TITOWed) + Int(TITOThur) + Int(TITOFri)

            ContactData = New ListViewItem
            ContactData.Text = LastName
            ContactData.SubItems.Add(FirstName)
            ContactData.SubItems.Add(ID)
            ContactData.SubItems.Add(TITOMon)
            ContactData.SubItems.Add(TITOTues)
            ContactData.SubItems.Add(TITOWed)
            ContactData.SubItems.Add(TITOThur)
            ContactData.SubItems.Add(TITOFri)
            ContactData.SubItems.Add(TITOWeek)

            lvwStaffInfo.Items.Add(ContactData)
        Loop
        FileClose(FileNum)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged

        'Makes sure to select a full row
        lvwStaffInfo.FullRowSelect = True

        'Highlight the registration in the listview corresponding to the text in the textbox
        Dim i, strLength As Integer
        strLength = txtSearch.Text.Length
        lvwStaffInfo.SelectedItems.Clear()
        For i = 0 To lvwStaffInfo.Items.Count - 1
            If lvwStaffInfo.Items(i).Text.ToUpper.StartsWith(txtSearch.Text.ToUpper) Then
                lvwStaffInfo.Items(i).Selected = True
                lvwStaffInfo.Update()
            End If
        Next

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim add As New frmAdd
        add.Show()
        add = Nothing
        Me.Hide()
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        Dim Edit As New frmEdit
        Edit.Show()
        Edit = Nothing
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim Login As New frmLogin
        Login.Show()
        Login = Nothing
        Me.Hide()
    End Sub

End Class