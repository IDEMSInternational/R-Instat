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

    Private Sub sdgSelectMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        InitialiseControls()
    End Sub

    Private Sub InitialiseControls()
        ucrMonthAsFactor.strSelectorColumnName = "Omit Level"
        ucrMonthAsFactor.SetAsMultipleSelector()
        ucrMonthAsFactor.SetReceiver(ucrReceiverMonth)
        ucrMonthAsFactor.SetIncludeLevels(False)
        ucrMonthAsFactor.bIncludeNA = False
    End Sub

    Public Sub SetRCode(Optional clsNewInOperator As ROperator = Nothing, Optional ucrNewReceiverMonth As ucrReceiverSingle = Nothing, Optional bReset As Boolean = False)
        ucrReceiverMonth = ucrNewReceiverMonth
        clsInOperator = clsNewInOperator
    End Sub

    Private Sub ucrMonthAsFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrMonthAsFactor.ControlValueChanged
        clsInOperator.AddParameter("months", ucrMonthAsFactor.GetSelectedLevels(), iPosition:=1)
    End Sub
End Class