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

Public Class dlgRank
    'Define a boolean to check if the dialog is loading for the first time
    Public bFirstLoad As Boolean = True

    Private Sub dlgRank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        ucrBase.clsRsyntax.SetFunction("rank")
        ucrBase.iHelpTopicID = 25
        ucrNewColumnNameSelector.SetDataFrameSelector(ucrSelectorForRank.ucrAvailableDataFrames)
        ucrNewColumnNameSelector.SetPrefix("Rank")
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameSelector.cboColumnName.Text, strTempDataframe:=ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnNameSelector.cboColumnName.Text)


        If bFirstLoad Then
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        'Checks if Ok can be enabled.

        TestOKEnabled()

    End Sub

    'This runs on load and after anything is changed on the dialog.
    Private Sub TestOKEnabled()
        If ucrReceiverRank.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    ' Sub that runs only the first time the dialog loads
    Private Sub SetDefaults()
        ucrReceiverRank.SetMeAsReceiver()
        ucrReceiverRank.Selector = ucrSelectorForRank
        rdoKeptAsMissing.Checked = True
        rdoAverage.Checked = True
        ucrSelectorForRank.Reset()
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

        SetTiesValues()
        setMissingValue()
    End Sub

    Private Sub grpTies_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAverage.CheckedChanged, rdoMinimum.CheckedChanged, rdoMaximum.CheckedChanged, rdoFirst.CheckedChanged, rdoRandom.CheckedChanged
        SetTiesValues()

    End Sub

    Private Sub SetTiesValues()

        If rdoAverage.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "average" & Chr(34))
            Else
                ucrBase.clsRsyntax.RemoveParameter("ties.method")
            End If
        ElseIf rdoMinimum.Checked Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "min" & Chr(34))
        ElseIf rdoMaximum.Checked Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "max" & Chr(34))
        ElseIf rdoFirst.Checked Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "first" & Chr(34))
        ElseIf rdoRandom.Checked Then
            ucrBase.clsRsyntax.AddParameter("ties.method", Chr(34) & "random" & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("ties.method")
        End If

    End Sub

    'When the reset button is clicked, set the defaults again
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    'Use this event to see when something has changed in a receiver
    Private Sub ucrReceiverRank_SelectionChanged() Handles ucrReceiverRank.SelectionChanged
        If Not ucrReceiverRank.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", ucrReceiverRank.GetVariableNames(False))
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If


        TestOKEnabled()
    End Sub

    Private Sub rdoKeptAsMissing_CheckedChanged(sender As Object, e As EventArgs) Handles rdoKeptAsMissing.CheckedChanged, rdoFirstMissingValues.CheckedChanged, rdoLast.CheckedChanged
        setMissingValue()
    End Sub

    Private Sub setMissingValue()
        If rdoKeptAsMissing.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("na.last", Chr(34) & "keep" & Chr(34))
            Else
                ucrBase.clsRsyntax.RemoveParameter("na.last")
            End If
        ElseIf rdoFirstMissingValues.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.last", "FALSE")
        ElseIf rdoLast.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.last", "TRUE")
        Else
            ucrBase.clsRsyntax.RemoveParameter("na.last")
        End If
    End Sub

End Class
