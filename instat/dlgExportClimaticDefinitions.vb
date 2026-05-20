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
            clsBuildSummaryLongMonthlyTempFunction, clsBuildSummaryLongAnnualMonthlyTempFunction, clsCollateSummaryDefinitionsFunction As New RFunction

    Private Enum SelectorMode
        SingleReceivers
        MultipleReceivers
    End Enum

    Private CurrentSelectorMode As SelectorMode

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
        SetSelectorMode(SelectorMode.SingleReceivers)
        HideDisplayGroupedControls()
    End Sub

    Private Sub InitialiseDialog()
        ' Selector
        ucrSelectorExportToEPicsa.SetParameter(New RParameter("data_name", 0))
        ucrSelectorExportToEPicsa.SetParameterIsString()
        ucrSelectorExportToEPicsa.Visible = False

        ucrSelectorDataFramesExportToEPicsa.SetParameter(New RParameter("data_name", 0))
        ucrSelectorDataFramesExportToEPicsa.SetLinkedDisplayControl(lblDataframes)
        ucrSelectorDataFramesExportToEPicsa.Visible = True

        ' Main Receivers
        ucrReceiverAnnualRainfallSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverAnnualRainfallSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverAnnualRainfallSummaries.SetParameterIsString()
        ucrReceiverAnnualRainfallSummaries.SetMeAsReceiver()
        ucrReceiverAnnualRainfallSummaries.SetItemType("dataframe")
        ucrReceiverAnnualRainfallSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverAnnualRainfallSummaries.SetLinkedDisplayControl(lblAnnualRainfallSummaries)

        ucrReceiverMonthlyRainfallSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverMonthlyRainfallSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverMonthlyRainfallSummaries.SetParameterIsString()
        ucrReceiverMonthlyRainfallSummaries.SetItemType("dataframe")
        ucrReceiverMonthlyRainfallSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverMonthlyRainfallSummaries.SetLinkedDisplayControl(lblMonthlyRainfallSummaries)

        ucrReceiverAnnualTempSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverAnnualTempSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverAnnualTempSummaries.SetParameterIsString()
        ucrReceiverAnnualTempSummaries.SetItemType("dataframe")
        ucrReceiverAnnualTempSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverAnnualTempSummaries.SetLinkedDisplayControl(lblAnnualTempSummaries)

        ucrReceiverMonthlyTempSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverMonthlyTempSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverMonthlyTempSummaries.SetParameterIsString()
        ucrReceiverMonthlyTempSummaries.SetItemType("dataframe")
        ucrReceiverMonthlyTempSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverMonthlyTempSummaries.SetLinkedDisplayControl(lblMonthlyTempSummaries)

        ucrReceiverAnnualMonthlyTempSummaries.SetParameter(New RParameter("data_name", 0))
        ucrReceiverAnnualMonthlyTempSummaries.Selector = ucrSelectorDataFramesExportToEPicsa
        ucrReceiverAnnualMonthlyTempSummaries.SetParameterIsString()
        ucrReceiverAnnualMonthlyTempSummaries.SetItemType("dataframe")
        ucrReceiverAnnualMonthlyTempSummaries.strSelectorHeading = "Data Sets"
        ucrReceiverAnnualMonthlyTempSummaries.SetLinkedDisplayControl(lblAnnualMonthlyTempSummaries)

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

        ' Annual-Monthly Temperature Products
        ucrReceiverMultipleAnnualMonthlyTemp.SetParameter(New RParameter("definitions", 3))
        ucrReceiverMultipleAnnualMonthlyTemp.Selector = ucrSelectorExportToEPicsa
        ucrReceiverMultipleAnnualMonthlyTemp.SetParameterIsString()
        ucrReceiverMultipleAnnualMonthlyTemp.strSelectorHeading = "Objects"
        ucrReceiverMultipleAnnualMonthlyTemp.SetItemType("object")
        ucrReceiverMultipleAnnualMonthlyTemp.SetLinkedDisplayControl(lblAnnualMonthlyTemp)

        HideDisplayGroupedControls()
    End Sub

    Private Sub SetDefaults()
        clsBuildSummaryLongAnnualRainFunction = New RFunction
        clsBuildSummaryLongMonthlyRainFunction = New RFunction
        clsBuildSummaryLongAnnualTempFunction = New RFunction
        clsBuildSummaryLongMonthlyTempFunction = New RFunction
        clsBuildSummaryLongAnnualMonthlyTempFunction = New RFunction

        ucrSelectorExportToEPicsa.Reset()
        ucrSelectorDataFramesExportToEPicsa.Reset()

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

        clsBuildSummaryLongAnnualMonthlyTempFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$build_summary_long")
        clsBuildSummaryLongAnnualMonthlyTempFunction.AddParameter("time_type", Chr(34) & "annual-monthly" & Chr(34), iPosition:=1)
        clsBuildSummaryLongAnnualMonthlyTempFunction.AddParameter("summary_type", Chr(34) & "Temperature" & Chr(34), iPosition:=2)
        clsBuildSummaryLongAnnualMonthlyTempFunction.SetAssignTo("annual_monthly_temp_longer")

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
        ucrReceiverAnnualMonthlyTempSummaries.SetRCode(clsBuildSummaryLongAnnualMonthlyTempFunction, bReset)

        ucrReceiverMultipleAnnualRainfall.SetRCode(clsBuildSummaryLongAnnualRainFunction, bReset)
        ucrReceiverMultipleAnnualTemp.SetRCode(clsBuildSummaryLongAnnualTempFunction, bReset)
        ucrReceiverMultipleMonthlyRainfall.SetRCode(clsBuildSummaryLongMonthlyRainFunction, bReset)
        ucrReceiverMultipleMonthlyTemp.SetRCode(clsBuildSummaryLongMonthlyTempFunction, bReset)
        ucrReceiverMultipleAnnualMonthlyTemp.SetRCode(clsBuildSummaryLongAnnualMonthlyTempFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOkEnable As Boolean = True
        If ucrReceiverAnnualRainfallSummaries.IsEmpty AndAlso ucrReceiverAnnualTempSummaries.IsEmpty AndAlso
                ucrReceiverMonthlyRainfallSummaries.IsEmpty AndAlso ucrReceiverMonthlyTempSummaries.IsEmpty AndAlso
                ucrReceiverAnnualMonthlyTempSummaries.IsEmpty Then
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

            If Not ucrReceiverAnnualMonthlyTempSummaries.IsEmpty AndAlso ucrReceiverMultipleAnnualMonthlyTemp.IsEmpty Then
                bOkEnable = False
            End If
        End If
        ucrBase.OKEnabled(bOkEnable)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        CheckAndUpdateConnectionStatus()
        SetSelectorMode(SelectorMode.SingleReceivers)
        HideDisplayGroupedControls()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualRainfallSummaries.ControlContentsChanged,
        ucrReceiverAnnualTempSummaries.ControlContentsChanged, ucrReceiverMonthlyRainfallSummaries.ControlContentsChanged,
        ucrReceiverMonthlyTempSummaries.ControlContentsChanged, ucrReceiverAnnualMonthlyTempSummaries.ControlContentsChanged,
        ucrReceiverMultipleAnnualRainfall.ControlContentsChanged, ucrReceiverMultipleAnnualTemp.ControlContentsChanged,
        ucrReceiverMultipleMonthlyRainfall.ControlContentsChanged, ucrReceiverMultipleMonthlyTemp.ControlContentsChanged,
        ucrReceiverMultipleAnnualMonthlyTemp.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub AddRemoveParamsInSummaryDefinitionsFunction()
        AddRemoveParameter(ucrReceiverAnnualRainfallSummaries, clsFunction:=clsBuildSummaryLongAnnualRainFunction, paramName:="annual_rain_summary", iPosition:=0)
        AddRemoveParameter(ucrReceiverAnnualTempSummaries, clsFunction:=clsBuildSummaryLongAnnualTempFunction, paramName:="annual_temp_summary", iPosition:=1)
        AddRemoveParameter(ucrReceiverMonthlyRainfallSummaries, clsFunction:=clsBuildSummaryLongMonthlyRainFunction, paramName:="monthly_rain_summary", iPosition:=2)
        AddRemoveParameter(ucrReceiverMonthlyTempSummaries, clsFunction:=clsBuildSummaryLongMonthlyTempFunction, paramName:="monthly_temp_summary", iPosition:=3)
        AddRemoveParameter(ucrReceiverAnnualMonthlyTempSummaries, clsFunction:=clsBuildSummaryLongAnnualMonthlyTempFunction, paramName:="annual_monthly_temp_summary", iPosition:=4)
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

    Private Sub SetSelectorMode(mode As SelectorMode)
        If CurrentSelectorMode = mode Then
            Exit Sub
        End If

        CurrentSelectorMode = mode

        Select Case mode
            Case SelectorMode.SingleReceivers
                ucrSelectorDataFramesExportToEPicsa.Visible = True
                ucrSelectorExportToEPicsa.Visible = False
            Case SelectorMode.MultipleReceivers
                ucrSelectorDataFramesExportToEPicsa.Visible = False
                ucrSelectorExportToEPicsa.Visible = True
        End Select
    End Sub

    Private Sub SingleReceiver_Click(sender As Object, e As EventArgs) Handles ucrReceiverAnnualRainfallSummaries.Enter,
        ucrReceiverAnnualTempSummaries.Enter, ucrReceiverMonthlyRainfallSummaries.Enter,
        ucrReceiverMonthlyTempSummaries.Enter, ucrReceiverAnnualMonthlyTempSummaries.Enter
        SetSelectorMode(SelectorMode.SingleReceivers)
    End Sub

    Private Sub MultipleReceiver_Click(sender As Object, e As EventArgs) Handles ucrReceiverMultipleAnnualRainfall.Enter,
            ucrReceiverMultipleMonthlyRainfall.Enter, ucrReceiverMultipleAnnualTemp.Enter, ucrReceiverMultipleMonthlyTemp.Enter,
            ucrReceiverMultipleAnnualMonthlyTemp.Enter
        SetSelectorMode(SelectorMode.MultipleReceivers)
    End Sub

    Private Sub HideDisplayGroupedControls()
        grpDefinitionsProducts.Visible = Not (ucrReceiverAnnualRainfallSummaries.IsEmpty AndAlso ucrReceiverMonthlyRainfallSummaries.IsEmpty AndAlso ucrReceiverAnnualTempSummaries.IsEmpty AndAlso ucrReceiverMonthlyTempSummaries.IsEmpty AndAlso ucrReceiverAnnualMonthlyTempSummaries.IsEmpty)
        ucrReceiverMultipleAnnualRainfall.Visible = Not ucrReceiverAnnualRainfallSummaries.IsEmpty
        ucrReceiverMultipleMonthlyRainfall.Visible = Not ucrReceiverMonthlyRainfallSummaries.IsEmpty
        ucrReceiverMultipleAnnualTemp.Visible = Not ucrReceiverAnnualTempSummaries.IsEmpty
        ucrReceiverMultipleMonthlyTemp.Visible = Not ucrReceiverMonthlyTempSummaries.IsEmpty
        ucrReceiverMultipleAnnualMonthlyTemp.Visible = Not ucrReceiverAnnualMonthlyTempSummaries.IsEmpty

        ' Making sure all labels don't appear at once when the group box appears
        lblAnnualRainfall.Visible = ucrReceiverMultipleAnnualRainfall.Visible
        lblMonthlyRainfall.Visible = ucrReceiverMultipleMonthlyRainfall.Visible
        lblAnnualTemp.Visible = ucrReceiverMultipleAnnualTemp.Visible
        lblMonthlyTemp.Visible = ucrReceiverMultipleMonthlyTemp.Visible
        lblAnnualMonthlyTemp.Visible = ucrReceiverMultipleAnnualMonthlyTemp.Visible

    End Sub

    Private Sub CoreControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverAnnualRainfallSummaries.ControlValueChanged,
        ucrReceiverAnnualTempSummaries.ControlValueChanged, ucrReceiverMonthlyRainfallSummaries.ControlValueChanged,
        ucrReceiverMonthlyTempSummaries.ControlValueChanged, ucrReceiverAnnualMonthlyTempSummaries.ControlValueChanged
        AddRemoveParamsInSummaryDefinitionsFunction()
        HideDisplayGroupedControls()
        TestOkEnabled()
    End Sub

End Class
