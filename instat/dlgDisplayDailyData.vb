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
Public Class dlgDisplayDailyData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSummaryTableFunction, clsDisplayDailyGraphFunction, clsConcFunction As RFunction

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
        ReopenDialog()
        bReset = False
        TestOkEnabled()
    End Sub

    Private Sub ReopenDialog()
        If rdoGraph.Checked Then
            grpGraph.Visible = True
        End If
    End Sub

    Private Sub InitialiseDialog()
        Dim dctBarColour As New Dictionary(Of String, String)
        Dim dctRugColour As New Dictionary(Of String, String)

        ucrSelectorDisplayDailyClimaticData.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDisplayDailyClimaticData.SetParameterIsString()

        ucrReceiverStations.SetParameter(New RParameter("station_col", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStations.SetParameterIsString()
        ucrReceiverStations.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True
        ucrReceiverStations.SetMeAsReceiver()

        ucrReceiverYear.SetParameter(New RParameter("year_col", 1, bNewIncludeArgumentName:=False))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})

        ucrReceiverMonth.SetParameter(New RParameter("month_col", 2, bNewIncludeArgumentName:=False))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True

        ucrReceiverDay.SetParameter(New RParameter("day_col", 3, bNewIncludeArgumentName:=False))
        ucrReceiverDay.SetParameterIsString()
        ucrReceiverDay.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDay.SetClimaticType("day")
        ucrReceiverDay.bAutoFill = True

        ucrReceiverDate.SetParameter(New RParameter("date_col", 1))
        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrReceiverDayOfYear.SetParameter(New RParameter("doy_col", 5))
        ucrReceiverDayOfYear.SetParameterIsString()
        ucrReceiverDayOfYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverDayOfYear.SetClimaticType("doy")
        ucrReceiverDayOfYear.bAutoFill = True

        ucrReceiverElements.SetParameter(New RParameter("climatic_element", 6))
        ucrReceiverElements.SetParameterIsString()
        ucrReceiverElements.Selector = ucrSelectorDisplayDailyClimaticData

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

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.AddFunctionNamesCondition(rdoGraph, frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")
        ucrPnlFrequencyDisplay.AddFunctionNamesCondition(rdoTable, frmMain.clsRLink.strInstatDataObject & "$summary_table")
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrNudUpperYaxis, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=100)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverDayOfYear, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverDate, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDate.SetLinkedDisplayControl(lblDate)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverDay, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverMonth, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDayOfYear.SetLinkedDisplayControl(lblDayOfTheYear)
        ucrReceiverDay.SetLinkedDisplayControl(lblDay)
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)
        ucrNudUpperYaxis.SetLinkedDisplayControl(grpGraph)
    End Sub

    Private Sub SetDefaults()
        clsSummaryTableFunction = New RFunction
        clsDisplayDailyGraphFunction = New RFunction
        clsConcFunction = New RFunction

        ucrSelectorDisplayDailyClimaticData.Reset()
        ucrReceiverStations.SetMeAsReceiver()

        clsConcFunction.SetRCommand("c")
        clsDisplayDailyGraphFunction.AddParameter("rug_colour", Chr(34) & "red" & Chr(34))
        clsDisplayDailyGraphFunction.AddParameter("bar_colour", Chr(34) & "blue" & Chr(34))
        clsSummaryTableFunction.AddParameter("summaries", "sum_label", iPosition:=1)
        clsSummaryTableFunction.AddParameter("n_column_factors", "1", iPosition:=4)
        clsSummaryTableFunction.AddParameter("include_margins", "TRUE", iPosition:=5)
        clsSummaryTableFunction.AddParameter("rnames", "FALSE", iPosition:=6)
        clsSummaryTableFunction.AddParameter("as_html", "TRUE", iPosition:=7)
        clsSummaryTableFunction.AddParameter("stored_results", Chr(34) & "FALSE" & Chr(34), iPosition:=9)
        clsSummaryTableFunction.AddParameter("factors", clsRFunctionParameter:=clsConcFunction, iPosition:=3)
        clsSummaryTableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDisplayDailyGraphFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryTableFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverYear.AddAdditionalCodeParameterPair(clsSummaryTableFunction, New RParameter("page_by", 8), iAdditionalPairNo:=1)
        ucrReceiverYear.AddAdditionalCodeParameterPair(clsConcFunction, New RParameter("year_col", 1, bNewIncludeArgumentName:=False), iAdditionalPairNo:=2)
        ucrSelectorDisplayDailyClimaticData.AddAdditionalCodeParameterPair(clsSummaryTableFunction, ucrSelectorDisplayDailyClimaticData.GetParameter, iAdditionalPairNo:=1)
        ucrReceiverElements.AddAdditionalCodeParameterPair(clsSummaryTableFunction, New RParameter("columns_to_summarise", 1), iAdditionalPairNo:=1)
        ucrReceiverStations.AddAdditionalCodeParameterPair(clsConcFunction, New RParameter("station_col", 0, bNewIncludeArgumentName:=False), iAdditionalPairNo:=1)

        ucrReceiverDay.SetRCode(clsConcFunction, bReset)
        ucrReceiverMonth.SetRCode(clsConcFunction, bReset)
        ucrReceiverDate.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverStations.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverDayOfYear.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverYear.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrSelectorDisplayDailyClimaticData.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrInputRugColour.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrInputBarColour.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrNudUpperYaxis.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverElements.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrPnlFrequencyDisplay.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoGraph.Checked Then
            If (Not ucrReceiverDate.IsEmpty OrElse Not ucrReceiverDayOfYear.IsEmpty OrElse Not ucrReceiverStations.IsEmpty) AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrNudUpperYaxis.GetText <> "" AndAlso Not ucrInputRugColour.IsEmpty AndAlso Not ucrInputBarColour.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoTable.Checked Then
            If Not ucrReceiverElements.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverDay.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
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
            ucrBase.clsRsyntax.SetBaseRFunction(clsDisplayDailyGraphFunction)
        ElseIf rdoTable.Checked Then
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.SetBaseRFunction(clsSummaryTableFunction)
        End If
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverStations.ControlContentsChanged, ucrReceiverDayOfYear.ControlContentsChanged, ucrNudUpperYaxis.ControlContentsChanged, ucrInputRugColour.ControlContentsChanged, ucrInputBarColour.ControlContentsChanged, ucrPnlFrequencyDisplay.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged, ucrReceiverDay.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class