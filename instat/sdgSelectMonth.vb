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
Public Class sdgSelectMonth
    Private ucrReceiverMonth As ucrReceiverSingle
    Private clsInOperator As New ROperator
    Private clsFilterMonthFunction As New RFunction
    Private clsListCalcFunction As New RFunction

    Private Sub sdgSelectMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiseControls()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrMonthAsFactor.strSelectorColumnName = "Omit Level"
        ucrMonthAsFactor.SetAsMultipleSelector()
        ucrMonthAsFactor.SetReceiver(ucrReceiverMonth)
        ucrMonthAsFactor.SetIncludeLevels(False)
        ucrMonthAsFactor.bIncludeNA = False
    End Sub

    Public Sub SetRCode(Optional clsNewInOperator As ROperator = Nothing, Optional clsNewListCalcFunction As RFunction = Nothing, Optional clsNewFilterMonthFunction As RFunction = Nothing, Optional ucrNewReceiverMonth As ucrReceiverSingle = Nothing, Optional bReset As Boolean = False)
        ucrReceiverMonth = ucrNewReceiverMonth
        clsInOperator = clsNewInOperator
        clsFilterMonthFunction = clsNewFilterMonthFunction
        clsListCalcFunction = clsNewListCalcFunction
    End Sub

    Private Sub ucrMonthAsFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrMonthAsFactor.ControlValueChanged
        clsInOperator.AddParameter("months", ucrMonthAsFactor.GetSelectedLevels(), iPosition:=1)
        If ucrMonthAsFactor.GetSelectedLevels.Count > 0 Then
            clsListCalcFunction.AddParameter("month_filter", clsRFunctionParameter:=clsFilterMonthFunction, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsListCalcFunction.RemoveParameterByName("month_filter")
        End If
    End Sub
End Class