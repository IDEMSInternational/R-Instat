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
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public clsHeadOrTail, clsOverall As New RFunction

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
        ucrReceiverView.SetRCode(clsHeadOrTail, bReset)
        ucrSelectorForView.SetRCode(clsOverall, bReset)
    End Sub

    Private Sub SetDefaults()
        Dim clsOveralDefaultFunction As New RFunction
        Dim clsDefaultHeadOrTail As New RFunction
        ucrSelectorForView.Reset()
        ucrSelectorForView.Focus()
        rdoDispSepOutputWindow.Checked = True
        ucrSpecifyRows.Checked = True
        clsDefaultHeadOrTail.SetRCommand("head")
        clsOveralDefaultFunction.SetRCommand("View")
        clsHeadOrTail = clsDefaultHeadOrTail.Clone
        clsOverall = clsOveralDefaultFunction.Clone
        clsOveralDefaultFunction.AddParameter("x", clsRFunctionParameter:=clsHeadOrTail)
        ucrBase.clsRsyntax.SetBaseRFunction(clsOveralDefaultFunction)
    End Sub

    'Public Sub SetDefaultHeadOrTail()
    '    Dim clsDefaultHeadOrTail As New RFunction
    '    If rdoTop.Checked Then
    '        clsDefaultHeadOrTail.SetRCommand("head")
    '    Else
    '        clsDefaultHeadOrTail.SetRCommand("tail")
    '    End If
    'End Sub

    Private Sub NumberOfRows()
        If ucrNudNumberRows.Maximum >= 6 Then
            ucrNudNumberRows.Value = 6
        Else
            ucrNudNumberRows.Value = ucrNudNumberRows.Maximum
        End If
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 32
        NumberOfRows()
        ucrPnlDisplayWindow.AddRadioButton(rdoDispOutputWindow)
        ucrPnlDisplayWindow.AddRadioButton(rdoDispSepOutputWindow)
        ucrPnlDisplayFrom.AddRadioButton(rdoBottom)
        ucrPnlDisplayFrom.AddRadioButton(rdoTop)

        ucrReceiverView.Selector = ucrSelectorForView
        ucrReceiverView.SetMeAsReceiver()
        DataFrameLength()

        ucrPnlDisplayWindow.AddToLinkedControls(ucrSpecifyRows, {rdoDispOutputWindow}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)

        ucrSpecifyRows.AddToLinkedControls(ucrPnlDisplayFrom, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlDisplayFrom.SetLinkedDisplayControl(lblDisplayFrom)

        ucrSpecifyRows.AddToLinkedControls(ucrNudNumberRows, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrNudNumberRows.SetLinkedDisplayControl(lblNumberofRows)

        SetIcallType()
        ucrSelectorForView.SetParameter(New RParameter("title"))
        ucrSelectorForView.SetParameterIsString()

        ucrNudNumberRows.SetParameter(New RParameter("n"))

        ucrReceiverView.SetParameter(New RParameter("x"))
        ucrReceiverView.SetParameterIsRFunction()
        ucrSpecifyRows.SetText("Specify Rows")
    End Sub
    'Private Sub ucrPnlRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDisplayFrom.ControlValueChanged
    '    SetDefaultHeadOrTail()
    'End Sub

    Private Sub ucrSelectorForView_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorForView.ControlValueChanged
        DataFrameLength()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverView.IsEmpty Then
            If rdoDispSepOutputWindow.Checked Then
                ucrBase.OKEnabled(True)
            Else
                If ucrSpecifyRows.Checked Then
                    If ucrNudNumberRows.GetText <> "" Then
                        ucrBase.OKEnabled(True)
                    Else
                        ucrBase.OKEnabled(False)
                    End If
                Else
                    If rdoBottom.Checked OrElse rdoTop.Checked Then
                        ucrBase.OKEnabled(True)
                    End If
                End If
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
        Else
        End If
    End Sub

    Private Sub ucrReceiverView_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverView.ControlContentsChanged, ucrPnlDisplayWindow.ControlContentsChanged, ucrSpecifyRows.ControlContentsChanged, ucrNudNumberRows.ControlContentsChanged, ucrPnlDisplayFrom.ControlContentsChanged
        SetIcallType()
        TestOKEnabled()
    End Sub
End Class