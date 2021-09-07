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

        ucrColumnsToCarryReceiver.SetParameter(New RParameter("id.vars", 1))
        ucrColumnsToCarryReceiver.Selector = ucrSelectorStack
        ucrColumnsToCarryReceiver.SetParameterIsString()
        ucrColumnsToCarryReceiver.bAddRemoveParameter = False
        ucrColumnsToCarryReceiver.SetValuesToIgnore({"NULL"})

        ucrReceiverColumnsToBeStack.SetParameter(New RParameter("cols", 2))
        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrReceiverColumnsToBeStack.SetParameterIsString()

        ucrInputNamesTo.SetParameter(New RParameter("names_to", 3))
        ucrInputNamesTo.SetRDefault(Chr(34) & "names" & Chr(34))
        ucrInputNamesTo.SetLinkedDisplayControl(lblNamesTo)

        ucrStackDataInto.SetParameter(New RParameter("value.name", 4))
        ucrStackDataInto.SetValidationTypeAsRVariable()
        ucrStackDataInto.SetRDefault(Chr(34) & "value" & Chr(34))
        ucrStackDataInto.SetLinkedDisplayControl(lblStackDataInto)

        ucrInputToken.SetLinkedDisplayControl(lblToken)
        ucrInputToken.SetParameter(New RParameter("token", 3))
        dctToken.Add("words", Chr(34) & "words" & Chr(34))
        dctToken.Add("characters", Chr(34) & " characters" & (34))
        dctToken.Add("character_shingles", Chr(34) & "character_shingles" & Chr(34))
        dctToken.Add("ngrams", Chr(34) & "ngrams" & Chr(34))
        dctToken.Add("skip_ngrams", Chr(34) & "skip_ngrams" & Chr(34))
        dctToken.Add("sentences", Chr(34) & "sentences" & Chr(34))
        dctToken.Add("lines", Chr(34) & "lines" & Chr(34))
        dctToken.Add("paragraphs", Chr(34) & "paragraphs" & Chr(34))
        dctToken.Add("regex", Chr(34) & "regex" & Chr(34))
        dctToken.Add("tweets", Chr(34) & "tweets" & Chr(34))
        dctToken.Add("ptb", Chr(34) & "ptb" & Chr(34))
        ucrInputToken.SetItems(dctToken)
        ucrInputToken.SetRDefault(Chr(34) & "words" & Chr(34))

        ucrInputFormat.SetParameter(New RParameter("format", 4))
        ucrInputFormat.SetLinkedDisplayControl(lblFormat)
        dctFormat.Add("text", Chr(34) & "text" & Chr(34))
        dctFormat.Add("man", Chr(34) & "man" & Chr(34))
        dctFormat.Add("latex", Chr(34) & "latex" & Chr(34))
        dctFormat.Add("html", Chr(34) & "html" & Chr(34))
        dctFormat.Add("xml", Chr(34) & "xml" & Chr(34))
        ucrInputFormat.SetItems(dctFormat)
        ucrInputFormat.SetRDefault(Chr(34) & "text" & Chr(34))
        ucrInputFormat.bAllowNonConditionValues = False

        ucrInputOutput.SetParameter(New RParameter("ouput", 1))
        ucrInputOutput.SetLinkedDisplayControl(lblOutput)
        ucrInputOutput.SetRDefault("word")


        ucrChkPunctuation.SetParameter(New RParameter("strip_punct", 6))
        ucrChkPunctuation.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkPunctuation.SetRDefault("TRUE")
        ucrChkPunctuation.SetText("Punctuation")


        ucrChkNonAlphanum.SetParameter(New RParameter("strip_non_alphanum", 7))
        ucrChkNonAlphanum.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkNonAlphanum.SetRDefault("TRUE")
        ucrChkNonAlphanum.SetText("Non-Alphanumeric")

        ucrChkNumeric.SetParameter(New RParameter("strip_numeric", 8))
        ucrChkNumeric.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkNumeric.SetRDefault("TRUE")
        ucrChkNumeric.SetText("Numeric")

        ucrChkUrl.SetParameter(New RParameter("strip_url", 9))
        ucrChkUrl.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkUrl.SetRDefault("TRUE")
        ucrChkUrl.SetText("URL")

        ucrChkToLowerCase.SetText("To Lower Case")
        ucrChkToLowerCase.SetParameter(New RParameter("to_lower ", 5))
        ucrChkToLowerCase.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkToLowerCase.SetRDefault("TRUE")

        ucrInputPattern.SetParameter(New RParameter("pattern", 5))
        ucrInputPattern.SetLinkedDisplayControl(lblPattern)

        ttPattern.SetToolTip(ucrInputPattern, " ""Chapter [\d]"" for regex token or "" "" ")

        ucrReceiverTextColumn.SetParameterIsRFunction()
        ucrReceiverTextColumn.SetParameter(New RParameter("input", 0))
        ucrReceiverTextColumn.strCurrDataType = "character"

        ucrPnlStack.AddRadioButton(rdoUnnest)
        ucrPnlStack.AddRadioButton(rdoPivotLonger)
        ucrPnlStack.AddFunctionNamesCondition(rdoUnnest, "unnest_tokens")
        ucrPnlStack.AddFunctionNamesCondition(rdoPivotLonger, "pivot_longer")

        ucrPnlStack.AddToLinkedControls({ucrChkPunctuation, ucrChkNumeric, ucrChkNonAlphanum, ucrChkUrl, ucrInputOutput, ucrInputToken, ucrInputFormat, ucrChkToLowerCase}, {rdoUnnest}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlStack.AddToLinkedControls({ucrInputNamesTo}, {rdoPivotLonger}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrSaveNewDataName.SetSaveTypeAsDataFrame()
        ucrSaveNewDataName.SetDataFrameSelector(ucrSelectorStack.ucrAvailableDataFrames)
        ucrSaveNewDataName.SetLabelText("New Data Frame Name:")
        ucrSaveNewDataName.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        clsPivotLongerFunction = New RFunction
        clsUnnestTokensFunction = New RFunction

        ucrSelectorStack.Reset()
        ucrSaveNewDataName.Reset()
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()

        clsPivotLongerFunction.SetRCommand("pivot_longer")
        clsPivotLongerFunction.SetPackageName("tidyr")

        clsUnnestTokensFunction.SetPackageName("tidytext")
        clsUnnestTokensFunction.SetRCommand("unnest_tokens")

        ucrBase.clsRsyntax.SetBaseRFunction(clsPivotLongerFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorStack.AddAdditionalCodeParameterPair(clsPivotLongerFunction, New RParameter("data", 0), iAdditionalPairNo:=1)
        ucrSaveNewDataName.AddAdditionalRCode(clsPivotLongerFunction, iAdditionalPairNo:=1)

        ucrReceiverTextColumn.SetRCode(clsUnnestTokensFunction, bReset)
        ucrSelectorStack.SetRCode(clsUnnestTokensFunction, bReset)
        ucrSaveNewDataName.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputToken.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputFormat.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkToLowerCase.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputPattern.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkPunctuation.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkNonAlphanum.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkNumeric.SetRCode(clsUnnestTokensFunction, bReset)
        ucrChkUrl.SetRCode(clsUnnestTokensFunction, bReset)
        ucrInputOutput.SetRCode(clsUnnestTokensFunction, bReset)
        ucrReceiverColumnsToBeStack.SetRCode(clsPivotLongerFunction, bReset)
        ucrInputNamesTo.SetRCode(clsPivotLongerFunction, bReset)

        ucrPnlStack.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveNewDataName.IsComplete AndAlso Not ucrStackDataInto.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

        If ucrSaveNewDataName.IsComplete AndAlso Not ucrStackDataInto.IsEmpty() AndAlso Not ucrInputNamesTo.IsEmpty() Then
            If Not ucrChkCarryColumns.Checked Then
                If Not ucrReceiverColumnsToBeStack.IsEmpty() Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                If Not ucrColumnsToCarryReceiver.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
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

    Private Sub CoreControls_ControlContentesChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToBeStack.ControlContentsChanged, ucrStackDataInto.ControlContentsChanged, ucrInputNamesTo.ControlContentsChanged, ucrSaveNewDataName.ControlContentsChanged, ucrColumnsToCarryReceiver.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlStack_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStack.ControlValueChanged
        If rdoUnnest.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsUnnestTokensFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsPivotLongerFunction)
        End If
    End Sub
End Class
