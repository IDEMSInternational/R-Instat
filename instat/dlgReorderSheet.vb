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
Public Class dlgReorderSheet
    Public bFirstLoad As Boolean = True
    Private Sub dlgReorderSheet_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            initialiseDialog()
        End If
        ucrSheetsToReorder.loadList()
        TestOkEnabled()
    End Sub

    Private Sub initialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$reorder_dataframes")
        ucrSheetsToReorder.setDataType("data frame")
        ucrBase.iHelpTopicID = 62
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrSheetsToReorder.isEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        ucrSheetsToReorder.ResetText()
        TestOkEnabled()
    End Sub

    Private Sub ucrSheetsToReoder_OrderChanged() Handles ucrSheetsToReorder.OrderChanged
        If Not ucrSheetsToReorder.isEmpty Then
            ucrBase.clsRsyntax.AddParameter("data_frames_order", ucrSheetsToReorder.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("data_frames_order")
        End If
    End Sub
End Class