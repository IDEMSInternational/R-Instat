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
    Private clsSummaryFunction, clsListFunction As New RFunction
    Private lstSummaryCheckboxes As New List(Of ucrCheck)
    Private Sub ucrContinuousVerification_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bControlsInitialised Then
            InitialiseControls()
            bControlsInitialised = False
        End If
    End Sub

    Private Sub InitialiseControls()

        'HydroGOF Options
        ucrChkMeanError.SetParameter(New RParameter("me", 31), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "me" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanError.SetText("me")
        ttVerificationSummaries.SetToolTip(ucrChkMeanError.chkCheck, "Mean error")

        ucrChkMeanAbsoluteError.SetParameter(New RParameter("mae", 32), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mae" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanAbsoluteError.SetText("mae")
        ttVerificationSummaries.SetToolTip(ucrChkMeanAbsoluteError.chkCheck, "Mean absolute error")

        ucrChkRootMeanSquaredError.SetParameter(New RParameter("rmse", 33), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rmse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRootMeanSquaredError.SetText("rmse")
        ttVerificationSummaries.SetToolTip(ucrChkRootMeanSquaredError.chkCheck, "Root mean squared error")

        ucrChkNormRootMeanSquaredError.SetParameter(New RParameter("nrmse", 34), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "nrmse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNormRootMeanSquaredError.SetText("nrmse")
        ttVerificationSummaries.SetToolTip(ucrChkNormRootMeanSquaredError.chkCheck, "Normalized root mean squared error")

        ucrChkPercentBias.SetParameter(New RParameter("PBIAS", 35), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "PBIAS" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkPercentBias.SetText("PBIAS")
        ttVerificationSummaries.SetToolTip(ucrChkPercentBias.chkCheck, "Percent bias")

        ucrChkRatioOfRootMeanSquaredError.SetParameter(New RParameter("rsr", 36), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rsr" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRatioOfRootMeanSquaredError.SetText("rsr")
        ttVerificationSummaries.SetToolTip(ucrChkRatioOfRootMeanSquaredError.chkCheck, "Ratio of root mean square error")

        ucrChkRatioOfStandardDeviation.SetParameter(New RParameter("rSD", 37), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rSD" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRatioOfStandardDeviation.SetText("rSD")
        ttVerificationSummaries.SetToolTip(ucrChkRatioOfStandardDeviation.chkCheck, "Ratio of standard deviations")

        ucrChkNashSutcliffeEfficiency.SetParameter(New RParameter("NSE", 38), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "NSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkNashSutcliffeEfficiency.SetText("NSE")
        ttVerificationSummaries.SetToolTip(ucrChkNashSutcliffeEfficiency.chkCheck, "Nash-Sutcliffe efficiency")

        ucrChkModNashSutcliffeEff.SetParameter(New RParameter("mNSE", 39), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mNSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkModNashSutcliffeEff.SetText("mNSE")
        ttVerificationSummaries.SetToolTip(ucrChkModNashSutcliffeEff.chkCheck, "Modified Nash-Sutcliffe effieciency")

        ucrChkRelativeNashSutcliffeEff.SetParameter(New RParameter("rNSE", 40), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rNSE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRelativeNashSutcliffeEff.SetText("rNSE")
        ttVerificationSummaries.SetToolTip(ucrChkRelativeNashSutcliffeEff.chkCheck, "Relative Nash-Sutcliffe efficiency")

        ucrChkModifiedIndexOfAgreement.SetParameter(New RParameter("md", 41), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "md" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkModifiedIndexOfAgreement.SetText("md")
        ttVerificationSummaries.SetToolTip(ucrChkModifiedIndexOfAgreement.chkCheck, "Modified index of agreement")

        ucrChkModifiedIndexOfAgreement.AddToLinkedControls(ucrInputJmia, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=1)
        ucrChkModNashSutcliffeEff.AddToLinkedControls(ucrInputJmia, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrInputJmia.SetLinkedDisplayControl(lblJmia)

        ucrChkIndexOfAgreement.SetParameter(New RParameter("d", 42), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "d" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkIndexOfAgreement.SetText("d")
        ttVerificationSummaries.SetToolTip(ucrChkIndexOfAgreement.chkCheck, "Index of agreement")

        ucrChkRelativeIndexOfAgreement.SetParameter(New RParameter("rd", 43), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "rd" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkRelativeIndexOfAgreement.SetText("rd")
        ttVerificationSummaries.SetToolTip(ucrChkRelativeIndexOfAgreement.chkCheck, "Relative index of agreement")

        ucrChkCoefPersistence.SetParameter(New RParameter("cp", 44), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "cp" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCoefPersistence.SetText("cp")
        ttVerificationSummaries.SetToolTip(ucrChkCoefPersistence.chkCheck, "Coefficient of persistence")

        ucrChkCoefDetermination.SetParameter(New RParameter("R2", 45), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "R2" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCoefDetermination.SetText("R^2")
        ttVerificationSummaries.SetToolTip(ucrChkCoefDetermination.chkCheck, "Coefficient of determination")

        ucrChkKlingGuptaEfficiency.SetParameter(New RParameter("KGE", 46), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "KGE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkKlingGuptaEfficiency.SetText("KGE")
        ttVerificationSummaries.SetToolTip(ucrChkKlingGuptaEfficiency.chkCheck, "Kling-Gupta efficiency")

        ucrChkVolumetricEfficiency.SetParameter(New RParameter("VE", 47), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "VE" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkVolumetricEfficiency.SetText("VE")
        ttVerificationSummaries.SetToolTip(ucrChkVolumetricEfficiency.chkCheck, "Volumetric efficiency")

        ucrChkMeanSquaredError.SetParameter(New RParameter("mse", 48), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "mse" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkMeanSquaredError.SetText("mse")
        ttVerificationSummaries.SetToolTip(ucrChkMeanSquaredError.chkCheck, "Mean squared error")

        ucrChkSumOfSquaredResiduals.SetParameter(New RParameter("ssq", 49), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "ssq" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkSumOfSquaredResiduals.SetText("ssq")
        ttVerificationSummaries.SetToolTip(ucrChkSumOfSquaredResiduals.chkCheck, "Sum of squared residuals")

        ucrChkCorrelations.SetParameter(New RParameter("summary_cor", 49), bNewChangeParameterValue:=True, bNewAddRemoveParameter:=True, strNewValueIfChecked:=Chr(34) & "summary_cor" & Chr(34), strNewValueIfUnchecked:=Chr(34) & Chr(34))
        ucrChkCorrelations.SetText("r")
        ttVerificationSummaries.SetToolTip(ucrChkCorrelations.chkCheck, "Pearson Correlation")

        ttVerificationSummaries.SetToolTip(ucrInputJmia.txtInput, "numeric value, with the exponent to be used in the computation of the modified index of agreement. The default value is j=1")

        ucrInputJmia.SetParameter(New RParameter("j", 50))
        ucrInputJmia.SetValidationTypeAsNumeric()
        ucrInputJmia.AddQuotesIfUnrecognised = False
        ucrInputJmia.SetRDefault(1)

        ucrChkSelectAll.SetText("Select all")

        lstSummaryCheckboxes.AddRange({ucrChkCorrelations, ucrChkCoefDetermination, ucrChkCoefPersistence, ucrChkIndexOfAgreement, ucrChkKlingGuptaEfficiency, ucrChkMeanAbsoluteError, ucrChkModifiedIndexOfAgreement, ucrChkMeanError, ucrChkModNashSutcliffeEff, ucrChkMeanSquaredError, ucrChkNormRootMeanSquaredError, ucrChkNashSutcliffeEfficiency, ucrChkPercentBias, ucrChkRelativeIndexOfAgreement, ucrChkRootMeanSquaredError, ucrChkRelativeNashSutcliffeEff, ucrChkRatioOfStandardDeviation, ucrChkRatioOfRootMeanSquaredError, ucrChkSumOfSquaredResiduals, ucrChkVolumetricEfficiency})

        For Each ctr In lstSummaryCheckboxes
            ctr.SetParameterIncludeArgumentName(False)
            ctr.SetRDefault(Chr(34) & Chr(34))
        Next
    End Sub

    Public Sub SetRFunction(clsNewSummaryFunction As RFunction, clsNewListFunction As RFunction, Optional bReset As Boolean = False)
        clsListFunction = clsNewListFunction
        clsSummaryFunction = clsNewSummaryFunction

        For Each ctr In lstSummaryCheckboxes
            ctr.SetRCode(clsListFunction, bReset)
        Next

        ucrInputJmia.SetRCode(clsSummaryFunction, bReset)

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
        frmMain.clsRLink.RunScript(clsHelp.ToScript, strComment:="Opening help page for" & " " & strPackageName & " " & "Package. Generated from subdialog" & " " & ParentForm.Text, iCallType:=2, bSeparateThread:=False, bUpdateGrids:=False)
    End Sub
    Private Sub ucrChkSelectAll_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectAll.ControlValueChanged
        If ucrChkSelectAll.Checked Then
            For Each ctrTemp In lstSummaryCheckboxes
                ctrTemp.Checked = True
            Next
            ucrChkSelectAll.SetText("Unselect all")
        Else
            For Each ctrTemp In lstSummaryCheckboxes
                ctrTemp.Checked = False
            Next
            ucrChkSelectAll.SetText("Select all")
        End If
    End Sub
End Class
