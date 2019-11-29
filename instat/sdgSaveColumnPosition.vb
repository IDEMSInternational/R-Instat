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
    Private clsDefaultFunction As RFunction
    Public bControlsNotInitialised As Boolean = True
    Public bUserSelected As Boolean = False
    Public bRcodeFlag As Boolean = False

    Private Sub sdgSaveColumnPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bControlsNotInitialised Then
            InitialiseControl()
            bControlsNotInitialised = False
        End If
    End Sub

    Private Sub InitialiseControl()
        'For ucrSelector
        ucrSelectorColumns.btnDataOptions.Visible = False

        'For ucrReceiver
        ucrReceiverColumn.SetParameter(New RParameter("adjacent_column", 1))
        ucrReceiverColumn.SetParameterIsString()
        ucrReceiverColumn.Selector = ucrSelectorColumns
        ucrReceiverColumn.SetMeAsReceiver()
        ucrReceiverColumn.bUseFilteredData = False
        ucrReceiverColumn.SetLinkedDisplayControl(lblColumns)

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

    End Sub

    Public Sub SetUp(clsColPosFunction As RFunction, strDataFrameName As String)
        If bControlsNotInitialised Then
            InitialiseControl()
            bControlsNotInitialised = False
        End If

        clsDefaultFunction = clsColPosFunction

        bRcodeFlag = True
        ucrSelectorColumns.SetDataframe(strDataFrameName, False)
        ucrPnlColumnPosition.SetRCode(clsDefaultFunction, True)
        ucrReceiverColumn.SetRCode(clsDefaultFunction, True)
        bRcodeFlag = False
        SetColumnControlsAndParameterState()
    End Sub

    Public Sub Reset()
        If bControlsNotInitialised Then
            InitialiseControl()
            bControlsNotInitialised = False
        End If
        ucrSelectorColumns.Reset()
        bUserSelected = False
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
            clsDefaultFunction.RemoveParameterByName("adjacent_column")
            ucrSelectorColumns.Visible = False
            ucrReceiverColumn.Visible = False
            lblColumns.Visible = False
            grpColumnPosition.Text = "New column will be at the: "
        ElseIf rdoEnd.Checked Then
            clsDefaultFunction.RemoveParameterByName("adjacent_column")
            ucrSelectorColumns.Visible = False
            ucrReceiverColumn.Visible = False
            lblColumns.Visible = False
            grpColumnPosition.Text = "New column will be at the: "
        ElseIf rdoBefore.Checked Then
            If Not ucrReceiverColumn.IsEmpty Then
                clsDefaultFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrReceiverColumn.GetVariableNames())
            Else
                clsDefaultFunction.RemoveParameterByName("adjacent_column")
            End If
            ucrSelectorColumns.Visible = True
            ucrReceiverColumn.Visible = True
            lblColumns.Visible = True
            grpColumnPosition.Text = "New column will be: "
        ElseIf rdoAfter.Checked Then
            If Not ucrReceiverColumn.IsEmpty Then
                clsDefaultFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrReceiverColumn.GetVariableNames())
            Else
                clsDefaultFunction.RemoveParameterByName("adjacent_column")
            End If
            ucrSelectorColumns.Visible = True
            ucrReceiverColumn.Visible = True
            lblColumns.Visible = True
            grpColumnPosition.Text = "New column will be: "
        End If
    End Sub

End Class
