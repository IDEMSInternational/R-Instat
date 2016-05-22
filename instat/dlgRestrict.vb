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
Public Class dlgRestrict
    Public bFirstLoad As Boolean
    Private clsRemoveFilter As RFunction

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        bFirstLoad = True
        clsRemoveFilter = New RFunction
        clsRemoveFilter.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_current_filter")
    End Sub

    Private Sub dlgRestrict_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrFilterPreview.txtInput.ReadOnly = True
    End Sub

    Private Sub SetDefaults()
        rdoApplySelected.Checked = True
    End Sub

    Private Sub TestOKEnabled()
        If rdoApplySelected.Checked Then
            ucrBase.OKEnabled(Not ucrFilterPreview.IsEmpty)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdNewFilter_Click(sender As Object, e As EventArgs) Handles cmdNewFilter.Click
        sdgCreateFilter.ShowDialog()
        rdoApplySelected.Checked = True
        ucrBase.clsRsyntax.SetBaseRFunction((sdgCreateFilter.clsCurrentFilter))
        ucrBase.clsRsyntax.AddParameter("set_as_current_filter", "TRUE")
        ucrFilterPreview.SetName(sdgCreateFilter.ucrCreateFilter.ucrFilterPreview.GetText())
        TestOKEnabled()
    End Sub

    Private Sub grpFilter_CheckedChanged(sender As Object, e As EventArgs) Handles rdoRemoveFilter.CheckedChanged, rdoApplySelected.CheckedChanged
        If rdoApplySelected.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction((sdgCreateFilter.clsCurrentFilter))
            ucrBase.clsRsyntax.AddParameter("set_as_current_filter", "TRUE")
            ucrFilterPreview.SetName(sdgCreateFilter.ucrCreateFilter.ucrFilterPreview.GetText())
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsRemoveFilter)
        End If
    End Sub

    Private Sub ucrSelectorFilter_DataFrameChanged() Handles ucrSelectorFilter.DataFrameChanged
        clsRemoveFilter.AddParameter("data_name", Chr(34) & ucrSelectorFilter.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub
End Class