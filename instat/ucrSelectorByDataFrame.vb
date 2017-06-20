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

Imports instat

Public Class ucrSelectorByDataFrame

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
            OnResetReceivers()
            OnDataFrameChanged()
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

    Public Overridable Sub SetVariablesVisible(bVisible As Boolean)
        lstAvailableVariable.Visible = bVisible
    End Sub

    Public Property bUseCurrentFilter As Boolean
        Get
            Return ucrAvailableDataFrames.bUseCurrentFilter
        End Get
        Set(bValue As Boolean)
            ucrAvailableDataFrames.bUseCurrentFilter = bValue
        End Set
    End Property

    Public Sub SetParameterIsString()
        ucrAvailableDataFrames.SetParameterIsString()
    End Sub

    Public Sub SetParameterIsrfunction()
        ucrAvailableDataFrames.SetParameterIsRFunction()
    End Sub

    Private Sub ucrAvailableDataFrames_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrAvailableDataFrames.ControlContentsChanged
        OnControlContentsChanged()
    End Sub

    Private Sub ucrAvailableDataFrames_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrAvailableDataFrames.ControlValueChanged
        OnControlValueChanged()
    End Sub

    Public Overrides Sub UpdateControl(Optional bReset As Boolean = False)
        MyBase.UpdateControl(bReset)
        ucrAvailableDataFrames.UpdateControl(bReset)
    End Sub

    Public Overrides Sub SetParameter(clsNewParameter As RParameter, Optional iIndex As Integer = 0)
        If bHasOwnParameter Then
            MyBase.SetParameter(clsNewParameter, iIndex)
        Else
            ucrAvailableDataFrames.SetParameter(clsNewParameter, iIndex)
        End If
    End Sub

    Public Overrides Function GetParameterName() As String
        If bHasOwnParameter Then
            Return MyBase.GetParameterName()
        Else
            Return ucrAvailableDataFrames.GetParameterName()
        End If
    End Function

    Public Overrides Function IsRDefault() As Boolean
        If bHasOwnParameter Then
            Return MyBase.IsRDefault()
        Else
            Return ucrAvailableDataFrames.IsRDefault()
        End If
    End Function

    Public Overrides Sub AddOrRemoveParameter(bAdd As Boolean)
        If bHasOwnParameter Then
            MyBase.AddOrRemoveParameter(bAdd)
        Else
            ucrAvailableDataFrames.AddOrRemoveParameter(bAdd)
        End If
    End Sub

    Public Overrides Function GetParameter(Optional iIndex As Integer = 0) As RParameter
        If bHasOwnParameter Then
            Return MyBase.GetParameter()
        Else
            Return ucrAvailableDataFrames.GetParameter()
        End If
    End Function

    Public Overrides Sub SetRCode(clsNewCodeStructure As RCodeStructure, Optional bReset As Boolean = False)
        MyBase.SetRCode(clsNewCodeStructure, bReset)
        ucrAvailableDataFrames.SetRCode(clsNewCodeStructure, bReset)
    End Sub

    Public Overrides Sub UpdateParameter(clsTempParam As RParameter)
        If bHasOwnParameter Then
            MyBase.UpdateParameter(clsTempParam)
        End If
    End Sub

    Public Overrides Sub AddAdditionalCodeParameterPair(clsNewRCode As RCodeStructure, clsNewRParameter As RParameter, Optional iAdditionalPairNo As Integer = -1)
        MyBase.AddAdditionalCodeParameterPair(clsNewRCode, clsNewRParameter, iAdditionalPairNo)
        ucrAvailableDataFrames.AddAdditionalCodeParameterPair(clsNewRCode, clsNewRParameter, iAdditionalPairNo)
    End Sub

    Public Sub SetLabelText(strText As String)
        ucrAvailableDataFrames.SetLabelText(strText)
    End Sub
End Class