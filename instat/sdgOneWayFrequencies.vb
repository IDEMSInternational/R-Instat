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
Public Class sdgOneWayFrequencies
    Public bControlsInitialised As Boolean = False
    Public clsOneWayTableFreq, clsOneWayGraphFreq As New RFunction
    Private Sub sdgOneWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctVerticalPositionLabel As New Dictionary(Of String, String)
        Dim dctHorizontalPositionLabel As New Dictionary(Of String, String)

        ucrInputHorizontalLabels.SetParameter(New RParameter("hjust"))
        dctHorizontalPositionLabel.Add("Left", Chr(34) & "left" & Chr(34))
        dctHorizontalPositionLabel.Add("Center", Chr(34) & "center" & Chr(34))
        dctHorizontalPositionLabel.Add("Right", Chr(34) & "right" & Chr(34))
        dctHorizontalPositionLabel.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctHorizontalPositionLabel.Add("Top", Chr(34) & "top" & Chr(34))
        dctHorizontalPositionLabel.Add("Inward", Chr(34) & "inward" & Chr(34))
        dctHorizontalPositionLabel.Add("Outward", Chr(34) & "outward" & Chr(34))
        ucrInputHorizontalLabels.SetItems(dctHorizontalPositionLabel)

        ucrInputVerticalLabels.SetParameter(New RParameter("vjust"))
        dctVerticalPositionLabel.Add("Left", Chr(34) & "left" & Chr(34))
        dctVerticalPositionLabel.Add("Center", Chr(34) & "center" & Chr(34))
        dctVerticalPositionLabel.Add("Right", Chr(34) & "right" & Chr(34))
        dctVerticalPositionLabel.Add("Bottom", Chr(34) & "bottom" & Chr(34))
        dctVerticalPositionLabel.Add("Top", Chr(34) & "top" & Chr(34))
        dctVerticalPositionLabel.Add("Inward", Chr(34) & "inward" & Chr(34))
        dctVerticalPositionLabel.Add("Outward", Chr(34) & "outward" & Chr(34))
        ucrInputVerticalLabels.SetItems(dctVerticalPositionLabel)

        ucrChkMedian.SetText("Emphasise Median")
        ucrChkMedian.SetParameter(New RParameter("emph.md"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMedian.SetRDefault("FALSE")

        'Set to unchecked on default(Default is TRUE)
        ucrChkShowSummary.SetText("Show Summary")
        ucrChkShowSummary.SetParameter(New RParameter("show.summary"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        'Default is auto
        ucrChkOmitZero.SetText("Omit Zero Counts from Table")
        ucrChkOmitZero.SetParameter(New RParameter("skip.zero"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")


        ucrChkDecimalPlaces.SetText("Decimal places for percentages")
        ucrNudDecimalPlaces.SetParameter(New RParameter("digits"))
        ucrChkDecimalPlaces.AddToLinkedControls(ucrNudDecimalPlaces, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDecimalPlaces.SetParameter(ucrNudDecimalPlaces.GetParameter, bNewAddRemoveParameter:=True, bNewChangeParameterValue:=True)
        ucrNudDecimalPlaces.SetMinMax(0, 4)

        ucrChkHighlightedRows.SetText("Alternate Rows Coloured")
        ucrChkHighlightedRows.SetParameter(New RParameter("altr.row.col"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkHighlightedRows.SetRDefault("FALSE")

        ucrChkShowCount.SetText("Show Count")
        ucrChkShowCount.SetParameter(New RParameter("show.n"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowCount.SetRDefault("FALSE")

        ucrChkShowPercentage.SetText("Show Percentage")
        ucrChkShowPercentage.SetParameter(New RParameter("show.prc"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")

        ucrChkVerticalLabelPosition.SetText("Vertical Label Positions")
        ' ucrChkVerticalLabelPosition.SetParameter(ucrInputVerticalLabels.GetParameter, bNewAddRemoveParameter:=True, bNewChangeParameterValue:=True)
        ucrChkVerticalLabelPosition.AddToLinkedControls(ucrInputVerticalLabels, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkHorizontalLabelPosition.SetText("Horizontal Label Positions")
        ' ucrChkHorizontalLabelPosition.SetParameter(ucrInputHorizontalLabels.GetParameter, bNewAddRemoveParameter:=True, bNewChangeParameterValue:=True)
        ucrChkHorizontalLabelPosition.AddToLinkedControls(ucrInputHorizontalLabels, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'not implemented
        ucrChkColour.Enabled = False
        ucrInputColour.Enabled = False
        ucrInputColour.bAllowNonConditionValues = False
        ucrChkColour.bAllowNonConditionValues = False
        'ucrChkColour.SetText("Colour")
        'ucrChkColour.AddToLinkedControls(ucrInputColour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkGraphTitle.SetText("Title")
        ucrInputGraphTitle.SetParameter(New RParameter("title"))
        ' ucrChkGraphTitle.SetParameter(ucrInputGraphTitle.GetParameter(), bNewAddRemoveParameter:=True, bNewChangeParameterValue:=True)
        ucrChkGraphTitle.AddToLinkedControls(ucrInputGraphTitle, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkShowMissing.SetText("Show Missing")
        ucrChkShowMissing.SetParameter(New RParameter("show.na"), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowMissing.SetRDefault("FALSE")

        ucrPnlGraphType.SetParameter(New RParameter("type"))
        ucrPnlGraphType.AddRadioButton(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoDot, Chr(34) & "dot" & Chr(34))
        ucrPnlGraphType.SetRDefault(Chr(34) & "bar" & Chr(34))

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
        ucrChkShowCount.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkShowPercentage.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkShowMissing.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkVerticalLabelPosition.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkHorizontalLabelPosition.SetRCode(clsOneWayGraphFreq, bReset)
        'ucrChkColour.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkGraphTitle.SetRCode(clsOneWayGraphFreq, bReset)
        ucrPnlGraphType.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputVerticalLabels.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputHorizontalLabels.SetRCode(clsOneWayGraphFreq, bReset)
        ucrInputColour.SetRCode(clsOneWayGraphFreq, bReset)
        ucrChkGraphTitle.SetRCode(clsOneWayGraphFreq, bReset)
        ucrSaveGraph.SetRCode(clsOneWayGraphFreq, bReset)
    End Sub
End Class