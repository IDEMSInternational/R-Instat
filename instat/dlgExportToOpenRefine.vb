'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.
'
Imports instat.Translations
Public Class dlgExportToOpenRefine
    Public bFirstLoad As Boolean = True

    Private Sub dlgExportToOpenRefine_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else

        End If
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        chkRefineBrowser.Checked = False
        chkCSV.Checked = False
        ucrOpenRefineDataFrame.Reset()
        ucrInputDatasetName.Reset()
        ucrInputDatasetName.SetName("TheCurrentDataSetName _ cleanup")
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrInputDatasetName.IsEmpty = True Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub chkOpenRefineBrowser_CheckedChanged(sender As Object, e As EventArgs) Handles chkCSV.CheckedChanged, chkRefineBrowser.CheckedChanged
        RefineOrConvertToCSV()
    End Sub

    Private Sub ucrOpenRefineDataFrame_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrOpenRefineDataFrame.DataFrameChanged
        RefineOrConvertToCSV()
    End Sub

    Private Sub ucrInputDatasetName_ContentsChanged() Handles ucrInputDatasetName.ContentsChanged
        RefineOrConvertToCSV()
        TestOKEnabled()
    End Sub

    Private Sub RefineOrConvertToCSV()
        If chkCSV.Checked Then
            ucrBase.clsRsyntax.SetFunction("write.csv")
            ucrBase.clsRsyntax.AddParameter("x", ucrOpenRefineDataFrame.cboAvailableDataFrames.SelectedItem)
            ucrBase.clsRsyntax.RemoveParameter("file")
            ucrBase.clsRsyntax.AddParameter("file", Chr(34) & ucrInputDatasetName.GetText & ".csv" & Chr(34))
            ucrBase.clsRsyntax.AddParameter("row.names", "FALSE")
            ucrBase.clsRsyntax.RemoveParameter("open.browser")
            ucrBase.clsRsyntax.RemoveParameter("project.name")
        ElseIf chkRefineBrowser.Checked Then
            ucrBase.clsRsyntax.SetFunction("rrefine::refine_upload")
            ucrBase.clsRsyntax.AddParameter("open.browser", "TRUE")
            ucrBase.clsRsyntax.RemoveParameter("x")
            ucrBase.clsRsyntax.RemoveParameter("row.names")
            ucrBase.clsRsyntax.AddParameter("project.name", Chr(34) & ucrInputDatasetName.GetText() & Chr(34))
            ucrBase.clsRsyntax.RemoveParameter("file")
            ucrBase.clsRsyntax.AddParameter("file", Chr(34) & ucrOpenRefineDataFrame.cboAvailableDataFrames.SelectedItem & ".csv" & Chr(34))
        End If
    End Sub
End Class