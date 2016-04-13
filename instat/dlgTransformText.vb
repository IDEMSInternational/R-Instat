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
        ucrReceiverTransformText.SetMeAsReceiver()
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
        ucrInputPrefixForNewColumn.SetItemsTypeAsColumns()
        ucrInputPrefixForNewColumn.SetDefaultTypeAsColumn()
        ucrInputPrefixForNewColumn.SetDataFrameSelector(ucrSelectorForTransformText.ucrAvailableDataFrames)
        ucrReceiverOrColumn.SetDataType("numeric")
        ucrReceiverTransformText.SetDataType("factor")

    End Sub

    Private Sub SetDefaults()
        ucrSelectorForTransformText.Reset()
        ucrInputPrefixForNewColumn.SetName("New_Text")
        ucrSelectorForTransformText.Focus()
        ucrInputPrefixForNewColumn.Reset()
        ucrInputTo.Visible = False
        lblTo.Visible = False
        lblWidth.Visible = False
        nudWidth.Visible = False
        chkLeft.Visible = False
        lblPad.Visible = False
        ucrInputPad.Visible = False
        lblFirstWord.Visible = False
        nudFirstWord.Visible = False
        chkOrColumn.Visible = False
        lblLastWord.Visible = False
        nudLastWord.Visible = False
        ucrInputSeparator.Visible = False
        lblSeparator.Visible = False
        ucrReceiverOrColumn.Visible = False
        rdoWords.Checked = False
        rdoTrim.Checked = False
        rdoPad.Checked = False
        rdoLength.Checked = False
        rdoConvertCase.Checked = False
        ucrInputTo.cboInput.Text = "Lower"

    End Sub

    Private Sub TestOkEnabled()
        If (ucrReceiverTransformText.IsEmpty = False Or ucrReceiverOrColumn.IsEmpty = False Or ucrReceiverOrColumn.IsEmpty = False) And (rdoConvertCase.Checked = True Or rdoLength.Checked = True Or rdoPad.Checked = True Or rdoTrim.Checked = True Or rdoWords.Checked = True Or chkOrColumn.Checked = True) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        TestOkEnabled()
        SetDefaults()
    End Sub
    Private Sub ucrInputPrefixForNewColumn_NameChanged() Handles ucrInputPrefixForNewColumn.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputPrefixForNewColumn.GetText, strTempDataframe:=ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputPrefixForNewColumn.GetText)
    End Sub

    Private Sub ucrReceiverTransformText_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverTransformText.SelectionChanged
        If Not ucrReceiverTransformText.IsEmpty Then

            ucrBase.clsRsyntax.AddParameter("string", clsRFunctionParameter:=ucrReceiverTransformText.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("string")
        End If
        TestOkEnabled()

    End Sub

    Private Sub grpOperation_CheckedChanged(sender As Object, e As EventArgs) Handles rdoConvertCase.CheckedChanged, rdoLength.CheckedChanged, rdoPad.CheckedChanged, rdoTrim.CheckedChanged, rdoWords.CheckedChanged
        SetFuncAndParameters()
        TestOkEnabled()
    End Sub
    Private Sub SetFuncAndParameters()
        If rdoConvertCase.Checked Then
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
            chkLeft.Visible = False
            lblPad.Visible = False
            ucrInputPad.Visible = False
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
            chkLeft.Visible = False
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
            ucrBase.clsRsyntax.RemoveParameter("pad")
            ucrBase.clsRsyntax.RemoveParameter("width")
            ucrBase.clsRsyntax.RemoveParameter("side")
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
            ucrBase.clsRsyntax.RemoveParameter("sep")

        ElseIf rdoPad.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_pad")
            lblWidth.Visible = True
            nudWidth.Visible = True
            chkLeft.Visible = True
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
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
            ucrBase.clsRsyntax.RemoveParameter("sep")



        ElseIf rdoTrim.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::str_trim")
            lblWidth.Visible = False
            nudWidth.Visible = False
            chkLeft.Visible = False
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
            ucrBase.clsRsyntax.RemoveParameter("pad")
            ucrBase.clsRsyntax.RemoveParameter("width")
            ucrBase.clsRsyntax.RemoveParameter("side")
            ucrBase.clsRsyntax.RemoveParameter("start")
            ucrBase.clsRsyntax.RemoveParameter("end")
            ucrBase.clsRsyntax.RemoveParameter("sep")

        ElseIf rdoWords.Checked Then
            ucrBase.clsRsyntax.SetFunction("stringr::word")
            lblFirstWord.Visible = True
            nudFirstWord.Visible = True
            chkOrColumn.Visible = True
            lblLastWord.Visible = True
            nudLastWord.Visible = True
            ucrInputSeparator.Visible = True
            lblSeparator.Visible = True
            lblWidth.Visible = False
            nudWidth.Visible = False
            chkLeft.Visible = False
            lblPad.Visible = False
            ucrInputPad.Visible = False
            ucrInputTo.Visible = False
            lblTo.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("pad")
            ucrBase.clsRsyntax.RemoveParameter("width")
            ucrBase.clsRsyntax.RemoveParameter("side")

        Else
        End If
    End Sub

    Private Sub ucrReceiverOrColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverOrColumn.SelectionChanged

        If chkOrColumn.Checked Then
        End If
        If Not ucrReceiverOrColumn.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("start", clsRFunctionParameter:=ucrReceiverOrColumn.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("start")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrInputTo_NameChanged() Handles ucrInputTo.NameChanged
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
        If rdoPad.Checked Then
            ucrBase.clsRsyntax.AddParameter("width", nudWidth.Value)
        Else
            ucrBase.clsRsyntax.RemoveParameter("width")
        End If
    End Sub

    Private Sub chkLeft_CheckedChanged(sender As Object, e As EventArgs) Handles chkLeft.CheckedChanged
        If rdoPad.Checked Then
            If chkLeft.Checked Then
                ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "left" & Chr(34))
            Else
                ucrBase.clsRsyntax.AddParameter("side", Chr(34) & "right" & Chr(34))
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("side")
        End If
    End Sub

    Private Sub ucrInputPad_Namechanged() Handles ucrInputPad.NameChanged
        If rdoPad.Checked Then
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
                lblTo.Visible = True
                nudFirstWord.Enabled = False
                chkOrColumn.Visible = True
                ucrInputSeparator.Visible = True
                lblSeparator.Visible = True
                ucrReceiverOrColumn.Visible = True
                lblWidth.Visible = False
                nudWidth.Visible = False
                chkLeft.Visible = False
                lblPad.Visible = False
                ucrInputPad.Visible = False
                ucrBase.clsRsyntax.RemoveParameter("pad")
                ucrBase.clsRsyntax.RemoveParameter("width")
                ucrBase.clsRsyntax.RemoveParameter("side")

            ElseIf chkOrColumn.Checked = False
                ucrBase.clsRsyntax.RemoveParameter("first")
                ucrReceiverOrColumn.Visible = False

            End If
        End If
    End Sub
End Class