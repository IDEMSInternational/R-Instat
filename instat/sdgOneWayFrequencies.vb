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
    Public clsOneWayTableFreq, clsOneWayGraphFreq As New RFunction

    Private Sub sdgOneWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctVerticalPositionLabel As New Dictionary(Of String, String)
        Dim dctHorizontalPositionLabel As New Dictionary(Of String, String)

        ucrInputHorizontalLabels.SetParameter(New RParameter("hjust", 38))
        dctHorizontalPositionLabel.Add("Left", Chr(34) & "left" & Chr(34))
        dctHorizontalPositionLabel.Add("Center", Chr(34) & "center" & Chr(34))
        dctHorizontalPositionLabel.Add("Right", Chr(34) & "right" & Chr(34))
        dctHorizontalPositionLabel.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctHorizontalPositionLabel.Add("Top", Chr(34) & "top" & Chr(34))
        dctHorizontalPositionLabel.Add("Inward", Chr(34) & "inward" & Chr(34))
        dctHorizontalPositionLabel.Add("Outward", Chr(34) & "outward" & Chr(34))
        ucrInputHorizontalLabels.SetItems(dctHorizontalPositionLabel)
        ucrInputHorizontalLabels.SetRDefault(Chr(34) & "center" & Chr(34))

        ucrInputVerticalLabels.SetParameter(New RParameter("vjust", 37))
        dctVerticalPositionLabel.Add("Left", Chr(34) & "left" & Chr(34))
        dctVerticalPositionLabel.Add("Center", Chr(34) & "center" & Chr(34))
        dctVerticalPositionLabel.Add("Right", Chr(34) & "right" & Chr(34))
        dctVerticalPositionLabel.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctVerticalPositionLabel.Add("Top", Chr(34) & "top" & Chr(34))
        dctVerticalPositionLabel.Add("Inward", Chr(34) & "inward" & Chr(34))
        dctVerticalPositionLabel.Add("Outward", Chr(34) & "outward" & Chr(34))
        ucrInputVerticalLabels.SetItems(dctVerticalPositionLabel)
        ucrInputVerticalLabels.SetRDefault(Chr(34) & "bottom" & Chr(34))

        'TODO Parameter position needed
        ucrChkMedian.SetParameter(New RParameter("emph.md"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMedian.SetRDefault("FALSE")
        ucrChkMedian.SetText("Emphasise Median")

        ucrChkShowSummary.SetText("Show Summary")
        'TODO Parameter position needed
        ucrChkShowSummary.SetParameter(New RParameter("show.summary"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        'Default is auto
        ucrChkOmitZero.SetText("Omit Zero Counts from Table")
        'TODO Parameter position needed
        'skip.zero has three options: "auto", TRUE, FALSE so this could be a combobox instead
        ucrChkOmitZero.SetParameter(New RParameter("skip.zero"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        'TODO Parameter position needed
        ucrNudDecimalPlaces.SetParameter(New RParameter("digits"))
        ucrNudDecimalPlaces.SetMinMax(0, 4)

        'TODO Parameter position needed
        ucrChkHighlightedRows.SetParameter(New RParameter("altr.row.col"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkHighlightedRows.SetRDefault("FALSE")
        ucrChkHighlightedRows.SetText("Alternate Rows Coloured")

        'TODO Parameter position needed
        ucrChkShowCount.SetParameter(New RParameter("show.n"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowCount.SetRDefault("FALSE")
        ucrChkShowCount.SetText("Show Count")

        'TODO Parameter position needed
        ucrChkShowPercentage.SetParameter(New RParameter("show.prc"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowPercentage.SetText("Show Percentage")

        'TODO Parameter position needed
        ucrInputGraphTitle.SetParameter(New RParameter("title"))

        ucrChkShowMissing.SetText("Show Missing")
        'TODO Parameter position needed
        ucrChkShowMissing.SetParameter(New RParameter("show.na"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowMissing.SetRDefault("FALSE")

        'TODO Parameter position needed
        ucrPnlGraphType.SetParameter(New RParameter("type"))
        ucrPnlGraphType.AddRadioButton(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoDot, Chr(34) & "dot" & Chr(34))
        ucrPnlGraphType.SetRDefault(Chr(34) & "bar" & Chr(34))

        'TODO Parameter position needed
        ucrInputCountsName.SetParameter(New RParameter("string.cnt"))
        ucrInputCountsName.SetRDefault(Chr(34) & "N" & Chr(34))

        'TODO Parameter position needed
        ucrChkCountName.SetParameter(ucrInputCountsName.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkCountName.SetText("Count Name")
        ucrChkCountName.AddToLinkedControls(ucrInputCountsName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveGraph.SetPrefix("one_way_freq")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(dlgOneWayFrequencies.ucrSelectorOneWayFreq.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewSjtFreq As RFunction, clsNewSjpFrq As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsOneWayTableFreq = clsNewSjtFreq
        clsOneWayGraphFreq = clsNewSjpFrq

        ucrChkMedian.SetRCode(clsOneWayTableFreq, bReset)
        ucrChkShowSummary.SetRCode(clsOneWayTableFreq, bReset)
        ucrChkHighlightedRows.SetRCode(clsOneWayTableFreq, bReset)
        ucrNudDecimalPlaces.SetRCode(clsOneWayTableFreq, bReset)
        ucrChkOmitZero.SetRCode(clsOneWayTableFreq, bReset)
        ucrInputCountsName.SetRCode(clsOneWayTableFreq, bReset)
        ucrChkCountName.SetRCode(clsOneWayTableFreq, bReset)

        ucrChkShowCount.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkShowPercentage.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkShowMissing.SetRCode(clsOneWayGraphFreq, bReset)
        ucrPnlGraphType.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputVerticalLabels.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputHorizontalLabels.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputGraphTitle.SetRCode(clsOneWayGraphFreq, bReset)
        ucrSaveGraph.SetRCode(clsOneWayGraphFreq, bReset)
    End Sub
End Class