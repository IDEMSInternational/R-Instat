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
    Private dctStationColumns As New Dictionary(Of String, String)
    Private dctElementsColumns As New Dictionary(Of String, String)

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
        'autoTranslate(Me) ' temporary commented, affects the connected text by overwriting it with wrong text
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 329

        ucrPnlOptions.AddRadioButton(rdoStations)
        ucrPnlOptions.AddRadioButton(rdoElements)
        ucrPnlOptions.AddRadioButton(rdoData)

        'link observation data related controls to include observation data checkbox
        ucrPnlOptions.AddToLinkedControls({ucrComboBoxObsTable, ucrChkObsDate, ucrChkObsEntryDate, ucrComboBoxElements,
                                          ucrReceiverStnElements, ucrChkStackData, ucrChkFlagsData},
                                          {rdoData}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        'include stations info checkbox
        ucrChkStations.SetText("Import Stations Information")
        ucrChkStations.SetParameter(New RParameter("include_stations_info", 7))
        ucrChkStations.SetRDefault("FALSE")

        'include elements info checkbox
        ucrChkElements.SetText("Import Elements Information")
        ucrChkElements.SetParameter(New RParameter("include_elements_info", 7))
        ucrChkElements.SetRDefault("FALSE")

        'include observation data checkbox
        ucrChkObservationData.SetText("Import Observation Data")
        ucrChkObservationData.SetParameter(New RParameter("include_observation_data", 4))
        ucrChkObservationData.SetRDefault("FALSE")

        'stations combobox
        dctStationColumns.Add("Station IDs", Chr(34) & "stationId" & Chr(34))
        dctStationColumns.Add("Station Names", Chr(34) & "stationName" & Chr(34))
        dctStationColumns.Add("Station Qualifiers", Chr(34) & "qualifier" & Chr(34))
        ucrComboBoxStations.SetParameter(New RParameter("stationfiltercolumn", 0))
        ucrComboBoxStations.SetItems(dctStationColumns)
        ucrComboBoxStations.SetRDefault(Chr(34) & "stationId" & Chr(34))
        ucrComboBoxStations.bAllowNonConditionValues = False
        ucrComboBoxStations.SetDropDownStyleAsNonEditable()

        'stations receiver
        ucrReceiverStations.SetParameter(New RParameter("stations", 1))
        ucrReceiverStations.SetParameterIsString()
        ucrReceiverStations.Selector = ucrSelectorForClimSoft
        ucrReceiverStations.SetItemType("database_variables")
        ucrReceiverStations.strSelectorHeading = "Stations"
        ucrReceiverStations.SetLinkedDisplayControl(lblStations)

        'station elements combobox
        dctElementsColumns.Add("Element IDs", Chr(34) & "elementId" & Chr(34))
        dctElementsColumns.Add("Element Names", Chr(34) & "elementName" & Chr(34))
        dctElementsColumns.Add("Element Abbreviation", Chr(34) & "abbreviation" & Chr(34))
        dctElementsColumns.Add("Element Types", Chr(34) & "elementtype" & Chr(34))
        ucrComboBoxElements.SetParameter(New RParameter("elementfiltercolumn", 2))
        ucrComboBoxElements.SetItems(dctElementsColumns)
        ucrComboBoxElements.SetRDefault(Chr(34) & "elementId" & Chr(34))
        ucrComboBoxElements.bAllowNonConditionValues = False
        ucrComboBoxElements.SetDropDownStyleAsNonEditable()

        'station elements receiver
        ucrReceiverStnElements.SetParameter(New RParameter("elements", 3))
        ucrReceiverStnElements.SetParameterIsString()
        ucrReceiverStnElements.Selector = ucrSelectorForClimSoft
        ucrReceiverStnElements.SetItemType("database_variables")
        ucrReceiverStnElements.strSelectorHeading = "Elements"
        ucrReceiverStnElements.SetLinkedDisplayControl(lblElements)

        '-----------------------------------------------------------------
        'stack data checkbox. 
        'parameter attached to it is determined by elements receiver no. of contents. Thus not directly set by the control 
        ucrChkStackData.SetText("Stack Data")
        'ucrChkUnstackData.Checked = True

        'include flags data checkbox
        ucrChkFlagsData.SetText("Include Observation Flags")
        ucrChkFlagsData.SetParameter(New RParameter("include_observation_flags", 5))
        ucrChkFlagsData.SetRDefault("FALSE")


        '-------------------------------------------------------------------------
        'observation date range checkbox
        ucrChkObsDate.SetText("Select Observation Date Range")

        'start date datepicker
        ucrDtpObStartdate.SetParameter(New RParameter("start_date", 8))
        ucrDtpObStartdate.SetParameterIsRDate()
        ucrDtpObStartdate.SetLinkedDisplayControl(lblObsDateTo)

        'end date datepicker
        ucrDtpObsEndDate.SetParameter(New RParameter("end_date", 9))
        ucrDtpObsEndDate.SetParameterIsRDate()
        'link date pickers to date range checkbox
        ucrChkObsDate.AddToLinkedControls({ucrDtpObStartdate, ucrDtpObsEndDate}, {True},
                                          bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        '-----------------------------------------------------------------------------------------
        'entry date range checkbox
        ucrChkObsDate.SetText("Select Observation Entry Date Range")

        'start date datepicker
        ucrDtpEntryStartdate.SetParameter(New RParameter("start_date", 8))
        ucrDtpEntryStartdate.SetParameterIsRDate()
        ucrDtpEntryStartdate.SetLinkedDisplayControl(lblObsDateTo)

        'end date datepicker
        ucrDtpEntryEndDate.SetParameter(New RParameter("end_date", 9))
        ucrDtpEntryEndDate.SetParameterIsRDate()
        'link date pickers to date range checkbox
        ucrChkObsEntryDate.AddToLinkedControls({ucrDtpEntryStartdate, ucrDtpEntryEndDate}, {True},
                                          bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


    End Sub

    Private Sub SetDefaults()
        clsRImportFromClimsoft = New RFunction
        clsRImportFromClimsoft.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_climsoft")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportFromClimsoft)

        ucrReceiverStations.SetMeAsReceiver()
        ucrSelectorForClimSoft.Reset()
        ucrChkStackData.Checked = True
        ucrChkObsDate.Checked = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrComboBoxStations.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverStations.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrComboBoxElements.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverStnElements.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkObservationData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkFlagsData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkElements.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrDtpObStartdate.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrDtpObsEndDate.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub btnEstablishConnection_Click(sender As Object, e As EventArgs) Handles cmdEstablishConnection.Click
        'shows the database connect sub dialog and checks if connection has been established
        sdgImportFromClimSoft.ShowDialog()
        CheckAndUpdateConnectionStatus()
        ucrReceiverStations.Clear()
        ucrReceiverStations.SetMeAsReceiver()
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled((Not ucrReceiverStations.IsEmpty() AndAlso Not ucrChkObservationData.Checked) OrElse (Not ucrReceiverStnElements.IsEmpty() AndAlso ucrChkObservationData.Checked))
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        sdgImportFromClimSoft.Reset()
        CheckAndUpdateConnectionStatus()
        TestOKEnabled()
    End Sub


    ''' <summary>
    ''' constructs and sets the stations reciver SQL query
    ''' </summary>
    ''' <returns>returns true if receivers query was changed</returns>
    Private Function SetStationsReceiverQuery() As Boolean
        If dctStationColumns.Count < 1 Then
            Return False
        End If

        'sql query to get station values of the selected column from station table
        Dim strQuery As String
        Dim strSelectedColumn As String = dctStationColumns.Item(ucrComboBoxStations.GetText).Trim("""")

        strQuery = "SELECT DISTINCT " & strSelectedColumn & " FROM station WHERE " & strSelectedColumn & " IS NOT NULL AND " & strSelectedColumn & " <> '';"
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
        If dctElementsColumns.Count < 1 Then
            Return False
        End If

        'sql query to get distinct element values of the selected column(obselement TABLE COLUMN) from the observationfinal table
        Dim strQuery As String
        strQuery = "SELECT DISTINCT obselement." & dctElementsColumns.Item(ucrComboBoxElements.GetText).Trim("""") &
            " FROM observationfinal" &
            " INNER JOIN obselement ON observationfinal.describedBy = obselement.elementId" &
            " INNER JOIN station ON observationfinal.recordedFrom = station.stationId"
        'if stations have been specified, then get elements for those stations only
        If Not ucrReceiverStations.IsEmpty Then
            strQuery = strQuery & " WHERE " & "station." & dctStationColumns.Item(ucrComboBoxStations.GetText).Trim("""") & " IN (" &
                String.Join(",", ucrReceiverStations.GetVariableNamesList(strQuotes:=Chr(39))) & ")"
        End If
        strQuery &= ";"

        If ucrReceiverStnElements.strDatabaseQuery = strQuery Then
            Return False
        End If
        ucrReceiverStnElements.Clear()
        ucrReceiverStnElements.strDatabaseQuery = strQuery
        Return True
    End Function

    Private Sub ucrComboBoxStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrComboBoxStations.ControlValueChanged
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

    Private Sub ucrComboBoxElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrComboBoxElements.ControlValueChanged
        If SetStationElementsRecieverQuery() Then
            'set as selected receiver. will also execute receiver's sql the query
            ucrReceiverStnElements.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrStackDataControlsValueChanged_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkStackData.ControlValueChanged, ucrReceiverStnElements.ControlValueChanged
        'only change the receivers if the event was raised by ucrChkObservationData checkbox
        If TypeOf ucrChangedControl Is ucrCheck Then
            If ucrChkObservationData.Checked Then
                ucrReceiverStnElements.SetMeAsReceiver()
            Else
                ucrReceiverStations.SetMeAsReceiver()
            End If
        End If

        'unstack observation data only when more than 1 element is selected
        If ucrChkObservationData.Checked AndAlso ucrReceiverStnElements.GetVariableNamesAsList.Count > 1 Then
            ucrChkStackData.Enabled = True
            clsRImportFromClimsoft.AddParameter("unstack_data", If(ucrChkStackData.Checked, "TRUE", "FALSE"), iPosition:=6)
        Else
            ucrChkStackData.Enabled = False
            clsRImportFromClimsoft.RemoveParameterByName("unstack_data")
        End If
    End Sub

    Private Sub ucrControlsContents_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStations.ControlContentsChanged, ucrReceiverStnElements.ControlContentsChanged, ucrChkStackData.ControlContentsChanged
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

    Private Sub ucrChkDateRange_ControlValueChanged(ucrChangedControl As ucrCore)
        'this forces the date pickers to write default parameter values to the Rfunction.
        'date picker controls have a problem of default date. 
        'its not set by default until the user changes selected date
        'todo. in future, this may not be needed
        If ucrChkObsDate.Checked Then
            ucrDtpObsEndDate.OnControlValueChanged()
            ucrDtpObStartdate.OnControlValueChanged()
        End If
    End Sub
End Class
