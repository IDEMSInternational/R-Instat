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
Public Class dlgModelling
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private strPackageName As String
    Private clsAttach, clsDetach As New RFunction
    Private Sub dlgModelling_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverForTestColumn.Selector = ucrSelectorModelling
        ucrReceiverMultiple.Selector = ucrSelectorModelling
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrChkIncludeArguments.SetText("Include Arguments")
        ucrBase.clsRsyntax.SetCommandString("")
        ucrSaveResult.SetPrefix("model")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Save Model")
        ucrSaveResult.SetAssignToIfUncheckedValue("last_model")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorModelling.ucrAvailableDataFrames)

        ucrInputComboRPackage.SetItems({"stats", "extRemes", "lme4", "MASS"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()

        clsAttach.SetRCommand("attach")
        clsDetach.SetRCommand("detach")
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorModelling.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("name", clsRFunctionParameter:=ucrSelectorModelling.ucrAvailableDataFrames.clsCurrDataFrame)
        clsDetach.AddParameter("unload", "TRUE")
    End Sub

    Private Sub SetDefaults()
        ucrSelectorModelling.Reset()
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrSaveResult.Reset()
        ucrSaveResult.ucrChkSave.Checked = False
        ucrBase.clsRsyntax.SetAssignTo("last_model", strTempModel:="last_model", strTempDataframe:=ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        ucrChkIncludeArguments.Checked = False
        ucrInputComboRPackage.SetName("stats")
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
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdaov_Click(sender As Object, e As EventArgs) Handles cmdaov.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("aov(formula = , data = NULL, projections = FALSE, qr = TRUE, contrasts = NULL))", 64)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("aov()", 1)
        End If
    End Sub

    Private Sub cmdar_Click(sender As Object, e As EventArgs) Handles cmdar.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ar()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ar()", 1)
        End If
    End Sub

    Private Sub cmdarima_Click(sender As Object, e As EventArgs) Handles cmdarima.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arima()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arima()", 1)
        End If
    End Sub

    Private Sub cmdglm_Click(sender As Object, e As EventArgs) Handles cmdglm.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm()", 1)
        End If
    End Sub

    Private Sub cmdlm_Click(sender As Object, e As EventArgs) Handles cmdlm.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lm()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lm()", 1)
        End If
    End Sub

    Private Sub cmdloess_Click(sender As Object, e As EventArgs) Handles cmdloess.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loess()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loess()", 1)
        End If
    End Sub

    Private Sub cmdlowess_Click(sender As Object, e As EventArgs) Handles cmdlowess.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lowess()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lowess()", 1)
        End If
    End Sub

    Private Sub cmdloglin_Click(sender As Object, e As EventArgs) Handles cmdloglin.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglin()", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglin()", 1)
        End If
    End Sub

    Private Sub cmdspline_Click(sender As Object, e As EventArgs) Handles cmdspline.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("spline()", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("spline()", 1)
        End If
    End Sub

    Private Sub cmdfevd_Click(sender As Object, e As EventArgs) Handles cmdfevd.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("fevd()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("fevd()", 1)
        End If
    End Sub

    Private Sub cmdlevd_Click(sender As Object, e As EventArgs) Handles cmdlevd.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("levd()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("levd()", 1)
        End If
    End Sub

    Private Sub cmdglmer_Click(sender As Object, e As EventArgs) Handles cmdglmer.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glmer()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glmer()", 1)
        End If
    End Sub

    Private Sub cmdlmer_Click(sender As Object, e As EventArgs) Handles cmdlmer.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lmer()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lmer()", 1)
        End If
    End Sub

    Private Sub cmdnlmer_Click(sender As Object, e As EventArgs) Handles cmdnlmer.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("nlmer()", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("nlmer()", 1)
        End If
    End Sub

    Private Sub cmdglmmPQL_Click(sender As Object, e As EventArgs) Handles cmdglmmPQL.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glmPQL()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glmPQL()", 1)
        End If
    End Sub

    Private Sub cmdglmnb_Click(sender As Object, e As EventArgs) Handles cmdglmnb.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm.nb()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm.nb()", 1)
        End If
    End Sub

    Private Sub cmdloglm_Click(sender As Object, e As EventArgs) Handles cmdloglm.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglm()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglm()", 1)
        End If
    End Sub

    Private Sub cmdpolr_Click(sender As Object, e As EventArgs) Handles cmdpolr.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("polr()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("polr()", 1)
        End If
    End Sub

    Private Sub cmdrlm_Click(sender As Object, e As EventArgs) Handles cmdrlm.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("rlm()")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("rlm()", 1)
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

    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles cmdTry.Click
        TryScript()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("package", Chr(34) & strPackageName & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for" & " " & strPackageName & " " & "Package. Generated from dialog Modelling", iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub clear()
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub ucrInputComboRPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboRPackage.ControlValueChanged
        Select Case ucrInputComboRPackage.GetText
            Case "stats"
                strPackageName = "stats"
                grpStats.Visible = True
                grpextRemes.Visible = False
                grplme4.Visible = False
                grpMASS.Visible = False

            Case "extRemes"
                strPackageName = "extRemes"
                grpStats.Visible = False
                grpextRemes.Visible = True
                grplme4.Visible = False
                grpMASS.Visible = False

            Case "lme4"
                strPackageName = "lme4"
                grpStats.Visible = False
                grpextRemes.Visible = False
                grplme4.Visible = True
                grpMASS.Visible = False

            Case "MASS"
                strPackageName = "MASS"
                grpStats.Visible = False
                grpextRemes.Visible = False
                grplme4.Visible = False
                grpMASS.Visible = True
        End Select
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        ucrSaveResult.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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

            ucrBase.clsRsyntax.SetstrAssignToColumn(strAssignToColumn)
            ucrBase.clsRsyntax.SetstrAssignToDataFrame(strAssignToDataFrame)
        End Try
    End Sub

    Private Sub ucrReceiverForTestColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForTestColumn.SelectionChanged
        ucrBase.clsRsyntax.SetCommandString(ucrReceiverForTestColumn.GetVariableNames(False))
        ucrInputTryMessage.SetName("")
        cmdTry.Enabled = Not ucrReceiverForTestColumn.IsEmpty()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        clsAttach.AddParameter("what", clsRFunctionParameter:=ucrSelectorModelling.ucrAvailableDataFrames.clsCurrDataFrame)
        strFunc = clsAttach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
        ucrBase.clsRsyntax.SetAssignTo(ucrSaveResult.GetText(), strTempModel:=ucrSaveResult.GetText(), strTempDataframe:=ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String = ""
        Dim strFunc As String
        strFunc = clsDetach.ToScript(strScript)
        frmMain.clsRLink.RunScript(strScript & strFunc)
    End Sub

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverForTestColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class