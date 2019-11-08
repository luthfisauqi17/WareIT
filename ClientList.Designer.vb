<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ClientList))
        Me.NewToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.loadClientListBtn = New System.Windows.Forms.Button()
        Me.refreshClientListBtn = New System.Windows.Forms.Button()
        Me.VendorListDataGridView = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.toAddNewClientBtn = New System.Windows.Forms.Button()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.deleteBtn = New System.Windows.Forms.Button()
        Me.updateClientName = New System.Windows.Forms.TextBox()
        Me.updateClientId = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.updateBtn = New System.Windows.Forms.Button()
        CType(Me.VendorListDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        'loadClientListBtn
        '
        Me.loadClientListBtn.Location = New System.Drawing.Point(12, 30)
        Me.loadClientListBtn.Name = "loadClientListBtn"
        Me.loadClientListBtn.Size = New System.Drawing.Size(127, 44)
        Me.loadClientListBtn.TabIndex = 14
        Me.loadClientListBtn.Text = "Load Table"
        Me.loadClientListBtn.UseVisualStyleBackColor = True
        '
        'refreshClientListBtn
        '
        Me.refreshClientListBtn.Location = New System.Drawing.Point(145, 30)
        Me.refreshClientListBtn.Name = "refreshClientListBtn"
        Me.refreshClientListBtn.Size = New System.Drawing.Size(127, 44)
        Me.refreshClientListBtn.TabIndex = 13
        Me.refreshClientListBtn.Text = "Refresh Table"
        Me.refreshClientListBtn.UseVisualStyleBackColor = True
        '
        'VendorListDataGridView
        '
        Me.VendorListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VendorListDataGridView.Location = New System.Drawing.Point(311, 80)
        Me.VendorListDataGridView.Name = "VendorListDataGridView"
        Me.VendorListDataGridView.ReadOnly = True
        Me.VendorListDataGridView.RowHeadersWidth = 51
        Me.VendorListDataGridView.RowTemplate.Height = 24
        Me.VendorListDataGridView.Size = New System.Drawing.Size(819, 512)
        Me.VendorListDataGridView.TabIndex = 12
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1142, 27)
        Me.ToolStrip1.TabIndex = 17
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'toAddNewClientBtn
        '
        Me.toAddNewClientBtn.Location = New System.Drawing.Point(1003, 30)
        Me.toAddNewClientBtn.Name = "toAddNewClientBtn"
        Me.toAddNewClientBtn.Size = New System.Drawing.Size(127, 44)
        Me.toAddNewClientBtn.TabIndex = 16
        Me.toAddNewClientBtn.Text = "Add New Client"
        Me.toAddNewClientBtn.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 619)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1142, 24)
        Me.StatusStrip1.TabIndex = 18
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
        Me.GroupBox2.Controls.Add(Me.updateClientName)
        Me.GroupBox2.Controls.Add(Me.updateClientId)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.updateBtn)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(293, 512)
        Me.GroupBox2.TabIndex = 19
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
        Me.deleteBtn.UseVisualStyleBackColor = True
        '
        'updateClientName
        '
        Me.updateClientName.Location = New System.Drawing.Point(153, 86)
        Me.updateClientName.Name = "updateClientName"
        Me.updateClientName.Size = New System.Drawing.Size(100, 22)
        Me.updateClientName.TabIndex = 6
        '
        'updateClientId
        '
        Me.updateClientId.Location = New System.Drawing.Point(153, 31)
        Me.updateClientId.Name = "updateClientId"
        Me.updateClientId.Size = New System.Drawing.Size(100, 22)
        Me.updateClientId.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 88)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Client Name:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Client Id:"
        '
        'updateBtn
        '
        Me.updateBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.updateBtn.Location = New System.Drawing.Point(5, 372)
        Me.updateBtn.Name = "updateBtn"
        Me.updateBtn.Size = New System.Drawing.Size(281, 64)
        Me.updateBtn.TabIndex = 0
        Me.updateBtn.Text = "Update Data"
        Me.updateBtn.UseVisualStyleBackColor = True
        '
        'ClientList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1142, 643)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.loadClientListBtn)
        Me.Controls.Add(Me.refreshClientListBtn)
        Me.Controls.Add(Me.VendorListDataGridView)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.toAddNewClientBtn)
        Me.Name = "ClientList"
        Me.Text = "ClientList"
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
    Friend WithEvents NewToolStripButton As ToolStripButton
    Friend WithEvents loadClientListBtn As Button
    Friend WithEvents refreshClientListBtn As Button
    Friend WithEvents VendorListDataGridView As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents toAddNewClientBtn As Button
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents Timer1 As Timer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents deleteBtn As Button
    Friend WithEvents updateClientName As TextBox
    Friend WithEvents updateClientId As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents updateBtn As Button
End Class
