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
Public Class dlgDescriptiveStatistics
    Public bFirstLoad As Boolean = True
    Public clsRBaseStatsFunction, clsRMissingFunction, clsRMissingSubFunction As New RFunction
    Private Sub dlgDescriptiveStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)



    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverDescribeOneVar.Selector = ucrSelectorDescribeOneVar
        ucrReceiverDescribeOneVar.SetDataType("numeric")
        ' ucrBaseDescribeOneVar.clsRsyntax.SetFunction("")
        ' ucrBaseDescribeOneVar.clsRsyntax.iCallType = 0
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub SetDefaults()
        ucrReceiverDescribeOneVar.SetMeAsReceiver()
        sdgDescribe.SetDefaults()
        ucrSelectorDescribeOneVar.Reset()
        ucrSelectorDescribeOneVar.Focus()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDescribeOneVar.IsEmpty() Then
            ucrBaseDescribeOneVar.OKEnabled(True)
        Else
            ucrBaseDescribeOneVar.OKEnabled(False)
        End If
    End Sub

    Public Sub ucrReceiverDescribeOneVar_selectionchanged() Handles ucrReceiverDescribeOneVar.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub cmdStatistics_Click(sender As Object, e As EventArgs) Handles cmdStatistics.Click
        sdgDescribe.ShowDialog()
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickOk(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickOk
        StatsOptions()
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickReset
        SetDefaults()
    End Sub
    Public Sub StatsOptions()
        If sdgDescribe.chkMean.Checked Then
            RBaseStats("mean")
        End If
        If sdgDescribe.chkStdDev.Checked Then
            RBaseStats("sd")
        End If
        If sdgDescribe.chkMaximum.Checked Then
            RBaseStats("max")
        End If
        If sdgDescribe.chkMinimum.Checked Then
            RBaseStats("min")
        End If
        If sdgDescribe.chkNMissing.Checked Then
            RNMissing("is.na")
        End If
        If sdgDescribe.chkN.Checked Then
            RNMissing("!is.na")
        End If
        If sdgDescribe.chkNTotal.Checked Then
            RBaseStats("length")
        End If
    End Sub

    Public Sub RBaseStats(strStat As String)
        If ucrReceiverDescribeOneVar.lstSelectedVariables.Items.Count > 1 Then
            clsRBaseStatsFunction.SetRCommand("apply")
            clsRBaseStatsFunction.AddParameter("X", clsRFunctionParameter:=ucrReceiverDescribeOneVar.GetVariables())
            clsRBaseStatsFunction.AddParameter("MARGIN", "2")
            clsRBaseStatsFunction.AddParameter("FUN", strStat)
            clsRBaseStatsFunction.RemoveParameterByName("x")
        Else
            clsRBaseStatsFunction.SetRCommand(strStat)
            clsRBaseStatsFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverDescribeOneVar.GetVariables())
            clsRBaseStatsFunction.RemoveParameterByName("X")
            clsRBaseStatsFunction.RemoveParameterByName("MARGIN")
            clsRBaseStatsFunction.RemoveParameterByName("FUN")
        End If
        frmMain.clsRLink.RunScript(clsRBaseStatsFunction.ToScript(), 2)
    End Sub

    Public Sub RNMissing(strMissing As String)
        clsRMissingSubFunction.SetRCommand(strMissing)
        clsRMissingSubFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverDescribeOneVar.GetVariables())
        If ucrReceiverDescribeOneVar.lstSelectedVariables.Items.Count > 1 Then
            clsRMissingFunction.SetRCommand("apply")
            clsRMissingFunction.AddParameter("X", clsRFunctionParameter:=clsRMissingSubFunction)
            clsRMissingFunction.AddParameter("MARGIN", "2")
            clsRMissingFunction.AddParameter("FUN", "sum")
            clsRMissingFunction.RemoveParameterByName("x")
        Else
            clsRMissingFunction.SetRCommand("sum")
            clsRMissingFunction.AddParameter("x", clsRFunctionParameter:=clsRMissingSubFunction)
            clsRMissingFunction.RemoveParameterByName("X")
            clsRMissingFunction.RemoveParameterByName("MARGIN")
            clsRMissingFunction.RemoveParameterByName("FUN")
        End If
        frmMain.clsRLink.RunScript(clsRMissingFunction.ToScript(), 2)
    End Sub

End Class
