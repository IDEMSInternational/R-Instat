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
    Private Sub sdgDescribe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
    End Sub

    Public Sub SetDefaults()
        chkMean.Checked = True
        chkStdDev.Checked = True
        chkMinimum.Checked = True
        chkMaximum.Checked = True
        chkNMissing.Checked = True
        chkN.Checked = True
        chkNTotal.Checked = True
        chkMedian.Checked = True
        chkRange.Checked = True
    End Sub

    Private Sub grpSummaries_CheckedChanged(sender As Object, e As EventArgs) Handles chkMean.CheckedChanged, chkMinimum.CheckedChanged, chkMaximum.CheckedChanged, chkMedian.CheckedChanged, chkRange.CheckedChanged, chkNTotal.CheckedChanged, chkStdDev.CheckedChanged, chkN.CheckedChanged, chkNMissing.CheckedChanged
        dlgDescriptiveStatistics.SummariesParameters()
    End Sub
End Class