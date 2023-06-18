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
            clsStartsFunction, clsEndsFunction, clsMatchAllFunction, clsExtractAllFunction, clsLocateAllFunction, clsRemoveAllFunction,
            clsReplaceCellFunction, clsAsDataFrameFunction, clsMutateFunction, clsReplaceGrepFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsDummyFunction, clsFindDummyFunction As New RFunction

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

        ucrPnlStringHandling.AddParameterValuesCondition(rdoDetects, "string_handling", "detect")
        ucrPnlStringHandling.AddParameterValuesCondition(rdoReplace, "string_handling", "replace")
        ucrPnlStringHandling.AddParameterValuesCondition(rdoFind, "string_handling", "find")
        ucrPnlStringHandling.AddParameterValuesCondition(rdoReplaceNa, "string_handling", "replace_na")
        ucrPnlStringHandling.AddParameterValuesCondition(rdoRemove, "string_handling", "remove")

        ucrPnlDetectOptions.AddRadioButton(rdoDetects)
        ucrPnlDetectOptions.AddRadioButton(rdoStarts)
        ucrPnlDetectOptions.AddRadioButton(rdoEnds)

        ucrPnlDetectOptions.AddParameterValuesCondition(rdoDetects, "detect", "str_detect")
        ucrPnlDetectOptions.AddParameterValuesCondition(rdoStarts, "detect", "str_starts")
        ucrPnlDetectOptions.AddParameterValuesCondition(rdoEnds, "detect", "str_ends")

        ucrPnlFindOptions.AddRadioButton(rdoCount)
        ucrPnlFindOptions.AddRadioButton(rdoExtract)
        ucrPnlFindOptions.AddRadioButton(rdoLocate)

        ucrPnlFindOptions.AddParameterValuesCondition(rdoCount, "checked", "str_count")
        ucrPnlFindOptions.AddParameterValuesCondition(rdoExtract, "checked", "str_extract")
        ucrPnlFindOptions.AddParameterValuesCondition(rdoLocate, "checked", "str_locate")

        ucrPnlReplaceOptions.AddRadioButton(rdoReplaceFirst)
        ucrPnlReplaceOptions.AddRadioButton(rdoReplaceAll)
        ucrPnlReplaceOptions.AddRadioButton(rdoReplaceCell)

        ucrPnlReplaceOptions.AddParameterValuesCondition(rdoReplaceFirst, "replace", "str_replace")
        ucrPnlReplaceOptions.AddParameterValuesCondition(rdoReplaceAll, "replace", "str_replace_all")
        ucrPnlReplaceOptions.AddParameterValuesCondition(rdoReplaceCell, "replace", "replace")

        ucrChkAll.SetText("All")
        ucrChkAll.SetParameter(New RParameter("all", 0))
        ucrChkAll.SetValuesCheckedAndUnchecked(True, False)

        ucrChkRemoveAll.SetText("Remove All")
        ucrChkRemoveAll.SetParameter(New RParameter("remove", 0))
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
        ucrPnlStringHandling.AddToLinkedControls({ucrInputReplaceBy, ucrPnlReplaceOptions}, {rdoReplace}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls({ucrInputPattern, ucrChkIgnoreCase, ucrChkIncludeRegularExpressions}, {rdoDetect, rdoFind, rdoReplace, rdoRemove}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrChkBoundary, {rdoDetect, rdoFind}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrPnlDetectOptions, {rdoDetect}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrPnlFindOptions, {rdoFind}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrChkReplaceBy, {rdoReplaceNa}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrChkRemoveAll, {rdoRemove}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFindOptions.AddToLinkedControls(ucrChkAll, {rdoExtract, rdoLocate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFindOptions.SetLinkedDisplayControl(grpFindOptions)
        ucrPnlDetectOptions.SetLinkedDisplayControl(grpDetectOptions)
        ucrPnlReplaceOptions.SetLinkedDisplayControl(grpReplaceOptions)
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
        clsRemoveFunction = New RFunction
        clsStartsFunction = New RFunction
        clsEndsFunction = New RFunction
        clsReplaceNaFunction = New RFunction
        clsFindDummyFunction = New RFunction
        clsMatchAllFunction = New RFunction
        clsExtractAllFunction = New RFunction
        clsLocateAllFunction = New RFunction
        clsRemoveAllFunction = New RFunction
        clsReplaceCellFunction = New RFunction
        clsAsDataFrameFunction = New RFunction
        clsMutateFunction = New RFunction
        clsPipeOperator = New ROperator
        clsReplaceGrepFunction = New RFunction

        ucrSelectorStringHandling.Reset()

        ucrInputReplaceBy.Reset()
        ucrSaveStringHandling.Reset()
        ucrInputReplaceBy.SetName("")
        ucrInputPattern.SetName("")

        clsDummyFunction.AddParameter("checked", False, iPosition:=0)
        clsDummyFunction.AddParameter("all", False, iPosition:=1)
        clsDummyFunction.AddParameter("remove", False, iPosition:=0)

        clsFindDummyFunction.AddParameter("checked", "str_count", iPosition:=0)
        clsFindDummyFunction.AddParameter("detect", "str_detect", iPosition:=1)
        clsFindDummyFunction.AddParameter("replace", "str_replace", iPosition:=2)
        clsFindDummyFunction.AddParameter("string_handling", "detect", iPosition:=3)

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

        clsAsDataFrameFunction.SetRCommand("data.frame")
        clsAsDataFrameFunction.SetAssignTo("df")

        clsReplaceGrepFunction.SetRCommand("grepl")

        clsReplaceCellFunction.SetRCommand("replace")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("x", clsRFunctionParameter:=clsReplaceCellFunction, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("x", "df", iPosition:=0, bIncludeArgumentName:=False)
        clsPipeOperator.AddParameter("y", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)

        clsDetectFunction.SetAssignTo(ucrSaveStringHandling.GetText, strTempDataframe:=ucrSelectorStringHandling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveStringHandling.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
        NewColumnName()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlStringHandling.SetRCode(clsFindDummyFunction, bReset)

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
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsAsDataFrameFunction, New RParameter("x", 0), iAdditionalPairNo:=14)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceCellFunction, New RParameter("x", 0), iAdditionalPairNo:=15)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceGrepFunction, New RParameter("x", 1), iAdditionalPairNo:=16)
        ucrInputReplaceBy.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("replacement", 2), iAdditionalPairNo:=1)
        ucrInputReplaceBy.AddAdditionalCodeParameterPair(clsReplaceCellFunction, New RParameter("values", 2), iAdditionalPairNo:=2)

        ucrChkIgnoreCase.AddAdditionalCodeParameterPair(clsRegexFunction, ucrChkIgnoreCase.GetParameter(), iAdditionalPairNo:=1)
        ucrChkIgnoreCase.AddAdditionalCodeParameterPair(clsReplaceGrepFunction, New RParameter("ignore.case", 2), iAdditionalPairNo:=2)
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
        ucrSaveStringHandling.AddAdditionalRCode(clsPipeOperator, iAdditionalPairNo:=14)

        ucrReceiverStringHandling.SetRCode(clsDetectFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceAllFunction, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsDummyFunction, bReset)
        ucrChkRemoveAll.SetRCode(clsDummyFunction, bReset)
        ucrChkAll.SetRCode(clsDummyFunction, bReset)
        ucrChkIgnoreCase.SetRCode(clsStringCollFunction, bReset)
        ucrInputBoundary.SetRCode(clsBoundaryFunction, bReset)
        ucrChkComments.SetRCode(clsRegexFunction, bReset)
        ucrChkMultiline.SetRCode(clsRegexFunction, bReset)
        ucrSaveStringHandling.SetRCode(clsDetectFunction, bReset)
        ucrChkNegate.SetRCode(clsDetectFunction, bReset)
        ucrChkReplaceBy.SetRCode(clsReplaceNaFunction, bReset)
        ucrInputReplaceNaBy.SetRCode(clsReplaceNaFunction, bReset)
        ucrPnlFindOptions.SetRCode(clsFindDummyFunction, bReset)
        ucrPnlDetectOptions.SetRCode(clsFindDummyFunction, bReset)
        ucrPnlReplaceOptions.SetRCode(clsFindDummyFunction, bReset)
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

    Private Sub ucrPnlStringHandling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStringHandling.ControlValueChanged,
        ucrPnlDetectOptions.ControlValueChanged, ucrChkAll.ControlValueChanged, ucrPnlFindOptions.ControlValueChanged, ucrChkRemoveAll.ControlValueChanged,
        ucrInputReplaceNaBy.ControlValueChanged, ucrPnlReplaceOptions.ControlValueChanged
        ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsAsDataFrameFunction)
        If rdoDetect.Checked Then
            If rdoDetects.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
            ElseIf rdoStarts.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsStartsFunction)
            ElseIf rdoEnds.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsEndsFunction)
            End If
            ucrSaveStringHandling.SetPrefix("detect")
            clsFindDummyFunction.AddParameter("string_handling", "detect", iPosition:=3)
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
            clsFindDummyFunction.AddParameter("string_handling", "find", iPosition:=3)
        ElseIf rdoReplace.Checked Then
            If rdoReplaceFirst.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
                ucrSaveStringHandling.SetPrefix("replace")
            ElseIf rdoReplaceAll.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceAllFunction)
                ucrSaveStringHandling.SetPrefix("replace_all")
            ElseIf rdoReplaceCell.Checked Then
                ucrBase.clsRsyntax.AddToBeforeCodes(clsAsDataFrameFunction)
                ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
                ucrSaveStringHandling.SetPrefix("replace_cell")
            End If
            clsFindDummyFunction.AddParameter("string_handling", "replace", iPosition:=3)
        ElseIf rdoReplaceNa.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceNaFunction)
            ucrSaveStringHandling.SetPrefix("replace_na")
            clsFindDummyFunction.AddParameter("string_handling", "replace_na", iPosition:=3)
        ElseIf rdoRemove.Checked Then
            If ucrChkRemoveAll.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveAllFunction)
                ucrSaveStringHandling.SetPrefix("remove_all")
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveFunction)
                ucrSaveStringHandling.SetPrefix("remove")
            End If
            clsFindDummyFunction.AddParameter("string_handling", "remove", iPosition:=3)
        End If
        NewColumnName()
        ChangePrefixName()
        AddRemoveParameters()
        CellParameters()
        RegularExpressionControl()
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
            clsFindDummyFunction.AddParameter("detect", "str_detect", iPosition:=1)
        ElseIf rdoStarts.Checked Then
            clsFindDummyFunction.AddParameter("detect", "str_starts", iPosition:=1)
        ElseIf rdoEnds.Checked Then
            clsFindDummyFunction.AddParameter("detect", "str_ends", iPosition:=1)
        End If
    End Sub

    Private Sub ucrChkIncludeRegularExpressions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeRegularExpressions.ControlValueChanged, ucrInputBoundary.ControlValueChanged, ucrChkBoundary.ControlValueChanged, ucrInputPattern.ControlValueChanged
        AddRemoveParameters()
        CellParameters()
        RegularExpressionControl()
        cmdAddkeyboard.Visible = If(ucrChkIncludeRegularExpressions.Checked, True, False)
    End Sub

    Private Sub ucrReceiverStringHandling_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringHandling.ControlContentsChanged, ucrPnlStringHandling.ControlContentsChanged, ucrSaveStringHandling.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub RegularExpressionControl()
        If ucrChkIncludeRegularExpressions.Checked Then
            If rdoReplace.Checked AndAlso rdoReplaceCell.Checked Then
                grpModifiers.Visible = False
            Else
                grpModifiers.Visible = True
            End If
        Else
            grpModifiers.Visible = False
        End If
    End Sub

    Private Sub CellParameters()
        If Not rdoReplace.Checked AndAlso Not rdoReplaceCell.Checked Then
            Exit Sub
        End If
        clsReplaceGrepFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34), bIncludeArgumentName:=False, iPosition:=0)
        clsReplaceCellFunction.AddParameter("pattern", clsRFunctionParameter:=clsReplaceGrepFunction, bIncludeArgumentName:=False, iPosition:=1)
    End Sub

    Private Sub ucrPnlReplaceOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlReplaceOptions.ControlContentsChanged
        If rdoReplaceFirst.Checked Then
            clsFindDummyFunction.AddParameter("replace", "str_replace", iPosition:=2)
        ElseIf rdoReplaceAll.Checked Then
            clsFindDummyFunction.AddParameter("replace", "str_replace_all", iPosition:=2)
        ElseIf rdoReplaceCell.Checked Then
            clsFindDummyFunction.AddParameter("replace", "replace", iPosition:=2)
        End If
    End Sub
End Class