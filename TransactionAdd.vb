Imports MySql.Data.MySqlClient
Public Class TransactionAdd
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim trans_qty As Int16
    Dim curr_qty As Int16
    Dim sold_qty As Int16
    Dim tot_price As Double
    Private Sub ProceedBtn_Click(sender As Object, e As EventArgs) Handles proceedBtn.Click

        Dim client_no As String = clientIdListBox.SelectedItem.ToString

        Dim qty_type() = {"Fixed", "Custom"}
        Dim type As String

        If fixedQtyRb.Checked Then
            type = qty_type(0)
        Else
            type = qty_type(1)
        End If



        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER, READER2 As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "INSERT INTO wareit.transactions(transaction_date, transaction_client_no, transaction_po_num, transaction_notes, transaction_product_id, transaction_qty, transaction_price, quantity_type) 
                    VALUES('" & transactionDatePicker.Text & "', '" & client_no & "', '" & poNumberTextBox.Text & "', '" & notesTextBox.Text & "', '" & productIdComboBox.Text & "', '" & trans_qty & "', '" & tot_price & "', '" & type & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            MessageBox.Show("Data Inserted Successfully")
            If generateReportCheckBox.Checked = True Then
                Dim reportString = "Date: " + Convert.ToString(transactionDatePicker.Text) + Constants.vbCrLf + "Client No: " + Convert.ToString(client_no) + Constants.vbCrLf + "PO Number: " + Convert.ToString(poNumberTextBox.Text) + Constants.vbCrLf +
                                "Notes: " + Convert.ToString(notesTextBox.Text) + Constants.vbCrLf + "Product Id: " + Convert.ToString(productIdComboBox.Text) + Constants.vbCrLf + "Transaction Quantity: " + Convert.ToString(trans_qty) + Constants.vbCrLf +
                                "Total Price: " + Convert.ToString(tot_price) + Constants.vbCrLf + "Quantity Type: " + Convert.ToString(type) + Constants.vbCrLf
                MessageBox.Show(reportString)
            End If
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try


        Try
            MysqlConn.Open()
            Dim Query = "UPDATE wareit.products SET product_in_hand = '" & curr_qty - trans_qty & "', product_sold = '" & sold_qty + trans_qty & "' WHERE product_id = '" & productIdComboBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER2 = COMMAND.ExecuteReader
            MessageBox.Show("Product Updated")
            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try







































    End Sub

    Private Sub TransactionAdd_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        customQtyGroupBox.Visible = False
        fixedQtyRb.Checked = True
        proceedBtn.Enabled = False

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER, READER2 As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.products"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            While READER.Read
                Dim productId = READER.GetString("product_id")
                productIdComboBox.Items.Add(productId)
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        Try
            MysqlConn.Open()
            Dim Query2 As String
            Query2 = "SELECT * FROM wareit.clients"
            COMMAND = New MySqlCommand(Query2, MysqlConn)
            READER2 = COMMAND.ExecuteReader

            While READER2.Read
                Dim clientId = READER2.GetString("client_no")
                clientIdListBox.Items.Add(clientId)
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub


    Private Sub AvailabilityCheckBtn_Click(sender As Object, e As EventArgs) Handles availabilityCheckBtn.Click

        If fixedQtyRb.Checked Then
            If qtyCheckboxList.SelectedIndex = 0 Then
                trans_qty = 5
            ElseIf qtyCheckboxList.SelectedIndex = 1 Then
                trans_qty = 10
            ElseIf qtyCheckboxList.SelectedIndex = 2 Then
                trans_qty = 15
            ElseIf qtyCheckboxList.SelectedIndex = 3 Then
                trans_qty = 20
            ElseIf qtyCheckboxList.SelectedIndex = 4 Then
                trans_qty = 25
            End If
        ElseIf customQtyRb.Checked Then
            trans_qty = qtyNumUpDown.Value
        End If

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = "server=localhost; userid=root; password=''; database=wareit"
        Dim READER As MySqlDataReader
        Dim prod_price As Double

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM wareit.products WHERE product_id = '" & productIdComboBox.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader


            While READER.Read
                curr_qty = READER.GetInt16("product_in_hand")
                sold_qty = READER.GetInt16("product_sold")
                prod_price = READER.GetDouble("product_buy_rate")
            End While

            MysqlConn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try

        If curr_qty < trans_qty Then
            MsgBox("Invalid Quantity")
            proceedBtn.Enabled = False
        Else
            MsgBox("Valid Quantity")
            tot_price = totalPriceCalculator(trans_qty, prod_price)
            totalPriceLabel.Text = tot_price
            proceedBtn.Enabled = True
        End If

        selectedItemLabel.Text = trans_qty

    End Sub

    Function totalPriceCalculator(ByVal qty As Int16, ByVal price As Double)
        Dim tax As Double
        Dim total_price As Double
        tax = (qty * price * 0.1)
        total_price = tax + (qty * price)
        Return total_price
    End Function


    Private Sub ProductInRb_CheckedChanged(sender As Object, e As EventArgs)
        productOutOpt.Visible = False
        availabilityCheckBtn.Visible = False
        totPriceGroupBox.Visible = False
        proceedBtn.Enabled = True
    End Sub

    Private Sub ProductOutRb_CheckedChanged(sender As Object, e As EventArgs)
        productOutOpt.Visible = True
        availabilityCheckBtn.Visible = True
        totPriceGroupBox.Visible = True
        proceedBtn.Enabled = False
    End Sub

    Private Sub ClrBtn_Click(sender As Object, e As EventArgs) Handles clrBtn.Click
        trans_qty = 0
    End Sub

    Private Sub FixedQtyRb_CheckedChanged(sender As Object, e As EventArgs) Handles fixedQtyRb.CheckedChanged
        customQtyGroupBox.Visible = False
        qtyCheckboxList.Visible = True
    End Sub

    Private Sub CustomQtyRb_CheckedChanged(sender As Object, e As EventArgs) Handles customQtyRb.CheckedChanged
        customQtyGroupBox.Visible = True
        qtyCheckboxList.Visible = False
    End Sub

End Class