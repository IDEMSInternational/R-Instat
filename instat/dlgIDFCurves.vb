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
Public Class dlgIDFCurves
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetRCode As Boolean = True
    Private clsIDFCurvesFunction As New RFunction
    Private clsVarsColumnsOperator As ROperator

    Private Sub dlgIDFCurves_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrIDFCurvesSelector.SetParameter(New RParameter("prdat", 0))
        ucrIDFCurvesSelector.SetParameterIsrfunction()

        ucrReceiverDateTime.SetParameter(New RParameter("clmn", 1))
        ucrReceiverDateTime.Selector = ucrIDFCurvesSelector

        ucrReceiverPrec.SetParameter(New RParameter("clmn", 1))
        ucrReceiverPrec.Selector = ucrIDFCurvesSelector

        ucrStationName.SetParameter(New RParameter("stname", 2))

        ucrNudMaxPrec.SetParameter(New RParameter("mindpy", 3))
        ucrNudMaxPrec.SetMinMax(0, 1)
        ucrNudMaxPrec.Increment = 0.1

    End Sub

    Private Sub SetDefaults()
        clsIDFCurvesFunction = New RFunction
        clsVarsColumnsOperator = New ROperator

        ucrIDFCurvesSelector.Reset()
        ucrReceiverDateTime.SetMeAsReceiver()

        clsIDFCurvesFunction.SetPackageName("climatol")
        clsIDFCurvesFunction.SetRCommand("IDFcurves")
        clsIDFCurvesFunction.AddParameter("na.code", "NA", iPosition:=0)

        clsVarsColumnsOperator.SetOperation("", bBracketsTemp:=False)
        clsVarsColumnsOperator.SetAssignTo("var_2")

        ucrBase.clsRsyntax.SetBaseRFunction(clsIDFCurvesFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrIDFCurvesSelector.SetRCode(clsIDFCurvesFunction, bReset)
        ucrReceiverDateTime.SetRCode(clsIDFCurvesFunction, bReset)

    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverDateTime_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDateTime.ControlValueChanged

    End Sub

    Private Sub ucrReceiverPrec_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPrec.ControlValueChanged

    End Sub

    Private Sub ucrNudMaxPrec_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudMaxPrec.ControlValueChanged

    End Sub

    Private Sub ucrStationName_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrStationName.ControlValueChanged

    End Sub
End Class