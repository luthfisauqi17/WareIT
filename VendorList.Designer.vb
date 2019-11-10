<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VendorList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VendorList))
        Me.toAddNewVendorBtn = New System.Windows.Forms.Button()
        Me.loadVendorListBtn = New System.Windows.Forms.Button()
        Me.refreshVendorListBtn = New System.Windows.Forms.Button()
        Me.VendorListDataGridView = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.updateVendorName = New System.Windows.Forms.TextBox()
        Me.updateVendorId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.VendorListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'toAddNewVendorBtn
        '
        Me.toAddNewVendorBtn.Location = New System.Drawing.Point(1003, 33)
        Me.toAddNewVendorBtn.Name = "toAddNewVendorBtn"
        Me.toAddNewVendorBtn.Size = New System.Drawing.Size(127, 44)
        Me.toAddNewVendorBtn.TabIndex = 10
        Me.toAddNewVendorBtn.Text = "Add New Vendor"
        Me.ToolTip1.SetToolTip(Me.toAddNewVendorBtn, "Add New Vendor")
        Me.toAddNewVendorBtn.UseVisualStyleBackColor = True
        '
        'loadVendorListBtn
        '
        Me.loadVendorListBtn.Location = New System.Drawing.Point(12, 30)
        Me.loadVendorListBtn.Name = "loadVendorListBtn"
        Me.loadVendorListBtn.Size = New System.Drawing.Size(127, 44)
        Me.loadVendorListBtn.TabIndex = 8
        Me.loadVendorListBtn.Text = "Load Table"
        Me.ToolTip1.SetToolTip(Me.loadVendorListBtn, "Load Table")
        Me.loadVendorListBtn.UseVisualStyleBackColor = True
        '
        'refreshVendorListBtn
        '
        Me.refreshVendorListBtn.Location = New System.Drawing.Point(145, 30)
        Me.refreshVendorListBtn.Name = "refreshVendorListBtn"
        Me.refreshVendorListBtn.Size = New System.Drawing.Size(127, 44)
        Me.refreshVendorListBtn.TabIndex = 7
        Me.refreshVendorListBtn.Text = "Refresh Table"
        Me.ToolTip1.SetToolTip(Me.refreshVendorListBtn, "Refresh Table")
        Me.refreshVendorListBtn.UseVisualStyleBackColor = True
        '
        'VendorListDataGridView
        '
        Me.VendorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendorListDataGridView.Location = New System.Drawing.Point(311, 83)
        Me.VendorListDataGridView.Name = "VendorListDataGridView"
        Me.VendorListDataGridView.ReadOnly = True
        Me.VendorListDataGridView.RowHeadersWidth = 51
        Me.VendorListDataGridView.RowTemplate.Height = 24
        Me.VendorListDataGridView.Size = New System.Drawing.Size(819, 524)
        Me.VendorListDataGridView.TabIndex = 6
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1142, 27)
        Me.ToolStrip1.TabIndex = 11
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
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Step = 100
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.deleteBtn)
        Me.GroupBox2.Controls.Add(Me.updateVendorName)
        Me.GroupBox2.Controls.Add(Me.updateVendorId)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.updateBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 83)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 524)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        '
        'deleteBtn
        '
        Me.deleteBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.deleteBtn.Location = New System.Drawing.Point(6, 442)
        Me.deleteBtn.Name = "deleteBtn"
        Me.deleteBtn.Size = New System.Drawing.Size(281, 64)
        Me.deleteBtn.TabIndex = 7
        Me.deleteBtn.Text = "Delete Data"
        Me.ToolTip1.SetToolTip(Me.deleteBtn, "Delete Data")
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'updateVendorName
        '
        Me.updateVendorName.Location = New System.Drawing.Point(153, 86)
        Me.updateVendorName.Name = "updateVendorName"
        Me.updateVendorName.Size = New System.Drawing.Size(100, 22)
        Me.updateVendorName.TabIndex = 6
        '
        'updateVendorId
        '
        Me.updateVendorId.Location = New System.Drawing.Point(153, 31)
        Me.updateVendorId.Name = "updateVendorId"
        Me.updateVendorId.Size = New System.Drawing.Size(100, 22)
        Me.updateVendorId.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Vendor Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Vendor Id:"
        '
        'updateBtn
        '
        Me.updateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(5, 372)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(281, 64)
        Me.updateBtn.TabIndex = 0
        Me.updateBtn.Text = "Update Data"
        Me.ToolTip1.SetToolTip(Me.updateBtn, "Update Data")
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'VendorList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 643)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.toAddNewVendorBtn)
        Me.Controls.Add(Me.loadVendorListBtn)
        Me.Controls.Add(Me.refreshVendorListBtn)
        Me.Controls.Add(Me.VendorListDataGridView)
        Me.Name = "VendorList"
        Me.Text = "VendorList"
        CType(Me.VendorListDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents toAddNewVendorBtn As Button
    Friend WithEvents loadVendorListBtn As Button
    Friend WithEvents refreshVendorListBtn As Button
    Friend WithEvents VendorListDataGridView As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateVendorName As TextBox
    Friend WithEvents updateVendorId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents updateBtn As Button
    Friend WithEvents ToolTip1 As ToolTip
End Class
