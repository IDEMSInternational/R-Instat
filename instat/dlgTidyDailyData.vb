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

Public Class dlgTidyDailyData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsTidyClimaticFunction As New RFunction

    Private iTextBoxMaxY As Integer
    Private iReceiverMaxY As Integer
    Private iReceiverLabelMaxY As Integer

    Private Sub dlgTidyDailyData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            iReceiverMaxY = ucrReceiverStation.Location.Y
            iReceiverLabelMaxY = lblStation.Location.Y
            iTextBoxMaxY = grpElements.Location.Y
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
        ColumnstoStackText()
    End Sub

    Private Sub InitialiseDialog()

        ucrBase.iHelpTopicID = 561
        ucrBase.clsRsyntax.iCallType = 2

        ucrPnlReshapeClimaticData.AddRadioButton(rdoYear)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoMonth)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoDay)

        ucrSelectorTidyDailyData.SetParameter(New RParameter("x", 0))
        ucrSelectorTidyDailyData.SetParameterIsrfunction()


        ucrReceiverStation.Selector = ucrSelectorTidyDailyData
        ucrReceiverMultipleStack.Selector = ucrSelectorTidyDailyData
        ucrReceiverElement.Selector = ucrSelectorTidyDailyData

        ucrReceiverYear.Selector = ucrSelectorTidyDailyData
        ucrReceiverMonth.Selector = ucrSelectorTidyDailyData
        ucrReceiverDayofMonth.Selector = ucrSelectorTidyDailyData

        ucrReceiverMultipleStack.SetParameter(New RParameter("stack_cols", 2))
        ucrReceiverMultipleStack.SetParameterIsString()


        ucrReceiverStation.SetParameter(New RParameter("station", 6))
        ucrReceiverStation.SetParameterIsString()

        ucrReceiverElement.SetParameter(New RParameter("element", 7))
        ucrReceiverElement.SetParameterIsString()

        ucrTextBoxElementName.SetParameter(New RParameter("element_name", 8))
        ucrTextBoxElementName.SetRDefault(Chr(34) & "value" & Chr(34))
        ucrTextBoxElementName.SetValidationTypeAsRVariable()

        'rdoYear
        'TODO; Receivers for Station, Month and Day might be added later for the "Year Columns" format.

        'rdoMonth
        ucrReceiverYear.SetParameter(New RParameter("year", 5))
        ucrReceiverYear.SetParameterIsString()

        ucrReceiverDayofMonth.SetParameter(New RParameter("day", 3))
        ucrReceiverDayofMonth.SetParameterIsString()

        'rdoDay

        ucrReceiverMonth.SetParameter(New RParameter("month", 4))
        ucrReceiverMonth.SetParameterIsString()

        'Checkboxes
        ucrChkIgnoreInvalid.SetParameter(New RParameter("ignore_invalid", 9))
        ucrChkIgnoreInvalid.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkIgnoreInvalid.SetRDefault("FALSE")
        ucrChkIgnoreInvalid.SetText("Ignore values on invalid dates")

        ucrChkSilent.SetParameter(New RParameter("silent", 10))
        ucrChkSilent.SetValuesCheckedAndUnchecked("FALSE", "TRUE")
        ucrChkSilent.SetRDefault("FALSE")
        ucrChkSilent.SetText("Display details of warnings and errors")

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverDayofMonth, {rdoMonth}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverMonth, {rdoDay}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddToLinkedControls(ucrReceiverYear, {rdoDay, rdoMonth}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoYear, "format", Chr(34) & "years" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoMonth, "format", Chr(34) & "months" & Chr(34))
        ucrPnlReshapeClimaticData.AddParameterValuesCondition(rdoDay, "format", Chr(34) & "days" & Chr(34))

        ucrReceiverStation.SetLinkedDisplayControl(lblStation)

        ucrReceiverYear.SetLinkedDisplayControl(lblYear)
        ucrReceiverDayofMonth.SetLinkedDisplayControl(lblDayofMonth)

        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        ucrReceiverElement.SetLinkedDisplayControl(lblMultipleElement)
        ucrTextBoxElementName.SetLinkedDisplayControl(lblElementName)

        ucrInputNewDataFrame.SetParameter(New RParameter("new_name", iNewPosition:=12))
        ucrInputNewDataFrame.SetDefaultTypeAsDataFrame()
    End Sub

    Private Sub SetDefaults()
        clsTidyClimaticFunction = New RFunction

        ucrSelectorTidyDailyData.Reset()
        ucrReceiverMultipleStack.SetMeAsReceiver()
        ucrInputNewDataFrame.Reset()

        clsTidyClimaticFunction.AddParameter("format", Chr(34) & "years" & Chr(34), iPosition:=3)

        clsTidyClimaticFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$tidy_climatic_data")
        ucrBase.clsRsyntax.SetBaseRFunction(clsTidyClimaticFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        If bReset Then
            NewDefaultName()
        End If
    End Sub

    Private Sub TestOkEnabled()
        If rdoYear.Checked Then
            If Not ucrReceiverMultipleStack.IsEmpty AndAlso Not ucrInputNewDataFrame.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoMonth.Checked Then
            If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMultipleStack.IsEmpty AndAlso Not ucrReceiverDayofMonth.IsEmpty AndAlso Not ucrInputNewDataFrame.IsEmpty() Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoDay.Checked Then
            If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverMultipleStack.IsEmpty AndAlso Not ucrInputNewDataFrame.IsEmpty() Then
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
        If (Not ucrInputNewDataFrame.bUserTyped) AndAlso ucrSelectorTidyDailyData.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrInputNewDataFrame.SetPrefix(ucrSelectorTidyDailyData.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_tidy")
        End If
    End Sub

    Private Sub ucrPnlReshapeClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlReshapeClimaticData.ControlValueChanged
        UpdateParameters()
        ElementGroupStationLocation()
        ColumnstoStackText()
        ChangeCurrentReceiver()
    End Sub

    Private Sub UpdateParameters()

        If rdoYear.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "years" & Chr(34), iPosition:=1)
        ElseIf rdoMonth.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "months" & Chr(34), iPosition:=1)
        ElseIf rdoDay.Checked Then
            clsTidyClimaticFunction.AddParameter("format", Chr(34) & "days" & Chr(34), iPosition:=1)
        End If

    End Sub

    Private Sub ColumnstoStackText()
        If rdoYear.Checked Then
            lblColumnstoStack.Text = "Year Columns:"
        ElseIf rdoMonth.Checked Then
            lblColumnstoStack.Text = "Month Columns (12):"
        Else
            lblColumnstoStack.Text = "Day Columns (31):"
        End If
    End Sub

    Private Sub ElementGroupStationLocation()
        If rdoYear.Checked Then
            ucrReceiverStation.Location = New Point(ucrReceiverStation.Location.X, iReceiverMaxY / 1.42)
            lblStation.Location = New Point(lblStation.Location.X, iReceiverLabelMaxY / 1.45)
            grpElements.Location = New Point(grpElements.Location.X, iTextBoxMaxY / 1.38)
        Else
            ucrReceiverStation.Location = New Point(ucrReceiverStation.Location.X, iReceiverMaxY)
            lblStation.Location = New Point(lblStation.Location.X, iReceiverLabelMaxY)
            grpElements.Location = New Point(grpElements.Location.X, iTextBoxMaxY)
        End If
    End Sub

    Private Sub ElementAddRemoveParam()
        If Not ucrReceiverElement.IsEmpty Then
            clsTidyClimaticFunction.RemoveParameterByName("element_name")
            ucrTextBoxElementName.Enabled = False
        Else
            clsTidyClimaticFunction.AddParameter("element_name", Chr(34) & ucrTextBoxElementName.GetText & Chr(34), iPosition:=8)
            ucrTextBoxElementName.Enabled = True
        End If
    End Sub

    Private Sub ChangeCurrentReceiver()
        Dim CurrReceiver = ucrSelectorTidyDailyData.CurrentReceiver

        If (CurrReceiver Is ucrReceiverDayofMonth AndAlso Not rdoMonth.Checked) OrElse (CurrReceiver Is ucrReceiverMonth AndAlso Not rdoDay.Checked) Then
            ucrReceiverMultipleStack.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverStation.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverDayofMonth.ControlContentsChanged, ucrPnlReshapeClimaticData.ControlContentsChanged, ucrReceiverMultipleStack.ControlContentsChanged, ucrInputNewDataFrame.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorTidyDailyData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorTidyDailyData.ControlValueChanged
        NewDefaultName()
    End Sub

    Private Sub ucrTextBoxElementName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrTextBoxElementName.ControlValueChanged, ucrReceiverElement.ControlValueChanged
        ElementAddRemoveParam()
    End Sub

End Class
