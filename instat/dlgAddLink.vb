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
Public Class dlgAddLink
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGetKeyNames As RFunction
    Private Sub dlgAddLink_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 506
        ucrDataSelectorTo.SetParameter(New RParameter("data_name", 0))
        ucrBase.clsRsyntax.iCallType = 2

    End Sub

    Private Sub SetDefaults()
        Dim lstOutput As String
        clsGetKeyNames = New RFunction
        ucrDataSelectorFrom.Reset()
        ucrDataSelectorTo.Reset()
        clsGetKeyNames.AddParameter("data_name", Chr(34) & ucrDataSelectorTo.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsGetKeyNames.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_keys")
        lstOutput = frmMain.clsRLink.RunInternalScriptGetValue(clsGetKeyNames.ToScript).AsCharacter(0)
        lvwLinkViewBox.Items.Add(lstOutput)
        lvwLinkViewBox.Columns.Add("Key", 50, HorizontalAlignment.Left)
        lvwLinkViewBox.Columns.Add("Column Name", 100, HorizontalAlignment.Left)
        ucrBase.clsRsyntax.SetBaseRFunction(clsGetKeyNames)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub ucrBaseReplace_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class