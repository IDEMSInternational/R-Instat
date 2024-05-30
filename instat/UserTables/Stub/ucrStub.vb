Public Class ucrStub

    Private Sub initialiseDialog()
        ucrReceiverSingleRowName.SetParameter(New RParameter("rowname_col", 0))
        ucrReceiverSingleRowName.SetParameterIsString()
        ucrReceiverSingleRowName.Selector = ucrSelectorCols
        ucrReceiverSingleRowName.SetLinkedDisplayControl(lblRowName)

        ucrReceiverSingleGroupByCol.SetParameter(New RParameter("groupname_col", 1))
        ucrReceiverSingleGroupByCol.SetParameterIsString()
        ucrReceiverSingleGroupByCol.Selector = ucrSelectorCols
        ucrReceiverSingleGroupByCol.SetLinkedDisplayControl(lblGroupByCol)


        'ucrInputHeaderTitle.SetParameter(New RParameter("title_text_param", 0, bNewIncludeArgumentName:=False))

    End Sub

    Public Sub Setup(strDataFrameName As String, clsOperator As ROperator)

    End Sub



End Class
