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

Public Class dlgFromLibrary
    Private strLibraryTemp As String = "dfLibrary"
    Private strPackages As String = "dfPackagesList"
    Private strLibraryPath As String = frmMain.strStaticPath & "\" & "Library"
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDataFunction As New RFunction
    Private dctPackages As New Dictionary(Of String, String)
    Private Sub dlgFromLibrary_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub
    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrInputPackages.SetRCode(clsDataFunction, bReset)
        ucrPnlOptions.SetRCode(clsDataFunction, bReset)
    End Sub
    Private Sub SetDefaults()
        loadDatasets(ucrInputPackages.GetText)
        ucrInputPackages.SetName("datasets")
        EnableHelp()
        cmdLibraryCollection.Visible = False
        clsDataFunction.SetPackageName("utils")
        clsDataFunction.SetRCommand("data")
        clsDataFunction.AddParameter("package", Chr(34) & "datasets" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsDataFunction)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 156
        ucrInputPackages.SetParameter(New RParameter("package"))
        FillPackagesCombo()
        lstCollection.HideSelection = False
        ucrInputPackages.cboInput.DropDownStyle = ComboBoxStyle.DropDownList
        ucrInputPackages.cboInput.AutoCompleteMode = AutoCompleteMode.None
        ucrInputPackages.cboInput.AutoCompleteSource = AutoCompleteSource.None

        ucrInputPackages.SetDropDownStyleAsNonEditable()
        ucrPnlOptions.AddRadioButton(rdoDefaultDatasets)
        ucrPnlOptions.AddRadioButton(rdoInstatCollection)
        ucrPnlOptions.bAllowNonConditionValues = True
        ucrPnlOptions.AddParameterPresentCondition(rdoDefaultDatasets, "package", True)
        ucrPnlOptions.AddParameterPresentCondition(rdoInstatCollection, "package", False)
        ucrPnlOptions.AddToLinkedControls(ucrInputPackages, {rdoDefaultDatasets}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrInputPackages.SetLinkedDisplayControl(lblFromPackage)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(bReset)
        TestOkEnabled()
    End Sub

    Private Sub cmdLibraryCollection_Click(sender As Object, e As EventArgs) Handles cmdLibraryCollection.Click
        dlgImportDataset.bFromLibrary = True
        dlgImportDataset.bStartOpenDialog = True
        dlgImportDataset.ShowDialog()
        Me.Hide()
    End Sub

    Private Sub rdoDefaultDatasets_CheckedChanged() Handles ucrPnlOptions.ControlValueChanged
        'this is done manually as because lstCollection doesnt inherit from core 
        If rdoDefaultDatasets.Checked Then
            ucrInputPackages.Enabled = True
            lstCollection.Enabled = True
            If Not bFirstLoad Then
                loadDatasets(ucrInputPackages.GetText.ToString)
            ElseIf rdoInstatCollection.Checked Then
                lstCollection.Items.Clear()
                lstCollection.Enabled = False
                ucrInputPackages.Enabled = False
            End If
        End If
        TestOkEnabled()
    End Sub

    Private Sub FillPackagesCombo()
        Dim strTempHolder As String = "lsPackagesHolder"
        Dim i As Integer
        Dim lstAvailablePackages As String()
        ucrInputPackages.Reset()
        'This is now a static list because
        lstAvailablePackages = {"datasets", "reshape2", "lubridate", "plyr", "dplyr", "rtf", "openxlsx", "ggplot2", "extRemes", "GGally", "agridat", "DAAG", "FactoMineR", "plotrix", "candisc", "R6", "openair", "circular", "survival", "Evapotranspiration", "clifro", "devtools", "factoextra", "circlize", "CircStats", "gridExtra", "ggfortify", "rio", "readxl", "lme4", "dummies", "ggthemes", "lazyeval", "stringr", "httr", "jsonlite", "fitdistrplus", "visreg", "climdex.pcic", "mosaic", "ncdf4", "getPass", "RMySQL", "DBI", "EnvStats", "signmedian.test", "sjPlot", "sjmisc", "plotly", "svglite", "htmlTable", "rje", "faraway"}

        ''lstAvailablePackages = frmMain.clsRLink.RunInternalScriptGetValue(strPackages & "<-(.packages())").AsCharacter

        For i = 0 To lstAvailablePackages.Length - 1
            Try
                If frmMain.clsRLink.RunInternalScriptGetValue("nrow(data(package = " & Chr(34) & lstAvailablePackages(i) & Chr(34) & ")$results)").AsInteger(0) > 0 Then
                    ucrInputPackages.SetItems({lstAvailablePackages(i)})
                End If
            Catch ex As Exception

            End Try
        Next
        dctPackages.Add("datasets", Chr(34) & "datasets" & Chr(34))
        dctPackages.Add("reshape2", Chr(34) & "reshape2" & Chr(34))
        dctPackages.Add("lubridate", Chr(34) & "lubridate" & Chr(34))
        dctPackages.Add("plyr", Chr(34) & "plyr" & Chr(34))
        dctPackages.Add("dplyr", Chr(34) & "dplyr" & Chr(34))
        dctPackages.Add("rtf", Chr(34) & "rtf" & Chr(34))
        dctPackages.Add("openxlsx", Chr(34) & "openxlsx" & Chr(34))
        dctPackages.Add("ggplot2", Chr(34) & "ggplot2" & Chr(34))
        dctPackages.Add("extRemes", Chr(34) & "extRemes" & Chr(34))
        dctPackages.Add("GGally", Chr(34) & "GGally" & Chr(34))
        dctPackages.Add("agridat", Chr(34) & "agridat" & Chr(34))
        dctPackages.Add("DAAG", Chr(34) & "DAAG" & Chr(34))
        dctPackages.Add("FactoMineR", Chr(34) & "FactoMineR" & Chr(34))
        dctPackages.Add("plotrix", Chr(34) & "plotrix" & Chr(34))
        dctPackages.Add("candisc", Chr(34) & "candisc" & Chr(34))
        dctPackages.Add("R6", Chr(34) & "R6" & Chr(34))
        dctPackages.Add("openair", Chr(34) & "openair" & Chr(34))
        dctPackages.Add("circular", Chr(34) & "circular" & Chr(34))
        dctPackages.Add("survival", Chr(34) & "survival" & Chr(34))
        dctPackages.Add("Evapotranspiration", Chr(34) & "Evapotranspiration" & Chr(34))
        dctPackages.Add("clifro", Chr(34) & "clifro" & Chr(34))
        dctPackages.Add("devtools", Chr(34) & "devtools" & Chr(34))
        dctPackages.Add("factoextra", Chr(34) & "factoextra" & Chr(34))
        dctPackages.Add("circlize", Chr(34) & "circlize" & Chr(34))
        dctPackages.Add("CircStats", Chr(34) & "CircStats" & Chr(34))
        dctPackages.Add("gridExtra", Chr(34) & "gridExtra" & Chr(34))
        dctPackages.Add("rio", Chr(34) & "rio" & Chr(34))
        dctPackages.Add("readxl", Chr(34) & "readxl" & Chr(34))
        dctPackages.Add("lme4", Chr(34) & "lme4" & Chr(34))
        dctPackages.Add("dummies", Chr(34) & "dummies" & Chr(34))
        dctPackages.Add("ggthemes", Chr(34) & "ggthemes" & Chr(34))
        dctPackages.Add("lazyeval", Chr(34) & "lazyeval" & Chr(34))
        dctPackages.Add("stringr", Chr(34) & "stringr" & Chr(34))
        dctPackages.Add("httr", Chr(34) & "httr" & Chr(34))
        dctPackages.Add("jsonlite", Chr(34) & "jsonlite" & Chr(34))
        dctPackages.Add("fitdistrplus", Chr(34) & "fitdistrplus" & Chr(34))
        dctPackages.Add("visreg", Chr(34) & "visreg" & Chr(34))
        dctPackages.Add("climdex.pcic", Chr(34) & "climdex.pcic" & Chr(34))
        dctPackages.Add("mosaic", Chr(34) & "mosaic" & Chr(34))
        dctPackages.Add("ncdf4", Chr(34) & "ncdf4" & Chr(34))
        dctPackages.Add("getPass", Chr(34) & "getPass" & Chr(34))
        dctPackages.Add("RMySQL", Chr(34) & "RMySQL" & Chr(34))
        dctPackages.Add("DBI", Chr(34) & "DBI" & Chr(34))
        dctPackages.Add("sjmisc", Chr(34) & "sjmisc" & Chr(34))
        dctPackages.Add("plotly", Chr(34) & "plotly" & Chr(34))
        dctPackages.Add("svglite", Chr(34) & "svglite" & Chr(34))
        dctPackages.Add("htmlTable", Chr(34) & "htmlTable" & Chr(34))
        dctPackages.Add("rje", Chr(34) & "rje" & Chr(34))
        dctPackages.Add("faraway", Chr(34) & "faraway" & Chr(34))
        ucrInputPackages.SetItems(dctPackages)
        ucrInputPackages.SetDropDownStyleAsNonEditable()
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

    Private Sub cboPackages_SelectedValueChanged() Handles ucrInputPackages.ControlValueChanged
        loadDatasets(ucrInputPackages.GetText())
        TestOkEnabled()
    End Sub

    Private Sub lstCollection_Click(sender As Object, e As EventArgs) Handles lstCollection.Click
        ucrBase.clsRsyntax.SetCommandString(chkString(lstCollection.SelectedItems(0).SubItems(0).Text))
        ucrBase.clsRsyntax.SetAssignTo(chkString(lstCollection.SelectedItems(0).SubItems(0).Text), strTempDataframe:=chkString(lstCollection.SelectedItems(0).SubItems(0).Text))
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
        'i leave this this way, because we dont have an option of adding strComment on AddToBeforeCodes
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
        clsHelp.AddParameter("package", Chr(34) & ucrInputPackages.cboInput.SelectedItem & Chr(34))
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

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged
        'lstCollection and cmdLibraryCollection are not core so have to be shown manually 
        If rdoDefaultDatasets.Checked Then
            lstCollection.Visible = True
            cmdLibraryCollection.Visible = False
        Else
            lstCollection.Visible = False
            cmdLibraryCollection.Visible = True
        End If
    End Sub
End Class