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

Imports System.IO
Imports instat.Translations

Public Class dlgExportToClimsoft
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDataFrameFunction, clsCurrentNewColumnFunction, clsDummyFunction, clsMutateFunction, clsExportClimsoftFunction As New RFunction
    Private clsPipeOperator As New ROperator

    Private Sub dlgExportToClimsoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
        AddStationName()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID=476
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.Selector = ucrSelectorImportToClimsoft
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)

        ucrReceiverDate.SetParameter(New RParameter("date", 2))
        ucrReceiverDate.SetParameterIsRFunction()
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrReceiverDate.Selector = ucrSelectorImportToClimsoft
        ucrReceiverDate.bAutoFill = True

        ucrInputHour.SetParameter(New RParameter("hour", 3))
        ucrInputHour.SetLinkedDisplayControl(lblHour)

        ucrInputLevel.SetParameter(New RParameter("level", 4))
        ucrInputLevel.SetLinkedDisplayControl(lblLevel)

        ucrReceiverElements.SetParameter(New RParameter("element", 5, bNewIncludeArgumentName:=False))
        ucrReceiverElements.SetParameterIsRFunction()
        ucrReceiverElements.SetLinkedDisplayControl(lblElement)
        ucrReceiverElements.Selector = ucrSelectorImportToClimsoft

        ucrChkNewDataFrame.SetText("New Data Frame Name")
        ucrChkNewDataFrame.AddToLinkedControls(ucrSaveNewDataFrame, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkNewDataFrame.AddParameterValuesCondition(True, "dataframe", "True")
        ucrChkNewDataFrame.AddParameterValuesCondition(False, "dataframe", "False")

        ucrChkExportDataFrame.SetText(" Export Data Frame(s)")
        ucrChkExportDataFrame.AddToLinkedControls(ucrInputExportFile, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkExportDataFrame.AddParameterValuesCondition(True, "export", "True")
        ucrChkExportDataFrame.AddParameterValuesCondition(False, "export", "False")

        ucrSaveNewDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveNewDataFrame.SetIsTextBox()
        ucrSaveNewDataFrame.SetLabelText("Data Frame Name:")

        ucrInputExportFile.SetParameter(New RParameter("file", 1))
        ucrInputExportFile.IsReadOnly = True
        ucrInputExportFile.SetLinkedDisplayControl(lblExport)

    End Sub

    Private Sub SetDefaults()
        clsDataFrameFunction = New RFunction
        clsDummyFunction = New RFunction
        clsCurrentNewColumnFunction = New RFunction
        clsMutateFunction = New RFunction
        clsExportClimsoftFunction = New RFunction
        clsPipeOperator = New ROperator

        ucrSelectorImportToClimsoft.Reset()
        ucrSaveNewDataFrame.Reset()
        ucrReceiverElements.SetMeAsReceiver()

        clsDummyFunction.AddParameter("dataframe", "True", iPosition:=0)
        clsDummyFunction.AddParameter("export", "False", iPosition:=1)

        clsDataFrameFunction.SetRCommand("data.frame")
        clsDataFrameFunction.AddParameter("hour", 6, iPosition:=3)
        clsDataFrameFunction.AddParameter("level", "surface", iPosition:=4)
        clsDataFrameFunction.AddParameter("x", "columns", iPosition:=5, bIncludeArgumentName:=False)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=clsDataFrameFunction, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")

        clsExportClimsoftFunction.SetPackageName("rio")
        clsExportClimsoftFunction.SetRCommand("export")
        clsExportClimsoftFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)

        DataFrameAssignTo()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDate.SetRCode(clsDataFrameFunction, bReset)
        ucrInputHour.SetRCode(clsDataFrameFunction, bReset)
        ucrInputLevel.SetRCode(clsDataFrameFunction, bReset)
        ucrSaveNewDataFrame.SetRCode(clsPipeOperator, bReset)
        ucrInputExportFile.SetRCode(clsExportClimsoftFunction, bReset)
        If bReset Then
            ucrChkExportDataFrame.SetRCode(clsDummyFunction, bReset)
            ucrChkNewDataFrame.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrReceiverDate.IsEmpty _
                              AndAlso Not ucrReceiverElements.IsEmpty _
                              AndAlso Not ucrReceiverStation.IsEmpty
                              )
        If ucrChkNewDataFrame.Checked And Not ucrSaveNewDataFrame.IsComplete Then
            ucrBase.OKEnabled(False)
        End If
        If ucrChkExportDataFrame.Checked And ucrInputExportFile.IsEmpty Then
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub DataFrameAssignTo()
        Dim strDataframeName As String = ucrSelectorImportToClimsoft.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        If strDataframeName = "" OrElse ucrSaveNewDataFrame.bUserTyped Then
            Exit Sub
        End If

        ucrSaveNewDataFrame.SetPrefix(strDataframeName & "__climsoft")

    End Sub

    Private Sub ucrSelectorImportToClimsoft_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorImportToClimsoft.ControlValueChanged
        DataFrameAssignTo()
    End Sub

    Private Sub ucrChkNewDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNewDataFrame.ControlValueChanged, ucrChkExportDataFrame.ControlValueChanged
        SettingBaseFunction()
    End Sub

    Private Sub ucrReceiverElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElements.ControlValueChanged
        ucrBase.clsRsyntax.GetBeforeCodes().Clear()
        clsCurrentNewColumnFunction = ucrReceiverElements.GetVariables(True).Clone
        clsCurrentNewColumnFunction.SetAssignTo("columns")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
        SettingBaseFunction()
    End Sub

    Private Sub AddStationName()
        If ucrReceiverStation.IsEmpty Then
            ucrReceiverStation.SetText(ucrSelectorImportToClimsoft.strCurrentDataFrame)
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)
        Else
            clsPipeOperator.RemoveParameterByName("right")
        End If
        If ucrSelectorImportToClimsoft.lstAvailableVariable.FindItemWithText(ucrReceiverStation.GetVariableNames(False)) Is Nothing Then
            clsMutateFunction.AddParameter("station", ucrReceiverStation.GetVariableNames(), iPosition:=0)
            clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)
            clsDataFrameFunction.RemoveParameterByName("station")
        Else
            Dim clsGetVariable As RFunction = ucrReceiverStation.GetVariables
            clsGetVariable.SetAssignTo("station")
            clsDataFrameFunction.AddParameter("station", clsRFunctionParameter:=clsGetVariable, iPosition:=1)
            clsPipeOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        SelectFileToSave()
    End Sub

    Private Sub SettingBaseFunction()
        cmdBrowse.Visible = False
        If ucrChkNewDataFrame.Checked And ucrChkExportDataFrame.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            ucrBase.clsRsyntax.ClearCodes()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
            ucrBase.clsRsyntax.AddToAfterCodes(clsExportClimsoftFunction)
            cmdBrowse.Visible = True
        ElseIf ucrChkNewDataFrame.Checked AndAlso Not ucrChkExportDataFrame.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            ucrBase.clsRsyntax.GetAfterCodes().Clear()
            cmdBrowse.Visible = False

        ElseIf ucrChkExportDataFrame.Checked AndAlso Not ucrChkNewDataFrame.Checked Then
            ucrBase.clsRsyntax.GetBeforeCodes().Clear()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
            ucrBase.clsRsyntax.SetBaseRFunction(clsExportClimsoftFunction)
            ucrBase.clsRsyntax.GetAfterCodes().Clear()
            cmdBrowse.Visible = True
        End If
    End Sub

    Private Sub SelectFileToSave()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save CPT File"
            dlgSave.Filter = "Comma separated file (*.csv)|*.csv"
            If ucrInputExportFile.GetText() <> "" Then
                dlgSave.InitialDirectory = ucrInputExportFile.GetText().Replace("/", "\")
            Else
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputExportFile.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
            TestOkEnabled()
        End Using
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        AddStationName()
    End Sub

    Private Sub ucrReceiverElements_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElements.ControlContentsChanged,
        ucrReceiverDate.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged, ucrInputLevel.ControlContentsChanged,
        ucrInputLevel.ControlContentsChanged, ucrInputExportFile.ControlContentsChanged, ucrChkExportDataFrame.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        If ucrInputExportFile.IsEmpty() Then
            SelectFileToSave()
        End If
        SettingBaseFunction()
    End Sub
End Class