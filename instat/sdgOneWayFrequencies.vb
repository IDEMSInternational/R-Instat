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
Public Class sdgOneWayFrequencies
    Public bControlsInitialised As Boolean = False
    Public clsOneWayTableFreq, clsOneWayGraphFreq, clsOneWayPlotGrid, clsOneWayListPlot As New RFunction

    Private Sub sdgOneWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctVerticalPositionLabel As New Dictionary(Of String, String)
        Dim dctHorizontalPositionLabel As New Dictionary(Of String, String)
        Dim dctOmitZero As New Dictionary(Of String, String)
        Dim dctColors As New Dictionary(Of String, String)

        ucrInputGraphTitle.SetParameter(New RParameter("title", 2))

        'Table Only
        ucrInputTitle.SetParameter(New RParameter("title", 5))

        'Table Only
        ucrChkShowStrings.SetParameter(New RParameter("show.strings", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowStrings.SetText("Omit Character Variables")

        ucrPnlShowMissingFreq.SetParameter(New RParameter("show.na", 8))
        ucrPnlShowMissingFreq.AddRadioButton(rdoShowMissingTrue, "TRUE")
        ucrPnlShowMissingFreq.AddRadioButton(rdoShowMissingFalse, "FALSE")
        ucrPnlShowMissingFreq.AddRadioButton(rdoShowMissingAuto, Chr(34) & "auto" & Chr(34))
        ucrPnlShowMissingFreq.SetRDefault("TRUE")

        'Graph Only
        ucrPnlGraphType.SetParameter(New RParameter("type", 4))
        ucrPnlGraphType.AddRadioButton(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoDot, Chr(34) & "dot" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoBoxplot, Chr(34) & "boxplot" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoHistogram, Chr(34) & "histogram" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoDensity, Chr(34) & "density" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoViolin, Chr(34) & "violin" & Chr(34))
        ucrPnlGraphType.SetRDefault(Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.bUpdateRCodeFromControl = False

        'Graph Only
        ucrChkShowCount.SetParameter(New RParameter("show.n", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowCount.SetRDefault("TRUE")
        ucrChkShowCount.SetText("Show Count")

        'Graph Only
        ucrChkShowPercentage.SetParameter(New RParameter("show.prc", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowPercentage.SetRDefault("TRUE")
        ucrChkShowPercentage.SetText("Show Percentage")

        'Graph Only
        ucrChkShowMissing.SetParameter(New RParameter("show.na", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowMissing.SetText("Show Missing")
        ucrChkShowMissing.SetRDefault("FALSE")

        'Graph Only
        ucrInputHorizontalLabels.SetParameter(New RParameter("hjust", 11))
        dctHorizontalPositionLabel.Add("Left", Chr(34) & "left" & Chr(34))
        dctHorizontalPositionLabel.Add("Center", Chr(34) & "center" & Chr(34))
        dctHorizontalPositionLabel.Add("Right", Chr(34) & "right" & Chr(34))
        dctHorizontalPositionLabel.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctHorizontalPositionLabel.Add("Top", Chr(34) & "top" & Chr(34))
        dctHorizontalPositionLabel.Add("Inward", Chr(34) & "inward" & Chr(34))
        dctHorizontalPositionLabel.Add("Outward", Chr(34) & "outward" & Chr(34))
        ucrInputHorizontalLabels.SetItems(dctHorizontalPositionLabel)
        ucrInputHorizontalLabels.SetRDefault(Chr(34) & "center" & Chr(34))
        ucrInputHorizontalLabels.bUpdateRCodeFromControl = False
        ucrInputHorizontalLabels.SetDropDownStyleAsNonEditable()

        'Graph Only
        ucrInputVerticalLabels.SetParameter(New RParameter("vjust", 12))
        dctVerticalPositionLabel.Add("Left", Chr(34) & "left" & Chr(34))
        dctVerticalPositionLabel.Add("Center", Chr(34) & "center" & Chr(34))
        dctVerticalPositionLabel.Add("Right", Chr(34) & "right" & Chr(34))
        dctVerticalPositionLabel.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctVerticalPositionLabel.Add("Top", Chr(34) & "top" & Chr(34))
        dctVerticalPositionLabel.Add("Inward", Chr(34) & "inward" & Chr(34))
        dctVerticalPositionLabel.Add("Outward", Chr(34) & "outward" & Chr(34))
        ucrInputVerticalLabels.SetItems(dctVerticalPositionLabel)
        ucrInputVerticalLabels.SetRDefault(Chr(34) & "bottom" & Chr(34))
        ucrInputVerticalLabels.bUpdateRCodeFromControl = False
        ucrInputVerticalLabels.SetDropDownStyleAsNonEditable()

        ucrInputColor.SetParameter(New RParameter("geom.colors", 13))
        dctColors.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctColors.Add("Black", Chr(34) & "black" & Chr(34))
        dctColors.Add("Red", Chr(34) & "red" & Chr(34))
        dctColors.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctColors.Add("Green", Chr(34) & "green" & Chr(34))
        dctColors.Add("Violet", Chr(34) & "violet" & Chr(34))
        dctColors.Add("White", Chr(34) & "white" & Chr(34))
        ucrInputColor.SetItems(dctColors)
        ucrInputColor.SetRDefault(Chr(34) & "blue" & Chr(34))
        ucrInputColor.bAllowNonConditionValues = True

        ucrNudSize.SetParameter(New RParameter("geom.size", 14))
        ucrNudSize.DecimalPlaces = 1
        ucrNudSize.Increment = 0.1
        ucrNudSize.SetMinMax(iNewMin:=0, iNewMax:=Integer.MaxValue)

        InitialiseTabs()
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewSjtFreq As RFunction, clsNewSjpFrq As RFunction, clsNewPlotGrid As RFunction, clsNewSjPlotList As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsOneWayTableFreq = clsNewSjtFreq
        clsOneWayGraphFreq = clsNewSjpFrq
        clsOneWayPlotGrid = clsNewPlotGrid
        clsOneWayListPlot = clsNewSjPlotList

        ucrChkShowStrings.SetRCode(clsOneWayTableFreq, bReset, bCloneIfNeeded:=True)
        ucrInputTitle.SetRCode(clsOneWayTableFreq, bReset, bCloneIfNeeded:=True)
        ucrChkShowCount.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)
        ucrChkShowPercentage.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)
        ucrChkShowMissing.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)
        ucrPnlGraphType.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)
        ucrInputVerticalLabels.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)
        ucrInputHorizontalLabels.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)
        ucrInputGraphTitle.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)
        ucrInputColor.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)
        ucrNudSize.SetRCode(clsOneWayGraphFreq, bReset, bCloneIfNeeded:=True)

        ucrPnlShowMissingFreq.AddAdditionalCodeParameterPair(clsOneWayTableFreq, clsNewRParameter:=New RParameter("show.na", 9), iAdditionalPairNo:=1)
        ucrPnlShowMissingFreq.SetRCode(clsOneWayTableFreq, bReset, bCloneIfNeeded:=True)
        If bReset Then
            tbpOneWayFrequencies.SelectedIndex = 0
        End If
    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpOneWayFrequencies.TabCount - 1
            tbpOneWayFrequencies.SelectedIndex = i
        Next
        tbpOneWayFrequencies.SelectedIndex = 0
    End Sub
End Class