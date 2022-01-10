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
        ucrReceiverMultipleStations.SetParameter(New RParameter("stations", 1))
        ucrReceiverMultipleStations.SetParameterIsString()
        ucrReceiverMultipleStations.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleStations.SetItemType("database_variables")
        ucrReceiverMultipleStations.strSelectorHeading = "Stations"
        ucrReceiverMultipleStations.SetLinkedDisplayControl(lblStations)

        'elements combobox
        dctElementsColumns.Add("Element IDs", Chr(34) & "elementId" & Chr(34))
        dctElementsColumns.Add("Element Names", Chr(34) & "elementName" & Chr(34))
        dctElementsColumns.Add("Element Abbreviation", Chr(34) & "abbreviation" & Chr(34))
        dctElementsColumns.Add("Element Types", Chr(34) & "elementtype" & Chr(34))
        ucrComboBoxElements.SetParameter(New RParameter("elementfiltercolumn", 2))
        ucrComboBoxElements.SetItems(dctElementsColumns)
        ucrComboBoxElements.SetRDefault(Chr(34) & "elementId" & Chr(34))
        ucrComboBoxElements.bAllowNonConditionValues = False
        ucrComboBoxElements.SetDropDownStyleAsNonEditable()

        'elements receiver
        ucrReceiverMultipleElements.SetParameter(New RParameter("elements", 3))
        ucrReceiverMultipleElements.SetParameterIsString()
        ucrReceiverMultipleElements.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleElements.SetItemType("database_variables")
        ucrReceiverMultipleElements.strSelectorHeading = "Elements"
        ucrReceiverMultipleElements.SetLinkedDisplayControl(lblElements)

        'include observation data checkbox
        ucrChkObservationData.SetText("Include Observation Data")
        ucrChkObservationData.SetParameter(New RParameter("include_observation_data", 4))
        ucrChkObservationData.SetRDefault("FALSE")

        'include flags data checkbox
        ucrChkFlagsData.SetText("Include Observation Flags")
        ucrChkFlagsData.SetParameter(New RParameter("include_observation_flags", 5))
        ucrChkFlagsData.SetRDefault("FALSE")

        'include Unstack data checkbox. 
        'parameter attached to it is determined by elements receiver no. of contents. Thus not directly set by the control 
        ucrChkUnstackData.SetText("Unstack Data")
        'ucrChkUnstackData.Checked = True

        'include elements info checkbox
        ucrChkElements.SetText("Include Elements Information")
        ucrChkElements.SetParameter(New RParameter("include_elements_info", 7))
        ucrChkElements.SetRDefault("FALSE")

        'date range checkbox
        ucrChkDateRange.SetText("Select Date Range")

        'start date datepicker
        ucrDtpStartdate.SetParameter(New RParameter("start_date", 8))
        ucrDtpStartdate.SetParameterIsRDate()
        ucrDtpStartdate.SetLinkedDisplayControl(lblStartDate)

        'end date datepicker
        ucrDtpEndDate.SetParameter(New RParameter("end_date", 9))
        ucrDtpEndDate.SetParameterIsRDate()
        ucrDtpEndDate.SetLinkedDisplayControl(lblEndDate)

        'linking observation data related controls  to include observation data checkbox
        ucrChkObservationData.AddToLinkedControls({ucrChkFlagsData, ucrChkUnstackData, ucrChkElements, ucrComboBoxElements, ucrReceiverMultipleElements}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'link date range checkbox
        ucrChkObservationData.AddToLinkedControls({ucrChkDateRange}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'linking date pickers to date range checkbox
        ucrChkDateRange.AddToLinkedControls({ucrDtpStartdate, ucrDtpEndDate}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

    Private Sub SetDefaults()
        clsRImportFromClimsoft = New RFunction
        clsRImportFromClimsoft.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_climsoft")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportFromClimsoft)

        ucrReceiverMultipleStations.SetMeAsReceiver()
        ucrSelectorForClimSoft.Reset()
        ucrChkUnstackData.Checked = True
        ucrChkDateRange.Checked = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrComboBoxStations.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverMultipleStations.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrComboBoxElements.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverMultipleElements.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkObservationData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkFlagsData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkElements.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrDtpStartdate.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrDtpEndDate.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled((Not ucrReceiverMultipleStations.IsEmpty() AndAlso Not ucrChkObservationData.Checked) OrElse (Not ucrReceiverMultipleElements.IsEmpty() AndAlso ucrChkObservationData.Checked))
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        sdgImportFromClimSoft.Reset()
        CheckAndUpdateConnectionStatus()
        TestOKEnabled()
    End Sub

    Private Sub btnEstablishConnection_Click(sender As Object, e As EventArgs) Handles cmdEstablishConnection.Click
        'shows the database connect sub dialog and checks if connection has been established
        sdgImportFromClimSoft.ShowDialog()
        CheckAndUpdateConnectionStatus()
        ucrReceiverMultipleStations.Clear()
        ucrReceiverMultipleStations.SetMeAsReceiver()
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
        If ucrReceiverMultipleStations.strDatabaseQuery = strQuery Then
            Return False
        End If
        ucrReceiverMultipleStations.Clear()
        ucrReceiverMultipleStations.strDatabaseQuery = strQuery
        Return True
    End Function

    ''' <summary>
    ''' constructs and sets elements receiver SQL query
    ''' </summary>
    ''' <returns>returns true if receivers query was changed</returns>
    Private Function SetElementsRecieverQuery() As Boolean
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
        If Not ucrReceiverMultipleStations.IsEmpty Then
            strQuery = strQuery & " WHERE " & "station." & dctStationColumns.Item(ucrComboBoxStations.GetText).Trim("""") & " IN (" &
                String.Join(",", ucrReceiverMultipleStations.GetVariableNamesList(strQuotes:=Chr(39))) & ")"
        End If
        strQuery &= ";"

        If ucrReceiverMultipleElements.strDatabaseQuery = strQuery Then
            Return False
        End If
        ucrReceiverMultipleElements.Clear()
        ucrReceiverMultipleElements.strDatabaseQuery = strQuery
        Return True
    End Function

    Private Sub ucrComboBoxStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrComboBoxStations.ControlValueChanged
        If SetStationsReceiverQuery() Then
            'set as selected receiver. will also execute the receiver's sql query
            ucrReceiverMultipleStations.SetMeAsReceiver()
        End If
    End Sub
    Private Sub ucrReceiverMultipleStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleStations.ControlValueChanged
        If Not bIgnoreReceiverChanges Then
            SetElementsRecieverQuery()
        End If
    End Sub

    Private Sub ucrComboBoxElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrComboBoxElements.ControlValueChanged
        If SetElementsRecieverQuery() Then
            'set as selected receiver. will also execute receiver's sql the query
            ucrReceiverMultipleElements.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrUnstackDataControlsValueChanged_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkUnstackData.ControlValueChanged, ucrReceiverMultipleElements.ControlValueChanged, ucrChkObservationData.ControlValueChanged
        'only change the receivers if the event was raised by ucrChkObservationData checkbox
        If TypeOf ucrChangedControl Is ucrCheck Then
            If ucrChkObservationData.Checked Then
                ucrReceiverMultipleElements.SetMeAsReceiver()
            Else
                ucrReceiverMultipleStations.SetMeAsReceiver()
            End If
        End If

        'unstack observation data only when more than 1 element is selected
        If ucrChkObservationData.Checked AndAlso ucrReceiverMultipleElements.GetVariableNamesAsList.Count > 1 Then
            ucrChkUnstackData.Enabled = True
            clsRImportFromClimsoft.AddParameter("unstack_data", If(ucrChkUnstackData.Checked, "TRUE", "FALSE"), iPosition:=6)
        Else
            ucrChkUnstackData.Enabled = False
            clsRImportFromClimsoft.RemoveParameterByName("unstack_data")
        End If
    End Sub

    Private Sub ucrControlsContents_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleStations.ControlContentsChanged, ucrReceiverMultipleElements.ControlContentsChanged, ucrChkObservationData.ControlContentsChanged, ucrChkUnstackData.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub CheckAndUpdateConnectionStatus()
        If sdgImportFromClimSoft.IsConnectionIsActive() Then
            lblConnection.Text = "Connected"
            lblConnection.ForeColor = Color.Green
        Else
            lblConnection.Text = "No Connection"
            lblConnection.ForeColor = Color.Red
            ucrReceiverMultipleStations.Clear()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub ucrChkDateRange_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDateRange.ControlValueChanged
        'this forces the date pickers to write default parameter values to the Rfunction.
        'date picker controls have a problem of default date. 
        'its not set by default until the user changes selected date
        'todo. in future, this may not be needed
        If ucrChkDateRange.Checked Then
            ucrDtpEndDate.OnControlValueChanged()
            ucrDtpStartdate.OnControlValueChanged()
        End If
    End Sub
End Class
