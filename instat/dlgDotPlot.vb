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
    Private strBinAxis As String
    Private strOtherAxis As String
    Private bEditAesFunction As Boolean = True

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
        ucrOtherAxisReceiver.Selector = ucrDotPlotSelector
        ucrOtherAxisReceiver.SetIncludedDataTypes({"factor", "numeric"}) 'Warning: Even if having "factor" only would maybe be more appropriate for the Axi that is not BinAxis, when coming back from the LayerOptions, where x and y can take both numeric and factor values, we would get bugs.
        ucrFactorReceiver.Selector = ucrDotPlotSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrBase.clsRsyntax.iCallType = 0


        ucrVariablesAsFactorDotPlot.SetFactorReceiver(ucrOtherAxisReceiver)
        ucrVariablesAsFactorDotPlot.SetSelector(ucrDotPlotSelector)
        ucrVariablesAsFactorDotPlot.SetIncludedDataType({"numeric", "factor"})
        ucrBase.iHelpTopicID = 437

        ucrSaveDotPlot.SetDataFrameSelector(ucrDotPlotSelector.ucrAvailableDataFrames)
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
        ucrSaveDotPlot.strPrefix = "Dotplot"
        ucrVariablesAsFactorDotPlot.ResetControl()
        ucrSaveDotPlot.Reset()
        sdgPlots.Reset()
        rdoXBinAxis.Checked = True 'If it was already True, no need to change anything, else it will raise event rdoBinAxis_CheckChanged
        SetFactorAxisAes()
        SetBinAxisAes() 'TestOk is done within this sub.
    End Sub

    Private Sub rdoBinAxis_CheckedChanged(sender As Object, e As EventArgs) Handles rdoXBinAxis.CheckedChanged
        If rdoYBinAxis.Checked Then
            strBinAxis = "y"
            strOtherAxis = "x"
            clsRgeom_dotplot.AddParameter("binaxis", Chr(34) & "y" & Chr(34))
        Else
            strBinAxis = "x"
            strOtherAxis = "y"
            clsRgeom_dotplot.AddParameter("binaxis", Chr(34) & "x" & Chr(34))
        End If
        'The aes parameters for x and y in the AesFunction need to be updated, unless we are setting up the dialogue according to the content of AesFunction, when coming back from LayerOptions.
        If bEditAesFunction Then
            SetFactorAxisAes()
            SetBinAxisAes()
        End If
    End Sub


    Private Sub SetFactorAxisAes()
        If ucrOtherAxisReceiver.IsEmpty() = False Then
            clsRaesFunction.AddParameter(strOtherAxis, ucrOtherAxisReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.AddParameter(strOtherAxis, Chr(34) & "" & Chr(34))
        End If
    End Sub
    Private Sub SetBinAxisAes()
        'Warning: need to name the geom_dotplot parameter of the RSyntax as other parameters could be added via plot options...
        If ucrVariablesAsFactorDotPlot.IsEmpty() = False Then
            ucrBase.clsRsyntax.SetOperatorParameter(False, strParameterName:="1.geom_dotplot", clsRFunc:=clsRgeom_dotplot)
            clsRaesFunction.AddParameter(strBinAxis, ucrVariablesAsFactorDotPlot.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(strBinAxis)
            ucrBase.clsRsyntax.RemoveOperatorParameter("1.geom_dotplot")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrOtherAxisReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrOtherAxisReceiver.SelectionChanged
        If bEditAesFunction Then 'The content of the AesFunction should not be edited when we are setting up the dialogue according to the content of AesFunction, when coming back from LayerOptions.
            SetFactorAxisAes()
        End If
    End Sub

    Private Sub ucrVariablesAsFactorDotPlot_SelectionChanged() Handles ucrVariablesAsFactorDotPlot.SelectionChanged
        If bEditAesFunction Then 'The content of the AesFunction should not be edited when we are setting up the dialogue according to the content of AesFunction, when coming back from LayerOptions.
            SetBinAxisAes()
        End If
    End Sub
    Private Sub ucrFactorReceiver_SelectonChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged
        If bEditAesFunction Then 'The content of the AesFunction should not be edited when we are setting up the dialogue according to the content of AesFunction, when coming back from LayerOptions.
            If ucrFactorReceiver.IsEmpty() = False Then
                clsRaesFunction.AddParameter("fill", ucrFactorReceiver.GetVariableNames(False))
            Else
                clsRaesFunction.RemoveParameterByName("fill")
            End If
        End If
    End Sub

    Private Sub ucrDotPlotSelector_DataFrameChanged() Handles ucrDotPlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrDotPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
        'Warning Question to be discussed: this is quite tricky, should reset everything that is data related, also in the sdgPLotOptions, the global dataframe should be changed so I would reset the whole ucrAdditionalLayers and so delete all the layers that are still stored in the RSyntax as OperatorParameters... How do we do this ? Maybe use new clean link with Options when designed...
        clsRaesFunction.ClearParameters() 'Theaes parameters that can be edited on the dialogue will be, but the parameters that have been edited on plots need to be removed...
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdDotPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdDotPlotOptions.Click
        Dim iIndex As Integer
        bEditAesFunction = False 'The content of the AesFunction should not be edited when we are setting up the dialogue according to the content of AesFunction, when coming back from LayerOptions.

        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_dotplot, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrDotPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        iIndex = clsRgeom_dotplot.clsParameters.FindIndex(Function(x) x.strArgumentName = "binaxis")
        If iIndex <> -1 AndAlso clsRgeom_dotplot.clsParameters(iIndex).strArgumentValue = "y" Then
            rdoYBinAxis.Checked = True
        Else
            rdoXBinAxis.Checked = True 'Note the default value of "binaxis" is "x"
        End If
        'Task: adapt for multivariable case...
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = strOtherAxis Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrOtherAxisReceiver.Clear()
                Else
                    ucrOtherAxisReceiver.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = strBinAxis AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorDotPlot.bSingleVariable) Then
                ucrVariablesAsFactorDotPlot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next

        bEditAesFunction = True

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
        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        sdgPlots.SetGgplotFunction(clsRggplotFunction)
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrDotPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrSaveDotPlot_ContentsChanged() Handles ucrSaveDotPlot.ContentsChanged
        TestOkEnabled()
    End Sub
End Class