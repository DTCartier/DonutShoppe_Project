'Programmer: Darryl Carter
'Date: 12-3-19
'Program: Calculates the subtotal, sales tax and total from the cost of 
'a donut and/or coffee

Option Explicit On
Option Strict Off
Option Infer Off

Public Class frmMain
    Dim decSubtotal As Decimal

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub Clearlabels(sender As Object, e As EventArgs) Handles radGlazed.CheckedChanged, radSugar.CheckedChanged,
            radChocolate.CheckedChanged, radFilled.CheckedChanged, radNone.CheckedChanged, radRegular.CheckedChanged,
            radCapp.CheckedChanged

        'Clears the amounts from the subtotal, tax, and total due labels
        lblSubtotalOut.Text = String.Empty
        lblSalesTaxOut.Text = String.Empty
        lblTotalDueOut.Text = String.Empty
    End Sub

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click
        Dim decTotal As Decimal

        SubTotalCalc()
        SalesTaxCalc(decSubtotal)
        decTotal = decSubtotal + SalesTaxCalc(decSubtotal)

        lblTotalDueOut.Text = decTotal.ToString("C2")

    End Sub

    Private Sub SubTotalCalc()
        'Calculates the cost of donuts
        Dim donut, coffee As Decimal
        If radGlazed.Checked Then
            donut = 1.05
        ElseIf radSugar.Checked Then
            donut = 1.05
        ElseIf radChocolate.Checked Then
            donut = 1.25
        ElseIf radFilled.Checked Then
            donut = 1.5
        End If

        'Calculates the cost of coffee
        If radNone.Checked = True Then
            coffee = 0.0
        ElseIf radRegular.Checked = True Then
            coffee = 1.5
        ElseIf radCapp.Checked = True Then
            coffee = 2.75
        End If

        'Adds donut and coffee to subtotal
        decSubtotal = donut + coffee
        lblSubtotalOut.Text = decSubtotal.ToString("C2")
    End Sub

    Private Function SalesTaxCalc(ByVal decSubtotal)
        Dim decSalesTax As Decimal
        Dim decTaxRate As Decimal = 0.06

        'Calculate the sales tax
        decSalesTax = decTaxRate * decSubtotal
        lblSalesTaxOut.Text = decSalesTax.ToString("C2")

        Return decSalesTax
    End Function

End Class
