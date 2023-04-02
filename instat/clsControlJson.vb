Imports System.ComponentModel
Imports System.Reflection
Imports System.Runtime
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Serialization

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

        Public Property dctProperties As Dictionary(Of String, Object)

        Public Sub New(ucrCore As ucrCore)
            MyBase.New(ucrCore)
            dctProperties = New Dictionary(Of String, Object)
            Dim bindingFlags As Reflection.BindingFlags =
                Reflection.BindingFlags.Public _
                Or Reflection.BindingFlags.NonPublic _
                Or Reflection.BindingFlags.Instance _
                Or Reflection.BindingFlags.FlattenHierarchy
            For Each clsField As Reflection.FieldInfo In ucrCore.GetType().GetFields(bindingFlags)
                Dim clsFieldType As Type = clsField.FieldType
                If clsFieldType Is GetType(String) OrElse clsFieldType.IsPrimitive Then
                    dctProperties.Add(clsField.Name, clsField.GetValue(ucrCore))
                ElseIf clsFieldType Is GetType(RFunction) Then
                    Console.WriteLine(clsFieldType.ToString())
                    Dim clsJsonSettings As New JsonSerializerSettings With {
                            .Formatting = Formatting.Indented,
                            .ContractResolver = New clsContractResolver()
                    }
                    Console.WriteLine(JsonConvert.SerializeObject(clsField.GetValue(ucrCore), clsJsonSettings))
                Else
                    dctProperties.Add(clsField.Name, clsFieldType.ToString() & " TODO")
                End If
            Next
        End Sub

        Public Class clsContractResolver
            Inherits DefaultContractResolver

            'Protected Overrides Function CreateProperties(type As Type, memberSerialization As MemberSerialization) As IList(Of JsonProperty)
            '    Dim props As IList(Of JsonProperty) = MyBase.CreateProperties(type, memberSerialization)
            '    Dim allProps As IList(Of JsonProperty) = type.GetProperties(BindingFlags.NonPublic Or BindingFlags.Public Or BindingFlags.Instance).Select(Function(p) MyBase.CreateProperty(p, memberSerialization)).ToList()
            '    For Each clsProperty In allProps
            '        clsProperty.Writable = clsProperty.Readable
            '    Next

            '    Return allProps
            'End Function

            Protected Overrides Function CreateProperties(type As Type, memberSerialization As MemberSerialization) As IList(Of JsonProperty)
                Dim props As IList(Of JsonProperty) = MyBase.CreateProperties(type, memberSerialization)
                Dim allFields = type.GetFields(BindingFlags.Public Or BindingFlags.NonPublic Or BindingFlags.Instance)

                For Each field In allFields
                    If props.All(Function(p) p.PropertyName <> field.Name) Then
                        Dim prop = MyBase.CreateProperty(field, memberSerialization)
                        prop.Writable = prop.Readable = True
                        prop.PropertyName = field.Name
                        props.Add(prop)
                    End If
                Next

                Return props
            End Function
        End Class

    End Class

End Class


