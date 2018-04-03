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

Public Class sdgDoyRange

    Private clsDoyFilterCalc As RFunction
    Private clsDayFromOperator As ROperator
    Private clsDayToOperator As ROperator
    Private bControlsInitialised As Boolean = False


    Private Sub sdgDoyRange_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub Setup(clsNewDoyFilterCalc As RFunction, clsNewDayFromOperator As ROperator, clsNewDayToOperator As ROperator)
        Dim iFrom As Integer
        Dim iTo As Integer
        Dim clsFromParam As RParameter

        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsDoyFilterCalc = clsNewDoyFilterCalc
        clsDayFromOperator = clsNewDayFromOperator
        clsDayToOperator = clsNewDayToOperator

        clsFromParam = clsDayFromOperator.GetParameter("from")
        If clsFromParam IsNot Nothing AndAlso clsFromParam.bIsString AndAlso clsFromParam.strArgumentValue IsNot Nothing Then
            If Integer.TryParse(clsFromParam.strArgumentValue, iFrom) Then
                rdoFromFixed.Checked = True
                ucrDoyFrom
            End If
        End If
    End Sub

    Public Sub InitialiseControls()
        ucrNudToDiff.SetMinMax(1, 366)
        ucrNudToDiff.SetLinkedDisplayControl(lblToDiff)

        ucrPnlFrom.AddRadioButton(rdoFromFixed)
        ucrPnlFrom.AddRadioButton(rdoFromVariable)
        ucrPnlFrom.AddToLinkedControls(ucrDoyFrom, {rdoFromFixed}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlFrom.AddToLinkedControls(ucrReceiverFrom, {rdoFromVariable}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlTo.AddRadioButton(rdoToFixed)
        ucrPnlTo.AddRadioButton(rdoToVariable)
        ucrPnlTo.AddRadioButton(rdoToFixedDiff)
        ucrPnlTo.AddToLinkedControls(ucrDoyFrom, {rdoToFixed}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTo.AddToLinkedControls(ucrReceiverTo, {rdoToVariable}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlTo.AddToLinkedControls(ucrNudToDiff, {rdoToFixedDiff}, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverFrom.Selector = ucrSelectorDoy
        ucrReceiverTo.Selector = ucrSelectorDoy

        ucrDoyFrom.SetParameterIsNumber()
        ucrDoyTo.SetParameterIsNumber()

        bControlsInitialised = True
    End Sub
End Class