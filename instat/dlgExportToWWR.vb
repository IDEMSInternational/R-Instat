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

Imports System.IO
Imports instat.Translations
Public Class dlgExportToWWR
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False

    'R function
    Private clsWWRExport As RFunction
    Private Sub dlgExportToWWR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitiliseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitiliseDialog()
        Dim dctStationIdentifier As New Dictionary(Of String, String)

        ucrSelectorExportToWWR.SetParameter(New RParameter("data", 0))
        ucrSelectorExportToWWR.SetParameterIsrfunction()

        ucrReceiverYear.Selector = ucrSelectorExportToWWR
        ucrReceiverYear.SetParameter(New RParameter("year", 1))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverMonth.Selector = ucrSelectorExportToWWR
        ucrReceiverMonth.SetParameter(New RParameter("month", 2))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True

        ucrReceiverMeanStationPressure.SetParameter(New RParameter("element", 3))
        ucrReceiverMeanStationPressure.Selector = ucrSelectorExportToWWR
        ucrReceiverMeanStationPressure.SetParameterIsString()

        ucrReceiverMeanSeaLevelPressure.SetParameter(New RParameter("station", 4))
        ucrReceiverMeanSeaLevelPressure.Selector = ucrSelectorExportToWWR
        ucrReceiverMeanSeaLevelPressure.SetParameterIsString()

        ucrReceiverPrecipitation.SetParameter(New RParameter("total_precip", 5))
        ucrReceiverPrecipitation.Selector = ucrSelectorExportToWWR
        ucrReceiverPrecipitation.SetParameterIsString()

        ucrReceiverMeanRelativeHumidity.SetParameter(New RParameter("mean_rel_hum", 6))
        ucrReceiverMeanRelativeHumidity.Selector = ucrSelectorExportToWWR
        ucrReceiverMeanRelativeHumidity.SetParameterIsString()

        ucrReceiverMeanDailyMaxAirTemperature.SetParameter(New RParameter("mean_max_temp", 7))
        ucrReceiverMeanDailyMaxAirTemperature.Selector = ucrSelectorExportToWWR
        ucrReceiverMeanDailyMaxAirTemperature.SetParameterIsString()

        ucrReceiverMeanDailyMinAirTemperature.SetParameter(New RParameter("mean_min_temp", 8))
        ucrReceiverMeanDailyMinAirTemperature.Selector = ucrSelectorExportToWWR
        ucrReceiverMeanDailyMinAirTemperature.SetParameterIsString()

        ucrReceiverMeanMonthlyAirTemperature.SetParameter(New RParameter("mean_temp", 9))
        ucrReceiverMeanMonthlyAirTemperature.Selector = ucrSelectorExportToWWR
        ucrReceiverMeanMonthlyAirTemperature.SetParameterIsString()

        ucrInputLinkby.SetParameter(New RParameter("link_by", 10))
        dctStationIdentifier.Add("Station Name", Chr(34) & "station_name" & Chr(34))
        dctStationIdentifier.Add("WMO Number", Chr(34) & "wmo_number" & Chr(34))
        ucrInputLinkby.SetItems(dctStationIdentifier)
        ucrInputLinkby.SetDropDownStyleAsNonEditable()

        ucrInputFilePath.SetParameter(New RParameter("folder", 11))
        ucrInputFilePath.IsReadOnly = True

        ucrReceiverStationIdentifier.SetParameter(New RParameter("link", 12))
        ucrReceiverStationIdentifier.Selector = ucrSelectorExportToWWR
        ucrReceiverStationIdentifier.SetParameterIsString()

    End Sub

    Private Sub SetDefaults()
        clsWWRExport = New RFunction

        clsWWRExport.AddParameter("link_by", Chr(34) & "station_name" & Chr(34), iPosition:=10)

        ucrSelectorExportToWWR.Reset()
        ucrReceiverYear.SetMeAsReceiver()

        clsWWRExport.SetRCommand("wwr_export")
        clsWWRExport.AddParameter("folder", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments).Replace("\", "/"), iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsWWRExport)

        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        '' If ucrInputStationName.IsEmpty Then
        '' ucrBase.OKEnabled(False)
        ''Else
        ''ucrBase.OKEnabled(True)
        ''End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputStationName_ControlContentsChanged(ucrChangedControl As ucrCore)
        TestOkEnabled()
    End Sub

    Private Sub btnStationMetadata_Click(sender As Object, e As EventArgs) Handles btnStationMetadata.Click
        sdgExportToWWR.SetRFunction(clsNewRFunction:=clsWWRExport, bResetSubdialog)
        sdgExportToWWR.ShowDialog()
        bResetSubdialog = False
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim strPath As String

        Using dlgFolder As New FolderBrowserDialog
            dlgFolder.Description = "Choose Folder"
            If dlgFolder.ShowDialog() = DialogResult.OK Then
                ucrInputFilePath.SetName("")
                strPath = dlgFolder.SelectedPath
                ucrInputFilePath.SetName(Replace(strPath, "\", "/"))
            End If
        End Using
    End Sub
End Class

