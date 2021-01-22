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
Public Class dlgClimaticNCMPSummaryFile
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction

    Private Sub dlgClimaticNCMPSummaryFile_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        If bFirstLoad Then
            bFirstLoad = False
        End If
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctResolution As New Dictionary(Of String, String)

        ucrSelectorA2.SetParameter(New RParameter("a2", 0))
        ucrSelectorA2.SetParameterIsRFunction()
        ucrSelectorA2.lblDataFrame.Text = "Indices Data Frame:"

        ucrSelectorA4.SetParameter(New RParameter("a4", 1))
        ucrSelectorA4.SetParameterIsRFunction()
        ucrSelectorA4.lblDataFrame.Text = "Region Average Data Frame:"

        ucrSelectorA6.SetParameter(New RParameter("a6", 2))
        ucrSelectorA6.SetParameterIsRFunction()
        ucrSelectorA6.lblDataFrame.Text = "Count Records Data Frame:"

        ucrInputFilePath.SetParameter(New RParameter("ncmp_folder", 5))
        ucrInputFilePath.IsReadOnly = True

        'ucrsave
        ucrSaveSummary.SetSaveTypeAsDataFrame()
        ucrSaveSummary.SetLabelText("New Data Frame Name:")
        ucrSaveSummary.SetIsTextBox()
        ucrSaveSummary.SetPrefix("summary_file")
    End Sub
    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorA2.Reset()
        ucrSelectorA4.Reset()
        ucrSelectorA6.Reset()
        ucrInputFilePath.Reset()
        ucrInputFilePath.SetName("")
        ucrSaveSummary.Reset()

        clsDefaultFunction.SetRCommand("p7_summary")
        clsDefaultFunction.SetAssignTo(ucrSaveSummary.GetText(), strTempDataframe:=ucrSaveSummary.GetText())
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrSelectorA2.cboAvailableDataFrames.Text = "" OrElse ucrSelectorA4.cboAvailableDataFrames.Text = "" OrElse ucrSelectorA6.cboAvailableDataFrames.Text = "" OrElse ucrInputFilePath.IsEmpty OrElse Not ucrSaveSummary.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrInputFilePath_Click(sender As Object, e As EventArgs) Handles ucrInputFilePath.Click
        If ucrInputFilePath.IsEmpty() Then
            SelectLocationToSave()
        End If
    End Sub

    Private Sub SelectLocationToSave()
        Dim strPath As String
        Using dlgFolder As New FolderBrowserDialog
            dlgFolder.Description = "Choose Folder"
            If dlgFolder.ShowDialog() = DialogResult.OK Then
                strPath = dlgFolder.SelectedPath
                ucrInputFilePath.SetName(Replace(strPath, "\", "/"))
            End If
            TestOkEnabled()
        End Using
    End Sub

    Private Sub cmdChooseFile_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        SelectLocationToSave()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorA2.ControlContentsChanged, ucrSelectorA4.ControlContentsChanged, ucrSelectorA6.ControlContentsChanged, ucrInputFilePath.ControlContentsChanged, ucrSaveSummary.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class