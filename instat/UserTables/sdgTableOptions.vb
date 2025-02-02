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

Public Class sdgTableOptions

    Public clsOperator As ROperator
    Private clsThemeRFunction As RFunction
    Private bFirstload As Boolean = True

    Private Sub sdgTableOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
            ucrCboSelectThemes.SetText(dlgGeneralTable.ucrCboSelectThemes.GetText)
        End If
        autoTranslate(Me)

    End Sub

    Private Sub InitialiseDialog()
        ucrSdgBaseButtons.iHelpTopicID = 146
        'ucrChkSelectTheme.Checked = True
        'ucrChkManualTheme.Checked = False
        '  ucrChkSelectTheme.Checked = dlgGeneralTable.ucrChkSelectTheme.Checked
        ucrChkSelectTheme.SetText("Select Theme")
        ucrChkManualTheme.SetText("Manual Theme")

        ucrCboSelectThemes.SetItems({"None", "Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrCboSelectThemes.SetDropDownStyleAsNonEditable()
    End Sub

    ''' <summary>
    ''' Sets up the sub dialog.
    ''' Expected to be called before showing the dialog. 
    ''' </summary>
    ''' <param name="strDataFrameName">Name of the data frame contained in the data book</param>
    ''' <param name="clsNewOperator">R operator that has a 'gt' parameter that produces a 'gt' object.</param>
    Public Sub Setup(strDataFrameName As String, clsNewOperator As ROperator)
        clsOperator = clsNewOperator

        ucrHeader.Setup(clsOperator)
        ucrStub.Setup(strDataFrameName, clsOperator)
        ucrRows.Setup(strDataFrameName, clsOperator)
        ucrColumns.Setup(strDataFrameName, clsOperator)
        ucrCells.Setup(strDataFrameName, clsOperator)
        ucrSourceNotes.Setup(clsOperator)
        ucrOtherStyles.Setup(clsOperator)

        SetupTheme(clsOperator)
    End Sub

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        ucrHeader.SetValuesToOperator()
        ucrStub.SetValuesToOperator()
        ucrColumns.SetValuesToOperator()
        ucrRows.SetValuesToOperator()
        ucrCells.SetValuesToOperator()
        ucrSourceNotes.SetValuesToOperator()
        ucrOtherStyles.SetValuesToOperator()
        SetThemeValuesOnReturn(clsOperator)
    End Sub


    '-----------------------------------------
    ' Themes

    Private Sub ucrChkSelectTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectTheme.ControlValueChanged
        If ucrChkSelectTheme.Checked Then
            dlgGeneralTable.ucrChkSelectTheme.Checked = True
            ucrChkManualTheme.Checked = Not ucrChkSelectTheme.Checked
            btnManualTheme.Visible = Not ucrChkSelectTheme.Checked
            ucrCboSelectThemes.Visible = True
        Else
            dlgGeneralTable.ucrChkSelectTheme.Checked = False
            ucrCboSelectThemes.Visible = False
        End If
    End Sub

    Public Sub ucrCboSelectThemes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSelectThemes.ControlValueChanged
        ' Notify the main dialog of the selected theme
        UpdateThemeRCommand(ucrCboSelectThemes.GetText)
    End Sub

    Private Sub SetupTheme(clsOperator As ROperator)
        If clsOperator.ContainsParameter("theme_format") Then
            clsThemeRFunction = clsOperator.GetParameter("theme_format").clsArgumentCodeStructure
        Else
            clsThemeRFunction = New RFunction
            clsThemeRFunction.SetPackageName("gtExtras")
        End If
    End Sub

    Public Sub UpdateThemeRCommand(selectedTheme As String)
        If clsThemeRFunction Is Nothing Then Exit Sub

        Dim strCommand As String = GetThemeRCommand(selectedTheme)
        If strCommand <> "" Then
            clsThemeRFunction.SetRCommand(strCommand)
        End If

        ' Sync selected theme with sub-dialog
        dlgGeneralTable.UpdateSelectedTheme(selectedTheme)
    End Sub

    Public Sub UpdateSelectedTheme(selectedTheme As String)
        ucrCboSelectThemes.SetText(selectedTheme)
    End Sub

    Private Function GetThemeRCommand(themeName As String) As String
        Select Case themeName
            Case "Dark Theme" : Return "gt_theme_dark"
            Case "538 Theme" : Return "gt_theme_538"
            Case "Dot Matrix Theme" : Return "gt_theme_dot_matrix"
            Case "Espn Theme" : Return "gt_theme_espn"
            Case "Excel Theme" : Return "gt_theme_excel"
            Case "Guardian Theme" : Return "gt_theme_guardian"
            Case "NY Times Theme" : Return "gt_theme_nytimes"
            Case "PFF Theme" : Return "gt_theme_pff"
            Case Else : Return ""
        End Select
    End Function

    ' Method to sync the state from the main dialog
    Public Sub UpdateThemeSelectionState(isChecked As Boolean)
        ucrChkSelectTheme.Checked = isChecked
        ucrCboSelectThemes.Visible = isChecked

    End Sub

    Private Sub ucrChkManualTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkManualTheme.ControlValueChanged
        '  ucrChkSelectTheme.Checked = Not ucrChkManualTheme.Checked

        If ucrChkManualTheme.Checked Then
            btnManualTheme.Visible = True
            clsThemeRFunction.SetPackageName("gt")
            clsThemeRFunction.SetRCommand("tab_options")
            ucrChkSelectTheme.Checked = Not ucrChkManualTheme.Checked
        Else
            btnManualTheme.Visible = False
        End If
    End Sub


    Private Sub btnManualTheme_Click(sender As Object, e As EventArgs) Handles btnManualTheme.Click
        sdgSummaryThemes.SetRCode(bReset:=True, clsNewThemesTabOption:=clsThemeRFunction)
        sdgSummaryThemes.ShowDialog(Me)
    End Sub

    Private Sub SetThemeValuesOnReturn(clsOperator As ROperator)
        ' Set the themes parameter if there was a theme selected
        If clsThemeRFunction IsNot Nothing AndAlso Not String.IsNullOrEmpty(clsThemeRFunction.strRCommand) Then
            clsOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
        Else
            clsOperator.RemoveParameterByName("theme_format")
        End If
    End Sub
    '-----------------------------------------

End Class