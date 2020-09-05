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
Public Class dlgExportRObjects
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsExport As RFunction

    Private Sub dlgExportRObjects_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 554

        'multiple reciever control that holds selected objects
        ucrReceiverObjects.SetParameter(New RParameter("x", 0))
        ucrReceiverObjects.SetParameterIsRFunction()
        ucrReceiverObjects.Selector = ucrSelectorObjects
        ucrReceiverObjects.SetMeAsReceiver()
        ucrReceiverObjects.strSelectorHeading = "Objects"
        ucrReceiverObjects.SetItemType("object")
        'file path control that holds the file path and name
        ucrFilePath.SetPathControlParameter(New RParameter("file", 1))
    End Sub

    Private Sub SetDefaults()
        clsExport = New RFunction

        'reset controls
        ucrSelectorObjects.Reset()
        ucrFilePath.ResetPathControl()

        'set R command and base function
        clsExport.SetPackageName("rio")
        clsExport.SetRCommand("export")
        ucrBase.clsRsyntax.SetBaseRFunction(clsExport)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverObjects.SetRCode(clsExport, bReset)
        ucrFilePath.SetPathControlRcode(clsExport, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrFilePath.IsEmpty AndAlso Not ucrReceiverObjects.IsEmpty AndAlso Not String.IsNullOrEmpty(ucrSelectorObjects.strCurrentDataFrame))
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverObjects.ControlContentsChanged, ucrSelectorObjects.ControlContentsChanged
        'ucrReceiverObjects is a multireceiver. So give a default suggested name if it has 1 item only
        ucrFilePath.DefaultFileSuggestionName = If(ucrReceiverObjects.GetVariableNamesList().Length = 1, ucrReceiverObjects.GetVariableNames(bWithQuotes:=False), "")
        TestOkEnabled()
    End Sub

    Private Sub ucrFilePath_FilePathChanged() Handles ucrFilePath.FilePathChanged
        TestOkEnabled()
    End Sub

End Class
