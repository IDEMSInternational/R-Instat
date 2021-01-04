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
Public Class sdgClimaticNCMPMetadata
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsDefaultFunction As New RFunction
    Private Sub sdgClimaticNCMPMetadata_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrSelectorMetadata.SetParameter(New RParameter("station_df", 10))
        ucrSelectorMetadata.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("station", 11))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorMetadata
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverLatitude.SetParameter(New RParameter("lat", 12))
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.Selector = ucrSelectorMetadata

        ucrReceiverLongitude.SetParameter(New RParameter("long", 13))
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.Selector = ucrSelectorMetadata
    End Sub

    Public Sub SetRFunction(clsNewDefaultFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsDefaultFunction = clsNewDefaultFunction

        ucrSelectorMetadata.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverStation.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverLatitude.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverLongitude.SetRCode(clsDefaultFunction, bReset, bCloneIfNeeded:=True)

        bControlsInitialised = True
    End Sub
End Class