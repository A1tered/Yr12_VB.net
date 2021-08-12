<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdmin
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnEdit = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.lvwStaffInfo = New System.Windows.Forms.ListView()
        Me.colLast = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colFirst = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTITOMon = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTITOTues = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTITOWed = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTITOThur = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTITOFri = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colTITOWeek = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSearch = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(26, 25)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(107, 50)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Add Member"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(149, 25)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(107, 50)
        Me.btnEdit.TabIndex = 1
        Me.btnEdit.Text = "Edit/Remove Member"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.Location = New System.Drawing.Point(901, 25)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(107, 50)
        Me.btnBack.TabIndex = 2
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'lvwStaffInfo
        '
        Me.lvwStaffInfo.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colLast, Me.colFirst, Me.colID, Me.colTITOMon, Me.colTITOTues, Me.colTITOWed, Me.colTITOThur, Me.colTITOFri, Me.colTITOWeek})
        Me.lvwStaffInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvwStaffInfo.FullRowSelect = True
        Me.lvwStaffInfo.GridLines = True
        Me.lvwStaffInfo.HideSelection = False
        Me.lvwStaffInfo.Location = New System.Drawing.Point(26, 83)
        Me.lvwStaffInfo.Name = "lvwStaffInfo"
        Me.lvwStaffInfo.Size = New System.Drawing.Size(982, 306)
        Me.lvwStaffInfo.TabIndex = 3
        Me.lvwStaffInfo.UseCompatibleStateImageBehavior = False
        Me.lvwStaffInfo.View = System.Windows.Forms.View.Details
        '
        'colLast
        '
        Me.colLast.Text = "Last Name"
        Me.colLast.Width = 123
        '
        'colFirst
        '
        Me.colFirst.Text = "First Name"
        Me.colFirst.Width = 111
        '
        'colID
        '
        Me.colID.Text = "ID"
        Me.colID.Width = 84
        '
        'colTITOMon
        '
        Me.colTITOMon.Text = "Hours Monday"
        Me.colTITOMon.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTITOMon.Width = 110
        '
        'colTITOTues
        '
        Me.colTITOTues.Text = "Hours Tuesday"
        Me.colTITOTues.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTITOTues.Width = 110
        '
        'colTITOWed
        '
        Me.colTITOWed.Text = "Hours Wednesday"
        Me.colTITOWed.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTITOWed.Width = 110
        '
        'colTITOThur
        '
        Me.colTITOThur.Text = "Hours Thursday"
        Me.colTITOThur.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTITOThur.Width = 110
        '
        'colTITOFri
        '
        Me.colTITOFri.Text = "Hours Friday"
        Me.colTITOFri.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTITOFri.Width = 110
        '
        'colTITOWeek
        '
        Me.colTITOWeek.Text = "Hours Past Week"
        Me.colTITOWeek.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.colTITOWeek.Width = 110
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(277, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Search Last Name:"
        '
        'txtSearch
        '
        Me.txtSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSearch.Location = New System.Drawing.Point(478, 35)
        Me.txtSearch.Name = "txtSearch"
        Me.txtSearch.Size = New System.Drawing.Size(254, 29)
        Me.txtSearch.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(774, 35)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 40)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "TI = Time In" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "TO = Time Out"
        '
        'frmAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 406)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtSearch)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lvwStaffInfo)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.btnAdd)
        Me.Name = "frmAdmin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Staff Info"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents lvwStaffInfo As ListView
    Friend WithEvents colLast As ColumnHeader
    Friend WithEvents colFirst As ColumnHeader
    Friend WithEvents colID As ColumnHeader
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents colTITOMon As ColumnHeader
    Friend WithEvents colTITOTues As ColumnHeader
    Friend WithEvents colTITOWed As ColumnHeader
    Friend WithEvents colTITOThur As ColumnHeader
    Friend WithEvents colTITOFri As ColumnHeader
    Friend WithEvents colTITOWeek As ColumnHeader
End Class
