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
Public Class dlgMakeDate
    Public clsPaste As New RFunction
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""
    Private strSelectedDataFrame As String = ""
    Private clsDateFunction, clsMakeYearDay, clsHelp, clsMakeYearMonthDay, clsDefaultDate, clsRDefaultDate, clsGregorianDefault, clsJulianDateDefault, clsAsCharacterFunction As New RFunction
    Private clsDivisionOperator, clsMultiplicationOperator As New ROperator

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
        Dim dctYearItems As New Dictionary(Of String, String)
        Dim dctMonthItems As New Dictionary(Of String, String)
        Dim dctMonthTwoItems As New Dictionary(Of String, String)
        Dim dctDateFormat As New Dictionary(Of String, String)

        clsHelp = New RFunction

        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("topic", Chr(34) & "strptime" & Chr(34))
        clsHelp.AddParameter("package", Chr(34) & "base" & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))

        'Help ID
        ucrBase.iHelpTopicID = 461
        txtTextDateFormats.ReadOnly = True


        dctMonthItems.Add("Numeric", Chr(34) & "%m" & Chr(34))
        dctMonthItems.Add("Abbreviation", Chr(34) & "%b" & Chr(34))
        dctMonthItems.Add("Full Name", Chr(34) & "%B" & Chr(34))

        ucrInputMonthOption.SetParameter(New RParameter("month_format", 5))
        ucrInputMonthOption.SetItems(dctMonthItems)
        ucrInputMonthOption.SetDropDownStyleAsNonEditable()

        dctMonthTwoItems.Add("365/366", Chr(34) & "365/366" & Chr(34))
        dctMonthTwoItems.Add("366", Chr(34) & "366" & Chr(34))

        ucrInputComboBoxMonthTwo.SetParameter(New RParameter("doy_typical_length", 3))
        ucrInputComboBoxMonthTwo.SetItems(dctMonthTwoItems)
        ucrInputComboBoxMonthTwo.SetDropDownStyleAsNonEditable()

        dctDateFormat.Add("Year(4-digit)-Month-Day", Chr(34) & "%Y-%m-%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)/Month/Day", Chr(34) & "%Y/%m/%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)-Month(Full Name)-Day", Chr(34) & "%Y-%B-%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)/Month(Full Name)/Day", Chr(34) & "%Y/%B/%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)-Month(abbr)-Day", Chr(34) & "%Y-%b-%d" & Chr(34))
        dctDateFormat.Add("Year(4-digit)/Month(abbr)/Day", Chr(34) & "%Y/%b/%d" & Chr(34))
        dctDateFormat.Add("Year(4 digit)MonthDay(YEARMODA)", Chr(34) & "%Y%m%d" & Chr(34))

        dctDateFormat.Add("Year(4-digit)Doy(Julian)", Chr(34) & "%Y%j" & Chr(34))

        dctDateFormat.Add("Day-Month-Year(4-digit)", Chr(34) & "%d-%m-%Y" & Chr(34))
        dctDateFormat.Add("Day/Month/Year(4-digit)", Chr(34) & "%d/%m/%Y" & Chr(34))
        dctDateFormat.Add("Day-Month(Full Name)-Year(4-digit)", Chr(34) & "%d-%B-%Y" & Chr(34))
        dctDateFormat.Add("Day/Month(Full Name)/Year(4-digit)", Chr(34) & "%d/%B/%Y" & Chr(34))
        dctDateFormat.Add("Day-Month(abbr)-Year(4-digit)", Chr(34) & "%d-%b-%Y" & Chr(34))
        dctDateFormat.Add("Day/Month(abbr)/Year(4-digit)", Chr(34) & "%d/%b/%Y" & Chr(34))

        dctDateFormat.Add("Month-Day-Year(4-digit)", Chr(34) & "%m-%d-%Y" & Chr(34))
        dctDateFormat.Add("Month/Day/Year(4-digit)", Chr(34) & "%m/%d/%Y" & Chr(34))
        dctDateFormat.Add("Month(Full Name)-Day-Year(4-digit)", Chr(34) & "%B-%d-%Y" & Chr(34))
        dctDateFormat.Add("Month(Full Name)/Day/Year(4-digit)", Chr(34) & "%B/%d/%Y" & Chr(34))
        dctDateFormat.Add("Month(abbr)-Day-Year(4-digit)", Chr(34) & "%b-%d-%Y" & Chr(34))
        dctDateFormat.Add("Month(abbr)/Day/Year(4-digit)", Chr(34) & "%b/%d/%Y" & Chr(34))

        ucrInputFormat.SetParameter(New RParameter("format", 1))
        ucrInputFormat.SetItems(dctDateFormat)
        ucrInputFormat.SetDropDownStyleAsEditable(bAdditionsAllowed:=True)

        ucrInputOrigin.SetItems({"R (1970/01/01)", "Excel (1899/12/30)", "Gregorian (1600/03/01)", "Julian Day Number (-4713/11/24)", "Specify"})
        ucrInputOrigin.SetDropDownStyleAsNonEditable()
        ucrInputOrigin.AddToLinkedControls(ucrDtpSpecifyOrigin, {"Specify"}, bNewLinkedHideIfParameterMissing:=True)

        dctYearItems.Add("4 Digit", Chr(34) & "%Y" & Chr(34))
        dctYearItems.Add("2 Digit", Chr(34) & "%y" & Chr(34))

        ucrInputYearOption.SetParameter(New RParameter("year_format", 6))
        ucrInputYearOption.SetItems(dctYearItems)
        ucrInputYearOption.SetDropDownStyleAsNonEditable()

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
        ucrPnlFormat.AddRadioButton(rdoOrigin)
        ucrPnlFormat.AddToLinkedControls(ucrInputFormat, {rdoSpecifyFormat}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Year(4-digit)-Month-Day")
        ucrPnlFormat.AddToLinkedControls(ucrInputOrigin, {rdoOrigin}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Excel(1899/12/30)")

        ttMakeDate.SetToolTip(rdoDefaultFormat, "This will try 'Year(4-digit)-Month-Day %Y-%m-%d' then 'Year(4-digit)/Month/Day %Y/%m/%d' on the first non-NA element")

        ucrPnlDate.AddFunctionNamesCondition(rdoSingleColumn, "as.Date")
        ucrPnlDate.AddFunctionNamesCondition(rdoTwoColumns, frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")
        ucrPnlDate.AddFunctionNamesCondition(rdoThreeColumns, frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")

        'ucrSave Date Column
        ucrSaveDate.SetPrefix("date")
        ucrSaveDate.SetSaveTypeAsColumn()
        ucrSaveDate.SetDataFrameSelector(ucrSelectorMakeDate.ucrAvailableDataFrames)
        ucrSaveDate.SetLabelText("Save Date:")
        ucrSaveDate.SetIsComboBox()

        ucrChkTwoDigitYear.SetParameter(New RParameter("year_format", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "%y" & Chr(34), strNewValueIfUnchecked:=Chr(34) & "%Y" & Chr(34))
        ucrChkTwoDigitYear.SetText("2-digit years")
        ucrChkTwoDigitYear.AddToLinkedControls(ucrNudCutoff, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudCutoff.SetLinkedDisplayControl(lblCutOffTwo)

        'rdoSingle
        ucrReceiverForDate.SetParameter(New RParameter("x", 0))
        ucrReceiverForDate.SetParameterIsRFunction()

        'rdoYearDayofMonth
        ucrReceiverYearTwo.SetParameter(New RParameter("year", 2))
        ucrReceiverYearTwo.SetParameterIsString()

        ucrReceiverDayTwo.SetParameter(New RParameter("doy", 1))
        ucrReceiverDayTwo.SetParameterIsString()

        'rdoYearMonthDay
        ucrPnlYearType.AddRadioButton(rdoYearColumn)
        ucrPnlYearType.AddRadioButton(rdoYearValue)
        ucrPnlYearType.AddParameterPresentCondition(rdoYearColumn, "year")
        ucrPnlYearType.AddParameterPresentCondition(rdoYearColumn, "f_year")
        ucrPnlYearType.AddToLinkedControls(ucrReceiverYearThree, {rdoYearColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlYearType.AddToLinkedControls(ucrInputYearThree, {rdoYearValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverYearThree.SetParameter(New RParameter("year", 3))
        ucrReceiverYearThree.SetParameterIsString()

        ucrInputYearThree.SetParameter(New RParameter("f_year", 6))
        ucrInputYearThree.SetValidationTypeAsNumeric()

        ucrPnlMonthType.AddRadioButton(rdoMonthColumn)
        ucrPnlMonthType.AddRadioButton(rdoMonthValue)
        ucrPnlMonthType.AddParameterPresentCondition(rdoYearColumn, "month")
        ucrPnlMonthType.AddParameterPresentCondition(rdoYearColumn, "f_month")
        ucrPnlMonthType.AddToLinkedControls(ucrReceiverMonthThree, {rdoMonthColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMonthType.AddToLinkedControls(ucrInputMonthThree, {rdoMonthValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        ucrReceiverMonthThree.SetParameter(New RParameter("month", 2))
        ucrReceiverMonthThree.SetParameterIsString()

        ucrInputMonthThree.SetParameter(New RParameter("f_month", 5))
        ucrInputMonthThree.SetValidationTypeAsNumeric(dcmMin:=1, dcmMax:=12)

        ucrPnlDayType.AddRadioButton(rdoDayColumn)
        ucrPnlDayType.AddRadioButton(rdoDayValue)
        ucrPnlDayType.AddParameterPresentCondition(rdoDayColumn, "day")
        ucrPnlDayType.AddParameterPresentCondition(rdoDayValue, "f_day")
        ucrPnlDayType.AddToLinkedControls(ucrReceiverDayThree, {rdoDayColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDayType.AddToLinkedControls(ucrInputDayThree, {rdoDayValue}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)

        ucrReceiverDayThree.SetParameter(New RParameter("day", 1))
        ucrReceiverDayThree.SetParameterIsString()

        ucrInputDayThree.SetParameter(New RParameter("f_day", 4))
        ucrInputDayThree.SetValidationTypeAsNumeric(dcmMin:=1, dcmMax:=31)

        ucrSelectorMakeDate.SetParameter(New RParameter("data_name", 0))
        ucrSelectorMakeDate.SetParameterIsString()

        ucrDtpSpecifyOrigin.SetParameter(New RParameter("origin", 1))
        ucrDtpSpecifyOrigin.SetParameterIsRDate()

        clsRDefaultDate = New RFunction
        clsRDefaultDate.SetRCommand("as.Date")
        clsRDefaultDate.AddParameter("x", Chr(34) & "1970/01/01" & Chr(34))

        clsDefaultDate = New RFunction
        clsDefaultDate.SetRCommand("as.Date")
        clsDefaultDate.AddParameter("x", Chr(34) & "1899/12/30" & Chr(34))

        clsGregorianDefault = New RFunction
        clsGregorianDefault.SetRCommand("as.Date")
        clsGregorianDefault.AddParameter("x", Chr(34) & "1600/03/01" & Chr(34))

        clsJulianDateDefault = New RFunction
        clsJulianDateDefault.SetRCommand("structure")
        clsJulianDateDefault.AddParameter("x", "-2440588", bIncludeArgumentName:=False)
        clsJulianDateDefault.AddParameter("class", Chr(34) & "Date" & Chr(34))

        clsAsCharacterFunction = New RFunction
        clsAsCharacterFunction.SetRCommand("as.character")

        ''when rdoSingleColumn is checked
        ucrPnlDate.AddToLinkedControls(ucrPnlFormat, {rdoSingleColumn}, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoDefaultFormat)

        'when rdoTwoColumn is checked
        ucrPnlDate.AddToLinkedControls(ucrInputComboBoxMonthTwo, {rdoTwoColumns}, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="366")

        ucrInputUnits.SetItems({"Days", "Hours", "Minutes", "Seconds"})
        ucrInputUnits.AddParameterPresentCondition("Days", "hours", bNewIsPositive:=False)
        ucrInputUnits.AddParameterPresentCondition("Days", "minutes", bNewIsPositive:=False)
        ucrInputUnits.AddParameterPresentCondition("Days", "seconds", bNewIsPositive:=False)
        ucrInputUnits.AddParameterPresentCondition("Hours", "hours")
        ucrInputUnits.AddParameterPresentCondition("Hours", "minutes", bNewIsPositive:=False)
        ucrInputUnits.AddParameterPresentCondition("Hours", "seconds", bNewIsPositive:=False)
        ucrInputUnits.AddParameterPresentCondition("Minutes", "hours")
        ucrInputUnits.AddParameterPresentCondition("Minutes", "minutes")
        ucrInputUnits.AddParameterPresentCondition("Minutes", "seconds", bNewIsPositive:=False)
        ucrInputUnits.AddParameterPresentCondition("Seconds", "hours")
        ucrInputUnits.AddParameterPresentCondition("Seconds", "minutes")
        ucrInputUnits.AddParameterPresentCondition("Seconds", "seconds")
        ucrInputUnits.SetDropDownStyleAsNonEditable()

        'when rdoThreeColumn is checked
        ucrPnlDate.AddToLinkedControls(ucrPnlYearType, {rdoThreeColumns}, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoYearColumn)
        ucrPnlDate.AddToLinkedControls(ucrPnlMonthType, {rdoThreeColumns}, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoMonthColumn)
        ucrPnlDate.AddToLinkedControls(ucrPnlDayType, {rdoThreeColumns}, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoDayColumn)
        ucrInputOrigin.AddToLinkedControls(ucrInputUnits, {"Specify"}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Days")
        ucrInputUnits.SetLinkedDisplayControl(lblUnits)

        'TODO - Add ucrinputFomat to construct format
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
        grpFormatField.Visible = False
    End Sub

    Private Sub SetDefaults()
        clsDateFunction = New RFunction
        clsMakeYearDay = New RFunction
        clsMakeYearMonthDay = New RFunction
        clsDivisionOperator = New ROperator
        clsMultiplicationOperator = New ROperator

        ucrSaveDate.Reset()
        ucrSelectorMakeDate.Reset()
        ucrInputFormat.Reset()
        ucrInputOrigin.Reset()

        clsMakeYearDay.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")
        clsMakeYearDay.AddParameter("year_format", Chr(34) & "%Y" & Chr(34))

        clsMakeYearMonthDay.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")
        clsMakeYearMonthDay.AddParameter("year_format", Chr(34) & "%Y" & Chr(34))
        clsMakeYearMonthDay.AddParameter("month_format", Chr(34) & "%m" & Chr(34))

        clsDateFunction.SetRCommand("as.Date")
        clsDateFunction.AddParameter("x", clsROperatorParameter:=clsDivisionOperator, iPosition:=0)
        clsDateFunction.AddParameter("origin", clsRFunctionParameter:=clsDefaultDate, iPosition:=1)

        clsDivisionOperator.SetOperation("/")
        clsDivisionOperator.bAllBrackets = True

        clsMultiplicationOperator.SetOperation("*")

        clsDateFunction.SetAssignTo(ucrSaveDate.GetText, strTempDataframe:=ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveDate.GetText)
        clsMakeYearMonthDay.SetAssignTo(ucrSaveDate.GetText, strTempDataframe:=ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveDate.GetText)
        clsMakeYearDay.SetAssignTo(ucrSaveDate.GetText, strTempDataframe:=ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveDate.GetText)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDateFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverForDate.AddAdditionalCodeParameterPair(clsAsCharacterFunction, New RParameter("x", 0, False), iAdditionalPairNo:=1)

        ucrPnlDate.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)

        ucrSaveDate.AddAdditionalRCode(clsMakeYearDay, iAdditionalPairNo:=1)
        ucrSaveDate.AddAdditionalRCode(clsMakeYearMonthDay, iAdditionalPairNo:=2)

        ucrSaveDate.SetRCode(clsDateFunction, bReset)

        ucrSaveDate.SetRCode(clsDateFunction, bReset)

        ucrInputUnits.SetRCode(clsMultiplicationOperator, bReset)
        ucrReceiverForDate.SetRCode(clsDivisionOperator, bReset)
        ucrInputFormat.SetRCode(clsDateFunction, bReset)
        ucrInputOrigin.SetRCode(clsDateFunction, bReset)
        ucrDtpSpecifyOrigin.SetRCode(clsDateFunction, bReset)

        ucrInputMonthOption.SetRCode(clsMakeYearMonthDay, bReset)
        ucrInputYearOption.SetRCode(clsMakeYearMonthDay, bReset)

        ucrInputComboBoxMonthTwo.SetRCode(clsMakeYearDay, bReset)
        ucrChkTwoDigitYear.SetRCode(clsMakeYearDay, bReset)

        ucrPnlFormat.SetRCode(clsDateFunction, bReset)

        ucrReceiverDayTwo.SetRCode(clsMakeYearDay, bReset)
        ucrReceiverYearTwo.SetRCode(clsMakeYearDay, bReset)

        ucrReceiverYearThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrInputYearThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrPnlYearType.SetRCode(clsMakeYearMonthDay, bReset)

        ucrReceiverMonthThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrInputMonthThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrPnlMonthType.SetRCode(clsMakeYearMonthDay, bReset)

        ucrReceiverDayThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrInputDayThree.SetRCode(clsMakeYearMonthDay, bReset)
        ucrPnlDayType.SetRCode(clsMakeYearMonthDay, bReset)

        ucrSelectorMakeDate.SetRCode(clsMakeYearMonthDay, bReset)

        GroupBoxSettings()
        DataFrameParameter()
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
                If ((rdoDayColumn.Checked AndAlso Not ucrReceiverDayThree.IsEmpty) OrElse (rdoDayValue.Checked AndAlso Not ucrInputDayThree.IsEmpty)) AndAlso
                    ((rdoMonthColumn.Checked AndAlso Not ucrReceiverMonthThree.IsEmpty) OrElse (rdoMonthValue.Checked AndAlso Not ucrInputMonthThree.IsEmpty)) AndAlso
                    ((rdoYearColumn.Checked AndAlso Not ucrReceiverYearThree.IsEmpty) OrElse (rdoYearValue.Checked AndAlso Not ucrInputYearThree.IsEmpty)) Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk_(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        SetHistory()
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        frmMain.clsRLink.RunScript(clsHelp.ToScript, iCallType:=2, strComment:="Display Help page for Date-Time Conversion Functions", bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SelectorHeader()
        If rdoDefaultFormat.Checked Then
            ucrReceiverForDate.strSelectorHeading = "Non Numerics"
        ElseIf rdoOrigin.Checked Then
            ucrReceiverForDate.strSelectorHeading = "Numerics"
        Else
            ucrReceiverForDate.strSelectorHeading = "Variables"
        End If
    End Sub

    Private Sub SetDefaultColumn()
        rdoSingleColumn.Checked = True
        ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverForDate.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub SetHistory()
        If Not ucrInputFormat.cboInput.Items.Contains(ucrInputFormat.GetText) Then
            ucrInputFormat.cboInput.Items.Insert(0, ucrInputFormat.GetText)
        Else
        End If
    End Sub

    Private Sub ucrPnlFormat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFormat.ControlValueChanged, ucrInputFormat.ControlValueChanged, ucrInputOrigin.ControlValueChanged
        ucrReceiverForDate.RemoveIncludedMetadataProperty("class")
        clsDateFunction.RemoveParameterByName("yearmoda")
        clsDateFunction.AddParameter("x", clsROperatorParameter:=clsDivisionOperator, iPosition:=0)
        If rdoDefaultFormat.Checked Then
            cmdHelp.Visible = False
            ucrReceiverForDate.SetExcludedDataTypes({"numeric"})
            clsDateFunction.RemoveParameterByName("format")
            clsDateFunction.RemoveParameterByName("origin")
        ElseIf rdoOrigin.Checked Then
            cmdHelp.Visible = False
            ucrReceiverForDate.SetIncludedDataTypes({"numeric"})
            If ucrInputOrigin.GetText = "Excel (1899/12/30)" Then
                clsDateFunction.AddParameter("origin", clsRFunctionParameter:=clsDefaultDate)
            ElseIf ucrInputOrigin.GetText = "Gregorian (1600/03/01)" Then
                clsDateFunction.AddParameter("origin", clsRFunctionParameter:=clsGregorianDefault)
            ElseIf ucrInputOrigin.GetText = "Julian Day Number (-4713/11/24)" Then
                clsDateFunction.AddParameter("origin", clsRFunctionParameter:=clsJulianDateDefault)
            ElseIf ucrInputOrigin.GetText = "R (1970/01/01)" Then
                clsDateFunction.AddParameter("origin", clsRFunctionParameter:=clsRDefaultDate)
            End If
        ElseIf rdoSpecifyFormat.Checked Then
            cmdHelp.Visible = True
            ucrReceiverForDate.RemoveExcludedMetadataProperty("class")
            clsDateFunction.AddParameter("yearmoda", clsRFunctionParameter:=clsAsCharacterFunction, bIncludeArgumentName:=False, iPosition:=0)
            clsDateFunction.RemoveParameterByName("x")
            clsDateFunction.RemoveParameterByName("origin")
        End If
        grpFormats.Visible = (rdoSpecifyFormat.Checked)
        If Not ucrReceiverForDate.IsEmpty AndAlso Not ucrSelectorMakeDate.ContainsVariable(ucrReceiverForDate.GetVariableNames(False)) Then
            ucrReceiverForDate.Clear()
        End If
        SelectorHeader()
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDate.ControlValueChanged
        GroupBoxSettings()
    End Sub

    Private Sub GroupBoxSettings()
        If rdoSingleColumn.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsDateFunction)
            ucrReceiverForDate.SetMeAsReceiver()
            grpSingleColumn.Show()
            grpTwoColumns.Hide()
            grpThreeColumns.Hide()
            cmdHelp.Visible = True
            grpFormats.Visible = (rdoSpecifyFormat.Checked)
        ElseIf rdoTwoColumns.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsMakeYearDay)
            ucrReceiverYearTwo.SetMeAsReceiver()
            grpSingleColumn.Hide()
            grpTwoColumns.Show()
            grpThreeColumns.Hide()
            cmdHelp.Visible = False
            grpFormats.Hide()
        Else
            ucrBase.clsRsyntax.SetBaseRFunction(clsMakeYearMonthDay)
            If rdoYearColumn.Checked Then
                ucrReceiverYearThree.SetMeAsReceiver()
            ElseIf rdoMonthColumn.Checked Then
                ucrReceiverMonthThree.SetMeAsReceiver()
            ElseIf rdoDayColumn.Checked Then
                ucrReceiverDayThree.SetMeAsReceiver()
            End If
            grpSingleColumn.Hide()
            grpTwoColumns.Hide()
            grpThreeColumns.Show()
            cmdHelp.Visible = False
            grpFormats.Hide()
        End If
    End Sub

    Private Sub ucrSelectorMakeDate_DataFrameChanged() Handles ucrSelectorMakeDate.DataFrameChanged
        DataFrameParameter()
    End Sub

    Private Sub DataFrameParameter()
        If ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            clsMakeYearDay.AddParameter("data_name", Chr(34) & ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
        End If
    End Sub

    Private Sub ucrPnlMonthType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMonthType.ControlValueChanged
        If rdoThreeColumns.Checked Then
            If rdoMonthColumn.Checked Then
                ucrReceiverMonthThree.SetMeAsReceiver()
            ElseIf rdoMonthValue.Checked Then
                ucrInputMonthOption.SetName("Numeric")
            End If
        End If
        ucrInputMonthOption.Enabled = (rdoMonthColumn.Checked)
    End Sub

    Private Sub ucrPnlDayType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlDayType.ControlValueChanged
        If rdoThreeColumns.Checked Then
            If rdoDayColumn.Checked Then
                ucrReceiverDayThree.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub ucrPnlYearType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlYearType.ControlValueChanged
        If rdoThreeColumns.Checked Then
            If rdoYearColumn.Checked Then
                ucrReceiverYearThree.SetMeAsReceiver()
            End If
        End If
    End Sub

    Private Sub ucrInputUnits_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputUnits.ControlValueChanged
        If ucrInputUnits.GetText() = "Days" Then
            clsDivisionOperator.RemoveParameterByName("division")
        Else
            clsDivisionOperator.AddParameter("division", clsROperatorParameter:=clsMultiplicationOperator, iPosition:=1)
            clsMultiplicationOperator.RemoveParameterByName("hours")
            clsMultiplicationOperator.RemoveParameterByName("minutes")
            clsMultiplicationOperator.RemoveParameterByName("seconds")
            Select Case ucrInputUnits.GetText()
                Case "Hours"
                    clsMultiplicationOperator.AddParameter("hours", 24, iPosition:=0)
                Case "Minutes"
                    clsMultiplicationOperator.AddParameter("hours", 24, iPosition:=0)
                    clsMultiplicationOperator.AddParameter("minutes", 60, iPosition:=1)
                Case "Seconds"
                    clsMultiplicationOperator.AddParameter("hours", 24, iPosition:=0)
                    clsMultiplicationOperator.AddParameter("minutes", 60, iPosition:=1)
                    clsMultiplicationOperator.AddParameter("seconds", 60, iPosition:=2)
            End Select
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDayTwo.ControlContentsChanged, ucrSaveDate.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged, ucrReceiverForDate.ControlContentsChanged, ucrReceiverYearThree.ControlContentsChanged, ucrReceiverMonthThree.ControlContentsChanged, ucrReceiverDayThree.ControlContentsChanged, ucrInputDayThree.ControlContentsChanged, ucrInputMonthThree.ControlContentsChanged, ucrInputYearThree.ControlContentsChanged, ucrPnlYearType.ControlContentsChanged, ucrPnlMonthType.ControlContentsChanged, ucrPnlDayType.ControlContentsChanged, ucrPnlDate.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class