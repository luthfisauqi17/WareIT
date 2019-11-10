<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ProductList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ProductList))
        Me.ProductListDataGridView = New System.Windows.Forms.DataGridView()
        Me.refreshProductListBtn = New System.Windows.Forms.Button()
        Me.loadProductListBtn = New System.Windows.Forms.Button()
        Me.toAddNewProductBtn = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.deleteProductBtn = New System.Windows.Forms.Button()
        Me.updateProductName = New System.Windows.Forms.TextBox()
        Me.updateProductId = New System.Windows.Forms.TextBox()
        Me.updateProductQty = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        CType(Me.ProductListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.updateProductQty, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProductListDataGridView
        '
        Me.ProductListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProductListDataGridView.Location = New System.Drawing.Point(311, 95)
        Me.ProductListDataGridView.Name = "ProductListDataGridView"
        Me.ProductListDataGridView.ReadOnly = True
        Me.ProductListDataGridView.RowHeadersWidth = 51
        Me.ProductListDataGridView.RowTemplate.Height = 24
        Me.ProductListDataGridView.Size = New System.Drawing.Size(819, 514)
        Me.ProductListDataGridView.TabIndex = 1
        '
        'refreshProductListBtn
        '
        Me.refreshProductListBtn.Location = New System.Drawing.Point(145, 30)
        Me.refreshProductListBtn.Name = "refreshProductListBtn"
        Me.refreshProductListBtn.Size = New System.Drawing.Size(127, 44)
        Me.refreshProductListBtn.TabIndex = 2
        Me.refreshProductListBtn.Text = "Refresh Table"
        Me.ToolTip1.SetToolTip(Me.refreshProductListBtn, "Refresh Table")
        Me.refreshProductListBtn.UseVisualStyleBackColor = True
        '
        'loadProductListBtn
        '
        Me.loadProductListBtn.Location = New System.Drawing.Point(12, 30)
        Me.loadProductListBtn.Name = "loadProductListBtn"
        Me.loadProductListBtn.Size = New System.Drawing.Size(127, 44)
        Me.loadProductListBtn.TabIndex = 3
        Me.loadProductListBtn.Text = "Load Table"
        Me.ToolTip1.SetToolTip(Me.loadProductListBtn, "Load Table")
        Me.loadProductListBtn.UseVisualStyleBackColor = True
        '
        'toAddNewProductBtn
        '
        Me.toAddNewProductBtn.Location = New System.Drawing.Point(1003, 30)
        Me.toAddNewProductBtn.Name = "toAddNewProductBtn"
        Me.toAddNewProductBtn.Size = New System.Drawing.Size(127, 44)
        Me.toAddNewProductBtn.TabIndex = 5
        Me.toAddNewProductBtn.Text = "Add New Product"
        Me.ToolTip1.SetToolTip(Me.toAddNewProductBtn, "Add New Product")
        Me.toAddNewProductBtn.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1142, 27)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewToolStripButton
        '
        Me.NewToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewToolStripButton.Image = CType(resources.GetObject("NewToolStripButton.Image"), System.Drawing.Image)
        Me.NewToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewToolStripButton.Name = "NewToolStripButton"
        Me.NewToolStripButton.Size = New System.Drawing.Size(29, 24)
        Me.NewToolStripButton.Text = "&New"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 619)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1142, 24)
        Me.StatusStrip1.TabIndex = 7
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Step = 100
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.deleteProductBtn)
        Me.GroupBox1.Controls.Add(Me.updateProductName)
        Me.GroupBox1.Controls.Add(Me.updateProductId)
        Me.GroupBox1.Controls.Add(Me.updateProductQty)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.updateBtn)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(293, 514)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'deleteProductBtn
        '
        Me.deleteProductBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteProductBtn.Location = New System.Drawing.Point(12, 444)
        Me.deleteProductBtn.Name = "deleteProductBtn"
        Me.deleteProductBtn.Size = New System.Drawing.Size(281, 64)
        Me.deleteProductBtn.TabIndex = 7
        Me.deleteProductBtn.Text = "Delete Data"
        Me.ToolTip1.SetToolTip(Me.deleteProductBtn, "Delete Data")
        Me.deleteProductBtn.UseVisualStyleBackColor = True
        '
        'updateProductName
        '
        Me.updateProductName.Location = New System.Drawing.Point(153, 86)
        Me.updateProductName.Name = "updateProductName"
        Me.updateProductName.Size = New System.Drawing.Size(100, 22)
        Me.updateProductName.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.updateProductName, "Fill in the Product Name")
        '
        'updateProductId
        '
        Me.updateProductId.Location = New System.Drawing.Point(153, 31)
        Me.updateProductId.Name = "updateProductId"
        Me.updateProductId.Size = New System.Drawing.Size(100, 22)
        Me.updateProductId.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.updateProductId, "Fill in the Product Id")
        '
        'updateProductQty
        '
        Me.updateProductQty.Location = New System.Drawing.Point(153, 159)
        Me.updateProductQty.Name = "updateProductQty"
        Me.updateProductQty.Size = New System.Drawing.Size(120, 22)
        Me.updateProductQty.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.updateProductQty, "Fill in the product Quantity")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(139, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Product Quantity:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(121, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Product Id:"
        '
        'updateBtn
        '
        Me.updateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(11, 374)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(281, 64)
        Me.updateBtn.TabIndex = 0
        Me.updateBtn.Text = "Update Data"
        Me.ToolTip1.SetToolTip(Me.updateBtn, "Update Data")
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'ProductList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 643)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.toAddNewProductBtn)
        Me.Controls.Add(Me.loadProductListBtn)
        Me.Controls.Add(Me.refreshProductListBtn)
        Me.Controls.Add(Me.ProductListDataGridView)
        Me.Name = "ProductList"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProductList"
        CType(Me.ProductListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.updateProductQty, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ProductListDataGridView As DataGridView
    Friend WithEvents refreshProductListBtn As Button
    Friend WithEvents loadProductListBtn As Button
    Friend WithEvents toAddNewProductBtn As Button
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents updateProductName As TextBox
    Friend WithEvents updateProductId As TextBox
    Friend WithEvents updateProductQty As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents deleteProductBtn As Button
End Class
