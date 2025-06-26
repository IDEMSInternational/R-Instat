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
Public Class dlgSplitText
    Public enumSplitMode As String = SplitMode.Prepare
    Public Enum SplitMode
        Prepare
        Climatic
    End Enum

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTextComponentsFixed, clsAddColumnsFunction, clsTextMultipleFixedFunction, clsCurrentNewColumnFunction, clsSquishFunction, clsTextSelectMaxFunction, clsTextComponentsMaximum, clsStringCollFunction As New RFunction
    Private clsBinaryColumns, clsBinarySelectFunction As New RFunction
    Private clsSplitDummyFunction As New RFunction
    Private clsPatternDummyFunction As New RFunction
    Private clsGetDataFrameFunction As New RFunction
    Private clsUnpackFunction As New RFunction
    Private clsPaste2Function As New RFunction
    Private clsEndsWithFunction As New RFunction
    Private clsPasteFunction As New RFunction
    Private clsMutateFunction As New RFunction
    Private clsAcrossFunction, clsSelectFunction, clsNamesFunction As New RFunction
    Private clsEverythingFunction, clsAnyFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsDataFrameOperator As New ROperator
    Private clsUnpackOperator As New ROperator
    Private clsTildaOperator As New ROperator
    Private clsSelectOperator As New ROperator
    Private dctPatternPairs As New Dictionary(Of String, String)

    Private Sub dlgSplitText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetHelpOptions()
        bReset = False
        TestOKEnabled()
        NewDefaultName()

        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 344

        ucrPnlSplitText.AddRadioButton(rdoTextComponents)
        ucrPnlSplitText.AddRadioButton(rdoBinaryColumns)

        ucrPnlSplitText.AddFunctionNamesCondition(rdoBinaryColumns, "multi.split", True)
        ucrPnlSplitText.AddFunctionNamesCondition(rdoTextComponents, "multi.split", False)

        ucrPnlTextComponents.AddRadioButton(rdoFixedNumberOfComponents)
        ucrPnlTextComponents.AddRadioButton(rdoMaximumNumberOfComponents)

        ucrPnlTextComponents.AddFunctionNamesCondition(rdoMaximumNumberOfComponents, "str_split")
        ucrPnlTextComponents.AddFunctionNamesCondition(rdoFixedNumberOfComponents, "str_split_fixed")

        ucrPnlColumnSelectOptions.AddRadioButton(rdoSingle)
        ucrPnlColumnSelectOptions.AddRadioButton(rdoMultiple)

        ucrPnlColumnSelectOptions.AddParameterValuesCondition(rdoSingle, "col", "single")
        ucrPnlColumnSelectOptions.AddParameterValuesCondition(rdoMultiple, "col", "multiple")

        ucrPnlTextComponents.AddToLinkedControls(ucrNudPieces, {rdoFixedNumberOfComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=2, bNewLinkedChangeParameterValue:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrChkIncludeRegularExpressions, {rdoTextComponents}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSplitText.AddToLinkedControls(ucrPnlTextComponents, {rdoTextComponents}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoFixedNumberOfComponents)
        ucrChkIncludeRegularExpressions.AddToLinkedControls(ucrInputRegexPattern, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudPieces.SetLinkedDisplayControl(lblNumberofPiecesToReturn)

        ucrReceiverSplitTextColumn.SetParameter(New RParameter("string", 0))
        ucrReceiverSplitTextColumn.SetParameterIsRFunction()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrReceiverSplitTextColumn.bUseFilteredData = False

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        dctPatternPairs.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctPatternPairs.Add("Spaces ( )", Chr(34) & " " & Chr(34) & " ") ' Adds an invisible difference
        dctPatternPairs.Add("Period .", Chr(34) & "." & Chr(34))
        dctPatternPairs.Add("Comma ,", Chr(34) & "," & Chr(34))
        dctPatternPairs.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctPatternPairs.Add("Semicolon ;", Chr(34) & ";" & Chr(34))
        dctPatternPairs.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctPatternPairs.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputPattern.SetItems(dctPatternPairs)
        ucrInputPattern.bAllowNonConditionValues = True

        ucrNudPieces.SetParameter(New RParameter("n", 2))
        ucrNudPieces.SetMinMax(2, Integer.MaxValue)

        ucrChkIncludeRegularExpressions.SetText("Include Regular Expressions")
        ucrChkIncludeRegularExpressions.SetParameter(New RParameter("checked", 0))
        ucrChkIncludeRegularExpressions.SetValuesCheckedAndUnchecked(True, False)
        ucrChkIncludeRegularExpressions.SetRDefault("FALSE")

        ucrSaveColumn.SetSaveTypeAsColumn()
        ucrSaveColumn.SetPrefix("split")
        ucrSaveColumn.SetDataFrameSelector(ucrSelectorSplitTextColumn.ucrAvailableDataFrames)
        ucrSaveColumn.SetLabelText("Prefix for New Columns:")
        ucrSaveColumn.SetIsComboBox()
        ucrSaveColumn.setLinkedReceiver(ucrReceiverSplitTextColumn)
    End Sub

    Private Sub SetDefaults()
        clsTextComponentsFixed = New RFunction
        clsTextMultipleFixedFunction = New RFunction
        clsTextComponentsMaximum = New RFunction
        clsTextSelectMaxFunction = New RFunction
        clsBinaryColumns = New RFunction
        clsBinarySelectFunction = New RFunction
        clsStringCollFunction = New RFunction
        clsSplitDummyFunction = New RFunction
        clsPatternDummyFunction = New RFunction
        clsSquishFunction = New RFunction
        clsCurrentNewColumnFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsMutateFunction = New RFunction
        clsAcrossFunction = New RFunction
        clsEverythingFunction = New RFunction
        clsPasteFunction = New RFunction
        clsPaste2Function = New RFunction
        clsEndsWithFunction = New RFunction
        clsUnpackFunction = New RFunction
        clsAddColumnsFunction = New RFunction
        clsPipeOperator = New ROperator
        clsDataFrameOperator = New ROperator
        clsUnpackOperator = New ROperator
        clsTildaOperator = New ROperator
        clsSelectOperator = New ROperator

        ucrSelectorSplitTextColumn.Reset()
        ucrSaveColumn.Reset()

        ucrInputRegexPattern.SetName("")

        clsSplitDummyFunction.AddParameter("checked", False, iPosition:=0)
        clsSplitDummyFunction.AddParameter("col", "single", iPosition:=1)

        clsPatternDummyFunction.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)

        clsStringCollFunction.SetPackageName("stringr")
        clsStringCollFunction.SetRCommand("coll")
        clsStringCollFunction.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=0)

        clsBinaryColumns.SetPackageName("questionr")
        clsBinaryColumns.SetRCommand("multi.split")

        clsBinarySelectFunction.SetPackageName("~questionr")
        clsBinarySelectFunction.SetRCommand("multi.split")

        clsTextComponentsFixed.SetPackageName("stringr")
        clsTextComponentsFixed.SetRCommand("str_split_fixed")
        clsTextComponentsFixed.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponentsFixed.AddParameter("n", strParameterValue:=2, iPosition:=2)


        clsTextMultipleFixedFunction.SetPackageName("~stringr")
        clsTextMultipleFixedFunction.SetRCommand("str_split_fixed")
        clsTextMultipleFixedFunction.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextMultipleFixedFunction.AddParameter("n", strParameterValue:=2, iPosition:=2)

        clsTextComponentsMaximum.SetPackageName("stringr")
        clsTextComponentsMaximum.SetRCommand("str_split")
        clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextComponentsMaximum.AddParameter("n", "Inf", iPosition:=2)
        clsTextComponentsMaximum.AddParameter("simplify", "TRUE", iPosition:=3)

        clsTextSelectMaxFunction.SetPackageName("~stringr")
        clsTextSelectMaxFunction.SetRCommand("str_split")
        clsTextSelectMaxFunction.AddParameter("pattern", Chr(34) & "," & Chr(34), iPosition:=1)
        clsTextSelectMaxFunction.AddParameter("n", "Inf", iPosition:=2)
        clsTextSelectMaxFunction.AddParameter("simplify", "TRUE", iPosition:=3)

        clsSquishFunction.SetPackageName("stringr")
        clsSquishFunction.SetRCommand("str_squish")

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        clsTildaOperator.SetOperation(" ", bBracketsTemp:=False)
        clsTildaOperator.SetAssignTo("select")

        clsDataFrameOperator.SetOperation("%>%")
        clsDataFrameOperator.AddParameter("right", "as.data.frame()", iPosition:=1)

        clsPasteFunction.SetRCommand("paste0")
        clsPasteFunction.AddParameter("col", """{.col}_""", iPosition:=0, bIncludeArgumentName:=False)
        clsPasteFunction.AddParameter("", clsROperatorParameter:=clsTildaOperator, bIncludeArgumentName:=False)

        clsEverythingFunction.SetRCommand("everything")
        clsEverythingFunction.AddParameter("dot", ".", bIncludeArgumentName:=False, iPosition:=0)

        clsAcrossFunction.SetPackageName("dplyr")
        clsAcrossFunction.SetRCommand("across")
        clsAcrossFunction.AddParameter("every", clsRFunctionParameter:=clsEverythingFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsAcrossFunction.AddParameter("tilda", clsROperatorParameter:=clsDataFrameOperator, bIncludeArgumentName:=False, iPosition:=1)
        clsAcrossFunction.AddParameter(".names", clsRFunctionParameter:=clsPasteFunction, iPosition:=2)

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter(".names", clsRFunctionParameter:=clsAcrossFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)

        clsPaste2Function.SetRCommand("paste0")
        clsPaste2Function.AddParameter("names", """_""", iPosition:=0, bIncludeArgumentName:=False)
        clsPaste2Function.AddParameter("split", "select", iPosition:=1, bIncludeArgumentName:=False)

        clsEndsWithFunction.SetRCommand("ends_with")
        clsEndsWithFunction.AddParameter("paste", clsRFunctionParameter:=clsPaste2Function, iPosition:=0, bIncludeArgumentName:=False)

        clsUnpackFunction.SetPackageName("tidyr")
        clsUnpackFunction.SetRCommand("unpack")
        clsUnpackFunction.AddParameter("cols", clsRFunctionParameter:=clsEndsWithFunction, iPosition:=0)
        clsUnpackFunction.AddParameter("names_sep", """.""", iPosition:=1)

        clsUnpackOperator.SetOperation("%>%")
        clsUnpackOperator.AddParameter("left", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsUnpackOperator.AddParameter("right", clsRFunctionParameter:=clsUnpackFunction, iPosition:=1)

        clsNamesFunction.SetRCommand("names")

        clsAnyFunction.SetRCommand("-any_of")
        clsAnyFunction.AddParameter("any", clsRFunctionParameter:=clsNamesFunction, bIncludeArgumentName:=False)

        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("select", clsRFunctionParameter:=clsAnyFunction, bIncludeArgumentName:=False)

        clsSelectOperator.SetOperation("%>%")
        clsSelectOperator.AddParameter("left", clsROperatorParameter:=clsUnpackOperator, iPosition:=0)
        clsSelectOperator.AddParameter("right", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)
        clsSelectOperator.SetAssignTo("col")


        clsAddColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsAddColumnsFunction.AddParameter("col_data", clsROperatorParameter:=clsSelectOperator, iPosition:=1)
        clsAddColumnsFunction.AddParameter("before", "FALSE", iPosition:=2)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveColumn.AddAdditionalRCode(clsTextComponentsMaximum, iAdditionalPairNo:=1)
        ucrSaveColumn.AddAdditionalRCode(clsBinaryColumns, iAdditionalPairNo:=2)
        ucrNudPieces.AddAdditionalCodeParameterPair(clsTextMultipleFixedFunction, New RParameter("n", 1), iAdditionalPairNo:=1)

        ucrInputPattern.SetRCode(clsPatternDummyFunction, bReset)
        ucrNudPieces.SetRCode(clsTextComponentsFixed, bReset)
        ucrChkIncludeRegularExpressions.SetRCode(clsSplitDummyFunction, bReset)
        ucrPnlTextComponents.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveColumn.SetRCode(clsTextComponentsFixed, bReset)
        ucrPnlColumnSelectOptions.SetRCode(clsSplitDummyFunction, bReset)

        If bReset Then
            ucrPnlSplitText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
        SetTextSplittingParameters()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverSplitTextColumn.IsEmpty() AndAlso
       Not ucrInputPattern.IsEmpty AndAlso
       ucrSaveColumn.IsComplete() AndAlso
       ((rdoTextComponents.Checked AndAlso ucrNudPieces.GetText <> "") OrElse rdoBinaryColumns.Checked) Then

            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
        sdgConstructRegexExpression.ucrReceiverForRegex.Clear()
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumSplitMode
            Case SplitMode.Prepare
                ucrBase.iHelpTopicID = 344
            Case SplitMode.Climatic
                ucrBase.iHelpTopicID = 601
        End Select
    End Sub


    Private Sub cmdAddkeyboard_Click(sender As Object, e As EventArgs) Handles cmdAddkeyboard.Click
        sdgConstructRegexExpression.ShowDialog()
        ucrInputRegexPattern.SetName(sdgConstructRegexExpression.ucrReceiverForRegex.GetText())
    End Sub

    Private Sub ucrPnlSplitText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSplitText.ControlValueChanged
        SetVisibleAddKeyboardButton()
        ChangeParametersValues()
        SetBaseFunction()
    End Sub

    Private Sub ucrPnlTextComponents_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlTextComponents.ControlValueChanged
        ChangeParametersValues()
        SetBaseFunction()
    End Sub

    Private Sub SetVisibleAddKeyboardButton()
        If rdoBinaryColumns.Checked Then
            cmdAddkeyboard.Visible = False
        Else
            cmdAddkeyboard.Visible = If(ucrChkIncludeRegularExpressions.Checked, True, False)
        End If
    End Sub

    Private Sub ChangeParametersValues()
        Dim strPattern As String

        If dctPatternPairs.ContainsKey(ucrInputPattern.GetText) Then
            strPattern = dctPatternPairs(ucrInputPattern.GetText)
        Else
            strPattern = Chr(34) & ucrInputPattern.GetText & Chr(34)
        End If
        clsTextComponentsFixed.RemoveParameterByName("pattern")
        clsTextMultipleFixedFunction.RemoveParameterByName("pattern")
        clsTextComponentsMaximum.RemoveParameterByName("pattern")
        clsTextSelectMaxFunction.RemoveParameterByName("pattern")
        clsBinaryColumns.AddParameter("split.char", strPattern, iPosition:=1)
        clsBinarySelectFunction.AddParameter("split.char", strPattern, iPosition:=1)

        If ucrChkIncludeRegularExpressions.Checked Then
            clsTextComponentsFixed.AddParameter("pattern", Chr(34) & ucrInputRegexPattern.GetText & Chr(34), iPosition:=1)
            clsTextComponentsMaximum.AddParameter("pattern", Chr(34) & ucrInputRegexPattern.GetText & Chr(34), iPosition:=1)
            clsTextMultipleFixedFunction.AddParameter("pattern", Chr(34) & ucrInputRegexPattern.GetText & Chr(34), iPosition:=1)
            clsTextSelectMaxFunction.AddParameter("pattern", Chr(34) & ucrInputRegexPattern.GetText & Chr(34), iPosition:=1)

        Else
            clsTextMultipleFixedFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, iPosition:=1)
            clsStringCollFunction.AddParameter("pattern", strPattern, iPosition:=0)
            clsTextComponentsFixed.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, iPosition:=1)
            clsTextComponentsMaximum.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, iPosition:=1)
            clsTextSelectMaxFunction.AddParameter("pattern", clsRFunctionParameter:=clsStringCollFunction, iPosition:=1)
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoSingle.Checked Then
            If rdoBinaryColumns.Checked Then
                cmdAddkeyboard.Visible = False
                ucrBase.clsRsyntax.SetBaseRFunction(clsBinaryColumns)
            Else
                If rdoFixedNumberOfComponents.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsFixed)
                ElseIf rdoMaximumNumberOfComponents.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsTextComponentsMaximum)
                End If
            End If
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsAddColumnsFunction)
            If rdoBinaryColumns.Checked Then
                clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsBinarySelectFunction, iPosition:=0)

            Else
                If rdoFixedNumberOfComponents.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsTextMultipleFixedFunction, iPosition:=0)

                ElseIf rdoMaximumNumberOfComponents.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsTextSelectMaxFunction, iPosition:=0)

                End If
            End If
        End If

        SetTextSplittingParameters()
        NewDefaultName()

    End Sub

    Private Sub NewDefaultName()
        If rdoSingle.Checked Then
            ucrSaveColumn.Visible = True
        ElseIf rdoMultiple.Checked Then
            ucrSaveColumn.Visible = False
        End If
    End Sub

    Private Sub ucrChkIncludeRegularExpressions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkIncludeRegularExpressions.ControlValueChanged, ucrReceiverSplitTextColumn.ControlValueChanged, ucrInputPattern.ControlValueChanged, ucrInputRegexPattern.ControlValueChanged
        clsCurrentNewColumnFunction = ucrReceiverSplitTextColumn.GetVariables()
        clsCurrentNewColumnFunction.SetAssignTo(ucrReceiverSplitTextColumn.GetVariableNames(False))
        ChangeParametersValues()
        SetVisibleAddKeyboardButton()
        SetTextSplittingParameters()
    End Sub

    Private Sub SetTextSplittingParameters()
        clsSquishFunction.RemoveParameterByName("split")
        clsTextComponentsMaximum.RemoveParameterByName("string")

        clsTextComponentsFixed.RemoveParameterByName("string")
        clsBinaryColumns.RemoveParameterByName("var")
        clsBinarySelectFunction.RemoveParameterByName("var")
        clsTextMultipleFixedFunction.RemoveParameterByName("string")
        clsTextSelectMaxFunction.RemoveParameterByName("string")

        If rdoSingle.Checked Then
            Select Case ucrInputPattern.GetText()
                Case "Spaces ( )"
                    clsSquishFunction.AddParameter("split", clsRFunctionParameter:=clsCurrentNewColumnFunction, bIncludeArgumentName:=False, iPosition:=0)
                    clsTextComponentsFixed.AddParameter("string", clsRFunctionParameter:=clsSquishFunction, iPosition:=0)
                    clsTextComponentsMaximum.AddParameter("string", clsRFunctionParameter:=clsSquishFunction, iPosition:=0)
                    clsBinaryColumns.AddParameter("var", clsRFunctionParameter:=clsSquishFunction, iPosition:=0)

                Case Else
                    clsTextComponentsFixed.AddParameter("string", clsRFunctionParameter:=clsCurrentNewColumnFunction, iPosition:=0)
                    clsTextComponentsMaximum.AddParameter("string", clsRFunctionParameter:=clsCurrentNewColumnFunction, iPosition:=0)
                    clsBinaryColumns.AddParameter("var", clsRFunctionParameter:=clsCurrentNewColumnFunction, iPosition:=0)
            End Select
        Else
            clsTextSelectMaxFunction.AddParameter("string", ".x", iPosition:=0)
            clsBinarySelectFunction.AddParameter("var", ".x", iPosition:=0)
            clsTextMultipleFixedFunction.AddParameter("string", ".x", iPosition:=0)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSplitTextColumn.ControlContentsChanged, ucrNudPieces.ControlContentsChanged, ucrSaveColumn.ControlContentsChanged, ucrPnlSplitText.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlColumnSelectOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnSelectOptions.ControlValueChanged, ucrReceiverSplitTextColumn.ControlValueChanged, ucrSelectorSplitTextColumn.ControlValueChanged
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrSelectorSplitTextColumn.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFrameFunction.AddParameter("column_selection_name ", ucrReceiverSplitTextColumn.GetVariableNames, iPosition:=1)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsTildaOperator.AddParameter("", ucrReceiverSplitTextColumn.GetVariableNames, iPosition:=0, bIncludeArgumentName:=False)
        clsAddColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsNamesFunction.AddParameter("data_name", ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0, bIncludeArgumentName:=False)

        If rdoMultiple.Checked Then
            clsSplitDummyFunction.AddParameter("col", "multiple", iPosition:=0)
            ucrSelectorSplitTextColumn.SetItemType("column_selection")
            ucrReceiverSplitTextColumn.strSelectorHeading = "Column selections"
            lblSelectedFactor.Text = "Select:"

        ElseIf rdoSingle.Checked Then

            clsSplitDummyFunction.AddParameter("col", "single", iPosition:=0)
            ucrSelectorSplitTextColumn.SetItemType("column")
            ucrReceiverSplitTextColumn.strSelectorHeading = "Numerics"
            lblSelectedFactor.Text = "Column:"
        End If
        SetBaseFunction()
    End Sub

End Class