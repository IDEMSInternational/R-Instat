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
    Private clsReshapeFunction As RFunction
    Private clsSplitColumnsFunction As RFunction
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
        ucrBase.iHelpTopicID = 57
        Dim dctToken As New Dictionary(Of String, String)
        Dim dctFormat As New Dictionary(Of String, String)

        ucrPnlStack.AddRadioButton(rdoUnnest)
        ucrPnlStack.AddRadioButton(rdoPivotLonger)
        ucrPnlStack.AddFunctionNamesCondition(rdoUnnest, "unnest_tokens")
        ucrPnlStack.AddFunctionNamesCondition(rdoPivotLonger, {"pivot_longer", "reshape"})

        ucrSelectorStack.SetParameter(New RParameter("tbl", 0))
        ucrSelectorStack.SetParameterIsrfunction()

        ucrReceiverColumnsToCarry.Selector = ucrSelectorStack
        ucrReceiverColumnsToCarry.SetParameterIsString()
        ucrReceiverColumnsToCarry.SetValuesToIgnore({"NULL"})

        ucrReceiverColumnsToBeStack.SetParameter(New RParameter("cols", 2))
        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrReceiverColumnsToBeStack.SetParameterIsString()

        ucrInputNamesTo.SetParameter(New RParameter("names_to", 3))
        ucrInputNamesTo.SetRDefault(Chr(34) & "names" & Chr(34))

        ucrChkDropMissingValues.SetParameter(New RParameter("values_drop_na", 5))
        ucrChkDropMissingValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropMissingValues.SetRDefault("FALSE")
        ucrChkDropMissingValues.SetText("Drop Missing Values")

        ucrChkStackMultipleSets.SetText("Stack Multiple Column Sets")
        ucrChkStackMultipleSets.AddToLinkedControls(ucrNudNoSets, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddToLinkedControls(ucrFactorInto, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddToLinkedControls(ucrChkCarryColumns, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddToLinkedControls(ucrChkCarryAllColumns, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddToLinkedControls(ucrInputValuesTo, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddToLinkedControls(ucrChkDropMissingValues, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddToLinkedControls(ucrChkDropPrefix, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddToLinkedControls(ucrInputDropPrefix, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddToLinkedControls(ucrInputNamesTo, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkStackMultipleSets.AddFunctionNamesCondition(True, "reshape")
        ucrChkStackMultipleSets.AddFunctionNamesCondition(False, "pivot_longer")

        ucrNudNoSets.SetParameter(New RParameter("num", 1))
        ucrNudNoSets.Minimum = 2
        ucrNudNoSets.SetLinkedDisplayControl(lblSets)

        ucrFactorInto.SetParameter(New RParameter("timevar", 3))
        ucrFactorInto.SetRDefault("variable")
        ucrFactorInto.SetLinkedDisplayControl(lblFactorInto)

        ucrChkCarryColumns.SetText("Columns to Carry")
        ucrChkCarryColumns.AddToLinkedControls(ucrReceiverColumnsToCarry, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputValuesTo.SetParameter(New RParameter(" values_to", 4))
        ucrInputValuesTo.SetRDefault(Chr(34) & "value" & Chr(34))

        ucrInputToken.SetParameter(New RParameter("token", 3))
        dctToken.Add("Words", Chr(34) & "words" & Chr(34))
        dctToken.Add("Characters", Chr(34) & " characters" & (34))
        dctToken.Add("Character shingles", Chr(34) & "character_shingles" & Chr(34))
        dctToken.Add("Ngrams", Chr(34) & "ngrams" & Chr(34))
        dctToken.Add("Skip ngrams", Chr(34) & "skip_ngrams" & Chr(34))
        dctToken.Add("Sentences", Chr(34) & "sentences" & Chr(34))
        dctToken.Add("Lines", Chr(34) & "lines" & Chr(34))
        dctToken.Add("Paragraphs", Chr(34) & "paragraphs" & Chr(34))
        dctToken.Add("Regex", Chr(34) & "regex" & Chr(34))
        dctToken.Add("Tweets", Chr(34) & "tweets" & Chr(34))
        dctToken.Add("Penn treebank", Chr(34) & "ptb" & Chr(34))
        ucrInputToken.SetItems(dctToken)
        ucrInputToken.SetRDefault(Chr(34) & "words" & Chr(34))

        ucrInputFormat.SetParameter(New RParameter("format", 4))

        dctFormat.Add("Text", Chr(34) & "text" & Chr(34))
        dctFormat.Add("Man", Chr(34) & "man" & Chr(34))
        dctFormat.Add("Latex", Chr(34) & "latex" & Chr(34))
        dctFormat.Add("Html", Chr(34) & "html" & Chr(34))
        dctFormat.Add("Xml", Chr(34) & "xml" & Chr(34))
        ucrInputFormat.SetItems(dctFormat)
        ucrInputFormat.SetRDefault(Chr(34) & "text" & Chr(34))
        ucrInputFormat.bAllowNonConditionValues = False

        ucrInputOutput.SetParameter(New RParameter("output", 1))
        ucrInputOutput.SetRDefault("word")

        ucrChkPunctuation.SetParameter(New RParameter("strip_punct", 6))
        ucrChkPunctuation.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkPunctuation.SetRDefault("TRUE")
        ucrChkPunctuation.SetText("Punctuation")

        ucrChkUrl.SetParameter(New RParameter("strip_url", 9))
        ucrChkUrl.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkUrl.SetRDefault("TRUE")
        ucrChkUrl.SetText("URL")

        ucrChkToLowerCase.SetText("To Lower Case")
        ucrChkToLowerCase.SetParameter(New RParameter("to_lower ", 5))
        ucrChkToLowerCase.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkToLowerCase.SetRDefault("TRUE")

        ucrInputPattern.SetParameter(New RParameter("pattern", 5))

        ucrReceiverTextColumn.SetParameter(New RParameter("input", 0))
        ucrReceiverTextColumn.SetParameterIsRFunction()
        ucrReceiverTextColumn.Selector = ucrSelectorStack
        ucrReceiverTextColumn.strSelectorHeading = "Characters"
        ucrReceiverTextColumn.SetDataType("character")

        ucrChkCarryAllColumns.SetText("Carry All Columns")
        ucrChkCarryAllColumns.AddParameterIsROperatorCondition(True, "%>%", False)
        ucrChkCarryAllColumns.AddParameterIsROperatorCondition(False, "%>%", True)

        ucrChkDropPrefix.SetText("Drop Prefix:")
        ucrChkDropPrefix.AddParameterPresentCondition(True, "names_prefix")
        ucrChkDropPrefix.AddParameterPresentCondition(False, "names_prefix", False)

        ucrInputDropPrefix.SetParameter(New RParameter("names_prefix", 6))
        ucrInputDropPrefix.SetValuesToIgnore({"NULL"})

        ucrInputToken.AddToLinkedControls(ucrInputPattern, {"Regex"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputToken.AddToLinkedControls(ucrChkPunctuation, {"Words", "Tweets"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputToken.AddToLinkedControls(ucrChkUrl, {"Tweets"}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStack.AddToLinkedControls({ucrChkCarryColumns, ucrChkCarryAllColumns}, {rdoPivotLonger}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStack.AddToLinkedControls({ucrReceiverTextColumn, ucrInputOutput, ucrInputToken, ucrInputFormat, ucrChkToLowerCase}, {rdoUnnest}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStack.AddToLinkedControls({ucrInputNamesTo, ucrChkDropMissingValues, ucrFactorInto, ucrInputValuesTo, ucrChkStackMultipleSets, ucrReceiverColumnsToBeStack}, {rdoPivotLonger}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkDropPrefix.AddToLinkedControls(ucrInputDropPrefix, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStack.AddToLinkedControls(ucrChkDropPrefix, {rdoPivotLonger}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)

        ucrReceiverTextColumn.SetLinkedDisplayControl(lblVariable)
        ucrReceiverColumnsToBeStack.SetLinkedDisplayControl(lblColumnsTostack)
        ucrInputNamesTo.SetLinkedDisplayControl(lblNamesTo)
        ucrInputValuesTo.SetLinkedDisplayControl(lblValuesTo)
        ucrInputToken.SetLinkedDisplayControl(lblToken)
        ucrInputFormat.SetLinkedDisplayControl(lblFormat)
        ucrInputOutput.SetLinkedDisplayControl(lblOutput)
        ucrInputPattern.SetLinkedDisplayControl(lblPattern)

        ttPattern.SetToolTip(ucrInputPattern.txtInput, " ""Chapter [\d]"" for regex token or "" "" ")

        ucrSaveNewDataName.SetSaveTypeAsDataFrame()
        ucrSaveNewDataName.SetDataFrameSelector(ucrSelectorStack.ucrAvailableDataFrames)
        ucrSaveNewDataName.SetLabelText("New Data Frame Name:")
        ucrSaveNewDataName.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        clsPivotLongerFunction = New RFunction
        clsUnnestTokensFunction = New RFunction
        clsSelectFunction = New RFunction
        clsReshapeFunction = New RFunction
        clsSplitColumnsFunction = New RFunction
        clsPipeOperator = New ROperator

        ucrSelectorStack.Reset()
        ucrSaveNewDataName.Reset()
        ucrChkCarryColumns.Checked = False 'Note: This checkbox doesn't read from R code therefore setting its default state automatically isn't straightforward as such!
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()

        clsPivotLongerFunction.SetRCommand("pivot_longer")
        clsPivotLongerFunction.SetPackageName("tidyr")

        clsUnnestTokensFunction.SetPackageName("tidytext")
        clsUnnestTokensFunction.SetRCommand("unnest_tokens")

        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.SetPackageName("dplyr")

        clsReshapeFunction.SetPackageName("stats")
        clsReshapeFunction.SetRCommand("reshape")
        clsReshapeFunction.SetAssignTo(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked", strTempDataframe:=ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        clsReshapeFunction.AddParameter("direction", Chr(34) & "long" & Chr(34), iPosition:=4)

        clsSplitColumnsFunction.SetRCommand("split_items_in_groups")
        clsSplitColumnsFunction.AddParameter("num", 2)

        clsReshapeFunction.AddParameter("varying", clsRFunctionParameter:=clsSplitColumnsFunction, iPosition:=1)

        clsPipeOperator.SetOperation(" %>% ")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsPivotLongerFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverColumnsToBeStack.AddAdditionalCodeParameterPair(clsSplitColumnsFunction, New RParameter("items", 0), iAdditionalPairNo:=1)
        ucrSelectorStack.AddAdditionalCodeParameterPair(clsReshapeFunction, New RParameter("data", ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame, 0), iAdditionalPairNo:=1)
        ucrChkStackMultipleSets.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrNudNoSets.SetRCode(clsSplitColumnsFunction, bReset)

        ucrReceiverTextColumn.SetRCode(clsUnnestTokensFunction, bReset)
        ucrSelectorStack.SetRCode(clsUnnestTokensFunction, bReset)
        ucrSaveNewDataName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputToken.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputFormat.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkToLowerCase.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputPattern.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkPunctuation.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkUrl.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputOutput.SetRCode(clsUnnestTokensFunction, bReset)
        ucrReceiverColumnsToBeStack.SetRCode(clsPivotLongerFunction, bReset)
        ucrInputNamesTo.SetRCode(clsPivotLongerFunction, bReset)
        ucrChkDropMissingValues.SetRCode(clsPivotLongerFunction, bReset)
        ucrInputValuesTo.SetRCode(clsPivotLongerFunction, bReset)
        ucrPnlStack.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkCarryAllColumns.SetRCode(clsPivotLongerFunction, bReset)
        ucrInputDropPrefix.SetRCode(clsPivotLongerFunction, bReset)
        ucrChkDropPrefix.SetRCode(clsPivotLongerFunction, bReset)
        ucrFactorInto.SetRCode(clsReshapeFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoUnnest.Checked Then
            If ucrReceiverTextColumn.IsEmpty OrElse ucrInputOutput.IsEmpty OrElse
                ucrInputToken.IsEmpty OrElse
                ucrInputFormat.IsEmpty OrElse Not ucrSaveNewDataName.IsComplete Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            If ucrReceiverColumnsToBeStack.IsEmpty OrElse Not ucrSaveNewDataName.IsComplete OrElse
                ucrInputNamesTo.IsEmpty OrElse ucrInputValuesTo.IsEmpty OrElse
                ucrFactorInto.IsEmpty OrElse
                (ucrReceiverColumnsToCarry.IsEmpty AndAlso ucrChkCarryColumns.Checked) Then
                ucrBase.OKEnabled(False)
            Else
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorStack_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorStack.ControlValueChanged
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        SetDataFramePrefix()
    End Sub

    Private Sub SetDataFramePrefix()
        Dim strDataframeName As String = ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        If ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso (Not ucrSaveNewDataName.bUserTyped) Then
            If rdoPivotLonger.Checked Then
                ucrSaveNewDataName.SetPrefix(strDataframeName & "_stacked")
            Else
                ucrSaveNewDataName.SetPrefix(strDataframeName & "_unnest")
            End If
        End If
    End Sub

    Private Sub ucrPnlStack_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStack.ControlValueChanged
        SetDataFramePrefix()
        If rdoUnnest.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsUnnestTokensFunction)
            ucrReceiverTextColumn.SetMeAsReceiver()
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsPivotLongerFunction)
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrChkCarryColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCarryColumns.ControlValueChanged,
    ucrReceiverColumnsToBeStack.ControlValueChanged, ucrReceiverColumnsToCarry.ControlValueChanged
        clsSelectFunction.ClearParameters()
        Dim iPosition As Integer = 0
        For Each strColumn In ucrReceiverColumnsToBeStack.GetVariableNamesAsList
            clsSelectFunction.AddParameter(strColumn, strColumn, iPosition:=iPosition, bIncludeArgumentName:=False)
            iPosition = iPosition + 1
        Next
        If ucrChkCarryColumns.Checked Then
            ucrChkCarryAllColumns.Checked = False
            ucrChkCarryAllColumns.Enabled = False
            ucrReceiverColumnsToCarry.SetMeAsReceiver()
            For Each strColumn In ucrReceiverColumnsToCarry.GetVariableNamesAsList
                If Not ucrReceiverColumnsToBeStack.GetVariableNamesAsList.Contains(strColumn) Then
                    clsSelectFunction.AddParameter(strColumn, strColumn, iPosition:=iPosition, bIncludeArgumentName:=False)
                    iPosition = iPosition + 1
                End If
            Next
        Else
            ucrChkCarryAllColumns.Enabled = True
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        End If
        AddRemoveDataOrPipeOperator()
    End Sub

    Private Sub AddRemoveDataOrPipeOperator()
        If ucrChkCarryAllColumns.Checked Then
            clsPivotLongerFunction.RemoveParameterByName("%>%")
            clsPivotLongerFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        Else
            clsPivotLongerFunction.RemoveParameterByName("data")
            clsPivotLongerFunction.AddParameter("%>%", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub ucrChkCarryAllColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCarryAllColumns.ControlValueChanged
        AddRemoveDataOrPipeOperator()
    End Sub

    Private Sub CoreControls_ControlContentesChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToBeStack.ControlContentsChanged, ucrInputNamesTo.ControlContentsChanged, ucrInputValuesTo.ControlContentsChanged,
    ucrSaveNewDataName.ControlContentsChanged, ucrInputOutput.ControlContentsChanged, ucrReceiverTextColumn.ControlContentsChanged, ucrInputToken.ControlContentsChanged, ucrInputDropPrefix.ControlContentsChanged, ucrFactorInto.ControlContentsChanged,
    ucrPnlStack.ControlContentsChanged, ucrInputFormat.ControlContentsChanged, ucrInputPattern.ControlContentsChanged, ucrChkCarryColumns.ControlContentsChanged, ucrReceiverColumnsToCarry.ControlContentsChanged, ucrChkDropMissingValues.ControlContentsChanged, ucrChkDropPrefix.ControlContentsChanged, ucrChkStackMultipleSets.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkStackMultipleSets_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStackMultipleSets.ControlValueChanged
        If ucrChkStackMultipleSets.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReshapeFunction)
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsPivotLongerFunction)
        End If
        TestOKEnabled()
    End Sub
End Class