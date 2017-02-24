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

Imports instat.Translations
Public Class dlgMakeDate
    Public clsPaste As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsDateFunction As New RFunction
    Private Sub dlgMakeDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        'helpID
        ucrBase.iHelpTopicID = 461

        'ucrReceiver
        ucrReceiverForDate.Selector = ucrSelectorMakeDate
        ucrReceiverYearTwo.Selector = ucrSelectorMakeDate
        ucrReceiverDayTwo.Selector = ucrSelectorMakeDate
        ucrReceiverYearThree.Selector = ucrSelectorMakeDate
        ucrReceiverMonthThree.Selector = ucrSelectorMakeDate
        ucrReceiverDayThree.Selector = ucrSelectorMakeDate

        'Setting filters
        ucrReceiverForDate.bUseFilteredData = False
        ucrReceiverYearTwo.bUseFilteredData = False
        ucrReceiverDayTwo.bUseFilteredData = False
        ucrReceiverYearThree.bUseFilteredData = False
        ucrReceiverMonthThree.bUseFilteredData = False
        ucrReceiverDayThree.bUseFilteredData = False

        '  ucrReceiverForDate.SetParameter(New RParameter("x", 0))



        ucrChkTwoDigitYear.SetText("2-digit years")
        ucrChkMore.SetText("More")




        'ucrSave Date Column
        ucrSaveDate.SetPrefix("Date")
        ucrSaveDate.SetSaveTypeAsColumn()
        ucrSaveDate.SetDataFrameSelector(ucrSelectorMakeDate.ucrAvailableDataFrames)
        ucrSaveDate.SetLabelText("Save Date:")
        ucrSaveDate.SetIsComboBox()

        ' Single
        ucrPanelDate.AddToLinkedControls(ucrReceiverForDate, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPanelDate.AddToLinkedControls(ucrChkMore, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPanelDate.AddToLinkedControls(ucrInputMonth, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMonth.SetLinkedDisplayControl(lblMonth)
        ucrPanelDate.AddToLinkedControls(ucrInputYear, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputYear.SetLinkedDisplayControl(lblYear)
        ucrPanelDate.AddToLinkedControls(ucrInputDay, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputDay.SetLinkedDisplayControl(lblDay)
        ucrPanelDate.AddToLinkedControls(ucrInputSeparator, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSeparator.SetLinkedDisplayControl(lblSeparator)


        ucrPanelDate.AddToLinkedControls(ucrReceiverYearThree, {rdoYearMonthDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYearThree.SetLinkedDisplayControl(lblYearThree)
        ucrPanelDate.AddToLinkedControls(ucrReceiverMonthThree, {rdoYearMonthDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMonthThree.SetLinkedDisplayControl(lblMonthThree)
        ucrPanelDate.AddToLinkedControls(ucrReceiverDayThree, {rdoYearMonthDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDayThree.SetLinkedDisplayControl(lblDayofMonth)

        ucrPanelDate.AddToLinkedControls(ucrInputYearOption, {rdoYearMonthDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputYearOption.SetLinkedDisplayControl(lblYearOption)
        ucrPanelDate.AddToLinkedControls(ucrInputMonthOption, {rdoYearMonthDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMonthOption.SetLinkedDisplayControl(lblMonthOption)
        ucrPanelDate.AddToLinkedControls(ucrInputDayOption, {rdoYearMonthDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputDayOption.SetLinkedDisplayControl(lblDayOption)

        ucrPanelDate.AddToLinkedControls(ucrReceiverYearTwo, {rdoYearandDayofYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYearTwo.SetLinkedDisplayControl(lblYearThree)
        ucrPanelDate.AddToLinkedControls(ucrReceiverDayTwo, {rdoYearandDayofYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDayTwo.SetLinkedDisplayControl(lblDayofYear)
        ucrPanelDate.AddToLinkedControls(ucrChkTwoDigitYear, {rdoYearandDayofYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPanelDate.AddToLinkedControls(ucrNudCutoff, {rdoYearandDayofYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudCutoff.SetLinkedDisplayControl(lblCutOffTwo)
        ucrPanelDate.AddToLinkedControls(ucrInputComboBoxMonthTwo, {rdoYearandDayofYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ' ucrReceiverForDate.SetLinkedDisplayControl(grpSingleColumn)

        'ucrInputSeparator.SetItems({"/", "-", "_", ".", ",", ";", ":"})
        'ucrInputYearOption.SetItems({"4 Digit", "2 Digit"})
        'ucrInputYear.SetItems({"4 Digit", "2 Digit"})
        'ucrInputMonth.SetItems({"Numerical", "Partial Word", "Full Word"})

        ucrInputYearOption.SetParameter(New RParameter("year_format"))
        Dim dctYearItems As New Dictionary(Of String, String)
        dctYearItems.Add("4 Digit", Chr(34) & "%Y" & Chr(34))
        dctYearItems.Add("2 Digit", Chr(34) & "%y" & Chr(34))
        ucrInputYearOption.SetItems(dctYearItems)

        ucrInputMonthOption.SetParameter(New RParameter("month_format"))
        Dim dctMonthItems As New Dictionary(Of String, String)
        dctMonthItems.Add("Numerical", Chr(34) & "%m" & Chr(34))
        dctMonthItems.Add("Partial Word", Chr(34) & "%b" & Chr(34))
        dctMonthItems.Add("Full Word", Chr(34) & "%B" & Chr(34))
        ucrInputMonthOption.SetItems(dctMonthItems)



        ucrInputDayOption.SetParameter(New RParameter("day_format"))
        Dim dctDayItems As New Dictionary(Of String, String)
        dctDayItems.Add("By Month", Chr(34) & "%d" & Chr(34))
        ucrInputDayOption.SetItems(dctDayItems)


        'ucrInputDay.SetParameter(New RParameter(""))
        'Dim dctDayItemsDOY As New Dictionary(Of String, String)
        'dctDayItemsDOY.Add("By Month", Chr(34) & "%d" & Chr(34))
        'dctDayItemsDOY.Add("By Year", Chr(34) & "%j" & Chr(34))
        'ucrInputDay.SetItems(dctDayItemsDOY)

        ucrInputComboBoxMonthTwo.SetParameter(New RParameter("doy_typical_length"))
        Dim dctMonthTwoItems As New Dictionary(Of String, String)
        dctMonthTwoItems.Add("365/366", Chr(34) & "365/366" & Chr(34))
        dctMonthTwoItems.Add("366", Chr(34) & "366" & Chr(34))
        ucrInputComboBoxMonthTwo.SetItems(dctMonthTwoItems)

        'ucrInputFormat.SetItems({"Year-Month-Day", "Year/Month/Day", "Day-Month-Year"})
        ucrInputFormat.SetParameter(New RParameter("format", 1))
        Dim dctDateFormat As New Dictionary(Of String, String)
        dctDateFormat.Add("Year-Month-Day", Chr(34) & "%Y-%m-%d" & Chr(34))
        dctDateFormat.Add("Year/Month/Day", Chr(34) & "%Y/%m/%d" & Chr(34))
        dctDateFormat.Add("Day-Month-Year", Chr(34) & "%d%m%Y" & Chr(34))
        ucrInputFormat.SetItems(dctDateFormat)

        ucrInputOrigin.SetParameter(New RParameter("origin", 1))
        ucrInputOrigin.SetItems({"Excel", "Gregorian"})
        Dim dctdateorigin As New Dictionary(Of String, String)
        dctdateorigin.Add("excel", Chr(34) & "30-12-1899" & Chr(34))
        dctdateorigin.Add("gregorian", Chr(34) & "01-03-1600" & Chr(34))
        ucrInputOrigin.SetItems(dctdateorigin)

        ' Formats()

    End Sub

    Private Sub SetDefaults()

        'reset
        ucrSaveDate.Reset()
        ucrSelectorMakeDate.Reset()
        ucrInputFormat.Reset()

        clsDateFunction = New RFunction
        clsDateFunction.SetRCommand("as.Date")
        clsDateFunction.AddParameter("x", ucrReceiverForDate.GetVariableNames)
        Formats()

        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveDate.GetText, strTempDataframe:=ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveDate.GetText, bAssignToIsPrefix:=False)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        rdoSingleColumn.Checked = True
        ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverForDate.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub TestOKEnabled()

        If ucrSaveDate.IsComplete Then
            ' we have three radio buttons, so need to define when OK can be enabled for each radio button.
            If rdoSingleColumn.Checked Then
                If Not ucrReceiverForDate.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoYearandDayofYear.Checked Then
                If Not ucrReceiverYearTwo.IsEmpty AndAlso Not ucrReceiverDayTwo.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                If Not ucrReceiverDayThree.IsEmpty AndAlso Not ucrReceiverMonthThree.IsEmpty AndAlso Not ucrReceiverYearThree.IsEmpty Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        SetHistory()
    End Sub

    Private Sub SetHistory()
        If Not ucrInputFormat.cboInput.Items.Contains(ucrInputFormat.GetText) Then
            ucrInputFormat.cboInput.Items.Insert(0, ucrInputFormat.GetText)
        Else
        End If
    End Sub

    'New Column Name
    'Private Sub UcrInputNewColumnName_NameChanged()
    '    'SetAssignTo()
    'End Sub

    'Private Sub SetAssignTo()
    'End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    ' When the ucrReceivers have a change occur
    'Private Sub ucrReceivers_SelectionChanged(sender As Object, e As EventArgs)
    '    ' Formats()
    '    TestOKEnabled()
    'End Sub

    ' When the three radio buttons are checked or unchecked
    'Private Sub rdoSingleColumn_CheckedChanged(sender As Object, e As EventArgs)
    '    SetReceivers()
    '    ' Formats()
    '    TestOKEnabled()
    'End Sub

    'Private Sub rdoSpecifyOrigin_CheckedChanged(sender As Object, e As EventArgs)
    '    'Formats()
    'End Sub

    Private Sub chkMore_CheckedChanged(sender As Object, e As EventArgs)
        'Formats()
        If ucrChkTwoDigitYear.Checked Then
            lblCutOffTwo.Visible = True
            ucrNudCutoff.Visible = True
        Else
            lblCutOffTwo.Visible = False
            ucrNudCutoff.Visible = False
        End If
    End Sub

    'Private Sub ucrInputSpecifyDates_NameChanged()
    '    Formats()
    'End Sub

    'Private Sub ucrSeclectorMakeDate_DataFrameChanged() Handles ucrSelectorMakeDate.DataFrameChanged
    '    Formats()
    '    '  SetAssignTo()
    'End Sub

    Private Sub SetReceivers()
        If rdoSingleColumn.Checked Then
            ucrReceiverForDate.SetMeAsReceiver()
        ElseIf rdoYearandDayofYear.Checked Then
            ucrReceiverYearTwo.SetMeAsReceiver()
        Else
            ucrReceiverYearThree.SetMeAsReceiver()
        End If
    End Sub

    Private Sub Formats()
        If rdoSingleColumn.Checked Then
            clsDateFunction.SetRCommand("as.Date")
            If rdoDefaultFormat.Checked Then

                ucrReceiverForDate.SetIncludedDataTypes({"character", "factor"})
                ucrReceiverForDate.SetParameter(New RParameter("x"))
                ucrReceiverForDate.SetParameterIsRFunction()
            ElseIf rdoSpecifyOrigin.Checked
                clsDateFunction.AddParameter("origin", Chr(34) & "01-03-1600" & Chr(34))
                ucrPanelDate.SetParameter(New RParameter("origin"))
                ucrPanelDate.AddRadioButton(rdoSpecifyOrigin, ucrInputOrigin.GetText)
                clsDateFunction.AddParameter("origin", Chr(34) & "30-12-1899" & Chr(34))
                ucrReceiverForDate.SetIncludedDataTypes({"numeric"})
            Else
                clsDateFunction.AddParameter("format", (34) & "%Y-%m-%d" & Chr(34))
                ucrPanelDate.SetParameter(New RParameter("format"))
                ucrPanelDate.AddRadioButton(rdoSpecifyOrigin, ucrInputOrigin.GetText)
                ucrReceiverForDate.SetIncludedDataTypes({"numeric", "character", "factor", "integer"})
                clsDateFunction.AddParameter("format", (34) & "%Y-%m-%d" & Chr(34))
            End If

        ElseIf rdoYearandDayofYear.Checked
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")
            ucrSelectorMakeDate.SetParameter(New RParameter("data_name", 0))
            ucrSelectorMakeDate.SetParameterIsString()

            ucrChkTwoDigitYear.SetParameter(New RParameter("year_format"))

            ucrReceiverYearTwo.SetParameter(New RParameter("year"))
            ucrReceiverYearTwo.SetParameterIsString()

            ucrReceiverDayTwo.SetParameter(New RParameter("doy"))
            ucrReceiverDayTwo.SetParameterIsString()

        Else
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")
            ucrSelectorMakeDate.SetParameter(New RParameter("data_name", 0))
            ucrSelectorMakeDate.SetParameterIsString()

            ucrReceiverYearThree.SetParameter(New RParameter("year"))
            ucrReceiverYearThree.SetParameterIsString()

            ucrReceiverMonthThree.SetParameter(New RParameter("month"))
            ucrReceiverMonthThree.SetParameterIsString()

            ucrReceiverDayThree.SetParameter(New RParameter("day"))
            ucrReceiverDayThree.SetParameterIsString()
        End If


        ' Three radio buttons to begin with can be checked.

        'If Single Then Column Is checked
        '  If rdoSingleColumn.Checked Then
        'Display Options
        'grpSingleColumn.Visible = True
        'grpTwoColumns.Visible = False
        'grpThreeColumns.Visible = False

        'Receivers
        'ucrBase.clsRsyntax.SetFunction("as.Date")
        'If Not ucrReceiverForDate.IsEmpty Then
        '    ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDate.GetVariables())
        'Else
        '    ucrBase.clsRsyntax.RemoveParameter("x")
        'End If

        ' Check Boxes/ Radio Buttons
        ' If ucrChkMore.Checked Then
        'grpFormatField.Visible = True
        'Else
        'grpFormatField.Visible = False
        'End If

        'If rdoSpecifyOrigin.Checked Then


        ' ucrInputFormat.Visible = False
        ' ucrInputOrigin.Visible = True
        'ucrBase.clsRsyntax.RemoveParameter("format")
        ' If Not ucrInputOrigin.IsEmpty Then
        ' ucrReceiverForDate.SetIncludedDataTypes({"numeric"})
        ' If ucrInputOrigin.GetText = "Excel" Then
        'ElseIf ucrInputOrigin.GetText = "Gregorian" Then

        'Else
        'ucrBase.clsRsyntax.AddParameter("origin", Chr(34) & ucrInputOrigin.GetText & Chr(34))
        'End If
        'Else
        ' ucrBase.clsRsyntax.RemoveParameter("origin")
        ''End If
        'If Not ucrReceiverForDate.IsEmpty Then
        '            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDate.GetVariables())
        '        Else
        '            ' ucrBase.clsRsyntax.RemoveParameter("x")
        '        End If

        '    ElseIf rdoSpecifyFormat.Checked Then


        '   ucrInputFormat.Visible = True
        ' ucrInputOrigin.Visible = False
        ' ucrBase.clsRsyntax.RemoveParameter("origin")
        ' If Not ucrInputFormat.IsEmpty Then
        'ucrReceiverForDate.SetIncludedDataTypes({"numeric", "character", "factor", "integer"})

        '  If ucrInputFormat.GetText = "Year/Month/Day" Then
        ' ucrBase.clsRsyntax.AddParameter("format", Chr(34) & "%Y/%m/%d" & Chr(34))
        'ElseIf ucrInputFormat.GetText = "Year-Month-Day" Then
        '            ucrBase.clsRsyntax.AddParameter("format", (34) & "%Y-%m-%d" & Chr(34))
        '        ElseIf ucrInputFormat.GetText = "Day-Month-Year" Then
        '            ucrBase.clsRsyntax.AddParameter("format", Chr(34) & "%d-%m-%Y" & Chr(34))
        '        Else
        '            ucrBase.clsRsyntax.AddParameter("format", Chr(34) & ucrInputFormat.GetText & Chr(34))
        '        End If
        '    Else
        '        ' ucrBase.clsRsyntax.RemoveParameter("format")
        '    End If
        'Else

        '    'ucrInputOrigin.Visible = False
        '    'ucrInputFormat.Visible = False


        'End If
        'If Year and DOY is checked

        '  ElseIf rdoYearandDayofYear.Checked Then

        ' Display Options
        ' grpTwoColumns.Visible = True
        'grpThreeColumns.Visible = False
        'grpSingleColumn.Visible = False

        ' Remove Parameters



        ' ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        'ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")

        ' Receivers
        'If Not ucrReceiverYearTwo.IsEmpty Then
        '    ' ucrBase.clsRsyntax.AddParameter("year", ucrReceiverYearTwo.GetVariableNames())
        '    ' Else
        '    'ucrBase.clsRsyntax.RemoveParameter("year")
        'End If
        'If Not ucrReceiverDayTwo.IsEmpty Then
        '    ' ucrBase.clsRsyntax.AddParameter("doy", ucrReceiverDayTwo.GetVariableNames())
        '    'Else
        '    'ucrBase.clsRsyntax.RemoveParameter("doy")
        'End If



        'If ucrChkTwoDigitYear.Checked Then
        '    ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & "%y" & Chr(34))
        'Else
        '    ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & "%Y" & Chr(34))
        'End If
        'If Not ucrInputComboBoxMonthTwo.IsEmpty Then
        '    If ucrInputComboBoxMonthTwo.GetText = "365/366" Then
        '        ucrBase.clsRsyntax.AddParameter("doy_typical_length", Chr(34) & "365" & Chr(34))
        '    ElseIf ucrInputComboBoxMonthTwo.GetText = "366" Then
        '        ucrBase.clsRsyntax.AddParameter("doy_typical_length", Chr(34) & "366" & Chr(34))
        '    Else
        '        ucrBase.clsRsyntax.RemoveParameter("doy_typical_length")
        '    End If
        'Else
        '    ucrBase.clsRsyntax.RemoveParameter("doy_typical_length")
        'End If
        ''If Year Date Month is selected
        ''  Else
        '' Sort display options
        '' grpThreeColumns.Visible = True
        ''grpTwoColumns.Visible = False
        ''grpSingleColumn.Visible = False

        ''Remove Parameters
        '' Coding options



        ' ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        ''ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")
        'If Not ucrInputDayOption.IsEmpty Then
        '    If ucrInputDayOption.GetText = "By Month" Then
        '        ucrBase.clsRsyntax.AddParameter("day_format", Chr(34) & "%d" & Chr(34))
        '    Else
        '        ucrBase.clsRsyntax.AddParameter("day_format", Chr(34) & ucrInputDayOption.GetText & Chr(34))
        '    End If
        'Else
        '    ucrBase.clsRsyntax.RemoveParameter("day_format")
        'End If
        'If Not ucrInputYearOption.IsEmpty Then
        '    If ucrInputYearOption.GetText = "4 Digit" Then
        '        ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & "%Y" & Chr(34))
        '    Else
        '        ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & "%y" & Chr(34))
        '    End If
        'Else
        '    ucrBase.clsRsyntax.RemoveParameter("year_formart")
        'End If
        'If Not ucrInputMonthOption.IsEmpty Then
        '    If ucrInputMonthOption.GetText = "Numerical" Then
        '        ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & "%m" & Chr(34))
        '    ElseIf ucrInputMonthOption.GetText = "Full Word" Then
        '        ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & "%B" & Chr(34))
        '    ElseIf ucrInputMonthOption.GetText = "Partial Word" Then
        '        ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & "%b" & Chr(34))
        '    Else
        '        ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & ucrInputMonthOption.GetText & Chr(34))
        '    End If
        'Else
        '    ucrBase.clsRsyntax.RemoveParameter("month_format")
        'End If



        ''Receivers
        'If Not ucrReceiverYearThree.IsEmpty Then
        '    ' ucrBase.clsRsyntax.AddParameter("year", ucrReceiverYearThree.GetVariableNames())
        'Else
        '    '  ucrBase.clsRsyntax.RemoveParameter("year")
        'End If
        'If ucrReceiverMonthThree.IsEmpty = False Then
        '    '  ucrBase.clsRsyntax.AddParameter("month", ucrReceiverMonthThree.GetVariableNames())
        'Else
        '    ' ucrBase.clsRsyntax.RemoveParameter("month")
        'End If
        'If ucrReceiverDayThree.IsEmpty = False Then
        '    ' ucrBase.clsRsyntax.AddParameter("day", ucrReceiverDayThree.GetVariableNames())
        'Else
        '    ' ucrBase.clsRsyntax.RemoveParameter("day")
        'End If
        ''  End If
    End Sub



    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDayTwo.ControlContentsChanged, ucrReceiverForDate.ControlContentsChanged, ucrSaveDate.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverYearThree.ControlContentsChanged, ucrReceiverMonthThree.ControlContentsChanged, ucrReceiverDayThree.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class