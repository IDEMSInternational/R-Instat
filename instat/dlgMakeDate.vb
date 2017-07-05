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
Public Class dlgMakeDate
    Public clsPaste As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private clsDateFunction, clsMakeYearDay, clsMakeYearMonthDay As New RFunction
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
        Dim dctYearItems As New Dictionary(Of String, String)
        Dim dctMonthItems As New Dictionary(Of String, String)
        Dim dctMonthTwoItems As New Dictionary(Of String, String)
        Dim dctDateFormat As New Dictionary(Of String, String)
        Dim dctdateorigin As New Dictionary(Of String, String)
        'Dim dctDayItemsDOY As New Dictionary(Of String, String)
        'Dim dctDayItemsDOY As New Dictionary(Of String, String)

        ucrInputMonthOption.SetParameter(New RParameter("month_format", 5))
        dctMonthItems.Add("Numeric", Chr(34) & "%m" & Chr(34))
        dctMonthItems.Add("Abbreviation", Chr(34) & "%b" & Chr(34))
        dctMonthItems.Add("Full Name", Chr(34) & "%B" & Chr(34))
        ucrInputMonthOption.SetItems(dctMonthItems)
        ucrInputMonthOption.SetDropDownStyleAsNonEditable()

        ucrInputComboBoxMonthTwo.SetParameter(New RParameter("doy_typical_length", 3))
        dctMonthTwoItems.Add("365/366", Chr(34) & "365/366" & Chr(34))
        dctMonthTwoItems.Add("366", Chr(34) & "366" & Chr(34))
        ucrInputComboBoxMonthTwo.SetItems(dctMonthTwoItems)
        ucrInputComboBoxMonthTwo.SetDropDownStyleAsNonEditable()

        ucrInputFormat.SetParameter(New RParameter("format", 1))
        dctDateFormat.Add("Year-Month-Day", Chr(34) & "%Y-%m-%d" & Chr(34))
        dctDateFormat.Add("Year/Month/Day", Chr(34) & "%Y/%m/%d" & Chr(34))
        dctDateFormat.Add("Day-Month-Year", Chr(34) & "%d-%m-%Y" & Chr(34))
        ucrInputFormat.SetItems(dctDateFormat)
        ucrInputFormat.SetDropDownStyleAsEditable(bAdditionsAllowed:=True)

        ucrInputOrigin.SetParameter(New RParameter("origin", 1))
        dctdateorigin.Add("Excel", Chr(34) & "1899-12-30" & Chr(34))
        dctdateorigin.Add("Gregorian", Chr(34) & "1600-03-01" & Chr(34))
        ucrInputOrigin.SetItems(dctdateorigin)
        ucrInputOrigin.SetDropDownStyleAsNonEditable()


        ucrInputYearOption.SetParameter(New RParameter("year_format", 6))
        dctYearItems.Add("4 Digit", Chr(34) & "%Y" & Chr(34))
        dctYearItems.Add("2 Digit", Chr(34) & "%y" & Chr(34))
        ucrInputYearOption.SetItems(dctYearItems)
        ucrInputYearOption.SetDropDownStyleAsNonEditable()
        'TODO - ucrinputFomat

        'ucrInputSeparator.SetItems({"/", "-", "_", ".", ",", ";", ":"})
        'ucrInputYearOption.SetItems({"4 Digit", "2 Digit"})
        'ucrInputYear.SetItems({"4 Digit", "2 Digit"})
        'ucrInputMonth.SetItems({"Numeric", "Abbreviation", "Full Name"})

        'ucrInputDay.SetParameter(New RParameter(""))
        'dctDayItemsDOY.Add("By Month", Chr(34) & "%d" & Chr(34))
        'dctDayItemsDOY.Add("By Year", Chr(34) & "%j" & Chr(34))
        'ucrInputDay.SetItems(dctDayItemsDOY)
        'ucrInputSeparator.SetItems({"/", "-", "_", ".", ",", ";", ":"})
        'ucrInputYearOption.SetItems({"4 Digit", "2 Digit"})
        'ucrInputYear.SetItems({"4 Digit", "2 Digit"})
        'ucrInputMonth.SetItems({"Numeric", "Abbreviation", "Full Name"})

        'ucrInputDay.SetParameter(New RParameter(""))
        'dctDayItemsDOY.Add("By Month", Chr(34) & "%d" & Chr(34))
        'dctDayItemsDOY.Add("By Year", Chr(34) & "%j" & Chr(34))
        'ucrInputDay.SetItems(dctDayItemsDOY)


        'ucrReceiver
        ucrReceiverForDate.Selector = ucrSelectorMakeDate
        ucrReceiverDayTwo.Selector = ucrSelectorMakeDate
        ucrReceiverYearTwo.Selector = ucrSelectorMakeDate
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

        ucrPnlDate.AddRadioButton(rdoSingleColumn)
        ucrPnlDate.AddRadioButton(rdoTwoColumns)
        ucrPnlDate.AddRadioButton(rdoThreeColumns)

        ucrPnlFormat.AddRadioButton(rdoDefaultFormat)
        ucrPnlFormat.AddRadioButton(rdoSpecifyFormat)
        ucrPnlFormat.AddRadioButton(rdoSpecifyOrigin)

        ucrPnlDate.AddFunctionNamesCondition(rdoSingleColumn, "as.Date")
        ucrPnlDate.AddFunctionNamesCondition(rdoTwoColumns, frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")
        ucrPnlDate.AddFunctionNamesCondition(rdoThreeColumns, frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")

        'ucrSave Date Column
        ucrSaveDate.SetPrefix("Date")
        ucrSaveDate.SetSaveTypeAsColumn()
        ucrSaveDate.SetDataFrameSelector(ucrSelectorMakeDate.ucrAvailableDataFrames)
        ucrSaveDate.SetLabelText("Save Date:")
        ucrSaveDate.SetIsComboBox()

        ucrChkTwoDigitYear.SetText("2-digit years")
        ucrChkTwoDigitYear.SetParameter(New RParameter("year_format", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "%y" & Chr(34), strNewValueIfUnchecked:=Chr(34) & "%Y" & Chr(34))

        'rdoSingle
        ucrReceiverForDate.SetParameter(New RParameter("x", 0))
        ucrReceiverForDate.SetParameterIsRFunction()

        'rdoYearDayofMonth
        ucrReceiverYearTwo.SetParameter(New RParameter("year", 2))
        ucrReceiverYearTwo.SetParameterIsString()

        ucrReceiverDayTwo.SetParameter(New RParameter("doy", 1))
        ucrReceiverDayTwo.SetParameterIsString()

        'rdoYearMonthDay
        ucrReceiverYearThree.SetParameter(New RParameter("year", 3))
        ucrReceiverYearThree.SetParameterIsString()

        ucrReceiverMonthThree.SetParameter(New RParameter("month", 2))
        ucrReceiverMonthThree.SetParameterIsString()

        ucrReceiverDayThree.SetParameter(New RParameter("day", 1))
        ucrReceiverDayThree.SetParameterIsString()

        ucrSelectorMakeDate.SetParameter(New RParameter("data_name", 0))
        ucrSelectorMakeDate.SetParameterIsString()

        'when rdoSingleColumn is checked
        ucrPnlDate.AddToLinkedControls(ucrPnlFormat, {rdoSingleColumn}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoDefaultFormat)
        ucrPnlDate.AddToLinkedControls(ucrPnlFormat, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDate.AddToLinkedControls(ucrReceiverForDate, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverForDate.SetLinkedDisplayControl(grpSingleColumn)

        ''linking up ucrinputs for format and origin
        ucrPnlFormat.AddToLinkedControls(ucrInputFormat, {rdoSpecifyFormat}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Year-Month-Day")
        ucrPnlFormat.AddToLinkedControls(ucrInputOrigin, {rdoSpecifyOrigin}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Excel")

        'when rdoTwoColumn is checked
        ucrPnlDate.AddToLinkedControls(ucrReceiverYearTwo, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYearTwo.SetLinkedDisplayControl(lblYearTwo)
        ucrPnlDate.AddToLinkedControls(ucrReceiverDayTwo, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDayTwo.SetLinkedDisplayControl(lblDayofYear)
        ucrPnlDate.AddToLinkedControls(ucrChkTwoDigitYear, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=True)
        ucrChkTwoDigitYear.AddToLinkedControls(ucrNudCutoff, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudCutoff.SetLinkedDisplayControl(lblCutOffTwo)
        ucrPnlDate.AddToLinkedControls(ucrInputComboBoxMonthTwo, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="365/366")
        ucrReceiverYearTwo.SetLinkedDisplayControl(grpTwoColumns)

        'when rdoThreeColumn is checked
        ucrPnlDate.AddToLinkedControls(ucrReceiverYearThree, {rdoThreeColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYearThree.SetLinkedDisplayControl(lblYearThree)
        ucrPnlDate.AddToLinkedControls(ucrReceiverMonthThree, {rdoThreeColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMonthThree.SetLinkedDisplayControl(lblMonthThree)
        ucrPnlDate.AddToLinkedControls(ucrReceiverDayThree, {rdoThreeColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDayThree.SetLinkedDisplayControl(lblDayofMonth)
        ucrPnlDate.AddToLinkedControls(ucrInputYearOption, {rdoThreeColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="4 Digit")
        ucrInputYearOption.SetLinkedDisplayControl(lblYearOption)
        ucrPnlDate.AddToLinkedControls(ucrInputMonthOption, {rdoThreeColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Numeric")
        ucrInputMonthOption.SetLinkedDisplayControl(lblMonthOption)
        ucrReceiverYearThree.SetLinkedDisplayControl(grpThreeColumns)

        'TODO - To be linked uplater with the ucrinputFomat
        'ucrChkMore.SetText("More")
        ' ucrChkMore.Enabled = False
        grpFormatField.Visible = False
        'ucrPnlDate.AddToLinkedControls(ucrChkMore, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ' ucrChkMore.SetLinkedDisplayControl(grpFormatField)

        'ucrChkMore.AddToLinkedControls(ucrInputMonth, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrInputMonth.SetLinkedDisplayControl(lblMonth)
        'ucrChkMore.AddToLinkedControls(ucrInputYear, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrInputYear.SetLinkedDisplayControl(lblYear)
        'ucrChkMore.AddToLinkedControls(ucrInputDay, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrInputDay.SetLinkedDisplayControl(lblDay)
        'ucrChkMore.AddToLinkedControls(ucrInputSeparator, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrInputSeparator.SetLinkedDisplayControl(lblSeparator)
        ucrPnlDate.AddToLinkedControls(ucrPnlFormat, {rdoSingleColumn}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoDefaultFormat)
    End Sub

    Private Sub SetDefaults()
        'reset
        ucrSaveDate.Reset()
        ucrSelectorMakeDate.Reset()
        ucrInputFormat.Reset()
        ucrInputOrigin.Reset()

        clsDateFunction = New RFunction
        clsMakeYearDay = New RFunction
        clsMakeYearMonthDay = New RFunction

        clsDateFunction.SetRCommand("as.Date")
        clsMakeYearDay.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")
        clsMakeYearMonthDay.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")
        clsMakeYearMonthDay.AddParameter("day_format", Chr(34) & "%d" & Chr(34))
        clsDateFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDate.GetVariables())
        clsDateFunction.SetAssignTo(ucrSaveDate.GetText, strTempDataframe:=ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveDate.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDateFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlDate.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveDate.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrReceiverForDate.SetRCode(clsDateFunction, bReset)
        ucrInputFormat.SetRCode(clsDateFunction, bReset)
        ucrInputOrigin.SetRCode(clsDateFunction, bReset)

        ucrInputMonthOption.SetRCode(clsMakeYearMonthDay, bReset)
        ucrInputYearOption.SetRCode(clsMakeYearMonthDay, bReset)

        ucrInputComboBoxMonthTwo.SetRCode(clsMakeYearDay, bReset)
        ucrChkTwoDigitYear.SetRCode(clsMakeYearDay, bReset)

        ucrPnlFormat.SetRCode(clsDateFunction, bReset)

        ucrReceiverDayTwo.SetRCode(clsMakeYearDay, bReset)
        ucrReceiverYearTwo.SetRCode(clsMakeYearDay, bReset)
        ucrReceiverYearThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrReceiverMonthThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrReceiverDayThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrSelectorMakeDate.SetRCode(clsMakeYearMonthDay, bReset)
        ucrSelectorMakeDate.SetRCode(clsMakeYearDay, bReset)
        GroupBoxDisplayOnReOpen()
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SelectorHeader()
        If rdoDefaultFormat.Checked Then
            ucrReceiverForDate.strSelectorHeading = "Factors"
        ElseIf rdoSpecifyOrigin.Checked
            ucrReceiverForDate.strSelectorHeading = "Numerics"
        Else
            ucrReceiverForDate.strSelectorHeading = "Variables"
        End If
    End Sub

    Private Sub SetDefaultColumn()
        rdoSingleColumn.Checked = True
        SetRCodeForControls(True)
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
            ElseIf rdoTwoColumns.Checked Then
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

    Private Sub ucrBase_ClickOk_(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        SetHistory()
    End Sub

    Private Sub SetHistory()
        If Not ucrInputFormat.cboInput.Items.Contains(ucrInputFormat.GetText) Then
            ucrInputFormat.cboInput.Items.Insert(0, ucrInputFormat.GetText)
        Else
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDate.ControlValueChanged
        If rdoSingleColumn.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDateFunction)
        ElseIf rdoTwoColumns.Checked
            ucrBase.clsRsyntax.SetBaseRFunction(clsMakeYearDay)
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsMakeYearMonthDay)
        End If
        SetReceivers()
        SetRCodeForControls(False)
    End Sub

    Private Sub SetReceivers()
        If rdoSingleColumn.Checked Then
            ucrReceiverForDate.SetMeAsReceiver()
        ElseIf rdoTwoColumns.Checked
            ucrReceiverYearTwo.SetMeAsReceiver()
        Else
            ucrReceiverYearThree.SetMeAsReceiver()
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDayTwo.ControlContentsChanged, ucrSaveDate.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverForDate.ControlContentsChanged, ucrReceiverYearThree.ControlContentsChanged, ucrReceiverMonthThree.ControlContentsChanged, ucrReceiverDayThree.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlFormat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFormat.ControlValueChanged, ucrInputFormat.ControlValueChanged, ucrInputOrigin.ControlValueChanged
        If rdoDefaultFormat.Checked Then
            grpFormats.Hide()
            ucrReceiverForDate.SetIncludedDataTypes({"character", "factor"})
            ucrBase.clsRsyntax.RemoveParameter("format")
            ucrBase.clsRsyntax.RemoveParameter("origin")
        ElseIf rdoSpecifyOrigin.Checked
            grpFormats.Hide()
            ucrReceiverForDate.SetIncludedDataTypes({"numeric"})
        Else
            ucrReceiverForDate.SetIncludedDataTypes({"numeric", "character", "factor", "integer"})
            grpFormats.Show()
        End If
        SelectorHeader()
    End Sub

    'Temporary fix: This should be deleted since - this should be automatic
    Private Sub GroupBoxDisplayOnReOpen()
        If rdoSingleColumn.Checked Then
            grpSingleColumn.Visible = True
        ElseIf rdoTwoColumns.Checked Then
            grpTwoColumns.Visible = True
        Else
            grpThreeColumns.Visible = True
        End If
    End Sub
End Class