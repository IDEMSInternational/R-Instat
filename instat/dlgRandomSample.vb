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
    Public bFirstLoad As Boolean = True
    Private clsMultipleSamplesFunction As New RFunction
    Public clsCurrentDistribution As New Distribution
    Private clsDistribtionFunction As New RFunction
    Private clsSetSeed As New RFunction

    Private Sub dlgRandomSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 376
        ucrDistWithParameters.SetRDistributions()
        clsDistribtionFunction = ucrDistWithParameters.clsCurrRFunction
        ucrSampleSize.SetDataFrameSelector(ucrSelectorRandomSamples)
        clsMultipleSamplesFunction.SetRCommand("data.frame")
        clsSetSeed.SetRCommand("set.seed")
        nudSeed.Minimum = Integer.MinValue
        nudSeed.Maximum = Integer.MaxValue
        ucrNewColumnName.SetPrefix("Rand")
        ucrNewColumnName.SetItemsTypeAsColumns()
        ucrNewColumnName.SetDefaultTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorRandomSamples)
        ucrNewColumnName.SetValidationTypeAsRVariable()
        ucrPrefixNewColumns.SetValidationTypeAsRVariable()
        ucrSelectorRandomSamples.bUseCurrentFilter = False
    End Sub

    Private Sub SetDefaults()
        ucrSelectorRandomSamples.Reset()
        ucrPrefixNewColumns.SetName("Rand")
        SetDataFrameandDistributionParameters()
        nudNumberOfSamples.Value = 1
        SetNumberOfSamplesParameters()
        chkSetSeed.Checked = False
        nudSeed.Value = 1
        ucrDistWithParameters.SetParameters()
        SetSeedParameters()
    End Sub

    Private Sub ReopenDialog()
        SetAssignTo()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub SetSeedParameters()
        If chkSetSeed.Checked Then
            nudSeed.Visible = True
            If nudSeed.Text <> "" Then
                clsSetSeed.AddParameter("seed", nudSeed.Value)
            Else
                clsSetSeed.RemoveParameterByName("seed")
            End If
        Else
            nudSeed.Visible = False
            clsSetSeed.RemoveParameterByName("seed")
        End If
    End Sub

    Private Sub SetDataFrameandDistributionParameters()
        If ucrDistWithParameters.clsCurrDistribution.strRName = "hyper" Then
            clsDistribtionFunction.AddParameter("nn", ucrSelectorRandomSamples.iDataFrameLength)
        Else
            clsDistribtionFunction.RemoveParameterByName("nn")
            clsDistribtionFunction.AddParameter("n", ucrSelectorRandomSamples.iDataFrameLength)
        End If
        SetAssignTo()
        TestOKEnabled()
    End Sub

    Private Sub ucrPrefixNewColumns_NameChanged() Handles ucrPrefixNewColumns.NameChanged
        SetAssignTo()
        TestOKEnabled()
    End Sub

    Private Sub SetAssignTo()
        If nudNumberOfSamples.Text <> "" Then
            If nudNumberOfSamples.Value = 1 Then
                ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnName.GetText, strTempDataframe:=ucrSelectorRandomSamples.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText)
            Else
                ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrPrefixNewColumns.GetText, strTempDataframe:=ucrSelectorRandomSamples.cboAvailableDataFrames.Text, strTempColumn:=ucrPrefixNewColumns.GetText)
            End If
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub

    Private Sub SetNumberOfSamplesParameters()
        If nudNumberOfSamples.Text <> "" Then
            If nudNumberOfSamples.Value = 1 Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDistribtionFunction)
                ucrNewColumnName.Visible = True
                lblNewColumnName.Visible = True
                ucrPrefixNewColumns.Visible = False
                lblPrefixColumnName.Visible = False
            Else
                clsDistribtionFunction.RemoveAssignTo()
                clsMultipleSamplesFunction.ClearParameters()
                For i = 1 To nudNumberOfSamples.Value
                    clsMultipleSamplesFunction.AddParameter("X" & i, clsRFunctionParameter:=clsDistribtionFunction)
                Next
                ucrBase.clsRsyntax.SetBaseRFunction(clsMultipleSamplesFunction)
                ucrNewColumnName.Visible = False
                lblNewColumnName.Visible = False
                ucrPrefixNewColumns.Visible = True
                lblPrefixColumnName.Visible = True
            End If
            SetAssignTo()
        End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrDistWithParameters.bParametersFilled AndAlso nudNumberOfSamples.Text <> "" _
            AndAlso nudNumberOfSamples.Text <> "" AndAlso (Not chkSetSeed.Checked OrElse (chkSetSeed.Checked AndAlso nudSeed.Text <> "")) _
            AndAlso ((nudNumberOfSamples.Value = 1 AndAlso Not ucrNewColumnName.IsEmpty) OrElse (nudNumberOfSamples.Value <> 1 AndAlso Not ucrPrefixNewColumns.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If chkSetSeed.Checked Then
            frmMain.clsRLink.RunScript(clsSetSeed.ToScript(), strComment:="dlgRandomSample: Setting the seed for random number generator")
        End If
        TestOKEnabled()
    End Sub

    Private Sub chkSetSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSetSeed.CheckedChanged
        SetSeedParameters()
        TestOKEnabled()
    End Sub

    Private Sub nudNumberOfSamples_TextChanged(sender As Object, e As EventArgs) Handles nudNumberOfSamples.TextChanged
        SetNumberOfSamplesParameters()
        TestOKEnabled()
    End Sub

    Private Sub ucrNewColumnName_NameChanged() Handles ucrNewColumnName.NameChanged
        SetAssignTo()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistWithParameters_ParameterChanged() Handles ucrDistWithParameters.ParameterChanged
        TestOKEnabled()
    End Sub

    Private Sub nudSeed_TextChanged(sender As Object, e As EventArgs) Handles nudSeed.TextChanged
        SetSeedParameters()
        TestOKEnabled()
    End Sub

    Private Sub ucrDistWithParameters_cboDistributionsIndexChanged(sender As Object, e As EventArgs) Handles ucrDistWithParameters.cboDistributionsIndexChanged
        SetDataFrameandDistributionParameters()
    End Sub

    Private Sub ucrSelectorRandomSamples_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRandomSamples.ControlValueChanged
        SetDataFrameandDistributionParameters()
        TestOKEnabled()
    End Sub
End Class