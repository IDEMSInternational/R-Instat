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
    Private clsRFunctionCancor, clsRFunctionCoef, clsRFunctionGraphics, clsDummyFunction As New RFunction

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
        'ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 423

        'ucrSelectorCCA.SetParameter(New RParameter("data_name", 0))
        'ucrSelectorCCA.SetParameterIsString()


        ' X Variable Selector
        ucrReceiverXVariables.SetParameter(New RParameter("x", 0))
        ucrReceiverXVariables.SetParameterIsRFunction()
        ucrReceiverXVariables.Selector = ucrSelectorCCA
        ucrReceiverXVariables.SetDataType("numeric", bStrict:=True)
        ucrReceiverXVariables.strSelectorHeading = "Numerics"

        'Y Variable Selector
        ucrReceiverYVariables.SetParameter(New RParameter("y", 1))
        ucrReceiverYVariables.SetParameterIsRFunction()
        ucrReceiverYVariables.Selector = ucrSelectorCCA
        ucrReceiverYVariables.SetDataType("numeric", bStrict:=True)
        ucrReceiverYVariables.strSelectorHeading = "Numerics"

        ucrPnlVariables.AddRadioButton(rdoXVariables)
        ucrPnlVariables.AddRadioButton(rdoYVariables)

        ucrChkCoefficients.SetText("Coefficients")
        ucrChkPairwisePlot.SetText("Pairwise Plot")
        ucrChkPairwisePlot.AddParameterValuesCondition(True, "check", "TRUE")
        ucrChkPairwisePlot.AddParameterValuesCondition(False, "check", "FALSE")
        ucrChkPairwisePlot.AddToLinkedControls(ucrPnlVariables, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveResult.SetPrefix("last_model")
        ucrSaveResult.SetSaveType(RObjectTypeLabel.Model, strRObjectFormat:=RObjectFormat.Text)
        ucrSaveResult.SetDataFrameSelector(ucrSelectorCCA.ucrAvailableDataFrames)
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetCheckBoxText("Save Model")
        ucrSaveResult.SetAssignToIfUncheckedValue("last_model")

    End Sub

    Private Sub SetDefaults()
        clsRFunctionCancor = New RFunction
        clsRFunctionCoef = New RFunction
        clsRFunctionGraphics = New RFunction

        ucrSelectorCCA.Reset()
        ucrSaveResult.Reset()
        ucrReceiverXVariables.SetMeAsReceiver()
        ucrChkCoefficients.Checked = True

        'ucrBase.clsRsyntax.lstAfterCodes.Clear()

        'Define the default RFunction
        clsDummyFunction.AddParameter("check", "FALSE", iPosition:=0)

        clsRFunctionCancor.SetPackageName("stats")
        clsRFunctionCancor.SetRCommand("cancor")
        clsRFunctionCancor.SetAssignToOutputObject(strRObjectToAssignTo:="last_model",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Model,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorCCA.strCurrentDataFrame,
                                                  strObjectName:="last_model")
        'clsRFunctionCancor.bExcludeAssignedFunctionOutput = False

        clsRFunctionCoef.SetRCommand("cancor_coef")
        clsRFunctionCoef.AddParameter("object", clsRFunctionParameter:=clsRFunctionCancor, iPosition:=0)
        clsRFunctionCoef.SetAssignToOutputObject(strRObjectToAssignTo:="last_summary",
                                                 strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                                                 strRObjectFormatToAssignTo:=RObjectFormat.Text,
                                                 strRDataFrameNameToAddObjectTo:=ucrSelectorCCA.strCurrentDataFrame,
                                                 strObjectName:="last_summary")

        clsRFunctionGraphics.SetPackageName("GGally")
        clsRFunctionGraphics.SetRCommand("ggpairs")
        ''clsRFunctionGraphics.SetAssignToOutputObject(strRObjectToAssignTo:="last_graph",
        'strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Graph,
        '                                          strRObjectFormatToAssignTo:=RObjectFormat.Image,
        '                                          strRDataFrameNameToAddObjectTo:=ucrSelectorCCA.strCurrentDataFrame,
        '                                          strObjectName:="last_graph")
        'clsRFunctionGraphics.bExcludeAssignedFunctionOutput = False

        ucrBase.clsRsyntax.SetBaseRFunction(clsRFunctionCancor)
        'bResetSubdialog = True
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrReceiverXVariables.SetRCode(clsRFunctionCancor, bReset)
        ucrReceiverYVariables.SetRCode(clsRFunctionCancor, bReset)
        ucrChkPairwisePlot.SetRCode(clsDummyFunction, bReset)
        ucrPnlVariables.SetRCode(clsRFunctionGraphics, bReset)
        ucrSaveResult.SetRCode(clsRFunctionCancor, bReset)
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


    Private Sub ucrChkCoefficients_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkCoefficients.ControlValueChanged
        If ucrChkCoefficients.Checked Then
            ucrBase.clsRsyntax.AddToAfterCodes(clsRFunctionCoef, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRFunctionCoef)
        End If
    End Sub

    Private Sub ucrChkPairwisePlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPairwisePlot.ControlValueChanged
        If ucrChkPairwisePlot.Checked Then
            ucrPnlVariables.Visible = True
            clsDummyFunction.AddParameter("check", "TRUE", iPosition:=0)
            ucrBase.clsRsyntax.AddToAfterCodes(clsRFunctionGraphics, iPosition:=1)
        Else
            ucrPnlVariables.Visible = False
            clsDummyFunction.AddParameter("check", "FALSE", iPosition:=0)
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRFunctionGraphics)

        End If
    End Sub

    Private Sub ucrReceiverVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverXVariables.ControlValueChanged, ucrReceiverYVariables.ControlValueChanged
        clsRFunctionGraphics.AddParameter("data", clsRFunctionParameter:=ucrSelectorCCA.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
        If rdoXVariables.Checked Then
            clsRFunctionGraphics.AddParameter("columns", ucrReceiverXVariables.GetVariableNames, iPosition:=1)
        ElseIf rdoYVariables.Checked Then
            clsRFunctionGraphics.AddParameter("columns", ucrReceiverYVariables.GetVariableNames, iPosition:=2)
        End If
    End Sub


    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged,
        ucrReceiverXVariables.ControlContentsChanged, ucrReceiverYVariables.ControlContentsChanged,
        ucrChkPairwisePlot.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class