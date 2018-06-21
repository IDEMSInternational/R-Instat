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
        'output_CPT = function(data, lat_lon_data, station_latlondata, latitude, longitude, station_data, year, element, long.data = TRUE)

        ucrSelectorExporCPT.SetParameter(New RParameter("data", 0))
        ucrSelectorExporCPT.SetParameterIsString()

        ucrReceiverStationElementData.Selector = ucrSelectorExporCPT
        ucrReceiverStationElementData.SetParameter(New RParameter("station", 5))
        ucrReceiverStationElementData.SetParameterIsString()
        ucrReceiverStationElementData.SetLinkedDisplayControl(lblStationElement)

        ucrReceiverYear.Selector = ucrSelectorExporCPT
        ucrReceiverYear.SetParameter(New RParameter("year", 6))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetLinkedDisplayControl(lblYear)

        ucrReceiverElement.Selector = ucrSelectorExporCPT
        ucrReceiverElement.SetParameter(New RParameter("element", 7))
        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.SetLinkedDisplayControl(lblElement)

        ucrReceiverStationLatLon.Selector = ucrSelectorExporCPT
        ucrReceiverStationLatLon.SetParameter(New RParameter("station_latlondata", 2))
        ucrReceiverStationLatLon.SetParameterIsString()
        ucrReceiverStationLatLon.SetLinkedDisplayControl(lblStationLatLon)
        ucrReceiverStationLatLon.strSelectorHeading = "Numerics"

        UcrReceiverLatitude.Selector = ucrSelectorExporCPT
        UcrReceiverLatitude.SetParameter(New RParameter("latitude", 3))
        UcrReceiverLatitude.SetParameterIsString()
        UcrReceiverLatitude.SetLinkedDisplayControl(lblLatitude)

        UcrReceiverLongitude.Selector = ucrSelectorExporCPT
        UcrReceiverLongitude.SetParameter(New RParameter("longitude", 4))
        UcrReceiverLongitude.SetParameterIsString()
        UcrReceiverLongitude.SetLinkedDisplayControl(lblLongitude)

        ucrChkLongData.SetParameter(New RParameter("long.data", 8))
        ucrChkLongData.SetText("Long Data Format")
        ucrChkLongData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkLongData.SetDefaultState("TRUE")

        UcrSaveExportFile.SetParameter(New RParameter("file", 0))
        UcrSaveExportFile.SetPrefix("CPT")
        UcrSaveExportFile.SetSaveTypeAsDataFrame()
        UcrSaveExportFile.SetDataFrameSelector(ucrSelectorExporCPT.ucrAvailableDataFrames)
        UcrSaveExportFile.SetLabelText("CPT File Name:")
        UcrSaveExportFile.SetIsComboBox()

        clsExportCPT.SetAssignTo(UcrSaveExportFile.GetText, strTempDataframe:=ucrSelectorExporCPT.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=UcrSaveExportFile.GetText)

        ucrPnlNoOfDF.AddRadioButton(rdoTwoDF)
        ucrPnlNoOfDF.AddRadioButton(rdoOneDF)
        ucrPnlNoOfDF.AddFunctionNamesCondition(rdoOneDF, "output_CPT")
        ucrPnlNoOfDF.AddFunctionNamesCondition(rdoTwoDF, "output_CPT")

        'ucrPnlNoOfDF.AddToLinkedControls(ucrReceiverYear, {rdoOneDF, rdoTwoDF}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrPnlNoOfDF.AddToLinkedControls(ucrReceiverElement, {rdoOneDF, rdoTwoDF}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        ucrPnlNoOfDF.AddToLinkedControls(ucrChkLongData, {rdoTwoDF}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkLongData.AddToLinkedControls(ucrSectorTwoDF, {False}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrChkLongData.AddToLinkedControls(ucrReceiverYear, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrChkLongData.AddToLinkedControls(ucrReceiverElement, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)
        'ucrChkLongData.AddToLinkedControls(ucrReceiverStationElementData, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True)

    End Sub

    Private Sub SetDefaults()
        clsOutputCPT = New RFunction
        clsExportCPT = New RFunction

        ucrReceiverStationElementData.SetMeAsReceiver()
        ucrSelectorExporCPT.Reset()
        OneOrTwoDF()
        ucrChkLongData.Checked = True

        clsOutputCPT.SetRCommand("output_CPT")

        clsExportCPT.SetPackageName("rio")
        clsExportCPT.SetRCommand("export")
        clsExportCPT.AddParameter("x", clsRFunctionParameter:=clsExportCPT)
        clsExportCPT.AddParameter("format", Chr(34) & "excel" & Chr(34))
        clsExportCPT.AddParameter("sep", Chr(34) & "\t" & Chr(34))
        clsExportCPT.AddParameter("quote", "FALSE")
        clsExportCPT.AddParameter("row.names", "FALSE")
        clsExportCPT.AddParameter("col.names", "TRUE")

        ucrBase.clsRsyntax.SetBaseRFunction(clsExportCPT)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkLongData.SetRCode(clsOutputCPT, bReset)
        ucrSelectorExporCPT.SetDataframe(ucrReceiverStationElementData.GetDataName())
        ucrReceiverStationLatLon.SetMeAsReceiver()
        ucrReceiverStationLatLon.SetRCode(clsOutputCPT, bReset)
        UcrReceiverLatitude.SetRCode(clsOutputCPT, bReset)
        UcrReceiverLongitude.SetRCode(clsOutputCPT, bReset)
        ucrSelectorExporCPT.SetDataframe(UcrReceiverLatitude.GetDataName())
        ucrReceiverStationElementData.SetRCode(clsOutputCPT, bReset)
        ucrReceiverYear.SetRCode(clsOutputCPT, bReset)
        ucrReceiverElement.SetRCode(clsOutputCPT, bReset)
        UcrSaveExportFile.SetRCode(clsExportCPT, bReset)
        ucrPnlNoOfDF.SetRCode(clsOutputCPT, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoTwoDF.Checked Then
            If ucrChkLongData.Checked Then
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

    Private Sub DataFramePanel()
        If ucrSelectorExporCPT.CurrentReceiver Is Nothing OrElse ucrSelectorExporCPT.CurrentReceiver.bAttachedToPrimaryDataFrame Then
            If rdoTwoDF.Checked Then
                clsOutputCPT.AddParameter("lat_lon_data", Chr(34) & ucrSelectorExporCPT.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
                If ucrChkLongData.Checked Then
                    clsOutputCPT.AddParameter("data", Chr(34) & ucrSelectorExporCPT.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
                Else
                    clsOutputCPT.AddParameter("data", Chr(34) & ucrSectorTwoDF.cboAvailableDataFrames.Text & Chr(34))
                End If
            ElseIf rdoOneDF.Checked Then
                clsOutputCPT.AddParameter("data", Chr(34) & ucrSelectorExporCPT.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
                clsOutputCPT.RemoveParameterByName("lat_lon_data")
            End If
        End If
    End Sub

    Private Sub OneOrTwoDF()
        If rdoTwoDF.Checked Then
            If ucrChkLongData.Checked Then
                ucrReceiverElement.Visible = True
                ucrReceiverYear.Visible = True
                ucrReceiverStationElementData.Visible = True
                ucrReceiverStationLatLon.Visible = True
                ucrReceiverStationLatLon.bAttachedToPrimaryDataFrame = False
                UcrReceiverLatitude.bAttachedToPrimaryDataFrame = False
                UcrReceiverLongitude.bAttachedToPrimaryDataFrame = False
                ucrReceiverStationLatLon.bOnlyLinkedToPrimaryDataFrames = False
                UcrReceiverLatitude.bOnlyLinkedToPrimaryDataFrames = False
                UcrReceiverLongitude.bOnlyLinkedToPrimaryDataFrames = False
            Else
                ucrReceiverElement.Visible = False
                ucrReceiverYear.Visible = False
                ucrReceiverStationElementData.Visible = False
                ucrReceiverStationLatLon.Visible = True
                lblStationOneDF.Visible = False
                ucrReceiverStationLatLon.bAttachedToPrimaryDataFrame = True
                UcrReceiverLatitude.bAttachedToPrimaryDataFrame = True
                UcrReceiverLongitude.bAttachedToPrimaryDataFrame = True
                ucrReceiverStationLatLon.bOnlyLinkedToPrimaryDataFrames = True
                UcrReceiverLatitude.bOnlyLinkedToPrimaryDataFrames = True
                UcrReceiverLongitude.bOnlyLinkedToPrimaryDataFrames = True
            End If
        ElseIf rdoOneDF.Checked Then
            lblStationElement.Visible = False
            lblStationOneDF.Visible = True
            ucrReceiverStationElementData.Visible = True
            ucrReceiverStationLatLon.Visible = False
            ucrReceiverElement.Visible = True
            ucrReceiverYear.Visible = True
            ucrReceiverStationLatLon.bAttachedToPrimaryDataFrame = True
            UcrReceiverLatitude.bAttachedToPrimaryDataFrame = True
            UcrReceiverLongitude.bAttachedToPrimaryDataFrame = True
            ucrReceiverStationLatLon.bOnlyLinkedToPrimaryDataFrames = True
            UcrReceiverLatitude.bOnlyLinkedToPrimaryDataFrames = True
            UcrReceiverLongitude.bOnlyLinkedToPrimaryDataFrames = True
        End If
    End Sub

    Private Sub ucrBaseExportToCPT_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrChkLong_ControlContentsChanged(ucrchangedControl As ucrCore) Handles ucrChkLongData.ControlContentsChanged, ucrPnlNoOfDF.ControlContentsChanged
        TestOkEnabled()
        DataFramePanel()
        OneOrTwoDF()
    End Sub

    Private Sub ucrSelectorExporCPT_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorExporCPT.ControlValueChanged
        DataFramePanel()
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveExportFile_ControlContentsChanged(ucrchangedControl As ucrCore) Handles UcrSaveExportFile.ControlContentsChanged, ucrReceiverStationElementData.ControlContentsChanged, ucrReceiverStationLatLon.ControlContentsChanged, ucrReceiverElement.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, UcrReceiverLatitude.ControlContentsChanged, UcrReceiverLongitude.ControlContentsChanged
        clsExportCPT.AddParameter("x", clsRFunctionParameter:=clsOutputCPT)
        clsExportCPT.AddParameter("file", Chr(34) & UcrSaveExportFile.GetText() & Chr(34))
        TestOkEnabled()
        OneOrTwoDF()
    End Sub
End Class