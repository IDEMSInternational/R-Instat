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

Public Class dlgRandomSample
    Private bFirstLoad As Boolean = True
    Private clsMultipleSamplesFunction As New RFunction
    Private clsDistributionFunction As New RFunction
    Private clsSetSeed As New RFunction
    Private bReset As Boolean = True

    Private Sub dlgRandomSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 376

        ucrNudNumberOfSamples.SetParameter(New RParameter("n", 0))
        ucrNudNumberOfSamples.SetMinMax(1, Integer.MaxValue)

        ucrSampleSize.SetDataFrameSelector(ucrSelectorRandomSamples)

        ucrSelectorRandomSamples.bUseCurrentFilter = False

        ucrChkSetSeed.SetText("Set Seed")
        ucrChkSetSeed.AddRSyntaxContainsFunctionNamesCondition(True, {"set.seed"})
        ucrChkSetSeed.AddRSyntaxContainsFunctionNamesCondition(False, {"set.seed"}, False)
        ucrChkSetSeed.AddToLinkedControls(ucrNudSeed, {True}, bNewLinkedHideIfParameterMissing:=True, bNewLinkedAddRemoveParameter:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=5)

        ucrNudSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSeed.SetMinMax(Integer.MinValue, Integer.MaxValue)

        ucrSaveRandomSample.SetSaveTypeAsColumn()
        ucrSaveRandomSample.SetDataFrameSelector(ucrSelectorRandomSamples)
        ucrSaveRandomSample.SetIsComboBox()
    End Sub

    Private Sub SetDefaults()
        clsSetSeed = New RFunction
        clsMultipleSamplesFunction = New RFunction
        clsDistributionFunction = New RFunction
        ucrBase.clsRsyntax.ClearCodes()
        ucrSelectorRandomSamples.Reset()
        ucrSaveRandomSample.Reset()
        SetNewColumName()

        clsSetSeed.SetRCommand("set.seed")

        ucrDistWithParameters.SetRDistributions()
        ucrDistWithParameters.SetParameters()

        clsMultipleSamplesFunction.SetRCommand("replicate")
        clsMultipleSamplesFunction.AddParameter("n", 1)

        clsDistributionFunction = ucrDistWithParameters.clsCurrRFunction

        clsMultipleSamplesFunction.AddParameter("expr", clsRFunctionParameter:=clsDistributionFunction)

        ucrBase.clsRsyntax.SetBaseRFunction(clsMultipleSamplesFunction)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveRandomSample.GetText, strTempDataframe:=ucrSelectorRandomSamples.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveRandomSample.GetText, bAssignToIsPrefix:=True)
        SetDataFrameAndDistributionParameters()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrNudSeed.SetRCode(clsSetSeed, bReset)
        ucrChkSetSeed.SetRCode(clsSetSeed, bReset)
        ucrChkSetSeed.SetRSyntax(ucrBase.clsRsyntax, bReset)
        ucrSaveRandomSample.SetRCode(clsMultipleSamplesFunction, bReset)
        ucrNudNumberOfSamples.SetRCode(clsMultipleSamplesFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If ((ucrDistWithParameters.bParametersFilled AndAlso ucrNudNumberOfSamples.GetText <> "") AndAlso
           ((Not ucrChkSetSeed.Checked) OrElse (ucrChkSetSeed.Checked AndAlso ucrNudSeed.GetText <> "")) _
            AndAlso ucrSaveRandomSample.IsComplete) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetNewColumName()
        If ucrNudNumberOfSamples.Value = 1 Then
            ucrSaveRandomSample.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
            ucrSaveRandomSample.SetLabelText("New Column Name:")
            If Not ucrSaveRandomSample.bUserTyped Then
                ucrSaveRandomSample.SetPrefix("random_sample")
            End If
        Else
            ucrSaveRandomSample.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
            ucrSaveRandomSample.SetLabelText("Prefix for New Columns:")
            If Not ucrSaveRandomSample.bUserTyped Then
                ucrSaveRandomSample.SetPrefix("")
                ucrSaveRandomSample.SetName("random_sample")
            End If
        End If
    End Sub

    Private Sub SetDataFrameAndDistributionParameters()
        If ucrDistWithParameters.clsCurrDistribution.strRName = "hyper" Then
            clsDistributionFunction.AddParameter("nn", ucrSelectorRandomSamples.iDataFrameLength)
        Else
            clsDistributionFunction.RemoveParameterByName("nn")
            clsDistributionFunction.AddParameter("n", ucrSelectorRandomSamples.iDataFrameLength)
        End If
    End Sub

    Private Sub ucrDistWithParameters_ucrInputDistributionsIndexChanged() Handles ucrDistWithParameters.DistributionsIndexChanged
        SetDataFrameAndDistributionParameters()
        TestOKEnabled()
    End Sub

    Private Sub ucrNudNumberOfSamples_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberOfSamples.ControlValueChanged
        SetNewColumName()
    End Sub

    Private Sub ucrSaveRandomSample_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSaveRandomSample.ControlContentsChanged, ucrSelectorRandomSamples.ControlContentsChanged, ucrChkSetSeed.ControlContentsChanged, ucrNudSeed.ControlContentsChanged, ucrSampleSize.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorRandomSamples_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRandomSamples.ControlValueChanged
        SetDataFrameAndDistributionParameters()
    End Sub

    Private Sub ucrDistWithParameters_ParameterChanged() Handles ucrDistWithParameters.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrChkSetSeed_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSetSeed.ControlValueChanged
        If ucrChkSetSeed.Checked Then
            ucrBase.clsRsyntax.AddToBeforeCodes(clsSetSeed, iPosition:=0)
        Else
            ucrBase.clsRsyntax.RemoveFromBeforeCodes(clsSetSeed)
        End If
    End Sub
End Class