Imports MySql.Data.MySqlClient
Public Class ProductAdd
    Dim MySqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub clear_entry()
        productIdTextBox.Text = ""
        productNameTextBox.Text = ""
        productDescTextBox.Text = ""
        productBuyRateMaskTextBox.Text = ""
        productQtyMaskTextBox.Text = ""
    End Sub
    Private Sub AddProductBtn_Click(sender As Object, e As EventArgs) Handles addProductBtn.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO wareit.products(product_id, product_name, product_buy_rate, product_desc, product_in_hand)
                    VALUES('" & productIdTextBox.Text & "', '" & productNameTextBox.Text & "', '" & productBuyRateMaskTextBox.Text & "' , '" & productDescTextBox.Text & "', '" & productQtyMaskTextBox.Text & "')"
            COMMAND = New MySqlCommand(Query, MySqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Inserted Successfully")
            clear_entry()
            MySqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MySqlConn.Dispose()

        End Try

    End Sub

End Class