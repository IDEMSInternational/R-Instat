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
Imports instat.Translations

Public Class ucrDataFrame
    Public iDataFrameLength As Integer
    Public iColumnCount As Integer
    Public clsCurrDataFrame As New RFunction
    Public bFirstLoad As Boolean = True
    Private bIncludeOverall As Boolean = False
    Private bPvtUseFilteredData As Boolean
    Public strCurrDataFrame As String = ""
    Public bDataFrameFixed As Boolean = False
    Private strFixedDataFrame As String

    Private Sub ucrDataFrame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FillComboBox()
        If bFirstLoad Then
            InitialiseControl()
            bFirstLoad = False
        End If
        SetDataFrameProperties()
    End Sub

    Private Sub InitialiseControl()
        bUseCurrentFilter = True
    End Sub

    Public Sub Reset()
        FillComboBox()
        If frmMain.strDefaultDataFrame <> "" Then
            cboAvailableDataFrames.SelectedIndex = cboAvailableDataFrames.Items.IndexOf(frmMain.strDefaultDataFrame)
        ElseIf frmMain.strCurrentDataFrame <> "" Then
            cboAvailableDataFrames.SelectedIndex = cboAvailableDataFrames.Items.IndexOf(frmMain.strCurrentDataFrame)
        End If
        SetDataFrameProperties()
    End Sub

    Private Sub FillComboBox(Optional bSetFixed As Boolean = True)
        Dim iOldText As String
        'TODO DO change DataFrameChanged event to not need these
        Dim sender As New Object
        Dim e As New EventArgs

        iOldText = cboAvailableDataFrames.Text
        cboAvailableDataFrames.Items.Clear()
        cboAvailableDataFrames.Text = ""
        frmMain.clsRLink.FillComboDataFrames(cboAvailableDataFrames, bFirstLoad, strCurrentDataFrame:=iOldText)
        If bSetFixed AndAlso bDataFrameFixed AndAlso strFixedDataFrame <> "" Then
            SetDataframe(strFixedDataFrame, False)
        End If
        If cboAvailableDataFrames.Text <> iOldText Then
            SelectedDataFrameChanged(sender, e)
        End If
    End Sub

    Public Event DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String)

    Private Sub cboAvailableDataFrames_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboAvailableDataFrames.SelectedIndexChanged
        SelectedDataFrameChanged(sender, e)
    End Sub

    Private Sub SelectedDataFrameChanged(sender As Object, e As EventArgs)
        If cboAvailableDataFrames.SelectedIndex = -1 Then
            cboAvailableDataFrames.Text = ""
        End If
        SetDataFrameProperties()
        RaiseEvent DataFrameChanged(sender, e, strCurrDataFrame)
        strCurrDataFrame = cboAvailableDataFrames.Text
    End Sub

    Public Sub SetDataFrameProperties()
        Dim clsParam As New RParameter
        If cboAvailableDataFrames.Text <> "" AndAlso Not bIncludeOverall Then
            If Not frmMain.clsRLink.DataFrameExists(cboAvailableDataFrames.Text) Then
                Reset()
                Exit Sub
            End If
            iDataFrameLength = frmMain.clsRLink.GetDataFrameLength(cboAvailableDataFrames.Text)
            iColumnCount = frmMain.clsRLink.GetDataFrameColumnCount(cboAvailableDataFrames.Text)
            clsCurrDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_data_frame")
            clsParam.SetArgumentName("data_name")
            clsParam.SetArgumentValue(Chr(34) & cboAvailableDataFrames.Text & Chr(34))
            clsCurrDataFrame.AddParameter(clsParam)
            clsCurrDataFrame.SetAssignTo(cboAvailableDataFrames.Text & "_temp")
        End If
    End Sub

    Public Sub SetDataframe(strDataframe As String, Optional bEnableDataframe As Boolean = True)
        Dim Index As Integer
        FillComboBox(False)
        Index = cboAvailableDataFrames.Items.IndexOf(strDataframe)
        If Index >= 0 Then
            cboAvailableDataFrames.SelectedIndex = Index
        End If
        If Not bEnableDataframe Then
            strFixedDataFrame = strDataframe
        Else
            strFixedDataFrame = ""
        End If
        cboAvailableDataFrames.Enabled = bEnableDataframe
        bDataFrameFixed = Not bEnableDataframe
    End Sub

    Public Sub SetIncludeOverall(bInclude As Boolean)
        bIncludeOverall = bInclude
        FillComboBox()
    End Sub

    Public Function GetIncludeOverall() As Boolean
        Return bIncludeOverall
    End Function

    Public Property bUseCurrentFilter As Boolean
        Get
            Return bPvtUseFilteredData
        End Get
        Set(bValue As Boolean)
            bPvtUseFilteredData = bValue
            If bPvtUseFilteredData Then
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    clsCurrDataFrame.AddParameter("use_current_filter", "TRUE")
                Else
                    clsCurrDataFrame.RemoveParameterByName("use_current_filter")
                End If
            Else
                clsCurrDataFrame.AddParameter("use_current_filter", "FALSE")
            End If
        End Set
    End Property
End Class