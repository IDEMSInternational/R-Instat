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
Public Class sdgMissingOptionsEvapotranspiration
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsReadInputs, clsMissingDataVector As New RFunction
    Private Sub sdgMissingOptionsEvapotranspiration_Load(sender As Object, e As EventArgs) Handles ucrSdgButtons.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrChkInterpMissingDays.SetParameter(New RParameter("interp_missing_days", 5))
        ucrChkInterpMissingDays.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkInterpMissingDays.SetRDefault("FALSE")
        ucrChkInterpMissingDays.SetText("Interpolate Missing Days")

        ucrChkInterpMissingEntries.SetParameter(New RParameter("interp_missing_entries", 6))
        ucrChkInterpMissingEntries.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkInterpMissingEntries.SetRDefault("FALSE")
        ucrChkInterpMissingEntries.SetText("Interpolate Missing Entries")

        ucrNudMaxMissingData.SetParameter(New RParameter("x", bNewIncludeArgumentName:=False))
        ucrNudMaxMissingData.SetMinMax(1, 99)

        ucrNudMaxMissingDays.SetParameter(New RParameter("y", bNewIncludeArgumentName:=False))
        ucrNudMaxMissingDays.SetMinMax(1, 99)

        ucrNudMaxDurationMissingData.SetParameter(New RParameter("z", bNewIncludeArgumentName:=False))
        ucrNudMaxDurationMissingData.SetMinMax(1, 99)
    End Sub

    Public Sub SetRFunction(clsNewReadInputs As RFunction, clsNewMissingDataVector As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsReadInputs = clsNewReadInputs
        clsMissingDataVector = clsNewMissingDataVector

        ucrChkInterpMissingDays.SetRCode(clsReadInputs, bReset, bCloneIfNeeded:=True)
        ucrChkInterpMissingEntries.SetRCode(clsReadInputs, bReset, bCloneIfNeeded:=True)
        ucrNudMaxMissingData.SetRCode(clsMissingDataVector, bReset, bCloneIfNeeded:=True)
        ucrNudMaxMissingDays.SetRCode(clsMissingDataVector, bReset, bCloneIfNeeded:=True)
        ucrNudMaxDurationMissingData.SetRCode(clsMissingDataVector, bReset, bCloneIfNeeded:=True)
    End Sub
End Class