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
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    'Public ExplanatoryVariables
    Public strModelName As String = ""
    Private clsPCAFunction As New RFunction
    Private clsREigenValues, clsREigenVectors, clsRRotation, clsRRotationCoord, clsRRotationEig As New RFunction
    Private clsRScreePlotFunction, clsRScreePlotTheme, clsRVariablesPlotFunction, clsRVariablesPlotTheme, clsRIndividualsPlotFunction, clsRIndividualsPlotTheme, clsRBiplotFunction, clsRBiplotTheme, clsRBarPlotFunction As New RFunction
    Private clsRFactor, clsRMelt, clsRBarPlotGeom, clsRBarPlotAes, clsRBarPlotFacet As New RFunction
    Private clsRScreePlot, clsRVariablesPlot, clsRIndividualsPlot, clsRBiplot As New RSyntax
    Dim clsRBarPlot, clsRBarPlot0 As New ROperator
    ' call all classes in the sub dialog

    Private Sub dlgPrincipalComponentAnalysis_oad(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 422
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ComponentsMinimum()

        'ucrReceiver
        ucrReceiverMultiplePCA.SetParameter(New RParameter("X", 0))
        ucrReceiverMultiplePCA.SetParameterIsRFunction()
        ucrReceiverMultiplePCA.Selector = ucrSelectorPCA
        ucrReceiverMultiplePCA.SetDataType("numeric")
        ucrReceiverMultiplePCA.SetMeAsReceiver()

        'ucrCheckBox
        ucrChkScaleData.SetParameter(New RParameter("scale.unit", 1))
        ucrChkScaleData.SetText("Scale Data")
        ucrChkScaleData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkScaleData.SetRDefault("TRUE")

        'ucrNud
        ucrNudNumberOfComp.SetParameter(New RParameter("ncp", 2))
        ucrNudNumberOfComp.SetRDefault(5)

        'ucrSaveResult
        ucrSaveResult.SetPrefix("PCA")
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetDataFrameSelector(ucrSelectorPCA.ucrAvailableDataFrames)
        ucrSaveResult.SetCheckBoxText("Save Result")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetAssignToIfUncheckedValue("last_PCA")

        'sdgPrincipalComponentAnalysis.ucrSelectorFactor.SetDataframe(ucrSelectorPCA.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)
    End Sub

    Private Sub SetDefaults()
        clsPCAFunction = New RFunction
        clsREigenVectors = New RFunction
        clsREigenValues = New RFunction
        clsRRotation = New RFunction
        clsRRotationEig = New RFunction
        clsRRotationCoord = New RFunction
        clsRScreePlotTheme = New RFunction
        clsRScreePlot = New RSyntax
        clsRScreePlotFunction = New RFunction
        clsRVariablesPlotFunction = New RFunction
        clsRVariablesPlotTheme = New RFunction
        clsRVariablesPlot = New RSyntax
        clsRIndividualsPlotFunction = New RFunction
        clsRIndividualsPlotTheme = New RFunction
        clsRIndividualsPlot = New RSyntax
        clsRBiplotFunction = New RFunction
        clsRBiplotTheme = New RFunction
        clsRBiplot = New RSyntax
        clsRBarPlotFunction = New RFunction
        clsRFactor = New RFunction
        clsRMelt = New RFunction
        clsRBarPlotGeom = New RFunction
        clsRBarPlotAes = New RFunction
        clsRBarPlotFacet = New RFunction
        clsRBarPlot0 = New ROperator
        clsRBarPlot = New ROperator
        ' package name, r command and defaults for sdg

        ucrSelectorPCA.Reset()

        clsPCAFunction.SetPackageName("FactoMineR")
        clsPCAFunction.SetRCommand("PCA")
        clsPCAFunction.AddParameter("ncp", 2)
        clsPCAFunction.AddParameter("graph", "FALSE") ' I don't know what this is for, but it's in there?
        clsPCAFunction.SetAssignTo("last_PCA", strTempModel:="last_PCA", strTempDataframe:=ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsREigenValues.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREigenValues.AddParameter("value1", Chr(34) & "eig" & Chr(34))

        clsREigenVectors.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREigenVectors.AddParameter("value1", Chr(34) & "ind" & Chr(34))
        clsREigenVectors.AddParameter("value2", Chr(34) & "coord" & Chr(34))

        clsRRotationCoord.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRRotationCoord.AddParameter("value1", Chr(34) & "var" & Chr(34))
        clsRRotationCoord.AddParameter("value2", Chr(34) & "coord" & Chr(34))

        clsRRotationEig.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRRotationEig.AddParameter("value1", Chr(34) & "eig" & Chr(34))

        clsRRotation.SetRCommand("sweep")
        clsRRotation.AddParameter("x", clsRFunctionParameter:=clsRRotationCoord)
        clsRRotation.AddParameter("MARGIN", 2)
        clsRRotation.AddParameter("STATS", "sqrt(" & clsRRotationEig.ToScript.ToString & "[,1])")
        clsRRotation.AddParameter("FUN", " '/'")

        ' Scree Function
        clsRScreePlot.SetOperation("+")
        clsRScreePlotFunction.SetPackageName("factoextra")
        clsRScreePlotFunction.SetRCommand("fviz_screeplot")
        clsRScreePlotFunction.AddParameter("X", clsRFunctionParameter:=clsPCAFunction)
        clsRScreePlotTheme.SetPackageName("ggplot2")
        clsRScreePlotTheme.SetRCommand("theme_minimal")
        clsRScreePlot.AddOperatorParameter(True, clsRFunc:=clsRScreePlotFunction)
        clsRScreePlot.AddOperatorParameter(True, clsRFunc:=clsRScreePlotTheme)

        ' Variables Function
        clsRVariablesPlot.SetOperation("+")
        clsRVariablesPlotFunction.SetPackageName("factoextra")
        clsRVariablesPlotFunction.SetRCommand("fviz_pca_var")
        clsRVariablesPlotFunction.AddParameter("X", clsRFunctionParameter:=clsPCAFunction)
        clsRVariablesPlotTheme.SetPackageName("ggplot2")
        clsRVariablesPlotTheme.SetRCommand("theme_minimal")
        clsRVariablesPlot.SetOperatorParameter(True, clsRFunc:=clsRVariablesPlotFunction)
        clsRVariablesPlot.SetOperatorParameter(False, clsRFunc:=clsRVariablesPlotTheme)

        ' Individual Plot
        clsRIndividualsPlot.SetOperation("+")
        clsRIndividualsPlotFunction.SetPackageName("factoextra")
        clsRIndividualsPlotFunction.SetRCommand("fviz_pca_ind")
        clsRIndividualsPlotFunction.AddParameter("X", clsRFunctionParameter:=clsPCAFunction)
        clsRIndividualsPlotTheme.SetPackageName("ggplot2")
        clsRIndividualsPlotTheme.SetRCommand("theme_minimal")
        clsRIndividualsPlot.SetOperatorParameter(True, clsRFunc:=clsRIndividualsPlotFunction)
        clsRIndividualsPlot.SetOperatorParameter(False, clsRFunc:=clsRIndividualsPlotTheme)

        ' Biplot
        clsRBiplot.SetOperation("+")
        clsRBiplotFunction.SetPackageName("factoextra")
        clsRBiplotFunction.SetRCommand("fviz_pca_biplot")
        clsRBiplotFunction.AddParameter("X", clsRFunctionParameter:=clsPCAFunction)
        clsRBiplotTheme.SetPackageName("ggplot2")
        clsRBiplotTheme.SetRCommand("theme_minimal")
        clsRBiplot.SetOperatorParameter(True, clsRFunc:=clsRBiplotFunction)
        clsRBiplot.SetOperatorParameter(False, clsRFunc:=clsRBiplotTheme)

        ' Barplot
        clsRBarPlot0.SetOperation("+")
        clsRBarPlot.SetOperation("+")
        clsRFactor.SetRCommand("cbind")
        clsRMelt.SetRCommand("melt")
        clsRMelt.AddParameter("", clsRFunctionParameter:=clsREigenVectors) ' not sure if this will work!
        clsRFactor.AddParameter("", clsRFunctionParameter:=clsRMelt)
        clsRBarPlotFunction.SetPackageName("ggplot2")
        clsRBarPlotFunction.SetRCommand("ggplot")
        clsRBarPlotFunction.AddParameter("data", clsRFunctionParameter:=clsRFactor)
        clsRBarPlotGeom.SetPackageName("ggplot2")
        clsRBarPlotGeom.SetRCommand("geom_bar")
        clsRBarPlotAes.SetPackageName("ggplot2")
        clsRBarPlotAes.SetRCommand("aes")
        clsRBarPlotAes.AddParameter("x", "Var1")
        clsRBarPlotAes.AddParameter("y", "value")
        clsRBarPlotAes.AddParameter("fill", "factor_col") ' may not run this here
        clsRBarPlotGeom.AddParameter("", clsRFunctionParameter:=clsRBarPlotAes)
        clsRBarPlotGeom.AddParameter("stat", Chr(34) & "identity" & Chr(34))
        clsRBarPlotFacet.SetPackageName("ggplot2")
        clsRBarPlotFacet.SetRCommand("facet_wrap")
        clsRBarPlotFacet.AddParameter("", "~Var2")
        clsRBarPlot0.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRBarPlotFunction)
        clsRBarPlot0.AddParameter(clsRFunctionParameter:=clsRBarPlotGeom)
        clsRBarPlot.AddParameter(iPosition:=0, clsROperatorParameter:=clsRBarPlot0)
        clsRBarPlot.AddParameter(clsRFunctionParameter:=clsRBarPlotFacet)

        ucrBase.clsRsyntax.SetBaseRFunction(clsPCAFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled() ' add in if the sdg has a clear nud, etc
        If ucrSaveResult.IsComplete AndAlso Not ucrReceiverMultiplePCA.IsEmpty() AndAlso ucrNudNumberOfComp.GetText <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBasePCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBasePCA_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        'sdgPrincipalComponentAnalysis.PCAOptions()
        ' this is wrong. just here for now.
        If sdgPrincipalComponentAnalysis.ucrChkEigenvalues.Checked Then
            frmMain.clsRLink.RunScript(clsREigenValues.ToScript(), 2)
        End If
        If sdgPrincipalComponentAnalysis.ucrChkEigenvectors.Checked Then
            frmMain.clsRLink.RunScript(clsREigenVectors.ToScript(), 2)
        End If
        If sdgPrincipalComponentAnalysis.ucrChkRotation.Checked Then
            frmMain.clsRLink.RunScript(clsRRotation.ToScript(), 2)
        End If
        If sdgPrincipalComponentAnalysis.rdoScreePlot.Checked Then
            frmMain.clsRLink.RunScript(clsRScreePlot.GetScript(), 3)
        ElseIf sdgPrincipalComponentAnalysis.rdoVariablesPlot.Checked Then
            frmMain.clsRLink.RunScript(clsRVariablesPlot.GetScript(), 3)
        ElseIf sdgPrincipalComponentAnalysis.rdoIndividualsPlot.Checked Then
            frmMain.clsRLink.RunScript(clsRIndividualsPlot.GetScript(), 3)
        ElseIf sdgPrincipalComponentAnalysis.rdoBiplot.Checked Then
            frmMain.clsRLink.RunScript(clsRBiplot.GetScript(), 3)
        ElseIf sdgPrincipalComponentAnalysis.rdoBarplot.Checked Then
            frmMain.clsRLink.RunScript(clsRBarPlot.ToScript, 3)
        End If
    End Sub

    Private Sub cmdPCAOptions_Click(sender As Object, e As EventArgs) Handles cmdPCAOptions.Click
        sdgPrincipalComponentAnalysis.SetRFunction(clsREigenValues, clsREigenVectors, clsRRotation, clsRScreePlotFunction, clsRVariablesPlotFunction, clsRIndividualsPlotFunction, clsRBiplotFunction, clsRFactor, bResetSubdialog)
        bResetSubdialog = False
        sdgPrincipalComponentAnalysis.ShowDialog()
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

    Private Sub SetUp()
        AssignName()
        clsREigenValues.AddParameter("data_name", Chr(34) & ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsREigenValues.AddParameter("model_name", Chr(34) & strModelName & Chr(34))

        clsREigenVectors.AddParameter("data_name", Chr(34) & ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsREigenVectors.AddParameter("model_name", Chr(34) & strModelName & Chr(34))

        clsRRotationCoord.AddParameter("data_name", Chr(34) & ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRRotationCoord.AddParameter("model_name", Chr(34) & strModelName & Chr(34))
        clsRRotationEig.AddParameter("data_name", Chr(34) & ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRRotationEig.AddParameter("model_name", Chr(34) & strModelName & Chr(34))
    End Sub

    Public Sub AssignName()
        If ucrSaveResult.IsComplete Then
            strModelName = ucrSaveResult.GetText()
        Else
            strModelName = "last_CCA"
        End If
    End Sub

    Private Sub ucrSaveResult_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlValueChanged, ucrSelectorPCA.ControlValueChanged
        SetUp()
    End Sub

    Private Sub ucrReceiverMultiplePCA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultiplePCA.ControlValueChanged, ucrNudNumberOfComp.ControlValueChanged
        ComponentsMinimum()
        '        sdgPrincipalComponentAnalysis.Dimensions()
    End Sub

    '  Private Sub nudComponents_TextChanged(sender As Object, e As EventArgs)
    '     sdgPrincipalComponentAnalysis.Dimensions()
    '  End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverMultiplePCA.ControlContentsChanged, ucrNudNumberOfComp.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class