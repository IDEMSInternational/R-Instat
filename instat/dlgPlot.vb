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
Public Class dlgPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_lineplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
            'SetDefaults
            SetDefaults()
        Else
            'reopendialog
        End If

        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)

        clsRgeom_lineplotFunction.SetRCommand("geom_line")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_lineplotFunction)

        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 434


        ucrReceiverX.Selector = ucrLinePlotSelector
        ucrReceiverX.SetIncludedDataTypes({"numeric", "factor"})
        ucrFactorOptionalReceiver.Selector = ucrLinePlotSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})
        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)



        ucrVariablesAsFactorForLinePlot.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForLinePlot.SetSelector(ucrLinePlotSelector)
        ucrVariablesAsFactorForLinePlot.SetIncludedDataType({"numeric", "factor"})

        ucrSaveLinePlot.SetDataFrameSelector(ucrLinePlotSelector.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

    End Sub
    Private Sub SetDefaults()
        clsRaesFunction.ClearParameters()
        clsRgeom_lineplotFunction.ClearParameters()
        chkPoints.Checked = False
        '        ucrLinePlotSelector.Focus()
        ucrSaveLinePlot.strPrefix = "Line"
        ucrVariablesAsFactorForLinePlot.SetMeAsReceiver()
        ucrLinePlotSelector.Reset()
        ucrVariablesAsFactorForLinePlot.ResetControl()
        ucrSaveLinePlot.Reset()
        sdgPlots.Reset()
        SetXParameter()
        SetYParameter()
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub



    Private Sub SetXParameter()
        If Not ucrReceiverX.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
            ucrFactorOptionalReceiver.SetMeAsReceiver()
        Else
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
        End If
    End Sub

    Private Sub SetYParameter()
        If Not ucrVariablesAsFactorForLinePlot.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForLinePlot.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("y", Chr(34) & Chr(34))
        End If
    End Sub
    Private Sub TestOkEnabled()
        'Both x and y aesthetics are mandatory for geom_line. However, when not filled they will be automatically populated by "".
        If (ucrSaveLinePlot.chkSaveGraph.Checked AndAlso ucrSaveLinePlot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrPlotSelector_DataFrameChanged() Handles ucrLinePlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrLinePlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged
        SetXParameter()
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorOptionalReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.SelectionChanged
        If ucrFactorOptionalReceiver.IsEmpty() = False Then
            clsRaesFunction.AddParameter("colour", ucrFactorOptionalReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkPoints_CheckedChanged(sender As Object, e As EventArgs) Handles chkPoints.CheckedChanged
        Dim clsTempRFunc As New RFunction
        If chkPoints.Checked = True Then
            clsTempRFunc.SetRCommand("geom_point")
            ucrBase.clsRsyntax.AddOperatorParameter("geom_point", clsRFunc:=clsTempRFunc)
        Else
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
        End If
    End Sub

    Private Sub UcrVariablesAsFactor_SelectionChanged() Handles ucrVariablesAsFactorForLinePlot.SelectionChanged
        SetYParameter()
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactorForLinePlot.bSingleVariable Then
            cmdLineOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdLineOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub
    Private Sub ucrSaveLinePlot_GraphNameChanged() Handles ucrSaveLinePlot.GraphNameChanged, ucrSaveLinePlot.SaveGraphCheckedChanged
        If ucrSaveLinePlot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveLinePlot.strGraphName, strTempDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveLinePlot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs) Handles cmdLineOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_lineplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrLinePlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        'Coming from the sdgLayerOptions, clsRaesFunction and others has been modified. One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required. 
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForLinePlot.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrVariablesAsFactorForLinePlot.Clear()
                Else ucrVariablesAsFactorForLinePlot.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveLinePlot_ContentsChanged() Handles ucrSaveLinePlot.ContentsChanged
        TestOkEnabled()
    End Sub
End Class