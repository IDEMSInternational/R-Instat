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

Public Class sdgCreateFilter
    Public clsCurrentFilter As RFunction
    Public bFilterDefined As Boolean
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clsCurrentFilter = ucrCreateFilter.clsFilterFunction
        bFilterDefined = ucrCreateFilter.bFilterDefined
    End Sub

    Private Sub ucrCreateFilter_FilterChanged() Handles ucrCreateFilter.FilterChanged
        bFilterDefined = ucrCreateFilter.bFilterDefined
    End Sub
End Class