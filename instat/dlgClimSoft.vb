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

Imports instat.Translations
Public Class dlgClimSoft
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRDatabaseConnect As New RFunction
    Public bConnectionActive As Boolean = False
    Private clsRDatabaseDisconnect As New RFunction
    Private clsRImportFromClimsoft As New RFunction
    Private bResetSubdialog As Boolean = False


    Private Sub dlgClimSoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False
        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 329
        ucrReceiverMultipleStations.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleStations.SetItemType("database_variables")
        ucrReceiverMultipleStations.strDatabaseQuery = "SELECT stationName FROM station;"
        ucrReceiverMultipleElements.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleElements.SetItemType("database_variables")
        ucrReceiverMultipleStations.strDatabaseQuery = "SELECT * FROM station;"
        ucrReceiverMultipleStations.SetMeAsReceiver()
        ucrChkObservationData.SetText("Observation Data")
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub SetDefaults()
        clsRDatabaseConnect.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$database_connect")
        clsRDatabaseDisconnect.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$database_disconnect")
        clsRImportFromClimsoft.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_climsoft")
        TestOKEnabled()
        ucrSelectorForClimSoft.Reset()
    End Sub

    Private Sub cmdEstablishConnection_Click(sender As Object, e As EventArgs) Handles cmdEstablishConnection.Click
        sdgImportFromDatabase.Set_RDatabaseConnection(clsRDatabaseConnect, bConnectionActive, bResetSubdialog)
        bResetSubdialog = False
        sdgImportFromDatabase.ShowDialog()
        SetConnectionActiveStatus(sdgImportFromDatabase.GetConnectionActiveStatus())
    End Sub

    Private Sub SetConnectionActiveStatus(bCurrentStatus As Boolean)
        bConnectionActive = bCurrentStatus
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class