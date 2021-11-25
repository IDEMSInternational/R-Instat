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

Public Class sdgDataOptions
    Public bFirstLoad As Boolean
    Private clsFilterPreview As RFunction
    Private clsRemoveCurrentFilter As RFunction
    Private clsRemoveCurrentColumnSelection As RFunction
    Private strCurrentDataFrame As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        clsFilterPreview = New RFunction
        clsRemoveCurrentFilter = New RFunction
        clsRemoveCurrentColumnSelection = New RFunction
    End Sub

    Private Sub sdgDataOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrSubDialogueBase.iHelpTopicID = 169

        clsFilterPreview.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$filter_string")
        clsRemoveCurrentFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
        clsRemoveCurrentColumnSelection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_column_selection")

        ucrReceiverFilter.Selector = ucrSelectorFilters
        ucrReceiverFilter.SetItemType("filter")
        ucrReceiverFilter.SetMeAsReceiver()
        ucrReceiverFilter.strSelectorHeading = "Filters"

        ucrSelectorFilters.HideShowAddOrDataOptionsButton(bDataOptionsVisible:=False)

        ucrSelectorForSelectColumns.HideShowAddOrDataOptionsButton(bDataOptionsVisible:=False)

        ucrReceiverSelect.Selector = ucrSelectorForSelectColumns
        ucrReceiverSelect.SetMeAsReceiver()
        ucrReceiverSelect.SetItemType("column_selection")
        ucrReceiverSelect.strSelectorHeading = "Column Selections"

        ucrInputFilterPreview.txtInput.ReadOnly = True
    End Sub

    Public Sub SetDefaults()
        ucrSelectorFilters.Reset()
        ucrSelectorForSelectColumns.Reset()
        rdoAllDialogs.Checked = True
        rdoColumnsForAllDialogs.Checked = True
    End Sub

    Private Sub cmdNewFilter_Click(sender As Object, e As EventArgs) Handles cmdDefineNewFilter.Click
        sdgCreateFilter.ucrCreateFilter.SetDefaultDataFrame(strCurrentDataFrame)
        sdgCreateFilter.ShowDialog()
        If sdgCreateFilter.bFilterDefined Then
            frmMain.clsRLink.RunScript(sdgCreateFilter.clsCurrentFilter.ToScript(), strComment:="Create Filter subdialog: Created new filter")
            ucrSelectorFilters.SetDataframe(sdgCreateFilter.ucrCreateFilter.ucrSelectorForFitler.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            If ucrReceiverFilter.GetVariableNames(False) = sdgCreateFilter.ucrCreateFilter.ucrInputFilterName.GetText() Then
                ucrReceiverFilter.Clear()
            End If
            ucrReceiverFilter.Add(sdgCreateFilter.ucrCreateFilter.ucrInputFilterName.GetText())
        End If
        ucrSelectorFilters.LoadList()
    End Sub

    Private Sub ucrSubDialogueBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrSubDialogueBase.ClickReturn
        Dim clsSetCurrentFilter As New RFunction
        Dim clsSetCurrentColumnSelection As New RFunction
        If tbcDataOptions.SelectedTab Is tbRows AndAlso Not ucrReceiverFilter.IsEmpty() Then
            If rdoAllDialogs.Checked Then
                clsSetCurrentFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_current_filter")
                clsSetCurrentFilter.AddParameter("data_name", Chr(34) & ucrSelectorFilters.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
                clsSetCurrentFilter.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
                frmMain.clsRLink.RunScript(clsSetCurrentFilter.ToScript(), strComment:="Data Options subdialog: Set the current filter")
            Else
                'TODO: Set Local Filter
            End If
        ElseIf tbcDataOptions.SelectedTab Is tbColumns AndAlso Not ucrReceiverSelect.IsEmpty Then
            If rdoColumnsForAllDialogs.Checked Then
                clsSetCurrentColumnSelection.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_current_column_selection")
                clsSetCurrentColumnSelection.AddParameter("data_name", Chr(34) & ucrSelectorForSelectColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
                clsSetCurrentColumnSelection.AddParameter("name", ucrReceiverSelect.GetVariableNames())
                frmMain.clsRLink.RunScript(clsSetCurrentColumnSelection.ToScript(), strComment:="Data Options subdialog: Set the current column selection")
            Else
                'TODO: Set Local column selection
            End If
        End If
    End Sub

    Private Sub ucrReceiverFilter_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFilter.SelectionChanged
        If Not ucrReceiverFilter.IsEmpty() Then
            clsFilterPreview.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
            Try
                ucrInputFilterPreview.SetName(frmMain.clsRLink.RunInternalScriptGetValue(clsFilterPreview.ToScript()).AsCharacter(0))
            Catch ex As Exception
                ucrInputFilterPreview.SetName("Preview not available")
            End Try
        Else
            ucrInputFilterPreview.SetName("")
        End If
    End Sub

    Private Sub ucrSelectors_DataFrameChanged() Handles ucrSelectorFilters.DataFrameChanged, ucrSelectorForSelectColumns.DataFrameChanged
        clsFilterPreview.AddParameter("data_name", Chr(34) & ucrSelectorFilters.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsRemoveCurrentFilter.AddParameter("data_name", Chr(34) & ucrSelectorFilters.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsRemoveCurrentColumnSelection.AddParameter("data_name", Chr(34) & ucrSelectorForSelectColumns.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Public Sub SetCurrentDataFrame(strNewDataFrame As String, Optional bEnabled As Boolean = False)
        strCurrentDataFrame = strNewDataFrame
        ucrSelectorFilters.SetDataframe(strCurrentDataFrame, bEnabled)
        ucrSelectorForSelectColumns.SetDataframe(strCurrentDataFrame, bEnabled)
    End Sub

    Private Sub cmdRemoveCurrentFilter_Click(sender As Object, e As EventArgs) Handles cmdRemoveCurrentFilter.Click
        frmMain.clsRLink.RunScript(clsRemoveCurrentFilter.ToScript, strComment:="Data Options subdialog: Remove current filter")
        If Not ucrReceiverFilter.IsEmpty Then
            ucrReceiverFilter.Clear()
        End If
    End Sub

    Private Sub cmdDefineNewSelect_Click(sender As Object, e As EventArgs) Handles cmdDefineNewSelect.Click
        dlgSelectColumns.ShowDialog()
        ucrReceiverSelect.Add(dlgSelectColumns.ucrInputSelectName.GetText)
        ucrSelectorForSelectColumns.LoadList()
    End Sub

    Private Sub cmdRemoveCurrentColumnSelection_Click(sender As Object, e As EventArgs) Handles cmdRemoveCurrentColumnSelection.Click
        frmMain.clsRLink.RunScript(clsRemoveCurrentColumnSelection.ToScript, strComment:="Data Options subdialog: Remove current column selection")
        If Not ucrReceiverSelect.IsEmpty Then
            ucrReceiverSelect.Clear()
        End If
    End Sub
End Class