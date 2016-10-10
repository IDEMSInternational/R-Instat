
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
Public Class dlgScatterPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_scatterplotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True

    Private Sub dlgScatterPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            'setdefauts
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
        TestOkEnabled()

    End Sub

    Private Sub ucrSelectorForScatter_DataFrameChanged() Handles ucrSelectorForScatter.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForScatter.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged

        If Not ucrReceiverX.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorOptionalReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.SelectionChanged
        If Not ucrFactorOptionalReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("colour", ucrFactorOptionalReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub

    Private Sub TestOkEnabled()
        'tests when okay Is enable
        If ucrReceiverX.IsEmpty() Or ucrVariablesAsFactorForScatter.IsEmpty Or (ucrSaveScatterPlot.chkSaveGraph.Checked And ucrSaveScatterPlot.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)

        clsRgeom_scatterplotFunction.SetRCommand("geom_point")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_scatterplotFunction)

        ucrVariablesAsFactorForScatter.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForScatter.SetSelector(ucrSelectorForScatter)
        ucrVariablesAsFactorForScatter.SetIncludedDataType({"factor", "numeric"})

        ucrReceiverX.Selector = ucrSelectorForScatter
        ucrReceiverX.SetIncludedDataTypes({"factor", "numeric"})
        ucrFactorOptionalReceiver.Selector = ucrSelectorForScatter
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        ucrBase.iHelpTopicID = 433

        ucrSaveScatterPlot.SetDataFrameSelector(ucrSelectorForScatter.ucrAvailableDataFrames)
        ucrSaveScatterPlot.strPrefix = "Scatter"
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

    End Sub
    Private Sub SetDefaults()
        'setDefaults
        clsRaesFunction.ClearParameters()
        clsRgeom_scatterplotFunction.ClearParameters()
        ucrSelectorForScatter.Reset()
        ucrSelectorForScatter.Focus()
        ucrVariablesAsFactorForScatter.ResetControl()
        sdgPlots.Reset()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrVariablesAsFactor_SelectionChanged() Handles ucrVariablesAsFactorForScatter.SelectionChanged
        If Not ucrVariablesAsFactorForScatter.IsEmpty Then
            clsRaesFunction.AddParameter("y", ucrVariablesAsFactorForScatter.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("y")
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdScatterPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdScatterPlotOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_scatterplotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bUseGlobalAes:=True)
        sdgLayerOptions.ShowDialog()

        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "y" Then
                'TODO Fix this generally
                'ucrVariablesAsFactorForScatter.SetSingleReceiverStatus(True)
                ucrVariablesAsFactorForScatter.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "x" Then
                ucrReceiverX.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub

    Private Sub ucrSaveScatterPlot_GraphNameChanged() Handles ucrSaveScatterPlot.GraphNameChanged, ucrSaveScatterPlot.SaveGraphCheckedChanged
        If ucrSaveScatterPlot.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveScatterPlot.strGraphName, strTempDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveScatterPlot.strGraphName)
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorForScatter.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        End If
        TestOkEnabled()
    End Sub
End Class