Public Class frmLogin

    'Name:         Zach Smith
    'Start:        12 June 2020
    'Last Updated: 12 June 2020
    'Description:  This form will read the id and password inputed in the text boxes and take the user to the next screen 
    '              depending if its right or wrong. If a Staff logs in they will be taken to a differnt screen to a admin

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'dicide weather the user gos to admin or not. if Admin and Admin0123 are used then the user will go to admin
        If txtID.Text = "Admin" And txtPassword.Text = "Admin0123" Then
            Dim Admin As New frmAdmin
            Admin.Show()
            Admin = Nothing
            Me.Hide()
        Else
            'proper staff login not complete due to time constraints
            Dim Staff As New frmStaff
            Staff.Show()
            Staff = Nothing
            Me.Hide()

        End If

    End Sub





    'Below are attempts of recording who logs in as a staff member. using arrays and listviews


    '1#

    'Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
    '
    'Dim FileName As String = "ChildCareDataBase.txt"
    'Dim ContactData As ListViewItem                'create contact data variable as type listviewitem
    'Dim FileNum As Integer = FreeFile()
    'Dim LastName As String
    'Dim FirstName As String
    'Dim ID As String
    'Dim Pass As String
    'Dim TIMon, TOMon, TITues, TOTues, TIWed, TOWed, TIThur, TOThur, TIFri, TOFri As String
    'Dim TITOMon, TITOTues, TITOWed, TITOThur, TITOFri, TITOWeek As Integer
    '
    'FileOpen(FileNum, FileName, OpenMode.Input)    'open file

    'Do  Until EOF(FileNum)        'Reads file and alocates were each line goes till it reaches the end of the txt file
    ' LastName = LineInput(FileNum)
    'FirstName = LineInput(FileNum)
    'ID = LineInput(FileNum)
    'Pass = LineInput(FileNum)
    'TIMon = LineInput(FileNum)
    'TOMon = LineInput(FileNum)
    'TITues = LineInput(FileNum)
    'TOTues = LineInput(FileNum)
    'TIWed = LineInput(FileNum)
    'TOWed = LineInput(FileNum)
    'TIThur = LineInput(FileNum)
    'TOThur = LineInput(FileNum)
    'TIFri = LineInput(FileNum)
    '        TOFri = LineInput(FileNum)
    '       TITOFri = Int(TOFri) - Int(TIFri)
    '      TITOWeek = Int(TITOMon) + Int(TITOTues) + Int(TITOWed) + Int(TITOThur) + Int(TITOFri)

    'ContactData = New ListViewItem
    '
    'ContactData.Text = ID
    'ContactData.SubItems.Add(Pass)
    '
    'lvwStaffLogin.Items.Add(ContactData)
    'Loop
    'FileClose(FileNum)

    'End Sub


    '2#

    'Dim FileName As String = "ChildCareDataBase.txt"
    'Dim ContactData As ListViewItem                'create contact data variable as type listviewitem
    'Dim FileNum As Integer = FreeFile()
    'Dim LastName As String
    'Dim FirstName As String
    'Dim ID As String
    'Dim Pass As String
    'Dim TIMon, TOMon, TITues, TOTues, TIWed, TOWed, TIThur, TOThur, TIFri, TOFri As String
    'Dim TITOMon, TITOTues, TITOWed, TITOThur, TITOFri, TITOWeek As Integer
    '
    'Do Until EOF(FileNum)        'Reads file and alocates were each line goes till it reaches the end of the txt file
    'LastName = LineInput(FileNum)
    'FirstName = LineInput(FileNum)
    'ID = LineInput(FileNum)
    'Pass = LineInput(FileNum)
    'TIMon = LineInput(FileNum)
    'TITues = LineInput(FileNum)
    'TOTues = LineInput(FileNum)
    'TIWed = LineInput(FileNum)
    'TOWed = LineInput(FileNum)
    'TIThur = LineInput(FileNum)
    'TOThur = LineInput(FileNum)
    'TIFri = LineInput(FileNum)
    'TOFri = LineInput(FileNum)
    'TITOFri = Int(TOFri) - Int(TIFri)
    'TITOWeek = Int(TITOMon) + Int(TITOTues) + Int(TITOWed) + Int(TITOThur) + Int(TITOFri)
    '
    'ContactData = New ListViewItem
    '
    'ContactData.Text = ID
    'ContactData.SubItems.Add(Pass)
    '
    'lvwStaffLogin.Items.Add(ContactData)
    'Loop
    'FileClose(FileNum)
    '
    'If txtID.Text = colID.Text And txtPassword.Text = colPass.Text Then
    '
    'Dim Staff As New frmStaff
    'Staff.Show()
    'Staff = Nothing
    'Me.Hide()
    '
    'End If


    '3#

    'Dim AccountInfo(419) As String
    'Dim i As Integer = 0
    'FileOpen(1, "ChildCareDataBase.txt", OpenMode.Input)
    'While Not EOF(1)
    'AccountInfo(i) = LineInput(1)
    'i = i + 1
    'End While
    'FileClose(1)
    '
    'Dim NOL14 As String = IO.File.ReadAllLines(ChildCareDataBase.FileName).Length
    'Dim ID As String = 2 + NOL14 / 14
    'Dim Identify(ID - 1) As String
    'Dim j As Integer = 0
    'Dim k As Integer = 0
    'For j = 0 To ID - 1
    'Identify(j) = AccountInfo(j + k)
    'k = k + 14
    'Next

    '  Dim Pass As String = NOL14 / 4









End Class
