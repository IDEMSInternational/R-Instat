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
Public Class dlgDefineCRI
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private bResetSubdialog As Boolean = False
    Private clsCalculation As New ROperator
    Private clsDefineFunction As New RFunction

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

    End Sub

    Private Sub InitialiseDialog()
        'helpID
        ucrInputCRIPreview.IsReadOnly = True

        clsDefineFunction.SetRCommand("instat_calculation$new")
        clsDefineFunction.SetAssignTo("Define_CRI")
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$apply_instat_calculation")

        '  ucrBase.iHelpTopicID =

        'Selector

        'Receivers
        ucrReceiverRedFlag.Selector = ucrSelectorCRI
        ucrReceiverRedFlag.SetMeAsReceiver()
        ucrReceiverRedFlag.SetIncludedDataTypes({"numeric", "logical", "factor"})

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
    End Sub

    Private Sub SetDefaults()
        clsCalculation = New ROperator
        'clsDefineFunction = New RFunction

        'Reset 
        ucrSelectorCRI.Reset()
        lstIndexComponents.Items.Clear()
        ucrInputCRIPreview.SetName("")

        clsCalculation.SetOperation("+")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefineFunction)
        ucrBase.clsRsyntax.SetBaseROperator(clsCalculation)
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
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        'if the list box is not empty then OK is enabled
    End Sub

    Private Sub EnableAddButton()
        If Not ucrReceiverRedFlag.IsEmpty() Then
            If (ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" OrElse ucrReceiverRedFlag.strCurrDataType = "integer") Then
                '        If ucrNudWeights.GetText <> "" Then
                ucrInputCRIPreview.SetName(clsCalculation.ToScript) ' will be the overall function
                '            cmdAddComponent.Enabled = True
                '        Else
                '            cmdAddComponent.Enabled = False
                '        End If
                '    Else
                '        If ucrGridWeights.GetSelectedLevels() <> "" Then
                '            cmdAddComponent.Enabled = True
                'ucrInputCRIPreview.SetName(clsCalculation.ToScript) ' will be the overall function

                '        Else
                '            cmdAddComponent.Enabled = False
                '        End If
            End If
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

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRedFlag.ControlContentsChanged, ucrNudWeights.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdAddComponent_Click(sender As Object, e As EventArgs) Handles cmdAddComponent.Click
        'Dim clsCurrentConditionView As New ROperator
        'Dim clsCurrentConditionList As New RFunction
        Dim lviCondition As ListViewItem
        Dim clsTempOp As ROperator
        Dim clsTempFactorOp As ROperator
        Dim i As Integer = 0

        'Dim strCondition As String

        ''clsCurrentConditionList.SetRCommand("list")
        ''clsCurrentConditionView.AddParameter(iPosition:=0, strParameterValue:=ucrFilterByReceiver.GetVariableNames(False))
        ''clsCurrentConditionList.AddParameter("column", ucrFilterByReceiver.GetVariableNames())
        'If ucrReceiverRedFlag.strCurrDataType.Contains("factor") Then
        '    clsCurrentConditionView.SetOperation("%in%")
        '    clsCurrentConditionList.AddParameter("operation", Chr(34) & "%in%" & Chr(34))
        '    strCondition = ucrGridWeights.GetSelectedLevels()
        'Else
        '    clsCurrentConditionView.SetOperation(ucrNudWeights.Value)
        '    clsCurrentConditionList.AddParameter("operation", Chr(34) & ucrNudWeights.Value & Chr(34))
        '    If ucrReceiverRedFlag.strCurrDataType = "?" AndAlso ucrNudWeights.GetText() <> "" Then
        '        strCondition = Chr(34) & ucrNudWeights.GetText() & Chr(34)
        '    Else
        '    End If
        'End If
        'clsCurrentConditionView.AddParameter(strParameterValue:=strCondition.Replace(Chr(34), Chr(39)))
        'clsCurrentConditionList.AddParameter("value", strCondition)
        'clsConditionsList.AddParameter("C" & clsConditionsList.clsParameters.Count, clsRFunctionParameter:=(clsCurrentConditionList))

        clsTempOp = New ROperator
        If ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "integer" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" Then
            lviCondition = New ListViewItem({ucrReceiverRedFlag.GetVariableNames(False), ucrNudWeights.Value})
            clsTempOp.SetOperation("*")
            clsTempOp.AddParameter("column", ucrReceiverRedFlag.GetVariableNames(False), iPosition:=0)
            clsTempOp.AddParameter("weight", ucrNudWeights.Value, iPosition:=1)
        ElseIf ucrReceiverRedFlag.strCurrDataType = "factor" Then
            lviCondition = New ListViewItem({ucrReceiverRedFlag.GetVariableNames(False), ucrGridWeights.GetColumnInFactorSheet(1, False)})
            For j As Integer = 0 To ucrGridWeights.grdFactorData.CurrentWorksheet.RowCount - 1
                clsTempFactorOp = New ROperator
                clsTempFactorOp.SetOperation("*")
                clsTempFactorOp.AddParameter("factor_level" & j, ucrReceiverRedFlag.GetVariableNames(False) & "==" & Chr(39) & ucrGridWeights.grdFactorData.CurrentWorksheet(j, 0) & Chr(39), iPosition:=1)
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
    End Sub

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

    Private Sub OverallCalculation() ' run this at right times
        clsDefineFunction.AddParameter("type", Chr(34) & "calculation" & Chr(34))
        clsDefineFunction.AddParameter("function_exp", clsROperatorParameter:=clsCalculation) ' item in preview box
        clsDefineFunction.AddParameter("result_name", Chr(34) & "Define_CRI" & Chr(34))
        clsDefineFunction.AddParameter("save", 2)

        ucrBase.clsRsyntax.AddParameter("calc", clsRFunctionParameter:=clsDefineFunction)
    End Sub

    Private Sub ucrReceiverOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRedFlag.ControlValueChanged
        DisplayRedFlag()
    End Sub
End Class