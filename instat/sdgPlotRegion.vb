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
        ucrInputAddtoTitle.SetParameter(New RParameter("add2title"))
        ucrInputAddtoTitle.SetRDefault("NA")

        ucrInputMinLongitude.SetParameter(New RParameter("lonmin"))
        ucrInputMinLongitude.SetRDefault("NA")
        ucrInputMinLongitude.SetValidationTypeAsNumeric()

        ucrInputMaxLongitude.SetParameter(New RParameter("lonmax"))
        ucrInputMaxLongitude.SetRDefault("NA")
        ucrInputMaxLongitude.SetValidationTypeAsNumeric()

        ucrInputMinLatitude.SetParameter(New RParameter("latmin"))
        ucrInputMinLatitude.SetRDefault("NA")
        ucrInputMinLatitude.SetValidationTypeAsNumeric()

        ucrInputMaxLatitude.SetParameter(New RParameter("latmax"))
        ucrInputMaxLatitude.SetRDefault("NA")
        ucrInputMaxLatitude.SetValidationTypeAsNumeric()

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
        ucrInputColourBarMin.SetValidationTypeAsNumeric()

        ucrInputColourBarMax.SetParameter(New RParameter("colmax0"))
        ucrInputColourBarMax.SetRDefault("NA")
        ucrInputColourBarMax.SetValidationTypeAsNumeric()


        ucrNudNumberofColours.SetParameter(New RParameter("ncol"))
        ucrNudNumberofColours.SetRDefault("14")

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