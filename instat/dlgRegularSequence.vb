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

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNewColumnName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlSequenceType.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrNudFrom.SetRCode(clsSeqFunction, bReset)
        ucrNudTo.SetRCode(clsSeqFunction, bReset)
        ucrNudRepeatValues.SetRCode(clsRepFunction, bReset)
        ucrNudInStepsOf.SetRCode(clsSeqFunction, bReset)
        ucrNudNumberOfDecimalPlaces.SetRCode(clsSeqFunction, bReset)
        ucrNudNumberOfDecimalPlaces.SetRCode(clsRepFunction, bReset)

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 30

        ucrPnlSequenceType.AddRadioButton(rdoNumeric)
        ucrPnlSequenceType.AddRadioButton(rdoDates)

        ucrNudFrom.SetParameter(New RParameter("from", 0))
        ucrNudTo.SetParameter(New RParameter("to", 1))
        ucrNudRepeatValues.SetParameter(New RParameter("each", 1))
        ucrNudInStepsOf.SetParameter(New RParameter("by", 2))
        ucrNudInStepsOf.Minimum = 1
        ucrNudInStepsOf.SetRDefault(1)
        ucrNudInStepsOf.Maximum = Integer.MaxValue
        ucrNudFrom.Minimum = 1
        ucrNudFrom.Maximum = Integer.MaxValue
        ucrNudTo.Minimum = 1
        ucrNudRepeatValues.Maximum = Integer.MaxValue
        ucrDataFrameLengthForRegularSequence.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)

        ucrPnlSequenceType.AddToLinkedControls(ucrNudFrom, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrPnlSequenceType.AddToLinkedControls(ucrNudTo, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=ucrSelectDataFrameRegularSequence.iDataFrameLength)
        ucrNudTo.SetLinkedDisplayControl(lblTo)
        ucrPnlSequenceType.AddToLinkedControls(ucrNudInStepsOf, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrNudRepeatValues.SetLinkedDisplayControl(lblRepeatValues)
        ucrPnlSequenceType.AddToLinkedControls(ucrNudRepeatValues, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrNudInStepsOf.SetLinkedDisplayControl(lblSteps)
        'ucrPnlSequenceType.AddToLinkedControls(dtpSelectorA, {rdoDates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSequenceType.AddToLinkedControls(dtpSelectorB, {rdoDates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlSequenceType.bAllowNonConditionValues = True
        ucrPnlSequenceType.AddFunctionNamesCondition(rdoNumeric, "seq")
        ucrPnlSequenceType.AddFunctionNamesCondition(rdoDates, "as.date")

        ucrNewColumnName.SetPrefix("Regular")
        ucrNewColumnName.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetLabelText("New Column Name:")

        'TODO complete dates option
        rdoDates.Enabled = False
        dtpSelectorB.Visible = False
        dtpSelectorA.Visible = False
        'ucrNudFrom.Visible = False
        ' ucrNudTo.Visible = False
        'chkDefineAsFactor.Visible = False
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
        clsRepFunction.AddParameter("length.out", ucrSelectDataFrameRegularSequence.iDataFrameLength)

        clsSeqFunction.SetAssignTo(ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsSeqFunction)

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewColumnName.IsComplete Then
            If rdoNumeric.Checked Then
                If ucrNudFrom.GetText <> "" AndAlso ucrNudTo.GetText <> "" AndAlso ucrNudInStepsOf.GetText <> "" AndAlso ucrNudRepeatValues.GetText <> "" AndAlso ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" AndAlso txtGetPreview.Text <> "" Then
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
            If ucrNudTo.Value < ucrNudFrom.Value Then
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub SetInStepsOfParameter()
        If rdoNumeric.Checked Then
            If ucrNudInStepsOf.GetText <> "" Then
                If (ucrNudInStepsOf.Value = 1 AndAlso frmMain.clsInstatOptions.bIncludeRDefaultParameters) OrElse ucrNudInStepsOf.Value <> 1 Then
                    If ucrNudTo.Value >= ucrNudFrom.Value Then
                        clsSeqFunction.AddParameter("by", ucrNudInStepsOf.Value)
                    Else
                        clsSeqFunction.AddParameter("by", -ucrNudInStepsOf.Value)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub SetBaseFunction()
        If ucrNudRepeatValues.Value > 1 Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsSeqFunction)
        End If
        CheckSequenceLength()
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
                clsRepFunction.AddParameter("length.out", ucrSelectDataFrameRegularSequence.iDataFrameLength)
                strRCommand = ucrBase.clsRsyntax.clsBaseFunction.ToScript()
                bIsAssigned = False
                vecSequence = frmMain.clsRLink.RunInternalScriptGetValue(strRCommand, bSilent:=True).AsNumeric
                If iLength < ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                    txtMessage.Text = "Sequence has been extended by repeating to match the length of the dataframe."
                ElseIf iLength > ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                    txtMessage.Text = "Sequence has been truncated to match the length of the dataframe."
                End If
            Else
                clsRepFunction.RemoveParameterByName("length.out")
                txtMessage.Text = "Sequence matches the length of the dataframe."
            End If
            txtGetPreview.Text = ""
            txtGetPreview.Text = String.Join(", ", vecSequence.AsCharacter())
            ucrBase.clsRsyntax.clsBaseFunction.bIsAssigned = bIsAssigned
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
        Catch ex As Exception
            txtGetPreview.Text = ""
            txtMessage.Text = "No preview avaiable"
        End Try
    End Sub

    Private Sub ucrSelectDataFrameRegularSequence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectDataFrameRegularSequence.ControlValueChanged
        If ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" Then
            ucrNudTo.Value = frmMain.clsRLink.GetDataFrameLength(ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text)
        End If
        CheckSequenceLength()
    End Sub


    Private Sub ucrNudRepeatValues_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudRepeatValues.ControlValueChanged
        SetBaseFunction()
        SetInStepsOfParameter()
    End Sub

    Private Sub ucrNewColumnName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrNudTo.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrNudInStepsOf.ControlContentsChanged, ucrNudRepeatValues.ControlContentsChanged, ucrPnlSequenceType.ControlContentsChanged, ucrSelectDataFrameRegularSequence.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrNudFrom_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudFrom.ControlValueChanged, ucrNudInStepsOf.ControlValueChanged, ucrNudTo.ControlValueChanged, ucrPnlSequenceType.ControlValueChanged
        SetInStepsOfParameter()
    End Sub

    Private Sub ucrNudNumberOfDecimalPlaces_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberOfDecimalPlaces.ControlContentsChanged
        ucrNudFrom.DecimalPlaces = ucrNudNumberOfDecimalPlaces.Value
        ucrNudTo.DecimalPlaces = ucrNudNumberOfDecimalPlaces.Value
        ucrNudInStepsOf.DecimalPlaces = ucrNudNumberOfDecimalPlaces.Value
        ucrNudFrom.Increment = 10 ^ -(ucrNudNumberOfDecimalPlaces.Value)
        ucrNudTo.Increment = 10 ^ -(ucrNudNumberOfDecimalPlaces.Value)
        ucrNudInStepsOf.Increment = 10 ^ -(ucrNudNumberOfDecimalPlaces.Value)
    End Sub

    Private Sub txtGetPreview_TextChanged(sender As Object, e As EventArgs) Handles txtGetPreview.TextChanged, rdoDates.TextChanged, rdoNumeric.TextChanged
        TestOKEnabled()
    End Sub
End Class