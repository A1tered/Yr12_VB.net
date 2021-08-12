<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmTextFileReader
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPath = New System.Windows.Forms.TextBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lvwContacts = New System.Windows.Forms.ListView()
        Me.colFirstName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colSecondName = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colNumber = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(30, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Path to text file:"
        '
        'txtPath
        '
        Me.txtPath.Location = New System.Drawing.Point(33, 47)
        Me.txtPath.Name = "txtPath"
        Me.txtPath.Size = New System.Drawing.Size(309, 20)
        Me.txtPath.TabIndex = 1
        '
        'btnRead
        '
        Me.btnRead.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRead.Location = New System.Drawing.Point(33, 254)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(92, 31)
        Me.btnRead.TabIndex = 3
        Me.btnRead.Text = "Read from file"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lvwContacts
        '
        Me.lvwContacts.CausesValidation = False
        Me.lvwContacts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colFirstName, Me.colSecondName, Me.colNumber})
        Me.lvwContacts.GridLines = True
        Me.lvwContacts.HideSelection = False
        Me.lvwContacts.Location = New System.Drawing.Point(33, 82)
        Me.lvwContacts.Name = "lvwContacts"
        Me.lvwContacts.Size = New System.Drawing.Size(309, 166)
        Me.lvwContacts.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.lvwContacts.TabIndex = 5
        Me.lvwContacts.UseCompatibleStateImageBehavior = False
        Me.lvwContacts.View = System.Windows.Forms.View.Details
        '
        'colFirstName
        '
        Me.colFirstName.Text = "First Name:"
        Me.colFirstName.Width = 98
        '
        'colSecondName
        '
        Me.colSecondName.Text = "Second Name:"
        Me.colSecondName.Width = 105
        '
        'colNumber
        '
        Me.colNumber.Text = "Number:"
        Me.colNumber.Width = 129
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(258, 254)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(84, 31)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmTextFileReader
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(373, 303)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lvwContacts)
        Me.Controls.Add(Me.btnRead)
        Me.Controls.Add(Me.txtPath)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmTextFileReader"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Text File Reader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtPath As TextBox
    Friend WithEvents btnRead As Button
    Friend WithEvents lvwContacts As ListView
    Friend WithEvents colFirstName As ColumnHeader
    Friend WithEvents colSecondName As ColumnHeader
    Friend WithEvents colNumber As ColumnHeader
    Friend WithEvents btnClear As Button
End Class
