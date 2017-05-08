' Instat-R
' Copyright (C) 2015
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.

' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgBarAndPieChart
    Private clsRggplotFunction As New RFunction
    Private clsRgeomPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private clsTempRFunc As New RFunction
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgBarAndPieChart_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrBarChartSelector.SetRCode(clsRggplotFunction, bReset)
        ucrSaveBar.SetRCode(clsBaseOperator, bReset)
        ucrChkFlipCoordinates.SetRCode(clsBaseOperator, bReset)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSecondReceiver.SetRCode(clsRaesFunction, bReset)
        ucrPnlOptions.SetRCode(clsRgeomPlotFunction, bReset)
    End Sub

    Private Sub SetDefaults()
        ucrBarChartSelector.Reset()
        ucrBarChartSelector.Focus()
        ucrFactorReceiver.SetMeAsReceiver()
        ucrSaveBar.Reset()
        sdgPlots.Reset()

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

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

    End Sub

    Private Sub InitialiseDialog()
        Dim clsCoordFlipFunc As New RFunction
        Dim clsCoordFlipParam As New RParameter

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 438

        ucrBarChartSelector.SetParameter(New RParameter("data", 0))
        ucrBarChartSelector.SetParameterIsrfunction()

        ucrFactorReceiver.Selector = ucrBarChartSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.SetParameter(New RParameter("x", 1))
        ucrFactorReceiver.bWithQuotes = False
        ucrFactorReceiver.SetParameterIsString()

        ucrSecondReceiver.Selector = ucrBarChartSelector
        ucrSecondReceiver.SetIncludedDataTypes({"factor"})
        ucrSecondReceiver.SetParameter(New RParameter("fill", 2))
        ucrSecondReceiver.bWithQuotes = False
        ucrSecondReceiver.SetParameterIsString()

        ucrPnlOptions.AddRadioButton(rdoBarChart)
        ucrPnlOptions.AddRadioButton(rdoPieChart)
        ucrPnlOptions.AddFunctionNamesCondition(rdoPieChart, "coord_polar")
        ucrPnlOptions.AddFunctionNamesCondition(rdoBarChart, "geom_bar")

        ucrPnlOptions.AddToLinkedControls(ucrChkFlipCoordinates, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls(ucrSecondReceiver, {rdoBarChart}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrSecondReceiver.SetLinkedDisplayControl(lblSecondFactor)

        clsCoordFlipFunc.SetPackageName("ggplot2")
        clsCoordFlipFunc.SetRCommand("coord_flip")
        clsCoordFlipParam.SetArgumentName("coord_flip")
        clsCoordFlipParam.SetArgument(clsCoordFlipFunc)
        ucrChkFlipCoordinates.SetText("Flip Coordinates")
        ucrChkFlipCoordinates.SetParameter(clsCoordFlipParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrSaveBar.SetDataFrameSelector(ucrBarChartSelector.ucrAvailableDataFrames)
        ucrSaveBar.SetPrefix("Bar")
        ucrSaveBar.SetIsComboBox()
        ucrSaveBar.SetCheckBoxText("Save Graph")
        ucrSaveBar.SetSaveTypeAsGraph()
        ucrSaveBar.SetAssignToIfUncheckedValue("last_graph")
        sdgPlots.SetRSyntax(ucrBase.clsRsyntax)
    End Sub
    Public Sub TestOKEnabled()
        If ucrFactorReceiver.IsEmpty OrElse Not ucrSaveBar.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged
        SetDailogOptions()
        'Warning: need to set second factor first, as in the pie chart case, it erases "fill" parameter (in clsRaesFunction), which is the parameter that takes the value in the first factor receiver.
    End Sub

    Private Sub SetDailogOptions()
        Dim clsBarForPieFunc As New RFunction
        Dim clsBarForPieParam As New RParameter

        If rdoBarChart.Checked = True Then
            ucrFactorReceiver.ChangeParameterName("x")
            ucrSaveBar.SetPrefix("Bar")
            clsRgeomPlotFunction.SetRCommand("geom_bar")
            cmdPieChartOptions.Visible = False
            cmdBarChartOptions.Visible = True

        ElseIf rdoPieChart.Checked = True Then
            ucrFactorReceiver.ChangeParameterName("fill")
                ucrSaveBar.SetPrefix("Pie")
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
                clsBaseOperator.AddParameter(clsBarForPieParam)
            End If

    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetDataFrame(strNewDataFrame:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        sdgPlots.ShowDialog()
        'Warning, when coordinate flip is added to coordinates tab on sdgPLots, then link with ucrChkFlipCoordinates...
    End Sub

    Private Sub cmdBarChartOptions_Click(sender As Object, e As EventArgs) Handles cmdBarChartOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeomPlotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True, bIgnoreGlobalAes:=False)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                ucrFactorReceiver.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOKEnabled()
    End Sub

    Private Sub cmdPieChartOptions_Click(sender As Object, e As EventArgs) Handles cmdPieChartOptions.Click
        sdgLayerOptions.SetupLayer(clsTempGgPlot:=clsRggplotFunction, clsTempGeomFunc:=clsRgeomPlotFunction, clsTempAesFunc:=clsRaesFunction, bFixAes:=True, bFixGeom:=True, strDataframe:=ucrBarChartSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bApplyAesGlobally:=True)
        sdgLayerOptions.ShowDialog()
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrFactorReceiver.Clear()
                Else
                    ucrFactorReceiver.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "fill" Then
                ucrSecondReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOKEnabled()
    End Sub
    Private Sub AllControlsChanged() Handles ucrSaveBar.ControlContentsChanged, ucrFactorReceiver.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class