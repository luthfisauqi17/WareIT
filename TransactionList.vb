Imports MySql.Data.MySqlClient

Public Class TransactionList

    Private Sub progress_bar()
        ToolStripProgressBar1.PerformStep()
    End Sub

    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Sub LoadTransactionBtn_Click(sender As Object, e As EventArgs) Handles loadTransactionBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.transactions"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim dr = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
            transactionListView.Items.Clear()
            Dim x As ListViewItem

            Do While dr.Read = True
                x = New ListViewItem(dr("transaction_no").ToString)
                x.SubItems.Add(dr("transaction_date"))
                x.SubItems.Add(dr("transaction_client_no"))
                x.SubItems.Add(dr("transaction_po_num"))
                x.SubItems.Add(dr("transaction_notes"))
                x.SubItems.Add(dr("transaction_product_id"))
                x.SubItems.Add(dr("transaction_qty"))
                x.SubItems.Add(dr("transaction_price"))
                x.SubItems.Add(dr("quantity_type"))
                transactionListView.Items.Add(x)
            Loop
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            progress_bar()

        End Try
    End Sub

    Private Sub LoadChartBtn_Click(sender As Object, e As EventArgs) Handles loadChartBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.products"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Chart1.Series("PRODUCT_VS_SOLD").Points.AddXY(READER.GetString("product_name"), READER.GetInt16("product_sold"))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TransactionAdd.ShowDialog()
    End Sub

    Private Sub RefreshTransactionBtn_Click(sender As Object, e As EventArgs) Handles refreshTransactionBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.transactions"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            Dim dr = COMMAND.ExecuteReader(CommandBehavior.CloseConnection)
            transactionListView.Items.Clear()
            Dim x As ListViewItem

            Do While dr.Read = True
                x = New ListViewItem(dr("transaction_no").ToString)
                x.SubItems.Add(dr("transaction_date"))
                x.SubItems.Add(dr("transaction_client_no"))
                x.SubItems.Add(dr("transaction_po_num"))
                x.SubItems.Add(dr("transaction_notes"))
                x.SubItems.Add(dr("transaction_product_id"))
                x.SubItems.Add(dr("transaction_qty"))
                x.SubItems.Add(dr("transaction_price"))
                x.SubItems.Add(dr("quantity_type"))
                transactionListView.Items.Add(x)
            Loop
            MysqlConn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)

        Finally
            MysqlConn.Dispose()
            progress_bar()

        End Try
    End Sub
End Class