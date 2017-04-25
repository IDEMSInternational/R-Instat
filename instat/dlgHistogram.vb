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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsBaseOperator As New ROperator
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_histogramFunction As New RFunction
    Private clsRgeom_densityFunction As New RFunction
    Private clsRgeom_FPolygon As New RFunction
    Private clsRaesFunction As New RFunction

    Private Sub dlgHistogram_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            'setdefaults
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If

        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrVariablesAsFactorforHist.SetRCode(clsRaesFunction, bReset)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSaveHist.SetRCode(clsBaseOperator, bReset)
        ucrHistogramSelector.SetRCode(clsBaseOperator, bReset)
        ucrHistogramSelector.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 435

        ucrPnlOptions.AddRadioButton(rdoDensity)
        ucrPnlOptions.AddRadioButton(rdoHistogram)
        ucrPnlOptions.AddRadioButton(rdoFreequencyPolygon)

        ucrFactorReceiver.Selector = ucrHistogramSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        'can put in colour for density and polygon but fill for Histogram
        ucrFactorReceiver.SetParameter(New RParameter("fill"))
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameterIsString()

        ucrHistogramSelector.SetParameter(New RParameter("data"))
        ucrHistogramSelector.SetParameterIsrfunction()

        ucrVariablesAsFactorforHist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforHist.Selector = ucrHistogramSelector
        ucrVariablesAsFactorforHist.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorforHist.SetParameter(New RParameter("x"))
        ucrVariablesAsFactorforHist.bWithQuotes = False
        ucrVariablesAsFactorforHist.SetParameterIsString()


        ucrSaveHist.SetPrefix("Histogram")
        ucrSaveHist.SetDataFrameSelector(ucrHistogramSelector.ucrAvailableDataFrames)
        ucrSaveHist.SetIsComboBox()
        ucrSaveHist.SetCheckBoxText("Save Graph")
        ucrSaveHist.SetSaveTypeAsGraph()
        ucrSaveHist.SetAssignToIfUncheckedValue("last_graph")
    End Sub


    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged, rdoHistogram.CheckedChanged, rdoDensity.CheckedChanged, rdoFreequencyPolygon.CheckedChanged
        If rdoHistogram.Checked = True Then
            clsRgeom_histogramFunction.SetRCommand("geom_histogram")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_histogramFunction)
            ucrFactorReceiver.ChangeParameterName("fill")

        ElseIf rdoDensity.Checked = True Then
            clsRgeom_densityFunction.SetRCommand("geom_density")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_densityFunction)
            ucrFactorReceiver.ChangeParameterName("colour")

        ElseIf rdoFreequencyPolygon.Checked = True Then
            clsRgeom_FPolygon.SetRCommand("geom_freqpoly")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_FPolygon)
            ucrFactorReceiver.ChangeParameterName("colour")
        End If

        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        'tests when ok can be enabled
        If ucrVariablesAsFactorforHist.IsEmpty OrElse Not ucrSaveHist.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If

    End Sub

    Private Sub SetDefaults()
        ucrHistogramSelector.Reset()
        ucrSaveHist.Reset()

        sdgPlots.Reset()
        TempOptionsDisabledInMultipleVariablesCase()

        clsBaseOperator = New ROperator
        clsRggplotFunction = New RFunction
        clsRgeom_histogramFunction = New RFunction
        clsRaesFunction = New RFunction

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("histogram", clsRFunctionParameter:=clsRgeom_histogramFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRgeom_histogramFunction.SetPackageName("ggplot2")
        clsRgeom_histogramFunction.SetRCommand("geom_histogram")

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

        TestOkEnabled()
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
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdHistogramOptions_Click(sender As Object, e As EventArgs) Handles cmdHistogramOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_histogramFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorforHist.bSingleVariable) Then
                ucrVariablesAsFactorforHist.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub cmdFrequencyOptions_Click(sender As Object, e As EventArgs)
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_FPolygon, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True)
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

    Private Sub cmdDensityOptions_Click(sender As Object, e As EventArgs)
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_densityFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrHistogramSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True)
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
        TempOptionsDisabledInMultipleVariablesCase()
    End Sub

    Private Sub ControlsValueChanged() Handles ucrVariablesAsFactorforHist.ControlContentsChanged, ucrSaveHist.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        'why was this done? What implications oes it have
        If ucrVariablesAsFactorforHist.bSingleVariable Then
            cmdHistogramOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdHistogramOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub

    Private Sub ChangeOptionsText() Handles rdoHistogram.CheckedChanged, rdoDensity.CheckedChanged, rdoFreequencyPolygon.CheckedChanged
        If rdoHistogram.Checked Then
            cmdHistogramOptions.Text = "Histogram Options"
            cmdHistogramOptions.Size = New Size(120, 25)
            ucrSaveHist.SetPrefix("Histogram")
        ElseIf rdoDensity.Checked Then
            cmdHistogramOptions.Text = "Density Options"
            cmdHistogramOptions.Size = New Size(120, 25)
            ucrSaveHist.SetPrefix("Density")
        ElseIf rdoFreequencyPolygon.Checked Then
            cmdHistogramOptions.Text = "Freequency Polygon Options"
            cmdHistogramOptions.Size = New Size(160, 25)
            ucrSaveHist.SetPrefix(" FrequencyPolygon")
        End If

    End Sub
End Class