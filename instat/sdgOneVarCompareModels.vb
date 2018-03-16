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
Public Class sdgOneVarCompareModels
    Private bControlsInitialised As Boolean = False
    Private clsCdfcompFunction, clsDenscompFunction, clsQqcompFunction, clsPpcompFunction, clsListFunction, clsRAsDataFrame, clsModel, clsRGofStat, clsRPlotFunction, clsOperation As New RFunction
    Private clsChisqtableOperator, clsChisqbreaksOperator As New ROperator
    Private clsRSyntax As RSyntax

    Private Sub sdgOneVarCompareModels(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        InitialiseTabs()

        'ucrInputChiSquareBreaks
        ucrChkInputChiSquareBreakpoints.SetText("Display Chi-Square Breakpoints")

        ucrChkCDF.AddRSyntaxContainsFunctionNamesCondition(True, {"cdfcomp"})
        ucrChkCDF.AddRSyntaxContainsFunctionNamesCondition(False, {"cdfcomp"}, False)
        ucrChkCDF.SetText("CDF")

        ucrChkDensity.SetText("Density")
        ucrChkDensity.AddRSyntaxContainsFunctionNamesCondition(True, {"denscomp"})
        ucrChkDensity.AddRSyntaxContainsFunctionNamesCondition(False, {"denscomp"}, False)

        ucrChkPP.SetText("PP")
        ucrChkPP.AddRSyntaxContainsFunctionNamesCondition(True, {"ppcomp"})
        ucrChkPP.AddRSyntaxContainsFunctionNamesCondition(False, {"ppcomp"}, False)

        ucrChkQQ.SetText("QQ")
        ucrChkQQ.AddRSyntaxContainsFunctionNamesCondition(True, {"qqcomp"})
        ucrChkQQ.AddRSyntaxContainsFunctionNamesCondition(False, {"qqcomp"}, False)

        'ucrSaveGOF
        ucrSaveGOF.SetPrefix("GOF")
        ucrSaveGOF.SetCheckBoxText("Save Fit")
        ucrSaveGOF.SetIsComboBox()
        ucrSaveGOF.SetAssignToIfUncheckedValue("last_model")
        ucrSaveGOF.SetSaveTypeAsModel()
        'temp disabled until working
        ucrSaveGOF.Enabled = False
        ucrSaveGOF.ucrChkSave.Checked = False

        'ucrSaveDisplayChi
        ' ucrSaveDisplayChi.SetPrefix("ChiSquare")
        ucrSaveDisplayChi.SetSaveTypeAsDataFrame()
        ucrSaveDisplayChi.SetCheckBoxText("DisplayChi")
        ucrSaveDisplayChi.SetIsComboBox()
        ucrSaveDisplayChi.SetAssignToIfUncheckedValue("last_DataFrame")
        'temp disabled until working
        ucrSaveDisplayChi.Enabled = False

        'ucrSavePlot
        ucrSavePlots.Visible = False 'hidden as would need to be able to save up to four graphs
        ucrSavePlots.SetPrefix("plots")
        ucrSavePlots.SetSaveTypeAsModel()
        ucrSavePlots.SetCheckBoxText("Save Plot")
        ucrSavePlots.SetIsComboBox()
        ucrSavePlots.SetAssignToIfUncheckedValue("last_model")

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewRGofStat As RFunction, clsNewDenscompFunction As RFunction, clsNewCdfcompFunction As RFunction, clsNewQqcompFunction As RFunction, clsNewPpcompFunction As RFunction, clsNewclsRAsDataFrame As RFunction, Optional clsNewChisqtableOperator As ROperator = Nothing, Optional clsNewChisqbreaksOperator As ROperator = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsRSyntax = clsNewRSyntax
        clsRGofStat = clsNewRGofStat
        clsChisqtableOperator = clsNewChisqtableOperator
        clsChisqbreaksOperator = clsNewChisqbreaksOperator

        clsRAsDataFrame = clsNewclsRAsDataFrame
        clsDenscompFunction = clsNewDenscompFunction
        clsCdfcompFunction = clsNewCdfcompFunction
        clsQqcompFunction = clsNewQqcompFunction
        clsPpcompFunction = clsNewPpcompFunction

        'ucrSaveGOF.SetRCode(clsRGofStat, bReset)
        'ucrSaveDisplayChi.SetRCode(clsRAsDataFrame, bReset)

        ucrChkDensity.SetRSyntax(clsRSyntax, bReset)
        ucrChkPP.SetRSyntax(clsRSyntax, bReset)
        ucrChkQQ.SetRSyntax(clsRSyntax, bReset)
        ucrChkCDF.SetRSyntax(clsRSyntax, bReset)

        ucrChkInputChiSquareBreakpoints.SetRSyntax(clsRSyntax, bReset)

        If bReset Then
            tbpOneVarCompareModels.SelectedIndex = 0
        End If
    End Sub

    Public Sub CreateGraphs()
        Dim strTemp As String = ""

        'If ucrChkCDF.Checked Then
        '    clsCdfcompFunction.SetPackageName("fitdistrplus")
        '    clsCdfcompFunction.SetRCommand("cdfcomp")
        '    clsCdfcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
        '    frmMain.clsRLink.RunScript(clsCdfcompFunction.ToScript(), 3)
        'End If
        'If ucrChkPP.Checked Then
        '    clsPpcompFunction.SetPackageName("fitdistrplus")
        '    clsPpcompFunction.SetRCommand("ppcomp")
        '    clsPpcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
        '    frmMain.clsRLink.RunScript(clsPpcompFunction.ToScript(), 3)

        'End If
        'If ucrChkQQ.Checked Then
        '    clsQqcompFunction.SetPackageName("fitdistrplus")
        '    clsQqcompFunction.SetRCommand("qqcomp")
        '    clsQqcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
        '    frmMain.clsRLink.RunScript(clsQqcompFunction.ToScript(), 3)
        'End If
        'If ucrChkDensity.Checked Then
        '    clsDenscompFunction.SetPackageName("fitdistrplus")
        '    clsDenscompFunction.SetRCommand("denscomp")
        '    clsDenscompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
        '    frmMain.clsRLink.RunScript(clsDenscompFunction.ToScript(), 3)
        'End If

        'If ucrSaveDisplayChi.IsComplete Then
        '    clsChisqtableOperator.SetOperation("$")
        '    clsChisqtableOperator.AddParameter(clsRFunctionParameter:=clsRGofStat, iPosition:=0)
        '    clsChisqtableOperator.AddParameter(strParameterValue:="chisqtable")

        '    frmMain.clsRLink.RunScript(clsChisqtableOperator.ToScript(), 0)
        '    clsRAsDataFrame.ToScript(strTemp)
        '    frmMain.clsRLink.RunScript(strTemp, 0)
        'End If
        'If ucrChkInputChiSquareBreakpoints.Checked Then
        '    clsChisqbreaksOperator.SetOperation("$")
        '    clsChisqbreaksOperator.AddParameter(iPosition:=0, clsRFunctionParameter:=clsRGofStat)
        '    clsChisqbreaksOperator.AddParameter(strParameterValue:="chisqbreaks")
        '    frmMain.clsRLink.RunScript(clsChisqbreaksOperator.ToScript(), 2)
        'End If

    End Sub

    Private Sub InitialiseTabs()
        For i = 0 To tbpOneVarCompareModels.TabCount - 1
            tbpOneVarCompareModels.SelectedIndex = i
        Next
        tbpOneVarCompareModels.SelectedIndex = 0
    End Sub

    Private Sub ucrChkCDF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCDF.ControlValueChanged
        If ucrChkCDF.Checked Then
            clsRSyntax.AddToAfterCodes(clsCdfcompFunction, iPosition:=0)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsCdfcompFunction)
        End If
    End Sub

    Private Sub ucrChkPP_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPP.ControlValueChanged
        If ucrChkPP.Checked Then
            clsRSyntax.AddToAfterCodes(clsPpcompFunction, iPosition:=1)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsPpcompFunction)
        End If
    End Sub

    Private Sub ucrChkQQ_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkQQ.ControlValueChanged
        If ucrChkQQ.Checked Then
            clsRSyntax.AddToAfterCodes(clsQqcompFunction, iPosition:=2)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsQqcompFunction)
        End If
    End Sub

    Private Sub ucrChkDensity_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDensity.ControlValueChanged
        If ucrChkDensity.Checked Then
            clsRSyntax.AddToAfterCodes(clsDenscompFunction, iPosition:=3)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsDenscompFunction)
        End If
    End Sub

    Private Sub ucrChkInputChiSquareBreakpoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkInputChiSquareBreakpoints.ControlValueChanged
        If ucrChkInputChiSquareBreakpoints.Checked Then
            clsRSyntax.AddToAfterCodes(clsChisqbreaksOperator, iPosition:=4)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsChisqbreaksOperator)
        End If
    End Sub
End Class


