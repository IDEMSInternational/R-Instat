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

Imports instat
Imports instat.Translations
Public Class dlgDisplayDailyData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSummaryTable, clsDisplayDailyGraph, clsConcat As RFunction

    Private Sub dlgDisplayDailyData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        Dim dctBarColour As New Dictionary(Of String, String)
        Dim dctRugColour As New Dictionary(Of String, String)

        ucrSelectorDisplayDailyClimaticData.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDisplayDailyClimaticData.SetParameterIsString()

        ucrReceiverStations.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True
        ucrReceiverStations.SetMeAsReceiver()

        ucrReceiverStations.SetParameter(New RParameter("station_col", 2))
        ucrReceiverStations.SetParameterIsString()

        ucrReceiverYear.SetParameter(New RParameter("year_col", 3))
        ucrReceiverYear.SetParameterIsString()

        ucrReceiverDayOfYear.SetParameter(New RParameter("doy_col", 5))
        ucrReceiverDayOfYear.SetParameterIsString()

        ucrReceiverYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True

        ucrReceiverDate.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDate.SetParameter(New RParameter("date_col", 1))
        ucrReceiverDate.SetParameterIsString()

        ucrReceiverElements.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverElements.SetParameter(New RParameter("climatic_element", 6))
        ucrReceiverElements.SetParameterIsString()

        ucrNudUpperYaxis.SetParameter(New RParameter("upper_limit", 9))
        ucrNudUpperYaxis.SetMinMax(0, Integer.MaxValue)

        ucrInputBarColour.SetParameter(New RParameter("bar_colour", 7))
        dctBarColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctBarColour.Add("Red", Chr(34) & "red" & Chr(34))
        dctBarColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctBarColour.Add("Green", Chr(34) & "green" & Chr(34))
        dctBarColour.Add("Violet", Chr(34) & "violet" & Chr(34))
        ucrInputBarColour.SetItems(dctBarColour)

        ucrInputRugColour.SetParameter(New RParameter("rug_colour", 8))
        dctRugColour.Add("Blue", Chr(34) & "blue" & Chr(34))
        dctRugColour.Add("Red", Chr(34) & "red" & Chr(34))
        dctRugColour.Add("Yellow", Chr(34) & "yellow" & Chr(34))
        dctRugColour.Add("Green", Chr(34) & "green" & Chr(34))
        dctRugColour.Add("Violet", Chr(34) & "violet" & Chr(34))
        ucrInputRugColour.SetItems(dctRugColour)

        ucrReceiverDayOfYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDayOfYear.SetClimaticType("doy")
        ucrReceiverDayOfYear.bAutoFill = True

        ucrReceiverFactorby.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverFactorby.SetMeAsReceiver()
        ucrReceiverFactorby.SetParameter(New RParameter("x"))
        ucrReceiverFactorby.SetParameterIsRFunction()

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.AddFunctionNamesCondition(rdoGraph, frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")
        ucrPnlFrequencyDisplay.AddFunctionNamesCondition(rdoTable, frmMain.clsRLink.strInstatDataObject & "$summary_table")
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrNudUpperYaxis, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverDayOfYear, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.SetLinkedDisplayControl(lblDayOfTheYear)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverDate, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverStations, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverStations.SetLinkedDisplayControl(lblStation)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverFactorby, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDayOfYear.SetLinkedDisplayControl(lblDayOfTheYear)
        ucrNudUpperYaxis.SetLinkedDisplayControl(grpGraph)
    End Sub

    Private Sub SetDefaults()
        clsSummaryTable = New RFunction
        clsDisplayDailyGraph = New RFunction
        clsConcat = New RFunction

        ucrSelectorDisplayDailyClimaticData.Reset()

        clsDisplayDailyGraph.AddParameter("upper_limit", 50)
        clsDisplayDailyGraph.AddParameter("rug_colour", Chr(34) & "blue" & Chr(34))
        clsDisplayDailyGraph.AddParameter("bar_colour", Chr(34) & "blue" & Chr(34))
        clsConcat.SetRCommand("c")
        clsSummaryTable.AddParameter("summaries", Chr(34) & "sum_label" & Chr(34))
        clsSummaryTable.AddParameter("factors", clsRFunctionParameter:=clsConcat)
        clsSummaryTable.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDisplayDailyGraph.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDisplayDailyGraph)
    End Sub

    Private Sub SetRCodeForControls(bReset As Object)
        ucrReceiverYear.AddAdditionalCodeParameterPair(clsSummaryTable, New RParameter("page_by", 2), 1)
        ucrSelectorDisplayDailyClimaticData.AddAdditionalCodeParameterPair(clsSummaryTable, ucrSelectorDisplayDailyClimaticData.GetParameter, 1)
        ucrReceiverElements.AddAdditionalCodeParameterPair(clsSummaryTable, New RParameter("columns_to_summarise", 1), 1)
        ucrReceiverFactorby.SetRCode(clsConcat, bReset)
        ucrReceiverDate.SetRCode(clsDisplayDailyGraph, bReset)
        ucrReceiverStations.SetRCode(clsDisplayDailyGraph, bReset)
        ucrReceiverDayOfYear.SetRCode(clsDisplayDailyGraph, bReset)
        ucrReceiverYear.SetRCode(clsDisplayDailyGraph, bReset)
        ucrSelectorDisplayDailyClimaticData.SetRCode(clsDisplayDailyGraph, bReset)
        ucrInputRugColour.SetRCode(clsDisplayDailyGraph, bReset)
        ucrInputBarColour.SetRCode(clsDisplayDailyGraph, bReset)
        ucrNudUpperYaxis.SetRCode(clsDisplayDailyGraph, bReset)
        ucrReceiverElements.SetRCode(clsDisplayDailyGraph, bReset)
        ucrPnlFrequencyDisplay.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoGraph.Checked Then
            If (Not ucrReceiverDate.IsEmpty OrElse Not ucrReceiverDayOfYear.IsEmpty OrElse Not ucrReceiverStations.IsEmpty) AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrNudUpperYaxis.GetText <> "" AndAlso Not ucrInputRugColour.IsEmpty AndAlso Not ucrInputBarColour.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            If Not ucrReceiverFactorby.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlFrequencyDisplay_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFrequencyDisplay.ControlValueChanged
        If rdoGraph.Checked Then
            ucrBase.clsRsyntax.iCallType = 3
            ucrBase.clsRsyntax.SetBaseRFunction(clsDisplayDailyGraph)
        Else
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryTable)
        End If
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverStations.ControlContentsChanged, ucrReceiverDayOfYear.ControlContentsChanged, ucrNudUpperYaxis.ControlContentsChanged, ucrInputRugColour.ControlContentsChanged, ucrInputBarColour.ControlContentsChanged, ucrPnlFrequencyDisplay.ControlContentsChanged, ucrReceiverFactorby.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class