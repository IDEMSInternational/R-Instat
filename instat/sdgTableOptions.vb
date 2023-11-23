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

    Dim clsOperator As ROperator

    Private Sub sdgTableOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub


    ''' <summary>
    ''' An R operateor that has a parameter named "gt" set up.
    ''' The parameter should be an R Function that generates script "gt:gt()" as part of the last script statement.
    ''' </summary>
    ''' <param name="clsNewOperator"></param>
    Public Sub Setup(clsNewOperator As ROperator)
        Me.clsOperator = clsNewOperator

        If Not clsNewOperator.ContainsParameter("gt") Then
            MsgBox("Developer Error: Parameter with 'gt' as name MUST be set up before using this subdialog")
            Me.Close()
            Exit Sub
        End If

        SetHeaderControlsContents(clsOperator)
        SetFootersControlsContents(clsOperator)

    End Sub

    Private Sub ucrBaseSubdialog_ClickReturn(sender As Object, e As EventArgs) Handles ucrBaseSubdialog.ClickReturn
        SetHeaderRFunctions(clsOperator)
        SetFootersRFunctions(clsOperator)
    End Sub

    '-----------------------------------------
    ' Header controls
    Private Sub SetHeaderControlsContents(clsOperator As ROperator)

        ucrInputHeaderTitle.SetName("")
        ucrInputHeaderSubtitle.SetName("")

        If Not clsOperator.ContainsParameter("tab_header") Then
            Exit Sub
        End If

        Dim clsParam As RParameter = clsOperator.GetParameter("tab_header")
        If clsParam.clsArgumentCodeStructure.ContainsParameter("title") Then
            ucrInputHeaderTitle.SetName(GetStringValue(clsParam.clsArgumentCodeStructure.GetParameter("title").strArgumentValue, False))
        End If

        If clsParam.clsArgumentCodeStructure.ContainsParameter("subtitle") Then
            ucrInputHeaderSubtitle.SetName(GetStringValue(clsParam.clsArgumentCodeStructure.GetParameter("subtitle").strArgumentValue, False))
        End If
    End Sub

    Private Sub SetHeaderRFunctions(clsOperator As ROperator)
        If ucrInputHeaderTitle.IsEmpty() AndAlso ucrInputHeaderSubtitle.IsEmpty() Then
            clsOperator.RemoveParameterByName("tab_header")
            Exit Sub
        End If

        Dim clsHeaderRFunction As New RFunction

        If clsOperator.ContainsParameter("tab_header") Then
            clsHeaderRFunction = clsOperator.GetParameter("tab_header").clsArgumentCodeStructure
        Else
            clsHeaderRFunction.SetPackageName("gt")
            clsHeaderRFunction.SetRCommand("tab_header")
            clsOperator.AddParameter("tab_header", clsRFunctionParameter:=clsHeaderRFunction, bIncludeArgumentName:=False)
        End If

        If Not ucrInputHeaderTitle.IsEmpty() Then
            clsHeaderRFunction.AddParameter("title", GetStringValue(ucrInputHeaderTitle.GetText(), True))
        End If

        If Not ucrInputHeaderSubtitle.IsEmpty() Then
            clsHeaderRFunction.AddParameter("subtitle", GetStringValue(ucrInputHeaderSubtitle.GetText(), True))
        End If
    End Sub
    '-----------------------------------------

    '-----------------------------------------
    ' Footer controls

    Private Sub SetFootersControlsContents(clsOperator As ROperator)
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
                        row.Cells(0).Value = GetStringValue(clsFootNoteRParam.strArgumentValue, False)
                    ElseIf clsFootNoteRParam.strArgumentName = "locations" Then
                        ' todo go through the location function
                        Dim clsFooterLocationRFunction As RFunction = clsFootNoteFunctRParam.clsArgumentCodeStructure


                    End If
                Next

                ' Add the tab_footnote() function parameters as a row
                dataGridFooterNotes.Rows.Add(row)

            End If
        Next

        ' Always add a place holder row for new foot note
        dataGridFooterNotes.Rows.Add()

    End Sub

    Private Sub SetFootersRFunctions(clsOperator As ROperator)

        If dataGridFooterNotes.Rows.Count = 0 Then
            Exit Sub
        End If

        ' Remove all the previous footer parameters first
        Dim lstParams As New List(Of RParameter)
        For Each clsRParam As RParameter In clsOperator.clsParameters
            If clsRParam.strArgumentName.Contains("tab_footnote") Then
                lstParams.Add(clsRParam)
            End If
        Next
        For Each clsRParam As RParameter In lstParams
            clsOperator.RemoveParameter(clsRParam)
        Next

        ' Then add the new footer parameters
        For index As Integer = 0 To dataGridFooterNotes.Rows.Count - 1

            Dim row As DataGridViewRow = dataGridFooterNotes.Rows.Item(index)

            If String.IsNullOrEmpty(row.Cells(0).Value) Then
                Continue For
            End If
            Dim clsFooterRFunction As New RFunction
            clsFooterRFunction.SetPackageName("gt")
            clsFooterRFunction.SetRCommand("tab_footnote")
            clsFooterRFunction.AddParameter(New RParameter(strParameterName:="footnote", strParamValue:=GetStringValue(row.Cells(0).Value, True)))

            clsOperator.AddParameter("tab_footnote" & index, clsRFunctionParameter:=clsFooterRFunction, bIncludeArgumentName:=False)

        Next

    End Sub


    Private Sub sdgTableOptions_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Me.KeyPress

    End Sub

    Private Sub sdgTableOptions_Leave(sender As Object, e As EventArgs) Handles Me.Leave

    End Sub

    Private Sub dataGridFooterNotes_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridFooterNotes.CellValueChanged

    End Sub

    Private Sub dataGridFooterNotes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles dataGridFooterNotes.CellEndEdit
        AddNewEmptyRowAfterUserInput()
    End Sub

    Private Sub AddNewEmptyRowAfterUserInput()
        If dataGridFooterNotes.Rows.Count > 0 AndAlso Not String.IsNullOrEmpty(dataGridFooterNotes.Rows.Item(dataGridFooterNotes.Rows.Count - 1).Cells(0).Value) Then
            dataGridFooterNotes.Rows.Add()
        End If
    End Sub
    '-----------------------------------------

    '-----------------------------------------
    Private Function GetStringValue(str As String, bwithQuotes As Boolean) As String
        Return If(bwithQuotes, """" & str & """", str.Replace("""", ""))
    End Function


End Class