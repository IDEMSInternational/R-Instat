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

Public Class sdgClimsoft

    Private bControlsInitialised As Boolean = False
    Private Sub sdgClimsoft_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        If bControlsInitialised Then
            Exit Sub
        End If

        'Columns to include
        '---------------------------------------
        ucrChkIncludeStationName.SetText("Station Name")
        ucrChkIncludeStationName.SetParameter(New RParameter("include_station_name", 13))
        ucrChkIncludeStationName.SetRDefault("TRUE")

        ucrChkIncludeElementAbbrv.SetText("Element Abbreviation")
        ucrChkIncludeElementAbbrv.SetParameter(New RParameter("include_element_abbreviation", 13))
        ucrChkIncludeElementAbbrv.SetRDefault("TRUE")

        ucrChkIncludeQCStatus.SetText("QC Status")
        ucrChkIncludeQCStatus.SetParameter(New RParameter("include_qc_status", 11))
        ucrChkIncludeQCStatus.SetRDefault("TRUE")

        ucrChkIncludeAquistion.SetText("Acquisition Type")
        ucrChkIncludeAquistion.SetParameter(New RParameter("include_acquisition_type", 14))
        ucrChkIncludeAquistion.SetRDefault("TRUE")

        ucrChkIncludeFlag.SetText("Flag")
        ucrChkIncludeFlag.SetParameter(New RParameter("include_flag", 12))
        ucrChkIncludeFlag.SetRDefault("TRUE")

        ucrChkIncludeEntryForm.SetText("Entry Form")
        ucrChkIncludeEntryForm.SetParameter(New RParameter("include_entry_form", 13))
        ucrChkIncludeEntryForm.SetRDefault("FALSE")
        '---------------------------------------

        'Metadata
        '---------------------------------------
        ucrChkImportStationsMetadata.SetText("Selected Stations")
        ucrChkImportStationsMetadata.SetParameter(New RParameter("import_selected_stations_metadata", 12))
        ucrChkImportStationsMetadata.SetRDefault("TRUE")

        ucrChkImportElementsMetadata.SetText("Selected Elements")
        ucrChkImportElementsMetadata.SetParameter(New RParameter("import_selected_elements_metadata", 13))
        ucrChkImportElementsMetadata.SetRDefault("TRUE")
        '---------------------------------------

        bControlsInitialised = True

    End Sub

    Public Sub SetRCode(clsRFunction As RFunction, Optional bReset As Boolean = True)
        'initialise controls if not initialised
        InitialiseControls()

        ucrChkIncludeQCStatus.SetRCode(clsRFunction, bReset)
        ucrChkIncludeAquistion.SetRCode(clsRFunction, bReset)
        ucrChkIncludeFlag.SetRCode(clsRFunction, bReset)
        ucrChkIncludeEntryForm.SetRCode(clsRFunction, bReset)
        ucrChkIncludeStationName.SetRCode(clsRFunction, bReset)
        ucrChkIncludeElementAbbrv.SetRCode(clsRFunction, bReset)

        ucrChkImportStationsMetadata.SetRCode(clsRFunction, bReset)
        ucrChkImportElementsMetadata.SetRCode(clsRFunction, bReset)

    End Sub


End Class