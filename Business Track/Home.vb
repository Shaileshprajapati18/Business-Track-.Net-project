Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Home
    Private Sub Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtTotalHomeP.Enabled = True
        TxtTotalHomeS.Enabled = True


        Dim totalsale As New SaleReport()
        Dim totalpurchase As New PurchaseReport()

        totalsale.TxtTotalSale = Me.TxtTotalHomeS
        totalsale.Show()
        totalsale.Hide()

        totalpurchase.TxtTotalPurchase = Me.TxtTotalHomeP
        totalpurchase.Show()
        totalpurchase.Hide()
    End Sub
End Class
