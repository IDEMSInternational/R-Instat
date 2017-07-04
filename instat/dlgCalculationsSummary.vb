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

Public Class dlgCalculationsSummary
    Public bFirstLoad As Boolean = True
    Private lstCalculations As New List(Of KeyValuePair(Of String, RFunction))
    Private clsApplyCalculation As New RFunction
    Private iCalcCount As Integer = 1

    Private Sub dlgCalculationsSummary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
        SetEnabledStatusButtons()
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
        ucrBase.iHelpTopicID = 513
        cmdEdit.Enabled = False
        cmdDuplicate.Enabled = False
        clsApplyCalculation.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$run_instat_calculation")
    End Sub

    Private Sub cmdAdd_Click(sender As Object, e As EventArgs) Handles cmdAdd.Click
        Dim clsCalcFunction As New RFunction

        clsCalcFunction.SetRCommand("instat_calculation$new")
        sdgCalculationsSummmary.SetAsCalculation()
        sdgCalculationsSummmary.SetCalculationFunction(clsCalcFunction)
        sdgCalculationsSummmary.ShowDialog()
        If clsCalcFunction.clsParameters.FindIndex(Function(x) x.strArgumentName = "name") = -1 Then
            clsCalcFunction.AddParameter("name", Chr(34) & "calc" & iCalcCount & Chr(34))
            clsCalcFunction.SetAssignTo("calc" & iCalcCount)
            iCalcCount = iCalcCount + 1
        End If
        lstLayers.Items.Add(clsCalcFunction.clsParameters.Find(Function(x) x.strArgumentName = "name").strArgumentValue.Trim(Chr(34)))
        lstCalculations.Add(New KeyValuePair(Of String, RFunction)(lstLayers.Items(lstLayers.Items.Count - 1).Text, clsCalcFunction.Clone()))
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickOk(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        Dim strScript As String
        Dim strTemp As String = ""
        Dim iCallType As Integer

        For i = 0 To lstCalculations.Count - 1
            strScript = ""
            clsApplyCalculation.AddParameter("calc", clsRFunctionParameter:=lstCalculations(i).Value.Clone())
            If lstCalculations(i).Value.clsParameters.FindIndex(Function(x) x.strArgumentName = "save") <> -1 AndAlso lstCalculations(i).Value.clsParameters.Find(Function(x) x.strArgumentName = "save").strArgumentValue = "2" Then
                iCallType = 0
                clsApplyCalculation.AddParameter("display", "FALSE")
            Else
                iCallType = 2
                clsApplyCalculation.AddParameter("display", "TRUE")
            End If
            strTemp = clsApplyCalculation.ToScript(strScript)
            frmMain.clsRLink.RunScript(strScript & strTemp, iCallType:=iCallType)
        Next
    End Sub

    Private Sub cmdDelete_Click(sender As Object, e As EventArgs) Handles cmdDelete.Click
        Dim iIndex As Integer

        For Each lviTemp As ListViewItem In lstLayers.SelectedItems
            iIndex = lstLayers.Items.IndexOf(lviTemp)
            lstLayers.Items.Remove(lviTemp)
            lstCalculations.RemoveAt(iIndex)
        Next
    End Sub

    Private Sub lstLayers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstLayers.SelectedIndexChanged
        SetEnabledStatusButtons()
    End Sub

    Private Sub SetEnabledStatusButtons()
        If lstLayers.SelectedItems.Count > 0 Then
            cmdDelete.Enabled = True
        Else
            cmdDelete.Enabled = False
        End If
    End Sub
End Class