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

Imports instat
Imports instat.Translations
Public Class sdgInventoryGraph
    Private bControlsInitialised As Boolean = False
    Private clsInventory As New RFunction
    Private bRCodeSet As Boolean = False


    Private Sub sdgInventoryGraph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub
    Public Sub InitialiseControls()

        ' Titles 
        ucrPnlXAxisTitle.AddRadioButton(rdoAutoXAxis)
        ucrPnlXAxisTitle.AddRadioButton(rdoNoTitleXAxisTitle)
        ucrPnlXAxisTitle.AddRadioButton(rdoSpecifyXAxisTitle)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoAutoXAxis, "label", False)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoNoTitleXAxisTitle, "label", True)
        ucrPnlXAxisTitle.AddParameterValuesCondition(rdoNoTitleXAxisTitle, "label", Chr(34) & Chr(34), True)

        ucrPnlXAxisTitle.AddParameterPresentCondition(rdoSpecifyXAxisTitle, "label", True)
        ucrPnlXAxisTitle.AddParameterValuesCondition(rdoSpecifyXAxisTitle, "label", Chr(34) & Chr(34), False)

        ucrPnlXAxisTitle.AddToLinkedControls(ucrInputXAxisTitle, {rdoSpecifyXAxisTitle}, bNewLinkedHideIfParameterMissing:=True)

        UcrPnlYAxisTitle.AddRadioButton(rdoAutoYAxis)
        UcrPnlYAxisTitle.AddRadioButton(rdoNoYAxisTitle)
        UcrPnlYAxisTitle.AddRadioButton(rdoSpecifyYAxisTitle)

        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoAutoYAxis, "label", False)

        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoNoYAxisTitle, "label", True)
        UcrPnlYAxisTitle.AddParameterValuesCondition(rdoNoYAxisTitle, "label", Chr(34) & Chr(34), True)

        UcrPnlYAxisTitle.AddParameterPresentCondition(rdoSpecifyYAxisTitle, "label", True)
        UcrPnlYAxisTitle.AddParameterValuesCondition(rdoSpecifyYAxisTitle, "label", Chr(34) & Chr(34), False)

        UcrPnlYAxisTitle.AddToLinkedControls(ucrInputYAxisTitle, {rdoSpecifyYAxisTitle}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputXAxisTitle.SetParameter(New RParameter("label"))
        ucrInputYAxisTitle.SetParameter(New RParameter("label"))

        ucrInputGraphTitle.SetParameter(New RParameter("title", 15))

        ucrInputGraphSubTitle.SetParameter(New RParameter("subtitle", 16))

        ucrInputGraphcCaption.SetParameter(New RParameter("caption", 17))

        ucrNudTitleSize.SetParameter(New RParameter("size"))
        ucrNudTitleSize.Increment = 0.1
        ucrNudTitleSize.Minimum = 0

        ucrNudSubTitleSize.SetParameter(New RParameter("size"))
        ucrNudSubTitleSize.Increment = 0.1
        ucrNudSubTitleSize.Minimum = 0

        ucrNudCaptionSize.SetParameter(New RParameter("size"))
        ucrNudCaptionSize.Increment = 0.1
        ucrNudCaptionSize.Minimum = 0

        ucrNudXAxisTitleSize.SetParameter(New RParameter("size"))
        ucrNudXAxisTitleSize.Increment = 0.1
        ucrNudXAxisTitleSize.Minimum = 0

        ucrNudYAxisTitleSize.SetParameter(New RParameter("size"))
        ucrNudYAxisTitleSize.Increment = 0.1
        ucrNudYAxisTitleSize.Minimum = 0

        bControlsInitialised = True
    End Sub
    Public Sub SetRCode(clsInventoryNew As RFunction, Optional bReset As Boolean = False)
        clsInventory = clsInventoryNew

        bRCodeSet = False

        If Not bControlsInitialised Then
            InitialiseControls()
        End If

        ucrNudTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudSubTitleSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)
        ucrNudCaptionSize.SetRCode(clsInventory, bReset, bCloneIfNeeded:=True)

    End Sub

End Class