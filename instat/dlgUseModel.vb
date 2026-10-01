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

Imports instat
Imports instat.Translations
Imports RDotNet
Public Class dlgUseModel
    Private strPackageName As String
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Public bUpdating As Boolean = False

    Private clsAttach As New RFunction

    Private Sub dlgUseModelLoad(sender As Object, e As EventArgs) Handles Me.Load
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
        ucrSaveResult.SetPrefix("object")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Store Output")
        ucrSaveResult.SetAssignToIfUncheckedValue("last_object")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorUseModel.ucrAvailableDataFrames)


        ucrReceiverForTestColumn.SetParameterIsRFunction()
        ucrReceiverForTestColumn.SetItemType("model")
        ucrReceiverForTestColumn.strSelectorHeading = "Models"
        ucrReceiverForTestColumn.Selector = ucrSelectorUseModel
        ucrReceiverForTestColumn.SetMeAsReceiver()

        ucrInputComboRPackage.SetItems({"General", "Prediction", "extRemes", "segmented", "emmeans"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()

        ucrTryModelling.SetReceiver(ucrReceiverForTestColumn)
        ucrTryModelling.SetIsModel()

        ucrChkIncludeArguments.SetText("Show Arguments")

        ucrInputModels.IsReadOnly = True

        bUpdating = False

    End Sub

    Private Sub SetDefaults()
        ' ucrBase.iHelpTopicID = 379
        clsAttach = New RFunction

        clsAttach.SetRCommand("attach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorUseModel.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)


        ucrBase.clsRsyntax.ClearCodes()

        ucrSelectorUseModel.Reset()
        ucrSaveResult.Reset()

        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrReceiverForTestColumn.Clear()

        ucrInputComboRPackage.SetName("General")


        ucrChkIncludeArguments.Checked = False

        ucrBase.clsRsyntax.ClearCodes()


        ucrBase.clsRsyntax.SetCommandString("")

        ucrBase.clsRsyntax.SetAssignTo("last_object", strTempModel:="last_object", strTempDataframe:=ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2

        ucrTryModelling.SetRSyntax(ucrBase.clsRsyntax)

        ucrBase.clsRsyntax.iCallType = 2

        KeyboardsVisibility()
        GetModels()
        TestOkEnabled()
    End Sub

    Private Sub SetRcodeForControls(bReset As Object)
        ucrSaveResult.SetRCode(ucrBase.clsRsyntax.clsBaseCommandString, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrSaveResult.IsComplete AndAlso Not ucrReceiverForTestColumn.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub cmdsummary_Click(sender As Object, e As EventArgs) Handles cmdsummary.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary(object=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary()", 1)
        End If
    End Sub

    Private Sub cmdanova_Click(sender As Object, e As EventArgs) Handles cmdanova.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("anova(object=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("anova()", 1)
        End If
    End Sub

    Private Sub cmdresiduals_Click(sender As Object, e As EventArgs) Handles cmdresiduals.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("residuals(object=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("residuals()", 1)
        End If
    End Sub

    Private Sub cmdSummaryFevd_click(sender As Object, e As EventArgs) Handles cmdSummaryFevd.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary(object=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary()", 1)
        End If
    End Sub

    Private Sub cmdPlotFevd_click(sender As Object, e As EventArgs) Handles cmdPlotFevd.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("plot(x=, type = c(""primary"", ""probprob"", ""qq"", ""qq2"",""Zplot"", ""hist"", ""density"",""rl"", ""trace""), rperiods = c(2, 5, 10, 20, 50, 80, 100, 120, 200, 250, 300, 500, 800),a = 0, hist.args = NULL, density.args = NULL, d = NULL, ...)", 219)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("plot()", 1)
        End If
    End Sub

    Private Sub cmdPrintFevd_click(sender As Object, e As EventArgs) Handles cmdPrintFevd.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("print(x=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("print()", 1)
        End If
    End Sub

    Private Sub cmdPredict_Click(sender As Object, e As EventArgs) Handles cmdPredict.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("prediction::prediction(model=, data = find_data(model,parent.frame()), at = NULL, type = ""response"",vcov = stats::vcov(model), calculate_se = TRUE, ...)", 123)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("prediction::prediction()", 1)
        End If
    End Sub

    Private Sub Clear()
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputComboRPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboRPackage.ControlValueChanged
        KeyboardsVisibility()
    End Sub

    Private Sub KeyboardsVisibility()
        grpGeneral.Visible = False
        grpPrediction.Visible = False
        grpExtrRemes.Visible = False
        grpSegmented.Visible = False
        grpEmmeans.Visible = False
        Select Case ucrInputComboRPackage.GetText
            Case "General"
                grpGeneral.Visible = True
                cmdRHelpGeneral.Visible = True
                cmdRHelpExtRemes.Visible = False
                cmdRHelpPrediction.Visible = False
                cmdRHelpSegmented.Visible = False
                cmdRHelpEmmeans.Visible = False
            Case "Prediction"
                grpPrediction.Visible = True
                cmdRHelpGeneral.Visible = False
                cmdRHelpExtRemes.Visible = False
                cmdRHelpPrediction.Visible = True
                cmdRHelpSegmented.Visible = False
                cmdRHelpEmmeans.Visible = False
            Case "extRemes"
                grpExtrRemes.Visible = True
                cmdRHelpGeneral.Visible = False
                cmdRHelpExtRemes.Visible = True
                cmdRHelpPrediction.Visible = False
                cmdRHelpSegmented.Visible = False
                cmdRHelpEmmeans.Visible = False
            Case "segmented"
                grpSegmented.Visible = True
                cmdRHelpGeneral.Visible = False
                cmdRHelpExtRemes.Visible = False
                cmdRHelpPrediction.Visible = False
                cmdRHelpSegmented.Visible = True
                cmdRHelpEmmeans.Visible = False
            Case "emmeans"
                grpEmmeans.Visible = True
                cmdRHelpEmmeans.Visible = True
                cmdRHelpGeneral.Visible = False
                cmdRHelpExtRemes.Visible = False
                cmdRHelpPrediction.Visible = False
                cmdRHelpSegmented.Visible = False
        End Select
    End Sub

    Private Sub ucrReceiverForTestColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForTestColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverForTestColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForTestColumn.ControlValueChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForTestColumn.GetVariableNames(False))
        GetModels()
    End Sub

    Private Sub GetModels()
        Dim clsGetModel As New RFunction
        Dim strExpression As String
        Dim lstModels As New List(Of String)
        Dim i As Integer = 0
        Dim strModel As String
        Dim item As ListViewItem

        ucrBase.clsRsyntax.GetBeforeCodes.Clear()
        clsGetModel.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        ucrInputModels.SetName("[No models selected]")
        strExpression = ucrReceiverForTestColumn.GetVariableNames(False)
        For Each item In ucrSelectorUseModel.lstAvailableVariable.Items
            strModel = item.Text
            If strExpression.Contains(strModel) Then
                lstModels.Add(strModel)
                clsGetModel.AddParameter("data_name", Chr(34) & ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
                clsGetModel.AddParameter("object_name", Chr(34) & strModel & Chr(34), iPosition:=1)
                clsGetModel.AddParameter("as_file", "FALSE", iPosition:=2)
                clsGetModel.SetAssignToObject(strRObjectToAssignTo:=strModel)
                ucrBase.clsRsyntax.AddToBeforeCodes(clsGetModel.Clone(), iPosition:=i)
                i = i + 1
            End If
        Next
        If i > 0 Then
            ucrInputModels.SetName(String.Join(", ", lstModels))
        End If
        'Checking if the commandString contains the commands from the segmented ,davie and pscore buttons.If so Again check if the list of before codes contains the clsAttach function before adiing
        If Not (InStr(ucrBase.clsRsyntax.strCommandString, "segmented::segmented") = 0) Or Not (InStr(ucrBase.clsRsyntax.strCommandString, "segmented::davies.test") = 0) Or Not (InStr(ucrBase.clsRsyntax.strCommandString, "segmented::pscore.test") = 0) Then
            If Not ucrBase.clsRsyntax.GetBeforeCodes().Contains(clsAttach) Then
                ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach)
            End If

        End If
    End Sub

    Private Sub cmdPrint_Click(sender As Object, e As EventArgs) Handles cmdPrint.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("print(x=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("print()", 1)
        End If
    End Sub

    Private Sub cmdCoefficient_Click(sender As Object, e As EventArgs) Handles cmdCoefficient.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coefficients(object=, complete = TRUE, ...)", 23)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("coefficients()", 1)
        End If
    End Sub

    Private Sub cmdAIC_Click(sender As Object, e As EventArgs) Handles cmdAIC.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("AIC(object=, ..., k = 2)", 13)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("AIC()", 1)
        End If
    End Sub

    Private Sub cmdBIC_Click(sender As Object, e As EventArgs) Handles cmdBIC.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("BIC(object=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("BIC()", 1)
        End If
    End Sub

    Private Sub cmdOutlierTest_Click(sender As Object, e As EventArgs) Handles cmdOutlierTest.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::outlierTest(model=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::outlierTest()", 1)
        End If
    End Sub

    Private Sub cmdNcvTest_Click(sender As Object, e As EventArgs) Handles cmdNcvTest.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::ncvTest(model=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::ncvTest()", 1)
        End If
    End Sub

    Private Sub cmdDurbinWatsonTest_Click(sender As Object, e As EventArgs) Handles cmdDurbinWatsonTest.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car:: durbinWatsonTest(model=, max.lag=1, ...)", 17)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car:: durbinWatsonTest()", 1)
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::Anova(mod=, type=c(""II"", ""III"", 2, 3),test.statistic=c(""Chisq"", ""F""), vcov.=vcov(mod, complete=FALSE),singular.ok, ...)", 109)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("car::Anova()", 1)
        End If
    End Sub

    Private Sub cmdCi_Click(sender As Object, e As EventArgs) Handles cmdCi.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("x=, alpha = 0.05, type = c(""Return.level"", ""parameter""),return.period = 100, which.par, R = 502, ...", 98)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::ci.fevd()", 1)
        End If
    End Sub

    Private Sub cmdDistill_Click(sender As Object, e As EventArgs) Handles cmdDistill.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::distill.fevd(x=, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::distill.fevd()", 1)
        End If
    End Sub

    Private Sub cmdErlevd_Click(sender As Object, e As EventArgs) Handles cmdErlevd.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::erlevd(x=, period = 100)", 15)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::erlevd()", 1)
        End If
    End Sub

    Private Sub cmdFindpars_Click(sender As Object, e As EventArgs) Handles cmdFindpars.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::findpars(x=, use.blocks = FALSE, ..., qcov = NULL)", 39)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::findpars()", 1)
        End If
    End Sub

    Private Sub cmdIsFixedfevd_Click(sender As Object, e As EventArgs) Handles cmdIsFixedfevd.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::is.fixedfevd(x=)", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::is.fixedfevd()", 1)
        End If
    End Sub

    Private Sub cmdLrTest_Click(sender As Object, e As EventArgs) Handles cmdLrTest.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::lr.test(x=, y, alpha = 0.05, df = 1)", 26)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("extRemes::lr.test()", 1)
        End If
    End Sub

    Private Sub OpenHelpPage()
        If Not String.IsNullOrEmpty(strPackageName) Then
            frmMaximiseOutput.Show(strFileName:=clsFileUrlUtilities.GetHelpFileURL(strPackageName:=strPackageName), bReplace:=False)
        End If
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForTestColumn.Clear()
    End Sub


    Private Sub ucrReceiverForTestColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForTestColumn.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForTestColumn.GetVariableNames(False))
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrReceiverForTestColumn.AddtoCombobox(ucrReceiverForTestColumn.GetText)
    End Sub

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverForTestColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub cmdSegmented_Click(sender As Object, e As EventArgs) Handles cmdSegmented.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("segmented::segmented()", 1)
    End Sub

    Private Sub cmdAapc_Click(sender As Object, e As EventArgs) Handles cmdAapc.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("segmented::aapc()", 1)
    End Sub

    Private Sub cmdSegmentedPrint_Click(sender As Object, e As EventArgs) Handles cmdSegmentedPrint.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("print()", 1)
    End Sub

    Private Sub cmdPscore_Click(sender As Object, e As EventArgs) Handles cmdPscore.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("segmented::pscore.test()", 1)
    End Sub

    Private Sub cmdSegmentedSummary_Click(sender As Object, e As EventArgs) Handles cmdSegmentedSummary.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary()", 1)
    End Sub

    Private Sub cmdConfint_Click(sender As Object, e As EventArgs) Handles cmdConfint.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("confint()", 1)
    End Sub

    Private Sub cmdVcov_Click(sender As Object, e As EventArgs) Handles cmdVcov.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("vcov()", 1)
    End Sub

    Private Sub cmdSlope_Click(sender As Object, e As EventArgs) Handles cmdSlope.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("segmented::slope()", 1)
    End Sub

    Private Sub cmdSegmentedPredict_Click(sender As Object, e As EventArgs) Handles cmdSegmentedPredict.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("predict()", 1)
    End Sub

    Private Sub cmdPlotLines_Click(sender As Object, e As EventArgs) Handles cmdPlotLines.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("plot()", 1)
    End Sub

    Private Sub cmdPoints_Click(sender As Object, e As EventArgs) Handles cmdPoints.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("points()", 1)
    End Sub

    Private Sub cmdBroken_Click(sender As Object, e As EventArgs) Handles cmdBroken.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("segmented::broken.line()", 1)
    End Sub

    Private Sub cmdDavies_Click(sender As Object, e As EventArgs) Handles cmdDavies.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("segmented::davies.test()", 1)
    End Sub

    Private Sub cmdIntercept_Click(sender As Object, e As EventArgs) Handles cmdIntercept.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("segmented::intercept()", 1)
    End Sub

    Private Sub cmdRHelpGeneral_Click(sender As Object, e As EventArgs) Handles cmdRHelpGeneral.Click, ToolStripMenuStats.Click
        If ucrInputComboRPackage.GetText = "General" Then
            strPackageName = "stats"
        End If
        OpenHelpPage()
    End Sub

    Private Sub ToolStripCar_Click(sender As Object, e As EventArgs) Handles ToolStripMenuCar.Click
        If ucrInputComboRPackage.GetText = "General" Then
            strPackageName = "car"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelpExtRemes_Click(sender As Object, e As EventArgs) Handles cmdRHelpExtRemes.Click, ToolStripMenuExtRemes.Click
        If ucrInputComboRPackage.GetText = "extRemes" Then
            strPackageName = "extRemes"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelpPrediction_Click(sender As Object, e As EventArgs) Handles cmdRHelpPrediction.Click, ToolStripMenuPrediction.Click
        If ucrInputComboRPackage.GetText = "Prediction" Then
            strPackageName = "prediction"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelpSegmented_Click(sender As Object, e As EventArgs) Handles cmdRHelpSegmented.Click, ToolStripMenuSegmented.Click
        If ucrInputComboRPackage.GetText = "segmented" Then
            strPackageName = "segmented"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdRHelpEmmeans_Click(sender As Object, e As EventArgs) Handles cmdRHelpEmmeans.Click, ToolStripMenuEmmeans.Click
        If ucrInputComboRPackage.GetText = "emmeans" Then
            strPackageName = "emmeans"
        End If
        OpenHelpPage()
    End Sub

    Private Sub cmdEmmeans_Click(sender As Object, e As EventArgs) Handles cmdEmmeans.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::emmeans(obj= , specs =~ , by = NULL )", 24)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::emmeans( , specs =~ )", 12)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdTrends_Click(sender As Object, e As EventArgs) Handles cmdTrends.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::emmeans(obj= , var = )", 9)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::emtrends( , var = )", 9)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdJoint_Click(sender As Object, e As EventArgs) Handles cmdJoint.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::joint_tests(obj= , by = NULL, show0df = FALSE, showconf=TRUE, cov.reduce=make.meanint(1))", 72)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::joint_tests( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdRefgrid_Click(sender As Object, e As EventArgs) Handles cmdRefgrid.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::ref_grid(obj= , cov.reduce = mean)", 20)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::ref_grid( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdEmmeanConfint_Click(sender As Object, e As EventArgs) Handles cmdEmmeanConfint.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("confint(obj= , level = 0.95)", 15)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("confint( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdContrast_Click(sender As Object, e As EventArgs) Handles cmdContrast.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::contrast(obj= )", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::contrast( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdPairs_Click(sender As Object, e As EventArgs) Handles cmdPairs.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("pairs(obj= )", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("pairs( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdEmmeansSummary_Click(sender As Object, e As EventArgs) Handles cmdEmmeansSummary.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary(obj= , infer = c(TRUE, TRUE ), adjust = ""scheffe"")", 45)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("summary( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdTest_Click(sender As Object, e As EventArgs) Handles cmdTest.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::test(obj= , joint = TRUE, verbose = TRUE)", 32)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::test( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdXtable_Click(sender As Object, e As EventArgs) Handles cmdXtable.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("xtable::xtable(obj = , caption = NULL, label = NULL, align = NULL,digits = 4, display = NULL, auto = FALSE)", 85)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("xtable::xtable( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
    End Sub

    Private Sub cmdIntplot_Click(sender As Object, e As EventArgs) Handles cmdIntplot.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::emmip(obj= , formula = ~ , CIs = FALSE, PIs = TRUE, plotit = TRUE)", 55)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::emmip( , formula = ~ )", 15)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Graph, strRObjectFormat:=RObjectFormat.Image)
    End Sub

    Private Sub cmdEmmeansPlot_Click(sender As Object, e As EventArgs) Handles cmdEmmeansPlot.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("plot(obj= , by=NULL, comparisons = TRUE, horizontal = FALSE, colors = ""darkgreen"")", 73)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("plot( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Graph, strRObjectFormat:=RObjectFormat.Image)
    End Sub

    Private Sub cmdpwpp_Click(sender As Object, e As EventArgs) Handles cmdpwpp.Click
        Clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::plot(obj= , method = ""trt.vs.ctrll"", type = ""response"", method = "">"")", 60)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("emmeans::pwpp( )", 1)
        End If
        ucrSaveResult.SetSaveType(strRObjectType:=RObjectTypeLabel.Graph, strRObjectFormat:=RObjectFormat.Image)
    End Sub

    Private Sub cmdQuotes_Click(sender As Object, e As EventArgs) Handles cmdQuotes.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition(" "" """)
    End Sub

    Private Sub cmdcurlySign_Click(sender As Object, e As EventArgs) Handles cmdcurlySign.Click
        ucrReceiverForTestColumn.AddToReceiverAtCursorPosition(" ~ ")
    End Sub

End Class
