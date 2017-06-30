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

Imports instat.Translations
Public Class sdgCorrPlot
    Public clsRGGscatmatrixFunction, clsRGGcorrGraphicsFunction, clsCorrelationFunction, clsRGraphicsFuction, clsRTempFunction As New RFunction
    Private clsColFunction As String
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Private clsRsyntax As RSyntax

    Private Sub sdgCorrPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrNudMaximumSize.SetParameter(New RParameter("max_size", 1))
        ucrNudMaximumSize.SetMinMax(1, 10)
        ucrNudMinimunSize.SetParameter(New RParameter("min_size", 2))
        ucrNudMinimunSize.SetMinMax(1, 5)
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 0
        ucrChkLabel.SetParameter(New RParameter("label", 4))
        ucrChkLabel.SetText("label")
        ucrNudAlphaCorr.SetMinMax(0, 1)
        ucrNudAlphaCorr.Increment = 0.01

        ucrSaveGraph.SetPrefix("CorGraph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetDataFrameSelector(dlgCorrelation.ucrSelectorCorrelation.ucrAvailableDataFrames)
        ucrSaveGraph.SetCheckBoxText("Save Graph:")
        ucrSaveGraph.SetIsComboBox()

        ucrReceiveFactor.SetParameter(New RParameter("data", 1))
        ucrReceiveFactor.SetParameterIsRFunction()
        ucrReceiveFactor.Selector = ucrSelectFactor
        ucrReceiveFactor.strSelectorHeading = "Numerics"
        ucrReceiveFactor.SetDataType("factor")
        ucrReceiveFactor.SetMeAsReceiver()

        ucrSelectFactor.Reset()
        ucrReceiveFactor.Selector = ucrSelectFactor
        ucrReceiveFactor.SetDataType("factor")
        ucrSelectFactor.Reset()

        ucrPnlGraphType.AddToLinkedControls(ucrInputComboGeom, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrNudMinimunSize, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrNudMaximumSize, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrNudAlphaCorr, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrChkLabel, {rdoCorrelationPlot}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputComboGeom.SetLinkedDisplayControl(lblgeom)
        ucrNudMinimunSize.SetLinkedDisplayControl(lblMinimumSize)
        ucrNudMaximumSize.SetLinkedDisplayControl(lblMaximumSize)
        ucrNudAlphaCorr.SetLinkedDisplayControl(lblLabelAlpha)
        ucrPnlGraphType.SetLinkedDisplayControl(grpOptions)

        ucrPnlGraphType.AddToLinkedControls(ucrSelectFactor, {rdoScatterPlotMatrix}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrReceiveFactor, {rdoScatterPlotMatrix}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrChkColor, {rdoScatterPlotMatrix}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlGraphType.AddToLinkedControls(ucrNudAlpha, {rdoScatterPlotMatrix}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiveFactor.SetLinkedDisplayControl(lblFactorVariable)
        ucrNudAlpha.SetLinkedDisplayControl(lblAlpha)

        Dim dctGeom As New Dictionary(Of String, String)
        ucrInputComboGeom.SetParameter(New RParameter("geom", 3))
        dctGeom.Add("Tile", Chr(34) & "tile" & Chr(34))
        dctGeom.Add("Circle", Chr(34) & "circle" & Chr(34))
        dctGeom.Add("Text", Chr(34) & "text" & Chr(34))
        dctGeom.Add("Blank", Chr(34) & "blank" & Chr(34))
        ucrInputComboGeom.SetItems(dctGeom)
        ucrInputComboGeom.SetRDefault(Chr(34) & "tile" & Chr(34))
        ucrInputComboGeom.SetDropDownStyleAsNonEditable()

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

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewcorrelationFunction As RFunction, clsNewRGGcorrGraphicsFunction As RFunction, clsNewRGraphicsFuction As RFunction, clsNewRTempFunction As RFunction, clsNewRGGscatmatrixFunction As RFunction, clsNewColFunction As String, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRsyntax = clsNewRSyntax
        clsCorrelationFunction = clsNewcorrelationFunction
        clsRGGcorrGraphicsFunction = clsNewRGGcorrGraphicsFunction
        clsRGraphicsFuction = clsNewRGraphicsFuction
        clsRTempFunction = clsNewRTempFunction
        clsColFunction = clsNewColFunction
        clsRGGscatmatrixFunction = clsNewRGGscatmatrixFunction

        ucrNudMaximumSize.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrNudMinimunSize.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrInputComboGeom.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrChkLabel.SetRSyntax(clsRsyntax, bReset)
        ucrSaveGraph.SetRCode(clsRGGcorrGraphicsFunction, bReset, bCloneIfNeeded:=True)
        ucrChkColor.SetRSyntax(clsRsyntax, bReset)
        ucrPnlGraphType.SetRSyntax(clsRsyntax, bReset)
        clsRGraphicsFuction.AddParameter("columns", clsColFunction)
        clsCorrelationFunction.iCallType = 2
        Visibility()
    End Sub

    Private Sub ucrChkLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabel.ControlValueChanged
        If ucrChkLabel.Checked Then
            clsRGGcorrGraphicsFunction.AddParameter("label", "TRUE")
        Else
            clsRGGcorrGraphicsFunction.AddParameter("label", "FALSE")
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
        If rdoCorrelationPlot.Checked Then
            dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
            clsRGGcorrGraphicsFunction.iCallType = 3
            clsRsyntax.AddToAfterCodes(clsRGGcorrGraphicsFunction, iPosition:=1)
            clsRsyntax.RemoveFromAfterCodes(clsRGraphicsFuction)
            clsRsyntax.RemoveFromAfterCodes(clsRGGscatmatrixFunction)
        ElseIf rdoPairwisePlot.Checked Then
            dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
            clsRGraphicsFuction.iCallType = 3
            clsRsyntax.AddToAfterCodes(clsRGraphicsFuction, iPosition:=2)
            clsRsyntax.RemoveFromAfterCodes(clsRGGcorrGraphicsFunction)
        ElseIf rdoScatterPlotMatrix.Checked Then
            dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
            clsRGGscatmatrixFunction.iCallType = 3
            clsRsyntax.AddToAfterCodes(clsRGGscatmatrixFunction, iPosition:=3)
            clsRsyntax.RemoveFromAfterCodes(clsRGGcorrGraphicsFunction)
        ElseIf rdoNone.Checked Then
            clsRsyntax.RemoveFromAfterCodes(clsRGGcorrGraphicsFunction)
            clsRsyntax.RemoveFromAfterCodes(clsRGraphicsFuction)
            clsRsyntax.RemoveFromAfterCodes(clsRGGscatmatrixFunction)
        End If
        If rdoCorrelationPlot.Checked Then
            Visibility()
        End If
    End Sub
End Class