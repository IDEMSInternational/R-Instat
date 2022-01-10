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
Public Class dlgCircular
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsCircularFunction As New RFunction
    Private Sub dlgCircular_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverCircular.Selector = ucrSelectorCircular
        ucrReceiverCircular.SetMeAsReceiver()

        ucrReceiverCircular.SetParameter(New RParameter("x", 0))
        ucrReceiverCircular.SetParameterIsRFunction()

        ucrPnlModulo.SetParameter(New RParameter("modulo", 1))
        ucrPnlModulo.AddRadioButton(rdoAsis, Chr(34) & "asis" & Chr(34))
        ucrPnlModulo.AddRadioButton(rdo2Pi, Chr(34) & "2pi" & Chr(34))
        ucrPnlModulo.AddRadioButton(rdoPi, Chr(34) & "pi" & Chr(34))

        ucrPnlUnits.SetParameter(New RParameter("units", 2))
        ucrPnlUnits.AddRadioButton(rdoDegrees, Chr(34) & "degrees" & Chr(34))
        ucrPnlUnits.AddRadioButton(rdoHours, Chr(34) & "hours" & Chr(34))
        ucrPnlUnits.AddRadioButton(rdoRadians, Chr(34) & "radians" & Chr(34))

        ucrPnlTemplate.SetParameter(New RParameter("template", 3))
        ucrPnlTemplate.AddRadioButton(rdoNone, Chr(34) & "none" & Chr(34))
        ucrPnlTemplate.AddRadioButton(rdoGeographics, Chr(34) & "geographics" & Chr(34))
        ucrPnlTemplate.AddRadioButton(rdoClock12, Chr(34) & "clock12" & Chr(34))
        ucrPnlTemplate.AddRadioButton(rdoClock24, Chr(34) & "clock24" & Chr(34))

        ucrSaveCircularColumn.SetPrefix("circ")
        ucrSaveCircularColumn.SetSaveTypeAsColumn()
        ucrSaveCircularColumn.SetDataFrameSelector(ucrSelectorCircular.ucrAvailableDataFrames)
        ucrSaveCircularColumn.SetLabelText("New Column Name:")
        ucrSaveCircularColumn.SetIsComboBox()
    End Sub

    Private Sub SetDefaults()
        clsCircularFunction = New RFunction

        ucrSelectorCircular.Reset()
        ucrSaveCircularColumn.Reset()
        clsCircularFunction.SetPackageName("circular")
        clsCircularFunction.SetRCommand("circular")

        clsCircularFunction.AddParameter("units", Chr(34) & "radians" & Chr(34), iPosition:=2)
        clsCircularFunction.AddParameter("modulo", Chr(34) & "asis" & Chr(34), iPosition:=1)
        clsCircularFunction.AddParameter("template", Chr(34) & "none" & Chr(34), iPosition:=3)


        clsCircularFunction.SetAssignTo(ucrSaveCircularColumn.GetText, strTempDataframe:=ucrSelectorCircular.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveCircularColumn.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsCircularFunction)
    End Sub

    Private Sub SetRcodeforControls(breset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, breset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRcodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub TestOkEnabled()
        If ucrReceiverCircular.IsEmpty OrElse Not ucrSaveCircularColumn.IsComplete Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrReceiverCircular_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverCircular.ControlContentsChanged, ucrSaveCircularColumn.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class