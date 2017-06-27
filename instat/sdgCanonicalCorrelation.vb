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
    Public strModelName As String
    Public clsTempFunction As String
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsRCanCorFunction, clsRCoefFunction, clsRGraphicsFunction As New RFunction
    Private clsRSyntax As RSyntax
    Private Sub sdgCanonicalCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        'ucrPnlVariables.SetParameter(New RParameter("columns", 1))
        ucrPnlVariables.AddRadioButton(rdoXVariables)
        ucrPnlVariables.AddRadioButton(rdoYVariables)

        ucrChkCanonicalCorrelations.SetText("canonical Correlations")
        ucrChkCoefficients.SetText("Coefficients")
        ucrChkPairwisePlot.SetText("Pairwise Plot")
        ucrChkPairwisePlot.AddToLinkedControls(ucrPnlVariables, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

    Public Sub SetRFunction(clsNewRSyntax As RSyntax, clsNewRCanCorFunction As RFunction, clsNewRCoefFunction As RFunction, clsNewRGraphicsFunction As RFunction, clsNewTempFunction As String, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        Dim clsTempFunc As RFunction
        clsRSyntax = clsNewRSyntax
        clsRCanCorFunction = clsNewRCanCorFunction
        clsRCoefFunction = clsNewRCoefFunction
        clsRGraphicsFunction = clsNewRGraphicsFunction
        clsTempFunction = clsNewTempFunction

        clsRCanCorFunction.AddParameter("data_name", Chr(34) & dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        'clsRCanCorFunction.AddParameter("model_name", clsTempFunction)

        clsRCanCorFunction.AddParameter("model_name", Chr(34) & clsTempFunction & Chr(34))
        clsRCoefFunction.AddParameter("data_name", Chr(34) & dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRCoefFunction.AddParameter("model_name", Chr(34) & dlgCanonicalCorrelationAnalysis.strModelName & Chr(34))
        clsRCanCorFunction.AddParameter("value1", Chr(34) & "cancor" & Chr(34))
        clsRCoefFunction.AddParameter("value1", Chr(34) & "coef" & Chr(34))

        clsTempFunc = dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
        clsTempFunc.AddParameter("remove_attr", "TRUE")
        clsRGraphicsFunction.AddParameter("data", clsRFunctionParameter:=clsTempFunc)

        If bReset Then
            tbRegOptions.SelectedIndex = 0
        End If
    End Sub

    Private Sub Cancor()
        'clsRCanCorFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        'clsRCanCorFunction.AddParameter("data_name", Chr(34) & dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        'clsRCanCorFunction.AddParameter("model_name", Chr(34) & dlgCanonicalCorrelationAnalysis.strModelName & Chr(34))
        'clsRCanCorFunction.AddParameter("value1", Chr(34) & "cancor" & Chr(34))
        'frmMain.clsRLink.RunScript(clsRCanCorFunction.ToScript(), 2)
    End Sub

    Private Sub Coef()
        'clsRCoefFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        'clsRCoefFunction.AddParameter("data_name", Chr(34) & dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        'clsRCoefFunction.AddParameter("model_name", Chr(34) & dlgCanonicalCorrelationAnalysis.strModelName & Chr(34))
        'clsRCoefFunction.AddParameter("value1", Chr(34) & "coef" & Chr(34))
        'frmMain.clsRLink.RunScript(clsRCoefFunction.ToScript(), 2)
    End Sub

    Private Sub ucrChkCanonicalCorrelations_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCanonicalCorrelations.ControlValueChanged
        clsRCanCorFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        If ucrChkCanonicalCorrelations.Checked Then
            clsRSyntax.AddToAfterCodes(clsRCanCorFunction, iPosition:=0)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRCanCorFunction)
        End If
    End Sub

    Private Sub ucrChkCoefficients_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCoefficients.ControlValueChanged
        clsRCoefFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        If ucrChkCoefficients.Checked Then
            clsRSyntax.AddToAfterCodes(clsRCoefFunction, iPosition:=1)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRCoefFunction)
        End If
    End Sub

    Private Sub ucrChkPairwisePlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPairwisePlot.ControlValueChanged
        If ucrChkPairwisePlot.Checked Then
            clsRSyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=2)
        Else
            clsRSyntax.RemoveFromAfterCodes(clsRGraphicsFunction)
        End If
    End Sub

    Private Sub ucrPnlVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlVariables.ControlValueChanged
        clsRGraphicsFunction.SetPackageName("GGally")
        clsRGraphicsFunction.SetRCommand("ggpairs")
        If rdoXVariables.Checked Then
            clsRGraphicsFunction.AddParameter("columns", dlgCanonicalCorrelationAnalysis.ucrReceiverXvariables.GetVariableNames())
        Else
            'clsRGraphicsFunction.RemoveParameter("columns")
        End If
        If rdoYVariables.Checked Then
            clsRGraphicsFunction.AddParameter("columns", dlgCanonicalCorrelationAnalysis.ucrReceiverYvariables.GetVariableNames())
        Else
            'clsRGraphicsFunction.RemoveParameter("columns")
        End If

    End Sub

    'Public Sub SetDefaults()
    '    ucrChkCanonicalCorrelations.Checked = True
    '    ucrChkCoefficients.Checked = True
    '    ucrChkPairwisePlot.Checked = False
    '    rdoXVariables.Checked = False
    '    rdoYVariables.Checked = False
    '    rdoXVariables.Enabled = False
    '    rdoYVariables.Enabled = False
    'End Sub

    'Public Sub CCAOptions()
    '    If (ucrChkCanonicalCorrelations.Checked) Then
    '        Cancor()
    '    End If
    '    If (ucrChkCoefficients.Checked) Then
    '        Coef()
    '    End If
    '    If (ucrChkPairwisePlot.Checked = True) Then
    '        GGPairs()
    '    End If
    'End Sub

    Private Sub GGPairs()
        'Dim clsTempFunc As RFunction

        'temp solution to fix bug in ggpairs function
        'clsTempFunc = dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
        'clsTempFunc.AddParameter("remove_attr", "TRUE")

        'clsRGraphics.SetPackageName("GGally")
        'clsRGraphics.SetFunction("ggpairs")
        'clsRGraphicsFunction.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
        'frmMain.clsRLink.RunScript(clsRGraphicsFunction.ToScript(), 2)
    End Sub

    'Private Sub chkPairwisePlot_CheckedChanged(sender As Object, e As EventArgs)
    '    If ucrChkPairwisePlot.Checked Then
    '        rdoXVariables.Enabled = True
    '        rdoYVariables.Enabled = True
    '        rdoXVariables.Checked = True
    '    Else
    '        rdoXVariables.Checked = False
    '        rdoXVariables.Enabled = False
    '        rdoYVariables.Enabled = False
    '    End If
    'End Sub

    'Private Sub rdoXVariables_CheckedChanged(sender As Object, e As EventArgs) Handles rdoXVariables.CheckedChanged
    '    If rdoXVariables.Checked Then
    '        clsRGraphics.AddParameter("columns", dlgCanonicalCorrelationAnalysis.ucrReceiverXvariables.GetVariableNames())
    '    Else
    '        clsRGraphics.RemoveParameter("columns")
    '    End If
    'End Sub

    'Private Sub rdoYVariables_CheckedChanged(sender As Object, e As EventArgs) Handles rdoYVariables.CheckedChanged
    '    If rdoYVariables.Checked Then
    '        clsRGraphics.AddParameter("columns", dlgCanonicalCorrelationAnalysis.ucrReceiverYvariables.GetVariableNames())
    '    Else
    '        clsRGraphics.RemoveParameter("columns")
    '    End If
    'End Sub

End Class