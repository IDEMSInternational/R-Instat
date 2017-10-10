﻿' R- Instat
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
    Private strAvailablePackages() As String

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
        Dim clsGetPackages As New RFunction
        Dim expPackageNames As SymbolicExpression
        Dim chrPackageNames As CharacterVector
        Dim iDataSets As Integer = 0

        ucrBase.iHelpTopicID = 156

        lstCollection.HideSelection = False

        clsGetPackages.SetRCommand("get_installed_packages_with_data")
        expPackageNames = frmMain.clsRLink.RunInternalScriptGetValue(clsGetPackages.ToScript(), bSilent:=True)
        If expPackageNames IsNot Nothing AndAlso expPackageNames.Type <> Internals.SymbolicExpressionType.Null Then
            chrPackageNames = expPackageNames.AsCharacter
            strAvailablePackages = chrPackageNames.ToArray
            System.Array.Sort(Of String)(strAvailablePackages)
        End If

        If strAvailablePackages IsNot Nothing Then
            ucrInputPackages.SetParameter(New RParameter("package"))
            ucrInputPackages.SetItems(strAvailablePackages, bAddConditions:=True)
            ucrInputPackages.SetDropDownStyleAsNonEditable()
            ucrInputPackages.SetLinkedDisplayControl(lblFromPackage)
        End If

        ucrPnlOptions.AddRadioButton(rdoDefaultDatasets)
        ucrPnlOptions.AddRadioButton(rdoInstatCollection)
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition(rdoDefaultDatasets, {"data"})
        ucrPnlOptions.AddRSyntaxContainsFunctionNamesCondition(rdoInstatCollection, {"data"}, False)
        ucrPnlOptions.AddToLinkedControls(ucrInputPackages, {rdoDefaultDatasets}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOptions.AddToLinkedControls(ucrNewDataFrameName, {rdoDefaultDatasets}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedUpdateFunction:=True)

        ucrNewDataFrameName.SetLabelText("New Data Frame Name:")
        ucrNewDataFrameName.SetIsTextBox()
        ucrNewDataFrameName.SetSaveTypeAsDataFrame()
    End Sub

    Private Sub SetDefaults()
        'TODO this should be the new clear method
        clsDataFunction.ClearParameters()

        ucrNewDataFrameName.Reset()

        clsDataFunction.SetPackageName("utils")
        clsDataFunction.SetRCommand("data")
        clsDataFunction.AddParameter("package", Chr(34) & "datasets" & Chr(34))
        ucrBase.clsRsyntax.AddToBeforeCodes(clsDataFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        If strAvailablePackages IsNot Nothing Then
            ucrInputPackages.SetRCode(clsDataFunction, bReset)
        End If
        ucrNewDataFrameName.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue("data.frame(data(package =" & Chr(34) & strPackage & Chr(34) & ")$results)[ ,3:4]", bSilent:=True)
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
            If Not ucrNewDataFrameName.bUserTyped Then
                ucrNewDataFrameName.SetName(strDataName)
            End If
            clsDataFunction.AddParameter("X", strDataName)
        End If
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If rdoDefaultDatasets.Checked AndAlso lstCollection.SelectedItems.Count > 0 AndAlso ucrNewDataFrameName.IsComplete Then
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
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for" & " " & lstCollection.SelectedItems(0).Text & " " & "dataset. Generated from dialog Open Dataset from Library", bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub EnableHelp()
        If rdoDefaultDatasets.Checked AndAlso lstCollection.SelectedItems.Count > 0 Then
            cmdHelp.Enabled = True
        Else
            cmdHelp.Enabled = False
        End If
    End Sub

    Private Sub ucrNewDataFrameName_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDataFrameName.ControlContentsChanged
        ucrBase.clsRsyntax.SetAssignTo(ucrNewDataFrameName.GetText, strTempDataframe:=ucrNewDataFrameName.GetText)
        TestOkEnabled()
    End Sub
End Class