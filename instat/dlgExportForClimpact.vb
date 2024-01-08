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

Public Class dlgExportForClimpact
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDataFrameFunction, clsCurrentNewColumnFunction, clsOutputClimpact, clsDummyFunction, clsMutateFunction, clsExportClimpactFunction As New RFunction
    Private clsPipeOperator As New ROperator

    Private Sub dlgExportForClimpact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrInputCodeMissingValues.SetParameter(New RParameter("na_code"))
        ucrInputCodeMissingValues.SetRDefault("-99.9")
        ucrInputCodeMissingValues.AddQuotesIfUnrecognised = False

        'Year Receiver
        ucrReceiverYear.Selector = ucrSelectorImportToClimpact
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        'Month Receiver
        ucrReceiverMonth.Selector = ucrSelectorImportToClimpact
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"

        'Day Receiver
        ucrReceiverDay.Selector = ucrSelectorImportToClimpact
        ucrReceiverDay.SetParameter(New RParameter("day", 0))
        ucrReceiverDay.SetParameterIsString()
        ucrReceiverDay.bWithQuotes = False
        ucrReceiverDay.bAutoFill = True
        ucrReceiverDay.SetClimaticType("doy")
        ucrReceiverDay.strSelectorHeading = "Day Variables"

        'Element Receiver
        ucrReceiverTX.Selector = ucrSelectorImportToClimpact
        ucrReceiverTX.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrReceiverTX.SetParameterIsString()
        ucrReceiverTX.bWithQuotes = False
        ucrReceiverTX.SetClimaticType("temp_max")
        ucrReceiverTX.bAutoFill = True


        ucrReceiverTN.Selector = ucrSelectorImportToClimpact
        ucrReceiverTN.SetParameter(New RParameter("x", 1, bNewIncludeArgumentName:=False))
        ucrReceiverTN.SetParameterIsString()
        ucrReceiverTN.SetClimaticType("temp_min")
        ucrReceiverTN.bAutoFill = True
        ucrReceiverTN.bWithQuotes = False

        ucrReceiverRR.SetParameter(New RParameter("left", 2, bNewIncludeArgumentName:=False))
        ucrReceiverRR.Selector = ucrSelectorImportToClimpact
        ucrReceiverRR.SetClimaticType("rain")
        ucrReceiverRR.bAutoFill = True
        ucrReceiverRR.SetParameterIsString()
        ucrReceiverRR.bWithQuotes = False

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

        DataFrameAssignTo()
    End Sub

    Private Sub SetDefaults()
        clsDataFrameFunction = New RFunction
        clsDummyFunction = New RFunction
        clsCurrentNewColumnFunction = New RFunction
        clsMutateFunction = New RFunction
        clsExportClimpactFunction = New RFunction
        clsPipeOperator = New ROperator
        clsOutputClimpact = New RFunction

        ucrSelectorImportToClimpact.Reset()
        ucrSaveNewDataFrame.Reset()


        clsDummyFunction.AddParameter("dataframe", "True", iPosition:=0)
        clsDummyFunction.AddParameter("export", "False", iPosition:=1)

        clsDataFrameFunction.SetRCommand("data.frame")
        clsDataFrameFunction.AddParameter("x", "columns", iPosition:=5, bIncludeArgumentName:=False)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("left", clsRFunctionParameter:=clsOutputClimpact, iPosition:=0)
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsMutateFunction, iPosition:=1)

        clsOutputClimpact.SetRCommand("output_Climpact")
        clsOutputClimpact.AddParameter("long.data", "TRUE")

        clsMutateFunction.SetPackageName("dplyr")
        clsMutateFunction.SetRCommand("mutate")

        clsExportClimpactFunction.SetPackageName("rio")
        clsExportClimpactFunction.SetRCommand("export")
        clsExportClimpactFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)


        'ucrBase.clsRsyntax.SetBaseRFunction(clsExportClimpactFunction)
        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
        'ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverDay.SetRCode(clsOutputClimpact, bReset)
        ucrReceiverYear.SetRCode(clsOutputClimpact, bReset)
        ucrSelectorImportToClimpact.SetRCode(clsOutputClimpact, bReset)
        ucrReceiverRR.SetRCode(clsOutputClimpact, bReset)
        ucrReceiverTN.SetRCode(clsOutputClimpact, bReset)
        ucrReceiverTX.SetRCode(clsOutputClimpact, bReset)
        ucrReceiverMonth.SetRCode(clsOutputClimpact, bReset)
        ucrInputCodeMissingValues.SetRCode(clsOutputClimpact, bReset)
        ucrInputExportFile.SetRCode(clsExportClimpactFunction)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrReceiverDay.IsEmpty _
                             AndAlso Not ucrReceiverMonth.IsEmpty _
                             AndAlso Not ucrReceiverYear.IsEmpty _
                             AndAlso Not ucrReceiverRR.IsEmpty _
                             AndAlso Not ucrReceiverTX.IsEmpty _
                             AndAlso Not ucrReceiverTN.IsEmpty
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
        Dim strDataframeName As String = ucrSelectorImportToClimpact.ucrAvailableDataFrames.cboAvailableDataFrames.Text
        If strDataframeName = "" OrElse ucrSaveNewDataFrame.bUserTyped Then
            Exit Sub
        End If
        ucrSaveNewDataFrame.SetPrefix(strDataframeName & "__climpact")
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        SelectFileToSave()
    End Sub

    Private Sub SelectFileToSave()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Climpact File"
            dlgSave.Filter = "Comma separated file (*.csv)|*.csv|Text File (*.txt)|*.txt"
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

    Private Sub ucrSelectorImportToClimpact_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorImportToClimpact.ControlValueChanged
        DataFrameAssignTo()
    End Sub

    'Private Sub ucrChkNewDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNewDataFrame.ControlValueChanged, ucrChkExportDataFrame.ControlValueChanged
    '    SettingBaseFunction()
    'End Sub

    'Private Sub ucrReceiverElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRR.ControlValueChanged, ucrReceiverTN.ControlValueChanged, ucrReceiverTX.ControlValueChanged
    '    ucrBase.clsRsyntax.lstBeforeCodes.Clear()
    '    clsCurrentNewColumnFunction = ucrReceiver.Get(True).Clone
    '    clsCurrentNewColumnFunction.SetAssignTo("columns")
    '    ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
    '    SettingBaseFunction()
    'End Sub

    Private Sub ucrReceiverElements_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRR.ControlContentsChanged, ucrReceiverTN.ControlValueChanged,
        ucrSaveNewDataFrame.ControlContentsChanged, ucrInputExportFile.ControlContentsChanged, ucrChkExportDataFrame.ControlContentsChanged, ucrReceiverTX.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        If ucrInputExportFile.IsEmpty() Then
            SelectFileToSave()
        End If
        'SettingBaseFunction()
    End Sub

    Private Sub SettingBaseFunction()
        cmdBrowse.Visible = False
        If ucrChkNewDataFrame.Checked And ucrChkExportDataFrame.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            ucrBase.clsRsyntax.ClearCodes()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
            ucrBase.clsRsyntax.AddToAfterCodes(clsExportClimpactFunction)
            cmdBrowse.Visible = True
        ElseIf ucrChkNewDataFrame.Checked AndAlso Not ucrChkExportDataFrame.Checked Then
            ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
            ucrBase.clsRsyntax.lstAfterCodes.Clear()
            cmdBrowse.Visible = False
        ElseIf ucrChkExportDataFrame.Checked AndAlso Not ucrChkNewDataFrame.Checked Then
            ucrBase.clsRsyntax.lstBeforeCodes.Clear()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
            ucrBase.clsRsyntax.SetBaseRFunction(clsExportClimpactFunction)
            ucrBase.clsRsyntax.lstAfterCodes.Clear()
            cmdBrowse.Visible = True
        End If
    End Sub
End Class