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
Public Class dlgBoxplot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_boxplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private Sub dlgBoxPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRgeom_boxplotFunction.SetRCommand("geom_boxplot")
        clsRaesFunction.SetRCommand("aes")
        clsRaesFunction.AddParameter("x", "") ' Empty string is default x value in case no factor is chosen
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        SetOperator()
        ucrBase.clsRsyntax.iCallType = 0
        ucrYvariableReceiver.Selector = ucrSelectorBoxPlot
        ucrYvariableReceiver.SetMeAsReceiver()
        ucrByFactorsReceiver.Selector = ucrSelectorBoxPlot
        ucrByFactorsReceiver.SetDataType("factor")
        ucrSecondFactorReceiver.Selector = ucrSelectorBoxPlot
        ucrSecondFactorReceiver.SetDataType("factor")
        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If

    End Sub

    Private Sub SetOperator()

        Dim clsTempOp As New ROperator
        Dim clsTempRFunc As New RFunction
        If chkHorizontalBoxplot.Checked Then
            clsTempOp.SetOperation("+")
            clsTempOp.SetParameter(True, clsRFunc:=clsRggplotFunction)
            clsTempOp.SetParameter(False, clsRFunc:=clsRgeom_boxplotFunction)
            clsTempRFunc.SetRCommand("coord_flip")
            ucrBase.clsRsyntax.SetOperatorParameter(True, clsOp:=clsTempOp)
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsTempRFunc)
        Else
            ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_boxplotFunction)
        End If
    End Sub
    Private Sub SetDefaults()
        ucrSelectorBoxPlot.Reset()
        ucrSelectorBoxPlot.Focus()
        ucrYvariableReceiver.SetMeAsReceiver()
        chkHorizontalBoxplot.Checked = False
        chkNotchedBoxplot.Checked = False
        chkVariableWidth.Checked = False
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrYvariableReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub
    Private Sub ucrSelectorBoxPlot_DataFrameChanged() Handles ucrSelectorBoxPlot.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorBoxPlot.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrYvariableReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrYvariableReceiver.SelectionChanged
        If Not ucrYvariableReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrYvariableReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrByFactorsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrByFactorsReceiver.SelectionChanged
        If Not ucrByFactorsReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrByFactorsReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
    End Sub
    Private Sub ucrSecondFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.SelectionChanged

        If Not ucrSecondFactorReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
        End If
    End Sub
    Private Sub chkHorizontalBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles chkHorizontalBoxplot.CheckedChanged
        SetOperator()
    End Sub

    Private Sub chkNotchedBoxplot_CheckedChanged(sender As Object, e As EventArgs) Handles chkNotchedBoxplot.CheckedChanged
        If chkNotchedBoxplot.Checked Then
            clsRgeom_boxplotFunction.AddParameter("notch", "TRUE")
        Else
            clsRgeom_boxplotFunction.RemoveParameterByName("notch")
        End If
    End Sub

    Private Sub chkVariableWidth_CheckedChanged(sender As Object, e As EventArgs) Handles chkVariableWidth.CheckedChanged
        If chkVariableWidth.Checked Then
            clsRgeom_boxplotFunction.AddParameter("varwidth", "TRUE")
        Else
            clsRgeom_boxplotFunction.RemoveParameterByName("varwidth")
        End If
    End Sub
    Private Sub cmdBoxPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdBoxPlotOptions.Click
        sdgBoxPlot.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class