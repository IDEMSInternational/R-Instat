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
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        If bReset Then
            SetCarryColumnsOptions()
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 57

        ucrSelectorStack.SetParameter(New RParameter("data", 0))
        ucrSelectorStack.SetParameterIsrfunction()

        ucrReceiverColumnsToBeStack.Selector = ucrSelectorStack
        ucrReceiverColumnsToBeStack.SetParameter(New RParameter("measure.vars", 1))
        ucrReceiverColumnsToBeStack.SetParameterIsString()

        ucrColumnsToCarryReceiver.Selector = ucrSelectorStack
        ucrColumnsToCarryReceiver.SetParameter(New RParameter("id.vars", 2))
        ucrColumnsToCarryReceiver.SetParameterIsString()
        ucrColumnsToCarryReceiver.bAddRemoveParameter = False
        ucrColumnsToCarryReceiver.SetValuesToIgnore({"NULL"})

        ucrChkCarryColumns.SetText("Carry Columns")
        ucrChkCarryColumns.AddParameterValuesCondition(True, "id.vars", "NULL", False)
        ucrChkCarryColumns.AddParameterValuesCondition(False, "id.vars", "NULL")
        ' I would like to do this since the checkbox also controls the value of id.vars
        ' but there is confusion with both controls setting the value of the same parameter at the same time. For now the writing is done manually in this dialog.
        'ucrChkCarryColumns.SetParameter(ucrColumnsToCarryReceiver.GetParameter(), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="", strNewValueIfUnchecked:="NULL")
        'We don't want the receiver to remove the parameter when the checkbox is unchecked since the id.vars parameter will always be given.
        ucrChkCarryColumns.AddToLinkedControls(ucrColumnsToCarryReceiver, {True}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)

        ucrFactorInto.SetParameter(New RParameter("variable.name", 3))
        ucrFactorInto.SetValidationTypeAsRVariable()

        ucrStackDataInto.SetParameter(New RParameter("value.name", 4))
        ucrStackDataInto.SetValidationTypeAsRVariable()

        ucrSaveNewDataName.SetIsTextBox()
        ucrSaveNewDataName.SetLabelText("New Data Frame Name:")
        ucrSaveNewDataName.SetSaveTypeAsDataFrame()
        ucrSaveNewDataName.SetDataFrameSelector(ucrSelectorStack.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDataFrameName()
        If ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso (Not ucrSaveNewDataName.bUserTyped) Then
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

        clsMelt.SetRCommand("melt")
        clsMelt.AddParameter("variable.name", Chr(34) & "variable" & Chr(34))
        clsMelt.AddParameter("value.name", Chr(34) & "value" & Chr(34))
        clsMelt.AddParameter("id.vars", "NULL")
        clsMelt.SetAssignTo(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked", strTempDataframe:=ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")

        ucrBase.clsRsyntax.SetBaseRFunction(clsMelt)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverColumnsToBeStack_ControlContentesChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToBeStack.ControlContentsChanged, ucrStackDataInto.ControlContentsChanged, ucrFactorInto.ControlContentsChanged, ucrSaveNewDataName.ControlContentsChanged, ucrChkCarryColumns.ControlContentsChanged, ucrColumnsToCarryReceiver.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkCarryColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCarryColumns.ControlValueChanged
        SetCarryColumnsOptions()
    End Sub

    Private Sub SetCarryColumnsOptions()
        If ucrChkCarryColumns.Checked Then
            ucrColumnsToCarryReceiver.SetMeAsReceiver()
            If Not ucrColumnsToCarryReceiver.IsEmpty() Then
                clsMelt.AddParameter("id.vars", ucrColumnsToCarryReceiver.GetVariableNames())
            End If
        Else
            ucrReceiverColumnsToBeStack.SetMeAsReceiver()
            clsMelt.AddParameter("id.vars", "NULL")
        End If
    End Sub

    Private Sub ucrSelectorStack_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorStack.ControlValueChanged
        SetDataFrameName()
        SetCarryColumnsOptions()
    End Sub
End Class
