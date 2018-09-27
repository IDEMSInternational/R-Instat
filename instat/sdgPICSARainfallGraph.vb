﻿' R- Instat
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

Imports instat
Imports instat.Translations
Public Class sdgPICSARainfallGraph
    Private bControlsInitialised As Boolean = False
    Public clsBaseOperator As ROperator
    Public clsLabsFunction, clsXLabsFunction, clsYLabsFunction As RFunction
    Public clsXScaleContinuousFunction, clsYScaleContinuousFunction As New RFunction
    Public clsXScalecontinuousSeqFunction, clsYScaleContinuousSeqFunction As New RFunction
    Public clsYScaleDateFunction As New RFunction
    Public clsGemoHLineMean As New RFunction
    Public clsMeanLine, clsMedianLine, clsTretile As New RFunction
    Public clsThemeFunction As RFunction
    Public dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bRCodeSet As Boolean = False

    Private clsPlotElementTitle As New RFunction
    Private clsPlotElementSubTitle As New RFunction
    Private clsPlotElementCaption As New RFunction
    Private clsXElementTitle As New RFunction
    Private clsYElementTitle As New RFunction
    Private clsXElementLabels As New RFunction
    Private clsYElementLabels As New RFunction
    Private clsElementPanelGridMajor, clsElementPanelGridMinor As New RFunction
    'Private clsPnlBackgroundElementRect As New RFunction
    Private clsPanelBackgroundElementRect As New RFunction
    Private clsPanelBorderElementRect As New RFunction
    Private dctLabelForDays As New Dictionary(Of String, String)
    Private dctDateTimePeriods As New Dictionary(Of String, String)

    Private clsDatePeriodOperator As New ROperator

    Private clsGeomHlineMean As New RFunction
    Private clsGeomHlineMedian As New RFunction
    Private clsGeomHlineLowerTercile As New RFunction
    Private clsGeomHlineUpperTercile As New RFunction

    Private clsRaesFunction As New RFunction
    Private clsAsDate As New RFunction
    Private clsAsNumeric As New RFunction

    Private Sub sdgPICSARainfallGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        ' Temp disabled until implemented
        ucrChkAddMeanLabel.Enabled = False
        ucrChkAddMedianLabel.Enabled = False
        ucrChkAddTercilesLabel.Enabled = False

        ' Titles 
        ucrPnlXAxisTitle.AddRadioButton(rdoAutoXAxis)
        ucrPnlXAxisTitle.AddRadioButton(rdoNoTitleXAxisTitle)
        ucrPnlXAxisTitle.AddRadioButton(rdoSpecifyXAxisTitle)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoAutoXAxis, "label", False)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoNoTitleXAxisTitle, "label", True)
        ucrPnlXAxisTitle.AddParameterValuesCondition(rdoNoTitleXAxisTitle, "label", Chr(34) & Chr(34), True)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoSpecifyXAxisTitle, "label", True)
        ucrPnlXAxisTitle.AddParameterValuesCondition(rdoSpecifyXAxisTitle, "label", Chr(34) & Chr(34), False)

        ucrPnlXAxisTitle.AddToLinkedControls(ucrInputXAxisTitle, {rdoSpecifyXAxisTitle}, bNewLinkedHideIfParameterMissing:=True)

        UcrPnlYAxisTitle.AddRadioButton(rdoAutoYAxis)
        UcrPnlYAxisTitle.AddRadioButton(rdoNoYAxisTitle)
        UcrPnlYAxisTitle.AddRadioButton(rdoSpecifyYAxisTitle)

        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoAutoYAxis, "label", False)

        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoNoYAxisTitle, "label", True)
        UcrPnlYAxisTitle.AddParameterValuesCondition(rdoNoYAxisTitle, "label", Chr(34) & Chr(34), True)

        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoSpecifyYAxisTitle, "label", True)
        UcrPnlYAxisTitle.AddParameterValuesCondition(rdoSpecifyYAxisTitle, "label", Chr(34) & Chr(34), False)

        UcrPnlYAxisTitle.AddToLinkedControls(ucrInputYAxisTitle, {rdoSpecifyYAxisTitle}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputXAxisTitle.SetParameter(New RParameter("label"))
        ucrInputYAxisTitle.SetParameter(New RParameter("label"))

        ucrInputGraphTitle.SetParameter(New RParameter("title"))

        ucrInputGraphSubTitle.SetParameter(New RParameter("subtitle"))

        ucrInputGraphcCaption.SetParameter(New RParameter("caption"))

        ucrNudTitleSize.SetParameter(New RParameter("size"))
        ucrNudTitleSize.Increment = 0.1
        ucrNudTitleSize.Minimum = 0

        ucrNudSubTitleSize.SetParameter(New RParameter("size"))
        ucrNudSubTitleSize.Increment = 0.1
        ucrNudSubTitleSize.Minimum = 0

        ucrNudCaptionSize.SetParameter(New RParameter("size"))
        ucrNudCaptionSize.Increment = 0.1
        ucrNudCaptionSize.Minimum = 0

        ucrNudXAxisTitleSize.SetParameter(New RParameter("size"))
        ucrNudXAxisTitleSize.Increment = 0.1
        ucrNudXAxisTitleSize.Minimum = 0

        ucrNudYAxisTitleSize.SetParameter(New RParameter("size"))
        ucrNudYAxisTitleSize.Increment = 0.1
        ucrNudYAxisTitleSize.Minimum = 0

        ' Labels 
        ucrChkXAxisLabelSize.SetText("Size")
        ucrChkXAxisLabelSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudXaxisLabelSize.SetParameter(New RParameter("size"))
        ucrNudXaxisLabelSize.Increment = 0.1
        ucrNudXaxisLabelSize.Minimum = 0

        ucrChkYAxisLabelSize.SetText("Size")
        ucrChkYAxisLabelSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudYAxisLabelSize.SetParameter(New RParameter("size"))
        ucrNudYAxisLabelSize.Increment = 0.1
        ucrNudYAxisLabelSize.Minimum = 0

        ucrChkXAxisAngle.SetText("Angle")
        ucrChkXAxisAngle.SetParameter(New RParameter("angle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrNudXAxisAngle.SetMinMax(0, 360)
        ucrNudXAxisAngle.SetParameter(New RParameter("angle"))

        ucrChkYAxisAngle.SetText("Angle")
        ucrChkYAxisAngle.SetParameter(New RParameter("angle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudYAxisAngle.SetMinMax(0, 360)

        ucrChkSpecifyXAxisTickMarks.SetText("Specify Breaks")
        ucrChkSpecifyXAxisTickMarks.SetParameter(New RParameter("scale_x_continuous"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrInputXFrom.SetParameter(New RParameter("from"))
        ucrInputXFrom.SetValidationTypeAsNumeric()
        ucrInputXFrom.AddQuotesIfUnrecognised = False

        ucrInputXTo.SetParameter(New RParameter("to"))
        ucrInputXTo.SetValidationTypeAsNumeric()
        ucrInputXTo.AddQuotesIfUnrecognised = False

        ucrInputXInStepsOf.SetParameter(New RParameter("by"))
        ucrInputXInStepsOf.SetValidationTypeAsNumeric()
        ucrInputXInStepsOf.AddQuotesIfUnrecognised = False

        ucrChkSpecifyYAxisTickMarks.SetText("Numeric Breaks")
        ucrChkSpecifyYAxisTickMarks.SetParameter(New RParameter("scale_y_continuous"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrInputYFrom.SetParameter(New RParameter("from"))
        ucrInputYFrom.SetValidationTypeAsNumeric()
        ucrInputYFrom.AddQuotesIfUnrecognised = False

        ucrInputYTo.SetParameter(New RParameter("to"))
        ucrInputYTo.SetValidationTypeAsNumeric()
        ucrInputYTo.AddQuotesIfUnrecognised = False

        ucrInputYInStepsOf.SetParameter(New RParameter("by"))
        ucrInputYInStepsOf.SetValidationTypeAsNumeric()
        ucrInputYInStepsOf.AddQuotesIfUnrecognised = False

        ucrChkLabelForDays.SetText("Format as Date")
        ucrChkLabelForDays.SetParameter(New RParameter("scale_y_date"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkLabelForDays.AddToLinkedControls(ucrInputLabelForDays, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Day Month (1 Jan)")
        ucrChkLabelForDays.AddToLinkedControls(ucrChkSpecifyDateBreaks, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputLabelForDays.SetParameter(New RParameter("date_label", 0))
        dctLabelForDays.Add("Day Number (1-366)", Chr(34) & "%j" & Chr(34))
        dctLabelForDays.Add("Day Month (1 Jan)", Chr(34) & "%d %b" & Chr(34))
        dctLabelForDays.Add("Day Month Full (1 January)", Chr(34) & "%d %B" & Chr(34))
        ucrInputLabelForDays.SetItems(dctLabelForDays)
        ucrInputLabelForDays.SetDropDownStyleAsNonEditable()

        ucrChkSpecifyDateBreaks.SetText("Specify Breaks")
        ucrChkSpecifyDateBreaks.SetParameter(New RParameter("date_breaks"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkSpecifyDateBreaks.AddToLinkedControls(ucrInputDateBreakTime, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Months")
        ucrChkSpecifyDateBreaks.AddToLinkedControls(ucrNudDateBreakNumber, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        dctDateTimePeriods.Add("Days", "days")
        dctDateTimePeriods.Add("Weeks", "weeks")
        dctDateTimePeriods.Add("Months", "months")
        dctDateTimePeriods.Add("Years", "years")

        ucrInputDateBreakTime.SetParameter(New RParameter("right", 1))
        ucrInputDateBreakTime.SetDropDownStyleAsNonEditable()
        ucrInputDateBreakTime.SetItems(dctDateTimePeriods)

        ucrNudDateBreakNumber.Minimum = 1
        ucrNudDateBreakNumber.Increment = 1
        ucrNudDateBreakNumber.SetParameter(New RParameter("left", 0))

        ucrChkYAxisAngle.AddToLinkedControls(ucrNudYAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkYAxisLabelSize.AddToLinkedControls(ucrNudYAxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecifyYAxisTickMarks.AddToLinkedControls({ucrInputYFrom, ucrInputYTo, ucrInputYInStepsOf}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputYFrom.SetLinkedDisplayControl(lblYFrom)
        ucrInputYTo.SetLinkedDisplayControl(lblYTo)
        ucrInputYInStepsOf.SetLinkedDisplayControl(lblYInStepsOf)

        ucrChkXAxisAngle.AddToLinkedControls(ucrNudXAxisAngle, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkXAxisLabelSize.AddToLinkedControls(ucrNudXaxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkSpecifyXAxisTickMarks.AddToLinkedControls({ucrInputXFrom, ucrInputXTo, ucrInputXInStepsOf}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputXFrom.SetLinkedDisplayControl(lblXFrom)
        ucrInputXTo.SetLinkedDisplayControl(lblXTo)
        ucrInputXInStepsOf.SetLinkedDisplayControl(lblXInStepsOf)

        ' Background
        ucrChkPnlBackgroundColour.SetText("Colour")
        ucrChkPnlBackgroundColour.SetParameter(New RParameter("colour"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrInputPnlBackgroundColour.SetParameter(New RParameter("colour"))
        UcrInputPnlBackgroundColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        UcrInputPnlBackgroundColour.SetDropDownStyleAsNonEditable()

        UcrChkPnlBackgroundFill.SetText("Fill")
        UcrChkPnlBackgroundFill.SetParameter(New RParameter("fill"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrInputPnlBackgroundFill.SetParameter(New RParameter("fill"))
        UcrInputPnlBackgroundFill.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        UcrInputPnlBackgroundFill.SetDropDownStyleAsNonEditable()

        UcrChkPnlBackgroundLineType.SetText("Line Type")
        UcrChkPnlBackgroundLineType.SetParameter(New RParameter("linetype"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrInputPnlBackgroundLinetype.SetParameter(New RParameter("linetype"))
        UcrInputPnlBackgroundLinetype.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        UcrInputPnlBackgroundLinetype.SetDropDownStyleAsNonEditable()

        UcrChkPnlBackgroundSize.SetText("Size")
        UcrChkPnlBackgroundSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudYAxisTitleSize.SetParameter(New RParameter("size"))
        ucrNudPnlBackgroundSize.Increment = 0.1
        ucrNudPnlBackgroundSize.DecimalPlaces = 1
        ucrNudPnlBackgroundSize.Minimum = 0

        UcrChkMajorGridLineColour.SetText("Colour")
        UcrChkMajorGridLineColour.SetParameter(New RParameter("colour"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrInputMajorGridLineColour.SetParameter(New RParameter("colour"))
        UcrInputMajorGridLineColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        UcrInputMajorGridLineColour.SetDropDownStyleAsNonEditable()

        UcrChkMajorGridLinetype.SetText("Line Type")
        UcrChkMajorGridLinetype.SetParameter(New RParameter("linetype"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrInputMajorGridLineLinetype.SetParameter(New RParameter("linetype"))
        UcrInputMajorGridLineLinetype.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        UcrInputMajorGridLineLinetype.SetDropDownStyleAsNonEditable()

        UcrChkMajorGridLineSize.SetText("Size")
        UcrChkMajorGridLineSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrNudMajorGridLineSize.SetParameter(New RParameter("size"))
        UcrNudMajorGridLineSize.Increment = 0.1
        UcrNudMajorGridLineSize.DecimalPlaces = 1
        UcrNudMajorGridLineSize.Minimum = 0

        UcrChkMinorGridLineColour.SetText("Colour")
        UcrChkMinorGridLineColour.SetParameter(New RParameter("colour"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrInputMinorGridLineColour.SetParameter(New RParameter("colour"))
        UcrInputMinorGridLineColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        UcrInputMinorGridLineColour.SetDropDownStyleAsNonEditable()

        UcrChkMinorGridLineType.SetText("Line Type")
        UcrChkMinorGridLineType.SetParameter(New RParameter("linetype"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrInputMinorGridLineTpe.SetParameter(New RParameter("linetype"))
        UcrInputMinorGridLineTpe.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        UcrInputMinorGridLineTpe.SetDropDownStyleAsNonEditable()

        UcrChkMinorGridLineSize.SetText("Size")
        UcrChkMinorGridLineSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrNudMinorGridLineSize.SetParameter(New RParameter("size"))
        UcrNudMinorGridLineSize.Increment = 0.1
        UcrNudMinorGridLineSize.DecimalPlaces = 1
        UcrNudMinorGridLineSize.Minimum = 0

        ucrChkBorderColour.SetText("Colour")
        ucrChkBorderColour.SetParameter(New RParameter("colour"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrInputBorderColour.SetParameter(New RParameter("colour"))
        ucrInputBorderColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputBorderColour.SetDropDownStyleAsNonEditable()

        ucrChkBorderLineType.SetText("Line Type")
        ucrChkBorderLineType.SetParameter(New RParameter("linetype"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrInputBorderLinetype.SetParameter(New RParameter("linetype"))
        ucrInputBorderLinetype.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputBorderLinetype.SetDropDownStyleAsNonEditable()

        UcrChkBorderSize.SetText("Size")
        UcrChkBorderSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudBorderSize.SetParameter(New RParameter("size"))
        ucrNudBorderSize.Increment = 0.1
        ucrNudBorderSize.DecimalPlaces = 1
        ucrNudBorderSize.Minimum = 0

        ucrChkPnlBackgroundColour.AddToLinkedControls(UcrInputPnlBackgroundColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkPnlBackgroundFill.AddToLinkedControls(UcrInputPnlBackgroundFill, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkPnlBackgroundLineType.AddToLinkedControls(UcrInputPnlBackgroundLinetype, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkPnlBackgroundSize.AddToLinkedControls(ucrNudPnlBackgroundSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        UcrChkMajorGridLineColour.AddToLinkedControls(UcrInputMajorGridLineColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkMajorGridLinetype.AddToLinkedControls(UcrInputMajorGridLineLinetype, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkMajorGridLineSize.AddToLinkedControls(UcrNudMajorGridLineSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        UcrChkMinorGridLineColour.AddToLinkedControls(UcrInputMinorGridLineColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkMinorGridLineType.AddToLinkedControls(UcrInputMinorGridLineTpe, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkMinorGridLineSize.AddToLinkedControls(UcrNudMinorGridLineSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkBorderColour.AddToLinkedControls(ucrInputBorderColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBorderLineType.AddToLinkedControls(ucrInputBorderLinetype, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Solid")
        UcrChkBorderSize.AddToLinkedControls(ucrNudBorderSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ' Line tab
        ' Mean Line
        ucrChkAddMean.SetText("Add Mean Line")
        ucrChkAddMean.AddParameterPresentCondition(True, "hlinemean", True)
        ucrChkAddMean.AddParameterPresentCondition(False, "hlinemean", False)
        ucrChkAddMean.AddToLinkedControls(ucrChkAddMeanLabel, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddMeanLabel.SetText("Include Label")

        ' Median Line
        ucrChkAddMedian.SetText("Add Median Line")
        ucrChkAddMedian.AddParameterPresentCondition(True, "hlinemedian", True)
        ucrChkAddMedian.AddParameterPresentCondition(False, "hlinemedian", False)
        ucrChkAddMedian.AddToLinkedControls(ucrChkAddMedianLabel, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddMedianLabel.SetText("Include Label")

        ' Tercile Lines
        ucrChkAddTerciles.SetText("Add Tercile Lines")
        ucrChkAddTerciles.AddParameterPresentCondition(True, "hlinelowertercile", True)
        ucrChkAddTerciles.AddParameterPresentCondition(False, "hlinelowertercile", False)
        ucrChkAddTerciles.AddToLinkedControls(ucrChkAddTercilesLabel, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddTercilesLabel.SetText("Include Labels")

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewOperator As ROperator, Optional clsNewLabsFunction As RFunction = Nothing, Optional clsNewXLabsFunction As RFunction = Nothing, Optional clsNewYLabsFunction As RFunction = Nothing, Optional clsNewXScaleContinuousFunction As RFunction = Nothing, Optional clsNewYScaleContinuousFunction As RFunction = Nothing, Optional clsNewYScaleDateFunction As RFunction = Nothing, Optional clsNewThemeFunction As RFunction = Nothing, Optional dctNewThemeFunctions As Dictionary(Of String, RFunction) = Nothing, Optional clsNewGeomhlineMean As RFunction = Nothing, Optional clsNewGeomhlineMedian As RFunction = Nothing, Optional clsNewGeomhlineLowerTercile As RFunction = Nothing, Optional clsNewGeomhlineUpperTercile As RFunction = Nothing, Optional clsNewRaesFunction As RFunction = Nothing, Optional clsNewAsDate As RFunction = Nothing, Optional clsNewAsNumeric As RFunction = Nothing, Optional clsNewDatePeriodOperator As ROperator = Nothing, Optional bReset As Boolean = False)
        bRCodeSet = False
        clsBaseOperator = clsNewOperator

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        'themes function
        clsThemeFunction = clsNewThemeFunction

        clsGeomHlineMean = clsNewGeomhlineMean
        clsGeomHlineMedian = clsNewGeomhlineMedian
        clsGeomHlineLowerTercile = clsNewGeomhlineLowerTercile
        clsGeomHlineUpperTercile = clsNewGeomhlineUpperTercile

        ' The position MUST be larger than the position of the theme_* argument
        ' Otherwise the choice of theme will overwrite the options selected here.
        ' Currently set to large value as no reason this cannot be at the end currently
        'clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)

        dctThemeFunctions = dctNewThemeFunctions
        dctThemeFunctions.TryGetValue("axis.text.x", clsXElementLabels)
        dctThemeFunctions.TryGetValue("axis.text.y", clsYElementLabels)

        dctThemeFunctions.TryGetValue("title", clsPlotElementTitle)
        dctThemeFunctions.TryGetValue("sub.title", clsPlotElementSubTitle)
        dctThemeFunctions.TryGetValue("caption", clsPlotElementCaption)
        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)

        dctThemeFunctions.TryGetValue("panel.grid.major", clsElementPanelGridMajor)
        dctThemeFunctions.TryGetValue("panel.grid.minor", clsElementPanelGridMinor)
        dctThemeFunctions.TryGetValue("panel.background", clsPanelBackgroundElementRect)
        dctThemeFunctions.TryGetValue("panel.border", clsPanelBorderElementRect)

        'Labels

        ucrNudTitleSize.SetRCode(clsPlotElementTitle, bCloneIfNeeded:=True)
        ucrNudSubTitleSize.SetRCode(clsPlotElementSubTitle, bCloneIfNeeded:=True)
        ucrNudCaptionSize.SetRCode(clsPlotElementCaption, bCloneIfNeeded:=True)

        ucrNudXAxisTitleSize.SetRCode(clsXElementTitle, bCloneIfNeeded:=True)
        ucrNudYAxisTitleSize.SetRCode(clsYElementTitle, bCloneIfNeeded:=True)

        ucrChkXAxisAngle.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)
        ucrChkXAxisLabelSize.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)
        ucrNudXAxisAngle.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)
        ucrNudXaxisLabelSize.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)

        ucrNudYAxisAngle.SetRCode(clsYElementLabels, bCloneIfNeeded:=True)
        ucrNudYAxisLabelSize.SetRCode(clsYElementLabels, bCloneIfNeeded:=True)
        ucrChkYAxisAngle.SetRCode(clsYElementLabels, bCloneIfNeeded:=True)
        ucrChkYAxisLabelSize.SetRCode(clsYElementLabels, bCloneIfNeeded:=True)

        'Background
        ucrChkPnlBackgroundColour.SetRCode(clsPanelBackgroundElementRect, bCloneIfNeeded:=True)
        UcrInputPnlBackgroundColour.SetRCode(clsPanelBackgroundElementRect, bCloneIfNeeded:=True)
        UcrChkPnlBackgroundFill.SetRCode(clsPanelBackgroundElementRect, bCloneIfNeeded:=True)
        UcrInputPnlBackgroundFill.SetRCode(clsPanelBackgroundElementRect, bCloneIfNeeded:=True)
        UcrChkPnlBackgroundLineType.SetRCode(clsPanelBackgroundElementRect, bCloneIfNeeded:=True)
        UcrInputPnlBackgroundLinetype.SetRCode(clsPanelBackgroundElementRect, bCloneIfNeeded:=True)
        UcrChkPnlBackgroundSize.SetRCode(clsPanelBackgroundElementRect, bCloneIfNeeded:=True)
        ucrNudPnlBackgroundSize.SetRCode(clsPanelBackgroundElementRect, bCloneIfNeeded:=True)

        UcrChkMajorGridLineColour.SetRCode(clsElementPanelGridMajor, bCloneIfNeeded:=True)
        UcrInputMajorGridLineColour.SetRCode(clsElementPanelGridMajor, bCloneIfNeeded:=True)
        UcrChkMajorGridLinetype.SetRCode(clsElementPanelGridMajor, bCloneIfNeeded:=True)
        UcrInputMajorGridLineLinetype.SetRCode(clsElementPanelGridMajor, bCloneIfNeeded:=True)
        UcrChkMajorGridLineSize.SetRCode(clsElementPanelGridMajor, bCloneIfNeeded:=True)
        UcrNudMajorGridLineSize.SetRCode(clsElementPanelGridMajor, bCloneIfNeeded:=True)

        UcrChkMinorGridLineColour.SetRCode(clsElementPanelGridMinor, bCloneIfNeeded:=True)
        UcrInputMinorGridLineColour.SetRCode(clsElementPanelGridMinor, bCloneIfNeeded:=True)
        UcrChkMinorGridLineType.SetRCode(clsElementPanelGridMinor, bCloneIfNeeded:=True)
        UcrInputMinorGridLineTpe.SetRCode(clsElementPanelGridMinor, bCloneIfNeeded:=True)
        UcrChkMinorGridLineSize.SetRCode(clsElementPanelGridMinor, bCloneIfNeeded:=True)
        UcrNudMinorGridLineSize.SetRCode(clsElementPanelGridMinor, bCloneIfNeeded:=True)

        ucrChkBorderColour.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        ucrInputBorderColour.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        ucrChkBorderLineType.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        ucrInputBorderLinetype.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        UcrChkBorderSize.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        ucrNudBorderSize.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)

        ' other functions 
        clsRaesFunction = clsNewRaesFunction

        clsAsDate = clsNewAsDate
        clsAsNumeric = clsNewAsNumeric

        clsDatePeriodOperator = clsNewDatePeriodOperator

        clsYScaleDateFunction = clsNewYScaleDateFunction

        ' Breaks for x-axis 
        If clsNewXScaleContinuousFunction IsNot Nothing Then
            clsXScaleContinuousFunction = clsNewXScaleContinuousFunction
        Else
            clsXScaleContinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        End If

        ' Breaks for y-axis 
        If clsNewYScaleContinuousFunction IsNot Nothing Then
            clsYScaleContinuousFunction = clsNewYScaleContinuousFunction
        Else
            clsYScaleContinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        End If

        ucrChkSpecifyXAxisTickMarks.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkSpecifyYAxisTickMarks.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)

        ' Seq function for Scales 
        Dim clsTempXBreaksParam As RParameter
        If clsXScaleContinuousFunction.ContainsParameter("breaks") Then
            clsTempXBreaksParam = clsXScaleContinuousFunction.GetParameter("breaks")
            If clsTempXBreaksParam.clsArgumentCodeStructure IsNot Nothing Then
                clsXScalecontinuousSeqFunction = clsTempXBreaksParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsXScalecontinuousSeqFunction = New RFunction
                clsXScalecontinuousSeqFunction.SetRCommand("seq")
            End If
        Else
            clsXScalecontinuousSeqFunction = New RFunction
            clsXScalecontinuousSeqFunction.SetRCommand("seq")
        End If

        ucrInputXFrom.SetRCode(clsXScalecontinuousSeqFunction, bReset, bCloneIfNeeded:=True)
        ucrInputXTo.SetRCode(clsXScalecontinuousSeqFunction, bReset, bCloneIfNeeded:=True)
        ucrInputXInStepsOf.SetRCode(clsXScalecontinuousSeqFunction, bReset, bCloneIfNeeded:=True)

        Dim clsTempYBreaksParam As RParameter
        If clsYScaleContinuousFunction.ContainsParameter("breaks") Then
            clsTempYBreaksParam = clsYScaleContinuousFunction.GetParameter("breaks")
            If clsTempYBreaksParam.clsArgumentCodeStructure IsNot Nothing Then
                clsYScaleContinuousSeqFunction = clsTempYBreaksParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsYScaleContinuousSeqFunction = New RFunction
                clsYScaleContinuousSeqFunction.SetRCommand("seq")
            End If
        Else
            clsYScaleContinuousSeqFunction = New RFunction
            clsYScaleContinuousSeqFunction.SetRCommand("seq")
        End If
        clsYScaleContinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsYScaleContinuousSeqFunction)

        ucrInputYFrom.SetRCode(clsYScaleContinuousSeqFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYTo.SetRCode(clsYScaleContinuousSeqFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYInStepsOf.SetRCode(clsYScaleContinuousSeqFunction, bReset, bCloneIfNeeded:=True)

        ' Graph Titles 
        If clsNewLabsFunction IsNot Nothing Then
            clsLabsFunction = clsNewLabsFunction
        Else
            clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        End If

        If clsNewXLabsFunction IsNot Nothing Then
            clsXLabsFunction = clsNewXLabsFunction
        Else
            clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        End If

        If clsNewYLabsFunction IsNot Nothing Then
            clsYLabsFunction = clsNewYLabsFunction
        Else
            clsYLabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        End If

        ucrInputGraphTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphSubTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputGraphcCaption.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)

        ucrPnlXAxisTitle.SetRCode(clsXLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputXAxisTitle.SetRCode(clsXLabsFunction, bReset, bCloneIfNeeded:=True)

        UcrPnlYAxisTitle.SetRCode(clsYLabsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYAxisTitle.SetRCode(clsYLabsFunction, bReset, bCloneIfNeeded:=True)

        If clsNewYScaleDateFunction IsNot Nothing Then
            clsYScaleDateFunction = clsNewYScaleDateFunction
        Else
            clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        End If

        ' scale_y_date function is used for the days lables - this function has been included in GGplot defaults 
        ' scale_y_date(date_label = %d %b) - for day/month option
        ' scale_y_date(date_label = %j) - for day option - however this gives the day number like so 01-366, which isn't great 
        ' so maybe when day option is selected we could remove the code instead 
        ucrChkLabelForDays.SetRCode(clsBaseOperator, bCloneIfNeeded:=True)
        ucrInputLabelForDays.SetRCode(clsYScaleDateFunction, bCloneIfNeeded:=True)

        ucrChkSpecifyDateBreaks.SetRCode(clsYScaleDateFunction, bCloneIfNeeded:=True)
        ucrInputDateBreakTime.SetRCode(clsDatePeriodOperator, bCloneIfNeeded:=True)
        ucrNudDateBreakNumber.SetRCode(clsDatePeriodOperator, bCloneIfNeeded:=True)

        ucrChkAddMean.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddMedian.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddTerciles.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)

        bRCodeSet = True
        AddRemoveTheme()
        AddRemoveLabs()
        AddRemoveXLabs()
        AddRemoveYLabs()
        AddRemoveSpecifyXAxisTickMarks()
        AddRemoveSpecifyYAxisTickMarks()
        AddRemoveHline()
        AddRemovePanelBorder()
        AddRemoveDateBreaks()
    End Sub

    Private Sub AddRemoveHline()
        If bRCodeSet Then
            If ucrChkAddMean.Checked Then
                clsBaseOperator.AddParameter("hlinemean", clsRFunctionParameter:=clsGeomHlineMean, iPosition:=20)
            Else
                clsBaseOperator.RemoveParameterByName("hlinemean")
            End If

            If ucrChkAddMedian.Checked Then
                clsBaseOperator.AddParameter("hlinemedian", clsRFunctionParameter:=clsGeomHlineMedian, iPosition:=21)
            Else
                clsBaseOperator.RemoveParameterByName("hlinemedian")
            End If

            If ucrChkAddTerciles.Checked Then
                clsBaseOperator.AddParameter("hlinelowertercile", clsRFunctionParameter:=clsGeomHlineLowerTercile, iPosition:=22)
                clsBaseOperator.AddParameter("hlineuppertercile", clsRFunctionParameter:=clsGeomHlineUpperTercile, iPosition:=23)
            Else
                clsBaseOperator.RemoveParameterByName("hlinelowertercile")
                clsBaseOperator.RemoveParameterByName("hlineuppertercile")
            End If
        End If
    End Sub

    Private Sub ucrChkAddMean_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddMean.ControlValueChanged, ucrChkAddTerciles.ControlValueChanged, ucrChkAddMedian.ControlValueChanged
        AddRemoveHline()
    End Sub

    Private Sub AddRemoveTheme()
        If clsThemeFunction.iParameterCount > 0 Then
            ' The position MUST be larger than the position of the theme_* argument
            ' Otherwise the choice of theme will overwrite the options selected here.
            ' Currently set to large value as no reason this cannot be at the end currently
            clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        Else
            clsBaseOperator.RemoveParameterByName("theme")
        End If
    End Sub

    Private Sub AddRemoveLabs()
        If bRCodeSet Then
            If Not ucrInputGraphTitle.IsEmpty() OrElse Not ucrInputGraphSubTitle.IsEmpty() OrElse Not ucrInputGraphcCaption.IsEmpty() Then
                clsBaseOperator.AddParameter("labs", clsRFunctionParameter:=clsLabsFunction)
            Else
                clsBaseOperator.RemoveParameterByName("labs")
            End If
        End If
    End Sub

    Private Sub AddRemoveXLabs()
        If bRCodeSet Then
            If rdoNoTitleXAxisTitle.Checked OrElse (rdoSpecifyXAxisTitle.Checked AndAlso Not ucrInputXAxisTitle.IsEmpty()) Then
                clsBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsXLabsFunction)
            Else
                clsBaseOperator.RemoveParameterByName("xlab")
            End If
        End If
    End Sub

    Private Sub AddRemoveYLabs()
        If bRCodeSet Then
            If rdoNoYAxisTitle.Checked OrElse (rdoSpecifyYAxisTitle.Checked AndAlso Not ucrInputYAxisTitle.IsEmpty()) Then
                clsBaseOperator.AddParameter("ylab", clsRFunctionParameter:=clsYLabsFunction)
            Else
                clsBaseOperator.RemoveParameterByName("ylab")
            End If
        End If
    End Sub

    Private Sub SetXLabel()
        If bRCodeSet Then
            If rdoAutoXAxis.Checked Then
                clsXLabsFunction.RemoveParameterByName("label")
            ElseIf rdoNoTitleXAxisTitle.Checked Then
                clsXLabsFunction.AddParameter("label", Chr(34) & Chr(34))
            Else
                clsXLabsFunction.AddParameter("label", Chr(34) & ucrInputXAxisTitle.GetText() & Chr(34))
            End If
            AddRemoveXLabs()
        End If
    End Sub

    Private Sub SetYLabel()
        If bRCodeSet Then
            If rdoAutoYAxis.Checked Then
                clsYLabsFunction.RemoveParameterByName("label")
            ElseIf rdoNoYAxisTitle.Checked Then
                clsYLabsFunction.AddParameter("label", Chr(34) & Chr(34))
            Else
                clsYLabsFunction.AddParameter("label", Chr(34) & ucrInputYAxisTitle.GetText() & Chr(34))
            End If
            AddRemoveYLabs()
        End If
    End Sub

    Private Sub ucrPnlXAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlXAxisTitle.ControlValueChanged, ucrInputXAxisTitle.ControlValueChanged
        SetXLabel()
    End Sub

    Private Sub ucrPnlYAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrPnlYAxisTitle.ControlValueChanged, ucrInputYAxisTitle.ControlValueChanged
        SetYLabel()
    End Sub

    Private Sub AddRemoveSpecifyXAxisTickMarks()
        If bRCodeSet Then
            If ucrChkSpecifyXAxisTickMarks.Checked AndAlso Not ucrInputXTo.IsEmpty AndAlso Not ucrInputXFrom.IsEmpty AndAlso Not ucrInputXInStepsOf.IsEmpty Then
                clsBaseOperator.AddParameter("scale_x_continuous", clsRFunctionParameter:=clsXScaleContinuousFunction)
                clsXScaleContinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsXScalecontinuousSeqFunction)

            Else
                clsXScaleContinuousFunction.RemoveParameterByName("breaks")
                clsBaseOperator.RemoveParameterByName("scale_x_continuous")
            End If
        End If
    End Sub

    Private Sub AddRemoveSpecifyYAxisTickMarks()
        If bRCodeSet Then
            If ucrChkSpecifyYAxisTickMarks.Checked AndAlso Not ucrInputYTo.IsEmpty AndAlso Not ucrInputYFrom.IsEmpty AndAlso Not ucrInputYInStepsOf.IsEmpty Then
                clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=1)
                clsBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsYScaleContinuousFunction)
                clsBaseOperator.RemoveParameterByName("scale_y_date")
            ElseIf ucrChkLabelForDays.Checked Then
                clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsAsDate, iPosition:=1)
                clsBaseOperator.RemoveParameterByName("scale_y_continuous")
                clsBaseOperator.AddParameter("scale_y_date", clsRFunctionParameter:=clsYScaleDateFunction)
            Else
                clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=1)
                clsBaseOperator.RemoveParameterByName("scale_y_continuous")
                clsBaseOperator.RemoveParameterByName("scale_y_date")
            End If
        End If
    End Sub

    Private Sub ucrInputGraphTitle_ControlValueChanged() Handles ucrInputGraphTitle.ControlValueChanged, ucrInputGraphSubTitle.ControlValueChanged, ucrInputGraphcCaption.ControlValueChanged
        AddRemoveLabs()
    End Sub

    Private Sub AddRemoveGraphTitleSize()
        If ucrNudTitleSize.GetText <> "" Then
            clsThemeFunction.AddParameter("plot.title", clsRFunctionParameter:=clsPlotElementTitle)
        Else
            clsThemeFunction.RemoveParameterByName("plot.title")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveGraphSubTitleSize()
        If ucrNudSubTitleSize.GetText <> "" Then
            clsThemeFunction.AddParameter("plot.subtitle", clsRFunctionParameter:=clsPlotElementSubTitle)
        Else
            clsThemeFunction.RemoveParameterByName("plot.subtitle")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveGraphCaptionSize()
        If ucrNudCaptionSize.GetText <> "" Then
            clsThemeFunction.AddParameter("plot.caption", clsRFunctionParameter:=clsPlotElementCaption)
        Else
            clsThemeFunction.RemoveParameterByName("plot.caption")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveXAxisTitleSize()
        If ucrNudXAxisTitleSize.GetText <> "" Then
            clsThemeFunction.AddParameter("axis.title.x", clsRFunctionParameter:=clsXElementTitle)
        Else
            clsThemeFunction.RemoveParameterByName("axis.title.x")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveYAxisTitleSize()
        If ucrNudYAxisTitleSize.GetText <> "" Then
            clsThemeFunction.AddParameter("axis.title.y", clsRFunctionParameter:=clsYElementTitle)
        Else
            clsThemeFunction.RemoveParameterByName("axis.title.y")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveAngleSizeXAxis()
        If bRCodeSet Then
            If (ucrChkXAxisAngle.Checked AndAlso ucrNudXAxisAngle.GetText <> "") OrElse (ucrChkXAxisLabelSize.Checked AndAlso ucrNudXaxisLabelSize.GetText <> "") Then
                clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsXElementLabels)
            Else
                clsThemeFunction.RemoveParameterByName("axis.text.x")
            End If
            AddRemoveTheme()
        End If
    End Sub

    Private Sub AddRemoveAngleSizeYAxis()
        If (ucrChkYAxisAngle.Checked AndAlso ucrNudYAxisAngle.GetText <> "") OrElse (ucrChkYAxisLabelSize.Checked AndAlso ucrNudYAxisLabelSize.GetText <> "") Then
            clsThemeFunction.AddParameter("axis.text.y", clsRFunctionParameter:=clsYElementLabels)
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.y")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemovePanelBackground()
        If (ucrChkPnlBackgroundColour.Checked AndAlso Not UcrInputPnlBackgroundColour.IsEmpty()) OrElse (UcrChkPnlBackgroundFill.Checked AndAlso Not UcrInputPnlBackgroundFill.IsEmpty()) OrElse (UcrChkPnlBackgroundLineType.Checked AndAlso Not UcrInputPnlBackgroundLinetype.IsEmpty()) OrElse (UcrChkPnlBackgroundSize.Checked AndAlso ucrNudPnlBackgroundSize.GetText <> "") Then
            clsThemeFunction.AddParameter("panel.background", clsRFunctionParameter:=clsPanelBackgroundElementRect)
        Else
            clsThemeFunction.RemoveParameterByName("panel.background")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemovePanelGridMajor()
        If (UcrChkMajorGridLineColour.Checked AndAlso Not UcrInputMajorGridLineColour.IsEmpty()) OrElse (UcrChkMajorGridLinetype.Checked AndAlso Not UcrInputMajorGridLineLinetype.IsEmpty()) OrElse (UcrChkMajorGridLineSize.Checked AndAlso UcrNudMajorGridLineSize.GetText <> "") Then
            clsThemeFunction.AddParameter("panel.grid.major", clsRFunctionParameter:=clsElementPanelGridMajor)
        Else
            clsThemeFunction.RemoveParameterByName("panel.grid.major")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemovePanelGridMinor()
        If (UcrChkMinorGridLineColour.Checked AndAlso Not UcrInputMinorGridLineColour.IsEmpty()) OrElse (UcrChkMinorGridLineType.Checked AndAlso Not UcrInputMinorGridLineTpe.IsEmpty()) OrElse (UcrChkMinorGridLineSize.Checked AndAlso UcrNudMinorGridLineSize.GetText <> "") Then
            clsThemeFunction.AddParameter("panel.grid.minor", clsRFunctionParameter:=clsElementPanelGridMinor)
        Else
            clsThemeFunction.RemoveParameterByName("panel.grid.minor")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemovePanelBorder()
        If bRCodeSet Then
            If (ucrChkBorderColour.Checked AndAlso Not ucrInputBorderColour.IsEmpty()) OrElse (ucrChkBorderLineType.Checked AndAlso Not ucrInputBorderLinetype.IsEmpty()) OrElse (UcrChkBorderSize.Checked AndAlso ucrNudBorderSize.GetText <> "") Then
                clsThemeFunction.AddParameter("panel.border", clsRFunctionParameter:=clsPanelBorderElementRect)
            Else
                clsThemeFunction.RemoveParameterByName("panel.border")
            End If
            AddRemoveTheme()
        End If
    End Sub

    Private Sub ucrChkPnlBackgroundColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPnlBackgroundColour.ControlValueChanged, UcrChkPnlBackgroundFill.ControlValueChanged, UcrChkPnlBackgroundLineType.ControlValueChanged, UcrChkPnlBackgroundSize.ControlValueChanged
        AddRemovePanelBackground()
    End Sub

    Private Sub UcrChkMajorGridLineColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrChkMajorGridLineColour.ControlValueChanged, UcrChkMajorGridLinetype.ControlValueChanged, UcrChkMajorGridLineSize.ControlValueChanged
        AddRemovePanelGridMajor()
    End Sub

    Private Sub UcrChkMinorGridLineColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrChkMinorGridLineColour.ControlValueChanged, UcrChkMinorGridLineType.ControlValueChanged, UcrChkMinorGridLineSize.ControlValueChanged
        AddRemovePanelGridMinor()
    End Sub

    Private Sub UcrChkTitleSize_ControlValueChanged(ucrChangedControl As ucrCore)
        AddRemoveGraphTitleSize()
    End Sub

    Private Sub UcrChkSubTitleSize_ControlValueChanged(ucrChangedControl As ucrCore)
        AddRemoveGraphSubTitleSize()
    End Sub

    Private Sub UcrChkCaptionSize_ControlValueChanged(ucrChangedControl As ucrCore)
        AddRemoveGraphCaptionSize()
    End Sub

    Private Sub UcrChkXAxisTitleSzie_ControlValueChanged(ucrChangedControl As ucrCore)
        AddRemoveXAxisTitleSize()
    End Sub

    Private Sub UcrChkYAxisTitleSzie_ControlValueChanged(ucrChangedControl As ucrCore)
        AddRemoveYAxisTitleSize()
    End Sub

    Private Sub ucrChkXAxisLabelSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkXAxisLabelSize.ControlValueChanged, ucrChkXAxisAngle.ControlValueChanged
        AddRemoveAngleSizeXAxis()
    End Sub

    Private Sub ucrInputXFrom_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputXFrom.ControlContentsChanged, ucrInputXFrom.ControlContentsChanged, ucrInputXInStepsOf.ControlContentsChanged, ucrChkSpecifyXAxisTickMarks.ControlValueChanged
        AddRemoveSpecifyXAxisTickMarks()
    End Sub
    Private Sub ucrChkYAxisLabelSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkYAxisLabelSize.ControlValueChanged, ucrChkYAxisAngle.ControlValueChanged
        AddRemoveAngleSizeYAxis()
    End Sub

    Private Sub ucrInputYFrom_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputYFrom.ControlContentsChanged, ucrInputYFrom.ControlContentsChanged, ucrInputYInStepsOf.ControlContentsChanged, ucrChkSpecifyYAxisTickMarks.ControlValueChanged, ucrChkLabelForDays.ControlValueChanged
        AddRemoveSpecifyYAxisTickMarks()
    End Sub

    Private Sub ucrChkBorderColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBorderColour.ControlValueChanged, ucrChkBorderLineType.ControlValueChanged, UcrChkBorderSize.ControlValueChanged
        AddRemovePanelBorder()
    End Sub

    Private Sub ucrChkLabelForDays_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabelForDays.ControlValueChanged, ucrChkSpecifyYAxisTickMarks.ControlValueChanged
        If ucrChangedControl.Equals(ucrChkSpecifyYAxisTickMarks) AndAlso ucrChkSpecifyYAxisTickMarks.Checked Then
            ucrChkLabelForDays.Checked = False
        ElseIf ucrChangedControl.Equals(ucrChkLabelForDays) AndAlso ucrChkLabelForDays.Checked Then
            ucrChkSpecifyYAxisTickMarks.Checked = False
        End If
    End Sub

    Private Sub ucrChkSpecifyDateBreaks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSpecifyDateBreaks.ControlValueChanged, ucrInputDateBreakTime.ControlValueChanged, ucrNudDateBreakNumber.ControlValueChanged
        AddRemoveDateBreaks()
    End Sub

    Private Sub AddRemoveDateBreaks()
        If bRCodeSet Then
            If ucrChkSpecifyDateBreaks.Checked AndAlso ucrNudDateBreakNumber.GetText <> "" AndAlso ucrInputDateBreakTime.GetText <> "" Then
                clsYScaleDateFunction.AddParameter("date_breaks", clsROperatorParameter:=clsDatePeriodOperator)
            Else
                clsYScaleDateFunction.RemoveParameterByName("date_breaks")
            End If
        End If
    End Sub
End Class