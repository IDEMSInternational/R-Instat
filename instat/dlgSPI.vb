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
    Private bResetSubdialog As Boolean = False
    Private clsSPIFunction, clsSPEIFunction, clsLISTFunction, clsPRINTSPIFunction, clsPRINTSPEIFunction As New RFunction

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
        ucrBase.iHelpTopicID = 510

        ucrSelectorVariable.SetParameterIsString()
        ucrReceiverDate.SetParameterIsString()

        'receivers:
        ' by receivers
        ucrReceiverData.SetParameterIsRFunction()
        ucrReceiverData.SetParameter(New RParameter("data", 0))
        ucrReceiverData.Selector = ucrSelectorVariable
        ucrReceiverData.bAutoFill = True
        ucrReceiverData.strSelectorHeading = "Variables"

        ucrReceiverYear.SetParameterIsString()
        ucrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        ucrReceiverYear.strSelectorHeading = "Year Variables"

        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorVariable
        ucrReceiverMonth.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)})
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"

        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorVariable
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        'setting up Nuds

        ucrTimeScale.SetParameter(New RParameter("scale", 1))
        ucrTimeScale.SetMinMax(1, 24)

        ' others

        ucrReceiverDate.SetParameterIsString()
        ucrReceiverDate.Selector = ucrSelectorVariable
        ucrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        ucrReceiverDate.bAutoFill = True
        ucrReceiverDate.strSelectorHeading = "Date Variables"

        ucrChkOmitMissingValues.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissingValues.SetText("Omit Missing Values")
        ucrChkOmitMissingValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissingValues.SetRDefault("FALSE")

        'panel

        ucrPnlType.SetParameter(New RParameter("type", 0))
        ucrPnlType.AddRadioButton(RdoTri, Chr(34) & "triangular" & Chr(34))
        ucrPnlType.AddRadioButton(Rdocirc, Chr(34) & "circular" & Chr(34))
        ucrPnlType.AddRadioButton(RdoRect, Chr(34) & "rectangular" & Chr(34))
        ucrPnlType.AddRadioButton(RdoGaus, Chr(34) & "gaussian" & Chr(34))
        ucrPnlType.SetRDefault(Chr(34) & "rectangular" & Chr(34))

        'ucrshift
        ucrKernShift.SetParameter(New RParameter("shift", 1))
        ucrKernShift.SetMinMax(0, 24)

        'ucrpnlInd
        ucrPnlInd.AddRadioButton(rdoSPI)
        ucrPnlInd.AddRadioButton(rdoSPEI)

    End Sub

    Private Sub SetDefaults()
        clsSPEIFunction = New RFunction
        clsSPIFunction = New RFunction
        clsLISTFunction = New RFunction
        clsPRINTSPIFunction = New RFunction
        clsPRINTSPEIFunction = New RFunction

        ucrSelectorVariable.Reset()

        clsLISTFunction.SetRCommand("list")
        clsLISTFunction.AddParameter("type", Chr(34) & "rectangular" & Chr(34), iPosition:=0)
        clsLISTFunction.AddParameter("shift", 0, iPosition:=1)

        clsSPIFunction.SetPackageName("SPEI")
        clsSPIFunction.SetRCommand("spi")
        clsSPIFunction.AddParameter("scale", 1, iPosition:=1)
        clsSPIFunction.AddParameter("kernel", clsRFunctionParameter:=clsLISTFunction, iPosition:=2)

        clsSPEIFunction.SetPackageName("SPEI")
        clsSPEIFunction.SetRCommand("spei")
        clsSPEIFunction.AddParameter("scale", 1, iPosition:=1)
        clsSPEIFunction.AddParameter("kernel", clsRFunctionParameter:=clsLISTFunction, iPosition:=2)

        ucrSaveIndex.SetSaveTypeAsColumn()
        ucrSaveIndex.SetDataFrameSelector(ucrSelectorVariable.ucrAvailableDataFrames)
        ucrSaveIndex.SetLabelText("Save Index into:")
        ucrSaveIndex.SetIsTextBox()
        ucrSaveIndex.SetAssignToBooleans(bTempAssignToIsPrefix:=True)

        clsPRINTSPIFunction.SetRCommand("print")
        clsPRINTSPIFunction.AddParameter(clsRFunctionParameter:=clsSPIFunction)
        clsPRINTSPEIFunction.SetRCommand("print")
        clsPRINTSPEIFunction.AddParameter(clsRFunctionParameter:=clsSPEIFunction)

        ucrBase.clsRsyntax.SetBaseRFunction(clsPRINTSPIFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrTimeScale.SetRCode(clsSPIFunction, bReset)
        ucrTimeScale.AddAdditionalCodeParameterPair(clsSPEIFunction, New RParameter("scale"), iAdditionalPairNo:=1)
        ucrChkOmitMissingValues.SetRCode(clsSPIFunction, bReset)
        ucrChkOmitMissingValues.AddAdditionalCodeParameterPair(clsSPEIFunction, New RParameter("na.rm"), iAdditionalPairNo:=1)
        ucrReceiverData.SetRCode(clsSPIFunction, bReset)
        ucrReceiverData.AddAdditionalCodeParameterPair(clsSPEIFunction, New RParameter("data"), iAdditionalPairNo:=1)
        ucrPnlType.SetRCode(clsSPEIFunction, bReset)
        ucrPnlType.SetRCode(clsSPIFunction, bReset)
        ucrPnlType.SetRCode(clsLISTFunction, bReset)
        ucrKernShift.SetRCode(clsLISTFunction, bReset)
        ucrSaveIndex.SetRCode(clsPRINTSPIFunction, bReset)
        ucrSaveIndex.SetRCode(clsPRINTSPEIFunction, bReset)

    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverData.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub UcrPnlInd_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlInd.ControlContentsChanged
        If rdoSPI.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPRINTSPIFunction)
            clsPRINTSPIFunction.SetAssignTo("spi", strTempDataframe:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="spi", bAssignToIsPrefix:=True)
            ucrSaveIndex.SetPrefix("spi")
        ElseIf rdoSPEI.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsPRINTSPEIFunction)
            clsPRINTSPEIFunction.SetAssignTo("spei", strTempDataframe:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="spei", bAssignToIsPrefix:=True)
            ucrSaveIndex.SetPrefix("spei")
        Else
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class