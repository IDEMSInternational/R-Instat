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
Public Class dlgDefineCRI
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private bResetSubdialog As Boolean = False
    Private clsCalculation As New ROperator
    Private clsDefineFunction As New RFunction
    Private i As Integer = 0

    Private Sub dlgDefineCRI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 527
        ucrInputCRIPreview.IsReadOnly = True
        cmdEdit.Enabled = False
        cmdDelete.Enabled = False
        ucrChkScaleNumeric.Enabled = False

        'ucrnud
        ucrNudWeights.Minimum = 0
        ucrNudWeights.Maximum = 1
        ucrNudWeights.DecimalPlaces = 2
        ucrNudWeights.Increment = 0.05

        'Receiver
        ucrReceiverRedFlag.Selector = ucrSelectorCRI
        ucrReceiverRedFlag.SetMeAsReceiver()
        ucrReceiverRedFlag.SetIncludedDataTypes({"numeric", "logical", "factor"})
        ucrReceiverRedFlag.AddIncludedMetadataProperty("Is_Corruption_Index", {"TRUE"})
        'ucrReceiverRedFlag.AddExcludedMetadataProperty("Is_Corruption_Red_Flag", {"FALSE"})

        'ucrChk
        ucrChkScaleNumeric.SetText("Scale Numeric")

        'grd
        ucrGridWeights.SetReceiver(ucrReceiverRedFlag)
        ucrGridWeights.SetAsViewerOnly()
        ucrGridWeights.strExtraColumn = "Weights"
        ucrGridWeights.AddEditableColumns({"Weights"})

        'lstbox
        lstIndexComponents.Columns.Add("Component")
        lstIndexComponents.Columns.Add("Weight(s)")

        'save
        ucrSaveCRI.SetDataFrameSelector(ucrSelectorCRI.ucrAvailableDataFrames)
        ucrSaveCRI.SetLabelText("New Column Name:")
        ucrSaveCRI.SetIsTextBox()
        ucrSaveCRI.SetPrefix("CRI")
        ucrSaveCRI.SetSaveTypeAsColumn()
    End Sub

    Private Sub SetDefaults()
        clsCalculation = New ROperator
        clsDefineFunction = New RFunction

        'Reset 
        ucrSelectorCRI.Reset()
        lstIndexComponents.Items.Clear()
        ucrInputCRIPreview.SetName("")
        ucrNudWeights.Value = 0
        clsCalculation.SetOperation("+")

        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsDefineFunction)
        ucrBase.clsRsyntax.AddParameter("display", "FALSE")

        clsDefineFunction.SetRCommand("instat_calculation$new")
        clsDefineFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsDefineFunction.AddParameter("save", 2)
        clsDefineFunction.AddParameter("result_name", Chr(34) & ucrSaveCRI.GetText() & Chr(34))
        bResetSubdialog = True
        DisplayRedFlag()
        EnableDeleteButton()
    End Sub

    Private Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorCRI.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverRedFlag.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        'SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        '        ucrSaveCRI.SetRCode(clsDefineFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If lstIndexComponents.Items.Count > 0 AndAlso ucrNudWeights.GetText <> "" AndAlso ucrSaveCRI.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub EnableAddButton()
        If Not ucrReceiverRedFlag.IsEmpty() Then
            If (ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" OrElse ucrReceiverRedFlag.strCurrDataType = "integer") Then
                If ucrNudWeights.GetText <> "" Then
                    cmdAddComponent.Enabled = True
                Else
                    cmdAddComponent.Enabled = False
                End If
            Else
                If ucrGridWeights.IsColumnComplete(2) Then
                    cmdAddComponent.Enabled = True
                Else
                    cmdAddComponent.Enabled = False
                End If
            End If
        Else
            cmdAddComponent.Enabled = False
        End If
    End Sub

    Private Sub DisplayRedFlag()
        If Not ucrReceiverRedFlag.IsEmpty Then
            lblWeights.Visible = True
            If ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "integer" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" Then
                ucrNudWeights.Visible = True
                ucrGridWeights.Visible = False
            Else
                ucrNudWeights.Visible = False
                ucrGridWeights.Visible = True
            End If
        Else
            ucrNudWeights.Visible = False
            lblWeights.Visible = False
            ucrGridWeights.Visible = False
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudWeights.ControlContentsChanged
        EnableAddButton()
        TestOKEnabled()
    End Sub

    Private Sub cmdAddComponent_Click(sender As Object, e As EventArgs) Handles cmdAddComponent.Click
        Dim lviCondition As ListViewItem
        Dim clsTempOp As ROperator
        Dim clsTempFactorOp As ROperator
        Dim strList As String = ""
        Dim strExpression As String

        clsTempOp = New ROperator
        If ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "integer" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" Then
            lviCondition = New ListViewItem({ucrReceiverRedFlag.GetVariableNames(False), ucrNudWeights.Value})
            clsTempOp.SetOperation("*")
            clsTempOp.AddParameter("column", ucrReceiverRedFlag.GetVariableNames(False), iPosition:=0)
            clsTempOp.AddParameter("weight", ucrNudWeights.Value, iPosition:=1)
        ElseIf ucrReceiverRedFlag.strCurrDataType = "factor" Then
            lviCondition = New ListViewItem({ucrReceiverRedFlag.GetVariableNames(False), ucrGridWeights.GetColumnInFactorSheet(2, False)})
            clsTempOp.SetOperation("+")
            For j As Integer = 0 To ucrGridWeights.grdFactorData.CurrentWorksheet.RowCount - 1
                clsTempFactorOp = New ROperator
                clsTempFactorOp.SetOperation("*")
                clsTempFactorOp.AddParameter("factor_level" & j, "(" & ucrReceiverRedFlag.GetVariableNames(False) & "==" & Chr(39) & ucrGridWeights.grdFactorData.CurrentWorksheet(j, 0) & Chr(39) & ")", iPosition:=1)
                clsTempFactorOp.AddParameter("level_weight" & j, ucrGridWeights.grdFactorData.CurrentWorksheet(j, 2), iPosition:=1)
                clsTempOp.AddParameter("factor_comp" & j, clsROperatorParameter:=clsTempFactorOp, iPosition:=j)
            Next
        Else
            lviCondition = New ListViewItem
            'TODO Give error here
        End If
        clsCalculation.AddParameter("comp" & i, clsROperatorParameter:=clsTempOp.Clone(), iPosition:=i)
        lstIndexComponents.Items.Add(lviCondition)

        'If clsFilterView.clsParameters.Count = 0 Then
        '    clsFilterView.AddParameter(iPosition:=0, clsROperatorParameter:=(clsCurrentConditionView))
        'Else
        '    clsFilterView.AddParameter(strParameterName:="Condition" & clsFilterView.clsParameters.Count - 1, clsROperatorParameter:=(clsCurrentConditionView))
        'End If
        lstIndexComponents.Columns(0).Width = -2
        lstIndexComponents.Columns(1).Width = -2
        'ucrFilterPreview.SetName(clsFilterView.ToScript())
        ucrReceiverRedFlag.Clear()
        'RaiseEvent FilterChanged()
        'CheckAddEnabled()

        strList = "list("
        For Each lviTemp As ListViewItem In lstIndexComponents.Items
            If lviTemp.Index <> 0 Then
                strList = strList & ", "
            End If
            strList = strList & ucrSelectorCRI.ucrAvailableDataFrames.cboAvailableDataFrames.Text & " = " & Chr(34) & lviTemp.Text & Chr(34)
        Next
        strList = strList & ")"
        clsDefineFunction.AddParameter("calculated_from", strList)
        strExpression = Chr(34) & "(" & clsCalculation.ToScript() & ")" & "/" & lstIndexComponents.Items.Count & Chr(34)
        clsDefineFunction.AddParameter("function_exp", strExpression)
        ucrInputCRIPreview.SetName(strExpression)
        TestOKEnabled()
        i = i + 1
    End Sub

    ' This is currently empty, but will be coded in the future
    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click

    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        '        Dim iIndex As Integer

        '        For Each lviTemp As ListViewItem In lstRedFlags.SelectedItems
        '            iIndex = lstRedFlags.Items.IndexOf(lviTemp)
        '            lstRedFlags.Items.Remove(lviTemp)
        '            lstFlagList.RemoveAt(iIndex)
        '        Next
    End Sub

    Private Sub lstRedFlags_SelectedIndexChanged(sender As Object, e As EventArgs)
        EnableDeleteButton()
    End Sub

    Private Sub EnableDeleteButton()
        If lstIndexComponents.SelectedItems.Count > 0 Then
            cmdDelete.Enabled = True
        Else
            cmdDelete.Enabled = False
        End If
    End Sub

    Private Sub ucrReceiverOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRedFlag.ControlValueChanged
        DisplayRedFlag()
        EnableAddButton()
    End Sub

    Private Sub ucrSelectorCRI_DataFrameChanged() Handles ucrSelectorCRI.DataFrameChanged
        lstIndexComponents.Items.Clear()
        clsCalculation.ClearParameters()
        clsDefineFunction.RemoveParameterByName("function_expression")
        clsDefineFunction.RemoveParameterByName("calculated_from")
        i = 0
        ucrInputCRIPreview.SetName("")
    End Sub

    Private Sub ucrGridWeights_GridContentChanged() Handles ucrGridWeights.GridContentChanged
        EnableAddButton()
    End Sub

    Private Sub ucrSaveCRI_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveCRI.ControlValueChanged
        clsDefineFunction.AddParameter("result_name", Chr(34) & ucrSaveCRI.GetText() & Chr(34))
        clsDefineFunction.SetAssignTo(ucrSaveCRI.ucrInputTextSave.GetText)
    End Sub

    Private Sub ucrSaveCRI_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveCRI.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class