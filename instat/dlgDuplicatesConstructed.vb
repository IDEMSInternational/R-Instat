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
        ucrPnlOptions.AddRadioButton(rdoDataFrame)
        ucrPnlOptions.AddRadioButton(rdoSelectedVariables)

        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoDataFrame, "x", frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoSelectedVariables, "x", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")

        ucrPnlOptions.AddToLinkedControls(ucrReceiverMultipleForDuplicates, {rdoSelectedVariables}, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorDuplicateswithVariables.SetParameter(New RParameter("x", 0))
        ucrSelectorDuplicateswithVariables.SetParameterIsrfunction()

        ucrReceiverMultipleForDuplicates.SetParameter(New RParameter("x", 0))
        ucrReceiverMultipleForDuplicates.SetParameterIsRFunction()
        ucrReceiverMultipleForDuplicates.Selector = ucrSelectorDuplicateswithVariables

        ucrPnlDuplicates.AddRadioButton(rdoAllDuplicateCases)
        ucrPnlDuplicates.AddRadioButton(rdoDuplicatesOnly)
        ucrPnlDuplicates.AddRadioButton(rdoIndexNumberOfDuplicates)

        ucrPnlDuplicates.AddFunctionNamesCondition(rdoAllDuplicateCases, "duplicated2")
        ucrPnlDuplicates.AddFunctionNamesCondition(rdoDuplicatesOnly, "duplicated")
        rdoIndexNumberOfDuplicates.Enabled = False 'for now until it's working properly

        ttDuplicates.SetToolTip(rdoAllDuplicateCases, "All cases are given as being duplicate rows")
        ttDuplicates.SetToolTip(rdoDuplicatesOnly, "The first occurrence is not indicated, but further instances are considered duplicates")
        ttDuplicates.SetToolTip(rdoIndexNumberOfDuplicates, "Any duplicates are given their index number")

        ucrNewColumnName.SetPrefix("dup")
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
        clsDuplicate2.AddParameter("x", frmMain.clsRLink.strInstatDataObject & "$get_data_frame", iPosition:=0)

        SetBaseFunction()
        DataFrameParameter()

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicate2)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverMultipleForDuplicates.AddAdditionalCodeParameterPair(clsDuplicate2, ucrReceiverMultipleForDuplicates.GetParameter, iAdditionalPairNo:=1)
        ucrSelectorDuplicateswithVariables.AddAdditionalCodeParameterPair(clsDuplicate2, ucrSelectorDuplicateswithVariables.GetParameter, iAdditionalPairNo:=1)
        ucrNewColumnName.AddAdditionalRCode(clsDuplicate2, 1)
        ucrSelectorDuplicateswithVariables.SetRCode(clsDuplicated, bReset)
        ucrReceiverMultipleForDuplicates.SetRCode(clsDuplicated, bReset)
        ucrNewColumnName.SetRCode(clsDuplicated, bReset)
        ucrPnlDuplicates.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlOptions.SetRCode(clsDuplicate2, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewColumnName.IsComplete Then
            If (rdoDataFrame.Checked AndAlso ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "") OrElse (rdoSelectedVariables.Checked AndAlso Not ucrReceiverMultipleForDuplicates.IsEmpty) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrPnlDuplicates.ControlValueChanged
        DataFrameParameter()
    End Sub

    Private Sub DataFrameParameter()
        If rdoDataFrame.Checked Then
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(False)
            clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
            clsDuplicate2.AddParameter("x", clsRFunctionParameter:=ucrSelectorDuplicateswithVariables.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        ElseIf rdoSelectedVariables.Checked Then
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(True)
            clsDuplicated.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleForDuplicates.GetVariables, iPosition:=0)
            clsDuplicate2.AddParameter("x", clsRFunctionParameter:=ucrReceiverMultipleForDuplicates.GetVariables, iPosition:=0)
        Else
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoAllDuplicateCases.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicate2)
        ElseIf rdoDuplicatesOnly.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated)
        End If
    End Sub

    Private Sub ucrPnlDuplicates_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDuplicates.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrSelectorDuplicateswithVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDuplicateswithVariables.ControlValueChanged
        DataFrameParameter()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrReceiverMultipleForDuplicates.ControlContentsChanged, ucrSelectorDuplicateswithVariables.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class