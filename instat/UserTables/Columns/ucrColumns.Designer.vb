<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucrColumns
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.rdoColSpanners = New System.Windows.Forms.RadioButton()
        Me.rdoColLabel = New System.Windows.Forms.RadioButton()
        Me.rdoColFootNotes = New System.Windows.Forms.RadioButton()
        Me.rdoColWidth = New System.Windows.Forms.RadioButton()
        Me.rdoColNanoPlot = New System.Windows.Forms.RadioButton()
        Me.rdoColStyles = New System.Windows.Forms.RadioButton()
        Me.rdoColHide = New System.Windows.Forms.RadioButton()
        Me.rdoColMissing = New System.Windows.Forms.RadioButton()
        Me.ucrColumnMissingTexts = New instat.ucrColumnMissingTexts()
        Me.ucrColumnHide = New instat.ucrColumnHide()
        Me.ucrColumnFootNote = New instat.ucrColumnFootNote()
        Me.ucrColumnWidth = New instat.ucrColumnWidth()
        Me.ucrPnlCols = New instat.UcrPanel()
        Me.ucrColumnNanoPlots = New instat.ucrColumnNanoPlots()
        Me.ucrColumnStyles = New instat.ucrColumnStyles()
        Me.ucrColumnSpanners = New instat.ucrColumnSpanners()
        Me.ucrColumnLabels = New instat.ucrColumnLabels()
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
        Me.rdoColSpanners.Location = New System.Drawing.Point(556, 3)
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
        Me.rdoColLabel.Location = New System.Drawing.Point(23, 3)
        Me.rdoColLabel.Name = "rdoColLabel"
        Me.rdoColLabel.Size = New System.Drawing.Size(91, 29)
        Me.rdoColLabel.TabIndex = 296
        Me.rdoColLabel.Text = "Labels"
        Me.rdoColLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColLabel.UseVisualStyleBackColor = True
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
        Me.rdoColFootNotes.Location = New System.Drawing.Point(467, 3)
        Me.rdoColFootNotes.Name = "rdoColFootNotes"
        Me.rdoColFootNotes.Size = New System.Drawing.Size(91, 29)
        Me.rdoColFootNotes.TabIndex = 298
        Me.rdoColFootNotes.Text = "Foot Notes"
        Me.rdoColFootNotes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColFootNotes.UseVisualStyleBackColor = True
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
        Me.rdoColWidth.Location = New System.Drawing.Point(112, 3)
        Me.rdoColWidth.Name = "rdoColWidth"
        Me.rdoColWidth.Size = New System.Drawing.Size(91, 29)
        Me.rdoColWidth.TabIndex = 300
        Me.rdoColWidth.Text = "Width"
        Me.rdoColWidth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColWidth.UseVisualStyleBackColor = True
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
        Me.rdoColNanoPlot.Location = New System.Drawing.Point(645, 3)
        Me.rdoColNanoPlot.Name = "rdoColNanoPlot"
        Me.rdoColNanoPlot.Size = New System.Drawing.Size(91, 29)
        Me.rdoColNanoPlot.TabIndex = 303
        Me.rdoColNanoPlot.Text = "Nano Plot"
        Me.rdoColNanoPlot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColNanoPlot.UseVisualStyleBackColor = True
        '
        'rdoColStyles
        '
        Me.rdoColStyles.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColStyles.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColStyles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColStyles.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColStyles.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColStyles.FlatAppearance.BorderSize = 2
        Me.rdoColStyles.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColStyles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColStyles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColStyles.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColStyles.Location = New System.Drawing.Point(380, 3)
        Me.rdoColStyles.Name = "rdoColStyles"
        Me.rdoColStyles.Size = New System.Drawing.Size(91, 29)
        Me.rdoColStyles.TabIndex = 305
        Me.rdoColStyles.Text = "Styles"
        Me.rdoColStyles.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColStyles.UseVisualStyleBackColor = True
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
        Me.rdoColHide.Location = New System.Drawing.Point(201, 3)
        Me.rdoColHide.Name = "rdoColHide"
        Me.rdoColHide.Size = New System.Drawing.Size(91, 29)
        Me.rdoColHide.TabIndex = 307
        Me.rdoColHide.Text = "Hide"
        Me.rdoColHide.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColHide.UseVisualStyleBackColor = True
        '
        'rdoColMissing
        '
        Me.rdoColMissing.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoColMissing.BackColor = System.Drawing.SystemColors.Control
        Me.rdoColMissing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoColMissing.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColMissing.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColMissing.FlatAppearance.BorderSize = 2
        Me.rdoColMissing.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoColMissing.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoColMissing.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoColMissing.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoColMissing.Location = New System.Drawing.Point(291, 3)
        Me.rdoColMissing.Name = "rdoColMissing"
        Me.rdoColMissing.Size = New System.Drawing.Size(91, 29)
        Me.rdoColMissing.TabIndex = 309
        Me.rdoColMissing.Text = "Missing"
        Me.rdoColMissing.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoColMissing.UseVisualStyleBackColor = True
        '
        'ucrColumnMissingTexts
        '
        Me.ucrColumnMissingTexts.Location = New System.Drawing.Point(59, 38)
        Me.ucrColumnMissingTexts.Margin = New System.Windows.Forms.Padding(1)
        Me.ucrColumnMissingTexts.Name = "ucrColumnMissingTexts"
        Me.ucrColumnMissingTexts.Size = New System.Drawing.Size(602, 294)
        Me.ucrColumnMissingTexts.TabIndex = 310
        '
        'ucrColumnHide
        '
        Me.ucrColumnHide.Location = New System.Drawing.Point(140, 42)
        Me.ucrColumnHide.Margin = New System.Windows.Forms.Padding(1)
        Me.ucrColumnHide.Name = "ucrColumnHide"
        Me.ucrColumnHide.Size = New System.Drawing.Size(418, 248)
        Me.ucrColumnHide.TabIndex = 308
        '
        'ucrColumnFootNote
        '
        Me.ucrColumnFootNote.Location = New System.Drawing.Point(72, 37)
        Me.ucrColumnFootNote.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrColumnFootNote.Name = "ucrColumnFootNote"
        Me.ucrColumnFootNote.Size = New System.Drawing.Size(599, 292)
        Me.ucrColumnFootNote.TabIndex = 299
        '
        'ucrColumnWidth
        '
        Me.ucrColumnWidth.Location = New System.Drawing.Point(71, 37)
        Me.ucrColumnWidth.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrColumnWidth.Name = "ucrColumnWidth"
        Me.ucrColumnWidth.Size = New System.Drawing.Size(613, 267)
        Me.ucrColumnWidth.TabIndex = 301
        '
        'ucrPnlCols
        '
        Me.ucrPnlCols.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCols.Location = New System.Drawing.Point(8, 3)
        Me.ucrPnlCols.Margin = New System.Windows.Forms.Padding(5)
        Me.ucrPnlCols.Name = "ucrPnlCols"
        Me.ucrPnlCols.Size = New System.Drawing.Size(743, 29)
        Me.ucrPnlCols.TabIndex = 289
        '
        'ucrColumnNanoPlots
        '
        Me.ucrColumnNanoPlots.Location = New System.Drawing.Point(69, 42)
        Me.ucrColumnNanoPlots.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrColumnNanoPlots.Name = "ucrColumnNanoPlots"
        Me.ucrColumnNanoPlots.Size = New System.Drawing.Size(635, 363)
        Me.ucrColumnNanoPlots.TabIndex = 304
        '
        'ucrColumnStyles
        '
        Me.ucrColumnStyles.Location = New System.Drawing.Point(95, 42)
        Me.ucrColumnStyles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrColumnStyles.Name = "ucrColumnStyles"
        Me.ucrColumnStyles.Size = New System.Drawing.Size(556, 280)
        Me.ucrColumnStyles.TabIndex = 306
        '
        'ucrColumnSpanners
        '
        Me.ucrColumnSpanners.Location = New System.Drawing.Point(69, 40)
        Me.ucrColumnSpanners.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrColumnSpanners.Name = "ucrColumnSpanners"
        Me.ucrColumnSpanners.Size = New System.Drawing.Size(615, 289)
        Me.ucrColumnSpanners.TabIndex = 295
        '
        'ucrColumnLabels
        '
        Me.ucrColumnLabels.Location = New System.Drawing.Point(71, 42)
        Me.ucrColumnLabels.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrColumnLabels.Name = "ucrColumnLabels"
        Me.ucrColumnLabels.Size = New System.Drawing.Size(575, 287)
        Me.ucrColumnLabels.TabIndex = 297
        '
        'ucrColumns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.rdoColMissing)
        Me.Controls.Add(Me.rdoColHide)
        Me.Controls.Add(Me.rdoColStyles)
        Me.Controls.Add(Me.rdoColNanoPlot)
        Me.Controls.Add(Me.rdoColWidth)
        Me.Controls.Add(Me.rdoColFootNotes)
        Me.Controls.Add(Me.rdoColLabel)
        Me.Controls.Add(Me.rdoColSpanners)
        Me.Controls.Add(Me.ucrPnlCols)
        Me.Controls.Add(Me.ucrColumnHide)
        Me.Controls.Add(Me.ucrColumnStyles)
        Me.Controls.Add(Me.ucrColumnNanoPlots)
        Me.Controls.Add(Me.ucrColumnWidth)
        Me.Controls.Add(Me.ucrColumnFootNote)
        Me.Controls.Add(Me.ucrColumnMissingTexts)
        Me.Controls.Add(Me.ucrColumnLabels)
        Me.Controls.Add(Me.ucrColumnSpanners)
        Me.Name = "ucrColumns"
        Me.Size = New System.Drawing.Size(757, 418)
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
    Friend WithEvents ucrColumnNanoPlots As ucrColumnNanoPlots
    Friend WithEvents rdoColStyles As RadioButton
    Friend WithEvents ucrColumnStyles As ucrColumnStyles
    Friend WithEvents rdoColHide As RadioButton
    Friend WithEvents ucrColumnHide As ucrColumnHide
    Friend WithEvents rdoColMissing As RadioButton
    Friend WithEvents ucrColumnMissingTexts As ucrColumnMissingTexts
End Class
