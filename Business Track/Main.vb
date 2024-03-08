Public Class Main

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ShowHomePage()
    End Sub

    Private Sub ShowHomePage()
        Dim homeForm As New Home()

        homeForm.TopLevel = False
        Panel4.Controls.Clear()
        Panel4.Controls.Add(homeForm)

        homeForm.BringToFront()
        homeForm.Show()
    End Sub

    Private Sub BtnHome_Click(sender As Object, e As EventArgs) Handles BtnHome.Click
        With Home  
            .TopLevel = False
            Panel4.Controls.Add(Home)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnCustomer_Click(sender As Object, e As EventArgs) Handles BtnCustomer.Click
        Home.Close()
        With Customer
            .TopLevel = False
            Panel4.Controls.Add(Customer)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnSale_Click(sender As Object, e As EventArgs) Handles BtnSale.Click
        Home.Close()

        With Sale
            .TopLevel = False
            Panel4.Controls.Add(Sale)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnPurchase_Click(sender As Object, e As EventArgs) Handles BtnPurchase.Click
        Home.Close()
        With Purchase
            .TopLevel = False
            Panel4.Controls.Add(Purchase)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnReport_Click(sender As Object, e As EventArgs) Handles BtnReport.Click
        Home.Close()
        With Report
            .TopLevel = False
            Panel4.Controls.Add(Report)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnHome_MouseHover(sender As Object, e As EventArgs) Handles BtnHome.MouseHover
        BtnHome.BackColor = Color.Silver
        BtnHome.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub BtnHome_MouseLeave(sender As Object, e As EventArgs) Handles BtnHome.MouseLeave
        BtnHome.BackColor = Color.FromArgb(64, 64, 64)
        BtnHome.ForeColor = Color.White
    End Sub

    Private Sub BtnCustomer_MouseHover(sender As Object, e As EventArgs) Handles BtnCustomer.MouseHover
        BtnCustomer.BackColor = Color.Silver
        BtnCustomer.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub BtnCustomer_MouseLeave(sender As Object, e As EventArgs) Handles BtnCustomer.MouseLeave
        BtnCustomer.BackColor = Color.FromArgb(64, 64, 64)
        BtnCustomer.ForeColor = Color.White
    End Sub

    Private Sub BtnSale_MouseHover(sender As Object, e As EventArgs) Handles BtnSale.MouseHover
        BtnSale.BackColor = Color.Silver
        BtnSale.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub BtnSale_MouseLeave(sender As Object, e As EventArgs) Handles BtnSale.MouseLeave
        BtnSale.BackColor = Color.FromArgb(64, 64, 64)
        BtnSale.ForeColor = Color.White
    End Sub

    Private Sub BtnPurchase_MouseHover(sender As Object, e As EventArgs) Handles BtnPurchase.MouseHover
        BtnPurchase.BackColor = Color.Silver
        BtnPurchase.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub BtnPurchase_MouseLeave(sender As Object, e As EventArgs) Handles BtnPurchase.MouseLeave
        BtnPurchase.BackColor = Color.FromArgb(64, 64, 64)
        BtnPurchase.ForeColor = Color.White
    End Sub

    Private Sub BtnReport_MouseHover(sender As Object, e As EventArgs) Handles BtnReport.MouseHover
        BtnReport.BackColor = Color.Silver
        BtnReport.ForeColor = Color.FromArgb(64, 64, 64)
    End Sub

    Private Sub BtnReport_MouseLeave(sender As Object, e As EventArgs) Handles BtnReport.MouseLeave
        BtnReport.BackColor = Color.FromArgb(64, 64, 64)
        BtnReport.ForeColor = Color.White
    End Sub

End Class
