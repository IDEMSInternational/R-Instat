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
    Public bFirstLoad As Boolean
    Public clsFilterView As ROperator
    Public clsFilterFunction As RFunction
    Private clsConditionsList As RFunction
    Public bFilterDefined As Boolean
    Public Event FilterChanged()

    Public Sub New()
        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        bFilterDefined = False
        clsFilterView = New ROperator
        clsFilterView.strOperation = "&&"
        clsFilterFunction = New RFunction
        clsFilterFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_filter")
        clsConditionsList = New RFunction
        clsConditionsList.SetRCommand("list")
        clsFilterFunction.AddParameter("filter", clsRFunctionParameter:=clsConditionsList)
    End Sub

    Private Sub ucrFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            SetDefaults()
            bFirstLoad = False
        End If
        ClearConditions()
    End Sub

    Private Sub InitialiseControl()
        ucrFilterPreview.txtInput.ReadOnly = True
        ucrFilterByReceiver.Selector = ucrSelectorForFitler
        ucrFilterOperation.SetItems({"==", "<", "<=", ">", ">=", "!="})
        ucrFactorLevels.SetAsMultipleSelector()
        ucrFactorLevels.SetReceiver(ucrFilterByReceiver)
        clsFilterView.bForceIncludeOperation = False
        lstFilters.Columns.Add("Variable")
        lstFilters.Columns.Add("Condition")
        ucrInputFilterName.SetItemsTypeAsFilters()
        ucrInputFilterName.SetDataFrameSelector(ucrSelectorForFitler.ucrAvailableDataFrames)
        ucrInputFilterName.SetPrefix("Filter")
        ucrInputFilterName.SetDefaultTypeAsFilter()
    End Sub

    Private Sub SetDefaults()
        ucrFilterOperation.SetName("==")
        ucrFilterByReceiver.SetMeAsReceiver()
        VariableTypeProperties()
    End Sub

    Private Sub ucrFilterVariable_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFilterByReceiver.SelectionChanged
        VariableTypeProperties()
    End Sub

    Private Sub VariableTypeProperties()
        Dim bIsFactor As Boolean
        If ucrFilterByReceiver.IsEmpty() Then
            ucrValueForFilter.Visible = False
            lblSelectLevels.Visible = False
            ucrFactorLevels.Visible = False
            cmdToggleSelectAll.Visible = False
            ucrFilterOperation.Visible = False
        Else
            bIsFactor = ucrFilterByReceiver.strCurrDataType = "factor"
            lblSelectLevels.Visible = bIsFactor
            ucrFactorLevels.Visible = bIsFactor
            cmdToggleSelectAll.Visible = bIsFactor
            ucrValueForFilter.Visible = Not bIsFactor
            ucrFilterOperation.Visible = Not bIsFactor
        End If
        SetToggleButtonSettings()
        CheckAddEnabled()
    End Sub

    Private Sub CheckAddEnabled()
        If Not ucrFilterByReceiver.IsEmpty() Then
            If ucrFilterByReceiver.strCurrDataType = "factor" AndAlso ucrFactorLevels.GetSelectedLevels() <> "" Then
                cmdAddCondition.Enabled = True
            ElseIf (Not ucrFilterOperation.IsEmpty) AndAlso (Not ucrValueForFilter.IsEmpty) Then
                cmdAddCondition.Enabled = True
            Else
                cmdAddCondition.Enabled = False
            End If
        Else
            cmdAddCondition.Enabled = False
        End If
    End Sub

    Private Sub cmdAddFilter_Click(sender As Object, e As EventArgs) Handles cmdAddCondition.Click
        Dim clsCurrentConditionView As New ROperator
        Dim clsCurrentConditionList As New RFunction
        Dim lviCondition As ListViewItem
        Dim strCondition As String

        clsCurrentConditionList.SetRCommand("list")
        clsCurrentConditionView.SetParameter(True, strValue:=ucrFilterByReceiver.GetVariableNames())
        clsCurrentConditionList.AddParameter("column", ucrFilterByReceiver.GetVariableNames())
        If ucrFilterByReceiver.strCurrDataType = "factor" Then
            clsCurrentConditionView.SetOperation("%in%")
            clsCurrentConditionList.AddParameter("operation", Chr(34) & "%in%" & Chr(34))
            strCondition = ucrFactorLevels.GetSelectedLevels()
        Else
            clsCurrentConditionView.SetOperation(ucrFilterOperation.GetText())
            clsCurrentConditionList.AddParameter("operation", Chr(34) & ucrFilterOperation.GetText() & Chr(34))
            If ucrFilterByReceiver.strCurrDataType = "character" Then
                strCondition = Chr(34) & ucrValueForFilter.GetText() & Chr(34)
            Else
                strCondition = ucrValueForFilter.GetText()
            End If
        End If
        clsCurrentConditionView.SetParameter(False, strValue:=strCondition)
        clsCurrentConditionList.AddParameter("value", strCondition)
        clsConditionsList.AddParameter("C" & clsConditionsList.clsParameters.Count, clsRFunctionParameter:=(clsCurrentConditionList))
        lviCondition = New ListViewItem({ucrFilterByReceiver.GetVariableNames(), clsCurrentConditionView.strOperation & " " & strCondition})
        lstFilters.Items.Add(lviCondition)
        If clsFilterView.clsLeftOperator Is Nothing Then
            clsFilterView.SetParameter(True, clsOp:=(clsCurrentConditionView))
        Else
            clsFilterView.SetParameter(False, strParameterName:="Condition" & clsFilterView.clsAdditionalParameters.Count, clsOp:=(clsCurrentConditionView))
        End If
        lstFilters.Columns(0).Width = -2
        lstFilters.Columns(1).Width = -2
        ucrFilterPreview.SetName(clsFilterView.ToScript())
        ucrFilterByReceiver.Clear()
        RaiseEvent FilterChanged()
        CheckAddEnabled()
    End Sub

    Private Sub cmdToggleSelectAll_Click(sender As Object, e As EventArgs) Handles cmdToggleSelectAll.Click
        ucrFactorLevels.SetSelectionAllLevels(Not ucrFactorLevels.IsAllSelected())
    End Sub

    Private Sub SetToggleButtonSettings()
        If ucrFactorLevels.IsAllSelected() Then
            cmdToggleSelectAll.Text = "Deselect All"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Flat
        Else
            cmdToggleSelectAll.Text = "Select All"
            cmdToggleSelectAll.FlatStyle = FlatStyle.Popup
        End If
    End Sub

    Private Sub ucrFilterOperation_NameChanged() Handles ucrFilterOperation.NameChanged
        CheckAddEnabled()
    End Sub

    Private Sub ucrValueForFilter_NameChanged() Handles ucrValueForFilter.NameChanged
        CheckAddEnabled()
    End Sub

    Private Sub ucrFactorLevels_SelectedLevelChanged() Handles ucrFactorLevels.SelectedLevelChanged
        SetToggleButtonSettings()
        CheckAddEnabled()
    End Sub

    Private Sub ucrSelectorForFitler_DataFrameChanged() Handles ucrSelectorForFitler.DataFrameChanged
        ClearConditions()
        clsFilterFunction.AddParameter("data_name", Chr(34) & ucrSelectorForFitler.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub cmdClearConditions_Click(sender As Object, e As EventArgs) Handles cmdClearConditions.Click
        ClearConditions()
    End Sub

    Private Sub ClearConditions()
        clsFilterView.RemoveAllParameters()
        clsConditionsList.clsParameters.Clear()
        lstFilters.Items.Clear()
        ucrFilterPreview.SetName("")
        RaiseEvent FilterChanged()
    End Sub

    Private Sub ucrFilter_FilterChanged() Handles Me.FilterChanged
        bFilterDefined = lstFilters.Items.Count > 0
    End Sub

    Private Sub ucrInputFilterName_NameChanged() Handles ucrInputFilterName.NameChanged
        If Not ucrInputFilterName.IsEmpty() Then
            clsFilterFunction.AddParameter("filter_name", Chr(34) & ucrInputFilterName.GetText() & Chr(34))
        Else
            clsFilterFunction.RemoveParameterByName("filter_name")
        End If
    End Sub
End Class
