﻿' R- Instat
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
Public Class dlgSetupForDataEntry
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsNewDataFrameFunction As New RFunction
    Private clsAddFlagFunction As New RFunction
    Private clsFactorFunction As New RFunction
    Private clsCFunction As New RFunction
    Private clsSeqFunction As New RFunction
    Private clsAddKeyFunction As New RFunction
    Private clsCAddKeyFunction As New RFunction

    Private iDialogHeight As Integer
    Private iBaseMaxY As Integer

    ''' <summary> Store the name of the specify value entered. </summary>
    Private strSpecify1 As String = ""
    Private strSpecify2 As String = ""
    Private strSpecify3 As String = ""

    ''' <summary> Store the name of the station value selected. </summary>
    Private strStation As String = ""

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

        ucrBase.iHelpTopicID = 359

        ucrSelectorSetupDataEntry.SetParameter(New RParameter("data_name", 0))
        ucrSelectorSetupDataEntry.SetParameterIsString()

        ucrReceiverStation.SetParameter(New RParameter("station", 2))
        ucrReceiverStation.Selector = ucrSelectorSetupDataEntry
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Factors"

        ucrReceiverDate.SetParameter(New RParameter("date", 3))
        ucrReceiverDate.Selector = ucrSelectorSetupDataEntry
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetIncludedDataTypes({"Date"})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.strSelectorHeading = "Date"

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

        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetLabelText("New Data Frame Name:")
        ucrNewDFName.SetIsTextBox()

        ucrInputSpecify1.Visible = False
        ucrInputSpecify2.Visible = False
        ucrInputSpecify3.Visible = False

        ucrPnlOptions.AddRadioButton(rdoNew)
        ucrPnlOptions.AddRadioButton(rdoAddFlags)
        ucrPnlOptions.AddFunctionNamesCondition(rdoNew, "data.frame")
        ucrPnlOptions.AddFunctionNamesCondition(rdoAddFlags, frmMain.clsRLink.strInstatDataObject & "$add_flag_fields")

        ucrPnlOptions.AddToLinkedControls({ucrInputSelectStation, ucrDateFrom, ucrDateTo, ucrChkAddFlagVariables, ucrChkSpecify1, ucrChkSpecify2, ucrChkSpecify3, ucrNewDFName}, {rdoNew}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverAddFlagVariables, ucrReceiverDate}, {rdoAddFlags}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecify1.AddToLinkedControls({ucrInputSpecify1}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecify2.AddToLinkedControls({ucrInputSpecify2}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSpecify3.AddToLinkedControls({ucrInputSpecify3}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSelectStation.SetLinkedDisplayControl(lblSelectStation)
        ucrDateFrom.SetLinkedDisplayControl(lblDateFrom)
        ucrDateTo.SetLinkedDisplayControl(lblDateTo)
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrReceiverAddFlagVariables.SetLinkedDisplayControl(lblAddFlagVariables)
    End Sub

    Private Sub SetDefaults()
        clsNewDataFrameFunction = New RFunction
        clsAddFlagFunction = New RFunction
        clsFactorFunction = New RFunction
        clsCFunction = New RFunction
        clsSeqFunction = New RFunction
        clsCAddKeyFunction = New RFunction
        clsAddKeyFunction = New RFunction

        ucrSelectorSetupDataEntry.Reset()
        ucrReceiverAddFlagVariables.SetMeAsReceiver()

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
        'todo. what should be the default date
        ucrDateFrom.DateValue = Date.Now
        ucrDateTo.DateValue = ucrDateFrom.DateValue.AddMonths(1).AddDays(-1)

        clsNewDataFrameFunction.SetRCommand("data.frame")

        clsAddFlagFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_flag_fields")

        clsFactorFunction.SetRCommand("factor")
        clsFactorFunction.AddParameter("x", "NA", iPosition:=0)
        clsFactorFunction.AddParameter("levels", clsRFunctionParameter:=clsCFunction, iPosition:=1)

        clsCFunction.SetRCommand("c")
        clsCFunction.AddParameter("data", Chr(34) & "data" & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsCFunction.AddParameter("edit", Chr(34) & "edit" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
        clsCFunction.AddParameter("add", Chr(34) & "add" & Chr(34), iPosition:=2, bIncludeArgumentName:=False)

        clsSeqFunction.SetRCommand("seq")
        clsSeqFunction.AddParameter("by", Chr(34) & "day" & Chr(34), iPosition:=2)

        clsAddKeyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        clsAddKeyFunction.AddParameter("key_name", Chr(34) & "key" & Chr(34), iPosition:=1)

        clsCAddKeyFunction.SetRCommand("c")

        clsNewDataFrameFunction.SetAssignTo(ucrNewDFName.GetText(), strTempDataframe:=ucrNewDFName.GetText())

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsNewDataFrameFunction)
        clsAddKeyFunction.iCallType = 2
        clsAddFlagFunction.iCallType = 2
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

        ucrPnlOptions.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrNewDFName.SetRCode(clsNewDataFrameFunction, bReset)
        ucrSelectorSetupDataEntry.SetRCode(clsAddFlagFunction, bReset)
        ucrReceiverAddFlagVariables.SetRCode(clsAddFlagFunction, bReset)
        ucrReceiverStation.SetRCode(clsAddFlagFunction, bReset)
        ucrReceiverDate.SetRCode(clsAddFlagFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoNew.Checked Then
            If Not ucrReceiverStation.IsEmpty AndAlso (ucrChkPrecip.Checked OrElse ucrChkSunh.Checked OrElse ucrChkTmax.Checked OrElse ucrChkTmin.Checked OrElse ucrChkWD.Checked OrElse ucrChkWS.Checked OrElse
                 (ucrChkSpecify1.Checked AndAlso Not ucrInputSpecify1.IsEmpty) OrElse (ucrChkSpecify2.Checked AndAlso Not ucrInputSpecify2.IsEmpty) OrElse (ucrChkSpecify3.Checked AndAlso Not ucrInputSpecify3.IsEmpty)) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If Not ucrReceiverStation.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverAddFlagVariables.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub AddRemoveParameter()
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
        If rdoNew.Checked Then
            clsCAddKeyFunction.AddParameter("date", Chr(34) & "date" & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
            clsAddKeyFunction.AddParameter("data_name", Chr(34) & ucrNewDFName.GetText() & Chr(34), iPosition:=0)
        Else
            clsCAddKeyFunction.AddParameter("date", ucrReceiverDate.GetVariableNames(True), iPosition:=1, bIncludeArgumentName:=False)
            clsAddKeyFunction.AddParameter("data_name", Chr(34) & ucrSelectorSetupDataEntry.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrInputSelectStation.ControlValueChanged, ucrReceiverDate.ControlValueChanged, ucrSelectorSetupDataEntry.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        ' This ensures clsNewDataFrameFunction has the correct parameters. Unlike in most functions, in our use of dplyr::mutate in this case, the parameter name is the selected variable.
        ' Storing and then removing strSpecify3 as a parameter ensures dplyr::mutate does not keep old parameters when the selected variable is changed.
        Dim strDaframeName As String = ucrInputSelectStation.GetValue().ToString.Trim(Chr(34)).ToLower.Replace(" ", "_")
        If Not ucrReceiverStation.IsEmpty AndAlso Not ucrInputSelectStation.IsEmpty Then
            strStation = ucrReceiverStation.GetVariableNames(bWithQuotes:=False)
            clsNewDataFrameFunction.AddParameter(strStation, "as.factor(" & Chr(34) & ucrInputSelectStation.GetValue() & Chr(34) & ")", iPosition:=0)
            ucrNewDFName.SetPrefix(strDaframeName.Replace("'", ""))
            clsCAddKeyFunction.AddParameter("station", ucrReceiverStation.GetVariableNames(True), iPosition:=0, bIncludeArgumentName:=False)
            clsAddKeyFunction.AddParameter("col_names", clsRFunctionParameter:=clsCAddKeyFunction, iPosition:=1)
        Else
            clsCAddKeyFunction.RemoveParameterByName("station")
            clsAddKeyFunction.RemoveParameterByName("col_names")
            clsNewDataFrameFunction.RemoveParameterByName(strDaframeName.Replace("'", ""))
            strStation = ""
        End If
        AddRemoveParameter()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrDateTo_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDateTo.ControlValueChanged, ucrDateFrom.ControlValueChanged
        clsSeqFunction.AddParameter("from", "as.Date(" & Chr(34) & ucrDateFrom.DateValue.ToString("yyyy-MM-dd") & Chr(34) & ")", iPosition:=0)
        clsSeqFunction.AddParameter("to", "as.Date(" & Chr(34) & ucrDateTo.DateValue.ToString("yyyy-MM-dd") & Chr(34) & ")", iPosition:=1)
        clsNewDataFrameFunction.AddParameter("date", clsRFunctionParameter:=clsSeqFunction, iPosition:=1)
        AddRemoveParameter()
    End Sub

    Private Sub ucrInputSpecify1_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify1.ControlValueChanged, ucrChkSpecify1.ControlValueChanged
        ' This ensures clsNewDataFrameFunction has the correct parameters. Unlike in most functions, in our use of dplyr::mutate in this case, the parameter name is the selected variable.
        ' Storing and then removing strSpecify3 as a parameter ensures dplyr::mutate does not keep old parameters when the selected variable is changed.
        If Not ucrInputSpecify1.IsEmpty AndAlso ucrChkSpecify1.Checked Then
            clsNewDataFrameFunction.RemoveParameterByName(strSpecify1)
            strSpecify1 = ucrInputSpecify1.GetValue()
            clsNewDataFrameFunction.AddParameter(strSpecify1, "NA_real_", iPosition:=8)
        Else
            clsNewDataFrameFunction.RemoveParameterByName(strSpecify1)
            strSpecify1 = ""
        End If
        AddRemoveParameter()
    End Sub

    Private Sub ucrInputSpecify2_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify2.ControlValueChanged, ucrChkSpecify2.ControlValueChanged
        ' This ensures clsNewDataFrameFunction has the correct parameters. Unlike in most functions, in our use of dplyr::mutate in this case, the parameter name is the selected variable.
        ' Storing and then removing strSpecify2 as a parameter ensures dplyr::mutate does not keep old parameters when the selected variable is changed.
        If Not ucrInputSpecify2.IsEmpty AndAlso ucrChkSpecify2.Checked Then
            clsNewDataFrameFunction.RemoveParameterByName(strSpecify2)
            strSpecify2 = ucrInputSpecify2.GetValue()
            clsNewDataFrameFunction.AddParameter(strSpecify2, "NA_real_", iPosition:=9)
        Else
            clsNewDataFrameFunction.RemoveParameterByName(strSpecify2)
            strSpecify2 = ""
        End If
        AddRemoveParameter()
    End Sub

    Private Sub ucrInputSpecify3_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputSpecify3.ControlValueChanged, ucrChkSpecify3.ControlValueChanged
        ' This ensures clsNewDataFrameFunction has the correct parameters. Unlike in most functions, in our use of dplyr::mutate in this case, the parameter name is the selected variable.
        ' Storing and then removing strSpecify3 as a parameter ensures dplyr::mutate does not keep old parameters when the selected variable is changed.
        If Not ucrInputSpecify3.IsEmpty AndAlso ucrChkSpecify3.Checked Then
            clsNewDataFrameFunction.RemoveParameterByName(strSpecify3)
            strSpecify3 = ucrInputSpecify3.GetValue()
            clsNewDataFrameFunction.AddParameter(strSpecify3, "NA_real_", iPosition:=10)
        Else
            clsNewDataFrameFunction.RemoveParameterByName(strSpecify3)
            strSpecify3 = ""
        End If
        AddRemoveParameter()
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        ' Dim bCheckKey As Boolean
        If rdoNew.Checked Then
            Me.Size = New System.Drawing.Size(Me.Width, iDialogHeight)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            ucrBase.clsRsyntax.SetBaseRFunction(clsNewDataFrameFunction)
            ucrBase.clsRsyntax.AddToAfterCodes(clsAddKeyFunction, iPosition:=0)
            clsAddKeyFunction.iCallType = 2
            grpElements.Visible = True
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsAddKeyFunction)
            Me.Size = New System.Drawing.Size(Me.Width, iDialogHeight * 0.8)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.35)
            ucrBase.clsRsyntax.SetBaseRFunction(clsAddFlagFunction)
            clsAddFlagFunction.iCallType = 2
            grpElements.Visible = False
        End If
        AddRemoveParameter()
    End Sub

    Private Sub ucrChkPrecip_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddFlagVariables.ControlValueChanged, ucrChkPrecip.ControlValueChanged, ucrChkSunh.ControlValueChanged, ucrChkTmax.ControlValueChanged, ucrChkTmin.ControlValueChanged, ucrChkWD.ControlValueChanged, ucrChkWS.ControlValueChanged, ucrNewDFName.ControlValueChanged
        AddRemoveParameter()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverAddFlagVariables.ControlContentsChanged, ucrChkPrecip.ControlContentsChanged, ucrChkSunh.ControlContentsChanged, ucrChkTmax.ControlContentsChanged, ucrChkTmin.ControlContentsChanged, ucrChkWD.ControlContentsChanged, ucrChkWS.ControlContentsChanged, ucrChkSpecify1.ControlContentsChanged, ucrChkSpecify2.ControlContentsChanged, ucrChkSpecify3.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrInputSpecify1.ControlContentsChanged, ucrInputSpecify2.ControlContentsChanged, ucrInputSpecify3.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class