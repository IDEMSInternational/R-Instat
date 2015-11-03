' Stats System
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
Imports RDotNet
Public Class ucrDataSelection
    Dim ucr As ucrSelected
    Dim lstSelectedVariables As ListBox = ucr.lstSelectedVariables

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (lstAvailableVariable.SelectedItem <> "") Then
            lstSelectedVariables.Items.Add(lstAvailableVariable.SelectedItem)
            lstAvailableVariable.Items.Remove(lstAvailableVariable.SelectedItem)

        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        If (lstSelectedVariables.SelectedItem <> "") Then
            lstAvailableVariable.Items.Add(lstSelectedVariables.SelectedItems)
            lstSelectedVariables.Items.Remove(lstSelectedVariables.SelectedItems)
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub

    Private Sub ucrDataSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dataset As DataFrame
        Dim i As Integer
        dataset = frmMain.clsRInterface.GetData("data")
        For i = 0 To dataset.ColumnCount - 1
            lstAvailableVariable.Items.Add(dataset.ColumnNames(i))
        Next
    End Sub

    Private Sub lstAvailableVariable_MouseDoubleClick(sender As Object, e As EventArgs) Handles lstAvailableVariable.MouseDoubleClick
        If (lstAvailableVariable.SelectedItem <> "") Then
            lstSelectedVariables.Items.Add(lstAvailableVariable.SelectedItems)
            lstAvailableVariable.Items.Remove(lstAvailableVariable.SelectedItems)
        Else
            MsgBox("Please select a column", vbInformation, "Message from Instat")
        End If
    End Sub

    Private Sub lstAvailableVariable_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstAvailableVariable.SelectedIndexChanged

    End Sub

    Private Sub lstAvailableVariable_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lstAvailableVariable.MouseDoubleClick

    End Sub
End Class
