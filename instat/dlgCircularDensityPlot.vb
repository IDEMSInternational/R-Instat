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
    Private clsRecordPlotFunction As RFunction
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

        ucrPnlOptions.AddFunctionNamesCondition(rdoRosePlot, "rose.diag")
        ucrPnlOptions.AddFunctionNamesCondition(rdoDensity, "recordPlot")
        ucrPnlOptions.AddFunctionNamesCondition(rdoScatterPlot, "plot.circular")

        ucrPnlOptions.AddToLinkedControls(ucrInputBandWidth, {rdoDensity}, bNewLinkedHideIfParameterMissing:=True)

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

        ucrInputUnits.SetParameter(New RParameter("units", 5))
        dctUnits.Add("degrees", Chr(34) & "degrees" & Chr(34))
        dctUnits.Add("radians", Chr(34) & "radians" & Chr(34))
        dctUnits.Add("hours", Chr(34) & "hours" & Chr(34))
        ucrInputUnits.SetItems(dctUnits)
        ucrInputUnits.SetDropDownStyleAsNonEditable()
        ucrInputUnits.SetLinkedDisplayControl(lblUnits)

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
        clsRecordPlotFunction = New RFunction
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

        clsRosePlotFunction.SetPackageName("circular")
        clsRosePlotFunction.SetRCommand("rose.diag")
        clsRosePlotFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
        clsRosePlotFunction.AddParameter("prop", 2.9, bIncludeArgumentName:=True, iPosition:=4)
        clsRosePlotFunction.AddParameter("bin", 36, bIncludeArgumentName:=True, iPosition:=5)
        clsRosePlotFunction.AddParameter("col", Chr(34) & "blue" & Chr(34), bIncludeArgumentName:=True, iPosition:=6)
        clsRosePlotFunction.AddParameter("kernel", Chr(34) & "vonmises" & Chr(34), iPosition:=7)
        clsRosePlotFunction.AddParameter("units", Chr(34) & "degrees" & Chr(34), iPosition:=8)

        clsScatterPlotFunction.SetPackageName("circular")
        clsScatterPlotFunction.SetRCommand("plot.circular")
        clsScatterPlotFunction.AddParameter("na.rm", "TRUE", iPosition:=3)
        clsScatterPlotFunction.AddParameter("stack", "TRUE", iPosition:=4)
        clsScatterPlotFunction.AddParameter("sep", 0.0003, bIncludeArgumentName:=True, iPosition:=5)
        clsScatterPlotFunction.AddParameter("shrink", 2, bIncludeArgumentName:=True, iPosition:=6)
        clsScatterPlotFunction.AddParameter("kernel", Chr(34) & "vonmises" & Chr(34), iPosition:=7)
        clsScatterPlotFunction.AddParameter("units", Chr(34) & "degrees" & Chr(34), iPosition:=8)


        clsDensityPlotFunction.SetRCommand("plot")
        clsDensityPlotFunction.AddParameter("x", clsRFunctionParameter:=clsDensityFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsDensityPlotFunction.AddParameter("main", Chr(34) & " " & Chr(34), bIncludeArgumentName:=True, iPosition:=1)
        clsDensityPlotFunction.AddParameter("xlab", Chr(34) & " " & Chr(34), bIncludeArgumentName:=True, iPosition:=2)
        clsDensityPlotFunction.AddParameter("ylab", Chr(34) & " " & Chr(34), bIncludeArgumentName:=True, iPosition:=3)
        clsDensityPlotFunction.AddParameter("shrink", 1.3, bIncludeArgumentName:=True, iPosition:=4)
        clsDensityPlotFunction.AddParameter("units", Chr(34) & "degrees" & Chr(34), iPosition:=5)

        clsRecordPlotFunction.SetPackageName("grDevices")
        clsRecordPlotFunction.SetRCommand("recordPlot")

        'clsRecordPlotFunction.AddParameter("x", clsRFunctionParameter:=clsDensityPlotFunction, bIncludeArgumentName:=False, iPosition:=0)



        'ucrSaveDensity.SetRCode(clsRecordPlotFunction, bReset)
        '''''''''''''''''ucrSaveDensity.SetRCode(clsDensityPlotFunction, bReset)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'ucrInputBandWidth.AddAdditionalCodeParameterPair(clsDensityFunction, ucrInputBandWidth.GetParameter(), iAdditionalPairNo:=1)
        'ucrChkOmitMissing.AddAdditionalCodeParameterPair(clsDensityFunction, ucrChkOmitMissing.GetParameter(), iAdditionalPairNo:=1)
        'ucrInputComboKernel.AddAdditionalCodeParameterPair(clsDensityFunction, ucrInputComboKernel.GetParameter(), iAdditionalPairNo:=1)
        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrSaveDensity.SetRCode(clsRecordPlotFunction, bReset)
        '''''''''''''ucrSaveDensity.SetRCode(clsDensityPlotFunction, bReset)
        ucrSaveDensity.AddAdditionalRCode(clsRosePlotFunction, iAdditionalPairNo:=1)
        ucrSaveDensity.AddAdditionalRCode(clsScatterPlotFunction, iAdditionalPairNo:=2)

        ucrReceiverVariable.SetRCode(clsDensityFunction, bReset)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsRosePlotFunction, New RParameter("x", 0), iAdditionalPairNo:=1)
        ucrReceiverVariable.AddAdditionalCodeParameterPair(clsScatterPlotFunction, New RParameter("x", 0), iAdditionalPairNo:=2)
        ucrInputBandWidth.SetRCode(clsDensityFunction, bReset)
        ucrInputComboKernel.SetRCode(clsDensityFunction, bReset)
        ucrInputComboKernel.AddAdditionalCodeParameterPair(clsRosePlotFunction, New RParameter("kernel", 7), iAdditionalPairNo:=1)
        ucrInputComboKernel.AddAdditionalCodeParameterPair(clsScatterPlotFunction, New RParameter("kernel", 7), iAdditionalPairNo:=2)


        ucrInputUnits.SetRCode(clsDensityPlotFunction, bReset)
        ucrInputUnits.AddAdditionalCodeParameterPair(clsRosePlotFunction, New RParameter("units", 2), iAdditionalPairNo:=1)
        ucrInputUnits.AddAdditionalCodeParameterPair(clsScatterPlotFunction, New RParameter("units", 2), iAdditionalPairNo:=2)

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
            ucrBase.clsRsyntax.AddToBeforeCodes(clsDensityPlotFunction)
            ucrBase.clsRsyntax.SetBaseRFunction(clsRecordPlotFunction)


            ucrSaveDensity.SetPrefix("density_plot")

        ElseIf rdoRosePlot.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRosePlotFunction)
            ucrSaveDensity.SetPrefix("rose_plot")
        ElseIf rdoScatterPlot.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsScatterPlotFunction)
            ucrSaveDensity.SetPrefix("scatter_plot")
        End If
    End Sub


    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk



        ucrBase.clsRsyntax.AddToBeforeCodes(clsDensityPlotFunction)
        'ucrBase.clsRsyntax.SetBaseRFunction(clsRecordPlotFunction)

        Dim strBeforeScripts As String = ucrBase.clsRsyntax.GetBeforeCodesScripts()(0)
        Dim strScripts As String = ucrBase.clsRsyntax.GetScript()

        ucrBase.clsRsyntax.strScript = ""

        ucrBase.clsRsyntax.GetBeforeCodes.Clear()



        ucrBase.clsRsyntax.SetCommandString(strBeforeScripts & Environment.NewLine & strScripts)


        'Dim strScript1 As String = ""
        'Dim strScript2 As String = ""
        'Dim strRealScript As String = ucrBase.clsRsyntax.GetScript
        'Dim funct1 As RFunction = ucrBase.clsRsyntax.clsBaseFunction.Clone
        ''funct1.SetPackageName("grDevices")
        ''funct1.SetRCommand("recordPlot")

        'Dim str1 As String = clsDensityPlotFunction.ToScript(strScript1, strScript2)

        'Dim str2 As String = clsRecordPlotFunction.ToScript
        'Dim str4 As String = funct1.ToScript(strScript1, strScript2)

        'ucrBase.clsRsyntax.GetBeforeCodes.Clear()



        'ucrBase.clsRsyntax.SetCommandString(str1 & Environment.NewLine & str2 & Environment.NewLine)
    End Sub
End Class