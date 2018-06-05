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

Imports instat.Translations
Public Class sdgPICSARainfallGraph
    Private bControlsInitialised As Boolean = False
    Private Sub sdgPICSARainfallGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrChkAddMean.SetText("Add Mean")
        ucrChkAddMedian.SetText("Add Median")
        ucrChkAddTerciles.SetText("Add Terciles")
        ucrChkYAxisTitle.SetText("Y Axis Title")
        ucrChkXaxisAngle.SetText("X Axis Angle")
        ucrChkXaxisLabelSize.SetText("X Axis Label Size")
        ucrChkYAxisLabelsSize.SetText("Y Axis Labels Size")

        ucrChkYAxisTitle.AddToLinkedControls(ucrInputYAxisTitle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkYAxisTitle.AddToLinkedControls(ucrNudYAxisTitleSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudYAxisTitleSize.SetLinkedDisplayControl(lblYAxisTitleSize)

        ucrChkYAxisLabelsSize.AddToLinkedControls(ucrNudYAxisLabelsSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ucrChkXaxisAngle.AddToLinkedControls(ucrNudXAxisAngle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkXaxisLabelSize.AddToLinkedControls(ucrNudXaxisLabelSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAddLabel.SetText("Add label")

        ucrChkFootNote.SetText("Foot Note")
        ucrChkFootNote.AddToLinkedControls(ucrInputFootNote, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSubFootNote.SetText("Sub Foot Note")
        ucrChkSubFootNote.AddToLinkedControls(ucrInputSubFootNote, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ucrSpecifyYAxisTickMarks.SetText("Specify Y Axis Tick Marks")
        ucrSpecifyYAxisTickMarks.AddToLinkedControls({ucrInputYFrom, ucrInputYTo, ucrInputYInStepsOf}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputYFrom.SetLinkedDisplayControl(lblYFrom)
        ucrInputYTo.SetLinkedDisplayControl(lblYTo)
        ucrInputYInStepsOf.SetLinkedDisplayControl(lblYInStepsOf)

        ucrSpecifyXAxisTickMarks.SetText("Specify x Axis Tick Marks")
        ucrSpecifyXAxisTickMarks.AddToLinkedControls({ucrInputXFrom, ucrInputXTo, ucrInputXInStepsOf}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputXFrom.SetLinkedDisplayControl(lblXFrom)
        ucrInputXTo.SetLinkedDisplayControl(lblXTo)
        ucrInputXInStepsOf.SetLinkedDisplayControl(lblXInStepsOf)

        bControlsInitialised = True
    End Sub

    Public Sub SetRcode()
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
    End Sub


End Class