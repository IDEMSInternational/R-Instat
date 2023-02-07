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
Public Class dlgImportFromPostgres
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRImportFromDatabase As New RFunction

    'the 2 dictionaries hold data for the station and elements comboboxes
    'As of 28th August 2020, there is no direct way of getting the selected value from the custom combobox
    'these are declared here to be used in getting the selected value
    Private dctDatabaseColumns As New Dictionary(Of String, String)
    Private dctColumns As New Dictionary(Of String, String)

    'flag used by elements receiver to determine when not to clear itself and change its sql query 
    'useful when form is reloaded, to let the elements reciever retain the elements selected
    Private bIgnoreReceiverChanges As Boolean = False

    Private Sub dlgImportFromPostgres_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        dctDatabaseColumns.Add("Database IDs", Chr(34) & "databaseId" & Chr(34))
        dctDatabaseColumns.Add("Database Names", Chr(34) & "databaseName" & Chr(34))
        dctDatabaseColumns.Add("Database Qualifiers", Chr(34) & "qualifier" & Chr(34))
        ucrComboBoxDatabase.SetParameter(New RParameter("databasefiltercolumn", 0))
        ucrComboBoxDatabase.SetItems(dctDatabaseColumns)
        ucrComboBoxDatabase.SetRDefault(Chr(34) & "databaseId" & Chr(34))
        ucrComboBoxDatabase.bAllowNonConditionValues = False
        ucrComboBoxDatabase.SetDropDownStyleAsNonEditable()

        'stations receiver
        ucrReceiverDatabase.SetParameter(New RParameter("database", 1))
        ucrReceiverDatabase.SetParameterIsString()
        ucrReceiverDatabase.Selector = ucrSelectorForDatabase
        ucrReceiverDatabase.SetItemType("database_variables")
        ucrReceiverDatabase.strSelectorHeading = "Database"
        ucrReceiverDatabase.SetLinkedDisplayControl(lblDatabase)

        'elements combobox
        dctColumns.Add("Column IDs", Chr(34) & "columnId" & Chr(34))
        dctColumns.Add("Column Names", Chr(34) & "columnName" & Chr(34))
        dctColumns.Add("Column Abbreviation", Chr(34) & "abbreviation" & Chr(34))
        dctColumns.Add("Column Types", Chr(34) & "columntype" & Chr(34))
        ucrComboBoxColumns.SetParameter(New RParameter("columnfiltercolumn", 2))
        ucrComboBoxColumns.SetItems(dctColumns)
        ucrComboBoxColumns.SetRDefault(Chr(34) & "columnId" & Chr(34))
        ucrComboBoxColumns.bAllowNonConditionValues = False
        ucrComboBoxColumns.SetDropDownStyleAsNonEditable()

        'elements receiver
        ucrReceiverMultipleColumns.SetParameter(New RParameter("elements", 3))
        ucrReceiverMultipleColumns.SetParameterIsString()
        ucrReceiverMultipleColumns.Selector = ucrSelectorForDatabase
        ucrReceiverMultipleColumns.SetItemType("database_variables")
        ucrReceiverMultipleColumns.strSelectorHeading = "Elements"
        ucrReceiverMultipleColumns.SetLinkedDisplayControl(lblColumns)

        ucrBase.clsRsyntax.bSeparateThread = False
        ucrBase.clsRsyntax.bShowWaitDialogOverride = False
    End Sub

    Private Sub SetDefaults()
        clsRImportFromDatabase = New RFunction
        clsRImportFromDatabase.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_database")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportFromDatabase)

        ucrReceiverDatabase.SetMeAsReceiver()
        ucrSelectorForDatabase.Reset()
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled((Not ucrReceiverDatabase.IsEmpty()) OrElse (Not ucrReceiverMultipleColumns.IsEmpty()))
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrComboBoxDatabase.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverDatabase.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrComboBoxColumns.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverMultipleColumns.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
        sdgImportfromRDBMS.ShowDialog()
        CheckAndUpdateConnectionStatus()
        ucrReceiverDatabase.Clear()
        ucrReceiverDatabase.SetMeAsReceiver()
    End Sub

    ''' <summary>
    ''' constructs and sets the stations reciver SQL query
    ''' </summary>
    ''' <returns>returns true if receivers query was changed</returns>
    Private Function SetStationsReceiverQuery() As Boolean
        If dctDatabaseColumns.Count < 1 Then
            Return False
        End If

        'sql query to get station values of the selected column from station table
        Dim strQuery As String
        Dim strSelectedColumn As String = dctDatabaseColumns.Item(ucrComboBoxDatabase.GetText).Trim("""")

        strQuery = "SELECT DISTINCT " & strSelectedColumn & " FROM database WHERE " & strSelectedColumn & " IS NOT NULL AND " & strSelectedColumn & " <> '';"
        If ucrReceiverDatabase.strDatabaseQuery = strQuery Then
            Return False
        End If
        ucrReceiverDatabase.Clear()
        ucrReceiverDatabase.strDatabaseQuery = strQuery
        Return True
    End Function

    ''' <summary>
    ''' constructs and sets elements receiver SQL query
    ''' </summary>
    ''' <returns>returns true if receivers query was changed</returns>
    Private Function SetElementsRecieverQuery() As Boolean
        If dctColumns.Count < 1 Then
            Return False
        End If

        'sql query to get distinct element values of the selected column(obselement TABLE COLUMN) from the observationfinal table
        Dim strQuery As String
        strQuery = "SELECT DISTINCT obscolumn." & dctColumns.Item(ucrComboBoxColumns.GetText).Trim("""") &
            " FROM observationfinal" &
            " INNER JOIN obselement ON observationfinal.describedBy = obscolumn.columnId" &
            " INNER JOIN station ON observationfinal.recordedFrom = database.databaseId"
        'if stations have been specified, then get elements for those stations only
        If Not ucrReceiverDatabase.IsEmpty Then
            strQuery = strQuery & " WHERE " & "station." & dctDatabaseColumns.Item(ucrComboBoxDatabase.GetText).Trim("""") & " IN (" &
                String.Join(",", ucrReceiverDatabase.GetVariableNameslist(strQuotes:=Chr(39))) & ")"
        End If
        strQuery &= ";"

        If ucrReceiverMultipleColumns.strDatabaseQuery = strQuery Then
            Return False
        End If
        ucrReceiverMultipleColumns.Clear()
        ucrReceiverMultipleColumns.strDatabaseQuery = strQuery
        Return True
    End Function

    Private Sub ucrComboBoxDatabase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrComboBoxDatabase.ControlValueChanged
        If SetStationsReceiverQuery() Then
            'set as selected receiver. will also execute the receiver's sql query
            ucrReceiverDatabase.SetMeAsReceiver()
        End If
    End Sub
    Private Sub ucrReceiverDatabase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDatabase.ControlValueChanged
        If Not bIgnoreReceiverChanges Then
            SetElementsRecieverQuery()
        End If
    End Sub

    Private Sub ucrComboBoxColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrComboBoxColumns.ControlValueChanged
        If SetElementsRecieverQuery() Then
            'set as selected receiver. will also execute receiver's sql the query
            ucrReceiverMultipleColumns.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrControlsContents_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDatabase.ControlContentsChanged, ucrReceiverMultipleColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub CheckAndUpdateConnectionStatus()
        If sdgImportfromRDBMS.IsConnectionIsActive() Then
            lblConnection.Text = "Connected"
            lblConnection.ForeColor = Color.Green
        Else
            lblConnection.Text = "No Connection"
            lblConnection.ForeColor = Color.Red
            ucrReceiverDatabase.Clear()
        End If
        autoTranslate(Me)
    End Sub
End Class