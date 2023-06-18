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

Public Class dlgCalculateTreatmentDifferences
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Public bRCodeSet As Boolean = True
    Private bCutCheck As Boolean = False
    Private bDefaultsSet As Boolean = True

    Public clsDCast As New RFunction
    Public clsDCastFormula As New ROperator
    Public clsDCastLeftFormula As New ROperator
    Public clsDCastLeftContextFormula As New ROperator
    Public clsPipeOperator As New ROperator
    Public clsMutate As New RFunction
    Public clsDiffOperator As New ROperator
    Public clsCut As New RFunction
    Public clsCutBreaks As New RFunction
    Public clsCutLabels As New RFunction

    Private Sub dlgCalculateTreatmentDifferences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 581
        ucrChkCalculateDiffCategories.SetText("Calculate Difference Categories")
        ucrChkCalculateDiffCategories.AddToLinkedControls(ucrInputBreakPoints, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCalculateDiffCategories.AddToLinkedControls(ucrInputLabels, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkCalculateDiffCategories.AddToLinkedControls(ucrInputCategoryColumn, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputBreakPoints.SetValidationTypeAsNumericList(bNewAllowInf:=True)
        ucrInputBreakPoints.SetLinkedDisplayControl(lblBreakPoints)

        ucrInputLabels.SetValidationTypeAsList()
        ucrInputLabels.IsMultiline = True
        ucrInputLabels.SetLinkedDisplayControl(lblLabels)

        ucrChkCalculateDiffCategories.SetLinkedDisplayControl(lblCategoryColumn)

        ucrSelectorDifference.SetParameterIsrfunction()
        ucrSelectorDifference.SetParameter(New RParameter("0", iNewPosition:=0, bNewIncludeArgumentName:=False))

        ucrReceiverMeasurement.SetParameter(New RParameter("value.var", 7))
        ucrReceiverMeasurement.Selector = ucrSelectorDifference
        ucrReceiverMeasurement.SetIncludedDataTypes({"numeric"})
        ucrReceiverMeasurement.strSelectorHeading = "Measurements"
        ucrReceiverMeasurement.SetParameterIsString()
        ucrReceiverMeasurement.SetOptionsByContextTypesAllMeasurements()

        ucrReceiverOption.SetParameter(New RParameter("1", 1))
        ucrReceiverOption.Selector = ucrSelectorDifference
        ucrReceiverOption.SetIncludedDataTypes({"factor"})
        ucrReceiverOption.strSelectorHeading = "Options"
        ucrReceiverOption.SetParameterIsString()
        ucrReceiverOption.bWithQuotes = False
        ucrReceiverOption.SetOptionsByContextTypesAllOptions()

        ucrReceiverContexts.Selector = ucrSelectorDifference
        ucrReceiverContexts.SetOptionsByContextTypesAllOptionsContextsBlockings()
        ucrReceiverContexts.strSelectorHeading = "Contexts,Options,Blocks"

        ucrInputFactorOption1.SetParameter(New RParameter("0", 0))
        ucrInputFactorOption1.SetFactorReceiver(ucrReceiverOption)
        ucrInputFactorOption1.AddQuotesIfUnrecognised = False
        ucrInputFactorOption1.strQuotes = "`"

        ucrInputFactorOption2.SetParameter(New RParameter("1", 1))
        ucrInputFactorOption2.SetFactorReceiver(ucrReceiverOption)
        ucrInputFactorOption2.AddQuotesIfUnrecognised = False
        ucrInputFactorOption2.strQuotes = "`"

        ucrReceiverID.SetParameter(New RParameter("0", 0))
        ucrReceiverID.Selector = ucrSelectorDifference
        ucrReceiverID.SetParameterIsString()
        ucrReceiverID.bWithQuotes = False
        ucrReceiverID.strSelectorHeading = "IDs"
        ucrReceiverID.SetOptionsByContextTypesAllIDs()

        ucrSaveDataFrame.SetIsTextBox()
        ucrSaveDataFrame.SetLabelText("New Data Frame Name:")
        ucrSaveDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveDataFrame.SetDataFrameSelector(ucrSelectorDifference.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsPipeOperator = New ROperator
        clsDCast = New RFunction
        clsDCastFormula = New ROperator
        clsMutate = New RFunction
        clsDiffOperator = New ROperator
        clsCut = New RFunction
        clsCutBreaks = New RFunction
        clsCutLabels = New RFunction

        bDefaultsSet = False
        ucrSelectorDifference.Reset()
        ucrSaveDataFrame.Reset()

        clsPipeOperator.SetOperation("%>%")

        clsPipeOperator.AddParameter("1", clsRFunctionParameter:=clsDCast, iPosition:=1)
        clsPipeOperator.AddParameter("2", clsRFunctionParameter:=clsMutate, iPosition:=2)

        clsDCast.SetPackageName("reshape2")
        clsDCast.SetRCommand("dcast")
        clsDCast.AddParameter("formula", clsROperatorParameter:=clsDCastFormula, iPosition:=1)
        clsDCast.AddParameter("fun.aggregate", "mean", iPosition:=2)

        clsDCastFormula.SetOperation("~")
        clsDCastFormula.AddParameter("0", clsROperatorParameter:=clsDCastLeftFormula, iPosition:=0)
        clsDCastFormula.bBrackets = False

        clsDCastLeftFormula.SetOperation("+")
        clsDCastLeftFormula.bBrackets = False

        clsDCastLeftContextFormula.SetOperation("+")
        clsDCastLeftContextFormula.bBrackets = False

        clsMutate.SetPackageName("dplyr")
        clsMutate.SetRCommand("mutate")

        clsDiffOperator.SetOperation("-")

        clsCut.SetRCommand("cut")
        clsCut.AddParameter("breaks", clsRFunctionParameter:=clsCutBreaks, iPosition:=1)

        ucrInputBreakPoints.SetName("-Inf, -10, 10, Inf")
        ucrInputLabels.SetName("Decrease, Same, Increase")
        ucrInputDiffName.SetName("diff")
        ucrInputCategoryColumn.SetName("diff_code")

        ucrBase.clsRsyntax.SetBaseROperator(clsPipeOperator)

        bDefaultsSet = True
        AutoAddDefaults()
        ucrReceiverMeasurement.SetMeAsReceiver()
    End Sub

    Private Sub SetRCodeforControls(bResetControls As Boolean)
        bRCodeSet = False
        ucrReceiverMeasurement.AddAdditionalCodeParameterPair(clsDCast, New RParameter("col_names", iNewPosition:=1), iAdditionalPairNo:=1)

        ucrSelectorDifference.SetRCode(clsPipeOperator, bResetControls)
        ucrReceiverMeasurement.SetRCode(clsDCast, bResetControls)
        ucrReceiverOption.SetRCode(clsDCastFormula, bReset)
        ucrReceiverID.SetRCode(clsDCastLeftFormula, bReset)
        'Needs to be done after linked receiver is set
        ucrInputFactorOption1.SetRCode(clsDiffOperator, bResetControls)
        ucrInputFactorOption2.SetRCode(clsDiffOperator, bResetControls)

        ucrSaveDataFrame.SetRCode(clsPipeOperator, bResetControls)
        ucrChkCalculateDiffCategories.Checked = clsMutate.clsParameters.Count = 2
        ucrChkCalculateDiffCategories.UpdateLinkedControls()

        bRCodeSet = True
        UpdateContextVariables()
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverMeasurement.IsEmpty() AndAlso Not ucrReceiverOption.IsEmpty() AndAlso Not ucrInputFactorOption1.IsEmpty() AndAlso Not ucrInputFactorOption2.IsEmpty() AndAlso ucrSaveDataFrame.IsComplete() AndAlso Not ucrReceiverID.IsEmpty() AndAlso Not ucrInputDiffName.IsEmpty() AndAlso (Not ucrChkCalculateDiffCategories.Checked OrElse (bCutCheck AndAlso Not ucrInputCategoryColumn.IsEmpty())) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverContexts_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverContexts.ControlValueChanged
        UpdateContextVariables()
    End Sub

    Private Sub UpdateContextVariables()
        Dim i As Integer = 0

        If bRCodeSet Then
            clsDCastLeftContextFormula.ClearParameters()
            If Not ucrReceiverContexts.IsEmpty Then
                For Each strContextVar As String In ucrReceiverContexts.GetVariableNamesAsList()
                    clsDCastLeftContextFormula.AddParameter(i, strContextVar, iPosition:=i)
                    i = i + 1
                Next
            End If
            If clsDCastLeftContextFormula.clsParameters.Count = 0 Then
                clsDCastLeftFormula.RemoveParameterByName("1")
            Else
                clsDCastLeftFormula.AddParameter("1", clsROperatorParameter:=clsDCastLeftContextFormula, iPosition:=1)
            End If
        End If
    End Sub

    Private Sub ucrInputLabels_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputLabels.ControlValueChanged
        If Not ucrInputLabels.IsEmpty() Then
            clsCut.AddParameter("labels", clsRFunctionParameter:=ucrInputLabels.clsRList, iPosition:=2)
        Else
            clsCut.RemoveParameterByName("labels")
        End If
        CutCheck()
    End Sub

    Private Sub ucrInputBreakPoints_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputBreakPoints.ControlValueChanged
        If Not ucrInputBreakPoints.IsEmpty() Then
            clsCut.AddParameter("breaks", clsRFunctionParameter:=ucrInputBreakPoints.clsRList, iPosition:=1)
            lblLabels.Text = GetTranslation("Labels (") & ucrInputBreakPoints.clsRList.clsParameters.Count - 1 & "):"
        Else
            clsCut.RemoveParameterByName("breaks")
            lblLabels.Text = GetTranslation("Labels:")
        End If
        CutCheck()
    End Sub

    Private Sub CutCheck()
        bCutCheck = ucrInputLabels.IsEmpty() OrElse ucrInputLabels.clsRList.clsParameters.Count = ucrInputBreakPoints.clsRList.clsParameters.Count - 1
        If bCutCheck Then
            lblLabels.ForeColor = Color.Black
        Else
            lblLabels.ForeColor = Color.Red
        End If
    End Sub

    Private Sub SetMutateParameters()
        clsMutate.ClearParameters()
        If Not ucrInputDiffName.IsEmpty() Then
            clsMutate.AddParameter(ucrInputDiffName.GetText(), clsROperatorParameter:=clsDiffOperator, iPosition:=0)
            clsCut.AddParameter("x", ucrInputDiffName.GetText(), iPosition:=0)
        Else
            clsCut.RemoveParameterByName("x")
        End If
        If ucrChkCalculateDiffCategories.Checked AndAlso Not ucrInputCategoryColumn.IsEmpty() Then
            clsMutate.AddParameter(ucrInputCategoryColumn.GetText(), clsRFunctionParameter:=clsCut, iPosition:=1)
        End If
    End Sub

    Private Sub ucrInputNames_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputDiffName.ControlValueChanged, ucrInputCategoryColumn.ControlValueChanged, ucrChkCalculateDiffCategories.ControlValueChanged
        SetMutateParameters()
    End Sub

    Private Sub NewDefaultName()
        If (Not ucrSaveDataFrame.bUserTyped) AndAlso ucrSelectorDifference.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrSaveDataFrame.SetName(ucrSelectorDifference.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")
        End If
    End Sub

    Private Sub ucrSelectorDifference_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDifference.ControlValueChanged
        NewDefaultName()
        AutoAddDefaults()
    End Sub

    Private Sub AutoAddDefaults()
        If bDefaultsSet Then
            ucrReceiverMeasurement.AddItemsWithMetadataProperty(ucrSelectorDifference.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"measurement_1_label"})
            ucrReceiverOption.AddItemsWithMetadataProperty(ucrSelectorDifference.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"option_1_label"})
            ucrReceiverID.AddItemsWithMetadataProperty(ucrSelectorDifference.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"id_1_label"})
            ucrReceiverContexts.AddItemsWithMetadataProperty(ucrSelectorDifference.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "O_by_C_Type", {"context_1_label"})
        End If
    End Sub

    Private Sub ucrReceiverMeasurement_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMeasurement.ControlContentsChanged, ucrReceiverID.ControlContentsChanged, ucrReceiverID.ControlContentsChanged, ucrInputFactorOption1.ControlContentsChanged, ucrInputFactorOption2.ControlContentsChanged, ucrSaveDataFrame.ControlContentsChanged, ucrInputDiffName.ControlContentsChanged, ucrChkCalculateDiffCategories.ControlContentsChanged, ucrInputBreakPoints.ControlContentsChanged, ucrInputLabels.ControlContentsChanged, ucrInputCategoryColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class