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

        ucrTemp = TryCast(ctrParent, ucrCore)
        If ucrTemp IsNot Nothing Then
            If ucrTemp.bIsActiveRControl Then
                lstAllControls.Add(ctrParent)
            End If
        End If

        For Each ctrChild As Control In ctrParent.Controls
            lstAllControls = GetAllCoreControls(lstAllControls, ctrChild)
        Next
        'removed from here as potentially slow
        'lstAllControls.Sort(AddressOf CompareCoreControls)
        Return lstAllControls
    End Function

    ' Defines ordering where selectors come before other controls
    ' Needed so that selectors are updated with RCode before receivers
    Private Function CompareCoreControls(ucrFirst As ucrCore, ucrSecond As ucrCore) As Integer
        If TypeOf ucrFirst Is ucrDataFrame Then
            Return -1
        Else
            Return 1
        End If
    End Function

    'Update RCode with values in all controls on a given form
    Public Sub UpdateRCode(frmCurrentForm As Form, clsRCodeStructure As RCodeStructure)
        Dim lstAllControls As New List(Of ucrCore)

        lstAllControls = GetAllCoreControls(lstAllControls, frmCurrentForm)
        lstAllControls.Sort(AddressOf CompareCoreControls)
        For Each ucrTemp As ucrCore In lstAllControls
            ucrTemp.UpdateRCode()
        Next
    End Sub

    Public Sub SetRCode(frmCurrentForm As Form, clsRCodeStructure As RCodeStructure, Optional bReset As Boolean = False)
        Dim lstAllControls As New List(Of ucrCore)

        lstAllControls = GetAllCoreControls(lstAllControls, frmCurrentForm)
        lstAllControls.Sort(AddressOf CompareCoreControls)
        SetRCode(lstAllControls, clsRCodeStructure, bReset)
    End Sub

    Public Sub SetRCode(lstControls As List(Of ucrCore), clsRCodeStructure As RCodeStructure, Optional bReset As Boolean = False)
        For Each ctrTemp In lstControls
            ctrTemp.SetRCode(clsRCodeStructure, bReset)
        Next
    End Sub

    Public Sub SetParameter(lstControls As ucrCore(), clsNewParameter As RParameter)
        For Each ucrTemp As ucrCore In lstControls
            ucrTemp.SetParameter(clsNewParameter)
        Next
    End Sub

    Public Function AllConditionsSatisfied(lstConditions As List(Of Condition), clsRCode As RCodeStructure, Optional clsParameter As RParameter = Nothing, Optional clsRSyntax As RSyntax = Nothing)
        Dim bTemp As Boolean = True

        For Each clsTempCond In lstConditions
            If Not clsTempCond.IsSatisfied(clsRCode, clsParameter, clsRSyntax) Then
                bTemp = False
                Exit For
            End If
        Next
        Return bTemp
    End Function

    'TODO This fails when items in the list contain "," as it splits values inside
    Public Function ExtractItemsFromRList(strTemp As String) As String()
        Dim lstVariables As String()
        If strTemp.StartsWith("c(") Then
            strTemp = strTemp.Substring(2)
        End If
        lstVariables = strTemp.Split(",")
        For i As Integer = 0 To lstVariables.Count - 1
            lstVariables(i) = lstVariables(i).Trim(Chr(34), " ", Chr(39), ")")
        Next
        Return lstVariables
    End Function
End Module