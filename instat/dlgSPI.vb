' R-Instat
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
Public Class dlgSPI
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsSpiFunction As New RFunction
    Private clsSpeiFunction As New RFunction
    Private clsListFunction As New RFunction
    Private clsSpeiInputFunction As New RFunction
    Private clsSpeiOutputFunction As New RFunction

    Private Sub dlgSPI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        Dim dctType As New Dictionary(Of String, String)

        ucrBase.iHelpTopicID = 566

        ucrSelectorVariable.SetParameterIsrfunction()
        ucrSelectorVariable.SetParameter(New RParameter("data", 0))
        ucrSelectorVariable.bUseCurrentFilter = False

        'receivers
        ucrReceiverStation.SetParameterIsString()
        ucrReceiverStation.SetParameter(New RParameter("station", 1))
        ucrReceiverStation.Selector = ucrSelectorVariable
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.bUseFilteredData = False

        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.SetParameter(New RParameter("year", 2))
        ucrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.bUseFilteredData = False

        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.SetParameter(New RParameter("month", 3))
        ucrReceiverMonth.Selector = ucrSelectorVariable
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.bUseFilteredData = False

        ucrReceiverElement.SetParameterIsString()
        ucrReceiverElement.SetParameter(New RParameter("element", 4))
        ucrReceiverElement.SetClimaticType("rain")
        ucrReceiverElement.Selector = ucrSelectorVariable
        ucrReceiverElement.bAutoFill = True
        ucrReceiverElement.bUseFilteredData = False

        'setting up Nuds
        ucrNudTimeScale.SetParameter(New RParameter("scale", 1))
        ucrNudTimeScale.SetMinMax(1)

        'others
        ucrChkOmitMissingValues.SetParameter(New RParameter("na.rm", 5))
        ucrChkOmitMissingValues.SetText("Omit Missing Values")
        ucrChkOmitMissingValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        'input
        ucrInputType.SetParameter(New RParameter("type", 0))
        dctType.Add("Rectangular", Chr(39) & "rectangular" & Chr(39))
        dctType.Add("Triangular", Chr(39) & "triangular" & Chr(39))
        dctType.Add("Circular", Chr(39) & "circular" & Chr(39))
        dctType.Add("Gaussian", Chr(39) & "gaussian" & Chr(39))
        ucrInputType.SetItems(dctType)
        ucrInputType.SetDropDownStyleAsNonEditable()

        'ucrshift
        ucrNudKernelShift.SetParameter(New RParameter("shift", 1))
        ucrNudKernelShift.SetMinMax(0, 24)

        'ucrpnlInd
        ucrPnlIndex.AddRadioButton(rdoSPI)
        ucrPnlIndex.AddRadioButton(rdoSPEI)
        ucrPnlIndex.AddParameterValueFunctionNamesCondition(rdoSPI, "object", "spi")
        ucrPnlIndex.AddParameterValueFunctionNamesCondition(rdoSPEI, "object", "spei")

        ucrSaveIndex.SetSaveTypeAsColumn()
        ucrSaveIndex.SetDataFrameSelector(ucrSelectorVariable.ucrAvailableDataFrames)
        ucrSaveIndex.SetLabelText("Save Index into:")
        ucrSaveIndex.SetIsTextBox()
        ucrSaveIndex.SetPrefix("spi")

        ucrSaveModel.SetSaveTypeAsModel()
        ucrSaveModel.SetDataFrameSelector(ucrSelectorVariable.ucrAvailableDataFrames)
        ucrSaveModel.SetCheckBoxText("Save Model")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsSpeiFunction = New RFunction
        clsSpiFunction = New RFunction
        clsListFunction = New RFunction
        clsSpeiInputFunction = New RFunction
        clsSpeiOutputFunction = New RFunction

        ucrBase.clsRsyntax.ClearCodes()

        ucrSelectorVariable.Reset()
        ucrSaveIndex.Reset()
        ucrSaveModel.Reset()
        ucrReceiverElement.SetMeAsReceiver()

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("type", Chr(39) & "rectangular" & Chr(39), iPosition:=0)
        clsListFunction.AddParameter("shift", 0, iPosition:=1)

        clsSpiFunction.SetPackageName("SPEI")
        clsSpiFunction.SetRCommand("spi")
        clsSpiFunction.AddParameter("data", clsRFunctionParameter:=clsSpeiInputFunction, iPosition:=0)
        clsSpiFunction.AddParameter("scale", 1, iPosition:=1)
        clsSpiFunction.AddParameter("na.rm", "TRUE", iPosition:=5)
        clsSpiFunction.AddParameter("kernel", clsRFunctionParameter:=clsListFunction, iPosition:=2)
        clsSpiFunction.SetAssignTo("last_model", strTempDataframe:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)

        clsSpeiFunction.SetPackageName("SPEI")
        clsSpeiFunction.SetRCommand("spei")
        clsSpeiFunction.AddParameter("data", clsrfunctionparameter:=clsSpeiInputFunction, iPosition:=0)
        clsSpeiFunction.AddParameter("scale", 1, iPosition:=1)
        clsSpeiFunction.AddParameter("na.rm", "TRUE", iPosition:=5)
        clsSpeiFunction.AddParameter("kernel", clsRFunctionParameter:=clsListFunction, iPosition:=2)
        clsSpeiFunction.SetAssignTo("last_model", strTempDataframe:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)

        clsSpeiInputFunction.SetRCommand("spei_input")
        clsSpeiInputFunction.SetAssignTo("data_ts")

        clsSpeiOutputFunction.SetRCommand("spei_output")
        clsSpeiOutputFunction.AddParameter("x", clsRFunctionParameter:=clsSpiFunction, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsSpeiOutputFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudTimeScale.AddAdditionalCodeParameterPair(clsSpeiFunction, New RParameter("scale", 1), iAdditionalPairNo:=1)
        ucrChkOmitMissingValues.AddAdditionalCodeParameterPair(clsSpeiFunction, New RParameter("na.rm", 6), iAdditionalPairNo:=1)
        ucrSaveModel.AddAdditionalRCode(clsSpiFunction, bReset)

        ucrReceiverStation.AddAdditionalCodeParameterPair(clsSpeiOutputFunction, New RParameter("station", 2), iAdditionalPairNo:=1)
        ucrReceiverYear.AddAdditionalCodeParameterPair(clsSpeiOutputFunction, New RParameter("year", 3), iAdditionalPairNo:=1)
        ucrReceiverMonth.AddAdditionalCodeParameterPair(clsSpeiOutputFunction, New RParameter("month", 4), iAdditionalPairNo:=1)
        ucrSelectorVariable.AddAdditionalCodeParameterPair(clsSpeiOutputFunction, ucrSelectorVariable.GetParameter(), iAdditionalPairNo:=1)

        ucrReceiverStation.SetRCode(clsSpeiInputFunction, bReset)
        ucrReceiverYear.SetRCode(clsSpeiInputFunction, bReset)
        ucrReceiverMonth.SetRCode(clsSpeiInputFunction, bReset)
        ucrReceiverElement.SetRCode(clsSpeiInputFunction, bReset)
        ucrSelectorVariable.SetRCode(clsSpeiInputFunction, bReset)

        ucrChkOmitMissingValues.SetRCode(clsSpiFunction, bReset)
        ucrNudTimeScale.SetRCode(clsSpiFunction, bReset)
        ucrInputType.SetRCode(clsListFunction, bReset)
        ucrNudKernelShift.SetRCode(clsListFunction, bReset)
        ucrSaveIndex.SetRCode(clsSpeiOutputFunction, bReset)
        ucrSaveModel.SetRCode(clsSpeiFunction, bReset)
        SetShiftMax()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverElement.IsEmpty AndAlso ucrSaveIndex.IsComplete AndAlso ucrSaveModel.IsComplete AndAlso ucrNudKernelShift.GetText <> "" AndAlso ucrNudTimeScale.GetText <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnlIndex_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlIndex.ControlContentsChanged
        If rdoSPI.Checked Then
            clsSpeiOutputFunction.AddParameter("x", clsRFunctionParameter:=clsSpiFunction, iPosition:=0)
            ucrSaveIndex.SetPrefix("spi")
            ucrSaveModel.SetPrefix("spi_mod")
        ElseIf rdoSPEI.Checked Then
            clsSpeiOutputFunction.AddParameter("x", clsRFunctionParameter:=clsSpeiFunction, iPosition:=0)
            ucrSaveIndex.SetPrefix("spei")
            ucrSaveModel.SetPrefix("spei_mod")
        End If
    End Sub

    Private Sub ucrNudTimeScale_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudTimeScale.ControlValueChanged
        SetShiftMax()
    End Sub

    Private Sub SetShiftMax()
        If ucrNudTimeScale.GetText <> "" AndAlso ucrNudTimeScale.Value < 25 Then
            ucrNudKernelShift.SetMinMax(0, ucrNudTimeScale.GetText - 1)
        Else
            ucrNudKernelShift.SetMinMax(0, 24)
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverElement.ControlContentsChanged, ucrReceiverYear.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrSaveIndex.ControlContentsChanged, ucrSaveModel.ControlContentsChanged, ucrNudTimeScale.ControlContentsChanged, ucrNudKernelShift.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class