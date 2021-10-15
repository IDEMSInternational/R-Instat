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
    Private clsCut2Function As New RFunction
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

        ucrNudQuantiles.SetParameter(New RParameter("g", iNewPosition:=3))
        ucrNudQuantiles.SetMinMax(1, Integer.MaxValue)
        ucrNudQuantiles.SetRDefault(4)
        ttQuantiles.SetToolTip(ucrChkQuantiles.chkCheck, "Opens control")

        ucrNudMinimum.SetParameter(New RParameter("m", 2))
        ucrNudMinimum.SetMinMax(1, Integer.MaxValue)
        ucrNudMinimum.SetRDefault(1)

        ucrChkMinimum.SetText("Minimum:")
        ucrChkMinimum.AddToLinkedControls(ucrNudMinimum, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrChkMinimum.AddParameterPresentCondition(True, "m", True)
        ucrChkMinimum.AddParameterPresentCondition(False, "m", False)
        ttMinimum.SetToolTip(ucrChkMinimum.chkCheck, "Opens a control")

        ucrChkQuantiles.SetText("Quantiles:")
        ucrChkQuantiles.AddToLinkedControls(ucrNudQuantiles, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkQuantiles.AddParameterPresentCondition(True, "g", True)
        ucrChkQuantiles.AddParameterPresentCondition(False, "g", False)

        ucrChkAddLabels.SetText("Label Groups with Means")

        ucrSaveRecode.SetPrefix("recode")
        ucrSaveRecode.SetSaveTypeAsColumn()
        ucrSaveRecode.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)
        ucrSaveRecode.SetIsComboBox()
        ucrSaveRecode.SetLabelText("New column name:")
        ucrSaveRecode.setLinkedReceiver(ucrReceiverRecode)


        'ucrInputMultipleLabels.SetValidationTypeAsList()
        ucrMultipleNumericRecode.SetValidationTypeAsNumericList(bNewAllowInf:=True)
        ucrMultipleNumericRecode.SetParameter(New RParameter("cuts", iNewPosition:=3))
        ttBreakpoint.SetToolTip(ucrMultipleNumericRecode.txtInput, "Seperate with comma")
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
        clsCut2Function = New RFunction

        ucrChkMinimum.Checked = False
        ucrChkQuantiles.Checked = False



        ucrSelectorForRecode.Reset()
        ucrSaveRecode.Reset()
        ucrReceiverRecode.SetMeAsReceiver()
        ucrMultipleNumericRecode.SetName("")

        clsCut2Function.SetRCommand("cut2")
        clsCut2Function.SetPackageName("Hmisc")
        'clsCut2Function.AddParameter("g", "4", iPosition:=1)
        'clsCut2Function.AddParameter("m", "1", iPosition:=2)
        clsCut2Function.AddParameter("cuts", clsRFunctionParameter:=ucrMultipleNumericRecode.clsRList, iPosition:=3)
        AddParameters()

        ucrBase.clsRsyntax.SetBaseRFunction(clsCut2Function)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrNudMinimum.SetRCode(clsCut2Function, bReset)
        ucrNudQuantiles.SetRCode(clsCut2Function, bReset)
        ucrReceiverRecode.SetRCode(clsCut2Function, bReset)
        ucrSaveRecode.SetRCode(clsCut2Function, bReset)

    End Sub

    Private Sub TestOKEnabled()
        'Dim iTemp As Integer

        If Not ucrReceiverRecode.IsEmpty() AndAlso Not ucrMultipleNumericRecode.IsEmpty AndAlso ucrSaveRecode.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    'Private Sub ucrMultipleNumericRecode_NameChanged() Handles ucrMultipleNumericRecode.NameChanged
    '    '    'Warning: Apparently the event is raised twice, such that the message is sent twice...
    '    '    'This sub is sending validation errors to the user for him/her to fill in the settingsof the dialogue in an appropriate way.
    '    '    'In case he/she enters only one number in ucrMultipleNumericRecode, this number has to be greater than one, as it is the number of intervals for cut.
    '    '    'Otherwise, if the user enters the list of break points, the resulting number of intervals should be smaller than the number of labels (see
    '    '    If ucrMultipleNumericRecode.GetText <> "" AndAlso ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 Then
    '    '        MsgBox("If the input of break points is a single number, it is understood as the number of intervals. It has to be > 1, otherwise an error will occur.", vbOKOnly, "Validation Error")
    '    '    Else
    '    '        ValidateBreakPointLabelCount()
    '    '    End If
    '    'ucrBase.clsRsyntax.AddParameter("cuts", clsRFunctionParameter:=ucrMultipleNumericRecode.clsRList)
    'End Sub

    'Private Sub ucrMultipleNumericRecode_Validated(sender As Object, e As EventArgs) Handles ucrMultipleNumericRecode.Validated
    '    'ValidateBreakPointLabelCount()
    'End Sub

    Private Sub AddParameters()
        If ucrChkAddLabels.Checked Then
            clsCut2Function.AddParameter(New RParameter("levels.mean", "TRUE", iNewPosition:=5))
            clsCut2Function.AddParameter(New RParameter("digits", "3", iNewPosition:=6))
        Else
            clsCut2Function.RemoveParameterByName("levels.mean")
            clsCut2Function.RemoveParameterByName("digits")
        End If

        If ucrChkMinimum.Checked = True Then
            ucrChkMinimum.Visible = True
        ElseIf ucrChkQuantiles.Checked = True Then
            ucrNudQuantiles.Visible = True
        Else
            ucrNudQuantiles.Visible = False
            ucrNudMinimum.Visible = False
        End If
    End Sub


    'Private Sub ValidateBreakPointLabelCount()
    '    Dim iTemp As Integer

    '    If Not ucrMultipleNumericRecode.IsEmpty() Then
    '        If ucrMultipleNumericRecode.clsRList.clsParameters.Count > 1 Then
    '            MsgBox("There must be one less label than the number of break points. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
    '        ElseIf ucrMultipleNumericRecode.clsRList.clsParameters.Count = 1 AndAlso Integer.TryParse(ucrMultipleNumericRecode.clsRList.clsParameters(0).strArgumentValue, iTemp) Then
    '            MsgBox("There must be the same number of labels to the number of intervals. Ok will not be enabled until this is resolved.", vbOKOnly, "Validation Error")
    '        End If
    '    End If
    'End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrMultipleNumericRecode.ControlContentsChanged, ucrReceiverRecode.ControlContentsChanged,
            ucrSaveRecode.ControlContentsChanged, ucrChkAddLabels.ControlContentsChanged, ucrNudMinimum.ControlContentsChanged, ucrNudQuantiles.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkAddLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddLabels.ControlValueChanged
        AddParameters()
    End Sub
End Class