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
''' Polynomials Class
''' This Class contains the scripts that will handle the running and behavior of the Polynomials dialogue
''' </summary>
''' <Prerequisites>
''' Needs to import the translation class that will handle the multilingual aspect
''' For it to be fully functional, data must be loaded in the editor.
''' </Prerequisites>
''' <usage>
''' This class will be used to generate polynomialss
''' This class will be instantiated when the polynomial dialogue is opened and disposed of when the dialog is closed
''' Not only will these module be able load the specific columns but also store the specific information about which data frame they originate from
''' </usage>
''' <Limitations> 
''' Cannot yet write back to the data frame, will be implemented later
''' It is still a work in progress
''' </Limitations>
''' <Future>
''' To have a fully functional dialogue, it still the target, that works with multiple data frames.
''' </Future>

Public Class dlgPolynomials
    ''' <summary>
    ''' Handles the Load event of the dlgPolynomials control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <code>
    ''' autoTranslate(me) handles the multilingual capabilities for the dialogue.
    ''' </code>
    Private Sub dlgPolynomials_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    ''' <summary>
    ''' Handles the CheckedChanged event of the rdoOrthogonal control.
    ''' </summary>
    ''' <param name="sender">The source of the event.</param>
    ''' <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
    ''' <code>
    ''' Checked change event toggles on/off the checkbox for weights being enabled.
    ''' </code>
    Private Sub rdoOrthogonal_CheckedChanged(sender As Object, e As EventArgs) Handles rdoOrthogonal.CheckedChanged
        If rdoOrthogonal.Checked = True Then
            chkWeights.Enabled = True
        ElseIf rdoOrthogonal.Checked = False
            chkWeights.Enabled = False
        End If
    End Sub
End Class