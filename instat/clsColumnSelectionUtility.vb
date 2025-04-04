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

Public Class clsColumnSelectionUtility

    ''' <summary>
    ''' Selects a column based on the provided parameters.
    ''' </summary>
    ''' <param name="ucrSelector">An object representing the selector (must expose a lstAvailableVariable with Items and a strCurrentDataFrame property).</param>
    ''' <param name="ucrReceiver">An object representing the receiver that has an Add method.</param>
    ''' <param name="dummyFunction">An instance of the dummy function (or related class) that provides GetParameter.</param>
    ''' <param name="dataName">Name of the current data frame.</param>
    ''' <param name="selectedColumn">The current selected column value (it will be updated by this method).</param>
    Public Shared Sub SetSelectedColumn(ByVal ucrSelector As ListView,
                                          ByVal ucrReceiver As Object,
                                          ByVal dummyFunction As Object,
                                          ByVal dataName As String,
                                          ByRef selectedColumn As String)
        Dim tempSelectedVariable As String = ""
        Dim temp As String = ""

        ' Retrieve parameter value safely
        Dim clsParam = dummyFunction.GetParameter("strVal")
        If clsParam IsNot Nothing Then
            temp = clsParam.strArgumentValue
        End If

        ' If selectedColumn is valid and a factor, use it
        If Not String.IsNullOrEmpty(selectedColumn) AndAlso
          frmMain.clsRLink.GetDataType(dataName, selectedColumn).Contains("factor") Then
            tempSelectedVariable = selectedColumn
        ElseIf ucrSelector.Items.Count > 0 Then
            ' If no valid selected column, use the first available variable
            tempSelectedVariable = ucrSelector.Items(0).Text
        Else
            ' No available variables, exit the method
            Exit Sub
        End If

        ' If temp takes precedence, update tempSelectedVariable
        If Not String.IsNullOrEmpty(temp) AndAlso tempSelectedVariable <> temp Then
            tempSelectedVariable = temp
        End If

        ' Add the selected variable to the receiver
        ucrReceiver.Add(tempSelectedVariable, dataName)

        ' Optionally update the selected column (if needed)
        selectedColumn = tempSelectedVariable
    End Sub
End Class

