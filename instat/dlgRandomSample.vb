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

Public Class dlgRandomSample
    Private bFirstLoad As Boolean = True
    Private clsMultipleSamplesFunction As New RFunction
    Public clsCurrentDistribution As New Distribution
    Private clsDistribtionFunction As New RFunction
    Private clsSetSeed As New RFunction
    Private bReset As Boolean = True

    Private Sub dlgRandomSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
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

    Private Sub SetRCodeforControls(bReset As Boolean)
        ucrNudSeed.SetRCode(clsSetSeed, bReset)
        ucrChkSetSeed.SetRCode(clsSetSeed, bReset)
        ucrDistWithParameters.SetRCode(clsDistribtionFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 376
        ucrChkSetSeed.SetText("Set Seed:")
        ucrChkSetSeed.AddFunctionNamesCondition(False, "set.seed")
        ucrChkSetSeed.AddToLinkedControls(ucrNudSeed, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudSeed.SetParameter(New RParameter("seed", 0))
        ucrNudSeed.SetMinMax(Integer.MaxValue, Integer.MinValue)

        ucrSaveRandomSamples.SetSaveTypeAsColumn()
        ucrSaveRandomSamples.SetDataFrameSelector(ucrSelectorRandomSamples)
        ucrSaveRandomSamples.SetIsComboBox()


        ucrDistWithParameters.SetRDistributions()
        clsDistribtionFunction = ucrDistWithParameters.clsCurrRFunction
        ucrSampleSize.SetDataFrameSelector(ucrSelectorRandomSamples)

        ucrNudSeed.Maximum = Integer.MaxValue
        ucrNudNumberOfSamples.SetMinMax(Integer.MinValue, Integer.MaxValue)
        ucrSelectorRandomSamples.bUseCurrentFilter = False
    End Sub



    Private Sub SetNewColumName()
        If ucrNudNumberOfSamples.Value = 1 Then
            ucrSaveRandomSamples.SetAssignToBooleans(bTempAssignToIsPrefix:=False)
            ucrSaveRandomSamples.SetLabelText("New Column Name:")
            If Not ucrSaveRandomSamples.bUserTyped Then
                ucrSaveRandomSamples.SetPrefix("random_sample")
            End If
        Else
            ucrSaveRandomSamples.SetAssignToBooleans(bTempAssignToIsPrefix:=True)
            ucrSaveRandomSamples.SetLabelText("Prefix for New Columns:")
            If Not ucrSaveRandomSamples.bUserTyped Then
                ucrSaveRandomSamples.SetPrefix("")
                ucrSaveRandomSamples.SetName("random_sample")
            End If
        End If
    End Sub
    Private Sub SetDefaults()
        clsSetSeed = New RFunction
        clsMultipleSamplesFunction = New RFunction
        clsDistribtionFunction = New RFunction
        clsMultipleSamplesFunction = New RFunction

        ucrSelectorRandomSamples.Reset()
        clsMultipleSamplesFunction.SetRCommand("data.frame")
        clsSetSeed.SetRCommand("set.seed")
        clsSetSeed.AddParameter("seed", 5)

        setnumberofsamplesparameters()
        clsDistribtionFunction = ucrDistWithParameters.clsCurrRFunction
        setdataframeanddistributionparameters()
        ucrDistWithParameters.SetParameters()
        ucrBase.clsRsyntax.SetBaseRFunction(clsDistribtionFunction)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub setdataframeanddistributionparameters()
        If ucrDistWithParameters.clsCurrDistribution.strRName = "hyper" Then
            clsDistribtionFunction.AddParameter("nn", ucrSelectorRandomSamples.iDataFrameLength)
        Else
            clsDistribtionFunction.RemoveParameterByName("nn")
            clsDistribtionFunction.AddParameter("n", ucrSelectorRandomSamples.iDataFrameLength)
        End If
        TestOKEnabled()
    End Sub

    Private Sub setnumberofsamplesparameters()
        If ucrNudNumberOfSamples.Text <> "" Then
            If ucrNudNumberOfSamples.Value = 1 Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDistribtionFunction)
                clsDistribtionFunction.RemoveAssignTo()
                clsMultipleSamplesFunction.ClearParameters()
                For i = 1 To ucrNudNumberOfSamples.Value
                    clsMultipleSamplesFunction.AddParameter("x" & i, clsRFunctionParameter:=clsDistribtionFunction)
                Next
                ucrBase.clsRsyntax.SetBaseRFunction(clsMultipleSamplesFunction)
            End If
        End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrDistWithParameters.bParametersFilled AndAlso ucrNudNumberOfSamples.GetText <> "" _
            AndAlso ucrNudNumberOfSamples.GetText <> "" AndAlso (Not ucrChkSetSeed.Checked OrElse (ucrChkSetSeed.Checked AndAlso ucrNudSeed.Text <> "")) _
            AndAlso ((ucrNudNumberOfSamples.Value = 1 AndAlso ucrSaveRandomSamples.IsComplete) OrElse (ucrNudNumberOfSamples.GetText <> 1 AndAlso ucrSaveRandomSamples.IsComplete)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If ucrChkSetSeed.Checked Then
            frmMain.clsRLink.RunScript(clsSetSeed.ToScript(), strComment:="dlgRandomSample: Setting the seed for random number generator")
        End If
    End Sub

    Private Sub ucrDistWithParameters_ucrInputDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrDistWithParameters.ucrInputDistributionsIndexChanged
        setdataframeanddistributionparameters()
    End Sub

    Private Sub ucrSelectorRandomSamples_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRandomSamples.ControlValueChanged
        setdataframeanddistributionparameters()
        TestOKEnabled()
    End Sub

    Private Sub ucrNudNumberOfSamples_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudNumberOfSamples.ControlValueChanged
        SetNewColumName()
    End Sub
End Class