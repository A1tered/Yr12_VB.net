Public Class frmCurrencyConverter

    'Name:         Zach Smith
    'Start:        07 Febuary 2020
    'Last Updated: 14 Febuary 2020
    'Description:  This program calculates the amount of moneey inputed to the selected countries

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If Not IsNumeric(txtAmountInput.Text) Then                         'This makes sure that text inputed into the text box in numerical and if so a error is dislpayed
            MessageBox.Show("Only Enter Positive Numbers", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If Val(txtAmountInput.Text) < 0 Then             'This checkes that numbers inputed are over 0 and if so a error is dislpayed
                txtAmountInput.Text = " "
                MessageBox.Show("Only Enter Numbers between 0 and 99999.99", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Else
                If Val(txtAmountInput.Text) > 99999.99 Then      ''This checkes that numbers inputed are not over 99999.99 and if so a error is dislpayed
                    txtAmountInput.Text = " "
                    MessageBox.Show("Only Enter Numbers between 0 and 99999.99", "Currency Converter", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Else
                    lblAmountOutput.Text = Format(Val(lblAmountOutput.Text), "$" + "##,##0.00")
                    Select Case cmbCountry.Text                     'The select case is used to calculate the rate of the Australi dollars to another countries currency
                        Case "Euro (EUR)"
                            lblAmountOutput.Text = Format(Val(txtAmountInput.Text) * 0.89, "$" + "##,##0.00")
                        Case "New Zealand Dollar (NZD)"
                            lblAmountOutput.Text = Format(Val(txtAmountInput.Text) * 1.04, "$" + "##,##0.00")
                        Case "British Pound (GBP)"
                            lblAmountOutput.Text = Format(Val(txtAmountInput.Text) * 0.52, "$" + "##,##0.00")
                        Case "US Dollar (USD)"
                            lblAmountOutput.Text = Format(Val(txtAmountInput.Text) * 0.67, "$" + "##,##0.00")
                        Case "Canadian Dollar (CAD)"
                            lblAmountOutput.Text = Format(Val(txtAmountInput.Text) * 0.89, "$" + "##,##0.00")
                        Case "Japanese Yen (JPY)"
                            lblAmountOutput.Text = Format(Val(txtAmountInput.Text) * 73.89, "$" + "##,##0.00")
                        Case "Sweedish Krona (SEK)"
                            lblAmountOutput.Text = Format(Val(txtAmountInput.Text) * 6.51, "$" + "##,##0.00")
                        Case "Kuwaiti Dinar (KWD)"
                            lblAmountOutput.Text = Format(Val(txtAmountInput.Text) * 0.21, "$" + "##,##0.00")
                    End Select
                End If
            End If
        End If
    End Sub

End Class
