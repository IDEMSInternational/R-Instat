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
Public Class sdgImportfromRDBMS
    Private clsRDatabaseConnect As RFunction
    Private clsRDatabaseDisconnect As RFunction

    Private bFirstLoad As Boolean = True
    Private bConnected As Boolean

    Private Sub sdgImportFromClimSoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        SetRCodeForControls(False)
        'could have been connected through the wizard. So check here
        bConnected = IsConnectionIsActive()
        UpdateConnectionAndControlsState()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()


        ucrCboType.SetDropDownStyleAsNonEditable()
        ucrCboType.bAllowNonConditionValues = False
        ucrCboType.AddQuotesIfUnrecognised = False
        ucrCboType.SetParameter(New RParameter("drv", 0))

        'database names
        ucrCboName.bAllowNonConditionValues = True
        ucrCboName.SetParameter(New RParameter("dbname", 1))

        'username
        ucrTxtUserName.SetParameter(New RParameter("user", 2))

        'host e.g 127.0.0.1
        ucrTxtHost.SetParameter(New RParameter("host", 3))

        'ports
        ucrCboPort.AddQuotesIfUnrecognised = False
        ucrCboPort.bAllowNonConditionValues = True
        ucrCboPort.SetParameter(New RParameter("port", 4))
        ucrCboPort.SetValidationTypeAsNumeric(dcmMin:=0)

        chkRememberCredentials.Enabled = False

    End Sub

    Public Sub SetDatabaseOptions(bImportFromClimsoft)

        If bFirstLoad Then
            InitialiseDialog()
        End If

        Dim dctDatabaseDriver As New Dictionary(Of String, String)

        'clear all the option items
        ucrCboType.cboInput.Items.Clear()
        ucrCboName.cboInput.Items.Clear()
        ucrCboPort.cboInput.Items.Clear()


        'if launched as climsoft connection subdialog the add the climsoft databases and ports as options
        If bImportFromClimsoft AndAlso ucrCboName.GetItemsCount < 1 Then
            Dim dctDatabaseNames As New Dictionary(Of String, String)
            dctDatabaseNames.Add("mariadb_climsoft_db_v4", Chr(34) & "mariadb_climsoft_db_v4" & Chr(34))
            dctDatabaseNames.Add("mariadb_climsoft_test_db_v4", Chr(34) & "mariadb_climsoft_test_db_v4" & Chr(34))

            ucrCboName.SetItems(dctDatabaseNames)

            Dim dctPorts As New Dictionary(Of String, String)
            dctPorts.Add("3308", "3308")
            dctPorts.Add("3306", "3306")
            ucrCboPort.SetItems(dctPorts)

            dctDatabaseDriver.Add("MYSQL", "RMySQL::MySQL()")
        Else
            dctDatabaseDriver.Add("MYSQL", "RMySQL::MySQL()")
            dctDatabaseDriver.Add("POSTGRES", "RPostgres::Postgres()")
        End If

        ucrCboType.SetItems(dctDatabaseDriver)

    End Sub

    Private Sub SetDefaults()
        clsRDatabaseConnect = New RFunction
        clsRDatabaseDisconnect = New RFunction

        'set database connect R command and it's parameter values(from previous set values if available)
        clsRDatabaseConnect.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$database_connect")
        'clsRDatabaseConnect.AddParameter("dbname", frmMain.clsInstatOptions.strClimsoftDatabaseName, iPosition:=0)
        'clsRDatabaseConnect.AddParameter("host", frmMain.clsInstatOptions.strClimsoftHost, iPosition:=1)
        'clsRDatabaseConnect.AddParameter("port", frmMain.clsInstatOptions.strClimsoftPort, iPosition:=2)
        'clsRDatabaseConnect.AddParameter("user", frmMain.clsInstatOptions.strClimsoftUsername, iPosition:=3)

        'set database disconnect R command
        clsRDatabaseDisconnect.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$database_disconnect")

        bConnected = IsConnectionIsActive()
        UpdateConnectionAndControlsState()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrCboType.SetRCode(clsRDatabaseConnect, bReset)
        ucrCboName.SetRCode(clsRDatabaseConnect, bReset)
        ucrTxtHost.SetRCode(clsRDatabaseConnect, bReset)
        ucrCboPort.SetRCode(clsRDatabaseConnect, bReset)
        ucrTxtUserName.SetRCode(clsRDatabaseConnect, bReset)
    End Sub

    Private Sub UpdateConnectionAndControlsState()
        Dim bEnableControls As Boolean
        If bConnected Then
            lblConnection.Text = GetTranslation("Connected")
            lblConnection.ForeColor = Color.Green
            btnConnect.Text = GetTranslation("Disconnect")
            'disable all other controls. Entry allowed only when there is no existing connection
            bEnableControls = False
        Else
            lblConnection.Text = GetTranslation("No Connection")
            lblConnection.ForeColor = Color.Red
            btnConnect.Text = GetTranslation("Connect")
            'enable all other controls to allow entry of connection details
            bEnableControls = True
        End If

        'enable/disable all other controls to allow entry of connection details
        ucrCboType.Enabled = bEnableControls
        ucrCboName.Enabled = bEnableControls
        ucrCboPort.Enabled = bEnableControls
        ucrTxtHost.Enabled = bEnableControls
        ucrTxtUserName.Enabled = bEnableControls
        'chkRememberCredentials.Enabled = bEnableControls
    End Sub

    ''' <summary>
    ''' checks if there is an active database connection
    ''' </summary>
    ''' <returns>true if connected to database, false if not</returns>
    Public Function IsConnectionIsActive() As Boolean
        Dim clsRHasConnection As New RFunction
        Dim expTemp As SymbolicExpression
        'set has connection R command
        clsRHasConnection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$has_database_connection")
        expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsRHasConnection.ToScript())
        Return (Not expTemp.Type = Internals.SymbolicExpressionType.Null) AndAlso expTemp.AsLogical(0)
    End Function

    Private Sub Disconnect()
        frmMain.clsRLink.RunScript(clsRDatabaseDisconnect.ToScript(), strComment:="Disconnect database connection.", bSeparateThread:=False, bShowWaitDialogOverride:=False)
        bConnected = False
    End Sub

    ''' <summary>
    '''  will display an R password input prompt, to enter password and attempt connecting to database
    ''' </summary>
    Private Sub Connect()
        frmMain.clsRLink.RunScript(clsRDatabaseConnect.ToScript(), strComment:="Connect database connection.", bSeparateThread:=False, bShowWaitDialogOverride:=False)
        bConnected = IsConnectionIsActive()
    End Sub

    Public Sub Reset()
        If Not bFirstLoad Then
            Disconnect()
            SetDefaults()
            SetRCodeForControls(True)
        End If
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        btnConnect.Enabled = False 'temporary disable 
        'if was already connected, then user action is meant to disconnect else, try connecting to database
        If bConnected Then
            Disconnect()
        Else
            Connect()
        End If
        UpdateConnectionAndControlsState()
        btnConnect.Enabled = True

        If chkRememberCredentials.Checked AndAlso bConnected Then
            'save credentials
            frmMain.clsInstatOptions.SetClimsoftDatabaseName(ucrCboType.GetText())
            frmMain.clsInstatOptions.SetClimsoftDatabaseName(ucrCboName.GetText())
            frmMain.clsInstatOptions.SetClimsoftHost(ucrTxtHost.GetText())
            frmMain.clsInstatOptions.SetClimsoftPort(ucrCboPort.GetText())
            frmMain.clsInstatOptions.SetClimsoftUsername(ucrTxtUserName.GetText())
        End If
    End Sub

    Private Sub ucrControlsContents_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrCboType.ControlContentsChanged, ucrCboName.ControlContentsChanged, ucrTxtHost.ControlContentsChanged, ucrCboPort.ControlContentsChanged, ucrTxtUserName.ControlContentsChanged
        'if not already connected, check if it's valid to attempt connecting to database
        If bConnected Then
            btnConnect.Enabled = True
        Else
            btnConnect.Enabled = Not ucrCboType.IsEmpty AndAlso Not ucrTxtHost.IsEmpty AndAlso Not ucrTxtUserName.IsEmpty AndAlso Not ucrCboPort.IsEmpty AndAlso Not ucrCboName.IsEmpty
        End If
    End Sub
End Class