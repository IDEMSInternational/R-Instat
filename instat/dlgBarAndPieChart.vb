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
Public Class dlgBarAndPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_barchart As New RFunction
    Private clsRgeom_piechart As New RFunction
    Private clsRgeom_piechartCoord As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private Sub dlgBarAndPieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrFactorReceiver.Selector = ucrBarChartSelector
        ucrSecondReceiver.Selector = ucrBarChartSelector
        ucrFactorReceiver.SetMeAsReceiver()
        rdoBarChart.Checked = True
        ucrBase.clsRsyntax.iCallType = 0
        autoTranslate(Me)

        sdgBarChart.SetBarChartFunction(clsRgeom_barchart)
        'set pie chart function when it exists
        'sdgPieChart.SetPieChartFunction(clsRgeom_piechart)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
    End Sub

    Private Sub SetDefaults()
        'Set main dialog defaults...

        'set subdialog defaults
        sdgBarChart.SetDefaults()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Public Sub TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrBarChartSelector_DataFrameChanged() Handles ucrBarChartSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrBarChartSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
    Private Sub ucrFactorReceiver_Leave(sender As Object, e As EventArgs) Handles ucrFactorReceiver.Leave
        If rdoBarChart.Checked = True Then
            clsRaesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("fill", ucrFactorReceiver.GetVariableNames(False))

        End If
    End Sub
    Private Sub ucrSecondReceiver_Leave(sender As Object, e As EventArgs) Handles ucrSecondReceiver.Leave
        If rdoBarChart.Checked = True Then
            clsRaesFunction.AddParameter("fill", ucrSecondReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
    End Sub

    Private Sub grpSelection_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBarChart.CheckedChanged, rdoPieChart.CheckedChanged
        If rdoBarChart.Checked = True Then
            clsRgeom_barchart.SetRCommand("geom_bar")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_barchart)
            cmdBarChartOptions.Visible = True
            cmdPieChartOptions.Visible = False
        ElseIf rdoPieChart.Checked = True Then

            Dim clsTempOp As New ROperator
            Dim clsTempRFunc As New RFunction
            clsTempOp.SetOperation("+")

            clsRgeom_piechart.SetRCommand("geom_bar")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_piechart)
            clsRgeom_piechart.AddParameter("width", "1")

            clsTempOp.SetParameter(True, clsRFunc:=clsRggplotFunction)
            clsTempOp.SetParameter(False, clsRFunc:=clsRgeom_piechart)
            clsTempRFunc.SetRCommand("coord_polar")
            clsTempRFunc.AddParameter("theta", Chr(34) & "y" & Chr(34))
            ucrBase.clsRsyntax.SetOperatorParameter(True, clsOp:=clsTempOp)
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsTempRFunc)
            cmdBarChartOptions.Visible = False
            cmdPieChartOptions.Visible = True
        Else
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=Nothing)
            cmdBarChartOptions.Visible = False
            cmdPieChartOptions.Visible = False
        End If
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        sdgBarChart.ShowDialog()
    End Sub
End Class