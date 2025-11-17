Imports System.Reflection

Public Class clsTablesUtils

    Public Shared Function ShowStyleSubDialog(owner As Form, Optional clsListStyleRFunction As RFunction = Nothing) As RFunction
        If clsListStyleRFunction IsNot Nothing AndAlso clsListStyleRFunction.ContainsParameter("style") Then
            sdgTableStyles.Setup(clsListStyleRFunction.GetParameter("style").clsArgumentCodeStructure)
        Else
            sdgTableStyles.Setup()
        End If

        sdgTableStyles.ShowDialog(owner)
        Return sdgTableStyles.GetNewUserInputAsRFunction()
    End Function

    Public Shared Function GetNewStyleRFunction(clsListStyleRFunction As RFunction, clsLocationsRFunction As RFunction) As RFunction
        Dim clsTabStyleRFunction As New RFunction
        clsTabStyleRFunction.SetPackageName("gt")
        clsTabStyleRFunction.SetRCommand("tab_style")
        clsTabStyleRFunction.AddParameter(strParameterName:="style", clsRFunctionParameter:=clsListStyleRFunction, iPosition:=0)
        clsTabStyleRFunction.AddParameter(strParameterName:="locations", clsRFunctionParameter:=clsLocationsRFunction, iPosition:=1)
        Return clsTabStyleRFunction
    End Function

    Public Shared Function FindRFunctionsParamsWithRCommand(strRCommandNames() As String, clsOperator As ROperator) As List(Of RParameter)
        Dim lstRFunctionParams As New List(Of RParameter)
        For Each clsRParam As RParameter In clsOperator.clsParameters
            If clsRParam.bIsFunction AndAlso clsRParam.HasValue() Then
                If strRCommandNames.Contains(DirectCast(clsRParam.clsArgumentCodeStructure, RFunction).strRCommand) Then
                    lstRFunctionParams.Add(clsRParam)
                End If
            End If
        Next
        Return lstRFunctionParams
    End Function

    Public Shared Sub RemoveRFunctionsParamsWithRCommand(strRCommandNames() As String, clsOperator As ROperator)
        ' Remove all the previous footer parameters first
        Dim lstParams As New List(Of RParameter)
        For Each clsRParam As RParameter In clsOperator.clsParameters
            If clsRParam.bIsFunction AndAlso clsRParam.HasValue() Then
                If strRCommandNames.Contains(DirectCast(clsRParam.clsArgumentCodeStructure, RFunction).strRCommand) Then
                    lstParams.Add(clsRParam)
                End If
            End If
        Next

        RemoveRParams(lstParams, clsOperator)
    End Sub

    Public Shared Sub RemoveRParams(lstParams As IEnumerable(Of RParameter), clsOperator As ROperator)
        For Each clsRParam As RParameter In lstParams
            clsOperator.RemoveParameter(clsRParam)
        Next
    End Sub

    Public Shared Sub AddGridRowTagsRParamsToROperator(dataGrid As DataGridView, clsOperator As ROperator)
        For index As Integer = 0 To dataGrid.Rows.Count - 1
            If dataGrid.Rows.Item(index).Tag IsNot Nothing Then
                Dim clsRParam As RParameter = dataGrid.Rows.Item(index).Tag
                clsOperator.AddParameter(clsRParam)
            End If
        Next
    End Sub

    ''' <summary>
    ''' E.g Finding cells_body in R Function tab_style( style = cell_fill(color = "gray85"),  locations = cells_body() ) 
    ''' </summary>
    ''' <param name="strRCommandNames"> e.g tab_style </param>
    ''' <param name="strParamName"> e.g locations</param>
    ''' <param name="strParamValueRCommand">e.g cells_body</param>
    ''' <param name="clsOperator">Operator that contains the parent strRCommandName</param>
    ''' <returns></returns>
    Public Shared Function FindRFunctionsParamsWithRParamValue(strRCommandNames() As String, strParamName As String, strParamValueRCommand As String, clsOperator As ROperator) As List(Of RParameter)

        Dim lstRFunctionParams As List(Of RParameter) = FindRFunctionsParamsWithRCommand(strRCommandNames, clsOperator)
        Dim lstRFunctionsParamsFound As New List(Of RParameter)

        For Each clsRParam As RParameter In lstRFunctionParams
            Dim rFunctionParent As RFunction = clsRParam.clsArgumentCodeStructure
            If strRCommandNames.Contains(rFunctionParent.strRCommand) AndAlso rFunctionParent.ContainsParameter(strParamName) Then

                Dim rFunctionchild As RFunction = rFunctionParent.GetParameter(strParamName).clsArgumentCodeStructure
                If rFunctionchild.strRCommand = strParamValueRCommand Then
                    lstRFunctionsParamsFound.Add(clsRParam)
                End If

            End If
        Next
        Return lstRFunctionsParamsFound
    End Function

    Public Shared Function GetStringValue(str As String, bwithQuotes As Boolean, Optional strQuoteCharacter As String = """") As String
        If String.IsNullOrEmpty(str) Then
            str = ""
        End If
        Return If(bwithQuotes, strQuoteCharacter & str & strQuoteCharacter, str.Replace(strQuoteCharacter, ""))
    End Function

    Public Shared Function SplitRText(input As String) As String()
        If input.StartsWith("c(") AndAlso input.EndsWith(")") Then
            ' Remove "c(" and ")"
            Dim trimmed As String = input.Substring(2, input.Length - 3)
            ' Split by comma and trim spaces
            Dim parts As String() = trimmed.Split(","c)
            Return parts
        Else
            Return {input}
        End If
    End Function

End Class
