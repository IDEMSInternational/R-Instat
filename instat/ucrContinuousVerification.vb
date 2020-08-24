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
    Private lstContinuousCheckboxes As New List(Of ucrCheck)

    Private Sub InitialiseControls()
        'HydroGOF Options
        ucrChkMeanError.SetParameter(New RParameter("me", 1), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "me" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanError.SetText("Mean error")

        ucrChkMeanAbsoluteError.SetParameter(New RParameter("mae", 2), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mae" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanAbsoluteError.SetText("Mean absolute error")

        ucrChkRootMeanSquaredError.SetParameter(New RParameter("rmse", 3), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rmse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRootMeanSquaredError.SetText("Root mean squared error")

        ucrChkNormRootMeanSquaredError.SetParameter(New RParameter("nrmse", 4), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "nrmse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNormRootMeanSquaredError.SetText("Normalized root mean squared error")

        ucrChkPercentBias.SetParameter(New RParameter("PBIAS", 5), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "PBIAS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkPercentBias.SetText("Percent bias")

        ucrChkRatioOfRootMeanSquaredError.SetParameter(New RParameter("rsr", 6), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rsr" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRatioOfRootMeanSquaredError.SetText("Ratio of root mean square error")

        ucrChkRatioOfStandardDeviation.SetParameter(New RParameter("rSD", 7), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rSD" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRatioOfStandardDeviation.SetText("Ratio of standard deviations")

        ucrChkNashSutcliffeEfficiency.SetParameter(New RParameter("NSE", 8), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "NSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNashSutcliffeEfficiency.SetText("Nash-Sutcliffe efficiency")

        ucrChkModNashSutcliffeEff.SetParameter(New RParameter("mNSE", 9), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mNSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkModNashSutcliffeEff.SetText("Modified Nash-Sutcliffe efficiency")

        ucrChkRelativeNashSutcliffeEff.SetParameter(New RParameter("rNSE", 10), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rNSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRelativeNashSutcliffeEff.SetText("Relative Nash-Sutcliffe efficiency")

        ucrChkModifiedIndexOfAgreement.SetParameter(New RParameter("md", 11), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "md" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkModifiedIndexOfAgreement.SetText("Modified index of agreement")

        ucrChkModifiedIndexOfAgreement.AddToLinkedControls(ucrInputJmia, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkModNashSutcliffeEff.AddToLinkedControls(ucrInputJmia, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputJmia.SetLinkedDisplayControl(lblJmia)

        ucrChkIndexOfAgreement.SetParameter(New RParameter("d", 12), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "d" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkIndexOfAgreement.SetText("Index of agreement")

        ucrChkRelativeIndexOfAgreement.SetParameter(New RParameter("rd", 13), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rd" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRelativeIndexOfAgreement.SetText("Relative index of agreement")

        ucrChkCoefPersistence.SetParameter(New RParameter("cp", 14), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "cp" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCoefPersistence.SetText("Coefficient of persistence")

        ucrChkCoefDetermination.SetParameter(New RParameter("R2", 15), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "R2" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCoefDetermination.SetText("Coefficient of determination")

        ucrChkKlingGuptaEfficiency.SetParameter(New RParameter("KGE", 16), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "KGE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkKlingGuptaEfficiency.SetText("Kling-Gupta efficiency")

        ucrChkVolumetricEfficiency.SetParameter(New RParameter("VE", 17), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "VE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkVolumetricEfficiency.SetText("Volumetric efficiency")

        ucrChkMeanSquaredError.SetParameter(New RParameter("mse", 18), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanSquaredError.SetText("Mean squared error")

        ucrChkSumOfSquaredResiduals.SetParameter(New RParameter("ssq", 19), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "ssq" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSumOfSquaredResiduals.SetText("Sum of squared residuals")

        ucrChkCorrelations.SetParameter(New RParameter("summary_cor", 20), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_cor" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCorrelations.SetText("Pearson Correlation")

        ttVerificationSummaries.SetToolTip(ucrInputJmia.txtInput, "numeric value, with the exponent to be used in the computation of the modified index of agreement. The default value is j=1")

        ucrInputJmia.SetParameter(New RParameter("j", 9))
        ucrInputJmia.SetValidationTypeAsNumeric()
        ucrInputJmia.AddQuotesIfUnrecognised = False
        ucrInputJmia.SetRDefault(1)

        ucrChkSelectAll.SetText("Select all")

        lstContinuousCheckboxes.AddRange({ucrChkCorrelations, ucrChkCoefDetermination, ucrChkCoefPersistence, ucrChkIndexOfAgreement, ucrChkKlingGuptaEfficiency, ucrChkMeanAbsoluteError, ucrChkModifiedIndexOfAgreement, ucrChkMeanError, ucrChkModNashSutcliffeEff, ucrChkMeanSquaredError, ucrChkNormRootMeanSquaredError, ucrChkNashSutcliffeEfficiency, ucrChkPercentBias, ucrChkRelativeIndexOfAgreement, ucrChkRootMeanSquaredError, ucrChkRelativeNashSutcliffeEff, ucrChkRatioOfStandardDeviation, ucrChkRatioOfRootMeanSquaredError, ucrChkSumOfSquaredResiduals, ucrChkVolumetricEfficiency})

        For Each ctr In lstContinuousCheckboxes
            ctr.SetParameterIncludeArgumentName(False)
            ctr.SetRDefault(Chr(34) & Chr(34))
        Next
    End Sub

    Public Sub SetRCodeForControls(clsNewSummaryFunction As RFunction, clsNewListFunction As RFunction, Optional bReset As Boolean = False)
        If bControlsInitialised Then
            InitialiseControls()
            bControlsInitialised = False
        End If

        For Each ctr In lstContinuousCheckboxes
            ctr.SetRCode(clsNewListFunction, bReset)
            If ctr.Enabled = False Then
                ctr.Checked = False
                ucrChkSelectAll.Checked = False
            End If
        Next

        ucrInputJmia.SetRCode(clsNewSummaryFunction, bReset)

        If bReset Then
            ucrChkSelectAll.Checked = False
        End If
    End Sub

    Private Sub cmdHelp_Click(sender As Object, e As EventArgs) Handles cmdHelp.Click
        Dim clsHelp As New RFunction
        Dim strPackageName As String

        strPackageName = "hydroGOF"
        clsHelp.SetPackageName("utils")
        clsHelp.SetRCommand("help")
        clsHelp.AddParameter("package", Chr(34) & strPackageName & Chr(34))
        clsHelp.AddParameter("help_type", Chr(34) & "html" & Chr(34))
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for " & strPackageName & " Package. Generated from subdialog " & ParentForm.Text, iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub

    Private Sub ucrChkSelectAll_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectAll.ControlValueChanged
        If ucrChkSelectAll.Checked Then
            For Each ctrTemp In lstContinuousCheckboxes
                ctrTemp.Checked = True
            Next
            ucrChkSelectAll.SetText("Unselect all")
        Else
            For Each ctrTemp In lstContinuousCheckboxes
                ctrTemp.Checked = False
            Next
            ucrChkSelectAll.SetText("Select all")
        End If
    End Sub
End Class
