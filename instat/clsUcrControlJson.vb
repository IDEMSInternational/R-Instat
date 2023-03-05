Imports System.ComponentModel
Imports Newtonsoft.Json

Public Class clsUcrControlJson
    Public Property strName As String
    Public Property lstUcrJson As List(Of clsUcrControlJson)

    Public Sub New(clsControl As Control)

        strName = ""
        lstUcrJson = New List(Of clsUcrControlJson)

        If IsNothing(clsControl) OrElse String.IsNullOrEmpty(clsControl.Name) Then
            Exit Sub
        End If

        strName = clsControl.Name

        If IsNothing(clsControl.Controls) Then
            Exit Sub
        End If

        For Each ctlChild As Control In clsControl.Controls
            'Recursively process different types of menus and child controls
            If TypeOf ctlChild Is MenuStrip OrElse TypeOf ctlChild Is ToolStrip Then
                'ignore
            ElseIf TypeOf ctlChild Is Control Then
                lstUcrJson.Add(New clsUcrControlJson(ctlChild))
            End If
        Next
    End Sub

    Public Function ToJsonString() As String
        Return JsonConvert.SerializeObject(Me)
    End Function

    Public Shared Function FromJsonString(jsonString As String) As clsUcrControlJson
        Return JsonConvert.DeserializeObject(Of clsUcrControlJson)(jsonString)
    End Function
End Class
