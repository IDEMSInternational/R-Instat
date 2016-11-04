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
Public Class dlgCompareModels
    Public lstCheckboxes As List(Of CheckBox)
    Public lstVals As List(Of String)

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
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.clsRsyntax.SetFunction("plotDist")
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistributionForCompareModels_ParameterChanged() Handles ucrDistributionForCompareModels.ParameterChanged
        distParameters()
    End Sub

    Private Sub distParameters()
        ucrBase.clsRsyntax.ClearParameters()
        ucrBase.clsRsyntax.AddParameter("dist", Chr(34) & ucrDistributionForCompareModels.clsCurrDistribution.strRName & Chr(34))

        For Each clstempparam In ucrDistributionForCompareModels.clsCurrRFunction.clsParameters
            ucrBase.clsRsyntax.AddParameter(clstempparam.Clone())
        Next
    End Sub

    Private Sub cmdAddNewDistributions_Click(sender As Object, e As EventArgs) Handles cmdAddNewDistributions.Click
        sdgAddNewDistribution.ShowDialog()
    End Sub

    Private Sub nudXlimMin_ValueChanged(sender As Object, e As EventArgs) Handles nudXlimMin.ValueChanged, nudYlimMin.ValueChanged, nudNumberofColumns.ValueChanged, nudXlimMax.ValueChanged, nudYlimMax.ValueChanged
        XLimits()
        Ylimits()
    End Sub

    Private Sub grpPlotOptions_CheckedChanged(sender As Object, e As EventArgs) Handles chkCDF.CheckedChanged, chkDensity.CheckedChanged, chkHistogram.CheckedChanged
        kindParameters()
    End Sub
    Private Sub Ylimits()
        If nudYlimMax.Text <> "" AndAlso nudYlimMin.Text <> "" Then
            ucrBase.clsRsyntax.AddParameter("ylim", "c(" & nudYlimMin.Text & "," & nudYlimMax.Text & ")")
        Else
            ucrBase.clsRsyntax.RemoveParameter("ylim")
        End If
    End Sub
    Private Sub XLimits()
        If nudXlimMax.Text <> "" AndAlso nudXlimMin.Text <> "" Then
            ucrBase.clsRsyntax.AddParameter("xlim", "c(" & nudXlimMin.Text & "," & nudXlimMax.Text & ")")
        Else
            ucrBase.clsRsyntax.RemoveParameter("xlim")
        End If
    End Sub

    Private Sub kindParameters()
        lstCheckboxes.AddRange({chkCDF, chkDensity, chkqq, chkHistogram})
        lstVals.AddRange({"cdf", "density", "qq", "histogram"})
        Dim ival As Integer
        Dim icheckedVal As Integer = lstCheckboxes(ival).Checked
        Dim strTemp As String = ""

        If lstCheckboxes(0).Checked Then
            ucrBase.clsRsyntax.AddParameter("kind", lstVals(0))
        ElseIf lstCheckboxes(1).Checked Then
            ucrBase.clsRsyntax.AddParameter("kind", lstVals(1))
        ElseIf lstCheckboxes(2).Checked = True Then
            ucrBase.clsRsyntax.AddParameter("kind", lstVals(2))
        ElseIf lstCheckboxes(3).Checked = True Then
            ucrBase.clsRsyntax.AddParameter("kind", lstVals(3))
        ElseIf icheckedVal > 1 Then
            strTemp = "c" & "("
            For icheckedVal = 0 To lstCheckboxes.Count - 1
                If icheckedVal > 1 Then
                    strTemp = strTemp & ","
                End If
            Next

            strTemp = strTemp & ")"
        End If
    End Sub

End Class