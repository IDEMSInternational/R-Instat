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
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(dlgCorrelation.clsRCorrelation)
    End Sub

    Public Sub GGPairs()
        clsRGraphics.SetRCommand("ggpairs")
        clsRGraphics.AddParameter("data", clsRFunctionParameter:=dlgCorrelation.ucrSelectorDataFrameVarAddRemove.ucrAvailableDataFrames.clsCurrDataFrame)
        clsRGraphics.AddParameter("columns", dlgCorrelation.ucrReceiverMultipleColumns.GetVariableNames())
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
        clsRGGscatmatrix.AddParameter("data", clsRFunctionParameter:=dlgCorrelation.ucrSelectorDataFrameVarAddRemove.ucrAvailableDataFrames.clsCurrDataFrame)
        clsRGGscatmatrix.AddParameter("columns", dlgCorrelation.ucrReceiverMultipleColumns.GetVariableNames(bWithQuotes:=True))
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGGscatmatrix)
    End Sub

    Public Sub SetDefaults()
        ucrSaveGraph.SetDataFrameSelector(dlgCorrelation.ucrSelectorDataFrameVarAddRemove.ucrAvailableDataFrames)
        ucrSaveGraph.strPrefix = "CorGraph"
        chkCorrelationMatrix.Checked = True
        chkPairwisePlot.Checked = False
        chkCorrelationPlot.Checked = False
        chkScatterplotMatrix.Checked = False
        tbSaveGraphs.Enabled = False
        chkColor.Checked = False
        nudAlpha.Value = 1
        lblAlpha.Enabled = False
        nudAlpha.Enabled = False
        chkColor.Enabled = False
        cmbgeom.SelectedItem = "tile"
        lblgeom.Enabled = False
        cmbgeom.Enabled = False
        lblMaximumSize.Enabled = False
        lblMinimumSize.Enabled = False
        nudMaximumSize.Enabled = False
        nudMinimunSize.Enabled = False
        chkLabel.Enabled = False
        lblLabelAlpha.Enabled = False
        nudLabelAlpha.Enabled = False
    End Sub

    Public Sub RegOptions()
        If (chkCorrelationMatrix.Checked = True) Then
            CorrelationMatrix()
        End If
        If (chkPairwisePlot.Checked = True) Then
            GGPairs()
        End If
        If (chkScatterplotMatrix.Checked = True) Then
            GGscatmatrix()
        End If
        If (chkCorrelationPlot.Checked = True) Then
            GGcorr()
        End If
    End Sub

    Private Sub nudAlpha_ValueChanged(sender As Object, e As EventArgs) Handles nudAlpha.ValueChanged
        clsRGGscatmatrix.AddParameter("alpha", nudAlpha.Value.ToString)
    End Sub

    Private Sub chkColor_CheckedChanged(sender As Object, e As EventArgs) Handles chkColor.CheckedChanged
        If chkColor.Checked = True Then
            ' clsRGGscatmatrix.AddParameter("color", ....) 'We need to use factor column from data
        ElseIf chkColor.Checked = False Then
            clsRGGscatmatrix.AddParameter("color", "NULL")
        Else
            clsRGGscatmatrix.RemoveParameterByName("color")
        End If
    End Sub

    Private Sub nudMinimunSize_ValueChanged(sender As Object, e As EventArgs) Handles nudMinimunSize.ValueChanged
        clsRGGcorrGraphics.AddParameter("min_size", nudMinimunSize.Value.ToString)
    End Sub

    Private Sub nudMaximumSize_ValueChanged(sender As Object, e As EventArgs) Handles nudMaximumSize.ValueChanged
        clsRGGcorrGraphics.AddParameter("max_size", nudMaximumSize.Value.ToString)
    End Sub

    Private Sub chkLabel_CheckedChanged(sender As Object, e As EventArgs) Handles chkLabel.CheckedChanged
        If chkLabel.Checked Then
            clsRGGcorrGraphics.AddParameter("label", "TRUE")
        Else
            clsRGGcorrGraphics.AddParameter("label", "FALSE")
        End If
    End Sub

    Private Sub nudLabelAlpha_ValueChanged(sender As Object, e As EventArgs) Handles nudLabelAlpha.ValueChanged
        clsRGGcorrGraphics.AddParameter("label_alpha", nudLabelAlpha.Value.ToString)
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

    Private Sub chkScatterplotMatrix_CheckedChanged(sender As Object, e As EventArgs) Handles chkScatterplotMatrix.CheckedChanged
        If chkScatterplotMatrix.Checked Then
            lblAlpha.Enabled = True
            nudAlpha.Enabled = True
            chkColor.Enabled = True
            tbSaveGraphs.Enabled = True
            ucrSaveGraph.Visible = True
            chkCorrelationMatrix.Checked = False
            chkPairwisePlot.Checked = False
            chkCorrelationPlot.Checked = False
        Else
            lblAlpha.Enabled = False
            nudAlpha.Enabled = False
            chkColor.Enabled = False
        End If
        dlgCorrelation.TestOKEnabled()
        RegOptions()
    End Sub

    Private Sub chkCorrelationPlot_CheckedChanged(sender As Object, e As EventArgs) Handles chkCorrelationPlot.CheckedChanged
        If chkCorrelationPlot.Checked Then
            lblgeom.Enabled = True
            cmbgeom.Enabled = True
            chkLabel.Enabled = True
            lblLabelAlpha.Enabled = True
            nudLabelAlpha.Enabled = True
            tbSaveGraphs.Enabled = True
            ucrSaveGraph.Visible = True
            chkCorrelationMatrix.Checked = False
            chkScatterplotMatrix.Checked = False
            chkPairwisePlot.Checked = False
        Else
            lblgeom.Enabled = False
            cmbgeom.Enabled = False
            chkLabel.Enabled = False
            lblLabelAlpha.Enabled = False
            nudLabelAlpha.Enabled = False
        End If
        dlgCorrelation.TestOKEnabled()
        RegOptions()
    End Sub

    Private Sub chkCorrelationMatrix_CheckedChanged(sender As Object, e As EventArgs) Handles chkCorrelationMatrix.CheckedChanged
        If chkCorrelationMatrix.Checked Then
            tbSaveGraphs.Enabled = False
            ucrSaveGraph.Visible = False
            chkPairwisePlot.Checked = False
            chkScatterplotMatrix.Checked = False
            chkCorrelationPlot.Checked = False
        End If
        dlgCorrelation.TestOKEnabled()
        RegOptions()
    End Sub

    Private Sub chkPairwisePlot_CheckedChanged(sender As Object, e As EventArgs) Handles chkPairwisePlot.CheckedChanged
        If chkPairwisePlot.Checked Then
            tbSaveGraphs.Enabled = True
            ucrSaveGraph.Visible = True
            chkCorrelationMatrix.Checked = False
            chkScatterplotMatrix.Checked = False
            chkCorrelationPlot.Checked = False
        End If
        dlgCorrelation.TestOKEnabled()
        RegOptions()
    End Sub

    Private Sub ucrSaveGraph_GraphNameChanged() Handles ucrSaveGraph.GraphNameChanged, ucrSaveGraph.SaveGraphCheckedChanged
        If ucrSaveGraph.bSaveGraph Then
            dlgCorrelation.ucrBase.clsRsyntax.SetAssignTo(ucrSaveGraph.strGraphName, strTempDataframe:=dlgCorrelation.ucrSelectorDataFrameVarAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveGraph.strGraphName)
        Else
            dlgCorrelation.ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub
End Class