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

Public Class sdgWindrose
    Public bControlsInitialised As Boolean = False
    Public clsWindRoseFunc As New RFunction
    Private Sub sdgWindrose_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrNudCalmWind.SetParameter(New RParameter("calm_wind"))
        ucrNudCalmWind.SetRDefault(0)

        ucrNudNoOfDirections.SetParameter(New RParameter("n_directions"))
        ucrNudNoOfDirections.SetRDefault(12)

        ucrNudNoOfSpeeds.SetParameter(New RParameter("n_speeds "))
        ucrNudNoOfSpeeds.SetRDefault(5)

        ucrInputSpeedCuts.SetParameter(New RParameter("speed_cuts "))
        ucrInputSpeedCuts.SetRDefault("NA")

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsWindRoseFunc = clsNewRFunction
        SetRCode(Me, clsWindRoseFunc, bReset)
    End Sub
End Class