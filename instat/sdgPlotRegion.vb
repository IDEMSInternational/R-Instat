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

Public Class sdgPlotRegion
    Private bControlsInitialised As Boolean = False
    Private clsRfunction As New RFunction
    Private Sub sdgPlotRegion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctPlotCapitalsPairs As New Dictionary(Of String, String)

        ucrInputAddtoTitle.SetParameter(New RParameter("add2title"))
        ucrInputAddtoTitle.SetRDefault("NA")

        ucrInputMinLongitude.SetParameter(New RParameter("lonmin"))
        ucrInputMinLongitude.SetRDefault("NA")
        'ucrInputMinLongitude.SetValidationTypeAsNumeric()

        ucrInputMaxLongitude.SetParameter(New RParameter("lonmax"))
        ucrInputMaxLongitude.SetRDefault("NA")
        'ucrInputMaxLongitude.SetValidationTypeAsNumeric()

        ucrInputMinLatitude.SetParameter(New RParameter("latmin"))
        ucrInputMinLatitude.SetRDefault("NA")
        'ucrInputMinLatitude.SetValidationTypeAsNumeric()

        ucrInputMaxLatitude.SetParameter(New RParameter("latmax"))
        ucrInputMaxLatitude.SetRDefault("NA")
        'ucrInputMaxLatitude.SetValidationTypeAsNumeric()

        ucrInputPlotHeight.SetParameter(New RParameter("height"))
        ucrInputPlotHeight.SetRDefault("600")
        ucrInputPlotHeight.SetValidationTypeAsNumeric()

        ucrInputPlotWidth.SetParameter(New RParameter("width"))
        ucrInputPlotWidth.SetRDefault("600")
        ucrInputPlotWidth.SetValidationTypeAsNumeric()

        ucrChkPlotAnomaly.SetParameter(New RParameter("plot.ano"))
        ucrChkPlotAnomaly.SetText("Plot Anomaly")
        ucrChkPlotAnomaly.SetRDefault("FALSE")

        ucrChkSetColourBreaks.SetParameter(New RParameter("set.col.breaks"))
        ucrChkSetColourBreaks.SetText("Set Colour Breaks")
        ucrChkSetColourBreaks.SetRDefault("FALSE")
        ucrChkSetColourBreaks.AddToLinkedControls(ucrInputMinBreakPoint, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMinBreakPoint.SetLinkedDisplayControl(lblMinBreakPoint)
        ucrChkSetColourBreaks.AddToLinkedControls(ucrInputMaxBreakPoint, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMaxBreakPoint.SetLinkedDisplayControl(lblMaxBreakPoint)
        ucrChkSetColourBreaks.AddToLinkedControls(ucrInputInterval, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputInterval.SetLinkedDisplayControl(lblInterval)

        ucrInputMinBreakPoint.SetParameter(New RParameter("var1", 0, bNewIncludeArgumentName:=False))
        ucrInputMinBreakPoint.SetRDefault("240")
        ucrInputMinBreakPoint.SetValidationTypeAsNumeric()

        ucrInputMaxBreakPoint.SetParameter(New RParameter("var2", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxBreakPoint.SetRDefault("340")
        ucrInputMaxBreakPoint.SetValidationTypeAsNumeric()

        ucrInputInterval.SetParameter(New RParameter("var3", 1, bNewIncludeArgumentName:=False))
        ucrInputInterval.SetRDefault("5")
        ucrInputInterval.SetValidationTypeAsNumeric()

        ucrInputColourBarMin.SetParameter(New RParameter("colmin0"))
        ucrInputColourBarMin.SetRDefault("NA")
        'ucrInputColourBarMin.SetValidationTypeAsNumeric()

        ucrInputColourBarMax.SetParameter(New RParameter("colmax0"))
        ucrInputColourBarMax.SetRDefault("NA")
        'ucrInputColourBarMax.SetValidationTypeAsNumeric()


        ucrNudNumberofColours.SetParameter(New RParameter("ncol"))
        ucrNudNumberofColours.SetRDefault("14")

        ucrChkPlotHighResolution.SetParameter(New RParameter("plotHighRes"))
        ucrChkPlotHighResolution.SetText("Plot High Resolution")
        ucrChkPlotHighResolution.SetRDefault("FALSE")

        ucrChkPlotCoastLines.SetParameter(New RParameter("plotCoastline"))
        ucrChkPlotCoastLines.SetText("Plot Coast Lines")
        ucrChkPlotCoastLines.SetRDefault("TRUE")

        ucrChkPlotCountries.SetParameter(New RParameter("plotCountries"))
        ucrChkPlotCountries.SetText("Plot Countries")
        ucrChkPlotCountries.SetRDefault("TRUE")

        ucrChkPlotRivers.SetParameter(New RParameter("plotRivers"))
        ucrChkPlotRivers.SetText("Plot Rivers")
        ucrChkPlotRivers.SetRDefault("FALSE")

        ucrChkPlotCities.SetParameter(New RParameter("plotCities"))
        ucrChkPlotCities.AddToLinkedControls(ucrNudSizeofCities, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrChkPlotCities.AddToLinkedControls(ucrChkLabelCities, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMinBreakPoint.SetLinkedDisplayControl(lblSizeofCities)
        ucrChkPlotCities.SetText("Plot Cities")
        ucrChkPlotCities.SetRDefault("FALSE")

        ucrNudThickness.SetParameter(New RParameter("contour.thick"))
        ucrNudThickness.SetRDefault("2")

        ucrNudSizeofCities.SetParameter(New RParameter("cex.cities"))
        ucrNudSizeofCities.SetRDefault("1")

        ucrChkLabelCities.SetParameter(New RParameter("label.cities"))
        ucrChkLabelCities.SetText("Label Cities")
        ucrChkLabelCities.SetRDefault("TRUE")

        ucrInputPlotCapitals.SetParameter(New RParameter("plotCapitals"))
        dctPlotCapitalsPairs.Add("No Capitals", Chr(34) & "0" & Chr(34))
        dctPlotCapitalsPairs.Add("Country Capitals", Chr(34) & "1" & Chr(34))
        dctPlotCapitalsPairs.Add("Provincial, State, Regional Capitals", Chr(34) & "2" & Chr(34))
        dctPlotCapitalsPairs.Add("Local Capitals", Chr(34) & "3" & Chr(34))
        ucrInputPlotCapitals.SetItems(dctPlotCapitalsPairs)
        ucrInputPlotCapitals.SetDropDownStyleAsNonEditable()

        ucrNudSizeofCityLabels.SetParameter(New RParameter("cex.label.cities"))
        ucrNudSizeofCityLabels.SetRDefault("0.5")

        ucrNudSizeofCityLabels.SetParameter(New RParameter("dlat"))
        ucrNudSizeofCityLabels.SetRDefault("0.25")

        ucrChkPlotOwnLocations.SetParameter(New RParameter("plotOwnLocations"))
        ucrChkPlotOwnLocations.SetText("Plot Own Locations")
        ucrChkPlotOwnLocations.SetRDefault("FALSE")

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRfunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRfunction = clsNewRfunction
        SetRCode(Me, clsRfunction, bReset)
    End Sub
End Class