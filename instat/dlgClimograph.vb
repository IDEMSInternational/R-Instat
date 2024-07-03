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

Imports instat.Translations

Public Class dlgClimograph
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsGgwalterliethFunction, clsDummyFunction As RFunction
    Private clsBaseOperator As New ROperator
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strNone As String = "None"
    Private ReadOnly strFacetWrap1 As String = "Facet Wrap"
    Private ReadOnly strFacetRow1 As String = "Facet Row"
    Private ReadOnly strFacetCol1 As String = "Facet Column"
    Private ReadOnly strNone1 As String = "None"
    Private clsFacetFunction As New RFunction
    Private clsGroupByFunction As New RFunction
    Private clsGeomBarFunction As New RFunction
    Private clsGeomLineFunction As New RFunction
    Private clsGeomLineStarFunction As New RFunction
    Private clsGeomLineStar1Function As New RFunction
    Private clsGeomLineFunction1 As New RFunction
    Private clsRggplotFunction As New RFunction
    Private clsBarAesFunction As New RFunction
    Private clsAesLineFunction As New RFunction
    Private clsAesLineStarFunction As New RFunction
    Private clsAesLine1Function As New RFunction
    Private clsAesLineStar1Function As New RFunction
    Private clsFacetFunction1 As New RFunction
    Private clsGroupByFunction1 As New RFunction
    Private bResetSubdialog As Boolean = True
    Private clsCoordPolarFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsAnnotateFunction As New RFunction
    Private clsCoordPolarStartOperator As New ROperator
    Private clsXScaleDateFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsScaleFillViridisFunction As New RFunction
    Private clsScaleColourViridisFunction As New RFunction
    Private clsScalecolouridentityFunction As New RFunction
    Private clsLabsFunction As New RFunction
    Private clsLabFunction As New RFunction
    Private clsXlabFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsSecondaryAxisFunction As New RFunction
    Private clsSecondaryAxis1Function As New RFunction
    Private clsSecondaryAxis2Function As New RFunction
    Private clsLenthFunction As New RFunction
    Private clsUniqueFunction As New RFunction
    Private clsSemicommaOperator As New ROperator
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsXScalecontinuousFunction As New RFunction
    Private clsXScalediscreteFunction As New RFunction
    Private clsScaleycontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsGeomRibbonFunction As New RFunction
    Private clsGeomRibbon1Function As New RFunction
    Private clsGeomTileFunction As New RFunction
    Private clsAesGeomRibbonFunction As New RFunction
    Private clsAesGeomRibbon1Function As New RFunction
    Private clsGeomTextBarFunction As New RFunction
    Private clsGeomTextTmaxFunction As New RFunction
    Private clsGeomTextTminFunction As New RFunction
    Private clsGeomTextTmaxStarFunction As New RFunction
    Private clsGeomTextTminStarFunction As New RFunction
    Private clsRoundBarFunction As New RFunction
    Private clsRoundTmaxFunction As New RFunction
    Private clsRoundTminFunction As New RFunction
    Private clsAesGeomTextBarFunction As New RFunction
    Private clsAesGeomTextTmaxFunction As New RFunction
    Private clsAesGeomTextStarTmaxFunction As New RFunction
    Private clsAesGeomTextTminFunction As New RFunction
    Private clsAesGeomTextStarTminFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsMaxFunction As New RFunction
    Private clsMax1Function As New RFunction
    Private clsVectorFunction As New RFunction
    Private clsGetObjectDataFunction As New RFunction
    Private clsStarOperator As New ROperator
    Private clsStar1Operator As New ROperator
    Private clsDivideOperator As New ROperator
    Private clsDivide1Operator As ROperator
    Private clsFacetVariablesOperator As New ROperator
    Private clsFacetRowOp1 As New ROperator
    Private clsFacetColOp1 As New ROperator
    Private clsPipeOperator1 As New ROperator
    Private clsFacetOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False
    Private bUpdateComboOptions1 As Boolean = True
    Private bUpdatingParameters1 As Boolean = False
    Private strScale As String = "Scale_Factor"

    Private Sub dlgClimograph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 432

        ucrSelectorClimograph.SetParameter(New RParameter("data", 0, bNewIncludeArgumentName:=False))
        ucrSelectorClimograph.SetParameterIsrfunction()

        ucrPnlClimograph.AddRadioButton(rdoClimograph)
        ucrPnlClimograph.AddRadioButton(rdoWalterLieth)
        ucrPnlClimograph.AddParameterValuesCondition(rdoWalterLieth, "checked", "WalterLieth")
        ucrPnlClimograph.AddParameterValuesCondition(rdoClimograph, "checked", "Climograph")

        ucrReceiverMonth.SetParameter(New RParameter("month", 1))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorClimograph
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        ucrReceiverMonthC.SetParameter(New RParameter("x", 2))
        ucrReceiverMonthC.SetParameterIsRFunction()
        ucrReceiverMonthC.Selector = ucrSelectorClimograph
        ucrReceiverMonthC.bWithQuotes = False
        ucrReceiverMonthC.SetClimaticType("month")
        ucrReceiverMonthC.bAutoFill = True
        ucrReceiverMonthC.strSelectorHeading = "Month Variables"
        ucrReceiverMonthC.SetLinkedDisplayControl(lblMonthC)

        ucrReceiverRain.SetParameter(New RParameter("p_mes", 3))
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.Selector = ucrSelectorClimograph
        ucrReceiverRain.SetClimaticType("rain")
        ucrReceiverRain.bAutoFill = True
        ucrReceiverRain.strSelectorHeading = "Rain Variables"
        ucrReceiverRain.SetLinkedDisplayControl(lblRain)

        ucrReceiverRainC.SetParameter(New RParameter("y", 1))
        ucrReceiverRainC.SetParameterIsRFunction()
        ucrReceiverRainC.Selector = ucrSelectorClimograph
        ucrReceiverRainC.bWithQuotes = False
        ucrReceiverRainC.SetClimaticType("rain")
        ucrReceiverRainC.bAutoFill = True
        ucrReceiverRainC.strSelectorHeading = "Rain Variables"
        ucrReceiverRainC.SetLinkedDisplayControl(lblRainC)

        ucrReceiverMaxtem.SetParameter(New RParameter("tm_max", 4))
        ucrReceiverMaxtem.SetParameterIsString()
        ucrReceiverMaxtem.Selector = ucrSelectorClimograph
        ucrReceiverMaxtem.SetClimaticType("temp_max")
        ucrReceiverMaxtem.bAutoFill = True
        ucrReceiverMaxtem.strSelectorHeading = "Variables"
        ucrReceiverMaxtem.SetLinkedDisplayControl(lblMaxtem)

        ucrReceiverMintemp.SetParameter(New RParameter("tm_min", 5))
        ucrReceiverMintemp.SetParameterIsString()
        ucrReceiverMintemp.Selector = ucrSelectorClimograph
        ucrReceiverMintemp.SetClimaticType("temp_min")
        ucrReceiverMintemp.bAutoFill = True
        ucrReceiverMintemp.strSelectorHeading = "Variables"
        ucrReceiverMintemp.SetLinkedDisplayControl(lblMintem)

        ucrReceiverElement1.SetParameter(New RParameter("y", 4, False))
        ucrReceiverElement1.SetParameterIsRFunction()
        ucrReceiverElement1.Selector = ucrSelectorClimograph
        ucrReceiverElement1.bWithQuotes = False
        ucrReceiverElement1.SetClimaticType("temp_max")
        ucrReceiverElement1.bAutoFill = True
        ucrReceiverElement1.strSelectorHeading = "Variables"
        ucrReceiverElement1.SetLinkedDisplayControl(lblElement1)

        ucrReceiverElement2.SetParameter(New RParameter("x", 5, False))
        ucrReceiverElement2.SetParameterIsRFunction()
        ucrReceiverElement2.Selector = ucrSelectorClimograph
        ucrReceiverElement2.bWithQuotes = False
        ucrReceiverElement2.SetClimaticType("temp_min")
        ucrReceiverElement2.bAutoFill = True
        ucrReceiverElement2.strSelectorHeading = "Variables"
        ucrReceiverElement2.SetLinkedDisplayControl(lblElement2)

        ucr1stFactorReceiver.SetParameter(New RParameter("var1"))
        ucr1stFactorReceiver.Selector = ucrSelectorClimograph
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrReceiverFacet.SetParameter(New RParameter("var1"))
        ucrReceiverFacet.Selector = ucrSelectorClimograph
        ucrReceiverFacet.SetClimaticType("year")
        ucrReceiverFacet.bAutoFill = True
        ucrReceiverFacet.bWithQuotes = False
        ucrReceiverFacet.SetParameterIsString()
        ucrReceiverFacet.SetValuesToIgnore({"."})

        ucrInputFacet.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputFacet.SetDropDownStyleAsNonEditable()

        ucrReceiverAbsolute.SetParameter(New RParameter("ta_min", 6))
        ucrReceiverAbsolute.SetParameterIsString()
        ucrReceiverAbsolute.Selector = ucrSelectorClimograph
        ucrReceiverAbsolute.strSelectorHeading = "Variables"
        ucrReceiverAbsolute.SetLinkedDisplayControl(lblAbsolute)

        ucrPnlClimograph.AddToLinkedControls({ucr1stFactorReceiver, ucrReceiverAbsolute, ucrReceiverMintemp, ucrReceiverMonth, ucrReceiverMaxtem, ucrReceiverRain, ucrInputStation}, {rdoWalterLieth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlClimograph.AddToLinkedControls({ucrReceiverFacet, ucrChkTile, ucrChkLegend, ucrReceiverElement2, ucrReceiverElement1, ucrReceiverMonthC, ucrReceiverRainC, ucrInputFacet, ucrChkColourIdntity, ucrChkRibbon, ucrChkText}, {rdoClimograph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkColourIdntity.SetText("Legend for Lines")
        ucrChkColourIdntity.AddParameterValuesCondition(True, "checked", "True")
        ucrChkColourIdntity.AddParameterValuesCondition(False, "checked", "False")
        ucrChkColourIdntity.AddToLinkedControls({ucrInputName, ucrInputLabels}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputName.SetValidationTypeAsList()
        ucrInputName.SetLinkedDisplayControl(lblName)
        ucrInputLabels.SetValidationTypeAsList()
        ucrInputLabels.SetLinkedDisplayControl(lblLabel)

        ucrChkLegend.SetText("Legend:")
        ucrChkLegend.AddToLinkedControls({ucrInputLegendPosition}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegend.AddParameterPresentCondition(True, "legend.position")
        ucrChkLegend.AddParameterPresentCondition(False, "legend.position", False)

        ucrChkRibbon.SetText("Add Ribbon")
        ucrChkRibbon.AddParameterValuesCondition(True, "checked", "True")
        ucrChkRibbon.AddParameterValuesCondition(False, "checked", "False")

        ucrChkTile.SetText("Add Tile")
        ucrChkTile.AddParameterValuesCondition(True, "checked", "True")
        ucrChkTile.AddParameterValuesCondition(False, "checked", "False")

        ucrChkText.SetText("Add Label")
        ucrChkText.AddParameterValuesCondition(True, "checked", "True")
        ucrChkText.AddParameterValuesCondition(False, "checked", "False")

        ucrSave.SetPrefix("wl_graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Store Graph")
        ucrSave.SetDataFrameSelector(ucrSelectorClimograph.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsGgwalterliethFunction = New RFunction
        clsBaseOperator = New ROperator
        clsDummyFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsPipeOperator = New ROperator
        clsFacetFunction = New RFunction
        clsFacetOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator
        clsGeomRibbonFunction = New RFunction
        clsGeomRibbon1Function = New RFunction
        clsAesGeomRibbonFunction = New RFunction
        clsAesGeomRibbon1Function = New RFunction
        clsGeomBarFunction = New RFunction
        clsGeomLineFunction = New RFunction
        clsGeomLineFunction1 = New RFunction
        clsGeomLineStarFunction = New RFunction
        clsGeomLineStar1Function = New RFunction
        clsAesLineFunction = New RFunction
        clsAesLineStarFunction = New RFunction
        clsAesLine1Function = New RFunction
        clsAesLineStar1Function = New RFunction
        clsRggplotFunction = New RFunction
        clsBarAesFunction = New RFunction
        clsFacetFunction1 = New RFunction
        clsScalecolouridentityFunction = New RFunction
        clsSecondaryAxisFunction = New RFunction
        clsSecondaryAxis1Function = New RFunction
        clsSecondaryAxis2Function = New RFunction
        clsLenthFunction = New RFunction
        clsUniqueFunction = New RFunction
        clsGeomTextBarFunction = New RFunction
        clsGeomTextTmaxFunction = New RFunction
        clsGeomTextTminFunction = New RFunction
        clsAesGeomTextBarFunction = New RFunction
        clsAesGeomTextTmaxFunction = New RFunction
        clsAesGeomTextTminFunction = New RFunction
        clsGeomTextTmaxStarFunction = New RFunction
        clsGeomTextTminStarFunction = New RFunction
        clsAesGeomTextStarTmaxFunction = New RFunction
        clsAesGeomTextStarTminFunction = New RFunction
        clsXScalediscreteFunction = New RFunction
        clsRoundBarFunction = New RFunction
        clsRoundTmaxFunction = New RFunction
        clsRoundTminFunction = New RFunction
        clsGeomTileFunction = New RFunction
        clsSemicommaOperator = New ROperator
        clsStarOperator = New ROperator
        clsStar1Operator = New ROperator
        clsDivideOperator = New ROperator
        clsDivide1Operator = New ROperator
        clsFacetVariablesOperator = New ROperator
        clsFacetRowOp1 = New ROperator
        clsFacetColOp1 = New ROperator
        clsPipeOperator1 = New ROperator
        clsGroupByFunction1 = New RFunction
        clsMaxFunction = New RFunction
        clsMax1Function = New RFunction
        clsVectorFunction = New RFunction
        clsScaleycontinuousFunction = New RFunction
        clsLabFunction = New RFunction
        clsGetObjectDataFunction = New RFunction

        ucrSelectorClimograph.Reset()
        ucrSelectorClimograph.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrInputFacet.SetName(strFacetWrap)
        ucrInputFacet.bUpdateRCodeFromControl = True

        clsDummyFunction.AddParameter("checked", "Climograph", iPosition:=0)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBarFunction, iPosition:=2)

        clsFacetFunction1.SetPackageName("ggplot2")
        clsFacetRowOp1.SetOperation("+")
        clsFacetRowOp1.bBrackets = False
        clsFacetColOp1.SetOperation("+")
        clsFacetColOp1.bBrackets = False
        clsFacetVariablesOperator.SetOperation("~")
        clsFacetVariablesOperator.bForceIncludeOperation = True
        clsFacetVariablesOperator.bBrackets = False
        clsFacetFunction1.AddParameter("facets", clsROperatorParameter:=clsFacetVariablesOperator, iPosition:=0)

        clsPipeOperator1.SetOperation("%>%")
        SetPipeAssignTo1()

        clsGroupByFunction1.SetPackageName("dplyr")
        clsGroupByFunction1.SetRCommand("group_by")

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGgwalterliethFunction.SetRCommand("ggwalter_lieth")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True
        clsFacetOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsBarAesFunction, iPosition:=1)

        clsBarAesFunction.SetRCommand("aes")

        clsGeomBarFunction.SetRCommand("geom_bar")
        clsGeomBarFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34), iPosition:=1)
        clsGeomBarFunction.AddParameter("alpha", "0.5", iPosition:=2)

        clsGeomLineFunction.SetRCommand("geom_line")
        clsGeomLineFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesLineFunction, iPosition:=0)

        clsGeomLineFunction1.SetRCommand("geom_line")
        clsGeomLineFunction1.AddParameter("mapping", clsRFunctionParameter:=clsAesLine1Function, iPosition:=0)

        clsGeomLineStarFunction.SetRCommand("geom_line")
        clsGeomLineStarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesLineStarFunction, iPosition:=0)

        clsGeomLineStar1Function.SetRCommand("geom_line")
        clsGeomLineStar1Function.AddParameter("mapping", clsRFunctionParameter:=clsAesLineStar1Function, iPosition:=0)

        clsAesLineFunction.SetRCommand("aes")
        clsAesLineFunction.AddParameter("group", "1", iPosition:=1)

        clsAesLineStarFunction.SetRCommand("aes")
        clsAesLineStarFunction.AddParameter("y", clsROperatorParameter:=clsStarOperator, iPosition:=0)
        clsAesLineStarFunction.AddParameter("group", "1", iPosition:=1)

        clsAesLine1Function.SetRCommand("aes")
        clsAesLine1Function.AddParameter("group", "1", iPosition:=1)

        clsAesLineStar1Function.SetRCommand("aes")
        clsAesLineStar1Function.AddParameter("group", "1", iPosition:=1)
        clsAesLineStar1Function.AddParameter("y", clsROperatorParameter:=clsStar1Operator, iPosition:=0)

        clsSecondaryAxisFunction.SetRCommand("sec_axis")
        clsSecondaryAxisFunction.AddParameter("x", "~.*0.0393701", iPosition:=0, bIncludeArgumentName:=False)
        clsSecondaryAxisFunction.AddParameter("name", Chr(34) & "Rainfall (inches)" & Chr(34), iPosition:=1)

        clsSecondaryAxis1Function.SetRCommand("sec_axis")
        clsSecondaryAxis1Function.AddParameter("x", "~.*32", iPosition:=0, bIncludeArgumentName:=False)
        clsSecondaryAxis1Function.AddParameter("name", Chr(34) & "Temperature (F)" & Chr(34), iPosition:=1)

        clsXScalediscreteFunction.SetRCommand("scale_x_discrete")
        clsXScalediscreteFunction.AddParameter("name", Chr(34) & "Month" & Chr(34), iPosition:=0)

        clsSemicommaOperator.SetOperation(":")
        clsSemicommaOperator.AddParameter("left", "1", iPosition:=0, bIncludeArgumentName:=False)
        clsSemicommaOperator.AddParameter("right", clsRFunctionParameter:=clsLenthFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsLenthFunction.SetRCommand("length")
        clsLenthFunction.AddParameter("x", clsRFunctionParameter:=clsUniqueFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsUniqueFunction.SetRCommand("unique")

        clsScalecolouridentityFunction.SetRCommand("scale_colour_identity")
        clsScalecolouridentityFunction.AddParameter("guide", Chr(34) & "legend" & Chr(34), iPosition:=1)

        clsGeomRibbonFunction.SetRCommand("geom_ribbon")
        clsGeomRibbonFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomRibbonFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomRibbonFunction.AddParameter("fill", Chr(34) & "#000000" & Chr(34), iPosition:=1)
        clsGeomRibbonFunction.AddParameter("alpha", "0.2", iPosition:=2)

        clsAesGeomRibbonFunction.SetRCommand("aes")
        clsAesGeomRibbonFunction.AddParameter("group", "1", iPosition:=2)

        clsGeomTileFunction.SetRCommand("geom_tile")
        clsGeomTileFunction.AddParameter("alpha", "0.5", iPosition:=0)

        clsGeomRibbon1Function.SetRCommand("geom_ribbon")
        clsGeomRibbon1Function.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomRibbon1Function, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomRibbon1Function.AddParameter("fill", Chr(34) & "#000000" & Chr(34), iPosition:=1)
        clsGeomRibbon1Function.AddParameter("alpha", "0.2", iPosition:=2)

        clsAesGeomRibbon1Function.SetRCommand("aes")
        clsAesGeomRibbon1Function.AddParameter("ymin", clsROperatorParameter:=clsStar1Operator, iPosition:=0)
        clsAesGeomRibbon1Function.AddParameter("ymax", clsROperatorParameter:=clsStarOperator, iPosition:=1)
        clsAesGeomRibbon1Function.AddParameter("group", "1", iPosition:=2)

        clsGeomTextBarFunction.SetRCommand("geom_text")
        clsGeomTextBarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextBarFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextBarFunction.AddParameter("vjust", "-0.5", iPosition:=1)
        clsGeomTextBarFunction.AddParameter("size", "3", iPosition:=2)

        clsAesGeomTextBarFunction.SetRCommand("aes")
        clsAesGeomTextBarFunction.AddParameter("label", clsRFunctionParameter:=clsRoundBarFunction, iPosition:=1)

        clsRoundBarFunction.SetRCommand("round")
        clsRoundBarFunction.AddParameter("x", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsGeomTextTmaxFunction.SetRCommand("geom_text")
        clsGeomTextTmaxFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextTmaxFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextTmaxFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34), iPosition:=1)
        clsGeomTextTmaxFunction.AddParameter("vjust", "-0.5", iPosition:=2)
        clsGeomTextTmaxFunction.AddParameter("size", "3", iPosition:=3)
        clsGeomTextTmaxFunction.AddParameter("Show.legend", "FALSE", iPosition:=4)

        clsAesGeomTextTmaxFunction.SetRCommand("aes")
        clsAesGeomTextTmaxFunction.AddParameter("label", clsRFunctionParameter:=clsRoundTmaxFunction, iPosition:=1)

        clsGeomTextTmaxStarFunction.SetRCommand("geom_text")
        clsGeomTextTmaxStarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextStarTmaxFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextTmaxStarFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34), iPosition:=1)
        clsGeomTextTmaxStarFunction.AddParameter("vjust", "-0.5", iPosition:=2)
        clsGeomTextTmaxStarFunction.AddParameter("size", "3", iPosition:=3)
        clsGeomTextTmaxStarFunction.AddParameter("Show.legend", "FALSE", iPosition:=4)

        clsAesGeomTextStarTmaxFunction.SetRCommand("aes")
        clsAesGeomTextStarTmaxFunction.AddParameter("y", clsROperatorParameter:=clsStarOperator, iPosition:=0)
        clsAesGeomTextStarTmaxFunction.AddParameter("label", clsRFunctionParameter:=clsRoundTmaxFunction, iPosition:=1)

        clsRoundTmaxFunction.SetRCommand("round")
        clsRoundTmaxFunction.AddParameter("x", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsGeomTextTminFunction.SetRCommand("geom_text")
        clsGeomTextTminFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextTminFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextTminFunction.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=1)
        clsGeomTextTminFunction.AddParameter("vjust", "1.5", iPosition:=2)
        clsGeomTextTminFunction.AddParameter("size", "3", iPosition:=3)
        clsGeomTextTminFunction.AddParameter("Show.legend", "FALSE", iPosition:=4)

        clsAesGeomTextTminFunction.SetRCommand("aes")
        clsAesGeomTextTminFunction.AddParameter("label", clsRFunctionParameter:=clsRoundTminFunction, iPosition:=1)

        clsGeomTextTminStarFunction.SetRCommand("geom_text")
        clsGeomTextTminStarFunction.AddParameter("mapping", clsRFunctionParameter:=clsAesGeomTextStarTminFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsGeomTextTminStarFunction.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=1)
        clsGeomTextTminStarFunction.AddParameter("vjust", "1.5", iPosition:=2)
        clsGeomTextTminStarFunction.AddParameter("size", "3", iPosition:=3)
        clsGeomTextTminStarFunction.AddParameter("Show.legend", "FALSE", iPosition:=4)

        clsAesGeomTextStarTminFunction.SetRCommand("aes")
        clsAesGeomTextStarTminFunction.AddParameter("y", clsROperatorParameter:=clsStar1Operator, iPosition:=0)
        clsAesGeomTextStarTminFunction.AddParameter("label", clsRFunctionParameter:=clsRoundTminFunction, iPosition:=1)

        clsRoundTminFunction.SetRCommand("round")
        clsRoundTminFunction.AddParameter("x", "1", iPosition:=1, bIncludeArgumentName:=False)

        clsSecondaryAxis2Function.SetRCommand("sec_axis")
        clsSecondaryAxis2Function.AddParameter("x", clsROperatorParameter:=clsDivide1Operator, iPosition:=0, bIncludeArgumentName:=False)
        clsSecondaryAxis2Function.AddParameter("name", Chr(34) & "Temperature (c)" & Chr(34), iPosition:=1)

        clsDivide1Operator.SetOperation("/")
        clsDivide1Operator.AddParameter("left", "~ .", iPosition:=0, bIncludeArgumentName:=False)
        clsDivide1Operator.AddParameter("right", clsROperatorParameter:=clsDivideOperator, iPosition:=1, bIncludeArgumentName:=False)

        clsStarOperator.SetOperation("*")
        clsStarOperator.AddParameter("right", strScale, iPosition:=1, bIncludeArgumentName:=False)

        clsStar1Operator.SetOperation("*")
        clsStar1Operator.AddParameter("right", strScale, iPosition:=1, bIncludeArgumentName:=False)

        clsDivideOperator.SetOperation("/")
        clsDivideOperator.AddParameter("left", clsRFunctionParameter:=clsMaxFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsDivideOperator.AddParameter("right", clsRFunctionParameter:=clsMax1Function, iPosition:=1, bIncludeArgumentName:=False)
        clsDivideOperator.SetAssignTo(strScale,)

        clsMaxFunction.SetRCommand("max")

        clsMax1Function.SetRCommand("max")
        clsMax1Function.AddParameter("x", clsRFunctionParameter:=clsVectorFunction, iPosition:=0, bIncludeArgumentName:=False)

        clsVectorFunction.SetRCommand("c")

        clsScaleycontinuousFunction.SetRCommand("scale_y_continuous")

        clsLabFunction.SetRCommand("labs")

        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXlabFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsCoordPolarStartOperator = GgplotDefaults.clsCoordPolarStartOperator.Clone()
        clsCoordPolarFunction = GgplotDefaults.clsCoordPolarFunction.Clone()
        clsXScaleDateFunction = GgplotDefaults.clsXScaleDateFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsScaleFillViridisFunction = GgplotDefaults.clsScaleFillViridisFunction
        clsScaleColourViridisFunction = GgplotDefaults.clsScaleColorViridisFunction
        clsAnnotateFunction = GgplotDefaults.clsAnnotateFunction

        clsGetObjectDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetObjectDataFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectDataFunction, iPosition:=0)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrSelectorClimograph.AddAdditionalCodeParameterPair(clsGgwalterliethFunction, New RParameter("data", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)
        ucrReceiverMonthC.AddAdditionalCodeParameterPair(clsUniqueFunction, New RParameter("x", 0, False), iAdditionalPairNo:=1)

        ucrReceiverRainC.SetRCode(clsMaxFunction, bReset)
        ucrSelectorClimograph.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverMonth.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverRain.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMintemp.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMaxtem.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverAbsolute.SetRCode(clsGgwalterliethFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkLegend.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        If bReset Then
            ucrReceiverElement2.SetRCode(clsVectorFunction, bReset)
            ucrReceiverElement1.SetRCode(clsVectorFunction, bReset)
            ucrReceiverMonthC.SetRCode(clsBarAesFunction, bReset)
            ucrPnlClimograph.SetRCode(clsDummyFunction, bReset)
            ucrChkColourIdntity.SetRCode(clsScalecolouridentityFunction, bReset)
            ucrChkRibbon.SetRCode(clsGeomRibbonFunction, bReset)
            ucrChkTile.SetRCode(clsGeomTileFunction, bReset)
            ucrInputName.SetRCode(clsScalecolouridentityFunction, bReset)
            ucrInputLabels.SetRCode(clsScalecolouridentityFunction, bReset)
            ucrChkText.SetRCode(clsBaseOperator, bReset)
        End If

    End Sub

    Private Sub TestOKEnabled()
        If rdoClimograph.Checked AndAlso Not ucrReceiverMonthC.IsEmpty AndAlso ((Not ucrReceiverElement1.IsEmpty OrElse Not ucrReceiverElement2.IsEmpty OrElse Not ucrReceiverRainC.IsEmpty) OrElse Not ucrSave.IsComplete) Then
            ucrBase.OKEnabled(True)
        ElseIf rdoWalterLieth.Checked AndAlso ((Not ucrReceiverAbsolute.IsEmpty AndAlso Not ucrReceiverMaxtem.IsEmpty AndAlso Not ucrReceiverMintemp.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverRain.IsEmpty) OrElse Not ucrSave.IsComplete) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrPnlClimograph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlClimograph.ControlValueChanged
        If rdoClimograph.Checked Then
            clsBaseOperator.RemoveParameterByName("ggwalter_lieth")
            ucrReceiverMonthC.SetMeAsReceiver()
            clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
            clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBarFunction, iPosition:=2)
        Else
            clsBaseOperator.RemoveParameterByName("ggplot")
            clsBaseOperator.RemoveParameterByName("geom_bar")
            ucrReceiverMonth.SetMeAsReceiver()
            clsBaseOperator.AddParameter("ggwalter_lieth", clsRFunctionParameter:=clsGgwalterliethFunction, iPosition:=0)
        End If
        AutoFacetStation()
        AddRemoveFacetClimograph()
        AddRemoveFacetsWalterLieth()
        AddRemoveGeomBar()
        AddRemoveGeomLine1()
        AddRemoveGeomLines()
        AddRemoveSecondaryAxis()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextBar()
        AddRemoveGeomTextTmax()
        AddRemoveGeomTextTmin()
        EnableTileAndRibbon()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        UpdateParameters()
        TestOKEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction,
                                clsNewXLabsTitleFunction:=clsXlabFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction,
                                dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrSelectorClimograph, clsNewThemeFunction:=clsThemeFunction,
                                clsNewCoordPolarFunction:=clsCoordPolarFunction, clsNewCoordPolarStartOperator:=clsCoordPolarStartOperator, clsNewXScaleDateFunction:=clsXScaleDateFunction, clsNewAnnotateFunction:=clsAnnotateFunction,
                                clsNewScaleFillViridisFunction:=clsScaleFillViridisFunction, clsNewScaleColourViridisFunction:=clsScaleColourViridisFunction, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewFacetVariablesOperator:=clsFacetVariablesOperator, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        AutoFacetStation()
        AddRemoveFacetClimograph()
        AddRemoveFacetsWalterLieth()
        AddRemoveGeomBar()
        AddRemoveGeomLine1()
        AddRemoveGeomLines()
        AddRemoveSecondaryAxis()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextBar()
        AddRemoveGeomTextTmax()
        AddRemoveGeomTextTmin()
        bResetSubdialog = False
    End Sub

    Private Sub ucrInputFacet_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputFacet.ControlValueChanged
        If Not bUpdateComboOptions1 Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not strChangedText = strFacetCol1 AndAlso Not strChangedText = strFacetRow1 AndAlso
                    Not ucrInputFacet.Equals(ucrChangedControl) AndAlso ucrInputFacet.GetText() = strChangedText Then
                bUpdateComboOptions1 = False
                ucrInputFacet.SetName(strNone1)
                bUpdateComboOptions1 = True
            End If
            If (strChangedText = strFacetWrap1 AndAlso ucrInputFacet.GetText = strFacetRow1) OrElse (strChangedText = strFacetRow1 AndAlso
                    ucrInputFacet.GetText = strFacetWrap1) OrElse (strChangedText = strFacetWrap1 AndAlso
                    ucrInputFacet.GetText = strFacetCol1) OrElse (strChangedText = strFacetCol1 AndAlso ucrInputFacet.GetText = strFacetWrap1) Then
                ucrInputFacet.SetName(strNone1)
            End If
        End If
        UpdateParameters1()
        AddRemoveFacets1()
        AddRemoveGroupBy1()
    End Sub

    Private Sub UpdateParameters1()
        clsFacetVariablesOperator.RemoveParameterByName("var1")
        clsFacetColOp1.RemoveParameterByName("col" & ucrInputFacet.Name)
        clsFacetRowOp1.RemoveParameterByName("row" & ucrInputFacet.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters1 = True
        ucrReceiverFacet.SetRCode(Nothing)
        Select Case ucrInputFacet.GetText()
            Case strFacetWrap1
                ucrReceiverFacet.ChangeParameterName("var1")
                ucrReceiverFacet.SetRCode(clsFacetVariablesOperator)
            Case strFacetCol1
                ucrReceiverFacet.ChangeParameterName("col" & ucrInputFacet.Name)
                ucrReceiverFacet.SetRCode(clsFacetColOp1)
            Case strFacetRow1
                ucrReceiverFacet.ChangeParameterName("row" & ucrInputFacet.Name)
                ucrReceiverFacet.SetRCode(clsFacetRowOp1)
        End Select
        If Not clsRFacetFunction.ContainsParameter("x") Then
            clsRFacetFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
        bUpdatingParameters1 = False
    End Sub

    Private Sub AddRemoveFacets1()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False

        If bUpdatingParameters1 Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucrReceiverFacet.IsEmpty Then
            Select Case ucrInputFacet.GetText()
                Case strFacetWrap1
                    bWrap = True
                Case strFacetCol1
                    bCol = True
                Case strFacetRow1
                    bRow = True
            End Select
        End If

        If bWrap OrElse bRow OrElse bCol Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction1)
        End If
        If bWrap Then
            clsFacetFunction1.SetRCommand("facet_wrap")
        End If
        If bRow OrElse bCol Then
            clsFacetFunction1.SetRCommand("facet_grid")
        End If
        If bRow Then
            clsFacetVariablesOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp1, iPosition:=0)
        ElseIf bCol AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("left")
        End If
        If bCol Then
            clsFacetVariablesOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp1, iPosition:=1)
        ElseIf bRow AndAlso bWrap = False Then
            clsFacetVariablesOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetVariablesOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub AddRemoveFacetClimograph()
        If rdoClimograph.Checked Then
            If Not ucrReceiverFacet.IsEmpty Then
                clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction1)
            Else
                clsBaseOperator.RemoveParameterByName("facets")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("facets")
        End If
    End Sub
    Private Sub ucrReceiverFacet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFacet.ControlValueChanged
        AddRemoveFacetClimograph()
        AddRemoveFacets1()
        AddRemoveGroupBy1()
    End Sub

    Private Sub GetParameterValue1(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction1.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy1()
        If clsPipeOperator1.ContainsParameter("mutate") Then
            clsGroupByFunction1.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputFacet.GetText()
                    Case strFacetWrap1
                        GetParameterValue1(clsFacetVariablesOperator)
                    Case strFacetCol1
                        GetParameterValue1(clsFacetColOp1)
                    Case strFacetRow1
                        GetParameterValue1(clsFacetRowOp1)
                End Select
            End If

            If clsGroupByFunction1.iParameterCount > 0 Then
                clsPipeOperator1.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction1, iPosition:=1)
            Else
                clsPipeOperator1.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator1.RemoveParameterByName("group_by")
        End If

        SetPipeAssignTo1()
    End Sub

    Private Sub SetPipeAssignTo1()
        If ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator1.clsParameters.Count > 1 Then
            clsPipeOperator1.SetAssignTo(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator1.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not strChangedText = strFacetCol AndAlso Not strChangedText = strFacetRow AndAlso
                    Not ucrInputStation.Equals(ucrChangedControl) AndAlso ucrInputStation.GetText() = strChangedText Then
                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso ucrInputStation.GetText = strFacetRow) OrElse (strChangedText = strFacetRow AndAlso
                    ucrInputStation.GetText = strFacetWrap) OrElse (strChangedText = strFacetWrap AndAlso
                    ucrInputStation.GetText = strFacetCol) OrElse (strChangedText = strFacetCol AndAlso ucrInputStation.GetText = strFacetWrap) Then
                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetOperator.RemoveParameterByName("var1")
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("var1")
                ucr1stFactorReceiver.SetRCode(clsFacetOperator)
            Case strFacetCol
                ucr1stFactorReceiver.ChangeParameterName("col" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetColOp)
            Case strFacetRow
                ucr1stFactorReceiver.ChangeParameterName("row" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetRowOp)
        End Select
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucr1stFactorReceiver.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
            End Select
        End If

        If bWrap OrElse bRow OrElse bCol Then
            clsBaseOperator.AddParameter("facets1", clsRFunctionParameter:=clsFacetFunction)
        End If
        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If
        If bRow OrElse bCol Then
            clsFacetFunction.SetRCommand("facet_grid")
        End If
        If bRow Then
            clsFacetOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf bCol AndAlso Not bWrap Then
            clsFacetOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetOperator.RemoveParameterByName("left")
        End If
        If bCol Then
            clsFacetOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf bRow AndAlso Not bWrap Then
            clsFacetOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub AddRemoveFacetsWalterLieth()
        If rdoWalterLieth.Checked Then
            If Not ucr1stFactorReceiver.IsEmpty Then
                clsGgwalterliethFunction.AddParameter("station", ucr1stFactorReceiver.GetVariableNames(), iPosition:=1)
            Else
                clsGgwalterliethFunction.RemoveParameterByName("station")
                clsBaseOperator.RemoveParameterByName("facets1")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("facets1")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged
        AddRemoveFacetsWalterLieth()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub AutoFacetStation()
        If rdoClimograph.Checked Then
            Dim currentReceiver As ucrReceiver = ucrSelectorClimograph.CurrentReceiver

            If currentReceiver IsNot Nothing Then
                ucrReceiverFacet.AddItemsWithMetadataProperty(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"year_label"})
                currentReceiver.SetMeAsReceiver()
                AddRemoveGroupBy1()
            End If
        Else
            Dim ucrCurrentReceiver As ucrReceiver = ucrSelectorClimograph.CurrentReceiver

            If ucrCurrentReceiver IsNot Nothing Then
                ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
                ucrCurrentReceiver.SetMeAsReceiver()
                AddRemoveGroupBy()
            End If
        End If
    End Sub

    Private Sub ucrSelectorClimograph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimograph.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
        SetPipeAssignTo1()
        AddRemoveGeomRibbon()
    End Sub

    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy()
        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetOperator)
                    Case strFacetCol
                        GetParameterValue(clsFacetColOp)
                    Case strFacetRow
                        GetParameterValue(clsFacetRowOp)
                End Select
            End If
            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If

        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrReceiverElement1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement1.ControlValueChanged
        AddRemoveSecondaryAxis()
        AddRemoveGeomLines()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextTmax()
        EnableTileAndRibbon()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=15)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub ucrChkLegend_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLegend.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged
        AddRemoveTheme()
    End Sub

    Private Sub ucrChkColourIdntity_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkColourIdntity.ControlValueChanged, ucrInputName.ControlValueChanged, ucrInputLabels.ControlValueChanged
        AddRemoveGeomLines()
        AddRemoveGeomLine1()
    End Sub

    Private Sub AddRemoveGeomTextBar()
        If rdoClimograph.Checked Then
            If ucrChkText.Checked Then
                If Not ucrReceiverRainC.IsEmpty Then
                    clsRoundBarFunction.AddParameter("y", ucrReceiverRainC.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                    clsAesGeomTextBarFunction.AddParameter("label", clsRFunctionParameter:=clsRoundBarFunction, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_text", clsRFunctionParameter:=clsGeomTextBarFunction, iPosition:=5, bIncludeArgumentName:=False)
                Else
                    clsBaseOperator.RemoveParameterByName("geom_text")
                End If
            Else
                clsBaseOperator.RemoveParameterByName("geom_text")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_text")
        End If
    End Sub

    Private Sub AddRemoveGeomTextTmax()
        If rdoClimograph.Checked Then
            If ucrChkText.Checked Then
                If Not ucrReceiverElement1.IsEmpty Then
                    clsRoundTmaxFunction.AddParameter("y", ucrReceiverElement1.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                    If Not ucrReceiverRainC.IsEmpty Then
                        clsStarOperator.AddParameter("left", ucrReceiverElement1.GetVariableNames(False), iPosition:=1, bIncludeArgumentName:=False)
                        clsBaseOperator.AddParameter("geom_text1", clsRFunctionParameter:=clsGeomTextTmaxStarFunction, iPosition:=6, bIncludeArgumentName:=False)
                    Else
                        clsAesGeomTextTmaxFunction.AddParameter("y", ucrReceiverElement1.GetVariableNames(False), iPosition:=0)
                        clsBaseOperator.AddParameter("geom_text1", clsRFunctionParameter:=clsGeomTextTmaxFunction, iPosition:=6, bIncludeArgumentName:=False)
                    End If
                Else
                    clsBaseOperator.RemoveParameterByName("geom_text1")
                End If
            Else
                clsBaseOperator.RemoveParameterByName("geom_text1")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_text1")
        End If
    End Sub

    Private Sub AddRemoveGeomTextTmin()
        If rdoClimograph.Checked Then
            If ucrChkText.Checked Then
                If Not ucrReceiverElement2.IsEmpty Then
                    clsRoundTminFunction.AddParameter("y", ucrReceiverElement2.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                    If Not ucrReceiverRainC.IsEmpty Then
                        clsStar1Operator.AddParameter("left", ucrReceiverElement2.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                        clsBaseOperator.AddParameter("geom_text2", clsRFunctionParameter:=clsGeomTextTminStarFunction, iPosition:=7, bIncludeArgumentName:=False)
                    Else
                        clsAesGeomTextTminFunction.AddParameter("y", ucrReceiverElement2.GetVariableNames(False), iPosition:=0)
                        clsBaseOperator.AddParameter("geom_text2", clsRFunctionParameter:=clsGeomTextTminFunction, iPosition:=7, bIncludeArgumentName:=False)
                    End If
                Else
                    clsBaseOperator.RemoveParameterByName("geom_text2")
                End If
            Else
                clsBaseOperator.RemoveParameterByName("geom_text2")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_text2")
        End If
    End Sub

    Private Sub AddRemoveGeomRibbon()
        If rdoClimograph.Checked Then
            If ucrChkRibbon.Checked Then
                If ucrChkRibbon.Enabled = True Then
                    clsBaseOperator.AddParameter("scale_x_discrete", clsRFunctionParameter:=clsXScalediscreteFunction, iPosition:=12)
                    If Not ucrReceiverRainC.IsEmpty Then
                        clsStar1Operator.AddParameter("left", ucrReceiverElement2.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                        clsStarOperator.AddParameter("left", ucrReceiverElement1.GetVariableNames(False), iPosition:=1, bIncludeArgumentName:=False)
                        clsBaseOperator.AddParameter("geom_ribbon", clsRFunctionParameter:=clsGeomRibbon1Function, iPosition:=1)
                    Else
                        clsAesGeomRibbonFunction.AddParameter("ymin", ucrReceiverElement2.GetVariableNames(False), iPosition:=0)
                        clsAesGeomRibbonFunction.AddParameter("ymax", ucrReceiverElement1.GetVariableNames(False), iPosition:=1)
                        clsBaseOperator.AddParameter("geom_ribbon", clsRFunctionParameter:=clsGeomRibbonFunction, iPosition:=1)
                    End If
                Else
                    clsBaseOperator.RemoveParameterByName("geom_ribbon")
                    clsBaseOperator.RemoveParameterByName("scale_x_discrete")
                End If
            Else
                    clsBaseOperator.RemoveParameterByName("geom_ribbon")
                clsBaseOperator.RemoveParameterByName("scale_x_discrete")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_ribbon")
            clsBaseOperator.RemoveParameterByName("scale_x_discrete")
        End If
    End Sub

    Private Sub ucrChkTile_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkTile.ControlValueChanged
        AddRemoveGeomBar()
        EnableTileAndRibbon()
    End Sub

    Private Sub ucrChkRibbon_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkRibbon.ControlValueChanged
        AddRemoveGeomRibbon()
        EnableTileAndRibbon()
    End Sub

    Private Sub AddRemoveGeomLines()
        If rdoClimograph.Checked Then
            If Not ucrReceiverElement1.IsEmpty Then
                If Not ucrReceiverRainC.IsEmpty Then
                    clsStarOperator.AddParameter("left", ucrReceiverElement1.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                    clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLineStarFunction, iPosition:=4)
                    If ucrChkColourIdntity.Checked Then
                        clsAesLineStarFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34), iPosition:=3)
                        clsBaseOperator.AddParameter("scale_colour_identity", clsRFunctionParameter:=clsScalecolouridentityFunction, iPosition:=13)
                        If Not ucrInputLabels.IsEmpty Then
                            clsScalecolouridentityFunction.AddParameter("labels", ucrInputLabels.clsRList.ToScript(), iPosition:=2)
                        Else
                            clsScalecolouridentityFunction.RemoveParameterByName("labels")
                        End If
                        If Not ucrInputName.IsEmpty Then
                            clsScalecolouridentityFunction.AddParameter("name", Chr(34) & ucrInputName.GetText() & Chr(34), iPosition:=0)
                        Else
                            clsScalecolouridentityFunction.RemoveParameterByName("name")
                        End If
                    Else
                        clsBaseOperator.RemoveParameterByName("scale_colour_identity")
                        clsAesLineStarFunction.RemoveParameterByName("colour")
                    End If
                Else
                    clsAesLineFunction.AddParameter("y", ucrReceiverElement1.GetVariableNames(False), iPosition:=0)
                    clsBaseOperator.AddParameter("geom_line", clsRFunctionParameter:=clsGeomLineFunction, iPosition:=4)
                    If ucrChkColourIdntity.Checked Then
                        clsAesLineFunction.AddParameter("colour", Chr(34) & "blue" & Chr(34), iPosition:=3)
                        clsBaseOperator.AddParameter("scale_colour_identity", clsRFunctionParameter:=clsScalecolouridentityFunction, iPosition:=13)
                        If Not ucrInputLabels.IsEmpty Then
                            clsScalecolouridentityFunction.AddParameter("labels", ucrInputLabels.clsRList.ToScript(), iPosition:=2)
                        Else
                            clsScalecolouridentityFunction.RemoveParameterByName("labels")
                        End If
                        If Not ucrInputName.IsEmpty Then
                            clsScalecolouridentityFunction.AddParameter("name", Chr(34) & ucrInputName.GetText() & Chr(34), iPosition:=0)
                        Else
                            clsScalecolouridentityFunction.RemoveParameterByName("name")
                        End If
                    Else
                        clsBaseOperator.RemoveParameterByName("scale_colour_identity")
                        clsAesLineFunction.RemoveParameterByName("colour")
                    End If
                End If
            Else
                clsBaseOperator.RemoveParameterByName("geom_line")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_line")
            clsBaseOperator.RemoveParameterByName("scale_colour_identity")
        End If
    End Sub

    Private Sub AddRemoveGeomLine1()
        If rdoClimograph.Checked Then
            If Not ucrReceiverElement2.IsEmpty Then
                If Not ucrReceiverRainC.IsEmpty Then
                    clsStar1Operator.AddParameter("left", ucrReceiverElement2.GetVariableNames(False), iPosition:=0, bIncludeArgumentName:=False)
                    clsBaseOperator.AddParameter("geom_line1", clsRFunctionParameter:=clsGeomLineStar1Function, iPosition:=4)
                    If ucrChkColourIdntity.Checked Then
                        clsAesLineStar1Function.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=3)
                        clsBaseOperator.AddParameter("scale_colour_identity", clsRFunctionParameter:=clsScalecolouridentityFunction, iPosition:=13)
                        If Not ucrInputLabels.IsEmpty Then
                            clsScalecolouridentityFunction.AddParameter("labels", ucrInputLabels.clsRList.ToScript(), iPosition:=2)
                        Else
                            clsScalecolouridentityFunction.RemoveParameterByName("labels")
                        End If
                        If Not ucrInputName.IsEmpty Then
                            clsScalecolouridentityFunction.AddParameter("name", Chr(34) & ucrInputName.GetText() & Chr(34), iPosition:=0)
                        Else
                            clsScalecolouridentityFunction.RemoveParameterByName("name")
                        End If
                    Else
                        clsAesLine1Function.AddParameter("y", ucrReceiverElement2.GetVariableNames(False), iPosition:=0)
                        clsBaseOperator.RemoveParameterByName("scale_colour_identity")
                        clsAesLineStar1Function.RemoveParameterByName("colour")
                    End If
                Else
                    clsBaseOperator.AddParameter("geom_line1", clsRFunctionParameter:=clsGeomLineFunction1, iPosition:=4)
                    If ucrChkColourIdntity.Checked Then
                        clsAesLine1Function.AddParameter("colour", Chr(34) & "red" & Chr(34), iPosition:=3)
                        clsBaseOperator.AddParameter("scale_colour_identity", clsRFunctionParameter:=clsScalecolouridentityFunction, iPosition:=13)
                        If Not ucrInputLabels.IsEmpty Then
                            clsScalecolouridentityFunction.AddParameter("labels", ucrInputLabels.clsRList.ToScript(), iPosition:=2)
                        Else
                            clsScalecolouridentityFunction.RemoveParameterByName("labels")
                        End If
                        If Not ucrInputName.IsEmpty Then
                            clsScalecolouridentityFunction.AddParameter("name", Chr(34) & ucrInputName.GetText() & Chr(34), iPosition:=0)
                        Else
                            clsScalecolouridentityFunction.RemoveParameterByName("name")
                        End If
                    Else
                        clsBaseOperator.RemoveParameterByName("scale_colour_identity")
                        clsAesLine1Function.RemoveParameterByName("colour")
                    End If
                End If
            Else
                clsBaseOperator.RemoveParameterByName("geom_line1")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("scale_colour_identity")
            clsBaseOperator.RemoveParameterByName("geom_line1")
        End If
    End Sub

    Private Sub AddRemoveGeomBar()
        If rdoClimograph.Checked Then
            If Not ucrReceiverRainC.IsEmpty Then
                clsBarAesFunction.AddParameter("y", ucrReceiverRainC.GetVariableNames(False), iPosition:=0)
                clsLabFunction.AddParameter("fill", Chr(34) & "Rainfall" & Chr(34), iPosition:=0)
                clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabFunction, iPosition:=13)
                If ucrChkTile.Checked Then
                    clsBarAesFunction.AddParameter("fill", ucrReceiverRainC.GetVariableNames(False), iPosition:=3)
                    clsBaseOperator.AddParameter("geom_tile", clsRFunctionParameter:=clsGeomTileFunction, iPosition:=1)
                    clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBarFunction, iPosition:=2)
                Else
                    clsBarAesFunction.AddParameter("fill", ucrReceiverMonthC.GetVariableNames(False), iPosition:=3)
                    clsBaseOperator.AddParameter("geom_bar", clsRFunctionParameter:=clsGeomBarFunction, iPosition:=2)
                    clsBaseOperator.RemoveParameterByName("geom_tile")
                End If
            Else
                clsBarAesFunction.RemoveParameterByName("y")
                clsBaseOperator.RemoveParameterByName("geom_tile")
                clsBaseOperator.RemoveParameterByName("geom_bar")
                clsBaseOperator.RemoveParameterByName("labs")
            End If
        Else
            clsBaseOperator.RemoveParameterByName("geom_tile")
            clsBaseOperator.RemoveParameterByName("geom_bar")
            clsBaseOperator.RemoveParameterByName("labs")
        End If
    End Sub

    Private Sub EnableTileAndRibbon()
        ucrChkRibbon.Enabled = (Not ucrReceiverElement1.IsEmpty AndAlso Not ucrReceiverElement2.IsEmpty) AndAlso Not ucrChkTile.Checked
        ucrChkTile.Enabled = Not ucrChkRibbon.Checked AndAlso Not ucrReceiverRainC.IsEmpty
    End Sub

    Private Sub AddRemoveSecondaryAxis()
        If rdoClimograph.Checked Then
            clsBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsScaleycontinuousFunction, iPosition:=9)
            If Not ucrReceiverRainC.IsEmpty Then
                clsScaleycontinuousFunction.AddParameter("name", Chr(34) & "Rainfall (mm)" & Chr(34), iPosition:=0)
                If Not ucrReceiverElement1.IsEmpty OrElse Not ucrReceiverElement2.IsEmpty Then
                    clsScaleycontinuousFunction.AddParameter("sec.axis", clsRFunctionParameter:=clsSecondaryAxis2Function, iPosition:=1)
                Else
                    clsScaleycontinuousFunction.AddParameter("sec.axis", clsRFunctionParameter:=clsSecondaryAxisFunction, iPosition:=1)
                End If
            Else
                clsScaleycontinuousFunction.AddParameter("name", Chr(34) & "Temperature (c)" & Chr(34), iPosition:=0)
                clsScaleycontinuousFunction.AddParameter("sec.axis", clsRFunctionParameter:=clsSecondaryAxis1Function, iPosition:=1)
            End If
        Else
            clsBaseOperator.RemoveParameterByName("scale_y_continuous")
        End If
    End Sub

    Private Sub ucrReceiverElement2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement2.ControlValueChanged
        AddRemoveSecondaryAxis()
        AddRemoveGeomLine1()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextTmin()
        EnableTileAndRibbon()
    End Sub

    Private Sub ucrReceiverRainC_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRainC.ControlValueChanged
        AddRemoveSecondaryAxis()
        AddRemoveGeomBar()
        AddRemoveGeomTextBar()
        EnableTileAndRibbon()
        AddRemoveGeomLines()
        AddRemoveGeomLine1()
        AddRemoveGeomRibbon()
        AddRemoveGeomTextTmin()
        AddRemoveGeomTextTmax()
    End Sub

    Private Sub ucrReceiverMonthC_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMonthC.ControlValueChanged
        AddRemoveGeomRibbon()
        AddRemoveGeomBar()
    End Sub

    Private Sub ucrSelectorClimograph_DataFrameChanged() Handles ucrSelectorClimograph.DataFrameChanged
        clsGetObjectDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        AddRemoveGeomRibbon()
    End Sub

    Private Sub ucrChkText_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkText.ControlValueChanged
        AddRemoveGeomTextBar()
        AddRemoveGeomTextTmax()
        AddRemoveGeomTextTmin()
    End Sub

    Private Sub ucrSave_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSave.ControlValueChanged
        If ucrSave.ucrChkSave.Checked Then
            clsGetObjectDataFunction.AddParameter("object_name", Chr(34) & ucrSave.GetText & Chr(34), iPosition:=1)
        Else
            clsGetObjectDataFunction.AddParameter("object_name", Chr(34) & "last_graph" & Chr(34), iPosition:=1)
        End If
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlClimograph.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverAbsolute.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverMaxtem.ControlContentsChanged, ucrReceiverMintemp.ControlContentsChanged, ucrSave.ControlContentsChanged, ucrReceiverElement1.ControlContentsChanged, ucrReceiverElement2.ControlContentsChanged, ucrReceiverMonthC.ControlContentsChanged, ucrReceiverRainC.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class