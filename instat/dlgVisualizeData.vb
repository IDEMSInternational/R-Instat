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
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsVisDatFunction As New RFunction
    Private clsVisMissFunction As New RFunction
    Private clsVisGuessFunction As New RFunction
    Private clsCurrBaseFunction As New RFunction
    Private clsFilterFunction As New RFunction
    Private clsAsLogicalFunction As New RFunction
    Private clsRBinonFunction As New RFunction
    Private clsElementTextFunction As New RFunction
    Private clsThemeFunction As New RFunction
    Private clsNRowFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private clsBaseOperator As New ROperator

    Private Sub dlgVisualizeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 54
        Dim lstMaximumControls As New List(Of Control)
        Dim lstMaximumSizeControls As New List(Of Control)
        Dim dctPalette As New Dictionary(Of String, String)
        Dim dctPaletteGuess As New Dictionary(Of String, String)

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlVisualizeData.AddRadioButton(rdoVisDat)
        ucrPnlVisualizeData.AddRadioButton(rdoVisMiss)
        ucrPnlVisualizeData.AddRadioButton(rdoVisGuess)

        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisDat, "vis_dat")
        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisMiss, "vis_miss")
        ucrPnlVisualizeData.AddFunctionNamesCondition(rdoVisGuess, "vis_guess")

        ucrPnlVisualizeData.AddToLinkedControls(ucrChkSortVariables, {rdoVisDat, rdoVisMiss}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlVisualizeData.AddToLinkedControls(ucrInputComboboxPalette, {rdoVisDat, rdoVisGuess}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlVisualizeData.AddToLinkedControls(ucrNudMaximumSize, {rdoVisDat, rdoVisMiss}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=0.9)
        ucrPnlSelectData.AddRadioButton(rdoWholeDataFrame)
        ucrPnlSelectData.AddRadioButton(rdoSelectedColumn)

        ucrPnlSelectData.AddParameterPresentCondition(rdoWholeDataFrame, "data")
        ucrPnlSelectData.AddParameterPresentCondition(rdoSelectedColumn, "x")

        ucrChkSortVariables.SetParameter(New RParameter("sort_type", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=False)
        ucrChkSortVariables.SetText("Sort Variables")
        ucrChkSortVariables.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        ucrInputComboboxPalette.SetParameter(New RParameter("palette", 2))
        dctPalette.Add("default", Chr(34) & "default" & Chr(34))
        dctPalette.Add("qual", Chr(34) & "qual" & Chr(34))
        dctPalette.Add("cb_safe", Chr(34) & "cb_safe" & Chr(34))
        ucrInputComboboxPalette.SetDropDownStyleAsNonEditable()
        ucrInputComboboxPalette.SetItems(dctPalette)

        ucrNudMaximumSize.SetMinMax(0.1, Integer.MaxValue)
        ucrNudMaximumSize.DecimalPlaces = 1
        ucrNudMaximumSize.Increment = 0.1

        ' Not yet implemented
        ucrNudSamplingFunction.SetParameter(New RParameter("prob", 2))
        ucrNudSamplingFunction.SetMinMax(0.01, 1)
        ucrNudSamplingFunction.DecimalPlaces = 2
        ucrNudSamplingFunction.Increment = 0.01

        ucrChkAdjustSize.SetText("Adjust size of variable names:")
        ucrChkAdjustSize.AddToLinkedControls(ucrNudAdjustSize, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)
        ucrNudAdjustSize.SetParameter(New RParameter("size", 0))
        ucrNudAdjustSize.SetMinMax(0.1, 15)
        ucrNudAdjustSize.DecimalPlaces = 1
        ucrNudAdjustSize.Increment = 0.1
        ucrChkAdjustSize.AddParameterPresentCondition(True, "size")
        ucrChkAdjustSize.AddParameterPresentCondition(False, "size", False)

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

        ucrNudSamplingFunction.SetLinkedDisplayControl(lblSampling)
        ucrPnlSelectData.AddToLinkedControls(ucrReceiverVisualizeData, {rdoSelectedColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorVisualizeData.ucrAvailableDataFrames)
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsVisDatFunction = New RFunction
        clsVisMissFunction = New RFunction
        clsVisGuessFunction = New RFunction
        clsFilterFunction = New RFunction
        clsRBinonFunction = New RFunction
        clsAsLogicalFunction = New RFunction
        clsNRowFunction = New RFunction
        clsElementTextFunction = New RFunction
        clsThemeFunction = New RFunction
        clsBaseOperator = New ROperator

        clsPipeOperator = New ROperator
        ucrSelectorVisualizeData.Reset()
        ucrSaveGraph.Reset()

        clsCurrBaseFunction = clsVisDatFunction

        clsThemeFunction.SetPackageName("ggplot2")
        clsThemeFunction.SetRCommand("theme")
        clsThemeFunction.AddParameter("axis.text.x", clsRFunctionParameter:=clsElementTextFunction, iPosition:=0)

        clsElementTextFunction.SetPackageName("ggplot2")
        clsElementTextFunction.SetRCommand("element_text")

        clsVisDatFunction.SetPackageName("visdat")
        clsVisDatFunction.SetRCommand("vis_dat")
        clsVisDatFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
        clsVisDatFunction.AddParameter("sort_type", "FALSE", iPosition:=1)
        clsVisDatFunction.AddParameter("palette", Chr(34) & "default" & Chr(34), iPosition:=2)
        clsVisDatFunction.AddParameter("warn_large_data", "TRUE", iPosition:=3)

        clsVisMissFunction.SetPackageName("visdat")
        clsVisMissFunction.SetRCommand("vis_miss")
        clsVisMissFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
        clsVisMissFunction.AddParameter("cluster", "FALSE", iPosition:=1)
        clsVisMissFunction.AddParameter("sort_miss", "FALSE", iPosition:=2)
        clsVisMissFunction.AddParameter("show_perc", "TRUE", iPosition:=3)
        clsVisMissFunction.AddParameter("show_perc_col", "TRUE", iPosition:=4)
        clsVisMissFunction.AddParameter("warn_large_data", "TRUE", iPosition:=6)

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

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("left", clsRFunctionParameter:=clsCurrBaseFunction, iPosition:=0)

        clsBaseOperator.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorVisualizeData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisMissFunction, New RParameter("x", 0), 1)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisGuessFunction, New RParameter("x", 0), 2)
        ucrInputComboboxPalette.AddAdditionalCodeParameterPair(clsVisGuessFunction, New RParameter("palette", 1), iAdditionalPairNo:=1)
        ucrChkSortVariables.AddAdditionalCodeParameterPair(clsVisMissFunction, New RParameter("sort_miss", 2), iAdditionalPairNo:=1)


        ucrPnlSelectData.SetRCode(clsCurrBaseFunction, bReset)
        ucrPnlVisualizeData.SetRCode(clsCurrBaseFunction, bReset)
        ucrReceiverVisualizeData.SetRCode(clsVisDatFunction, bReset)
        ucrSelectorVisualizeData.SetRCode(clsNRowFunction, bReset)
        ucrSaveGraph.SetRCode(clsBaseOperator, bReset)
        ucrInputComboboxPalette.SetRCode(clsVisDatFunction, bReset)
        ucrChkSortVariables.SetRCode(clsVisDatFunction)
        ucrNudAdjustSize.SetRCode(clsElementTextFunction, bReset)
        ucrChkAdjustSize.SetRCode(clsElementTextFunction, bReset)
        ucrNudSamplingFunction.SetRCode(clsRBinonFunction, bReset)
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
            ucrSaveGraph.SetPrefix("vis_dat")
            clsCurrBaseFunction = clsVisDatFunction
        ElseIf rdoVisMiss.Checked Then
            ucrSaveGraph.SetPrefix("vis_miss")
            clsCurrBaseFunction = clsVisMissFunction
        ElseIf rdoVisGuess.Checked Then
            ucrSaveGraph.SetPrefix("vis_guess")
            clsCurrBaseFunction = clsVisGuessFunction
        End If
        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
        AddRemoveDataHideOptionsButtons()
    End Sub

    Private Sub AddRemoveDataHideOptionsButtons()
        If rdoWholeDataFrame.Checked Then
            ucrSelectorVisualizeData.lstAvailableVariable.Visible = False
            ucrSelectorVisualizeData.btnAdd.Visible = False
            ucrSelectorVisualizeData.btnDataOptions.Visible = False
        ElseIf rdoSelectedColumn.Checked Then
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

    Private Sub ucrNudMaximumSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudMaximumSize.ControlValueChanged
        MaximumDataPoint()
    End Sub

    Private Sub ucrNudSamplingFunction_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudSamplingFunction.ControlValueChanged, ucrReceiverVisualizeData.ControlValueChanged, ucrPnlSelectData.ControlValueChanged
        If rdoSelectedColumn.Checked AndAlso Not ucrReceiverVisualizeData.IsEmpty Then
            clsVisDatFunction.RemoveParameterByName("data")
            clsVisGuessFunction.RemoveParameterByName("data")
            clsVisMissFunction.RemoveParameterByName("data")
            If ucrNudSamplingFunction.Value = 1 Then
                clsVisDatFunction.RemoveParameterByName("x")
                clsVisGuessFunction.RemoveParameterByName("x")
                clsVisMissFunction.RemoveParameterByName("x")
                clsVisDatFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverVisualizeData.GetVariables(True), bIncludeArgumentName:=False, iPosition:=0)
                clsVisGuessFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverVisualizeData.GetVariables(True), bIncludeArgumentName:=False, iPosition:=0)
                clsVisMissFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverVisualizeData.GetVariables(True), bIncludeArgumentName:=False, iPosition:=0)
            Else ' if it is not checked we run vis_dat(col = columns selected)
                clsVisDatFunction.RemoveParameterByName("x")
                clsVisGuessFunction.RemoveParameterByName("x")
                clsVisMissFunction.RemoveParameterByName("x")
                clsPipeOperator.RemoveParameterByName("left")
                clsVisDatFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
                clsVisGuessFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
                clsVisMissFunction.AddParameter("x", clsROperatorParameter:=clsPipeOperator, iPosition:=0)
                clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrReceiverVisualizeData.GetVariables(True), iPosition:=0)
            End If
        ElseIf rdoWholeDataFrame.Checked Then
            clsVisDatFunction.RemoveParameterByName("x")
            clsVisGuessFunction.RemoveParameterByName("x")
            clsVisMissFunction.RemoveParameterByName("x")
            If ucrNudSamplingFunction.Value = 1 Then
                clsVisDatFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
                clsVisGuessFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
                clsVisMissFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
            Else
                clsPipeOperator.RemoveParameterByName("left")
                clsPipeOperator.AddParameter("left", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                clsVisDatFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)
                clsVisGuessFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)
                clsVisMissFunction.AddParameter("data", clsROperatorParameter:=clsPipeOperator, iPosition:=0, bIncludeArgumentName:=False)
            End If
        End If
    End Sub

    Private Sub ucrChkAdjustSize_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAdjustSize.ControlValueChanged
        If ucrChkAdjustSize.Checked Then
            clsBaseOperator.AddParameter("right", clsRFunctionParameter:=clsThemeFunction, iPosition:=1)
        Else
            clsBaseOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVisualizeData.ControlContentsChanged, ucrSelectorVisualizeData.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrNudMaximumSize.ControlValueChanged, ucrNudSamplingFunction.ControlValueChanged
        TestOkEnabled()
    End Sub
End Class