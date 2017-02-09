' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat
Imports instat.Translations

Public Class dlgTransformText
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

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
        ucrBase.iHelpTopicID = 343
        ucrBase.clsRsyntax.bUseBaseFunction = True

        'ucrReceiver
        ucrReceiverTransformText.SetParameter(New RParameter("string", 0))
        ucrReceiverTransformText.SetParameterIsRFunction()
        ucrReceiverTransformText.Selector = ucrSelectorForTransformText
        ucrReceiverTransformText.bUseFilteredData = False
        ucrReceiverTransformText.SetMeAsReceiver()
        ucrReceiverTransformText.SetIncludedDataTypes({"factor", "character"})

        'ucrRdoOptions
        ucrPnlOperation.AddRadioButton(rdoConvertCase)
        ucrPnlOperation.AddRadioButton(rdoLength)
        ucrPnlOperation.AddRadioButton(rdoPad)
        ucrPnlOperation.AddRadioButton(rdoTrim)
        ucrPnlOperation.AddRadioButton(rdoWords)
        ucrPnlOperation.AddRadioButton(rdoSubstring)

        ucrPnlOperation.AddFunctionNamesCondition(rdoConvertCase, "stringr::str_to_lower")
        ucrPnlOperation.AddFunctionNamesCondition(rdoLength, "stringr::str_length")
        ucrPnlOperation.AddFunctionNamesCondition(rdoPad, "stringr::str_pad")
        ucrPnlOperation.AddFunctionNamesCondition(rdoTrim, "stringr::str_trim")
        ucrPnlOperation.AddFunctionNamesCondition(rdoWords, "stringr::word")
        ucrPnlOperation.AddFunctionNamesCondition(rdoSubstring, "stringr::str_sub")

        'rdoConvertCase
        ucrPnlOperation.AddToLinkedControls(ucrInputTo, {rdoConvertCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputTo
        ucrInputTo.SetItems({"Lower", "Upper", "Title"})
        ucrInputTo.AddFunctionNamesCondition("Lower", "stringr::str_to_lower")
        ucrInputTo.AddFunctionNamesCondition("Upper", "stringr::str_to_upper")
        ucrInputTo.AddFunctionNamesCondition("Title", "stringr::str_to_title")
        ucrInputTo.SetLinkedDisplayControl(lblTo)

        'rdoPad
        ucrPnlOperation.AddToLinkedControls(ucrInputPad, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudWidth, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputPad
        Dim dctInputPad As New Dictionary(Of String, String)
        ucrInputPad.SetParameter(New RParameter("pad", ))
        dctInputPad.Add("Space", Chr(34) & " " & Chr(34))
        dctInputPad.Add("Hash", Chr(34) & "#" & Chr(34))
        dctInputPad.Add("Hyphen", Chr(34) & "-" & Chr(34))
        dctInputPad.Add("Period", Chr(34) & "." & Chr(34))
        dctInputPad.Add("Underscore", Chr(34) & "_" & Chr(34))
        ucrInputPad.SetItems(dctInputPad)
        ucrInputPad.SetLinkedDisplayControl(lblPad)
        ucrInputPad.SetRDefault(Chr(34) & " " & Chr(34))
        ucrInputPad.bAllowNonConditionValues = True

        'ucrNudWidth
        ucrNudWidth.SetParameter(New RParameter("width"))
        ucrNudWidth.SetLinkedDisplayControl(lblWidth)
        ucrNudWidth.SetRDefault(1)

        'rdoTrim and pnl
        ucrPnlOperation.AddToLinkedControls(ucrPnlPad, {rdoPad, rdoTrim}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlPad
        ucrPnlPad.SetParameter(New RParameter("side"))
        ucrPnlPad.AddRadioButton(rdoLeftPad, Chr(34) & "left" & Chr(34))
        ucrPnlPad.AddRadioButton(rdoRightPad, Chr(34) & "right" & Chr(34))
        ucrPnlPad.AddRadioButton(rdoBothPad, Chr(34) & "both" & Chr(34))
        ucrPnlPad.SetRDefault(Chr(34) & "left" & Chr(34)) ' left is the R default

        'rdoWords
        ucrPnlOperation.AddToLinkedControls(ucrInputSeparator, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverFirstWord.Selector = ucrSelectorForTransformText
        ucrReceiverFirstWord.bUseFilteredData = False
        ucrReceiverFirstWord.SetIncludedDataTypes({"numeric"})

        ucrChkFirstOr.SetText("Or Column")

        ucrReceiverLastWord.Selector = ucrSelectorForTransformText
        ucrReceiverLastWord.bUseFilteredData = False
        ucrReceiverLastWord.SetIncludedDataTypes({"numeric"})

        ucrChkLastOr.SetText("Or Column")

        ' ucrInputSeparator
        Dim dctInputSeparator As New Dictionary(Of String, String)
        ucrInputSeparator.SetParameter(New RParameter("sep"))
        dctInputSeparator.Add("Space", Chr(34) & " " & Chr(34))
        dctInputSeparator.Add("Colon", Chr(34) & ":" & Chr(34))
        dctInputSeparator.Add("Period", Chr(34) & "." & Chr(34))
        dctInputSeparator.Add("Underscore", Chr(34) & "_" & Chr(34))
        ucrInputSeparator.SetItems(dctInputSeparator)
        ucrInputSeparator.SetLinkedDisplayControl(lblSeparator)
        ucrInputSeparator.SetRDefault(Chr(34) & " " & Chr(34))
        ' this does not default upon pressing reset, this is because this is not added as a parameter
        ' not added as param. because of linking. Not necessarily a parameter
        ' wait for Danny's updated code to do a set Default for this, nuds, etc - all things linked.

        'rdoSubstring
        ucrPnlOperation.AddToLinkedControls(ucrNudFrom, {rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudTo, {rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrNud
        ucrNudFrom.SetParameter(New RParameter("start"))
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrNudFrom.SetRDefault(1)

        ucrNudTo.SetParameter(New RParameter("end"))
        ucrNudTo.SetLinkedDisplayControl(lblToSubstring)
        ucrNudTo.SetRDefault(1)

        'ucrNewColName
        ucrNewColName.SetIsTextBox()
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetDataFrameSelector(ucrSelectorForTransformText.ucrAvailableDataFrames)
        ucrNewColName.SetLabelText("Column Name:")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrNewColName.Reset()
        ucrSelectorForTransformText.Reset()
        ucrChkFirstOr.Checked = False
        ucrChkLastOr.Checked = False
        ucrNudFirstWord.Value = 1
        ucrNudLastWord.Value = 1

        NewDefaultName()
        WordsTab()

        clsDefaultFunction.SetRCommand("stringr::str_to_lower")
        clsDefaultFunction.SetAssignTo(ucrNewColName.GetText(), strTempDataframe:=ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOperation.ControlValueChanged, ucrInputTo.ControlValueChanged
        If rdoLength.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_length")
        ElseIf rdoPad.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_pad")
        ElseIf rdoTrim.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_trim")
        ElseIf rdoWords.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::word")
        ElseIf rdoSubstring.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_sub")
        ElseIf rdoConvertCase.Checked Then
            Select Case ucrInputTo.GetText
                Case "Lower"
                    ucrBase.clsRsyntax.SetFunction("stringr::str_to_lower")
                Case "Upper"
                    ucrBase.clsRsyntax.SetFunction("stringr::str_to_upper")
                Case "Title"
                    ucrBase.clsRsyntax.SetFunction("stringr::str_to_title")
            End Select
        End If
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
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

    Private Sub ucrReceiverTransformText_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstWord.ControlContentsChanged, ucrNudWidth.ControlContentsChanged, ucrNudFirstWord.ControlContentsChanged, ucrNudLastWord.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrNudTo.ControlContentsChanged, ucrReceiverLastWord.ControlContentsChanged, ucrReceiverTransformText.ControlContentsChanged, ucrPnlOperation.ControlContentsChanged, ucrInputPad.ControlContentsChanged, ucrNewColName.ControlContentsChanged, ucrInputSeparator.ControlContentsChanged, ucrInputPad.ControlContentsChanged
        WordsTab()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkFirstOr_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFirstOr.ControlValueChanged, ucrChkLastOr.ControlValueChanged
        WordsTab()
    End Sub

    Private Sub WordsTab()
        If rdoWords.Checked Then
            lblFirstWord.Visible = True
            ucrNudFirstWord.Visible = True
            ucrChkFirstOr.Visible = True
            lblLastWord.Visible = True
            ucrNudLastWord.Visible = True
            ucrChkLastOr.Visible = True
            If ucrChkFirstOr.Checked Then
                ucrBase.clsRsyntax.RemoveParameter("start")
                ucrNudFirstWord.Enabled = False
                ucrReceiverFirstWord.Visible = True
                ucrReceiverFirstWord.SetMeAsReceiver()
                ucrBase.clsRsyntax.AddParameter("start", clsRFunctionParameter:=ucrReceiverFirstWord.GetVariables())
            Else
                ucrBase.clsRsyntax.RemoveParameter("start")
                ucrNudFirstWord.Enabled = True
                ucrReceiverFirstWord.Visible = False
                If ucrChkLastOr.Checked Then
                    ucrReceiverLastWord.SetMeAsReceiver()
                Else
                    ucrReceiverTransformText.SetMeAsReceiver()
                End If
                ucrBase.clsRsyntax.AddParameter("start", ucrNudFirstWord.Value)
            End If

            If ucrChkLastOr.Checked Then
                ucrBase.clsRsyntax.RemoveParameter("end")
                ucrNudLastWord.Enabled = False
                ucrReceiverLastWord.Visible = True
                ucrReceiverLastWord.SetMeAsReceiver()
                ucrBase.clsRsyntax.AddParameter("end", clsRFunctionParameter:=ucrReceiverLastWord.GetVariables())
            Else
                ucrBase.clsRsyntax.RemoveParameter("end")
                ucrReceiverLastWord.Visible = False
                ucrNudLastWord.Enabled = True
                ucrBase.clsRsyntax.AddParameter("end", ucrNudLastWord.Value)
                If ucrChkFirstOr.Checked Then
                    ucrReceiverFirstWord.SetMeAsReceiver()
                Else
                    ucrReceiverTransformText.SetMeAsReceiver()
                End If
            End If
        Else
            lblFirstWord.Visible = False
            ucrNudFirstWord.Visible = False
            ucrChkFirstOr.Visible = False
            lblLastWord.Visible = False
            ucrNudLastWord.Visible = False
            ucrChkLastOr.Visible = False
            ucrReceiverFirstWord.Visible = False
            ucrReceiverLastWord.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
        End If
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrNewColName.bUserTyped) AndAlso ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewColName.SetName(ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_Transformed")
        End If
    End Sub

    Private Sub ucrSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForTransformText.ControlValueChanged
        NewDefaultName()
    End Sub

End Class