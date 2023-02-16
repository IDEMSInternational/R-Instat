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
Public Class dlgUseTable
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRFunctionAsHTML, clsRFunctionAsRTF, clsRFunctionAsWord, clsRFunctionAsLaTex As New RFunction

    Private clsTableTitleFunction, clsTabFootnoteTitleFunction, clsTableSourcenoteFunction, clsDummyFunction,
                                        clsCellTextFunction, clsCellBorderFunction, clsCellFillFunction, clsHeaderFormatFunction,
                                        clsTabOptionsFunction, clsFootnoteCellFunction, clsStubHeadFunction, clsSecondFootnoteCellBodyFunction,
                                       clsBorderWeightPxFunction, clsFootnoteTitleLocationFunction, clsFootnoteCellBodyFunction,
                                       clsFootnoteSubtitleLocationFunction, clsTabFootnoteSubtitleFunction,
                                       clsStyleListFunction, clsSecondFootnoteCellFunction, clsTabStyleCellTitleFunction,
                                       clsTabStyleCellTextFunction, clsTabStyleFunction, clsTabStylePxFunction As New RFunction

    Private clsPipeOperator, clsTabFootnoteOperator, clsSummaryOperator, clsJoiningPipeOperator As ROperator

    Private Sub dlgUseTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrTablesReceiver.SetParameter(New RParameter("data", 0))
        ucrTablesReceiver.Selector = ucrTablesSelector
        ucrTablesReceiver.SetParameterIsRFunction()
        ucrTablesReceiver.SetMeAsReceiver()
        ucrTablesReceiver.strSelectorHeading = "Tables"
        ucrTablesReceiver.SetItemType(RObjectTypeLabel.Table)

        ucrPnlExportOptions.AddRadioButton(rdoAsHTML)
        ucrPnlExportOptions.AddRadioButton(rdoAsRTF)
        ucrPnlExportOptions.AddRadioButton(rdoAsWord)
        ucrPnlExportOptions.AddRadioButton(rdoAsLaTex)
        ucrPnlExportOptions.AddFunctionNamesCondition(rdoAsHTML, "as_raw_html")
        ucrPnlExportOptions.AddFunctionNamesCondition(rdoAsRTF, "as_rtf")
        ucrPnlExportOptions.AddFunctionNamesCondition(rdoAsWord, "as_word")
        ucrPnlExportOptions.AddFunctionNamesCondition(rdoAsLaTex, "as_word")

        ucrSaveTable.SetPrefix("use_table")
        ucrSaveTable.SetSaveType(strRObjectType:=RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSaveTable.SetDataFrameSelector(ucrTablesSelector.ucrAvailableDataFrames)
        ucrSaveTable.SetCheckBoxText("Save New Table")
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
    End Sub

    Private Sub SetDefaults()
        clsRFunctionAsHTML = New RFunction
        clsRFunctionAsRTF = New RFunction
        clsRFunctionAsWord = New RFunction
        clsRFunctionAsLaTex = New RFunction
        clsPipeOperator = New ROperator

        clsTableTitleFunction = New RFunction
        clsTabFootnoteTitleFunction = New RFunction
        clsTableSourcenoteFunction = New RFunction
        clsDummyFunction = New RFunction
        clsCellTextFunction = New RFunction
        clsCellBorderFunction = New RFunction
        clsCellFillFunction = New RFunction
        clsHeaderFormatFunction = New RFunction
        clsTabOptionsFunction = New RFunction
        clsFootnoteCellFunction = New RFunction
        clsStubHeadFunction = New RFunction
        clsSecondFootnoteCellBodyFunction = New RFunction
        clsBorderWeightPxFunction = New RFunction
        clsFootnoteTitleLocationFunction = New RFunction
        clsFootnoteCellBodyFunction = New RFunction
        clsFootnoteSubtitleLocationFunction = New RFunction
        clsTabFootnoteSubtitleFunction = New RFunction
        clsStyleListFunction = New RFunction
        clsSecondFootnoteCellFunction = New RFunction
        clsTabStyleCellTextFunction = New RFunction
        clsTabStyleFunction = New RFunction
        clsTabStylePxFunction = New RFunction
        clsTabStyleCellTitleFunction = New RFunction
        clsTabFootnoteOperator = New ROperator
        clsSummaryOperator = New ROperator
        clsJoiningPipeOperator = New ROperator

        rdoAsHTML.Checked = True

        clsTabFootnoteOperator.SetOperation("%>%")
        clsTabFootnoteOperator.bBrackets = False

        clsJoiningPipeOperator.SetOperation("%>%")

        clsSummaryOperator.SetOperation("+")

        clsStubHeadFunction.SetPackageName("gt")
        clsStubHeadFunction.SetRCommand("tab_stubhead")

        clsTabStyleFunction.SetRCommand("tab_style")
        clsTabStyleFunction.SetPackageName("gt")
        clsTabStyleFunction.AddParameter("style", clsRFunctionParameter:=clsTabStyleCellTextFunction, iPosition:=0)
        clsTabStyleFunction.AddParameter("location", clsRFunctionParameter:=clsTabStyleCellTitleFunction, iPosition:=1)

        clsTabStyleCellTitleFunction.SetPackageName("gt")
        clsTabStyleCellTitleFunction.SetRCommand("cells_title")
        clsTabStyleCellTitleFunction.AddParameter("groups", Chr(34) & "title" & Chr(34), iPosition:=0)

        clsTabStyleCellTextFunction.SetPackageName("gt")
        clsTabStyleCellTextFunction.SetRCommand("cell_text")
        clsTabStyleCellTextFunction.AddParameter("size", clsRFunctionParameter:=clsTabStylePxFunction, iPosition:=0)

        clsTabStylePxFunction.SetPackageName("gt")
        clsTabStylePxFunction.SetRCommand("px")
        clsTabStylePxFunction.AddParameter("size", "18", bIncludeArgumentName:=False, iPosition:=0)

        clsTableTitleFunction.SetPackageName("gt")
        clsTableTitleFunction.SetRCommand("tab_header")

        clsTabFootnoteTitleFunction.SetPackageName("gt")
        clsTabFootnoteTitleFunction.SetRCommand("tab_footnote")

        clsTabFootnoteSubtitleFunction.SetPackageName("gt")
        clsTabFootnoteSubtitleFunction.SetRCommand("tab_footnote")

        clsFootnoteCellFunction.SetPackageName("gt")
        clsFootnoteCellFunction.SetRCommand("tab_footnote")

        clsSecondFootnoteCellFunction.SetPackageName("gt")
        clsSecondFootnoteCellFunction.SetRCommand("tab_footnote")

        clsFootnoteTitleLocationFunction.SetPackageName("gt")
        clsFootnoteTitleLocationFunction.SetRCommand("cells_title")

        clsFootnoteSubtitleLocationFunction.SetPackageName("gt")
        clsFootnoteSubtitleLocationFunction.SetRCommand("cells_title")

        clsTableSourcenoteFunction.SetPackageName("gt")
        clsTableSourcenoteFunction.SetRCommand("tab_source_note")

        clsFootnoteCellBodyFunction.SetPackageName("gt")
        clsFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsSecondFootnoteCellBodyFunction.SetPackageName("gt")
        clsSecondFootnoteCellBodyFunction.SetRCommand("cells_body")

        clsCellTextFunction.SetPackageName("gt")
        clsCellTextFunction.SetRCommand("cell_text")

        clsCellBorderFunction.SetPackageName("gt")
        clsCellBorderFunction.SetRCommand("cell_borders")
        clsCellBorderFunction.AddParameter("weight", clsRFunctionParameter:=clsBorderWeightPxFunction, iPosition:=3)

        clsCellFillFunction.SetPackageName("gt")
        clsCellFillFunction.SetRCommand("cell_fill")

        clsHeaderFormatFunction.SetPackageName("mmtable2")
        clsHeaderFormatFunction.SetRCommand("header_format")
        clsHeaderFormatFunction.AddParameter("header", Chr(34) & "all_cols" & Chr(34), iPosition:=0)
        clsHeaderFormatFunction.AddParameter("style", clsRFunctionParameter:=clsStyleListFunction, iPosition:=1)

        clsTabOptionsFunction.SetPackageName("gt")
        clsTabOptionsFunction.SetRCommand("tab_options")

        clsBorderWeightPxFunction.SetPackageName("gt")
        clsBorderWeightPxFunction.SetRCommand("px")
        clsBorderWeightPxFunction.AddParameter("weight", "1", iPosition:=0, bIncludeArgumentName:=False)

        clsStyleListFunction.SetRCommand("list")

        clsRFunctionAsHTML.SetPackageName("gt")
        clsRFunctionAsHTML.SetRCommand("as_raw_html")

        clsRFunctionAsRTF.SetPackageName("gt")
        clsRFunctionAsRTF.SetRCommand("as_rtf")

        clsRFunctionAsWord.SetPackageName("gt")
        clsRFunctionAsWord.SetRCommand("as_word")

        clsRFunctionAsLaTex.SetPackageName("gt")
        clsRFunctionAsLaTex.SetRCommand("as_word")

        clsPipeOperator.SetOperation("%>%")

        ucrBase.clsRsyntax.SetBaseROperator(clsJoiningPipeOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrTablesReceiver.SetRCode(clsJoiningPipeOperator, bReset)
        'ucrSaveTable.SetRCode(clsJoiningPipeOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrTablesReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdFormatOptions_Click(sender As Object, e As EventArgs) Handles cmdFormatOptions.Click
        sdgFormatSummaryTables.SetRCode(clsNewTableTitleFunction:=clsTableTitleFunction, clsNewTabFootnoteTitleFunction:=clsTabFootnoteTitleFunction, clsNewTableSourcenoteFunction:=clsTableSourcenoteFunction, clsNewDummyFunction:=clsDummyFunction,
                                        clsNewCellTextFunction:=clsCellTextFunction, clsNewCellBorderFunction:=clsCellBorderFunction, clsNewCellFillFunction:=clsCellFillFunction, clsNewHeaderFormatFunction:=clsHeaderFormatFunction,
                                        clsNewTabOptionsFunction:=clsTabOptionsFunction, clsNewFootnoteCellFunction:=clsFootnoteCellFunction, clsNewStubHeadFunction:=clsStubHeadFunction, clsNewSecondFootnoteCellBodyFunction:=clsSecondFootnoteCellBodyFunction,
                                       clsNewPipeOperator:=clsPipeOperator, clsNewBorderWeightPxFunction:=clsBorderWeightPxFunction, clsNewFootnoteTitleLocationFunction:=clsFootnoteTitleLocationFunction, clsNewFootnoteCellBodyFunction:=clsFootnoteCellBodyFunction,
                                       clsNewFootnoteSubtitleLocationFunction:=clsFootnoteSubtitleLocationFunction, clsNewTabFootnoteSubtitleFunction:=clsTabFootnoteSubtitleFunction, clsNewJoiningOperator:=clsJoiningPipeOperator,
                                       clsNewStyleListFunction:=clsStyleListFunction, clsNewMutableOPerator:=clsSummaryOperator, clsNewSecondFootnoteCellFunction:=clsSecondFootnoteCellFunction, clsNewTabFootnoteOperator:=clsTabFootnoteOperator,
                                       clsNewTabStyleCellTextFunction:=clsTabStyleCellTextFunction, clsNewTabStyleFunction:=clsTabStyleFunction, clsNewTabStylePxFunction:=clsTabStylePxFunction, bReset:=bReset)
        sdgFormatSummaryTables.ShowDialog()
    End Sub
    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTablesReceiver.ControlContentsChanged, ucrSaveTable.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlExportOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExportOptions.ControlValueChanged
        If rdoAsHTML.Checked Then
            clsJoiningPipeOperator.AddParameter("y", clsRFunctionParameter:=clsRFunctionAsHTML)
        ElseIf rdoAsRTF.Checked Then
            clsJoiningPipeOperator.AddParameter("y", clsRFunctionParameter:=clsRFunctionAsRTF)
        ElseIf rdoAsWord.Checked Then
            clsJoiningPipeOperator.AddParameter("y", clsRFunctionParameter:=clsRFunctionAsWord)
        Else
            clsJoiningPipeOperator.AddParameter("y", clsRFunctionParameter:=clsRFunctionAsLaTex)
        End If
    End Sub
End Class