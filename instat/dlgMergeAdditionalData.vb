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

Public Class dlgMergeAdditionalData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsInsertColumnFunction, clsGetColumnsFromData, clsListFunction, clsImportDataFunction As New RFunction
    Private lstJoinColumns As New List(Of String)
    Private clsLeftJoinFunction As New RFunction
    Private clsByListFunction As New RFunction
    Private clsGetVariablesFunction As New RFunction
    Private bResetSubdialog As Boolean = True
    Private bBySpecified As Boolean
    Private bJoinColsAreUnique As Boolean = False

    Private Sub dlgMergeAdditionalData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        SetMergingBy()
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 186
        ucrToDataFrame.SetParameter(New RParameter("x", 0))
        ucrToDataFrame.SetParameterIsRFunction()
        ucrToDataFrame.SetLabelText("To Data Frame:")

        ucrFromDataFrame.SetLabelText("From Data Frame:")
        ucrFromDataFrame.SetParameter(New RParameter("data_name", 0))
        ucrFromDataFrame.SetParameterIsString()

        ucrReceiverSecond.Selector = ucrFromDataFrame
        ucrReceiverSecond.bForceAsDataFrame = True

        ucrChkSaveDataFrame.SetText("New Data Frame:")
        ucrChkSaveDataFrame.AddFunctionNamesCondition(True, "left_join")
        ucrChkSaveDataFrame.AddFunctionNamesCondition(False, frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")

        ucrInputMergingBy.IsReadOnly = True
        ucrInputMergingBy.IsMultiline = True
        ucrInputCheckInput.IsReadOnly = True
        EnableDisableCmdCheckUnique()
    End Sub

    Private Sub SetDefaults()
        clsLeftJoinFunction = New RFunction
        clsByListFunction = New RFunction
        clsInsertColumnFunction = New RFunction
        clsImportDataFunction = New RFunction
        clsListFunction = New RFunction
        clsGetColumnsFromData = New RFunction
        clsGetVariablesFunction = New RFunction

        ucrToDataFrame.Reset()
        ucrFromDataFrame.Reset()
        ucrReceiverSecond.SetMeAsReceiver()
        ucrInputSaveDataFrame.SetName("merge")
        ucrInputCheckInput.Reset()

        clsGetVariablesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")

        clsLeftJoinFunction.SetPackageName("dplyr")
        clsLeftJoinFunction.SetRCommand("left_join")
        clsLeftJoinFunction.AddParameter("y", clsRFunctionParameter:=clsGetColumnsFromData, iPosition:=1)

        clsByListFunction.SetRCommand("c")

        clsGetColumnsFromData.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetColumnsFromData.AddParameter("use_current_filter", "FALSE", iPosition:=2)


        clsListFunction.SetRCommand("list")

        clsImportDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$import_data")
        clsImportDataFunction.AddParameter("data_tables", clsRFunctionParameter:=clsListFunction, iPosition:=0)
        clsImportDataFunction.AddParameter("prefix", "FALSE", iPosition:=1)

        SetDataFrameAssign()
        ucrBase.clsRsyntax.SetBaseRFunction(clsInsertColumnFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        ucrFromDataFrame.SetRCode(clsGetVariablesFunction, bResetControls)
        ucrToDataFrame.SetRCode(clsLeftJoinFunction, bResetControls)
        ucrChkSaveDataFrame.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrToDataFrame.cboAvailableDataFrames.Text <> "" AndAlso ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso
                  Not ucrReceiverSecond.IsEmpty() AndAlso bBySpecified AndAlso bJoinColsAreUnique Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub DataFrames_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrFromDataFrame.ControlValueChanged, ucrToDataFrame.ControlValueChanged
        ' Ensures options set on the subdialog are "reset" since they depend on data frame choice
        clsLeftJoinFunction.RemoveParameterByName("by")
        clsByListFunction.ClearParameters()
        SetDataFrameAssign()
        SetMergingBy()
        SetInputCheckVisibility(False)
    End Sub

    Private Sub ucrChkSaveDataFrame_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSaveDataFrame.ControlValueChanged, ucrInputSaveDataFrame.ControlValueChanged
        SetDataFrameAssign()
    End Sub

    Private Sub SetDataFrameAssign()
        If clsLeftJoinFunction IsNot Nothing Then
            Dim strParam As String = ucrToDataFrame.cboAvailableDataFrames.Text
            If strParam <> "" Then
                clsLeftJoinFunction.RemoveAssignTo()
                If ucrChkSaveDataFrame.Checked Then
                    clsLeftJoinFunction.SetAssignTo(ucrInputSaveDataFrame.GetText, strTempDataframe:=ucrInputSaveDataFrame.GetText)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsLeftJoinFunction)
                    ucrInputSaveDataFrame.Visible = True
                    bJoinColsAreUnique = True
                    cmdCheckUnique.Visible = False
                    SetInputCheckVisibility(False)
                Else
                    clsLeftJoinFunction.SetAssignTo(strParam)
                    clsListFunction.ClearParameters()
                    clsListFunction.AddParameter(strParam, clsRFunctionParameter:=clsLeftJoinFunction, iPosition:=0)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsImportDataFunction)
                    ucrInputSaveDataFrame.Visible = False
                    cmdCheckUnique.Visible = True
                End If
            Else
                clsLeftJoinFunction.RemoveAssignTo()
            End If
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetMergingBy()
        Dim dctJoinColumns As New Dictionary(Of String, String)
        lstJoinColumns.Clear()
        If ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso ucrToDataFrame.cboAvailableDataFrames.Text <> "" Then
            If clsLeftJoinFunction.ContainsParameter("by") Then
                For Each clsTempParam As RParameter In clsByListFunction.clsParameters
                    dctJoinColumns.Add(clsTempParam.strArgumentName.Trim(Chr(34)), clsTempParam.strArgumentValue.Trim(Chr(34)))
                Next
            Else
                Dim lstFirstColumns As List(Of String)
                Dim lstSecondColumns As List(Of String)
                lstFirstColumns = frmMain.clsRLink.GetColumnNames(ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
                lstSecondColumns = frmMain.clsRLink.GetColumnNames(ucrToDataFrame.cboAvailableDataFrames.Text)
                Dim i As Integer = 0
                For Each strFirst As String In lstFirstColumns
                    If lstSecondColumns.Contains(strFirst) Then
                        dctJoinColumns.Add(strFirst, strFirst)
                        clsByListFunction.AddParameter(Chr(34) & strFirst & Chr(34), Chr(34) & strFirst & Chr(34), iPosition:=i)
                        i += 1
                    End If
                Next
                If clsByListFunction.iParameterCount > 0 Then
                    clsLeftJoinFunction.AddParameter("by", clsRFunctionParameter:=clsByListFunction, iPosition:=2)
                End If
            End If
            If dctJoinColumns.Count > 0 Then
                Dim lstJoinPairs As New List(Of String)
                For Each kvpTemp As KeyValuePair(Of String, String) In dctJoinColumns
                    lstJoinPairs.Add(kvpTemp.Key & " = " & kvpTemp.Value)
                    lstJoinColumns.Add(kvpTemp.Value)
                Next
                ucrInputMergingBy.SetName(String.Join(", ", lstJoinPairs))
                ucrInputMergingBy.txtInput.BackColor = SystemColors.Control
                cmdModify.BackColor = SystemColors.ButtonFace
                cmdModify.UseVisualStyleBackColor = True
            Else
                ucrInputMergingBy.SetName("No columns to merge by!" & Environment.NewLine & "Click Join Options to specify merging columns.")
                ucrInputMergingBy.txtInput.BackColor = Color.LightCoral
                cmdModify.BackColor = Color.LemonChiffon
            End If
        Else
            ucrInputMergingBy.SetName("")
            ucrInputMergingBy.txtInput.BackColor = SystemColors.Control
            clsLeftJoinFunction.RemoveParameterByName("by")
            clsByListFunction.ClearParameters()
        End If
        bBySpecified = (dctJoinColumns.Count > 0)
        TestOkEnabled()
    End Sub

    Private Sub cmdModify_Click(sender As Object, e As EventArgs) Handles cmdModify.Click
        sdgMerge.Setup(ucrToDataFrame.cboAvailableDataFrames.Text, ucrFromDataFrame.ucrAvailableDataFrames.cboAvailableDataFrames.Text, clsLeftJoinFunction, clsByListFunction, bResetSubdialog)
        sdgMerge.ShowDialog()
        SetMergingBy()
        bResetSubdialog = False
        TestOkEnabled()
    End Sub

    Private Sub AddColumns()
        Dim lstVariables As New List(Of String)
        If ucrReceiverSecond.lstSelectedVariables.Items.Count > 0 Then
            lstVariables.Clear()
            lstVariables = ucrReceiverSecond.GetVariableNamesAsList()
            For Each var In lstJoinColumns
                lstVariables.Add(var)
            Next
            clsGetColumnsFromData.AddParameter("data_name", Chr(34) & ucrFromDataFrame.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
            clsGetColumnsFromData.AddParameter("col_names", frmMain.clsRLink.GetListAsRString(lstVariables, bWithQuotes:=True), iPosition:=1)
        End If
    End Sub

    Private Sub EnableDisableCmdCheckUnique()
        cmdCheckUnique.Enabled = Not ucrReceiverSecond.IsEmpty OrElse Not ucrInputMergingBy.IsEmpty
    End Sub

    Private Sub CheckUnique()
        Dim clsAnyDuplicatesFunction As New RFunction
        Dim iAnyDuplicated As Integer

        If ucrInputMergingBy.GetText <> "" AndAlso lstJoinColumns.Count > 0 Then
            clsGetVariablesFunction.AddParameter("col_names", frmMain.clsRLink.GetListAsRString(lstJoinColumns, bWithQuotes:=True), iPosition:=1)
            clsAnyDuplicatesFunction.SetRCommand("anyDuplicated")
            clsAnyDuplicatesFunction.AddParameter("x", clsRFunctionParameter:=clsGetVariablesFunction)
            Try
                iAnyDuplicated = frmMain.clsRLink.RunInternalScriptGetValue(clsAnyDuplicatesFunction.ToScript()).AsInteger(0)
            Catch ex As Exception
                iAnyDuplicated = -1
            End Try
            bJoinColsAreUnique = False
            If iAnyDuplicated = -1 Then
                ucrInputCheckInput.SetName("Developer error! Could not check uniqueness.")
                ucrInputCheckInput.txtInput.BackColor = Color.Yellow
            ElseIf iAnyDuplicated > 0 Then
                ucrInputCheckInput.SetName("From Data Frame entries not unique.")
                ucrInputCheckInput.txtInput.BackColor = Color.LightCoral
            Else
                ucrInputCheckInput.SetName("Join column(s) unique in From Data Frame.")
                ucrInputCheckInput.txtInput.BackColor = Color.LightGreen
                bJoinColsAreUnique = True
            End If
        End If
        TestOkEnabled()
    End Sub

    Private Sub cmdCheckUnique_Click(sender As Object, e As EventArgs) Handles cmdCheckUnique.Click
        CheckUnique()
        SetInputCheckVisibility(True)
    End Sub

    Private Sub SetInputCheckVisibility(bCheck As Boolean)
        ucrInputCheckInput.Visible = bCheck
    End Sub

    Private Sub ucrReceiverSecond_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSecond.ControlValueChanged
        AddColumns()
        EnableDisableCmdCheckUnique()
        SetInputCheckVisibility(False)
    End Sub

    Private Sub ucrInputMergingBy_TextChanged(sender As Object, e As EventArgs) Handles ucrInputMergingBy.TextChanged
        AddColumns()
        CheckUnique()
        SetDataFrameAssign()
        SetInputCheckVisibility(False)
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrToDataFrame.ControlContentsChanged, ucrFromDataFrame.ControlContentsChanged, ucrReceiverSecond.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class