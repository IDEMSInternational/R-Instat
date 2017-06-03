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
    '  Public clsRsyntax As New RSyntax
    Public clsXlabTitleFunction As New RFunction
    Public clsYlabTitleFunction As New RFunction

    Public clsScalecontinuousFunction As New RFunction
    Public clsSeqFunction As New RFunction
    Public strAxis As String
    Public bFirstLoad As Boolean = True
    Dim bInitialiseControls As Boolean = False

    Private Sub ucrAxes_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub SetDefaults()
        TitleDefaults()
        ucrTickMarkers.SetName("Interval")
        TitleFunction()
        ucrTitle.SetName("")

        ucrNudTickMarkersNoOfDecimalPlaces.Value = 0
        ucrNudFrom.Value = 0
        ucrNudTo.Value = 0
        ucrNudInStepsOf.Value = 0
    End Sub

    Public Sub Reset()
        SetDefaults()
    End Sub

    Private Sub InitialiseControl()
        Dim dctTickMarkers As New Dictionary(Of String, String)

        'Axis Section
        ucrPnlAxisTitle.AddRadioButton(rdoTitleAuto)
        ucrPnlAxisTitle.AddRadioButton(rdoNoTitle)
        ucrPnlAxisTitle.AddRadioButton(rdoSpecifyTitle)
        ucrPnlAxisTitle.AddParameterPresentCondition(rdoTitleAuto, "label", False)

        ucrPnlAxisTitle.AddParameterValuesCondition(rdoNoTitle, "label", "", True)
        ucrPnlAxisTitle.AddParameterValuesCondition(rdoSpecifyTitle, "label", ucrTitle.GetText <> "", True)
        ucrPnlAxisTitle.AddToLinkedControls(ucrTitle, {rdoSpecifyTitle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrTitle.SetLinkedDisplayControl(lblTitle)
        'Tick Markers section

        ucrPnlTickmarkers.AddRadioButton(rdoTickMarkersAuto)
        ucrPnlTickmarkers.AddRadioButton(rdoTickMarkersCustom)
        ucrPnlTickmarkers.AddToLinkedControls(ucrTickMarkers, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlTickmarkers.AddToLinkedControls(ucrNudFrom, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)

        ucrPnlTickmarkers.AddToLinkedControls(ucrNudTo, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudTo.SetLinkedDisplayControl(lblTo)

        ucrPnlTickmarkers.AddToLinkedControls(ucrNudInStepsOf, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudInStepsOf.SetLinkedDisplayControl(lblInStepsOf)

        ucrPnlTickmarkers.AddToLinkedControls(ucrNudTickMarkersNoOfDecimalPlaces, {rdoTickMarkersCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudTickMarkersNoOfDecimalPlaces.SetLinkedDisplayControl(lblTickMarkersNoOfDecimalPlaces)

        'these add parameters to clsSeqFunction
        ucrNudInStepsOf.SetParameter(New RParameter("by"))
        ucrNudTo.SetParameter(New RParameter("to"))
        ucrNudFrom.SetParameter(New RParameter("from"))

        'Scales section
        ucrPnlScales.AddRadioButton(rdoScalesAuto)
        ucrPnlScales.AddRadioButton(rdoScalesCustom)
        ucrPnlScales.AddToLinkedControls(ucrInputNoofDecimalsLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputNoofDecimalsLimit.SetLinkedDisplayControl(lblScalesNoDecimalPlaces)

        ucrPnlScales.AddToLinkedControls(ucrInputLowerLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputLowerLimit.SetLinkedDisplayControl(lblLowerLimit)

        ucrPnlScales.AddToLinkedControls(ucrInputUpperLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputUpperLimit.SetLinkedDisplayControl(lblUpperLimit)

        ucrTickMarkers.SetParameter(New RParameter("breaks"))
        dctTickMarkers.Add("Interval", Chr(34) & "" & Chr(34))
        dctTickMarkers.Add("Specific Values", Chr(34) & "" & Chr(34))
        ucrTickMarkers.SetItems(dctTickMarkers)

        TitleDefaults()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'ucrNudInStepsOf.SetRCode(clsSeqFunction, bReset)
        'ucrNudTo.SetRCode(clsSeqFunction, bReset)
        'ucrNudFrom.SetRCode(clsSeqFunction, bReset)
        'ucrTitle.SetRCode(clsTitleFunction, bReset)
        'ucrPnlAxisTitle.SetRCode(clsTitleFunction, bReset)
    End Sub

    Private Sub TitleDefaults()
        'If rdoTitleAuto.Checked Then
        '    ucrChkDisplayTitle.Visible = False
        '    ucrChkOverwriteTitle.Visible = False
        '    ucrOverwriteTitle.Visible = False
        'ElseIf rdoTitleCustom.Checked Then
        '    ucrChkDisplayTitle.Visible = True
        '    ucrChkDisplayTitle.Checked = True
        '    ucrChkOverwriteTitle.Visible = True
        '    ucrChkOverwriteTitle.Checked = False
        'End If
    End Sub

    ' i think this sub can be used to set the functions to link with the subdialog

    Public Sub SetRCodeForXorY(bIsXAxis As Boolean, Optional clsSeqFunction As RFunction = Nothing, Optional clsNewXlabTitleFunction As RFunction = Nothing, Optional clsScalecontinuousFunction As RFunction = Nothing, Optional bReset As Boolean = False)

        'If Not bInitialiseControls Then
        '    InitialiseControl()
        'End If
        'If clsNewXlabTitleFunction IsNot Nothing Then
        '    clsXlabTitleFunction = clsNewXlabTitleFunction
        'Else
        '    clsXlabTitleFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        'End If

        'If bIsXAxis Then
        '    bIsX = True
        '    strAxis = "x"
        '    clsXlabTitleFunction.SetRCommand("xlab")
        '    clsScalecontinuousFunction.SetRCommand("scale_" & strAxis & "_continuous")

        '    ' put scale_x_continuous function here
        'ElseIf bIsXAxis = False Then
        '    bIsX = False
        '    strAxis = "y"
        '    clsYlabTitleFunction.SetRCommand("ylab")
        '    clsScalecontinuousFunction.SetRCommand("scale_" & strAxis & "_continuous")
        '    ' put scale_y_continuous function here
        'End If

        'ucrNudInStepsOf.SetRCode(clsSeqFunction, bReset)
        'ucrNudTo.SetRCode(clsSeqFunction, bReset)
        'ucrNudFrom.SetRCode(clsSeqFunction, bReset)
        'ucrTitle.SetRCode(clsXlabTitleFunction, bReset)
        'ucrPnlAxisTitle.SetRCode(clsXlabTitleFunction, bReset)
    End Sub

    Public Sub SetRsyntaxAxis(clsRsyntaxAxis As RSyntax)
        ' clsRsyntax = clsRsyntaxAxis
    End Sub

    Private Sub TitleFunction()
        'If rdoNoTitle.Checked AndAlso ucrChkDisplayTitle.Checked Then
        '    If ucrChkOverwriteTitle.Checked AndAlso Not ucrOverwriteTitle.IsEmpty Then
        '        clsTitleFunction.AddParameter("label", Chr(34) & ucrOverwriteTitle.GetText & Chr(34))
        '        'clsRsyntax.AddOperatorParameter(strAxis & "axistitle", clsRFunc:=clsTitleFunction)
        '    Else
        '        'clsRsyntax.RemoveOperatorParameter(strAxis & "axistitle")
        '    End If
        'Else
        '    clsTitleFunction.AddParameter("label", Chr(34) & "" & Chr(34))
        '    ' clsRsyntax.AddOperatorParameter(strAxis & "axistitle", clsRFunc:=clsTitleFunction)
        'End If
    End Sub

    Private Sub ScalesFunction()
        If rdoScalesCustom.Checked Then
            clsScalecontinuousFunction.AddParameter("limits", "c(" & ucrInputLowerLimit.GetText & "," & ucrInputUpperLimit.GetText & ")")
            ' clsRsyntax.AddOperatorParameter("scale_" & strAxis & "_continuous", clsRFunc:=clsScalecontinuousFunction)
        Else
            'clsRsyntax.RemoveOperatorParameter("scale_" & strAxis & "_continuous")
        End If
    End Sub

    Private Sub ucrOverwriteTitle_NameChanged() Handles ucrTitle.NameChanged
        If rdoNoTitle.Checked Then
            TitleFunction()
        End If
    End Sub

    Private Sub ucrChkOverwriteTitle_CheckedChanged(sender As Object, e As EventArgs)
        'If rdoNoTitle.Checked AndAlso ucrChkOverwriteTitle.Checked Then
        '    ucrOverwriteTitle.Visible = True
        'Else
        '    ucrOverwriteTitle.Visible = False
        'End If
        'TitleFunction()
    End Sub

    Private Sub ucrChkDisplayTitle_CheckedChanged(sender As Object, e As EventArgs)
        'If rdoNoTitle.Checked AndAlso ucrChkDisplayTitle.Checked Then
        '    ucrChkOverwriteTitle.Visible = True
        '    If ucrChkOverwriteTitle.Checked Then
        '        ucrOverwriteTitle.Visible = True
        '    Else
        '        ucrOverwriteTitle.Visible = False
        '    End If
        'Else
        '    ucrChkOverwriteTitle.Visible = False
        '    ucrOverwriteTitle.Visible = False
        'End If
        'TitleFunction()
    End Sub

    Private Sub rdoTitleCustom_CheckedChanged(sender As Object, e As EventArgs) Handles rdoNoTitle.CheckedChanged, rdoSpecifyTitle.CheckedChanged
        TitleDefaults()
    End Sub

    Private Sub rdoTitleAuto_CheckedChanged(sender As Object, e As EventArgs) Handles rdoTitleAuto.CheckedChanged
        TitleDefaults()
    End Sub

    Private Sub ucrNudLowerLimit_TextChanged(sender As Object, e As EventArgs)
        ScalesFunction()
    End Sub

    Private Sub ucrNudTickMarkersNoOfDecimalPlaces_ControlContentsChanged() Handles ucrNudTickMarkersNoOfDecimalPlaces.ControlContentsChanged
        ucrNudFrom.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
        ucrNudTo.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
        ucrNudInStepsOf.DecimalPlaces = ucrNudTickMarkersNoOfDecimalPlaces.Value
    End Sub

    Private Sub ucrTickMarkers_ControlValueChanged() Handles ucrTickMarkers.ControlValueChanged
        If rdoTickMarkersCustom.Checked Then
            If ucrTickMarkers.cboInput.SelectedItem = "Interval" Then
                clsSeqFunction.SetRCommand("seq")
                clsScalecontinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsSeqFunction)

            ElseIf ucrTickMarkers.cboInput.SelectedItem = "Specific Values" Then
                clsScalecontinuousFunction.RemoveParameterByName("breaks")
            End If
        End If
    End Sub

    Private Sub ucrTitle_Load(sender As Object, e As EventArgs) Handles ucrTitle.Load

    End Sub
End Class

