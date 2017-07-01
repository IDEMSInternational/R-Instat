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
Public Class dlgFind
    Public currWindow As Form
    Dim targetPos As Integer = 0

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 406
    End Sub
    Private Sub cmdFindNext_Click(sender As Object, e As EventArgs) Handles cmdFindNext.Click

        Select Case currWindow.Name
            Case "frmLog"
                searchTextBox(frmLog.txtLog, targetPos)

            Case "frmCommand"
                searchTextBox(frmCommand.txtCommand, targetPos)

            Case "frmScript"
                searchTextBox(frmScript.txtScript, targetPos)

            Case "frmEditor"
                searchDataView(targetPos)

            Case Nothing
                Exit Sub
        End Select
    End Sub

    Private Sub dlgFind_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtFindWhat.Focus()
    End Sub

    Private Sub txtFindWhat_TextChanged(sender As Object, e As EventArgs) Handles txtFindWhat.TextChanged
        If txtFindWhat.Text <> "" Then
            TestEnabled()
        Else
            cmdFindAll.Enabled = False
            cmdFindNext.Enabled = False
        End If
        targetPos = 0
    End Sub

    Private Sub searchTextBox(tmpTxtBox As TextBoxBase, startIndex As Integer)
        Dim pos As Integer = 0
        Dim s As String = tmpTxtBox.Text
        Dim j As Integer = s.IndexOf(txtFindWhat.Text, targetPos)
        If j < 0 Then
            MsgBox("Not found")
            txtFindWhat.Focus()
        Else
            tmpTxtBox.Focus()
            If TypeOf tmpTxtBox Is RichTextBox Then
                tmpTxtBox.Select(j, txtFindWhat.Text.Length)
            Else
                tmpTxtBox.SelectionStart = j
                tmpTxtBox.SelectionLength = txtFindWhat.Text.Length
            End If
            targetPos = j + 1
        End If
    End Sub

    Private Sub searchDataView(startIndex As Integer)
        Dim currSheet = frmEditor.grdData.CurrentWorksheet
        Dim addressList As New List(Of Tuple(Of Integer, Integer))
        currSheet.IterateCells(unvell.ReoGrid.RangePosition.EntireRange, Function(row, col, cell)
                                                                             If cell.DisplayText.Contains(txtFindWhat.Text) Then
                                                                                 addressList.Add(New Tuple(Of Integer, Integer)(cell.Row, cell.Column))
                                                                                 ''currSheet.StartEdit(cell.Row, cell.Column)
                                                                                 'cell.StartEdit()
                                                                                 'Return False
                                                                             End If
                                                                             Return True
                                                                         End Function)
        If startIndex < addressList.Count Then
            currSheet.StartEdit(addressList.Item(startIndex).Item1, addressList.Item(startIndex).Item2)
        Else
            MsgBox("End of search")
        End If

        targetPos = startIndex + 1
    End Sub

    Private Sub dlgFind_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Me.Text = "Search in " & currWindow.Text
        TestEnabled()
    End Sub

    Private Sub TestEnabled()
        If currWindow.Name = "frmEditor" Then
            cmdFindNext.Enabled = True
            Me.AcceptButton = cmdFindNext
            cmdFindAll.Enabled = False
        ElseIf currWindow.Name = "frmCommand" Or currWindow.Name = "frmLog" Or currWindow.Name = "frmScript" Then
            cmdFindNext.Enabled = True
            Me.AcceptButton = cmdFindNext
            cmdFindAll.Enabled = False
        End If
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

End Class