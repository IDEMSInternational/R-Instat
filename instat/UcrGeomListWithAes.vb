
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

    Private Sub UcrGeomListWithParameters_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SetParameters()
    End Sub

    Public Sub SetParameters()
        'this will set function or aes parameters
        lstGgParameterLabels.AddRange({lblGgParam1, lblGgParam2, lblGgParam3, lblGgParam4, lblGgParam5, lblGgParam6, lblGgParam7}) 'Adds range for the parameter labels


        'Adds range for the parameter receivers
        lstGgParameterUcr.AddRange({ucrReceiverParam1, ucrReceiverParam2, ucrReceiverParam3, ucrReceiverParam4, ucrReceiverParam5, ucrReceiverParam6, ucrReceiverParam7})

    End Sub


End Class
