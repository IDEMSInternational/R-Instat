'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'

Imports instat.Translations
''' <summary>
''' Duplicate Columns Class
''' This Class contains the scripts that will handle the running and behavior of the Duplicate columns dialog
''' </summary>
''' <Prerequisites>
''' Needs to import the translation class that will handle the multilingual aspect
''' For it to be fully functional, data must be loaded in the editor.
''' Data loaded has to be sensible, in that there must be columns and meta data related to it must be available
''' </Prerequisites>
''' <usage>
''' This class will be used to generate copies of already existing columns or the meta data purposely for modifying them further
''' This class will be instantiated when the Duplicate dialog is opened and disposed of when the dialog is closed
''' Not only will these module be able load the specific columns and meta data but also store the specific information about which data frame they originate from
''' </usage>
''' <Limitations>
''' Currently this class cannot implement the Labels event changed because discussion about this are still pending
''' Cannot yet write back to the data frame, will be implemented later
''' Transpose is not yet working
''' It is still a work in progress
''' </Limitations>
''' <Future>
''' We would like the checked change event to toggle on/off list of column type for the data
''' </Future>

Public Class dlgDuplicateColumns
    ''' <summary>
    ''' Handles the Load event of the dlgDuplicateColumns control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <code>
    ''' autoTranslate(me)
    ''' <return>
    ''' Returns the multilingual translation
    ''' </return>
    ''' </code>
    Private Sub dlgDuplicateColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
    End Sub

    ''' <summary>
    ''' Handles the CheckedChanged event of the rdoAnotherWorkSheet control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <code>
    '''  If rdoAnotherWorkSheet.Checked = True/False
    ''' <return>
    ''' Toggles enabling/disabling the grpWorksheetName
    ''' </return>
    ''' </code>
    Private Sub rdoAnotherWorkSheet_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAnotherWorkSheet.CheckedChanged
        If rdoAnotherWorkSheet.Checked = True Then
            grpWorksheetName.Enabled = True
        ElseIf rdoAnotherWorkSheet.Checked = False
            grpWorksheetName.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Handles the CheckedChanged event of the rdoCurrentWorksheet control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' ''' <code>
    ''' If rdoCurrentWorksheet.Checked = True/False
    ''' <return>
    ''' Toggles enabling/disabling the grpDataType
    ''' </return>
    ''' </code>
    Private Sub rdoCurrentWorksheet_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCurrentWorksheet.CheckedChanged
        If rdoCurrentWorksheet.Checked = True Then
            grpDataType.Enabled = True
        ElseIf rdoCurrentWorksheet.Checked = False
            grpDataType.Enabled = False
        End If
    End Sub

End Class