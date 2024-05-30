<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrRows
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.rdoStyle = New System.Windows.Forms.RadioButton()
        Me.rdoGroup = New System.Windows.Forms.RadioButton()
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRow = New instat.UcrPanel()
        Me.ucrRowGroups = New instat.ucrRowGroup()
        Me.SuspendLayout()
        '
        'rdoStyle
        '
        Me.rdoStyle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoStyle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoStyle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStyle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStyle.FlatAppearance.BorderSize = 2
        Me.rdoStyle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoStyle.Location = New System.Drawing.Point(412, 3)
        Me.rdoStyle.Name = "rdoStyle"
        Me.rdoStyle.Size = New System.Drawing.Size(91, 29)
        Me.rdoStyle.TabIndex = 282
        Me.rdoStyle.Text = "Styles"
        Me.rdoStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStyle.UseVisualStyleBackColor = True
        '
        'rdoGroup
        '
        Me.rdoGroup.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGroup.BackColor = System.Drawing.SystemColors.Control
        Me.rdoGroup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGroup.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGroup.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGroup.FlatAppearance.BorderSize = 2
        Me.rdoGroup.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGroup.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGroup.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGroup.Location = New System.Drawing.Point(235, 3)
        Me.rdoGroup.Name = "rdoGroup"
        Me.rdoGroup.Size = New System.Drawing.Size(91, 29)
        Me.rdoGroup.TabIndex = 280
        Me.rdoGroup.Text = "Groups"
        Me.rdoGroup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGroup.UseVisualStyleBackColor = True
        '
        'rdoSummary
        '
        Me.rdoSummary.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoSummary.BackColor = System.Drawing.SystemColors.Control
        Me.rdoSummary.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoSummary.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummary.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatAppearance.BorderSize = 2
        Me.rdoSummary.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoSummary.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoSummary.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoSummary.Location = New System.Drawing.Point(324, 3)
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.Size = New System.Drawing.Size(91, 29)
        Me.rdoSummary.TabIndex = 281
        Me.rdoSummary.Text = "Summaries"
        Me.rdoSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummary.UseVisualStyleBackColor = True
        '
        'ucrPnlRow
        '
        Me.ucrPnlRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRow.Location = New System.Drawing.Point(93, 3)
        Me.ucrPnlRow.Name = "ucrPnlRow"
        Me.ucrPnlRow.Size = New System.Drawing.Size(506, 29)
        Me.ucrPnlRow.TabIndex = 279
        '
        'ucrRowGroups
        '
        Me.ucrRowGroups.Location = New System.Drawing.Point(3, 38)
        Me.ucrRowGroups.Name = "ucrRowGroups"
        Me.ucrRowGroups.Size = New System.Drawing.Size(749, 194)
        Me.ucrRowGroups.TabIndex = 283
        '
        'ucrRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrRowGroups)
        Me.Controls.Add(Me.rdoStyle)
        Me.Controls.Add(Me.rdoGroup)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.ucrPnlRow)
        Me.Name = "ucrRows"
        Me.Size = New System.Drawing.Size(753, 237)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdoStyle As RadioButton
    Friend WithEvents rdoGroup As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents ucrPnlRow As UcrPanel
    Friend WithEvents ucrRowGroups As ucrRowGroup
End Class
