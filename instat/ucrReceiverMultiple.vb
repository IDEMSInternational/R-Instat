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

Public Class ucrReceiverMultiple
    Dim objSelected As New List(Of ListViewItem)
    Public Overrides Sub AddSelected()
        Dim objItem As ListViewItem
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As Object

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
        For Each objItem In tempObjects
            If Not objSelected.Contains(objItem) Then
                objSelected.Add(objItem)
                lstSelectedVariables.Items.Add(objItem.Text)
            End If
        Next

    End Sub

    Public Overrides Sub RemoveSelected()
        Dim objItem As ListViewItem
        Dim tempObjects(lstSelectedVariables.SelectedItems.Count - 1) As Object
        Dim i As Integer

        If lstSelectedVariables.SelectedItems.Count > 0 Then
            lstSelectedVariables.SelectedItems.CopyTo(tempObjects, 0)
            For Each objItem In tempObjects
                lstSelectedVariables.Items.Remove(objItem)
                i = objSelected.FindIndex(Function(x) x.Text.Equals(objItem.Text))
                If i <> -1 Then
                    objSelected.RemoveAt(i)
                End If
            Next
        End If
    End Sub

    Public Overrides Function GetVariables() As RFunction
        'TODO sort this out
        Dim clsGetVariablesFunc As New RFunction
        Dim lstCurrDataFrames As List(Of String)
        Dim strCurrDataFrame As String
        lstCurrDataFrames = GetDataFrameNames()

        If lstCurrDataFrames.Count = 1 Then
            strCurrDataFrame = lstCurrDataFrames(0)
            clsRSyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data", clsFunction:=clsGetVariablesFunc)
            clsRSyntax.AddParameter("data_name", Chr(34) & strCurrDataFrame & Chr(34), clsRFunction:=clsGetVariablesFunc)
            clsRSyntax.AddParameter("col_names", GetVariableNames(), clsRFunction:=clsGetVariablesFunc)
            'TODO make this an option set in Options menu
            'clsRSyntax.SetAssignTo(MakeValidRString(strCurrDataFrame) & "_temp", clsFunction:=clsGetVariablesFunc)
        Else
        End If
        Return clsGetVariablesFunc
    End Function

    Public Overrides Function GetVariableNames() As String
        Dim strTemp As String = ""
        Dim i As Integer
        If objSelected.Count = 1 Then
            strTemp = Chr(34) & objSelected(0).Text & Chr(34)
        ElseIf objSelected.Count > 1 Then
            strTemp = "c" & "("
            For i = 0 To objSelected.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                strTemp = strTemp & Chr(34) & objSelected(i).Text & Chr(34)
            Next
            strTemp = strTemp & ")"
        End If

        Return strTemp
    End Function

    Public Function GetDataFrameNames() As List(Of String)
        Dim strDataFrames As New List(Of String)

        For Each CurrObj In objSelected
            If Not strDataFrames.Contains(CurrObj.Group.ToString) Then
                strDataFrames.Add(CurrObj.Group.ToString)
            End If
        Next

        Return strDataFrames
    End Function
End Class