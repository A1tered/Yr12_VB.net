Public Class frmAdd

    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim FileName As String = "ChildCareDataBase.txt"
        Dim ContactData As ListViewItem                'create contact data variable as type listviewitem
        Dim FileNum As Integer = FreeFile()
        Dim LastName As String
        Dim FirstName As String
        Dim ID As String
        Dim Pass As String
        Dim TIMon, TOMon, TITues, TOTues, TIWed, TOWed, TIThur, TOThur, TIFri, TOFri As String

        FileOpen(FileNum, FileName, OpenMode.Input)    'open file

        Do Until EOF(FileNum)        'Reads file and alocates were each line goes till it reaches the end of the txt file
            LastName = LineInput(FileNum)
            FirstName = LineInput(FileNum)
            ID = LineInput(FileNum)
            Pass = LineInput(FileNum)
            TIMon = LineInput(FileNum)
            TOMon = LineInput(FileNum)
            TITues = LineInput(FileNum)
            TOTues = LineInput(FileNum)
            TIWed = LineInput(FileNum)
            TOWed = LineInput(FileNum)
            TIThur = LineInput(FileNum)
            TOThur = LineInput(FileNum)
            TIFri = LineInput(FileNum)
            TOFri = LineInput(FileNum)

            ContactData = New ListViewItem
            ContactData.Text = LastName
            ContactData.SubItems.Add(FirstName)
            ContactData.SubItems.Add(ID)
            ContactData.SubItems.Add(Pass)
            ContactData.SubItems.Add(TIMon)
            ContactData.SubItems.Add(TOMon)
            ContactData.SubItems.Add(TITues)
            ContactData.SubItems.Add(TOTues)
            ContactData.SubItems.Add(TIWed)
            ContactData.SubItems.Add(TOWed)
            ContactData.SubItems.Add(TIThur)
            ContactData.SubItems.Add(TOThur)
            ContactData.SubItems.Add(TIFri)
            ContactData.SubItems.Add(TOFri)

            lvwStaffInfo.Items.Add(ContactData)
        Loop
        FileClose(FileNum)

    End Sub

    Dim index As Integer = 0
    Dim index_real As Integer = 48

    Private Sub btnAddCar_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        'reset all 6 textbox Checkers

        Dim FileName As String = "ChildCareDataBase.txt"
        Dim FileNum As Integer = FreeFile()
        Dim Last, First, ID, Pass, TIMon, TOMon, TITues, TOTues, TIWed, TOWed, TIThur, TOThur, TIFri, TOFri As String

        lblLastC.Text = 1
        lblFirstC.Text = 1
        lblIDC.Text = 1
        lblPassC.Text = 1
        lblMC.Text = 1
        lblMoC.Text = 1
        lblTC.Text = 1
        lblTuC.Text = 1
        lblWC.Text = 1
        lblWeC.Text = 1
        lblThC.Text = 1
        lblThuC.Text = 1
        lblFC.Text = 1
        lblFrC.Text = 1

        'disable text boxes and add btn when index = 420
        If index = 420 Then
            btnAdd.Enabled = False
            txtLast.Enabled = False
            txtFirst.Enabled = False
            txtID.Enabled = False
            txtPass.Enabled = False
            txtTIM.Enabled = False
            txtTOM.Enabled = False
            txtTIT.Enabled = False
            txtTOT.Enabled = False
            txtTIW.Enabled = False
            txtTOW.Enabled = False
            txtTITh.Enabled = False
            txtTOTh.Enabled = False
            txtTIF.Enabled = False
            txtTOF.Enabled = False
        End If


        If lblLastC.Text = 1 And lblFirstC.Text = 1 And lblIDC.Text = 1 And lblPassC.Text = 1 And lblMC.Text = 1 And lblMoC.Text = 1 And lblTC.Text And lblTuC.Text And lblWC.Text And lblWeC.Text = 1 And lblThC.Text And lblThuC.Text And lblFC.Text And lblFrC.Text Then
            'increase index number when textfile grows
            index_real += 14
            index = index_real / 14

            Last = txtLast.Text
            First = txtFirst.Text
            ID = txtID.Text
            Pass = txtPass.Text
            TIMon = txtTIM.Text
            TOMon = txtTOM.Text
            TITues = txtTIT.Text
            TOTues = txtTOT.Text
            TIWed = txtTIW.Text
            TOWed = txtTOW.Text
            TIThur = txtTITh.Text
            TOThur = txtTOTh.Text
            TIFri = txtTIF.Text
            TOFri = txtTOF.Text

            'enter the data into the textfile
            FileOpen(FileNum, FileName, OpenMode.Append)
            PrintLine(FileNum, (Last))
            PrintLine(FileNum, (First))
            PrintLine(FileNum, (ID))
            PrintLine(FileNum, (Pass))
            PrintLine(FileNum, (TIMon))
            PrintLine(FileNum, (TOMon))
            PrintLine(FileNum, (TITues))
            PrintLine(FileNum, (TOTues))
            PrintLine(FileNum, (TIWed))
            PrintLine(FileNum, (TOWed))
            PrintLine(FileNum, (TIThur))
            PrintLine(FileNum, (TOThur))
            PrintLine(FileNum, (TIFri))
            PrintLine(FileNum, (TOFri))
            FileClose(FileNum)

            'empty the 6 textboxes to prevent doubles in database
            txtLast.Text = ""
            txtFirst.Text = ""
            txtID.Text = ""
            txtPass.Text = ""
            txtTIM.Text = "0000"
            txtTOM.Text = "0000"
            txtTIT.Text = "0000"
            txtTOT.Text = "0000"
            txtTIW.Text = "0000"
            txtTOW.Text = "0000"
            txtTITh.Text = "0000"
            txtTOTh.Text = "0000"
            txtTIF.Text = "0000"
            txtTOF.Text = "0000"
        End If
    End Sub

    'Back button
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Dim admin As New frmAdmin
        admin.Show()
        admin = Nothing
        Me.Hide()
    End Sub

End Class