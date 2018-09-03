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
    Private clsHelpFunction, clsVignettesFunction As New RFunction
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
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bSeparateThread = False

        ucrPnlHelpVignettes.AddRadioButton(rdoHelp)
        ucrPnlHelpVignettes.AddRadioButton(rdoVignettes)

        ucrPnlHelpVignettes.AddFunctionNamesCondition(rdoHelp, "help")
        ucrPnlHelpVignettes.AddFunctionNamesCondition(rdoVignettes, "browseVignettes")

        ucrPnlHelpVignettes.AddToLinkedControls(ucrInputFunctionName, {rdoHelp}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedDisabledIfParameterMissing:=True)
        ucrInputFunctionName.SetLinkedDisplayControl(lblFunctionName)

        clsGetPackages.SetRCommand("get_installed_packages_with_data")
        expPackageNames = frmMain.clsRLink.RunInternalScriptGetValue(clsGetPackages.ToScript(),bSeparateThread:=False, bSilent:=True)
        If expPackageNames IsNot Nothing AndAlso expPackageNames.Type <> Internals.SymbolicExpressionType.Null Then
            chrPackageNames = expPackageNames.AsCharacter
            strAvailablePackages = chrPackageNames.ToArray
            System.Array.Sort(Of String)(strAvailablePackages)
        End If

        If strAvailablePackages IsNot Nothing Then
            ucrInputComboPackage.SetParameter(New RParameter("package", 1))
            ucrInputComboPackage.SetItems(strAvailablePackages, bAddConditions:=True)
            ucrInputComboPackage.SetDropDownStyleAsNonEditable()
        End If

    End Sub

    Private Sub SetDefaults()
        clsHelpFunction = New RFunction
        clsVignettesFunction = New RFunction

        ucrInputFunctionName.SetName("")

        clsHelpFunction.SetPackageName("utils")
        clsHelpFunction.SetRCommand("help")

        clsHelpFunction.AddParameter("package", Chr(34) & "datasets" & Chr(34))

        clsVignettesFunction.SetPackageName("utils")
        clsVignettesFunction.SetRCommand("browseVignettes")

        ucrBase.clsRsyntax.SetBaseRFunction(clsHelpFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputComboPackage.AddAdditionalCodeParameterPair(clsVignettesFunction, New RParameter("package", 0), iAdditionalPairNo:=1)
        ucrInputComboPackage.SetRCode(clsHelpFunction, bReset)
        ucrPnlHelpVignettes.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrPnlHelpVignettes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlHelpVignettes.ControlValueChanged
        If rdoHelp.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsHelpFunction)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsVignettesFunction)
        End If
    End Sub

    Private Sub ucrInputFunctionName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputFunctionName.ControlValueChanged, ucrPnlHelpVignettes.ControlValueChanged
        If rdoHelp.Checked AndAlso Not ucrInputFunctionName.IsEmpty Then
            clsHelpFunction.AddParameter("topic", Chr(34) & ucrInputFunctionName.GetText & Chr(34), iPosition:=0)
        Else
            clsHelpFunction.RemoveParameterByName("topic")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub
End Class