' R-Instat
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
Public Class dlgPlotRegion
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = True
    Private clsPlotRegionFunction As RFunction
    Private clsAsDateTimeFunction As RFunction

    Private Sub dlgPlotRegion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3

        ucrReceiverLongitude.SetParameter(New RParameter("lon", 1))
        ucrReceiverLongitude.Selector = ucrSelectorPlotRegion
        ucrReceiverLongitude.SetParameterIsRFunction()

        ucrReceiverLatitude.SetParameter(New RParameter("lat", 2))
        ucrReceiverLatitude.Selector = ucrSelectorPlotRegion
        ucrReceiverLatitude.SetParameterIsRFunction()

        ucrReceiverElement.SetParameter(New RParameter("product", 3))
        ucrReceiverElement.Selector = ucrSelectorPlotRegion
        ucrReceiverElement.SetParameterIsRFunction()

        ucrReceiverDate.SetParameter(New RParameter("time", 4))
        ucrReceiverDate.Selector = ucrSelectorPlotRegion
        ucrReceiverDate.SetParameterIsRFunction()
        ucrReceiverDate.SetIncludedDataTypes({"Date"})
    End Sub

    Private Sub SetDefaults()
        clsPlotRegionFunction = New RFunction
        clsAsDateTimeFunction = New RFunction
        bResetSubdialog = True
        ucrSelectorPlotRegion.Reset()
        ucrReceiverLongitude.SetMeAsReceiver()
        clsPlotRegionFunction.AddParameter("time_point", clsRFunctionParameter:=clsAsDateTimeFunction)

        clsPlotRegionFunction.SetRCommand("plot.region")
        clsAsDateTimeFunction.SetRCommand("as.Date")
        clsAsDateTimeFunction.AddParameter("format", Chr(34) & "%Y-%m-%d" & Chr(34), iPosition:=1)
        dtpDateTimePicker.Value = New DateTime(2015, 1, 1)

        AsDate()
        ucrBase.clsRsyntax.SetBaseRFunction(clsPlotRegionFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBasePlotRegion_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub AsDate()
        clsAsDateTimeFunction.AddParameter("x", Chr(34) & dtpDateTimePicker.Value.Year & "-" & dtpDateTimePicker.Value.Month & "-" & dtpDateTimePicker.Value.Day & Chr(34), iPosition:=0)
    End Sub

    Private Sub dtpDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles dtpDateTimePicker.ValueChanged
        AsDate()
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlotRegion.SetRFunction(clsPlotRegionFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgPlotRegion.ShowDialog()
    End Sub
End Class