Public Class Distribution
    Public strNameTag As String
    Public strRFunctionName As String = ""
    Public strPFunctionName As String = ""
    Public strQFunctionName As String = ""
    Public strDFunctionName As String = ""
    Public strGLMFunctionName As String = ""
    Public clsParameters As New List(Of DistributionParameter)

    Public Sub SetNameTag(strTemp As String)
        strNameTag = strTemp
    End Sub

    Public Sub AddParameter(strArgumentName, strNameTag)
        Dim NewParameter As New DistributionParameter
        NewParameter.strArgumentName = strArgumentName
        NewParameter.strNameTag = strNameTag
        clsParameters.Add(NewParameter)
    End Sub
End Class

Public Class DistributionParameter
    Public strArgumentName As String
    Public strNameTag As String

End Class