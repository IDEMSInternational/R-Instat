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

        'table receiver
        ucrReceiverTable.SetParameter(New RParameter("Table", 1))
        ucrReceiverTable.SetParameterIsString()
        ucrReceiverTable.Selector = ucrSelectorForDatabase
        ucrReceiverTable.SetItemType("database_variables")
        ucrReceiverTable.strSelectorHeading = "Tables"
        ucrReceiverTable.SetLinkedDisplayControl(lblTables)

        'elements combobox
        dctColumns.Add("Column IDs", Chr(34) & "columnId" & Chr(34))
        dctColumns.Add("Column Names", Chr(34) & "columnName" & Chr(34))
        dctColumns.Add("Column Abbreviation", Chr(34) & "abbreviation" & Chr(34))
        dctColumns.Add("Column Types", Chr(34) & "columntype" & Chr(34))

        'columns receiver
        ucrReceiverColumns.SetParameter(New RParameter("column", 3))
        ucrReceiverColumns.SetParameterIsString()
        ucrReceiverColumns.Selector = ucrSelectorForDatabase
        ucrReceiverColumns.SetItemType("database_variables")
        ucrReceiverColumns.strSelectorHeading = "Columns"
        ucrReceiverColumns.SetLinkedDisplayControl(lblColumns)

        ucrBase.clsRsyntax.bSeparateThread = False
        ucrBase.clsRsyntax.bShowWaitDialogOverride = False
    End Sub

    Private Sub SetDefaults()
        clsRImportFromDatabase = New RFunction
        clsRImportFromDatabase.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_database")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportFromDatabase)

        ucrReceiverTable.SetMeAsReceiver()
        ucrSelectorForDatabase.Reset()
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled((Not ucrReceiverTable.IsEmpty()) OrElse (Not ucrReceiverColumns.IsEmpty()))
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverTable.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverColumns.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        sdgImportfromRDBMS.Reset()
        CheckAndUpdateConnectionStatus()
        TestOKEnabled()
    End Sub

    Private Sub btnEstablishConnection_Click(sender As Object, e As EventArgs) Handles cmdEstablishConnection.Click
        'shows the database connect sub dialog and checks if connection has been established
        sdgImportfromRDBMS.ShowDialog()
        CheckAndUpdateConnectionStatus()
        ucrReceiverTable.Clear()
        ucrReceiverTable.SetMeAsReceiver()
    End Sub

    ''' <summary>
    ''' constructs and sets the stations reciver SQL query
    ''' </summary>
    ''' <returns>returns true if receivers query was changed</returns>
    'Private Function SetTableReceiverQuery() As Boolean
    'If ucrReceiverTable.IsEmpty Then
    'Return False
    'End If

    '    'sql query to get the selected column from a database table
    '    Dim strQuery As String
    'Dim strSelectedColumn As String = ucrReceiverTable.GetListAsRString

    '    strQuery = "SELECT DISTINCT " & strSelectedColumn & " FROM database WHERE " & strSelectedColumn & " IS NOT NULL AND " & strSelectedColumn & " <> '';"
    '    If ucrReceiverTable.strDatabaseQuery = strQuery Then
    '        Return False
    '    End If
    '    ucrReceiverTable.Clear()
    '    ucrReceiverTable.strDatabaseQuery = strQuery
    '    Return True
    'End Function

    ''' <summary>
    ''' constructs and sets elements receiver SQL query
    ''' </summary>
    ''' <returns>returns true if receivers query was changed</returns>
    'Private Function SetElementsRecieverQuery() As Boolean
    '    If dctColumns.Count < 1 Then
    '        Return False
    '    End If

    '    'sql query to get distinct element values of the selected column(obselement TABLE COLUMN) from the observationfinal table
    '    Dim strQuery As String
    '    strQuery = "SELECT DISTINCT obscolumn." & dctColumns.Item(ucrCboColumns.GetText).Trim("""") &
    '        " FROM observationfinal" &
    '        " INNER JOIN obselement ON observationfinal.describedBy = obscolumn.columnId" &
    '        " INNER JOIN station ON observationfinal.recordedFrom = database.databaseId"
    '    'if stations have been specified, then get elements for those stations only
    '    If Not ucrReceiverTable.IsEmpty Then
    '        strQuery = strQuery & " WHERE " & "station." & dctDatabaseColumns.Item(ucrCboTable.GetText).Trim("""") & " IN (" &
    '            String.Join(",", ucrReceiverTable.GetVariableNameslist(strQuotes:=Chr(39))) & ")"
    '    End If
    '    strQuery &= ";"

    '    If ucrReceiverColumns.strDatabaseQuery = strQuery Then
    '        Return False
    '    End If
    '    ucrReceiverColumns.Clear()
    '    ucrReceiverColumns.strDatabaseQuery = strQuery
    '    Return True
    'End Function

    'Private Sub ucrComboBoxDatabase_ControlValueChanged(ucrChangedControl As ucrCore)
    '    If SetStationsReceiverQuery() Then
    '        'set as selected receiver. will also execute the receiver's sql query
    '        ucrReceiverTable.SetMeAsReceiver()
    '    End If
    'End Sub
    Private Sub ucrReceiverDatabase_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTable.ControlValueChanged
        If Not bIgnoreReceiverChanges Then
            'SetElementsRecieverQuery()
        End If
    End Sub

    'Private Sub ucrComboBoxColumns_ControlValueChanged(ucrChangedControl As ucrCore)
    '    If SetElementsRecieverQuery() Then
    '        'set as selected receiver. will also execute receiver's sql the query
    '        ucrReceiverColumns.SetMeAsReceiver()
    '    End If
    'End Sub

    Private Sub ucrControlsContents_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTable.ControlContentsChanged, ucrReceiverColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub CheckAndUpdateConnectionStatus()
        If sdgImportfromRDBMS.IsConnectionIsActive() Then
            lblConnection.Text = "Connected"
            lblConnection.ForeColor = Color.Green
        Else
            lblConnection.Text = "No Connection"
            lblConnection.ForeColor = Color.Red
            ucrReceiverTable.Clear()
        End If
        autoTranslate(Me)
    End Sub
End Class