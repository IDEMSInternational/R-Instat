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

Imports System.IO
Imports instat.Translations

Public Class dlgExportForClimpact
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsOutputClimpact As New RFunction

    Private Sub dlgExportForClimpact_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
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

        ucrInputCodeMissingValues.SetParameter(New RParameter("missing_code", 6))
        ucrInputCodeMissingValues.SetRDefault("-99.9")

        'Year Receiver
        ucrReceiverYear.Selector = ucrSelectorImportToClimpact
        ucrReceiverYear.SetParameter(New RParameter("year", 0))
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.SetParameterIsRFunction()
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        'Month Receiver
        ucrReceiverMonth.Selector = ucrSelectorImportToClimpact
        ucrReceiverMonth.SetParameter(New RParameter("month", 1))
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.SetParameterIsRFunction()
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"
        ucrReceiverMonth.bWithQuotes = False

        'Day Receiver
        ucrReceiverDay.Selector = ucrSelectorImportToClimpact
        ucrReceiverDay.SetParameter(New RParameter("day", 2))
        ucrReceiverDay.SetParameterIsRFunction()
        ucrReceiverDay.bWithQuotes = False
        ucrReceiverDay.SetClimaticType("day")
        ucrReceiverDay.bAutoFill = True

        'Element Receiver
        ucrReceiverTX.Selector = ucrSelectorImportToClimpact
        ucrReceiverTX.SetParameter(New RParameter("mx_tmp", 3))
        ucrReceiverTX.SetParameterIsRFunction()
        ucrReceiverTX.bWithQuotes = False
        ucrReceiverTX.SetClimaticType("temp_max")
        ucrReceiverTX.bAutoFill = True

        ucrReceiverTN.Selector = ucrSelectorImportToClimpact
        ucrReceiverTN.SetParameter(New RParameter("mn_tmp", 4))
        ucrReceiverTN.SetParameterIsRFunction()
        ucrReceiverTN.SetClimaticType("temp_min")
        ucrReceiverTN.bAutoFill = True
        ucrReceiverTN.bWithQuotes = False

        ucrReceiverRR.SetParameter(New RParameter("rain", 5,))
        ucrReceiverRR.Selector = ucrSelectorImportToClimpact
        ucrReceiverRR.SetClimaticType("rain")
        ucrReceiverRR.bAutoFill = True
        ucrReceiverRR.SetParameterIsRFunction()
        ucrReceiverRR.bWithQuotes = False

        ucrInputExportFile.SetParameter(New RParameter("output_file ", 9))
        ucrInputExportFile.IsReadOnly = True
        ucrInputExportFile.SetLinkedDisplayControl(lblExport)

    End Sub

    Private Sub SetDefaults()
        clsOutputClimpact = New RFunction

        ucrSelectorImportToClimpact.Reset()

        clsOutputClimpact.SetRCommand("write_weather_data")

        ucrBase.clsRsyntax.SetBaseRFunction(clsOutputClimpact)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        ucrBase.OKEnabled(Not ucrReceiverDay.IsEmpty _
                             AndAlso Not ucrReceiverMonth.IsEmpty _
                             AndAlso Not ucrReceiverYear.IsEmpty _
                             AndAlso Not ucrReceiverRR.IsEmpty _
                             AndAlso Not ucrReceiverTX.IsEmpty _
                             AndAlso Not ucrReceiverTN.IsEmpty
                             )
        If ucrInputExportFile.IsEmpty Then
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdBrowse_Click(sender As Object, e As EventArgs) Handles cmdBrowse.Click
        SelectFileToSave()
    End Sub

    Private Sub SelectFileToSave()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save Climpact File"
            dlgSave.Filter = "Text File (*.txt)|*.txt"
            If ucrInputExportFile.GetText() <> "" Then
                dlgSave.InitialDirectory = ucrInputExportFile.GetText().Replace("/", "\")
            Else
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputExportFile.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
            TestOkEnabled()
        End Using
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        If ucrInputExportFile.IsEmpty() Then
            SelectFileToSave()
        End If
    End Sub

    Private Sub ucrReceiverElements_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRR.ControlContentsChanged, ucrReceiverTN.ControlValueChanged, ucrReceiverDay.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrInputExportFile.ControlContentsChanged, ucrReceiverTX.ControlValueChanged, ucrReceiverMonth.ControlValueChanged
        TestOkEnabled()
    End Sub
End Class