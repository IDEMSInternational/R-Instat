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
    Public clsRModelFunction As RFunction
    Public clsRGGPairsFunction As New RFunction
    Public clsRGGscatmatrix As New RSyntax
    Public bFirstLoad As Boolean = True

    Private Sub sdgCorrPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetRModelFunction(clsRModelFunc As RFunction)
        clsRModelFunction = clsRModelFunc
    End Sub

    Private Sub CorrelationMatrix()
        frmMain.clsRLink.RunScript(dlgCorrelation.ucrBase.clsRsyntax.clsBaseFunction.ToScript(), 2)
    End Sub

    Private Sub GGPairs()
        Dim clsRGraphics As New RSyntax
        clsRGraphics.SetFunction("ggpairs")
        clsRGraphics.AddParameter("data", clsRFunctionParameter:=dlgCorrelation.ucrSelectorDataFrameVarAddRemove.ucrAvailableDataFrames.clsCurrDataFrame)
        clsRGraphics.AddParameter("columns", dlgCorrelation.ucrReceiverMultipleColumns.GetVariableNames())

        'Calltype is not the right one but it works
        frmMain.clsRLink.RunScript(clsRGraphics.GetScript(), 2)
    End Sub

    Private Sub GGcorr()
        Dim clsRGGcorrGraphics As New RSyntax
        'We may have to save the correlation matrix then use it here.
        'We still need to add more arguments to the ggcorr function 
        clsRGGcorrGraphics.SetFunction("ggcorr")
        clsRGGcorrGraphics.AddParameter("data", "NULL")
        clsRGGcorrGraphics.AddParameter("cor_matrix", dlgCorrelation.ucrBase.clsRsyntax.GetScript())

        'Calltype is not the right one but it works
        frmMain.clsRLink.RunScript(clsRGGcorrGraphics.GetScript(), 2)
    End Sub

    Public Sub GGscatmatrix()
        ' Dim clsRGGscatmatrix As New RSyntax
        clsRGGscatmatrix.SetFunction("ggscatmat")
        clsRGGscatmatrix.AddParameter("data", clsRFunctionParameter:=dlgCorrelation.ucrSelectorDataFrameVarAddRemove.ucrAvailableDataFrames.clsCurrDataFrame)
        clsRGGscatmatrix.AddParameter("columns", dlgCorrelation.ucrReceiverMultipleColumns.GetVariableNames(bWithQuotes:=True))
        'clsRGGscatmatrix.AddParameter("color", "NULL") 'This is the default option. We need to use factor column from data
        'clsRGGscatmatrix.AddParameter("alpha", 1) 'This is the default option. We need a numeric up-down in the subdialogue

        frmMain.clsRLink.RunScript(clsRGGscatmatrix.GetScript(), 2)
    End Sub

    Public Sub SetDefaults()
        chkCorrelationMatrix.Checked = True
        rdoPairwisePlot.Checked = False
        rdoCorrelationPlot.Checked = False
        rdoScatterplotMatrix.Checked = False
        tbSaveGraphs.Visible = False
        chkColor.Checked = False
        nudAlpha.Value = 1
        lblAlpha.Enabled = False
        nudAlpha.Enabled = False
        chkColor.Enabled = False
        'set save graph to unchecked by default
    End Sub

    Public Sub RegOptions()
        If (chkCorrelationMatrix.Checked = True) Then
            CorrelationMatrix()
        End If
        If (rdoPairwisePlot.Checked = True) Then
            GGPairs()
        End If
        If (rdoScatterplotMatrix.Checked = True) Then
            GGscatmatrix()
        End If
        If (rdoCorrelationPlot.Checked = True) Then
            GGcorr()
        End If
    End Sub

    Private Sub ucrSaveGraph_CheckedChanged(bChecked As Boolean) Handles ucrSaveGraph.CheckedChanged
        If bChecked = True Then
            tbSaveGraphs.Visible = True
        Else
            tbSaveGraphs.Visible = False
        End If
    End Sub

    Private Sub nudAlpha_ValueChanged(sender As Object, e As EventArgs) Handles nudAlpha.ValueChanged
        clsRGGscatmatrix.AddParameter("alpha", nudAlpha.Value.ToString) 'This is the default option. We need a numeric up-down in the subdialogue
    End Sub

    Private Sub chkColor_CheckedChanged(sender As Object, e As EventArgs) Handles chkColor.CheckedChanged
        If chkColor.Checked = True Then
            ' clsRGGscatmatrix.AddParameter("color", ....) 'We need to use factor column from data
        ElseIf chkColor.Checked = False Then
            clsRGGscatmatrix.AddParameter("color", "NULL")
        Else
            clsRGGscatmatrix.RemoveParameter("color")
        End If
    End Sub

    Private Sub rdoScatterplotMatrix_CheckedChanged(sender As Object, e As EventArgs) Handles rdoScatterplotMatrix.CheckedChanged
        If rdoScatterplotMatrix.Checked Then
            lblAlpha.Enabled = True
            nudAlpha.Enabled = True
            chkColor.Enabled = True
        Else
            lblAlpha.Enabled = False
            nudAlpha.Enabled = False
            chkColor.Enabled = False
        End If

    End Sub

 \End Class