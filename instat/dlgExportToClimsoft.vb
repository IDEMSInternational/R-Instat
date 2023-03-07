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
    Private clsDataFrameFunction, clsCurrentNewColumnFunction, clsDummyFunction, clsMutateFunction, clsExportClimsoftFunction, clsExportCommentsFunction As New RFunction
    Private clsPipeOperator As New ROperator

    Private iBasicHeight As Integer
    Private iBaseMaxY As Integer
    Private iInputExp As Integer
    Private iucrDataFrame As Integer
    Private ichkAddReport As Integer
    Private iucrReceiverComment As Integer
    Private icmdBrowser As Integer
    Private ilblBrowser As Integer
    Private icomments As Integer

    Private Sub dlgExportToClimsoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iBasicHeight = Me.Height
            iBaseMaxY = ucrBase.Location.Y
            iInputExp = ucrInputExportFile.Location.Y
            iucrDataFrame = ucrDataFrameSheets.Location.Y
            ichkAddReport = ucrChkAddReport.Location.Y
            iucrReceiverComment = ucrReceiverComments.Location.Y
            icmdBrowser = cmdBrowse.Location.Y
            ilblBrowser = lblExport.Location.Y
            icomments = lblcomments.Location.Y
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

        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.Selector = ucrSelectorImportToClimsoft
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)

        ucrDataFrameSheets.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameSheets.SetParameterIsString()

        ucrReceiverComments.SetParameter(New RParameter("x", 1))
        ucrReceiverComments.SetParameterIsRFunction()
        ucrReceiverComments.SetItemType("dataframe")

        ucrReceiverComments.SetLinkedDisplayControl(lblcomments)

        ucrPnlPrepareData.AddRadioButton(rdoData)
        ucrPnlPrepareData.AddRadioButton(rdoStation)
        ucrPnlPrepareData.AddParameterValuesCondition(rdoData, "checked", "data")
        ucrPnlPrepareData.AddParameterValuesCondition(rdoStation, "checked", "station")

        ucrChkAddReport.SetText("Add Reports")
        ucrChkAddReport.AddToLinkedControls({ucrReceiverComments, ucrDataFrameSheets, ucrInputExportFile}, {True}, bNewLinkedHideIfParameterMissing:=True)
        'ucrChkAddReport.AddToLinkedControls({ucrReceiverElements, ucrReceiverDate, ucrSaveNewDataFrame, ucrChkExportDataFrame, ucrChkNewDataFrame, ucrReceiverStation, ucrInputHour, ucrInputLevel, ucrSelectorImportToClimsoft}, {False}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkAddReport.AddParameterValuesCondition(True, "comments", "True")
        ucrChkAddReport.AddParameterValuesCondition(False, "comments", "False")

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
        ucrChkExportDataFrame.AddToLinkedControls(ucrInputExportFile, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkExportDataFrame.AddParameterValuesCondition(True, "export", "True")
        ucrChkExportDataFrame.AddParameterValuesCondition(False, "export", "False")

        ucrChkSingleValue.SetText("Single Value")
        ucrChkSingleValue.AddToLinkedControls(ucrInputHour, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkSingleValue.AddParameterValuesCondition(True, "value", "True")
        ucrChkSingleValue.AddParameterValuesCondition(False, "value", "False")


        ucrSaveNewDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveNewDataFrame.SetIsTextBox()
        ucrSaveNewDataFrame.SetLabelText("Data Frame Name:")

        ucrInputExportFile.SetParameter(New RParameter("file", 1))
        ucrInputExportFile.IsReadOnly = True
        ucrInputExportFile.SetLinkedDisplayControl(lblExport)

        ucrPnlPrepareData.AddToLinkedControls({ucrReceiverComments, ucrReceiverElements, ucrInputExportFile,
                                              ucrInputHour, ucrInputLevel, ucrChkAddReport, ucrChkExportDataFrame,
                                              ucrChkNewDataFrame}, {rdoData}, bNewLinkedHideIfParameterMissing:=True)


    End Sub

    Private Sub SetDefaults()
        clsDataFrameFunction = New RFunction
        clsDummyFunction = New RFunction
        clsCurrentNewColumnFunction = New RFunction
        clsMutateFunction = New RFunction
        clsExportClimsoftFunction = New RFunction
        clsExportCommentsFunction = New RFunction
        clsPipeOperator = New ROperator

        ucrSelectorImportToClimsoft.Reset()
        ucrSaveNewDataFrame.Reset()
        ucrReceiverElements.SetMeAsReceiver()

        AddingComments()

        clsDummyFunction.AddParameter("dataframe", "True", iPosition:=0)
        clsDummyFunction.AddParameter("export", "False", iPosition:=1)
        clsDummyFunction.AddParameter("comments", "False", iPosition:=2)
        clsDummyFunction.AddParameter("checked", "data", iPosition:=3)
        clsDummyFunction.AddParameter("value", "True", iPosition:=4)


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

        clsExportCommentsFunction.SetPackageName("rio")
        clsExportCommentsFunction.SetRCommand("export")

        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)

        DataFrameAssignTo()

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputExportFile.AddAdditionalCodeParameterPair(clsExportCommentsFunction, New RParameter("file", 0), iAdditionalPairNo:=1)

        ucrReceiverDate.SetRCode(clsDataFrameFunction, bReset)
        ucrInputHour.SetRCode(clsDataFrameFunction, bReset)
        ucrInputLevel.SetRCode(clsDataFrameFunction, bReset)
        ucrSaveNewDataFrame.SetRCode(clsPipeOperator, bReset)
        ucrInputExportFile.SetRCode(clsExportClimsoftFunction, bReset)
        ucrPnlPrepareData.SetRCode(clsDummyFunction, bReset)
        If bReset Then
            ucrChkNewDataFrame.SetRCode(clsDummyFunction, bReset)
            ucrChkAddReport.SetRCode(clsDummyFunction, bReset)
            ucrChkSingleValue.SetRCode(clsDummyFunction, bReset)
            ucrReceiverComments.SetRCode(clsExportCommentsFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()

        If ucrChkNewDataFrame.Checked Then
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso Not ucrReceiverStation.IsEmpty AndAlso ucrSaveNewDataFrame.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf ucrChkExportDataFrame.Checked Then
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso Not ucrReceiverStation.IsEmpty AndAlso Not ucrInputExportFile.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf ucrChkAddReport.Checked Then
            If Not ucrReceiverComments.IsEmpty AndAlso Not ucrInputExportFile.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If

        If ucrChkNewDataFrame.Checked AndAlso ucrChkExportDataFrame.Checked Then
            If Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso Not ucrReceiverStation.IsEmpty AndAlso ucrSaveNewDataFrame.IsComplete AndAlso Not ucrInputExportFile.IsEmpty AndAlso ucrSaveNewDataFrame.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
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
        ucrBase.clsRsyntax.lstBeforeCodes.Clear()
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
            ucrBase.clsRsyntax.lstAfterCodes.Clear()
            cmdBrowse.Visible = False

        ElseIf ucrChkExportDataFrame.Checked AndAlso Not ucrChkNewDataFrame.Checked Then
            ucrBase.clsRsyntax.lstBeforeCodes.Clear()
            ucrBase.clsRsyntax.AddToBeforeCodes(clsCurrentNewColumnFunction)
            ucrBase.clsRsyntax.SetBaseRFunction(clsExportClimsoftFunction)
            ucrBase.clsRsyntax.lstAfterCodes.Clear()
            cmdBrowse.Visible = True
        ElseIf ucrChkAddReport.Checked Then
            ucrBase.clsRsyntax.ClearCodes()
            ucrBase.clsRsyntax.SetBaseRFunction(clsExportCommentsFunction)
            cmdBrowse.Visible = True
        End If
    End Sub

    Private Sub AddingComments()
        If ucrDataFrameSheets.cboAvailableDataFrames.Text = ".comment" Then
            ucrReceiverComments.SetText(ucrDataFrameSheets.cboAvailableDataFrames.Text)
        Else
            ucrReceiverComments.SetText("")
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
        'If ucrChkExportDataFrame.Checked AndAlso Not ucrInputExportFile.IsEmpty Then
        '    ucrChkAddReport.Enabled = True
        'ElseIf ucrChkNewDataFrame.Checked AndAlso ucrChkExportDataFrame.Checked AndAlso Not ucrInputExportFile.IsEmpty Then
        '    ucrChkAddReport.Enabled = True

        'Else
        '    ucrChkAddReport.Enabled = False

        'End If
        If ucrChkNewDataFrame.Checked Then
            If ucrChkExportDataFrame.Checked Then
                If ucrInputExportFile.IsEmpty Then
                    ucrChkAddReport.Enabled = True
                Else
                    ucrChkAddReport.Enabled = False
                End If
            End If
        Else
            ucrChkAddReport.Enabled = False
        End If
    End Sub

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged
        AddStationName()
    End Sub

    Private Sub ucrReceiverElements_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElements.ControlContentsChanged,
        ucrReceiverDate.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged, ucrInputLevel.ControlContentsChanged, ucrChkNewDataFrame.ControlContentsChanged,
        ucrInputHour.ControlContentsChanged, ucrInputExportFile.ControlContentsChanged, ucrChkExportDataFrame.ControlContentsChanged, ucrChkAddReport.ControlContentsChanged, ucrReceiverComments.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        If ucrInputExportFile.IsEmpty() Then
            SelectFileToSave()
        End If
        SettingBaseFunction()
        'EnableDisableComments()
    End Sub

    Private Sub ucrDataFrameSheets_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameSheets.ControlValueChanged
        AddingComments()
    End Sub

    Private Sub ucrReceiverComments_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverComments.ControlValueChanged
        clsExportCommentsFunction.AddParameter("x", clsRFunctionParameter:=ucrDataFrameSheets.clsCurrDataFrame, iPosition:=1)
    End Sub

    Private Sub ucrChkAddReport_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAddReport.ControlValueChanged
        AddingComments()
        'If ucrChkAddReport.Checked Then
        '    ucrChkExportDataFrame.Checked = False
        '    ucrChkNewDataFrame.Checked = False
        '    ucrInputExportFile.Visible = True

        'Else
        '    ucrChkExportDataFrame.Checked = False

        'End If
        SettingBaseFunction()
        EnableDisableComments()

    End Sub

    Private Sub ucrChkNewDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkNewDataFrame.ControlValueChanged
        SettingBaseFunction()
        EnableDisableComments()
    End Sub

    Private Sub ucrPnlPrepareData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPrepareData.ControlValueChanged
        SettingBaseFunction()
        AddingComments()
        EnableDisableComments()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        EnableDisableComments()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkExportDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExportDataFrame.ControlValueChanged
        EnableDisableComments()
        SettingBaseFunction()
    End Sub
End Class