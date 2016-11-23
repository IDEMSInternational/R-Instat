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

Public Class sdgCorrPlot
    Public clsRGGscatmatrix, clsRGGcorrGraphics, clsRGraphics As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub sdgCorrPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub CorrelationMatrix()
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        If Not chkPairwisePlot.Checked AndAlso Not chkCorrelationPlot.Checked AndAlso Not chkScatterplotMatrix.Checked Then
            dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(dlgCorrelation.clsRCorrelation)
        End If
    End Sub

    Public Sub GGPairs()
        clsRGraphics.SetRCommand("ggpairs")
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGraphics)
    End Sub

    Public Sub GGcorr()
        'We still need to add more arguments to the ggcorr function 
        clsRGGcorrGraphics.SetRCommand("ggcorr")
        clsRGGcorrGraphics.AddParameter("data", "NULL")
        clsRGGcorrGraphics.AddParameter("cor_matrix", clsRFunctionParameter:=dlgCorrelation.clsRCorrelation)
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGGcorrGraphics)
    End Sub

    Public Sub GGscatmatrix()
        clsRGGscatmatrix.SetRCommand("ggscatmat")
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGGscatmatrix)
    End Sub

    Public Sub SetDefaults()
        ucrSaveGraph.SetDataFrameSelector(dlgCorrelation.ucrSelectorCorrelation.ucrAvailableDataFrames)
        ucrSaveGraph.strPrefix = "CorGraph"
        chkCorrelationMatrix.Checked = True
        chkPairwisePlot.Checked = False
        chkCorrelationPlot.Checked = False
        chkScatterplotMatrix.Checked = False
        nudAlphaScatter.Value = 1
        cmbgeom.SelectedItem = "tile"
        chkColour.Checked = False
        ucrReceiveFactor.Selector = ucrSelectFactor
        ucrReceiveFactor.SetDataType("factor")
        ucrSelectFactor.Reset()
        CorrOptions()
    End Sub

    Public Sub CorrOptions()
        If chkCorrelationMatrix.Checked Then
            CorrelationMatrix()
        End If
        If chkPairwisePlot.Checked Then
            GGPairs()
        End If
        If chkScatterplotMatrix.Checked Then
            GGscatmatrix()
        End If
        If chkCorrelationPlot.Checked Then
            GGcorr()
        End If
    End Sub

    Private Sub chkColor_CheckedChanged(sender As Object, e As EventArgs) Handles chkColour.CheckedChanged
        ColourbyFactor()
    End Sub

    Public Sub ColourbyFactor()
        If chkColour.Checked = True Then
            ucrSelectFactor.Visible = True
            ucrReceiveFactor.Visible = True
            lblFactorVariable.Visible = True
            clsRGGscatmatrix.AddParameter("color", ucrReceiveFactor.GetVariableNames)
        ElseIf chkColour.Checked = False Then
            clsRGGscatmatrix.AddParameter("color", "NULL")
            ucrSelectFactor.Visible = False
            ucrReceiveFactor.Visible = False
            lblFactorVariable.Visible = False
        Else
            clsRGGscatmatrix.RemoveParameterByName("color")
        End If
    End Sub

    Private Sub chkMatrixOrPlots(sender As Object, e As EventArgs) Handles chkCorrelationMatrix.CheckedChanged, chkPairwisePlot.CheckedChanged, chkCorrelationPlot.CheckedChanged, chkScatterplotMatrix.CheckedChanged
        If Not chkPairwisePlot.Checked AndAlso Not chkCorrelationPlot.Checked AndAlso Not chkScatterplotMatrix.Checked Then
            ucrSaveGraph.Visible = False
        Else
            ucrSaveGraph.Visible = True
            '    chkPairwisePlot.Checked = False
            '    chkCorrelationPlot.Checked = False
            '    chkScatterplotMatrix.Checked = False
        End If
        If chkPairwisePlot.Checked Then
            tbPairwisePlot.Enabled = True
            tbSaveGraphs.SelectTab(tbPairwisePlot)
            ucrSaveGraph.Visible = True
            '     chkCorrelationMatrix.Checked = False
            '    chkCorrelationPlot.Checked = False
            '    chkScatterplotMatrix.Checked = False
        Else
            tbPairwisePlot.Enabled = False
        End If
        If chkCorrelationPlot.Checked Then
            tbCorrelationPlot.Enabled = True
            tbSaveGraphs.SelectTab(tbCorrelationPlot)
            ucrSaveGraph.Visible = True
            '    chkPairwisePlot.Checked = False
            '    chkCorrelationMatrix.Checked = False
            '    chkScatterplotMatrix.Checked = False
        Else
            tbCorrelationPlot.Enabled = False
        End If
        If chkScatterplotMatrix.Checked Then
            tbScatterplotMatrix.Enabled = True
            tbSaveGraphs.SelectTab(tbScatterplotMatrix)
            ucrSaveGraph.Visible = True
            ucrReceiveFactor.Focus()
            ColourbyFactor()
            '   chkPairwisePlot.Checked = False
            '   chkCorrelationPlot.Checked = False
            '   chkCorrelationMatrix.Checked = False
        Else
            tbScatterplotMatrix.Enabled = False
        End If
        dlgCorrelation.TestOKEnabled()
        CorrOptions()
    End Sub

    Private Sub ucrSaveGraph_GraphNameChanged() Handles ucrSaveGraph.GraphNameChanged, ucrSaveGraph.SaveGraphCheckedChanged
        If ucrSaveGraph.bSaveGraph Then
            dlgCorrelation.ucrBase.clsRsyntax.SetAssignTo(ucrSaveGraph.strGraphName, strTempDataframe:=dlgCorrelation.ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveGraph.strGraphName)
        Else
            dlgCorrelation.ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub

    Private Sub chkCorrelationPlotItems_CheckedChanged(sender As Object, e As EventArgs) Handles chkLabel.CheckedChanged, nudMaximumSize.ValueChanged, nudMinimunSize.ValueChanged, nudAlphaCorr.ValueChanged
        If chkLabel.Checked Then
            clsRGGcorrGraphics.AddParameter("label", "TRUE")
        Else
            clsRGGcorrGraphics.AddParameter("label", "FALSE")
        End If
        clsRGGcorrGraphics.AddParameter("min_size", nudMinimunSize.Value.ToString)
        clsRGGcorrGraphics.AddParameter("max_size", nudMaximumSize.Value.ToString)
        clsRGGcorrGraphics.AddParameter("label_alpha", nudAlphaCorr.Value.ToString)
    End Sub

    Private Sub ucrReceiveFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiveFactor.SelectionChanged
        ColourbyFactor()
    End Sub

    Private Sub cmbgeom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgeom.SelectedIndexChanged
        If cmbgeom.SelectedItem = "circle" Then
            lblMaximumSize.Enabled = True
            lblMinimumSize.Enabled = True
            nudMaximumSize.Enabled = True
            nudMinimunSize.Enabled = True
            clsRGGcorrGraphics.AddParameter("min_size", nudMinimunSize.Value.ToString)
            clsRGGcorrGraphics.AddParameter("max_size", nudMaximumSize.Value.ToString)
        Else
            lblMaximumSize.Enabled = False
            lblMinimumSize.Enabled = False
            nudMaximumSize.Enabled = False
            nudMinimunSize.Enabled = False
            clsRGGcorrGraphics.RemoveParameterByName("min_size")
            clsRGGcorrGraphics.RemoveParameterByName("max_size")
        End If
        clsRGGcorrGraphics.AddParameter("geom", Chr(34) & cmbgeom.SelectedItem.ToString & Chr(34))
    End Sub

    Private Sub nudAlpha_ValueChanged(sender As Object, e As EventArgs) Handles nudAlphaScatter.ValueChanged
        clsRGGscatmatrix.AddParameter("alpha", nudAlphaScatter.Value.ToString)
    End Sub
End Class