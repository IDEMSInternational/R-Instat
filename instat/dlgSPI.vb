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
    Private clsSpiFunction, clsSpeiFunction, clsListFunction As New RFunction

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

        'receivers:
        ' by receivers
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
        ucrNudTimeScale.SetMinMax(1, 24)

        ' others
        ucrChkOmitMissingValues.SetParameter(New RParameter("na.rm", 5))
        ucrChkOmitMissingValues.SetText("Omit Missing Values")
        ucrChkOmitMissingValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissingValues.SetRDefault("FALSE")

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
        ucrPnlIndex.AddFunctionNamesCondition(rdoSPI, "spi")
        ucrPnlIndex.AddFunctionNamesCondition(rdoSPEI, "spei")

        ucrSaveIndex.SetSaveTypeAsColumn()
        ucrSaveIndex.SetDataFrameSelector(ucrSelectorVariable.ucrAvailableDataFrames)
        ucrSaveIndex.SetLabelText("Save Index into:")
        ucrSaveIndex.SetIsTextBox()
        ucrSaveIndex.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
    End Sub

    Private Sub SetDefaults()
        clsSpeiFunction = New RFunction
        clsSpiFunction = New RFunction
        clsListFunction = New RFunction

        ucrSelectorVariable.Reset()
        ucrReceiverData.SetMeAsReceiver()

        clsListFunction.SetRCommand("list")
        clsListFunction.AddParameter("type", Chr(39) & "rectangular" & Chr(39), iPosition:=0)
        clsListFunction.AddParameter("shift", 0, iPosition:=1)

        clsSpiFunction.SetPackageName("SPEI")
        clsSpiFunction.SetRCommand("spi")
        clsSpiFunction.AddParameter("scale", 1, iPosition:=1)
        clsSpiFunction.AddParameter("kernel", clsRFunctionParameter:=clsListFunction, iPosition:=2)

        clsSpeiFunction.SetPackageName("SPEI")
        clsSpeiFunction.SetRCommand("spei")
        clsSpeiFunction.AddParameter("scale", 1, iPosition:=1)
        clsSpeiFunction.AddParameter("kernel", clsRFunctionParameter:=clsListFunction, iPosition:=2)

        ucrBase.clsRsyntax.SetBaseRFunction(clsSpiFunction)
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
        ucrPnlIndex.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        'ucrSaveIndex.AddAdditionalRCode(clsSpeiFunction, iAdditionalPairNo:=1)
        'ucrSaveIndex.SetRCode(clsSpiFunction, bReset)
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

    Private Sub ucrPnlIndex_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlIndex.ControlContentsChanged
        If rdoSPI.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSpiFunction)
            'clsSpiFunction.SetAssignTo("spi", strTempDataframe:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="spi", bAssignToIsPrefix:=True)
            ucrSaveIndex.SetPrefix("spi")
        ElseIf rdoSPEI.Checked Then
            ucrBase.clsRsyntax.SetBaseRFunction(clsSpeiFunction)
            'clsSpeiFunction.SetAssignTo("spei", strTempDataframe:=ucrSelectorVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:="spei", bAssignToIsPrefix:=True)
            ucrSaveIndex.SetPrefix("spei")
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class