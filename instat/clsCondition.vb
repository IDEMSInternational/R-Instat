Public Class Condition
    Private bIsParameterValues As Boolean = False
    Private bIsParameterPresent As Boolean = False
    Private bIsFunctionNames As Boolean = False
    Private bIsParameterType As Boolean = False
    Private strParameterType As String = ""
    Private strParameterName As String = ""
    Private lstValues As List(Of String) = New List(Of String)
    Private bIsPositive As Boolean = True

    Public Sub SetParameterPresentName(strParamName As String, Optional bNewIsPositive As Boolean = True)
        strParameterName = strParamName
        bIsParameterPresent = True
        bIsParameterValues = False
        bIsFunctionNames = False
        bIsParameterType = False
        strParameterType = ""
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetParameterValues(strParamName As String, lstParamValues As List(Of String), Optional bNewIsPositive As Boolean = True)
        strParameterName = strParamName
        lstValues = lstParamValues
        bIsParameterValues = True
        bIsParameterPresent = False
        bIsFunctionNames = False
        bIsParameterType = False
        strParameterType = ""
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
        bIsParameterPresent = False
        bIsParameterType = False
        strParameterType = ""
        bIsPositive = bNewIsPositive
    End Sub

    Public Sub SetParameterType(strType As String, strParamName As String, Optional bNewIsPositive As Boolean = True)
        bIsFunctionNames = False
        bIsParameterValues = False
        bIsParameterPresent = False
        bIsParameterType = True
        strParameterName = strParamName
        If Not {"string", "RFunction", "ROperator"}.Contains(strType) Then
            MsgBox("Developer error: strType must be either string, RFunction or ROperator.")
            strParameterType = ""
        Else
            strParameterType = strType
        End If
    End Sub

    Public Function IsSatisfied(clsRCode As RCodeStructure, Optional clsParameter As RParameter = Nothing) As Boolean
        Dim clsTempParam As RParameter
        Dim clsTempFunc As RFunction

        If bIsParameterValues Then
            If clsParameter IsNot Nothing Then
                clsTempParam = clsParameter
            Else
                clsTempParam = clsRCode.GetParameter(strParameterName)
            End If
            Return (clsTempParam IsNot Nothing AndAlso clsTempParam.bIsString AndAlso clsTempParam.strArgumentValue IsNot Nothing AndAlso (bIsPositive = lstValues.Contains(clsTempParam.strArgumentValue)))
        ElseIf bIsParameterPresent Then
            Return (bIsPositive = clsRCode.ContainsParameter(strParameterName))
        ElseIf bIsFunctionNames Then
            If TypeOf clsRCode Is RFunction Then
                clsTempFunc = CType(clsRCode, RFunction)
                Return (bIsPositive = lstValues.Contains(clsTempFunc.strRCommand))
            Else
                Return False
            End If
        ElseIf bIsParameterType Then
            If Not clsRCode.ContainsParameter(strParameterName) Then
                Return Not bIsPositive
            Else
                clsTempParam = clsRCode.GetParameter(strParameterName)
                Select Case strParameterType
                    Case "string"
                        Return (bIsPositive = clsTempParam.bIsString)
                    Case "RFunction"
                        Return (bIsPositive = clsTempParam.bIsFunction)
                    Case "ROperator"
                        Return (bIsPositive = clsTempParam.bIsOperator)
                    Case Else
                        MsgBox("Developer error: strType must be either string, RFunction or ROperator.")
                        Return False
                End Select
            End If
        Else
            Return True
        End If
    End Function
End Class