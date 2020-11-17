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

Public Class dlgCircularDensityPlot
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDensityFunction As RFunction
    Private Sub dlgCircularDensityPlot_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 3
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrSelectorDataFrame.SetParameter(New RParameter("data", 0))
        ucrSelectorDataFrame.SetParameterIsrfunction()

        ucrReceiverVariable.SetParameter(New RParameter("x", 0))
        ucrReceiverVariable.Selector = ucrSelectorDataFrame
        'ucrReceiverVariable.SetParameterIsString()
        ucrReceiverVariable.SetIncludedDataTypes({"numeric"})
        ucrReceiverVariable.strSelectorHeading = "Numerics"
        ucrReceiverVariable.bWithQuotes = False

        ucrSaveDensity.SetPrefix("circular_density")
        ucrSaveDensity.SetDataFrameSelector(ucrSelectorDataFrame.ucrAvailableDataFrames)
        ucrSaveDensity.SetIsComboBox()
        ucrSaveDensity.SetCheckBoxText("Save Graph")
        ucrSaveDensity.SetSaveTypeAsGraph()
        ucrSaveDensity.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsDensityFunction = New RFunction

        ucrSaveDensity.Reset()
        ucrReceiverVariable.SetMeAsReceiver()
        ucrSelectorDataFrame.Reset()

        clsDensityFunction.SetPackageName("circular")
        clsDensityFunction.SetRCommand("density.circular")
        clsDensityFunction.AddParameter("adjust", "1", iPosition:=1)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDensityFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverVariable.SetRCode(clsDensityFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        'If ucrReceiverVariable.IsEmpty Then
        '    ucrBase.OKEnabled(False)
        'Else
        '    ucrBase.OKEnabled(True)
        'End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
End Class