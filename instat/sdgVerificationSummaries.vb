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

Public Class sdgVerificationSummaries
    Private bControlsInitialised As Boolean = True
    Private bResetSubdialog As Boolean = False
    Private lstSummaryCheckboxes As New List(Of ucrCheck)
    Private clsListFunction As New RFunction
    Private Sub sdgVerificationSummaries_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseControls()
        ucrChkHitRate.SetParameter(New RParameter("PODy", 21), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "PODy" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkHitRate.SetText("Hit Rate")

        ucrChkThreatScore.SetParameter(New RParameter("TS", 22), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "TS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkThreatScore.SetText("Threat Score")

        ucrChkEquitableThreatScore.SetParameter(New RParameter("ETS", 23), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "ETS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkEquitableThreatScore.SetText("Equitable Threat Score")

        ucrChkFalseAlarmRatio.SetParameter(New RParameter("FAR", 24), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "FAR" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkFalseAlarmRatio.SetText("False Alarm Ratio")

        ucrChkHeidkeSkillScore.SetParameter(New RParameter("HSS", 25), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "HSS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkHeidkeSkillScore.SetText("Heidke Skill Score")

        ucrChkPercentCorrect.SetParameter(New RParameter("PC", 26), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "PC" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkPercentCorrect.SetText("Percent Correct")

        ucrChkBias.SetParameter(New RParameter("BIAS", 27), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "BIAS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkBias.SetText("Bias")

        ucrChkExtremeDependencyScore.SetParameter(New RParameter("EDS", 28), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "EDS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkExtremeDependencyScore.SetText("Extreme Dependency Score")

        ucrChkSymmetricExtremeDependencyScore.SetParameter(New RParameter("SEDS", 29), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "SEDS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSymmetricExtremeDependencyScore.SetText("Symmetric Extreme Dependency Score")

        ucrChkExremalDependencyIndex.SetParameter(New RParameter("EDI", 30), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "EDI" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkExremalDependencyIndex.SetText("Exremal Dependency Index")

        ucrChkSymmetricExtremalDependenceIndex.SetParameter(New RParameter("SEDI", 31), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "SEDI" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSymmetricExtremalDependenceIndex.SetText("Symmetric Extremal Dependence Index")

        ucrChkCatPercentCorrect.SetParameter(New RParameter("pc", 32), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "pc" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCatPercentCorrect.SetText("Percent Correct")

        ucrChkCatHeidkeSkillScore.SetParameter(New RParameter("hss", 33), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "hss" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCatHeidkeSkillScore.SetText("Heidke Skill Score")

        ucrChkCatPierceSkillScore.SetParameter(New RParameter("pss", 34), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "pss" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCatPierceSkillScore.SetText("Pierce Skill Score")

        ucrChkGerrityScore.SetParameter(New RParameter("GS", 35), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "GS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkGerrityScore.SetText("Gerrity Score")

        lstSummaryCheckboxes.AddRange({ucrChkHitRate, ucrChkThreatScore, ucrChkEquitableThreatScore, ucrChkFalseAlarmRatio, ucrChkHeidkeSkillScore, ucrChkPercentCorrect, ucrChkBias, ucrChkExtremeDependencyScore, ucrChkSymmetricExtremeDependencyScore, ucrChkExremalDependencyIndex, ucrChkSymmetricExtremalDependenceIndex, ucrChkCatPercentCorrect, ucrChkCatHeidkeSkillScore, ucrChkCatPierceSkillScore, ucrChkGerrityScore})

        For Each ctr In lstSummaryCheckboxes
            ctr.SetParameterIncludeArgumentName(False)
            ctr.SetRDefault(Chr(34) & Chr(34))
        Next
    End Sub

    Public Sub SetRFunction(clsNewSummaryFunction As RFunction, clsNewListFunction As RFunction, Optional iNewTabIndexSelected As Integer = 0, Optional bReset As Boolean = False)
        If bControlsInitialised Then
            InitialiseControls()
            bControlsInitialised = False
        End If
        clsListFunction = clsNewListFunction

        For Each ctr In lstSummaryCheckboxes
            ctr.SetRCode(clsNewListFunction, bReset)
            If ctr.Enabled = False Then
                ctr.Checked = False
            End If
        Next
        bResetSubdialog = bReset

        ucrContinuousVerification.SetRCodeForControls(clsNewSummaryFunction:=clsNewSummaryFunction, clsNewListFunction:=clsNewListFunction, bReset:=bResetSubdialog)

        tbSummaries.SelectedIndex = iNewTabIndexSelected
    End Sub

    Private Sub ucrBase_ClickReturn(sender As Object, e As EventArgs) Handles ucrBase.ClickReturn
        If clsListFunction.clsParameters.Count = 0 Then
            MsgBox("No verification summary selected. Ok will not be enabled on the main dialog.", Title:="No verification summary selected", Buttons:=MsgBoxStyle.Information)
        End If
    End Sub

    Public Sub EnableDisableTabs(bEnabledDisabledContinuous As Boolean, bEnabledDisabledBinary As Boolean, bEnabledDisabledCategorical As Boolean)
        tbContinuous.Enabled = bEnabledDisabledContinuous
        tbBinary.Enabled = bEnabledDisabledBinary
        tbCategorical.Enabled = bEnabledDisabledCategorical
    End Sub
End Class