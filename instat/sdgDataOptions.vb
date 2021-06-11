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

Public Class sdgDataOptions
    Public bFirstLoad As Boolean
    Private clsFilterPreview As RFunction
    Private clsRemoveCurrentFilter As RFunction
    Private strCurrentDataFrame As String

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        clsFilterPreview = New RFunction
        clsRemoveCurrentFilter = New RFunction
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
        clsFilterPreview.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$filter_string")
        clsRemoveCurrentFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
        ucrReceiverFilter.Selector = ucrSelectorFilters
        ucrReceiverFilter.SetItemType("filter")
        ucrReceiverFilter.SetMeAsReceiver()
        ucrInputFilterPreview.txtInput.ReadOnly = True
    End Sub

    Public Sub SetDefaults()
        ucrSelectorFilters.Reset()
        'chkShowHiddenColumns.Checked = False
        rdoAllDialogs.Checked = True
    End Sub

    Public Property ShowHiddenColumns As Boolean
        Get
            Return chkShowHiddenColumns.Checked
        End Get
        Set(bShowHidden As Boolean)
            chkShowHiddenColumns.Checked = bShowHidden
        End Set
    End Property

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
        If Not ucrReceiverFilter.IsEmpty() Then
            If rdoAllDialogs.Checked Then
                clsSetCurrentFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_current_filter")
                clsSetCurrentFilter.AddParameter("data_name", Chr(34) & ucrSelectorFilters.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
                clsSetCurrentFilter.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
                frmMain.clsRLink.RunScript(clsSetCurrentFilter.ToScript(), strComment:="Data Options subdialog: Set the current filter")
            Else
                'TODO Set Local Filter
            End If
        End If
    End Sub

    Private Sub ucrReceiverFilter_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFilter.SelectionChanged
        If Not ucrReceiverFilter.IsEmpty() Then
            clsFilterPreview.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
            ucrInputFilterPreview.SetName(frmMain.clsRLink.RunInternalScriptGetValue(clsFilterPreview.ToScript()).AsCharacter(0))
        Else
            ucrInputFilterPreview.SetName("")
        End If
    End Sub

    Private Sub ucrSelectorFilters_DataFrameChanged() Handles ucrSelectorFilters.DataFrameChanged
        clsFilterPreview.AddParameter("data_name", Chr(34) & ucrSelectorFilters.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsRemoveCurrentFilter.AddParameter("data_name", Chr(34) & ucrSelectorFilters.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Public Sub SetCurrentDataFrame(strNewDataFrame As String, Optional bEnabled As Boolean = False)
        strCurrentDataFrame = strNewDataFrame
        ucrSelectorFilters.SetDataframe(strCurrentDataFrame, bEnabled)
    End Sub

    Private Sub cmdRemoveCurrentFilter_Click(sender As Object, e As EventArgs) Handles cmdRemoveCurrentFilter.Click
        frmMain.clsRLink.RunScript(clsRemoveCurrentFilter.ToScript, strComment:="Data Options subdialog: Remove current filter")
        If Not ucrReceiverFilter.IsEmpty Then
            ucrReceiverFilter.Clear()
        End If
    End Sub
End Class