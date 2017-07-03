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

Imports instat
Imports RDotNet
Public Class ucrReorder
    Public Event OrderChanged()
    Public WithEvents ucrDataFrameList As ucrDataFrame
    Public WithEvents ucrReceiver As ucrReceiverSingle
    Private strDataType As String
    Dim selectedListViewItem As ListViewItem
    Dim selectedIndex As Integer
    Dim itemsCount As Integer
    Public bWithQuotes As Boolean = True

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        strDataType = ""
        selectedListViewItem = New ListViewItem
    End Sub

    Public Sub setDataType(strType As String)
        strDataType = strType
        lstAvailableData.Clear()
        Select Case strDataType
            Case "column"
                lstAvailableData.Columns.Add("Variables")
            Case "factor"
                lstAvailableData.Columns.Add("Levels")
            Case "data frame"
                lstAvailableData.Columns.Add("Data Frame")
            Case "metadata"
                lstAvailableData.Columns.Add("Metadata")
            Case "object"
                lstAvailableData.Columns.Add("Objects")
        End Select
        lstAvailableData.Columns(0).Width = -2
        LoadList()
    End Sub

    Private Sub cmdUp_Click(sender As Object, e As EventArgs) Handles cmdUp.Click
        If lstAvailableData.Items.Count > 0 And lstAvailableData.SelectedItems.Count > 0 Then
            selectedListViewItem = lstAvailableData.SelectedItems(0)
            selectedIndex = lstAvailableData.SelectedItems.Item(0).Index
            itemsCount = lstAvailableData.Items.Count
            'checks if the item is at the top, if true exits
            If selectedIndex = 0 Then
                Exit Sub
            Else
                lstAvailableData.Items.RemoveAt(selectedIndex)
                lstAvailableData.Items.Insert(selectedIndex - 1, selectedListViewItem)

            End If
            selectedListViewItem.Selected = True
            lstAvailableData.Select()
            selectedListViewItem.EnsureVisible()
            RaiseEvent OrderChanged()
        End If

    End Sub

    Private Sub cmdDown_click(sender As Object, e As EventArgs) Handles cmdDown.Click
        If lstAvailableData.Items.Count > 0 And lstAvailableData.SelectedItems.Count > 0 Then
            selectedListViewItem = lstAvailableData.SelectedItems(0)
            selectedIndex = selectedListViewItem.Index
            itemsCount = lstAvailableData.Items.Count
            'checks if the item is at the bottom, if true exits
            If selectedIndex = itemsCount - 1 Then
                Exit Sub
            Else
                lstAvailableData.Items.Remove(selectedListViewItem)
                lstAvailableData.Items.Insert(selectedIndex + 1, selectedListViewItem)
            End If
            selectedListViewItem.Selected = True
            lstAvailableData.Select()
            selectedListViewItem.EnsureVisible()
            RaiseEvent OrderChanged()
        End If
    End Sub

    Private Sub cmdBottom_Click(sender As Object, e As EventArgs) Handles cmdBottom.Click
        If lstAvailableData.Items.Count > 0 And lstAvailableData.SelectedItems.Count > 0 Then
            selectedListViewItem = lstAvailableData.SelectedItems(0)
            selectedIndex = selectedListViewItem.Index
            itemsCount = lstAvailableData.Items.Count
            'checks if the item is at the bottom, if not moves it to the bottom
            If Not selectedIndex = itemsCount - 1 Then
                lstAvailableData.Items.Remove(selectedListViewItem)
                lstAvailableData.Items.Insert(itemsCount - 1, selectedListViewItem)
            End If
            selectedListViewItem.Selected = True
            lstAvailableData.Select()
            selectedListViewItem.EnsureVisible()
            RaiseEvent OrderChanged()
        End If
    End Sub

    Private Sub cmdTop_Click(sender As Object, e As EventArgs) Handles cmdTop.Click
        If lstAvailableData.Items.Count > 0 And lstAvailableData.SelectedItems.Count > 0 Then
            selectedListViewItem = lstAvailableData.SelectedItems(0)
            selectedIndex = selectedListViewItem.Index
            itemsCount = lstAvailableData.Items.Count
            'checks if the item is at the top, if not moves it to the top
            If Not selectedIndex = 0 Then
                lstAvailableData.Items.Remove(selectedListViewItem)
                lstAvailableData.Items.Insert(0, selectedListViewItem)
            End If
            selectedListViewItem.Selected = True
            lstAvailableData.Select()
            selectedListViewItem.EnsureVisible()
            RaiseEvent OrderChanged()
        End If
    End Sub

    Public Function GetVariableNames(Optional bWithQuotes As Boolean = True) As String
        Dim strTemp As String = ""
        Dim i As Integer
        If lstAvailableData.Items.Count = 1 Then
            If bWithQuotes Then
                strTemp = Chr(34) & lstAvailableData.Items(0).Text & Chr(34)
            Else
                strTemp = lstAvailableData.Items(0).Text
            End If
        ElseIf lstAvailableData.Items.Count > 1 Then
            strTemp = "c" & "("
            For i = 0 To lstAvailableData.Items.Count - 1
                If i > 0 Then
                    strTemp = strTemp & ","
                End If
                If bWithQuotes Then
                    strTemp = strTemp & Chr(34) & lstAvailableData.Items(i).Text & Chr(34)
                Else
                    strTemp = strTemp & lstAvailableData.Items(i).Text
                End If
            Next
            strTemp = strTemp & ")"
        End If

        Return strTemp
    End Function

    Public Sub setDataframes(dfDataframes As ucrDataFrame)
        ucrDataFrameList = dfDataframes
        LoadList()
    End Sub

    Public Sub setReceiver(dfSingle As ucrReceiverSingle)
        ucrReceiver = dfSingle
        LoadList()
    End Sub

    Public Sub LoadList()
        Dim vecNames As CharacterVector = Nothing
        Select Case strDataType
            Case "column"
                If ucrDataFrameList IsNot Nothing AndAlso ucrDataFrameList.cboAvailableDataFrames.Text <> "" Then
                    vecNames = frmMain.clsRLink.RunInternalScriptGetValue(frmMain.clsRLink.strInstatDataObject & "$get_column_names(data_name = " & Chr(34) & ucrDataFrameList.cboAvailableDataFrames.SelectedItem & Chr(34) & ")").AsCharacter
                End If
            Case "factor"
                'Using Contains means ordered factors will also be shown.
                If ucrReceiver IsNot Nothing AndAlso Not ucrReceiver.IsEmpty() AndAlso ucrReceiver.strCurrDataType.Contains("factor") Then
                    vecNames = frmMain.clsRLink.RunInternalScriptGetValue(frmMain.clsRLink.strInstatDataObject & "$get_column_factor_levels(data_name = " & Chr(34) & ucrReceiver.GetDataName() & Chr(34) & ", col_name = " & ucrReceiver.GetVariableNames() & ")").AsCharacter
                End If
            Case "data frame"
                vecNames = frmMain.clsRLink.RunInternalScriptGetValue(frmMain.clsRLink.strInstatDataObject & "$get_data_names()").AsCharacter
            Case "metadata"
                If ucrDataFrameList IsNot Nothing AndAlso ucrDataFrameList.cboAvailableDataFrames.Text <> "" Then
                    vecNames = frmMain.clsRLink.RunInternalScriptGetValue(frmMain.clsRLink.strInstatDataObject & "$get_metadata_fields(data_name = " & Chr(34) & ucrDataFrameList.cboAvailableDataFrames.Text & Chr(34) & ")").AsCharacter
                End If
            Case "object"
                If ucrDataFrameList IsNot Nothing AndAlso ucrDataFrameList.cboAvailableDataFrames.Text <> "" Then
                    vecNames = frmMain.clsRLink.RunInternalScriptGetValue(frmMain.clsRLink.strInstatDataObject & "$get_object_names(data_name = " & Chr(34) & ucrDataFrameList.cboAvailableDataFrames.Text & Chr(34) & ")").AsCharacter
                End If
            Case Else
                vecNames = Nothing
        End Select
        FillListView(vecNames)
    End Sub

    Private Sub FillListView(vecNames As CharacterVector)
        If vecNames IsNot Nothing Then
            lstAvailableData.Items.Clear()
            For i = 0 To vecNames.Count - 1
                lstAvailableData.Items.Add(vecNames(i))
            Next
            RaiseEvent OrderChanged()
        Else
            lstAvailableData.Items.Clear()
        End If
    End Sub

    Private Sub FillListView(strItems As String())
        If strItems IsNot Nothing Then
            lstAvailableData.Items.Clear()
            For i = 0 To strItems.Count - 1
                lstAvailableData.Items.Add(strItems(i))
            Next
            RaiseEvent OrderChanged()
        Else
            lstAvailableData.Items.Clear()
        End If
    End Sub

    Private Sub ucrDataFrameList_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrDataFrameList.DataFrameChanged
        LoadList()
    End Sub

    Private Sub ucrReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiver.SelectionChanged
        LoadList()
    End Sub

    'to update this to check if the order has changed
    Public Function IsEmpty() As Boolean
        If lstAvailableData.Items.Count > 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Sub Reset()
        lstAvailableData.Items.Clear()
    End Sub

    Protected Overrides Sub SetControlValue()
        Dim lstCurrentVariables As String()
        Dim clsMainParameter As RParameter

        clsMainParameter = GetParameter()
        If clsMainParameter IsNot Nothing AndAlso clsMainParameter.bIsString AndAlso clsMainParameter.strArgumentValue IsNot Nothing Then
            lstCurrentVariables = ExtractItemsFromRList(clsMainParameter.strArgumentValue)
            SetToValue(lstCurrentVariables)
        End If
    End Sub

    Protected Overrides Sub SetToValue(objTemp As Object)
        Dim strTemp As String()
        Dim chrTemp As CharacterVector

        If objTemp Is Nothing Then
            FillListView(New String() {})
        Else
            If TypeOf objTemp Is String() Then
                strTemp = CType(objTemp, String())
                FillListView(strTemp)
            ElseIf TypeOf objTemp Is CharacterVector Then
                chrTemp = CType(objTemp, CharacterVector)
                FillListView(chrTemp)
            Else
                MsgBox("Developer error: Cannot set the value of " & Name & " because cannot convert value of object to String() or CharacterVector.")
            End If
        End If
    End Sub

    Private Sub ucrReorder_OrderChanged() Handles Me.OrderChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If clsTempParam Is Nothing Then
            clsTempParam = New RParameter
        End If
        clsTempParam.SetArgumentValue(GetVariableNames(bWithQuotes))
    End Sub

    Private Sub ucrReorder_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadList()
    End Sub
End Class
