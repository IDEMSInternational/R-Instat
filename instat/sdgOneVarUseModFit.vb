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
Public Class sdgOneVarUseModFit
    Private bControlsInitialised As Boolean = False
    Private clsRSeqFunction, clsOneVarRBootFunction, clsOneVarQuantileFunction, clsRBootFunction, clsRReceiver, clsRPlotAllFunction, clsRplotPPfunction, clsRplotCDFfunction, clsRplotQQfunction, clsRplotDensfunction, clsRplotCIfunction, clsRNoPlotfunction As New RFunction
    Private clsRSyntax As RSyntax
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctQuantileValues As New Dictionary(Of String, String)

        ucrNudIterations.SetParameter(New RParameter("niter", 1))
        ucrNudIterations.SetMinMax(1, 10001)
        ucrNudIterations.SetRDefault(1001)
        ucrNudIterations.Increment = 100

        ucrNudCI.SetParameter(New RParameter("CI.level", 1))
        ucrNudCI.SetMinMax(0, 1)
        ucrNudCI.SetRDefault(0.95)
        ucrNudCI.Increment = 0.05

        ucrChkParametric.SetParameter(New RParameter("bootmethod", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "param" & Chr(34), strNewValueIfUnchecked:=Chr(34) & "nonparam" & Chr(34))
        ucrChkParametric.SetText("Parametric")
        ucrChkParametric.SetRDefault(Chr(34) & "param" & Chr(34))

        ' "probs" parameter:
        ucrPnlQuantiles.AddRadioButton(rdoSequence)
        ucrPnlQuantiles.AddRadioButton(rdoInsertValues)

        'ucrPnlQuantiles.AddRSyntaxContainsFunctionNamesCondition(rdoSequence, {"seq"})
        'ucrPnlQuantiles.AddRSyntaxContainsFunctionNamesCondition(rdoInsertValues, {"quantile"})

        ucrPnlQuantiles.AddFunctionNamesCondition(rdoSequence, "seq")
        ucrPnlQuantiles.AddFunctionNamesCondition(rdoInsertValues, "quantile")

        '1. Function ran here is probs = seq(from = , to = , by =)
        ucrNudFrom.SetParameter(New RParameter("from", 1))
        ucrNudFrom.SetMinMax(0, 1)
        ucrNudFrom.Increment = 0.05
        ucrNudFrom.SetRDefault(0)

        ucrNudTo.SetParameter(New RParameter("to", 2))
        ucrNudTo.SetMinMax(0, 1)
        ucrNudTo.Increment = 0.05
        ucrNudTo.SetRDefault(1)

        ucrNudBy.SetParameter(New RParameter("by", 3))
        ucrNudBy.SetMinMax(0.01, 1)
        ucrNudBy.Increment = 0.05
        ucrNudBy.SetRDefault(0.25)

        'function ran here is probs = c(VALUES)
        ucrInputQuantiles.SetParameter(New RParameter("x"))
        dctQuantileValues.Add("0.25,0.5,0.75", Chr(34) & "0.25,0.5,0.75" & Chr(34))
        dctQuantileValues.Add("0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8,0.9", Chr(34) & "0.1,0.2,0.3,0.4,0.5,0.6,0.7,0.8,0.9" & Chr(34))
        ucrInputQuantiles.SetItems(dctQuantileValues)
        ucrInputQuantiles.bAllowNonConditionValues = True
        ucrInputQuantiles.SetValidationTypeAsNumericList(dcmMin:=0, dcmMax:=1)

        ucrPnlQuantiles.AddToLinkedControls(ucrInputQuantiles, {rdoInsertValues}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.25,0.5,0.75")
        ucrPnlQuantiles.AddToLinkedControls(ucrNudTo, {rdoSequence}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrPnlQuantiles.AddToLinkedControls(ucrNudFrom, {rdoSequence}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrPnlQuantiles.AddToLinkedControls(ucrNudBy, {rdoSequence}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrNudTo.SetLinkedDisplayControl(lblTo)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)
        ucrNudBy.SetLinkedDisplayControl(lblBy)

        ucrPnlPlots.AddRadioButton(rdoNoPlot)
        ucrPnlPlots.AddRadioButton(rdoPlotAll)
        ucrPnlPlots.AddRadioButton(rdoPPPlot)
        ucrPnlPlots.AddRadioButton(rdoCDFPlot)
        ucrPnlPlots.AddRadioButton(rdoQQPlot)
        ucrPnlPlots.AddRadioButton(rdoDensityPlot)
        ucrPnlPlots.AddRadioButton(rdoCIcdf)

        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoNoPlot, {""})
        ' ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoNoPlot, {""}, False)
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoPlotAll, {"plot"})
        'ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoPlotAll, {"plot"}, False)
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoPPPlot, {"ppcomp"})
        'ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoPPPlot, {"ppcomp"}, False)
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoCDFPlot, {"cdfcomp"})
        'ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoCDFPlot, {"cdfcomp"}, False)
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoQQPlot, {"qqcomp"})
        ' ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoQQPlot, {"qqcomp"}, False)
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoDensityPlot, {"denscomp"})
        'ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoDensityPlot, {"denscomp"}, False)
        ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoCIcdf, {"cicdfplot"})
        'ucrPnlPlots.AddRSyntaxContainsFunctionNamesCondition(rdoCIcdf, {"cicdfplot"}, False)


        'ucrPnlPlots.AddFunctionNamesCondition(rdoNoPlot, "")
        'ucrPnlPlots.AddFunctionNamesCondition(rdoPlotAll, "plot")
        'ucrPnlPlots.AddFunctionNamesCondition(rdoPPPlot, "ppcomp")
        'ucrPnlPlots.AddFunctionNamesCondition(rdoCDFPlot, "cdfcomp")
        'ucrPnlPlots.AddFunctionNamesCondition(rdoQQPlot, "qqcomp")
        'ucrPnlPlots.AddFunctionNamesCondition(rdoDensityPlot, "denscomp")
        'ucrPnlPlots.AddFunctionNamesCondition(rdoCIcdf, "CIcdfplot")
        InitialiseTabs()
        SetPlotOptions()

        ' rdoNoPlot.Enabled = False ' temporary
        bControlsInitialised = True
    End Sub

    Public Sub SetRcode(ClsNewRSyntax As RSyntax, clsNewRSeqFunction As RFunction, clsNewRBootFunction As RFunction, clsNewQuantileFunction As RFunction, clsNewReceiver As RFunction, clsNewPlotAllFunction As RFunction, clsNewplotPPfunction As RFunction, clsNewplotCDFfunction As RFunction, clsNewplotQQfunction As RFunction, clsNewplotDensfunction As RFunction, clsNewplotCIfunction As RFunction, clsNewNoPlotfunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRSyntax = ClsNewRSyntax
        clsRSeqFunction = clsNewRSeqFunction
        clsOneVarRBootFunction = clsNewRBootFunction
        clsOneVarQuantileFunction = clsNewQuantileFunction
        clsRReceiver = clsNewReceiver
        ' clsRPlotFunction = clsNewPlotFunction
        clsRPlotAllFunction = clsNewPlotAllFunction
        clsRplotPPfunction = clsNewplotPPfunction
        clsRplotCDFfunction = clsNewplotCDFfunction
        clsRplotQQfunction = clsNewplotQQfunction
        clsRplotDensfunction = clsNewplotDensfunction
        clsRplotCIfunction = clsNewplotCIfunction
        clsRNoPlotfunction = clsNewNoPlotfunction
        'Setting Rcode for the sub dialog
        ucrNudFrom.SetRCode(clsRSeqFunction, bReset)
        ucrNudTo.SetRCode(clsRSeqFunction, bReset)
        ucrNudBy.SetRCode(clsRSeqFunction, bReset)
        ucrChkParametric.SetRCode(clsOneVarRBootFunction, bReset)
        ucrNudIterations.SetRCode(clsOneVarRBootFunction, bReset)
        ucrNudCI.SetRCode(clsOneVarQuantileFunction, bReset)
        ucrPnlPlots.SetRSyntax(clsRSyntax, bReset)
        ucrPnlQuantiles.SetRCode(clsRSeqFunction, bReset)
        ucrInputQuantiles.SetRCode(clsOneVarQuantileFunction, bReset)

        If bReset Then
            tbpOneVarUseModFit.SelectedIndex = 0
        End If
    End Sub

    Public Sub CreateGraphs()
        '    If rdoPlotAll.Checked Then
        '        clsRPlotAllFunction.ClearParameters()
        '        clsRPlotAllFunction.SetPackageName("graphics")
        '        clsRPlotAllFunction.SetRCommand("plot")
        '        clsRPlotAllFunction.AddParameter("x", clsRFunctionParameter:=clsRReceiver)
        '    ElseIf rdoPPPlot.Checked Then
        '        clsRplotPPfunction.removeparameterbyname("x")
        '        clsRplotPPfunction.ClearParameters()
        '        clsRplotPPfunction.SetPackageName("fitdistrplus")
        '        clsRplotPPfunction.SetRCommand("ppcomp")
        '        clsRplotPPfunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
        '    ElseIf rdoCDFPlot.Checked Then
        '        clsrplotCDFfunction.clearparameters()
        '        clsrplotCDFfunction.removeparameterbyname("x")
        '        clsrplotCDFfunction.setpackagename("fitdistrplus")
        '        clsrplotCDFfunction.setrcommand("cdfcomp")
        '        clsRplotCDFfunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
        '    ElseIf rdoQQPlot.Checked Then
        '        clsrplotQQfunction.removeparameterbyname("x")
        '        clsrplotQQfunction.clearparameters()
        '        clsrplotQQfunction.setpackagename("fitdistrplus")
        '        clsrplotQQfunction.setrcommand("qqcomp")
        '        clsrplotQQfunction.addparameter("ft", clsrfunctionparameter:=clsRReceiver)
        '    ElseIf rdoDensityPlot.Checked Then
        '        clsrplotDensfunction.removeparameterbyname("x")
        '        clsrplotDensfunction.clearparameters()
        '        clsrplotDensfunction.setpackagename("fitdistrplus")
        '        clsrplotDensfunction.setrcommand("denscomp")
        '        clsrplotDensfunction.addparameter("ft", clsrfunctionparameter:=clsRReceiver)
        '    ElseIf rdoCIcdf.Checked Then
        '        clsrplotCIfunction.removeparameterbyname("x")
        '        clsrplotCIfunction.clearparameters()
        '        clsrplotCIfunction.setpackagename("fitdistrplus")
        '        clsrplotCIfunction.setrcommand("cicdfplot")
        '        dlgOneVarUseModel.clsRBootFunction.RemoveParameterByName("bootmethod")
        '        dlgOneVarUseModel.clsRBootFunction.RemoveParameterByName("niter")
        '        clsrplotCIfunction.addparameter("b", clsrfunctionparameter:=clsOneVarRBootFunction)
        '        clsrplotCIfunction.addparameter("ci.output", Chr(34) & "quantile" & Chr(34))
        '    End If
    End Sub


    Public Sub SetPlotOptions()
        If Not dlgOneVarUseModel.ucrChkProduceBootstrap.Checked Then
            rdoCIcdf.Enabled = False
            tbpBootstrapOptions.Enabled = False
            If rdoCIcdf.Checked Then
                rdoPlotAll.Checked = True
            End If
        Else
            rdoCIcdf.Enabled = True
            tbpBootstrapOptions.Enabled = True
        End If
    End Sub

    Private Sub ucrBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrBase.ClickReturn
        QuantileCommand()
        CreateGraphs()
    End Sub

    Public Sub QuantileCommand()
        If rdoSequence.Checked Then
            clsOneVarQuantileFunction.AddParameter("probs", clsRFunctionParameter:=clsRSeqFunction)
        Else
            clsOneVarQuantileFunction.AddParameter("probs", strParameterValue:="c(" & ucrInputQuantiles.GetText & ")")
        End If
    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpOneVarUseModFit.TabCount - 1
            tbpOneVarUseModFit.SelectedIndex = i
        Next
        tbpOneVarUseModFit.SelectedIndex = 0
    End Sub

    Private Sub ucrPnlPlots_ControlValueChanged() Handles ucrPnlPlots.ControlValueChanged
        If rdoPlotAll.Checked Then
            clsRSyntax.AddToAfterCodes(clsRPlotAllFunction, iPosition:=1)
            'clsRSyntax.SetBaseRFunction(clsRPlotAllFunction)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRPlotAllFunction)
        End If
        If rdoPPPlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotPPfunction, iPosition:=2)
            '  clsRSyntax.SetBaseRFunction(clsRplotPPfunction)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRplotPPfunction)
        End If
        If rdoQQPlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotQQfunction, iPosition:=3)
            ' clsRSyntax.SetBaseRFunction(clsRplotQQfunction)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRplotQQfunction)
        End If
        If rdoDensityPlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotDensfunction, iPosition:=4)
            '   clsRSyntax.SetBaseRFunction(clsRplotDensfunction)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRplotDensfunction)
        End If
        If rdoCIcdf.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotCIfunction, iPosition:=5)
            clsRplotCIfunction.AddParameter("b", clsRFunctionParameter:=clsOneVarRBootFunction)
            clsRplotCIfunction.AddParameter("CI.cdfplot", Chr(34) & "quantile" & Chr(34))
            'clsRSyntax.SetBaseRFunction(clsRplotCIfunction)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRplotCIfunction)
        End If
        If rdoNoPlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRNoPlotfunction, iPosition:=6)
            clsRSyntax.SetBaseRFunction(clsRNoPlotfunction)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRNoPlotfunction)
        End If
        If rdoCDFPlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRplotCDFfunction, iPosition:=7)
            'clsRSyntax.SetBaseRFunction(clsRplotCDFfunction)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRplotCDFfunction)
        End If

    End Sub

End Class