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
        autoTranslate(Me)
    End Sub

    Private Sub initialiseDialog()
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

        If bFirstload Then
            initialiseDialog()
            bFirstload = False
        End If

        clsOperator = clsNewOperator

        ucrHeader.Setup(clsOperator)
        ucrStub.Setup(strDataFrameName, clsOperator)
        ucrRows.Setup(strDataFrameName, clsOperator)
        ucrColumns.Setup(strDataFrameName, clsOperator)
        ucrCells.Setup(strDataFrameName, clsOperator)
        SetupFooterNotesRFunctionsInOperatorOnNew(clsOperator)
        ucrSourceNotes.Setup(clsOperator)
        SetupThemeRFunctionsInOperatorOnNew(clsOperator)
    End Sub

    Private Sub ucrSdgBaseButtons_ClickReturn(sender As Object, e As EventArgs) Handles ucrSdgBaseButtons.ClickReturn
        ucrHeader.SetValuesToOperator()
        ucrStub.SetValuesToOperator()
        ucrColumns.SetValuesToOperator()
        ucrCells.SetValuesToOperator()
        SetThemesInOperatorOnReturn(clsOperator)
    End Sub






    '-----------------------------------------
    ' FOOTER CONTROLS

    Private Sub SetupFooterNotesRFunctionsInOperatorOnNew(clsOperator As ROperator)
        'SetFooterGridContents(clsOperator, dataGridHeaderFooterNotes)
        'SetFooterGridContents(clsOperator, dataGridCellFooterNotes)
    End Sub

    Private Sub SetFooterGridContents(clsOperator As ROperator, dataGridFooterNotes As DataGridView)
        dataGridFooterNotes.Rows.Clear()

        For Each clsFootNoteFunctRParam As RParameter In clsOperator.clsParameters
            If clsFootNoteFunctRParam.strArgumentName.Contains("tab_footnote") Then
                ' Create a new row that represents the tab_footnote() parameters 
                Dim row As New DataGridViewRow
                row.CreateCells(dataGridFooterNotes)

                Dim clsFooterRFunction As RFunction = clsFootNoteFunctRParam.clsArgumentCodeStructure

                For Each clsFootNoteRParam As RParameter In clsFooterRFunction.clsParameters

                    If clsFootNoteRParam.strArgumentName = "footnote" Then
                        ' Set the foot note text
                        row.Cells(0).Value = GetStringValue(clsFootNoteRParam.clsArgumentCodeStructure.clsParameters(0).strArgumentValue, False)
                    ElseIf clsFootNoteRParam.strArgumentName = "locations" Then
                        ' todo go through the location function
                        Dim clsFooterLocationNoteRFunction As RFunction = clsFootNoteRParam.clsArgumentCodeStructure

                        'If clsFooterLocationNoteRFunction.strRCommand = "cells_body" AndAlso dataGridFooterNotes Is dataGridCellFooterNotes Then
                        '    For Each clsFootNoteLocationRParam As RParameter In clsFooterLocationNoteRFunction.clsParameters
                        '        If clsFootNoteLocationRParam.strArgumentName = "columns" Then
                        '            row.Cells(1).Value = GetStringValue(clsFootNoteLocationRParam.strArgumentValue, False)
                        '        ElseIf clsFootNoteLocationRParam.strArgumentName = "rows" Then
                        '            row.Cells(2).Value = GetStringValue(clsFootNoteLocationRParam.strArgumentValue, False)
                        '        End If
                        '    Next
                        'End If
                    End If

                    ' Tag and add the tab_footnote() function contents as a row
                    ' Check if second cell has a value
                    If row.Cells(1).Value IsNot Nothing Then
                        row.Tag = clsFooterRFunction
                        dataGridFooterNotes.Rows.Add(row)
                    End If


                Next

            End If
        Next

        ' Always add a place holder row for new foot note
        dataGridFooterNotes.Rows.Add()

    End Sub



    Private Function SetupAndGetNewNoteRFunction(clsPossibleNoteRFunction As RFunction, strNoteRCommand As String, strRNoteTextParameterName As String, strNoteTextValue As String) As RFunction
        Dim clsNewNoteRFunction As RFunction = clsPossibleNoteRFunction
        ' Get the prevous style parameter to retain any format options previously done
        Dim clsStyleParam As RParameter
        If clsNewNoteRFunction IsNot Nothing Then
            clsStyleParam = clsNewNoteRFunction.GetParameter(strRNoteTextParameterName).clsArgumentCodeStructure.GetParameter("style")
        Else
            clsStyleParam = New RParameter(strParameterName:="style", strParamValue:=clsTablesUtils.GetNewHtmlStyleRFunction(), iNewPosition:=1)
        End If


        ' Recreate the footer function
        clsNewNoteRFunction = New RFunction
        clsNewNoteRFunction.SetPackageName("gt")
        clsNewNoteRFunction.SetRCommand(strNoteRCommand)

        Dim clsNoteTextRFunction As RFunction = clsTablesUtils.GetNewHtmlSpanRFunction()
        clsNoteTextRFunction.AddParameter(New RParameter(strParameterName:="", strParamValue:=GetStringValue(strNoteTextValue, True), iNewPosition:=0, bNewIncludeArgumentName:=False))
        clsNoteTextRFunction.AddParameter(clsStyleParam) ' Add the style parameter for formating

        ' Add the foot note text parameter to the footer R function
        clsNewNoteRFunction.AddParameter(New RParameter(strParameterName:=strRNoteTextParameterName, strParamValue:=clsNoteTextRFunction, iNewPosition:=0))
        Return clsNewNoteRFunction
    End Function

    '-----------------------------------------

    '-----------------------------------------
    ' Themes

    Private Sub SetupThemeRFunctionsInOperatorOnNew(clsOperator As ROperator)
        clsThemeRFunction = New RFunction

        ' Uncheck then the select radio button to orces the panel to raise it ControlValueChanged event
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

    Private Sub SetThemesInOperatorOnReturn(clsOperator As ROperator)
        ' Set the themes parameter if there was a theme selected
        If clsThemeRFunction IsNot Nothing AndAlso Not String.IsNullOrEmpty(clsThemeRFunction.strRCommand) Then
            clsOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
        Else
            clsOperator.RemoveParameterByName("theme_format")
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
    '-----------------------------------------

    '-----------------------------------------
    Private Function GetStringValue(str As String, bwithQuotes As Boolean) As String
        If String.IsNullOrEmpty(str) Then
            str = ""
        End If
        Return If(bwithQuotes, """" & str & """", str.Replace("""", ""))
    End Function


End Class