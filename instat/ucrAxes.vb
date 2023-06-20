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
Imports RDotNet
Public Class ucrAxes
    Public bIsX As Boolean
    Public clsXYlabTitleFunction As New RFunction
    Public clsXYScaleContinuousFunction As New RFunction
    Public clsXYScaleDiscreteFunction As New RFunction
    Public clsXYScaleDateFunction As New RFunction
    Public clsLimitsFunction As New RFunction
    Public clsLimitsFunctionDiscrete As New RFunction
    Public clsBaseOperator As New ROperator
    Public clsMajorBreaksSeqFunction As New RFunction
    Public clsMinorBreaksSeqFunction As New RFunction
    Public clsMajorBreaksSeqDiscreteFunction As New RFunction
    Public clsMinorBreaksSeqDiscreteFunction As New RFunction
    Public clsXYScaleDateBreakOperator As New ROperator
    Public clsXYScaleDateLimitFunction As New RFunction
    Public strAxis As String
    'e.g. discrete, continuous
    Public strAxisType As String
    Public bFirstLoad As Boolean = True
    Private bControlsInitialised As Boolean = False
    Private bRCodeSet As Boolean = False

    Public Sub InitialiseControl()
        Dim dctTickMarkers As New Dictionary(Of String, String)
        Dim dctDateFormat As New Dictionary(Of String, String)

        'Axis Section
        ucrPnlAxisTitle.AddRadioButton(rdoTitleAuto)
        ucrPnlAxisTitle.AddRadioButton(rdoNoTitle)
        ucrPnlAxisTitle.AddRadioButton(rdoSpecifyTitle)
        ucrPnlAxisTitle.AddParameterPresentCondition(rdoTitleAuto, "label", False)
        ucrPnlAxisTitle.AddParameterPresentCondition(rdoNoTitle, "label", True)
        ucrPnlAxisTitle.AddParameterValuesCondition(rdoNoTitle, "label", Chr(34) & Chr(34), True)
        ucrPnlAxisTitle.AddParameterPresentCondition(rdoSpecifyTitle, "label", True)
        ucrPnlAxisTitle.AddParameterValuesCondition(rdoSpecifyTitle, "label", Chr(34) & Chr(34), False)
        ucrPnlAxisTitle.AddToLinkedControls(ucrInputTitle, {rdoSpecifyTitle}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputTitle.SetParameter(New RParameter("label"))
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)

        'Tick Markers section
        ucrPnlMajorBreaks.AddRadioButton(rdoMajorBreaksAuto)
        ucrPnlMajorBreaks.AddRadioButton(rdoMajorBreaksNone)
        ucrPnlMajorBreaks.AddRadioButton(rdoMajorBreaksCustom)
        ucrPnlMajorBreaks.AddRadioButton(rdoMajorBreaksSeq)

        ucrPnlMajorBreaks.AddParameterPresentCondition(rdoMajorBreaksAuto, "breaks", bNewIsPositive:=False)
        ucrPnlMajorBreaks.AddParameterValuesCondition(rdoMajorBreaksNone, "breaks", "NULL")
        ucrPnlMajorBreaks.AddParameterValueFunctionNamesCondition(rdoMajorBreaksSeq, "breaks", "seq")
        ucrPnlMajorBreaks.AddParameterPresentCondition(rdoMajorBreaksCustom, "breaks")
        ucrPnlMajorBreaks.AddParameterValuesCondition(rdoMajorBreaksCustom, "breaks", "NULL", bNewIsPositive:=False)
        ucrPnlMajorBreaks.AddParameterIsStringCondition(rdoMajorBreaksCustom, "breaks")

        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksFrom, {rdoMajorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksTo, {rdoMajorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksInStepsOf, {rdoMajorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksInStepsOf, {rdoMajorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksCustom, {rdoMajorBreaksCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrChkLabels, {rdoMajorBreaksSeq, rdoMajorBreaksCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)

        ucrChkLabels.SetText("Labels")
        ucrChkLabels.AddParameterPresentCondition(True, "labels")
        ucrChkLabels.AddParameterPresentCondition(False, "labels", False)
        ucrChkLabels.AddToLinkedControls(ucrInputMajorBreaksLabels, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputMajorBreaksLabels.SetValidationTypeAsList()

        'ucrInputMajorBreaksCustom.SetParameter(New RParameter("breaks"))
        ucrInputMajorBreaksCustom.AddQuotesIfUnrecognised = False
        ucrInputMajorBreaksCustom.SetValidationTypeAsNumericList()

        ucrPnlMinorBreaks.AddRadioButton(rdoMinorBreaksAuto)
        ucrPnlMinorBreaks.AddRadioButton(rdoMinorBreaksCustom)
        ucrPnlMinorBreaks.AddRadioButton(rdoMinorBreaksSeq)
        ucrPnlMinorBreaks.AddRadioButton(rdoMinorBreaksNone)

        ucrPnlMinorBreaks.AddParameterPresentCondition(rdoMinorBreaksAuto, "minor_breaks", bNewIsPositive:=False)
        ucrPnlMinorBreaks.AddParameterValuesCondition(rdoMinorBreaksNone, "minor_breaks", "NULL")
        ucrPnlMinorBreaks.AddParameterValueFunctionNamesCondition(rdoMinorBreaksSeq, "minor_breaks", "seq")
        ucrPnlMinorBreaks.AddParameterPresentCondition(rdoMinorBreaksCustom, "minor_breaks")
        ucrPnlMinorBreaks.AddParameterIsRFunctionCondition(rdoMinorBreaksCustom, "minor_breaks")
        ucrPnlMinorBreaks.AddParameterValueFunctionNamesCondition(rdoMinorBreaksCustom, "minor_breaks", "seq", bNewIsPositive:=False)

        ucrPnlMinorBreaks.AddToLinkedControls(ucrInputMinorBreaksFrom, {rdoMinorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMinorBreaks.AddToLinkedControls(ucrInputMinorBreaksTo, {rdoMinorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMinorBreaks.AddToLinkedControls(ucrInputMinorBreaksInStepsOf, {rdoMinorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMinorBreaks.AddToLinkedControls(ucrInputMinorBreaksCustom, {rdoMinorBreaksCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ''These add parameters to clsMajorBreaksSeqFunction
        ucrInputMajorBreaksInStepsOf.SetParameter(New RParameter("by"))
        ucrInputMajorBreaksInStepsOf.SetValidationTypeAsNumeric()
        ucrInputMajorBreaksInStepsOf.AddQuotesIfUnrecognised = False
        ucrInputMajorBreaksInStepsOf.SetLinkedDisplayControl(lblMajorBreaksInStepsOf)
        ucrInputMajorBreaksInStepsOf.SetLinkedDisplayControl(lblMajorBreaksInStepsOf)

        ucrInputMajorBreaksTo.SetParameter(New RParameter("to"))
        ucrInputMajorBreaksTo.SetValidationTypeAsNumeric()
        ucrInputMajorBreaksTo.AddQuotesIfUnrecognised = False
        ucrInputMajorBreaksTo.SetLinkedDisplayControl(lblMajorBreaksTo)

        ucrInputMajorBreaksFrom.SetParameter(New RParameter("from"))
        ucrInputMajorBreaksFrom.SetValidationTypeAsNumeric()
        ucrInputMajorBreaksFrom.AddQuotesIfUnrecognised = False
        ucrInputMajorBreaksFrom.SetLinkedDisplayControl(lblMajorBreaksFrom)

        'These add parameters to clsMinorBreaksSeqFunction
        ucrInputMinorBreaksInStepsOf.SetParameter(New RParameter("by"))
        ucrInputMinorBreaksInStepsOf.SetValidationTypeAsNumeric()
        ucrInputMinorBreaksInStepsOf.AddQuotesIfUnrecognised = False
        ucrInputMinorBreaksInStepsOf.SetLinkedDisplayControl(lblMinorBreaksInStepsOf)

        ucrInputMinorBreaksTo.SetParameter(New RParameter("to"))
        ucrInputMinorBreaksTo.SetValidationTypeAsNumeric()
        ucrInputMinorBreaksTo.AddQuotesIfUnrecognised = False
        ucrInputMinorBreaksTo.SetLinkedDisplayControl(lblMinorBreaksTo)

        ucrInputMinorBreaksFrom.SetParameter(New RParameter("from"))
        ucrInputMinorBreaksFrom.SetValidationTypeAsNumeric()
        ucrInputMinorBreaksFrom.AddQuotesIfUnrecognised = False
        ucrInputMinorBreaksFrom.SetLinkedDisplayControl(lblMinorBreaksFrom)

        ucrChkLabelsDiscrete.SetText("Labels")
        ucrChkLabelsDiscrete.AddParameterPresentCondition(True, "labels")
        ucrChkLabelsDiscrete.AddParameterPresentCondition(False, "labels", False)
        ucrChkLabelsDiscrete.AddToLinkedControls(ucrInputMajorBreaksLabelsDiscrete, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputMajorBreaksLabelsDiscrete.SetValidationTypeAsList()

        'Scales section
        ucrPnlScales.AddRadioButton(rdoScalesAuto)
        ucrPnlScales.AddRadioButton(rdoScalesCustom)
        ucrPnlScales.AddParameterPresentCondition(rdoScalesAuto, "limits", False)
        ucrPnlScales.AddParameterPresentCondition(rdoScalesCustom, "limits", True)
        ucrPnlScales.AddToLinkedControls(ucrInputLowerLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlScales.AddToLinkedControls(ucrInputUpperLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputLowerLimit.SetParameter(New RParameter("lowerlimit", 0))
        ucrInputLowerLimit.SetParameterIncludeArgumentName(False)
        ucrInputLowerLimit.SetValidationTypeAsNumeric()
        ucrInputLowerLimit.AddQuotesIfUnrecognised = False
        ucrInputLowerLimit.SetValuesToIgnore({"NA"})
        ucrInputLowerLimit.SetLinkedDisplayControl(lblLowerLimit)

        ucrInputUpperLimit.SetParameter(New RParameter("upperlimit", 1))
        ucrInputUpperLimit.SetParameterIncludeArgumentName(False)
        ucrInputUpperLimit.SetValidationTypeAsNumeric()
        ucrInputUpperLimit.AddQuotesIfUnrecognised = False
        ucrInputUpperLimit.SetValuesToIgnore({"NA"})
        ucrInputUpperLimit.SetLinkedDisplayControl(lblUpperLimit)


        'Scales Discrete section
        ucrPnlScaleDiscrete.AddRadioButton(rdoAutoDiscrete)
        ucrPnlScaleDiscrete.AddRadioButton(rdoBreaksDiscrete)
        ucrPnlScaleDiscrete.AddRadioButton(rdoLimitDiscrete)
        ucrPnlScaleDiscrete.AddParameterPresentCondition(rdoAutoDiscrete, "limits", False)
        ucrPnlScaleDiscrete.AddParameterPresentCondition(rdoBreaksDiscrete, "breaks", True)
        ucrPnlScaleDiscrete.AddParameterPresentCondition(rdoLimitDiscrete, "limits", True)
        ucrPnlScaleDiscrete.AddToLinkedControls(ucrInputLimitDiscrete, {rdoLimitDiscrete}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlScaleDiscrete.AddToLinkedControls(ucrInputBreaksDiscrete, {rdoBreaksDiscrete}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputLimitDiscrete.SetLinkedDisplayControl(lblLimitDiscrete)
        ucrInputLimitDiscrete.SetValidationTypeAsList()

        ucrInputBreaksDiscrete.SetLinkedDisplayControl(lblBreaksDiscrete)
        ucrInputBreaksDiscrete.SetValidationTypeAsList()

        'Axis type - controls which options are available
        ucrInputAxisType.SetItems({"continuous", "discrete", "date"})
        ucrInputAxisType.SetDropDownStyleAsNonEditable()

        ucrInputRelaceMissingvalues.SetParameter(New RParameter("na.value"))
        ucrInputRelaceMissingvalues.SetValidationTypeAsNumeric()
        ucrInputRelaceMissingvalues.bAddRemoveParameter = False
        ucrInputRelaceMissingvalues.AddQuotesIfUnrecognised = False

        ucrChkNaValue.SetText("Replace Missing Values")
        ucrChkNaValue.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValue.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValue.AddToLinkedControls(ucrInputRelaceMissingvalues, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrInputNaValueDiscrete.SetParameter(New RParameter("na.value"))
        ucrInputNaValueDiscrete.SetValidationTypeAsNumeric()
        ucrInputNaValueDiscrete.bAddRemoveParameter = False
        ucrInputNaValueDiscrete.AddQuotesIfUnrecognised = False

        ucrChkNaValueDiscrete.SetText("Replace Missing Values")
        ucrChkNaValueDiscrete.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValueDiscrete.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValueDiscrete.AddToLinkedControls(ucrInputNaValueDiscrete, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkTransformation.SetText("Transformation")
        ucrInputTransformation.SetParameter(New RParameter("trans"))
        ucrChkTransformation.AddParameterPresentCondition(True, "trans")
        ucrChkTransformation.AddParameterPresentCondition(False, "trans", False)
        ucrChkTransformation.AddToLinkedControls(ucrInputTransformation, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="asn")
        ucrInputTransformation.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctTransformations))
        ucrInputTransformation.SetDropDownStyleAsNonEditable()

        ucrChkDropUnusedLevels.SetText("Drop Unused Levels:")
        ucrInputDropUnusedLevels.SetParameter(New RParameter("drop"))
        ucrChkDropUnusedLevels.AddParameterPresentCondition(True, "drop")
        ucrChkDropUnusedLevels.AddParameterPresentCondition(False, "drop", False)
        ucrChkDropUnusedLevels.AddToLinkedControls(ucrInputDropUnusedLevels, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrInputDropUnusedLevels.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctDropUnusedLevels))
        ucrInputDropUnusedLevels.SetDropDownStyleAsNonEditable()

        ucrChkPosition.SetText("Position")
        ucrInputPosition.SetParameter(New RParameter("position"))
        ucrInputPosition.SetDropDownStyleAsNonEditable()
        ucrChkPosition.AddParameterPresentCondition(True, "position")
        ucrChkPosition.AddParameterPresentCondition(False, "position", False)
        ucrChkPosition.AddToLinkedControls(ucrInputPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=Nothing)

        ucrChkPositionDiscrete.SetText("Position")
        ucrInputPositionDiscrete.SetParameter(New RParameter("position"))
        ucrInputPositionDiscrete.SetDropDownStyleAsNonEditable()
        ucrChkPositionDiscrete.AddParameterPresentCondition(True, "position")
        ucrChkPositionDiscrete.AddParameterPresentCondition(False, "position", False)
        ucrChkPositionDiscrete.AddToLinkedControls(ucrInputPositionDiscrete, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=Nothing)

        ucrChkExpand.SetText("Expand")
        ucrChkExpand.AddParameterPresentCondition(True, "expand")
        ucrChkExpand.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpand.AddToLinkedControls(ucrInputExpand, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputExpand.SetValidationTypeAsNumericList()

        ucrChkExpandDiscrete.SetText("Expand")
        ucrChkExpandDiscrete.AddParameterPresentCondition(True, "expand")
        ucrChkExpandDiscrete.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpandDiscrete.AddToLinkedControls(ucrInputExpandDiscrete, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputExpandDiscrete.SetValidationTypeAsNumericList()

        'Date X Scale
        dctDateFormat.Add("Year, with century (0000-9999)", Chr(34) & "%Y" & Chr(34))
        dctDateFormat.Add("Year, without century (00-99)", Chr(34) & "%y" & Chr(34))

        dctDateFormat.Add("month, full (January-December)", Chr(34) & "%B" & Chr(34))
        dctDateFormat.Add("month, abbreviated (Jan-Dec)", Chr(34) & "%b" & Chr(34))
        dctDateFormat.Add("month, numeric (01-12)", Chr(34) & "%m" & Chr(34))

        dctDateFormat.Add("day of the month (01-31)", Chr(34) & "%d" & Chr(34))
        dctDateFormat.Add("day of the month (1-31)", Chr(34) & "%e" & Chr(34))
        dctDateFormat.Add("day of the week, full (Monday-Sunday)", Chr(34) & "%A" & Chr(34))
        dctDateFormat.Add("day of the week, abbreviated (Mon-Sun)", Chr(34) & "%a" & Chr(34))

        dctDateFormat.Add("hour, in 24-hour clock (01-24)", Chr(34) & "%H" & Chr(34))
        dctDateFormat.Add("hour, in 12-hour clock (01-12)", Chr(34) & "%I" & Chr(34))
        dctDateFormat.Add("hour, in 12-hour clock (1-12)", Chr(34) & "%l" & Chr(34))

        dctDateFormat.Add("minute (00-59)", Chr(34) & "%M" & Chr(34))
        dctDateFormat.Add("second (00-59)", Chr(34) & "%S" & Chr(34))

        dctDateFormat.Add("Day-Month-Year(4-digit)", Chr(34) & "%d-%m-%Y" & Chr(34))
        dctDateFormat.Add("Day/Month/Year(4-digit)", Chr(34) & "%d/%m/%Y" & Chr(34))
        dctDateFormat.Add("Day-Month(Full Name)-Year(4-digit)", Chr(34) & "%d-%B-%Y" & Chr(34))
        dctDateFormat.Add("Day/Month(Full Name)/Year(4-digit)", Chr(34) & "%d/%B/%Y" & Chr(34))

        ucrInputComboDateLabel.SetParameter(New RParameter("date_labels", 3))
        ucrInputComboDateLabel.SetItems(dctDateFormat)
        ucrInputComboDateLabel.SetDropDownStyleAsEditable(bAdditionsAllowed:=True)

        ucrChkDateLabels.SetText("Date labels")

        ucrChkDateLabels.SetParameter(New RParameter("date_labels"), bNewChangeParameterValue:=False)
        ucrChkDateLabels.AddToLinkedControls(ucrInputComboDateLabel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Year(4-digit)-Month-Day")

        ucrNudDateBreak.SetParameter(New RParameter("value", 0, bNewIncludeArgumentName:=False))

        ucrInputComboDateBreak.SetParameter(New RParameter("duration", 1, bNewIncludeArgumentName:=False))
        ucrInputComboDateBreak.SetItems({"year", "month", "week", "day", "hour", "min", "sec"})
        ucrInputComboDateBreak.SetName("year")
        ucrInputComboDateBreak.SetDropDownStyleAsNonEditable()
        ucrInputComboDateBreak.AddQuotesIfUnrecognised = False

        ucrDtpLowerLimit.SetParameter(New RParameter("from", 0))
        ucrDtpUpperLimit.SetParameter(New RParameter("to", 1))

        ucrChkBreaks.SetText("Breaks")
        ucrChkBreaks.SetParameter(New RParameter("date_breaks", 1), bNewChangeParameterValue:=False)
        ucrChkBreaks.AddToLinkedControls(ucrInputComboDateBreak, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="year")
        ucrChkBreaks.AddToLinkedControls(ucrNudDateBreak, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="1")

        ucrChkLimits.AddToLinkedControls(ucrDtpLowerLimit, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLimits.AddToLinkedControls(ucrDtpUpperLimit, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrDtpUpperLimit.SetLinkedDisplayControl(lblXScalDateUpperLimit)
        ucrDtpLowerLimit.SetLinkedDisplayControl(lbXscaleDateLowerLimit)

        ucrChkLimits.SetText("Limits")
        ucrChkLimits.SetParameter(New RParameter("limits", 2), bNewChangeParameterValue:=False)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCodeForControl(bIsXAxis As Boolean, Optional strNewAxisType As String = "continuous", Optional clsNewXYScaleContinuousFunction As RFunction = Nothing, Optional clsNewXYScaleDiscreteFunction As RFunction = Nothing, Optional clsNewXYlabTitleFunction As RFunction = Nothing, Optional clsNewXYScaleDateFunction As RFunction = Nothing, Optional clsNewBaseOperator As ROperator = Nothing, Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        Dim clsTempBreaksParam As RParameter
        Dim clsTempMinorBreaksParam As RParameter

        bRCodeSet = False
        If Not bControlsInitialised Then
            InitialiseControl()
        End If
        clsBaseOperator = clsNewBaseOperator
        bIsX = bIsXAxis
        strAxisType = strNewAxisType
        If bIsXAxis Then
            bIsX = True
            strAxis = "x"

        Else
            bIsX = False
            strAxis = "y"
        End If

        If bIsX Then
            ucrInputPosition.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctXPosition))
            ucrInputPosition.SetDefaultState("Bottom")
        ElseIf Not bIsX Then
            ucrInputPosition.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctYPosition))
            ucrInputPosition.SetDefaultState("Left")
        End If

        If bIsX Then
            ucrInputPositionDiscrete.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctXPosition))
            ucrInputPositionDiscrete.SetDefaultState("Bottom")
        ElseIf Not bIsX Then
            ucrInputPositionDiscrete.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctYPosition))
            ucrInputPositionDiscrete.SetDefaultState("Left")
        End If

        'ucrInputBreaksDiscrete.SetName({"A", "B"})
        clsXYScaleDateLimitFunction = New RFunction
        clsXYScaleDateLimitFunction.SetRCommand("c")
        clsXYScaleDateLimitFunction.AddParameter("from", clsRFunctionParameter:=ucrDtpLowerLimit.ValueAsRDate(), iPosition:=0)
        clsXYScaleDateLimitFunction.AddParameter("to", clsRFunctionParameter:=ucrDtpLowerLimit.ValueAsRDate(), iPosition:=1)

        clsXYScaleDateBreakOperator = New ROperator
        clsXYScaleDateBreakOperator.SetOperation(" ")
        clsXYScaleDateBreakOperator.bSpaceAroundOperation = False
        clsXYScaleDateBreakOperator.bToScriptAsRString = True

        clsXYlabTitleFunction = clsNewXYlabTitleFunction
        clsXYScaleDateFunction = clsNewXYScaleDateFunction
        clsXYScaleContinuousFunction = clsNewXYScaleContinuousFunction
        clsXYScaleDiscreteFunction = clsNewXYScaleDiscreteFunction

        'TODO these could be passed through as a dictionary of scale functions instead of searched
        If clsXYScaleContinuousFunction.ContainsParameter("limits") AndAlso clsXYScaleContinuousFunction.GetParameter("limits").clsArgumentCodeStructure IsNot Nothing Then
            clsLimitsFunction = clsXYScaleContinuousFunction.GetParameter("limits").clsArgumentCodeStructure
        Else
            'TODO move to ggplot defaults
            clsLimitsFunction = New RFunction
            clsLimitsFunction.SetRCommand("c")
        End If

        If clsXYScaleDiscreteFunction.ContainsParameter("limits") AndAlso clsXYScaleDiscreteFunction.GetParameter("limits").clsArgumentCodeStructure IsNot Nothing Then
            clsLimitsFunctionDiscrete = clsXYScaleDiscreteFunction.GetParameter("limits").clsArgumentCodeStructure
        Else
            'TODO move to ggplot defaults
            clsLimitsFunctionDiscrete = New RFunction
            clsLimitsFunctionDiscrete.SetRCommand("c")
        End If

        If clsXYScaleDiscreteFunction.ContainsParameter("breaks") AndAlso clsXYScaleDiscreteFunction.GetParameter("breaks").clsArgumentCodeStructure IsNot Nothing Then
            clsLimitsFunctionDiscrete = clsXYScaleDiscreteFunction.GetParameter("breaks").clsArgumentCodeStructure
        Else
            'TODO move to ggplot defaults
            clsLimitsFunctionDiscrete = New RFunction
            clsLimitsFunctionDiscrete.SetRCommand("c")
        End If

        If clsXYScaleContinuousFunction.ContainsParameter("breaks") Then
            clsTempBreaksParam = clsXYScaleContinuousFunction.GetParameter("breaks")
            If clsTempBreaksParam.clsArgumentCodeStructure IsNot Nothing Then
                clsMajorBreaksSeqFunction = clsTempBreaksParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsMajorBreaksSeqFunction = New RFunction
                clsMajorBreaksSeqFunction.SetRCommand("seq")
            End If
        Else
            clsMajorBreaksSeqFunction = New RFunction
            clsMajorBreaksSeqFunction.SetRCommand("seq")
        End If

        If clsXYScaleDiscreteFunction.ContainsParameter("breaks") Then
            clsTempBreaksParam = clsXYScaleDiscreteFunction.GetParameter("breaks")
            If clsTempBreaksParam.clsArgumentCodeStructure IsNot Nothing Then
                clsMajorBreaksSeqDiscreteFunction = clsTempBreaksParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsMajorBreaksSeqDiscreteFunction = New RFunction
                clsMajorBreaksSeqDiscreteFunction.SetRCommand("seq")
            End If
        Else
            clsMajorBreaksSeqDiscreteFunction = New RFunction
            clsMajorBreaksSeqDiscreteFunction.SetRCommand("seq")
            clsMajorBreaksSeqDiscreteFunction.SetRCommand("seq")
        End If


        If clsXYScaleContinuousFunction.ContainsParameter("minor_breaks") Then
            clsTempMinorBreaksParam = clsXYScaleContinuousFunction.GetParameter("minor_breaks")
            If clsTempMinorBreaksParam.clsArgumentCodeStructure IsNot Nothing Then
                clsMinorBreaksSeqFunction = clsTempMinorBreaksParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsMinorBreaksSeqFunction = New RFunction
                clsMinorBreaksSeqFunction.SetRCommand("seq")
            End If
        Else
            clsMinorBreaksSeqFunction = New RFunction
            clsMinorBreaksSeqFunction.SetRCommand("seq")
        End If

        If clsXYScaleDateFunction.ContainsParameter("date_breaks") Then
            clsXYScaleDateBreakOperator = clsXYScaleDateFunction.GetParameter("date_breaks").clsArgumentCodeStructure
        End If

        If clsXYScaleDateFunction.ContainsParameter("limits") Then
            clsXYScaleDateLimitFunction = clsXYScaleDateFunction.GetParameter("limits").clsArgumentCodeStructure
        End If

        ucrPnlAxisTitle.SetRCode(clsXYlabTitleFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputTitle.SetRCode(clsXYlabTitleFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        'scales functions
        ucrPnlScales.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputLowerLimit.SetRCode(clsLimitsFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputUpperLimit.SetRCode(clsLimitsFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrInputPosition.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkPosition.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrChkNaValue.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputRelaceMissingvalues.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrChkTransformation.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputTransformation.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrPnlMajorBreaks.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputMajorBreaksCustom.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputMajorBreaksLabels.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrInputMajorBreaksLabelsDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        'Scale_x_Date
        ucrChkDateLabels.SetRCode(clsXYScaleDateFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputComboDateLabel.SetRCode(clsXYScaleDateFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrChkBreaks.SetRCode(clsXYScaleDateFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrChkLimits.SetRCode(clsXYScaleDateFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrNudDateBreak.SetRCode(clsXYScaleDateBreakOperator, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputComboDateBreak.SetRCode(clsXYScaleDateBreakOperator, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrDtpUpperLimit.SetRCode(clsXYScaleDateLimitFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrDtpLowerLimit.SetRCode(clsXYScaleDateLimitFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        'Temp disabled, not yet implemented
        ucrInputMajorBreaksInStepsOf.SetRCode(clsMajorBreaksSeqFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputMajorBreaksTo.SetRCode(clsMajorBreaksSeqFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputMajorBreaksFrom.SetRCode(clsMajorBreaksSeqFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrPnlMinorBreaks.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputMinorBreaksFrom.SetRCode(clsMinorBreaksSeqFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputMinorBreaksTo.SetRCode(clsMinorBreaksSeqFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        ucrInputMinorBreaksInStepsOf.SetRCode(clsMinorBreaksSeqFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)

        ucrChkLabels.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)


        bRCodeSet = True
        If bReset Then
            ucrInputPositionDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrChkPositionDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrInputLimitDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrInputBreaksDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrChkDropUnusedLevels.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrInputDropUnusedLevels.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrPnlScaleDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrInputAxisType.SetName(strAxisType)
            ucrChkExpand.SetRCode(clsXYScaleContinuousFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrChkExpandDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrChkNaValueDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrInputNaValueDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
            ucrChkLabelsDiscrete.SetRCode(clsXYScaleDiscreteFunction, bReset, bCloneIfNeeded:=bCloneIfNeeded)
        End If
        SetLabel()
        AddRemoveContinuousXYScales()
        AddRemoveDiscreteXYScales()
    End Sub

    Private Sub AddRemoveLabs()
        If bRCodeSet Then
            If rdoNoTitle.Checked OrElse (rdoSpecifyTitle.Checked AndAlso Not ucrInputTitle.IsEmpty) Then
                clsBaseOperator.AddParameter(strAxis & "lab", clsRFunctionParameter:=clsXYlabTitleFunction)
            Else
                clsBaseOperator.RemoveParameterByName(strAxis & "lab")
            End If
        End If
    End Sub

    Private Sub SetLabel()
        If bRCodeSet Then
            If rdoTitleAuto.Checked Then
                clsXYlabTitleFunction.RemoveParameterByName("label")
            ElseIf rdoNoTitle.Checked Then
                clsXYlabTitleFunction.AddParameter("label", Chr(34) & Chr(34))
            Else
                clsXYlabTitleFunction.AddParameter("label", Chr(34) & ucrInputTitle.GetText() & Chr(34))
            End If
            AddRemoveLabs()
        End If
    End Sub

    Private Sub ucrPnlAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlAxisTitle.ControlValueChanged, ucrInputAxisType.ControlValueChanged
        SetLabel()
    End Sub

    Private Sub AddRemoveContinuousXYScales()
        If clsXYScaleContinuousFunction.clsParameters.Count > 0 Then
            clsBaseOperator.AddParameter("scale" & "_" & strAxis & "_" & "continuous", clsRFunctionParameter:=clsXYScaleContinuousFunction)

        Else
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & "continuous")
        End If
    End Sub

    Private Sub AddRemoveDiscreteXYScales()
        If clsXYScaleDiscreteFunction.clsParameters.Count > 0 Then
            clsBaseOperator.AddParameter("scale" & "_" & strAxis & "_" & "discrete", clsRFunctionParameter:=clsXYScaleDiscreteFunction)
        Else
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & "discrete")
        End If
    End Sub

    Private Sub AddRemoveScaleFunctions()
        If strAxisType = "continuous" Then
            AddRemoveContinuousXYScales()
            clsBaseOperator.AddParameter("scale" & "_" & strAxis & "_" & "continuous", clsRFunctionParameter:=clsXYScaleContinuousFunction)
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & "date")
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & "discrete")
        ElseIf strAxisType = "date" Then
            clsBaseOperator.AddParameter("scale" & "_" & strAxis & "_" & "date", clsRFunctionParameter:=clsXYScaleDateFunction)
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & "discrete")
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & "continuous")
        ElseIf strAxisType = "discrete" Then
            AddRemoveDiscreteXYScales()
            clsBaseOperator.AddParameter("scale" & "_" & strAxis & "_" & "discrete", clsRFunctionParameter:=clsXYScaleDiscreteFunction)
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & "continuous")
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & "date")
        End If
    End Sub

    Private Sub ucrInputAxisType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputAxisType.ControlValueChanged
        SetAxisTypeControls()
        AddRemoveScaleFunctions()
        ExpandControl()
    End Sub

    Private Sub SetAxisTypeControls()
        strAxisType = ucrInputAxisType.GetText()
        'hide all axis type lanels
        grpMajorBreaks.Hide()
        grpScales.Hide()
        grpScaleDiscrete.Hide()
        grpScaleXDate.Hide()
        If strAxisType.ToLower = "continuous" Then
            'show continous panels
            'TODO put controls in panels so group boxes can be used for multiple cases
            grpMajorBreaks.Show()
            grpMinorBreaks.Show()
            grpScales.Show()
            grpScaleDiscrete.Hide()
            grpMajorBreaksDiscrete.Hide()
        ElseIf strAxisType.ToLower = "discrete" Then
            'show discrete panels
            grpScaleDiscrete.Show()
            grpScaleXDate.Hide()
            grpMajorBreaks.Hide()
            grpMinorBreaks.Hide()
            grpScales.Hide()
            grpMajorBreaksDiscrete.Show()
        ElseIf strAxisType.ToLower = "date" Then
            'show date panels
            grpScaleXDate.Show()
            grpMajorBreaks.Hide()
            grpMinorBreaks.Hide()
            grpScales.Hide()
            grpScaleDiscrete.Hide()
            grpMajorBreaksDiscrete.Hide()
        End If
    End Sub

    Private Sub BreaksControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMajorBreaks.ControlValueChanged, ucrInputMajorBreaksCustom.ControlValueChanged
        If rdoMajorBreaksAuto.Checked Then
            clsXYScaleContinuousFunction.RemoveParameterByName("breaks")
        ElseIf rdoMajorBreaksNone.Checked Then
            clsXYScaleContinuousFunction.AddParameter("breaks", "NULL")
        ElseIf rdoMajorBreaksSeq.Checked Then
            clsXYScaleContinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsMajorBreaksSeqFunction)
        ElseIf rdoMajorBreaksCustom.Checked Then
            clsXYScaleContinuousFunction.AddParameter("breaks", "c(" & ucrInputMajorBreaksCustom.GetText() & ")")
        End If
        SetLabelsParameter()
        SetLabelsDiscreteParameter()
        AddRemoveContinuousXYScales()
        AddRemoveDiscreteXYScales()
    End Sub

    Private Sub ucrPnlMinorBreaks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMinorBreaks.ControlValueChanged
        If rdoMinorBreaksAuto.Checked Then
            clsXYScaleContinuousFunction.RemoveParameterByName("minor_breaks")
        ElseIf rdoMinorBreaksNone.Checked Then
            clsXYScaleContinuousFunction.AddParameter("minor_breaks", "NULL")
        ElseIf rdoMinorBreaksSeq.Checked Then
            clsXYScaleContinuousFunction.AddParameter("minor_breaks", clsRFunctionParameter:=clsMinorBreaksSeqFunction)
        ElseIf rdoMinorBreaksCustom.Checked Then
            clsXYScaleContinuousFunction.AddParameter("minor_breaks", "c(" & ucrInputMinorBreaksCustom.GetText() & ")")
        End If
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub ucrPnlScales_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlScales.ControlValueChanged, ucrInputLowerLimit.ControlValueChanged, ucrInputUpperLimit.ControlValueChanged
        If rdoScalesCustom.Checked AndAlso (Not ucrInputLowerLimit.IsEmpty AndAlso Not ucrInputUpperLimit.IsEmpty) Then
            clsXYScaleContinuousFunction.AddParameter("limits", clsRFunctionParameter:=clsLimitsFunction)
        Else
            clsXYScaleContinuousFunction.RemoveParameterByName("limits")
        End If
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub ucrPnlScaleDiscrete_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlScaleDiscrete.ControlValueChanged
        SetBreaksDiscrete()
        SetLimitsDiscrete()
    End Sub

    Private Sub ExpandControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExpand.ControlValueChanged, ucrInputExpand.ControlValueChanged
        If bRCodeSet Then
            If ucrChkExpand.Checked AndAlso Not ucrInputExpand.IsEmpty Then
                clsXYScaleContinuousFunction.AddParameter("expand", clsRFunctionParameter:=ucrInputExpand.clsRList)
            Else
                clsXYScaleContinuousFunction.RemoveParameterByName("expand")
            End If
            AddRemoveContinuousXYScales()
        End If
    End Sub

    Private Sub ScalesCheckboxes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExpand.ControlValueChanged, ucrChkPosition.ControlValueChanged, ucrChkNaValue.ControlValueChanged, ucrChkTransformation.ControlValueChanged, ucrChkExpandDiscrete.ControlValueChanged, ucrChkPositionDiscrete.ControlValueChanged, ucrChkNaValueDiscrete.ControlValueChanged, ucrChkDropUnusedLevels.ControlValueChanged
        AddRemoveContinuousXYScales()
        AddRemoveDiscreteXYScales()
        AddRemoveScaleFunctions()
    End Sub

    Private Sub LabelsControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabels.ControlValueChanged, ucrInputMajorBreaksLabels.ControlValueChanged
        SetLabelsParameter()
    End Sub

    Private Sub SetLabelsParameter()
        If (rdoMajorBreaksSeq.Checked OrElse rdoMajorBreaksCustom.Checked) AndAlso ucrChkLabels.Checked AndAlso Not ucrInputMajorBreaksLabels.IsEmpty() Then
            'TODO add functionality to input control to do this automatically for a list
            clsXYScaleContinuousFunction.AddParameter("labels", ucrInputMajorBreaksLabels.clsRList.ToScript())
        Else
            clsXYScaleContinuousFunction.RemoveParameterByName("labels")
        End If
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub SetLabelsDiscreteParameter()
        If ucrChkLabelsDiscrete.Checked AndAlso Not ucrInputMajorBreaksLabelsDiscrete.IsEmpty Then
            'TODO add functionality to input control to do this automatically for a list
            clsXYScaleDiscreteFunction.AddParameter("labels", ucrInputMajorBreaksLabelsDiscrete.clsRList.ToScript())
        Else
            clsXYScaleDiscreteFunction.RemoveParameterByName("labels")
        End If
        AddRemoveDiscreteXYScales()
    End Sub

    Private Sub SetBreaksDiscrete()
        If rdoBreaksDiscrete.Checked AndAlso Not ucrInputBreaksDiscrete.IsEmpty() Then
            'TODO add functionality to input control to do this automatically for a list
            clsXYScaleDiscreteFunction.AddParameter("breaks", ucrInputBreaksDiscrete.clsRList.ToScript())
        Else
            clsXYScaleDiscreteFunction.RemoveParameterByName("breaks")
        End If
        AddRemoveDiscreteXYScales()
    End Sub

    Private Sub SetLimitsDiscrete()
        If rdoLimitDiscrete.Checked AndAlso Not ucrInputLimitDiscrete.IsEmpty() Then
            'TODO add functionality to input control to do this automatically for a list
            clsXYScaleDiscreteFunction.AddParameter("limit", ucrInputLimitDiscrete.clsRList.ToScript())
        Else
            clsXYScaleDiscreteFunction.RemoveParameterByName("limit")
        End If
        AddRemoveDiscreteXYScales()
    End Sub

    Private Sub ScaleDateFunction_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLimits.ControlValueChanged, ucrChkBreaks.ControlValueChanged
        If bRCodeSet Then
            If ucrChkLimits.Checked Then
                clsXYScaleDateFunction.AddParameter("limits", clsRFunctionParameter:=clsXYScaleDateLimitFunction, iPosition:=2)
            End If
            If ucrChkBreaks.Checked Then
                clsXYScaleDateFunction.AddParameter("date_breaks", clsROperatorParameter:=clsXYScaleDateBreakOperator, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ExpandControl()
        If strAxisType = "discrete" Then
            If ucrChkExpandDiscrete.Checked AndAlso Not ucrInputExpandDiscrete.IsEmpty Then
                clsXYScaleDiscreteFunction.AddParameter("expand", clsRFunctionParameter:=ucrInputExpandDiscrete.clsRList)
            Else
                clsXYScaleDiscreteFunction.RemoveParameterByName("expand")
            End If
        Else
            clsXYScaleDiscreteFunction.RemoveParameterByName("expand")
        End If
    End Sub

    Private Sub ucrInputExpandDiscrete_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputExpandDiscrete.ControlValueChanged
        ExpandControl()
        AddRemoveScaleFunctions()
        AddRemoveDiscreteXYScales()
    End Sub

    Private Sub ucrChkExpandDiscrete_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExpandDiscrete.ControlValueChanged
        ExpandControl()
        AddRemoveScaleFunctions()
        AddRemoveDiscreteXYScales()
    End Sub

    Private Sub ucrChkLabelsDiscrete_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabelsDiscrete.ControlValueChanged, ucrInputMajorBreaksLabelsDiscrete.ControlValueChanged
        SetLabelsDiscreteParameter()
    End Sub

    Private Sub ucrInputBreaksDiscrete_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBreaksDiscrete.ControlValueChanged
        SetBreaksDiscrete()
    End Sub

    Private Sub ucrInputLimitDiscrete_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLimitDiscrete.ControlValueChanged
        SetLimitsDiscrete()
    End Sub
End Class
