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
    Private clsDefaultFunction As New RFunction

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
        '  ucrBase.iHelpTopicID =

        'Selector
        '        ucrSelectorCRI.SetParameter(New RParameter("", 0))
        ucrSelectorCRI.SetParameterIsString()

        'Receivers
        '        ucrReceiverRedFlag.SetParameter(New RParameter("", 1))
        ucrReceiverRedFlag.SetParameterIsString()
        ucrReceiverRedFlag.Selector = ucrSelectorCRI
        ucrReceiverRedFlag.SetMeAsReceiver()

        'ucrChk
        ucrChkScaleNumeric.SetText("Scale Numeric")
        ucrChkScaleNumeric.SetParameter(New RParameter("scale_numeric", 3))
        ucrChkScaleNumeric.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkScaleNumeric.SetRDefault("TRUE")

        'ucrNud
        'ucrNudWeights.SetParameter(New RParameter("", 2))

        'ucrGrid
        'ucrGridWeights.SetParameter()

        'lstbox
        lstRedFlags.Columns.Add("Component")
        lstRedFlags.Columns.Add("Weight(s)")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        'Reset 
        ucrSelectorCRI.Reset()
        lstRedFlags.Items.Clear()

        'clsDefaultFunction.SetRCommand("")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
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
        If Not ucrReceiverRedFlag.IsEmpty() Then
            If (ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" OrElse ucrReceiverRedFlag.strCurrDataType = "integer") Then
                If ucrNudWeights.GetText <> "" Then
                    ucrBase.OKEnabled(True)
                    cmdAddComponent.Enabled = True
                Else
                    ucrBase.OKEnabled(False)
                    cmdAddComponent.Enabled = False
                End If
            Else
                If ucrGridWeights.GetSelectedLevels() <> "" Then
                    ucrBase.OKEnabled(True)
                    cmdAddComponent.Enabled = True
                Else
                    ucrBase.OKEnabled(False)
                    cmdAddComponent.Enabled = False
                End If
            End If
        End If
    End Sub

    Private Sub DisplayRedFlag()
        If Not ucrReceiverRedFlag.IsEmpty Then
            If ucrReceiverRedFlag.strCurrDataType = "numeric" OrElse ucrReceiverRedFlag.strCurrDataType = "integer" OrElse ucrReceiverRedFlag.strCurrDataType = "logical" Then
                ucrNudWeights.Visible = True
                ucrGridWeights.Visible = False
            Else
                ucrNudWeights.Visible = False
                ucrGridWeights.Visible = True
            End If
        Else
            ucrNudWeights.Visible = True
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
        'Dim lviCondition As ListViewItem
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
        'lviCondition = New ListViewItem({ucrFilterByReceiver.GetVariableNames(), clsCurrentConditionView.strOperation & " " & strCondition})
        'lstFilters.Items.Add(lviCondition)
        'If clsFilterView.clsParameters.Count = 0 Then
        '    clsFilterView.AddParameter(iPosition:=0, clsROperatorParameter:=(clsCurrentConditionView))
        'Else
        '    clsFilterView.AddParameter(strParameterName:="Condition" & clsFilterView.clsParameters.Count - 1, clsROperatorParameter:=(clsCurrentConditionView))
        'End If
        'lstFilters.Columns(0).Width = -2
        'lstFilters.Columns(1).Width = -2
        'ucrFilterPreview.SetName(clsFilterView.ToScript())
        'ucrFilterByReceiver.Clear()
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
        If lstRedFlags.SelectedItems.Count > 0 Then
            cmdDelete.Enabled = True
        Else
            cmdDelete.Enabled = False
        End If
    End Sub

    Private Sub ucrReceiverOutput_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRedFlag.ControlValueChanged
        DisplayRedFlag()
    End Sub
End Class