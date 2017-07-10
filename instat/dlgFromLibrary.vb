' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
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
    Private lstAvailablePackages As List(Of String)

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

    Private Sub InitialiseDialog()
        Dim expPackageData As SymbolicExpression
        Dim iDataSets As Integer = 0

        ucrBase.iHelpTopicID = 156

        lstCollection.HideSelection = False

        'This is now a static list because packages are not loaded in R.
        lstAvailablePackages = {"agridat", "candisc", "CircStats", "circular", "climdex.pcic", "DAAG", "dae", "datasets", "dplyr", "EnvStats", "Evapotranspiration", "extRemes", "factoextra", "FactoMineR", "faraway", "fitdistrplus", "gapminder", "GGally", "ggplot2", "ggthemes", "htmlTable", "lme4", "lubridate", "openair", "plotly", "plotrix", "plyr", "reshape2", "sjmisc", "stringr", "survival"}.ToList()
        'TODO possibly don't want to be running this much R code in initialse.
        '     alternatively have to make sure all packages have some data
        For i = lstAvailablePackages.Count - 1 To 0 Step -1
            Try
                expPackageData = frmMain.clsRLink.RunInternalScriptGetValue("nrow(data(package = " & Chr(34) & lstAvailablePackages(i) & Chr(34) & ")$results)", bSilent:=True)
                If expPackageData IsNot Nothing Then
                    iDataSets = expPackageData.AsInteger(0)
                End If
                If iDataSets = 0 Then
                    lstAvailablePackages.RemoveAt(i)
                End If
            Catch ex As Exception
                lstAvailablePackages.RemoveAt(i)
            End Try
        Next
        lstAvailablePackages.Sort()

        ucrInputPackages.SetParameter(New RParameter("package"))
        ucrInputPackages.SetItems(lstAvailablePackages.ToArray(), bAddConditions:=True)
        ucrInputPackages.SetDropDownStyleAsNonEditable()
        ucrInputPackages.SetLinkedDisplayControl(lblFromPackage)

        ucrPnlOptions.AddRadioButton(rdoDefaultDatasets)
        ucrPnlOptions.AddRadioButton(rdoInstatCollection)
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition(rdoDefaultDatasets, {"data"})
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition(rdoInstatCollection, {"data"}, False)
        ucrPnlOptions.AddToLinkedControls(ucrInputPackages, {rdoDefaultDatasets}, bNewLinkedHideIfParameterMissing:=True)
    End Sub

    Private Sub SetDefaults()
        'TODO this should be the new clear method
        clsDataFunction.ClearParameters()

        clsDataFunction.SetPackageName("utils")
        clsDataFunction.SetRCommand("data")
        clsDataFunction.AddParameter("package", Chr(34) & "datasets" & Chr(34))

        ucrBase.clsRsyntax.AddToBeforeCodes(clsDataFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrInputPackages.SetRCode(clsDataFunction, bReset)
        ucrPnlOptions.SetRSyntax(ucrBase.clsRsyntax, bReset)
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

    Private Sub ucrPnlOptions_ControlValueChanged() Handles ucrPnlOptions.ControlValueChanged
        'this is done manually as because lstCollection doesnt inherit from core 
        If rdoDefaultDatasets.Checked Then
            lstCollection.Visible = True
            cmdLibraryCollection.Visible = False
            ucrBase.clsRsyntax.AddToBeforeCodes(clsDataFunction)
        Else
            lstCollection.Visible = False
            cmdLibraryCollection.Visible = True
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsDataFunction)
        End If
        TestOkEnabled()
    End Sub

    Private Sub FillListView(dfDataframe As DataFrame)
        Dim lstItem As New ListViewItem

        lstCollection.Items.Clear()
        If dfDataframe IsNot Nothing Then
            For i As Integer = 0 To dfDataframe.RowCount - 1
                lstItem = lstCollection.Items.Add(dfDataframe(i, 0))
                If dfDataframe.ColumnCount > 1 Then
                    lstItem.SubItems.Add(dfDataframe(i, 1))
                Else
                    lstItem.SubItems.Add("")
                End If
            Next
        End If
    End Sub

    Private Sub LoadDatasets(strPackage As String)
        Dim expTemp As SymbolicExpression
        Dim dfPackage As DataFrame = Nothing

        If strPackage IsNot Nothing Then
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue("data.frame(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results[1:nrow(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results),3:4])", bSilent:=True)
            If expTemp IsNot Nothing Then
                dfPackage = expTemp.AsDataFrame
            End If
        End If
        FillListView(dfDataframe:=dfPackage)
    End Sub

    Private Sub ucrInputPackages_ControlValueChanged() Handles ucrInputPackages.ControlValueChanged
        LoadDatasets(ucrInputPackages.GetText())
        TestOkEnabled()
    End Sub

    Private Sub lstCollection_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCollection.SelectedIndexChanged
        Dim strDataName As String

        If lstCollection.SelectedItems.Count > 0 Then
            strDataName = CheckString(lstCollection.SelectedItems(0).SubItems(0).Text)
            ucrBase.clsRsyntax.SetCommandString(strDataName)
            ucrBase.clsRsyntax.SetAssignTo(strDataName, strTempDataframe:=strDataName)
            clsDataFunction.AddParameter("X", strDataName)
        End If
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

    Private Function CheckString(ByVal strValue As String)
        Dim strLength As Integer = strValue.IndexOf(" ")
        If strLength = -1 Then
            Return strValue
        Else
            Return strValue.Substring(0, strLength)
        End If
    End Function

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("topic", Chr(34) & lstCollection.SelectedItems(0).Text & Chr(34))
        clsHelp.AddParameter("package", Chr(34) & ucrInputPackages.cboInput.SelectedItem & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:=" dlgOpenFromLibrary Opening help page for" & " " & lstCollection.SelectedItems(0).Text & " " & "dataset", bSeparateThread:=False)
    End Sub

    Private Sub EnableHelp()
        If rdoDefaultDatasets.Checked AndAlso lstCollection.SelectedItems.Count > 0 Then
            cmdHelp.Enabled = True
        Else
            cmdHelp.Enabled = False
        End If
    End Sub
End Class