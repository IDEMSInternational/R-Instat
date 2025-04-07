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

Public Class dlgTraits
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgTraits_Load(sender As Object, e As EventArgs) Handles Me.Load
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
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False

        ucrTraitGraphSelector.SetParameter(New RParameter("data_name", 0))
        ucrTraitGraphSelector.SetParameterIsString()

        ucrReceiverTrait.SetParameter(New RParameter("", 1))
        ucrReceiverTrait.Selector = ucrTraitGraphSelector
        ucrReceiverTrait.SetParameterIsString()
        ucrReceiverTrait.strSelectorHeading = "Traits"
        ucrReceiverTrait.SetIncludedDataTypes({"traits"})
    End Sub

    Private Sub SetDefaults()


        ucrTraitGraphSelector.Reset()
        ucrReceiverTrait.SetMeAsReceiver()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
    End Sub

    Private Sub TestOKEnabled()
        ucrBase.OKEnabled(Not ucrReceiverTrait.IsEmpty)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrCoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrTraitGraphSelector.ControlContentsChanged, ucrReceiverTrait.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class