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
        UpdateParameters()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()

        ucrPnlReshapeClimaticData.AddRadioButton(rdoYear)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoMonth)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoDay)

        ucrSelectorReshapeClimaticData.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrSelectorReshapeClimaticData.SetParameterIsrfunction()


        ucrReceiverStation.Selector = ucrSelectorReshapeClimaticData

        ucrReceiverFirstYear.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverLastYear.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverYear.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverYearTwo.Selector = ucrSelectorReshapeClimaticData

        ucrReceiverFirstMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverLastMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverMonth.Selector = ucrSelectorReshapeClimaticData
        ucrReceiverMonthTwo.Selector = ucrSelectorReshapeClimaticData

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

        'ucrReceiverDayofYear.SetParameter(New RParameter("day", 1))
        'ucrReceiverDayofYear.SetParameterIsString()
        'ucrReceiverDayofYear.bAutoFill = True

        'ucrReceiverMonth.SetParameter(New RParameter("month", 2))
        'ucrReceiverMonth.SetParameterIsString()
        'ucrReceiverMonth.bAutoFill = True

        ucrReceiverStation.SetParameter(New RParameter("sortcols", 6))
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.bAutoFill = True

        'rdoMonth
        'ucrReceiverYear.SetParameter(New RParameter("year", 3))
        'ucrReceiverYear.SetParameterIsString()
        'ucrReceiverYear.bAutoFill = True

        'ucrReceiverDayofMonth.SetParameter(New RParameter("day", 1))
        'ucrReceiverDayofMonth.SetParameterIsString()
        'ucrReceiverDayofMonth.bAutoFill = True

        ucrReceiverFirstMonth.SetParameter(New RParameter("first", 4))
        ucrReceiverFirstMonth.SetParameterIsString()
        ucrReceiverFirstMonth.bAutoFill = True

        ucrReceiverLastMonth.SetParameter(New RParameter("last", 5))
        ucrReceiverLastMonth.SetParameterIsString()
        ucrReceiverLastMonth.bAutoFill = True

        'rdoDay
        'ucrReceiverYearTwo.SetParameter(New RParameter("year", 3))
        'ucrReceiverYearTwo.SetParameterIsString()
        'ucrReceiverYearTwo.bAutoFill = True

        ucrReceiverFirstDay.SetParameter(New RParameter("first", 4))
        ucrReceiverFirstDay.SetParameterIsString()
        ucrReceiverFirstDay.bAutoFill = True

        ucrReceiverLastDay.SetParameter(New RParameter("last", 5))
        ucrReceiverLastDay.SetParameterIsString()
        ucrReceiverLastDay.bAutoFill = True

        'ucrReceiverMonthTwo.SetParameter(New RParameter("month", 2))
        'ucrReceiverMonthTwo.SetParameterIsString()
        'ucrReceiverMonthTwo.bAutoFill = True

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverFirstYear, {rdoYear}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverLastYear, {rdoYear}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverMonth, {rdoYear}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverDayofYear, {rdoYear}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverYear, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverFirstMonth, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverLastMonth, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverDayofMonth, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverYearTwo, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverMonthTwo, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverFirstDay, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverLastDay, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoYear, "year", Chr(34) & "columns" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoYear, "month", Chr(34) & "columns" & Chr(34), False)
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoYear, "day", Chr(34) & "columns" & Chr(34), False)

        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoMonth, "month", Chr(34) & "columns" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoMonth, "year", Chr(34) & "columns" & Chr(34), False)
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoMonth, "day", Chr(34) & "columns" & Chr(34), False)

        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoDay, "day", Chr(34) & "columns" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoDay, "month", Chr(34) & "columns" & Chr(34), False)
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoDay, "year", Chr(34) & "columns" & Chr(34), False)

        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrReceiverFirstYear.SetLinkedDisplayControl(lblYearFirst)
        ucrReceiverLastYear.SetLinkedDisplayControl(lblYearLast)
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)
        ucrReceiverDayofYear.SetLinkedDisplayControl(lblDayofYear)

        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverFirstMonth.SetLinkedDisplayControl(lblMonthFirst)
        ucrReceiverLastMonth.SetLinkedDisplayControl(lblMonthLast)
        ucrReceiverDayofMonth.SetLinkedDisplayControl(lblDayofMonth)

        ucrReceiverYearTwo.SetLinkedDisplayControl(lblYearTwo)
        ucrReceiverMonthTwo.SetLinkedDisplayControl(lblMonthTwo)
        ucrReceiverFirstDay.SetLinkedDisplayControl(lblDayFirst)
        ucrReceiverLastDay.SetLinkedDisplayControl(lblDayLast)

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
        rdoYear.Enabled = True

        clsGridtoDataFunc.SetAssignTo(ucrNewDFName.GetText, strTempDataframe:=ucrSelectorReshapeClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsGridtoDataFunc.AddParameter("year", Chr(34) & "columns" & Chr(34), iPosition:=3)

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
            If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverFirstMonth.IsEmpty AndAlso Not ucrReceiverLastMonth.IsEmpty AndAlso Not ucrReceiverDayofMonth.IsEmpty AndAlso ucrNewDFName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoDay.Checked Then
            If Not ucrReceiverYearTwo.IsEmpty AndAlso Not ucrReceiverMonthTwo.IsEmpty AndAlso Not ucrReceiverFirstDay.IsEmpty AndAlso Not ucrReceiverLastDay.IsEmpty AndAlso ucrNewDFName.IsComplete Then
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
        UpdateParameters()
    End Sub

    Private Sub UpdateParameters()

        If rdoYear.Checked Then
            clsGridtoDataFunc.AddParameter("year", Chr(34) & "columns" & Chr(34), iPosition:=3)
            clsGridtoDataFunc.AddParameter("month", ucrReceiverMonth.GetVariableNames, iPosition:=2)
            clsGridtoDataFunc.AddParameter("day", ucrReceiverDayofYear.GetVariableNames, iPosition:=1)
        End If

        If rdoMonth.Checked Then
            clsGridtoDataFunc.AddParameter("month", Chr(34) & "columns" & Chr(34), iPosition:=2)
            clsGridtoDataFunc.AddParameter("year", ucrReceiverYear.GetVariableNames, iPosition:=3)
            clsGridtoDataFunc.AddParameter("day", ucrReceiverDayofMonth.GetVariableNames, iPosition:=1)
        End If

        If rdoDay.Checked Then
            clsGridtoDataFunc.AddParameter("day", Chr(34) & "columns" & Chr(34), iPosition:=1)
            clsGridtoDataFunc.AddParameter("month", ucrReceiverMonthTwo.GetVariableNames, iPosition:=2)
            clsGridtoDataFunc.AddParameter("year", ucrReceiverYearTwo.GetVariableNames, iPosition:=3)
        End If

    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverFirstYear.ControlContentsChanged, ucrReceiverLastYear.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverFirstMonth.ControlContentsChanged, ucrReceiverLastMonth.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverMonthTwo.ControlContentsChanged, ucrReceiverDayofYear.ControlContentsChanged, ucrReceiverDayofMonth.ControlContentsChanged, ucrReceiverFirstDay.ControlContentsChanged, ucrReceiverLastDay.ControlContentsChanged
        TestOkEnabled()
    End Sub

End Class
