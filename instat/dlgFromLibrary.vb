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
    Dim strLibraryPath As String = frmMain.strStaticPath & "\" & "Library"
    Dim bFirstLoad As Boolean = True

    Private Sub dlgFromLibrary_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            setLibrary()
            bFirstLoad = False
        End If
    End Sub

    Private Sub setLibrary()
        Dim dfTemp As DataFrame
        Dim lstItem As New ListViewItem
        frmMain.clsRLink.clsEngine.Evaluate(strLibraryTemp & "<-data.frame(data(package =  .packages(all.available = TRUE))$results[1:343,3:4])")
        dfTemp = frmMain.clsRLink.clsEngine.GetSymbol(strLibraryTemp).AsDataFrame
        'Fills the list
        For i As Integer = 0 To dfTemp.RowCount - 1
            lstItem = lstCollection.Items.Add(dfTemp(i, 0))
            lstItem.SubItems.Add(dfTemp(i, 1))
        Next
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
            lstCollection.Enabled = True
        Else
            lstCollection.Enabled = False
        End If
    End Sub

End Class