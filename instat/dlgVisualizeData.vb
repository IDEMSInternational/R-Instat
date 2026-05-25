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

Public Class dlgVisualizeData
    Public enumVisualizeMode As String = VisualizeMode.Prepare
    Public Enum VisualizeMode
        Prepare
        Describe
        Climatic
        Tricot
    End Enum

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsVisDatFunction As New RFunction
    Private clsVisMissFunction As New RFunction
    Private clsVisGuessFunction As New RFunction
    Private clsVisValueFunction As New RFunction
    Private clsCurrBaseFunction As New RFunction
    Private clsFilterFunction As New RFunction
    Private clsAsLogicalFunction As New RFunction
    Private clsRBinonFunction As New RFunction
    Private clsGetVariableFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private clsNRowFunction As New RFunction
    Private clsPipeOperator As New ROperator

    Private Sub dlgVisualizeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetHelpOptions()
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim lstMaximumControls As New List(Of Control)
        Dim lstMaximumSizeControls As New List(Of Control)
        Dim dctPalette As New Dictionary(Of String, String)
        Dim dctPaletteGuess As New Dictionary(Of String, String)
        Dim dctColourPallette As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 733
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlVisualizeData.AddRadioButton(rdoVisDat)
        ucrPnlVisualizeData.AddRadioButton(rdoVisMiss)
        ucrPnlVisualizeData.AddRadioButton(rdoVisGuess)
        ucrPnlVisualizeData.AddRadioButton(rdoNumeric)

        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisDat, "vis_dat")
        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisMiss, "vis_miss")
        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisGuess, "vis_guess")
        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoNumeric, "vis_value")

        ucrByFactorsReceiver.SetParameter(New RParameter("facet", 3))
        ucrByFactorsReceiver.Selector = ucrSelectorVisualizeData
        ucrByFactorsReceiver.SetIncludedDataTypes({"factor", "ordered,factor"})
        ucrByFactorsReceiver.SetSelectorHeading("Factor")
        ucrByFactorsReceiver.SetParameterIsString()
        ucrByFactorsReceiver.bWithQuotes = False
        ucrByFactorsReceiver.SetValuesToIgnore({Chr(34) & Chr(34)})
        ucrByFactorsReceiver.bAddParameterIfEmpty = True

        ucrPnlVisualizeData.AddToLinkedControls(ucrChkFacet, {rdoVisDat, rdoVisMiss}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlVisualizeData.AddToLinkedControls(ucrChkSortVariables, {rdoVisDat, rdoVisMiss}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlVisualizeData.AddToLinkedControls(ucrInputComboboxPalette, {rdoVisDat, rdoVisGuess}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlVisualizeData.AddToLinkedControls(ucrNudMaximumSize, {rdoVisDat, rdoVisMiss}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=2.5)
        ucrPnlSelectData.AddRadioButton(rdoWholeDataFrame)
        ucrPnlSelectData.AddRadioButton(rdoSelectedColumn)
        ucrPnlVisualizeData.AddToLinkedControls(ucrInputColourPalette, {rdoNumeric}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Viridis")
        ucrPnlVisualizeData.AddToLinkedControls({ucrInputColour}, {rdoNumeric}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Grey")

        ucrInputColour.SetParameter(New RParameter("na_colour", 4))
        ucrInputColour.SetLinkedDisplayControl(lblColour)
        ucrInputColour.SetRDefault(Chr(34) & "Grey" & Chr(34))
        ucrInputColour.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctColour))

        ucrPnlSelectData.AddParameterPresentCondition(rdoWholeDataFrame, "data")
        ucrPnlSelectData.AddParameterPresentCondition(rdoSelectedColumn, "x")

        ucrChkSortVariables.SetParameter(New RParameter("sort_type", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False)
        ucrChkSortVariables.SetText("Sort Variables")
        ucrChkSortVariables.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputColourPalette.SetParameter(New RParameter("viridis_option", 3))
        dctColourPallette.Add("Viridis", Chr(34) & "A" & Chr(34))
        dctColourPallette.Add("Magma", Chr(34) & "B" & Chr(34))
        dctColourPallette.Add("Inferno", Chr(34) & "C" & Chr(34))
        dctColourPallette.Add("Plasma", Chr(34) & "D" & Chr(34))
        dctColourPallette.Add("Cividis", Chr(34) & "E" & Chr(34))
        ucrInputColourPalette.SetItems(dctColourPallette)
        ucrInputColourPalette.SetDropDownStyleAsNonEditable()

        ucrInputComboboxPalette.SetParameter(New RParameter("palette", 2))
        dctPalette.Add("default", Chr(34) & "default" & Chr(34))
        dctPalette.Add("qual", Chr(34) & "qual" & Chr(34))
        dctPalette.Add("cb_safe", Chr(34) & "cb_safe" & Chr(34))
        ucrInputComboboxPalette.SetDropDownStyleAsNonEditable()
        ucrInputComboboxPalette.SetItems(dctPalette)

        ucrNudMaximumSize.DecimalPlaces = 1
        ucrNudMaximumSize.Increment = 0.1
        ucrNudMaximumSize.Minimum = 0.1
        ucrNudMaximumSize.Maximum = Integer.MaxValue

        ' Not yet implemented
        ucrNudSamplingFunction.SetParameter(New RParameter("prob", 2))
        ucrNudSamplingFunction.DecimalPlaces = 2
        ucrNudSamplingFunction.Increment = 0.01
        ucrNudSamplingFunction.Minimum = 0.01
        ucrNudSamplingFunction.Maximum = 1

        ucrReceiverVisualizeData.SetParameter(New RParameter("x", 0))
        ucrReceiverVisualizeData.SetParameterIsRFunction()
        ucrReceiverVisualizeData.Selector = ucrSelectorVisualizeData
        ucrReceiverVisualizeData.bForceAsDataFrame = True
        ucrReceiverVisualizeData.SetMeAsReceiver()

        ucrSelectorVisualizeData.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrSelectorVisualizeData.SetParameterIsrfunction()

        ucrInputComboboxPalette.SetLinkedDisplayControl(lblPaltte)
        lstMaximumSizeControls.Add(lblMillionDataPoints)
        lstMaximumSizeControls.Add(lblMaximumSize)
        ucrNudMaximumSize.SetLinkedDisplayControl(lstMaximumSizeControls)
        ucrInputColourPalette.SetLinkedDisplayControl(lblpalettecolor)

        ucrChkFacet.SetText("Facets")
        ucrChkFacet.AddToLinkedControls(ucrByFactorsReceiver, {True}, bNewLinkedHideIfParameterMissing:=True)
        ucrChkFacet.AddParameterValuesCondition(True, "checked", "True")
        ucrChkFacet.AddParameterValuesCondition(False, "checked", "False")

        ucrNudSamplingFunction.SetLinkedDisplayControl(lblSampling)
        ucrPnlSelectData.AddToLinkedControls(ucrReceiverVisualizeData, {rdoSelectedColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Store Graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorVisualizeData.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsVisDatFunction = New RFunction
        clsVisMissFunction = New RFunction
        clsVisGuessFunction = New RFunction
        clsVisValueFunction = New RFunction
        clsFilterFunction = New RFunction
        clsRBinonFunction = New RFunction
        clsDummyFunction = New RFunction
        clsAsLogicalFunction = New RFunction
        clsNRowFunction = New RFunction
        clsGetVariableFunction = New RFunction
        clsPipeOperator = New ROperator
        ucrSelectorVisualizeData.Reset()
        ucrSaveGraph.Reset()

        clsCurrBaseFunction = clsVisDatFunction

        clsGetVariableFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetVariableFunction.SetAssignTo("colnames")
        clsGetVariableFunction.AddParameter("force_as_data_frame", "TRUE")

        clsVisDatFunction.SetPackageName("visdat")
        clsVisDatFunction.SetRCommand("vis_dat")
        clsVisDatFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariableFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsVisDatFunction.AddParameter("sort_type", "FALSE", iPosition:=1)
        clsVisDatFunction.AddParameter("palette", Chr(34) & "default" & Chr(34), iPosition:=2)
        clsVisDatFunction.AddParameter("warn_large_data", "TRUE", iPosition:=3)

        clsVisMissFunction.SetPackageName("visdat")
        clsVisMissFunction.SetRCommand("vis_miss")
        clsVisMissFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariableFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsVisMissFunction.AddParameter("cluster", "FALSE", iPosition:=1)
        clsVisMissFunction.AddParameter("sort_miss", "FALSE", iPosition:=2)
        clsVisMissFunction.AddParameter("show_perc", "TRUE", iPosition:=3)
        clsVisMissFunction.AddParameter("show_perc_col", "TRUE", iPosition:=4)
        clsVisMissFunction.AddParameter("warn_large_data", "TRUE", iPosition:=6)

        clsVisValueFunction.SetPackageName("visdat")
        clsVisValueFunction.SetRCommand("vis_value")
        clsVisValueFunction.AddParameter("data", clsRFunctionParameter:=clsGetVariableFunction, bIncludeArgumentName:=False, iPosition:=0)
        clsVisValueFunction.AddParameter("viridis_option", Chr(34) & "A" & Chr(34), iPosition:=1)
        clsVisValueFunction.AddParameter("na_colour", Chr(34) & "grey" & Chr(34), iPosition:=2)

        clsPipeOperator.SetOperation("%>%")
        clsPipeOperator.AddParameter("right", clsRFunctionParameter:=clsFilterFunction, iPosition:=1)

        clsFilterFunction.SetPackageName("dplyr")
        clsFilterFunction.SetRCommand("filter")
        clsFilterFunction.AddParameter(clsRFunctionParameter:=clsAsLogicalFunction, iPosition:=0)

        clsAsLogicalFunction.SetRCommand("as.logical")
        clsAsLogicalFunction.AddParameter("x", clsRFunctionParameter:=clsRBinonFunction, bIncludeArgumentName:=False, iPosition:=0)

        clsRBinonFunction.SetRCommand("rbinom")
        clsRBinonFunction.AddParameter("n", clsRFunctionParameter:=clsNRowFunction, iPosition:=0)
        clsRBinonFunction.AddParameter("size", "1", iPosition:=1)
        clsRBinonFunction.AddParameter("prob", "1", iPosition:=2)

        clsNRowFunction.SetRCommand("nrow")

        clsVisGuessFunction.SetPackageName("visdat")
        clsVisGuessFunction.SetRCommand("vis_guess")
        clsVisGuessFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)

        clsCurrBaseFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorVisualizeData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsCurrBaseFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisMissFunction, New RParameter("x", 0), 1)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisGuessFunction, New RParameter("x", 0), 2)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisValueFunction, New RParameter("x", 0), 3)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsPipeOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), 4)
        ucrSelectorVisualizeData.AddAdditionalCodeParameterPair(clsPipeOperator, New RParameter("left", 0, bNewIncludeArgumentName:=False), 1)
        ucrSaveGraph.AddAdditionalRCode(clsVisMissFunction, iAdditionalPairNo:=1)
        ucrSaveGraph.AddAdditionalRCode(clsVisGuessFunction, iAdditionalPairNo:=2)
        ucrSaveGraph.AddAdditionalRCode(clsVisValueFunction, iAdditionalPairNo:=3)
        ucrInputComboboxPalette.AddAdditionalCodeParameterPair(clsVisGuessFunction, New RParameter("palette", 1), iAdditionalPairNo:=1)
        ucrChkSortVariables.AddAdditionalCodeParameterPair(clsVisMissFunction, New RParameter("sort_miss", 2), iAdditionalPairNo:=1)

        ucrPnlSelectData.SetRCode(clsCurrBaseFunction, bReset)
        ucrPnlVisualizeData.SetRCode(clsCurrBaseFunction, bReset)
        ucrSelectorVisualizeData.SetRCode(clsNRowFunction, bReset)
        ucrSaveGraph.SetRCode(clsVisDatFunction, bReset)
        ucrInputComboboxPalette.SetRCode(clsVisDatFunction, bReset)
        ucrInputColourPalette.SetRCode(clsVisValueFunction, bReset)
        ucrInputColour.SetRCode(clsVisValueFunction, bReset)
        ucrChkSortVariables.SetRCode(clsVisDatFunction)
        ucrNudSamplingFunction.SetRCode(clsRBinonFunction, bReset)
        If bReset Then
            ucrReceiverVisualizeData.SetRCode(clsVisDatFunction, bReset)
            ucrChkFacet.SetRCode(clsDummyFunction, bReset)
        End If
    End Sub

    Private Sub TestOkEnabled()
        If ucrSelectorVisualizeData.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "" OrElse (rdoSelectedColumn.Checked AndAlso ucrReceiverVisualizeData.IsEmpty) OrElse Not ucrSaveGraph.IsComplete() OrElse (ucrNudMaximumSize.Visible = True AndAlso ucrNudMaximumSize.GetText = "") OrElse (ucrNudSamplingFunction.GetText = "") Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
        ' Temporary fix for resetting  the maximum value when the default is not  changed 
        MaximumDataPoint()
    End Sub

    Private Sub ucrPnlVisualizeData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlVisualizeData.ControlValueChanged
        If rdoVisDat.Checked Then
            ucrReceiverVisualizeData.SetIncludedDataTypes({"numeric", "logical", "factor", "character", "interger", "Date"})
            ucrSaveGraph.SetPrefix("vis_dat")
            clsCurrBaseFunction = clsVisDatFunction
        ElseIf rdoVisMiss.Checked Then
            ucrReceiverVisualizeData.SetIncludedDataTypes({"numeric", "logical", "factor", "character", "interger", "Date"})
            ucrSaveGraph.SetPrefix("vis_miss")
            clsCurrBaseFunction = clsVisMissFunction
        ElseIf rdoVisGuess.Checked Then
            ucrReceiverVisualizeData.SetIncludedDataTypes({"numeric", "logical", "factor", "character", "interger", "Date"})
            ucrSaveGraph.SetPrefix("vis_guess")
            clsCurrBaseFunction = clsVisGuessFunction
        ElseIf rdoNumeric.Checked Then
            ucrReceiverVisualizeData.SetIncludedDataTypes({"numeric", "logical", "interger"})
            ucrSaveGraph.SetPrefix("vis_value")
            clsCurrBaseFunction = clsVisValueFunction
        End If
        ucrBase.clsRsyntax.SetBaseRFunction(clsCurrBaseFunction)
        AddRemoveDataHideOptionsButtons()
        If rdoNumeric.Checked Then
            rdoWholeDataFrame.Enabled = False
        Else
            rdoWholeDataFrame.Enabled = True
        End If
    End Sub

    Private Sub AddRemoveDataHideOptionsButtons()
        If rdoWholeDataFrame.Checked Then
            If ucrChkFacet.Checked Then
                ucrSelectorVisualizeData.lstAvailableVariable.Visible = True
                ucrSelectorVisualizeData.btnAdd.Visible = True
                ucrSelectorVisualizeData.btnDataOptions.Visible = True
            Else
                ucrSelectorVisualizeData.lstAvailableVariable.Visible = False
                ucrSelectorVisualizeData.btnAdd.Visible = False
                ucrSelectorVisualizeData.btnDataOptions.Visible = False
            End If
        Else
            ucrSelectorVisualizeData.lstAvailableVariable.Visible = True
            ucrSelectorVisualizeData.btnAdd.Visible = True
            ucrSelectorVisualizeData.btnDataOptions.Visible = True
        End If
    End Sub

    Private Sub ucrControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSelectData.ControlValueChanged, ucrSelectorVisualizeData.ControlValueChanged, ucrReceiverVisualizeData.ControlValueChanged
        AddRemoveDataHideOptionsButtons()
    End Sub

    ''' <summary>
    '''This sub converts the maximum size nud's value To millions
    ''' </summary>
    Private Sub MaximumDataPoint()
        Dim strNudValue As String = ucrNudMaximumSize.GetText()
        Dim dcNudValue As Decimal
        Dim strLargeDataSizeParamVal As Integer
        If Decimal.TryParse(strNudValue, dcNudValue) Then
            strLargeDataSizeParamVal = dcNudValue * 1000000
            clsVisMissFunction.AddParameter("large_data_size", strParameterValue:=strLargeDataSizeParamVal, iPosition:=5)
            clsVisDatFunction.AddParameter("large_data_size", strParameterValue:=strLargeDataSizeParamVal, iPosition:=4)
        End If
    End Sub

    Private Sub SetHelpOptions()
        Select Case enumVisualizeMode
            Case VisualizeMode.Prepare
                ucrBase.iHelpTopicID = 54
            Case VisualizeMode.Describe
                ucrBase.iHelpTopicID = 600
            Case VisualizeMode.Climatic
                ucrBase.iHelpTopicID = 524
            Case VisualizeMode.Tricot
                ucrBase.iHelpTopicID = 733
        End Select
    End Sub

    Private Sub ucrNudMaximumSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudMaximumSize.ControlValueChanged
        MaximumDataPoint()
    End Sub

    Private Sub ucrNudSamplingFunction_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudSamplingFunction.ControlValueChanged, ucrReceiverVisualizeData.ControlValueChanged, ucrPnlSelectData.ControlValueChanged
        If rdoSelectedColumn.Checked AndAlso Not ucrReceiverVisualizeData.IsEmpty Then
            clsVisDatFunction.RemoveParameterByName("data")
            clsVisGuessFunction.RemoveParameterByName("data")
            clsVisMissFunction.RemoveParameterByName("data")
            clsVisValueFunction.RemoveParameterByName("data")
            If ucrNudSamplingFunction.Value = 1 Then
                clsVisDatFunction.RemoveParameterByName("x")
                clsVisGuessFunction.RemoveParameterByName("x")
                clsVisMissFunction.RemoveParameterByName("x")
                clsVisValueFunction.RemoveParameterByName("x")
                clsVisValueFunction.AddParameter("x", clsRFunctionParameter:=clsGetVariableFunction, bIncludeArgumentName:=False, iPosition:=0)
                clsVisDatFunction.AddParameter("x", clsRFunctionParameter:=clsGetVariableFunction, bIncludeArgumentName:=False, iPosition:=0)
                clsVisGuessFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverVisualizeData.GetVariables(True), bIncludeArgumentName:=False, iPosition:=0)
                clsVisMissFunction.AddParameter("x", clsRFunctionParameter:=clsGetVariableFunction, bIncludeArgumentName:=False, iPosition:=0)
            Else ' if it is not checked we run vis_dat(col = columns selected)
                clsVisDatFunction.RemoveParameterByName("x")
                clsVisGuessFunction.RemoveParameterByName("x")
                clsVisMissFunction.RemoveParameterByName("x")
                clsPipeOperator.RemoveParameterByName("left")
                clsVisDatFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
                clsVisGuessFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
                clsVisMissFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
                clsVisValueFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
                clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrReceiverVisualizeData.GetVariables(True), iPosition:=0)
            End If
        ElseIf rdoWholeDataFrame.Checked Then
            clsVisDatFunction.RemoveParameterByName("x")
            clsVisGuessFunction.RemoveParameterByName("x")
            clsVisMissFunction.RemoveParameterByName("x")
            clsVisValueFunction.RemoveParameterByName("x")
            If ucrNudSamplingFunction.Value = 1 Then
                clsVisDatFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
                clsVisGuessFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
                clsVisMissFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
                clsVisValueFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
            Else
                clsPipeOperator.RemoveParameterByName("left")
                clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                clsVisDatFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)
                clsVisGuessFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)
                clsVisMissFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)
                clsVisValueFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)
            End If
        End If
    End Sub

    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVisualizeData.ControlContentsChanged, ucrSelectorVisualizeData.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrNudMaximumSize.ControlValueChanged, ucrNudSamplingFunction.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrChkFacet_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFacet.ControlValueChanged, ucrByFactorsReceiver.ControlValueChanged
        If ucrChkFacet.Checked Then
            ucrByFactorsReceiver.SetMeAsReceiver()
            If Not ucrByFactorsReceiver.IsEmpty Then
                clsVisDatFunction.AddParameter("facet", ucrByFactorsReceiver.GetVariableNames(bWithQuotes:=False))
                clsVisMissFunction.AddParameter("facet", ucrByFactorsReceiver.GetVariableNames(bWithQuotes:=False))
            Else
                clsVisDatFunction.RemoveParameterByName("facet")
                clsVisMissFunction.RemoveParameterByName("facet")
            End If
        Else
            ucrReceiverVisualizeData.SetMeAsReceiver()
            clsVisDatFunction.RemoveParameterByName("facet")
            clsVisMissFunction.RemoveParameterByName("facet")
        End If
        AddRemoveDataHideOptionsButtons()
    End Sub

    Private Sub ucrByFactorsReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrByFactorsReceiver.ControlValueChanged, ucrReceiverVisualizeData.ControlValueChanged, ucrSelectorVisualizeData.ControlValueChanged, ucrPnlVisualizeData.ControlValueChanged
        If ucrReceiverVisualizeData.lstSelectedVariables.Items.Count <= 0 Then
            Exit Sub
        End If
        Dim lstvariable As List(Of String) = ucrReceiverVisualizeData.GetVariableNamesAsList
        Dim strFacetvariable As String = ucrByFactorsReceiver.GetVariableNames(False)
        If Not ucrByFactorsReceiver.IsEmpty AndAlso (rdoVisDat.Checked OrElse rdoVisMiss.Checked) AndAlso Not lstvariable.Contains(strFacetvariable) Then
            lstvariable.Add(strFacetvariable)
        End If
        clsGetVariableFunction.AddParameter("data_name", Chr(34) & ucrSelectorVisualizeData.ucrAvailableDataFrames.strCurrDataFrame & Chr(34), iPosition:=0)
        clsGetVariableFunction.AddParameter("col_names", frmMain.clsRLink.GetListAsRString(lstvariable, bWithQuotes:=True), iPosition:=1)
    End Sub
End Class