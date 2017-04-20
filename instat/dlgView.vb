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
    Private clsMainFunction As New RFunction
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

    Private Sub SetRCodeForControls(bReset As Boolean)
        bControlsUpdated = False
        ucrNudNumberRows.Maximum = Decimal.MaxValue
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        DataFrameLength()
        bControlsUpdated = True
    End Sub

    Private Sub SetDefaults()
        clsMainFunction = New RFunction
        ucrSelectorForView.Reset()
        ucrSelectorForView.Focus()
        ucrReceiverView.SetMeAsReceiver()
        clsMainFunction.SetRCommand("View")
        ucrBase.clsRsyntax.SetBaseRFunction(clsMainFunction)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 32

        ucrReceiverView.SetParameter(New RParameter("x", 0))
        ucrReceiverView.SetParameterIsRFunction()
        ucrReceiverView.Selector = ucrSelectorForView
        '        ucrReceiverView.SetMeAsReceiver()

        ucrPnlDisplayWindow.AddRadioButton(rdoDispOutputWindow)
        ucrPnlDisplayWindow.AddRadioButton(rdoDispSepOutputWindow)
        ucrPnlDisplayWindow.AddRadioButton(rdoHTMLOutputWindow)
        ucrPnlDisplayWindow.AddToLinkedControls(ucrChkSpecifyRows, {rdoDispOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ' TODO: If we want to give an option of number of columns to display then we want this ucrChk to be linked with rdoHTML
        ' We do not want the "Display From: Options" to be linked to ucrChk if it is with rdoHTML
        ' How do we select a certain number of columns in our system?
        ucrPnlDisplayWindow.AddFunctionNamesCondition(rdoDispSepOutputWindow, "View")
        ucrPnlDisplayWindow.AddFunctionNamesCondition(rdoHTMLOutputWindow, "sjt.df")
        ucrPnlDisplayWindow.AddFunctionNamesCondition(rdoDispOutputWindow, {"head", "tail", frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data"})
        ucrPnlDisplayWindow.SetDefaultState(rdoTop)

        ucrPnlDisplayFrom.AddRadioButton(rdoBottom)
        ucrPnlDisplayFrom.AddRadioButton(rdoTop)
        ucrPnlDisplayFrom.SetLinkedDisplayControl(lblDisplayFrom)
        ucrPnlDisplayFrom.AddFunctionNamesCondition(rdoTop, "head")
        ucrPnlDisplayFrom.AddFunctionNamesCondition(rdoBottom, "tail")
        ucrPnlDisplayFrom.bAllowNonConditionValues = True

        ' This linking only applies if rdoDispOutputWindow is checked
        ucrChkSpecifyRows.SetText("Specify Rows")
        ucrChkSpecifyRows.AddToLinkedControls(ucrPnlDisplayFrom, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoTop)
        ucrChkSpecifyRows.AddToLinkedControls(ucrNudNumberRows, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=6)
        ucrChkSpecifyRows.AddFunctionNamesCondition(True, {"head", "tail"})
        ucrChkSpecifyRows.AddFunctionNamesCondition(False, {frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data"})
        ucrChkSpecifyRows.bAllowNonConditionValues = True

        ' Linking for when rdoHTML is checked
        ucrPnlDisplayWindow.AddToLinkedControls(ucrChkSortColumn, {rdoHTMLOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrChkSortColumn.SetText("Sort by Column")
        ucrChkSortColumn.AddToLinkedControls(ucrReceiverSortCol, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoTop)
        ucrChkSortColumn.SetRDefault("NULL")

        ucrReceiverSortCol.SetParameter(New RParameter("sort.col", 3))
        ucrReceiverSortCol.SetParameterIsString()
        ucrReceiverSortCol.Selector = ucrSelectorForView
        ' TODO: Options in this selector should be limited to options which are also in the other selector.
        ucrChkSortColumn.SetParameter(ucrReceiverSortCol.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)

        ucrSelectorForView.SetParameter(New RParameter("title", 1))
        ucrSelectorForView.SetParameterIsString()

        ucrNudNumberRows.SetParameter(New RParameter("n", 1))
        ucrNudNumberRows.Minimum = 1
        ucrNudNumberRows.SetLinkedDisplayControl(lblNumberofRows)
    End Sub

    Private Sub ucrSelectorForView_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForView.ControlValueChanged
        DataFrameLength()
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

    Private Sub DataFrameLength()
        ucrNudNumberRows.Maximum = ucrSelectorForView.ucrAvailableDataFrames.iDataFrameLength
    End Sub

    Private Sub SetiCallType()
        If rdoDispOutputWindow.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
            If ucrChkSpecifyRows.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsMainFunction)
                clsMainFunction.RemoveParameterByName("mydf")
                clsMainFunction.RemoveParameterByName("altr.row.col")
                clsMainFunction.RemoveParameterByName("describe")
                clsMainFunction.RemoveParameterByName("hide.progress")
                clsMainFunction.AddParameter("title", Chr(34) & ucrSelectorForView.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
                clsMainFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverView.GetVariables)
                If rdoTop.Checked Then
                    clsMainFunction.SetRCommand("head")
                Else
                    clsMainFunction.SetRCommand("tail")
                End If
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(ucrReceiverView.GetVariables())
            End If
        ElseIf rdoDispSepOutputWindow.Checked Then
            '            clsMainFunction.SetPackageName("")
            clsMainFunction.RemoveParameterByName("mydf")
            clsMainFunction.RemoveParameterByName("altr.row.col")
            clsMainFunction.RemoveParameterByName("describe")
            clsMainFunction.RemoveParameterByName("hide.progress")
            clsMainFunction.RemoveParameterByName("x")
            clsMainFunction.RemoveParameterByName("title")
            clsMainFunction.SetRCommand("View")
            ucrBase.clsRsyntax.SetBaseRFunction(clsMainFunction)
        Else
            clsMainFunction.SetRCommand("sjt.df")
            clsMainFunction.RemoveParameterByName("x")
            clsMainFunction.RemoveParameterByName("title")
            clsMainFunction.AddParameter("mydf", clsRFunctionParameter:=ucrReceiverView.GetVariables)
            clsMainFunction.AddParameter("describe", "FALSE", iPosition:=1)
            clsMainFunction.AddParameter("altr.row.col", "TRUE", iPosition:=2)
            clsMainFunction.AddParameter("hide.progress", "TRUE", iPosition:=4)
            ucrBase.clsRsyntax.SetBaseRFunction(clsMainFunction)
        End If
    End Sub

    Private Sub ucrReceiverView_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverView.ControlContentsChanged, ucrPnlDisplayWindow.ControlContentsChanged, ucrChkSpecifyRows.ControlContentsChanged, ucrNudNumberRows.ControlContentsChanged, ucrPnlDisplayFrom.ControlContentsChanged, ucrChkSortColumn.ControlContentsChanged, ucrReceiverSortCol.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub FunctionControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDisplayFrom.ControlValueChanged, ucrPnlDisplayWindow.ControlValueChanged, ucrChkSpecifyRows.ControlValueChanged
        If bControlsUpdated Then
            SetiCallType()
        End If
    End Sub

    Private Sub ucrChkSortColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSortColumn.ControlValueChanged, ucrPnlDisplayWindow.ControlValueChanged
        If rdoHTMLOutputWindow.Checked AndAlso ucrChkSortColumn.Checked Then
            ucrReceiverSortCol.SetMeAsReceiver()
        Else
            ucrReceiverView.SetMeAsReceiver()
        End If
    End Sub
End Class