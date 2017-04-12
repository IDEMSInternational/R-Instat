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

Imports instat
Imports instat.Translations
Public Class dlgRecodeNumeric
    Private clsRecodeNumeric As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""
    Private Sub dlgRecode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 43
        ucrReceiverRecode.Selector = ucrSelectorForRecode
        ucrReceiverRecode.SetMeAsReceiver()
        ucrReceiverRecode.SetIncludedDataTypes({"numeric"})
        ucrMultipleLabels.SetValidationTypeAsList()
        ucrMultipleNumericRecode.SetValidationTypeAsNumericList()

        ucrPnlClosedOn.SetText("Closed on")
        ucrChkAddLabels.SetText("Add Labels")
        ucrMultipleNumericRecode.SetName("")
        ucrMultipleLabels.SetName("")

        ucrReceiverRecode.SetParameter(New RParameter("x", 0))
        ucrReceiverRecode.SetParameterIsRFunction()

        ucrMultipleNumericRecode.SetParameter(New RParameter("breaks", 1))

        ucrMultipleLabels.SetParameter(New RParameter("labels", 2))

        ucrPnlClosedOn.SetParameter(New RParameter("right", 3))
        ucrPnlClosedOn.AddRadioButton(rdoRight, "TRUE")
        ucrPnlClosedOn.AddRadioButton(rdoLeft, "FALSE")
        ucrPnlClosedOn.SetRDefault("TRUE")

        ucrNewColumnName.SetLabelText("Column Name:")
        ucrNewColumnName.SetPrefix("Recode")
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrNewColumnName.SetIsComboBox()
    End Sub

    Private Sub SetDefaults()
        clsRecodeNumeric = New RFunction

        ucrChkAddLabels.Checked = False
        ucrMultipleLabels.Visible = False
        rdoRight.Checked = True
        ucrSelectorForRecode.Reset()
        ucrMultipleNumericRecode.Reset()
        ucrMultipleLabels.Reset()
        BreaksCheck()

        clsRecodeNumeric.SetRCommand("cut")
        clsRecodeNumeric.AddParameter("include.lowest", "TRUE")
        'clsRecodeNumeric.AddParameter("right", "TRUE")
        clsRecodeNumeric.SetAssignTo(ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorForRecode.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)

        ucrBase.clsRsyntax.SetBaseRFunction(clsRecodeNumeric)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForRecode.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumn <> "" Then
            ucrReceiverRecode.Add(strDefaultColumn, strDefaultDataFrame)
            ucrNewColumnName.Focus()
        End If
        strDefaultDataFrame = ""
        strDefaultColumn = ""
    End Sub

    Private Sub TestOKEnabled()
        Dim iTemp As Integer
        If Not ucrReceiverRecode.IsEmpty() AndAlso Not ucrMultipleNumericRecode.IsEmpty AndAlso ucrNewColumnName.IsComplete Then
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
        ucrBase.clsRsyntax.AddParameter("breaks", clsRFunctionParameter:=ucrMultipleNumericRecode.clsRList)
    End Sub

    Private Sub ucrMultipleNumericRecode_Validated(sender As Object, e As EventArgs) Handles ucrMultipleNumericRecode.Validated, ucrMultipleLabels.Validated
        ValidateBreakPointLabelCount()
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

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrChkAddLabels_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlContentsChanged
        If ucrChkAddLabels.Checked Then
            ucrMultipleLabels.Visible = True
        Else
            ucrMultipleLabels.Visible = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrReceiverRecode.ControlContentsChanged, ucrMultipleLabels.ControlContentsChanged, ucrMultipleNumericRecode.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrMultipleNumericRecode_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrMultipleNumericRecode.ControlValueChanged
        BreaksCheck()
    End Sub
End Class