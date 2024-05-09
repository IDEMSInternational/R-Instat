﻿' R- Instat
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
Imports RDotNet

Public Class dlgAddKey
    Public enumAddkeyMode As String = AddkeyMode.Prepare
    Public Enum AddkeyMode
        Prepare
        Describe
        Climatic
    End Enum

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultRFunction As New RFunction
    Private clsAnyDuplicatesFunction As New RFunction
    Private bUniqueChecked As Boolean = False

    Private Sub dlgAddKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetHelpOptions()
        bReset = False
        bUniqueChecked = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 504
        ucrBase.clsRsyntax.iCallType = 2
        ucrInputCheckInput.IsReadOnly = True
        EnableDisableCmdCheckUnique()

        ucrSelectorKeyColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorKeyColumns.SetParameterIsString()

        ucrReceiverKeyColumns.SetParameter(New RParameter("col_names", 1))
        ucrReceiverKeyColumns.SetParameterIsString()
        ucrReceiverKeyColumns.Selector = ucrSelectorKeyColumns
        ucrReceiverKeyColumns.SetMeAsReceiver()

        ucrSaveKey.SetParameter(New RParameter("key_name", 2))
        ucrSaveKey.SetSaveTypeAsKey()
        ucrSaveKey.SetDataFrameSelector(ucrSelectorKeyColumns.ucrAvailableDataFrames)
        ucrSaveKey.SetLabelText("Key:")
        ucrSaveKey.SetIsTextBox()
        ucrSaveKey.SetPrefix("key")
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction

        ucrSelectorKeyColumns.Reset()
        ucrSaveKey.Reset()
        ucrInputCheckInput.Reset()
        bUniqueChecked = False

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverKeyColumns.IsEmpty()) AndAlso ucrSaveKey.IsComplete) AndAlso bUniqueChecked Then

            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdCheckUnique_Click(sender As Object, e As EventArgs) Handles cmdCheckUnique.Click
        Dim iAnyDuplicated As Integer

        clsAnyDuplicatesFunction.SetRCommand("anyDuplicated")

        clsAnyDuplicatesFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverKeyColumns.GetVariables())
        Try
            iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsAnyDuplicatesFunction.ToScript()).AsInteger(0)
        Catch ex As Exception
            iAnyDuplicated = -1
        End Try
        bUniqueChecked = False
        If iAnyDuplicated = -1 Then
            ucrInputCheckInput.SetName("Developer error! Could not check uniqueness.")
            ucrInputCheckInput.txtInput.BackColor = Color.Yellow
        ElseIf iAnyDuplicated > 0 Then
            ucrInputCheckInput.SetName("Column(s) cannot define a key. Entries not unique.")
            ucrInputCheckInput.txtInput.BackColor = Color.LightCoral
        Else
            ucrInputCheckInput.SetName("Column(s) can define a key.")
            ucrInputCheckInput.txtInput.BackColor = Color.LightGreen
            bUniqueChecked = True
        End If
        TestOKEnabled()
    End Sub

    Private Sub EnableDisableCmdCheckUnique()
        If ucrReceiverKeyColumns.IsEmpty Then
            cmdCheckUnique.Enabled = False
        Else
            cmdCheckUnique.Enabled = True
        End If
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumAddkeyMode
            Case AddkeyMode.Prepare
                ucrBase.iHelpTopicID = 416
            Case AddkeyMode.Climatic
                ucrBase.iHelpTopicID = 424
        End Select
    End Sub

    Private Sub ucrReceiverKeyColumns_ControlValueChanged() Handles ucrReceiverKeyColumns.ControlValueChanged
        EnableDisableCmdCheckUnique()
        bUniqueChecked = False
        ucrInputCheckInput.SetName("")
        ucrInputCheckInput.txtInput.BackColor = SystemColors.Window
    End Sub

    Private Sub AllControls_ControlContentsChanged() Handles ucrSaveKey.ControlContentsChanged, ucrReceiverKeyColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class