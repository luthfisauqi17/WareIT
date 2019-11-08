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
End Class