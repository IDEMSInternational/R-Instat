' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class sdgFormatSummaryTables
    Private clsTableTitleFunction, clsTabFootnoteTitleFunction, clsTableSourcenoteFunction, clsFootnoteCellFunction,
        clsCellTextFunction, clsCellBorderFunction, clsCellFillFunction, clsHeaderFormatFunction, clsFootnoteTitleLocationFunction,
        clsTabOptionsFunction, clsBorderWeightPxFunction, clsFootnoteSubtitleLocationFunction, clsTabFootnoteSubtitleFunction, clsFootnoteCellBodyFunction,
        clsStyleListFunction, clsStubHeadFunction, clsSecondFootnoteCellFunction, clsSecondFootnoteCellBodyFunction,
        clsTabStyleFunction, clsTabStyleCellTextFunction, clsTabStylePxFunction As New RFunction
    'The dummy Function is used by input controls that add the parameter manually,
    'when opening the subdialogue from multiple dialogues
    Private clsDummyFunction As New RFunction
    Private clsPipeOperator, clsMutableOperator, clsJoiningOperator, clsTabFootnoteOperator As New ROperator
    Private bControlsInitialised As Boolean = False
    Private bRCodeSet As Boolean = False
    Private Sub sdgFormatSummaryTables_load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        bControlsInitialised = False
        Dim dctTextSize, dctTextAlign, dctTextValign, dctTextStyle, dctTextWeight, dctTextDecorate, dctTextTransform,
        dctTextStretch, dctTextWhitespace, dctTableAlign As New Dictionary(Of String, String)

        'Titles
        ucrInputTitle.SetParameter(New RParameter("title", iNewPosition:=0))
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)

        ucrInputSubtitle.SetParameter(New RParameter("subtitle", iNewPosition:=1))
        ucrInputSubtitle.SetLinkedDisplayControl(lblSubtitle)

        ucrInputTitleFootnote.SetParameter(New RParameter("title_footnote", iNewPosition:=2))

        ucrChkTitleFootnote.SetText("Add title footnote")
        ucrChkTitleFootnote.AddToLinkedControls(ucrInputTitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTitleFootnote.SetLinkedDisplayControl(grpTitleSubtitle)

        ucrChkTitleFootnote.AddParameterPresentCondition(True, "title_footnote")
        ucrChkTitleFootnote.AddParameterPresentCondition(False, "title_footnote", False)

        ucrInputSubtitleFootnote.SetParameter(New RParameter("subtitle_footnote", iNewPosition:=3))

        ucrChkSubtitleFootnote.SetText("Add subtitle footnote")
        ucrChkSubtitleFootnote.AddToLinkedControls(ucrInputSubtitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSubtitleFootnote.AddParameterPresentCondition(True, "subtitle_footnote")
        ucrChkSubtitleFootnote.AddParameterPresentCondition(False, "subtitle_footnote", False)

        ucrInputTitleFont.SetParameter(New RParameter("font", iNewPosition:=0))
        ucrInputTitleFont.SetRDefault("NULL")
        ucrInputTitleFont.SetLinkedDisplayControl(lblTitleFont)

        ucrNudTitleSize.SetParameter(New RParameter("size", iNewPosition:=0, bNewIncludeArgumentName:=False))
        ucrNudTitleSize.Increment = 1
        ucrNudTitleSize.SetMinMax(1)
        ucrNudTitleSize.SetLinkedDisplayControl(lblTitleSize)

        ucrChkAddTitleSubtitle.SetText("Add title/subtitle")
        ucrChkAddTitleSubtitle.AddToLinkedControls({ucrInputTitle, ucrInputSubtitle, ucrChkTitleFootnote, ucrChkSubtitleFootnote, ucrInputTitleFont, ucrNudTitleSize}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddTitleSubtitle.AddParameterPresentCondition(True, "title_subtitle")
        ucrChkAddTitleSubtitle.AddParameterPresentCondition(False, "title_subtitle", False)

        ucrInputFootnoteColumnLocation.SetParameter(New RParameter("col_location", 5))
        ucrInputFootnoteColumnLocation.SetValidationTypeAsNumericList()

        ucrInputFootnoteRowLocation.SetParameter(New RParameter("row_location", iNewPosition:=6))
        ucrInputFootnoteRowLocation.SetValidationTypeAsNumericList()
        ucrInputFootnoteRowLocation.SetLinkedDisplayControl(grpLocation)

        ucrInputCellFootnote.SetParameter(New RParameter("cell_footnote", iNewPosition:=4))
        ucrInputCellFootnote.SetLinkedDisplayControl(lblFootnote)

        ucrChkAddFootnote.SetText("Add footnote")
        ucrChkAddFootnote.AddToLinkedControls({ucrInputCellFootnote, ucrInputFootnoteColumnLocation, ucrInputFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddFootnote.AddParameterPresentCondition(True, "cell_footnote")
        ucrChkAddFootnote.AddParameterPresentCondition(False, "cell_footnote", False)

        ucrChKAddSecondFootnote.SetText("Add second footnote")
        ucrChKAddSecondFootnote.AddToLinkedControls({ucrInputSecondCellFootnote, ucrInputSecondFootnoteColumnLocation, ucrInputSecondFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputSecondFootnoteRowLocation.SetParameter(New RParameter("second_row_location", iNewPosition:=7))
        ucrInputSecondFootnoteRowLocation.SetValidationTypeAsNumericList()

        ucrInputSecondFootnoteColumnLocation.SetParameter(New RParameter("second_col_location", iNewPosition:=6))
        ucrInputSecondFootnoteColumnLocation.SetValidationTypeAsNumericList()

        ucrInputSecondCellFootnote.SetParameter(New RParameter("second_footnote", iNewPosition:=4))
        ucrInputSecondCellFootnote.SetLinkedDisplayControl(lblSecondFootnote)

        ucrInputSecondFootnoteColumnLocation.SetLinkedDisplayControl(grpSecondFootnote)

        ucrChKAddSecondFootnote.AddParameterPresentCondition(True, "second_cellfootnote")
        ucrChKAddSecondFootnote.AddParameterPresentCondition(False, "second_cellfootnote", False)

        ucrInputAddSourceNote.SetParameter(New RParameter("source_note", iNewPosition:=8))

        ucrChkAddSourcenote.SetText("Add source")
        ucrChkAddSourcenote.AddToLinkedControls(ucrInputAddSourceNote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddSourcenote.AddParameterPresentCondition(True, "source_note")
        ucrChkAddSourcenote.AddParameterPresentCondition(False, "source_note", False)
        'Header
        ucrChkAddHeader.SetText("Add header")
        ucrChkAddHeader.AddToLinkedControls({ucrChkStyleText, ucrPnlHeader}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)
        ucrChkAddHeader.AddParameterPresentCondition(True, "header")
        ucrChkAddHeader.AddParameterPresentCondition(False, "header", False)

        ucrChkAddTableFormat.SetText("Add table format")
        ucrChkAddTableFormat.AddToLinkedControls({ucrInputTableLayout, ucrInputTableAlign, ucrInputTableBackgroundColor, ucrInputTableFontWeight, ucrInputTableFontColor,
                                                  ucrNudTableWidth, ucrNudTableFontSize}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddTableFormat.AddParameterPresentCondition(True, "table_format")
        ucrChkAddTableFormat.AddParameterPresentCondition(False, "table_format", False)

        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)
        ucrPnlHeader.SetParameter(New RParameter("header", iNewPosition:=0))
        ucrPnlHeader.AddRadioButton(rdoAllColumns, Chr(34) & "all_cols" & Chr(34))
        ucrPnlHeader.AddRadioButton(rdoAllRows, Chr(34) & "all_rows" & Chr(34))
        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)

        ucrChkStyleText.SetText("Add text style")
        ucrChkStyleText.AddToLinkedControls({ucrInputStyleTextColor, ucrInputStyleTextFont, ucrInputStyleTextSize, ucrInputStyleTextAlign,
                                             ucrInputStyleTextValign, ucrInputStyleTextStyle, ucrInputStyleTextWeight, ucrInputStyleTextStretch,
                                             ucrInputStyleTextDecorate, ucrInputStyleTextTransform, ucrInputStyleTextWhitespace, ucrNudStyleTextIndent},
                                          {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkStyleText.SetLinkedDisplayControl(grpStyle)
        ucrChkStyleText.AddParameterPresentCondition(True, "text_style")
        ucrChkStyleText.AddParameterPresentCondition(False, "text_style", False)

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

        ucrChkStyleBoarder.AddParameterPresentCondition(True, "border_style")
        ucrChkStyleBoarder.AddParameterPresentCondition(False, "border_style", False)

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
        ucrChkStyleFill.AddParameterPresentCondition(True, "fill_style")
        ucrChkStyleFill.AddParameterPresentCondition(False, "fill_style", False)

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
                        clsNewTabStyleCellTextFunction As RFunction, clsNewSecondFootnoteCellBodyFunction As RFunction, clsNewTabStylePxFunction As RFunction, clsNewDummyFunction As RFunction)
        bRCodeSet = False
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
        clsDummyFunction = clsNewDummyFunction

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
        ucrInputTitle.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSubtitle.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputCellFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSecondCellFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputFootnoteColumnLocation.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputFootnoteRowLocation.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSecondFootnoteColumnLocation.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSecondFootnoteRowLocation.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputAddSourceNote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTitleFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        ucrInputSubtitleFootnote.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        bRCodeSet = True
    End Sub

    Private Sub ucrChkAddTitleSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddTitleSubtitle.ControlValueChanged
        AddTableTitle()
        AddFootnote()
    End Sub

    Private Sub AddTableTitle()
        If ucrChkAddTitleSubtitle.Checked AndAlso (Not ucrInputTitle.IsEmpty OrElse Not ucrInputSubtitle.IsEmpty) Then
            clsPipeOperator.AddParameter("title_subtitle", clsRFunctionParameter:=clsTableTitleFunction, iPosition:=1)
            clsPipeOperator.AddParameter("title_font", clsRFunctionParameter:=clsTabStyleFunction, iPosition:=5)
        Else
            clsPipeOperator.RemoveParameterByName("title_subtitle")
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
        If Not bRCodeSet Then
            Exit Sub
        End If
        If ucrChkTitleFootnote.Checked AndAlso Not ucrInputTitleFootnote.IsEmpty Then
            clsTabFootnoteOperator.AddParameter("title_footnote", clsRFunctionParameter:=clsTabFootnoteTitleFunction, iPosition:=1)
        Else
            clsTabFootnoteOperator.RemoveParameterByName("title_footnote")
        End If

        If ucrChkSubtitleFootnote.Checked AndAlso Not ucrInputSubtitleFootnote.IsEmpty Then
            clsTabFootnoteOperator.AddParameter("subtitle_footnote", clsRFunctionParameter:=clsTabFootnoteSubtitleFunction, iPosition:=2)
        Else
            clsTabFootnoteOperator.RemoveParameterByName("subtitle_footnote")
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
            clsStyleListFunction.AddParameter("text_style", clsRFunctionParameter:=clsCellTextFunction, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsStyleListFunction.RemoveParameterByName("text_style")
        End If
    End Sub

    Private Sub ucrChkStyleBoarder_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStyleBoarder.ControlValueChanged
        If ucrChkStyleBoarder.Checked Then
            clsStyleListFunction.AddParameter("border_style", clsRFunctionParameter:=clsCellBorderFunction, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsStyleListFunction.RemoveParameterByName("border_style")
        End If
    End Sub

    Private Sub ucrChkStyleFill_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStyleFill.ControlValueChanged
        If ucrChkStyleFill.Checked Then
            clsStyleListFunction.AddParameter("fill_style", clsRFunctionParameter:=clsCellFillFunction, bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsStyleListFunction.RemoveParameterByName("fill_style")
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
        If Not bRCodeSet Then
            Exit Sub
        End If
        If ucrChkAddFootnote.Checked AndAlso Not ucrInputCellFootnote.IsEmpty Then
            clsPipeOperator.AddParameter("cell_footnote", clsRFunctionParameter:=clsFootnoteCellFunction, iPosition:=3)
        Else
            clsPipeOperator.RemoveParameterByName("cell_footnote")
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