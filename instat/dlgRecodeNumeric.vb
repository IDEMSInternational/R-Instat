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
Public Class dlgRecodeNumeric
    Public bFirstLoad As Boolean = True
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""
    Private Sub dlgRecode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        SetDefaultColumn()
        TestOKEnabled()
        ucrBase.iHelpTopicID = 43
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverRecode.Selector = ucrSelectorForRecode
        ucrReceiverRecode.SetMeAsReceiver()
        ucrReceiverRecode.SetIncludedDataTypes({"numeric"})
        ucrBase.clsRsyntax.SetFunction("cut")
        ucrReceiverRecode.strSelectorHeading = "Numerics"
        ucrBase.clsRsyntax.AddParameter("include.lowest", "TRUE")
        ucrBase.clsRsyntax.AddParameter("dig.lab", "10")
        ucrInputRecode.SetItemsTypeAsColumns()
        ucrInputRecode.SetDefaultTypeAsColumn()
        ucrInputRecode.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrInputRecode.SetValidationTypeAsRVariable()
        ucrMultipleLabels.SetValidationTypeAsList()
        ucrMultipleNumericRecode.SetValidationTypeAsNumericList(bNewAllowInf:=True)
    End Sub

    Private Sub SetDefaults()
        chkAddLabels.Checked = False
        ucrMultipleLabels.Visible = False
        rdoRight.Checked = True
        ucrInputRecode.SetPrefix("Recode")
        ucrSelectorForRecode.Reset()
        ucrSelectorForRecode.Focus()
        ucrMultipleNumericRecode.Reset()
        ucrMultipleNumericRecode.SetName("")
        ucrMultipleLabels.Reset()
        ucrMultipleLabels.SetName("")
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForRecode.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumn <> "" Then
            ucrReceiverRecode.Add(strDefaultColumn, strDefaultDataFrame)
            ucrInputRecode.Focus()
        End If
        strDefaultDataFrame = ""
        strDefaultColumn = ""
    End Sub

    Private Sub TestOKEnabled()
        Dim iTemp As Integer

        If Not ucrReceiverRecode.IsEmpty() AndAlso Not ucrMultipleNumericRecode.IsEmpty AndAlso Not ucrInputRecode.IsEmpty Then
            If chkAddLabels.Checked AndAlso Not ucrMultipleLabels.IsEmpty Then
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

    Private Sub ucrReceiverRecode_SelectionChanged() Handles ucrReceiverRecode.SelectionChanged
        If Not ucrReceiverRecode.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverRecode.GetVariables())

        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrMultipleNumericRecode_NameChanged() Handles ucrMultipleNumericRecode.NameChanged
        'Warning: Apparently the event is raised twice, such that the message is sent twice...
        'This sub is sending validation errors to the user for him/her to fill in the settingsof the dialogue in an appropriate way.
        'In case he/she enters only one number in ucrMultipleNumericRecode, this number has to be greater than one, as it is the number of intervals for cut.
        'Otherwise, if the user enters the list of break points, the resulting number of intervals should be smaller than the number of labels (see
        If ucrMultipleNumericRecode.GetText <> "" AndAlso ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 Then
            MsgBox("If the input of break points is a single number, it is understood as the number of intervals. It has to be > 1, otherwise an error will occur.", vbOKOnly, "Validation Error")
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
        Dim iTemp As Integer

        If Not ucrMultipleNumericRecode.IsEmpty() AndAlso (Not ucrMultipleLabels.IsEmpty()) Then
            If ucrMultipleNumericRecode.clsRList.clsParameters.Count > 1 AndAlso ucrMultipleLabels.clsRList.clsParameters.Count <> ucrMultipleNumericRecode.clsRList.clsParameters.Count - 1 Then
                MsgBox("There must be one less label than the number of break points. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
            ElseIf ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 AndAlso Integer.TryParse(ucrMultipleNumericRecode.clsRList.clsParameters(0).strArgumentValue, iTemp) AndAlso iTemp <> ucrMultipleLabels.clsRList.clsParameters.Count Then
                MsgBox("There must be the same number of labels to the number of intervals. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
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