Imports System.Char     'need the IsLetter function

Public Class frmSecretMessage
    'Name:         Mr D Hew
    'Start:        19/4/2020
    'Last Updated: 19/4/2020
    'Description:  Programming with Visual Basic 5th Ed "Programming example 9" Pages 101-110 by Graeme Summer

    Dim Shift As Integer = 0                                            'number of chars shifted to left

    Private Sub frmSecretMessage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim I As Integer
        For I = 65 To 90                                                'from A to Z
            lblPlainText.Text += Chr(I)
            lblEncrypted.Text += Chr(I)
        Next
    End Sub

    Private Sub btnShiftLeft_Click(sender As Object, e As EventArgs) Handles btnShiftLeft.Click
        Dim NewText As String = lblEncrypted.Text
        'construct shifted text
        NewText = NewText.Substring(1, 25) + NewText.Substring(0, 1)
        lblEncrypted.Text = NewText                                     'display shifted text
        Shift += 1
        Shift = Shift Mod 26                                            'keep in range 0 to 25
        lblShift.Text = Shift
    End Sub

    Private Sub btnShiftRight_Click(sender As Object, e As EventArgs) Handles btnShiftRight.Click
        Dim NewText As String = lblEncrypted.Text
        'construct shifted text
        NewText = NewText.Substring(25, 1) + NewText.Substring(0, 25)
        lblEncrypted.Text = NewText                                     'display shifted text
        Shift += 25                                                     'equivalent to -= 1
        Shift = Shift Mod 26                                            'keep in range 0 to 25
        lblShift.Text = Shift
    End Sub

    Private Sub btnEncrypt_Click(sender As Object, e As EventArgs) Handles btnEncrypt.Click
        Dim I, C As Integer
        Dim Last As Integer = txtMessage.Text.Length - 1                'last character
        Dim ThisChar As Char
        lblMessageEncrypted.Text = ""                                   'start with nothing
        For I = 0 To Last
            ThisChar = txtMessage.Text.Chars(I)                         'one character
            C = Asc(ThisChar) Xor nudXORoperand.Value                   'calculate new ASCII value
            ThisChar = Chr(C)   ' gets encrypted letter
            lblMessageEncrypted.Text += ThisChar                        'add the character
        Next
    End Sub

    Private Sub btnEncryptXOR_Click(sender As Object, e As EventArgs) Handles btnEncryptXOR.Click
        Dim I, C As Integer
        Dim Last As Integer = txtMessage2.Text.Length - 1               'last character
        Dim ThisChar As Char
        lblMessage2Encrypted.Text = ""                                  'start with nothing
        For I = 0 To Last
            ThisChar = txtMessage2.Text.Chars(I)                        'one character
            If ThisChar <> " " Then                                     'not spacebar character
                C = Asc(ThisChar)                                       'calculate new ASCII value
                C = C Xor nudXORoperand.Value                           'whichever number was chosen
                ThisChar = Chr(C)                                       'get encrypted letter
            End If
            lblMessage2Encrypted.Text += ThisChar                       'add the character
        Next
        btnDecrypt2.Visible = True
        lblMessage2Decrypted.Visible = True
    End Sub

    Private Sub btnDecrypt2_Click(sender As Object, e As EventArgs) Handles btnDecrypt2.Click
        Dim I, C As Integer
        Dim Last As Integer = lblMessage2Encrypted.Text.Length - 1      'last character
        Dim ThisChar As Char
        lblMessage2Decrypted.Text = ""                                  'start with nothing
        For I = 0 To Last
            ThisChar = lblMessage2Encrypted.Text.Chars(I)               'one character
            If ThisChar <> " " Then                                     'not spacebar character
                C = Asc(ThisChar)                                       'calculate new ASCII value
                C = C Xor nudXORoperand.Value                           'whichever number was chosen
                ThisChar = Chr(C)                                       'get encrypted letter
            End If
            lblMessage2Decrypted.Text += ThisChar                       'add the character
        Next
    End Sub

    Private Sub btnDisplayBeforeSending_Click(sender As Object, e As EventArgs) Handles btnDisplayBeforeSending.Click
        'Question 9 from Page 108-109
        Dim oLook As Object
        Dim oMail As Object
        oLook = CreateObject("Outlook.application")
        oMail = oLook.createItem(0)
        With oMail
            .To = txtSendTo.Text
            .subject = txtSubject.Text
            .body = lblMessageEncrypted.Text
            .display()
        End With
    End Sub
End Class
