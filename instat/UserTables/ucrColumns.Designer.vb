<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucrColumns
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
        Me.rdoSummary = New System.Windows.Forms.RadioButton()
        Me.ucrPnlRow = New instat.UcrPanel()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.ucrColumnSpanners = New instat.ucrColumnSpanners()
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
        Me.rdoStyle.Location = New System.Drawing.Point(406, 3)
        Me.rdoStyle.Name = "rdoStyle"
        Me.rdoStyle.Size = New System.Drawing.Size(91, 29)
        Me.rdoStyle.TabIndex = 292
        Me.rdoStyle.Text = "Styles"
        Me.rdoStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoStyle.UseVisualStyleBackColor = True
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
        Me.rdoSummary.Location = New System.Drawing.Point(318, 3)
        Me.rdoSummary.Name = "rdoSummary"
        Me.rdoSummary.Size = New System.Drawing.Size(91, 29)
        Me.rdoSummary.TabIndex = 291
        Me.rdoSummary.Text = "Summaries"
        Me.rdoSummary.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoSummary.UseVisualStyleBackColor = True
        '
        'ucrPnlRow
        '
        Me.ucrPnlRow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlRow.Location = New System.Drawing.Point(26, 3)
        Me.ucrPnlRow.Name = "ucrPnlRow"
        Me.ucrPnlRow.Size = New System.Drawing.Size(533, 29)
        Me.ucrPnlRow.TabIndex = 289
        '
        'RadioButton1
        '
        Me.RadioButton1.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton1.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RadioButton1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton1.FlatAppearance.BorderSize = 2
        Me.RadioButton1.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton1.Location = New System.Drawing.Point(229, 3)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(91, 29)
        Me.RadioButton1.TabIndex = 293
        Me.RadioButton1.Text = "Formats"
        Me.RadioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.Appearance = System.Windows.Forms.Appearance.Button
        Me.RadioButton2.BackColor = System.Drawing.SystemColors.Control
        Me.RadioButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.RadioButton2.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton2.FlatAppearance.BorderSize = 2
        Me.RadioButton2.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.RadioButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.RadioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.RadioButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadioButton2.Location = New System.Drawing.Point(140, 3)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(91, 29)
        Me.RadioButton2.TabIndex = 294
        Me.RadioButton2.Text = "Spanners"
        Me.RadioButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'ucrColumnSpanners
        '
        Me.ucrColumnSpanners.Location = New System.Drawing.Point(12, 40)
        Me.ucrColumnSpanners.Name = "ucrColumnSpanners"
        Me.ucrColumnSpanners.Size = New System.Drawing.Size(615, 215)
        Me.ucrColumnSpanners.TabIndex = 295
        '
        'ucrColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrColumnSpanners)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.rdoStyle)
        Me.Controls.Add(Me.rdoSummary)
        Me.Controls.Add(Me.ucrPnlRow)
        Me.Name = "ucrColumns"
        Me.Size = New System.Drawing.Size(633, 260)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents rdoStyle As RadioButton
    Friend WithEvents rdoSummary As RadioButton
    Friend WithEvents ucrPnlRow As UcrPanel
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents ucrColumnSpanners As ucrColumnSpanners
End Class
