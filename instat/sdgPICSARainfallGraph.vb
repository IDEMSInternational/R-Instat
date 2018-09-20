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
    Public clsXScalecontinuousFunction, clsYScalecontinuousFunction As New RFunction
    Public clsXScalecontinuousSeqFunction, clsYScalecontinuousSeqFunction As New RFunction
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
    Private dctLabelForDays As New Dictionary(Of String, RFunction)

    Private clsMeanFunction As New RFunction
    Private clsMedianFunction As New RFunction
    Private clsTercilesFunction As New RFunction
    Private clsGeomHline As New RFunction
    Private clsGeomHlineAes As New RFunction
    Private strColumn As String

    'geom_hline(mean(rain)


    Private Sub sdgPICSARainfallGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        ' Titles 
        ucrPnlXAxisTitle.AddRadioButton(rdoAutoXAxis)
        ucrPnlXAxisTitle.AddRadioButton(rdoRemoveXAxisTitle)
        ucrPnlXAxisTitle.AddRadioButton(rdoChangeXAxisTitle)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoAutoXAxis, "label", False)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoRemoveXAxisTitle, "label", True)
        ucrPnlXAxisTitle.AddParameterValuesCondition(rdoRemoveXAxisTitle, "label", Chr(34) & Chr(34), True)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoChangeXAxisTitle, "label", True)
        ucrPnlXAxisTitle.AddParameterValuesCondition(rdoChangeXAxisTitle, "label", Chr(34) & Chr(34), False)

        ucrPnlXAxisTitle.AddToLinkedControls(ucrInputXAxisTitle, {rdoChangeXAxisTitle}, bNewLinkedHideIfParameterMissing:=True)

        UcrPnlYAxisTitle.AddRadioButton(rdoAutoYAxis)
        UcrPnlYAxisTitle.AddRadioButton(rdoRemoveYAxisTitle)
        UcrPnlYAxisTitle.AddRadioButton(rdoChangeYAxisTitle)
        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoAutoYAxis, "label", False)
        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoRemoveYAxisTitle, "label", True)
        UcrPnlYAxisTitle.AddParameterValuesCondition(rdoRemoveYAxisTitle, "label", Chr(34) & Chr(34), True)
        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoChangeYAxisTitle, "label", True)
        UcrPnlYAxisTitle.AddParameterValuesCondition(rdoChangeYAxisTitle, "label", Chr(34) & Chr(34), False)
        UcrPnlYAxisTitle.AddToLinkedControls(ucrInputYAxisTitle, {rdoChangeYAxisTitle}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputXAxisTitle.SetParameter(New RParameter("label"))
        ucrInputYAxisTitle.SetParameter(New RParameter("label"))

        UcrChkTitle.SetText("Add Graph Title")
        UcrChkTitle.SetParameter(New RParameter("title"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrInputGraphTitle.SetParameter(New RParameter("title"))

        UcrChkSubTitle.SetText("Add Sub Title")
        UcrChkSubTitle.SetParameter(New RParameter("subtitle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrInputGraphSubTitle.SetParameter(New RParameter("subtitle"))

        UcrChkCaption.SetText("Add Caption")
        UcrChkCaption.SetParameter(New RParameter("caption"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrInputGraphcCaption.SetParameter(New RParameter("caption"))

        UcrChkTitle.AddToLinkedControls(ucrInputGraphTitle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkSubTitle.AddToLinkedControls(ucrInputGraphSubTitle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkCaption.AddToLinkedControls(ucrInputGraphcCaption, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        UcrChkTitleSize.SetText("Size")
        UcrChkTitleSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrNudTitleSize.SetParameter(New RParameter("size"))
        UcrNudTitleSize.Increment = 0.1
        UcrNudTitleSize.Minimum = 0

        UcrChkSubTitleSize.SetText("Size")
        UcrChkSubTitleSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrNudSubTitleSize.SetParameter(New RParameter("size"))
        UcrNudSubTitleSize.Increment = 0.1
        UcrNudSubTitleSize.Minimum = 0

        ucrChkCaptionSize.SetText("Size")
        ucrChkCaptionSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrNudCaptionSize.SetParameter(New RParameter("size"))
        UcrNudCaptionSize.Increment = 0.1
        UcrNudCaptionSize.Minimum = 0

        UcrChkXAxisTitleSzie.SetText("Size")
        UcrChkXAxisTitleSzie.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrNudXAxisTitleSzie.SetParameter(New RParameter("size"))
        UcrNudXAxisTitleSzie.Increment = 0.1
        UcrNudXAxisTitleSzie.Minimum = 0

        UcrChkYAxisTitleSzie.SetText("Size")
        UcrChkYAxisTitleSzie.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrNudYAxisTitleSzie.SetParameter(New RParameter("size"))
        UcrNudYAxisTitleSzie.Increment = 0.1
        UcrNudYAxisTitleSzie.Minimum = 0

        UcrChkTitleSize.AddToLinkedControls(UcrNudTitleSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkSubTitleSize.AddToLinkedControls(UcrNudSubTitleSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCaptionSize.AddToLinkedControls(UcrNudCaptionSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkXAxisTitleSzie.AddToLinkedControls(UcrNudXAxisTitleSzie, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkYAxisTitleSzie.AddToLinkedControls(UcrNudYAxisTitleSzie, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

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
        ucrNudXAxisAngle.SetParameter(New RParameter("angle"))
        ucrNudXAxisAngle.SetMinMax(0, 360)

        ucrChkYAxisAngle.SetText("Angle")
        ucrChkYAxisAngle.SetParameter(New RParameter("angle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudYAxisAngle.SetParameter(New RParameter("angle"))
        ucrNudYAxisAngle.SetMinMax(0, 360)

        ucrChkSpecifyXAxisTickMarks.SetText("Specify Tick Marks")
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

        ucrChkSpecifyYAxisTickMarks.SetText("Specify Tick Marks")
        ucrChkSpecifyYAxisTickMarks.SetParameter(New RParameter("breaks"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrInputYFrom.SetParameter(New RParameter("from"))
        ucrInputYFrom.SetValidationTypeAsNumeric()
        ucrInputYFrom.AddQuotesIfUnrecognised = False

        ucrInputYTo.SetParameter(New RParameter("to"))
        ucrInputYTo.SetValidationTypeAsNumeric()
        ucrInputYTo.AddQuotesIfUnrecognised = False

        ucrInputYInStepsOf.SetParameter(New RParameter("by"))
        ucrInputYInStepsOf.SetValidationTypeAsNumeric()
        ucrInputYInStepsOf.AddQuotesIfUnrecognised = False

        ucrChkLabelForDays.SetText("Labels for Days in Year")
        ucrChkLabelForDays.SetParameter(New RParameter("date_labels"))
        'dctLabelForDays.Add("Day Number", "%j")
        'dctLabelForDays.Add("Day/Month", "%d %b")
        'ucrInputLabelForDays.SetItems(dctLabelForDays)

        ucrChkYAxisAngle.AddToLinkedControls(ucrNudYAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkYAxisLabelSize.AddToLinkedControls(ucrNudYAxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecifyYAxisTickMarks.AddToLinkedControls({ucrInputYFrom, ucrInputYTo, ucrInputYInStepsOf}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputYFrom.SetLinkedDisplayControl(lblYFrom)
        ucrInputYTo.SetLinkedDisplayControl(lblYTo)
        ucrInputYInStepsOf.SetLinkedDisplayControl(lblYInStepsOf)

        ucrChkXAxisAngle.AddToLinkedControls(ucrNudXAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkXAxisLabelSize.AddToLinkedControls(ucrNudXaxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLabelForDays.AddToLinkedControls(ucrInputLabelForDays, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecifyXAxisTickMarks.AddToLinkedControls({ucrInputXFrom, ucrInputXTo, ucrInputXInStepsOf}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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
        UcrNudYAxisTitleSzie.SetParameter(New RParameter("size"))
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
        UcrInputBorderColour.SetParameter(New RParameter("colour"))
        UcrInputBorderColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))
        UcrInputBorderColour.SetDropDownStyleAsNonEditable()

        ucrChkBorderLineType.SetText("Line Type")
        ucrChkBorderLineType.SetParameter(New RParameter("linetype"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrInputBorderLinetype.SetParameter(New RParameter("linetype"))
        UcrInputBorderLinetype.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctLineType))
        UcrInputBorderLinetype.SetDropDownStyleAsNonEditable()

        UcrChkBorderSize.SetText("Size")
        UcrChkBorderSize.SetParameter(New RParameter("size"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        UcrNudBorderSize.SetParameter(New RParameter("size"))
        UcrNudBorderSize.Increment = 0.1
        UcrNudBorderSize.DecimalPlaces = 1
        UcrNudBorderSize.Minimum = 0

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

        ucrChkBorderColour.AddToLinkedControls(UcrInputBorderColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkBorderLineType.AddToLinkedControls(UcrInputBorderLinetype, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        UcrChkBorderSize.AddToLinkedControls(UcrNudBorderSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ' Line tab 
        ucrChkAddMean.SetText("Add Mean")
        ucrChkAddMean.SetParameter(New RParameter("x"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        Dim clsMeanFunc As New RFunction
        Dim clsMeanpParam As New RParameter
        ucrChkAddMedian.SetText("Add Median")

        clsMeanFunc.SetRCommand("mean")
        clsMeanpParam.SetArgumentName("mean")
        clsMeanpParam.SetArgument(clsMeanFunc)
        ucrChkAddMedian.SetParameter(clsMeanpParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrChkAddTerciles.SetText("Add Terciles")

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewOperator As ROperator, Optional clsNewLabsFunction As RFunction = Nothing, Optional clsNewXLabsFunction As RFunction = Nothing, Optional clsNewYLabsFunction As RFunction = Nothing, Optional clsNewXScalecontinuousFunction As RFunction = Nothing, Optional clsNewYScalecontinuousFunction As RFunction = Nothing, Optional clsNewYScaleDateFunction As RFunction = Nothing, Optional clsNewThemeFunction As RFunction = Nothing, Optional dctNewThemeFunctions As Dictionary(Of String, RFunction) = Nothing, Optional clsnewGeomhline As RFunction = Nothing, Optional clsNewGeomHlineAes As RFunction = Nothing, Optional clsNewMeanFunc As RFunction = Nothing, Optional bReset As Boolean = False)
        clsBaseOperator = clsNewOperator

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        'themes function
        clsThemeFunction = clsNewThemeFunction
        clsGeomHline = clsnewGeomhline
        clsMeanFunction = clsNewMeanFunc
        clsGeomHlineAes = clsNewGeomHlineAes
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
        UcrNudTitleSize.SetRCode(clsPlotElementTitle, bCloneIfNeeded:=True)
        UcrNudSubTitleSize.SetRCode(clsPlotElementSubTitle, bCloneIfNeeded:=True)
        UcrNudCaptionSize.SetRCode(clsPlotElementCaption, bCloneIfNeeded:=True)
        UcrNudXAxisTitleSzie.SetRCode(clsXElementTitle, bCloneIfNeeded:=True)
        UcrNudYAxisTitleSzie.SetRCode(clsYElementTitle, bCloneIfNeeded:=True)
        UcrChkTitleSize.SetRCode(clsPlotElementTitle, bCloneIfNeeded:=True)
        UcrChkSubTitleSize.SetRCode(clsPlotElementSubTitle, bCloneIfNeeded:=True)
        ucrChkCaptionSize.SetRCode(clsPlotElementCaption, bCloneIfNeeded:=True)
        UcrChkXAxisTitleSzie.SetRCode(clsXElementTitle, bCloneIfNeeded:=True)
        UcrChkYAxisTitleSzie.SetRCode(clsYElementTitle, bCloneIfNeeded:=True)

        ucrNudXAxisAngle.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)
        ucrNudXaxisLabelSize.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)
        ucrChkXAxisAngle.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)
        ucrChkXAxisLabelSize.SetRCode(clsXElementLabels, bCloneIfNeeded:=True)

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
        ucrChkBorderColour.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        ucrChkBorderLineType.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        UcrInputBorderLinetype.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        UcrChkBorderSize.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)
        UcrNudBorderSize.SetRCode(clsPanelBorderElementRect, bCloneIfNeeded:=True)


        ' other functions 

        clsLabsFunction = clsNewLabsFunction
        clsXLabsFunction = clsNewXLabsFunction
        clsYLabsFunction = clsNewYLabsFunction
        clsXScalecontinuousFunction = clsNewXScalecontinuousFunction
        clsYScalecontinuousFunction = clsNewYScalecontinuousFunction
        clsYScaleDateFunction = clsNewYScaleDateFunction


        ' Breaks for x-axis 
        If clsNewXScalecontinuousFunction IsNot Nothing Then
            clsXScalecontinuousFunction = clsNewXScalecontinuousFunction
        Else
            clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        End If

        ' Breaks for y-axis 
        If clsNewYScalecontinuousFunction IsNot Nothing Then
            clsYScalecontinuousFunction = clsNewYScalecontinuousFunction
        Else
            clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        End If

        ucrChkSpecifyXAxisTickMarks.SetRCode(clsXScalecontinuousFunction, bReset, bCloneIfNeeded:=True)
        ucrChkSpecifyYAxisTickMarks.SetRCode(clsYScalecontinuousFunction, bReset, bCloneIfNeeded:=True)

        ' Seq function for Scales 
        Dim clsTempXBreaksParam As RParameter
        If clsXScalecontinuousFunction.ContainsParameter("breaks") Then
            clsTempXBreaksParam = clsXScalecontinuousFunction.GetParameter("breaks")
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
        If clsYScalecontinuousFunction.ContainsParameter("breaks") Then
            clsTempYBreaksParam = clsYScalecontinuousFunction.GetParameter("breaks")
            If clsTempYBreaksParam.clsArgumentCodeStructure IsNot Nothing Then
                clsYScalecontinuousSeqFunction = clsTempYBreaksParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsYScalecontinuousSeqFunction = New RFunction
                clsYScalecontinuousSeqFunction.SetRCommand("seq")
            End If
        Else
            clsYScalecontinuousSeqFunction = New RFunction
            clsYScalecontinuousSeqFunction.SetRCommand("seq")
        End If

        ucrInputYFrom.SetRCode(clsYScalecontinuousSeqFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYTo.SetRCode(clsYScalecontinuousSeqFunction, bReset, bCloneIfNeeded:=True)
        ucrInputYInStepsOf.SetRCode(clsYScalecontinuousSeqFunction, bReset, bCloneIfNeeded:=True)

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

        UcrChkTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        UcrChkSubTitle.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)
        UcrChkCaption.SetRCode(clsLabsFunction, bReset, bCloneIfNeeded:=True)

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
        ucrChkLabelForDays.SetRCode(clsYScaleDateFunction, bCloneIfNeeded:=True)
        ucrInputLabelForDays.SetRCode(clsYScaleDateFunction, bCloneIfNeeded:=True)

        ucrChkAddMedian.SetRCode(clsGeomHline, bReset, bCloneIfNeeded:=True)

        bRCodeSet = True
        AddRemoveTheme()
        AddRemoveLabs()
        AddRemoveXLabs()
        AddRemoveYLabs()
        AddRemoveSpecifyXAxisTickMarks()
        AddRemoveSpecifyYAxisTickMarks()
        AddRemoveHline()
    End Sub


    Private Sub AddRemoveHline()
        If ucrChkAddMean.Checked Then
            clsBaseOperator.AddParameter("hline", clsRFunctionParameter:=clsGeomHline)
            clsGeomHline.AddParameter("aes", clsRFunctionParameter:=clsGeomHlineAes, bIncludeArgumentName:=False)
            clsGeomHlineAes.AddParameter("yintercept", clsRFunctionParameter:=clsMeanFunction)
            clsMeanFunction.AddParameter("column", strColumn, bIncludeArgumentName:=False)
        Else
            clsBaseOperator.RemoveParameterByName("hline")
        End If
    End Sub

    Public Sub SetComputationValue(strNewColumn As String)
        strColumn = strNewColumn
    End Sub

    Private Sub ucrChkAddMean_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddMean.ControlValueChanged
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
            If rdoRemoveXAxisTitle.Checked OrElse (rdoChangeXAxisTitle.Checked AndAlso Not ucrInputXAxisTitle.IsEmpty()) Then
                clsBaseOperator.AddParameter("lab", clsRFunctionParameter:=clsXLabsFunction)
            Else
                clsBaseOperator.RemoveParameterByName("lab")
            End If
        End If
    End Sub

    Private Sub AddRemoveYLabs()
        If bRCodeSet Then
            If Not rdoRemoveYAxisTitle.Checked OrElse (rdoChangeYAxisTitle.Checked AndAlso Not ucrInputYAxisTitle.IsEmpty()) Then
                clsBaseOperator.AddParameter("lab", clsRFunctionParameter:=clsYLabsFunction)
            Else
                clsBaseOperator.RemoveParameterByName("lab")
            End If
        End If
    End Sub

    Private Sub SetXLabel()
        If bRCodeSet Then
            If rdoAutoXAxis.Checked Then
                clsXLabsFunction.RemoveParameterByName("label")
            ElseIf rdoRemoveXAxisTitle.Checked Then
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
            ElseIf rdoRemoveYAxisTitle.Checked Then
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
                clsBaseOperator.AddParameter("scale_x_continuous", clsRFunctionParameter:=clsXScalecontinuousFunction)
                clsXScalecontinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsXScalecontinuousSeqFunction)

            Else
                clsXScalecontinuousFunction.RemoveParameterByName("breaks")
                clsBaseOperator.RemoveParameterByName("scale_x_continuous")
            End If
        End If
    End Sub

    Private Sub AddRemoveSpecifyYAxisTickMarks()
        If bRCodeSet Then
            If ucrChkSpecifyYAxisTickMarks.Checked AndAlso Not ucrInputYTo.IsEmpty AndAlso Not ucrInputYFrom.IsEmpty AndAlso Not ucrInputYInStepsOf.IsEmpty Then
                clsBaseOperator.AddParameter("scale_y_continuous", clsRFunctionParameter:=clsYScalecontinuousFunction)
                clsYScalecontinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsYScalecontinuousSeqFunction)
            Else
                clsYScalecontinuousFunction.RemoveParameterByName("breaks")
                clsBaseOperator.RemoveParameterByName("scale_x_continuous")
            End If
        End If
    End Sub

    Private Sub ucrInputGraphTitle_ControlValueChanged() Handles ucrInputGraphTitle.ControlValueChanged, ucrInputGraphSubTitle.ControlValueChanged, ucrInputGraphcCaption.ControlValueChanged
        AddRemoveLabs()
    End Sub

    Private Sub AddRemoveGraphTitleSize()
        If (UcrChkTitleSize.Checked AndAlso UcrNudTitleSize.GetText <> "") Then
            clsThemeFunction.AddParameter("plot.title", clsRFunctionParameter:=clsPlotElementTitle)
        Else
            clsThemeFunction.RemoveParameterByName("plot.title")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveGraphSubTitleSize()
        If (UcrChkSubTitleSize.Checked AndAlso UcrNudSubTitleSize.GetText <> "") Then
            clsThemeFunction.AddParameter("plot.subtitle", clsRFunctionParameter:=clsPlotElementSubTitle)
        Else
            clsThemeFunction.RemoveParameterByName("plot.subtitle")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveGraphCaptionSize()
        If (ucrChkCaptionSize.Checked AndAlso UcrNudCaptionSize.GetText <> "") Then
            clsThemeFunction.AddParameter("plot.caption", clsRFunctionParameter:=clsPlotElementCaption)
        Else
            clsThemeFunction.RemoveParameterByName("plot.caption")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveXAxisTitleSize()
        If UcrChkXAxisTitleSzie.Checked AndAlso UcrNudXAxisTitleSzie.GetText <> "" Then
            clsThemeFunction.AddParameter("axis.title.x", clsRFunctionParameter:=clsXElementTitle)
        Else
            clsThemeFunction.RemoveParameterByName("axis.title.x")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveYAxisTitleSize()
        If UcrChkYAxisTitleSzie.Checked AndAlso UcrNudYAxisTitleSzie.GetText <> "" Then
            clsThemeFunction.AddParameter("axis.title.y", clsRFunctionParameter:=clsYElementTitle)
        Else
            clsThemeFunction.RemoveParameterByName("axis.title.y")
        End If
        AddRemoveTheme()
    End Sub

    Private Sub AddRemoveAngleSizeXAxis()
        If (ucrChkXAxisAngle.Checked AndAlso ucrNudXAxisAngle.GetText <> "") OrElse (ucrChkXAxisLabelSize.Checked AndAlso ucrNudXaxisLabelSize.GetText <> "") Then
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsXElementLabels)
        Else
            clsThemeFunction.RemoveParameterByName("axis.text.x")
        End If
        AddRemoveTheme()
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
        If (ucrChkBorderColour.Checked AndAlso Not UcrInputBorderColour.IsEmpty()) OrElse (ucrChkBorderLineType.Checked AndAlso Not UcrInputBorderLinetype.IsEmpty()) OrElse (UcrChkBorderSize.Checked AndAlso UcrNudBorderSize.GetText <> "") Then
            clsThemeFunction.AddParameter("panel.border", clsRFunctionParameter:=clsPanelBorderElementRect)
        Else
            clsThemeFunction.RemoveParameterByName("panel.border")
        End If
        AddRemoveTheme()
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

    Private Sub UcrChkTitleSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrChkTitleSize.ControlValueChanged
        AddRemoveGraphTitleSize()
    End Sub

    Private Sub UcrChkSubTitleSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrChkSubTitleSize.ControlValueChanged
        AddRemoveGraphSubTitleSize()
    End Sub

    Private Sub UcrChkCaptionSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCaptionSize.ControlValueChanged
        AddRemoveGraphCaptionSize()
    End Sub

    Private Sub UcrChkXAxisTitleSzie_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrChkXAxisTitleSzie.ControlValueChanged
        AddRemoveXAxisTitleSize()
    End Sub

    Private Sub UcrChkYAxisTitleSzie_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrChkYAxisTitleSzie.ControlValueChanged
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

    Private Sub ucrInputYFrom_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputYFrom.ControlContentsChanged, ucrInputYFrom.ControlContentsChanged, ucrInputYInStepsOf.ControlContentsChanged, ucrChkSpecifyYAxisTickMarks.ControlValueChanged
        AddRemoveSpecifyYAxisTickMarks()
    End Sub

    Private Sub ucrChkBorderColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBorderColour.ControlValueChanged, ucrChkBorderLineType.ControlValueChanged, UcrChkBorderSize.ControlValueChanged
        AddRemovePanelBorder()
    End Sub


End Class