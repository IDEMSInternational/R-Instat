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
Public Class dlgSurvivalObject
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private clsRightLeftFunction As New RFunction
    Private clsStartEndFunction As New RFunction
    Private clsModifyFunction As New RFunction
    Private clsModifyOperation As New ROperator
    Private clsModifyFunction2 As New RParameter
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
        DialogWidth()
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
        ' if status is a factor, then mstate is the new default (and it runs mstate even if you type in type = "right" - and consequently does not work in places where right censored data usually works, such as coxph model
        ' so the option "right" cannot be chosen if status is a factor

        ' entry time always is time
        ' exit time is time or time2 depending if rdoright, left are selected, or one of the other four are
        ' attach to different classes for time and time2 to get around this

        ucrPnlType.AddToLinkedControls(ucrReceiverTime1, {rdoCounting, rdoInterval, rdoInterval2, rdoMstate}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlType.AddToLinkedControls(ucrInputOrigin, {rdoCounting}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

        'ucrSelector
        ucrSelectorFitObject.SetParameter(New RParameter("data", 0))
        ucrSelectorFitObject.SetParameterIsrfunction()

        'ucrReceiver
        ucrReceiverTime1.SetParameter(New RParameter("time", 0))
        ucrReceiverTime1.SetParameterIsRFunction()
        ucrReceiverTime1.Selector = ucrSelectorFitObject
        ' allows numeric or logical, but not factor
        ucrReceiverTime1.SetIncludedDataTypes({"numeric"})
        ucrReceiverTime1.SetLinkedDisplayControl(lblEntryTime)

        ucrReceiverTime2.SetParameter(New RParameter("time", 1))
        ucrReceiverTime2.SetParameterIsRFunction()
        ucrReceiverTime2.Selector = ucrSelectorFitObject
        ucrReceiverTime2.SetMeAsReceiver()
        ucrReceiverTime2.SetIncludedDataTypes({"numeric"})
        ucrReceiverTime2.SetLinkedDisplayControl(lblExitTime2)

        ucrReceiverEvent.SetParameter(New RParameter("event", 0, bNewIncludeArgumentName:=False))
        ucrReceiverEvent.SetParameterIsRFunction()
        ucrReceiverEvent.Selector = ucrSelectorFitObject
        ucrReceiverEvent.SetIncludedDataTypes({"numeric"})

        ' only display if counting is selected
        ucrInputOrigin.SetParameter(New RParameter("origin", 4))
        ucrInputOrigin.SetLinkedDisplayControl(lblOrigin)
        ucrInputOrigin.SetValidationTypeAsNumeric(dcmMin:=Integer.MinValue,
                                                  dcmMax:=Integer.MaxValue)
        ucrInputOrigin.AddQuotesIfUnrecognised = False
        ucrInputOrigin.SetRDefault(0)

        'ucrChk
        ucrChkModifyEvent.SetText("Modify Event")
        ' TODO: set up so we can add to linked controls
        ' this can't currently be done (to my knowledge) because we need to specify if it is a factor or numeric
        ' this is currently run manually in the Viewing modify options() sub

        'ucrReceiverEvent.AddToLinkedControls(ucrModifyEventNumeric, {"numeric"}, bNewLinkedHideIfParameterMissing:=True)

        'ucrChkModifyEvent.AddToLinkedControls(ucrModifyEventNumeric, {True}, bNewLinkedHideIfParameterMissing:=True)
        'ucrChkModifyEvent.AddToLinkedControls(ucrModifyEventFactor, {True}, bNewLinkedHideIfParameterMissing:=True)

        'ucrChkModifyEvent.AddParameterValuesCondition(False, "event", ucrReceiverEvent.GetVariables(), True)
        ucrChkModifyEvent.AddParameterIsROperatorCondition(True, "%in%", True)
        ucrChkModifyEvent.SetDefaultState(False)

        'ucrInput
        ucrModifyEventNumeric.SetParameter(New RParameter("x", bNewIncludeArgumentName:=False))
        ucrModifyEventNumeric.SetValidationTypeAsNumericList(dcmMin:=Integer.MinValue,
                                                             dcmMax:=Integer.MaxValue)
        ucrModifyEventNumeric.SetLinkedDisplayControl(lblSelectLevels)
        ucrModifyEventNumeric.AddQuotesIfUnrecognised = False

        'ucrFactorLevels
        ucrModifyEventFactor.SetParameter(New RParameter("y", bNewIncludeArgumentName:=False))
        ucrModifyEventFactor.SetLinkedDisplayControl(lblSelectLevels)
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
        clsModifyFunction = New RFunction
        clsModifyFunction2 = New RParameter
        clsModifyOperation = New ROperator
        clsCFunction = New RFunction

        ucrSelectorFitObject.Reset()
        ucrSaveObject.Reset()

        clsRightLeftFunction.SetPackageName("survival")
        clsRightLeftFunction.SetRCommand("Surv")
        clsRightLeftFunction.AddParameter("type", Chr(34) & "right" & Chr(34), iPosition:=3)

        clsStartEndFunction.SetPackageName("survival")
        clsStartEndFunction.SetRCommand("Surv")

        ' TODO If I check several options in the factor dlg, then it runs c(c())
        clsCFunction.SetRCommand("c")

        clsModifyOperation.SetOperation("%in%")
        clsModifyOperation.AddParameter(clsRFunctionParameter:=clsCFunction, iPosition:=1)

        clsDefaultFunction.SetRCommand("with")
        clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction)
        ' TODO fix up the set assign to as currently it is always running surv()
        clsDefaultFunction.SetAssignTo(strTemp:="surv", strTempDataframe:=ucrSelectorFitObject.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempSurv:="surv", bAssignToIsPrefix:=True)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)

        DialogWidth()
        ViewingModifyOptions()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverTime2.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("time2", 1), iAdditionalPairNo:=1)
        'ucrReceiverEvent.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("event", 2), iAdditionalPairNo:=1)
        'ucrReceiverEvent.AddAdditionalCodeParameterPair(clsRightLeftFunction, New RParameter("event", 2), iAdditionalPairNo:=2)
        ucrPnlType.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("type", 3), iAdditionalPairNo:=1)

        ucrSelectorFitObject.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverTime1.SetRCode(clsStartEndFunction, bReset)
        ucrReceiverTime2.SetRCode(clsRightLeftFunction, bReset)
        ucrPnlType.SetRCode(clsRightLeftFunction, bReset)
        ucrInputOrigin.SetRCode(clsStartEndFunction, bReset)
        ucrSaveObject.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverEvent.SetRCode(clsModifyOperation, bReset)

        ucrModifyEventNumeric.SetRCode(clsCFunction, bReset)
        ucrModifyEventFactor.SetRCode(clsCFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()

        If ucrReceiverTime2.IsEmpty() OrElse ucrReceiverEvent.IsEmpty() OrElse Not ucrSaveObject.IsComplete() OrElse ((ucrReceiverEvent.strCurrDataType = "numeric" OrElse ucrReceiverEvent.strCurrDataType = "integer") AndAlso ucrChkModifyEvent.Checked AndAlso ucrModifyEventNumeric.GetText = "") OrElse (ucrReceiverEvent.strCurrDataType = "factor" AndAlso ucrChkModifyEvent.Checked AndAlso ucrModifyEventFactor.GetSelectedLevels = "") Then
            ucrBase.OKEnabled(False)
        Else
            If (rdoMstate.Checked OrElse rdoCounting.Checked OrElse rdoInterval.Checked OrElse rdoInterval2.Checked) AndAlso ucrReceiverTime1.IsEmpty() Then
                ucrBase.OKEnabled(False)
            Else
                If rdoCounting.Checked AndAlso ucrInputOrigin.IsEmpty() Then
                    ucrBase.OKEnabled(False)
                Else
                    ucrBase.OKEnabled(True)
                End If
            End If
        End If

        ' TODO add chkbox stuff in here
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnl_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlType.ControlContentsChanged
        ' exp = clsRightLeftFunction if right or left censoring occurs
        ' otherwise exp = clsStartEndFunction if one Then Of the other four rdos are selected

        If rdoRight.Checked = True OrElse rdoLeft.Checked = True Then
            clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction)
        Else
            clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsStartEndFunction)

            '            If ucrReceiverTime1.focused Then ' TODO what is the correct code for this line?
            '            ucrReceiverTime2.SetMeAsReceiver()
            '        End If

        End If

        ' mstate allows factors
        If rdoMstate.Checked OrElse rdoCounting.Checked Then
            ' todo: why doesn't this line work?
            ucrReceiverEvent.SetIncludedDataTypes({"factor", "numeric"})
        Else
            ucrReceiverEvent.SetIncludedDataTypes({"numeric"})
        End If

        ViewingModifyOptions()
        TestOkEnabled()
    End Sub

    Private Sub DialogWidth()
        If ucrChkModifyEvent.Checked Then
            Me.Size = New System.Drawing.Size(692, Me.Height)
        Else
            Me.Size = New System.Drawing.Size(448, Me.Height)
        End If
    End Sub

    Private Sub ViewingModifyOptions()
        If Not ucrReceiverEvent.IsEmpty Then
            ucrChkModifyEvent.Enabled = True
            If ucrChkModifyEvent.Checked Then
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
                    ' what if it is logic? Surely that should be treated in the "else" case
                    ' does that work here?
                    ucrModifyEventNumeric.Visible = False
                    ucrModifyEventFactor.Visible = True
                    clsCFunction.RemoveParameterByName("x")
                    clsCFunction.AddParameter("y", ucrModifyEventFactor.GetSelectedLevels(), bIncludeArgumentName:=False)
                End If
            Else
                lblSelectLevels.Visible = False
                ucrModifyEventNumeric.Visible = False
                ucrModifyEventFactor.Visible = False

                clsCFunction.RemoveParameterByName("x")
                clsCFunction.RemoveParameterByName("y")

                clsRightLeftFunction.AddParameter("event", clsRFunctionParameter:=ucrReceiverEvent.GetVariables, iPosition:=2)
                clsStartEndFunction.AddParameter("event", clsRFunctionParameter:=ucrReceiverEvent.GetVariables, iPosition:=2)
            End If

        Else
            ucrChkModifyEvent.Enabled = False
        End If
    End Sub

    Private Sub ucrChkModifyEvent_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrChkModifyEvent.ControlContentsChanged
        DialogWidth()
        TestOkEnabled()
        ViewingModifyOptions()
    End Sub

    Private Sub ucrReceiverEventControl(ucrChangedControl As ucrCore) Handles ucrReceiverEvent.ControlContentsChanged
        ViewingModifyOptions()
        TestOkEnabled()
    End Sub

    Private Sub ucrCoreControls(ucrChangedControl As ucrCore) Handles ucrReceiverTime1.ControlContentsChanged, ucrReceiverTime2.ControlContentsChanged, ucrSaveObject.ControlContentsChanged, ucrInputOrigin.ControlContentsChanged, ucrModifyEventFactor.ControlContentsChanged, ucrModifyEventNumeric.ControlContentsChanged, ucrChkModifyEvent.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class