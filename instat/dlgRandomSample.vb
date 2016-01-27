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

Public Class dlgRandomSample
    Public clsRSyntax As New RSyntax
    Private Sub dlgRandomSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        'ucrBase.OKEnabled(False)
        ucrDistWithParameters.SetRDistributions()
        ucrNewColumnNameSelector.strPrefix = "Rand"
        ucrDataFrameSelector.SetColumnList(ucrNewColumnNameSelector)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelector.cboColumnName.Text, strTempDataframe:=ucrDataFrameSelector.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelector.cboColumnName.Text)

        ucrBase.clsRsyntax.clsBaseFunction = ucrDistWithParameters.clsCurrRFunction
        ucrDistWithParameters.AddParameter("n", ucrDataFrameSelector.strDataFrameLength)
    End Sub

    Private Sub ucrDataFrameSelector_Leave(sender As Object, e As EventArgs) Handles ucrDataFrameSelector.Leave
        ucrDistWithParameters.AddParameter("n", ucrDataFrameSelector.strDataFrameLength)
    End Sub
End Class