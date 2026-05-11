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
Public Class dlgExportClimaticDefinitions
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsBuildSummaryLongAnnualRainFunction, clsBuildSummaryLongMonthlyRainFunction, clsBuildSummaryLongAnnualTempFunction,
            clsBuildSummaryLongMonthlyTempFunction, clsCollateSummaryDefinitionsFunction As New RFunction

    Private Sub dlgExportClimaticDefinitions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
        CheckAndUpdateConnectionStatus()
        HideDisplayGroupedControls()
    End Sub

    Private Sub InitialiseDialog()
        ' Selector
        ucrSelectorExportToEPicsa.SetParameter(New RParameter("data_name", 0))
        ucrSelectorExportToEPicsa.SetParameterIsString()

        ' Main Receivers
        ucrReceiverAnnualRainfallSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverAnnualRainfallSummaries.Selector = ucrSelectorExportToEPicsa
        ucrReceiverAnnualRainfallSummaries.SetParameterIsString()
        ucrReceiverAnnualRainfallSummaries.SetMeAsReceiver()
        ucrReceiverAnnualRainfallSummaries.SetItemType("dataframe")
        ucrReceiverAnnualRainfallSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverAnnualRainfallSummaries.SetLinkedDisplayControl(lblAnnualRainfallSummaries)

        ucrReceiverMonthlyRainfallSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverMonthlyRainfallSummaries.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMonthlyRainfallSummaries.SetParameterIsString()
        ucrReceiverMonthlyRainfallSummaries.SetItemType("dataframe")
        ucrReceiverMonthlyRainfallSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverMonthlyRainfallSummaries.SetLinkedDisplayControl(lblMonthlyRainfallSummaries)

        ucrReceiverAnnualTempSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverAnnualTempSummaries.Selector = ucrSelectorExportToEPicsa
        ucrReceiverAnnualTempSummaries.SetParameterIsString()
        ucrReceiverAnnualTempSummaries.SetItemType("dataframe")
        ucrReceiverAnnualTempSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverAnnualTempSummaries.SetLinkedDisplayControl(lblAnnualTempSummaries)

        ucrReceiverMonthlyTempSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverMonthlyTempSummaries.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMonthlyTempSummaries.SetParameterIsString()
        ucrReceiverMonthlyTempSummaries.SetItemType("dataframe")
        ucrReceiverMonthlyTempSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverMonthlyTempSummaries.SetLinkedDisplayControl(lblMonthlyTempSummaries)

        ' Annual Rainfall Products
        ucrReceiverMultipleAnnualRainfall.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleAnnualRainfall.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleAnnualRainfall.SetParameterIsString()
        ucrReceiverMultipleAnnualRainfall.strSelectorHeading = "Objects"
        ucrReceiverMultipleAnnualRainfall.SetItemType("object")
        ucrReceiverMultipleAnnualRainfall.SetLinkedDisplayControl(lblAnnualRainfall)

        ' Annual Temperature Products
        ucrReceiverMultipleAnnualTemp.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleAnnualTemp.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleAnnualTemp.SetParameterIsString()
        ucrReceiverMultipleAnnualTemp.strSelectorHeading = "Objects"
        ucrReceiverMultipleAnnualTemp.SetItemType("object")
        ucrReceiverMultipleAnnualTemp.SetLinkedDisplayControl(lblAnnualTemp)

        ' Monthly Rainfall Products
        ucrReceiverMultipleMonthlyRainfall.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleMonthlyRainfall.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleMonthlyRainfall.SetParameterIsString()
        ucrReceiverMultipleMonthlyRainfall.strSelectorHeading = "Objects"
        ucrReceiverMultipleMonthlyRainfall.SetItemType("object")
        ucrReceiverMultipleMonthlyRainfall.SetLinkedDisplayControl(lblMonthlyRainfall)

        ' Monthly Temperature Products
        ucrReceiverMultipleMonthlyTemp.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleMonthlyTemp.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleMonthlyTemp.SetParameterIsString()
        ucrReceiverMultipleMonthlyTemp.strSelectorHeading = "Objects"
        ucrReceiverMultipleMonthlyTemp.SetItemType("object")
        ucrReceiverMultipleMonthlyTemp.SetLinkedDisplayControl(lblMonthlyTemp)

        HideDisplayGroupedControls()
    End Sub

    Private Sub SetDefaults()
        clsBuildSummaryLongAnnualRainFunction = New RFunction
        clsBuildSummaryLongMonthlyRainFunction = New RFunction
        clsBuildSummaryLongAnnualTempFunction = New RFunction
        clsBuildSummaryLongMonthlyTempFunction = New RFunction

        ucrSelectorExportToEPicsa.Reset()

        clsBuildSummaryLongAnnualRainFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongAnnualRainFunction.AddParameter("time_type", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsBuildSummaryLongAnnualRainFunction.AddParameter("summary_type", Chr(34) & "Rain" & Chr(34), iPosition:=2)
        clsBuildSummaryLongAnnualRainFunction.SetAssignTo("annual_rain_longer")

        clsBuildSummaryLongMonthlyRainFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongMonthlyRainFunction.AddParameter("time_type", Chr(34) & "monthly" & Chr(34), iPosition:=1)
        clsBuildSummaryLongMonthlyRainFunction.AddParameter("summary_type", Chr(34) & "Rain" & Chr(34), iPosition:=2)
        clsBuildSummaryLongMonthlyRainFunction.SetAssignTo("monthly_rain_longer")

        clsBuildSummaryLongAnnualTempFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongAnnualTempFunction.AddParameter("time_type", Chr(34) & "annual" & Chr(34), iPosition:=1)
        clsBuildSummaryLongAnnualTempFunction.AddParameter("summary_type", Chr(34) & "Temperature" & Chr(34), iPosition:=2)
        clsBuildSummaryLongAnnualTempFunction.SetAssignTo("annual_temp_longer")

        clsBuildSummaryLongMonthlyTempFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongMonthlyTempFunction.AddParameter("time_type", Chr(34) & "monthly" & Chr(34), iPosition:=1)
        clsBuildSummaryLongMonthlyTempFunction.AddParameter("summary_type", Chr(34) & "Temperature" & Chr(34), iPosition:=2)
        clsBuildSummaryLongMonthlyTempFunction.SetAssignTo("monthly_temp_longer")

        clsCollateSummaryDefinitionsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$collate_summary_definitions")

        HideDisplayGroupedControls()
        AddRemoveParamsInSummaryDefinitionsFunction()
        ucrBase.clsRsyntax.SetBaseRFunction(clsCollateSummaryDefinitionsFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverAnnualRainfallSummaries.SetRCode(clsBuildSummaryLongAnnualRainFunction, bReset)
        ucrReceiverMonthlyRainfallSummaries.SetRCode(clsBuildSummaryLongMonthlyRainFunction, bReset)
        ucrReceiverAnnualTempSummaries.SetRCode(clsBuildSummaryLongAnnualTempFunction, bReset)
        ucrReceiverMonthlyTempSummaries.SetRCode(clsBuildSummaryLongMonthlyTempFunction, bReset)

        ucrReceiverMultipleAnnualRainfall.SetRCode(clsBuildSummaryLongAnnualRainFunction, bReset)
        ucrReceiverMultipleAnnualTemp.SetRCode(clsBuildSummaryLongAnnualTempFunction, bReset)
        ucrReceiverMultipleMonthlyRainfall.SetRCode(clsBuildSummaryLongMonthlyRainFunction, bReset)
        ucrReceiverMultipleMonthlyTemp.SetRCode(clsBuildSummaryLongMonthlyTempFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnable As Boolean = True
        If ucrReceiverAnnualRainfallSummaries.IsEmpty AndAlso ucrReceiverAnnualTempSummaries.IsEmpty AndAlso
                ucrReceiverMonthlyRainfallSummaries.IsEmpty AndAlso ucrReceiverMonthlyTempSummaries.IsEmpty Then
            bOkEnable = False
        Else
            If Not ucrReceiverAnnualRainfallSummaries.IsEmpty AndAlso ucrReceiverMultipleAnnualRainfall.IsEmpty Then
                bOkEnable = False
            End If

            If Not ucrReceiverAnnualTempSummaries.IsEmpty AndAlso ucrReceiverMultipleAnnualTemp.IsEmpty Then
                bOkEnable = False
            End If

            If Not ucrReceiverMonthlyRainfallSummaries.IsEmpty AndAlso ucrReceiverMultipleMonthlyRainfall.IsEmpty Then
                bOkEnable = False
            End If

            If Not ucrReceiverMonthlyTempSummaries.IsEmpty AndAlso ucrReceiverMultipleMonthlyTemp.IsEmpty Then
                bOkEnable = False
            End If
        End If
        ucrBase.OKEnabled(bOkEnable)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs)
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        CheckAndUpdateConnectionStatus()
        HideDisplayGroupedControls()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualRainfallSummaries.ControlContentsChanged,
        ucrReceiverAnnualTempSummaries.ControlContentsChanged, ucrReceiverMonthlyRainfallSummaries.ControlContentsChanged,
        ucrReceiverMonthlyTempSummaries.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AddRemoveParamsInSummaryDefinitionsFunction()
        AddRemoveParameter(ucrReceiverAnnualRainfallSummaries, clsFunction:=clsBuildSummaryLongAnnualRainFunction, paramName:="annual_rain_summary", iPosition:=0)
        AddRemoveParameter(ucrReceiverAnnualTempSummaries, clsFunction:=clsBuildSummaryLongAnnualTempFunction, paramName:="annual_temp_summary", iPosition:=1)
        AddRemoveParameter(ucrReceiverMonthlyRainfallSummaries, clsFunction:=clsBuildSummaryLongMonthlyRainFunction, paramName:="monthly_rain_summary", iPosition:=2)
        AddRemoveParameter(ucrReceiverMonthlyTempSummaries, clsFunction:=clsBuildSummaryLongMonthlyTempFunction, paramName:="monthly_temp_summary", iPosition:=3)
    End Sub

    Private Sub AddRemoveParameter(ucrReceiverSummary As ucrReceiverSingle, clsFunction As RFunction, paramName As String, iPosition As Integer)
        If Not ucrReceiverSummary.IsEmpty Then
            clsCollateSummaryDefinitionsFunction.AddParameter(paramName, clsRFunctionParameter:=clsFunction, iPosition:=iPosition)
        Else
            clsCollateSummaryDefinitionsFunction.RemoveParameterByName(paramName)
        End If
    End Sub

    Private Sub btnConnection_Click(sender As Object, e As EventArgs) Handles btnConnection.Click
        Using dlg As New sdgImportFromClimSoft
            AddHandler dlg.Shown, AddressOf SetEPicsaSubDialogDefaults
            dlg.ShowDialog()
        End Using

        CheckAndUpdateConnectionStatus()
    End Sub

    Private Sub SetEPicsaSubDialogDefaults(sender As Object, e As EventArgs)
        Dim dlg As sdgImportFromClimSoft = DirectCast(sender, sdgImportFromClimSoft)
        'sdgImportFromClimSoft.ucrComboBoxDatabaseName.SetText("")
        dlg.ucrInputDrv.SetText("RPostgres::Postgres()")
        dlg.ucrTxtHost.SetText("db.epicsa.idems.international")
        dlg.ucrComboBoxPort.SetText("5432")
    End Sub

    Private Sub CheckAndUpdateConnectionStatus()
        If sdgImportFromClimSoft.IsConnectionIsActive() Then
            lblConnection.Text = "Connected"
            lblConnection.ForeColor = Color.Green
        Else
            lblConnection.Text = "No Connection"
            lblConnection.ForeColor = Color.Red
        End If
    End Sub

    Private Sub HideDisplayGroupedControls()
        grpDefinitionsProducts.Visible = Not (ucrReceiverAnnualRainfallSummaries.IsEmpty AndAlso ucrReceiverMonthlyRainfallSummaries.IsEmpty AndAlso ucrReceiverAnnualTempSummaries.IsEmpty AndAlso ucrReceiverMonthlyTempSummaries.IsEmpty)
        ucrReceiverMultipleAnnualRainfall.Visible = Not ucrReceiverAnnualRainfallSummaries.IsEmpty
        ucrReceiverMultipleMonthlyRainfall.Visible = Not ucrReceiverMonthlyRainfallSummaries.IsEmpty
        ucrReceiverMultipleAnnualTemp.Visible = Not ucrReceiverAnnualTempSummaries.IsEmpty
        ucrReceiverMultipleMonthlyTemp.Visible = Not ucrReceiverMonthlyTempSummaries.IsEmpty

        ' Making sure all labels don't appear at once when the group box appears
        lblAnnualRainfall.Visible = ucrReceiverMultipleAnnualRainfall.Visible
        lblMonthlyRainfall.Visible = ucrReceiverMultipleMonthlyRainfall.Visible
        lblAnnualTemp.Visible = ucrReceiverMultipleAnnualTemp.Visible
        lblMonthlyTemp.Visible = ucrReceiverMultipleMonthlyTemp.Visible
    End Sub

    Private Sub CoreControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualRainfallSummaries.ControlValueChanged,
        ucrReceiverAnnualTempSummaries.ControlValueChanged, ucrReceiverMonthlyRainfallSummaries.ControlValueChanged,
        ucrReceiverMonthlyTempSummaries.ControlValueChanged
        AddRemoveParamsInSummaryDefinitionsFunction()
        HideDisplayGroupedControls()
    End Sub

End Class
