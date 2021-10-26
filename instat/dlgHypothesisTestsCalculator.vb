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
Public Class dlgHypothesisTestsCalculator
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsAttach As New RFunction
    Private clsDetach As New RFunction
    Private strPackageName As String
    Private clsSummary As New RFunction
    Private Sub dlgHypothesisTestsCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
        SetRcodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForTestColumn.Selector = ucrSelectorColumn
        ucrReceiverMultiple.Selector = ucrSelectorColumn
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrChkIncludeArguments.SetText("Include Arguments")
        ucrChkBy.SetText("By")
        ucrChkDisplayModel.SetText("Display Model")
        ucrChkSummaryModel.SetText("Summary Model")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveResult.SetPrefix("test")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Save test object")
        ucrSaveResult.SetAssignToIfUncheckedValue("Last_Test")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorColumn.ucrAvailableDataFrames)

        ucrInputComboRPackage.SetItems({"Stats1", "Stats2", "Agricolae", "Verification", "Coin", "Trend"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()
        'Tooltips for conf & and Alt Buttons
        ttHypothesisTests.SetToolTip(cmdConf, "The confidence level can be changed for some tests to 0.9 or 0.99 etc")
        ttHypothesisTests.SetToolTip(cmdAlt, " For some hypotheses the alternative hypothesis is two sided by default, but can be changed to ""greater"" or ""less""")

        'Tooltips for the trend kyboard buttons
        ttHypothesisTests.SetToolTip(cmdBartels, "A rank version of von Neumann’s ratio test proposed by Bartels")
        ttHypothesisTests.SetToolTip(cmdBr, "The Buishand range test for change-point detection of a normal variate")
        ttHypothesisTests.SetToolTip(cmdBu, "The Buishand U test for change-point detection of a normal variate")
        ttHypothesisTests.SetToolTip(cmdCs, "The non-parametric Cox and Stuart trend test")
        ttHypothesisTests.SetToolTip(cmdCsmk, "The seasonal Mann-Kendall test under the presence of correlated seasons")
        ttHypothesisTests.SetToolTip(cmdLanzante, "The non-parametric Lanzante test for a shift in the central tendency of a time series")
        ttHypothesisTests.SetToolTip(cmdMk, "The Mann-Kendall trend test")
        ttHypothesisTests.SetToolTip(cmdMmk, "The multivariate (multisite) Mann-Kendall test")
        ttHypothesisTests.SetToolTip(cmdPcor, "The partial correlation trend test")
        ttHypothesisTests.SetToolTip(cmdPmk, "The partial Mann-Kendall trend test")
        ttHypothesisTests.SetToolTip(cmdPettitt, "Pettitt’s test for change-point detection")
        ttHypothesisTests.SetToolTip(cmdRrod, "The Fligner-Pollicello robust rank-order distributional test for location")
        ttHypothesisTests.SetToolTip(cmdSsens, "The seasonal Sen’s slope for linear rate of change")
        ttHypothesisTests.SetToolTip(cmdSens, "Sen’s slope for linear rate of change and corresponding confidence interval")
        ttHypothesisTests.SetToolTip(cmdSmk, "Seasonal Mann-Kendall trend test (Hirsch-Slack test)")
        ttHypothesisTests.SetToolTip(cmdSnh, "The standard normal homogeneity test (SNHT) for change-point detection of a normal variate")
        ttHypothesisTests.SetToolTip(cmdWm, "The Wallis and Moore phase-frequency test")
        ttHypothesisTests.SetToolTip(cmdWw, "The non-parametric Wald-Wolfowitz test for independence and stationarity")

        'Temporarily disabled: Not yet functioning.
        ucrChkBy.Enabled = False
        ucrReceiverMultiple.Enabled = False
        ucrChkBy.AddToLinkedControls(ucrReceiverMultiple, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrTryModelling.SetReceiver(ucrReceiverForTestColumn)
        ucrTryModelling.SetIsCommand()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorColumn.Reset()
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrSaveResult.Reset()
        ucrSaveResult.ucrChkSave.Checked = False
        ucrBase.clsRsyntax.SetAssignTo("Last_Test", strTempModel:="Last_Test", strTempDataframe:=ucrSelectorColumn.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        ucrChkDisplayModel.Checked = True
        ucrChkIncludeArguments.Checked = False
        ucrChkSummaryModel.AddRSyntaxContainsFunctionNamesCondition(True, {"summary"}, bNewIsPositive:=True)
        ucrInputComboRPackage.SetName("Stats1")
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsSummary.SetRCommand("summary")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorColumn.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorColumn.ucrAvailableDataFrames.clsCurrDataFrame)
        clsSummary.AddParameter("object", clsRCodeStructureParameter:=ucrBase.clsRsyntax.clsBaseCommandString, iPosition:=0)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)
        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSaveResult.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString, bReset)
    End Sub

    Private Sub ucrReceiverForTestColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForTestColumn.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForTestColumn.GetVariableNames(False))
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveResult.IsComplete AndAlso Not ucrReceiverForTestColumn.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        ucrReceiverForTestColumn.Backspace()
    End Sub

    Private Sub cmdComma_Click(sender As Object, e As EventArgs) Handles cmdComma.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition(",")
    End Sub

    Private Sub cmdBrackets_Click(sender As Object, e As EventArgs) Handles cmdBrackets.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("( )")
    End Sub

    Private Sub cmdSquareBrackets_Click(sender As Object, e As EventArgs) Handles cmdSquareBrackets.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("[ ]")
    End Sub

    Private Sub cmdSquiggle_Click(sender As Object, e As EventArgs) Handles cmdSquiggle.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("~")
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdConf_Click(sender As Object, e As EventArgs) Handles cmdConf.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("conf=0.95")
    End Sub

    Private Sub cmdAlt_Click(sender As Object, e As EventArgs) Handles cmdAlt.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("Alt=""two""")
    End Sub

    Private Sub cmdBartlett_Click(sender As Object, e As EventArgs) Handles cmdBartlett.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("bartlett.test(x = , g = )", 7)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("bartlett.test( )", 1)
        End If
    End Sub

    Private Sub cmdBinom_Click(sender As Object, e As EventArgs) Handles cmdBinom.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("binom.test(x = , n = , p = 0.5, alternative = c(""two.sided"", ""less"", ""greater""), conf.level = 0.95)", 85)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("binom.test( )", 1)
        End If
    End Sub

    Private Sub cmdbox_Click(sender As Object, e As EventArgs) Handles cmdbox.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("Box.test(x = , lag = 1, type = c(""Box-Pierce"", ""Ljung-Box""), fitdf = 0)", 59)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("Box.test( )", 1)
        End If
    End Sub

    Private Sub cmdChisq_Click(sender As Object, e As EventArgs) Handles cmdChisq.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("chisq.test(x = , y = NULL, correct = TRUE, p = rep(1/length(x), length(x)), rescale.p = FALSE,simulate.p.value = FALSE, B = 2000)", 114)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("chisq.test( )", 1)
        End If
    End Sub

    Private Sub cmdCor_Click(sender As Object, e As EventArgs) Handles cmdCor.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("cor.test(x = , y= ,alternative = c(""two.sided"", ""less"", ""greater""),method = c(""pearson"", ""kendall"", ""spearman""),exact = NULL, conf.level = 0.95, continuity = FALSE)", 152)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("cor.test( )", 1)
        End If
    End Sub

    Private Sub cmdfisher_Click(sender As Object, e As EventArgs) Handles cmdfisher.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("fisher.test(x = , y = NULL, workspace = 200000, hybrid = FALSE, control = list(), or = 1, alternative = ""two.sided"", conf.int = TRUE, conf.level = 0.95, simulate.p.value = FALSE, B = 2000)", 172)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("fisher.test( )", 1)
        End If
    End Sub

    Private Sub cmdfligner_Click(sender As Object, e As EventArgs) Handles cmdfligner.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("fligner.test(x = , g = )", 7)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("fligner.test( )", 1)
        End If
    End Sub

    Private Sub cmdFriedman_Click(sender As Object, e As EventArgs) Handles cmdFriedman.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("friedman.test(y = )", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("friedman.test( )", 1)
        End If
    End Sub

    Private Sub cmdKs_Click(sender As Object, e As EventArgs) Handles cmdKs.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ks.test(x = , y = , alternative = c(""two.sided"", ""less"", ""greater""), exact = NULL)", 70)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ks.test( )", 1)
        End If
    End Sub

    Private Sub cmdKruskal_Click(sender As Object, e As EventArgs) Handles cmdKruskal.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("kruskal.test(x = , g = )", 7)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("kruskal.test( )", 1)
        End If
    End Sub

    Private Sub cmdMauchly_Click(sender As Object, e As EventArgs) Handles cmdMauchly.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("mauchly.test(object = , Sigma = diag(nrow = p), T = Thin.row(proj(M) - proj(X)), M = diag(nrow = p), X = ~0,idata = data.frame(index = seq_len(p)))", 124)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("mauchly.test( )", 1)
        End If
    End Sub

    Private Sub cmdWilcox_Click(sender As Object, e As EventArgs) Handles cmdWilcox.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("wilcox.test(x = , y = NULL, alternative = c(""two.sided"", ""less"", ""greater""), mu = 0, paired = FALSE, exact = NULL, correct = TRUE, conf.int = FALSE, conf.level = 0.95)", 151)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("wilcox.test( )", 1)
        End If
    End Sub

    Private Sub cmdMcnemar_Click(sender As Object, e As EventArgs) Handles cmdMcnemar.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("mcnemar.test(x = , y = NULL, correct = TRUE)", 27)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("mcnemar.test( )", 1)
        End If
    End Sub

    Private Sub cmdMood_Click(sender As Object, e As EventArgs) Handles cmdMood.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("mood.test(x = , y = , alternative = c(""two.sided"", ""less"", ""greater""))", 55)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("mood.test( )", 1)
        End If
    End Sub

    Private Sub cmdOneway_Click(sender As Object, e As EventArgs) Handles cmdOneway.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("oneway.test(formula = , data = , subset = , na.action = , var.equal = FALSE)", 55)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("oneway.test( )", 1)
        End If
    End Sub

    Private Sub cmdPairwiseProp_Click(sender As Object, e As EventArgs) Handles cmdPairwiseProp.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("pairwise.prop.test(x = , n = , p.adjust.method = p.adjust.method)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("pairwise.prop.test( )", 1)
        End If
    End Sub

    Private Sub cmdPairwiset_Click(sender As Object, e As EventArgs) Handles cmdPairwiset.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("pairwise.t.test(x = , g = , p.adjust.method = p.adjust.methods,pool.sd = !paired, paired = FALSE, alternative = c(""two.sided"", ""less"", ""greater""))", 126)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("pairwise.t.test( )", 1)
        End If
    End Sub

    Private Sub cmdPaiwiseWilcox_Click(sender As Object, e As EventArgs) Handles cmdPaiwiseWilcox.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("pairwise.wilcox.test(x = , g = , p.adjust.method = p.adjust.methods,paired = FALSE)", 58)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("pairwise.wilcox.test( )", 1)
        End If
    End Sub

    Private Sub cmdPowerAnova_Click(sender As Object, e As EventArgs) Handles cmdPowerAnova.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("power.anova.test(groups = NULL, n = NULL, between.var = NULL, within.var = NULL, sig.level = 0.05, power = NULL)", 85)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("power.anova.test( )", 1)
        End If
    End Sub

    Private Sub cmdPowerProp_Click(sender As Object, e As EventArgs) Handles cmdPowerProp.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("power.prop.test(n = NULL, p1 = NULL, p2 = NULL, sig.level = 0.05, power = NULL, alternative = c(""two.sided"", ""one.sided""),strict = FALSE, tol = .Machine$double.eps^0.25)", 149)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("power.prop.test( )", 1)
        End If
    End Sub

    Private Sub cmdPowerT_Click(sender As Object, e As EventArgs) Handles cmdPowerT.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("power.t.test(n = NULL, delta = NULL, sd = 1, sig.level = 0.05, power = NULL, type = c(""two.sample"", ""one.sample"", ""paired""), alternative = c(""two.sided"", ""one.sided""), strict = FALSE, tol = .Machine$double.eps^0.25)", 196)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("power.t.test( )", 1)
        End If
    End Sub

    Private Sub cmdPropTrend_Click(sender As Object, e As EventArgs) Handles cmdPropTrend.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("prop.trend.test(x = , n = , score = seq_along(x))", 30)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("prop.trend.test( )", 1)
        End If
    End Sub

    Private Sub cmdShapiro_Click(sender As Object, e As EventArgs) Handles cmdShapiro.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("shapiro.test(x = )", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("shapiro.test( )", 1)
        End If
    End Sub

    Private Sub cmdVar_Click(sender As Object, e As EventArgs) Handles cmdVar.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("var.test(x = , y = , ratio = 1, alternative = c(""two.sided"", ""less"", ""greater""), conf.level = 0.95)", 86)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("var.test( )", 1)
        End If
    End Sub

    Private Sub cmdPoisson_Click(sender As Object, e As EventArgs) Handles cmdPoisson.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("poisson.test(x = , T = 1, r = 1, alternative = c(""two.sided"", ""less"", ""greater""), conf.level = 0.95)", 83)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("poisson.test( )", 1)
        End If
    End Sub

    Private Sub cmdProp_Click(sender As Object, e As EventArgs) Handles cmdProp.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("prop.test(x = , n = , p = NULL, alternative = c(""two.sided"", ""less"", ""greater""), conf.level = 0.95, correct = TRUE)", 99)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("prop.test( )", 1)
        End If
    End Sub

    Private Sub cmdT_Click(sender As Object, e As EventArgs) Handles cmdT.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("t.test(x= , y = NULL, alternative = c(""two.sided"", ""less"", ""greater""), mu = 0, paired = FALSE, var.equal = FALSE, conf.level = 0.95)", 122)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("t.test( )", 1)
        End If
    End Sub

    Private Sub cmdAnsari_Click(sender As Object, e As EventArgs) Handles cmdAnsari.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ansari.test(x = , y = , alternative = c(""two.sided"", ""less"", ""greater""), exact = NULL, conf.int = FALSE, conf.level = 0.95,))", 109)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ansari.test( )", 1)
        End If
    End Sub

    Private Sub cmdMantelhaen_Click(sender As Object, e As EventArgs) Handles cmdMantelhaen.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("mantelhaen.test(x = , y = NULL, z = NULL,alternative = c(""two.sided"", ""less"", ""greater""),correct = TRUE, exact = FALSE, conf.level = 0.95)", 118)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("mantelhaen.test( )", 1)
        End If
    End Sub

    Private Sub cmdQuade_Click(sender As Object, e As EventArgs) Handles cmdQuade.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("quade.test(y = , groups = , blocks = )", 23)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("quade.test( )", 1)
        End If
    End Sub

    Private Sub cmdPP_Click(sender As Object, e As EventArgs) Handles cmdPP.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("PP.test(x = , lshort = TRUE)", 16)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("PP.test( )", 1)
        End If
    End Sub

    Private Sub cmdBIB_Click(sender As Object, e As EventArgs) Handles cmdBIB.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::BIB.test(block = , trt = , y = , test = c(""lsd"",""tukey"",""duncan"",""waller"",""snk""), alpha = 0.05, group = TRUE, console = FALSE)", 110)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::BIB.test( )", 1)
        End If
    End Sub

    Private Sub cmdDuncan_Click(sender As Object, e As EventArgs) Handles cmdDuncan.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::duncan.test(y = , trt = , DFerror = , MSerror = , alpha = 0.05, group = TRUE, main = NULL, console = FALSE)", 91)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::duncan.test( )", 1)
        End If
    End Sub

    Private Sub cmdDurbin_Click(sender As Object, e As EventArgs) Handles cmdDurbin.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::durbin.test(judge = , trt = , evaluation = , alpha = 0.05, group = TRUE, main = NULL, console = FALSE)", 82)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::durbin.test( )", 1)
        End If
    End Sub

    Private Sub cmdAgriFriedman_Click(sender As Object, e As EventArgs) Handles cmdAgriFriedman.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::friedman(judge = , trt = , evaluation = , alpha = 0.05, group = True, main = NULL, Console = False)", 82)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::friedman( )", 1)
        End If
    End Sub

    Private Sub cmdAgriKruskal_Click(sender As Object, e As EventArgs) Handles cmdAgriKruskal.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::kruskal(y = , trt = , alpha = 0.05, p.adj = c(""none"", ""holm"", ""hommel"", ""hochberg"", ""bonferroni"", ""BH"", ""BY"", ""fdr""), group = True, main = NULL, Console = False)", 149)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::kruskal( )", 1)
        End If

    End Sub

    Private Sub cmdLSD_Click(sender As Object, e As EventArgs) Handles cmdLSD.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::LSD.test(y = , trt = , DFerror = , MSerror = , alpha = 0.05, p.adj = c(""none"", ""holm"", ""hommel"", ""hochberg"", ""bonferroni"", ""BH"", ""BY"", ""fdr""), group = True, main = NULL, Console = False)", 174)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::LSD.test( )", 1)
        End If
    End Sub

    Private Sub cmdMedian_Click(sender As Object, e As EventArgs) Handles cmdMedian.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::Median.test(y = , trt = , alpha = 0.05, correct =TRUE, simulate.p.value = FALSE, group = TRUE, main = NULL, console = TRUE)", 107)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::Median.test( )", 1)
        End If
    End Sub

    Private Sub cmdAgriNonAdditivity_Click(sender As Object, e As EventArgs) Handles cmdAgriNonAdditivity.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::nonadditivity(y = , factor1 = , factor2 = , df = , MSerror = )", 44)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::nonadditivity( )", 1)
        End If
    End Sub

    Private Sub cmdPBIB_Click(sender As Object, e As EventArgs) Handles cmdPBIB.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::PBIB.test(block = , trt = , replication = , y = , k = , method = c(""REML"", ""ML"", ""VC""), test = c(""lsd"", ""tukey""), alpha = 0.05, Console = False, group = True)", 140)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::PBIB.test( )", 1)
        End If
    End Sub

    Private Sub cmdREGW_Click(sender As Object, e As EventArgs) Handles cmdREGW.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::REGW.test(y = , trt = , DFerror = , MSerror = , alpha = 0.05, group = TRUE, main = NULL, console = FALSE)", 91)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::REGW.test( )", 1)
        End If
    End Sub

    Private Sub cmdScheffe_Click(sender As Object, e As EventArgs) Handles cmdScheffe.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::scheffe.test(y = , trt = , DFerror = , MSerror = , Fc = , alpha = 0.05, group = TRUE, main = NULL, console = FALSE )", 99)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::scheffe.test( )", 1)
        End If
    End Sub

    Private Sub cmdSNK_Click(sender As Object, e As EventArgs) Handles cmdSNK.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::SNK.test(y = , trt = , DFerror = , MSerror = , alpha = 0.05, group = TRUE, main = NULL, console = FALSE)", 91)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::SNK.test( )", 1)
        End If
    End Sub

    Private Sub cmdWaerden_Click(sender As Object, e As EventArgs) Handles cmdWaerden.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::waerden.test(y = , trt = , alpha = 0.05, group = TRUE, main = NULL, console = FALSE)", 67)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::waerden.test( )", 1)
        End If
    End Sub

    Private Sub cmdAgriWaller_Click(sender As Object, e As EventArgs) Handles cmdAgriWaller.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::waller.test(y = , trt = , DFerror = , MSerror = , Fc = , K = 100, group = TRUE, main = NULL, console = FALSE)", 93)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("agricolae::waller.test( )", 1)
        End If
    End Sub

    Private Sub cmdClearStats2_Click(sender As Object, e As EventArgs) Handles cmdClearStats2.Click
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub ucrChkBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkBy.ControlValueChanged
        If ucrChkBy.Checked Then
            ucrReceiverMultiple.SetMeAsReceiver()
        Else
            ucrReceiverForTestColumn.SetMeAsReceiver()
        End If
    End Sub

    Private Sub clear()
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub ucrInputComboRPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboRPackage.ControlValueChanged
        Select Case ucrInputComboRPackage.GetText
            Case "Stats1"
                strPackageName = "stats"
                grpAgricolae.Visible = False
                grpStats1.Visible = True
                grpStats2.Visible = False
                grpVerification.Visible = False
                grpCoin.Visible = False
                grpTrend.Visible = False
            Case "Stats2"
                strPackageName = "stats"
                grpAgricolae.Visible = False
                grpStats1.Visible = False
                grpStats2.Visible = True
                grpVerification.Visible = False
                grpCoin.Visible = False
                grpTrend.Visible = False
            Case "Agricolae"
                strPackageName = "agricolae"
                grpStats1.Visible = False
                grpStats2.Visible = False
                grpAgricolae.Visible = True
                grpVerification.Visible = False
                grpCoin.Visible = False
                grpTrend.Visible = False
            Case "Verification"
                strPackageName = "verification"
                grpStats1.Visible = False
                grpStats2.Visible = False
                grpAgricolae.Visible = False
                grpVerification.Visible = True
                grpCoin.Visible = False
                grpTrend.Visible = False
            Case "Coin"
                strPackageName = "coin"
                grpStats1.Visible = False
                grpStats2.Visible = False
                grpAgricolae.Visible = False
                grpVerification.Visible = False
                grpCoin.Visible = True
                grpTrend.Visible = False
            Case "Trend"
                strPackageName = "trend"
                grpStats1.Visible = False
                grpStats2.Visible = False
                grpAgricolae.Visible = False
                grpVerification.Visible = False
                grpCoin.Visible = False
                grpTrend.Visible = True

        End Select
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction

        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("package", Chr(34) & strPackageName & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for" & " " & strPackageName & " " & "Package. Generated from dialog Hypothesis Tests", iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverForTestColumn.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrReceiverForTestColumn.AddtoCombobox(ucrReceiverForTestColumn.GetText)
    End Sub

    Private Sub cmdBinary_Click(sender As Object, e As EventArgs) Handles cmdBinary.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("verification::verify(obs = , pred, p = NULL, baseline = NULL, frcst.type = ""prob"", obs.type = ""binary"",thresholds = seq(0,1,0.1), show = TRUE, bins = TRUE,fudge = 0.01)", 142)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("verification::verify(obs = , pred = , frcst.type = ""bin"", obs.type = ""bin"" )", 50)
        End If
    End Sub

    Private Sub cmdCat_Click(sender As Object, e As EventArgs) Handles cmdCat.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("verification::verify(obs = , pred, p = NULL, baseline = NULL, frcst.type = ""prob"", obs.type = ""binary"",thresholds = seq(0,1,0.1), show = TRUE, bins = TRUE,fudge = 0.01)", 142)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("verification::verify(obs = , pred = , frcst.type = ""cat"", obs.type = ""cat"" )", 50)
        End If
    End Sub

    Private Sub cmdCont_Click(sender As Object, e As EventArgs) Handles cmdCont.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("verification::verify(obs = , pred, p = NULL, baseline = NULL, frcst.type = ""prob"", obs.type = ""binary"",thresholds = seq(0,1,0.1), show = TRUE, bins = TRUE,fudge = 0.01)", 142)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("verification::verify(obs = , pred = , frcst.type = ""cont"", obs.type = ""cont"" )", 52)
        End If
    End Sub

    Private Sub ucrChkSummaryDisplayModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSummaryModel.ControlValueChanged
        If ucrChkSummaryModel.Checked Then
            clsSummary.iCallType = 2
            ucrBase.clsRsyntax.AddToAfterCodes(clsSummary, 0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsSummary)
        End If
    End Sub

    Private Sub ucrChkDisplayModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayModel.ControlValueChanged
        If ucrChkDisplayModel.Checked Then
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        Else
            ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = True
        End If
    End Sub

    Private Sub cmdOneway1_Click(sender As Object, e As EventArgs) Handles cmdOneway1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::oneway_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::oneway_test()", 1)
        End If
    End Sub

    Private Sub cmdWilcox1_Click(sender As Object, e As EventArgs) Handles cmdWilcox1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::wilcox_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::wilcox_test()", 1)
        End If
    End Sub

    Private Sub cmdKruskal1_Click(sender As Object, e As EventArgs) Handles cmdKruskal1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::kruskal_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::kruskal_test()", 1)
        End If
    End Sub

    Private Sub cmdNormal_Click(sender As Object, e As EventArgs) Handles cmdNormal.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::normal_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::normal_test()", 1)
        End If
    End Sub

    Private Sub cmdMedian1_Click(sender As Object, e As EventArgs) Handles cmdMedian1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::median_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::median_test()", 1)
        End If
    End Sub

    Private Sub cmdSavage_Click(sender As Object, e As EventArgs) Handles cmdSavage.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::savage_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::savage_test()", 1)
        End If
    End Sub

    Private Sub cmdSign_Click(sender As Object, e As EventArgs) Handles cmdSign.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::sign_test(formula = , data = , subset = NULL)", 26)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::sign_test()", 1)
        End If
    End Sub

    Private Sub cmdWilcoksign_Click(sender As Object, e As EventArgs) Handles cmdWilcoxsign.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::wilcoxsign_test(formula = , data = , subset = NULL)", 26)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::wilcoxsign_test()", 1)
        End If
    End Sub

    Private Sub cmdFriedman1_Click(sender As Object, e As EventArgs) Handles cmdFriedman1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::friedman_test(object = )", 2)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::friedman_test()", 1)
        End If
    End Sub

    Private Sub cmdQuade1_Click(sender As Object, e As EventArgs) Handles cmdQuade1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::quade_test(object = )", 2)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::quade_test()", 1)
        End If
    End Sub

    Private Sub cmdTaha_Click(sender As Object, e As EventArgs) Handles cmdTaha.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::taha_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::taha_test()", 1)
        End If
    End Sub

    Private Sub cmdKlotz_Click(sender As Object, e As EventArgs) Handles cmdKlotz.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::klotz_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::klotz_test()", 1)
        End If
    End Sub

    Private Sub cmdMood1_Click(sender As Object, e As EventArgs) Handles cmdMood1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::mood_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::mood_test()", 1)
        End If
    End Sub

    Private Sub cmdAnsari1_Click(sender As Object, e As EventArgs) Handles cmdAnsari1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::ansari_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::ansari_test()", 1)
        End If
    End Sub

    Private Sub cmdFligner1_Click(sender As Object, e As EventArgs) Handles cmdFligner1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::fligner_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::fligner_test()", 1)
        End If
    End Sub

    Private Sub cmdConover_Click(sender As Object, e As EventArgs) Handles cmdConover.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::conover_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::conover_test()", 1)
        End If
    End Sub

    Private Sub cmdSpearman_Click(sender As Object, e As EventArgs) Handles cmdSpearman.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::spearman_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::spearman_test()", 1)
        End If
    End Sub

    Private Sub cmdFisyat_Click(sender As Object, e As EventArgs) Handles cmdFisyat.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::fisyat_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::fisyat_test()", 1)
        End If
    End Sub

    Private Sub cmdQuadrant_Click(sender As Object, e As EventArgs) Handles cmdQuadrant.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::quadrant_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::quadrant_test()", 1)
        End If
    End Sub

    Private Sub cmdKoziol_Click(sender As Object, e As EventArgs) Handles cmdKoziol.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::koziol_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::koziol_test()", 1)
        End If
    End Sub

    Private Sub cmdChisq1_Click(sender As Object, e As EventArgs) Handles cmdChisq1.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::chisq_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::chisq_test()", 1)
        End If
    End Sub

    Private Sub cmdCmh_Click(sender As Object, e As EventArgs) Handles cmdCmh.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::cmh_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::cmh_test()", 1)
        End If
    End Sub

    Private Sub cmdLbl_Click(sender As Object, e As EventArgs) Handles cmdLbl.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::lbl_test(formula = , data = , subset = NULL, weights = NULL)", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coin::lbl_test()", 1)
        End If
    End Sub

    Private Sub cmdBartels_Click(sender As Object, e As EventArgs) Handles cmdBartels.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::bartels.test(x = )", 2)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::bartels.test()", 1)
        End If
    End Sub

    Private Sub cmdBr_Click(sender As Object, e As EventArgs) Handles cmdBr.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::br.test(x = , m = 20000)", 13)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::br.test()", 1)
        End If
    End Sub

    Private Sub cmdBu_Click(sender As Object, e As EventArgs) Handles cmdBu.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::bu.test(x = , m = 20000)", 13)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::bu.test()", 1)
        End If
    End Sub

    Private Sub cmdCs_Click(sender As Object, e As EventArgs) Handles cmdCs.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::cs.test(x = )", 2)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::cs.test()", 1)
        End If
    End Sub

    Private Sub cmdCsmk_Click(sender As Object, e As EventArgs) Handles cmdCsmk.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::csmk.test(x = , alternative = c(""two.sided"", ""greater"", ""less""))", 51)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::csmk.test()", 1)
        End If
    End Sub

    Private Sub cmdLanzante_Click(sender As Object, e As EventArgs) Handles cmdLanzante.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::lanzante.test(x = , method = c(""wilcox.test"", ""rrod.test""))", 42)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::lanzante.test()", 1)
        End If
    End Sub

    Private Sub cmdMk_Click(sender As Object, e As EventArgs) Handles cmdMk.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::mk.test(x = , alternative = c(""two.sided"", ""greater"", ""less""), continuity = TRUE)", 70)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::mk.test()", 1)
        End If
    End Sub

    Private Sub cmdMmk_Click(sender As Object, e As EventArgs) Handles cmdMmk.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::mult.mk.test(x = , alternative = c(""two.sided"", ""greater"", ""less""))", 51)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::mult.mk.test()", 1)
        End If
    End Sub

    Private Sub cmdPcor_Click(sender As Object, e As EventArgs) Handles cmdPcor.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::partial.cor.trend.test(x = , z = , method = c(""pearson"", ""spearman""))", 43)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::partial.cor.trend.test()", 1)
        End If
    End Sub

    Private Sub cmdPmk_Click(sender As Object, e As EventArgs) Handles cmdPmk.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::partial.mk.test(x = , y = , alternative = c(""two.sided"", ""greater"", ""less""))", 57)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::partial.mk.test()", 1)
        End If
    End Sub

    Private Sub cmdPettitt_Click(sender As Object, e As EventArgs) Handles cmdPettitt.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::pettitt.test(x = )", 2)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::pettitt.test()", 1)
        End If
    End Sub

    Private Sub cmdRrod_Click(sender As Object, e As EventArgs) Handles cmdRrod.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::rrod.test(x = , y = , alternative = c(""two.sided"", ""less"", ""greater""))", 57)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::rrod.test()", 1)
        End If
    End Sub

    Private Sub cmdSsens_Click(sender As Object, e As EventArgs) Handles cmdSsens.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::sea.sens.slope(x = )", 2)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::sea.sens.slope()", 1)
        End If
    End Sub

    Private Sub cmdSens_Click(sender As Object, e As EventArgs) Handles cmdSens.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::sens.slope(x = , conf.level = 0.95)", 21)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::sens.slope()", 1)
        End If
    End Sub

    Private Sub cmdSmk_Click(sender As Object, e As EventArgs) Handles cmdSmk.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::smk.test(x = , alternative = c(""two.sided"", ""greater"", ""less""), continuity = TRUE)", 70)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::smk.test()", 1)
        End If
    End Sub

    Private Sub cmdSnh_Click(sender As Object, e As EventArgs) Handles cmdSnh.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::snh.test(x = , m = 20000)", 13)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::snh.test()", 1)
        End If
    End Sub

    Private Sub cmdWw_Click(sender As Object, e As EventArgs) Handles cmdWw.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::ww.test(x = )", 2)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::ww.test()", 1)
        End If
    End Sub

    Private Sub cmdWm_Click(sender As Object, e As EventArgs) Handles cmdWm.Click
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::wm.test(x = )", 2)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("trend::wm.test()", 1)
        End If
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("I()", 1)
    End Sub
End Class