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
Public Class dlgStringHandling
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsCountFunction, clsExtractFunction, clsDetectFunction, clsLocateFunction, clsReplaceFunction, clsReplaceAllFunction, clsFixedFunction, clsRegexFunction As New RFunction
    Private Sub dlgStringHandling_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
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
        ucrBase.iHelpTopicID = 406

        'ucrReceiver
        ucrReceiverStringHandling.SetParameter(New RParameter("string", 0))
        ucrReceiverStringHandling.SetParameterIsRFunction()
        ucrReceiverStringHandling.Selector = ucrSelectorStringHandling
        ucrReceiverStringHandling.SetMeAsReceiver()

        'ucrRdoOptions
        ucrPnlStringHandling.AddRadioButton(rdoCount)
        ucrPnlStringHandling.AddRadioButton(rdoExtract)
        ucrPnlStringHandling.AddRadioButton(rdoDetect)
        ucrPnlStringHandling.AddRadioButton(rdoLocate)
        ucrPnlStringHandling.AddRadioButton(rdoReplace)
        ucrPnlStringHandling.AddRadioButton(rdoReplaceAll)

        'ucrRdofixedRegex
        ucrPnlFixedRegex.AddRadioButton(rdoFixed)
        ucrPnlFixedRegex.AddRadioButton(rdoRegex)

        ucrPnlStringHandling.AddFunctionNamesCondition(rdoCount, "str_count")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoExtract, "str_extract")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoDetect, "str_detect")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoLocate, "str_locate")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplace, "str_replace")
        ucrPnlStringHandling.AddFunctionNamesCondition(rdoReplaceAll, "str_replace_all")

        ucrInputPattern.SetParameter(New RParameter("pattern", 1))
        ucrInputReplaceBy.SetParameter(New RParameter("replacement", 2))

        'disabling replaceby input text box
        ucrPnlStringHandling.AddToLinkedControls(ucrInputReplaceBy, {rdoReplace, rdoReplaceAll}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputReplaceBy.SetLinkedDisplayControl(lblReplaceBy)
        ucrChkIncludeRegularExpressions.AddToLinkedControls(ucrPnlFixedRegex, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=rdoFixed)
        ucrPnlFixedRegex.AddToLinkedControls(ucrReceiverForRegexExpression, {rdoRegex}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrSave
        ucrSaveStringHandling.SetPrefix("count")
        ucrSaveStringHandling.SetSaveTypeAsColumn()
        ucrSaveStringHandling.SetDataFrameSelector(ucrSelectorStringHandling.ucrAvailableDataFrames)
        ucrSaveStringHandling.SetIsTextBox()
        ucrSaveStringHandling.SetLabelText("Prefix for New Column:")

        'ucrChkIncludeRegularExpressions
        ucrChkIncludeRegularExpressions.SetText("Include Regular Expressions")
        ucrChkIncludeRegularExpressions.AddFunctionNamesCondition(False, {"fixed", "regex"}, False)

        ucrPnlFixedRegex.AddFunctionNamesCondition(rdoFixed, "fixed")
        ucrPnlFixedRegex.AddFunctionNamesCondition(rdoRegex, "regex")

        'temporary disabling
        grpRegex.Enabled = False
        ucrChkIncludeRegularExpressions.Enabled = False
        'cmdDBackSlah.Visible = False
        'cmdWBackSlash.Visible = False
        'cmdBbackSlash.Visible = False
        'cmdSbackSlash.Visible = False
        'cmdBackSlashb.Visible = False
        'cmdBackSlashw.Visible = False
        'cmdBackSlashs.Visible = False
        'cmdBackSlashd.Visible = False
    End Sub

    Private Sub SetDefaults()
        clsCountFunction = New RFunction
        clsExtractFunction = New RFunction
        clsDetectFunction = New RFunction
        clsLocateFunction = New RFunction
        clsReplaceFunction = New RFunction
        clsReplaceAllFunction = New RFunction
        clsFixedFunction = New RFunction
        clsRegexFunction = New RFunction

        ucrSelectorStringHandling.Reset()

        'temporaryfix
        ucrChkIncludeRegularExpressions.Checked = False
        rdoFixed.Checked = True
        rdoCount.Checked = True
        Visibile()

        ucrInputReplaceBy.Reset()
        ucrSaveStringHandling.Reset()
        ucrInputReplaceBy.SetName("")
        ucrInputPattern.SetName("")
        ucrInputPattern.Reset()
        ucrReceiverForRegexExpression.ResetText()

        clsFixedFunction.SetPackageName("stringr")
        clsFixedFunction.SetRCommand("fixed")
        clsFixedFunction.AddParameter("ignore_case", "FALSE")

        clsRegexFunction.SetPackageName("stringr")
        clsRegexFunction.SetRCommand("regex")
        clsRegexFunction.AddParameter("ignore_case", "TRUE")

        ucrReceiverForRegexExpression.SetText("")
        AddRemoveParameters()

        clsCountFunction.SetPackageName("stringr")
        clsCountFunction.SetRCommand("str_count")
        clsExtractFunction.SetPackageName("stringr")
        clsExtractFunction.SetRCommand("str_extract")
        clsDetectFunction.SetPackageName("stringr")
        clsDetectFunction.SetRCommand("str_detect")
        clsLocateFunction.SetPackageName("stringr")
        clsLocateFunction.SetRCommand("str_locate")
        clsReplaceFunction.SetPackageName("stringr")
        clsReplaceFunction.SetRCommand("str_replace")
        clsReplaceAllFunction.SetPackageName("stringr")
        clsReplaceAllFunction.SetRCommand("str_replace_all")
        ChangePrefixName()
        clsCountFunction.SetAssignTo(ucrSaveStringHandling.GetText, strTempDataframe:=ucrSelectorStringHandling.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveStringHandling.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
        NewColumnName()
        ChangeSize()
    End Sub

    'temporary fix.
    Private Sub Visibile()
        If ucrChkIncludeRegularExpressions.Checked Then
            rdoRegex.Visible = True
            rdoFixed.Visible = True
        Else
            rdoRegex.Visible = False
            rdoFixed.Visible = False
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsDetectFunction, New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsExtractFunction, New RParameter("string", 0), iAdditionalPairNo:=2)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsLocateFunction, New RParameter("string", 0), iAdditionalPairNo:=3)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("string", 0), iAdditionalPairNo:=4)
        ucrReceiverStringHandling.AddAdditionalCodeParameterPair(clsReplaceAllFunction, New RParameter("string", 0), iAdditionalPairNo:=5)

        ucrInputPattern.AddAdditionalCodeParameterPair(clsDetectFunction, New RParameter("pattern", 1), iAdditionalPairNo:=1)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsExtractFunction, New RParameter("pattern", 1), iAdditionalPairNo:=2)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsLocateFunction, New RParameter("pattern", 1), iAdditionalPairNo:=3)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("pattern", 1), iAdditionalPairNo:=4)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsReplaceAllFunction, New RParameter("pattern", 1), iAdditionalPairNo:=5)
        ucrInputPattern.AddAdditionalCodeParameterPair(clsFixedFunction, New RParameter("pattern", 1), iAdditionalPairNo:=6)

        ucrInputReplaceBy.AddAdditionalCodeParameterPair(clsReplaceFunction, New RParameter("replacement", 2), iAdditionalPairNo:=1)

        ucrSaveStringHandling.AddAdditionalRCode(clsDetectFunction, iAdditionalPairNo:=1)
        ucrSaveStringHandling.AddAdditionalRCode(clsExtractFunction, iAdditionalPairNo:=2)
        ucrSaveStringHandling.AddAdditionalRCode(clsLocateFunction, iAdditionalPairNo:=3)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceFunction, iAdditionalPairNo:=4)
        ucrSaveStringHandling.AddAdditionalRCode(clsReplaceAllFunction, iAdditionalPairNo:=5)

        ucrReceiverStringHandling.SetRCode(clsCountFunction, bReset)
        ucrInputPattern.SetRCode(clsCountFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceFunction, bReset)
        ucrInputReplaceBy.SetRCode(clsReplaceAllFunction, bReset)
        'ucrPnlStringHandling.SetRCode(clsCountFunction, bReset)
        ucrSaveStringHandling.SetRCode(clsCountFunction, bReset)
        'ucrChkIncludeRegularExpressions.SetRCode(clsFixedFunction, bReset)
        'ucrPnlFixedRegex.SetRCode(clsFixedFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If (rdoCount.Checked OrElse rdoDetect.Checked OrElse rdoExtract.Checked OrElse rdoLocate.Checked) AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty() Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoReplace.Checked OrElse rdoReplaceAll.Checked) AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputPattern.IsEmpty AndAlso Not ucrInputReplaceBy.IsEmpty Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoCount.Checked OrElse rdoDetect.Checked OrElse rdoExtract.Checked OrElse rdoLocate.Checked) AndAlso ucrChkIncludeRegularExpressions.Checked AndAlso rdoRegex.Checked AndAlso Not ucrReceiverForRegexExpression.IsEmpty AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() Then
            ucrBase.OKEnabled(True)
        ElseIf (rdoReplace.Checked OrElse rdoReplaceAll.Checked) AndAlso ucrChkIncludeRegularExpressions.Checked AndAlso rdoFixed.Checked AndAlso Not ucrReceiverForRegexExpression.IsEmpty AndAlso ucrSaveStringHandling.IsComplete() AndAlso Not ucrReceiverStringHandling.IsEmpty() AndAlso Not ucrInputReplaceBy.IsEmpty Then
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

    Private Sub NewColumnName()
        If rdoLocate.Checked Then
            ucrSaveStringHandling.SetLabelText("Prefix for New Column:")
        Else
            ucrSaveStringHandling.SetLabelText("New Column Name:")
        End If
    End Sub

    Private Sub AddRemoveParameters()
        If ucrChkIncludeRegularExpressions.Checked Then
            If rdoRegex.Checked Then
                clsFixedFunction.RemoveParameterByName("ignore_case")
                clsRegexFunction.AddParameter("ignore_case", "TRUE")
                If Not ucrReceiverForRegexExpression.IsEmpty Then
                    clsRegexFunction.AddParameter("pattern", Chr(34) & ucrReceiverForRegexExpression.GetText & Chr(34))
                    clsCountFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction)
                    clsDetectFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction)
                    clsExtractFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction)
                    clsLocateFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction)
                    clsReplaceFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction)
                    clsReplaceAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsRegexFunction)
                End If
            Else
                clsFixedFunction.AddParameter("ignore_case", "FALSE")
                clsRegexFunction.RemoveParameterByName("ignore_case")
                clsRegexFunction.RemoveParameterByName("pattern")
                clsFixedFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
                clsCountFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
                clsDetectFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
                clsExtractFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
                clsLocateFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
                clsReplaceFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
                clsReplaceAllFunction.AddParameter("pattern", clsRFunctionParameter:=clsFixedFunction)
            End If
        Else
            clsCountFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsDetectFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsExtractFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsLocateFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsReplaceFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
            clsReplaceAllFunction.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))
        End If
    End Sub

    Private Sub ucrPnlStringHandling_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlStringHandling.ControlValueChanged
        If rdoCount.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsCountFunction)
        ElseIf rdoDetect.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDetectFunction)
        ElseIf rdoExtract.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsExtractFunction)
        ElseIf rdoLocate.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsLocateFunction)
        ElseIf rdoReplace.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceFunction)
        ElseIf rdoReplaceAll.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsReplaceAllFunction)
        End If
        NewColumnName()
        ChangePrefixName()
    End Sub

    Private Sub ChangeSize()
        If rdoRegex.Checked Then
            grpRegex.Visible = True
            Me.Size = New Size(685, 390)
        Else
            grpRegex.Visible = False
            Me.Size = New Size(437, 390)
        End If
    End Sub

    Private Sub ChangePrefixName()
        If Not ucrSaveStringHandling.bUserTyped Then
            If rdoCount.Checked Then
                ucrSaveStringHandling.SetPrefix("count")
            ElseIf rdoDetect.Checked Then
                ucrSaveStringHandling.SetPrefix("detect")
            ElseIf rdoExtract.Checked Then
                ucrSaveStringHandling.SetPrefix("extract")
            ElseIf rdoLocate.Checked Then
                ucrSaveStringHandling.SetPrefix("")
                ucrSaveStringHandling.SetName("locate")
            ElseIf rdoReplace.Checked Then
                ucrSaveStringHandling.SetPrefix("replace")
            ElseIf rdoReplaceAll.Checked Then
                ucrSaveStringHandling.SetPrefix("replace_all")
            End If
        End If
        If rdoLocate.Checked Then
            ucrSaveStringHandling.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
        Else
            ucrSaveStringHandling.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
        End If
    End Sub

    Private Sub cmdQuote_Click(sender As Object, e As EventArgs) Handles cmdQuote.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition(" "" ")
    End Sub

    Private Sub cmdSingleQuote_Click(sender As Object, e As EventArgs) Handles cmdSingleQuote.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition(" ' ' ")
    End Sub

    Private Sub cmdOpenClosedBracket_Click(sender As Object, e As EventArgs) Handles cmdOpenClosedBracket.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("[ ] ")
    End Sub

    Private Sub cmdOpenBracketCaretClosedBracket_Click(sender As Object, e As EventArgs) Handles cmdOpenBracketCaretClosedBracket.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("[ ^ ] ")
    End Sub

    Private Sub cmdOpenCloseBrace_Click(sender As Object, e As EventArgs) Handles cmdOpenCloseBrace.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("{ }")
    End Sub

    Private Sub cmdOpenCloseParenthesis_Click(sender As Object, e As EventArgs) Handles cmdOpenCloseParenthesis.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdPlus_Click(sender As Object, e As EventArgs) Handles cmdPlus.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdQuestionMark_Click(sender As Object, e As EventArgs) Handles cmdQuestionMark.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("?")
    End Sub

    Private Sub cmdMultiply_Click(sender As Object, e As EventArgs) Handles cmdMultiply.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition(".")
    End Sub

    Private Sub cmdPower_Click(sender As Object, e As EventArgs) Handles cmdPower.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("^")
    End Sub

    Private Sub cmdDollarSign_Click(sender As Object, e As EventArgs) Handles cmdDollarSign.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("$")
    End Sub

    Private Sub cmdOr_Click(sender As Object, e As EventArgs) Handles cmdOr.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("|,")
    End Sub

    Private Sub cmdBackSlashb_Click(sender As Object, e As EventArgs) Handles cmdBackSlashb.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\b")
    End Sub

    Private Sub cmdBbackSlash_Click(sender As Object, e As EventArgs) Handles cmdBbackSlash.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\B")
    End Sub

    Private Sub cmdBackSlashw_Click(sender As Object, e As EventArgs) Handles cmdBackSlashw.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\w")
    End Sub

    Private Sub cmdWBackSlash_Click(sender As Object, e As EventArgs) Handles cmdWBackSlash.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\W")
    End Sub

    Private Sub cmdBackSlashs_Click(sender As Object, e As EventArgs) Handles cmdBackSlashs.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\s")
    End Sub

    Private Sub cmdSbackSlash_Click(sender As Object, e As EventArgs) Handles cmdSbackSlash.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\S")
    End Sub

    Private Sub cmdBackSlashd_Click(sender As Object, e As EventArgs) Handles cmdBackSlashd.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\d")
    End Sub

    Private Sub cmdDBackSlah_Click(sender As Object, e As EventArgs) Handles cmdDBackSlah.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\D")
    End Sub

    Private Sub cmdBackSlash_Click(sender As Object, e As EventArgs) Handles cmdBackSlash.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("\")
    End Sub

    Private Sub cmdStar_Click(sender As Object, e As EventArgs) Handles cmdStar.Click
        ucrReceiverForRegexExpression.AddToReceiverAtCursorPosition("*")
    End Sub

    Private Sub cmdClear_Click(sender As Object, e As EventArgs) Handles cmdClear.Click
        ucrReceiverForRegexExpression.Clear()
    End Sub

    Private Sub ucrPnlFixedRegex_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlFixedRegex.ControlContentsChanged, ucrChkIncludeRegularExpressions.ControlValueChanged, ucrReceiverForRegexExpression.ControlValueChanged, ucrInputPattern.ControlValueChanged
        Visibile()
        AddRemoveParameters()
        ChangeSize()
    End Sub

    Private Sub ucrReceiverStringHandling_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStringHandling.ControlContentsChanged, ucrPnlStringHandling.ControlContentsChanged, ucrInputPattern.ControlContentsChanged, ucrInputReplaceBy.ControlContentsChanged, ucrReceiverForRegexExpression.ControlContentsChanged, ucrPnlFixedRegex.ControlContentsChanged, ucrChkIncludeRegularExpressions.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class