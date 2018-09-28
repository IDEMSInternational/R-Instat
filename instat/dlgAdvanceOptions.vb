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

Public Class dlgAdvanceOptions
    Dim strScript As String
    Private Sub ucrBase_ClickReturn(sender As Object, e As EventArgs)
        'strScript = strScript & ", data_tables_meta_data=" & txtDataTablesMetaData.Text.ToString()
        'strScript = strScript & ", climate_object_meta_data=" & txt.Value.ToString()
        'strScript = strScript & ", data_tables_meta_data=" & txtDataTablesMetaData.Text.ToString()
        'strScript = strScript & ", data_tables_variables=" & txtDataTablesVariables.Text.ToString()
        'strScript = strScript & ", imported_from=" & txtImportedFrom.Text.ToString()
        'strScript = strScript & ", data_time_periods=" & txtDataTimePeriods.Text.ToString()
        'strScript = strScript & ", messages=" & chkMessages.Checked.ToString().ToUpper()
        'strScript = strScript & ", convert=" & chkConvert.Checked.ToString().ToUpper()
        'strScript = strScript & ", create=" & chkCreate.Checked.ToString().ToUpper()
    End Sub
    Private Sub dlgAdvanceOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class