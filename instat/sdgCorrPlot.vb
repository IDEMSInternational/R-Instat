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
Public Class sdgCorrPlot
    Public clsRGGscatmatrixFunction, clsRGGcorrGraphicsFunction, clsCorrelationTestFunction, clsCorrelationFunction, clsRGraphicsFuction, clsRTempFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Private clsRsyntax As RSyntax
    Private ucrBaseSelector As ucrSelector
    Public strDataFrame As String

    Private Sub sdgCorrPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim dctGeom As New Dictionary(Of String, String)

        ucrNudMaximumSize.SetParameter(New RParameter("max_size", 1))
        ucrNudMaximumSize.SetMinMax(1, 10)
        ucrNudMaximumSize.SetRDefault("6")

        ucrNudMinimunSize.SetParameter(New RParameter("min_size", 2))
        ucrNudMinimunSize.SetMinMax(1, 5)
        ucrNudMinimunSize.SetRDefault("2")

        ucrChkLabel.SetParameter(New RParameter("label", 4))
        ucrChkLabel.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkLabel.SetText("Label")
        ucrChkLabel.SetRDefault("FALSE")

        ucrSaveGraph.SetPrefix("CorGraph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(dlgCorrelation.ucrSelectorCorrelation.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph")
        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetAssignToIfUncheckedValue("last_graph")

        ucrReceiverFactor.SetParameter(New RParameter("color", 2))
        ucrReceiverFactor.Selector = ucrSelectorFactor
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetDataType("factor")
        ucrReceiverFactor.SetMeAsReceiver()

        ucrPnlGraphType.AddToLinkedControls(ucrInputComboGeom, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="tile")
        ucrPnlGraphType.AddToLinkedControls(ucrNudMinimunSize, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrNudMaximumSize, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrChkLabel, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrSaveGraph, {rdoPairwisePlot, rdoCorrelationPlot, rdoScatterPlotMatrix}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrNudMinimunSize.SetLinkedDisplayControl(lblMinimumSize)
        ucrNudMaximumSize.SetLinkedDisplayControl(lblMaximumSize)
        ucrPnlGraphType.SetLinkedDisplayControl(grpOptions)
        ucrInputComboGeom.SetLinkedDisplayControl(lblGeom)

        ucrPnlGraphType.AddToLinkedControls(ucrSelectorFactor, {rdoScatterPlotMatrix}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrReceiverFactor, {rdoScatterPlotMatrix}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverFactor.SetLinkedDisplayControl(lblFactor)

        ucrInputComboGeom.SetParameter(New RParameter("geom", 3))
        dctGeom.Add("Tile", Chr(34) & "tile" & Chr(34))
        dctGeom.Add("Circle", Chr(34) & "circle" & Chr(34))
        dctGeom.Add("Text", Chr(34) & "text" & Chr(34))
        dctGeom.Add("Blank", Chr(34) & "blank" & Chr(34))
        ucrInputComboGeom.SetItems(dctGeom)
        ucrInputComboGeom.SetDropDownStyleAsNonEditable()
        ucrInputComboGeom.SetLinkedDisplayControl(lblGeom)

        ucrPnlGraphType.AddRadioButton(rdoNone)
        ucrPnlGraphType.AddRadioButton(rdoCorrelationPlot)
        ucrPnlGraphType.AddRadioButton(rdoPairwisePlot)
        ucrPnlGraphType.AddRadioButton(rdoScatterPlotMatrix)

        ucrPnlGraphType.AddRSyntaxContainsFunctionNamesCondition(rdoCorrelationPlot, {"ggcorr"})
        ucrPnlGraphType.AddRSyntaxContainsFunctionNamesCondition(rdoPairwisePlot, {"ggpairs"})
        ucrPnlGraphType.AddRSyntaxContainsFunctionNamesCondition(rdoScatterPlotMatrix, {"ggscatmat"})
        ucrPnlGraphType.AddRSyntaxContainsFunctionNamesCondition(rdoNone, {"ggcorr", "ggpairs", "ggscatmat"}, False)
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewcorrelationFunction As RFunction, clsNewcorrelationTestFunction As RFunction, clsNewRGGcorrGraphicsFunction As RFunction, clsNewRGraphicsFuction As RFunction, clsNewRTempFunction As RFunction, clsNewRGGscatmatrixFunction As RFunction, strColFunction As String, Optional ucrNewBaseSelector As ucrSelector = Nothing, Optional bReset As Boolean = False, Optional bTwoColumns As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        'This is meant to force selector select the current dataframe as selected in the main dialog
        ucrBaseSelector = ucrNewBaseSelector
        If ucrBaseSelector IsNot Nothing AndAlso ucrBaseSelector.strCurrentDataFrame <> "" Then
            strDataFrame = ucrBaseSelector.strCurrentDataFrame
            ucrSelectorFactor.SetDataframe(strDataFrame, False)
        End If

        clsRsyntax = clsNewRSyntax
        clsCorrelationTestFunction = clsNewcorrelationTestFunction
        clsCorrelationFunction = clsNewcorrelationFunction
        clsRGGcorrGraphicsFunction = clsNewRGGcorrGraphicsFunction
        clsRGraphicsFuction = clsNewRGraphicsFuction
        clsRTempFunction = clsNewRTempFunction
        clsRGGscatmatrixFunction = clsNewRGGscatmatrixFunction
        ucrNudMaximumSize.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudMinimunSize.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputComboGeom.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrChkLabel.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrSaveGraph.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrSaveGraph.AddAdditionalRCode(clsRGraphicsFuction, iAdditionalPairNo:=1)
        ucrSaveGraph.AddAdditionalRCode(clsRGGscatmatrixFunction, iAdditionalPairNo:=2)
        ucrPnlGraphType.SetRSyntax(clsRsyntax, bReset)
        Visibility()
        If bReset Then
            ucrSelectorFactor.Reset()
        End If

        If bTwoColumns Then
            rdoCorrelationPlot.Enabled = False
            If rdoCorrelationPlot.Checked Then
                rdoNone.Checked = True
            End If
        Else
            rdoCorrelationPlot.Enabled = True
        End If
    End Sub

    Private Sub Visibility()
        If ucrInputComboGeom.cboInput.SelectedItem = "Circle" Then
            ucrNudMinimunSize.Visible = True
            lblMinimumSize.Visible = True
            ucrNudMaximumSize.Visible = True
            lblMaximumSize.Visible = True
        Else
            ucrNudMinimunSize.Visible = False
            lblMinimumSize.Visible = False
            ucrNudMaximumSize.Visible = False
            lblMaximumSize.Visible = False
        End If
    End Sub

    Private Sub ucrInputComboGeom_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboGeom.ControlValueChanged
        Visibility()
    End Sub

    Private Sub ucrPnlGraphType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphType.ControlValueChanged
        Visibility()
        BeforeAndAfterCodes()
        If rdoNone.Checked OrElse rdoPairwisePlot.Checked Then
            grpOptions.Hide()
        Else
            grpOptions.Show()
        End If

    End Sub

    Private Sub ucrReceiverFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlValueChanged
        If Not ucrReceiverFactor.IsEmpty Then
            clsRGGscatmatrixFunction.AddParameter("color", ucrReceiverFactor.GetVariableNames(), iPosition:=2)
        Else
            clsRGGscatmatrixFunction.RemoveParameterByName("color")
        End If
    End Sub

    Public Sub BeforeAndAfterCodes()
        clsRsyntax.RemoveFromAfterCodes(clsRGGcorrGraphicsFunction)
        clsRsyntax.RemoveFromAfterCodes(clsRGraphicsFuction)
        clsRsyntax.RemoveFromAfterCodes(clsRGGscatmatrixFunction)
        If rdoCorrelationPlot.Checked AndAlso rdoCorrelationPlot.Enabled Then
            clsRsyntax.AddToAfterCodes(clsRGGcorrGraphicsFunction, iPosition:=1)
        End If
        If rdoPairwisePlot.Checked Then
            clsRsyntax.AddToAfterCodes(clsRGraphicsFuction, iPosition:=2)
        End If
        If rdoScatterPlotMatrix.Checked Then
            clsRsyntax.AddToAfterCodes(clsRGGscatmatrixFunction, iPosition:=3)
        End If
    End Sub
End Class