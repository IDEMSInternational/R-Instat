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
Public Class sdgExportToWWR
    Private bControlsInitialised As Boolean = True
    Private clsWWRExport As New RFunction
    Public bOkEnabled As Boolean = False

    Private Sub sdgExportToWWR_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        ucrSelectorStationMetadata.SetParameter(New RParameter("station_data", 12))
        ucrSelectorStationMetadata.SetParameterIsrfunction()

        ucrReceiverWMONumber.SetParameter(New RParameter("wmo_number", 13))
        ucrReceiverWMONumber.Selector = ucrSelectorStationMetadata
        ucrReceiverWMONumber.SetParameterIsString()

        ucrReceiverLatitude.SetParameter(New RParameter("latitude", 14))
        ucrReceiverLatitude.Selector = ucrSelectorStationMetadata
        ucrReceiverLatitude.SetParameterIsString()

        ucrReceiverLongitude.SetParameter(New RParameter("longitude", 15))
        ucrReceiverLongitude.Selector = ucrSelectorStationMetadata
        ucrReceiverLongitude.SetParameterIsString()

        ucrReceiverCountry.SetParameter(New RParameter("country_name", 16))
        ucrReceiverCountry.Selector = ucrSelectorStationMetadata
        ucrReceiverCountry.SetParameterIsString()

        ucrReceiverStationName.SetParameter(New RParameter("station_name", 17))
        ucrReceiverStationName.Selector = ucrSelectorStationMetadata
        ucrReceiverStationName.SetParameterIsString()
        ucrReceiverStationName.SetMeAsReceiver()

        ucrReceiverStationHeight.SetParameter(New RParameter("height_station", 18))
        ucrReceiverStationHeight.Selector = ucrSelectorStationMetadata
        ucrReceiverStationHeight.SetParameterIsString()

        ucrReceiverBarometerHeight.SetParameter(New RParameter("height_barometer", 19))
        ucrReceiverBarometerHeight.Selector = ucrSelectorStationMetadata
        ucrReceiverBarometerHeight.SetParameterIsString()

        ucrReceiverWIGOSIdentifier.SetParameter(New RParameter("wigos_identifier", 20))
        ucrReceiverWIGOSIdentifier.Selector = ucrSelectorStationMetadata
        ucrReceiverWIGOSIdentifier.SetParameterIsString()

        bControlsInitialised = False
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If bControlsInitialised Then
            InitialiseControls()
        End If

        clsWWRExport = clsNewRFunction

        ucrSelectorStationMetadata.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)
        ucrReceiverStationName.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)
        ucrReceiverWMONumber.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)
        ucrReceiverCountry.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)
        ucrReceiverLatitude.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)
        ucrReceiverLongitude.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)
        ucrReceiverStationHeight.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)
        ucrReceiverBarometerHeight.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)
        ucrReceiverWIGOSIdentifier.SetRCode(clsWWRExport, bReset, bCloneIfNeeded:=True)

        If bReset Then
            ucrSelectorStationMetadata.Reset()
            ucrReceiverStationName.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrButtonsSdg_ClickReturn(sender As Object, e As EventArgs) Handles ucrButtonsSdg.ClickReturn
        If ucrReceiverStationName.IsEmpty OrElse ucrReceiverCountry.IsEmpty OrElse ucrReceiverLatitude.IsEmpty OrElse ucrReceiverLongitude.IsEmpty Then
            bOkEnabled = False
        Else
            bOkEnabled = True
        End If
    End Sub

    Private Sub sdgExportToWWR_Closing(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.Closing
        Dim result As MsgBoxResult

        If Not bOkEnabled Then
            result = MessageBox.Show(text:="Information missing. Station Name, Country, Latitude and Longitude are required. OK will not be enabled on the main dialog untill resolved." & Environment.NewLine & "Are you sure you want to return to the main dialog?", caption:="Missing information", buttons:=MessageBoxButtons.YesNo, icon:=MessageBoxIcon.Information)
            If result = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class