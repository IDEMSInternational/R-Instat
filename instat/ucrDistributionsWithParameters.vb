' Instat+R
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

Public Class ucrDistributionsWithParameters
    Public lstParameterLabels As New List(Of Label)
    Public lstParameterTextBoxes As New List(Of TextBox)
    Public lstCurrArguments As New List(Of String)
    Public bParametersFilled As Boolean = False

    Private Sub ucrDistributionsWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetParameters()
        'temp disabled
        txtParameter4.Visible = False
        lblParameter4.Visible = False
    End Sub

    Public Sub SetParameters()
        Dim i As Integer = 0
        Dim strParamName As String

        If lstParameterLabels.Count = 0 Then
            lstParameterLabels.AddRange({lblParameter1, lblParameter2, lblParameter3})
        End If
        If lstParameterTextBoxes.Count = 0 Then
            lstParameterTextBoxes.AddRange({txtParameter1, txtParameter2, txtParameter3})
        End If

        If clsCurrDistribution.clsParameters.Count < 3 Then
            lblParameter3.Visible = False
            txtParameter3.Visible = False
        Else
            lblParameter3.Visible = True
            txtParameter3.Visible = True
        End If
        If clsCurrDistribution.clsParameters.Count < 2 Then
            lblParameter2.Visible = False
            txtParameter2.Visible = False
        Else
            lblParameter2.Visible = True
            txtParameter2.Visible = True
        End If
        If clsCurrDistribution.clsParameters.Count < 1 Then
            lblParameter1.Visible = False
            txtParameter1.Visible = False
        Else
            lblParameter1.Visible = True
            txtParameter1.Visible = True
        End If

        If clsCurrDistribution IsNot Nothing Then
            For Each strParamName In lstCurrArguments
                clsCurrRFunction.RemoveParameterByName(strParamName)
            Next
            'Removes transformed parameters
            'which are not in lstCurrArguments
            clsCurrRFunction.RemoveParameterByName("rate")
            clsCurrRFunction.RemoveParameterByName("scale")
            clsCurrRFunction.RemoveParameterByName("size")
            lstCurrArguments.Clear()
            For i = 0 To clsCurrDistribution.clsParameters.Count - 1
                lstParameterLabels(i).Text = translate(clsCurrDistribution.clsParameters(i).strNameTag)
                lstCurrArguments.Add(clsCurrDistribution.clsParameters(i).strArgumentName)
                If clsCurrDistribution.clsParameters(i).bHasDefault Then
                    lstParameterTextBoxes(i).Text = clsCurrDistribution.clsParameters(i).strDefaultValue
                    AddParameter(clsCurrDistribution.clsParameters(i).strArgumentName, clsCurrDistribution.clsParameters(i).strDefaultValue)
                Else
                    lstParameterTextBoxes(i).Clear()
                End If
                RaiseEvent ParameterChanged()
            Next
            If clsCurrDistribution.strNameTag = "Bernouli" Then
                AddParameter("size", 1)
            End If
            bParametersFilled = False
        End If
        CheckParametersFilled()
    End Sub

    Public Sub CheckParametersFilled()
        If (Not txtParameter1.Visible Or txtParameter1.Text <> "") And (Not txtParameter2.Visible Or txtParameter2.Text <> "") And (Not txtParameter3.Visible Or txtParameter3.Text <> "") Then
            bParametersFilled = True
        Else
            bParametersFilled = False
        End If
    End Sub

    Private Sub ucrDistributionsWithParameters_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles Me.cboDistributionsIndexChanged
        SetParameters()
    End Sub

    Public Event ParameterChanged()

    Private Sub txtParameter1_Leave(sender As Object, e As EventArgs) Handles txtParameter1.Leave
        AddParameter(lstCurrArguments(0), txtParameter1.Text)
        CheckParametersFilled()
        RaiseEvent ParameterChanged()
    End Sub

    Private Sub txtParameter2_Leave(sender As Object, e As EventArgs) Handles txtParameter2.Leave
        AddParameter(lstCurrArguments(1), txtParameter2.Text)
        CheckParametersFilled()
        RaiseEvent ParameterChanged()
    End Sub

    Private Sub txtParameter3_Leave(sender As Object, e As EventArgs) Handles txtParameter3.Leave
        AddParameter(lstCurrArguments(2), txtParameter3.Text)
        RaiseEvent ParameterChanged()
    End Sub

    Private Sub ucrDistributionsWithParameters_ParameterChanged() Handles Me.ParameterChanged
        CheckParametersFilled()
    End Sub
End Class