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

Public Class ucrSelectorByDataFrameAddRemove
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Add()
    End Sub

    Private Sub btnDataOptions_Click(sender As Object, e As EventArgs) Handles btnDataOptions.Click
        ShowDataOptionsDialog()
        If ParentForm IsNot Nothing Then
            For Each ctr In ParentForm.Controls
                If TypeOf ctr Is ucrSelector Then
                    ctr.LoadList()
                End If
            Next
        End If
    End Sub

    Public Sub ShowColumnSelector(bShow As Boolean)
        btnAdd.Visible = bShow
        btnDataOptions.Visible = bShow
        lstAvailableVariable.Visible = bShow
    End Sub

    Public Overrides Sub SetVariablesEnabled(bEnable As Boolean)
        MyBase.SetVariablesEnabled(bEnable)
        btnAdd.Enabled = bEnable
        btnDataOptions.Enabled = bEnable
    End Sub

    Public Overrides Sub SetVariablesVisible(bVisible As Boolean)
        MyBase.SetVariablesVisible(bVisible)
        btnAdd.Visible = bVisible
        btnDataOptions.Visible = bVisible
    End Sub

    Public Overrides Sub EnableDataOptions(strCurrentType As String)
        If strCurrentType = "column" Then
            btnDataOptions.Enabled = True
        Else
            btnDataOptions.Enabled = False
        End If
    End Sub

    Public Sub HideShowAddOrDataOptionsButton(Optional bAddVisible As Boolean = True, Optional bDataOptionsVisible As Boolean = True)
        btnDataOptions.Visible = bDataOptionsVisible
        btnAdd.Visible = bAddVisible
    End Sub
End Class
