Imports System.Data.OleDb
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Purchase
    Dim cn As New OleDbConnection
    Dim ds As New DataSet
    Dim cmd As OleDbCommand

    Private Sub Purchase_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Disable fields initially
        TxtSerialNo.Enabled = False
        TxtDescription.Enabled = False
        TxtUnit.Enabled = False
        TxtQty.Enabled = False
        TxtRate.Enabled = False
    End Sub
    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrWhiteSpace(TxtInvoiceNo.Text) OrElse
    String.IsNullOrWhiteSpace(TxtDate.Text) OrElse
    String.IsNullOrWhiteSpace(TxtQuantity.Text) OrElse  ' Changed from TxtQuantity.Text
    String.IsNullOrWhiteSpace(TxtGrandTotal.Text) Then
            MsgBox("Please fill in all fields.")
            Return
        End If

        ' Define connection string
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\BUSINESS_TRACK.accdb"

        ' Create connection
        Using cn As New OleDbConnection(connectionString)
            Try
                cn.Open()
                ' Create SQL command with parameters
                Dim cmd As New OleDbCommand("INSERT INTO PURCHASE (Invoice_no, [Date], Quantity, Amount) VALUES (?, ?, ?, ?)", cn)
                cmd.Parameters.AddWithValue("Invoice_no", TxtInvoiceNo.Text)
                cmd.Parameters.AddWithValue("Date", TxtDate.Text)
                cmd.Parameters.AddWithValue("Quantity", TxtQuantity.Text) ' Assuming TxtQty is automatically calculated
                cmd.Parameters.AddWithValue("Amount", TxtGrandTotal.Text) ' Assuming TxtGrandTotal is automatically calculated
                cmd.ExecuteNonQuery()
                MsgBox("Invoice saved successfully.")
            Catch ex As Exception
                MsgBox("Error while saving invoice: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub TxtInvoiceNo_TextChanged(sender As Object, e As EventArgs) Handles TxtInvoiceNo.TextChanged
        If Not String.IsNullOrWhiteSpace(TxtInvoiceNo.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtDate.Text) Then
            EnableFields()
        Else
            DisableFields()
        End If
    End Sub

    Private Sub TxtDate_TextChanged(sender As Object, e As EventArgs) Handles TxtDate.TextChanged
        If Not String.IsNullOrWhiteSpace(TxtInvoiceNo.Text) AndAlso Not String.IsNullOrWhiteSpace(TxtDate.Text) Then
            EnableFields()
        Else
            DisableFields()
        End If
    End Sub

    Private Sub EnableFields()
        TxtSerialNo.Enabled = True
        TxtDescription.Enabled = True
        TxtUnit.Enabled = True
        TxtQty.Enabled = True
        TxtRate.Enabled = True
    End Sub

    Private Sub DisableFields()
        TxtSerialNo.Enabled = False
        TxtDescription.Enabled = False
        TxtUnit.Enabled = False
        TxtQty.Enabled = False
        TxtRate.Enabled = False
    End Sub

    Private Sub BtnPlus_Click(sender As Object, e As EventArgs) Handles BtnPlus.Click
        ' Get the values from the TextBoxes
        Dim value1 As String = TxtSerialNo.Text
        Dim value2 As String = TxtDescription.Text
        Dim value3 As String = TxtUnit.Text
        Dim value4 As String = TxtQty.Text
        Dim value5 As String = TxtRate.Text
        If String.IsNullOrWhiteSpace(TxtInvoiceNo.Text) OrElse String.IsNullOrWhiteSpace(TxtDate.Text) Then
            MsgBox("Please fill in Invoice Number and Date.")
            Return
        End If
        ' Check if any of the TextBoxes are empty, don't add row if any are empty
        If String.IsNullOrEmpty(value1) OrElse String.IsNullOrEmpty(value2) OrElse String.IsNullOrEmpty(value3) OrElse String.IsNullOrEmpty(value4) OrElse String.IsNullOrEmpty(value5) Then
            MessageBox.Show("Please fill all fields.")
            Return
        End If

        ' Calculate the Amount (Qty * Rate)
        Dim amount As Decimal = Convert.ToDecimal(value4) * Convert.ToDecimal(value5)

        ' Add a new row to the DataGridView
        Dim rowIndex As Integer = DataGridViewPurchase.Rows.Add()

        ' Set the values of the cells in the new row
        DataGridViewPurchase.Rows(rowIndex).Cells(0).Value = rowIndex + 1
        DataGridViewPurchase.Rows(rowIndex).Cells(1).Value = value1
        DataGridViewPurchase.Rows(rowIndex).Cells(2).Value = value2
        DataGridViewPurchase.Rows(rowIndex).Cells(3).Value = value3
        DataGridViewPurchase.Rows(rowIndex).Cells(4).Value = value4
        DataGridViewPurchase.Rows(rowIndex).Cells(5).Value = value5
        DataGridViewPurchase.Rows(rowIndex).Cells(6).Value = amount

        Dim Total As Decimal = 0
        Dim Qty As Decimal = 0

        For Each row As DataGridViewRow In DataGridViewPurchase.Rows
            If Not row.IsNewRow Then
                Dim rowAmount1 As Decimal = Convert.ToDecimal(row.Cells("Column7").Value)
                Dim rowAmount2 As Decimal = Convert.ToDecimal(row.Cells("Column5").Value)

                Total += rowAmount1
                Qty += rowAmount2

            End If
        Next

        ' Set total to TxtTotal
        TxtTotal.Text = Total.ToString("0.00")
        TxtQuantity.Text = Qty.ToString("")

        UpdateGrandTotal() ' Call the function to update grand total

        ' Clear the TextBoxes after adding the values
        TxtSerialNo.Text = ""
        TxtDescription.Text = ""
        TxtUnit.Text = ""
        TxtQty.Text = ""
        TxtRate.Text = ""

        ' Set the focus back to the first textbox
        TxtSerialNo.Focus()
    End Sub

    Private Sub Btnless_Click(sender As Object, e As EventArgs) Handles Btnless.Click
        ' Check if a row is selected
        If DataGridViewPurchase.SelectedRows.Count > 0 Then
            ' Get the selected row index
            Dim rowIndex As Integer = DataGridViewPurchase.SelectedRows(0).Index

            ' Remove the selected row
            DataGridViewPurchase.Rows.RemoveAt(rowIndex)

            ' Recalculate total and quantities
            UpdateTotalAndQuantity()

            ' Update grand total
            UpdateGrandTotal()
        Else
            MessageBox.Show("Please select a row to delete.")
        End If
    End Sub

    Private Sub TxtDiscount_TextChanged(sender As Object, e As EventArgs) Handles TxtDiscount.TextChanged
        UpdateGrandTotal()
    End Sub

    Private Sub UpdateGrandTotal()
        Dim Total As Decimal = Convert.ToDecimal(TxtTotal.Text)
        Dim discount As Decimal = If(String.IsNullOrEmpty(TxtDiscount.Text), 0, Convert.ToDecimal(TxtDiscount.Text))
        Dim grandTotal As Decimal = Total - discount

        TxtGrandTotal.Text = grandTotal.ToString("0.00")
    End Sub

    Private Sub UpdateTotalAndQuantity()
        Dim Total As Decimal = 0
        Dim Qty As Decimal = 0

        For Each row As DataGridViewRow In DataGridViewPurchase.Rows
            If Not row.IsNewRow Then
                Dim rowAmount1 As Decimal = Convert.ToDecimal(row.Cells("Column7").Value)
                Dim rowAmount2 As Decimal = Convert.ToDecimal(row.Cells("Column5").Value)

                Total += rowAmount1
                Qty += rowAmount2
            End If
        Next

        ' Set total to TxtTotal
        TxtTotal.Text = Total.ToString("0.00")
        TxtQuantity.Text = Qty.ToString("")
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

    End Sub

End Class
