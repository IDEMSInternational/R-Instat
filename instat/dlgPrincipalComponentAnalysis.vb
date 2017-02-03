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
Imports instat
Imports instat.Translations
Public Class dlgPrincipalComponentAnalysis
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private bResetSubdialog As Boolean = False
    'Public ExplanatoryVariables
    'Public strModelName As String = ""

    Private Sub dlgPrincipalComponentAnalysis_oad(sender As Object, e As EventArgs) Handles MyBase.Load
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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 422
        ucrBase.clsRsyntax.iCallType = 0
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ComponentsMinimum()

        'ucrReceiver
        ucrReceiverMultiplePCA.SetParameter(New RParameter("X", 1))
        ucrReceiverMultiplePCA.SetParameterIsRFunction()
        ucrReceiverMultiplePCA.Selector = ucrSelectorPCA
        ucrReceiverMultiplePCA.SetDataType("numeric")
        ucrReceiverMultiplePCA.SetMeAsReceiver()

        'ucrSaveResult
        ucrSaveResult.SetPrefix("PCA")
        ucrSaveResult.SetSaveTypeAsModel()
        ucrSaveResult.SetDataFrameSelector(ucrSelectorPCA.ucrAvailableDataFrames)
        ucrSaveResult.SetCheckBoxText("Save Result")
        ucrSaveResult.SetIsComboBox()
        ucrSaveResult.SetAssignToIfUncheckedValue("last_PCA")

        'ucrNud
        ucrNudNumberOfComp.SetParameter(New RParameter("ncp"))

        'ucrCheckBox
        ucrChkScaleData.SetParameter(New RParameter("scale.unit"))
        ucrChkScaleData.SetText("Scale Data")
        ucrChkScaleData.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkScaleData.SetRDefault("TRUE")

        sdgPrincipalComponentAnalysis.ucrSelectorFactor.SetDataframe(ucrSelectorPCA.ucrAvailableDataFrames.strCurrDataFrame, bEnableDataframe:=False)
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        ucrSelectorPCA.Reset()

        clsDefaultFunction.SetRCommand("PCA")
        clsDefaultFunction.AddParameter("ncp", 2)
        clsDefaultFunction.AddParameter("graph", "FALSE") ' I don't know what this is for, but it's in there?
        clsDefaultFunction.SetAssignTo("last_PCA", strTempModel:="last_PCA", strTempDataframe:=ucrSelectorPCA.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem)

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        bResetSubdialog = True
    End Sub

    Private Sub TestOKEnabled()
        If ucrSaveResult.IsComplete AndAlso Not ucrReceiverMultiplePCA.IsEmpty() AndAlso ucrNudNumberOfComp.GetText <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBasePCA_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub cmdPCAOptions_Click(sender As Object, e As EventArgs) Handles cmdPCAOptions.Click
        '        sdgPrincipalComponentAnalysis.SetRFunction(ucrBase.clsRsyntax.clsBaseFunction, bResetSubdialog)
        '        bResetSubdialog = False
        sdgPrincipalComponentAnalysis.ShowDialog()
    End Sub

    Private Sub ucrBasePCA_clickok(sender As Object, e As EventArgs) Handles ucrBase.ClickOk
        sdgPrincipalComponentAnalysis.PCAOptions()
    End Sub

    Private Sub ComponentsMinimum()
        If ucrReceiverMultiplePCA.IsEmpty Then
            ucrNudNumberOfComp.Minimum = 0
            ucrNudNumberOfComp.Value = 0
        ElseIf ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count = 1 Then
            ucrNudNumberOfComp.Minimum = 2
        ElseIf ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 1 Then
            ucrNudNumberOfComp.Minimum = 2
            If ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count > 5 Then
                ucrNudNumberOfComp.Value = 5
            Else
                ucrNudNumberOfComp.Value = ucrReceiverMultiplePCA.lstSelectedVariables.Items.Count
            End If
        End If
    End Sub

    Private Sub ucrReceiverMultiplePCA_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultiplePCA.ControlValueChanged, ucrNudNumberOfComp.ControlValueChanged
        ComponentsMinimum()
        '        sdgPrincipalComponentAnalysis.Dimensions()
    End Sub

    '  Private Sub nudComponents_TextChanged(sender As Object, e As EventArgs)
    '     sdgPrincipalComponentAnalysis.Dimensions()
    '  End Sub

    Private Sub ucr_for_Test_OK(ucrChangedControl As ucrCore) Handles ucrSaveResult.ControlContentsChanged, ucrReceiverMultiplePCA.ControlContentsChanged, ucrNudNumberOfComp.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class