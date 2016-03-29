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
    Dim strDataFrameName As String = ""

    Public Overrides Sub AddSelected()
        Dim objItem As ListViewItem
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As ListViewItem

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
        For Each objItem In tempObjects
            SetSelected(objItem.Text, objItem.Group.Name)
        Next

    End Sub

    Public Sub SetSelected(strColumn As String, strDataFrame As String)
        strDataFrameName = strDataFrame
        txtReceiverSingle.Text = strColumn
    End Sub

    Public Overrides Sub RemoveSelected()

        txtReceiverSingle.Text = ""
        strDataFrameName = ""

    End Sub

    Public Overrides Sub Clear()
        RemoveSelected()
    End Sub

    Public Overrides Function IsEmpty() As Boolean

        If txtReceiverSingle.Text <> "" Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Overrides Function GetVariables(Optional bForceAsDataFrame As Boolean = False) As RFunction
        'return columns (in data frame) in both cases
        'call GetVariableNames
        Dim clsGetVariablesFunc As New RFunction
        Dim clsParam As New RParameter
        If txtReceiverSingle.Text <> "" Then
            clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
            clsGetVariablesFunc.AddParameter("data_name", Chr(34) & strDataFrameName & Chr(34))
            clsGetVariablesFunc.AddParameter("col_name", GetVariableNames())
            If bForceAsDataFrame Then
                clsGetVariablesFunc.AddParameter("force_as_data_frame", "TRUE")
            Else
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsGetVariablesFunc.AddParameter("force_as_data_frame", "FALSE")
                End If
            End If
                'TODO make this an option set in Options menu
                clsGetVariablesFunc.SetAssignTo(txtReceiverSingle.Text)
            Return clsGetVariablesFunc
        Else
            Return clsGetVariablesFunc
        End If
    End Function

    Public Overrides Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        If txtReceiverSingle.Text <> "" Then
            If bWithQuotes Then
                strTemp = Chr(34) & txtReceiverSingle.Text & Chr(34)
            Else
                strTemp = txtReceiverSingle.Text
            End If
        End If
        Return strTemp
    End Function

    Public Function GetDataName() As String
        Return strDataFrameName
    End Function

    Public Event SelectionChanged(sender As Object, e As EventArgs)

    Private Sub txtReceiverSingle_TextChanged(sender As Object, e As EventArgs) Handles txtReceiverSingle.TextChanged
        OnValueChanged(sender, e)
        RaiseEvent SelectionChanged(sender, e)
    End Sub

    Public Overrides Sub SetColor()
        txtReceiverSingle.BackColor = Color.Aqua
    End Sub

    Public Overrides Sub RemoveColor()
        txtReceiverSingle.BackColor = Color.White
    End Sub

    Private Sub txtReceiverSingle_KeyDown(sender As Object, e As KeyEventArgs) Handles txtReceiverSingle.KeyDown
        If e.KeyCode = Keys.Delete Or e.KeyCode = Keys.Back Then
            RemoveSelected()
        End If
    End Sub

    Private Sub RemoveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RemoveToolStripMenuItem.Click
        RemoveSelected()
    End Sub

    Public Sub SetStackedFactorMode(bDisableReceiver As Boolean)
        If bDisableReceiver Then
            txtReceiverSingle.Text = "variable"
            txtReceiverSingle.Enabled = False
        End If
    End Sub

End Class

