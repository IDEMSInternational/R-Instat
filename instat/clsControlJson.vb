Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

Public Class clsControlJson
    Public Property strName As String
    Public Property strType As String
    Public Property dctFields As Dictionary(Of String, Object)

    Public Sub New(clsControl As Control)

        strName = clsControl.Name
        strType = clsControl.GetType().Name

        dctFields = New Dictionary(Of String, Object)
        Dim bindingFlags As Reflection.BindingFlags =
                Reflection.BindingFlags.Public _
                Or Reflection.BindingFlags.NonPublic _
                Or Reflection.BindingFlags.Instance _
                Or Reflection.BindingFlags.FlattenHierarchy

        For Each clsField As Reflection.FieldInfo In clsControl.GetType().GetFields(bindingFlags)
            Dim clsFieldType As Type = clsField.FieldType
            If clsFieldType Is GetType(ucrNud) Then
                Console.WriteLine("*** ignored ucrNud: " & clsField.Name)
            ElseIf GetType(Control).IsAssignableFrom(clsFieldType) Then
                Console.WriteLine(clsField.Name)
                dctFields.Add(clsField.Name, New clsControlJson(clsField.GetValue(clsControl)))
                'Else
                '    dctFields.Add(clsField.Name, clsField.GetValue(clsControl))
                '    Dim clsJsonSettings As New JsonSerializerSettings With {
                '            .ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                '            .Formatting = Formatting.Indented
                '    }
                '    Console.WriteLine("***" & clsField.Name & vbCrLf & JsonConvert.SerializeObject(clsField.GetValue(clsControl), clsJsonSettings))
            End If
        Next

    End Sub

    Public Function ToJsonString() As String
        Dim clsJsonSettings As New JsonSerializerSettings With {
            .ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
            .Formatting = Formatting.Indented
        }
        Return JsonConvert.SerializeObject(Me, clsJsonSettings)
    End Function

    Public Shared Function FromJsonString(jsonString As String) As clsControlJson
        Return JsonConvert.DeserializeObject(Of clsControlJson)(jsonString)
    End Function

End Class


