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
Public Class dlgFrequency
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private clsMmtableFunction As New RFunction
    Private clsFrequencyOperator As New ROperator
    Private clsMmtableOperator As New ROperator
    Private clsSummariesHeaderLeftTopFunction, clsSummariesHeaderTopLeftFunction As New RFunction

    Private Sub dlgFrequency_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 425

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        cmdOptions.Enabled = False ' Temporarily disabled

        ucrSelectorFrequency.SetParameter(New RParameter("data_name", 0))
        ucrSelectorFrequency.SetParameterIsString()

        ucrReceiverFactors.SetParameter(New RParameter("factors", 1))
        ucrReceiverFactors.SetParameterIsString()
        ucrReceiverFactors.Selector = ucrSelectorFrequency
        ucrReceiverFactors.SetDataType("factor")
        ucrReceiverFactors.SetMeAsReceiver()

        ucrChkStoreResults.SetParameter(New RParameter("store_results", 2))
        ucrChkStoreResults.SetText("Store Results")
        ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkStoreResults.SetRDefault("FALSE")

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 3))
        ucrChkDisplayMargins.SetText("Display Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        ucrInputMarginName.SetParameter(New RParameter("margin_name", iNewPosition:=5))
        ucrInputMarginName.SetLinkedDisplayControl(lblMarginName)

        ucrNudSigFigs.SetParameter(New RParameter("signif_fig", 6))
        ucrNudSigFigs.SetMinMax(0, 22)
        ucrNudSigFigs.SetRDefault(2)

        ucrChkDisplayAsPercentage.SetParameter(New RParameter("percentage_type", 7))
        ucrChkDisplayAsPercentage.SetText("As Percentages")
        ucrChkDisplayAsPercentage.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkDisplayAsPercentage.SetRDefault(Chr(34) & "none" & Chr(34))

        ucrReceiverMultiplePercentages.SetParameter(New RParameter("perc_total_factors", 8))
        ucrReceiverMultiplePercentages.SetParameterIsString()
        ucrReceiverMultiplePercentages.Selector = ucrSelectorFrequency
        ucrReceiverMultiplePercentages.SetDataType("factor") ' TODO data this accepts must be in the other receiver too
        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrReceiverMultiplePercentages, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMultiplePercentages.SetLinkedDisplayControl(lblFactorsAsPercentage)

        ucrChkPercentageProportion.SetParameter(New RParameter("perc_decimal", 9))
        ucrChkPercentageProportion.SetText("Display as Decimal")
        ucrChkPercentageProportion.SetRDefault("FALSE")

        ucrNudColumnFactors.SetLinkedDisplayControl(lblColumnFactors)
        ucrNudColumnFactors.SetMinMax(iNewMin:=0)
        ucrNudColumnFactors.Increment = 1

        ucrChkDisplayAsPercentage.AddToLinkedControls(ucrChkPercentageProportion, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDisplayMargins.AddToLinkedControls(ucrInputMarginName, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="All")

        ucrChkDisplaySummariesAsRow.SetText("Display Summaries As Rows")
        ucrChkDisplaySummariesAsRow.Enabled = False


        ucrSaveTable.SetPrefix("frequency_table")
        ucrSaveTable.SetSaveTypeAsTable()
        ucrSaveTable.SetDataFrameSelector(ucrSelectorFrequency.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Save Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsMmtableFunction = New RFunction
        clsFrequencyOperator = New ROperator
        clsMmtableOperator = New ROperator
        clsSummariesHeaderTopLeftFunction = New RFunction
        clsSummariesHeaderLeftTopFunction = New RFunction

        ucrReceiverFactors.SetMeAsReceiver()
        ucrSelectorFrequency.Reset()
        ucrSaveTable.Reset()
        ucrNudColumnFactors.SetText(1)
        ucrBase.clsRsyntax.lstBeforeCodes.Clear()

        clsSummariesHeaderLeftTopFunction.SetPackageName("mmtable2")
        clsSummariesHeaderLeftTopFunction.SetRCommand("header_left_top")
        clsSummariesHeaderLeftTopFunction.AddParameter("variable", "summary", iPosition:=0)

        clsSummariesHeaderTopLeftFunction.SetPackageName("mmtable2")
        clsSummariesHeaderTopLeftFunction.SetRCommand("header_top_left")
        clsSummariesHeaderTopLeftFunction.AddParameter("variable", "summary", iPosition:=0)

        clsMmtableOperator.SetOperation("+")

        clsFrequencyOperator.SetOperation("+")
        clsFrequencyOperator.AddParameter("mmtable2", clsRFunctionParameter:=clsMmtableFunction, iPosition:=0)

        clsMmtableFunction.SetPackageName("mmtable2")
        clsMmtableFunction.SetRCommand("mmtable")
        clsMmtableFunction.AddParameter("data", "frequency_table", iPosition:=0)
        clsMmtableFunction.AddParameter("cells", "value", iPosition:=1)

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDefaultFunction.AddParameter("store_results", "FALSE", iPosition:=2)
        clsDefaultFunction.AddParameter("treat_columns_as_factor", "FALSE", iPosition:=10)
        clsDefaultFunction.AddParameter("summaries", "count_label", iPosition:=11)
        clsDefaultFunction.SetAssignTo("frequency_table")

        ucrBase.clsRsyntax.AddToBeforeCodes(clsDefaultFunction, 0)
        ucrBase.clsRsyntax.SetBaseROperator(clsFrequencyOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrInputMarginName.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverFactors.SetRCode(clsDefaultFunction, bReset)
        ucrChkDisplayMargins.SetRCode(clsDefaultFunction, bReset)
        ucrChkStoreResults.SetRCode(clsDefaultFunction, bReset)
        ucrSelectorFrequency.SetRCode(clsDefaultFunction, bReset)
        ucrChkPercentageProportion.SetRCode(clsDefaultFunction, bReset)
        ucrChkDisplayAsPercentage.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverMultiplePercentages.SetRCode(clsDefaultFunction, bReset)
        ucrNudSigFigs.SetRCode(clsDefaultFunction, bReset)
        ucrSaveTable.SetRCode(clsFrequencyOperator, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverFactors.IsEmpty _
           OrElse String.IsNullOrEmpty(ucrNudColumnFactors.GetText()) _
           OrElse Not ucrSaveTable.IsComplete _
           OrElse String.IsNullOrEmpty(ucrNudSigFigs.GetText()) _
           OrElse ucrReceiverFactors.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SettingReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayAsPercentage.ControlValueChanged
        If ucrChkDisplayAsPercentage.Checked Then
            ucrReceiverMultiplePercentages.SetMeAsReceiver()
        Else
            ucrReceiverFactors.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlContentsChanged,
        ucrSaveTable.ControlContentsChanged, ucrNudSigFigs.ControlContentsChanged, ucrNudColumnFactors.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactors.ControlValueChanged, ucrNudColumnFactors.ControlValueChanged
        If ucrReceiverFactors.IsEmpty OrElse String.IsNullOrEmpty(ucrNudColumnFactors.GetText()) Then
            Exit Sub
        End If

        Dim iColumn As Integer = 1
        Dim iNumberOfColumns As Integer
        clsMmtableOperator.ClearParameters()

        iNumberOfColumns = ucrNudColumnFactors.GetText()
        For Each strcolumn As String In ucrReceiverFactors.GetVariableNamesAsList
            If iColumn <= iNumberOfColumns Then
                Dim clsHeaderLeftFunction As New RFunction
                clsHeaderLeftFunction.SetPackageName("mmtable2")
                clsHeaderLeftFunction.SetRCommand("header_top_left")
                clsHeaderLeftFunction.AddParameter("variable", strcolumn, iPosition:=0)
                clsMmtableOperator.AddParameter(strcolumn, clsRFunctionParameter:=clsHeaderLeftFunction, iPosition:=iColumn)
            Else
                Dim clsHeaderTopFunction As New RFunction
                clsHeaderTopFunction.SetPackageName("mmtable2")
                clsHeaderTopFunction.SetRCommand("header_left_top")
                clsHeaderTopFunction.AddParameter("variable", strcolumn, iPosition:=0)
                clsMmtableOperator.AddParameter(strcolumn, clsRFunctionParameter:=clsHeaderTopFunction, iPosition:=iColumn)
            End If
            iColumn += 1
        Next
        clsFrequencyOperator.AddParameter("columnOp", clsROperatorParameter:=clsMmtableOperator, iPosition:=1)
    End Sub
End Class