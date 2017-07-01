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
Public Class dlgPrincipalComponentAnalysis
    Public bFirstLoad As Boolean = True
    Public ExplanatoryVariables
    Public strModelName As String = ""

    Private Sub dlgPrincipalComponentAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBasePCA.clsRsyntax.SetPackageName("FactoMineR")
        ucrBasePCA.clsRsyntax.SetFunction("PCA")
        ucrBasePCA.clsRsyntax.iCallType = 0
        ucrReceiverMultiplePCA.Selector = ucrSelectorPCA
        ucrReceiverMultiplePCA.SetDataType("numeric")
        ucrReceiverMultiplePCA.strSelectorHeading = "Numerics"
        ucrResultName.SetDefaultTypeAsModel()
        ucrResultName.SetItemsTypeAsModels()
        ucrResultName.SetValidationTypeAsRVariable()
        ucrBasePCA.clsRsyntax.bExcludeAssignedFunctionOutput = False
        sdgPrincipalComponentAnalysis.ucrSelectorFactor.SetDataframe(ucrSelectorPCA.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)
        ucrBasePCA.iHelpTopicID = 422
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorPCA.Reset()
        ucrReceiverMultiplePCA.SetMeAsReceiver()
        ucrSelectorPCA.Focus()
        chkSaveResult.Checked = True
        ucrResultName.Visible = True
        chkScaleData.Checked = True
        ucrBasePCA.clsRsyntax.AddParameter("graph", "FALSE")
        ucrResultName.SetName("PCA")
        sdgPrincipalComponentAnalysis.SetDefaults()
        ComponentsMinimum()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        'If (Not ucrReceiverMultiplePCA.IsEmpty()) And ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 1 Then
        'If Not ucrReceiverMultiplePCA.IsEmpty() AndAlso ((chkSaveResult.Checked AndAlso ucrResultName.GetText() <> "") OrElse Not chkSaveResult.Checked) Then
        'ucrBasePCA.OKEnabled(True)
        'Else
        ' ucrBasePCA.OKEnabled(False)
        'End If

        If (chkSaveResult.Checked AndAlso Not ucrResultName.IsEmpty() OrElse Not chkSaveResult.Checked) AndAlso Not ucrReceiverMultiplePCA.IsEmpty() Then
            ucrBasePCA.OKEnabled(True)
        Else
            ucrBasePCA.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorPCA_DataFrameChanged() Handles ucrSelectorPCA.DataFrameChanged
        AssignName()
    End Sub

    Private Sub ucrBasePCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBasePCA.ClickReset
        SetDefaults()
    End Sub

    Public Sub ucrReceiverMultiplePCA_SelectionChanged() Handles ucrReceiverMultiplePCA.SelectionChanged
        If ucrReceiverMultiplePCA.IsEmpty Then
            AssignName()
        End If
        ucrBasePCA.clsRsyntax.AddParameter("X", clsRFunctionParameter:=ucrReceiverMultiplePCA.GetVariables())
        ucrBasePCA.clsRsyntax.AddParameter("ncp", nudComponents.Value)
        sdgPrincipalComponentAnalysis.Dimensions()
        TestOKEnabled()
        ComponentsMinimum()
    End Sub

    Private Sub nudComponents_TextChanged(sender As Object, e As EventArgs) Handles nudComponents.TextChanged
        ucrBasePCA.clsRsyntax.AddParameter("ncp", nudComponents.Value)
        sdgPrincipalComponentAnalysis.Dimensions()
    End Sub

    Private Sub chkScaleData_CheckedChanged(sender As Object, e As EventArgs) Handles chkScaleData.CheckedChanged
        If chkScaleData.Checked Then
            ucrBasePCA.clsRsyntax.AddParameter("scale.unit", "TRUE")
        Else
            ucrBasePCA.clsRsyntax.AddParameter("scale.unit", "FALSE")
        End If
    End Sub

    Private Sub cmdPCAOptions_Click(sender As Object, e As EventArgs) Handles cmdPCAOptions.Click
        sdgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub ucrResultName_NameChanged() Handles ucrResultName.NameChanged
        AssignName()
    End Sub

    Private Sub chkSaveResult_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveResult.CheckedChanged
        If chkSaveResult.Checked Then
            ucrResultName.Visible = True
        Else
            ucrResultName.Visible = False
        End If
        AssignName()
    End Sub

    Private Sub AssignName()
        If chkSaveResult.Checked AndAlso ucrResultName.GetText() <> "" Then
            ucrBasePCA.clsRsyntax.SetAssignTo(ucrResultName.GetText(), strTempModel:=ucrResultName.GetText(), strTempDataframe:=ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
            ucrBasePCA.clsRsyntax.bExcludeAssignedFunctionOutput = False
            strModelName = ucrResultName.GetText()
        Else
            ucrBasePCA.clsRsyntax.SetAssignTo("last_PCA", strTempModel:="last_PCA", strTempDataframe:=ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
            ucrBasePCA.clsRsyntax.bExcludeAssignedFunctionOutput = False
            ucrBasePCA.clsRsyntax.bExcludeAssignedFunctionOutput = False
            strModelName = "last_PCA"
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrBasePCA_clickok(sender As Object, e As EventArgs) Handles ucrBasePCA.ClickOk
        sdgPrincipalComponentAnalysis.PCAOptions()
    End Sub

    Private Sub ComponentsMinimum()
        If ucrReceiverMultiplePCA.IsEmpty Then
            nudComponents.Minimum = 0
            nudComponents.Value = 0
        ElseIf ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count = 1 Then
            nudComponents.Minimum = 2
        ElseIf ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 1 Then
            nudComponents.Minimum = 2
            If ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 5 Then
                nudComponents.Value = 5
            Else
                nudComponents.Value = ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
            End If
        End If
    End Sub
End Class