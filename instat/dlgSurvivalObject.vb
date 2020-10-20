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

    Private Sub dlgSurvivalObject_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
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
        ucrReceiverEntry.SetParameterIsRFunction()
        ucrReceiverEntry.Selector = ucrSelectorFitObject
        ' allows numeric or logical, but not factor
        ucrReceiverEntry.SetIncludedDataTypes({"numeric"})
        ucrReceiverEntry.SetLinkedDisplayControl(lblEntryTime)

        ' EXIT: `time` arg for r, l
        '       `time2` for c, i, i2, ms
        ucrReceiverExit.SetParameter(New RParameter("time", 1))
        ucrReceiverExit.SetParameterIsRFunction()
        ucrReceiverExit.Selector = ucrSelectorFitObject
        ucrReceiverExit.SetMeAsReceiver()
        ucrReceiverExit.SetIncludedDataTypes({"numeric"})
        ucrReceiverExit.SetLinkedDisplayControl(lblExitTime2)

        ucrReceiverEvent.SetParameter(New RParameter("event", 0, bNewIncludeArgumentName:=False)) ' to left of %in% operator
        ucrReceiverEvent.SetParameterIsRFunction()
        ucrReceiverEvent.Selector = ucrSelectorFitObject
        ucrReceiverEvent.SetIncludedDataTypes({"numeric", "factor"}, bStrict:=True)
        ucrReceiverEvent.SetLinkedDisplayControl(lblEvent)

        ' only display if counting is selected
        ucrInputOrigin.SetParameter(New RParameter("origin", 4))
        ucrInputOrigin.SetLinkedDisplayControl(lblOrigin)
        ucrInputOrigin.SetValidationTypeAsNumeric(dcmMin:=Integer.MinValue,
                                                  dcmMax:=Integer.MaxValue)
        ucrInputOrigin.AddQuotesIfUnrecognised = False
        ucrInputOrigin.SetRDefault(0)

        'ucrChk
        ucrChkModifyEvent.SetText("Modify Event")
        'ucrReceiverEvent.AddToLinkedControls(ucrModifyEventNumeric, {"numeric"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkModifyEvent.AddParameterIsROperatorCondition(True, "%in%", True)
        ucrChkModifyEvent.SetDefaultState(False)

        'ucrInput
        ucrModifyEventNumeric.SetParameter(New RParameter("x", bNewIncludeArgumentName:=False))
        ucrModifyEventNumeric.SetValidationTypeAsNumericList(dcmMin:=Integer.MinValue,
                                                             dcmMax:=Integer.MaxValue)
        ucrModifyEventNumeric.SetLinkedDisplayControl(lblSelectLevels)
        ucrModifyEventNumeric.AddQuotesIfUnrecognised = False

        'ucrFactorLevels
        ucrModifyEventFactor.strSelectorColumnName = "Event Occurs"
        ucrModifyEventFactor.SetReceiver(ucrReceiverEvent)
        ucrModifyEventFactor.SetAsMultipleSelector()
        ucrModifyEventFactor.SetIncludeLevels(False)

        ucrSaveObject.SetSaveTypeAsSurv()
        ucrSaveObject.SetDataFrameSelector(ucrSelectorFitObject.ucrAvailableDataFrames)
        ucrSaveObject.SetLabelText("Save Survival Object:")
        ucrSaveObject.SetIsComboBox()
        ucrSaveObject.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsRightLeftFunction = New RFunction
        clsStartEndFunction = New RFunction
        clsInterval2Function = New RFunction
        clsModifyOperation = New ROperator
        clsCFunction = New RFunction

        ucrSelectorFitObject.Reset()
        ucrSaveObject.Reset()

        clsRightLeftFunction.SetPackageName("survival")
        clsRightLeftFunction.SetRCommand("Surv")
        clsRightLeftFunction.AddParameter("type", Chr(34) & "right" & Chr(34), iPosition:=3)

        clsStartEndFunction.SetPackageName("survival")
        clsStartEndFunction.SetRCommand("Surv")

        clsInterval2Function.SetPackageName("survival")
        clsInterval2Function.SetRCommand("Surv")

        ' TODO If I check several options in the factor dlg, then it runs c(c())
        clsCFunction.SetRCommand("c")

        clsModifyOperation.SetOperation("%in%")
        clsModifyOperation.AddParameter(clsRFunctionParameter:=clsCFunction, iPosition:=1)

        clsDefaultFunction.SetRCommand("with")
        clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction)
        ' TODO fix up the set assign to as currently it is always running surv()
        clsDefaultFunction.SetAssignTo(strTemp:="surv", strTempDataframe:=ucrSelectorFitObject.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempSurv:="surv", bAssignToIsPrefix:=True)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)

        SetBaseRFunction()
        ViewingModifyOptions()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverExit.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("time2", 1), iAdditionalPairNo:=1)
        ucrReceiverExit.AddAdditionalCodeParameterPair(clsInterval2Function, New RParameter("time2", 1), iAdditionalPairNo:=2)
        ucrPnlType.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("type", 3), iAdditionalPairNo:=1)
        ucrPnlType.AddAdditionalCodeParameterPair(clsInterval2Function, New RParameter("type", 3), iAdditionalPairNo:=2)
        ucrReceiverEntry.AddAdditionalCodeParameterPair(clsInterval2Function, New RParameter("time", 2), iAdditionalPairNo:=1)

        ucrSelectorFitObject.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverEntry.SetRCode(clsStartEndFunction, bReset)
        ucrReceiverExit.SetRCode(clsRightLeftFunction, bReset)
        ucrPnlType.SetRCode(clsRightLeftFunction, bReset)
        ucrInputOrigin.SetRCode(clsStartEndFunction, bReset)
        ucrSaveObject.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverEvent.SetRCode(clsModifyOperation, bReset)

        ucrModifyEventNumeric.SetRCode(clsCFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverExit.IsEmpty() OrElse Not ucrSaveObject.IsComplete() Then
            ucrBase.OKEnabled(False)
        Else
            If (rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoCounting.Checked OrElse rdoInterval.Checked OrElse rdoMstate.Checked) Then
                If ucrReceiverEvent.IsEmpty() OrElse ((ucrReceiverEvent.strCurrDataType = "numeric" OrElse ucrReceiverEvent.strCurrDataType = "integer") AndAlso ucrChkModifyEvent.Checked AndAlso ucrModifyEventNumeric.GetText = "") OrElse (ucrReceiverEvent.strCurrDataType = "factor" AndAlso ucrChkModifyEvent.Checked AndAlso ucrModifyEventFactor.GetSelectedLevels = "") Then
                    ucrBase.OKEnabled(False)
                Else
                    If (rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoMstate.Checked) Then
                        ucrBase.OKEnabled(True)
                    ElseIf (rdoCounting.Checked) Then
                        If ucrInputOrigin.IsEmpty() OrElse ucrReceiverEntry.IsEmpty() Then
                            ucrBase.OKEnabled(False)
                        Else
                            ucrBase.OKEnabled(True)
                        End If
                    Else 'rdoInterval.Checked
                        If ucrReceiverEntry.IsEmpty() Then
                            ucrBase.OKEnabled(False)
                        Else
                            ucrBase.OKEnabled(True)
                        End If
                    End If
                End If
            Else ' rdoInterval2.checked
                If ucrReceiverEntry.IsEmpty() Then
                    ucrBase.OKEnabled(False)
                Else
                    ucrBase.OKEnabled(True)
                End If
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub SetBaseRFunction()
        ' exp = clsRightLeftFunction if right or left censoring occurs
        ' otherwise exp = clsStartEndFunction if one of the other four rdos are selected
        If rdoRight.Checked OrElse rdoLeft.Checked Then
            clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction)
        ElseIf rdoCounting.Checked OrElse rdoInterval.Checked Then
            clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsStartEndFunction)
        ElseIf rdoMstate.Checked Then
            If ucrReceiverEntry.IsEmpty() Then
                ' if no entry time, then mstate reads the "Exit Time" receiver as time.
                ' if there is entry time, mstate reads the "Exit Time" receiver as time2; "Entry Time" receiver as time.
                clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction)
            Else
                clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsStartEndFunction)
            End If
        Else
            clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsInterval2Function)
        End If
    End Sub

    Private Sub SetReceivers()
        If ucrSelectorFitObject.CurrentReceiver.Name Is "ucrReceiverEvent" Then
            If (rdoInterval2.Checked) Then
                ucrReceiverExit.SetMeAsReceiver()
            End If
        ElseIf ucrSelectorFitObject.CurrentReceiver.Name Is "ucrReceiverEntry" Then
            If (rdoRight.Checked OrElse rdoLeft.Checked) Then
                ucrReceiverExit.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub ViewingModifyOptions()
        If (rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoCounting.Checked OrElse rdoMstate.Checked OrElse rdoInterval.Checked) AndAlso Not ucrReceiverEvent.IsEmpty Then
            ucrChkModifyEvent.Visible = True

            If ucrChkModifyEvent.Checked Then
                Me.Size = New System.Drawing.Size(692, Me.Height)
                lblSelectLevels.Visible = True
                clsRightLeftFunction.AddParameter("event", clsROperatorParameter:=clsModifyOperation, iPosition:=2)
                clsStartEndFunction.AddParameter("event", clsROperatorParameter:=clsModifyOperation, iPosition:=2)
                ' have to currently add these variables into the c() function manually
                ' this is because the ucr that is added changed depending on the data type
                ' and (to my knowledge) we can't yet do this in the automatic system

                If ucrReceiverEvent.strCurrDataType = "numeric" OrElse ucrReceiverEvent.strCurrDataType = "integer" Then
                    ucrModifyEventNumeric.Visible = True
                    ucrModifyEventFactor.Visible = False
                    clsCFunction.RemoveParameterByName("y")
                    clsCFunction.AddParameter("x", ucrModifyEventNumeric.GetText(), bIncludeArgumentName:=False)
                Else
                    ucrModifyEventNumeric.Visible = False
                    ucrModifyEventFactor.Visible = True
                    clsCFunction.RemoveParameterByName("x")
                    clsCFunction.AddParameter("y", ucrModifyEventFactor.GetSelectedLevels(), bIncludeArgumentName:=False)
                End If

            Else
                Me.Size = New System.Drawing.Size(448, Me.Height)
                ucrModifyEventNumeric.Visible = False
                ucrModifyEventFactor.Visible = False
                clsCFunction.RemoveParameterByName("y")
                clsCFunction.RemoveParameterByName("x")
                clsRightLeftFunction.AddParameter("event", clsRFunctionParameter:=ucrReceiverEvent.GetVariables, iPosition:=2)
                clsStartEndFunction.AddParameter("event", clsRFunctionParameter:=ucrReceiverEvent.GetVariables, iPosition:=2)
            End If

        Else
            ucrChkModifyEvent.Visible = False
            Me.Size = New System.Drawing.Size(448, Me.Height)
            ucrModifyEventNumeric.Visible = False
            ucrModifyEventFactor.Visible = False
            clsCFunction.RemoveParameterByName("y")
            clsCFunction.RemoveParameterByName("x")
            clsRightLeftFunction.AddParameter("event", clsRFunctionParameter:=ucrReceiverEvent.GetVariables, iPosition:=2)
            clsStartEndFunction.AddParameter("event", clsRFunctionParameter:=ucrReceiverEvent.GetVariables, iPosition:=2)
            ' interval has its own function without this event parameter
        End If
    End Sub

    Private Sub ucrPnl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlType.ControlContentsChanged
        If rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoInterval.Checked Then
            ucrReceiverEvent.RemoveIncludedMetadataProperty("class")
            ucrReceiverEvent.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        Else
            ucrReceiverEvent.RemoveIncludedMetadataProperty("class")
            ucrReceiverEvent.SetIncludedDataTypes({"numeric", "factor"}, bStrict:=True)
        End If

        ' if the thing in the event receiver is factor variable, if you click left/right/i, clear it.
        If {"factor"}.Contains(ucrReceiverEvent.strCurrDataType) Then
            If rdoRight.Checked OrElse rdoLeft.Checked OrElse rdoInterval.Checked Then
                ucrReceiverEvent.Clear()
            End If
        End If
        SetReceivers()
        ViewingModifyOptions()
        SetBaseRFunction()
        TestOkEnabled()
    End Sub

    Private Sub ucrModifyEventFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrModifyEventFactor.ControlValueChanged
        If {"factor"}.Contains(ucrReceiverEvent.strCurrDataType) Then
            clsModifyOperation.ClearParameters()
            clsModifyOperation.AddParameter("event", clsRFunctionParameter:=ucrReceiverEvent.GetVariables, bIncludeArgumentName:=False, iPosition:=0)
            clsModifyOperation.AddParameter("y", ucrModifyEventFactor.GetSelectedLevels(), bIncludeArgumentName:=False, iPosition:=1)
        Else
            clsModifyOperation.RemoveParameterByName("y")
            clsModifyOperation.AddParameter(clsRFunctionParameter:=clsCFunction, iPosition:=1)
        End If
    End Sub

    Private Sub ucrSelectorFitObject_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorFitObject.ControlContentsChanged
        SetReceivers()
    End Sub

    Private Sub ucrChkModifyEvent_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkModifyEvent.ControlContentsChanged
        TestOkEnabled()
        ViewingModifyOptions()
    End Sub

    Private Sub ucrReceiverEventControl(ucrChangedControl As ucrCore) Handles ucrReceiverEvent.ControlContentsChanged
        ViewingModifyOptions()
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverEntryControl(ucrChangedControl As ucrCore) Handles ucrReceiverEntry.ControlContentsChanged
        SetBaseRFunction()
        TestOkEnabled()
    End Sub

    Private Sub ucrCoreControls(ucrChangedControl As ucrCore) Handles ucrReceiverExit.ControlContentsChanged, ucrSaveObject.ControlContentsChanged, ucrInputOrigin.ControlContentsChanged, ucrModifyEventFactor.ControlContentsChanged, ucrModifyEventNumeric.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class