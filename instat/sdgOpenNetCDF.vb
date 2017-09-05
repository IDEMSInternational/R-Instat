' R-Instat
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
Public Class sdgOpenNetCDF
    Private clsRCDF, clsRSubsetFunction, clsRLatFunction, clsRLongFunction, clsRZFunction, clsRTimeFunction As New RFunction
    Private strShort As String
    Private Sub sdgOpenNetCDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ' subset = list(lat = c(a,b), long = c(a, b), z = c(a, b), time = c(a, b))

        ucrInputMinLong.SetParameter(New RParameter("long1", 0, bNewIncludeArgumentName:=False))
        ucrInputMinLong.SetValidationTypeAsNumeric()
        ucrInputMinLong.AddQuotesIfUnrecognised = False
        ucrInputMinLong.Focus()

        ucrInputMaxLong.SetParameter(New RParameter("long2", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxLong.SetValidationTypeAsNumeric()
        ucrInputMaxLong.AddQuotesIfUnrecognised = False

        ucrInputMinLat.SetParameter(New RParameter("lat1", 0, bNewIncludeArgumentName:=False))
        ucrInputMinLat.SetValidationTypeAsNumeric()
        ucrInputMinLat.AddQuotesIfUnrecognised = False

        ucrInputMaxLat.SetParameter(New RParameter("lat2", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxLat.SetValidationTypeAsNumeric()
        ucrInputMaxLat.AddQuotesIfUnrecognised = False

        ucrInputMinZ.SetParameter(New RParameter("Z1", 0, bNewIncludeArgumentName:=False))
        ucrInputMinZ.SetValidationTypeAsNumeric()
        ucrInputMinZ.AddQuotesIfUnrecognised = False

        ucrInputMaxZ.SetParameter(New RParameter("Z2", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxZ.SetValidationTypeAsNumeric()
        ucrInputMaxZ.AddQuotesIfUnrecognised = False

        ucrInputMinTime.SetParameter(New RParameter("time1", 0, bNewIncludeArgumentName:=False))
        ucrInputMinTime.SetValidationTypeAsNumeric()
        ucrInputMinTime.AddQuotesIfUnrecognised = False

        ucrInputMaxTime.SetParameter(New RParameter("time2", 1, bNewIncludeArgumentName:=False))
        ucrInputMaxTime.SetValidationTypeAsNumeric()
        ucrInputMaxTime.AddQuotesIfUnrecognised = False
    End Sub

    Public Sub SetRFunction(clsRNewCDF As RFunction, clsRNewLatFunction As RFunction, clsRNewLongFunction As RFunction, clsRNewZFunction As RFunction, clsRNewTimeFunction As RFunction, strNewShort As String, Optional bReset As Boolean = False)
        'If Not bControlsInitialised Then
        '    InitialiseControls()
        'End If
        clsRCDF = clsRNewCDF
        clsRLatFunction = clsRNewLatFunction
        clsRLongFunction = clsRNewLongFunction
        clsRZFunction = clsRNewZFunction
        clsRTimeFunction = clsRNewTimeFunction
        strShort = strNewShort

        ucrInputFileDetails.Text = strShort

        ucrInputMinLong.SetRCode(clsRLongFunction, bReset, bCloneIfNeeded:=True)
        ucrInputMaxLong.SetRCode(clsRLongFunction, bReset, bCloneIfNeeded:=True)
        ucrInputMinLat.SetRCode(clsRLatFunction, bReset, bCloneIfNeeded:=True)
        ucrInputMaxLat.SetRCode(clsRLatFunction, bReset, bCloneIfNeeded:=True)
        ucrInputMinZ.SetRCode(clsRZFunction, bReset, bCloneIfNeeded:=True)
        ucrInputMaxZ.SetRCode(clsRZFunction, bReset, bCloneIfNeeded:=True)
        ucrInputMinTime.SetRCode(clsRTimeFunction, bReset, bCloneIfNeeded:=True)
        ucrInputMaxTime.SetRCode(clsRTimeFunction, bReset, bCloneIfNeeded:=True)

        ucrInputMinLong.Focus()
    End Sub
End Class