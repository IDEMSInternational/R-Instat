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
    Public clsXScalecontinuousFunction As New RFunction
    Public clsXlabTitleFunction As New RFunction
    Public clsBaseOperator As New ROperator
    Public clsScalecontinuousFunction As New RFunction
    Public clsSeqFunction As New RFunction
    Public strAxis As String
    Public bFirstLoad As Boolean = True
    Dim bInitialiseControls As Boolean = False

    Public Sub SetYOrX(bNewIsXorY As Boolean)
        bIsX = bNewIsXorY
    End Sub

    Private Sub SetDefaults()
        ucrTickMarkers.SetName("Interval")
        ucrInputTitle.SetName("")
        ucrNudTickMarkersNoOfDecimalPlaces.Value = 0
        ucrNudFrom.Value = 0
        ucrNudTo.Value = 0
        ucrNudInStepsOf.Value = 0
    End Sub

    Public Sub InitialiseControl()
        Dim dctTickMarkers As New Dictionary(Of String, String)

        'Axis Section
        ucrPnlAxisTitle.AddRadioButton(rdoTitleAuto)
        ucrPnlAxisTitle.AddRadioButton(rdoNoTitle)
        ucrPnlAxisTitle.AddRadioButton(rdoSpecifyTitle)
        ucrPnlAxisTitle.AddParameterPresentCondition(rdoTitleAuto, "label", False)
        ucrPnlAxisTitle.AddParameterValuesCondition(rdoNoTitle, "label", Chr(34) & Chr(34), True)
        ucrPnlAxisTitle.AddParameterValuesCondition(rdoSpecifyTitle, "label", Chr(34) & Chr(34), False)
        ucrPnlAxisTitle.AddToLinkedControls(ucrInputTitle, {rdoSpecifyTitle}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)

        ucrInputTitle.SetParameter(New RParameter("label"))

        'Tick Markers section
        ucrPnlTickmarkers.AddRadioButton(rdoTickMarkersAuto)
        ucrPnlTickmarkers.AddRadioButton(rdoTickMarkersCustom)
        ucrPnlTickmarkers.AddParameterPresentCondition(rdoTickMarkersAuto, "breaks", False)
        ucrPnlTickmarkers.AddParameterPresentCondition(rdoTickMarkersCustom, "breaks", True)
        ucrPnlTickmarkers.AddToLinkedControls(ucrTickMarkers, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlTickmarkers.AddToLinkedControls(ucrNudFrom, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)

        ucrPnlTickmarkers.AddToLinkedControls(ucrNudTo, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudTo.SetLinkedDisplayControl(lblTo)

        ucrPnlTickmarkers.AddToLinkedControls(ucrNudInStepsOf, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudInStepsOf.SetLinkedDisplayControl(lblInStepsOf)

        ucrPnlTickmarkers.AddToLinkedControls(ucrNudTickMarkersNoOfDecimalPlaces, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudTickMarkersNoOfDecimalPlaces.SetLinkedDisplayControl(lblTickMarkersNoOfDecimalPlaces)

        ucrTickMarkers.SetParameter(New RParameter("breaks"))
        dctTickMarkers.Add("Interval", Chr(34) & "" & Chr(34))
        dctTickMarkers.Add("Specific Values", Chr(34) & "" & Chr(34))
        ucrTickMarkers.SetItems(dctTickMarkers)

        ucrPnlTickmarkers.AddParameterPresentCondition(rdoTickMarkersAuto, "breaks", False)
        ucrPnlTickmarkers.AddParameterPresentCondition(rdoTickMarkersCustom, "breaks", True)


        'these add parameters to clsSeqFunction
        ucrNudInStepsOf.SetParameter(New RParameter("by"))
        ucrNudTo.SetParameter(New RParameter("to"))
        ucrNudFrom.SetParameter(New RParameter("from"))

        'Scales section
        ucrPnlScales.AddRadioButton(rdoScalesAuto)
        ucrPnlScales.AddParameterPresentCondition(rdoScalesAuto, "limits", False)
        ucrPnlScales.AddRadioButton(rdoScalesCustom)
        ucrPnlScales.AddParameterPresentCondition(rdoScalesCustom, "limits", True)

        'ucrPnlScales.AddToLinkedControls(ucrInputNoofDecimalsLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrInputNoofDecimalsLimit.SetLinkedDisplayControl(lblScalesNoDecimalPlaces)

        ucrPnlScales.AddToLinkedControls(ucrInputLowerLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputLowerLimit.SetLinkedDisplayControl(lblLowerLimit)

        ucrPnlScales.AddToLinkedControls(ucrInputUpperLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputUpperLimit.SetLinkedDisplayControl(lblUpperLimit)

        bInitialiseControls = True
    End Sub

    Public Sub SetRCodeForControl(bIsXAxis As Boolean, Optional clsNewXScalecontinuousFunction As RFunction = Nothing, Optional clsNewXYlabTitleFunction As RFunction = Nothing, Optional clsNewBaseOperator As ROperator = Nothing, Optional bReset As Boolean = False)

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
            '    strAxis = "y"
            '    clsYlabTitleFunction.SetRCommand("ylab")
            '    clsScalecontinuousFunction.SetRCommand("scale_" & strAxis & "_continuous")
            '    ' put scale_y_continuous function here
        End If

        If clsNewXYlabTitleFunction IsNot Nothing Then
            clsXYlabTitleFunction = clsNewXYlabTitleFunction
        Else
            clsXYlabTitleFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        End If

        If clsNewXScalecontinuousFunction IsNot Nothing Then
            clsXScalecontinuousFunction = clsNewXScalecontinuousFunction
        Else
            clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone
        End If

        ucrPnlAxisTitle.SetRCode(clsXYlabTitleFunction, bReset)
        ucrInputTitle.SetRCode(clsXYlabTitleFunction, bReset)

        'scales functions
        ucrPnlScales.SetRCode(clsXScalecontinuousFunction, bReset)
        ucrInputLowerLimit.SetRCode(clsXScalecontinuousFunction, bReset)
        ucrInputUpperLimit.SetRCode(clsXScalecontinuousFunction, bReset)
        ucrPnlTickmarkers.SetRCode(clsXScalecontinuousFunction, bReset)

        ucrNudInStepsOf.SetRCode(clsSeqFunction, bReset)
        ucrNudTo.SetRCode(clsSeqFunction, bReset)
        ucrNudFrom.SetRCode(clsSeqFunction, bReset)

        AddRemoveLabs()
        AddRemoveXScales()
    End Sub

    Private Sub ucrNudTickMarkersNoOfDecimalPlaces_ControlContentsChanged() Handles ucrNudTickMarkersNoOfDecimalPlaces.ControlContentsChanged
        ucrNudFrom.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
        ucrNudTo.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
        ucrNudInStepsOf.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
    End Sub

    Private Sub ucrTickMarkers_ControlValueChanged() Handles ucrTickMarkers.ControlValueChanged, ucrPnlTickmarkers.ControlValueChanged
        If rdoTickMarkersCustom.Checked AndAlso ucrTickMarkers.cboInput.SelectedItem = "Interval" Then
            clsSeqFunction.SetRCommand("seq")
            clsXScalecontinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsSeqFunction)

        ElseIf ucrTickMarkers.cboInput.SelectedItem = "Specific Values" Then
            clsXScalecontinuousFunction.RemoveParameterByName("breaks")
        End If
        tickMarkersDisplay()
    End Sub

    Private Sub AddRemoveLabs()
        If rdoNoTitle.Checked OrElse (rdoSpecifyTitle.Checked AndAlso Not ucrInputTitle.IsEmpty) Then
            clsBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsXYlabTitleFunction)
        Else
            clsBaseOperator.RemoveParameterByName("xlab")
        End If
    End Sub

    Private Sub ucrPnlAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlAxisTitle.ControlValueChanged, ucrInputTitle.ControlValueChanged
        If ucrChangedControl.Equals(ucrPnlAxisTitle) Then
            If rdoTitleAuto.Checked Then
                clsXlabTitleFunction.RemoveParameterByName("label")
            ElseIf rdoNoTitle.Checked Then
                clsXlabTitleFunction.AddParameter("label", Chr(34) & Chr(34))
            Else
                clsXlabTitleFunction.AddParameter(ucrInputTitle.GetParameter())
            End If
        End If
        AddRemoveLabs()
    End Sub

    Private Sub AddRemoveXScales()
        If rdoScalesCustom.Checked AndAlso (Not ucrInputLowerLimit.IsEmpty AndAlso Not ucrInputUpperLimit.IsEmpty) Then
            clsBaseOperator.AddParameter("xscales", clsRFunctionParameter:=clsXScalecontinuousFunction)
        Else
            clsBaseOperator.RemoveParameterByName("xscales")
        End If
    End Sub

    Private Sub ucrPnlScales_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlScales.ControlValueChanged, ucrInputLowerLimit.ControlValueChanged, ucrInputUpperLimit.ControlValueChanged
        'If ucrChangedControl.Equals(ucrPnlScales) Then
        If rdoScalesCustom.Checked AndAlso (Not ucrInputLowerLimit.IsEmpty AndAlso Not ucrInputUpperLimit.IsEmpty) Then
            Dim strLowerLimit As String = ucrInputLowerLimit.GetText
            Dim strUpperLimit As String = ucrInputUpperLimit.GetText
            clsXScalecontinuousFunction.AddParameter("limits", "c(" & strLowerLimit & "," & strUpperLimit & ")")
        End If

        ' End If
        AddRemoveXScales()
    End Sub

    Private Sub tickMarkersDisplay()
        If ucrTickMarkers.GetText = "Specific Values" Then
            ucrSpecificValues.Visible = True
            ucrNudFrom.Visible = False
            lblFrom.Visible = False
            ucrNudTo.Visible = False
            lblTo.Visible = False
            ucrNudTickMarkersNoOfDecimalPlaces.Visible = False
            lblTickMarkersNoOfDecimalPlaces.Visible = False
            ucrNudInStepsOf.Visible = False
            lblInStepsOf.Visible = False
        Else
            ucrSpecificValues.Visible = False
            ucrNudFrom.Visible = True
            lblFrom.Visible = True
            ucrNudTo.Visible = True
            lblTo.Visible = True
            ucrNudTickMarkersNoOfDecimalPlaces.Visible = True
            lblTickMarkersNoOfDecimalPlaces.Visible = True
            ucrNudInStepsOf.Visible = True
            lblInStepsOf.Visible = True
        End If

    End Sub

End Class

