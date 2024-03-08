Public Class Report

    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles BtnCustomer.Click
        With CustomerReport
            .TopLevel = False
            ShowReport.Controls.Add(CustomerReport)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
        With PurchaseReport
            .TopLevel = False
            ShowReport.Controls.Add(PurchaseReport)
            .BringToFront()
            .Show()
        End With
    End Sub


    Private Sub BtnSale_Click(sender As Object, e As EventArgs) Handles BtnSale.Click
        With SaleReport
            .TopLevel = False
            ShowReport.Controls.Add(SaleReport)
            .BringToFront()
            .Show()
        End With
    End Sub
End Class