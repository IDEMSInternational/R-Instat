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

Imports instat

Public Class ucrLayerParameters
    Public lstLayerParameterControl As New List(Of ucrLayerParamsControls)
    Private bFirstLoad As Boolean = True
    Public WithEvents ucrGeomWithAes As ucrGeomListWithParameters

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        lstLayerParameterControl.AddRange({UcrLayerParamsControls1, UcrLayerParamsControls2, UcrLayerParamsControls3, UcrLayerParamsControls4, UcrLayerParamsControls5, UcrLayerParamsControls6, UcrLayerParamsControls7, UcrLayerParamsControls8, UcrLayerParamsControls9, UcrLayerParamsControls10, UcrLayerParamsControls11, UcrLayerParamsControls12, UcrLayerParamsControls13, UcrLayerParamsControls14, UcrLayerParamsControls15, UcrLayerParamsControls16, UcrLayerParamsControls17})
    End Sub

    Private Sub ucrLayerParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            bFirstLoad = False
        End If
    End Sub

    Private Sub InitialiseControl()
    End Sub

    Public Overrides Sub Setup(clsNewGgplotFunction As RFunction, clsNewGeomFunc As RFunction, clsNewGlobalAesFunc As RFunction, clsNewLocalAes As RFunction, Optional bFixGeom As Boolean = False, Optional ucrNewBaseSelector As ucrSelectorByDataFrame = Nothing, Optional bApplyAesGlobally As Boolean = True, Optional iNumVariablesForGeoms As Integer = -1, Optional bReset As Boolean = False, Optional strDataFrame As String = "")
        MyBase.Setup(clsNewGgplotFunction, clsNewGeomFunc, clsNewGlobalAesFunc, clsNewLocalAes, bFixGeom, ucrNewBaseSelector, bApplyAesGlobally, iNumVariablesForGeoms, bReset, strDataFrame)
        SetLayerParameters(bReset)
    End Sub

    Public Sub SetLayerParameters(Optional bReset As Boolean = False)
        Dim i As Integer = 0
        'fill the labels and checkboxes
        If clsCurrGeom IsNot Nothing Then
            For i = 0 To (lstLayerParameterControl.Count - 1)
                If (i < clsCurrGeom.clsLayerParameters.Count) Then
                    lstLayerParameterControl(i).SetControl(clsGeomFunction, clsCurrGeom.clsLayerParameters(i), bReset:=bReset)
                Else
                    lstLayerParameterControl(i).SetControl(clsGeomFunction, Nothing)
                End If
            Next
        End If
    End Sub

    Private Sub ucrLayerParameters_GeomChanged() Handles Me.GeomChanged
        If ucrGeomWithAes IsNot Nothing Then
            ucrGeomWithAes.SetGeomName(GetGeomName())
        End If
        SetLayerParameters(False)
    End Sub
End Class

