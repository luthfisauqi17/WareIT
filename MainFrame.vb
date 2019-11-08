Public Class MainFrame
    Private Sub MainFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currTimeLabel.Text = Date.Now.ToString("dd-MM-yyyy hh:mm:ss")
    End Sub

    Private Sub SignoutBtn_Click(sender As Object, e As EventArgs) Handles signoutBtn.Click
        Login.Show()
        Me.Hide()
    End Sub

#Region "Product"

    Private Sub ProductListToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem.Click
        ProductList.MdiParent = Me
        ProductList.Show()
    End Sub

    Private Sub ProductListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem1.Click
        ProductList.MdiParent = Me
        ProductList.Show()
    End Sub

    Private Sub AddNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewProductToolStripMenuItem.Click
        ProductAdd.ShowDialog()
    End Sub

    Private Sub AddNewProductToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewProductToolStripMenuItem1.Click
        ProductAdd.ShowDialog()
    End Sub
#End Region

#Region "Vendor"

    Private Sub VendorListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorListToolStripMenuItem.Click
        VendorList.MdiParent = Me
        VendorList.Show()
    End Sub

    Private Sub AddNewVendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewVendorToolStripMenuItem.Click
        VendorAdd.ShowDialog()
    End Sub
    Private Sub VendorListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles VendorListToolStripMenuItem1.Click
        VendorList.MdiParent = Me
        VendorList.Show()
    End Sub

    Private Sub AddNewVendorToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewVendorToolStripMenuItem1.Click
        VendorAdd.ShowDialog()
    End Sub


#End Region

#Region "Client"
    Private Sub ClientListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientListToolStripMenuItem.Click
        ClientList.MdiParent = Me
        ClientList.Show()
    End Sub
    Private Sub AddNewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewClientToolStripMenuItem.Click
        ClientAdd.ShowDialog()
    End Sub
    Private Sub ClientListToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientListToolStripMenuItem1.Click
        ClientList.MdiParent = Me
        ClientList.Show()
    End Sub

    Private Sub AddNewClientToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewClientToolStripMenuItem1.Click
        ClientAdd.ShowDialog()
    End Sub

#End Region


#Region "Transaction"
    Private Sub TransactionHistoryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionHistoryToolStripMenuItem.Click
        TransactionList.MdiParent = Me
        TransactionList.Show()
    End Sub
    Private Sub AddNewTransactionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewTransactionToolStripMenuItem.Click
        TransactionAdd.Show()
    End Sub
    Private Sub TransactionListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TransactionListToolStripMenuItem.Click
        TransactionList.MdiParent = Me
        TransactionList.Show()
    End Sub

    Private Sub AddNewTransactionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddNewTransactionToolStripMenuItem1.Click
        TransactionAdd.Show()
    End Sub

#End Region

#Region "Help"

    Private Sub ViewHelpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem.Click
        About.ShowDialog()
    End Sub
    Private Sub ViewHelpToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewHelpToolStripMenuItem1.Click
        About.ShowDialog()
    End Sub

#End Region
End Class