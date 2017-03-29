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
Public Class dlgLabels
    Public bFirstLoad As Boolean = True
    Private Sub dlgLabels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverLabels.IsEmpty() AndAlso ucrFactorLabels.IsColumnComplete(0) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_factor_levels")
        ucrBase.iHelpTopicID = 35
        ucrReceiverLabels.Selector = ucrSelectorForLabels
        ucrReceiverLabels.SetMeAsReceiver()

        ucrReceiverLabels.SetIncludedDataTypes({"factor"})
        ucrFactorLabels.SetReceiver(ucrReceiverLabels)
        ucrFactorLabels.SetAsViewerOnly()
        ucrFactorLabels.AddEditableColumns({"Levels"})
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForLabels.Reset()
        ucrSelectorForLabels.Focus()
        SetNewLevels()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrFactorLabels_GridContentChanged() Handles ucrFactorLabels.GridContentChanged
        SetNewLevels()
    End Sub

    Private Sub SetNewLevels()
        If ucrFactorLabels.IsColumnComplete(0) Then
            ucrBase.clsRsyntax.AddParameter("new_levels", ucrFactorLabels.GetColumnInFactorSheet(iColumn:=0))
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_levels")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverLabels_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverLabels.SelectionChanged
        If Not ucrReceiverLabels.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_name", ucrReceiverLabels.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorForLabels_DataFrameChanged() Handles ucrSelectorForLabels.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForLabels.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub

    Private Sub cmdAddLevel_Click(sender As Object, e As EventArgs) Handles cmdAddLevel.Click
        ucrFactorLabels.AddLevel()
        TestOKEnabled()
    End Sub

    Private Sub ucrFactorLabels_GridVisibleChanged() Handles ucrFactorLabels.GridVisibleChanged
        cmdAddLevel.Enabled = ucrFactorLabels.grdFactorData.Visible
        TestOKEnabled()
    End Sub
End Class