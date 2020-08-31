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
Public Class dlgExportGraphAsImage
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsggSave As New RFunction

    Private Sub dlgExportGraphAsImage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 556

        ucrFilePath.SetPathControlParameter(New RParameter("filename", 0))

        ucrSelectedGraphReceiver.SetParameter(New RParameter("plot", 1))
        ucrSelectedGraphReceiver.SetParameterIsRFunction()
        ucrSelectedGraphReceiver.SetItemType("graph")
        ucrSelectedGraphReceiver.bPrintGraph = False
        ucrSelectedGraphReceiver.strSelectorHeading = "Graphs"
        ucrSelectedGraphReceiver.Selector = ucrSelectorGraphAsImage
        ucrSelectedGraphReceiver.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        clsggSave = New RFunction

        ucrSelectorGraphAsImage.Reset()
        ucrFilePath.ResetPathControl()

        clsggSave.SetPackageName("ggplot2")
        clsggSave.SetRCommand("ggsave")
        ucrBase.clsRsyntax.SetBaseRFunction(clsggSave)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorGraphAsImage.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrFilePath.SetPathControlRcode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrSelectedGraphReceiver.IsEmpty AndAlso Not ucrFilePath.IsEmpty)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectedGraphReceiver.ControlContentsChanged
        'give a default suggested name from the receiver
        ucrFilePath.DefaultFileSuggestionName = ucrSelectedGraphReceiver.GetVariableNames(bWithQuotes:=False)
        TestOkEnabled()
    End Sub

    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        TestOkEnabled()
    End Sub

End Class
