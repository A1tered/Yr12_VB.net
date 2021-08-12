<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCurrencyConverter
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
        Me.txtAmountInput = New System.Windows.Forms.TextBox()
        Me.lblAmountOutput = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.cmbCountry = New System.Windows.Forms.ComboBox()
        Me.lblAmount = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtAmountInput
        '
        Me.txtAmountInput.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountInput.Location = New System.Drawing.Point(119, 132)
        Me.txtAmountInput.Name = "txtAmountInput"
        Me.txtAmountInput.Size = New System.Drawing.Size(100, 24)
        Me.txtAmountInput.TabIndex = 2
        Me.txtAmountInput.Text = "0"
        '
        'lblAmountOutput
        '
        Me.lblAmountOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmountOutput.Location = New System.Drawing.Point(137, 243)
        Me.lblAmountOutput.Name = "lblAmountOutput"
        Me.lblAmountOutput.Size = New System.Drawing.Size(214, 23)
        Me.lblAmountOutput.TabIndex = 3
        Me.lblAmountOutput.Text = "$00000.00"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(78, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(273, 64)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Australian Currency Converter"
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(250, 133)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Australian Dollar"
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(255, 181)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(130, 43)
        Me.btnConvert.TabIndex = 6
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'cmbCountry
        '
        Me.cmbCountry.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCountry.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.FormattingEnabled = True
        Me.cmbCountry.Items.AddRange(New Object() {"British Pound (GBP)", "Canadian Dollar (CAD)", "Euro (EUR)", "New Zealand Dollar (NZD)", "US Dollar (USD)", "Japanese Yen (JPY)", "Sweedish Krona (SEK)", "Kuwaiti Dinar (KWD)"})
        Me.cmbCountry.Location = New System.Drawing.Point(84, 181)
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.Size = New System.Drawing.Size(153, 24)
        Me.cmbCountry.TabIndex = 7
        '
        'lblAmount
        '
        Me.lblAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAmount.Location = New System.Drawing.Point(13, 133)
        Me.lblAmount.Name = "lblAmount"
        Me.lblAmount.Size = New System.Drawing.Size(100, 23)
        Me.lblAmount.TabIndex = 8
        Me.lblAmount.Text = "Amount:"
        '
        'frmCurrencyConverter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 308)
        Me.Controls.Add(Me.lblAmount)
        Me.Controls.Add(Me.cmbCountry)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblAmountOutput)
        Me.Controls.Add(Me.txtAmountInput)
        Me.Name = "frmCurrencyConverter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Currency Converter"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtAmountInput As TextBox
    Friend WithEvents lblAmountOutput As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnConvert As Button
    Friend WithEvents cmbCountry As ComboBox
    Friend WithEvents lblAmount As Label
End Class
