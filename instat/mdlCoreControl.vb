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
    Public Function GetAllCoreControls(ByVal lstAllControls As List(Of Control), ByVal ctrParent As Control) As List(Of Control)
        If ctrParent Is Nothing Then
            Return lstAllControls
        End If

        If TypeOf ctrParent Is ucrCore Then
            lstAllControls.Add(ctrParent)
        End If

        For Each ctrChild As Control In ctrParent.Controls
            lstAllControls = GetAllCoreControls(lstAllControls, ctrChild)
        Next
        Return lstAllControls
    End Function

    'Update all ucrCore controls on a given form with values in clsRCodeStructure
    Public Sub UpdateControls(frmCurrentForm As Form, clsRCodeStructure As RCodeStructure)
        Dim ctrTemp As Control
        Dim ucrTemp As ucrCore
        Dim lstAllControls As New List(Of Control)

        lstAllControls = GetAllCoreControls(lstAllControls, frmCurrentForm)
        For Each ctrTemp In lstAllControls
            ucrTemp = DirectCast(ctrTemp, ucrCore)
            'Check shouldn't be needed because of GetAllCoreControls method but not harm to leave in
            If ucrTemp IsNot Nothing Then
                ucrTemp.UpdateControl(clsRCodeStructure)
            End If
        Next
    End Sub
End Module