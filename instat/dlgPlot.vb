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
Public Class dlgPlot
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_plotFunction As New RFunction
    Private clsRaesFunction As New RFunction

    Public bFirstLoad As Boolean = True

    Private Sub dlgPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        ucrBase.clsRsyntax.iCallType = 0
        autoTranslate(Me)
        ucrReceiverY.Selector = ucrPlotSelector
        ucrReceiverX.Selector = ucrPlotSelector
        ucrFactorOptionalReceiver.Selector = ucrPlotSelector

        If bFirstLoad Then
            bFirstLoad = False
            'SetDefaults
            SetDefaults()
        Else
            'reopendialog
        End If
        TeskOkEnabled()
    End Sub

    Private Sub SetDefaults()
        chkPoints.Checked = False
        chkLines.Checked = False
        ucrPlotSelector.Focus()
        ucrPlotSelector.Reset()
        ucrReceiverY.SetMeAsReceiver()
        TeskOkEnabled()
    End Sub
    Private Sub TeskOkEnabled()
        If ucrReceiverX.IsEmpty() = True Then
            ucrBase.OKEnabled(False)
            ucrBase.clsRsyntax.RemoveParameter("x")
        ElseIf ucrReceiverY.IsEmpty() = True Then
            ucrBase.clsRsyntax.RemoveParameter("y")
            ucrBase.OKEnabled(False)
        ElseIf Not (chkLines.Checked = True Or chkPoints.Checked = True) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub ucrReceiverY_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverY.SelectionChanged
        clsRaesFunction.AddParameter("y", ucrReceiverY.GetVariableNames(False))
        TeskOkEnabled()
    End Sub

    Private Sub ucrReceiverX_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverX.SelectionChanged
        clsRaesFunction.AddParameter("x", ucrReceiverX.GetVariableNames(False))
        TeskOkEnabled()
    End Sub

    Private Sub ucrPlotSelector_DataFrameChanged() Handles ucrPlotSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrPlotSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
    Private Sub ucrFactorOptionalReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorOptionalReceiver.SelectionChanged
        clsRaesFunction.AddParameter("fill", ucrFactorOptionalReceiver.GetVariableNames(False))
    End Sub

    Private Sub chkPoints_CheckedChanged(sender As Object, e As EventArgs) Handles chkPoints.CheckedChanged
        If chkPoints.Checked = True Then
            clsRgeom_plotFunction.SetRCommand("geom_point")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_plotFunction)
        Else
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
        End If
        TeskOkEnabled()
    End Sub

    Private Sub chkLines_CheckedChanged(sender As Object, e As EventArgs) Handles chkLines.CheckedChanged
        If chkLines.Checked = True Then
            clsRgeom_plotFunction.SetRCommand("geom_line")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_plotFunction)
        Else
            ucrBase.clsRsyntax.RemoveParameter("geom_line")
        End If
        TeskOkEnabled()
    End Sub

    Private Sub grpPointsAndLines_CheckedChanged(sender As Object, e As EventArgs) Handles chkLines.CheckedChanged, chkPoints.CheckedChanged
        Dim clsTempOp As New ROperator
        Dim clsTempRFunc As New RFunction
        clsTempOp.SetOperation("+")

        If chkPoints.Checked = True AndAlso chkLines.Checked = True Then
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_line")
            ucrBase.clsRsyntax.RemoveOperatorParameter("geom_point")
            clsTempOp.SetParameter(True, clsRFunc:=clsRggplotFunction)

            clsRgeom_plotFunction.SetRCommand("geom_point")
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_plotFunction)


            clsTempOp.SetParameter(False, clsRFunc:=clsRgeom_plotFunction)
            clsTempRFunc.SetRCommand("geom_line")
            ucrBase.clsRsyntax.SetOperatorParameter(True, clsOp:=clsTempOp)
            ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsTempRFunc)
        End If
    End Sub
    Private Sub cmdOptions_Click(sender As Object, e As EventArgs) Handles cmdOptions.Click
        sdgPlots.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class