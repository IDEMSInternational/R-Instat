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
Public Class dlgExportDataset
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction

    Private Sub dlgExportDataset_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrAvailableSheets.SetParameter(New RParameter("x", 0))
        ucrAvailableSheets.SetParameterIsRFunction()
        ucrAvailableSheets.SetText("Data Frame to Export:")

        ucrFilePath.SetPathControlParameter(New RParameter("file", 1))

        lblConfirm.Visible = False
        lblConfirm.ForeColor = Color.Green
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrAvailableSheets.Reset()
        ucrFilePath.ResetPathControl()
        ucrFilePath.DefaultFileSuggestionName = ucrAvailableSheets.strCurrDataFrame 'set default suggested name from selected data frame


        clsDefaultFunction.SetPackageName("rio")
        clsDefaultFunction.SetRCommand("export")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrAvailableSheets.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrFilePath.SetPathControlRcode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrFilePath.IsEmpty AndAlso Not String.IsNullOrEmpty(ucrAvailableSheets.strCurrDataFrame) Then
            ucrBase.OKEnabled(True)
            lblConfirm.Visible = True
        Else
            ucrBase.OKEnabled(False)
            lblConfirm.Visible = False
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrAvailableSheets_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrAvailableSheets.ControlValueChanged
        'give a suggestive name from selected data frame
        ucrFilePath.DefaultFileSuggestionName = ucrAvailableSheets.strCurrDataFrame
        ucrFilePath.Clear() 'clears the file path contents. 
    End Sub

    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        TestOkEnabled()
    End Sub

End Class
