﻿Imports MySql.Data.MySqlClient
Public Class ClientList
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
            Query = "SELECT * FROM wareit.clients"
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


    Private Sub ToAddNewClientBtn_Click(sender As Object, e As EventArgs) Handles toAddNewClientBtn.Click
        ClientAdd.ShowDialog()
    End Sub

    Private Sub LoadClientListBtn_Click(sender As Object, e As EventArgs) Handles loadClientListBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim SDA As New MySqlDataAdapter
        Dim dbDataSet As New DataTable
        Dim bSource As New BindingSource

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.clients"
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

    Private Sub RefreshClientListBtn_Click(sender As Object, e As EventArgs) Handles refreshClientListBtn.Click
        load_table()
        progress_bar()
    End Sub

    Private Sub UpdateBtn_Click(sender As Object, e As EventArgs) Handles updateBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "UPDATE wareit.clients SET client_name = '" & updateClientName.Text & "' WHERE client_no = '" & updateClientId.Text & "'"
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
            Query = "DELETE FROM clients WHERE client_no = '" & updateClientId.Text & "'"
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

    Private Sub NewToolStripButton_Click(sender As Object, e As EventArgs) Handles NewToolStripButton.Click
        ClientAdd.ShowDialog()
    End Sub
End Class