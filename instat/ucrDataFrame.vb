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
Imports RDotNet

Public Class ucrDataFrame
    Public strDataFrameLength As String
    Public clsCurrDataFrame As RFunction
    Public clsRSyntax As New RSyntax

    Private Sub ucrDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmMain.clsRLink.FillComboDataFrames(cboAvailableDataFrames)
        SetDataFrameProperties()
    End Sub

    Public Event DataFrameChanged(sender As Object, e As EventArgs)

    Private Sub cboAvailableDataFrames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAvailableDataFrames.SelectedIndexChanged
        SetDataFrameProperties()
        RaiseEvent DataFrameChanged(sender, e)
    End Sub

    Public Sub SetDataFrameProperties()
        strDataFrameLength = frmMain.clsRLink.clsEngine.Evaluate(frmMain.clsRLink.strInstatDataObject & "$length_of_data(" & Chr(34) & cboAvailableDataFrames.Text & Chr(34) & ")").AsCharacter(0).ToString
        clsRSyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_data_frame", clsFunction:=clsCurrDataFrame)
        clsRSyntax.AddParameter("data_name", Chr(34) & cboAvailableDataFrames.SelectedItem & Chr(34), clsRFunction:=clsCurrDataFrame)
        clsRSyntax.SetAssignTo(cboAvailableDataFrames.SelectedItem & "_temp", clsFunction:=clsCurrDataFrame)
    End Sub

End Class
