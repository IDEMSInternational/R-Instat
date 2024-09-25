Public Class ucrStubOptions
    Private clsOperator As New ROperator
    Private clsGtRFunction, clsStubHeadRFunction, clsStubStyleRFunction, clsStubLocationRFunction As New RFunction
    Private bFirstload As Boolean = True

    Private Sub initialiseDialog()
        ucrReceiverSingleRowName.SetParameter(New RParameter("rowname_col", 0))
        ucrReceiverSingleRowName.SetParameterIsString()
        ucrReceiverSingleRowName.Selector = ucrSelectorCols
        ucrReceiverSingleRowName.SetLinkedDisplayControl(lblRowName)

        ucrReceiverSingleGroupByCol.SetParameter(New RParameter("groupname_col", 1))
        ucrReceiverSingleGroupByCol.SetParameterIsString()
        ucrReceiverSingleGroupByCol.Selector = ucrSelectorCols
        ucrReceiverSingleGroupByCol.SetLinkedDisplayControl(lblGroupByCol)

        ucrInputStubHead.SetParameter(New RParameter("label", 0))
    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)

        If bFirstload Then
            initialiseDialog()
            bFirstload = False
        End If

        Me.clsOperator = clsOperator

        ucrSelectorCols.SetDataframe(strDataFrameName, bEnableDataframe:=False)
        ucrReceiverSingleRowName.SetMeAsReceiver()

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
