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

    Private Sub ucrReceiverMultiple_Load(sender As Object, e As EventArgs) Handles Me.Load
        If lstSelectedVariables.Columns.Count = 0 Then
            lstSelectedVariables.Columns.Add("Selected Data")
            lstSelectedVariables.Columns(0).Width = -2
        End If
    End Sub

    Public Event SelectionChanged()

    Public Overrides Sub AddSelected()
        Dim objItem As ListViewItem
        Dim tempObjects(Selector.lstAvailableVariable.SelectedItems.Count - 1) As Object
        Dim grpTemp As ListViewGroup

        Selector.lstAvailableVariable.SelectedItems.CopyTo(tempObjects, 0)
        For Each objItem In tempObjects
            If Not lstSelectedVariables.Items.Contains(objItem) Then
                If Not GetCurrHeaders().Contains(objItem.Group.Header) Then
                    grpTemp = New ListViewGroup(objItem.Group.Header, HorizontalAlignment.Left)
                    grpTemp.Name = objItem.Group.Header
                    lstSelectedVariables.Groups.Add(grpTemp)
                Else
                    grpTemp = lstSelectedVariables.Groups(objItem.Group.Header)
                End If
                lstSelectedVariables.Items.Add(objItem.Text).Group = grpTemp
            End If
        Next
        RaiseEvent SelectionChanged()

    End Sub

    Private Function GetCurrHeaders() As List(Of String)
        Dim strHeaders As New List(Of String)
        Dim grpTemp As ListViewGroup

        For Each grpTemp In lstSelectedVariables.Groups
            If Not strHeaders.Contains(grpTemp.Header) Then
                strHeaders.Add(grpTemp.Header)
            End If
        Next
        Return strHeaders
    End Function
    Public Overrides Sub RemoveSelected()
        Dim objItem As ListViewItem
        Dim tempObjects(lstSelectedVariables.SelectedItems.Count - 1) As Object

        If lstSelectedVariables.SelectedItems.Count > 0 Then
            lstSelectedVariables.SelectedItems.CopyTo(tempObjects, 0)
            For Each objItem In tempObjects
                lstSelectedVariables.Items.Remove(objItem)
            Next
        End If
        RaiseEvent SelectionChanged()
    End Sub

    Public Overrides Sub Clear()

        lstSelectedVariables.Items.Clear()
        RaiseEvent SelectionChanged()

    End Sub

    Public Overrides Function GetVariables() As RFunction
        'TODO sort this out
        Dim clsGetVariablesFunc As New RFunction
        Dim lstCurrDataFrames As List(Of String)
        Dim strCurrDataFrame As String
        lstCurrDataFrames = GetDataFrameNames()

        If lstCurrDataFrames.Count = 1 Then
            strCurrDataFrame = lstCurrDataFrames(0)
            clsGetVariablesFunc.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
            clsGetVariablesFunc.AddParameter("data_name", Chr(34) & strCurrDataFrame & Chr(34))
            clsGetVariablesFunc.AddParameter("col_names", GetVariableNames())
            'TODO make this an option set in Options menu
            'clsRSyntax.SetAssignTo(MakeValidRString(strCurrDataFrame) & "_temp", clsFunction:=clsGetVariablesFunc)
        End If
        Return clsGetVariablesFunc
    End Function

    Public Overrides Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        Dim i As Integer
        If lstSelectedVariables.Items.Count = 1 Then
            strTemp = Chr(34) & lstSelectedVariables.Items(0).Text & Chr(34)
        ElseIf lstSelectedVariables.Items.Count > 1 Then
            strTemp = "c" & "("
            For i = 0 To lstSelectedVariables.Items.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                If lstSelectedVariables.Items(i).Text <> "" Then
                    If bWithQuotes Then
                        strTemp = strTemp & Chr(34) & lstSelectedVariables.Items(i).Text & Chr(34)
                    Else
                        strTemp = strTemp & lstSelectedVariables.Items(i).Text
                    End If
                End If
            Next
            strTemp = strTemp & ")"
        End If

        Return strTemp
    End Function

    Public Function GetDataFrameNames() As List(Of String)
        Dim strDataFrames As New List(Of String)
        Dim CurrObj As ListViewItem

        For Each CurrObj In lstSelectedVariables.Items
            If Not strDataFrames.Contains(CurrObj.Group.Header) Then
                strDataFrames.Add(CurrObj.Group.Header)
            End If
        Next

        Return strDataFrames
    End Function

    Public Overrides Sub SetColor()
        lstSelectedVariables.BackColor = Color.Aqua
    End Sub

    Public Overrides Sub RemoveColor()
        lstSelectedVariables.BackColor = Color.White
    End Sub

    Private Sub lstSelectedVariables_KeyDown(sender As Object, e As KeyEventArgs) Handles lstSelectedVariables.KeyDown
        If e.KeyCode = Keys.Delete Then
            RemoveSelected()
        End If
    End Sub
End Class