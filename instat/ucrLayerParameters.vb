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
            lstLayerParameterCheckbox.AddRange({chkParam1, chkParam2})
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
        Else
            clsGeomFunction.RemoveParameterByName(lstCurrLayerArguments(0))
        End If
    End Sub
End Class

