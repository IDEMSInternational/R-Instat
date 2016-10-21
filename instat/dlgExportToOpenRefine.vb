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
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        chkOpenRefineBrowser.Checked = False
        chkCSV.Checked = False
        ucrOpenRefineDataFrame.Reset()
        ucrInputDatasetName.Reset()
        chkOpenRefineBrowser.ResetText()
        ucrInputDatasetName.SetName("TheCurrentDataSetName _ cleanup")
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("refine_upload")
        'ucrBase.clsRsyntax.SetFunction("write")
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrInputDatasetName.IsEmpty = True Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        TestOKEnabled()
        SetDefaults()
    End Sub

    Private Sub ucrInputDatasetName_TextChanged(sender As Object, e As EventArgs) Handles ucrInputDatasetName.TextChanged
        SetDefaults()
    End Sub

    Private Sub chkOpenRefineBrowser_CheckedChanged(sender As Object, e As EventArgs) Handles  chkCSV.CheckedChanged
        OpenRefineParameters()
    End Sub

    Private Sub ucrOpenRefineDataFrame_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrOpenRefineDataFrame.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & ucrOpenRefineDataFrame.strCurrDataFrame & Chr(34))

    End Sub

    Private Sub ucrInputDatasetName_ContentsChanged() Handles ucrInputDatasetName.ContentsChanged
        ucrBase.clsRsyntax.AddParameter("project.name", Chr(34) & ucrInputDatasetName.GetText() & Chr(34))
    End Sub

    Private Sub OpenRefineParameters()
        If chkCSV.Checked Then
            'ucrBase.clsRsyntax.AddParameter("file")
            'ucrBase.clsRsyntax.AddParameter("x")
        Else

        End If

        If chkOpenRefineBrowser.Checked Then
            ucrBase.clsRsyntax.AddParameter("open.browser", "FALSE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("open.browser")
        End If
    End Sub
End Class