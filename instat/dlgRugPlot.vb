' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgRugPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_RugPlotFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private bFirstLoad As Boolean = True
    Private clsBaseOperator As New ROperator
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private clsLocalRaesFunction As New RFunction
    Private bResetRugLayerSubdialog As Boolean = True


    Private Sub dlgRugPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 476
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrRugPlotSelector.SetParameter(New RParameter("data", 0))
        ucrRugPlotSelector.SetParameterIsrfunction()

        ucrVariablesAsFactorForRugPlot.SetParameter(New RParameter("y", 1))
        ucrVariablesAsFactorForRugPlot.SetParameterIsString()
        ucrVariablesAsFactorForRugPlot.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForRugPlot.Selector = ucrRugPlotSelector
        ucrVariablesAsFactorForRugPlot.SetIncludedDataTypes({"factor", "numeric"})
        ucrVariablesAsFactorForRugPlot.strSelectorHeading = "Variables"
        ucrVariablesAsFactorForRugPlot.bWithQuotes = False

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.Selector = ucrRugPlotSelector
        ucrReceiverX.SetIncludedDataTypes({"factor", "numeric"})
        ucrReceiverX.strSelectorHeading = "Variables"
        ucrReceiverX.bWithQuotes = False

        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.Selector = ucrRugPlotSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor", "numeric"})
        ucrFactorOptionalReceiver.strSelectorHeading = "Variables"
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.SetParameterIsString()

        ucrSaveGraph.SetPrefix("rugplot")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrRugPlotSelector.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsRaesFunction = New RFunction
        clsRggplotFunction = New RFunction
        clsRgeom_RugPlotFunction = New RFunction
        clsBaseOperator = New ROperator

        ucrSaveGraph.Reset()
        ucrRugPlotSelector.Reset()
        bResetSubdialog = True
        bResetRugLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("scatter", clsRFunctionParameter:=clsRgeom_RugPlotFunction)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsRgeom_RugPlotFunction.SetPackageName("ggplot2")
        clsRgeom_RugPlotFunction.SetRCommand("geom_rug")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)
        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrRugPlotSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
        ucrRugPlotSelector.SetRCode(clsRggplotFunction, bReset)

        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorForRugPlot.SetRCode(clsRaesFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ' Tests when OK is enabled
        If (Not ucrSaveGraph.IsComplete) OrElse (ucrVariablesAsFactorForRugPlot.IsEmpty AndAlso ucrReceiverX.IsEmpty()) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub AllControlsContentsChanged() Handles ucrReceiverX.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrVariablesAsFactorForRugPlot.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, ucrNewBaseSelector:=ucrRugPlotSelector, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdRugPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdRugPlotOptions.Click
        ''''''' i wonder if all this will be needed for the new system
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsRgeom_RugPlotFunction, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrRugPlotSelector, bApplyAesGlobally:=True, bReset:=bResetRugLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetRugLayerSubdialog = False
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForRugPlot.bSingleVariable) Then
                ucrVariablesAsFactorForRugPlot.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "x" Then
                ucrReceiverX.Add(clsParam.strArgumentValue)
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
    End Sub
End Class
