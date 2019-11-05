<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProductAdd
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.vendorComboBox = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.productDescTextBox = New System.Windows.Forms.TextBox()
        Me.productBuyRateMaskTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.productIdTextBox = New System.Windows.Forms.TextBox()
        Me.productNameTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addProductBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.vendorComboBox)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.productDescTextBox)
        Me.GroupBox1.Controls.Add(Me.productBuyRateMaskTextBox)
        Me.GroupBox1.Controls.Add(Me.productIdTextBox)
        Me.GroupBox1.Controls.Add(Me.productNameTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(458, 422)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'vendorComboBox
        '
        Me.vendorComboBox.FormattingEnabled = True
        Me.vendorComboBox.Location = New System.Drawing.Point(116, 107)
        Me.vendorComboBox.Name = "vendorComboBox"
        Me.vendorComboBox.Size = New System.Drawing.Size(121, 24)
        Me.vendorComboBox.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 107)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 17)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Vendor:"
        '
        'productDescTextBox
        '
        Me.productDescTextBox.Location = New System.Drawing.Point(10, 253)
        Me.productDescTextBox.Multiline = True
        Me.productDescTextBox.Name = "productDescTextBox"
        Me.productDescTextBox.Size = New System.Drawing.Size(442, 155)
        Me.productDescTextBox.TabIndex = 9
        '
        'productBuyRateMaskTextBox
        '
        Me.productBuyRateMaskTextBox.Location = New System.Drawing.Point(116, 149)
        Me.productBuyRateMaskTextBox.Name = "productBuyRateMaskTextBox"
        Me.productBuyRateMaskTextBox.Size = New System.Drawing.Size(117, 22)
        Me.productBuyRateMaskTextBox.TabIndex = 7
        '
        'productIdTextBox
        '
        Me.productIdTextBox.Location = New System.Drawing.Point(116, 22)
        Me.productIdTextBox.Name = "productIdTextBox"
        Me.productIdTextBox.Size = New System.Drawing.Size(247, 22)
        Me.productIdTextBox.TabIndex = 6
        '
        'productNameTextBox
        '
        Me.productNameTextBox.Location = New System.Drawing.Point(116, 61)
        Me.productNameTextBox.Name = "productNameTextBox"
        Me.productNameTextBox.Size = New System.Drawing.Size(247, 22)
        Me.productNameTextBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 233)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Description:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Buy Rate:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(7, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(102, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Product Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Product Id:"
        '
        'addProductBtn
        '
        Me.addProductBtn.Location = New System.Drawing.Point(22, 449)
        Me.addProductBtn.Name = "addProductBtn"
        Me.addProductBtn.Size = New System.Drawing.Size(161, 55)
        Me.addProductBtn.TabIndex = 1
        Me.addProductBtn.Text = "Insert Data"
        Me.addProductBtn.UseVisualStyleBackColor = True
        '
        'ProductAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 516)
        Me.Controls.Add(Me.addProductBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ProductAdd"
        Me.Text = "ProductAdd"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents productDescTextBox As TextBox
    Friend WithEvents productBuyRateMaskTextBox As MaskedTextBox
    Friend WithEvents productIdTextBox As TextBox
    Friend WithEvents productNameTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents addProductBtn As Button
    Friend WithEvents vendorComboBox As ComboBox
    Friend WithEvents Label6 As Label
End Class
