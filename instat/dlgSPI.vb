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

Imports instat
Imports instat.Translations
Public Class dlgSPI
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private clsSPIFunction, clsPrintFunction As New RFunction

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
        rdoPET.Enabled = False

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

        UcrtimeScale.SetParameter(New RParameter("scale", 1))
        UcrtimeScale.SetMinMax(1, 24)

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


    End Sub
    Private Sub SetDefaults()
        clsSPIFunction.SetPackageName("SPEI")
        clsSPIFunction.SetRCommand("spei")
        clsPrintFunction.SetRCommand("print")

        clsSPIFunction.AddParameter("data", iPosition:=0)
        clsSPIFunction.AddParameter("na.rm", iPosition:=6)
        clsSPIFunction.AddParameter("scale", 1, iPosition:=1)
        'clsPrintFunction.AddParameter("clsSPIFunction", iPosition:=0)
        ucrBase.clsRsyntax.SetBaseRFunction(clsSPIFunction)



    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        UcrtimeScale.SetRCode(clsSPIFunction, bReset)
        ucrChkOmitMissingValues.SetRCode(clsSPIFunction, bReset)
        ucrReceiverData.SetRCode(clsSPIFunction, bReset)
    End Sub
    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverData.ControlContentsChanged
        TestOKEnabled()
    End Sub
    Private Sub TestOKEnabled()
        If ucrReceiverData.IsEmpty Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub TimeScale_ValueChanged(sender As Object, e As EventArgs)

    End Sub


End Class