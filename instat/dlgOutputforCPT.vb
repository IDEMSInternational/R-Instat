
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

Public Class dlgOutputforCPT
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgOutputforCPT_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        ucrBase.clsRsyntax.iCallType = 1

    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction

        clsDefaultFunction.SetRCommand("climate_obj$output_for_CPT()")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub txtFilename_Leave(sender As Object, e As EventArgs) Handles txtFilename.Leave
        ucrBase.clsRsyntax.AddParameter("Filename", Chr(34) & txtFilename.Text & Chr(34))
        ' kept this the same for now as it's a txt and I'm not sure if we want it to be a ucrSave, ucrReceiver, or else
    End Sub

    Private Sub txtInterestedVariable_Leave(sender As Object, e As EventArgs) Handles txtInterestedVariable.Leave
        ucrBase.clsRsyntax.AddParameter("Interested_vaiables", Chr(34) & txtInterestedVariable.Text & Chr(34))
        ' kept this the same for now as it's a txt and I'm not sure if we want it to be a ucrSave, ucrReceiver, or else
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    'ControlContentsChanged
End Class