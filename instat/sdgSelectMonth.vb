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

Imports instat.Translations
Public Class sdgSelectMonth
    Private ucrReceiverMonth As ucrReceiverSingle
    Private clsInOperator As New ROperator
    Private clsFilterMonthFunction As New RFunction
    Private clsListCalcFunction As New RFunction
    Private lblHelperText As Label

    Private Sub sdgSelectMonth_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InitialiseControls()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ' Create the helper label
        lblHelperText = New Label()
        lblHelperText.Text = "Month variable is numeric and has no month labels." & Environment.NewLine &
                             "Convert Month to a factor (e.g., via Climatic > Dates > Use Date)."
        lblHelperText.Dock = DockStyle.Fill
        lblHelperText.TextAlign = ContentAlignment.MiddleCenter
        lblHelperText.ForeColor = Color.Red
        lblHelperText.Visible = False
        Me.Controls.Add(lblHelperText)
        lblHelperText.BringToFront()
        Dim strVarName As String = ucrReceiverMonth.GetVariableNames(bWithQuotes:=False)
        If String.IsNullOrWhiteSpace(strVarName) Then
            ucrMonthAsFactor.Visible = True
            lblHelperText.Visible = False
            Return
        End If

        ' Check if the linked receiver exists
        If ucrReceiverMonth IsNot Nothing Then
            ' Get the variable type from R
            Dim strColType As String = frmMain.clsRLink.GetColumnType(
                ucrReceiverMonth.GetDataName(),
                ucrReceiverMonth.GetVariableNames(bWithQuotes:=False)
            )

            ' If factor, show the grid; else show the helper label
            If strColType.Contains("factor") Then
                ucrMonthAsFactor.SetAsMultipleSelectorGrid(ucrReceiverMonth,
                                                           hiddenColNames:={ucrFactor.DefaultColumnNames.Level},
                                                           bIncludeNALevel:=False)
                ucrMonthAsFactor.Visible = True
                lblHelperText.Visible = False
            Else
                ucrMonthAsFactor.Visible = False
                lblHelperText.Visible = True
            End If
        End If

        ' Disable Select All button by default
        ucrMonthAsFactor.btnSelectAll.Enabled = False
    End Sub

    Public Sub SetRCode(Optional clsNewInOperator As ROperator = Nothing, Optional clsNewListCalcFunction As RFunction = Nothing, Optional clsNewFilterMonthFunction As RFunction = Nothing, Optional ucrNewReceiverMonth As ucrReceiverSingle = Nothing, Optional bReset As Boolean = False)
        ucrReceiverMonth = ucrNewReceiverMonth
        clsInOperator = clsNewInOperator
        clsFilterMonthFunction = clsNewFilterMonthFunction
        clsListCalcFunction = clsNewListCalcFunction
    End Sub

    Private Sub ucrMonthAsFactor_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrMonthAsFactor.ControlValueChanged
        clsInOperator.AddParameter("months",
                                   mdlCoreControl.GetRVector(ucrMonthAsFactor.GetSelectedCellValues(ucrFactor.DefaultColumnNames.Label, True)),
                                   iPosition:=1)
        If ucrMonthAsFactor.IsAnyGridRowSelected Then
            clsListCalcFunction.AddParameter("month_filter", clsRFunctionParameter:=clsFilterMonthFunction, bIncludeArgumentName:=False, iPosition:=0)
        Else
            clsListCalcFunction.RemoveParameterByName("month_filter")
        End If
    End Sub
End Class