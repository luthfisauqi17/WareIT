Imports MySql.Data.MySqlClient
Public Class ClientAdd
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub clear_entry()
        clientIdTextBox.Text = ""
        clientNameTextBox.Text = ""
        clientAddressTextBox.Text = ""
        clientEmailTextBox.Text = ""
        clientPhoneTextBox.Text = ""
    End Sub

    Private Sub AddClientBtn_Click(sender As Object, e As EventArgs) Handles addClientBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO wareit.clients(client_no, client_name, client_address, client_email, client_phone)
                    VALUES('" & clientIdTextBox.Text & "', '" & clientNameTextBox.Text & "', '" & clientAddressTextBox.Text & "', '" & clientEmailTextBox.Text & "', '" & clientPhoneTextBox.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Inserted Successfully")
            clear_entry()
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub
End Class