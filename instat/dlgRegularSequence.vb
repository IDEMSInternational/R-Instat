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
Imports RDotNet

Public Class dlgRegularSequence
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSeqFunction, clsRepFunction As New RFunction
    Private clsSeqDateFunction As New RFunction
    Private bUpdateBy As Boolean = False
    Private clsByDateOperator As New ROperator
    Private clsDefaultStartDate As RFunction
    Private clsDefaultEndDate As RFunction
    Public bNumericIsDefault As Boolean

    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetDefaultRdo()
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub
    'This sub is meant to set the default radiobutton on diffrent places on the Menu.
    Private Sub SetDefaultRdo()
        If bNumericIsDefault Then
            rdoNumeric.Checked = True
        Else
            rdoDates.Checked = True
        End If
    End Sub

    Private Sub InitialiseDialog()
        Dim dctDatesBy As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 30

        ucrInputFrom.SetParameter(New RParameter("from", 0))
        ucrInputFrom.AddQuotesIfUnrecognised = False
        ucrInputFrom.SetValidationTypeAsNumeric()

        ucrInputTo.SetParameter(New RParameter("to", 1))
        ucrInputTo.AddQuotesIfUnrecognised = False
        ucrInputTo.SetValidationTypeAsNumeric()

        ucrInputInStepsOf.SetParameter(New RParameter("by", 2))
        ucrInputInStepsOf.AddQuotesIfUnrecognised = False
        ucrInputInStepsOf.SetValidationTypeAsNumeric(dcmMin:=0, bIncludeMin:=False)

        ucrNudRepeatValues.SetParameter(New RParameter("each", 1))
        ucrNudRepeatValues.SetMinMax(1, Integer.MaxValue)

        ucrDateTimePickerFrom.SetParameter(New RParameter("from", 0))
        ucrDateTimePickerFrom.SetParameterIsRDate()

        ucrDateTimePickerTo.SetParameter(New RParameter("to", 1))
        ucrDateTimePickerTo.SetParameterIsRDate()

        ucrInputComboDatesBy.SetParameter(New RParameter("period", 1, bNewIncludeArgumentName:=False))

        dctDatesBy.Add("Days", "days")
        dctDatesBy.Add("Weeks", "weeks")
        dctDatesBy.Add("Months", "months")
        dctDatesBy.Add("Years", "years")
        ucrInputComboDatesBy.SetItems(dctDatesBy)
        ucrInputComboDatesBy.SetDropDownStyleAsNonEditable()

        ucrDataFrameLengthForRegularSequence.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)

        ucrPnlSequenceType.AddRadioButton(rdoNumeric)
        ucrPnlSequenceType.AddRadioButton(rdoDates)

        'This will be linked to the rep function which will always have the correct sequence function as its x argument
        ucrPnlSequenceType.AddParameterValueFunctionNamesCondition(rdoNumeric, "x", "seq")
        ucrPnlSequenceType.AddParameterValueFunctionNamesCondition(rdoDates, "x", "seq.Date")

        ucrPnlSequenceType.AddToLinkedControls(ucrInputFrom, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSequenceType.AddToLinkedControls(ucrInputTo, {rdoNumeric}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSequenceType.AddToLinkedControls(ucrDateTimePickerFrom, {rdoDates}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSequenceType.AddToLinkedControls(ucrDateTimePickerTo, {rdoDates}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSequenceType.AddToLinkedControls(ucrInputComboDatesBy, {rdoDates}, bNewLinkedHideIfParameterMissing:=True)

        ucrNewColumnName.SetPrefix("regular")
        ucrNewColumnName.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetLabelText("New Column Name:")

        ucrChkDefineAsFactor.SetText("Define As Factor")
        CheckSequenceLength()

        clsDefaultStartDate = New RFunction
        clsDefaultStartDate.SetRCommand("as.Date")
        clsDefaultStartDate.AddParameter("x", Chr(34) & "2018/1/1" & Chr(34))

        clsDefaultEndDate = New RFunction
        clsDefaultEndDate.SetRCommand("as.Date")
        clsDefaultEndDate.AddParameter("x", Chr(34) & "2018/12/31" & Chr(34))

        'Temporarily disabled
        ucrChkDefineAsFactor.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsRepFunction = New RFunction
        clsSeqFunction = New RFunction
        clsByDateOperator = New ROperator
        clsSeqDateFunction = New RFunction

        ucrSelectDataFrameRegularSequence.Reset()
        ucrNewColumnName.Reset()

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 1, iPosition:=0)
        clsSeqFunction.AddParameter("to", ucrSelectDataFrameRegularSequence.iDataFrameLength, iPosition:=1)
        clsSeqFunction.AddParameter("by", 1, iPosition:=2)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqFunction, iPosition:=0)
        clsRepFunction.AddParameter("each", 1, iPosition:=2)
        clsRepFunction.AddParameter("length.out", ucrSelectDataFrameRegularSequence.iDataFrameLength, iPosition:=3)

        clsByDateOperator.SetOperation(" ")
        clsByDateOperator.AddParameter("number", 1, iPosition:=0)
        clsByDateOperator.AddParameter("period", "days", iPosition:=1)
        clsByDateOperator.bToScriptAsRString = True
        clsByDateOperator.bSpaceAroundOperation = False

        clsSeqDateFunction.SetRCommand("seq.Date")
        clsSeqDateFunction.AddParameter("from", clsRFunctionParameter:=clsDefaultStartDate, iPosition:=0)
        clsSeqDateFunction.AddParameter("to", clsRFunctionParameter:=clsDefaultEndDate, iPosition:=1)
        clsSeqDateFunction.AddParameter("by", clsROperatorParameter:=clsByDateOperator, iPosition:=2)

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
        ResetNumberFromToByParameters()
        ucrBase.clsRsyntax.SetBaseRFunction(clsSeqFunction)
    End Sub

    Private Sub ResetNumberFromToByParameters()
        If rdoNumeric.Checked Then
            clsSeqFunction.AddParameter("from", 1, iPosition:=0)
            clsSeqFunction.AddParameter("to", ucrSelectDataFrameRegularSequence.iDataFrameLength, iPosition:=1)
            clsSeqFunction.AddParameter("by", 1, iPosition:=2)
        End If
    End Sub

    Private Sub ucrPnlSequenceType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSequenceType.ControlValueChanged
        If rdoDates.Checked Then
            clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqDateFunction, iPosition:=0)
        ElseIf rdoNumeric.Checked Then
            clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqFunction, iPosition:=0)
        End If
        SetBaseFunction()
        CheckSequenceLength()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        Dim strBy As String
        Dim dcmBy As Decimal

        bUpdateBy = False
        ucrNudRepeatValues.AddAdditionalCodeParameterPair(clsSeqDateFunction, ucrNudRepeatValues.GetParameter(), iAdditionalPairNo:=1)

        ucrDateTimePickerFrom.SetRCode(clsSeqDateFunction, bReset)
        ucrDateTimePickerTo.SetRCode(clsSeqDateFunction, bReset)
        ucrInputComboDatesBy.SetRCode(clsByDateOperator, bReset)

        'Set to base function so that control is set correctly
        ucrNewColumnName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrPnlSequenceType.SetRCode(clsRepFunction, bReset)
        ucrInputFrom.SetRCode(clsSeqFunction, bReset)
        ucrInputTo.SetRCode(clsSeqFunction, bReset)
        ucrNudRepeatValues.SetRCode(clsRepFunction, bReset)
        If clsSeqFunction.ContainsParameter("by") Then
            strBy = clsSeqFunction.GetParameter("by").strArgumentValue
            If strBy IsNot Nothing Then
                If Decimal.TryParse(strBy, dcmBy) Then
                    ucrInputInStepsOf.SetName(Math.Abs(dcmBy))
                Else
                    ucrInputInStepsOf.SetName("")
                End If
            Else
                ucrInputInStepsOf.SetName("")
            End If
        Else
            ucrInputInStepsOf.SetName("")
        End If
        bUpdateBy = True
        CheckSequenceLength()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        SetDefaultRdo()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If ucrNewColumnName.IsComplete Then
            If rdoNumeric.Checked Then
                If ucrInputFrom.GetText <> "" AndAlso ucrInputTo.GetText <> "" AndAlso ucrInputInStepsOf.GetText <> "" AndAlso ucrNudRepeatValues.GetText <> "" AndAlso ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoDates.Checked AndAlso Not ucrInputInStepsOf.IsEmpty AndAlso Not ucrInputComboDatesBy.IsEmpty AndAlso ucrNudRepeatValues.GetText <> "" Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetInStepsOfDateParameter()
        If ucrDateTimePickerTo.DateValue >= ucrDateTimePickerFrom.DateValue Then
            clsByDateOperator.AddParameter("number", ucrInputInStepsOf.GetText(), iPosition:=0)
        Else
            clsByDateOperator.AddParameter("number", "-" & ucrInputInStepsOf.GetText(), iPosition:=0)
        End If
        CheckSequenceLength()
    End Sub

    Private Sub SetInStepsOfNumberParameter()
        Dim dcmTo As Decimal
        Dim dcmFrom As Decimal

        If Not ucrInputTo.IsEmpty AndAlso Not ucrInputFrom.IsEmpty Then
            If Decimal.TryParse(ucrInputTo.GetText, dcmTo) AndAlso Decimal.TryParse(ucrInputFrom.GetText, dcmFrom) Then
                If dcmTo >= dcmFrom Then
                    clsSeqFunction.AddParameter("by", ucrInputInStepsOf.GetText())
                Else
                    clsSeqFunction.AddParameter("by", "-" & ucrInputInStepsOf.GetText())
                End If
            Else
                clsSeqFunction.RemoveParameterByName("by")
            End If
        Else
            clsSeqFunction.RemoveParameterByName("by")
        End If
        CheckSequenceLength()
    End Sub


    Private Sub SetBaseFunction()
        If ucrNudRepeatValues.Value = 1 Then
            If rdoDates.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsSeqDateFunction)
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsSeqFunction)
            End If
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
        End If
        SetAssignTo()
    End Sub

    Private Sub CheckSequenceLength()
        Dim iLength As Integer
        Dim vecSequence As CharacterVector
        Dim expTemp As SymbolicExpression
        Dim strRCommand As String
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean
        Dim clsAsCharacter As New RFunction
        Dim clsRepClone As New RFunction

        lblMessage.Text = ""
        Try
            bIsAssigned = ucrBase.clsRsyntax.clsBaseFunction.bIsAssigned
            bToBeAssigned = ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned
            ucrBase.clsRsyntax.clsBaseFunction.bIsAssigned = False
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = False
            ucrBase.clsRsyntax.RemoveParameter("length.out")
            clsAsCharacter.SetRCommand("as.character")
            clsAsCharacter.AddParameter("x", clsRFunctionParameter:=ucrBase.clsRsyntax.clsBaseFunction)
            strRCommand = clsAsCharacter.ToScript()
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(strRCommand, bSilent:=True)
            vecSequence = expTemp.AsCharacter
            iLength = vecSequence.Length
            If iLength <> ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)
                clsRepFunction.AddParameter("length.out", ucrSelectDataFrameRegularSequence.iDataFrameLength, iPosition:=3)
                clsRepClone = clsRepFunction.Clone()
                clsRepClone.bToBeAssigned = False
                clsRepClone.bIsAssigned = False
                clsAsCharacter.SetRCommand("as.character")
                clsAsCharacter.AddParameter("x", clsRFunctionParameter:=clsRepClone)
                strRCommand = clsAsCharacter.ToScript()
                bIsAssigned = False
                vecSequence = frmMain.clsRLink.RunInternalScriptGetValue(strRCommand, bSilent:=True).AsCharacter
                ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
                If iLength < ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                    lblMessage.Text = "Sequence extended to match" & Environment.NewLine & "the length of the data frame."
                ElseIf iLength > ucrSelectDataFrameRegularSequence.iDataFrameLength Then
                    lblMessage.Text = "Sequence truncated to match" & Environment.NewLine & "the length of the data frame."
                End If
            Else
                clsRepFunction.RemoveParameterByName("length.out")
                lblMessage.Text = "Sequence matches the length of the data frame."
            End If
            txtGetPreview.Text = ""
            txtGetPreview.Text = String.Join(", ", vecSequence)
            ucrBase.clsRsyntax.clsBaseFunction.bIsAssigned = bIsAssigned
            ucrBase.clsRsyntax.clsBaseFunction.bToBeAssigned = bToBeAssigned
        Catch ex As Exception
            txtGetPreview.Text = ""
            lblMessage.Text = "No preview available."
        End Try
    End Sub

    Private Sub ucrSelectDataFrameRegularSequence_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectDataFrameRegularSequence.ControlValueChanged
        If ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" Then
            Try
                ucrInputTo.SetName(frmMain.clsRLink.GetDataFrameLength(ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text))
            Catch ex As Exception
                ucrInputTo.SetName("")
            End Try
        End If
        SetAssignTo()
    End Sub

    Private Sub ucrNudRepeatValues_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudRepeatValues.ControlValueChanged
        SetBaseFunction()
        CheckSequenceLength()
    End Sub

    Private Sub ucrInputNumberControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFrom.ControlValueChanged, ucrInputTo.ControlValueChanged, ucrInputInStepsOf.ControlValueChanged
        If bUpdateBy Then
            SetInStepsOfNumberParameter()
        End If
    End Sub

    Private Sub ucrInputDateControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDateTimePickerFrom.ControlValueChanged, ucrDateTimePickerTo.ControlValueChanged, ucrInputComboDatesBy.ControlValueChanged
        If bUpdateBy Then
            SetInStepsOfDateParameter()
        End If
    End Sub

    Private Sub ucrNewColumnName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlValueChanged
        SetAssignTo()
    End Sub

    Private Sub SetAssignTo()
        If ucrNewColumnName.IsComplete AndAlso ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text <> "" Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewColumnName.GetText(), strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText())
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub

    Private Sub ucrInputComboDatesBy_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboDatesBy.ControlValueChanged
        ResetNumberFromToByParameters()
    End Sub
    Private Sub lblPreview_Click(sender As Object, e As EventArgs) Handles lblPreview.Click

    End Sub

    Private Sub lblMessage_Click(sender As Object, e As EventArgs) Handles lblMessage.Click

    End Sub

    Private Sub ucrNewColumnName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrInputTo.ControlContentsChanged, ucrInputFrom.ControlContentsChanged, ucrInputInStepsOf.ControlContentsChanged, ucrSelectDataFrameRegularSequence.ControlContentsChanged, ucrInputFrom.ControlContentsChanged, ucrInputTo.ControlContentsChanged, ucrInputInStepsOf.ControlContentsChanged, ucrNudRepeatValues.ControlContentsChanged, ucrPnlSequenceType.ControlContentsChanged, ucrInputComboDatesBy.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
