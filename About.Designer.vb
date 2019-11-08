<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class About
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
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("About Us")
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Features")
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("About", New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Send Feedback")
        Dim TreeNode5 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Technical Supports")
        Dim TreeNode6 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Customer Service", New System.Windows.Forms.TreeNode() {TreeNode4, TreeNode5})
        Dim TreeNode7 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("FAQ")
        Dim TreeNode8 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Partnership")
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(About))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.aboutTreeView = New System.Windows.Forms.TreeView()
        Me.faqPanel = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.aboutUsPanel = New System.Windows.Forms.Panel()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.featurePanel = New System.Windows.Forms.Panel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.techSupportPanel = New System.Windows.Forms.Panel()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.sendFeedbackPanel = New System.Windows.Forms.Panel()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.partnershipPanel = New System.Windows.Forms.Panel()
        Me.partnershipPictureBox4 = New System.Windows.Forms.PictureBox()
        Me.partnershipPictureBox3 = New System.Windows.Forms.PictureBox()
        Me.partnershipPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.partnershipPictureBox1 = New System.Windows.Forms.PictureBox()
        Me.partnershipPictureBox0 = New System.Windows.Forms.PictureBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.faqPanel.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.aboutUsPanel.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.featurePanel.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.techSupportPanel.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.sendFeedbackPanel.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.partnershipPanel.SuspendLayout()
        CType(Me.partnershipPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partnershipPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partnershipPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partnershipPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.partnershipPictureBox0, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.aboutTreeView)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.aboutUsPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.featurePanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.techSupportPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.sendFeedbackPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.partnershipPanel)
        Me.SplitContainer1.Panel2.Controls.Add(Me.faqPanel)
        Me.SplitContainer1.Size = New System.Drawing.Size(800, 450)
        Me.SplitContainer1.SplitterDistance = 266
        Me.SplitContainer1.TabIndex = 0
        '
        'aboutTreeView
        '
        Me.aboutTreeView.Location = New System.Drawing.Point(0, 3)
        Me.aboutTreeView.Name = "aboutTreeView"
        TreeNode1.Name = "aboutUsNode"
        TreeNode1.Text = "About Us"
        TreeNode2.Name = "featuresNode"
        TreeNode2.Text = "Features"
        TreeNode3.Name = "Node0"
        TreeNode3.Text = "About"
        TreeNode4.Name = "sendFeedbackNode"
        TreeNode4.Text = "Send Feedback"
        TreeNode5.Name = "technicalSupportNode"
        TreeNode5.Text = "Technical Supports"
        TreeNode6.Name = "Node8"
        TreeNode6.Text = "Customer Service"
        TreeNode7.Name = "faqNode"
        TreeNode7.Text = "FAQ"
        TreeNode8.Name = "partnershipNode"
        TreeNode8.Text = "Partnership"
        Me.aboutTreeView.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode3, TreeNode6, TreeNode7, TreeNode8})
        Me.aboutTreeView.Size = New System.Drawing.Size(260, 444)
        Me.aboutTreeView.TabIndex = 0
        '
        'faqPanel
        '
        Me.faqPanel.Controls.Add(Me.GroupBox1)
        Me.faqPanel.Controls.Add(Me.Label1)
        Me.faqPanel.Location = New System.Drawing.Point(3, 12)
        Me.faqPanel.Name = "faqPanel"
        Me.faqPanel.Size = New System.Drawing.Size(530, 43)
        Me.faqPanel.TabIndex = 6
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 56)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(503, 86)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 18)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(243, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Q: How to use this application?"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(282, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "A: First you can add new information"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(217, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FAQs"
        '
        'aboutUsPanel
        '
        Me.aboutUsPanel.Controls.Add(Me.GroupBox8)
        Me.aboutUsPanel.Controls.Add(Me.Label22)
        Me.aboutUsPanel.Location = New System.Drawing.Point(3, 63)
        Me.aboutUsPanel.Name = "aboutUsPanel"
        Me.aboutUsPanel.Size = New System.Drawing.Size(512, 43)
        Me.aboutUsPanel.TabIndex = 5
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.Label23)
        Me.GroupBox8.Location = New System.Drawing.Point(24, 88)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(479, 320)
        Me.GroupBox8.TabIndex = 1
        Me.GroupBox8.TabStop = False
        '
        'Label23
        '
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(22, 27)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(438, 281)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = resources.GetString("Label23.Text")
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(188, 39)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(131, 32)
        Me.Label22.TabIndex = 0
        Me.Label22.Text = "About Us"
        '
        'featurePanel
        '
        Me.featurePanel.Controls.Add(Me.GroupBox7)
        Me.featurePanel.Controls.Add(Me.Label17)
        Me.featurePanel.Location = New System.Drawing.Point(6, 112)
        Me.featurePanel.Name = "featurePanel"
        Me.featurePanel.Size = New System.Drawing.Size(521, 52)
        Me.featurePanel.TabIndex = 4
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.Label21)
        Me.GroupBox7.Controls.Add(Me.Label20)
        Me.GroupBox7.Controls.Add(Me.Label19)
        Me.GroupBox7.Controls.Add(Me.Label18)
        Me.GroupBox7.Location = New System.Drawing.Point(29, 93)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(468, 167)
        Me.GroupBox7.TabIndex = 5
        Me.GroupBox7.TabStop = False
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(6, 117)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(413, 25)
        Me.Label21.TabIndex = 8
        Me.Label21.Text = "4. You able to view and add transaction history"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(6, 87)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(423, 25)
        Me.Label20.TabIndex = 7
        Me.Label20.Text = "3. You able to add, edit, delete client information"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(6, 57)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(438, 25)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "2. You able to add, edit, delete vendor information"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 31)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(443, 25)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "1. You able to add, edit, delete product information"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(192, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(127, 32)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Features"
        '
        'techSupportPanel
        '
        Me.techSupportPanel.Controls.Add(Me.GroupBox6)
        Me.techSupportPanel.Controls.Add(Me.Label11)
        Me.techSupportPanel.Location = New System.Drawing.Point(9, 172)
        Me.techSupportPanel.Name = "techSupportPanel"
        Me.techSupportPanel.Size = New System.Drawing.Size(524, 46)
        Me.techSupportPanel.TabIndex = 3
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label16)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.Label14)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.Label12)
        Me.GroupBox6.Location = New System.Drawing.Point(9, 103)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(515, 246)
        Me.GroupBox6.TabIndex = 1
        Me.GroupBox6.TabStop = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(92, 134)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(158, 25)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "0803-2377-2312"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(11, 134)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 25)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Phone:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(11, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 25)
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Email:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(83, 101)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(236, 25)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "wareitsupport@email.com"
        '
        'Label12
        '
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(9, 22)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(494, 53)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "If you sumbled on an error or bug, you can contact our technical support team 24/" &
    "7."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(143, 43)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(245, 32)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "Technical Support"
        '
        'sendFeedbackPanel
        '
        Me.sendFeedbackPanel.Controls.Add(Me.GroupBox5)
        Me.sendFeedbackPanel.Controls.Add(Me.Label8)
        Me.sendFeedbackPanel.Location = New System.Drawing.Point(9, 224)
        Me.sendFeedbackPanel.Name = "sendFeedbackPanel"
        Me.sendFeedbackPanel.Size = New System.Drawing.Size(521, 63)
        Me.sendFeedbackPanel.TabIndex = 2
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label10)
        Me.GroupBox5.Controls.Add(Me.Label9)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 80)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(506, 128)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 58)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(295, 29)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "sauqiluthfi877@gmail.com"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(368, 17)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "You able to send your feedback at the email given below:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(159, 32)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(214, 32)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Send Feedback"
        '
        'partnershipPanel
        '
        Me.partnershipPanel.Controls.Add(Me.Label4)
        Me.partnershipPanel.Controls.Add(Me.partnershipPictureBox4)
        Me.partnershipPanel.Controls.Add(Me.partnershipPictureBox3)
        Me.partnershipPanel.Controls.Add(Me.partnershipPictureBox2)
        Me.partnershipPanel.Controls.Add(Me.partnershipPictureBox1)
        Me.partnershipPanel.Controls.Add(Me.partnershipPictureBox0)
        Me.partnershipPanel.Location = New System.Drawing.Point(9, 304)
        Me.partnershipPanel.Name = "partnershipPanel"
        Me.partnershipPanel.Size = New System.Drawing.Size(518, 130)
        Me.partnershipPanel.TabIndex = 0
        '
        'partnershipPictureBox4
        '
        Me.partnershipPictureBox4.Location = New System.Drawing.Point(18, 223)
        Me.partnershipPictureBox4.Name = "partnershipPictureBox4"
        Me.partnershipPictureBox4.Size = New System.Drawing.Size(100, 100)
        Me.partnershipPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partnershipPictureBox4.TabIndex = 9
        Me.partnershipPictureBox4.TabStop = False
        '
        'partnershipPictureBox3
        '
        Me.partnershipPictureBox3.Location = New System.Drawing.Point(397, 107)
        Me.partnershipPictureBox3.Name = "partnershipPictureBox3"
        Me.partnershipPictureBox3.Size = New System.Drawing.Size(100, 100)
        Me.partnershipPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partnershipPictureBox3.TabIndex = 8
        Me.partnershipPictureBox3.TabStop = False
        '
        'partnershipPictureBox2
        '
        Me.partnershipPictureBox2.Location = New System.Drawing.Point(273, 107)
        Me.partnershipPictureBox2.Name = "partnershipPictureBox2"
        Me.partnershipPictureBox2.Size = New System.Drawing.Size(100, 100)
        Me.partnershipPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partnershipPictureBox2.TabIndex = 7
        Me.partnershipPictureBox2.TabStop = False
        '
        'partnershipPictureBox1
        '
        Me.partnershipPictureBox1.Location = New System.Drawing.Point(149, 107)
        Me.partnershipPictureBox1.Name = "partnershipPictureBox1"
        Me.partnershipPictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.partnershipPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partnershipPictureBox1.TabIndex = 6
        Me.partnershipPictureBox1.TabStop = False
        '
        'partnershipPictureBox0
        '
        Me.partnershipPictureBox0.Location = New System.Drawing.Point(18, 107)
        Me.partnershipPictureBox0.Name = "partnershipPictureBox0"
        Me.partnershipPictureBox0.Size = New System.Drawing.Size(100, 100)
        Me.partnershipPictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.partnershipPictureBox0.TabIndex = 5
        Me.partnershipPictureBox0.TabStop = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "0.jpg")
        Me.ImageList1.Images.SetKeyName(1, "0.png")
        Me.ImageList1.Images.SetKeyName(2, "20699_20121157_3631274_db840141_image.jpg")
        Me.ImageList1.Images.SetKeyName(3, "12009670_163602357313862_6012260228671958984_n.jpg.300x300_q85.jpg")
        Me.ImageList1.Images.SetKeyName(4, "download.png")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(188, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(161, 32)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Partnership"
        '
        'About
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "About"
        Me.Text = "About"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.faqPanel.ResumeLayout(False)
        Me.faqPanel.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.aboutUsPanel.ResumeLayout(False)
        Me.aboutUsPanel.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.featurePanel.ResumeLayout(False)
        Me.featurePanel.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.GroupBox7.PerformLayout()
        Me.techSupportPanel.ResumeLayout(False)
        Me.techSupportPanel.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.sendFeedbackPanel.ResumeLayout(False)
        Me.sendFeedbackPanel.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.partnershipPanel.ResumeLayout(False)
        Me.partnershipPanel.PerformLayout()
        CType(Me.partnershipPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partnershipPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partnershipPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partnershipPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.partnershipPictureBox0, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents aboutTreeView As TreeView
    Friend WithEvents partnershipPanel As Panel
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents partnershipPictureBox0 As PictureBox
    Friend WithEvents sendFeedbackPanel As Panel
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents partnershipPictureBox4 As PictureBox
    Friend WithEvents partnershipPictureBox3 As PictureBox
    Friend WithEvents partnershipPictureBox2 As PictureBox
    Friend WithEvents partnershipPictureBox1 As PictureBox
    Friend WithEvents techSupportPanel As Panel
    Friend WithEvents aboutUsPanel As Panel
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents featurePanel As Panel
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents Label21 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents faqPanel As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
End Class
