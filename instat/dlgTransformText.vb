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

Imports System.ComponentModel.Design
Imports System.Data.Common
Imports instat.Translations

Public Class dlgTransformText
    Public enumTransformMode As String = TransformMode.Prepare

    Public Enum TransformMode
        Prepare
        Describe
        Climatic
        Tricot
    End Enum

    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsConvertFunction, clsLengthFunction, clsPadFunction, clsWordsFunction, clsSubstringFunction As New RFunction
    Private clsSquishTrimFunction, clsTruncateFunction, clsWrapFunction As New RFunction
    Private clsDummyFunction, clsGetDataFrameFunction, clsPasteFunction, clsEverythingFunction, clsAcrossFunction, clsPaste2Function,
     clsEndsWithFunction, clsUnpackFunction, clsMutate2Function, clsAddColumnsFunction, clsNamesFunction, clsAnyFunction, clsSelectFunction As New RFunction
    Private clsTildaOperator, clsDataFrameOperator, clsPipe2Operator, clsUnpackOperator, clsSelectOperator As New ROperator
    Private clsLengthSelectFunction, clsPadSelectFunction, clsTruncateSelectFunction, clsSquishTrimSelectFunction, clsWrapSelectFunction,
        clsWordsSelectFunction, clsSubstringSelectFunction, clsConvertSelectFunction As New RFunction

    Private bRCodeSet As Boolean = False
    Private iFullHeight As Integer
    Private igrpParameterFullHeight As Integer
    Private iBaseMaxY As Integer
    Private iNewColMaxY As Integer
    Private iNewOverWriteMaxY As Integer

    Private Sub dlgTransformText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            iFullHeight = Me.Height
            igrpParameterFullHeight = grpParameters.Height
            iBaseMaxY = ucrBase.Location.Y
            iNewColMaxY = ucrNewColName.Location.Y
            iNewOverWriteMaxY = ucrChkOverWriteColumns.Location.Y
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetHelpOptions()
        bReset = False
        ReopenDialog()
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        Dim dctInputPad As New Dictionary(Of String, String)
        Dim dctInputSeparator As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 343

        'ucrReceiver
        ucrReceiverTransformText.SetParameter(New RParameter("string", 0))
        ucrReceiverTransformText.SetParameterIsRFunction()
        ucrReceiverTransformText.Selector = ucrSelectorForTransformText
        ucrReceiverTransformText.bUseFilteredData = False
        ucrReceiverTransformText.SetMeAsReceiver()
        'ucrReceiverTransformText.strSelectorHeading = "Variables"

        'ucrRdoOptions
        ucrPnlOperation.AddRadioButton(rdoCase)
        ucrPnlOperation.AddRadioButton(rdoLength)
        ucrPnlOperation.AddRadioButton(rdoPad)
        ucrPnlOperation.AddRadioButton(rdoTrim)
        ucrPnlOperation.AddRadioButton(rdoWords)
        ucrPnlOperation.AddRadioButton(rdoSubstring)
        ucrPnlOperation.AddRadioButton(rdoTruncate)
        ucrPnlOperation.AddRadioButton(rdoWrap)

        ucrPnlOperation.AddParameterValuesCondition(rdoCase, "transform", "case")
        ucrPnlOperation.AddParameterValuesCondition(rdoLength, "transform", "length")
        ucrPnlOperation.AddParameterValuesCondition(rdoPad, "transform", "pad")
        ucrPnlOperation.AddParameterValuesCondition(rdoTrim, "transform", "trim")
        ucrPnlOperation.AddParameterValuesCondition(rdoWords, "transform", "words")
        ucrPnlOperation.AddParameterValuesCondition(rdoSubstring, "transform", "sub_string")
        ucrPnlOperation.AddParameterValuesCondition(rdoTruncate, "transform", "trunc")
        ucrPnlOperation.AddParameterValuesCondition(rdoWrap, "transform", "wrap")

        'rdoCase
        ucrPnlOperation.AddToLinkedControls(ucrInputTo, {rdoCase}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'ucrInputTo
        ucrInputTo.SetItems({"Lower", "Upper", "Title", "Sentence"})
        ucrInputTo.AddFunctionNamesCondition("Lower", "str_to_lower")
        ucrInputTo.AddFunctionNamesCondition("Upper", "str_to_upper")
        ucrInputTo.AddFunctionNamesCondition("Title", "str_to_title")
        ucrInputTo.AddFunctionNamesCondition("Sentence", "str_to_sentence")
        ucrInputTo.SetLinkedDisplayControl(lblTo)
        ucrInputTo.SetDropDownStyleAsNonEditable()

        'rdoPad
        ucrPnlOperation.AddToLinkedControls(ucrInputPad, {rdoPad}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudWidth, {rdoPad}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudWidthTrunc, {rdoTruncate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrNudWidthWrap, {rdoWrap}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOperation.AddToLinkedControls(ucrPnlSide, {rdoPad}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSide.SetParameter(New RParameter("side", 2))
        ucrPnlSide.AddRadioButton(rdoLeftSide, Chr(34) & "left" & Chr(34))
        ucrPnlSide.AddRadioButton(rdoRightSide, Chr(34) & "right" & Chr(34))
        ucrPnlSide.AddRadioButton(rdoBothSide, Chr(34) & "both" & Chr(34))
        ucrPnlSide.SetLinkedDisplayControl(lblSide)

        ucrPnlOperation.AddToLinkedControls(ucrPnlSideTrunc, {rdoTruncate}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlSideTrunc.SetParameter(New RParameter("side", 2))
        ucrPnlSideTrunc.AddRadioButton(rdoLeft, Chr(34) & "left" & Chr(34))
        ucrPnlSideTrunc.AddRadioButton(rdoRight, Chr(34) & "right" & Chr(34))
        ucrPnlSideTrunc.AddRadioButton(rdoMiddle, Chr(34) & "center" & Chr(34))
        ucrPnlSideTrunc.SetLinkedDisplayControl(lblSideTrunc)


        'ucrInputPad
        ucrInputPad.SetParameter(New RParameter("pad", 3))
        dctInputPad.Add("Space ( )", Chr(34) & " " & Chr(34))
        dctInputPad.Add("Hash #", Chr(34) & "#" & Chr(34))
        dctInputPad.Add("Hyphen -", Chr(34) & "-" & Chr(34))
        dctInputPad.Add("Period .", Chr(34) & "." & Chr(34))
        dctInputPad.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputPad.SetItems(dctInputPad)
        ucrInputPad.SetLinkedDisplayControl(lblPad)
        ucrInputPad.SetRDefault(Chr(34) & " " & Chr(34))
        ucrInputPad.bAllowNonConditionValues = True

        'ucrNudWidth
        ucrNudWidth.SetParameter(New RParameter("width", 1))
        ucrNudWidth.SetLinkedDisplayControl(lblWidth)

        'ucrNudWidthTrunc
        ucrNudWidthTrunc.SetParameter(New RParameter("width", 1))
        ucrNudWidthTrunc.SetLinkedDisplayControl(lblWidthTrunc)

        'ucrNudWidthWrap
        ucrNudWidthWrap.SetParameter(New RParameter("width", 1))
        ucrNudWidthWrap.SetLinkedDisplayControl(lblWidthWrap)

        'rdoTrim, rdoPad
        ucrPnlOperation.AddToLinkedControls(ucrPnlPad, {rdoTrim}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPad.AddRadioButton(rdoLeftPad)
        ucrPnlPad.AddRadioButton(rdoRightPad)
        ucrPnlPad.AddRadioButton(rdoBothPad)
        ucrPnlPad.AddRadioButton(rdoSquish)

        ucrPnlPad.AddParameterValuesCondition(rdoLeftPad, "side", Chr(34) & "left" & Chr(34))
        ucrPnlPad.AddParameterValuesCondition(rdoRightPad, "side", Chr(34) & "right" & Chr(34))
        ucrPnlPad.AddParameterValuesCondition(rdoBothPad, "side", Chr(34) & "both" & Chr(34))
        ucrPnlPad.AddFunctionNamesCondition(rdoSquish, "str_squish")

        'rdoWords
        ucrPnlOperation.AddToLinkedControls(ucrChkFirstOr, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOperation.AddToLinkedControls(ucrChkLastOr, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFirstOr.AddToLinkedControls(ucrNudFirstWord, {False}, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkFirstOr.AddToLinkedControls(ucrReceiverFirstWord, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkLastOr.AddToLinkedControls(ucrNudLastWord, {False}, bNewLinkedDisabledIfParameterMissing:=True)
        ucrChkLastOr.AddToLinkedControls(ucrReceiverLastWord, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOperation.AddToLinkedControls(ucrInputSeparator, {rdoWords}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'parameter for this control has been passed manually
        ucrNudFirstWord.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudFirstWord.SetLinkedDisplayControl(lblFirstWord)

        ucrChkFirstOr.SetText("Or Column")

        'parameter for this control has been passed manually
        ucrReceiverFirstWord.Selector = ucrSelectorForTransformText
        ucrReceiverFirstWord.bUseFilteredData = False
        ucrReceiverFirstWord.SetIncludedDataTypes({"numeric"})

        'parameter for this control has been passed manually
        ucrNudLastWord.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudLastWord.SetLinkedDisplayControl(lblLastWord)

        ucrChkLastOr.SetText("Or Column")

        'parameter for this control has been passed manually
        ucrReceiverLastWord.Selector = ucrSelectorForTransformText
        ucrReceiverLastWord.bUseFilteredData = False
        ucrReceiverLastWord.SetIncludedDataTypes({"numeric"})

        ' ucrInputSeparator
        ucrInputSeparator.SetParameter(New RParameter("sep", 3))
        dctInputSeparator.Add("Space ( )", "stringr::fixed(" & Chr(34) & " " & Chr(34) & ")")
        dctInputSeparator.Add("Colon :", Chr(34) & ":" & Chr(34))
        dctInputSeparator.Add("Period .", "stringr::fixed(" & Chr(34) & "." & Chr(34) & ")")
        dctInputSeparator.Add("Underscore _", Chr(34) & "_" & Chr(34))
        ucrInputSeparator.SetItems(dctInputSeparator)
        ucrInputSeparator.SetLinkedDisplayControl(lblSeparator)
        ucrInputSeparator.SetRDefault("stringr::fixed(" & Chr(34) & " " & Chr(34) & ")")
        ucrInputSeparator.bAllowNonConditionValues = True

        'rdoSubstring
        ucrPnlOperation.AddToLinkedControls(ucrNudFrom, {rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrPnlOperation.AddToLinkedControls(ucrNudTo, {rdoSubstring}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2)

        'ucrNuds
        ucrNudFrom.SetParameter(New RParameter("start", 1))
        ucrNudFrom.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudFrom.SetLinkedDisplayControl(lblFrom)

        ucrNudTo.SetParameter(New RParameter("end", 2))
        ucrNudTo.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrNudTo.SetLinkedDisplayControl(lblToSubstring)

        'select options
        ucrPnlColumnSelectOptions.AddRadioButton(rdoSingle)
        ucrPnlColumnSelectOptions.AddRadioButton(rdoMultiple)

        ucrPnlColumnSelectOptions.AddParameterValuesCondition(rdoSingle, "col", "single")
        ucrPnlColumnSelectOptions.AddParameterValuesCondition(rdoMultiple, "col", "multiple")

        ucrChkOverWriteColumns.SetText("Overwrite Columns")
        ucrPnlColumnSelectOptions.SetLinkedDisplayControl(grpVar)
        ucrPnlColumnSelectOptions.AddToLinkedControls(ucrChkOverWriteColumns, {rdoMultiple}, bNewLinkedHideIfParameterMissing:=True)

        'ucrNewColName
        ucrNewColName.SetIsComboBox()
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetDataFrameSelector(ucrSelectorForTransformText.ucrAvailableDataFrames)
        ucrNewColName.SetLabelText("New Column:")
        ucrNewColName.setLinkedReceiver(ucrReceiverTransformText)
    End Sub

    Private Sub SetDefaults()
        clsConvertFunction = New RFunction
        clsLengthFunction = New RFunction
        clsPadFunction = New RFunction
        clsTruncateFunction = New RFunction
        clsWordsFunction = New RFunction
        clsWrapFunction = New RFunction
        clsSubstringFunction = New RFunction
        clsSquishTrimFunction = New RFunction
        clsDummyFunction = New RFunction
        clsGetDataFrameFunction = New RFunction
        clsTildaOperator = New ROperator
        clsDataFrameOperator = New ROperator
        clsPasteFunction = New RFunction
        clsEverythingFunction = New RFunction
        clsAcrossFunction = New RFunction
        clsPaste2Function = New RFunction
        clsPipe2Operator = New ROperator
        clsEndsWithFunction = New RFunction
        clsUnpackFunction = New RFunction
        clsUnpackOperator = New ROperator
        clsMutate2Function = New RFunction
        clsAddColumnsFunction = New RFunction
        clsNamesFunction = New RFunction
        clsAnyFunction = New RFunction
        clsSelectFunction = New RFunction
        clsSelectOperator = New ROperator
        clsLengthSelectFunction = New RFunction
        clsPadSelectFunction = New RFunction
        clsTruncateSelectFunction = New RFunction
        clsSquishTrimSelectFunction = New RFunction
        clsWrapSelectFunction = New RFunction
        clsWordsSelectFunction = New RFunction
        clsSubstringSelectFunction = New RFunction
        clsConvertSelectFunction = New RFunction

        ucrNewColName.Reset()
        ucrSelectorForTransformText.Reset()
        NewDefaultName()

        'initialise word controls
        ucrNudFirstWord.SetText(1)
        ucrNudLastWord.SetText(2)
        ucrChkFirstOr.Checked = False
        ucrChkLastOr.Checked = False

        clsConvertFunction.SetPackageName("stringr")
        clsConvertFunction.SetRCommand("str_to_lower")
        clsConvertFunction.SetAssignTo(ucrNewColName.GetText(), strTempDataframe:=ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText)

        clsConvertSelectFunction.SetPackageName("~stringr")
        clsConvertSelectFunction.SetRCommand("str_to_lower")
        clsConvertSelectFunction.AddParameter("string", ".x", iPosition:=0)

        clsLengthFunction.SetPackageName("stringr")
        clsLengthFunction.SetRCommand("str_length")

        clsLengthSelectFunction.SetPackageName("~stringr")
        clsLengthSelectFunction.SetRCommand("str_length")
        clsLengthSelectFunction.AddParameter("string", ".x", iPosition:=0)

        clsPadFunction.SetPackageName("stringr")
        clsPadFunction.SetRCommand("str_pad")
        clsPadFunction.AddParameter("width", "20", iPosition:=1)
        clsPadFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=2)
        clsPadFunction.AddParameter("pad", Chr(34) & " " & Chr(34), iPosition:=3)

        clsPadSelectFunction.SetPackageName("~stringr")
        clsPadSelectFunction.SetRCommand("str_pad")
        clsPadSelectFunction.AddParameter("string", ".x", iPosition:=0)
        clsPadSelectFunction.AddParameter("width", "20", iPosition:=1)
        clsPadSelectFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=2)
        clsPadSelectFunction.AddParameter("pad", Chr(34) & " " & Chr(34), iPosition:=3)

        clsTruncateFunction.SetPackageName("stringr")
        clsTruncateFunction.SetRCommand("str_trunc")
        clsTruncateFunction.AddParameter("width", "20", iPosition:=1)
        clsTruncateFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=2)

        clsTruncateSelectFunction.SetPackageName("~stringr")
        clsTruncateSelectFunction.SetRCommand("str_trunc")
        clsTruncateSelectFunction.AddParameter("string", ".x", iPosition:=0)
        clsTruncateSelectFunction.AddParameter("width", "20", iPosition:=1)
        clsTruncateSelectFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=2)

        clsWrapFunction.SetPackageName("stringr")
        clsWrapFunction.SetRCommand("str_wrap")
        clsWrapFunction.AddParameter("width", "40", iPosition:=1)

        clsWrapSelectFunction.SetPackageName("~stringr")
        clsWrapSelectFunction.SetRCommand("str_wrap")
        clsWrapSelectFunction.AddParameter("string", ".x", iPosition:=0)
        clsWrapSelectFunction.AddParameter("width", "40", iPosition:=1)

        clsSquishTrimFunction.SetPackageName("stringr")
        clsSquishTrimFunction.SetRCommand("str_trim")
        clsSquishTrimFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=1)

        clsSquishTrimSelectFunction.SetPackageName("~stringr")
        clsSquishTrimSelectFunction.SetRCommand("str_trim")
        clsSquishTrimSelectFunction.AddParameter("string", ".x", iPosition:=0)
        clsSquishTrimSelectFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=1)

        clsWordsFunction.SetPackageName("stringr")
        clsWordsFunction.SetRCommand("word")

        clsWordsSelectFunction.SetPackageName("~stringr")
        clsWordsSelectFunction.SetRCommand("word")
        clsWordsSelectFunction.AddParameter("string", ".x", iPosition:=0)

        clsSubstringFunction.SetPackageName("stringr")
        clsSubstringFunction.SetRCommand("str_sub")
        clsSubstringFunction.AddParameter("start", 1, iPosition:=1)
        clsSubstringFunction.AddParameter("end", 2, iPosition:=2)

        clsSubstringSelectFunction.SetPackageName("~stringr")
        clsSubstringSelectFunction.SetRCommand("str_sub")
        clsSubstringSelectFunction.AddParameter("string", ".x", iPosition:=0)
        clsSubstringSelectFunction.AddParameter("start", 1, iPosition:=1)
        clsSubstringSelectFunction.AddParameter("end", 2, iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsSubstringFunction)

        clsDummyFunction.AddParameter("col", "single", iPosition:=0)
        clsDummyFunction.AddParameter("transform", "sub_string", iPosition:=1)

        clsGetDataFrameFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")

        clsTildaOperator.SetOperation(" ", bBracketsTemp:=False)

        clsDataFrameOperator.SetOperation("%>%")
        clsDataFrameOperator.AddParameter("right", "as.data.frame()", iPosition:=1)

        clsPasteFunction.SetRCommand("paste0")
        clsPasteFunction.AddParameter("col", """{.col}_""", iPosition:=0, bIncludeArgumentName:=False)
        clsPasteFunction.AddParameter("", clsROperatorParameter:=clsTildaOperator, bIncludeArgumentName:=False)

        clsEverythingFunction.SetRCommand("everything")
        clsEverythingFunction.AddParameter("dot", ".", bIncludeArgumentName:=False, iPosition:=0)

        clsAcrossFunction.SetPackageName("dplyr")
        clsAcrossFunction.SetRCommand("across")
        clsAcrossFunction.AddParameter("every", clsRFunctionParameter:=clsEverythingFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsMutate2Function.SetPackageName("dplyr")
        clsMutate2Function.SetRCommand("mutate")
        clsMutate2Function.AddParameter(".names", clsRFunctionParameter:=clsAcrossFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsPipe2Operator.SetOperation("%>%")
        clsPipe2Operator.AddParameter("left", clsRFunctionParameter:=clsGetDataFrameFunction, iPosition:=0)
        clsPipe2Operator.AddParameter("right", clsROperatorParameter:=clsUnpackOperator, iPosition:=1)
        clsPipe2Operator.SetAssignTo("col")

        clsPaste2Function.SetRCommand("paste0")
        clsPaste2Function.AddParameter("names", """_""", iPosition:=0, bIncludeArgumentName:=False)
        clsPaste2Function.AddParameter("split", "new_name", iPosition:=1, bIncludeArgumentName:=False)

        clsEndsWithFunction.SetRCommand("ends_with")
        clsEndsWithFunction.AddParameter("paste", clsRFunctionParameter:=clsPaste2Function, iPosition:=0, bIncludeArgumentName:=False)

        clsUnpackFunction.SetPackageName("tidyr")
        clsUnpackFunction.SetRCommand("unpack")
        clsUnpackFunction.AddParameter("cols", clsRFunctionParameter:=clsEndsWithFunction, iPosition:=0)
        clsUnpackFunction.AddParameter("names_sep", """.""", iPosition:=1)

        clsUnpackOperator.SetOperation("%>%")
        clsUnpackOperator.AddParameter("left", clsRFunctionParameter:=clsMutate2Function, iPosition:=0)
        clsUnpackOperator.AddParameter("right", clsROperatorParameter:=clsSelectOperator, iPosition:=1)

        clsNamesFunction.SetRCommand("names")

        clsAnyFunction.SetRCommand("-any_of")
        clsAnyFunction.AddParameter("any", clsRFunctionParameter:=clsNamesFunction, bIncludeArgumentName:=False)

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("select", clsRFunctionParameter:=clsAnyFunction, bIncludeArgumentName:=False)

        clsSelectOperator.SetOperation("%>%")
        clsSelectOperator.AddParameter("left", clsRFunctionParameter:=clsUnpackFunction, iPosition:=0)
        clsSelectOperator.AddParameter("right", clsRFunctionParameter:=clsSelectFunction, iPosition:=1)

        clsAddColumnsFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsAddColumnsFunction.AddParameter("col_data", clsROperatorParameter:=clsPipe2Operator, iPosition:=1)
        clsAddColumnsFunction.AddParameter("before", "FALSE", iPosition:=2)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bRCodeSet = False

        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsLengthFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=1)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsPadFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=2)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsTruncateFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=3)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsSquishTrimFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=4)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsWrapFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=5)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsWordsFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=6)
        ucrReceiverTransformText.AddAdditionalCodeParameterPair(clsSubstringFunction, clsNewRParameter:=New RParameter("string", 0), iAdditionalPairNo:=7)

        ucrNewColName.AddAdditionalRCode(clsLengthFunction, iAdditionalPairNo:=1)
        ucrNewColName.AddAdditionalRCode(clsPadFunction, iAdditionalPairNo:=2)
        ucrNewColName.AddAdditionalRCode(clsTruncateFunction, iAdditionalPairNo:=3)
        ucrNewColName.AddAdditionalRCode(clsSquishTrimFunction, iAdditionalPairNo:=4)
        ucrNewColName.AddAdditionalRCode(clsWrapFunction, iAdditionalPairNo:=5)
        ucrNewColName.AddAdditionalRCode(clsWordsFunction, iAdditionalPairNo:=6)
        ucrNewColName.AddAdditionalRCode(clsSubstringFunction, iAdditionalPairNo:=7)

        ucrInputTo.AddAdditionalCodeParameterPair(clsConvertSelectFunction, ucrInputTo.GetParameter(), iAdditionalPairNo:=1)
        ucrInputPad.AddAdditionalCodeParameterPair(clsPadSelectFunction, ucrInputPad.GetParameter(), iAdditionalPairNo:=1)
        ucrNudWidth.AddAdditionalCodeParameterPair(clsPadSelectFunction, ucrNudWidth.GetParameter(), iAdditionalPairNo:=1)
        ucrNudWidthTrunc.AddAdditionalCodeParameterPair(clsTruncateSelectFunction, ucrNudWidthTrunc.GetParameter(), iAdditionalPairNo:=1)
        ucrNudWidthWrap.AddAdditionalCodeParameterPair(clsWrapSelectFunction, ucrNudWidthWrap.GetParameter(), iAdditionalPairNo:=1)
        ucrInputSeparator.AddAdditionalCodeParameterPair(clsWordsSelectFunction, ucrInputSeparator.GetParameter(), iAdditionalPairNo:=1)
        ucrNudFrom.AddAdditionalCodeParameterPair(clsSubstringSelectFunction, ucrNudFrom.GetParameter(), iAdditionalPairNo:=1)
        ucrNudTo.AddAdditionalCodeParameterPair(clsSubstringSelectFunction, ucrNudTo.GetParameter(), iAdditionalPairNo:=1)
        ucrPnlPad.AddAdditionalCodeParameterPair(clsSquishTrimSelectFunction, ucrPnlPad.GetParameter(), iAdditionalPairNo:=1)
        ucrPnlSide.AddAdditionalCodeParameterPair(clsPadSelectFunction, ucrPnlSide.GetParameter(), iAdditionalPairNo:=1)
        ucrPnlSideTrunc.AddAdditionalCodeParameterPair(clsTruncateSelectFunction, ucrPnlSideTrunc.GetParameter(), iAdditionalPairNo:=1)

        ucrNewColName.SetRCode(clsConvertFunction, bReset)
        ucrPnlOperation.SetRCode(clsDummyFunction, bReset)
        ucrInputTo.SetRCode(clsConvertFunction, bReset)
        ucrInputPad.SetRCode(clsPadFunction, bReset)
        ucrNudWidth.SetRCode(clsPadFunction, bReset)
        ucrNudWidthTrunc.SetRCode(clsTruncateFunction, bReset)
        ucrNudWidthWrap.SetRCode(clsWrapFunction, bReset)
        ucrInputSeparator.SetRCode(clsWordsFunction, bReset)
        ucrNudFrom.SetRCode(clsSubstringFunction, bReset)
        ucrNudTo.SetRCode(clsSubstringFunction, bReset)
        ucrPnlPad.SetRCode(clsSquishTrimFunction, bReset)
        ucrPnlSide.SetRCode(clsPadFunction, bReset)
        ucrPnlSideTrunc.SetRCode(clsTruncateFunction, bReset)
        ucrPnlColumnSelectOptions.SetRCode(clsDummyFunction, bReset)

        If bReset Then
            ucrReceiverTransformText.SetRCode(clsConvertFunction, bReset)
        End If

        bRCodeSet = True
        DialogSize()
    End Sub

    Private Sub TestOkEnabled()
        If (Not ucrReceiverTransformText.IsEmpty()) AndAlso ucrNewColName.IsComplete() Then
            If rdoCase.Checked Then
                If Not ucrInputTo.IsEmpty() Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoLength.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoPad.Checked Then
                If Not ucrInputPad.IsEmpty() AndAlso ucrNudWidth.GetText <> "" Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoTruncate.Checked OrElse rdoTrim.Checked OrElse rdoWrap.Checked Then
                ucrBase.OKEnabled(True)
            ElseIf rdoWords.Checked Then
                If Not ucrInputSeparator.IsEmpty() AndAlso ((ucrNudFirstWord.GetText <> "" AndAlso Not ucrChkFirstOr.Checked) OrElse (ucrChkFirstOr.Checked AndAlso Not ucrReceiverFirstWord.IsEmpty)) AndAlso ((ucrNudLastWord.GetText <> "" AndAlso Not ucrChkLastOr.Checked) OrElse (ucrChkLastOr.Checked AndAlso Not ucrReceiverLastWord.IsEmpty)) Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            ElseIf rdoSubstring.Checked Then
                If ucrNudTo.GetText <> "" AndAlso ucrNudFrom.GetText <> "" Then
                    ucrBase.OKEnabled(True)
                Else
                    ucrBase.OKEnabled(False)
                End If
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub NewDefaultName()
        If rdoMultiple.Checked Then
            ucrNewColName.SetPrefix("transform")
            ucrNewColName.SetLabelText("Prefix for New Column:")
            ucrNewColName.btnColumnPosition.Visible = False
            If ucrChkOverWriteColumns.Checked Then
                ucrNewColName.Enabled = False
            Else
                ucrNewColName.Enabled = True
            End If
        Else
            ucrNewColName.btnColumnPosition.Visible = True
            ucrNewColName.SetLabelText("New Column:")
            If (Not ucrNewColName.bUserTyped) AndAlso Not ucrReceiverTransformText.IsEmpty Then
                ucrNewColName.SetName(ucrReceiverTransformText.GetVariableNames(bWithQuotes:=False) & "_transformed")
            End If
        End If
    End Sub

    Private Sub DialogSize()
        If rdoCase.Checked OrElse rdoTrim.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight / 3.04)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iNewColMaxY / 1.39)
            ucrChkOverWriteColumns.Location = New Point(ucrChkOverWriteColumns.Location.X, iNewOverWriteMaxY / 1.39)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.36)
            Me.Size = New Size(Me.Width, iFullHeight / 1.27)
        ElseIf rdoLength.Checked Then
            grpParameters.Visible = False
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iNewColMaxY / 1.65)
            ucrChkOverWriteColumns.Location = New Point(ucrChkOverWriteColumns.Location.X, iNewOverWriteMaxY / 1.7)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.6)
            Me.Size = New Size(Me.Width, iFullHeight / 1.5)
        ElseIf rdoSubstring.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight / 2.14)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iNewColMaxY / 1.28)
            ucrChkOverWriteColumns.Location = New Point(ucrChkOverWriteColumns.Location.X, iNewOverWriteMaxY / 1.28)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.26)
            Me.Size = New Size(Me.Width, iFullHeight / 1.2)
        ElseIf rdoPad.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight / 1.43)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iNewColMaxY / 1.14)
            ucrChkOverWriteColumns.Location = New Point(ucrChkOverWriteColumns.Location.X, iNewOverWriteMaxY / 1.14)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.13)
            Me.Size = New Size(Me.Width, iFullHeight / 1.1)
        ElseIf rdoTruncate.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight / 2.14)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iNewColMaxY / 1.28)
            ucrChkOverWriteColumns.Location = New Point(ucrChkOverWriteColumns.Location.X, iNewOverWriteMaxY / 1.28)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.26)
            Me.Size = New Size(Me.Width, iFullHeight / 1.2)
        ElseIf rdoWrap.Checked Then
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight / 3.04)
            ucrNewColName.Location = New Point(ucrNewColName.Location.X, iNewColMaxY / 1.39)
            ucrChkOverWriteColumns.Location = New Point(ucrChkOverWriteColumns.Location.X, iNewOverWriteMaxY / 1.39)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY / 1.36)
            Me.Size = New Size(Me.Width, iFullHeight / 1.27)
        Else
            grpParameters.Visible = True
            grpParameters.Size = New Size(grpParameters.Width, igrpParameterFullHeight)
            ucrNewColName.Location = New Point(ucrBase.Location.X, iNewColMaxY)
            ucrChkOverWriteColumns.Location = New Point(ucrBase.Location.X, iNewOverWriteMaxY)
            ucrBase.Location = New Point(ucrBase.Location.X, iBaseMaxY)
            Me.Size = New Size(Me.Width, iFullHeight)
        End If
    End Sub

    Private Sub ucrPnlOperation_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOperation.ControlValueChanged, ucrPnlPad.ControlValueChanged, ucrPnlSide.ControlValueChanged
        If rdoWords.Checked Then
            ucrNudFirstWord.Visible = True
            ucrNudLastWord.Visible = True
        Else
            ucrNudFirstWord.Visible = False
            ucrNudLastWord.Visible = False
            ucrReceiverTransformText.SetMeAsReceiver()
        End If
        ChangeBaseFunction()
        DialogSize()
    End Sub

    Private Sub ucrInputTo_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputTo.ControlValueChanged, ucrPnlPad.ControlValueChanged, ucrPnlSide.ControlValueChanged
        ChangeBaseFunction()
    End Sub

    Private Sub LastAndFirstWord_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFirstOr.ControlValueChanged, ucrChkLastOr.ControlValueChanged
        If ucrChangedControl Is ucrChkFirstOr AndAlso ucrChkFirstOr.Checked Then
            ucrReceiverFirstWord.SetMeAsReceiver()
        ElseIf ucrChangedControl Is ucrChkFirstOr AndAlso ucrChkLastOr.Checked Then
            ucrReceiverLastWord.SetMeAsReceiver()
        ElseIf ucrChangedControl Is ucrChkLastOr AndAlso ucrChkLastOr.Checked Then
            ucrReceiverLastWord.SetMeAsReceiver()
        ElseIf ucrChangedControl Is ucrChkLastOr AndAlso ucrChkFirstOr.Checked Then
            ucrReceiverFirstWord.SetMeAsReceiver()
        Else
            ucrReceiverTransformText.SetMeAsReceiver()
        End If

        AddRemoveStartAndEndParameters()
    End Sub

    Private Sub ReceiverAndNuds_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstWord.ControlValueChanged, ucrReceiverLastWord.ControlValueChanged,
            ucrNudFirstWord.ControlValueChanged, ucrNudLastWord.ControlValueChanged
        AddRemoveStartAndEndParameters()
    End Sub

    Private Sub ChangeBaseFunction()
        If rdoMultiple.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsAddColumnsFunction)
            If Not ucrChkOverWriteColumns.Checked Then
                clsUnpackOperator.AddParameter("right", clsROperatorParameter:=clsSelectOperator, iPosition:=1)
                clsAcrossFunction.AddParameter("tilda", clsROperatorParameter:=clsDataFrameOperator, bIncludeArgumentName:=False, iPosition:=1)
                clsAcrossFunction.AddParameter(".names", clsRFunctionParameter:=clsPasteFunction, iPosition:=2)
                clsAcrossFunction.RemoveParameterByName("left")
                clsAcrossFunction.RemoveParameterByName(".fns")
            Else
                clsAcrossFunction.RemoveParameterByName("tilda")
                clsAcrossFunction.RemoveParameterByName(".names")
                clsUnpackOperator.RemoveParameterByName("right")
            End If
        End If

        If rdoLength.Checked Then
            clsDummyFunction.AddParameter("transform", "length", iPosition:=1)
            If rdoSingle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsLengthFunction)
            Else
                If Not ucrChkOverWriteColumns.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsLengthSelectFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsAcrossFunction.AddParameter("left", clsRFunctionParameter:=clsLengthSelectFunction, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        ElseIf rdoPad.Checked Then
            clsDummyFunction.AddParameter("transform", "pad", iPosition:=1)
            If rdoSingle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsPadFunction)
            Else
                If Not ucrChkOverWriteColumns.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsPadSelectFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsAcrossFunction.AddParameter("left", clsRFunctionParameter:=clsPadSelectFunction, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        ElseIf rdoTruncate.Checked Then
            clsDummyFunction.AddParameter("transform", "trunc", iPosition:=1)
            If rdoSingle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsTruncateFunction)
            Else
                If Not ucrChkOverWriteColumns.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsTruncateSelectFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsAcrossFunction.AddParameter("left", clsRFunctionParameter:=clsTruncateSelectFunction, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        ElseIf rdoTrim.Checked Then
            clsDummyFunction.AddParameter("transform", "trim", iPosition:=1)
            If rdoSingle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsSquishTrimFunction)
            Else
                If Not ucrChkOverWriteColumns.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsSquishTrimSelectFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsAcrossFunction.AddParameter("left", clsRFunctionParameter:=clsSquishTrimSelectFunction, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        ElseIf rdoWrap.Checked Then
            clsDummyFunction.AddParameter("transform", "wrap", iPosition:=1)
            If rdoSingle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsWrapFunction)
            Else
                If Not ucrChkOverWriteColumns.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsWrapSelectFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsAcrossFunction.AddParameter("left", clsRFunctionParameter:=clsWrapSelectFunction, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        ElseIf rdoWords.Checked Then
            clsDummyFunction.AddParameter("transform", "words", iPosition:=1)
            If rdoSingle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsWordsFunction)
            Else
                If Not ucrChkOverWriteColumns.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsWordsSelectFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsAcrossFunction.AddParameter("left", clsRFunctionParameter:=clsWordsSelectFunction, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        ElseIf rdoSubstring.Checked Then
            clsDummyFunction.AddParameter("transform", "sub_string", iPosition:=1)
            If rdoSingle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsSubstringFunction)
            Else
                If Not ucrChkOverWriteColumns.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsSubstringSelectFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsAcrossFunction.AddParameter("left", clsRFunctionParameter:=clsSubstringSelectFunction, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        ElseIf rdoCase.Checked Then
            clsDummyFunction.AddParameter("transform", "case", iPosition:=1)
            If rdoSingle.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsConvertFunction)
                Select Case ucrInputTo.GetText
                    Case "Lower"
                        ucrBase.clsRsyntax.SetFunction("str_to_lower")
                    Case "Upper"
                        ucrBase.clsRsyntax.SetFunction("str_to_upper")
                    Case "Title"
                        ucrBase.clsRsyntax.SetFunction("str_to_title")
                    Case "Sentence"
                        ucrBase.clsRsyntax.SetFunction("str_to_sentence")
                End Select
            Else
                Select Case ucrInputTo.GetText
                    Case "Lower"
                        clsConvertSelectFunction.SetRCommand("str_to_lower")
                    Case "Upper"
                        clsConvertSelectFunction.SetRCommand("str_to_upper")
                    Case "Title"
                        clsConvertSelectFunction.SetRCommand("str_to_title")
                    Case "Sentence"
                        clsConvertSelectFunction.SetRCommand("str_to_sentence")
                End Select
                If Not ucrChkOverWriteColumns.Checked Then
                    clsDataFrameOperator.AddParameter("left", clsRFunctionParameter:=clsConvertSelectFunction, iPosition:=0, bIncludeArgumentName:=False)
                Else
                    clsAcrossFunction.AddParameter("left", clsRFunctionParameter:=clsConvertSelectFunction, iPosition:=1, bIncludeArgumentName:=False)
                End If
            End If
        End If
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumTransformMode
            Case TransformMode.Prepare
                ucrBase.iHelpTopicID = 343
            Case TransformMode.Climatic
                ucrBase.iHelpTopicID = 606
            Case TransformMode.Tricot
                ucrBase.iHelpTopicID = 749
        End Select
    End Sub

    Private Sub AddRemoveStartAndEndParameters()
        If rdoSingle.Checked Then
            If ucrChkFirstOr.Checked Then
                clsWordsFunction.AddParameter("start", clsRFunctionParameter:=ucrReceiverFirstWord.GetVariables(), iPosition:=1)
            Else
                clsWordsFunction.AddParameter("start", strParameterValue:=ucrNudFirstWord.Value, iPosition:=1)
            End If

            If ucrChkLastOr.Checked Then
                clsWordsFunction.AddParameter("end", clsRFunctionParameter:=ucrReceiverLastWord.GetVariables(), iPosition:=2)
            Else
                clsWordsFunction.AddParameter("end", strParameterValue:=ucrNudLastWord.Value, iPosition:=2)
            End If
        Else
            If ucrChkFirstOr.Checked Then
                clsWordsSelectFunction.AddParameter("start", clsRFunctionParameter:=ucrReceiverFirstWord.GetVariables(), iPosition:=1)
            Else
                clsWordsSelectFunction.AddParameter("start", strParameterValue:=ucrNudFirstWord.Value, iPosition:=1)
            End If

            If ucrChkLastOr.Checked Then
                clsWordsSelectFunction.AddParameter("end", clsRFunctionParameter:=ucrReceiverLastWord.GetVariables(), iPosition:=2)
            Else
                clsWordsSelectFunction.AddParameter("end", strParameterValue:=ucrNudLastWord.Value, iPosition:=2)
            End If
        End If
    End Sub

    Private Sub ucrReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverTransformText.ControlValueChanged, ucrSelectorForTransformText.ControlValueChanged,
            ucrPnlColumnSelectOptions.ControlValueChanged, ucrChkOverWriteColumns.ControlValueChanged
        NewDefaultName()
        SelectOptions()
        ChangeBaseFunction()
    End Sub

    Private Sub controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFirstWord.ControlContentsChanged, ucrNudWidth.ControlContentsChanged,
        ucrNudWidthTrunc.ControlContentsChanged, ucrNudWidthWrap.ControlContentsChanged, ucrNudFirstWord.ControlContentsChanged, ucrNudLastWord.ControlContentsChanged, ucrNudFrom.ControlContentsChanged, ucrNudTo.ControlContentsChanged,
        ucrReceiverLastWord.ControlContentsChanged, ucrReceiverTransformText.ControlContentsChanged, ucrPnlOperation.ControlContentsChanged, ucrPnlPad.ControlContentsChanged,
        ucrInputPad.ControlContentsChanged, ucrNewColName.ControlContentsChanged, ucrInputSeparator.ControlContentsChanged, ucrInputTo.ControlContentsChanged,
        ucrChkFirstOr.ControlContentsChanged, ucrChkLastOr.ControlContentsChanged, ucrPnlPad.ControlContentsChanged, ucrPnlSide.ControlContentsChanged, ucrPnlSideTrunc.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlPad_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPad.ControlValueChanged, ucrPnlOperation.ControlValueChanged, ucrPnlSide.ControlValueChanged
        ChangeBaseFunction()
        If Not rdoTrim.Checked Then
            Exit Sub
        End If

        If rdoSquish.Checked Then
            If rdoSingle.Checked Then
                clsSquishTrimFunction.SetRCommand("str_squish")
                clsSquishTrimFunction.RemoveParameterByName("side")
            Else
                clsSquishTrimSelectFunction.SetRCommand("str_squish")
                clsSquishTrimSelectFunction.RemoveParameterByName("side")
            End If
        Else
            If rdoSingle.Checked Then
                clsSquishTrimFunction.SetRCommand("str_trim")
                If rdoLeftPad.Checked Then
                    clsSquishTrimFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=2)
                ElseIf rdoRightPad.Checked Then
                    clsSquishTrimFunction.AddParameter("side", Chr(34) & "right" & Chr(34), iPosition:=2)
                ElseIf rdoBothPad.Checked Then
                    clsSquishTrimFunction.AddParameter("side", Chr(34) & "both" & Chr(34), iPosition:=2)
                End If
            Else
                clsSquishTrimSelectFunction.SetRCommand("str_trim")
                If rdoLeftPad.Checked Then
                    clsSquishTrimSelectFunction.AddParameter("side", Chr(34) & "left" & Chr(34), iPosition:=2)
                ElseIf rdoRightPad.Checked Then
                    clsSquishTrimSelectFunction.AddParameter("side", Chr(34) & "right" & Chr(34), iPosition:=2)
                ElseIf rdoBothPad.Checked Then
                    clsSquishTrimSelectFunction.AddParameter("side", Chr(34) & "both" & Chr(34), iPosition:=2)
                End If
            End If
        End If
    End Sub

    Private Sub ReopenDialog()
        'This is hardcoded here so that the checkbox is always unchecked when the dialog is reopened
        ucrChkOverWriteColumns.Checked = False
    End Sub

    Private Sub SelectOptions()
        clsGetDataFrameFunction.AddParameter("data_name", Chr(34) & ucrSelectorForTransformText.strCurrentDataFrame & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsGetDataFrameFunction.SetAssignTo(ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        clsAddColumnsFunction.AddParameter("data_name", Chr(34) & ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetDataFrameFunction.AddParameter("column_selection_name ", ucrReceiverTransformText.GetVariableNames, iPosition:=1)
        clsNamesFunction.AddParameter("data_name", ucrSelectorForTransformText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, iPosition:=0, bIncludeArgumentName:=False)

        If rdoMultiple.Checked Then
            clsDummyFunction.AddParameter("col", "multiple", iPosition:=0)
            ucrSelectorForTransformText.SetItemType("column_selection")
            ucrReceiverTransformText.strSelectorHeading = "Column selections"
            lblColumnToTransform.Text = "Select To Transform"
        ElseIf rdoSingle.Checked Then
            clsDummyFunction.AddParameter("col", "single", iPosition:=0)
            ucrSelectorForTransformText.SetItemType("column")
            ucrReceiverTransformText.strSelectorHeading = "Variables"
            lblColumnToTransform.Text = "Column To Transform"
        End If
    End Sub

    Private Sub ucrNewColName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNewColName.ControlValueChanged
        clsTildaOperator.AddParameter("new_name", Chr(34) & ucrNewColName.GetText & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
        clsTildaOperator.SetAssignTo("new_name")
    End Sub
End Class