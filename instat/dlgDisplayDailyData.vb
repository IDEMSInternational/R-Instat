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
    Private clsDisplayDailyTable, clsDisplayDailyGraphFunction As New RFunction

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
        Dim dctSummary As New Dictionary(Of String, String)
        Dim dctMissingvalues As New Dictionary(Of String, String)
        Dim dctTracevalues As New Dictionary(Of String, String)
        Dim dctZeroValues As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorDisplayDailyClimaticData.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDisplayDailyClimaticData.SetParameterIsString()

        ucrReceiverStations.SetParameter(New RParameter("station_col", 0, bNewIncludeArgumentName:=False))
        ucrReceiverStations.SetParameterIsString()
        ucrReceiverStations.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverStations.SetClimaticType("station")
        ucrReceiverStations.bAutoFill = True
        ucrReceiverStations.SetMeAsReceiver()

        ucrReceiverYear.SetParameter(New RParameter("year_col", 3))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorDisplayDailyClimaticData
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})

        ucrReceiverDate.SetParameter(New RParameter("date_col", 2))
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

        ucrReceiverElements.SetParameter(New RParameter("climatic_element", 1))
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

        ucrInputComboMonStat.SetParameter(New RParameter("monstats", 8))
        dctSummary.Add("min", Chr(34) & "min" & Chr(34))
        dctSummary.Add("mean", Chr(34) & "mean" & Chr(34))
        dctSummary.Add("median", Chr(34) & "median" & Chr(34))
        dctSummary.Add("max", Chr(34) & "max" & Chr(34))
        dctSummary.Add("IQR", Chr(34) & "IQR" & Chr(34))
        dctSummary.Add("sum", Chr(34) & "sum" & Chr(34))
        ucrInputComboMonStat.SetItems(dctSummary)

        ucrChkMissing.SetParameter(ucrInputComboMissing.GetParameter)
        ucrChkMissing.AddParameterPresentCondition(True, "Misscode")
        ucrChkMissing.AddParameterPresentCondition(False, "Misscode", False)
        ucrChkMissing.SetText("Missing Values")
        ucrInputComboMissing.SetParameter(New RParameter("Misscode", 5))
        dctMissingvalues.Add("-", Chr(34) & "-" & Chr(34))
        ucrInputComboMissing.SetItems(dctMissingvalues)
        ucrInputComboMissing.bAllowNonConditionValues = True

        ucrChkTrace.SetParameter(ucrInputComboTrace.GetParameter())
        ucrChkTrace.AddParameterPresentCondition(True, "Tracecode")
        ucrChkTrace.AddParameterPresentCondition(False, "Tracecode", False)
        ucrChkTrace.SetText("Trace Values")
        ucrInputComboTrace.SetParameter(New RParameter("Tracecode", 6))
        dctTracevalues.Add("tr", Chr(34) & "tr" & Chr(34))
        ucrInputComboTrace.SetItems(dctTracevalues)
        ucrInputComboTrace.bAllowNonConditionValues = True

        ucrChkZero.SetParameter(ucrInputComboZero.GetParameter())
        ucrChkZero.AddParameterPresentCondition(True, "Zerocode")
        ucrChkZero.AddParameterPresentCondition(False, "Zerocode", False)
        ucrChkZero.SetText("Zero Values")
        ucrInputComboZero.SetParameter(New RParameter("Zerocode", 7))
        dctZeroValues.Add("--", Chr(34) & "--" & Chr(34))
        ucrInputComboZero.SetItems(dctZeroValues)
        ucrInputComboZero.bAllowNonConditionValues = True

        ucrSaveGraph.SetPrefix("Graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames)
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrPnlFrequencyDisplay.AddRadioButton(rdoTable)
        ucrPnlFrequencyDisplay.AddRadioButton(rdoGraph)
        ucrPnlFrequencyDisplay.AddFunctionNamesCondition(rdoGraph, frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")
        ucrPnlFrequencyDisplay.AddFunctionNamesCondition(rdoTable, frmMain.clsRLink.strInstatDataObject & "$display_daily_table")
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrNudUpperYaxis, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=100)
        'ucrPnlFrequencyDisplay.AddToLinkedControls(ucrReceiverDayOfYear, {rdoGraph}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls(ucrInputComboMonStat, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputComboMissing, ucrChkMissing}, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputComboTrace, ucrChkTrace}, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrequencyDisplay.AddToLinkedControls({ucrInputComboZero, ucrChkZero}, {rdoTable}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkMissing.AddToLinkedControls({ucrInputComboMissing}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkTrace.AddToLinkedControls({ucrInputComboTrace}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkZero.AddToLinkedControls({ucrInputComboZero}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboMonStat.SetLinkedDisplayControl(lblMonStat)
        'ucrReceiverDayOfYear.SetLinkedDisplayControl(lblDayOfTheYear)
        ucrNudUpperYaxis.SetLinkedDisplayControl(grpGraph)
    End Sub

    Private Sub SetDefaults()
        clsDisplayDailyTable = New RFunction
        clsDisplayDailyGraphFunction = New RFunction

        ucrSelectorDisplayDailyClimaticData.Reset()
        ucrReceiverStations.SetMeAsReceiver()

        clsDisplayDailyGraphFunction.AddParameter("rug_colour", Chr(34) & "red" & Chr(34))
        clsDisplayDailyGraphFunction.AddParameter("bar_colour", Chr(34) & "blue" & Chr(34))
        clsDisplayDailyGraphFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempTable:="last_graph")
        clsDisplayDailyTable.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$display_daily_table")
        clsDisplayDailyTable.AddParameter("monstats", Chr(34) & "sum" & Chr(34), iPosition:=8)
        clsDisplayDailyTable.AddParameter("Misscode", Chr(34) & "-" & Chr(34), iPosition:=5)
        clsDisplayDailyTable.AddParameter("Tracecode", Chr(34) & "tr" & Chr(34), iPosition:=6)
        clsDisplayDailyTable.AddParameter("Zerocode", Chr(34) & "--" & Chr(34), iPosition:=7)
        clsDisplayDailyGraphFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$display_daily_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDisplayDailyTable)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverYear.AddAdditionalCodeParameterPair(clsDisplayDailyTable, New RParameter("year_col", 3), iAdditionalPairNo:=1)
        ucrReceiverElements.AddAdditionalCodeParameterPair(clsDisplayDailyTable, New RParameter("climatic_element", 1), iAdditionalPairNo:=1)
        ucrReceiverStations.AddAdditionalCodeParameterPair(clsDisplayDailyTable, New RParameter("station_col", 4), iAdditionalPairNo:=1)
        'ucrSelectorDisplayDailyClimaticData.AddAdditionalCodeParameterPair(clsDisplayDailyTable, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrReceiverDate.AddAdditionalCodeParameterPair(clsDisplayDailyTable, New RParameter("date_col", 2), iAdditionalPairNo:=1)

        ucrChkTrace.SetRCode(clsDisplayDailyTable, bReset)
        ucrChkZero.SetRCode(clsDisplayDailyTable, bReset)
        ucrChkMissing.SetRCode(clsDisplayDailyTable, bReset)
        ucrInputComboZero.SetRCode(clsDisplayDailyTable, bReset)
        ucrInputComboTrace.SetRCode(clsDisplayDailyTable, bReset)
        ucrInputComboMissing.SetRCode(clsDisplayDailyTable, bReset)
        ucrInputComboMonStat.SetRCode(clsDisplayDailyTable, bReset)
        ucrReceiverDate.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverStations.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverDayOfYear.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverYear.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrSelectorDisplayDailyClimaticData.SetRCode(clsDisplayDailyTable, bReset)
        ucrInputRugColour.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrInputBarColour.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrNudUpperYaxis.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrReceiverElements.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrSaveGraph.SetRCode(clsDisplayDailyGraphFunction, bReset)
        ucrPnlFrequencyDisplay.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoGraph.Checked AndAlso (Not ucrReceiverDate.IsEmpty OrElse Not ucrReceiverDayOfYear.IsEmpty OrElse Not ucrReceiverStations.IsEmpty) AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty AndAlso ucrNudUpperYaxis.GetText <> "" AndAlso Not ucrInputRugColour.IsEmpty AndAlso Not ucrInputBarColour.IsEmpty Then
            ucrBase.OKEnabled(True)
        ElseIf rdoTable.Checked AndAlso Not ucrReceiverElements.IsEmpty AndAlso Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(True)
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
        Else
            ucrBase.clsRsyntax.iCallType = 2
            ucrBase.clsRsyntax.SetBaseRFunction(clsDisplayDailyTable)
        End If
    End Sub

    Private Sub ucrSelectorDisplayDailyClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDisplayDailyClimaticData.ControlValueChanged
        clsDisplayDailyGraphFunction.AddParameter("data_name", Chr(34) & ucrSelectorDisplayDailyClimaticData.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
    End Sub

    Private Sub ucrReceiverDate_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDate.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverStations.ControlContentsChanged, ucrReceiverDayOfYear.ControlContentsChanged, ucrNudUpperYaxis.ControlContentsChanged, ucrInputRugColour.ControlContentsChanged, ucrInputBarColour.ControlContentsChanged, ucrPnlFrequencyDisplay.ControlContentsChanged, ucrReceiverElements.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class