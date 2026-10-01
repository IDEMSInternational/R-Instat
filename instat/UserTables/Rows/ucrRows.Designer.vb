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
        Me.rdoRowsGroups = New System.Windows.Forms.RadioButton()
        Me.rdoRowsGroupSummaries = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRows = New instat.UcrPanel()
        Me.ucrRowSummary = New instat.ucrRowSummary()
        Me.ucrRowGroups = New instat.ucrRowGroup()
        Me.rdoGrandSummaries = New System.Windows.Forms.RadioButton()
        Me.ucrRowsGrandSummary = New instat.ucrRowsGrandSummary()
        Me.SuspendLayout()
        '
        'rdoRowsGroups
        '
        Me.rdoRowsGroups.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRowsGroups.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRowsGroups.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoRowsGroups.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRowsGroups.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRowsGroups.FlatAppearance.BorderSize = 2
        Me.rdoRowsGroups.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRowsGroups.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRowsGroups.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRowsGroups.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRowsGroups.Location = New System.Drawing.Point(369, 17)
        Me.rdoRowsGroups.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoRowsGroups.Name = "rdoRowsGroups"
        Me.rdoRowsGroups.Size = New System.Drawing.Size(136, 45)
        Me.rdoRowsGroups.TabIndex = 280
        Me.rdoRowsGroups.Text = "Groups"
        Me.rdoRowsGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRowsGroups.UseVisualStyleBackColor = True
        '
        'rdoRowsGroupSummaries
        '
        Me.rdoRowsGroupSummaries.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRowsGroupSummaries.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRowsGroupSummaries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoRowsGroupSummaries.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRowsGroupSummaries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRowsGroupSummaries.FlatAppearance.BorderSize = 2
        Me.rdoRowsGroupSummaries.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRowsGroupSummaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRowsGroupSummaries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRowsGroupSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRowsGroupSummaries.Location = New System.Drawing.Point(503, 17)
        Me.rdoRowsGroupSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoRowsGroupSummaries.Name = "rdoRowsGroupSummaries"
        Me.rdoRowsGroupSummaries.Size = New System.Drawing.Size(158, 45)
        Me.rdoRowsGroupSummaries.TabIndex = 281
        Me.rdoRowsGroupSummaries.Text = "Group Summaries"
        Me.rdoRowsGroupSummaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRowsGroupSummaries.UseVisualStyleBackColor = True
        '
        'ucrPnlRows
        '
        Me.ucrPnlRows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRows.Location = New System.Drawing.Point(94, 9)
        Me.ucrPnlRows.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlRows.Name = "ucrPnlRows"
        Me.ucrPnlRows.Size = New System.Drawing.Size(707, 61)
        Me.ucrPnlRows.TabIndex = 279
        '
        'ucrRowSummary
        '
        Me.ucrRowSummary.Location = New System.Drawing.Point(10, 68)
        Me.ucrRowSummary.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrRowSummary.Name = "ucrRowSummary"
        Me.ucrRowSummary.Size = New System.Drawing.Size(900, 588)
        Me.ucrRowSummary.TabIndex = 284
        '
        'ucrRowGroups
        '
        Me.ucrRowGroups.Location = New System.Drawing.Point(132, 87)
        Me.ucrRowGroups.Margin = New System.Windows.Forms.Padding(6, 8, 6, 8)
        Me.ucrRowGroups.Name = "ucrRowGroups"
        Me.ucrRowGroups.Size = New System.Drawing.Size(727, 411)
        Me.ucrRowGroups.TabIndex = 283
        '
        'rdoGrandSummaries
        '
        Me.rdoGrandSummaries.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoGrandSummaries.BackColor = System.Drawing.SystemColors.Control
        Me.rdoGrandSummaries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoGrandSummaries.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGrandSummaries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGrandSummaries.FlatAppearance.BorderSize = 2
        Me.rdoGrandSummaries.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoGrandSummaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoGrandSummaries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoGrandSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoGrandSummaries.Location = New System.Drawing.Point(210, 17)
        Me.rdoGrandSummaries.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.rdoGrandSummaries.Name = "rdoGrandSummaries"
        Me.rdoGrandSummaries.Size = New System.Drawing.Size(161, 45)
        Me.rdoGrandSummaries.TabIndex = 285
        Me.rdoGrandSummaries.Text = "Grand Summaries"
        Me.rdoGrandSummaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoGrandSummaries.UseVisualStyleBackColor = True
        '
        'ucrRowsGrandSummary
        '
        Me.ucrRowsGrandSummary.Location = New System.Drawing.Point(24, 79)
        Me.ucrRowsGrandSummary.Name = "ucrRowsGrandSummary"
        Me.ucrRowsGrandSummary.Size = New System.Drawing.Size(938, 565)
        Me.ucrRowsGrandSummary.TabIndex = 286
        '
        'ucrRows
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoGrandSummaries)
        Me.Controls.Add(Me.rdoRowsGroups)
        Me.Controls.Add(Me.rdoRowsGroupSummaries)
        Me.Controls.Add(Me.ucrPnlRows)
        Me.Controls.Add(Me.ucrRowsGrandSummary)
        Me.Controls.Add(Me.ucrRowGroups)
        Me.Controls.Add(Me.ucrRowSummary)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "ucrRows"
        Me.Size = New System.Drawing.Size(979, 667)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdoRowsGroups As RadioButton
    Friend WithEvents rdoRowsGroupSummaries As RadioButton
    Friend WithEvents ucrPnlRows As UcrPanel
    Friend WithEvents ucrRowGroups As ucrRowGroup
    Friend WithEvents ucrRowSummary As ucrRowSummary
    Friend WithEvents rdoGrandSummaries As RadioButton
    Friend WithEvents ucrRowsGrandSummary As ucrRowsGrandSummary
End Class
