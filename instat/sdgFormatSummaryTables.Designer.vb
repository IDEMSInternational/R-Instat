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
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.ucrInputSelectThemes = New instat.ucrInputComboBox()
        Me.cmdManualTheme = New System.Windows.Forms.Button()
        Me.rdoSelectTheme = New System.Windows.Forms.RadioButton()
        Me.rdoManualTheme = New System.Windows.Forms.RadioButton()
        Me.ucrPnlThemesPanel = New instat.UcrPanel()
        Me.tbpStubs = New System.Windows.Forms.TabPage()
        Me.cmdStubsFormat = New System.Windows.Forms.Button()
        Me.ucrChkFootNote = New instat.ucrCheck()
        Me.cmdStubsFont = New System.Windows.Forms.Button()
        Me.ucrImputStubs = New instat.ucrInputTextBox()
        Me.lblStubs = New System.Windows.Forms.Label()
        Me.grpStubs = New System.Windows.Forms.GroupBox()
        Me.lblStubsFootNote = New System.Windows.Forms.Label()
        Me.ucrInputStubsFootNote = New instat.ucrInputTextBox()
        Me.ucrChkStubs = New instat.ucrCheck()
        Me.tbpTitle = New System.Windows.Forms.TabPage()
        Me.grpSubtitle = New System.Windows.Forms.GroupBox()
        Me.lblSubtitleFnText = New System.Windows.Forms.Label()
        Me.cmdSubtitleFont = New System.Windows.Forms.Button()
        Me.cmdSubtitleFormat = New System.Windows.Forms.Button()
        Me.ucrInputSubtitleFootnote = New instat.ucrInputTextBox()
        Me.ucrChkSubtitleFootnote = New instat.ucrCheck()
        Me.UcrInputSubtitle = New instat.ucrInputTextBox()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.grpSecondFootnote = New System.Windows.Forms.GroupBox()
        Me.ucrInputSecondFootnoteColumnLocation = New instat.ucrInputTextBox()
        Me.ucrInputSecondFootnoteRowLocation = New instat.ucrInputTextBox()
        Me.lblSecondColumns = New System.Windows.Forms.Label()
        Me.lblSecondRows = New System.Windows.Forms.Label()
        Me.lblSecondFootnote = New System.Windows.Forms.Label()
        Me.ucrInputSecondCellFootnote = New instat.ucrInputTextBox()
        Me.ucrChKAddSecondFootnote = New instat.ucrCheck()
        Me.lblFootnote = New System.Windows.Forms.Label()
        Me.ucrInputCellFootnote = New instat.ucrInputTextBox()
        Me.ucrInputAddSourceNote = New instat.ucrInputTextBox()
        Me.ucrChkAddSourcenote = New instat.ucrCheck()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.ucrInputFootnoteColumnLocation = New instat.ucrInputTextBox()
        Me.ucrInputFootnoteRowLocation = New instat.ucrInputTextBox()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.ucrChkAddFootnote = New instat.ucrCheck()
        Me.ucrChkAddTitleSubtitle = New instat.ucrCheck()
        Me.grpTitle = New System.Windows.Forms.GroupBox()
        Me.lblTitlefnText = New System.Windows.Forms.Label()
        Me.cmdTitleFont = New System.Windows.Forms.Button()
        Me.cmdTitleFormat = New System.Windows.Forms.Button()
        Me.ucrInputTitleFont = New instat.ucrInputTextBox()
        Me.ucrNudTitleSize = New instat.ucrNud()
        Me.lblTitleSize = New System.Windows.Forms.Label()
        Me.lblTitleFont = New System.Windows.Forms.Label()
        Me.ucrInputTitleFootnote = New instat.ucrInputTextBox()
        Me.ucrChkTitleFootnote = New instat.ucrCheck()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbpFormatOptions = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tbpThemes.SuspendLayout()
        Me.tbpStubs.SuspendLayout()
        Me.grpStubs.SuspendLayout()
        Me.tbpTitle.SuspendLayout()
        Me.grpSubtitle.SuspendLayout()
        Me.grpSecondFootnote.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpTitle.SuspendLayout()
        Me.tbpFormatOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(190, 669)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(4)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(224, 29)
        Me.ucrBaseSubdialog.TabIndex = 3
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
        Me.tbpThemes.Size = New System.Drawing.Size(580, 629)
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
        'tbpStubs
        '
        Me.tbpStubs.Controls.Add(Me.cmdStubsFormat)
        Me.tbpStubs.Controls.Add(Me.ucrChkFootNote)
        Me.tbpStubs.Controls.Add(Me.cmdStubsFont)
        Me.tbpStubs.Controls.Add(Me.ucrImputStubs)
        Me.tbpStubs.Controls.Add(Me.lblStubs)
        Me.tbpStubs.Controls.Add(Me.grpStubs)
        Me.tbpStubs.Controls.Add(Me.ucrChkStubs)
        Me.tbpStubs.Location = New System.Drawing.Point(4, 22)
        Me.tbpStubs.Name = "tbpStubs"
        Me.tbpStubs.Size = New System.Drawing.Size(580, 629)
        Me.tbpStubs.TabIndex = 5
        Me.tbpStubs.Text = "Stubs"
        Me.tbpStubs.UseVisualStyleBackColor = True
        '
        'cmdStubsFormat
        '
        Me.cmdStubsFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStubsFormat.Location = New System.Drawing.Point(398, 165)
        Me.cmdStubsFormat.Name = "cmdStubsFormat"
        Me.cmdStubsFormat.Size = New System.Drawing.Size(104, 23)
        Me.cmdStubsFormat.TabIndex = 23
        Me.cmdStubsFormat.Text = "Format"
        Me.cmdStubsFormat.UseVisualStyleBackColor = True
        '
        'ucrChkFootNote
        '
        Me.ucrChkFootNote.AutoSize = True
        Me.ucrChkFootNote.Checked = False
        Me.ucrChkFootNote.Location = New System.Drawing.Point(22, 129)
        Me.ucrChkFootNote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkFootNote.Name = "ucrChkFootNote"
        Me.ucrChkFootNote.Size = New System.Drawing.Size(124, 34)
        Me.ucrChkFootNote.TabIndex = 22
        '
        'cmdStubsFont
        '
        Me.cmdStubsFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.cmdStubsFont.Location = New System.Drawing.Point(397, 81)
        Me.cmdStubsFont.Name = "cmdStubsFont"
        Me.cmdStubsFont.Size = New System.Drawing.Size(104, 23)
        Me.cmdStubsFont.TabIndex = 21
        Me.cmdStubsFont.Text = "Font"
        Me.cmdStubsFont.UseVisualStyleBackColor = True
        '
        'ucrImputStubs
        '
        Me.ucrImputStubs.AddQuotesIfUnrecognised = True
        Me.ucrImputStubs.AutoSize = True
        Me.ucrImputStubs.IsMultiline = False
        Me.ucrImputStubs.IsReadOnly = False
        Me.ucrImputStubs.Location = New System.Drawing.Point(68, 82)
        Me.ucrImputStubs.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrImputStubs.Name = "ucrImputStubs"
        Me.ucrImputStubs.Size = New System.Drawing.Size(137, 21)
        Me.ucrImputStubs.TabIndex = 20
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
        Me.grpStubs.Controls.Add(Me.lblStubsFootNote)
        Me.grpStubs.Controls.Add(Me.ucrInputStubsFootNote)
        Me.grpStubs.Location = New System.Drawing.Point(11, 65)
        Me.grpStubs.Name = "grpStubs"
        Me.grpStubs.Size = New System.Drawing.Size(496, 139)
        Me.grpStubs.TabIndex = 3
        Me.grpStubs.TabStop = False
        Me.grpStubs.Text = "Stub"
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
        'tbpTitle
        '
        Me.tbpTitle.Controls.Add(Me.grpSubtitle)
        Me.tbpTitle.Controls.Add(Me.grpSecondFootnote)
        Me.tbpTitle.Controls.Add(Me.lblSecondFootnote)
        Me.tbpTitle.Controls.Add(Me.ucrInputSecondCellFootnote)
        Me.tbpTitle.Controls.Add(Me.ucrChKAddSecondFootnote)
        Me.tbpTitle.Controls.Add(Me.lblFootnote)
        Me.tbpTitle.Controls.Add(Me.ucrInputCellFootnote)
        Me.tbpTitle.Controls.Add(Me.ucrInputAddSourceNote)
        Me.tbpTitle.Controls.Add(Me.ucrChkAddSourcenote)
        Me.tbpTitle.Controls.Add(Me.grpLocation)
        Me.tbpTitle.Controls.Add(Me.ucrChkAddFootnote)
        Me.tbpTitle.Controls.Add(Me.ucrChkAddTitleSubtitle)
        Me.tbpTitle.Controls.Add(Me.grpTitle)
        Me.tbpTitle.Location = New System.Drawing.Point(4, 22)
        Me.tbpTitle.Name = "tbpTitle"
        Me.tbpTitle.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpTitle.Size = New System.Drawing.Size(580, 629)
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
        Me.grpSubtitle.Controls.Add(Me.UcrInputSubtitle)
        Me.grpSubtitle.Controls.Add(Me.lblSubtitle)
        Me.grpSubtitle.Location = New System.Drawing.Point(7, 198)
        Me.grpSubtitle.Name = "grpSubtitle"
        Me.grpSubtitle.Size = New System.Drawing.Size(479, 139)
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
        'UcrInputSubtitle
        '
        Me.UcrInputSubtitle.AddQuotesIfUnrecognised = True
        Me.UcrInputSubtitle.AutoSize = True
        Me.UcrInputSubtitle.IsMultiline = False
        Me.UcrInputSubtitle.IsReadOnly = False
        Me.UcrInputSubtitle.Location = New System.Drawing.Point(69, 11)
        Me.UcrInputSubtitle.Margin = New System.Windows.Forms.Padding(9)
        Me.UcrInputSubtitle.Name = "UcrInputSubtitle"
        Me.UcrInputSubtitle.Size = New System.Drawing.Size(137, 21)
        Me.UcrInputSubtitle.TabIndex = 3
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
        'grpSecondFootnote
        '
        Me.grpSecondFootnote.Controls.Add(Me.ucrInputSecondFootnoteColumnLocation)
        Me.grpSecondFootnote.Controls.Add(Me.ucrInputSecondFootnoteRowLocation)
        Me.grpSecondFootnote.Controls.Add(Me.lblSecondColumns)
        Me.grpSecondFootnote.Controls.Add(Me.lblSecondRows)
        Me.grpSecondFootnote.Location = New System.Drawing.Point(11, 510)
        Me.grpSecondFootnote.Name = "grpSecondFootnote"
        Me.grpSecondFootnote.Size = New System.Drawing.Size(476, 74)
        Me.grpSecondFootnote.TabIndex = 11
        Me.grpSecondFootnote.TabStop = False
        Me.grpSecondFootnote.Text = "Location"
        '
        'ucrInputSecondFootnoteColumnLocation
        '
        Me.ucrInputSecondFootnoteColumnLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputSecondFootnoteColumnLocation.AutoSize = True
        Me.ucrInputSecondFootnoteColumnLocation.IsMultiline = False
        Me.ucrInputSecondFootnoteColumnLocation.IsReadOnly = False
        Me.ucrInputSecondFootnoteColumnLocation.Location = New System.Drawing.Point(69, 22)
        Me.ucrInputSecondFootnoteColumnLocation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSecondFootnoteColumnLocation.Name = "ucrInputSecondFootnoteColumnLocation"
        Me.ucrInputSecondFootnoteColumnLocation.Size = New System.Drawing.Size(134, 21)
        Me.ucrInputSecondFootnoteColumnLocation.TabIndex = 6
        '
        'ucrInputSecondFootnoteRowLocation
        '
        Me.ucrInputSecondFootnoteRowLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputSecondFootnoteRowLocation.AutoSize = True
        Me.ucrInputSecondFootnoteRowLocation.IsMultiline = False
        Me.ucrInputSecondFootnoteRowLocation.IsReadOnly = False
        Me.ucrInputSecondFootnoteRowLocation.Location = New System.Drawing.Point(69, 50)
        Me.ucrInputSecondFootnoteRowLocation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSecondFootnoteRowLocation.Name = "ucrInputSecondFootnoteRowLocation"
        Me.ucrInputSecondFootnoteRowLocation.Size = New System.Drawing.Size(134, 21)
        Me.ucrInputSecondFootnoteRowLocation.TabIndex = 5
        '
        'lblSecondColumns
        '
        Me.lblSecondColumns.AutoSize = True
        Me.lblSecondColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondColumns.Location = New System.Drawing.Point(15, 26)
        Me.lblSecondColumns.Name = "lblSecondColumns"
        Me.lblSecondColumns.Size = New System.Drawing.Size(50, 13)
        Me.lblSecondColumns.TabIndex = 4
        Me.lblSecondColumns.Text = "Columns:"
        '
        'lblSecondRows
        '
        Me.lblSecondRows.AutoSize = True
        Me.lblSecondRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondRows.Location = New System.Drawing.Point(15, 54)
        Me.lblSecondRows.Name = "lblSecondRows"
        Me.lblSecondRows.Size = New System.Drawing.Size(37, 13)
        Me.lblSecondRows.TabIndex = 3
        Me.lblSecondRows.Text = "Rows:"
        '
        'lblSecondFootnote
        '
        Me.lblSecondFootnote.AutoSize = True
        Me.lblSecondFootnote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondFootnote.Location = New System.Drawing.Point(137, 469)
        Me.lblSecondFootnote.Name = "lblSecondFootnote"
        Me.lblSecondFootnote.Size = New System.Drawing.Size(52, 13)
        Me.lblSecondFootnote.TabIndex = 13
        Me.lblSecondFootnote.Text = "Footnote:"
        '
        'ucrInputSecondCellFootnote
        '
        Me.ucrInputSecondCellFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputSecondCellFootnote.AutoSize = True
        Me.ucrInputSecondCellFootnote.IsMultiline = False
        Me.ucrInputSecondCellFootnote.IsReadOnly = False
        Me.ucrInputSecondCellFootnote.Location = New System.Drawing.Point(190, 467)
        Me.ucrInputSecondCellFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputSecondCellFootnote.Name = "ucrInputSecondCellFootnote"
        Me.ucrInputSecondCellFootnote.Size = New System.Drawing.Size(132, 21)
        Me.ucrInputSecondCellFootnote.TabIndex = 12
        '
        'ucrChKAddSecondFootnote
        '
        Me.ucrChKAddSecondFootnote.AutoSize = True
        Me.ucrChKAddSecondFootnote.Checked = False
        Me.ucrChKAddSecondFootnote.Location = New System.Drawing.Point(9, 467)
        Me.ucrChKAddSecondFootnote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChKAddSecondFootnote.Name = "ucrChKAddSecondFootnote"
        Me.ucrChKAddSecondFootnote.Size = New System.Drawing.Size(133, 34)
        Me.ucrChKAddSecondFootnote.TabIndex = 10
        '
        'lblFootnote
        '
        Me.lblFootnote.AutoSize = True
        Me.lblFootnote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFootnote.Location = New System.Drawing.Point(135, 361)
        Me.lblFootnote.Name = "lblFootnote"
        Me.lblFootnote.Size = New System.Drawing.Size(52, 13)
        Me.lblFootnote.TabIndex = 9
        Me.lblFootnote.Text = "Footnote:"
        '
        'ucrInputCellFootnote
        '
        Me.ucrInputCellFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputCellFootnote.AutoSize = True
        Me.ucrInputCellFootnote.IsMultiline = False
        Me.ucrInputCellFootnote.IsReadOnly = False
        Me.ucrInputCellFootnote.Location = New System.Drawing.Point(188, 359)
        Me.ucrInputCellFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputCellFootnote.Name = "ucrInputCellFootnote"
        Me.ucrInputCellFootnote.Size = New System.Drawing.Size(134, 21)
        Me.ucrInputCellFootnote.TabIndex = 8
        '
        'ucrInputAddSourceNote
        '
        Me.ucrInputAddSourceNote.AddQuotesIfUnrecognised = True
        Me.ucrInputAddSourceNote.AutoSize = True
        Me.ucrInputAddSourceNote.IsMultiline = False
        Me.ucrInputAddSourceNote.IsReadOnly = False
        Me.ucrInputAddSourceNote.Location = New System.Drawing.Point(148, 591)
        Me.ucrInputAddSourceNote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputAddSourceNote.Name = "ucrInputAddSourceNote"
        Me.ucrInputAddSourceNote.Size = New System.Drawing.Size(104, 21)
        Me.ucrInputAddSourceNote.TabIndex = 7
        '
        'ucrChkAddSourcenote
        '
        Me.ucrChkAddSourcenote.AutoSize = True
        Me.ucrChkAddSourcenote.Checked = False
        Me.ucrChkAddSourcenote.Location = New System.Drawing.Point(9, 591)
        Me.ucrChkAddSourcenote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkAddSourcenote.Name = "ucrChkAddSourcenote"
        Me.ucrChkAddSourcenote.Size = New System.Drawing.Size(133, 34)
        Me.ucrChkAddSourcenote.TabIndex = 6
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.ucrInputFootnoteColumnLocation)
        Me.grpLocation.Controls.Add(Me.ucrInputFootnoteRowLocation)
        Me.grpLocation.Controls.Add(Me.lblColumns)
        Me.grpLocation.Controls.Add(Me.lblRows)
        Me.grpLocation.Location = New System.Drawing.Point(11, 391)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Size = New System.Drawing.Size(474, 68)
        Me.grpLocation.TabIndex = 5
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Location"
        '
        'ucrInputFootnoteColumnLocation
        '
        Me.ucrInputFootnoteColumnLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputFootnoteColumnLocation.AutoSize = True
        Me.ucrInputFootnoteColumnLocation.IsMultiline = False
        Me.ucrInputFootnoteColumnLocation.IsReadOnly = False
        Me.ucrInputFootnoteColumnLocation.Location = New System.Drawing.Point(69, 16)
        Me.ucrInputFootnoteColumnLocation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputFootnoteColumnLocation.Name = "ucrInputFootnoteColumnLocation"
        Me.ucrInputFootnoteColumnLocation.Size = New System.Drawing.Size(134, 21)
        Me.ucrInputFootnoteColumnLocation.TabIndex = 6
        '
        'ucrInputFootnoteRowLocation
        '
        Me.ucrInputFootnoteRowLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputFootnoteRowLocation.AutoSize = True
        Me.ucrInputFootnoteRowLocation.IsMultiline = False
        Me.ucrInputFootnoteRowLocation.IsReadOnly = False
        Me.ucrInputFootnoteRowLocation.Location = New System.Drawing.Point(69, 44)
        Me.ucrInputFootnoteRowLocation.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputFootnoteRowLocation.Name = "ucrInputFootnoteRowLocation"
        Me.ucrInputFootnoteRowLocation.Size = New System.Drawing.Size(134, 21)
        Me.ucrInputFootnoteRowLocation.TabIndex = 5
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(15, 20)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(50, 13)
        Me.lblColumns.TabIndex = 4
        Me.lblColumns.Text = "Columns:"
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRows.Location = New System.Drawing.Point(15, 48)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(37, 13)
        Me.lblRows.TabIndex = 3
        Me.lblRows.Text = "Rows:"
        '
        'ucrChkAddFootnote
        '
        Me.ucrChkAddFootnote.AutoSize = True
        Me.ucrChkAddFootnote.Checked = False
        Me.ucrChkAddFootnote.Location = New System.Drawing.Point(6, 357)
        Me.ucrChkAddFootnote.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkAddFootnote.Name = "ucrChkAddFootnote"
        Me.ucrChkAddFootnote.Size = New System.Drawing.Size(133, 34)
        Me.ucrChkAddFootnote.TabIndex = 2
        '
        'ucrChkAddTitleSubtitle
        '
        Me.ucrChkAddTitleSubtitle.AutoSize = True
        Me.ucrChkAddTitleSubtitle.Checked = False
        Me.ucrChkAddTitleSubtitle.Location = New System.Drawing.Point(9, 18)
        Me.ucrChkAddTitleSubtitle.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrChkAddTitleSubtitle.Name = "ucrChkAddTitleSubtitle"
        Me.ucrChkAddTitleSubtitle.Size = New System.Drawing.Size(156, 34)
        Me.ucrChkAddTitleSubtitle.TabIndex = 1
        '
        'grpTitle
        '
        Me.grpTitle.Controls.Add(Me.lblTitlefnText)
        Me.grpTitle.Controls.Add(Me.cmdTitleFont)
        Me.grpTitle.Controls.Add(Me.cmdTitleFormat)
        Me.grpTitle.Controls.Add(Me.ucrInputTitleFont)
        Me.grpTitle.Controls.Add(Me.ucrNudTitleSize)
        Me.grpTitle.Controls.Add(Me.lblTitleSize)
        Me.grpTitle.Controls.Add(Me.lblTitleFont)
        Me.grpTitle.Controls.Add(Me.ucrInputTitleFootnote)
        Me.grpTitle.Controls.Add(Me.ucrChkTitleFootnote)
        Me.grpTitle.Controls.Add(Me.ucrInputTitle)
        Me.grpTitle.Controls.Add(Me.lblTitle)
        Me.grpTitle.Location = New System.Drawing.Point(6, 46)
        Me.grpTitle.Name = "grpTitle"
        Me.grpTitle.Size = New System.Drawing.Size(479, 139)
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
        'ucrInputTitleFont
        '
        Me.ucrInputTitleFont.AddQuotesIfUnrecognised = True
        Me.ucrInputTitleFont.AutoSize = True
        Me.ucrInputTitleFont.IsMultiline = False
        Me.ucrInputTitleFont.IsReadOnly = False
        Me.ucrInputTitleFont.Location = New System.Drawing.Point(69, 115)
        Me.ucrInputTitleFont.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrInputTitleFont.Name = "ucrInputTitleFont"
        Me.ucrInputTitleFont.Size = New System.Drawing.Size(137, 21)
        Me.ucrInputTitleFont.TabIndex = 16
        '
        'ucrNudTitleSize
        '
        Me.ucrNudTitleSize.AutoSize = True
        Me.ucrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTitleSize.Location = New System.Drawing.Point(342, 115)
        Me.ucrNudTitleSize.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Name = "ucrNudTitleSize"
        Me.ucrNudTitleSize.Size = New System.Drawing.Size(50, 20)
        Me.ucrNudTitleSize.TabIndex = 15
        Me.ucrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'lblTitleSize
        '
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleSize.Location = New System.Drawing.Point(218, 122)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(53, 13)
        Me.lblTitleSize.TabIndex = 9
        Me.lblTitleSize.Text = "Title Size:"
        '
        'lblTitleFont
        '
        Me.lblTitleFont.AutoSize = True
        Me.lblTitleFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleFont.Location = New System.Drawing.Point(14, 118)
        Me.lblTitleFont.Name = "lblTitleFont"
        Me.lblTitleFont.Size = New System.Drawing.Size(54, 13)
        Me.lblTitleFont.TabIndex = 8
        Me.lblTitleFont.Text = "Title Font:"
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
        Me.tbpFormatOptions.Controls.Add(Me.TabPage1)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(12, 12)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(588, 655)
        Me.tbpFormatOptions.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(580, 629)
        Me.TabPage1.TabIndex = 7
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'sdgFormatSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(616, 700)
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
        Me.grpSecondFootnote.ResumeLayout(False)
        Me.grpSecondFootnote.PerformLayout()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
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
    Friend WithEvents grpSecondFootnote As GroupBox
    Friend WithEvents ucrInputSecondFootnoteColumnLocation As ucrInputTextBox
    Friend WithEvents ucrInputSecondFootnoteRowLocation As ucrInputTextBox
    Friend WithEvents lblSecondColumns As Label
    Friend WithEvents lblSecondRows As Label
    Friend WithEvents lblSecondFootnote As Label
    Friend WithEvents ucrInputSecondCellFootnote As ucrInputTextBox
    Friend WithEvents ucrChKAddSecondFootnote As ucrCheck
    Friend WithEvents lblFootnote As Label
    Friend WithEvents ucrInputCellFootnote As ucrInputTextBox
    Friend WithEvents ucrInputAddSourceNote As ucrInputTextBox
    Friend WithEvents ucrChkAddSourcenote As ucrCheck
    Friend WithEvents grpLocation As GroupBox
    Friend WithEvents ucrInputFootnoteColumnLocation As ucrInputTextBox
    Friend WithEvents ucrInputFootnoteRowLocation As ucrInputTextBox
    Friend WithEvents lblColumns As Label
    Friend WithEvents lblRows As Label
    Friend WithEvents ucrChkAddFootnote As ucrCheck
    Friend WithEvents ucrChkAddTitleSubtitle As ucrCheck
    Friend WithEvents grpTitle As GroupBox
    Friend WithEvents ucrInputTitleFont As ucrInputTextBox
    Friend WithEvents ucrNudTitleSize As ucrNud
    Friend WithEvents lblTitleSize As Label
    Friend WithEvents lblTitleFont As Label
    Friend WithEvents ucrInputTitleFootnote As ucrInputTextBox
    Friend WithEvents ucrChkTitleFootnote As ucrCheck
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents tbpFormatOptions As TabControl
    Friend WithEvents grpSubtitle As GroupBox
    Friend WithEvents ucrInputSubtitleFootnote As ucrInputTextBox
    Friend WithEvents ucrChkSubtitleFootnote As ucrCheck
    Friend WithEvents UcrInputSubtitle As ucrInputTextBox
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblSubtitleFnText As Label
    Friend WithEvents cmdSubtitleFont As Button
    Friend WithEvents cmdSubtitleFormat As Button
    Friend WithEvents lblTitlefnText As Label
    Friend WithEvents cmdTitleFont As Button
    Friend WithEvents cmdTitleFormat As Button
    Friend WithEvents grpStubs As GroupBox
    Friend WithEvents ucrChkStubs As ucrCheck
    Friend WithEvents cmdStubsFont As Button
    Friend WithEvents ucrImputStubs As ucrInputTextBox
    Friend WithEvents lblStubs As Label
    Friend WithEvents ucrChkFootNote As ucrCheck
    Friend WithEvents cmdStubsFormat As Button
    Friend WithEvents lblStubsFootNote As Label
    Friend WithEvents ucrInputStubsFootNote As ucrInputTextBox
    Friend WithEvents TabPage1 As TabPage
End Class
