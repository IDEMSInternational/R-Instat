
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
    Private clsRecodeNumeric As New RFunction
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
        ucrBase.iHelpTopicID = 43
        ucrReceiverRecode.Selector = ucrSelectorForRecode
        ucrReceiverRecode.SetMeAsReceiver()
        ucrReceiverRecode.SetIncludedDataTypes({"numeric"})
        ucrInputRecode.SetItemsTypeAsColumns()
        ucrInputRecode.SetDefaultTypeAsColumn()
        ucrInputRecode.SetValidationTypeAsRVariable()
        ucrMultipleLabels.SetValidationTypeAsList()
        ucrMultipleNumericRecode.SetValidationTypeAsNumericList()
        ucrInputRecode.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)

        ucrpnlClosedOn.SetText("Closed on")
        ucrChkAddLabels.SetText("Add Labels")
        ucrMultipleNumericRecode.SetName("")
        ucrMultipleLabels.SetName("")
        ucrInputRecode.SetPrefix("Recode")

        ucrReceiverRecode.SetParameter(New RParameter("X", 0))
        ucrReceiverRecode.SetParameterIsRFunction()

        ucrMultipleNumericRecode.SetParameter(New RParameter("breaks", 1))
        ucrMultipleLabels.SetParameter(New RParameter("labels", 2))

        ucrpnlClosedOn.SetParameter(New RParameter("right", 3))
        ucrpnlClosedOn.AddRadioButton(rdoRight, "TRUE")
        ucrpnlClosedOn.AddRadioButton(rdoLeft, "FALSE")

        ucrBase.clsRsyntax.AddParameter("include.lowest", "TRUE")
        clsRecodeNumeric.SetRCommand("cut")
    End Sub

    Private Sub SetDefaults()
        ucrChkAddLabels.Checked = False
        ucrMultipleLabels.Visible = False
        rdoRight.Checked = True
        ucrSelectorForRecode.Reset()
        ucrSelectorForRecode.Focus()
        ucrMultipleNumericRecode.Reset()
        ucrMultipleLabels.Reset()
        BreaksCheck()
        ucrBase.clsRsyntax.SetBaseRFunction(clsRecodeNumeric.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        Dim iTemp As Integer
        If Not ucrReceiverRecode.IsEmpty() AndAlso Not ucrMultipleNumericRecode.IsEmpty AndAlso Not ucrInputRecode.IsEmpty Then
            If ucrChkAddLabels.Checked AndAlso Not ucrMultipleLabels.IsEmpty Then
                If (ucrMultipleNumericRecode.clsRList.clsParameters.Count > 1 AndAlso (Not ucrMultipleLabels.clsRList.clsParameters.Count <> ucrMultipleNumericRecode.clsRList.clsParameters.Count - 1)) OrElse (ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 AndAlso Integer.TryParse(ucrMultipleNumericRecode.clsRList.clsParameters(0).strArgumentValue, iTemp) AndAlso iTemp = ucrMultipleLabels.clsRList.clsParameters.Count) Then
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

    Private Sub BreaksCheck()
        If ucrMultipleNumericRecode.GetText <> "" AndAlso ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 Then
            MsgBox("If the input of break points is a single number, it is understood as the number of intervals. It has to be > 1, otherwise an error will occur.", vbOKOnly, "Validation Error")
        Else
            ValidateBreakPointLabelCount()
        End If
    End Sub

    Private Sub ValidateBreakPointLabelCount()
        Dim iTemp As Integer
        If Not ucrMultipleNumericRecode.IsEmpty() AndAlso (Not ucrMultipleLabels.IsEmpty()) Then
            If ucrMultipleNumericRecode.clsRList.clsParameters.Count > 1 AndAlso ucrMultipleLabels.clsRList.clsParameters.Count <> ucrMultipleNumericRecode.clsRList.clsParameters.Count - 1 Then
                MsgBox("There must be one less label than the number of break points. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
            ElseIf ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 AndAlso Integer.TryParse(ucrMultipleNumericRecode.clsRList.clsParameters(0).strArgumentValue, iTemp) AndAlso iTemp <> ucrMultipleLabels.clsRList.clsParameters.Count Then
                MsgBox("There must be the same number of labels to the number of intervals. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
            End If
        End If
    End Sub

    Private Sub LablesVissible()
        If ucrChkAddLabels.Checked Then
            ucrMultipleLabels.Visible = True
        Else
            ucrMultipleLabels.Visible = False
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverRecode_ControlContenetsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRecode.ControlContentsChanged, ucrChkAddLabels.ControlContentsChanged, ucrMultipleLabels.ControlContentsChanged, ucrMultipleNumericRecode.ControlContentsChanged
        LablesVissible()
        TestOKEnabled()
    End Sub
End Class