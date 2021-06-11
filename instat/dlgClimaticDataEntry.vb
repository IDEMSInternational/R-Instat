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

Public Class dlgClimaticDataEntry
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSaveDataEntryFunction As New RFunction
    Private clsEditDataFrameFunction As New RFunction
    Private clsGetDataEntryFunction As New RFunction
    Private clsCommentsListFunction As New RFunction
    Private clsListFunction As New RFunction
    Private clsGetKeyFunction As New RFunction
    Private strStationColumn As String = ""
    Private ReadOnly strDay As String = "Day"
    Private ReadOnly strMonth As String = "Month"
    Private ReadOnly strRange As String = "Range"
    Private bChange As Boolean = False
    Private bSubdialogFirstLoad As Boolean = True
    Private bState As Boolean = False
    Private bResetSubdialogs As Boolean

    Private Sub dlgClimaticDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ucrBase.OKEnabled(False)
        SetNumberCommentEnteredText(sdgCommentForDataEntry.GetSetNumberOfCommentsEntered)
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctPeriods As New Dictionary(Of String, String)

        ucrPnlOptions.AddRadioButton(rdoAdd)
        ucrPnlOptions.AddRadioButton(rdoEdit)
        rdoAdd.Enabled = False
        rdoEdit.Checked = True

        ucrBase.iHelpTopicID = 359

        dctPeriods.Add("Day", Chr(34) & "day" & Chr(34))
        dctPeriods.Add("Month", Chr(34) & "month" & Chr(34))
        dctPeriods.Add("Range", Chr(34) & "range" & Chr(34))

        ucrInputType.SetParameter(New RParameter("type", iNewPosition:=6))
        ucrInputType.SetItems(dctPeriods)
        ucrInputType.SetDropDownStyleAsNonEditable()

        ucrSelectorClimaticDataEntry.SetParameterIsString()
        ucrSelectorClimaticDataEntry.SetParameter(New RParameter("data_name", iNewPosition:=0))

        ucrReceiverStation.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.SetParameter(New RParameter("station", iNewPosition:=1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.SetIncludedDataTypes({"factor"})
        ucrReceiverStation.strSelectorHeading = "Factors"

        ucrInputSelectStation.SetFactorReceiver(ucrReceiverStation)
        ucrInputSelectStation.strQuotes = ""


        ucrReceiverDate.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetIncludedDataTypes({"Date"})
        ucrReceiverDate.SetParameter(New RParameter("date", iNewPosition:=2))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date"

        ucrReceiverElements.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverElements.SetParameter(New RParameter("elements", iNewPosition:=3))
        ucrReceiverElements.SetParameterIsString()
        ucrReceiverElements.strSelectorHeading = "Numerics"
        ucrReceiverElements.SetIncludedDataTypes({"numeric"}, bStrict:=True)
        ucrReceiverElements.bAutoFill = True

        ucrReceiverViewVariables.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverViewVariables.SetParameter(New RParameter("view_variables", iNewPosition:=4))
        ucrReceiverViewVariables.SetParameterIsString()

        ucrStartDate.SetParameter(New RParameter("start_date", iNewPosition:=8))
        ucrStartDate.SetParameterIsRDate()

        ucrEndDate.SetParameter(New RParameter("end_date", iNewPosition:=9))
        ucrEndDate.SetParameterIsRDate()

        ttCmdCheckData.SetToolTip(cmdCheckData, "Data checking facilities not yet implemented")
        cmdCheckData.Enabled = False
    End Sub

    Private Sub SetDefaults()
        clsSaveDataEntryFunction = New RFunction
        clsEditDataFrameFunction = New RFunction
        clsGetDataEntryFunction = New RFunction
        clsCommentsListFunction = New RFunction
        clsListFunction = New RFunction
        clsGetKeyFunction = New RFunction

        ucrSelectorClimaticDataEntry.Reset()
        ucrReceiverElements.SetMeAsReceiver()
        ucrInputSelectStation.bFirstLevelDefault = True
        lblNbCommentEntered.Visible = False
        lblNbRowsChanged1.Visible = False

        clsGetDataEntryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_entry_data")
        clsGetDataEntryFunction.AddParameter("type", Chr(34) & "month" & Chr(34), iPosition:=6)

        clsSaveDataEntryFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$save_data_entry_data")
        clsSaveDataEntryFunction.AddParameter("new_data", clsRFunctionParameter:=clsEditDataFrameFunction, iPosition:=1)

        clsEditDataFrameFunction.SetRCommand("data.frame")
        clsEditDataFrameFunction.SetAssignTo("new_data")

        clsGetKeyFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$has_key")

        clsCommentsListFunction.SetRCommand("list")

        clsListFunction.SetRCommand("list")

        bChange = False
        bState = False
        bSubdialogFirstLoad = True
        bResetSubdialogs = True
        sdgCommentForDataEntry.GetSetNumberOfCommentsEntered = 0
        sdgClimaticDataEntryOptions.GetSetDefaultValue = "NA"
        sdgClimaticDataEntryOptions.GetSetNoDecimals = False
        sdgClimaticDataEntryOptions.GetSetAllowTrace = False
        sdgClimaticDataEntryOptions.GetSetTransform = False
        sdgClimaticDataEntryOptions.GetSetTransformValue = 0.1
        sdgClimaticDataEntryOptions.GetSetAllowTrace = False
        sdgClimaticDataEntryOptions.GetSetIncludeFirstNextOfMonth = False
        sdgClimaticDataEntryOptions.GetSetEditNAOnly = False

        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.SetBaseRFunction(clsSaveDataEntryFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorClimaticDataEntry.AddAdditionalCodeParameterPair(clsSaveDataEntryFunction, ucrSelectorClimaticDataEntry.GetParameter(), iAdditionalPairNo:=1)

        ucrInputType.SetRCode(clsGetDataEntryFunction, bReset)
        ucrSelectorClimaticDataEntry.SetRCode(clsGetDataEntryFunction, bReset)
        ucrReceiverStation.SetRCode(clsGetDataEntryFunction, bReset)
        ucrReceiverDate.SetRCode(clsGetDataEntryFunction, bReset)
        ucrReceiverElements.SetRCode(clsGetDataEntryFunction, bReset)
        ucrReceiverViewVariables.SetRCode(clsGetDataEntryFunction, bReset)
        ucrInputSelectStation.SetRCode(clsGetDataEntryFunction, bReset)

        ucrStartDate.SetRCode(clsGetDataEntryFunction, bReset)
        ucrEndDate.SetRCode(clsGetDataEntryFunction, bReset)
        If bReset Then
            'Default start date to 1 Jan.
            ucrStartDate.DateValue = New Date(Date.Now.Year, "1", "1")
        End If
        SetDateOptions()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty Then
            ucrBase.OKEnabled(clsSaveDataEntryFunction.ContainsParameter("rows_changed"))
            cmdEnterData.Enabled = True
            If Not ucrReceiverStation.IsEmpty AndAlso ucrInputSelectStation.IsEmpty Then
                cmdEnterData.Enabled = False
            End If
        Else
            ucrBase.OKEnabled(False)
            cmdEnterData.Enabled = False
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        sdgClimaticDataEntry.Reset()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrInputSelectStation.ControlContentsChanged, ucrReceiverDate.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub cmdEnterData_Click(sender As Object, e As EventArgs) Handles cmdEnterData.Click
        Dim strStationColumnName As String
        Dim strDateColumnName As String
        Dim lstElementsColumnNames As List(Of String)
        Dim lstVariablesColumnNames As List(Of String)
        Dim strStationSelected As String
        Dim dfEditData As DataFrame
        Dim strDataFrameName As String
        Dim bSetup As Boolean
        Dim bShow As Boolean

        strDataFrameName = ucrSelectorClimaticDataEntry.strCurrentDataFrame
        strStationColumnName = ucrReceiverStation.GetVariableNames(bWithQuotes:=False)
        strStationSelected = ucrInputSelectStation.GetValue()
        strDateColumnName = ucrReceiverDate.GetVariableNames(bWithQuotes:=False)
        lstElementsColumnNames = ucrReceiverElements.GetVariableNamesList(bWithQuotes:=False).ToList
        lstVariablesColumnNames = ucrReceiverViewVariables.GetVariableNamesList(bWithQuotes:=False).ToList
        dfEditData = GetSelectedDataFrame()

        If dfEditData Is Nothing Then
            MsgBox("No available data for this selection. Modify dates and try again.")
            Exit Sub
        End If

        If bChange Then
            If bSubdialogFirstLoad Then
                bSetup = True
                bShow = True
            Else
                bShow = MsgBox("Are you sure you want to continue? If you reopen the subdialog the existing data entry will be lost. Return and click Ok to apply the existing change or continue to start again.", MsgBoxStyle.YesNo) = MsgBoxResult.Yes
                bSetup = bShow
            End If
        Else
            bShow = True
            bSetup = False
        End If

        If bShow Then
            If bSetup Then
                sdgClimaticDataEntry.Setup(dfEditData:=dfEditData, strDataFrameName:=strDataFrameName, clsSaveDataEntry:=clsSaveDataEntryFunction,
                                         clsEditDataFrame:=clsEditDataFrameFunction, clsNewGetKey:=clsGetKeyFunction, clsNewCommentsList:=clsCommentsListFunction, clsNewList:=clsListFunction,
                      strDateName:=strDateColumnName, lstElementsNames:=lstElementsColumnNames, lstViewVariablesNames:=lstVariablesColumnNames,
                                           strStationColumnName:=strStationColumnName,
                                           bEditNewDataOnly:=sdgClimaticDataEntryOptions.GetSetEditNAOnly,
                                           strDefaultValue:=sdgClimaticDataEntryOptions.GetSetDefaultValue,
                                           bNoDecimal:=sdgClimaticDataEntryOptions.GetSetNoDecimals,
                                           bAllowTrace:=sdgClimaticDataEntryOptions.GetSetAllowTrace,
                                           bTransform:=sdgClimaticDataEntryOptions.GetSetTransform,
                                           dTranformValue:=sdgClimaticDataEntryOptions.GetSetTransformValue,
                                           strEntryType:=ucrInputType.GetText, ucrNewBaseSelector:=ucrSelectorClimaticDataEntry, bReset:=bResetSubdialogs)
            End If
            sdgClimaticDataEntry.ShowDialog()
            bResetSubdialogs = False
            SetNumberRowsChangedText(sdgClimaticDataEntry.NRowsChanged)
            SetNumberCommentEnteredText(sdgCommentForDataEntry.GetSetNumberOfCommentsEntered)
            bSubdialogFirstLoad = False
            bChange = False
            TestOkEnabled()
        End If
    End Sub

    Public Function GetSelectedDataFrame() As DataFrame
        Dim dfTemp As DataFrame = Nothing
        Dim expTemp As SymbolicExpression

        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataEntryFunction.ToScript(), bSilent:=True)
        If expTemp IsNot Nothing Then
            dfTemp = expTemp.AsDataFrame()
        End If
        Return dfTemp
    End Function

    Private Sub ucrChangedControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrReceiverDate.ControlValueChanged, ucrReceiverElements.ControlValueChanged, ucrReceiverViewVariables.ControlValueChanged, ucrInputType.ControlValueChanged, ucrStartDate.ControlValueChanged, ucrEndDate.ControlValueChanged, ucrInputSelectStation.ControlValueChanged, ucrPnlOptions.ControlValueChanged
        bChange = True
    End Sub

    Private Sub ucrSelectorClimaticDataEntry_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimaticDataEntry.ControlValueChanged
        bChange = True
        SetNumberRowsChangedText(0)
    End Sub

    Private Sub SetDateOptions()
        Dim dtStart As Date

        dtStart = ucrStartDate.DateValue
        Select Case ucrInputType.GetText()
            Case strDay
                ucrEndDate.DateValue = dtStart
                ucrEndDate.Enabled = False
            Case strMonth
                If sdgClimaticDataEntryOptions.GetSetIncludeFirstNextOfMonth Then
                    ucrStartDate.DateValue = New Date(dtStart.Year, dtStart.Month, 2)
                Else
                    ucrStartDate.DateValue = New Date(dtStart.Year, dtStart.Month, 1)
                End If
                ucrEndDate.DateValue = ucrStartDate.DateValue.AddMonths(1).AddDays(-1)

                ucrEndDate.Enabled = False
            Case strRange
                ucrEndDate.Enabled = True
        End Select
    End Sub

    Private Sub DateControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputType.ControlValueChanged, ucrStartDate.ControlValueChanged
        SetDateOptions()
    End Sub

    Private Sub StationControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrInputSelectStation.ControlValueChanged
        clsEditDataFrameFunction.RemoveParameterByName(strStationColumn)
        clsGetDataEntryFunction.AddParameter("station_name", Chr(34) & ucrInputSelectStation.GetValue() & Chr(34), iPosition:=6)
        strStationColumn = ucrReceiverStation.GetVariableNames(bWithQuotes:=False)
        If Not strStationColumn = "" AndAlso Not ucrInputSelectStation.GetValue() = "" Then
            clsEditDataFrameFunction.AddParameter(strStationColumn, Chr(34) & ucrInputSelectStation.GetValue() & Chr(34), iPosition:=0)
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        bChange = True
        bSubdialogFirstLoad = True
        clsListFunction.ClearParameters()
        sdgCommentForDataEntry.GetSetNumberOfCommentsEntered = 0
        SetNumberRowsChangedText(0)
    End Sub

    Private Sub SetNumberRowsChangedText(nval As Integer)
        If nval > 0 Then
            lblNbRowsChanged1.Visible = True
            lblNbRowsChanged1.ForeColor = Color.Red
            lblNbRowsChanged1.Text = nval & " row(s) entered"
        Else
            lblNbRowsChanged1.Visible = False
        End If
    End Sub

    Private Sub SetNumberCommentEnteredText(nval As Integer)
        If nval > 0 Then
            lblNbCommentEntered.Visible = True
            lblNbCommentEntered.ForeColor = Color.Red
            lblNbCommentEntered.Text = nval & " comment(s) entered"
        Else
            lblNbCommentEntered.Visible = False
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgClimaticDataEntryOptions.SetUpDataEntryOptions(ucrInputType.GetText)
        sdgClimaticDataEntryOptions.ShowDialog()
        SetDateOptions()
        bChange = True
    End Sub
End Class