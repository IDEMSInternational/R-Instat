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
Public Class dlgContrasts
    Public bFirstLoad As Boolean = True
    Private Sub dlgContrasts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForContrasts.IsEmpty Then
            If rdoCurrentContrasts.Checked OrElse rdoHemert.Checked OrElse rdoPolynomials.Checked OrElse rdoSumToZero.Checked OrElse rdoTreatControl.Checked OrElse rdoUserDefined.Checked Then
                ucrBase.OKEnabled(True)
            Else
                ucrBase.OKEnabled(False)
            End If
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub InitialiseDialog()
        ucrReceiverForContrasts.Selector = ucrSelectorForContrast
        ucrReceiverForContrasts.SetMeAsReceiver()
        ucrReceiverForContrasts.SetIncludedDataTypes({"factor"})
        ucrBase.iHelpTopicID = 353
        ucrFactorLevelsAndLabels.SetReceiver(ucrReceiverForContrasts)
        ucrFactorLevelsAndLabels.SetAsSingleSelector()
    End Sub
    Private Sub SetDefaults()
        ucrSelectorForContrast.Reset()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrReceiverForContrasts_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForContrasts.SelectionChanged
        If ucrReceiverForContrasts.IsEmpty = False Then
            ucrBase.clsRsyntax.AddParameter("n", clsRFunctionParameter:=ucrReceiverForContrasts.GetVariables)
        Else
            ucrBase.clsRsyntax.RemoveParameter("n")
        End If
        TestOKEnabled()
    End Sub

    Private Sub rdoCurrentContrasts_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCurrentContrasts.CheckedChanged, rdoHemert.CheckedChanged, rdoPolynomials.CheckedChanged, rdoTreatControl.CheckedChanged, rdoUserDefined.CheckedChanged, rdoSumToZero.CheckedChanged
        ContrastsFunctions()
        TestOKEnabled()
    End Sub

    Private Sub ContrastsFunctions()
        If rdoSumToZero.Checked Then
            ucrBase.clsRsyntax.SetFunction("contr.sum")
        ElseIf rdoCurrentContrasts.Checked Then


        ElseIf rdoHemert.Checked Then
            ucrBase.clsRsyntax.SetFunction("contr.helmert")
        ElseIf rdoTreatControl.Checked Then
            ucrBase.clsRsyntax.SetFunction("contr.treatment")
        ElseIf rdoUserDefined.Checked

        Else
            ucrBase.clsRsyntax.SetFunction("contr.poly")
        End If
    End Sub
End Class