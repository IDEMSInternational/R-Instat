' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.
Imports instat
Imports instat.Translations
Public Class dlgWaterBalance
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgWaterBalance_Load(sender As Object, e As EventArgs) Handles ucrBase.Load
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
        TestOKEnabled()
        Me.Hide()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 1

        'ucrNud
        ucrNudDecimalPlace.SetParameter(New RParameter("decimal_places", ))
        ucrNudEvaporation.SetParameter(New RParameter("evaporation", ))
        ucrNudMaxCapacity.SetParameter(New RParameter("capacity_max", ))

        'ucrChk
        'ucrChkMonthAbbreviations.SetParameter(New RParameter("", ))
        ucrChkMonthAbbreviations.SetText("Month Abbreviations")

        ucrChkPrintTables.SetParameter(New RParameter("print_tables", ))
        ucrChkPrintTables.SetText("Print Tables")
    End Sub

    'frmMain.FillData("climate_obj$climate_data_objects[[1]]$data")
    'frmMain.FillData("climate_obj$used_data_objects[[1]]$data")

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        clsDefaultFunction.SetRCommand("climate_obj$display_water_balance()")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub txtColunmName_Leave(sender As Object, e As EventArgs) Handles txtColumnName.Leave
        ucrBase.clsRsyntax.AddParameter("col_name", Chr(34) & txtColumnName.Text & Chr(34))
        ' kept this as this for now, not sure what we want from the code with this (i.e., ucrSave eventually? or ucrReceiver? etc)
    End Sub

    Private Sub txtDisplayDayName_Leave(sender As Object, e As EventArgs) Handles txtDisplayDayName.Leave
        ucrBase.clsRsyntax.AddParameter("day_display", txtDisplayDayName.Text)
        ' kept this as this for now, not sure what we want from the code with this (i.e., ucrSave eventually? or ucrReceiver? etc)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    'ControlContentsChanged

End Class