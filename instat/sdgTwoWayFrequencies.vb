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
Public Class sdgTwoWayFrequencies
    Public bControlsInitialised As Boolean = False
    Public clsTwoWayTableFreq, clsTwoWayGraphFreq As New RFunction
    Public clsGraphOperator As ROperator
    Public bUseTitle As Boolean = True

    Private Sub sdgTwoWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctVerticalPositionLabel As New Dictionary(Of String, String)
        Dim dctHorizontalPositionLabel As New Dictionary(Of String, String)

        'Setting Table parameter
        ucrInputHorizontalLabels.SetParameter(New RParameter("hjust", 13))
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

        'Setting Table parameter
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

        ucrChkStack.SetParameter(New RParameter("bar.pos", 10), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "stack" & Chr(34), strNewValueIfUnchecked:=Chr(34) & "dodge" & Chr(34))
        ucrChkStack.SetText("Stack Bar Graph")
        ucrChkStack.SetRDefault(Chr(34) & "dodge" & Chr(34))

        'Setting Table parameter
        ucrChkShowSummary.SetParameter(New RParameter("show.summary", 9), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowSummary.SetText("Show Summary")
        ucrChkShowSummary.SetRDefault("TRUE")

        'Setting Table parameter
        ucrNudDecimalPlaces.SetParameter(New RParameter("digits", 10))
        ucrNudDecimalPlaces.SetMinMax(0, 4)

        'Setting Table parameter
        ucrChkBackgroundColour.SetParameter(New RParameter("emph.total", 11), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkBackgroundColour.SetText("Totals Column/Row Background Highlighted")
        ucrChkBackgroundColour.SetRDefault("FALSE")

        'Setting Plot parameter
        ucrChkShowCount.SetParameter(New RParameter("show.n", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowCount.SetText("Show Count")
        ucrChkShowCount.SetRDefault("TRUE")

        'Setting Plot parameter
        ucrChkShowPercentage.SetParameter(New RParameter("show.prc", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowPercentage.SetText("Show Percentage")
        ucrChkShowPercentage.SetRDefault("TRUE")

        'Setting Plot & Table parameter
        ucrInputGraphTitle.SetParameter(New RParameter("title", 9))
        ucrInputTableTitle.SetParameter(New RParameter("title", 14))

        'Setting Plot parameter
        ucrChkShowModelSummary.SetParameter(New RParameter("show.summary", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkShowModelSummary.SetText("Show Model Summary")
        ucrChkShowModelSummary.SetRDefault("FALSE")

        'Setting Plot parameter
        ucrChkMissingValues.SetParameter(New RParameter("show.na", 11), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkMissingValues.SetText("Show Missing Values")
        ucrChkMissingValues.SetRDefault("FALSE")

        'Setting Plot parameter
        ucrPnlGraphType.SetParameter(New RParameter("type", 8))
        ucrPnlGraphType.AddRadioButton(rdoBar, Chr(34) & "bar" & Chr(34))
        ucrPnlGraphType.AddRadioButton(rdoLine, Chr(34) & "line" & Chr(34))
        ucrPnlGraphType.SetRDefault(Chr(34) & "bar" & Chr(34))

        'Setting Plot parameter
        ucrInputTotalsName.SetParameter(New RParameter("string.total", 12))
        ucrInputTotalsName.SetRDefault(Chr(34) & "Total" & Chr(34))
        ucrChkTotalColumnName.SetText("Total Column Name")

        'Setting Plot parameter
        ucrChkTotalColumnName.SetParameter(ucrInputTotalsName.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkTotalColumnName.AddToLinkedControls(ucrInputTotalsName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'Setting Plot parameter
        ucrPnlGraphType.AddToLinkedControls(ucrChkStack, {rdoBar}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)

        'TODO: Investigate why when some variables are used for line graph this error is given "Breaks and labels are of different lengths"
        rdoLine.Enabled = False
        bControlsInitialised = True
    End Sub
    'Linking the subdialog to the functions main dialogue
    Public Sub SetRCode(clsNewSjtFreq As RFunction, clsNewSjpFrq As RFunction, Optional clsNewGraphOperator As ROperator = Nothing, Optional bReset As Boolean = False, Optional bNewUseTitle As Boolean = True)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsTwoWayTableFreq = clsNewSjtFreq
        clsTwoWayGraphFreq = clsNewSjpFrq
        clsGraphOperator = clsNewGraphOperator
        bUseTitle = bNewUseTitle

        'Setting Rcode for the sub dialogue
        ucrChkShowSummary.SetRCode(clsTwoWayTableFreq, bReset)
        ucrChkBackgroundColour.SetRCode(clsTwoWayTableFreq, bReset)
        ucrNudDecimalPlaces.SetRCode(clsTwoWayTableFreq, bReset)
        ucrChkMissingValues.SetRCode(clsTwoWayTableFreq, bReset)
        ucrInputTotalsName.SetRCode(clsTwoWayTableFreq, bReset)
        ucrChkTotalColumnName.SetRCode(clsTwoWayTableFreq, bReset)
        ucrChkShowCount.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrChkStack.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrChkShowPercentage.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrChkShowModelSummary.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrPnlGraphType.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrInputVerticalLabels.SetRCode(clsTwoWayGraphFreq, bReset)
        ucrInputHorizontalLabels.SetRCode(clsTwoWayGraphFreq, bReset)

        If bUseTitle Then
            ucrInputTableTitle.SetRCode(clsTwoWayTableFreq, bReset)
            ucrInputGraphTitle.SetRCode(clsTwoWayGraphFreq, bReset)
            ucrInputTableTitle.Enabled = True
            ucrInputGraphTitle.Enabled = True
        Else
            ucrInputTableTitle.SetName("")
            ucrInputGraphTitle.SetName("")
            ucrInputTableTitle.Enabled = False
            ucrInputGraphTitle.Enabled = False
        End If
    End Sub

    'This is a temporary solution to a known bug with sjPlot package
    'Issue posted here https://github.com/strengejacke/sjPlot/issues/227
    'This sub can be removed when this issue is resolved in sjPlot
    Private Sub CheckboxesForShowValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkShowPercentage.ControlValueChanged, ucrChkShowCount.ControlValueChanged
        If (ucrChkShowPercentage.Checked = False AndAlso ucrChkShowCount.Checked = False) Then
            clsTwoWayGraphFreq.AddParameter("show.values", "FALSE")
        Else
            clsTwoWayGraphFreq.RemoveParameterByName("show.values")
        End If
    End Sub
End Class
