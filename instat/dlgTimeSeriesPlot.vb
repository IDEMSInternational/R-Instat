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

Public Class dlgTimeSeriesPlot

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    ' Constants
    Private strReference As String = "reference"
    Private strEstimates As String = "estimates"
    Private strData As String = "data"
    Private strValue As String = "value"

    ' Adjust NA values
    Private clsAdjustNAOperator As ROperator
    Private clsAdjustNAMutate As RFunction
    Private clsIfElseReference As RFunction
    Private clsIsNaReference As RFunction
    Private clsIfElseEstimates As RFunction
    Private clsIsNaEstimates As RFunction

    ' Stack data
    Private clsStackOperator As ROperator
    Private clsPivotLonger As RFunction

    ' Calculate means
    Private clsMeansOperator As ROperator
    Private clsMeansGroupBy As RFunction
    Private clsMeansSummarise As RFunction
    Private clsMeanFunction As RFunction

    Private Sub dlgTimeSeriesPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID =

        ucrSelectorTimeSeriesPlots.SetParameter(New RParameter("0", 0))
        ucrSelectorTimeSeriesPlots.SetParameterIsrfunction()

        ucrReceiverReference.SetParameter(New RParameter("x", 0))
        ucrReceiverReference.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverReference.SetParameterIsString()
        ucrReceiverReference.bWithQuotes = False

        ucrReceiverEstimates.SetParameter(New RParameter("x", 0))
        ucrReceiverEstimates.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverEstimates.SetParameterIsString()
        ucrReceiverEstimates.bWithQuotes = False

        ucrReceiverTime.SetParameter(New RParameter("", 1))
        ucrReceiverTime.Selector = ucrSelectorTimeSeriesPlots

        ucrReceiverStation.SetParameter(New RParameter("0", 0))
        ucrReceiverStation.Selector = ucrSelectorTimeSeriesPlots
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bWithQuotes = False

    End Sub

    Private Sub SetDefaults()
        ucrSelectorTimeSeriesPlots.Reset()

        ' Adjust NA values

        SetDataFrameAssignTo()
        clsAdjustNAOperator.SetOperation("%>%")
        clsAdjustNAOperator.AddParameter("1", clsRFunctionParameter:=clsAdjustNAMutate, iPosition:=1)

        clsAdjustNAMutate.SetPackageName("dplyr")
        clsAdjustNAMutate.SetRCommand("mutate")
        clsAdjustNAMutate.AddParameter(strReference, clsRFunctionParameter:=clsIfElseReference, iPosition:=0)
        clsAdjustNAMutate.AddParameter(strEstimates, clsRFunctionParameter:=clsIfElseEstimates, iPosition:=1)

        clsIfElseReference.SetRCommand("ifelse")
        clsIfElseReference.AddParameter("test", clsRFunctionParameter:=clsIsNaReference, iPosition:=0)
        clsIfElseReference.AddParameter("yes", "NA", iPosition:=1)

        clsIfElseEstimates.SetRCommand("ifelse")
        clsIfElseEstimates.AddParameter("test", clsRFunctionParameter:=clsIsNaEstimates, iPosition:=0)
        clsIfElseEstimates.AddParameter("yes", "NA", iPosition:=1)

        clsIsNaReference.SetRCommand("is.na")
        clsIsNaEstimates.SetRCommand("is.na")

        ' Stack data

        clsStackOperator.SetOperation("%>%")
        clsStackOperator.AddParameter("0", clsROperatorParameter:=clsAdjustNAOperator, iPosition:=0)
        clsStackOperator.AddParameter("1", clsRFunctionParameter:=clsPivotLonger, iPosition:=1)

        clsPivotLonger.SetPackageName("tidyr")
        clsPivotLonger.SetRCommand("pivot_longer")
        clsPivotLonger.AddParameter("cols", "c(" & strReference & ", " & strEstimates & ")", iPosition:=1)
        clsPivotLonger.AddParameter("names_to", Chr(34) & strData & Chr(34), iPosition:=2)
        clsPivotLonger.AddParameter("values_to", Chr(34) & strValue & Chr(34), iPosition:=8)

        ' Calculate means

        clsMeansOperator.SetOperation("%>%")
        clsMeansOperator.AddParameter("0", clsRFunctionParameter:=clsPivotLonger, iPosition:=0)
        clsMeansOperator.AddParameter("1", clsRFunctionParameter:=clsMeansGroupBy, iPosition:=1)
        clsMeansOperator.AddParameter("1", clsRFunctionParameter:=clsMeansSummarise, iPosition:=2)

        clsMeansGroupBy.SetPackageName("dplyr")
        clsMeansGroupBy.SetRCommand("group_by")
        clsMeansGroupBy.AddParameter("1", strData, iPosition:=1)

        clsMeansSummarise.SetPackageName("dplyr")
        clsMeansSummarise.SetRCommand("summarise")
        clsMeansSummarise.AddParameter("mean", clsRFunctionParameter:=clsMeanFunction, iPosition:=0)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("x", strValue, iPosition:=0)
        clsMeanFunction.AddParameter("na.rm", "TRUE", iPosition:=1)

        'ucrBase.clsRsyntax.SetBaseRFunction()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverReference.AddAdditionalCodeParameterPair(clsIfElseReference, New RParameter("no", 2), iAdditionalPairNo:=1)
        ucrReceiverEstimates.AddAdditionalCodeParameterPair(clsIfElseEstimates, New RParameter("no", 2), iAdditionalPairNo:=1)

        ucrSelectorTimeSeriesPlots.SetRCode(clsAdjustNAOperator, bReset)
        ucrReceiverReference.SetRCode(clsIsNaReference, bReset)
        ucrReceiverEstimates.SetRCode(clsIsNaEstimates, bReset)
        ucrReceiverStation.SetRCode(clsMeansGroupBy, bReset)

    End Sub

    Private Sub SetDataFrameAssignTo()
        If ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsAdjustNAOperator.clsParameters.Count > 1 Then
            clsAdjustNAOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            clsStackOperator.SetAssignTo(ucrSelectorTimeSeriesPlots.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_stack")
        Else
            clsAdjustNAOperator.RemoveAssignTo()
            clsStackOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrSelectorTimeSeriesPlots_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTimeSeriesPlots.ControlValueChanged
        SetDataFrameAssignTo()
    End Sub
End Class