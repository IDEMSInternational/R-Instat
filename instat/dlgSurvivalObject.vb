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

        ucrReceiverEvent.SetParameter(New RParameter("event", 2))
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

        ucrSelectorFitObject.Reset()
        ucrSaveObject.Reset()

        clsRightLeftFunction.SetPackageName("survival")
        clsRightLeftFunction.SetRCommand("Surv")
        clsRightLeftFunction.AddParameter("type", Chr(34) & "right" & Chr(34), iPosition:=3)

        clsStartEndFunction.SetPackageName("survival")
        clsStartEndFunction.SetRCommand("Surv")

        clsDefaultFunction.SetRCommand("with")
        clsDefaultFunction.AddParameter("exp", clsRFunctionParameter:=clsRightLeftFunction)
        clsDefaultFunction.SetAssignTo(strTemp:="surv", strTempDataframe:=ucrSelectorFitObject.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempSurv:="surv", bAssignToIsPrefix:=True)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverTime2.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("time2", 1), iAdditionalPairNo:=1)
        ucrReceiverEvent.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("event", 2), iAdditionalPairNo:=1)
        ucrPnlType.AddAdditionalCodeParameterPair(clsStartEndFunction, New RParameter("type", 3), iAdditionalPairNo:=1)

        ucrSelectorFitObject.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverTime1.SetRCode(clsStartEndFunction, bReset)
        ucrReceiverTime2.SetRCode(clsRightLeftFunction, bReset)
        ucrReceiverEvent.SetRCode(clsRightLeftFunction, bReset)
        ucrPnlType.SetRCode(clsRightLeftFunction, bReset)
        ucrInputOrigin.SetRCode(clsStartEndFunction, bReset)
        ucrSaveObject.SetRCode(clsDefaultFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()

        If ucrReceiverTime2.IsEmpty() OrElse ucrReceiverEvent.IsEmpty() OrElse Not ucrSaveObject.IsComplete() Then
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

        ' ucrsave cannot be empty

        ' if right or left are clicked, then end and event cannot be empty

        ' if one of the other four are clicked, then start or end have to be filled
        '           ' if end is filled, then event must be filled 
        '           ' if counting is selected, nud cannot be empty

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

            'If ucrReceiverTime1.SetMeAsReceiver Then ' TODO what is the correct code for this line?
            'ucrReceiverTime2.SetMeAsReceiver()
            'End If
        End If

        ' mstate allows factors
        If rdoMstate.Checked = True OrElse rdoCounting.Checked = True Then
            ucrReceiverEvent.SetIncludedDataTypes({"numeric", "factor"})
        Else
            ucrReceiverEvent.SetIncludedDataTypes({"numeric"})
        End If

        TestOkEnabled()
    End Sub

    Private Sub ucrCoreControls(ucrChangedControl As ucrCore) Handles ucrReceiverTime1.ControlContentsChanged, ucrReceiverTime2.ControlContentsChanged, ucrReceiverEvent.ControlContentsChanged, ucrSaveObject.ControlContentsChanged, ucrInputOrigin.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class