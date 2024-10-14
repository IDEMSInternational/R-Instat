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

Imports System.IO
Imports instat.Translations

Public Class dlgExportToClimsoft
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDataFrameFunction, clsGetDataFrameFunction, clsCurrentNewColumnFunction, clsDummyFunction, clsMutateFunction, clsExportClimsoftFunction, clsPasteFunction, clsSprintfFunction, clsPosixctFunction, clsExportCommentsFunction As New RFunction
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
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 476
        ucrReceiverStationID.SetParameter(New RParameter("station_id", 1))
        ucrReceiverStationID.SetParameterIsRFunction()
        ucrReceiverStationID.SetLinkedDisplayControl(lblStationID)
        ucrReceiverStationID.Selector = ucrSelectorImportToClimsoft

        ucrDataFrameSheets.SetParameter(New RParameter("x", 0))
        ucrDataFrameSheets.SetParameterIsRFunction()

        ucrPnlOutput.AddRadioButton(rdoNewDataFrame)
        ucrPnlOutput.AddRadioButton(rdoExportData)

        ucrPnlOutput.AddParameterValuesCondition(rdoNewDataFrame, "check", "dataframe")
        ucrPnlOutput.AddParameterValuesCondition(rdoExportData, "check", "export")

        ucrChkAddReport.SetText("Add Report (Comments Sheet)")
        ucrChkAddReport.AddToLinkedControls({ucrDataFrameSheets, ucrInputExportFile}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddReport.AddParameterValuesCondition(True, "comments", "True")
        ucrChkAddReport.AddParameterValuesCondition(False, "comments", "False")

        ucrReceiverDate.SetParameter(New RParameter("date", 2))
        ucrReceiverDate.SetParameterIsRFunction()
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrReceiverDate.Selector = ucrSelectorImportToClimsoft
        ucrReceiverDate.bAutoFill = True

        ucrPnlDailyHourly.AddRadioButton(rdoDaily)
        ucrPnlDailyHourly.AddRadioButton(rdoHourly)
        ucrPnlDailyHourly.AddParameterValuesCondition(rdoDaily, "checked", "daily")
        ucrPnlDailyHourly.AddParameterValuesCondition(rdoHourly, "checked", "hourly")

        ucrInputHour.SetParameter(New RParameter("hour", 3))
        ucrInputHour.SetLinkedDisplayControl(lblHour)

        ucrReceiverElements.SetParameter(New RParameter("element", 5, bNewIncludeArgumentName:=False))
        ucrReceiverElements.SetParameterIsRFunction()
        ucrReceiverElements.SetLinkedDisplayControl(lblElement)
        ucrReceiverElements.Selector = ucrSelectorImportToClimsoft

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
        clsPasteFunction = New RFunction
        clsSprintfFunction = New RFunction
        clsExportCommentsFunction = New RFunction
        clsPipeOperator = New ROperator

        ucrSelectorImportToClimsoft.Reset()
        ucrSaveNewDataFrame.Reset()
        ucrReceiverStationID.SetMeAsReceiver()

        clsDummyFunction.AddParameter("dataframe", "True", iPosition:=0)
        clsDummyFunction.AddParameter("export", "False", iPosition:=1)
        clsDummyFunction.AddParameter("checked", "daily", iPosition:=2)
        clsDummyFunction.AddParameter("value", "True", iPosition:=3)
        clsDummyFunction.AddParameter("check", "dataframe", iPosition:=4)

        clsPosixctFunction.SetRCommand("as.POSIXct")
        clsPosixctFunction.AddParameter("x", clsRFunctionParameter:=clsPasteFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsPosixctFunction.AddParameter("format", Chr(34) & "%Y-%m-%d %H:%M:%S" & Chr(34), iPosition:=1)

        clsDataFrameFunction.SetRCommand("data.frame")
        clsDataFrameFunction.AddParameter("date_time", clsRFunctionParameter:=clsPosixctFunction, iPosition:=4)
        clsDataFrameFunction.AddParameter("x", "columns", iPosition:=5, bIncludeArgumentName:=False)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=clsDataFrameFunction, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")

        clsExportClimsoftFunction.SetRCommand("write.csv")
        clsExportClimsoftFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)

        clsPasteFunction.SetRCommand("paste")
        clsPasteFunction.SetAssignTo("date1")

        clsSprintfFunction.SetRCommand("sprintf")
        clsSprintfFunction.AddParameter("hour", 6, iPosition:=1, bIncludeArgumentName:=False)

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        clsGetDataFrameFunction.SetAssignTo(ucrDataFrameSheets.cboAvailableDataFrames.Text)

        clsExportCommentsFunction.SetPackageName("rio")
        clsExportCommentsFunction.SetRCommand("export")
        clsExportCommentsFunction.AddParameter("x", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=1)

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsPasteFunction, iPosition:=1)

        DataFrameAssignTo()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputExportFile.AddAdditionalCodeParameterPair(clsExportCommentsFunction, New RParameter("file", 0), iAdditionalPairNo:=1)

        ucrReceiverDate.SetRCode(clsPasteFunction, bReset)
        ucrInputHour.SetRCode(clsSprintfFunction, bReset)
        ucrReceiverStationID.SetRCode(clsDataFrameFunction, bReset)
        ucrSaveNewDataFrame.SetRCode(clsPipeOperator, bReset)
        ucrInputExportFile.SetRCode(clsExportClimsoftFunction, bReset)
        ucrPnlDailyHourly.SetRCode(clsDummyFunction, bReset)
        If bReset Then
            ucrPnlOutput.SetRCode(clsDummyFunction, bReset)
            ucrChkAddReport.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()

        If rdoNewDataFrame.Checked Then
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrSaveNewDataFrame.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If Not ucrChkAddReport.Checked Then
                If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso Not ucrInputExportFile.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                If ucrDataFrameSheets.cboAvailableDataFrames.Text <> "" AndAlso Not ucrInputExportFile.IsEmpty Then
                    ucrBase.OKEnabled(True)

                Else
                    ucrBase.OKEnabled(False)

                End If
            End If
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

    Private Sub ucrReceiverElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElements.ControlValueChanged
        ucrBase.clsRsyntax.GetBeforeCodes().Clear()
        clsCurrentNewColumnFunction = ucrReceiverElements.GetVariables(True).Clone
        clsCurrentNewColumnFunction.SetAssignTo("columns")
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
        SettingBaseFunction()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        SelectFileToSave()
    End Sub

    Private Sub SettingBaseFunction()

        cmdBrowse.Visible = False
        If rdoNewDataFrame.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            ucrBase.clsRsyntax.GetAfterCodes().Clear()
            cmdBrowse.Visible = False
            ucrInputExportFile.Visible = False

        Else
            ucrBase.clsRsyntax.GetAfterCodes().Clear()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
            ucrBase.clsRsyntax.SetBaseRFunction(clsExportClimsoftFunction)
            ucrBase.clsRsyntax.GetAfterCodes().Clear()
            cmdBrowse.Visible = True
            ucrInputExportFile.Visible = True
        End If

        If ucrChkAddReport.Checked AndAlso rdoExportData.Checked Then
            ucrBase.clsRsyntax.ClearCodes()
            ucrBase.clsRsyntax.SetBaseRFunction(clsExportCommentsFunction)
            cmdBrowse.Visible = True
            ucrInputExportFile.Visible = True
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

    Private Sub EnableDisableComments()
        If rdoExportData.Checked Then
            ucrChkAddReport.Enabled = True
        Else
            ucrChkAddReport.Enabled = False
            ucrChkAddReport.Checked = False
        End If

    End Sub

    Private Sub ucrReceiverElements_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElements.ControlContentsChanged,
        ucrReceiverDate.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged, ucrChkAddReport.ControlContentsChanged,
        ucrReceiverStationID.ControlContentsChanged, ucrInputExportFile.ControlContentsChanged, ucrDataFrameSheets.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        If ucrInputExportFile.IsEmpty() Then
            SelectFileToSave()
        End If
        SettingBaseFunction()
        EnableDisableComments()
    End Sub

    Private Sub ucrDataFrameSheets_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameSheets.ControlValueChanged
        SettingBaseFunction()

        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrDataFrameSheets.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetDataFrameFunction.SetAssignTo(ucrDataFrameSheets.cboAvailableDataFrames.Text)

    End Sub

    Private Sub ucrChkAddReport_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddReport.ControlValueChanged
        If ucrChkAddReport.Checked Then
            ucrInputExportFile.SetName("")
        End If
        SettingBaseFunction()
        EnableDisableComments()
        TestOkEnabled()
    End Sub

    Private Sub ucrInputHour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputHour.ControlValueChanged
        If Not ucrInputHour.IsEmpty Then
            clsSprintfFunction.AddParameter("fmt", Chr(34) & "%02d:00:00" & Chr(34), iPosition:=0)
            clsSprintfFunction.AddParameter("hour", ucrInputHour.GetText, bIncludeArgumentName:=False, iPosition:=1)

        Else
            clsSprintfFunction.RemoveParameterByName("format")
            clsSprintfFunction.RemoveParameterByName("hour")
        End If
    End Sub

    Private Sub ucrReceiverDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlValueChanged
        If Not ucrReceiverDate.IsEmpty Then
            clsPasteFunction.AddParameter("date_time", clsRFunctionParameter:=clsSprintfFunction, iPosition:=3, bIncludeArgumentName:=False)
        Else
            clsPasteFunction.RemoveParameterByName("date")
            clsPasteFunction.RemoveParameterByName("date_time")
        End If
    End Sub

    Private Sub ucrInputExportFile_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputExportFile.ControlValueChanged
        EnableDisableComments()
    End Sub

    Private Sub ucrPnlOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOutput.ControlValueChanged
        EnableDisableComments()
        SettingBaseFunction()
        TestOkEnabled()
    End Sub

End Class