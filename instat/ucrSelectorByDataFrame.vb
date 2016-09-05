' Instat+R
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

Public Class ucrSelectorByDataFrame
    Public Event DataFrameChanged()

    Public Overrides Sub LoadList()
        If ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            MyBase.LoadList()
        Else
            lstAvailableVariable.Clear()
        End If
    End Sub

    Private Sub ucrAvailableDataFrames_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrAvailableDataFrames.DataFrameChanged
        strCurrentDataFrame = ucrAvailableDataFrames.cboAvailableDataFrames.Text
        LoadList()
        If strPrevDataFrame <> ucrAvailableDataFrames.cboAvailableDataFrames.Text Then
            RaiseEvent DataFrameChanged()
            OnResetReceivers()
        End If
    End Sub

    Public Overrides Sub Reset()
        ucrAvailableDataFrames.Reset()
        MyBase.Reset()
    End Sub

    Private Sub ucrSelectorByDataFrame_DataFrameChanged() Handles Me.DataFrameChanged
        LoadList()
    End Sub

    Public Overrides Sub SetIncludeOverall(bInclude As Boolean)
        MyBase.SetIncludeOverall(bInclude)
        ucrAvailableDataFrames.SetIncludeOverall(bIncludeOverall)
        LoadList()
    End Sub

    Public Sub SetDataframe(strDataframe As String, Optional bEnableDataframe As Boolean = True)
        ucrAvailableDataFrames.SetDataframe(strDataframe, bEnableDataframe)
    End Sub

    Public Overridable Sub SetVariablesEnabled(bEnable As Boolean)
        lstAvailableVariable.Enabled = bEnable
    End Sub

    Public Property bUseCurrentFilter As Boolean
        Get
            Return ucrAvailableDataFrames.bUseCurrentFilter
        End Get
        Set(bValue As Boolean)
            ucrAvailableDataFrames.bUseCurrentFilter = bValue
        End Set
    End Property
End Class
