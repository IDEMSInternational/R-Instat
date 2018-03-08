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



Public Class SPI
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSPIFunction As New RFunction
    Private Sub SPEI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        UcrBase.clsRsyntax.iCallType = 0
        UcrBase.iHelpTopicID = 510
        rdoPET.Enabled = False

        ucrSelectorVariable.SetParameterIsString()
        UcrReceiverDate.SetParameterIsString()

        'receivers:
        ' by receivers
        UcrReceiverData.SetParameterIsString()
        UcrReceiverData.SetParameter(New RParameter("data", 0))
        UcrReceiverData.Selector = ucrSelectorVariable
        UcrReceiverData.bAutoFill = True
        UcrReceiverData.strSelectorHeading = "Variables"


        UcrReceiverYear.SetParameterIsString()
        UcrReceiverYear.Selector = ucrSelectorVariable
        ucrReceiverYear.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "year" & Chr(34)})
        ucrReceiverYear.bAutoFill = True
        UcrReceiverYear.strSelectorHeading = "Year Variables"

        UcrReceiverMonth.SetParameterIsString()
        UcrReceiverMonth.Selector = ucrSelectorVariable
        UcrReceiverMonth.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)})
        UcrReceiverMonth.bAutoFill = True
        UcrReceiverMonth.strSelectorHeading = "Month Variables"

        UcrReceiverDate.SetParameterIsString()
        UcrReceiverDate.Selector = ucrSelectorVariable
        UcrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "month" & Chr(34)})
        UcrReceiverDate.bAutoFill = True
        UcrReceiverDate.strSelectorHeading = "Date Variables"

        'setting up Nuds



        ' others

        UcrReceiverDate.SetParameterIsString()
        UcrReceiverDate.Selector = ucrSelectorVariable
        UcrReceiverDate.AddIncludedMetadataProperty("Climatic_Type", {Chr(34) & "date" & Chr(34)})
        UcrReceiverDate.bAutoFill = True
        UcrReceiverDate.strSelectorHeading = "Date Variables"

        ucrChkOmitMissingValues.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissingValues.SetText("Omit Missing Values")
        ucrChkOmitMissingValues.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissingValues.SetRDefault("FALSE")

    End Sub
    Private Sub SetDefaults()
        clsSPIFunction.SetPackageName("SPEI")
        clsSPIFunction.SetRCommand("spei")
        clsSPIFunction.AddParameter("data")
        clsSPIFunction.AddParameter("scale")
        clsSPIFunction.AddParameter("na.rm")
        UcrBase.clsRsyntax.SetBaseRFunction(clsSPIFunction)
    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        UcrReceiverData.SetRCode(clsSPIFunction, bReset)
    End Sub
    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles UcrReceiverData.ControlContentsChanged
        TestOKEnabled()
    End Sub
    Private Sub TestOKEnabled()
        If UcrReceiverData.IsEmpty Then
            UcrBase.OKEnabled(False)
        Else
            UcrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub TimeScale_ValueChanged(sender As Object, e As EventArgs) Handles TimeScale.ValueChanged

    End Sub


End Class