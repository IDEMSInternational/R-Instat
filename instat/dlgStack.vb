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
        ucrBase.clsRsyntax.SetFunction("melt")
        ucrBase.clsRsyntax.AddParameter("variable.name", Chr(34) & txtFactorInto.Text & Chr(34))
        ucrBase.clsRsyntax.AddParameter("value.name", Chr(34) & txtStackDataInto.Text & Chr(34))
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorStack.ucrAvailableDataFrames.clsCurrDataFrame)
        ucrNewDataFrameName.txtValidation.Text = ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked"
        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.txtValidation.Text, strTempDataframe:=ucrNewDataFrameName.txtValidation.Text)
        ucrBase.iHelpTopicID = 57
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        'Checks if Ok can be enabled.

        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()


    End Sub
    Private Sub TestOKEnabled()
        If ucrReceiverColumnsToBeStack.GetVariableNames() <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        'Set receiver/selector options
        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrIDVariablesReceiver.Selector = ucrSelectorStack
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        ucrIDVariablesReceiver.Visible = False
        txtStackDataInto.Text = "Value"
        txtFactorInto.Text = "Variable"
        autoTranslate(Me)

    End Sub


    Private Sub chkIDVariables_CheckedChanged(sender As Object, e As EventArgs) Handles chkIDVariables.CheckedChanged
        If chkIDVariables.Checked = True Then
            ucrIDVariablesReceiver.Visible = True
            ucrIDVariablesReceiver.Focus()
            ucrIDVariablesReceiver.SetMeAsReceiver()
        Else
            ucrIDVariablesReceiver.Visible = False
        End If
    End Sub

    Private Sub ucrReceiverColumnsToBeStack_SelectionChanged() Handles ucrReceiverColumnsToBeStack.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("measure.vars", ucrReceiverColumnsToBeStack.GetVariableNames())
        TestOKEnabled()
    End Sub


    Private Sub ucrIDVariablesReceiver_SelectionChanged() Handles ucrIDVariablesReceiver.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("id.vars", ucrIDVariablesReceiver.GetVariableNames())
        TestOKEnabled()
    End Sub

    Private Sub txtFactorInto_Leave(sender As Object, e As EventArgs) Handles txtFactorInto.Leave
        ucrBase.clsRsyntax.AddParameter("variable.name", Chr(34) & txtFactorInto.Text & Chr(34))
        TestOKEnabled()
    End Sub

    Private Sub txtStackDataInto_Leave(sender As Object, e As EventArgs) Handles txtStackDataInto.Leave
        ucrBase.clsRsyntax.AddParameter("value.name", Chr(34) & txtStackDataInto.Text & Chr(34))
        TestOKEnabled()
    End Sub

    Private Sub ucrNewDataFrameName_Leave(sender As Object, e As EventArgs) Handles ucrNewDataFrameName.Leave
        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.txtValidation.Text, strTempDataframe:=ucrNewDataFrameName.txtValidation.Text)

    End Sub

    Private Sub ucrDataFrameAddRemove_DataFrameChanged() Handles ucrSelectorStack.DataFrameChanged
        If Not ucrNewDataFrameName.bUserTyped Then
            ucrNewDataFrameName.txtValidation.Text = ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked"
        End If
    End Sub

    Private Sub chkIDVariables_KeyPress(sender As Object, e As KeyPressEventArgs) Handles chkIDVariables.KeyPress
        If chkIDVariables.Checked = True And e.KeyChar = vbCr Then
            chkIDVariables.Checked = False
        Else
            chkIDVariables.Checked = True
        End If
    End Sub


End Class