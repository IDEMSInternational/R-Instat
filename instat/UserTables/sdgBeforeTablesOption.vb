﻿' R- Instat
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

Public Class sdgBeforeTablesOption

    Private clsOperator As ROperator
    Private clsThemeRFunction As RFunction
    Private bFirstload As Boolean = True

    Private Sub sdgBeforeTablesOption_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
            'adding these  because it's ignored on first load
            ucrCboSelectThemes.SetText(dlgGeneralTable.ucrCboSelectThemes.GetText)
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSdgBaseButtons.iHelpTopicID = 146
        ucrChkSelectTheme.Checked = True
        ucrChkSelectTheme.SetText("Select Theme")
        ucrChkManualTheme.SetText("Manual Theme")

        ucrCboSelectThemes.SetItems({"None", "Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrCboSelectThemes.SetDropDownStyleAsNonEditable()
    End Sub

    ''' <summary>
    ''' Sets up the sub dialog, this is the simpler version of the main sdgTableOptions dialog but has only 4 options.
    ''' Expected to be called before showing the dialog. 
    ''' </summary>
    ''' <param name="strDataFrameName">Name of the data frame contained in the data book</param>
    ''' <param name="clsNewOperator">R operator that has a 'gt' parameter that produces a 'gt' object.</param>
    Public Sub Setup(strDataFrameName As String, clsNewOperator As ROperator)
        clsOperator = clsNewOperator

        ucrHeader.Setup(clsOperator)
        ucrSourceNotes.Setup(clsOperator)
        ucrOtherStyles.Setup(clsOperator)

        ucrHeader.ucrInputTitle.SetText(dlgGeneralTable.ucrInputTitle.GetText)
        ucrHeader.ucrInputTitleFooter.SetText(dlgGeneralTable.ucrInputTitleFooter.GetText)
        ucrCboSelectThemes.SetText(dlgGeneralTable.ucrCboSelectThemes.GetText)
        ucrChkSelectTheme.Checked = dlgGeneralTable.ucrChkSelectTheme.Checked
        sdgTableStyles.GetNewUserInputAsRFunction()
        SetupTheme(clsOperator)
    End Sub

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        ucrHeader.SetValuesToOperator()
        ucrSourceNotes.SetValuesToOperator()
        ucrOtherStyles.SetValuesToOperator()
        SetThemeValuesOnReturn(clsOperator)
    End Sub

    '-----------------------------------------
    ' Themes

    Private Sub SetupTheme(clsOperator As ROperator)
        If clsOperator.ContainsParameter("theme_format") Then
            clsThemeRFunction = clsOperator.GetParameter("theme_format").clsArgumentCodeStructure
        Else
            clsThemeRFunction = New RFunction
            clsThemeRFunction.SetPackageName("gtExtras")
        End If
        If ucrChkManualTheme.Checked Then
            sdgSummaryThemes.SetRCode(bReset:=True, clsNewThemesTabOption:=clsThemeRFunction)
        End If
    End Sub

    Private Sub ucrChkSelectTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectTheme.ControlValueChanged
        If ucrChkSelectTheme.Checked Then
            btnManualTheme.Visible = False
            ucrCboSelectThemes.Visible = True
        ElseIf ucrChkSelectTheme.Checked Then
            ucrChkManualTheme.Checked = True
        Else
            ucrCboSelectThemes.Visible = False
        End If
    End Sub

    Private Sub ucrChkManualTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkManualTheme.ControlValueChanged

        If ucrChkManualTheme.Checked Then
            btnManualTheme.Visible = True
            ucrChkSelectTheme.Checked = Not ucrChkManualTheme.Checked
            btnManualTheme.Visible = ucrChkManualTheme.Checked
        End If
    End Sub

    Private Sub btnManualTheme_Click(sender As Object, e As EventArgs) Handles btnManualTheme.Click
        clsThemeRFunction.SetPackageName("gt")
        clsThemeRFunction.SetRCommand("tab_options")
        sdgSummaryThemes.SetRCode(bReset:=True, clsNewThemesTabOption:=clsThemeRFunction)
        sdgSummaryThemes.ShowDialog(Me)
    End Sub

    Private Sub ucrCboSelectThemes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSelectThemes.ControlValueChanged

        If clsThemeRFunction Is Nothing Then
            Exit Sub
        End If

        Dim strCommand As String = ""
        Select Case ucrCboSelectThemes.GetText
            Case "Dark Theme"
                strCommand = "gt_theme_dark"
            Case "538 Theme"
                strCommand = "gt_theme_538"
            Case "Dot Matrix Theme"
                strCommand = "gt_theme_dot_matrix"
            Case "Espn Theme"
                strCommand = "gt_theme_espn"
            Case "Excel Theme"
                strCommand = "gt_theme_excel"
            Case "Guardian Theme"
                strCommand = "gt_theme_guardian"
            Case "NY Times Theme"
                strCommand = "gt_theme_nytimes"
            Case "PFF Theme"
                strCommand = "gt_theme_pff"
        End Select

        clsThemeRFunction.SetRCommand(strCommand)
    End Sub

    Private Sub SetThemeValuesOnReturn(clsOperator As ROperator)
        ' Set the themes parameter if there was a theme selected
        If ucrChkManualTheme.Checked Then
            sdgSummaryThemes.SetRCode(bReset:=True, clsNewThemesTabOption:=clsThemeRFunction)
        End If
        If clsThemeRFunction IsNot Nothing AndAlso Not String.IsNullOrEmpty(clsThemeRFunction.strRCommand) Then
            clsOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
        Else
            clsOperator.RemoveParameterByName("theme_format")
        End If
    End Sub
    '-----------------------------------------
End Class