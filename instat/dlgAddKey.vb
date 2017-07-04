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
Imports RDotNet

Public Class dlgAddKey
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultRFunction As New RFunction
    Private clsAnyDuplicatesFunction As New RFunction
    Private clsSumFunction As New RFunction
    Private clsIsNAFunction As New RFunction
    Private bUniqueChecked As Boolean = False

    Private Sub dlgAddKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        bUniqueChecked = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 504

        ucrSelectorKeyColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorKeyColumns.SetParameterIsString()

        ucrReceiverKeyColumns.SetParameter(New RParameter("col_names", 1))
        ucrReceiverKeyColumns.SetParameterIsString()
        ucrReceiverKeyColumns.Selector = ucrSelectorKeyColumns
        ucrReceiverKeyColumns.SetMeAsReceiver()

        ucrInputKeyName.SetParameter(New RParameter("key_name", 2))
        ucrInputKeyName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        clsDefaultRFunction = New RFunction

        ucrSelectorKeyColumns.Reset()
        ucrInputKeyName.SetName("")
        ucrInputKeyName.Reset()
        ucrInputCheckInput.Reset()
        bUniqueChecked = False

        clsDefaultRFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_key")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultRFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverKeyColumns.IsEmpty()) AndAlso (Not ucrInputKeyName.IsEmpty())) AndAlso bUniqueChecked Then
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
        Dim iSumNA As Integer

        clsAnyDuplicatesFunction.SetRCommand("anyDuplicated")
        clsSumFunction.SetRCommand("sum")
        clsIsNAFunction.SetRCommand("is.na")
        clsSumFunction.AddParameter("x", clsRFunctionParameter:=clsIsNAFunction)

        clsAnyDuplicatesFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverKeyColumns.GetVariables())
        clsIsNAFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverKeyColumns.GetVariables())
        Try
            iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsAnyDuplicatesFunction.ToScript()).AsInteger(0)
            iSumNA = frmMain.clsRLink.RunInternalScriptGetValue(clsSumFunction.ToScript()).AsInteger(0)
        Catch ex As Exception
            iAnyDuplicated = -1
            iSumNA = -1
        End Try
        bUniqueChecked = False
        If iAnyDuplicated = -1 OrElse iSumNA = -1 Then
            ucrInputCheckInput.SetName("Developer error! Could not check uniqueness/missing values.")
            ucrInputCheckInput.txtInput.BackColor = Color.Yellow
        ElseIf iAnyDuplicated > 0 Then
            ucrInputCheckInput.SetName("Column(s) cannot define a key. Entries not unique.")
            ucrInputCheckInput.txtInput.BackColor = Color.LightCoral
        ElseIf iSumNA > 0 Then
            ucrInputCheckInput.SetName("Column(s) cannot define a key. Entries contain missing values.")
            ucrInputCheckInput.txtInput.BackColor = Color.LightCoral
        Else
            ucrInputCheckInput.SetName("Column(s) can define a key.")
            ucrInputCheckInput.txtInput.BackColor = Color.LightGreen
            bUniqueChecked = True
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverKeyColumns_ControlValueChanged() Handles ucrReceiverKeyColumns.ControlValueChanged
        If ucrReceiverKeyColumns.IsEmpty Then
            cmdCheckUnique.Enabled = False
        Else
            cmdCheckUnique.Enabled = True
        End If
        bUniqueChecked = False
        ucrInputCheckInput.SetName("")
        ucrInputCheckInput.txtInput.BackColor = SystemColors.Window
    End Sub

    Private Sub AllControls_ControlContentsChanged() Handles ucrInputKeyName.ControlContentsChanged, ucrReceiverKeyColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class