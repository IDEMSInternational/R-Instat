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
Imports System.Text.RegularExpressions
Public Class dlgInfill
    Public enumFilldateMode As String = FilldateMode.Prepare
    Public Enum FilldateMode
        Prepare
        Climatic
    End Enum

    Private isFilling As Boolean = False
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private lstStationReceivers As New List(Of ucrReceiverMultiple)
    Dim lstRecognisedTypes As New List(Of KeyValuePair(Of String, List(Of String)))

    Private Sub dlgInfill_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        SetHelpOptions()
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 497

        ucrBase.clsRsyntax.iCallType = 2

        Dim kvpStation As KeyValuePair(Of String, List(Of String)) = New KeyValuePair(Of String, List(Of String))("station", {"station", "station.", "id", "name"}.ToList())

        lstStationReceivers.AddRange({ucrReceiverFactors})

        lstRecognisedTypes.AddRange({kvpStation})
        'Set receiver
        ucrReceiverDate.Selector = ucrInfillSelector
        ucrReceiverDate.SetDataType("Date")
        ucrReceiverDate.SetParameter(New RParameter("date_name", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.strSelectorHeading = "Date"
        ucrReceiverDate.bAutoFill = True

        'Set ucrreceiver factors
        ucrReceiverFactors.SetIncludedDataTypes({"factor"})
        ucrReceiverFactors.Selector = ucrInfillSelector
        ucrReceiverFactors.strSelectorHeading = "Factors"
        ucrReceiverFactors.Tag = "station"
        ucrReceiverFactors.SetParameter(New RParameter("factors", 5))
        ucrReceiverFactors.SetParameterIsString()

        'Set data frame parameter
        ucrInfillSelector.SetParameter(New RParameter("data_name", 0))
        ucrInfillSelector.SetParameterIsString()

        ucrChkResort.SetParameter(New RParameter("resort", 3))
        ucrChkResort.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkResort.SetRDefault("TRUE")
        ucrChkResort.SetText("Sort Data after filling gaps")

        ucrInputLimitOptions.SetItems({"Data Limits", "Fixed Limits", "Fixed Start Limit", "Fixed End Limit"})
        ucrInputLimitOptions.AddParameterPresentCondition("Fixed Limits", {"start_date", "end_date"})
        ucrInputLimitOptions.AddParameterPresentCondition("Data Limits", {"start_date", "end_date"}, False)
        ucrInputLimitOptions.SetDropDownStyleAsNonEditable()

        ucrInputComboMonth.SetParameter(New RParameter("start_month", 2))
        Dim dctMonth As New Dictionary(Of String, String)
        dctMonth.Add("January", 1)
        dctMonth.Add("February", 2)
        dctMonth.Add("March", 3)
        dctMonth.Add("April", 4)
        dctMonth.Add("May", 5)
        dctMonth.Add("June", 6)
        dctMonth.Add("July", 7)
        dctMonth.Add("August", 8)
        dctMonth.Add("September", 9)
        dctMonth.Add("October", 10)
        dctMonth.Add("November", 11)
        dctMonth.Add("December", 12)
        ucrInputComboMonth.SetItems(dctMonth)
        ucrInputComboMonth.SetDropDownStyleAsNonEditable()
        ucrInputComboMonth.SetLinkedDisplayControl(lblStartingFrom)

        ucrChkCompleteYears.SetText("Ensure complete years")
        ucrChkCompleteYears.AddParameterPresentCondition(True, "start_month")
        ucrChkCompleteYears.AddParameterPresentCondition(False, "start_month", False)

        ucrInputLimitOptions.AddToLinkedControls(ucrChkCompleteYears, {"Data Limits"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputLimitOptions.AddToLinkedControls(ucrDtpStartDate, {"Fixed Start Limit", "Fixed Limits"}, bNewLinkedHideIfParameterMissing:=True)
        ucrInputLimitOptions.AddToLinkedControls(ucrDtpEndDate, {"Fixed End Limit", "Fixed Limits"}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCompleteYears.AddToLinkedControls(ucrInputComboMonth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="January")
        ucrDtpEndDate.SetLinkedDisplayControl(lblEndDate)
        ucrDtpStartDate.SetLinkedDisplayControl(lblStartDate)
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        'Set default RFunction as the base function
        ucrInfillSelector.Reset()
        ucrReceiverFactors.SetMeAsReceiver()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$infill_missing_dates")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        AutoFillStation()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        If bReset Then
            SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
        AutoFillStation()
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrReceiverDate.IsEmpty)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputLimitOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLimitOptions.ControlValueChanged, ucrDtpStartDate.ControlValueChanged, ucrDtpEndDate.ControlValueChanged
        clsDefaultFunction.RemoveParameterByName("start_date")
        clsDefaultFunction.RemoveParameterByName("end_date")
        Select Case ucrInputLimitOptions.GetText
            Case "Fixed Limits", "Fixed Start Limit"
                clsDefaultFunction.AddParameter("start_date", clsRFunctionParameter:=ucrDtpStartDate.ValueAsRDate, iPosition:=3)
            Case "Fixed Limits", "Fixed End Limit"
                clsDefaultFunction.AddParameter("end_date", clsRFunctionParameter:=ucrDtpEndDate.ValueAsRDate, iPosition:=4)
        End Select
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumFilldateMode
            Case FilldateMode.Prepare
                ucrBase.iHelpTopicID = 497
            Case FilldateMode.Climatic
                ucrBase.iHelpTopicID = 357
        End Select
    End Sub

    Private Sub AutoFillStation()
        If isFilling Then
            Exit Sub
        End If
        isFilling = True

        ' Temporarily remove the event handler
        RemoveHandler ucrInfillSelector.ControlValueChanged, AddressOf AutoFillStation

        Dim lstRecognisedValues As List(Of String)
        Dim ucrCurrentReceiver As ucrReceiver
        Dim bFound As Boolean = False

        ucrCurrentReceiver = ucrInfillSelector.CurrentReceiver

        For Each ucrTempReceiver As ucrReceiver In lstStationReceivers
            ucrTempReceiver.SetMeAsReceiver()
            lstRecognisedValues = GetRecognisedValues(ucrTempReceiver.Tag)

            If lstRecognisedValues.Count > 0 Then
                For Each lviTempVariable As ListViewItem In ucrInfillSelector.lstAvailableVariable.Items
                    For Each strValue As String In lstRecognisedValues
                        If Regex.Replace(lviTempVariable.Text.ToLower(), "[^\w]", String.Empty).Equals(strValue) Then
                            ucrTempReceiver.Add(lviTempVariable.Text, ucrInfillSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                            bFound = True
                            Exit For
                        End If
                    Next
                    If bFound Then
                        bFound = False
                        Exit For
                    End If
                Next
            End If
        Next

        If ucrCurrentReceiver IsNot Nothing Then
            ucrCurrentReceiver.SetMeAsReceiver()
        End If

        ' Re-enable the event handler
        AddHandler ucrInfillSelector.ControlValueChanged, AddressOf AutoFillStation

        isFilling = False
    End Sub

    Private Function GetRecognisedValues(strVariable As String) As List(Of String)
        Dim lstValues As New List(Of String)

        For Each kvpTemp As KeyValuePair(Of String, List(Of String)) In lstRecognisedTypes
            If kvpTemp.Key = strVariable Then
                lstValues = kvpTemp.Value
                Exit For
            End If
        Next
        Return lstValues
    End Function

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInfillSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInfillSelector.ControlValueChanged, ucrReceiverFactors.ControlValueChanged
        AutoFillStation()
    End Sub
End Class
