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
Public Class dlgAugment
    Public bfirstload As Boolean = True
    Public bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsAugment As New RFunction

    Private Sub dlgTidy_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bfirstload Then
            InitialiseDialog()
            bfirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrModelReceiver.SetItemType("model")
        ucrModelReceiver.strSelectorHeading = "Model"
        ucrModelReceiver.SetParameterIsRFunction()
        ucrModelReceiver.Selector = ucrModelSelector

        ucrModelSelector.SetParameter(New RParameter("data", 0))
        ucrModelSelector.SetParameterIsrfunction()

        ucrPnlOptions.AddRadioButton(rdoAddToDataFrame)
        ucrPnlOptions.AddRadioButton(rdoDisplayInOutput)
        ucrPnlOptions.AddRadioButton(rdoNewDataFrame)

        ucrPnlOptions.bAllowNonConditionValues = True

        ucrPnlOptions.AddToLinkedControls(ucrSaveNewDataFrame, {rdoNewDataFrame}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ucrSaveNewDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveNewDataFrame.lblSaveText.Visible = False
        ucrSaveNewDataFrame.SetLabelText("")
        ucrSaveNewDataFrame.SetPrefix("augment_dataframe")
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrModelSelector.ucrAvailableDataFrames)

        ucrModelReceiver.SetParameter(New RParameter("x", 0))
        ucrModelReceiver.Selector = ucrModelSelector
        ucrModelReceiver.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        clsAugment = New RFunction

        rdoAddToDataFrame.Checked = True

        ucrModelSelector.Reset()
        ucrSaveNewDataFrame.Reset()
        ucrBase.clsRsyntax.iCallType = 2

        clsAugment.SetRCommand("augment")
        clsAugment.SetPackageName("broom")

        SetDefaultNewDataFrameName()
        ucrBase.clsRsyntax.SetBaseRFunction(clsAugment)
        UpdateAssignTo()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrModelReceiver.SetRCode(clsAugment, bReset)
        UpdateAssignTo()
    End Sub

    Private Sub TestOKEnabled()
        'Tests when ok can be enabled
        If (rdoNewDataFrame.Checked AndAlso ucrSaveNewDataFrame.IsComplete AndAlso Not ucrModelReceiver.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoDisplayInOutput.Checked AndAlso Not ucrModelReceiver.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoAddToDataFrame.Checked AndAlso Not ucrModelReceiver.IsEmpty()) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaultNewDataFrameName()
        If ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrSaveNewDataFrame.SetPrefix("augment_" & ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoDisplayInOutput.Checked Then
            ucrBase.clsRsyntax.RemoveAssignTo()
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoAddToDataFrame.Checked Then
            ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="augment_data", strTempDataframe:=ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
            ucrBase.clsRsyntax.iCallType = 0
        End If
        If rdoNewDataFrame.Checked Then
            clsAugment.SetAssignTo(ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempDataframe:=ucrSaveNewDataFrame.GetText)
            ucrBase.clsRsyntax.iCallType = 0
        End If
    End Sub

    Private Sub UpdateAssignTo()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="augment_data", strTempDataframe:=ucrModelSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrModelReceiver.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrModelSelector_DataFrameChanged() Handles ucrModelSelector.DataFrameChanged
        SetDefaultNewDataFrameName()
    End Sub
End Class