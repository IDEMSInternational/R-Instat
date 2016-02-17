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

Imports RDotNet

Public Class ucrFactor
    Public WithEvents clsReceiver As ucrReceiverSingle
    Public clsRSyntax As New RSyntax
    Public bIsSelector As Boolean = False
    Public bIsMultipleSelector As Boolean = False

    Private Sub ucrFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        grdFactorData.SetSettings(unvell.ReoGrid.WorkbookSettings.View_ShowSheetTabControl, False)
    End Sub

    Public Sub SetReceiver(clsNewReceiver As ucrReceiverSingle)
        clsReceiver = clsNewReceiver
        RefreshFactorData()
    End Sub

    Public Sub SetAsSingleSelector()
        bIsSelector = True
        bIsMultipleSelector = False
    End Sub

    Public Sub SetAsMultipleSelector()
        bIsSelector = True
        bIsMultipleSelector = False
    End Sub

    Private Sub RefreshFactorData()
        Dim dfTemp As DataFrame

        If clsReceiver IsNot Nothing Then
            If clsReceiver.strDataType = "factor" Then
                If clsReceiver.GetVariableNames <> "" Then
                    dfTemp = frmMain.clsRLink.GetData(frmMain.clsRLink.strInstatDataObject & "$get_column_factor_levels(data_name = " & clsReceiver.GetDataName() & ", col_name = " & clsReceiver.GetVariableNames() & ")")
                    frmMain.clsGrids.FillSheet(dfTemp, "Factor Data", grdFactorData)
                    If bIsSelector Then
                        If bIsMultipleSelector Then
                            'Add a radio button column at end
                        Else
                            'Add a checkbox column at end
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub clsReceiver_SelectionChanged(sender As Object, e As EventArgs) Handles clsReceiver.SelectionChanged
        RefreshFactorData()
    End Sub

    Public Function GetSelectedLevels() As String
        'return a string of the names of the level(s) that have been checked
        Return ""
    End Function
End Class
