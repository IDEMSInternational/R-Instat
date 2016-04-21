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
Public Class sdgPrincipalComponentAnalysis
    'Public clsRPCAFunction As RFunction
    Public bFirstLoad As Boolean = True

    Private Sub sdgPrincipalComponentAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    'Public Sub SetRModelFunction(clsRModelFunc As RFunction)
    '    clsRModelFunction = clsRModelFunc
    'End Sub

    Private Sub EigenValues()
        frmMain.clsRLink.RunScript(dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.GetScript() & "$eig", 2)
    End Sub

    Private Sub EigenVectors()
        frmMain.clsRLink.RunScript(dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.GetScript() & "$ind$contrib", 2)
    End Sub

    Private Sub Scores()
        frmMain.clsRLink.RunScript(dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.GetScript() & "$ind$coord", 2)
    End Sub

    Private Sub Residuals()
        'frmMain.clsRLink.RunScript(dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.GetScript() & "$eig", 2)
    End Sub

    Public Sub SetDefaults()
        chkEigenValues.Checked = True
        chkEigenVectors.Checked = True
        chkScores.Checked = True
        chkResiduals.Checked = True
    End Sub

    Public Sub PCAOptions()
        If (chkEigenValues.Checked) Then
            EigenValues()
        End If
        If (chkEigenVectors.Checked) Then
            EigenVectors()
        End If
        If (chkScores.Checked) Then
            Scores()
        End If
        If (chkResiduals.Checked) Then
            Residuals()
        End If
    End Sub

End Class
