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
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License

' along with this program. If not, see <http://www.gnu.org/licenses/>.


Imports instat.Translations
Imports System.IO
Imports RDotNet

Public Class dlgImportFromEPicsa
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bDBConnected As Boolean = False
    Private clsDummyFunction, clsGetDBConnectionFunction, clsDBWriteFunction, clsImportFromDatabaseFunction, clsImportDataFunction, clsLApplyFunction As New RFunction
    Private _sdgImportFromClimSoft As sdgImportFromClimSoft

    Private Sub dlgImportFromEPicsa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        CheckAndUpdateConnectionStatus()
        HideShowStationEntities()
        ChangeSizeAndLocation()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctCountry As New Dictionary(Of String, String)

        ucrPnlImportFromEPicsa.AddRadioButton(rdoStationMetadata)
        ucrPnlImportFromEPicsa.AddRadioButton(rdoSummaryData)
        ucrPnlImportFromEPicsa.AddRadioButton(rdoSummaryMetadata)
        ucrPnlImportFromEPicsa.AddParameterValuesCondition(rdoStationMetadata, "checked", "station_metadata")
        ucrPnlImportFromEPicsa.AddParameterValuesCondition(rdoSummaryData, "checked", "summary_data")
        ucrPnlImportFromEPicsa.AddParameterValuesCondition(rdoSummaryMetadata, "checked", "summary_metadata")
        ucrPnlImportFromEPicsa.AddToLinkedControls(
            {ucrChkDefinitionsData, ucrChkSummaryData, ucrChkCropData, ucrChkLatestData, ucrInputDefinitionsID},
            {rdoSummaryData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True
        )

        ucrChkDefinitionsData.SetText("Definition Data")
        ucrChkDefinitionsData.SetParameter(New RParameter("definition_data", 2))
        ucrChkDefinitionsData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkSummaryData.SetText("Summary Data")
        ucrChkSummaryData.SetParameter(New RParameter("summary_data", 4))
        ucrChkSummaryData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkCropData.SetText("Crop Data")
        ucrChkCropData.SetParameter(New RParameter("crop_data", 5))
        ucrChkCropData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkSpecifyStations.SetText("Specify Station(s)")
        ucrChkSpecifyStations.AddParameterValuesCondition(True, "specify_stations", "True")
        ucrChkSpecifyStations.AddParameterValuesCondition(False, "specify_stations", "False")

        ucrChkLatestData.SetText("Latest Data")
        ucrChkLatestData.AddParameterValuesCondition(True, "latest", "True")
        ucrChkLatestData.AddParameterValuesCondition(False, "latest", "False")
        ucrChkLatestData.AddToLinkedControls(ucrInputDefinitionsID, {False}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrInputDefinitionsID.SetParameter(New RParameter("definitions_id", 8))

        ucrSelectorImportFromEPICSA.SetParameter(New RParameter("data", 0))
        ucrSelectorImportFromEPICSA.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("fill", iNewPosition:=0))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetDataType("factor")
        ucrReceiverStation.strSelectorHeading = "Factors"
        ucrReceiverStation.Selector = ucrSelectorImportFromEPICSA
        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrReceiverStation.bWithQuotes = False

        ucrStationFactorLevels.SetAsMultipleSelectorGrid(ucrReceiverStation,
                                                  hiddenColNames:={ucrFactor.DefaultColumnNames.Level},
                                                  bIncludeNALevel:=True)
    End Sub

    Private Sub SetDefaults()
        clsDummyFunction = New RFunction
        clsGetDBConnectionFunction = New RFunction
        clsDBWriteFunction = New RFunction
        clsImportFromDatabaseFunction = New RFunction
        clsImportDataFunction = New RFunction
        clsLApplyFunction = New RFunction

        clsDummyFunction.AddParameter("checked", "station_metadata", iPosition:=0)
        clsDummyFunction.AddParameter("specify_stations", "False", iPosition:=1)
        clsDummyFunction.AddParameter("latest", "True", iPosition:=2)

        clsGetDBConnectionFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_database_connection")
        clsGetDBConnectionFunction.SetAssignTo("con")

        clsDBWriteFunction.SetRCommand("library")
        clsDBWriteFunction.AddParameter("x", "DBI", iPosition:=0, bIncludeArgumentName:=False)

        clsImportFromDatabaseFunction.SetPackageName("epicsawrap")
        clsImportFromDatabaseFunction.SetRCommand("import_from_database")
        clsImportFromDatabaseFunction.AddParameter("con", "con", iPosition:=0)
        clsImportFromDatabaseFunction.SetAssignTo("imported_data_list")

        clsLApplyFunction.SetRCommand("lapply")
        clsLApplyFunction.AddParameter("X", "imported_data_list", iPosition:=0)
        clsLApplyFunction.AddParameter("FUN", "data.frame", iPosition:=1)

        clsImportDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")
        clsImportDataFunction.AddParameter("data_tables", clsRFunctionParameter:=clsImportFromDatabaseFunction, iPosition:=0)

        ucrBase.clsRsyntax.AddToBeforeCodes(clsDBWriteFunction, iPosition:=0)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDBConnectionFunction, iPosition:=1)
        ucrBase.clsRsyntax.SetBaseRFunction(clsImportDataFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        If bReset Then
            ucrPnlImportFromEPicsa.SetRCode(clsDummyFunction, bReset)
            ucrChkDefinitionsData.SetRCode(clsImportFromDatabaseFunction, bReset)
            ucrChkSummaryData.SetRCode(clsImportFromDatabaseFunction, bReset)
            ucrChkCropData.SetRCode(clsImportFromDatabaseFunction, bReset)
            ucrChkSpecifyStations.SetRCode(clsDummyFunction, bReset)
            ucrChkLatestData.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled = True
        If rdoSummaryData.Checked Then
            If Not ucrChkCropData.Checked AndAlso Not ucrChkDefinitionsData.Checked AndAlso Not ucrChkSummaryData.Checked Then
                bOkEnabled = False
            End If
        End If

        If ucrChkSpecifyStations.Checked Then
            If ucrReceiverStation.IsEmpty OrElse (Not ucrReceiverStation.IsEmpty AndAlso Not ucrStationFactorLevels.IsAnyGridRowSelected()) Then
                bOkEnabled = False
            End If
        End If

        If Not bDBConnected Then
            bOkEnabled = False
        End If

        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlImportFromEPicsa.ControlContentsChanged, ucrChkCropData.ControlContentsChanged, ucrChkDefinitionsData.ControlContentsChanged,
            ucrChkLatestData.ControlContentsChanged, ucrChkSpecifyStations.ControlContentsChanged, ucrChkSummaryData.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrSelectorImportFromEPICSA.ControlContentsChanged,
            ucrStationFactorLevels.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        If _sdgImportFromClimSoft IsNot Nothing Then
            _sdgImportFromClimSoft.Reset()
        End If
        CheckAndUpdateConnectionStatus()
    End Sub


    Private Sub ucrPnlImportFromEPicsa_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlImportFromEPicsa.ControlValueChanged
        clsImportFromDatabaseFunction.RemoveParameterByName("station_metadata")
        clsImportFromDatabaseFunction.RemoveParameterByName("summary_station_metadata")

        If rdoStationMetadata.Checked Then
            clsImportFromDatabaseFunction.AddParameter("station_metadata", "TRUE", iPosition:=1)
        ElseIf rdoSummaryMetadata.Checked Then
            clsImportFromDatabaseFunction.AddParameter("summary_station_metadata", "TRUE", iPosition:=3)
        End If

        HideShowDefinitionInputBox()
        AddRemoveDefinitionID()
        HideShowStationEntities()
        ChangeSizeAndLocation()
    End Sub

    Private Sub AddRemoveStationIDs()
        If ucrChkSpecifyStations.Checked Then
            clsImportFromDatabaseFunction.AddParameter("station_id", mdlCoreControl.GetRVector(ucrStationFactorLevels.GetSelectedCellValues(ucrFactor.DefaultColumnNames.Label, True)), iPosition:=6)
        Else
            clsImportFromDatabaseFunction.AddParameter("station_id", "NULL", iPosition:=6)
        End If
    End Sub

    Private Sub ucrChkSpecifyStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSpecifyStations.ControlValueChanged
        AddRemoveStationIDs()
        HideShowStationEntities()
        ChangeSizeAndLocation()
    End Sub

    Private Sub ucrStationFactorLevels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrStationFactorLevels.ControlValueChanged
        AddRemoveStationIDs()
    End Sub

    Private Sub AddRemoveDefinitionID()
        clsImportFromDatabaseFunction.RemoveParameterByName("latest")
        clsImportFromDatabaseFunction.RemoveParameterByName("definition_id")

        If rdoSummaryData.Checked Then
            If ucrChkLatestData.Checked Then
                clsImportFromDatabaseFunction.AddParameter("latest", "TRUE", iPosition:=7)
            Else
                clsImportFromDatabaseFunction.AddParameter("latest", "FALSE", iPosition:=7)
                If Not ucrInputDefinitionsID.IsEmpty Then
                    clsImportFromDatabaseFunction.AddParameter("definition_id", Chr(34) & ucrInputDefinitionsID.GetText() & Chr(34), iPosition:=8)
                End If
            End If
        End If
    End Sub

    Private Sub ucrChkLatestData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLatestData.ControlValueChanged
        AddRemoveDefinitionID()
        HideShowDefinitionInputBox()
    End Sub

    Private Sub ucrInputDefinitionsID_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDefinitionsID.ControlValueChanged
        AddRemoveDefinitionID()
    End Sub

    Private Sub HideShowDefinitionInputBox()
        If rdoSummaryData.Checked Then
            ucrInputDefinitionsID.Visible = Not ucrChkLatestData.Checked
        End If
    End Sub

    Private Sub HideShowStationEntities()
        If ucrChkSpecifyStations.Checked Then
            ucrSelectorImportFromEPICSA.Visible = True
            ucrReceiverStation.Visible = True
            ucrStationFactorLevels.Visible = True
        Else
            ucrSelectorImportFromEPICSA.Visible = False
            ucrReceiverStation.Visible = False
            ucrStationFactorLevels.Visible = False
        End If
    End Sub

    Private Sub btnConnection_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        If _sdgImportFromClimSoft Is Nothing Then
            _sdgImportFromClimSoft = New sdgImportFromClimSoft
            AddHandler _sdgImportFromClimSoft.Shown, AddressOf SetEPicsaSubDialogDefaults
        End If

        _sdgImportFromClimSoft.ShowDialog()

        CheckAndUpdateConnectionStatus()
        TestOkEnabled()
    End Sub

    Private Sub SetEPicsaSubDialogDefaults(sender As Object, e As EventArgs)
        Dim dlg As sdgImportFromClimSoft = DirectCast(sender, sdgImportFromClimSoft)
        dlg.ucrComboBoxDatabaseName.SetText("epicsa")
        dlg.ucrInputDrv.SetText("RPostgres::Postgres()")
        dlg.ucrTxtHost.SetText("db.epicsa.idems.international")
        dlg.ucrComboBoxPort.SetText("5432")

        dlg.ucrTxtHost.OnControlValueChanged()
        dlg.ucrComboBoxDatabaseName.OnControlValueChanged()

        dlg.chkRememberCredentials.Checked = False
    End Sub

    Private Sub CheckAndUpdateConnectionStatus()
        If _sdgImportFromClimSoft IsNot Nothing Then
            If _sdgImportFromClimSoft.IsConnectionIsActive() Then
                bDBConnected = True
                lblConnection.Text = "Connected"
                lblConnection.ForeColor = Color.Green
            Else
                bDBConnected = False
                lblConnection.Text = "No Connection"
                lblConnection.ForeColor = Color.Red
            End If
        End If
    End Sub

    Private Sub ChangeSizeAndLocation()
        ucrStationFactorLevels.grdFactorData.Size = New Size(200, 130)

        If rdoStationMetadata.Checked OrElse rdoSummaryMetadata.Checked Then
            Me.Size = New Size(515, 450)
            ucrChkSpecifyStations.Location = New Point(17, 100)
            ucrBase.Location = New Point(20, 350)
            ucrChkLatestData.Location = New Point(17, 320)
            ucrInputDefinitionsID.Location = New Point(190, 320)
            ucrSelectorImportFromEPICSA.Location = New Point(17, 130)
            lblStation.Location = New Point(270, 130)
            ucrReceiverStation.Location = New Point(270, 150)
            ucrStationFactorLevels.Location = New Point(270, 190)
        Else
            ucrChkSpecifyStations.Location = New Point(17, 185)
            If ucrChkSpecifyStations.Checked Then
                Me.Size = New Size(515, 550)
                ucrBase.Location = New Point(17, 450)
                ucrChkLatestData.Location = New Point(17, 420)
                ucrInputDefinitionsID.Location = New Point(190, 420)
                ucrSelectorImportFromEPICSA.Location = New Point(17, 220)
                lblStation.Location = New Point(270, 220)
                ucrReceiverStation.Location = New Point(270, 240)
                ucrStationFactorLevels.Location = New Point(270, 280)
            Else
                Me.Size = New Size(515, 450)
                ucrBase.Location = New Point(17, 350)
                ucrChkLatestData.Location = New Point(17, 320)
                ucrInputDefinitionsID.Location = New Point(190, 320)
                ucrSelectorImportFromEPICSA.Location = New Point(17, 130)
                lblStation.Location = New Point(270, 130)
                ucrReceiverStation.Location = New Point(270, 150)
                ucrStationFactorLevels.Location = New Point(270, 190)
            End If
        End If
    End Sub

End Class