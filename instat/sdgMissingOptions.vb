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
Public Class sdgMissingOptions
    Private bFirstLoad As Boolean = True
    Private clsSummaryFunction As RFunction
    Private clsConcFunction As RFunction
    Private Sub sdgMissingOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        Dim lstCheckboxes As New List(Of ucrCheck)
        ucrChkMaxNumMissing.AddToLinkedControls({ucrNudNumber}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkMaxPercMissing.AddToLinkedControls({ucrInputPercentage}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkMinNumNonMissing.AddToLinkedControls({ucrNudNumberNotMissing}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=340)
        ucrChkConsecutiveMissing.AddToLinkedControls({ucrNudConsecutive}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=4)

        ucrChkMaxNumMissing.SetParameter(New RParameter("n", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "'n'" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMaxNumMissing.SetText("Maximum number of missing allowed")

        ucrChkMinNumNonMissing.SetParameter(New RParameter("n_non_miss", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "'n_non_miss'" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMinNumNonMissing.SetText("Minimum number of non missing required")

        ucrChkMaxPercMissing.SetParameter(New RParameter("prop", 3), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "'prop'" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMaxPercMissing.SetText("Maximum percentage of missing allowed")

        ucrChkConsecutiveMissing.SetParameter(New RParameter("con", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "'con'" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkConsecutiveMissing.SetText("Maximum number of consecutive missing allowed")

        ucrInputPercentage.SetParameter(New RParameter("na_max_prop", 10))
        ucrInputPercentage.SetValidationTypeAsNumeric(dcmMin:=0, dcmMax:=100)
        ucrInputPercentage.AddQuotesIfUnrecognised = False

        ucrNudNumber.SetParameter(New RParameter("na_max_n", 11))
        ucrNudNumber.SetMinMax(0, iNewMax:=Integer.MaxValue)

        ucrNudNumberNotMissing.SetParameter(New RParameter("na_min_n", 12))
        ucrNudNumberNotMissing.SetMinMax(0, iNewMax:=Integer.MaxValue)

        ucrNudConsecutive.SetParameter(New RParameter("na_consecutive_n", 13))
        ucrNudConsecutive.SetMinMax(0, iNewMax:=Integer.MaxValue)

        lstCheckboxes.AddRange({ucrChkMaxNumMissing, ucrChkMinNumNonMissing, ucrChkMaxPercMissing, ucrChkConsecutiveMissing})
        For Each ctrTemp As ucrCheck In lstCheckboxes
            ctrTemp.SetParameterIncludeArgumentName(False)
            ctrTemp.SetRDefault(Chr(34) & Chr(34))
        Next
    End Sub

    Public Sub SetRFunction(clsNewSummaryFunction As RFunction, clsNewConcFunction As RFunction, Optional bReset As Boolean = False)
        If bFirstLoad Then
            InitialiseControls()
            bFirstLoad = False
        End If
        clsConcFunction = clsNewConcFunction
        clsSummaryFunction = clsNewSummaryFunction

        ucrInputPercentage.SetRCode(clsSummaryFunction, bReset, bCloneIfNeeded:=True)
        ucrNudNumber.SetRCode(clsSummaryFunction, bReset, bCloneIfNeeded:=True)
        ucrNudNumberNotMissing.SetRCode(clsSummaryFunction, bReset, bCloneIfNeeded:=True)
        ucrNudConsecutive.SetRCode(clsSummaryFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMaxNumMissing.SetRCode(clsConcFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMaxPercMissing.SetRCode(clsConcFunction, bReset, bCloneIfNeeded:=True)
        ucrChkConsecutiveMissing.SetRCode(clsConcFunction, bReset, bCloneIfNeeded:=True)
        ucrChkMinNumNonMissing.SetRCode(clsConcFunction, bReset, bCloneIfNeeded:=True)
    End Sub

    Private Sub ucrChkConsecutiveMissing_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkConsecutiveMissing.ControlValueChanged, ucrChkMaxNumMissing.ControlValueChanged, ucrChkMinNumNonMissing.ControlValueChanged, ucrChkMaxNumMissing.ControlValueChanged, ucrChkMaxPercMissing.ControlValueChanged
        If ucrChkConsecutiveMissing.Checked OrElse ucrChkMinNumNonMissing.Checked OrElse ucrChkMaxNumMissing.Checked OrElse ucrChkMaxPercMissing.Checked Then
            clsSummaryFunction.AddParameter("na_type", clsRFunctionParameter:=clsConcFunction, iPosition:=9)
        Else
            clsSummaryFunction.RemoveParameterByName("na_type")
        End If
    End Sub
End Class