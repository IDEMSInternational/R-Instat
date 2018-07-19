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

Public Class dlgClimaticLengthOfSeason
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private clsLengthOfSeasonFunction As New RFunction
    Private Sub dlgClimaticLengthOfSeason_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverStartofRains.Selector = ucrSelectorLengthofSeason
        ucrReceiverStartofRainsLogical.Selector = ucrSelectorLengthofSeason
        ucrReceiverEndofRains.Selector = ucrSelectorLengthofSeason
        ucrReceiverEndofRainsLogical.Selector = ucrSelectorLengthofSeason

        ucrChkLengthofSeason.AddToLinkedControls(ucrInputLengthofSeason, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkLengthofSeason.SetText("Length of Season")
        ucrInputLengthofSeason.SetName("Length")

        ucrChkType.AddToLinkedControls(ucrInputTextType, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrChkType.SetText("Occurence")
        ucrInputTextType.SetName("Type")
    End Sub

    Private Sub SetDefaults()

        ucrSelectorLengthofSeason.Reset()
        ucrReceiverStartofRains.SetMeAsReceiver()

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub
End Class