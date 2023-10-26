<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class sdgFormatSummaryTables
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.cmdManualTheme = New System.Windows.Forms.Button()
        Me.rdoSelectTheme = New System.Windows.Forms.RadioButton()
        Me.rdoManualTheme = New System.Windows.Forms.RadioButton()
        Me.tbpStubs = New System.Windows.Forms.TabPage()
        Me.lblStubs = New System.Windows.Forms.Label()
        Me.grpStubs = New System.Windows.Forms.GroupBox()
        Me.cmdStubsFormat = New System.Windows.Forms.Button()
        Me.cmdStubsFont = New System.Windows.Forms.Button()
        Me.lblStubsFootNote = New System.Windows.Forms.Label()
        Me.tbpTitle = New System.Windows.Forms.TabPage()
        Me.grpSubtitle = New System.Windows.Forms.GroupBox()
        Me.lblSubtitleFnText = New System.Windows.Forms.Label()
        Me.cmdSubtitleFont = New System.Windows.Forms.Button()
        Me.cmdSubtitleFormat = New System.Windows.Forms.Button()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblSecondFootnote = New System.Windows.Forms.Label()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.lblTitlefnText = New System.Windows.Forms.Label()
        Me.cmdTitleFont = New System.Windows.Forms.Button()
        Me.cmdTitleFormat = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbpFormatOptions = New System.Windows.Forms.TabControl()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrInputSubtitleFootnote = New instat.ucrInputTextBox()
        Me.ucrChkSubtitleFootnote = New instat.ucrCheck()
        Me.ucrInputSubtitle = New instat.ucrInputTextBox()
        Me.ucrChkIncludeTitles = New instat.ucrCheck()
        Me.ucrInputTitleFootnote = New instat.ucrInputTextBox()
        Me.ucrChkTitleFootnote = New instat.ucrCheck()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrChkFootNote = New instat.ucrCheck()
        Me.ucrInputStubsFootNote = New instat.ucrInputTextBox()
        Me.ucrInputStubs = New instat.ucrInputTextBox()
        Me.ucrChkStubs = New instat.ucrCheck()
        Me.ucrInputSelectThemes = New instat.ucrInputComboBox()
        Me.ucrPnlThemesPanel = New instat.UcrPanel()
        Me.tbpThemes.SuspendLayout()
        Me.tbpStubs.SuspendLayout()
        Me.grpStubs.SuspendLayout()
        Me.tbpTitle.SuspendLayout()
        Me.grpSubtitle.SuspendLayout()
        Me.grpTitle.SuspendLayout()
        Me.tbpFormatOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpThemes
        '
        Me.tbpThemes.Controls.Add(Me.ucrInputSelectThemes)
        Me.tbpThemes.Controls.Add(Me.cmdManualTheme)
        Me.tbpThemes.Controls.Add(Me.rdoSelectTheme)
        Me.tbpThemes.Controls.Add(Me.rdoManualTheme)
        Me.tbpThemes.Controls.Add(Me.ucrPnlThemesPanel)
        Me.tbpThemes.Location = New System.Drawing.Point(4, 22)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(580, 327)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
        '
        'cmdManualTheme
        '
        Me.cmdManualTheme.Location = New System.Drawing.Point(157, 59)
        Me.cmdManualTheme.Name = "cmdManualTheme"
        Me.cmdManualTheme.Size = New System.Drawing.Size(168, 21)
        Me.cmdManualTheme.TabIndex = 2
        Me.cmdManualTheme.Text = "Themes Sub Dialog"
        Me.cmdManualTheme.UseVisualStyleBackColor = True
        '
        'rdoSelectTheme
        '
        Me.rdoSelectTheme.AutoSize = True
        Me.rdoSelectTheme.Checked = True
        Me.rdoSelectTheme.Location = New System.Drawing.Point(22, 31)
        Me.rdoSelectTheme.Name = "rdoSelectTheme"
        Me.rdoSelectTheme.Size = New System.Drawing.Size(91, 17)
        Me.rdoSelectTheme.TabIndex = 0
        Me.rdoSelectTheme.TabStop = True
        Me.rdoSelectTheme.Text = "Select Theme"
        Me.rdoSelectTheme.UseVisualStyleBackColor = True
        '
        'rdoManualTheme
        '
        Me.rdoManualTheme.AutoSize = True
        Me.rdoManualTheme.Location = New System.Drawing.Point(22, 61)
        Me.rdoManualTheme.Name = "rdoManualTheme"
        Me.rdoManualTheme.Size = New System.Drawing.Size(96, 17)
        Me.rdoManualTheme.TabIndex = 1
        Me.rdoManualTheme.Text = "Manual Theme"
        Me.rdoManualTheme.UseVisualStyleBackColor = True
        '
        'tbpStubs
        '
        Me.tbpStubs.Controls.Add(Me.lblStubs)
        Me.tbpStubs.Controls.Add(Me.grpStubs)
        Me.tbpStubs.Controls.Add(Me.ucrInputStubs)
        Me.tbpStubs.Controls.Add(Me.ucrChkStubs)
        Me.tbpStubs.Location = New System.Drawing.Point(4, 22)
        Me.tbpStubs.Name = "tbpStubs"
        Me.tbpStubs.Size = New System.Drawing.Size(580, 327)
        Me.tbpStubs.TabIndex = 5
        Me.tbpStubs.Text = "Stubs"
        Me.tbpStubs.UseVisualStyleBackColor = True
        '
        'lblStubs
        '
        Me.lblStubs.AutoSize = True
        Me.lblStubs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStubs.Location = New System.Drawing.Point(14, 82)
        Me.lblStubs.Name = "lblStubs"
        Me.lblStubs.Size = New System.Drawing.Size(31, 13)
        Me.lblStubs.TabIndex = 19
        Me.lblStubs.Text = "Text:"
        '
        'grpStubs
        '
        Me.grpStubs.Controls.Add(Me.cmdStubsFormat)
        Me.grpStubs.Controls.Add(Me.cmdStubsFont)
        Me.grpStubs.Controls.Add(Me.ucrChkFootNote)
        Me.grpStubs.Controls.Add(Me.lblStubsFootNote)
        Me.grpStubs.Controls.Add(Me.ucrInputStubsFootNote)
        Me.grpStubs.Location = New System.Drawing.Point(11, 65)
        Me.grpStubs.Name = "grpStubs"
        Me.grpStubs.Size = New System.Drawing.Size(496, 139)
        Me.grpStubs.TabIndex = 3
        Me.grpStubs.TabStop = False
        Me.grpStubs.Text = "Stub"
        '
        'cmdStubsFormat
        '
        Me.cmdStubsFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStubsFormat.Location = New System.Drawing.Point(372, 100)
        Me.cmdStubsFormat.Name = "cmdStubsFormat"
        Me.cmdStubsFormat.Size = New System.Drawing.Size(104, 23)
        Me.cmdStubsFormat.TabIndex = 25
        Me.cmdStubsFormat.Text = "Format"
        Me.cmdStubsFormat.UseVisualStyleBackColor = True
        '
        'cmdStubsFont
        '
        Me.cmdStubsFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStubsFont.Location = New System.Drawing.Point(371, 16)
        Me.cmdStubsFont.Name = "cmdStubsFont"
        Me.cmdStubsFont.Size = New System.Drawing.Size(104, 23)
        Me.cmdStubsFont.TabIndex = 24
        Me.cmdStubsFont.Text = "Font"
        Me.cmdStubsFont.UseVisualStyleBackColor = True
        '
        'lblStubsFootNote
        '
        Me.lblStubsFootNote.AutoSize = True
        Me.lblStubsFootNote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStubsFootNote.Location = New System.Drawing.Point(13, 104)
        Me.lblStubsFootNote.Name = "lblStubsFootNote"
        Me.lblStubsFootNote.Size = New System.Drawing.Size(31, 13)
        Me.lblStubsFootNote.TabIndex = 21
        Me.lblStubsFootNote.Text = "Text:"
        '
        'tbpTitle
        '
        Me.tbpTitle.Controls.Add(Me.grpSubtitle)
        Me.tbpTitle.Controls.Add(Me.lblSecondFootnote)
        Me.tbpTitle.Controls.Add(Me.ucrChkIncludeTitles)
        Me.tbpTitle.Controls.Add(Me.grpTitle)
        Me.tbpTitle.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitle.Name = "tbpTitle"
        Me.tbpTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitle.Size = New System.Drawing.Size(580, 327)
        Me.tbpTitle.TabIndex = 0
        Me.tbpTitle.Text = "Title"
        Me.tbpTitle.UseVisualStyleBackColor = True
        '
        'grpSubtitle
        '
        Me.grpSubtitle.Controls.Add(Me.lblSubtitleFnText)
        Me.grpSubtitle.Controls.Add(Me.cmdSubtitleFont)
        Me.grpSubtitle.Controls.Add(Me.cmdSubtitleFormat)
        Me.grpSubtitle.Controls.Add(Me.ucrInputSubtitleFootnote)
        Me.grpSubtitle.Controls.Add(Me.ucrChkSubtitleFootnote)
        Me.grpSubtitle.Controls.Add(Me.ucrInputSubtitle)
        Me.grpSubtitle.Controls.Add(Me.lblSubtitle)
        Me.grpSubtitle.Location = New System.Drawing.Point(7, 198)
        Me.grpSubtitle.Name = "grpSubtitle"
        Me.grpSubtitle.Size = New System.Drawing.Size(479, 115)
        Me.grpSubtitle.TabIndex = 14
        Me.grpSubtitle.TabStop = False
        Me.grpSubtitle.Text = "Subtitle"
        '
        'lblSubtitleFnText
        '
        Me.lblSubtitleFnText.AutoSize = True
        Me.lblSubtitleFnText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubtitleFnText.Location = New System.Drawing.Point(14, 77)
        Me.lblSubtitleFnText.Name = "lblSubtitleFnText"
        Me.lblSubtitleFnText.Size = New System.Drawing.Size(31, 13)
        Me.lblSubtitleFnText.TabIndex = 16
        Me.lblSubtitleFnText.Text = "Text:"
        '
        'cmdSubtitleFont
        '
        Me.cmdSubtitleFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSubtitleFont.Location = New System.Drawing.Point(358, 16)
        Me.cmdSubtitleFont.Name = "cmdSubtitleFont"
        Me.cmdSubtitleFont.Size = New System.Drawing.Size(104, 23)
        Me.cmdSubtitleFont.TabIndex = 15
        Me.cmdSubtitleFont.Text = "Font"
        Me.cmdSubtitleFont.UseVisualStyleBackColor = True
        '
        'cmdSubtitleFormat
        '
        Me.cmdSubtitleFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSubtitleFormat.Location = New System.Drawing.Point(362, 70)
        Me.cmdSubtitleFormat.Name = "cmdSubtitleFormat"
        Me.cmdSubtitleFormat.Size = New System.Drawing.Size(104, 23)
        Me.cmdSubtitleFormat.TabIndex = 14
        Me.cmdSubtitleFormat.Text = "Format"
        Me.cmdSubtitleFormat.UseVisualStyleBackColor = True
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubtitle.Location = New System.Drawing.Point(15, 16)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(31, 13)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Text:"
        '
        'lblSecondFootnote
        '
        Me.lblSecondFootnote.AutoSize = True
        Me.lblSecondFootnote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondFootnote.Location = New System.Drawing.Point(137, 469)
        Me.lblSecondFootnote.Name = "lblSecondFootnote"
        Me.lblSecondFootnote.Size = New System.Drawing.Size(0, 13)
        Me.lblSecondFootnote.TabIndex = 13
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.lblTitlefnText)
        Me.grpTitle.Controls.Add(Me.cmdTitleFont)
        Me.grpTitle.Controls.Add(Me.cmdTitleFormat)
        Me.grpTitle.Controls.Add(Me.ucrInputTitleFootnote)
        Me.grpTitle.Controls.Add(Me.ucrChkTitleFootnote)
        Me.grpTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpTitle.Controls.Add(Me.lblTitle)
        Me.grpTitle.Location = New System.Drawing.Point(6, 53)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(479, 115)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "Title"
        '
        'lblTitlefnText
        '
        Me.lblTitlefnText.AutoSize = True
        Me.lblTitlefnText.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitlefnText.Location = New System.Drawing.Point(18, 81)
        Me.lblTitlefnText.Name = "lblTitlefnText"
        Me.lblTitlefnText.Size = New System.Drawing.Size(31, 13)
        Me.lblTitlefnText.TabIndex = 19
        Me.lblTitlefnText.Text = "Text:"
        '
        'cmdTitleFont
        '
        Me.cmdTitleFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTitleFont.Location = New System.Drawing.Point(367, 23)
        Me.cmdTitleFont.Name = "cmdTitleFont"
        Me.cmdTitleFont.Size = New System.Drawing.Size(104, 23)
        Me.cmdTitleFont.TabIndex = 18
        Me.cmdTitleFont.Text = "Font"
        Me.cmdTitleFont.UseVisualStyleBackColor = True
        '
        'cmdTitleFormat
        '
        Me.cmdTitleFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTitleFormat.Location = New System.Drawing.Point(366, 73)
        Me.cmdTitleFormat.Name = "cmdTitleFormat"
        Me.cmdTitleFormat.Size = New System.Drawing.Size(104, 23)
        Me.cmdTitleFormat.TabIndex = 17
        Me.cmdTitleFormat.Text = "Format"
        Me.cmdTitleFormat.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(15, 25)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(31, 13)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Text:"
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpTitle)
        Me.tbpFormatOptions.Controls.Add(Me.tbpStubs)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(12, 12)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(588, 353)
        Me.tbpFormatOptions.TabIndex = 1
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(190, 368)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 3
        '
        'ucrInputSubtitleFootnote
        '
        Me.ucrInputSubtitleFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitleFootnote.AutoSize = True
        Me.ucrInputSubtitleFootnote.IsMultiline = False
        Me.ucrInputSubtitleFootnote.IsReadOnly = False
        Me.ucrInputSubtitleFootnote.Location = New System.Drawing.Point(71, 73)
        Me.ucrInputSubtitleFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSubtitleFootnote.Name = "ucrInputSubtitleFootnote"
        Me.ucrInputSubtitleFootnote.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputSubtitleFootnote.TabIndex = 7
        '
        'ucrChkSubtitleFootnote
        '
        Me.ucrChkSubtitleFootnote.AutoSize = True
        Me.ucrChkSubtitleFootnote.Checked = False
        Me.ucrChkSubtitleFootnote.Location = New System.Drawing.Point(69, 36)
        Me.ucrChkSubtitleFootnote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkSubtitleFootnote.Name = "ucrChkSubtitleFootnote"
        Me.ucrChkSubtitleFootnote.Size = New System.Drawing.Size(124, 34)
        Me.ucrChkSubtitleFootnote.TabIndex = 5
        '
        'ucrInputSubtitle
        '
        Me.ucrInputSubtitle.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitle.AutoSize = True
        Me.ucrInputSubtitle.IsMultiline = False
        Me.ucrInputSubtitle.IsReadOnly = False
        Me.ucrInputSubtitle.Location = New System.Drawing.Point(69, 11)
        Me.ucrInputSubtitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSubtitle.Name = "ucrInputSubtitle"
        Me.ucrInputSubtitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSubtitle.TabIndex = 3
        '
        'ucrChkIncludeTitles
        '
        Me.ucrChkIncludeTitles.AutoSize = True
        Me.ucrChkIncludeTitles.Checked = False
        Me.ucrChkIncludeTitles.Location = New System.Drawing.Point(9, 18)
        Me.ucrChkIncludeTitles.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkIncludeTitles.Name = "ucrChkIncludeTitles"
        Me.ucrChkIncludeTitles.Size = New System.Drawing.Size(156, 34)
        Me.ucrChkIncludeTitles.TabIndex = 1
        '
        'ucrInputTitleFootnote
        '
        Me.ucrInputTitleFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputTitleFootnote.AutoSize = True
        Me.ucrInputTitleFootnote.IsMultiline = False
        Me.ucrInputTitleFootnote.IsReadOnly = False
        Me.ucrInputTitleFootnote.Location = New System.Drawing.Point(71, 79)
        Me.ucrInputTitleFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTitleFootnote.Name = "ucrInputTitleFootnote"
        Me.ucrInputTitleFootnote.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputTitleFootnote.TabIndex = 6
        '
        'ucrChkTitleFootnote
        '
        Me.ucrChkTitleFootnote.AutoSize = True
        Me.ucrChkTitleFootnote.Checked = False
        Me.ucrChkTitleFootnote.Location = New System.Drawing.Point(70, 49)
        Me.ucrChkTitleFootnote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkTitleFootnote.Name = "ucrChkTitleFootnote"
        Me.ucrChkTitleFootnote.Size = New System.Drawing.Size(124, 34)
        Me.ucrChkTitleFootnote.TabIndex = 4
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(69, 25)
        Me.ucrInputTitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTitle.TabIndex = 2
        '
        'ucrChkFootNote
        '
        Me.ucrChkFootNote.AutoSize = True
        Me.ucrChkFootNote.Checked = False
        Me.ucrChkFootNote.Location = New System.Drawing.Point(25, 52)
        Me.ucrChkFootNote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkFootNote.Name = "ucrChkFootNote"
        Me.ucrChkFootNote.Size = New System.Drawing.Size(124, 34)
        Me.ucrChkFootNote.TabIndex = 23
        '
        'ucrInputStubsFootNote
        '
        Me.ucrInputStubsFootNote.AddQuotesIfUnrecognised = True
        Me.ucrInputStubsFootNote.AutoSize = True
        Me.ucrInputStubsFootNote.IsMultiline = False
        Me.ucrInputStubsFootNote.IsReadOnly = False
        Me.ucrInputStubsFootNote.Location = New System.Drawing.Point(66, 102)
        Me.ucrInputStubsFootNote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputStubsFootNote.Name = "ucrInputStubsFootNote"
        Me.ucrInputStubsFootNote.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputStubsFootNote.TabIndex = 20
        '
        'ucrInputStubs
        '
        Me.ucrInputStubs.AddQuotesIfUnrecognised = True
        Me.ucrInputStubs.AutoSize = True
        Me.ucrInputStubs.IsMultiline = False
        Me.ucrInputStubs.IsReadOnly = False
        Me.ucrInputStubs.Location = New System.Drawing.Point(68, 82)
        Me.ucrInputStubs.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputStubs.Name = "ucrInputStubs"
        Me.ucrInputStubs.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputStubs.TabIndex = 20
        '
        'ucrChkStubs
        '
        Me.ucrChkStubs.AutoSize = True
        Me.ucrChkStubs.Checked = False
        Me.ucrChkStubs.Location = New System.Drawing.Point(8, 23)
        Me.ucrChkStubs.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkStubs.Name = "ucrChkStubs"
        Me.ucrChkStubs.Size = New System.Drawing.Size(156, 34)
        Me.ucrChkStubs.TabIndex = 2
        '
        'ucrInputSelectThemes
        '
        Me.ucrInputSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSelectThemes.GetSetSelectedIndex = -1
        Me.ucrInputSelectThemes.IsReadOnly = False
        Me.ucrInputSelectThemes.Location = New System.Drawing.Point(157, 29)
        Me.ucrInputSelectThemes.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSelectThemes.Name = "ucrInputSelectThemes"
        Me.ucrInputSelectThemes.Size = New System.Drawing.Size(168, 21)
        Me.ucrInputSelectThemes.TabIndex = 3
        '
        'ucrPnlThemesPanel
        '
        Me.ucrPnlThemesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlThemesPanel.Location = New System.Drawing.Point(12, 16)
        Me.ucrPnlThemesPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlThemesPanel.Name = "ucrPnlThemesPanel"
        Me.ucrPnlThemesPanel.Size = New System.Drawing.Size(349, 70)
        Me.ucrPnlThemesPanel.TabIndex = 4
        '
        'sdgFormatSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(616, 399)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFormatSummaryTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Format Summary Table"
        Me.tbpThemes.ResumeLayout(False)
        Me.tbpThemes.PerformLayout()
        Me.tbpStubs.ResumeLayout(False)
        Me.tbpStubs.PerformLayout()
        Me.grpStubs.ResumeLayout(False)
        Me.grpStubs.PerformLayout()
        Me.tbpTitle.ResumeLayout(False)
        Me.tbpTitle.PerformLayout()
        Me.grpSubtitle.ResumeLayout(False)
        Me.grpSubtitle.PerformLayout()
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents ucrInputSelectThemes As ucrInputComboBox
    Friend WithEvents cmdManualTheme As Button
    Friend WithEvents rdoSelectTheme As RadioButton
    Friend WithEvents rdoManualTheme As RadioButton
    Friend WithEvents ucrPnlThemesPanel As UcrPanel
    Friend WithEvents tbpStubs As TabPage
    Friend WithEvents tbpTitle As TabPage
    Friend WithEvents lblSecondFootnote As Label
    Friend WithEvents ucrChkIncludeTitles As ucrCheck
    Friend WithEvents grpTitle As GroupBox
    Friend WithEvents ucrInputTitleFootnote As ucrInputTextBox
    Friend WithEvents ucrChkTitleFootnote As ucrCheck
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents tbpFormatOptions As TabControl
    Friend WithEvents grpSubtitle As GroupBox
    Friend WithEvents ucrInputSubtitleFootnote As ucrInputTextBox
    Friend WithEvents ucrChkSubtitleFootnote As ucrCheck
    Friend WithEvents ucrInputSubtitle As ucrInputTextBox
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblSubtitleFnText As Label
    Friend WithEvents cmdSubtitleFont As Button
    Friend WithEvents cmdSubtitleFormat As Button
    Friend WithEvents lblTitlefnText As Label
    Friend WithEvents cmdTitleFont As Button
    Friend WithEvents cmdTitleFormat As Button
    Friend WithEvents grpStubs As GroupBox
    Friend WithEvents ucrChkStubs As ucrCheck
    Friend WithEvents ucrInputStubs As ucrInputTextBox
    Friend WithEvents lblStubs As Label
    Friend WithEvents lblStubsFootNote As Label
    Friend WithEvents ucrInputStubsFootNote As ucrInputTextBox
    Friend WithEvents cmdStubsFormat As Button
    Friend WithEvents cmdStubsFont As Button
    Friend WithEvents ucrChkFootNote As ucrCheck
End Class
