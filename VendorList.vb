Imports MySql.Data.MySqlClient
Public Class VendorList
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand

    Private Sub load_table()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.vendors"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            VendorListDataGridView.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()

        End Try
    End Sub

    Private Sub progress_bar()
        ToolStripProgressBar1.PerformStep()
    End Sub

    Private Sub LoadVendorListBtn_Click(sender As Object, e As EventArgs) Handles loadVendorListBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.vendors"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            VendorListDataGridView.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            progress_bar()

        End Try
    End Sub

    Private Sub RefreshVendorListBtn_Click(sender As Object, e As EventArgs) Handles refreshVendorListBtn.Click
        load_table()
    End Sub

    Private Sub ToAddNewVendorBtn_Click(sender As Object, e As EventArgs) Handles toAddNewVendorBtn.Click
        VendorAdd.ShowDialog()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE wareit.vendors SET vendor_name = '" & updateVendorName.Text & "' WHERE vendor_id = '" & updateVendorId.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Updated")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub DeleteBtn_Click(sender As Object, e As EventArgs) Handles deleteBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM vendors WHERE client_no = '" & updateVendorId.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Data Deleted")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class