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

    'This needs testing to see if the ByVal works
    'If not, it could be modified to work as ByRef
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

    Public Sub UpdateControls(frmCurrentForm As Form, clsRFunction As RFunction)
        Dim ctrTemp As Control
        Dim ucrTemp As ucrCore
        Dim lstAllControls As New List(Of Control)

        lstAllControls = GetAllCoreControls(lstAllControls, frmCurrentForm)
        For Each ctrTemp In lstAllControls
            ucrTemp = DirectCast(ctrTemp, ucrCore)
            If ucrTemp IsNot Nothing Then
                ucrTemp.UpdateControl(clsRFunction)
            End If
        Next
    End Sub
End Module