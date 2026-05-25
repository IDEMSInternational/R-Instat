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


Imports instat.Translations
Imports RDotNet

Public Class dlgClimSoft
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRImportClimsoftData, clsRImportClimsoftMetaData As New RFunction

    'the 4 dictionaries hold data for the station, elements, tables and QC comboboxes
    'As of 28th August 2020, there is no direct way of getting the selected value from the custom combobox
    'these are declared here to be used in getting the selected value
    Private dctStationCols, dctElementsCols, dctTables, dctQCStatuses As New Dictionary(Of String, String)

    Private Sub dlgClimSoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        CheckAndUpdateConnectionStatus()
        'autoTranslate(Me) ' temporary commented, affects the connected text by overwriting it with wrong text
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 329

        '---------------------------------------
        'tables
        dctTables.Add("Initial", Chr(34) & "observationinitial" & Chr(34))
        dctTables.Add("Final", Chr(34) & "observationfinal" & Chr(34))
        ucrCboTable.SetParameter(New RParameter("table", 0))
        ucrCboTable.SetItems(dctTables)
        ucrCboTable.bAllowNonConditionValues = False
        ucrCboTable.SetDropDownStyleAsNonEditable()
        ucrCboTable.SetLinkedDisplayControl(lblSelectTable)
        '---------------------------------------

        'stations
        '---------------------------------------
        dctStationCols.Add("Station IDs", Chr(34) & "stationId" & Chr(34))
        dctStationCols.Add("Station Names", Chr(34) & "stationName" & Chr(34))
        dctStationCols.Add("Station Qualifiers", Chr(34) & "qualifier" & Chr(34))
        ucrCboStations.SetParameter(New RParameter("station_filter_column", 1))
        ucrCboStations.SetItems(dctStationCols)
        ucrCboStations.bAllowNonConditionValues = False
        ucrCboStations.SetDropDownStyleAsNonEditable()
        ucrCboStations.SetLinkedDisplayControl(New List(Of Control)({lblSelectElements, btnUseDataFrameFilter}))

        ucrReceiverMultipleStations.SetParameter(New RParameter("stations", 2))
        ucrReceiverMultipleStations.SetParameterIsString()
        ucrReceiverMultipleStations.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleStations.SetItemType("database_variables")
        ucrReceiverMultipleStations.strSelectorHeading = "Stations"
        ucrReceiverMultipleStations.SetLinkedDisplayControl(lblSelectStations)
        '---------------------------------------

        'elements
        '---------------------------------------
        dctElementsCols.Add("Element IDs", Chr(34) & "elementId" & Chr(34))
        dctElementsCols.Add("Element Names", Chr(34) & "elementName" & Chr(34))
        dctElementsCols.Add("Element Abbreviation", Chr(34) & "abbreviation" & Chr(34))
        dctElementsCols.Add("Element Types", Chr(34) & "elementtype" & Chr(34))
        ucrCboElements.SetParameter(New RParameter("element_filter_column", 3))
        ucrCboElements.SetItems(dctElementsCols)
        ucrCboElements.bAllowNonConditionValues = False
        ucrCboElements.SetDropDownStyleAsNonEditable()
        ucrCboElements.SetLinkedDisplayControl(lblSelectElements)

        ucrReceiverMultipleElements.SetParameter(New RParameter("elements", 4))
        ucrReceiverMultipleElements.SetParameterIsString()
        ucrReceiverMultipleElements.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleElements.SetItemType("database_variables")
        ucrReceiverMultipleElements.strSelectorHeading = "Elements"
        ucrReceiverMultipleElements.SetLinkedDisplayControl(lblSelectElements)
        '---------------------------------------

        'qc status
        '---------------------------------------
        dctQCStatuses.Add("All", "-1")
        dctQCStatuses.Add("Zero", "0")
        dctQCStatuses.Add("One", "1")
        dctQCStatuses.Add("Two", "2")
        ucrCboQCStatus.SetParameter(New RParameter("qc_status", 5))
        ucrCboQCStatus.SetItems(dctQCStatuses)
        ucrCboQCStatus.SetRDefault("-1")
        ucrCboQCStatus.bAllowNonConditionValues = False
        ucrCboQCStatus.SetDropDownStyleAsNonEditable()
        ucrCboQCStatus.SetLinkedDisplayControl(lblSelectQCStatus)
        '---------------------------------------

        'Unstack data
        '---------------------------------------
        ucrChKUnstackData.SetText("Unstack Data")
        ucrChKUnstackData.SetParameter(New RParameter("unstack_data", 13))
        ucrChKUnstackData.SetRDefault("FALSE")
        '---------------------------------------

        'date range
        '---------------------------------------
        ucrChkDataDate.SetText("Select Dates")

        ucrDtpStartDataDate.SetParameter(New RParameter("start_date", 6))
        ucrDtpStartDataDate.SetParameterIsRDate()
        ucrDtpStartDataDate.SetLinkedDisplayControl(lblToDataDate)

        ucrDtpEndDataDate.SetParameter(New RParameter("end_date", 7))
        ucrDtpEndDataDate.SetParameterIsRDate()

        ucrChkDataDate.AddToLinkedControls({ucrDtpStartDataDate, ucrDtpEndDataDate}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        '---------------------------------------

        'metadata controls
        '---------------------------------------
        ucrChkImportStationsMetadata.SetText("Import All Stations Metadata")
        ucrChkImportStationsMetadata.SetParameter(New RParameter("import_stations", 0))
        ucrChkImportStationsMetadata.SetRDefault("FALSE")

        ucrChkImportElementsMetadata.SetText("Import All Elements Metadata")
        ucrChkImportElementsMetadata.SetParameter(New RParameter("import_elements", 2))
        ucrChkImportElementsMetadata.SetRDefault("FALSE")

        ucrChkImportFlagsMetadata.SetText("Import All Flags Metadata")
        ucrChkImportFlagsMetadata.SetParameter(New RParameter("import_flags", 3))
        ucrChkImportFlagsMetadata.SetRDefault("FALSE")
        '---------------------------------------

        'dialog options
        '---------------------------------------
        ucrPnlOptions.AddRadioButton(rdoData)
        ucrPnlOptions.AddRadioButton(rdoMetadata)

        ucrPnlOptions.AddFunctionNamesCondition(rdoData, frmMain.clsRLink.strInstatDataObject & "$import_climsoft_data")
        ucrPnlOptions.AddFunctionNamesCondition(rdoMetadata, frmMain.clsRLink.strInstatDataObject & "$import_climsoft_metadata")


        ucrPnlOptions.AddToLinkedControls({ucrCboTable, ucrCboQCStatus, ucrSelectorForClimSoft, ucrReceiverMultipleStations, ucrReceiverMultipleElements, ucrCboStations, ucrCboElements, ucrChkDataDate, ucrChKUnstackData},
                                          {rdoData}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkImportStationsMetadata, ucrChkImportElementsMetadata, ucrChkImportFlagsMetadata},
                                        {rdoMetadata}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)

        '---------------------------------------

    End Sub

    Private Sub SetDefaults()
        clsRImportClimsoftData = New RFunction
        clsRImportClimsoftMetaData = New RFunction

        'data command
        '---------------------------------------
        clsRImportClimsoftData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_climsoft_data")
        clsRImportClimsoftData.AddParameter(strParameterName:="table", strParameterValue:=Chr(34) & "observationfinal" & Chr(34), iPosition:=0)
        clsRImportClimsoftData.AddParameter(strParameterName:="station_filter_column", strParameterValue:=Chr(34) & "stationId" & Chr(34), iPosition:=1)
        clsRImportClimsoftData.AddParameter(strParameterName:="element_filter_column", strParameterValue:=Chr(34) & "elementId" & Chr(34), iPosition:=3)
        '---------------------------------------

        'metadata command
        '---------------------------------------
        clsRImportClimsoftMetaData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_climsoft_metadata")
        '---------------------------------------

        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportClimsoftData)

        ucrSelectorForClimSoft.Reset()
        ucrReceiverMultipleStations.SetMeAsReceiver()
        ucrChkDataDate.Checked = False
        rdoData.Checked = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'data option
        '---------------------------------------
        ucrCboStations.SetRCode(clsRImportClimsoftData, bReset)
        ucrReceiverMultipleStations.SetRCode(clsRImportClimsoftData, bReset)

        ucrCboElements.SetRCode(clsRImportClimsoftData, bReset)
        ucrReceiverMultipleElements.SetRCode(clsRImportClimsoftData, bReset)

        ucrCboTable.SetRCode(clsRImportClimsoftData, bReset)

        ucrChKUnstackData.SetRCode(clsRImportClimsoftData, bReset)

        ucrCboQCStatus.SetRCode(clsRImportClimsoftData, bReset)

        ucrDtpStartDataDate.SetRCode(clsRImportClimsoftData, bReset)
        ucrDtpEndDataDate.SetRCode(clsRImportClimsoftData, bReset)

        'data sub dialog
        sdgClimsoft.SetRCode(clsRImportClimsoftData, bReset)
        '---------------------------------------

        'metadata option
        '---------------------------------------
        ucrChkImportStationsMetadata.SetRCode(clsRImportClimsoftMetaData, bReset)
        ucrChkImportElementsMetadata.SetRCode(clsRImportClimsoftMetaData, bReset)
        ucrChkImportFlagsMetadata.SetRCode(clsRImportClimsoftMetaData, bReset)
        '---------------------------------------
    End Sub

    Private Sub btnConnection_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        'shows the database connect sub dialog and checks if connection has been established
        sdgImportFromClimSoft.ShowDialog()
        CheckAndUpdateConnectionStatus()
        ucrReceiverMultipleStations.Clear()
        ucrReceiverMultipleElements.Clear()
        ucrReceiverMultipleStations.SetMeAsReceiver()
    End Sub

    Private Sub ucrPnlOption_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged
        btnMoreOptions.Visible = rdoData.Checked
        btnCheckRecords.Visible = rdoData.Checked
        lblRecordsNum.Visible = rdoData.Checked
        ucrBase.clsRsyntax.SetBaseRFunction(If(rdoData.Checked, clsRImportClimsoftData, clsRImportClimsoftMetaData))
    End Sub

    Private Sub ucrCboStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboStations.ControlValueChanged
        If dctStationCols.Count < 1 Then
            Exit Sub
        End If
        SetRecieverQuery("station", dctStationCols.Item(ucrCboStations.GetText).Trim(""""), ucrReceiverMultipleStations)
    End Sub

    Private Sub btnUseDataFrameFilter_Click(sender As Object, e As EventArgs) Handles btnUseDataFrameFilter.Click
        Dim strDBColumnSelected As String = dctStationCols.Item(ucrCboStations.GetText).Trim("""")
        Dim strDFColumnToUse As String
        If strDBColumnSelected = "stationId" Then
            strDFColumnToUse = "station_id"
        ElseIf strDBColumnSelected = "stationName" Then
            strDFColumnToUse = "station_name"
        ElseIf strDBColumnSelected = "qualifier" Then
            strDFColumnToUse = "qualifier"
        Else
            MsgBoxTranslate("Developer Error: Database column not supported")
            Exit Sub
        End If
        sdgClimsoftFilter.setup(strDFColumnToUse)
        sdgClimsoftFilter.ShowDialog(Me)
        SetRecieverQuery("station", strDBColumnSelected, ucrReceiverMultipleStations, sdgClimsoftFilter.getSelections())
    End Sub

    Private Sub ucrCboElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboElements.ControlValueChanged
        If dctElementsCols.Count < 1 Then
            Exit Sub
        End If
        SetRecieverQuery("obselement", dctElementsCols.Item(ucrCboElements.GetText).Trim(""""), ucrReceiverMultipleElements)
    End Sub

    Private Sub ucrChkDataDate_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDataDate.ControlValueChanged
        'this forces the date pickers to write default parameter values to the Rfunction.
        'date picker controls have a problem of default date. 
        'its not set by default until the user changes selected date
        'todo. in future, this may not be needed
        If ucrChkDataDate.Checked Then
            ucrDtpEndDataDate.OnControlValueChanged()
            ucrDtpStartDataDate.OnControlValueChanged()
        End If
    End Sub

    Private Sub btnMoreOptions_Click(sender As Object, e As EventArgs) Handles btnMoreOptions.Click
        sdgClimsoft.ShowDialog()
        lblRecordsNum.Text = ""
    End Sub

    Private Sub btnCheckRecords_Click(sender As Object, e As EventArgs) Handles btnCheckRecords.Click
        Try
            lblRecordsNum.Text = ""
            Dim strTableName As String = dctTables.Item(ucrCboTable.GetText).Trim("""")
            Dim strStationColumn As String = dctStationCols.Item(ucrCboStations.GetText).Trim("""")
            Dim strElementsColumn As String = dctElementsCols.Item(ucrCboElements.GetText).Trim("""")
            Dim strStationsValues As String = GetSQLArrayFilter(ucrReceiverMultipleStations.GetVariableNamesList(bWithQuotes:=False))
            Dim strElementsValues As String = GetSQLArrayFilter(ucrReceiverMultipleElements.GetVariableNamesList(bWithQuotes:=False))
            Dim strQueryCondition As String = " INNER JOIN station ON " & strTableName & ".recordedFrom = station.stationId" &
                " INNER JOIN obselement ON " & strTableName & ".describedBy = obselement.elementId WHERE" &
                " station." & strStationColumn & " IN (" & strStationsValues & ")" &
                " AND obselement." & strElementsColumn & " IN (" & strElementsValues & ")"

            Dim strQCStatus As String = If(dctQCStatuses.Item(ucrCboQCStatus.GetText) = "-1", "", dctQCStatuses.Item(ucrCboQCStatus.GetText))

            If dctQCStatuses.Item(ucrCboQCStatus.GetText) <> "-1" Then
                strQueryCondition = strQueryCondition & " AND qcStatus = " & dctQCStatuses.Item(ucrCboQCStatus.GetText)
            End If

            If ucrChkDataDate.Checked Then
                strQueryCondition = strQueryCondition & " AND obsDatetime >= '" & ucrDtpStartDataDate.DateValue.ToString("yyyy-MM-dd") & "' AND obsDatetime <= '" & ucrDtpEndDataDate.DateValue.ToString("yyyy-MM-dd") & "'"
            End If

            Dim clsRowsCountRFunction As New RFunction
            clsRowsCountRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_db_table_row_count")
            clsRowsCountRFunction.AddParameter(strParameterName:="tableName", strParameterValue:=Chr(34) & strTableName & Chr(34))
            clsRowsCountRFunction.AddParameter(strParameterName:="query_condition", strParameterValue:=Chr(34) & strQueryCondition & Chr(34))

            Dim expTemp As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsRowsCountRFunction.ToScript())
            If expTemp IsNot Nothing Then
                Dim recordsNum As Integer = expTemp.AsNumeric().FirstOrDefault()
                lblRecordsNum.Text = recordsNum & " records found"
                lblRecordsNum.ForeColor = If(recordsNum > 0, Color.Green, Color.Red)
            End If
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Function GetSQLArrayFilter(values() As String) As String
        Dim strSQL As String = ""
        For index As Integer = 0 To values.Length - 1
            If index = 0 Then
                strSQL = "'" & values(index).Replace("'", "''") & "'"
            Else
                strSQL = strSQL & "," & "'" & values(index).Replace("'", "''") & "'"
            End If
        Next
        Return strSQL
    End Function

    Private Sub ucrControlsContents_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleStations.ControlContentsChanged, ucrReceiverMultipleElements.ControlContentsChanged, ucrCboTable.ControlContentsChanged, ucrCboQCStatus.ControlContentsChanged, ucrDtpStartDataDate.ControlContentsChanged, ucrDtpEndDataDate.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrChkImportStationsMetadata.ControlContentsChanged, ucrChkImportElementsMetadata.ControlContentsChanged, ucrChkImportFlagsMetadata.ControlContentsChanged
        Dim bValid As Boolean = False
        If rdoData.Checked Then
            bValid = Not ucrReceiverMultipleStations.IsEmpty() AndAlso Not ucrReceiverMultipleElements.IsEmpty() AndAlso Not ucrCboTable.IsEmpty()
            btnCheckRecords.Enabled = bValid
            lblRecordsNum.Text = ""
        ElseIf rdoMetadata.Checked Then
            bValid = ucrChkImportStationsMetadata.Checked OrElse ucrChkImportElementsMetadata.Checked OrElse ucrChkImportFlagsMetadata.Checked
        End If
        ucrBase.OKEnabled(bValid)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        sdgImportFromClimSoft.Reset()
        CheckAndUpdateConnectionStatus()
    End Sub

    Private Sub SetRecieverQuery(strTable As String, strSelectedColumn As String, ucrReceiverControl As ucrReceiverMultiple, Optional selectionIds() As String = Nothing)
        'sql query to get values of the selected column from the table
        Dim strQuery As String = $"SELECT DISTINCT {strSelectedColumn} FROM {strTable} WHERE {strSelectedColumn} IS NOT NULL AND {strSelectedColumn} <> ''"
        If selectionIds IsNot Nothing AndAlso selectionIds.Length > 0 Then
            Dim joined As String = String.Join(",", selectionIds.Select(Function(x) $"'{x}'"))
            strQuery = $"{strQuery} AND {strSelectedColumn} IN ({joined})"
        End If
        strQuery = $"{strQuery};"
        If ucrReceiverControl.strDatabaseQuery = strQuery Then
            Exit Sub
        End If
        ucrReceiverControl.Clear()
        ucrReceiverControl.strDatabaseQuery = strQuery
        'set as selected receiver. will also execute receiver's sql the query
        ucrReceiverControl.SetMeAsReceiver()
    End Sub

    Private Sub CheckAndUpdateConnectionStatus()
        If sdgImportFromClimSoft.IsConnectionIsActive() Then
            lblConnection.Text = "Connected"
            lblConnection.ForeColor = Color.Green
        Else
            lblConnection.Text = "No Connection"
            lblConnection.ForeColor = Color.Red
            ucrReceiverMultipleStations.Clear()
            ucrReceiverMultipleElements.Clear()
        End If
    End Sub


End Class