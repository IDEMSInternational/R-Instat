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
Imports RDotNet

Public Class dlgPICSARainfall
    Public bFirstLoad As Boolean = True
    Private clsRggplotFunction As New RFunction
    Private clsGeomLine As New RFunction
    Private clsRaesFunction As New RFunction
    Private clsBaseOperator As New ROperator
    Private bReset As Boolean = True
    Private clsXScalecontinuousFunction As New RFunction
    Private clsYScalecontinuousFunction As New RFunction
    Private clsYScaleDateFunction As New RFunction
    Private clsRFacetFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private dctThemeFunctions As New Dictionary(Of String, RFunction)
    Private bResetSubdialog As Boolean = True
    Private bResetLineLayerSubdialog As Boolean = True
    Private clsLocalRaesFunction As New RFunction
    Private clsGeomPoint As New RFunction
    Private clsPointsFunc As New RFunction
    Private clsPointsParam As New RParameter
    Private clsYLabsFunction, clsXLabsFunction, clsLabsFunction As RFunction
    Private clsXAxisLabels, clsYAxisLabels As New RFunction
    Private clsMeanLine, clsMedianLine, clsTretile As New RFunction
    Private clsPnlBackgroundFunction, clsPnlGridLinesFunction As RFunction
    Private clsFactorLevels As New RFunction
    Private FactorLevel As RDotNet.SymbolicExpression

    Private clsDatePeriodOperator As New ROperator

    Private clsMeanFunction As New RFunction
    Private clsMedianFunction As New RFunction
    Private clsLowerTercileFunction As New RFunction
    Private clsUpperTercileFunction As New RFunction

    Private clsGeomHlineMean As New RFunction
    Private clsGeomHlineMedian As New RFunction
    Private clsGeomHlineLowerTercile As New RFunction
    Private clsGeomHlineUpperTercile As New RFunction

    Private clsGeomHlineAesMean As New RFunction
    Private clsGeomHlineAesMedian As New RFunction
    Private clsGeomHlineAesLowerTercile As New RFunction
    Private clsGeomHlineAesUpperTercile As New RFunction

    Private clsAnnotateMeanLine As New RFunction
    Private clsMeanYAnnotate As New RFunction
    Private clsRoundMeanY As New RFunction
    Private clsPasteMeanY As New RFunction
    Private clsAnnotateMedianLine As New RFunction
    Private clsMedianYAnnotate As New RFunction
    Private clsRoundMedianY As New RFunction
    Private clsPasteMedianY As New RFunction
    Private clsAnnotateLowerTercileLine As New RFunction
    Private clsLowerTercileYAnnotate As New RFunction
    Private clsRoundLowerTercileY As New RFunction
    Private clsPasteLowerTercileY As New RFunction
    Private clsAnnotateUpperTercileLine As New RFunction
    Private clsUpperTercileYAnnotate As New RFunction
    Private clsRoundUpperTercileY As New RFunction
    Private clsPasteUpperTercileY As New RFunction

    Private clsAsDate As New RFunction
    Private clsAsNumeric As New RFunction

    Private strCalcColumn As String

    Private Sub dlgPCSARainfall_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 118
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrPICSARainfallSelector.SetParameter(New RParameter("data", 0))
        ucrPICSARainfallSelector.SetParameterIsrfunction()

        ucrReceiverX.SetParameter(New RParameter("x", 0))
        ucrReceiverX.SetParameterIsString()
        ucrReceiverX.Selector = ucrPICSARainfallSelector
        ucrReceiverX.SetClimaticType("year")
        ucrReceiverX.strSelectorHeading = "Year Variables"
        ucrReceiverX.bAutoFill = True
        ucrReceiverX.bWithQuotes = False

        ucrFactorOptionalReceiver.SetParameter(New RParameter("colour", 2))
        ucrFactorOptionalReceiver.Selector = ucrPICSARainfallSelector
        ucrFactorOptionalReceiver.SetIncludedDataTypes({"factor"})
        ucrFactorOptionalReceiver.strSelectorHeading = "Factors"
        ucrFactorOptionalReceiver.bWithQuotes = False
        ucrFactorOptionalReceiver.SetParameterIsString()

        ucrVariablesAsFactorForPicsa.SetParameter(New RParameter("x", 0))
        ucrVariablesAsFactorForPicsa.SetFactorReceiver(ucrFactorOptionalReceiver)
        ucrVariablesAsFactorForPicsa.Selector = ucrPICSARainfallSelector
        ucrVariablesAsFactorForPicsa.strSelectorHeading = "Varibles"
        ucrVariablesAsFactorForPicsa.SetParameterIsString()
        ucrVariablesAsFactorForPicsa.bWithQuotes = False

        ucrChkPoints.SetText("Add Points")
        ucrChkPoints.AddParameterPresentCondition(True, "points")
        ucrChkPoints.AddParameterPresentCondition(False, "points", False)
        clsPointsFunc.SetPackageName("ggplot2")
        clsPointsFunc.SetRCommand("geom_point")
        clsPointsParam.SetArgumentName("points")
        clsPointsParam.SetArgument(clsPointsFunc)
        clsPointsFunc.AddParameter("size", "3")
        clsPointsFunc.AddParameter("colour", Chr(34) & "red" & Chr(34))
        ucrChkPoints.SetParameter(clsPointsParam, bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrSave.SetPrefix("PICSA_Rainfall_Graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save Graph")
        ucrSave.SetDataFrameSelector(ucrPICSARainfallSelector.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        Dim clsPanelBackgroundElementRect As New RFunction
        Dim clsXElementLabels As New RFunction
        Dim clsXElementTitle As New RFunction
        Dim clsYElementTitle As New RFunction
        Dim clsYElementLabels As New RFunction
        Dim clsPanelGridMajorElementLine As New RFunction
        Dim clsPanelGridMinorElementLine As New RFunction
        Dim clsPanelBorderElementRect As New RFunction
        Dim clsPlotElementTitle As New RFunction
        Dim clsPlotElementSubTitle As New RFunction
        Dim clsPlotElementCaption As New RFunction

        clsRggplotFunction = New RFunction
        clsGeomLine = New RFunction
        clsRaesFunction = New RFunction
        clsBaseOperator = New ROperator
        clsFactorLevels = New RFunction

        clsGeomHlineMean = New RFunction
        clsGeomHlineAesMean = New RFunction
        clsMeanFunction = New RFunction
        clsGeomHlineMedian = New RFunction
        clsGeomHlineAesMedian = New RFunction
        clsMedianFunction = New RFunction
        clsGeomHlineLowerTercile = New RFunction
        clsGeomHlineAesLowerTercile = New RFunction
        clsLowerTercileFunction = New RFunction
        clsGeomHlineUpperTercile = New RFunction
        clsGeomHlineAesUpperTercile = New RFunction
        clsUpperTercileFunction = New RFunction

        clsAnnotateMeanLine = New RFunction
        clsMeanYAnnotate = New RFunction
        clsRoundMeanY = New RFunction
        clsPasteMeanY = New RFunction
        clsAnnotateMedianLine = New RFunction
        clsMedianYAnnotate = New RFunction
        clsRoundMedianY = New RFunction
        clsPasteMedianY = New RFunction
        clsAnnotateLowerTercileLine = New RFunction
        clsLowerTercileYAnnotate = New RFunction
        clsRoundLowerTercileY = New RFunction
        clsPasteLowerTercileY = New RFunction
        clsAnnotateUpperTercileLine = New RFunction
        clsUpperTercileYAnnotate = New RFunction
        clsRoundUpperTercileY = New RFunction
        clsPasteUpperTercileY = New RFunction

        clsDatePeriodOperator = New ROperator

        clsAsDate = New RFunction
        clsAsNumeric = New RFunction

        clsXLabsFunction = GgplotDefaults.clsXlabTitleFunction.Clone()
        clsYLabsFunction = GgplotDefaults.clsYlabTitleFunction.Clone()
        clsLabsFunction = GgplotDefaults.clsDefaultLabs.Clone()
        clsXScalecontinuousFunction = GgplotDefaults.clsXScalecontinuousFunction.Clone()
        clsYScalecontinuousFunction = GgplotDefaults.clsYScalecontinuousFunction.Clone()
        clsYScaleDateFunction = GgplotDefaults.clsYScaleDateFunction.Clone()
        clsYScaleDateFunction.AddParameter("date_labels", Chr(34) & "%d %b" & Chr(34), iPosition:=0)

        clsThemeFunction = GgplotDefaults.clsDefaultThemeFunction
        clsLocalRaesFunction = GgplotDefaults.clsAesFunction.Clone()
        dctThemeFunctions = New Dictionary(Of String, RFunction)(GgplotDefaults.dctThemeFunctions)

        ucrPICSARainfallSelector.Reset()
        ucrPICSARainfallSelector.SetGgplotFunction(clsBaseOperator)
        ucrSave.Reset()
        ucrVariablesAsFactorForPicsa.SetMeAsReceiver()
        bResetSubdialog = True
        bResetLineLayerSubdialog = True

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggplot", clsRFunctionParameter:=clsRggplotFunction, iPosition:=0)
        clsBaseOperator.AddParameter("lineplot", clsRFunctionParameter:=clsGeomLine, iPosition:=2)

        clsRggplotFunction.SetPackageName("ggplot2")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction, iPosition:=1)

        clsRaesFunction.SetPackageName("ggplot2")
        clsRaesFunction.SetRCommand("aes")

        clsGeomLine.SetPackageName("ggplot2")
        clsGeomLine.SetRCommand("geom_line")
        clsGeomLine.AddParameter("colour", Chr(34) & "blue" & Chr(34))
        clsGeomLine.AddParameter("size", "0.8")
        clsBaseOperator.AddParameter(clsPointsParam)

        'Mean Line
        clsGeomHlineMean.SetPackageName("ggplot2")
        clsGeomHlineMean.SetRCommand("geom_hline")
        clsGeomHlineMean.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesMean, iPosition:=0)
        clsGeomHlineMean.AddParameter("size", "1.5", iPosition:=1)

        clsGeomHlineAesMean.SetPackageName("ggplot2")
        clsGeomHlineAesMean.SetRCommand("aes")
        clsGeomHlineAesMean.AddParameter("yintercept", clsRFunctionParameter:=clsMeanFunction)

        clsMeanFunction.SetRCommand("mean")
        clsMeanFunction.AddParameter("na.rm", "TRUE")

        ' Mean Line Label
        clsAnnotateMeanLine.SetPackageName("ggplot2")
        clsAnnotateMeanLine.SetRCommand("annotate")
        clsAnnotateMeanLine.AddParameter("geom", Chr(34) & "text" & Chr(34), iPosition:=0)
        clsAnnotateMeanLine.AddParameter("x", "-Inf", iPosition:=1)
        clsAnnotateMeanLine.AddParameter("y", clsRFunctionParameter:=clsMeanYAnnotate, iPosition:=2)
        clsAnnotateMeanLine.AddParameter("hjust", "0", iPosition:=9)
        clsAnnotateMeanLine.AddParameter("vjust", "-0.3", iPosition:=10)

        clsMeanYAnnotate.SetRCommand("mean")
        clsMeanYAnnotate.AddParameter("na.rm", "TRUE", iPosition:=2)
        clsMeanYAnnotate.SetAssignTo("mean_y")

        clsRoundMeanY.SetRCommand("round")
        clsRoundMeanY.AddParameter("x", clsRFunctionParameter:=clsMeanYAnnotate, iPosition:=0)

        clsPasteMeanY.SetRCommand("paste")
        clsPasteMeanY.AddParameter("1", "Mean:", bIncludeArgumentName:=False, iPosition:=0)
        clsPasteMeanY.AddParameter("2", clsRFunctionParameter:=clsRoundMeanY, bIncludeArgumentName:=False, iPosition:=1)

        'Median Line
        clsGeomHlineMedian.SetPackageName("ggplot2")
        clsGeomHlineMedian.SetRCommand("geom_hline")
        clsGeomHlineMedian.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesMedian, iPosition:=0)
        clsGeomHlineMedian.AddParameter("size", "1.5", iPosition:=1)

        clsGeomHlineAesMedian.SetPackageName("ggplot2")
        clsGeomHlineAesMedian.SetRCommand("aes")
        clsGeomHlineAesMedian.AddParameter("yintercept", clsRFunctionParameter:=clsMedianFunction)

        clsMedianFunction.SetRCommand("median")
        clsMedianFunction.AddParameter("na.rm", "TRUE")

        ' Median Line Label
        clsAnnotateMedianLine.SetPackageName("ggplot2")
        clsAnnotateMedianLine.SetRCommand("annotate")
        clsAnnotateMedianLine.AddParameter("x", "-Inf", iPosition:=1)
        clsAnnotateMedianLine.AddParameter("y", clsRFunctionParameter:=clsMedianYAnnotate, iPosition:=2)
        clsAnnotateMedianLine.AddParameter("hjust", "0", iPosition:=9)
        clsAnnotateMedianLine.AddParameter("vjust", "-0.3", iPosition:=10)

        clsMedianYAnnotate.SetRCommand("median")
        clsMedianYAnnotate.AddParameter("na.rm", "TRUE", iPosition:=1)
        clsMedianYAnnotate.SetAssignTo("median_y")

        clsRoundMedianY.SetRCommand("round")
        clsRoundMedianY.AddParameter("x", clsRFunctionParameter:=clsMedianYAnnotate, iPosition:=0)

        clsPasteMedianY.SetRCommand("paste")
        clsPasteMedianY.AddParameter("1", "Median:", bIncludeArgumentName:=False, iPosition:=0)
        clsPasteMedianY.AddParameter("2", clsRFunctionParameter:=clsRoundMedianY, bIncludeArgumentName:=False, iPosition:=1)

        'Lower Tercile Line
        clsGeomHlineLowerTercile.SetPackageName("ggplot2")
        clsGeomHlineLowerTercile.SetRCommand("geom_hline")
        clsGeomHlineLowerTercile.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesLowerTercile, iPosition:=0)
        clsGeomHlineLowerTercile.AddParameter("size", "1.5", iPosition:=1)

        clsGeomHlineAesLowerTercile.SetPackageName("ggplot2")
        clsGeomHlineAesLowerTercile.SetRCommand("aes")
        clsGeomHlineAesLowerTercile.AddParameter("yintercept", clsRFunctionParameter:=clsLowerTercileFunction)

        clsLowerTercileFunction.SetRCommand("quantile")
        clsLowerTercileFunction.AddParameter("probs", "1/3", iPosition:=1)
        clsLowerTercileFunction.AddParameter("na.rm", "TRUE", iPosition:=2)

        ' Lower Tercile Line Label
        clsAnnotateLowerTercileLine.SetPackageName("ggplot2")
        clsAnnotateLowerTercileLine.SetRCommand("annotate")
        clsAnnotateLowerTercileLine.AddParameter("x", "-Inf", iPosition:=1)
        clsAnnotateLowerTercileLine.AddParameter("y", clsRFunctionParameter:=clsLowerTercileYAnnotate, iPosition:=2)
        clsAnnotateLowerTercileLine.AddParameter("hjust", "0", iPosition:=9)
        clsAnnotateLowerTercileLine.AddParameter("vjust", "-0.3", iPosition:=10)

        clsLowerTercileYAnnotate.SetRCommand("quantile")
        clsLowerTercileYAnnotate.AddParameter("probs", "1/3", iPosition:=1)
        clsLowerTercileYAnnotate.AddParameter("na.rm", "TRUE", iPosition:=2)
        clsLowerTercileYAnnotate.SetAssignTo("lower_ter")

        clsRoundLowerTercileY.SetRCommand("round")
        clsRoundLowerTercileY.AddParameter("x", clsRFunctionParameter:=clsLowerTercileYAnnotate, iPosition:=0)

        clsPasteLowerTercileY.SetRCommand("paste")
        clsPasteLowerTercileY.AddParameter("1", "Lower Tercile:", bIncludeArgumentName:=False, iPosition:=0)
        clsPasteLowerTercileY.AddParameter("2", clsRFunctionParameter:=clsRoundLowerTercileY, bIncludeArgumentName:=False, iPosition:=1)

        'Upper Tercile Line
        clsGeomHlineUpperTercile.SetPackageName("ggplot2")
        clsGeomHlineUpperTercile.SetRCommand("geom_hline")
        clsGeomHlineUpperTercile.AddParameter("mapping", clsRFunctionParameter:=clsGeomHlineAesUpperTercile, iPosition:=0)
        clsGeomHlineUpperTercile.AddParameter("size", "1.5", iPosition:=1)

        clsGeomHlineAesUpperTercile.SetPackageName("ggplot2")
        clsGeomHlineAesUpperTercile.SetRCommand("aes")
        clsGeomHlineAesUpperTercile.AddParameter("yintercept", clsRFunctionParameter:=clsUpperTercileFunction)

        clsUpperTercileFunction.SetRCommand("quantile")
        clsUpperTercileFunction.AddParameter("probs", "2/3", iPosition:=1)
        clsUpperTercileFunction.AddParameter("na.rm", "TRUE", iPosition:=2)

        'Upper Tercile Line Label
        clsAnnotateUpperTercileLine.SetPackageName("ggplot2")
        clsAnnotateUpperTercileLine.SetRCommand("annotate")
        clsAnnotateUpperTercileLine.AddParameter("x", "-Inf", iPosition:=1)
        clsAnnotateUpperTercileLine.AddParameter("y", clsRFunctionParameter:=clsUpperTercileYAnnotate, iPosition:=2)
        clsAnnotateUpperTercileLine.AddParameter("hjust", "0", iPosition:=9)
        clsAnnotateUpperTercileLine.AddParameter("vjust", "-0.3", iPosition:=10)

        clsUpperTercileYAnnotate.SetRCommand("quantile")
        clsUpperTercileYAnnotate.AddParameter("probs", "2/3", iPosition:=1)
        clsUpperTercileYAnnotate.AddParameter("na.rm", "TRUE", iPosition:=2)
        clsUpperTercileYAnnotate.SetAssignTo("upper_q")

        clsRoundUpperTercileY.SetRCommand("round")
        clsRoundUpperTercileY.AddParameter("x", clsRFunctionParameter:=clsUpperTercileYAnnotate, iPosition:=0)

        clsPasteUpperTercileY.SetRCommand("paste")
        clsPasteUpperTercileY.AddParameter("1", "Upper Tercile:", bIncludeArgumentName:=False, iPosition:=0)
        clsPasteUpperTercileY.AddParameter("2", clsRFunctionParameter:=clsRoundUpperTercileY, bIncludeArgumentName:=False, iPosition:=1)

        If dctThemeFunctions.TryGetValue("panel.background", clsPanelBackgroundElementRect) Then
            clsPanelBackgroundElementRect.AddParameter("colour", Chr(34) & "white" & Chr(34))
            clsPanelBackgroundElementRect.AddParameter("fill", Chr(34) & "white" & Chr(34))
            clsPanelBackgroundElementRect.AddParameter("size", "0.5")
            clsPanelBackgroundElementRect.AddParameter("linetype", Chr(34) & "solid" & Chr(34))
            clsThemeFunction.AddParameter("panel.background", clsRFunctionParameter:=clsPanelBackgroundElementRect)
        End If

        If dctThemeFunctions.TryGetValue("panel.grid.major", clsPanelGridMajorElementLine) Then
            clsPanelGridMajorElementLine.AddParameter("colour", Chr(34) & "lightblue" & Chr(34))
            clsPanelGridMajorElementLine.AddParameter("linetype", Chr(34) & "longdash" & Chr(34))
            clsThemeFunction.AddParameter("panel.grid.major", clsRFunctionParameter:=clsPanelGridMajorElementLine)
        End If

        If dctThemeFunctions.TryGetValue("panel.grid.minor", clsPanelGridMinorElementLine) Then
            clsPanelGridMinorElementLine.AddParameter("colour", Chr(34) & "lightblue" & Chr(34))
            clsPanelGridMinorElementLine.AddParameter("linetype", Chr(34) & "longdash" & Chr(34))
            clsThemeFunction.AddParameter("panel.grid.minor", clsRFunctionParameter:=clsPanelGridMinorElementLine)
        End If

        If dctThemeFunctions.TryGetValue("panel.border", clsPanelBorderElementRect) Then
            clsPanelBorderElementRect.AddParameter("colour", Chr(34) & "black" & Chr(34))
            clsPanelBorderElementRect.AddParameter("fill", Chr(34) & "NA" & Chr(34))
            clsThemeFunction.AddParameter("panel.border", clsRFunctionParameter:=clsPanelBorderElementRect)
        End If

        If dctThemeFunctions.TryGetValue("axis.text.x", clsXElementLabels) Then
            clsXElementLabels.AddParameter("angle", "90")
            clsXElementLabels.AddParameter("vjust", "0.4")
            clsXElementLabels.AddParameter("size", "12")
            clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsXElementLabels)
        End If

        If dctThemeFunctions.TryGetValue("axis.title.x", clsXElementTitle) Then
            clsXElementTitle.AddParameter("size", 14)
            clsThemeFunction.AddParameter("axis.title.x", clsRFunctionParameter:=clsXElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("axis.text.y", clsYElementLabels) Then
            clsYElementLabels.AddParameter("size", "12")
            clsThemeFunction.AddParameter("axis.text.y", clsRFunctionParameter:=clsYElementLabels)
        End If

        If dctThemeFunctions.TryGetValue("axis.title.y", clsYElementTitle) Then
            clsYElementTitle.AddParameter("size", 14)
            clsThemeFunction.AddParameter("axis.title.y", clsRFunctionParameter:=clsYElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("title", clsPlotElementTitle) Then
            clsPlotElementTitle.AddParameter("size", 20)
            clsThemeFunction.AddParameter("title", clsRFunctionParameter:=clsPlotElementTitle)
        End If

        If dctThemeFunctions.TryGetValue("sub.title", clsPlotElementSubTitle) Then
            clsPlotElementSubTitle.AddParameter("size", 15)
            clsThemeFunction.AddParameter("plot.subtitle", clsRFunctionParameter:=clsPlotElementSubTitle)
        End If

        If dctThemeFunctions.TryGetValue("caption", clsPlotElementCaption) Then
            clsPlotElementCaption.AddParameter("size", 8)
            clsThemeFunction.AddParameter("plot.caption", clsRFunctionParameter:=clsPlotElementCaption)
        End If

        clsFactorLevels.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_column_factor_levels")

        clsBaseOperator.AddParameter("xlab", clsRFunctionParameter:=clsXLabsFunction)
        clsXLabsFunction.AddParameter("label", Chr(34) & Chr(34))

        clsBaseOperator.AddParameter("ylab", clsRFunctionParameter:=clsYLabsFunction)
        clsYLabsFunction.AddParameter("label", Chr(34) & Chr(34))

        clsAsDate.SetRCommand("as.Date")
        clsAsDate.AddParameter("origin", Chr(34) & "2015-12-31" & Chr(34), iPosition:=1)

        clsDatePeriodOperator.SetOperation(" ")
        clsDatePeriodOperator.bSpaceAroundOperation = False
        clsDatePeriodOperator.bToScriptAsRString = True

        clsAsNumeric.SetRCommand("as.numeric")

        clsRaesFunction.AddParameter("y", clsRFunctionParameter:=clsAsNumeric, iPosition:=1)

        clsBaseOperator.AddParameter("theme", clsRFunctionParameter:=clsThemeFunction, iPosition:=100)
        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrPICSARainfallSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        TempOptionsDisabledInMultipleVariablesCase()
        TestOkEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrVariablesAsFactorForPicsa.AddAdditionalCodeParameterPair(clsAsDate, New RParameter("x", 0), iAdditionalPairNo:=1)

        ucrPICSARainfallSelector.SetRCode(clsRggplotFunction, bReset)
        ucrReceiverX.SetRCode(clsRaesFunction, bReset)
        ucrFactorOptionalReceiver.SetRCode(clsRaesFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        ucrChkPoints.SetRCode(clsBaseOperator, bReset)
        ucrVariablesAsFactorForPicsa.SetRCode(clsAsNumeric, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (ucrVariablesAsFactorForPicsa.IsEmpty OrElse ucrReceiverX.IsEmpty) OrElse Not ucrSave.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub TempOptionsDisabledInMultipleVariablesCase()
        If ucrVariablesAsFactorForPicsa.bSingleVariable Then
            'Added this because this sub is called on sed defaults and  it over writes the enabled property 
            cmdPICSAOptions.Enabled = True
            cmdLineOptions.Enabled = True
            cmdOptions.Enabled = True
        Else
            cmdPICSAOptions.Enabled = False
            cmdLineOptions.Enabled = False
            cmdOptions.Enabled = False
        End If
    End Sub

    Private Sub ucrVariablesAsFactorForPicsa_ControlValueChanged() Handles ucrVariablesAsFactorForPicsa.ControlValueChanged
        TempOptionsDisabledInMultipleVariablesCase()
        If Not ucrVariablesAsFactorForPicsa.IsEmpty AndAlso ucrVariablesAsFactorForPicsa.bSingleVariable Then
            clsMeanYAnnotate.AddParameter("x", clsRFunctionParameter:=ucrVariablesAsFactorForPicsa.GetVariables(), iPosition:=0)
            clsMedianYAnnotate.AddParameter("x", clsRFunctionParameter:=ucrVariablesAsFactorForPicsa.GetVariables(), iPosition:=0)
            clsLowerTercileYAnnotate.AddParameter("x", clsRFunctionParameter:=ucrVariablesAsFactorForPicsa.GetVariables(), iPosition:=0)
            clsUpperTercileYAnnotate.AddParameter("x", clsRFunctionParameter:=ucrVariablesAsFactorForPicsa.GetVariables(), iPosition:=0)
        Else
            clsMeanYAnnotate.RemoveParameterByName("x")
            clsMedianYAnnotate.RemoveParameterByName("x")
            clsLowerTercileYAnnotate.RemoveParameterByName("x")
            clsUpperTercileYAnnotate.RemoveParameterByName("x")
        End If
    End Sub

    'add more functions 
    Private Sub cmdPICSAOptions_Click(sender As Object, e As EventArgs) Handles cmdPICSAOptions.Click
        sdgPICSARainfallGraph.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, dctNewThemeFunctions:=dctThemeFunctions, clsNewLabsFunction:=clsLabsFunction, clsNewThemeFunction:=clsThemeFunction, clsNewXScaleContinuousFunction:=clsXScalecontinuousFunction, clsNewYScaleContinuousFunction:=clsYScalecontinuousFunction, clsNewGeomhlineMean:=clsGeomHlineMean, clsNewGeomhlineMedian:=clsGeomHlineMedian, clsNewGeomhlineLowerTercile:=clsGeomHlineLowerTercile, clsNewGeomhlineUpperTercile:=clsGeomHlineUpperTercile, clsNewXLabsFunction:=clsXLabsFunction, clsNewYLabsFunction:=clsYLabsFunction, clsNewRaesFunction:=clsRaesFunction, clsNewAsDate:=clsAsDate, clsNewAsNumeric:=clsAsNumeric, clsNewYScaleDateFunction:=clsYScaleDateFunction, clsNewDatePeriodOperator:=clsDatePeriodOperator, bReset:=bResetSubdialog)
        sdgPICSARainfallGraph.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.SetRCode(clsNewOperator:=ucrBase.clsRsyntax.clsBaseOperator, clsNewYScalecontinuousFunction:=clsYScalecontinuousFunction, clsNewXScalecontinuousFunction:=clsXScalecontinuousFunction, clsNewXLabsTitleFunction:=clsXLabsFunction, clsNewYLabTitleFunction:=clsYLabsFunction, clsNewLabsFunction:=clsLabsFunction, clsNewFacetFunction:=clsRFacetFunction, clsNewThemeFunction:=clsThemeFunction, dctNewThemeFunctions:=dctThemeFunctions, clsNewGlobalAesFunction:=clsRaesFunction, ucrNewBaseSelector:=ucrPICSARainfallSelector, bReset:=bResetSubdialog)
        sdgPlots.ShowDialog()
        bResetSubdialog = False

        ucrVariablesAsFactorForPicsa.SetParameter(New RParameter("x"))
    End Sub

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs) Handles cmdLineOptions.Click
        sdgLayerOptions.SetupLayer(clsNewGgPlot:=clsRggplotFunction, clsNewGeomFunc:=clsGeomLine, clsNewGlobalAesFunc:=clsRaesFunction, clsNewLocalAes:=clsLocalRaesFunction, bFixGeom:=True, ucrNewBaseSelector:=ucrPICSARainfallSelector, bApplyAesGlobally:=True, bReset:=bResetLineLayerSubdialog)
        sdgLayerOptions.ShowDialog()
        bResetLineLayerSubdialog = False
        'Coming from the sdgLayerOptions, clsRaesFunction and others has been modified. One then needs to display these modifications on the dlgScatteredPlot.

        'The aesthetics parameters on the main dialog are repopulated as required.
        For Each clsParam In clsRaesFunction.clsParameters
            If clsParam.strArgumentName = "x" Then
                If clsParam.strArgumentValue = Chr(34) & Chr(34) Then
                    ucrReceiverX.Clear()
                Else
                    ucrReceiverX.Add(clsParam.strArgumentValue)
                End If
                'In the y case, the vlue stored in the clsReasFunction in the multiplevariables case is "value", however that one shouldn't be written in the multiple variables receiver (otherwise it would stack all variables and the stack ("value") itself!).
                'Warning: what if someone used the name value for one of it's variables independently from the multiple variables method ? Here if the receiver is actually in single mode, the variable "value" will still be given back, which throws the problem back to the creation of "value" in the multiple receiver case.
            ElseIf clsParam.strArgumentName = "y" AndAlso (clsParam.strArgumentValue <> "value" OrElse ucrVariablesAsFactorForPicsa.bSingleVariable) Then
                'Still might be in the case of bSingleVariable with mapping y="".
                If clsParam.strArgumentValue = (Chr(34) & Chr(34)) Then
                    ucrVariablesAsFactorForPicsa.Clear()
                Else ucrVariablesAsFactorForPicsa.Add(clsParam.strArgumentValue)
                End If
            ElseIf clsParam.strArgumentName = "colour" Then
                ucrFactorOptionalReceiver.Add(clsParam.strArgumentValue)
            End If
        Next
        TestOkEnabled()
    End Sub

    Private Sub AllControl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForPicsa.ControlContentsChanged, ucrSave.ControlContentsChanged, ucrReceiverX.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrVariablesAsFactorForPicsa_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrVariablesAsFactorForPicsa.ControlContentsChanged
        'TODO should be done automatically though linking
        strCalcColumn = ucrVariablesAsFactorForPicsa.GetVariableNames(bWithQuotes:=False)
        clsMeanFunction.AddParameter("x", strCalcColumn, iPosition:=0)
        clsMedianFunction.AddParameter("x", strCalcColumn, iPosition:=0)
        clsLowerTercileFunction.AddParameter("x", strCalcColumn, iPosition:=0)
        clsUpperTercileFunction.AddParameter("x", strCalcColumn, iPosition:=0)
    End Sub

    Private Sub ucrFactorOptionalReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFactorOptionalReceiver.ControlValueChanged
        'TODO this should run when levels of factor >1
        If Not ucrFactorOptionalReceiver.IsEmpty Then
            clsGeomLine.RemoveParameterByName("colour")
        Else
            clsGeomLine.AddParameter("colour", Chr(34) & "blue" & Chr(34))
        End If
    End Sub

    Private Sub ucrReceiverX_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverX.ControlValueChanged
        If Not ucrReceiverX.IsEmpty AndAlso ucrReceiverX.strCurrDataType.Contains("factor") Then
            clsGeomLine.AddParameter("group", 1)
        Else
            clsGeomLine.RemoveParameterByName("group")
        End If
    End Sub
End Class