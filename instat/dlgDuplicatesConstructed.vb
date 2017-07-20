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
Imports instat
Imports instat.Translations

Public Class dlgDuplicatesConstructed
    Private bReset As Boolean = True
    Private bFirstLoad As Boolean = True
    Private clsDuplicate2, clsDuplicated As New RFunction
    Private Sub dlgDuplicatesConstructed_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrReceiverMultipleForDuplicates.Selector = ucrSelectorForDuplicates
        ucrReceiverMultipleForDuplicates.SetMeAsReceiver()

        ucrPnlDuplicates.AddRadioButton(rdoAllduplicatecases)
        ucrPnlDuplicates.AddRadioButton(rdoDuplicatesonly)
        ucrPnlDuplicates.AddRadioButton(rdoIndexnumberofduplicates)

        ucrPnlDuplicates.AddFunctionNamesCondition(rdoAllduplicatecases, "duplicated2")
        ucrPnlDuplicates.AddFunctionNamesCondition(rdoDuplicatesonly, "duplicated")
        rdoIndexnumberofduplicates.Enabled = False 'for now until it's working properly


    End Sub

    Private Sub SetDefaults()
        clsDuplicated = New RFunction
        clsDuplicate2 = New RFunction

        clsDuplicated.SetRCommand("duplicated")
        clsDuplicate2.SetPackageName("questionr")
        clsDuplicate2.SetRCommand("duplicated2")
        Dataframe()

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub TestOKEnabled()

    End Sub

    Private Sub Dataframe()
        If rdoDataframe.Checked Then
            ucrSelectorForDuplicates.SetVariablesVisible(False)
            ucrSelectorForDuplicates.Reset()
        Else
            ucrSelectorForDuplicates.SetVariablesVisible(True)
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlContentsChanged
        Dataframe()
    End Sub
End Class