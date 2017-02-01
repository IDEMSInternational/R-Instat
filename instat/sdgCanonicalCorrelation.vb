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
    Public bControlsInitialised As Boolean = False
    Public clsRCanCor, clsRCoef As New RFunction
    Public clsGraphFunction As New RFunction
    Public clsRGraphics As New RSyntax

    Private Sub sdgCanonicalCorrelation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        'CheckBoxes
        ucrChkCanonicalCorrelations.SetText("Canonical Correlations")
        ucrChkCanonicalCorrelations.SetParameter(New RParameter(""))
        ucrChkCanonicalCorrelations.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCanonicalCorrelations.SetRDefault("TRUE")

        'clsRCanCor.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        'clsRCanCor.AddParameter("data_name", Chr(34) & dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        'clsRCanCor.AddParameter("model_name", Chr(34) & dlgCanonicalCorrelationAnalysis.strModelName & Chr(34))
        'clsRCanCor.AddParameter("value1", Chr(34) & "cancor" & Chr(34))
        'frmMain.clsRLink.RunScript(clsRCanCor.ToScript(), 2)

        'InstatDataObject$get_from_model(value1 = "cancor", model_name = "CCA1", data_name = "DamangoShort")
        ucrChkCoefficients.SetText("Coefficients")
        ucrChkCoefficients.SetParameter(New RParameter(""))
        ucrChkCoefficients.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCoefficients.SetRDefault("TRUE")

        'clsRCoef.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        'clsRCoef.AddParameter("data_name", Chr(34) & dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        'clsRCoef.AddParameter("model_name", Chr(34) & dlgCanonicalCorrelationAnalysis.strModelName & Chr(34))
        'clsRCoef.AddParameter("value1", Chr(34) & "coef" & Chr(34))
        'frmMain.clsRLink.RunScript(clsRCoef.ToScript(), 2)

        SetParameter({ucrChkPairwisePlot, ucrPnlPairwise}, New RParameter("columns"))
        ucrChkPairwisePlot.SetText("Pairwise Plot")
        ucrChkPairwisePlot.bChangeParameterValue = False
        ucrChkPairwisePlot.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkPairwisePlot.SetRDefault("FALSE")
        ucrChkPairwisePlot.AddToLinkedControls(ucrLinked:=ucrPnlPairwise, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPairwise.AddRadioButton(rdoXVariables, dlgCanonicalCorrelationAnalysis.ucrReceiverXvariables.GetVariableNames())
        ucrPnlPairwise.AddRadioButton(rdoYVariables, dlgCanonicalCorrelationAnalysis.ucrReceiverYvariables.GetVariableNames())
        ucrPnlPairwise.SetRDefault(dlgCanonicalCorrelationAnalysis.ucrReceiverXvariables.GetVariableNames())

        rdoXVariables.Enabled = False
        rdoYVariables.Enabled = False

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewRFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsGraphFunction = clsNewRFunction
        SetRCode(Me, clsGraphFunction, bReset)
    End Sub
End Class

'Public Sub CCAOptions()
'If (chkCanonicalCorrelations.Checked) Then
'Cancor()
'End If
'If (chkCoef.Checked) Then
'Coef()
'End If
'If (chkPairwisePlot.Checked = True) Then
'GGPairs()
'End If
'End Sub

'   If rdoXVariables.Checked Then
'  clsRGraphics.AddParameter("columns", dlgCanonicalCorrelationAnalysis.ucrReceiverXvariables.GetVariableNames())
'    If rdoYVariables.Checked Then
'   clsRGraphics.AddParameter("columns", dlgCanonicalCorrelationAnalysis.ucrReceiverYvariables.GetVariableNames())


'Private Sub GGPairs()'
'Dim clsTempFunc As RFunction

''temp solution to fix bug in ggpairs function
'clsTempFunc = dlgCanonicalCorrelationAnalysis.ucrSelectorCCA.ucrAvailableDataFrames.clsCurrDataFrame.Clone()
'clsTempFunc.AddParameter("remove_attr", "TRUE")
''
'clsRGraphics.SetFunction("ggpairs")
'clsRGraphics.AddParameter("data", clsRFunctionParameter:=clsTempFunc)
'frmMain.clsRLink.RunScript(clsRGraphics.GetScript(), 2)
'End Sub