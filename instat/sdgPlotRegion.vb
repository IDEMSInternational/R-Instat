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
    Private clsRfunction, clsSequenceFunction As New RFunction
    Private Sub sdgPlotRegion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        Dim dctPlotCapitalsPairs As New Dictionary(Of String, String)

        ucrInputAddtoTitle.SetParameter(New RParameter("add2title", 6))
        ucrInputAddtoTitle.SetRDefault("")

        ucrInputMinLongitude.SetParameter(New RParameter("lonmin", 7))
        ucrInputMinLongitude.SetRDefault("NA")
        ucrInputMinLongitude.AddQuotesIfUnrecognised = False
        'ucrInputMinLongitude.SetValidationTypeAsNumeric()

        ucrInputMaxLongitude.SetParameter(New RParameter("lonmax", 8))
        ucrInputMaxLongitude.SetRDefault("NA")
        ucrInputMaxLongitude.AddQuotesIfUnrecognised = False
        'ucrInputMaxLongitude.SetValidationTypeAsNumeric()

        ucrInputMinLatitude.SetParameter(New RParameter("latmin", 9))
        ucrInputMinLatitude.SetRDefault("NA")
        ucrInputMinLatitude.AddQuotesIfUnrecognised = False
        'ucrInputMinLatitude.SetValidationTypeAsNumeric()

        ucrInputMaxLatitude.SetParameter(New RParameter("latmax", 10))
        ucrInputMaxLatitude.SetRDefault("NA")
        ucrInputMaxLatitude.AddQuotesIfUnrecognised = False
        'ucrInputMaxLatitude.SetValidationTypeAsNumeric()

        ucrInputPlotHeight.SetParameter(New RParameter("height", 11))
        ucrInputPlotHeight.SetRDefault("600")
        ucrInputPlotHeight.AddQuotesIfUnrecognised = False
        ucrInputPlotHeight.SetValidationTypeAsNumeric()

        ucrInputPlotWidth.SetParameter(New RParameter("width", 12))
        ucrInputPlotWidth.SetRDefault("600")
        ucrInputPlotWidth.AddQuotesIfUnrecognised = False
        ucrInputPlotWidth.SetValidationTypeAsNumeric()

        ucrChkPlotAnomaly.SetParameter(New RParameter("plot.ano", 13))
        ucrChkPlotAnomaly.SetText("Plot Anomaly")
        ucrChkPlotAnomaly.SetRDefault("FALSE")

        ucrChkSetColourBreaks.SetParameter(New RParameter("set.col.breaks", 14))
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

        ucrInputColourBarMin.SetParameter(New RParameter("colmin0", 15))
        ucrInputColourBarMin.SetRDefault("NA")
        ucrInputColourBarMin.AddQuotesIfUnrecognised = False
        'ucrInputColourBarMin.SetValidationTypeAsNumeric()

        ucrInputColourBarMax.SetParameter(New RParameter("colmax0", 16))
        ucrInputColourBarMax.SetRDefault("NA")
        ucrInputColourBarMax.AddQuotesIfUnrecognised = False
        'ucrInputColourBarMax.SetValidationTypeAsNumeric()


        ucrNudNumberofColours.SetParameter(New RParameter("ncol", 17))
        ucrNudNumberofColours.SetRDefault("14")

        ucrChkPlotHighResolution.SetParameter(New RParameter("plotHighRes", 18))
        ucrChkPlotHighResolution.SetText("Plot High Resolution")
        ucrChkPlotHighResolution.SetRDefault("FALSE")

        ucrChkPlotCoastLines.SetParameter(New RParameter("plotCoastline", 19))
        ucrChkPlotCoastLines.SetText("Plot Coast Lines")
        ucrChkPlotCoastLines.SetRDefault("TRUE")

        ucrChkPlotCountries.SetParameter(New RParameter("plotCountries", 20))
        ucrChkPlotCountries.SetText("Plot Countries")
        ucrChkPlotCountries.SetRDefault("TRUE")

        ucrChkPlotRivers.SetParameter(New RParameter("plotRivers", 21))
        ucrChkPlotRivers.SetText("Plot Rivers")
        ucrChkPlotRivers.SetRDefault("FALSE")

        ucrChkPlotCities.SetParameter(New RParameter("plotCities", 22))
        ucrChkPlotCities.AddToLinkedControls(ucrNudSizeofCities, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrChkPlotCities.AddToLinkedControls(ucrChkLabelCities, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMinBreakPoint.SetLinkedDisplayControl(lblSizeofCities)
        ucrChkPlotCities.SetText("Plot Cities")
        ucrChkPlotCities.SetRDefault("FALSE")

        ucrNudThickness.SetParameter(New RParameter("contour.thick", 23))
        ucrNudThickness.SetRDefault("2")

        ucrNudSizeofCities.SetParameter(New RParameter("cex.cities", 24))
        ucrNudSizeofCities.SetRDefault("1")

        ucrChkLabelCities.SetParameter(New RParameter("label.cities", 25))
        ucrChkLabelCities.SetText("Label Cities")
        ucrChkLabelCities.SetRDefault("TRUE")

        ucrInputPlotCapitals.SetParameter(New RParameter("plotCapitals", 26))
        dctPlotCapitalsPairs.Add("No Capitals", "0")
        dctPlotCapitalsPairs.Add("Country Capitals", "1")
        dctPlotCapitalsPairs.Add("Provincial, State, Regional Capitals", "2")
        dctPlotCapitalsPairs.Add("Local Capitals", "3")
        ucrInputPlotCapitals.SetItems(dctPlotCapitalsPairs)
        ucrInputPlotCapitals.SetRDefault("1")
        ucrInputPlotCapitals.SetDropDownStyleAsNonEditable()

        ucrNudSizeofCityLabels.SetParameter(New RParameter("cex.label.cities", 27))
        ucrNudSizeofCityLabels.SetRDefault("0.5")

        ucrNudSizeofCityLabels.SetParameter(New RParameter("dlat", 28))
        ucrNudSizeofCityLabels.SetRDefault("0.25")

        'not yet working disabled for now
        ucrChkPlotOwnLocations.Enabled = False
        ucrChkPlotOwnLocations.SetParameter(New RParameter("plotOwnLocations", 29))
        ucrChkPlotOwnLocations.SetText("Plot Own Locations")
        ucrChkPlotOwnLocations.SetRDefault("FALSE")

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRfunction As RFunction, clsNewSequenceFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRfunction = clsNewRfunction
        clsSequenceFunction = clsNewSequenceFunction
        SetRCode(Me, clsRfunction, bReset)
    End Sub
End Class