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
    Private Sub dlgHypothesisTestsCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
        SetRcodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForTestColumn.Selector = ucrSelectorColumn
        ucrReceiverMultiple.Selector = ucrSelectorColumn
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrChkIncludeArguments.SetText("Include Arguments")
        ucrChkBy.SetText("By")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveResult.SetPrefix("Test")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Save test object")
        ucrSaveResult.SetAssignToIfUncheckedValue("Last_Test")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorColumn.ucrAvailableDataFrames)

        ucrInputComboRPackage.SetItems({"Stats1", "Stats2", "Agricolae"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()
        'Tooltips for conf & and Alt Buttons
        tpConf.SetToolTip(cmdConf, "The confidence level can be changed for some tests to 0.9 or 0.99 etc")
        tpAlt.SetToolTip(cmdAlt, " For some hypotheses the alternative hypothesis is two sided by default, but can be changed to ""greater"" or ""less""")
        'Temporarily disabled: Not yet functioning.
        ucrChkBy.Enabled = False
        ucrReceiverMultiple.Enabled = False
        ucrChkBy.AddToLinkedControls(ucrReceiverMultiple, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        ucrSelectorColumn.Reset()
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrSaveResult.Reset()
        ucrSaveResult.ucrChkSave.Checked = False
        ucrBase.clsRsyntax.SetAssignTo("Last_Test", strTempModel:="Last_Test", strTempDataframe:=ucrSelectorColumn.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        ucrChkIncludeArguments.Checked = False
        ucrInputComboRPackage.SetName("Stats1")
        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorColumn.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorColumn.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSaveResult.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString, bReset)
    End Sub

    Private Sub ucrReceiverForTestColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForTestColumn.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForTestColumn.GetVariableNames(False))
        ucrInputTryMessage.SetName("")
        cmdTry.Enabled = Not ucrReceiverForTestColumn.IsEmpty()
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

    Private Sub TryScript()
        Dim strOutPut As String
        Dim strAttach As String
        Dim strDetach As String
        Dim strTempScript As String = ""
        Dim strVecOutput As CharacterVector
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean
        Dim strAssignTo As String
        Dim strAssignToColumn As String
        Dim strAssignToDataFrame As String

        bIsAssigned = ucrBase.clsRsyntax.GetbIsAssigned()
        bToBeAssigned = ucrBase.clsRsyntax.GetbToBeAssigned()
        strAssignTo = ucrBase.clsRsyntax.GetstrAssignTo()
        'These should really be done through RSyntax methods as above
        strAssignToColumn = ucrBase.clsRsyntax.GetstrAssignToColumn()
        strAssignToDataFrame = ucrBase.clsRsyntax.GetstrAssignToDataFrame()

        Try
            If ucrReceiverForTestColumn.IsEmpty Then
                ucrInputTryMessage.SetName("")
            Else
                'get strScript here
                strAttach = clsAttach.ToScript(strTempScript)
                frmMain.clsRLink.RunInternalScript(strTempScript & strAttach, bSilent:=True)
                ucrBase.clsRsyntax.RemoveAssignTo()
                strOutPut = ucrBase.clsRsyntax.GetScript
                strVecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(strOutPut, bSilent:=True)
                If strVecOutput IsNot Nothing Then
                    If strVecOutput.Length > 1 Then
                        ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5) & "...")
                    Else
                        ucrInputTryMessage.SetName(Mid(strVecOutput(0), 5))
                    End If
                Else
                    ucrInputTryMessage.SetName("Command produced an error or no output to display.")
                End If
            End If
        Catch ex As Exception
            ucrInputTryMessage.SetName("Command produced an error. Modify input before running.")
        Finally
            strTempScript = ""
            strDetach = clsDetach.ToScript(strTempScript)
            frmMain.clsRLink.RunInternalScript(strTempScript & strDetach, bSilent:=True)
            ucrBase.clsRsyntax.SetbIsAssigned(bIsAssigned)
            ucrBase.clsRsyntax.SetbToBeAssigned(bToBeAssigned)
            ucrBase.clsRsyntax.SetstrAssignTo(strAssignTo)
            'These should really be done through RSyntax methods as above
            ucrBase.clsRsyntax.SetstrAssignToColumn(strAssignToColumn)
            ucrBase.clsRsyntax.SetstrAssignToDataFrame(strAssignToDataFrame)
        End Try
    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles cmdTry.Click
        TryScript()
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
            Case "Stats2"
                strPackageName = "stats"
                grpAgricolae.Visible = False
                grpStats1.Visible = False
                grpStats2.Visible = True
            Case "Agricolae"
                strPackageName = "agricolae"
                grpStats1.Visible = False
                grpStats2.Visible = False
                grpAgricolae.Visible = True
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

End Class