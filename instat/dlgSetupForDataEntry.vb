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
Public Class dlgSetupForDataEntry
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsNewDataFrameFunction As New RFunction
    Private clsAddFlagFunction As New RFunction
    Private clsFactorFunction As New RFunction
    Private clsCFunction As New RFunction
    Private clsSeqDateFunction As New RFunction
    Private clsAddKeyFunction As New RFunction
    Private clsFlagCAddKeyFunction As New RFunction
    Private clsNewCAddKeyFunction As New RFunction
    Private clsDefaultStartDateFunction As New RFunction
    Private clsDefaultEndDateFunction As New RFunction

    Private iDialogHeight As Integer
    Private iBaseMaxY As Integer

    Private strSpecify1 As String = ""
    Private strSpecify2 As String = ""
    Private strSpecify3 As String = ""

    Private ReadOnly strDateName As String = "date"

    Private Sub dlgSetupForDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iDialogHeight = Me.Height
            iBaseMaxY = ucrBase.Location.Y
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        'Add correct help topic ID

        ucrSelectorSetupDataEntry.SetParameter(New RParameter("data_name", 0))
        ucrSelectorSetupDataEntry.SetParameterIsString()

        ucrReceiverStation.SetParameter(New RParameter("station", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStation.Selector = ucrSelectorSetupDataEntry
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bAutoFill = True

        ucrReceiverFlagDate.SetParameter(New RParameter("date", 1, bNewIncludeArgumentName:=False))
        ucrReceiverFlagDate.Selector = ucrSelectorSetupDataEntry
        ucrReceiverFlagDate.SetClimaticType("date")
        ucrReceiverFlagDate.SetIncludedDataTypes({"Date"})
        ucrReceiverFlagDate.bAutoFill = True
        ucrReceiverFlagDate.SetParameterIsString()
        ucrReceiverFlagDate.strSelectorHeading = "Date"

        ucrInputSelectStation.SetFactorReceiver(ucrReceiverStation)
        ucrInputSelectStation.strQuotes = ""
        ucrInputSelectStation.bFirstLevelDefault = True

        ucrChkPrecip.SetText("precip")

        ucrChkTmax.SetText("tmax")

        ucrChkTmin.SetText("tmin")

        ucrChkSunh.SetText("sunh")

        ucrChkWD.SetText("wd")

        ucrChkWS.SetText("ws")

        ucrChkSpecify1.SetText("specify1")

        ucrChkSpecify2.SetText("specify2")

        ucrChkSpecify3.SetText("specify3")

        ucrChkAddFlagVariables.SetText("Add Flag Variables")

        ucrReceiverAddFlagVariables.SetParameter(New RParameter("col_names", 1))
        ucrReceiverAddFlagVariables.Selector = ucrSelectorSetupDataEntry
        ucrReceiverAddFlagVariables.SetParameterIsString()
        ucrReceiverAddFlagVariables.strSelectorHeading = "Numerics"
        ucrReceiverAddFlagVariables.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        ucrReceiverAddFlagVariables.bAutoFill = True

        ucrSaveNewDFName.SetSaveTypeAsDataFrame()
        ucrSaveNewDFName.SetLabelText("New Data Frame Name:")
        ucrSaveNewDFName.SetIsTextBox()

        ucrInputSpecify1.Visible = False
        ucrInputSpecify2.Visible = False
        ucrInputSpecify3.Visible = False

        ucrPnlOptions.AddRadioButton(rdoNew)
        ucrPnlOptions.AddRadioButton(rdoAddFlags)
        ucrPnlOptions.AddFunctionNamesCondition(rdoNew, "data.frame")
        ucrPnlOptions.AddFunctionNamesCondition(rdoAddFlags, frmMain.clsRLink.strInstatDataObject & "$add_flag_fields")

        ucrDateFrom.SetParameter(New RParameter("from", 0))
        ucrDateFrom.SetParameterIsRDate()

        ucrDateTo.SetParameter(New RParameter("to", 1))
        ucrDateTo.SetParameterIsRDate()

        clsDefaultStartDateFunction = New RFunction
        clsDefaultStartDateFunction.SetRCommand("as.Date")
        clsDefaultStartDateFunction.AddParameter("x", Chr(34) & Date.Now.ToString("yyy/MM/dd") & Chr(34), iPosition:=0)

        clsDefaultEndDateFunction = New RFunction
        clsDefaultEndDateFunction.SetRCommand("as.Date")
        clsDefaultEndDateFunction.AddParameter("x", Chr(34) & Date.Now.AddMonths(1).ToString("yyy/MM/dd") & Chr(34), iPosition:=0)

        ucrPnlOptions.AddToLinkedControls({ucrInputSelectStation, ucrChkAddFlagVariables, ucrChkSpecify1, ucrChkSpecify2, ucrChkSpecify3, ucrSaveNewDFName}, {rdoNew}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrDateFrom, ucrDateTo}, {rdoNew}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverAddFlagVariables, ucrReceiverFlagDate}, {rdoAddFlags}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecify1.AddToLinkedControls({ucrInputSpecify1}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecify2.AddToLinkedControls({ucrInputSpecify2}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecify3.AddToLinkedControls({ucrInputSpecify3}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSelectStation.SetLinkedDisplayControl(lblSelectStation)
        ucrDateFrom.SetLinkedDisplayControl(lblDateFrom)
        ucrDateTo.SetLinkedDisplayControl(lblDateTo)
        ucrReceiverFlagDate.SetLinkedDisplayControl(lblFlagDate)
        ucrReceiverAddFlagVariables.SetLinkedDisplayControl(lblAddFlagVariables)
        ucrChkSpecify1.SetLinkedDisplayControl(grpElements)
    End Sub

    Private Sub SetDefaults()
        clsNewDataFrameFunction = New RFunction
        clsAddFlagFunction = New RFunction
        clsFactorFunction = New RFunction
        clsCFunction = New RFunction
        clsSeqDateFunction = New RFunction
        clsFlagCAddKeyFunction = New RFunction
        clsNewCAddKeyFunction = New RFunction
        clsAddKeyFunction = New RFunction

        ucrSelectorSetupDataEntry.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        clsAddKeyFunction.iCallType = 2

        ucrChkSpecify1.Checked = False
        ucrChkSpecify2.Checked = False
        ucrChkSpecify3.Checked = False
        ucrChkPrecip.Checked = False
        ucrChkSunh.Checked = False
        ucrChkTmax.Checked = False
        ucrChkTmin.Checked = False
        ucrChkWS.Checked = False
        ucrChkWD.Checked = False
        ucrChkAddFlagVariables.Checked = False
        ucrInputSpecify1.SetText("")
        ucrInputSpecify2.SetText("")
        ucrInputSpecify3.SetText("")

        clsNewDataFrameFunction.SetRCommand("data.frame")
        clsNewDataFrameFunction.AddParameter(strDateName, clsRFunctionParameter:=clsSeqDateFunction, iPosition:=1)

        clsAddFlagFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_flag_fields")
        clsAddFlagFunction.AddParameter("key_column_names", clsRFunctionParameter:=clsFlagCAddKeyFunction, iPosition:=2)

        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("x", "NA_character_", iPosition:=0)
        clsFactorFunction.AddParameter("levels", clsRFunctionParameter:=clsCFunction, iPosition:=1)

        clsCFunction.SetRCommand("c")
        clsCFunction.AddParameter("data", Chr(34) & "data" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsCFunction.AddParameter("edit", Chr(34) & "edit" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsCFunction.AddParameter("add", Chr(34) & "add" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)

        clsSeqDateFunction.SetRCommand("seq")
        clsSeqDateFunction.AddParameter("from", clsRFunctionParameter:=clsDefaultStartDateFunction, iPosition:=0)
        clsSeqDateFunction.AddParameter("to", clsRFunctionParameter:=clsDefaultEndDateFunction, iPosition:=1)
        clsSeqDateFunction.AddParameter("by", Chr(34) & "day" & Chr(34), iPosition:=2)

        clsAddKeyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKeyFunction.AddParameter("col_names", clsRFunctionParameter:=clsNewCAddKeyFunction, iPosition:=1)

        clsFlagCAddKeyFunction.SetRCommand("c")

        clsNewCAddKeyFunction.SetRCommand("c")
        clsNewCAddKeyFunction.AddParameter("date", Chr(34) & strDateName & Chr(34), bIncludeArgumentName:=False, iPosition:=1)

        clsNewDataFrameFunction.SetAssignTo(ucrSaveNewDFName.GetText(), strTempDataframe:=ucrSaveNewDFName.GetText())

        ucrBase.clsRsyntax.ClearCodes()
        RunAddKeysFunction()
        ucrBase.clsRsyntax.SetBaseRFunction(clsNewDataFrameFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStation.AddAdditionalCodeParameterPair(clsNewCAddKeyFunction, ucrReceiverStation.GetParameter, iAdditionalPairNo:=1)

        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveNewDFName.SetRCode(clsNewDataFrameFunction, bReset)
        ucrSelectorSetupDataEntry.SetRCode(clsAddFlagFunction, bReset)
        ucrReceiverAddFlagVariables.SetRCode(clsAddFlagFunction, bReset)
        ucrReceiverFlagDate.SetRCode(clsFlagCAddKeyFunction, bReset)
        ucrReceiverStation.SetRCode(clsFlagCAddKeyFunction, bReset)
        ucrDateFrom.SetRCode(clsSeqDateFunction, bReset)
        ucrDateTo.SetRCode(clsSeqDateFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled As Boolean = True
        If rdoNew.Checked Then
            If (ucrReceiverStation.IsEmpty OrElse Not ucrSaveNewDFName.IsComplete) OrElse Not (
                ucrChkPrecip.Checked OrElse ucrChkSunh.Checked OrElse ucrChkTmax.Checked OrElse ucrChkTmin.Checked OrElse
                ucrChkWD.Checked OrElse ucrChkWS.Checked OrElse ucrChkSpecify1.Checked OrElse
                ucrChkSpecify2.Checked OrElse ucrChkSpecify3.Checked) Then
                bOkEnabled = False
            End If
            If (ucrChkSpecify1.Checked AndAlso ucrInputSpecify1.IsEmpty) OrElse
                (ucrChkSpecify2.Checked AndAlso ucrInputSpecify2.IsEmpty) OrElse (ucrChkSpecify3.Checked AndAlso ucrInputSpecify3.IsEmpty) Then
                bOkEnabled = False
            End If
        ElseIf Not rdoAddFlags.Checked Then
            bOkEnabled = False
        ElseIf ucrReceiverFlagDate.IsEmpty OrElse ucrReceiverAddFlagVariables.IsEmpty Then
            bOkEnabled = False
        End If
        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub AddRemoveFlagParameter()
        If ucrChkPrecip.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter("precip_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=11)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("precip_fl")
        End If
        If ucrChkTmax.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter("tmax_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=12)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("tmax_fl")
        End If
        If ucrChkTmin.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter("tmin_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=13)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("tmin_fl")
        End If
        If ucrChkSunh.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter("sunh_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=14)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("sunh_fl")
        End If
        If ucrChkWD.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter("wd_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=15)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("wd_fl")
        End If
        If ucrChkWS.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter("ws_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=16)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("ws_fl")
        End If
        If ucrChkSpecify1.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter(ucrInputSpecify1.GetValue() & "_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=17)
        Else
            clsNewDataFrameFunction.RemoveParameterByName(ucrInputSpecify1.GetValue() & "_fl")
        End If
        If ucrChkSpecify2.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter(ucrInputSpecify2.GetValue() & "_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=18)
        Else
            clsNewDataFrameFunction.RemoveParameterByName(ucrInputSpecify2.GetValue() & "_fl")
        End If
        If ucrChkSpecify3.Checked AndAlso ucrChkAddFlagVariables.Checked Then
            clsNewDataFrameFunction.AddParameter(ucrInputSpecify3.GetValue() & "_fl", clsRFunctionParameter:=clsFactorFunction, iPosition:=19)
        Else
            clsNewDataFrameFunction.RemoveParameterByName(ucrInputSpecify3.GetValue() & "_fl")
        End If

        If ucrChkPrecip.Checked Then
            clsNewDataFrameFunction.AddParameter("precip", "NA_real_", iPosition:=2)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("precip")
        End If
        If ucrChkTmax.Checked Then
            clsNewDataFrameFunction.AddParameter("tmax", "NA_real_", iPosition:=3)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("tmax")
        End If
        If ucrChkTmin.Checked Then
            clsNewDataFrameFunction.AddParameter("tmin", "NA_real_", iPosition:=4)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("tmin")
        End If
        If ucrChkSunh.Checked Then
            clsNewDataFrameFunction.AddParameter("sunh", "NA_real_", iPosition:=5)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("sunh")
        End If
        If ucrChkWS.Checked Then
            clsNewDataFrameFunction.AddParameter("ws", "NA_real_", iPosition:=6)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("ws")
        End If
        If ucrChkWD.Checked Then
            clsNewDataFrameFunction.AddParameter("wd", "NA_real_", iPosition:=7)
        Else
            clsNewDataFrameFunction.RemoveParameterByName("wd")
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrInputSelectStation.ControlValueChanged
        Dim strStation As String = ucrReceiverStation.GetVariableNames(bWithQuotes:=False)
        Dim strDaframeName As String = ucrInputSelectStation.GetText.Replace(" ", "_").ToLower

        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrInputSelectStation.IsEmpty Then
            clsNewDataFrameFunction.AddParameter(strStation, "as.factor(" & Chr(34) & ucrInputSelectStation.GetValue() & Chr(34) & ")", iPosition:=0)
            ucrSaveNewDFName.SetPrefix(strDaframeName.Replace(Chr(39), ""))
        Else
            clsNewDataFrameFunction.RemoveParameterByName(strStation)
        End If
        AddRemoveFlagParameter()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputSpecify1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify1.ControlValueChanged, ucrChkSpecify1.ControlValueChanged
        clsNewDataFrameFunction.RemoveParameterByName(strSpecify1)
        strSpecify1 = ""
        If Not ucrInputSpecify1.IsEmpty AndAlso ucrChkSpecify1.Checked Then
            strSpecify1 = ucrInputSpecify1.GetValue()
            clsNewDataFrameFunction.AddParameter(strSpecify1, "NA_real_", iPosition:=8)
        End If
        AddRemoveFlagParameter()
    End Sub

    Private Sub ucrInputSpecify2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify2.ControlValueChanged, ucrChkSpecify2.ControlValueChanged
        clsNewDataFrameFunction.RemoveParameterByName(strSpecify2)
        strSpecify2 = ""
        If Not ucrInputSpecify2.IsEmpty AndAlso ucrChkSpecify2.Checked Then
            strSpecify2 = ucrInputSpecify2.GetValue()
            clsNewDataFrameFunction.AddParameter(strSpecify2, "NA_real_", iPosition:=9)
        End If
        AddRemoveFlagParameter()
    End Sub

    Private Sub ucrInputSpecify3_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify3.ControlValueChanged, ucrChkSpecify3.ControlValueChanged
        clsNewDataFrameFunction.RemoveParameterByName(strSpecify3)
        strSpecify3 = ""
        If Not ucrInputSpecify3.IsEmpty AndAlso ucrChkSpecify3.Checked Then
            strSpecify3 = ucrInputSpecify3.GetValue()
            clsNewDataFrameFunction.AddParameter(strSpecify3, "NA_real_", iPosition:=10)
        End If
        AddRemoveFlagParameter()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        If rdoNew.Checked Then
            ucrReceiverStation.SetMeAsReceiver()
            Me.Size = New System.Drawing.Size(Me.Width, iDialogHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            ucrBase.clsRsyntax.SetBaseRFunction(clsNewDataFrameFunction)
        Else
            ucrReceiverAddFlagVariables.SetMeAsReceiver()
            Me.Size = New System.Drawing.Size(Me.Width, iDialogHeight * 0.8)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.35)
            ucrBase.clsRsyntax.SetBaseRFunction(clsAddFlagFunction)
        End If
        RunAddKeysFunction()
    End Sub

    Private Sub RunAddKeysFunction()
        If rdoNew.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsAddKeyFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddKeyFunction)
        End If
    End Sub

    Private Sub ucrChkPrecip_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddFlagVariables.ControlValueChanged, ucrChkPrecip.ControlValueChanged, ucrChkSunh.ControlValueChanged, ucrChkTmax.ControlValueChanged, ucrChkTmin.ControlValueChanged, ucrChkWD.ControlValueChanged, ucrChkWS.ControlValueChanged
        AddRemoveFlagParameter()
    End Sub

    Private Sub ucrSaveNewDFName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveNewDFName.ControlValueChanged, ucrInputSelectStation.ControlValueChanged
        If ucrSaveNewDFName.IsComplete Then
            clsAddKeyFunction.AddParameter("data_name", Chr(34) & ucrSaveNewDFName.GetText & Chr(34), iPosition:=0)
        Else
            clsAddKeyFunction.RemoveParameterByName("data_name")
        End If
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverFlagDate.ControlContentsChanged, ucrReceiverAddFlagVariables.ControlContentsChanged, ucrChkPrecip.ControlContentsChanged, ucrChkSunh.ControlContentsChanged, ucrChkTmax.ControlContentsChanged, ucrChkTmin.ControlContentsChanged, ucrChkWD.ControlContentsChanged, ucrChkWS.ControlContentsChanged, ucrChkSpecify1.ControlContentsChanged, ucrChkSpecify2.ControlContentsChanged, ucrChkSpecify3.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrInputSpecify1.ControlContentsChanged, ucrInputSpecify2.ControlContentsChanged, ucrInputSpecify3.ControlContentsChanged, ucrSaveNewDFName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
