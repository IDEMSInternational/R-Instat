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
    Public strDataFrame As String

    Private Sub sdgCorrPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub CorrelationMatrix()
        If dlgCorrelation.rdoMultipleColumns.Checked AndAlso dlgCorrelation.ucrChkCorrelationMatrix.Checked AndAlso Not rdoPairwisePlot.Checked AndAlso Not rdoCorrelationPlot.Checked AndAlso Not rdoScatterplotMatrix.Checked Then
            If dlgCorrelation.ucrSaveModel.chkSaveModel.Checked Then
                dlgCorrelation.ucrBase.clsRsyntax.iCallType = 0
            Else
                dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
            End If
            ' dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(dlgCorrelation.clsRCorrelation)
        End If
        dlgCorrelation.TestOKEnabled()
    End Sub

    Public Sub GGPairs()
        'dlgCorrelation.TempData()
        clsRGraphics.SetPackageName("GGally")
        clsRGraphics.SetRCommand("ggpairs")
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGraphics)
        dlgCorrelation.TestOKEnabled()
    End Sub

    Public Sub GGcorr()
        'We still need to add more arguments to the ggcorr function 
        clsRGGcorrGraphics.SetPackageName("GGally")
        clsRGGcorrGraphics.SetRCommand("ggcorr")
        clsRGGcorrGraphics.AddParameter("data", "NULL")
        'clsRGGcorrGraphics.AddParameter("cor_matrix", clsRFunctionParameter:=dlgCorrelation.clsRCorrelation)
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGGcorrGraphics)
        dlgCorrelation.TestOKEnabled()
    End Sub

    Public Sub GGscatmatrix()
        'dlgCorrelation.TempData()
        clsRGGscatmatrix.SetPackageName("GGally")
        clsRGGscatmatrix.SetRCommand("ggscatmat")
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGGscatmatrix)
        dlgCorrelation.TestOKEnabled()
    End Sub

    Public Sub SetDefaults()
        ucrSaveGraph.SetDataFrameSelector(dlgCorrelation.ucrSelectorCorrelation.ucrAvailableDataFrames)
        ucrSaveGraph.strPrefix = "CorGraph"
        dlgCorrelation.ucrChkCorrelationMatrix.Checked = True
        rdoNone.Checked = True
        tbSaveGraphs.Visible = False
        nudAlphaScatter.Value = 1
        nudAlphaCorr.Value = 1
        ucrSelectFactor.Reset()
        cmbgeom.SelectedItem = "tile"
        chkColour.Checked = False
        chkLabel.Checked = False
        ucrReceiveFactor.Selector = ucrSelectFactor
        ucrReceiveFactor.SetDataType("factor")
        ucrSelectFactor.Reset()
        CorrOptions()
    End Sub

    Public Sub CorrOptions()
        If dlgCorrelation.ucrChkCorrelationMatrix.Checked Then
            CorrelationMatrix()
        End If
        If rdoPairwisePlot.Checked Then
            GGPairs()
        End If
        If rdoScatterplotMatrix.Checked Then
            GGscatmatrix()
        End If
        If rdoCorrelationPlot.Checked Then
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

    Private Sub MatrixOrPlots(sender As Object, e As EventArgs) Handles rdoPairwisePlot.CheckedChanged, rdoCorrelationPlot.CheckedChanged, rdoScatterplotMatrix.CheckedChanged, rdoNone.CheckedChanged
        If ((dlgCorrelation.ucrChkCorrelationMatrix.Checked AndAlso Not rdoPairwisePlot.Checked AndAlso Not rdoCorrelationPlot.Checked AndAlso Not rdoScatterplotMatrix.Checked) OrElse (Not dlgCorrelation.ucrChkCorrelationMatrix.Checked AndAlso rdoNone.Checked)) Then
            ucrSaveGraph.chkSaveGraph.Checked = False
            ucrSaveGraph.Visible = False
            tbSaveGraphs.Visible = False
        Else
            ucrSaveGraph.Visible = True
            tbSaveGraphs.Visible = True
        End If

        If rdoPairwisePlot.Checked Then
            tbPairwisePlot.Enabled = True
            tbSaveGraphs.SelectTab(tbPairwisePlot)
            ucrSaveGraph.Visible = True
        Else
            tbPairwisePlot.Enabled = False
        End If

        If rdoCorrelationPlot.Checked Then
            tbCorrelationPlot.Enabled = True
            tbSaveGraphs.SelectTab(tbCorrelationPlot)
            ucrSaveGraph.Visible = True
        Else
            tbCorrelationPlot.Enabled = False
        End If

        If rdoScatterplotMatrix.Checked Then
            tbScatterplotMatrix.Enabled = True
            tbSaveGraphs.SelectTab(tbScatterplotMatrix)
            ucrSaveGraph.Visible = True
            ucrReceiveFactor.Focus()
            ColourbyFactor()
        Else
            tbScatterplotMatrix.Enabled = False
        End If
        dlgCorrelation.TestOKEnabled()
        CorrOptions()
    End Sub

    Private Sub ucrSaveGraph_GraphNameChanged() Handles ucrSaveGraph.GraphNameChanged, ucrSaveGraph.SaveGraphCheckedChanged
        dlgCorrelation.TestOKEnabled()
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

    Public Sub SetDataFrame(strNewDataFrame As String)
        strDataFrame = strNewDataFrame
        ucrSelectFactor.SetDataframe(strDataFrame, False)
    End Sub
End Class