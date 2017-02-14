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
    Private Sub dlgMakeDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
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

        ucrInputNewColumnName.SetItemsTypeAsColumns()
        ucrInputNewColumnName.SetDefaultTypeAsColumn()
        ucrInputNewColumnName.SetDataFrameSelector(ucrSelectorMakeDate.ucrAvailableDataFrames)
        ucrInputNewColumnName.SetValidationTypeAsRVariable()
        ucrInputSeparator.SetItems({"/", "-", "_", ".", ",", ";", ":"})
        ucrInputYearOption.SetItems({"4 Digit", "2 Digit"})
        ucrInputYear.SetItems({"4 Digit", "2 Digit"})
        ucrInputMonth.SetItems({"Numerical", "Partial Word", "Full Word"})
        ucrInputMonthOption.SetItems({"Numerical", "Partial Word", "Full Word"})

        'Dim lstYearItems As New List(Of KeyValuePair(Of String, String))
        'lstYearItems.Add(New KeyValuePair(Of String, String)("4 Digit", Chr(34) & "%Y" & Chr(34)))
        'lstYearItems.Add(New KeyValuePair(Of String, String)("2 Digit", Chr(34) & "%y" & Chr(34)))
        'ucrInputYear.SetItems(lstYearItems)
        'ucrInputYearOption.SetItems(lstYearItems)

        'Dim lstMonthItems As New List(Of KeyValuePair(Of String, String))
        'lstMonthItems.Add(New KeyValuePair(Of String, String)("Numerical", Chr(34) & "%m" & Chr(34)))
        'lstMonthItems.Add(New KeyValuePair(Of String, String)("Partial Word", Chr(34) & "%b" & Chr(34)))
        'lstMonthItems.Add(New KeyValuePair(Of String, String)("Full Word", Chr(34) & "%B" & Chr(34)))
        'ucrInputMonth.SetItems(lstMonthItems)
        'ucrInputMonthOption.SetItems(lstMonthItems)
        ucrInputDayOption.SetItems({"By Month"})
        'Dim lstDayItems As New List(Of KeyValuePair(Of String, String))
        'lstDayItems.Add(New KeyValuePair(Of String, String)("By Month", Chr(34) & "%d" & Chr(34)))
        'ucrInputDayOption.SetItems(lstDayItems)
        ucrInputDay.SetItems({"By Month", "By Year"})
        'Dim lstDayItemsDOY As New List(Of KeyValuePair(Of String, String))
        'lstDayItemsDOY.Add(New KeyValuePair(Of String, String)("By Month", Chr(34) & "%d" & Chr(34)))
        'lstDayItemsDOY.Add(New KeyValuePair(Of String, String)("By Year", Chr(34) & "%j" & Chr(34)))
        'ucrInputDay.SetItems(lstDayItemsDOY)
        ucrInputComboBoxMonthTwo.SetItems({"365/366", "366"})
        'Dim lstMonthTwoItems As New List(Of KeyValuePair(Of String, String))
        'lstMonthTwoItems.Add(New KeyValuePair(Of String, String)("365/366", Chr(34) & "365/366" & Chr(34)))
        'lstMonthTwoItems.Add(New KeyValuePair(Of String, String)("366", Chr(34) & "366" & Chr(34)))
        'ucrInputComboBoxMonthTwo.SetItems(lstMonthTwoItems)
        ucrInputFormat.SetItems({"Year-Month-Day", "Year/Month/Day", "Day-Month-Year"})
        'Dim lstDateFormat As New List(Of KeyValuePair(Of String, String))
        'lstDateFormat.Add(New KeyValuePair(Of String, String)("Year-Month-Day", Chr(34) & "%Y-%m-%d" & Chr(34)))
        'lstDateFormat.Add(New KeyValuePair(Of String, String)("Year/Month/Day", Chr(34) & "%Y/%m/%d" & Chr(34)))
        'lstDateFormat.Add(New KeyValuePair(Of String, String)("Day-Month-Year", Chr(34) & "%d%m%Y" & Chr(34)))
        'ucrInputFormat.SetItems(lstDateFormat)
        ucrInputOrigin.SetItems({"Excel", "Gregorian"})
        'Dim lstDateOrigin As New List(Of KeyValuePair(Of String, String))
        'lstDateOrigin.Add(New KeyValuePair(Of String, String)("Excel", Chr(34) & "30-12-1899" & Chr(34)))
        'lstDateOrigin.Add(New KeyValuePair(Of String, String)("Gregorian", Chr(34) & "01-03-1600" & Chr(34)))
        'ucrInputOrigin.SetItems(lstDateOrigin)



    End Sub

    Private Sub SetDefaults()
        ucrInputNewColumnName.Reset()
        ucrSelectorMakeDate.Reset()
        ucrInputFormat.Reset()
        rdoSingleColumn.Checked = True
        rdoSpecifyFormat.Checked = False
        rdoDefaultFormat.Checked = True
        ucrInputYearOption.SetName("4 Digit")
        ucrInputMonthOption.SetName("Numerical")
        ucrInputDayOption.SetName("By Month")
        ucrInputFormat.SetName("Day-Month-Year")
        ucrInputSeparator.SetName("/")
        ucrInputYear.SetName("4 Digit")
        ucrInputMonth.SetName("Numerical")
        ucrInputDay.SetName("By Month")
        ucrInputComboBoxMonthTwo.SetName("365/366")
        ucrInputOrigin.Visible = False
        ucrInputOrigin.SetName("Excel")
        ucrInputNewColumnName.SetPrefix("Date")
        chkTwoDigitYearTwo.Checked = False
        lblCutOffTwo.Visible = False
        chkTwoDigitYearTwo.Visible = True
        nudCutOffTwo.Visible = False
        nudCutOffTwo.Value = 0
        chkMore.Checked = False
        chkMore.Visible = True
        Formats()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
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
        If Not ucrInputNewColumnName.IsEmpty Then
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
    Private Sub UcrInputNewColumnName_NameChanged() Handles ucrInputNewColumnName.NameChanged
        SetAssignTo()
    End Sub

    Private Sub SetAssignTo()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputNewColumnName.GetText, strTempDataframe:=ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputNewColumnName.GetText, bAssignToIsPrefix:=False)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    ' When the ucrReceivers have a change occur
    Private Sub ucrReceivers_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForDate.SelectionChanged, ucrReceiverDayThree.SelectionChanged, ucrReceiverDayTwo.SelectionChanged, ucrReceiverMonthThree.SelectionChanged, ucrReceiverYearThree.SelectionChanged, ucrReceiverYearTwo.SelectionChanged
        Formats()
        TestOKEnabled()
    End Sub

    ' When the three radio buttons are checked or unchecked
    Private Sub rdoSingleColumn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingleColumn.CheckedChanged, rdoYearandDayofYear.CheckedChanged, rdoYearMonthDay.CheckedChanged
        SetReceivers()
        Formats()
        TestOKEnabled()
    End Sub

    Private Sub rdoSpecifyOrigin_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDefaultFormat.CheckedChanged, rdoSpecifyFormat.CheckedChanged, rdoSpecifyOrigin.CheckedChanged
        Formats()
    End Sub

    Private Sub chkMore_CheckedChanged(sender As Object, e As EventArgs) Handles chkMore.CheckedChanged, chkTwoDigitYearTwo.CheckedChanged
        Formats()
        If chkTwoDigitYearTwo.Checked Then
            lblCutOffTwo.Visible = True
            nudCutOffTwo.Visible = True
        Else
            lblCutOffTwo.Visible = False
            nudCutOffTwo.Visible = False
        End If
    End Sub

    Private Sub ucrInputSpecifyDates_NameChanged() Handles ucrInputFormat.NameChanged, ucrInputDayOption.NameChanged, ucrInputMonthOption.NameChanged, ucrInputYearOption.NameChanged, ucrInputOrigin.NameChanged, ucrInputComboBoxMonthTwo.NameChanged
        Formats()
    End Sub

    Private Sub ucrSeclectorMakeDate_DataFrameChanged() Handles ucrSelectorMakeDate.DataFrameChanged
        Formats()
        SetAssignTo()
    End Sub

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
        ' Three radio buttons to begin with can be checked.

        ' If Single Column is checked
        If rdoSingleColumn.Checked Then
            'Display Options
            grpSingleColumn.Visible = True
            grpTwoColumns.Visible = False
            grpThreeColumns.Visible = False

            'Remove Parameters
            ucrBase.clsRsyntax.RemoveParameter("month_format")
            ucrBase.clsRsyntax.RemoveParameter("day_format")
            ucrBase.clsRsyntax.RemoveParameter("year")
            ucrBase.clsRsyntax.RemoveParameter("doy")
            ucrBase.clsRsyntax.RemoveParameter("month")
            ucrBase.clsRsyntax.RemoveParameter("day")
            ucrBase.clsRsyntax.RemoveParameter("data_name")
            ucrBase.clsRsyntax.RemoveParameter("year_format")
            ucrBase.clsRsyntax.RemoveParameter("doy_typical_length")
            'Receivers
            ucrBase.clsRsyntax.SetFunction("as.Date")
            If Not ucrReceiverForDate.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDate.GetVariables())
            Else
                ucrBase.clsRsyntax.RemoveParameter("x")
            End If

            ' Check Boxes/ Radio Buttons
            If chkMore.Checked Then
                grpFormatField.Visible = True
            Else
                grpFormatField.Visible = False
            End If

            If rdoSpecifyOrigin.Checked Then
                ucrInputFormat.Visible = False
                ucrInputOrigin.Visible = True
                ucrBase.clsRsyntax.RemoveParameter("format")
                If Not ucrInputOrigin.IsEmpty Then
                    ucrReceiverForDate.SetIncludedDataTypes({"numeric"})
                    If ucrInputOrigin.GetText = "Excel" Then
                        ucrBase.clsRsyntax.AddParameter("origin", Chr(34) & "30-12-1899" & Chr(34))
                    ElseIf ucrInputOrigin.GetText = "Gregorian" Then
                        ucrBase.clsRsyntax.AddParameter("origin", Chr(34) & "01-03-1600" & Chr(34))
                    Else
                        ucrBase.clsRsyntax.AddParameter("origin", Chr(34) & ucrInputOrigin.GetText & Chr(34))
                    End If
                Else
                    ucrBase.clsRsyntax.RemoveParameter("origin")
                End If
                If Not ucrReceiverForDate.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDate.GetVariables())
                Else
                    ucrBase.clsRsyntax.RemoveParameter("x")
                End If

            ElseIf rdoSpecifyFormat.Checked Then
                ucrInputFormat.Visible = True
                ucrInputOrigin.Visible = False
                ucrBase.clsRsyntax.RemoveParameter("origin")
                If Not ucrInputFormat.IsEmpty Then
                    ucrReceiverForDate.SetIncludedDataTypes({"numeric", "character", "factor", "integer"})
                    If ucrInputFormat.GetText = "Year/Month/Day" Then
                        ucrBase.clsRsyntax.AddParameter("format", Chr(34) & "%Y/%m/%d" & Chr(34))
                    ElseIf ucrInputFormat.GetText = "Year-Month-Day" Then
                        ucrBase.clsRsyntax.AddParameter("format", (34) & "%Y-%m-%d" & Chr(34))
                    ElseIf ucrInputFormat.GetText = "Day-Month-Year" Then
                        ucrBase.clsRsyntax.AddParameter("format", Chr(34) & "%d-%m-%Y" & Chr(34))
                    Else
                        ucrBase.clsRsyntax.AddParameter("format", Chr(34) & ucrInputFormat.GetText & Chr(34))
                    End If
                Else
                    ucrBase.clsRsyntax.RemoveParameter("format")
                End If
            Else
                ucrInputOrigin.Visible = False
                ucrInputFormat.Visible = False
                ucrReceiverForDate.SetIncludedDataTypes({"character", "factor"})
                ucrBase.clsRsyntax.RemoveParameter("format")
                ucrBase.clsRsyntax.RemoveParameter("origin")
            End If
            'If Year and DOY is checked
        ElseIf rdoYearandDayofYear.Checked Then
            ' Display Options
            grpTwoColumns.Visible = True
            grpThreeColumns.Visible = False
            grpSingleColumn.Visible = False

            ' Remove Parameters
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            ucrBase.clsRsyntax.RemoveParameter("x")
            ucrBase.clsRsyntax.RemoveParameter("format")
            ucrBase.clsRsyntax.RemoveParameter("origin")
            ucrBase.clsRsyntax.RemoveParameter("month")
            ucrBase.clsRsyntax.RemoveParameter("day")
            ucrBase.clsRsyntax.RemoveParameter("month_format")
            ucrBase.clsRsyntax.RemoveParameter("day_format")
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")

            ' Receivers
            If Not ucrReceiverYearTwo.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("year", ucrReceiverYearTwo.GetVariableNames())
            Else
                ucrBase.clsRsyntax.RemoveParameter("year")
            End If
            If Not ucrReceiverDayTwo.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("doy", ucrReceiverDayTwo.GetVariableNames())
            Else
                ucrBase.clsRsyntax.RemoveParameter("doy")
            End If

            If chkTwoDigitYearTwo.Checked Then
                ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & "%y" & Chr(34))
            Else
                ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & "%Y" & Chr(34))
            End If
            If Not ucrInputComboBoxMonthTwo.IsEmpty Then
                If ucrInputComboBoxMonthTwo.GetText = "365/366" Then
                    ucrBase.clsRsyntax.AddParameter("doy_typical_length", Chr(34) & "365" & Chr(34))
                ElseIf ucrInputComboBoxMonthTwo.GetText = "366" Then
                    ucrBase.clsRsyntax.AddParameter("doy_typical_length", Chr(34) & "366" & Chr(34))
                Else
                    ucrBase.clsRsyntax.RemoveParameter("doy_typical_length")
                End If
            Else
                ucrBase.clsRsyntax.RemoveParameter("doy_typical_length")
            End If
            'If Year Date Month is selected
        Else
            ' Sort display options
            grpThreeColumns.Visible = True
            grpTwoColumns.Visible = False
            grpSingleColumn.Visible = False

            'Remove Parameters
            ucrBase.clsRsyntax.RemoveParameter("x")
            ucrBase.clsRsyntax.RemoveParameter("format")
            ucrBase.clsRsyntax.RemoveParameter("origin")
            ucrBase.clsRsyntax.RemoveParameter("doy")
            ucrBase.clsRsyntax.RemoveParameter("year")
            ucrBase.clsRsyntax.RemoveParameter("doy_typical_length")

            ' Coding options
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")
            If Not ucrInputDayOption.IsEmpty Then
                If ucrInputDayOption.GetText = "By Month" Then
                    ucrBase.clsRsyntax.AddParameter("day_format", Chr(34) & "%d" & Chr(34))
                Else
                    ucrBase.clsRsyntax.AddParameter("day_format", Chr(34) & ucrInputDayOption.GetText & Chr(34))
                End If
            Else
                ucrBase.clsRsyntax.RemoveParameter("day_format")
            End If
            If Not ucrInputYearOption.IsEmpty Then
                If ucrInputYearOption.GetText = "4 Digit" Then
                    ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & "%Y" & Chr(34))
                Else
                    ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & "%y" & Chr(34))
                End If
            Else
                ucrBase.clsRsyntax.RemoveParameter("year_formart")
            End If
            If Not ucrInputMonthOption.IsEmpty Then
                If ucrInputMonthOption.GetText = "Numerical" Then
                    ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & "%m" & Chr(34))
                ElseIf ucrInputMonthOption.GetText = "Full Word" Then
                    ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & "%B" & Chr(34))
                ElseIf ucrInputMonthOption.GetText = "Partial Word" Then
                    ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & "%b" & Chr(34))
                Else
                    ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & ucrInputMonthOption.GetText & Chr(34))
                End If
            Else
                ucrBase.clsRsyntax.RemoveParameter("month_format")
            End If
            'Receivers
            If Not ucrReceiverYearThree.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("year", ucrReceiverYearThree.GetVariableNames())
            Else
                ucrBase.clsRsyntax.RemoveParameter("year")
                End If
                If ucrReceiverMonthThree.IsEmpty = False Then
                    ucrBase.clsRsyntax.AddParameter("month", ucrReceiverMonthThree.GetVariableNames())
                Else
                    ucrBase.clsRsyntax.RemoveParameter("month")
                End If
                If ucrReceiverDayThree.IsEmpty = False Then
                    ucrBase.clsRsyntax.AddParameter("day", ucrReceiverDayThree.GetVariableNames())
                Else
                    ucrBase.clsRsyntax.RemoveParameter("day")
                End If
            End If
    End Sub

    Private Sub ucrInputNewColumnName_ContentsChanged() Handles ucrInputNewColumnName.ContentsChanged
        TestOKEnabled()
    End Sub
End Class