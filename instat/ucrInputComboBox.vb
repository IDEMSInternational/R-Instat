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
Imports System.ComponentModel

Public Class ucrInputComboBox
    Dim strItemsType As String = ""

    Private Sub cboInput_Validating(sender As Object, e As CancelEventArgs) Handles cboInput.Validating
        e.Cancel = Not ValidateText(cboInput.Text)
    End Sub

    Public Sub SetItemsTypeAsColumns()
        strItemsType = "Columns"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsDataFrames()
        strItemsType = "Data Frames"
        FillItemTypes()
    End Sub

    Public Sub SetItemsTypeAsModels()
        strItemsType = "Models"
        FillItemTypes()
    End Sub

    Private Sub FillItemTypes()
        Select Case strItemsType
            Case "Columns"
                If ucrDataFrameSelector IsNot Nothing Then
                    frmMain.clsRLink.FillColumnNames(ucrDataFrameSelector.cboAvailableDataFrames.Text, cboColumns:=cboInput)
                End If
            Case "Data Frames"
            Case "Models"
                cboInput.Items.Add(frmMain.clsRLink.GetModelNames().ToArray)
        End Select
    End Sub

    Public Sub ucrDataFrameSelector_DataFrameChanged() Handles ucrDataFrameSelector.DataFrameChanged
        FillItemTypes()
    End Sub

    Public Overrides Sub SetName(strName As String)
        If ValidateText(strName) Then
            cboInput.Text = strName
            OnNameChanged()
        End If
    End Sub

    Public Overrides Function GetText() As String
        Return cboInput.Text
    End Function

    Public Sub AddItems(strItems As String())
        cboInput.Items.AddRange(strItems)
    End Sub

    Private Sub cboInput_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cboInput.KeyPress
        bUserTyped = True
    End Sub
End Class
