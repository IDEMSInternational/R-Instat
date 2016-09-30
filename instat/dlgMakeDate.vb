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
    Public bFirstLoad As Boolean = True
    Private Sub ucrSeclectorMakeDate_Load(sender As Object, e As EventArgs) Handles ucrSeclectorMakeDate.Load
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
        ucrInputNewColumnName.SetPrefix("Date")
        ucrInputNewColumnName.SetItemsTypeAsColumns()
        ucrInputNewColumnName.SetDefaultTypeAsColumn()
        ucrInputNewColumnName.SetDataFrameSelector(ucrSeclectorMakeDate.ucrAvailableDataFrames)
        ucrInputNewColumnName.SetValidationTypeAsRVariable()
        ucrInputSeparator.SetItems({"/", "-", "_", ".", ",", ";", ":"})
        ucrInputYear.SetItems({"%Y (4 digits)", "%y (2 digits)"})
        ucrInputMonth.SetItems({"%m (1-12)", "%b (e.g. Jan)", "%B (e.g. January)"})
        ucrInputDay.SetItems({"%d (1-31)", "%j (1-366)"})
        ucrInputComboBoxMonthTwo.SetItems({"365/366", "366"})
        ucrInputComboBoxYearTwo.SetItems({"4 digits", "2 digits"})
        ucrInputSpecifyDates.SetItems({"%Y-%m-%d", "%Y/%m/%d", "%d%m%Y"})
        ucrInputComboBoxTearThree.SetItems({"4 digits", "2 digits"})
        ucrInputOrigin.SetItems({"30-12-1899 (Excel)", "01-03-1600 (Gregorian)"})

    End Sub
    Private Sub SetDefaults()
        rdoSpecifyFormat.Checked = False
        specifyformats()
        ucrInputNewColumnName.Reset()
        ucrSeclectorMakeDate.Reset()
        ucrInputSeparator.SetName("/")
        ucrInputYear.SetName("%Y (4 digits)")
        ucrInputMonth.SetName("%m (1-12)")
        ucrInputDay.SetName("%d (1-31)")
        ucrInputComboBoxTearThree.SetName("4 digits (eg 1920)")
        ucrInputComboBoxMonthTwo.SetName("365/366")
        ucrInputComboBoxYearTwo.SetName("4 digits (eg 1920)")
        ucrInputOrigin.SetName("30-12-1899 (Excel)")
        grpFormatField.Visible = False
        ucrInputOrigin.Visible = False
        TestOKEnabled()
        rdoSingleColumn.Checked = True
        ShowGroups()
    End Sub
    Private Sub TestOKEnabled()
        If ((Not ucrReceiverForDate.IsEmpty) OrElse ((Not ucrReceiverYearTwo.IsEmpty) AndAlso (Not ucrReceiverDayTwo.IsEmpty)) OrElse ((Not ucrReceiverDayThree.IsEmpty) AndAlso (Not ucrReceiverMonthThree.IsEmpty) AndAlso (Not ucrReceiverYearThree.IsEmpty))) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        If ((Not ucrInputSpecifyDates.GetText = "%Y-%m-%d") OrElse (Not ucrInputSpecifyDates.GetText = "%Y/%m/%d") OrElse (Not ucrInputSpecifyDates.GetText = "%d%m%Y")) Then
            ucrInputSpecifyDates.cboInput.Items.Insert(0, ucrInputSpecifyDates.GetText)
        End If
    End Sub
    Private Sub ReopenDialog()

    End Sub

    Private Sub UcrInputNewColumnName_NameChanged() Handles ucrInputNewColumnName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputNewColumnName.GetText, strTempDataframe:=ucrSeclectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputNewColumnName.GetText, bAssignToIsPrefix:=True)
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrReceiverForDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForDate.SelectionChanged, ucrReceiverYearTwo.SelectionChanged, ucrReceiverDayTwo.SelectionChanged, ucrReceiverYearThree.SelectionChanged, ucrReceiverMonthThree.SelectionChanged, ucrReceiverDayThree.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverForDate_Load(sender As Object, e As EventArgs)

    End Sub

    Private Sub rdoSingleColumn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSingleColumn.CheckedChanged, rdoYearandDayofYear.CheckedChanged, rdoYearMonthDay.CheckedChanged
        ShowGroups()
    End Sub

    Private Sub ShowGroups()
        If rdoSingleColumn.Checked Then
            ucrReceiverForDate.Selector = ucrSeclectorMakeDate
            ucrReceiverForDate.SetMeAsReceiver()
            grpSingleColumn.Visible = True
            grpTwoColumns.Visible = False
            grpThreeColumns.Visible = False
        ElseIf rdoYearandDayofYear.Checked Then
            ucrReceiverYearTwo.Selector = ucrSeclectorMakeDate
            ucrReceiverDayTwo.Selector = ucrSeclectorMakeDate
            ucrReceiverYearTwo.SetMeAsReceiver()
            grpTwoColumns.Visible = True
            grpThreeColumns.Visible = False
            grpSingleColumn.Visible = False
        Else
            ucrReceiverYearThree.Selector = ucrSeclectorMakeDate
            ucrReceiverMonthThree.Selector = ucrSeclectorMakeDate
            ucrReceiverDayThree.Selector = ucrSeclectorMakeDate
            ucrReceiverYearThree.SetMeAsReceiver()
            grpThreeColumns.Visible = True
            grpTwoColumns.Visible = False
            grpSingleColumn.Visible = False
        End If
    End Sub
    Private Sub ShowOrigin()
        If rdoSpecifyOrigin.Checked Then
            ucrInputOrigin.Visible = True
        Else
            ucrInputOrigin.Visible = False
        End If
    End Sub

    Private Sub showFormat()
        If chkMore.Checked Then
            grpFormatField.Visible = True
        Else
            grpFormatField.Visible = False
        End If
    End Sub

    Private Sub rdoSpecifyOrigin_CheckedChanged(sender As Object, e As EventArgs) Handles rdoSpecifyOrigin.CheckedChanged, rdoSpecifyFormat.CheckedChanged
        ShowOrigin()
        specifyformats()
    End Sub

    Private Sub specifyformats()
        If rdoSpecifyFormat.Checked Then
            ucrInputSpecifyDates.Visible = True
        Else
            ucrInputSpecifyDates.Visible = False
        End If
    End Sub
    Private Sub chkMore_CheckedChanged(sender As Object, e As EventArgs) Handles chkMore.CheckedChanged
        showFormat()
    End Sub

End Class





