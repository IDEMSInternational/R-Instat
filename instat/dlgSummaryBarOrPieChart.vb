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
    Private clsRgeom_summarybar As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True

    Private Sub cmdOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If (ucrYReceiver.IsEmpty AndAlso ucrFactorReceiver.IsEmpty) OrElse Not ucrSaveSummaryBar.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 439

        ucrSummarybarSelector.SetParameter(New RParameter("data"), 0)
        ucrSummarybarSelector.SetParameterIsrfunction()

        ucrYReceiver.Selector = ucrSummarybarSelector
        ucrYReceiver.SetIncludedDataTypes({"numeric"})
        ucrYReceiver.bWithQuotes = False
        ucrYReceiver.SetParameter(New RParameter("y"))
        ucrYReceiver.SetParameterIsString()

        ucrFactorReceiver.Selector = ucrSummarybarSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameter(New RParameter(""))
        ucrFactorReceiver.SetParameterIsString()

        ucrSecondFactorReceiver.Selector = ucrSummarybarSelector
        ucrSecondFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondFactorReceiver.bWithQuotes = False
        ucrSecondFactorReceiver.SetParameter(New RParameter("fill"))
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
        clsRgeom_summarybar.ClearParameters()
        ucrSummarybarSelector.Reset()
        ucrSummarybarSelector.Focus()
        ucrYReceiver.SetMeAsReceiver()
        cmdBarChartOptions.Visible = False
        cmdPieChartOptions.Visible = False
        ucrSaveSummaryBar.Reset()
        TestOkEnabled()

        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        clsRgeom_summarybar.SetRCommand("geom_bar")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_summarybar)
    End Sub
    Private Sub grpChartOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoBarChart.CheckedChanged, rdoPieChart.CheckedChanged

        SummaryCheck()
        Dim clsTempRFunc As New RFunction
        If rdoBarChart.Checked = True Then
            cmdBarChartOptions.Visible = True
            cmdPieChartOptions.Visible = False
            clsRgeom_summarybar.AddParameter("stat", Chr(34) & "identity" & Chr(34))
            ucrBase.clsRsyntax.RemoveOperatorParameter("polar")
            clsRgeom_summarybar.RemoveParameterByName("width")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_summarybar)

        ElseIf rdoPieChart.Checked = True Then
            cmdPieChartOptions.Visible = True
            cmdBarChartOptions.Visible = False
            clsRaesFunction.AddParameter("x", Chr(34) & Chr(34))
            ucrSecondFactorReceiver.SetMeAsReceiver()

            clsRgeom_summarybar.AddParameter("width", 1)
            clsRgeom_summarybar.AddParameter("stat", Chr(34) & "identity" & Chr(34))
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_summarybar)

            clsTempRFunc.SetRCommand("coord_polar")
            clsTempRFunc.AddParameter("theta", Chr(34) & "y" & Chr(34))
            ucrBase.clsRsyntax.AddOperatorParameter("polar", clsRFunc:=clsTempRFunc)
        End If
        TestOkEnabled()
    End Sub


    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged
        SummaryCheck()
        TestOkEnabled()
    End Sub

    Private Sub SummaryCheck()
        If rdoBarChart.Checked = True Then
            If ucrFactorReceiver.IsEmpty Then
                clsRaesFunction.RemoveParameterByName("x")
            Else
                clsRaesFunction.AddParameter("x", ucrFactorReceiver.GetVariableNames(False))
            End If

        ElseIf rdoPieChart.Checked = True Then
            If ucrFactorReceiver.IsEmpty Then
                clsRaesFunction.RemoveParameterByName("fill")
            Else
                clsRaesFunction.AddParameter("fill", ucrSecondFactorReceiver.GetVariableNames(False))
            End If
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSummarybarSelector_DataFrameChanged() Handles ucrSummarybarSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrSummarybarSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        sdgPlots.Reset()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrSummarybarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_summarybar, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSummarybarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
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
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeom_summarybar, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrSummarybarSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True)
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

    Private Sub ucrSaveSummaryBar_ContentsChanged()
        TestOkEnabled()
    End Sub
End Class