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

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations
Public Class sdgSaveColumnPosition
    Private clsColPosFunction As RFunction
    Public bControlsNotInitialised As Boolean = True
    Public bUserSelected As Boolean = False
    Public bRcodeFlag As Boolean = False

    Private Sub sdgSaveColumnPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bControlsNotInitialised Then
            InitialiseControl()
            bControlsNotInitialised = False
        End If
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControl()
        'For ucrSelector
        ucrSelectorColumns.btnDataOptions.Visible = False

        ucrBaseSubdialog.iHelpTopicID = 179

        'Panel and radio buttons
        ucrPnlColumnPosition.SetParameter(New RParameter("before"))

        ucrPnlColumnPosition.AddRadioButton(rdoStart, "TRUE")
        ucrPnlColumnPosition.AddRadioButton(rdoEnd, "FALSE")
        ucrPnlColumnPosition.AddRadioButton(rdoBefore, "TRUE")
        ucrPnlColumnPosition.AddRadioButton(rdoAfter, "FALSE")

        ucrPnlColumnPosition.AddParameterPresentCondition(rdoStart, "adjacent_column", False)
        ucrPnlColumnPosition.AddParameterPresentCondition(rdoEnd, "adjacent_column", False)
        ucrPnlColumnPosition.AddParameterPresentCondition(rdoBefore, "adjacent_column", True)
        ucrPnlColumnPosition.AddParameterPresentCondition(rdoAfter, "adjacent_column", True)

        'For ucrReceiver
        ucrReceiverColumn.SetParameter(New RParameter("adjacent_column"))
        ucrReceiverColumn.SetParameterIsString()
        ucrReceiverColumn.Selector = ucrSelectorColumns
        ucrReceiverColumn.SetMeAsReceiver()
        ucrReceiverColumn.bUseFilteredData = False
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumns)

        'todo. change visibilty to true once this feature is implemented
        ucrChkKeepExistingPos.Visible = False
        ucrChkKeepExistingPos.Text = "Keep existing position"
        ucrChkKeepExistingPos.SetParameter(New RParameter("keep_existing_position"))
        ucrChkKeepExistingPos.Checked = True
    End Sub

    Public Sub SetUp(strDataFrameName As String, bInsertColumnBefore As Boolean, strAdjacentColumn As String, bKeepExistingPosition As Boolean)
        If bControlsNotInitialised Then
            InitialiseControl()
            bControlsNotInitialised = False
        End If

        clsColPosFunction = New RFunction

        clsColPosFunction.AddParameter(strParameterName:="before", strParameterValue:=If(bInsertColumnBefore, "TRUE", "FALSE"))

        If Not String.IsNullOrEmpty(strAdjacentColumn) Then
            clsColPosFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=strAdjacentColumn)
        End If

        clsColPosFunction.AddParameter(strParameterName:="keep_existing_position", strParameterValue:=If(bKeepExistingPosition, "TRUE", "FALSE"))

        bRcodeFlag = True
        ucrSelectorColumns.SetDataframe(strDataFrameName, False)
        ucrPnlColumnPosition.SetRCode(clsColPosFunction, True)
        ucrReceiverColumn.SetRCode(clsColPosFunction, True)
        ucrChkKeepExistingPos.SetRCode(clsColPosFunction, True)
        bRcodeFlag = False
        SetColumnControlsAndParameterState()
    End Sub

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnPosition.ControlValueChanged, ucrReceiverColumn.ControlValueChanged
        If Not bRcodeFlag Then
            'in future this should be moved to UserValueChanged event
            bUserSelected = True
            SetColumnControlsAndParameterState()
        End If
    End Sub

    Private Sub SetColumnControlsAndParameterState()
        If rdoStart.Checked Then
            clsColPosFunction.RemoveParameterByName("adjacent_column")
            ucrSelectorColumns.Visible = False
            ucrReceiverColumn.Visible = False
            lblColumns.Visible = False
            grpColumnPosition.Text = GetTranslation("New column will be at the: ")
        ElseIf rdoEnd.Checked Then
            clsColPosFunction.RemoveParameterByName("adjacent_column")
            ucrSelectorColumns.Visible = False
            ucrReceiverColumn.Visible = False
            lblColumns.Visible = False
            grpColumnPosition.Text = GetTranslation("New column will be at the: ")
        ElseIf rdoBefore.Checked Then
            If Not ucrReceiverColumn.IsEmpty Then
                clsColPosFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrReceiverColumn.GetVariableNames())
            Else
                clsColPosFunction.RemoveParameterByName("adjacent_column")
            End If
            ucrSelectorColumns.Visible = True
            ucrReceiverColumn.Visible = True
            lblColumns.Visible = True
            grpColumnPosition.Text = GetTranslation("New column will be: ")
        ElseIf rdoAfter.Checked Then
            If Not ucrReceiverColumn.IsEmpty Then
                clsColPosFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrReceiverColumn.GetVariableNames())
            Else
                clsColPosFunction.RemoveParameterByName("adjacent_column")
            End If
            ucrSelectorColumns.Visible = True
            ucrReceiverColumn.Visible = True
            lblColumns.Visible = True
            grpColumnPosition.Text = GetTranslation("New column will be: ")
        End If
    End Sub

    Public ReadOnly Property InsertColumnBefore() As Boolean
        Get
            Return Not IsNothing(clsColPosFunction.GetParameter("before")) AndAlso clsColPosFunction.GetParameter("before").strArgumentValue = "TRUE"
        End Get
    End Property

    Public ReadOnly Property AdjacentColumn() As String
        Get
            Return If(IsNothing(clsColPosFunction.GetParameter("adjacent_column")), "", clsColPosFunction.GetParameter("adjacent_column").strArgumentValue)
        End Get
    End Property

    Public ReadOnly Property KeepExistingPosition() As Boolean
        Get
            Return Not IsNothing(clsColPosFunction.GetParameter("keep_existing_position")) AndAlso clsColPosFunction.GetParameter("keep_existing_position").strArgumentValue = "TRUE"
        End Get
    End Property

End Class
