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
        ucrInputNewColumnName.SetDataFrameSelector(ucrSeclectorMakeDate.ucrAvailableDataFrames)
        ucrInputNewColumnName.SetValidationTypeAsRVariable()
        ucrInputSeparator.SetItems({"/", "-", "_", ".", ",", ";", ":"})
        ucrInputYear.SetItems({"%Y (4 digits)", "%y (2 digits)"})
        ucrInputMonth.SetItems({"%m (1-12)", "%b (e.g. Jan)", "%B (e.g. January)"})
        ucrInputDay.SetItems({"%d (1-31)", "%j (1-366)"})
        ucrInputComboBoxMonthTwo.SetItems({"365/366", "366"})
        ucrInputFormat.SetItems({"%Y-%m-%d", "%Y/%m/%d", "%d%m%Y"})
        ucrInputOrigin.SetItems({"30-12-1899 (Excel)", "01-03-1600 (Gregorian)"})
        ucrReceiverForDate.Selector = ucrSeclectorMakeDate
        ucrReceiverYearTwo.Selector = ucrSeclectorMakeDate
        ucrReceiverDayTwo.Selector = ucrSeclectorMakeDate
        ucrReceiverYearThree.Selector = ucrSeclectorMakeDate
        ucrReceiverMonthThree.Selector = ucrSeclectorMakeDate
        ucrReceiverDayThree.Selector = ucrSeclectorMakeDate

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
        ucrSeclectorMakeDate.Reset()
        ucrInputFormat.Reset()
        ucrInputFormat.SetName("%d/%m/%Y")
        ucrInputSeparator.SetName("/")
        ucrInputYear.SetName("%Y (4 digits)")
        ucrInputMonth.SetName("%m (1-12)")
        ucrInputDay.SetName("%d (1-31)")
        ucrInputComboBoxMonthTwo.SetName("365/366")
        ucrInputOrigin.SetName("30-12-1899 (Excel)")
        ucrInputOrigin.Visible = False
        ucrInputNewColumnName.SetPrefix("Date")
        TestOKEnabled()
        rdoSingleColumn.Checked = True
        rdoSpecifyFormat.Checked = False
        rdoDefaultFormat.Checked = True
        chkTwoDigitYearThree.Checked = False
        chkTwoDigitYearTwo.Checked = False
        lblCutOffThree.Visible = False
        lblCutOffTwo.Visible = False
        'Disabling the check boxes, Input,... which are yet to be Implemented.
        'To be return to how it was prev...
        'chkTwoDigitYearThree.Enabled = False
        'chkTwoDigitYearTwo.Enabled = False
        nudCutOffThree.Visible = True
        nudCutOffTwo.Visible = True
        nudCutOffThree.Enabled = False
        nudCutOffTwo.Enabled = False
        chkMore.Checked = False
        'chkMore.Enabled = False
        lblCutOffTwo.Visible = True
        lblCutOffThree.Visible = True
        lblCutOffThree.Enabled = False
        lblCutOffTwo.Enabled = False
        ucrInputComboBoxMonthTwo.Enabled = False
        grpFormatField.Visible = False

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputNewColumnName.IsEmpty Then
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
                If Not ucrReceiverDayThree.IsEmpty AndAlso Not ucrReceiverMonthThree.IsEmpty Then
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
        Select Case ucrInputOrigin.GetText
            Case "30-12-1899 (Excel)"
                ucrBase.clsRsyntax.AddParameter("origin", Chr(34) & "1899-12-30" & Chr(34))
            Case Else
                ucrBase.clsRsyntax.AddParameter("origin", Chr(34) & "1600-01-03" & Chr(34))
        End Select
    End Sub


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

    Private Sub UcrInputNewColumnName_NameChanged() Handles ucrInputNewColumnName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputNewColumnName.GetText, strTempDataframe:=ucrSeclectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputNewColumnName.GetText, bAssignToIsPrefix:=False)
        TestOKEnabled()
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
    Private Sub ucrReceiverForDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForDate.SelectionChanged, ucrReceiverDayThree.SelectionChanged, ucrReceiverDayTwo.SelectionChanged, ucrReceiverMonthThree.SelectionChanged, ucrReceiverYearThree.SelectionChanged, ucrReceiverYearTwo.SelectionChanged
        Formats()
        TestOKEnabled()
    End Sub

    Private Sub rdoSingleColumn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingleColumn.CheckedChanged, rdoYearandDayofYear.CheckedChanged, rdoYearMonthDay.CheckedChanged, rdoSpecifyOrigin.CheckedChanged, rdoSpecifyFormat.CheckedChanged, rdoDefaultFormat.CheckedChanged
        Formats()
        If rdoSpecifyOrigin.Checked Then
            DateFormat()
        Else
            ucrBase.clsRsyntax.RemoveParameter("origin")
        End If
        'to be removed later
        grpFormatField.Enabled = False
        TestOKEnabled()
    End Sub

    Private Sub chkMore_CheckedChanged(sender As Object, e As EventArgs) Handles chkMore.CheckedChanged, chkTwoDigitYearThree.CheckedChanged, chkTwoDigitYearTwo.CheckedChanged
        Formats()
        If chkTwoDigitYearTwo.Checked Then
            lblCutOffTwo.Visible = True
            nudCutOffTwo.Visible = True
        Else
            lblCutOffTwo.Visible = False
            nudCutOffTwo.Visible = False
        End If
        If chkTwoDigitYearThree.Checked Then
            lblCutOffThree.Visible = True
            nudCutOffThree.Visible = True
        Else
            lblCutOffThree.Visible = False
            nudCutOffThree.Visible = False

        End If
    End Sub

    Private Sub ucrInputSpecifyDates_NameChanged() Handles ucrInputFormat.NameChanged
        Formats()
    End Sub

    Private Sub ucrSeclectorMakeDate_DataFrameChanged() Handles ucrSeclectorMakeDate.DataFrameChanged
        Formats()
    End Sub

    Private Sub Formats()
        If rdoSingleColumn.Checked Then

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
            ucrBase.clsRsyntax.RemoveParameter("year")
            ucrBase.clsRsyntax.RemoveParameter("doy")
            ucrBase.clsRsyntax.RemoveParameter("month")
            ucrBase.clsRsyntax.RemoveParameter("day")
            ucrBase.clsRsyntax.RemoveParameter("data_name")
        ElseIf rdoYearandDayofYear.Checked Then
            ucrReceiverYearTwo.SetMeAsReceiver()
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSeclectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            ucrBase.clsRsyntax.RemoveParameter("x")
            ucrBase.clsRsyntax.RemoveParameter("format")
            ucrBase.clsRsyntax.RemoveParameter("origin")
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")
            grpTwoColumns.Visible = True
            grpThreeColumns.Visible = False
            grpSingleColumn.Visible = False

            If ucrReceiverYearTwo.IsEmpty = False Then
                ucrBase.clsRsyntax.AddParameter("year", ucrReceiverYearTwo.GetVariableNames())
            Else
                ucrBase.clsRsyntax.RemoveParameter("year")
            End If
            If ucrReceiverDayTwo.IsEmpty = False Then
                ucrBase.clsRsyntax.AddParameter("doy", ucrReceiverDayTwo.GetVariableNames())
            Else
                ucrBase.clsRsyntax.RemoveParameter("doy")
            End If
            ucrBase.clsRsyntax.RemoveParameter("month")
            ucrBase.clsRsyntax.RemoveParameter("day")
        Else
            ucrReceiverYearThree.SetMeAsReceiver()
            ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSeclectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
            ucrBase.clsRsyntax.RemoveParameter("doy")
            ucrBase.clsRsyntax.RemoveParameter("year")
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")
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
            grpThreeColumns.Visible = True
            grpTwoColumns.Visible = False
            grpSingleColumn.Visible = False
            ucrBase.clsRsyntax.RemoveParameter("x")
            ucrBase.clsRsyntax.RemoveParameter("format")
            ucrBase.clsRsyntax.RemoveParameter("origin")
        End If
    End Sub

End Class
