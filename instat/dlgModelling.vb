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
        ucrSaveResult.SetPrefix("Model")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetCheckBoxText("Save Model")
        ucrSaveResult.SetAssignToIfUncheckedValue("Last_Model")
        ucrSaveResult.SetDataFrameSelector(ucrSelectorModelling.ucrAvailableDataFrames)

        ucrInputComboRPackage.SetItems({"Stats", "extRemes", "lme4", "MASS"})
        ucrInputComboRPackage.SetDropDownStyleAsNonEditable()

    End Sub

    Private Sub SetDefaults()
        ucrSelectorModelling.Reset()
        ucrReceiverForTestColumn.SetMeAsReceiver()
        ucrSaveResult.Reset()
        ucrSaveResult.ucrChkSave.Checked = False
        ucrBase.clsRsyntax.SetAssignTo("Last_Model", strTempModel:="Last_Model", strTempDataframe:=ucrSelectorModelling.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 2
        ucrChkIncludeArguments.Checked = False
        ucrInputComboRPackage.SetName("Stats")

    End Sub

    Private Sub SetRCodeForControls(bReset)

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

    'stats
    Private Sub cmdaov_Click(sender As Object, e As EventArgs) Handles cmdaov.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("aov( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("aov( )", 1)
        End If
    End Sub

    Private Sub cmdar_Click(sender As Object, e As EventArgs) Handles cmdar.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ar( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("ar( )", 1)
        End If
    End Sub

    Private Sub cmdarima_Click(sender As Object, e As EventArgs) Handles cmdarima.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arima( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("arima( )", 1)
        End If
    End Sub

    Private Sub cmdglm_Click(sender As Object, e As EventArgs) Handles cmdglm.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm( )", 1)
        End If
    End Sub

    Private Sub cmdlm_Click(sender As Object, e As EventArgs) Handles cmdlm.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lm( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lm( )", 1)
        End If
    End Sub

    Private Sub cmdloess_Click(sender As Object, e As EventArgs) Handles cmdloess.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loess( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loess( )", 1)
        End If
    End Sub

    Private Sub cmdlowess_Click(sender As Object, e As EventArgs) Handles cmdlowess.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lowess( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lowess( )", 1)
        End If
    End Sub

    Private Sub cmdloglin_Click(sender As Object, e As EventArgs) Handles cmdloglin.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglin( )", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglin( )", 1)
        End If
    End Sub

    Private Sub cmdspline_Click(sender As Object, e As EventArgs) Handles cmdspline.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("spline( )", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("spline( )", 1)
        End If
    End Sub

    'extRemes
    Private Sub cmdfevd_Click(sender As Object, e As EventArgs) Handles cmdfevd.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("fevd( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("fevd( )", 1)
        End If
    End Sub

    Private Sub cmdlevd_Click(sender As Object, e As EventArgs) Handles cmdlevd.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("levd( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("levd( )", 1)
        End If
    End Sub

    'lmer4
    Private Sub cmdglmer_Click(sender As Object, e As EventArgs) Handles cmdglmer.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glmer( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glmer( )", 1)
        End If
    End Sub

    Private Sub cmdlmer_Click(sender As Object, e As EventArgs) Handles cmdlmer.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lmer( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("lmer( )", 1)
        End If
    End Sub

    Private Sub cmdnlmer_Click(sender As Object, e As EventArgs) Handles cmdnlmer.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("nlmer( )", 1)
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("nlmer( )", 1)
        End If
    End Sub

    'MASS
    Private Sub cmdglmmPQL_Click(sender As Object, e As EventArgs) Handles cmdglmmPQL.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glmPQL( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glmPQL( )", 1)
        End If
    End Sub

    Private Sub cmdglmnb_Click(sender As Object, e As EventArgs) Handles cmdglmnb.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm.nb( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("glm.nb( )", 1)
        End If
    End Sub

    Private Sub cmdloglm_Click(sender As Object, e As EventArgs) Handles cmdloglm.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglm( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("loglm( )", 1)
        End If
    End Sub

    Private Sub cmdpolr_Click(sender As Object, e As EventArgs) Handles cmdpolr.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("polr( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("polr( )", 1)
        End If
    End Sub

    Private Sub cmdrlm_Click(sender As Object, e As EventArgs) Handles cmdrlm.Click
        clear()
        If ucrChkIncludeArguments.Checked Then
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("rlm( )")
        Else
            ucrReceiverForTestColumn.AddToReceiverAtCursorPosition("rlm( )", 1)
        End If
    End Sub

    'FirstCalc

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

    End Sub

    Private Sub cmdPredict_Click(sender As Object, e As EventArgs) Handles cmdPredict.Click

    End Sub

    Private Sub cmdTry_Click(sender As Object, e As EventArgs) Handles cmdTry.Click

    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("package", Chr(34) & strPackageName & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for" & " " & strPackageName & " " & "Package. Generated from dialog Hypothesis Tests", iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub clear()
        ucrReceiverForTestColumn.Clear()
    End Sub

    Private Sub ucrInputComboRPackage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboRPackage.ControlValueChanged
        Select Case ucrInputComboRPackage.GetText
            Case "Stats"
                strPackageName = "stat"
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

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverForTestColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class