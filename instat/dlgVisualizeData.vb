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

Public Class dlgVisualizeData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsVisDatFunction As New RFunction
    Private clsVisMissFunction As New RFunction
    Private clsVisGuessFunction As New RFunction
    Private clsCurrBaseFunction As New RFunction
    Private clsSamplingFraction As New RFunction

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

        ucrPnlVisualizeData.AddToLinkedControls(ucrChkSortVariables, {rdoVisDat, rdoVisMiss}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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

        ucrNudMaximumSize.DecimalPlaces = 1
        ucrNudMaximumSize.Increment = 0.1
        ucrNudMaximumSize.Minimum = 0.1
        ucrNudMaximumSize.Maximum = Integer.MaxValue

        ' Not yet implemented
        ucrNudSamplingFunction.SetParameter(New RParameter("prop", 1))
        ucrNudSamplingFunction.DecimalPlaces = 2
        ucrNudSamplingFunction.Increment = 0.01
        ucrNudSamplingFunction.Minimum = 0.01
        ucrNudSamplingFunction.Maximum = 1

        ucrReceiverVisualizeData.SetParameter(New RParameter("x", 0))
        ucrReceiverVisualizeData.SetParameterIsRFunction()
        ucrReceiverVisualizeData.Selector = ucrSelectorVisualizeData
        ucrReceiverVisualizeData.bForceAsDataFrame = True
        ucrReceiverVisualizeData.SetMeAsReceiver()

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
        clsSamplingFraction = New RFunction
        ucrSelectorVisualizeData.Reset()
        ucrSaveGraph.Reset()

        clsCurrBaseFunction = clsVisDatFunction

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

        clsVisGuessFunction.SetPackageName("visdat")
        clsVisGuessFunction.SetRCommand("vis_guess")
        clsVisGuessFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)

        clsCurrBaseFunction.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorVisualizeData.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsCurrBaseFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisMissFunction, New RParameter("x", 0), 1)
        ucrReceiverVisualizeData.AddAdditionalCodeParameterPair(clsVisGuessFunction, New RParameter("x", 0), 2)
        ucrSaveGraph.AddAdditionalRCode(clsVisMissFunction, iAdditionalPairNo:=1)
        ucrSaveGraph.AddAdditionalRCode(clsVisGuessFunction, iAdditionalPairNo:=2)
        ucrInputComboboxPalette.AddAdditionalCodeParameterPair(clsVisGuessFunction, New RParameter("palette", 1), iAdditionalPairNo:=1)
        ucrChkSortVariables.AddAdditionalCodeParameterPair(clsVisMissFunction, New RParameter("sort_miss", 2), iAdditionalPairNo:=1)

        ucrPnlSelectData.SetRCode(clsCurrBaseFunction, bReset)
        ucrPnlVisualizeData.SetRCode(clsCurrBaseFunction, bReset)
        ucrReceiverVisualizeData.SetRCode(clsVisDatFunction, bReset)
        ucrSaveGraph.SetRCode(clsVisDatFunction, bReset)
        ucrInputComboboxPalette.SetRCode(clsVisDatFunction, bReset)
        ucrChkSortVariables.SetRCode(clsVisDatFunction)
    End Sub

    Private Sub TestOkEnabled()
        If ucrSelectorVisualizeData.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "" OrElse (rdoSelectedColumn.Checked AndAlso ucrReceiverVisualizeData.IsEmpty) OrElse Not ucrSaveGraph.IsComplete() OrElse (ucrNudMaximumSize.Visible = True AndAlso ucrNudMaximumSize.GetText = "") Then
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

    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverVisualizeData.ControlContentsChanged, ucrSelectorVisualizeData.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged, ucrNudMaximumSize.ControlValueChanged
        TestOkEnabled()
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
        ucrBase.clsRsyntax.SetBaseRFunction(clsCurrBaseFunction)
        AddRemoveDataHideOptionsButtons()
    End Sub

    Private Sub AddRemoveDataHideOptionsButtons()
        If rdoWholeDataFrame.Checked Then
            clsCurrBaseFunction.RemoveParameterByName("x")
            ucrSelectorVisualizeData.lstAvailableVariable.Visible = False
            ucrSelectorVisualizeData.btnAdd.Visible = False
            ucrSelectorVisualizeData.btnDataOptions.Visible = False
            clsCurrBaseFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorVisualizeData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
        ElseIf rdoSelectedColumn.Checked Then
            clsCurrBaseFunction.RemoveParameterByName("data")
            ucrSelectorVisualizeData.lstAvailableVariable.Visible = True
            ucrSelectorVisualizeData.btnAdd.Visible = True
            ucrSelectorVisualizeData.btnDataOptions.Visible = True
            clsCurrBaseFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverVisualizeData.GetVariables(), iPosition:=0)
        End If
    End Sub

    Private Sub ucrControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSelectData.ControlValueChanged, ucrSelectorVisualizeData.ControlValueChanged, ucrReceiverVisualizeData.ControlValueChanged, ucrInputComboboxPalette.ControlValueChanged
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
End Class