'Instat-R
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

Public Class dlgConvertColumnsToFactors
    Public bFirstLoad As Boolean

    Private Sub ucrSelectorDataFrameColumns_Load(sender As Object, e As EventArgs) Handles ucrSelectorDataFrameColumns.Load
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$convert_column_to_type")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverColumnsToConvert.Selector = ucrSelectorDataFrameColumns
        ucrReceiverColumnsToConvert.SetMeAsReceiver()
        autoTranslate(Me)
        ucrBase.iHelpTopicID = 34
        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False

        End If

        TestOKEnabled()
    End Sub

    Private Sub SetDefaults()
        ucrReceiverColumnsToConvert.SetMeAsReceiver()
        ucrSelectorDataFrameColumns.Reset()
        ucrSelectorDataFrameColumns.Focus()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverColumnsToConvert_SelectionChanged() Handles ucrReceiverColumnsToConvert.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverColumnsToConvert.GetVariables())
        TestOKEnabled()
    End Sub



    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub


    Private Sub TestOKEnabled()
        If ucrReceiverColumnsToConvert.GetVariableNames() <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
End Class