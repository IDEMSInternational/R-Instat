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
Module mdlCoreControl
    'This module contains global functions related to ucrCore

    'This needs testing to see if the ByVal works
    'If not, it could be modified to work as ByRef
    'Recursive method to get all core controls on a given form/control
    Public Function GetAllCoreControls(ByVal lstAllControls As List(Of ucrCore), ByVal ctrParent As Control) As List(Of ucrCore)
        Dim ucrTemp As ucrCore

        If ctrParent Is Nothing Then
            Return lstAllControls
        End If

        If TypeOf ctrParent Is ucrCore Then
            ucrTemp = DirectCast(ctrParent, ucrCore)
            lstAllControls.Add(ctrParent)
        End If

        For Each ctrChild As Control In ctrParent.Controls
            lstAllControls = GetAllCoreControls(lstAllControls, ctrChild)
        Next
        Return lstAllControls
        lstAllControls.Sort(AddressOf CompareCoreControls)
    End Function

    ' Defines ordering where selectors come before other controls
    ' Needed so that selectors are updated with RCode before receivers
    Private Function CompareCoreControls(ucrFirst As ucrCore, ucrSecond As ucrCore)
        If TryCast(ucrFirst, ucrDataFrame) IsNot Nothing Then
            Return -1
        Else
            Return 1
        End If
    End Function

    'Update RCode with values in all controls on a given form
    Public Sub UpdateRCode(frmCurrentForm As Form, clsRCodeStructure As RCodeStructure)
        Dim lstAllControls As New List(Of ucrCore)

        lstAllControls = GetAllCoreControls(lstAllControls, frmCurrentForm)
        For Each ucrTemp As ucrCore In lstAllControls
            ucrTemp.UpdateRCode()
        Next
    End Sub

    Public Sub SetRCode(frmCurrentForm As Form, clsRCodeStructure As RCodeStructure, Optional bReset As Boolean = False)
        Dim lstAllControls As New List(Of ucrCore)

        lstAllControls = GetAllCoreControls(lstAllControls, frmCurrentForm)
        SetRCode(lstAllControls, clsRCodeStructure, bReset)
    End Sub

    Public Sub SetRCode(lstControls As List(Of ucrCore), clsRCodeStructure As RCodeStructure, Optional bReset As Boolean = False)
        For Each ctrTemp In lstControls
            ctrTemp.SetRCode(clsRCodeStructure, bReset)
        Next
    End Sub

    Public Sub SetParameterName(lstControls As ucrCore(), strParameterName As String)
        For Each ucrTemp As ucrCore In lstControls
            ucrTemp.strParameterName = strParameterName
        Next
    End Sub
End Module