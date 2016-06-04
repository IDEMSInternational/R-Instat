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

Public Class ucrLayerParameters
    Public lstLayerParameterCheckbox As New List(Of CheckBox)
    Public lstlayerParameterNud As New List(Of NumericUpDown)
    Public lstCurrLayerArguments As New List(Of String)
    Private bFirstLoad As Boolean = True
    Public WithEvents ucrGeomWithAes As UcrGeomListWithParameters

    Private Sub ucrLayerParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            bFirstLoad = False
        End If
    End Sub
    Private Sub InitialiseControl()

    End Sub

    Public Sub SetGeomFunction(clsLayerGeomFunc As RFunction)
        clsGeomFunction = clsLayerGeomFunc
    End Sub

    Public Sub SetLayerParameters()
        Dim i As Integer = 0
        If lstLayerParameterCheckbox.Count = 0 Then
            lstLayerParameterCheckbox.AddRange({chkParam1, chkParam2, chkParam3, chkParam4, chkParam5})
        End If
        If lstlayerParameterNud.Count = 0 Then
            lstlayerParameterNud.AddRange({nud1, nud2, nud3, nud4})
        End If

        'fill the labels and checkboxes
        If clsCurrGeom IsNot Nothing Then
            lstCurrLayerArguments.Clear()
            For i = 0 To (clsCurrGeom.clsLayerParameters.Count - 1)
                lstLayerParameterCheckbox(i).Text = (clsCurrGeom.clsLayerParameters(i).strLayerParameterName)
                lstCurrLayerArguments.Add(clsCurrGeom.clsLayerParameters(i).strLayerParameterName)
            Next
        End If
    End Sub
    Public Sub ucrLayerParameters_cboGeomListIndexChanged(sender As Object, e As EventArgs) Handles Me.GeomChanged
        'this would only work on sdgLayers only
        'sdgLayerOptions.ucrGeomWithAes.cboGeomList.SelectedItem = Me.cboGeomList.SelectedItem
        If ucrGeomWithAes IsNot Nothing Then
            ucrGeomWithAes.cboGeomList.SelectedItem = Me.cboGeomList.SelectedItem
        End If
        SetLayerParameters()
    End Sub

    Private Sub SetDefaults()

    End Sub
    Private Sub chkParam1_CheckedChanged(sender As Object, e As EventArgs) Handles chkParam1.CheckedChanged
        If chkParam1.Checked = True Then
            clsGeomFunction.AddParameter(lstCurrLayerArguments(0), "TRUE")
            chkParam2.Enabled = True
        Else
            clsGeomFunction.RemoveParameterByName(lstCurrLayerArguments(0))
            chkParam2.Enabled = True
        End If
    End Sub

    Private Sub chkParam2_CheckedChanged(sender As Object, e As EventArgs) Handles chkParam2.CheckedChanged
        If chkParam2.Checked Then
            nud1.Visible = True
        Else
            nud1.Visible = False
        End If
    End Sub

    Private Sub chkParam3_CheckedChanged(sender As Object, e As EventArgs) Handles chkParam3.CheckedChanged
        If chkParam3.Checked Then
            nud2.Visible = True
        Else
            nud2.Visible = False
        End If
    End Sub

    Private Sub chkParam4_CheckedChanged(sender As Object, e As EventArgs) Handles chkParam4.CheckedChanged
        If chkParam4.Checked Then
            nud3.Visible = True
        Else
            nud3.Visible = False
        End If
    End Sub
    Private Sub chkParam5_CheckedChanged(sender As Object, e As EventArgs) Handles chkParam5.CheckedChanged
        If chkParam5.Checked Then
            nud4.Visible = True
        Else
            nud4.Visible = False
        End If
    End Sub

    Private Sub nud1_ValueChanged(sender As Object, e As EventArgs) Handles nud1.ValueChanged
        clsGeomFunction.AddParameter(lstCurrLayerArguments(1), nud1.Value)
    End Sub

    Private Sub nud2_ValueChanged(sender As Object, e As EventArgs) Handles nud2.ValueChanged
        clsGeomFunction.AddParameter(lstCurrLayerArguments(2), nud2.Value)
    End Sub

    Private Sub nud3_ValueChanged(sender As Object, e As EventArgs) Handles nud3.ValueChanged
        clsGeomFunction.AddParameter(lstCurrLayerArguments(3), nud3.Value)
    End Sub

    Private Sub nud4_ValueChanged(sender As Object, e As EventArgs) Handles nud4.ValueChanged
        clsGeomFunction.AddParameter(lstCurrLayerArguments(4), nud4.Value)
    End Sub
End Class

