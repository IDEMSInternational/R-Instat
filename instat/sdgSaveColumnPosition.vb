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
    Private clsDefaultFunction As New RFunction
    Public bControlsInitialised As Boolean = True
    Public bUserSelected As Boolean = False
    Private strDefaultCol As String = ""

    Private Sub sdgSaveColumnPosition_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bControlsInitialised Then
            InitialiseControl()
            bControlsInitialised = False
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
        If bControlsInitialised Then
            InitialiseControl()
            bControlsInitialised = False
        End If

        clsDefaultFunction = clsColPosFunction

        ucrSelectorColumns.SetDataframe(strDataFrameName, False)

        ucrReceiverColumn.SetRCode(clsDefaultFunction, True)
        ucrPnlColumnPosition.SetRCode(clsDefaultFunction, True)

        strDefaultCol = ucrReceiverColumn.GetVariableNames()

    End Sub

    Private Sub Controls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColumnPosition.ControlValueChanged, ucrReceiverColumn.ControlValueChanged
        PositionOfDuplicatedColumn()
        'If ucrReceiverColumn.GetVariableNames() <> strDefaultCol Then
        '    bUserSelected = True
        'Else
        '    bUserSelected = False
        'End If
        bUserSelected = False
    End Sub

    'TODO. Can this be done implictly by the panel control ?
    Private Sub PositionOfDuplicatedColumn()
        If rdoStart.Checked Then
            clsDefaultFunction.RemoveParameterByName("adjacent_column")
        ElseIf rdoEnd.Checked Then
            clsDefaultFunction.RemoveParameterByName("adjacent_column")
        ElseIf rdoBefore.Checked Then
            If Not ucrReceiverColumn.IsEmpty Then
                clsDefaultFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrReceiverColumn.GetVariableNames())
            Else
                clsDefaultFunction.RemoveParameterByName("adjacent_column")
            End If
        ElseIf rdoAfter.Checked Then
            If Not ucrReceiverColumn.IsEmpty Then
                clsDefaultFunction.AddParameter(strParameterName:="adjacent_column", strParameterValue:=ucrReceiverColumn.GetVariableNames())
            Else
                clsDefaultFunction.RemoveParameterByName("adjacent_column")
            End If
        End If
    End Sub

    Private Sub TestOk()
        'TODO
    End Sub

End Class
