' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat
Imports instat.Translations

Public Class dlgDuplicatesConstructed
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsDuplicate2, clsDuplicated As New RFunction
    Private Sub dlgDuplicatesConstructed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrReceiverMultipleForDuplicates.SetParameter(New RParameter("x", 1))
        ucrReceiverMultipleForDuplicates.SetParameterIsRFunction()
        ucrReceiverMultipleForDuplicates.Selector = ucrSelectorDuplicateswithVariables

        ucrPnlDuplicates.AddRadioButton(rdoAllduplicatecases)
        ucrPnlDuplicates.AddRadioButton(rdoDuplicatesonly)
        ucrPnlDuplicates.AddRadioButton(rdoIndexnumberofduplicates)

        ucrPnlOptions.AddRadioButton(rdoDataframe)
        ucrPnlOptions.AddRadioButton(rdoSelectedVariables)

        ucrPnlOptions.AddFunctionNamesCondition(rdoSelectedVariables, "duplicated")
        ucrPnlOptions.AddFunctionNamesCondition(rdoDataframe, "duplicated2")

        ucrPnlDuplicates.AddFunctionNamesCondition(rdoAllduplicatecases, "duplicated2")
        ucrPnlDuplicates.AddFunctionNamesCondition(rdoDuplicatesonly, "duplicated")
        rdoIndexnumberofduplicates.Enabled = False 'for now until it's working properly

        ttDuplicates.SetToolTip(rdoAllduplicatecases, "All cases are given as being duplicate rows")
        ttDuplicates.SetToolTip(rdoDuplicatesonly, "The first occurrence is not indicated, but further instances are considered duplicates")
        ttDuplicates.SetToolTip(rdoIndexnumberofduplicates, "Any duplicates are given their index number")

        ucrNewColumnName.SetPrefix("Dup")
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetLabelText("New Column Name:")

    End Sub

    Private Sub SetDefaults()
        clsDuplicated = New RFunction
        clsDuplicate2 = New RFunction

        ucrNewColumnName.Reset()
        ucrSelectorDuplicateswithVariables.Reset()
        ucrReceiverMultipleForDuplicates.SetMeAsReceiver()

        clsDuplicated.SetRCommand("duplicated")
        clsDuplicate2.SetPackageName("questionr")
        clsDuplicate2.SetRCommand("duplicated2")

        SetBaseFunction()
        DataframeParam()

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicate2)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverMultipleForDuplicates.AddAdditionalCodeParameterPair(clsDuplicate2, ucrReceiverMultipleForDuplicates.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverMultipleForDuplicates.SetRCode(clsDuplicated, bReset)
        ucrNewColumnName.AddAdditionalRCode(clsDuplicate2, 1)
        ucrNewColumnName.SetRCode(clsDuplicated, bReset)
        ucrPnlDuplicates.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverMultipleForDuplicates.IsEmpty OrElse ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") AndAlso ucrNewColumnName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        DataframeParam()
    End Sub

    Private Sub DataframeParam()
        If rdoDataframe.Checked Then
            clsDuplicate2.AddParameter("x", ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
            clsDuplicated.AddParameter("x", ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(False)
            ucrReceiverMultipleForDuplicates.Visible = False
        Else
            clsDuplicate2.AddParameter("x", ucrReceiverMultipleForDuplicates.GetVariableNames)
            clsDuplicated.AddParameter("x", ucrReceiverMultipleForDuplicates.GetVariableNames)
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(True)
            ucrReceiverMultipleForDuplicates.Visible = True

        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoAllduplicatecases.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicate2)
        ElseIf rdoDuplicatesonly.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated)
        End If
    End Sub
    Private Sub ucrNewColumnName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrReceiverMultipleForDuplicates.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlDuplicates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDuplicates.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrSelectorDuplicateswithVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDuplicateswithVariables.ControlValueChanged
        DataframeParam()
    End Sub
End Class