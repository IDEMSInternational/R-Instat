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
    Private clsDataFunctionPM, clsDatafunctionHS, clsVarnamesVectorPM, clsListFunction As New RFunction
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
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorLocation
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverLatitude.SetParameter(New RParameter("lat_rad", 2))
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.Selector = ucrSelectorLocation

        ucrReceiverLongitude.SetParameter(New RParameter("lon", 3))
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.Selector = ucrSelectorLocation

        ucrReceiverAltitude.SetParameter(New RParameter("Elev", 4))
        ucrReceiverAltitude.SetParameterIsString()
        ucrReceiverAltitude.Selector = ucrSelectorLocation
    End Sub

    Public Sub SetRFunction(clsNewDataFunctionPM As RFunction, clsNewVarnamesVectorPM As RFunction, clsNewDataFunctionHS As RFunction, clsNewListFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseDialog()
        End If
        clsDataFunctionPM = clsNewDataFunctionPM
        clsDatafunctionHS = clsNewDataFunctionHS
        clsListFunction = clsNewListFunction
        clsVarnamesVectorPM = clsNewVarnamesVectorPM
        ucrReceiverLongitude.AddAdditionalCodeParameterPair(clsNewDataFunctionHS, New RParameter("lon", 3), iAdditionalPairNo:=1)
        ucrReceiverLatitude.AddAdditionalCodeParameterPair(clsListFunction, New RParameter("lat", 2), iAdditionalPairNo:=1)
        ucrReceiverAltitude.AddAdditionalCodeParameterPair(clsListFunction, New RParameter("elev", 4), iAdditionalPairNo:=1)


        ucrSelectorLocation.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)
        ucrReceiverStation.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)
        ucrReceiverLatitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverAltitude.SetRCode(clsListFunction, bReset, bCloneIfNeeded:=True)
        ucrReceiverLongitude.SetRCode(clsVarnamesVectorPM, bReset, bCloneIfNeeded:=True)

        bControlsInitialised = True
    End Sub

End Class