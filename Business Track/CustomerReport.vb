Imports System.Data.OleDb
Imports System.Runtime.Intrinsics.Arm
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class CustomerReport
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\BUSINESS_TRACK.accdb"
    Dim conn As New OleDbConnection(connString)
    Dim adapter As OleDbDataAdapter
    Dim dt As New DataTable()


    Private Sub CustomerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Load data from database when the form loads
        LoadDataFromDatabase()
    End Sub

    Private Sub LoadDataFromDatabase()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM CUSTOMER"
            adapter = New OleDbDataAdapter(query, conn)
            dt.Clear()
            adapter.Fill(dt)
            DataGridViewCusReport.DataSource = dt
            DataGridViewCusReport.AllowUserToAddRows = False
            DataGridViewCusReport.AllowUserToDeleteRows = False
            DataGridViewCusReport.AllowUserToResizeRows = False
            DataGridViewCusReport.AllowUserToResizeColumns = False

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged

        Dim searchText As String = TxtSearch.Text.Trim()

        If searchText = "" Then
            CType(DataGridViewCusReport.DataSource, DataTable).DefaultView.RowFilter = ""
        Else
            CType(DataGridViewCusReport.DataSource, DataTable).DefaultView.RowFilter = $"Customer_name LIKE '%{searchText}%'"
        End If
    End Sub
    Private Sub DataGridViewCusReport_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewCusReport.CellClick

        If e.RowIndex >= 0 AndAlso e.ColumnIndex >= 0 Then
            Dim selectedRow As DataGridViewRow = DataGridViewCusReport.Rows(e.RowIndex)

            Dim form2 As New Customer()
            Dim form3 As New Sale()



            Customer.TxtCustName.Text = selectedRow.Cells("Customer_name").Value.ToString()
            Customer.TxtCustAddress.Text = selectedRow.Cells("Address").Value.ToString()
            Customer.TxtContactPerson.Text = selectedRow.Cells("Contact_person").Value.ToString()
            Customer.TxtPhoneNumber.Text = selectedRow.Cells("Phone_number").Value.ToString()
            Sale.TxtCustomerName.Text = selectedRow.Cells("Customer_name").Value.ToString()
            Sale.TxtPhoneNumber.Text = selectedRow.Cells("Phone_number").Value.ToString()
            Sale.TxtAddress.Text = selectedRow.Cells("Address").Value.ToString()

        End If

    End Sub

End Class
