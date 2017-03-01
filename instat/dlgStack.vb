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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgStack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 57
        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrColumnsToCarryReceiver.Selector = ucrSelectorStack
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        ucrSelectorStack.SetParameter(New RParameter("data", 0))
        ucrSelectorStack.SetParameterIsrfunction()
        ucrChkCarryColumns.SetText("Carry Columns")
        ucrReceiverColumnsToBeStack.SetParameter(New RParameter("measure.vars", 1))
        ucrReceiverColumnsToBeStack.SetParameterIsString()
        ucrChkCarryColumns.AddToLinkedControls(ucrColumnsToCarryReceiver, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrColumnsToCarryReceiver.SetParameter(New RParameter("id.vars", 2))
        ucrColumnsToCarryReceiver.SetParameterIsString()
        ucrChkCarryColumns.SetParameter(ucrColumnsToCarryReceiver.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrFactorInto.SetParameter(New RParameter("variable.name", 3))
        ucrStackDataInto.SetParameter(New RParameter("value.name", 4))
        'TODO Should this be enforced for column names?
        ucrSaveNewDataName.SetIsTextBox()
        ucrSaveNewDataName.SetLabelText("New Data Frame Name:")
        ucrStackDataInto.SetValidationTypeAsRVariable()
        ucrFactorInto.SetValidationTypeAsRVariable()
    End Sub

    Private Sub ReopenDialog()
        StackDataFrame()
    End Sub

    Private Sub StackDataFrame()
        'TODO this is a work around for AssignTo not clearing in RSyntax
        If ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrSaveNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveNewDataName.IsComplete AndAlso Not ucrStackDataInto.IsEmpty() AndAlso Not ucrFactorInto.IsEmpty() Then
            If Not ucrChkCarryColumns.Checked Then
                If Not ucrReceiverColumnsToBeStack.IsEmpty() Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                If Not ucrColumnsToCarryReceiver.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
        clsMelt = New RFunction
        ucrSelectorStack.Reset()
        ucrSaveNewDataName.Reset()
        ucrStackDataInto.Reset()
        ucrFactorInto.Reset()
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        ucrFactorInto.SetName("variable")
        ucrStackDataInto.SetName("value")
        clsMelt.SetAssignTo(ucrSaveNewDataName.GetText(), strTempDataframe:=ucrSaveNewDataName.GetText())
        AddSuffix()
        clsMelt.AddParameter("variable.name", Chr(34) & ucrFactorInto.GetText() & Chr(34))
        clsMelt.SetRCommand("melt")
        ucrBase.clsRsyntax.SetBaseRFunction(clsMelt)
    End Sub

    Private Sub AddSuffix()
        If (Not ucrSaveNewDataName.bUserTyped) AndAlso ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrSaveNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
    End Sub

    Private Sub chkIDVariables_KeyPress(sender As Object, e As KeyPressEventArgs) Handles ucrChkCarryColumns.KeyPress
        If e.KeyChar = vbCr Then
            ucrChkCarryColumns.Checked = Not ucrChkCarryColumns.Checked
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverColumnsToBeStack_ControlContentesChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToBeStack.ControlContentsChanged, ucrStackDataInto.ControlContentsChanged, ucrFactorInto.ControlContentsChanged, ucrSaveNewDataName.ControlContentsChanged, ucrChkCarryColumns.ControlContentsChanged, ucrColumnsToCarryReceiver.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrsavenewdataname_cotrolvaluechanged(ucrchangedcontrol As ucrCore) Handles ucrSaveNewDataName.ControlValueChanged
        clsMelt.SetAssignTo(ucrSaveNewDataName.GetText(), strTempDataframe:=ucrSaveNewDataName.GetText())
    End Sub

    Private Sub ucrChkCarryColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCarryColumns.ControlValueChanged
        If ucrChkCarryColumns.Checked Then
            ucrColumnsToCarryReceiver.SetMeAsReceiver()
        Else
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrSelectorStack_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorStack.ControlValueChanged
        StackDataFrame()
    End Sub
End Class
