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

Public Class sdgOneVarFitModel
    Public clsROneVarFitModel As New RFunction
    Private clsRLogLikFunction As New RFunction
    Private WithEvents ucrDistribution As ucrDistributions
    Public bControlsInitialised As Boolean = False
    Private clsRSyntax As RSyntax

    Private Sub sdgOneVarFitModDisplay(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        'TODO needs a probs argument
        rdoQme.Enabled = False
        ucrPnlFitMethod.SetParameter(New RParameter("method"))
        ucrPnlFitMethod.AddRadioButton(rdoMle, Chr(34) & "mle" & Chr(34))
        ucrPnlFitMethod.AddRadioButton(rdoMme, Chr(34) & "mme" & Chr(34))
        ucrPnlFitMethod.AddRadioButton(rdoQme, Chr(34) & "qme" & Chr(34))
        ucrPnlFitMethod.AddRadioButton(rdoMge, Chr(34) & "mge" & Chr(34))

        ucrPnlOptimisation.SetParameter(New RParameter("optim.method"))
        ucrPnlOptimisation.AddRadioButton(rdoDefault, Chr(34) & "default" & Chr(34))
        ucrPnlOptimisation.AddRadioButton(rdoNelderMead, Chr(34) & "Nelder-Mead" & Chr(34))
        ucrPnlOptimisation.AddRadioButton(rdoBFGS, Chr(34) & "BFGS" & Chr(34))
        ucrPnlOptimisation.AddRadioButton(rdoCG, Chr(34) & "CG" & Chr(34))
        ucrPnlOptimisation.AddRadioButton(rdoSANN, Chr(34) & "SANN" & Chr(34))
        ucrPnlOptimisation.SetRDefault(Chr(34) & "default" & Chr(34))
        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewRSyntax As RSyntax, clsRNewOneVarFitModel As RFunction, Optional clsNewRLogLikFunction As RFunction = Nothing, Optional ucrNewDistribution As ucrDistributions = Nothing, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRSyntax = clsNewRSyntax
        clsRLogLikFunction = clsNewRLogLikFunction
        ucrDistribution = ucrNewDistribution
        clsROneVarFitModel = clsRNewOneVarFitModel
        ucrPnlOptimisation.SetRCode(clsROneVarFitModel, bReset)
        ucrPnlFitMethod.SetRCode(clsROneVarFitModel, bReset)
    End Sub

    Private Sub ucrDistribution_cboDistributionsIndexChanged() Handles ucrDistribution.DistributionsIndexChanged
        If ucrDistribution.clsCurrDistribution IsNot Nothing AndAlso Not ucrDistribution.clsCurrDistribution.bIsContinuous Then
            rdoMge.Enabled = False
            If rdoMge.Checked Then
                rdoMle.Checked = True
            End If
        Else
            rdoMge.Enabled = True
        End If
    End Sub

    Private Sub SetPlotOptions()
        If ucrDistribution.clsCurrDistribution IsNot Nothing AndAlso Not ucrDistribution.clsCurrDistribution.bIsContinuous Then
            rdoMge.Enabled = False
            If rdoMge.Checked Then
                rdoMle.Checked = True
            End If
        Else
            rdoMge.Enabled = True
        End If
    End Sub

    Private Sub ucrPnlFitMethod_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlFitMethod.ControlValueChanged
        If rdoMle.Checked Then
            clsRSyntax.AddToAfterCodes(clsRLogLikFunction, iPosition:=2)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRLogLikFunction)
        End If
    End Sub
End Class