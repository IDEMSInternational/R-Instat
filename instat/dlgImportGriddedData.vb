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
Public Class dlgImportGriddedData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRDefaultFunction As New RFunction
    Private Sub dlgImportGriddedData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()

        ucrInputDataName.SetParameter(New RParameter("data_names", 0))
        ucrInputDataName.clsParameter.bIncludeArgumentName = False
        ucrInputDownloadFrom.SetParameter(New RParameter("download_from", 1))

        Dim dctDownloadPairs As New Dictionary(Of String, String)
        dctDownloadPairs.Add("CHIRPS", Chr(34) & "CHIRPS" & Chr(34))
        dctDownloadPairs.Add("TAMSAT", Chr(34) & "TAMSAT" & Chr(34))

        'dctDownloadPairs.Add("CHIRPS", Chr(34) & "CHIRPS" & Chr(34))
        'dctDownloadPairs.Add("TAMSAT", Chr(34) & "TAMSAT" & Chr(34))
        ucrInputDownloadFrom.SetItems(dctDownloadPairs)


        ucrNudMinLat.SetParameter(New RParameter("X1", 2))
        ucrNudMinLat.SetMinMax(-50, 50)
        ucrNudMinLat.DecimalPlaces = 2
        ucrNudMinLat.Increment = 0.01
        'ucrNudMinLat.bAddRemoveParameter = False
        ucrNudMinLat.SetLinkedDisplayControl(lblMinLat)
        ucrNudMaxLat.SetParameter(New RParameter("X2", 3))
        ucrNudMaxLat.SetMinMax(-50, 50)
        ucrNudMaxLat.DecimalPlaces = 2
        ucrNudMaxLat.Increment = 0.01
        'ucrNudMaxLat.bAddRemoveParameter = False
        ucrNudMaxLat.SetLinkedDisplayControl(lblMaxLat)
        ucrNudMinLon.SetParameter(New RParameter("Y1", 4))
        ucrNudMinLon.SetMinMax(-180, 180)
        ucrNudMinLon.DecimalPlaces = 2
        ucrNudMinLon.Increment = 0.01
        'ucrNudMinLon.bAddRemoveParameter = False
        ucrNudMinLon.SetLinkedDisplayControl(lblMinLon)
        ucrNudMaxLon.SetParameter(New RParameter("Y2", 5))
        ucrNudMaxLon.SetMinMax(-180, 180)
        ucrNudMaxLon.DecimalPlaces = 2
        ucrNudMaxLon.Increment = 0.01
        'ucrNudMaxLon.bAddRemoveParameter = False
        ucrNudMaxLon.SetLinkedDisplayControl(lblMaxLon)
    End Sub

    Private Sub SetDefaults()
        clsRDefaultFunction = New RFunction

        clsRDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_from_iri")
        clsRDefaultFunction.AddParameter("download_from", "CHIRPS")
        clsRDefaultFunction.AddParameter("data_names", Chr(34) & "CHIRPS" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsRDefaultFunction)
    End Sub

    Private Sub TestOkEnabled()
        'If (ucrInputDataName.Text <> "" AndAlso ucrInputLocDataName.Text <> "" AndAlso ucrInputFilePath.Text <> "" AndAlso (Not ucrInputDataName.Text = ucrInputLocDataName.Text)) Then
        If (ucrInputDataName.Text <> "") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputDataName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class