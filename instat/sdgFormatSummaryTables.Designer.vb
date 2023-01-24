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
        Me.grpSecondFootnote = New System.Windows.Forms.GroupBox()
        Me.lblSecondColumns = New System.Windows.Forms.Label()
        Me.lblSecondRows = New System.Windows.Forms.Label()
        Me.lblSecondFootnote = New System.Windows.Forms.Label()
        Me.lblFootnote = New System.Windows.Forms.Label()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.grpTitleSubtitle = New System.Windows.Forms.GroupBox()
        Me.lblTitleSize = New System.Windows.Forms.Label()
        Me.lblTitleFont = New System.Windows.Forms.Label()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbpFacets = New System.Windows.Forms.TabPage()
        Me.tbpRows = New System.Windows.Forms.TabPage()
        Me.tbpColumns = New System.Windows.Forms.TabPage()
        Me.tbpThemes = New System.Windows.Forms.TabPage()
        Me.cmdManualTheme = New System.Windows.Forms.Button()
        Me.rdoSelectTheme = New System.Windows.Forms.RadioButton()
        Me.rdoManualTheme = New System.Windows.Forms.RadioButton()
        Me.ucrBaseSubdialog = New instat.ucrButtonsSubdialogue()
        Me.ucrInputSecondFootnoteColumnLocation = New instat.ucrInputTextBox()
        Me.ucrInputSecondFootnoteRowLocation = New instat.ucrInputTextBox()
        Me.ucrInputSecondCellFootnote = New instat.ucrInputTextBox()
        Me.ucrChKAddSecondFootnote = New instat.ucrCheck()
        Me.ucrInputCellFootnote = New instat.ucrInputTextBox()
        Me.ucrInputAddSourceNote = New instat.ucrInputTextBox()
        Me.ucrChkAddSourcenote = New instat.ucrCheck()
        Me.ucrInputFootnoteColumnLocation = New instat.ucrInputTextBox()
        Me.ucrInputFootnoteRowLocation = New instat.ucrInputTextBox()
        Me.ucrChkAddFootnote = New instat.ucrCheck()
        Me.ucrChkAddTitleSubtitle = New instat.ucrCheck()
        Me.ucrInputTitleFont = New instat.ucrInputTextBox()
        Me.ucrNudTitleSize = New instat.ucrNud()
        Me.ucrInputSubtitleFootnote = New instat.ucrInputTextBox()
        Me.ucrInputTitleFootnote = New instat.ucrInputTextBox()
        Me.ucrChkSubtitleFootnote = New instat.ucrCheck()
        Me.ucrChkTitleFootnote = New instat.ucrCheck()
        Me.ucrInputSubtitle = New instat.ucrInputTextBox()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.ucrInputSelectThemes = New instat.ucrInputComboBox()
        Me.ucrPnlThemesPanel = New instat.UcrPanel()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpTitle.SuspendLayout()
        Me.grpSecondFootnote.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpTitleSubtitle.SuspendLayout()
        Me.tbpThemes.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpTitle)
        Me.tbpFormatOptions.Controls.Add(Me.tbpFacets)
        Me.tbpFormatOptions.Controls.Add(Me.tbpRows)
        Me.tbpFormatOptions.Controls.Add(Me.tbpColumns)
        Me.tbpFormatOptions.Controls.Add(Me.tbpThemes)
        Me.tbpFormatOptions.Location = New System.Drawing.Point(18, 18)
        Me.tbpFormatOptions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        Me.tbpFormatOptions.Size = New System.Drawing.Size(882, 657)
        Me.tbpFormatOptions.TabIndex = 1
        '
        'tbpTitle
        '
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
        Me.tbpTitle.Controls.Add(Me.grpTitleSubtitle)
        Me.tbpTitle.Location = New System.Drawing.Point(4, 29)
        Me.tbpTitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpTitle.Name = "tbpTitle"
        Me.tbpTitle.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpTitle.Size = New System.Drawing.Size(874, 624)
        Me.tbpTitle.TabIndex = 0
        Me.tbpTitle.Text = "Title"
        Me.tbpTitle.UseVisualStyleBackColor = True
        '
        'grpSecondFootnote
        '
        Me.grpSecondFootnote.Controls.Add(Me.ucrInputSecondFootnoteColumnLocation)
        Me.grpSecondFootnote.Controls.Add(Me.ucrInputSecondFootnoteRowLocation)
        Me.grpSecondFootnote.Controls.Add(Me.lblSecondColumns)
        Me.grpSecondFootnote.Controls.Add(Me.lblSecondRows)
        Me.grpSecondFootnote.Location = New System.Drawing.Point(16, 446)
        Me.grpSecondFootnote.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSecondFootnote.Name = "grpSecondFootnote"
        Me.grpSecondFootnote.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpSecondFootnote.Size = New System.Drawing.Size(714, 111)
        Me.grpSecondFootnote.TabIndex = 11
        Me.grpSecondFootnote.TabStop = False
        Me.grpSecondFootnote.Text = "Location"
        '
        'lblSecondColumns
        '
        Me.lblSecondColumns.AutoSize = True
        Me.lblSecondColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondColumns.Location = New System.Drawing.Point(22, 39)
        Me.lblSecondColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondColumns.Name = "lblSecondColumns"
        Me.lblSecondColumns.Size = New System.Drawing.Size(75, 20)
        Me.lblSecondColumns.TabIndex = 4
        Me.lblSecondColumns.Text = "Columns:"
        '
        'lblSecondRows
        '
        Me.lblSecondRows.AutoSize = True
        Me.lblSecondRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondRows.Location = New System.Drawing.Point(22, 81)
        Me.lblSecondRows.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondRows.Name = "lblSecondRows"
        Me.lblSecondRows.Size = New System.Drawing.Size(53, 20)
        Me.lblSecondRows.TabIndex = 3
        Me.lblSecondRows.Text = "Rows:"
        '
        'lblSecondFootnote
        '
        Me.lblSecondFootnote.AutoSize = True
        Me.lblSecondFootnote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSecondFootnote.Location = New System.Drawing.Point(206, 418)
        Me.lblSecondFootnote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSecondFootnote.Name = "lblSecondFootnote"
        Me.lblSecondFootnote.Size = New System.Drawing.Size(78, 20)
        Me.lblSecondFootnote.TabIndex = 13
        Me.lblSecondFootnote.Text = "Footnote:"
        '
        'lblFootnote
        '
        Me.lblFootnote.AutoSize = True
        Me.lblFootnote.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblFootnote.Location = New System.Drawing.Point(202, 264)
        Me.lblFootnote.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFootnote.Name = "lblFootnote"
        Me.lblFootnote.Size = New System.Drawing.Size(78, 20)
        Me.lblFootnote.TabIndex = 9
        Me.lblFootnote.Text = "Footnote:"
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.ucrInputFootnoteColumnLocation)
        Me.grpLocation.Controls.Add(Me.ucrInputFootnoteRowLocation)
        Me.grpLocation.Controls.Add(Me.lblColumns)
        Me.grpLocation.Controls.Add(Me.lblRows)
        Me.grpLocation.Location = New System.Drawing.Point(16, 297)
        Me.grpLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpLocation.Size = New System.Drawing.Size(711, 102)
        Me.grpLocation.TabIndex = 5
        Me.grpLocation.TabStop = False
        Me.grpLocation.Text = "Location"
        '
        'lblColumns
        '
        Me.lblColumns.AutoSize = True
        Me.lblColumns.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblColumns.Location = New System.Drawing.Point(22, 30)
        Me.lblColumns.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblColumns.Name = "lblColumns"
        Me.lblColumns.Size = New System.Drawing.Size(75, 20)
        Me.lblColumns.TabIndex = 4
        Me.lblColumns.Text = "Columns:"
        '
        'lblRows
        '
        Me.lblRows.AutoSize = True
        Me.lblRows.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblRows.Location = New System.Drawing.Point(22, 72)
        Me.lblRows.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRows.Name = "lblRows"
        Me.lblRows.Size = New System.Drawing.Size(53, 20)
        Me.lblRows.TabIndex = 3
        Me.lblRows.Text = "Rows:"
        '
        'grpTitleSubtitle
        '
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputTitleFont)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrNudTitleSize)
        Me.grpTitleSubtitle.Controls.Add(Me.lblTitleSize)
        Me.grpTitleSubtitle.Controls.Add(Me.lblTitleFont)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputSubtitleFootnote)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputTitleFootnote)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrChkSubtitleFootnote)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrChkTitleFootnote)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputSubtitle)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputTitle)
        Me.grpTitleSubtitle.Controls.Add(Me.lblSubtitle)
        Me.grpTitleSubtitle.Controls.Add(Me.lblTitle)
        Me.grpTitleSubtitle.Location = New System.Drawing.Point(9, 69)
        Me.grpTitleSubtitle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTitleSubtitle.Name = "grpTitleSubtitle"
        Me.grpTitleSubtitle.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpTitleSubtitle.Size = New System.Drawing.Size(718, 180)
        Me.grpTitleSubtitle.TabIndex = 0
        Me.grpTitleSubtitle.TabStop = False
        Me.grpTitleSubtitle.Text = "Title\Subtitle"
        '
        'lblTitleSize
        '
        Me.lblTitleSize.AutoSize = True
        Me.lblTitleSize.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleSize.Location = New System.Drawing.Point(327, 134)
        Me.lblTitleSize.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleSize.Name = "lblTitleSize"
        Me.lblTitleSize.Size = New System.Drawing.Size(77, 20)
        Me.lblTitleSize.TabIndex = 9
        Me.lblTitleSize.Text = "Title Size:"
        '
        'lblTitleFont
        '
        Me.lblTitleFont.AutoSize = True
        Me.lblTitleFont.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitleFont.Location = New System.Drawing.Point(21, 128)
        Me.lblTitleFont.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitleFont.Name = "lblTitleFont"
        Me.lblTitleFont.Size = New System.Drawing.Size(79, 20)
        Me.lblTitleFont.TabIndex = 8
        Me.lblTitleFont.Text = "Title Font:"
        '
        'lblSubtitle
        '
        Me.lblSubtitle.AutoSize = True
        Me.lblSubtitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblSubtitle.Location = New System.Drawing.Point(22, 90)
        Me.lblSubtitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSubtitle.Name = "lblSubtitle"
        Me.lblSubtitle.Size = New System.Drawing.Size(67, 20)
        Me.lblSubtitle.TabIndex = 1
        Me.lblSubtitle.Text = "Subtitle:"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.lblTitle.Location = New System.Drawing.Point(22, 38)
        Me.lblTitle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(42, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Title:"
        '
        'tbpFacets
        '
        Me.tbpFacets.Location = New System.Drawing.Point(4, 29)
        Me.tbpFacets.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpFacets.Name = "tbpFacets"
        Me.tbpFacets.Size = New System.Drawing.Size(874, 624)
        Me.tbpFacets.TabIndex = 3
        Me.tbpFacets.Text = "Facets"
        Me.tbpFacets.UseVisualStyleBackColor = True
        '
        'tbpRows
        '
        Me.tbpRows.Location = New System.Drawing.Point(4, 29)
        Me.tbpRows.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpRows.Name = "tbpRows"
        Me.tbpRows.Size = New System.Drawing.Size(874, 624)
        Me.tbpRows.TabIndex = 4
        Me.tbpRows.Text = "Rows"
        Me.tbpRows.UseVisualStyleBackColor = True
        '
        'tbpColumns
        '
        Me.tbpColumns.Location = New System.Drawing.Point(4, 29)
        Me.tbpColumns.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpColumns.Name = "tbpColumns"
        Me.tbpColumns.Size = New System.Drawing.Size(874, 624)
        Me.tbpColumns.TabIndex = 5
        Me.tbpColumns.Text = "Columns"
        Me.tbpColumns.UseVisualStyleBackColor = True
        '
        'tbpThemes
        '
        Me.tbpThemes.Controls.Add(Me.ucrInputSelectThemes)
        Me.tbpThemes.Controls.Add(Me.cmdManualTheme)
        Me.tbpThemes.Controls.Add(Me.rdoSelectTheme)
        Me.tbpThemes.Controls.Add(Me.rdoManualTheme)
        Me.tbpThemes.Controls.Add(Me.ucrPnlThemesPanel)
        Me.tbpThemes.Location = New System.Drawing.Point(4, 29)
        Me.tbpThemes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpThemes.Name = "tbpThemes"
        Me.tbpThemes.Size = New System.Drawing.Size(874, 624)
        Me.tbpThemes.TabIndex = 6
        Me.tbpThemes.Text = "Themes"
        Me.tbpThemes.UseVisualStyleBackColor = True
        '
        'cmdManualTheme
        '
        Me.cmdManualTheme.Location = New System.Drawing.Point(236, 85)
        Me.cmdManualTheme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdManualTheme.Name = "cmdManualTheme"
        Me.cmdManualTheme.Size = New System.Drawing.Size(252, 32)
        Me.cmdManualTheme.TabIndex = 2
        Me.cmdManualTheme.Text = "Themes Sub Dialog"
        Me.cmdManualTheme.UseVisualStyleBackColor = True
        '
        'rdoSelectTheme
        '
        Me.rdoSelectTheme.AutoSize = True
        Me.rdoSelectTheme.Checked = True
        Me.rdoSelectTheme.Location = New System.Drawing.Point(33, 46)
        Me.rdoSelectTheme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoSelectTheme.Name = "rdoSelectTheme"
        Me.rdoSelectTheme.Size = New System.Drawing.Size(132, 24)
        Me.rdoSelectTheme.TabIndex = 0
        Me.rdoSelectTheme.TabStop = True
        Me.rdoSelectTheme.Text = "Select Theme"
        Me.rdoSelectTheme.UseVisualStyleBackColor = True
        '
        'rdoManualTheme
        '
        Me.rdoManualTheme.AutoSize = True
        Me.rdoManualTheme.Location = New System.Drawing.Point(33, 88)
        Me.rdoManualTheme.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdoManualTheme.Name = "rdoManualTheme"
        Me.rdoManualTheme.Size = New System.Drawing.Size(139, 24)
        Me.rdoManualTheme.TabIndex = 1
        Me.rdoManualTheme.Text = "Manual Theme"
        Me.rdoManualTheme.UseVisualStyleBackColor = True
        '
        'ucrBaseSubdialog
        '
        Me.ucrBaseSubdialog.AutoSize = True
        Me.ucrBaseSubdialog.Location = New System.Drawing.Point(285, 682)
        Me.ucrBaseSubdialog.Margin = New System.Windows.Forms.Padding(6)
        Me.ucrBaseSubdialog.Name = "ucrBaseSubdialog"
        Me.ucrBaseSubdialog.Size = New System.Drawing.Size(336, 44)
        Me.ucrBaseSubdialog.TabIndex = 3
        '
        'ucrInputSecondFootnoteColumnLocation
        '
        Me.ucrInputSecondFootnoteColumnLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputSecondFootnoteColumnLocation.AutoSize = True
        Me.ucrInputSecondFootnoteColumnLocation.IsMultiline = False
        Me.ucrInputSecondFootnoteColumnLocation.IsReadOnly = False
        Me.ucrInputSecondFootnoteColumnLocation.Location = New System.Drawing.Point(104, 33)
        Me.ucrInputSecondFootnoteColumnLocation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSecondFootnoteColumnLocation.Name = "ucrInputSecondFootnoteColumnLocation"
        Me.ucrInputSecondFootnoteColumnLocation.Size = New System.Drawing.Size(201, 32)
        Me.ucrInputSecondFootnoteColumnLocation.TabIndex = 6
        '
        'ucrInputSecondFootnoteRowLocation
        '
        Me.ucrInputSecondFootnoteRowLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputSecondFootnoteRowLocation.AutoSize = True
        Me.ucrInputSecondFootnoteRowLocation.IsMultiline = False
        Me.ucrInputSecondFootnoteRowLocation.IsReadOnly = False
        Me.ucrInputSecondFootnoteRowLocation.Location = New System.Drawing.Point(104, 75)
        Me.ucrInputSecondFootnoteRowLocation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSecondFootnoteRowLocation.Name = "ucrInputSecondFootnoteRowLocation"
        Me.ucrInputSecondFootnoteRowLocation.Size = New System.Drawing.Size(201, 32)
        Me.ucrInputSecondFootnoteRowLocation.TabIndex = 5
        '
        'ucrInputSecondCellFootnote
        '
        Me.ucrInputSecondCellFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputSecondCellFootnote.AutoSize = True
        Me.ucrInputSecondCellFootnote.IsMultiline = False
        Me.ucrInputSecondCellFootnote.IsReadOnly = False
        Me.ucrInputSecondCellFootnote.Location = New System.Drawing.Point(285, 416)
        Me.ucrInputSecondCellFootnote.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSecondCellFootnote.Name = "ucrInputSecondCellFootnote"
        Me.ucrInputSecondCellFootnote.Size = New System.Drawing.Size(198, 32)
        Me.ucrInputSecondCellFootnote.TabIndex = 12
        '
        'ucrChKAddSecondFootnote
        '
        Me.ucrChKAddSecondFootnote.AutoSize = True
        Me.ucrChKAddSecondFootnote.Checked = False
        Me.ucrChKAddSecondFootnote.Location = New System.Drawing.Point(14, 416)
        Me.ucrChKAddSecondFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChKAddSecondFootnote.Name = "ucrChKAddSecondFootnote"
        Me.ucrChKAddSecondFootnote.Size = New System.Drawing.Size(200, 51)
        Me.ucrChKAddSecondFootnote.TabIndex = 10
        '
        'ucrInputCellFootnote
        '
        Me.ucrInputCellFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputCellFootnote.AutoSize = True
        Me.ucrInputCellFootnote.IsMultiline = False
        Me.ucrInputCellFootnote.IsReadOnly = False
        Me.ucrInputCellFootnote.Location = New System.Drawing.Point(282, 261)
        Me.ucrInputCellFootnote.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputCellFootnote.Name = "ucrInputCellFootnote"
        Me.ucrInputCellFootnote.Size = New System.Drawing.Size(201, 32)
        Me.ucrInputCellFootnote.TabIndex = 8
        '
        'ucrInputAddSourceNote
        '
        Me.ucrInputAddSourceNote.AddQuotesIfUnrecognised = True
        Me.ucrInputAddSourceNote.AutoSize = True
        Me.ucrInputAddSourceNote.IsMultiline = False
        Me.ucrInputAddSourceNote.IsReadOnly = False
        Me.ucrInputAddSourceNote.Location = New System.Drawing.Point(222, 567)
        Me.ucrInputAddSourceNote.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputAddSourceNote.Name = "ucrInputAddSourceNote"
        Me.ucrInputAddSourceNote.Size = New System.Drawing.Size(156, 32)
        Me.ucrInputAddSourceNote.TabIndex = 7
        '
        'ucrChkAddSourcenote
        '
        Me.ucrChkAddSourcenote.AutoSize = True
        Me.ucrChkAddSourcenote.Checked = False
        Me.ucrChkAddSourcenote.Location = New System.Drawing.Point(14, 567)
        Me.ucrChkAddSourcenote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAddSourcenote.Name = "ucrChkAddSourcenote"
        Me.ucrChkAddSourcenote.Size = New System.Drawing.Size(200, 51)
        Me.ucrChkAddSourcenote.TabIndex = 6
        '
        'ucrInputFootnoteColumnLocation
        '
        Me.ucrInputFootnoteColumnLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputFootnoteColumnLocation.AutoSize = True
        Me.ucrInputFootnoteColumnLocation.IsMultiline = False
        Me.ucrInputFootnoteColumnLocation.IsReadOnly = False
        Me.ucrInputFootnoteColumnLocation.Location = New System.Drawing.Point(104, 24)
        Me.ucrInputFootnoteColumnLocation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputFootnoteColumnLocation.Name = "ucrInputFootnoteColumnLocation"
        Me.ucrInputFootnoteColumnLocation.Size = New System.Drawing.Size(201, 32)
        Me.ucrInputFootnoteColumnLocation.TabIndex = 6
        '
        'ucrInputFootnoteRowLocation
        '
        Me.ucrInputFootnoteRowLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputFootnoteRowLocation.AutoSize = True
        Me.ucrInputFootnoteRowLocation.IsMultiline = False
        Me.ucrInputFootnoteRowLocation.IsReadOnly = False
        Me.ucrInputFootnoteRowLocation.Location = New System.Drawing.Point(104, 66)
        Me.ucrInputFootnoteRowLocation.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputFootnoteRowLocation.Name = "ucrInputFootnoteRowLocation"
        Me.ucrInputFootnoteRowLocation.Size = New System.Drawing.Size(201, 32)
        Me.ucrInputFootnoteRowLocation.TabIndex = 5
        '
        'ucrChkAddFootnote
        '
        Me.ucrChkAddFootnote.AutoSize = True
        Me.ucrChkAddFootnote.Checked = False
        Me.ucrChkAddFootnote.Location = New System.Drawing.Point(9, 258)
        Me.ucrChkAddFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAddFootnote.Name = "ucrChkAddFootnote"
        Me.ucrChkAddFootnote.Size = New System.Drawing.Size(200, 51)
        Me.ucrChkAddFootnote.TabIndex = 2
        '
        'ucrChkAddTitleSubtitle
        '
        Me.ucrChkAddTitleSubtitle.AutoSize = True
        Me.ucrChkAddTitleSubtitle.Checked = False
        Me.ucrChkAddTitleSubtitle.Location = New System.Drawing.Point(14, 27)
        Me.ucrChkAddTitleSubtitle.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkAddTitleSubtitle.Name = "ucrChkAddTitleSubtitle"
        Me.ucrChkAddTitleSubtitle.Size = New System.Drawing.Size(234, 51)
        Me.ucrChkAddTitleSubtitle.TabIndex = 1
        '
        'ucrInputTitleFont
        '
        Me.ucrInputTitleFont.AddQuotesIfUnrecognised = True
        Me.ucrInputTitleFont.AutoSize = True
        Me.ucrInputTitleFont.IsMultiline = False
        Me.ucrInputTitleFont.IsReadOnly = False
        Me.ucrInputTitleFont.Location = New System.Drawing.Point(104, 123)
        Me.ucrInputTitleFont.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTitleFont.Name = "ucrInputTitleFont"
        Me.ucrInputTitleFont.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputTitleFont.TabIndex = 16
        '
        'ucrNudTitleSize
        '
        Me.ucrNudTitleSize.AutoSize = True
        Me.ucrNudTitleSize.DecimalPlaces = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Increment = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ucrNudTitleSize.Location = New System.Drawing.Point(513, 123)
        Me.ucrNudTitleSize.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrNudTitleSize.Maximum = New Decimal(New Integer() {100, 0, 0, 0})
        Me.ucrNudTitleSize.Minimum = New Decimal(New Integer() {0, 0, 0, 0})
        Me.ucrNudTitleSize.Name = "ucrNudTitleSize"
        Me.ucrNudTitleSize.Size = New System.Drawing.Size(75, 30)
        Me.ucrNudTitleSize.TabIndex = 15
        Me.ucrNudTitleSize.Value = New Decimal(New Integer() {0, 0, 0, 0})
        '
        'ucrInputSubtitleFootnote
        '
        Me.ucrInputSubtitleFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitleFootnote.AutoSize = True
        Me.ucrInputSubtitleFootnote.IsMultiline = False
        Me.ucrInputSubtitleFootnote.IsReadOnly = False
        Me.ucrInputSubtitleFootnote.Location = New System.Drawing.Point(513, 82)
        Me.ucrInputSubtitleFootnote.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSubtitleFootnote.Name = "ucrInputSubtitleFootnote"
        Me.ucrInputSubtitleFootnote.Size = New System.Drawing.Size(178, 32)
        Me.ucrInputSubtitleFootnote.TabIndex = 7
        '
        'ucrInputTitleFootnote
        '
        Me.ucrInputTitleFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputTitleFootnote.AutoSize = True
        Me.ucrInputTitleFootnote.IsMultiline = False
        Me.ucrInputTitleFootnote.IsReadOnly = False
        Me.ucrInputTitleFootnote.Location = New System.Drawing.Point(513, 38)
        Me.ucrInputTitleFootnote.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTitleFootnote.Name = "ucrInputTitleFootnote"
        Me.ucrInputTitleFootnote.Size = New System.Drawing.Size(178, 32)
        Me.ucrInputTitleFootnote.TabIndex = 6
        '
        'ucrChkSubtitleFootnote
        '
        Me.ucrChkSubtitleFootnote.AutoSize = True
        Me.ucrChkSubtitleFootnote.Checked = False
        Me.ucrChkSubtitleFootnote.Location = New System.Drawing.Point(318, 84)
        Me.ucrChkSubtitleFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkSubtitleFootnote.Name = "ucrChkSubtitleFootnote"
        Me.ucrChkSubtitleFootnote.Size = New System.Drawing.Size(186, 51)
        Me.ucrChkSubtitleFootnote.TabIndex = 5
        '
        'ucrChkTitleFootnote
        '
        Me.ucrChkTitleFootnote.AutoSize = True
        Me.ucrChkTitleFootnote.Checked = False
        Me.ucrChkTitleFootnote.Location = New System.Drawing.Point(318, 39)
        Me.ucrChkTitleFootnote.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrChkTitleFootnote.Name = "ucrChkTitleFootnote"
        Me.ucrChkTitleFootnote.Size = New System.Drawing.Size(186, 51)
        Me.ucrChkTitleFootnote.TabIndex = 4
        '
        'ucrInputSubtitle
        '
        Me.ucrInputSubtitle.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitle.AutoSize = True
        Me.ucrInputSubtitle.IsMultiline = False
        Me.ucrInputSubtitle.IsReadOnly = False
        Me.ucrInputSubtitle.Location = New System.Drawing.Point(104, 82)
        Me.ucrInputSubtitle.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSubtitle.Name = "ucrInputSubtitle"
        Me.ucrInputSubtitle.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputSubtitle.TabIndex = 3
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.AutoSize = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        Me.ucrInputTitle.Location = New System.Drawing.Point(104, 38)
        Me.ucrInputTitle.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputTitle.Name = "ucrInputTitle"
        Me.ucrInputTitle.Size = New System.Drawing.Size(206, 32)
        Me.ucrInputTitle.TabIndex = 2
        '
        'ucrInputSelectThemes
        '
        Me.ucrInputSelectThemes.AddQuotesIfUnrecognised = True
        Me.ucrInputSelectThemes.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrInputSelectThemes.GetSetSelectedIndex = -1
        Me.ucrInputSelectThemes.IsReadOnly = False
        Me.ucrInputSelectThemes.Location = New System.Drawing.Point(236, 48)
        Me.ucrInputSelectThemes.Margin = New System.Windows.Forms.Padding(14)
        Me.ucrInputSelectThemes.Name = "ucrInputSelectThemes"
        Me.ucrInputSelectThemes.Size = New System.Drawing.Size(252, 30)
        Me.ucrInputSelectThemes.TabIndex = 3
        '
        'ucrPnlThemesPanel
        '
        Me.ucrPnlThemesPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ucrPnlThemesPanel.Location = New System.Drawing.Point(18, 24)
        Me.ucrPnlThemesPanel.Margin = New System.Windows.Forms.Padding(9)
        Me.ucrPnlThemesPanel.Name = "ucrPnlThemesPanel"
        Me.ucrPnlThemesPanel.Size = New System.Drawing.Size(524, 105)
        Me.ucrPnlThemesPanel.TabIndex = 4
        '
        'sdgFormatSummaryTables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(924, 735)
        Me.Controls.Add(Me.ucrBaseSubdialog)
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFormatSummaryTables"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Format Summary Table"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpTitle.ResumeLayout(False)
        Me.tbpTitle.PerformLayout()
        Me.grpSecondFootnote.ResumeLayout(False)
        Me.grpSecondFootnote.PerformLayout()
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.grpTitleSubtitle.ResumeLayout(False)
        Me.grpTitleSubtitle.PerformLayout()
        Me.tbpThemes.ResumeLayout(False)
        Me.tbpThemes.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbpFormatOptions As TabControl
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
    Friend WithEvents grpTitleSubtitle As GroupBox
    Friend WithEvents ucrInputTitleFont As ucrInputTextBox
    Friend WithEvents ucrNudTitleSize As ucrNud
    Friend WithEvents lblTitleSize As Label
    Friend WithEvents lblTitleFont As Label
    Friend WithEvents ucrInputSubtitleFootnote As ucrInputTextBox
    Friend WithEvents ucrInputTitleFootnote As ucrInputTextBox
    Friend WithEvents ucrChkSubtitleFootnote As ucrCheck
    Friend WithEvents ucrChkTitleFootnote As ucrCheck
    Friend WithEvents ucrInputSubtitle As ucrInputTextBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents ucrBaseSubdialog As ucrButtonsSubdialogue
    Friend WithEvents tbpFacets As TabPage
    Friend WithEvents tbpRows As TabPage
    Friend WithEvents tbpColumns As TabPage
    Friend WithEvents tbpThemes As TabPage
    Friend WithEvents rdoSelectTheme As RadioButton
    Friend WithEvents cmdManualTheme As Button
    Friend WithEvents rdoManualTheme As RadioButton
    Friend WithEvents ucrInputSelectThemes As ucrInputComboBox
    Friend WithEvents ucrPnlThemesPanel As UcrPanel
End Class
