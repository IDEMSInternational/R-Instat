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

    Public Overrides Function GetVariables() As RFunction
        Dim clsGetVariablesFunc As New RFunction
        If bSelected Then
            clsRSyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_column_from_data", clsFunction:=clsGetVariablesFunc)
            clsRSyntax.AddParameter("data_name", Chr(34) & objSelected.Group.ToString() & Chr(34), clsRFunction:=clsGetVariablesFunc)
            clsRSyntax.AddParameter("col_name", Chr(34) & objSelected.Text & Chr(34), clsRFunction:=clsGetVariablesFunc)
            clsRSyntax.SetAssignTo(objSelected.Text, clsFunction:=clsGetVariablesFunc)
            Return clsGetVariablesFunc
        Else
            Return clsGetVariablesFunc
        End If
    End Function

    Private Sub txtReceiverSingle_TextChanged(sender As Object, e As EventArgs) Handles txtReceiverSingle.TextChanged
        OnValueChanged(sender, e)
    End Sub

End Class

