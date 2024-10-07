' R- Instat
' Copyright (C) 2015-2017
'
' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.
'
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgView
    Private clsBaseOperator As New ROperator

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsHeadRFunction, clsGtRFunction, clsOutputWindowFunction, clsHTMLFunction, clsAsHtmlWidgetFunction, clsViewColumnsFunction, clsDummyFunction, clsGetObjectDataFunction, clsViewAllFunction As New RFunction
    Private bControlsUpdated As Boolean = False

    Private Sub dlgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 32
        'Needed because window may pop up window which will disappear in a separate thread
        ucrBase.clsRsyntax.bSeparateThread = False

        ucrReceiverView.SetParameter(New RParameter("x", 0))
        ucrReceiverView.SetParameterIsRFunction()
        ucrReceiverView.Selector = ucrSelectorForView
        ucrReceiverView.bForceAsDataFrame = True

        ucrPnlDisplayWindow.AddRadioButton(rdoDispOutputWindow)
        ucrPnlDisplayWindow.AddRadioButton(rdoDispSepOutputWindow)
        ucrPnlDisplayWindow.AddRadioButton(rdoHTMLOutputWindow)
        ucrPnlDisplayWindow.AddParameterValuesCondition(rdoHTMLOutputWindow, "checked", "html")
        ucrPnlDisplayWindow.AddParameterValuesCondition(rdoDispOutputWindow, "checked", "window")
        ucrPnlDisplayWindow.AddParameterValuesCondition(rdoDispSepOutputWindow, "checked", "viewer")

        ucrPnlDisplayWindow.AddToLinkedControls(ucrChkDisplayFromTop, {rdoDispOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrPnlDisplayWindow.AddToLinkedControls(ucrChkRowNumbers, {rdoDispOutputWindow, rdoHTMLOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        'ucrPnlDisplayFrom.AddRadioButton(rdoBottom)
        'ucrPnlDisplayFrom.AddRadioButton(rdoTop)
        'ucrPnlDisplayFrom.SetLinkedDisplayControl(lblDisplayFrom)
        'ucrChkDisplayFromTop.AddFunctionNamesCondition("head")
        'ucrChkDisplayFromTop.AddFunctionNamesCondition(rdoBottom, "tail")

        ' This linking only applies if rdoDispOutputWindow is checked

        ' ucrChkSpecifyRows.AddToLinkedControls(ucrChkDisplayFromTop, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True)
        '  ucrChkSpecifyRows.AddToLinkedControls(ucrNudNumberRows, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=6)

        ucrNudNumberRows.SetParameter(New RParameter("n", 1))
        ucrChkRowNumbers.SetText("Rows")
        ucrChkRowNumbers.AddToLinkedControls(ucrNudNumberRows, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=6)

        ucrChkDisplayFromTop.SetText("Display From Top")
        ucrChkDisplayFromTop.AddFunctionNamesCondition(True, {"head", "tail"})
        ucrChkDisplayFromTop.AddFunctionNamesCondition(False, {frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data"})
        '   ucrChkSpecifyRows.bAllowNonConditionValues = True

        '  ucrPnlViewData.AddRadioButton(rdoViewAll)
        '  ucrPnlViewData.AddRadioButton(rdoViewSelectedColumnsRows)

        '  ucrPnlViewData.AddParameterValueFunctionNamesCondition(rdoViewAll, "x", frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
        '  ucrPnlViewData.AddParameterValueFunctionNamesCondition(rdoViewSelectedColumnsRows, "x", frmMain.clsRLink.strInstatDataObject & "$get_data_frame", bNewIsPositive:=False)

        ' ucrPnlViewData.AddToLinkedControls(ucrReceiverView, {rdoViewSelectedColumnsRows}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrReceiverView.SetLinkedDisplayControl(lblSelected)
        '   ucrPnlViewData.AddToLinkedControls(ucrPnlDisplayWindow, {rdoViewSelectedColumnsRows}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrChkSortColumn.Visible = False
        'ucrPnlDisplayWindow.AddToLinkedControls(ucrChkSortColumn, {rdoHTMLOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        'ucrChkSortColumn.SetText("Sort by Column")
        ' ucrChkSortColumn.AddToLinkedControls(ucrReceiverSortCol, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoTop)
        ' ucrChkSortColumn.SetRDefault("NULL")

        ucrReceiverSortCol.Visible = False
        ' ucrReceiverSortCol.SetParameter(New RParameter("sort.col", 3))
        ' ucrReceiverSortCol.SetParameterIsString()
        ' ucrReceiverSortCol.Selector = ucrSelectorForView

        ' TODO: Options in this selector should be limited to options which are also in the other selector.
        'The sort column checkbox and receiver set to be invisible since the method for allowing variables in receiver1 to be strictly the same variables in receiver2 is yet to be implemented.
        'ucrChkSortColumn.SetParameter(ucrReceiverSortCol.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrSelectorForView.SetParameter(New RParameter("title", 1))
        ucrSelectorForView.SetParameterIsString()


        ucrNudNumberRows.Minimum = 1
        ' ucrNudNumberRows.SetLinkedDisplayControl(ucrChkNumbersRows)

        ucrSaveData.SetCheckBoxText("Store Data")
        ucrSaveData.SetPrefix("last_table")
        ucrSaveData.SetDataFrameSelector(ucrSelectorForView.ucrAvailableDataFrames)
        ucrSaveData.setLinkedReceiver(ucrReceiverView)
        ucrSaveData.SetIsComboBox()
        ucrSaveData.SetAssignToIfUncheckedValue("last_table")

    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsOutputWindowFunction = New RFunction
        clsViewColumnsFunction = New RFunction
        clsHTMLFunction = New RFunction
        clsViewAllFunction = New RFunction
        clsGetObjectDataFunction = New RFunction
        clsHeadRFunction = New RFunction
        clsGtRFunction = New RFunction
        clsDummyFunction = New RFunction
        clsAsHtmlWidgetFunction = New RFunction

        ucrSelectorForView.Reset()
        ucrReceiverView.SetMeAsReceiver()

        clsDummyFunction.AddParameter("checked", "window", iPosition:=0)

        clsGetObjectDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")
        clsGetObjectDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorForView.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetObjectDataFunction.AddParameter("as_file", "TRUE", iPosition:=2)


        clsOutputWindowFunction.SetPackageName("utils")
        clsOutputWindowFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                               strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                               strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                               strRDataFrameNameToAddObjectTo:=ucrSelectorForView.strCurrentDataFrame,
                                               strObjectName:="last_table")


        clsHTMLFunction.SetPackageName("formattable")
        clsHTMLFunction.SetRCommand("formattable")
        clsHTMLFunction.AddParameter("align", Chr(34) & "l" & Chr(34), iPosition:=1)


        clsAsHtmlWidgetFunction.SetPackageName("formattable")
        clsAsHtmlWidgetFunction.SetRCommand("as.htmlwidget")
        clsAsHtmlWidgetFunction.AddParameter("x", clsRFunctionParameter:=clsHTMLFunction, iPosition:=0)
        clsAsHtmlWidgetFunction.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                               strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                               strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                               strRDataFrameNameToAddObjectTo:=ucrSelectorForView.strCurrentDataFrame,
                                               strObjectName:="last_table")

        clsBaseOperator.SetOperation("%>%")
        clsBaseOperator.bBrackets = False

        clsHeadRFunction.SetPackageName("utils")
        clsHeadRFunction.SetRCommand("head")
        clsHeadRFunction.AddParameter(strParameterName:="x", strParameterValue:=6, iPosition:=0, bIncludeArgumentName:=False)
        clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsGtRFunction.SetPackageName("gt")
        clsGtRFunction.SetRCommand("gt")
        clsBaseOperator.AddParameter(strParameterName:="gt", clsRFunctionParameter:=clsGtRFunction, iPosition:=2, bIncludeArgumentName:=False)

        clsViewColumnsFunction.SetPackageName("utils")
        clsViewColumnsFunction.SetRCommand("View")

        clsViewAllFunction.SetPackageName("utils")
        clsViewAllFunction.SetRCommand("View")
        clsViewAllFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorForView.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsViewAllFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bControlsUpdated = False
        'Set maximum temporarily to prevent error in SetRCode
        'Correct maximum is then set in DataFrameLength()
        ucrNudNumberRows.Maximum = Decimal.MaxValue

        'ucrReceiverView.AddAdditionalCodeParameterPair(clsHTMLFunction, New RParameter("mydf"), iAdditionalPairNo:=1)
        ucrReceiverView.AddAdditionalCodeParameterPair(clsHTMLFunction, New RParameter("x"), iAdditionalPairNo:=1)

        ucrReceiverView.AddAdditionalCodeParameterPair(clsOutputWindowFunction, New RParameter("x"), iAdditionalPairNo:=2)
        ucrSelectorForView.AddAdditionalCodeParameterPair(clsViewColumnsFunction, ucrSelectorForView.GetParameter(), iAdditionalPairNo:=1)
        ucrSaveData.AddAdditionalRCode(clsOutputWindowFunction, iAdditionalPairNo:=1)

        ucrReceiverView.SetRCode(clsViewColumnsFunction, bReset)
        ucrPnlDisplayWindow.SetRCode(clsDummyFunction, bReset)

        ucrChkDisplayFromTop.SetRCode(clsOutputWindowFunction, bReset)
        ucrNudNumberRows.SetRCode(clsOutputWindowFunction, bReset)
        ucrChkRowNumbers.SetRCode(clsHeadRFunction, bReset)
        '        ucrChkSpecifyRows.SetRCode(clsOutputWindowFunction, bReset)
        ucrSelectorForView.SetRCode(clsViewAllFunction, bReset)
        '   ucrPnlViewData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveData.SetRCode(clsAsHtmlWidgetFunction, bReset)

        DataFrameLength()
        ChangeFunctionParameters()
        bControlsUpdated = True
    End Sub

    Private Sub SetSelectorParameterType()
        clsViewAllFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorForView.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
    End Sub

    Private Sub TestOKEnabled()
        ' If rdoViewSelectedColumnsRows.Checked Then
        If Not ucrReceiverView.IsEmpty Then
            If rdoDispSepOutputWindow.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoDispOutputWindow.Checked Then
                ' If ucrChkSpecifyRows.Checked Then
                If ucrNudNumberRows.GetText <> "" OrElse ucrChkDisplayFromTop.Checked Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                ucrBase.OKEnabled(True)
            End If
        ElseIf rdoHTMLOutputWindow.Checked AndAlso ((ucrChkSortColumn.Checked AndAlso Not ucrReceiverSortCol.IsEmpty) OrElse Not ucrChkSortColumn.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
        'Else
        '    ucrBase.OKEnabled(False)
        'End If
        'Else
        '    If ucrSelectorForView.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
        '        ucrBase.OKEnabled(True)
        '    Else
        '        ucrBase.OKEnabled(False)
        '    End If
        'End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ChangeFunctionParameters()
        'If rdoViewSelectedColumnsRows.Checked Then
        If rdoDispOutputWindow.Checked Then
            clsDummyFunction.AddParameter("checked", "window", iPosition:=0)

            cmdTableOptions.Visible = False
            ucrSaveData.Visible = True
            ucrBase.clsRsyntax.iCallType = 2

            'If ucrChkDisplayFromTop.Checked Then
            '    clsOutputWindowFunction.SetRCommand("head")
            'Else
            '    clsOutputWindowFunction.SetRCommand("tail")
            'End If
            '  If ucrNudNumberRows.GetText <> "" Then
            'If ucrNudNumberRows.GetText <> "" AndAlso rdoDispOutputWindow.Checked Then 'OrElse ucrChkDisplayFromTop.Checked Then
            '    ' clsOutputWindowFunction.SetRCommand("head")
            '    ucrBase.clsRsyntax.SetBaseRFunction(clsOutputWindowFunction)
            '    ucrSaveData.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Text)
            '    ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectDataFunction)

            'Else
            '    '    clsViewAllFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorForView.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)

            '    ' clsOutputWindowFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorForView.ucrAvailableDataFrames.iColumnCount, iPosition:=0)

            '    ' ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectDataFunction)
            '    ucrBase.clsRsyntax.SetBaseRFunction(ucrReceiverView.GetVariables(True))
            'End If
        ElseIf rdoDispSepOutputWindow.Checked Then
            clsOutputWindowFunction.SetRCommand("head")
            clsDummyFunction.AddParameter("checked", "viewer", iPosition:=0)

            ucrBase.clsRsyntax.iCallType = 0
            ucrBase.clsRsyntax.SetBaseRFunction(clsViewColumnsFunction)
            '   ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectDataFunction)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectDataFunction)
            cmdTableOptions.Visible = False
            ucrSaveData.Visible = False
        Else
            'ucrNudNumberRows.AddParameterPresentCondition(True, "head", bNewIsPositive:=True)
            'ucrNudNumberRows.AddParameterPresentCondition(False, "head", bNewIsPositive:=False)
            'If ucrNudNumberRows.GetText <> "" Then
            '    ' clsOutputWindowFunction.RemoveParameterByName("x")
            '    '   clsOutputWindowFunction.SetRCommand("head")
            '    clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)
            'Else
            '    clsBaseOperator.RemoveParameterByName("head")
            'End If
            'ucrChkRowNumbers.AddParameterPresentCondition(True, "head", bNewIsPositive:=True)
            'ucrChkRowNumbers.AddParameterPresentCondition(False, "head", bNewIsPositive:=False)
            'If ucrChkRowNumbers.Checked AndAlso ucrNudNumberRows.GetText <> "" Then
            '    clsOutputWindowFunction.RemoveParameterByName("x")
            '    clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)
            'Else

            '    clsBaseOperator.RemoveParameterByName("head")
            'End If
            clsDummyFunction.AddParameter("checked", "html", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsAsHtmlWidgetFunction)
            ucrSaveData.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
            cmdTableOptions.Visible = True
            ucrSaveData.Visible = True
            ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectDataFunction)
        End If
        'Else
        '    ucrBase.clsRsyntax.SetBaseRFunction(clsViewAllFunction)
        '    ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectDataFunction)
        '    ucrSaveData.Visible = False
        'End If
    End Sub

    Private Sub DataFrameLength()
        ucrNudNumberRows.Maximum = ucrSelectorForView.ucrAvailableDataFrames.iDataFrameLength
    End Sub

    Private Sub FunctionControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayFromTop.ControlValueChanged, ucrPnlDisplayWindow.ControlValueChanged, ucrReceiverView.ControlValueChanged
        If bControlsUpdated Then
            ChangeFunctionParameters()
        End If
        GetObjectName()
    End Sub

    Private Sub ucrChkRowNumbers_Load(sender As Object, e As EventArgs) Handles ucrChkRowNumbers.Load
        If ucrChkRowNumbers.Checked Then
            If rdoDispOutputWindow.Checked Then
                If ucrChkDisplayFromTop.Checked Then
                    clsOutputWindowFunction.SetRCommand("head")
                Else
                    clsOutputWindowFunction.SetRCommand("tail")
                End If
                If ucrNudNumberRows.GetText <> "" Then
                    clsOutputWindowFunction.SetRCommand("head")
                    ucrBase.clsRsyntax.SetBaseRFunction(clsOutputWindowFunction)
                    ucrSaveData.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Text)
                    ucrBase.clsRsyntax.AddToAfterCodes(clsGetObjectDataFunction)
                Else
                    ucrBase.clsRsyntax.SetBaseRFunction(ucrReceiverView.GetVariables(True))
                End If
            ElseIf rdoHTMLOutputWindow.Checked Then
                ucrChkRowNumbers.AddParameterPresentCondition(True, "head", bNewIsPositive:=True)
                ucrChkRowNumbers.AddParameterPresentCondition(False, "head", bNewIsPositive:=False)
                If ucrNudNumberRows.GetText <> "" Then
                    ' clsOutputWindowFunction.RemoveParameterByName("x")
                    clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)
                Else
                    clsBaseOperator.RemoveParameterByName("head")
                End If
            End If
        End If
    End Sub

    Private Sub ucrChkSortColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSortColumn.ControlValueChanged, ucrPnlDisplayWindow.ControlValueChanged
        'Not yet implemented
        'If rdoHTMLOutputWindow.Checked AndAlso ucrChkSortColumn.Checked Then
        '    ucrReceiverSortCol.SetMeAsReceiver()
        'Else
        '    ucrReceiverView.SetMeAsReceiver()
        'End If
    End Sub

    Private Sub ucrSelectorForView_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForView.ControlValueChanged
        DataFrameLength()
        SetSelectorParameterType()
    End Sub

    Private Sub cmdTableOptions_Click(sender As Object, e As EventArgs) Handles cmdTableOptions.Click
        sdgTableOptions.Setup(ucrSelectorForView.strCurrentDataFrame, clsBaseOperator)
        sdgTableOptions.ShowDialog(Me)
    End Sub

    'Private Sub ucrChkRowNumbers_Load(sender As Object, e As EventArgs) Handles ucrChkRowNumbers.Load
    '    If ucrChkRowNumbers.Checked Then
    '        ucrNudNumberRows.SetParameter(New RParameter("n", 1))
    '        ucrNudNumberRows.Visible = True
    '    Else
    '        'ucrNudNumberRows.Remove("n")
    '        'ucrNudNumberRows.UnSetParameter(New RParameter("n", 1))
    '        ucrNudNumberRows.Visible = False
    '    End If
    'End Sub

    Private Sub ucrPnlViewData_ControlValueChanged(ucrChangedControl As ucrCore)
        ChangeFunctionParameters()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverView.ControlContentsChanged, ucrPnlDisplayWindow.ControlContentsChanged, ucrNudNumberRows.ControlContentsChanged, ucrChkDisplayFromTop.ControlContentsChanged, ucrChkSortColumn.ControlContentsChanged, ucrReceiverSortCol.ControlContentsChanged
        ' TableOptions()
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveData.ControlValueChanged
        ' TableOptions()
        GetObjectName()
    End Sub

    Private Sub GetObjectName()
        If rdoDispOutputWindow.Checked Then
            Dim strPrefix As String = clsOutputWindowFunction.GetRObjectToAssignTo 'If(ucrSaveData.GetText <> "", ucrSaveData.GetText, "last_table")
            clsGetObjectDataFunction.AddParameter("object_name", Chr(34) & strPrefix & Chr(34), iPosition:=1)
        ElseIf rdoHTMLOutputWindow.Checked Then
            Dim strPrefix As String = clsAsHtmlWidgetFunction.GetRObjectToAssignTo
            clsGetObjectDataFunction.AddParameter("object_name", Chr(34) & strPrefix & Chr(34), iPosition:=1)
        End If
    End Sub

    Private Sub ucrSelectorForView_DataFrameChanged() Handles ucrSelectorForView.DataFrameChanged
        clsGetObjectDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorForView.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

End Class