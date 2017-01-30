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
    Private clsMelt As New RFunction
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
        ucrBase.iHelpTopicID = 57
        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrColumnsToCarryReceiver.Selector = ucrSelectorStack
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        ucrSelectorStack.SetParameter(New RParameter("data", 0))
        ucrSelectorStack.SetParameterIsrfunction()
        ucrChkCarryColumns.SetText("Carry Columns")
        ucrFactorInto.SetName("variable")
        ucrStackDataInto.SetName("value")
        ucrReceiverColumnsToBeStack.SetParameter(New RParameter("measure.vars", 1))
        ucrReceiverColumnsToBeStack.SetParameterIsString()
        ucrColumnsToCarryReceiver.SetParameter(New RParameter("id.vars", 2))
        ucrColumnsToCarryReceiver.SetParameterIsString()
        ucrFactorInto.SetParameter(New RParameter("variable.name", 3))
        ucrStackDataInto.SetParameter(New RParameter("value.name", 4))
        ucrNewDataName.SetValidationTypeAsRVariable()
        'TODO Should this be enforced for column names?
        'ucrStackDataInto.SetValidationTypeAsRVariable()
        'ucrFactorInto.SetValidationTypeAsRVariable()
        ucrStackDataInto.SetValidationTypeAsRVariable()
        clsMelt.AddParameter("variable.name", Chr(34) & ucrFactorInto.GetText() & Chr(34))
        clsMelt.SetRCommand("melt")
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
        ucrChkCarryColumns.Checked = False
        SetColumnsToCarryProperties()
        AddSuffix()
        ucrBase.clsRsyntax.SetBaseRFunction(clsMelt.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub chkIDVariables_CheckedChanged() Handles ucrChkCarryColumns.ControlValueChanged
        SetColumnsToCarryProperties()
    End Sub

    Private Sub SetColumnsToCarryProperties()
        If ucrChkCarryColumns.Checked Then
            ucrColumnsToCarryReceiver.Visible = True
            ucrColumnsToCarryReceiver.SetMeAsReceiver()
        Else
            ucrColumnsToCarryReceiver.Visible = False
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        End If
    End Sub

    Private Sub AddSuffix()
        If (Not ucrNewDataName.bUserTyped) AndAlso ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
    End Sub

    Private Sub chkIDVariables_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ucrChkCarryColumns.KeyPress
        If e.KeyChar = vbCr Then
            ucrChkCarryColumns.Checked = Not ucrChkCarryColumns.Checked
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverColumnsToBeStack_ControlContentesChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToBeStack.ControlContentsChanged, ucrNewDataName.ControlContentsChanged, ucrStackDataInto.ControlContentsChanged, ucrFactorInto.ControlContentsChanged, ucrNewDataName.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrNewDataName_CotrolValueChanged(ucrChangedControl As ucrCore) Handles ucrNewDataName.ControlValueChanged
        NewDataName()
    End Sub
    Private Sub NewDataName()
        If Not ucrNewDataName.IsEmpty Then
            clsMelt.SetAssignTo(ucrNewDataName.GetText(), strTempDataframe:=ucrNewDataName.GetText())
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub
End Class
