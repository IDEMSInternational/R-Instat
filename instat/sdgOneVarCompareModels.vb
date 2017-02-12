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
    Private clsRcdfcompFunction, clsRdenscompFunction, clsRqqcompFunction, clsRppcompFunction, clsListFunction, clsRAsDataFrame, clsModel, clsRsyntax, clsOperation As New RFunction
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
        ucrChkCDF.SetText("CDF")
        ucrChkDensity.SetText("Density")
        ucrChkPP.SetText("PP")
        ucrChkQQ.SetText("QQ")

        'ucrSavePlot
        ucrSavePlots.SetPrefix("plots")
        ucrSavePlots.SetSaveTypeAsModel()
        ucrSavePlots.SetCheckBoxText("Save Plot")
        ucrSavePlots.SetIsComboBox()
        ucrSavePlots.SetAssignToIfUncheckedValue("last_model")
    End Sub



    Public Sub InitialiseDialog()
        clsRcdfcompFunction.SetRCommand("cdfcomp")
        clsRdenscompFunction.SetRCommand("denscomp")
        clsRqqcompFunction.SetRCommand("qqcomp")
        clsRppcompFunction.SetRCommand("ppcomp")
        ucrDisplayChiData.SetValidationTypeAsRVariable()
    End Sub

    Public Sub SetDefaults()
        ucrChkCDF.Checked = True
        ucrChkDensity.Checked = False
        ucrChkPP.Checked = False
        ucrChkQQ.Checked = False
        chkSaveChi.Checked = True
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

    Private Sub ucrDisplayChiData_NameChanged() Handles ucrDisplayChiData.NameChanged
        DisplayChiSquare()
    End Sub

    Public Sub SetReceiver(ucrNewReceiver As ucrReceiver)
        ucrRecs = ucrNewReceiver
    End Sub

    Public Sub CreateGraphs()
        Dim strTemp As String = ""

        If ucrChkCDF.Checked Then
            clsRcdfcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
            frmMain.clsRLink.RunScript(clsRcdfcompFunction.ToScript(), 2)
        End If
        If ucrChkPP.Checked Then
            clsRppcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
            frmMain.clsRLink.RunScript(clsRppcompFunction.ToScript(), 2)
        End If
        If ucrChkQQ.Checked Then
            clsRqqcompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
            frmMain.clsRLink.RunScript(clsRqqcompFunction.ToScript(), 2)
        End If
        If ucrChkDensity.Checked Then
            clsRdenscompFunction.AddParameter("ft", clsRFunctionParameter:=dlgOneVarCompareModels.UcrReceiver.GetVariables())
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

    Private Sub chkSaveChi_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveChi.CheckedChanged
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