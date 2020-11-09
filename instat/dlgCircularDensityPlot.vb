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

Public Class dlgCircularDensityPlot
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

    Private Sub dlgCircularDensityPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrSelectorDataFrame.SetParameter(New RParameter("data", 0))
        ucrSelectorDataFrame.SetParameterIsrfunction()

        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        ucrReceiverVariable.Selector = ucrSelectorDataFrame
        ucrReceiverVariable.SetParameterIsString()
        ucrReceiverVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverVariable.strSelectorHeading = "Numerics"
        ucrReceiverVariable.bWithQuotes = False

        ucrReceiverFactor.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverFactor.Selector = ucrSelectorDataFrame
        ucrReceiverFactor.SetParameterIsString()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.bWithQuotes = False


        ucrSaveDensityPlot.SetDataFrameSelector(ucrSelectorDataFrame.ucrAvailableDataFrames)
        ucrSaveDensityPlot.SetSaveTypeAsGraph()
        ucrSaveDensityPlot.SetCheckBoxText("Save Graph:")
        ucrSaveDensityPlot.SetPrefix("circular_density_plot")
        ucrSaveDensityPlot.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsMutateFunction = New RFunction
        clsArrangeFunction = New RFunction
        clsDensityFunction = New RFunction
        clsOrderFunction = New RFunction
        clsGgplotFunction = New RFunction
        clsGgplotAesFunction = New RFunction
        clsGeomPointFunction = New RFunction
        clsGeomPointAesFunction = New RFunction
        clsGeomLineFunction = New RFunction
        clsYlimFunction = New RFunction
        clsXlimFunction = New RFunction
        clsCordPolarFunction = New RFunction
        clsMinimumFunction = New RFunction
        clsMaximumFunction = New RFunction
        clsFacetWrapFunction = New RFunction
        clsVarsFunction = New RFunction

        clsPipeOperator = New ROperator
        clsPlusOperator = New ROperator
        clsDolarOperator = New ROperator

        ucrSelectorDataFrame.Reset()
        ucrReceiverVariable.SetMeAsReceiver()
        ucrSaveDensityPlot.Reset()


        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")
        clsMutateFunction.AddParameter("density_col", clsRFunctionParameter:=clsDensityFunction, iPosition:=0)

        clsArrangeFunction.SetPackageName("dplyr")
        clsArrangeFunction.SetRCommand("arrange")
        clsArrangeFunction.AddParameter("order", clsRFunctionParameter:=clsOrderFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsDensityFunction.SetRCommand("density_fun")

        clsOrderFunction.SetRCommand("order")
        clsOrderFunction.AddParameter("density", "density_col", bIncludeArgumentName:=False, iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("mutate", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)
        clsPipeOperator.AddParameter("arrange", clsRFunctionParameter:=clsArrangeFunction, iPosition:=2)
        clsPipeOperator.SetAssignTo("df1")

        clsGgplotFunction.SetPackageName("ggplot2")
        clsGgplotFunction.SetRCommand("ggplot")
        clsGgplotFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsGgplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsGgplotAesFunction, iPosition:=1)

        clsGgplotAesFunction.SetPackageName("ggplot2")
        clsGgplotAesFunction.SetRCommand("aes")
        clsGgplotAesFunction.AddParameter("y", "density_col", iPosition:=1)

        clsPlusOperator.SetOperation("+")
        clsPlusOperator.AddParameter("ggplot", clsRFunctionParameter:=clsGgplotFunction, iPosition:=0)
        clsPlusOperator.AddParameter("geom_point", clsRFunctionParameter:=clsGeomPointFunction, iPosition:=1)
        clsPlusOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLineFunction, iPosition:=2)
        clsPlusOperator.AddParameter("ylim", clsRFunctionParameter:=clsYlimFunction, iPosition:=3)
        clsPlusOperator.AddParameter("xlim", clsRFunctionParameter:=clsXlimFunction, iPosition:=4)
        clsPlusOperator.AddParameter("coord_polar", clsRFunctionParameter:=clsCordPolarFunction, iPosition:=5)
        clsPlusOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        clsGeomPointFunction.SetPackageName("ggplot2")
        clsGeomPointFunction.SetRCommand("geom_point")
        clsGeomPointFunction.AddParameter("mapping", clsRFunctionParameter:=clsGeomPointAesFunction, iPosition:=0)

        clsGeomPointAesFunction.SetPackageName("ggplot2")
        clsGeomPointAesFunction.SetRCommand("aes")
        clsGeomPointAesFunction.AddParameter("y", clsRFunctionParameter:=clsMinimumFunction, iPosition:=1)

        clsGeomLineFunction.SetPackageName("ggplot2")
        clsGeomLineFunction.SetRCommand("geom_line")

        clsYlimFunction.SetPackageName("ggplot2")
        clsYlimFunction.SetRCommand("ylim")
        clsYlimFunction.AddParameter("min", "0", bIncludeArgumentName:=False, iPosition:=0)
        clsYlimFunction.AddParameter("max", clsRFunctionParameter:=clsMaximumFunction, bIncludeArgumentName:=False, iPosition:=1)

        clsXlimFunction.SetPackageName("ggplot2")
        clsXlimFunction.SetRCommand("xlim")
        clsXlimFunction.AddParameter("min", "0", bIncludeArgumentName:=False, iPosition:=0)
        clsXlimFunction.AddParameter("max", "360", bIncludeArgumentName:=False, iPosition:=1)

        clsCordPolarFunction.SetPackageName("ggplot2")
        clsCordPolarFunction.SetRCommand("coord_polar")

        clsMaximumFunction.SetRCommand("max")
        clsMaximumFunction.AddParameter("x", clsROperatorParameter:=clsDolarOperator, bIncludeArgumentName:=False, iPosition:=0)

        clsMinimumFunction.SetRCommand("min")
        clsMinimumFunction.AddParameter("x", "density_col", bIncludeArgumentName:=False, iPosition:=0)

        clsDolarOperator.SetOperation("$")
        clsDolarOperator.bSpaceAroundOperation = False
        clsDolarOperator.AddParameter("df1", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
        clsDolarOperator.AddParameter("density_col", "density_col", iPosition:=1)

        clsFacetWrapFunction.SetPackageName("ggplot2")
        clsFacetWrapFunction.SetRCommand("facet_wrap")
        clsFacetWrapFunction.AddParameter("facets", clsRFunctionParameter:=clsVarsFunction, iPosition:=0)

        clsVarsFunction.SetPackageName("ggplot2")
        clsVarsFunction.SetRCommand("vars")

        ucrBase.clsRsyntax.SetBaseROperator(clsPlusOperator)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsOrderFunction, New RParameter("d1", bNewIncludeArgumentName:=False, iNewPosition:=1), iAdditionalPairNo:=1)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsGeomPointAesFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=2)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsGgplotAesFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=3)

        ucrReceiverVariable.SetRCode(clsDensityFunction, bReset)
        ucrSelectorDataFrame.SetRCode(clsPipeOperator, bReset)
        ucrReceiverFactor.SetRCode(clsVarsFunction, bReset)
        ucrSaveDensityPlot.SetRCode(clsPlusOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrReceiverVariable.IsEmpty AndAlso ucrSaveDensityPlot.IsComplete)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlValueChanged
        If Not ucrReceiverFactor.IsEmpty Then
            clsPlusOperator.AddParameter("facet", clsRFunctionParameter:=clsFacetWrapFunction, iPosition:=6)
        Else
            clsPlusOperator.RemoveParameterByName("facet")
        End If
    End Sub

    Private Sub CoreControlsContentsChanged() Handles ucrReceiverVariable.ControlContentsChanged, ucrSaveDensityPlot.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class