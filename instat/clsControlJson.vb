Imports System.ComponentModel
Imports Newtonsoft.Json

Public Class clsControlJson
    Public Property strName As String
    Public Property strControlType As String
    Public Property strText As String
    Public Property iLeft As Integer
    Public Property iTop As Integer
    Public Property iWidth As Integer
    Public Property iHeight As Integer
    Public Property lstUcrJson As List(Of clsControlJson)

    Public Sub New(clsControl As Control)

        strName = clsControl.Name
        strControlType = clsControl.GetType().Name
        strText = clsControl.Text
        iLeft = clsControl.Left
        iTop = clsControl.Top
        iWidth = clsControl.Width
        iHeight = clsControl.Height

        lstUcrJson = New List(Of clsControlJson)
        For Each ctlChild As Control In clsControl.Controls
            'Recursively process different types of menus and child controls
            If TypeOf ctlChild Is MenuStrip OrElse TypeOf ctlChild Is ToolStrip Then
                'ignore
            ElseIf TypeOf ctlChild Is ucrCore Then
                lstUcrJson.Add(New clsUcrCoreJson(ctlChild))
            ElseIf TypeOf ctlChild Is Control Then
                lstUcrJson.Add(New clsControlJson(ctlChild))
            End If
        Next
    End Sub

    Public Function ToJsonString() As String
        Dim clsJsonSettings As New JsonSerializerSettings With {
            .Formatting = Formatting.Indented
        }
        Return JsonConvert.SerializeObject(Me, clsJsonSettings)
    End Function

    Public Shared Function FromJsonString(jsonString As String) As clsControlJson
        Return JsonConvert.DeserializeObject(Of clsControlJson)(jsonString)
    End Function
    Private Class clsUcrCoreJson
        Inherits clsControlJson

        Public Property bAddRemoveParameter As Boolean

        Public Sub New(clsControl As ucrCore)
            MyBase.New(clsControl)
            bAddRemoveParameter = clsControl.bAddRemoveParameter
        End Sub
    End Class
End Class


