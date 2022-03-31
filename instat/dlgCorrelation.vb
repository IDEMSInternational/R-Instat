﻿' R- Instat
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
Public Class dlgCorrelation
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsCorrelationTestFunction, clsRGGcorrGraphicsFunction,
        clsRGGscatMatrixFunction, clsCorrelationFunction, clsCurrentDataFrameFunction,
        clsGuidesFunction, clsGuideLegendFunction, clsDummyFunction, clsFashionFunction, clsShaveFunction, clsRearrangeFunction As New RFunction
    Private clsRGraphicsFuction, clsListFunction, clsWrapFunction As New RFunction
    Private clsDummyShave As New RFunction
    Private clsRGGscatMatricReverseOperator As New ROperator
    Private strColFunction As String
    Private bResetSubdialog As Boolean = False
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumns() As String = Nothing

    Private Sub dlgCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        SetDefaultColumn()
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctNaPrint As New Dictionary(Of String, String)
        Dim dctDiagonal As New Dictionary(Of String, String)
        Dim dctMethod As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 421

        ucrReceiverFirstColumn.SetParameter(New RParameter("x", 0))
        ucrReceiverFirstColumn.SetParameterIsRFunction()
        ucrReceiverFirstColumn.Selector = ucrSelectorCorrelation
        ucrReceiverFirstColumn.strSelectorHeading = "Numerics"
        ' cor.test only accepts numeric columns so need to be strict
        ucrReceiverFirstColumn.SetDataType("numeric", bStrict:=True)

        ucrReceiverSecondColumn.SetParameter(New RParameter("y", 1))
        ucrReceiverSecondColumn.SetParameterIsRFunction()
        ucrReceiverSecondColumn.strSelectorHeading = "Numerics"
        ucrReceiverSecondColumn.Selector = ucrSelectorCorrelation
        ' cor.test only accepts numeric columns so need to be strict
        ucrReceiverSecondColumn.SetDataType("numeric", bStrict:=True)

        ucrReceiverMultipleColumns.SetParameter(New RParameter("x", 2))
        ucrReceiverMultipleColumns.Selector = ucrSelectorCorrelation
        ucrReceiverMultipleColumns.strSelectorHeading = "Numerics"
        ucrReceiverMultipleColumns.SetParameterIsRFunction()
        ' cor accepts numeric and logical columns
        ucrReceiverMultipleColumns.SetIncludedDataTypes({"numeric", "logical"})

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrNudConfidenceInterval.SetParameter(New RParameter("conf.level", 3))
        ucrNudConfidenceInterval.SetMinMax(0, 1)
        ucrNudConfidenceInterval.DecimalPlaces = 2
        ucrNudConfidenceInterval.Increment = 0.05
        ucrNudConfidenceInterval.SetRDefault(0.95)

        ucrNudDecimalPlaces.SetParameter(New RParameter("decimals", 1))
        ucrNudDecimalPlaces.SetMinMax(0, 5)
        ucrNudDecimalPlaces.Increment = 1
        ucrNudDecimalPlaces.SetRDefault(2)

        ucrChkLeadingZeros.SetParameter(New RParameter("leading_zeros", 2))
        ucrChkLeadingZeros.SetText("Leading Zeros")
        ucrChkLeadingZeros.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrChkShave.SetText("Shave")
        ucrChkShave.SetParameter(New RParameter("checked", 0))
        ucrChkShave.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputDisplayNas.SetParameter(New RParameter("na_print", 3))
        dctNaPrint.Add("blank", Chr(34) & " " & Chr(34))
        dctNaPrint.Add("NA", "NA")
        dctNaPrint.Add("1", Chr(34) & 1 & Chr(34))
        ucrInputDisplayNas.SetItems(dctNaPrint)
        ucrInputDisplayNas.AddQuotesIfUnrecognised = False

        ucrInputDiagonal.SetParameter(New RParameter("diagonal", 6))
        dctDiagonal.Add("NA", "NA")
        dctDiagonal.Add("1", "1")
        ucrInputDiagonal.SetItems(dctDiagonal)
        ucrInputDiagonal.AddQuotesIfUnrecognised = False

        ucrPnlColumns.AddRadioButton(rdoTwoColumns)
        ucrPnlColumns.AddRadioButton(rdoMultipleColumns)
        ucrPnlColumns.AddFunctionNamesCondition(rdoTwoColumns, "cor.test")
        ucrPnlColumns.AddFunctionNamesCondition(rdoMultipleColumns, {"fashion", "shave", "rearrange", "correlate"})

        ucrPnlMethod.SetParameter(New RParameter("method", 4))
        ucrPnlMethod.AddRadioButton(rdoPearson, Chr(34) & "pearson" & Chr(34))
        ucrPnlMethod.AddRadioButton(rdoKendall, Chr(34) & "kendall" & Chr(34))
        ucrPnlMethod.AddRadioButton(rdoSpearman, Chr(34) & "spearman" & Chr(34))

        ucrPnlCompletePairwise.SetParameter(New RParameter("use", 5))
        ucrPnlCompletePairwise.AddRadioButton(rdoCompleteRowsOnly, Chr(34) & "complete.obs" & Chr(34))
        ucrPnlCompletePairwise.AddRadioButton(rdoPairwise, Chr(34) & "pairwise.complete.obs" & Chr(34))
        ucrPnlCompletePairwise.AddParameterValuesCondition(rdoCompleteRowsOnly, "use", Chr(34) & "complete.obs" & Chr(34))
        ucrPnlCompletePairwise.AddParameterValuesCondition(rdoPairwise, "use", Chr(34) & "pairwise.complete.obs" & Chr(34))

        ucrChkRearrange.SetText("Rearrange")
        ucrChkRearrange.SetParameter(New RParameter("check", 0))
        ucrChkRearrange.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkRearrange.AddToLinkedControls(ucrInputRearrange, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="PCA")
        ucrChkRearrange.AddToLinkedControls(ucrChkAbsolute, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkDisplayOptions.SetText("Display Options")
        ucrChkDisplayOptions.SetParameter(New RParameter("display", 0))
        ucrChkDisplayOptions.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDisplayOptions.AddToLinkedControls({ucrChkLeadingZeros, ucrChkRearrange, ucrChkShave, ucrNudDecimalPlaces}, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkDisplayOptions.AddToLinkedControls(ucrInputDisplayNas, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="blank")

        ucrInputRearrange.SetParameter(New RParameter("method", 1))
        dctMethod.Add("PCA", Chr(34) & "PCA" & Chr(34))
        dctMethod.Add("HC", Chr(34) & "HC" & Chr(34))
        dctMethod.Add("Identity", Chr(34) & "Identity" & Chr(34))
        dctMethod.Add("Random", Chr(34) & "Random" & Chr(34))
        dctMethod.Add("MDS", Chr(34) & "MDS" & Chr(34))
        dctMethod.Add("R2E", Chr(34) & "R2E" & Chr(34))
        dctMethod.Add("Spectral", Chr(34) & "Spectral" & Chr(34))
        ucrInputRearrange.SetItems(dctMethod)

        ucrChkAbsolute.SetText("Absolute")
        ucrChkAbsolute.SetParameter(New RParameter("absolute", 2))
        ucrChkAbsolute.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrPnlColumns.AddToLinkedControls({ucrReceiverFirstColumn, ucrNudConfidenceInterval, ucrSaveModel, ucrReceiverSecondColumn}, {rdoTwoColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverFirstColumn.SetLinkedDisplayControl(lblFirstColumn)
        ucrReceiverSecondColumn.SetLinkedDisplayControl(lblSecondColumn)
        ucrPnlColumns.AddToLinkedControls({ucrReceiverMultipleColumns}, {rdoMultipleColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverMultipleColumns.SetLinkedDisplayControl(lblSelectedVariables)
        ucrNudConfidenceInterval.SetLinkedDisplayControl(lblConfInterval)
        ucrInputDiagonal.SetLinkedDisplayControl(lblDisplayOnDiagonal)
        ucrInputDisplayNas.SetLinkedDisplayControl(lblDisplayNas)
        ucrInputRearrange.SetLinkedDisplayControl(lblMethod)
        ucrNudDecimalPlaces.SetLinkedDisplayControl(lblDecimalPlaces)
        ucrPnlColumns.AddToLinkedControls(ucrPnlCompletePairwise, {rdoMultipleColumns}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoCompleteRowsOnly)
        ucrPnlColumns.AddToLinkedControls(ucrInputDiagonal, {rdoMultipleColumns}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="NA")
        ucrPnlColumns.AddToLinkedControls(ucrNudDecimalPlaces, {rdoMultipleColumns}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls(ucrSaveDataFrame, {rdoMultipleColumns}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlColumns.AddToLinkedControls({ucrChkDisplayOptions}, {rdoMultipleColumns}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlCompletePairwise.SetLinkedDisplayControl(grpMissing)

        ucrSaveModel.SetPrefix("model")
        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetDataFrameSelector(ucrSelectorCorrelation.ucrAvailableDataFrames)
        ucrSaveModel.SetCheckBoxText("Result Name")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")

        ucrSaveDataFrame.SetPrefix("corr")
        ucrSaveDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveDataFrame.SetDataFrameSelector(ucrSelectorCorrelation.ucrAvailableDataFrames)
        ucrSaveDataFrame.SetCheckBoxText("Result Name")
        ucrSaveDataFrame.SetIsComboBox()
        ucrSaveDataFrame.SetAssignToIfUncheckedValue("last_correlation")
    End Sub

    Private Sub SetDefaults()
        clsCorrelationTestFunction = New RFunction
        clsCorrelationFunction = New RFunction
        clsRGGcorrGraphicsFunction = New RFunction
        clsRGraphicsFuction = New RFunction
        clsListFunction = New RFunction
        clsWrapFunction = New RFunction
        clsRGGscatMatrixFunction = New RFunction
        clsRGGscatMatricReverseOperator = New ROperator
        clsGuidesFunction = New RFunction
        clsGuideLegendFunction = New RFunction
        clsDummyFunction = New RFunction
        clsCurrentDataFrameFunction = New RFunction
        clsFashionFunction = New RFunction
        clsShaveFunction = New RFunction
        clsDummyShave = New RFunction
        clsRearrangeFunction = New RFunction
        bResetSubdialog = True

        ucrSelectorCorrelation.Reset()
        ucrSaveModel.Reset()
        ucrSaveDataFrame.Reset()
        ucrReceiverFirstColumn.SetMeAsReceiver()
        ucrReceiverMultipleColumns.SetMeAsReceiver()

        clsDummyFunction.AddParameter("checked", "none", iPosition:=0)
        'cls
        clsRGGscatMatricReverseOperator.SetOperation("+")
        clsRGGscatMatricReverseOperator.AddParameter("matrix", clsRFunctionParameter:=clsRGGscatMatrixFunction, iPosition:=0)
        clsRGGscatMatricReverseOperator.iCallType = 3
        clsRGGscatMatricReverseOperator.bExcludeAssignedFunctionOutput = False

        clsGuidesFunction.SetPackageName("ggplot2")
        clsGuidesFunction.SetRCommand("guides")
        clsGuidesFunction.AddParameter("colour", clsRFunctionParameter:=clsGuideLegendFunction, iPosition:=0)

        clsGuideLegendFunction.SetPackageName("ggplot2")
        clsGuideLegendFunction.SetRCommand("guide_legend")
        clsGuideLegendFunction.AddParameter("reverse", "TRUE", iPosition:=0)

        clsCurrentDataFrameFunction = ucrSelectorCorrelation.ucrAvailableDataFrames.clsCurrDataFrame
        clsCurrentDataFrameFunction.AddParameter("remove_attr", "TRUE")

        clsRGraphicsFuction.SetPackageName("GGally")
        clsRGraphicsFuction.SetRCommand("ggpairs")
        clsRGraphicsFuction.iCallType = 3
        clsRGraphicsFuction.bExcludeAssignedFunctionOutput = False
        clsRGraphicsFuction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)
        clsRGraphicsFuction.AddParameter("lower", clsRFunctionParameter:=clsListFunction, iPosition:=3)
        clsListFunction.SetRCommand("list")
        clsWrapFunction.SetPackageName("GGally")
        clsWrapFunction.SetRCommand("wrap")
        clsWrapFunction.AddParameter("points", Chr(39) & "points" & Chr(39), bIncludeArgumentName:=False, iPosition:=0)
        clsListFunction.AddParameter("continuous", clsRFunctionParameter:=clsWrapFunction)

        clsRGGscatMatrixFunction.SetPackageName("GGally")
        clsRGGscatMatrixFunction.SetRCommand("ggscatmat")
        clsRGGscatMatrixFunction.bExcludeAssignedFunctionOutput = False
        clsRGGscatMatrixFunction.AddParameter("data", clsRFunctionParameter:=clsCurrentDataFrameFunction, iPosition:=0)

        clsCorrelationTestFunction.SetRCommand("cor.test")
        clsCorrelationTestFunction.AddParameter("alternative", Chr(34) & "two.sided" & Chr(34))
        clsCorrelationTestFunction.AddParameter("exact", "NULL")
        clsCorrelationTestFunction.AddParameter("conf.level", "0.95")
        clsCorrelationTestFunction.AddParameter("method", Chr(34) & "pearson" & Chr(34))

        clsCorrelationFunction.SetPackageName("corrr")
        clsCorrelationFunction.SetRCommand("correlate ")
        clsCorrelationFunction.AddParameter("use", Chr(34) & "complete.obs" & Chr(34))

        clsRearrangeFunction.SetPackageName("corrr")
        clsRearrangeFunction.SetRCommand("rearrange")
        clsRearrangeFunction.AddParameter("x", clsRFunctionParameter:=clsCorrelationFunction, iPosition:=0)
        clsRearrangeFunction.AddParameter("method", "PCA", iPosition:=1)
        clsRearrangeFunction.AddParameter("absolute", "FALSE", iPosition:=3)

        clsFashionFunction.SetPackageName("corrr")
        clsFashionFunction.SetRCommand("fashion")
        clsFashionFunction.AddParameter("x", clsRFunctionParameter:=clsCorrelationFunction, iPosition:=0)
        clsFashionFunction.AddParameter("decimals", "2", iPosition:=1)
        clsFashionFunction.AddParameter("leading_zeros", "FALSE", iPosition:=2)
        clsFashionFunction.AddParameter("na_print", Chr(34) & " " & Chr(34), iPosition:=3)

        clsShaveFunction.SetPackageName("corrr")
        clsShaveFunction.SetRCommand("shave")
        clsShaveFunction.AddParameter("x", clsRFunctionParameter:=clsCorrelationFunction, iPosition:=0)

        clsRGGcorrGraphicsFunction.SetPackageName("GGally")
        clsRGGcorrGraphicsFunction.SetRCommand("ggcorr")
        clsRGGcorrGraphicsFunction.iCallType = 3
        clsRGGcorrGraphicsFunction.bExcludeAssignedFunctionOutput = False
        clsRGGcorrGraphicsFunction.AddParameter("cor_matrix", clsRFunctionParameter:=clsCorrelationFunction)
        clsRGGcorrGraphicsFunction.AddParameter("data", "NULL")

        clsCorrelationTestFunction.SetAssignTo("last_model", strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model")
        clsFashionFunction.SetAssignTo("last_fashion", strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strDataFrameNames:="last_fashion")
        clsCorrelationFunction.SetAssignTo("last_correlation", strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strDataFrameNames:="last_correlation")
        clsRGGcorrGraphicsFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        clsRGraphicsFuction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsCorrelationTestFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrPnlMethod.AddAdditionalCodeParameterPair(clsCorrelationFunction, New RParameter("method", 4), iAdditionalPairNo:=1)
        ucrPnlMethod.AddAdditionalCodeParameterPair(clsWrapFunction, New RParameter("method", 2), iAdditionalPairNo:=2)
        ucrPnlMethod.AddAdditionalCodeParameterPair(clsRGGcorrGraphicsFunction, New RParameter("method", 2), iAdditionalPairNo:=3)
        ucrPnlMethod.AddAdditionalCodeParameterPair(clsRGGscatMatrixFunction, New RParameter("corMethod", 4), iAdditionalPairNo:=4)
        ucrReceiverMultipleColumns.SetRCode(clsCorrelationFunction, bReset)
        ucrInputDiagonal.SetRCode(clsCorrelationFunction, bReset)
        ucrNudConfidenceInterval.SetRCode(clsCorrelationTestFunction, bReset)
        ucrReceiverFirstColumn.SetRCode(clsCorrelationTestFunction, bReset)
        ucrReceiverSecondColumn.SetRCode(clsCorrelationTestFunction, bReset)
        ucrNudDecimalPlaces.SetRCode(clsFashionFunction, bReset)
        ucrChkLeadingZeros.SetRCode(clsFashionFunction, bReset)
        ucrInputDisplayNas.SetRCode(clsFashionFunction, bReset)
        ucrInputRearrange.SetRCode(clsRearrangeFunction, bReset)
        ucrChkRearrange.SetRCode(clsDummyShave, bReset)
        ucrChkAbsolute.SetRCode(clsRearrangeFunction, bReset)
        ucrChkShave.SetRCode(clsDummyShave, bReset)
        ucrChkDisplayOptions.SetRCode(clsDummyShave, bReset)
        If bReset Then
            ucrPnlColumns.SetRCode(clsFashionFunction, bReset)
        End If
        ucrPnlMethod.SetRCode(clsCorrelationTestFunction, bReset)
        ucrPnlCompletePairwise.SetRCode(clsCorrelationFunction, bReset)
        ucrSaveModel.SetRCode(clsCorrelationTestFunction, bReset)
        ucrSaveDataFrame.SetRCode(clsFashionFunction, bReset)
        ucrSaveDataFrame.AddAdditionalRCode(clsCorrelationFunction, bReset)
    End Sub

    Private Sub SetDefaultColumn()
        If strDefaultDataFrame <> "" Then
            ucrSelectorCorrelation.SetDataframe(strDefaultDataFrame)
            rdoMultipleColumns.Checked = True
        End If
        If strDefaultColumns IsNot Nothing AndAlso strDefaultColumns.Count > 0 Then
            For Each strVar As String In strDefaultColumns
                ucrReceiverMultipleColumns.Add(strVar, strDefaultDataFrame)
            Next
        End If
        strDefaultDataFrame = ""
        strDefaultColumns = Nothing
    End Sub

    Public Sub TestOKEnabled()
        If rdoTwoColumns.Checked Then
            If (Not ucrReceiverFirstColumn.IsEmpty()) AndAlso (Not ucrReceiverSecondColumn.IsEmpty()) AndAlso (rdoPearson.Checked = True Or rdoKendall.Checked = True Or rdoSpearman.Checked = True) Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        ElseIf rdoMultipleColumns.Checked AndAlso ucrReceiverMultipleColumns.lstSelectedVariables.Items.Count > 1 AndAlso (rdoCompleteRowsOnly.Checked OrElse rdoPairwise.Checked) AndAlso (rdoPearson.Checked OrElse rdoKendall.Checked OrElse rdoSpearman.Checked) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdPlots_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgCorrPlot.SetRCode(clsNewRSyntax:=ucrBase.clsRsyntax, clsNewcorrelationFunction:=clsCorrelationFunction, clsNewcorrelationTestFunction:=clsCorrelationTestFunction,
                             clsNewRGGcorrGraphicsFunction:=clsRGGcorrGraphicsFunction, clsNewRGraphicsFuction:=clsRGraphicsFuction, clsNewRGGscatmatrixFunction:=clsRGGscatMatrixFunction,
                             strNewColFunction:=strColFunction, clsNewRGGscatMatrixReverseOperator:=clsRGGscatMatricReverseOperator, ucrNewBaseSelector:=ucrSelectorCorrelation,
                             clsNewGuideFunction:=clsGuidesFunction, clsNewDummyFunction:=clsDummyFunction, bReset:=bResetSubdialog, bTwoColumns:=rdoTwoColumns.Checked)
        sdgCorrPlot.ShowDialog()
        bResetSubdialog = False
    End Sub

    ' This is here because otherwise the panel cannot be set up correctly if you reopen the dialog when on the 2-variable rdo button
    Private Sub ucrPnlCompletePairwise_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlCompletePairwise.ControlValueChanged
        If rdoPairwise.Checked Then
            clsCorrelationFunction.AddParameter("use", Chr(34) & "pairwise.complete.obs" & Chr(34))
        ElseIf rdoCompleteRowsOnly.Checked Then
            clsCorrelationFunction.AddParameter("use", Chr(34) & "complete.obs" & Chr(34))
        End If
    End Sub

    Private Sub ucrPnlColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumns.ControlValueChanged, ucrChkDisplayOptions.ControlValueChanged, ucrChkRearrange.ControlValueChanged, ucrChkShave.ControlValueChanged
        If rdoTwoColumns.Checked Then
            ucrReceiverFirstColumn.SetMeAsReceiver()
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRGGcorrGraphicsFunction)
            ucrBase.clsRsyntax.SetBaseRFunction(clsCorrelationTestFunction)
            grpDisplayOptions.Hide()
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoMultipleColumns.Checked Then
            If ucrChkDisplayOptions.Checked Then
                If ucrChkShave.Checked Then
                    clsFashionFunction.AddParameter("x", clsRFunctionParameter:=clsShaveFunction, iPosition:=0)
                ElseIf ucrChkRearrange.Checked Then
                    clsRearrangeFunction.AddParameter("x", clsRFunctionParameter:=clsCorrelationFunction, iPosition:=0)
                    clsFashionFunction.AddParameter("x", clsRFunctionParameter:=clsRearrangeFunction, iPosition:=0)
                Else
                    clsFashionFunction.AddParameter("x", clsRFunctionParameter:=clsCorrelationFunction, iPosition:=0)
                End If
                If ucrChkShave.Checked AndAlso ucrChkRearrange.Checked Then
                    clsShaveFunction.AddParameter("x", clsRFunctionParameter:=clsRearrangeFunction, iPosition:=0)
                    clsFashionFunction.AddParameter("x", clsRFunctionParameter:=clsShaveFunction, iPosition:=0)
                Else
                    clsShaveFunction.AddParameter("x", clsRFunctionParameter:=clsCorrelationFunction, iPosition:=0)
                End If
                clsCorrelationFunction.RemoveAssignTo()
                ucrBase.clsRsyntax.SetBaseRFunction(clsFashionFunction)
                grpDisplayOptions.Show()
            Else
                clsCorrelationFunction.SetAssignTo("last_correlation", strTempDataframe:=ucrSelectorCorrelation.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strDataFrameNames:="last_correlation")
                ucrBase.clsRsyntax.SetBaseRFunction(clsCorrelationFunction)
                ucrReceiverMultipleColumns.SetMeAsReceiver()
                grpDisplayOptions.Hide()
            End If
            ucrBase.clsRsyntax.iCallType = 0
        End If
        ReceiverColumns()
    End Sub

    Private Sub ucrReceiverMultipleColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleColumns.ControlValueChanged, ucrReceiverFirstColumn.ControlValueChanged, ucrReceiverSecondColumn.ControlValueChanged
        ReceiverColumns()
    End Sub

    Private Sub ucrReceiverFirstColumn_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstColumn.ControlContentsChanged,
        ucrReceiverSecondColumn.ControlContentsChanged, ucrReceiverMultipleColumns.ControlContentsChanged, ucrPnlColumns.ControlContentsChanged, ucrSaveDataFrame.ControlContentsChanged,
        ucrPnlCompletePairwise.ControlContentsChanged, ucrPnlMethod.ControlContentsChanged, ucrChkShave.ControlContentsChanged, ucrInputDiagonal.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorCorrelation_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorCorrelation.ControlContentsChanged
        clsCurrentDataFrameFunction = ucrSelectorCorrelation.ucrAvailableDataFrames.clsCurrDataFrame
    End Sub

    Private Sub ReceiverColumns()
        Dim strTwoColumns As String
        If rdoTwoColumns.Checked Then
            strTwoColumns = "c(" & ucrReceiverFirstColumn.GetVariableNames() & ", " & ucrReceiverSecondColumn.GetVariableNames() & ")"
            clsRGraphicsFuction.AddParameter("columns", strTwoColumns, iPosition:=1)
            clsRGGscatMatrixFunction.AddParameter("columns", strTwoColumns, iPosition:=1)
        ElseIf rdoMultipleColumns.Checked Then
            clsRGraphicsFuction.AddParameter("columns", ucrReceiverMultipleColumns.GetVariableNames(), iPosition:=1)
            clsRGGscatMatrixFunction.AddParameter("columns", ucrReceiverMultipleColumns.GetVariableNames(), iPosition:=1)
        End If
    End Sub
End Class