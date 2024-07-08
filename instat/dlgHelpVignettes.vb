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

Imports RDotNet
Imports instat.Translations

Public Class dlgHelpVignettes
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private strAvailablePackages() As String
    Private clsDummyFunction As New RFunction
    Private Sub dlgHelpVignettes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim clsGetPackages As New RFunction
        Dim expPackageNames As SymbolicExpression
        Dim chrPackageNames As CharacterVector

        ucrBase.iHelpTopicID = 695
        ucrPnlHelpVignettes.AddRadioButton(rdoHelp)
        ucrPnlHelpVignettes.AddRadioButton(rdoVignettes)

        ucrInputFunctionName.AddQuotesIfUnrecognised = True

        ucrPnlHelpVignettes.AddParameterValuesCondition(rdoHelp, "type", "help")
        ucrPnlHelpVignettes.AddParameterValuesCondition(rdoVignettes, "type", "browseVignettes")

        ucrPnlHelpVignettes.AddToLinkedControls(ucrChkFunction, {rdoHelp}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedDisabledIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)
        ucrChkFunction.AddToLinkedControls(ucrInputFunctionName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedDisabledIfParameterMissing:=True)

        ucrChkFunction.SetText("Function Name:")

        clsGetPackages.SetRCommand("get_installed_packages_with_data")
        clsGetPackages.AddParameter("with_data", "FALSE")
        expPackageNames = frmMain.clsRLink.RunInternalScriptGetValue(clsGetPackages.ToScript(),bSeparateThread:=False, bSilent:=True)
        If expPackageNames IsNot Nothing AndAlso expPackageNames.Type <> Internals.SymbolicExpressionType.Null Then
            chrPackageNames = expPackageNames.AsCharacter
            strAvailablePackages = chrPackageNames.ToArray
            System.Array.Sort(Of String)(strAvailablePackages)
        End If

        If strAvailablePackages IsNot Nothing Then
            ucrInputComboPackage.SetItems(strAvailablePackages)
            ucrInputComboPackage.SetDropDownStyleAsNonEditable()
        End If
    End Sub

    Private Sub SetDefaults()
        clsDummyFunction = New RFunction

        ucrInputComboPackage.cboInput.SelectedItem = "datasets"

        clsDummyFunction.AddParameter("type", "help", iPosition:=0)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlHelpVignettes.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strPackageName As String = ucrInputComboPackage.cboInput.SelectedItem
        Dim strTopic As String = ucrInputFunctionName.GetText
        If strPackageName <> "" Then
            Dim strURL = clsFileUrlUtilities.GetHelpFileURL(strPackageName:=strPackageName, strTopic:=strTopic,
                                                          bVignette:=rdoVignettes.Checked)
            Dim frmMaximiseOutput As New frmMaximiseOutput
            frmMaximiseOutput.Show(strFileName:=strURL, bReplace:=False)
        End If
    End Sub

    Private Sub ucrPnlHelpVignettes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlHelpVignettes.ControlValueChanged
        If rdoHelp.Checked Then
            clsDummyFunction.AddParameter("type", "help", iPosition:=0)
        Else
            clsDummyFunction.AddParameter("type", "browseVignettes", iPosition:=0)
        End If
    End Sub
End Class