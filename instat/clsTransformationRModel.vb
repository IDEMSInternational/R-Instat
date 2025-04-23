Imports Newtonsoft.Json
Imports Newtonsoft.Json.Converters
Imports RInsightF461

''' <summary>
''' Each instance of this class specifies how to make a single update to an R model (a 
''' representation of a valid R script). The R model is updated based on the current state of an 
''' entry in a dictionary of configurable values.<para>
''' A list of instances of this class can be used to fully update an R model based upon the 
''' current state of the dictionary.</para>
''' </summary>
Public Class clsTransformationRModel

    ''' <summary>
    ''' Surround the updated value in the R model with quotes (e.g. 'f("myValue")').
    ''' </summary>
    Public bIsQuoted As Boolean = False

    ''' <summary>
    ''' Used when locating the function to update in the R model. If the function occurs more 
    ''' than once in the statement, this value specifies which occurrence to update.
    ''' </summary>
    Public iOccurence As UInteger

    ''' <summary>
    ''' The parameter to update (starting from 0).
    ''' </summary>
    Public iParameterNumber As UInteger

    ''' <summary>
    ''' The statement number in the R model to update.
    ''' </summary>
    Public iStatementNumber As UInteger

    ''' <summary>
    ''' A list of child transformations to execute if the specified condition is successful.
    ''' </summary>
    Public lstTransformations As List(Of clsTransformationRModel)

    ''' <summary>
    ''' The name of the function to update in the R model.
    ''' </summary>
    Public strFunctionName As String

    ''' <summary>
    ''' The name of the parameter to update in the R model.
    ''' </summary>
    Public strParameterName As String

    ''' <summary>
    ''' A valid R script to update the R model with.
    ''' </summary>
    Public strScript As String

    ''' <summary>
    ''' Used as part of the condition in some transformations.
    ''' </summary>
    Public strValueDefault As String = "TRUE"
    Public strValueKey As String

    ''' <summary>
    ''' The type of transformation to perform
    ''' </summary>
    Public Enum TransformationType
        functionAddParam
        functionAddRemoveParamByName
        functionRemoveParamByName
        functionUpdateParamValue
        ifFalseExecuteChildTransformations
        ifTrueExecuteChildTransformations
        operatorAddParam
        operatorUpdateParam
        operatorUpdateParamPresentation
        quoteEmptyString
    End Enum

    <JsonConverter(GetType(StringEnumConverter))>
    Public enumTransformationType As TransformationType = TransformationType.functionUpdateParamValue


    ''' <summary>
    ''' Updates <paramref name="rScript"/> using <paramref name="dctConfigurableValues"/> and the 
    ''' data members of this object.
    ''' </summary>
    ''' <param name="rScript">               The R model to update</param>
    ''' <param name="dctConfigurableValues"> The dictionary of configurable values to reference 
    '''                                      when performing the transformation</param>
    Public Sub updateRModel(rScript As RScript, dctConfigurableValues As Dictionary(Of String, String))

        Dim strValue As String = If(String.IsNullOrEmpty(strValueKey), strScript, dctConfigurableValues(strValueKey))

        Select Case enumTransformationType
            Case TransformationType.functionAddParam
                rScript.FunctionAddParam(iStatementNumber, strFunctionName, strParameterName, strValue, iParameterNumber, bIsQuoted)

            Case TransformationType.functionAddRemoveParamByName
                If String.IsNullOrEmpty(strValue) OrElse strValue = strValueDefault Then
                    rScript.FunctionRemoveParamByName(iStatementNumber, strFunctionName, strParameterName)
                Else
                    rScript.FunctionAddParam(iStatementNumber, strFunctionName, strParameterName, strValue, iParameterNumber, bIsQuoted)
                End If

            Case TransformationType.functionRemoveParamByName
                rScript.FunctionRemoveParamByName(iStatementNumber, strFunctionName, strParameterName)

            Case TransformationType.functionUpdateParamValue
                rScript.FunctionUpdateParamValue(iStatementNumber, strFunctionName, iParameterNumber, strValue, bIsQuoted, iOccurence)

            Case TransformationType.ifFalseExecuteChildTransformations
                If Not strValue = strValueDefault Then
                    ExecuteChildTransformations(rScript, dctConfigurableValues)
                End If

            Case TransformationType.ifTrueExecuteChildTransformations
                If strValue = strValueDefault Then
                    ExecuteChildTransformations(rScript, dctConfigurableValues)
                End If

            Case TransformationType.operatorAddParam
                rScript.OperatorAddParam(iStatementNumber, strFunctionName, iParameterNumber, strValue)

            Case TransformationType.operatorUpdateParam
                rScript.OperatorUpdateParam(iStatementNumber, strFunctionName, iParameterNumber, strValue)

            Case TransformationType.operatorUpdateParamPresentation
                rScript.OperatorUpdateParamPresentation(iStatementNumber, strFunctionName, iParameterNumber, strValue)

            Case TransformationType.quoteEmptyString
                If String.IsNullOrEmpty(strValue) Then
                    rScript.FunctionUpdateParamValue(iStatementNumber, strFunctionName, iParameterNumber, "", True)
                Else
                    rScript.FunctionUpdateParamValue(iStatementNumber, strFunctionName, iParameterNumber, strValue, bIsQuoted)
                End If
        End Select
    End Sub

    Private Sub ExecuteChildTransformations(rScript As RScript, dctConfigurableValues As Dictionary(Of String, String))
        For Each transform As clsTransformationRModel In lstTransformations
            transform.updateRModel(rScript, dctConfigurableValues)
        Next
    End Sub
End Class
