
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
Public Class dlgDummyVariables
    Private bFirstLoad As Boolean = True
    Private Sub dlgIndicatorVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()

        End If
        autoTranslate(Me)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFactor.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        ucrSelectorDummyVariable.Focus()
        ucrSelectorDummyVariable.Reset()
        ucrReceiverFactor.Selector = ucrSelectorDummyVariable
        ucrReceiverFactor.SetMeAsReceiver()
        chkXvariable.Checked = False
        TestOkEnabled()
        chkXvariable.Enabled = False
    End Sub

    Public Sub InitialiseDialog()

        'ucrInputColumns.SetItemsTypeAsColumns()
        'ucrInputColumns.SetDefaultTypeAsColumn()
        'ucrInputColumns.SetPrefix("dummy")
        'ucrInputColumns.SetDataFrameSelector(ucrSelectorDummyVariable.ucrAvailableDataFrames)

        ucrBase.iHelpTopicID = 41
        ucrReceiverFactor.Selector = ucrSelectorDummyVariable
        ucrVariateReceiver.Selector = ucrSelectorDummyVariable
        ucrReceiverFactor.SetMeAsReceiver()

        ucrReceiverFactor.SetIncludedDataTypes({"factor"})

        chkXvariable.Checked = False
        ucrVariateReceiver.Visible = False
        lblVariate.Visible = False
        grpLevelOmitted.Enabled = False

        ucrBase.clsRsyntax.SetFunction("dummy")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="dummy_vars", strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub chkXvariable_CheckedChanged(sender As Object, e As EventArgs) Handles chkXvariable.CheckedChanged
        If chkXvariable.Checked Then
            ucrVariateReceiver.Visible = True
            lblVariate.Visible = True
            ucrVariateReceiver.SetMeAsReceiver()
        Else
            ucrVariateReceiver.Visible = False
            lblVariate.Visible = False
            ucrReceiverFactor.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
    Private Sub ucrReceiverFactor_Selectionchanged(sender As Object, e As EventArgs) Handles ucrReceiverFactor.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFactor.GetVariables)
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorDummyVariable_DataFrameChanged() Handles ucrSelectorDummyVariable.DataFrameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="dummy_vars", strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub
End Class