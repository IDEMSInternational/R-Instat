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
Public Class dlgSurvivalObject
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private clsRightLeftFunction As New RFunction
    Private clsStartEndFunction As New RFunction
    Private clsInterval2Function As New RFunction
    Private clsModifyOperation As New ROperator
    Private clsCFunction As New RFunction
    Private clsCreateObjectScript As New RFunction
    Private clsCreateObjectScriptPaste As New RFunction

    Private Sub dlgSurvivalObject_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.iHelpTopicID = 

        'ucrPnl
        ucrPnlType.SetParameter(New RParameter("type", 3))
        ucrPnlType.AddRadioButton(rdoRight, Chr(34) & "right" & Chr(34))
        ucrPnlType.AddRadioButton(rdoLeft, Chr(34) & "left" & Chr(34))
        ucrPnlType.AddRadioButton(rdoCounting, Chr(34) & "counting" & Chr(34))
        ucrPnlType.AddRadioButton(rdoInterval, Chr(34) & "interval" & Chr(34))
        ucrPnlType.AddRadioButton(rdoInterval2, Chr(34) & "interval2" & Chr(34))
        ucrPnlType.AddRadioButton(rdoMstate, Chr(34) & "mstate" & Chr(34))
        ucrPnlType.SetRDefault(Chr(34) & "right" & Chr(34))
        ' Note that this is the default in R when the status is not a factor
        ' but status should not be a factor variable for "right", hence this is the R default here.

        ' entry time always is time
        ' exit time is time or time2 depending if rdoright, left are selected, or one of the other four are
        ucrPnlType.AddToLinkedControls(ucrReceiverEntry, {rdoCounting, rdoInterval, rdoInterval2, rdoMstate}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlType.AddToLinkedControls(ucrReceiverEvent, {rdoRight, rdoLeft, rdoCounting, rdoInterval, rdoMstate}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlType.AddToLinkedControls(ucrInputOrigin, {rdoCounting}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        'ucrSelector
        ucrSelectorFitObject.SetParameter(New RParameter("data", 0))
        ucrSelectorFitObject.SetParameterIsrfunction()

        'ucrReceiver:
        ' ENTRY: `time` argument only. Only visible for c, i, i2, ms
        ucrReceiverEntry.SetParameter(New RParameter("time", 0))
        ucrReceiverEntry.SetParameterIsString()
        ucrReceiverEntry.bWithQuotes = False
        ucrReceiverEntry.Selector = ucrSelectorFitObject
        ' allows numeric or logical, but not factor
        ucrReceiverEntry.SetIncludedDataTypes({"numeric", "integer"}, bStrict:=True)
        ucrReceiverEntry.SetLinkedDisplayControl(lblEntryTime)

        ' EXIT: `time` arg for r, l
        '       `time2` for c, i, i2, ms
        ucrReceiverExit.SetParameter(New RParameter("time", 1))
        ucrReceiverExit.SetParameterIsString()
        ucrReceiverExit.bWithQuotes = False
        ucrReceiverExit.Selector = ucrSelectorFitObject
        ucrReceiverExit.SetMeAsReceiver()
        ucrReceiverExit.SetIncludedDataTypes({"numeric", "integer"}, bStrict:=True)
        ucrReceiverExit.SetLinkedDisplayControl(lblExitTime2)

        ucrReceiverEvent.SetParameter(New RParameter("event", 0, bNewIncludeArgumentName:=False)) ' to left of %in% operator
        ucrReceiverEvent.SetParameterIsString()
        ucrReceiverEvent.bWithQuotes = False
        ucrReceiverEvent.Selector = ucrSelectorFitObject
        ucrReceiverEvent.SetIncludedDataTypes({"numeric", "factor"}, bStrict:=True)
        ucrReceiverEvent.SetLinkedDisplayControl(lblEvent)

        ' only display if counting is selected
        ucrInputOrigin.SetParameter(New RParameter("origin", 4))
        ucrInputOrigin.SetLinkedDisplayControl(lblOrigin)
        ucrInputOrigin.SetValidationTypeAsNumeric(dcmMin:=Integer.MinValue,
                                                  dcmMax:=Integer.MaxValue)
        ucrInputOrigin.AddQuotesIfUnrecognised = False
        ucrInputOrigin.SetRDefault("0")

        'ucrChk
        ucrChkModifyEvent.SetText("Modify Event")
        ucrChkModifyEvent.AddParameterIsROperatorCondition(True, "%in%", True)
        ucrChkModifyEvent.SetDefaultState(False)

        'ucrInput
        ucrModifyEventNumeric.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrModifyEventNumeric.SetValidationTypeAsNumericList(dcmMin:=Integer.MinValue,
                                                             dcmMax:=Integer.MaxValue)
        ucrModifyEventNumeric.AddQuotesIfUnrecognised = False

        'logical
        ucrModifyEventLogical.SetParameter(New RParameter("z", 0, bNewIncludeArgumentName:=False))
        Dim dctLogical As New Dictionary(Of String, String)
        dctLogical.Add("TRUE", "TRUE")
        dctLogical.Add("FALSE", "FALSE")
        ucrModifyEventLogical.SetItems(dctLogical)
        ucrModifyEventLogical.SetRDefault("TRUE")
        ucrModifyEventLogical.SetDropDownStyleAsNonEditable()

        'ucrFactorLevels
        ucrModifyEventFactor.strSelectorColumnName = "Event Occurs"
        ucrModifyEventFactor.SetReceiver(ucrReceiverEvent)
        ucrModifyEventFactor.SetAsMultipleSelector()
        ucrModifyEventFactor.SetIncludeLevels(False)

        ucrSaveObject.SetPrefix("surv")
        ucrSaveObject.SetSaveTypeAsSurv()
        ucrSaveObject.SetDataFrameSelector(ucrSelectorFitObject.ucrAvailableDataFrames)
        ucrSaveObject.SetLabelText("Survival Object Name:")
        ucrSaveObject.SetIsComboBox()
        ucrSaveObject.SetAssignToBooleans(bTempAssignToIsPrefix:=True)

        ttEventInterval.SetToolTip(ucrReceiverEvent, "When interval-censored, the 'Event' variable takes 0=right censored, 1=event at time, 2=left censored, 3=interval censored.")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsRightLeftFunction = New RFunction
        clsStartEndFunction = New RFunction
        clsInterval2Function = New RFunction
        clsModifyOperation = New ROperator
        clsCFunction = New RFunction
        clsCreateObjectScript = New RFunction
        clsCreateObjectScriptPaste = New RFunction

        ucrSelectorFitObject.Reset()
        ucrSaveObject.Reset()
        lblModifyEvent.Visible = False

        clsRightLeftFunction.SetPackageName("survival")
        clsRightLeftFunction.SetRCommand("Surv")
        clsRightLeftFunction.AddParameter("type", Chr(34) & "right" & Chr(34), iPosition:=3)

        clsStartEndFunction.SetPackageName("survival")
        clsStartEndFunction.SetRCommand("Surv")

        clsInterval2Function.SetPackageName("survival")
        clsInterval2Function.SetRCommand("Surv")

        clsCFunction.SetRCommand("c")

        clsModifyOperation.SetOperation("%in%")
        clsModifyOperation.AddParameter("c_function", clsRFunctionParameter:=clsCFunction, iPosition:=1)

        clsDefaultFunction.SetRCommand("with")
        clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction, iPosition:=1)

        clsCreateObjectScript.SetRCommand("cat")
        clsCreateObjectScriptPaste.SetRCommand("paste")
        clsCreateObjectScriptPaste.AddParameter("sep", Chr(34) & ", " & Chr(34), iPosition:=3)
        clsCreateObjectScript.AddParameter("x", clsRFunctionParameter:=clsCreateObjectScriptPaste, bIncludeArgumentName:=False, iPosition:=0)
        clsCreateObjectScript.AddParameter("after_cols", Chr(34) & "used to create the Survival Object:" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsCreateObjectScript.AddParameter("surv_name", Chr(34) & ucrSaveObject.ucrInputComboSave.GetText() & Chr(34), iPosition:=2, bIncludeArgumentName:=False)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)

        ucrBase.clsRsyntax.AddToAfterCodes(clsCreateObjectScript)
        clsCreateObjectScript.iCallType = 2

        ModifyOptions()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverExit.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("time2", 1), iAdditionalPairNo:=1)
        ucrReceiverExit.AddAdditionalCodeParameterPair(clsInterval2Function, New RParameter("time2", 1), iAdditionalPairNo:=2)
        ucrPnlType.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("type", 3), iAdditionalPairNo:=1)
        ucrPnlType.AddAdditionalCodeParameterPair(clsInterval2Function, New RParameter("type", 3), iAdditionalPairNo:=2)
        ucrReceiverEntry.AddAdditionalCodeParameterPair(clsInterval2Function, New RParameter("time", 2), iAdditionalPairNo:=1)
        ucrReceiverEvent.AddAdditionalCodeParameterPair(clsRightLeftFunction, New RParameter("event", 2), iAdditionalPairNo:=1)
        ucrReceiverEvent.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("event", 2), iAdditionalPairNo:=2)

        ucrSelectorFitObject.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverEntry.SetRCode(clsStartEndFunction, bReset)
        ucrReceiverExit.SetRCode(clsRightLeftFunction, bReset)
        ucrPnlType.SetRCode(clsRightLeftFunction, bReset)
        ucrInputOrigin.SetRCode(clsStartEndFunction, bReset)
        ucrSaveObject.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverEvent.SetRCode(clsModifyOperation, bReset)

        ucrModifyEventNumeric.SetRCode(clsCFunction, bReset)
        ucrModifyEventLogical.SetRCode(clsCFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverExit.IsEmpty() OrElse Not ucrSaveObject.IsComplete() Then
            ucrBase.OKEnabled(False)
        Else
            If (rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoCounting.Checked OrElse rdoMstate.Checked) Then
                If ucrReceiverEvent.IsEmpty() OrElse ((ucrReceiverEvent.strCurrDataType = "numeric" OrElse ucrReceiverEvent.strCurrDataType = "integer") AndAlso ucrChkModifyEvent.Checked AndAlso ucrModifyEventNumeric.GetText = "") OrElse (ucrReceiverEvent.strCurrDataType = "factor" AndAlso ucrChkModifyEvent.Checked AndAlso ucrModifyEventFactor.GetSelectedLevels = "") Then
                    ucrBase.OKEnabled(False)
                Else
                    If (rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoMstate.Checked) Then
                        ucrBase.OKEnabled(True)
                    Else '(rdoCounting.Checked) Then
                        If ucrInputOrigin.IsEmpty() OrElse ucrReceiverEntry.IsEmpty() Then
                            ucrBase.OKEnabled(False)
                        Else
                            ucrBase.OKEnabled(True)
                        End If
                    End If
                End If
            Else ' interval or interval2 checked
                If ucrReceiverEntry.IsEmpty() Then
                    ucrBase.OKEnabled(False)
                Else
                    If rdoInterval.Checked AndAlso ucrReceiverEvent.IsEmpty() Then
                        ucrBase.OKEnabled(False)
                    Else
                        ucrBase.OKEnabled(True)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetBaseExpression()
        ' exp = clsRightLeftFunction if right or left censoring occurs
        ' otherwise exp = clsStartEndFunction if one of the other four rdos are selected
        If rdoRight.Checked OrElse rdoLeft.Checked Then
            clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction, iPosition:=1)
        ElseIf rdoCounting.Checked OrElse rdoInterval.Checked Then
            clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsStartEndFunction, iPosition:=1)
        ElseIf rdoMstate.Checked Then
            If ucrReceiverEntry.IsEmpty() Then
                ' if no entry time, then mstate reads the "Exit Time" receiver as time.
                ' if there is entry time, mstate reads te "Exit Time" receiver as time2; "Entry Time" receiver as time.
                clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction, iPosition:=1)
            Else
                clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsStartEndFunction, iPosition:=1)
            End If
        Else
            clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsInterval2Function, iPosition:=1)
        End If
    End Sub

    Private Sub SetCurrentReceiver()
        If (ucrSelectorFitObject.CurrentReceiver Is ucrReceiverEvent()) AndAlso (rdoInterval2.Checked) Then
            ucrReceiverExit.SetMeAsReceiver()
        ElseIf (ucrSelectorFitObject.CurrentReceiver Is ucrReceiverEntry()) AndAlso (rdoRight.Checked OrElse rdoLeft.Checked) Then
            ucrReceiverExit.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ModifyOptions()
        ' checkbox corresponds to operation: %in% 
        ' left (0) is always the event parameter
        ' right (1) changes
        '' if numerical: right is clsCfunction. With value from input box read in
        '' if factor: right is variables checked in factor grid
        '' if logical: right is value from combo box

        If (rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoCounting.Checked OrElse rdoMstate.Checked) AndAlso Not ucrReceiverEvent.IsEmpty Then
            ucrChkModifyEvent.Visible = True

            If ucrChkModifyEvent.Checked Then
                ' have to currently add these variables manually because the ucr that is added changed depending on the data type
                ' and (to my knowledge) we can't yet do this in the automatic system
                clsRightLeftFunction.AddParameter("event", clsROperatorParameter:=clsModifyOperation, iPosition:=2)
                clsStartEndFunction.AddParameter("event", clsROperatorParameter:=clsModifyOperation, iPosition:=2)
                lblModifyEvent.Visible = True

                If ucrReceiverEvent.strCurrDataType = "factor" Then
                    Me.Size = New System.Drawing.Size(662, Me.Height)
                    clsModifyOperation.RemoveParameterByName("c_function")
                    clsModifyOperation.AddParameter("factor_value", ucrModifyEventFactor.GetSelectedLevels(), bIncludeArgumentName:=False, iPosition:=1)

                    ucrModifyEventNumeric.Visible = False
                    ucrModifyEventFactor.Visible = True
                    ucrModifyEventLogical.Visible = False

                Else
                    Me.Size = New System.Drawing.Size(523, Me.Height)
                    clsModifyOperation.RemoveParameterByName("factor_value")
                    clsModifyOperation.AddParameter("c_function", clsRFunctionParameter:=clsCFunction, iPosition:=1)

                    If ucrReceiverEvent.strCurrDataType = "logical" Then
                        clsCFunction.RemoveParameterByName("x")
                        clsCFunction.AddParameter("z", ucrModifyEventLogical.GetText(), bIncludeArgumentName:=False, iPosition:=0)
                        ucrModifyEventNumeric.Visible = False
                        ucrModifyEventFactor.Visible = False
                        ucrModifyEventLogical.Visible = True

                    Else '(if numeric or integer)
                        clsCFunction.RemoveParameterByName("z")
                        clsCFunction.AddParameter("x", ucrModifyEventNumeric.GetText(), bIncludeArgumentName:=False, iPosition:=0)
                        ucrModifyEventNumeric.Visible = True
                        ucrModifyEventFactor.Visible = False
                        ucrModifyEventLogical.Visible = False
                    End If
                End If
            Else
                lblModifyEvent.Visible = False
                clsRightLeftFunction.AddParameter("event", strParameterValue:=ucrReceiverEvent.GetVariableNames(False), iPosition:=2)
                clsStartEndFunction.AddParameter("event", strParameterValue:=ucrReceiverEvent.GetVariableNames(False), iPosition:=2)
                Me.Size = New System.Drawing.Size(523, Me.Height)
                ucrModifyEventNumeric.Visible = False
                ucrModifyEventFactor.Visible = False
                ucrModifyEventLogical.Visible = False
            End If

        Else 'if interval or interval2 checked
            lblModifyEvent.Visible = False
            clsRightLeftFunction.AddParameter("event", strParameterValue:=ucrReceiverEvent.GetVariableNames(False), iPosition:=2)
            clsStartEndFunction.AddParameter("event", strParameterValue:=ucrReceiverEvent.GetVariableNames(False), iPosition:=2)
            Me.Size = New System.Drawing.Size(523, Me.Height)
            ucrChkModifyEvent.Visible = False
            ucrModifyEventNumeric.Visible = False
            ucrModifyEventFactor.Visible = False
            ucrModifyEventLogical.Visible = False
        End If
    End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlType.ControlValueChanged
        ucrReceiverEvent.RemoveIncludedMetadataProperty("class")
        If rdoRight.Checked OrElse rdoLeft.Checked Then
            ucrReceiverEvent.SetIncludedDataTypes({"numeric", "logical"}, bStrict:=True)
        ElseIf rdoInterval.Checked Then
            ucrReceiverEvent.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        Else
            ucrReceiverEvent.SetIncludedDataTypes({"numeric", "factor", "logical"})
        End If

        ' if the variable in the event receiver is factor variable, if you click left/right/i, clear it.
        If ucrReceiverEvent.strCurrDataType = "factor" AndAlso (rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoInterval.Checked) Then
            ucrReceiverEvent.Clear()
            ' if the variable in the event receiver is logical and you click rdoInterval, clear it.
        ElseIf ucrReceiverEvent.strCurrDataType = "logical" AndAlso rdoInterval.Checked Then
            ucrReceiverEvent.Clear()
        End If
        SetCurrentReceiver()
        ModifyOptions()
        SetBaseExpression()
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        clsCreateObjectScriptPaste.AddParameter("col1", strParameterValue:=ucrReceiverExit.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=1)
        clsCreateObjectScript.AddParameter("surv_name", Chr(34) & ucrSaveObject.ucrInputComboSave.GetText() & Chr(34), iPosition:=2, bIncludeArgumentName:=False)

        If Not ucrReceiverEntry.IsEmpty AndAlso ucrReceiverEntry.Visible Then
            clsCreateObjectScriptPaste.AddParameter("col0", strParameterValue:=ucrReceiverEntry.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsCreateObjectScriptPaste.RemoveParameterByName("col0")
        End If

        If ucrReceiverEvent.Visible Then
            clsCreateObjectScriptPaste.AddParameter("col2", strParameterValue:=ucrReceiverEvent.GetVariableNames(), bIncludeArgumentName:=False, iPosition:=2)
        Else
            clsCreateObjectScriptPaste.RemoveParameterByName("col2")
        End If
    End Sub

    Private Sub ucrSelectorFitObject_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorFitObject.ControlValueChanged
        SetCurrentReceiver()
    End Sub

    Private Sub ucrModifyEventControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrModifyEventFactor.ControlValueChanged, ucrModifyEventLogical.ControlValueChanged, ucrChkModifyEvent.ControlValueChanged, ucrReceiverEvent.ControlValueChanged
        ModifyOptions()
    End Sub

    Private Sub ucrReceiverEntryControl(ucrChangedControl As ucrCore) Handles ucrReceiverEntry.ControlValueChanged
        SetBaseExpression()
    End Sub

    Private Sub ucrCoreControls(ucrChangedControl As ucrCore) Handles ucrReceiverExit.ControlContentsChanged, ucrSaveObject.ControlContentsChanged, ucrInputOrigin.ControlContentsChanged, ucrModifyEventFactor.ControlContentsChanged, ucrModifyEventNumeric.ControlContentsChanged, ucrReceiverEntry.ControlContentsChanged, ucrChkModifyEvent.ControlContentsChanged, ucrReceiverEvent.ControlContentsChanged, ucrPnlType.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class