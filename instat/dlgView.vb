' Instat-R
' Copyright (C) 2015
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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsOutputWindowFunction, clsSeparateWindowFunction, clsHTMLFunction As New RFunction
    Private bControlsUpdated As Boolean = False

    Private Sub dlgView_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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

        ucrPnlDisplayWindow.AddToLinkedControls(ucrChkSpecifyRows, {rdoDispOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)

        ucrPnlDisplayFrom.AddRadioButton(rdoBottom)
        ucrPnlDisplayFrom.AddRadioButton(rdoTop)
        ucrPnlDisplayFrom.SetLinkedDisplayControl(lblDisplayFrom)
        ucrPnlDisplayFrom.AddFunctionNamesCondition(rdoTop, "head")
        ucrPnlDisplayFrom.AddFunctionNamesCondition(rdoBottom, "tail")

        '  ucrPnlDisplayFrom.bAllowNonConditionValues = True

        ' This linking only applies if rdoDispOutputWindow is checked
        ucrChkSpecifyRows.SetText("Specify Rows")
        ucrChkSpecifyRows.AddToLinkedControls(ucrPnlDisplayFrom, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoTop)
        ucrChkSpecifyRows.AddToLinkedControls(ucrNudNumberRows, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=6)
        ucrChkSpecifyRows.AddFunctionNamesCondition(True, {"head", "tail"})
        ucrChkSpecifyRows.AddFunctionNamesCondition(False, {frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data"})
        '   ucrChkSpecifyRows.bAllowNonConditionValues = True

        ucrPnlDisplayWindow.AddFunctionNamesCondition(rdoDispSepOutputWindow, "View")
        ucrPnlDisplayWindow.AddFunctionNamesCondition(rdoDispOutputWindow, {"head", "tail", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data"})
        ucrPnlDisplayWindow.AddFunctionNamesCondition(rdoHTMLOutputWindow, "sjt.df")

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

        ucrNudNumberRows.SetParameter(New RParameter("n", 1))
        ucrNudNumberRows.Minimum = 1
        ucrNudNumberRows.SetLinkedDisplayControl(lblNumberofRows)
    End Sub

    Private Sub SetDefaults()
        clsOutputWindowFunction = New RFunction
        clsSeparateWindowFunction = New RFunction
        clsHTMLFunction = New RFunction

        ucrSelectorForView.Reset()
        ucrReceiverView.SetMeAsReceiver()

        clsOutputWindowFunction.SetPackageName("utils")
        clsSeparateWindowFunction.AddParameter("title", Chr(34) & ucrSelectorForView.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))

        clsHTMLFunction.SetPackageName("sjPlot")
        clsHTMLFunction.SetRCommand("sjt.df")
        clsHTMLFunction.AddParameter("describe", "FALSE", iPosition:=1)
        clsHTMLFunction.AddParameter("altr.row.col", "TRUE", iPosition:=2)
        clsHTMLFunction.AddParameter("hide.progress", "TRUE", iPosition:=4)

        clsSeparateWindowFunction.SetPackageName("utils")
        clsSeparateWindowFunction.SetRCommand("View")

        ucrBase.clsRsyntax.SetBaseRFunction(clsSeparateWindowFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bControlsUpdated = False
        ucrNudNumberRows.Maximum = Decimal.MaxValue
        ucrReceiverView.SetRCode(clsSeparateWindowFunction, bReset)
        ucrPnlDisplayWindow.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlDisplayFrom.SetRCode(clsOutputWindowFunction, bReset)
        ucrNudNumberRows.SetRCode(clsOutputWindowFunction, bReset)
        ucrChkSpecifyRows.SetRCode(clsOutputWindowFunction, bReset)
        ucrSelectorForView.SetRCode(clsSeparateWindowFunction, bReset)
        ucrReceiverView.AddAdditionalCodeParameterPair(clsHTMLFunction, New RParameter("mydf"), iAdditionalPairNo:=1)
        ucrReceiverView.AddAdditionalCodeParameterPair(clsOutputWindowFunction, New RParameter("x"), iAdditionalPairNo:=2)
        DataFrameLength()
        bControlsUpdated = True
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverView.IsEmpty Then
            If rdoDispSepOutputWindow.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoDispOutputWindow.Checked Then
                If ucrChkSpecifyRows.Checked Then
                    If ucrNudNumberRows.GetText <> "" AndAlso (rdoTop.Checked OrElse rdoBottom.Checked) Then
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
            ucrBase.clsRsyntax.iCallType = 2
            If ucrChkSpecifyRows.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsOutputWindowFunction)
                If rdoTop.Checked Then
                    clsOutputWindowFunction.SetRCommand("head")
                Else
                    clsOutputWindowFunction.SetRCommand("tail")
                End If
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(ucrReceiverView.GetVariables(True))
            End If
        ElseIf rdoDispSepOutputWindow.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSeparateWindowFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsHTMLFunction)
        End If
    End Sub

    Private Sub DataFrameLength()
        ucrNudNumberRows.Maximum = ucrSelectorForView.ucrAvailableDataFrames.iDataFrameLength
    End Sub

    Private Sub FunctionControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDisplayFrom.ControlValueChanged, ucrPnlDisplayWindow.ControlValueChanged, ucrChkSpecifyRows.ControlValueChanged
        If bControlsUpdated Then
            ChangeFunctionParameters()
        End If
    End Sub

    Private Sub ucrChkSortColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSortColumn.ControlValueChanged, ucrPnlDisplayWindow.ControlValueChanged
        If rdoHTMLOutputWindow.Checked AndAlso ucrChkSortColumn.Checked Then
            ucrReceiverSortCol.SetMeAsReceiver()
        Else
            ucrReceiverView.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrSelectorForView_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForView.ControlValueChanged
        DataFrameLength()
    End Sub

    Private Sub ucrReceiverView_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverView.ControlContentsChanged, ucrPnlDisplayWindow.ControlContentsChanged, ucrChkSpecifyRows.ControlContentsChanged, ucrNudNumberRows.ControlContentsChanged, ucrPnlDisplayFrom.ControlContentsChanged, ucrChkSortColumn.ControlContentsChanged, ucrReceiverSortCol.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class