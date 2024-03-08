Imports System.Data.OleDb

Public Class Login
    Dim cn As New OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader

    Private Sub BtnLogin_Click(sender As Object, e As EventArgs) Handles BtnLogin.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\BUSINESS_TRACK.accdb"

        ' Check if username or password is empty
        If String.IsNullOrEmpty(TxtUsername.Text) OrElse String.IsNullOrEmpty(TxtPassword.Text) Then
            MsgBox("Please enter both username and password.", MsgBoxStyle.Information, "Empty Fields")
            Return
        End If

        Try
            cn.ConnectionString = connectionString
            cn.Open()

            ' Prepare the SQL query to check if the user exists with the provided username and password
            Dim query As String = "SELECT COUNT(*) FROM LOGIN WHERE Username = ? AND Password = ?"
            cmd = New OleDbCommand(query, cn)
            cmd.Parameters.AddWithValue("@username", TxtUsername.Text.Trim())
            cmd.Parameters.AddWithValue("@password", TxtPassword.Text.Trim())

            Dim count As Integer = CInt(cmd.ExecuteScalar())

            If count > 0 Then
                MsgBox("Login Successful!", MsgBoxStyle.Information, "Success")
                Dim mainForm As New Main()
                mainForm.Show()
                Me.Hide()
            Else
                MsgBox("Invalid username or password.", MsgBoxStyle.Exclamation, "Login Failed")
            End If
        Catch ex As Exception
            MsgBox("Error during login: " & ex.Message, MsgBoxStyle.Critical, "Error")
        Finally
            cn.Close()
        End Try
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim result As DialogResult = MessageBox.Show("Are you sure you want to exit?", "Exit Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class
