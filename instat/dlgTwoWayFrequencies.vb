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
Public Class dlgTwoWayFrequencies
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSjTab, clsSjPlot As New RFunction
    Public strDefaultDataFrame As String = ""
    Public strDefaultColumnVariable As String = ""
    Public strDefaultRowVariable As String = ""
    Private iFullWidth As Integer
    Private iGraphTypeMaxX As Integer
    Private iTableTypeMaxX As Integer

    Private Sub dlgTwoWayFrequencies_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
            iFullWidth = Me.Width
            iGraphTypeMaxX = grpFreqTypeGraph.Location.X
            iTableTypeMaxX = grpFreqTypeTable.Location.X
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        SetDefaultVariables()
        bReset = False
        'temp needed because of show/hiding bug
        SetLocations()
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'HelpID
        ucrBase.iHelpTopicID = 415
        ucrReceiverColumnFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverRowFactor.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverWeights.Selector = ucrSelectorTwoWayFrequencies
        ucrReceiverColumnFactor.SetDataType("factor")
        ucrReceiverColumnFactor.strSelectorHeading = "Factors"
        ucrReceiverWeights.SetDataType("numeric")
        ucrReceiverWeights.strSelectorHeading = "Numerics"

        'setting receivers parameters
        ucrReceiverRowFactor.SetParameter(New RParameter("var.row", 1))
        ucrReceiverRowFactor.SetParameterIsString()
        ucrReceiverRowFactor.strSelectorHeading = "Variables"
        ucrReceiverRowFactor.bWithQuotes = False
        ucrReceiverRowFactor.SetParameterIncludeArgumentName(False)

        ucrReceiverColumnFactor.SetParameter(New RParameter("var.col", 2))
        ucrReceiverColumnFactor.SetParameterIsString()
        ucrReceiverColumnFactor.bWithQuotes = False
        ucrReceiverColumnFactor.SetParameterIncludeArgumentName(False)

        'setting selector
        ucrSelectorTwoWayFrequencies.SetParameter(New RParameter("data", 0))
        ucrSelectorTwoWayFrequencies.SetParameterIsrfunction()
        ucrSelectorTwoWayFrequencies.bDropUnusedFilterLevels = True

        'ucrReceiverWeights
        ucrReceiverWeights.SetParameter(New RParameter("weight.by", 3))
        ucrReceiverWeights.SetParameterIsRFunction()

        'setting ucrPnlFreqType
        ucrPnlFreqType.SetParameter(New RParameter("fun", 4))
        ucrPnlFreqType.AddRadioButton(rdoCount, Chr(34) & "grpfrq" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoRow, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoColumn, Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddRadioButton(rdoCell, Chr(34) & "xtab" & Chr(34))

        'Adding ucrPnlFreqType conditions
        ucrPnlFreqType.AddParameterValuesCondition(rdoCount, "fun", Chr(34) & "grpfrq" & Chr(34))
        ucrPnlFreqType.AddParameterPresentCondition(rdoCount, "margin", False)
        ucrPnlFreqType.AddParameterValuesCondition(rdoRow, "fun", Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddParameterValuesCondition(rdoRow, "margin", Chr(34) & "row" & Chr(34))
        ucrPnlFreqType.AddParameterValuesCondition(rdoCell, "fun", Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddParameterValuesCondition(rdoCell, "margin", Chr(34) & "cell" & Chr(34))
        ucrPnlFreqType.AddParameterValuesCondition(rdoColumn, "fun", Chr(34) & "xtab" & Chr(34))
        ucrPnlFreqType.AddParameterValuesCondition(rdoColumn, "margin", Chr(34) & "col" & Chr(34))

        ucrChkRow.SetParameter(New RParameter("show.row.prc", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkRow.SetText("Row (%)")
        ucrChkRow.SetRDefault("FALSE")

        ucrChkCount.SetParameter(New RParameter("show.obs", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCount.SetText("Count")
        ucrChkCount.SetRDefault("TRUE")

        ucrChkColumn.SetParameter(New RParameter("show.col.prc", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkColumn.SetText("Column (%)")
        ucrChkColumn.SetRDefault("FALSE")

        ucrChkCell.SetParameter(New RParameter("show.cell.prc", 8), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkCell.SetText("Cell (%)")
        ucrChkCell.SetRDefault("FALSE")

        ucrChkWeights.SetText("Weights")
        ucrChkWeights.SetParameter(ucrReceiverWeights.GetParameter(), bNewChangeParameterValue:=False, bNewAddRemoveParameter:=True)
        ucrChkWeights.AddToLinkedControls(ucrReceiverWeights, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrChkFlip.SetParameter(New RParameter("coord.flip", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFlip.SetText("Flip Coordinates")
        ucrChkFlip.SetRDefault("FALSE")

        ucrChkFacetGrid.SetParameter(New RParameter("facet.grid", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:="TRUE", strNewValueIfUnchecked:="FALSE")
        ucrChkFacetGrid.SetText("Facet by Column Factor")

        'Setting ucrPnlFreqDisplay
        ucrPnlFreqDisplay.AddRadioButton(rdoTable)
        ucrPnlFreqDisplay.AddRadioButton(rdoGraph)
        ucrPnlFreqDisplay.AddRadioButton(rdoBoth)

        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoTable, "sjtab")
        ucrPnlFreqDisplay.AddFunctionNamesCondition(rdoGraph, "sjplot")
        'TODO conditions for both requires checks on multiple functions

        'Setting Display of the group boxes in the dialog
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkCount, {rdoTable, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkRow, {rdoTable, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkCell, {rdoTable, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkColumn, {rdoTable, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrPnlFreqType, {rdoGraph, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoCount)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrSaveGraph, {rdoGraph, rdoBoth}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFreqDisplay.AddToLinkedControls(ucrChkFacetGrid, {rdoGraph, rdoBoth}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")
        ucrPnlFreqType.SetLinkedDisplayControl(grpFreqTypeGraph)

        ucrSaveGraph.SetPrefix("two_way_freq")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorTwoWayFrequencies.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")
        ucrChkColumn.SetLinkedDisplayControl(grpFreqTypeTable)
    End Sub

    Private Sub SetDefaults()
        clsSjTab = New RFunction
        clsSjPlot = New RFunction

        'Reset
        ucrSelectorTwoWayFrequencies.Reset()
        ucrReceiverRowFactor.SetMeAsReceiver()
        ucrSaveGraph.Reset()

        'Defining Table functions and default functions
        clsSjTab.SetPackageName("sjPlot")
        clsSjTab.SetRCommand("sjtab")
        clsSjTab.AddParameter("show.obs", "TRUE")
        clsSjTab.AddParameter("show.summary", "FALSE")
        clsSjTab.AddParameter("digits", 0)
        clsSjTab.AddParameter("fun", Chr(34) & "xtab" & Chr(34))
        clsSjTab.AddParameter("title", Chr(34) & "" & Chr(34))
        clsSjTab.AddParameter("string.total", Chr(34) & "Total" & Chr(34))

        'Defining Plot functions and default functions
        clsSjPlot.SetPackageName("sjPlot")
        clsSjPlot.SetRCommand("sjplot")
        clsSjPlot.AddParameter("fun", Chr(34) & "grpfrq" & Chr(34))
        clsSjPlot.AddParameter("show.prc", "TRUE")
        clsSjPlot.AddParameter("show.n", "TRUE")
        clsSjPlot.AddParameter("title", Chr(34) & "" & Chr(34))
        clsSjPlot.AddParameter("facet.grid", "TRUE")
        clsSjPlot.SetAssignTo("last_graph", strTempDataframe:=ucrSelectorTwoWayFrequencies.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:="last_graph")
        ucrBase.clsRsyntax.SetBaseRFunction(clsSjTab)
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        Dim clsTempParamOne As RParameter
        Dim clsTempParamTwo As RParameter

        'Adding additional pair of fuction and parameters in various controls and setting up Rcode
        clsTempParamOne = New RParameter("x", 1)
        clsTempParamOne.bIncludeArgumentName = False
        ucrReceiverRowFactor.AddAdditionalCodeParameterPair(clsSjPlot, clsTempParamOne, iAdditionalPairNo:=1)

        clsTempParamTwo = New RParameter("grp", 2)
        clsTempParamTwo.bIncludeArgumentName = False
        ucrReceiverColumnFactor.AddAdditionalCodeParameterPair(clsSjPlot, clsTempParamTwo, iAdditionalPairNo:=1)

        ucrSelectorTwoWayFrequencies.AddAdditionalCodeParameterPair(clsSjPlot, ucrSelectorTwoWayFrequencies.GetParameter(), iAdditionalPairNo:=1)
        ucrChkWeights.AddAdditionalCodeParameterPair(clsSjPlot, ucrReceiverWeights.GetParameter(), iAdditionalPairNo:=1)
        ucrReceiverWeights.AddAdditionalCodeParameterPair(clsSjPlot, ucrReceiverWeights.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverRowFactor.SetRCode(clsSjTab, bReset)
        ucrReceiverColumnFactor.SetRCode(clsSjTab, bReset)
        ucrReceiverWeights.SetRCode(clsSjTab, bReset)
        ucrChkWeights.SetRCode(clsSjTab, bReset)
        ucrChkFlip.SetRCode(clsSjPlot, bReset)
        ucrPnlFreqType.SetRCode(clsSjPlot, bReset)
        If bReset OrElse Not rdoBoth.Checked Then
            ucrPnlFreqDisplay.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        End If
        ucrSelectorTwoWayFrequencies.SetRCode(clsSjTab, bReset)
        ucrChkCell.SetRCode(clsSjTab, bReset)
        ucrChkColumn.SetRCode(clsSjTab, bReset)
        ucrChkRow.SetRCode(clsSjTab, bReset)
        ucrChkCount.SetRCode(clsSjTab, bReset)
        ucrChkFacetGrid.SetRCode(clsSjPlot)
        ucrSaveGraph.SetRCode(clsSjPlot, bReset)
        SetLocations()
    End Sub

    Private Sub SetDefaultVariables()
        If strDefaultDataFrame <> "" Then
            ucrSelectorTwoWayFrequencies.SetDataframe(strDefaultDataFrame)
        End If
        If strDefaultColumnVariable <> "" Then
            ucrReceiverColumnFactor.Add(strDefaultColumnVariable, strDefaultDataFrame)
        End If
        If strDefaultRowVariable <> "" Then
            ucrReceiverRowFactor.Add(strDefaultRowVariable, strDefaultDataFrame)
        End If
        strDefaultDataFrame = ""
        strDefaultRowVariable = ""
        strDefaultColumnVariable = ""
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverColumnFactor.IsEmpty() AndAlso Not ucrReceiverRowFactor.IsEmpty() AndAlso ucrSaveGraph.IsComplete Then
            If Not ucrChkWeights.Checked Then
                ucrBase.OKEnabled(True)
            Else
                If Not ucrReceiverWeights.IsEmpty Then
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
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strGraph As String
        Dim strTempScript As String = ""
        Dim bIsAssigned As Boolean
        Dim bToBeAssigned As Boolean
        Dim strAssignTo As String

        If rdoBoth.Checked Then
            bIsAssigned = clsSjPlot.bIsAssigned
            bToBeAssigned = clsSjPlot.bToBeAssigned
            strAssignTo = clsSjPlot.strAssignTo

            strGraph = clsSjPlot.ToScript(strTempScript)
            frmMain.clsRLink.RunScript(strTempScript & strGraph, iCallType:=3)

            clsSjPlot.bIsAssigned = bIsAssigned
            clsSjPlot.bToBeAssigned = bToBeAssigned
            clsSjPlot.strAssignTo = strAssignTo
        End If
    End Sub

    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgTwoWayFrequencies.SetRCode(clsSjTab, clsSjPlot, bReset:=bResetSubdialog)
        bResetSubdialog = False
        sdgTwoWayFrequencies.ShowDialog()
        TestOkEnabled()
    End Sub

    Private Sub SetLocations()
        If rdoBoth.Checked Then
            grpFreqTypeTable.Location = New Point(iTableTypeMaxX / 1.1, grpFreqTypeTable.Location.Y)
            grpFreqTypeGraph.Location = New Point(iGraphTypeMaxX, grpFreqTypeGraph.Location.Y)
            Me.Size = New Size(iFullWidth, Me.Height)
        Else
            If rdoGraph.Checked Then
                grpFreqTypeGraph.Show()
                grpFreqTypeTable.Hide()
            ElseIf rdoTable.Checked Then
                grpFreqTypeGraph.Hide()
                grpFreqTypeTable.Show()
            End If
            grpFreqTypeTable.Location = New Point(iTableTypeMaxX, grpFreqTypeTable.Location.Y)
            grpFreqTypeGraph.Location = New Point(iGraphTypeMaxX / 1.36, grpFreqTypeGraph.Location.Y)
            Me.Size = New Size(iFullWidth / 1.13, Me.Height)
        End If
    End Sub

    Private Sub FlipAndDisplayTypeControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFlip.ControlValueChanged, ucrPnlFreqDisplay.ControlValueChanged
        Dim clsRowParam As RParameter
        Dim clsColumnParam As RParameter

        clsRowParam = ucrReceiverRowFactor.GetParameter()
        clsColumnParam = ucrReceiverColumnFactor.GetParameter()
        If rdoTable.Checked OrElse rdoBoth.Checked Then
            If ucrChkFlip.Checked Then
                clsColumnParam.Position = 1
                clsRowParam.Position = 2
            Else
                clsRowParam.Position = 1
                clsColumnParam.Position = 2
            End If
            ucrReceiverRowFactor.SetParameter(clsRowParam)
            ucrReceiverColumnFactor.SetParameter(clsColumnParam)
        End If
        SetLocations()
        SetBaseFunction()
    End Sub

    Private Sub ucrPnlFreqType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFreqType.ControlValueChanged
        If rdoCell.Checked Then
            clsSjPlot.AddParameter("margin", Chr(34) & "cell" & Chr(34))
        ElseIf rdoColumn.Checked Then
            clsSjPlot.AddParameter("margin", Chr(34) & "col" & Chr(34))
        ElseIf rdoRow.Checked Then
            clsSjPlot.AddParameter("margin", Chr(34) & "row" & Chr(34))
        Else
            clsSjPlot.RemoveParameterByName("margin")
        End If
        AddRemoveFacets()
    End Sub

    Private Sub AddRemoveFacets()
        If rdoCount.Checked Then
            ucrChkFacetGrid.Enabled = True
            If ucrChkFacetGrid.Checked Then
                clsSjPlot.AddParameter("facet.grid", "TRUE")
            End If
        Else
                clsSjPlot.RemoveParameterByName("facet.grid")
            ucrChkFacetGrid.Enabled = False
        End If
    End Sub

    Private Sub ucrChkWeights_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkWeights.ControlValueChanged
        If ucrChkWeights.Checked Then
            ucrReceiverWeights.SetMeAsReceiver()
        Else
            ucrReceiverRowFactor.SetMeAsReceiver()
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverColumnFactor.ControlContentsChanged, ucrReceiverRowFactor.ControlContentsChanged, ucrReceiverWeights.ControlContentsChanged, ucrChkWeights.ControlContentsChanged, ucrSaveGraph.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub SetBaseFunction()
        If rdoTable.Checked OrElse rdoBoth.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjTab)
            'ucrBase.clsRsyntax.bHTMLOutput = True
            ucrBase.clsRsyntax.iCallType = 2
        ElseIf rdoGraph.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSjPlot)
            ' ucrBase.clsRsyntax.bHTMLOutput = False
            ucrBase.clsRsyntax.iCallType = 3
        End If
    End Sub

    Private Sub ucrChkFacetGrid_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkFacetGrid.ControlValueChanged
        AddRemoveFacets()
    End Sub
End Class