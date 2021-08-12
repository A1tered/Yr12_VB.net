Public Class frmGrade

    'Name:         Zach Smith
    'Start:        21 Febuary 2020
    'Last Updated: 28 Febuary 2020
    'Description:  This program stores and add the number sailors in the four differnt grades(A, B, C, D). 

    Private Sub frmGrade_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblA.Text = 0
        lblB.Text = 0
        lblC.Text = 0
        lblD.Text = 0
        'Resets all grade labes to 0
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        If Not IsNumeric(txtSailors.Text) Then
            MessageBox.Show("Only Enter Positive Numbers", "Sailor Grade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'Reads if text box is numeric or not
        Else
            If Val(txtSailors.Text) > 999 Or Val(txtSailors.Text) < 0 Then
                MessageBox.Show("Only Enter Positive Numbers", "Sailor Grade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                'Reads if text box is with in the range
            Else
                If txtSailors.Text = " " Then
                    MessageBox.Show("Only Enter Positive Numbers", "Sailor Grade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Reads if nothing has been inputed into the text box
                Else
                    If cmbGrade.Text = "" Then
                        MessageBox.Show("Please select Grade", "Sailor Grade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        'read if a grade has been selected in the combo box
                    Else
                        Select Case cmbGrade.Text
                            Case "A"
                                lblA.Text = Val(lblA.Text) + 1
                            Case "B"
                                lblB.Text = Val(lblB.Text) + 1
                            Case "C"
                                lblC.Text = Val(lblC.Text) + 1
                            Case "D"
                                lblD.Text = Val(lblD.Text) + 1
                                'Reads what has been selcted in the combo box and adds 1 to the corresponding grade
                        End Select
                        If Val(lblA.Text) + Val(lblB.Text) + Val(lblC.Text) + Val(lblD.Text) = Val(txtSailors.Text) Then
                            btnAdd.Enabled = False
                            MessageBox.Show("All sailors added", "Sailor Grade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                            'Read the total of the 4 grades and if the total equals number inputed in text box disable the add button
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblA.Text = 0
        lblB.Text = 0
        lblC.Text = 0
        lblD.Text = 0
        btnAdd.Enabled = True
        '5resest all grade lables to 0 and enables add button
    End Sub

End Class
