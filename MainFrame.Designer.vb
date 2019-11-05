<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainFrame
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProductToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewVendorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewClientToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionHistoryToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductFlowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductInToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductListToolStripMenuItem, Me.AddNewProductToolStripMenuItem, Me.ProductFlowToolStripMenuItem})
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ProductToolStripMenuItem.Text = "&Products"
        '
        'ProductListToolStripMenuItem
        '
        Me.ProductListToolStripMenuItem.Name = "ProductListToolStripMenuItem"
        Me.ProductListToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ProductListToolStripMenuItem.Text = "Product &List"
        '
        'AddNewProductToolStripMenuItem
        '
        Me.AddNewProductToolStripMenuItem.Name = "AddNewProductToolStripMenuItem"
        Me.AddNewProductToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddNewProductToolStripMenuItem.Text = "Add &New Product"
        '
        'VendorToolStripMenuItem
        '
        Me.VendorToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendorListToolStripMenuItem, Me.AddNewVendorToolStripMenuItem})
        Me.VendorToolStripMenuItem.Name = "VendorToolStripMenuItem"
        Me.VendorToolStripMenuItem.Size = New System.Drawing.Size(76, 24)
        Me.VendorToolStripMenuItem.Text = "&Vendors"
        '
        'VendorListToolStripMenuItem
        '
        Me.VendorListToolStripMenuItem.Name = "VendorListToolStripMenuItem"
        Me.VendorListToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.VendorListToolStripMenuItem.Text = "Vendor &List"
        '
        'AddNewVendorToolStripMenuItem
        '
        Me.AddNewVendorToolStripMenuItem.Name = "AddNewVendorToolStripMenuItem"
        Me.AddNewVendorToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.AddNewVendorToolStripMenuItem.Text = "Add &New Vendor"
        '
        'ClientsToolStripMenuItem
        '
        Me.ClientsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientListToolStripMenuItem, Me.AddNewClientToolStripMenuItem})
        Me.ClientsToolStripMenuItem.Name = "ClientsToolStripMenuItem"
        Me.ClientsToolStripMenuItem.Size = New System.Drawing.Size(67, 24)
        Me.ClientsToolStripMenuItem.Text = "&Clients"
        '
        'ClientListToolStripMenuItem
        '
        Me.ClientListToolStripMenuItem.Name = "ClientListToolStripMenuItem"
        Me.ClientListToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.ClientListToolStripMenuItem.Text = "Client &List"
        '
        'AddNewClientToolStripMenuItem
        '
        Me.AddNewClientToolStripMenuItem.Name = "AddNewClientToolStripMenuItem"
        Me.AddNewClientToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.AddNewClientToolStripMenuItem.Text = "Add &New Client"
        '
        'TransactionToolStripMenuItem
        '
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionHistoryToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.TransactionToolStripMenuItem.Text = "&Transaction"
        '
        'TransactionHistoryToolStripMenuItem
        '
        Me.TransactionHistoryToolStripMenuItem.Name = "TransactionHistoryToolStripMenuItem"
        Me.TransactionHistoryToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.TransactionHistoryToolStripMenuItem.Text = "Transaction &History"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductToolStripMenuItem, Me.VendorToolStripMenuItem, Me.ClientsToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1169, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.SignOutToolStripMenuItem.Text = "&Sign Out"
        '
        'ProductFlowToolStripMenuItem
        '
        Me.ProductFlowToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductInToolStripMenuItem, Me.ProductOutToolStripMenuItem})
        Me.ProductFlowToolStripMenuItem.Name = "ProductFlowToolStripMenuItem"
        Me.ProductFlowToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ProductFlowToolStripMenuItem.Text = "Product &Flow"
        '
        'ProductInToolStripMenuItem
        '
        Me.ProductInToolStripMenuItem.Name = "ProductInToolStripMenuItem"
        Me.ProductInToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ProductInToolStripMenuItem.Text = "Product &In"
        '
        'ProductOutToolStripMenuItem
        '
        Me.ProductOutToolStripMenuItem.Name = "ProductOutToolStripMenuItem"
        Me.ProductOutToolStripMenuItem.Size = New System.Drawing.Size(224, 26)
        Me.ProductOutToolStripMenuItem.Text = "Product &Out"
        '
        'MainFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 755)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WareIT"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewProductToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewVendorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TransactionHistoryToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductFlowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductInToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductOutToolStripMenuItem As ToolStripMenuItem
End Class
