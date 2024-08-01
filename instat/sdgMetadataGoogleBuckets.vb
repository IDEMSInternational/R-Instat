'R-Instat
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
Public Class sdgMetadataGoogleBuckets
    Public clsUpdateMetadataInfoFunction As New RFunction
    Public clsRsyntax As New RSyntax
    Public bControlsInitialised As Boolean = False

    Private Sub sdgMetadataGoogleBuckets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()
        ucrSelectorMetadata.SetParameter(New RParameter("metadata_data", 0))
        ucrSelectorMetadata.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("station_var", 1))
        ucrReceiverStation.Selector = ucrSelectorMetadata
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverLongititude.SetParameter(New RParameter("longitude_var", 2))
        ucrReceiverLongititude.Selector = ucrSelectorMetadata
        ucrReceiverLongititude.SetParameterIsString()
        ucrReceiverLongititude.SetClimaticType("lon")
        ucrReceiverLongititude.bAutoFill = True

        ucrReceiverLatitude.SetParameter(New RParameter("latitude_var", 3))
        ucrReceiverLatitude.Selector = ucrSelectorMetadata
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.SetClimaticType("lat")
        ucrReceiverLatitude.bAutoFill = True

        ucrReceiverElavation.SetParameter(New RParameter("elevation_var", 4))
        ucrReceiverElavation.Selector = ucrSelectorMetadata
        ucrReceiverElavation.SetParameterIsString()
        ucrReceiverElavation.SetClimaticType("alt")
        ucrReceiverElavation.bAutoFill = True

        ucrReceiverDistrict.SetParameter(New RParameter("district_var", 5))
        ucrReceiverDistrict.Selector = ucrSelectorMetadata
        ucrReceiverDistrict.SetParameterIsString()
        ucrReceiverDistrict.SetClimaticType("district")
        ucrReceiverDistrict.bAutoFill = True
    End Sub
    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewUpdateMetadataInfoFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRsyntax = clsNewRSyntax
        clsUpdateMetadataInfoFunction = clsNewUpdateMetadataInfoFunction

        ucrReceiverDistrict.SetRCode(clsUpdateMetadataInfoFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverElavation.SetRCode(clsUpdateMetadataInfoFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverLatitude.SetRCode(clsUpdateMetadataInfoFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverLongititude.SetRCode(clsUpdateMetadataInfoFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverStation.SetRCode(clsUpdateMetadataInfoFunction, bReset, bCloneIfNeeded:=True)
        ucrSelectorMetadata.SetRCode(clsUpdateMetadataInfoFunction, bReset, bCloneIfNeeded:=True)
    End Sub

    Private Sub ucrReceiverLongititude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverLongititude.ControlValueChanged, ucrReceiverStation.ControlValueChanged, ucrReceiverLatitude.ControlValueChanged, ucrReceiverElavation.ControlValueChanged, ucrReceiverDistrict.ControlValueChanged, ucrSelectorMetadata.ControlValueChanged
        If Not (ucrReceiverElavation.IsEmpty OrElse ucrReceiverDistrict.IsEmpty OrElse ucrReceiverLatitude.IsEmpty OrElse ucrReceiverLongititude.IsEmpty OrElse ucrReceiverStation.IsEmpty) Then
            clsRsyntax.AddToBeforeCodes(clsUpdateMetadataInfoFunction, 1)
        Else
            clsRsyntax.RemoveFromBeforeCodes(clsUpdateMetadataInfoFunction)
        End If
    End Sub
End Class