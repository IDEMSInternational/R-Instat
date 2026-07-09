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

Imports System.Diagnostics
Imports instat.Translations
Public Class dlgExportClimaticDefinitions
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bDBConnected As Boolean = False
    Private dctReceiverMap As New Dictionary(Of ucrReceiver, ucrReceiverSingle)
    Private dctCurrentMultipleReceiverSnapshot As New Dictionary(Of ucrReceiver, List(Of KeyValuePair(Of String, String)))
    Private clsBuildSummaryLongAnnualRainFunction, clsBuildSummaryLongMonthlyRainFunction, clsBuildSummaryLongAnnualTempFunction,
            clsBuildSummaryLongMonthlyTempFunction, clsBuildSummaryLongAnnualMonthlyTempFunction, clsCollateSummaryDefinitionsFunction,
            clsBuildCropLongerFunction, clsExportToDBFunction As New RFunction
    Private clsSummaryDataOperator, clsDefinitionDataOperator, clsSummaryStationMetadataOperator, clsCropDataOperator As ROperator
    Private clsDummyFunction, clsCollateStationMetadataFunction, clsDBWriteFunction, clsGetDBConnectionFunction As RFunction
    Private _sdgImportFromClimSoft As sdgImportFromClimSoft
    Private strCurrentEPicsaDataframe As String = ""

    Private Enum SummaryDataSelectorMode
        Dataframes
        Objects
    End Enum

    Private CurrentSummaryDataSelectorMode As SummaryDataSelectorMode

    Private Sub dlgExportClimaticDefinitions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        SetSummaryDataDefaultSelector()
        SetDialogSize()
        CheckAndUpdateConnectionStatus()
        HideDisplayGroupedControls()
        RestoreMultipleReceiversIfStripped()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2

        ucrPnlExportToEPicsa.AddRadioButton(rdoSummaryData)
        ucrPnlExportToEPicsa.AddRadioButton(rdoStationMetadata)
        ucrPnlExportToEPicsa.AddParameterValuesCondition(rdoSummaryData, "checked", "summary_data")
        ucrPnlExportToEPicsa.AddParameterValuesCondition(rdoStationMetadata, "checked", "station_metadata")

        ucrPnlExportToEPicsa.AddToLinkedControls(
            {
                ucrSelectorDataFramesExportToEPicsa, ucrReceiverAnnualRainfallSummaries, ucrReceiverMonthlyRainfallSummaries, ucrReceiverAnnualTempSummaries,
                ucrReceiverMonthlyTempSummaries, ucrReceiverAnnualMonthlyTempSummaries, ucrReceiverCropSummaries, ucrReceiverPropSummaries, ucrReceiverMultipleAnnualRainfall,
                ucrReceiverMultipleAnnualTemp, ucrReceiverMultipleMonthlyRainfall, ucrReceiverMultipleMonthlyTemp, ucrReceiverMultipleAnnualMonthlyTemp, ucrReceiverCropDefinition,
                ucrReceiverPropDefinition
            },
            {rdoSummaryData}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True
        )
        ucrPnlExportToEPicsa.AddToLinkedControls(
            {
                ucrSelectorStationMetadata, ucrReceiverStationID, ucrReceiverStationName, ucrReceiverLongitude, ucrReceiverLatitude, ucrReceiverElevation, ucrReceiverDistrict, ucrReceiverCountryCode
            },
            {rdoStationMetadata}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True
        )

        ucrSelectorExportToEPicsa.Visible = False

        ' Selectors
        ucrSelectorExportToEPicsa.SetParameter(New RParameter("data_name", 0))
        ucrSelectorExportToEPicsa.SetParameterIsString()
        ucrSelectorExportToEPicsa.Visible = False

        ucrSelectorDataFramesExportToEPicsa.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDataFramesExportToEPicsa.SetLinkedDisplayControl(lblDataframes)
        ucrSelectorDataFramesExportToEPicsa.Visible = True

        ucrSelectorStationMetadata.SetParameter(New RParameter("data", 0))
        ucrSelectorStationMetadata.SetParameterIsrfunction()
        ucrSelectorStationMetadata.Visible = False


        ' Station Metadata Receivers
        ucrReceiverStationID.SetParameter(New RParameter("station_id", 1))
        ucrReceiverStationID.Selector = ucrSelectorStationMetadata
        ucrReceiverStationID.SetParameterIsString()
        ucrReceiverStationID.SetMeAsReceiver()
        ucrReceiverStationID.strSelectorHeading = "Variables"
        ucrReceiverStationID.SetLinkedDisplayControl(lblStationID)

        ucrReceiverStationName.SetParameter(New RParameter("station_name", 2))
        ucrReceiverStationName.Selector = ucrSelectorStationMetadata
        ucrReceiverStationName.SetParameterIsString()
        ucrReceiverStationName.strSelectorHeading = "Variables"
        ucrReceiverStationName.SetLinkedDisplayControl(lblStationName)

        ucrReceiverLongitude.SetParameter(New RParameter("longitude", 3))
        ucrReceiverLongitude.Selector = ucrSelectorStationMetadata
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.strSelectorHeading = "Variables"
        ucrReceiverLongitude.SetLinkedDisplayControl(lblLongitude)

        ucrReceiverLatitude.SetParameter(New RParameter("latitude", 4))
        ucrReceiverLatitude.Selector = ucrSelectorStationMetadata
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.strSelectorHeading = "Variables"
        ucrReceiverLatitude.SetLinkedDisplayControl(lblLatitiude)

        ucrReceiverElevation.SetParameter(New RParameter("elevation", 5))
        ucrReceiverElevation.Selector = ucrSelectorStationMetadata
        ucrReceiverElevation.SetParameterIsString()
        ucrReceiverElevation.strSelectorHeading = "Variables"
        ucrReceiverElevation.SetLinkedDisplayControl(lblElevation)

        ucrReceiverDistrict.SetParameter(New RParameter("district", 6))
        ucrReceiverDistrict.Selector = ucrSelectorStationMetadata
        ucrReceiverDistrict.SetParameterIsString()
        ucrReceiverDistrict.strSelectorHeading = "Variables"
        ucrReceiverDistrict.SetLinkedDisplayControl(lblDistrict)

        ucrReceiverCountryCode.SetParameter(New RParameter("country_code", 7))
        ucrReceiverCountryCode.Selector = ucrSelectorStationMetadata
        ucrReceiverCountryCode.SetParameterIsString()
        ucrReceiverCountryCode.strSelectorHeading = "Variables"
        ucrReceiverCountryCode.SetLinkedDisplayControl(lblCountryCode)


        ' Summary Data Main Receivers
        ucrReceiverAnnualRainfallSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverAnnualRainfallSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverAnnualRainfallSummaries.SetParameterIsString()
        ucrReceiverAnnualRainfallSummaries.SetMeAsReceiver()
        ucrReceiverAnnualRainfallSummaries.SetItemType("dataframe")
        ucrReceiverAnnualRainfallSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverAnnualRainfallSummaries.SetLinkedDisplayControl(lblAnnualRainfallSummaries)

        ucrReceiverMonthlyRainfallSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverMonthlyRainfallSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverMonthlyRainfallSummaries.SetParameterIsString()
        ucrReceiverMonthlyRainfallSummaries.SetItemType("dataframe")
        ucrReceiverMonthlyRainfallSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverMonthlyRainfallSummaries.SetLinkedDisplayControl(lblMonthlyRainfallSummaries)

        ucrReceiverAnnualTempSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverAnnualTempSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverAnnualTempSummaries.SetParameterIsString()
        ucrReceiverAnnualTempSummaries.SetItemType("dataframe")
        ucrReceiverAnnualTempSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverAnnualTempSummaries.SetLinkedDisplayControl(lblAnnualTempSummaries)

        ucrReceiverMonthlyTempSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverMonthlyTempSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverMonthlyTempSummaries.SetParameterIsString()
        ucrReceiverMonthlyTempSummaries.SetItemType("dataframe")
        ucrReceiverMonthlyTempSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverMonthlyTempSummaries.SetLinkedDisplayControl(lblMonthlyTempSummaries)

        ucrReceiverAnnualMonthlyTempSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverAnnualMonthlyTempSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverAnnualMonthlyTempSummaries.SetParameterIsString()
        ucrReceiverAnnualMonthlyTempSummaries.SetItemType("dataframe")
        ucrReceiverAnnualMonthlyTempSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverAnnualMonthlyTempSummaries.SetLinkedDisplayControl(lblAnnualMonthlyTempSummaries)

        ucrReceiverCropSummaries.SetParameter(New RParameter("crop_data_name", 0))
        ucrReceiverCropSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverCropSummaries.SetParameterIsString()
        ucrReceiverCropSummaries.SetItemType("dataframe")
        ucrReceiverCropSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverCropSummaries.SetLinkedDisplayControl(lblCropSummaries)

        ucrReceiverPropSummaries.SetParameter(New RParameter("prop_data_name", 1))
        ucrReceiverPropSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverPropSummaries.SetParameterIsString()
        ucrReceiverPropSummaries.SetItemType("dataframe")
        ucrReceiverPropSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverPropSummaries.SetLinkedDisplayControl(lblPropSummaries)

        ' Annual Rainfall Products
        ucrReceiverMultipleAnnualRainfall.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleAnnualRainfall.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleAnnualRainfall.SetParameterIsString()
        ucrReceiverMultipleAnnualRainfall.strSelectorHeading = "Objects"
        ucrReceiverMultipleAnnualRainfall.SetItemType("object")
        ucrReceiverMultipleAnnualRainfall.SetLinkedDisplayControl(lblAnnualRainfall)

        ' Annual Temperature Products
        ucrReceiverMultipleAnnualTemp.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleAnnualTemp.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleAnnualTemp.SetParameterIsString()
        ucrReceiverMultipleAnnualTemp.strSelectorHeading = "Objects"
        ucrReceiverMultipleAnnualTemp.SetItemType("object")
        ucrReceiverMultipleAnnualTemp.SetLinkedDisplayControl(lblAnnualTemp)

        ' Monthly Rainfall Products
        ucrReceiverMultipleMonthlyRainfall.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleMonthlyRainfall.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleMonthlyRainfall.SetParameterIsString()
        ucrReceiverMultipleMonthlyRainfall.strSelectorHeading = "Objects"
        ucrReceiverMultipleMonthlyRainfall.SetItemType("object")
        ucrReceiverMultipleMonthlyRainfall.SetLinkedDisplayControl(lblMonthlyRainfall)

        ' Monthly Temperature Products
        ucrReceiverMultipleMonthlyTemp.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleMonthlyTemp.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleMonthlyTemp.SetParameterIsString()
        ucrReceiverMultipleMonthlyTemp.strSelectorHeading = "Objects"
        ucrReceiverMultipleMonthlyTemp.SetItemType("object")
        ucrReceiverMultipleMonthlyTemp.SetLinkedDisplayControl(lblMonthlyTemp)

        ' Annual-Monthly Temperature Products
        ucrReceiverMultipleAnnualMonthlyTemp.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleAnnualMonthlyTemp.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleAnnualMonthlyTemp.SetParameterIsString()
        ucrReceiverMultipleAnnualMonthlyTemp.strSelectorHeading = "Objects"
        ucrReceiverMultipleAnnualMonthlyTemp.SetItemType("object")
        ucrReceiverMultipleAnnualMonthlyTemp.SetLinkedDisplayControl(lblAnnualMonthlyTemp)

        ' Crop Definition
        ucrReceiverCropDefinition.SetParameter(New RParameter("crop_definition", 2))
        ucrReceiverCropDefinition.Selector = ucrSelectorExportToEPicsa
        ucrReceiverCropDefinition.SetParameterIsString()
        ucrReceiverCropDefinition.strSelectorHeading = "Objects"
        ucrReceiverCropDefinition.SetItemType("object")
        ucrReceiverCropDefinition.SetLinkedDisplayControl(lblCropDefinition)

        ' Prop Definition
        ucrReceiverPropDefinition.SetParameter(New RParameter("prop_definition", 3))
        ucrReceiverPropDefinition.Selector = ucrSelectorExportToEPicsa
        ucrReceiverPropDefinition.SetParameterIsString()
        ucrReceiverPropDefinition.strSelectorHeading = "Objects"
        ucrReceiverPropDefinition.SetItemType("object")
        ucrReceiverPropDefinition.SetLinkedDisplayControl(lblPropDefinition)

        ' Dictionary mapping receivers in the groupbox (single/multiple) to their corresponding main receivers
        dctReceiverMap.Add(ucrReceiverMultipleAnnualRainfall, ucrReceiverAnnualRainfallSummaries)
        dctReceiverMap.Add(ucrReceiverMultipleMonthlyRainfall, ucrReceiverMonthlyRainfallSummaries)
        dctReceiverMap.Add(ucrReceiverMultipleAnnualTemp, ucrReceiverAnnualTempSummaries)
        dctReceiverMap.Add(ucrReceiverMultipleMonthlyTemp, ucrReceiverMonthlyTempSummaries)
        dctReceiverMap.Add(ucrReceiverMultipleAnnualMonthlyTemp, ucrReceiverAnnualMonthlyTempSummaries)
        dctReceiverMap.Add(ucrReceiverCropDefinition, ucrReceiverCropSummaries)
        dctReceiverMap.Add(ucrReceiverPropDefinition, ucrReceiverPropSummaries)

        HideDisplayGroupedControls()
    End Sub

    Private Sub SetDefaults()
        clsBuildSummaryLongAnnualRainFunction = New RFunction
        clsBuildSummaryLongMonthlyRainFunction = New RFunction
        clsBuildSummaryLongAnnualTempFunction = New RFunction
        clsBuildSummaryLongMonthlyTempFunction = New RFunction
        clsBuildSummaryLongAnnualMonthlyTempFunction = New RFunction
        clsBuildCropLongerFunction = New RFunction
        clsExportToDBFunction = New RFunction
        clsDummyFunction = New RFunction
        clsCollateStationMetadataFunction = New RFunction
        clsDBWriteFunction = New RFunction
        clsGetDBConnectionFunction = New RFunction

        clsSummaryDataOperator = New ROperator
        clsDefinitionDataOperator = New ROperator
        clsSummaryStationMetadataOperator = New ROperator
        clsCropDataOperator = New ROperator

        Dim strSummaryDef = "summary_def"

        clsDummyFunction.AddParameter("checked", "summary_data", iPosition:=0)

        ucrSelectorExportToEPicsa.Reset()
        ucrSelectorDataFramesExportToEPicsa.Reset()
        ucrSelectorStationMetadata.Reset()

        strCurrentEPicsaDataframe = ""

        clsBuildSummaryLongAnnualRainFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongAnnualRainFunction.AddParameter("time_type", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsBuildSummaryLongAnnualRainFunction.AddParameter("summary_type", Chr(34) & "Rain" & Chr(34), iPosition:=2)
        clsBuildSummaryLongAnnualRainFunction.SetAssignTo("annual_rain_longer")

        clsBuildSummaryLongMonthlyRainFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongMonthlyRainFunction.AddParameter("time_type", Chr(34) & "monthly" & Chr(34), iPosition:=1)
        clsBuildSummaryLongMonthlyRainFunction.AddParameter("summary_type", Chr(34) & "Rain" & Chr(34), iPosition:=2)
        clsBuildSummaryLongMonthlyRainFunction.SetAssignTo("monthly_rain_longer")

        clsBuildSummaryLongAnnualTempFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongAnnualTempFunction.AddParameter("time_type", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsBuildSummaryLongAnnualTempFunction.AddParameter("summary_type", Chr(34) & "Temperature" & Chr(34), iPosition:=2)
        clsBuildSummaryLongAnnualTempFunction.SetAssignTo("annual_temp_longer")

        clsBuildSummaryLongMonthlyTempFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongMonthlyTempFunction.AddParameter("time_type", Chr(34) & "monthly" & Chr(34), iPosition:=1)
        clsBuildSummaryLongMonthlyTempFunction.AddParameter("summary_type", Chr(34) & "Temperature" & Chr(34), iPosition:=2)
        clsBuildSummaryLongMonthlyTempFunction.SetAssignTo("monthly_temp_longer")

        clsBuildSummaryLongAnnualMonthlyTempFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongAnnualMonthlyTempFunction.AddParameter("time_type", Chr(34) & "annual-monthly" & Chr(34), iPosition:=1)
        clsBuildSummaryLongAnnualMonthlyTempFunction.AddParameter("summary_type", Chr(34) & "Temperature" & Chr(34), iPosition:=2)
        clsBuildSummaryLongAnnualMonthlyTempFunction.SetAssignTo("annual_monthly_temp_longer")

        clsBuildCropLongerFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_crop_longer")
        clsBuildCropLongerFunction.SetAssignTo("crop_summary_longer")

        clsCollateSummaryDefinitionsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$collate_summary_definitions")
        clsCollateSummaryDefinitionsFunction.SetAssignTo(strSummaryDef)

        clsSummaryDataOperator.SetOperation("$")
        clsSummaryDataOperator.AddParameter("x", clsRFunctionParameter:=clsCollateSummaryDefinitionsFunction, iPosition:=0, bIncludeArgumentName:=False)
        clsSummaryDataOperator.AddParameter("y", "summary", iPosition:=1, bIncludeArgumentName:=False)
        clsSummaryDataOperator.bAllBrackets = False
        clsSummaryDataOperator.bSpaceAroundOperation = False

        clsDefinitionDataOperator.SetOperation("$")
        clsDefinitionDataOperator.AddParameter("x", strSummaryDef, iPosition:=0, bIncludeArgumentName:=False)
        clsDefinitionDataOperator.AddParameter("y", "definition", iPosition:=1, bIncludeArgumentName:=False)
        clsDefinitionDataOperator.bAllBrackets = False
        clsDefinitionDataOperator.bSpaceAroundOperation = False

        clsSummaryStationMetadataOperator.SetOperation("$")
        clsSummaryStationMetadataOperator.AddParameter("x", strSummaryDef, iPosition:=0, bIncludeArgumentName:=False)
        clsSummaryStationMetadataOperator.AddParameter("y", "summary_station_metadata", iPosition:=1, bIncludeArgumentName:=False)
        clsSummaryStationMetadataOperator.bAllBrackets = False
        clsSummaryStationMetadataOperator.bSpaceAroundOperation = False

        clsCropDataOperator.SetOperation("$")
        clsCropDataOperator.AddParameter("x", strSummaryDef, iPosition:=0, bIncludeArgumentName:=False)
        clsCropDataOperator.AddParameter("y", "crop", iPosition:=1, bIncludeArgumentName:=False)
        clsCropDataOperator.bAllBrackets = False
        clsCropDataOperator.bSpaceAroundOperation = False

        clsExportToDBFunction.SetPackageName("epicsawrap")
        clsExportToDBFunction.SetRCommand("export_to_database")
        clsExportToDBFunction.AddParameter("con", "con", iPosition:=0, bIncludeArgumentName:=False)

        clsCollateStationMetadataFunction.SetPackageName("epicsawrap")
        clsCollateStationMetadataFunction.SetRCommand("collate_station_metadata")
        clsCollateStationMetadataFunction.SetAssignTo("collate_station_metadata")

        clsDBWriteFunction.SetRCommand("library")
        clsDBWriteFunction.AddParameter("x", "DBI", iPosition:=0, bIncludeArgumentName:=False)

        clsGetDBConnectionFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_database_connection")
        clsGetDBConnectionFunction.SetAssignTo("con")

        HideDisplayGroupedControls()
        AddRemoveParamsInSummaryDefinitionsFunction()
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDBWriteFunction, iPosition:=0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsExportToDBFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverAnnualRainfallSummaries.SetRCode(clsBuildSummaryLongAnnualRainFunction, bReset)
        ucrReceiverMonthlyRainfallSummaries.SetRCode(clsBuildSummaryLongMonthlyRainFunction, bReset)
        ucrReceiverAnnualTempSummaries.SetRCode(clsBuildSummaryLongAnnualTempFunction, bReset)
        ucrReceiverMonthlyTempSummaries.SetRCode(clsBuildSummaryLongMonthlyTempFunction, bReset)
        ucrReceiverAnnualMonthlyTempSummaries.SetRCode(clsBuildSummaryLongAnnualMonthlyTempFunction, bReset)
        ucrReceiverCropSummaries.SetRCode(clsBuildCropLongerFunction, bReset)
        ucrReceiverPropSummaries.SetRCode(clsBuildCropLongerFunction, bReset)

        ' Sync the shared object selector's dataframe to THIS receiver's dataframe to prevent clearing of receivers on dataframe change
        SyncEPicsaDataframeThenSetRCode(ucrReceiverMultipleAnnualRainfall, clsBuildSummaryLongAnnualRainFunction, bReset)
        SyncEPicsaDataframeThenSetRCode(ucrReceiverMultipleAnnualTemp, clsBuildSummaryLongAnnualTempFunction, bReset)
        SyncEPicsaDataframeThenSetRCode(ucrReceiverMultipleMonthlyRainfall, clsBuildSummaryLongMonthlyRainFunction, bReset)
        SyncEPicsaDataframeThenSetRCode(ucrReceiverMultipleMonthlyTemp, clsBuildSummaryLongMonthlyTempFunction, bReset)
        SyncEPicsaDataframeThenSetRCode(ucrReceiverMultipleAnnualMonthlyTemp, clsBuildSummaryLongAnnualMonthlyTempFunction, bReset)
        SyncEPicsaDataframeThenSetRCode(ucrReceiverCropDefinition, clsBuildCropLongerFunction, bReset)
        SyncEPicsaDataframeThenSetRCode(ucrReceiverPropDefinition, clsBuildCropLongerFunction, bReset)

        ucrPnlExportToEPicsa.SetRCode(clsDummyFunction)

        ' Station Metadata
        ucrSelectorStationMetadata.SetRCode(clsCollateStationMetadataFunction, bReset)
        ucrReceiverStationID.SetRCode(clsCollateStationMetadataFunction, bReset)
        ucrReceiverStationName.SetRCode(clsCollateStationMetadataFunction, bReset)
        ucrReceiverLongitude.SetRCode(clsCollateStationMetadataFunction, bReset)
        ucrReceiverLatitude.SetRCode(clsCollateStationMetadataFunction, bReset)
        ucrReceiverElevation.SetRCode(clsCollateStationMetadataFunction, bReset)
        ucrReceiverDistrict.SetRCode(clsCollateStationMetadataFunction, bReset)
        ucrReceiverCountryCode.SetRCode(clsCollateStationMetadataFunction, bReset)
    End Sub

    Private Sub SyncEPicsaDataframeThenSetRCode(ucrReceiverMulti As ucrReceiver, clsFunction As RFunction, bReset As Boolean)
        Dim ucrReceiverDataframe As ucrReceiverSingle = Nothing

        If dctReceiverMap.TryGetValue(ucrReceiverMulti, ucrReceiverDataframe) AndAlso Not ucrReceiverDataframe.IsEmpty() Then
            Dim strDataframe As String = ucrReceiverDataframe.GetVariableNames(bWithQuotes:=False)
            If strDataframe <> strCurrentEPicsaDataframe Then
                ucrSelectorExportToEPicsa.SetDataframe(strDataframe, bEnableDataframe:=False, bSilent:=True)
                strCurrentEPicsaDataframe = strDataframe
            End If
        End If
        ucrReceiverMulti.SetRCode(clsFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnable As Boolean = True
        If rdoSummaryData.Checked Then
            If ucrReceiverAnnualRainfallSummaries.IsEmpty AndAlso ucrReceiverAnnualTempSummaries.IsEmpty AndAlso
                ucrReceiverMonthlyRainfallSummaries.IsEmpty AndAlso ucrReceiverMonthlyTempSummaries.IsEmpty AndAlso
                ucrReceiverAnnualMonthlyTempSummaries.IsEmpty AndAlso ucrReceiverPropSummaries.IsEmpty AndAlso
                ucrReceiverCropSummaries.IsEmpty Then
                bOkEnable = False
            Else
                If Not ucrReceiverAnnualRainfallSummaries.IsEmpty AndAlso ucrReceiverMultipleAnnualRainfall.IsEmpty Then
                    bOkEnable = False
                End If

                If Not ucrReceiverAnnualTempSummaries.IsEmpty AndAlso ucrReceiverMultipleAnnualTemp.IsEmpty Then
                    bOkEnable = False
                End If

                If Not ucrReceiverMonthlyRainfallSummaries.IsEmpty AndAlso ucrReceiverMultipleMonthlyRainfall.IsEmpty Then
                    bOkEnable = False
                End If

                If Not ucrReceiverMonthlyTempSummaries.IsEmpty AndAlso ucrReceiverMultipleMonthlyTemp.IsEmpty Then
                    bOkEnable = False
                End If

                If Not ucrReceiverAnnualMonthlyTempSummaries.IsEmpty AndAlso ucrReceiverMultipleAnnualMonthlyTemp.IsEmpty Then
                    bOkEnable = False
                End If

                If Not ucrReceiverCropSummaries.IsEmpty AndAlso ucrReceiverCropDefinition.IsEmpty Then
                    bOkEnable = False
                End If

                If Not ucrReceiverPropSummaries.IsEmpty AndAlso ucrReceiverPropDefinition.IsEmpty Then
                    bOkEnable = False
                End If
            End If
        Else
            If ucrReceiverStationID.IsEmpty OrElse ucrReceiverStationName.IsEmpty Then
                bOkEnable = False
            End If
        End If

        If Not bDBConnected Then
            bOkEnable = False
        End If

        ucrBase.OKEnabled(bOkEnable)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        SetSummaryDataDefaultSelector()
        HideDisplayGroupedControls()
        If _sdgImportFromClimSoft IsNot Nothing Then
            _sdgImportFromClimSoft.Reset()
        End If
        SetDialogSize()
        CheckAndUpdateConnectionStatus()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualRainfallSummaries.ControlContentsChanged,
        ucrReceiverAnnualTempSummaries.ControlContentsChanged, ucrReceiverMonthlyRainfallSummaries.ControlContentsChanged,
        ucrReceiverMonthlyTempSummaries.ControlContentsChanged, ucrReceiverAnnualMonthlyTempSummaries.ControlContentsChanged,
        ucrReceiverMultipleAnnualRainfall.ControlContentsChanged, ucrReceiverMultipleAnnualTemp.ControlContentsChanged,
        ucrReceiverMultipleMonthlyRainfall.ControlContentsChanged, ucrReceiverMultipleMonthlyTemp.ControlContentsChanged,
        ucrReceiverMultipleAnnualMonthlyTemp.ControlContentsChanged, ucrReceiverCropSummaries.ControlContentsChanged,
        ucrReceiverCropDefinition.ControlContentsChanged, ucrReceiverPropSummaries.ControlContentsChanged,
        ucrReceiverPropDefinition.ControlContentsChanged, ucrPnlExportToEPicsa.ControlContentsChanged,
        ucrReceiverStationID.ControlContentsChanged, ucrReceiverStationName.ControlContentsChanged,
        ucrReceiverLongitude.ControlContentsChanged, ucrReceiverLatitude.ControlContentsChanged,
        ucrReceiverElevation.ControlContentsChanged, ucrReceiverDistrict.ControlContentsChanged, ucrReceiverCountryCode.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlExportToEPicsa_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlExportToEPicsa.ControlValueChanged
        If rdoSummaryData.Checked Then
            SetSelectorMode(SummaryDataSelectorMode.Dataframes)
            clsDummyFunction.AddParameter("checked", "summary_data", iPosition:=0)
        Else
            clsDummyFunction.AddParameter("checked", "station_metadata", iPosition:=0)
            grpDefinitionsProducts.Visible = False
        End If

        HideDisplayGroupedControls()
        SetDialogSize()
        ChangeExportToDBParams()
        TestOkEnabled()
    End Sub

    Private Sub SnapshotCurrentMultipleReceiver(ucrReceiverCurrent As ucrReceiver)
        dctCurrentMultipleReceiverSnapshot.Clear()
        Dim lstItems As New List(Of KeyValuePair(Of String, String))
        Dim lstDataFrames As List(Of String) = ucrReceiverCurrent.GetItemsDataFrames()
        Dim strDataFrame As String = If(lstDataFrames.Count > 0, lstDataFrames(0), "")
        For Each strItem As String In ucrReceiverCurrent.GetVariableNamesList(bWithQuotes:=False)
            lstItems.Add(New KeyValuePair(Of String, String)(strDataFrame, strItem))
        Next
        dctCurrentMultipleReceiverSnapshot(ucrReceiverCurrent) = lstItems

    End Sub

    Private Sub RestoreMultipleReceiversIfStripped()
        For Each kvpEntry In dctCurrentMultipleReceiverSnapshot
            Dim ucrReceiverTemp As ucrReceiver = kvpEntry.Key
            Dim lstExpected As List(Of KeyValuePair(Of String, String)) = kvpEntry.Value
            If lstExpected.Count > 0 AndAlso ucrReceiverTemp.IsEmpty() Then
                For Each kvpDataframeVariable As KeyValuePair(Of String, String) In lstExpected
                    Dim strDataframe = kvpDataframeVariable.Key
                    If strDataframe <> strCurrentEPicsaDataframe Then
                        ucrSelectorExportToEPicsa.SetDataframe(kvpDataframeVariable.Key, bEnableDataframe:=False, bSilent:=True)
                    End If
                    ucrReceiverTemp.Add(strItem:=kvpDataframeVariable.Value, strDataFrame:=kvpDataframeVariable.Key)
                    strCurrentEPicsaDataframe = kvpDataframeVariable.Key
                Next
            End If
        Next
    End Sub

    Private Sub dlgExportClimaticDefinitions_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        Dim ucrReceiverCurrent As ucrReceiver
        For Each ucrReceiverTemp As ucrReceiver In {ucrReceiverMultipleAnnualRainfall, ucrReceiverMultipleMonthlyRainfall,
            ucrReceiverMultipleAnnualTemp, ucrReceiverMultipleMonthlyTemp, ucrReceiverMultipleAnnualMonthlyTemp,
            ucrReceiverPropDefinition, ucrReceiverCropDefinition}
            If ucrSelectorExportToEPicsa.CurrentReceiver.Equals(ucrReceiverTemp) Then
                ucrReceiverCurrent = ucrReceiverTemp
            End If
        Next

        SnapshotCurrentMultipleReceiver(ucrReceiverCurrent)
    End Sub

    Private Sub SetDialogSize()
        Me.AutoSize = False

        If rdoSummaryData.Checked Then
            If GetGrpBoxVisibility() Then
                Me.Size = New Size(555, 680)
            Else
                Me.Size = New Size(500, 680)
            End If
            ucrBase.Location = New Point(12, 585)
            ucrPnlExportToEPicsa.Location = New Point(150, 7)
        Else
            Me.Size = New Size(500, 500)
            ucrPnlExportToEPicsa.Location = New Point(125, 7)
            ucrBase.Location = New Point(12, 405)
        End If

        CenterDialog()
    End Sub

    Private Sub CenterDialog()
        Dim WorkingArea = Screen.FromControl(Me).WorkingArea

        ' Manually Centering Dialog 
        Me.Location = New Point(WorkingArea.Left + (WorkingArea.Width - Me.Width) \ 2, WorkingArea.Top + (WorkingArea.Height - Me.Height) \ 2)
    End Sub

    Private Sub ChangeExportToDBParams()
        If rdoSummaryData.Checked Then
            clsExportToDBFunction.RemoveParameterByName("station_metadata")

            clsExportToDBFunction.AddParameter("summary_data", clsROperatorParameter:=clsSummaryDataOperator, iPosition:=1)
            clsExportToDBFunction.AddParameter("summary_station_metadata", clsROperatorParameter:=clsSummaryStationMetadataOperator, iPosition:=2)
            clsExportToDBFunction.AddParameter("definition_data", clsROperatorParameter:=clsDefinitionDataOperator, iPosition:=3)
            clsExportToDBFunction.AddParameter("crop_data", clsROperatorParameter:=clsCropDataOperator, iPosition:=4)
        Else
            clsExportToDBFunction.RemoveParameterByName("summary_data")
            clsExportToDBFunction.RemoveParameterByName("summary_station_metadata")
            clsExportToDBFunction.RemoveParameterByName("definition_data")
            clsExportToDBFunction.RemoveParameterByName("crop_data")

            clsExportToDBFunction.AddParameter("station_metadata", clsRFunctionParameter:=clsCollateStationMetadataFunction, iPosition:=1)
        End If
    End Sub


    Private Sub AddRemoveParamsInSummaryDefinitionsFunction()
        AddRemoveParameter(clsCollateSummaryDefinitionsFunction, clsFunctionParameter:=clsBuildSummaryLongAnnualRainFunction, paramName:="annual_rain_summary", iPosition:=0, ucrReceiverAnnualRainfallSummaries)
        AddRemoveParameter(clsCollateSummaryDefinitionsFunction, clsFunctionParameter:=clsBuildSummaryLongAnnualTempFunction, paramName:="annual_temp_summary", iPosition:=1, ucrReceiverAnnualTempSummaries)
        AddRemoveParameter(clsCollateSummaryDefinitionsFunction, clsFunctionParameter:=clsBuildSummaryLongMonthlyRainFunction, paramName:="monthly_rain_summary", iPosition:=2, ucrReceiverMonthlyRainfallSummaries)
        AddRemoveParameter(clsCollateSummaryDefinitionsFunction, clsFunctionParameter:=clsBuildSummaryLongMonthlyTempFunction, paramName:="monthly_temp_summary", iPosition:=3, ucrReceiverMonthlyTempSummaries)
        AddRemoveParameter(clsCollateSummaryDefinitionsFunction, clsFunctionParameter:=clsBuildSummaryLongAnnualMonthlyTempFunction, paramName:="annual_monthly_temp_summary", iPosition:=4, ucrReceiverAnnualMonthlyTempSummaries)
        AddRemoveParameter(clsCollateSummaryDefinitionsFunction, clsFunctionParameter:=clsBuildCropLongerFunction, paramName:="crop_summary", iPosition:=5, ucrReceiverCropSummaries, ucrReceiverPropSummaries)
    End Sub

    Private Sub AddRemoveParameter(clsRFunction As RFunction, clsFunctionParameter As RFunction, paramName As String, iPosition As Integer, ParamArray ucrReceivers() As ucrReceiverSingle)
        Dim bAnyFilled As Boolean = False
        For Each ucrReceiverTemp As ucrReceiverSingle In ucrReceivers
            If Not ucrReceiverTemp.IsEmpty Then
                bAnyFilled = True
                Exit For
            End If
        Next

        If bAnyFilled Then
            clsRFunction.AddParameter(paramName, clsRFunctionParameter:=clsFunctionParameter, iPosition:=iPosition)
        Else
            clsRFunction.RemoveParameterByName(paramName)
        End If
    End Sub

    Private Sub RemoveRelatedParams(clsRFunction As RFunction, paramName As String, iPosition As Integer, ucrReceiverCore As ucrReceiverSingle, ucrReceiverAssociated As ucrReceiverSingle)
        If ucrReceiverCore.IsEmpty Then
            If clsRFunction.ContainsParameter(paramName) Then
                clsRFunction.RemoveParameterByName(paramName)
            End If
        Else
            If Not ucrReceiverAssociated.IsEmpty Then
                clsRFunction.AddParameter(paramName, ucrReceiverAssociated.GetVariableNames(), iPosition:=iPosition)
            End If
        End If
    End Sub

    Private Sub SetSummaryDataDefaultSelector()
        If rdoSummaryData.Checked Then
            SetSelectorMode(SummaryDataSelectorMode.Dataframes)
        End If
    End Sub

    Private Sub CoreCropPropSummaryReceivers_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCropSummaries.ControlValueChanged,
            ucrReceiverPropSummaries.ControlValueChanged
        ' Removes the parameter if the core receiver is empty and adds it back in if it's filled
        RemoveRelatedParams(clsBuildCropLongerFunction, paramName:="crop_definition", iPosition:=2, ucrReceiverCore:=ucrReceiverCropSummaries, ucrReceiverAssociated:=ucrReceiverCropDefinition)
        RemoveRelatedParams(clsBuildCropLongerFunction, paramName:="prop_definition", iPosition:=3, ucrReceiverCore:=ucrReceiverPropSummaries, ucrReceiverAssociated:=ucrReceiverPropDefinition)
    End Sub

    Private Sub btnConnection_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        If _sdgImportFromClimSoft Is Nothing Then
            _sdgImportFromClimSoft = New sdgImportFromClimSoft
            AddHandler _sdgImportFromClimSoft.Shown, AddressOf SetEPicsaSubDialogDefaults
        End If

        AddRemoveDBConnectionCodes()
        _sdgImportFromClimSoft.ShowDialog()

        CheckAndUpdateConnectionStatus()
        TestOkEnabled()
    End Sub


    Private Sub AddRemoveDBConnectionCodes()
        If _sdgImportFromClimSoft IsNot Nothing Then
            If bDBConnected Then
                ucrBase.clsRsyntax.AddToBeforeCodes(clsGetDBConnectionFunction, iPosition:=2)
            Else
                ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsGetDBConnectionFunction)
            End If
        End If
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

        AddRemoveDBConnectionCodes()
    End Sub

    Private Sub SetSelectorMode(mode As SummaryDataSelectorMode)
        If CurrentSummaryDataSelectorMode = mode Then
            Exit Sub
        End If

        CurrentSummaryDataSelectorMode = mode

        Select Case mode
            Case SummaryDataSelectorMode.Dataframes
                ucrSelectorDataFramesExportToEPicsa.Visible = True
                ucrSelectorExportToEPicsa.Visible = False
            Case SummaryDataSelectorMode.Objects
                ucrSelectorDataFramesExportToEPicsa.Visible = False
                ucrSelectorExportToEPicsa.Visible = True
        End Select
    End Sub

    Private Sub SingleReceiver_Click(sender As Object, e As EventArgs) Handles ucrReceiverAnnualRainfallSummaries.Enter,
        ucrReceiverAnnualTempSummaries.Enter, ucrReceiverMonthlyRainfallSummaries.Enter,
        ucrReceiverMonthlyTempSummaries.Enter, ucrReceiverAnnualMonthlyTempSummaries.Enter, ucrReceiverCropSummaries.Enter,
        ucrReceiverPropSummaries.Enter
        SetSelectorMode(SummaryDataSelectorMode.Dataframes)
    End Sub

    Private Sub MultipleReceiver_Click(sender As Object, e As EventArgs) Handles ucrReceiverMultipleAnnualRainfall.Enter,
            ucrReceiverMultipleMonthlyRainfall.Enter, ucrReceiverMultipleAnnualTemp.Enter, ucrReceiverMultipleMonthlyTemp.Enter,
            ucrReceiverMultipleAnnualMonthlyTemp.Enter, ucrReceiverPropDefinition.Enter, ucrReceiverCropDefinition.Enter
        Dim ucrReceiverCurrent As ucrReceiver = DirectCast(sender, ucrReceiver)
        Dim ucrReceiverDataframe As ucrReceiverSingle
        Dim strDataframe As String = ""

        ' Setting the dataframe in the object selector to be the dataframe name in the corresponding main single receiver
        If dctReceiverMap.TryGetValue(ucrReceiverCurrent, ucrReceiverDataframe) Then
            If Not ucrReceiverDataframe.IsEmpty() Then
                strDataframe = ucrReceiverDataframe.GetVariableNames(bWithQuotes:=False)
                If strDataframe <> strCurrentEPicsaDataframe Then
                    ucrSelectorExportToEPicsa.SetDataframe(strDataframe, bEnableDataframe:=False, bSilent:=True)
                    strCurrentEPicsaDataframe = strDataframe
                End If
            End If
        End If

        SetSelectorMode(SummaryDataSelectorMode.Objects)
    End Sub

    Private Function GetGrpBoxVisibility() As Boolean
        Return Not (ucrReceiverAnnualRainfallSummaries.IsEmpty AndAlso ucrReceiverMonthlyRainfallSummaries.IsEmpty AndAlso
            ucrReceiverAnnualTempSummaries.IsEmpty AndAlso ucrReceiverMonthlyTempSummaries.IsEmpty AndAlso
            ucrReceiverAnnualMonthlyTempSummaries.IsEmpty AndAlso ucrReceiverCropSummaries.IsEmpty AndAlso ucrReceiverPropSummaries.IsEmpty)
    End Function

    Private Sub HideDisplayGroupedControls()
        If rdoSummaryData.Checked Then
            grpDefinitionsProducts.Visible = GetGrpBoxVisibility()
            ucrReceiverMultipleAnnualRainfall.Visible = Not ucrReceiverAnnualRainfallSummaries.IsEmpty
            ucrReceiverMultipleMonthlyRainfall.Visible = Not ucrReceiverMonthlyRainfallSummaries.IsEmpty
            ucrReceiverMultipleAnnualTemp.Visible = Not ucrReceiverAnnualTempSummaries.IsEmpty
            ucrReceiverMultipleMonthlyTemp.Visible = Not ucrReceiverMonthlyTempSummaries.IsEmpty
            ucrReceiverMultipleAnnualMonthlyTemp.Visible = Not ucrReceiverAnnualMonthlyTempSummaries.IsEmpty
            ucrReceiverPropDefinition.Visible = Not ucrReceiverPropSummaries.IsEmpty
            ucrReceiverCropDefinition.Visible = Not ucrReceiverCropSummaries.IsEmpty

            ' Making sure all labels don't appear at once when the group box appears
            lblAnnualRainfall.Visible = ucrReceiverMultipleAnnualRainfall.Visible
            lblMonthlyRainfall.Visible = ucrReceiverMultipleMonthlyRainfall.Visible
            lblAnnualTemp.Visible = ucrReceiverMultipleAnnualTemp.Visible
            lblMonthlyTemp.Visible = ucrReceiverMultipleMonthlyTemp.Visible
            lblAnnualMonthlyTemp.Visible = ucrReceiverMultipleAnnualMonthlyTemp.Visible
            lblCropDefinition.Visible = ucrReceiverCropDefinition.Visible
            lblPropDefinition.Visible = ucrReceiverPropDefinition.Visible

            lblStationID.Visible = False
            lblStationName.Visible = False
            lblLatitiude.Visible = False
            lblLongitude.Visible = False
            lblElevation.Visible = False
            lblDistrict.Visible = False
            lblCountryCode.Visible = False
        Else
            lblAnnualMonthlyTemp.Visible = False
            lblAnnualMonthlyTempSummaries.Visible = False
            lblAnnualRainfall.Visible = False
            lblAnnualRainfallSummaries.Visible = False
            lblAnnualTemp.Visible = False
            lblAnnualTempSummaries.Visible = False
            lblCropDefinition.Visible = False
            lblCropSummaries.Visible = False
            lblDataframes.Visible = False
            lblMonthlyRainfall.Visible = False
            lblMonthlyRainfallSummaries.Visible = False
            lblMonthlyTemp.Visible = False
            lblMonthlyTempSummaries.Visible = False
            lblPropDefinition.Visible = False
            lblPropSummaries.Visible = False
        End If
    End Sub

    Private Sub CoreControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualRainfallSummaries.ControlValueChanged,
        ucrReceiverAnnualTempSummaries.ControlValueChanged, ucrReceiverMonthlyRainfallSummaries.ControlValueChanged,
        ucrReceiverMonthlyTempSummaries.ControlValueChanged, ucrReceiverAnnualMonthlyTempSummaries.ControlValueChanged,
        ucrReceiverCropSummaries.ControlValueChanged, ucrReceiverPropSummaries.ControlValueChanged
        AddRemoveParamsInSummaryDefinitionsFunction()
        HideDisplayGroupedControls()
        SetDialogSize()
        TestOkEnabled()
    End Sub

End Class
