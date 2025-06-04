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
Public Class sdgInventoryOptions
    Private clsInventoryFunction, clsListFunction, clsKeyColourLabelFunction, clsBreaksFunction, clslabelsFunction, clsKeyMissingFunction As New RFunction
    Private bControlsInitialised As Boolean = False
    Public bRCodeSet As Boolean = False

    Private Sub sdgInventoryOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()

        Dim lstControls As New List(Of Control)
        lstControls.AddRange({grpDisplayraindays, lblRainLabel})

        ucrColourMissing.SetParameter(New RParameter("var1", 0, False))
        ucrColourMissing.SetRDefault("red")
        ucrColorsNonMissing.SetParameter(New RParameter("var2", 1, False))
        ucrColorsNonMissing.SetRDefault("grey")

        ucrChkDisplayRainday.SetParameter(New RParameter("display_rain_days", 13), bNewChangeParameterValue:=True)
        ucrChkDisplayRainday.SetText("Display Rain Days")
        ucrChkDisplayRainday.SetRDefault("FALSE")
        ucrChkDisplayRainday.AddParameterPresentCondition(True, "display_rain_days", True)
        ucrChkDisplayRainday.AddToLinkedControls(ucrInputRainLabel, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Rain")
        ucrChkDisplayRainday.AddToLinkedControls(ucrInputDryLabel, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="Dry")

        ucrInputRainLabel.SetParameter(New RParameter("rain", 0, False))
        ucrInputRainLabel.SetLinkedDisplayControl(lstControls)

        ucrInputDryLabel.SetParameter(New RParameter("dry", 1, False))
        ucrInputDryLabel.SetLinkedDisplayControl(lblDryLabel)

        ucrChkDisplayRainday.AddToLinkedControls(ucrNudRainThreshold, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.85")
        ucrNudRainThreshold.SetParameter(New RParameter("x", 1, False))
        ucrNudRainThreshold.Increment = 0.01
        ucrNudRainThreshold.DecimalPlaces = 2
        ucrNudRainThreshold.SetMinMax(0, 10)
        ucrNudRainThreshold.SetLinkedDisplayControl(lblRainThreshold)

        ucrChkDisplayRainday.AddToLinkedControls(ucrColorsRain, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="green")
        ucrColorsRain.SetLinkedDisplayControl(lblRainColour)
        ucrColorsRain.SetParameter(New RParameter("rain", 0, False))
        'ucrColorsRainColour.SetRDefault("tan3")

        ucrChkDisplayRainday.AddToLinkedControls(ucrColorsDryColour, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrColorsDryColour.SetLinkedDisplayControl(lblDryColour)
        ucrColorsDryColour.SetParameter(New RParameter("dry", 1, False))
        ucrColorsDryColour.SetRDefault("blue")

        bControlsInitialised = True
    End Sub

    Public Sub SetRCode(clsNewInventoryFunction As RFunction, Optional bReset As Boolean = False)
        bRCodeSet = False
        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        clsInventoryFunction = clsNewInventoryFunction

        clsKeyColourLabelFunction = New RFunction
        clsBreaksFunction = New RFunction
        clslabelsFunction = New RFunction
        clsKeyMissingFunction = New RFunction
        clsListFunction = New RFunction

        clsKeyColourLabelFunction.SetRCommand("c")

        clsBreaksFunction.SetRCommand("c")
        clsBreaksFunction.AddParameter("min", "0", iPosition:=0, bIncludeArgumentName:=False)
        clsBreaksFunction.AddParameter("max", "Inf", iPosition:=2, bIncludeArgumentName:=False)
        clsListFunction.AddParameter("breaks", clsRFunctionParameter:=clsBreaksFunction)

        clslabelsFunction.SetRCommand("c")

        clsKeyMissingFunction.SetRCommand("c")

        clsListFunction.SetRCommand("list")

        ucrColorsRain.SetRCode(clsKeyColourLabelFunction, bReset)
        If bReset Then
            ucrColorsDryColour.SetRCode(clsKeyColourLabelFunction, bReset)
            ucrNudRainThreshold.SetRCode(clsBreaksFunction, bReset)
            ucrInputDryLabel.SetRCode(clslabelsFunction, bReset)
            ucrInputRainLabel.SetRCode(clslabelsFunction, bReset)
            ucrChkDisplayRainday.SetRCode(clsInventoryFunction, bReset)
            ucrColorsNonMissing.SetRCode(clsKeyMissingFunction, bReset)
            ucrColourMissing.SetRCode(clsKeyMissingFunction, bReset)
        End If
        bRCodeSet = True
    End Sub

    Private Sub ucrChkDisplayRainday_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkDisplayRainday.ControlValueChanged
        If ucrChkDisplayRainday.Checked Then
            clsInventoryFunction.AddParameter("display_rain_days", "TRUE")
            clsInventoryFunction.AddParameter("rain_cats", clsRFunctionParameter:=clsListFunction)
            UpdateRaindrycolors()
        Else
            clsInventoryFunction.AddParameter("display_rain_days", "FALSE")
            clsInventoryFunction.RemoveParameterByName("rain_cats")
        End If

    End Sub

    Private Sub ucrInputRainLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputRainLabel.ControlValueChanged, ucrInputDryLabel.ControlValueChanged
        If bRCodeSet Then
            If Not ucrInputRainLabel.IsEmpty Then
                clslabelsFunction.AddParameter("rain", Chr(34) & ucrInputRainLabel.GetText() & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            Else
                clslabelsFunction.RemoveParameterByName("rain")
            End If
            If Not ucrInputDryLabel.IsEmpty Then
                clslabelsFunction.AddParameter("dry", Chr(34) & ucrInputDryLabel.GetText() & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
            Else
                clslabelsFunction.RemoveParameterByName("dry")
            End If
        End If
        clsListFunction.AddParameter("labels", clsRFunctionParameter:=clslabelsFunction)

    End Sub

    Private Sub ucrNudRainThreshold_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudRainThreshold.ControlValueChanged
        If bRCodeSet Then
            If Not ucrNudRainThreshold.IsEmpty Then
                clsBreaksFunction.AddParameter("x", ucrNudRainThreshold.GetText(), iPosition:=1, bIncludeArgumentName:=False)
                clsListFunction.AddParameter("breaks", clsRFunctionParameter:=clsBreaksFunction)
            Else
                clsBreaksFunction.RemoveParameterByName("x")
                clsListFunction.RemoveParameterByName("breaks")
            End If
        End If
    End Sub

    Private Sub UpdateamissingColour()
        If bRCodeSet Then
            If Not ucrColourMissing.IsEmpty Then
                clsKeyMissingFunction.AddParameter("var1", Chr(34) & ucrColourMissing.GetText() & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            Else
                clsKeyMissingFunction.RemoveParameterByName("var1")
            End If
            If Not ucrColorsNonMissing.IsEmpty Then
                clsKeyMissingFunction.AddParameter("var2", Chr(34) & ucrColorsNonMissing.GetText() & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsKeyMissingFunction.RemoveParameterByName("var2")
            End If
        End If
        clsInventoryFunction.AddParameter("key_colours", clsRFunctionParameter:=clsKeyMissingFunction)
    End Sub

    Private Sub ucrColorsNonMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrColorsNonMissing.ControlValueChanged
        UpdateamissingColour()
    End Sub

    Private Sub ucrColourMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrColourMissing.ControlValueChanged
        UpdateamissingColour()
    End Sub

    Private Sub UpdateRaindrycolors()
        If bRCodeSet Then
            If Not ucrColorsRain.IsEmpty Then
                clsKeyColourLabelFunction.AddParameter("rain", Chr(34) & ucrColorsRain.GetText() & Chr(34), iPosition:=0, bIncludeArgumentName:=False)
            Else
                clsKeyColourLabelFunction.RemoveParameterByName("rain")
            End If
            If Not ucrColorsDryColour.IsEmpty Then
                clsKeyColourLabelFunction.AddParameter("dry", Chr(34) & ucrColorsDryColour.GetText() & Chr(34), iPosition:=1, bIncludeArgumentName:=False)
            Else
                clsKeyColourLabelFunction.RemoveParameterByName("dry")
            End If
        End If
        clsListFunction.AddParameter("key_colours", clsRFunctionParameter:=clsKeyColourLabelFunction)

    End Sub

    Private Sub ucrColorsDryColour_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrColorsDryColour.ControlValueChanged
        UpdateRaindrycolors()
    End Sub

    Private Sub ucrColorsRain_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrColorsRain.ControlValueChanged
        UpdateRaindrycolors()
    End Sub
End Class