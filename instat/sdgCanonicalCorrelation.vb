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
Public Class sdgCanonicalCorrelation
    Public bFirstLoad As Boolean = True
    Private Sub sdgCanonicalCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub Cancor()
        frmMain.clsRLink.RunScript(dlgCanonicalCorrelationAnalysis.ucrBaseCCA.clsRsyntax.GetScript() & "$cancor", 2)
    End Sub

    Private Sub Coef()
        frmMain.clsRLink.RunScript(dlgCanonicalCorrelationAnalysis.ucrBaseCCA.clsRsyntax.GetScript() & "$coef", 2)
    End Sub

    Public Sub SetDefaults()
        chkCanonicalCorrelations.Checked = True
        chkCoef.Checked = True
    End Sub

    Public Sub CCAOptions()
        If (chkCanonicalCorrelations.Checked) Then
            Cancor()
        End If
        If (chkCoef.Checked) Then
            Coef()
        End If
    End Sub
End Class