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
Public Class sdgDescribe
    Public clsRMeanFunction, clsRStdDevFunction, clsRMinFunction, clsRMaxFunction, clsRMissingFunction, clsRMissingSubFunction As New RFunction
    Private Sub sdgDescribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub SetDefaults()
        chkMean.Checked = True
        chkStdDev.Checked = True
        chkMinimum.Checked = True
        chkMaximum.Checked = True
        chkNMissing.Checked = True
    End Sub

    Public Sub StatsOptions()
        If chkMean.Checked Then
            RMeans()
        End If
        If chkStdDev.Checked Then
            RStdDev()
        End If
        If chkMaximum.Checked Then
            RMax()
        End If
        If chkMinimum.Checked Then
            RMin()
        End If
        If chkNMissing.Checked Then
            RNMissing()
        End If
    End Sub

    Public Sub RMeans()
        If dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.lstSelectedVariables.Items.Count > 1 Then
            clsRMeanFunction.SetRCommand("apply")
            clsRMeanFunction.AddParameter("X", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
            clsRMeanFunction.AddParameter("MARGIN", "2")
            clsRMeanFunction.AddParameter("FUN", "mean")
            clsRMeanFunction.RemoveParameterByName("x")
        Else
            clsRMeanFunction.SetRCommand("mean")
            clsRMeanFunction.AddParameter("x", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
            clsRMeanFunction.RemoveParameterByName("X")
            clsRMeanFunction.RemoveParameterByName("MARGIN")
            clsRMeanFunction.RemoveParameterByName("FUN")
        End If
        frmMain.clsRLink.RunScript(clsRMeanFunction.ToScript(), 2)
    End Sub

    Public Sub RStdDev()
        If dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.lstSelectedVariables.Items.Count > 1 Then
            clsRStdDevFunction.SetRCommand("apply")
            clsRStdDevFunction.AddParameter("X", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
            clsRStdDevFunction.AddParameter("MARGIN", "2")
            clsRStdDevFunction.AddParameter("FUN", "sd")
            clsRStdDevFunction.RemoveParameterByName("x")
        Else
            clsRStdDevFunction.SetRCommand("sd")
            clsRStdDevFunction.AddParameter("x", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
            clsRStdDevFunction.RemoveParameterByName("X")
            clsRStdDevFunction.RemoveParameterByName("MARGIN")
            clsRStdDevFunction.RemoveParameterByName("FUN")
        End If
        frmMain.clsRLink.RunScript(clsRStdDevFunction.ToScript(), 2)
    End Sub

    Public Sub RMin()
        If dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.lstSelectedVariables.Items.Count > 1 Then
            clsRMinFunction.SetRCommand("apply")
            clsRMinFunction.AddParameter("X", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
            clsRMinFunction.AddParameter("MARGIN", "2")
            clsRMinFunction.AddParameter("FUN", "min")
            clsRMinFunction.RemoveParameterByName("x")
        Else
            clsRMinFunction.SetRCommand("min")
            clsRMinFunction.AddParameter("x", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
            clsRMinFunction.RemoveParameterByName("X")
            clsRMinFunction.RemoveParameterByName("MARGIN")
            clsRMinFunction.RemoveParameterByName("FUN")
        End If
        frmMain.clsRLink.RunScript(clsRMinFunction.ToScript(), 2)
    End Sub

    Public Sub RMax()
        If dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.lstSelectedVariables.Items.Count > 1 Then
            clsRMaxFunction.SetRCommand("apply")
            clsRMaxFunction.AddParameter("X", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
            clsRMaxFunction.AddParameter("MARGIN", "2")
            clsRMaxFunction.AddParameter("FUN", "max")
            clsRMaxFunction.RemoveParameterByName("x")
        Else
            clsRMaxFunction.SetRCommand("max")
            clsRMaxFunction.AddParameter("x", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
            clsRMaxFunction.RemoveParameterByName("X")
            clsRMaxFunction.RemoveParameterByName("MARGIN")
            clsRMaxFunction.RemoveParameterByName("FUN")
        End If
        frmMain.clsRLink.RunScript(clsRMaxFunction.ToScript(), 2)
    End Sub

    Public Sub RNMissing()
        clsRMissingSubFunction.SetRCommand("is.na")
        clsRMissingSubFunction.AddParameter("x", clsRFunctionParameter:=dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.GetVariables())
        If dlgDescriptiveStatistics.ucrReceiverDescribeOneVar.lstSelectedVariables.Items.Count > 1 Then
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
