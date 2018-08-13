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

Public Class dlgCompare
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True


    Private iReceiverSateliteY As Integer
    Private iReceiverLabelSateliteY As Integer
    Private iReceiverStationY As Integer
    Private iReceiverLabelStationY As Integer

    Private Sub dlgCompare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iReceiverSateliteY = ucrReceiverSateliteElement.Location.Y
            iReceiverLabelSateliteY = lblSateliteElement.Location.Y
            iReceiverStationY = ucrReceiverStationElement.Location.Y
            iReceiverLabelStationY = lblStationElement.Location.Y
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrPnlCompare.AddRadioButton(rdoAnomalies)
        ucrPnlCompare.AddRadioButton(rdoDifferences)

        ucrPnlCompare.AddToLinkedControls(ucrReceiverStationElement, {rdoDifferences, rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrReceiverSateliteElement, {rdoDifferences, rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrReceiverStation, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrReceiverWithinYear, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrSaveBias, {rdoDifferences}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrSaveAbsDev, {rdoDifferences}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrSaveSateliteAnomalies, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)
        ucrPnlCompare.AddToLinkedControls(ucrSaveStationAnomalies, {rdoAnomalies}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True)


        ucrSelectorCompare.SetParameter(New RParameter("", 0))
        ucrSelectorCompare.SetParameterIsrfunction()

        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetParameter(New RParameter(""))
        ucrReceiverStation.Selector = ucrSelectorCompare
        ucrReceiverStation.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "station" & Chr(34)})
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.bWithQuotes = False
        ucrReceiverStation.SetIncludedDataTypes({"factor"})
        ucrReceiverStation.strSelectorHeading = "Station Variables"

        ucrReceiverWithinYear.SetParameter(New RParameter("", 1))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False
        ucrReceiverWithinYear.strSelectorHeading = "Factors"
        ucrReceiverWithinYear.Selector = ucrSelectorCompare
        ucrReceiverWithinYear.SetIncludedDataTypes({"factor"})

        ucrReceiverSateliteElement.SetParameter(New RParameter("", 0))
        ucrReceiverSateliteElement.SetParameterIsString()
        ucrReceiverSateliteElement.bWithQuotes = False
        ucrReceiverSateliteElement.bAutoFill = True
        ucrReceiverSateliteElement.strSelectorHeading = "Variables"
        ucrReceiverSateliteElement.Selector = ucrSelectorCompare
        ucrReceiverSateliteElement.SetIncludedDataTypes({"numeric"})

        ucrReceiverStationElement.SetParameter(New RParameter("", 0))
        ucrReceiverStationElement.SetParameterIsString()
        ucrReceiverStationElement.bWithQuotes = False
        ucrReceiverStationElement.bAutoFill = True
        ucrReceiverStationElement.strSelectorHeading = "Variables"
        ucrReceiverStationElement.Selector = ucrSelectorCompare
        ucrReceiverStationElement.SetIncludedDataTypes({"numeric"})

        ucrChkMovingAverage.SetText("Moving Average")
        ucrChkMovingAverage.Enabled = False

        ucrSaveBias.SetPrefix("bias")
        ucrSaveBias.SetIsComboBox()
        ucrSaveBias.SetCheckBoxText("Bias")
        ucrSaveBias.SetSaveTypeAsColumn()
        ucrSaveBias.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)

        ucrSaveAbsDev.SetPrefix("absdev")
        ucrSaveAbsDev.SetIsComboBox()
        ucrSaveAbsDev.SetCheckBoxText("Absolute Deviation")
        ucrSaveAbsDev.SetSaveTypeAsColumn()
        ucrSaveAbsDev.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)


        ucrSaveSateliteAnomalies.SetPrefix("satelite_anomalies")
        ucrSaveSateliteAnomalies.SetIsTextBox()
        ucrSaveSateliteAnomalies.SetLabelText("Satelite Anomalies")
        ucrSaveSateliteAnomalies.SetSaveTypeAsColumn()
        ucrSaveSateliteAnomalies.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)

        ucrSaveStationAnomalies.SetPrefix("station_anomalies")
        ucrSaveStationAnomalies.SetIsTextBox()
        ucrSaveStationAnomalies.SetLabelText("Station Anomalies")
        ucrSaveStationAnomalies.SetSaveTypeAsColumn()
        ucrSaveStationAnomalies.SetDataFrameSelector(ucrSelectorCompare.ucrAvailableDataFrames)

        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrReceiverWithinYear.SetLinkedDisplayControl(lblWithinYear)
        ucrReceiverSateliteElement.SetLinkedDisplayControl(lblSateliteElement)
        ucrReceiverStationElement.SetLinkedDisplayControl(lblStationElement)

        ucrChkMovingAverage.AddToLinkedControls(ucrNudMovingAverage, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0)

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)

    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverSateliteElement.IsEmpty AndAlso Not ucrReceiverStationElement.IsEmpty AndAlso (ucrChkMovingAverage.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore)
        TestOkEnabled()
    End Sub

    Private Sub ElementsLabelReceiverLocation()
        If rdoDifferences.Checked Then
            lblSateliteElement.Location = New Point(lblSateliteElement.Location.X, iReceiverLabelSateliteY / 2.0)
            lblStationElement.Location = New Point(lblStationElement.Location.X, iReceiverLabelStationY / 1.7)
            ucrReceiverSateliteElement.Location = New Point(ucrReceiverSateliteElement.Location.X, iReceiverSateliteY / 1.85)
            ucrReceiverStationElement.Location = New Point(ucrReceiverStationElement.Location.X, iReceiverStationY / 1.6)
        Else
            lblSateliteElement.Location = New Point(lblSateliteElement.Location.X, iReceiverLabelSateliteY)
            ucrReceiverSateliteElement.Location = New Point(ucrReceiverSateliteElement.Location.X, iReceiverSateliteY)
            lblStationElement.Location = New Point(lblStationElement.Location.X, iReceiverLabelStationY)
            ucrReceiverStationElement.Location = New Point(ucrReceiverStationElement.Location.X, iReceiverStationY)
        End If
    End Sub

    Private Sub ucrPnlCompare_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCompare.ControlValueChanged
        ElementsLabelReceiverLocation()
    End Sub
End Class
