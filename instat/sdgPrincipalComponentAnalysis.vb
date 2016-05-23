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
    Public bFirstLoad As Boolean = True
    Public clsREigenValues, clsREigenVectors, clsRScores, clsPCAModel As New RFunction
    Public clsRScreePlot As New RSyntax

    Private Sub sdgPrincipalComponentAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub EigenValues()
        clsREigenValues.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREigenValues.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
        clsREigenValues.AddParameter("value1", Chr(34) & "eig" & Chr(34))
        frmMain.clsRLink.RunScript(clsREigenValues.ToScript(), 2)
    End Sub

    Private Sub EigenVectors()
        clsREigenVectors.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsREigenVectors.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
        clsREigenVectors.AddParameter("value1", Chr(34) & "ind" & Chr(34))
        clsREigenVectors.AddParameter("value2", Chr(34) & "contrib" & Chr(34))
        frmMain.clsRLink.RunScript(clsREigenVectors.ToScript(), 2)
    End Sub

    Private Sub Scores()
        clsRScores.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRScores.AddParameter("model_name", Chr(34) & dlgPrincipalComponentAnalysis.strModelName & Chr(34))
        clsRScores.AddParameter("value1", Chr(34) & "ind" & Chr(34))
        clsRScores.AddParameter("value2", Chr(34) & "coord" & Chr(34))
        frmMain.clsRLink.RunScript(clsRScores.ToScript(), 2)
    End Sub

    Private Sub Residuals()
        'TODO
    End Sub

    Private Sub ScreePlot()
        clsRScreePlot.SetFunction("fviz_screeplot")
        clsRScreePlot.AddParameter("X", clsRFunctionParameter:=dlgPrincipalComponentAnalysis.ucrBasePCA.clsRsyntax.clsBaseFunction)

        frmMain.clsRLink.RunScript(clsRScreePlot.GetScript(), 0)
    End Sub

    Private Sub chkBar_CheckedChanged(sender As Object, e As EventArgs) Handles chkBar.CheckedChanged
        If chkBar.Checked Then
            If chkLine.Checked Then
                clsRScreePlot.AddParameter("geom", "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")
            Else
                clsRScreePlot.AddParameter("geom", Chr(34) & "bar" & Chr(34))
            End If
        Else
            chkLine.Checked = True
            clsRScreePlot.AddParameter("geom", Chr(34) & "line" & Chr(34))
        End If
    End Sub

    Private Sub chkLine_CheckedChanged(sender As Object, e As EventArgs) Handles chkLine.CheckedChanged
        If chkLine.Checked Then
            If chkBar.Checked Then
                clsRScreePlot.AddParameter("geom", "c(" & Chr(34) & "bar" & Chr(34) & "," & Chr(34) & "line" & Chr(34) & ")")
            Else
                clsRScreePlot.AddParameter("geom", Chr(34) & "line" & Chr(34))
            End If
        Else
            chkBar.Checked = True
            clsRScreePlot.AddParameter("geom", Chr(34) & "bar" & Chr(34))
        End If
    End Sub

    Private Sub cmbChoice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbChoice.SelectedIndexChanged
        clsRScreePlot.AddParameter("choice", Chr(34) & cmbChoice.SelectedItem.ToString & Chr(34))
    End Sub

    Private Sub chkScreePlot_CheckedChanged(sender As Object, e As EventArgs) Handles chkScreePlot.CheckedChanged
        If chkScreePlot.Checked Then
            grpGeom.Enabled = True
            chkBar.Enabled = True
            chkLine.Enabled = True
            lblChoice.Enabled = True
            cmbChoice.Enabled = True
        Else
            chkBar.Enabled = False
            chkLine.Enabled = False
            grpGeom.Enabled = False
            lblChoice.Enabled = False
            cmbChoice.Enabled = False
        End If
    End Sub


    Public Sub SetDefaults()
        chkEigenValues.Checked = True
        chkEigenVectors.Checked = True
        chkScores.Checked = True
        chkResiduals.Checked = True
        chkScreePlot.Checked = False
        chkBar.Checked = True
        chkLine.Checked = True
        chkBar.Enabled = False
        chkLine.Enabled = False
        grpGeom.Enabled = False
        lblChoice.Enabled = False
        cmbChoice.SelectedItem = "variance"
        cmbChoice.Enabled = False
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
        If chkScreePlot.Checked Then
            ScreePlot()
        End If
    End Sub

End Class
