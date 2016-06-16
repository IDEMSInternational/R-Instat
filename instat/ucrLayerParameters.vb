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
    Public lstLayerParameterControl As New List(Of ucrLayerParamsControls)
    Private bFirstLoad As Boolean = True
    Public WithEvents ucrGeomWithAes As UcrGeomListWithParameters

    Private Sub ucrLayerParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            bFirstLoad = False
        End If
    End Sub
    Private Sub InitialiseControl()
        If lstLayerParameterControl.Count = 0 Then
            lstLayerParameterControl.AddRange({UcrLayerParamsControls1, UcrLayerParamsControls2, UcrLayerParamsControls3, UcrLayerParamsControls4, UcrLayerParamsControls5, UcrLayerParamsControls6, UcrLayerParamsControls7, UcrLayerParamsControls8, UcrLayerParamsControls9, UcrLayerParamsControls10, UcrLayerParamsControls11, UcrLayerParamsControls12})
            For i = 0 To (lstLayerParameterControl.Count - 1)
                lstLayerParameterControl(i).SetGeomFunction(clsGeomFunction)
            Next
        End If
    End Sub

    Public Sub SetLayerParameters()
        Dim i As Integer = 0
        'fill the labels and checkboxes
        If clsCurrGeom IsNot Nothing Then
            For i = 0 To (lstLayerParameterControl.Count - 1)
                If (i < clsCurrGeom.clsLayerParameters.Count - 1) Then
                    lstLayerParameterControl(i).SetLayerParameter(clsCurrGeom.clsLayerParameters(i))
                Else
                    lstLayerParameterControl(i).SetLayerParameter(Nothing)
                End If
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
End Class

