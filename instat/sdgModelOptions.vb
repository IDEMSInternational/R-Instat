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

Public Class sdgModelOptions
    Private bControlsInitialised As Boolean = False
    Public clsFamilyFunction As New RFunction
    Public bFirstLoad As Boolean = True
    Public bRCodeSet As Boolean = True
    Private lstRadioButtons As New List(Of RadioButton)

    Private Sub sdgModelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()
        ucrPnlLinkFunctions.SetParameter(New RParameter("link", 0))
        ucrPnlLinkFunctions.AddRadioButton(rdoIdentity, Chr(34) & "identity" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoCauchit, Chr(34) & "cauchit" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoCloglog, Chr(34) & "cloglog" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoLog, Chr(34) & "log" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoSqrt, Chr(34) & "sqrt" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoProbit, Chr(34) & "probit" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoLogit, Chr(34) & "logit" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoMuSquaredInverse, Chr(34) & "1/mu^2" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoInverse, Chr(34) & "inverse" & Chr(34))
        'True because no fixed default (depends on distribution) and there may not be a link parameter present
        ucrPnlLinkFunctions.bAllowNonConditionValues = True
        ucrPnlLinkFunctions.bSetToFirstIfNoValue = False

        ucrDistributionChoice.SetGLMDistributions()
        ucrDistributionChoice.SetFunctionIsDistFunction()
        'Override so that distributions don't reset on loading
        ucrDistributionChoice.bFirstLoad = False

        lstRadioButtons.AddRange({rdoIdentity, rdoCauchit, rdoCloglog, rdoLog, rdoSqrt, rdoProbit, rdoLogit, rdoMuSquaredInverse, rdoInverse})
        bControlsInitialised = True
    End Sub

    Public Sub SetRCodeForControls(ucrNewDistributionChoice As ucrDistributions, clsNewFamilyFunction As RFunction, Optional bReset As Boolean = False)
        bRCodeSet = False
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsFamilyFunction = clsNewFamilyFunction
        ucrDistributionChoice.SetDataType(ucrNewDistributionChoice.strDataType)

        ucrPnlLinkFunctions.SetRCode(clsFamilyFunction, bReset)
        ucrDistributionChoice.SetRCode(clsFamilyFunction, bReset)

        bRCodeSet = True
        SetLinkFunctionsAvailable(Not clsFamilyFunction.ContainsParameter("link"))
    End Sub

    Private Sub ResetLinks()
        rdoIdentity.Enabled = False
        rdoCauchit.Enabled = False
        rdoCloglog.Enabled = False
        rdoInverse.Enabled = False
        rdoLog.Enabled = False
        rdoLogit.Enabled = False
        rdoMuSquaredInverse.Enabled = False
        rdoProbit.Enabled = False
        rdoSqrt.Enabled = False
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrDistributionChoice.DistributionsIndexChanged
        If bRCodeSet Then
            SetLinkFunctionsAvailable(True)
        End If
    End Sub

    Public Sub SetLinkFunctionsAvailable(Optional bSetDefault As Boolean = True)
        Dim strDistributionName As String

        strDistributionName = ucrDistributionChoice.clsCurrDistribution.strNameTag
        ResetLinks()
        If strDistributionName = "Normal" Then
            rdoIdentity.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            If bSetDefault Then
                rdoIdentity.Checked = True
            End If
        ElseIf strDistributionName = "Binomial" Or strDistributionName = "Quasibinomial" Then
            rdoLogit.Enabled = True
            rdoCauchit.Enabled = True
            rdoCloglog.Enabled = True
            rdoLog.Enabled = True
            rdoProbit.Enabled = True
            If bSetDefault Then
                rdoLogit.Checked = True
            End If
        ElseIf strDistributionName = "Gamma" Then
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            rdoIdentity.Enabled = True
            If bSetDefault Then
                rdoInverse.Checked = True
            End If
        ElseIf strDistributionName = "Poisson" Or strDistributionName = "Quasipoisson" Then
            rdoLog.Enabled = True
            rdoIdentity.Enabled = True
            rdoSqrt.Enabled = True
            If bSetDefault Then
                rdoLog.Checked = True
            End If
        ElseIf strDistributionName = "Inverse_Gaussian" Then
            rdoMuSquaredInverse.Enabled = True
            rdoIdentity.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            If bSetDefault Then
                rdoMuSquaredInverse.Checked = True
            End If
        ElseIf strDistributionName = "Quasi" Then
            rdoIdentity.Enabled = True
            rdoCloglog.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            rdoLogit.Enabled = True
            rdoMuSquaredInverse.Enabled = True
            rdoProbit.Enabled = True
            rdoSqrt.Enabled = True
            If bSetDefault Then
                rdoIdentity.Checked = True
            End If
        End If
        'Ensures a disabled radio button cannot be checked
        For i As Integer = 0 To lstRadioButtons.Count - 1
            If lstRadioButtons(i).Checked AndAlso Not lstRadioButtons(i).Enabled Then
                lstRadioButtons(i).Checked = False
            End If
        Next
    End Sub
End Class