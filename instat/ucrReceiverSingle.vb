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

Public Class ucrReceiverSingle
    Dim objSelected As New ListViewItem
    Dim bSelected As Boolean = False

    Public Overrides Sub AddSelected()
        Dim objItem As Object
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As Object

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
        For Each objItem In tempObjects
            objSelected = objItem
            bSelected = True
            txtReceiverSingle.Text = objItem.text
        Next

    End Sub

    Public Overrides Sub RemoveSelected()

        If txtReceiverSingle.Text <> "" Then
            bSelected = False
            txtReceiverSingle.Text = Nothing
        End If
    End Sub

    Public Overrides Sub Clear()

        If txtReceiverSingle.Text <> "" Then
            bSelected = False
            txtReceiverSingle.Text = Nothing
        End If
    End Sub

    Public Overrides Function GetVariables() As RFunction
        'return columns (in data frame) in both cases
        'call GetVariableNames
        Dim clsGetVariablesFunc As New RFunction
        Dim clsParam As New RParameter
        If bSelected Then
            clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
            clsGetVariablesFunc.AddParameter("data_name", Chr(34) & objSelected.Group.ToString() & Chr(34))
            clsGetVariablesFunc.AddParameter("col_name", GetVariableNames())
            'TODO make this an option set in Options menu
            clsGetVariablesFunc.SetAssignTo(MakeValidRString(objSelected.Text))
            Return clsGetVariablesFunc
        Else
            Return clsGetVariablesFunc
        End If
    End Function

    Public Overrides Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        If txtReceiverSingle.Text <> "" Then
            If bWithQuotes Then
                strTemp = Chr(34) & objSelected.Text & Chr(34)
            Else
                strTemp = objSelected.Text
            End If
        End If
        Return strTemp
    End Function

    Private Sub txtReceiverSingle_TextChanged(sender As Object, e As EventArgs) Handles txtReceiverSingle.TextChanged
        OnValueChanged(sender, e)
    End Sub

    Public Overrides Sub SetColor()
        txtReceiverSingle.BackColor = Color.Aqua
    End Sub

    Public Overrides Sub RemoveColor()
        txtReceiverSingle.BackColor = Color.White
    End Sub

End Class

