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
    Private bResetSubdialog As Boolean = False
    Private bReset As Boolean = True
    Private clsDefaultFunction, clsRCanCorFunction, clsRXCoefFunction, clsRYCoefFunction, clsRGraphicsFunction As New RFunction

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
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 423

        ucrSelectorCCA.SetParameter(New RParameter("data", 0))
        ucrSelectorCCA.SetParameterIsrfunction()

        ucrReceiverYVariables.SetParameter(New RParameter("y", 0))
        ucrReceiverYVariables.SetParameterIsRFunction()
        ucrReceiverYVariables.Selector = ucrSelectorCCA
        ucrReceiverYVariables.SetDataType("numeric")
        ucrReceiverYVariables.strSelectorHeading = "Numerics"

        ' X Variable Selector
        ucrReceiverXVariables.SetParameter(New RParameter("x", 1))
        ucrReceiverXVariables.SetParameterIsRFunction()
        ucrReceiverXVariables.Selector = ucrSelectorCCA
        ucrReceiverXVariables.SetDataType("numeric")
        ucrReceiverXVariables.strSelectorHeading = "Numerics"

        'ucrSaveResult
        ucrSaveResult.SetCheckBoxText("Save Result")
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetPrefix("CCA")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetDataFrameSelector(ucrSelectorCCA.ucrAvailableDataFrames)
        ucrSaveResult.SetAssignToIfUncheckedValue("last_CCA")
        ucrBase.clsRsyntax.iCallType = 2
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsRGraphicsFunction = New RFunction
        clsRCanCorFunction = New RFunction
        clsRXCoefFunction = New RFunction
        clsRYCoefFunction = New RFunction

        ucrSelectorCCA.Reset()
        ucrSaveResult.Reset()
        ucrReceiverXVariables.SetMeAsReceiver()

        'Define the default RFunction
        clsDefaultFunction.SetRCommand("cancor")
        clsDefaultFunction.SetAssignTo("last_CCA", strTempModel:="last_CCA", strTempDataframe:=ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsRCanCorFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRCanCorFunction.iCallType = 2
        '        clsRCanCorFunction.AddParameter("data_name", Chr(34) & ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))

        clsRXCoefFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRXCoefFunction.iCallType = 2
        '        clsRXCoefFunction.AddParameter("data_name", Chr(34) & ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))

        clsRYCoefFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRYCoefFunction.iCallType = 2
        '        clsRYCoefFunction.AddParameter("data_name", Chr(34) & ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))

        clsRGraphicsFunction.SetPackageName("GGally")
        clsRGraphicsFunction.SetRCommand("ggpairs")
        clsRGraphicsFunction.iCallType = 3
        clsRCanCorFunction.AddParameter("value1", Chr(34) & "cor" & Chr(34))
        clsRXCoefFunction.AddParameter("value1", Chr(34) & "xcoef" & Chr(34))
        clsRYCoefFunction.AddParameter("value1", Chr(34) & "ycoef" & Chr(34))

        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToAfterCodes(clsRXCoefFunction, 1)
        ucrBase.clsRsyntax.AddToAfterCodes(clsRCanCorFunction, 2)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrSelectorCCA.AddAdditionalCodeParameterPair(clsRCanCorFunction, New RParameter("data_name", 0), iAdditionalPairNo:=1)
        ucrSelectorCCA.AddAdditionalCodeParameterPair(clsRXCoefFunction, New RParameter("data_name", 0), iAdditionalPairNo:=2)
        ucrSelectorCCA.AddAdditionalCodeParameterPair(clsRYCoefFunction, New RParameter("data_name", 0), iAdditionalPairNo:=3)

        ucrSelectorCCA.SetRCode(clsRGraphicsFunction, bReset)
        ucrSaveResult.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverXVariables.SetRCode(clsDefaultFunction, bReset)
        ucrReceiverYVariables.SetRCode(clsDefaultFunction, bReset)
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

    Private Sub cmdCCAOptions_Click(sender As Object, e As EventArgs) Handles cmdCCAOptions.Click
        sdgCanonicalCorrelation.SetRFunction(ucrBase.clsRsyntax, clsRCanCorFunction, clsRXCoefFunction, clsRYCoefFunction, clsRGraphicsFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgCanonicalCorrelation.ShowDialog()
    End Sub

    Private Sub ucrSaveResult_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlValueChanged
        If ucrSaveResult.ucrChkSave.Checked Then
            clsRCanCorFunction.AddParameter("model_name", Chr(34) & ucrSaveResult.GetText & Chr(34))
            clsRXCoefFunction.AddParameter("model_name", Chr(34) & ucrSaveResult.GetText & Chr(34))
            clsRYCoefFunction.AddParameter("model_name", Chr(34) & ucrSaveResult.GetText & Chr(34))
        Else
            clsRCanCorFunction.AddParameter("model_name", Chr(34) & "last_CCA" & Chr(34))
            clsRXCoefFunction.AddParameter("model_name", Chr(34) & "last_CCA" & Chr(34))
            clsRYCoefFunction.AddParameter("model_name", Chr(34) & "last_CCA" & Chr(34))
        End If
    End Sub

    Private Sub ucrSelectorCCA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorCCA.ControlValueChanged
        clsRYCoefFunction.AddParameter("data_name", Chr(34) & ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRXCoefFunction.AddParameter("data_name", Chr(34) & ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRCanCorFunction.AddParameter("data_name", Chr(34) & ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        ColumnsParameter()
    End Sub

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverXVariables.ControlContentsChanged, ucrReceiverYVariables.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Public Sub ColumnsParameter()
        If sdgCanonicalCorrelation.ucrChkPairwisePlot.Checked Then
            If sdgCanonicalCorrelation.rdoXVariables.Checked Then
                clsRGraphicsFunction.AddParameter("columns", ucrReceiverXVariables.GetVariableNames)
                ucrBase.clsRsyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=2)
            ElseIf sdgCanonicalCorrelation.rdoYVariables.Checked Then
                clsRGraphicsFunction.AddParameter("columns", ucrReceiverYVariables.GetVariableNames)
                ucrBase.clsRsyntax.AddToAfterCodes(clsRGraphicsFunction, iPosition:=2)
            Else
                ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRGraphicsFunction)
            End If
        Else
            ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRGraphicsFunction)
        End If
    End Sub

    Private Sub ucrReceiverVariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverXVariables.ControlValueChanged, ucrReceiverYVariables.ControlValueChanged
        ColumnsParameter()
    End Sub
End Class