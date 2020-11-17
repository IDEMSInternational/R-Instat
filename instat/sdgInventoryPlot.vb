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
Public Class sdgInventoryPlot
    Private bControlsInitialised As Boolean = False
    Private clsInventory As New RFunction
    Public strAxisType As String

    Private Sub sdgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctDateFormat As New Dictionary(Of String, String)
        Dim dctXScaleFormat As New Dictionary(Of String, String)
        Dim dctXScaledateFormat As New Dictionary(Of String, String)

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

        ucrNudTitleSize.SetParameter(New RParameter("title_size"))
        ucrNudTitleSize.Increment = 0.1
        ucrNudTitleSize.Minimum = 0

        ucrNudSubTitleSize.SetParameter(New RParameter("subtitle_size"))
        ucrNudSubTitleSize.Increment = 0.1
        ucrNudSubTitleSize.Minimum = 0

        ucrNudCaptionSize.SetParameter(New RParameter("caption_size"))
        ucrNudCaptionSize.Increment = 0.1
        ucrNudCaptionSize.Minimum = 0

        ucrChkXAxisLabelSize.SetText("Size")
        ucrChkXAxisLabelSize.SetParameter(New RParameter("xSize"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudXaxisLabelSize.SetParameter(New RParameter("xSize"))
        ucrNudXaxisLabelSize.Increment = 0.1
        ucrNudXaxisLabelSize.Minimum = 0



        ucrNudYAxisTitleSize.SetParameter(New RParameter("ySize"))
        ucrNudYAxisTitleSize.Increment = 0.1
        ucrNudYAxisTitleSize.Minimum = 0

        ucrChkXAxisAngle.SetText("Angle")
        ucrChkXAxisAngle.SetParameter(New RParameter("Xangle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudXAxisAngle.SetMinMax(0, 360)
        ucrNudXAxisAngle.SetParameter(New RParameter("Xangle"))

        ucrChkYAxisAngle.SetText("Angle")
        ucrChkYAxisAngle.SetParameter(New RParameter("Yangle"), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrNudYAxisAngle.SetMinMax(0, 360)
        ucrNudYAxisAngle.SetParameter(New RParameter("Yangle"))


        ucrChkXAxisAngle.AddToLinkedControls(ucrNudXAxisAngle, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkXAxisLabelSize.AddToLinkedControls(ucrNudXaxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkYAxisAngle.AddToLinkedControls(ucrNudYAxisAngle, {True}, bNewLinkedHideIfParameterMissing:=True)


        ucrChkInputAxisType.SetText("Axis type")
        dctXScaledateFormat.Add("None", Chr(34) & "None" & Chr(34))
        dctXScaledateFormat.Add("Date", Chr(34) & "date" & Chr(34))
        ucrInputAxisType.SetParameter(New RParameter("scale_xdate"))
        ucrInputAxisType.SetItems(dctXScaledateFormat)
        ucrInputAxisType.SetDropDownStyleAsNonEditable()

        ucrChkInputAxisType.SetParameter(New RParameter("scale_xdate"), bNewChangeParameterValue:=False)
        ucrChkInputAxisType.AddToLinkedControls(ucrInputAxisType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Year(4-digit)-Month-Day")


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


        ucrChkDateLabels.SetText("Date labels")
        ucrInputComboDateLabel.SetParameter(New RParameter("date_xlabels"))
        ucrInputComboDateLabel.SetItems(dctDateFormat)
        ucrInputComboDateLabel.SetDropDownStyleAsEditable(bAdditionsAllowed:=True)

        ucrChkDateLabels.SetParameter(New RParameter("date_xlabels"), bNewChangeParameterValue:=False)
        ucrChkDateLabels.AddToLinkedControls(ucrInputComboDateLabel, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Year(4-digit)-Month-Day")

        ucrNudDateBreak.SetParameter(New RParameter("byXaxis"))

        dctXScaleFormat.Add("Year", Chr(34) & "year" & Chr(34))
        dctXScaleFormat.Add("Month", Chr(34) & "month" & Chr(34))
        dctXScaleFormat.Add("Week", Chr(34) & "week" & Chr(34))
        dctXScaleFormat.Add("Day", Chr(34) & "day" & Chr(34))
        dctXScaleFormat.Add("Hour", Chr(34) & "hour" & Chr(34))
        dctXScaleFormat.Add("Min", Chr(34) & "min" & Chr(34))
        dctXScaleFormat.Add("Sec", Chr(34) & "sec" & Chr(34))
        ucrInputComboDateBreak.SetParameter(New RParameter("Xduration"))
        ucrInputComboDateBreak.SetItems(dctXScaleFormat)
        'ucrInputComboDateBreak.SetName("year")
        ucrInputComboDateBreak.SetDropDownStyleAsNonEditable()
        ucrInputComboDateBreak.AddQuotesIfUnrecognised = False

        ucrChkBreaks.SetText("Breaks")
        ucrChkBreaks.SetParameter(New RParameter("byXaxis"), bNewChangeParameterValue:=False)
        ucrChkBreaks.AddToLinkedControls(ucrInputComboDateBreak, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="year")
        ucrChkBreaks.AddToLinkedControls(ucrNudDateBreak, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="1")



        ucrDtpLowerLimit.SetParameter(New RParameter("fromXAxis"))
        ucrDtpUpperLimit.SetParameter(New RParameter("toXAxis"))
        ucrDtpLowerLimit.ValueAsRDate()
        ucrDtpUpperLimit.ValueAsRDate()

        ucrDtpUpperLimit.SetLinkedDisplayControl(lblXScalDateUpperLimit)
        ucrDtpLowerLimit.SetLinkedDisplayControl(lbXscaleDateLowerLimit)

        ucrChkLimits.AddToLinkedControls(ucrDtpLowerLimit, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLimits.AddToLinkedControls(ucrDtpUpperLimit, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrDtpUpperLimit.SetLinkedDisplayControl(lblXScalDateUpperLimit)
        ucrDtpLowerLimit.SetLinkedDisplayControl(lbXscaleDateLowerLimit)

        ucrChkLimits.SetText("Limits")
        ucrChkLimits.SetParameter(New RParameter("fromXAxis"), bNewChangeParameterValue:=False)


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
    Public Sub SetRCode(clsInventoryNew As RFunction, Optional strNewAxisType As String = "None", Optional bReset As Boolean = False)
        clsInventory = clsInventoryNew
        strAxisType = strNewAxisType


        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        If bReset Then
            tbInventory.SelectedIndex = 0
        End If

        ucrInputAxisType.SetName(strAxisType)

        ucrInputGraphTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputGraphSubTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputGraphcCaption.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudSubTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudCaptionSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudXaxisLabelSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkXAxisLabelSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudYAxisTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputXAxisTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkYAxisAngle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudYAxisAngle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkBreaks.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputAxisType.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkLimits.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkDateLabels.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkInputAxisType.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkLegendPosition.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputYAxisTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudXAxisAngle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrChkXAxisAngle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudDateBreak.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrInputComboDateBreak.SetRCode(clsInventory, bReset, bCloneIfNeeded:=False)
        ucrInputComboDateLabel.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrDtpLowerLimit.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrDtpUpperLimit.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrPnlXAxisTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        UcrPnlYAxisTitle.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)


        SetXLabel()
        SetYLabel()

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
    Private Sub SetAxisTypeControls()
        strAxisType = ucrInputAxisType.GetText()

        If strAxisType.ToLower = "date" Then
            'show date panels
            grpScaleXDate.Show()
        Else
            grpScaleXDate.Hide()
        End If
    End Sub
    Private Sub ucrPnlXAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlXAxisTitle.ControlValueChanged, ucrInputXAxisTitle.ControlValueChanged
        SetXLabel()

    End Sub

    Private Sub UcrPnlYAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles UcrPnlYAxisTitle.ControlValueChanged, ucrInputYAxisTitle.ControlValueChanged
        SetYLabel()

    End Sub

    Private Sub ucrInputAxisType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputAxisType.ControlValueChanged
        SetAxisTypeControls()
    End Sub
End Class