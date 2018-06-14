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

Public Class dlgReshapeClimaticData
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True


    Private Sub dlgReshapeClimaticData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        'autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()

        ucrPnlReshapeClimaticData.AddRadioButton(rdoYear)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoMonth)
        ucrPnlReshapeClimaticData.AddRadioButton(rdoDay)

        ' ucrPnlReshapeClimaticData.s(grpYear, {rdoYear}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        'ucrPnlReshapeClimaticData.AddToLinkedControls(grpMonth, {rdoMonth})
        'ucrPnlReshapeClimaticData.AddToLinkedControls(ucrChkVarWidth, {rdoDay}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

    End Sub

    Private Sub SetDefaults()

    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
    End Sub

    Private Sub TestOkEnabled()

    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOkEnabled()
    End Sub
    Private Sub GroupBoxDisplayOnReopen()
        If rdoYear.Checked Then
            grpDay.Visible = False
            grpMonth.Visible = False
            grpYear.Visible = True
        ElseIf rdoMonth.Checked Then
            grpMonth.Visible = True
            grpYear.Visible = False
            grpDay.Visible = False
        Else
            grpDay.Visible = True
            grpMonth.Visible = False
            grpYear.Visible = False
        End If
    End Sub

    Private Sub ucrPnlReshapeClimaticData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlReshapeClimaticData.ControlValueChanged
        GroupBoxDisplayOnReopen()
    End Sub
End Class
