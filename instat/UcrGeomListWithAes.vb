﻿
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

Public Class UcrGeomListWithParameters
    Public lstAesParameterLabels As New List(Of Label)
    Public lstAesParameterUcr As New List(Of ucrReceiverSingle)
    Public lstCurrArguments As New List(Of String)
    Public bFirstLoad As Boolean = True
    Public ucrLayersControl As ucrLayerParameters
    Public Event DataFrameChanged()

    Private Sub UcrGeomListWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            SetDefaults()
            SetParameters()
            bFirstLoad = False
        End If
    End Sub
    Private Sub InitialiseControl()
        ucrReceiverParam1.Selector = UcrSelector
        ucrReceiverParam2.Selector = UcrSelector
        ucrReceiverParam3.Selector = UcrSelector
        ucrReceiverParam4.Selector = UcrSelector
        ucrReceiverParam5.Selector = UcrSelector
        ucrReceiverParam6.Selector = UcrSelector
        ucrReceiverParam7.Selector = UcrSelector
        ucrReceiverParam8.Selector = UcrSelector
        ucrReceiverParam9.Selector = UcrSelector
        ucrReceiverParam1.SetMeAsReceiver()
    End Sub

    Private Sub SetDefaults()
        'sets control defaults
        UcrSelector.Reset()
    End Sub

    Public Sub SetGeomFunction(clsAesGeomFunc As RFunction)
        clsGeomFunction = clsAesGeomFunc
    End Sub

    Public Sub SetParameters() 'this will set function or aes parameters
        Dim i As Integer = 0

        If lstAesParameterLabels.Count = 0 Then
            lstAesParameterLabels.AddRange({lblGgParam1, lblGgParam2, lblGgParam3, lblGgParam4, lblGgParam5, lblGgParam6, lblGgParam7, lblGgParam8, lblGgParam9}) 'Adds range for the parameter labels
        End If

        If lstAesParameterUcr.Count = 0 Then
            'Adds range for the parameter receivers
            lstAesParameterUcr.AddRange({ucrReceiverParam1, ucrReceiverParam2, ucrReceiverParam3, ucrReceiverParam4, ucrReceiverParam5, ucrReceiverParam6, ucrReceiverParam7, ucrReceiverParam8, ucrReceiverParam9})
        End If

        If clsCurrGeom.clsAesParameters.Count < 9 Then
            lblGgParam9.Visible = False
            ucrReceiverParam9.Visible = False
        Else
            lblGgParam9.Visible = True
            ucrReceiverParam9.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 8 Then
            lblGgParam8.Visible = False
            ucrReceiverParam8.Visible = False
        Else
            lblGgParam8.Visible = True
            ucrReceiverParam8.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 7 Then
            lblGgParam7.Visible = False
            ucrReceiverParam7.Visible = False
        Else
            lblGgParam7.Visible = True
            ucrReceiverParam7.Visible = True
        End If
        If clsCurrGeom.clsAesParameters.Count < 6 Then
            lblGgParam6.Visible = False
            ucrReceiverParam6.Visible = False
        Else
            lblGgParam6.Visible = True
            ucrReceiverParam6.Visible = True
        End If
        If clsCurrGeom.clsAesParameters.Count < 5 Then
            lblGgParam5.Visible = False
            ucrReceiverParam5.Visible = False
        Else
            lblGgParam5.Visible = True
            ucrReceiverParam5.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 4 Then
            lblGgParam4.Visible = False
            ucrReceiverParam4.Visible = False
        Else
            lblGgParam4.Visible = True
            ucrReceiverParam4.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 3 Then
            lblGgParam3.Visible = False
            ucrReceiverParam3.Visible = False
        Else
            lblGgParam3.Visible = True
            ucrReceiverParam3.Visible = True
        End If

        If clsCurrGeom.clsAesParameters.Count < 2 Then 'this is available for some cases like piechart
            lblGgParam2.Visible = False
            ucrReceiverParam2.Visible = False
        Else
            lblGgParam2.Visible = True
            ucrReceiverParam2.Visible = True
        End If
        'populating labels with appropriate names
        If clsCurrGeom IsNot Nothing Then
            lstCurrArguments.Clear()
            For i = 0 To (clsCurrGeom.clsAesParameters.Count - 1)
                If Not clsCurrGeom.clsAesParameters(i).bIsMandatory Then
                    lstAesParameterLabels(i).Text = clsCurrGeom.clsAesParameters(i).strAesParameterName
                    lstCurrArguments.Add(clsCurrGeom.clsAesParameters(i).strAesParameterName)
                Else
                    'make them uppercase
                    lstAesParameterLabels(i).Text = (clsCurrGeom.clsAesParameters(i).strAesParameterName)
                    lstAesParameterLabels(i).Font = New Font(lstAesParameterLabels(i).Font, FontStyle.Bold)
                    lstCurrArguments.Add(clsCurrGeom.clsAesParameters(i).strAesParameterName)
                End If

                If clsCurrGeom.clsAesParameters(i).strIncludedDataTypes IsNot Nothing Then
                    lstAesParameterUcr(i).SetIncludedDataTypes(clsCurrGeom.clsAesParameters(i).strIncludedDataTypes)

                ElseIf clsCurrGeom.clsAesParameters(i).strExcludedDataTypes IsNot Nothing Then
                    lstAesParameterUcr(i).SetExcludedDataTypes(clsCurrGeom.clsAesParameters(i).strExcludedDataTypes)
                End If
            Next
        End If
    End Sub

    Public Sub UcrGeomListWithParameters_cboGeomListIndexChanged(sender As Object, e As EventArgs) Handles Me.GeomChanged
        'this would only work on sdgLayers only
        'sdgLayerOptions.ucrLayerParameter.cboGeomList.SelectedItem = Me.cboGeomList.SelectedItem
        If ucrLayersControl IsNot Nothing Then
            ucrLayersControl.cboGeomList.SelectedItem = Me.cboGeomList.SelectedItem
        End If
        SetParameters()
    End Sub
    Private Sub ucrReceiverParam1_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam1.SelectionChanged
        If Not ucrReceiverParam1.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(0), ucrReceiverParam1.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(0))
        End If
        dlgGeneralForGraphics.TestOkEnabled()
    End Sub

    Private Sub ucrReceiverParam2_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam2.SelectionChanged
        If Not ucrReceiverParam2.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(1), ucrReceiverParam2.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(1))
        End If
    End Sub
    Private Sub ucrReceiverParam3_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam3.SelectionChanged
        If Not ucrReceiverParam3.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(2), ucrReceiverParam3.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(2))
        End If

    End Sub

    Private Sub ucrReceiverParam4_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam4.SelectionChanged
        If Not ucrReceiverParam4.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(3), ucrReceiverParam4.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(3))
        End If

    End Sub
    Private Sub ucrReceiverParam5_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam5.SelectionChanged
        If Not ucrReceiverParam5.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(4), ucrReceiverParam5.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(4))
        End If
    End Sub

    Private Sub ucrReceiverParam6_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam6.SelectionChanged
        If Not ucrReceiverParam6.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(5), ucrReceiverParam6.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(5))
        End If
    End Sub

    Private Sub ucrReceiverParam7_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam7.SelectionChanged, ucrReceiverParam9.SelectionChanged, ucrReceiverParam8.SelectionChanged
        If Not ucrReceiverParam7.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(6), ucrReceiverParam7.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(6))
        End If
    End Sub
    Private Sub ucrReceiverParam8_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam8.SelectionChanged, ucrReceiverParam9.SelectionChanged, ucrReceiverParam8.SelectionChanged
        If Not ucrReceiverParam8.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(7), ucrReceiverParam8.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(7))
        End If
    End Sub

    Private Sub ucrReceiverParam9_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam9.SelectionChanged, ucrReceiverParam9.SelectionChanged, ucrReceiverParam8.SelectionChanged
        If Not ucrReceiverParam9.IsEmpty Then
            clsRaesFunction.AddParameter(lstCurrArguments(8), ucrReceiverParam9.GetVariableNames(False))
        Else
            clsRaesFunction.RemoveParameterByName(lstCurrArguments(8))
        End If
    End Sub

    Private Sub UcrSelector_DataFrameChanged() Handles UcrSelector.DataFrameChanged
        clsGeomFunction.AddParameter("data", clsRFunctionParameter:=UcrSelector.ucrAvailableDataFrames.clsCurrDataFrame)
        ' RaiseEvent DataFrameChanged() do we need this?
    End Sub
End Class
