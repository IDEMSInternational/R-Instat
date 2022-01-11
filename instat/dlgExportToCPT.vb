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
Public Class dlgExportToCPT
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsExportCPT, clsOutputCPT As New RFunction

    Private Sub dlgExportToCPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 355

        ucrSelectorOneDF.SetParameter(New RParameter("data"))
        ucrSelectorOneDF.SetParameterIsrfunction()

        ucrSelectorTwoDF.SetParameter(New RParameter("lat_lon_data"))
        ucrSelectorTwoDF.SetParameterIsrfunction()

        ucrReceiverStationOneDF.Selector = ucrSelectorOneDF
        ucrReceiverStationOneDF.SetParameter(New RParameter("station"))
        ucrReceiverStationOneDF.SetParameterIsString()
        ucrReceiverStationOneDF.SetLinkedDisplayControl(lblStationOneDF)
        ucrReceiverStationOneDF.SetClimaticType("station")
        ucrReceiverStationOneDF.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorOneDF
        ucrReceiverYear.SetParameter(New RParameter("year"))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverElement.Selector = ucrSelectorOneDF
        ucrReceiverElement.SetParameter(New RParameter("element"))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.SetLinkedDisplayControl(lblElement)

        ucrReceiverMultipleStation.Selector = ucrSelectorOneDF
        ucrReceiverMultipleStation.SetParameter(New RParameter("station"))
        ucrReceiverMultipleStation.SetParameterIsString()
        ucrReceiverMultipleStation.SetLinkedDisplayControl(lblMultStations)

        ucrReceiverLatitude.SetParameter(New RParameter("latitude"))
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)
        ' ucrReceiverLatitude.SetClimaticType("latitude")
        ucrReceiverLatitude.bAutoFill = True

        ucrReceiverLongitude.SetParameter(New RParameter("longitude"))
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.SetLinkedDisplayControl(lblLongitude)
        ' ucrReceiverLongitude.SetClimaticType("longitude")
        ucrReceiverLongitude.bAutoFill = True

        ucrReceiverStationTwoDF.Selector = ucrSelectorTwoDF
        ucrReceiverStationTwoDF.SetParameter(New RParameter("station_latlondata"))
        ucrReceiverStationTwoDF.SetParameterIsString()
        ucrReceiverStationTwoDF.strSelectorHeading = "Numerics"
        ucrReceiverStationTwoDF.bAutoFill = True

        ucrInputCodeMissingValues.SetParameter(New RParameter("na_code"))
        ucrInputCodeMissingValues.SetRDefault("-999")
        ucrInputCodeMissingValues.AddQuotesIfUnrecognised = False

        ucrInputFilePath.SetParameter(New RParameter("file", 0))
        ucrInputFilePath.IsReadOnly = True

        ucrPnlNoOfDF.AddRadioButton(rdoOneDF)
        ucrPnlNoOfDF.AddRadioButton(rdoTwoDFLong)
        ucrPnlNoOfDF.AddRadioButton(rdoTwoDFWide)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoOneDF, "element", True)
        'ucrPnlNoOfDF.AddParameterPresentCondition(rdoOneDF, "station_latlondata", False)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoOneDF, "lat_lon_data", False)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDFLong, "element", True)
        'ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDFLong, "station_latlondata", True)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDFLong, "lat_lon_data", True)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDFWide, "element", False)
        'ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDFWide, "station_latlondata", True)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDFWide, "lat_lon_data", True)

        ucrPnlNoOfDF.AddToLinkedControls({ucrReceiverStationTwoDF, ucrSelectorTwoDF}, {rdoTwoDFLong, rdoTwoDFWide}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNoOfDF.AddToLinkedControls({ucrReceiverMultipleStation}, {rdoTwoDFWide}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNoOfDF.AddToLinkedControls({ucrReceiverElement, ucrReceiverStationOneDF}, {rdoOneDF, rdoTwoDFLong}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverStationTwoDF.SetLinkedDisplayControl(lblStationTwoDF)
        ucrSelectorTwoDF.SetLinkedDisplayControl(lblLine)

    End Sub

    Private Sub SetDefaults()
        clsOutputCPT = New RFunction
        clsExportCPT = New RFunction

        ucrReceiverYear.SetMeAsReceiver()
        ucrSelectorOneDF.Reset()
        ucrSelectorTwoDF.Reset()
        ucrInputFilePath.Reset()
        ucrInputFilePath.SetName("")

        clsOutputCPT.SetRCommand("output_CPT")

        clsExportCPT.SetPackageName("rio")
        clsExportCPT.SetRCommand("export")
        clsExportCPT.AddParameter("x", clsRFunctionParameter:=clsOutputCPT, iPosition:=0)
        clsExportCPT.AddParameter("sep", Chr(34) & "\t" & Chr(34))
        clsExportCPT.AddParameter("quote", "FALSE")
        clsExportCPT.AddParameter("row.names", "FALSE")
        clsExportCPT.AddParameter("col.names", "TRUE")

        ucrBase.clsRsyntax.SetBaseRFunction(clsExportCPT)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverStationOneDF.SetRCode(clsOutputCPT, bReset)
        ucrReceiverYear.SetRCode(clsOutputCPT, bReset)
        ucrSelectorOneDF.SetRCode(clsOutputCPT, bReset)
        ucrSelectorTwoDF.SetRCode(clsOutputCPT, bReset)
        ucrReceiverElement.SetRCode(clsOutputCPT, bReset)
        ucrReceiverMultipleStation.SetRCode(clsOutputCPT, bReset)
        ucrReceiverLatitude.SetRCode(clsOutputCPT, bReset)
        ucrReceiverLongitude.SetRCode(clsOutputCPT, bReset)
        ucrReceiverStationTwoDF.SetRCode(clsOutputCPT, bReset)
        ucrPnlNoOfDF.SetRCode(clsOutputCPT, bReset)
        ucrInputCodeMissingValues.SetRCode(clsOutputCPT, bReset)
        ucrInputFilePath.SetRCode(clsExportCPT)
    End Sub

    Private Sub TestOkEnabled()
        If rdoTwoDFLong.Checked Then
            If Not ucrReceiverStationTwoDF.IsEmpty AndAlso Not ucrReceiverStationOneDF.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongitude.IsEmpty AndAlso Not ucrInputFilePath.IsEmpty AndAlso Not ucrInputCodeMissingValues.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoOneDF.Checked Then
            If Not ucrReceiverStationOneDF.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongitude.IsEmpty AndAlso Not ucrInputFilePath.IsEmpty AndAlso Not ucrInputCodeMissingValues.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoTwoDFWide.Checked Then
            If Not ucrReceiverStationTwoDF.IsEmpty AndAlso Not ucrReceiverMultipleStation.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongitude.IsEmpty AndAlso Not ucrInputFilePath.IsEmpty AndAlso Not ucrInputCodeMissingValues.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSaveExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverStationOneDF.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrInputCodeMissingValues.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs)
        frmMain.strSaveFilePath = ucrInputFilePath.GetText()
        frmMain.clsRecentItems.addToMenu(Replace(ucrInputFilePath.GetText(), "\", "/"))
    End Sub

    Private Sub cmdEditorSave_Click(sender As Object, e As EventArgs) Handles cmdChooseFile.Click
        SelectFileToSave()
    End Sub

    Private Sub ucrInputFilePath_Click(sender As Object, e As EventArgs) Handles ucrInputFilePath.Click
        If ucrInputFilePath.IsEmpty() Then
            SelectFileToSave()
        End If
    End Sub

    Private Sub SelectFileToSave()
        Using dlgSave As New SaveFileDialog
            dlgSave.Title = "Save CPT File"
            dlgSave.Filter = "txt Data file (*.txt)|*.txt"
            If ucrInputFilePath.GetText() <> "" Then
                dlgSave.InitialDirectory = ucrInputFilePath.GetText().Replace("/", "\")
            Else
                dlgSave.InitialDirectory = frmMain.clsInstatOptions.strWorkingDirectory
            End If
            If dlgSave.ShowDialog() = DialogResult.OK Then
                ucrInputFilePath.SetName(dlgSave.FileName.Replace("\", "/"))
            End If
            TestOkEnabled()
        End Using
    End Sub

    Private Sub ucrInputFilePath_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputFilePath.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlNoOfDF_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlNoOfDF.ControlContentsChanged
        TestOkEnabled()
        DataFrames()
        Selectors()
    End Sub

    Private Sub ucrReceiverStationOneDF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStationOneDF.ControlValueChanged, ucrReceiverStationTwoDF.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrReceiverElement.ControlValueChanged, ucrReceiverLatitude.ControlValueChanged, ucrReceiverLongitude.ControlValueChanged, ucrReceiverMultipleStation.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorOneDF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOneDF.ControlValueChanged, ucrSelectorTwoDF.ControlValueChanged
        Selectors()
    End Sub

    Private Sub DataFrames()
        If rdoOneDF.Checked Then
            clsOutputCPT.AddParameter("long.data", "TRUE")
        ElseIf rdoTwoDFLong.Checked() Then
            clsOutputCPT.AddParameter("long.data", "TRUE")
        ElseIf rdoTwoDFWide.Checked() Then
            clsOutputCPT.AddParameter("long.data", "FALSE")
        End If
    End Sub

    Private Sub Selectors()
        If rdoOneDF.Checked() Then
            ucrReceiverLatitude.Selector = ucrSelectorOneDF
            ucrReceiverLongitude.Selector = ucrSelectorOneDF
        ElseIf rdoTwoDFLong.Checked() OrElse rdoTwoDFWide.Checked() Then
            ucrReceiverLatitude.Selector = ucrSelectorTwoDF
            ucrReceiverLongitude.Selector = ucrSelectorTwoDF
        End If
    End Sub
End Class