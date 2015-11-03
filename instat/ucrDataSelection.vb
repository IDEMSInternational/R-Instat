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
Imports RDotNet

Public Class ucrDataSelection
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
            lstAvailableVariable.Items.Add(lstSelectedVariables.SelectedItem)
            lstSelectedVariables.Items.Remove(lstSelectedVariables.SelectedItem)
        Else
            MsgBox("No item was selected", vbInformation, "Selection message")
        End If
    End Sub

    Private Sub ucrDataSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cvDataset As CharacterVector
        Dim aDataset As Array
        Dim i As Integer

        cvDataset = frmMain.clsRInterface.GetVariables("colnames(data)")
        aDataset = cvDataset.ToArray
        For i = 0 To aDataset.GetLength(0) - 1
            lstAvailableVariable.Items.Add(aDataset(i))
        Next

    End Sub

End Class
