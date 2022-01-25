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
Public Class dlgStringHandling
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsCountFunction, clsExtractFunction, clsDetectFunction, clsLocateFunction, clsReplaceFunction, clsReplaceAllFunction,
            clsFixedFunction, clsRegexFunction, clsStringCollFunction, clsBoundaryFunction, clsRemoveFunction, clsReplaceNaFunction,
            clsStartsFunction, clsEndsFunction, clsMatchAllFunction, clsExtractAllFunction, clsLocateAllFunction, clsRemoveAllFunction As New RFunction
    Private clsDummyFunction, clsDetectDummyFunction, clsFindDummyFunction, clsAllDummyFunction, clsReplaceAllDummyFunction, clsRemoveAllDummyFunction As New RFunction

    Private Sub dlgStringHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctBoundaryPairs As New Dictionary(Of String, String)
        ucrBase.iHelpTopicID = 406

        ucrReceiverStringHandling.SetParameter(New RParameter("string", 0))
        ucrReceiverStringHandling.SetParameterIsRFunction()
        ucrReceiverStringHandling.Selector = ucrSelectorStringHandling
        ucrReceiverStringHandling.bUseFilteredData = False
        ucrReceiverStringHandling.SetMeAsReceiver()

        ucrPnlStringHandling.AddRadioButton(rdoDetect)
        ucrPnlStringHandling.AddRadioButton(rdoReplace)
        ucrPnlStringHandling.AddRadioButton(rdoFind)
        ucrPnlStringHandling.AddRadioButton(rdoReplaceNa)
        ucrPnlStringHandling.AddRadioButton(rdoRemove)

        ucrPnlStringHandling.AddFunctionNamesCondition(rdoDetect, {"str_detect", "str_starts", "str_ends"})
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplace, {"str_replace", "str_replace_all"})
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoFind, {"str_find", "str_count", "str_extract", "str_extract_all", "str_locate", "str_locate_all"})
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplaceNa, "str_replace_na")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoRemove, {"str_remove", "str_remove_all"})

        ucrPnlDetectOptions.AddRadioButton(rdoDetects)
        ucrPnlDetectOptions.AddRadioButton(rdoStarts)
        ucrPnlDetectOptions.AddRadioButton(rdoEnds)

        ucrPnlDetectOptions.AddParameterValuesCondition(rdoDetects, "checked", "str_detect")
        ucrPnlDetectOptions.AddParameterValuesCondition(rdoStarts, "checked", "str_starts")
        ucrPnlDetectOptions.AddParameterValuesCondition(rdoEnds, "checked", "str_ends")

        ucrPnlFindOptions.AddRadioButton(rdoCount)
        ucrPnlFindOptions.AddRadioButton(rdoExtract)
        ucrPnlFindOptions.AddRadioButton(rdoLocate)

        ucrPnlFindOptions.AddParameterValuesCondition(rdoCount, "checked", "str_count")
        ucrPnlFindOptions.AddParameterValuesCondition(rdoExtract, "checked", "str_extract")
        ucrPnlFindOptions.AddParameterValuesCondition(rdoLocate, "checked", "str_locate")

        ucrChkAll.SetText("All")
        ucrChkAll.SetParameter(New RParameter("checked", 0))
        ucrChkAll.SetValuesCheckedAndUnchecked(True, False)

        ucrChkReplaceAll.SetText("Replace All")
        ucrChkReplaceAll.SetParameter(New RParameter("checked", 0))
        ucrChkReplaceAll.SetValuesCheckedAndUnchecked(True, False)

        ucrChkRemoveAll.SetText("Remove All")
        ucrChkRemoveAll.SetParameter(New RParameter("checked", 0))
        ucrChkRemoveAll.SetValuesCheckedAndUnchecked(True, False)

        ucrChkNegate.SetText("Negate")
        ucrChkNegate.SetParameter(New RParameter("negate", 2))
        ucrChkNegate.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputReplaceBy.SetParameter(New RParameter("replacement", 2))

        ucrChkReplaceBy.SetText("Replace By:")
        ucrChkReplaceBy.SetParameter(New RParameter("replacement", 1), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrInputReplaceNaBy.SetParameter(New RParameter("replacement", 1))

        ucrSaveStringHandling.SetPrefix("count")
        ucrSaveStringHandling.SetSaveTypeAsColumn()
        ucrSaveStringHandling.SetDataFrameSelector(ucrSelectorStringHandling.ucrAvailableDataFrames)
        ucrSaveStringHandling.SetIsComboBox()
        ucrSaveStringHandling.SetLabelText("New Column:")
        ucrSaveStringHandling.setLinkedReceiver(ucrReceiverStringHandling) 'added

        ucrChkIgnoreCase.SetText("Ignore Case")
        ucrChkIgnoreCase.SetParameter(New RParameter("ignore_case", 3))
        ucrChkIgnoreCase.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputBoundary.SetParameter(New RParameter("type", 0))
        dctBoundaryPairs.Add("character", Chr(34) & "character" & Chr(34))
        dctBoundaryPairs.Add("line_break", Chr(34) & "line_break" & Chr(34))
        dctBoundaryPairs.Add("sentence", Chr(34) & "sentence" & Chr(34))
        dctBoundaryPairs.Add("word", Chr(34) & "word" & Chr(34))
        'ucrInputBoundary.SetItems(dctBoundaryPairs)
        'ucrInputBoundary.SetDropDownStyleAsNonEditable()
        ucrInputBoundary.Visible = False

        ucrChkBoundary.SetText("Boundary")
        ucrChkBoundary.SetParameter(New RParameter("checked", 0))
        ucrChkBoundary.SetValuesCheckedAndUnchecked(True, False)
        ucrChkBoundary.Enabled = False

        ucrChkIncludeRegularExpressions.SetText("Include Regular Expressions")

        ucrChkIncludeRegularExpressions.SetParameter(New RParameter("checked", 0))
        ucrChkIncludeRegularExpressions.SetValuesCheckedAndUnchecked(True, False)

        ucrChkMultiline.SetText("Multiline")
        ucrChkMultiline.SetParameter(New RParameter("multiline", 4))
        ucrChkMultiline.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkComments.SetText("Comments")
        ucrChkComments.SetParameter(New RParameter("comments", 5))
        ucrChkComments.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkReplaceBy.AddToLinkedControls(ucrInputReplaceNaBy, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="NA")
        ucrPnlStringHandling.AddToLinkedControls({ucrInputReplaceBy, ucrChkReplaceAll}, {rdoReplace}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls({ucrInputPattern, ucrChkIgnoreCase, ucrChkIncludeRegularExpressions}, {rdoDetect, rdoFind, rdoReplace, rdoRemove}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrChkBoundary, {rdoDetect, rdoFind}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrPnlDetectOptions, {rdoDetect}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrPnlFindOptions, {rdoFind}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrChkReplaceBy, {rdoReplaceNa}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrChkRemoveAll, {rdoRemove}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFindOptions.AddToLinkedControls(ucrChkAll, {rdoExtract, rdoLocate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFindOptions.SetLinkedDisplayControl(grpFindOptions)
        ucrPnlDetectOptions.SetLinkedDisplayControl(grpDetectOptions)
        ucrInputReplaceBy.SetLinkedDisplayControl(lblReplaceBy)
        ucrInputPattern.SetLinkedDisplayControl(lblPattern)
        ucrChkBoundary.AddToLinkedControls(ucrInputBoundary, {True}, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsCountFunction = New RFunction
        clsExtractFunction = New RFunction
        clsDetectFunction = New RFunction
        clsLocateFunction = New RFunction
        clsReplaceFunction = New RFunction
        clsReplaceAllFunction = New RFunction
        clsFixedFunction = New RFunction
        clsRegexFunction = New RFunction
        clsStringCollFunction = New RFunction
        clsBoundaryFunction = New RFunction
        clsDummyFunction = New RFunction
        clsDetectDummyFunction = New RFunction
        clsRemoveFunction = New RFunction
        clsStartsFunction = New RFunction
        clsEndsFunction = New RFunction
        clsReplaceNaFunction = New RFunction
        clsFindDummyFunction = New RFunction
        clsMatchAllFunction = New RFunction
        clsExtractAllFunction = New RFunction
        clsLocateAllFunction = New RFunction
        clsRemoveAllFunction = New RFunction
        clsAllDummyFunction = New RFunction
        clsReplaceAllDummyFunction = New RFunction
        clsRemoveAllDummyFunction = New RFunction

        ucrSelectorStringHandling.Reset()

        ucrInputReplaceBy.Reset()
        ucrSaveStringHandling.Reset()
        ucrInputReplaceBy.SetName("")
        ucrInputPattern.SetName("")

        clsDummyFunction.AddParameter("checked", False, iPosition:=0)
        clsAllDummyFunction.AddParameter("checked", False, iPosition:=0)
        clsReplaceAllDummyFunction.AddParameter("checked", False, iPosition:=0)
        clsRemoveAllDummyFunction.AddParameter("checked", False, iPosition:=0)
        clsDetectDummyFunction.AddParameter("checked", "str_detect", iPosition:=0)
        clsFindDummyFunction.AddParameter("checked", "str_count", iPosition:=0)

        clsBoundaryFunction.SetPackageName("stringr")
        clsBoundaryFunction.SetRCommand("boundary")
        clsBoundaryFunction.AddParameter("type", Chr(34) & "character" & Chr(34), iPosition:=0)

        clsFixedFunction.SetPackageName("stringr")
        clsFixedFunction.SetRCommand("fixed")
        clsFixedFunction.AddParameter("ignore_case", "FALSE")

        clsRegexFunction.SetPackageName("stringr")
        clsRegexFunction.SetRCommand("regex")
        clsRegexFunction.AddParameter("ignore_case", "FALSE", bIncludeArgumentName:=False, iPosition:=3)
        clsRegexFunction.AddParameter("multiline", "FALSE", iPosition:=4)
        clsRegexFunction.AddParameter("comments", "FALSE", iPosition:=5)

        clsStringCollFunction.SetPackageName("stringr")
        clsStringCollFunction.SetRCommand("coll")
        clsStringCollFunction.AddParameter("ignore_case", "FALSE", bIncludeArgumentName:=False, iPosition:=3)

        clsStartsFunction.SetPackageName("stringr")
        clsStartsFunction.SetRCommand("str_starts")
        clsStartsFunction.AddParameter("negate", "FALSE", iPosition:=2)

        clsEndsFunction.SetPackageName("stringr")
        clsEndsFunction.SetRCommand("str_ends")
        clsEndsFunction.AddParameter("negate", "FALSE", iPosition:=2)

        clsCountFunction.SetPackageName("stringr")
        clsCountFunction.SetRCommand("str_count")
        clsExtractFunction.SetPackageName("stringr")
        clsExtractFunction.SetRCommand("str_extract")
        clsExtractAllFunction.SetPackageName("stringr")
        clsExtractAllFunction.SetRCommand("str_extract_all")
        clsMatchAllFunction.SetPackageName("stringr")
        clsMatchAllFunction.SetRCommand("str_match_all")
        clsDetectFunction.SetPackageName("stringr")
        clsDetectFunction.SetRCommand("str_detect")
        clsLocateFunction.SetPackageName("stringr")
        clsLocateFunction.SetRCommand("str_locate")
        clsLocateAllFunction.SetPackageName("stringr")
        clsLocateAllFunction.SetRCommand("str_locate_all")
        clsReplaceFunction.SetPackageName("stringr")
        clsReplaceFunction.SetRCommand("str_replace")
        clsReplaceAllFunction.SetPackageName("stringr")
        clsReplaceAllFunction.SetRCommand("str_replace_all")
        clsReplaceNaFunction.SetPackageName("stringr")
        clsReplaceNaFunction.SetRCommand("str_replace_na")
        clsRemoveFunction.SetPackageName("stringr")
        clsRemoveFunction.SetRCommand("str_remove")
        clsRemoveAllFunction.SetPackageName("stringr")
        clsRemoveAllFunction.SetRCommand("str_remove_all")

        clsDetectFunction.SetAssignTo(ucrSaveStringHandling.GetText, strTempDataframe:=ucrSelectorStringHandling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveStringHandling.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
        NewColumnName()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlStringHandling.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsCountFunction, New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsExtractFunction, New RParameter("string", 0), iAdditionalPairNo:=2)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsLocateFunction, New RParameter("string", 0), iAdditionalPairNo:=3)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("string", 0), iAdditionalPairNo:=4)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceAllFunction, New RParameter("string", 0), iAdditionalPairNo:=5)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsStartsFunction, New RParameter("string", 0), iAdditionalPairNo:=6)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsEndsFunction, New RParameter("string", 0), iAdditionalPairNo:=7)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsRemoveFunction, New RParameter("string", 0), iAdditionalPairNo:=8)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceNaFunction, New RParameter("string", 0), iAdditionalPairNo:=9)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsExtractAllFunction, New RParameter("string", 0), iAdditionalPairNo:=10)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsMatchAllFunction, New RParameter("string", 0), iAdditionalPairNo:=11)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsLocateAllFunction, New RParameter("string", 0), iAdditionalPairNo:=12)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsRemoveAllFunction, New RParameter("string", 0), iAdditionalPairNo:=13)
        ucrInputReplaceBy.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("replacement", 2), iAdditionalPairNo:=1)

        ucrChkIgnoreCase.AddAdditionalCodeParameterPair(clsRegexFunction, ucrChkIgnoreCase.GetParameter(), iAdditionalPairNo:=1)
        ucrChkNegate.AddAdditionalCodeParameterPair(clsStartsFunction, ucrChkNegate.GetParameter(), iAdditionalPairNo:=1)
        ucrChkNegate.AddAdditionalCodeParameterPair(clsEndsFunction, ucrChkNegate.GetParameter(), iAdditionalPairNo:=2)

        ucrSaveStringHandling.AddAdditionalRCode(clsCountFunction, iAdditionalPairNo:=1)
        ucrSaveStringHandling.AddAdditionalRCode(clsExtractFunction, iAdditionalPairNo:=2)
        ucrSaveStringHandling.AddAdditionalRCode(clsLocateFunction, iAdditionalPairNo:=3)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceFunction, iAdditionalPairNo:=4)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceAllFunction, iAdditionalPairNo:=5)
        ucrSaveStringHandling.AddAdditionalRCode(clsStartsFunction, iAdditionalPairNo:=6)
        ucrSaveStringHandling.AddAdditionalRCode(clsEndsFunction, iAdditionalPairNo:=7)
        ucrSaveStringHandling.AddAdditionalRCode(clsRemoveFunction, iAdditionalPairNo:=8)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceNaFunction, iAdditionalPairNo:=9)
        ucrSaveStringHandling.AddAdditionalRCode(clsExtractAllFunction, iAdditionalPairNo:=10)
        ucrSaveStringHandling.AddAdditionalRCode(clsLocateAllFunction, iAdditionalPairNo:=11)
        ucrSaveStringHandling.AddAdditionalRCode(clsMatchAllFunction, iAdditionalPairNo:=12)
        ucrSaveStringHandling.AddAdditionalRCode(clsRemoveAllFunction, iAdditionalPairNo:=13)

        ucrReceiverStringHandling.SetRCode(clsDetectFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceAllFunction, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsDummyFunction, bReset)
        ucrChkReplaceAll.SetRCode(clsReplaceAllDummyFunction, bReset)
        ucrChkRemoveAll.SetRCode(clsRemoveAllDummyFunction, bReset)
        ucrChkAll.SetRCode(clsAllDummyFunction, bReset)
        ucrChkIgnoreCase.SetRCode(clsStringCollFunction, bReset)
        ucrInputBoundary.SetRCode(clsBoundaryFunction, bReset)
        ucrChkComments.SetRCode(clsRegexFunction, bReset)
        ucrChkMultiline.SetRCode(clsRegexFunction, bReset)
        ucrSaveStringHandling.SetRCode(clsDetectFunction, bReset)
        ucrChkNegate.SetRCode(clsDetectFunction, bReset)
        ucrChkReplaceBy.SetRCode(clsReplaceNaFunction, bReset)
        ucrInputReplaceNaBy.SetRCode(clsReplaceNaFunction, bReset)
        ucrPnlFindOptions.SetRCode(clsFindDummyFunction, bReset)
        ucrPnlDetectOptions.SetRCode(clsDetectDummyFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (rdoDetect.Checked OrElse rdoFind.Checked OrElse rdoReplace.Checked OrElse rdoRemove.Checked) AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() Then
            ucrBase.OKEnabled(True)
        ElseIf rdoReplaceNa.Checked AndAlso ucrSaveStringHandling.IsComplete() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub NewColumnName()
        If rdoReplaceNa.Checked Then
            ucrSaveStringHandling.SetLabelText("Prefix for New Column:")
        Else
            ucrSaveStringHandling.SetLabelText("New Column Name:")
        End If
    End Sub

    Private Sub AddRemoveParameters()
        clsStringCollFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        clsRegexFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=1)
        If ucrChkIncludeRegularExpressions.Checked Then
            clsCountFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsRemoveFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsDetectFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsStartsFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsEndsFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsExtractFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsLocateFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsReplaceFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsReplaceAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsLocateAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsExtractAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsMatchAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsRemoveAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsCountFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsRemoveFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsDetectFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsStartsFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsEndsFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsExtractFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsLocateFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsReplaceFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsReplaceAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsLocateAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsMatchAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsExtractAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsRemoveAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
        End If
    End Sub

    Private Sub ucrPnlStringHandling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStringHandling.ControlValueChanged, ucrPnlDetectOptions.ControlValueChanged, ucrChkAll.ControlValueChanged, ucrPnlFindOptions.ControlValueChanged, ucrChkReplaceAll.ControlValueChanged, ucrChkRemoveAll.ControlValueChanged, ucrInputReplaceNaBy.ControlValueChanged
        If rdoDetect.Checked Then
            If rdoDetects.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
            ElseIf rdoStarts.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsStartsFunction)
            ElseIf rdoEnds.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsEndsFunction)
            End If
            ucrSaveStringHandling.SetPrefix("detect")
        ElseIf rdoFind.Checked Then
            If rdoCount.Checked Then
                clsFindDummyFunction.AddParameter("checked", "str_count", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
                ucrSaveStringHandling.SetPrefix("count")
            ElseIf rdoExtract.Checked Then
                clsFindDummyFunction.AddParameter("checked", "str_extract", iPosition:=0)
                If ucrChkAll.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsExtractAllFunction)
                    ucrSaveStringHandling.SetPrefix("extract_all")
                Else
                    ucrBase.clsRsyntax.SetBaseRFunction(clsExtractFunction)
                    ucrSaveStringHandling.SetPrefix("extract")
                End If
            ElseIf rdoLocate.Checked Then
                clsFindDummyFunction.AddParameter("checked", "str_locate", iPosition:=0)
                If ucrChkAll.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsLocateAllFunction)
                    ucrSaveStringHandling.SetPrefix("locate_all")
                Else
                    ucrBase.clsRsyntax.SetBaseRFunction(clsLocateFunction)
                    ucrSaveStringHandling.SetPrefix("locate")
                End If
            End If
        ElseIf rdoReplace.Checked Then
            If ucrChkReplaceAll.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceAllFunction)
                ucrSaveStringHandling.SetPrefix("replace_all")
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
                ucrSaveStringHandling.SetPrefix("replace")
            End If
        ElseIf rdoReplaceNa.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceNaFunction)
            ucrSaveStringHandling.SetPrefix("replace_na")
        ElseIf rdoRemove.Checked Then
            If ucrChkRemoveAll.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveAllFunction)
                ucrSaveStringHandling.SetPrefix("remove_all")
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveFunction)
                ucrSaveStringHandling.SetPrefix("remove")
            End If
        End If

        NewColumnName()
        ChangePrefixName()
        AddRemoveParameters()
    End Sub

    Private Sub ChangePrefixName()
        If rdoLocate.Checked Then
            ucrSaveStringHandling.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        Else
            ucrSaveStringHandling.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
        End If
    End Sub

    Private Sub cmdAddkeyboard_Click(sender As Object, e As EventArgs) Handles cmdAddkeyboard.Click
        sdgConstructRegexExpression.ShowDialog()
        ucrInputPattern.SetName(sdgConstructRegexExpression.ucrReceiverForRegex.GetText())
    End Sub

    Private Sub ucrPnlDetectOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlDetectOptions.ControlContentsChanged
        If rdoDetects.Checked Then
            clsDetectDummyFunction.AddParameter("checked", "str_detect", iPosition:=0)
        ElseIf rdoStarts.Checked Then
            clsDetectDummyFunction.AddParameter("checked", "str_starts", iPosition:=0)
        ElseIf rdoEnds.Checked Then
            clsDetectDummyFunction.AddParameter("checked", "str_ends", iPosition:=0)
        End If
    End Sub

    Private Sub ucrChkIncludeRegularExpressions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeRegularExpressions.ControlValueChanged, ucrInputBoundary.ControlValueChanged, ucrChkBoundary.ControlValueChanged, ucrInputPattern.ControlValueChanged
        AddRemoveParameters()
        cmdAddkeyboard.Visible = If(ucrChkIncludeRegularExpressions.Checked, True, False)
        grpModifiers.Visible = If(ucrChkIncludeRegularExpressions.Checked, True, False)
    End Sub

    Private Sub ucrReceiverStringHandling_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringHandling.ControlContentsChanged, ucrPnlStringHandling.ControlContentsChanged, ucrSaveStringHandling.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class