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

Imports System.Windows.Forms.TabControl
Imports instat.Translations

Public Class sdgTableOptions
    Private clsOperator As ROperator
    Private clsThemeRFunction As RFunction
    Private tabsToUse As IEnumerable(Of EnumTableSubDialogTab)
    Private bFirstload As Boolean = True

    Private Sub sdgTableOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
            'adding these  because it's ignored on first load
            'ucrCboSelectThemes.SetText(dlgGeneralTable.ucrCboSelectThemes.GetText)
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSdgBaseButtons.iHelpTopicID = 146

        ucrChkSelectTheme.Checked = False
        ucrChkSelectTheme.SetText("Select Theme")

        ucrCboSelectThemes.Visible = False
        ucrCboSelectThemes.SetItems({"Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrCboSelectThemes.SetDropDownStyleAsNonEditable()

        ucrChkManualTheme.SetText("Manual Theme")
        btnManualTheme.Visible = False
    End Sub

    ''' <summary>
    ''' Sets up the sub dialog.
    ''' Expected to be called before showing the dialog. 
    ''' </summary>
    ''' <param name="strDataFrameName">Name of the data frame contained in the data book</param>
    ''' <param name="clsNewOperator">R operator that has a 'gt' parameter that produces a 'gt' object.</param>
    Public Sub Setup(strDataFrameName As String, clsNewOperator As ROperator, tabsToUse As IEnumerable(Of EnumTableSubDialogTab), Optional strTableName As String = "")
        Me.clsOperator = clsNewOperator
        Me.tabsToUse = tabsToUse

        tbTableOptions.TabPages.Clear()

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.Header) Then
            tbTableOptions.TabPages.Add(tbpHeader)
            ucrHeader.Setup(clsOperator)
        End If

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.Stub) Then
            tbTableOptions.TabPages.Add(tbpStub)
            ucrStub.Setup(strDataFrameName, clsOperator, strTableName)
        End If

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.Rows) Then
            tbTableOptions.TabPages.Add(tbpRows)
            ucrRows.Setup(strDataFrameName, clsOperator, strTableName)
        End If

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.Columns) Then
            tbTableOptions.TabPages.Add(tbpColumns)
            ucrColumns.Setup(strDataFrameName, clsOperator, strTableName)
        End If

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.Cells) Then
            tbTableOptions.TabPages.Add(tbpCells)
            ucrCells.Setup(strDataFrameName, clsOperator, strTableName)
        End If

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.SourceNotes) Then
            tbTableOptions.TabPages.Add(tbpSourceNotes)
            ucrSourceNotes.Setup(clsOperator)
        End If

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.Themes) Then
            tbTableOptions.TabPages.Add(tbpThemes)
            SetupTheme(clsOperator)
        End If

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.OtherStyle) Then
            tbTableOptions.TabPages.Add(tbpOtherStyles)
            ucrOtherStyles.Setup(clsOperator)
        End If

        If Me.tabsToUse.Contains(EnumTableSubDialogTab.Table) Then
            tbTableOptions.TabPages.Add(tbpTable)
            ucrTableOptions.Setup(clsOperator)
        End If
    End Sub

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        If tabsToUse.Contains(EnumTableSubDialogTab.Header) Then
            ucrHeader.SetValuesToOperator()
        End If

        If tabsToUse.Contains(EnumTableSubDialogTab.Stub) Then
            ucrStub.SetValuesToOperator()
        End If

        If tabsToUse.Contains(EnumTableSubDialogTab.Rows) Then
            ucrRows.SetValuesToOperator()
        End If

        If tabsToUse.Contains(EnumTableSubDialogTab.Columns) Then
            ucrColumns.SetValuesToOperator()
        End If

        If tabsToUse.Contains(EnumTableSubDialogTab.Cells) Then
            ucrCells.SetValuesToOperator()
        End If

        If tabsToUse.Contains(EnumTableSubDialogTab.SourceNotes) Then
            ucrSourceNotes.SetValuesToOperator()
        End If

        If tabsToUse.Contains(EnumTableSubDialogTab.Themes) Then
            SetThemeValuesOnReturn(clsOperator)
        End If

        If tabsToUse.Contains(EnumTableSubDialogTab.OtherStyle) Then
            ucrOtherStyles.SetValuesToOperator()
        End If

        If tabsToUse.Contains(EnumTableSubDialogTab.Table) Then
            ucrTableOptions.SetValuesToOperator()
        End If
    End Sub

    '-----------------------------------------
    ' Themes

    Private Sub SetupTheme(clsOperator As ROperator)
        If clsOperator.ContainsParameter("theme_format") Then
            clsThemeRFunction = clsOperator.GetParameter("theme_format").clsArgumentCodeStructure
            ' TODO. Set up the themes R function controls with the parameter values
        End If

        ' TODO. This should be changed to checking for the `tab_options` paraneter from the ROperator
        If ucrChkManualTheme.Checked Then
            sdgSummaryThemes.SetRCode(bReset:=True, clsNewThemesTabOption:=clsThemeRFunction)
        End If
    End Sub

    Private Sub ucrChkSelectTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectTheme.ControlValueChanged
        clsThemeRFunction = New RFunction
        If ucrChkSelectTheme.Checked Then
            clsThemeRFunction.SetPackageName("gtExtras")
            clsThemeRFunction.SetRCommand("gt_theme_dark")
            ucrCboSelectThemes.SetName("Dark Theme")
        End If

        ucrCboSelectThemes.Visible = ucrChkSelectTheme.Checked
        If ucrChkSelectTheme.Checked AndAlso ucrChkManualTheme.Checked Then
            ucrChkManualTheme.Checked = False
        End If

    End Sub

    Private Sub ucrChkManualTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkManualTheme.ControlValueChanged
        clsThemeRFunction = New RFunction
        If ucrChkManualTheme.Checked Then
            clsThemeRFunction.SetPackageName("gt")
            clsThemeRFunction.SetRCommand("tab_options")
        End If

        btnManualTheme.Visible = ucrChkManualTheme.Checked
        If ucrChkManualTheme.Checked AndAlso ucrChkSelectTheme.Checked Then
            ucrChkSelectTheme.Checked = False
        End If
    End Sub

    Private Sub btnManualTheme_Click(sender As Object, e As EventArgs) Handles btnManualTheme.Click
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
        clsOperator.RemoveParameterByName("theme_format")

        If Not ucrChkSelectTheme.Checked AndAlso Not ucrChkManualTheme.Checked Then
            Exit Sub
        End If

        If clsThemeRFunction IsNot Nothing AndAlso Not String.IsNullOrEmpty(clsThemeRFunction.strRCommand) Then
            clsOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
        End If
    End Sub
    '-----------------------------------------
End Class