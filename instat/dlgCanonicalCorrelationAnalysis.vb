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
    Public strModelName As String = ""
    Public bFirstLoad As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private bReset As Boolean = True
    Private clsDefaultFunction, clsRCanCorFunction, clsRXCoefFunction, clsRYCoefFunction, clsRGraphicsFunction As New RFunction
    Private clsTempFunction, clsXvarFunction, clsYvarFunction, clsTempFunc As String

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

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrSaveResult.SetRCode(clsDefaultFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 423

        ' note: canne have the same variables in both receivers.
        ' Y Variable Selector
        ucrReceiverYvariables.SetParameter(New RParameter("y", 0))
        ucrReceiverYvariables.SetParameterIsRFunction()
        ucrReceiverYvariables.Selector = ucrSelectorCCA
        ucrReceiverYvariables.SetDataType("numeric")
        ucrReceiverYvariables.strSelectorHeading = "Numerics"

        ' X Variable Selector
        ucrReceiverXvariables.SetParameter(New RParameter("x", 1))
        ucrReceiverXvariables.SetParameterIsRFunction()
        ucrReceiverXvariables.Selector = ucrSelectorCCA
        ucrReceiverXvariables.SetDataType("numeric")
        ucrReceiverXvariables.strSelectorHeading = "Numerics"

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
        ucrReceiverXvariables.SetMeAsReceiver()

        'Define the default RFunction
        clsDefaultFunction.SetRCommand("cancor")
        clsDefaultFunction.SetAssignTo("last_CCA", strTempModel:="last_CCA", strTempDataframe:=ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        clsRCanCorFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRXCoefFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRYCoefFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_from_model")
        clsRGraphicsFunction.SetPackageName("GGally")
        clsRGraphicsFunction.SetRCommand("ggpairs")
        clsRCanCorFunction.AddParameter("data_name", Chr(34) & ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
        clsRCanCorFunction.AddParameter("model_name", Chr(34) & strModelName & Chr(34))
        clsRCanCorFunction.AddParameter("value1", Chr(34) & "cancor" & Chr(34))
        clsRCanCorFunction.AddParameter("model_name", Chr(34) & clsTempFunction & Chr(34))
        clsRCanCorFunction.AddParameter("value1", Chr(34) & "cor" & Chr(34))
        clsRXCoefFunction.AddParameter("model_name", Chr(34) & clsTempFunction & Chr(34))
        clsRXCoefFunction.AddParameter("value1", Chr(34) & "xcoef" & Chr(34))
        clsRYCoefFunction.AddParameter("model_name", Chr(34) & clsTempFunction & Chr(34))
        clsRYCoefFunction.AddParameter("value1", Chr(34) & "ycoef" & Chr(34))
        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        bResetSubdialog = True
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveResult.IsComplete() AndAlso ucrReceiverYvariables.lstSelectedVariables.Items.Count > 1 AndAlso ucrReceiverXvariables.lstSelectedVariables.Items.Count > 1 Then
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
        sdgCanonicalCorrelation.SetRFunction(ucrBase.clsRsyntax, clsRCanCorFunction, clsRXCoefFunction, clsRYCoefFunction, clsRGraphicsFunction, clsTempFunction, clsXvarFunction, clsYvarFunction, clsTempFunc, bResetSubdialog)
        bResetSubdialog = False
        sdgCanonicalCorrelation.ShowDialog()
    End Sub

    Private Sub ucrSaveResult_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlValueChanged
        clsTempFunction = ucrSaveResult.GetText
    End Sub

    Private Sub ucrReceiverXvariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverXvariables.ControlValueChanged
        clsXvarFunction = ucrReceiverXvariables.GetVariableNames()
    End Sub

    Private Sub ucrReceiverYvariables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverYvariables.ControlValueChanged
        clsYvarFunction = ucrReceiverYvariables.GetVariableNames()
    End Sub

    Private Sub ucrSelectorCCA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorCCA.ControlValueChanged
        clsTempFunc = ucrSelectorCCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem
    End Sub

    Private Sub ucrSaveResult_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverXvariables.ControlContentsChanged, ucrReceiverYvariables.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class