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
Public Class ucrContinuousVerification
    Private bControlsInitialised As Boolean = True
    Private clsListFunction As New RFunction
    Private lstSummaryCheckboxes As New List(Of ucrCheck)
    Private Sub ucrContinuousVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrChkME.SetParameter(New RParameter("ME", 0), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "ME" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkME.SetText("Mean error")

        ucrChkMAE.SetParameter(New RParameter("MAE", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "MAE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMAE.SetText("Mean absolute error")

        ucrChkMSE.SetParameter(New RParameter("MSE", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "MSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMSE.SetText("Mean squared error")

        lstSummaryCheckboxes.AddRange({ucrChkME, ucrChkMAE, ucrChkMSE})

        For Each ctr In lstSummaryCheckboxes
            ctr.SetParameterIncludeArgumentName(False)
            ctr.SetRDefault(Chr(34) & Chr(34))
        Next
    End Sub

    Public Sub SetRFunction(clsNewListFunction As RFunction, Optional bReset As Boolean = False)
        If bControlsInitialised Then
            InitialiseControls()
            bControlsInitialised = False
        End If

        clsListFunction = clsNewListFunction

        For Each ctr In lstSummaryCheckboxes
            ctr.SetRCode(clsListFunction, bReset)
        Next
    End Sub
End Class
