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

Imports System.Reflection
Imports System.Windows.Documents
Imports instat.Translations
Imports unvell.ReoGrid.IO.OpenXML.Schema

Public Class sdgTableOptions

    Private clsOperator As ROperator
    Private clsTitleRFunction As RFunction
    Private clsSubtitleRFunction As RFunction
    Private clsThemeRFunction As RFunction
    Private bDialogInitialised As Boolean = False

    Private Sub sdgTableOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub ucrBaseSubdialog_ClickReturn(sender As Object, e As EventArgs) Handles ucrBaseSubdialog.ClickReturn
        SetHeaderOptionsInOperatorOnReturn(clsOperator)
        RemoveParameterFromOperatorOnReturn("tab_footnote", clsOperator)
        SetGridOptionsInOperatorOnReturn(dataGridHeaderFooterNotes, "tab_footnote", clsOperator)
        SetGridOptionsInOperatorOnReturn(dataGridCellFooterNotes, "tab_footnote", clsOperator)
        SetGridOptionsInOperatorOnReturn(dataGridSourceNotes, "tab_source_note", clsOperator)
        SetThemesInOperatorOnReturn(clsOperator)
    End Sub

    Private Sub SetGridOptionsInOperatorOnReturn(dataGrid As DataGridView, strParameterName As String, clsOperator As ROperator)

        If dataGrid.Rows.Count = 0 Then
            Exit Sub
        End If

        ' Then add the new footer parameters
        For index As Integer = 0 To dataGrid.Rows.Count - 1
            Dim clsFooterRFunction As RFunction = dataGrid.Rows.Item(index).Tag
            If clsFooterRFunction IsNot Nothing Then
                clsOperator.AddParameter(strParameterName & index, clsRFunctionParameter:=clsFooterRFunction, bIncludeArgumentName:=False)
            End If
        Next

    End Sub

    Private Sub RemoveParameterFromOperatorOnReturn(strParameterName As String, clsOperator As ROperator)

        ' Remove all the previous footer parameters first
        Dim lstParams As New List(Of RParameter)
        For Each clsRParam As RParameter In clsOperator.clsParameters
            If clsRParam.strArgumentName.Contains(strParameterName) Then
                lstParams.Add(clsRParam)
            End If
        Next
        For Each clsRParam As RParameter In lstParams
            clsOperator.RemoveParameter(clsRParam)
        Next


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
    Public Sub Setup(clsNewOperator As ROperator)

        If Not bDialogInitialised Then
            initialiseDialog()
            bDialogInitialised = True
        End If

        clsOperator = clsNewOperator

        If Not clsNewOperator.ContainsParameter("gt") Then
            MsgBox("Developer Error: Parameter with 'gt' as name MUST be set up before using this subdialog")
            Me.Close()
            Exit Sub
        End If

        SetupHeaderRFunctionsInOperatorOnNew(clsOperator)
        SetupFooterNotesRFunctionsInOperatorOnNew(clsOperator)
        SetupSouceNotesRFunctionsInOperatorOnNew(clsOperator)
        SetupThemeRFunctionsInOperatorOnNew(clsOperator)

    End Sub

    '-----------------------------------------
    ' HEADER CONTROLS 

    Private Sub SetupHeaderRFunctionsInOperatorOnNew(clsOperator As ROperator)

        ' Use existing header function it's in the operator,
        ' if it's not in the operator create one and add it to the operator.
        Dim clsHeaderRFunction As RFunction

        If clsOperator.ContainsParameter("tab_header") Then
            clsHeaderRFunction = clsOperator.GetParameter("tab_header").clsArgumentCodeStructure
        Else
            ' Create new header function
            clsHeaderRFunction = New RFunction
            clsHeaderRFunction.SetPackageName("gt")
            clsHeaderRFunction.SetRCommand("tab_header")
            ' add the header function into the operator
            clsOperator.AddParameter("tab_header", clsRFunctionParameter:=clsHeaderRFunction, bIncludeArgumentName:=False)
        End If

        If clsHeaderRFunction.ContainsParameter("title") Then
            clsTitleRFunction = clsHeaderRFunction.GetParameter("title").clsArgumentCodeStructure
        Else
            ' create new title function and add it to into the header function
            clsTitleRFunction = GetNewHtmlDivRFunction()
            clsTitleRFunction.AddParameter(strParameterValue:=Chr(34) & "" & Chr(34), iPosition:=0)
            clsTitleRFunction.AddParameter(strParameterName:="style", clsRFunctionParameter:=GetNewStyleRFunction(), iPosition:=1)

            ' Add the title function as the paramter value of header function
            clsHeaderRFunction.AddParameter("title", clsRFunctionParameter:=clsTitleRFunction)

        End If

        If clsHeaderRFunction.ContainsParameter("subtitle") Then
            clsSubtitleRFunction = clsHeaderRFunction.GetParameter("subtitle").clsArgumentCodeStructure
        Else
            ' Create new sub title function and add it to into the header function
            clsSubtitleRFunction = GetNewHtmlDivRFunction()
            clsSubtitleRFunction.AddParameter(strParameterValue:=Chr(34) & "" & Chr(34), iPosition:=0)
            clsSubtitleRFunction.AddParameter(strParameterName:="style", clsRFunctionParameter:=GetNewStyleRFunction(), iPosition:=1)

            ' Add the subtitle function as the paramter value of header function
            clsHeaderRFunction.AddParameter("subtitle", clsRFunctionParameter:=clsSubtitleRFunction)

        End If

        ' set the header controls values
        ucrInputHeaderTitle.SetName(GetStringValue(clsTitleRFunction.clsParameters(0).strArgumentValue, False))
        ucrInputHeaderSubtitle.SetName(GetStringValue(clsSubtitleRFunction.clsParameters(0).strArgumentValue, False))
    End Sub

    Private Sub SetHeaderOptionsInOperatorOnReturn(clsOperator As ROperator)
        'Remove any header additions if both title and sub title are empty

        If ucrInputHeaderTitle.IsEmpty() AndAlso ucrInputHeaderSubtitle.IsEmpty() Then
            clsOperator.RemoveParameterByName("tab_header")
            Exit Sub
        End If
        Dim clsHeaderRFunction As RFunction = clsOperator.GetParameter("tab_header").clsArgumentCodeStructure

        If ucrInputHeaderTitle.IsEmpty() Then
            clsHeaderRFunction.RemoveParameterByName("title")
        Else
            clsTitleRFunction.AddParameter(strParameterValue:=GetStringValue(ucrInputHeaderTitle.GetText(), True), iPosition:=0)
        End If

        If ucrInputHeaderSubtitle.IsEmpty() Then
            clsHeaderRFunction.RemoveParameterByName("subtitle")
        Else
            clsSubtitleRFunction.AddParameter(strParameterValue:=GetStringValue(ucrInputHeaderSubtitle.GetText(), True), iPosition:=0)
        End If

    End Sub

    Private Function GetNewHtmlDivRFunction() As RFunction
        Dim clsHtmlDivRFunction As New RFunction
        clsHtmlDivRFunction.SetPackageName("htmltools")
        clsHtmlDivRFunction.SetRCommand("tags$span")
        Return clsHtmlDivRFunction
    End Function

    Private Function GetNewStyleRFunction() As RFunction
        Dim clsStyleRFunction As New RFunction
        clsStyleRFunction.SetPackageName("htmltools")
        clsStyleRFunction.SetRCommand("css")
        Return clsStyleRFunction
    End Function

    Private Sub ucrInputHeaderTitle_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderTitle.ControlContentsChanged
        btnHeaderTitleFormat.Enabled = Not ucrInputHeaderTitle.IsEmpty
    End Sub

    Private Sub btnHeaderTitleFormat_Click(sender As Object, e As EventArgs) Handles btnHeaderTitleFormat.Click
        sdgTableOptionsTextFormat.Setup(clsTitleRFunction.GetParameter("style").clsArgumentCodeStructure)
        sdgTableOptionsTextFormat.Show(Me)
    End Sub

    Private Sub ucrInputHeaderSubtitle_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderSubtitle.ControlContentsChanged
        btnHeaderSubTitleFormat.Enabled = Not ucrInputHeaderSubtitle.IsEmpty
    End Sub

    Private Sub btnHeaderSubTitleFormat_Click(sender As Object, e As EventArgs) Handles btnHeaderSubTitleFormat.Click
        sdgTableOptionsTextFormat.Setup(clsSubtitleRFunction.GetParameter("style").clsArgumentCodeStructure)
        sdgTableOptionsTextFormat.Show(Me)
    End Sub
    '-----------------------------------------

    '-----------------------------------------
    ' FOOTER CONTROLS

    Private Sub SetupFooterNotesRFunctionsInOperatorOnNew(clsOperator As ROperator)
        SetFooterGridContents(clsOperator, dataGridHeaderFooterNotes)
        SetFooterGridContents(clsOperator, dataGridCellFooterNotes)
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

                        If clsFooterLocationNoteRFunction.strRCommand = "cells_title" AndAlso dataGridFooterNotes Is dataGridHeaderFooterNotes Then
                            If clsFooterLocationNoteRFunction.clsParameters.Count > 0 Then
                                row.Cells(1).Value = GetStringValue(clsFooterLocationNoteRFunction.clsParameters(0).strArgumentValue, False)
                            End If
                        ElseIf clsFooterLocationNoteRFunction.strRCommand = "cells_body" AndAlso dataGridFooterNotes Is dataGridFooterNotes Then
                            For Each clsFootNoteLocationRParam As RParameter In clsFooterLocationNoteRFunction.clsParameters
                                If clsFootNoteLocationRParam.strArgumentName = "columns" Then
                                    row.Cells(1).Value = GetStringValue(clsFootNoteLocationRParam.strArgumentValue, False)
                                ElseIf clsFootNoteLocationRParam.strArgumentName = "rows" Then
                                    row.Cells(2).Value = GetStringValue(clsFootNoteLocationRParam.strArgumentValue, False)
                                End If
                            Next
                        End If
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



    Private Sub SetupSouceNotesRFunctionsInOperatorOnNew(clsOperator As ROperator)
        dataGridSourceNotes.Rows.Clear()

        For Each clsFootNoteFunctRParam As RParameter In clsOperator.clsParameters
            If clsFootNoteFunctRParam.strArgumentName.Contains("tab_source_note") Then
                ' Create a new row that represents the tab_footnote() parameters
                Dim row As New DataGridViewRow
                row.CreateCells(dataGridSourceNotes)

                Dim clsFooterRFunction As RFunction = clsFootNoteFunctRParam.clsArgumentCodeStructure
                For Each clsFootNoteRParam As RParameter In clsFooterRFunction.clsParameters
                    If clsFootNoteRParam.strArgumentName = "source_note" Then
                        ' Set the foot note text
                        row.Cells(0).Value = GetStringValue(clsFootNoteRParam.clsArgumentCodeStructure.clsParameters(0).strArgumentValue, False)
                    End If
                Next

                ' Tag and add the tab_footnote() function contents as a row
                row.Tag = clsFooterRFunction
                dataGridSourceNotes.Rows.Add(row)

            End If
        Next

        ' Always add a place holder row for new foot note
        dataGridSourceNotes.Rows.Add()

    End Sub


    Private Sub dataGridCellFooterNotes_EditingControlShowing(sender As Object, e As DataGridViewEditingControlShowingEventArgs) Handles dataGridCellFooterNotes.EditingControlShowing
        ' Check if the current column is the DataGridViewComboBoxColumn
        If dataGridCellFooterNotes.CurrentCell.ColumnIndex = 1 Then
            Dim comboBox As ComboBox = CType(e.Control, ComboBox)
            If comboBox IsNot Nothing Then
                comboBox.DropDownStyle = ComboBoxStyle.DropDown
                ' Remove any existing handler to avoid multiple assignments
                RemoveHandler comboBox.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged

                ' Add the new event handler
                AddHandler comboBox.SelectedIndexChanged, AddressOf ComboBox_SelectedIndexChanged
            End If
        End If
    End Sub

    Private Sub ComboBox_SelectedIndexChanged(sender As Object, e As EventArgs)
        Dim comboBox As ComboBox = CType(sender, ComboBox)
        If comboBox IsNot Nothing Then
            ' Now you can access the selected item
            Dim selectedItem As String = comboBox.SelectedItem.ToString()
            MessageBox.Show("Selected Item: " & selectedItem)
        End If
    End Sub

    Private Sub dataGridNotes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridHeaderFooterNotes.CellEndEdit, dataGridCellFooterNotes.CellEndEdit, dataGridSourceNotes.CellEndEdit
        Dim dataGrid As DataGridView = sender
        Dim row As DataGridViewRow = dataGrid.Rows.Item(e.RowIndex)
        Dim strNoteTextValue As String = row.Cells(0).Value

        ' If no foot note typed by user then just exit the sub
        If String.IsNullOrEmpty(strNoteTextValue) Then
            Exit Sub
        End If

        Dim clsNoteRFunction As RFunction = Nothing

        If dataGrid Is dataGridHeaderFooterNotes Then
            clsNoteRFunction = SetupAndGetNewNoteRFunction(row.Tag, "tab_footnote", "footnote", strNoteTextValue)
            ' Add column and row expressions as paramters if user has typed them
            If Not String.IsNullOrEmpty(row.Cells(1).Value) Then
                Dim clsFooterLocationNoteRFunction As New RFunction
                clsFooterLocationNoteRFunction.SetPackageName("gt")
                clsFooterLocationNoteRFunction.SetRCommand("cells_title")
                clsFooterLocationNoteRFunction.AddParameter(New RParameter(strParameterName:="groups", strParamValue:=GetStringValue(row.Cells(1).Value, True)))
                clsNoteRFunction.AddParameter(New RParameter(strParameterName:="locations", strParamValue:=clsFooterLocationNoteRFunction, iNewPosition:=1))
            End If

        ElseIf dataGrid Is dataGridCellFooterNotes Then

            clsNoteRFunction = SetupAndGetNewNoteRFunction(row.Tag, "tab_footnote", "footnote", strNoteTextValue)

            ' Add column and row expressions as paramters if user has typed them
            If Not String.IsNullOrEmpty(row.Cells(1).Value) AndAlso Not String.IsNullOrEmpty(row.Cells(2).Value) Then
                Dim clsFooterLocationNoteRFunction As New RFunction
                clsFooterLocationNoteRFunction.SetPackageName("gt")
                clsFooterLocationNoteRFunction.SetRCommand("cells_body")
                clsFooterLocationNoteRFunction.AddParameter(New RParameter(strParameterName:="columns", strParamValue:=GetStringValue(row.Cells(1).Value, False)))
                clsFooterLocationNoteRFunction.AddParameter(New RParameter(strParameterName:="rows", strParamValue:=GetStringValue(row.Cells(2).Value, False)))
                clsNoteRFunction.AddParameter(New RParameter(strParameterName:="locations", strParamValue:=clsFooterLocationNoteRFunction, iNewPosition:=1))
            End If

        ElseIf dataGrid Is dataGridSourceNotes Then
            clsNoteRFunction = SetupAndGetNewNoteRFunction(row.Tag, "tab_source_note", "source_note", strNoteTextValue)
        End If

        ' Overwrite the tag with the new foot function
        row.Tag = clsNoteRFunction

        ' If last row then add new empty row
        If e.RowIndex = dataGrid.Rows.Count - 1 Then
            dataGrid.Rows.Add()
        End If
    End Sub

    Private Function SetupAndGetNewNoteRFunction(clsPossibleNoteRFunction As RFunction, strNoteRCommand As String, strRNoteTextParameterName As String, strNoteTextValue As String) As RFunction
        Dim clsNewNoteRFunction As RFunction = clsPossibleNoteRFunction
        ' Get the prevous style parameter to retain any format options previously done
        Dim clsStyleParam As RParameter
        If clsNewNoteRFunction IsNot Nothing Then
            clsStyleParam = clsNewNoteRFunction.GetParameter(strRNoteTextParameterName).clsArgumentCodeStructure.GetParameter("style")
        Else
            clsStyleParam = New RParameter(strParameterName:="style", strParamValue:=GetNewStyleRFunction(), iNewPosition:=1)
        End If


        ' Recreate the footer function
        clsNewNoteRFunction = New RFunction
        clsNewNoteRFunction.SetPackageName("gt")
        clsNewNoteRFunction.SetRCommand(strNoteRCommand)

        Dim clsNoteTextRFunction As RFunction = GetNewHtmlDivRFunction()
        clsNoteTextRFunction.AddParameter(New RParameter(strParameterName:="", strParamValue:=GetStringValue(strNoteTextValue, True), iNewPosition:=0, bNewIncludeArgumentName:=False))
        clsNoteTextRFunction.AddParameter(clsStyleParam) ' Add the style parameter for formating

        ' Add the foot note text parameter to the footer R function
        clsNewNoteRFunction.AddParameter(New RParameter(strParameterName:=strRNoteTextParameterName, strParamValue:=clsNoteTextRFunction, iNewPosition:=0))
        Return clsNewNoteRFunction
    End Function

    Private Sub dataGridNotes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridHeaderFooterNotes.CellClick, dataGridCellFooterNotes.CellClick, dataGridSourceNotes.CellClick

        Dim dataGrid As DataGridView = sender
        Dim clsNoteRFunction As RFunction = dataGrid.Rows.Item(e.RowIndex).Tag
        Dim strParameterName As String = Nothing

        '---------------------------
        ' Ignore clicks that are not from button cells. 
        If dataGrid Is dataGridHeaderFooterNotes Then
            strParameterName = "footnote"
            If e.ColumnIndex <> 2 Then
                Exit Sub
            End If
        ElseIf dataGrid Is dataGridCellFooterNotes Then
            strParameterName = "footnote"
            If e.ColumnIndex <> 3 Then
                Exit Sub
            End If
        ElseIf dataGrid Is dataGridSourceNotes Then
            strParameterName = "source_note"
            If e.ColumnIndex <> 1 Then
                Exit Sub
            End If
        End If
        '---------------------------

        If clsNoteRFunction IsNot Nothing AndAlso strParameterName IsNot Nothing Then
            sdgTableOptionsTextFormat.Setup(clsNoteRFunction.GetParameter(strParameterName).clsArgumentCodeStructure.GetParameter("style").clsArgumentCodeStructure)
            sdgTableOptionsTextFormat.Show(Me)
        End If

    End Sub



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