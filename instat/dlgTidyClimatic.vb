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

Public Class dlgTidyClimaticData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTidyClimaticFunction As New RFunction

    Private iReceiverMaxY As Integer
    Private iReceiverLabelMaxY As Integer

    Private Sub dlgReshapeClimaticData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iReceiverMaxY = ucrReceiverMultipleStack.Location.Y
            iReceiverLabelMaxY = lblColumnstoStack.Location.Y
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
        ucrBase.clsRsyntax.iCallType = 0

        ucrPnlReshapeClimaticData.AddRadioButton(rdoYear)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoMonth)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoDay)

        ucrSelectorTidyClimaticData.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrSelectorTidyClimaticData.SetParameterIsrfunction()


        ucrReceiverStation.Selector = ucrSelectorTidyClimaticData
        ucrReceiverMultipleStack.Selector = ucrSelectorTidyClimaticData
        ucrReceiverElement.Selector = ucrSelectorTidyClimaticData

        ucrReceiverYear.Selector = ucrSelectorTidyClimaticData
        ucrReceiverYearTwo.Selector = ucrSelectorTidyClimaticData

        ucrReceiverMonth.Selector = ucrSelectorTidyClimaticData
        ucrReceiverMonthTwo.Selector = ucrSelectorTidyClimaticData

        ucrReceiverDayofYear.Selector = ucrSelectorTidyClimaticData
        ucrReceiverDayofMonth.Selector = ucrSelectorTidyClimaticData

        ucrReceiverMultipleStack.SetParameter(New RParameter("stack_cols", 2))
        ucrReceiverMultipleStack.SetParameterIsString()


        ucrReceiverStation.SetParameter(New RParameter("station", 6))
        ucrReceiverStation.SetParameterIsString()

        ucrReceiverElement.SetParameter(New RParameter("element", 7))
        ucrReceiverElement.SetParameterIsString()

        ucrTextBoxElementName.SetParameter(New RParameter("element_name", 8))

        'rdoYear
        ucrReceiverDayofYear.SetParameter(New RParameter("day", 3))
        ucrReceiverDayofYear.SetParameterIsString()

        ucrReceiverMonth.SetParameter(New RParameter("month", 4))
        ucrReceiverMonth.SetParameterIsString()

        'rdoMonth
        ucrReceiverYear.SetParameter(New RParameter("year", 5))
        ucrReceiverYear.SetParameterIsString()

        ucrReceiverDayofMonth.SetParameter(New RParameter("day", 3))
        ucrReceiverDayofMonth.SetParameterIsString()

        'rdoDay
        ucrReceiverYearTwo.SetParameter(New RParameter("year", 5))
        ucrReceiverYearTwo.SetParameterIsString()

        ucrReceiverMonthTwo.SetParameter(New RParameter("month", 4))
        ucrReceiverMonthTwo.SetParameterIsString()

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverMonth, {rdoYear}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverDayofYear, {rdoYear}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverYear, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverDayofMonth, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverYearTwo, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverMonthTwo, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverDayofMonth, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoYear, "format", Chr(34) & "years" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoMonth, "format", Chr(34) & "months" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoDay, "format", Chr(34) & "days" & Chr(34))

        ucrReceiverStation.SetLinkedDisplayControl(lblStation)
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)
        ucrReceiverDayofYear.SetLinkedDisplayControl(lblDayofYear)

        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverDayofMonth.SetLinkedDisplayControl(lblDayofMonth)

        ucrReceiverYearTwo.SetLinkedDisplayControl(lblYearTwo)
        ucrReceiverMonthTwo.SetLinkedDisplayControl(lblMonthTwo)

        ucrReceiverElement.SetLinkedDisplayControl(lblElement)
        ucrTextBoxElementName.SetLinkedDisplayControl(lblElementName)

        ucrNewDFName.SetIsComboBox()
        ucrNewDFName.SetSaveTypeAsDataFrame()
        ucrNewDFName.SetCheckBoxText("New Data Frame Name")
        ucrNewDFName.SetDataFrameSelector(ucrSelectorTidyClimaticData.ucrAvailableDataFrames)
        ucrNewDFName.SetAssignToIfUncheckedValue("last_data_frame")

    End Sub

    Private Sub SetDefaults()
        clsTidyClimaticFunction = New RFunction

        ucrSelectorTidyClimaticData.Reset()
        ucrReceiverStation.SetMeAsReceiver()
        ucrNewDFName.Reset()
        'rdoYear.Enabled = False

        clsTidyClimaticFunction.SetAssignTo(ucrNewDFName.GetText, strTempDataframe:=ucrSelectorTidyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsTidyClimaticFunction.AddParameter("format", Chr(34) & "years" & Chr(34), iPosition:=3)
        clsTidyClimaticFunction.AddParameter("ignore_invalid", "TRUE")

        clsTidyClimaticFunction.SetRCommand("tidy_climatic_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsTidyClimaticFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If rdoYear.Checked Then
            If Not ucrReceiverMultipleStack.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverDayofYear.IsEmpty AndAlso ucrNewDFName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoMonth.Checked Then
            If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMultipleStack.IsEmpty AndAlso Not ucrReceiverDayofMonth.IsEmpty AndAlso ucrNewDFName.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
        If rdoDay.Checked Then
            If Not ucrReceiverYearTwo.IsEmpty AndAlso Not ucrReceiverMonthTwo.IsEmpty AndAlso Not ucrReceiverMultipleStack.IsEmpty AndAlso ucrNewDFName.IsComplete Then
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

    Private Sub NewDefaultName()
        If (Not ucrNewDFName.bUserTyped) AndAlso ucrSelectorTidyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDFName.SetPrefix("tidy_" & ucrSelectorTidyClimaticData.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        End If
    End Sub

    Private Sub ucrPnlReshapeClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlReshapeClimaticData.ControlValueChanged, ucrReceiverMonth.ControlValueChanged, ucrReceiverDayofYear.ControlValueChanged, ucrReceiverMonthTwo.ControlValueChanged, ucrReceiverYear.ControlValueChanged, ucrReceiverYearTwo.ControlValueChanged
        UpdateParameters()
        ShowElementReceivers()
        MultipleStackLocation()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub UpdateParameters()

        clsTidyClimaticFunction.RemoveParameterByName("format")

        If rdoYear.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "years" & Chr(34), iPosition:=1)
        ElseIf rdoMonth.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "months" & Chr(34), iPosition:=1)
        ElseIf rdoDay.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "days" & Chr(34), iPosition:=1)
        End If

    End Sub

    Private Sub ShowElementReceivers()
        If rdoYear.Checked Then
            ucrReceiverElement.Visible = False
            ucrTextBoxElementName.Visible = False
        Else
            ucrReceiverElement.Visible = True
            ucrTextBoxElementName.Visible = True
        End If
    End Sub

    Private Sub MultipleStackLocation()
        If rdoYear.Checked Then
            lblColumnstoStack.Location = New Point(lblColumnstoStack.Location.X, iReceiverLabelMaxY / 1.4)
            ucrReceiverMultipleStack.Location = New Point(ucrReceiverMultipleStack.Location.X, iReceiverMaxY / 1.35)
        Else
            lblColumnstoStack.Location = New Point(lblColumnstoStack.Location.X, iReceiverLabelMaxY)
            ucrReceiverMultipleStack.Location = New Point(ucrReceiverMultipleStack.Location.X, iReceiverMaxY)
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNewDFName.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverMonthTwo.ControlContentsChanged, ucrReceiverDayofYear.ControlContentsChanged, ucrReceiverDayofMonth.ControlContentsChanged, ucrPnlReshapeClimaticData.ControlContentsChanged, ucrReceiverMultipleStack.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorReshapeClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTidyClimaticData.ControlValueChanged
        NewDefaultName()
    End Sub
End Class
