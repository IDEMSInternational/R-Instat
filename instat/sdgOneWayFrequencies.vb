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

Imports instat.Translations
Public Class sdgOneWayFrequencies
    Public bControlsInitialised As Boolean = False
    Public clsOneWayTableFreq, clsOneWayGraphFreq, clsOneWayPlotGrid As New RFunction

    Private Sub sdgOneWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctVerticalPositionLabel As New Dictionary(Of String, String)
        Dim dctHorizontalPositionLabel As New Dictionary(Of String, String)
        Dim dctOmitZero As New Dictionary(Of String, String)

        ucrInputGraphTitle.SetParameter(New RParameter("title", 2))

        'Table Only
        ucrChkHighlightedRows.SetParameter(New RParameter("altr.row.col", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkHighlightedRows.SetRDefault("FALSE")
        ucrChkHighlightedRows.SetText("Alternate Rows Coloured")

        'Table Only
        ucrInputCountsName.SetParameter(New RParameter("string.cnt", 5))
        ucrInputCountsName.SetRDefault(Chr(34) & "N" & Chr(34))
        ucrChkCountName.SetParameter(ucrInputCountsName.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkCountName.SetText("Count Name")
        ucrChkCountName.AddToLinkedControls(ucrInputCountsName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'Table Only
        ucrChkMedian.SetParameter(New RParameter("emph.md", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMedian.SetRDefault("FALSE")
        ucrChkMedian.SetText("Emphasise Median")

        'Table Only
        ucrChkShowSummary.SetParameter(New RParameter("show.summary", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowSummary.SetText("Show Summary")

        'Table Only
        ucrInputOmitZero.SetParameter(New RParameter("skip.zero", 8))
        dctOmitZero.Add("Auto", Chr(34) & "auto" & Chr(34))
        dctOmitZero.Add("True", Chr(34) & "TRUE" & Chr(34))
        dctOmitZero.Add("False", Chr(34) & "FALSE" & Chr(34))
        ucrInputOmitZero.SetItems(dctOmitZero)
        ucrInputOmitZero.SetRDefault(Chr(34) & "auto" & Chr(34))
        ucrInputOmitZero.bUpdateRCodeFromControl = False

        'Table Only
        ucrNudDecimalPlaces.SetParameter(New RParameter("digits", 10))
        ucrNudDecimalPlaces.SetMinMax(0, 4)

        'Graph Only
        ucrPnlGraphType.SetParameter(New RParameter("type", 4))
        ucrPnlGraphType.AddRadioButton(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoDot, Chr(34) & "dot" & Chr(34))
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
        InitialiseTabs()
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewSjtFreq As RFunction, clsNewSjpFrq As RFunction, clsNewPlotGrid As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsOneWayTableFreq = clsNewSjtFreq
        clsOneWayGraphFreq = clsNewSjpFrq
        clsOneWayPlotGrid = clsNewPlotGrid

        ucrChkMedian.SetRCode(clsOneWayTableFreq, bReset)
        ucrChkShowSummary.SetRCode(clsOneWayTableFreq, bReset)
        ucrChkHighlightedRows.SetRCode(clsOneWayTableFreq, bReset)
        ucrNudDecimalPlaces.SetRCode(clsOneWayTableFreq, bReset)
        ucrInputOmitZero.SetRCode(clsOneWayTableFreq, bReset)
        ucrInputCountsName.SetRCode(clsOneWayTableFreq, bReset)
        ucrChkCountName.SetRCode(clsOneWayTableFreq, bReset)

        ucrChkShowCount.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkShowPercentage.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkShowMissing.SetRCode(clsOneWayGraphFreq, bReset)
        ucrPnlGraphType.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputVerticalLabels.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputHorizontalLabels.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputGraphTitle.SetRCode(clsOneWayGraphFreq, bReset)

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