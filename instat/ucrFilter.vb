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

Public Class ucrFilter
    Public bFirstLoad As Boolean = True
    Private clsFilterFunction As New ROperator

    Private Sub ucrFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrFilterPreview.Enabled = False
        ucrFilterVariable.Selector = ucrSelectorForFitler
        ucrSecondFilterVariable.Selector = ucrSelectorForFitler
        ucrOperation.AddItems({"=", "<", "<=", ">", ">=", "!="})
        ucrFactorLevels.SetAsMultipleSelector()
        ucrFactorLevels.SetReceiver(ucrFilterVariable)
        lstFilters.Columns.Add("Variable")
        lstFilters.Columns.Add("Condition")
    End Sub

    Private Sub SetDefaults()
        chkAsVariable.Checked = False
        ucrOperation.SetName("=")
        VariableTypeProperties()
    End Sub

    Private Sub ucrFilterVariable_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFilterVariable.SelectionChanged
        VariableTypeProperties()
    End Sub

    Private Sub VariableTypeProperties()
        Dim bIsFactor As Boolean
        If ucrFilterVariable.IsEmpty() Then
            ucrSecondValue.Visible = False
            lblSelectLevels.Visible = False
            ucrFactorLevels.Visible = False
            cmdToggleSelectAll.Visible = False
        Else
            bIsFactor = ucrFilterVariable.strCurrDataType = "factor"
            lblSelectLevels.Visible = bIsFactor
            ucrFactorLevels.Visible = bIsFactor
            cmdToggleSelectAll.Visible = bIsFactor

            chkAsVariable.Visible = Not bIsFactor
            ucrSecondFilterVariable.Visible = Not bIsFactor
            ucrSecondValue.Visible = Not bIsFactor
            ucrOperation.Visible = Not bIsFactor
        End If
        SecondValueOptions()
        CheckAddEnabled()
    End Sub

    Private Sub SecondValueOptions()
        If ucrFilterVariable.strCurrDataType <> "factor" Then
            If chkAsVariable.Checked Then
                ucrSecondFilterVariable.Visible = True
                ucrSecondValue.Visible = False
                ucrSecondFilterVariable.SetMeAsReceiver()
            Else
                ucrSecondFilterVariable.Visible = False
                ucrSecondValue.Visible = True
                ucrFilterVariable.SetMeAsReceiver()
            End If
        Else
            chkAsVariable.Visible = False
            ucrSecondFilterVariable.Visible = False
            ucrSecondValue.Visible = False
            ucrOperation.Visible = False
        End If
        CheckAddEnabled()
    End Sub

    Private Sub chkAsVariable_CheckedChanged(sender As Object, e As EventArgs) Handles chkAsVariable.CheckedChanged
        SecondValueOptions()
    End Sub

    Private Sub CheckAddEnabled()
        If Not ucrFilterVariable.IsEmpty() Then
            If ucrFilterVariable.strCurrDataType = "factor" AndAlso ucrFactorLevels.GetSelectedLevels() <> "" Then
                cmdAddFilter.Enabled = True
            ElseIf Not ucrOperation.IsEmpty AndAlso ((Not chkAsVariable.Checked AndAlso Not ucrSecondValue.IsEmpty) OrElse (chkAsVariable.Checked AndAlso Not ucrSecondFilterVariable.IsEmpty)) Then
                cmdAddFilter.Enabled = True
            Else
                cmdAddFilter.Enabled = False
            End If
        Else
            cmdAddFilter.Enabled = False
        End If
    End Sub

    Private Sub cmdAddFilter_Click(sender As Object, e As EventArgs) Handles cmdAddFilter.Click
        Dim clsCurrentCondition As New ROperator
        Dim lviCondition As ListViewItem

        clsCurrentCondition.SetParameter(True, ucrFilterVariable.GetVariableNames())
        If ucrFilterVariable.strCurrDataType = "factor" Then
            clsCurrentCondition.SetOperation("%in%")
            clsCurrentCondition.SetParameter(False, ucrFactorLevels.GetSelectedLevels())
        Else
            clsCurrentCondition.SetOperation(ucrOperation.GetText())
            If chkAsVariable.Checked Then
                clsCurrentCondition.SetParameter(False, ucrSecondFilterVariable.GetVariableNames())
            Else
                clsCurrentCondition.SetParameter(False, ucrSecondValue.GetText())
            End If
        End If
        lviCondition = New ListViewItem({ucrFilterVariable.GetVariableNames(), clsCurrentCondition.strOperation & " " & clsCurrentCondition.clsRightParameter.strArgumentValue})
        lstFilters.Items.Add(lviCondition)
        ucrFilterVariable.Clear()
        CheckAddEnabled()
    End Sub

    Private Sub cmdToggleSelectAll_Click(sender As Object, e As EventArgs) Handles cmdToggleSelectAll.Click
        If cmdToggleSelectAll.FlatStyle = FlatStyle.Popup Then
            ucrFactorLevels.SetSelectionAllLevels(True)
            cmdToggleSelectAll.Text = "Deselect All"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Flat
        Else
            ucrFactorLevels.SetSelectionAllLevels(False)
            cmdToggleSelectAll.Text = "Select All"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Popup
        End If
        CheckAddEnabled()
    End Sub
End Class
