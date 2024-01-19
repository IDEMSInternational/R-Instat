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

        ucrInputCodeMissingValues.SetParameter(New RParameter("na_code"))
        ucrInputCodeMissingValues.SetRDefault("-99.9")
        ucrInputCodeMissingValues.AddQuotesIfUnrecognised = False

        'Year Receiver
        ucrReceiverYear.Selector = ucrSelectorImportToClimpact
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        'Month Receiver
        ucrReceiverMonth.Selector = ucrSelectorImportToClimpact
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"

        'Day Receiver
        ucrReceiverDay.Selector = ucrSelectorImportToClimpact
        ucrReceiverDay.SetParameter(New RParameter("day", 5, bNewIncludeArgumentName:=False))
        ucrReceiverDay.SetParameterIsString()
        ucrReceiverDay.bWithQuotes = False
        ucrReceiverDay.SetClimaticType("day")
        ucrReceiverDay.bAutoFill = True

        'Element Receiver
        ucrReceiverTX.Selector = ucrSelectorImportToClimpact
        ucrReceiverTX.SetParameter(New RParameter("x", 4, bNewIncludeArgumentName:=False))
        ucrReceiverTX.SetParameterIsString()
        ucrReceiverTX.bWithQuotes = False
        ucrReceiverTX.SetClimaticType("temp_max")
        ucrReceiverTX.bAutoFill = True

        ucrReceiverTN.Selector = ucrSelectorImportToClimpact
        ucrReceiverTN.SetParameter(New RParameter("x", 1, bNewIncludeArgumentName:=False))
        ucrReceiverTN.SetParameterIsString()
        ucrReceiverTN.SetClimaticType("temp_min")
        ucrReceiverTN.bAutoFill = True
        ucrReceiverTN.bWithQuotes = False

        ucrReceiverRR.SetParameter(New RParameter("left", 2, bNewIncludeArgumentName:=False))
        ucrReceiverRR.Selector = ucrSelectorImportToClimpact
        ucrReceiverRR.SetClimaticType("rain")
        ucrReceiverRR.bAutoFill = True
        ucrReceiverRR.SetParameterIsString()
        ucrReceiverRR.bWithQuotes = False

        ucrInputExportFile.SetParameter(New RParameter("output_file ", 9))
        ucrInputExportFile.IsReadOnly = True
        ucrInputExportFile.SetLinkedDisplayControl(lblExport)

    End Sub

    Private Sub SetDefaults()
        clsOutputClimpact = New RFunction

        ucrSelectorImportToClimpact.Reset()

        clsOutputClimpact.SetRCommand("write_weather_data")
        clsOutputClimpact.AddParameter("year", clsRFunctionParameter:=ucrReceiverYear.GetVariables, iPosition:=1)
        clsOutputClimpact.AddParameter("month", clsRFunctionParameter:=ucrReceiverMonth.GetVariables, iPosition:=2)
        clsOutputClimpact.AddParameter("day", clsRFunctionParameter:=ucrReceiverDay.GetVariables, iPosition:=3)
        clsOutputClimpact.AddParameter("rain", clsRFunctionParameter:=ucrReceiverRR.GetVariables, iPosition:=4)
        clsOutputClimpact.AddParameter("mn_tmp", clsRFunctionParameter:=ucrReceiverTN.GetVariables, iPosition:=5)
        clsOutputClimpact.AddParameter("mx_tmp", clsRFunctionParameter:=ucrReceiverTX.GetVariables, iPosition:=6)
        clsOutputClimpact.AddParameter("missing_code", "-99.9", iPosition:=7)

        ucrBase.clsRsyntax.SetBaseRFunction(clsOutputClimpact)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverYear.SetRCode(clsOutputClimpact, bReset)
        ucrSelectorImportToClimpact.SetRCode(clsOutputClimpact, bReset)

        ucrReceiverMonth.SetRCode(clsOutputClimpact, bReset)
        ucrInputCodeMissingValues.SetRCode(clsOutputClimpact, bReset)
        ucrInputExportFile.SetRCode(clsOutputClimpact)
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

    Private Sub ucrReceiverElements_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverRR.ControlContentsChanged, ucrReceiverTN.ControlValueChanged, ucrReceiverDay.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrInputExportFile.ControlContentsChanged, ucrReceiverTX.ControlValueChanged, ucrReceiverMonth.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrInputExportFile_Click(sender As Object, e As EventArgs) Handles ucrInputExportFile.Click
        If ucrInputExportFile.IsEmpty() Then
            SelectFileToSave()
        End If
    End Sub

End Class