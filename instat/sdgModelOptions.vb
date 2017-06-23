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
Public Class sdgModelOptions
    Private bControlsInitialised As Boolean = False
    Public clsRCIFunction As New RFunction
    Public bFirstLoad As Boolean = True

    Private Sub sdgModelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub InitialiseControls()

        ucrPnlLinkFunctions.SetParameter(New RParameter("link", 0))

        ucrPnlLinkFunctions.AddRadioButton(rdoIdentity, Chr(34) & "identity" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoCauchit, Chr(34) & "cauchit" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdocloglog, Chr(34) & "cloglog" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoLog, Chr(34) & "log" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoSqrt, Chr(34) & "sqrt" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoProbit, Chr(34) & "probit" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoLogit, Chr(34) & "logit" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoMuSquaredInverse, Chr(34) & "1/mu^2" & Chr(34))
        ucrPnlLinkFunctions.AddRadioButton(rdoInverse, Chr(34) & "inverse" & Chr(34))
        bControlsInitialised = True

    End Sub

    Public Sub SetRFunction(clsNewRCIFunction As RFunction, Optional bReset As Boolean = False)
        If Not bControlsInitialised Then
            InitialiseControls()
        End If
        clsRCIFunction = clsNewRCIFunction
        ucrPnlLinkFunctions.SetRCode(clsRCIFunction, bReset)
    End Sub

    Public Sub SetDefaults()
        RestrictLink()
    End Sub

    Private Sub ResetLinks()
        rdoIdentity.Checked = False
        rdoCauchit.Checked = False
        rdocloglog.Checked = False
        rdoInverse.Checked = False
        rdoLog.Checked = False
        rdoLogit.Checked = False
        rdoMuSquaredInverse.Checked = False
        rdoProbit.Checked = False
        rdoSqrt.Checked = False

        rdoIdentity.Enabled = False
        rdoCauchit.Enabled = False
        rdocloglog.Enabled = False
        rdoInverse.Enabled = False
        rdoLog.Enabled = False
        rdoLogit.Enabled = False
        rdoMuSquaredInverse.Enabled = False
        rdoProbit.Enabled = False
        rdoSqrt.Enabled = False
    End Sub

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrFamily.DistributionsIndexChanged
        RestrictLink()
    End Sub

    Public Sub RestrictLink()
        Dim strFamilyName As String
        strFamilyName = ucrFamily.clsCurrDistribution.strNameTag
        ResetLinks()
        If strFamilyName = "Normal" Then
            rdoIdentity.Enabled = True
            'rdoIdentity.Checked = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
        End If
        If strFamilyName = "Binomial" Or strFamilyName = "Quasibinomial" Then
            rdoLogit.Enabled = True
            'rdoLogit.Checked = True
            rdoCauchit.Enabled = True
            rdocloglog.Enabled = True
            rdoLog.Enabled = True
            rdoProbit.Enabled = True
        End If
        If strFamilyName = "Gamma" Then
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            ' rdoLog.Checked = True
            rdoIdentity.Enabled = True
        End If
        If strFamilyName = "Poisson" Or strFamilyName = "Quasipoisson" Then
            rdoLog.Enabled = True
            '  rdoLog.Checked = True
            rdoIdentity.Enabled = True
            rdoSqrt.Enabled = True
        End If
        If strFamilyName = "Inverse_Gaussian" Then
            rdoMuSquaredInverse.Enabled = True
            ' rdoMuSquaredInverse.Checked = True
            rdoIdentity.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
        End If
        If strFamilyName = "Quasi" Then
            rdoIdentity.Enabled = True
            ' rdoIdentity.Checked = True
            rdocloglog.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            rdoLogit.Enabled = True
            rdoMuSquaredInverse.Enabled = True
            rdoProbit.Enabled = True
            rdoSqrt.Enabled = True
        End If
    End Sub

End Class