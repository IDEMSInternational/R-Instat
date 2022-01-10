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
Public Class dlgClimsoftWizard
    Private bFirstLoad As Boolean = True

    'used as the R command by the 2 wizard steps. import stations and import elements data
    'this is also be used as the base function
    Private clsRImportFromClimsoft As RFunction

    'holds all the wizard steps objects, used in going from step to step
    Private lstWizardSteps As New List(Of IWizStep)

    'used to track the position of the selected wizard step
    Private iCurrentStep As Integer = 0
    Private Sub dlgClimsoftWizard_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        lstWizardSteps.Item(iCurrentStep).Show()
        autoTranslate(Me)
    End Sub
    Private Sub ucrBase_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
        'todo. temporary. the translation is changing the "Finish" to "Ok"
        ucrBase.cmdOk.Text = "Finish"
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 329
        'currently the ucrButtons doesn't support "wizards". 
        'doing a small modification to extend its modification. 
        'hides the comments checkbox and textbox, changes the Ok button text to finish 
        ucrBase.txtComment.Visible = False
        ucrBase.chkComment.Visible = False
        ucrBase.cmdOk.Text = "Finish"

        'add the 3 objects that represent the steps
        lstWizardSteps.Add(New ConnectDatabase(Me))
        lstWizardSteps.Add(New ImportStations(Me))
        lstWizardSteps.Add(New ImportObservationData(Me))

        'attach statechanged event handler to the steps and hide them
        For Each wizStep As IWizStep In lstWizardSteps
            AddHandler wizStep.StateChanged, AddressOf OnWizStepStateChanged
            wizStep.Hide()
        Next
        'initialise the current step position
        iCurrentStep = 0

    End Sub

    ''' <summary>
    ''' sets the main R command which is is used as the base function
    ''' </summary>
    Private Sub SetDefaults()
        clsRImportFromClimsoft = New RFunction
        clsRImportFromClimsoft.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_climsoft")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportFromClimsoft)
    End Sub

    ''' <summary>
    ''' event handler called when there is changes to the state of any wizard step
    ''' </summary>
    ''' <param name="wizStep"></param>
    Private Sub OnWizStepStateChanged(wizStep As IWizStep)
        TestOkAndChangeBaseButtonsState()
    End Sub

    ''' <summary>
    ''' changes the state of the base buttons and validates navigation from one wizard step to another
    ''' </summary>
    Private Sub TestOkAndChangeBaseButtonsState()
        btnBack.Enabled = False
        btnNext.Enabled = False
        ucrBase.OKEnabled(False)

        btnBack.Enabled = iCurrentStep > 0

        If Not lstWizardSteps.Item(iCurrentStep).CanMoveNext Then
            Exit Sub
        End If

        If iCurrentStep < lstWizardSteps.Count - 1 Then
            btnNext.Enabled = True
        Else
            btnNext.Enabled = False
            ucrBase.OKEnabled(True)
        End If

        If TypeOf lstWizardSteps.Item(iCurrentStep) Is ImportStations Then
            'if indicated not to import observation data in the import stations wizard step
            'then just enable the finish button and disable the Next button
            If Not DirectCast(lstWizardSteps.Item(iCurrentStep), ImportStations).IncludeObservationData Then
                btnNext.Enabled = False
                ucrBase.OKEnabled(True)
            End If
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        'on button back click hide current selected wizard step, and show the previous one
        lstWizardSteps.Item(iCurrentStep).Hide()
        iCurrentStep = iCurrentStep - 1
        lstWizardSteps.Item(iCurrentStep).Show()
        TestOkAndChangeBaseButtonsState()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'on button next click hide current selected wizard step, and show the next one
        lstWizardSteps.Item(iCurrentStep).Hide()
        iCurrentStep = iCurrentStep + 1

        'if now selected wizard step is import observation data, 
        'then set selected stations info to be used by the wizard step
        If TypeOf lstWizardSteps.Item(iCurrentStep) Is ImportObservationData Then
            Dim strStationColumn As String = DirectCast(lstWizardSteps.Item(iCurrentStep - 1), ImportStations).GetSelectedStationColumn
            Dim arrStations As String() = DirectCast(lstWizardSteps.Item(iCurrentStep - 1), ImportStations).GetSelectedStations
            DirectCast(lstWizardSteps.Item(iCurrentStep), ImportObservationData).SetStations(strStationColumn, arrStations)
        End If

        lstWizardSteps.Item(iCurrentStep).Show()
        TestOkAndChangeBaseButtonsState()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        'on click reset, set defaults(create new base function) 
        'and indicate to all wizard steps to reset on show. Then show the first wizard step
        SetDefaults()
        For Each wizStep As IWizStep In lstWizardSteps
            wizStep.Reset = True
            wizStep.Hide()
        Next
        iCurrentStep = 0
        lstWizardSteps.Item(iCurrentStep).Show()
        TestOkAndChangeBaseButtonsState()
    End Sub

    ''' <summary>
    ''' An interface that all wizard steps must implement. 
    ''' Wizard should be able to show, hide, reset itself and flag its change of state.
    ''' Currently, in this form, every panel represents a wizard step, 
    ''' but in future the panels could be changed to external custom controls used in the form.
    ''' </summary>
    Interface IWizStep
        ''' <summary>
        ''' raised by the wizard step if any of its child controls change their value
        ''' </summary>
        ''' <param name="wizStepChanged"></param>
        Event StateChanged(wizStepChanged As IWizStep)

        'if set true, indicates to the wizard step, to reset to defaults and reset its R code
        Property Reset As Boolean

        ''' <summary>
        ''' shows the wizard step parent control, sets the defaults and R code for its child controls
        ''' </summary>
        Sub Show()

        ''' <summary>
        ''' hides the wizard step parent control and all its child controls
        ''' </summary>
        Sub Hide()

        'indicates that the all the values set in the wizard step are valid and next step can be performed
        Function CanMoveNext() As Boolean
    End Interface

    ''' <summary>
    ''' this class represent the Connect to database wizard step. 
    ''' it only manipulates controls in the panel connect to database of the form.
    ''' doesn't use the base function because its main purpose is simply to connect to the database.
    ''' the controls used also write to its own defined RFunctions
    ''' todo. this class can be refactored to be a custom control in future.
    ''' It could then be used by the sdgImportFromClimSoft subdialog and also here as a wizard step.
    ''' </summary>
    Private Class ConnectDatabase
        Implements IWizStep

        Public Event StateChanged(wizStepChanged As IWizStep) Implements IWizStep.StateChanged
        Public Property Reset As Boolean Implements IWizStep.Reset
        Private parentControls As dlgClimsoftWizard
        Private clsRDatabaseConnect As RFunction
        Private clsRDatabaseDisconnect As RFunction
        Private clsRHasConnection As RFunction
        Private bConnected As Boolean = False

        Public Sub New(_parentControls As dlgClimsoftWizard)
            parentControls = _parentControls
            Reset = True
            InitialiseControls()
            AddHandler parentControls.btnConnect.Click, AddressOf OnBtnConnect_Click
            AddHandler parentControls.ucrTxtUserName.ControlContentsChanged, AddressOf OnUcrControlsContents_ControlValueChanged
            AddHandler parentControls.ucrComboBoxDatabaseName.ControlContentsChanged, AddressOf OnUcrControlsContents_ControlValueChanged
            AddHandler parentControls.ucrTxtHost.ControlContentsChanged, AddressOf OnUcrControlsContents_ControlValueChanged
            AddHandler parentControls.ucrComboBoxPort.ControlContentsChanged, AddressOf OnUcrControlsContents_ControlValueChanged
            AddHandler parentControls.ucrTxtUserName.ControlContentsChanged, AddressOf OnUcrControlsContents_ControlValueChanged
        End Sub

        Private Sub InitialiseControls()
            Dim dctDatabaseNames As New Dictionary(Of String, String)
            Dim dctPorts As New Dictionary(Of String, String)

            'database names
            dctDatabaseNames.Add("mariadb_climsoft_db_v4", Chr(34) & "mariadb_climsoft_db_v4" & Chr(34))
            dctDatabaseNames.Add("mariadb_climsoft_test_db_v4", Chr(34) & "mariadb_climsoft_test_db_v4" & Chr(34))
            parentControls.ucrComboBoxDatabaseName.SetParameter(New RParameter("dbname", 0))
            parentControls.ucrComboBoxDatabaseName.SetItems(dctDatabaseNames)
            parentControls.ucrComboBoxDatabaseName.bAllowNonConditionValues = True

            'host e.g 127.0.0.1
            parentControls.ucrTxtHost.SetParameter(New RParameter("host", 1))

            'ports
            dctPorts.Add("3308", "3308")
            dctPorts.Add("3306", "3306")
            parentControls.ucrComboBoxPort.SetParameter(New RParameter("port", 2))
            parentControls.ucrComboBoxPort.SetItems(dctPorts)
            parentControls.ucrComboBoxPort.AddQuotesIfUnrecognised = False
            parentControls.ucrComboBoxPort.bAllowNonConditionValues = True
            parentControls.ucrComboBoxPort.SetValidationTypeAsNumeric(dcmMin:=0)

            'user name
            parentControls.ucrTxtUserName.SetParameter(New RParameter("user", 3))
        End Sub

        Private Sub UpdateConnectionState()
            If bConnected Then
                parentControls.lblConnection.Text = "Connected"
                parentControls.lblConnection.ForeColor = Color.Green
                parentControls.btnConnect.Text = "Disconnect"

                'disable all other controls. Entry allowed only when there is no existing connection
                parentControls.ucrComboBoxDatabaseName.Enabled = False
                parentControls.ucrComboBoxPort.Enabled = False
                parentControls.ucrTxtHost.Enabled = False
                parentControls.ucrTxtUserName.Enabled = False
                parentControls.chkRememberCredentials.Enabled = False
            Else
                parentControls.lblConnection.Text = "No Connection"
                parentControls.lblConnection.ForeColor = Color.Red
                parentControls.btnConnect.Text = "Connect"

                'enable all other controls to allow entry of connection details
                parentControls.ucrComboBoxDatabaseName.Enabled = True
                parentControls.ucrComboBoxPort.Enabled = True
                parentControls.ucrTxtHost.Enabled = True
                parentControls.ucrTxtUserName.Enabled = True
                parentControls.chkRememberCredentials.Enabled = True
            End If
            autoTranslate(parentControls)
        End Sub

        Private Sub Disconnect()
            frmMain.clsRLink.RunScript(clsRDatabaseDisconnect.ToScript(), strComment:="Disconnect database connection.", bSeparateThread:=False, bShowWaitDialogOverride:=False)
        End Sub

        Private Function CheckIfConnectionIsActive() As Boolean
            Dim expTemp As SymbolicExpression
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsRHasConnection.ToScript())
            Return (Not expTemp.Type = Internals.SymbolicExpressionType.Null) AndAlso expTemp.AsLogical(0)
        End Function

        Private Sub OnBtnConnect_Click()
            parentControls.btnConnect.Enabled = False 'temporary disable 

            'if was already connected, then user action is meant to disconnect else, try connecting to database
            If bConnected Then
                Disconnect()
                bConnected = False
            Else
                'will display an R password input prompt, to enter password and attempt connecting to database
                frmMain.clsRLink.RunScript(clsRDatabaseConnect.ToScript(), strComment:="Connect database connection.", bSeparateThread:=False, bShowWaitDialogOverride:=False)
                bConnected = CheckIfConnectionIsActive()
            End If
            UpdateConnectionState()
            parentControls.btnConnect.Enabled = True

            If parentControls.chkRememberCredentials.Checked AndAlso bConnected Then
                'save credentials before
                frmMain.clsInstatOptions.SetClimsoftDatabaseName(parentControls.ucrComboBoxDatabaseName.GetText())
                frmMain.clsInstatOptions.SetClimsoftHost(parentControls.ucrTxtHost.GetText())
                frmMain.clsInstatOptions.SetClimsoftPort(parentControls.ucrComboBoxPort.GetText())
                frmMain.clsInstatOptions.SetClimsoftUsername(parentControls.ucrTxtUserName.GetText())
            End If

            RaiseEvent StateChanged(Me)
        End Sub

        Private Sub OnUcrControlsContents_ControlValueChanged()
            'if not already connected, check if it's valid to attempt connecting to database
            If bConnected Then
                Exit Sub
            End If
            parentControls.btnConnect.Enabled = Not parentControls.ucrTxtHost.IsEmpty AndAlso Not parentControls.ucrTxtUserName.IsEmpty AndAlso Not parentControls.ucrComboBoxPort.IsEmpty AndAlso Not parentControls.ucrComboBoxDatabaseName.IsEmpty
            RaiseEvent StateChanged(Me)
        End Sub

        Public Sub SetDefaults()
            clsRDatabaseConnect = New RFunction
            clsRDatabaseDisconnect = New RFunction
            clsRHasConnection = New RFunction

            'set database connect R command and it's parameter values(from previous set values if available)
            clsRDatabaseConnect.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$database_connect")
            clsRDatabaseConnect.AddParameter("dbname", frmMain.clsInstatOptions.strClimsoftDatabaseName, iPosition:=0)
            clsRDatabaseConnect.AddParameter("host", frmMain.clsInstatOptions.strClimsoftHost, iPosition:=1)
            clsRDatabaseConnect.AddParameter("port", frmMain.clsInstatOptions.strClimsoftPort, iPosition:=2)
            clsRDatabaseConnect.AddParameter("user", frmMain.clsInstatOptions.strClimsoftUsername, iPosition:=3)

            'set database disconnect R command
            clsRDatabaseDisconnect.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$database_disconnect")

            'set has connection R command
            clsRHasConnection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$has_database_connection")

            'disconnect if was already connected. 
            'If CheckIfConnectionIsActive() Then
            '    Disconnect()
            'End If
            'bConnected = False
            bConnected = CheckIfConnectionIsActive()
            UpdateConnectionState()

        End Sub

        Public Sub SetRCodeForControls(bReset As Boolean)
            parentControls.ucrComboBoxDatabaseName.SetRCode(clsRDatabaseConnect, bReset)
            parentControls.ucrTxtHost.SetRCode(clsRDatabaseConnect, bReset)
            parentControls.ucrComboBoxPort.SetRCode(clsRDatabaseConnect, bReset)
            parentControls.ucrTxtUserName.SetRCode(clsRDatabaseConnect, bReset)
        End Sub

        Public Sub Show() Implements IWizStep.Show
            parentControls.panelConnectDatabase.Visible = True
            If Reset Then
                SetDefaults()
                Disconnect()
            End If
            SetRCodeForControls(Reset)
            Reset = False
            'could have been connected through the main dialog. So check if connection exists here
            bConnected = CheckIfConnectionIsActive()
            UpdateConnectionState()
        End Sub

        Public Sub Hide() Implements IWizStep.Hide
            parentControls.panelConnectDatabase.Visible = False
        End Sub

        Private Function CanMoveNext() As Boolean Implements IWizStep.CanMoveNext
            Return bConnected
        End Function

    End Class

    ''' <summary>
    ''' this class represents the Import Stations wizard step.
    ''' it only manipulates controls in the panel import stations.
    ''' uses the base function of the form and is also used in determining 
    ''' the inputs of the import observation data wizard step
    ''' </summary>
    Private Class ImportStations
        Implements IWizStep
        Public Event StateChanged(wizStepChanged As IWizStep) Implements IWizStep.StateChanged
        Public Property Reset As Boolean Implements IWizStep.Reset
        Private parentControls As dlgClimsoftWizard
        Private dctStationColumns As New Dictionary(Of String, String)

        Public Sub New(_parentControls As dlgClimsoftWizard)
            parentControls = _parentControls
            Reset = True
            InitialiseControls()
            AddHandler parentControls.ucrComboBoxStations.ControlValueChanged, AddressOf OnUcrComboBoxStations_ControlValueChanged
            AddHandler parentControls.ucrReceiverMultipleStations.ControlContentsChanged, AddressOf OnUcrControlsContents_ControlContentsChanged
            AddHandler parentControls.ucrChkObservationData.ControlContentsChanged, AddressOf OnUcrControlsContents_ControlContentsChanged
        End Sub

        Private Sub InitialiseControls()

            'stations combobox
            dctStationColumns.Add("Station IDs", Chr(34) & "stationId" & Chr(34))
            dctStationColumns.Add("Station Names", Chr(34) & "stationName" & Chr(34))
            dctStationColumns.Add("Station Qualifiers", Chr(34) & "qualifier" & Chr(34))
            parentControls.ucrComboBoxStations.SetParameter(New RParameter("stationfiltercolumn", 0))
            parentControls.ucrComboBoxStations.SetItems(dctStationColumns)
            parentControls.ucrComboBoxStations.SetRDefault(Chr(34) & "stationId" & Chr(34))
            parentControls.ucrComboBoxStations.bAllowNonConditionValues = False
            parentControls.ucrComboBoxStations.SetDropDownStyleAsNonEditable()

            'stations receiver
            parentControls.ucrReceiverMultipleStations.SetParameter(New RParameter("stations", 1))
            parentControls.ucrReceiverMultipleStations.SetParameterIsString()
            parentControls.ucrReceiverMultipleStations.Selector = parentControls.ucrSelectorStations
            parentControls.ucrReceiverMultipleStations.SetItemType("database_variables")
            parentControls.ucrReceiverMultipleStations.strSelectorHeading = "Stations"
            parentControls.ucrReceiverMultipleStations.SetLinkedDisplayControl(parentControls.lblStations)

            'include observation data checkbox
            parentControls.ucrChkObservationData.SetParameter(New RParameter("include_observation_data", 4))
            parentControls.ucrChkObservationData.SetText("Include Observation Data")
            parentControls.ucrChkObservationData.SetRDefault("FALSE")

            autoTranslate(parentControls)
        End Sub

        Public Sub SetDefaults()
            parentControls.ucrSelectorStations.Reset()
            parentControls.ucrComboBoxStations.Reset()
            parentControls.ucrReceiverMultipleStations.SetMeAsReceiver()
        End Sub

        Public Sub SetRCodeForControls(bReset As Boolean)
            parentControls.ucrComboBoxStations.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
            parentControls.ucrReceiverMultipleStations.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
            parentControls.ucrChkObservationData.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
        End Sub
        Private Sub OnUcrComboBoxStations_ControlValueChanged()
            If SetStationsReceiverQuery() Then
                'will also execute the receiver's sql query
                parentControls.ucrReceiverMultipleStations.SetMeAsReceiver()
            End If
        End Sub

        Private Sub OnUcrControlsContents_ControlContentsChanged()
            RaiseEvent StateChanged(Me)
        End Sub

        ''' <summary>
        ''' constructs and sets the stations reciver SQL query
        ''' </summary>
        ''' <returns> returns true if receivers query was changed</returns>
        Private Function SetStationsReceiverQuery() As Boolean
            If dctStationColumns.Count < 1 OrElse parentControls.ucrComboBoxStations.IsEmpty Then
                Return False
            End If

            'sql query to get station values of the selected column from station table
            Dim strQuery As String
            Dim strSelectedColumn As String = dctStationColumns.Item(parentControls.ucrComboBoxStations.GetText).Trim("""")
            strQuery = "SELECT DISTINCT " & strSelectedColumn & " FROM station WHERE " & strSelectedColumn & " IS NOT NULL AND " & strSelectedColumn & " <> '';"

            If parentControls.ucrReceiverMultipleStations.strDatabaseQuery = strQuery Then
                Return False
            End If
            parentControls.ucrReceiverMultipleStations.Clear()
            parentControls.ucrReceiverMultipleStations.strDatabaseQuery = strQuery
            Return True
        End Function

        Public Function IncludeObservationData() As Boolean
            Return parentControls.ucrChkObservationData.Checked
        End Function

        Public Function GetSelectedStationColumn() As String
            Return dctStationColumns.Item(parentControls.ucrComboBoxStations.GetText).Trim("""")
        End Function

        Public Function GetSelectedStations() As String()
            Return parentControls.ucrReceiverMultipleStations.GetVariableNamesList(strQuotes:=Chr(39))
        End Function

        Public Sub Show() Implements IWizStep.Show
            parentControls.panelStations.Visible = True

            If Reset Then
                SetDefaults()
                SetRCodeForControls(Reset)
            End If

            Reset = False
        End Sub

        Public Sub Hide() Implements IWizStep.Hide
            parentControls.panelStations.Visible = False
        End Sub

        Private Function CanMoveNext() As Boolean Implements IWizStep.CanMoveNext
            Return Not parentControls.ucrReceiverMultipleStations.IsEmpty()
        End Function

    End Class

    ''' <summary>
    ''' this class represents the import observation data wizard step.
    ''' it only manipulates the controls in the panel import observation data.
    ''' uses the base function of the form
    ''' </summary>
    Private Class ImportObservationData
        Implements IWizStep
        Public Event StateChanged(wizStepChanged As IWizStep) Implements IWizStep.StateChanged
        Public Property Reset As Boolean Implements IWizStep.Reset
        Private parentControls As dlgClimsoftWizard
        Private dctElementsColumns As New Dictionary(Of String, String)
        Private arrStations As String()
        Private strStationColumn As String

        Public Sub New(_parentControls As dlgClimsoftWizard)
            parentControls = _parentControls
            Reset = True
            InitialiseControls()
            AddHandler parentControls.ucrComboBoxElements.ControlValueChanged, AddressOf OnUcrComboBoxElements_ControlValueChanged
            AddHandler parentControls.ucrChkUnstackData.ControlValueChanged, AddressOf OnUcrUnstackDataControls_ControlValueChanged
            AddHandler parentControls.ucrReceiverMultipleElements.ControlValueChanged, AddressOf OnUcrUnstackDataControls_ControlValueChanged
            AddHandler parentControls.ucrReceiverMultipleElements.ControlContentsChanged, AddressOf OnUcrControlsContents_ControlContentsChanged
            AddHandler parentControls.ucrChkDateRange.ControlValueChanged, AddressOf OnUcrChkDateRangeControl_ControlValueChanged
        End Sub

        Private Sub InitialiseControls()
            'elements combobox
            dctElementsColumns.Add("Element IDs", Chr(34) & "elementId" & Chr(34))
            dctElementsColumns.Add("Element Names", Chr(34) & "elementName" & Chr(34))
            dctElementsColumns.Add("Element Abbreviation", Chr(34) & "abbreviation" & Chr(34))
            dctElementsColumns.Add("Element Types", Chr(34) & "elementtype" & Chr(34))
            parentControls.ucrComboBoxElements.SetParameter(New RParameter("elementfiltercolumn", 2))
            parentControls.ucrComboBoxElements.SetItems(dctElementsColumns)
            parentControls.ucrComboBoxElements.SetRDefault(Chr(34) & "elementId" & Chr(34))
            parentControls.ucrComboBoxElements.bAllowNonConditionValues = False
            parentControls.ucrComboBoxElements.SetDropDownStyleAsNonEditable()

            'elements receiver
            parentControls.ucrReceiverMultipleElements.SetParameter(New RParameter("elements", 3))
            parentControls.ucrReceiverMultipleElements.SetParameterIsString()
            parentControls.ucrReceiverMultipleElements.Selector = parentControls.ucrSelectorElements
            parentControls.ucrReceiverMultipleElements.SetItemType("database_variables")
            parentControls.ucrReceiverMultipleElements.strSelectorHeading = "Elements"
            parentControls.ucrReceiverMultipleElements.SetLinkedDisplayControl(parentControls.lblElements)

            'include flags data checkbox
            parentControls.ucrChkFlagsData.SetText("Include Observation Flags")
            parentControls.ucrChkFlagsData.SetParameter(New RParameter("include_observation_flags", 4))
            parentControls.ucrChkFlagsData.SetRDefault("FALSE")

            'include Unstack data checkbox. 
            'parameter attached to it is determined by elements receiver no. of contents. Thus not directly set by the control 
            parentControls.ucrChkUnstackData.SetText("Unstack Data")

            'elements info checkbox
            parentControls.ucrChkElements.SetParameter(New RParameter("include_elements_info", 5))
            parentControls.ucrChkElements.SetText("Include Elements Information")
            parentControls.ucrChkElements.SetRDefault("FALSE")

            'date range checkbox
            parentControls.ucrChkDateRange.SetText("Select Date Range")

            'todo. datepicker control have a problem of default date. 
            'its NOT set by default until the user changes select date

            'start date datepicker
            parentControls.ucrDtpStartdate.SetParameter(New RParameter("start_date", 6))
            parentControls.ucrDtpStartdate.SetParameterIsRDate()
            parentControls.ucrDtpStartdate.SetLinkedDisplayControl(parentControls.lblStartDate)

            'end date datepicker
            parentControls.ucrDtpEndDate.SetParameter(New RParameter("end_date", 7))
            parentControls.ucrDtpEndDate.SetParameterIsRDate()
            parentControls.ucrDtpEndDate.SetLinkedDisplayControl(parentControls.lblEndDate)

            'linking datepickers
            parentControls.ucrChkDateRange.AddToLinkedControls({parentControls.ucrDtpStartdate, parentControls.ucrDtpEndDate}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

            parentControls.ucrChkDateRange.OnControlValueChanged()
            autoTranslate(parentControls)
        End Sub

        Public Sub SetDefaults()
            parentControls.ucrSelectorElements.Reset()
            parentControls.ucrComboBoxElements.Reset()
            SetElementsRecieverQuery()
            parentControls.ucrReceiverMultipleElements.SetMeAsReceiver()
            parentControls.ucrChkUnstackData.Checked = True
            parentControls.ucrChkDateRange.Checked = False
        End Sub

        Public Sub SetRCodeForControls(bReset As Boolean)
            parentControls.ucrComboBoxElements.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
            parentControls.ucrReceiverMultipleElements.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
            parentControls.ucrChkFlagsData.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
            parentControls.ucrChkElements.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
            parentControls.ucrDtpStartdate.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
            parentControls.ucrDtpEndDate.SetRCode(parentControls.clsRImportFromClimsoft, bReset)
        End Sub

        Private Sub OnUcrComboBoxElements_ControlValueChanged()
            If SetElementsRecieverQuery() Then
                'will also execute the receiver's sql query and also raise ControlsContents_ControlContentsChanged
                parentControls.ucrReceiverMultipleElements.SetMeAsReceiver()
            End If
        End Sub

        Private Sub OnUcrUnstackDataControls_ControlValueChanged()
            'unstack observation data only when more than 1 element is selected
            If parentControls.ucrReceiverMultipleElements.GetVariableNamesAsList.Count > 1 Then
                parentControls.ucrChkUnstackData.Enabled = True
                parentControls.clsRImportFromClimsoft.AddParameter("unstack_data", If(parentControls.ucrChkUnstackData.Checked, "TRUE", "FALSE"), iPosition:=6)
            Else
                parentControls.ucrChkUnstackData.Enabled = False
                parentControls.clsRImportFromClimsoft.RemoveParameterByName("unstack_data")
            End If
        End Sub

        Private Sub OnUcrChkDateRangeControl_ControlValueChanged()
            'this forces the date pickers to write default parameter values to the Rfunction.
            'date picker controls have a problem of default date. 
            'its not set by default until the user changes selected date
            'todo. in future, this may not be needed
            If parentControls.ucrChkDateRange.Checked Then
                parentControls.ucrDtpEndDate.OnControlValueChanged()
                parentControls.ucrDtpStartdate.OnControlValueChanged()
            End If
        End Sub

        Private Sub OnUcrControlsContents_ControlContentsChanged()
            RaiseEvent StateChanged(Me)
        End Sub

        Public Sub SetStations(_strStationColumn As String, _arrStations As String())
            strStationColumn = _strStationColumn
            arrStations = _arrStations
        End Sub

        ''' <summary>
        ''' constructs and sets elements receiver SQL query
        ''' </summary>
        ''' <returns>returns true if receivers query was changed</returns>
        Private Function SetElementsRecieverQuery() As Boolean
            If dctElementsColumns.Count < 1 OrElse parentControls.ucrComboBoxElements.IsEmpty Then
                Return False
            End If

            'sql query to get distinct element values of the selected column(obselement TABLE COLUMN) from the observationfinal table
            Dim strQuery As String
            strQuery = "SELECT DISTINCT obselement." & dctElementsColumns.Item(parentControls.ucrComboBoxElements.GetText).Trim("""") &
                " FROM observationfinal" &
                " INNER JOIN obselement ON observationfinal.describedBy = obselement.elementId" &
                " INNER JOIN station ON observationfinal.recordedFrom = station.stationId"
            'if stations have been specified, then get elements for those stations only
            If arrStations IsNot Nothing AndAlso arrStations.Length > 0 Then
                strQuery = strQuery & " WHERE " & "station." & strStationColumn & " IN (" &
                    String.Join(",", arrStations) & ")"
            End If
            strQuery &= ";"

            If parentControls.ucrReceiverMultipleElements.strDatabaseQuery = strQuery Then
                Return False
            End If
            parentControls.ucrReceiverMultipleElements.Clear()
            parentControls.ucrReceiverMultipleElements.strDatabaseQuery = strQuery
            Return True
        End Function

        Public Sub Show() Implements IWizStep.Show
            parentControls.panelElementsData.Visible = True
            If Reset Then
                SetDefaults()
                SetRCodeForControls(Reset)
            Else
                'refresh the receiver query
                If SetElementsRecieverQuery() Then
                    'will also execute the receiver's sql query and also raise ControlsContents_ControlContentsChanged
                    parentControls.ucrReceiverMultipleElements.SetMeAsReceiver()
                End If
            End If
            Reset = False
        End Sub

        Public Sub Hide() Implements IWizStep.Hide
            parentControls.panelElementsData.Visible = False
        End Sub

        Private Function CanMoveNext() As Boolean Implements IWizStep.CanMoveNext
            Return Not parentControls.ucrReceiverMultipleElements.IsEmpty()
        End Function
    End Class


End Class