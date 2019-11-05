<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionAdd
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
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.generateReportCheckBox = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.notesTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.productQtyComboBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.productIdComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.productOutOpt = New System.Windows.Forms.GroupBox()
        Me.poNumberTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.soldToComboBox = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.productOutRb = New System.Windows.Forms.RadioButton()
        Me.productInRb = New System.Windows.Forms.RadioButton()
        Me.GroupBox3.SuspendLayout()
        Me.productOutOpt.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.generateReportCheckBox)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.totalPriceLabel)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.notesTextBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.productQtyComboBox)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.productIdComboBox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.productOutOpt)
        Me.GroupBox3.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.GroupBox1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(868, 511)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'generateReportCheckBox
        '
        Me.generateReportCheckBox.Location = New System.Drawing.Point(557, 355)
        Me.generateReportCheckBox.Name = "generateReportCheckBox"
        Me.generateReportCheckBox.Size = New System.Drawing.Size(137, 21)
        Me.generateReportCheckBox.TabIndex = 14
        Me.generateReportCheckBox.Text = "Generate Report"
        Me.generateReportCheckBox.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(557, 382)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(227, 65)
        Me.Button1.TabIndex = 27
        Me.Button1.Text = "Proceed"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.AutoSize = True
        Me.totalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPriceLabel.Location = New System.Drawing.Point(180, 183)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(58, 29)
        Me.totalPriceLabel.TabIndex = 26
        Me.totalPriceLabel.Text = "Rp.-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(38, 183)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 29)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Total Price:"
        '
        'notesTextBox
        '
        Me.notesTextBox.Location = New System.Drawing.Point(41, 296)
        Me.notesTextBox.Multiline = True
        Me.notesTextBox.Name = "notesTextBox"
        Me.notesTextBox.Size = New System.Drawing.Size(464, 151)
        Me.notesTextBox.TabIndex = 24
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(38, 275)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(49, 17)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Notes:"
        '
        'productQtyComboBox
        '
        Me.productQtyComboBox.Location = New System.Drawing.Point(166, 116)
        Me.productQtyComboBox.Name = "productQtyComboBox"
        Me.productQtyComboBox.Size = New System.Drawing.Size(100, 22)
        Me.productQtyComboBox.TabIndex = 22
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(38, 116)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 17)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Product Quantity:"
        '
        'productIdComboBox
        '
        Me.productIdComboBox.FormattingEnabled = True
        Me.productIdComboBox.Location = New System.Drawing.Point(166, 76)
        Me.productIdComboBox.Name = "productIdComboBox"
        Me.productIdComboBox.Size = New System.Drawing.Size(200, 24)
        Me.productIdComboBox.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(38, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Product Id:"
        '
        'productOutOpt
        '
        Me.productOutOpt.Controls.Add(Me.poNumberTextBox)
        Me.productOutOpt.Controls.Add(Me.Label3)
        Me.productOutOpt.Controls.Add(Me.soldToComboBox)
        Me.productOutOpt.Controls.Add(Me.Label2)
        Me.productOutOpt.Location = New System.Drawing.Point(460, 116)
        Me.productOutOpt.Name = "productOutOpt"
        Me.productOutOpt.Size = New System.Drawing.Size(351, 96)
        Me.productOutOpt.TabIndex = 18
        Me.productOutOpt.TabStop = False
        '
        'poNumberTextBox
        '
        Me.poNumberTextBox.Location = New System.Drawing.Point(97, 50)
        Me.poNumberTextBox.Name = "poNumberTextBox"
        Me.poNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.poNumberTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 50)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PO number:"
        '
        'soldToComboBox
        '
        Me.soldToComboBox.FormattingEnabled = True
        Me.soldToComboBox.Location = New System.Drawing.Point(97, 18)
        Me.soldToComboBox.Name = "soldToComboBox"
        Me.soldToComboBox.Size = New System.Drawing.Size(227, 24)
        Me.soldToComboBox.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Sold To:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(166, 38)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(35, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Transaction Date:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.productOutRb)
        Me.GroupBox1.Controls.Add(Me.productInRb)
        Me.GroupBox1.Location = New System.Drawing.Point(460, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 90)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        '
        'productOutRb
        '
        Me.productOutRb.AutoSize = True
        Me.productOutRb.Location = New System.Drawing.Point(5, 48)
        Me.productOutRb.Name = "productOutRb"
        Me.productOutRb.Size = New System.Drawing.Size(105, 21)
        Me.productOutRb.TabIndex = 1
        Me.productOutRb.TabStop = True
        Me.productOutRb.Text = "Product Out"
        Me.productOutRb.UseVisualStyleBackColor = True
        '
        'productInRb
        '
        Me.productInRb.AutoSize = True
        Me.productInRb.Location = New System.Drawing.Point(6, 21)
        Me.productInRb.Name = "productInRb"
        Me.productInRb.Size = New System.Drawing.Size(93, 21)
        Me.productInRb.TabIndex = 0
        Me.productInRb.TabStop = True
        Me.productInRb.Text = "Product In"
        Me.productInRb.UseVisualStyleBackColor = True
        '
        'TransactionAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(892, 535)
        Me.Controls.Add(Me.GroupBox3)
        Me.Name = "TransactionAdd"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TransactionAdd"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.productOutOpt.ResumeLayout(False)
        Me.productOutOpt.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents generateReportCheckBox As CheckBox
    Friend WithEvents Button1 As Button
    Friend WithEvents totalPriceLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents notesTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents productQtyComboBox As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents productIdComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents productOutOpt As GroupBox
    Friend WithEvents poNumberTextBox As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents soldToComboBox As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents productOutRb As RadioButton
    Friend WithEvents productInRb As RadioButton
End Class
