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

Public Class dlgTransformText
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsConvertFunction, clsLengthFunction, clsPadFunction, clsTrimFunction, clsWordsFunction, clsSubstringFunction, clsFixedFunction As New RFunction
    Private bRCodeSet As Boolean = True

    Private Sub dlgTransformText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctInputPad As New Dictionary(Of String, String)
        Dim dctInputSeparator As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 343
        ucrBase.clsRsyntax.bUseBaseFunction = True

        'ucrReceiver
        ucrReceiverTransformText.SetParameter(New RParameter("string", 0))
        ucrReceiverTransformText.SetParameterIsRFunction()
        ucrReceiverTransformText.Selector = ucrSelectorForTransformText
        ucrReceiverTransformText.bUseFilteredData = False
        ucrReceiverTransformText.SetMeAsReceiver()
        ucrReceiverTransformText.SetIncludedDataTypes({"factor", "character"})
        ucrReceiverTransformText.strSelectorHeading = "Characters"

        'ucrRdoOptions
        ucrPnlOperation.AddRadioButton(rdoConvertCase)
        ucrPnlOperation.AddRadioButton(rdoLength)
        ucrPnlOperation.AddRadioButton(rdoPad)
        ucrPnlOperation.AddRadioButton(rdoTrim)
        ucrPnlOperation.AddRadioButton(rdoWords)
        ucrPnlOperation.AddRadioButton(rdoSubstring)

        ucrPnlOperation.AddFunctionNamesCondition(rdoConvertCase, {"str_to_lower", "str_to_upper", "str_to_title"})
        ucrPnlOperation.AddFunctionNamesCondition(rdoLength, "str_length")
        ucrPnlOperation.AddFunctionNamesCondition(rdoPad, "str_pad")
        ucrPnlOperation.AddFunctionNamesCondition(rdoTrim, "str_trim")
        ucrPnlOperation.AddFunctionNamesCondition(rdoWords, "word")
        ucrPnlOperation.AddFunctionNamesCondition(rdoSubstring, "str_sub")

        'rdoConvertCase
        ucrPnlOperation.AddToLinkedControls(ucrInputTo, {rdoConvertCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputTo
        ucrInputTo.SetItems({"Lower", "Upper", "Title"})
        ucrInputTo.AddFunctionNamesCondition("Lower", "str_to_lower")
        ucrInputTo.AddFunctionNamesCondition("Upper", "str_to_upper")
        ucrInputTo.AddFunctionNamesCondition("Title", "str_to_title")
        ucrInputTo.SetLinkedDisplayControl(lblTo)
        ucrInputTo.SetDropDownStyleAsNonEditable()

        'rdoPad
        ucrPnlOperation.AddToLinkedControls(ucrInputPad, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudWidth, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputPad
        ucrInputPad.SetParameter(New RParameter("pad", 3))
        dctInputPad.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctInputPad.Add("Hash #", Chr(34) & "#" & Chr(34))
        dctInputPad.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctInputPad.Add("Period .", Chr(34) & "." & Chr(34))
        dctInputPad.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputPad.SetItems(dctInputPad)
        ucrInputPad.SetLinkedDisplayControl(lblPad)
        ucrInputPad.SetRDefault(Chr(34) & " " & Chr(34))
        ucrInputPad.bAllowNonConditionValues = True

        'ucrNudWidth
        ucrNudWidth.SetParameter(New RParameter("width", 1))
        ucrNudWidth.SetLinkedDisplayControl(lblWidth)

        'rdoTrim, rdoPad
        ucrPnlOperation.AddToLinkedControls(ucrPnlPad, {rdoPad, rdoTrim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPad.SetParameter(New RParameter("side", 2))
        ucrPnlPad.AddRadioButton(rdoLeftPad, Chr(34) & "left" & Chr(34))
        ucrPnlPad.AddRadioButton(rdoRightPad, Chr(34) & "right" & Chr(34))
        ucrPnlPad.AddRadioButton(rdoBothPad, Chr(34) & "both" & Chr(34))
        ucrPnlPad.SetRDefault(Chr(34) & "left" & Chr(34))

        'rdoWords
        ucrPnlOperation.AddToLinkedControls(ucrChkFirstOr, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrChkLastOr, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFirstOr.AddToLinkedControls(ucrNudFirstWord, {False}, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFirstOr.AddToLinkedControls(ucrReceiverFirstWord, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLastOr.AddToLinkedControls(ucrNudLastWord, {False}, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkLastOr.AddToLinkedControls(ucrReceiverLastWord, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrInputSeparator, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrChkFirstOr
        ucrNudFirstWord.SetParameter(New RParameter("start", 1))
        ucrNudFirstWord.SetLinkedDisplayControl(lblFirstWord)

        ucrReceiverFirstWord.SetParameter(New RParameter("start", 1))
        ucrReceiverFirstWord.SetParameterIsRFunction()
        ucrReceiverFirstWord.Selector = ucrSelectorForTransformText
        ucrReceiverFirstWord.bUseFilteredData = False
        ucrReceiverFirstWord.SetIncludedDataTypes({"numeric"})

        ucrChkFirstOr.SetText("Or Column")
        ucrChkFirstOr.AddParameterIsStringCondition(False, "start", True)
        ucrChkFirstOr.AddParameterIsRFunctionCondition(True, "start", True)

        'ucrChkLastOr
        ucrNudLastWord.SetParameter(New RParameter("end", 2))
        ucrNudLastWord.SetLinkedDisplayControl(lblLastWord)

        ucrReceiverLastWord.SetParameter(New RParameter("end", 2))
        ucrReceiverLastWord.SetParameterIsRFunction()
        ucrReceiverLastWord.Selector = ucrSelectorForTransformText
        ucrReceiverLastWord.bUseFilteredData = False
        ucrReceiverLastWord.SetIncludedDataTypes({"numeric"})

        ucrChkLastOr.SetText("Or Column")
        ucrChkLastOr.AddParameterIsStringCondition(False, "start", True)
        ucrChkLastOr.AddParameterIsRFunctionCondition(True, "start", True)

        ' ucrInputSeparator
        ucrInputSeparator.SetParameter(New RParameter("pattern", 3))
        dctInputSeparator.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctInputSeparator.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctInputSeparator.Add("Period .", Chr(34) & "." & Chr(34))
        dctInputSeparator.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputSeparator.SetItems(dctInputSeparator)
        ucrInputSeparator.SetLinkedDisplayControl(lblSeparator)
        ucrInputSeparator.bAllowNonConditionValues = True

        'rdoSubstring
        ucrPnlOperation.AddToLinkedControls(ucrNudFrom, {rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudTo, {rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrNuds
        ucrNudFrom.SetParameter(New RParameter("start", 1))
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)

        ucrNudTo.SetParameter(New RParameter("end", 2))
        ucrNudTo.SetLinkedDisplayControl(lblToSubstring)

        'ucrNewColName
        ucrNewColName.SetIsTextBox()
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetDataFrameSelector(ucrSelectorForTransformText.ucrAvailableDataFrames)
        ucrNewColName.SetLabelText("Column Name:")
        DialogSize()
    End Sub

    Private Sub SetDefaults()
        clsConvertFunction = New RFunction
        clsLengthFunction = New RFunction
        clsPadFunction = New RFunction
        clsTrimFunction = New RFunction
        clsWordsFunction = New RFunction
        clsSubstringFunction = New RFunction
        clsFixedFunction = New RFunction

        ucrNewColName.Reset()
        ucrSelectorForTransformText.Reset()

        NewDefaultName()
        clsConvertFunction.SetPackageName("stringr")
        clsConvertFunction.SetRCommand("str_to_lower")
        clsConvertFunction.SetAssignTo(ucrNewColName.GetText(), strTempDataframe:=ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)

        clsLengthFunction.SetPackageName("stringr")
        clsLengthFunction.SetRCommand("str_length")

        clsPadFunction.SetPackageName("stringr")
        clsPadFunction.SetRCommand("str_pad")
        clsPadFunction.AddParameter("pad", Chr(34) & " " & Chr(34))
        clsPadFunction.AddParameter("side", Chr(34) & "left" & Chr(34))
        clsPadFunction.AddParameter("width", 1)

        clsTrimFunction.SetPackageName("stringr")
        clsTrimFunction.SetRCommand("str_trim")
        clsTrimFunction.AddParameter("side", Chr(34) & "left" & Chr(34))
        clsFixedFunction.AddParameter("pattern", strParameterValue:=Chr(34) & " " & Chr(34))
        clsWordsFunction.SetPackageName("stringr")
        clsWordsFunction.SetRCommand("word")
        clsWordsFunction.AddParameter("start", 1)
        clsWordsFunction.AddParameter("end", 2)
        clsFixedFunction.SetPackageName("stringr")
        clsFixedFunction.SetRCommand("fixed")
        clsWordsFunction.AddParameter("sep", clsRFunctionParameter:=clsFixedFunction)

        clsSubstringFunction.SetPackageName("stringr")
        clsSubstringFunction.SetRCommand("str_sub")
        clsSubstringFunction.AddParameter("start", 1)
        clsSubstringFunction.AddParameter("end", 2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsConvertFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrReceiverTransformText.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrNewColName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlOperation.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrInputTo.SetRCode(clsConvertFunction, bReset)
        ucrInputPad.SetRCode(clsPadFunction, bReset)
        ucrPnlPad.SetRCode(clsPadFunction, bReset)
        ucrNudWidth.SetRCode(clsPadFunction, bReset)
        ucrPnlPad.SetRCode(clsTrimFunction, bReset)
        ucrChkFirstOr.SetRCode(clsWordsFunction, bReset)
        ucrChkLastOr.SetRCode(clsWordsFunction, bReset)
        ucrReceiverFirstWord.SetRCode(clsWordsFunction, bReset)
        ucrReceiverLastWord.SetRCode(clsWordsFunction, bReset)
        ucrNudFirstWord.SetRCode(clsWordsFunction, bReset)
        ucrNudLastWord.SetRCode(clsWordsFunction, bReset)
        ucrInputSeparator.SetRCode(clsFixedFunction, bReset)
        ucrNudFrom.SetRCode(clsSubstringFunction, bReset)
        ucrNudTo.SetRCode(clsSubstringFunction, bReset)

        bRCodeSet = True
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverTransformText.IsEmpty()) AndAlso ucrNewColName.IsComplete() Then
            If rdoConvertCase.Checked Then
                If Not ucrInputTo.IsEmpty() Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoLength.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoPad.Checked Then
                If Not ucrInputPad.IsEmpty() AndAlso ucrNudWidth.GetText <> "" Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoTrim.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoWords.Checked Then
                If Not ucrInputSeparator.IsEmpty() AndAlso ((ucrNudFirstWord.GetText <> "" AndAlso Not ucrChkFirstOr.Checked) OrElse (ucrChkFirstOr.Checked AndAlso Not ucrReceiverFirstWord.IsEmpty)) AndAlso ((ucrNudLastWord.GetText <> "" AndAlso Not ucrChkLastOr.Checked) OrElse (ucrChkLastOr.Checked AndAlso Not ucrReceiverLastWord.IsEmpty)) Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoSubstring.Checked Then
                If ucrNudTo.GetText <> "" AndAlso ucrNudFrom.GetText <> "" Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrNewColName.bUserTyped) AndAlso Not ucrReceiverTransformText.IsEmpty Then
            ucrNewColName.SetName(ucrReceiverTransformText.GetVariableNames(bWithQuotes:=False) & "_transformed")
        End If
    End Sub

    Private Sub DialogSize()
        If rdoConvertCase.Checked OrElse rdoTrim.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(397, 57)
            ucrNewColName.Location = New Point(10, 301)
            ucrBase.Location = New Point(10, 326)
            Me.Size = New Size(435, 422)
        ElseIf rdoLength.Checked Then
            grpParameters.Visible = False
            ucrNewColName.Location = New Point(10, 237)
            ucrBase.Location = New Point(10, 262)
            Me.Size = New Size(435, 357)
        ElseIf rdoSubstring.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(397, 81)
            ucrNewColName.Location = New Point(10, 327)
            ucrBase.Location = New Point(10, 352)
            Me.Size = New Size(435, 448)
        ElseIf rdoPad.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(397, 121)
            ucrNewColName.Location = New Point(10, 365)
            ucrBase.Location = New Point(10, 390)
            Me.Size = New Size(435, 486)
        Else
            grpParameters.Visible = True
            grpParameters.Size = New Size(397, 173)
            ucrNewColName.Location = New Point(10, 417)
            ucrBase.Location = New Point(10, 442)
            Me.Size = New Size(435, 537)
        End If
    End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOperation.ControlValueChanged, ucrInputTo.ControlValueChanged
        If bRCodeSet Then
            If rdoLength.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsLengthFunction)
            ElseIf rdoPad.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsPadFunction)
            ElseIf rdoTrim.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsTrimFunction)
            ElseIf rdoWords.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsWordsFunction)
            ElseIf rdoSubstring.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsSubstringFunction)
            ElseIf rdoConvertCase.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsConvertFunction)
                Select Case ucrInputTo.GetText
                    Case "Lower"
                        ucrBase.clsRsyntax.SetFunction("str_to_lower")
                    Case "Upper"
                        ucrBase.clsRsyntax.SetFunction("str_to_upper")
                    Case "Title"
                        ucrBase.clsRsyntax.SetFunction("str_to_title")
                End Select
            End If
            TestOkEnabled()
            SetRCodeForControls(False)
        End If
    End Sub

    Private Sub ucrWordsTab_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFirstOr.ControlValueChanged, ucrChkLastOr.ControlValueChanged, ucrPnlOperation.ControlValueChanged
        If rdoWords.Checked Then
            ucrNudFirstWord.Visible = True
            ucrNudLastWord.Visible = True
            If ucrChkFirstOr.Checked Then
                ucrBase.clsRsyntax.RemoveParameter("start")
                ucrReceiverFirstWord.SetMeAsReceiver()
                ucrBase.clsRsyntax.AddParameter("start", clsRFunctionParameter:=ucrReceiverFirstWord.GetVariables())
            Else
                ucrBase.clsRsyntax.RemoveParameter("start")
                If ucrChkLastOr.Checked Then
                    ucrReceiverLastWord.SetMeAsReceiver()
                Else
                    ucrReceiverTransformText.SetMeAsReceiver()
                End If
                ucrBase.clsRsyntax.AddParameter("start", ucrNudFirstWord.Value)
            End If

            If ucrChkLastOr.Checked Then
                ucrBase.clsRsyntax.RemoveParameter("end")
                ucrReceiverLastWord.SetMeAsReceiver()
                ucrBase.clsRsyntax.AddParameter("end", clsRFunctionParameter:=ucrReceiverLastWord.GetVariables())
            Else
                ucrBase.clsRsyntax.RemoveParameter("end")
                ucrBase.clsRsyntax.AddParameter("end", ucrNudLastWord.Value)
                If ucrChkFirstOr.Checked Then
                    ucrReceiverFirstWord.SetMeAsReceiver()
                Else
                    ucrReceiverTransformText.SetMeAsReceiver()
                End If
            End If
        Else
            ucrReceiverTransformText.SetMeAsReceiver()
            ucrNudFirstWord.Visible = False
            ucrNudLastWord.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
        End If
        DialogSize()
    End Sub

    Private Sub ucrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTransformText.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub ucrReceiverTransformText_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstWord.ControlContentsChanged, ucrNudWidth.ControlContentsChanged, ucrNudFirstWord.ControlContentsChanged, ucrNudLastWord.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrNudTo.ControlContentsChanged, ucrReceiverLastWord.ControlContentsChanged, ucrReceiverTransformText.ControlContentsChanged, ucrPnlOperation.ControlContentsChanged, ucrInputPad.ControlContentsChanged, ucrNewColName.ControlContentsChanged, ucrInputSeparator.ControlContentsChanged, ucrInputTo.ControlContentsChanged, ucrChkFirstOr.ControlContentsChanged, ucrChkLastOr.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class