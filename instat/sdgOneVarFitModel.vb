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

Public Class sdgOneVarFitModel
    Public clsRConvert As New RFunction
    Public clsRSyntax As New RSyntax
    Private WithEvents ucrDists As ucrDistributions
    Public bfirstload As Boolean = True


    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        clsRSyntax.AddParameter("optim.method")
        clsRSyntax.AddParameter("method")
    End Sub


    Public Sub SetDefaults()
        rdoMle.Enabled = True
        rdoMme.Enabled = True
        rdoQme.Enabled = False
        rdoMge.Enabled = True
        rdoDefault.Enabled = True
        rdoNelderMead.Enabled = True
        rdoBFGS.Enabled = True
        rdoCG.Enabled = True
        rdoSANN.Enabled = True
        rdoDefault.Checked = True
        rdoMle.Checked = True
        'ucrBase.ihelptopicID = 
    End Sub

    Public Sub SetMyRSyntax(clsRNewSyntax As RSyntax)
        clsRSyntax = clsRNewSyntax
    End Sub

    Private Sub rdoOptimMethod_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDefault.CheckedChanged, rdoNelderMead.CheckedChanged, rdoBFGS.CheckedChanged, rdoCG.CheckedChanged, rdoSANN.CheckedChanged

        If rdoDefault.Checked Then
            clsRSyntax.AddParameter("optim.method", Chr(34) & "default" & Chr(34))
        ElseIf rdoNelderMead.Checked Then
            clsRSyntax.AddParameter("optim.method", Chr(34) & "Nelder-Mead" & Chr(34))
        ElseIf rdoBFGS.Checked Then
            clsRSyntax.AddParameter("optim.method", Chr(34) & "BFGS" & Chr(34))
        ElseIf rdoCG.Checked Then
            clsRSyntax.AddParameter("optim.method", Chr(34) & "CG" & Chr(34))
        ElseIf rdoSANN.Checked Then
            clsRSyntax.AddParameter("optim.method", Chr(34) & "SANN" & Chr(34))
        End If
    End Sub


    Private Sub rdoEstimators_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMle.CheckedChanged, rdoMme.CheckedChanged, rdoQme.CheckedChanged, rdoMge.CheckedChanged
        If rdoMle.Checked Then
            clsRSyntax.AddParameter("method", Chr(34) & "mle" & Chr(34))
        ElseIf rdoMme.Checked Then
            clsRSyntax.AddParameter("method", Chr(34) & "mme" & Chr(34))
        ElseIf rdoQme.Checked Then
            clsRSyntax.AddParameter("method", Chr(34) & "qme" & Chr(34))
            'TODO needs a probs argument
        ElseIf rdoMge.Checked Then
            clsRSyntax.AddParameter("method", Chr(34) & "mge" & Chr(34))
        End If
    End Sub

    Public Sub SetDistribution(ucrNewDists As ucrDistributions)
        ucrDists = ucrNewDists
        SetPlotOptions()
    End Sub

    Private Sub ucrDists_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrDists.cboDistributionsIndexChanged
        SetPlotOptions()
    End Sub

    Private Sub SetPlotOptions()
        If ucrDists.clsCurrDistribution IsNot Nothing AndAlso Not ucrDists.clsCurrDistribution.bIsContinuous Then
            rdoMge.Enabled = False
            If rdoMge.Checked Then
                rdoMle.Checked = True
            End If
        Else
            rdoMge.Enabled = True
        End If
    End Sub

End Class