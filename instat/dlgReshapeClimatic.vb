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

        ucrSelectorReshapeClimaticData.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrSelectorReshapeClimaticData.SetParameterIsrfunction()


        ucrReceiverStation.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverStationTwo.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverStationThree.Selector = ucrSelectorReshapeClimaticData

        ucrReceiverFirstYear.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverLastYear.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverYearTwo.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverYearThree.Selector = ucrSelectorReshapeClimaticData

        ucrReceiverFirstMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverLastMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverMonthThree.Selector = ucrSelectorReshapeClimaticData

        ucrReceiverDayofYear.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverDayofMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverFirstDay.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverLastDay.Selector = ucrSelectorReshapeClimaticData

        'rdoYear
        ucrReceiverFirstYear.SetParameterIsString()
        ucrReceiverFirstYear.SetParameter(New RParameter("first", 4))
        ucrReceiverFirstYear.bAutoFill = True

        ucrReceiverLastYear.SetParameterIsString()
        ucrReceiverLastYear.SetParameter(New RParameter("last", 5))
        ucrReceiverLastYear.bAutoFill = True

        ucrReceiverDayofYear.SetParameter(New RParameter("day", 1))
        ucrReceiverDayofYear.SetParameterIsString()
        ucrReceiverDayofYear.bAutoFill = True

        ucrReceiverMonth.SetParameter(New RParameter("month", 2))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.bAutoFill = True

        ucrReceiverStation.SetParameter(New RParameter("sortcols", 6))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bAutoFill = True

        'rdoMonth
        ucrReceiverYearTwo.SetParameter(New RParameter("year", 3))
        ucrReceiverYearTwo.SetParameterIsString()
        ucrReceiverYearTwo.bAutoFill = True

        ucrReceiverDayofMonth.SetParameter(New RParameter("day", 1))
        ucrReceiverDayofMonth.SetParameterIsString()
        ucrReceiverDayofMonth.bAutoFill = True

        ucrReceiverFirstMonth.SetParameter(New RParameter("first", 4))
        ucrReceiverFirstMonth.SetParameterIsString()
        ucrReceiverFirstMonth.bAutoFill = True

        ucrReceiverLastMonth.SetParameter(New RParameter("last", 5))
        ucrReceiverLastMonth.SetParameterIsString()
        ucrReceiverLastMonth.bAutoFill = True

        ucrReceiverStationTwo.SetParameter(New RParameter("sortcols", 6))
        ucrReceiverStationTwo.SetParameterIsString()
        ucrReceiverStationTwo.bAutoFill = True

        'rdoDay
        ucrReceiverYearThree.SetParameter(New RParameter("year", 3))
        ucrReceiverYearThree.SetParameterIsString()
        ucrReceiverYearThree.bAutoFill = True

        ucrReceiverFirstDay.SetParameter(New RParameter("first", 4))
        ucrReceiverFirstDay.SetParameterIsString()
        ucrReceiverFirstDay.bAutoFill = True

        ucrReceiverLastDay.SetParameter(New RParameter("last", 5))
        ucrReceiverLastDay.SetParameterIsString()
        ucrReceiverLastDay.bAutoFill = True

        ucrReceiverMonthThree.SetParameter(New RParameter("month", 2))
        ucrReceiverMonthThree.SetParameterIsString()
        ucrReceiverMonthThree.bAutoFill = True

        ucrReceiverStationThree.SetParameter(New RParameter("sortcols", 6))
        ucrReceiverStationThree.SetParameterIsString()
        ucrReceiverStationThree.bAutoFill = True

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverStation, {rdoYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverStationTwo, {rdoMonth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverStationThree, {rdoDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoYear, "year", Chr(34) & "columns" & Chr(34))
        'ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoMonth, "month", Chr(34) & "columns" & Chr(34))
        'ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoDay, "day", Chr(34) & "columns" & Chr(34))

        ucrReceiverStation.SetLinkedDisplayControl(grpYear)
        ucrReceiverStationTwo.SetLinkedDisplayControl(grpMonth)
        ucrReceiverStationThree.SetLinkedDisplayControl(grpDay)

        ucrNewDFName.SetIsComboBox()
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetCheckBoxText("New Data Frame Name")
        ucrNewDFName.SetDataFrameSelector(ucrSelectorReshapeClimaticData.ucrAvailableDataFrames)
        'ucrNewDFName.SetAssignToIfUncheckedValue("last_data_frame")

    End Sub

    Private Sub SetDefaults()
        clsGridtoDataFunc = New RFunction

        ucrSelectorReshapeClimaticData.Reset()
        ucrReceiverFirstYear.SetMeAsReceiver()
        ucrNewDFName.Reset()
        rdoYear.Enabled = False

        clsGridtoDataFunc.SetAssignTo(ucrNewDFName.GetText, strTempDataframe:=ucrSelectorReshapeClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text)

        clsGridtoDataFunc.SetRCommand("grid2data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsGridtoDataFunc)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoYear.Checked Then
            If Not ucrReceiverFirstYear.IsEmpty AndAlso Not ucrReceiverLastYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverDayofYear.IsEmpty AndAlso ucrNewDFName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoMonth.Checked Then
            If Not ucrReceiverYearTwo.IsEmpty AndAlso Not ucrReceiverFirstMonth.IsEmpty AndAlso Not ucrReceiverLastMonth.IsEmpty AndAlso Not ucrReceiverDayofMonth.IsEmpty AndAlso ucrNewDFName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoDay.Checked Then
            If Not ucrReceiverYearThree.IsEmpty AndAlso Not ucrReceiverMonthThree.IsEmpty AndAlso Not ucrReceiverFirstDay.IsEmpty AndAlso Not ucrReceiverLastDay.IsEmpty AndAlso ucrNewDFName.IsComplete Then
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
            clsGridtoDataFunc.AddParameter("year", Chr(34) & "columns" & Chr(34), iPosition:=3)
        Else
            'clsGridtoDataFunc.RemoveParameterByName("year")
        End If

        If rdoMonth.Checked Then
            clsGridtoDataFunc.AddParameter("month", Chr(34) & "columns" & Chr(34), iPosition:=2)
        Else
            'clsGridtoDataFunc.RemoveParameterByName("month")
        End If

        If rdoDay.Checked Then
            clsGridtoDataFunc.AddParameter("day", Chr(34) & "columns" & Chr(34), iPosition:=1)
        Else
            'clsGridtoDataFunc.RemoveParameterByName("day")
        End If

    End Sub

    Private Sub ucrSelector_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorReshapeClimaticData.ControlValueChanged

    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverYearThree.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverMonthThree.ControlContentsChanged, ucrReceiverDayofYear.ControlContentsChanged, ucrReceiverDayofMonth.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class
