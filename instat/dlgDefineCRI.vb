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
    Private clsCalculationComponents As New ROperator
    Private clsCalculationScaled As New ROperator
    Private clsDefineFunction As New RFunction
    Private i As Integer = 0
    Private strWeightColumn As String = "Weight"

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
        ucrReceiverRedFlag.AddIncludedMetadataProperty("Is_CRI_Component", {"TRUE"})

        'ucrChk
        ucrChkScaleNumeric.SetText("Scale Numeric Variables")
        ucrChkScaleNumeric.Enabled = False

        'grd
        ucrGridWeights.SetReceiver(ucrReceiverRedFlag)
        ucrGridWeights.SetAsViewerOnly()
        ucrGridWeights.bIncludeLevels = False
        ucrGridWeights.strExtraColumn = strWeightColumn
        ucrGridWeights.AddEditableColumns({strWeightColumn})

        'lstbox
        lstIndexComponents.Columns.Add("Component")
        lstIndexComponents.Columns.Add("Weight(s)")

        ucrInputCRIPreview.txtInput.Multiline = True

        'save
        ucrSaveCRI.SetDataFrameSelector(ucrSelectorCRI.ucrAvailableDataFrames)
        ucrSaveCRI.SetLabelText("New Column Name:")
        ucrSaveCRI.SetIsTextBox()
        ucrSaveCRI.SetPrefix("CRI")
        ucrSaveCRI.SetSaveTypeAsColumn()
    End Sub

    Private Sub SetDefaults()
        clsCalculationComponents = New ROperator
        clsDefineFunction = New RFunction
        clsCalculationScaled = New ROperator

        'Reset 
        ucrSelectorCRI.Reset()

        lstIndexComponents.Items.Clear()
        lstIndexComponents.Columns(0).Width = 95
        lstIndexComponents.Columns(1).Width = 70

        ucrInputCRIPreview.SetName("")
        ucrNudWeights.Value = 1

        clsCalculationComponents.SetOperation("+")

        clsCalculationScaled.SetOperation("/")
        clsCalculationScaled.AddParameter("left", clsROperatorParameter:=clsCalculationComponents, iPosition:=0)
        clsCalculationScaled.bToScriptAsRString = True

        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsDefineFunction)
        ucrBase.clsRsyntax.AddParameter("display", "FALSE")

        clsDefineFunction.SetRCommand("instat_calculation$new")
        clsDefineFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsDefineFunction.AddParameter("save", 2)
        clsDefineFunction.AddParameter("result_name", Chr(34) & ucrSaveCRI.GetText() & Chr(34))
        clsDefineFunction.AddParameter("function_exp", clsROperatorParameter:=clsCalculationScaled)

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
        If lstIndexComponents.Items.Count > 0 AndAlso ucrSaveCRI.IsComplete Then
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
                If ucrGridWeights.IsColumnComplete(strWeightColumn) Then
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
    End Sub

    Private Sub cmdAddComponent_Click(sender As Object, e As EventArgs) Handles cmdAddComponent.Click
        Dim lviCondition As ListViewItem = Nothing
        Dim clsTempOp As ROperator
        Dim clsTempFactorOp As ROperator
        Dim strList As String = ""
        Dim iWeightColumn As Integer = -1
        Dim bFound As Boolean = False

        clsTempOp = New ROperator
        iWeightColumn = ucrGridWeights.GetColumnIndex(strWeightColumn)
        For j = 0 To lstIndexComponents.Items.Count - 1
            If lstIndexComponents.Items(j).Text = ucrReceiverRedFlag.GetVariableNames(False) Then
                lviCondition = lstIndexComponents.Items(j)
                bFound = True
                Exit For
            End If
        Next
        If Not bFound Then
            lviCondition = New ListViewItem({ucrReceiverRedFlag.GetVariableNames(False), ""})
        End If
        If ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "integer" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" Then
            lviCondition.SubItems(1).Text = ucrNudWeights.Value
            clsTempOp.SetOperation("*")
            clsTempOp.AddParameter("column", ucrReceiverRedFlag.GetVariableNames(False), iPosition:=0)
            clsTempOp.AddParameter("weight", ucrNudWeights.Value, iPosition:=1)
        ElseIf ucrReceiverRedFlag.strCurrDataType = "factor" AndAlso iWeightColumn <> -1 Then
            lviCondition.SubItems(1).Text = ucrGridWeights.GetColumnInFactorSheet(strWeightColumn, False)
            clsTempOp.SetOperation("+")
            For j As Integer = 0 To ucrGridWeights.grdFactorData.CurrentWorksheet.RowCount - 1
                clsTempFactorOp = New ROperator
                clsTempFactorOp.SetOperation("*")
                clsTempFactorOp.AddParameter("factor_level" & j, "(" & ucrReceiverRedFlag.GetVariableNames(False) & "==" & Chr(39) & ucrGridWeights.grdFactorData.CurrentWorksheet(j, 1) & Chr(39) & ")", iPosition:=1)
                clsTempFactorOp.AddParameter("level_weight" & j, ucrGridWeights.grdFactorData.CurrentWorksheet(j, iWeightColumn), iPosition:=1)
                clsTempOp.AddParameter("factor_comp" & j, clsROperatorParameter:=clsTempFactorOp, iPosition:=j)
            Next
        Else
            lviCondition = New ListViewItem
            'TODO Give error here
        End If
        If Not bFound Then
            lviCondition.Tag = i
            lstIndexComponents.Items.Add(lviCondition)
        End If
        clsCalculationComponents.AddParameter(lviCondition.Tag, clsROperatorParameter:=clsTempOp.Clone(), iPosition:=lviCondition.Tag)
        'If clsFilterView.clsParameters.Count = 0 Then
        '    clsFilterView.AddParameter(iPosition:=0, clsROperatorParameter:=(clsCurrentConditionView))
        'Else
        '    clsFilterView.AddParameter(strParameterName:="Condition" & clsFilterView.clsParameters.Count - 1, clsROperatorParameter:=(clsCurrentConditionView))
        'End If
        'lstIndexComponents.Columns(0).Width = -2
        'lstIndexComponents.Columns(1).Width = -2
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
        SetCalculationScale()
        UpdatePreview()
        TestOKEnabled()
        i = i + 1
    End Sub

    Private Sub UpdatePreview()
        If lstIndexComponents.Items.Count > 0 Then
            ucrInputCRIPreview.SetName(clsCalculationScaled.ToScript().Trim(Chr(34)))
        Else
            ucrInputCRIPreview.SetName("")
        End If
    End Sub

    Private Sub SetCalculationScale()
        clsCalculationScaled.AddParameter("right", lstIndexComponents.Items.Count, iPosition:=1)
    End Sub

    Private Sub cmdEdit_Click(sender As Object, e As EventArgs) Handles cmdEdit.Click
        EditComponent()
    End Sub

    Private Sub EditComponent()
        Dim lviCondition As ListViewItem
        Dim strCol As String
        Dim iWeightColumn As Integer
        Dim strIndexValues() As String

        If lstIndexComponents.SelectedItems.Count = 1 Then
            lviCondition = lstIndexComponents.SelectedItems(0)
            strCol = lviCondition.Text
            ucrReceiverRedFlag.Add(strCol, ucrSelectorCRI.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            iWeightColumn = ucrGridWeights.GetColumnIndex(strWeightColumn)
            If ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "integer" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" Then
                ucrNudWeights.Value = lviCondition.SubItems(1).Text
            ElseIf ucrReceiverRedFlag.strCurrDataType = "factor" AndAlso iWeightColumn <> -1 Then
                strIndexValues = ExtractItemsFromRList(lviCondition.SubItems(1).Text)
                ucrGridWeights.SetColumn(strIndexValues, iWeightColumn, bSilent:=False)
            Else
                MsgBox("Cannot detect column or column data in the data. Editing of this component not possible", MsgBoxStyle.Exclamation, "Cannot edit component")
            End If
        End If
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        For Each lviTemp As ListViewItem In lstIndexComponents.SelectedItems
            lviTemp.Remove()
            clsCalculationComponents.RemoveParameterByName(lviTemp.Tag)
        Next
        SetCalculationScale()
        UpdatePreview()
        TestOKEnabled()
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
        clsCalculationComponents.ClearParameters()
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

    Private Sub lstIndexComponents_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstIndexComponents.SelectedIndexChanged
        cmdEdit.Enabled = (lstIndexComponents.SelectedItems.Count > 0)
        cmdDelete.Enabled = (lstIndexComponents.SelectedItems.Count > 0)
    End Sub

    Private Sub lstIndexComponents_DoubleClick(sender As Object, e As EventArgs) Handles lstIndexComponents.DoubleClick
        EditComponent()
    End Sub
End Class