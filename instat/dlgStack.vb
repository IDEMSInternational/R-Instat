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
Public Class dlgStack
    Public bFirstLoad As Boolean = True
    Private Sub dlgStack_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        ucrBase.clsRsyntax.SetFunction("melt")
        ucrBase.iHelpTopicID = 57
        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrColumnsToCarryReceiver.Selector = ucrSelectorStack
        ucrNewDataName.SetValidationTypeAsRVariable()
        'TODO Should this be enforced for column names?
        'ucrStackDataInto.SetValidationTypeAsRVariable()
        'ucrFactorInto.SetValidationTypeAsRVariable()
        ucrStackDataInto.SetValidationTypeAsRVariable()
    End Sub

    Private Sub ReopenDialog()
        'TODO this is a work around for AssignTo not clearing in RSyntax
        If ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
    End Sub



    Private Sub TestOKEnabled()
        If ucrReceiverColumnsToBeStack.IsEmpty() OrElse ucrNewDataName.IsEmpty() OrElse ucrStackDataInto.IsEmpty() OrElse ucrFactorInto.IsEmpty() Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrNewDataName.Reset()
        ucrStackDataInto.Reset()
        ucrFactorInto.Reset()
        ucrSelectorStack.Reset()
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        chkColumnsToCarry.Checked = False
        SetColumnsToCarryProperties()
        If (ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") Then
            ucrNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
        SetStackIntoText("value")
        SetFactorIntoText("variable")
    End Sub

    Private Sub SetFactorIntoText(Optional strNewVal As String = Nothing)
        If strNewVal IsNot Nothing Then ucrFactorInto.SetName(strNewVal)
        If ucrFactorInto.GetText = "" Or (ucrFactorInto.Text = "variable" AndAlso (Not frmMain.clsInstatOptions.bIncludeRDefaultParameters)) Then
            ucrBase.clsRsyntax.RemoveParameter("variable.name")
        Else
            ucrBase.clsRsyntax.AddParameter("variable.name", Chr(34) & ucrFactorInto.GetText() & Chr(34))
        End If
        TestOKEnabled()
    End Sub

    Private Sub SetStackIntoText(Optional strNewVal As String = Nothing)
        If strNewVal IsNot Nothing Then ucrStackDataInto.SetName(strNewVal)
        If ucrStackDataInto.IsEmpty Then
            ucrBase.clsRsyntax.RemoveParameter("value.name")
        Else
            ucrBase.clsRsyntax.AddParameter("value.name", Chr(34) & ucrStackDataInto.GetText() & Chr(34))
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkIDVariables_CheckedChanged(sender As Object, e As EventArgs) Handles chkColumnsToCarry.CheckedChanged
        SetColumnsToCarryProperties()
    End Sub

    Private Sub SetColumnsToCarryProperties()
        If chkColumnsToCarry.Checked Then
            ucrColumnsToCarryReceiver.Visible = True
            ucrColumnsToCarryReceiver.SetMeAsReceiver()
            SetIDVars()
        Else
            ucrColumnsToCarryReceiver.Visible = False
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
            ucrBase.clsRsyntax.AddParameter("id.vars", "NULL")
        End If
    End Sub

    Private Sub ucrReceiverColumnsToBeStack_SelectionChanged() Handles ucrReceiverColumnsToBeStack.SelectionChanged
        If Not ucrReceiverColumnsToBeStack.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("measure.vars", ucrReceiverColumnsToBeStack.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("measure.vars")
        End If
        TestOKEnabled()
    End Sub


    Private Sub ucrIDVariablesReceiver_SelectionChanged() Handles ucrColumnsToCarryReceiver.SelectionChanged
        SetIDVars()
    End Sub

    Private Sub SetIDVars()
        If Not ucrColumnsToCarryReceiver.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("id.vars", ucrColumnsToCarryReceiver.GetVariableNames())
        Else
            ucrBase.clsRsyntax.AddParameter("id.vars", "NULL")
        End If
    End Sub

    Private Sub ucrSelectorStack_DataFrameChanged() Handles ucrSelectorStack.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame)

        If (Not ucrNewDataName.UserTyped()) AndAlso ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkIDVariables_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkColumnsToCarry.KeyPress
        If e.KeyChar = vbCr Then
            chkColumnsToCarry.Checked = Not chkColumnsToCarry.Checked
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrNewDataName_NameChanged() Handles ucrNewDataName.NameChanged
        If Not ucrNewDataName.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDataName.GetText(), strTempDataframe:=ucrNewDataName.GetText())
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
        TestOKEnabled()
    End Sub
    Private Sub ucrFactorInto_NameChanged() Handles ucrFactorInto.NameChanged
        SetFactorIntoText()
    End Sub

    Private Sub ucrStackDataInto_NameChanged() Handles ucrStackDataInto.NameChanged
        SetStackIntoText()
    End Sub
End Class
