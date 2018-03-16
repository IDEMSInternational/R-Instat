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

Public Class ucrDistributionsWithParameters
    Public lstParameterLabels As New List(Of Label)
    Public lstParameterInputTextBoxes As New List(Of ucrInputTextBox)
    Public lstCurrArguments As New List(Of String)
    Public bParametersFilled As Boolean = False

    Private Sub ucrDistributionsWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        If lstParameterInputTextBoxes.Count = 0 Then
            lstParameterInputTextBoxes.AddRange({ucrInputParameter1, ucrInputParameter2, ucrInputParameter3})
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
                    lstParameterInputTextBoxes(i).SetName(clsCurrDistribution.clsParameters(i).strDefaultValue)
                    AddParameter(clsCurrDistribution.clsParameters(i).strArgumentName, clsCurrDistribution.clsParameters(i).strDefaultValue)
                Else
                    lstParameterInputTextBoxes(i).Reset()
                End If
                OnControlValueChanged()
            Next
            If clsCurrDistribution.strNameTag = "Bernouli" Then
                AddParameter("size", 1)
            End If
            bParametersFilled = False
        End If
        CheckParametersFilled()
    End Sub

    Public Sub CheckParametersFilled()
        If (Not ucrInputParameter1.Visible OrElse Not ucrInputParameter1.IsEmpty) AndAlso (Not ucrInputParameter2.Visible OrElse Not ucrInputParameter2.IsEmpty) AndAlso (Not ucrInputParameter3.Visible OrElse Not ucrInputParameter3.IsEmpty) Then
            bParametersFilled = True
        Else
            bParametersFilled = False
        End If
    End Sub

    Private Sub ucrDistributionsWithParameters_ucrInputDistributionsIndexChanged() Handles Me.DistributionsIndexChanged
        SetParameters()
    End Sub

    Private Sub ucrInputParameter1_ControlValueChanged() Handles ucrInputParameter1.ControlValueChanged
        If lstCurrArguments IsNot Nothing AndAlso lstCurrArguments.Count > 0 Then
            AddParameter(lstCurrArguments(0), ucrInputParameter1.GetText)
            CheckParametersFilled()
        End If
        OnControlValueChanged()
    End Sub

    Private Sub ucrInputParameter2_ControlValueChanged() Handles ucrInputParameter2.ControlValueChanged
        If lstCurrArguments IsNot Nothing AndAlso lstCurrArguments.Count > 1 Then
            AddParameter(lstCurrArguments(1), ucrInputParameter2.GetText)
            CheckParametersFilled()
        End If
        OnControlValueChanged()
    End Sub

    Private Sub ucrInputParameter3_ControlValueChanged() Handles ucrInputParameter3.ControlValueChanged
        If lstCurrArguments IsNot Nothing AndAlso lstCurrArguments.Count > 2 Then
            AddParameter(lstCurrArguments(2), ucrInputParameter3.GetText)
            CheckParametersFilled()
        End If
        OnControlValueChanged()
    End Sub

    Private Sub ucrDistributionsWithParameters_ParameterChanged() Handles Me.ControlValueChanged
        CheckParametersFilled()
    End Sub
End Class