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
Public Class sdgCanonicalCorrelation
    Public bFirstLoad As Boolean = True
    Public clsRCanCor, clsRCoef As New RFunction
    Public clsRGraphics As New RSyntax
    Private Sub sdgCanonicalCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub Cancor()
        clsRCanCor.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRCanCor.AddParameter("data_name", Chr(34) & dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRCanCor.AddParameter("model_name", Chr(34) & dlgCanonicalCorrelationAnalysis.strModelName & Chr(34))
        clsRCanCor.AddParameter("value1", Chr(34) & "cancor" & Chr(34))
        frmMain.clsRLink.RunScript(clsRCanCor.ToScript(), 2)
    End Sub

    Private Sub Coef()
        clsRCoef.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRCoef.AddParameter("data_name", Chr(34) & dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRCoef.AddParameter("model_name", Chr(34) & dlgCanonicalCorrelationAnalysis.strModelName & Chr(34))
        clsRCoef.AddParameter("value1", Chr(34) & "coef" & Chr(34))
        frmMain.clsRLink.RunScript(clsRCoef.ToScript(), 2)
    End Sub

    Public Sub SetDefaults()
        chkCanonicalCorrelations.Checked = True
        chkCoef.Checked = True
        chkPairwisePlot.Checked = False
        rdoXVariables.Checked = False
        rdoYVariables.Checked = False
        rdoXVariables.Enabled = False
        rdoYVariables.Enabled = False
    End Sub

    Public Sub CCAOptions()
        If (chkCanonicalCorrelations.Checked) Then
            Cancor()
        End If
        If (chkCoef.Checked) Then
            Coef()
        End If
        If (chkPairwisePlot.Checked = True) Then
            GGPairs()
        End If
    End Sub

    Private Sub GGPairs()
        Dim clsTempFunc As RFunction

        'temp solution to fix bug in ggpairs function
        clsTempFunc = dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
        clsTempFunc.AddParameter("remove_attr", "TRUE")

        clsRGraphics.SetFunction("ggpairs")
        clsRGraphics.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
        frmMain.clsRLink.RunScript(clsRGraphics.GetScript(), 2)
    End Sub

    Private Sub chkPairwisePlot_CheckedChanged(sender As Object, e As EventArgs) Handles chkPairwisePlot.CheckedChanged
        If chkPairwisePlot.Checked Then
            rdoXVariables.Enabled = True
            rdoYVariables.Enabled = True
            rdoXVariables.Checked = True
        Else
            rdoXVariables.Checked = False
            rdoXVariables.Enabled = False
            rdoYVariables.Enabled = False
        End If
    End Sub

    Private Sub rdoXVariables_CheckedChanged(sender As Object, e As EventArgs) Handles rdoXVariables.CheckedChanged
        If rdoXVariables.Checked Then
            clsRGraphics.AddParameter("columns", dlgCanonicalCorrelationAnalysis.ucrReceiverXvariables.GetVariableNames())
        Else
            clsRGraphics.RemoveParameter("columns")
        End If
    End Sub

    Private Sub rdoYVariables_CheckedChanged(sender As Object, e As EventArgs) Handles rdoYVariables.CheckedChanged
        If rdoYVariables.Checked Then
            clsRGraphics.AddParameter("columns", dlgCanonicalCorrelationAnalysis.ucrReceiverYvariables.GetVariableNames())
        Else
            clsRGraphics.RemoveParameter("columns")
        End If
    End Sub
End Class