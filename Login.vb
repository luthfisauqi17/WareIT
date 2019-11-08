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
                If validateVscrollPass(vscrollAmount.Text) Then
                    MessageBox.Show("Welcome " + usernameTextBox.Text)
                    MainFrame.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Sorry, Wrong Vscroll Auth Password!")
                End If

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

    Private Sub VscrollPass_Scroll(sender As Object, e As ScrollEventArgs) Handles vscrollPass.Scroll
        vscrollAmount.Text = vscrollPass.Value
    End Sub

    Function validateVscrollPass(ByVal amount)
        If amount = 54 Then
            Return True
        Else
            Return False
        End If
    End Function

End Class