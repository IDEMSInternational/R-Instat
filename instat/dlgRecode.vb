
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
        ucrReceiverRecode.Selector = ucrSelectorDataFrameAddRemove
        ucrReceiverRecode.SetMeAsReceiver()
        ucrMultipleNumericBreakPoints.bIsNumericInput = True
        chkAddLabels.Checked = False
        ucrMultipleLabels.Visible = False
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("cut")
        ucrBase.clsRsyntax.AddParameter("include.lowest", "TRUE")
        ucrSelectorNewColumnName.SetDataFrameSelector(ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames)
        ucrSelectorNewColumnName.SetPrefix("Recode")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSelectorNewColumnName.cboColumnName.Text, strTempDataframe:=ucrSelectorDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSelectorNewColumnName.cboColumnName.Text)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrReceiverRecode_Leave(sender As Object, e As EventArgs) Handles ucrReceiverRecode.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverRecode.GetVariables())

    End Sub

    Private Sub ucrMultipleNumeric_Leave(sender As Object, e As EventArgs) Handles ucrMultipleNumericBreakPoints.Leave
        If ucrMultipleNumericBreakPoints.clsNumericList.clsParameters.Count = 1 Then
            If ucrMultipleNumericBreakPoints.txtNumericItems.Text < 2 Then
                MsgBox("If break points is a single number, it specify a number of intervals > 1.", vbOKOnly, "Validation Error")
            End If
        Else
            ValidateBreakPointLabelCount(True)
        End If
        ucrBase.clsRsyntax.AddParameter("breaks", clsRFunctionParameter:=ucrMultipleNumericBreakPoints.clsNumericList)
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
        If ucrMultipleNumericBreakPoints.clsNumericList.clsParameters.Count > 1 Then
            If ucrMultipleNumericBreakPoints.txtNumericItems.Text <> "" And ucrMultipleLabels.txtNumericItems.Text <> "" Then
                If ucrMultipleLabels.clsNumericList.clsParameters.Count <> ucrMultipleNumericBreakPoints.clsNumericList.clsParameters.Count - 1 Then
                    MsgBox("There must be one less label than the number of break points.", vbOKOnly, "Validation Error")
                    If bBreakPointFocused Then
                        ucrMultipleNumericBreakPoints.Focus()
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
        If rdoLeft.Checked Then
            ucrBase.clsRsyntax.AddParameter("right", "FALSE")
        Else
            ucrBase.clsRsyntax.AddParameter("right", "TRUE")
        End If
    End Sub

End Class