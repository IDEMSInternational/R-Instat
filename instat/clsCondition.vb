Public Class Condition
    Private bIsParameterValues As Boolean = False
    Private bIsParameterPresenet As Boolean = False
    Private bIsFunctionNames As Boolean = False
    Private strParameterName As String = ""
    Private lstValues As List(Of String) = New List(Of String)
    Private bIsPositive As Boolean = True

    Public Sub SetParameterPresentName(strParamName As String, Optional bNewIsPositive As Boolean = True)
        strParameterName = strParamName
        bIsParameterPresenet = True
        bIsParameterValues = False
        bIsFunctionNames = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetParameterValues(strParamName As String, lstParamValues As List(Of String), Optional bNewIsPositive As Boolean = True)
        strParameterName = strParamName
        lstValues = lstParamValues
        bIsParameterValues = True
        bIsParameterPresenet = False
        bIsFunctionNames = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetParameterValues(strParamName As String, strParamValues As String, Optional bNewIsPositive As Boolean = True)
        SetParameterValues(strParamName, New List(Of String)({strParamValues}), bNewIsPositive)
    End Sub

    Public Sub SetFunctionName(strFuncName As String, Optional bNewIsPositive As Boolean = True)
        SetFunctionNamesMultiple(New List(Of String)({strFuncName}), bNewIsPositive)
    End Sub

    Public Sub SetFunctionNamesMultiple(lstFuncNames As List(Of String), Optional bNewIsPositive As Boolean = True)
        lstValues = lstFuncNames
        bIsFunctionNames = True
        bIsParameterValues = False
        bIsParameterPresenet = False
        bIsPositive = bNewIsPositive
    End Sub

    Public Function IsSatisfied(clsRCode As RCodeStructure) As Boolean
        Dim clsTempParam As RParameter
        Dim clsTempFunc As RFunction

        If bIsParameterValues Then
            clsTempParam = clsRCode.GetParameter(strParameterName)
            Return (clsTempParam IsNot Nothing AndAlso clsTempParam.bIsString AndAlso clsTempParam.strArgumentValue IsNot Nothing AndAlso (bIsPositive = lstValues.Contains(clsRCode.GetParameter(strParameterName).strArgumentValue)))
        ElseIf bIsParameterPresenet Then
            Return (bIsPositive = clsRCode.ContainsParameter(strParameterName))
        ElseIf bIsFunctionNames Then
            If TypeOf clsRCode Is RFunction Then
                clsTempFunc = CType(clsRCode, RFunction)
                Return (bIsPositive = lstValues.Contains(clsTempFunc.strRCommand))
            Else
                Return False
            End If
        Else
            Return True
        End If
    End Function
End Class