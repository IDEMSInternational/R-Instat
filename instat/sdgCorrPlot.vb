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

Imports instat
Imports instat.Translations
Public Class sdgCorrPlot
    Public clsRGGscatmatrix, clsRGGcorrGraphicsFunction, clsCorrelationFunction, clsRGraphicsFuction As New RFunction
    Public bFirstLoad As Boolean = True
    Private bControlsInitialised As Boolean = False
    Public strDataFrame As String
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

        ucrPnlGraphType.AddRadioButton(rdoNone)
        ucrPnlGraphType.AddRadioButton(rdoCorrelationPlot)
        ucrPnlGraphType.AddRadioButton(rdoPairwisePlot)
        ucrPnlGraphType.AddRadioButton(rdoScatterPlotMatrix)

        ucrNudAlphaCorr.SetParameter(New RParameter("label_alpha", 3))
        ucrNudAlphaCorr.SetMinMax(0, 1)
        ucrNudAlphaCorr.DecimalPlaces = 2
        ucrNudAlphaCorr.Increment = 0.01

        ucrNudAlpha.SetMinMax(0, 1)
        ucrNudAlpha.DecimalPlaces = 2
        ucrNudAlpha.Increment = 0.01

        ucrChkLabel.SetParameter(New RParameter("label", 4))
        ucrChkLabel.SetText("label")

        ucrSaveGraph.SetPrefix("CorGraph")
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetCheckBoxText("Save Graph:")
        ucrSaveGraph.SetIsComboBox()

        ucrPnlGraphType.AddRSyntaxContainsFunctionNamesCondition(rdoCorrelationPlot, {"ggcorr"})
        ucrPnlGraphType.AddRSyntaxContainsFunctionNamesCondition(rdoNone, {"ggcorr"}, False)
        ucrPnlGraphType.AddRSyntaxContainsFunctionNamesCondition(rdoPairwisePlot, {"ggcorr"}, False)
        ucrPnlGraphType.AddRSyntaxContainsFunctionNamesCondition(rdoScatterPlotMatrix, {"ggcorr"}, False)

        'rdoNone.Checked = True
        ucrChkColor.SetParameter(New RParameter("color"))
        ucrChkColor.SetText("colour By Factor")

        Dim dctGeom As New Dictionary(Of String, String)
        ucrInputComboGeom.SetParameter(New RParameter("geom", 3))
        dctGeom.Add("tile", Chr(34) & "tile" & Chr(34))
        dctGeom.Add("circle", Chr(34) & "circle" & Chr(34))
        dctGeom.Add("text", Chr(34) & "text" & Chr(34))
        dctGeom.Add("blank", Chr(34) & "blank" & Chr(34))
        ucrInputComboGeom.SetItems(dctGeom)
        ucrInputComboGeom.SetRDefault(Chr(34) & "tile" & Chr(34))
        ucrInputComboGeom.SetDropDownStyleAsNonEditable()
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsNewcorrelationFunction As RFunction, clsNewRGGcorrGraphicsFunction As RFunction, clsNewRGGscatmatrix As RFunction, clsNewRGraphicsFuction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsCorrelationFunction = clsNewcorrelationFunction
        clsRGGcorrGraphicsFunction = clsNewRGGcorrGraphicsFunction
        'settingRcode for subdialog
        ucrNudMaximumSize.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrNudMinimunSize.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrInputComboGeom.SetRCode(clsRGGcorrGraphicsFunction, bReset)
        ucrChkLabel.SetRCode(clsNewRGGcorrGraphicsFunction, bReset)
        ucrSaveGraph.SetRCode(clsNewRGGcorrGraphicsFunction, bReset)

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
            'ucrSaveGraph.chkSaveGraph.Checked = False
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
            ColourbyFactor()
        Else
            tbScatterplotMatrix.Enabled = False
        End If
        dlgCorrelation.TestOKEnabled()
        CorrOptions()

        'If rdoCorrelationPlot.Checked Then
        'clsRsyntax.AddToAfterCodes(clsRGGcorrGraphicsFunction, iPosition:=0)
        'Else
        'clsRsyntax.RemoveFromAfterCodes(clsRGGcorrGraphicsFunction)
        'End If
    End Sub

    'Public Sub CorrelationMatrix()
    '    If dlgCorrelation.rdoMultipleColumns.Checked AndAlso dlgCorrelation.ucrChkCorrelationMatrix.Checked AndAlso Not rdoPairwisePlot.Checked AndAlso Not rdoCorrelationPlot.Checked AndAlso Not rdoScatterPlotMatrix.Checked Then
    '        If dlgCorrelation.ucrSaveModel.chkSaveModel.Checked Then
    '            dlgCorrelation.ucrBase.clsRsyntax.iCallType = 0
    '        Else
    '            dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
    '        End If
    '        dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(dlgCorrelation.clsCorrelationFunction)
    '    End If
    '    dlgCorrelation.TestOKEnabled()
    'End Sub

    Public Sub GGPairs()
        dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
        dlgCorrelation.TestOKEnabled()
    End Sub

    'Public Sub GGscatmatrix()
    '    'dlgCorrelation.TempData()

    '    dlgCorrelation.ucrBase.clsRsyntax.iCallType = 2
    '    dlgCorrelation.ucrBase.clsRsyntax.SetBaseRFunction(clsRGGscatmatrix)
    '    dlgCorrelation.TestOKEnabled()
    'End Sub

    Public Sub SetDefaults()
        ucrSaveGraph.SetDataFrameSelector(dlgCorrelation.ucrSelectorCorrelation.ucrAvailableDataFrames)
        dlgCorrelation.ucrChkCorrelationMatrix.Checked = True
        rdoNone.Checked = True
        tbSaveGraphs.Visible = False
        ucrSelectFactor.Reset()
        ucrReceiveFactor.Selector = ucrSelectFactor
        ucrReceiveFactor.SetDataType("factor")
        ucrSelectFactor.Reset()
        CorrOptions()
    End Sub

    Public Sub CorrOptions()
        If dlgCorrelation.ucrChkCorrelationMatrix.Checked Then
            ' CorrelationMatrix()
        End If
        If rdoPairwisePlot.Checked Then
            GGPairs()
        End If
        If rdoScatterPlotMatrix.Checked Then
            'GGscatmatrix()
        End If
        If rdoCorrelationPlot.Checked Then
            'GGcorr()
        End If
    End Sub

    Private Sub chkColor_CheckedChanged(sender As Object, e As EventArgs)
        ColourbyFactor()
    End Sub

    Public Sub ColourbyFactor()
        'If chkColour.Checked = True Then
        ucrSelectFactor.Visible = True
        ucrReceiveFactor.Visible = True
        lblFactorVariable.Visible = True
        clsRGGscatmatrix.AddParameter("color", ucrReceiveFactor.GetVariableNames)
        ' ElseIf chkColour.Checked = False Then
        clsRGGscatmatrix.AddParameter("color", "NULL")
        ucrSelectFactor.Visible = False
        ucrReceiveFactor.Visible = False
        lblFactorVariable.Visible = False
        ' Else
        clsRGGscatmatrix.RemoveParameterByName("color")
        ' End If
    End Sub

    Private Sub ucrSaveGraph_GraphNameChanged()
        dlgCorrelation.TestOKEnabled()
    End Sub

    Private Sub ucrReceiveFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiveFactor.SelectionChanged
        ColourbyFactor()
    End Sub

    Public Sub SetDataFrame(strNewDataFrame As String)
        strDataFrame = strNewDataFrame
        ucrSelectFactor.SetDataframe(strDataFrame, False)
    End Sub

End Class