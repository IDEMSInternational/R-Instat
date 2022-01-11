Imports instat.Translations
Public Class sdgFormatSummaryTables
    Private clsTableTitleFunction, clsTabFootnoteTitleFunction, clsTableSourcenoteFunction, clsFootnoteCellFunction,
        clsCellTextFunction, clsCellBorderFunction, clsCellFillFunction, clsHeaderFormatFunction, clsFootnoteTitleLocationFunction,
        clsTabOptionsFunction, clsBorderWeightPxFunction, clsFootnoteSubtitleLocationFunction, clsTabFootnoteSubtitleFunction, clsFootnoteCellBodyFunction,
        clsStyleListFunction, clsStubHeadFunction, clsSecondFootnoteCellFunction, clsSecondFootnoteCellBodyFunction,
        clsTabStyleFunction, clsTabStyleCellTextFunction, clsTabStylePxFunction As New RFunction
    Private clsPipeOperator, clsMutableOperator, clsJoiningOperator, clsTabFootnoteOperator As New ROperator
    Private bControlsInitialised As Boolean = False
    Private Sub sdgFormatSummaryTables_load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()
        bControlsInitialised = False
        Dim dctTextSize, dctTextAlign, dctTextValign, dctTextStyle, dctTextWeight, dctTextDecorate, dctTextTransform,
        dctTextStretch, dctTextWhitespace, dctTableAlign As New Dictionary(Of String, String)

        'Titles
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)
        ucrInputSubtitle.SetLinkedDisplayControl(lblSubtitle)

        ucrChkTitleFootnote.SetText("Add title footnote")
        ucrChkTitleFootnote.AddToLinkedControls(ucrInputTitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTitleFootnote.SetLinkedDisplayControl(grpTitleSubtitle)

        ucrChkTitleFootnote.AddParameterPresentCondition(True, "titlefootnote")
        ucrChkTitleFootnote.AddParameterPresentCondition(False, "titlefootnote", False)

        ucrChkSubtitleFootnote.SetText("Add subtitle footnote")
        ucrChkSubtitleFootnote.AddToLinkedControls(ucrInputSubtitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSubtitleFootnote.AddParameterPresentCondition(True, "subtitlefootnote")
        ucrChkSubtitleFootnote.AddParameterPresentCondition(False, "subtitlefootnote", False)

        ucrInputTitleFont.SetParameter(New RParameter("font", iNewPosition:=0))
        ucrInputTitleFont.SetRDefault("NULL")
        ucrInputTitleFont.SetLinkedDisplayControl(lblTitleFont)

        ucrNudTitleSize.SetParameter(New RParameter("size", iNewPosition:=0, bNewIncludeArgumentName:=False))
        ucrNudTitleSize.Increment = 1
        ucrNudTitleSize.SetLinkedDisplayControl(lblTitleSize)

        ucrChkAddTitleSubtitle.SetText("Add title/subtitle")
        ucrChkAddTitleSubtitle.AddToLinkedControls({ucrInputTitle, ucrInputSubtitle, ucrChkTitleFootnote, ucrChkSubtitleFootnote, ucrInputTitleFont, ucrNudTitleSize}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddTitleSubtitle.AddParameterPresentCondition(True, "title\subtitle")
        ucrChkAddTitleSubtitle.AddParameterPresentCondition(False, "title\subtitle", False)

        ucrInputFootnoteColumnLocation.SetValidationTypeAsNumericList()

        ucrInputFootnoteRowLocation.SetValidationTypeAsNumericList()
        ucrInputFootnoteRowLocation.SetLinkedDisplayControl(grpLocation)

        ucrInputCellFootnote.SetLinkedDisplayControl(lblFootnote)

        ucrChkAddFootnote.SetText("Add footnote")
        ucrChkAddFootnote.AddToLinkedControls({ucrInputCellFootnote, ucrInputFootnoteColumnLocation, ucrInputFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddFootnote.AddParameterPresentCondition(True, "cellfootnote")
        ucrChkAddFootnote.AddParameterPresentCondition(False, "cellfootnote", False)

        ucrChKAddSecondFootnote.SetText("Add Second footnote")
        ucrChKAddSecondFootnote.AddToLinkedControls({ucrInputSecondCellFootnote, ucrInputSecondFootnoteColumnLocation, ucrInputSecondFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputSecondFootnoteRowLocation.SetValidationTypeAsNumericList()

        ucrInputSecondFootnoteColumnLocation.SetValidationTypeAsNumericList()

        ucrInputSecondCellFootnote.SetLinkedDisplayControl(lblSecondFootnote)

        ucrInputSecondFootnoteColumnLocation.SetLinkedDisplayControl(grpSecondFootnote)

        ucrChKAddSecondFootnote.AddParameterPresentCondition(True, "second_cellfootnote")
        ucrChKAddSecondFootnote.AddParameterPresentCondition(False, "second_cellfootnote", False)

        ucrChkAddSourcenote.SetText("Add Source")
        ucrChkAddSourcenote.AddToLinkedControls(ucrInputAddSourceNote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddSourcenote.AddParameterPresentCondition(True, "source_note")
        ucrChkAddSourcenote.AddParameterPresentCondition(False, "source_note", False)
        'Header
        ucrChkAddHeader.SetText("Add Header")
        ucrChkAddHeader.AddToLinkedControls({ucrChkStyleText, ucrPnlHeader}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)
        ucrChkAddHeader.AddParameterPresentCondition(True, "header")
        ucrChkAddHeader.AddParameterPresentCondition(False, "header", False)

        ucrChkAddTableFormat.SetText("Add Table format")
        ucrChkAddTableFormat.AddToLinkedControls({ucrInputTableLayout, ucrInputTableAlign, ucrInputTableBackgroundColor, ucrInputTableFontWeight, ucrInputTableFontColor,
                                                  ucrNudTableWidth, ucrNudTableFontSize}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddTableFormat.AddParameterPresentCondition(True, "table_format")
        ucrChkAddTableFormat.AddParameterPresentCondition(False, "table_format", False)

        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)
        ucrPnlHeader.SetParameter(New RParameter("header", iNewPosition:=0))
        ucrPnlHeader.AddRadioButton(rdoAllColumns, Chr(34) & "all_cols" & Chr(34))
        ucrPnlHeader.AddRadioButton(rdoAllRows, Chr(34) & "all_rows" & Chr(34))
        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)

        ucrChkStyleText.SetText("Add Text style")
        ucrChkStyleText.AddToLinkedControls({ucrInputStyleTextColor, ucrInputStyleTextFont, ucrInputStyleTextSize, ucrInputStyleTextAlign,
                                             ucrInputStyleTextValign, ucrInputStyleTextStyle, ucrInputStyleTextWeight, ucrInputStyleTextStretch,
                                             ucrInputStyleTextDecorate, ucrInputStyleTextTransform, ucrInputStyleTextWhitespace, ucrNudStyleTextIndent},
                                          {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkStyleText.SetLinkedDisplayControl(grpStyle)
        ucrChkStyleText.AddParameterPresentCondition(True, "textStyle")
        ucrChkStyleText.AddParameterPresentCondition(False, "textStyle", False)

        ucrInputStyleTextColor.SetParameter(New RParameter("color", iNewPosition:=0))
        ucrInputStyleTextColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrInputStyleTextColor.SetLinkedDisplayControl(lblStyleTextColor)

        ucrInputStyleTextFont.SetParameter(New RParameter("font", iNewPosition:=1))
        ucrInputStyleTextFont.SetLinkedDisplayControl(lblStyleTextFont)
        ucrInputStyleTextFont.AddQuotesIfUnrecognised = False
        ucrInputStyleTextFont.SetRDefault("NULL")

        ucrInputStyleTextSize.SetParameter(New RParameter("size", iNewPosition:=2))
        dctTextSize.Add("NULL", "NULL")
        dctTextSize.Add("xx-small", Chr(34) & "xx-small" & Chr(34))
        dctTextSize.Add("x-small", Chr(34) & "x-small" & Chr(34))
        dctTextSize.Add("small", Chr(34) & "small" & Chr(34))
        dctTextSize.Add("medium", Chr(34) & "medium" & Chr(34))
        dctTextSize.Add("large", Chr(34) & "large" & Chr(34))
        dctTextSize.Add("x-large", Chr(34) & "x-large" & Chr(34))
        dctTextSize.Add("xx-large", Chr(34) & "xx-large" & Chr(34))
        ucrInputStyleTextSize.SetItems(dctTextSize)
        ucrInputStyleTextSize.SetRDefault("NULL")
        ucrInputStyleTextSize.SetLinkedDisplayControl(lblStyleTextSize)

        ucrInputStyleTextAlign.SetParameter(New RParameter("align", iNewPosition:=3))
        dctTextAlign.Add("NULL", "NULL")
        dctTextAlign.Add("center", Chr(34) & "center" & Chr(34))
        dctTextAlign.Add("left", Chr(34) & "left" & Chr(34))
        dctTextAlign.Add("right", Chr(34) & "right" & Chr(34))
        dctTextAlign.Add("justify", Chr(34) & "justify" & Chr(34))
        ucrInputStyleTextAlign.SetItems(dctTextAlign)
        ucrInputStyleTextAlign.SetRDefault("NULL")
        ucrInputStyleTextAlign.SetLinkedDisplayControl(lblStyleTextAlign)

        ucrInputStyleTextValign.SetParameter(New RParameter("v_align", iNewPosition:=4))
        dctTextValign.Add("NULL", "NULL")
        dctTextValign.Add("middle", Chr(34) & "middle" & Chr(34))
        dctTextValign.Add("top", Chr(34) & "top" & Chr(34))
        dctTextValign.Add("bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputStyleTextValign.SetItems(dctTextValign)
        ucrInputStyleTextValign.SetRDefault("NULL")
        ucrInputStyleTextValign.SetLinkedDisplayControl(lblStyleTextVAlign)

        ucrInputStyleTextStyle.SetParameter(New RParameter("style", iNewPosition:=5))
        dctTextStyle.Add("NULL", "NULL")
        dctTextStyle.Add("normal", Chr(34) & "normal" & Chr(34))
        dctTextStyle.Add("italic", Chr(34) & "italic" & Chr(34))
        dctTextStyle.Add("oblique", Chr(34) & "oblique" & Chr(34))
        ucrInputStyleTextStyle.SetItems(dctTextStyle)
        ucrInputStyleTextStyle.SetRDefault("NULL")
        ucrInputStyleTextStyle.SetLinkedDisplayControl(lblStyleTextStyle)

        ucrInputStyleTextWeight.SetParameter(New RParameter("weight", iNewPosition:=6))
        dctTextWeight.Add("NULL", "NULL")
        dctTextWeight.Add("normal", Chr(34) & "normal" & Chr(34))
        dctTextWeight.Add("bold", Chr(34) & "bold" & Chr(34))
        dctTextWeight.Add("lighter", Chr(34) & "lighter" & Chr(34))
        dctTextWeight.Add("bolder", Chr(34) & "bolder" & Chr(34))
        ucrInputStyleTextWeight.SetItems(dctTextWeight)
        ucrInputStyleTextWeight.SetRDefault("NULL")
        ucrInputStyleTextWeight.SetLinkedDisplayControl(lblStyleTextWeight)

        ucrInputStyleTextStretch.SetParameter(New RParameter("stretch", iNewPosition:=7))
        dctTextStretch.Add("NULL", "NULL")
        dctTextStretch.Add("ultra-condensed", Chr(34) & "ultra-condensed" & Chr(34))
        dctTextStretch.Add("extra-condensed", Chr(34) & "extra-condensed" & Chr(34))
        dctTextStretch.Add("condensed", Chr(34) & "condensed" & Chr(34))
        dctTextStretch.Add("semi-condensed", Chr(34) & "semi-condensed" & Chr(34))
        dctTextStretch.Add("normal", Chr(34) & "normal" & Chr(34))
        dctTextStretch.Add("semi-expanded", Chr(34) & "semi-expanded" & Chr(34))
        dctTextStretch.Add("expanded", Chr(34) & "expanded" & Chr(34))
        dctTextStretch.Add("extra-expanded", Chr(34) & "extra-expanded" & Chr(34))
        dctTextStretch.Add("ultra-expanded", Chr(34) & "ultra-expanded" & Chr(34))
        ucrInputStyleTextStretch.SetItems(dctTextStretch)
        ucrInputStyleTextStretch.SetRDefault("NULL")
        ucrInputStyleTextStretch.SetLinkedDisplayControl(lblStyleTextStretch)

        ucrInputStyleTextDecorate.SetParameter(New RParameter("decorate", iNewPosition:=8))
        dctTextDecorate.Add("NULL", "NULL")
        dctTextDecorate.Add("overline", Chr(34) & "overline" & Chr(34))
        dctTextDecorate.Add("line-through", Chr(34) & "line-through" & Chr(34))
        dctTextDecorate.Add("underline", Chr(34) & "underline" & Chr(34))
        ucrInputStyleTextDecorate.SetItems(dctTextDecorate)
        ucrInputStyleTextDecorate.SetRDefault("NULL")
        ucrInputStyleTextDecorate.SetLinkedDisplayControl(lblStyleTextDecorate)

        ucrInputStyleTextTransform.SetParameter(New RParameter("transform", iNewPosition:=9))
        dctTextTransform.Add("NULL", "NULL")
        dctTextTransform.Add("uppercase", Chr(34) & "uppercase" & Chr(34))
        dctTextTransform.Add("lowercase", Chr(34) & "lowercase" & Chr(34))
        dctTextTransform.Add("capitalize", Chr(34) & "capitalize" & Chr(34))
        ucrInputStyleTextTransform.SetItems(dctTextTransform)
        ucrInputStyleTextTransform.SetRDefault("NULL")
        ucrInputStyleTextTransform.SetLinkedDisplayControl(lblStyleTextTransform)

        ucrInputStyleTextWhitespace.SetParameter(New RParameter("whitespace", iNewPosition:=10))
        dctTextWhitespace.Add("NULL", "NULL")
        dctTextWhitespace.Add("normal", Chr(34) & "normal" & Chr(34))
        dctTextWhitespace.Add("nowrap", Chr(34) & "nowrap" & Chr(34))
        dctTextWhitespace.Add("pre", Chr(34) & "pre" & Chr(34))
        dctTextWhitespace.Add("pre-wrap", Chr(34) & "pre-wrap" & Chr(34))
        dctTextWhitespace.Add("pre-line", Chr(34) & "pre-line" & Chr(34))
        dctTextWhitespace.Add("break-spaces", Chr(34) & "break-spaces" & Chr(34))
        ucrInputStyleTextWhitespace.SetItems(dctTextWhitespace)
        ucrInputStyleTextWhitespace.SetRDefault("NULL")
        ucrInputStyleTextWhitespace.SetLinkedDisplayControl(lblStyleTextWhitespace)

        ucrNudStyleTextIndent.SetParameter(New RParameter("indent", iNewPosition:=11))
        ucrNudStyleTextIndent.SetRDefault(0)

        ucrNudStyleTextIndent.SetLinkedDisplayControl(lblStyleTextIndent)
        ucrNudStyleTextIndent.Increment = 1

        ucrChkStyleBoarder.SetText("Add style border")
        ucrChkStyleBoarder.AddToLinkedControls({ucrInputStyleBorderSides, ucrInputStyleBorderColor, ucrInputStyleBorderStyle, ucrNudStyleBorderWeight}, {True},
                                                bNewLinkedHideIfParameterMissing:=True)

        ucrChkStyleBoarder.AddParameterPresentCondition(True, "boarderStyle")
        ucrChkStyleBoarder.AddParameterPresentCondition(False, "boarderStyle", False)

        ucrInputStyleBorderSides.SetParameter(New RParameter("sides", iNewPosition:=0))
        ucrInputStyleBorderSides.SetItems({"all", "left", "right", "top", "bottom"}, bAddConditions:=True)
        ucrInputStyleBorderSides.SetRDefault(Chr(34) & "all" & Chr(34))
        ucrInputStyleBorderSides.SetLinkedDisplayControl(lblBorderSides)

        ucrInputStyleBorderColor.SetParameter(New RParameter("color", iNewPosition:=1))
        ucrInputStyleBorderColor.SetRDefault("#000000")
        ucrInputStyleBorderColor.SetLinkedDisplayControl(lblBorderColor)

        ucrInputStyleBorderStyle.SetParameter(New RParameter("style", iNewPosition:=2))
        ucrInputStyleBorderStyle.SetItems({"solid", "dashed", "dotted"}, bAddConditions:=True)
        ucrInputStyleBorderStyle.SetRDefault(Chr(34) & "solid" & Chr(34))
        ucrInputStyleBorderStyle.SetLinkedDisplayControl(lblBorderStyle)

        ucrNudStyleBorderWeight.SetParameter(New RParameter("weight", iNewPosition:=3, bNewIncludeArgumentName:=False))
        ucrNudStyleBorderWeight.SetLinkedDisplayControl(lblBorderWeight)
        ucrNudStyleBorderWeight.Increment = 1

        ucrChkStyleFill.SetText("Add fill style")
        ucrChkStyleFill.AddToLinkedControls({ucrNudStyleFillAlpha, ucrInputStyleFillColor}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStyleFill.AddParameterPresentCondition(True, "fillStyle")
        ucrChkStyleFill.AddParameterPresentCondition(False, "fillStyle", False)

        ucrNudStyleFillAlpha.Increment = 0.1
        ucrNudStyleFillAlpha.DecimalPlaces = 1
        ucrNudStyleFillAlpha.SetMinMax(0.0, 1.0)
        ucrNudStyleFillAlpha.SetParameter(New RParameter("alpha", iNewPosition:=1))
        ucrNudStyleFillAlpha.SetRDefault("0.0")
        ucrNudStyleFillAlpha.SetLinkedDisplayControl(lblStyleFillAlpha)

        ucrInputStyleFillColor.SetParameter(New RParameter("color", iNewPosition:=0))
        ucrInputStyleFillColor.SetRDefault("#D3D3D3")
        ucrInputStyleFillColor.SetLinkedDisplayControl(lblStyleFillColor)
        'Table
        ucrInputTableAlign.SetParameter(New RParameter("table.align", iNewPosition:=0))
        dctTableAlign.Add("NULL", "NULL")
        dctTableAlign.Add("left", Chr(34) & "left" & Chr(34))
        dctTableAlign.Add("right", Chr(34) & "right" & Chr(34))
        ucrInputTableAlign.SetItems(dctTableAlign)
        ucrInputTableAlign.SetRDefault("NULL")
        ucrInputTableAlign.SetLinkedDisplayControl(lblTableAlign)

        ucrInputTableBackgroundColor.SetParameter(New RParameter("table.background.color", iNewPosition:=1))
        ucrInputTableBackgroundColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrInputTableBackgroundColor.SetLinkedDisplayControl(lblTableBackgroundColor)

        ucrInputTableFontColor.SetParameter(New RParameter("table.font.color ", 2))
        ucrInputTableFontColor.SetRDefault(Chr(34) & "NULL" & Chr(34))
        ucrInputTableFontColor.SetLinkedDisplayControl(lblTableFontColor)

        ucrInputTableLayout.SetParameter(New RParameter("table.layout", iNewPosition:=3))
        ucrInputTableLayout.SetItems({"fixed", "auto"}, bAddConditions:=True)
        ucrInputTableLayout.SetRDefault(Chr(34) & "fixed" & Chr(34))
        ucrInputTableLayout.SetLinkedDisplayControl(lblTableLayout)

        ucrInputTableFontWeight.SetParameter(New RParameter("table.font.weight", iNewPosition:=4))
        ucrInputTableFontWeight.SetItems(dctTextWeight)
        ucrInputTableFontWeight.SetRDefault("NULL")
        ucrInputTableFontWeight.SetLinkedDisplayControl(lblTableFontWeight)

        ucrNudTableWidth.SetParameter(New RParameter("table.width", iNewPosition:=0))
        ucrNudTableWidth.SetRDefault(0)
        ucrNudTableWidth.SetLinkedDisplayControl(lblTableWidth)

        ucrNudTableFontSize.SetParameter(New RParameter("table.font.size", iNewPosition:=0))
        ucrNudTableFontSize.SetRDefault(0)
        ucrNudTableFontSize.SetLinkedDisplayControl(lblFontSize)

        ucrChkAddStubHeader.SetText("Add stub header")
        ucrChkAddStubHeader.AddToLinkedControls(ucrInputStubLabel, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddStubHeader.AddParameterPresentCondition(True, "stub")
        ucrChkAddStubHeader.AddParameterPresentCondition(False, "stub", False)
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(bReset As Boolean, clsNewTableTitleFunction As RFunction, clsNewTabFootnoteTitleFunction As RFunction, clsNewFootnoteCellFunction As RFunction,
                        clsNewTableSourcenoteFunction As RFunction, clsNewCellTextFunction As RFunction, clsNewStubHeadFunction As RFunction, clsNewTabStyleFunction As RFunction,
                        clsNewCellBorderFunction As RFunction, clsNewCellFillFunction As RFunction, clsNewHeaderFormatFunction As RFunction, clsNewMutableOPerator As ROperator,
                        clsNewTabOptionsFunction As RFunction, clsNewPipeOperator As ROperator, clsNewBorderWeightPxFunction As RFunction, clsNewFootnoteTitleLocationFunction As RFunction,
                        clsNewFootnoteSubtitleLocationFunction As RFunction, clsNewTabFootnoteSubtitleFunction As RFunction, clsNewStyleListFunction As RFunction,
                        clsNewFootnoteCellBodyFunction As RFunction, clsNewJoiningOperator As ROperator, clsNewSecondFootnoteCellFunction As RFunction, clsNewTabFootnoteOperator As ROperator,
                        clsNewTabStyleCellTextFunction As RFunction, clsNewSecondFootnoteCellBodyFunction As RFunction, clsNewTabStylePxFunction As RFunction)
        clsTableTitleFunction = clsNewTableTitleFunction
        clsTabFootnoteTitleFunction = clsNewTabFootnoteTitleFunction
        clsTabFootnoteSubtitleFunction = clsNewTabFootnoteSubtitleFunction
        clsTableSourcenoteFunction = clsNewTableSourcenoteFunction
        clsCellTextFunction = clsNewCellTextFunction
        clsCellBorderFunction = clsNewCellBorderFunction
        clsCellFillFunction = clsNewCellFillFunction
        clsHeaderFormatFunction = clsNewHeaderFormatFunction
        clsTabOptionsFunction = clsNewTabOptionsFunction
        clsBorderWeightPxFunction = clsNewBorderWeightPxFunction
        clsFootnoteSubtitleLocationFunction = clsNewFootnoteSubtitleLocationFunction
        clsFootnoteTitleLocationFunction = clsNewFootnoteTitleLocationFunction
        clsStyleListFunction = clsNewStyleListFunction
        clsPipeOperator = clsNewPipeOperator
        clsMutableOperator = clsNewMutableOPerator
        clsFootnoteCellFunction = clsNewFootnoteCellFunction
        clsFootnoteCellBodyFunction = clsNewFootnoteCellBodyFunction
        clsJoiningOperator = clsNewJoiningOperator
        clsStubHeadFunction = clsNewStubHeadFunction
        clsSecondFootnoteCellFunction = clsNewSecondFootnoteCellFunction
        clsSecondFootnoteCellBodyFunction = clsNewSecondFootnoteCellBodyFunction
        clsTabStyleFunction = clsNewTabStyleFunction
        clsTabStyleCellTextFunction = clsNewTabStyleCellTextFunction
        clsTabStylePxFunction = clsNewTabStylePxFunction
        clsTabFootnoteOperator = clsNewTabFootnoteOperator

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        ucrChkAddTitleSubtitle.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkTitleFootnote.SetRCode(clsTabFootnoteOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChKAddSecondFootnote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkSubtitleFootnote.SetRCode(clsTabFootnoteOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddSourcenote.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddHeader.SetRCode(clsMutableOperator, bReset, bCloneIfNeeded:=True)
        ucrChkStyleText.SetRCode(clsStyleListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkStyleBoarder.SetRCode(clsStyleListFunction, bReset, bCloneIfNeeded:=True)
        ucrChkStyleFill.SetRCode(clsStyleListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextColor.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextFont.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextSize.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextAlign.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextValign.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextStyle.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextWeight.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextStretch.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextDecorate.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextTransform.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleTextWhitespace.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrNudStyleTextIndent.SetRCode(clsCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleBorderSides.SetRCode(clsCellBorderFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleBorderColor.SetRCode(clsCellBorderFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleBorderStyle.SetRCode(clsCellBorderFunction, bReset, bCloneIfNeeded:=True)
        ucrNudStyleBorderWeight.SetRCode(clsBorderWeightPxFunction, bReset, bCloneIfNeeded:=True)
        ucrNudStyleFillAlpha.SetRCode(clsCellFillFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleFillColor.SetRCode(clsCellFillFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableAlign.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableBackgroundColor.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableFontColor.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableLayout.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableFontWeight.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableWidth.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableFontSize.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrPnlHeader.SetRCode(clsHeaderFormatFunction, bReset, bCloneIfNeeded:=True)
        ucrChkAddTableFormat.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddStubHeader.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
        ucrInputTitleFont.SetRCode(clsTabStyleCellTextFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTitleSize.SetRCode(clsTabStylePxFunction, bReset, bCloneIfNeeded:=True)
    End Sub

    Private Sub ucrChkAddTitleSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddTitleSubtitle.ControlValueChanged
        AddTableTitle()
        AddFootnote()
    End Sub

    Private Sub AddTableTitle()
        If ucrChkAddTitleSubtitle.Checked AndAlso (Not ucrInputTitle.IsEmpty OrElse Not ucrInputSubtitle.IsEmpty) Then
            clsPipeOperator.AddParameter("title\subtitle", clsRFunctionParameter:=clsTableTitleFunction, iPosition:=1)
            clsPipeOperator.AddParameter("title_font", clsRFunctionParameter:=clsTabStyleFunction, iPosition:=5)
        Else
            clsPipeOperator.RemoveParameterByName("title\subtitle")
            clsPipeOperator.RemoveParameterByName("title_font")
        End If
    End Sub

    Private Sub ucrInputTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTitle.ControlValueChanged
        AddTableTitle()
        If Not ucrInputTitle.IsEmpty Then
            clsTableTitleFunction.AddParameter("title", Chr(34) & ucrInputTitle.GetText() & Chr(34), iPosition:=0)
        Else
            clsTableTitleFunction.RemoveParameterByName("title")
        End If
    End Sub

    Private Sub ucrInputSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSubtitle.ControlValueChanged
        AddTableTitle()
        If Not ucrInputSubtitle.IsEmpty Then
            clsTableTitleFunction.AddParameter("subtitle", Chr(34) & ucrInputSubtitle.GetText() & Chr(34), iPosition:=1)
        Else
            clsTableTitleFunction.RemoveParameterByName("subtitle")
        End If
    End Sub

    Private Sub AddFootnote()
        If ucrChkTitleFootnote.Checked AndAlso Not ucrInputTitleFootnote.IsEmpty Then
            clsTabFootnoteOperator.AddParameter("titlefootnote", clsRFunctionParameter:=clsTabFootnoteTitleFunction, iPosition:=1)
        Else
            clsTabFootnoteOperator.RemoveParameterByName("titlefootnote")
        End If

        If ucrChkSubtitleFootnote.Checked AndAlso Not ucrInputSubtitleFootnote.IsEmpty Then
            clsTabFootnoteOperator.AddParameter("subtitlefootnote", clsRFunctionParameter:=clsTabFootnoteSubtitleFunction, iPosition:=2)
        Else
            clsTabFootnoteOperator.RemoveParameterByName("subtitlefootnote")
        End If

        If (ucrChkSubtitleFootnote.Checked OrElse ucrChkTitleFootnote.Checked) AndAlso clsTabFootnoteOperator.clsParameters.Count >= 1 AndAlso ucrChkAddTitleSubtitle.Checked Then
            clsPipeOperator.AddParameter("title_footnote", clsROperatorParameter:=clsTabFootnoteOperator, iPosition:=1)
        Else
            clsPipeOperator.RemoveParameterByName("title_footnote")
        End If
    End Sub

    Private Sub ucrChkTitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTitleFootnote.ControlValueChanged
        If ucrChkTitleFootnote.Checked Then
            clsTabFootnoteTitleFunction.AddParameter("locations", clsRFunctionParameter:=clsFootnoteTitleLocationFunction, iPosition:=2)
            clsFootnoteTitleLocationFunction.AddParameter("groups", Chr(34) & "title" & Chr(34), iPosition:=0)
        Else
            clsFootnoteTitleLocationFunction.RemoveParameterByName("groups")
            clsTabFootnoteTitleFunction.RemoveParameterByName("locations")
        End If
        AddFootnote()
    End Sub

    Private Sub ucrChkSubtitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSubtitleFootnote.ControlValueChanged
        If ucrChkSubtitleFootnote.Checked Then
            clsTabFootnoteSubtitleFunction.AddParameter("locations", clsRFunctionParameter:=clsFootnoteSubtitleLocationFunction, iPosition:=2)
            clsFootnoteSubtitleLocationFunction.AddParameter("groups", Chr(34) & "subtitle" & Chr(34), iPosition:=0)
        Else
            clsFootnoteSubtitleLocationFunction.RemoveParameterByName("groups")
            clsTabFootnoteSubtitleFunction.RemoveParameterByName("locations")
        End If
        AddFootnote()
    End Sub

    Private Sub ucrInputTitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTitleFootnote.ControlValueChanged
        If Not ucrInputTitleFootnote.IsEmpty Then
            clsTabFootnoteTitleFunction.AddParameter("footnote", Chr(34) & ucrInputTitleFootnote.GetText() & Chr(34), iPosition:=1)
        Else
            clsTabFootnoteTitleFunction.RemoveParameterByName("footnote")
        End If
        AddFootnote()
    End Sub

    Private Sub ucrInputSubtitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSubtitleFootnote.ControlValueChanged
        If Not ucrInputSubtitleFootnote.IsEmpty Then
            clsTabFootnoteSubtitleFunction.AddParameter("footnote", Chr(34) & ucrInputSubtitleFootnote.GetText & Chr(34), iPosition:=1)
        Else
            clsTabFootnoteSubtitleFunction.RemoveParameterByName("footnote")
        End If
        AddFootnote()
    End Sub

    Private Sub ucrInputAddSourceNote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputAddSourceNote.ControlValueChanged
        AddRemoveSourceNoteParameter()
        AddSourceNote()
    End Sub

    Private Sub ucrChkStyleText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStyleText.ControlValueChanged
        If ucrChkStyleText.Checked Then
            clsStyleListFunction.AddParameter("textStyle", clsRFunctionParameter:=clsCellTextFunction, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsStyleListFunction.RemoveParameterByName("textStyle")
        End If
    End Sub

    Private Sub ucrChkStyleBoarder_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStyleBoarder.ControlValueChanged
        If ucrChkStyleBoarder.Checked Then
            clsStyleListFunction.AddParameter("boarderStyle", clsRFunctionParameter:=clsCellBorderFunction, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsStyleListFunction.RemoveParameterByName("boarderStyle")
        End If
    End Sub

    Private Sub ucrChkStyleFill_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStyleFill.ControlValueChanged
        If ucrChkStyleFill.Checked Then
            clsStyleListFunction.AddParameter("fillStyle", clsRFunctionParameter:=clsCellFillFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsStyleListFunction.RemoveParameterByName("fillStyle")
        End If
    End Sub

    Private Sub ucrChkAddHeader_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddHeader.ControlValueChanged
        If ucrChkAddHeader.Checked Then
            clsMutableOperator.AddParameter("header", clsRFunctionParameter:=clsHeaderFormatFunction, iPosition:=2)
        Else
            clsMutableOperator.RemoveParameterByName("header")
        End If
    End Sub

    Private Sub PipeOperator_controlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkAddTitleSubtitle.ControlContentsChanged,
            ucrChkAddFootnote.ControlContentsChanged, ucrChKAddSecondFootnote.ControlContentsChanged, ucrChkAddSourcenote.ControlContentsChanged,
            ucrChkAddHeader.ControlContentsChanged, ucrChkAddTableFormat.ControlContentsChanged, ucrChkAddStubHeader.ControlContentsChanged,
            ucrInputTitle.ControlContentsChanged, ucrInputSubtitle.ControlContentsChanged, ucrInputTitleFootnote.ControlContentsChanged,
            ucrInputSubtitleFootnote.ControlContentsChanged, ucrInputAddSourceNote.ControlContentsChanged, ucrInputStubLabel.ControlContentsChanged,
            ucrInputCellFootnote.ControlContentsChanged, ucrInputSecondCellFootnote.ControlContentsChanged

        If ucrChkAddTitleSubtitle.Checked OrElse ucrChkAddFootnote.Checked OrElse ucrChKAddSecondFootnote.Checked OrElse ucrChkAddSourcenote.Checked OrElse
            ucrChKAddSecondFootnote.Checked OrElse ucrChkAddTableFormat.Checked OrElse ucrChkAddStubHeader.Checked Then
            If ucrInputTitle.IsEmpty AndAlso ucrInputSubtitle.IsEmpty AndAlso ucrInputTitleFootnote.IsEmpty AndAlso
                ucrInputSubtitleFootnote.IsEmpty AndAlso ucrInputAddSourceNote.IsEmpty AndAlso ucrInputStubLabel.IsEmpty AndAlso
                Not ucrChkAddTableFormat.Checked AndAlso ucrInputCellFootnote.IsEmpty AndAlso ucrInputSecondCellFootnote.IsEmpty Then
                clsJoiningOperator.RemoveParameterByName("pipe")
            Else
                clsJoiningOperator.AddParameter("pipe", clsROperatorParameter:=clsPipeOperator, iPosition:=1)
            End If
        Else
            clsJoiningOperator.RemoveParameterByName("pipe")
        End If
    End Sub

    Private Sub AddCellFootnote()
        If ucrChkAddFootnote.Checked AndAlso Not ucrInputCellFootnote.IsEmpty Then
            clsPipeOperator.AddParameter("cellfootnote", clsRFunctionParameter:=clsFootnoteCellFunction, iPosition:=3)
        Else
            clsPipeOperator.RemoveParameterByName("cellfootnote")
        End If

        If ucrChKAddSecondFootnote.Checked AndAlso Not ucrInputSecondCellFootnote.IsEmpty Then

            clsPipeOperator.AddParameter("second_cellfootnote", clsRFunctionParameter:=clsSecondFootnoteCellFunction, iPosition:=3)
        Else
            clsPipeOperator.RemoveParameterByName("second_cellfootnote")
        End If
    End Sub

    Private Sub AddFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddFootnote.ControlValueChanged, ucrChKAddSecondFootnote.ControlValueChanged
        If ucrChkAddFootnote.Checked Then
            clsFootnoteCellFunction.AddParameter("locations", clsRFunctionParameter:=clsFootnoteCellBodyFunction, iPosition:=3)
        Else
            clsFootnoteCellFunction.RemoveParameterByName("locations")
        End If

        If ucrChKAddSecondFootnote.Checked Then
            clsSecondFootnoteCellFunction.AddParameter("locations", clsRFunctionParameter:=clsSecondFootnoteCellBodyFunction, iPosition:=3)
        Else
            clsSecondFootnoteCellFunction.RemoveParameterByName("locations")
        End If
        AddRemoveFootnote()
        AddCellFootnote()
    End Sub

    Private Sub ColumnLocation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFootnoteColumnLocation.ControlValueChanged, ucrInputSecondFootnoteColumnLocation.ControlValueChanged
        If Not ucrInputFootnoteColumnLocation.IsEmpty Then
            clsFootnoteCellBodyFunction.AddParameter("columns", clsRFunctionParameter:=ucrInputFootnoteColumnLocation.clsRList, iPosition:=0)
        Else
            clsFootnoteCellBodyFunction.AddParameter("columns", "everything()", iPosition:=0)
        End If

        If Not ucrInputSecondFootnoteColumnLocation.IsEmpty Then
            clsSecondFootnoteCellBodyFunction.AddParameter("columns", clsRFunctionParameter:=ucrInputSecondFootnoteColumnLocation.clsRList, iPosition:=0)
        Else
            clsSecondFootnoteCellBodyFunction.AddParameter("columns", "everything()", iPosition:=0)
        End If
    End Sub

    Private Sub RowLocation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFootnoteRowLocation.ControlValueChanged, ucrInputSecondFootnoteRowLocation.ControlValueChanged
        If Not ucrInputFootnoteRowLocation.IsEmpty Then
            clsFootnoteCellBodyFunction.AddParameter("rows", clsRFunctionParameter:=ucrInputFootnoteRowLocation.clsRList, iPosition:=1)
        Else
            clsFootnoteCellBodyFunction.AddParameter("rows", "everything()", iPosition:=1)
        End If

        If Not ucrInputSecondFootnoteRowLocation.IsEmpty Then
            clsSecondFootnoteCellBodyFunction.AddParameter("rows", clsRFunctionParameter:=ucrInputSecondFootnoteRowLocation.clsRList, iPosition:=1)
        Else
            clsSecondFootnoteCellBodyFunction.AddParameter("rows", "everything()", iPosition:=1)
        End If
    End Sub

    Private Sub Footnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCellFootnote.ControlValueChanged, ucrInputSecondCellFootnote.ControlValueChanged
        AddRemoveFootnote()
        AddCellFootnote()
    End Sub

    Private Sub AddRemoveFootnote()
        If Not ucrInputCellFootnote.IsEmpty Then
            clsFootnoteCellFunction.AddParameter("footnote", Chr(34) & ucrInputCellFootnote.GetText() & Chr(34), iPosition:=2)
        Else
            clsFootnoteCellFunction.RemoveParameterByName("footnote")
        End If

        If Not ucrInputSecondCellFootnote.IsEmpty Then
            clsSecondFootnoteCellFunction.AddParameter("footnote", Chr(34) & ucrInputSecondCellFootnote.GetText() & Chr(34), iPosition:=2)
        Else
            clsSecondFootnoteCellFunction.RemoveParameterByName("footnote")
        End If
    End Sub

    Private Sub AddSourceNote()
        If ucrChkAddSourcenote.Checked AndAlso Not ucrInputAddSourceNote.IsEmpty Then
            clsPipeOperator.AddParameter("source_note", iPosition:=4, clsRFunctionParameter:=clsTableSourcenoteFunction)
        Else
            clsPipeOperator.RemoveParameterByName("source_note")
        End If
    End Sub

    Private Sub ucrChkAddSourcenote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddSourcenote.ControlValueChanged
        AddSourceNote()
        AddRemoveSourceNoteParameter()
    End Sub

    Private Sub AddRemoveSourceNoteParameter()
        If Not ucrInputAddSourceNote.IsEmpty Then
            clsTableSourcenoteFunction.AddParameter("source_note", Chr(34) & ucrInputAddSourceNote.GetText() & Chr(34), iPosition:=1)
        Else
            clsTableSourcenoteFunction.RemoveParameterByName("source_note")
        End If
    End Sub

    Private Sub ucrChkAddTableFormat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddTableFormat.ControlValueChanged
        If ucrChkAddTableFormat.Checked Then
            clsPipeOperator.AddParameter("table_format", clsRFunctionParameter:=clsTabOptionsFunction, iPosition:=6)
        Else
            clsPipeOperator.RemoveParameterByName("table_format")
        End If
    End Sub

    Private Sub ucrChkAddStubHeader_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddStubHeader.ControlValueChanged
        If ucrChkAddStubHeader.Checked Then
            clsPipeOperator.AddParameter("stub", clsRFunctionParameter:=clsStubHeadFunction, iPosition:=5)
        Else
            clsPipeOperator.RemoveParameterByName("stub")
        End If
    End Sub

    Private Sub ucrInputStubLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStubLabel.ControlValueChanged
        If Not ucrInputStubLabel.IsEmpty Then
            clsStubHeadFunction.AddParameter("label", Chr(34) & ucrInputStubLabel.GetText & Chr(34), iPosition:=0)
        Else
            clsStubHeadFunction.RemoveParameterByName("label")
        End If
    End Sub
End Class