' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat.Translations
Public Class dlgFind
    Public currWindow As Form
    Dim targetPos As Integer = 0
    Private Sub cmdFindNext_Click(sender As Object, e As EventArgs) Handles cmdFindNext.Click

        Select Case currWindow.Name
            Case "frmLog"
                searchTextBox(frmLog.txtLog, targetPos)

            Case "frmScript"
                searchTextBox(frmScript.txtScript, targetPos)

            Case "frmEditor"
                Dim currSheet = frmEditor.grdData.CurrentWorksheet
                'Dim selRange As New unvell.ReoGrid.RangePosition
                'selRange = currSheet.SelectionRange

                currSheet.IterateCells(unvell.ReoGrid.RangePosition.EntireRange, Function(row, col, cell)
                                                                                     If cell.DisplayText.Contains(txtFindWhat.Text) Then
                                                                                         MessageBox.Show(cell.Address)

                                                                                         'currSheet.SelectionRange = New unvell.ReoGrid.RangePosition(cell.Address)
                                                                                     End If
                                                                                     Return True
                                                                                 End Function)
            Case Nothing
                Exit Sub
        End Select
    End Sub

    Private Sub dlgFind_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtFindWhat.Focus()
    End Sub

    Private Sub txtFindWhat_TextChanged(sender As Object, e As EventArgs) Handles txtFindWhat.TextChanged
        frmCommand.txtCommand.Select(0, frmCommand.txtCommand.TextLength)
        frmCommand.txtCommand.SelectionBackColor = frmCommand.txtCommand.BackColor
    End Sub

    Private Sub searchRtf(txtbase As RichTextBox)
        Dim pos As Integer = 0
        Dim s As String = txtbase.Text
        Dim i As Integer = 0
        Dim StopWhile As Boolean = False
        While Not StopWhile
            Dim j As Integer = s.IndexOf(txtFindWhat.Text, i)
            If j < 0 Then
                StopWhile = True
            Else
                txtbase.Select(j, txtFindWhat.Text.Length)
                txtbase.SelectionColor = Color.Blue

                i = j + 1
            End If
        End While
    End Sub

    Private Sub searchTextBox(tmpTxtBox As TextBox, startIndex As Integer)
        Dim pos As Integer = 0
        Dim s As String = tmpTxtBox.Text
        Dim j As Integer = s.IndexOf(txtFindWhat.Text, targetPos)
        If j < 0 Then
            MsgBox("Not found")
            txtFindWhat.Focus()
        Else
            tmpTxtBox.SelectionStart = j
            tmpTxtBox.SelectionLength = txtFindWhat.Text.Length
            tmpTxtBox.Focus()
            targetPos = j + 1
        End If
    End Sub

    Private Sub dlgFind_Activated(sender As Object, e As EventArgs) Handles Me.Activated

        If currWindow.Name = "frmCommand" Then
            cmdFindAll.Enabled = True
            cmdFindNext.Enabled = False
        ElseIf currWindow.Name = "frmEditor" Or currWindow.Name = "frmLog" Or currWindow.Name = "frmScript" Then
            cmdFindNext.Enabled = True
            cmdFindAll.Enabled = False
        End If

    End Sub

    Private Sub cmdFindAll_Click(sender As Object, e As EventArgs) Handles cmdFindAll.Click
        Select Case currWindow.Name
            Case "frmCommand"
                searchRtf(frmCommand.txtCommand)
            Case Nothing
                Exit Sub
        End Select
    End Sub

    Private Sub cmdClose_Click(sender As Object, e As EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub
End Class