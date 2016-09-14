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
Public Class sdgDescribeTwoVarGraph
    Public bFirstLoad As Boolean = True
    Private Sub sdgDescribeTwoVarGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Public Sub SetDefaults()
        grpVariateByVariate.Enabled = True
        grpVariateByFactor.Enabled = True
        grpFactorByVariate.Enabled = True
        grpFactorByFactor.Enabled = True
        rdoScatterPlot.Enabled = True
        rdoLinePlot.Enabled = True
        rdoBoxPlot.Enabled = True
        rdoSummaryPlot.Enabled = True
        rdoBarPlot.Enabled = True
        rdoDotPlot.Enabled = True
        rdoScatterPlot.Checked = True
        rdoLinePlot.Checked = False
        rdoBoxPlot.Checked = True
        rdoSummaryPlot.Checked = True
        rdoBarPlot.Checked = True
        rdoDotPlot.Checked = False
    End Sub

    Private Sub rdoTwoVarGraphs_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBarPlot.CheckedChanged, rdoLinePlot.CheckedChanged, rdoBoxPlot.CheckedChanged, rdoSummaryPlot.CheckedChanged, rdoDotPlot.CheckedChanged, rdoScatterPlot.CheckedChanged
        dlgDescribeTwoVarGraph.Results()
    End Sub

    Public Sub GrpBoxEnable()
        If ((dlgDescribeTwoVarGraph.strVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strVarType = "integer") And (dlgDescribeTwoVarGraph.strSecondVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "integer")) Then
            grpVariateByVariate.Enabled = True
            grpVariateByFactor.Enabled = False
            grpFactorByVariate.Enabled = False
            grpFactorByFactor.Enabled = False
            rdoScatterPlot.Enabled = True
            rdoLinePlot.Enabled = True
            rdoBoxPlot.Enabled = False
            rdoSummaryPlot.Enabled = False
            rdoBarPlot.Enabled = False
            rdoDotPlot.Enabled = False
        ElseIf ((dlgDescribeTwoVarGraph.strVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strVarType = "integer") And (dlgDescribeTwoVarGraph.strSecondVarType = "factor")) Then
            grpVariateByVariate.Enabled = False
            grpVariateByFactor.Enabled = True
            grpFactorByVariate.Enabled = False
            grpFactorByFactor.Enabled = False
            rdoScatterPlot.Enabled = False
            rdoLinePlot.Enabled = False
            rdoBoxPlot.Enabled = True
            rdoSummaryPlot.Enabled = False
            rdoBarPlot.Enabled = False
            rdoDotPlot.Enabled = False
        ElseIf ((dlgDescribeTwoVarGraph.strVarType = "factor") And (dlgDescribeTwoVarGraph.strSecondVarType = "numeric" OrElse dlgDescribeTwoVarGraph.strSecondVarType = "integer")) Then
            grpVariateByVariate.Enabled = False
            grpVariateByFactor.Enabled = False
            grpFactorByVariate.Enabled = True
            grpFactorByFactor.Enabled = False
            rdoScatterPlot.Enabled = False
            rdoLinePlot.Enabled = False
            rdoBoxPlot.Enabled = False
            rdoSummaryPlot.Enabled = True
            rdoBarPlot.Enabled = False
            rdoDotPlot.Enabled = False
        ElseIf ((dlgDescribeTwoVarGraph.strVarType = "factor") And (dlgDescribeTwoVarGraph.strSecondVarType = "factor")) Then
            grpVariateByVariate.Enabled = False
            grpVariateByFactor.Enabled = False
            grpFactorByVariate.Enabled = False
            grpFactorByFactor.Enabled = True
            rdoScatterPlot.Enabled = False
            rdoLinePlot.Enabled = False
            rdoBoxPlot.Enabled = False
            rdoSummaryPlot.Enabled = False
            rdoBarPlot.Enabled = True
            rdoDotPlot.Enabled = True
        End If
    End Sub
End Class