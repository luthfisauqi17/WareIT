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
        Me.totPriceGroupBox = New System.Windows.Forms.GroupBox()
        Me.totalPriceLabel = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.availabilityCheckBtn = New System.Windows.Forms.Button()
        Me.customQtyRb = New System.Windows.Forms.RadioButton()
        Me.fixedQtyRb = New System.Windows.Forms.RadioButton()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.qtyCheckboxList = New System.Windows.Forms.CheckedListBox()
        Me.customQtyGroupBox = New System.Windows.Forms.GroupBox()
        Me.qtyNumUpDown = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.generateReportCheckBox = New System.Windows.Forms.CheckBox()
        Me.proceedBtn = New System.Windows.Forms.Button()
        Me.notesTextBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.productIdComboBox = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.productOutOpt = New System.Windows.Forms.GroupBox()
        Me.clientIdListBox = New System.Windows.Forms.ListBox()
        Me.poNumberTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.transactionDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.clrBtn = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.selectedItemLabel = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.totPriceGroupBox.SuspendLayout()
        Me.customQtyGroupBox.SuspendLayout()
        CType(Me.qtyNumUpDown, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.productOutOpt.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.selectedItemLabel)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.clrBtn)
        Me.GroupBox3.Controls.Add(Me.totPriceGroupBox)
        Me.GroupBox3.Controls.Add(Me.availabilityCheckBtn)
        Me.GroupBox3.Controls.Add(Me.customQtyRb)
        Me.GroupBox3.Controls.Add(Me.fixedQtyRb)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.qtyCheckboxList)
        Me.GroupBox3.Controls.Add(Me.customQtyGroupBox)
        Me.GroupBox3.Controls.Add(Me.generateReportCheckBox)
        Me.GroupBox3.Controls.Add(Me.proceedBtn)
        Me.GroupBox3.Controls.Add(Me.notesTextBox)
        Me.GroupBox3.Controls.Add(Me.Label6)
        Me.GroupBox3.Controls.Add(Me.productIdComboBox)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.productOutOpt)
        Me.GroupBox3.Controls.Add(Me.transactionDatePicker)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(868, 511)
        Me.GroupBox3.TabIndex = 14
        Me.GroupBox3.TabStop = False
        '
        'totPriceGroupBox
        '
        Me.totPriceGroupBox.Controls.Add(Me.totalPriceLabel)
        Me.totPriceGroupBox.Controls.Add(Me.Label7)
        Me.totPriceGroupBox.Location = New System.Drawing.Point(511, 258)
        Me.totPriceGroupBox.Name = "totPriceGroupBox"
        Me.totPriceGroupBox.Size = New System.Drawing.Size(351, 74)
        Me.totPriceGroupBox.TabIndex = 35
        Me.totPriceGroupBox.TabStop = False
        '
        'totalPriceLabel
        '
        Me.totalPriceLabel.AutoSize = True
        Me.totalPriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalPriceLabel.Location = New System.Drawing.Point(159, 18)
        Me.totalPriceLabel.Name = "totalPriceLabel"
        Me.totalPriceLabel.Size = New System.Drawing.Size(58, 29)
        Me.totalPriceLabel.TabIndex = 28
        Me.totalPriceLabel.Text = "Rp.-"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(17, 18)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 29)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Total Price:"
        '
        'availabilityCheckBtn
        '
        Me.availabilityCheckBtn.Location = New System.Drawing.Point(303, 183)
        Me.availabilityCheckBtn.Name = "availabilityCheckBtn"
        Me.availabilityCheckBtn.Size = New System.Drawing.Size(130, 54)
        Me.availabilityCheckBtn.TabIndex = 34
        Me.availabilityCheckBtn.Text = "Check Availability"
        Me.availabilityCheckBtn.UseVisualStyleBackColor = True
        '
        'customQtyRb
        '
        Me.customQtyRb.AutoSize = True
        Me.customQtyRb.Location = New System.Drawing.Point(162, 150)
        Me.customQtyRb.Name = "customQtyRb"
        Me.customQtyRb.Size = New System.Drawing.Size(133, 21)
        Me.customQtyRb.TabIndex = 33
        Me.customQtyRb.TabStop = True
        Me.customQtyRb.Text = "Custom Quantity"
        Me.customQtyRb.UseVisualStyleBackColor = True
        '
        'fixedQtyRb
        '
        Me.fixedQtyRb.AutoSize = True
        Me.fixedQtyRb.Location = New System.Drawing.Point(41, 150)
        Me.fixedQtyRb.Name = "fixedQtyRb"
        Me.fixedQtyRb.Size = New System.Drawing.Size(119, 21)
        Me.fixedQtyRb.TabIndex = 32
        Me.fixedQtyRb.TabStop = True
        Me.fixedQtyRb.Text = "Fixed Quantity"
        Me.fixedQtyRb.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(38, 130)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 17)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Quantity: "
        '
        'qtyCheckboxList
        '
        Me.qtyCheckboxList.FormattingEnabled = True
        Me.qtyCheckboxList.Items.AddRange(New Object() {"5 Items", "10 Items", "15 Items", "20 Items", "25 Items"})
        Me.qtyCheckboxList.Location = New System.Drawing.Point(41, 177)
        Me.qtyCheckboxList.Name = "qtyCheckboxList"
        Me.qtyCheckboxList.Size = New System.Drawing.Size(120, 89)
        Me.qtyCheckboxList.TabIndex = 29
        '
        'customQtyGroupBox
        '
        Me.customQtyGroupBox.Controls.Add(Me.qtyNumUpDown)
        Me.customQtyGroupBox.Controls.Add(Me.Label5)
        Me.customQtyGroupBox.Location = New System.Drawing.Point(41, 177)
        Me.customQtyGroupBox.Name = "customQtyGroupBox"
        Me.customQtyGroupBox.Size = New System.Drawing.Size(255, 100)
        Me.customQtyGroupBox.TabIndex = 28
        Me.customQtyGroupBox.TabStop = False
        '
        'qtyNumUpDown
        '
        Me.qtyNumUpDown.Location = New System.Drawing.Point(126, 38)
        Me.qtyNumUpDown.Name = "qtyNumUpDown"
        Me.qtyNumUpDown.Size = New System.Drawing.Size(120, 22)
        Me.qtyNumUpDown.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 17)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Product Quantity:"
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
        'proceedBtn
        '
        Me.proceedBtn.Location = New System.Drawing.Point(557, 382)
        Me.proceedBtn.Name = "proceedBtn"
        Me.proceedBtn.Size = New System.Drawing.Size(227, 65)
        Me.proceedBtn.TabIndex = 27
        Me.proceedBtn.Text = "Proceed"
        Me.proceedBtn.UseVisualStyleBackColor = True
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
        Me.productOutOpt.Controls.Add(Me.clientIdListBox)
        Me.productOutOpt.Controls.Add(Me.poNumberTextBox)
        Me.productOutOpt.Controls.Add(Me.Label3)
        Me.productOutOpt.Controls.Add(Me.Label2)
        Me.productOutOpt.Location = New System.Drawing.Point(465, 40)
        Me.productOutOpt.Name = "productOutOpt"
        Me.productOutOpt.Size = New System.Drawing.Size(351, 136)
        Me.productOutOpt.TabIndex = 18
        Me.productOutOpt.TabStop = False
        '
        'clientIdListBox
        '
        Me.clientIdListBox.FormattingEnabled = True
        Me.clientIdListBox.ItemHeight = 16
        Me.clientIdListBox.Location = New System.Drawing.Point(97, 18)
        Me.clientIdListBox.Name = "clientIdListBox"
        Me.clientIdListBox.Size = New System.Drawing.Size(248, 36)
        Me.clientIdListBox.TabIndex = 7
        '
        'poNumberTextBox
        '
        Me.poNumberTextBox.Location = New System.Drawing.Point(97, 74)
        Me.poNumberTextBox.Name = "poNumberTextBox"
        Me.poNumberTextBox.Size = New System.Drawing.Size(100, 22)
        Me.poNumberTextBox.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "PO number:"
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
        'transactionDatePicker
        '
        Me.transactionDatePicker.CustomFormat = "yyyy-MM-dd"
        Me.transactionDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.transactionDatePicker.Location = New System.Drawing.Point(166, 38)
        Me.transactionDatePicker.Name = "transactionDatePicker"
        Me.transactionDatePicker.Size = New System.Drawing.Size(200, 22)
        Me.transactionDatePicker.TabIndex = 17
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
        'clrBtn
        '
        Me.clrBtn.Location = New System.Drawing.Point(303, 244)
        Me.clrBtn.Name = "clrBtn"
        Me.clrBtn.Size = New System.Drawing.Size(130, 33)
        Me.clrBtn.TabIndex = 36
        Me.clrBtn.Text = "Clear Items"
        Me.clrBtn.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(511, 206)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(104, 17)
        Me.Label9.TabIndex = 37
        Me.Label9.Text = "Selected items:"
        '
        'selectedItemLabel
        '
        Me.selectedItemLabel.AutoSize = True
        Me.selectedItemLabel.Location = New System.Drawing.Point(621, 206)
        Me.selectedItemLabel.Name = "selectedItemLabel"
        Me.selectedItemLabel.Size = New System.Drawing.Size(13, 17)
        Me.selectedItemLabel.TabIndex = 38
        Me.selectedItemLabel.Text = "-"
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
        Me.totPriceGroupBox.ResumeLayout(False)
        Me.totPriceGroupBox.PerformLayout()
        Me.customQtyGroupBox.ResumeLayout(False)
        Me.customQtyGroupBox.PerformLayout()
        CType(Me.qtyNumUpDown, System.ComponentModel.ISupportInitialize).EndInit()
        Me.productOutOpt.ResumeLayout(False)
        Me.productOutOpt.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents generateReportCheckBox As CheckBox
    Friend WithEvents proceedBtn As Button
    Friend WithEvents notesTextBox As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents productIdComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents productOutOpt As GroupBox
    Friend WithEvents poNumberTextBox As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents transactionDatePicker As DateTimePicker
    Friend WithEvents Label1 As Label
    Friend WithEvents customQtyGroupBox As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents qtyCheckboxList As CheckedListBox
    Friend WithEvents customQtyRb As RadioButton
    Friend WithEvents fixedQtyRb As RadioButton
    Friend WithEvents clientIdListBox As ListBox
    Friend WithEvents qtyNumUpDown As NumericUpDown
    Friend WithEvents availabilityCheckBtn As Button
    Friend WithEvents totPriceGroupBox As GroupBox
    Friend WithEvents totalPriceLabel As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents clrBtn As Button
    Friend WithEvents selectedItemLabel As Label
    Friend WithEvents Label9 As Label
End Class
