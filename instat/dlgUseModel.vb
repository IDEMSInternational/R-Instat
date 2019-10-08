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
    Private clsAttach, clsDetach As New RFunction
    Public bFirstLoad As Boolean = True
    Public bReset As Boolean = True
    Public bUpdating As Boolean = False

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
        ucrReceiverForTestColumn.SetParameterIsRFunction()
        ucrReceiverForTestColumn.SetItemType("model")
        ucrReceiverForTestColumn.strSelectorHeading = "Models"
        ucrReceiverForTestColumn.Selector = ucrSelectorUseModel
        ucrReceiverForTestColumn.SetMeAsReceiver()

        ucrInputComboRPackage.SetItems({"General", "Prediction", "extRemes"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()

        ucrChkIncludeArguments.SetText("Show Arguments")

        ucrInputModels.IsReadOnly = True

        bUpdating = False
    End Sub

    Private Sub SetDefaults()
        ' ucrBase.iHelpTopicID = 379
        clsAttach = New RFunction
        clsDetach = New RFunction

        ucrBase.clsRsyntax.ClearCodes()

        ucrSelectorUseModel.Reset()

        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrReceiverForTestColumn.Clear()

        ucrInputComboRPackage.SetName("General")

        ucrChkIncludeArguments.Checked = False
        ucrInputTryMessage.txtInput.BackColor = SystemColors.Window

        ucrBase.clsRsyntax.SetCommandString("")

        clsAttach.SetRCommand("attach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorUseModel.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        clsDetach.SetRCommand("detach")
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorUseModel.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsDetach.AddParameter("unload", "TRUE", iPosition:=1)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsAttach, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsDetach, 1000)
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetCommandString("")
        ucrBase.clsRsyntax.iCallType = 2
        KeyboardsVisibility()
        GetModels()
        TestOkEnabled()
    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles cmdTry.Click
        TryScript()
    End Sub

    Private Sub TryScript()
        Dim strOutPut As String
        Dim strAttach As String
        Dim strDetach As String
        Dim strTempScript As String = ""
        Dim strVecOutput As CharacterVector
        Dim clsCommandString As RCodeStructure

        Try
            If ucrReceiverForTestColumn.IsEmpty Then
                ucrInputTryMessage.SetName("")
            Else
                'get strScript here
                strAttach = clsAttach.Clone().ToScript(strTempScript)
                frmMain.clsRLink.RunInternalScript(strTempScript & strAttach, bSilent:=True)
                strTempScript = ""
                clsCommandString = ucrBase.clsRsyntax.clsBaseCommandString.Clone()
                clsCommandString.RemoveAssignTo()
                strOutPut = clsCommandString.ToScript(strTempScript, ucrBase.clsRsyntax.strCommandString)
                strVecOutput = frmMain.clsRLink.RunInternalScriptGetOutput(strTempScript & strOutPut, bSilent:=True)
                If strVecOutput IsNot Nothing Then
                    If strVecOutput.Length > 1 Then
                        ucrInputTryMessage.SetName("Model runs without error")
                        ucrInputTryMessage.txtInput.BackColor = Color.LightGreen
                    End If
                Else
                    ucrInputTryMessage.SetName("Command produced an error or no output to display.")
                    ucrInputTryMessage.txtInput.BackColor = Color.LightCoral
                End If
            End If
        Catch ex As Exception
            ucrInputTryMessage.SetName("Command produced an error. Modify input before running.")
            ucrInputTryMessage.txtInput.BackColor = Color.LightCoral
        Finally
            strTempScript = ""
            strDetach = clsDetach.Clone().ToScript(strTempScript)
            frmMain.clsRLink.RunInternalScript(strTempScript & strDetach, bSilent:=True)
        End Try
    End Sub

    Private Sub SetRcodeForControls(bReset As Object)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverForTestColumn.IsEmpty Then
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
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("residuals(object, ...)", 6)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("residuals()", 1)
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
        Select Case ucrInputComboRPackage.GetText
            Case "General"
                grpGeneral.Visible = True
            Case "Prediction"
                grpPrediction.Visible = True
            Case "extRemes"
                grpExtrRemes.Visible = True
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

        ucrBase.clsRsyntax.lstBeforeCodes.Clear()
        clsGetModel.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_models")
        ucrInputModels.SetName("[No models selected]")
        strExpression = ucrReceiverForTestColumn.GetVariableNames(False)
        For Each item In ucrSelectorUseModel.lstAvailableVariable.Items
            strModel = item.Text
            If strExpression.Contains(strModel) Then
                lstModels.Add(strModel)
                clsGetModel.AddParameter("data_name", Chr(34) & ucrSelectorUseModel.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
                clsGetModel.AddParameter("model_name", Chr(34) & strModel & Chr(34), iPosition:=1)
                clsGetModel.SetAssignTo(strModel)
                ucrBase.clsRsyntax.AddToBeforeCodes(clsGetModel.Clone(), iPosition:=i)
                i = i + 1
            End If
        Next
        If i > 0 Then
            ucrInputModels.SetName(String.Join(", ", lstModels))
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

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction
        Dim strPackageName As String

        strPackageName = ucrInputComboRPackage.GetText
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("package", Chr(34) & strPackageName & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for" & " " & strPackageName & " " & "Package. Generated from dialog Modelling", iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub ucrReceiverForTestColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForTestColumn.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForTestColumn.GetVariableNames(False))
        ucrInputTryMessage.SetName("")
        cmdTry.Enabled = Not ucrReceiverForTestColumn.IsEmpty()
        ucrInputTryMessage.txtInput.BackColor = SystemColors.Window
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        ucrReceiverForTestColumn.AddtoCombobox(ucrReceiverForTestColumn.GetText)
    End Sub

End Class