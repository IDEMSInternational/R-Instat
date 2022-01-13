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

Public Class sdgConstructRegexExpression

    Private Sub sdgConstructRegexExpression_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ttAddKeyboard.SetToolTip(cmdAny1, "Matches any character. For example,str_count(c(""rss"",""r.s.t""),""."") gives 3 5.  Using \\. Gives 0 2")
        ttAddKeyboard.SetToolTip(cmdbegin, "Start of the string. For example, str_count(c(""rss"",""r.s.t""),""^r\\."") gives 0 1")
        ttAddKeyboard.SetToolTip(cmdEnd1, "End of the string. For example, str_count(c(""rss"",""r.s.t""),""s$"") gives 1 0")
        ttAddKeyboard.SetToolTip(cmdDigit, "Digit (0 to 9), For example, str_replace_all(c(""rs5"",""r19s20t""),""[^\\d]"","") gives 5 1920")
        ttAddKeyboard.SetToolTip(cmdSpace, "space. For example. str_remove_all(c(""r ss"",""r s t""),""\\s"") gives ""rss"" ""rst""")
        ttAddKeyboard.SetToolTip(cmdOr1, "or. For example, str_count(c(""rss"", ""rsstt""),""[st]"") gives 2 4")
        ttAddKeyboard.SetToolTip(cmdNot1, "not any. For example, str_remove_all(c(""rs5"",""r19s20t""),""[^\\d]"") gives 5 1920")
        ttAddKeyboard.SetToolTip(cmdOr3, "or. For example, str_count(c(""-abc"",""67""),""-|\\d"") gives 1 2")
        ttAddKeyboard.SetToolTip(cmdOr2, "n times. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]{1}t"") gives 0 1 0 0")
        ttAddKeyboard.SetToolTip(cmdNumbers, "between. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]{0,2}t"") gives 1 1 1 1")
        ttAddKeyboard.SetToolTip(cmdZeroOrOne, "0 or 1 times. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]?t"") gives 1 1 0 0")
        ttAddKeyboard.SetToolTip(cmdPlusOne, "1 or more times. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]+t"") gives 0 1 1 1")
        ttAddKeyboard.SetToolTip(cmdZero, "0 or more times. For example, str_count(c(""bt"",""bat"",""boot"",""boat""),""b[ao]*t"") gives 1 1 1 1")
        ttAddKeyboard.SetToolTip(cmdEscape, "Escape (with +*.? etc). For example, str_detect(c(""b$t"",""bat?"",""3*4""),""[\\?\\$\\*]"") gives TRUE TRUE TRUE")
        ttAddKeyboard.SetToolTip(cmdPlusZero, "range of values. For example, str_count(c(""b$t"",""Bat?""),""[a-zA-Z]"") gives 2 3")
    End Sub

    Public Sub Reset()
        ucrReceiverForRegex.Clear()
    End Sub

    Private Sub cmdAny1_Click(sender As Object, e As EventArgs) Handles cmdAny1.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition(".", 1)
    End Sub

    Private Sub cmdbegin_Click(sender As Object, e As EventArgs) Handles cmdbegin.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("^", 1)
    End Sub

    Private Sub cmdEnd1_Click(sender As Object, e As EventArgs) Handles cmdEnd1.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("$")
    End Sub

    Private Sub cmdDigit_Click(sender As Object, e As EventArgs) Handles cmdDigit.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("\\d")
    End Sub

    Private Sub cmdSpace_Click(sender As Object, e As EventArgs) Handles cmdSpace.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("\\s")
    End Sub

    Private Sub cmdOr1_Click(sender As Object, e As EventArgs) Handles cmdOr1.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("[]", 1)
    End Sub

    Private Sub cmdNot1_Click(sender As Object, e As EventArgs) Handles cmdNot1.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("[^ ]", 3)
    End Sub

    Private Sub cmdOr3_Click(sender As Object, e As EventArgs) Handles cmdOr3.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("|", 1)
    End Sub

    Private Sub cmdOr2_Click(sender As Object, e As EventArgs) Handles cmdOr2.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("{}", 1)
    End Sub

    Private Sub cmdNumbers_Click(sender As Object, e As EventArgs) Handles cmdNumbers.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("{,}", 2)
    End Sub

    Private Sub cmdZeroOrOne_Click(sender As Object, e As EventArgs) Handles cmdZeroOrOne.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("?")
    End Sub

    Private Sub cmdPlusOne_Click(sender As Object, e As EventArgs) Handles cmdPlusOne.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdZero_Click(sender As Object, e As EventArgs) Handles cmdZero.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("+")
    End Sub

    Private Sub cmdEscape_Click(sender As Object, e As EventArgs) Handles cmdEscape.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("\\")
    End Sub

    Private Sub cmdPlusZero_Click(sender As Object, e As EventArgs) Handles cmdPlusZero.Click
        ucrReceiverForRegex.AddToReceiverAtCursorPosition("-")
    End Sub

    Private Sub ucrBaseSubdialog_ClickReturn(sender As Object, e As EventArgs) Handles ucrBaseSubdialog.ClickReturn
        ucrReceiverForRegex.AddtoCombobox(ucrReceiverForRegex.GetText)
    End Sub
End Class