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
        Me.rdoRowsSummaries = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRows = New instat.UcrPanel()
        Me.ucrRowGroups = New instat.ucrRowGroup()
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
        Me.rdoRowsGroups.Location = New System.Drawing.Point(283, 3)
        Me.rdoRowsGroups.Name = "rdoRowsGroups"
        Me.rdoRowsGroups.Size = New System.Drawing.Size(91, 29)
        Me.rdoRowsGroups.TabIndex = 280
        Me.rdoRowsGroups.Text = "Groups"
        Me.rdoRowsGroups.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRowsGroups.UseVisualStyleBackColor = True
        '
        'rdoRowsSummaries
        '
        Me.rdoRowsSummaries.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoRowsSummaries.BackColor = System.Drawing.SystemColors.Control
        Me.rdoRowsSummaries.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoRowsSummaries.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRowsSummaries.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRowsSummaries.FlatAppearance.BorderSize = 2
        Me.rdoRowsSummaries.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoRowsSummaries.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoRowsSummaries.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoRowsSummaries.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoRowsSummaries.Location = New System.Drawing.Point(372, 3)
        Me.rdoRowsSummaries.Name = "rdoRowsSummaries"
        Me.rdoRowsSummaries.Size = New System.Drawing.Size(91, 29)
        Me.rdoRowsSummaries.TabIndex = 281
        Me.rdoRowsSummaries.Text = "Summaries"
        Me.rdoRowsSummaries.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoRowsSummaries.UseVisualStyleBackColor = True
        '
        'ucrPnlRows
        '
        Me.ucrPnlRows.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRows.Location = New System.Drawing.Point(93, 3)
        Me.ucrPnlRows.Name = "ucrPnlRows"
        Me.ucrPnlRows.Size = New System.Drawing.Size(506, 29)
        Me.ucrPnlRows.TabIndex = 279
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
        Me.Controls.Add(Me.rdoRowsGroups)
        Me.Controls.Add(Me.rdoRowsSummaries)
        Me.Controls.Add(Me.ucrPnlRows)
        Me.Name = "ucrRows"
        Me.Size = New System.Drawing.Size(753, 237)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rdoRowsGroups As RadioButton
    Friend WithEvents rdoRowsSummaries As RadioButton
    Friend WithEvents ucrPnlRows As UcrPanel
    Friend WithEvents ucrRowGroups As ucrRowGroup
End Class
