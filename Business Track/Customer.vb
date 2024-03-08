Imports System.Data.OleDb

Public Class Customer
    Dim cn As New OleDbConnection
    Dim ds As New DataSet
    Dim cmd As OleDbCommand

    Private Sub ButSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
        If String.IsNullOrWhiteSpace(TxtCustName.Text) OrElse
String.IsNullOrWhiteSpace(TxtCustAddress.Text) OrElse
String.IsNullOrWhiteSpace(TxtContactPerson.Text) OrElse
String.IsNullOrWhiteSpace(TxtPhoneNumber.Text) Then
            MsgBox("Please fill in all fields.")
            Return
        End If
        cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\BUSINESS_TRACK.accdb"
        Try
            cn.Open()
            cmd = New OleDbCommand("insert into CUSTOMER values('" & TxtCustName.Text & "','" & TxtCustAddress.Text & "','" & TxtContactPerson.Text & "','" & TxtPhoneNumber.Text & "')", cn)
            cmd.ExecuteNonQuery()
            ' MsgBox("Inserted....")
        Catch ex As Exception
            MsgBox("error" & ex.Message)
        Finally
            cn.Close()
        End Try


    End Sub

    Private Sub BtnFind_Click(sender As Object, e As EventArgs) Handles BtnFind.Click
        With CustomerReport
            .TopLevel = False
            ShowReport.Controls.Add(CustomerReport)
            .BringToFront()
            .Show()
        End With
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles BtnAdd.Click

        TxtCustName.Clear()
        TxtCustAddress.Clear()
        TxtContactPerson.Clear()
        TxtPhoneNumber.Clear()


    End Sub

    Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click

        If String.IsNullOrWhiteSpace(TxtCustName.Text) OrElse
    String.IsNullOrWhiteSpace(TxtCustAddress.Text) OrElse
    String.IsNullOrWhiteSpace(TxtContactPerson.Text) OrElse
    String.IsNullOrWhiteSpace(TxtPhoneNumber.Text) Then
            MsgBox("Please fill in all fields.")
            Return
        End If


        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\BUSINESS_TRACK.accdb")
                cn.Open()
                Dim query As String = "UPDATE CUSTOMER SET Customer_name = ?, Address = ?, Contact_person = ? WHERE Phone_number = ?  "
                Using cmd As New OleDbCommand(query, cn)

                    cmd.Parameters.AddWithValue("?", TxtCustName.Text.Trim())
                    cmd.Parameters.AddWithValue("?", TxtCustAddress.Text.Trim())
                    cmd.Parameters.AddWithValue("?", TxtContactPerson.Text.Trim())
                    cmd.Parameters.AddWithValue("?", TxtPhoneNumber.Text.Trim())


                    cmd.ExecuteNonQuery()
                    MsgBox("Record Updated")
                End Using
            End Using
        Catch ex As Exception
            ' MsgBox("Error updating record: " & ex.Message)
        End Try
    End Sub


    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click

        If String.IsNullOrWhiteSpace(TxtCustName.Text) AndAlso
       String.IsNullOrWhiteSpace(TxtCustAddress.Text) AndAlso
       String.IsNullOrWhiteSpace(TxtContactPerson.Text) AndAlso
       String.IsNullOrWhiteSpace(TxtPhoneNumber.Text) Then
            MsgBox("Please select an item to delete.")
        End If
        Try
            Using cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\BUSINESS_TRACK.accdb")
                cn.Open()
                Dim query As String = "DELETE FROM CUSTOMER WHERE Customer_name = ? AND Address = ? AND Contact_person = ? AND Phone_number = ?"
                Using cmd As New OleDbCommand(query, cn)
                    cmd.Parameters.AddWithValue("?", TxtCustName.Text.Trim())
                    cmd.Parameters.AddWithValue("?", TxtCustAddress.Text.Trim())
                    cmd.Parameters.AddWithValue("?", TxtContactPerson.Text.Trim())
                    cmd.Parameters.AddWithValue("?", TxtPhoneNumber.Text.Trim())
                    cmd.ExecuteNonQuery()
                    ' MsgBox("Record Deleted")
                End Using
            End Using

            TxtCustName.Clear()
            TxtCustAddress.Clear()
            TxtContactPerson.Clear()
            TxtPhoneNumber.Clear()

        Catch ex As Exception
            ' MsgBox("Error deleting record: " & ex.Message)
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Me.Close()
    End Sub
End Class
