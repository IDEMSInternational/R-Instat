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
    Private clsRepFunction, clsSeqFunction, clsSeqDateFunction As New RFunction
    Private clsByOperator As New ROperator
    Private enumDefaultSequenceOption As DefaultSequenceOption = DefaultSequenceOption.NumericOption
    Private bDefaultOptionChanged As Boolean = False
    'used to determine if the preview script has changed and whether to reresh preview or not
    Private strPreviewScript As String = ""

    Private Enum DefaultSequenceOption
        NumericOption
        DateOption
    End Enum

    Private Sub dlgRegularSequence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)

        If bDefaultOptionChanged Then
            SetSelectedDefaultSequenceOption()
            bDefaultOptionChanged = False
        End If

        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub SetSelectedDefaultSequenceOption()
        Select Case enumDefaultSequenceOption
            Case DefaultSequenceOption.NumericOption
                rdoNumeric.Checked = True
            Case DefaultSequenceOption.DateOption
                rdoDates.Checked = True
        End Select
    End Sub

    ''' <summary>
    ''' sets the dialog to be shown with 'numeric' option as the default option
    ''' </summary>
    Public Sub SetNumericSequenceAsDefaultOption()
        enumDefaultSequenceOption = DefaultSequenceOption.NumericOption
        bDefaultOptionChanged = True
    End Sub

    ''' <summary>
    ''' sets the dialog to be shown with 'numeric' option as the default option
    ''' </summary>
    Public Sub SetDateSequenceAsDefaultOption()
        enumDefaultSequenceOption = DefaultSequenceOption.DateOption
        bDefaultOptionChanged = True
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 30
        '-------------- seq controls -----------------------
        ucrInputFrom.SetParameter(New RParameter("from", 0))
        ucrInputFrom.AddQuotesIfUnrecognised = False
        ucrInputFrom.SetValidationTypeAsNumeric()

        ucrInputTo.SetParameter(New RParameter("to", 1))
        ucrInputTo.AddQuotesIfUnrecognised = False
        ucrInputTo.SetValidationTypeAsNumeric()

        '--------------- seq.Date controls ---------------
        ucrDateTimePickerFrom.SetParameter(New RParameter("from", 0))
        ucrDateTimePickerFrom.SetParameterIsRDate()

        ucrDateTimePickerTo.SetParameter(New RParameter("to", 1))
        ucrDateTimePickerTo.SetParameterIsRDate()

        Dim dctDatesBy As New Dictionary(Of String, String) From {
            {"Days", "days"},
            {"Weeks", "weeks"},
            {"Months", "months"},
            {"Years", "years"}
        }
        ucrInputComboDatesBy.SetParameter(New RParameter("period", 1, bNewIncludeArgumentName:=False))
        ucrInputComboDatesBy.SetItems(dctDatesBy)
        ucrInputComboDatesBy.SetDropDownStyleAsNonEditable()

        '---------------- seq and seq.Date controls-----------
        ucrInputInStepsOf.SetParameter(New RParameter("by", 2))
        ucrInputInStepsOf.AddQuotesIfUnrecognised = False
        ucrInputInStepsOf.SetValidationTypeAsNumeric()

        '--------------- repeat controls --------------------
        ucrNudRepeatValues.SetParameter(New RParameter("each", 1))
        ucrNudRepeatValues.SetMinMax(1, Integer.MaxValue)

        ucrDataFrameLength.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        ucrDataFrameLength.SetParameter(New RParameter("length.out", 3))
        ucrDataFrameLength.AddQuotesIfUnrecognised = False

        ucrPnlSequenceType.AddRadioButton(rdoNumeric)
        ucrPnlSequenceType.AddRadioButton(rdoDates)

        ucrPnlSequenceType.AddParameterValueFunctionNamesCondition(rdoNumeric, "x", "seq")
        ucrPnlSequenceType.AddParameterValueFunctionNamesCondition(rdoDates, "x", "seq.Date")

        ucrPnlSequenceType.AddToLinkedControls({ucrInputFrom, ucrInputTo}, {rdoNumeric}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSequenceType.AddToLinkedControls({ucrDateTimePickerFrom, ucrDateTimePickerTo}, {rdoDates}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSequenceType.AddToLinkedControls({ucrInputComboDatesBy}, {rdoDates}, bNewLinkedHideIfParameterMissing:=True)

        ucrNewColumnName.SetPrefix("regular")
        ucrNewColumnName.SetDataFrameSelector(ucrSelectDataFrameRegularSequence)
        ucrNewColumnName.SetIsComboBox()
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetLabelText("New Column Name:")
        '---------------------------------------------------

        'Temporarily disabled
        ucrChkDefineAsFactor.SetText("Define As Factor")
        ucrChkDefineAsFactor.Enabled = False
        '---------------------------------------------------
    End Sub

    Private Sub SetDefaults()
        clsRepFunction = New RFunction
        clsSeqFunction = New RFunction
        clsSeqDateFunction = New RFunction
        clsByOperator = New ROperator

        ucrSelectDataFrameRegularSequence.Reset()
        ucrDateTimePickerFrom.DateValue = DateAndTime.Now()
        ucrDateTimePickerTo.DateValue = DateAndTime.Now()
        ucrNewColumnName.Reset()

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("from", 1, iPosition:=0)
        clsSeqFunction.AddParameter("to", ucrDataFrameLength.GetDataFrameLength, iPosition:=1)
        clsSeqFunction.AddParameter("by", 1, iPosition:=2)

        clsByOperator.SetOperation(" ")
        clsByOperator.AddParameter("number", 1, iPosition:=0)
        clsByOperator.AddParameter("period", "days", iPosition:=1)
        clsByOperator.bToScriptAsRString = True
        clsByOperator.bSpaceAroundOperation = False

        clsSeqDateFunction.SetRCommand("seq.Date")
        clsSeqDateFunction.AddParameter("from", clsRFunctionParameter:=ucrDateTimePickerFrom.ValueAsRDate, iPosition:=0)
        clsSeqDateFunction.AddParameter("to", clsRFunctionParameter:=ucrDateTimePickerTo.ValueAsRDate, iPosition:=1)
        clsSeqDateFunction.AddParameter("by", clsROperatorParameter:=clsByOperator, iPosition:=2)

        clsRepFunction.SetRCommand("rep")
        clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqFunction, iPosition:=0)
        clsRepFunction.AddParameter("each", 1, iPosition:=2)
        clsRepFunction.AddParameter("length.out", ucrDataFrameLength.GetDataFrameLength, iPosition:=3)

        clsRepFunction.SetAssignTo(ucrNewColumnName.GetText, strTempDataframe:=ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText, bAssignToIsPrefix:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRepFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'command 'seq.Date' and 'seq' controls
        ucrInputInStepsOf.AddAdditionalCodeParameterPair(clsByOperator, New RParameter("number", 0), iAdditionalPairNo:=1)
        ucrInputInStepsOf.SetRCode(clsSeqFunction, bReset)

        'command 'seq' controls
        ucrInputFrom.SetRCode(clsSeqFunction, bReset)
        ucrInputTo.SetRCode(clsSeqFunction, bReset)

        'command 'seq.Date'  controls
        ucrDateTimePickerFrom.SetRCode(clsSeqDateFunction, bReset)
        ucrDateTimePickerTo.SetRCode(clsSeqDateFunction, bReset)
        ucrInputComboDatesBy.SetRCode(clsByOperator, bReset)

        'base command 'rep' controls
        ucrPnlSequenceType.SetRCode(clsRepFunction, bReset)
        ucrNudRepeatValues.SetRCode(clsRepFunction, bReset)
        ucrDataFrameLength.SetRCode(clsRepFunction, bReset)
        ucrNewColumnName.SetRCode(clsRepFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        bReset = True
        SetDefaults()
        SetRCodeForControls(bReset)
        SetSelectedDefaultSequenceOption()
        TestOKEnabled()
        bReset = False
    End Sub

    Private Sub TestOKEnabled()
        If Not String.IsNullOrEmpty(ucrSelectDataFrameRegularSequence.cboAvailableDataFrames.Text) AndAlso
            ucrNewColumnName.IsComplete AndAlso Not ucrInputInStepsOf.IsEmpty AndAlso
            Not ucrNudRepeatValues.IsEmpty Then

            If rdoNumeric.Checked Then
                ucrBase.OKEnabled(Not ucrInputFrom.IsEmpty AndAlso Not ucrInputTo.IsEmpty)
            ElseIf rdoDates.Checked Then
                ucrBase.OKEnabled(Not ucrInputComboDatesBy.IsEmpty)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    ''' <summary>
    ''' displays the sequence that would be added when the R script is executed.
    ''' Also gives feedback on whether the sequence will be truncated or extended
    ''' </summary>
    Private Sub PreviewSequence()
        Try
            Dim clsNewRepClone As RFunction
            Dim clsAsCharacter As New RFunction
            Dim vecSequence As CharacterVector
            Dim strNewPreviewScript As String
            Dim iLength As Integer

            'clone the "rep" command base function
            clsNewRepClone = clsRepFunction.Clone()
            clsNewRepClone.bToBeAssigned = False
            clsNewRepClone.bIsAssigned = False

            'set up "as.character" command to be usde for testing
            clsAsCharacter.SetRCommand("as.character")
            clsAsCharacter.AddParameter("x", clsRFunctionParameter:=clsNewRepClone)

            'if the new peview script is the same as the previous one then no need to refresh preview
            'this check is useful for large data frames.
            strNewPreviewScript = clsAsCharacter.ToScript()
            If strNewPreviewScript = strPreviewScript Then
                Exit Sub
            End If
            strPreviewScript = strNewPreviewScript

            'get the sequence from the R command as it is, and dispay it
            vecSequence = frmMain.clsRLink.RunInternalScriptGetValue(strPreviewScript, bSilent:=True).AsCharacter
            txtPreview.Text = String.Join(", ", vecSequence)

            'remove the "length.out", then check if sequence is truncated or extended
            clsNewRepClone.RemoveParameterByName("length.out")
            vecSequence = frmMain.clsRLink.RunInternalScriptGetValue(clsAsCharacter.ToScript(), bSilent:=True).AsCharacter
            iLength = vecSequence.Length
            If iLength = ucrDataFrameLength.GetDataFrameLength Then
                lblMessage.Text = GetTranslation("Sequence matches the length of the data frame.")
            ElseIf iLength < ucrDataFrameLength.GetDataFrameLength Then
                lblMessage.Text = GetTranslation("Sequence extended to match the length of the data frame.")
            ElseIf iLength > ucrDataFrameLength.GetDataFrameLength Then
                lblMessage.Text = GetTranslation("Sequence truncated to match the length of the data frame.")
            End If
        Catch ex As Exception
            txtPreview.Text = ""
            lblMessage.Text = "No preview available."
        End Try
    End Sub

    Private Sub ucrPnlSequenceType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSequenceType.ControlValueChanged
        If rdoNumeric.Checked Then
            clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqFunction, iPosition:=0)
        ElseIf rdoDates.Checked Then
            clsRepFunction.AddParameter("x", clsRFunctionParameter:=clsSeqDateFunction, iPosition:=0)
        End If
    End Sub

    Private Sub ucrInputStepsOfControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFrom.ControlValueChanged, ucrInputTo.ControlValueChanged, ucrDateTimePickerFrom.ControlValueChanged, ucrDateTimePickerTo.ControlValueChanged, ucrInputComboDatesBy.ControlValueChanged, ucrPnlSequenceType.ControlValueChanged
        'ucrInputInStepsOf will be empty when dialog loads for the first time
        'no need to st value for ucrInputInStepsOf if its empty
        If ucrInputInStepsOf.IsEmpty Then
            Exit Sub
        End If

        If rdoNumeric.Checked Then
            Dim dcmTo As Decimal
            Dim dcmFrom As Decimal
            If Decimal.TryParse(ucrInputTo.GetText, dcmTo) AndAlso Decimal.TryParse(ucrInputFrom.GetText, dcmFrom) Then
                ucrInputInStepsOf.SetName(If(dcmTo >= dcmFrom, "", "-") & ucrInputInStepsOf.GetText().Replace("-", ""))
            End If
        ElseIf rdoDates.Checked Then
            ucrInputInStepsOf.SetName(If(ucrDateTimePickerTo.DateValue >= ucrDateTimePickerFrom.DateValue,
                                          "", "-") & ucrInputInStepsOf.GetText().Replace("-", ""))
        End If

    End Sub

    Private Sub ucrInputInStepsOf_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputInStepsOf.ControlValueChanged
        PreviewSequence()
    End Sub

    Private Sub ucrRepeatControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudRepeatValues.ControlValueChanged, ucrDataFrameLength.ControlValueChanged
        PreviewSequence()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewColumnName.ControlContentsChanged, ucrInputTo.ControlContentsChanged, ucrInputFrom.ControlContentsChanged, ucrInputInStepsOf.ControlContentsChanged, ucrSelectDataFrameRegularSequence.ControlContentsChanged, ucrInputFrom.ControlContentsChanged, ucrInputTo.ControlContentsChanged, ucrInputInStepsOf.ControlContentsChanged, ucrNudRepeatValues.ControlContentsChanged, ucrPnlSequenceType.ControlContentsChanged, ucrInputComboDatesBy.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class
