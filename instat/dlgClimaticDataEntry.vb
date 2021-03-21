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
Imports RDotNet
Imports unvell.ReoGrid
Public Class dlgClimaticDataEntry
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsClimaticDataEntry As RFunction
    'Public dfTemp As DataFrame
    Private Sub dlgClimaticDataEntry_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub
    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 359

        ucrSelectorClimaticDataEntry.SetParameter(New RParameter("data_name", 0))
        ucrSelectorClimaticDataEntry.SetParameterIsString()

        ucrReceiverStation.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.SetParameter(New RParameter("station_col", 1))
        ucrReceiverStation.SetParameterIsRFunction()
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Factors"

        ucrInputSelectStation.SetParameter(New RParameter("left", 2))
        ucrInputSelectStation.SetFactorReceiver(ucrReceiverStation)
        ucrInputSelectStation.SetItems()
        'ucrInputFactorLevels.AddQuotesIfUnrecognised = False
        ucrInputSelectStation.strQuotes = ""

        ucrDateTimePickerStartingDate.SetParameter(New RParameter(""))
        ucrDateTimePickerStartingDate.SetParameterIsRDate()

        ucrReceiverDate.SetParameter(New RParameter("date_col", 3))
        ucrReceiverDate.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.SetIncludedDataTypes({"Date"})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.SetParameterIsRFunction()
        ucrReceiverDate.strSelectorHeading = "Date"

        ucrReceiverElements.SetParameter(New RParameter("element_cols", 4))
        ucrReceiverElements.Selector = ucrSelectorClimaticDataEntry
        ucrReceiverElements.SetParameterIsRFunction()
        ucrReceiverElements.strSelectorHeading = "Numerics"
        ucrReceiverElements.SetIncludedDataTypes({"numeric"})
        ucrReceiverElements.SetClimaticType("element")
        ucrReceiverElements.bAutoFill = True

        ucrPnlOptions.AddRadioButton(rdoDaily)
        ucrPnlOptions.AddRadioButton(rdoMonthly)

    End Sub
    Private Sub SetDefaults()
        clsClimaticDataEntry = New RFunction

        ucrSelectorClimaticDataEntry.Reset()
        ucrReceiverElements.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetBaseRFunction(clsClimaticDataEntry)
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ' SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub
    Private Sub TestOkEnabled()
        If (Not ucrReceiverStation.IsEmpty AndAlso Not ucrInputSelectStation.IsEmpty AndAlso Not ucrReceiverDate.IsEmpty AndAlso Not ucrReceiverElements.IsEmpty) Then
            ucrBase.OKEnabled(True)
            'cmdEnterData.Enabled = True
        Else
            ucrBase.OKEnabled(False)
            'cmdEnterData.Enabled = False
        End If
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub cmdEnterData_Click(sender As Object, e As EventArgs) Handles cmdEnterData.Click
        sdgClimaticDataEntry.Setup(ucrReceiverStation.GetVariableNames(bWithQuotes:=False),
                                   ucrReceiverDate.GetVariableNames(bWithQuotes:=False),
                                   ucrReceiverElements.GetVariableNamesList(bWithQuotes:=False).ToList,
                                   ucrInputSelectStation.GetValue(),
                                   ucrDateTimePickerStartingDate.DateValue,
                                   GetDataFrame(), ucrSelectorClimaticDataEntry.strCurrentDataFrame)
        sdgClimaticDataEntry.ShowDialog()
    End Sub

    Private Function GetDataFrame() As DataFrame
        Dim dfTemp As DataFrame = Nothing
        Dim clsGetDataFrame As New RFunction
        Dim expTemp As SymbolicExpression

        If frmMain.clsRLink.bInstatObjectExists AndAlso frmMain.clsRLink.GetDataFrameCount() > 0 Then
            clsGetDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_entry_data")
            clsGetDataFrame.AddParameter("data_name", Chr(34) & ucrSelectorClimaticDataEntry.strCurrentDataFrame & Chr(34), iPosition:=0)
            clsGetDataFrame.AddParameter("station", ucrReceiverStation.GetVariableNames, iPosition:=1)
            clsGetDataFrame.AddParameter("date", ucrReceiverDate.GetVariableNames, iPosition:=2)
            clsGetDataFrame.AddParameter("elements", ucrReceiverElements.GetVariableNames(), iPosition:=3)
            clsGetDataFrame.AddParameter("station_name", Chr(34) & ucrInputSelectStation.GetValue() & Chr(34), iPosition:=4)
            clsGetDataFrame.AddParameter("start_date", clsRFunctionParameter:=ucrDateTimePickerStartingDate.ValueAsRDate(), iPosition:=5)
            ' clsGetDataFrame.AddParameter("end_date", Chr(34) & ucrSelectorClimaticDataEntry.strCurrentDataFrame & Chr(34))
            expTemp = frmMain.clsRLink.RunInternalScriptGetValue(clsGetDataFrame.ToScript(), bSilent:=True)
            dfTemp = expTemp.AsDataFrame()

        End If
        Return dfTemp
    End Function

    Private Sub ucrReceiverStation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlValueChanged, ucrInputSelectStation.ControlValueChanged, ucrReceiverDate.ControlValueChanged, ucrReceiverElements.ControlValueChanged
        TestOkEnabled()
    End Sub
End Class