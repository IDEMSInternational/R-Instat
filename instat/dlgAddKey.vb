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
Imports RDotNet

Public Class dlgAddKey
    Dim bFirstLoad As Boolean = True
    Dim clsAnyDuplicatesFunction As New RFunction
    Dim clsSumFunction As New RFunction
    Dim clsIsNAFunction As New RFunction
    Dim bUniqueChecked As Boolean = False

    Private Sub dlgAddKey_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.iHelpTopicID = 504
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReOpenDialog()
        End If
        bUniqueChecked = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverKeyColumns.Selector = ucrSelectorKeyColumns
        ucrReceiverKeyColumns.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$add_key")
        ucrInputKeyName.SetValidationTypeAsRVariable()
        clsAnyDuplicatesFunction.SetRCommand("anyDuplicated")
        clsSumFunction.SetRCommand("sum")
        clsIsNAFunction.SetRCommand("is.na")
        clsSumFunction.AddParameter("x", clsRFunctionParameter:=clsIsNAFunction)
    End Sub

    Private Sub SetDefaults()
        ucrSelectorKeyColumns.Reset()
        ucrInputKeyName.ResetText()
        ucrInputCheckInput.ResetText()
        bUniqueChecked = False
    End Sub

    Private Sub ReOpenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If ((Not ucrReceiverKeyColumns.IsEmpty()) AndAlso (Not ucrInputKeyName.IsEmpty())) AndAlso bUniqueChecked Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverKeyColumns_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverKeyColumns.SelectionChanged
        If ucrReceiverKeyColumns.IsEmpty Then
            ucrBase.clsRsyntax.RemoveParameter("col_names")
            cmdCheckUnique.Enabled = False
        Else
            ucrBase.clsRsyntax.AddParameter("col_names", ucrReceiverKeyColumns.GetVariableNames())
            cmdCheckUnique.Enabled = True
        End If
        bUniqueChecked = False
        TestOKEnabled()
        ucrInputCheckInput.SetName("")
        ucrInputCheckInput.txtInput.BackColor = SystemColors.Window
    End Sub

    Private Sub ucrSelectorKeyColumns_DataFrameChanged() Handles ucrSelectorKeyColumns.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorKeyColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub ucrInputKeyName_NameChanged() Handles ucrInputKeyName.NameChanged
        If ucrInputKeyName.IsEmpty Then
            ucrBase.clsRsyntax.RemoveParameter("key_name")
        Else
            ucrBase.clsRsyntax.AddParameter("key_name", Chr(34) & ucrInputKeyName.GetText() & Chr(34))
        End If
        TestOKEnabled()
    End Sub

    Private Sub cmdCheckUnique_Click(sender As Object, e As EventArgs) Handles cmdCheckUnique.Click
        Dim iAnyDuplicated As Integer
        Dim iSumNA As Integer

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

    Private Sub ucrInputKeyName_ContentsChanged() Handles ucrInputKeyName.ContentsChanged
        TestOKEnabled()
    End Sub
End Class