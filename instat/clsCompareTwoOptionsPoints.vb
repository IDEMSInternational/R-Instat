Public Class clsCompareTwoOptionsPoints
    ' R- Instat
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

    ' Main functions and operator for ggplot
    Public clsBaseOperator As New ROperator
    Public clsRggplotFunction As New RFunction
    Public clsRaesGlobalFunction As New RFunction

    ' Geoms (layers)
    Public clsPointGeom As New RFunction
    Public clsSmoothGeom As New RFunction
    Public clsAblineGeom As New RFunction

    ' Not yet implemented
    ' Additional functions for plot subdialog
    'Public clsLabsFunction As New RFunction
    'Public clsXlabsFunction As New RFunction
    'Public clsYlabFunction As New RFunction
    'Public clsXScaleContinuousFunction As New RFunction
    'Public clsYScaleContinuousFunction As New RFunction
    'Public clsThemeFunction As New RFunction
    'Public dctThemeFunctions As Dictionary(Of String, RFunction)

    ' Facet functions
    Public clsRFacetFunction As New RFunction
    Public clsFacetOp As New ROperator
    Public clsFacetRowOp As New ROperator
    Public clsFacetColOp As New ROperator

    ' Data unstacking and calculations
    Public clsDCast As New RFunction
    Public clsDCastFormula As New ROperator
    Public clsDCastIDFormula As New ROperator
    Public clsMean As New RFunction

    Public Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRaesGlobalFunction = New RFunction
        clsPointGeom = New RFunction
        clsSmoothGeom = New RFunction
        clsAblineGeom = New RFunction

        clsRFacetFunction = New RFunction
        clsFacetOp = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

        clsDCast = New RFunction
        clsDCastFormula = New ROperator
        clsDCastIDFormula = New ROperator
        clsMean = New RFunction

        ' Data manipulation code
        clsDCast.SetPackageName("reshape2")
        clsDCast.SetRCommand("dcast")
        clsDCast.AddParameter("formula", clsROperatorParameter:=clsDCastFormula, iPosition:=1)
        clsDCast.AddParameter("fun.aggregate", "mean", iPosition:=2)

        clsDCastFormula.SetOperation("~")
        clsDCastFormula.AddParameter("left", clsROperatorParameter:=clsDCastIDFormula, iPosition:=0)

        clsDCastIDFormula.SetOperation("+")

        ' ggplot code
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsPointGeom, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=clsDCast, iPosition:=0)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesGlobalFunction, iPosition:=1)

        clsRaesGlobalFunction.SetPackageName("ggplot2")
        clsRaesGlobalFunction.SetRCommand("aes")

        clsPointGeom.SetPackageName("ggplot2")
        clsPointGeom.SetRCommand("geom_point")

        clsSmoothGeom.SetPackageName("ggplot2")
        clsSmoothGeom.SetRCommand("geom_smooth")
        clsSmoothGeom.AddParameter("se", "FALSE", iPosition:=6)
        clsSmoothGeom.AddParameter("method", Chr(34) & "loes" & Chr(34), iPosition:=4)
        clsSmoothGeom.AddParameter("alpha", "0.5", iPosition:=10)

        clsAblineGeom.SetPackageName("ggplot2")
        clsAblineGeom.SetRCommand("geom_abline")
        clsAblineGeom.AddParameter("slope", "1", iPosition:=2)
        clsAblineGeom.AddParameter("intercept", clsRFunctionParameter:=clsMean, iPosition:=3)
        clsAblineGeom.AddParameter("col", Chr(34) & "red" & Chr(34), iPosition:=10)

        clsMean.SetRCommand("mean")

        clsRFacetFunction.SetPackageName("ggplot2")
        clsRFacetFunction.SetRCommand("facet_grid")
        clsRFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOp, iPosition:=0)

        clsFacetOp.SetOperation("~")
        clsFacetOp.bForceIncludeOperation = True
        clsFacetOp.bBrackets = False

        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
    End Sub

    Public Sub SetRCodeforControls(ucrSelectorPlot As ucrSelectorByDataFrameAddRemove, ucrReceiverOption As ucrReceiverSingle, ucrReceiverID As ucrReceiverSingle, ucrReceiverMeasurement As ucrReceiverSingle, ucrInputFactorOption1 As ucrInputFactorLevels, ucrInputFactorOption2 As ucrInputFactorLevels, ucrChkColourByDifference As ucrCheck, ucrChkIncludeBoxplot As ucrCheck, ucrNudTransparency As ucrNud, ucrChkBoxplotOnlyComplete As ucrCheck, ucrChkHline As ucrCheck, ucrInputHlineValue As ucrInputTextBox, bResetControls As Boolean)
        ucrSelectorPlot.AddAdditionalCodeParameterPair(clsDCast, ucrSelectorPlot.GetParameter(), iAdditionalPairNo:=2)
        ucrReceiverOption.AddAdditionalCodeParameterPair(clsDCastFormula, New RParameter("right", iNewPosition:=1), iAdditionalPairNo:=2)
        ucrReceiverID.AddAdditionalCodeParameterPair(clsDCastIDFormula, New RParameter("left", iNewPosition:=0), iAdditionalPairNo:=2)

        ucrReceiverMeasurement.SetRCode(clsRaesGlobalFunction, bResetControls)
        ucrReceiverOption.SetRCode(clsDCastFormula, bResetControls)
        'Needs to be done after linked receiver is set
        ucrInputFactorOption1.SetRCode(clsDiffOperator, bResetControls)
        ucrInputFactorOption2.SetRCode(clsDiffOperator, bResetControls)
        ucrReceiverID.SetRCode(clsDCastFormula, bResetControls)
        ucrChkColourByDifference.SetRCode(clsRaesLineFunction, bResetControls)
        ucrChkIncludeBoxplot.SetRCode(clsBaseOperator, bResetControls)
        ucrNudTransparency.SetRCode(clsBoxplotGeom, bResetControls)
        ucrChkBoxplotOnlyComplete.SetRCode(clsFilterMissingOperator, bResetControls)
        ucrChkHline.SetRCode(clsBaseOperator, bResetControls)
        ucrInputHlineValue.SetRCode(clsHlineGeom, bResetControls)
    End Sub
End Class
