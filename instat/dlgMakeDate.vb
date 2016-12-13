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
    Private Sub dlgMakeDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
        autoTranslate(Me)

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 461
        ucrInputNewColumnName.SetItemsTypeAsColumns()
        ucrInputNewColumnName.SetDefaultTypeAsColumn()
        ucrInputNewColumnName.SetDataFrameSelector(ucrSelectorMakeDate.ucrAvailableDataFrames)
        ucrInputNewColumnName.SetValidationTypeAsRVariable()
        ucrInputSeparator.SetItems({"/", "-", "_", ".", ",", ";", ":"})
        ucrInputYear.SetItems({"%Y (4 digits)", "%y (2 digits)"})
        ucrInputMonth.SetItems({"%m (1-12)", "%b (e.g. Jan)", "%B (e.g. January)"})
        ucrInputDay.SetItems({"%d (1-31)", "%j (1-366)"})
        ucrInputComboBoxMonthTwo.SetItems({"365/366", "366"})
        ucrInputFormat.SetItems({"%Y-%m-%d", "%Y/%m/%d", "%d%m%Y"})
        ucrInputOrigin.SetItems({"30-12-1899 (Excel)", "01-03-1600 (Gregorian)"})
        ucrInputDayOption.SetItems({"%d"})
        ucrInputMonthOption.SetItems({"%m", "%b", "%B"})
        ucrInputYearOption.SetItems({"%Y", "%y"})
        ucrReceiverForDate.Selector = ucrSelectorMakeDate
        ucrReceiverYearTwo.Selector = ucrSelectorMakeDate
        ucrReceiverDayTwo.Selector = ucrSelectorMakeDate
        ucrReceiverYearThree.Selector = ucrSelectorMakeDate
        ucrReceiverMonthThree.Selector = ucrSelectorMakeDate
        ucrReceiverDayThree.Selector = ucrSelectorMakeDate

        ucrReceiverForDate.bUseFilteredData = False
        ucrReceiverYearTwo.bUseFilteredData = False
        ucrReceiverDayTwo.bUseFilteredData = False
        ucrReceiverYearThree.bUseFilteredData = False
        ucrReceiverMonthThree.bUseFilteredData = False
        ucrReceiverDayThree.bUseFilteredData = False

    End Sub

    Private Sub SetDefaults()
        Formats()
        ucrInputNewColumnName.Reset()
        ucrSelectorMakeDate.Reset()
        ucrInputFormat.Reset()
        ucrInputYearOption.SetName("%Y")
        ucrInputMonthOption.SetName("%m")
        ucrInputDayOption.SetName("%d")
        ucrInputFormat.SetName("%d/%m/%Y")
        ucrInputSeparator.SetName("/")
        ucrInputYear.SetName("%Y (4 digits)")
        ucrInputMonth.SetName("%m (1-12)")
        ucrInputDay.SetName("%d (1-31)")
        ucrInputComboBoxMonthTwo.SetName("365/366")
        ucrInputOrigin.Visible = False
        ucrInputOrigin.SetName("30-12-1899 (Excel)")
        ucrInputNewColumnName.SetPrefix("Date")
        TestOKEnabled()
        rdoSingleColumn.Checked = True
        rdoSpecifyFormat.Checked = False
        rdoDefaultFormat.Checked = True
        chkTwoDigitYearTwo.Checked = False
        lblCutOffTwo.Visible = False
        chkTwoDigitYearTwo.Visible = True
        nudCutOffTwo.Visible = False
        nudCutOffTwo.Value = 0
        chkMore.Checked = False
        chkMore.Visible = True

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

    Private Sub DateFormat()
        ' We have two options for the Date Format
        Select Case ucrInputOrigin.GetText
            Case "30-12-1899 (Excel)"
                ucrBase.clsRsyntax.AddParameter("origin", Chr(34) & "1899-12-30" & Chr(34))
            Case Else
                ucrBase.clsRsyntax.AddParameter("origin", Chr(34) & "1600-01-03" & Chr(34))
        End Select
    End Sub

    ' When to run the DateFormat() sub
    Private Sub ucrInputOrigin_NameChanged() Handles ucrInputOrigin.NameChanged
        If Not ucrInputOrigin.IsEmpty Then
            DateFormat()
        Else
            ucrBase.clsRsyntax.RemoveParameter("origin")
        End If
        Formats()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        setHistory()
    End Sub

    Private Sub setHistory()
        If Not ucrInputFormat.cboInput.Items.Contains(ucrInputFormat.GetText) Then
            ucrInputFormat.cboInput.Items.Insert(0, ucrInputFormat.GetText)
        Else
        End If
    End Sub
    Private Sub ReopenDialog()

    End Sub

    'New Column Name
    Private Sub UcrInputNewColumnName_NameChanged() Handles ucrInputNewColumnName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputNewColumnName.GetText, strTempDataframe:=ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputNewColumnName.GetText, bAssignToIsPrefix:=False)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    ' When the ucrReceivers have a change occur
    Private Sub ucrReceivers_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForDate.SelectionChanged, ucrReceiverDayThree.SelectionChanged, ucrReceiverDayTwo.SelectionChanged, ucrReceiverMonthThree.SelectionChanged, ucrReceiverYearThree.SelectionChanged, ucrReceiverYearTwo.SelectionChanged
        Formats()
        TestOKEnabled()
    End Sub

    ' When the three radio buttons are checked or unchecked
    Private Sub rdoSingleColumn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingleColumn.CheckedChanged, rdoYearandDayofYear.CheckedChanged, rdoYearMonthDay.CheckedChanged, rdoSpecifyOrigin.CheckedChanged, rdoSpecifyFormat.CheckedChanged, rdoDefaultFormat.CheckedChanged
        Formats()
        If rdoSpecifyOrigin.Checked Then
            DateFormat()
        Else
            ucrBase.clsRsyntax.RemoveParameter("origin")
        End If
        TestOKEnabled()
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

    Private Sub ucrInputSpecifyDates_NameChanged() Handles ucrInputFormat.NameChanged, ucrInputDayOption.NameChanged, ucrInputMonthOption.NameChanged, ucrInputYearOption.NameChanged
        Formats()
    End Sub

    Private Sub ucrSeclectorMakeDate_DataFrameChanged() Handles ucrSelectorMakeDate.DataFrameChanged
        Formats()
    End Sub

    Private Sub Formats()
        ' Three radio buttons to begin with can be checked.
        ' If Single Column is checked
        If rdoSingleColumn.Checked Then
            ' Sorting Display Options for rdoSingleColumn
            ucrBase.clsRsyntax.RemoveParameter("month_format")
            ucrBase.clsRsyntax.RemoveParameter("day_format")
            ucrBase.clsRsyntax.RemoveParameter("day_format")
            ucrReceiverForDate.SetMeAsReceiver()
            grpSingleColumn.Visible = True
            grpTwoColumns.Visible = False
            grpThreeColumns.Visible = False
            ucrBase.clsRsyntax.SetFunction("as.Date")
            If chkMore.Checked Then
                grpFormatField.Visible = True
            Else
                grpFormatField.Visible = False
            End If
            If Not ucrReceiverForDate.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDate.GetVariables())
            Else
                ucrBase.clsRsyntax.RemoveParameter("x")
            End If

            If rdoSpecifyOrigin.Checked Then
                ucrInputFormat.Visible = False
                ucrInputOrigin.Visible = True
                ucrBase.clsRsyntax.RemoveParameter("format")
                If Not ucrInputOrigin.IsEmpty Then
                    DateFormat()
                    ucrReceiverForDate.SetIncludedDataTypes({"numeric"})
                Else
                    ucrBase.clsRsyntax.RemoveParameter("origin")
                End If

            ElseIf rdoSpecifyFormat.Checked Then
                ucrBase.clsRsyntax.RemoveParameter("origin")
                ucrInputFormat.Visible = True
                ucrInputOrigin.Visible = False

                If Not ucrInputFormat.IsEmpty Then
                    ucrBase.clsRsyntax.AddParameter("format", Chr(34) & ucrInputFormat.GetText & Chr(34))
                    ucrReceiverForDate.SetIncludedDataTypes({"numeric", "character", "factor", "integer"})
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
            ' Sorting Coding Options for rdoSingleColumn
            If Not ucrReceiverForDate.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDate.GetVariables())
            Else
                ucrBase.clsRsyntax.RemoveParameter("x")
            End If
            ucrBase.clsRsyntax.RemoveParameter("year")
            ucrBase.clsRsyntax.RemoveParameter("doy")
            ucrBase.clsRsyntax.RemoveParameter("month")
            ucrBase.clsRsyntax.RemoveParameter("day")
            ucrBase.clsRsyntax.RemoveParameter("data_name")

            'If Year and DOY is checked
        ElseIf rdoYearandDayofYear.Checked Then
            ' Display Options
            ucrReceiverYearTwo.SetMeAsReceiver()
            grpTwoColumns.Visible = True
            grpThreeColumns.Visible = False
            grpSingleColumn.Visible = False

            ' Coding Options
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            ucrBase.clsRsyntax.RemoveParameter("x")
            ucrBase.clsRsyntax.RemoveParameter("format")
            ucrBase.clsRsyntax.RemoveParameter("origin")
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")

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
            ucrBase.clsRsyntax.RemoveParameter("month")
            ucrBase.clsRsyntax.RemoveParameter("day")
            ucrBase.clsRsyntax.RemoveParameter("month_format")
            ucrBase.clsRsyntax.RemoveParameter("day_format")
            ucrBase.clsRsyntax.RemoveParameter("day_format")

            'If Year Date Month is selected
        Else
            ' Sort display options
            grpThreeColumns.Visible = True
            grpTwoColumns.Visible = False
            grpSingleColumn.Visible = False
            ' Coding options
            ucrReceiverYearThree.SetMeAsReceiver()
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            ucrBase.clsRsyntax.RemoveParameter("doy")
            ucrBase.clsRsyntax.RemoveParameter("year")
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")
            ucrBase.clsRsyntax.AddParameter("month_format", Chr(34) & ucrInputMonthOption.GetText & Chr(34))
            ucrBase.clsRsyntax.AddParameter("day_format", Chr(34) & ucrInputDayOption.GetText & Chr(34))
            ucrBase.clsRsyntax.AddParameter("year_format", Chr(34) & ucrInputYearOption.GetText & Chr(34))
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
            ucrBase.clsRsyntax.RemoveParameter("x")
            ucrBase.clsRsyntax.RemoveParameter("format")
            ucrBase.clsRsyntax.RemoveParameter("origin")
        End If
    End Sub

    Private Sub ucrInputNewColumnName_ContentsChanged() Handles ucrInputNewColumnName.ContentsChanged
        TestOKEnabled()
    End Sub
End Class