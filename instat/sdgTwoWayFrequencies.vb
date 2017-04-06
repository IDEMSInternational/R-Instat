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

Imports instat
Imports instat.Translations
Public Class sdgTwoWayFrequencies
    Public bControlsInitialised As Boolean = False
    Public clsTwoWayTableFreq, clsTwoWayGraphFreq As New RFunction
    Private Sub sdgTwoWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()
        Dim dctVerticalPositionLabel As New Dictionary(Of String, String)
        Dim dctHorizontalPositionLabel As New Dictionary(Of String, String)

        ucrInputHorizontalLabels.SetParameter(New RParameter("hjust", 12))
        dctHorizontalPositionLabel.Add("Left", Chr(34) & "left" & Chr(34))
        dctHorizontalPositionLabel.Add("Center", Chr(34) & "center" & Chr(34))
        dctHorizontalPositionLabel.Add("Right", Chr(34) & "right" & Chr(34))
        dctHorizontalPositionLabel.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctHorizontalPositionLabel.Add("Top", Chr(34) & "top" & Chr(34))
        dctHorizontalPositionLabel.Add("Inward", Chr(34) & "inward" & Chr(34))
        dctHorizontalPositionLabel.Add("Outward", Chr(34) & "outward" & Chr(34))
        ucrInputHorizontalLabels.SetItems(dctHorizontalPositionLabel)
        ucrInputHorizontalLabels.SetRDefault(Chr(34) & "center" & Chr(34))

        ucrInputVerticalLabels.SetParameter(New RParameter("vjust", 11))
        dctVerticalPositionLabel.Add("Left", Chr(34) & "left" & Chr(34))
        dctVerticalPositionLabel.Add("Center", Chr(34) & "center" & Chr(34))
        dctVerticalPositionLabel.Add("Right", Chr(34) & "right" & Chr(34))
        dctVerticalPositionLabel.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctVerticalPositionLabel.Add("Top", Chr(34) & "top" & Chr(34))
        dctVerticalPositionLabel.Add("Inward", Chr(34) & "inward" & Chr(34))
        dctVerticalPositionLabel.Add("Outward", Chr(34) & "outward" & Chr(34))
        ucrInputVerticalLabels.SetItems(dctVerticalPositionLabel)
        ucrInputVerticalLabels.SetRDefault(Chr(34) & "bottom" & Chr(34))

        ucrChkStack.SetText("Stack Bar Graph")
        ucrChkStack.SetParameter(New RParameter("bar.pos", 10), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "stack" & Chr(34), strNewValueIfUnchecked:=Chr(34) & "dodge" & Chr(34))
        ucrChkStack.SetRDefault(Chr(34) & "dodge" & Chr(34))

        ucrChkShowSummary.SetText("Show Summary")
        ucrChkShowSummary.SetParameter(New RParameter("show.summary", 8), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowSummary.SetRDefault("TRUE")

        ucrNudDecimalPlaces.SetParameter(New RParameter("digits", 9))
        ucrNudDecimalPlaces.SetMinMax(0, 4)

        ucrChkBackgroundColour.SetText("Totals Column/Row Background Highlighted")
        ucrChkBackgroundColour.SetParameter(New RParameter("emph.total", 10), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkBackgroundColour.SetRDefault("FALSE")

        ucrChkShowCount.SetText("Show Count")
        ucrChkShowCount.SetParameter(New RParameter("show.n", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowCount.SetRDefault("TRUE")

        ucrChkShowPercentage.SetText("Show Percentage")
        ucrChkShowPercentage.SetParameter(New RParameter("show.prc", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowPercentage.SetRDefault("TRUE")

        ucrInputGraphTitle.SetParameter(New RParameter("title", 9))
        ucrInputTableTitle.SetParameter(New RParameter("title", 13))

        ucrChkShowModelSummary.SetText("Show Model Summary")
        ucrChkShowModelSummary.SetParameter(New RParameter("show.summary", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowModelSummary.SetRDefault("FALSE")

        ucrChkMissingValues.SetText("Show Missing Values")
        ucrChkMissingValues.SetParameter(New RParameter("show.na", 11), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMissingValues.SetRDefault("FALSE")

        ucrPnlGraphType.SetParameter(New RParameter("type", 8))
        ucrPnlGraphType.AddRadioButton(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlGraphType.SetRDefault(Chr(34) & "bar" & Chr(34))

        ucrInputTotalsName.SetParameter(New RParameter("string.total", 12))
        ucrInputTotalsName.SetRDefault(Chr(34) & "Total" & Chr(34))
        ucrChkTotalColumnName.SetText("Total Column Name")

        ucrChkTotalColumnName.SetParameter(ucrInputTotalsName.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkTotalColumnName.AddToLinkedControls(ucrInputTotalsName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlGraphType.AddToLinkedControls(ucrChkStack, {rdoBar}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
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
        clsTwoWayTableFreq = clsNewSjtFreq
        clsTwoWayGraphFreq = clsNewSjpFrq

        ucrChkShowSummary.SetRCode(clsTwoWayTableFreq, bReset)
        ucrChkBackgroundColour.SetRCode(clsTwoWayTableFreq, bReset)
        ucrNudDecimalPlaces.SetRCode(clsTwoWayTableFreq, bReset)
        ucrChkMissingValues.SetRCode(clsTwoWayTableFreq, bReset)
        ucrInputTableTitle.SetRCode(clsTwoWayTableFreq, bReset)
        ucrInputTotalsName.SetRCode(clsTwoWayTableFreq, bReset)
        ucrChkTotalColumnName.SetRCode(clsTwoWayTableFreq, bReset)
        ucrChkShowCount.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrChkStack.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrChkShowPercentage.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrChkShowModelSummary.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrPnlGraphType.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrInputVerticalLabels.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrInputHorizontalLabels.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrInputGraphTitle.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrSaveGraph.SetRCode(clsTwoWayGraphFreq, bReset)
    End Sub

End Class