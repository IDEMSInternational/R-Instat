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
Public Class dlgDotPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_dotplot As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgDotPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRgeom_dotplot.SetRCommand("geom_dotplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrFactorReceiver.Selector = ucrDotPlotSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondFactorReceiver.Selector = ucrDotPlotSelector
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrBase.clsRsyntax.iCallType = 0

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        sdgPlots.SetGgplotFunction(clsRggplotFunction)
        ucrVariablesAsFactorDotPlot.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorDotPlot.SetSelector(ucrDotPlotSelector)
        ucrVariablesAsFactorDotPlot.SetIncludedDataType({"numeric"})
        ucrBase.iHelpTopicID = 437

        ucrSaveDotPlot.SetDataFrameSelector(ucrDotPlotSelector.ucrAvailableDataFrames)
        ucrSaveDotPlot.strPrefix = "Dotplot"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorDotPlot.IsEmpty OrElse (ucrSaveDotPlot.chkSaveGraph.Checked AndAlso ucrSaveDotPlot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub SetDefaults()
        clsRaesFunction.ClearParameters()
        clsRgeom_dotplot.ClearParameters()
        ucrDotPlotSelector.Reset()
        ucrVariablesAsFactorDotPlot.ResetControl()
        ucrSaveDotPlot.Reset()
        sdgPlots.Reset()
        SetXParameter()
        TestOkEnabled()
    End Sub

    Private Sub SetXParameter()
        If ucrFactorReceiver.IsEmpty() = False Then
            clsRaesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter("x", Chr(34) & "" & Chr(34))
        End If
    End Sub

    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged
        SetXParameter()
    End Sub

    Private Sub ucrSecondFactorReceiver_SelectonChanged(sender As Object, e As EventArgs) Handles ucrSecondFactorReceiver.SelectionChanged
        If ucrSecondFactorReceiver.IsEmpty() = False Then
            clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("fill")
        End If
    End Sub

    Private Sub ucrDotPlotSelector_DataFrameChanged() Handles ucrDotPlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrDotPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdDotPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdDotPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_dotplot, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrDotPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        'Task: adapt for multivariable case...
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrFactorReceiver.Clear()
                Else
                    ucrFactorReceiver.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorDotPlot.bSingleVariable) Then
                ucrVariablesAsFactorDotPlot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub ucrVariablesAsFactorDotPlot_SelectionChanged() Handles ucrVariablesAsFactorDotPlot.SelectionChanged
        If ucrVariablesAsFactorDotPlot.IsEmpty() = False Then
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_dotplot)
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorDotPlot.GetVariableNames(False))
            clsRgeom_dotplot.AddParameter("binaxis", Chr(34) & "y" & Chr(34))
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveDotPlot_GraphNameChanged() Handles ucrSaveDotPlot.GraphNameChanged, ucrSaveDotPlot.SaveGraphCheckedChanged
        If ucrSaveDotPlot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveDotPlot.strGraphName, strTempDataframe:=ucrDotPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveDotPlot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrDotPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrDotPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrSaveDotPlot_ContentsChanged() Handles ucrSaveDotPlot.ContentsChanged
        TestOkEnabled()
    End Sub
End Class