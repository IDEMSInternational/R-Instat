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

Public Class dlgReshapeClimaticData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsGridtoDataFunc As New RFunction


    Private Sub dlgReshapeClimaticData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrPnlReshapeClimaticData.AddRadioButton(rdoYear)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoMonth)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoDay)

        ucrSelectorReshapeClimaticData.SetParameter(New RParameter("x", 0))
        ucrSelectorReshapeClimaticData.SetParameterIsString()


        ucrReceiverStation.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverStationTwo.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverStationThree.Selector = ucrSelectorReshapeClimaticData

        ucrReceiverYear.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverYearTwo.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverYearThree.Selector = ucrSelectorReshapeClimaticData

        ucrReceiverMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverMonthTwo.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverMonthThree.Selector = ucrSelectorReshapeClimaticData

        ucrReceiverDayofYear.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverDayofMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverDayofMonthTwo.Selector = ucrSelectorReshapeClimaticData

        'rdoYear
        ucrReceiverYear.SetParameter(New RParameter("year", 3))
        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.bWithQuotes = False

        ucrReceiverDayofYear.SetParameter(New RParameter("day", 1))
        ucrReceiverDayofYear.SetParameterIsString()
        ucrReceiverDayofYear.bWithQuotes = False
        ucrReceiverDayofYear.bAutoFill = True

        ucrReceiverMonth.SetParameter(New RParameter("month", 2))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.bWithQuotes = False
        ucrReceiverMonth.bAutoFill = True

        ucrReceiverStation.SetParameter(New RParameter("sortcols", 4))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bWithQuotes = False
        ucrReceiverStation.bAutoFill = True

        'rdoMonth
        ucrReceiverYearTwo.SetParameter(New RParameter("year", 3))
        ucrReceiverYearTwo.SetParameterIsString()
        ucrReceiverYearTwo.bWithQuotes = False
        ucrReceiverYearTwo.bAutoFill = True

        ucrReceiverDayofMonth.SetParameter(New RParameter("day", 1))
        ucrReceiverDayofMonth.SetParameterIsString()
        ucrReceiverDayofMonth.bWithQuotes = False
        ucrReceiverDayofMonth.bAutoFill = True

        ucrReceiverMonthTwo.SetParameter(New RParameter("month", 2))
        ucrReceiverMonthTwo.SetParameterIsString()
        ucrReceiverMonthTwo.bWithQuotes = False

        ucrReceiverStationTwo.SetParameter(New RParameter("sortcols", 4))
        ucrReceiverStationTwo.SetParameterIsString()
        ucrReceiverStationTwo.bWithQuotes = False
        ucrReceiverStationTwo.bAutoFill = True

        'rdoDay
        ucrReceiverYearThree.SetParameter(New RParameter("year", 3))
        ucrReceiverYearThree.SetParameterIsString()
        ucrReceiverYearThree.bWithQuotes = False
        ucrReceiverYearThree.bAutoFill = True

        ucrReceiverDayofMonthTwo.SetParameter(New RParameter("day", 1))
        ucrReceiverDayofMonthTwo.SetParameterIsString()
        ucrReceiverDayofMonthTwo.bWithQuotes = False

        ucrReceiverMonthThree.SetParameter(New RParameter("month", 2))
        ucrReceiverMonthThree.SetParameterIsString()
        ucrReceiverMonthThree.bWithQuotes = False
        ucrReceiverMonthThree.bAutoFill = True

        ucrReceiverStationThree.SetParameter(New RParameter("sortcols", 4))
        ucrReceiverStationThree.SetParameterIsString()
        ucrReceiverStationThree.bWithQuotes = False
        ucrReceiverStationThree.bAutoFill = True

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverStation, {rdoYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverStationTwo, {rdoMonth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverStationThree, {rdoDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverStation.SetLinkedDisplayControl(grpYear)
        ucrReceiverStationTwo.SetLinkedDisplayControl(grpMonth)
        ucrReceiverStationThree.SetLinkedDisplayControl(grpDay)

    End Sub

    Private Sub SetDefaults()
        clsGridtoDataFunc = New RFunction

        ucrSelectorReshapeClimaticData.Reset()
        ucrReceiverYear.SetMeAsReceiver()

        clsGridtoDataFunc.SetRCommand("grid2data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsGridtoDataFunc)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoYear.Checked Then
            If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverDayofYear.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoMonth.Checked Then
            If Not ucrReceiverYearTwo.IsEmpty AndAlso Not ucrReceiverMonthTwo.IsEmpty AndAlso Not ucrReceiverDayofMonth.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoDay.Checked Then
            If Not ucrReceiverYearThree.IsEmpty AndAlso Not ucrReceiverMonthThree.IsEmpty AndAlso Not ucrReceiverDayofMonthTwo.IsEmpty Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If

    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlReshapeClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlReshapeClimaticData.ControlValueChanged

        If rdoYear.Checked Then
            clsGridtoDataFunc.AddParameter("year", Chr(34) & "columns" & Chr(34))
        Else
            'clsGridtoDataFunc.RemoveParameterByName("year")
        End If
        If rdoMonth.Checked Then
            clsGridtoDataFunc.AddParameter("month", Chr(34) & "columns" & Chr(34))
        Else

            'clsGridtoDataFunc.RemoveParameterByName("month")
        End If
        If rdoDay.Checked Then
            clsGridtoDataFunc.AddParameter("day", Chr(34) & "columns" & Chr(34))
        Else
            'clsGridtoDataFunc.RemoveParameterByName("day")
        End If
    End Sub

End Class
