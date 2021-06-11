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

Public Class sdgThemes
    Public bControlsInitialised As Boolean = False
    Private clsElementLine, clsElementRect, clsElementXAxisTextTop, clsElementXAxisLine, clsElementYAxisLine, clsElementText, clsElementYAxisTextRight, clsElementXAxisLineTop, clsThemeFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsThemeSubFunctions As New clsThemeSubFunctions

    Private Sub sdgThemes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctLegendPosition As New Dictionary(Of String, String)
        Dim dctLegendDirection As New Dictionary(Of String, String)
        Dim dctLegendBox As New Dictionary(Of String, String)
        Dim dctLegendBoxJust As New Dictionary(Of String, String)
        Dim dctLegendJustification As New Dictionary(Of String, String)

        ucrThemeBottomXAxis.SetLabel("X axis tick labels")
        ucrThemeTopXAxis.SetLabel("X axis tick labels on top axis")
        ucrThemeLeftYAxis.SetLabel("Y axis tick labels")
        ucrThemeYRightAxis.SetLabel("Y axis tick labels on right axis")
        ucrThemeTitleXAxis.SetLabel("X axis label ")
        ucrThemeTitleXTopAxis.SetLabel("X axis label on top axis")
        ucrThemeTitleYAxis.SetLabel("Y axis labels")
        ucrThemeTitleYRightAxis.SetLabel("Y axis labels on right axis")
        ucrTickMarksYAxis.SetLabel("Y axis tick marks")
        ucrYAxisLines.SetLabel("Line along y axis")
        ucrTickMarksXAxis.SetLabel("X axis tick marks")
        ucrXAxisLines.SetLabel("Line along x axis")
        ucrTickMarksAxes.SetLabel("Tick marks along axes")
        ucrThemeAxesTitle.SetLabel("Label of axes")
        ucrThemeAxesTickLabels.SetLabel("Tick marks label along axes")
        ucrThemeAxesLines.SetLabel("Lines along axes")

        ucrLegendTitle.SetLabel("Title of legend")
        ucrLegendText.SetLabel("Legend item labels")
        ucrLegendBackground.SetLabel("Background of legend")
        ucrLegendKey.SetLabel("Background underneath legend keys")
        ucrLegendBoxBackground.SetLabel("Background of legend area")

        ucrLegendSpacing.setLabel("Spacing between legends")
        ucrLegendSpacingXAxis.setLabel("Horizontal spacing between legends")
        ucrLegendSpacingYAxis.setLabel("Horizontal spacing between legends")
        ucrLegendBoxSpacing.setLabel("Space between plot area legend box")

        ucrPanelGridMajorXAxis.SetLabel("Vertical major grid lines ")
        ucrPanelGridMajorYAxis.SetLabel("Horizontal major grid lines ")
        ucrPanelGridMinorXAxis.SetLabel("Vertical minor grid lines")
        ucrPanelGridMinorYAxis.SetLabel("Horizontal minor grid lines")

        ucrPanelGrid.SetLabel("Grid lines")
        ucrPanelGridMajor.SetLabel("Major grid lines ")
        ucrPanelGridMinor.SetLabel("Major grid lines ")
        ucrPanelBorder.SetLabel("Panel border")
        ucrPanelBackGround.SetLabel("Panel background")

        ucrPlotBackground.SetLabel("Background of the entire plot")
        ucrPlotCaption.SetLabel("Caption below the plot (text appearance)")
        ucrPlotSubTitle.SetLabel("Plot subtitle (text appearance)")
        ucrPlotTitle.SetLabel("Plot title (text appearance)")

        ucrStripBackGround.SetLabel("Background of facet labels")
        ucrStripText.SetLabel("Facet labels")
        ucrStripTextXAxis.SetLabel("Facet labels along horizontal direction")
        ucrStripTextYAxis.SetLabel("Facet labels along vertical direction")

        ucrTickLength.setLabel("Length of tick marks")
        ucrPlotMargin.setLabel("Margin around entire plot")

        ucrLegendKeySize.setLabel("Size of legend keys")
        ucrLegendKeyHeight.setLabel("Key background height")
        ucrLegendKeyWidth.setLabel("Key background width")

        ucrPanelSpacing.setLabel("Spacing between facet panels ")
        ucrPanelSpacingXAxis.setLabel("Horizontal spacing between facet panels")
        ucrPanelSpacingYAxis.setLabel("Vertical spacing between facet panels")

        ucrStripsSpaceGrid.setLabel("When strips are switched (Grid)")
        ucrStripsSpaceWrap.setLabel("when strips are switched (wrap)")

        ' TODO: Find what this means: "two-element numeric vector"
        urChkLegendPosition.SetText("Legend Position")
        ucrInputLegendPosition.SetParameter(New RParameter("legend.position"))
        dctLegendPosition.Add("None", Chr(34) & "none" & Chr(34))
        dctLegendPosition.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendPosition.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendPosition.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendPosition.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        ucrInputLegendPosition.SetItems(dctLegendPosition)
        urChkLegendPosition.AddParameterPresentCondition(True, "legend.position")
        urChkLegendPosition.AddParameterPresentCondition(False, "legend.position", False)

        ucrChkLegendBox.SetText("Legend Layout")
        ucrInputLegendBox.SetParameter(New RParameter("legend.box"))
        dctLegendBox.Add("Vertical", Chr(34) & "vertical" & Chr(34))
        dctLegendBox.Add("Horizontal", Chr(34) & "horizontal" & Chr(34))
        ucrInputLegendBox.SetItems(dctLegendBox)
        ucrChkLegendBox.AddParameterPresentCondition(True, "legend.box")
        ucrChkLegendBox.AddParameterPresentCondition(False, "legend.box", False)

        urChkLegendBoxJust.SetText("Justify Legend Box")
        ucrInputLegendBoxJust.SetParameter(New RParameter("legend.box.just"))
        dctLegendBoxJust.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendBoxJust.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctLegendBoxJust.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendBoxJust.Add("Left", Chr(34) & "left" & Chr(34))
        ucrInputLegendBoxJust.SetItems(dctLegendBoxJust)
        urChkLegendBoxJust.AddParameterPresentCondition(True, "legend.box.just")
        urChkLegendBoxJust.AddParameterPresentCondition(False, "legend.box.just", False)

        ucrChkLegendDirection.SetText("Legend Direction")
        ucrInputLegendDirection.SetParameter(New RParameter("legend.direction"))
        dctLegendDirection.Add("Vertical", Chr(34) & "vertical" & Chr(34))
        dctLegendDirection.Add("Horizontal", Chr(34) & "horizontal" & Chr(34))
        ucrInputLegendDirection.SetItems(dctLegendDirection)
        ucrChkLegendDirection.AddParameterPresentCondition(True, "legend.direction")
        ucrChkLegendDirection.AddParameterPresentCondition(False, "legend.direction", False)


        ucrChkLegendJustification.SetText("Legend Justification")
        ucrInputLegendJustification.SetParameter(New RParameter("legend.justification"))
        dctLegendJustification.Add("Top", Chr(34) & "top" & Chr(34))
        dctLegendJustification.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctLegendJustification.Add("Right", Chr(34) & "right" & Chr(34))
        dctLegendJustification.Add("Left", Chr(34) & "left" & Chr(34))
        dctLegendJustification.Add("Center", Chr(34) & "centre" & Chr(34))
        ucrInputLegendJustification.SetItems(dctLegendJustification)
        ucrChkLegendJustification.AddParameterPresentCondition(True, "legend.justification")
        ucrChkLegendJustification.AddParameterPresentCondition(False, "legend.justification", False)


        urChkLegendPosition.AddToLinkedControls(ucrInputLegendPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="None")
        ucrChkLegendBox.AddToLinkedControls(ucrInputLegendBox, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        urChkLegendBoxJust.AddToLinkedControls(ucrInputLegendBoxJust, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")
        ucrChkLegendDirection.AddToLinkedControls(ucrInputLegendDirection, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Vertical")
        ucrChkLegendJustification.AddToLinkedControls(ucrInputLegendJustification, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Top")

    End Sub

    Public Sub SetRCode(clsBaseOperator As ROperator, clsNewThemeFunction As RFunction, dctNewThemeFunctions As Dictionary(Of String, RFunction), Optional bReset As Boolean = False)

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsThemeFunction = clsNewThemeFunction
        ' The position MUST be larger than the position of the theme_* argument
        ' Otherwise the choice of theme will overwrite the options selected here.
        ' Currently set to large value as no reason this cannot be at the end currently
        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)

        clsThemeSubFunctions.SetRCode(clsBaseOperator, dctNewThemeFunctions, bReset)

        ucrTickMarksXAxis.SetRCodeForControl("axis.ticks.x", clsThemeSubFunctions.clsXElementLine, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrTickMarksYAxis.SetRCodeForControl("axis.ticks.y", clsThemeSubFunctions.clsYElementLine, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrXAxisLines.SetRCodeForControl("axis.line.x", clsThemeSubFunctions.clsElementLineXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrYAxisLines.SetRCodeForControl("axis.line.y", clsThemeSubFunctions.clsElementLineYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrTickMarksAxes.SetRCodeForControl("axis.ticks", clsThemeSubFunctions.clsElementTickAxes, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesTickLabels.SetRCodeForControl("axis.text", clsThemeSubFunctions.clsElementTickText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesTitle.SetRCodeForControl("axis.title", clsThemeSubFunctions.clsXElementTitleText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeAxesLines.SetRCodeForControl("axis.line", clsThemeSubFunctions.clsElementLineAxes, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrThemeBottomXAxis.SetRCodeForControl("axis.text.x", clsThemeSubFunctions.clsXElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTopXAxis.SetRCodeForControl("axis.text.x.top", clsThemeSubFunctions.clsXTopElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeLeftYAxis.SetRCodeForControl("axis.text.y", clsThemeSubFunctions.clsYElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeYRightAxis.SetRCodeForControl("axis.text.y.right", clsThemeSubFunctions.clsYRightElementText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrThemeTitleXAxis.SetRCodeForControl("axis.title.x", clsThemeSubFunctions.clsXElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleXTopAxis.SetRCodeForControl("axis.title.x.top", clsThemeSubFunctions.clsXTopElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleYAxis.SetRCodeForControl("axis.title.y", clsThemeSubFunctions.clsYElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrThemeTitleYRightAxis.SetRCodeForControl("axis.title.y.right", clsThemeSubFunctions.clsYRightElementTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrLegendTitle.SetRCodeForControl("legend.title", clsThemeSubFunctions.clsElementLegendTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendText.SetRCodeForControl("legend.text", clsThemeSubFunctions.clsElementLegendText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendBackground.SetRCodeForControl("legend.background", clsThemeSubFunctions.clsElementLegendBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendBoxBackground.SetRCodeForControl("legend.box.background", clsThemeSubFunctions.clsElementLegendBoxBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendKey.SetRCodeForControl("legend.key", clsThemeSubFunctions.clsElementLegendtKey, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrLegendSpacing.SetRCodeForControl("legend.spacing", clsThemeSubFunctions.clsUnitLegendSpacing, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendSpacingXAxis.SetRCodeForControl("legend.spacing.x", clsThemeSubFunctions.clsUnitLegendSpacingXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendSpacingYAxis.SetRCodeForControl("legend.spacing.y", clsThemeSubFunctions.clsUnitLegendSpacingYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendBoxSpacing.SetRCodeForControl("legend.box.spacing", clsThemeSubFunctions.clsUnitLegendBoxSpacing, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelGridMajorXAxis.SetRCodeForControl("panel.grid.major.x", clsThemeSubFunctions.clsElementPanelGridMajorXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMajorYAxis.SetRCodeForControl("panel.grid.major.y", clsThemeSubFunctions.clsElementPanelGridMajorYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMinorXAxis.SetRCodeForControl("panel.grid.minor.x", clsThemeSubFunctions.clsElementPanelGridMinorXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMinorYAxis.SetRCodeForControl("panel.grid.minor.y", clsThemeSubFunctions.clsElementPanelGridMinorYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelGrid.SetRCodeForControl("panel.grid", clsThemeSubFunctions.clsElementPanelGrid, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMajor.SetRCodeForControl("panel.grid.major", clsThemeSubFunctions.clsElementPanelGridMajor, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelGridMinor.SetRCodeForControl("panel.grid.minor", clsThemeSubFunctions.clsElementPanelGridMinor, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelBackGround.SetRCodeForControl("panel.background", clsThemeSubFunctions.clsElementPanelBackGround, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelBorder.SetRCodeForControl("panel.border", clsThemeSubFunctions.clsElementBorder, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPlotBackground.SetRCodeForControl("plot.background", clsThemeSubFunctions.clsElementPlotBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotCaption.SetRCodeForControl("plot.caption", clsThemeSubFunctions.clsElementPlotCaption, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotSubTitle.SetRCodeForControl("plot.subtitle", clsThemeSubFunctions.clsElementPlotSubtitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPlotTitle.SetRCodeForControl("plot.title", clsThemeSubFunctions.clsElementPlotTitle, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrStripBackGround.SetRCodeForControl("strip.background", clsThemeSubFunctions.clsElementStripBackground, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrStripText.SetRCodeForControl("strip.text", clsThemeSubFunctions.clsElementStripText, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrStripTextXAxis.SetRCodeForControl("strip.text.x", clsThemeSubFunctions.clsElementStripTextXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrStripTextYAxis.SetRCodeForControl("strip.text.y", clsThemeSubFunctions.clsElementStripTextYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrTickLength.SetRCodeForControl("axis.ticks.length", clsThemeSubFunctions.clsUnitAxisTickLength, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrLegendKeySize.SetRCodeForControl("legend.key.size", clsThemeSubFunctions.clsUnitLegendSize, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendKeyHeight.SetRCodeForControl("legend.key.height", clsThemeSubFunctions.clsUnitLegendHeight, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrLegendKeyWidth.SetRCodeForControl("legend.key.width", clsThemeSubFunctions.clsUnitLegendWidth, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPanelSpacing.SetRCodeForControl("panel.spacing", clsThemeSubFunctions.clsUnitPanelSpacing, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelSpacingXAxis.SetRCodeForControl("panel.spacing.x", clsThemeSubFunctions.clsUnitPanelSpacingXAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrPanelSpacingYAxis.SetRCodeForControl("panel.spacing.y", clsThemeSubFunctions.clsUnitPanelSpacingYAxis, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrStripsSpaceGrid.SetRCodeForControl("strip.switch.pad.grid", clsThemeSubFunctions.clsUnitStripsGrid, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)
        ucrStripsSpaceWrap.SetRCodeForControl("strip.switch.pad.wrap", clsThemeSubFunctions.clsUnitStripsWrap, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        ucrPlotMargin.SetRCodeForControl("plot.margin", clsThemeSubFunctions.clsUnitPlotMargin, clsNewThemeFunction:=clsThemeFunction, clsNewBaseOperator:=clsBaseOperator, bReset:=bReset)

        urChkLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendPosition.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        ucrChkLegendBox.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendBox.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        urChkLegendBoxJust.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendBoxJust.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        ucrChkLegendDirection.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendDirection.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)

        ucrChkLegendJustification.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLegendJustification.SetRCode(clsThemeFunction, bReset, bCloneIfNeeded:=True)
        AddRemoveElementParameters()
    End Sub

    Private Sub AddRemoveElementParameters()
        If ucrChkLegendBox.Checked Then
            clsThemeFunction.AddParameter("legend.box")
        Else
            clsThemeFunction.RemoveParameterByName("legend.box")
        End If

        If ucrChkLegendDirection.Checked Then
            clsThemeFunction.AddParameter("legend.direction")
        Else
            clsThemeFunction.RemoveParameterByName("legend.direction")
        End If

        If ucrChkLegendJustification.Checked Then
            clsThemeFunction.AddParameter("legend.justification")
        Else
            clsThemeFunction.RemoveParameterByName("legend.justification")
        End If

        If urChkLegendBoxJust.Checked Then
            clsThemeFunction.AddParameter("legend.box.just")
        Else
            clsThemeFunction.RemoveParameterByName("legend.box.just")
        End If

        If urChkLegendPosition.Checked Then
            clsThemeFunction.AddParameter("legend.position")
        Else
            clsThemeFunction.RemoveParameterByName("legend.position")
        End If

        AddRemoveTheme()
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

    Private Sub ElementLegendControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles urChkLegendPosition.ControlValueChanged, urChkLegendBoxJust.ControlValueChanged, ucrChkLegendJustification.ControlValueChanged, ucrChkLegendDirection.ControlValueChanged, ucrChkLegendBox.ControlValueChanged
        AddRemoveElementParameters()
    End Sub
End Class