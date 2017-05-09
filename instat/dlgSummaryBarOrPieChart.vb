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
Public Class dlgSummaryBarOrPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True

    Private Sub cmdOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
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
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrYReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSecondFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSaveSummaryBar.SetRCode(clsBaseOperator, bReset)
        ucrSummarybarSelector.SetRCode(clsRggplotFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (ucrYReceiver.IsEmpty AndAlso ucrFactorReceiver.IsEmpty) OrElse Not ucrSaveSummaryBar.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub AllControls_ContenctsChanged() Handles ucrYReceiver.ControlContentsChanged, ucrFactorReceiver.ControlContentsChanged, ucrSaveSummaryBar.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 439

        ucrSummarybarSelector.SetParameter(New RParameter("data", 0))
        ucrSummarybarSelector.SetParameterIsrfunction()

        ucrYReceiver.Selector = ucrSummarybarSelector
        ucrYReceiver.SetIncludedDataTypes({"numeric"})
        ucrYReceiver.bWithQuotes = False
        ucrYReceiver.SetParameter(New RParameter("y", 1))
        ucrYReceiver.SetParameterIsString()

        ucrFactorReceiver.Selector = ucrSummarybarSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameter(New RParameter("x", 0))
        ucrFactorReceiver.SetParameterIsString()

        ucrSecondFactorReceiver.Selector = ucrSummarybarSelector
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondFactorReceiver.bWithQuotes = False
        ucrSecondFactorReceiver.SetParameter(New RParameter("fill", 2))
        ucrSecondFactorReceiver.SetParameterIsString()

        ucrPnlOptions.AddToLinkedControls(ucrSecondFactorReceiver, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrSecondFactorReceiver.SetLinkedDisplayControl(lblSecondFactor)

        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
        ucrSaveSummaryBar.SetIsComboBox()
        ucrSaveSummaryBar.SetCheckBoxText("Save Graph")
        ucrSaveSummaryBar.SetDataFrameSelector(ucrSummarybarSelector.ucrAvailableDataFrames)
        ucrSaveSummaryBar.SetSaveTypeAsGraph()
        ucrSaveSummaryBar.SetPrefix("Bar")
        ucrSaveSummaryBar.SetAssignToIfUncheckedValue("last_graph")

    End Sub

    Private Sub SetDefaults()
        clsRaesFunction.ClearParameters()
        clsRgeomPlotFunction.ClearParameters()
        ucrSummarybarSelector.Reset()
        ucrYReceiver.SetMeAsReceiver()
        cmdBarChartOptions.Visible = False
        cmdPieChartOptions.Visible = False
        ucrSaveSummaryBar.Reset()

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("barchart", clsRFunctionParameter:=clsRgeomPlotFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRgeomPlotFunction.SetPackageName("ggplot2")
        clsRgeomPlotFunction.SetRCommand("geom_bar")

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSummarybarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub
    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged

        SummaryCheck()
        Dim clsBarForPieFunc As New RFunction
        Dim clsBarForPieParam As New RParameter

        If rdoBarChart.Checked = True Then
            ucrSaveSummaryBar.SetPrefix("Bar")
            clsRgeomPlotFunction.SetRCommand("geom_bar")
            cmdPieChartOptions.Visible = False
            cmdBarChartOptions.Visible = True
        ElseIf rdoPieChart.Checked = True Then
            ucrSaveSummaryBar.SetPrefix("Pie")
            cmdPieChartOptions.Visible = True
            cmdBarChartOptions.Visible = False
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
            clsRgeomPlotFunction.SetRCommand("coord_polar")
            clsRgeomPlotFunction.AddParameter("theta", Chr(34) & "y" & Chr(34))

            clsBarForPieParam.SetArgument(clsBarForPieFunc)
            clsBarForPieFunc.SetPackageName("ggplot2")
            clsBarForPieParam.SetArgumentName("geom_bar")
            clsBarForPieFunc.SetRCommand("geom_bar")
            clsBarForPieFunc.AddParameter("width", "1")
            clsRgeomPlotFunction.AddParameter("stat", Chr(34) & "identity" & Chr(34))
            clsBaseOperator.AddParameter(clsBarForPieParam)
        End If
    End Sub

    Private Sub SummaryCheck()
        If rdoBarChart.Checked = True Then
            If ucrFactorReceiver.IsEmpty Then
                ucrSecondFactorReceiver.ChangeParameterName("fill")
            End If

        ElseIf rdoPieChart.Checked = True Then
            If ucrFactorReceiver.IsEmpty Then
                ucrFactorReceiver.ChangeParameterName("x")
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        sdgPlots.Reset()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrSummarybarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeomPlotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSummarybarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "y" Then
                ucrYReceiver.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub cmdPieChartOptions_Click(sender As Object, e As EventArgs) Handles cmdPieChartOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeomPlotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSummarybarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "y" Then
                ucrYReceiver.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub
End Class