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
        Me.rdoColSpanners = New System.Windows.Forms.RadioButton()
        Me.rdoColLabel = New System.Windows.Forms.RadioButton()
        Me.ucrColumnLabels = New instat.ucrColumnLabels()
        Me.ucrColumnSpanners = New instat.ucrColumnSpanners()
        Me.ucrPnlCols = New instat.UcrPanel()
        Me.SuspendLayout()
        '
        'rdoColSpanners
        '
        Me.rdoColSpanners.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColSpanners.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColSpanners.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColSpanners.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColSpanners.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColSpanners.FlatAppearance.BorderSize = 2
        Me.rdoColSpanners.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColSpanners.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColSpanners.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColSpanners.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColSpanners.Location = New System.Drawing.Point(329, 3)
        Me.rdoColSpanners.Name = "rdoColSpanners"
        Me.rdoColSpanners.Size = New System.Drawing.Size(91, 29)
        Me.rdoColSpanners.TabIndex = 294
        Me.rdoColSpanners.Text = "Spanners"
        Me.rdoColSpanners.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColSpanners.UseVisualStyleBackColor = True
        '
        'rdoColLabel
        '
        Me.rdoColLabel.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColLabel.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColLabel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColLabel.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColLabel.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColLabel.FlatAppearance.BorderSize = 2
        Me.rdoColLabel.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColLabel.Location = New System.Drawing.Point(241, 3)
        Me.rdoColLabel.Name = "rdoColLabel"
        Me.rdoColLabel.Size = New System.Drawing.Size(91, 29)
        Me.rdoColLabel.TabIndex = 296
        Me.rdoColLabel.Text = "Labels"
        Me.rdoColLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColLabel.UseVisualStyleBackColor = True
        '
        'ucrColumnLabels
        '
        Me.ucrColumnLabels.Location = New System.Drawing.Point(16, 42)
        Me.ucrColumnLabels.Name = "ucrColumnLabels"
        Me.ucrColumnLabels.Size = New System.Drawing.Size(575, 194)
        Me.ucrColumnLabels.TabIndex = 297
        '
        'ucrColumnSpanners
        '
        Me.ucrColumnSpanners.Location = New System.Drawing.Point(12, 40)
        Me.ucrColumnSpanners.Name = "ucrColumnSpanners"
        Me.ucrColumnSpanners.Size = New System.Drawing.Size(615, 215)
        Me.ucrColumnSpanners.TabIndex = 295
        '
        'ucrPnlCols
        '
        Me.ucrPnlCols.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCols.Location = New System.Drawing.Point(26, 3)
        Me.ucrPnlCols.Name = "ucrPnlCols"
        Me.ucrPnlCols.Size = New System.Drawing.Size(570, 29)
        Me.ucrPnlCols.TabIndex = 289
        '
        'ucrColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.ucrColumnLabels)
        Me.Controls.Add(Me.rdoColLabel)
        Me.Controls.Add(Me.ucrColumnSpanners)
        Me.Controls.Add(Me.rdoColSpanners)
        Me.Controls.Add(Me.ucrPnlCols)
        Me.Name = "ucrColumns"
        Me.Size = New System.Drawing.Size(633, 260)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrPnlCols As UcrPanel
    Friend WithEvents rdoColSpanners As RadioButton
    Friend WithEvents ucrColumnSpanners As ucrColumnSpanners
    Friend WithEvents rdoColLabel As RadioButton
    Friend WithEvents ucrColumnLabels As ucrColumnLabels
End Class
