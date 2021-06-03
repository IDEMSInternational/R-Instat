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

Imports instat
Imports instat.Translations
Public Class dlgRecodeNumeric
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumn As String = ""
    Private lstRCodeStructure As List(Of RCodeStructure)
    Private clsCutFunction As New RFunction

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
        SetDefaultColumn()
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 43

        ucrReceiverRecode.SetParameter(New RParameter("x", iNewPosition:=1))
        ucrReceiverRecode.SetParameterIsRFunction()
        ucrReceiverRecode.strSelectorHeading = "Numerics"
        ucrReceiverRecode.SetIncludedDataTypes({"numeric"})
        ucrReceiverRecode.Selector = ucrSelectorRecode
        ucrReceiverRecode.SetMeAsReceiver()

        ucrPnlClosedOn.AddRadioButton(rdoLeft)
        ucrPnlClosedOn.AddRadioButton(rdoRight)

        ucrPnlClosedOn.AddParameterValuesCondition(rdoLeft, "right", "FALSE")
        ucrPnlClosedOn.AddParameterValuesCondition(rdoRight, "right", "TRUE")

        ucrChkAddLabel.SetText("AddLabel")
        ucrChkAddLabel.AddParameterPresentCondition(True, "labels")
        ucrChkAddLabel.AddParameterPresentCondition(False, "labels", False)

        ucrChkAddLabel.AddToLinkedControls(ucrInputMultipleLabels, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrInputMultipleLabels.SetValidationTypeAsList()
        ucrInputMultipleNumericRecode.SetValidationTypeAsNumericList(bNewAllowInf:=True)

        ucrSaveRecodeNumeric.SetSaveTypeAsColumn()
        ucrSaveRecodeNumeric.SetDataFrameSelector(ucrSelectorRecode.ucrAvailableDataFrames)
        ucrSaveRecodeNumeric.SetLabelText("New Column :")
        ucrSaveRecodeNumeric.SetIsTextBox()
        ucrSaveRecodeNumeric.SetPrefix("Recode")
        ucrSaveRecodeNumeric.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
    End Sub
    Private Sub SetRFunctionDefaultParameters()
        clsCutFunction.SetRCommand("cut")
        clsCutFunction.AddParameter("include.lowest", "TRUE", iPosition:=0)
        clsCutFunction.AddParameter("right", "TRUE", iPosition:=2)
        clsCutFunction.AddParameter("dig.lab", "10", iPosition:=3)

        ucrBase.clsRsyntax.SetBaseRFunction(clsCutFunction)
    End Sub

    Private Sub SetDefaults()
        clsCutFunction = New RFunction

        ucrSelectorRecode.Reset()
        ucrInputMultipleNumericRecode.Reset()
        ucrInputMultipleNumericRecode.SetName("")
        ucrInputMultipleLabels.Reset()

        If IsNothing(lstRCodeStructure) Then
            SetRFunctionDefaultParameters()
        ElseIf (lstRCodeStructure.Count > 1) Then
            SetRFunctionDefaultParameters()
            MsgBox("Developer error: List of RCodeStructure must have only one RFunction")
        ElseIf (lstRCodeStructure.Count = 1) Then
            If Not IsNothing(TryCast(lstRCodeStructure(0), RFunction)) Then
                If TryCast(lstRCodeStructure(0), RFunction).strRCommand = "cut" Then
                    clsCutFunction = lstRCodeStructure(0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsCutFunction)
                Else
                    MsgBox("Developer error: This dialogue has the ""cut"" function")
                End If
            Else
                    SetRFunctionDefaultParameters()
                MsgBox("Developer error:The Script must be an RFunction")
            End If
        End If
        lstRCodeStructure = Nothing
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkAddLabel.SetRCode(clsCutFunction, bReset)
        ucrReceiverRecode.SetRCode(clsCutFunction, bReset)
        ucrPnlClosedOn.SetRCode(clsCutFunction, bReset)
        ucrSaveRecodeNumeric.SetRCode(clsCutFunction, bReset)
    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorRecode.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumn <> "" Then
            ucrReceiverRecode.Add(strDefaultColumn, strDefaultDataFrame)
        End If
        strDefaultDataFrame = ""
        strDefaultColumn = ""
    End Sub
    Private Sub TestOKEnabled()
        Dim iTemp As Integer

        If Not ucrReceiverRecode.IsEmpty() AndAlso Not ucrInputMultipleNumericRecode.IsEmpty AndAlso ucrSaveRecodeNumeric.IsComplete Then
            If ucrChkAddLabel.Checked AndAlso Not ucrInputMultipleLabels.IsEmpty Then
                If (ucrInputMultipleNumericRecode.clsRList.clsParameters.Count > 1 AndAlso (Not ucrInputMultipleLabels.clsRList.clsParameters.Count <> ucrInputMultipleNumericRecode.clsRList.clsParameters.Count - 1)) OrElse
                    (ucrInputMultipleNumericRecode.clsRList.clsParameters.Count = 1 AndAlso Integer.TryParse(ucrInputMultipleNumericRecode.clsRList.clsParameters(0).strArgumentValue, iTemp) AndAlso iTemp = ucrInputMultipleLabels.clsRList.clsParameters.Count) Then
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

    Private Sub ucrMultipleNumericRecode_NameChanged() Handles ucrInputMultipleNumericRecode.NameChanged
        'Warning: Apparently the event is raised twice, such that the message is sent twice...
        'This sub is sending validation errors to the user for him/her to fill in the settingsof the dialogue in an appropriate way.
        'In case he/she enters only one number in ucrMultipleNumericRecode, this number has to be greater than one, as it is the number of intervals for cut.
        'Otherwise, if the user enters the list of break points, the resulting number of intervals should be smaller than the number of labels (see
        If ucrInputMultipleNumericRecode.GetText <> "" AndAlso ucrInputMultipleNumericRecode.clsRList.clsParameters.Count = 1 Then
            MsgBox("If the input of break points is a single number, it is understood as the number of intervals. It has to be > 1, otherwise an error will occur.", vbOKOnly, "Validation Error")
        Else
            ValidateBreakPointLabelCount()
        End If
        ucrBase.clsRsyntax.AddParameter("breaks", clsRFunctionParameter:=ucrInputMultipleNumericRecode.clsRList)
    End Sub

    Private Sub ucrMultipleNumericRecode_Validated(sender As Object, e As EventArgs) Handles ucrInputMultipleNumericRecode.Validated, ucrInputMultipleLabels.Validated
        ValidateBreakPointLabelCount()
    End Sub



    Private Sub ValidateBreakPointLabelCount()
        Dim iTemp As Integer

        If Not ucrInputMultipleNumericRecode.IsEmpty() AndAlso (Not ucrInputMultipleLabels.IsEmpty()) Then
            If ucrInputMultipleNumericRecode.clsRList.clsParameters.Count > 1 AndAlso ucrInputMultipleLabels.clsRList.clsParameters.Count <> ucrInputMultipleNumericRecode.clsRList.clsParameters.Count - 1 Then
                MsgBox("There must be one less label than the number of break points. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
            ElseIf ucrInputMultipleNumericRecode.clsRList.clsParameters.Count = 1 AndAlso Integer.TryParse(ucrInputMultipleNumericRecode.clsRList.clsParameters(0).strArgumentValue, iTemp) AndAlso iTemp <> ucrInputMultipleLabels.clsRList.clsParameters.Count Then
                MsgBox("There must be the same number of labels to the number of intervals. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrReceiverRecode_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRecode.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverRecode.GetVariables())
    End Sub

    Private Sub ucrPnlClosedOn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlClosedOn.ControlValueChanged
        If rdoRight.Checked Then
            ucrBase.clsRsyntax.AddParameter("right", "TRUE")
        Else
            ucrBase.clsRsyntax.AddParameter("right", "FALSE")
        End If
    End Sub

    Private Sub ucrInputMultipleLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputMultipleLabels.ControlValueChanged, ucrChkAddLabel.ControlValueChanged
        If ucrChkAddLabel.Checked Then
            clsCutFunction.AddParameter("labels", clsRFunctionParameter:=ucrInputMultipleLabels.clsRList)
        Else
            clsCutFunction.RemoveParameterByName("labels")
        End If

    End Sub

    Private Sub Controls_ContentChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRecode.ControlContentsChanged,
            ucrInputMultipleLabels.ControlContentsChanged, ucrInputMultipleNumericRecode.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Public Property lstScriptsRCodeStructure As List(Of RCodeStructure)
        Get
            Return lstRCodeStructure
        End Get
        Set(lstNewRCodeStructure As List(Of RCodeStructure))
            lstRCodeStructure = lstNewRCodeStructure
            bReset = True
        End Set
    End Property
End Class