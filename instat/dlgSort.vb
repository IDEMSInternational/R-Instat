
' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgSort

    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
        ucrReceiverSort.Selector = ucrSelectorByDataFrameAddRemove
        ucrReceiverSort.SetMeAsReceiver()
        ucrBase.clsRsyntax.AddParameter("col_names", clsRFunctionParameter:=ucrReceiverSort.GetVariables())
        autoTranslate(Me)
        rdoLast.Checked = True
        rdoAscending.Checked = True

    End Sub
    Private Sub ucrReceiverSort_Leave(sender As Object, e As EventArgs) Handles ucrReceiverSort.Leave
        ucrBase.clsRsyntax.AddParameter("data_name", clsRFunctionParameter:=ucrSelectorByDataFrameAddRemove.ucrAvailableDataFrames.clsCurrDataFrame)

    End Sub
    Private Sub grpOrder_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAscending.CheckedChanged, rdoDescending.CheckedChanged
        If rdoAscending.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("Descending", Chr(34) & "FALSE" & Chr(34))
        Else
            ucrBase.clsRsyntax.AddParameter("Descending", Chr(34) & "TRUE" & Chr(34))
        End If

    End Sub

    Private Sub grpMissingValues_ChekedChanged(sender As Object, e As EventArgs) Handles rdoFirst.CheckedChanged, rdoLast.CheckedChanged
        If rdoFirst.Checked = True Then
            ucrBase.clsRsyntax.AddParameter("na.last", Chr(34) & "FALSE" & Chr(34))
        Else
            ucrBase.clsRsyntax.AddParameter("na.last", Chr(34) & "TRUE" & Chr(34))
        End If

    End Sub
End Class