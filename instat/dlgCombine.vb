'Instat-R
'Copyright (C) 2015
'This program is free software: you can redistribute it and/or modify
'it under the terms of the GNU General Public License as published by
'the Free Software Foundation, either version 3 of the License, or
'(at your option) any later version.
'This program is distributed in the hope that it will be useful,
'but WITHOUT ANY WARRANTY; without even the implied warranty of
'MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
'GNU General Public License for more details.
'You should have received a copy of the GNU General Public License k
'along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Public Class dlgCombine
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgCombine_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub


    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 39

        'ucrReceiver
        ucrFactorsReceiver.SetParameter(New RParameter("x"))
        ucrFactorsReceiver.strSelectorHeading = "Factors"
        ucrFactorsReceiver.SetParameterIsRFunction()
        ucrFactorsReceiver.Selector = ucrSelectorCombineFactors
        ucrFactorsReceiver.SetMeAsReceiver()
        ucrFactorsReceiver.bUseFilteredData = False
        ucrFactorsReceiver.SetIncludedDataTypes({"factor"})

        ' Input Column Name
        ucrNewColName.SetIsTextBox()
        ucrNewColName.SetPrefix("Interact")
        ucrNewColName.SetSaveTypeAsColumn()
        ucrNewColName.SetDataFrameSelector(ucrSelectorCombineFactors.ucrAvailableDataFrames)
        ucrNewColName.SetLabelText("New Column Name:")

        'chkbox
        ucrChkDropUnusedLevels.SetParameter(New RParameter("drop"))
        ucrChkDropUnusedLevels.SetText("Drop Unused Levels")
        ucrChkDropUnusedLevels.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkDropUnusedLevels.SetRDefault("FALSE")
    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorCombineFactors.Reset()

        clsDefaultFunction.SetRCommand("interaction")
        clsDefaultFunction.SetAssignTo(strTemp:=ucrNewColName.GetText(), strTempDataframe:=ucrSelectorCombineFactors.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColName.GetText())

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub ReOpenDialog()

    End Sub

    Private Sub TestOkEnabled()
        If (ucrFactorsReceiver.lstSelectedVariables.Items.Count > 1) AndAlso ucrNewColName.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrFactorsReceiver_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrFactorsReceiver.ControlContentsChanged, ucrNewColName.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class
