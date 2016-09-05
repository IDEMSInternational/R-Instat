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
Public Class sdgPrincipalComponentAnalysis
    Public bFirstLoad As Boolean = True
    Public clsREigenValues, clsREigenVectors, clsRScores, clsPCAModel, clsRVariablesPlotFunction, clsRVariablesPlotTheme, clsRRotation, clsRCoord, clsRContrib, clsREig, clsRFactor, clsRMelt As New RFunction
    Public clsRScreePlotFunction, clsRScreePlotTheme, clsRIndividualsPlotFunction, clsRIndividualsPlotTheme, clsRBiplotFunction, clsRBiplotTheme, clsRBarPlotFunction, clsRBarPlotGeom, clsRBarPlotFacet, clsRBarPlotAes As New RFunction
    Public clsRScreePlot, clsRVariablesPlot, clsRIndividualsPlot, clsRBiplot As New RSyntax
    Dim clsRBarPlot, clsRBarPlot0 As New ROperator
    Private Sub sdgPrincipalComponentAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetDefaults()
        ucrReceiverFactor.Selector = ucrSelectorFactor
        ucrReceiverFactor.SetDataType("factor")
        ucrSelectorFactor.Reset()
        ucrReceiverFactor.SetMeAsReceiver()
        ucrSelectorFactor.Focus()
        chkEigenValues.Checked = True
        chkEigenVectors.Checked = True
        chkScores.Checked = True
        chkResiduals.Checked = True
        chkRotation.Checked = True
        chkBar.Checked = True
        chkLine.Checked = True
        chkBar.Enabled = False
        chkLine.Enabled = False
        grpGeom.Enabled = False
        lblChoice.Enabled = False
        cmbChoice.SelectedItem = "variance"
        cmbChoice.Enabled = False
        rdoVariablesPlot.Checked = False
        rdoIndividualsPlot.Checked = False
        rdoBiplot.Checked = False
        rdoScreePlot.Checked = False
        rdoBarPlot.Checked = False
    End Sub

    Private Sub EigenValues()
        clsREigenValues.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREigenValues.AddParameter("data_name", Chr(34) & dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsREigenValues.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
        clsREigenValues.AddParameter("value1", Chr(34) & "eig" & Chr(34))
        frmMain.clsRLink.RunScript(clsREigenValues.ToScript(), 2)
    End Sub

    Public Sub EigenVectors()
        clsREigenVectors.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREigenVectors.AddParameter("data_name", Chr(34) & dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsREigenVectors.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
        clsREigenVectors.AddParameter("value1", Chr(34) & "ind" & Chr(34))
        clsREigenVectors.AddParameter("value2", Chr(34) & "coord" & Chr(34))
        frmMain.clsRLink.RunScript(clsREigenVectors.ToScript(), 2)
    End Sub

    Private Sub Scores()
        clsRScores.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRScores.AddParameter("data_name", Chr(34) & dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRScores.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
        clsRScores.AddParameter("value1", Chr(34) & "var" & Chr(34))
        clsRScores.AddParameter("value2", Chr(34) & "coord" & Chr(34))
        frmMain.clsRLink.RunScript(clsRScores.ToScript(), 2)
    End Sub

    Private Sub Rotation()
        clsRRotation.SetRCommand("sweep")
        clsRCoord.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRCoord.AddParameter("data_name", Chr(34) & dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRCoord.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
        clsRCoord.AddParameter("value1", Chr(34) & "var" & Chr(34))
        clsRCoord.AddParameter("value2", Chr(34) & "coord" & Chr(34))
        clsREig.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREig.AddParameter("data_name", Chr(34) & dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsREig.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
        clsREig.AddParameter("value1", Chr(34) & "eig" & Chr(34))
        clsRRotation.AddParameter("x", clsRFunctionParameter:=clsRCoord)
        clsRRotation.AddParameter("MARGIN", 2)
        clsRRotation.AddParameter("STATS", "sqrt(" & clsREig.ToScript.ToString & "[,1])")
        clsRRotation.AddParameter("FUN", " '/'")
        frmMain.clsRLink.RunScript(clsRRotation.ToScript(), 2)
    End Sub

    Private Sub Residuals()
        'TODO
    End Sub

    Private Sub ScreePlot()
        clsRScreePlot.SetOperation("+")
        clsRScreePlotFunction.SetRCommand("fviz_screeplot")
        clsRScreePlotFunction.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        clsRScreePlotTheme.SetRCommand("theme_minimal")
        clsRScreePlot.SetOperatorParameter(True, clsRFunc:=clsRScreePlotFunction)
        clsRScreePlot.SetOperatorParameter(False, clsRFunc:=clsRScreePlotTheme)
        clsRScreePlot.SetFunction("fviz_screeplot")
        clsRScreePlot.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        frmMain.clsRLink.RunScript(clsRScreePlot.GetScript(), 0)
    End Sub

    Private Sub VariablesPlot()
        clsRVariablesPlot.SetOperation("+")
        clsRVariablesPlotFunction.SetRCommand("fviz_pca_var")
        clsRVariablesPlotFunction.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        clsRVariablesPlotTheme.SetRCommand("theme_minimal")
        clsRVariablesPlot.SetOperatorParameter(True, clsRFunc:=clsRVariablesPlotFunction)
        clsRVariablesPlot.SetOperatorParameter(False, clsRFunc:=clsRVariablesPlotTheme)
        frmMain.clsRLink.RunScript(clsRVariablesPlot.GetScript(), 0)
    End Sub

    Private Sub IndividualsPlot()
        clsRIndividualsPlot.SetOperation("+")
        clsRIndividualsPlotFunction.SetRCommand("fviz_pca_ind")
        clsRIndividualsPlotFunction.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        clsRIndividualsPlotTheme.SetRCommand("theme_minimal")
        clsRIndividualsPlot.SetOperatorParameter(True, clsRFunc:=clsRIndividualsPlotFunction)
        clsRIndividualsPlot.SetOperatorParameter(False, clsRFunc:=clsRIndividualsPlotTheme)
        frmMain.clsRLink.RunScript(clsRIndividualsPlot.GetScript(), 0)
    End Sub

    Private Sub Biplot()
        clsRBiplot.SetOperation("+")
        clsRBiplotFunction.SetRCommand("fviz_pca_biplot")
        clsRBiplotFunction.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        clsRBiplotTheme.SetRCommand("theme_minimal")
        clsRBiplot.SetOperatorParameter(True, clsRFunc:=clsRBiplotFunction)
        clsRBiplot.SetOperatorParameter(False, clsRFunc:=clsRBiplotTheme)
        frmMain.clsRLink.RunScript(clsRBiplot.GetScript(), 0)
    End Sub

    Private Sub Barplot()
        clsRBarPlot0.SetOperation("+")
        clsRBarPlot.SetOperation("+")
        clsRFactor.SetRCommand("cbind")
        clsRMelt.SetRCommand("melt")
        clsRMelt.AddParameter("", clsRFunctionParameter:=clsREigenVectors)
        clsRFactor.AddParameter("factor_col", clsRFunctionParameter:=ucrReceiverFactor.GetVariables())
        clsRFactor.AddParameter("", clsRFunctionParameter:=clsRMelt)
        clsRBarPlotFunction.SetRCommand("ggplot")
        clsRBarPlotFunction.AddParameter("data", clsRFactor.ToScript.ToString)
        clsRBarPlotGeom.SetRCommand("geom_bar")
        clsRBarPlotAes.SetRCommand("aes")
        clsRBarPlotAes.AddParameter("x", "Var1")
        clsRBarPlotAes.AddParameter("y", "value")
        clsRBarPlotAes.AddParameter("fill", "factor_col")
        clsRBarPlotGeom.AddParameter("", clsRFunctionParameter:=clsRBarPlotAes)
        clsRBarPlotGeom.AddParameter("stat", Chr(34) & "identity" & Chr(34))
        clsRBarPlotFacet.SetRCommand("facet_wrap")
        clsRBarPlotFacet.AddParameter("", "~Var2")
        clsRBarPlot0.SetParameter(True, clsRFunc:=clsRBarPlotFunction)
        clsRBarPlot0.SetParameter(False, clsRFunc:=clsRBarPlotGeom)
        clsRBarPlot.SetParameter(True, clsOp:=clsRBarPlot0)
        clsRBarPlot.SetParameter(False, clsRFunc:=clsRBarPlotFacet)
        frmMain.clsRLink.RunScript(clsRBarPlot.ToScript, 0)
    End Sub

    Private Sub chkBar_CheckedChanged(sender As Object, e As EventArgs) Handles chkBar.CheckedChanged
        If chkBar.Checked Then
            If chkLine.Checked Then
                clsRScreePlotFunction.AddParameter("geom", "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")
            Else
                clsRScreePlotFunction.AddParameter("geom", Chr(34) & "bar" & Chr(34))
            End If
        Else
            chkLine.Checked = True
            clsRScreePlotFunction.AddParameter("geom", Chr(34) & "line" & Chr(34))
        End If
    End Sub

    Private Sub chkLine_CheckedChanged(sender As Object, e As EventArgs) Handles chkLine.CheckedChanged
        If chkLine.Checked Then
            If chkBar.Checked Then
                clsRScreePlotFunction.AddParameter("geom", "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")
            Else
                clsRScreePlotFunction.AddParameter("geom", Chr(34) & "line" & Chr(34))
            End If
        Else
            chkBar.Checked = True
            clsRScreePlotFunction.AddParameter("geom", Chr(34) & "bar" & Chr(34))
        End If
    End Sub

    Private Sub cmbChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChoice.SelectedIndexChanged
        clsRScreePlotFunction.AddParameter("choice", Chr(34) & cmbChoice.SelectedItem.ToString & Chr(34))
    End Sub

    Private Sub rdoScreePlot_CheckedChanged(sender As Object, e As EventArgs) Handles rdoScreePlot.CheckedChanged
        If rdoScreePlot.Checked Then
            grpGeom.Enabled = True
            chkBar.Enabled = True
            chkLine.Enabled = True
            lblChoice.Enabled = True
            cmbChoice.Enabled = True
        Else
            chkBar.Enabled = False
            chkLine.Enabled = False
            grpGeom.Enabled = False
            lblChoice.Enabled = False
            cmbChoice.Enabled = False
        End If
    End Sub

    Public Sub PCAOptions()
        If (chkEigenValues.Checked) Then
            EigenValues()
        End If
        If (chkEigenVectors.Checked) Then
            EigenVectors()
        End If
        If (chkScores.Checked) Then
            Scores()
        End If
        If (chkResiduals.Checked) Then
            Residuals()
        End If
        If rdoScreePlot.Checked Then
            ScreePlot()
        End If
        If rdoIndividualsPlot.Checked Then
            IndividualsPlot()
        End If
        If rdoVariablesPlot.Checked Then
            VariablesPlot()
        End If
        If rdoBiplot.Checked Then
            Biplot()
        End If
        If chkRotation.Checked Then
            Rotation()
        End If
        If rdoBarPlot.Checked Then
            Barplot()
        End If
    End Sub
End Class