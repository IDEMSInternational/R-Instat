Imports instat.Translations
Public Class sdgFormatSummaryTables
    Private clsTableTitleFunction, clsTabFootnoteTitleFunction, clsTableSourcenoteFunction, clsCellsTitleFunction,
        clsCellTextFunction, clsCellBorderFunction, clsCellFillFunction, clsHeaderFormatFunction, clsFootnoteTitleLocationFunction,
        clsTabOptionsFunction, clsPxFunction, clsFootnoteSubtitleLocationFunction, clsTabFootnoteSubtitleFunction,
        clsStyleListFunction, clsDefaultFunction As New RFunction
    Private clsPipeOperator, clsMutableOperator, clsTempMutableOPerator As New ROperator
    Private bControlsInitialised = False
    Private clsRsyntax As New RSyntax

    Private Sub sdgFormatSummaryTables_load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        bControlsInitialised = False
        'Titles
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)
        ucrInputSubtitle.SetLinkedDisplayControl(lblSubtitle)

        ucrChkTitleFootnote.SetText("Add title footnote")
        ucrChkTitleFootnote.AddToLinkedControls(ucrInputTitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSubtitleFootnote.SetText("Add subtitle footnote")
        ucrChkSubtitleFootnote.AddToLinkedControls(ucrInputSubtitleFootnote, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddTitleSubtitle.SetText("Add title/subtitle")
        ucrChkAddTitleSubtitle.AddToLinkedControls({ucrInputTitle, ucrInputSubtitle, ucrChkTitleFootnote, ucrChkSubtitleFootnote}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddTitleSubtitle.SetLinkedDisplayControl(grpTitleSubtitle)

        ucrChkAddTitleSubtitle.AddParameterPresentCondition(True, "title\subtitle")
        ucrChkAddTitleSubtitle.AddParameterPresentCondition(False, "title\subtitle", False)

        ucrInputFootnoteColumnLocation.SetLinkedDisplayControl(lblColumns)
        ucrInputFootnoteRowLocation.SetLinkedDisplayControl(lblRows)

        ucrChkAddFootnote.SetText("Add footnote")
        ucrChkAddFootnote.SetLinkedDisplayControl(grpLocation)
        ucrChkAddFootnote.AddToLinkedControls({ucrInputFootnoteColumnLocation, ucrInputFootnoteRowLocation}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddSourcenote.SetText("Add sourcenote")
        ucrChkAddSourcenote.AddToLinkedControls(ucrInputAddSourceNote, {True}, bNewLinkedHideIfParameterMissing:=True)

        'Header
        ucrChkAddHeader.SetText("Add Header")
        ucrChkAddHeader.AddToLinkedControls({ucrPnlHeader, ucrChkAddStyles}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeParameterValue:=True)
        'Add conditions for the add header checkbox
        'Add setRcode for the header checkbox

        ucrChkAddStyles.SetText("Add Style")
        ucrChkAddStyles.AddToLinkedControls(ucrChkStyleText, {True}, bNewLinkedHideIfParameterMissing:=True)
        'Add conditions for the add style checkbox
        'Add setRcode for the style checkbox

        ucrChkAddTableFormat.SetText("Add Table format")
        ucrChkAddTableFormat.AddToLinkedControls({ucrInputTableLayout, ucrInputTableAlign, ucrInputTableBackgroundColor, ucrInputTableFontWeight, ucrInputTableFontColor,
                                                  ucrNudTableWidth, ucrNudTableFontSize}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeParameterValue:=True)

        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)
        ucrPnlHeader.AddRadioButton(rdoAllColumns)
        ucrPnlHeader.AddRadioButton(rdoAllRows)
        ucrPnlHeader.SetLinkedDisplayControl(lblHeader)
        ucrPnlHeader.AddParameterValuesCondition(rdoAllColumns, "header", Chr(34) & "all_cols" & Chr(34))
        ucrPnlHeader.AddParameterValuesCondition(rdoAllRows, "header", Chr(34) & "all_rows" & Chr(34))

        ucrChkStyleText.SetText("Add Text style")
        ucrChkStyleText.AddToLinkedControls({ucrInputStyleTextColor, ucrInputStyleTextSize, ucrInputStyleTextAlign,
                                             ucrInputStyleTextValign, ucrInputStyleTextStyle, ucrInputStyleTextWeight, ucrInputStyleTextStretch,
                                             ucrInputStyleTextDecorate, ucrInputStyleTextTransform, ucrInputStyleTextWhitespace, ucrNudStyleTextIndent},
                                          {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)
        ucrChkStyleText.SetLinkedDisplayControl(grpStyle)

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
        ucrInputTableAlign.SetLinkedDisplayControl(lblTableAlign)


        ucrInputTableBackgroundColor.SetParameter(New RParameter("table.background.color", iNewPosition:=1))
        ucrInputTableBackgroundColor.SetRDefault("NULL")
        ucrInputTableBackgroundColor.SetLinkedDisplayControl(lblTableBackgroundColor)

        ucrInputTableFontColor.SetParameter(New RParameter("table.font.color ", 2))
        ucrInputTableFontColor.SetRDefault("NULL")
        ucrInputTableFontColor.SetLinkedDisplayControl(lblTableFontColor)

        ucrInputTableLayout.SetParameter(New RParameter("table.layout", iNewPosition:=3))
        ucrInputTableLayout.SetItems({"fixed", "auto"}, bAddConditions:=True)
        ucrInputTableLayout.SetRDefault("fixed")
        ucrInputTableLayout.SetLinkedDisplayControl(lblTableLayout)

        ucrInputTableFontWeight.SetParameter(New RParameter("table.font.weight", iNewPosition:=4))
        ucrInputTableFontWeight.SetItems({"normal", "bold", "lighter", "bolder"}, bAddConditions:=True)
        ucrInputTableFontWeight.SetRDefault("NULL")
        ucrInputTableFontWeight.SetLinkedDisplayControl(lblTableFontWeight)

        ucrNudTableWidth.SetParameter(New RParameter("table.width", iNewPosition:=0, bNewIncludeArgumentName:=False))

        ucrNudTableFontSize.SetParameter(New RParameter("table.font.size", iNewPosition:=0, bNewIncludeArgumentName:=False))

        ucrChkAddStubHeader.SetText("Add stub header")
        ucrChkAddStubHeader.AddToLinkedControls(ucrInputStubLabel, {True}, bNewLinkedHideIfParameterMissing:=True)
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(bReset As Boolean, clsNewTableTitleFunction As RFunction, clsNewTabFootnoteTitleFunction As RFunction, clsNewRSyntax As RSyntax,
                        clsNewTableSourcenoteFunction As RFunction, clsNewCellsTitleFunction As RFunction, clsNewCellTextFunction As RFunction, clsNewDefaultFunction As RFunction,
                        clsNewCellBorderFunction As RFunction, clsNewCellFillFunction As RFunction, clsNewHeaderFormatFunction As RFunction, clsNewMutableOPerator As ROperator,
                        clsNewTabOptionsFunction As RFunction, clsNewPipeOperator As ROperator, clsNewPxFunction As RFunction, clsNewFootnoteTitleLocationFunction As RFunction,
                        clsNewFootnoteSubtitleLocationFunction As RFunction, clsNewTabFootnoteSubtitleFunction As RFunction, clsNewStyleListFunction As RFunction)
        clsTableTitleFunction = clsNewTableTitleFunction
        clsTabFootnoteTitleFunction = clsNewTabFootnoteTitleFunction
        clsTabFootnoteSubtitleFunction = clsNewTabFootnoteSubtitleFunction
        clsTableSourcenoteFunction = clsNewTableSourcenoteFunction
        clsCellsTitleFunction = clsNewCellsTitleFunction
        clsCellTextFunction = clsNewCellTextFunction
        clsCellBorderFunction = clsNewCellBorderFunction
        clsCellFillFunction = clsNewCellFillFunction
        clsHeaderFormatFunction = clsNewHeaderFormatFunction
        clsTabOptionsFunction = clsNewTabOptionsFunction
        clsPxFunction = clsNewPxFunction
        clsFootnoteSubtitleLocationFunction = clsNewFootnoteSubtitleLocationFunction
        clsFootnoteTitleLocationFunction = clsNewFootnoteTitleLocationFunction
        clsStyleListFunction = clsNewStyleListFunction
        clsPipeOperator = clsNewPipeOperator
        clsMutableOperator = clsNewMutableOPerator
        clsTempMutableOPerator = clsMutableOperator.Clone()
        clsDefaultFunction = clsNewDefaultFunction
        clsRsyntax = clsNewRSyntax

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        ucrChkAddTitleSubtitle.SetRCode(clsPipeOperator, bReset, bCloneIfNeeded:=True)
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
        ucrNudStyleBorderWeight.SetRCode(clsCellBorderFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStyleFillColor.SetRCode(clsCellFillFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableAlign.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableBackgroundColor.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableFontColor.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableLayout.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputTableFontWeight.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableWidth.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudTableFontSize.SetRCode(clsTabOptionsFunction, bReset, bCloneIfNeeded:=True)
        ucrPnlHeader.SetRCode(clsHeaderFormatFunction, bReset, bCloneIfNeeded:=True)
    End Sub

    Private Sub ucrChkAddTitleSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddTitleSubtitle.ControlValueChanged
        If ucrChkAddTitleSubtitle.Checked Then
            clsPipeOperator.AddParameter("title\subtitle", clsRFunctionParameter:=clsTableTitleFunction, iPosition:=1)
        Else
            clsPipeOperator.RemoveParameterByName("title\subtitle")
        End If
    End Sub

    Private Sub ucrInputTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTitle.ControlValueChanged
        If Not ucrInputTitle.IsEmpty Then
            clsTableTitleFunction.AddParameter("title", Chr(34) & ucrInputTitle.GetText() & Chr(34), iPosition:=0)
        Else
            clsTableTitleFunction.RemoveParameterByName("title")
        End If
    End Sub

    Private Sub ucrInputSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSubtitle.ControlValueChanged
        If Not ucrInputTitle.IsEmpty Then
            clsTableTitleFunction.AddParameter("subtitle", Chr(34) & ucrInputSubtitle.GetText() & Chr(34), iPosition:=1)
        Else
            clsTableTitleFunction.RemoveParameterByName("subtitle")
        End If
    End Sub

    Private Sub ucrChkTitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTitleFootnote.ControlValueChanged
        If ucrChkTitleFootnote.Checked Then
            clsPipeOperator.AddParameter("titlefootnote", clsRFunctionParameter:=clsTabFootnoteTitleFunction, iPosition:=1)
            clsTabFootnoteTitleFunction.AddParameter("locations", clsRFunctionParameter:=clsFootnoteTitleLocationFunction, iPosition:=2)
            clsFootnoteTitleLocationFunction.AddParameter("groups", Chr(34) & "title" & Chr(34), iPosition:=0)
        Else
            clsPipeOperator.RemoveParameterByName("titlefootnote")
            clsFootnoteTitleLocationFunction.RemoveParameterByName("groups")
            clsTabFootnoteTitleFunction.RemoveParameterByName("locations")
        End If
    End Sub

    Private Sub ucrChkSubtitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSubtitleFootnote.ControlValueChanged
        If ucrChkSubtitleFootnote.Checked Then
            clsPipeOperator.AddParameter("subtitlefootnote", clsRFunctionParameter:=clsTabFootnoteSubtitleFunction, iPosition:=2)
            clsTabFootnoteSubtitleFunction.AddParameter("locations", clsRFunctionParameter:=clsFootnoteSubtitleLocationFunction, iPosition:=2)
            clsFootnoteSubtitleLocationFunction.AddParameter("groups", Chr(34) & "subtitle" & Chr(34), iPosition:=0)
        Else
            clsPipeOperator.RemoveParameterByName("subtitlefootnote")
            clsFootnoteSubtitleLocationFunction.RemoveParameterByName("groups")
            clsTabFootnoteSubtitleFunction.RemoveParameterByName("locations")
        End If
    End Sub

    Private Sub ucrInputTitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTitleFootnote.ControlValueChanged
        If Not ucrInputTitleFootnote.IsEmpty Then
            clsFootnoteTitleLocationFunction.AddParameter("footnote", ucrInputTitleFootnote.GetText, iPosition:=1)
        Else
            clsFootnoteTitleLocationFunction.RemoveParameterByName("footnote")
        End If
    End Sub

    Private Sub ucrInputSubtitleFootnote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSubtitleFootnote.ControlValueChanged
        If Not ucrInputSubtitleFootnote.IsEmpty Then
            clsFootnoteSubtitleLocationFunction.AddParameter("footnote", ucrInputSubtitleFootnote.GetText, iPosition:=1)
        Else
            clsFootnoteSubtitleLocationFunction.RemoveParameterByName("footnote")
        End If
    End Sub

    Private Sub ucrInputAddSourceNote_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputAddSourceNote.ControlValueChanged
        If Not ucrInputAddSourceNote.IsEmpty Then
            clsTableSourcenoteFunction.AddParameter("sourcenote", ucrInputAddSourceNote.GetText(), iPosition:=0)
        End If
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
            'add header
        Else
            'remove header
        End If
    End Sub

    Private Sub ucrChkAddStyles_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddStyles.ControlValueChanged
        If ucrChkAddStyles.Checked Then
            clsHeaderFormatFunction.AddParameter("list", clsRFunctionParameter:=clsStyleListFunction, iPosition:=1)
        Else
            clsHeaderFormatFunction.RemoveParameterByName("list")
        End If
    End Sub

    Private Sub PipeOperator_controlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkAddTitleSubtitle.ControlContentsChanged,
            ucrChkAddFootnote.ControlContentsChanged, ucrChkAddSourcenote.ControlContentsChanged, ucrChkAddHeader.ControlContentsChanged,
            ucrChkAddTableFormat.ControlContentsChanged
        clsRsyntax.lstBeforeCodes.Clear()
        clsRsyntax.AddToBeforeCodes(clsDefaultFunction, iPosition:=0)
        If ucrChkAddTitleSubtitle.Checked OrElse ucrChkAddFootnote.Checked OrElse ucrChkAddSourcenote.Checked OrElse ucrChkAddHeader.Checked OrElse ucrChkAddTableFormat.Checked Then
            clsTempMutableOPerator.RemoveAssignTo()
            clsTempMutableOPerator.SetAssignTo("mmtable_table")
            clsRsyntax.AddToBeforeCodes(clsTempMutableOPerator, iPosition:=1)
            clsPipeOperator.AddParameter("table", "mmtable_table", iPosition:=0)
            clsRsyntax.SetBaseROperator(clsPipeOperator)
        Else
            clsRsyntax.RemoveFromBeforeCodes(clsTempMutableOPerator)
            clsRsyntax.SetBaseROperator(clsMutableOperator)
        End If
    End Sub

End Class