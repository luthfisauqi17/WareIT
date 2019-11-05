<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClientAdd
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
        Me.clientPhoneTextBox = New System.Windows.Forms.TextBox()
        Me.clientEmailTextBox = New System.Windows.Forms.TextBox()
        Me.clientNameTextBox = New System.Windows.Forms.TextBox()
        Me.clientIdTextBox = New System.Windows.Forms.TextBox()
        Me.clientAddressTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.addClientBtn = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.clientPhoneTextBox)
        Me.GroupBox1.Controls.Add(Me.clientEmailTextBox)
        Me.GroupBox1.Controls.Add(Me.clientNameTextBox)
        Me.GroupBox1.Controls.Add(Me.clientIdTextBox)
        Me.GroupBox1.Controls.Add(Me.clientAddressTextBox)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 368)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'clientPhoneTextBox
        '
        Me.clientPhoneTextBox.Location = New System.Drawing.Point(139, 315)
        Me.clientPhoneTextBox.Name = "clientPhoneTextBox"
        Me.clientPhoneTextBox.Size = New System.Drawing.Size(213, 22)
        Me.clientPhoneTextBox.TabIndex = 9
        '
        'clientEmailTextBox
        '
        Me.clientEmailTextBox.Location = New System.Drawing.Point(139, 265)
        Me.clientEmailTextBox.Name = "clientEmailTextBox"
        Me.clientEmailTextBox.Size = New System.Drawing.Size(213, 22)
        Me.clientEmailTextBox.TabIndex = 8
        '
        'clientNameTextBox
        '
        Me.clientNameTextBox.Location = New System.Drawing.Point(139, 76)
        Me.clientNameTextBox.Name = "clientNameTextBox"
        Me.clientNameTextBox.Size = New System.Drawing.Size(213, 22)
        Me.clientNameTextBox.TabIndex = 7
        '
        'clientIdTextBox
        '
        Me.clientIdTextBox.Location = New System.Drawing.Point(139, 32)
        Me.clientIdTextBox.Name = "clientIdTextBox"
        Me.clientIdTextBox.Size = New System.Drawing.Size(213, 22)
        Me.clientIdTextBox.TabIndex = 6
        '
        'clientAddressTextBox
        '
        Me.clientAddressTextBox.Location = New System.Drawing.Point(139, 127)
        Me.clientAddressTextBox.Multiline = True
        Me.clientAddressTextBox.Name = "clientAddressTextBox"
        Me.clientAddressTextBox.Size = New System.Drawing.Size(254, 110)
        Me.clientAddressTextBox.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 315)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Client Phone:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Client Email:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(30, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(103, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Client Address:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(30, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Client Name:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Client Id:"
        '
        'addClientBtn
        '
        Me.addClientBtn.Location = New System.Drawing.Point(46, 389)
        Me.addClientBtn.Name = "addClientBtn"
        Me.addClientBtn.Size = New System.Drawing.Size(161, 55)
        Me.addClientBtn.TabIndex = 11
        Me.addClientBtn.Text = "Insert Data"
        Me.addClientBtn.UseVisualStyleBackColor = True
        '
        'ClientAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 456)
        Me.Controls.Add(Me.addClientBtn)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "ClientAdd"
        Me.Text = "ClientAdd"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents clientPhoneTextBox As TextBox
    Friend WithEvents clientEmailTextBox As TextBox
    Friend WithEvents clientNameTextBox As TextBox
    Friend WithEvents clientIdTextBox As TextBox
    Friend WithEvents clientAddressTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents addClientBtn As Button
End Class
