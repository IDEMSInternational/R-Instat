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
    Public bFirstLoad As Boolean = True
    Private bControlsInitialised As Boolean = False
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

        ucrNudAlphaCorr.SetParameter(New RParameter("label_alpha", 3))
        ucrNudAlphaCorr.SetMinMax(0, 1)
        ucrNudAlphaCorr.DecimalPlaces = 2
        ucrNudAlphaCorr.Increment = 0.01

        ucrNudAlpha.SetParameter(New RParameter("alpha"))
        ucrNudAlpha.SetMinMax(0, 1)
        ucrNudAlpha.DecimalPlaces = 2
        ucrNudAlpha.Increment = 0.01

        ucrChkColor.SetParameter(New RParameter("color"))
        ucrChkColor.SetText("colour By Factor")

        ucrChkLabel.SetParameter(New RParameter("label", 4))
        ucrChkLabel.SetText("label")

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

        Dim dctGeom As New Dictionary(Of String, String)
        ucrInputComboGeom.SetParameter(New RParameter("geom", 3))
        dctGeom.Add("tile", Chr(34) & "tile" & Chr(34))
        dctGeom.Add("circle", Chr(34) & "circle" & Chr(34))
        dctGeom.Add("text", Chr(34) & "text" & Chr(34))
        dctGeom.Add("blank", Chr(34) & "blank" & Chr(34))
        ucrInputComboGeom.SetItems(dctGeom)
        ucrInputComboGeom.SetRDefault(Chr(34) & "tile" & Chr(34))
        ucrInputComboGeom.SetDropDownStyleAsNonEditable()

        ucrPnlGraphType.AddRadioButton(rdoNone)
        ucrPnlGraphType.AddRadioButton(rdoCorrelationPlot)
        ucrPnlGraphType.AddRadioButton(rdoPairwisePlot)
        ucrPnlGraphType.AddRadioButton(rdoScatterPlotMatrix)

        ucrPnlGraphType.AddFunctionNamesCondition(rdoCorrelationPlot, "ggcorr")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoScatterPlotMatrix, "ggpairs")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoScatterPlotMatrix, "ggscatmat")
        ucrPnlGraphType.AddFunctionNamesCondition(rdoNone, "")

    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewcorrelationFunction As RFunction, clsNewRGGcorrGraphicsFunction As RFunction, clsNewRGraphicsFuction As RFunction, clsNewRTempFunction As RFunction, clsNewRGGscatmatrixFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRsyntax = clsNewRSyntax
        clsCorrelationFunction = clsNewcorrelationFunction
        clsRGGcorrGraphicsFunction = clsNewRGGcorrGraphicsFunction
        clsRGraphicsFuction = clsNewRGraphicsFuction
        clsRTempFunction = clsNewRTempFunction
        clsRGGscatmatrixFunction = clsNewRGGscatmatrixFunction

        'settingRcode for subdialog
        ucrNudMaximumSize.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrNudMinimunSize.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrInputComboGeom.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrChkLabel.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrSaveGraph.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrChkColor.SetRCode(clsRGGscatmatrixFunction, bReset)
        ucrPnlGraphType.SetRCode(clsRGGcorrGraphicsFunction, bReset)

        clsCorrelationFunction.iCallType = 2
        ucrPnlGraphType.SetRSyntax(clsRsyntax, bReset)
        If bReset Then
            tbSaveGraphs.SelectedIndex = 0
        End If
    End Sub

    Private Sub ucrChkLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabel.ControlValueChanged
        If ucrChkLabel.Checked Then
            clsRGGcorrGraphicsFunction.AddParameter("label", "TRUE")
        Else
            clsRGGcorrGraphicsFunction.AddParameter("label", "FALSE")
        End If
    End Sub

    Private Sub ucrInputComboGeom_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputComboGeom.ControlValueChanged
        If ucrInputComboGeom.cboInput.SelectedItem = "circle" Then
            ucrNudMinimunSize.Visible = True
            lblMinimumSize.Visible = True
            ucrNudMaximumSize.Visible = True
            lblMaximumSize.Visible = True
        ElseIf ucrInputComboGeom.cboInput.SelectedItem <> "circle" Then
            ucrNudMinimunSize.Visible = False
            lblMinimumSize.Visible = False
            ucrNudMaximumSize.Visible = False
            lblMaximumSize.Visible = False
        End If
    End Sub

    Private Sub ucrPnlGraphType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlGraphType.ControlValueChanged
        If ((dlgCorrelation.ucrChkCorrelationMatrix.Checked AndAlso Not rdoPairwisePlot.Checked AndAlso Not rdoCorrelationPlot.Checked AndAlso Not rdoScatterPlotMatrix.Checked) OrElse (Not dlgCorrelation.ucrChkCorrelationMatrix.Checked AndAlso rdoNone.Checked)) Then
            ucrSaveGraph.Visible = False
            tbSaveGraphs.Visible = False
        Else
            ucrSaveGraph.Visible = True
            tbSaveGraphs.Visible = True
        End If

        If rdoPairwisePlot.Checked Then
            tbPairwisePlot.Enabled = True
            tbSaveGraphs.SelectTab(tbPairwisePlot)
            ucrSaveGraph.Visible = True
        Else
            tbPairwisePlot.Enabled = False
        End If
        If rdoCorrelationPlot.Checked Then
            tbCorrelationPlot.Enabled = True
            tbSaveGraphs.SelectTab(tbCorrelationPlot)
            ucrSaveGraph.Visible = True
        Else
            tbCorrelationPlot.Enabled = False
        End If

        If rdoScatterPlotMatrix.Checked Then
            tbScatterplotMatrix.Enabled = True
            tbSaveGraphs.SelectTab(tbScatterplotMatrix)
            ucrSaveGraph.Visible = True
            ucrReceiveFactor.Focus()
        Else
            tbScatterplotMatrix.Enabled = False
        End If

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
            clsRsyntax.AddToAfterCodes(clsRGGscatmatrixFunction, iPosition:=1)
            clsRsyntax.RemoveFromAfterCodes(clsRGGcorrGraphicsFunction)
        ElseIf rdoNone.Checked Then
            clsRsyntax.RemoveFromAfterCodes(clsRGGcorrGraphicsFunction)
            clsRsyntax.RemoveFromAfterCodes(clsRGraphicsFuction)
            clsRsyntax.RemoveFromAfterCodes(clsRGGscatmatrixFunction)
        End If
    End Sub
End Class