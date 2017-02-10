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
Imports instat
Imports instat.Translations

Public Class dlgView
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsMainFunction As RFunction

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

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrNudNumberRows.Maximum = Decimal.MaxValue
        SetRCode(Me, clsMainFunction, bReset)
        DataFrameLength()
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorForView.Reset()
        ucrSelectorForView.Focus()
        clsDefaultFunction.SetRCommand("View")
        clsMainFunction = clsDefaultFunction.Clone()
        ucrBase.clsRsyntax.SetBaseRFunction(clsMainFunction)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 32

        ucrPnlDisplayWindow.AddRadioButton(rdoDispOutputWindow)
        ucrPnlDisplayWindow.AddRadioButton(rdoDispSepOutputWindow)
        ucrPnlDisplayWindow.AddToLinkedControls(ucrChkSpecifyRows, {rdoDispOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrPnlDisplayWindow.AddFunctionNamesCondition(rdoDispSepOutputWindow, "View")

        ucrPnlDisplayFrom.AddRadioButton(rdoBottom)
        ucrPnlDisplayFrom.AddRadioButton(rdoTop)
        ucrPnlDisplayFrom.SetLinkedDisplayControl(lblDisplayFrom)
        ucrPnlDisplayFrom.AddFunctionNamesCondition(rdoTop, "head")
        ucrPnlDisplayFrom.AddFunctionNamesCondition(rdoBottom, "tail")
        ucrPnlDisplayFrom.bAllowNonConditionValues = True

        ucrReceiverView.Selector = ucrSelectorForView
        ucrReceiverView.SetMeAsReceiver()
        ucrReceiverView.SetParameter(New RParameter("x", 0))
        ucrReceiverView.SetParameterIsRFunction()

        ucrChkSpecifyRows.SetText("Specify Rows")
        ucrChkSpecifyRows.AddToLinkedControls(ucrPnlDisplayFrom, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoTop)
        ucrChkSpecifyRows.AddToLinkedControls(ucrNudNumberRows, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=6)
        ucrSelectorForView.SetParameter(New RParameter("title", 1))
        ucrSelectorForView.SetParameterIsString()

        ucrNudNumberRows.SetParameter(New RParameter("n", 1))
        ucrNudNumberRows.SetRDefault(6)
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

    Private Sub SetIcallType()
        If rdoDispOutputWindow.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
            If ucrChkSpecifyRows.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsMainFunction)
                If rdoTop.Checked Then
                    clsMainFunction.SetRCommand("head")
                Else
                    clsMainFunction.SetRCommand("tail")
                End If
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(ucrReceiverView.GetVariables())
            End If
        ElseIf rdoDispSepOutputWindow.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsMainFunction)
            clsMainFunction.SetRCommand("View")
        End If
    End Sub

    Private Sub ucrReceiverView_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverView.ControlContentsChanged, ucrPnlDisplayWindow.ControlContentsChanged, ucrChkSpecifyRows.ControlContentsChanged, ucrNudNumberRows.ControlContentsChanged, ucrPnlDisplayFrom.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub FunctionControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDisplayFrom.ControlValueChanged, ucrPnlDisplayWindow.ControlValueChanged, ucrChkSpecifyRows.ControlValueChanged
        SetIcallType()
    End Sub
End Class