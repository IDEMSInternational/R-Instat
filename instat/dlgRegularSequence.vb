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

Imports instat.Translations
Imports RDotNet
Public Class dlgRegularSequence
    Dim bIsExtended As Boolean = False
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSeqFunction, clsRepFunction As New RFunction
    Private bUpdateBy As Boolean = False
    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 30

        ucrInputFrom.SetParameter(New RParameter("from", 0))
        ucrInputFrom.AddQuotesIfUnrecognised = False
        ucrInputFrom.SetValidationTypeAsNumeric()

        ucrInputTo.SetParameter(New RParameter("to", 1))
        ucrInputTo.AddQuotesIfUnrecognised = False
        ucrInputTo.SetValidationTypeAsNumeric()

        ucrInputInStepsOf.SetParameter(New RParameter("by", 2))
        ucrInputInStepsOf.AddQuotesIfUnrecognised = False
        ucrInputInStepsOf.SetValidationTypeAsNumeric(dcmMin:=0, bIncludeMin:=False)

        ucrNudRepeatValues.SetParameter(New RParameter("each", 1))
        ucrNudRepeatValues.SetMinMax(1, Integer.MaxValue)

        ucrDataFrameLengthForRegularSequence.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)

        ucrPnlSequenceType.AddRadioButton(rdoNumeric)
        ucrPnlSequenceType.AddRadioButton(rdoDates)
        ucrPnlSequenceType.AddFunctionNamesCondition(rdoNumeric, {"seq", "rep"})
        'ucrPnlSequenceType.AddFunctionNamesCondition(rdoDates, "as.date")

        ucrPnlSequenceType.AddToLinkedControls(ucrInputFrom, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputFrom.SetLinkedDisplayControl(lblFrom)
        ucrPnlSequenceType.AddToLinkedControls(ucrInputTo, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputTo.SetLinkedDisplayControl(lblTo)
        ucrPnlSequenceType.AddToLinkedControls(ucrInputInStepsOf, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputInStepsOf.SetLinkedDisplayControl(lblInStepsOf)
        ucrPnlSequenceType.AddToLinkedControls(ucrNudRepeatValues, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudRepeatValues.SetLinkedDisplayControl(lblRepeatValues)
        'ucrPnlSequenceType.AddToLinkedControls(dtpSelectorA, {rdoDates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSequenceType.AddToLinkedControls(dtpSelectorB, {rdoDates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNewColumnName.SetPrefix("Regular")
        ucrNewColumnName.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetLabelText("New Column Name:")

        'TODO complete dates option
        dtpSelectorB.Visible = False
        dtpSelectorA.Visible = False
        ucrChkDefineAsFactor.SetText("Define As Factor")
        CheckSequenceLength()

        'Temporarily disabled
        ucrChkDefineAsFactor.Enabled = False
        rdoDates.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsRepFunction = New RFunction
        clsSeqFunction = New RFunction
        ucrSelectDataFrameRegularSequence.Reset()
        ucrNewColumnName.Reset()

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 1)
        clsSeqFunction.AddParameter("to", ucrSelectDataFrameRegularSequence.iDataFrameLength)
        clsSeqFunction.AddParameter("by", 1)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqFunction)
        clsRepFunction.AddParameter("each", 1)
        clsRepFunction.AddParameter("length.out", ucrSelectDataFrameRegularSequence.iDataFrameLength, iPosition:=3)
        'clsSeqFunction.SetAssignTo(ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
        CheckSequenceLength()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bUpdateBy = False
        ucrNewColumnName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSequenceType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrInputFrom.SetRCode(clsSeqFunction, bReset)
        ucrInputTo.SetRCode(clsSeqFunction, bReset)
        ucrNudRepeatValues.SetRCode(clsRepFunction, bReset)
        If bReset AndAlso (ucrInputFrom.GetText < ucrInputTo.GetText) Then
            ucrInputInStepsOf.SetRCode(clsSeqFunction, bReset)
        End If
        bUpdateBy = True
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewColumnName.IsComplete Then
            If rdoNumeric.Checked Then
                If ucrInputFrom.GetText <> "" AndAlso ucrInputTo.GetText <> "" AndAlso ucrInputInStepsOf.GetText <> "" AndAlso ucrNudRepeatValues.GetText <> "" AndAlso ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoDates.Checked Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetInStepsOfParameter()
        If Not ucrInputTo.IsEmpty AndAlso Not ucrInputFrom.IsEmpty Then
            If Convert.ToDecimal(ucrInputTo.GetText) >= Convert.ToDecimal(ucrInputFrom.GetText) Then
                clsSeqFunction.AddParameter("by", ucrInputInStepsOf.GetText)
            Else
                clsSeqFunction.AddParameter("by", "-" & ucrInputInStepsOf.GetText)
            End If
        End If
        CheckSequenceLength()
    End Sub

    Private Sub SetBaseFunction()
        If ucrNudRepeatValues.Value > 1 Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsSeqFunction)
        End If

    End Sub

    'Private Sub dtpSelectorA_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectorA.ValueChanged
    '    ucrBase.clsRsyntax.AddParameter("from", "as.Date('" & Format(dtpSelectorA.Value, "yyyy/MM/dd") & "')")
    '    CheckSequenceLength()
    'End Sub

    'Private Sub dtpSelectorB_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectorB.ValueChanged
    '    ucrBase.clsRsyntax.AddParameter("to", "as.Date('" & Format(dtpSelectorB.Value, "yyyy/MM/dd") & "')")
    '    CheckSequenceLength()
    'End Sub

    Private Sub CheckSequenceLength()
        Dim iLength As Integer
        Dim vecSequence As NumericVector
        Dim strRCommand As String
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean

        txtMessage.Text = ""
        Try
            bIsAssigned = ucrBase.clsRsyntax.clsBaseFunction.bIsAssigned
            bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
            ucrBase.clsRsyntax.clsBaseFunction.bIsAssigned = False
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
            ucrBase.clsRsyntax.RemoveParameter("length.out")
            strRCommand = ucrBase.clsRsyntax.clsBaseFunction.ToScript()
            vecSequence = frmMain.clsRLink.RunInternalScriptGetValue(strRCommand, bSilent:=True).AsNumeric
            iLength = vecSequence.Length
            If iLength <> ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
                clsSeqFunction.RemoveAssignTo()
                clsRepFunction.AddParameter("length.out", ucrSelectDataFrameRegularSequence.iDataFrameLength, iPosition:=3)
                strRCommand = ucrBase.clsRsyntax.clsBaseFunction.ToScript()
                bIsAssigned = False
                vecSequence = frmMain.clsRLink.RunInternalScriptGetValue(strRCommand, bSilent:=True).AsNumeric
                ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
                If iLength < ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                    txtMessage.Text = "Sequence extended to match" & Environment.NewLine & " the length of the data frame."
                ElseIf iLength > ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                    txtMessage.Text = "Sequence truncated to match" & Environment.NewLine & " the length of the data frame."
                End If
            Else
                clsRepFunction.RemoveParameterByName("length.out")
                txtMessage.Text = "Sequence matches the length of the data frame."
            End If
            txtGetPreview.Text = ""
            txtGetPreview.Text = String.Join(", ", vecSequence.AsCharacter())
            ucrBase.clsRsyntax.clsBaseFunction.bIsAssigned = bIsAssigned
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
        Catch ex As Exception
            txtGetPreview.Text = ""
            txtMessage.Text = "No preview available."
        End Try
    End Sub

    Private Sub ucrSelectDataFrameRegularSequence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectDataFrameRegularSequence.ControlValueChanged
        If ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" Then
            Try
                ucrInputTo.txtInput.Text = frmMain.clsRLink.GetDataFrameLength(ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text)
            Catch ex As Exception
            End Try
        End If
        CheckSequenceLength()
    End Sub

    Private Sub ucrNudRepeatValues_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudRepeatValues.ControlContentsChanged
        SetBaseFunction()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputFrom_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFrom.ControlValueChanged, ucrInputTo.ControlValueChanged, ucrInputInStepsOf.ControlValueChanged
        If bUpdateBy Then
            SetInStepsOfParameter()
        End If
    End Sub

    Private Sub ucrNewColumnName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrInputTo.ControlContentsChanged, ucrInputFrom.ControlContentsChanged, ucrInputInStepsOf.ControlContentsChanged, ucrPnlSequenceType.ControlContentsChanged, ucrSelectDataFrameRegularSequence.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class