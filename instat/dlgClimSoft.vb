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
        'autoTranslate(Me) ' temporary commented, affects the connected text by overwriting on it
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 329

        dctStationColumns.Add("Station IDs", Chr(34) & "stationId" & Chr(34))
        dctStationColumns.Add("Station Names", Chr(34) & "stationName" & Chr(34))
        ucrComboBoxStations.SetParameter(New RParameter("stationfiltercolumn", 0))
        ucrComboBoxStations.SetItems(dctStationColumns)
        ucrComboBoxStations.SetRDefault(Chr(34) & "stationId" & Chr(34))
        ucrComboBoxStations.bAllowNonConditionValues = False
        ucrComboBoxStations.SetDropDownStyleAsNonEditable()

        ucrReceiverMultipleStations.SetParameter(New RParameter("stations", 1))
        ucrReceiverMultipleStations.SetParameterIsString()
        ucrReceiverMultipleStations.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleStations.SetItemType("database_variables")
        ucrReceiverMultipleStations.strSelectorHeading = "Stations"
        ucrReceiverMultipleElements.SetLinkedDisplayControl(lblStations)

        dctElementsColumns.Add("Element IDs", Chr(34) & "elementId" & Chr(34))
        dctElementsColumns.Add("Element Names", Chr(34) & "elementName" & Chr(34))
        dctElementsColumns.Add("Element Abbreviation", Chr(34) & "abbreviation" & Chr(34))
        dctElementsColumns.Add("Element Types", Chr(34) & "elementtype" & Chr(34))
        ucrComboBoxElements.SetParameter(New RParameter("elementfiltercolumn", 2))
        ucrComboBoxElements.SetItems(dctElementsColumns)
        ucrComboBoxElements.SetRDefault(Chr(34) & "elementId" & Chr(34))
        ucrComboBoxElements.bAllowNonConditionValues = False
        ucrComboBoxElements.SetDropDownStyleAsNonEditable()

        ucrReceiverMultipleElements.SetParameter(New RParameter("elements", 3))
        ucrReceiverMultipleElements.SetParameterIsString()
        ucrReceiverMultipleElements.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleElements.SetItemType("database_variables")
        ucrReceiverMultipleElements.strSelectorHeading = "Elements"
        ucrReceiverMultipleElements.SetLinkedDisplayControl(lblElements)

        ucrChkData.SetParameter(New RParameter("include_observation_data", 4))
        ucrChkData.Text = "Include Observation Data"
        ucrChkData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkData.SetRDefault("FALSE")

        ucrChkElements.SetParameter(New RParameter("include_elements_info", 5))
        ucrChkElements.Text = "Include Elements Metadata Data"
        ucrChkElements.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkElements.SetRDefault("FALSE")

        ucrChkUnstackData.Text = "Unstack Data"
        'ucrChkUnstackData.Enabled = False
        ucrChkUnstackData.Visible = False

        ucrChkDateRange.Text = "Select Date Range"
        ucrChkDateRange.SetDefaultState(False) 'todo delete this

        ucrDtpStartdate.SetParameter(New RParameter("start_date", 6))
        ucrDtpStartdate.SetParameterIsRDate()
        ucrDtpStartdate.SetLinkedDisplayControl(lblStartDate)

        UcrDtpEndDate.SetParameter(New RParameter("end_date", 7))
        UcrDtpEndDate.SetParameterIsRDate()
        UcrDtpEndDate.SetLinkedDisplayControl(lblEndDate)

        ucrChkData.AddToLinkedControls({ucrChkElements, ucrComboBoxElements, ucrReceiverMultipleElements}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'todo. we have a problem with how we will link this control. check on dlgImportDataSet??
        ucrChkData.AddToLinkedControls({ucrChkDateRange}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkDateRange.AddToLinkedControls({ucrDtpStartdate, UcrDtpEndDate}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        clsRImportFromClimsoft = New RFunction

        clsRImportFromClimsoft.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_climsoft")
        'ucrBase.clsRsyntax.AddParameter("include_observation_data", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportFromClimsoft)

        'frmMain.clsRLink.RunScript(clsRDatabaseDisconnect.ToScript(), strComment:="Disconnect database connection.")

        ucrReceiverMultipleStations.SetMeAsReceiver()
        ucrSelectorForClimSoft.Reset()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        'todo. include also validation of the dates
        If (Not ucrReceiverMultipleStations.IsEmpty() AndAlso Not ucrChkData.Checked) OrElse (Not ucrReceiverMultipleElements.IsEmpty() AndAlso ucrChkData.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub btnEstablishConnection_Click(sender As Object, e As EventArgs) Handles btnEstablishConnection.Click
        sdgImportFromClimSoft.ShowDialog()
        If sdgImportFromClimSoft.ConnectionActive() Then
            lblConnection.Text = "Connected"
            lblConnection.ForeColor = Color.Green
        Else
            lblConnection.Text = "No Connection"
            lblConnection.ForeColor = Color.Red
        End If
        ucrReceiverMultipleStations.Clear()
        ucrReceiverMultipleStations.SetMeAsReceiver()
    End Sub

    Private Sub SetStationsReceiverQuery()
        If dctStationColumns.Count < 1 Then
            Exit Sub
        End If

        'sql query to get station values of the selected column from station table
        Dim strQuery As String
        strQuery = "SELECT " & dctStationColumns.Item(ucrComboBoxStations.GetText).Trim("""") & " FROM station;"

        If ucrReceiverMultipleStations.strDatabaseQuery = strQuery Then
            Exit Sub
        End If
        ucrReceiverMultipleStations.Clear()
        ucrReceiverMultipleStations.strDatabaseQuery = strQuery
    End Sub

    Private Sub SetElementsRecieverQuery()
        If dctElementsColumns.Count < 1 Then
            Exit Sub
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
            Exit Sub
        End If
        ucrReceiverMultipleElements.Clear()
        ucrReceiverMultipleElements.strDatabaseQuery = strQuery
    End Sub

    Private Sub ucrComboBoxStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrComboBoxStations.ControlValueChanged
        SetStationsReceiverQuery()
        ucrReceiverMultipleStations.SetMeAsReceiver() 'will also execute the sql query
    End Sub

    Private Sub ucrComboBoxElements_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrComboBoxElements.ControlValueChanged
        SetElementsRecieverQuery()
        ucrReceiverMultipleElements.SetMeAsReceiver() 'will also execute sql the query
    End Sub


    Private Sub ucrReceiverMultipleStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleStations.ControlValueChanged
        If bIgnoreReceiverChanges Then
            Exit Sub
        End If
        SetElementsRecieverQuery()
    End Sub

    Private Sub ucrControlsContents_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleStations.ControlContentsChanged, ucrReceiverMultipleElements.ControlContentsChanged, ucrChkData.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkObservationData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkData.ControlValueChanged
        If ucrChkData.Checked Then
            ucrReceiverMultipleElements.SetMeAsReceiver()
        Else
            ucrReceiverMultipleStations.SetMeAsReceiver()
        End If
    End Sub


End Class
