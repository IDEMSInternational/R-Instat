' R-Instat
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

Public Class sdgCountryColouredMapOptions

    Private clsJoinFunction As New RFunction
    Private clsMapDataOperator As New ROperator
    Private clsFilterMapData As New RFunction
    Private clsFilterExpression As New ROperator
    Private clsLatMin As New ROperator
    Private clsLatMax As New ROperator
    Private clsLongMin As New ROperator
    Private clsLongMax As New ROperator
    Private lstRegionInputControls As New List(Of ucrInputTextBox)

    Private bControlsInitialised As Boolean = False
    Private bClearRegion As Boolean = True

    Private Sub sdgCountryColouredMapOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlRegionChoice.AddRadioButton(rdoOwnCountries)
        ucrPnlRegionChoice.AddRadioButton(rdoChooseRegion)
        ucrPnlRegionChoice.AddFunctionNamesCondition(rdoOwnCountries, "right_join")
        ucrPnlRegionChoice.AddFunctionNamesCondition(rdoChooseRegion, "left_join")
        ucrPnlRegionChoice.AddToLinkedControls(ucrInputLatMin, {rdoChooseRegion}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlRegionChoice.AddToLinkedControls(ucrInputLatMax, {rdoChooseRegion}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlRegionChoice.AddToLinkedControls(ucrInputLongMin, {rdoChooseRegion}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlRegionChoice.AddToLinkedControls(ucrInputLongMax, {rdoChooseRegion}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlRegionChoice.AddToLinkedControls(ucrInputCommonRegions, {rdoChooseRegion}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputCommonRegions.SetLinkedDisplayControl(lblCommonRegions)
        ucrInputLongMin.SetLinkedDisplayControl(lblLongMin)
        ucrInputLongMax.SetLinkedDisplayControl(lblLongMax)
        ucrInputLatMin.SetLinkedDisplayControl(lblLatMin)
        ucrInputLatMax.SetLinkedDisplayControl(lblLatMax)

        lstRegionInputControls = New List(Of ucrInputTextBox)
        lstRegionInputControls.AddRange({ucrInputLatMin, ucrInputLatMax, ucrInputLongMin, ucrInputLongMax})
        For Each ucrInputTemp As ucrInputTextBox In lstRegionInputControls
            ucrInputTemp.SetParameter(New RParameter("value", iNewPosition:=1))
            ucrInputTemp.AddQuotesIfUnrecognised = False
        Next
        ucrInputLatMin.SetValidationTypeAsNumeric(dcmMin:=-90, dcmMax:=90)
        ucrInputLatMax.SetValidationTypeAsNumeric(dcmMin:=-90, dcmMax:=90)
        ucrInputLongMin.SetValidationTypeAsNumeric(dcmMin:=-180, dcmMax:=191)
        ucrInputLongMax.SetValidationTypeAsNumeric(dcmMin:=-180, dcmMax:=191)

        ucrInputCommonRegions.SetItems({"Africa", "Asia", "Australia", "Europe", "North America", "South America", "World", "Choose..."})
        ucrInputCommonRegions.SetDropDownStyleAsNonEditable()
        InitialiseTabs()
        bControlsInitialised = True
    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbcOptions.TabCount - 1
            tbcOptions.SelectedIndex = i
        Next
        tbcOptions.SelectedIndex = 0
    End Sub

    Public Sub SetRCode(clsNewJoinFunction As RFunction, clsNewMapDataOperator As ROperator, clsNewFilterMapData As RFunction, clsNewFilterExpression As ROperator, clsNewLatMin As ROperator, clsNewLatMax As ROperator, clsNewLongMin As ROperator, clsNewLongMax As ROperator, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsJoinFunction = clsNewJoinFunction
        clsMapDataOperator = clsNewMapDataOperator
        clsFilterMapData = clsNewFilterMapData
        clsFilterExpression = clsNewFilterExpression
        clsLatMin = clsNewLatMin
        clsLatMax = clsNewLatMax
        clsLongMin = clsNewLongMin
        clsLongMax = clsNewLongMax

        bClearRegion = False
        ucrInputLatMin.SetRCode(clsLatMin, bReset:=bReset, bCloneIfNeeded:=True)
        ucrInputLatMax.SetRCode(clsLatMax, bReset:=bReset, bCloneIfNeeded:=True)
        ucrInputLongMin.SetRCode(clsLongMin, bReset:=bReset, bCloneIfNeeded:=True)
        ucrInputLongMax.SetRCode(clsLongMax, bReset:=bReset, bCloneIfNeeded:=True)
        ucrPnlRegionChoice.SetRCode(clsJoinFunction, bReset:=bReset, bCloneIfNeeded:=True)
        bClearRegion = True
        ucrInputCommonRegions.SetName("Choose...")
    End Sub

    Private Sub ucrInputCommonRegions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputCommonRegions.ControlValueChanged
        bClearRegion = False
        Select Case ucrInputCommonRegions.GetText()
            Case "Africa"
                ucrInputLatMin.SetName(-40)
                ucrInputLatMax.SetName(40)
                ucrInputLongMin.SetName(-30)
                ucrInputLongMax.SetName(55)
            Case "Asia"
                ucrInputLatMin.SetName(-10)
                ucrInputLatMax.SetName(80)
                ucrInputLongMin.SetName(25)
                ucrInputLongMax.SetName(180)
            Case "Europe"
                ucrInputLatMin.SetName(35)
                ucrInputLatMax.SetName(75)
                ucrInputLongMin.SetName(-25)
                ucrInputLongMax.SetName(70)
            Case "North America"
                ucrInputLatMin.SetName(0)
                ucrInputLatMax.SetName(80)
                ucrInputLongMin.SetName(-180)
                ucrInputLongMax.SetName(-45)
            Case "South America"
                ucrInputLatMin.SetName(-60)
                ucrInputLatMax.SetName(20)
                ucrInputLongMin.SetName(-100)
                ucrInputLongMax.SetName(-30)
            Case "Australia"
                ucrInputLatMin.SetName(-50)
                ucrInputLatMax.SetName(15)
                ucrInputLongMin.SetName(110)
                ucrInputLongMax.SetName(180)
            Case "World"
                ucrInputLatMin.SetName(-90)
                ucrInputLatMax.SetName(90)
                ucrInputLongMin.SetName(-180)
                ucrInputLongMax.SetName(191)
        End Select
        bClearRegion = True
    End Sub

    Private Sub ucrPnlRegionChoice_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlRegionChoice.ControlValueChanged
        If rdoOwnCountries.Checked Then
            clsJoinFunction.SetRCommand("right_join")
            clsMapDataOperator.RemoveParameterByName("filter")
        ElseIf rdoChooseRegion.Checked Then
            clsJoinFunction.SetRCommand("left_join")
            clsMapDataOperator.AddParameter("filter", clsRFunctionParameter:=clsFilterMapData, iPosition:=1)
        End If
    End Sub

    Private Sub ucrInputLatMax_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputLatMin.ControlContentsChanged, ucrInputLatMax.ControlContentsChanged, ucrInputLongMin.ControlContentsChanged, ucrInputLongMax.ControlContentsChanged
        If bClearRegion Then
            ucrInputCommonRegions.SetName("Choose...")
        End If
    End Sub

    Private Sub lblLongMin_VisibleChanged(sender As Object, e As EventArgs) Handles lblLongMin.VisibleChanged
        lblLong.Visible = lblLongMin.Visible
    End Sub

    Private Sub lblLatMin_VisibleChanged(sender As Object, e As EventArgs) Handles lblLatMin.VisibleChanged
        lblLat.Visible = lblLatMin.Visible
    End Sub
End Class