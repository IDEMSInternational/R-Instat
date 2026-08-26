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

Public Class sdgChecksFromFactor
    Private bControlsInitialised As Boolean = False
    Private bChangeHandlerAdded As Boolean = False
    Private clsAugmentedFunction As RFunction

    Private Sub sdgChecksFromFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls(ucrTreatmentReceiver As ucrReceiverSingle)
        ucrChecksLevels.pnlSelectOptions.Controls.Remove(ucrChecksLevels.btnSelectAll)

        Dim pChecks As New RParameter("checks", 5)
        pChecks.bIsString = True
        ucrChecksLevels.SetParameter(pChecks)

        ucrChecksLevels.SetAsMultipleSelectorGrid(ucrTreatmentReceiver,
                                                   dctParamAndColNames:=New Dictionary(Of String, String) From {{"checks", ucrFactor.DefaultColumnNames.Label}},
                                                   hiddenColNames:={ucrFactor.DefaultColumnNames.Level},
                                                   bIncludeNALevel:=False)
        bControlsInitialised = True
    End Sub

    Public Sub SetRFunction(clsNewAugmentedFunction As RFunction, ucrTreatmentReceiver As ucrReceiverSingle, bReset As Boolean)
        If Not bControlsInitialised Then
            InitialiseControls(ucrTreatmentReceiver)
        End If
        clsAugmentedFunction = clsNewAugmentedFunction
        ucrChecksLevels.SetRCode(clsAugmentedFunction, bReset)

        If Not bChangeHandlerAdded Then
            AddHandler ucrChecksLevels.ControlValueChanged, AddressOf ucrChecksLevels_ControlValueChanged
            AddHandler ucrChecksLevels.GridContentReFilledFromR, AddressOf RestoreChecks
            bChangeHandlerAdded = True
        End If

        If Not bReset Then
            RestoreChecks()
        End If
    End Sub


    '' Re-ticks grid rows to match the "checks" parameter's current value after the grid is
    '' repopulated from R (e.g. when the data frame or treatment factor changes), so
    '' previously selected check varieties stay selected if they're still present.
    Private Sub RestoreChecks()
        Dim pChecks As RParameter = ucrChecksLevels.GetParameter()
        If pChecks Is Nothing OrElse String.IsNullOrEmpty(pChecks.strArgumentValue) OrElse pChecks.strArgumentValue = "none" Then Return

        Dim sheet = ucrChecksLevels.GridSheet
        If sheet Is Nothing Then Return

        Dim iSelectorCol As Integer = ucrChecksLevels.GetColumnIndex(ucrFactor.DefaultColumnNames.SelectorColumn)
        Dim iValueCol As Integer = ucrChecksLevels.GetColumnIndex(ucrFactor.DefaultColumnNames.Label)
        If iSelectorCol < 0 OrElse iValueCol < 0 Then Return

        For iRow As Integer = 0 To sheet.Rows - 1
            Dim cellLabel As String = sheet(iRow, iValueCol).ToString()
            If pChecks.strArgumentValue.Contains("""" & cellLabel & """") OrElse pChecks.strArgumentValue.Contains("'" & cellLabel & "'") Then
                sheet(iRow, iSelectorCol) = True
            Else
                sheet(iRow, iSelectorCol) = False
            End If
        Next
    End Sub


    ' Fires when the grid's selection changes. If nothing is selected, removes the "checks"
    ' parameter entirely rather than leaving an empty one on the function.
    Private Sub ucrChecksLevels_ControlValueChanged(ucrChangedControl As ucrCore)
        If Not ucrChecksLevels.IsAnyGridRowSelected() Then
            clsAugmentedFunction.RemoveParameterByName("checks")
        End If
    End Sub
End Class