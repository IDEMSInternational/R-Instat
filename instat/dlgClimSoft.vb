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

Imports instat
Imports instat.Translations

Public Class dlgClimSoft
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRImportFromClimsoft As New RFunction

    'the 2 dictionaries hold data for the station and elements comboboxes
    'As of 28th August 2020, there is no direct way of getting the selected value from the custom combobox
    'these are declared here to be used in getting the selected value
    Private dctObsTables As New Dictionary(Of String, String)
    Private dctStationCols As New Dictionary(Of String, String)
    Private dctElementsCols As New Dictionary(Of String, String)

    'flag used by elements receiver to determine when not to clear itself and change its sql query 
    'useful when form is reloaded, to let the elements reciever retain the elements selected
    Private bIgnoreReceiverChanges As Boolean = False

    Private Sub dlgClimSoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bIgnoreReceiverChanges = True
        If bFirstLoad Then
            bIgnoreReceiverChanges = False
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        bIgnoreReceiverChanges = False
        CheckAndUpdateConnectionStatus()
        'autoTranslate(Me) ' temporary commented, affects the "connected" label by overwriting it's text with wrong text
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 329

        '-------------------------------------------------------------------------
        'observation tables combobox
        dctObsTables.Add("Observation Initial", Chr(34) & "observationinitial" & Chr(34))
        dctObsTables.Add("Observation Final", Chr(34) & "observationfinal" & Chr(34))
        ucrCboObsTable.SetParameter(New RParameter("observation_data_table", 0))
        ucrCboObsTable.SetItems(dctObsTables)
        ucrCboObsTable.bAllowNonConditionValues = False
        ucrCboObsTable.SetDropDownStyleAsNonEditable()

        '-----------------------------------------------------------------------------------
        'stations combobox
        dctStationCols.Add("Station IDs", Chr(34) & "stationId" & Chr(34))
        dctStationCols.Add("Station Names", Chr(34) & "stationName" & Chr(34))
        dctStationCols.Add("Station Qualifiers", Chr(34) & "qualifier" & Chr(34))
        ucrCboStations.SetParameter(New RParameter("station_filter_column", 1))
        ucrCboStations.SetItems(dctStationCols)
        ucrCboStations.bAllowNonConditionValues = False
        ucrCboStations.SetDropDownStyleAsNonEditable()

        'stations receiver
        ucrReceiverStations.SetParameter(New RParameter("stations", 2))
        ucrReceiverStations.SetParameterIsString()
        ucrReceiverStations.Selector = ucrSelectorForClimSoft
        ucrReceiverStations.SetItemType("database_variables")
        ucrReceiverStations.strSelectorHeading = "Stations"
        ucrReceiverStations.SetLinkedDisplayControl(lblStations)

        'station elements combobox
        dctElementsCols.Add("Element IDs", Chr(34) & "elementId" & Chr(34))
        dctElementsCols.Add("Element Names", Chr(34) & "elementName" & Chr(34))
        dctElementsCols.Add("Element Abbreviation", Chr(34) & "abbreviation" & Chr(34))
        dctElementsCols.Add("Element Types", Chr(34) & "elementtype" & Chr(34))
        ucrCboElements.SetParameter(New RParameter("element_filter_column", 3))
        ucrCboElements.SetItems(dctElementsCols)
        ucrCboElements.bAllowNonConditionValues = False
        ucrCboElements.SetDropDownStyleAsNonEditable()

        'station elements receiver
        ucrReceiverElements.SetParameter(New RParameter("elements", 4))
        ucrReceiverElements.SetParameterIsString()
        ucrReceiverElements.Selector = ucrSelectorForClimSoft
        ucrReceiverElements.SetItemType("database_variables")
        ucrReceiverElements.strSelectorHeading = "Elements"
        ucrReceiverElements.SetLinkedDisplayControl(lblElements)

        '-----------------------------------------------------------------
        'include stations checkbox
        ucrChkStations.SetText("Import Stations Metadata")
        ucrChkStations.SetParameter(New RParameter("include_stations_meta_data", 5))
        ucrChkStations.SetRDefault("FALSE")

        'include elements info checkbox
        ucrChkElements.SetText("Import Elements Metadata")
        ucrChkElements.SetParameter(New RParameter("include_elements_meta_data", 6))
        ucrChkElements.SetRDefault("FALSE")

        '-----------------------------------------------------------------
        ucrChkUnStackData.SetText("Unstack Data")
        ucrChkUnStackData.SetParameter(New RParameter("unstack_data", 7))
        ucrChkUnStackData.SetRDefault("FALSE")

        '-----------------------------------------------------------------
        'observation date range checkbox
        ucrChkObsDate.SetText("Select Date Range")
        ucrChkObsDate.Checked = True

        'start date datepicker
        ucrDtpObStartdate.SetParameter(New RParameter("obs_start_date", 11))
        ucrDtpObStartdate.SetParameterIsRDate()
        ucrDtpObStartdate.SetLinkedDisplayControl(lblObsStartDate)
        'todo. temporary, the date control is not writing to it's parameter on initial load
        'this is due to the date time picker loading with "now date" by default
        'ucrDtpObStartdate.DateValue = Date.Now.AddDays(1)

        'end date datepicker
        ucrDtpObsEndDate.SetParameter(New RParameter("obs_end_date", 12))
        ucrDtpObsEndDate.SetParameterIsRDate()
        ucrDtpObsEndDate.SetLinkedDisplayControl(lblObsEndDate)
        'todo. temporary, the date control is not writing to it's parameter on initial load
        'this is due to the date time picker loading with "now date" by default
        'ucrDtpObsEndDate.DateValue = Date.Now.AddDays(1)

        'link date pickers to date range checkbox
        ucrChkObsDate.AddToLinkedControls({ucrDtpObStartdate, ucrDtpObsEndDate}, {True},
                                          bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


    End Sub

    Private Sub SetDefaults()
        clsRImportFromClimsoft = New RFunction
        clsRImportFromClimsoft.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_observation_data_from_climsoft")
        clsRImportFromClimsoft.AddParameter(strParameterName:="observation_data_table",
                                            strParameterValue:=Chr(34) & "observationinitial" & Chr(34),
                                            iPosition:=0)
        clsRImportFromClimsoft.AddParameter(strParameterName:="station_filter_column",
                                            strParameterValue:=Chr(34) & "stationId" & Chr(34),
                                            iPosition:=1)
        clsRImportFromClimsoft.AddParameter(strParameterName:="element_filter_column",
                                            strParameterValue:=Chr(34) & "elementId" & Chr(34),
                                            iPosition:=3)


        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportFromClimsoft)

        ucrCboObsTable.Reset()
        ucrCboStations.Reset()
        ucrCboElements.Reset()
        ucrReceiverStations.SetMeAsReceiver()
        ucrSelectorForClimSoft.Reset()
        ucrChkUnStackData.Checked = False
        btnMoreOptions.Enabled = True
        ucrChkObsDate.Checked = False
        ucrDtpObStartdate.DateValue = Date.Now
        ucrDtpObsEndDate.DateValue = Date.Now
        ucrChkStations.Checked = False
        ucrChkElements.Checked = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrCboObsTable.SetRCode(clsRImportFromClimsoft, bReset)
        ucrCboStations.SetRCode(clsRImportFromClimsoft, bReset)
        ucrCboElements.SetRCode(clsRImportFromClimsoft, bReset)
        ucrReceiverStations.SetRCode(clsRImportFromClimsoft, bReset)
        ucrReceiverElements.SetRCode(clsRImportFromClimsoft, bReset)

        ucrChkStations.SetRCode(clsRImportFromClimsoft, bReset)
        ucrChkElements.SetRCode(clsRImportFromClimsoft, bReset)

        ucrChkUnStackData.SetRCode(clsRImportFromClimsoft, bReset)

        ucrDtpObStartdate.SetRCode(clsRImportFromClimsoft, bReset)
        ucrDtpObsEndDate.SetRCode(clsRImportFromClimsoft, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled((Not ucrReceiverStations.IsEmpty() AndAlso Not ucrReceiverElements.IsEmpty()))
    End Sub

    Private Sub btnEstablishConnection_Click(sender As Object, e As EventArgs) Handles btnEstablishConnection.Click
        'shows the database connect sub dialog and checks if connection has been established
        sdgImportFromClimSoft.ShowDialog()
        CheckAndUpdateConnectionStatus()
        ucrReceiverStations.Clear()
        ucrReceiverStations.SetMeAsReceiver()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        sdgImportFromClimSoft.Reset()
        CheckAndUpdateConnectionStatus()
        TestOKEnabled()
    End Sub

    Private Sub CheckAndUpdateConnectionStatus()
        If sdgImportFromClimSoft.IsConnectionIsActive() Then
            lblConnection.Text = Translations.GetTranslation("Connected")
            lblConnection.ForeColor = Color.Green
        Else
            lblConnection.Text = Translations.GetTranslation("No Connection")
            lblConnection.ForeColor = Color.Red
            ucrReceiverStations.Clear()
        End If
    End Sub

    ''' <summary>
    ''' constructs and sets the stations reciver SQL query
    ''' </summary>
    ''' <returns>returns true if receivers query was changed</returns>
    Private Function SetStationsReceiverQuery() As Boolean
        If ucrCboStations.IsEmpty Then
            Return False
        End If

        'sql query to get station values of the selected column from station table
        Dim strQuery As String
        Dim strSelectedObsTable As String = dctObsTables.Item(ucrCboObsTable.GetText).Trim("""")
        Dim strSelectedStationCol As String = dctStationCols.Item(ucrCboStations.GetText).Trim("""")
        strQuery = "SELECT DISTINCT station." & strSelectedStationCol &
            " FROM " & strSelectedObsTable &
            " INNER JOIN station ON " & strSelectedObsTable & ".recordedFrom = station.stationId;"

        'to avoid repetition in code execution check if the database query is still the same
        If ucrReceiverStations.strDatabaseQuery = strQuery Then
            Return False
        End If
        ucrReceiverStations.Clear()
        ucrReceiverStations.strDatabaseQuery = strQuery
        Return True
    End Function

    ''' <summary>
    ''' constructs and sets elements receiver SQL query
    ''' </summary>
    ''' <returns>returns true if receivers query was changed</returns>
    Private Function SetStationElementsRecieverQuery() As Boolean
        If ucrCboStations.IsEmpty OrElse ucrCboElements.IsEmpty Then
            Return False
        End If

        'sql query to get distinct element values of the selected column(obselement TABLE COLUMN) from the observationfinal table
        Dim strQuery As String
        Dim strSelectedObsTable As String = dctObsTables.Item(ucrCboObsTable.GetText).Trim("""")
        Dim strSelectedStationCol As String = dctStationCols.Item(ucrCboStations.GetText).Trim("""")
        Dim strSelectedElementCol As String = dctElementsCols.Item(ucrCboElements.GetText).Trim("""")
        strQuery = "SELECT DISTINCT obselement." & strSelectedElementCol &
            " FROM " & strSelectedObsTable &
            " INNER JOIN obselement ON " & strSelectedObsTable & ".describedBy = obselement.elementId" &
            " INNER JOIN station ON " & strSelectedObsTable & ".recordedFrom = station.stationId"
        'if stations have been specified, then get elements for those stations only
        If Not ucrReceiverStations.IsEmpty Then
            strQuery = strQuery & " WHERE " & "station." & strSelectedStationCol & " IN (" &
                String.Join(",", ucrReceiverStations.GetVariableNamesList(strQuotes:=Chr(39))) & ")"
        End If
        strQuery &= ";"

        'to avoid repetition in code execution check if the database query is still the same
        If ucrReceiverElements.strDatabaseQuery = strQuery Then
            Return False
        End If
        ucrReceiverElements.Clear()
        ucrReceiverElements.strDatabaseQuery = strQuery
        Return True
    End Function

    Private Sub ucrCboObsTable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboObsTable.ControlValueChanged
        If SetStationsReceiverQuery() Then
            'set as selected receiver. will also execute the receiver's sql query
            ucrReceiverStations.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrCboStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboStations.ControlValueChanged
        If SetStationsReceiverQuery() Then
            'set as selected receiver. will also execute the receiver's sql query
            ucrReceiverStations.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrReceiverStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStations.ControlValueChanged
        If Not bIgnoreReceiverChanges Then
            SetStationElementsRecieverQuery()
        End If
    End Sub

    Private Sub ucrCboElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboElements.ControlValueChanged
        If SetStationElementsRecieverQuery() Then
            'set as selected receiver. will also execute receiver's sql the query
            ucrReceiverElements.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrControlsContents_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrCboStations.ControlContentsChanged, ucrCboElements.ControlContentsChanged, ucrReceiverStations.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged
        TestOKEnabled()
    End Sub


    Private Sub ucrChkStackData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkUnStackData.ControlValueChanged
        If ucrChkUnStackData.Checked Then
            clsRImportFromClimsoft.RemoveParameterByName("include_qc_status")
            clsRImportFromClimsoft.RemoveParameterByName("include_entry_form")
            clsRImportFromClimsoft.RemoveParameterByName("include_flags")
        End If
    End Sub

    Private Sub btnMoreOptions_Click(sender As Object, e As EventArgs) Handles btnMoreOptions.Click
        sdgClimsoftDataOptions.SetUpRCode(clsRImportFromClimsoft, Not ucrChkUnStackData.Checked)
        sdgClimsoftDataOptions.ShowDialog(Me)
    End Sub

    Private Sub ucrChkDateRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkObsDate.ControlValueChanged
        'this forces the date pickers to write default parameter values to the Rfunction.
        'date picker controls have a problem of default date. 
        'its not set by default until the user changes selected date
        'todo. in future, this may not be needed
        If ucrChkObsDate.Checked Then
            ucrDtpObStartdate.OnControlValueChanged()
            ucrDtpObsEndDate.OnControlValueChanged()
        End If
    End Sub


End Class
