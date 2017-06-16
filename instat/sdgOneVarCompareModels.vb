
﻿' Instat-R
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

Public Class sdgOneVarCompareModels
    Private bControlsInitialised As Boolean = False
    Private clsRcdfcompFunction, clsRdenscompFunction, clsRqqcompFunction, clsRppcompFunction, clsListFunction, clsRAsDataFrame, clsModel, clsRGofStat, clsRGofStat2, clsRReceiver, clsRsyntax, clsRPlotFunction, clsOperation As New RFunction
    Private clsOperatorforTable, clsOperatorForBreaks As New ROperator
    Private WithEvents ucrRecs As ucrReceiver
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarCompareModels(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        'ucrInputChiSquareBreaks
        ucrChkInputChiSquareBreakpoints.SetText("Input Chi-Square Breakpoints")

        'ucrChkPlots
        ucrChkCDF.AddFunctionNamesCondition(True, "cdfcomp")
        ucrChkCDF.SetText("CDF")

        ucrChkDensity.SetText("Density")
        ucrChkPP.SetText("PP")
        ucrChkQQ.SetText("QQ")
        InitialiseTabs()
        'ucrSaveGOF
        ucrSaveGOF.SetPrefix("GOF")
        ' ucrSaveGOF.SetSaveTypeAsModel() ' or graph?
        ucrSaveGOF.SetCheckBoxText("Save Fit")
        ucrSaveGOF.SetIsComboBox()
        ucrSaveGOF.SetAssignToIfUncheckedValue("last_model")

        'ucrSaveDisplayChi
        ' ucrSaveDisplayChi.SetPrefix("ChiSquare")
        ucrSaveDisplayChi.SetSaveTypeAsDataFrame()
        ucrSaveDisplayChi.SetCheckBoxText("DisplayChi")
        ucrSaveDisplayChi.SetIsComboBox()
        ucrSaveDisplayChi.SetAssignToIfUncheckedValue("last_DataFrame")

        'ucrSavePlot
        ucrSavePlots.Enabled = False 'for now
        ucrSavePlots.SetPrefix("plots")
        ucrSavePlots.SetSaveTypeAsModel()
        ucrSavePlots.SetCheckBoxText("Save Plot")
        ucrSavePlots.SetIsComboBox()
        ucrSavePlots.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Public Sub SetRCode(clsNewRGofStat As RFunction, clsNewReceiver As RFunction, clsNewRdenscompFunction As RFunction, clsNewRcdfcompFunction As RFunction, clsNewRqqcompFunction As RFunction, clsNewRppcompFunction As RFunction, clsNewclsRAsDataFrame As RFunction, Optional clsNewOperatorforTable As ROperator = Nothing, Optional clsNewOperatorForBreaks As ROperator = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsRGofStat = clsNewRGofStat.Clone
        clsRGofStat2 = clsNewRGofStat.Clone
        clsRReceiver = clsNewReceiver
        clsOperatorforTable = clsNewOperatorforTable
        clsRAsDataFrame = clsNewclsRAsDataFrame
        '  clsRPlotFunction = clsNewRPlotFunction
        clsRdenscompFunction = clsNewRdenscompFunction
        clsRcdfcompFunction = clsNewRcdfcompFunction
        clsRqqcompFunction = clsNewRqqcompFunction
        clsRppcompFunction = clsNewRppcompFunction
        clsOperatorForBreaks = clsNewOperatorForBreaks

        'Setting Rcode for the sub dialog
        ucrSaveGOF.SetRCode(clsRGofStat, bReset)
        ucrChkCDF.SetRCode(clsRcdfcompFunction, bReset)
        ucrChkDensity.SetRCode(clsRdenscompFunction, bReset)
        ucrChkInputChiSquareBreakpoints.SetRCode(clsOperatorForBreaks, bReset)
        ucrChkPP.SetRCode(clsRppcompFunction, bReset)
        ucrChkQQ.SetRCode(clsRqqcompFunction, bReset)
        ucrSaveDisplayChi.SetRCode(clsRAsDataFrame, bReset)

        If bReset Then
            tbpOneVarCompareModels.SelectedIndex = 0
        End If
    End Sub

    Public Sub CreateGraphs()
        Dim strTemp As String = ""

        If ucrChkCDF.Checked Then
            clsRcdfcompFunction.SetPackageName("fitdistrplus")
            clsRcdfcompFunction.SetRCommand("cdfcomp")
            clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
            frmMain.clsRLink.RunScript(clsRcdfcompFunction.ToScript(), 3)
        End If
        If ucrChkPP.Checked Then
            clsRppcompFunction.SetPackageName("fitdistrplus")
            clsRppcompFunction.SetRCommand("ppcomp")
            clsRppcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
            frmMain.clsRLink.RunScript(clsRppcompFunction.ToScript(), 3)

        End If
        If ucrChkQQ.Checked Then
            clsRqqcompFunction.SetPackageName("fitdistrplus")
            clsRqqcompFunction.SetRCommand("qqcomp")
            clsRqqcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
            frmMain.clsRLink.RunScript(clsRqqcompFunction.ToScript(), 3)
        End If
        If ucrChkDensity.Checked Then
            clsRdenscompFunction.SetPackageName("fitdistrplus")
            clsRdenscompFunction.SetRCommand("denscomp")
            clsRdenscompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
            frmMain.clsRLink.RunScript(clsRdenscompFunction.ToScript(), 3)
        End If

        If ucrSaveDisplayChi.IsComplete Then
            clsOperatorforTable.SetOperation("$")
            clsOperatorforTable.AddParameter(clsRFunctionParameter:=clsRGofStat2, iPosition:=0)
            clsOperatorforTable.AddParameter(strParameterValue:="chisqtable")

            frmMain.clsRLink.RunScript(clsOperatorforTable.ToScript(), 0)
            clsRAsDataFrame.ToScript(strTemp)
            frmMain.clsRLink.RunScript(strTemp, 0)
        End If
        If ucrChkInputChiSquareBreakpoints.Checked Then
            clsOperatorForBreaks.SetOperation("$")
            clsOperatorForBreaks.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRGofStat)
            clsOperatorForBreaks.AddParameter(strParameterValue:="chisqbreaks")
            frmMain.clsRLink.RunScript(clsOperatorForBreaks.ToScript(), 2)
        End If

    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpOneVarCompareModels.TabCount - 1
            tbpOneVarCompareModels.SelectedIndex = i
        Next
        tbpOneVarCompareModels.SelectedIndex = 0
    End Sub

End Class


