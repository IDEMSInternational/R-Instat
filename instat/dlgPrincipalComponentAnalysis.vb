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
Public Class dlgPrincipalComponentAnalysis
    Public bFirstLoad As Boolean = True
    Public ExplanatoryVariables
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
        ucrBasePCA.clsRsyntax.SetFunction("PCA")
        ucrBasePCA.clsRsyntax.iCallType = 0
        ucrReceiverMultiplePCA.Selector = ucrSelectorPCA
        ucrReceiverMultiplePCA.SetDataType("numeric")
        'ucrBase.iHelpTopicID = 171
        ' sdgPrincipalComponentAnalysis.SetPCAFunction(ucrBasePCA.clsRsyntax.clsBaseFunction)
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
        'Need to ask if we really need to used FactoMineR package for PCA as it outputs graph by default
        ucrResultName.SetName("PCA_1")
        sdgPrincipalComponentAnalysis.SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverMultiplePCA.IsEmpty()) Then
            ucrBasePCA.OKEnabled(True)
        Else
            ucrBasePCA.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBasePCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBasePCA.ClickReset
        SetDefaults()
    End Sub

    Public Sub ucrReceiverMultiplePCA_SelectionChanged() Handles ucrReceiverMultiplePCA.SelectionChanged
        TestOKEnabled()
        ExplanatoryVariables = XVariables(ucrReceiverMultiplePCA.GetVariableNames())
        ucrBasePCA.clsRsyntax.AddParameter("X", ExplanatoryVariables)
    End Sub

    Private Sub nudComponents_ValueChanged(sender As Object, e As EventArgs) Handles nudComponents.ValueChanged
        ucrBasePCA.clsRsyntax.AddParameter("ncp", nudComponents.Value)
    End Sub

    Private Sub chkScaleData_CheckedChanged(sender As Object, e As EventArgs) Handles chkScaleData.CheckedChanged
        If chkScaleData.Checked Then
            ucrBasePCA.clsRsyntax.AddParameter("scale.unit", "TRUE")
        Else
            ucrBasePCA.clsRsyntax.AddParameter("scale.unit", "FALSE")
        End If
    End Sub

    Public Function XVariables(ByVal my_variable) As String
        Dim Variables As New RSyntax
        Variables.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        Variables.AddParameter("col_names", my_variable)
        Variables.AddParameter("data_name", Chr(34) & ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        Return (Variables.GetScript())
    End Function

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
        If chkSaveResult.Checked AndAlso ucrResultName.txtValidation.Text <> "" Then
            ucrBasePCA.clsRsyntax.SetAssignTo(ucrResultName.txtValidation.Text, strTempModel:=ucrResultName.txtValidation.Text)
            ucrBasePCA.clsRsyntax.bExcludeAssignedFunctionOutput = False
        Else
            ucrBasePCA.clsRsyntax.SetAssignTo("last_PCA", strTempModel:="last_PCA")
            ucrBasePCA.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub

    Private Sub ucrBasePCA_clickok(sender As Object, e As EventArgs) Handles ucrBasePCA.ClickOk
        sdgPrincipalComponentAnalysis.PCAOptions()
    End Sub
End Class
