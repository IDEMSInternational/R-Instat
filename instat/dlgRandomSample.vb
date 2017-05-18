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

Imports instat.Translations

Public Class dlgRandomSample
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsMultipleSamplesFunction As New RFunction
    Public clsCurrentDistribution As New Distribution
    Private clsDistribtionFunction As New RFunction
    Private clsSetSeed As New RFunction

    Private Sub dlgRandomSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 376

        ucrDistWithParameters.SetRDistributions()
        clsDistribtionFunction = ucrDistWithParameters.clsCurrRFunction
        ucrSampleSize.SetDataFrameSelector(ucrSelectorRandomSamples)

        ucrChkSetSeed.SetText("Set Seed")
        ucrChkSetSeed.AddFunctionNamesCondition(False, "set.seed")

        ucrNudSetSeed.SetParameter(New RParameter("seed", 0))
        ucrChkSetSeed.AddToLinkedControls(ucrLinked:=ucrNudSetSeed, objValues:={True}, bNewLinkedHideIfParameterMissing:=True)
        ucrNudSetSeed.SetMinMax(Integer.MinValue, Integer.MaxValue)

        ucrNudNumberOfSamples.SetMinMax(1, Integer.MaxValue)

        ucrSaveRandomSample.SetSaveTypeAsColumn()
        ucrSaveRandomSample.SetDataFrameSelector(ucrSelectorRandomSamples)
        ucrSaveRandomSample.SetIsComboBox()
        ucrSelectorRandomSamples.bUseCurrentFilter = False
    End Sub

    Private Sub SetDefaults()
        clsMultipleSamplesFunction = New RFunction
        clsSetSeed = New RFunction

        ucrSelectorRandomSamples.Reset()
        ucrSaveRandomSample.Reset()
        'ucrPrefixNewColumns.SetName("Rand")
        SetNewColumName()
        clsMultipleSamplesFunction.SetRCommand("data.frame")

        'setseed fuction
        clsSetSeed.SetPackageName("base")
        clsSetSeed.SetRCommand("set.seed")
        clsSetSeed.AddParameter("seed", 1)

        ucrNudNumberOfSamples.Value = 1
        SetDataFrameandDistributionParameters()
        SetNumberOfSamplesParameters()
        ucrDistWithParameters.SetParameters()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveRandomSample.GetText, strTempDataframe:=ucrSelectorRandomSamples.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveRandomSample.GetText)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDistribtionFunction)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        ucrChkSetSeed.SetRCode(clsSetSeed, bReset)
        ucrNudSetSeed.SetRCode(clsSetSeed, bReset)
        ucrNudNumberOfSamples.SetRCode(clsDistribtionFunction)
        ucrSaveRandomSample.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub SetNewColumName()
        If ucrNudNumberOfSamples.Value = 1 Then
            ucrSaveRandomSample.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
            ucrSaveRandomSample.SetLabelText("New Column Name:")
            If Not ucrSaveRandomSample.bUserTyped Then
                ucrSaveRandomSample.SetPrefix("Rand")
            End If
        Else
            ucrSaveRandomSample.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
            ucrSaveRandomSample.SetLabelText("Prefix for New Columns:")
            ucrSaveRandomSample.SetPrefix("")
            If Not ucrSaveRandomSample.bUserTyped Then
                ucrSaveRandomSample.SetName("Rand")
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub SetDataFrameandDistributionParameters()
        If ucrDistWithParameters.clsCurrDistribution.strRName = "hyper" Then
            clsDistribtionFunction.AddParameter("nn", ucrSelectorRandomSamples.iDataFrameLength)
        Else
            clsDistribtionFunction.RemoveParameterByName("nn")
            clsDistribtionFunction.AddParameter("n", ucrSelectorRandomSamples.iDataFrameLength)
        End If
        SetNewColumName()
    End Sub

    'Private Sub SetAssignTo()
    '    If ucrNudNumberOfSamples.Text <> "" Then
    '        If ucrNudNumberOfSamples.Value = 1 Then
    '            ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveRandomSample.GetText, strTempDataframe:=ucrSelectorRandomSamples.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveRandomSample.GetText)
    '        Else
    '            ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrSaveRandomSample.GetText, strTempDataframe:=ucrSelectorRandomSamples.cboAvailableDataFrames.Text, strTempColumn:=ucrSaveRandomSample.GetText)
    '        End If
    '    Else
    '        ucrBase.clsRsyntax.RemoveAssignTo()
    '    End If
    'End Sub

    Private Sub SetNumberOfSamplesParameters()
        'If ucrNudNumberOfSamples.Text <> "" Then
        If ucrNudNumberOfSamples.Value = 1 Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDistribtionFunction)
            Else
                clsDistribtionFunction.RemoveAssignTo()
                clsMultipleSamplesFunction.ClearParameters()
                For i = 1 To ucrNudNumberOfSamples.Value
                    clsMultipleSamplesFunction.AddParameter("X" & i, clsRFunctionParameter:=clsDistribtionFunction)
                Next
                ucrBase.clsRsyntax.SetBaseRFunction(clsMultipleSamplesFunction)
            End If
        '  End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrDistWithParameters.bParametersFilled AndAlso ucrNudNumberOfSamples.Text <> "" AndAlso ucrNudNumberOfSamples.Text <> "" AndAlso (Not ucrChkSetSeed.Checked OrElse (ucrChkSetSeed.Checked AndAlso ucrNudSetSeed.Text <> "")) AndAlso ucrSaveRandomSample.IsComplete Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
        ucrBase.OKEnabled(True)
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkSetSeed.Checked Then
            frmMain.clsRLink.RunScript(clsSetSeed.ToScript(), strComment:="dlgRandomSample: Setting the seed for random number generator")
        End If
    End Sub

    Private Sub ucrDistWithParameters_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrDistWithParameters.cboDistributionsIndexChanged
        SetDataFrameandDistributionParameters()
    End Sub

    Private Sub ucrSelectorRandomSamples_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRandomSamples.ControlValueChanged
        SetDataFrameandDistributionParameters()
    End Sub

    Private Sub ucrNudNumberOfSamples_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberOfSamples.ControlValueChanged, ucrNudNumberOfSamples.ControlValueChanged
        SetNumberOfSamplesParameters()
        SetNewColumName()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberOfSamples.ControlContentsChanged, ucrNudSetSeed.ControlContentsChanged, ucrSaveRandomSample.ControlContentsChanged, ucrChkSetSeed.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrDistWithParameters_ParameterChanged() Handles ucrDistWithParameters.ParameterChanged
        TestOKEnabled()
    End Sub
End Class