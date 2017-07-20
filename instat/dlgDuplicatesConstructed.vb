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

        ucrSelectDataFrameDuplicates.SetParameter(New RParameter("x", 1))
        ucrSelectDataFrameDuplicates.SetParameterIsRFunction()

        ucrReceiverMultipleForDuplicates.SetParameter(New RParameter("x", 1))
        ucrReceiverMultipleForDuplicates.SetParameterIsRFunction()

        ucrReceiverMultipleForDuplicates.Selector = ucrSelectorDuplicateswithVariables
        ucrReceiverMultipleForDuplicates.SetMeAsReceiver()

        ucrPnlDuplicates.AddRadioButton(rdoAllduplicatecases)
        ucrPnlDuplicates.AddRadioButton(rdoDuplicatesonly)
        ucrPnlDuplicates.AddRadioButton(rdoIndexnumberofduplicates)

        ucrPnlDuplicates.AddFunctionNamesCondition(rdoAllduplicatecases, "duplicated2")
        ucrPnlDuplicates.AddFunctionNamesCondition(rdoDuplicatesonly, "duplicated")
        rdoIndexnumberofduplicates.Enabled = False 'for now until it's working properly

        ucrNewColumnName.SetPrefix("Dup")
        ucrNewColumnName.SetDataFrameSelector(ucrSelectDataFrameDuplicates)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetLabelText("New Column Name:")

    End Sub

    Private Sub SetDefaults()
        clsDuplicated = New RFunction
        clsDuplicate2 = New RFunction

        ucrNewColumnName.Reset()
        ucrSelectDataFrameDuplicates.Reset()

        clsDuplicated.SetRCommand("duplicated")
        clsDuplicate2.SetPackageName("questionr")
        clsDuplicate2.SetRCommand("duplicated2")
        Dataframe()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameDuplicates.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDuplicated)


    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ' ucrNewColumnName.AddAdditionalRCode(clsDuplicated, 1)
        ucrReceiverMultipleForDuplicates.SetRCode(clsDuplicated, bReset)
        ucrSelectDataFrameDuplicates.SetRCode(clsDuplicated, bReset)
        ucrNewColumnName.SetRCode(clsDuplicated, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverMultipleForDuplicates.IsEmpty AndAlso ucrSelectDataFrameDuplicates.cboAvailableDataFrames.Text <> "" AndAlso ucrNewColumnName.IsComplete Then
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

    Private Sub Dataframe()
        If rdoDataframe.Checked Then
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(False)
            ucrSelectorDuplicateswithVariables.Reset()
        Else
            ucrSelectorDuplicateswithVariables.SetVariablesVisible(True)
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlContentsChanged
        Dataframe()
    End Sub

    Private Sub ucrNewColumnName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrSelectDataFrameDuplicates.ControlContentsChanged, ucrReceiverMultipleForDuplicates.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class