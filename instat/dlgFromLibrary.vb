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
    Dim clsDataFunction As New RFunction

    Private Sub dlgFromLibrary_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            '
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        rdoDefaultDatasets.Checked = True
        cboPackages.SelectedItem = "datasets"
        loadDatasets(cboPackages.SelectedItem.ToString)
        EnableHelp()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 156
        'fills the combo box
        clsDataFunction.SetPackageName("utils")
        clsDataFunction.SetRCommand("data")
        FillPackagesCombo()
        'TODO remove once control is updated
        cboPackages.DropDownStyle = ComboBoxStyle.DropDownList
        cboPackages.AutoCompleteMode = AutoCompleteMode.None
        cboPackages.AutoCompleteSource = AutoCompleteSource.None
        lstCollection.HideSelection = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdLibraryCollection_Click(sender As Object, e As EventArgs) Handles cmdLibraryCollection.Click
        dlgImportDataset.bFromLibrary = True
        dlgImportDataset.bStartOpenDialog = True
        dlgImportDataset.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub rdoDefaultDatasets_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDefaultDatasets.CheckedChanged, rdoInstatCollection.CheckedChanged
        If rdoDefaultDatasets.Checked Then
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
        Dim lstAvailablePackages As String()
        cboPackages.Items.Clear()
        'This is now a static list because
        lstAvailablePackages = {"datasets", "reshape2", "lubridate", "plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "faraway"}

        'lstAvailablePackages = frmMain.clsRLink.RunInternalScriptGetValue(strPackages & "<-(.packages())").AsCharacter
        For i = 0 To lstAvailablePackages.Length - 1
            Try
                If frmMain.clsRLink.RunInternalScriptGetValue("nrow(data(package = " & Chr(34) & lstAvailablePackages(i) & Chr(34) & ")$results)").AsInteger(0) > 0 Then
                    cboPackages.Items.Add(lstAvailablePackages(i))
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
            dfPackage = frmMain.clsRLink.RunInternalScriptGetValue("data.frame(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results[1:nrow(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results),3:4])").AsDataFrame
            If dfPackage.RowCount > 1 Then
                FillListView(dfDataframe:=dfPackage)
            End If
        Catch ex As Exception
            'lstCollection.Items.Clear()
        End Try

    End Sub

    Private Sub cboPackages_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboPackages.SelectedValueChanged
        loadDatasets(cboPackages.SelectedItem.ToString)
        clsDataFunction.AddParameter("package", Chr(34) & cboPackages.SelectedItem.ToString & Chr(34))
        TestOkEnabled()
    End Sub

    Private Sub lstCollection_Click(sender As Object, e As EventArgs) Handles lstCollection.Click
        ucrBase.clsRsyntax.SetCommandString(chkString(lstCollection.SelectedItems(0).SubItems(0).Text))
        ucrBase.clsRsyntax.SetAssignTo(chkString(lstCollection.SelectedItems(0).SubItems(0).Text), strTempDataframe:=chkString(lstCollection.SelectedItems(0).SubItems(0).Text))
        'ucrBase.clsRsyntax.AddParameter("x", chkString(lstCollection.SelectedItems(0).SubItems(0).Text))
        clsDataFunction.AddParameter("X", chkString(lstCollection.SelectedItems(0).SubItems(0).Text))

        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If rdoDefaultDatasets.Checked AndAlso lstCollection.SelectedItems.Count > 0 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

        EnableHelp()
    End Sub

    Private Function chkString(ByVal strValue As String)
        Dim strLength As Integer = strValue.IndexOf(" ")
        If strLength = -1 Then
            Return strValue
        Else
            Return strValue.Substring(0, strLength)
        End If
    End Function

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        Dim bChecked As Boolean
        bChecked = ucrBase.chkComment.Checked
        If bChecked Then
            frmMain.clsRLink.RunScript(clsDataFunction.ToScript(), strComment:=ucrBase.strComment)
        Else
            frmMain.clsRLink.RunScript(clsDataFunction.ToScript())
        End If
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("topic", Chr(34) & lstCollection.SelectedItems(0).Text & Chr(34))
        clsHelp.AddParameter("package", Chr(34) & cboPackages.SelectedItem & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:=" dlgOpenFromLibrary Opening help page for" & " " & lstCollection.SelectedItems(0).Text & " " & "dataset")
    End Sub

    Private Sub EnableHelp()
        If rdoDefaultDatasets.Checked AndAlso lstCollection.SelectedItems.Count > 0 Then
            cmdHelp.Enabled = True
        Else
            cmdHelp.Enabled = False
        End If
    End Sub

End Class