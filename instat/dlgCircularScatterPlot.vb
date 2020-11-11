'R-Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgCircularScatterPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsMutateFunction As RFunction
    Private clsArrangeFunction As RFunction
    Private clsDensityFunction As RFunction
    Private clsOrderFunction As RFunction
    Private clsGgplotFunction As RFunction
    Private clsGgplotAesFunction As RFunction
    Private clsGeomPointFunction As RFunction
    Private clsGeomPointAesFunction As RFunction
    Private clsGeomLineFunction As RFunction
    Private clsYlimFunction As RFunction
    Private clsXlimFunction As RFunction
    Private clsCordPolarFunction As RFunction
    Private clsMinimumFunction As RFunction
    Private clsMaximumFunction As RFunction
    Private clsFacetWrapFunction As RFunction
    Private clsVarsFunction As RFunction

    Private clsPipeOperator As ROperator
    Private clsPlusOperator As ROperator
    Private clsDolarOperator As ROperator

    Private Sub dlgCircularScatterPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If

        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorCircularDataFrame.SetParameter(New RParameter("data", 0))
        ucrSelectorCircularDataFrame.SetParameterIsrfunction()

        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        ucrReceiverVariable.Selector = ucrSelectorCircularDataFrame
        ucrReceiverVariable.SetParameterIsString()
        ucrReceiverVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverVariable.strSelectorHeading = "Numerics"
        ucrReceiverVariable.bWithQuotes = False

        ucrSaveScatterPlot.SetDataFrameSelector(ucrSelectorCircularDataFrame.ucrAvailableDataFrames)
        ucrSaveScatterPlot.SetSaveTypeAsGraph()
        ucrSaveScatterPlot.SetCheckBoxText("Save Graph:")
        ucrSaveScatterPlot.SetPrefix("circular_density_plot")
        ucrSaveScatterPlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

End Class