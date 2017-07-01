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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        clsFilterPreview = New RFunction
    End Sub

    Private Sub sdgDataOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
    End Sub

    Private Sub InitialiseDialog()
        clsFilterPreview.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$filter_string")
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

    Private Sub ReopenDialog()
        ucrSelectorFilters.Reset()
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
        sdgCreateFilter.ShowDialog()
        If sdgCreateFilter.bFilterDefined Then
            frmMain.clsRLink.RunScript(sdgCreateFilter.clsCurrentFilter.ToScript(), strComment:="Create Filter subdialog: Created new filter")
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
        End If
    End Sub

    Private Sub ucrSelectorFilters_DataFrameChanged() Handles ucrSelectorFilters.DataFrameChanged
        clsFilterPreview.AddParameter("data_name", Chr(34) & ucrSelectorFilters.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub
End Class