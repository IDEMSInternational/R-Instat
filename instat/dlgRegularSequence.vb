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
        TestOKEnabled()
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudFrom.SetRCode(clsSeqFunction, bReset)
        ucrNudTo.SetRCode(clsSeqFunction, bReset)
        ucrNudRepeatValues.SetRCode(clsRepFunction)
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 30

        ucrPnlSequenceType.AddRadioButton(rdoNumeric)
        ucrPnlSequenceType.AddRadioButton(rdoDates)

        ucrPnlSequenceType.AddFunctionNamesCondition(rdoNumeric, "seq")
        ucrPnlSequenceType.AddFunctionNamesCondition(rdoDates, "as.Date")

        ucrPnlSequenceType.AddToLinkedControls(ucrNudFrom, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSequenceType.AddToLinkedControls(ucrNudTo, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSequenceType.AddToLinkedControls(dtpSelectorA, {rdoDates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlSequenceType.AddToLinkedControls(dtpSelectorB, {rdoDates}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrNudFrom.SetParameter(New RParameter("from", 0))
        ucrNudTo.SetParameter(New RParameter("to", 1))
        ucrNudRepeatValues.SetParameter(New RParameter("by", 2))
        ucrNudFrom.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudTo.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudInStepsOf.Maximum = Integer.MaxValue
        ucrNudRepeatValues.Maximum = Integer.MaxValue


        ucrNewColumnName.SetPrefix("Regular")
        ucrNewColumnName.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetSaveTypeAsColumn()

        'TODO complete dates option
        rdoDates.Enabled = False
        dtpSelectorB.Visible = False
        ucrNudFrom.Visible = False
        ucrNudTo.Visible = False
        chkDefineAsFactor.Visible = False
    End Sub

    Private Sub SetDefaults()
        clsRepFunction = New RFunction
        clsSeqFunction = New RFunction
        ucrSelectDataFrameRegularSequence.Reset()

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 1)
        clsSeqFunction.AddParameter("to")
        clsSeqFunction.AddParameter("by", 1)
        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqFunction)
        clsRepFunction.AddParameter("each", 1)

        If ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" Then
            ucrNudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        End If

        'SetNumericOrDatesParameters()
        CheckSequenceLength()
        ucrNudNumberOfDecimalPlaces.Value = 2
        ucrNewColumnName.SetPrefix("Regular")
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewColumnName.IsComplete Then
            If rdoNumeric.Checked Then
                If ucrNudFrom.Text <> "" AndAlso ucrNudTo.Text <> "" AndAlso ucrNudInStepsOf.Text <> "" AndAlso ucrNudRepeatValues.Text <> "" AndAlso ucrDataFrameLengthForRegularSequence.ucrDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
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

    Private Sub grpSequenceType_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    ' ' Private Sub SetNumericOrDatesParameters()
    ' If rdoNumeric.Checked Then
    '         ucrNudFrom.Visible = True
    '         ucrNudTo.Visible = True
    '         dtpSelectorA.Visible = False
    '         dtpSelectorB.Visible = False
    '         chkDefineAsFactor.Visible = False
    '     ElseIf rdoDates.Checked Then
    '         dtpSelectorA.Visible = True
    '      
    '     End If
    '     SetFromParameter()
    '     SetToParameter()
    '     SetInStepsOfParameter()
    '     SetRepeatProperties()
    '     CheckSequenceLength()
    '     TestOKEnabled()
    '' End Sub

    Private Sub nudInstepsOf_TextChanged(sender As Object, e As EventArgs)
        SetInStepsOfParameter()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub SetInStepsOfParameter()
        If rdoNumeric.Checked Then
            If ucrNudInStepsOf.Text <> "" Then
                If (ucrNudInStepsOf.Value = 1 AndAlso frmMain.clsInstatOptions.bIncludeRDefaultParameters) OrElse ucrNudInStepsOf.Value <> 1 Then
                    If ucrNudTo.Value >= ucrNudFrom.Value Then
                        clsSeqFunction.AddParameter("by", ucrNudInStepsOf.Value)
                    Else
                        clsSeqFunction.AddParameter("by", -ucrNudInStepsOf.Value)
                    End If
                Else
                    clsSeqFunction.RemoveParameterByName("by")
                End If
            Else
                clsSeqFunction.RemoveParameterByName("by")
            End If
        Else
            clsSeqFunction.RemoveParameterByName("by")
        End If
    End Sub
    Private Sub nudRepeatValues_TextChanged(sender As Object, e As EventArgs)
        SetRepeatProperties()
        TestOKEnabled()
    End Sub

    Private Sub SetRepeatProperties()
        If ucrNudRepeatValues.Text <> "" Then
            If ucrNudRepeatValues.Value > 1 Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
                clsSeqFunction.RemoveAssignTo()
                clsRepFunction.AddParameter("each", ucrNudRepeatValues.Value)
            Else
                clsRepFunction.RemoveParameterByName("each")
                ucrBase.clsRsyntax.SetBaseRFunction(clsSeqFunction)
                clsRepFunction.RemoveAssignTo()
            End If
            SetAssignTo()
        Else
            clsRepFunction.RemoveParameterByName("each")
        End If
        CheckSequenceLength()
    End Sub

    Private Sub nudFrom_TextChanged(sender As Object, e As EventArgs)
        SetFromParameter()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub SetFromParameter()
        If rdoNumeric.Checked Then
            If ucrNudFrom.Text <> "" Then
                clsSeqFunction.AddParameter("from", ucrNudFrom.Value)
            Else
                clsSeqFunction.RemoveParameterByName("from")
            End If
        Else
            clsSeqFunction.RemoveParameterByName("from")
        End If
    End Sub

    Private Sub nudTo_TextChanged(sender As Object, e As EventArgs)
        SetToParameter()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub SetToParameter()
        If rdoNumeric.Checked Then
            If ucrNudTo.Text <> "" Then
                clsSeqFunction.AddParameter("to", ucrNudTo.Value)
            Else
                clsSeqFunction.RemoveParameterByName("to")
            End If
        Else
            clsSeqFunction.RemoveParameterByName("to")
        End If
    End Sub

    Private Sub dtpSelectorA_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectorA.ValueChanged
        ucrBase.clsRsyntax.AddParameter("from", "as.Date('" & Format(dtpSelectorA.Value, "yyyy/MM/dd") & "')")
        CheckSequenceLength()
    End Sub

    Private Sub dtpSelectorB_ValueChanged(sender As Object, e As EventArgs) Handles dtpSelectorB.ValueChanged
        ucrBase.clsRsyntax.AddParameter("to", "as.Date('" & Format(dtpSelectorB.Value, "yyyy/MM/dd") & "')")
        CheckSequenceLength()
    End Sub

    Private Sub ucrInputCboRegularSequence_NameChanged()
        SetAssignTo()
        TestOKEnabled()
    End Sub

    Private Sub SetAssignTo()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
    End Sub
    Private Sub ucrSelectDataFrameRegularSequence_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrSelectDataFrameRegularSequence.DataFrameChanged
        ucrNudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        ucrNudFrom.Value = 1
        ucrNudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        '  SetNumericOrDatesParameters()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

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
                SetAssignTo()
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

    Private Sub nudNumberofDecimalPlaces_TextChanged(sender As Object, e As EventArgs)
        ucrNudFrom.DecimalPlaces = ucrNudNumberOfDecimalPlaces.Value
        ucrNudTo.DecimalPlaces = ucrNudNumberOfDecimalPlaces.Value
        ucrNudInStepsOf.DecimalPlaces = ucrNudNumberOfDecimalPlaces.Value
        ucrNudFrom.Increment = 10 ^ -(ucrNudNumberOfDecimalPlaces.Value)
        ucrNudTo.Increment = 10 ^ -(ucrNudNumberOfDecimalPlaces.Value)
        ucrNudInStepsOf.Increment = 10 ^ -(ucrNudNumberOfDecimalPlaces.Value)
    End Sub

    Private Sub ucrSelectDataFrameRegularSequence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectDataFrameRegularSequence.ControlValueChanged, ucrNudTo.ControlValueChanged, ucrNudFrom.ControlValueChanged
        CheckSequenceLength()
    End Sub
End Class