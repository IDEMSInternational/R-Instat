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

Public Class sdgOneVarCompareModels
    Private bControlsInitialised As Boolean = False
    Private clsRcdfcompFunction, clsRdenscompFunction, clsRqqcompFunction, clsRppcompFunction, clsListFunction, clsRAsDataFrame, clsModel, clsRGofStat, clsRReceiver, clsRsyntax, clsOperation As New RFunction
    Private clsOperatorforTable, clsOperatorForBreaks As New ROperator
    Private WithEvents ucrRecs As ucrReceiver
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarCompareModels(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        'ucrSaveGOF
        ucrSaveGOF.SetName("GOF")
        ucrSaveGOF.SetSaveTypeAsModel() ' or graph?
        ucrSaveGOF.SetCheckBoxText("Save Fit")
        ucrSaveGOF.SetIsComboBox()
        ucrSaveGOF.SetAssignToIfUncheckedValue("last_model")

        'ucrInputChiSquareBreaks
        ucrChkInputChiSquareBreakpoints.SetText("Input Chi-Square Breakpoints")

        'ucrChkPlots
        ucrChkCDF.SetParameter(New RParameter("ft", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCDF.SetRDefault("TRUE")
        ucrChkCDF.SetText("CDF")

        ucrChkDensity.SetParameter(New RParameter("ft", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkDensity.SetText("Density")
        ucrChkDensity.SetRDefault("FALSE")

        ucrChkPP.SetParameter(New RParameter("ft", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkPP.SetRDefault("FALSE")
        ucrChkPP.SetText("PP")

        ucrChkQQ.SetParameter(New RParameter("ft", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkQQ.SetRDefault("FALSE")
        ucrChkQQ.SetText("QQ")
        InitialiseTabs()

        'ucrSavePlot
        ucrSavePlots.SetPrefix("plots")
        ucrSavePlots.SetSaveTypeAsModel()
        ucrSavePlots.SetCheckBoxText("Save Plot")
        ucrSavePlots.SetIsComboBox()
        ucrSavePlots.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Public Sub SetRFunction(clsNewRGofStat As RFunction, clsNewReceiver As RFunction, clsNewRcdfcompFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsRGofStat = clsNewRGofStat
        clsRcdfcompFunction = clsNewRcdfcompFunction
        clsRReceiver = clsNewReceiver
        'Setting Rcode for the sub dialog
        ucrSaveGOF.SetRCode(clsRGofStat, bReset)
        ucrChkCDF.SetRCode(clsRcdfcompFunction, bReset)
        ucrChkDensity.SetRCode(clsRdenscompFunction, bReset)
        ucrChkInputChiSquareBreakpoints.SetRCode(clsOperatorForBreaks, bReset)
        ucrChkPP.SetRCode(clsRppcompFunction, bReset)
        ucrChkQQ.SetRCode(clsRqqcompFunction, bReset)


        If bReset Then
            tbpOneVarCompareModels.SelectedIndex = 0
        End If
    End Sub
    Public Sub InitialiseDialog()
        ucrDisplayChiData.SetValidationTypeAsRVariable()
    End Sub

    Public Sub SetDefaults()
        ucrSavePlots.Enabled = False ' disabled for now
        ucrDisplayChiData.Reset()
        If dlgOneVarCompareModels.ucrSelectorOneVarCompModels.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrDisplayChiData.SetName(dlgOneVarCompareModels.ucrSelectorOneVarCompModels.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_ChiSquare")
        End If
        DisplayChiSquare()
        DisplayChiBreaks()
        'ucrBase.ihelptopicID = 
    End Sub

    Public Sub Reopen()
        DisplayChiSquare()
    End Sub

    Public Sub SetModelFunction(clsNewModel As RFunction)
        clsModel = clsNewModel
    End Sub

    Public Sub DisplayChiSquare()
        If chkSaveChi.Checked Then
            ucrDisplayChiData.Visible = True
            clsOperatorforTable.SetOperation("$")
            clsOperatorforTable.AddParameter(iPosition:=0, clsRFunctionParameter:=clsModel)
            clsOperatorforTable.AddParameter(strParameterValue:="chisqtable")
            clsRAsDataFrame.SetRCommand("as.data.frame")
            clsRAsDataFrame.AddParameter("x", clsROperatorParameter:=clsOperatorforTable)
        Else
            ucrDisplayChiData.Visible = False
        End If
        If Not ucrDisplayChiData.IsEmpty Then
            clsRAsDataFrame.SetAssignTo(ucrDisplayChiData.GetText(), strTempDataframe:=ucrDisplayChiData.GetText())
        Else
            clsRAsDataFrame.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrDisplayChiData_NameChanged()
        DisplayChiSquare()
    End Sub

    Public Sub SetReceiver(ucrNewReceiver As ucrReceiver)
        ucrRecs = ucrNewReceiver
    End Sub

    Public Sub CreateGraphs()
        Dim strTemp As String = ""

        If ucrChkCDF.Checked Then
            clsRcdfcompFunction.SetRCommand("fitdistrplus::cdfcomp")
            clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
            frmMain.clsRLink.RunScript(clsRcdfcompFunction.ToScript(), 2)
        End If
        If ucrChkPP.Checked Then
            clsRppcompFunction.SetRCommand("fitdistrplus::denscomp")
            clsRppcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
            frmMain.clsRLink.RunScript(clsRppcompFunction.ToScript(), 2)
        End If
        If ucrChkQQ.Checked Then
            clsRqqcompFunction.SetRCommand("fitdistrplus::qqcomp")
            clsRqqcompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
            frmMain.clsRLink.RunScript(clsRqqcompFunction.ToScript(), 2)
        End If
        If ucrChkDensity.Checked Then
            clsRdenscompFunction.SetRCommand("fitdistrplus::ppcomp")
            clsRdenscompFunction.AddParameter("ft", clsRFunctionParameter:=clsRReceiver)
            frmMain.clsRLink.RunScript(clsRdenscompFunction.ToScript(), 2)
        End If
        If chkSaveChi.Checked Then
            frmMain.clsRLink.RunScript(clsOperatorforTable.ToScript(), 0)
            clsRAsDataFrame.ToScript(strTemp)
            frmMain.clsRLink.RunScript(strTemp, 0)
        End If
        If ucrChkInputChiSquareBreakpoints.Checked Then
            frmMain.clsRLink.RunScript(clsOperatorForBreaks.ToScript(), 2)
        End If
    End Sub

    Private Sub chkInputBreakpoints_Checked_Changed(sender As Object, e As EventArgs)
        DisplayChiBreaks()
    End Sub

    Public Sub DisplayChiBreaks()
        If ucrChkInputChiSquareBreakpoints.Checked Then
            clsOperatorForBreaks.SetOperation("$")
            clsOperatorForBreaks.AddParameter(iPosition:=0, clsRFunctionParameter:=clsModel)
            clsOperatorForBreaks.AddParameter(strParameterValue:="chisqbreaks")
        End If
    End Sub

    Private Sub chkSaveChi_CheckedChanged(sender As Object, e As EventArgs)
        DisplayChiSquare()
    End Sub

    ' Private Sub ucrSavePlots_NameChanged() Handles ucrSavePlots.Click
    'TODO Graph Names assigned go up in increments for any of the graphs selected (e.g. 3 plots are selected and it is named "plots", then automatically we get "plots1", ... , "plots3"
    'End Sub

    Public Function TestOkEnabled() As Boolean
        Dim bOkEnabled As Boolean
        If (ucrSaveGOF.IsComplete()) AndAlso (chkSaveChi.Checked AndAlso Not ucrDisplayChiData.IsEmpty OrElse Not chkSaveChi.Checked) Then
            bOkEnabled = True
        Else
            bOkEnabled = False
        End If
        Return bOkEnabled
    End Function

    Private Sub InitialiseTabs()
        For i = 0 To tbpOneVarCompareModels.TabCount - 1
            tbpOneVarCompareModels.SelectedIndex = i
        Next
        tbpOneVarCompareModels.SelectedIndex = 0
    End Sub

End Class


' if in main dialog:
' How does this change here?

'Private clsCDF As New RFunction

'Public Sub SetRCodeForControls(bReset As Boolean)
'    ucrreceiverinDLG.SetRCode(clsCDF, bReset)
'End Sub

'Private Sub SetDefaults()
'Dim clsCDFDefault As New RFunction
'ucrChkSetSeed.Checked = False
'clsCDFDefault.SetRCommand("cdfcomp")

'clsCDF = clsCDFDefault.Clone
'End Sub

'    Private Sub InitialiseDialog()
'ucrReceiverinDLG.SetParameter(New RParameter ("ft"))
'    End Sub

'Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk'
'If ucrChkCDF.Checked Then 
'frmMain.clsRLink.RunScript(clsCDF.ToScript, strComment:="")
'End If
'End Sub