Public Class Condition
    Private bIsParameterValues As Boolean = False
    Private bIsParameterPresenet As Boolean = False
    Private bIsFunctionNames As Boolean = False
    Private strParameterName As String = ""
    Private lstValues As List(Of String) = New List(Of String)

    Public Sub SetParameterPresentName(strParamName As String)
        strParameterName = strParamName
        bIsParameterPresenet = True
        bIsParameterValues = False
        bIsFunctionNames = False
    End Sub

    Public Sub SetParameterValues(strParamName As String, lstParamValues As List(Of String))
        strParameterName = strParamName
        lstValues = lstParamValues
        bIsParameterValues = True
        bIsParameterPresenet = False
        bIsFunctionNames = False
    End Sub

    Public Sub SetParameterValues(strParamName As String, strParamValues As String)
        SetParameterValues(strParamName, New List(Of String)({strParamValues}))
    End Sub

    Public Sub SetFunctionName(strFuncName As String)
        SetFunctionNamesMultiple(New List(Of String)({strFuncName}))
    End Sub

    Public Sub SetFunctionNamesMultiple(lstFuncNames As List(Of String))
        lstValues = lstFuncNames
        bIsFunctionNames = True
        bIsParameterValues = False
        bIsParameterPresenet = False
    End Sub

    Public Function IsSatisfied(clsRCode As RCodeStructure) As Boolean
        Dim clsTempParam As RParameter
        Dim clsTempFunc As RFunction

        If bIsParameterValues Then
            clsTempParam = clsRCode.GetParameter(strParameterName)
            Return (clsTempParam IsNot Nothing AndAlso clsTempParam.bIsString AndAlso clsTempParam.strArgumentValue IsNot Nothing AndAlso lstValues.Contains(clsRCode.GetParameter(strParameterName).strArgumentValue))
        ElseIf bIsParameterPresenet Then
            Return (clsRCode.ContainsParameter(strParameterName))
        ElseIf bIsFunctionNames Then
            If TypeOf clsRCode Is RFunction Then
                clsTempFunc = CType(clsRCode, RFunction)
                Return lstValues.Contains(clsTempFunc.strRCommand)
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function
End Class