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
Public Class dlgReoderDescriptives
    Public bFirstLoad As Boolean = True
    Private Sub dlgReoderDescriptives_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$reorder_objects")
        ucrReorderObjects.setDataType("object")
        ucrReorderObjects.setDataframes(ucrDataFrameReoder)
        ucrBase.iHelpTopicID = 351
    End Sub
    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOKEnabled()
        If Not ucrReorderObjects.isEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub SetDefaults()
        ucrDataFrameReoder.Reset()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReorderObjects_OrderChanged() Handles ucrReorderObjects.OrderChanged
        If Not ucrReorderObjects.isEmpty Then
            ucrBase.clsRsyntax.AddParameter("new_order", ucrReorderObjects.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_order")
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrDataFrameReoder_DataFrameChanged() Handles ucrDataFrameReoder.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrDataFrameReoder.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub
End Class