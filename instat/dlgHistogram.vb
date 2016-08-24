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
Public Class dlgHistogram
    Public bFirstLoad As Boolean = True
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_histogramFunction As New RFunction
    Private clsRgeom_densityFunction As New RFunction
    Private clsRgeom_FPolygon As New RFunction
    Private clsRaesFunction As New RFunction

    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            'setdefaults
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            'todo what happens when it reopens
            ReopenDialog()
        End If


        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 435
        ucrFactorReceiver.Selector = ucrHistogramSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)


        ucrVariablesAsFactorforHist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforHist.SetSelector(ucrHistogramSelector)
        ucrVariablesAsFactorforHist.SetIncludedDataType({"numeric"})

        ucrSaveHist.SetDataFrameSelector(ucrHistogramSelector.ucrAvailableDataFrames)
    End Sub
    Private Sub ucrHistogramSelector_DataFrameChanged() Handles ucrHistogramSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrHistogramSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged, rdoHistogram.CheckedChanged, rdoDensity.CheckedChanged, rdoFreequencyPolygon.CheckedChanged
        If rdoHistogram.Checked = True Then
            clsRgeom_histogramFunction.SetRCommand("geom_histogram")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_histogramFunction)
            ucrSaveHist.strPrefix = "Histogram"
            clsRaesFunction.RemoveParameterByName("colour")
            cmdHistogramOptions.Visible = True
            cmdDensityOptions.Visible = False
            cmdFrequencyOptions.Visible = False
            If Not ucrFactorReceiver.IsEmpty Then
                clsRaesFunction.AddParameter("fill", ucrFactorReceiver.GetVariableNames(False))
            Else
                clsRaesFunction.RemoveParameterByName("fill")
            End If

        ElseIf rdoDensity.Checked = True Then
            clsRgeom_densityFunction.SetRCommand("geom_density")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_densityFunction)
            ucrSaveHist.strPrefix = "Density"
            clsRaesFunction.RemoveParameterByName("fill")
            cmdHistogramOptions.Visible = False
            cmdDensityOptions.Visible = True
            cmdFrequencyOptions.Visible = False

            If Not ucrFactorReceiver.IsEmpty Then
                clsRaesFunction.AddParameter("colour", ucrFactorReceiver.GetVariableNames(False))
            Else
                clsRaesFunction.RemoveParameterByName("colour")
            End If
        ElseIf rdoFreequencyPolygon.Checked = True Then
            clsRgeom_FPolygon.SetRCommand("geom_freqpoly")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_FPolygon)
            ucrSaveHist.strPrefix = "FrequencyPolygon"
            clsRaesFunction.RemoveParameterByName("fill")
            cmdHistogramOptions.Visible = False
            cmdDensityOptions.Visible = False
            cmdFrequencyOptions.Visible = True

            If Not ucrFactorReceiver.IsEmpty Then
                clsRaesFunction.AddParameter("colour", ucrFactorReceiver.GetVariableNames(False))
            Else
                clsRaesFunction.RemoveParameterByName("colour")
            End If
        End If
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        'tests when ok can be enabled
        If ucrVariablesAsFactorforHist.IsEmpty Or (ucrSaveHist.chkSaveGraph.Checked And ucrSaveHist.ucrInputGraphName.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If

    End Sub

    Private Sub SetDefaults()
        'seting Defaults for the dialog
        clsRaesFunction.ClearParameters()
        clsRgeom_densityFunction.ClearParameters()
        clsRgeom_FPolygon.ClearParameters()
        clsRgeom_histogramFunction.ClearParameters()
        ucrHistogramSelector.Reset()
        ucrVariablesAsFactorforHist.ResetControl()
        rdoHistogram.Checked = True
        cmdHistogramOptions.Visible = True
        cmdDensityOptions.Visible = False
        cmdFrequencyOptions.Visible = False
        ucrSaveHist.strPrefix = "Histogram"
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()
        'TODO what happens on reopening

    End Sub

    Private Sub rdoHistogram_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoHistogram.KeyPress
        If e.KeyChar = vbCr Then
            rdoHistogram.Checked = True
        End If
    End Sub

    Private Sub rdoDensity_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoDensity.KeyPress
        If e.KeyChar = vbCr Then
            rdoDensity.Checked = True
        End If
    End Sub

    Private Sub rdoFreequencyPolygon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles rdoFreequencyPolygon.KeyPress
        If e.KeyChar = vbCr Then
            rdoFreequencyPolygon.Checked = True
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        sdgPlots.Reset()
        TestOkEnabled()
    End Sub

    Private Sub cmdHistogramOptions_Click(sender As Object, e As EventArgs) Handles cmdHistogramOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_histogramFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bUseGlobalAes:=True)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrVariablesAsFactorforHist.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub cmdFrequencyOptions_Click(sender As Object, e As EventArgs) Handles cmdFrequencyOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_FPolygon, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bUseGlobalAes:=True)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrVariablesAsFactorforHist.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub cmdDensityOptions_Click(sender As Object, e As EventArgs) Handles cmdDensityOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_densityFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bUseGlobalAes:=True)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrVariablesAsFactorforHist.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub ucrVariablesAsFactorforHist_SelectionChanged() Handles ucrVariablesAsFactorforHist.SelectionChanged
        If Not ucrVariablesAsFactorforHist.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrVariablesAsFactorforHist.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveHist_GraphNameChanged() Handles ucrSaveHist.GraphNameChanged, ucrSaveHist.SaveGraphCheckedChanged
        If ucrSaveHist.bSaveGraph Then
            ucrBase.clsRsyntax.SetAssignTo(ucrSaveHist.strGraphName, strTempDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=ucrSaveHist.strGraphName)
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        Else
            ucrBase.clsRsyntax.SetAssignTo("last_graph", strTempDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        End If
        TestOkEnabled()
    End Sub
End Class