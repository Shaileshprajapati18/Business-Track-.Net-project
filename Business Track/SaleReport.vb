Imports System.Data.OleDb

Public Class SaleReport
    Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\BUSINESS_TRACK.accdb"
    Dim conn As New OleDbConnection(connString)
    Dim adapter As OleDbDataAdapter
    Dim dt As New DataTable()
    Dim TotalQuantity As Integer = 0
    Dim TotalAmount As Decimal = 0

    Private Sub SaleReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        LoadDataFromDatabase()
    End Sub

    Private Sub LoadDataFromDatabase()
        Try
            conn.Open()
            Dim query As String = "SELECT * FROM SALE"
            adapter = New OleDbDataAdapter(query, conn)
            dt.Clear()
            adapter.Fill(dt)
            DataGridViewSaleReport.DataSource = dt
            DataGridViewSaleReport.AllowUserToAddRows = False
            DataGridViewSaleReport.AllowUserToDeleteRows = False
            DataGridViewSaleReport.AllowUserToResizeRows = False
            DataGridViewSaleReport.AllowUserToResizeColumns = False

            UpdateTotals()

        Catch ex As Exception
            MessageBox.Show("Error loading data: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub TxtSearch_TextChanged(sender As Object, e As EventArgs) Handles TxtSearch.TextChanged
        Dim searchText As String = TxtSearch.Text.Trim()

        If searchText = "" Then
            CType(DataGridViewSaleReport.DataSource, DataTable).DefaultView.RowFilter = ""
        Else
            CType(DataGridViewSaleReport.DataSource, DataTable).DefaultView.RowFilter = $"Convert(Invoice_no, 'System.String') LIKE '%{searchText}%'"
        End If
    End Sub

    Private Sub UpdateTotals()
        TotalQuantity = 0
        TotalAmount = 0

        For Each row As DataGridViewRow In DataGridViewSaleReport.Rows
            If Not row.IsNewRow Then
                Dim quantity As Integer = 0
                Dim amount As Decimal = 0

                Integer.TryParse(row.Cells("Quantity").Value.ToString(), quantity)
                Decimal.TryParse(row.Cells("Amount").Value.ToString(), amount)

                TotalQuantity += quantity
                TotalAmount += amount
            End If
        Next

        TxtTotalQuantity.Text = TotalQuantity.ToString()
        TxtTotalSale.Text = TotalAmount.ToString("0.00")

    End Sub

    Private Sub DataGridViewSaleReport_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        UpdateTotals()
    End Sub

    Private Sub DataGridViewSaleReport_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs)
        UpdateTotals()
    End Sub
    Private Sub Btnless_Click(sender As Object, e As EventArgs) Handles Btnless.Click
        ' Check if a row is selected
        If DataGridViewSaleReport.SelectedRows.Count > 0 Then
            ' Get the selected row index
            Dim rowIndex = DataGridViewSaleReport.SelectedRows(0).Index

            ' Get the Invoice_no of the selected row
            Dim invoiceNo = DataGridViewSaleReport.Rows(rowIndex).Cells("Invoice_no").Value.ToString

            ' Remove the selected row from DataGridView
            DataGridViewSaleReport.Rows.RemoveAt(rowIndex)

            ' Remove the row from the database
            Try
                conn.Open()
                Dim deleteQuery = "DELETE FROM SALE WHERE Invoice_no = @InvoiceNo"
                Dim cmd As New OleDbCommand(deleteQuery, conn)
                cmd.Parameters.AddWithValue("@InvoiceNo", invoiceNo)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Row deleted successfully.")
            Catch ex As Exception
                MessageBox.Show("Error deleting row: " & ex.Message)
            Finally
                conn.Close()
                ' Update the totals after deleting the row
                UpdateTotals()
            End Try
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

End Class
