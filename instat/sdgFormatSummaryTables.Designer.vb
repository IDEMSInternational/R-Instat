<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sdgFormatSummaryTables
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
        Me.tbpTitle = New System.Windows.Forms.TabPage()
        Me.grpSubtitle = New System.Windows.Forms.GroupBox()
        Me.cmdSubtitleFont = New System.Windows.Forms.Button()
        Me.cmdSubtitleFormat = New System.Windows.Forms.Button()
        Me.lblSubtitleFootnote = New System.Windows.Forms.Label()
        Me.ucrInputSubtitleFootnote = New instat.ucrInputTextBox()
        Me.ucrChkSubtitleFootnote = New instat.ucrCheck()
        Me.ucrInputSubtitle = New instat.ucrInputTextBox()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.ucrChkIncludeTitles = New instat.ucrCheck()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.cmdTitleFont = New System.Windows.Forms.Button()
        Me.cmdTitleFormat = New System.Windows.Forms.Button()
        Me.lblTitleFootnote = New System.Windows.Forms.Label()
        Me.ucrInputTitleFootnote = New instat.ucrInputTextBox()
        Me.ucrChkTitleFootnote = New instat.ucrCheck()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbpStub = New System.Windows.Forms.TabPage()
        Me.ucrChkStub = New instat.ucrCheck()
        Me.grpStub = New System.Windows.Forms.GroupBox()
        Me.cmdStubFont = New System.Windows.Forms.Button()
        Me.cmdStubFormat = New System.Windows.Forms.Button()
        Me.lblStubFootnote = New System.Windows.Forms.Label()
        Me.ucrInputStubFootnote = New instat.ucrInputTextBox()
        Me.ucrChkStubFootnote = New instat.ucrCheck()
        Me.ucrInputStub = New instat.ucrInputTextBox()
        Me.lblStubs = New System.Windows.Forms.Label()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.ucrInputSelectThemes = New instat.ucrInputComboBox()
        Me.cmdManualTheme = New System.Windows.Forms.Button()
        Me.rdoSelectTheme = New System.Windows.Forms.RadioButton()
        Me.rdoManualTheme = New System.Windows.Forms.RadioButton()
        Me.ucrPnlThemesPanel = New instat.UcrPanel()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpTitle.SuspendLayout()
        Me.grpSubtitle.SuspendLayout()
        Me.grpTitle.SuspendLayout()
        Me.tbpStub.SuspendLayout()
        Me.grpStub.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpTitle)
        Me.tbpFormatOptions.Controls.Add(Me.tbpStub)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(12, 12)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(588, 438)
        Me.tbpFormatOptions.TabIndex = 1
        '
        'tbpTitle
        '
        Me.tbpTitle.Controls.Add(Me.ucrChkIncludeTitles)
        Me.tbpTitle.Controls.Add(Me.grpTitle)
        Me.tbpTitle.Controls.Add(Me.grpSubtitle)
        Me.tbpTitle.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitle.Name = "tbpTitle"
        Me.tbpTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitle.Size = New System.Drawing.Size(580, 412)
        Me.tbpTitle.TabIndex = 0
        Me.tbpTitle.Text = "Title"
        Me.tbpTitle.UseVisualStyleBackColor = True
        '
        'grpSubtitle
        '
        Me.grpSubtitle.Controls.Add(Me.cmdSubtitleFormat)
        Me.grpSubtitle.Controls.Add(Me.lblSubtitleFootnote)
        Me.grpSubtitle.Controls.Add(Me.ucrInputSubtitleFootnote)
        Me.grpSubtitle.Controls.Add(Me.ucrChkSubtitleFootnote)
        Me.grpSubtitle.Controls.Add(Me.ucrInputSubtitle)
        Me.grpSubtitle.Controls.Add(Me.lblSubtitle)
        Me.grpSubtitle.Controls.Add(Me.cmdSubtitleFont)
        Me.grpSubtitle.Location = New System.Drawing.Point(12, 224)
        Me.grpSubtitle.Name = "grpSubtitle"
        Me.grpSubtitle.Size = New System.Drawing.Size(479, 119)
        Me.grpSubtitle.TabIndex = 10
        Me.grpSubtitle.TabStop = False
        Me.grpSubtitle.Text = "Subtitle"
        '
        'cmdSubtitleFont
        '
        Me.cmdSubtitleFont.Enabled = False
        Me.cmdSubtitleFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSubtitleFont.Location = New System.Drawing.Point(343, 16)
        Me.cmdSubtitleFont.Name = "cmdSubtitleFont"
        Me.cmdSubtitleFont.Size = New System.Drawing.Size(104, 23)
        Me.cmdSubtitleFont.TabIndex = 20
        Me.cmdSubtitleFont.Text = "Font"
        Me.cmdSubtitleFont.UseVisualStyleBackColor = True
        '
        'cmdSubtitleFormat
        '
        Me.cmdSubtitleFormat.Enabled = False
        Me.cmdSubtitleFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdSubtitleFormat.Location = New System.Drawing.Point(343, 85)
        Me.cmdSubtitleFormat.Name = "cmdSubtitleFormat"
        Me.cmdSubtitleFormat.Size = New System.Drawing.Size(104, 23)
        Me.cmdSubtitleFormat.TabIndex = 19
        Me.cmdSubtitleFormat.Text = "Format"
        Me.cmdSubtitleFormat.UseVisualStyleBackColor = True
        '
        'lblSubtitleFootnote
        '
        Me.lblSubtitleFootnote.AutoSize = True
        Me.lblSubtitleFootnote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubtitleFootnote.Location = New System.Drawing.Point(16, 95)
        Me.lblSubtitleFootnote.Name = "lblSubtitleFootnote"
        Me.lblSubtitleFootnote.Size = New System.Drawing.Size(31, 13)
        Me.lblSubtitleFootnote.TabIndex = 12
        Me.lblSubtitleFootnote.Text = "Text:"
        '
        'ucrInputSubtitleFootnote
        '
        Me.ucrInputSubtitleFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitleFootnote.AutoSize = True
        Me.ucrInputSubtitleFootnote.IsMultiline = False
        Me.ucrInputSubtitleFootnote.IsReadOnly = False
        Me.ucrInputSubtitleFootnote.Location = New System.Drawing.Point(68, 87)
        Me.ucrInputSubtitleFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSubtitleFootnote.Name = "ucrInputSubtitleFootnote"
        Me.ucrInputSubtitleFootnote.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputSubtitleFootnote.TabIndex = 11
        '
        'ucrChkSubtitleFootnote
        '
        Me.ucrChkSubtitleFootnote.AutoSize = True
        Me.ucrChkSubtitleFootnote.Checked = False
        Me.ucrChkSubtitleFootnote.Location = New System.Drawing.Point(70, 46)
        Me.ucrChkSubtitleFootnote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkSubtitleFootnote.Name = "ucrChkSubtitleFootnote"
        Me.ucrChkSubtitleFootnote.Size = New System.Drawing.Size(124, 34)
        Me.ucrChkSubtitleFootnote.TabIndex = 10
        '
        'ucrInputSubtitle
        '
        Me.ucrInputSubtitle.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitle.AutoSize = True
        Me.ucrInputSubtitle.IsMultiline = False
        Me.ucrInputSubtitle.IsReadOnly = False
        Me.ucrInputSubtitle.Location = New System.Drawing.Point(70, 18)
        Me.ucrInputSubtitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSubtitle.Name = "ucrInputSubtitle"
        Me.ucrInputSubtitle.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputSubtitle.TabIndex = 9
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubtitle.Location = New System.Drawing.Point(16, 23)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(31, 13)
        Me.lblSubtitle.TabIndex = 8
        Me.lblSubtitle.Text = "Text:"
        '
        'ucrChkIncludeTitles
        '
        Me.ucrChkIncludeTitles.AutoSize = True
        Me.ucrChkIncludeTitles.Checked = False
        Me.ucrChkIncludeTitles.Location = New System.Drawing.Point(9, 18)
        Me.ucrChkIncludeTitles.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkIncludeTitles.Name = "ucrChkIncludeTitles"
        Me.ucrChkIncludeTitles.Size = New System.Drawing.Size(156, 26)
        Me.ucrChkIncludeTitles.TabIndex = 1
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.cmdTitleFont)
        Me.grpTitle.Controls.Add(Me.cmdTitleFormat)
        Me.grpTitle.Controls.Add(Me.lblTitleFootnote)
        Me.grpTitle.Controls.Add(Me.ucrInputTitleFootnote)
        Me.grpTitle.Controls.Add(Me.ucrChkTitleFootnote)
        Me.grpTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpTitle.Controls.Add(Me.lblTitle)
        Me.grpTitle.Location = New System.Drawing.Point(6, 46)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(479, 120)
        Me.grpTitle.TabIndex = 0
        Me.grpTitle.TabStop = False
        Me.grpTitle.Text = "Title"
        '
        'cmdTitleFont
        '
        Me.cmdTitleFont.Enabled = False
        Me.cmdTitleFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTitleFont.Location = New System.Drawing.Point(350, 25)
        Me.cmdTitleFont.Name = "cmdTitleFont"
        Me.cmdTitleFont.Size = New System.Drawing.Size(104, 23)
        Me.cmdTitleFont.TabIndex = 20
        Me.cmdTitleFont.Text = "Font"
        Me.cmdTitleFont.UseVisualStyleBackColor = True
        '
        'cmdTitleFormat
        '
        Me.cmdTitleFormat.Enabled = False
        Me.cmdTitleFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdTitleFormat.Location = New System.Drawing.Point(349, 86)
        Me.cmdTitleFormat.Name = "cmdTitleFormat"
        Me.cmdTitleFormat.Size = New System.Drawing.Size(104, 23)
        Me.cmdTitleFormat.TabIndex = 19
        Me.cmdTitleFormat.Text = "Format"
        Me.cmdTitleFormat.UseVisualStyleBackColor = True
        '
        'lblTitleFootnote
        '
        Me.lblTitleFootnote.AutoSize = True
        Me.lblTitleFootnote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleFootnote.Location = New System.Drawing.Point(22, 87)
        Me.lblTitleFootnote.Name = "lblTitleFootnote"
        Me.lblTitleFootnote.Size = New System.Drawing.Size(31, 13)
        Me.lblTitleFootnote.TabIndex = 7
        Me.lblTitleFootnote.Text = "Text:"
        '
        'ucrInputTitleFootnote
        '
        Me.ucrInputTitleFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputTitleFootnote.AutoSize = True
        Me.ucrInputTitleFootnote.IsMultiline = False
        Me.ucrInputTitleFootnote.IsReadOnly = False
        Me.ucrInputTitleFootnote.Location = New System.Drawing.Point(69, 87)
        Me.ucrInputTitleFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTitleFootnote.Name = "ucrInputTitleFootnote"
        Me.ucrInputTitleFootnote.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputTitleFootnote.TabIndex = 6
        '
        'ucrChkTitleFootnote
        '
        Me.ucrChkTitleFootnote.AutoSize = True
        Me.ucrChkTitleFootnote.Checked = False
        Me.ucrChkTitleFootnote.Location = New System.Drawing.Point(71, 51)
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
        'tbpStub
        '
        Me.tbpStub.Controls.Add(Me.ucrChkStub)
        Me.tbpStub.Controls.Add(Me.grpStub)
        Me.tbpStub.Location = New System.Drawing.Point(4, 22)
        Me.tbpStub.Name = "tbpStub"
        Me.tbpStub.Size = New System.Drawing.Size(580, 412)
        Me.tbpStub.TabIndex = 5
        Me.tbpStub.Text = "Stub"
        Me.tbpStub.UseVisualStyleBackColor = True
        '
        'ucrChkStub
        '
        Me.ucrChkStub.AutoSize = True
        Me.ucrChkStub.Checked = False
        Me.ucrChkStub.Location = New System.Drawing.Point(10, 18)
        Me.ucrChkStub.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkStub.Name = "ucrChkStub"
        Me.ucrChkStub.Size = New System.Drawing.Size(156, 34)
        Me.ucrChkStub.TabIndex = 2
        '
        'grpStub
        '
        Me.grpStub.Controls.Add(Me.cmdStubFont)
        Me.grpStub.Controls.Add(Me.cmdStubFormat)
        Me.grpStub.Controls.Add(Me.lblStubFootnote)
        Me.grpStub.Controls.Add(Me.ucrInputStubFootnote)
        Me.grpStub.Controls.Add(Me.ucrChkStubFootnote)
        Me.grpStub.Controls.Add(Me.ucrInputStub)
        Me.grpStub.Controls.Add(Me.lblStubs)
        Me.grpStub.Location = New System.Drawing.Point(10, 71)
        Me.grpStub.Name = "grpStub"
        Me.grpStub.Size = New System.Drawing.Size(479, 120)
        Me.grpStub.TabIndex = 1
        Me.grpStub.TabStop = False
        Me.grpStub.Text = "Stub"
        '
        'cmdStubFont
        '
        Me.cmdStubFont.Enabled = False
        Me.cmdStubFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStubFont.Location = New System.Drawing.Point(331, 25)
        Me.cmdStubFont.Name = "cmdStubFont"
        Me.cmdStubFont.Size = New System.Drawing.Size(104, 23)
        Me.cmdStubFont.TabIndex = 20
        Me.cmdStubFont.Text = "Font"
        Me.cmdStubFont.UseVisualStyleBackColor = True
        '
        'cmdStubFormat
        '
        Me.cmdStubFormat.Enabled = False
        Me.cmdStubFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStubFormat.Location = New System.Drawing.Point(331, 84)
        Me.cmdStubFormat.Name = "cmdStubFormat"
        Me.cmdStubFormat.Size = New System.Drawing.Size(104, 23)
        Me.cmdStubFormat.TabIndex = 19
        Me.cmdStubFormat.Text = "Format"
        Me.cmdStubFormat.UseVisualStyleBackColor = True
        '
        'lblStubFootnote
        '
        Me.lblStubFootnote.AutoSize = True
        Me.lblStubFootnote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStubFootnote.Location = New System.Drawing.Point(15, 90)
        Me.lblStubFootnote.Name = "lblStubFootnote"
        Me.lblStubFootnote.Size = New System.Drawing.Size(31, 13)
        Me.lblStubFootnote.TabIndex = 7
        Me.lblStubFootnote.Text = "Text:"
        '
        'ucrInputStubFootnote
        '
        Me.ucrInputStubFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputStubFootnote.AutoSize = True
        Me.ucrInputStubFootnote.IsMultiline = False
        Me.ucrInputStubFootnote.IsReadOnly = False
        Me.ucrInputStubFootnote.Location = New System.Drawing.Point(69, 87)
        Me.ucrInputStubFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputStubFootnote.Name = "ucrInputStubFootnote"
        Me.ucrInputStubFootnote.Size = New System.Drawing.Size(119, 21)
        Me.ucrInputStubFootnote.TabIndex = 6
        '
        'ucrChkStubFootnote
        '
        Me.ucrChkStubFootnote.AutoSize = True
        Me.ucrChkStubFootnote.Checked = False
        Me.ucrChkStubFootnote.Location = New System.Drawing.Point(71, 51)
        Me.ucrChkStubFootnote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkStubFootnote.Name = "ucrChkStubFootnote"
        Me.ucrChkStubFootnote.Size = New System.Drawing.Size(124, 34)
        Me.ucrChkStubFootnote.TabIndex = 4
        '
        'ucrInputStub
        '
        Me.ucrInputStub.AddQuotesIfUnrecognised = True
        Me.ucrInputStub.AutoSize = True
        Me.ucrInputStub.IsMultiline = False
        Me.ucrInputStub.IsReadOnly = False
        Me.ucrInputStub.Location = New System.Drawing.Point(69, 25)
        Me.ucrInputStub.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputStub.Name = "ucrInputStub"
        Me.ucrInputStub.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputStub.TabIndex = 2
        '
        'lblStubs
        '
        Me.lblStubs.AutoSize = True
        Me.lblStubs.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblStubs.Location = New System.Drawing.Point(15, 25)
        Me.lblStubs.Name = "lblStubs"
        Me.lblStubs.Size = New System.Drawing.Size(31, 13)
        Me.lblStubs.TabIndex = 0
        Me.lblStubs.Text = "Text:"
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
        Me.tbpThemes.Size = New System.Drawing.Size(580, 412)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
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
        'ucrPnlThemesPanel
        '
        Me.ucrPnlThemesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlThemesPanel.Location = New System.Drawing.Point(12, 16)
        Me.ucrPnlThemesPanel.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrPnlThemesPanel.Name = "ucrPnlThemesPanel"
        Me.ucrPnlThemesPanel.Size = New System.Drawing.Size(349, 70)
        Me.ucrPnlThemesPanel.TabIndex = 4
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(190, 455)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 3
        '
        'sdgFormatSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(616, 490)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFormatSummaryTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Format Summary Table"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpTitle.ResumeLayout(False)
        Me.tbpTitle.PerformLayout()
        Me.grpSubtitle.ResumeLayout(False)
        Me.grpSubtitle.PerformLayout()
        Me.grpTitle.ResumeLayout(False)
        Me.grpTitle.PerformLayout()
        Me.tbpStub.ResumeLayout(False)
        Me.tbpStub.PerformLayout()
        Me.grpStub.ResumeLayout(False)
        Me.grpStub.PerformLayout()
        Me.tbpThemes.ResumeLayout(False)
        Me.tbpThemes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbpFormatOptions As TabControl
    Friend WithEvents tbpTitle As TabPage
    Friend WithEvents ucrChkIncludeTitles As ucrCheck
    Friend WithEvents grpTitle As GroupBox
    Friend WithEvents ucrInputTitleFootnote As ucrInputTextBox
    Friend WithEvents ucrChkTitleFootnote As ucrCheck
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbpStub As TabPage
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents rdoSelectTheme As RadioButton
    Friend WithEvents cmdManualTheme As Button
    Friend WithEvents rdoManualTheme As RadioButton
    Friend WithEvents ucrInputSelectThemes As ucrInputComboBox
    Friend WithEvents ucrPnlThemesPanel As UcrPanel
    Friend WithEvents grpSubtitle As GroupBox
    Friend WithEvents ucrInputSubtitleFootnote As ucrInputTextBox
    Friend WithEvents ucrChkSubtitleFootnote As ucrCheck
    Friend WithEvents ucrInputSubtitle As ucrInputTextBox
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents grpStub As GroupBox
    Friend WithEvents ucrInputStubFootnote As ucrInputTextBox
    Friend WithEvents ucrChkStubFootnote As ucrCheck
    Friend WithEvents ucrInputStub As ucrInputTextBox
    Friend WithEvents lblStubs As Label
    Friend WithEvents ucrChkStub As ucrCheck
    Friend WithEvents lblSubtitleFootnote As Label
    Friend WithEvents lblTitleFootnote As Label
    Friend WithEvents lblStubFootnote As Label
    Friend WithEvents cmdSubtitleFont As Button
    Friend WithEvents cmdSubtitleFormat As Button
    Friend WithEvents cmdTitleFont As Button
    Friend WithEvents cmdTitleFormat As Button
    Friend WithEvents cmdStubFont As Button
    Friend WithEvents cmdStubFormat As Button
End Class
