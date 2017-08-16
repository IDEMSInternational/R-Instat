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
Public Class dlgCumulativeDistribution
    Private clsRggplotFunction As New RFunction
    Private clsRgeomCumDistFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bFirstLoad As Boolean = True
    Private clsLabsFunction As New RFunction
    Private clsXlabsFunction As New RFunction
    Private clsYlabFunction As New RFunction
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bReset As Boolean = True

    Private Sub dlgCumulativeDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitaliseDialog()
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

    Private Sub InitaliseDialog()
        Dim clsScaleYReverseFunc As New RFunction
        Dim clsScaleYReverseParam As New RParameter
        Dim clsGeomPointFunc As New RFunction
        Dim clsGeomPointParam As New RParameter

        ucrChkCountsOnYAxis.Enabled = False ' temporary What should this do?

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.iHelpTopicID = 453

        ucrCumDistSelector.SetParameter(New RParameter("data", 0))
        ucrCumDistSelector.SetParameterIsrfunction()

        ucrFactorReceiver.SetParameter(New RParameter("colour", 1))
        ucrFactorReceiver.Selector = ucrCumDistSelector
        ucrFactorReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorReceiver.strSelectorHeading = "Factors"
        ucrFactorReceiver.SetParameterIsString()
        ucrFactorReceiver.bWithQuotes = False

        ucrVariablesAsFactorforCumDist.SetParameter(New RParameter("x", 0))
        ucrVariablesAsFactorforCumDist.SetFactorReceiver(ucrFactorReceiver)
        ucrVariablesAsFactorforCumDist.Selector = ucrCumDistSelector
        ucrVariablesAsFactorforCumDist.SetIncludedDataTypes({"numeric"})
        ucrVariablesAsFactorforCumDist.strSelectorHeading = "Numerics"
        ucrVariablesAsFactorforCumDist.SetParameterIsString()
        ucrVariablesAsFactorforCumDist.bWithQuotes = False

        clsScaleYReverseFunc.SetPackageName("ggplot2")
        clsScaleYReverseFunc.SetRCommand("scale_y_reverse")
        clsScaleYReverseFunc.AddParameter("breaks", "seq(1,0,-0.25), labels = seq(0,1,0.25)")
        clsScaleYReverseParam.SetArgumentName("scale_y_reverse")
        clsScaleYReverseParam.SetArgument(clsScaleYReverseFunc)

        ucrChkExceedancePlots.SetText("Exceedance Plots")
        ucrChkExceedancePlots.SetParameter(clsScaleYReverseParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrChkCountsOnYAxis.SetText("Counts on Y Axis")

        clsGeomPointFunc.SetPackageName("ggplot2")
        clsGeomPointFunc.SetRCommand("geom_point")
        clsGeomPointFunc.AddParameter("stat", Chr(34) & "ecdf" & Chr(34))
        clsGeomPointParam.SetArgumentName("geom_point")
        clsGeomPointParam.SetArgument(clsGeomPointFunc)
        ucrChkIncludePoints.SetText("Include Points")
        ucrChkIncludePoints.SetParameter(clsGeomPointParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrSaveCumDist.SetPrefix("cumulative_dist")
        ucrSaveCumDist.SetSaveTypeAsGraph()
        ucrSaveCumDist.SetIsComboBox()
        ucrSaveCumDist.SetCheckBoxText("Save Graph")
        ucrSaveCumDist.SetAssignToIfUncheckedValue("last_graph")
        ucrSaveCumDist.SetDataFrameSelector(ucrCumDistSelector.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsRaesFunction = New RFunction
        clsRgeomCumDistFunction = New RFunction
        clsRggplotFunction = New RFunction

        ucrCumDistSelector.Reset()
        ucrCumDistSelector.SetGgplotFunction(clsBaseOperator)
        ucrCumDistSelector.Focus()
        ucrSaveCumDist.Reset()
        sdgPlots.Reset()
        bResetSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("stat_ecdf", clsRFunctionParameter:=clsRgeomCumDistFunction, iPosition:=1)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRgeomCumDistFunction.SetPackageName("ggplot2")
        clsRgeomCumDistFunction.SetRCommand("stat_ecdf")

        clsBaseOperator.AddParameter(GgplotDefaults.clsDefaultThemeParameter.Clone())
        clsXlabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone
        clsRFacetFunction = GgplotDefaults.clsFacetFunction.Clone()
        clsYlabFunction = GgplotDefaults.clsYlabTitleFunction.Clone
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrCumDistSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrFactorReceiver.SetRCode(clsRaesFunction, bReset)
        ucrVariablesAsFactorforCumDist.SetRCode(clsRaesFunction, bReset)
        ucrSaveCumDist.SetRCode(clsBaseOperator, bReset)
        ucrCumDistSelector.SetRCode(clsRggplotFunction, bReset)
        ucrChkExceedancePlots.SetRCode(clsBaseOperator, bReset)
        ucrChkIncludePoints.SetRCode(clsBaseOperator, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrVariablesAsFactorforCumDist.IsEmpty OrElse Not ucrSaveCumDist.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgPlots.SetRCode(clsBaseOperator, dctNewThemeFunctions:=dctThemeFunctions, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXlabsFunction, clsNewYLabTitleFunction:=clsYlabFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, ucrNewBaseSelector:=ucrCumDistSelector, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs) Handles cmdLineOptions.Click
        sdgLayerOptions.ShowDialog()
    End Sub

    Private Sub CoreControls_ControlContentsChanged() Handles ucrVariablesAsFactorforCumDist.ControlContentsChanged, ucrSaveCumDist.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class