Imports MySql.Data.MySqlClient

Public Class Login
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub testConnectionBtn_Click(sender As Object, e As EventArgs) Handles testConnectionBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"

        Try
            MysqlConn.Open()
            MessageBox.Show("Connection found")
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Close()

        End Try
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.auth WHERE auth_username = '" & usernameTextBox.Text & "' AND auth_password = '" & passwordTextBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim counter As Int16 = 0
            While READER.Read
                counter += 1
            End While

            If counter = 1 Then
                MessageBox.Show("Welcome " + usernameTextBox.Text)
                MainFrame.Show()
                Me.Hide()
            ElseIf counter > 1 Then
                MessageBox.Show("User duplicated")
            Else
                MessageBox.Show("Username and password are incorrect")
            End If
            MysqlConn.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
End Class