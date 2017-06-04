' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Public Class ucrAxes
    Public bIsX As Boolean
    Public clsXYlabTitleFunction As RFunction
    Public clsXYScaleContinuousFunction As New RFunction
    Public clsXlabTitleFunction As New RFunction
    Public clsBaseOperator As New ROperator
    Public clsScalecontinuousFunction As New RFunction
    Public clsSeqFunction As New RFunction
    Public strAxis As String
    Public bFirstLoad As Boolean = True
    Private bInitialiseControls As Boolean = False
    Private bRCodeSet As Boolean = False

    Public Sub InitialiseControl()
        Dim dctTickMarkers As New Dictionary(Of String, String)

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
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)

        ucrInputTitle.SetParameter(New RParameter("label"))

        'temp disabled, not yet implemented
        grpTickMarkers.Enabled = False
        'Tick Markers section
        'ucrPnlTickmarkers.AddRadioButton(rdoTickMarkersAuto)
        'ucrPnlTickmarkers.AddRadioButton(rdoTickMarkersCustom)
        'ucrPnlTickmarkers.AddParameterPresentCondition(rdoTickMarkersAuto, "breaks", False)
        'ucrPnlTickmarkers.AddParameterPresentCondition(rdoTickMarkersCustom, "breaks", True)
        'ucrPnlTickmarkers.AddToLinkedControls(ucrTickMarkers, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlTickmarkers.AddToLinkedControls(ucrTickMarkers, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrPnlTickmarkers.AddToLinkedControls(ucrNudFrom, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrNudFrom.SetLinkedDisplayControl(lblFrom)

        'ucrPnlTickmarkers.AddToLinkedControls(ucrNudTo, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrNudTo.SetLinkedDisplayControl(lblTo)

        'ucrPnlTickmarkers.AddToLinkedControls(ucrNudInStepsOf, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrNudInStepsOf.SetLinkedDisplayControl(lblInStepsOf)

        'ucrPnlTickmarkers.AddToLinkedControls(ucrNudTickMarkersNoOfDecimalPlaces, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrNudTickMarkersNoOfDecimalPlaces.SetLinkedDisplayControl(lblTickMarkersNoOfDecimalPlaces)
        'ucrTickMarkers.SetName("Interval")
        'ucrTickMarkers.SetItems({"Interval", "Specific Values"})

        'ucrPnlTickmarkers.AddParameterPresentCondition(rdoTickMarkersAuto, "breaks", False)
        'ucrPnlTickmarkers.AddParameterPresentCondition(rdoTickMarkersCustom, "breaks", True)
        'ucrSpecificValues.SetParameter(New RParameter("breaks"))
        'ucrSpecificValues.AddQuotesIfUnrecognised = False
        'ucrSpecificValues.SetValidationTypeAsNumericList()

        'these add parameters to clsSeqFunction
        'ucrNudInStepsOf.SetParameter(New RParameter("by"))
        'ucrNudTo.SetParameter(New RParameter("to"))
        'ucrNudFrom.SetParameter(New RParameter("from"))

        'Scales section
        'temp disabled, not yet implemented
        grpScales.Enabled = False
        'ucrPnlScales.AddRadioButton(rdoScalesAuto)
        'ucrPnlScales.AddParameterPresentCondition(rdoScalesAuto, "limits", False)
        'ucrPnlScales.AddRadioButton(rdoScalesCustom)
        'ucrPnlScales.AddParameterPresentCondition(rdoScalesCustom, "limits", True)
        'ucrPnlScales.AddToLinkedControls(ucrInputLowerLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlScales.AddToLinkedControls(ucrInputUpperLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrInputLowerLimit.SetLinkedDisplayControl(lblLowerLimit)
        'ucrInputUpperLimit.SetLinkedDisplayControl(lblUpperLimit)
        bInitialiseControls = True
    End Sub

    Public Sub SetRCodeForControl(bIsXAxis As Boolean, Optional clsNewXYScaleContinuousFunction As RFunction = Nothing, Optional clsNewXYlabTitleFunction As RFunction = Nothing, Optional clsNewBaseOperator As ROperator = Nothing, Optional bReset As Boolean = False)
        bRCodeSet = False
        If Not bInitialiseControls Then
            InitialiseControl()
        End If
        clsBaseOperator = clsNewBaseOperator
        bIsX = bIsXAxis

        If bIsXAxis Then
            bIsX = True
            strAxis = "x"
        Else
            bIsX = False
            strAxis = "y"
        End If

        clsXYlabTitleFunction = clsNewXYlabTitleFunction
        clsXYScaleContinuousFunction = clsNewXYScaleContinuousFunction

        ucrPnlAxisTitle.SetRCode(clsXYlabTitleFunction, bReset)
        ucrInputTitle.SetRCode(clsXYlabTitleFunction, bReset)

        'scales functions
        'Temp disabled, not yet implemented
        'ucrPnlScales.SetRCode(clsXYScaleContinuousFunction, bReset)
        'ucrInputLowerLimit.SetRCode(clsXYScaleContinuousFunction, bReset)
        'ucrInputUpperLimit.SetRCode(clsXYScaleContinuousFunction, bReset)
        'ucrPnlTickmarkers.SetRCode(clsXYScaleContinuousFunction, bReset)
        'ucrSpecificValues.SetRCode(clsXYScaleContinuousFunction, bReset)

        'Temp disabled, not yet implemented
        'ucrNudInStepsOf.SetRCode(clsSeqFunction, bReset)
        'clsSeqFunction.AddParameter("by", 0)
        'ucrNudTo.SetRCode(clsSeqFunction, bReset)
        'clsSeqFunction.AddParameter("to", 0)
        'ucrNudFrom.SetRCode(clsSeqFunction, bReset)
        'clsSeqFunction.AddParameter("from", 0)

        bRCodeSet = True
        SetLabel()
        AddRemoveXYScales()
    End Sub

    Private Sub ucrNudTickMarkersNoOfDecimalPlaces_ControlContentsChanged() Handles ucrNudTickMarkersNoOfDecimalPlaces.ControlContentsChanged
        'ucrNudFrom.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
        'ucrNudTo.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
        'ucrNudInStepsOf.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
    End Sub

    Private Sub ucrTickMarkers_ControlValueChanged() Handles ucrTickMarkers.ControlValueChanged, ucrPnlTickmarkers.ControlValueChanged
        'If rdoTickMarkersCustom.Checked AndAlso ucrTickMarkers.cboInput.SelectedItem = "Interval" Then
        '    clsSeqFunction.SetRCommand("seq")
        '    clsXYScaleContinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsSeqFunction)

        'ElseIf ucrTickMarkers.cboInput.SelectedItem = "Specific Values" Then
        '    clsXYScaleContinuousFunction.RemoveParameterByName("breaks")
        'End If
        'tickMarkersDisplay()
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

    Private Sub ucrPnlAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlAxisTitle.ControlValueChanged, ucrInputTitle.ControlValueChanged
        SetLabel()
    End Sub

    Private Sub AddRemoveXYScales()
        'If rdoScalesCustom.Checked AndAlso (Not ucrInputLowerLimit.IsEmpty AndAlso Not ucrInputUpperLimit.IsEmpty) Then
        '    clsBaseOperator.AddParameter(strAxis & "scales", clsRFunctionParameter:=clsXYScaleContinuousFunction)
        'Else
        '    clsBaseOperator.RemoveParameterByName(strAxis & "scales")
        'End If
    End Sub

    Private Sub ucrPnlScales_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlScales.ControlValueChanged, ucrInputLowerLimit.ControlValueChanged, ucrInputUpperLimit.ControlValueChanged
        ''If ucrChangedControl.Equals(ucrPnlScales) Then
        'If rdoScalesCustom.Checked AndAlso (Not ucrInputLowerLimit.IsEmpty AndAlso Not ucrInputUpperLimit.IsEmpty) Then
        '    Dim strLowerLimit As String = ucrInputLowerLimit.GetText
        '    Dim strUpperLimit As String = ucrInputUpperLimit.GetText
        '    clsXYScaleContinuousFunction.AddParameter("limits", "c(" & strLowerLimit & "," & strUpperLimit & ")")
        'End If

        '' End If
        'AddRemoveXScales()
    End Sub

    Private Sub tickMarkersDisplay()
        'If rdoTickMarkersCustom.Checked AndAlso ucrTickMarkers.GetText = "Specific Values" Then
        '    ucrSpecificValues.Visible = True
        '    ucrNudFrom.Visible = False
        '    lblFrom.Visible = False
        '    ucrNudTo.Visible = False
        '    lblTo.Visible = False
        '    ucrNudTickMarkersNoOfDecimalPlaces.Visible = False
        '    lblTickMarkersNoOfDecimalPlaces.Visible = False
        '    ucrNudInStepsOf.Visible = False
        '    lblInStepsOf.Visible = False
        'Else
        '    ucrSpecificValues.Visible = False
        '    ucrNudFrom.Visible = True
        '    lblFrom.Visible = True
        '    ucrNudTo.Visible = True
        '    lblTo.Visible = True
        '    ucrNudTickMarkersNoOfDecimalPlaces.Visible = True
        '    lblTickMarkersNoOfDecimalPlaces.Visible = True
        '    ucrNudInStepsOf.Visible = True
        '    lblInStepsOf.Visible = True
        'End If
    End Sub
End Class

