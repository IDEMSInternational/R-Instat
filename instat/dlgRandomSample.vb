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
    Private clsMultipleSamplesFunction As New RFunction
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

    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 31
        ucrDistWithParameters.SetRDistributions()
        clsDistribtionFunction = ucrDistWithParameters.clsCurrRFunction
        ucrSampleSize.SetDataFrameSelector(ucrSelectorRandomSamples)
        clsMultipleSamplesFunction.SetRCommand("data.frame")
        clsSetSeed.SetRCommand("set.seed")
        nudSeed.Minimum = Integer.MinValue
        nudSeed.Maximum = Integer.MaxValue
    End Sub

    Private Sub SetDefaults()
        ucrPrefixNewColumns.SetName("Rand")
        SetDataFrameParameters()
        nudNumberOfSamples.Value = 1
        SetNumberOfSamplesParameters()
        chkSetSeed.Checked = False
        nudSeed.Value = 1
        SetSeedParameters()
    End Sub

    Private Sub ReopenDialog()
        SetAssignTo()
    End Sub

    Private Sub ucrDataFrameSelector_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrSelectorRandomSamples.DataFrameChanged
        SetDataFrameParameters()
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

    Private Sub SetDataFrameParameters()
        clsDistribtionFunction.AddParameter("n", ucrSelectorRandomSamples.iDataFrameLength)
        SetAssignTo()
    End Sub

    Private Sub ucrPrefixNewColumns_NameChanged() Handles ucrPrefixNewColumns.NameChanged
        SetAssignTo()
    End Sub

    Private Sub SetAssignTo()
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrPrefixNewColumns.GetText, strTempDataframe:=ucrSelectorRandomSamples.cboAvailableDataFrames.Text, strTempColumn:=ucrPrefixNewColumns.GetText)
    End Sub

    Private Sub SetNumberOfSamplesParameters()
        If nudNumberOfSamples.Text <> "" Then
            If nudNumberOfSamples.Value = 1 Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsDistribtionFunction)
            Else
                clsDistribtionFunction.RemoveAssignTo()
                clsMultipleSamplesFunction.ClearParameters()
                For i = 1 To nudNumberOfSamples.Value
                    clsMultipleSamplesFunction.AddParameter("X" & i, clsRFunctionParameter:=clsDistribtionFunction)
                Next
                ucrBase.clsRsyntax.SetBaseRFunction(clsMultipleSamplesFunction)
            End If
            SetAssignTo()
        End If
    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrBase_BeforeClickOk(sender As Object, e As EventArgs) Handles ucrBase.BeforeClickOk
        If chkSetSeed.Checked AndAlso nudSeed.Text <> "" Then
            frmMain.clsRLink.RunScript(clsSetSeed.ToScript(), strComment:="dlgRandomSample: Setting the seed for random number generator")
        End If
    End Sub

    Private Sub chkSetSeed_CheckedChanged(sender As Object, e As EventArgs) Handles chkSetSeed.CheckedChanged
        SetSeedParameters()
    End Sub

    Private Sub nudNumberOfSamples_TextChanged(sender As Object, e As EventArgs) Handles nudNumberOfSamples.TextChanged
        SetNumberOfSamplesParameters()
    End Sub
End Class