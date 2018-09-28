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
Public Class dlgCreateClimateObject
    Public bFirstLoad As Boolean = True
    Private Sub dlgCreateClimateObject_Load(sender As Object, e As EventArgs) Handles Me.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()

    End Sub

    Private Sub TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        'frmMain.clsRLink.CreateNewClimateObject()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strClimateObject & "$import_data")
    End Sub
    Private Sub SetDefaults()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub SetDataFrameParam()

        Dim clsTempFunction As New RFunction
        Dim clsTempParameter As New RParameter

        clsTempFunction.SetRCommand("list")
        clsTempParameter.SetArgumentName(ucrDataFrameImportClimateObject.cboAvailableDataFrames.Text)
        clsTempParameter.SetArgument(ucrDataFrameImportClimateObject.clsCurrDataFrame)
        clsTempFunction.AddParameter(clsTempParameter)
        ucrBase.clsRsyntax.AddParameter("data_tables", clsRFunctionParameter:=clsTempFunction)

    End Sub

    Private Sub UcrDataFrame_Load(sender As Object, e As EventArgs) Handles ucrDataFrameImportClimateObject.Load
        SetDataFrameParam()
    End Sub

    Private Sub UcrDataFrame_Leave(sender As Object, e As EventArgs) Handles ucrDataFrameImportClimateObject.Leave
        SetDataFrameParam()
    End Sub

End Class