'' Instat-R
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
Public Class dlgExportGraphAsImage
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsGgsave As New RFunction

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
        ucrSelectorGraphAsImage.SetItemType("graph")
        ucrSelectedGraphReceiver.strSelectorHeading = "Graphs"

        ucrPnlImageFormats.SetParameter(New RParameter("device"))
        ucrPnlImageFormats.AddRadioButton(rdoBmp, Chr(34) & "bmp" & Chr(34))
        ucrPnlImageFormats.AddRadioButton(rdoJpeg, Chr(34) & "jpeg" & Chr(34))
        ucrPnlImageFormats.AddRadioButton(rdoPng, Chr(34) & "png" & Chr(34))
        ucrPnlImageFormats.AddRadioButton(rdoSvg, Chr(34) & "svg" & Chr(34))
        ucrPnlImageFormats.AddRadioButton(rdoTex, Chr(34) & "tex" & Chr(34))
        ucrPnlImageFormats.AddRadioButton(rdoWmf, Chr(34) & "wmf" & Chr(34))

        ucrSelectedGraphReceiver.Selector = ucrSelectorGraphAsImage
        ucrSelectedGraphReceiver.SetParameter(New RParameter("filename"))
        ucrSelectedGraphReceiver.SetParameterIsString()
        ucrSelectedGraphReceiver.SetMeAsReceiver()
        ucrInputFile.SetParameter(New RParameter("path"))


    End Sub

    Private Sub SetDefaults()
        ucrInputFile.Reset()
        ucrInputFile.SetName("")
        ucrSelectorGraphAsImage.Reset()

        clsGgsave = New RFunction
        clsGgsave.SetRCommand("ggsave")
        clsGgsave.AddParameter("device", Chr(34) & "png" & Chr(34))
        ucrBase.clsRsyntax.SetBaseRFunction(clsGgsave)
    End Sub

    Private Sub SetRcodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrSelectedGraphReceiver.IsEmpty AndAlso ucrInputFile.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputFile_ControlContentsChanged() Handles ucrInputFile.ControlContentsChanged, ucrSelectedGraphReceiver.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        Dim dlgSelectFile As New FolderBrowserDialog
        dlgSelectFile.Description = "Save Graph As Image"
        If dlgSelectFile.ShowDialog() = DialogResult.OK Then
            ucrInputFile.SetName(dlgSelectFile.SelectedPath.Replace("\", "/"))
        End If
    End Sub

    Private Sub ucrInputFile_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectedGraphReceiver.ControlContentsChanged, ucrInputFile.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class