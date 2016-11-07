
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
Public Class dlgRecodeNumeric
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
        ucrBase.iHelpTopicID = 43
    End Sub
    Private Sub InitialiseDialog()
        ucrReceiverRecode.Selector = ucrSelectorForRecode
        ucrReceiverRecode.SetMeAsReceiver()
        ucrReceiverRecode.SetIncludedDataTypes({"numeric"})
        ucrBase.clsRsyntax.SetFunction("cut")
        ucrBase.clsRsyntax.AddParameter("include.lowest", "TRUE")
        ucrInputRecode.SetPrefix("Recode")
        ucrInputRecode.SetItemsTypeAsColumns()
        ucrInputRecode.SetDefaultTypeAsColumn()
        ucrInputRecode.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrInputRecode.SetValidationTypeAsRVariable()
        ucrMultipleLabels.SetValidationTypeAsList()
        ucrMultipleNumericRecode.SetValidationTypeAsNumericList()
    End Sub

    Private Sub SetDefaults()
        chkAddLabels.Checked = False
        ucrMultipleLabels.Visible = False
        rdoRight.Checked = True
        ucrSelectorForRecode.Reset()
        ucrSelectorForRecode.Focus()
        ucrMultipleNumericRecode.ResetText()
        ucrMultipleLabels.ResetText()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverRecode.IsEmpty() AndAlso Not ucrMultipleNumericRecode.IsEmpty AndAlso Not ucrInputRecode.IsEmpty Then
            If chkAddLabels.Checked AndAlso Not ucrMultipleLabels.IsEmpty Then
                If Not ucrMultipleLabels.clsRList.clsParameters.Count <> ucrMultipleNumericRecode.clsRList.clsParameters.Count - 1 Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                ucrBase.OKEnabled(True)
            End If
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

    Private Sub ucrMultipleNumericRecode_NameChanged() Handles ucrMultipleNumericRecode.NameChanged
        If ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 Then
            If ucrMultipleNumericRecode.GetText < 2 Then
                MsgBox("If break points is a single number, it specify a number of intervals > 1.", vbOKOnly, "Validation Error")
            End If
        Else
            ValidateBreakPointLabelCount()
        End If
        ucrBase.clsRsyntax.AddParameter("breaks", clsRFunctionParameter:=ucrMultipleNumericRecode.clsRList)
        TestOKEnabled()
    End Sub

    Private Sub ucrMultipleLabels_NameChanged() Handles ucrMultipleLabels.NameChanged
        AddLabelsParameter()
        TestOKEnabled()
    End Sub

    Private Sub ucrMultipleNumericRecode_Validated(sender As Object, e As EventArgs) Handles ucrMultipleNumericRecode.Validated, ucrMultipleLabels.Validated
        ValidateBreakPointLabelCount()
    End Sub

    Private Sub AddLabelsParameter()
        If Not ucrMultipleLabels.IsEmpty() Then
            ucrBase.clsRsyntax.AddParameter("labels", clsRFunctionParameter:=ucrMultipleLabels.clsRList)
        Else
            ucrBase.clsRsyntax.RemoveParameter("labels")
        End If
    End Sub

    Private Sub ValidateBreakPointLabelCount()
        If ucrMultipleNumericRecode.clsRList.clsParameters.Count > 1 Then
            If Not ucrMultipleNumericRecode.IsEmpty() And Not ucrMultipleLabels.IsEmpty() Then
                If ucrMultipleLabels.clsRList.clsParameters.Count <> ucrMultipleNumericRecode.clsRList.clsParameters.Count - 1 Then
                    MsgBox("There must be one less label than the number of break points. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
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
        TestOKEnabled()
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
    End Sub

    Private Sub ucrInputRecode_Namechanged() Handles ucrInputRecode.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputRecode.GetText, strTempDataframe:=ucrSelectorForRecode.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputRecode.GetText)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverRecode_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRecode.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverRecode.GetVariables())
    End Sub
End Class