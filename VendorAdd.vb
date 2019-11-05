Imports MySql.Data.MySqlClient
Public Class VendorAdd
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub clear_entry()
        vendorIdTextBox.Text = ""
        vendorNameTextBox.Text = ""
        vendorSpaceLocationTextBox.Text = ""
        vendorEmailTextBox.Text = ""
        vendorPhoneTextBox.Text = ""
        vendorAddressTextBox.Text = ""
    End Sub

    Private Sub AddVendorBtn_Click(sender As Object, e As EventArgs) Handles addVendorBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO wareit.vendors(vendor_id, vendor_name, vendor_space_location, vendor_email, vendor_phone, vendor_address)
                    VALUES('" & vendorIdTextBox.Text & "', '" & vendorNameTextBox.Text & "', '" & vendorSpaceLocationTextBox.Text & "', '" & vendorEmailTextBox.Text & "', '" & vendorPhoneTextBox.Text & "', '" & vendorAddressTextBox.Text & "')"
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