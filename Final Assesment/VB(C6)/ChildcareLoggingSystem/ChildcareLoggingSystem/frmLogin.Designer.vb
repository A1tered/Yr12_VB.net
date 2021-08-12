<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ChildCareDataBase = New System.Windows.Forms.OpenFileDialog()
        Me.lvwStaffLogin = New System.Windows.Forms.ListView()
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPass = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(261, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(185, 84)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Monash " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Childcare"
        '
        'txtID
        '
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(137, 293)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(456, 38)
        Me.txtID.TabIndex = 1
        Me.txtID.Text = "ID"
        '
        'txtPassword
        '
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(137, 358)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(456, 38)
        Me.txtPassword.TabIndex = 2
        Me.txtPassword.Tag = ""
        Me.txtPassword.Text = "Password"
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(286, 453)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(110, 53)
        Me.btnLogin.TabIndex = 3
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(204, 208)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Enter your ID and password to continue" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'ChildCareDataBase
        '
        Me.ChildCareDataBase.FileName = "ChildCareDataBase.txt"
        '
        'lvwStaffLogin
        '
        Me.lvwStaffLogin.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colID, Me.colPass})
        Me.lvwStaffLogin.HideSelection = False
        Me.lvwStaffLogin.Location = New System.Drawing.Point(41, 77)
        Me.lvwStaffLogin.Name = "lvwStaffLogin"
        Me.lvwStaffLogin.Size = New System.Drawing.Size(124, 126)
        Me.lvwStaffLogin.TabIndex = 5
        Me.lvwStaffLogin.UseCompatibleStateImageBehavior = False
        Me.lvwStaffLogin.View = System.Windows.Forms.View.Details
        Me.lvwStaffLogin.Visible = False
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 61
        '
        'colPass
        '
        Me.colPass.Text = "Password"
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(763, 650)
        Me.Controls.Add(Me.lvwStaffLogin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents ChildCareDataBase As OpenFileDialog
    Friend WithEvents lvwStaffLogin As ListView
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents colPass As ColumnHeader
End Class
