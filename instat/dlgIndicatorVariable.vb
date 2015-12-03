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
''' Indicator Variable Class
''' This Class contains the scripts that will handle the running and behavior of the Indicator Variable dialogue
''' </summary>
''' <Prerequisites>
''' Needs to import the translation class that will handle the multilingual aspect
''' For it to be fully functional, data must be loaded in the editor.
''' Data loaded has to be sensible, in that the data has to have columns of type factor and non-factors
''' </Prerequisites>
''' <usage>
''' This class will be used to generate Indicator variables
''' This class will be instantiated when the Indicator Variable dialogue is opened and disposed of when the dialog is closed
''' Not only will these module be able load the specific columns but also store the specific information about which data frame they originate from
''' </usage>
''' <Limitations>
''' The available factors and non factors at the moment are just combo boxes, I propose they become user controls.
''' Cannot yet write back to the data frame, will be implemented later
''' It is still a work in progress
''' </Limitations>
''' <Future>
''' To have a fully functional dialogue, it still the target, that works with multiple data frames.
''' </Future>

Public Class dlgIndicatorVariable
    ''' <summary>
    ''' Handles the Load event of the dlgIndicatorVariable control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <code>
    ''' autoTranslate(me) handles the multilingual capabilities for the dialogue.
    ''' </code>
    Private Sub dlgIndicatorVariable_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
    End Sub

    ''' <summary>
    ''' Handles the CheckedChanged event of the chkWithX control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <code>
    ''' The checkChanged event for chkWithX toggles on/off cboNonFactors enabled or not.
    ''' </code>
    Private Sub chkWithX_CheckedChanged(sender As Object, e As EventArgs) Handles chkWithX.CheckedChanged
        If chkWithX.Checked = True Then
            cboNonFactors.Enabled = True
        ElseIf chkWithX.Checked = False
            cboNonFactors.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Handles the CheckedChanged event of the rdoLevelNumber control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <code>
    ''' The checkChanged event for rdoLevelNumber toggles on/off txtLevel being enabled or not.
    ''' </code>
    Private Sub rdoLevelNumber_CheckedChanged(sender As Object, e As EventArgs) Handles rdoLevelNumber.CheckedChanged
        If rdoLevelNumber.Checked = True Then
            txtLevel.Enabled = True
        ElseIf rdoLevelNumber.Checked = False
            txtLevel.Enabled = False
        End If
    End Sub
End Class