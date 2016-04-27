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
    End Sub

    Private Sub SetDefaults()
        rdoNumeric.Checked = True
        rdoDates.Checked = False
        ucrSelectDataFrameRegularSequence.Reset()
        ucrSelectDataFrameRegularSequence.Focus()
        nudFrom.Value = 1
        nudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        nudInStepsOf.Value = 1
        CheckSequenceLength()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If rdoNumeric.Checked Then
            If nudFrom.Text <> "" AndAlso nudTo.Text <> "" AndAlso nudInStepsOf.Text <> "" AndAlso nudRepeatValues.Text <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoDates.Checked Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub grpSequenceType_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDates.CheckedChanged, rdoNumeric.CheckedChanged
        If rdoNumeric.Checked Then
            nudFrom.Visible = True
            nudTo.Visible = True
            dtpSelectorA.Visible = False
            dtpSelectorB.Visible = False
        Else
            dtpSelectorA.Visible = True
            dtpSelectorB.Visible = True
            nudFrom.Visible = False
            nudTo.Visible = False
        End If
        CheckSequenceLength()
        TestOKEnabled()
    End Sub

    Private Sub nudInstepsOf_ValueChanged(sender As Object, e As EventArgs) Handles nudInStepsOf.ValueChanged
        If nudInStepsOf.Text <> "" Then
            If (nudInStepsOf.Value = 1 AndAlso frmMain.clsInstatOptions.bIncludeRDefaultParameters) OrElse nudInStepsOf.Value <> 1 Then
                clsSeqFunction.AddParameter("by", nudInStepsOf.Value)
            Else
                clsSeqFunction.RemoveParameterByName("by")
            End If
        Else
            clsSeqFunction.RemoveParameterByName("by")
        End If
        CheckSequenceLength()
    End Sub

    Private Sub nudRepeatValues_ValueChanged(sender As Object, e As EventArgs) Handles nudRepeatValues.TextChanged
        SetRepeatProperties()
    End Sub

    Private Sub SetRepeatProperties()
        If nudRepeatValues.Text <> "" AndAlso nudRepeatValues.Value > 1 Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
            clsRepFunction.AddParameter("each", nudRepeatValues.Value)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsSeqFunction)
        End If
        CheckSequenceLength()
    End Sub

    Private Sub nudFrom_ValueChanged(sender As Object, e As EventArgs) Handles nudFrom.TextChanged
        If nudFrom.Text <> "" Then
            clsSeqFunction.AddParameter("from", nudFrom.Value)
        Else
            clsSeqFunction.RemoveParameterByName("from")
        End If
        CheckSequenceLength()
    End Sub

    Private Sub nudTo_ValueChanged(sender As Object, e As EventArgs) Handles nudTo.TextChanged
        If nudTo.Text <> "" Then
            clsSeqFunction.AddParameter("to", nudTo.Value)
        Else
            clsSeqFunction.RemoveParameterByName("to")
        End If
        CheckSequenceLength()
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
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
    End Sub

    Private Sub ucrSelectDataFrameRegularSequence_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrSelectDataFrameRegularSequence.DataFrameChanged
        nudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        SetRepeatProperties()
        nudFrom.Value = 1
        nudTo.Value = ucrSelectDataFrameRegularSequence.iDataFrameLength
        CheckSequenceLength()
    End Sub

    Private Sub CheckSequenceLength()
        Dim iLength As Integer
        Dim vecSequence As NumericVector
        Dim strRCommand As String
        lblMessage.Text = ""
        Try
            strRCommand = ucrBase.clsRsyntax.clsBaseFunction.ToScript()
            vecSequence = frmMain.clsRLink.clsEngine.Evaluate(strRCommand).AsNumeric
            iLength = vecSequence.Length
            If iLength <> ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
                clsRepFunction.AddParameter("length.out", ucrSelectDataFrameRegularSequence.iDataFrameLength)
                strRCommand = ucrBase.clsRsyntax.clsBaseFunction.ToScript()
                vecSequence = frmMain.clsRLink.clsEngine.Evaluate(strRCommand).AsNumeric
                If iLength < ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                    lblMessage.Text = "Sequence has been extended by repeating to match the length of the dataframe."
                ElseIf iLength > ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                    lblMessage.Text = "Sequence has been truncated to match the length of the dataframe."
                End If
            Else
                clsRepFunction.RemoveParameterByName("length.out")
                lblMessage.Text = "Sequence matches the length of the dataframe."
            End If
            txtGetPreview.Text = vecSequence.ToString()
        Catch ex As Exception
            txtGetPreview.Text = ""
            lblMessage.Text = "No preview avaiable"
        End Try
    End Sub
End Class