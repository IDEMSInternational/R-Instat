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
    Private clsConvertFunction, clsLengthFunction, clsPadFunction, clsTrimFunction, clsWordsFunction, clsSubstringFunction As New RFunction
    Private bRCodeSet As Boolean = True
    Private iFullHeight As Integer
    Private igrpParameterFullHeight As Integer
    Private iBaseMaxY As Integer
    Private iNewColMaxY As Integer

    Private Sub dlgTransformText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            iFullHeight = Me.Height
            igrpParameterFullHeight = grpParameters.Height
            iBaseMaxY = ucrBase.Location.Y
            iNewColMaxY = ucrSaveNewColumn.Location.Y
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

        'ucrInputTo
        ucrInputTo.SetItems({"Lower", "Upper", "Title"})
        ucrInputTo.AddFunctionNamesCondition("Lower", "str_to_lower")
        ucrInputTo.AddFunctionNamesCondition("Upper", "str_to_upper")
        ucrInputTo.AddFunctionNamesCondition("Title", "str_to_title")
        ucrInputTo.SetDropDownStyleAsNonEditable()

        'ucrInputPad
        ucrInputPad.SetParameter(New RParameter("pad", 3))
        dctInputPad.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctInputPad.Add("Hash #", Chr(34) & "#" & Chr(34))
        dctInputPad.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctInputPad.Add("Period .", Chr(34) & "." & Chr(34))
        dctInputPad.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputPad.SetItems(dctInputPad)
        ucrInputPad.SetRDefault(Chr(34) & " " & Chr(34))
        ucrInputPad.bAllowNonConditionValues = True

        'ucrNudWidth
        ucrNudWidth.SetParameter(New RParameter("width", 1))

        'rdoTrim, rdoPad
        ucrPnlPad.SetParameter(New RParameter("side", 2))
        ucrPnlPad.AddRadioButton(rdoLeftPad, Chr(34) & "left" & Chr(34))
        ucrPnlPad.AddRadioButton(rdoRightPad, Chr(34) & "right" & Chr(34))
        ucrPnlPad.AddRadioButton(rdoBothPad, Chr(34) & "both" & Chr(34))
        ucrPnlPad.SetRDefault(Chr(34) & "left" & Chr(34))

        'linking
        ucrPnlOperation.AddToLinkedControls(ucrInputPad, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudWidth, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlOperation.AddToLinkedControls(ucrInputTo, {rdoConvertCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrPnlPad, {rdoPad, rdoTrim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrChkFirstOr, {rdoWords, rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrChkLastOr, {rdoWords, rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrInputSeparator, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudFirstWord, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlOperation.AddToLinkedControls(ucrNudLastWord, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        ucrPnlOperation.AddToLinkedControls(ucrNudFrom, {rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlOperation.AddToLinkedControls(ucrNudTo, {rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        'ucrChkFirstOr.AddToLinkedControls(ucrNudFirstWord, {False}, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        'ucrChkFirstOr.AddToLinkedControls(ucrNudFrom, {False}, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFirstOr.AddToLinkedControls(ucrReceiverFirstWord, {True}, bNewLinkedHideIfParameterMissing:=True)
        'ucrChkLastOr.AddToLinkedControls(ucrNudLastWord, {False}, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)
        'ucrChkLastOr.AddToLinkedControls(ucrNudTo, {False}, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkLastOr.AddToLinkedControls(ucrReceiverLastWord, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudFirstWord.SetLinkedDisplayControl(lblFirstWord)
        ucrNudLastWord.SetLinkedDisplayControl(lblLastWord)
        ucrInputTo.SetLinkedDisplayControl(lblTo)
        ucrInputPad.SetLinkedDisplayControl(lblPad)
        ucrNudWidth.SetLinkedDisplayControl(lblWidth)
        ucrInputSeparator.SetLinkedDisplayControl(lblSeparator)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrNudTo.SetLinkedDisplayControl(lblToSubstring)

        'ucrChkFirstOr
        ucrNudFirstWord.SetParameter(New RParameter("start", 1))
        ucrNudFirstWord.SetMinMax(Integer.MinValue, Integer.MaxValue)

        'ucrChkLastOr
        ucrNudLastWord.SetParameter(New RParameter("end", 2))
        ucrNudLastWord.SetMinMax(Integer.MinValue, Integer.MaxValue)

        ucrReceiverFirstWord.SetParameter(New RParameter("start", 1))
        ucrReceiverFirstWord.SetParameterIsRFunction()
        ucrReceiverFirstWord.Selector = ucrSelectorForTransformText
        ucrReceiverFirstWord.bUseFilteredData = False
        ucrReceiverFirstWord.SetIncludedDataTypes({"numeric"})

        ucrReceiverLastWord.SetParameter(New RParameter("end", 2))
        ucrReceiverLastWord.SetParameterIsRFunction()
        ucrReceiverLastWord.Selector = ucrSelectorForTransformText
        ucrReceiverLastWord.bUseFilteredData = False
        ucrReceiverLastWord.SetIncludedDataTypes({"numeric"})

        ucrChkFirstOr.SetText("Or Column")
        ucrChkFirstOr.AddParameterIsStringCondition(False, "start", True)
        ucrChkFirstOr.AddParameterIsRFunctionCondition(True, "start", True)

        ucrChkLastOr.SetText("Or Column")
        ucrChkLastOr.AddParameterIsStringCondition(False, "start", True)
        ucrChkLastOr.AddParameterIsRFunctionCondition(True, "start", True)

        ' ucrInputSeparator
        ucrInputSeparator.SetParameter(New RParameter("sep", 3))
        dctInputSeparator.Add("Space ( )", "stringr::fixed(" & Chr(34) & " " & Chr(34) & ")")
        dctInputSeparator.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctInputSeparator.Add("Period .", "stringr::fixed(" & Chr(34) & "." & Chr(34) & ")")
        dctInputSeparator.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputSeparator.SetItems(dctInputSeparator)
        ucrInputSeparator.SetRDefault("stringr::fixed(" & Chr(34) & " " & Chr(34) & ")")
        ucrInputSeparator.bAllowNonConditionValues = True

        'ucrNuds
        ucrNudFrom.SetParameter(New RParameter("start", 1))
        ucrNudFrom.SetMinMax(Integer.MinValue, Integer.MaxValue)

        ucrNudTo.SetParameter(New RParameter("end", 2))
        ucrNudTo.SetMinMax(Integer.MinValue, Integer.MaxValue)

        'ucrNewColName
        ucrSaveNewColumn.SetIsTextBox()
        ucrSaveNewColumn.SetSaveTypeAsColumn()
        ucrSaveNewColumn.SetDataFrameSelector(ucrSelectorForTransformText.ucrAvailableDataFrames)
        ucrSaveNewColumn.SetLabelText("Column Name:")
    End Sub

    Private Sub SetDefaults()
        clsConvertFunction = New RFunction
        clsLengthFunction = New RFunction
        clsPadFunction = New RFunction
        clsTrimFunction = New RFunction
        clsWordsFunction = New RFunction
        clsSubstringFunction = New RFunction

        ucrSaveNewColumn.Reset()
        ucrSelectorForTransformText.Reset()

        NewDefaultName()
        clsConvertFunction.SetPackageName("stringr")
        clsConvertFunction.SetRCommand("str_to_lower")
        clsConvertFunction.SetAssignTo(ucrSaveNewColumn.GetText(), strTempDataframe:=ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveNewColumn.GetText)

        clsLengthFunction.SetPackageName("stringr")
        clsLengthFunction.SetRCommand("str_length")

        clsPadFunction.SetPackageName("stringr")
        clsPadFunction.SetRCommand("str_pad")
        clsPadFunction.AddParameter("width", 1, iPosition:=1)
        clsPadFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=2)
        clsPadFunction.AddParameter("pad", Chr(34) & " " & Chr(34), iPosition:=3)

        clsTrimFunction.SetPackageName("stringr")
        clsTrimFunction.SetRCommand("str_trim")
        clsTrimFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=1)

        clsWordsFunction.SetPackageName("stringr")
        clsWordsFunction.SetRCommand("word")
        clsWordsFunction.AddParameter("start", 1, iPosition:=1)
        clsWordsFunction.AddParameter("end", 2, iPosition:=2)
        clsWordsFunction.AddParameter("sep", "stringr::fixed(" & Chr(34) & " " & Chr(34) & ")", iPosition:=3)

        clsSubstringFunction.SetPackageName("stringr")
        clsSubstringFunction.SetRCommand("str_sub")
        clsSubstringFunction.AddParameter("start", 1, iPosition:=1)
        clsSubstringFunction.AddParameter("end", 2, iPosition:=2)
        ucrBase.clsRsyntax.SetBaseRFunction(clsConvertFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlPad.AddAdditionalCodeParameterPair(clsPadFunction, clsNewRParameter:=New RParameter("side", 2), iAdditionalPairNo:=1)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsConvertFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsPadFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=2)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsTrimFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=3)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsWordsFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=4)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsSubstringFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=5)
        ucrReceiverFirstWord.AddAdditionalCodeParameterPair(clsSubstringFunction, clsNewRParameter:=New RParameter("start", 1), iAdditionalPairNo:=1)
        ucrReceiverLastWord.AddAdditionalCodeParameterPair(clsSubstringFunction, clsNewRParameter:=New RParameter("end", 2), iAdditionalPairNo:=1)

        ucrSaveNewColumn.AddAdditionalRCode(clsLengthFunction, iAdditionalPairNo:=1)
        ucrSaveNewColumn.AddAdditionalRCode(clsPadFunction, iAdditionalPairNo:=2)
        ucrSaveNewColumn.AddAdditionalRCode(clsTrimFunction, iAdditionalPairNo:=3)
        ucrSaveNewColumn.AddAdditionalRCode(clsWordsFunction, iAdditionalPairNo:=4)
        ucrSaveNewColumn.AddAdditionalRCode(clsSubstringFunction, iAdditionalPairNo:=5)

        ucrReceiverTransformText.SetRCode(clsLengthFunction, bReset)
        ucrSaveNewColumn.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlOperation.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputTo.SetRCode(clsConvertFunction, bReset)
        ucrInputPad.SetRCode(clsPadFunction, bReset)
        ucrNudWidth.SetRCode(clsPadFunction, bReset)
        ucrPnlPad.SetRCode(clsTrimFunction, bReset)
        ucrChkFirstOr.SetRCode(clsWordsFunction, bReset)
        ucrChkLastOr.SetRCode(clsWordsFunction, bReset)
        ucrReceiverFirstWord.SetRCode(clsWordsFunction, bReset)
        ucrReceiverLastWord.SetRCode(clsWordsFunction, bReset)
        ucrNudFirstWord.SetRCode(clsWordsFunction, bReset)
        ucrNudLastWord.SetRCode(clsWordsFunction, bReset)
        ucrInputSeparator.SetRCode(clsWordsFunction, bReset)
        ucrNudFrom.SetRCode(clsSubstringFunction, bReset)
        ucrNudTo.SetRCode(clsSubstringFunction, bReset)
        DialogSize()
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverTransformText.IsEmpty()) AndAlso ucrSaveNewColumn.IsComplete() Then
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
                If ((ucrNudTo.GetText <> "" AndAlso ucrNudFrom.GetText <> "" AndAlso Not ucrChkFirstOr.Checked) OrElse (ucrChkFirstOr.Checked AndAlso Not ucrReceiverFirstWord.IsEmpty)) AndAlso ((ucrNudLastWord.GetText <> "" AndAlso Not ucrChkLastOr.Checked) OrElse (ucrChkLastOr.Checked AndAlso Not ucrReceiverLastWord.IsEmpty)) Then
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
        If (Not ucrSaveNewColumn.bUserTyped) AndAlso Not ucrReceiverTransformText.IsEmpty Then
            ucrSaveNewColumn.SetName(ucrReceiverTransformText.GetVariableNames(bWithQuotes:=False) & "_transformed")
        End If
    End Sub

    Private Sub DialogSize()
        If rdoConvertCase.Checked OrElse rdoTrim.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight / 3.04)
            ucrSaveNewColumn.Location = New Point(ucrSaveNewColumn.Location.X, iNewColMaxY / 1.39)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.36)
            Me.Size = New Size(Me.Width, iFullHeight / 1.27)
        ElseIf rdoLength.Checked Then
            grpParameters.Visible = False
            ucrSaveNewColumn.Location = New Point(ucrSaveNewColumn.Location.X, iNewColMaxY / 1.76)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.69)
            Me.Size = New Size(Me.Width, iFullHeight / 1.5)
        ElseIf rdoSubstring.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight / 1.22)
            ucrSaveNewColumn.Location = New Point(ucrSaveNewColumn.Location.X, iNewColMaxY / 1.09)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.09)
            Me.Size = New Size(Me.Width, iFullHeight / 1.07)
        ElseIf rdoPad.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight / 1.43)
            ucrSaveNewColumn.Location = New Point(ucrSaveNewColumn.Location.X, iNewColMaxY / 1.14)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.13)
            Me.Size = New Size(Me.Width, iFullHeight / 1.1)
        Else
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight)
            ucrSaveNewColumn.Location = New Point(ucrBase.Location.X, iNewColMaxY)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            Me.Size = New Size(Me.Width, iFullHeight)
        End If
    End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOperation.ControlValueChanged, ucrInputTo.ControlValueChanged
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
    End Sub

    Private Sub ucrWordsTab_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFirstOr.ControlValueChanged, ucrChkLastOr.ControlValueChanged, ucrPnlOperation.ControlValueChanged
        If rdoWords.Checked OrElse rdoSubstring.Checked Then
            If ucrChkFirstOr.Checked Then
                ucrNudFirstWord.Enabled = False
                ucrNudFrom.Enabled = False
                ucrReceiverFirstWord.SetMeAsReceiver()
            Else
                ucrNudFirstWord.Enabled = True
                ucrNudFrom.Enabled = True
                If ucrChkLastOr.Checked Then
                    ucrNudLastWord.Enabled = False
                    ucrNudTo.Enabled = False
                    ucrReceiverLastWord.SetMeAsReceiver()
                Else
                    ucrNudLastWord.Enabled = True
                    ucrNudTo.Enabled = True
                    ucrReceiverTransformText.SetMeAsReceiver()
                End If
            End If
            If ucrChkLastOr.Checked Then
                ucrNudLastWord.Enabled = False
                ucrNudTo.Enabled = False
                ucrReceiverLastWord.SetMeAsReceiver()
            Else
                If ucrChkFirstOr.Checked Then
                    ucrNudFirstWord.Enabled = False
                    ucrNudFrom.Enabled = False
                    ucrReceiverFirstWord.SetMeAsReceiver()
                Else
                    ucrNudFirstWord.Enabled = True
                    ucrNudFrom.Enabled = True
                    ucrReceiverTransformText.SetMeAsReceiver()
                End If
            End If
        Else
            ucrReceiverTransformText.SetMeAsReceiver()
        End If
        DialogSize()
    End Sub

    Private Sub ucrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTransformText.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub ucrReceiverTransformText_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstWord.ControlContentsChanged, ucrNudWidth.ControlContentsChanged, ucrNudFirstWord.ControlContentsChanged, ucrNudLastWord.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrNudTo.ControlContentsChanged, ucrReceiverLastWord.ControlContentsChanged, ucrReceiverTransformText.ControlContentsChanged, ucrPnlOperation.ControlContentsChanged, ucrInputPad.ControlContentsChanged, ucrSaveNewColumn.ControlContentsChanged, ucrInputSeparator.ControlContentsChanged, ucrInputTo.ControlContentsChanged, ucrChkFirstOr.ControlContentsChanged, ucrChkLastOr.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class