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
    Private clsKeyColours As New RFunction
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
        ucrInputRain.SetParameter(New RParameter("rainlabel"))

        ucrChkDisplayRainDays.AddToLinkedControls(ucrInputDry, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputDry.SetLinkedDisplayControl(lblDryLabel)

        ucrChkDisplayRainDays.AddToLinkedControls(ucrNudThresholdValue, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.85)
        ucrNudThresholdValue.SetLinkedDisplayControl(lblRainThresholdValue)

        ucrChkDisplayRainDays.AddToLinkedControls(ucrRainColour, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrRainColour.SetLinkedDisplayControl(lblRainColour)
        ucrRainColour.SetParameter(New RParameter("rain", 0))

        ucrChkDisplayRainDays.AddToLinkedControls(ucrDryColour, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrDryColour.SetLinkedDisplayControl(lblDryColour)
        ucrDryColour.SetParameter(New RParameter("dry", 1))

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, clsNewKeyColours As RFunction, bReset As Boolean)

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsInventoryFunction = clsNewRFunction
        clsKeyColours = clsNewKeyColours

        ucrRainColour.SetRCode(clsNewKeyColours, bReset)
        ucrDryColour.SetRCode(clsNewKeyColours, bReset)
        ucrChkDisplayRainDays.SetRCode(clsInventoryFunction, bReset)
    End Sub

End Class