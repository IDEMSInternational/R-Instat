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

Public Class dlgModelling
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsAttach, clsDetach As New RFunction
    Private strPackageName As String
    Public clsRModelFunction As New RFunction
    Public clsRYVariable, clsRXVariable As String
    Private ucrAvailableDataframe As ucrDataFrame
    'Public clsRAovFunction, clsRAovPValFunction, clsREstPValFunction, clsRgeom_point, clsRPredFunction, clsRDFFunction, clsRFittedValues, clsRWriteFitted, clsRResiduals, clsRWriteResiduals, clsRStdResiduals, clsRWriteStdResiduals, clsRLeverage, clsRWriteLeverage As New RFunction
    Public clsVisReg, clsRaesFunction, clsRStat_smooth, clsR_ribbon, clsRaes_ribbon As New RFunction
    Public clsWhichFunction As New RFunction
    Public bUpdating As Boolean = False

    'Display tab functions
    Public clsFormulaFunction, clsAnovaFunction, clsSummaryFunction, clsConfint As New RFunction
    Private clsFittedValuesFunction, clsBayesglmFunction, clsResidualFunction, clsRstandardFunction, clsHatvaluesFunction, clsArmAddParametersFunction, clsStanGlmFunction,
    clsStanPolrFunction As New RFunction

    Private bResetDisplayOptions = False
    Private dctPlotFunctions As New Dictionary(Of String, RFunction)

    Private Sub dlgModelling_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
        SetRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        bUpdating = True
        cmdPredict.Visible = False

        ucrReceiverForTestColumn.Selector = ucrSelectorModelling

        ucrChkIncludeArguments.SetText("Include Arguments")

        ucrSaveResult.SetPrefix("model")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Save Model")
        ucrSaveResult.SetAssignToIfUncheckedValue("last_model")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorModelling.ucrAvailableDataFrames)

        ucrTryModelling.SetReceiver(ucrReceiverForTestColumn)
        ucrTryModelling.SetIsModel()

        ucrInputComboRPackage.SetItems({"stats", "extRemes", "lme4", "MASS", "arm", "rstanarm"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()

        bUpdating = False
    End Sub

    Private Sub SetDefaults()
        clsAttach = New RFunction
        clsDetach = New RFunction
        clsFormulaFunction = New RFunction
        clsRModelFunction = New RFunction
        clsConfint = New RFunction
        clsSummaryFunction = New RFunction
        clsAnovaFunction = New RFunction
        clsVisReg = New RFunction
        clsRstandardFunction = New RFunction
        clsHatvaluesFunction = New RFunction
        clsResidualFunction = New RFunction
        clsFittedValuesFunction = New RFunction
        clsArmAddParametersFunction = New RFunction
        clsBayesglmFunction = New RFunction
        clsStanGlmFunction = New RFunction
        clsStanPolrFunction = New RFunction

        '---------------------------------------------------------
        'todo. what was the purpose of these RFunctions? delete?
        'clsRAovFunction = New RFunction
        'clsRAovPValFunction = New RFunction
        'clsREstPValFunction = New RFunction
        'clsRFittedValues = New RFunction
        'clsRResiduals = New RFunction
        'clsRStdResiduals = New RFunction

        'clsRWriteResiduals = New RFunction
        'clsRWriteLeverage = New RFunction
        'clsRLeverage = New RFunction
        'clsRWriteStdResiduals = New RFunction
        'clsRWriteFitted = New RFunction
        ' clsRgeom_point = New RFunction
        '---------------------------------------------------------

        ucrBase.clsRsyntax.ClearCodes()

        bUpdating = True

        clsAttach.SetRCommand("attach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorModelling.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorModelling.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsDetach.AddParameter("unload", "TRUE", iPosition:=1)

        ucrBase.clsRsyntax.SetCommandString("")
        ucrBase.clsRsyntax.clsBaseCommandString.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorModelling.strCurrentDataFrame)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        'Residual Plots
        dctPlotFunctions = New Dictionary(Of String, RFunction)(clsRegressionDefaults.dctModelPlotFunctions)

        'FitModel
        clsVisReg.SetPackageName("visreg")
        clsVisReg.SetRCommand("visreg")
        clsVisReg.AddParameter("type", Chr(34) & "conditional" & Chr(34))
        clsVisReg.AddParameter("gg", "TRUE")
        clsVisReg.bExcludeAssignedFunctionOutput = False

        'Model
        clsFormulaFunction = clsRegressionDefaults.clsDefaultFormulaFunction.Clone
        clsFormulaFunction.bExcludeAssignedFunctionOutput = False

        'Bayesian
        clsBayesglmFunction.SetPackageName("arm")
        clsBayesglmFunction.SetRCommand("bayesglm")
        clsBayesglmFunction.iCallType = 2

        clsArmAddParametersFunction.SetPackageName("arm")
        clsArmAddParametersFunction.SetRCommand("bayespolr")
        clsArmAddParametersFunction.iCallType = 2

        clsStanGlmFunction.SetPackageName("rstanarm")
        clsStanGlmFunction.SetRCommand("StanGlm")
        clsStanGlmFunction.iCallType = 2

        clsStanPolrFunction.SetPackageName("rstanarm")
        clsStanPolrFunction.SetRCommand("StanPolr")
        clsStanPolrFunction.iCallType = 2

        'Summary
        clsSummaryFunction = clsRegressionDefaults.clsDefaultSummary.Clone
        clsSummaryFunction.bExcludeAssignedFunctionOutput = False

        'ANOVA
        clsAnovaFunction = clsRegressionDefaults.clsDefaultAnovaFunction.Clone
        clsAnovaFunction.bExcludeAssignedFunctionOutput = False

        'Confidence Interval
        clsConfint = clsRegressionDefaults.clsDefaultConfint.Clone
        clsConfint.bExcludeAssignedFunctionOutput = False

        '--------------------------------------------------------------------
        'todo. what was the purpose of these RFunctions? Delete
        'clsRgeom_point = clsRegressionDefaults.clsDefaultRgeom_pointFunction.Clone

        'clsRAovFunction.SetPackageName("stats")
        'clsRAovFunction.SetRCommand("anova")
        'clsRAovFunction.iCallType = 2

        'Anova +Pvalue
        'clsREstPValFunction = clsRegressionDefaults.clsDefaultRaovPValueFunction.Clone
        'clsRaovpvalFunction.AddParameter("", clsRFunctionParameter:=clsRLmOrGLM)
        'clsREstPValFunction.iCallType = 2

        'todo. where is it used?
        'ucrSave (sdgSimpleRegOptions) Fitted Values
        'clsRWriteFitted = clsRegressionDefaults.clsDefaultAddColumnsToData.Clone
        'clsRWriteFitted.SetAssignTo(sdgSimpleRegOptions.ucrSaveFittedColumnName.GetText, strTempDataframe:=ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=sdgSimpleRegOptions.ucrSaveFittedColumnName.GetText, bAssignToIsPrefix:=True)
        'clsRWriteFitted.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) Residuals
        'clsRWriteResiduals = clsRegressionDefaults.clsDefaultAddColumnsToData.Clone
        'clsRWriteResiduals.SetAssignTo(sdgSimpleRegOptions.ucrSaveResidualsColumnName.GetText, strTempDataframe:=ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=sdgSimpleRegOptions.ucrSaveResidualsColumnName.GetText, bAssignToIsPrefix:=True)
        'clsRWriteResiduals.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) StdResiduals
        'clsRWriteStdResiduals = clsRegressionDefaults.clsDefaultAddColumnsToData.Clone
        'clsRWriteStdResiduals.SetAssignTo(sdgSimpleRegOptions.ucrSaveStdResidualsColumnName.GetText, strTempDataframe:=ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=sdgSimpleRegOptions.ucrSaveStdResidualsColumnName.GetText, bAssignToIsPrefix:=True)
        'clsRWriteStdResiduals.iCallType = 3

        'ucrSave (sdgSimpleRegOptions) Leverage
        'clsRWriteLeverage = clsRegressionDefaults.clsDefaultAddColumnsToData.Clone
        'clsRWriteLeverage.SetAssignTo(sdgSimpleRegOptions.ucrSaveLeverageColumnName.GetText, strTempDataframe:=ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=sdgSimpleRegOptions.ucrSaveLeverageColumnName.GetText, bAssignToIsPrefix:=True)
        'clsRWriteLeverage.iCallType = 3

        '--------------------------------------------------------------------

        clsResidualFunction.SetRCommand("residuals")
        clsFittedValuesFunction.SetRCommand("fitted.values")
        clsRstandardFunction.SetRCommand("rstandard")
        clsHatvaluesFunction.SetRCommand("hatvalues")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach, 1000)
        ucrBase.clsRsyntax.AddToAfterCodes(clsSummaryFunction, 2)

        ucrSelectorModelling.Reset()
        ucrChkIncludeArguments.Checked = False
        ucrInputComboRPackage.SetName("stats")
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lm(, na.action = na.exclude)", 25)
        ucrSaveResult.Reset()
        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)
        bResetDisplayOptions = True
        bUpdating = False
    End Sub

    Private Sub assignToControlsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlValueChanged

        Dim strAssginTo As String
        If ucrBase.clsRsyntax.bUseBaseFunction Then
            strAssginTo = ucrBase.clsRsyntax.clsBaseFunction.GetRObjectToAssignTo()
        ElseIf ucrBase.clsRsyntax.bUseBaseOperator Then
            strAssginTo = ucrBase.clsRsyntax.clsBaseOperator.GetRObjectToAssignTo()
        ElseIf ucrBase.clsRsyntax.bUseCommandString Then
            strAssginTo = ucrBase.clsRsyntax.clsBaseCommandString.GetRObjectToAssignTo()
        Else
            strAssginTo = ""
        End If


        '---------------------------------------------------------------------
        'model summaries outputs

        'stats output formula for the model
        clsFormulaFunction.AddParameter("x", strParameterValue:=strAssginTo, iPosition:=0)
        clsFormulaFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        'anova output summary for the model
        clsAnovaFunction.AddParameter("object", strParameterValue:=strAssginTo, iPosition:=0)
        clsAnovaFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        'estimates output for the model
        clsSummaryFunction.AddParameter("object", strParameterValue:=strAssginTo, iPosition:=0)
        clsSummaryFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")


        'confidence output limits for the model
        clsConfint.AddParameter("object", strParameterValue:=strAssginTo, iPosition:=0)
        clsConfint.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                           strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                           strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                           strRDataFrameNameToAddObjectTo:=ucrSelectorModelling.strCurrentDataFrame,
                                           strObjectName:="last_summary")

        '---------------------------------------------------------------------
        'column outputs
        'note set assign has not been set here because it's done at the sub dialog level
        'through individual save controls linked to this dialog data frame selector

        clsResidualFunction.AddParameter("object", strParameterValue:=strAssginTo, iPosition:=0)
        clsFittedValuesFunction.AddParameter("object", strParameterValue:=strAssginTo, iPosition:=0)
        clsRstandardFunction.AddParameter("model", strParameterValue:=strAssginTo, iPosition:=0)
        clsHatvaluesFunction.AddParameter("model", strParameterValue:=strAssginTo, iPosition:=0)

        '---------------------------------------------------------------------
        'graphical outputs

        'model plot output
        clsVisReg.AddParameter("fit", strParameterValue:=strAssginTo, iPosition:=0)
        clsVisReg.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                  strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                  strRDataFrameNameToAddObjectTo:=ucrSelectorModelling.strCurrentDataFrame,
                                  strObjectName:="last_graph")

        'residual plots outputs
        For Each kvp As KeyValuePair(Of String, RFunction) In dctPlotFunctions
            kvp.Value.AddParameter("x", strParameterValue:=strAssginTo, iPosition:=0)
            kvp.Value.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
                                        strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
                                        strRObjectFormatToAssignTo:=RObjectFormat.Image,
                                        strRDataFrameNameToAddObjectTo:=ucrSelectorModelling.strCurrentDataFrame,
                                        strObjectName:="last_graph")
        Next

    End Sub

    Private Sub TestOkEnabled()
        If ucrSaveResult.IsComplete AndAlso Not ucrReceiverForTestColumn.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdaov_Click(sender As Object, e As EventArgs) Handles cmdaov.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("aov(formula = , data = NULL, projections = FALSE, qr = TRUE, contrasts = NULL)", 65)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("aov()", 1)
        End If
    End Sub

    Private Sub cmdar_Click(sender As Object, e As EventArgs) Handles cmdar.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then

            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ar(x = , aic = TRUE, order.max = NULL, method = c(""yule-walker"", ""burg"", ""ols"", ""mle"", ""yw""), na.action, series)", 106)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ar()", 1)
        End If
    End Sub

    Private Sub cmdarima_Click(sender As Object, e As EventArgs) Handles cmdarima.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arima(x = , order = c(0L, 0L, 0L), seasonal = list(order = c(0L, 0L, 0L), period = NA), xreg = NULL, include.mean = TRUE, transform.pars = TRUE, fixed = NULL, init = NULL, method = c(""CSS-ML"", ""ML"", ""CSS""), n.cond,SSinit = c(""Gardner1980"", ""Rossignol2011""), optim.method = ""BFGS"", optim.control = list(), kappa = 1e6)", 308)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arima()", 1)
        End If
    End Sub

    Private Sub cmdglm_Click(sender As Object, e As EventArgs) Handles cmdglm.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm(formula = , family = gaussian, data, weights, subset, na.action = na.exclude, start = NULL, etastart, mustart, offset, control = list(...), model = TRUE, method = ""glm.fit"" ,x = FALSE, y = TRUE, contrasts = NULL)", 188)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm(, na.action = na.exclude)", 25)
        End If
    End Sub

    Private Sub cmdlm_Click(sender As Object, e As EventArgs) Handles cmdlm.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lm(formula = , data, subset, weights, na.action = na.exclude, method = ""qr"", model = TRUE, x = FALSE, y = FALSE, qr = TRUE, singular.ok = TRUE, contrasts = NULL, offset)", 143)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lm(, na.action = na.exclude)", 25)
        End If
    End Sub

    Private Sub cmdloess_Click(sender As Object, e As EventArgs) Handles cmdloess.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loess(formula = , data, weights, subset, na.action, model = FALSE,span = 0.75, enp.target, degree = 2,parametric = FALSE, drop.square = FALSE, normalize = TRUE,family = c(""gaussian"", ""symmetric""),method = c(""loess"", ""model.frame""), control = loess.control(...))", 246)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loess()", 1)
        End If
    End Sub

    Private Sub cmdlowess_Click(sender As Object, e As EventArgs) Handles cmdlowess.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lowess(x = , y = NULL, f = 2/3, iter = 3, delta = 0.01 * diff(range(x)))", 61)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lowess()", 1)
        End If
    End Sub

    Private Sub cmdloglin_Click(sender As Object, e As EventArgs) Handles cmdloglin.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglin(table = , margin, start = rep(1, length(table)), fit = FALSE, eps = 0.1, iter = 20, param = FALSE, print = TRUE)", 104)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglin()", 1)
        End If
    End Sub

    Private Sub cmdnls_Click(sender As Object, e As EventArgs) Handles cmdnls.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("nls(formula = , data, start, control, algorithm, trace, subset, weights, na.action, model, lower, upper, ...)", 97)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("nls()", 1)
        End If
    End Sub

    Private Sub cmdppr_Click(sender As Object, e As EventArgs) Handles cmdppr.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ppr(formula =, data, weights, subset, na.action, contrasts = NULL, ..., model=FALSE)", 77)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ppr()", 1)
        End If
    End Sub

    Private Sub cmdprincomp_Click(sender As Object, e As EventArgs) Handles cmdprincomp.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("princomp(formula =, data=NULL, subset, na.action, ...)", 52)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("princomp()", 1)
        End If
    End Sub

    Private Sub cmdspline_Click(sender As Object, e As EventArgs) Handles cmdspline.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("spline(x = , y = NULL, n = 3*length(x), method = ""fmm"",xmin = min(x), xmax = max(x), xout, ties = mean)", 92)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("spline()", 1)
        End If
    End Sub
    Private Sub cmdfevd_Click(sender As Object, e As EventArgs) Handles cmdfevd.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::fevd(x = , data, threshold = NULL, threshold.fun = ~1, location.fun = ~1, scale.fun = ~1, shape.fun = ~1, use.phi = FALSE, type = c(""GEV"", ""GP"", ""PP"", ""Gumbel"", ""Exponential""), method = c(""MLE"", ""GMLE"", ""Bayesian"", ""Lmoments""), initial = NULL, span, units = NULL, time.units = ""days"", period.basis = ""year"", na.action = na.fail, optim.args = NULL, priorFun = NULL, priorParams = NULL, proposalFun = NULL, proposalParams = NULL, iter = 9999, weights = 1, blocks = NULL, verbose = FALSE)", 476)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::fevd()", 1)
        End If
    End Sub

    Private Sub cmdlevd_Click(sender As Object, e As EventArgs) Handles cmdlevd.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::levd(x = , threshold, location, scale, shape, type = c(""GEV"", ""GP"", ""PP"", ""Gumbel"", ""Weibull"", ""Frechet"",""Exponential"", ""Beta"", ""Pareto""), log = TRUE, negative = TRUE, span, npy = 365.25, infval = Inf, weights = 1, blocks = NULL)", 220)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::levd()", 1)
        End If
    End Sub

    Private Sub cmdglmer_Click(sender As Object, e As EventArgs) Handles cmdglmer.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lme4::glmer(formula = , data = NULL, family = gaussian, control = glmerControl(), start = NULL, verbose = 0L, nAGQ = 1L, subset, weights, na.action, offset, contrasts = NULL, mustart, etastart, devFunOnly = FALSE)", 192)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lme4::glmer()", 1)
        End If
    End Sub

    Private Sub cmdlmer_Click(sender As Object, e As EventArgs) Handles cmdlmer.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lme4::lmer(formula = , data = NULL, REML = TRUE, control = lmerControl(), start = NULL, verbose = 0L, subset, weights, na.action, offset, contrasts = NULL, devFunOnly = FALSE)", 154)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lme4::lmer()", 1)
        End If
    End Sub

    Private Sub cmdnlmer_Click(sender As Object, e As EventArgs) Handles cmdnlmer.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lme4::nlmer(formula = , data = NULL, control = nlmerControl(), start = NULL, verbose = 0L, nAGQ = 1L, subset, weights, na.action, offset, contrasts = NULL, devFunOnly = FALSE)", 153)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lme4::nlmer()", 1)
        End If
    End Sub

    Private Sub cmdglmmPQL_Click(sender As Object, e As EventArgs) Handles cmdglmmPQL.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::glmmPQL(fixed = , random, family, data, correlation, weights,control, niter = 10, verbose = TRUE)", 82)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::glmmPQL()", 1)
        End If
    End Sub

    Private Sub cmdglmnb_Click(sender As Object, e As EventArgs) Handles cmdglmnb.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::glm.nb(formula = , data, weights, subset, na.action,start = NULL, etastart, mustart,control = glm.control(...), method = ""glm.fit"",model = TRUE, x = FALSE, y = TRUE, contrasts = NULL, ...,init.theta, link = log)", 194)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::glm.nb()", 1)
        End If
    End Sub

    Private Sub cmdloglm_Click(sender As Object, e As EventArgs) Handles cmdloglm.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::loglm(formula = , data, subset, na.action)", 27)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::loglm()", 1)
        End If
    End Sub

    Private Sub cmdpolr_Click(sender As Object, e As EventArgs) Handles cmdpolr.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::polr(formula = , data, weights, start, ..., subset, na.action, contrasts = NULL, Hess = FALSE, model = TRUE, method = c(""logistic"", ""probit"", ""loglog"", ""cloglog"", ""cauchit""))", 158)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::polr()", 1)
        End If
    End Sub

    Private Sub cmdTilda_Click(sender As Object, e As EventArgs) Handles cmdTilda.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("~")
    End Sub

    Private Sub cmdrlm_Click(sender As Object, e As EventArgs) Handles cmdrlm.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::rlm(formula = , data, weights, ..., subset, na.action, method = c(""M"", ""MM"", ""model.frame""), wt.method = c(""inv.var"", ""case""), model = TRUE, x.ret = TRUE, y.ret = FALSE, contrasts = NULL)", 173)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::rlm()", 1)
        End If
    End Sub

    Private Sub cmdbayesglm_Click(sender As Object, e As EventArgs) Handles cmdbayesglm.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arm::bayesglm(formula =, family = gaussian, data=" &
            ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text & ",weights=, subset=, na.action=,start = NULL, " &
            " etastart=, mustart= ,offset=, control = list(...), model = TRUE, method = glm.fit, x = FALSE, y = TRUE, " &
            " contrasts = NULL,drop.unused.levels = TRUE,prior.mean = 0,prior.scale = NULL,prior.df = 1, prior.mean.for.intercept = 0, " &
            "prior.scale.for.intercept = NULL,prior.df.for.intercept = 1,min.prior.scale=1e-12,scaled = TRUE, keep.order=TRUE, " &
            "drop.baseline=TRUE,maxit=100, print.unnormalized.log.posterior=FALSE,Warning=TRUE)", 494)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arm::bayesglm()", 1)
        End If
    End Sub

    Private Sub cmdbayespolr_Click(sender As Object, e As EventArgs) Handles cmdbayespolr.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arm::bayespolr(formula= , data=" &
            ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text &
            ", weights=, start=, subset=, na.action=, contrasts = NULL, Hess = TRUE, model = TRUE," &
            "method = c(logistic, probit,cloglog,cauchit),drop.unused.levels=TRUE,prior.mean = 0, " &
            "prior.scale = 2.5,prior.df = 1,prior.counts.for.bins = NULL,min.prior.scale=1e-12, scaled = TRUE, " &
            "maxit = 100,print.unnormalized.log.posterior = FALSE)", 329)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arm::bayespolr()", 1)
        End If
    End Sub

    Private Sub cmdstanglm_Click(sender As Object, e As EventArgs) Handles cmdstanglm.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("rstanarm::stan_glm(formula= ,family= gaussian, data=" &
            ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text & ", weights=, subset= ,na.action = NULL," &
            " offset = NULL,model = TRUE, x = FALSE, y = TRUE,contrasts = NULL,prior = default_prior_coef(family), " &
            "prior_intercept = default_prior_intercept(family),prior_aux = exponential(autoscale = TRUE), prior_PD = FALSE, " &
            "algorithm = c(sampling, optimizing, meanfield, fullrank),mean_PPD = algorithm != optimizing && !prior_PD,adapt_delta = NULL, " &
            "QR = FALSE,sparse = FALSE)", 426)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("rstanarm::stan_glm()", 1)
        End If
    End Sub

    Private Sub cmdstanpolr_Click(sender As Object, e As EventArgs) Handles cmdstanpolr.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("rstanarm::stan_polr(formula=, data=" &
            ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.Text & ", weights= ,subset= , " &
            "na.action = getOption(na.action, na.omit), contrasts = NULL,model = TRUE, method = c(logistic, probit, loglog, cloglog, cauchit), " &
            " prior = R2,prior_counts = dirichlet(1),shape = NULL,rate = NULL, prior_PD = FALSE,algorithm = c(sampling, meanfield, fullrank), " &
            "adapt_delta = NULL,do_residuals = NULL)", 327)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("rstanarm::stan_polr()", 1)
        End If
    End Sub

    Private Sub cmdlda_Click(sender As Object, e As EventArgs) Handles cmdlda.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::lda(formula = , data, ..., subset, na.action)", 48)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::lda()", 1)
        End If
    End Sub

    Private Sub cmdmca_Click(sender As Object, e As EventArgs) Handles cmdmca.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::mca(df, nf = 2, abbrev = FALSE)", 34)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::mca()", 1)
        End If
    End Sub

    Private Sub cmdlqs_Click(sender As Object, e As EventArgs) Handles cmdlqs.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::lqs(formula = , data, method = c(""lts"", ""lqs"",""lms"",""S"",""model.frame""), subset,na.action, model = TRUE, x.ret = FALSE, y.ret = FALSE, contrasts = NULL)", 150)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::lqs()", 1)
        End If
    End Sub

    Private Sub cmdqda_Click(sender As Object, e As EventArgs) Handles cmdqda.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::qda(formula = , data, weights, ..., subset, na.action)", 56)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("MASS::qda()", 1)
        End If
    End Sub

    Private Sub cmdMinus_Click(sender As Object, e As EventArgs) Handles cmdMinus.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdOpeningBracket_Click(sender As Object, e As EventArgs) Handles cmdOpeningBracket.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("(")
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmdDiv_Click(sender As Object, e As EventArgs) Handles cmdDiv.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("/")
    End Sub

    Private Sub cmdDoubleBracket_Click(sender As Object, e As EventArgs) Handles cmdDoubleBracket.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("( )")
    End Sub

    Private Sub cmdSquareBrackets_Click(sender As Object, e As EventArgs) Handles cmdSquareBrackets.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("[ ]")
    End Sub

    Private Sub cmdClosingBracket_Click(sender As Object, e As EventArgs) Handles cmdClosingBracket.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition(")")
    End Sub

    Private Sub cmdColon_Click(sender As Object, e As EventArgs) Handles cmdColon.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition(":")
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub cmdDisplayOptions_Click(sender As Object, e As EventArgs) Handles cmdDisplayOptions.Click
        sdgSimpleRegOptions.SetRCode(clsNewRSyntax:=ucrBase.clsRsyntax, clsNewFormulaFunction:=clsFormulaFunction, clsNewAnovaFunction:=clsAnovaFunction, clsNewRSummaryFunction:=clsSummaryFunction, clsNewConfint:=clsConfint, clsNewVisReg:=clsVisReg, dctNewPlot:=dctPlotFunctions, clsNewResidualFunction:=clsResidualFunction, clsNewFittedValuesFunction:=clsFittedValuesFunction, clsNewRstandardFunction:=clsRstandardFunction, clsNewHatvaluesFunction:=clsHatvaluesFunction, ucrNewAvailableDatafrane:=ucrSelectorModelling.ucrAvailableDataFrames, bReset:=bResetDisplayOptions)
        sdgSimpleRegOptions.ShowDialog()
        bResetDisplayOptions = False
    End Sub

    Private Sub OpenHelpPage()
        If Not String.IsNullOrEmpty(strPackageName) Then
            frmMaximiseOutput.Show(strFileName:=clsFileUrlUtilities.GetHelpFileURL(strPackageName:=strPackageName), bReplace:=False)
        End If
    End Sub

    Private Sub Clear()
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        bUpdating = True
        ucrSaveResult.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString, bReset)
        bUpdating = False
    End Sub


    Private Sub ucrReceiverForTestColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForTestColumn.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForTestColumn.GetVariableNames(False))
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverForTestColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputComboRPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboRPackage.ControlValueChanged
        Select Case ucrInputComboRPackage.GetText
            Case "stats"
                strPackageName = "stats"
                grpStats.Visible = True
                grpextRemes.Visible = False
                grplme4.Visible = False
                grpMASS.Visible = False
                grpArm.Visible = False
                grpRstanarm.Visible = False
                cmdRHelpStats.Visible = True
                cmdRHelpExtRemes.Visible = False
                cmdRHelpLme4.Visible = False
                cmdRHelpMASS.Visible = False
                cmdRHelpArm.Visible = False
                cmdRHelpRstanam.Visible = False
            Case "extRemes"
                strPackageName = "extRemes"
                grpStats.Visible = False
                grpextRemes.Visible = True
                grplme4.Visible = False
                grpMASS.Visible = False
                grpArm.Visible = False
                grpRstanarm.Visible = False
                cmdRHelpStats.Visible = False
                cmdRHelpExtRemes.Visible = True
                cmdRHelpLme4.Visible = False
                cmdRHelpMASS.Visible = False
                cmdRHelpArm.Visible = False
                cmdRHelpRstanam.Visible = False
            Case "lme4"
                strPackageName = "lme4"
                grpStats.Visible = False
                grpextRemes.Visible = False
                grplme4.Visible = True
                grpMASS.Visible = False
                grpArm.Visible = False
                grpRstanarm.Visible = False
                cmdRHelpStats.Visible = False
                cmdRHelpExtRemes.Visible = False
                cmdRHelpLme4.Visible = True
                cmdRHelpMASS.Visible = False
                cmdRHelpArm.Visible = False
                cmdRHelpRstanam.Visible = False
            Case "MASS"
                strPackageName = "MASS"
                grpStats.Visible = False
                grpextRemes.Visible = False
                grplme4.Visible = False
                grpMASS.Visible = True
                grpArm.Visible = False
                grpRstanarm.Visible = False
                cmdRHelpStats.Visible = False
                cmdRHelpExtRemes.Visible = False
                cmdRHelpLme4.Visible = False
                cmdRHelpMASS.Visible = True
                cmdRHelpArm.Visible = False
                cmdRHelpRstanam.Visible = False
            Case "arm"
                strPackageName = "arm"
                grpArm.Visible = True
                grpRstanarm.Visible = False
                grpStats.Visible = False
                grpextRemes.Visible = False
                grplme4.Visible = False
                grpMASS.Visible = False
                cmdRHelpStats.Visible = False
                cmdRHelpExtRemes.Visible = False
                cmdRHelpLme4.Visible = False
                cmdRHelpMASS.Visible = False
                cmdRHelpArm.Visible = True
                cmdRHelpRstanam.Visible = False
            Case "rstanarm"
                strPackageName = "rstanarm"
                grpRstanarm.Visible = True
                grpArm.Visible = False
                grpStats.Visible = False
                grpextRemes.Visible = False
                grplme4.Visible = False
                grpMASS.Visible = False
                cmdRHelpStats.Visible = False
                cmdRHelpExtRemes.Visible = False
                cmdRHelpLme4.Visible = False
                cmdRHelpMASS.Visible = False
                cmdRHelpArm.Visible = False
                cmdRHelpRstanam.Visible = True
        End Select
    End Sub

    Private Sub cmdRHelpStats_Click(sender As Object, e As EventArgs) Handles cmdRHelpStats.Click, ToolStripMenuStats.Click
        If ucrInputComboRPackage.GetText = "stats" Then
            strPackageName = "stats"
        End If
        OpenHelpPage()
    End Sub
    Private Sub cmdRHelpExtRemes_Click(sender As Object, e As EventArgs) Handles cmdRHelpExtRemes.Click, ToolStripMenuExtRemes.Click
        If ucrInputComboRPackage.GetText = "extRemes" Then
            strPackageName = "extRemes"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelpLme4_Click(sender As Object, e As EventArgs) Handles cmdRHelpLme4.Click, ToolStripMenuLme4.Click
        If ucrInputComboRPackage.GetText = "lme4" Then
            strPackageName = "lme4"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelpMASS_Click(sender As Object, e As EventArgs) Handles cmdRHelpMASS.Click, ToolStripMenuMASS.Click
        If ucrInputComboRPackage.GetText = "MASS" Then
            strPackageName = "MASS"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelpArm_Click(sender As Object, e As EventArgs) Handles cmdRHelpArm.Click, ToolStripMenuIArm.Click
        If ucrInputComboRPackage.GetText = "arm" Then
            strPackageName = "arm"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelpRstanam_Click(sender As Object, e As EventArgs) Handles cmdRHelpRstanam.Click, ToolStripMenuRstanam.Click
        If ucrInputComboRPackage.GetText = "rstanarm" Then
            strPackageName = "rstanarm"
        End If
        OpenHelpPage()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrReceiverForTestColumn.AddtoCombobox(ucrReceiverForTestColumn.GetText)
    End Sub


End Class