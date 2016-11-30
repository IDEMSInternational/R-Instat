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
        chkRotation.Checked = True
        chkPercentageScree.Checked = False
        rdoScreePlot.Checked = True
        cboChoiceScree.SelectedItem = "variance"
        cboLabel.SelectedItem = "all"
        rdoScreePlot.Checked = True
        nudDim2.Value = 2
        Dimensions()
        DisplayOptions()
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

    Private Sub ScreePlot()
        clsRScreePlot.SetOperation("+")
        clsRScreePlotFunction.SetRCommand("fviz_screeplot")
        clsRScreePlotFunction.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        clsRScreePlotTheme.SetRCommand("theme_minimal")
        clsRScreePlot.SetOperatorParameter(True, clsRFunc:=clsRScreePlotFunction)
        clsRScreePlot.SetOperatorParameter(False, clsRFunc:=clsRScreePlotTheme)
        If chkPercentageScree.Checked Then
            clsRScreePlotFunction.AddParameter("addlabels", "TRUE")
        ElseIf Not chkPercentageScree.Checked Then
            clsRScreePlotFunction.AddParameter("addlabels", "FALSE")
        Else
            clsRScreePlotFunction.RemoveParameterByName("addlabels")
        End If
        frmMain.clsRLink.RunScript(clsRScreePlot.GetScript(), 0)
    End Sub


    Private Sub VariablesPlot()
        clsRVariablesPlot.SetOperation("+")
        clsRVariablesPlotFunction.SetRCommand("fviz_pca_var")
        clsRVariablesPlotFunction.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        clsRVariablesPlotTheme.SetRCommand("theme_minimal")
        clsRVariablesPlot.SetOperatorParameter(True, clsRFunc:=clsRVariablesPlotFunction)
        clsRVariablesPlot.SetOperatorParameter(False, clsRFunc:=clsRVariablesPlotTheme)
        clsRVariablesPlotFunction.AddParameter("axes", "c(" & nudDim1.Value & "," & nudDim2.Value & ")")
        frmMain.clsRLink.RunScript(clsRVariablesPlot.GetScript(), 0)
    End Sub

    Private Sub IndividualsPlot()
        clsRIndividualsPlot.SetOperation("+")
        clsRIndividualsPlotFunction.SetRCommand("fviz_pca_ind")
        clsRIndividualsPlotFunction.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        clsRIndividualsPlotTheme.SetRCommand("theme_minimal")
        clsRIndividualsPlot.SetOperatorParameter(True, clsRFunc:=clsRIndividualsPlotFunction)
        clsRIndividualsPlot.SetOperatorParameter(False, clsRFunc:=clsRIndividualsPlotTheme)
        clsRIndividualsPlotFunction.AddParameter("axes", "c(" & nudDim1.Value & "," & nudDim2.Value & ")")
        frmMain.clsRLink.RunScript(clsRIndividualsPlot.GetScript(), 0)
    End Sub

    Private Sub Biplot()
        clsRBiplot.SetOperation("+")
        clsRBiplotFunction.SetRCommand("fviz_pca_biplot")
        clsRBiplotFunction.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)
        clsRBiplotTheme.SetRCommand("theme_minimal")
        clsRBiplot.SetOperatorParameter(True, clsRFunc:=clsRBiplotFunction)
        clsRBiplot.SetOperatorParameter(False, clsRFunc:=clsRBiplotTheme)
        clsRBiplotFunction.AddParameter("axes", "c(" & nudDim1.Value & "," & nudDim2.Value & ")")
        frmMain.clsRLink.RunScript(clsRBiplot.GetScript(), 0)
    End Sub

    Private Sub Barplot()
        clsRBarPlot0.SetOperation("+")
        clsRBarPlot.SetOperation("+")
        clsRFactor.SetRCommand("cbind")
        clsRMelt.SetRCommand("melt")
        clsRMelt.AddParameter("", clsRFunctionParameter:=clsREigenVectors)
        clsRFactor.AddParameter("factor_col", ucrReceiverFactor.GetVariableNames)
        clsRFactor.AddParameter("", clsRFunctionParameter:=clsRMelt)
        clsRBarPlotFunction.SetRCommand("ggplot")
        clsRBarPlotFunction.AddParameter("data", clsRFunctionParameter:=clsRFactor)
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
    End Sub

    Private Sub cmbChoice_SelectedIndexChanged(sender As Object, e As EventArgs)
        clsRScreePlotFunction.AddParameter("choice", Chr(34) & cboChoiceScree.SelectedItem.ToString & Chr(34))
    End Sub

    Public Sub PCAOptions()
        If (chkEigenValues.Checked) Then
            EigenValues()
        End If
        If (chkEigenVectors.Checked) Then
            EigenVectors()
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
            frmMain.clsRLink.RunScript(clsRBarPlot.ToScript, 0)
        End If
    End Sub

    Public Sub ucrReceiverFactor_SelectionChanged() Handles ucrReceiverFactor.SelectionChanged
        Barplot()
    End Sub

    Public Sub Dimensions()
        nudDim1.Minimum = 1
        nudDim2.Minimum = 1
        If dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.IsEmpty OrElse dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count = 1 Then
            nudDim2.Value = 2
        ElseIf dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 1 Then
            If dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength <= dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count Then
                If dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength <= dlgPrincipalComponentAnalysis.nudComponents.Value Then
                    nudDim1.Maximum = dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength - 1
                    nudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrSelectorPCA.ucrAvailableDataFrames.iDataFrameLength - 1
                Else
                    nudDim1.Maximum = dlgPrincipalComponentAnalysis.nudComponents.Value
                    nudDim2.Maximum = dlgPrincipalComponentAnalysis.nudComponents.Value
                End If
            Else
                If dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count <= dlgPrincipalComponentAnalysis.nudComponents.Value Then
                    nudDim1.Maximum = dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
                    nudDim2.Maximum = dlgPrincipalComponentAnalysis.ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
                Else
                    nudDim1.Maximum = dlgPrincipalComponentAnalysis.nudComponents.Value
                    nudDim2.Maximum = dlgPrincipalComponentAnalysis.nudComponents.Value
                End If
            End If
            End If

        ' This number must be the minimum between components selected and items in receiver.
        ' However, if the rows are shorter than the columns then it must be the minimum between rows and components
        ' Then if rows is shorter overall, it must be the number of rows minus one.
    End Sub

    Private Sub DisplayOptions()
        If rdoBarPlot.Checked Then
            lblChoiceScree.Visible = False
            grpGeom.Visible = False
            chkPercentageScree.Visible = False
            nudDim1.Visible = False
            nudDim2.Visible = False
            lblDim.Visible = False
            cboChoiceScree.Visible = False
            cboLabel.Visible = False
            'rdoBoth.Checked = False
            ucrSelectorFactor.Visible = True
            ucrReceiverFactor.Visible = True
            lblFactorVariable.Visible = True
        Else
            'rdoBoth.Checked = True
            lblChoiceScree.Visible = True
            grpGeom.Visible = True
            ucrSelectorFactor.Visible = False
            ucrReceiverFactor.Visible = False
            lblFactorVariable.Visible = False
            If rdoScreePlot.Checked Then
                grpGeom.Visible = True
                lblChoiceScree.Text = "Choice:"
                rdoOne.Text = "Bar"
                rdoTwo.Text = "Line"
                chkPercentageScree.Visible = True
                nudDim1.Visible = False
                nudDim2.Visible = False
                lblDim.Visible = False
                cboChoiceScree.Visible = True
                cboLabel.Visible = False
            Else
                nudDim1.Visible = True
                nudDim2.Visible = True
                lblDim.Visible = True
                chkPercentageScree.Visible = False
                lblChoiceScree.Text = "Label:"
                rdoTwo.Text = "Text"
                cboChoiceScree.Visible = False
                cboLabel.Visible = True
                If rdoVariablesPlot.Checked Then
                    rdoOne.Text = "Arrow"
                Else
                    rdoOne.Text = "Point"
                End If
            End If
        End If
    End Sub

    Private Sub lblNames_TextChanged(sender As Object, e As EventArgs) Handles lblChoiceScree.TextChanged, rdoOne.TextChanged, rdoTwo.TextChanged
    DisplayOptions()
End Sub

    Private Sub rdoPlotItems_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBoth.CheckedChanged, rdoOne.CheckedChanged, rdoTwo.CheckedChanged
        GeomChecked()
    End Sub

    Private Sub GeomChecked()
        If rdoScreePlot.Checked Then
            If rdoBoth.Checked Then
                clsRScreePlotFunction.AddParameter("geom", "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")
            ElseIf rdoOne.Checked Then
                clsRScreePlotFunction.AddParameter("geom", Chr(34) & "bar" & Chr(34))
            ElseIf rdoTwo.Checked Then
                clsRScreePlotFunction.AddParameter("geom", Chr(34) & "line" & Chr(34))
            End If
        ElseIf rdoVariablesPlot.Checked Then
            If rdoBoth.Checked Then
                clsRVariablesPlotFunction.AddParameter("geom", "c(" & Chr(34) & "arrow" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")
            ElseIf rdoOne.Checked Then
                clsRVariablesPlotFunction.AddParameter("geom", Chr(34) & "arrow" & Chr(34))
            ElseIf rdoTwo.Checked Then
                clsRVariablesPlotFunction.AddParameter("geom", Chr(34) & "text" & Chr(34))
            End If
        ElseIf rdoIndividualsPlot.Checked Then
            If rdoBoth.Checked Then
                clsRIndividualsPlotFunction.AddParameter("geom", "c(" & Chr(34) & "point" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")
            ElseIf rdoOne.Checked Then
                clsRIndividualsPlotFunction.AddParameter("geom", Chr(34) & "point" & Chr(34))
            ElseIf rdoTwo.Checked Then
                clsRIndividualsPlotFunction.AddParameter("geom", Chr(34) & "text" & Chr(34))
            End If
        ElseIf rdoBiplot.Checked Then
            If rdoBoth.Checked Then
                clsRBiplotFunction.AddParameter("geom", "c(" & Chr(34) & "point" & Chr(34) & "," & Chr(34) & "text" & Chr(34) & ")")
            ElseIf rdoOne.Checked Then
                clsRBiplotFunction.AddParameter("geom", Chr(34) & "point" & Chr(34))
            ElseIf rdoTwo.Checked Then
                clsRBiplotFunction.AddParameter("geom", Chr(34) & "text" & Chr(34))
            Else
                clsRBiplotFunction.RemoveParameterByName("geom")
            End If
        Else
            clsRScreePlotFunction.RemoveParameterByName("geom")
        End If
    End Sub

    Private Sub cboChoiceScree_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboChoiceScree.SelectedIndexChanged
    clsRScreePlotFunction.AddParameter("choice", Chr(34) & cboChoiceScree.SelectedItem.ToString & Chr(34))
        ' have one combo box which they all use.
    End Sub

    Private Sub cboLabelVar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboLabel.SelectedIndexChanged
        If rdoVariablesPlot.Checked Then
            clsRVariablesPlotFunction.AddParameter("label", Chr(34) & cboLabel.SelectedItem.ToString & Chr(34))
        End If
        If rdoIndividualsPlot.Checked Then
            clsRIndividualsPlotFunction.AddParameter("label", Chr(34) & cboLabel.SelectedItem.ToString & Chr(34))
        End If
        If rdoBiplot.Checked Then
            clsRBiplotFunction.AddParameter("label", Chr(34) & cboLabel.SelectedItem.ToString & Chr(34))
        End If
    End Sub

    Private Sub rdoPlots_CheckedChanged(sender As Object, e As EventArgs) Handles rdoScreePlot.CheckedChanged, rdoBarPlot.CheckedChanged, rdoBiplot.CheckedChanged, rdoVariablesPlot.CheckedChanged, rdoIndividualsPlot.CheckedChanged
        DisplayOptions()
        GeomChecked()
    End Sub
End Class