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
            'fills the combo box
            FillPackagesCombo()
            '
            setDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub setDefaults()
        rdoDefaultDatasets.Checked = True
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
        txtFilePath.Text = strFilePath
    End Sub

    Private Sub rdoDefaultDatasets_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDefaultDatasets.CheckedChanged, rdoInstatCollection.CheckedChanged
        If rdoDefaultDatasets.Checked Then
            cboPackages.Enabled = False
            cboPackages.SelectedItem = "datasets"
            cboPackages.Enabled = True
            grpCollection.Enabled = False
        ElseIf rdoInstatCollection.Checked Then
            cboPackages.Enabled = False
            grpCollection.Enabled = True
        End If
    End Sub

    Private Sub FillPackagesCombo()
        Dim strTempHolder As String = "lsPackagesHolder"
        Dim i As Integer
        Dim lstAvailablePackages As CharacterVector
        cboPackages.Items.Clear()
        lstAvailablePackages = frmMain.clsRLink.clsEngine.Evaluate(strPackages & "<-(.packages())").AsCharacter
        For i = 0 To lstAvailablePackages.Length - 1
            Try
                If frmMain.clsRLink.clsEngine.Evaluate("nrow(data(package = " & Chr(34) & lstAvailablePackages.AsCharacter(i) & Chr(34) & ")$results)").AsInteger(0) > 0 Then
                    cboPackages.Items.Add(lstAvailablePackages.AsCharacter(i))
                End If
            Catch ex As Exception

            End Try
        Next
    End Sub

    Private Sub FillListView(dfDataframe As DataFrame)
        Dim lstItem As New ListViewItem
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
            If dfPackage.RowCount > 1 Then
                FillListView(dfDataframe:=dfPackage)
            End If
        Catch ex As Exception
            'lstCollection.Items.Clear()
        End Try

    End Sub

    Private Sub cboPackages_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPackages.SelectedValueChanged
        loadDatasets(cboPackages.SelectedItem.ToString)
    End Sub

    Private Sub lstCollection_Click(sender As Object, e As EventArgs) Handles lstCollection.Click
        ucrBase.clsRsyntax.SetAssignTo(lstCollection.SelectedItems(0).SubItems(0).Text, strTempDataframe:=lstCollection.SelectedItems(0).SubItems(0).Text)
        ucrBase.clsRsyntax.AddParameter("x", lstCollection.SelectedItems(0).SubItems(0).Text)
    End Sub

    Private Sub initialiseFunction()
        ucrBase.clsRsyntax.SetFunction("as.data.frame")
    End Sub

    Private Sub TestOkEnabled()
        'ToDO
    End Sub

End Class