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
Imports RDotNet
Public Class dlgCompareModels
    Public strOutput As String
    Public clsPlotDist As New RFunction
    Public bFirstLoad As Boolean = True
    Private Sub dlgCompareModels_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub
    Private Sub InitialiseDialog()
        clsPlotDist.SetRCommand("plotDist")
        ucrBase.clsRsyntax.SetFunction("grid.arrange")
    End Sub

    Private Sub TestOKEnabled()
        If nudXlimMax.Value > nudXlimMin.Value AndAlso nudYlimMax.Value > nudYlimMin.Value Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub SetDefaults()
        rdoSingle.Checked = True
        rdoDensity.Checked = True
        nudNumberofColumns.Enabled = False
        lblNumberofColumns.Enabled = False
        rdoCombine.Enabled = False
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistributionForCompareModels_ParameterChanged() Handles ucrDistributionForCompareModels.ControlContentsChanged
        distParameters()
    End Sub

    Private Sub distParameters()
        XLimits()
        Ylimits()
        kindParameters()
        clsPlotDist.AddParameter("dist", Chr(34) & ucrDistributionForCompareModels.clsCurrDistribution.strRName & Chr(34))
        For Each clstempparam In ucrDistributionForCompareModels.clsCurrRFunction.clsParameters
            clsPlotDist.AddParameter(clstempparam.Clone())
        Next

    End Sub

    Private Sub cmdAddNewDistributions_Click(sender As Object, e As EventArgs) Handles cmdAddNewDistributions.Click
        sdgAddNewDistribution.ShowDialog()
    End Sub

    Private Sub nudXlimMin_TextChanged(sender As Object, e As EventArgs) Handles nudXlimMin.TextChanged, nudYlimMin.TextChanged, nudNumberofColumns.TextChanged, nudXlimMax.TextChanged, nudYlimMax.TextChanged
        distParameters()
        TestOKEnabled()
    End Sub

    Private Sub grpPlotOptions_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCDF.CheckedChanged, rdoDensity.CheckedChanged, rdoHistogram.CheckedChanged, rdoqq.CheckedChanged
        distParameters()
    End Sub

    Private Sub Ylimits()
        If nudYlimMax.Value > nudYlimMin.Value Then
            If nudYlimMax.Text <> "" AndAlso nudYlimMin.Text <> "" Then
                clsPlotDist.AddParameter("ylim", "c(" & nudYlimMin.Value & "," & nudYlimMax.Value & ")")
            Else
                clsPlotDist.RemoveParameterByName("ylim")
            End If
            clsPlotDist.RemoveParameterByName("ylim")
        End If
    End Sub
    Private Sub XLimits()
        If nudXlimMax.Value > nudXlimMin.Value Then
            If nudXlimMax.Text <> "" AndAlso nudXlimMin.Text <> "" Then
                clsPlotDist.AddParameter("xlim", "c(" & nudXlimMin.Value & "," & nudXlimMax.Value & ")")

            Else
                clsPlotDist.RemoveParameterByName("xlim")
            End If
        Else
            clsPlotDist.RemoveParameterByName("xlim")
        End If

    End Sub

    Private Sub kindParameters()
        If rdoqq.Checked Then
            clsPlotDist.AddParameter("kind", Chr(34) & "qq" & Chr(34))
        ElseIf rdoHistogram.Checked Then
            clsPlotDist.AddParameter("kind", Chr(34) & "histogram" & Chr(34))
        ElseIf rdoCDF.Checked Then
            clsPlotDist.AddParameter("kind", Chr(34) & "cdf" & Chr(34))
        Else
            clsPlotDist.AddParameter("kind", Chr(34) & "density" & Chr(34))
        End If

    End Sub

    Private Sub plotgraphspar()
        If rdoSingle.Checked Then
            cmdAddNewDistributions.Enabled = False
            ucrBase.clsRsyntax.AddParameter("x", clsPlotDist.ToScript)
            ucrBase.clsRsyntax.AddParameter("ncol", 1)
        ElseIf rdoCombine.Checked Then
            cmdAddNewDistributions.Enabled = True
            nudNumberofColumns.Enabled = True
            lblNumberofColumns.Enabled = True
        End If
    End Sub
    Private Sub grpPlotGraphs_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCombine.CheckedChanged, rdoSingle.CheckedChanged
        plotgraphspar()
    End Sub
End Class