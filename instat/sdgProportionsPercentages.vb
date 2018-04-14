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
Public Class sdgProportionsPercentages
    Public bFirstLoad As Boolean = True
    Public bControlsInitialised As Boolean = False
    Public clsDefaultFunction As RFunction

    Private Sub sdgProportionsPercentages_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrPnlBY.AddRadioButton(rdoByFactors)
        ucrPnlBY.AddRadioButton(rdoByFilter)
        ucrPnlBY.AddRadioButton(rdoByColumn)
        ucrPnlBY.AddParameterPresentCondition(rdoByFactors, "perc_total_factors")
        ucrPnlBY.AddParameterPresentCondition(rdoByFilter, "perc_total_filter")
        ucrPnlBY.AddParameterPresentCondition(rdoByColumn, "perc_total_columns")
        rdoByColumn.Enabled = False
        rdoByFilter.Enabled = False

        ucrReceiverByFactor.Selector = ucrSelectorProportionsPercentiles
        ucrReceiverColumn.Selector = ucrSelectorProportionsPercentiles
        ucrReceiverFilter.Selector = ucrSelectorProportionsPercentiles
        ucrReceiverByFactor.SetMeAsReceiver()

        ucrReceiverByFactor.SetParameter(New RParameter("perc_total_factors"))
        ucrReceiverByFactor.SetParameterIsString()
        ucrReceiverColumn.SetMeAsReceiver()

        ucrChkDisplayAsDecimal.SetParameter(New RParameter("perc_decimal"))
        ucrChkDisplayAsDecimal.SetText("Display as decimal")
        ucrChkDisplayAsDecimal.SetRDefault("FALSE")

        ucrChkProportionsPercentages.SetParameter(New RParameter("percentage_type"))
        ucrChkProportionsPercentages.SetValuesCheckedAndUnchecked(Chr(34) & "factors" & Chr(34), Chr(34) & "none" & Chr(34))
        ucrChkProportionsPercentages.SetRDefault(Chr(34) & "none" & Chr(34))
        ucrChkProportionsPercentages.SetText("Calculate Proportions or Percentages")

        ucrPnlBY.AddToLinkedControls(ucrReceiverByFactor, objValues:={rdoByFactors}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlBY.AddToLinkedControls(ucrChkDisplayAsDecimal, objValues:={rdoByFactors}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkProportionsPercentages.AddToLinkedControls(ucrPnlBY, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=rdoByFactors)
        ucrChkProportionsPercentages.AddToLinkedControls(ucrSelectorProportionsPercentiles, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlBY.AddToLinkedControls(ucrReceiverColumn, objValues:={rdoByColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlBY.AddToLinkedControls(ucrReceiverFilter, objValues:={rdoByFilter}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrReceiverByFactor.SetLinkedDisplayControl(lblByFactors)
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumn)
        ucrChkDisplayAsDecimal.SetLinkedDisplayControl(grpOptions)
        ucrReceiverFilter.SetLinkedDisplayControl(lblFilter)

        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewDefaultFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsDefaultFunction = clsNewDefaultFunction
        SetRCode(Me, clsDefaultFunction, bReset)
    End Sub

    Private Sub ucrPnlBY_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlBY.ControlContentsChanged
        If rdoByFilter.Checked Then
            ucrReceiverFilter.SetMeAsReceiver()
        ElseIf rdoByFactors.Checked Then
            ucrReceiverByFactor.SetMeAsReceiver()
        ElseIf rdoByColumn.Checked Then
            ucrReceiverColumn.SetMeAsReceiver()
        End If
    End Sub
End Class