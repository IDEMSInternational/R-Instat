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
Imports instat
Imports instat.Translations
Public Class dlgExportToCPT
    Dim bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsExportCPT, clsOutputCPT As New RFunction

    Private Sub dlgExportToCPT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 355

        ucrSelectorExporCPT.SetParameter(New RParameter("data"))
        ucrSelectorExporCPT.SetParameterIsrfunction()

        ucrReceiverStationElementData.Selector = ucrSelectorExporCPT
        ucrReceiverStationElementData.SetParameter(New RParameter("station"))
        ucrReceiverStationElementData.SetParameterIsString()
        ucrReceiverStationElementData.SetLinkedDisplayControl(lblStationElement)
        'ucrReceiverStationElementData.SetClimaticType("station")
        'ucrReceiverStationElementData.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorExporCPT
        ucrReceiverYear.SetParameter(New RParameter("year"))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        'ucrReceiverYear.SetClimaticType("year")
        'ucrReceiverYear.bAutoFill = True

        ucrReceiverElement.Selector = ucrSelectorExporCPT
        ucrReceiverElement.SetParameter(New RParameter("element"))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.SetLinkedDisplayControl(lblElement)

        ucrReceiverStationLatLon.Selector = ucrSelectorExporCPT
        ucrReceiverStationLatLon.SetParameter(New RParameter("station_latlondata"))
        ucrReceiverStationLatLon.SetParameterIsString()
        ucrReceiverStationLatLon.SetLinkedDisplayControl(lblStationLatLon)
        ucrReceiverStationLatLon.strSelectorHeading = "Numerics"

        UcrReceiverLatitude.Selector = ucrSelectorExporCPT
        UcrReceiverLatitude.SetParameter(New RParameter("latitude"))
        UcrReceiverLatitude.SetParameterIsString()
        UcrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)

        UcrReceiverLongitude.Selector = ucrSelectorExporCPT
        UcrReceiverLongitude.SetParameter(New RParameter("longitude"))
        UcrReceiverLongitude.SetParameterIsString()
        UcrReceiverLongitude.SetLinkedDisplayControl(lblLongitude)

        ucrInputFilePath.SetParameter(New RParameter("file", 0))
        ucrInputFilePath.IsReadOnly = True

        ucrPnlNoOfDF.AddRadioButton(rdoTwoDF)
        ucrPnlNoOfDF.AddRadioButton(rdoOneDF)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoOneDF, "lat_lon_data", False)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDF, "lat_lon_data", True)


        'ucrChkLongData.AddToLinkedControls(ucrReceiverElement, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrChkLongData.AddToLinkedControls(ucrReceiverStationElementData, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

    End Sub

    Private Sub SetDefaults()
        clsOutputCPT = New RFunction
        clsExportCPT = New RFunction

        ucrReceiverStationElementData.SetMeAsReceiver()
        ucrSelectorExporCPT.Reset()
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
        ucrReceiverStationElementData.SetMeAsReceiver()
        ucrSelectorExporCPT.SetRCode(clsOutputCPT, bReset)
        ucrReceiverStationElementData.SetRCode(clsOutputCPT, bReset)
        ucrReceiverYear.SetRCode(clsOutputCPT, bReset)
        ucrReceiverElement.SetRCode(clsOutputCPT, bReset)
        UcrReceiverLatitude.SetMeAsReceiver()
        UcrReceiverLatitude.SetRCode(clsOutputCPT, bReset)
        UcrReceiverLongitude.SetRCode(clsOutputCPT, bReset)
        ucrReceiverStationLatLon.SetRCode(clsOutputCPT, bReset)
        ucrPnlNoOfDF.SetRCode(clsOutputCPT, bReset)
        ucrInputFilePath.SetRCode(clsExportCPT)
    End Sub

    Private Sub TestOkEnabled()
        If rdoTwoDF.Checked Then

            If Not ucrReceiverStationLatLon.IsEmpty AndAlso Not UcrReceiverLatitude.IsEmpty AndAlso Not UcrReceiverLongitude.IsEmpty AndAlso Not ucrReceiverStationElementData.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf Not ucrChkLongData.Checked Then
                If Not ucrReceiverStationLatLon.IsEmpty AndAlso Not UcrReceiverLatitude.IsEmpty AndAlso Not UcrReceiverLongitude.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        ElseIf rdoOneDF.Checked Then
            If Not ucrReceiverStationElementData.IsEmpty AndAlso Not UcrReceiverLatitude.IsEmpty AndAlso Not UcrReceiverLongitude.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub



    Private Sub ucrChkLong_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrPnlNoOfDF.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorExporCPT_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorExporCPT.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverStationElementData.ControlContentsChanged, ucrReceiverStationLatLon.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, UcrReceiverLatitude.ControlContentsChanged, UcrReceiverLongitude.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        frmMain.strSaveFilePath = ucrInputFilePath.GetText()
        frmMain.clsRecentItems.addToMenu(Replace(ucrInputFilePath.GetText(), "/", "\"))
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



    Private Sub ucrBaseExportToCPT_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
End Class