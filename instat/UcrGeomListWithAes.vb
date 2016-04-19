
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
    Public lstGgParameterLabels As New List(Of Label)
    Public lstGgParameterUcr As New List(Of ucrReceiverSingle)
    Public lstCurrArguments As New List(Of String)
    Public bFirstLoad As Boolean = True

    Private Sub UcrGeomListWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseControl()
            Setdefaults()
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
        ucrReceiverParam1.SetMeAsReceiver()
    End Sub

    Private Sub Setdefaults()
        'sets control defaults

    End Sub
    Public Sub SetParameters() 'this will set function or aes parameters
        Dim i As Integer = 0

        If lstGgParameterLabels.Count = 0 Then
            lstGgParameterLabels.AddRange({lblGgParam1, lblGgParam2, lblGgParam3, lblGgParam4, lblGgParam5, lblGgParam6, lblGgParam7}) 'Adds range for the parameter labels
        End If

        If lstGgParameterUcr.Count = 0 Then
            'Adds range for the parameter receivers
            lstGgParameterUcr.AddRange({ucrReceiverParam1, ucrReceiverParam2, ucrReceiverParam3, ucrReceiverParam4, ucrReceiverParam5, ucrReceiverParam6, ucrReceiverParam7})
        End If

        If clsCurrGeom.clsGgParameters.Count < 7 Then
            lblGgParam7.Visible = False
            ucrReceiverParam7.Visible = False
        Else
            lblGgParam7.Visible = True
            ucrReceiverParam7.Visible = True
        End If
        If clsCurrGeom.clsGgParameters.Count < 6 Then
            lblGgParam6.Visible = False
            ucrReceiverParam6.Visible = False
        Else
            lblGgParam6.Visible = True
            ucrReceiverParam6.Visible = True
        End If

        'populating labels with appropriate names
        If clsCurrGeom IsNot Nothing Then
            lstCurrArguments.Clear()
            For i = 0 To (clsCurrGeom.clsGgParameters.Count - 1)
                lstGgParameterLabels(i).Text = clsCurrGeom.clsGgParameters(i).strGgParameterName
                lstCurrArguments.Add(clsCurrGeom.clsGgParameters(i).strGgParameterName)

            Next
        End If
    End Sub

    Private Sub UcrGeomListWithParameters_cboGeomListIndexChanged(sender As Object, e As EventArgs) Handles Me.cboGeomListIndexChanged
        SetParameters()
    End Sub

    Private Sub ucrReceiverParam1_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverParam1.SelectionChanged
        AddParameter(lstCurrArguments(0), ucrReceiverParam1.GetVariableNames())

    End Sub
End Class
