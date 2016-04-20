' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations

Public Class dlgTransformText
    Public bFirstLoad As Boolean = True
    Private Sub dlgTransformText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False

        Else
            ReopenDialog()
        End If
        TestOkEnabled()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverTransformText.Selector = ucrSelectorForTransformText
        ucrReceiverOrColumn.Selector = ucrSelectorForTransformText
        ucrReceiverLastWord.Selector = ucrSelectorForTransformText
        ucrReceiverTransformText.SetMeAsReceiver()
        ucrBase.clsRsyntax.bUseBaseFunction = True
        ucrInputTo.cboInput.Items.Add("Lower")
        ucrInputTo.cboInput.Items.Add("Upper")
        ucrInputTo.cboInput.Items.Add("Title")
        ucrInputPad.cboInput.Items.Add("Space")
        ucrInputPad.cboInput.Items.Add("Hash")
        ucrInputPad.cboInput.Items.Add("Hyphen")
        ucrInputPad.cboInput.Items.Add("Period")
        ucrInputPad.cboInput.Items.Add("Underscore")
        ucrInputSeparator.cboInput.Items.Add("Space")
        ucrInputSeparator.cboInput.Items.Add("Period")
        ucrInputSeparator.cboInput.Items.Add("Colon")
        ucrInputSeparator.cboInput.Items.Add("Underscore")
        ucrInputSeparator.cboInput.Items.Add("Hyphen")
        ucrInputPad.cboInput.MaxLength = 1
        ucrInputPrefixForNewColumn.SetPrefix("New_Text")
        ucrInputPrefixForNewColumn.SetItemsTypeAsColumns()
        ucrInputPrefixForNewColumn.SetDefaultTypeAsColumn()
        ucrInputPrefixForNewColumn.SetDataFrameSelector(ucrSelectorForTransformText.ucrAvailableDataFrames)
        ucrReceiverOrColumn.SetDataType("numeric")
        ucrReceiverTransformText.SetDataType("factor")

    End Sub

    Private Sub SetDefaults()
        rdoConvertCase.Checked = True
        ucrSelectorForTransformText.Reset()
        ucrSelectorForTransformText.Focus()
        ucrInputPrefixForNewColumn.ResetText()
        ucrInputSeparator.ResetText()
        ucrInputPad.ResetText()
        ucrInputTo.ResetText()
        rdoWords.Checked = False
        rdoLeftTrim.Checked = True
        rdoLeft.Checked = True
        rdoTrim.Checked = False
        rdoPad.Checked = False
        rdoLength.Checked = False
        nudFrom.Value = 1
        nudTo.Value = -1
        nudWidth.Value = 1
        ucrInputTo.SetName("Lower")
        ucrInputSeparator.SetName("Space")
        ucrInputPad.SetName("Space")
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverTransformText.IsEmpty()) And (Not ucrInputPrefixForNewColumn.IsEmpty()) Then
            If rdoConvertCase.Checked Then
                If Not ucrInputTo.IsEmpty() Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(True)
                End If
            ElseIf rdoLength.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoPad.Checked Then

            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverTransformText_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverTransformText.SelectionChanged
        If Not ucrReceiverTransformText.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("string", clsRFunctionParameter:=ucrReceiverTransformText.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("string")
        End If
        TestOkEnabled()
    End Sub

    Private Sub grpOperation_CheckedChanged(sender As Object, e As EventArgs) Handles rdoConvertCase.CheckedChanged, rdoLength.CheckedChanged, rdoPad.CheckedChanged, rdoTrim.CheckedChanged, rdoWords.CheckedChanged, rdoSubstring.CheckedChanged
        SetFuncAndParameters()
        TestOkEnabled()
    End Sub
    Private Sub SetFuncAndParameters()

        If rdoConvertCase.Checked Then
            ConvertcaseFunc()
            ucrInputTo.Visible = True
            lblTo.Visible = True
            lblFirstWord.Visible = False
            nudFirstWord.Visible = False
            chkOrColumn.Visible = False
            lblLastWord.Visible = False
            nudLastWord.Visible = False
            ucrInputSeparator.Visible = False
            lblSeparator.Visible = False
            ucrReceiverOrColumn.Visible = False
            lblWidth.Visible = False
            nudWidth.Visible = False
            lblPad.Visible = False
            ucrInputPad.Visible = False
            rdoBoth.Visible = False
            rdoRight.Visible = False
            rdoLeft.Visible = False
            rdoLeftTrim.Visible = False
            rdoRightTrim.Visible = False
            rdoBothTrim.Visible = False
            lblFrom.Visible = False
            lblToSubstring.Visible = False
            nudFrom.Visible = False
            nudTo.Visible = False
            ucrReceiverLastWord.Visible = False
            chkOrColumnL.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("pad")
            ucrBase.clsRsyntax.RemoveParameter("width")
            ucrBase.clsRsyntax.RemoveParameter("side")
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
            ucrBase.clsRsyntax.RemoveParameter("sep")

        ElseIf rdoLength.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_length")
            lblWidth.Visible = False
            nudWidth.Visible = False
            lblPad.Visible = False
            ucrInputPad.Visible = False
            ucrInputTo.Visible = False
            lblTo.Visible = False
            lblFirstWord.Visible = False
            nudFirstWord.Visible = False
            chkOrColumn.Visible = False
            lblLastWord.Visible = False
            nudLastWord.Visible = False
            ucrInputSeparator.Visible = False
            lblSeparator.Visible = False
            rdoBoth.Visible = False
            rdoRight.Visible = False
            rdoLeft.Visible = False
            rdoLeftTrim.Visible = False
            rdoRightTrim.Visible = False
            rdoBothTrim.Visible = False
            lblFrom.Visible = False
            lblToSubstring.Visible = False
            nudFrom.Visible = False
            nudTo.Visible = False
            chkOrColumnL.Visible = False
            ucrReceiverLastWord.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("pad")
            ucrBase.clsRsyntax.RemoveParameter("width")
            ucrBase.clsRsyntax.RemoveParameter("side")
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
            ucrBase.clsRsyntax.RemoveParameter("sep")

        ElseIf rdoPad.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_pad")
            PadSideParameter()
            SeperatorParameter()
            WidthParameter()
            nudWidth.Visible = True
            lblWidth.Visible = True
            lblPad.Visible = True
            ucrInputPad.Visible = True
            ucrInputTo.Visible = False
            lblTo.Visible = False
            lblFirstWord.Visible = False
            nudFirstWord.Visible = False
            chkOrColumn.Visible = False
            lblLastWord.Visible = False
            nudLastWord.Visible = False
            ucrInputSeparator.Visible = False
            lblSeparator.Visible = False
            rdoBoth.Visible = True
            rdoRight.Visible = True
            rdoLeft.Visible = True
            rdoLeftTrim.Visible = False
            rdoRightTrim.Visible = False
            rdoBothTrim.Visible = False
            lblFrom.Visible = False
            lblToSubstring.Visible = False
            nudFrom.Visible = False
            nudTo.Visible = False
            chkOrColumnL.Visible = False
            ucrReceiverLastWord.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
            ucrBase.clsRsyntax.RemoveParameter("sep")

        ElseIf rdoTrim.Checked Then
            TrimSideParameter()
            lblWidth.Visible = False
            nudWidth.Visible = False
            lblPad.Visible = False
            ucrInputPad.Visible = False
            ucrInputTo.Visible = False
            lblTo.Visible = False
            lblFirstWord.Visible = False
            nudFirstWord.Visible = False
            chkOrColumn.Visible = False
            lblLastWord.Visible = False
            nudLastWord.Visible = False
            ucrInputSeparator.Visible = False
            lblSeparator.Visible = False
            rdoBoth.Visible = False
            rdoRight.Visible = False
            rdoLeft.Visible = False
            rdoLeftTrim.Visible = True
            rdoRightTrim.Visible = True
            rdoBothTrim.Visible = True
            lblFrom.Visible = False
            lblToSubstring.Visible = False
            nudFrom.Visible = False
            nudTo.Visible = False
            chkOrColumnL.Visible = False
            ucrReceiverLastWord.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("pad")
            ucrBase.clsRsyntax.RemoveParameter("width")
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
            ucrBase.clsRsyntax.RemoveParameter("sep")

        ElseIf rdoWords.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::word")
            WordSepParameter()
            lblFirstWord.Visible = True
            nudFirstWord.Visible = True
            chkOrColumn.Visible = True
            lblLastWord.Visible = True
            nudLastWord.Visible = True
            ucrInputSeparator.Visible = True
            lblSeparator.Visible = True
            lblWidth.Visible = False
            nudWidth.Visible = False
            lblPad.Visible = False
            ucrInputPad.Visible = False
            ucrInputTo.Visible = False
            lblTo.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("pad")
            ucrBase.clsRsyntax.RemoveParameter("width")
            ucrBase.clsRsyntax.RemoveParameter("side")
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
            rdoBoth.Visible = False
            rdoRight.Visible = False
            rdoLeft.Visible = False
            rdoLeftTrim.Visible = False
            rdoRightTrim.Visible = False
            rdoBothTrim.Visible = False
            lblFrom.Visible = False
            lblToSubstring.Visible = False
            nudFrom.Visible = False
            nudTo.Visible = False
            chkOrColumnL.Visible = True
            ucrReceiverLastWord.Visible = False

        ElseIf rdoSubstring.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_sub")
            nudToParameter()
            NudFromParameter()
            lblFirstWord.Visible = False
            nudFirstWord.Visible = False
            chkOrColumn.Visible = False
            lblLastWord.Visible = False
            nudLastWord.Visible = False
            ucrInputSeparator.Visible = False
            lblSeparator.Visible = False
            lblWidth.Visible = False
            nudWidth.Visible = False
            lblPad.Visible = False
            ucrInputPad.Visible = False
            ucrInputTo.Visible = False
            lblTo.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("width")
            ucrBase.clsRsyntax.RemoveParameter("side")
            ucrBase.clsRsyntax.RemoveParameter("pad")
            ucrBase.clsRsyntax.RemoveParameter("sep")
            rdoBoth.Visible = False
            rdoRight.Visible = False
            rdoLeft.Visible = False
            rdoLeftTrim.Visible = False
            rdoRightTrim.Visible = False
            rdoBothTrim.Visible = False
            lblFrom.Visible = True
            lblToSubstring.Visible = True
            nudFrom.Visible = True
            nudTo.Visible = True
            chkOrColumnL.Visible = False
            ucrReceiverLastWord.Visible = False
        Else
        End If
    End Sub

    Private Sub ucrReceiverOrColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverOrColumn.SelectionChanged
        If rdoWords.Checked Then
            If chkOrColumn.Checked Then
                If Not ucrReceiverOrColumn.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("start", clsRFunctionParameter:=ucrReceiverOrColumn.GetVariables())
                Else
                    ucrBase.clsRsyntax.RemoveParameter("start")
                End If
                End If
            End If
        TestOkEnabled()
    End Sub

    Private Sub ucrInputTo_NameChanged() Handles ucrInputTo.NameChanged
        ConvertcaseFunc()
    End Sub

    Private Sub ConvertcaseFunc()
        If rdoConvertCase.Checked Then
            Select Case ucrInputTo.GetText
                Case "Lower"
                    ucrBase.clsRsyntax.SetFunction("stringr::str_to_lower")
                Case "Upper"
                    ucrBase.clsRsyntax.SetFunction("stringr::str_to_upper")
                Case "Title"
                    ucrBase.clsRsyntax.SetFunction("stringr::str_to_title")
            End Select
        End If
    End Sub

    Private Sub nudWidth_TextChanged(sender As Object, e As EventArgs) Handles nudWidth.TextChanged
        WidthParameter()
    End Sub

    Private Sub WidthParameter()
        If rdoPad.Checked Then
            If rdoBoth.Checked Or rdoLeft.Checked Or rdoRight.Checked Then
                ucrBase.clsRsyntax.AddParameter("width", nudWidth.Value)
            Else
                ucrBase.clsRsyntax.RemoveParameter("width")
            End If
        End If
    End Sub

    Private Sub ucrInputPad_NameChanged() Handles ucrInputPad.NameChanged
        SeperatorParameter()
    End Sub

    Private Sub SeperatorParameter()
        If rdoPad.Checked Then
            If rdoRight.Checked Or rdoLeft.Checked Or rdoBoth.Checked Then
                Select Case ucrInputPad.GetText
                    Case "Space"
                        ucrBase.clsRsyntax.AddParameter("pad", Chr(34) & " " & Chr(34))
                    Case "Hash"
                        ucrBase.clsRsyntax.AddParameter("pad", Chr(34) & "#" & Chr(34))
                    Case "Hyphen"
                        ucrBase.clsRsyntax.AddParameter("pad", Chr(34) & "-" & Chr(34))
                    Case "Period"
                        ucrBase.clsRsyntax.AddParameter("pad", Chr(34) & "." & Chr(34))
                    Case "Underscore"
                        ucrBase.clsRsyntax.AddParameter("pad", Chr(34) & "_" & Chr(34))
                    Case Else
                        ucrBase.clsRsyntax.AddParameter("pad", Chr(34) & ucrInputPad.GetText & Chr(34))
                End Select
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("pad")
        End If
    End Sub

    Private Sub nudFirstWord_TextChanged(sender As Object, e As EventArgs) Handles nudFirstWord.TextChanged
        If rdoWords.Checked Then
            ucrBase.clsRsyntax.AddParameter("start", nudFirstWord.Value)
        Else
            ucrBase.clsRsyntax.RemoveParameter("start")
        End If
    End Sub

    Private Sub nudLastWord_TextChanged(sender As Object, e As EventArgs) Handles nudLastWord.TextChanged
        If rdoWords.Checked Then
            ucrBase.clsRsyntax.AddParameter("end", nudLastWord.Value)
        Else
            ucrBase.clsRsyntax.RemoveParameter("end")
        End If
    End Sub

    Private Sub ucrInputSeparator_NameChanged() Handles ucrInputSeparator.NameChanged
        WordSepParameter()
    End Sub

    Private Sub WordSepParameter()
        If rdoWords.Checked Then
            Select Case ucrInputSeparator.GetText
                Case "Space"
                    ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & " " & Chr(34))
                Case "Period"
                    ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "." & Chr(34))
                Case "Colon"
                    ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & ":" & Chr(34))
                Case "Underscore"
                    ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "_" & Chr(34))
                Case Else
                    ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & ucrInputSeparator.GetText & Chr(34))
            End Select
        Else
            ucrBase.clsRsyntax.RemoveParameter("sep")
        End If
    End Sub

    Private Sub chkOrColumn_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrColumn.CheckedChanged
        If rdoWords.Checked Then
            If chkOrColumn.Checked Then
                ucrInputTo.Visible = False
                ucrReceiverOrColumn.SetMeAsReceiver()
                lblTo.Visible = False
                nudFirstWord.Enabled = False
                chkOrColumn.Visible = True
                ucrInputSeparator.Visible = True
                lblSeparator.Visible = True
                ucrReceiverOrColumn.Visible = True
                lblWidth.Visible = False
                nudWidth.Visible = False
                lblPad.Visible = False
                ucrInputPad.Visible = False
                ucrBase.clsRsyntax.RemoveParameter("pad")
                ucrBase.clsRsyntax.RemoveParameter("width")
                ucrBase.clsRsyntax.RemoveParameter("side")

            ElseIf chkOrColumn.Checked = False
                ucrBase.clsRsyntax.RemoveParameter("first")
                ucrReceiverOrColumn.Visible = False
                nudFirstWord.Enabled = True
                ucrReceiverTransformText.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub SideParameter_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLeft.CheckedChanged, rdoRight.CheckedChanged, rdoBoth.CheckedChanged
        PadSideParameter()
    End Sub

    Private Sub PadSideParameter()
        If rdoPad.Checked Then
            If rdoLeft.Checked Then
                ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "left" & Chr(34))
            ElseIf rdoRight.Checked Then
                ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "right" & Chr(34))
            ElseIf rdoBoth.Checked Then
                ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "both" & Chr(34))
            Else
                ucrBase.clsRsyntax.RemoveParameter("side")
            End If
        End If
    End Sub

    Private Sub TrimFunction_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLeftTrim.CheckedChanged, rdoRightTrim.CheckedChanged, rdoBothTrim.CheckedChanged
        TrimSideParameter()
    End Sub

    Private Sub TrimSideParameter()
        If rdoTrim.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_trim")
            If rdoLeftTrim.Checked Then
                ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "left" & Chr(34))
            ElseIf rdoRightTrim.Checked Then
                ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "right" & Chr(34))
            ElseIf rdoBothTrim.Checked Then
                ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "both" & Chr(34))
            Else
                ucrBase.clsRsyntax.RemoveParameter("side")
            End If
        End If
    End Sub

    Private Sub nudFrom_TextCanged(sender As Object, e As EventArgs) Handles nudFrom.TextChanged
        NudFromParameter()
    End Sub

    Private Sub NudFromParameter()
        If rdoSubstring.Checked Then
            ucrBase.clsRsyntax.AddParameter("start", nudFrom.Value)
        Else
            ucrBase.clsRsyntax.RemoveParameter("start")
        End If
    End Sub

    Private Sub nudTo_TextChanged(sender As Object, e As EventArgs) Handles nudTo.TextChanged
        nudToParameter()
    End Sub

    Private Sub nudToParameter()
        If rdoSubstring.Checked Then
            ucrBase.clsRsyntax.AddParameter("end", nudTo.Value)
        Else
            ucrBase.clsRsyntax.RemoveParameter("end")
        End If
    End Sub

    Private Sub ucrInputPrefixForNewColumn_NameChanged() Handles ucrInputPrefixForNewColumn.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputPrefixForNewColumn.GetText, strTempDataframe:=ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputPrefixForNewColumn.GetText)
    End Sub

    Private Sub chkOrColumnL_CheckedChanged(sender As Object, e As EventArgs) Handles chkOrColumnL.CheckedChanged
        If rdoWords.Checked Then
            If chkOrColumnL.Checked Then
                ucrInputTo.Visible = False
                ucrReceiverLastWord.SetMeAsReceiver()
                lblTo.Visible = False
                nudLastWord.Enabled = False
                chkOrColumnL.Visible = True
                ucrInputSeparator.Visible = True
                lblSeparator.Visible = True
                ucrReceiverLastWord.Visible = True
                lblWidth.Visible = False
                nudWidth.Visible = False
                lblPad.Visible = False
                ucrInputPad.Visible = False
                ucrBase.clsRsyntax.RemoveParameter("pad")
                ucrBase.clsRsyntax.RemoveParameter("width")
                ucrBase.clsRsyntax.RemoveParameter("side")

            ElseIf chkOrColumn.Checked = False
                ucrBase.clsRsyntax.RemoveParameter("first")
                ucrReceiverLastWord.Visible = False
                nudLastWord.Enabled = True
                ucrReceiverTransformText.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub ucrReceiverLastWord_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverLastWord.SelectionChanged
        If rdoWords.Checked Then
            If chkOrColumnL.Checked Then
                If Not ucrReceiverLastWord.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("end", clsRFunctionParameter:=ucrReceiverOrColumn.GetVariables())
                Else
                    ucrBase.clsRsyntax.RemoveParameter("end")
                End If
            End If
        End If
        TestOkEnabled()
    End Sub
End Class