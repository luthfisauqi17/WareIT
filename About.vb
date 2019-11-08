Public Class About
    Private Sub About_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        partnershipPictureBox0.Image = ImageList1.Images(0)
        partnershipPictureBox1.Image = ImageList1.Images(1)
        partnershipPictureBox2.Image = ImageList1.Images(2)
        partnershipPictureBox3.Image = ImageList1.Images(3)
        partnershipPictureBox4.Image = ImageList1.Images(4)
        aboutUsPanel.Dock = DockStyle.Fill
        featurePanel.Dock = DockStyle.Fill
        sendFeedbackPanel.Dock = DockStyle.Fill
        techSupportPanel.Dock = DockStyle.Fill
        faqPanel.Dock = DockStyle.Fill
        partnershipPanel.Dock = DockStyle.Fill
    End Sub

    Private Sub AboutTreeView_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles aboutTreeView.AfterSelect
        Dim selected_node As String = aboutTreeView.SelectedNode.Text

        If selected_node = "About Us" Then
            aboutUsPanel.Visible = True
            featurePanel.Visible = False
            sendFeedbackPanel.Visible = False
            techSupportPanel.Visible = False
            faqPanel.Visible = False
            partnershipPanel.Visible = False
        ElseIf selected_node = "Features" Then
            aboutUsPanel.Visible = False
            featurePanel.Visible = True
            sendFeedbackPanel.Visible = False
            techSupportPanel.Visible = False
            faqPanel.Visible = False
            partnershipPanel.Visible = False
        ElseIf selected_node = "Send Feedback" Then
            aboutUsPanel.Visible = False
            featurePanel.Visible = False
            sendFeedbackPanel.Visible = True
            techSupportPanel.Visible = False
            faqPanel.Visible = False
            partnershipPanel.Visible = False
        ElseIf selected_node = "Technical Supports" Then
            aboutUsPanel.Visible = False
            featurePanel.Visible = False
            sendFeedbackPanel.Visible = False
            techSupportPanel.Visible = True
            faqPanel.Visible = False
            partnershipPanel.Visible = False
        ElseIf selected_node = "FAQ" Then
            aboutUsPanel.Visible = False
            featurePanel.Visible = False
            sendFeedbackPanel.Visible = False
            techSupportPanel.Visible = False
            faqPanel.Visible = True
            partnershipPanel.Visible = False
        ElseIf selected_node = "Partnership" Then
            aboutUsPanel.Visible = False
            featurePanel.Visible = False
            sendFeedbackPanel.Visible = False
            techSupportPanel.Visible = False
            faqPanel.Visible = False
            partnershipPanel.Visible = True
        End If

    End Sub


End Class