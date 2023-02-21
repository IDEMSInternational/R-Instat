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
    Private bOKEnabled As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
    End Sub

    Private Sub sdgLocation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            ucrSelectorLocation.Reset()
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

        ucrInputLatitude.SetParameter(New RParameter("lat_rad", 2))
        ucrInputLatitude.AddQuotesIfUnrecognised = False
        ucrInputLatitude.SetLinkedDisplayControl(lblLatitude)
        ucrInputLatitude.SetRDefault(0)

        ucrReceiverLongitude.SetParameter(New RParameter("lon", 3))
        ucrReceiverLongitude.SetParameterIsRFunction()
        ucrReceiverLongitude.Selector = ucrSelectorLocation

        ucrInputLongitude.SetParameter(New RParameter("lon", 3))
        ucrInputLongitude.AddQuotesIfUnrecognised = False
        ucrInputLongitude.SetLinkedDisplayControl(lblLongitude)
        ucrInputLongitude.SetRDefault(0)

        ucrReceiverAltitude.SetParameter(New RParameter("Elev", 4))
        ucrReceiverAltitude.SetParameterIsRFunction()
        ucrReceiverAltitude.Selector = ucrSelectorLocation

        ucrInputElevation.SetParameter(New RParameter("Elev", 4))
        ucrInputElevation.AddQuotesIfUnrecognised = False
        ucrInputElevation.SetLinkedDisplayControl(lblLatitude)
        ucrInputElevation.SetRDefault(0)
    End Sub

    Public Sub SetRFunction(clsNewVarnamesVectorHS As RFunction, clsNewVarnamesVectorPM As RFunction, clsNewListFunction As RFunction, Optional bReset As Boolean = False)
        EnableDesableSelector()
        If Not bControlsInitialised Then
            InitialiseDialog()
        End If
        clsListFunction = clsNewListFunction
        clsVarnamesVectorPM = clsNewVarnamesVectorPM
        clsVarnamesVectorHS = clsNewVarnamesVectorHS
        ucrReceiverLongitude.AddAdditionalCodeParameterPair(clsVarnamesVectorHS, New RParameter("lon", 3), iAdditionalPairNo:=1)
        ucrReceiverLatitude.AddAdditionalCodeParameterPair(clsListFunction, New RParameter("lat_rad", 2), iAdditionalPairNo:=1)
        ucrReceiverAltitude.AddAdditionalCodeParameterPair(clsListFunction, New RParameter("Elev", 4), iAdditionalPairNo:=1)
        ucrInputLongitude.AddAdditionalCodeParameterPair(clsVarnamesVectorHS, New RParameter("lon", 3), iAdditionalPairNo:=1)
        ucrInputLatitude.AddAdditionalCodeParameterPair(clsListFunction, New RParameter("lat_rad", 2), iAdditionalPairNo:=1)
        ucrInputElevation.AddAdditionalCodeParameterPair(clsListFunction, New RParameter("Elev", 4), iAdditionalPairNo:=1)

        ucrSelectorLocation.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)
        ucrReceiverStation.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)
        ucrReceiverLatitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverAltitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverLongitude.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)
        ucrInputLatitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputElevation.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrInputLongitude.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)

        bControlsInitialised = True
    End Sub
    Private Sub EnableDesableSelector()
        If ucrReceiverLatitude.IsEmpty AndAlso ucrReceiverAltitude.IsEmpty Then
            grpLocation.Visible = True
            ucrSelectorLocation.Visible = False
        Else
            ucrSelectorLocation.Visible = True
            grpLocation.Visible = False
        End If
    End Sub
End Class