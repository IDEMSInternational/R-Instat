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

Imports System.Runtime.InteropServices
Imports instat.Translations
Imports RDotNet

Public Class dlgImportFromRapidPro
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsGetUserDataFunction As New RFunction
    Private clsGetFlowDataFunction As New RFunction
    Public clsGetFlowFunction As New RFunction
    Public clsModifyOperation As New ROperator
    Public clsOpeningOperator As New ROperator
    Public clsClosingOperator As New ROperator
    Private clsSetTokenFunction As New RFunction
    Private clsLinkDataFramesFunction As New RFunction
    Private clsSetSiteFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsConvertToFactor As New RFunction

    Private Sub dlgImportFromRapidPro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
    End Sub

    Private Sub InitialiseDialog()
        Dim dctDateFormat As New Dictionary(Of String, String)
        Dim dctTimezone As New Dictionary(Of String, String)

        ucrPnlImportFromRapidPro.AddRadioButton(rdoUserData)
        ucrPnlImportFromRapidPro.AddRadioButton(rdoFlowData)

        ucrInputRapidProSite.SetParameter(New RParameter("site", 0))
        ucrInputRapidProSite.SetLinkedDisplayControl(lblRapidProSite)

        ucrChkFlattenData.SetText("Flatten")
        ucrChkFlattenData.SetParameter(New RParameter("flatten", 2))
        ucrChkFlattenData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkFlattenData.Visible = False ' disabled because R Instat doesn't yet support json format

        ucrChkSetStartDate.SetText("Start Date")
        ucrChkSetStartDate.AddParameterValuesCondition(True, "checked", "TRUE")
        ucrChkSetStartDate.AddParameterValuesCondition(False, "checked", "FALSE")
        ucrChkSetStartDate.AddToLinkedControls(ucrInputStartDate, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputStartDate.SetParameter(New RParameter("date_from", 3))

        ucrChkSetEndDate.SetText("End Date")
        ucrChkSetEndDate.AddParameterValuesCondition(True, "checked1", "TRUE")
        ucrChkSetEndDate.AddParameterValuesCondition(False, "checked1", "FALSE")
        ucrChkSetEndDate.AddToLinkedControls(ucrInputEndDate, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputEndDate.SetParameter(New RParameter("date_to", 4))

        ucrInputDateFormat.SetParameter(New RParameter("format_date", 5))
        ucrInputDateFormat.SetLinkedDisplayControl(lblDateFormat)
        dctDateFormat.Add("Year(4-digit)-Month-Day", Chr(34) & "%Y-%m-%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)/Month/Day", Chr(34) & "%Y/%m/%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)-Month(Full Name)-Day", Chr(34) & "%Y-%B-%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)/Month(Full Name)/Day", Chr(34) & "%Y/%B/%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)-Month(abbr)-Day", Chr(34) & "%Y-%b-%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)/Month(abbr)/Day", Chr(34) & "%Y/%b/%d" & Chr(34))
        dctDateFormat.Add("Year(4 digit)MonthDay(YEARMODA)", Chr(34) & "%Y%m%d" & Chr(34))

        dctDateFormat.Add("Year(4-digit)Doy(Julian)", Chr(34) & "%Y%j" & Chr(34))

        dctDateFormat.Add("Day-Month-Year(4-digit)", Chr(34) & "%d-%m-%Y" & Chr(34))
        dctDateFormat.Add("Day/Month/Year(4-digit)", Chr(34) & "%d/%m/%Y" & Chr(34))
        dctDateFormat.Add("Day-Month(Full Name)-Year(4-digit)", Chr(34) & "%d-%B-%Y" & Chr(34))
        dctDateFormat.Add("Day/Month(Full Name)/Year(4-digit)", Chr(34) & "%d/%B/%Y" & Chr(34))
        dctDateFormat.Add("Day-Month(abbr)-Year(4-digit)", Chr(34) & "%d-%b-%Y" & Chr(34))
        dctDateFormat.Add("Day/Month(abbr)/Year(4-digit)", Chr(34) & "%d/%b/%Y" & Chr(34))

        dctDateFormat.Add("Month-Day-Year(4-digit)", Chr(34) & "%m-%d-%Y" & Chr(34))
        dctDateFormat.Add("Month/Day/Year(4-digit)", Chr(34) & "%m/%d/%Y" & Chr(34))
        dctDateFormat.Add("Month(Full Name)-Day-Year(4-digit)", Chr(34) & "%B-%d-%Y" & Chr(34))
        dctDateFormat.Add("Month(Full Name)/Day/Year(4-digit)", Chr(34) & "%B/%d/%Y" & Chr(34))
        dctDateFormat.Add("Month(abbr)-Day-Year(4-digit)", Chr(34) & "%b-%d-%Y" & Chr(34))
        dctDateFormat.Add("Month(abbr)/Day/Year(4-digit)", Chr(34) & "%b/%d/%Y" & Chr(34))
        ucrInputDateFormat.SetItems(dctDateFormat)
        ucrInputDateFormat.SetDropDownStyleAsEditable(bAdditionsAllowed:=True)
        ucrInputDateFormat.SetRDefault(Chr(34) & "%Y%m%d" & Chr(34))

        ucrInputTimezone.SetParameter(New RParameter("tzone_date", 6))
        ucrInputTimezone.SetLinkedDisplayControl(lblTimezone)
        dctTimezone.Add("UTC", Chr(34) & "UTC" & Chr(34))
        dctTimezone.Add("EAT", Chr(34) & "EAT" & Chr(34))
        dctTimezone.Add("GMT", Chr(34) & "GMT" & Chr(34))
        dctTimezone.Add("ECT", Chr(34) & "ECT" & Chr(34))
        dctTimezone.Add("MET", Chr(34) & "MET" & Chr(34))
        dctTimezone.Add("CST", Chr(34) & "CST" & Chr(34))
        dctTimezone.Add("EST", Chr(34) & "EST" & Chr(34))
        dctTimezone.Add("CET", Chr(34) & "CET" & Chr(34))
        dctTimezone.Add("EET", Chr(34) & "EET" & Chr(34))
        dctTimezone.Add("WAT", Chr(34) & "WAT" & Chr(34))
        dctTimezone.Add("WET", Chr(34) & "WET" & Chr(34))
        ucrInputTimezone.SetItems(dctTimezone)
        ucrInputTimezone.SetRDefault(Chr(34) & "UTC" & Chr(34))
        ucrInputTimezone.SetDropDownStyleAsEditable(bAdditionsAllowed:=True)

        ucrChkUser.SetText("User")
        ucrChkUser.AddParameterValuesCondition(True, "user", "TRUE")
        ucrChkUser.AddParameterValuesCondition(False, "user", "FALSE")

        ucrChkFlow.SetText("Flow")
        ucrChkFlow.AddParameterValuesCondition(True, "flow", "TRUE")
        ucrChkFlow.AddParameterValuesCondition(False, "flow", "FALSE")

        ucrChkSetStartDate.SetText("Start Date")
        ucrChkSetStartDate.AddParameterValuesCondition(True, "checked", "TRUE")
        ucrChkSetStartDate.AddParameterValuesCondition(False, "checked", "FALSE")

        ucrChkFilter.SetText("Filter to groups")
        ucrChkFilter.AddParameterValuesCondition(True, "filter", "TRUE")
        ucrChkFilter.AddParameterValuesCondition(False, "filter", "FALSE")
        ucrChkFilter.AddToLinkedControls(ucrInputFilterToGroups, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="joined")

        ucrInputFilterToGroups.SetParameter(New RParameter("filter_variable_value", 7))

        ttFlow.SetToolTip(ucrChkFlow.chkCheck, " To import by flow, you need to first import the flow metadata from the ""Flow Data"" button at the top. After pressing OK, you can then select which flows to import by clicking on 'Select Flows' button ")

        ucrSaveDataframeName.SetSaveTypeAsDataFrame()
        ucrSaveDataframeName.SetIsTextBox()
        ucrSaveDataframeName.SetLabelText("Data Frame Name:")

        ucrSaveFlow.SetSaveTypeAsDataFrame()
        ucrSaveFlow.SetIsTextBox()
        ucrSaveFlow.SetLabelText("Flow Data Name:")
    End Sub

    Private Sub SetDefaults()
        clsGetFlowDataFunction = New RFunction
        clsGetUserDataFunction = New RFunction
        clsSetTokenFunction = New RFunction
        clsDummyFunction = New RFunction
        clsConvertToFactor = New RFunction
        clsSetSiteFunction = New RFunction
        clsGetFlowFunction = New RFunction
        clsLinkDataFramesFunction = New RFunction
        clsModifyOperation = New ROperator
        clsClosingOperator = New ROperator
        clsOpeningOperator = New ROperator

        ucrSaveDataframeName.Reset()

        clsDummyFunction.AddParameter("checked", "FALSE", iPosition:=0)
        clsDummyFunction.AddParameter("checked1", "FALSE", iPosition:=1)
        clsDummyFunction.AddParameter("flow", "FALSE", iPosition:=2)
        clsDummyFunction.AddParameter("user", "TRUE", iPosition:=3)
        clsDummyFunction.AddParameter("filter", "FALSE", iPosition:=4)

        clsSetSiteFunction.SetPackageName("rapidpror")
        clsSetSiteFunction.SetRCommand("set_rapidpro_site")

        clsSetTokenFunction.SetPackageName("rapidpror")
        clsSetTokenFunction.SetRCommand("set_rapidpro_key")
        clsSetTokenFunction.AddParameter(strParameterName:="key", Chr(34) & Chr(34), iPosition:=0)
        clsSetTokenFunction.AddParameter(strParameterName:="file", "TRUE", iPosition:=1)

        clsGetUserDataFunction.SetPackageName("rapidpror")
        clsGetUserDataFunction.SetRCommand("get_user_data")
        clsGetUserDataFunction.AddParameter("rapidpro_site", "rapidpror::get_rapidpro_site()", iPosition:=0)
        clsGetUserDataFunction.AddParameter("token", "rapidpror::get_rapidpro_key()", iPosition:=1)
        clsGetUserDataFunction.AddParameter("flatten", "TRUE", iPosition:=2)
        clsGetUserDataFunction.AddParameter("unlist_consent", "TRUE", iPosition:=3)

        clsGetFlowDataFunction.SetPackageName("rapidpror")
        clsGetFlowDataFunction.SetRCommand("get_flow_names")
        clsGetFlowDataFunction.AddParameter("rapidpro_site", "rapidpror::get_rapidpro_site()", iPosition:=0)
        clsGetFlowDataFunction.AddParameter("token", "rapidpror::get_rapidpro_key()", iPosition:=1)
        clsGetFlowDataFunction.AddParameter("flatten", "TRUE", iPosition:=2)

        clsGetFlowFunction.SetPackageName("rapidpror")
        clsGetFlowFunction.SetRCommand("get_flow_data")
        clsGetFlowFunction.AddParameter("rapidpro_site", "rapidpror::get_rapidpro_site()", iPosition:=0)
        clsGetFlowFunction.AddParameter("token", "rapidpror::get_rapidpro_key()", iPosition:=1)
        clsGetFlowFunction.AddParameter("flatten", "TRUE", iPosition:=2)

        clsConvertToFactor.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        clsConvertToFactor.AddParameter("col_names", Chr(34) & "name" & Chr(34), iPosition:=1)
        clsConvertToFactor.AddParameter("to_type", Chr(34) & "factor" & Chr(34), iPosition:=3)

        clsLinkDataFramesFunction.SetPackageName("rapidpror")
        clsLinkDataFramesFunction.SetRCommand("link_data_frames")

        clsModifyOperation.SetOperation("%in%")

        clsOpeningOperator.SetOperation("[")

        clsClosingOperator.SetOperation("]")

        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputStartDate.AddAdditionalCodeParameterPair(clsGetFlowDataFunction, ucrInputStartDate.GetParameter(), iAdditionalPairNo:=1)
        ucrInputEndDate.AddAdditionalCodeParameterPair(clsGetFlowDataFunction, ucrInputEndDate.GetParameter(), iAdditionalPairNo:=1)
        ucrInputDateFormat.AddAdditionalCodeParameterPair(clsGetFlowDataFunction, ucrInputDateFormat.GetParameter(), iAdditionalPairNo:=1)
        ucrInputTimezone.AddAdditionalCodeParameterPair(clsGetFlowDataFunction, ucrInputTimezone.GetParameter(), iAdditionalPairNo:=1)

        ucrSaveDataframeName.AddAdditionalRCode(clsGetFlowDataFunction, iAdditionalPairNo:=1)

        ucrInputRapidProSite.SetRCode(clsSetSiteFunction, bReset)
        ucrInputEndDate.SetRCode(clsGetUserDataFunction, bReset)
        ucrInputStartDate.SetRCode(clsGetUserDataFunction, bReset)
        ucrInputDateFormat.SetRCode(clsGetUserDataFunction, bReset)
        ucrInputTimezone.SetRCode(clsGetUserDataFunction, bReset)
        ucrChkSetEndDate.SetRCode(clsDummyFunction, bReset)
        ucrChkSetStartDate.SetRCode(clsDummyFunction, bReset)
        ucrSaveDataframeName.SetRCode(clsGetUserDataFunction, bReset)
        ucrSaveFlow.SetRCode(clsGetFlowFunction, bReset)
        ucrInputFilterToGroups.SetRCode(clsGetUserDataFunction, bReset)
        If bReset Then
            ucrChkUser.SetRCode(clsDummyFunction, bReset)
            ucrChkFlow.SetRCode(clsDummyFunction, bReset)
            ucrChkFilter.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputRapidProSite.IsEmpty AndAlso clsSetTokenFunction.GetParameter("key").strArgumentValue <> Chr(34) & Chr(34) AndAlso ucrSaveDataframeName.IsComplete AndAlso (ucrChkUser.Checked OrElse ucrChkFlow.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrPnlImportFromRapidPro_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlImportFromRapidPro.ControlValueChanged,
       ucrChkFlow.ControlValueChanged, ucrChkUser.ControlValueChanged
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsSetTokenFunction, 0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsSetSiteFunction, 1)
        grpDataToImport.Visible = False
        ucrChkFlow.Visible = False
        ucrChkUser.Visible = False
        ucrSaveFlow.Visible = False

        If rdoUserData.Checked AndAlso ucrChkUser.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetUserDataFunction)
            ucrSaveDataframeName.SetPrefix("user_data")
            ucrSaveFlow.Visible = False

        ElseIf rdoUserData.Checked AndAlso ucrChkFlow.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetFlowFunction)
            ucrSaveFlow.SetPrefix("flow_data")
            ucrSaveFlow.Visible = True

        ElseIf rdoFlowData.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetFlowDataFunction)
            ucrSaveDataframeName.SetPrefix("flow_metadata")
        End If

        If rdoUserData.Checked AndAlso ucrChkFlow.Checked AndAlso ucrChkUser.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsGetUserDataFunction)
            ucrBase.clsRsyntax.AddToAfterCodes(clsGetFlowFunction, 0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsLinkDataFramesFunction, 1)
            ucrSaveFlow.SetPrefix("flow_data")
            ucrSaveDataframeName.SetPrefix("user_data")
            ucrSaveFlow.Visible = True
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetFlowFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetUserDataFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsLinkDataFramesFunction)
            ucrSaveFlow.Visible = False
        End If

        If rdoFlowData.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsConvertToFactor, 0)
        End If

        If rdoUserData.Checked Then
            grpDataToImport.Visible = True
            ucrChkFlow.Visible = True
            ucrChkUser.Visible = True
        Else
            grpDataToImport.Visible = False
            ucrChkFlow.Visible = False
            ucrChkUser.Visible = False
        End If

        If rdoUserData.Checked AndAlso ucrChkFlow.Checked Then
            cmdSelectFlows.Visible = True
        Else
            cmdSelectFlows.Visible = False
        End If
        ucrChkFilter.Visible = ucrChkUser.Checked
    End Sub

    Private Sub cmdSetToken_Click(sender As Object, e As EventArgs) Handles cmdSetToken.Click
        sdgImportFromRapidPro.Setup(clsSetTokenFunction.GetParameter("key"))
        sdgImportFromRapidPro.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub ucrChkSetStartDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSetStartDate.ControlValueChanged,
        ucrChkSetEndDate.ControlValueChanged, ucrInputDateFormat.ControlValueChanged, ucrInputTimezone.ControlValueChanged
        ucrInputDateFormat.Visible = ucrChkSetStartDate.Checked OrElse ucrChkSetEndDate.Checked
        ucrInputTimezone.Visible = ucrInputDateFormat.Visible
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrInputRapidProSite_ControlContentsChanged(ucrChangedControl As ucrCore) Handles  ucrInputRapidProSite.ControlContentsChanged,
        ucrPnlImportFromRapidPro.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdSelectFlows_Click(sender As Object, e As EventArgs) Handles cmdSelectFlows.Click
        sdgFlowsToImport.SetRFunction(clsNewGetFlowFunction:=clsGetFlowFunction, clsNewModifyOperation:=clsModifyOperation, clsNewClosingOperator:=clsClosingOperator, clsNewOpeningOperator:=clsOpeningOperator, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgFlowsToImport.ShowDialog()
    End Sub

    Private Sub ucrSaveDataframeName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveDataframeName.ControlValueChanged
        clsConvertToFactor.AddParameter("data_name", Chr(34) & ucrSaveDataframeName.GetText & Chr(34)) 'TODO: this to be the name in the ucrSave
    End Sub

    Private Sub ucrChkFilter_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFilter.ControlValueChanged, ucrInputFilterToGroups.ControlValueChanged
        If ucrChkFilter.Checked AndAlso Not ucrInputFilterToGroups.IsEmpty Then
            clsGetUserDataFunction.AddParameter("filter_variable", Chr(34) & "group" & Chr(34))
        Else
            clsGetUserDataFunction.RemoveParameterByName("filter_variable")
            clsGetUserDataFunction.RemoveParameterByName("filter_variable_value")
        End If
        ucrInputFilterToGroups.Visible = ucrChkFilter.Checked
    End Sub

End Class
