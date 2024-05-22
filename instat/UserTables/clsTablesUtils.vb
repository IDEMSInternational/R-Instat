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
        'Dim rclone = clsHtmlTagRFunction.GetParameter("style").clsArgumentCodeStructure.Clone()
        'sdgTableOptionsTextFormat.Setup(rclone)
        sdgTableOptionsTextFormat.Setup(clsHtmlTagRFunction.GetParameter("style").clsArgumentCodeStructure)
        sdgTableOptionsTextFormat.ShowDialog(owner)
        'clsHtmlTagRFunction.GetParameter("style").clsArgumentCodeStructure = rclone.Clone()
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

    Public Shared Function FindRFunctionsParamsWithRCommand(strRCommandName As String, clsOperator As ROperator) As List(Of RParameter)
        Dim lstRFunctionParams As New List(Of RParameter)
        For Each clsRParam As RParameter In clsOperator.clsParameters
            If clsRParam.bIsFunction AndAlso clsRParam.HasValue() Then
                If DirectCast(clsRParam.clsArgumentCodeStructure, RFunction).strRCommand = strRCommandName Then
                    lstRFunctionParams.Add(clsRParam)
                End If
            End If
        Next
        Return lstRFunctionParams
    End Function

    Public Shared Sub RemoveParameterFromOperator(strParameterName As String, clsOperator As ROperator)
        ' Remove all the previous footer parameters first
        Dim lstParams As New List(Of RParameter)
        For Each clsRParam As RParameter In clsOperator.clsParameters
            If clsRParam.strArgumentName.Contains(strParameterName) Then
                lstParams.Add(clsRParam)
            End If
        Next
        For Each clsRParam As RParameter In lstParams
            clsOperator.RemoveParameter(clsRParam)
        Next
    End Sub

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
