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

Public Class clsCompareTwoOptionsLines
    ' Main functions and operator for ggplot
    Public clsBaseOperator As New ROperator
    Public clsRggplotFunction As New RFunction
    Public clsRaesGlobalFunction As New RFunction
    Public clsRaesLineFunction As New RFunction

    ' Geoms (layers)
    Public clsLineGeom As New RFunction
    Public clsColourParam As New RParameter
    Public clsBoxplotGeom As New RFunction
    Public clsHlineGeom As New RFunction

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

    ' Data unstacking, diff calculation and merge codes
    Public clsFilterMissingOperator As New ROperator
    Public clsFilterMissingFunction As New RFunction
    Public clsLeftJoin As New RFunction
    Public clsFilter As New RFunction
    Public clsFilterInOperator As New ROperator
    Public clsDCast As New RFunction
    Public clsDCastFormula As New ROperator
    Public clsPipeOperator As New ROperator
    Public clsMutate As New RFunction
    Public clsDiffOperator As New ROperator
    Public clsCut As New RFunction
    Public clsCutBreaks As New RFunction
    Public clsCutLabels As New RFunction

    Public strDiff As String = "diff"
    Public strDiffCode As String = "diff_code"

    Public Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRaesGlobalFunction = New RFunction
        clsRaesLineFunction = New RFunction

        clsLineGeom = New RFunction
        clsBoxplotGeom = New RFunction
        clsHlineGeom = New RFunction

        clsRFacetFunction = New RFunction
        clsFacetOp = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

        clsFilterMissingOperator = New ROperator
        clsFilterMissingFunction = New RFunction
        clsLeftJoin = New RFunction
        clsFilter = New RFunction
        clsFilterInOperator = New ROperator
        clsPipeOperator = New ROperator
        clsDCast = New RFunction
        clsDCastFormula = New ROperator
        clsMutate = New RFunction
        clsDiffOperator = New ROperator
        clsCut = New RFunction
        clsCutBreaks = New RFunction
        clsCutLabels = New RFunction

        ' Data manipulation code
        clsFilterMissingOperator.SetOperation("%>%")
        clsFilterMissingOperator.AddParameter("left", clsRFunctionParameter:=clsLeftJoin, iPosition:=0)
        clsFilterMissingOperator.AddParameter("right", clsRFunctionParameter:=clsFilterMissingFunction, iPosition:=1)

        clsFilterMissingFunction.SetPackageName("dplyr")
        clsFilterMissingFunction.SetRCommand("filter")
        clsFilterMissingFunction.AddParameter("0", "!is.na(" & strDiff & ")", bIncludeArgumentName:=False)

        clsLeftJoin.SetPackageName("dplyr")
        clsLeftJoin.SetRCommand("left_join")

        clsLeftJoin.AddParameter("x", clsRFunctionParameter:=clsFilter, iPosition:=0)
        clsLeftJoin.AddParameter("y", clsROperatorParameter:=clsPipeOperator, iPosition:=1)

        clsFilter.SetPackageName("dplyr")
        clsFilter.SetRCommand("filter")
        clsFilter.AddParameter("1", clsROperatorParameter:=clsFilterInOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsFilterInOperator.SetOperation("%in%")

        clsPipeOperator.SetOperation("%>%")

        clsPipeOperator.AddParameter("1", clsRFunctionParameter:=clsDCast, iPosition:=1)
        clsPipeOperator.AddParameter("2", clsRFunctionParameter:=clsMutate, iPosition:=2)

        clsDCast.SetPackageName("reshape2")
        clsDCast.SetRCommand("dcast")
        clsDCast.AddParameter("formula", clsROperatorParameter:=clsDCastFormula, iPosition:=1)
        clsDCast.AddParameter("fun.aggregate", "mean", iPosition:=2)

        clsDCastFormula.SetOperation("~")

        clsMutate.SetPackageName("dplyr")
        clsMutate.SetRCommand("mutate")

        clsMutate.AddParameter(strDiff, clsROperatorParameter:=clsDiffOperator, iPosition:=0)
        clsMutate.AddParameter(strDiffCode, clsRFunctionParameter:=clsCut, iPosition:=1)

        clsDiffOperator.SetOperation("-")

        clsCut.SetRCommand("cut")
        clsCut.AddParameter("x", strDiff, iPosition:=0)
        clsCut.AddParameter("breaks", clsRFunctionParameter:=clsCutBreaks, iPosition:=1)
        clsCut.AddParameter("labels", clsRFunctionParameter:=clsCutLabels, iPosition:=2)

        clsCutBreaks.SetRCommand("c")
        clsCutBreaks.AddParameter("0", "-Inf, -10, 10, Inf", bIncludeArgumentName:=False)

        clsCutLabels.SetRCommand("c")
        clsCutLabels.AddParameter("0", Chr(34) & "Decrease" & Chr(34) & ", " & Chr(34) & "Same" & Chr(34) & ", " & Chr(34) & "Increase" & Chr(34), bIncludeArgumentName:=False)

        ' ggplot code
        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsLineGeom, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("data", clsROperatorParameter:=clsFilterMissingOperator, iPosition:=0)
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesGlobalFunction, iPosition:=1)

        clsRaesGlobalFunction.SetPackageName("ggplot2")
        clsRaesGlobalFunction.SetRCommand("aes")

        clsLineGeom.SetPackageName("ggplot2")
        clsLineGeom.SetRCommand("geom_line")
        clsLineGeom.AddParameter("mapping", clsRFunctionParameter:=clsRaesLineFunction, iPosition:=0)

        clsRaesLineFunction.SetPackageName("ggplot2")
        clsRaesLineFunction.SetRCommand("aes")
        clsRaesLineFunction.AddParameter(clsColourParam)

        clsBoxplotGeom.SetPackageName("ggplot2")
        clsBoxplotGeom.SetRCommand("geom_boxplot")
        clsBoxplotGeom.AddParameter("outlier.colour", Chr(34) & "red" & Chr(34), iPosition:=1)
        clsBoxplotGeom.AddParameter("alpha", "0.75")

        clsHlineGeom.SetPackageName("ggplot2")
        clsHlineGeom.SetRCommand("geom_hline")
        clsHlineGeom.AddParameter("yintercept", 0, iPosition:=2)

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

    Public Sub SetRCodeforControls(ucrSelectorPlot As ucrSelectorByDataFrameAddRemove, ucrReceiverOption As ucrReceiverSingle, ucrReceiverID As ucrReceiverSingle, ucrReceiverMeasurement As ucrReceiverSingle, ucrInputFactorOption1 As ucrInputFactorLevels, ucrInputFactorOption2 As ucrInputFactorLevels, ucrChkColourByDifference As ucrCheck, ucrChkIncludeBoxplot As ucrCheck, ucrNudTransparency As ucrNud, ucrChkBoxplotOnlyComplete As ucrCheck, ucrChkHline As ucrCheck, ucrInputHlineValue As ucrInputTextBox, ucrSavePlot As ucrSave, ucrReceiverContext1 As ucrReceiverSingle, ucrReceiverContext2 As ucrReceiverSingle, ucrReceiverContext3 As ucrReceiverSingle, ucrChkSmoothLine As ucrCheck, ucrChkIncludeMeanLine As ucrCheck, bResetControls As Boolean)
        ucrSelectorPlot.AddAdditionalCodeParameterPair(clsPipeOperator, ucrSelectorPlot.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverOption.AddAdditionalCodeParameterPair(clsRaesGlobalFunction, New RParameter("x", iNewPosition:=0), iAdditionalPairNo:=2)
        ucrReceiverOption.AddAdditionalCodeParameterPair(clsFilterInOperator, New RParameter("0", iNewPosition:=0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=3)
        ucrReceiverID.AddAdditionalCodeParameterPair(clsRaesLineFunction, New RParameter("group", iNewPosition:=0), iAdditionalPairNo:=2)

        ucrReceiverMeasurement.SetRCode(clsRaesGlobalFunction, bResetControls)
        ucrReceiverOption.SetRCode(clsDCastFormula, bResetControls)
        'Needs to be done after linked receiver is set
        ucrInputFactorOption1.SetRCode(clsDiffOperator, bResetControls)
        ucrInputFactorOption2.SetRCode(clsDiffOperator, bResetControls)
        ucrReceiverID.SetRCode(clsDCastFormula, bResetControls)
        ucrSelectorPlot.SetRCode(clsFilter, bResetControls)
        ucrChkColourByDifference.SetRCode(clsRaesLineFunction, bResetControls)
        ucrChkIncludeBoxplot.SetRCode(clsBaseOperator, bResetControls)
        ucrNudTransparency.SetRCode(clsBoxplotGeom, bResetControls)
        ucrChkBoxplotOnlyComplete.SetRCode(clsFilterMissingOperator, bResetControls)
        ucrChkHline.SetRCode(clsBaseOperator, bResetControls)
        ucrInputHlineValue.SetRCode(clsHlineGeom, bResetControls)
        ucrSavePlot.SetRCode(clsBaseOperator, bResetControls)
    End Sub
End Class
