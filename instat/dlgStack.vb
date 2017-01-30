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
        ucrReceiverColumnsToBeStack.SetMeAsReceiver()
        ucrColumnsToCarryReceiver.SetMeAsReceiver()

        ucrSelectorStack.SetParameter(New RParameter("data", 0))
        ucrSelectorStack.SetParameterIsrfunction()

        ucrChkCarryColumns.SetText("Carry Columns")

        AddSuffix()

        ucrReceiverColumnsToBeStack.SetParameter(New RParameter("measure.vars", 1))
        ucrReceiverColumnsToBeStack.SetParameterIsString()

        ucrColumnsToCarryReceiver.SetParameter(New RParameter("id.vars", 2))
        ucrColumnsToCarryReceiver.SetParameterIsString()

        ucrFactorInto.SetParameter(New RParameter("variable.name", 3))

        ucrFactorInto.SetParameter(New RParameter("value.name", 4))



        ucrNewDataName.SetValidationTypeAsRVariable()
        'TODO Should this be enforced for column names?
        'ucrStackDataInto.SetValidationTypeAsRVariable()
        'ucrFactorInto.SetValidationTypeAsRVariable()
        ucrStackDataInto.SetValidationTypeAsRVariable()
        clsMelt.AddParameter("variable.name", Chr(34) & ucrFactorInto.GetText() & Chr(34))
        clsMelt.AddParameter("id.vars", "NULL")
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
        ucrBase.clsRsyntax.SetBaseRFunction(clsMelt.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)

        If (ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") Then
            ucrNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
        'SetStackIntoText("value")
        'SetFactorIntoText("variable")
    End Sub

    'Private Sub SetFactorIntoText(Optional strNewVal As String = Nothing)
    '    If strNewVal IsNot Nothing Then ucrFactorInto.SetName(strNewVal)
    '    If ucrFactorInto.GetText = "" Or (ucrFactorInto.Text = "variable" AndAlso (Not frmMain.clsInstatOptions.bIncludeRDefaultParameters)) Then
    '        ucrBase.clsRsyntax.RemoveParameter("variable.name")
    '    Else
    '        ucrBase.clsRsyntax.AddParameter("variable.name", Chr(34) & ucrFactorInto.GetText() & Chr(34))
    '    End If
    '    TestOKEnabled()
    'End Sub

    'Private Sub SetStackIntoText(Optional strNewVal As String = Nothing)
    '    If strNewVal IsNot Nothing Then ucrStackDataInto.SetName(strNewVal)
    '    If ucrStackDataInto.IsEmpty Then
    '        ucrBase.clsRsyntax.RemoveParameter("value.name")
    '    Else
    '        ucrBase.clsRsyntax.AddParameter("value.name", Chr(34) & ucrStackDataInto.GetText() & Chr(34))
    '    End If
    '    TestOKEnabled()
    'End Sub

    Private Sub chkIDVariables_CheckedChanged(sender As Object, e As EventArgs)
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
        If (Not ucrNewDataName.UserTyped()) AndAlso ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataName.SetName(ucrSelectorStack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stacked")
        End If
    End Sub

    Private Sub chkIDVariables_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = vbCr Then
            ucrChkCarryColumns.Checked = Not ucrChkCarryColumns.Checked
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverColumnsToBeStack_ControlContentesChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnsToBeStack.ControlContentsChanged, ucrNewDataName.ControlContentsChanged, ucrStackDataInto.ControlContentsChanged, ucrFactorInto.ControlContentsChanged
        TestOKEnabled()

    End Sub

    'Private Sub ucrNewDataName_NameChanged() Handles ucrNewDataName.NameChanged
    '    If Not ucrNewDataName.IsEmpty Then
    '        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataName.GetText(), strTempDataframe:=ucrNewDataName.GetText())
    '    Else
    '        ucrBase.clsRsyntax.RemoveAssignTo()
    '    End If
    '    TestOKEnabled()
    'End Sub
End Class
