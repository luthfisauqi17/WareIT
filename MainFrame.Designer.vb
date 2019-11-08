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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainFrame))
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
        Me.AddNewTransactionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.currTimeLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.signoutBtn = New System.Windows.Forms.Button()
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ProductsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProductListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VendorListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewVendorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientsToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientListToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewClientToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TransactionListToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddNewTransactionToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.HelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewHelpToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProductToolStripMenuItem
        '
        Me.ProductToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductListToolStripMenuItem, Me.AddNewProductToolStripMenuItem})
        Me.ProductToolStripMenuItem.Name = "ProductToolStripMenuItem"
        Me.ProductToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.ProductToolStripMenuItem.Text = "&Products"
        '
        'ProductListToolStripMenuItem
        '
        Me.ProductListToolStripMenuItem.Name = "ProductListToolStripMenuItem"
        Me.ProductListToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
        Me.ProductListToolStripMenuItem.Text = "Product &List"
        '
        'AddNewProductToolStripMenuItem
        '
        Me.AddNewProductToolStripMenuItem.Name = "AddNewProductToolStripMenuItem"
        Me.AddNewProductToolStripMenuItem.Size = New System.Drawing.Size(209, 26)
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
        Me.VendorListToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
        Me.VendorListToolStripMenuItem.Text = "Vendor &List"
        '
        'AddNewVendorToolStripMenuItem
        '
        Me.AddNewVendorToolStripMenuItem.Name = "AddNewVendorToolStripMenuItem"
        Me.AddNewVendorToolStripMenuItem.Size = New System.Drawing.Size(205, 26)
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
        Me.TransactionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionHistoryToolStripMenuItem, Me.AddNewTransactionToolStripMenuItem})
        Me.TransactionToolStripMenuItem.Name = "TransactionToolStripMenuItem"
        Me.TransactionToolStripMenuItem.Size = New System.Drawing.Size(98, 24)
        Me.TransactionToolStripMenuItem.Text = "&Transaction"
        '
        'TransactionHistoryToolStripMenuItem
        '
        Me.TransactionHistoryToolStripMenuItem.Name = "TransactionHistoryToolStripMenuItem"
        Me.TransactionHistoryToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TransactionHistoryToolStripMenuItem.Text = "Transaction &History"
        '
        'AddNewTransactionToolStripMenuItem
        '
        Me.AddNewTransactionToolStripMenuItem.Name = "AddNewTransactionToolStripMenuItem"
        Me.AddNewTransactionToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.AddNewTransactionToolStripMenuItem.Text = "Add &New Transaction"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductToolStripMenuItem, Me.VendorToolStripMenuItem, Me.ClientsToolStripMenuItem, Me.TransactionToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1505, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(55, 24)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'ViewHelpToolStripMenuItem
        '
        Me.ViewHelpToolStripMenuItem.Name = "ViewHelpToolStripMenuItem"
        Me.ViewHelpToolStripMenuItem.Size = New System.Drawing.Size(160, 26)
        Me.ViewHelpToolStripMenuItem.Text = "&View Help"
        '
        'Splitter1
        '
        Me.Splitter1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Splitter1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Splitter1.Location = New System.Drawing.Point(0, 28)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(244, 757)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'currTimeLabel
        '
        Me.currTimeLabel.AutoSize = True
        Me.currTimeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.currTimeLabel.Location = New System.Drawing.Point(12, 363)
        Me.currTimeLabel.Name = "currTimeLabel"
        Me.currTimeLabel.Size = New System.Drawing.Size(154, 29)
        Me.currTimeLabel.TabIndex = 4
        Me.currTimeLabel.Text = "Current Time"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 32)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Welcome"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Current Time:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(221, 205)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'signoutBtn
        '
        Me.signoutBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.signoutBtn.Location = New System.Drawing.Point(12, 700)
        Me.signoutBtn.Name = "signoutBtn"
        Me.signoutBtn.Size = New System.Drawing.Size(209, 43)
        Me.signoutBtn.TabIndex = 9
        Me.signoutBtn.Text = "Sign Out"
        Me.signoutBtn.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(1481, 28)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(23, 757)
        Me.VScrollBar1.TabIndex = 10
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductsToolStripMenuItem, Me.VendorsToolStripMenuItem, Me.ClientsToolStripMenuItem1, Me.TransactionToolStripMenuItem1, Me.ToolStripSeparator1, Me.HelpToolStripMenuItem1})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(154, 130)
        '
        'ProductsToolStripMenuItem
        '
        Me.ProductsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProductListToolStripMenuItem1, Me.AddNewProductToolStripMenuItem1})
        Me.ProductsToolStripMenuItem.Name = "ProductsToolStripMenuItem"
        Me.ProductsToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.ProductsToolStripMenuItem.Text = "&Products"
        '
        'ProductListToolStripMenuItem1
        '
        Me.ProductListToolStripMenuItem1.Name = "ProductListToolStripMenuItem1"
        Me.ProductListToolStripMenuItem1.Size = New System.Drawing.Size(209, 26)
        Me.ProductListToolStripMenuItem1.Text = "Product &List"
        '
        'AddNewProductToolStripMenuItem1
        '
        Me.AddNewProductToolStripMenuItem1.Name = "AddNewProductToolStripMenuItem1"
        Me.AddNewProductToolStripMenuItem1.Size = New System.Drawing.Size(209, 26)
        Me.AddNewProductToolStripMenuItem1.Text = "Add &New Product"
        '
        'VendorsToolStripMenuItem
        '
        Me.VendorsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VendorListToolStripMenuItem1, Me.AddNewVendorToolStripMenuItem1})
        Me.VendorsToolStripMenuItem.Name = "VendorsToolStripMenuItem"
        Me.VendorsToolStripMenuItem.Size = New System.Drawing.Size(153, 24)
        Me.VendorsToolStripMenuItem.Text = "&Vendors"
        '
        'VendorListToolStripMenuItem1
        '
        Me.VendorListToolStripMenuItem1.Name = "VendorListToolStripMenuItem1"
        Me.VendorListToolStripMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.VendorListToolStripMenuItem1.Text = "Vendor &List"
        '
        'AddNewVendorToolStripMenuItem1
        '
        Me.AddNewVendorToolStripMenuItem1.Name = "AddNewVendorToolStripMenuItem1"
        Me.AddNewVendorToolStripMenuItem1.Size = New System.Drawing.Size(205, 26)
        Me.AddNewVendorToolStripMenuItem1.Text = "Add &New Vendor"
        '
        'ClientsToolStripMenuItem1
        '
        Me.ClientsToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientListToolStripMenuItem1, Me.AddNewClientToolStripMenuItem1})
        Me.ClientsToolStripMenuItem1.Name = "ClientsToolStripMenuItem1"
        Me.ClientsToolStripMenuItem1.Size = New System.Drawing.Size(153, 24)
        Me.ClientsToolStripMenuItem1.Text = "&Clients"
        '
        'ClientListToolStripMenuItem1
        '
        Me.ClientListToolStripMenuItem1.Name = "ClientListToolStripMenuItem1"
        Me.ClientListToolStripMenuItem1.Size = New System.Drawing.Size(196, 26)
        Me.ClientListToolStripMenuItem1.Text = "Client &List"
        '
        'AddNewClientToolStripMenuItem1
        '
        Me.AddNewClientToolStripMenuItem1.Name = "AddNewClientToolStripMenuItem1"
        Me.AddNewClientToolStripMenuItem1.Size = New System.Drawing.Size(196, 26)
        Me.AddNewClientToolStripMenuItem1.Text = "Add &New Client"
        '
        'TransactionToolStripMenuItem1
        '
        Me.TransactionToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionListToolStripMenuItem, Me.AddNewTransactionToolStripMenuItem1})
        Me.TransactionToolStripMenuItem1.Name = "TransactionToolStripMenuItem1"
        Me.TransactionToolStripMenuItem1.Size = New System.Drawing.Size(153, 24)
        Me.TransactionToolStripMenuItem1.Text = "&Transaction"
        '
        'TransactionListToolStripMenuItem
        '
        Me.TransactionListToolStripMenuItem.Name = "TransactionListToolStripMenuItem"
        Me.TransactionListToolStripMenuItem.Size = New System.Drawing.Size(233, 26)
        Me.TransactionListToolStripMenuItem.Text = "Transaction &History"
        '
        'AddNewTransactionToolStripMenuItem1
        '
        Me.AddNewTransactionToolStripMenuItem1.Name = "AddNewTransactionToolStripMenuItem1"
        Me.AddNewTransactionToolStripMenuItem1.Size = New System.Drawing.Size(233, 26)
        Me.AddNewTransactionToolStripMenuItem1.Text = "Add &New Transaction"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(150, 6)
        '
        'HelpToolStripMenuItem1
        '
        Me.HelpToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewHelpToolStripMenuItem1})
        Me.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1"
        Me.HelpToolStripMenuItem1.Size = New System.Drawing.Size(153, 24)
        Me.HelpToolStripMenuItem1.Text = "&Help"
        '
        'ViewHelpToolStripMenuItem1
        '
        Me.ViewHelpToolStripMenuItem1.Name = "ViewHelpToolStripMenuItem1"
        Me.ViewHelpToolStripMenuItem1.Size = New System.Drawing.Size(224, 26)
        Me.ViewHelpToolStripMenuItem1.Text = "&View Help"
        '
        'MainFrame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1505, 785)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.signoutBtn)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.currTimeLabel)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MainFrame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "WareIT"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
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
    Friend WithEvents ClientListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewClientToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewTransactionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Splitter1 As Splitter
    Friend WithEvents Timer1 As Timer
    Friend WithEvents currTimeLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents signoutBtn As Button
    Friend WithEvents VScrollBar1 As VScrollBar
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ProductsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProductListToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddNewProductToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents VendorsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientsToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransactionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VendorListToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddNewVendorToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ClientListToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents AddNewClientToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents TransactionListToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddNewTransactionToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents HelpToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ViewHelpToolStripMenuItem1 As ToolStripMenuItem
End Class
