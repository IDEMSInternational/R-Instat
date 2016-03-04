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
Public Class dlgSummaryBarOrPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_summarybar As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub cmdOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        clsRgeom_summarybar.SetRCommand("geom_bar")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_summarybar)

        ucrYReceiver.Selector = ucrSummarybarSelector
        ucrFactorReceiver.Selector = ucrSummarybarSelector
        ucrFactorReceiver.SetDataType("factor")
        ucrSecondFactorReceiver.Selector = ucrSummarybarSelector
        ucrSecondFactorReceiver.SetDataType("factor")
        ucrYReceiver.SetMeAsReceiver()
        autoTranslate(Me)
        ucrBase.clsRsyntax.iCallType = 0

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub
    Private Sub TestOkEnabled()
        If Not ucrYReceiver.IsEmpty And Not ucrFactorReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)

        End If
    End Sub
    Private Sub SetDefaults()
        ucrSummarybarSelector.Reset()
        ucrSummarybarSelector.Focus()
        cmdBarChartOptions.Visible = False
        cmdPieChartOptions.Visible = False
        TestOkEnabled()
    End Sub
    Private Sub grpChartOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBarChart.CheckedChanged, rdoPieChart.CheckedChanged

        SummaryCheck()
        Dim clsTempRFunc As New RFunction
        If rdoBarChart.Checked = True Then
            cmdBarChartOptions.Visible = True
            cmdPieChartOptions.Visible = False
            lblSecondFactor.Visible = True
            ucrSecondFactorReceiver.Visible = True
            clsRgeom_summarybar.AddParameter("stat", Chr(34) & "identity" & Chr(34))
            ucrBase.clsRsyntax.RemoveOperatorParameter("polar")
            clsRgeom_summarybar.RemoveParameterByName("width")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_summarybar)

        ElseIf rdoPieChart.Checked = True
            cmdPieChartOptions.Visible = True
            cmdBarChartOptions.Visible = False
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
            lblSecondFactor.Visible = False
            ucrSecondFactorReceiver.Visible = False
            ucrYReceiver.SetMeAsReceiver()

            clsRgeom_summarybar.AddParameter("width", 1)
            clsRgeom_summarybar.AddParameter("stat", Chr(34) & "identity" & Chr(34))
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_summarybar)

            clsTempRFunc.SetRCommand("coord_polar")
            clsTempRFunc.AddParameter("theta", Chr(34) & "y" & Chr(34))
            ucrBase.clsRsyntax.AddOperatorParameter("polar", clsRFunc:=clsTempRFunc)

        End If
    End Sub

    Private Sub ucrYReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrYReceiver.SelectionChanged
        If Not ucrYReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrYReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSecondFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.SelectionChanged
        If Not ucrSecondFactorReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged
        SummaryCheck()
        TestOkEnabled()
    End Sub

    Private Sub SummaryCheck()
        If rdoBarChart.Checked = True Then
            If ucrFactorReceiver.IsEmpty Then
                clsRaesFunction.RemoveParameterByName("x")
            Else
                clsRaesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
            End If

        ElseIf rdoPieChart.Checked = True Then
            If ucrFactorReceiver.IsEmpty Then
                clsRaesFunction.RemoveParameterByName("fill")
            Else
                clsRaesFunction.AddParameter("fill", ucrYReceiver.GetVariableNames(False))
            End If
        End If
    End Sub

    Private Sub ucrSummarybarSelector_DataFrameChanged() Handles ucrSummarybarSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSummarybarSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        sdgBarChart.ShowDialog()
    End Sub

    Private Sub cmdPieChartOptions_Click(sender As Object, e As EventArgs) Handles cmdPieChartOptions.Click
        sdgPieChartOptions.ShowDialog()
    End Sub
End Class