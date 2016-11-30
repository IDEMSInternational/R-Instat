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
    Dim clsSeqFunction As New RFunction
    Dim clsRepFunction As New RFunction

    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        clsSeqFunction.SetRCommand("seq")
        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqFunction)
        nudFrom.Minimum = Integer.MinValue
        nudFrom.Maximum = Integer.MaxValue
        nudTo.Minimum = Integer.MinValue
        nudTo.Maximum = Integer.MaxValue
        nudInStepsOf.Maximum = Integer.MaxValue
        nudRepeatValues.Maximum = Integer.MaxValue
        ucrBase.iHelpTopicID = 30
        ucrDataFrameLengthForRegularSequence.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        ucrNewColumnName.SetPrefix("Regular")
        ucrNewColumnName.SetItemsTypeAsColumns()
        ucrNewColumnName.SetDefaultTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        ucrNewColumnName.SetValidationTypeAsRVariable()
        'TODO complete dates option
        rdoDates.Enabled = False
    End Sub

    Private Sub SetDefaults()
        rdoNumeric.Checked = True
        rdoDates.Checked = False
        ucrSelectDataFrameRegularSequence.Reset()
        ucrSelectDataFrameRegularSequence.Focus()
        nudFrom.Value = 1
        If ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" Then
            nudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        End If
        nudInStepsOf.Value = 1
        nudRepeatValues.Value = 1
        SetNumericOrDatesParameters()
        CheckSequenceLength()
        nudNumberofDecimalPlaces.Value = 2
        ucrNewColumnName.SetPrefix("Regular")
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrNewColumnName.IsEmpty Then
            If rdoNumeric.Checked Then
                If nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso nudInStepsOf.Text <> "" AndAlso nudRepeatValues.Text <> "" AndAlso ucrDataFrameLengthForRegularSequence.clsDataFrameSelector.cboAvailableDataFrames.Text <> "" Then
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

    Private Sub grpSequenceType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDates.CheckedChanged, rdoNumeric.CheckedChanged

    End Sub

    Private Sub SetNumericOrDatesParameters()
        If rdoNumeric.Checked Then
            nudFrom.Visible = True
            nudTo.Visible = True
            dtpSelectorA.Visible = False
            dtpSelectorB.Visible = False
            chkDefineAsFactor.Visible = False
        ElseIf rdoDates.Checked Then
            dtpSelectorA.Visible = True
            dtpSelectorB.Visible = True
            nudFrom.Visible = False
            nudTo.Visible = False
            chkDefineAsFactor.Visible = True
        End If
        SetFromParameter()
        SetToParameter()
        SetInStepsOfParameter()
        SetRepeatProperties()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub nudInstepsOf_TextChanged(sender As Object, e As EventArgs) Handles nudInStepsOf.TextChanged
        SetInStepsOfParameter()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub SetInStepsOfParameter()
        If rdoNumeric.Checked Then
            If nudInStepsOf.Text <> "" Then
                If (nudInStepsOf.Value = 1 AndAlso frmMain.clsInstatOptions.bIncludeRDefaultParameters) OrElse nudInStepsOf.Value <> 1 Then
                    If nudTo.Value >= nudFrom.Value Then
                        clsSeqFunction.AddParameter("by", nudInStepsOf.Value)
                    Else
                        clsSeqFunction.AddParameter("by", -nudInStepsOf.Value)
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
    Private Sub nudRepeatValues_TextChanged(sender As Object, e As EventArgs) Handles nudRepeatValues.TextChanged
        SetRepeatProperties()
        TestOKEnabled()
    End Sub

    Private Sub SetRepeatProperties()
        If nudRepeatValues.Text <> "" Then
            If nudRepeatValues.Value > 1 Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
                clsSeqFunction.RemoveAssignTo()
                clsRepFunction.AddParameter("each", nudRepeatValues.Value)
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

    Private Sub nudFrom_TextChanged(sender As Object, e As EventArgs) Handles nudFrom.TextChanged
        SetFromParameter()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub SetFromParameter()
        If rdoNumeric.Checked Then
            If nudFrom.Text <> "" Then
                clsSeqFunction.AddParameter("from", nudFrom.Value)
            Else
                clsSeqFunction.RemoveParameterByName("from")
            End If
        Else
            clsSeqFunction.RemoveParameterByName("from")
        End If
    End Sub

    Private Sub nudTo_TextChanged(sender As Object, e As EventArgs) Handles nudTo.TextChanged
        SetToParameter()
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub SetToParameter()
        If rdoNumeric.Checked Then
            If nudTo.Text <> "" Then
                clsSeqFunction.AddParameter("to", nudTo.Value)
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

    Private Sub ucrInputCboRegularSequence_NameChanged() Handles ucrNewColumnName.NameChanged
        SetAssignTo()
        TestOKEnabled()
    End Sub

    Private Sub SetAssignTo()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
    End Sub
    Private Sub ucrSelectDataFrameRegularSequence_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrSelectDataFrameRegularSequence.DataFrameChanged
        nudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        nudFrom.Value = 1
        nudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        SetNumericOrDatesParameters()
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

    Private Sub nudNumberofDecimalPlaces_TextChanged(sender As Object, e As EventArgs) Handles nudNumberofDecimalPlaces.TextChanged
        nudFrom.DecimalPlaces = nudNumberofDecimalPlaces.Value
        nudTo.DecimalPlaces = nudNumberofDecimalPlaces.Value
        nudInStepsOf.DecimalPlaces = nudNumberofDecimalPlaces.Value
        nudFrom.Increment = 10 ^ -(nudNumberofDecimalPlaces.Value)
        nudTo.Increment = 10 ^ -(nudNumberofDecimalPlaces.Value)
        nudInStepsOf.Increment = 10 ^ -(nudNumberofDecimalPlaces.Value)
    End Sub

End Class