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
Public Class dlgChiSquareTest
    Private Sub ChiSquareTest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ucrReceiverChiSquare.Selector = ucrAddRemove
        ucrReceiverChiSquare.SetMeAsReceiver()
        ucrBase.clsRsyntax.iCallType = 2
        ucrBase.clsRsyntax.SetFunction("chisq.test")
        autoTranslate(Me)
        cboLayoutOfData.Text = "Multiple Data Columns"
        ucrBase.iHelpTopicID = 175
    End Sub


    Private Sub ucrReceiverChiSquare_Leave(sender As Object, e As EventArgs) Handles ucrReceiverChiSquare.Leave
        ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverChiSquare.GetVariables())
    End Sub

End Class