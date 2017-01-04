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
Public Class dlgCalculationsSummary
    Public bFirstLoad As Boolean = True
    Private lstCalculations As New List(Of KeyValuePair(Of String, RFunction))

    Private Sub dlgCalculationsSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If lstLayers.Items.Count > 0 Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub SetDefaults()
    End Sub

    Private Sub InitialiseDialog()
        cmdEdit.Enabled = False
        cmdDuplicate.Enabled = False
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim clsCalcFunction As New RFunction

        clsCalcFunction.SetRCommand("instat_calculation$new")
        sdgCalculationsSummmary.SetCalculationFunction(clsCalcFunction)
        sdgCalculationsSummmary.ShowDialog()
        If clsCalcFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "name") Then
            lstLayers.Items.Add(clsCalcFunction.clsParameters.Find(Function(x) x.strArgumentName = "name").strArgumentValue)
        Else
            lstLayers.Items.Add("calc" & lstLayers.Items.Count + 1)
        End If
        lstCalculations.Add(New KeyValuePair(Of String, RFunction)(lstLayers.Items(lstLayers.Items.Count - 1).Text, clsCalcFunction.Clone()))
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        For i = 0 To lstCalculations.Count
            frmMain.clsRLink.RunScript(lstCalculations(i).Value.ToScript())
        Next
    End Sub
End Class