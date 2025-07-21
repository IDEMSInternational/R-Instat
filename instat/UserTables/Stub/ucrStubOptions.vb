Public Class ucrStubOptions
    Private clsOperator As New ROperator
    Private clsGtRFunction, clsStubHeadRFunction, clsStubStyleRFunction, clsStubLocationRFunction As New RFunction
    Private bFirstload As Boolean = True

    Private Sub initialiseControl()
        ucrReceiverSingleRowName.SetParameter(New RParameter("rowname_col", 0))
        ucrReceiverSingleRowName.SetParameterIsString()
        ucrReceiverSingleRowName.Selector = ucrSelectorByDF
        ucrReceiverSingleRowName.SetLinkedDisplayControl(lblRowName)

        ucrReceiverSingleGroupByCol.SetParameter(New RParameter("groupname_col", 1))
        ucrReceiverSingleGroupByCol.SetParameterIsString()
        ucrReceiverSingleGroupByCol.Selector = ucrSelectorByDF
        ucrReceiverSingleGroupByCol.SetLinkedDisplayControl(lblGroupByCol)

        ucrInputStubHead.SetParameter(New RParameter("label", 0))
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator, strTableName As String)
        If bFirstload Then
            initialiseControl()
            bFirstload = False
        End If

        ' Set up the selector and receiver
        ucrReceiverSingleRowName.strObjectName = strTableName
        If String.IsNullOrEmpty(strTableName) Then
            ucrSelectorByDF.Visible = True
            ucrSelectorByTableDF.Visible = False
            ucrSelectorByDF.SetDataframe(strDataFrameName, bEnableDataframe:=False)
            ucrReceiverSingleRowName.Selector = ucrSelectorByDF
        Else
            ucrSelectorByDF.Visible = False
            ucrSelectorByTableDF.Visible = True
            ucrSelectorByTableDF.SetDataframe(strDataFrameName, bEnableDataframe:=False)
            ucrReceiverSingleRowName.Selector = ucrSelectorByTableDF
        End If
        ucrReceiverSingleRowName.SetMeAsReceiver()
        ucrReceiverSingleRowName.Clear()

        Me.clsOperator = clsOperator

        ' The GT paramter should always be there.
        clsGtRFunction = clsTablesUtils.FindRFunctionsParamsWithRCommand({"gt"}, clsOperator).FirstOrDefault()?.clsArgumentCodeStructure

        clsStubHeadRFunction = clsTablesUtils.FindRFunctionsParamsWithRCommand({"tab_stubhead"}, clsOperator).FirstOrDefault()?.clsArgumentCodeStructure
        If clsStubHeadRFunction Is Nothing Then
            clsStubHeadRFunction = New RFunction
            clsStubHeadRFunction.SetPackageName("gt")
            clsStubHeadRFunction.SetRCommand("tab_stubhead")
        End If

        SetRCode()
    End Sub

    Private Sub SetRCode()
        ucrReceiverSingleRowName.SetRCode(clsGtRFunction, True, bCloneIfNeeded:=True)
        ucrReceiverSingleGroupByCol.SetRCode(clsGtRFunction, True, bCloneIfNeeded:=True)
        ucrInputStubHead.SetRCode(clsStubHeadRFunction, True, bCloneIfNeeded:=True)
    End Sub


    Private Sub btnStyle_Click(sender As Object, e As EventArgs)
        Dim clsListStyleRFunction As RFunction = clsTablesUtils.ShowStyleSubDialog(Me.ParentForm, clsStubStyleRFunction)
        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If

        clsStubStyleRFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsStubLocationRFunction)
    End Sub

    Public Sub SetValuesToOperator()

        clsTablesUtils.RemoveRFunctionsParamsWithRCommand({"tab_stubhead"}, clsOperator)

        If Not ucrInputStubHead.IsEmpty Then
            clsOperator.AddParameter(New RParameter(strParameterName:="tab_stubhead_param", strParamValue:=clsStubHeadRFunction, bNewIncludeArgumentName:=False))
        End If
    End Sub
End Class
