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


        'Not implemented 
        grpFormatField.Enabled = False
        ucrChkMore.Enabled = False

        'ucrReceiver
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

        ucrChkTwoDigitYear.SetText("2-digit years")
        ' ucrChkMore.SetText("More")

        'ucrSave Date Column
        ucrSaveDate.SetPrefix("Date")
        ucrSaveDate.SetSaveTypeAsColumn()
        ucrSaveDate.SetDataFrameSelector(ucrSelectorMakeDate.ucrAvailableDataFrames)
        ucrSaveDate.SetLabelText("Save Date:")
        ucrSaveDate.SetIsComboBox()

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

        ucrInputFormat.SetParameter(New RParameter("format", 1))
        Dim dctDateFormat As New Dictionary(Of String, String)
        dctDateFormat.Add("Year-Month-Day", Chr(34) & "%Y-%m-%d" & Chr(34))
        dctDateFormat.Add("Year/Month/Day", Chr(34) & "%Y/%m/%d" & Chr(34))
        dctDateFormat.Add("Day-Month-Year", Chr(34) & "%d%m%Y" & Chr(34))
        ucrInputFormat.SetItems(dctDateFormat)

        ucrInputOrigin.SetParameter(New RParameter("origin", 1))
        Dim dctdateorigin As New Dictionary(Of String, String)
        dctdateorigin.Add("excel", Chr(34) & "30-12-1899" & Chr(34))
        dctdateorigin.Add("gregorian", Chr(34) & "01-03-1600" & Chr(34))
        ucrInputOrigin.SetItems(dctdateorigin)

        'rdoSingle
        ucrReceiverForDate.SetParameter(New RParameter("x"))
        ucrReceiverForDate.SetParameterIsRFunction()

        ucrPnlDate.AddRadioButton(rdoSingleColumn)
        ucrPnlDate.AddRadioButton(rdoTwoColumn)
        ucrPnlDate.AddRadioButton(rdoThreeColumn)

        ucrPnlFormat.AddRadioButton(rdoDefaultFormat)
        ucrPnlFormat.AddRadioButton(rdoSpecifyFormat)
        ucrPnlFormat.AddRadioButton(rdoSpecifyOrigin)


        ucrPnlDate.AddFunctionNamesCondition(rdoTwoColumn, "as.date")
        ucrPnlDate.AddFunctionNamesCondition(rdoTwoColumn, frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")
        ucrPnlDate.AddFunctionNamesCondition(rdoTwoColumn, frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")

        'rdoYearDayofMonth
        ucrChkTwoDigitYear.SetParameter(New RParameter("year_format"))

        ucrReceiverYearTwo.SetParameter(New RParameter("year"))
        ucrReceiverYearTwo.SetParameterIsRFunction()

        ucrReceiverDayTwo.SetParameter(New RParameter("doy"))
        ucrReceiverDayTwo.SetParameterIsRFunction()

        'rdoYearMonthDay

        ucrReceiverYearThree.SetParameter(New RParameter("year"))
        ucrReceiverYearThree.SetParameterIsRFunction()

        ucrReceiverMonthThree.SetParameter(New RParameter("month"))
        ucrReceiverMonthThree.SetParameterIsRFunction()

        ucrReceiverDayThree.SetParameter(New RParameter("day"))
        ucrReceiverDayThree.SetParameterIsRFunction()

        ucrSelectorMakeDate.SetParameter(New RParameter("data_name", 0))
        ucrSelectorMakeDate.SetParameterIsString()


        'Single
        ucrPnlDate.AddToLinkedControls(ucrReceiverForDate, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDate.AddToLinkedControls(ucrPnlFormat, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDate.AddToLinkedControls(ucrChkMore, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDate.AddToLinkedControls(ucrInputMonth, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMonth.SetLinkedDisplayControl(lblMonth)
        ucrPnlDate.AddToLinkedControls(ucrInputYear, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputYear.SetLinkedDisplayControl(lblYear)
        ucrPnlDate.AddToLinkedControls(ucrInputDay, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputDay.SetLinkedDisplayControl(lblDay)
        ucrPnlDate.AddToLinkedControls(ucrInputSeparator, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputSeparator.SetLinkedDisplayControl(lblSeparator)
        ucrPnlDate.AddToLinkedControls(ucrInputOrigin, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDate.AddToLinkedControls(ucrInputFormat, {rdoSingleColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverForDate.SetLinkedDisplayControl(grpSingleColumn)

        'when rdoThreeColumn is checked
        ucrPnlDate.AddToLinkedControls(ucrReceiverYearThree, {rdoThreeColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYearThree.SetLinkedDisplayControl(lblYearThree)
        ucrPnlDate.AddToLinkedControls(ucrReceiverMonthThree, {rdoThreeColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMonthThree.SetLinkedDisplayControl(lblMonthThree)
        ucrPnlDate.AddToLinkedControls(ucrReceiverDayThree, {rdoThreeColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDayThree.SetLinkedDisplayControl(lblDayofMonth)
        ucrPnlDate.AddToLinkedControls(ucrInputYearOption, {rdoThreeColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputYearOption.SetLinkedDisplayControl(lblYearOption)
        ucrPnlDate.AddToLinkedControls(ucrInputMonthOption, {rdoThreeColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputMonthOption.SetLinkedDisplayControl(lblMonthOption)
        ucrPnlDate.AddToLinkedControls(ucrInputDayOption, {rdoThreeColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputDayOption.SetLinkedDisplayControl(lblDayOption)
        ucrReceiverYearThree.SetLinkedDisplayControl(grpThreeColumns)

        ucrPnlDate.AddToLinkedControls(ucrReceiverYearTwo, {rdoTwoColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, objNewDefaultState:=1)
        ucrReceiverYearTwo.SetLinkedDisplayControl(lblYearTwo)
        ucrPnlDate.AddToLinkedControls(ucrReceiverDayTwo, {rdoTwoColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverDayTwo.SetLinkedDisplayControl(lblDayofYear)
        ucrPnlDate.AddToLinkedControls(ucrChkTwoDigitYear, {rdoTwoColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlDate.AddToLinkedControls(ucrNudCutoff, {rdoTwoColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudCutoff.SetLinkedDisplayControl(lblCutOffTwo)
        ucrPnlDate.AddToLinkedControls(ucrInputComboBoxMonthTwo, {rdoTwoColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverYearTwo.SetLinkedDisplayControl(grpTwoColumns)

        'ucrInputSeparator.SetItems({"/", "-", "_", ".", ",", ";", ":"})
        'ucrInputYearOption.SetItems({"4 Digit", "2 Digit"})
        'ucrInputYear.SetItems({"4 Digit", "2 Digit"})
        'ucrInputMonth.SetItems({"Numerical", "Partial Word", "Full Word"})

    End Sub

    Private Sub SetDefaults()

        'reset
        ucrSaveDate.Reset()
        ucrSelectorMakeDate.Reset()
        ucrInputFormat.Reset()

        ucrReceiverForDate.Selector = ucrSelectorMakeDate
        ucrReceiverForDate.SetMeAsReceiver()

        clsDateFunction = New RFunction
        clsDateFunction.SetRCommand("as.Date")
        clsDateFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverForDate.GetVariables())
        ucrReceiverForDate.SetIncludedDataTypes({"character", "factor"})
        ucrReceiverForDate.AddParameterPresentCondition("origin", False)
        ucrReceiverForDate.AddParameterPresentCondition("format", False)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveDate.GetText, strTempDataframe:=ucrSelectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveDate.GetText, bAssignToIsPrefix:=False)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDateFunction)

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ' SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrReceiverMonthThree.SetRCode(clsMakeYearMonthDay, bReset)
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
            ElseIf rdoTwoColumn.Checked Then
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
            ucrReceiverForDate.SetMeAsReceiver()
            ucrBase.clsRsyntax.SetBaseRFunction(clsDateFunction)
        ElseIf rdoTwoColumn.Checked
            ucrReceiverYearTwo.SetMeAsReceiver()
            clsMakeYearDay.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_date_yeardoy")
            ucrBase.clsRsyntax.SetBaseRFunction(clsMakeYearDay)
        Else
            ucrReceiverYearThree.SetMeAsReceiver()
            clsMakeYearMonthDay.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$make_date_yearmonthday")
            ucrBase.clsRsyntax.SetBaseRFunction(clsMakeYearMonthDay)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDayTwo.ControlContentsChanged, ucrSaveDate.ControlContentsChanged, ucrReceiverYearTwo.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlFormat_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFormat.ControlValueChanged
        If rdoDefaultFormat.Checked Then
            ucrReceiverForDate.SetIncludedDataTypes({"character", "factor"})
        ElseIf rdoSpecifyOrigin.Checked
            ucrReceiverForDate.SetIncludedDataTypes({"numeric"})
        Else
            ucrReceiverForDate.SetIncludedDataTypes({"numeric", "character", "factor", "integer"})
        End If
    End Sub
End Class