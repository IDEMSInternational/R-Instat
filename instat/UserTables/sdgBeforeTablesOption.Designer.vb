<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgBeforeTablesOption
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
        Me.tbpFormatOptions = New System.Windows.Forms.TabControl()
        Me.tbpHeader = New System.Windows.Forms.TabPage()
        Me.ucrHeader = New instat.ucrHeader()
        Me.tbpSourceNotes = New System.Windows.Forms.TabPage()
        Me.ucrSourceNotes = New instat.ucrSourceNotes()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.ucrChkSelectTheme = New instat.ucrCheck()
        Me.ucrChkManualTheme = New instat.ucrCheck()
        Me.ucrCboSelectThemes = New instat.ucrInputComboBox()
        Me.btnManualTheme = New System.Windows.Forms.Button()
        Me.tbpOtherStyles = New System.Windows.Forms.TabPage()
        Me.ucrOtherStyles = New instat.ucrOtherStyles()
        Me.tbpTables = New System.Windows.Forms.TabPage()
        Me.ucrColumnNewMissingTexts = New instat.ucrColumnNewMissingTexts()
        Me.rdoReplaceNa = New System.Windows.Forms.RadioButton()
        Me.rdoDataFormat = New System.Windows.Forms.RadioButton()
        Me.ucrPnlCells = New instat.UcrPanel()
        Me.ucrNewCellFormats = New instat.ucrNewCellFormats()
        Me.ucrSdgBaseButtons = New instat.ucrButtonsSubdialogue()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.tbpSourceNotes.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        Me.tbpOtherStyles.SuspendLayout()
        Me.tbpTables.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpHeader)
        Me.tbpFormatOptions.Controls.Add(Me.tbpSourceNotes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Controls.Add(Me.tbpOtherStyles)
        Me.tbpFormatOptions.Controls.Add(Me.tbpTables)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(2, 1)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(645, 389)
        Me.tbpFormatOptions.TabIndex = 6
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.ucrHeader)
        Me.tbpHeader.Location = New System.Drawing.Point(4, 22)
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpHeader.Size = New System.Drawing.Size(637, 363)
        Me.tbpHeader.TabIndex = 0
        Me.tbpHeader.Text = "Header"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'ucrHeader
        '
        Me.ucrHeader.Location = New System.Drawing.Point(7, 6)
        Me.ucrHeader.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrHeader.Name = "ucrHeader"
        Me.ucrHeader.Size = New System.Drawing.Size(601, 300)
        Me.ucrHeader.TabIndex = 16
        '
        'tbpSourceNotes
        '
        Me.tbpSourceNotes.Controls.Add(Me.ucrSourceNotes)
        Me.tbpSourceNotes.Location = New System.Drawing.Point(4, 22)
        Me.tbpSourceNotes.Name = "tbpSourceNotes"
        Me.tbpSourceNotes.Size = New System.Drawing.Size(637, 363)
        Me.tbpSourceNotes.TabIndex = 4
        Me.tbpSourceNotes.Text = "Source Notes"
        Me.tbpSourceNotes.UseVisualStyleBackColor = True
        '
        'ucrSourceNotes
        '
        Me.ucrSourceNotes.Location = New System.Drawing.Point(7, 7)
        Me.ucrSourceNotes.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrSourceNotes.Name = "ucrSourceNotes"
        Me.ucrSourceNotes.Size = New System.Drawing.Size(581, 190)
        Me.ucrSourceNotes.TabIndex = 0
        '
        'tbpThemes
        '
        Me.tbpThemes.Controls.Add(Me.ucrChkSelectTheme)
        Me.tbpThemes.Controls.Add(Me.ucrChkManualTheme)
        Me.tbpThemes.Controls.Add(Me.ucrCboSelectThemes)
        Me.tbpThemes.Controls.Add(Me.btnManualTheme)
        Me.tbpThemes.Location = New System.Drawing.Point(4, 22)
        Me.tbpThemes.Margin = New System.Windows.Forms.Padding(2)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(637, 363)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
        '
        'ucrChkSelectTheme
        '
        Me.ucrChkSelectTheme.AutoSize = True
        Me.ucrChkSelectTheme.Checked = False
        Me.ucrChkSelectTheme.Location = New System.Drawing.Point(17, 19)
        Me.ucrChkSelectTheme.Margin = New System.Windows.Forms.Padding(2)
        Me.ucrChkSelectTheme.Name = "ucrChkSelectTheme"
        Me.ucrChkSelectTheme.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkSelectTheme.TabIndex = 29
        '
        'ucrChkManualTheme
        '
        Me.ucrChkManualTheme.AutoSize = True
        Me.ucrChkManualTheme.Checked = False
        Me.ucrChkManualTheme.Location = New System.Drawing.Point(17, 59)
        Me.ucrChkManualTheme.Margin = New System.Windows.Forms.Padding(2)
        Me.ucrChkManualTheme.Name = "ucrChkManualTheme"
        Me.ucrChkManualTheme.Size = New System.Drawing.Size(121, 23)
        Me.ucrChkManualTheme.TabIndex = 28
        '
        'ucrCboSelectThemes
        '
        Me.ucrCboSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrCboSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrCboSelectThemes.GetSetSelectedIndex = -1
        Me.ucrCboSelectThemes.IsReadOnly = False
        Me.ucrCboSelectThemes.Location = New System.Drawing.Point(153, 19)
        Me.ucrCboSelectThemes.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrCboSelectThemes.Name = "ucrCboSelectThemes"
        Me.ucrCboSelectThemes.Size = New System.Drawing.Size(150, 21)
        Me.ucrCboSelectThemes.TabIndex = 3
        '
        'btnManualTheme
        '
        Me.btnManualTheme.Location = New System.Drawing.Point(154, 60)
        Me.btnManualTheme.Margin = New System.Windows.Forms.Padding(2)
        Me.btnManualTheme.Name = "btnManualTheme"
        Me.btnManualTheme.Size = New System.Drawing.Size(149, 21)
        Me.btnManualTheme.TabIndex = 2
        Me.btnManualTheme.Text = "Custom Theme"
        Me.btnManualTheme.UseVisualStyleBackColor = True
        '
        'tbpOtherStyles
        '
        Me.tbpOtherStyles.Controls.Add(Me.ucrOtherStyles)
        Me.tbpOtherStyles.Location = New System.Drawing.Point(4, 22)
        Me.tbpOtherStyles.Name = "tbpOtherStyles"
        Me.tbpOtherStyles.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpOtherStyles.Size = New System.Drawing.Size(637, 363)
        Me.tbpOtherStyles.TabIndex = 10
        Me.tbpOtherStyles.Text = "Other Styles"
        Me.tbpOtherStyles.UseVisualStyleBackColor = True
        '
        'ucrOtherStyles
        '
        Me.ucrOtherStyles.Location = New System.Drawing.Point(8, 7)
        Me.ucrOtherStyles.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ucrOtherStyles.Name = "ucrOtherStyles"
        Me.ucrOtherStyles.Size = New System.Drawing.Size(326, 179)
        Me.ucrOtherStyles.TabIndex = 0
        '
        'tbpTables
        '
        Me.tbpTables.Controls.Add(Me.ucrColumnNewMissingTexts)
        Me.tbpTables.Controls.Add(Me.rdoReplaceNa)
        Me.tbpTables.Controls.Add(Me.rdoDataFormat)
        Me.tbpTables.Controls.Add(Me.ucrPnlCells)
        Me.tbpTables.Controls.Add(Me.ucrNewCellFormats)
        Me.tbpTables.Location = New System.Drawing.Point(4, 22)
        Me.tbpTables.Name = "tbpTables"
        Me.tbpTables.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTables.Size = New System.Drawing.Size(637, 363)
        Me.tbpTables.TabIndex = 11
        Me.tbpTables.Text = "Tables"
        Me.tbpTables.UseVisualStyleBackColor = True
        '
        'ucrColumnNewMissingTexts
        '
        Me.ucrColumnNewMissingTexts.Location = New System.Drawing.Point(12, 59)
        Me.ucrColumnNewMissingTexts.Name = "ucrColumnNewMissingTexts"
        Me.ucrColumnNewMissingTexts.Size = New System.Drawing.Size(602, 303)
        Me.ucrColumnNewMissingTexts.TabIndex = 297
        '
        'rdoReplaceNa
        '
        Me.rdoReplaceNa.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoReplaceNa.BackColor = System.Drawing.SystemColors.Control
        Me.rdoReplaceNa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoReplaceNa.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplaceNa.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceNa.FlatAppearance.BorderSize = 2
        Me.rdoReplaceNa.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoReplaceNa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoReplaceNa.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoReplaceNa.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoReplaceNa.Location = New System.Drawing.Point(288, 15)
        Me.rdoReplaceNa.Name = "rdoReplaceNa"
        Me.rdoReplaceNa.Size = New System.Drawing.Size(108, 29)
        Me.rdoReplaceNa.TabIndex = 301
        Me.rdoReplaceNa.Text = "Replace NA with"
        Me.rdoReplaceNa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoReplaceNa.UseVisualStyleBackColor = True
        '
        'rdoDataFormat
        '
        Me.rdoDataFormat.Appearance = System.Windows.Forms.Appearance.Button
        Me.rdoDataFormat.BackColor = System.Drawing.SystemColors.Control
        Me.rdoDataFormat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.rdoDataFormat.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFormat.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFormat.FlatAppearance.BorderSize = 2
        Me.rdoDataFormat.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ActiveCaption
        Me.rdoDataFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rdoDataFormat.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.rdoDataFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.rdoDataFormat.Location = New System.Drawing.Point(179, 15)
        Me.rdoDataFormat.Name = "rdoDataFormat"
        Me.rdoDataFormat.Size = New System.Drawing.Size(109, 29)
        Me.rdoDataFormat.TabIndex = 300
        Me.rdoDataFormat.Text = "Data Format"
        Me.rdoDataFormat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.rdoDataFormat.UseVisualStyleBackColor = True
        '
        'ucrPnlCells
        '
        Me.ucrPnlCells.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlCells.Location = New System.Drawing.Point(163, 11)
        Me.ucrPnlCells.Name = "ucrPnlCells"
        Me.ucrPnlCells.Size = New System.Drawing.Size(247, 40)
        Me.ucrPnlCells.TabIndex = 299
        '
        'ucrNewCellFormats
        '
        Me.ucrNewCellFormats.Location = New System.Drawing.Point(15, 50)
        Me.ucrNewCellFormats.Name = "ucrNewCellFormats"
        Me.ucrNewCellFormats.Size = New System.Drawing.Size(602, 312)
        Me.ucrNewCellFormats.TabIndex = 298
        '
        'ucrSdgBaseButtons
        '
        Me.ucrSdgBaseButtons.AutoSize = True
        Me.ucrSdgBaseButtons.Location = New System.Drawing.Point(195, 401)
        Me.ucrSdgBaseButtons.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrSdgBaseButtons.Name = "ucrSdgBaseButtons"
        Me.ucrSdgBaseButtons.Size = New System.Drawing.Size(224, 30)
        Me.ucrSdgBaseButtons.TabIndex = 344
        '
        'sdgBeforeTablesOption
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(648, 438)
        Me.Controls.Add(Me.ucrSdgBaseButtons)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgBeforeTablesOption"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tables Option"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpSourceNotes.ResumeLayout(False)
        Me.tbpThemes.ResumeLayout(False)
        Me.tbpThemes.PerformLayout()
        Me.tbpOtherStyles.ResumeLayout(False)
        Me.tbpTables.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbpFormatOptions As TabControl
    Friend WithEvents tbpHeader As TabPage
    Friend WithEvents ucrHeader As ucrHeader
    Friend WithEvents tbpSourceNotes As TabPage
    Friend WithEvents ucrSourceNotes As ucrSourceNotes
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents ucrChkSelectTheme As ucrCheck
    Friend WithEvents ucrChkManualTheme As ucrCheck
    Friend WithEvents ucrCboSelectThemes As ucrInputComboBox
    Friend WithEvents btnManualTheme As Button
    Friend WithEvents tbpOtherStyles As TabPage
    Friend WithEvents ucrOtherStyles As ucrOtherStyles
    Friend WithEvents ucrSdgBaseButtons As ucrButtonsSubdialogue
    Friend WithEvents tbpTables As TabPage
    Friend WithEvents ucrColumnNewMissingTexts As ucrColumnNewMissingTexts
    Friend WithEvents ucrNewCellFormats As ucrNewCellFormats
    Friend WithEvents rdoReplaceNa As RadioButton
    Friend WithEvents rdoDataFormat As RadioButton
    Friend WithEvents ucrPnlCells As UcrPanel
End Class
