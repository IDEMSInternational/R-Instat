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
    Private clsRaesFunction As New RFunction
    Private clsTempRFunc As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgBarAndPieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        autoTranslate(Me)
    End Sub

    Private Sub SetDefaults()
        'Set main dialog defaults...
        rdoBarChart.Checked = True
        ucrBarChartSelector.Reset()
        ucrBarChartSelector.Focus()
        ucrFactorReceiver.SetMeAsReceiver()
        'set subdialog defaults
        'sdgBarChart.SetDefaults()
        sdgPieChartOptions.SetDefaults()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        clsRgeom_barchart.SetRCommand("geom_bar")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_barchart)
        ucrFactorReceiver.Selector = ucrBarChartSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})

        ucrSecondReceiver.Selector = ucrBarChartSelector
        ucrSecondReceiver.SetIncludedDataTypes({"factor"})


        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 327


        ucrSaveBar.SetDataFrameSelector(ucrBarChartSelector.ucrAvailableDataFrames)
        ucrSaveBar.strPrefix = "Graph"

    End Sub

    Private Sub ReopenDialog()
    End Sub

    Public Sub TestOKEnabled()
        If ucrFactorReceiver.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            If rdoBarChart.Checked = True Then
                clsRaesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
                If Not ucrSecondReceiver.IsEmpty Then
                    clsRaesFunction.AddParameter("fill", ucrSecondReceiver.GetVariableNames(False))
                Else
                    clsRaesFunction.RemoveParameterByName("fill")
                End If
            ElseIf rdoPieChart.Checked = True Then
                clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
                clsRaesFunction.AddParameter("fill", ucrFactorReceiver.GetVariableNames(False))
            End If
            ucrBase.OKEnabled(True)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrBarChartSelector_DataFrameChanged() Handles ucrBarChartSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrBarChartSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrFactorReceiver_SelectionChanged() Handles ucrFactorReceiver.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSecondReceiver_SelectionChanged() Handles ucrSecondReceiver.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub grpSelection_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBarChart.CheckedChanged, rdoPieChart.CheckedChanged

        If rdoBarChart.Checked = True Then
            clsRgeom_barchart.RemoveParameterByName("width")
            ucrBase.clsRsyntax.RemoveOperatorParameter("polar")
            cmdBarChartOptions.Visible = True
            cmdPieChartOptions.Visible = False
            ucrSecondReceiver.Visible = True
            lblSecondFactor.Visible = True
        ElseIf rdoPieChart.Checked = True Then
            clsRgeom_barchart.AddParameter("width", "1")
            clsTempRFunc.SetRCommand("coord_polar")
            clsTempRFunc.AddParameter("theta", Chr(34) & "y" & Chr(34))
            ucrBase.clsRsyntax.AddOperatorParameter("polar", clsRFunc:=clsTempRFunc)
            cmdBarChartOptions.Visible = False
            cmdPieChartOptions.Visible = True
            ucrSecondReceiver.Visible = False
            lblSecondFactor.Visible = False
        End If
        TestOKEnabled()
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

    Private Sub ucrSaveBar_GraphNameChanged() Handles ucrSaveBar.GraphNameChanged, ucrSaveBar.SaveGraphCheckedChanged
        If ucrSaveBar.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveBar.strGraphName, strTempDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveBar.strGraphName)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
    End Sub
End Class