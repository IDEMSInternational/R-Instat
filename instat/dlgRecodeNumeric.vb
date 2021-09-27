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
    Private bReset As Boolean = True
    Private clsCutFunction As New RFunction
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""

    Private Sub dlgRecode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
        SetDefaultColumn()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 43

        ucrReceiverRecode.SetParameter(New RParameter("x", iNewPosition:=2))
        ucrReceiverRecode.SetParameterIsRFunction()
        ucrReceiverRecode.Selector = ucrSelectorForRecode
        ucrReceiverRecode.SetIncludedDataTypes({"numeric"})
        ucrReceiverRecode.strSelectorHeading = "Numerics"

        ucrPnlClosedOn.SetParameter(New RParameter("right", iNewPosition:=3))
        ucrPnlClosedOn.AddRadioButton(rdoLeft, "FALSE")
        ucrPnlClosedOn.AddRadioButton(rdoRight, "TRUE")

        ucrChkAddLabels.SetText("Add Labels")
        ucrChkAddLabels.AddParameterPresentCondition(True, "labels", True)
        ucrChkAddLabels.AddParameterPresentCondition(False, "labels", False)
        ucrChkAddLabels.AddToLinkedControls(ucrInputMultipleLabels, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
    
        ucrSaveRecode.SetPrefix("recode")
        ucrSaveRecode.SetSaveTypeAsColumn()
        ucrSaveRecode.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrSaveRecode.SetIsComboBox()
        ucrSaveRecode.SetLabelText("New column name:")
        ucrSaveRecode.setLinkedReceiver(ucrReceiverRecode)


        ucrInputMultipleLabels.SetValidationTypeAsList()
        ucrMultipleNumericRecode.SetValidationTypeAsNumericList(bNewAllowInf:=True)
    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorForRecode.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumn <> "" Then
            ucrReceiverRecode.Add(strDefaultColumn, strDefaultDataFrame)
            ucrSaveRecode.Focus()
        End If
        strDefaultDataFrame = ""
        strDefaultColumn = ""
    End Sub

    Private Sub SetDefaults()
        clsCutFunction = New RFunction

        ucrSelectorForRecode.Reset()
        ucrSaveRecode.Reset()
        ucrReceiverRecode.SetMeAsReceiver()
        ucrMultipleNumericRecode.SetName("")
        ucrInputMultipleLabels.SetName("")

        clsCutFunction.SetRCommand("cut")
        clsCutFunction.AddParameter("include.lowest", "TRUE", iPosition:=0)
        clsCutFunction.AddParameter("dig.lab", "10", iPosition:=1)
        clsCutFunction.AddParameter("right", "FALSE", iPosition:=3)

        ucrBase.clsRsyntax.SetBaseRFunction(clsCutFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrReceiverRecode.SetRCode(clsCutFunction, bReset)
        ucrSaveRecode.SetRCode(clsCutFunction, bReset)
        ucrChkAddLabels.SetRCode(clsCutFunction, bReset)
        ucrPnlClosedOn.SetRCode(clsCutFunction, bReset)
    End Sub


    Private Sub TestOKEnabled()
        Dim iTemp As Integer

        If Not ucrReceiverRecode.IsEmpty() AndAlso Not ucrMultipleNumericRecode.IsEmpty AndAlso ucrSaveRecode.IsComplete Then
            If ucrChkAddLabels.Checked AndAlso Not ucrInputMultipleLabels.IsEmpty Then
                If (ucrMultipleNumericRecode.clsRList.clsParameters.Count > 1 AndAlso (Not ucrInputMultipleLabels.clsRList.clsParameters.Count <> ucrMultipleNumericRecode.clsRList.clsParameters.Count - 1)) OrElse (ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 AndAlso Integer.TryParse(ucrMultipleNumericRecode.clsRList.clsParameters(0).strArgumentValue, iTemp) AndAlso iTemp = ucrInputMultipleLabels.clsRList.clsParameters.Count) Then
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
    End Sub

    Private Sub ucrMultipleLabels_NameChanged() Handles ucrInputMultipleLabels.NameChanged
        AddLabelsParameter()
    End Sub

    Private Sub ucrMultipleNumericRecode_Validated(sender As Object, e As EventArgs) Handles ucrMultipleNumericRecode.Validated, ucrInputMultipleLabels.Validated
        ValidateBreakPointLabelCount()
    End Sub

    Private Sub AddLabelsParameter()
        If Not ucrInputMultipleLabels.IsEmpty() Then
            clsCutFunction.AddParameter("labels", clsRFunctionParameter:=ucrInputMultipleLabels.clsRList)
        Else
            clsCutFunction.RemoveParameterByName("labels")
        End If
    End Sub

    Private Sub ValidateBreakPointLabelCount()
        Dim iTemp As Integer

        If Not ucrMultipleNumericRecode.IsEmpty() AndAlso (Not ucrInputMultipleLabels.IsEmpty()) Then
            If ucrMultipleNumericRecode.clsRList.clsParameters.Count > 1 AndAlso ucrInputMultipleLabels.clsRList.clsParameters.Count <> ucrMultipleNumericRecode.clsRList.clsParameters.Count - 1 Then
                MsgBox("There must be one less label than the number of break points. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
            ElseIf ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 AndAlso Integer.TryParse(ucrMultipleNumericRecode.clsRList.clsParameters(0).strArgumentValue, iTemp) AndAlso iTemp <> ucrInputMultipleLabels.clsRList.clsParameters.Count Then
                MsgBox("There must be the same number of labels to the number of intervals. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrMultipleNumericRecode.ControlContentsChanged, ucrInputMultipleLabels.ControlContentsChanged, ucrReceiverRecode.ControlContentsChanged,
            ucrSaveRecode.ControlContentsChanged, ucrChkAddLabels.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkAddLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlValueChanged
        If ucrChkAddLabels.Checked Then
            AddLabelsParameter()
        Else
            clsCutFunction.RemoveParameterByName("labels")
        End If
    End Sub
End Class