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
        Me.rdoColFootNotes = New System.Windows.Forms.RadioButton()
        Me.ucrColumnFootNote = New instat.ucrColumnFootNote()
        Me.rdoColWidth = New System.Windows.Forms.RadioButton()
        Me.ucrColumnWidth = New instat.ucrColumnWidth()
        Me.rdoColNanoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoColHide = New System.Windows.Forms.RadioButton()
        Me.rdoColStyle = New System.Windows.Forms.RadioButton()
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
        Me.rdoColSpanners.Location = New System.Drawing.Point(546, 3)
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
        Me.rdoColLabel.Location = New System.Drawing.Point(12, 3)
        Me.rdoColLabel.Name = "rdoColLabel"
        Me.rdoColLabel.Size = New System.Drawing.Size(91, 29)
        Me.rdoColLabel.TabIndex = 296
        Me.rdoColLabel.Text = "Labels"
        Me.rdoColLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColLabel.UseVisualStyleBackColor = True
        '
        'ucrColumnLabels
        '
        Me.ucrColumnLabels.Location = New System.Drawing.Point(13, 42)
        Me.ucrColumnLabels.Name = "ucrColumnLabels"
        Me.ucrColumnLabels.Size = New System.Drawing.Size(575, 262)
        Me.ucrColumnLabels.TabIndex = 297
        '
        'ucrColumnSpanners
        '
        Me.ucrColumnSpanners.Location = New System.Drawing.Point(6, 40)
        Me.ucrColumnSpanners.Name = "ucrColumnSpanners"
        Me.ucrColumnSpanners.Size = New System.Drawing.Size(615, 266)
        Me.ucrColumnSpanners.TabIndex = 295
        '
        'ucrPnlCols
        '
        Me.ucrPnlCols.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCols.Location = New System.Drawing.Point(3, 3)
        Me.ucrPnlCols.Name = "ucrPnlCols"
        Me.ucrPnlCols.Size = New System.Drawing.Size(634, 29)
        Me.ucrPnlCols.TabIndex = 289
        '
        'rdoColFootNotes
        '
        Me.rdoColFootNotes.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColFootNotes.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColFootNotes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColFootNotes.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColFootNotes.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColFootNotes.FlatAppearance.BorderSize = 2
        Me.rdoColFootNotes.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColFootNotes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColFootNotes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColFootNotes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColFootNotes.Location = New System.Drawing.Point(367, 3)
        Me.rdoColFootNotes.Name = "rdoColFootNotes"
        Me.rdoColFootNotes.Size = New System.Drawing.Size(91, 29)
        Me.rdoColFootNotes.TabIndex = 298
        Me.rdoColFootNotes.Text = "Foot Notes"
        Me.rdoColFootNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColFootNotes.UseVisualStyleBackColor = True
        '
        'ucrColumnFootNote
        '
        Me.ucrColumnFootNote.Location = New System.Drawing.Point(7, 37)
        Me.ucrColumnFootNote.Name = "ucrColumnFootNote"
        Me.ucrColumnFootNote.Size = New System.Drawing.Size(599, 220)
        Me.ucrColumnFootNote.TabIndex = 299
        '
        'rdoColWidth
        '
        Me.rdoColWidth.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColWidth.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColWidth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColWidth.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColWidth.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColWidth.FlatAppearance.BorderSize = 2
        Me.rdoColWidth.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColWidth.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColWidth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColWidth.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColWidth.Location = New System.Drawing.Point(101, 3)
        Me.rdoColWidth.Name = "rdoColWidth"
        Me.rdoColWidth.Size = New System.Drawing.Size(91, 29)
        Me.rdoColWidth.TabIndex = 300
        Me.rdoColWidth.Text = "Width"
        Me.rdoColWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColWidth.UseVisualStyleBackColor = True
        '
        'ucrColumnWidth
        '
        Me.ucrColumnWidth.Location = New System.Drawing.Point(5, 37)
        Me.ucrColumnWidth.Name = "ucrColumnWidth"
        Me.ucrColumnWidth.Size = New System.Drawing.Size(613, 267)
        Me.ucrColumnWidth.TabIndex = 301
        '
        'rdoColNanoPlot
        '
        Me.rdoColNanoPlot.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColNanoPlot.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColNanoPlot.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColNanoPlot.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColNanoPlot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColNanoPlot.FlatAppearance.BorderSize = 2
        Me.rdoColNanoPlot.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColNanoPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColNanoPlot.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColNanoPlot.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColNanoPlot.Location = New System.Drawing.Point(278, 3)
        Me.rdoColNanoPlot.Name = "rdoColNanoPlot"
        Me.rdoColNanoPlot.Size = New System.Drawing.Size(91, 29)
        Me.rdoColNanoPlot.TabIndex = 303
        Me.rdoColNanoPlot.Text = "Nano Plot"
        Me.rdoColNanoPlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColNanoPlot.UseVisualStyleBackColor = True
        '
        'rdoColHide
        '
        Me.rdoColHide.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColHide.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColHide.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColHide.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColHide.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColHide.FlatAppearance.BorderSize = 2
        Me.rdoColHide.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColHide.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColHide.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColHide.Location = New System.Drawing.Point(189, 3)
        Me.rdoColHide.Name = "rdoColHide"
        Me.rdoColHide.Size = New System.Drawing.Size(91, 29)
        Me.rdoColHide.TabIndex = 302
        Me.rdoColHide.Text = "Hide"
        Me.rdoColHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColHide.UseVisualStyleBackColor = True
        '
        'rdoColStyle
        '
        Me.rdoColStyle.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColStyle.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColStyle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColStyle.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColStyle.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColStyle.FlatAppearance.BorderSize = 2
        Me.rdoColStyle.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColStyle.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColStyle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColStyle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColStyle.Location = New System.Drawing.Point(456, 3)
        Me.rdoColStyle.Name = "rdoColStyle"
        Me.rdoColStyle.Size = New System.Drawing.Size(91, 29)
        Me.rdoColStyle.TabIndex = 304
        Me.rdoColStyle.Text = "Style"
        Me.rdoColStyle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColStyle.UseVisualStyleBackColor = True
        '
        'ucrColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoColStyle)
        Me.Controls.Add(Me.rdoColNanoPlot)
        Me.Controls.Add(Me.rdoColHide)
        Me.Controls.Add(Me.ucrColumnSpanners)
        Me.Controls.Add(Me.ucrColumnLabels)
        Me.Controls.Add(Me.ucrColumnFootNote)
        Me.Controls.Add(Me.ucrColumnWidth)
        Me.Controls.Add(Me.rdoColWidth)
        Me.Controls.Add(Me.rdoColFootNotes)
        Me.Controls.Add(Me.rdoColLabel)
        Me.Controls.Add(Me.rdoColSpanners)
        Me.Controls.Add(Me.ucrPnlCols)
        Me.Name = "ucrColumns"
        Me.Size = New System.Drawing.Size(651, 309)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ucrPnlCols As UcrPanel
    Friend WithEvents rdoColSpanners As RadioButton
    Friend WithEvents ucrColumnSpanners As ucrColumnSpanners
    Friend WithEvents rdoColLabel As RadioButton
    Friend WithEvents ucrColumnLabels As ucrColumnLabels
    Friend WithEvents rdoColFootNotes As RadioButton
    Friend WithEvents ucrColumnFootNote As ucrColumnFootNote
    Friend WithEvents rdoColWidth As RadioButton
    Friend WithEvents ucrColumnWidth As ucrColumnWidth
    Friend WithEvents rdoColNanoPlot As RadioButton
    Friend WithEvents rdoColHide As RadioButton
    Friend WithEvents rdoColStyle As RadioButton
End Class
