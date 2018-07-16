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

        ucrSelectorOneDF.SetParameter(New RParameter("data"))
        ucrSelectorOneDF.SetParameterIsrfunction()

        ucrReceiverStationOneDF.Selector = ucrSelectorOneDF
        ucrReceiverStationOneDF.SetParameter(New RParameter("station"))
        ucrReceiverStationOneDF.SetParameterIsString()
        ucrReceiverStationOneDF.SetLinkedDisplayControl(lblStationOneDF)
        'ucrReceiverStationElementData.SetClimaticType("station")
        'ucrReceiverStationElementData.bAutoFill = True

        ucrReceiverYear.Selector = ucrSelectorOneDF
        ucrReceiverYear.SetParameter(New RParameter("year"))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        'ucrReceiverYear.SetClimaticType("year")
        'ucrReceiverYear.bAutoFill = True

        ucrReceiverElement.Selector = ucrSelectorOneDF
        ucrReceiverElement.SetParameter(New RParameter("element"))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.SetLinkedDisplayControl(lblElement)

        ucrReceiverLatitude.Selector = ucrSelectorOneDF
        ucrReceiverLatitude.SetParameter(New RParameter("latitude"))
        ucrReceiverLatitude.SetParameterIsString()
        ucrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)
        ucrReceiverLatitude.bAttachedToPrimaryDataFrame = False
        ucrReceiverLatitude.bOnlyLinkedToPrimaryDataFrames = False

        ucrReceiverLongitude.Selector = ucrSelectorOneDF
        ucrReceiverLongitude.SetParameter(New RParameter("longitude"))
        ucrReceiverLongitude.SetParameterIsString()
        ucrReceiverLongitude.SetLinkedDisplayControl(lblLongitude)
        ucrReceiverLongitude.bAttachedToPrimaryDataFrame = False
        ucrReceiverLongitude.bOnlyLinkedToPrimaryDataFrames = False

        ucrReceiverStationTwoDF.Selector = ucrSelectorOneDF
        ucrReceiverStationTwoDF.SetParameter(New RParameter("station_latlondata"))
        ucrReceiverStationTwoDF.SetParameterIsString()
        ucrReceiverStationTwoDF.SetLinkedDisplayControl(lblStationTwoDF)
        ucrReceiverStationTwoDF.strSelectorHeading = "Numerics"
        ucrReceiverStationTwoDF.bAttachedToPrimaryDataFrame = False
        ucrReceiverStationTwoDF.bOnlyLinkedToPrimaryDataFrames = False

        ucrInputFilePath.SetParameter(New RParameter("file", 0))
        ucrInputFilePath.IsReadOnly = True

        ucrPnlNoOfDF.AddRadioButton(rdoTwoDFLong)
        ucrPnlNoOfDF.AddRadioButton(rdoOneDF)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoOneDF, "lat_lon_data", False)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDFLong, "lat_lon_data", True)
        ucrPnlNoOfDF.AddParameterPresentCondition(rdoTwoDFWide, "long", True)

        ucrPnlNoOfDF.AddToLinkedControls({ucrReceiverStationTwoDF, ucrSelectorTwoDF}, {rdoTwoDFLong, rdoTwoDFWide}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNoOfDF.AddToLinkedControls({ucrReceiverMultipleStation}, {rdoTwoDFWide}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlNoOfDF.AddToLinkedControls(ucrReceiverElement, {rdoOneDF, rdoTwoDFLong}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

    Private Sub SetDefaults()
        clsOutputCPT = New RFunction
        clsExportCPT = New RFunction

        ucrReceiverStationOneDF.SetMeAsReceiver()
        ucrSelectorOneDF.Reset()
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
        ucrSelectorOneDF.AddAdditionalCodeParameterPair(clsOutputCPT, New RParameter("lat_lon_data"), iAdditionalPairNo:=1)
        ucrReceiverStationOneDF.SetMeAsReceiver()
        ucrReceiverStationOneDF.SetRCode(clsOutputCPT, bReset)
        ucrReceiverYear.SetRCode(clsOutputCPT, bReset)
        ucrSelectorOneDF.SetRCode(clsOutputCPT, bReset)
        ucrReceiverElement.SetRCode(clsOutputCPT, bReset)
        ucrReceiverLatitude.SetMeAsReceiver()
        ucrReceiverLatitude.SetRCode(clsOutputCPT, bReset)
        ucrReceiverLongitude.SetRCode(clsOutputCPT, bReset)
        ucrReceiverStationTwoDF.SetRCode(clsOutputCPT, bReset)
        ucrPnlNoOfDF.SetRCode(clsOutputCPT, bReset)
        ucrInputFilePath.SetRCode(clsExportCPT)
    End Sub

    Private Sub TestOkEnabled()
        If rdoTwoDFLong.Checked Then
            If Not ucrReceiverStationTwoDF.IsEmpty AndAlso Not ucrReceiverStationOneDF.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongitude.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoOneDF.Checked Then
            If Not ucrReceiverStationOneDF.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso Not ucrReceiverLatitude.IsEmpty AndAlso Not ucrReceiverLongitude.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSaveExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrReceiverStationOneDF.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs)
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

    Private Sub ucrBaseExportToCPT_ClickReset(sender As Object, e As EventArgs)
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlNoOfDF_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlNoOfDF.ControlContentsChanged
        TestOkEnabled()
        DataFrames()
    End Sub

    Private Sub ucrReceiverStationOneDF_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStationOneDF.ControlValueChanged, ucrReceiverStationTwoDF.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrReceiverElement.ControlValueChanged, ucrReceiverLatitude.ControlValueChanged, ucrReceiverLongitude.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorExporCPT_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorOneDF.ControlValueChanged
        DataFrames()
    End Sub

    Private Sub DataFrames()
        If rdoTwoDFLong.Checked() Then
            If ucrSelectorOneDF.CurrentReceiver Is Nothing OrElse ucrSelectorOneDF.CurrentReceiver.bAttachedToPrimaryDataFrame Then
                clsOutputCPT.AddParameter("data", ucrSelectorOneDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
            Else
                clsOutputCPT.AddParameter("lat_lon_data", ucrSelectorOneDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
            End If
        ElseIf rdoOneDF.Checked Then
            clsOutputCPT.RemoveParameterByName("lat_lon_data")
            clsOutputCPT.AddParameter("data", ucrSelectorOneDF.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0)
        End If
    End Sub
End Class