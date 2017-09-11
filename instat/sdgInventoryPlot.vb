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
Public Class sdgInventoryPlot
    Private clsInventoryFunction As New RFunction
    Private bControlsInitialised As Boolean = False

    Private Sub sdgInventoryPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        ucrChkDisplayRainDays.SetParameter(New RParameter("display_rain_days", 13), bNewChangeParameterValue:=True)
        ucrChkDisplayRainDays.SetText("Display Rain Days")
        ucrChkDisplayRainDays.SetRDefault("FALSE")

        ucrChkDisplayRainDays.AddToLinkedControls(ucrInputRain, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputRain.SetLinkedDisplayControl(lblRainLabel)
        ucrInputRain.SetLinkedDisplayControl(grpDisplayRainDays)

        ucrChkDisplayRainDays.AddToLinkedControls(ucrInputDry, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputRain.SetLinkedDisplayControl(lblDryLabel)

        ucrChkDisplayRainDays.AddToLinkedControls(ucrNudThresholdValue, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)
        ucrInputRain.SetLinkedDisplayControl(lblRainThresholdValue)

        ucrChkDisplayRainDays.AddToLinkedControls(ucrRainColour, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputRain.SetLinkedDisplayControl(lblRainColour)

        ucrChkDisplayRainDays.AddToLinkedControls(ucrDryColour, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputRain.SetLinkedDisplayControl(lblDryColour)

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, bReset As Boolean)

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsInventoryFunction = clsNewRFunction
        SetRCode(Me, clsInventoryFunction, bReset)
    End Sub

End Class