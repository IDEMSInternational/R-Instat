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
Imports instat
Imports instat.Translations
Public Class dlgReorderColumns
    Dim bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgReorderColumns_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)
        If bFirstLoad Then
            initialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOkEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrDataFrameSelector.Reset()
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        TestOkEnabled()
    End Sub

    Private Sub initialiseDialog()
        ucrBase.iHelpTopicID = 163
        ucrBase.clsRsyntax.iCallType = 0

        ucrReorderColumns.setDataframes(ucrDataFrameSelector)

        ucrDataFrameSelector.SetParameter(New RParameter("data_name", 0))
        ucrDataFrameSelector.SetParameterIsString()

        ucrReorderColumns.setDataType("column")
        'ucrReorderColumns.SetParameter(New RParameter("col_order", 1))
        'ucrReorderColumns.SetParameterIsString()

        'seting default function
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$reorder_columns_in_data")
    End Sub

    Private Sub ReopenDialog()
        TestOkEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        TestOkEnabled()
    End Sub

    Private Sub ucrReorderColumns_OrderChanged() Handles ucrReorderColumns.OrderChanged
        If Not ucrReorderColumns.isEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_order", ucrReorderColumns.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_order")
        End If
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReorderColumns.isEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrDataFrameSelector.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class