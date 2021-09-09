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
Public Class dlgStack
    Private clsUnnestTokensFunction As RFunction
    Private clsPivotLongerFunction As RFunction
    Private clsSelectFunction As RFunction
    Private clsPipeOperator As ROperator
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgStack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctToken As New Dictionary(Of String, String)
        Dim dctFormat As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 57

        ucrSelectorStack.SetParameter(New RParameter("tbl", 0))
        ucrSelectorStack.SetParameterIsrfunction()

        ucrReceiverColumnsToCarry.Selector = ucrSelectorStack
        ucrReceiverColumnsToCarry.SetParameterIsString()
        ucrReceiverColumnsToCarry.SetValuesToIgnore({"NULL"})

        ucrReceiverColumnsToBeStack.SetParameter(New RParameter("cols", 2))
        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrReceiverColumnsToBeStack.SetParameterIsString()
        ucrReceiverColumnsToBeStack.SetLinkedDisplayControl(lblColumnsTostack)

        ucrInputNamesTo.SetParameter(New RParameter("names_to", 3))
        ucrInputNamesTo.SetRDefault(Chr(34) & "names" & Chr(34))
        ucrInputNamesTo.SetLinkedDisplayControl(lblNamesTo)

        ucrChkCarryColumns.SetText("Columns to carry")
        ucrChkCarryColumns.AddParameterIsROperatorCondition(True, "data")
        ucrChkCarryColumns.AddParameterIsROperatorCondition(False, "data", False)

        ucrChkCarryColumns.AddToLinkedControls(ucrReceiverColumnsToCarry, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputValuesTo.SetParameter(New RParameter(" values_to", 4))
        ucrInputValuesTo.SetRDefault(Chr(34) & "value" & Chr(34))
        ucrInputValuesTo.SetLinkedDisplayControl(lblValuesTo)

        ucrInputToken.SetLinkedDisplayControl(lblToken)
        ucrInputToken.SetParameter(New RParameter("token", 3))
        dctToken.Add("Words", Chr(34) & "words" & Chr(34))
        dctToken.Add("Characters", Chr(34) & " characters" & (34))
        dctToken.Add("Character_shingles", Chr(34) & "character_shingles" & Chr(34))
        dctToken.Add("Ngrams", Chr(34) & "ngrams" & Chr(34))
        dctToken.Add("Skip_ngrams", Chr(34) & "skip_ngrams" & Chr(34))
        dctToken.Add("Sentences", Chr(34) & "sentences" & Chr(34))
        dctToken.Add("Lines", Chr(34) & "lines" & Chr(34))
        dctToken.Add("Paragraphs", Chr(34) & "paragraphs" & Chr(34))
        dctToken.Add("Regex", Chr(34) & "regex" & Chr(34))
        dctToken.Add("Tweets", Chr(34) & "tweets" & Chr(34))
        dctToken.Add("Penn treebank", Chr(34) & "ptb" & Chr(34))
        ucrInputToken.SetItems(dctToken)
        ucrInputToken.SetRDefault(Chr(34) & "words" & Chr(34))

        ucrInputFormat.SetParameter(New RParameter("format", 4))
        ucrInputFormat.SetLinkedDisplayControl(lblFormat)
        dctFormat.Add("Text", Chr(34) & "text" & Chr(34))
        dctFormat.Add("Man", Chr(34) & "man" & Chr(34))
        dctFormat.Add("Latex", Chr(34) & "latex" & Chr(34))
        dctFormat.Add("Html", Chr(34) & "html" & Chr(34))
        dctFormat.Add("Xml", Chr(34) & "xml" & Chr(34))
        ucrInputFormat.SetItems(dctFormat)
        ucrInputFormat.SetRDefault(Chr(34) & "text" & Chr(34))
        ucrInputFormat.bAllowNonConditionValues = False

        ucrInputOutput.SetParameter(New RParameter("output", 1))
        ucrInputOutput.SetLinkedDisplayControl(lblOutput)
        ucrInputOutput.SetRDefault("word")


        ucrChkPunctuation.SetParameter(New RParameter("strip_punct", 6))
        ucrChkPunctuation.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkPunctuation.SetRDefault("TRUE")
        ucrChkPunctuation.SetText("Punctuation")

        ucrChkUrl.SetParameter(New RParameter("strip_url", 9))
        ucrChkUrl.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkUrl.SetRDefault("TRUE")
        ucrChkUrl.SetText("URL")

        ucrChkToLowerCase.SetText("To lower case")
        ucrChkToLowerCase.SetParameter(New RParameter("to_lower ", 5))
        ucrChkToLowerCase.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkToLowerCase.SetRDefault("TRUE")

        ucrInputPattern.SetParameter(New RParameter("pattern", 5))
        ucrInputPattern.SetLinkedDisplayControl(lblPattern)
        ttPattern.SetToolTip(ucrInputPattern.txtInput, " ""Chapter [\d]"" for regex token or "" "" ")

        ucrReceiverTextColumn.SetParameterIsRFunction()
        ucrReceiverTextColumn.Selector = ucrSelectorStack
        ucrReceiverTextColumn.SetLinkedDisplayControl(lblVariable)
        ucrReceiverTextColumn.SetParameter(New RParameter("input", 0))
        ucrReceiverTextColumn.strCurrDataType = "character"
        ucrReceiverTextColumn.SetDataType("character")

        ucrPnlStack.AddRadioButton(rdoUnnest)
        ucrPnlStack.AddRadioButton(rdoPivotLonger)
        ucrPnlStack.AddFunctionNamesCondition(rdoUnnest, "unnest_tokens")
        ucrPnlStack.AddFunctionNamesCondition(rdoPivotLonger, "pivot_longer")

        ucrInputToken.AddToLinkedControls(ucrInputPattern, {"Regex"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputToken.AddToLinkedControls(ucrChkPunctuation, {"Words", "Tweets"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputToken.AddToLinkedControls(ucrChkUrl, {"Tweets"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStack.AddToLinkedControls(ucrChkCarryColumns, {rdoPivotLonger}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlStack.AddToLinkedControls({ucrReceiverTextColumn, ucrInputOutput, ucrInputToken, ucrInputFormat, ucrChkToLowerCase}, {rdoUnnest}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStack.AddToLinkedControls({ucrInputNamesTo, ucrInputValuesTo, ucrReceiverColumnsToBeStack}, {rdoPivotLonger}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)


        ucrSaveNewDataName.SetSaveTypeAsDataFrame()
        ucrSaveNewDataName.SetDataFrameSelector(ucrSelectorStack.ucrAvailableDataFrames)
        ucrSaveNewDataName.SetLabelText("New Data Frame Name:")
        ucrSaveNewDataName.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        clsPivotLongerFunction = New RFunction
        clsUnnestTokensFunction = New RFunction
        clsSelectFunction = New RFunction
        clsPipeOperator = New ROperator

        ucrSelectorStack.Reset()
        ucrSaveNewDataName.Reset()
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()

        clsPivotLongerFunction.SetRCommand("pivot_longer")
        clsPivotLongerFunction.SetPackageName("tidyr")
        clsPivotLongerFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsUnnestTokensFunction.SetPackageName("tidytext")
        clsUnnestTokensFunction.SetRCommand("unnest_tokens")

        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.SetPackageName("dplyr")

        clsPipeOperator.SetOperation(" %>% ")
        clsPipeOperator.AddParameter("one", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsPipeOperator.AddParameter("two", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsPivotLongerFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveNewDataName.AddAdditionalRCode(clsPivotLongerFunction, iAdditionalPairNo:=1)

        ucrReceiverTextColumn.SetRCode(clsUnnestTokensFunction, bReset)
        ucrSelectorStack.SetRCode(clsUnnestTokensFunction, bReset)
        ucrSaveNewDataName.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputToken.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputFormat.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkToLowerCase.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputPattern.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkPunctuation.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkUrl.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputOutput.SetRCode(clsUnnestTokensFunction, bReset)
        ucrReceiverColumnsToBeStack.SetRCode(clsPivotLongerFunction, bReset)
        ucrInputNamesTo.SetRCode(clsPivotLongerFunction, bReset)
        ucrInputValuesTo.SetRCode(clsPivotLongerFunction, bReset)
        ucrChkCarryColumns.SetRCode(clsPivotLongerFunction, bReset)
        ucrPnlStack.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoUnnest.Checked Then
            If Not ucrReceiverTextColumn.IsEmpty AndAlso ucrInputOutput.GetText <> "" AndAlso ucrInputToken.GetText <> "" AndAlso ucrInputFormat.GetText <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else

        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetDataFrameName()
        If ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso (Not ucrSaveNewDataName.bUserTyped) Then
            ucrSaveNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
    End Sub

    Private Sub ucrSelectorStack_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorStack.ControlValueChanged
        SetDataFrameName()
    End Sub

    Private Sub AddColumnsSelected()
        If ucrChkCarryColumns.Checked AndAlso Not ucrReceiverColumnsToCarry.IsEmpty Then
            clsPivotLongerFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        Else
            clsPivotLongerFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        End If

        'comparing the list of colums to avoid duplication
        clsSelectFunction.ClearParameters()
        Dim iPosition As Integer = 0
        For Each strColumn In ucrReceiverColumnsToBeStack.GetVariableNamesAsList
            If Not ucrReceiverColumnsToCarry.GetVariableNamesAsList.Contains(strColumn) Then
                clsSelectFunction.AddParameter(strColumn, strColumn, iPosition:=iPosition, bIncludeArgumentName:=False)
                iPosition = iPosition + 1
            End If
        Next
        For Each strColumn In ucrReceiverColumnsToCarry.GetVariableNamesAsList
            If Not ucrReceiverColumnsToBeStack.GetVariableNamesAsList.Contains(strColumn) Then
                clsSelectFunction.AddParameter(strColumn, strColumn, iPosition:=iPosition, bIncludeArgumentName:=False)
                iPosition = iPosition + 1
            End If
        Next
    End Sub

    Private Sub CoreControls_ControlContentesChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToBeStack.ControlContentsChanged, ucrInputNamesTo.ControlContentsChanged, ucrInputValuesTo.ControlContentsChanged,
    ucrSaveNewDataName.ControlContentsChanged, ucrInputOutput.ControlContentsChanged, ucrReceiverTextColumn.ControlContentsChanged, ucrInputToken.ControlContentsChanged,
    ucrPnlStack.ControlContentsChanged, ucrInputFormat.ControlContentsChanged, ucrInputPattern.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlStack_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStack.ControlValueChanged
        If rdoUnnest.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsUnnestTokensFunction)
            ucrReceiverTextColumn.SetMeAsReceiver()
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsPivotLongerFunction)
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrChkCarryColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCarryColumns.ControlValueChanged
        If rdoPivotLonger.Checked AndAlso ucrChkCarryColumns.Checked Then
            ucrReceiverColumnsToCarry.SetMeAsReceiver()
        Else
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        End If

        AddColumnsSelected()
    End Sub

    Private Sub Receiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToBeStack.ControlValueChanged, ucrReceiverColumnsToCarry.ControlValueChanged
        AddColumnsSelected()
    End Sub
End Class
