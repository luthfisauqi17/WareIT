Imports MySql.Data.MySqlClient

Public Class ProductList
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
            Query = "SELECT * FROM wareit.products"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            ProductListDataGridView.DataSource = bSource
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

    Private Sub LoadProductListBtn_Click(sender As Object, e As EventArgs) Handles loadProductListBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.products"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            ProductListDataGridView.DataSource = bSource
            SDA.Update(dbDataSet)
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            progress_bar()

        End Try
    End Sub

    Private Sub ToAddNewProductBtn_Click(sender As Object, e As EventArgs) Handles toAddNewProductBtn.Click
        ProductAdd.ShowDialog()
    End Sub

    Private Sub RefreshProductListBtn_Click(sender As Object, e As EventArgs) Handles refreshProductListBtn.Click
        load_table()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE wareit.products SET product_name = '" & updateProductName.Text & "', product_in_hand = '" & updateProductQty.Text & "' WHERE product_id = '" & updateProductId.Text & "'"
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

    Private Sub DeleteProductBtn_Click(sender As Object, e As EventArgs) Handles deleteProductBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "DELETE FROM products WHERE product_id = '" & updateProductId.Text & "'"
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