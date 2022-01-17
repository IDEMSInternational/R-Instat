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
            clsFindFunction, clsStartsFunction, clsEndsFunction, clsMatchFunction, clsMatchAllFunction, clsExtractAllFunction,
            clsLocateAllFunction, clsCountAllFunction As New RFunction
    Private clsDummyFunction, clsDetectDummyFunction, clsFindDummyFunction, clsAllDummyFunction As New RFunction

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
        ucrPnlStringHandling.AddRadioButton(rdoReplaceNA)
        ucrPnlStringHandling.AddRadioButton(rdoRemove)

        ucrPnlStringHandling.AddFunctionNamesCondition(rdoDetect, "str_detect")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplace, "str_replace")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoFind, "str_find")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplaceNA, "str_replace_na")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoRemove, "str_remove")

        ucrPnlDetectOptions.AddRadioButton(rdoDetects)
        ucrPnlDetectOptions.AddRadioButton(rdoStarts)
        ucrPnlDetectOptions.AddRadioButton(rdoEnds)

        ucrPnlDetectOptions.AddParameterValuesCondition(rdoDetects, "checked", "str_detect")
        ucrPnlDetectOptions.AddParameterValuesCondition(rdoStarts, "checked", "str_starts")
        ucrPnlDetectOptions.AddParameterValuesCondition(rdoEnds, "checked", "str_ends")


        ucrPnlFindOptions.AddRadioButton(rdoCount)
        ucrPnlFindOptions.AddRadioButton(rdoExtract)
        ucrPnlFindOptions.AddRadioButton(rdoLocate)
        ucrPnlFindOptions.AddRadioButton(rdoMatch)

        ucrPnlFindOptions.AddParameterValuesCondition(rdoCount, "checked", "str_count")
        ucrPnlFindOptions.AddParameterValuesCondition(rdoExtract, "checked", "str_extract")
        ucrPnlFindOptions.AddParameterValuesCondition(rdoLocate, "checked", "str_locate")
        ucrPnlFindOptions.AddParameterValuesCondition(rdoMatch, "checked", "str_match")

        ucrChkAll.SetText("All")
        ucrChkAll.SetParameter(New RParameter("checked", 0))
        ucrChkAll.SetValuesCheckedAndUnchecked(True, False)

        rdoLocate.Enabled = False 'not yet implementated

        ucrChkNegate.SetText("Negate")
        ucrChkNegate.SetParameter(New RParameter("negate", 2))
        ucrChkNegate.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputReplaceBy.SetParameter(New RParameter("replacement", 2))

        ucrPnlStringHandling.AddToLinkedControls({ucrInputReplaceBy}, {rdoReplace}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrChkBoundary, {rdoDetect, rdoFind}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrPnlDetectOptions, {rdoDetect}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStringHandling.AddToLinkedControls(ucrPnlFindOptions, {rdoFind}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDetectOptions.SetLinkedDisplayControl(grpDetectOptions)
        ucrPnlFindOptions.SetLinkedDisplayControl(grpFindOptions)
        ucrInputReplaceBy.SetLinkedDisplayControl(lblReplaceBy)
        ucrChkBoundary.AddToLinkedControls(ucrInputBoundary, {True}, bNewLinkedHideIfParameterMissing:=True)

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
        clsStartsFunction = New RFunction
        clsEndsFunction = New RFunction
        clsMatchFunction = New RFunction
        clsReplaceNaFunction = New RFunction
        clsFindDummyFunction = New RFunction
        clsMatchAllFunction = New RFunction
        clsCountAllFunction = New RFunction
        clsExtractAllFunction = New RFunction
        clsLocateAllFunction = New RFunction
        clsAllDummyFunction = New RFunction

        ucrSelectorStringHandling.Reset()

        rdoDetect.Checked = True

        ucrInputReplaceBy.Reset()
        ucrSaveStringHandling.Reset()
        ucrInputReplaceBy.SetName("")
        ucrInputPattern.SetName("")

        clsDummyFunction.AddParameter("checked", False, iPosition:=0)
        clsAllDummyFunction.AddParameter("checked", False, iPosition:=0)
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

        AddRemoveParameters()

        clsStartsFunction.SetPackageName("stringr")
        clsStartsFunction.SetRCommand("str_starts")
        clsStartsFunction.AddParameter("negate", "FALSE", iPosition:=2)

        clsEndsFunction.SetPackageName("stringr")
        clsEndsFunction.SetRCommand("str_ends")
        clsEndsFunction.AddParameter("negate", "FALSE", iPosition:=2)

        clsCountFunction.SetPackageName("stringr")
        clsCountFunction.SetRCommand("str_count")
        clsCountAllFunction.SetPackageName("stringr")
        clsCountAllFunction.SetRCommand("str_count_all")
        clsExtractFunction.SetPackageName("stringr")
        clsExtractFunction.SetRCommand("str_extract")
        clsExtractAllFunction.SetPackageName("stringr")
        clsExtractAllFunction.SetRCommand("str_extract_all")
        clsMatchFunction.SetPackageName("stringr")
        clsMatchFunction.SetRCommand("str_match")
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

        ChangePrefixName()
        clsDetectFunction.SetAssignTo(ucrSaveStringHandling.GetText, strTempDataframe:=ucrSelectorStringHandling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveStringHandling.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
        NewColumnName()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsCountFunction, New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsExtractFunction, New RParameter("string", 0), iAdditionalPairNo:=2)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsLocateFunction, New RParameter("string", 0), iAdditionalPairNo:=3)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("string", 0), iAdditionalPairNo:=4)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceAllFunction, New RParameter("string", 0), iAdditionalPairNo:=5)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsStartsFunction, New RParameter("string", 0), iAdditionalPairNo:=6)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsEndsFunction, New RParameter("string", 0), iAdditionalPairNo:=7)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsMatchFunction, New RParameter("string", 0), iAdditionalPairNo:=8)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsRemoveFunction, New RParameter("string", 0), iAdditionalPairNo:=9)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceNaFunction, New RParameter("string", 0), iAdditionalPairNo:=10)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsCountAllFunction, New RParameter("string", 0), iAdditionalPairNo:=11)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsExtractAllFunction, New RParameter("string", 0), iAdditionalPairNo:=12)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsMatchAllFunction, New RParameter("string", 0), iAdditionalPairNo:=13)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsLocateAllFunction, New RParameter("string", 0), iAdditionalPairNo:=14)

        ucrChkIgnoreCase.AddAdditionalCodeParameterPair(clsRegexFunction, ucrChkIgnoreCase.GetParameter(), iAdditionalPairNo:=1)
        ucrChkNegate.AddAdditionalCodeParameterPair(clsStartsFunction, ucrChkNegate.GetParameter(), iAdditionalPairNo:=1)
        ucrChkNegate.AddAdditionalCodeParameterPair(clsEndsFunction, ucrChkNegate.GetParameter(), iAdditionalPairNo:=2)

        ucrInputReplaceBy.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("replacement", 2), iAdditionalPairNo:=1)

        ucrSaveStringHandling.AddAdditionalRCode(clsCountFunction, iAdditionalPairNo:=1)
        ucrSaveStringHandling.AddAdditionalRCode(clsExtractFunction, iAdditionalPairNo:=2)
        ucrSaveStringHandling.AddAdditionalRCode(clsLocateFunction, iAdditionalPairNo:=3)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceFunction, iAdditionalPairNo:=4)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceAllFunction, iAdditionalPairNo:=5)
        ucrSaveStringHandling.AddAdditionalRCode(clsStartsFunction, iAdditionalPairNo:=6)
        ucrSaveStringHandling.AddAdditionalRCode(clsEndsFunction, iAdditionalPairNo:=7)
        ucrSaveStringHandling.AddAdditionalRCode(clsRemoveFunction, iAdditionalPairNo:=8)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceNaFunction, iAdditionalPairNo:=9)
        ucrSaveStringHandling.AddAdditionalRCode(clsMatchFunction, iAdditionalPairNo:=10)
        ucrSaveStringHandling.AddAdditionalRCode(clsCountAllFunction, iAdditionalPairNo:=11)
        ucrSaveStringHandling.AddAdditionalRCode(clsExtractAllFunction, iAdditionalPairNo:=12)
        ucrSaveStringHandling.AddAdditionalRCode(clsLocateAllFunction, iAdditionalPairNo:=13)
        ucrSaveStringHandling.AddAdditionalRCode(clsMatchAllFunction, iAdditionalPairNo:=14)

        ucrReceiverStringHandling.SetRCode(clsDetectFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceAllFunction, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsDummyFunction, bReset)
        ucrChkAll.SetRCode(clsAllDummyFunction, bReset)
        ucrChkIgnoreCase.SetRCode(clsStringCollFunction, bReset)
        ucrInputBoundary.SetRCode(clsBoundaryFunction, bReset)
        ucrChkComments.SetRCode(clsRegexFunction, bReset)
        ucrChkMultiline.SetRCode(clsRegexFunction, bReset)
        ucrSaveStringHandling.SetRCode(clsDetectFunction, bReset)
        ucrChkNegate.SetRCode(clsDetectFunction, bReset)
        ucrPnlDetectOptions.SetRCode(clsDetectDummyFunction, bReset)
        ucrPnlFindOptions.SetRCode(clsFindDummyFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoDetect.Checked AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty() Then
            ucrBase.OKEnabled(True)
        ElseIf rdoFind.Checked AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty() Then
            ucrBase.OKEnabled(True)
            'ElseIf (rdoDetect.Checked OrElse rdoFind.Checked OrElse rdoReplace.Checked OrElse rdoReplaceNA.Checked) AndAlso ucrChkIncludeRegularExpressions.Checked AndAlso Not ucrReceiverForRegexExpression.IsEmpty AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() Then
            '    ucrBase.OKEnabled(True)
            'ElseIf (rdoRemove.Checked OrElse rdoReplaceAll.Checked) AndAlso ucrChkIncludeRegularExpressions.Checked AndAlso Not ucrReceiverForRegexExpression.IsEmpty AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputReplaceBy.IsEmpty Then
            '    ucrBase.OKEnabled(True)
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
        If rdoReplaceNA.Checked Then
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
            clsMatchFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsDetectFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsStartsFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsEndsFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsExtractFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsLocateFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsReplaceFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsReplaceAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsCountAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsLocateAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsExtractAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsMatchAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction, bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsCountFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsMatchFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsDetectFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsStartsFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsEndsFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsExtractFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsLocateFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsReplaceFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsReplaceAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsCountAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsLocateAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsMatchAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
            clsExtractAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, bIncludeArgumentName:=False, iPosition:=1)
        End If
    End Sub

    Private Sub ucrPnlStringHandling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStringHandling.ControlValueChanged, ucrPnlDetectOptions.ControlValueChanged, ucrChkAll.ControlValueChanged, ucrPnlFindOptions.ControlValueChanged
        If rdoDetect.Checked Then
            If rdoDetects.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
                clsDetectDummyFunction.AddParameter("checked", "str_detect", iPosition:=0)
            ElseIf rdoStarts.Checked Then
                clsDetectDummyFunction.AddParameter("checked", "str_starts", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsStartsFunction)
            ElseIf rdoEnds.Checked Then
                clsDetectDummyFunction.AddParameter("checked", "str_ends", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsEndsFunction)
            End If
        ElseIf rdoFind.Checked Then
            If rdoCount.Checked Then
                clsFindDummyFunction.AddParameter("checked", "str_count", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
                If ucrChkAll.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsCountAllFunction)
                End If
            ElseIf rdoExtract.Checked Then
                clsFindDummyFunction.AddParameter("checked", "str_extract", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsExtractFunction)
                If ucrChkAll.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsExtractAllFunction)
                End If
            ElseIf rdoMatch.Checked Then
                clsFindDummyFunction.AddParameter("checked", "str_match", iPosition:=0)
                ucrBase.clsRsyntax.SetBaseRFunction(clsMatchFunction)
                If ucrChkAll.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMatchAllFunction)
                End If
            End If
        ElseIf rdoReplace.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
        ElseIf rdoReplaceNA.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceNaFunction)
        ElseIf rdoRemove.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveFunction)
        End If

        NewColumnName()
        ChangePrefixName()
        AddRemoveParameters()
    End Sub

    Private Sub ChangePrefixName()
        If Not ucrSaveStringHandling.bUserTyped Then
            If rdoDetects.Checked OrElse rdoStarts.Checked OrElse rdoEnds.Checked Then
                ucrSaveStringHandling.SetPrefix("detect")
            ElseIf rdoFind.Checked Then
                ucrSaveStringHandling.SetPrefix("find")
            ElseIf rdoReplace.Checked Then
                ucrSaveStringHandling.SetPrefix("replace")
            ElseIf rdoReplaceNA.Checked Then
                ucrSaveStringHandling.SetPrefix("")
                ucrSaveStringHandling.SetName("")
            ElseIf rdoRemove.Checked Then
                ucrSaveStringHandling.SetPrefix("remove")
            End If
        End If
        If rdoReplaceNA.Checked Then
            ucrSaveStringHandling.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        Else
            ucrSaveStringHandling.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
        End If
    End Sub

    Private Sub cmdAddkeyboard_Click(sender As Object, e As EventArgs) Handles cmdAddkeyboard.Click
        sdgConstructRegexExpression.ShowDialog()
        ucrInputPattern.SetName(sdgConstructRegexExpression.ucrReceiverForRegex.GetText())
    End Sub

    Private Sub ucrChkIncludeRegularExpressions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeRegularExpressions.ControlValueChanged, ucrInputBoundary.ControlValueChanged, ucrChkBoundary.ControlValueChanged, ucrInputPattern.ControlValueChanged
        AddRemoveParameters()
        cmdAddkeyboard.Visible = If(ucrChkIncludeRegularExpressions.Checked, True, False)
        grpModifiers.Visible = If(ucrChkIncludeRegularExpressions.Checked, True, False)
    End Sub

    Private Sub ucrReceiverStringHandling_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringHandling.ControlContentsChanged, ucrPnlStringHandling.ControlContentsChanged, ucrInputPattern.ControlContentsChanged, ucrSaveStringHandling.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class