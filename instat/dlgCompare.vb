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


    Private Sub dlgCompare_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
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

        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetParameter(New RParameter(""))
        ucrReceiverYear.Selector = ucrSelectorCompare
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.bWithQuotes = False
        ucrReceiverYear.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverWithinYear.SetParameter(New RParameter("", 1))
        ucrReceiverWithinYear.SetParameterIsString()
        ucrReceiverWithinYear.bWithQuotes = False
        ucrReceiverWithinYear.strSelectorHeading = "Factors"
        ucrReceiverWithinYear.Selector = ucrSelectorCompare
        ucrReceiverWithinYear.SetIncludedDataTypes({"factor"})

        ' others
        ucrReceiverDate.SetParameter(New RParameter("date", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorCompare
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ' summary
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

        ucrChkDifference.SetText("Difference")
        ucrChkAbsoluteDifference.SetText("Absolute Difference")

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

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)

    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverSateliteElement.IsEmpty AndAlso Not ucrReceiverStationElement.IsEmpty AndAlso (ucrChkAbsoluteDifference.Checked OrElse ucrChkDifference.Checked) Then
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

End Class
