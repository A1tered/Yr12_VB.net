<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSecretMessage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblPlainText = New System.Windows.Forms.Label()
        Me.lblEncrypted = New System.Windows.Forms.Label()
        Me.lblShift = New System.Windows.Forms.Label()
        Me.btnShiftLeft = New System.Windows.Forms.Button()
        Me.btnShiftRight = New System.Windows.Forms.Button()
        Me.txtMessage = New System.Windows.Forms.TextBox()
        Me.btnEncrypt = New System.Windows.Forms.Button()
        Me.lblMessageEncrypted = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSendTo = New System.Windows.Forms.TextBox()
        Me.txtSubject = New System.Windows.Forms.TextBox()
        Me.btnDisplayBeforeSending = New System.Windows.Forms.Button()
        Me.btnEncryptXOR = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nudXORoperand = New System.Windows.Forms.NumericUpDown()
        Me.lblMessage2Encrypted = New System.Windows.Forms.Label()
        Me.txtMessage2 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnDecrypt2 = New System.Windows.Forms.Button()
        Me.lblMessage2Decrypted = New System.Windows.Forms.Label()
        Me.ToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        CType(Me.nudXORoperand, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblPlainText
        '
        Me.lblPlainText.BackColor = System.Drawing.Color.White
        Me.lblPlainText.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPlainText.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPlainText.Location = New System.Drawing.Point(47, 26)
        Me.lblPlainText.Name = "lblPlainText"
        Me.lblPlainText.Size = New System.Drawing.Size(278, 20)
        Me.lblPlainText.TabIndex = 0
        '
        'lblEncrypted
        '
        Me.lblEncrypted.BackColor = System.Drawing.Color.Black
        Me.lblEncrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblEncrypted.Font = New System.Drawing.Font("Courier New", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEncrypted.ForeColor = System.Drawing.Color.White
        Me.lblEncrypted.Location = New System.Drawing.Point(47, 46)
        Me.lblEncrypted.Name = "lblEncrypted"
        Me.lblEncrypted.Size = New System.Drawing.Size(278, 20)
        Me.lblEncrypted.TabIndex = 1
        '
        'lblShift
        '
        Me.lblShift.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblShift.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShift.Location = New System.Drawing.Point(170, 85)
        Me.lblShift.Name = "lblShift"
        Me.lblShift.Size = New System.Drawing.Size(33, 23)
        Me.lblShift.TabIndex = 2
        Me.lblShift.Text = "0"
        Me.lblShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnShiftLeft
        '
        Me.btnShiftLeft.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShiftLeft.Location = New System.Drawing.Point(131, 85)
        Me.btnShiftLeft.Name = "btnShiftLeft"
        Me.btnShiftLeft.Size = New System.Drawing.Size(33, 23)
        Me.btnShiftLeft.TabIndex = 3
        Me.btnShiftLeft.Text = "<"
        Me.btnShiftLeft.UseVisualStyleBackColor = True
        '
        'btnShiftRight
        '
        Me.btnShiftRight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnShiftRight.Location = New System.Drawing.Point(209, 85)
        Me.btnShiftRight.Name = "btnShiftRight"
        Me.btnShiftRight.Size = New System.Drawing.Size(33, 23)
        Me.btnShiftRight.TabIndex = 4
        Me.btnShiftRight.Text = ">"
        Me.btnShiftRight.UseVisualStyleBackColor = True
        '
        'txtMessage
        '
        Me.txtMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage.Location = New System.Drawing.Point(47, 126)
        Me.txtMessage.Multiline = True
        Me.txtMessage.Name = "txtMessage"
        Me.txtMessage.Size = New System.Drawing.Size(278, 68)
        Me.txtMessage.TabIndex = 5
        '
        'btnEncrypt
        '
        Me.btnEncrypt.Location = New System.Drawing.Point(149, 210)
        Me.btnEncrypt.Name = "btnEncrypt"
        Me.btnEncrypt.Size = New System.Drawing.Size(75, 23)
        Me.btnEncrypt.TabIndex = 6
        Me.btnEncrypt.Text = "Encrypt"
        Me.btnEncrypt.UseVisualStyleBackColor = True
        '
        'lblMessageEncrypted
        '
        Me.lblMessageEncrypted.BackColor = System.Drawing.Color.Black
        Me.lblMessageEncrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessageEncrypted.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessageEncrypted.ForeColor = System.Drawing.Color.White
        Me.lblMessageEncrypted.Location = New System.Drawing.Point(47, 248)
        Me.lblMessageEncrypted.Name = "lblMessageEncrypted"
        Me.lblMessageEncrypted.Size = New System.Drawing.Size(278, 68)
        Me.lblMessageEncrypted.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 338)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Email to:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 368)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Subject"
        '
        'txtSendTo
        '
        Me.txtSendTo.Location = New System.Drawing.Point(103, 335)
        Me.txtSendTo.Name = "txtSendTo"
        Me.txtSendTo.Size = New System.Drawing.Size(222, 20)
        Me.txtSendTo.TabIndex = 11
        Me.txtSendTo.Text = "some1@mydomain.com"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(103, 368)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(222, 20)
        Me.txtSubject.TabIndex = 12
        Me.txtSubject.Text = "Secret"
        '
        'btnDisplayBeforeSending
        '
        Me.btnDisplayBeforeSending.Location = New System.Drawing.Point(103, 394)
        Me.btnDisplayBeforeSending.Name = "btnDisplayBeforeSending"
        Me.btnDisplayBeforeSending.Size = New System.Drawing.Size(222, 23)
        Me.btnDisplayBeforeSending.TabIndex = 13
        Me.btnDisplayBeforeSending.Text = "Display before sending"
        Me.ToolTip.SetToolTip(Me.btnDisplayBeforeSending, "Only functional if Outlook is installed")
        Me.btnDisplayBeforeSending.UseVisualStyleBackColor = True
        '
        'btnEncryptXOR
        '
        Me.btnEncryptXOR.Location = New System.Drawing.Point(379, 196)
        Me.btnEncryptXOR.Name = "btnEncryptXOR"
        Me.btnEncryptXOR.Size = New System.Drawing.Size(118, 37)
        Me.btnEncryptXOR.TabIndex = 14
        Me.btnEncryptXOR.Text = "Encrypt using XOR"
        Me.btnEncryptXOR.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(331, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 389)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "I"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(403, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "XOR operand"
        '
        'nudXORoperand
        '
        Me.nudXORoperand.Location = New System.Drawing.Point(405, 132)
        Me.nudXORoperand.Name = "nudXORoperand"
        Me.nudXORoperand.Size = New System.Drawing.Size(69, 20)
        Me.nudXORoperand.TabIndex = 17
        Me.nudXORoperand.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'lblMessage2Encrypted
        '
        Me.lblMessage2Encrypted.BackColor = System.Drawing.Color.Black
        Me.lblMessage2Encrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage2Encrypted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage2Encrypted.ForeColor = System.Drawing.Color.White
        Me.lblMessage2Encrypted.Location = New System.Drawing.Point(503, 180)
        Me.lblMessage2Encrypted.Name = "lblMessage2Encrypted"
        Me.lblMessage2Encrypted.Size = New System.Drawing.Size(162, 68)
        Me.lblMessage2Encrypted.TabIndex = 18
        '
        'txtMessage2
        '
        Me.txtMessage2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMessage2.Location = New System.Drawing.Point(503, 95)
        Me.txtMessage2.Multiline = True
        Me.txtMessage2.Name = "txtMessage2"
        Me.txtMessage2.Size = New System.Drawing.Size(162, 69)
        Me.txtMessage2.TabIndex = 19
        Me.txtMessage2.Text = "There is a new theory regarding the assassination of JFK."
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(392, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(273, 66)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Q10 Page 109 Secret Message 2 - fixed spacebar character as well"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnDecrypt2
        '
        Me.btnDecrypt2.Location = New System.Drawing.Point(379, 279)
        Me.btnDecrypt2.Name = "btnDecrypt2"
        Me.btnDecrypt2.Size = New System.Drawing.Size(118, 37)
        Me.btnDecrypt2.TabIndex = 21
        Me.btnDecrypt2.Text = "Decrypt using XOR"
        Me.btnDecrypt2.UseVisualStyleBackColor = True
        Me.btnDecrypt2.Visible = False
        '
        'lblMessage2Decrypted
        '
        Me.lblMessage2Decrypted.BackColor = System.Drawing.Color.Black
        Me.lblMessage2Decrypted.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblMessage2Decrypted.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage2Decrypted.ForeColor = System.Drawing.Color.White
        Me.lblMessage2Decrypted.Location = New System.Drawing.Point(503, 266)
        Me.lblMessage2Decrypted.Name = "lblMessage2Decrypted"
        Me.lblMessage2Decrypted.Size = New System.Drawing.Size(162, 68)
        Me.lblMessage2Decrypted.TabIndex = 22
        Me.lblMessage2Decrypted.Visible = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(402, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(263, 49)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Can you now save the encrypted content to a textfile? Can you then decypt the enc" &
    "rypted textfile and display it again?"
        '
        'frmSecretMessage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(717, 424)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblMessage2Decrypted)
        Me.Controls.Add(Me.btnDecrypt2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtMessage2)
        Me.Controls.Add(Me.lblMessage2Encrypted)
        Me.Controls.Add(Me.nudXORoperand)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnEncryptXOR)
        Me.Controls.Add(Me.btnDisplayBeforeSending)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.txtSendTo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblMessageEncrypted)
        Me.Controls.Add(Me.btnEncrypt)
        Me.Controls.Add(Me.txtMessage)
        Me.Controls.Add(Me.btnShiftRight)
        Me.Controls.Add(Me.btnShiftLeft)
        Me.Controls.Add(Me.lblShift)
        Me.Controls.Add(Me.lblEncrypted)
        Me.Controls.Add(Me.lblPlainText)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmSecretMessage"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Secret Message"
        CType(Me.nudXORoperand, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblPlainText As Label
    Friend WithEvents lblEncrypted As Label
    Friend WithEvents lblShift As Label
    Friend WithEvents btnShiftLeft As Button
    Friend WithEvents btnShiftRight As Button
    Friend WithEvents txtMessage As TextBox
    Friend WithEvents btnEncrypt As Button
    Friend WithEvents lblMessageEncrypted As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSendTo As TextBox
    Friend WithEvents txtSubject As TextBox
    Friend WithEvents btnDisplayBeforeSending As Button
    Friend WithEvents btnEncryptXOR As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nudXORoperand As NumericUpDown
    Friend WithEvents lblMessage2Encrypted As Label
    Friend WithEvents txtMessage2 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnDecrypt2 As Button
    Friend WithEvents lblMessage2Decrypted As Label
    Friend WithEvents ToolTip As ToolTip
    Friend WithEvents Label6 As Label
End Class
