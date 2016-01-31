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
    Private Sub dlgStack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set receiver/selector options
        ucrIDVariablesReceiver.Visible = False
        ucrReceiverColumnsToBeStack.Selector = ucrDataFrameAddRemove
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        ucrIDVariablesReceiver.Selector = ucrDataFrameAddRemove

        'Set function parameters/settings
        ucrBase.clsRsyntax.SetFunction("melt")

        txtFactorInto.Text = "Variable"
        ucrBase.clsRsyntax.AddParameter("variable.name", Chr(34) & txtFactorInto.Text & Chr(34))

        txtStackDataInto.Text = "Value"
        ucrBase.clsRsyntax.AddParameter("value.name", Chr(34) & txtStackDataInto.Text & Chr(34))

        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrDataFrameAddRemove.ucrAvailableDataFrames.clsCurrDataFrame)

        ucrNewDataFrameName.txtValidation.Text = ucrDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked"
        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.txtValidation.Text, strTempDataframe:=ucrNewDataFrameName.txtValidation.Text)

        autoTranslate(Me)
    End Sub

    Private Sub chkIDVariables_CheckedChanged(sender As Object, e As EventArgs) Handles chkIDVariables.CheckedChanged
        If chkIDVariables.Checked = True Then
            ucrIDVariablesReceiver.Visible = True
            ucrIDVariablesReceiver.Focus()
        Else
            ucrIDVariablesReceiver.Visible = False
        End If
    End Sub

    Private Sub ucrIDVariablesReceiver_Enter(sender As Object, e As EventArgs) Handles ucrIDVariablesReceiver.Enter
        ucrIDVariablesReceiver.SetMeAsReceiver()
    End Sub

    Private Sub ucrReceiverColumnsToBeStack_Leave(sender As Object, e As EventArgs) Handles ucrReceiverColumnsToBeStack.Leave
        ucrBase.clsRsyntax.AddParameter("measure.vars", ucrReceiverColumnsToBeStack.GetVariableNames())
    End Sub
    Private Sub ucrIDVariablesReceiver_Leave(sender As Object, e As EventArgs) Handles ucrIDVariablesReceiver.Leave
        ucrBase.clsRsyntax.AddParameter("id.vars", ucrIDVariablesReceiver.GetVariableNames())
    End Sub

    Private Sub txtFactorInto_Leave(sender As Object, e As EventArgs) Handles txtFactorInto.Leave
        ucrBase.clsRsyntax.AddParameter("variable.name", Chr(34) & txtFactorInto.Text & Chr(34))
    End Sub

    Private Sub txtStackDataInto_Leave(sender As Object, e As EventArgs) Handles txtStackDataInto.Leave
        ucrBase.clsRsyntax.AddParameter("value.name", Chr(34) & txtStackDataInto.Text & Chr(34))
    End Sub

    Private Sub ucrNewDataFrameName_Leave(sender As Object, e As EventArgs) Handles ucrNewDataFrameName.Leave
        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.txtValidation.Text, strTempDataframe:=ucrNewDataFrameName.txtValidation.Text)
    End Sub

    Private Sub ucrDataFrameAddRemove_DataFrameChanged(sender As Object, e As EventArgs) Handles ucrDataFrameAddRemove.DataFrameChanged
        If Not ucrNewDataFrameName.bUserTyped Then
            ucrNewDataFrameName.txtValidation.Text = ucrDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked"
        End If
    End Sub
End Class