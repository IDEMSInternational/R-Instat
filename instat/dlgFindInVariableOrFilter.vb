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
Public Class dlgFindInVariableOrFilter
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private iClick As Integer = 1

    Private Sub dlgFindInVariableOrFilter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRcodeForControls(bReset)

        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverVariable.Selector = ucrSelectorFind

        ucrPnlOptions.AddRadioButton(rdoVariable, True)
        ucrPnlOptions.AddRadioButton(rdoInFilter, False)
    End Sub

    Private Sub SetDefaults()
        ucrReceiverVariable.SetMeAsReceiver()
        cmdFindNext.Enabled = False
    End Sub


    Private Sub SetRcodeForControls(bReset As Boolean)
        'SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()

    End Sub

    Private Sub cmdFind_Click(sender As Object, e As EventArgs) Handles cmdFind.Click
        frmMain.ucrDataViewer.SearchInGrid(strPattern:=ucrInputPattern.GetText,
                                           strVariable:=ucrReceiverVariable.GetVariableNames,
                                           bFindNext:=False)
        iClick = 1
        cmdFindNext.Enabled = True
    End Sub

    Private Sub cmdFindNext_Click(sender As Object, e As EventArgs) Handles cmdFindNext.Click
        frmMain.ucrDataViewer.SearchInGrid(strPattern:=ucrInputPattern.GetText,
                                   strVariable:=ucrReceiverVariable.GetVariableNames,
                                   bFindNext:=True,
                                   iClick:=iClick)
        iClick += 1
    End Sub
End Class