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
Public Class dlgNewSummaryTables
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private Sub dlgNewSummaryTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        bReset = False
        TestOKEnabled()
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)

    End Sub

    Private Sub SetDefaults()
        ucrFactorsSelector.Reset()
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverFactor.Selector = ucrFactorsSelector
        ucrReceiverNumeric.Selector = ucrFactorsSelector
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetDataType("factor")
        ucrReceiverNumeric.SetDataType("numeric")
        ucrCheckWeight.SetText("Weights")
        ucrCheckSummaries.SetText("Treat Summary Columns as a Further Factor")
        ucrCheckDisplayMargins.SetText("Dispaly Margins")
    End Sub

    Private Sub EnableCheckSummaries()
        If ucrReceiverNumeric.lstSelectedVariables.Items.Count > 1 Then
            ucrCheckSummaries.Enabled = True
        Else
            ucrCheckSummaries.Enabled = False
        End If
    End Sub

    Private Sub TestOKEnabled()
        'If Not ucrReceiverFactor.IsEmpty Then
        '    If ucrCheckWeight.Checked Then
        '        If ucrSingleReceiver.IsEmpty() Then
        '            ucrBase.OKEnabled(True)
        '        Else

        '        End If
        '        ucrBase.OKEnabled(False)
        '    End If
        '    ucrBase.OKEnabled(False)
        'End If
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs)
        sdgSummaries.ShowDialog()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverNumeric_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverNumeric.ControlValueChanged
        EnableCheckSummaries()
    End Sub

    Private Sub ucrReceiverFactor_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged, ucrCheckWeight.ControlContentsChanged, ucrSingleReceiver.ControlContentsChanged
        TestOKEnabled()
    End Sub

End Class