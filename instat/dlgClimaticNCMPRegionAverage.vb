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
Public Class dlgClimaticNCMPRegionAverage
    Public bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private bReset As Boolean = True
    Private clsNCMPFunction, clsBaseFunction As New RFunction
    Private bSubDialogOKEnabled As Boolean = True

    Private Sub dlgClimaticNCMPRegionAverage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrSelectorForA2.SetParameter(New RParameter("a2", 0))
        ucrSelectorForA2.SetParameterIsrfunction()
        ucrSelectorForA2.ucrAvailableDataFrames.lblDataFrame.Text = "Indices Data Frame:"

        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.Selector = ucrSelectorForA2
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True

        ucrReceiverYear.SetParameter(New RParameter("year", 2))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorForA2
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True

        ucrReceiverMonth.SetParameter(New RParameter("month", 3))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorForA2
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True

        ucrSelectorForA3.SetParameter(New RParameter("a3", 4))
        ucrSelectorForA3.SetParameterIsRFunction()
        ucrSelectorForA3.lblDataFrame.Text = "Variogram Data Frame:"

        ucrNudNYE.SetParameter(New RParameter("nye", 11))
        ucrNudNYE.SetMinMax(2000, 2020) ' TODO: how to set as current year - 1
        'ucrNudNYE.SetRDefault(2010) 

        ucrInputUNCode.SetParameter(New RParameter("uncode", 12))
        ucrInputUNCode.SetValidationTypeAsNumeric(dcmMin:=0)
        ucrInputUNCode.AddQuotesIfUnrecognised = False

        ' add in label parameter and ne parameter

        ucrInputResolution.SetParameter(New RParameter("res", 14))
        dctResolution.Add("0.1", 0.1)
        dctResolution.Add("0.25", 0.25)
        dctResolution.Add("0.5", 0.5)
        dctResolution.Add("1", 1)
        dctResolution.Add("2", 2)
        ucrInputResolution.SetItems(dctResolution)
        ucrInputResolution.SetDropDownStyleAsNonEditable()

        ucrChkOutputGridSquareData.SetParameter(New RParameter("igrid", 15))
        ucrChkOutputGridSquareData.SetText("Output Grid Square Data")
        ucrChkOutputGridSquareData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOutputGridSquareData.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        clsBaseFunction = New RFunction
        clsNCMPFunction = New RFunction

        ucrSelectorForA2.Reset()
        ucrSelectorForA3.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrInputUNCode.Reset()
        ucrInputUNCode.SetName("")
        ucrInputResolution.SetName(1)
        bResetSubdialog = True
        bSubDialogOKEnabled = False

        clsBaseFunction.SetRCommand("data_book$import_data")
        clsBaseFunction.AddParameter("data_tables", clsRFunctionParameter:=clsNCMPFunction)
        ' the "name" of this function (clsNCMPFunction) is the value in the ucrInput box
        clsNCMPFunction.SetRCommand("p4_region_average")
        clsNCMPFunction.AddParameter("nye", 2020, iPosition:=11)
        clsNCMPFunction.AddParameter("res", 1, iPosition:=14)
        clsNCMPFunction.SetAssignTo("region_average_dfs")
        ucrBase.clsRsyntax.SetBaseRFunction(clsBaseFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        SetRCode(Me, clsNCMPFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverStation.IsEmpty OrElse ucrReceiverYear.IsEmpty OrElse ucrReceiverMonth.IsEmpty OrElse ucrNudNYE.GetText = "" OrElse ucrInputUNCode.IsEmpty OrElse Not bSubDialogOKEnabled Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub cmdStationMetadata_click(sender As Object, e As EventArgs) Handles cmdStationMetadata.Click
        sdgClimaticNCMPMetadata.SetRFunction(clsNCMPFunction, bReset:=bResetSubdialog)
        bResetSubdialog = True
        sdgClimaticNCMPMetadata.ShowDialog()
        bSubDialogOKEnabled = sdgClimaticNCMPMetadata.bOKEnabled
        TestOkEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrNudNYE.ControlContentsChanged, ucrInputUNCode.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class