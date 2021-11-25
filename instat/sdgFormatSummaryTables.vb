Imports instat.Translations
Public Class sdgFormatSummaryTables
    Private clsTableTitleFunction, clsTabFootnoteFunction, clsTableSourcenoteFunction, clsCellsTitleFunction,
        clsCellTextFunction, clsCellBorderFunction, clsCellFillFunction, clsHeaderFormatFunction,
        clsTabOptionsFunction, clsPxFunction As New RFunction

    Private Sub sdgFormatSummaryTables_load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        'Titles
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)
        ucrInputSubtitle.SetLinkedDisplayControl(lblSubtitle)

        ucrChkTitleFootnote.SetText("Add title footnote")
        ucrChkTitleFootnote.AddToLinkedControls(ucrInputTitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSubtitleFootnote.SetText("Add subtitle footnote")
        ucrChkSubtitleFootnote.AddToLinkedControls(ucrInputSubtitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddTitleSubtitle.SetText("Add title/subtitle")
        ucrChkAddTitleSubtitle.AddToLinkedControls({ucrInputTitle, ucrInputSubtitle, ucrChkTitleFootnote, ucrChkSubtitleFootnote}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddTitleSubtitle.SetLinkedDisplayControl(grpTitleSubtitle)

        ucrInputFootnoteColumnLocation.SetLinkedDisplayControl(lblColumns)
        ucrInputFootnoteRowLocation.SetLinkedDisplayControl(lblRows)

        ucrChkAddFootnote.SetText("Add footnote")
        ucrChkAddFootnote.SetLinkedDisplayControl(grpLocation)
        ucrChkAddFootnote.AddToLinkedControls({ucrInputFootnoteColumnLocation, ucrInputFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddSourcenote.SetText("Add sourcenote")
        ucrChkAddSourcenote.AddToLinkedControls(ucrInputAddSourceNote, {True}, bNewLinkedHideIfParameterMissing:=True)

        'Header
        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)
        ucrPnlHeader.AddRadioButton(rdoAllColumns)
        ucrPnlHeader.AddRadioButton(rdoAllRows)

        ucrChkStyleText.SetText("Add Text style")
        ucrChkStyleText.AddToLinkedControls({ucrInputStyleTextColor, ucrInputStyleTextSize, ucrInputStyleTextAlign,
                                             ucrInputStyleTextValign, ucrInputStyleTextStyle, ucrInputStyleTextWeight, ucrInputStyleTextStretch,
                                             ucrInputStyleTextDecorate, ucrInputStyleTextTransform, ucrInputStyleTextWhitespace, ucrNudStyleTextIndent},
                                          {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)


        ucrInputStyleTextColor.SetParameter(New RParameter("color", iNewPosition:=0))
        ucrInputStyleTextColor.SetRDefault("NULL")
        ucrInputStyleTextColor.SetLinkedDisplayControl(lblStyleTextColor)

        ucrInputStyleTextFont.SetLinkedDisplayControl(lblStyleTextFont)

        ucrInputStyleTextSize.SetParameter(New RParameter("size", iNewPosition:=2))
        ucrInputStyleTextSize.SetRDefault("NULL")
        ucrInputStyleTextSize.SetLinkedDisplayControl(lblStyleTextSize)

        ucrInputStyleTextAlign.SetParameter(New RParameter("align", iNewPosition:=3))
        ucrInputStyleTextAlign.SetRDefault("NULL")
        ucrInputStyleTextAlign.SetLinkedDisplayControl(lblStyleTextAlign)

        ucrInputStyleTextValign.SetParameter(New RParameter("v_align", iNewPosition:=4))
        ucrInputStyleTextValign.SetRDefault("NULL")
        ucrInputStyleTextValign.SetLinkedDisplayControl(lblStyleTextVAlign)

        ucrInputStyleTextStyle.SetParameter(New RParameter("style", iNewPosition:=5))
        ucrInputStyleTextStyle.SetRDefault("NULL")
        ucrInputStyleTextStyle.SetLinkedDisplayControl(lblStyleTextStyle)

        ucrInputStyleTextWeight.SetParameter(New RParameter("weight", iNewPosition:=6))
        ucrInputStyleTextWeight.SetRDefault("NULL")
        ucrInputStyleTextWeight.SetLinkedDisplayControl(lblStyleTextWeight)

        ucrInputStyleTextStretch.SetParameter(New RParameter("stretch", iNewPosition:=7))
        ucrInputStyleTextStretch.SetRDefault("NULL")
        ucrInputStyleTextStretch.SetLinkedDisplayControl(lblStyleTextStretch)

        ucrInputStyleTextDecorate.SetParameter(New RParameter("decorate", iNewPosition:=8))
        ucrInputStyleTextDecorate.SetRDefault("NULL")
        ucrInputStyleTextDecorate.SetLinkedDisplayControl(lblStyleTextStretch)

        ucrInputStyleTextTransform.SetParameter(New RParameter("transform", iNewPosition:=9))
        ucrInputStyleTextTransform.SetRDefault("NULL")
        ucrInputStyleTextTransform.SetLinkedDisplayControl(lblStyleTextTransform)

        ucrInputStyleTextWhitespace.SetParameter(New RParameter("whitespace", iNewPosition:=10))
        ucrInputStyleTextWhitespace.SetRDefault("NULL")
        ucrInputStyleTextWhitespace.SetLinkedDisplayControl(lblStyleTextWhitespace)

        ucrNudStyleTextIndent.SetParameter(New RParameter("indent", iNewPosition:=11))
        ucrNudStyleTextIndent.SetRDefault("NULL")
        ucrNudStyleTextIndent.SetLinkedDisplayControl(lblStyleTextIndent)
        ucrNudStyleTextIndent.Increment = 1

        ucrChkStyleBoarder.SetText("Add style border")
        ucrChkStyleBoarder.AddToLinkedControls({ucrInputStyleBorderSides, ucrInputStyleBorderColor, ucrInputStyleBorderStyle, ucrNudStyleBorderWeight}, {True},
                                               bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)

        ucrInputStyleBorderSides.SetParameter(New RParameter("sides", iNewPosition:=0))
        ucrInputStyleBorderSides.SetRDefault("all")
        ucrInputStyleBorderSides.SetLinkedDisplayControl(lblBorderSides)

        ucrInputStyleBorderColor.SetParameter(New RParameter("color", iNewPosition:=1))
        ucrInputStyleBorderColor.SetRDefault("#000000")
        ucrInputStyleBorderColor.SetLinkedDisplayControl(lblBorderColor)

        ucrInputStyleBorderStyle.SetParameter(New RParameter("style", iNewPosition:=2))
        ucrInputStyleBorderStyle.SetRDefault("solid")
        ucrInputStyleBorderStyle.SetLinkedDisplayControl(lblBorderStyle)

        ucrNudStyleBorderWeight.SetParameter(New RParameter("weight", iNewPosition:=3))
        ucrNudStyleBorderWeight.SetRDefault("1")
        ucrNudStyleBorderWeight.SetLinkedDisplayControl(lblBorderWeight)
        ucrNudStyleBorderWeight.Increment = 1

        ucrChkStyleFill.SetText("Add fill style")
        ucrChkStyleFill.AddToLinkedControls({ucrNudStyleFillAlpha, ucrInputStyleFillColor}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)

        ucrNudStyleFillAlpha.Increment = 0.1
        ucrNudStyleFillAlpha.SetMinMax(0.0, 1.0)
        ucrNudStyleFillAlpha.SetParameter(New RParameter("alpha", iNewPosition:=1))
        ucrNudStyleFillAlpha.SetRDefault("NULL")
        ucrNudStyleFillAlpha.SetLinkedDisplayControl(lblStyleFillAlpha)

        ucrInputStyleFillColor.SetParameter(New RParameter("color", iNewPosition:=0))
        ucrInputStyleFillColor.SetRDefault("#D3D3D3")
        ucrInputStyleFillColor.SetLinkedDisplayControl(lblStyleFillColor)

        'Table
        ucrInputTableAlign.SetParameter(New RParameter("table.layout", iNewPosition:=0))
        ucrInputTableAlign.SetItems({"left", "right", "NULL"}, bAddConditions:=True)
        ucrInputTableAlign.SetRDefault("NULL")


        ucrInputTableBackgroundColor.SetParameter(New RParameter("table.background.color", iNewPosition:=1))
        ucrInputTableBackgroundColor.SetRDefault("NULL")

        ucrInputTableFontColor.SetParameter(New RParameter("table.font.color ", 2))
        ucrInputTableFontColor.SetRDefault("NULL")

        ucrInputTableLayout.SetParameter(New RParameter("table.layout", iNewPosition:=3))
        ucrInputTableLayout.SetItems({"fixed", "auto"}, bAddConditions:=True)
        ucrInputTableLayout.SetRDefault("fixed")

        ucrInputTableFontWeight.SetParameter(New RParameter("table.font.weight", iNewPosition:=4))
        ucrInputTableFontWeight.SetItems({"normal", "bold", "lighter", "bolder"}, bAddConditions:=True)
        ucrInputTableFontWeight.SetRDefault("NULL")

        ucrNudTableWidth.SetParameter(New RParameter("table.width", iNewPosition:=0, bNewIncludeArgumentName:=False))

        ucrNudTableFontSize.SetParameter(New RParameter("table.font.size", iNewPosition:=0, bNewIncludeArgumentName:=False))

        ucrChkAddStubHeader.SetText("Add stub header")
        ucrChkAddStubHeader.AddToLinkedControls(ucrInputStubLabel, {True}, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Public Sub SetRCode()

    End Sub

End Class