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

    Private clsOperator As ROperator
    Private clsThemeRFunction As RFunction
    Private bFirstload As Boolean = True

    Private Sub sdgTableOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSdgBaseButtons.iHelpTopicID = 146

        ucrPnlThemesPanel.AddRadioButton(rdoSelectTheme)
        ucrPnlThemesPanel.AddRadioButton(rdoManualTheme)

        ucrCboSelectThemes.SetItems({"None", "Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrCboSelectThemes.SetDropDownStyleAsNonEditable()
    End Sub

    ''' <summary>
    ''' An R operateor that has a parameter named "gt" set up.
    ''' The parameter should be an R Function that generates script "gt:gt()" as part of the last script statement.
    ''' </summary>
    ''' <param name="clsNewOperator"></param>
    Public Sub Setup(strDataFrameName As String, clsNewOperator As ROperator)
        If clsTablesUtils.FindRFunctionsParamsWithRCommand({"gt"}, clsNewOperator).Count = 0 Then
            MsgBox("Developer Error: Parameter with 'gt' as name MUST be set up before using this subdialog")
            Exit Sub
        End If

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

    Private Sub SetupTheme(clsOperator As ROperator)
        clsThemeRFunction = New RFunction

        ' Uncheck then the check radio button to forces the panel to raise its ControlValueChanged event
        rdoSelectTheme.Checked = False
        rdoSelectTheme.Checked = True

        If Not clsOperator.ContainsParameter("theme_format") Then
            Exit Sub
        End If

        clsThemeRFunction = clsOperator.GetParameter("theme_format").clsArgumentCodeStructure

        If clsThemeRFunction.strRCommand = "tab_options" Then
            rdoManualTheme.Checked = True
        Else
            rdoSelectTheme.Checked = True
            ucrCboSelectThemes.SetName(clsThemeRFunction.strRCommand)
        End If

    End Sub

    Private Sub ucrPnlThemes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlThemesPanel.ControlValueChanged
        ucrCboSelectThemes.Visible = False
        btnManualTheme.Visible = False

        If rdoSelectTheme.Checked Then
            ucrCboSelectThemes.Visible = True
            clsThemeRFunction.SetPackageName("gtExtras")
            clsThemeRFunction.ClearParameters()
        ElseIf rdoManualTheme.Checked Then
            btnManualTheme.Visible = True
            clsThemeRFunction.SetPackageName("gt")
            clsThemeRFunction.SetRCommand("tab_options")
        End If

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