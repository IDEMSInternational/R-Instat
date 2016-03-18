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
Public Class dlgCumulativeDistribution
    Private clsRggplotFunction As New RFunction
    Private clsRgeom_CumDistFunction As New RFunction
    Private clsRaesFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgCumulativeDistribution_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetOperation("+")
        clsRggplotFunction.SetRCommand("ggplot")
        clsRaesFunction.SetRCommand("aes")
        clsRggplotFunction.AddParameter("mapping", clsRFunctionParameter:=clsRaesFunction)
        ucrBase.clsRsyntax.SetOperatorParameter(True, clsRFunc:=clsRggplotFunction)
        clsRgeom_CumDistFunction.SetRCommand("stat_ecdf")
        ucrBase.clsRsyntax.SetOperatorParameter(False, clsRFunc:=clsRgeom_CumDistFunction)

        ucrVariateReceiver.Selector = ucrCumDistSelector
        ucrFactorReceiver.Selector = ucrCumDistSelector
        ucrFactorReceiver.SetDataType("factor")
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.iHelpTopicID = 133

        autoTranslate(Me)
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        'set defaults here 
        ucrCumDistSelector.Reset()
        ucrCumDistSelector.Focus()
        chkCountsOnYAxis.Checked = False
        chkExceedancePlots.Checked = False
        chkIncludePoints.Checked = False
        ucrVariateReceiver.SetMeAsReceiver()
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        'TODO what enables ok
        If Not ucrVariateReceiver.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub ucrCumDistSelector_DataFrameChanged() Handles ucrCumDistSelector.DataFrameChanged
        clsRggplotFunction.AddParameter("data", clsRFunctionParameter:=ucrCumDistSelector.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub

    Private Sub ucrVariateReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrVariateReceiver.SelectionChanged
        If Not ucrVariateReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("x", ucrVariateReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("x")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles ucrFactorReceiver.SelectionChanged
        If Not ucrFactorReceiver.IsEmpty Then
            clsRaesFunction.AddParameter("colour", ucrFactorReceiver.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName("colour")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub cmdLineOptions_Click(sender As Object, e As EventArgs) Handles cmdLineOptions.Click
        sdgCumDistLineOptions.ShowDialog()
    End Sub

    Private Sub cmdPlotOptions_Click(sender As Object, e As EventArgs) Handles cmdPlotOptions.Click
        sdgCumDistPlotOptions.ShowDialog()
    End Sub

    Private Sub cmdThemeOptions_Click(sender As Object, e As EventArgs) 
        sdgThemeOptions.ShowDialog()
    End Sub
End Class