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
Public Class sdgLocation
    Private bFirstLoad As Boolean = True
    Private bControlsInitialised As Boolean = False
    Private clsVarnamesVectorPM, clsVarnamesVectorHS, clsListFunction As New RFunction

    Private Sub sdgLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            ucrSelectorLocation.Reset()
            EnableDesableSelector()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorLocation.SetParameter(New RParameter("station_df", 0))
        ucrSelectorLocation.SetParameterIsrfunction()

        ucrReceiverStation.SetParameter(New RParameter("name", 1))
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.Selector = ucrSelectorLocation
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverLatitude.SetParameter(New RParameter("lat_rad", 2))
        ucrReceiverLatitude.SetParameterIsRFunction()
        ucrReceiverLatitude.Selector = ucrSelectorLocation
        ucrReceiverLatitude.SetClimaticType("lat")
        ucrReceiverLatitude.bAutoFill = True

        ucrInputLatitude.SetParameter(New RParameter("lat_rad", 2))
        ucrInputLatitude.AddQuotesIfUnrecognised = False
        ucrInputLatitude.SetLinkedDisplayControl(lblLatitude)

        ucrReceiverLongitude.SetParameter(New RParameter("lon", 3))
        ucrReceiverLongitude.SetParameterIsRFunction()
        ucrReceiverLongitude.Selector = ucrSelectorLocation
        ucrReceiverLongitude.SetClimaticType("lon")
        ucrReceiverLongitude.bAutoFill = True

        ucrInputLongitude.SetParameter(New RParameter("lon", 3))
        ucrInputLongitude.AddQuotesIfUnrecognised = False
        ucrInputLongitude.SetLinkedDisplayControl(lblLongitude)
        ucrInputLongitude.SetRDefault(0)

        ucrReceiverAltitude.SetParameter(New RParameter("Elev", 4))
        ucrReceiverAltitude.SetParameterIsRFunction()
        ucrReceiverAltitude.Selector = ucrSelectorLocation
        ucrReceiverAltitude.SetClimaticType("alt")
        ucrReceiverAltitude.bAutoFill = True

        ucrInputElevation.SetParameter(New RParameter("Elev", 4))
        ucrInputElevation.AddQuotesIfUnrecognised = False
        ucrInputElevation.SetLinkedDisplayControl(lblLatitude)

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewVarnamesVectorHS As RFunction, clsNewVarnamesVectorPM As RFunction, clsNewListFunction As RFunction, Optional bReset As Boolean = False)
        clsListFunction = clsNewListFunction
        clsVarnamesVectorPM = clsNewVarnamesVectorPM
        clsVarnamesVectorHS = clsNewVarnamesVectorHS

        If Not bControlsInitialised Then
            InitialiseDialog()
        End If

        ucrReceiverLongitude.AddAdditionalCodeParameterPair(clsVarnamesVectorHS, New RParameter("lon", 3), iAdditionalPairNo:=1)
        ucrInputLongitude.AddAdditionalCodeParameterPair(clsVarnamesVectorHS, New RParameter("lon", 3), iAdditionalPairNo:=1)

        ucrSelectorLocation.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)
        ucrReceiverStation.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)
        ucrReceiverLatitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverAltitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverLongitude.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)

        If bReset Then
            ucrInputElevation.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
            ucrInputLongitude.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)
            ucrInputLatitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        End If
    End Sub

    Private Sub EnableDesableSelector()
        If ucrReceiverLatitude.IsEmpty AndAlso ucrReceiverAltitude.IsEmpty Then
            ucrInputLatitude.Enabled = True
            ucrInputElevation.Enabled = True
            ucrInputLongitude.Enabled = True
        Else
            ucrInputLatitude.Enabled = False
            ucrInputElevation.Enabled = False
            ucrInputLongitude.Enabled = False
        End If
    End Sub

    Private Sub ucrReceiverAltitude_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAltitude.ControlValueChanged, ucrReceiverLatitude.ControlValueChanged, ucrReceiverLongitude.ControlValueChanged
        EnableDesableSelector()
    End Sub

    Private Sub ucrInputElevation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputElevation.ControlValueChanged, ucrInputLatitude.ControlValueChanged, ucrInputLongitude.ControlValueChanged
        EnableDesableSelector()
    End Sub

    Private Sub ucrSelectorLocation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorLocation.ControlValueChanged
        EnableDesableSelector()
    End Sub
End Class