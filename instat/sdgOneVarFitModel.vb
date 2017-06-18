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
    Public clsROneVarFitModel As New RFunction
    Private WithEvents ucrDists As ucrDistributions
    Public bfirstload As Boolean = True

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseDialog()
        clsROneVarFitModel.AddParameter("optim.method")
        clsROneVarFitModel.AddParameter("method")
    End Sub

    Public Sub SetDefaults()
        rdoQme.Enabled = False
        rdoDefault.Checked = True
        rdoMle.Checked = True
        'ucrBase.ihelptopicID = 
    End Sub

    Public Sub SetMyRFunction(clsRNewOneVarFitModel As RFunction)
        clsROneVarFitModel = clsRNewOneVarFitModel
    End Sub

    Private Sub rdoOptimMethod_CheckedChanged(sender As Object, e As EventArgs) Handles rdoDefault.CheckedChanged, rdoNelderMead.CheckedChanged, rdoBFGS.CheckedChanged, rdoCG.CheckedChanged, rdoSANN.CheckedChanged
        OptimisationMethod()
    End Sub

    Public Sub rdoEstimators_CheckedChanged(sender As Object, e As EventArgs) Handles rdoMle.CheckedChanged, rdoMme.CheckedChanged, rdoQme.CheckedChanged, rdoMge.CheckedChanged
        Estimators()
    End Sub

    Public Sub Estimators()
        If dlgOneVarFitModel.rdoGeneralCase.Checked Then
            If rdoMle.Checked Then
                clsROneVarFitModel.AddParameter("method", Chr(34) & "mle" & Chr(34))
            ElseIf rdoMme.Checked Then
                clsROneVarFitModel.AddParameter("method", Chr(34) & "mme" & Chr(34))
            ElseIf rdoQme.Checked Then
                clsROneVarFitModel.AddParameter("method", Chr(34) & "qme" & Chr(34))
                'TODO needs a probs argument
            ElseIf rdoMge.Checked Then
                clsROneVarFitModel.AddParameter("method", Chr(34) & "mge" & Chr(34))
            End If
        Else
            clsROneVarFitModel.RemoveParameterByName("method")
        End If
    End Sub

    Public Sub OptimisationMethod()
        If dlgOneVarFitModel.rdoGeneralCase.Checked Then
            If rdoDefault.Checked Then
                clsROneVarFitModel.AddParameter("optim.method", Chr(34) & "default" & Chr(34))
            ElseIf rdoNelderMead.Checked Then
                clsROneVarFitModel.AddParameter("optim.method", Chr(34) & "Nelder-Mead" & Chr(34))
            ElseIf rdoBFGS.Checked Then
                clsROneVarFitModel.AddParameter("optim.method", Chr(34) & "BFGS" & Chr(34))
            ElseIf rdoCG.Checked Then
                clsROneVarFitModel.AddParameter("optim.method", Chr(34) & "CG" & Chr(34))
            ElseIf rdoSANN.Checked Then
                clsROneVarFitModel.AddParameter("optim.method", Chr(34) & "SANN" & Chr(34))
            End If
        Else
            clsROneVarFitModel.RemoveParameterByName("optim.method")
        End If
    End Sub

    Public Sub SetDistribution(ucrNewDists As ucrDistributions)
        ucrDists = ucrNewDists
        SetPlotOptions()
    End Sub

    Private Sub ucrDists_cboDistributionsIndexChanged() Handles ucrDists.DistributionsIndexChanged
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