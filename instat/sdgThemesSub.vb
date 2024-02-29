
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

Public Class sdgThemesSub
    Public bControlsInitialised As Boolean = False
    Private clsThemesFunction, clsElementPlotTitle, clsAxesTitles, clsElementPanelGridMinor, clsElementPanelGridMajor, clsXElementTitle, clsYElementTitle, clsAllLabels, clsXAxisLables, clsYAxisLabels, clsAllTickMarks, clsXAxisTickMarks, clsYAxisTickMarks, clsUnitAxisTickLength, clsAllAxisLines, clsXAxisLine, clsYAxisLine, clsElementLineXAxis, clsElementLineYAxis As New RFunction
    Private clsAllPanelGrid, clsPanelGridMajor, clsPanelGridMinor, clsDummyFunction, clsPanelBackground, clsPanelBorder As New RFunction
    Private clsBaseOperator As New ROperator
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsThemesSubFunctions As New clsThemeSubFunctions

    Private Sub sdgThemesSub_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        'temp hidden as not yet implemented
        'tbLegend.Visible = False
        'tbLegend.Enabled = False
    End Sub

    Public Sub InitialiseControls()
        Dim dctLegendPosition As New Dictionary(Of String, String)

        ucrPlotTitle.SetLabel("Plot Title")
        ucrThemeTitleXAxis.SetLabel("X-Axis Title")
        ucrThemeTitleYAxis.SetLabel("Y-Axis Title")

        ucrThemeAxesTickLabels.SetLabel("X and Y-Axis Labels")
        ucrThemeBottomXAxis.SetLabel("X-Axis Labels")
        ucrThemeLeftYAxis.SetLabel("Y-Axis Labels")

        ucrTickMarksAxes.SetLabel("X and Y-Axis Tick Markers")
        ucrTickMarksXAxis.SetLabel("X-Axis Tick Markers")
        ucrTickMarksYAxis.SetLabel("Y-Axis Tick Markers")

        ucrThemeAxesLines.SetLabel("Axis Lines")
        ucrXAxisLines.SetLabel("X-Axis Line")
        ucrYAxisLines.SetLabel("Y-Axis Line")

        ucrPanelGridMajor.SetLabel("Major Grid Lines")
        ucrPanelGridMinor.SetLabel("Minor Grid Lines")
        ucrPanelBorder.SetLabel("Panel Border")
        ucrPanelBackground.SetLabel("Panel Background")

        ucrChkRemoveLegend.SetText("Remove Legend")
        ucrChkRemoveLegend.AddParameterPresentCondition(True, "legend", True)
        ucrChkRemoveLegend.AddParameterPresentCondition(False, "legend", False)

        ucrPnlOptions.AddRadioButton(rdoCoordinated)
        ucrPnlOptions.AddRadioButton(rdoSpecific)
        ucrPnlOptions.AddParameterValuesCondition(rdoCoordinated, "legend", "coordinated")
        ucrPnlOptions.AddParameterValuesCondition(rdoSpecific, "legend", "specific")
        ucrPnlOptions.AddToLinkedControls({ucrNudX, ucrNudY}, {rdoCoordinated}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0")
        ucrPnlOptions.AddToLinkedControls(ucrInputLegendPosition, {rdoSpecific}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputLegendPosition.SetDropDownStyleAsNonEditable()
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)

        ucrNudX.SetParameter(New RParameter("legend.position", 3))
        ucrNudX.SetMinMax(0, 1)
        ucrNudX.DecimalPlaces = 1
        ucrNudX.Increment = 0.1
        ucrNudX.SetLinkedDisplayControl(lblXCoord)

        ucrNudY.SetParameter(New RParameter("legend.position", 4))
        ucrNudY.SetMinMax(0, 1)
        ucrNudY.DecimalPlaces = 1
        ucrNudY.Increment = 0.1
        ucrNudY.SetLinkedDisplayControl(lblYCoord)

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemesFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        ucrInputLegendPosition.SetName("None")

        clsDummyFunction = New RFunction
        clsDummyFunction.AddParameter("legend", "specific", iPosition:=0)

        clsThemesFunction = clsNewThemesFunction
        ' The position MUST be larger than the position of the theme_* argument
        ' Otherwise the choice of theme will overwrite the options selected here.
        ' Currently set to large value as no reason this cannot be at the end currently
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemesFunction, iPosition:=100)
        dctThemeFunctions = dctNewThemeFunctions

        Dim clsElementLegendText As New RFunction
        Dim clsElementLegendTitle As New RFunction

        dctThemeFunctions.TryGetValue("plot.title", clsElementPlotTitle)
        ucrPlotTitle.SetRCodeForControl("plot.title", clsElementPlotTitle, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle)
        ucrThemeTitleXAxis.SetRCodeForControl("axis.title.x", clsXElementTitle, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle)
        ucrThemeTitleYAxis.SetRCodeForControl("axis.title.y", clsYElementTitle, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.text.x", clsXAxisLables)
        ucrThemeBottomXAxis.SetRCodeForControl("axis.text.x", clsXAxisLables, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.text.y", clsYAxisLabels)
        ucrThemeLeftYAxis.SetRCodeForControl("axis.text.y", clsYAxisLabels, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.ticks.x", clsXAxisTickMarks)
        ucrTickMarksXAxis.SetRCodeForControl("axis.ticks.x", clsXAxisTickMarks, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.ticks.y", clsYAxisTickMarks)
        ucrTickMarksYAxis.SetRCodeForControl("axis.ticks.y", clsYAxisTickMarks, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("panel.grid.major", clsElementPanelGridMajor)
        ucrPanelGridMajor.SetRCodeForControl("panel.grid.major", clsElementPanelGridMajor, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("panel.grid.minor", clsElementPanelGridMinor)
        ucrPanelGridMinor.SetRCodeForControl("panel.grid.minor", clsElementPanelGridMinor, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("legend.text", clsElementLegendText)
        dctThemeFunctions.TryGetValue("legend.title", clsElementLegendTitle)

        dctThemeFunctions.TryGetValue("axis.line.x", clsElementLineXAxis)
        ucrXAxisLines.SetRCodeForControl("axis.line.x", clsElementLineXAxis, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        dctThemeFunctions.TryGetValue("axis.line.y", clsElementLineYAxis)
        ucrYAxisLines.SetRCodeForControl("axis.line.y", clsElementLineYAxis, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelBorder.SetRCodeForControl("panel.border", clsThemesSubFunctions.clsElementBorder, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelBackground.SetRCodeForControl("panel.background", clsThemesSubFunctions.clsElementPanelBackGround, clsNewThemeFunction:=clsThemesFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        If bReset Then
            ucrInputLegendPosition.SetRCode(clsThemesFunction, bReset, bCloneIfNeeded:=True)
            ucrChkRemoveLegend.SetRCode(clsThemesFunction, bReset, bCloneIfNeeded:=True)
            ucrPnlOptions.SetRCode(clsDummyFunction, bReset, bCloneIfNeeded:=True)
        End If
    End Sub

    Private Sub LegendOptions()
        Dim clsCFunction As New RFunction
        clsCFunction.SetRCommand("c")
        clsCFunction.AddParameter("x", ucrNudX.GetText(), iPosition:=0, bIncludeArgumentName:=False)
        clsCFunction.AddParameter("y", ucrNudY.GetText(), iPosition:=1, bIncludeArgumentName:=False)
        If ucrChkRemoveLegend.Checked Then
            clsThemesFunction.RemoveParameterByName("legend.position")
        Else
            If rdoSpecific.Checked Then
                clsThemesFunction.AddParameter("legend.position", Chr(34) & ucrInputLegendPosition.GetText().ToLower() & Chr(34), iPosition:=0)
            Else
                clsThemesFunction.AddParameter("legend.position", clsRFunctionParameter:=clsCFunction, iPosition:=0)
            End If
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrInputLegendPosition.ControlValueChanged, ucrNudX.ControlValueChanged, ucrNudY.ControlValueChanged, ucrChkRemoveLegend.ControlValueChanged
        LegendOptions()
    End Sub
End Class

