' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Public Class dlgClimSoft
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRDatabaseConnect As New RFunction
    Public bConnectionActive As Boolean = False
    Private clsRDatabaseDisconnect As New RFunction
    Private clsRImportFromClimsoft As New RFunction
    Private clsHasConnection As New RFunction
    Private bResetSubdialog As Boolean = False

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
        TestOKEnabled()
        ReopenDialog()
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 329

        ucrReceiverMultipleStations.SetParameter(New RParameter("stations", 0))
        ucrReceiverMultipleStations.SetParameterIsString()
        ucrReceiverMultipleStations.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleStations.SetItemType("database_variables")
        ucrReceiverMultipleStations.strDatabaseQuery = "SELECT stationId FROM station;"
        ucrReceiverMultipleStations.bWithQuotes = False

        ucrReceiverMultipleElements.SetParameter(New RParameter("elements", 1))
        ucrReceiverMultipleElements.SetParameterIsString()
        ucrReceiverMultipleElements.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleElements.SetItemType("database_variables")
        ucrReceiverMultipleElements.strDatabaseQuery = "SELECT obselement.elementName FROM obselement,observationfinal WHERE obselement.elementId=observationfinal.describedBy AND observationfinal.recordedFrom in (10202200,10306100) GROUP BY observationfinal.describedBy;"

        ucrChkObservationData.SetText("Observation Data")
        ucrChkObservationData.SetParameter(New RParameter("include_observation_data", 2))
        ucrChkObservationData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkObservationData.SetRDefault("FALSE")

        ucrInputStartDate.SetParameter(New RParameter("start_date", 3))
        ucrInputStartDate.SetLinkedDisplayControl(lblStartDate)
        ttClimsoft.SetToolTip(ucrInputStartDate.txtInput, "yyyy-mm-dd")
        ucrInputEndDate.SetParameter(New RParameter("end_date", 4))
        ucrInputEndDate.SetLinkedDisplayControl(lblEndDate)
        ttClimsoft.SetToolTip(ucrInputEndDate.txtInput, "yyyy-mm-dd")
        ucrChkObservationData.AddToLinkedControls({ucrInputStartDate, ucrInputEndDate}, {True}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverMultipleStations.IsEmpty() AndAlso Not ucrChkObservationData.Checked) OrElse (Not ucrReceiverMultipleStations.IsEmpty() AndAlso Not ucrReceiverMultipleElements.IsEmpty() AndAlso ucrChkObservationData.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub SetDefaults()
        clsRImportFromClimsoft = New RFunction
        ucrSelectorForClimSoft.Reset()
        ucrReceiverMultipleStations.SetMeAsReceiver()
        ucrInputStartDate.SetText("")
        ucrInputEndDate.SetText("")

        clsRDatabaseConnect.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$database_connect")
        clsRDatabaseDisconnect.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$database_disconnect")
        clsRImportFromClimsoft.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_climsoft")
        clsHasConnection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$has_database_connection")
        ucrBase.clsRsyntax.AddParameter("include_observation_data", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsRImportFromClimsoft)
        bResetSubdialog = True
    End Sub

    Private Sub cmdEstablishConnection_Click(sender As Object, e As EventArgs) Handles cmdEstablishConnection.Click

        sdgImportFromClimSoft.SetRDatabaseConnection(clsRDatabaseConnect, clsRDatabaseDisconnect, clsHasConnection, bConnectionActive, bResetSubdialog)
        bResetSubdialog = False
        sdgImportFromClimSoft.ShowDialog()
        SetConnectionActiveStatus(sdgImportFromClimSoft.GetConnectionActiveStatus())
    End Sub

    Private Sub SetConnectionActiveStatus(bCurrentStatus As Boolean)
        bConnectionActive = bCurrentStatus
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverMultipleStations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleStations.ControlValueChanged
        If ucrReceiverMultipleStations.IsEmpty Then
            ucrReceiverMultipleElements.strDatabaseQuery = "SELECT obselement.elementName FROM obselement,observationfinal WHERE obselement.elementId=observationfinal.describedBy GROUP BY observationfinal.describedBy;"
        Else
            ucrReceiverMultipleElements.strDatabaseQuery = "SELECT obselement.elementName FROM obselement,observationfinal WHERE obselement.elementId=observationfinal.describedBy AND observationfinal.recordedFrom IN (" & String.Join(",", ucrReceiverMultipleStations.GetVariableNamesList(bWithQuotes:=False)) & ") GROUP BY observationfinal.describedBy;"
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrControlsContents_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleElements.ControlValueChanged, ucrChkObservationData.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class