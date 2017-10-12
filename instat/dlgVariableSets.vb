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
Public Class dlgVariableSets

    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgVariableSets_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            'setdefaults
            InitialiseDialog()
            bFirstLoad = False
        Else
            SetDialogOptions()
        End If

        If bReset Then
            'SetDefaults()
        End If

        'SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        ' TestOkEnabled()

    End Sub

    Private Sub InitialiseDialog()
        ucrPnlOptions.AddRadioButton(rdoMake)
        ucrPnlOptions.AddRadioButton(rdoEdit)
        ucrPnlOptions.AddRadioButton(rdoDelete)


    End Sub

    Private Sub SetDialogOptions()
        If rdoMake.Checked = True Then
            'clsRgeomPlotFunction.SetRCommand("geom_histogram")
            'ucrFactorReceiver.ChangeParameterName("fill")
            'cmdHistogramOptions.Text = "Histogram Options"
            'cmdHistogramOptions.Size = New Size(120, 25)
            'If Not ucrSaveHist.bUserTyped Then
            'ucrSaveHist.SetPrefix("histogram")
            'End If
        ElseIf rdoEdit.Checked = True Then
            'clsRgeomPlotFunction.SetRCommand("geom_density")
            'ucrFactorReceiver.ChangeParameterName("colour")
            'cmdHistogramOptions.Text = "Density Options"
            'cmdHistogramOptions.Size = New Size(120, 25)
            'If Not ucrSaveHist.bUserTyped Then
            'ucrSaveHist.SetPrefix("density")
            'End If
        ElseIf rdoDelete.Checked = True Then
            'clsRgeomPlotFunction.SetRCommand("geom_freqpoly")
            ' ucrFactorReceiver.ChangeParameterName("colour")
            ' cmdHistogramOptions.Text = "Frequency Polygon Options"
            '  cmdHistogramOptions.Size = New Size(160, 25)
            'If Not ucrSaveHist.bUserTyped Then
            '  ucrSaveHist.SetPrefix("frequency_polygon")
            'End If
        End If
    End Sub


End Class