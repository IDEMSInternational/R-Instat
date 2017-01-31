
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
    Private clsDefaultFunction As New RFunction
    Private Sub dlgIndicatorVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
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
        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorDummyVariable.Focus()
        ucrSelectorDummyVariable.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOkEnabled()
    End Sub

    Public Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 41
        clsDefaultFunction.SetRCommand("dummy")

        'Set Receiver
        ucrReceiverFactor.Selector = ucrSelectorDummyVariable
        ucrVariateReceiver.Selector = ucrSelectorDummyVariable
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.SetParameter(New RParameter("x"))

        'Set RadioBattons : Parameters yet to be set up
        ucrPnlLevelOmitted.SetParameter(New RParameter(""))
        ucrPnlLevelOmitted.AddRadioButton(rdoNone, "")
        ucrPnlLevelOmitted.AddRadioButton(rdoFirst, "")
        ucrPnlLevelOmitted.AddRadioButton(rdoLast, "")
        ucrPnlLevelOmitted.AddRadioButton(rdoLevelNumber, "")




        ucrChkWithXVariable.SetText("With X Variable")
        ucrChkWithXVariable.SetParameter(New RParameter(""))

        'Note: This was not implemented (Additions of ucrInputColumns were added for appending new columns with prefix "dummy" ): Just added if incase it was to be added otherwise it can be deleted

        'ucrSaveDummy.SetPrefix("dummy")
        'ucrSaveDummy.SetSaveTypeAsColumn()
        'ucrSaveDummy.SetDataFrameSelector(ucrSelectorDummyVariable.ucrAvailableDataFrames)
        'ucrSaveDummy.SetCheckBoxText("Save Dummy")
        'ucrSaveDummy.SetIsComboBox()
        'clsDefaultFunction.SetAssignTo("dummy", strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="dummy")

        'chkXvariable.Checked = False
        ucrVariateReceiver.Visible = False
        lblVariate.Visible = False
        grpLevelOmitted.Enabled = False
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="dummy_vars", strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Private Sub VariateVisible()
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
    Private Sub ucrreceiverfactor_selectionchanged(sender As Object, e As EventArgs) Handles ucrReceiverFactor.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFactor.GetVariables)
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorDummyVariable_DataFrameChanged() Handles ucrSelectorDummyVariable.DataFrameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="dummy_vars", strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlLevelOmitted.ControlValueChanged
        VariateVisible()
    End Sub

End Class