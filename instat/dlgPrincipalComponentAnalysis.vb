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
    Public strModelName As String = ""
    Private clsDefaultFunction As New RFunction

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
        ucrBase.iHelpTopicID = 422
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ' PCA <- PCA(scale.unit=TRUE, graph=FALSE, X=InstatDataObject$get_columns_from_data(col_names="data.2", data_name="data1"), ncp=2)
        'InstatDataObject$add_model(data_name = "data1", model = PCA, model_name = "PCA")
        'InstatDataObject$get_models(model_name = "PCA", data_name = "data1")

        'ucrReceiver
        ucrReceiverMultiplePCA.SetParameter(New RParameter("X", 1))
        ucrReceiverMultiplePCA.SetParameterIsRFunction()
        ucrReceiverMultiplePCA.Selector = ucrSelectorPCA
        ucrReceiverMultiplePCA.SetDataType("numeric")
        ucrReceiverMultiplePCA.SetMeAsReceiver()
        'ucrBasePCA.clsRsyntax.AddParameter("X", clsRFunctionParameter:=ucrReceiverMultiplePCA.GetVariables())

        'ucrSaveResult
        ucrSaveResult.SetName("PCA") ' this is possible once dlgtranspose is merged in
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetDataFrameSelector(ucrSelectorPCA.ucrAvailableDataFrames)
        ucrSaveResult.SetCheckBoxText("Save Result")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetAssignToIfUncheckedValue("last_graph")
        ' where do I say this is default checked?

        'ucrNud
        ucrNudNumberOfComp.SetParameter(New RParameter("ncp"))

        'ucrCheckBox
        ucrChkScaleData.SetParameter(New RParameter("scale.unit"))
        ucrChkScaleData.SetText("Scale Data")
        ucrChkScaleData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkScaleData.SetRDefault("TRUE")


        ' nudComponents.Value = ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count


        ' Default
        clsDefaultFunction.SetRCommand("PCA")
        clsDefaultFunction.AddParameter("graph", "FALSE") ' not sure what this does?
        clsDefaultFunction.SetAssignTo("last_PCA", strTempModel:="last_PCA", strTempDataframe:=ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)


        sdgPrincipalComponentAnalysis.ucrSelectorFactor.SetDataframe(ucrSelectorPCA.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorPCA.Reset()
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

        If ucrSaveResult.IsComplete AndAlso Not ucrReceiverMultiplePCA.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorPCA_DataFrameChanged() Handles ucrSelectorPCA.DataFrameChanged
        AssignName()
    End Sub

    Private Sub ucrBasePCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Public Sub ucrReceiverMultiplePCA_SelectionChanged() Handles ucrReceiverMultiplePCA.SelectionChanged
        If ucrReceiverMultiplePCA.IsEmpty Then
            AssignName()
        End If
        ucrBase.clsRsyntax.AddParameter("X", clsRFunctionParameter:=ucrReceiverMultiplePCA.GetVariables())
        '     ucrBasePCA.clsRsyntax.AddParameter("ncp", ucrNudNumberOfComp.Value)
        sdgPrincipalComponentAnalysis.Dimensions()
        TestOKEnabled()
        ComponentsMinimum()
    End Sub

    Private Sub nudComponents_TextChanged(sender As Object, e As EventArgs)
        '    ucrBasePCA.clsRsyntax.AddParameter("ncp", ucrNudNumberOfComp.Value)
        sdgPrincipalComponentAnalysis.Dimensions()
    End Sub

    Private Sub chkScaleData_CheckedChanged(sender As Object, e As EventArgs)
        '        If chkScaleData.Checked Then
        '       ucrBasePCA.clsRsyntax.AddParameter("scale.unit", "TRUE")
        '      Else
        '     ucrBasePCA.clsRsyntax.AddParameter("scale.unit", "FALSE")
        '    End If
    End Sub

    Private Sub cmdPCAOptions_Click(sender As Object, e As EventArgs) Handles cmdPCAOptions.Click
        sdgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub ucrResultName_NameChanged()
        AssignName()
    End Sub

    Private Sub AssignName()
        '       If ucrSaveResult.IsComplete() Then
        ' i think this is done already now: '      ucrBase.clsRsyntax.SetAssignTo(ucrResultName.GetText(), strTempModel:=ucrResultName.GetText(), strTempDataframe:=ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        '     strModelName = ucrResultName.GetText()
        '    Else
        '   ucrBase.clsRsyntax.SetAssignTo("last_PCA", strTempModel:="last_PCA", strTempDataframe:=ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        '  strModelName = "last_PCA"
        ' End If
        'TestOKEnabled()
    End Sub



    Private Sub ucrBasePCA_clickok(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgPrincipalComponentAnalysis.PCAOptions()
    End Sub

    Private Sub ComponentsMinimum()
        If ucrReceiverMultiplePCA.IsEmpty Then
            ucrNudNumberOfComp.Minimum = 0
            ucrNudNumberOfComp.Value = 0
        ElseIf ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count = 1 Then
            ucrNudNumberOfComp.Minimum = 2
        ElseIf ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 1 Then
            ucrNudNumberOfComp.Minimum = 2
            If ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 5 Then
                ucrNudNumberOfComp.Value = 5
            Else
                ucrNudNumberOfComp.Value = ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
            End If
        End If
    End Sub
End Class