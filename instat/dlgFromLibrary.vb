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
Imports System.IO
Imports RDotNet

Public Class dlgFromLibrary
    Dim strLibraryTemp As String = "dfLibrary"
    Dim strPackages As String = "dfPackagesList"
    Dim strLibraryPath As String = frmMain.strStaticPath & "\" & "Library"
    Dim bFirstLoad As Boolean = True

    Private Sub dlgFromLibrary_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            setDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub setDefaults()
        rdoDefaultDatasets.Checked = True
        grpR.Enabled = False
    End Sub

    Private Sub cmdLibraryCollection_Click(sender As Object, e As EventArgs) Handles cmdLibraryCollection.Click
        Dim dlgOpenDialog As New OpenFileDialog
        dlgOpenDialog.Title = "Import from library"
        dlgOpenDialog.InitialDirectory = strLibraryPath
        dlgOpenDialog.Filter = "RDS R-file (*.RDS)|*.RDS"
        If Not frmMain.clsRLink.bInstatObjectExists Then
            frmMain.clsRLink.CreateNewInstatObject()
        End If
        If dlgOpenDialog.ShowDialog = DialogResult.OK Then
            loadData(dlgOpenDialog.FileName.Replace("\", "/"))
            dlgOpenDialog.RestoreDirectory = True
        End If
    End Sub

    Private Sub loadData(strFilePath As String)
        ucrBase.clsRsyntax.SetFunction("readRDS")
        ucrBase.clsRsyntax.SetAssignTo(frmMain.clsRLink.strInstatDataObject)
        ucrBase.clsRsyntax.AddParameter("file", Chr(34) & strFilePath & Chr(34))
    End Sub

    Private Sub chkChooseFrom_CheckStateChanged(sender As Object, e As EventArgs) Handles chkChooseFrom.CheckStateChanged
        If chkChooseFrom.Checked Then
            grpR.Enabled = True
            lstCollection.Enabled = True
        Else
            grpR.Enabled = False
            lstCollection.Enabled = False
        End If
    End Sub

    Private Sub rdoDefaultDatasets_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDefaultDatasets.CheckedChanged, rdoChooseDatasets.CheckedChanged
        If rdoDefaultDatasets.Checked Then
            Dim dfDefault As DataFrame
            cboPackages.Visible = False
            frmMain.clsRLink.clsEngine.Evaluate(strLibraryTemp & "<-data.frame(data(package = 'datasets')$results[1:nrow(data(package = 'datasets')$results),3:4])")
            dfDefault = frmMain.clsRLink.clsEngine.GetSymbol(strLibraryTemp).AsDataFrame
            FillListView(dfDataframe:=dfDefault)
        ElseIf rdoChooseDatasets.Checked Then
            lstCollection.Items.Clear()
            FillPackagesCombo()
            cboPackages.Visible = True
        End If
    End Sub

    Private Sub FillPackagesCombo()
        Dim i As Integer
        Dim lstAvailablePackages As GenericVector
        lstAvailablePackages = frmMain.clsRLink.clsEngine.Evaluate(strPackages & "<-installed.packages(lib.loc = NULL)[,1]").AsList
        cboPackages.Items.Clear()
        For i = 0 To lstAvailablePackages.Length - 1
            cboPackages.Items.Add(lstAvailablePackages.AsCharacter(i))
        Next
    End Sub

    Private Sub FillListView(dfDataframe As DataFrame)
        Dim lstItem As New ListViewItem
        lblDatasetsNumber.Text = dfDataframe.RowCount
        'clears the listview before loading
        lstCollection.Items.Clear()
        'Fills the list
        For i As Integer = 0 To dfDataframe.RowCount - 1
            lstItem = lstCollection.Items.Add(dfDataframe(i, 0))
            lstItem.SubItems.Add(dfDataframe(i, 1))
        Next
    End Sub

    Private Sub loadDatasets(strPackage As String)
        Try
            Dim dfPackage As DataFrame
            frmMain.clsRLink.clsEngine.Evaluate(strLibraryTemp & "<-data.frame(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results[1:nrow(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results),3:4])")
            dfPackage = frmMain.clsRLink.clsEngine.GetSymbol(strLibraryTemp).AsDataFrame
            FillListView(dfDataframe:=dfPackage)
        Catch ex As Exception
            MessageBox.Show("Selected package does not contain any datasets", "Error in loading datasets")
        End Try

    End Sub

    Private Sub cboPackages_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPackages.SelectedValueChanged
        loadDatasets(cboPackages.SelectedItem.ToString)
    End Sub
End Class