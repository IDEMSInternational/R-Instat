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

Public Class dlgClimograph
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsGgwalterliethFunction, clsDummyFunction As RFunction
    Private clsBaseOperator As New ROperator

    Private Sub dlgClimograph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrSelectorClimograph.SetParameter(New RParameter("data", 0))
        ucrSelectorClimograph.SetParameterIsrfunction()

        ucrPnlClimograph.AddRadioButton(rdoClimograph)
        ucrPnlClimograph.AddRadioButton(rdoWalterLieth)
        ucrPnlClimograph.AddParameterValuesCondition(rdoWalterLieth, "checked", "WalterLieth")
        ucrPnlClimograph.AddParameterValuesCondition(rdoClimograph, "checked", "Climograph")
        ' ucrPnlClimograph.SetRDefault(rdoWalterLieth)

        ucrReceiverMonth.SetParameter(New RParameter("month", 1))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorClimograph
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        ucrReceiverRain.SetParameter(New RParameter("p_mes", 3))
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.Selector = ucrSelectorClimograph
        ucrReceiverRain.SetClimaticType("rain")
        ucrReceiverRain.bAutoFill = True
        ucrReceiverRain.strSelectorHeading = "Rain Variables"
        ucrReceiverRain.SetLinkedDisplayControl(lblRain)

        ucrReceiverMaxtem.SetParameter(New RParameter("tm_max", 4))
        ucrReceiverMaxtem.SetParameterIsString()
        ucrReceiverMaxtem.Selector = ucrSelectorClimograph
        ucrReceiverMaxtem.SetClimaticType("temp_max")
        ucrReceiverMaxtem.bAutoFill = True
        ucrReceiverMaxtem.strSelectorHeading = "Variables"
        ucrReceiverMaxtem.SetLinkedDisplayControl(lblMaxtem)

        ucrReceiverMintemp.SetParameter(New RParameter("tm_min", 5))
        ucrReceiverMintemp.SetParameterIsString()
        ucrReceiverMintemp.Selector = ucrSelectorClimograph
        ucrReceiverMintemp.SetClimaticType("temp_min")
        ucrReceiverMintemp.bAutoFill = True
        ucrReceiverMintemp.strSelectorHeading = "Variables"
        ucrReceiverMintemp.SetLinkedDisplayControl(lblMintem)

        ucrReceiverAbsolutetem.SetParameter(New RParameter("ta_min", 6))
        ucrReceiverAbsolutetem.SetParameterIsString()
        ucrReceiverAbsolutetem.Selector = ucrSelectorClimograph
        ucrReceiverAbsolutetem.strSelectorHeading = "Variables"
        ucrReceiverAbsolutetem.SetLinkedDisplayControl(lblAbsoluteTemp)

        ucrReceiverStation.SetParameter(New RParameter("station", 2))
        ucrReceiverStation.Selector = ucrSelectorClimograph
        ucrReceiverStation.SetClimaticType("station")
        ucrReceiverStation.bAutoFill = True
        ucrReceiverStation.strSelectorHeading = "Factors"
        ucrReceiverStation.SetParameterIsString()

        ucrSave.SetPrefix("graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save")
        ucrSave.SetDataFrameSelector(ucrSelectorClimograph.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsGgwalterliethFunction = New RFunction
        clsBaseOperator = New ROperator
        clsDummyFunction = New RFunction

        ucrSelectorClimograph.Reset()
        ucrSave.Reset()

        ucrReceiverMonth.SetMeAsReceiver()

        clsDummyFunction.AddParameter("checked", "WalterLieth", iPosition:=0)

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggwalter_lieth", clsRFunctionParameter:=clsGgwalterliethFunction, iPosition:=0)

        clsGgwalterliethFunction.SetRCommand("ggwalter_lieth")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrSelectorClimograph.SetRCode(clsGgwalterliethFunction, bReset)
        ucrPnlClimograph.SetRCode(clsDummyFunction, bReset)
        ucrReceiverMonth.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverRain.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMintemp.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMaxtem.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverAbsolutetem.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverStation.SetRCode(clsGgwalterliethFunction, bReset)
        ucrSave.SetRCode(clsGgwalterliethFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoWalterLieth.Checked Then
            If (Not ucrReceiverAbsolutetem.IsEmpty AndAlso Not ucrReceiverMaxtem.IsEmpty AndAlso Not ucrReceiverMintemp.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverRain.IsEmpty) OrElse Not ucrSave.IsComplete Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        End If
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlClimograph.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverAbsolutetem.ControlContentsChanged, ucrReceiverMaxtem.ControlContentsChanged, ucrReceiverMintemp.ControlContentsChanged, ucrReceiverStation.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class