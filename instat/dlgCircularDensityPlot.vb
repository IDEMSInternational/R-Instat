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

Public Class dlgCircularDensityPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDensityFunction As RFunction
    Private clsRecordGraphFunction As RFunction
    Private clsDensityPlotFunction, clsRosePlotFunction, clsScatterPlotFunction As RFunction
    Private Sub dlgCircularDensityPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctKernel As New Dictionary(Of String, String)
        Dim dctUnits As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrPnlOptions.AddRadioButton(rdoRosePlot)
        ucrPnlOptions.AddRadioButton(rdoDensity)
        ucrPnlOptions.AddRadioButton(rdoScatterPlot)

        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoRosePlot, "x", "rose.diag")
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoDensity, "x", "plot")
        ucrPnlOptions.AddParameterValueFunctionNamesCondition(rdoScatterPlot, "x", "plot.circular")

        ucrPnlOptions.AddToLinkedControls(ucrInputBandWidth, {rdoDensity}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputBins, {rdoRosePlot}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrInputComboKernel, {rdoDensity}, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorDataFrame.SetParameter(New RParameter("data", 0))
        ucrSelectorDataFrame.SetParameterIsrfunction()

        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        ucrReceiverVariable.Selector = ucrSelectorDataFrame
        ucrReceiverVariable.SetParameterIsRFunction()
        ucrReceiverVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverVariable.strSelectorHeading = "Numerics"

        ucrInputBandWidth.SetParameter(New RParameter("bw", 1))
        ucrInputBandWidth.SetValidationTypeAsNumeric()
        ucrInputBandWidth.AddQuotesIfUnrecognised = False
        ucrInputBandWidth.SetLinkedDisplayControl(lblBandWidth)

        ucrInputComboKernel.SetParameter(New RParameter("kernel", 2))
        dctKernel.Add("vonmises", Chr(34) & "vonmises" & Chr(34))
        dctKernel.Add("wrappednormal", Chr(34) & "wrappednormal" & Chr(34))
        ucrInputComboKernel.SetItems(dctKernel)
        ucrInputComboKernel.SetDropDownStyleAsNonEditable()
        ucrInputComboKernel.SetLinkedDisplayControl(lblKernel)

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 3))
        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputBins.SetParameter(New RParameter("bins", 5))
        ucrInputBins.SetValidationTypeAsNumeric()
        ucrInputBins.AddQuotesIfUnrecognised = False
        ucrInputBins.SetLinkedDisplayControl(lblBins)

        ucrInputUnits.SetParameter(New RParameter("units", 5))
        dctUnits.Add("degrees", Chr(34) & "degrees" & Chr(34))
        dctUnits.Add("radians", Chr(34) & "radians" & Chr(34))
        dctUnits.Add("hours", Chr(34) & "hours" & Chr(34))
        ucrInputUnits.SetItems(dctUnits)
        ucrInputUnits.SetDropDownStyleAsNonEditable()
        ucrInputUnits.SetLinkedDisplayControl(lblUnits)

        ucrNudShrink.SetParameter(New RParameter("shrink", 9))
        ucrNudShrink.DecimalPlaces = 1
        ucrNudShrink.Increment = 0.1
        ucrNudShrink.SetRDefault(1.0)
        ucrNudShrink.SetMinMax(0.5, 3)

        ucrSaveDensity.SetPrefix("circular_density")
        ucrSaveDensity.SetDataFrameSelector(ucrSelectorDataFrame.ucrAvailableDataFrames)
        ucrSaveDensity.SetIsComboBox()
        ucrSaveDensity.SetCheckBoxText("Save Graph")
        ucrSaveDensity.SetSaveTypeAsGraph()
        ucrSaveDensity.SetAssignToIfUncheckedValue("last_graph")

    End Sub

    Private Sub SetDefaults()
        clsDensityFunction = New RFunction
        clsDensityPlotFunction = New RFunction
        clsRecordGraphFunction = New RFunction
        clsRosePlotFunction = New RFunction
        clsScatterPlotFunction = New RFunction

        ucrSaveDensity.Reset()
        ucrReceiverVariable.SetMeAsReceiver()
        ucrSelectorDataFrame.Reset()

        clsDensityFunction.SetPackageName("circular")
        clsDensityFunction.SetRCommand("density.circular")
        clsDensityFunction.AddParameter("bw", "25", iPosition:=1)
        clsDensityFunction.AddParameter("kernel", Chr(34) & "vonmises" & Chr(34), iPosition:=2)
        clsDensityFunction.AddParameter("na.rm", "TRUE", iPosition:=3)

        clsDensityPlotFunction.SetRCommand("plot")
        clsDensityPlotFunction.AddParameter("x", clsRFunctionParameter:=clsDensityFunction, iPosition:=0)
        clsDensityPlotFunction.AddParameter("main", Chr(34) & " " & Chr(34), iPosition:=1)
        clsDensityPlotFunction.AddParameter("xlab", Chr(34) & " " & Chr(34), iPosition:=2)
        clsDensityPlotFunction.AddParameter("ylab", Chr(34) & " " & Chr(34), iPosition:=3)
        clsDensityPlotFunction.AddParameter("shrink", 1, iPosition:=4)
        clsDensityPlotFunction.AddParameter("units", Chr(34) & "degrees" & Chr(34), iPosition:=5)

        clsRosePlotFunction.SetPackageName("circular")
        clsRosePlotFunction.SetRCommand("rose.diag")
        clsRosePlotFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
        clsRosePlotFunction.AddParameter("prop", 2.9, iPosition:=4)
        clsRosePlotFunction.AddParameter("bins", 36, iPosition:=5)
        clsRosePlotFunction.AddParameter("col", Chr(34) & "blue" & Chr(34), iPosition:=6)
        clsRosePlotFunction.AddParameter("units", Chr(34) & "degrees" & Chr(34), iPosition:=8)
        clsRosePlotFunction.AddParameter("shrink", 1, iPosition:=9)

        clsScatterPlotFunction.SetPackageName("circular")
        clsScatterPlotFunction.SetRCommand("plot.circular")
        clsScatterPlotFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
        clsScatterPlotFunction.AddParameter("stack", "TRUE", iPosition:=4)
        clsScatterPlotFunction.AddParameter("sep", 0.0003, iPosition:=5)
        clsScatterPlotFunction.AddParameter("shrink", 1, iPosition:=9)

        clsRecordGraphFunction.SetRCommand("record_graph")
        clsRecordGraphFunction.AddParameter("x", clsRFunctionParameter:=clsDensityPlotFunction, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsRecordGraphFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrSaveDensity.SetRCode(clsRecordGraphFunction, bReset)

        ucrReceiverVariable.SetRCode(clsDensityFunction, bReset)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRosePlotFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsScatterPlotFunction, New RParameter("x", 0), iAdditionalPairNo:=2)

        ucrInputBandWidth.SetRCode(clsDensityFunction, bReset)
        ucrInputBins.SetRCode(clsRosePlotFunction, bReset)
        ucrInputComboKernel.SetRCode(clsDensityFunction, bReset)

        ucrNudShrink.SetRCode(clsDensityPlotFunction, bReset)
        ucrNudShrink.AddAdditionalCodeParameterPair(clsRosePlotFunction, New RParameter("shrink", 1), iAdditionalPairNo:=1)
        ucrNudShrink.AddAdditionalCodeParameterPair(clsScatterPlotFunction, New RParameter("shrink", 1), iAdditionalPairNo:=2)

        ucrInputUnits.SetRCode(clsDensityPlotFunction, bReset)
        ucrInputUnits.AddAdditionalCodeParameterPair(clsRosePlotFunction, New RParameter("units", 9), iAdditionalPairNo:=1)
        ucrInputUnits.AddAdditionalCodeParameterPair(clsScatterPlotFunction, New RParameter("units", 9), iAdditionalPairNo:=2)

        ucrChkOmitMissing.SetRCode(clsDensityFunction, bReset)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsRosePlotFunction, New RParameter("na.rm", 1), iAdditionalPairNo:=1)
        ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsScatterPlotFunction, New RParameter("na.rm", 1), iAdditionalPairNo:=2)
    End Sub

    Private Sub TestOkEnabled()
        If ucrSaveDensity.IsComplete AndAlso Not ucrReceiverVariable.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrReceiverVariable.ControlContentsChanged, ucrSaveDensity.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoDensity.Checked Then
            clsRecordGraphFunction.AddParameter("x", clsRFunctionParameter:=clsDensityPlotFunction, iPosition:=0)
            ucrSaveDensity.SetPrefix("density_plot")
        ElseIf rdoRosePlot.Checked Then
            clsRecordGraphFunction.AddParameter("x", clsRFunctionParameter:=clsRosePlotFunction, iPosition:=0)
            ucrSaveDensity.SetPrefix("rose_plot")
        ElseIf rdoScatterPlot.Checked Then
            clsRecordGraphFunction.AddParameter("x", clsRFunctionParameter:=clsScatterPlotFunction, iPosition:=0)
            ucrSaveDensity.SetPrefix("scatter_plot")
        End If
    End Sub
End Class