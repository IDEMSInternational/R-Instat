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
    Public clsRGGscatmatrix, clsRGGcorrGraphicsFunction, clsRGraphicsFuction As New RFunction
    Public bFirstLoad As Boolean = True
    Private bControlsInitialised As Boolean = False
    Public strDataFrame As String

    Private Sub sdgCorrPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrNudMaximumSize.SetParameter(New RParameter("max_size", 1))
        ucrNudMaximumSize.SetMinMax(1, 10)
        ucrNudMinimunSize.SetParameter(New RParameter("min_size", 2))
        ucrNudMinimunSize.SetMinMax(1, 5)

        ucrNudAlphaCorr.SetParameter(New RParameter("label_alpha", 3))
        ucrNudAlphaCorr.SetMinMax(0, 1)
        ucrNudAlphaCorr.DecimalPlaces = 2
        ucrNudAlphaCorr.Increment = 0.01

        Dim dctGeom As New Dictionary(Of String, String)
        ucrInputComboGeom.SetParameter(New RParameter("geom", 3))
        dctGeom.Add("tile", Chr(34) & "tile" & Chr(34))
        dctGeom.Add("circle", Chr(34) & "circle" & Chr(34))
        dctGeom.Add("text", Chr(34) & "text" & Chr(34))
        dctGeom.Add("blank", Chr(34) & "blank" & Chr(34))
        ucrInputComboGeom.SetItems(dctGeom)
        ucrInputComboGeom.SetRDefault("tile")
        ucrInputComboGeom.SetDropDownStyleAsNonEditable()
    End Sub

    Public Sub SetRFunction(clscorrelationFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRGGcorrGraphicsFunction = clscorrelationFunction
        clsRGGcorrGraphicsFunction.SetPackageName("GGally")
        clsRGGcorrGraphicsFunction.SetRCommand("ggcorr")
        clsRGraphicsFuction.SetPackageName("GGally")
        clsRGraphicsFuction.SetRCommand("ggpairs")

        'settingRcode for subdialog
        ucrNudMaximumSize.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrNudMinimunSize.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrInputComboGeom.SetRCode(clsRGGcorrGraphicsFunction, bReset)

        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGraphicsFuction)
        'If bReset Then
        '    tbCorrelationPlot.SelectedIndex = 0
        'End If
    End Sub

    'Private Sub chkCorrelationPlotItems_CheckedChanged(sender As Object, e As EventArgs) Handles chkLabel.CheckedChanged
    '    If chkLabel.Checked Then
    '        clsRGGcorrGraphicsFunction.AddParameter("label", "TRUE")
    '    Else
    '        clsRGGcorrGraphicsFunction.AddParameter("label", "FALSE")
    '    End If
    '    clsRGGcorrGraphicsFunction.AddParameter("min_size", ucrNudMinimunSize.Value.ToString)
    '    clsRGGcorrGraphicsFunction.AddParameter("max_size", ucrNudMaximumSize.Value.ToString)
    '    clsRGGcorrGraphicsFunction.AddParameter("label_alpha", ucrNudAlphaCorr.Value.ToString)
    'End Sub

    Public Sub CorrelationMatrix()
        If dlgCorrelation.rdoMultipleColumns.Checked AndAlso dlgCorrelation.ucrChkCorrelationMatrix.Checked AndAlso Not rdoPairwisePlot.Checked AndAlso Not rdoCorrelationPlot.Checked AndAlso Not rdoScatterplotMatrix.Checked Then
            If dlgCorrelation.ucrSaveModel.chkSaveModel.Checked Then
                dlgCorrelation.ucrBase.clsRsyntax.iCallType = 0
            Else
                dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
            End If
            dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(dlgCorrelation.clsCorrelationFunction)
        End If
        dlgCorrelation.TestOKEnabled()
    End Sub

    Public Sub GGPairs()
        'dlgCorrelation.TempData()

        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2

        dlgCorrelation.TestOKEnabled()
    End Sub

    Public Sub GGcorr()
        'We still need to add more arguments to the ggcorr function 
        clsRGGcorrGraphicsFunction.AddParameter("data", "NULL")
        clsRGGcorrGraphicsFunction.AddParameter("cor_matrix", clsRFunctionParameter:=dlgCorrelation.clsCorrelationFunction)
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGGcorrGraphicsFunction)
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
        ucrNudAlphaCorr.Value = 1
        ucrSelectFactor.Reset()
        'cmbgeom.SelectedItem = "tile"
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

    Private Sub ucrReceiveFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiveFactor.SelectionChanged
        ColourbyFactor()
    End Sub

    Private Sub cmbgeom_SelectedIndexChanged(sender As Object, e As EventArgs)
        'If cmbgeom.SelectedItem = "circle" Then
        lblMaximumSize.Enabled = True
        lblMinimumSize.Enabled = True
        ucrNudMaximumSize.Enabled = True
        ucrNudMinimunSize.Enabled = True
        clsRGGcorrGraphicsFunction.AddParameter("min_size", ucrNudMinimunSize.Value.ToString)
        clsRGGcorrGraphicsFunction.AddParameter("max_size", ucrNudMaximumSize.Value.ToString)
        'Else
        lblMaximumSize.Enabled = False
        lblMinimumSize.Enabled = False
        ucrNudMaximumSize.Enabled = False
        ucrNudMinimunSize.Enabled = False
        clsRGGcorrGraphicsFunction.RemoveParameterByName("min_size")
        clsRGGcorrGraphicsFunction.RemoveParameterByName("max_size")
        ' End If
        'clsRGGcorrGraphicsFunction.AddParameter("geom", Chr(34) & cmbgeom.SelectedItem.ToString & Chr(34))
    End Sub

    Public Sub SetDataFrame(strNewDataFrame As String)
        strDataFrame = strNewDataFrame
        ucrSelectFactor.SetDataframe(strDataFrame, False)
    End Sub
End Class