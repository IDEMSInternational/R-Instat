'R-Instat
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
    Private clsSpiFunction, clsSpeiFunction, clsListFunction, clsSummaryFunction, clsAsVectorFunction As New RFunction
    Private clsDolarOperator As New ROperator

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
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.iHelpTopicID = 566

        ucrSelectorVariable.SetParameterIsString()

        'receivers
        ucrReceiverData.SetParameterIsRFunction()
        ucrReceiverData.SetParameter(New RParameter("data", 0))
        ucrReceiverData.Selector = ucrSelectorVariable
        ucrReceiverData.bAutoFill = True
        ucrReceiverData.strSelectorHeading = "Variables"

        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.SetClimaticType("year")
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorVariable
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"

        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorVariable
        ucrReceiverDate.SetClimaticType("date")
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        'setting up Nuds
        ucrNudTimeScale.SetParameter(New RParameter("scale", 1))
        ucrNudTimeScale.SetMinMax(1)

        'others
        ucrChkOmitMissingValues.SetParameter(New RParameter("na.rm", 5))
        ucrChkOmitMissingValues.SetText("Omit Missing Values")
        ucrChkOmitMissingValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")

        'panel
        ucrPnlKernelType.SetParameter(New RParameter("type", 0))
        ucrPnlKernelType.AddRadioButton(rdoTriangular, Chr(39) & "triangular" & Chr(39))
        ucrPnlKernelType.AddRadioButton(rdoCircular, Chr(39) & "circular" & Chr(39))
        ucrPnlKernelType.AddRadioButton(rdoRectangular, Chr(39) & "rectangular" & Chr(39))
        ucrPnlKernelType.AddRadioButton(rdoGaussian, Chr(39) & "gaussian" & Chr(39))

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
        ucrSaveModel.SetCheckBoxText("Save Model:")
        ucrSaveModel.SetIsComboBox()
        ucrSaveModel.SetAssignToIfUncheckedValue("last_model")
    End Sub

    Private Sub SetDefaults()
        clsSpeiFunction = New RFunction
        clsSpiFunction = New RFunction
        clsListFunction = New RFunction
        clsAsVectorFunction = New RFunction
        clsSummaryFunction = New RFunction

        clsDolarOperator = New ROperator

        ucrBase.clsRsyntax.ClearCodes()

        ucrSelectorVariable.Reset()
        ucrSaveIndex.Reset()
        ucrSaveModel.Reset()
        ucrReceiverData.SetMeAsReceiver()

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("type", Chr(39) & "rectangular" & Chr(39), iPosition:=0)
        clsListFunction.AddParameter("shift", 0, iPosition:=1)

        clsSpiFunction.SetPackageName("SPEI")
        clsSpiFunction.SetRCommand("spi")
        clsSpiFunction.AddParameter("scale", 1, iPosition:=1)
        clsSpiFunction.AddParameter("na.rm", "TRUE", iPosition:=5)
        clsSpiFunction.AddParameter("kernel", clsRFunctionParameter:=clsListFunction, iPosition:=2)
        clsSpiFunction.SetAssignTo("last_model", strTempDataframe:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)

        clsSpeiFunction.SetPackageName("SPEI")
        clsSpeiFunction.SetRCommand("spei")
        clsSpeiFunction.AddParameter("scale", 1, iPosition:=1)
        clsSpeiFunction.AddParameter("na.rm", "TRUE", iPosition:=5)
        clsSpeiFunction.AddParameter("kernel", clsRFunctionParameter:=clsListFunction, iPosition:=2)
        clsSpeiFunction.SetAssignTo("last_model", strTempDataframe:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempModel:="last_model", bAssignToIsPrefix:=True)

        clsSummaryFunction.SetRCommand("summary")
        clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsSpiFunction)

        clsAsVectorFunction.SetRCommand("as.vector")
        clsAsVectorFunction.AddParameter("x", clsROperatorParameter:=clsDolarOperator)

        clsDolarOperator.SetOperation("$")
        clsDolarOperator.AddParameter("model", clsRFunctionParameter:=clsSpiFunction, iPosition:=0)
        clsDolarOperator.AddParameter("fitted", "fitted", iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsAsVectorFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudTimeScale.AddAdditionalCodeParameterPair(clsSpeiFunction, New RParameter("scale", 1), iAdditionalPairNo:=1)
        ucrChkOmitMissingValues.AddAdditionalCodeParameterPair(clsSpeiFunction, New RParameter("na.rm", 6), iAdditionalPairNo:=1)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsSpeiFunction, New RParameter("data", 0), iAdditionalPairNo:=1)

        ucrReceiverData.SetRCode(clsSpiFunction, bReset)
        ucrChkOmitMissingValues.SetRCode(clsSpiFunction, bReset)
        ucrNudTimeScale.SetRCode(clsSpiFunction, bReset)
        ucrPnlKernelType.SetRCode(clsListFunction, bReset)
        ucrNudKernelShift.SetRCode(clsListFunction, bReset)
        ucrPnlIndex.SetRCode(clsSummaryFunction, bReset)
        ucrSaveIndex.SetRCode(clsAsVectorFunction, bReset)
        ucrSaveModel.AddAdditionalRCode(clsSpiFunction, bReset)
        ucrSaveModel.SetRCode(clsSpeiFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverData.IsEmpty AndAlso ucrSaveIndex.IsComplete Then
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
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsSpiFunction)
            clsDolarOperator.AddParameter("model", clsRFunctionParameter:=clsSpiFunction, iPosition:=0)
            ucrSaveIndex.SetPrefix("spi")
            ucrSaveModel.SetPrefix("spi_mod")
        ElseIf rdoSPEI.Checked Then
            clsSummaryFunction.AddParameter("object", clsRFunctionParameter:=clsSpeiFunction)
            clsDolarOperator.AddParameter("model", clsRFunctionParameter:=clsSpeiFunction, iPosition:=0)
            ucrSaveIndex.SetPrefix("spei")
            ucrSaveModel.SetPrefix("spei_mod")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged, ucrSaveIndex.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class