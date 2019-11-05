Public Class MainFrame

    Private Sub ProductListToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles ProductListToolStripMenuItem.Click
        ProductList.MdiParent = Me
        ProductList.Show()
    End Sub

    Private Sub SignOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SignOutToolStripMenuItem.Click
        Login.Show()
        Me.Hide()
    End Sub

    Private Sub AddNewProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewProductToolStripMenuItem.Click
        ProductAdd.ShowDialog()
    End Sub

    Private Sub AddNewVendorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewVendorToolStripMenuItem.Click
        VendorAdd.ShowDialog()
    End Sub

    Private Sub VendorListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VendorListToolStripMenuItem.Click
        VendorList.MdiParent = Me
        VendorList.Show()
    End Sub

    Private Sub ClientListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientListToolStripMenuItem.Click
        ClientList.MdiParent = Me
        ClientList.Show()
    End Sub

    Private Sub AddNewClientToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddNewClientToolStripMenuItem.Click
        ClientAdd.ShowDialog()
    End Sub
End Class