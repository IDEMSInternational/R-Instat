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

Imports System.Windows
Imports instat.Translations

Public Class dlgView
    Private clsBaseOperator As New ROperator

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsHeadRFunction, clsGtRFunction, clsOutputWindowFunction, clsViewColumnsFunction, clsDummyFunction, clsGetObjectDataFunction As New RFunction
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
        ucrPnlDisplayWindow.AddToLinkedControls(ucrChkRowNumbers, {rdoDispOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrPnlDisplayWindow.AddToLinkedControls(ucrViewChkPreview, {rdoHTMLOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)

        ucrChkRowNumbers.AddToLinkedControls(ucrNudNumberRows, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=6)


        ucrNudNumberRows.Visible = rdoDispOutputWindow.Checked
        ucrReceiverView.SetParameter(New RParameter("x", 1, bNewIncludeArgumentName:=False))

        ucrNudNumberRows.SetParameter(New RParameter("n", 1))
        'ucrNudNumberRows.Minimum = 1
        ucrNudNumberRows.SetRDefault(6)
        ucrNudNumberRows.SetLinkedDisplayControl(lblNumberofRows)

        ucrChkDisplayFromTop.SetText("Display From Top")
        ucrChkDisplayFromTop.AddFunctionNamesCondition(True, {"head", "tail"})

        ucrViewChkPreview.SetText("Rows")
        ucrViewChkPreview.AddParameterPresentCondition(True, "head", bNewIsPositive:=True)
        ucrViewChkPreview.AddParameterPresentCondition(False, "head", bNewIsPositive:=False)
        ucrViewChkPreview.AddToLinkedControls(ucrViewNudPreview, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrViewNudPreview.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrViewNudPreview.Minimum = 6
        ucrViewNudPreview.Maximum = Decimal.MaxValue
        ucrViewNudPreview.SetRDefault(6)

        ucrReceiverView.SetLinkedDisplayControl(lblSelected)

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

        ucrSelectorForView.SetParameterIsString()

        ucrSaveData.SetCheckBoxText("Store Data")
        ucrSaveData.SetPrefix("last_table")
        ucrSaveData.SetDataFrameSelector(ucrSelectorForView.ucrAvailableDataFrames)
        ucrSaveData.setLinkedReceiver(ucrReceiverView)
        ucrSaveData.SetIsComboBox()
        ucrSaveData.SetAssignToIfUncheckedValue("last_table")

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator
        clsOutputWindowFunction = New RFunction
        clsViewColumnsFunction = New RFunction
        clsGetObjectDataFunction = New RFunction
        clsHeadRFunction = New RFunction
        clsGtRFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrViewChkPreview.Checked = True
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

        clsBaseOperator.SetOperation("%>%")
        clsBaseOperator.bBrackets = False
        clsHeadRFunction.SetPackageName("utils")
        clsHeadRFunction.SetRCommand("head")
        clsHeadRFunction.AddParameter(strParameterName:="x", strParameterValue:=6, iPosition:=2, bIncludeArgumentName:=False)
        clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=3, bIncludeArgumentName:=False)

        clsGtRFunction.SetPackageName("gt")
        clsGtRFunction.SetRCommand("gt")
        clsBaseOperator.AddParameter(strParameterName:="gt", clsRFunctionParameter:=clsGtRFunction, iPosition:=4, bIncludeArgumentName:=False)

        clsBaseOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                      strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                      strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                      strRDataFrameNameToAddObjectTo:=ucrSelectorForView.strCurrentDataFrame,
                                      strObjectName:="last_table")

        clsViewColumnsFunction.SetPackageName("utils")
        clsViewColumnsFunction.SetRCommand("View")

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bControlsUpdated = False
        'Set maximum temporarily to prevent error in SetRCode
        'Correct maximum is then set in DataFrameLength()
        ucrNudNumberRows.Maximum = Decimal.MaxValue

        ucrReceiverView.AddAdditionalCodeParameterPair(clsOutputWindowFunction, New RParameter("x"), iAdditionalPairNo:=1)
        ucrSelectorForView.AddAdditionalCodeParameterPair(clsViewColumnsFunction, ucrSelectorForView.GetParameter(), iAdditionalPairNo:=1)
        ucrSaveData.AddAdditionalRCode(clsOutputWindowFunction, iAdditionalPairNo:=1)

        ucrReceiverView.AddAdditionalCodeParameterPair(clsViewColumnsFunction, New RParameter("x"), iAdditionalPairNo:=2)

        ucrReceiverView.SetRCode(clsBaseOperator, bReset)
        ucrPnlDisplayWindow.SetRCode(clsDummyFunction, bReset)
        ucrViewChkPreview.SetRCode(clsBaseOperator, bReset)
        ucrChkDisplayFromTop.SetRCode(clsOutputWindowFunction, bReset)
        ucrNudNumberRows.SetRCode(clsOutputWindowFunction, bReset)
        ucrViewNudPreview.SetRCode(clsHeadRFunction, bReset)
        ucrSelectorForView.SetRCode(clsViewColumnsFunction, bReset)
        ucrSaveData.SetRCode(clsBaseOperator, bReset)

        DataFrameLength()
        ChangeFunctionParameters()
        bControlsUpdated = True
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverView.IsEmpty Then
            If rdoDispSepOutputWindow.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoDispOutputWindow.Checked Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(True)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ChangeFunctionParameters()
        If rdoDispOutputWindow.Checked Then
            clsDummyFunction.AddParameter("checked", "window", iPosition:=0)
            cmdTableOptions.Visible = False
            ucrSaveData.Visible = True
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectDataFunction)
            ucrSaveData.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Text)
            If ucrNudNumberRows.GetText <> "" OrElse ucrChkDisplayFromTop.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsOutputWindowFunction)

                If ucrChkDisplayFromTop.Checked Then
                    clsOutputWindowFunction.SetRCommand("head")
                Else
                    clsOutputWindowFunction.SetRCommand("tail")
                End If
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(ucrReceiverView.GetVariables(True))
            End If
        ElseIf rdoDispSepOutputWindow.Checked Then
            clsDummyFunction.AddParameter("checked", "viewer", iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsGetObjectDataFunction)
            ucrBase.clsRsyntax.iCallType = 0
            ucrBase.clsRsyntax.SetBaseRFunction(clsViewColumnsFunction)
            ucrSaveData.Visible = False
            cmdTableOptions.Visible = False
            ucrSaveData.Visible = False
        Else
            ucrSaveData.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
            clsDummyFunction.AddParameter("checked", "html", iPosition:=0)
            ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
            cmdTableOptions.Visible = True
            ucrSaveData.Visible = True
            If ucrViewChkPreview.Checked Then
                clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=2, bIncludeArgumentName:=False)
            Else
                clsBaseOperator.RemoveParameterByName("head")
            End If
        End If
    End Sub

    Private Sub DataFrameLength()
        ucrNudNumberRows.Maximum = ucrSelectorForView.ucrAvailableDataFrames.iDataFrameLength
    End Sub


    Private Sub FunctionControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrViewChkPreview.ControlValueChanged, ucrViewNudPreview.ControlValueChanged, ucrChkDisplayFromTop.ControlValueChanged, ucrPnlDisplayWindow.ControlValueChanged, ucrReceiverView.ControlValueChanged
        If bControlsUpdated Then
            ChangeFunctionParameters()
        End If
        GetObjectName()
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
        clsOutputWindowFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForView.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        clsHeadRFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorForView.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
    End Sub

    Private Sub cmdTableOptions_Click(sender As Object, e As EventArgs) Handles cmdTableOptions.Click
        sdgTableOptions.Setup(ucrSelectorForView.strCurrentDataFrame, clsBaseOperator)
        sdgTableOptions.ShowDialog(Me)
    End Sub

    Private Sub ucrPnlViewData_ControlValueChanged(ucrChangedControl As ucrCore)
        ChangeFunctionParameters()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrViewNudPreview.ControlContentsChanged, ucrViewChkPreview.ControlContentsChanged, ucrReceiverView.ControlContentsChanged, ucrPnlDisplayWindow.ControlContentsChanged, ucrNudNumberRows.ControlContentsChanged, ucrChkDisplayFromTop.ControlContentsChanged, ucrChkSortColumn.ControlContentsChanged, ucrReceiverSortCol.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSaveData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveData.ControlValueChanged
        GetObjectName()
    End Sub

    Private Sub GetObjectName()
        If rdoDispOutputWindow.Checked Then
            Dim strPrefix As String = clsOutputWindowFunction.GetRObjectToAssignTo 'If(ucrSaveData.GetText <> "", ucrSaveData.GetText, "last_table")
            clsGetObjectDataFunction.AddParameter("object_name", Chr(34) & strPrefix & Chr(34), iPosition:=1)
        ElseIf rdoHTMLOutputWindow.Checked Then
            Dim strPrefix As String = clsBaseOperator.GetRObjectToAssignTo
            clsGetObjectDataFunction.AddParameter("object_name", Chr(34) & strPrefix & Chr(34), iPosition:=1)
        End If
    End Sub

    Private Sub ucrSelectorForView_DataFrameChanged() Handles ucrSelectorForView.DataFrameChanged
        clsGetObjectDataFunction.AddParameter("data_name", Chr(34) & ucrSelectorForView.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub
End Class