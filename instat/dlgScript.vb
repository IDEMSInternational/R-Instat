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
Public Class dlgScript
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsLibraryFunction, clsGetDataFrameFunction, clsImportNewDataFrame As New RFunction

    Private Sub dlgScript_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        'todo. the iCallType will probably be dynamic
        'ucrBase.clsRsyntax.iCallType = 2
        'ucrBase.clsRsyntax.bSeparateThread = False

        'todo. this combobox can be a custom package control in future. Its also needed in dlgHelpVignettes
        ucrComboGetPackage.SetParameter(New RParameter("package", 0))
        ucrComboGetPackage.SetItems(GetPackages(), bAddConditions:=True)
        ucrComboGetPackage.SetDropDownStyleAsNonEditable()

        ucrDataFrameGet.lblDataFrame.Text = "Get Data Frame:"
        ucrDataFrameGet.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameGet.SetParameterIsString()

        'ucrInputNewDataFrame.SetParameter(New RParameter("new_name", 1))
        ucrInputNewDataFrame.SetValidationTypeAsRVariable()
    End Sub

    Private Function GetPackages() As String()
        Dim arrAvailablePackages() As String = {}
        Dim clsGetPackages As New RFunction
        clsGetPackages.SetRCommand("get_installed_packages_with_data")
        clsGetPackages.AddParameter("with_data", "FALSE")
        Dim expPackageNames As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(clsGetPackages.ToScript(), bSeparateThread:=False, bSilent:=True)
        If expPackageNames IsNot Nothing AndAlso expPackageNames.Type <> Internals.SymbolicExpressionType.Null Then
            arrAvailablePackages = expPackageNames.AsCharacter.ToArray
            Array.Sort(arrAvailablePackages)
        End If
        Return arrAvailablePackages
    End Function

    Private Sub SetDefaults()
        clsLibraryFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsImportNewDataFrame = New RFunction

        ucrComboGetPackage.Reset()
        ucrDataFrameGet.Reset()
        ucrInputNewDataFrame.SetName("")
        ucrInputCommand.SetName("")

        clsLibraryFunction.SetRCommand("library")
        clsLibraryFunction.AddParameter("package", Chr(34) & "datasets" & Chr(34))

        clsGetDataFrameFunction.SetRCommand("data_book$get_data_frame")
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrDataFrameGet.strCurrDataFrame & Chr(34))

        clsImportNewDataFrame.SetRCommand("data_book$import_data")

    End Sub

    Private Sub TestOKEnabled()

        'enable if there is text in the input textbox
        ucrBase.OKEnabled(Not ucrInputCommand.IsEmpty)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrComboGetPackage.SetRCode(clsLibraryFunction, bReset)
        ucrDataFrameGet.SetRCode(clsGetDataFrameFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
    End Sub

    Private Sub ucrInputCommand_ContentsChanged() Handles ucrInputCommand.ContentsChanged
        ucrBase.clsRsyntax.SetCommandString(ucrInputCommand.GetText())
        TestOKEnabled()
    End Sub

    Private Sub btnGetPackage_Click(sender As Object, e As EventArgs) Handles btnGetPackage.Click
        ucrInputCommand.SetName(ucrInputCommand.GetText & Environment.NewLine & clsLibraryFunction.ToScript)
    End Sub

    Private Sub btnGetDataFrame_Click(sender As Object, e As EventArgs) Handles btnGetDataFrame.Click
        clsGetDataFrameFunction.SetAssignTo(ucrDataFrameGet.cboAvailableDataFrames.Text)
        Dim strAssignedScript As String = ""
        clsGetDataFrameFunction.ToScript(strScript:=strAssignedScript)
        ucrInputCommand.SetName(ucrInputCommand.GetText & Environment.NewLine & strAssignedScript)
    End Sub

    Private Sub btnGetColumn_Click(sender As Object, e As EventArgs) Handles btnGetColumn.Click

    End Sub

    Private Sub ucrInputNewDataFrame_ContentsChanged() Handles ucrInputNewDataFrame.ContentsChanged
        btnNewDataframe.Enabled = Not ucrInputNewDataFrame.IsEmpty
    End Sub

    Private Sub btnNewDataframe_Click(sender As Object, e As EventArgs) Handles btnNewDataframe.Click
        Dim clsRFunctionList As New RFunction
        clsRFunctionList.SetRCommand("list")
        clsRFunctionList.AddParameter(ucrInputNewDataFrame.GetText(), ucrInputNewDataFrame.GetText())
        clsImportNewDataFrame.AddParameter("data_tables", clsRFunctionList.ToScript)

        ucrInputCommand.SetName(ucrInputCommand.GetText & Environment.NewLine & clsImportNewDataFrame.ToScript)
    End Sub


End Class