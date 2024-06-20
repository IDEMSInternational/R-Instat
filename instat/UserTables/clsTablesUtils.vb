Imports System.Reflection

Public Class clsTablesUtils

    Public Shared Function GetNewHtmlSpanRFunction() As RFunction
        Dim clsHtmlDivRFunction As New RFunction
        clsHtmlDivRFunction.SetPackageName("htmltools")
        clsHtmlDivRFunction.SetRCommand("tags$span")
        Return clsHtmlDivRFunction
    End Function

    Public Shared Function GetNewHtmlStyleRFunction() As RFunction
        Dim clsStyleRFunction As New RFunction
        clsStyleRFunction.SetPackageName("htmltools")
        clsStyleRFunction.SetRCommand("css")
        Return clsStyleRFunction
    End Function

    Public Shared Sub ShowTextFormatSubDialog(owner As Form, clsHtmlTagRFunction As RFunction)
        If Not clsHtmlTagRFunction.ContainsParameter("style") Then
            clsHtmlTagRFunction.AddParameter(strParameterName:="style", clsRFunctionParameter:=GetNewHtmlStyleRFunction(), iPosition:=1)
        End If
        sdgTableOptionsTextFormat.Setup(clsHtmlTagRFunction.GetParameter("style").clsArgumentCodeStructure)
        sdgTableOptionsTextFormat.ShowDialog(owner)
    End Sub

    Public Shared Function FindRFunctionsWithRCommand(strRCommandName As String, clsOperator As ROperator) As List(Of RFunction)
        Dim lstRFunctions As New List(Of RFunction)
        For Each clsRParam As RParameter In clsOperator.clsParameters
            If clsRParam.bIsFunction AndAlso clsRParam.HasValue() Then
                Dim rFunction As RFunction = clsRParam.clsArgumentCodeStructure
                If rFunction.strRCommand = strRCommandName Then
                    lstRFunctions.Add(rFunction)
                End If
            End If
        Next
        Return lstRFunctions
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
    ''' <param name="strRCommandName"> e.g tab_style </param>
    ''' <param name="strParamName"> e.g locations</param>
    ''' <param name="strParamValueRCommand">e.g cells_body</param>
    ''' <param name="clsOperator">Operator that contains the parent strRCommandName</param>
    ''' <returns></returns>
    Public Shared Function FindRFunctionsParamsWithRParamValue(strRCommandName As String, strParamName As String, strParamValueRCommand As String, clsOperator As ROperator) As List(Of RParameter)

        Dim lstRFunctionParams As List(Of RParameter) = FindRFunctionsParamsWithRCommand({strRCommandName}, clsOperator)
        Dim lstRFunctionsParamsFound As New List(Of RParameter)

        For Each clsRParam As RParameter In lstRFunctionParams
            Dim rFunctionParent As RFunction = clsRParam.clsArgumentCodeStructure
            If rFunctionParent.strRCommand = strRCommandName AndAlso rFunctionParent.ContainsParameter(strParamName) Then

                Dim rFunctionchild As RFunction = rFunctionParent.GetParameter(strParamName).clsArgumentCodeStructure
                If rFunctionchild.strRCommand = strParamValueRCommand Then
                    lstRFunctionsParamsFound.Add(clsRParam)
                End If

            End If
        Next
        Return lstRFunctionsParamsFound
    End Function


    ' TODO. Delete
    Public Shared Sub RemoveParameterFromOperator(strParameterNames() As String, clsOperator As ROperator)
        ' Remove all the previous footer parameters first
        Dim lstParams As New List(Of RParameter)
        For Each clsRParam As RParameter In clsOperator.clsParameters
            If strParameterNames.Contains(clsRParam.strArgumentName) Then
                lstParams.Add(clsRParam)
            End If
        Next
        For Each clsRParam As RParameter In lstParams
            clsOperator.RemoveParameter(clsRParam)
        Next
    End Sub


    'TODO. Delete
    Public Shared Sub SetGridTagsInOperator(dataGrid As DataGridView, strParameterName As String, clsOperator As ROperator)

        If dataGrid.Rows.Count = 0 Then
            Exit Sub
        End If

        ' Then add the new footer parameters
        For index As Integer = 0 To dataGrid.Rows.Count - 1
            Dim clsFooterRFunction As RFunction = dataGrid.Rows.Item(index).Tag
            If clsFooterRFunction IsNot Nothing Then
                clsOperator.AddParameter(strParameterName & index, clsRFunctionParameter:=clsFooterRFunction, bIncludeArgumentName:=False)
            End If
        Next

    End Sub

    Public Shared Function GetStringValue(str As String, bwithQuotes As Boolean) As String
        If String.IsNullOrEmpty(str) Then
            str = ""
        End If
        Return If(bwithQuotes, """" & str & """", str.Replace("""", ""))
    End Function

End Class
