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

Imports instat
Imports instat.Translations
Public Class sdgPICSARainfallGraph
    Private bControlsInitialised As Boolean = False
    Public clsBaseOperator As ROperator
    Public clsLabsFunction, clsXLabsFunction, clsYLabsFunction As RFunction
    Public clsXScaleContinuousFunction, clsYScaleContinuousFunction As New RFunction
    Public clsCLimitsYContinuous, clsCLimitsYDate As New RFunction
    Public clsXScalecontinuousSeqFunction, clsYScaleContinuousSeqFunction As New RFunction
    Public clsYScaleDateFunction As New RFunction
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
    Private dctDateStartMonths As New Dictionary(Of String, String)
    Private dctLabelTypes As New Dictionary(Of String, String)

    Private clsDatePeriodOperator As New ROperator

    Private clsGeomHlineMean As New RFunction
    Private clsGeomHlineMedian As New RFunction
    Private clsGeomHlineLowerTercile As New RFunction
    Private clsGeomHlineUpperTercile As New RFunction

    Private clsAnnotateMeanLine As New RFunction
    Private clsRoundMeanY As New RFunction
    Private clsPasteMeanY As New RFunction
    Private clsAnnotateMedianLine As New RFunction
    Private clsRoundMedianY As New RFunction
    Private clsPasteMedianY As New RFunction
    Private clsAnnotateLowerTercileLine As New RFunction
    Private clsRoundLowerTercileY As New RFunction
    Private clsPasteLowerTercileY As New RFunction
    Private clsAnnotateUpperTercileLine As New RFunction
    Private clsRoundUpperTercileY As New RFunction
    Private clsPasteUpperTercileY As New RFunction

    Private clsRaesFunction As New RFunction
    Private clsAsDate As New RFunction
    Private clsAsNumeric As New RFunction

    Private Sub sdgPICSARainfallGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

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

        ' X-Axis 
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
        ucrChkSpecifyXAxisTickMarks.SetParameter(New RParameter("breaks"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrInputXFrom.SetParameter(New RParameter("from"))
        ucrInputXFrom.SetValidationTypeAsNumeric()
        ucrInputXFrom.AddQuotesIfUnrecognised = False

        ucrInputXTo.SetParameter(New RParameter("to"))
        ucrInputXTo.SetValidationTypeAsNumeric()
        ucrInputXTo.AddQuotesIfUnrecognised = False

        ucrInputXInStepsOf.SetParameter(New RParameter("by"))
        ucrInputXInStepsOf.SetValidationTypeAsNumeric()
        ucrInputXInStepsOf.AddQuotesIfUnrecognised = False

        ' Y-Axis
        ucrPnlYAxisType.AddRadioButton(rdoYNumeric)
        ucrPnlYAxisType.AddRadioButton(rdoYDate)
        ucrPnlYAxisType.AddParameterValueFunctionNamesCondition(rdoYNumeric, "y", "as.Date", False)
        ucrPnlYAxisType.AddParameterValueFunctionNamesCondition(rdoYDate, "y", "as.Date", True)

        'TODO not yet implemented need to ensure correct date will be used (2015/16 depending on origin date)
        ucrInputYSpecifyLowerLimitDate.Visible = False
        ucrInputYSpecifyUpperLimitDate.Visible = False

        ucrPnlYAxisType.AddToLinkedControls(ucrChkSpecifyYAxisTickMarks, {rdoYNumeric}, bNewLinkedHideIfParameterMissing:=True)
        'TODO these two will not be only for numeric once limits for dates implemented
        ucrPnlYAxisType.AddToLinkedControls(ucrChkYSpecifyLowerLimit, {rdoYNumeric}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlYAxisType.AddToLinkedControls(ucrChkYSpecifyUpperLimit, {rdoYNumeric}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlYAxisType.AddToLinkedControls(ucrInputDateDisplayFormat, {rdoYDate}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Day Month (1 Jan)")
        ucrPnlYAxisType.AddToLinkedControls(ucrChkSpecifyDateBreaks, {rdoYDate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlYAxisType.AddToLinkedControls(ucrInputStartMonth, {rdoYDate}, bNewLinkedHideIfParameterMissing:=True)
        'TODO controls not yet implemented
        'ucrPnlYAxisType.AddToLinkedControls(ucrInputYSpecifyLowerLimitDate, {rdoYDate}, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlYAxisType.AddToLinkedControls(ucrInputYSpecifyUpperLimitDate, {rdoYDate}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkYSpecifyLowerLimit.SetText("Specify Lower Limit")
        ucrChkYSpecifyLowerLimit.AddParameterValuesCondition(True, "min", "NA", False)
        ucrChkYSpecifyLowerLimit.AddParameterValuesCondition(False, "min", "NA", True)
        ucrChkYSpecifyLowerLimit.AddToLinkedControls(ucrInputYSpecifyLowerLimitNumeric, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputYSpecifyLowerLimitNumeric.SetParameter(New RParameter("min", 0))
        ucrInputYSpecifyLowerLimitNumeric.SetValidationTypeAsNumeric()
        ucrInputYSpecifyLowerLimitNumeric.SetValuesToIgnore({"NA"})
        ucrInputYSpecifyLowerLimitNumeric.AddQuotesIfUnrecognised = False

        ucrChkYSpecifyUpperLimit.SetText("Specify Upper Limit")
        ucrChkYSpecifyUpperLimit.AddParameterValuesCondition(True, "max", "NA", False)
        ucrChkYSpecifyUpperLimit.AddParameterValuesCondition(False, "max", "NA", True)
        ucrChkYSpecifyUpperLimit.AddToLinkedControls(ucrInputYSpecifyUpperLimitNumeric, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputYSpecifyUpperLimitNumeric.SetParameter(New RParameter("max", 1))
        ucrInputYSpecifyUpperLimitNumeric.SetValidationTypeAsNumeric()
        ucrInputYSpecifyUpperLimitNumeric.SetValuesToIgnore({"NA"})
        ucrInputYSpecifyUpperLimitNumeric.AddQuotesIfUnrecognised = False

        ucrChkSpecifyYAxisTickMarks.SetText("Specify Breaks")
        ucrChkSpecifyYAxisTickMarks.SetParameter(New RParameter("breaks", 1), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkSpecifyYAxisTickMarks.AddToLinkedControls({ucrInputYFrom, ucrInputYTo, ucrInputYInStepsOf}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputYFrom.SetParameter(New RParameter("from"))
        ucrInputYFrom.SetValidationTypeAsNumeric()
        ucrInputYFrom.AddQuotesIfUnrecognised = False

        ucrInputYTo.SetParameter(New RParameter("to"))
        ucrInputYTo.SetValidationTypeAsNumeric()
        ucrInputYTo.AddQuotesIfUnrecognised = False

        ucrInputYInStepsOf.SetParameter(New RParameter("by"))
        ucrInputYInStepsOf.SetValidationTypeAsNumeric()
        ucrInputYInStepsOf.AddQuotesIfUnrecognised = False

        ucrInputDateDisplayFormat.SetParameter(New RParameter("date_labels", 0))
        dctLabelForDays.Add("Day Number (1-366)", Chr(34) & "%j" & Chr(34))
        dctLabelForDays.Add("Day Month (1 Jan)", Chr(34) & "%d %b" & Chr(34))
        dctLabelForDays.Add("Day Month Full (1 January)", Chr(34) & "%d %B" & Chr(34))
        ucrInputDateDisplayFormat.SetItems(dctLabelForDays)
        ucrInputDateDisplayFormat.SetDropDownStyleAsNonEditable()
        ucrInputDateDisplayFormat.SetLinkedDisplayControl(lblDateDisplayFormat)

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

        ucrInputStartMonth.SetParameter(New RParameter("origin", 1))
        ucrInputStartMonth.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctStartMonthOriginDates))
        ucrInputStartMonth.SetDropDownStyleAsNonEditable()
        ucrInputStartMonth.SetLinkedDisplayControl(lblStartMonth)

        ucrChkYAxisAngle.AddToLinkedControls(ucrNudYAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkYAxisLabelSize.AddToLinkedControls(ucrNudYAxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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

        ucrChkAddMeanLabel.SetText("Add Label")
        ucrChkAddMeanLabel.AddParameterPresentCondition(True, "annotate_mean", True)
        ucrChkAddMeanLabel.AddParameterPresentCondition(False, "annotate_mean", False)
        ucrChkAddMeanLabel.AddToLinkedControls(ucrInputMeanLineType, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddMeanLabel.AddToLinkedControls(ucrInputMeanLineLabelText, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddMeanLabel.AddToLinkedControls(ucrChkMeanLineLabelIncludeValue, {True}, bNewLinkedHideIfParameterMissing:=True)

        dctLabelTypes.Add("Text", Chr(34) & "text" & Chr(34))
        dctLabelTypes.Add("Textbox", Chr(34) & "label" & Chr(34))

        ucrInputMeanLineType.SetLinkedDisplayControl(lblMeanLineType)
        ucrInputMeanLineType.SetParameter(New RParameter("geom", iNewPosition:=0))
        ucrInputMeanLineType.SetItems(dctLabelTypes)
        ucrInputMeanLineType.SetDropDownStyleAsNonEditable()

        ucrInputMeanLineLabelText.SetLinkedDisplayControl(lblMeanLineLabelText)
        ucrInputMeanLineLabelText.SetParameter(New RParameter("0", 0, bNewIncludeArgumentName:=False))

        ucrChkMeanLineLabelIncludeValue.SetText("Include value after label")
        ucrChkMeanLineLabelIncludeValue.AddParameterPresentCondition(True, "1", True)
        ucrChkMeanLineLabelIncludeValue.AddParameterPresentCondition(False, "1", False)

        ' Median Line
        ucrChkAddMedian.SetText("Add Median Line")
        ucrChkAddMedian.AddParameterPresentCondition(True, "hlinemedian", True)
        ucrChkAddMedian.AddParameterPresentCondition(False, "hlinemedian", False)
        ucrChkAddMedian.AddToLinkedControls(ucrChkAddMedianLabel, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddMedianLabel.SetText("Add Label")
        ucrChkAddMedianLabel.AddParameterPresentCondition(True, "annotate_median", True)
        ucrChkAddMedianLabel.AddParameterPresentCondition(False, "annotate_median", False)
        ucrChkAddMedianLabel.AddToLinkedControls(ucrInputMedianLineType, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddMedianLabel.AddToLinkedControls(ucrInputMedianLineLabelText, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddMedianLabel.AddToLinkedControls(ucrChkMedianLineLabelIncludeValue, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputMedianLineType.SetLinkedDisplayControl(lblMedianLineType)
        ucrInputMedianLineType.SetParameter(New RParameter("geom", iNewPosition:=0))
        ucrInputMedianLineType.SetItems(dctLabelTypes)
        ucrInputMedianLineType.SetDropDownStyleAsNonEditable()

        ucrInputMedianLineLabelText.SetLinkedDisplayControl(lblMedianLineLabelText)
        ucrInputMedianLineLabelText.SetParameter(New RParameter("0", 0, bNewIncludeArgumentName:=False))

        ucrChkMedianLineLabelIncludeValue.SetText("Include value after label")
        ucrChkMedianLineLabelIncludeValue.AddParameterPresentCondition(True, "1", True)
        ucrChkMedianLineLabelIncludeValue.AddParameterPresentCondition(False, "1", False)

        ' Tercile Lines
        ucrChkAddTerciles.SetText("Add Tercile Lines")
        ucrChkAddTerciles.AddParameterPresentCondition(True, "hlinelowertercile", True)
        ucrChkAddTerciles.AddParameterPresentCondition(False, "hlinelowertercile", False)
        ucrChkAddTerciles.AddToLinkedControls(ucrChkAddTercilesLabel, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddTercilesLabel.SetText("Add Labels")
        ucrChkAddTercilesLabel.AddParameterPresentCondition(True, "annotate_lower_tercile", True)
        ucrChkAddTercilesLabel.AddParameterPresentCondition(False, "annotate_lower_tercile", False)
        ucrChkAddTercilesLabel.AddToLinkedControls(ucrInputTercilesLineType, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddTercilesLabel.AddToLinkedControls(ucrInputTercilesLineLabelTextLower, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddTercilesLabel.AddToLinkedControls(ucrInputTercilesLineLabelTextUpper, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddTercilesLabel.AddToLinkedControls(ucrChkTercilesLineLabelIncludeValue, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputTercilesLineType.SetLinkedDisplayControl(lblTercilesLineType)
        ucrInputTercilesLineType.SetParameter(New RParameter("geom", iNewPosition:=0))
        ucrInputTercilesLineType.SetItems(dctLabelTypes)
        ucrInputTercilesLineType.SetDropDownStyleAsNonEditable()

        ucrInputTercilesLineLabelTextLower.SetLinkedDisplayControl(lblTercilesLineLabelTextLower)
        ucrInputTercilesLineLabelTextLower.SetParameter(New RParameter("0", 0, bNewIncludeArgumentName:=False))

        ucrInputTercilesLineLabelTextUpper.SetLinkedDisplayControl(lblTercilesLineLabelTextUpper)
        ucrInputTercilesLineLabelTextUpper.SetParameter(New RParameter("0", 0, bNewIncludeArgumentName:=False))

        ucrChkTercilesLineLabelIncludeValue.SetText("Include value after label")
        ucrChkTercilesLineLabelIncludeValue.AddParameterPresentCondition(True, "1", True)
        ucrChkTercilesLineLabelIncludeValue.AddParameterPresentCondition(False, "1", False)

        'H Line Format
        ucrChkHLineColour.SetText("Colour")
        ucrChkHLineColour.SetParameter(New RParameter("colour"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkHLineColour.AddToLinkedControls(ucrInputHLineColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Black")
        ucrInputHLineColour.SetParameter(New RParameter("colour"))
        ucrInputHLineColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        ucrInputHLineColour.SetDropDownStyleAsNonEditable()

        ucrChkHLineType.SetText("Line Type")
        ucrChkHLineType.SetParameter(New RParameter("linetype"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkHLineType.AddToLinkedControls(ucrInputHLineType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Solid")
        ucrInputHLineType.SetParameter(New RParameter("linetype"))
        ucrInputHLineType.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        ucrInputHLineType.SetDropDownStyleAsNonEditable()

        ucrChkHLineSize.SetText("Size")
        ucrChkHLineSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkHLineSize.AddToLinkedControls(ucrNudHLineSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudHLineSize.SetParameter(New RParameter("size"))
        ucrNudHLineSize.Increment = 0.1
        ucrNudHLineSize.DecimalPlaces = 1
        ucrNudHLineSize.Minimum = 0

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewOperator As ROperator, Optional clsNewLabsFunction As RFunction = Nothing, Optional clsNewXLabsFunction As RFunction = Nothing, Optional clsNewYLabsFunction As RFunction = Nothing, Optional clsNewXScaleContinuousFunction As RFunction = Nothing, Optional clsNewYScaleContinuousFunction As RFunction = Nothing, Optional clsNewYScaleDateFunction As RFunction = Nothing, Optional clsNewThemeFunction As RFunction = Nothing, Optional dctNewThemeFunctions As Dictionary(Of String, RFunction) = Nothing, Optional clsNewGeomhlineMean As RFunction = Nothing, Optional clsNewGeomhlineMedian As RFunction = Nothing, Optional clsNewGeomhlineLowerTercile As RFunction = Nothing, Optional clsNewGeomhlineUpperTercile As RFunction = Nothing, Optional clsNewRaesFunction As RFunction = Nothing, Optional clsNewAsDate As RFunction = Nothing, Optional clsNewAsNumeric As RFunction = Nothing, Optional clsNewDatePeriodOperator As ROperator = Nothing, Optional clsNewAnnotateMeanLine As RFunction = Nothing, Optional clsNewRoundMeanY As RFunction = Nothing, Optional clsNewPasteMeanY As RFunction = Nothing, Optional clsNewAnnotateMedianLine As RFunction = Nothing, Optional clsNewRoundMedianY As RFunction = Nothing, Optional clsNewPasteMedianY As RFunction = Nothing, Optional clsNewAnnotateLowerTercileLine As RFunction = Nothing, Optional clsNewRoundLowerTercileY As RFunction = Nothing, Optional clsNewPasteLowerTercileY As RFunction = Nothing, Optional clsNewAnnotateUpperTercileLine As RFunction = Nothing, Optional clsNewRoundUpperTercileY As RFunction = Nothing, Optional clsNewPasteUpperTercileY As RFunction = Nothing, Optional bReset As Boolean = False)
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

        clsAnnotateMeanLine = clsNewAnnotateMeanLine
        clsRoundMeanY = clsNewRoundMeanY
        clsPasteMeanY = clsNewPasteMeanY
        clsAnnotateMedianLine = clsNewAnnotateMedianLine
        clsRoundMedianY = clsNewRoundMedianY
        clsPasteMedianY = clsNewPasteMedianY
        clsAnnotateLowerTercileLine = clsNewAnnotateLowerTercileLine
        clsRoundLowerTercileY = clsNewRoundLowerTercileY
        clsPasteLowerTercileY = clsNewPasteLowerTercileY
        clsAnnotateUpperTercileLine = clsNewAnnotateUpperTercileLine
        clsRoundUpperTercileY = clsNewRoundUpperTercileY
        clsPasteUpperTercileY = clsNewPasteUpperTercileY

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

        ucrNudTitleSize.SetRCode(clsPlotElementTitle, bReset, bCloneIfNeeded:=True)
        ucrNudSubTitleSize.SetRCode(clsPlotElementSubTitle, bReset, bCloneIfNeeded:=True)
        ucrNudCaptionSize.SetRCode(clsPlotElementCaption, bReset, bCloneIfNeeded:=True)

        ucrNudXAxisTitleSize.SetRCode(clsXElementTitle, bReset, bCloneIfNeeded:=True)
        ucrNudYAxisTitleSize.SetRCode(clsYElementTitle, bReset, bCloneIfNeeded:=True)

        ucrChkXAxisAngle.SetRCode(clsXElementLabels, bReset, bCloneIfNeeded:=True)
        ucrChkXAxisLabelSize.SetRCode(clsXElementLabels, bReset, bCloneIfNeeded:=True)
        ucrNudXAxisAngle.SetRCode(clsXElementLabels, bReset, bCloneIfNeeded:=True)
        ucrNudXaxisLabelSize.SetRCode(clsXElementLabels, bReset, bCloneIfNeeded:=True)

        ucrNudYAxisAngle.SetRCode(clsYElementLabels, bReset, bCloneIfNeeded:=True)
        ucrNudYAxisLabelSize.SetRCode(clsYElementLabels, bReset, bCloneIfNeeded:=True)
        ucrChkYAxisAngle.SetRCode(clsYElementLabels, bReset, bCloneIfNeeded:=True)
        ucrChkYAxisLabelSize.SetRCode(clsYElementLabels, bReset, bCloneIfNeeded:=True)

        'Background
        ucrChkPnlBackgroundColour.SetRCode(clsPanelBackgroundElementRect, bReset, bCloneIfNeeded:=True)
        UcrInputPnlBackgroundColour.SetRCode(clsPanelBackgroundElementRect, bReset, bCloneIfNeeded:=True)
        UcrChkPnlBackgroundFill.SetRCode(clsPanelBackgroundElementRect, bReset, bCloneIfNeeded:=True)
        UcrInputPnlBackgroundFill.SetRCode(clsPanelBackgroundElementRect, bReset, bCloneIfNeeded:=True)
        UcrChkPnlBackgroundLineType.SetRCode(clsPanelBackgroundElementRect, bReset, bCloneIfNeeded:=True)
        UcrInputPnlBackgroundLinetype.SetRCode(clsPanelBackgroundElementRect, bReset, bCloneIfNeeded:=True)
        UcrChkPnlBackgroundSize.SetRCode(clsPanelBackgroundElementRect, bReset, bCloneIfNeeded:=True)
        ucrNudPnlBackgroundSize.SetRCode(clsPanelBackgroundElementRect, bReset, bCloneIfNeeded:=True)

        UcrChkMajorGridLineColour.SetRCode(clsElementPanelGridMajor, bReset, bCloneIfNeeded:=True)
        UcrInputMajorGridLineColour.SetRCode(clsElementPanelGridMajor, bReset, bCloneIfNeeded:=True)
        UcrChkMajorGridLinetype.SetRCode(clsElementPanelGridMajor, bReset, bCloneIfNeeded:=True)
        UcrInputMajorGridLineLinetype.SetRCode(clsElementPanelGridMajor, bReset, bCloneIfNeeded:=True)
        UcrChkMajorGridLineSize.SetRCode(clsElementPanelGridMajor, bReset, bCloneIfNeeded:=True)
        UcrNudMajorGridLineSize.SetRCode(clsElementPanelGridMajor, bReset, bCloneIfNeeded:=True)

        UcrChkMinorGridLineColour.SetRCode(clsElementPanelGridMinor, bReset, bCloneIfNeeded:=True)
        UcrInputMinorGridLineColour.SetRCode(clsElementPanelGridMinor, bReset, bCloneIfNeeded:=True)
        UcrChkMinorGridLineType.SetRCode(clsElementPanelGridMinor, bReset, bCloneIfNeeded:=True)
        UcrInputMinorGridLineTpe.SetRCode(clsElementPanelGridMinor, bReset, bCloneIfNeeded:=True)
        UcrChkMinorGridLineSize.SetRCode(clsElementPanelGridMinor, bReset, bCloneIfNeeded:=True)
        UcrNudMinorGridLineSize.SetRCode(clsElementPanelGridMinor, bReset, bCloneIfNeeded:=True)

        ucrChkBorderColour.SetRCode(clsPanelBorderElementRect, bReset, bCloneIfNeeded:=True)
        ucrInputBorderColour.SetRCode(clsPanelBorderElementRect, bReset, bCloneIfNeeded:=True)
        ucrChkBorderLineType.SetRCode(clsPanelBorderElementRect, bReset, bCloneIfNeeded:=True)
        ucrInputBorderLinetype.SetRCode(clsPanelBorderElementRect, bReset, bCloneIfNeeded:=True)
        UcrChkBorderSize.SetRCode(clsPanelBorderElementRect, bReset, bCloneIfNeeded:=True)
        ucrNudBorderSize.SetRCode(clsPanelBorderElementRect, bReset, bCloneIfNeeded:=True)

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

        Dim clsTempParam As RParameter
        If clsYScaleContinuousFunction.ContainsParameter("limits") Then
            clsTempParam = clsYScaleContinuousFunction.GetParameter("limits")
            If clsTempParam.bIsFunction AndAlso clsTempParam.clsArgumentCodeStructure IsNot Nothing Then
                clsCLimitsYContinuous = clsTempParam.clsArgumentCodeStructure
            Else
                clsCLimitsYContinuous = New RFunction
                clsCLimitsYContinuous.SetRCommand("c")
            End If
        Else
            clsCLimitsYContinuous = New RFunction
            clsCLimitsYContinuous.SetRCommand("c")
        End If

        ucrPnlYAxisType.SetRCode(clsRaesFunction, bReset, bCloneIfNeeded:=True)

        ucrChkYSpecifyLowerLimit.SetRCode(clsCLimitsYContinuous, bReset, bCloneIfNeeded:=True)
        ucrInputYSpecifyLowerLimitNumeric.SetRCode(clsCLimitsYContinuous, bReset, bCloneIfNeeded:=True)
        ucrChkYSpecifyUpperLimit.SetRCode(clsCLimitsYContinuous, bReset, bCloneIfNeeded:=True)
        ucrInputYSpecifyUpperLimitNumeric.SetRCode(clsCLimitsYContinuous, bReset, bCloneIfNeeded:=True)

        ucrChkSpecifyXAxisTickMarks.SetRCode(clsXScaleContinuousFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSpecifyYAxisTickMarks.SetRCode(clsYScaleContinuousFunction, bReset, bCloneIfNeeded:=True)

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

        ' Limits c() function for y continuous scales
        Dim clsTempYLimitsContinuousParam As RParameter
        If clsYScaleContinuousFunction.ContainsParameter("limits") Then
            clsTempYLimitsContinuousParam = clsYScaleContinuousFunction.GetParameter("limits")
            If clsTempYLimitsContinuousParam.clsArgumentCodeStructure IsNot Nothing Then
                clsCLimitsYContinuous = clsTempYLimitsContinuousParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsCLimitsYContinuous = New RFunction
                clsCLimitsYContinuous.SetRCommand("c")
                clsCLimitsYContinuous.AddParameter("min", "0", bIncludeArgumentName:=False, iPosition:=0)
                clsCLimitsYContinuous.AddParameter("max", "NA", bIncludeArgumentName:=False, iPosition:=1)
            End If
        Else
            clsCLimitsYContinuous = New RFunction
            clsCLimitsYContinuous.SetRCommand("c")
            clsCLimitsYContinuous.AddParameter("min", "0", bIncludeArgumentName:=False, iPosition:=0)
            clsCLimitsYContinuous.AddParameter("max", "NA", bIncludeArgumentName:=False, iPosition:=1)
        End If

        ' Limits c() function for y date scales
        Dim clsTempYLimitsDateParam As RParameter
        If clsYScaleDateFunction.ContainsParameter("limits") Then
            clsTempYLimitsDateParam = clsYScaleDateFunction.GetParameter("limits")
            If clsTempYLimitsDateParam.clsArgumentCodeStructure IsNot Nothing Then
                clsCLimitsYDate = clsTempYLimitsDateParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsCLimitsYDate = New RFunction
                clsCLimitsYDate.SetRCommand("c")
                clsCLimitsYDate.AddParameter("min", "NA", bIncludeArgumentName:=False, iPosition:=0)
                clsCLimitsYDate.AddParameter("max", "NA", bIncludeArgumentName:=False, iPosition:=1)
            End If
        Else
            clsCLimitsYContinuous = New RFunction
            clsCLimitsYContinuous.SetRCommand("c")
            clsCLimitsYContinuous.AddParameter("min", "NA", bIncludeArgumentName:=False, iPosition:=0)
            clsCLimitsYContinuous.AddParameter("max", "NA", bIncludeArgumentName:=False, iPosition:=1)
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

        ' scale_y_date function is used for the days lables
        ' scale_y_date(date_label = %d %b) - for day/month option
        ' scale_y_date(date_label = %j) - for day option
        ucrInputDateDisplayFormat.SetRCode(clsYScaleDateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputStartMonth.SetRCode(clsAsDate, bReset, bCloneIfNeeded:=True)

        ucrChkSpecifyDateBreaks.SetRCode(clsYScaleDateFunction, bReset, bCloneIfNeeded:=True)
        ucrInputDateBreakTime.SetRCode(clsDatePeriodOperator, bReset, bCloneIfNeeded:=True)
        ucrNudDateBreakNumber.SetRCode(clsDatePeriodOperator, bReset, bCloneIfNeeded:=True)

        ucrChkAddMean.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddMedian.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddTerciles.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)

        ucrChkAddMeanLabel.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddMedianLabel.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)
        ucrChkAddTercilesLabel.SetRCode(clsBaseOperator, bReset, bCloneIfNeeded:=True)

        ucrInputMeanLineType.SetRCode(clsAnnotateMeanLine, bReset, bCloneIfNeeded:=True)
        ucrInputMedianLineType.SetRCode(clsAnnotateMedianLine, bReset, bCloneIfNeeded:=True)
        ucrInputTercilesLineType.AddAdditionalCodeParameterPair(clsAnnotateLowerTercileLine, New RParameter("geom", 0), iAdditionalPairNo:=1)
        ucrInputTercilesLineType.SetRCode(clsAnnotateLowerTercileLine, bReset, bCloneIfNeeded:=True)

        ucrInputMeanLineLabelText.SetRCode(clsPasteMeanY, bReset, bCloneIfNeeded:=True)
        ucrInputMedianLineLabelText.SetRCode(clsPasteMedianY, bReset, bCloneIfNeeded:=True)
        ucrInputTercilesLineLabelTextLower.SetRCode(clsPasteLowerTercileY, bReset, bCloneIfNeeded:=True)
        ucrInputTercilesLineLabelTextUpper.SetRCode(clsPasteUpperTercileY, bReset, bCloneIfNeeded:=True)

        ucrChkMeanLineLabelIncludeValue.SetRCode(clsPasteMeanY, bReset, bCloneIfNeeded:=True)
        ucrChkMedianLineLabelIncludeValue.SetRCode(clsPasteMedianY, bReset, bCloneIfNeeded:=True)
        ucrChkTercilesLineLabelIncludeValue.SetRCode(clsPasteUpperTercileY, bReset, bCloneIfNeeded:=True)

        ucrChkHLineColour.AddAdditionalCodeParameterPair(clsGeomHlineMedian, ucrChkHLineColour.GetParameter(), iAdditionalPairNo:=1)
        ucrInputHLineColour.AddAdditionalCodeParameterPair(clsGeomHlineMedian, ucrInputHLineColour.GetParameter(), iAdditionalPairNo:=1)
        ucrChkHLineType.AddAdditionalCodeParameterPair(clsGeomHlineMedian, ucrChkHLineType.GetParameter(), iAdditionalPairNo:=1)
        ucrInputHLineType.AddAdditionalCodeParameterPair(clsGeomHlineMedian, ucrInputHLineType.GetParameter(), iAdditionalPairNo:=1)
        ucrChkHLineSize.AddAdditionalCodeParameterPair(clsGeomHlineMedian, ucrChkHLineSize.GetParameter(), iAdditionalPairNo:=1)
        ucrNudHLineSize.AddAdditionalCodeParameterPair(clsGeomHlineMedian, ucrNudHLineSize.GetParameter(), iAdditionalPairNo:=1)

        ucrChkHLineColour.AddAdditionalCodeParameterPair(clsGeomHlineLowerTercile, ucrChkHLineColour.GetParameter(), iAdditionalPairNo:=2)
        ucrInputHLineColour.AddAdditionalCodeParameterPair(clsGeomHlineLowerTercile, ucrInputHLineColour.GetParameter(), iAdditionalPairNo:=2)
        ucrChkHLineType.AddAdditionalCodeParameterPair(clsGeomHlineLowerTercile, ucrChkHLineType.GetParameter(), iAdditionalPairNo:=2)
        ucrInputHLineType.AddAdditionalCodeParameterPair(clsGeomHlineLowerTercile, ucrInputHLineType.GetParameter(), iAdditionalPairNo:=2)
        ucrChkHLineSize.AddAdditionalCodeParameterPair(clsGeomHlineLowerTercile, ucrChkHLineSize.GetParameter(), iAdditionalPairNo:=2)
        ucrNudHLineSize.AddAdditionalCodeParameterPair(clsGeomHlineLowerTercile, ucrNudHLineSize.GetParameter(), iAdditionalPairNo:=2)

        ucrChkHLineColour.AddAdditionalCodeParameterPair(clsGeomHlineUpperTercile, ucrChkHLineColour.GetParameter(), iAdditionalPairNo:=3)
        ucrInputHLineColour.AddAdditionalCodeParameterPair(clsGeomHlineUpperTercile, ucrInputHLineColour.GetParameter(), iAdditionalPairNo:=3)
        ucrChkHLineType.AddAdditionalCodeParameterPair(clsGeomHlineUpperTercile, ucrChkHLineType.GetParameter(), iAdditionalPairNo:=3)
        ucrInputHLineType.AddAdditionalCodeParameterPair(clsGeomHlineUpperTercile, ucrInputHLineType.GetParameter(), iAdditionalPairNo:=3)
        ucrChkHLineSize.AddAdditionalCodeParameterPair(clsGeomHlineUpperTercile, ucrChkHLineSize.GetParameter(), iAdditionalPairNo:=3)
        ucrNudHLineSize.AddAdditionalCodeParameterPair(clsGeomHlineUpperTercile, ucrNudHLineSize.GetParameter(), iAdditionalPairNo:=3)

        ucrChkHLineColour.SetRCode(clsGeomHlineMean, bReset, bCloneIfNeeded:=True)
        ucrInputHLineColour.SetRCode(clsGeomHlineMean, bReset, bCloneIfNeeded:=True)
        ucrChkHLineType.SetRCode(clsGeomHlineMean, bReset, bCloneIfNeeded:=True)
        ucrInputHLineType.SetRCode(clsGeomHlineMean, bReset, bCloneIfNeeded:=True)
        ucrChkHLineSize.SetRCode(clsGeomHlineMean, bReset, bCloneIfNeeded:=True)
        ucrNudHLineSize.SetRCode(clsGeomHlineMean, bReset, bCloneIfNeeded:=True)

        bRCodeSet = True
        AddRemoveTheme()
        AddRemoveLabs()
        AddRemoveXLabs()
        AddRemoveYLabs()
        AddRemoveXAxisBreaks()
        AddRemoveYAxisBreaks()
        AddRemoveYLimits()
        AddRemoveAxisTextY()
        AddRemoveXAxisScalesContinuous()
        AddRemoveYAxisScales()
        AddRemoveHline()
        AddRemovePanelBorder()
        AddRemoveDateBreaks()
    End Sub

    Private Sub AddRemoveHline()
        If bRCodeSet Then
            If ucrChkAddMean.Checked Then
                clsBaseOperator.AddParameter("hlinemean", clsRFunctionParameter:=clsGeomHlineMean, iPosition:=20)
                If ucrChkAddMeanLabel.Checked Then
                    clsBaseOperator.AddParameter("annotate_mean", clsRFunctionParameter:=clsAnnotateMeanLine, iPosition:=24)
                    If ucrChkMeanLineLabelIncludeValue.Checked Then
                        clsPasteMeanY.AddParameter("1", clsRFunctionParameter:=clsRoundMeanY, bIncludeArgumentName:=False, iPosition:=1)
                    Else
                        clsPasteMeanY.RemoveParameterByName("1")
                    End If
                Else
                    clsBaseOperator.RemoveParameterByName("annotate_mean")
                End If
            Else
                clsBaseOperator.RemoveParameterByName("hlinemean")
                clsBaseOperator.RemoveParameterByName("annotate_mean")
            End If

            If ucrChkAddMedian.Checked Then
                clsBaseOperator.AddParameter("hlinemedian", clsRFunctionParameter:=clsGeomHlineMedian, iPosition:=21)
                If ucrChkAddMedianLabel.Checked Then
                    clsBaseOperator.AddParameter("annotate_median", clsRFunctionParameter:=clsAnnotateMedianLine, iPosition:=25)
                    If ucrChkMedianLineLabelIncludeValue.Checked Then
                        clsPasteMedianY.AddParameter("1", clsRFunctionParameter:=clsRoundMedianY, bIncludeArgumentName:=False, iPosition:=1)
                    Else
                        clsPasteMedianY.RemoveParameterByName("1")
                    End If
                Else
                    clsBaseOperator.RemoveParameterByName("annotate_median")
                End If
            Else
                clsBaseOperator.RemoveParameterByName("hlinemedian")
                clsBaseOperator.RemoveParameterByName("annotate_median")
            End If

            If ucrChkAddTerciles.Checked Then
                clsBaseOperator.AddParameter("hlinelowertercile", clsRFunctionParameter:=clsGeomHlineLowerTercile, iPosition:=22)
                clsBaseOperator.AddParameter("hlineuppertercile", clsRFunctionParameter:=clsGeomHlineUpperTercile, iPosition:=23)
                If ucrChkAddTercilesLabel.Checked Then
                    clsBaseOperator.AddParameter("annotate_lower_tercile", clsRFunctionParameter:=clsAnnotateLowerTercileLine, iPosition:=26)
                    clsBaseOperator.AddParameter("annotate_upper_tercile", clsRFunctionParameter:=clsAnnotateUpperTercileLine, iPosition:=27)
                    If ucrChkTercilesLineLabelIncludeValue.Checked Then
                        clsPasteLowerTercileY.AddParameter("1", clsRFunctionParameter:=clsRoundLowerTercileY, bIncludeArgumentName:=False, iPosition:=1)
                        clsPasteUpperTercileY.AddParameter("1", clsRFunctionParameter:=clsRoundUpperTercileY, bIncludeArgumentName:=False, iPosition:=1)
                    Else
                        clsPasteLowerTercileY.RemoveParameterByName("1")
                        clsPasteUpperTercileY.RemoveParameterByName("1")
                    End If
                Else
                    clsBaseOperator.RemoveParameterByName("annotate_lower_tercile")
                    clsBaseOperator.RemoveParameterByName("annotate_upper_tercile")
                End If
            Else
                clsBaseOperator.RemoveParameterByName("hlinelowertercile")
                clsBaseOperator.RemoveParameterByName("hlineuppertercile")
                clsBaseOperator.RemoveParameterByName("annotate_lower_tercile")
                clsBaseOperator.RemoveParameterByName("annotate_upper_tercile")
            End If
        End If
    End Sub

    Private Sub ucrLineControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddMean.ControlValueChanged, ucrChkAddTerciles.ControlValueChanged, ucrChkAddMedian.ControlValueChanged, ucrChkAddMeanLabel.ControlValueChanged, ucrChkAddMedianLabel.ControlValueChanged, ucrChkAddTercilesLabel.ControlValueChanged, ucrChkMeanLineLabelIncludeValue.ControlValueChanged, ucrChkMedianLineLabelIncludeValue.ControlValueChanged, ucrChkTercilesLineLabelIncludeValue.ControlValueChanged
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

    Private Sub AddRemoveXAxisBreaks()
        If bRCodeSet Then
            If ucrChkSpecifyXAxisTickMarks.Checked AndAlso Not ucrInputXTo.IsEmpty AndAlso Not ucrInputXFrom.IsEmpty AndAlso Not ucrInputXInStepsOf.IsEmpty Then
                clsXScaleContinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsXScalecontinuousSeqFunction)
            Else
                clsXScaleContinuousFunction.RemoveParameterByName("breaks")
            End If
            AddRemoveXAxisScalesContinuous()
        End If
    End Sub

    Private Sub AddRemoveXAxisScalesContinuous()
        If bRCodeSet Then
            If clsXScaleContinuousFunction.clsParameters.Count > 0 Then
                clsBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsYScaleContinuousFunction)
            Else
                clsBaseOperator.RemoveParameterByName("scale_y_continuous")
            End If
        End If
    End Sub

    Private Sub AddRemoveYAxisBreaks()
        If bRCodeSet Then
            If ucrChkSpecifyYAxisTickMarks.Checked AndAlso Not ucrInputYTo.IsEmpty AndAlso Not ucrInputYFrom.IsEmpty AndAlso Not ucrInputYInStepsOf.IsEmpty Then
                clsYScaleContinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsYScaleContinuousSeqFunction)
            Else
                clsYScaleContinuousFunction.RemoveParameterByName("breaks")
            End If
            AddRemoveYAxisScales()
        End If
    End Sub

    Private Sub AddRemoveYAxisScales()
        If bRCodeSet Then
            If rdoYNumeric.Checked Then
                clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=1)
                If clsYScaleContinuousFunction.iParameterCount > 0 Then
                    clsBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsYScaleContinuousFunction)
                Else
                    clsBaseOperator.RemoveParameterByName("scale_y_continuous")
                End If
                clsBaseOperator.RemoveParameterByName("scale_y_date")
            ElseIf rdoYDate.Checked Then
                clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsAsDate, iPosition:=1)
                If clsYScaleDateFunction.iParameterCount > 0 Then
                    clsBaseOperator.AddParameter("scale_y_date", clsRFunctionParameter:=clsYScaleDateFunction)
                Else
                    clsBaseOperator.RemoveParameterByName("scale_y_date")
                End If
                clsBaseOperator.RemoveParameterByName("scale_y_continuous")
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

    Private Sub AddRemoveAxisTextY()
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
        XAxisAngleJust()
        AddRemoveAngleSizeXAxis()
    End Sub

    Private Sub ucrNudXAxisAngle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudXAxisAngle.ControlValueChanged
        XAxisAngleJust()
    End Sub

    Private Sub XAxisAngleJust()
        If Not ucrChkXAxisAngle.Checked OrElse ucrNudXAxisAngle.Value = 0 Then
            clsXElementLabels.RemoveParameterByName("vjust")
            clsXElementLabels.RemoveParameterByName("hjust")
        ElseIf ucrNudXAxisAngle.Value = 90 Then
            clsXElementLabels.RemoveParameterByName("hjust")
            clsXElementLabels.AddParameter("vjust", "0.4")
        Else
            clsXElementLabels.RemoveParameterByName("vjust")
            clsXElementLabels.AddParameter("hjust", "1")
        End If
    End Sub

    Private Sub ucrXBreaksControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputXFrom.ControlValueChanged, ucrInputXTo.ControlValueChanged, ucrInputXInStepsOf.ControlValueChanged, ucrChkSpecifyXAxisTickMarks.ControlValueChanged
        AddRemoveXAxisBreaks()
    End Sub

    Private Sub ucrYBreaksControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputYFrom.ControlValueChanged, ucrInputYTo.ControlValueChanged, ucrInputYInStepsOf.ControlValueChanged, ucrChkSpecifyYAxisTickMarks.ControlValueChanged
        AddRemoveYAxisBreaks()
    End Sub

    Private Sub ucrAxisTextYControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkYAxisAngle.ControlValueChanged, ucrNudYAxisAngle.ControlValueChanged, ucrChkYAxisLabelSize.ControlValueChanged, ucrNudYAxisLabelSize.ControlValueChanged
        AddRemoveAxisTextY()
    End Sub

    Private Sub ucrChkBorderColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBorderColour.ControlValueChanged, ucrChkBorderLineType.ControlValueChanged, UcrChkBorderSize.ControlValueChanged
        AddRemovePanelBorder()
    End Sub

    Private Sub ucrDateBreakControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSpecifyDateBreaks.ControlValueChanged, ucrNudDateBreakNumber.ControlValueChanged, ucrInputDateBreakTime.ControlValueChanged
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

    Private Sub ucrYLimitControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkYSpecifyLowerLimit.ControlValueChanged, ucrChkYSpecifyUpperLimit.ControlValueChanged, ucrInputYSpecifyLowerLimitNumeric.ControlValueChanged, ucrInputYSpecifyUpperLimitNumeric.ControlValueChanged
        If Not ucrChkYSpecifyLowerLimit.Checked Then
            clsCLimitsYContinuous.AddParameter("min", "NA", bIncludeArgumentName:=False, iPosition:=0)
        End If
        If Not ucrChkYSpecifyUpperLimit.Checked Then
            clsCLimitsYContinuous.AddParameter("max", "NA", bIncludeArgumentName:=False, iPosition:=1)
        End If
        AddRemoveYLimits()
    End Sub

    Private Sub AddRemoveYLimits()
        Dim strExpand As String
        If bRCodeSet Then
            If (ucrChkYSpecifyLowerLimit.Checked AndAlso Not ucrInputYSpecifyLowerLimitNumeric.IsEmpty()) OrElse (ucrChkYSpecifyUpperLimit.Checked AndAlso Not ucrInputYSpecifyUpperLimitNumeric.IsEmpty()) Then
                clsYScaleContinuousFunction.AddParameter("limits", clsRFunctionParameter:=clsCLimitsYContinuous, iPosition:=4)
                strExpand = "ggplot2::expand_scale(mult = c("
                If ucrChkYSpecifyLowerLimit.Checked Then
                    strExpand = strExpand & "0, "
                Else
                    strExpand = strExpand & "0.05, "
                End If
                If ucrChkYSpecifyUpperLimit.Checked Then
                    strExpand = strExpand & "0"
                Else
                    strExpand = strExpand & "0.05"
                End If
                strExpand = strExpand & "))"
                clsYScaleContinuousFunction.AddParameter("expand", strExpand, iPosition:=5)
            Else
                clsYScaleContinuousFunction.RemoveParameterByName("limits")
                clsYScaleContinuousFunction.RemoveParameterByName("expand")
            End If
            AddRemoveYAxisScales()
        End If
    End Sub

    Private Sub ucrPnlYAxisType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlYAxisType.ControlValueChanged
        AddRemoveYAxisScales()
    End Sub
End Class