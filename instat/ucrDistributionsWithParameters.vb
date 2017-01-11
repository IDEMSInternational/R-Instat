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
    Public lstParameterInput As New List(Of ucrInputTextBox)
    Public lstCurrArguments As New List(Of String)
    Public bParametersFilled As Boolean = False

    Private Sub ucrDistributionsWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetParameters()
        'temp disabled
        ucrInputParameter4.Visible = False
        lblParameter4.Visible = False
    End Sub

    Public Sub SetParameters()
        Dim i As Integer = 0
        Dim strParamName As String

        If lstParameterLabels.Count = 0 Then
            lstParameterLabels.AddRange({lblParameter1, lblParameter2, lblParameter3})
        End If
        If lstParameterInput.Count = 0 Then
            lstParameterInput.AddRange({ucrInputParameter1, ucrInputParameter2, ucrInputParameter3})
        End If

        If clsCurrDistribution.clsParameters.Count < 3 Then
            lblParameter3.Visible = False
            ucrInputParameter3.Visible = False
        Else
            lblParameter3.Visible = True
            ucrInputParameter3.Visible = True
        End If
        If clsCurrDistribution.clsParameters.Count < 2 Then
            lblParameter2.Visible = False
            ucrInputParameter2.Visible = False
        Else
            lblParameter2.Visible = True
            ucrInputParameter2.Visible = True
        End If
        If clsCurrDistribution.clsParameters.Count < 1 Then
            lblParameter1.Visible = False
            ucrInputParameter1.Visible = False
        Else
            lblParameter1.Visible = True
            ucrInputParameter1.Visible = True
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
                    lstParameterInput(i).Text = clsCurrDistribution.clsParameters(i).strDefaultValue
                    AddParameter(clsCurrDistribution.clsParameters(i).strArgumentName, clsCurrDistribution.clsParameters(i).strDefaultValue)
                Else
                    lstParameterInput(i).Reset()
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
        If (Not ucrInputParameter1.Visible Or ucrInputParameter1.Text <> "") And (Not ucrInputParameter2.Visible Or ucrInputParameter2.Text <> "") And (Not ucrInputParameter3.Visible Or ucrInputParameter3.Text <> "") Then
            bParametersFilled = True
        Else
            bParametersFilled = False
        End If
    End Sub

    Private Sub ucrDistributionsWithParameters_ucrDistributionsTextChanged(sender As Object, e As EventArgs) Handles Me.ucrInputDistributionTextChangedchanged
        SetParameters()
    End Sub

    Public Event ParameterChanged()

    Private Sub ucrInputParameter1_NameChanged() Handles ucrInputParameter1.NameChanged
        AddParameter(lstCurrArguments(0), ucrInputParameter1.GetText)
        CheckParametersFilled()
        RaiseEvent ParameterChanged()
    End Sub

    Private Sub ucrInputParameter2_NameChanged() Handles ucrInputParameter2.NameChanged
        AddParameter(lstCurrArguments(1), ucrInputParameter2.GetText)
        CheckParametersFilled()
        RaiseEvent ParameterChanged()
    End Sub

    Private Sub ucrInputParameter3_NameChanged() Handles ucrInputParameter3.NameChanged
        AddParameter(lstCurrArguments(2), ucrInputParameter3.Text)
        RaiseEvent ParameterChanged()
    End Sub

    Private Sub ucrDistributionsWithParameters_ParameterChanged() Handles Me.ParameterChanged
        CheckParametersFilled()
    End Sub

End Class