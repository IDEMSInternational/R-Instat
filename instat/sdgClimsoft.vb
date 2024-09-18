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

        ucrBaseSubdialog.iHelpTopicID = 352

        'Columns to include
        '---------------------------------------
        ucrChkIncludeStationId.SetText("Station Id")
        ucrChkIncludeStationId.Enabled = False

        ucrChkIncludeStationName.SetText("Station Name")
        ucrChkIncludeStationName.Enabled = False

        ucrChkIncludeElementAbbrv.SetText("Element Abbreviation")
        ucrChkIncludeElementAbbrv.Enabled = False

        ucrChkIncludeDateTime.SetText("Date Time")
        ucrChkIncludeDateTime.Enabled = False

        ucrChkIncludeElementId.SetText("Element Id")
        ucrChkIncludeElementId.SetParameter(New RParameter("include_element_id", 14))
        ucrChkIncludeElementId.SetRDefault("FALSE")

        ucrChkIncludeElementName.SetText("Element Name")
        ucrChkIncludeElementName.SetParameter(New RParameter("include_element_name", 15))
        ucrChkIncludeElementName.SetRDefault("FALSE")

        ucrChkIncludeAquistion.SetText("Acquisition Type")
        ucrChkIncludeAquistion.SetParameter(New RParameter("include_acquisition_type", 16))
        ucrChkIncludeAquistion.SetRDefault("FALSE")

        ucrChkIncludeLevel.SetText("Level")
        ucrChkIncludeLevel.SetParameter(New RParameter("include_level", 17))
        ucrChkIncludeLevel.SetRDefault("FALSE")

        ucrChkIncludeEntryForm.SetText("Entry Form")
        ucrChkIncludeEntryForm.SetParameter(New RParameter("include_entry_form", 18))
        ucrChkIncludeEntryForm.SetRDefault("FALSE")

        ucrChkIncludeCapturedBy.SetText("Captured By (user)")
        ucrChkIncludeCapturedBy.SetParameter(New RParameter("include_captured_by", 19))
        ucrChkIncludeCapturedBy.SetRDefault("FALSE")

        ucrChkIncludeQCStatus.SetText("QC Status")
        ucrChkIncludeQCStatus.SetParameter(New RParameter("include_qc_status", 20))
        ucrChkIncludeQCStatus.SetRDefault("FALSE")

        ucrChkIncludeQCLog.SetText("QC Log")
        ucrChkIncludeQCLog.SetParameter(New RParameter("include_qc_log", 21))
        ucrChkIncludeQCLog.SetRDefault("FALSE")

        ucrChkIncludeFlag.SetText("Flag")
        ucrChkIncludeFlag.SetParameter(New RParameter("include_flag", 22))
        ucrChkIncludeFlag.SetRDefault("FALSE")

        '---------------------------------------

        'Metadata
        '---------------------------------------
        ucrChkImportStationsMetadata.SetText("Selected Stations")
        ucrChkImportStationsMetadata.SetParameter(New RParameter("import_selected_stations_metadata", 23))
        ucrChkImportStationsMetadata.SetRDefault("FALSE")

        ucrChkImportElementsMetadata.SetText("Selected Elements")
        ucrChkImportElementsMetadata.SetParameter(New RParameter("import_selected_elements_metadata", 24))
        ucrChkImportElementsMetadata.SetRDefault("FALSE")
        '---------------------------------------

        bControlsInitialised = True

    End Sub

    Public Sub SetRCode(clsRFunction As RFunction, Optional bReset As Boolean = True)
        'initialise controls if not initialised
        InitialiseControls()

        'Columns
        '---------------------------------------
        ucrChkIncludeElementId.SetRCode(clsRFunction, bReset)
        ucrChkIncludeElementName.SetRCode(clsRFunction, bReset)
        ucrChkIncludeAquistion.SetRCode(clsRFunction, bReset)
        ucrChkIncludeLevel.SetRCode(clsRFunction, bReset)
        ucrChkIncludeEntryForm.SetRCode(clsRFunction, bReset)
        ucrChkIncludeCapturedBy.SetRCode(clsRFunction, bReset)
        ucrChkIncludeQCStatus.SetRCode(clsRFunction, bReset)
        ucrChkIncludeQCLog.SetRCode(clsRFunction, bReset)
        ucrChkIncludeFlag.SetRCode(clsRFunction, bReset)
        '---------------------------------------

        'Metadata
        '---------------------------------------
        ucrChkImportStationsMetadata.SetRCode(clsRFunction, bReset)
        ucrChkImportElementsMetadata.SetRCode(clsRFunction, bReset)
        '---------------------------------------

    End Sub


End Class