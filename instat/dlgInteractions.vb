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
''' Interactions Class
''' This Class contains the scripts that will handle the running and behavior of the Interactions dialogue
''' </summary>
''' <Prerequisites>
''' Needs to import the translation class that will handle the multilingual aspect
''' For it to be fully functional, data must be loaded in the editor and has factor type columns.
''' Data loaded has to be sensible, in that the data has to have columns of type factor and non-factors
''' </Prerequisites>
''' <usage>
''' This class will be used to generate interactions
''' This class will be instantiated when the Indicator Variable dialogue is opened and disposed of when the dialog is closed
''' Not only will these module be able load the specific columns but also store the specific information about which data frame they originate from
''' </usage>
''' <Limitations>
''' The available factors and non factors at the moment are just combo boxes, I propose they become user controls. 
''' One of the user control to be a combo box and the other one a listview item or list box
''' Cannot yet write back to the data frame, will be implemented later
''' It is still a work in progress
''' </Limitations>
''' <Future>
''' To have a fully functional dialogue, it still the target, that works with multiple data frames.
''' </Future>

Public Class dlgInteractions
    ''' <summary>
    ''' Handles the KeyUp event of the dlgInteractions control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="KeyEventArgs"/> instance containing the event data.</param>
    ''' <code>
    ''' autoTranslate(me) handles the multilingual capabilities for the dialogue.
    ''' </code>
    Private Sub dlgInteractions_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        autoTranslate(Me)
    End Sub

    ''' <summary>
    ''' Handles the CheckedChanged event of the rdoCombineToNewFactor control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <code>
    ''' The checkChanged event for radio button toggles on/off checkbox With Label enabled or not.
    ''' </code>
    Private Sub rdoCombineToNewFactor_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCombineToNewFactor.CheckedChanged
        If rdoCombineToNewFactor.Checked = True Then
            chkWithLabel.Enabled = True
        ElseIf rdoCombineToNewFactor.Checked = False
            chkWithLabel.Enabled = False
        End If
    End Sub

    ''' <summary>
    ''' Handles the CheckedChanged event of the chkWithLabel control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>''' 
    ''' <code>
    ''' The checkChanged event for checkbox with label toggles on/off cbo Available Labels and chk Use Exiting Factor level combinations enabled or not.
    ''' </code>
    Private Sub chkWithLabel_CheckedChanged(sender As Object, e As EventArgs) Handles chkWithLabel.CheckedChanged
        If chkWithLabel.Enabled = True Then
            cboAvailableLabels.Enabled = True
            chkUseExitingFactorLevelCombinations.Enabled = True
        ElseIf chkWithLabel.Enabled = False
            cboAvailableLabels.Enabled = False
            chkUseExitingFactorLevelCombinations.Enabled = False
        End If
    End Sub
End Class