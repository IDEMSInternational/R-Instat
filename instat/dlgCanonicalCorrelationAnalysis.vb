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
Public Class dlgCanonicalCorrelationAnalysis
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction, clsRCoefFunction, clsRGraphicsFunction, clsDummyFunction As New RFunction

    Private Sub dlgCanonicalCorrelationAnalysis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        'ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 423

        ucrSelectorCCA.SetParameter(New RParameter("data_name", 0))
        ucrSelectorCCA.SetParameterIsString()

        ucrReceiverYVariables.SetParameter(New RParameter("y", 0))
        ucrReceiverYVariables.SetParameterIsRFunction()
        ucrReceiverYVariables.Selector = ucrSelectorCCA
        ucrReceiverYVariables.SetDataType("numeric", bStrict:=True)
        ucrReceiverYVariables.strSelectorHeading = "Numerics"

        ' X Variable Selector
        ucrReceiverXVariables.SetParameter(New RParameter("x", 1))
        ucrReceiverXVariables.SetParameterIsRFunction()
        ucrReceiverXVariables.Selector = ucrSelectorCCA
        ucrReceiverXVariables.SetDataType("numeric", bStrict:=True)
        ucrReceiverXVariables.strSelectorHeading = "Numerics"

        ucrPnlVariables.AddRadioButton(rdoXVariables)
        ucrPnlVariables.AddRadioButton(rdoYVariables)

        ucrChkCoefficients.SetText("Coefficients")

        ucrChkPairwisePlot.SetText("Pairwise Plot")
        ucrChkPairwisePlot.AddToLinkedControls(ucrPnlVariables, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoXVariables)

        ucrSaveResult.SetDataFrameSelector(ucrSelectorCCA.ucrAvailableDataFrames)
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsRGraphicsFunction = New RFunction
        clsRCoefFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrSelectorCCA.Reset()
        ucrSaveResult.Reset()
        ucrReceiverXVariables.SetMeAsReceiver()
        ucrChkCoefficients.Checked = True

        'Define the default RFunction
        clsDefaultFunction.SetRCommand("cancor")
        clsRCoefFunction.AddParameter("object", clsRFunctionParameter:=clsDefaultFunction, iPosition:=0)
        clsDefaultFunction.SetAssignToOutputObject(strRObjectToAssignTo:="CCA",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorCCA.strCurrentDataFrame,
                                                  strObjectName:="last_CCA")

        clsRCoefFunction.SetRCommand("cancor_coef")
        clsRCoefFunction.SetAssignToOutputObject(strRObjectToAssignTo:="CCA",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorCCA.strCurrentDataFrame,
                                                  strObjectName:="last_CCA")

        clsRGraphicsFunction.SetPackageName("GGally")
        clsRGraphicsFunction.SetRCommand("ggpairs")
        clsRGraphicsFunction.iCallType = 3
        clsRGraphicsFunction.bExcludeAssignedFunctionOutput = False

        'ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        'bResetSubdialog = True
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverXVariables.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverYVariables.SetRCode(clsDefaultFunction, bReset)
        ucrPnlVariables.SetRCode(clsRGraphicsFunction, bReset)
        ucrSaveResult.SetRCode(clsDefaultFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveResult.IsComplete() AndAlso ucrReceiverYVariables.lstSelectedVariables.Items.Count > 1 AndAlso ucrReceiverXVariables.lstSelectedVariables.Items.Count > 1 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBaseCCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverXVariables.ControlValueChanged,
        ucrReceiverYVariables.ControlValueChanged, ucrChkPairwisePlot.ControlValueChanged, ucrPnlVariables.ControlValueChanged,
         ucrSelectorCCA.ControlValueChanged
        If ucrChkPairwisePlot.Checked Then
            clsRGraphicsFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorCCA.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
            If rdoXVariables.Checked Then
                clsRGraphicsFunction.AddParameter("columns", ucrReceiverXVariables.GetVariableNames)
                ucrBase.clsRsyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=1)
            ElseIf rdoYVariables.Checked Then
                clsRGraphicsFunction.AddParameter("columns", ucrReceiverYVariables.GetVariableNames)
                ucrBase.clsRsyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=1)
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRGraphicsFunction)
            End If
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRGraphicsFunction)
        End If
    End Sub

    Private Sub ucrChkCoefficients_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCoefficients.ControlValueChanged
        If ucrChkCoefficients.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsRCoefFunction, iPosition:=0)
        Else
            ucrBase.clsRsyntax.lstAfterCodes.Clear()
        End If
    End Sub

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged,
        ucrReceiverXVariables.ControlContentsChanged, ucrReceiverYVariables.ControlContentsChanged, ucrChkCoefficients.ControlContentsChanged,
        ucrChkPairwisePlot.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class