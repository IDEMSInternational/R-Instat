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
    Public clsRCIFunction As RFunction
    Public bFirstLoad As Boolean

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        clsRCIFunction = New RFunction
        ucrFamily.SetGLMDistributions()
        bFirstLoad = True
    End Sub

    Private Sub sdgModelOptions_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        End If

    End Sub

    Private Sub InitialiseDialog()
    End Sub

    Public Sub SetDefaults()
        RestrictLink()
    End Sub

    Public Sub SetRCIFunction(clsNewFunction As RFunction)
        clsRCIFunction = clsNewFunction
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

    Public Sub ucrFamily_cboDistributionsIndexChanged() Handles ucrFamily.ControlValueChanged
        RestrictLink()
    End Sub

    Public Sub RestrictLink()
        Dim strFamilyName As String
        strFamilyName = ucrFamily.clsCurrDistribution.strNameTag
        ResetLinks()
        If strFamilyName = "Normal" Then
            rdoIdentity.Enabled = True
            rdoIdentity.Checked = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
        End If
        If strFamilyName = "Binomial" Or strFamilyName = "Quasibinomial" Then
            rdoLogit.Enabled = True
            rdoLogit.Checked = True
            rdoCauchit.Enabled = True
            rdocloglog.Enabled = True
            rdoLog.Enabled = True
            rdoProbit.Enabled = True
        End If
        If strFamilyName = "Gamma" Then
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            rdoLog.Checked = True
            rdoIdentity.Enabled = True
        End If
        If strFamilyName = "Poisson" Or strFamilyName = "Quasipoisson" Then
            rdoLog.Enabled = True
            rdoLog.Checked = True
            rdoIdentity.Enabled = True
            rdoSqrt.Enabled = True
        End If
        If strFamilyName = "Inverse_Gaussian" Then
            rdoMuSquaredInverse.Enabled = True
            rdoMuSquaredInverse.Checked = True
            rdoIdentity.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
        End If
        If strFamilyName = "Quasi" Then
            rdoIdentity.Enabled = True
            rdoIdentity.Checked = True
            rdocloglog.Enabled = True
            rdoInverse.Enabled = True
            rdoLog.Enabled = True
            rdoLogit.Enabled = True
            rdoMuSquaredInverse.Enabled = True
            rdoProbit.Enabled = True
            rdoSqrt.Enabled = True
        End If
        LinkFunction()
    End Sub

    Public Sub LinkFunction()
        Dim strLinkFunction As String = ""
        If rdoInverse.Checked Then
            strLinkFunction = "inverse"
        End If
        If rdoIdentity.Checked Then
            strLinkFunction = "identity"
        End If
        If rdoLog.Checked Then
            strLinkFunction = "log"
        End If
        If rdoLogit.Checked Then
            strLinkFunction = "logit"
        End If
        If rdoProbit.Checked Then
            strLinkFunction = "probit"
        End If
        If rdoCauchit.Checked Then
            strLinkFunction = "cauchit"
        End If
        If rdocloglog.Checked Then
            strLinkFunction = "cloglog"
        End If
        If rdoSqrt.Checked Then
            strLinkFunction = "sqrt"
        End If
        If rdoMuSquaredInverse.Checked Then
            strLinkFunction = "1/mu^2"
        End If
        clsRCIFunction.AddParameter("link", Chr(34) & strLinkFunction & Chr(34))
    End Sub

    Private Sub rdoCauchit_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCauchit.CheckedChanged, rdocloglog.CheckedChanged, rdoIdentity.CheckedChanged, rdoInverse.CheckedChanged, rdoLog.CheckedChanged, rdoLogit.CheckedChanged, rdoMuSquaredInverse.CheckedChanged, rdoProbit.CheckedChanged, rdoSqrt.CheckedChanged
        LinkFunction()
    End Sub
End Class