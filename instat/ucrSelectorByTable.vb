﻿' R- Instat
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

Imports instat

Public Class ucrSelectorByTable

    Public Overrides Sub LoadList()
        If ucrAvailableTables.cboAvailableTables.Text <> "" Then
            MyBase.LoadList()
        Else
            lstAvailableVariable.Clear()
        End If
    End Sub

    Private Sub ucrAvailableTables_ControlValueChanged(sender As Object) Handles ucrAvailableTables.ControlValueChanged
        strCurrentDataFrame = ucrAvailableTables.cboAvailableTables.Text
        If CurrentReceiver Is Nothing OrElse CurrentReceiver.bAttachedToPrimaryDataFrame Then
            strPrimaryDataFrame = strCurrentDataFrame
        End If
        LoadList()
        OnDataFrameChanged()
    End Sub

    Public Overrides Sub Reset()
        ucrAvailableTables.Reset()
        MyBase.Reset()
    End Sub

    Public Overrides Sub SetDataframe(strDataframe As String, Optional bEnableDataframe As Boolean = True, Optional bSilent As Boolean = False)
        bSilentDataFrameChange = bSilent
        ucrAvailableTables.SetDataframe(strDataframe, bEnableDataframe)
    End Sub

    Public Overridable Sub SetVariablesEnabled(bEnable As Boolean)
        lstAvailableVariable.Enabled = bEnable
    End Sub

    Public Overridable Sub SetVariablesVisible(bVisible As Boolean)
        lstAvailableVariable.Visible = bVisible
    End Sub

    Public Property bUseCurrentFilter As Boolean
        Get
            Return ucrAvailableTables.bUseCurrentFilter
        End Get
        Set(bValue As Boolean)
            ucrAvailableTables.bUseCurrentFilter = bValue
        End Set
    End Property

    Public Property bDropUnusedFilterLevels As Boolean
        Get
            Return ucrAvailableTables.bDropUnusedFilterLevels
        End Get
        Set(bValue As Boolean)
            ucrAvailableTables.bDropUnusedFilterLevels = bValue
        End Set
    End Property

    Public Sub SetParameterIsString()
        ucrAvailableTables.SetParameterIsString()
    End Sub

    Public Sub SetParameterIsrfunction()
        ucrAvailableTables.SetParameterIsRFunction()
    End Sub

    Private Sub ucrAvailableTables_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrAvailableTables.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

    Private Sub ucrAvailableTables_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrAvailableTables.ControlValueChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False, Optional bCloneIfNeeded As Boolean = False)
        MyBase.UpdateControl(bReset, bCloneIfNeeded)
        ucrAvailableTables.UpdateControl(bReset)
    End Sub

    Public Overrides Sub SetParameter(clsNewParameter As RParameter, Optional iIndex As Integer = 0)
        If bHasOwnParameter Then
            MyBase.SetParameter(clsNewParameter, iIndex)
        Else
            ucrAvailableTables.SetParameter(clsNewParameter, iIndex)
        End If
    End Sub

    Public Overrides Function GetParameterName() As String
        If bHasOwnParameter Then
            Return MyBase.GetParameterName()
        Else
            Return ucrAvailableTables.GetParameterName()
        End If
    End Function

    Public Overrides Function IsRDefault() As Boolean
        If bHasOwnParameter Then
            Return MyBase.IsRDefault()
        Else
            Return ucrAvailableTables.IsRDefault()
        End If
    End Function

    Public Overrides Sub AddOrRemoveParameter(bAdd As Boolean)
        If bHasOwnParameter Then
            MyBase.AddOrRemoveParameter(bAdd)
        Else
            ucrAvailableTables.AddOrRemoveParameter(bAdd)
        End If
    End Sub

    Public Overrides Function GetParameter(Optional iIndex As Integer = 0) As RParameter
        If bHasOwnParameter Then
            Return MyBase.GetParameter()
        Else
            Return ucrAvailableTables.GetParameter()
        End If
    End Function

    Public Overrides Sub SetRCode(clsNewCodeStructure As RCodeStructure, Optional bReset As Boolean = False, Optional bUpdate As Boolean = True, Optional bCloneIfNeeded As Boolean = False)
        MyBase.SetRCode(clsNewCodeStructure, bReset, bUpdate, bCloneIfNeeded)
        ucrAvailableTables.SetRCode(clsNewCodeStructure, bReset)
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If bHasOwnParameter Then
            MyBase.UpdateParameter(clsTempParam)
        End If
    End Sub

    Public Overrides Sub AddAdditionalCodeParameterPair(clsNewRCode As RCodeStructure, clsNewRParameter As RParameter, Optional iAdditionalPairNo As Integer = -1)
        MyBase.AddAdditionalCodeParameterPair(clsNewRCode, clsNewRParameter, iAdditionalPairNo)
        ucrAvailableTables.AddAdditionalCodeParameterPair(clsNewRCode, clsNewRParameter, iAdditionalPairNo)
    End Sub

    Public Sub SetLabelText(strText As String)
        ucrAvailableTables.SetLabelText(strText)
    End Sub

    Public Overrides Sub SetPrimaryDataFrameOptions(strNewPrimaryDataFrame As String, bNewOnlyLinkedToPrimaryDataFrames As Boolean, Optional bNewIncludePrimaryDataFrameAsLinked As Boolean = False)
        ucrAvailableTables.SetPrimaryDataFrameOptions(strNewPrimaryDataFrame:=strNewPrimaryDataFrame, bNewOnlyLinkedToPrimaryDataFrames:=bNewOnlyLinkedToPrimaryDataFrames, bNewIncludePrimaryDataFrameAsLinked:=bNewIncludePrimaryDataFrameAsLinked)
    End Sub

    Public Function IsEmpty() As Boolean
        If ucrAvailableTables.cboAvailableTables.Text = "" Then
            Return True
        Else
            Return False
        End If
    End Function
End Class