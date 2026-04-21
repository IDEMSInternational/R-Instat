Imports Antlr.Runtime

Public Class ucrColumnHide
    Private clsOperator As New ROperator
    Private clsColHideRFunction As RFunction

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, strTableName As String)
        Me.clsOperator = clsOperator

        ' Set up the selector and receiver
        ucrReceiverMultipleCols.strObjectName = strTableName
        If String.IsNullOrEmpty(strTableName) Then
            ucrSelectorByDF.Visible = True
            ucrSelectorByTableDF.Visible = False
            ucrSelectorByDF.SetDataframe(strDataFrameName, bEnableDataframe:=False)
            ucrReceiverMultipleCols.Selector = ucrSelectorByDF
        Else
            ucrSelectorByDF.Visible = False
            ucrSelectorByTableDF.Visible = True
            ucrSelectorByTableDF.SetDataframe(strDataFrameName, bEnableDataframe:=False)
            ucrReceiverMultipleCols.Selector = ucrSelectorByTableDF
        End If
        ucrReceiverMultipleCols.SetMeAsReceiver()
        ucrReceiverMultipleCols.Clear()

        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand({"cols_hide"}, clsOperator)
        If lstRParams.Count > 0 Then
            clsColHideRFunction = lstRParams(0).clsArgumentCodeStructure
            Dim arrColumnNames As String() = clsTablesUtils.SplitRText(clsColHideRFunction.GetParameter("columns").strArgumentValue)
            For Each columnName As String In arrColumnNames
                ucrReceiverMultipleCols.Add(columnName.Replace("`", ""))
            Next
        Else
            clsColHideRFunction = New RFunction
            clsColHideRFunction.SetPackageName("gt")
            clsColHideRFunction.SetRCommand("cols_hide")
        End If
    End Sub

    Public Sub SetValuesToOperator()
        ' Remove any previous cell footers 
        Dim lstRParams As List(Of RParameter) = clsTablesUtils.FindRFunctionsParamsWithRCommand({"cols_hide"}, clsOperator)
        For Each clsRParam As RParameter In lstRParams
            clsOperator.RemoveParameter(clsRParam)
        Next

        ' Add new changes
        If Not ucrReceiverMultipleCols.IsEmpty Then
            Dim strParamValue = ucrReceiverMultipleCols.GetVariableNames(bWithQuotes:=True, strQuotes:="`")
            clsColHideRFunction.AddParameter("columns", strParameterValue:=strParamValue, iPosition:=0, bIncludeArgumentName:=True)
            clsOperator.AddParameter(New RParameter(strParameterName:="cols_hide_param", strParamValue:=clsColHideRFunction, bNewIncludeArgumentName:=False))
        End If
    End Sub

End Class
