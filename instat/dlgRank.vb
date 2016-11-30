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
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()

    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("rank")
        ucrReceiverRank.Selector = ucrSelectorForRank
        ucrReceiverRank.bUseFilteredData = False
        ucrReceiverRank.SetIncludedDataTypes({"numeric"})
        ucrBase.iHelpTopicID = 25

        ucrInputColName.SetPrefix("Rank")
        ucrInputColName.SetItemsTypeAsColumns()
        ucrInputColName.SetDefaultTypeAsColumn()
        ucrInputColName.SetDataFrameSelector(ucrSelectorForRank.ucrAvailableDataFrames)
        ucrInputColName.SetValidationTypeAsRVariable()
    End Sub

    'This runs on load and after anything is changed on the dialog.
    Private Sub TestOKEnabled()
        If Not ucrReceiverRank.IsEmpty() AndAlso Not ucrInputColName.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    ' Sub that runs only the first time the dialog loads
    Private Sub SetDefaults()
        ucrReceiverRank.Selector = ucrSelectorForRank
        ucrReceiverRank.SetMeAsReceiver()
        rdoKeptAsMissing.Checked = True
        rdoAverage.Checked = True
        ucrSelectorForRank.Reset()
        ucrInputColName.SetPrefix("Rank")
        rdoAverage.Checked = True
        rdoKeptAsMissing.Checked = True
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

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
    End Sub

    'Use this event to see when something has changed in a receiver
    Private Sub ucrReceiverRank_SelectionChanged() Handles ucrReceiverRank.SelectionChanged
        If Not ucrReceiverRank.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverRank.GetVariables())
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

    Private Sub ucrInputColName_NameChnahed() Handles ucrInputColName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColName.GetText, strTempDataframe:=ucrSelectorForRank.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColName.GetText)
        TestOKEnabled()
    End Sub
End Class
