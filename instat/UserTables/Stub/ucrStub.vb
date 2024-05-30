Imports Antlr.Runtime

Public Class ucrStub

    Private clsOperator As New ROperator
    Private clsStubHeadRParameter As RParameter
    Private clsGtRFunction As New RFunction
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

        Dim lstRParams As List(Of RParameter)

        lstRParams = clsTablesUtils.FindRFunctionsParamsWithRCommand("gt", clsOperator)

        ' The GT paramter should always be there. 
        If lstRParams.Count > 0 Then
            clsGtRFunction = lstRParams(0).clsArgumentCodeStructure
            ucrReceiverSingleRowName.SetRCode(clsGtRFunction, False, bCloneIfNeeded:=True)
            ucrReceiverSingleGroupByCol.SetRCode(clsGtRFunction, False, bCloneIfNeeded:=True)
        End If


        lstRParams = clsTablesUtils.FindRFunctionsParamsWithRCommand("tab_stubhead", clsOperator)
        If lstRParams.Count > 0 Then
            clsStubHeadRParameter = lstRParams(0)
        Else
            Dim clstabStubHeadFunction As New RFunction
            clstabStubHeadFunction.SetPackageName("gt")
            clstabStubHeadFunction.SetRCommand("tab_stubhead")
            clsStubHeadRParameter = New RParameter(strParameterName:="tab_stubhead_param", strParamValue:=clstabStubHeadFunction, bNewIncludeArgumentName:=False)
        End If


    End Sub

    Private Sub ucrInputStubHead_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputStubHead.ControlValueChanged
        If ucrInputStubHead.IsEmpty Then
            clsOperator.RemoveParameter(clsStubHeadRParameter)
        Else
            clsStubHeadRParameter.clsArgumentCodeStructure.AddParameter("label", strParameterValue:=clsTablesUtils.GetStringValue(ucrInputStubHead.GetValue(), True))
            clsOperator.AddParameter(clsStubHeadRParameter)
        End If
    End Sub



End Class
