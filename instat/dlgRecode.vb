
' Instat-R
' Copyright (C) 2015
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
' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class dlgRecode
    Private Sub dlgRecode_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrReceiverRecode.Selector = ucrSelectorByDataFrameAddRemove
        ucrReceiverRecode.SetMeAsReceiver()
        autoTranslate(Me)

        ucrNewColumnName.SetDataFrameSelector(ucrSelectorByDataFrameAddRemove.ucrAvailableDataFrames)
        ucrNewColumnName.SetPrefix("Recode")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.cboColumnName.Text, strTempDataframe:=ucrSelectorByDataFrameAddRemove.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.cboColumnName.Text)

    End Sub
    Private Sub ucrReceiverRecode_Leave(sender As Object, e As EventArgs) Handles ucrReceiverRecode.Leave
        ucrBase.clsRsyntax.AddParameter("X", clsRFunctionParameter:=ucrReceiverRecode.GetVariables())

    End Sub


End Class