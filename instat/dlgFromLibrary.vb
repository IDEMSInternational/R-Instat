﻿' Instat-R
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
            InitialiseDialog()
            '
            setDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub setDefaults()
        rdoDefaultDatasets.Checked = True
        cboPackages.SelectedItem = "datasets"
        loadDatasets(cboPackages.SelectedItem.ToString)
    End Sub

    Private Sub InitialiseDialog()
        'fills the combo box
        FillPackagesCombo()
    End Sub

    Private Sub cmdLibraryCollection_Click(sender As Object, e As EventArgs) Handles cmdLibraryCollection.Click
        dlgImportDataset.bFromLibrary = True
        dlgImportDataset.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub rdoDefaultDatasets_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDefaultDatasets.CheckedChanged, rdoInstatCollection.CheckedChanged
        If rdoDefaultDatasets.Checked Then
            ucrBase.clsRsyntax.SetFunction("as.data.frame")
            cboPackages.Enabled = True
            lstCollection.Enabled = True
            grpCollection.Enabled = False
            If Not bFirstLoad Then
                loadDatasets(cboPackages.SelectedItem.ToString)
            End If
        ElseIf rdoInstatCollection.Checked Then
            lstCollection.Items.Clear()
            lstCollection.Enabled = False
            cboPackages.Enabled = False
            grpCollection.Enabled = True
        End If
        TestOkEnabled()
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
        TestOkEnabled()
    End Sub

    Private Sub lstCollection_Click(sender As Object, e As EventArgs) Handles lstCollection.Click
        ucrBase.clsRsyntax.SetAssignTo(chkString(lstCollection.SelectedItems(0).SubItems(0).Text), strTempDataframe:=chkString(lstCollection.SelectedItems(0).SubItems(0).Text))
        ucrBase.clsRsyntax.AddParameter("x", chkString(lstCollection.SelectedItems(0).SubItems(0).Text))
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If rdoDefaultDatasets.Checked AndAlso lstCollection.SelectedItems.Count > 0 OrElse rdoInstatCollection.Checked Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Function chkString(ByVal strValue As String)
        Dim strLength As Integer = strValue.IndexOf(" ")
        If strLength = -1 Then
            Return strValue
        Else
            Return strValue.Substring(0, strLength)
        End If
    End Function

End Class