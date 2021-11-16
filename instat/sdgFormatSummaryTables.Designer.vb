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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(sdgFormatSummaryTables))
        Me.tbpFormatOptions = New System.Windows.Forms.TabControl()
        Me.tbpTitle = New System.Windows.Forms.TabPage()
        Me.ucrInputAddSourceNote = New instat.ucrInputTextBox()
        Me.ucrChkAddSourcenote = New instat.ucrCheck()
        Me.grpLocation = New System.Windows.Forms.GroupBox()
        Me.ucrInputFootnoteColumnLocation = New instat.ucrInputTextBox()
        Me.ucrInputFootnoteRowLocation = New instat.ucrInputTextBox()
        Me.lblColumns = New System.Windows.Forms.Label()
        Me.lblRows = New System.Windows.Forms.Label()
        Me.ucrChkAddFootnote = New instat.ucrCheck()
        Me.ucrChkAddTitleSubtitle = New instat.ucrCheck()
        Me.grpTitleSubtitle = New System.Windows.Forms.GroupBox()
        Me.ucrInputSubtitleFootnote = New instat.ucrInputTextBox()
        Me.ucrInputTitleFootnote = New instat.ucrInputTextBox()
        Me.ucrChkSubtitleFootnote = New instat.ucrCheck()
        Me.ucrChkTitleFootnote = New instat.ucrCheck()
        Me.ucrInputSubtitle = New instat.ucrInputTextBox()
        Me.ucrInputTitle = New instat.ucrInputTextBox()
        Me.lblSubtitle = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.tbpHeader = New System.Windows.Forms.TabPage()
        Me.grpStyle = New System.Windows.Forms.GroupBox()
        Me.ucrInputStyleTextFont = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextSize = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextAlign = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextValign = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextWeight = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextWhitespace = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextIndent = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextStretch = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextDecorate = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextTransform = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextStyle = New instat.ucrInputComboBox()
        Me.ucrInputStyleTextFill = New instat.ucrInputComboBox()
        Me.lblIndent = New System.Windows.Forms.Label()
        Me.lblWhitespace = New System.Windows.Forms.Label()
        Me.lblTransform = New System.Windows.Forms.Label()
        Me.lblWeight = New System.Windows.Forms.Label()
        Me.lblStretch = New System.Windows.Forms.Label()
        Me.lblDecorate = New System.Windows.Forms.Label()
        Me.lblSize = New System.Windows.Forms.Label()
        Me.lblFont = New System.Windows.Forms.Label()
        Me.lblStyle = New System.Windows.Forms.Label()
        Me.lblAlign = New System.Windows.Forms.Label()
        Me.lblVAlign = New System.Windows.Forms.Label()
        Me.lblFill = New System.Windows.Forms.Label()
        Me.ucrChkStyleBoarder = New instat.ucrCheck()
        Me.ucrChkStyleText = New instat.ucrCheck()
        Me.ucrChkStyleFill = New instat.ucrCheck()
        Me.rdoAllColumns = New System.Windows.Forms.RadioButton()
        Me.rdoAllRows = New System.Windows.Forms.RadioButton()
        Me.ucrPnlHeader = New instat.UcrPanel()
        Me.lblHeader = New System.Windows.Forms.Label()
        Me.tbpTable = New System.Windows.Forms.TabPage()
        Me.ucrInputSides = New instat.ucrInputComboBox()
        Me.UcrInputComboBox14 = New instat.ucrInputComboBox()
        Me.lblColour = New System.Windows.Forms.Label()
        Me.lblSides = New System.Windows.Forms.Label()
        Me.tbpFormatOptions.SuspendLayout()
        Me.tbpTitle.SuspendLayout()
        Me.grpLocation.SuspendLayout()
        Me.grpTitleSubtitle.SuspendLayout()
        Me.tbpHeader.SuspendLayout()
        Me.grpStyle.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbpFormatOptions
        '
        Me.tbpFormatOptions.Controls.Add(Me.tbpTitle)
        Me.tbpFormatOptions.Controls.Add(Me.tbpHeader)
        Me.tbpFormatOptions.Controls.Add(Me.tbpTable)
        resources.ApplyResources(Me.tbpFormatOptions, "tbpFormatOptions")
        Me.tbpFormatOptions.Name = "tbpFormatOptions"
        Me.tbpFormatOptions.SelectedIndex = 0
        '
        'tbpTitle
        '
        Me.tbpTitle.Controls.Add(Me.ucrInputAddSourceNote)
        Me.tbpTitle.Controls.Add(Me.ucrChkAddSourcenote)
        Me.tbpTitle.Controls.Add(Me.grpLocation)
        Me.tbpTitle.Controls.Add(Me.ucrChkAddFootnote)
        Me.tbpTitle.Controls.Add(Me.ucrChkAddTitleSubtitle)
        Me.tbpTitle.Controls.Add(Me.grpTitleSubtitle)
        resources.ApplyResources(Me.tbpTitle, "tbpTitle")
        Me.tbpTitle.Name = "tbpTitle"
        Me.tbpTitle.UseVisualStyleBackColor = True
        '
        'ucrInputAddSourceNote
        '
        Me.ucrInputAddSourceNote.AddQuotesIfUnrecognised = True
        Me.ucrInputAddSourceNote.IsMultiline = False
        Me.ucrInputAddSourceNote.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputAddSourceNote, "ucrInputAddSourceNote")
        Me.ucrInputAddSourceNote.Name = "ucrInputAddSourceNote"
        '
        'ucrChkAddSourcenote
        '
        Me.ucrChkAddSourcenote.Checked = False
        resources.ApplyResources(Me.ucrChkAddSourcenote, "ucrChkAddSourcenote")
        Me.ucrChkAddSourcenote.Name = "ucrChkAddSourcenote"
        '
        'grpLocation
        '
        Me.grpLocation.Controls.Add(Me.ucrInputFootnoteColumnLocation)
        Me.grpLocation.Controls.Add(Me.ucrInputFootnoteRowLocation)
        Me.grpLocation.Controls.Add(Me.lblColumns)
        Me.grpLocation.Controls.Add(Me.lblRows)
        resources.ApplyResources(Me.grpLocation, "grpLocation")
        Me.grpLocation.Name = "grpLocation"
        Me.grpLocation.TabStop = False
        '
        'ucrInputFootnoteColumnLocation
        '
        Me.ucrInputFootnoteColumnLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputFootnoteColumnLocation.IsMultiline = False
        Me.ucrInputFootnoteColumnLocation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFootnoteColumnLocation, "ucrInputFootnoteColumnLocation")
        Me.ucrInputFootnoteColumnLocation.Name = "ucrInputFootnoteColumnLocation"
        '
        'ucrInputFootnoteRowLocation
        '
        Me.ucrInputFootnoteRowLocation.AddQuotesIfUnrecognised = True
        Me.ucrInputFootnoteRowLocation.IsMultiline = False
        Me.ucrInputFootnoteRowLocation.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputFootnoteRowLocation, "ucrInputFootnoteRowLocation")
        Me.ucrInputFootnoteRowLocation.Name = "ucrInputFootnoteRowLocation"
        '
        'lblColumns
        '
        resources.ApplyResources(Me.lblColumns, "lblColumns")
        Me.lblColumns.Name = "lblColumns"
        '
        'lblRows
        '
        resources.ApplyResources(Me.lblRows, "lblRows")
        Me.lblRows.Name = "lblRows"
        '
        'ucrChkAddFootnote
        '
        Me.ucrChkAddFootnote.Checked = False
        resources.ApplyResources(Me.ucrChkAddFootnote, "ucrChkAddFootnote")
        Me.ucrChkAddFootnote.Name = "ucrChkAddFootnote"
        '
        'ucrChkAddTitleSubtitle
        '
        Me.ucrChkAddTitleSubtitle.Checked = False
        resources.ApplyResources(Me.ucrChkAddTitleSubtitle, "ucrChkAddTitleSubtitle")
        Me.ucrChkAddTitleSubtitle.Name = "ucrChkAddTitleSubtitle"
        '
        'grpTitleSubtitle
        '
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputSubtitleFootnote)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputTitleFootnote)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrChkSubtitleFootnote)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrChkTitleFootnote)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputSubtitle)
        Me.grpTitleSubtitle.Controls.Add(Me.ucrInputTitle)
        Me.grpTitleSubtitle.Controls.Add(Me.lblSubtitle)
        Me.grpTitleSubtitle.Controls.Add(Me.lblTitle)
        resources.ApplyResources(Me.grpTitleSubtitle, "grpTitleSubtitle")
        Me.grpTitleSubtitle.Name = "grpTitleSubtitle"
        Me.grpTitleSubtitle.TabStop = False
        '
        'ucrInputSubtitleFootnote
        '
        Me.ucrInputSubtitleFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitleFootnote.IsMultiline = False
        Me.ucrInputSubtitleFootnote.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSubtitleFootnote, "ucrInputSubtitleFootnote")
        Me.ucrInputSubtitleFootnote.Name = "ucrInputSubtitleFootnote"
        '
        'ucrInputTitleFootnote
        '
        Me.ucrInputTitleFootnote.AddQuotesIfUnrecognised = True
        Me.ucrInputTitleFootnote.IsMultiline = False
        Me.ucrInputTitleFootnote.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTitleFootnote, "ucrInputTitleFootnote")
        Me.ucrInputTitleFootnote.Name = "ucrInputTitleFootnote"
        '
        'ucrChkSubtitleFootnote
        '
        Me.ucrChkSubtitleFootnote.Checked = False
        resources.ApplyResources(Me.ucrChkSubtitleFootnote, "ucrChkSubtitleFootnote")
        Me.ucrChkSubtitleFootnote.Name = "ucrChkSubtitleFootnote"
        '
        'ucrChkTitleFootnote
        '
        Me.ucrChkTitleFootnote.Checked = False
        resources.ApplyResources(Me.ucrChkTitleFootnote, "ucrChkTitleFootnote")
        Me.ucrChkTitleFootnote.Name = "ucrChkTitleFootnote"
        '
        'ucrInputSubtitle
        '
        Me.ucrInputSubtitle.AddQuotesIfUnrecognised = True
        Me.ucrInputSubtitle.IsMultiline = False
        Me.ucrInputSubtitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSubtitle, "ucrInputSubtitle")
        Me.ucrInputSubtitle.Name = "ucrInputSubtitle"
        '
        'ucrInputTitle
        '
        Me.ucrInputTitle.AddQuotesIfUnrecognised = True
        Me.ucrInputTitle.IsMultiline = False
        Me.ucrInputTitle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputTitle, "ucrInputTitle")
        Me.ucrInputTitle.Name = "ucrInputTitle"
        '
        'lblSubtitle
        '
        resources.ApplyResources(Me.lblSubtitle, "lblSubtitle")
        Me.lblSubtitle.Name = "lblSubtitle"
        '
        'lblTitle
        '
        resources.ApplyResources(Me.lblTitle, "lblTitle")
        Me.lblTitle.Name = "lblTitle"
        '
        'tbpHeader
        '
        Me.tbpHeader.Controls.Add(Me.grpStyle)
        Me.tbpHeader.Controls.Add(Me.rdoAllColumns)
        Me.tbpHeader.Controls.Add(Me.rdoAllRows)
        Me.tbpHeader.Controls.Add(Me.ucrPnlHeader)
        Me.tbpHeader.Controls.Add(Me.lblHeader)
        resources.ApplyResources(Me.tbpHeader, "tbpHeader")
        Me.tbpHeader.Name = "tbpHeader"
        Me.tbpHeader.UseVisualStyleBackColor = True
        '
        'grpStyle
        '
        Me.grpStyle.Controls.Add(Me.ucrInputSides)
        Me.grpStyle.Controls.Add(Me.UcrInputComboBox14)
        Me.grpStyle.Controls.Add(Me.lblColour)
        Me.grpStyle.Controls.Add(Me.lblSides)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextFont)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextSize)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextAlign)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextValign)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextWeight)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextWhitespace)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextIndent)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextStretch)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextDecorate)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextTransform)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextStyle)
        Me.grpStyle.Controls.Add(Me.ucrInputStyleTextFill)
        Me.grpStyle.Controls.Add(Me.lblIndent)
        Me.grpStyle.Controls.Add(Me.lblWhitespace)
        Me.grpStyle.Controls.Add(Me.lblTransform)
        Me.grpStyle.Controls.Add(Me.lblWeight)
        Me.grpStyle.Controls.Add(Me.lblStretch)
        Me.grpStyle.Controls.Add(Me.lblDecorate)
        Me.grpStyle.Controls.Add(Me.lblSize)
        Me.grpStyle.Controls.Add(Me.lblFont)
        Me.grpStyle.Controls.Add(Me.lblStyle)
        Me.grpStyle.Controls.Add(Me.lblAlign)
        Me.grpStyle.Controls.Add(Me.lblVAlign)
        Me.grpStyle.Controls.Add(Me.lblFill)
        Me.grpStyle.Controls.Add(Me.ucrChkStyleBoarder)
        Me.grpStyle.Controls.Add(Me.ucrChkStyleText)
        Me.grpStyle.Controls.Add(Me.ucrChkStyleFill)
        resources.ApplyResources(Me.grpStyle, "grpStyle")
        Me.grpStyle.Name = "grpStyle"
        Me.grpStyle.TabStop = False
        '
        'ucrInputStyleTextFont
        '
        Me.ucrInputStyleTextFont.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextFont.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextFont.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextFont, "ucrInputStyleTextFont")
        Me.ucrInputStyleTextFont.Name = "ucrInputStyleTextFont"
        '
        'ucrInputStyleTextSize
        '
        Me.ucrInputStyleTextSize.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextSize.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextSize.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextSize, "ucrInputStyleTextSize")
        Me.ucrInputStyleTextSize.Name = "ucrInputStyleTextSize"
        '
        'ucrInputStyleTextAlign
        '
        Me.ucrInputStyleTextAlign.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextAlign.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextAlign.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextAlign, "ucrInputStyleTextAlign")
        Me.ucrInputStyleTextAlign.Name = "ucrInputStyleTextAlign"
        '
        'ucrInputStyleTextValign
        '
        Me.ucrInputStyleTextValign.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextValign.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextValign.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextValign, "ucrInputStyleTextValign")
        Me.ucrInputStyleTextValign.Name = "ucrInputStyleTextValign"
        '
        'ucrInputStyleTextWeight
        '
        Me.ucrInputStyleTextWeight.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextWeight.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextWeight.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextWeight, "ucrInputStyleTextWeight")
        Me.ucrInputStyleTextWeight.Name = "ucrInputStyleTextWeight"
        '
        'ucrInputStyleTextWhitespace
        '
        Me.ucrInputStyleTextWhitespace.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextWhitespace.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextWhitespace.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextWhitespace, "ucrInputStyleTextWhitespace")
        Me.ucrInputStyleTextWhitespace.Name = "ucrInputStyleTextWhitespace"
        '
        'ucrInputStyleTextIndent
        '
        Me.ucrInputStyleTextIndent.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextIndent.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextIndent.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextIndent, "ucrInputStyleTextIndent")
        Me.ucrInputStyleTextIndent.Name = "ucrInputStyleTextIndent"
        '
        'ucrInputStyleTextStretch
        '
        Me.ucrInputStyleTextStretch.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextStretch.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextStretch.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextStretch, "ucrInputStyleTextStretch")
        Me.ucrInputStyleTextStretch.Name = "ucrInputStyleTextStretch"
        '
        'ucrInputStyleTextDecorate
        '
        Me.ucrInputStyleTextDecorate.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextDecorate.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextDecorate.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextDecorate, "ucrInputStyleTextDecorate")
        Me.ucrInputStyleTextDecorate.Name = "ucrInputStyleTextDecorate"
        '
        'ucrInputStyleTextTransform
        '
        Me.ucrInputStyleTextTransform.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextTransform.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextTransform.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextTransform, "ucrInputStyleTextTransform")
        Me.ucrInputStyleTextTransform.Name = "ucrInputStyleTextTransform"
        '
        'ucrInputStyleTextStyle
        '
        Me.ucrInputStyleTextStyle.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextStyle.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextStyle.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextStyle, "ucrInputStyleTextStyle")
        Me.ucrInputStyleTextStyle.Name = "ucrInputStyleTextStyle"
        '
        'ucrInputStyleTextFill
        '
        Me.ucrInputStyleTextFill.AddQuotesIfUnrecognised = True
        Me.ucrInputStyleTextFill.GetSetSelectedIndex = -1
        Me.ucrInputStyleTextFill.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputStyleTextFill, "ucrInputStyleTextFill")
        Me.ucrInputStyleTextFill.Name = "ucrInputStyleTextFill"
        '
        'lblIndent
        '
        resources.ApplyResources(Me.lblIndent, "lblIndent")
        Me.lblIndent.Name = "lblIndent"
        '
        'lblWhitespace
        '
        resources.ApplyResources(Me.lblWhitespace, "lblWhitespace")
        Me.lblWhitespace.Name = "lblWhitespace"
        '
        'lblTransform
        '
        resources.ApplyResources(Me.lblTransform, "lblTransform")
        Me.lblTransform.Name = "lblTransform"
        '
        'lblWeight
        '
        resources.ApplyResources(Me.lblWeight, "lblWeight")
        Me.lblWeight.Name = "lblWeight"
        '
        'lblStretch
        '
        resources.ApplyResources(Me.lblStretch, "lblStretch")
        Me.lblStretch.Name = "lblStretch"
        '
        'lblDecorate
        '
        resources.ApplyResources(Me.lblDecorate, "lblDecorate")
        Me.lblDecorate.Name = "lblDecorate"
        '
        'lblSize
        '
        resources.ApplyResources(Me.lblSize, "lblSize")
        Me.lblSize.Name = "lblSize"
        '
        'lblFont
        '
        resources.ApplyResources(Me.lblFont, "lblFont")
        Me.lblFont.Name = "lblFont"
        '
        'lblStyle
        '
        resources.ApplyResources(Me.lblStyle, "lblStyle")
        Me.lblStyle.Name = "lblStyle"
        '
        'lblAlign
        '
        resources.ApplyResources(Me.lblAlign, "lblAlign")
        Me.lblAlign.Name = "lblAlign"
        '
        'lblVAlign
        '
        resources.ApplyResources(Me.lblVAlign, "lblVAlign")
        Me.lblVAlign.Name = "lblVAlign"
        '
        'lblFill
        '
        resources.ApplyResources(Me.lblFill, "lblFill")
        Me.lblFill.Name = "lblFill"
        '
        'ucrChkStyleBoarder
        '
        Me.ucrChkStyleBoarder.Checked = False
        resources.ApplyResources(Me.ucrChkStyleBoarder, "ucrChkStyleBoarder")
        Me.ucrChkStyleBoarder.Name = "ucrChkStyleBoarder"
        '
        'ucrChkStyleText
        '
        Me.ucrChkStyleText.Checked = False
        resources.ApplyResources(Me.ucrChkStyleText, "ucrChkStyleText")
        Me.ucrChkStyleText.Name = "ucrChkStyleText"
        '
        'ucrChkStyleFill
        '
        Me.ucrChkStyleFill.Checked = False
        resources.ApplyResources(Me.ucrChkStyleFill, "ucrChkStyleFill")
        Me.ucrChkStyleFill.Name = "ucrChkStyleFill"
        '
        'rdoAllColumns
        '
        resources.ApplyResources(Me.rdoAllColumns, "rdoAllColumns")
        Me.rdoAllColumns.Name = "rdoAllColumns"
        Me.rdoAllColumns.TabStop = True
        Me.rdoAllColumns.UseVisualStyleBackColor = True
        '
        'rdoAllRows
        '
        resources.ApplyResources(Me.rdoAllRows, "rdoAllRows")
        Me.rdoAllRows.Name = "rdoAllRows"
        Me.rdoAllRows.TabStop = True
        Me.rdoAllRows.UseVisualStyleBackColor = True
        '
        'ucrPnlHeader
        '
        resources.ApplyResources(Me.ucrPnlHeader, "ucrPnlHeader")
        Me.ucrPnlHeader.Name = "ucrPnlHeader"
        '
        'lblHeader
        '
        resources.ApplyResources(Me.lblHeader, "lblHeader")
        Me.lblHeader.Name = "lblHeader"
        '
        'tbpTable
        '
        resources.ApplyResources(Me.tbpTable, "tbpTable")
        Me.tbpTable.Name = "tbpTable"
        Me.tbpTable.UseVisualStyleBackColor = True
        '
        'ucrInputSides
        '
        Me.ucrInputSides.AddQuotesIfUnrecognised = True
        Me.ucrInputSides.GetSetSelectedIndex = -1
        Me.ucrInputSides.IsReadOnly = False
        resources.ApplyResources(Me.ucrInputSides, "ucrInputSides")
        Me.ucrInputSides.Name = "ucrInputSides"
        '
        'UcrInputComboBox14
        '
        Me.UcrInputComboBox14.AddQuotesIfUnrecognised = True
        Me.UcrInputComboBox14.GetSetSelectedIndex = -1
        Me.UcrInputComboBox14.IsReadOnly = False
        resources.ApplyResources(Me.UcrInputComboBox14, "UcrInputComboBox14")
        Me.UcrInputComboBox14.Name = "UcrInputComboBox14"
        '
        'lblColour
        '
        resources.ApplyResources(Me.lblColour, "lblColour")
        Me.lblColour.Name = "lblColour"
        '
        'lblSides
        '
        resources.ApplyResources(Me.lblSides, "lblSides")
        Me.lblSides.Name = "lblSides"
        '
        'sdgFormatSummaryTables
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tbpFormatOptions)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "sdgFormatSummaryTables"
        Me.tbpFormatOptions.ResumeLayout(False)
        Me.tbpTitle.ResumeLayout(False)
        Me.grpLocation.ResumeLayout(False)
        Me.grpLocation.PerformLayout()
        Me.grpTitleSubtitle.ResumeLayout(False)
        Me.grpTitleSubtitle.PerformLayout()
        Me.tbpHeader.ResumeLayout(False)
        Me.tbpHeader.PerformLayout()
        Me.grpStyle.ResumeLayout(False)
        Me.grpStyle.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbpFormatOptions As TabControl
    Friend WithEvents tbpTitle As TabPage
    Friend WithEvents tbpHeader As TabPage
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
    Friend WithEvents ucrInputSubtitleFootnote As ucrInputTextBox
    Friend WithEvents ucrInputTitleFootnote As ucrInputTextBox
    Friend WithEvents ucrChkSubtitleFootnote As ucrCheck
    Friend WithEvents ucrChkTitleFootnote As ucrCheck
    Friend WithEvents ucrInputSubtitle As ucrInputTextBox
    Friend WithEvents ucrInputTitle As ucrInputTextBox
    Friend WithEvents lblSubtitle As Label
    Friend WithEvents lblTitle As Label
    Friend WithEvents tbpTable As TabPage
    Friend WithEvents grpStyle As GroupBox
    Friend WithEvents ucrChkStyleBoarder As ucrCheck
    Friend WithEvents ucrChkStyleText As ucrCheck
    Friend WithEvents ucrChkStyleFill As ucrCheck
    Friend WithEvents rdoAllColumns As RadioButton
    Friend WithEvents rdoAllRows As RadioButton
    Friend WithEvents ucrPnlHeader As UcrPanel
    Friend WithEvents lblHeader As Label
    Friend WithEvents lblWeight As Label
    Friend WithEvents lblStretch As Label
    Friend WithEvents lblDecorate As Label
    Friend WithEvents lblSize As Label
    Friend WithEvents lblFont As Label
    Friend WithEvents lblStyle As Label
    Friend WithEvents lblAlign As Label
    Friend WithEvents lblVAlign As Label
    Friend WithEvents lblFill As Label
    Friend WithEvents lblIndent As Label
    Friend WithEvents lblWhitespace As Label
    Friend WithEvents lblTransform As Label
    Friend WithEvents ucrInputStyleTextFont As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextSize As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextAlign As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextValign As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextWeight As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextWhitespace As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextIndent As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextStretch As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextDecorate As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextTransform As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextStyle As ucrInputComboBox
    Friend WithEvents ucrInputStyleTextFill As ucrInputComboBox
    Friend WithEvents ucrInputSides As ucrInputComboBox
    Friend WithEvents UcrInputComboBox14 As ucrInputComboBox
    Friend WithEvents lblColour As Label
    Friend WithEvents lblSides As Label
End Class
