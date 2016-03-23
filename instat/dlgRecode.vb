
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
Public Class dlgRecode
    Public bFirstLoad As Boolean = True
    Private Sub dlgRecode_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        autoTranslate(Me)



        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 37
        ucrReceiverRecode.Selector = ucrSelectorForRecode
        ucrReceiverRecode.SetMeAsReceiver()
        ucrMultipleNumericRecode.bIsNumericInput = True
        ucrInputRecode.SetPrefix("Recode")
        ucrInputRecode.SetDefaultTypeAsColumn()
        ucrInputRecode.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrReceiverRecode.SetDataType("numeric")
        ucrBase.clsRsyntax.SetFunction("cut")
        ucrBase.clsRsyntax.AddParameter("include.lowest", "TRUE")


    End Sub

    Private Sub SetDefaults()
        chkAddLabels.Checked = False
        ucrMultipleLabels.Visible = False
        rdoRight.Checked = True
        ucrSelectorForRecode.Reset()
        ucrSelectorForRecode.Focus()
        ucrMultipleNumericRecode.txtNumericItems.ResetText()
        ucrMultipleLabels.txtNumericItems.ResetText()
        ucrInputRecode.txtInput.ResetText()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverRecode.IsEmpty() = False AndAlso ucrMultipleNumericRecode.txtNumericItems.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverRecode_SelectionChanged() Handles ucrReceiverRecode.SelectionChanged
        If Not ucrReceiverRecode.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverRecode.GetVariables())

        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrMultipleNumericRecode_Leave(sender As Object, e As EventArgs) Handles ucrMultipleNumericRecode.Leave
        If ucrMultipleNumericRecode.clsNumericList.clsParameters.Count = 1 Then
            If ucrMultipleNumericRecode.txtNumericItems.Text < 2 Then
                MsgBox("If break points is a single number, it specify a number of intervals > 1.", vbOKOnly, "Validation Error")
            End If


        Else
            ValidateBreakPointLabelCount(True)
        End If
        ucrBase.clsRsyntax.AddParameter("breaks", clsRFunctionParameter:=ucrMultipleNumericRecode.clsNumericList)
        TestOKEnabled()
    End Sub

    Private Sub ucrMultipleLabels_Leave(sender As Object, e As EventArgs) Handles ucrMultipleLabels.Leave
        ValidateBreakPointLabelCount(False)
        AddLabelsParameter()
    End Sub

    Private Sub AddLabelsParameter()
        If ucrMultipleLabels.txtNumericItems.Text <> "" Then
            ucrBase.clsRsyntax.AddParameter("labels", clsRFunctionParameter:=ucrMultipleLabels.clsNumericList)
        Else
            ucrBase.clsRsyntax.RemoveParameter("labels")
        End If
    End Sub

    Private Sub ValidateBreakPointLabelCount(bBreakPointFocused As Boolean)
        If ucrMultipleNumericRecode.clsNumericList.clsParameters.Count > 1 Then
            If ucrMultipleNumericRecode.txtNumericItems.Text <> "" And ucrMultipleLabels.txtNumericItems.Text <> "" Then
                If ucrMultipleLabels.clsNumericList.clsParameters.Count <> ucrMultipleNumericRecode.clsNumericList.clsParameters.Count - 1 Then
                    MsgBox("There must be one less label than the number of break points.", vbOKOnly, "Validation Error")
                    If bBreakPointFocused Then
                        ucrMultipleNumericRecode.Focus()
                    Else
                        ucrMultipleLabels.Focus()
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub chkAddLabels_CheckedChanged(sender As Object, e As EventArgs) Handles chkAddLabels.CheckedChanged
        If chkAddLabels.Checked Then
            ucrMultipleLabels.Visible = True
            AddLabelsParameter()
        Else
            ucrMultipleLabels.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("labels")
        End If

    End Sub

    Private Sub grpClosedOn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLeft.CheckedChanged, rdoRight.CheckedChanged
        SetClosedOn()

    End Sub

    Private Sub SetClosedOn()
        If rdoRight.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("right", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("right")
            End If
        Else
            ucrBase.clsRsyntax.AddParameter("right", "FALSE")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()

    End Sub

    Private Sub ucrInputRecode_Namechanged() Handles ucrInputRecode.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputRecode.GetText, strTempDataframe:=ucrSelectorForRecode.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputRecode.GetText)
    End Sub

    Private Sub ucrReceiverRecode_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRecode.SelectionChanged

    End Sub
End Class