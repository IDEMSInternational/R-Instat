Public Class Condition
    Private strType As String = "ParameterValue"
    Private strParameterName As String = ""
    Private lstValues As List(Of String) = New List(Of String)

    Public Sub SetParameterPresentName(strParamName As String)
        strType = "ParameterPresent"
        strParameterName = strParamName
    End Sub

    Public Sub SetParameterValues(strParamName As String, lstParamValues As List(Of String))
        strType = "ParameterValue"
        strParameterName = strParamName
        lstValues = lstParamValues
    End Sub

    Public Sub SetParameterValues(strParamName As String, strParamValues As String)
        strType = "ParameterValue"
        strParameterName = strParamName
        lstValues = New List(Of String)({strParamValues})
    End Sub

    Public Sub SetFunctionName(strFuncName As String)
        strType = "FunctionName"
        lstValues = New List(Of String)({strFuncName})
    End Sub

    Public Sub SetFunctionNamesMultiple(lstFuncNames As List(Of String))
        strType = "FunctionName"
        lstValues = lstFuncNames
    End Sub
End Class
