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
Imports RDotNet
Public Class dlgRestrict
    Public bFirstLoad As Boolean
    Private clsRemoveFilter As RFunction
    Private clsAddFilter As RFunction
    Private clsFilterView As RFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        clsRemoveFilter = New RFunction
        clsRemoveFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
        clsAddFilter = New RFunction
        clsAddFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_current_filter")
        clsFilterView = New RFunction
        clsFilterView.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$filter_string")
    End Sub

    Private Sub dlgRestrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrInputFilterPreview.txtInput.ReadOnly = True
        ucrSelectorFilter.SetItemType("filter")
        ucrReceiverFilter.Selector = ucrSelectorFilter
        ucrReceiverFilter.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        ucrReceiverFilter.SetMeAsReceiver()
    End Sub

    Private Sub cmdNewFilter_Click(sender As Object, e As EventArgs) Handles cmdDefineNewFilter.Click
        sdgCreateFilter.ShowDialog()
        If sdgCreateFilter.bFilterDefined Then
            frmMain.clsRLink.RunScript(sdgCreateFilter.clsCurrentFilter.ToScript(), strComment:="Create Filter subdialog: Created new filter")
        End If
        ucrSelectorFilter.LoadList()
    End Sub

    Private Sub ucrSelectorFilter_DataFrameChanged() Handles ucrSelectorFilter.DataFrameChanged
        clsAddFilter.AddParameter("data_name", Chr(34) & ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
        clsRemoveFilter.AddParameter("data_name", Chr(34) & ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
        clsFilterView.AddParameter("data_name", Chr(34) & ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub ucrReceiverFilter_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFilter.SelectionChanged
        If ucrReceiverFilter.IsEmpty Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveFilter)
            'TODO translate this
            ucrInputFilterPreview.SetName("Current Filter will be removed.")
        Else
            clsAddFilter.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
            clsFilterView.AddParameter("filter_name", ucrReceiverFilter.GetVariableNames())
            ucrBase.clsRsyntax.SetBaseRFunction(clsAddFilter)
            ucrInputFilterPreview.SetName(frmMain.clsRLink.RunInternalScriptGetValue(clsFilterView.ToScript()).AsCharacter(0))
        End If
        ucrBase.OKEnabled(True)
    End Sub
End Class