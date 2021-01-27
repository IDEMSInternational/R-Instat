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
Public Class sdgInventoryPlot
    Private bControlsInitialised As Boolean = False
    Private clsInventory As New RFunction
    Public bRCodeSet As Boolean = False

    Private Sub sdgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctScale As New Dictionary(Of String, String)
        Dim dctLabelForDays As New Dictionary(Of String, String)
        Dim dctDateTimePeriods As New Dictionary(Of String, String)

        'facets tab  
        ucrChkFacetXSize.SetText("Size X-Axis")
        ucrChkFacetXSize.SetParameter(New RParameter("facet_xsize"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudFacetXSize.SetParameter(New RParameter("facet_xsize"))
        ucrChkFacetXSize.AddToLinkedControls(ucrNudFacetXSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=7)

        ucrChkFacetYSize.SetText("Size Y-Axis")
        ucrChkFacetYSize.SetParameter(New RParameter("facet_ysize"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudFacetYSize.SetParameter(New RParameter("facet_ysize"))
        ucrChkFacetYSize.AddToLinkedControls(ucrNudFacetYSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=11)


        ucrChkScales.SetText("Scales")
        ucrChkScales.SetParameter(New RParameter("scale"))
        ucrChkScales.AddToLinkedControls(ucrInputScale, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Free_y")
        ucrInputScale.SetParameter(New RParameter("scale"))
        dctScale.Add("None", Chr(34) & "none" & Chr(34))
        dctScale.Add("Free_y", Chr(34) & "free_y" & Chr(34))
        dctScale.Add("Free_x", Chr(34) & "free_x" & Chr(34))
        dctScale.Add("Free", Chr(34) & "free" & Chr(34))
        dctScale.Add("Fixed", Chr(34) & "fixed" & Chr(34))
        ucrInputScale.SetItems(dctScale)
        ucrInputScale.SetDropDownStyleAsNonEditable()
        ucrChkScales.AddParameterPresentCondition(True, "scale")
        ucrChkScales.AddParameterPresentCondition(False, "scale", False)

        ucrChkNoOfRowsorColumns.SetText("Fixed Number of Rows")
        ucrChkNoOfRowsorColumns.AddParameterPresentCondition(True, {"nrow", "ncol"}, True)
        ucrChkNoOfRowsorColumns.AddParameterPresentCondition(False, {"nrow", "ncol"}, False)
        ucrNudNumberofRowsOrcolumns.SetParameter(New RParameter("nrow"))
        ucrNudNumberofRowsOrcolumns.SetMinMax(1, Integer.MaxValue)
        ucrNudNumberofRowsOrcolumns.bAddRemoveParameter = False

        ucrChkNoOfRowsorColumns.AddToLinkedControls(ucrNudNumberofRowsOrcolumns, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        'Not setting parameter to write because of complex conditions for adding/removing this parameter
        'Conditions in place for reading function
        ucrPnlHorizonatalVertical.SetParameter(New RParameter("dir"))
        ucrPnlHorizonatalVertical.bChangeParameterValue = False
        ucrPnlHorizonatalVertical.AddRadioButton(rdoVertical)
        ucrPnlHorizonatalVertical.AddRadioButton(rdoHorizontal)
        ucrPnlHorizonatalVertical.AddParameterValuesCondition(rdoVertical, "dir", Chr(34) & "v" & Chr(34))
        ucrPnlHorizonatalVertical.AddParameterValuesCondition(rdoHorizontal, "dir", Chr(34) & "h" & Chr(34))
        ucrPnlHorizonatalVertical.SetRDefault(Chr(34) & "h" & Chr(34))

        ucrPnlXAxisTitle.AddRadioButton(rdoAutoXAxis)
        ucrPnlXAxisTitle.AddRadioButton(rdoNoTitleXAxisTitle)
        ucrPnlXAxisTitle.AddRadioButton(rdoSpecifyXAxisTitle)
        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoAutoXAxis, "labelXAxis", False)
        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoNoTitleXAxisTitle, "labelXAxis", True)
        ucrPnlXAxisTitle.AddParameterValuesCondition(rdoNoTitleXAxisTitle, "labelXAxis", Chr(34) & Chr(34), True)
        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoSpecifyXAxisTitle, "labelXAxis", True)
        ucrPnlXAxisTitle.AddParameterValuesCondition(rdoSpecifyXAxisTitle, "labelXAxis", Chr(34) & Chr(34), False)
        ucrPnlXAxisTitle.AddToLinkedControls(ucrInputXAxisTitle, {rdoSpecifyXAxisTitle}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputXAxisTitle.SetParameter(New RParameter("labelXAxis"))

        UcrPnlYAxisTitle.AddRadioButton(rdoAutoYAxis)
        UcrPnlYAxisTitle.AddRadioButton(rdoNoYAxisTitle)
        UcrPnlYAxisTitle.AddRadioButton(rdoSpecifyYAxisTitle)
        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoAutoYAxis, "labelYAxis", False)
        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoNoYAxisTitle, "labelYAxis", True)
        UcrPnlYAxisTitle.AddParameterValuesCondition(rdoNoYAxisTitle, "labelYAxis", Chr(34) & Chr(34), True)
        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoSpecifyYAxisTitle, "labelYAxis", True)
        UcrPnlYAxisTitle.AddParameterValuesCondition(rdoSpecifyYAxisTitle, "labelYAxis", Chr(34) & Chr(34), False)
        UcrPnlYAxisTitle.AddToLinkedControls(ucrInputYAxisTitle, {rdoSpecifyYAxisTitle}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputYAxisTitle.SetParameter(New RParameter("labelYAxis"))
        ucrInputGraphTitle.SetParameter(New RParameter("graph_title"))
        ucrInputGraphSubTitle.SetParameter(New RParameter("graph_subtitle"))
        ucrInputGraphcCaption.SetParameter(New RParameter("graph_caption"))
        ttInventoryPlot.SetToolTip(ucrInputGraphcCaption.txtInput, "Type \n where you would like a new-line")

        ucrNudTitleSize.SetParameter(New RParameter("title_size"))
        ucrNudTitleSize.SetRDefault(20)

        ucrNudSubTitleSize.SetParameter(New RParameter("subtitle_size"))
        ucrNudSubTitleSize.SetRDefault(15)

        ucrNudCaptionSize.SetParameter(New RParameter("caption_size"))
        ucrNudCaptionSize.SetRDefault(8)

        ucrNudXaxisTitleSize.SetParameter(New RParameter("xlabelsize"))
        ucrNudXaxisTitleSize.SetRDefault(14)

        ucrNudYAxisTitleSize.SetParameter(New RParameter("ylabelsize"))
        ucrNudYAxisTitleSize.SetRDefault(14)

        ucrChkXAxisLabelSize.SetText("Size")
        ucrChkXAxisLabelSize.SetParameter(New RParameter("xSize"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudXAxisLabelSize.SetParameter(New RParameter("xSize"))

        ucrChkXAxisAngle.SetText("Angle")
        ucrChkXAxisAngle.SetParameter(New RParameter("Xangle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudXAxisAngle.SetParameter(New RParameter("Xangle"))
        ucrNudXAxisAngle.SetMinMax(0, 360)

        ucrChkXAxisAngle.AddToLinkedControls(ucrNudXAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=90)
        ucrChkXAxisLabelSize.AddToLinkedControls(ucrNudXAxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=12)

        ucrInputXInStepsOf.SetParameter(New RParameter("byXaxis"))
        ucrInputXInStepsOf.SetValidationTypeAsNumeric()
        ucrInputXInStepsOf.AddQuotesIfUnrecognised = False
        ucrInputXFrom.SetParameter(New RParameter("fromXAxis"))
        ucrInputXFrom.SetValidationTypeAsNumeric()
        ucrInputXFrom.AddQuotesIfUnrecognised = False
        ucrInputXTo.SetParameter(New RParameter("toXAxis"))
        ucrInputXTo.SetValidationTypeAsNumeric()
        'ucrInputXTo.SetRDefault(1)
        ucrInputXTo.AddQuotesIfUnrecognised = False
        ucrChkSpecifyXAxisTickMarks.SetText("Specify Breaks")
        ucrChkSpecifyXAxisTickMarks.SetRDefault("TRUE")
        ucrChkSpecifyXAxisTickMarks.SetParameter(New RParameter("scale_xdate"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrChkSpecifyXAxisTickMarks.AddToLinkedControls({ucrInputXFrom, ucrInputXTo, ucrInputXInStepsOf}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputXFrom.SetLinkedDisplayControl(lblXFrom)
        ucrInputXTo.SetLinkedDisplayControl(lblXTo)
        ucrInputXInStepsOf.SetLinkedDisplayControl(lblXInStepsOf)

        dctLabelForDays.Add("Day Number (1-366)", Chr(34) & "%j" & Chr(34))
        dctLabelForDays.Add("Day Month (1 Jan)", Chr(34) & "%d %b" & Chr(34))
        dctLabelForDays.Add("Day Month Full (1 January)", Chr(34) & "%d %B" & Chr(34))
        ucrInputDateDisplayFormat.SetParameter(New RParameter("date_ylabels"))
        ucrInputDateDisplayFormat.SetItems(dctLabelForDays)
        ucrInputDateDisplayFormat.SetDropDownStyleAsNonEditable()
        ucrInputDateDisplayFormat.SetLinkedDisplayControl(lblDateDisplayFormat)

        dctDateTimePeriods.Add("Default", Chr(34) & "NULL" & Chr(34))
        dctDateTimePeriods.Add("Days", Chr(34) & "day" & Chr(34))
        dctDateTimePeriods.Add("Weeks", Chr(34) & "week" & Chr(34))
        dctDateTimePeriods.Add("Months", Chr(34) & "month" & Chr(34))
        dctDateTimePeriods.Add("Years", Chr(34) & "year" & Chr(34))

        ucrInputDateBreakTime.SetParameter(New RParameter("date_ybreaks"))
        ucrInputDateBreakTime.SetItems(dctDateTimePeriods)
        ucrInputDateBreakTime.SetDropDownStyleAsNonEditable()

        ucrNudDateBreakNumber.Minimum = 1
        ucrNudDateBreakNumber.Increment = 1
        ucrNudDateBreakNumber.SetParameter(New RParameter("step"))

        ucrChkSpecifyDateBreaks.SetText("Specify Breaks")
        ucrChkSpecifyDateBreaks.SetRDefault("TRUE")
        ucrChkSpecifyDateBreaks.SetParameter(New RParameter("scale_ydate"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkSpecifyDateBreaks.AddToLinkedControls(ucrInputDateDisplayFormat, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Day Month (1 Jan)")
        ucrChkSpecifyDateBreaks.AddToLinkedControls(ucrInputDateBreakTime, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Months")
        ucrChkSpecifyDateBreaks.AddToLinkedControls(ucrNudDateBreakNumber, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkYAxisAngle.SetText("Angle")
        ucrChkYAxisAngle.SetParameter(New RParameter("Yangle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudYAxisAngle.SetParameter(New RParameter("Yangle"))
        ucrNudYAxisAngle.SetMinMax(0, 360)

        ucrChkYAxisLabelSize.SetText("Size")
        ucrChkYAxisLabelSize.SetParameter(New RParameter("ySize"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudYAxisLabelSize.SetParameter(New RParameter("ySize"))
        'ucrNudYAxisLabelSize.Increment = 0.1
        ucrNudYAxisLabelSize.Minimum = 1

        ucrChkYAxisAngle.AddToLinkedControls(ucrNudYAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=90)
        ucrChkYAxisLabelSize.AddToLinkedControls(ucrNudYAxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=12)

        ucrChkLegendPosition.SetText("Legend Position")
        ucrChkLegendPosition.AddToLinkedControls(ucrInputLegendPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend_position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        ucrChkLegendPosition.AddParameterPresentCondition(True, "legend_position")
        ucrChkLegendPosition.AddParameterPresentCondition(False, "legend_position", False)

        bControlsInitialised = True
    End Sub
    Public Sub SetRCode(clsInventoryNew As RFunction, Optional bReset As Boolean = False)
        clsInventory = clsInventoryNew
        bRCodeSet = False

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        If bReset Then
            tbInventory.SelectedIndex = 0
        End If

        ucrInputGraphTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputGraphSubTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputGraphcCaption.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudSubTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudCaptionSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudXaxisTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkXAxisLabelSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudYAxisTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputXAxisTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputXTo.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkSpecifyDateBreaks.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudDateBreakNumber.SetRCode(clsInventoryNew, bReset, bCloneIfNeeded:=True)
        ucrChkFacetXSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkFacetYSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkYAxisAngle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputDateDisplayFormat.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputDateBreakTime.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkNoOfRowsorColumns.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudNumberofRowsOrcolumns.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudXAxisLabelSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputScale.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkYAxisLabelSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudYAxisAngle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudFacetXSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudFacetYSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudYAxisLabelSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputXFrom.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkScales.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkSpecifyXAxisTickMarks.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputXInStepsOf.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkLegendPosition.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputYAxisTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudXAxisAngle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkXAxisAngle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrPnlXAxisTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        UcrPnlYAxisTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrPnlHorizonatalVertical.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)

        bRCodeSet = True

        SetXLabel()
        SetYLabel()
        SetFacetParameter()

    End Sub

    Private Sub SetXLabel()
        If rdoAutoXAxis.Checked Then
            clsInventory.RemoveParameterByName("labelXAxis")
        ElseIf rdoNoTitleXAxisTitle.Checked Then
            clsInventory.AddParameter("labelXAxis", Chr(34) & Chr(34))
        Else
            clsInventory.AddParameter("labelXAxis", Chr(34) & ucrInputXAxisTitle.GetText() & Chr(34))
        End If
    End Sub

    Private Sub SetYLabel()
        If rdoAutoYAxis.Checked Then
            clsInventory.RemoveParameterByName("labelYAxis")
        ElseIf rdoNoYAxisTitle.Checked Then
            clsInventory.AddParameter("labelYAxis", Chr(34) & Chr(34))
        Else
            clsInventory.AddParameter("labelYAxis", Chr(34) & ucrInputYAxisTitle.GetText() & Chr(34))
        End If
    End Sub
    Public Sub SetFacetParameter()
        If bRCodeSet Then
            If rdoHorizontal.Checked Then
                ucrChkNoOfRowsorColumns.SetText("Fixed Number of Rows")
                ucrNudNumberofRowsOrcolumns.ChangeParameterName("nrow")
            ElseIf rdoVertical.Checked Then
                ucrChkNoOfRowsorColumns.SetText("Fixed Number of Columns")
                ucrNudNumberofRowsOrcolumns.ChangeParameterName("ncol")
            End If
            If ucrChkNoOfRowsorColumns.Checked Then
                clsInventory.AddParameter(ucrNudNumberofRowsOrcolumns.GetParameter())
            Else
                clsInventory.RemoveParameter(ucrNudNumberofRowsOrcolumns.GetParameter())
            End If
        End If
    End Sub

    Private Sub ucrPnlXAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlXAxisTitle.ControlValueChanged, ucrInputXAxisTitle.ControlValueChanged
        SetXLabel()

    End Sub

    Private Sub UcrPnlYAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrPnlYAxisTitle.ControlValueChanged, ucrInputYAxisTitle.ControlValueChanged
        SetYLabel()

    End Sub

    Private Sub ucrPnlHorizonatalVertical_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlHorizonatalVertical.ControlValueChanged
        SetFacetParameter()

    End Sub

    Private Sub ucrChkNoOfRowsorColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNoOfRowsorColumns.ControlValueChanged
        SetFacetParameter()
    End Sub

End Class