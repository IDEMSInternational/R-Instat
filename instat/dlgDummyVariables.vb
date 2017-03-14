﻿
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgDummyVariables
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDummy As New RFunction
    Private Sub dlgIndicatorVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        'reset
        ucrSelectorDummyVariable.Reset()
        'set default function
        clsDummy.SetRCommand("dummy")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDummy)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="dummy_vars", strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Public Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 41
        'Set Receiver
        ucrReceiverFactor.Selector = ucrSelectorDummyVariable
        ucrVariateReceiver.Selector = ucrSelectorDummyVariable
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.SetParameter(New RParameter("x", 0))
        ucrReceiverFactor.SetParameterIsRFunction()

        'Set RadioBattons : Parameters yet to be set up
        'ucrPnlLevelOmitted.SetParameter(New RParameter(""))
        'ucrPnlLevelOmitted.AddRadioButton(rdoNone, "")
        'ucrPnlLevelOmitted.AddRadioButton(rdoFirst, "")
        'ucrPnlLevelOmitted.AddRadioButton(rdoLast, "")
        'ucrPnlLevelOmitted.AddRadioButton(rdoLevelNumber, "")
        ucrPnlLevelOmitted.bAllowNonConditionValues = True
        'currently disabled sice the functions and parameters are yet to be set
        ucrChkWithXVariable.Enabled = False
        lblVariate.Enabled = False
        ucrVariateReceiver.Enabled = False
        ucrChkWithXVariable.SetText("With X Variable")
        ' ucrChkWithXVariable.SetParameter(New RParameter(""))
        grpLevelOmitted.Enabled = False

        'Note: This was not implemented (Additions of ucrInputColumns were added for appending new columns with prefix "dummy" ): Just added if incase it was to be added otherwise it can be deleted

        'ucrSaveDummy.SetPrefix("dummy")
        'ucrSaveDummy.SetSaveTypeAsColumn()
        'ucrSaveDummy.SetDataFrameSelector(ucrSelectorDummyVariable.ucrAvailableDataFrames)
        'ucrSaveDummy.SetCheckBoxText("Save Dummy:")
        'ucrSaveDummy.SetIsComboBox()

        ' ucrChkWithXVariable.AddToLinkedControls(ucrVariateReceiver, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedDisabledIfParameterMissing:=True)
        'ucrVariateReceiver.SetLinkedDisplayControl(lblVariate)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFactor.IsEmpty AndAlso ((ucrChkWithXVariable.Checked AndAlso Not ucrVariateReceiver.IsEmpty) OrElse Not ucrChkWithXVariable.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    'Private Sub SetMeAsReceiver()
    '    If ucrChkWithXVariable.Checked Then
    '        ucrVariateReceiver.SetMeAsReceiver()
    '    Else
    '        ucrReceiverFactor.SetMeAsReceiver()
    '    End If
    'End Sub

    'Private Sub ucrChkWithXVariable_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWithXVariable.ControlValueChanged
    '    VariateVisible()
    ' SetReceiver()
    'End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged, ucrChkWithXVariable.ControlContentsChanged, ucrVariateReceiver.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class