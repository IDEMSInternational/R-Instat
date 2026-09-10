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

Imports instat
Imports instat.Translations
Imports RDotNet
Public Class dlgPrepareDataReshapeUnnest

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bUniqueChecked As Boolean = False

    Private clsDummyFunction, clsExtractJSONColsFunction As RFunction
    Private clsAnyDuplicatesFunction As New RFunction

    Private clsAssignOperator As ROperator


    Private Sub dlgPrepareDataReshapeUnnest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
        autoTranslate(Me)
        SetDialogSize()
        HideShowCheckUniqueBtn()
    End Sub

    Private Sub InitialiseDialog()
        ucrPnlJSONOther.AddRadioButton(rdoJSON)
        ucrPnlJSONOther.AddRadioButton(rdoOther)
        ucrPnlJSONOther.AddParameterValuesCondition(rdoJSON, "checked", "json")
        ucrPnlJSONOther.AddParameterValuesCondition(rdoOther, "checked", "other")

        rdoOther.Enabled = False

        ucrPnlJSONOther.AddToLinkedControls({ucrSelectorUnnest, ucrReceiverJSONCols, ucrReceiverKeyCols, ucrReceiverCarryCols, ucrChkCarryCols, ucrInputNewIDName, ucrInputCheckInput}, {rdoJSON}, bNewLinkedHideIfParameterMissing:=True)

        ucrSelectorUnnest.SetParameter(New RParameter("data_name", 0))
        ucrSelectorUnnest.SetParameterIsString()

        ucrReceiverJSONCols.SetParameter(New RParameter("json_cols", iNewPosition:=1))
        ucrReceiverJSONCols.SetParameterIsString()
        ucrReceiverJSONCols.Selector = ucrSelectorUnnest
        ucrReceiverJSONCols.SetLinkedDisplayControl(lblJSONCols)
        ucrReceiverJSONCols.SetMeAsReceiver()

        ucrReceiverKeyCols.SetParameter(New RParameter("key_columns", iNewPosition:=2))
        ucrReceiverKeyCols.SetParameterIsString()
        ucrReceiverKeyCols.Selector = ucrSelectorUnnest
        ucrReceiverKeyCols.SetLinkedDisplayControl(lblKeyCols)

        ucrReceiverCarryCols.SetParameter(New RParameter("carry_columns", iNewPosition:=3))
        ucrReceiverCarryCols.SetParameterIsString()
        ucrReceiverCarryCols.Selector = ucrSelectorUnnest
        ucrReceiverCarryCols.SetLinkedDisplayControl(lblCarryCols)

        ucrChkCarryCols.SetText("Carry Columns")
        ucrChkCarryCols.AddParameterValuesCondition(True, "carry_cols", "True")
        ucrChkCarryCols.AddParameterValuesCondition(False, "carry_cols", "False")
        ucrChkCarryCols.AddToLinkedControls({ucrReceiverCarryCols}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputNewIDName.SetParameter(New RParameter("id_column", iNewPosition:=4))
        ucrInputNewIDName.SetLinkedDisplayControl(lblNewIDName)

        ucrInputCheckInput.IsReadOnly = True
    End Sub

    Private Sub SetDefaults()
        clsDummyFunction = New RFunction
        clsExtractJSONColsFunction = New RFunction
        clsAssignOperator = New ROperator

        bUniqueChecked = False
        ucrSelectorUnnest.Reset()
        ucrInputNewIDName.Reset()
        ucrReceiverJSONCols.SetMeAsReceiver()
        ucrInputCheckInput.SetName("")
        ucrInputCheckInput.txtInput.BackColor = Color.White

        clsDummyFunction.AddParameter("checked", "json", iPosition:=0)
        clsDummyFunction.AddParameter("carry_cols", "False", iPosition:=1)

        clsExtractJSONColsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_dataframes_from_JSON_columns")
        clsExtractJSONColsFunction.AddParameter("json_cols", "json_cols", iPosition:=1)

        clsAssignOperator.SetOperation("<-")
        clsAssignOperator.AddParameter("left", "json_cols", iPosition:=0, bIncludeArgumentName:=False)
        clsAssignOperator.AddParameter("right", ucrReceiverJSONCols.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)

        ucrBase.clsRsyntax.ClearCodes()
        SetBaseFunction()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorUnnest.SetRCode(clsExtractJSONColsFunction, bReset)
        ucrReceiverKeyCols.SetRCode(clsExtractJSONColsFunction, bReset)
        ucrReceiverCarryCols.SetRCode(clsExtractJSONColsFunction, bReset)
        ucrPnlJSONOther.SetRCode(clsDummyFunction, bReset)

        If bReset Then
            ucrChkCarryCols.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnabled = True

        If rdoJSON.Checked Then
            If ucrReceiverJSONCols.IsEmpty() OrElse ucrReceiverKeyCols.IsEmpty() Then
                bOkEnabled = False
            ElseIf ucrChkCarryCols.Checked AndAlso ucrReceiverCarryCols.IsEmpty() Then
                bOkEnabled = False
            ElseIf Not bUniqueChecked Then
                bOkEnabled = False
            End If
        End If

        ucrBase.OKEnabled(bOkEnabled)
    End Sub

    Private Sub cmdCheckUniqueKeys_Click(sender As Object, e As EventArgs) Handles cmdCheckUniqueKeys.Click
        Dim expTemp As SymbolicExpression
        Dim iAnyDuplicated As Integer

        clsAnyDuplicatesFunction.SetRCommand("anyDuplicated")

        clsAnyDuplicatesFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverKeyCols.GetVariables())
        Try
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsAnyDuplicatesFunction.ToScript())
            iAnyDuplicated = expTemp.AsInteger(0)
        Catch ex As Exception
            iAnyDuplicated = -1
        End Try
        bUniqueChecked = False
        If iAnyDuplicated = -1 Then
            ucrInputCheckInput.SetName("Developer error! Could not check uniqueness.")
            ucrInputCheckInput.txtInput.BackColor = Color.Yellow
        ElseIf iAnyDuplicated > 0 Then
            ucrInputCheckInput.SetName("Column(s) do not define a key. Entries not unique.")
            ucrInputCheckInput.txtInput.BackColor = Color.LightCoral
        Else
            ucrInputCheckInput.SetName("Column(s) define a key.")
            ucrInputCheckInput.txtInput.BackColor = Color.LightGreen
            bUniqueChecked = True
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverJSONCols_ControlValueChanges(ucrChangedControl As ucrCore) Handles ucrReceiverJSONCols.ControlValueChanged
        clsAssignOperator.AddParameter("right", ucrReceiverJSONCols.GetVariableNames(), iPosition:=1, bIncludeArgumentName:=False)
    End Sub

    Private Sub ucrInputNewIDName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputNewIDName.ControlValueChanged
        If clsExtractJSONColsFunction IsNot Nothing Then
            If Not ucrInputNewIDName.IsEmpty() Then
                clsExtractJSONColsFunction.AddParameter("id_column", Chr(34) & ucrInputNewIDName.GetText() & Chr(34), iPosition:=4)
            Else
                clsExtractJSONColsFunction.RemoveParameterByName("id_column")
            End If
        End If
    End Sub

    Private Sub ucrPnlJSONOther_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlJSONOther.ControlValueChanged
        HideShowCheckUniqueBtn()
        SetBaseFunction()
        TestOkEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorUnnest.ControlContentsChanged, ucrReceiverJSONCols.ControlContentsChanged,
        ucrReceiverKeyCols.ControlContentsChanged, ucrPnlJSONOther.ControlContentsChanged, ucrReceiverCarryCols.ControlContentsChanged, ucrInputNewIDName.ControlContentsChanged,
        ucrInputCheckInput.ControlContentsChanged, ucrChkCarryCols.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub HideShowCheckUniqueBtn()
        If rdoJSON.Checked Then
            cmdCheckUniqueKeys.Visible = True
            cmdCheckUniqueKeys.Enabled = True
        Else
            cmdCheckUniqueKeys.Visible = False
            cmdCheckUniqueKeys.Enabled = False
        End If
    End Sub

    Private Sub SetBaseFunction()
        If rdoJSON.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsAssignOperator, iPosition:=0)
            ucrBase.clsRsyntax.SetBaseRFunction(clsExtractJSONColsFunction)
        End If
    End Sub

    Private Sub SetDialogSize()
        Me.Size = New Size(440, 520)
    End Sub
End Class




