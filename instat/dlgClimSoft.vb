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
        ucrReceiverMultipleElements.Selector = ucrSelectorForClimSoft
        ucrReceiverMultipleStations.SetMeAsReceiver()
        ucrChkObservationData.SetText("Observation Data")
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub SetDefaults()
        TestOKEnabled()
        ucrSelectorForClimSoft.Reset()
    End Sub

    Private Sub cmdEstablishConnection_Click(sender As Object, e As EventArgs) Handles cmdEstablishConnection.Click
        sdgImportFromClimSoft.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class