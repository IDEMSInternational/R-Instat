' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgSort
    'Define a boolean to check if the dialog is loading for the first time
    Public bFirstLoad As Boolean = True

    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Set the things that will always be constant for the dialog
        ' e.g. function name, selectors and receivers
        'If this is the first load, set the defaults and then change bFirstLoad to False
        ' On future loads the dialog will keep previous values used
        ' and not reset to defaults.
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        grpMissingValues.Enabled = False
        'Checks if Ok can be enabled.
        'Define this method for each dialog 
        'depending on what parameters are neccessary for the function to run.
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    ' Sub that runs only the first time the dialog loads
    Private Sub SetDefaults()
        rdoLast.Checked = True
        rdoAscending.Checked = True
        ucrSelectForSort.Reset()
    End Sub

    'Currently we are not clearing the RSyntax after running script (only clearing strScript)
    'so I don't think this is neccessary. Should we be clearing the RSyntax as well?
    'Not clearing seems to be a good way to keep the parameters from the last call
    'but will there be unwanted consequences of this?
    Private Sub ReopenDialog()
        SetOrderValue()
        SetMissingValue()
    End Sub

    'Sub that tests if the OK button can be enabled.
    'This runs on load and after anything is changed on the dialog.
    'No other place needs to set Ok enabled, always done through this sub
    Private Sub TestOKEnabled()
        If ucrReceiverSort.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
        ucrReceiverSort.Selector = ucrSelectForSort
        ucrReceiverSort.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 339
    End Sub

    Private Sub ucrReceiverSort_SelectionChanged() Handles ucrReceiverSort.SelectionChanged
        If Not ucrReceiverSort.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_names", ucrReceiverSort.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_names")
        End If
        'Test ok enabled
        TestOKEnabled()
    End Sub

    'For grouped radio buttons put all CheckedChanged events into one sub and check which is checked.
    Private Sub grpOrder_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAscending.CheckedChanged, rdoDescending.CheckedChanged
        SetOrderValue()
    End Sub

    Private Sub SetOrderValue()
        If rdoAscending.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("decreasing", "FALSE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("decreasing")
            End If
        ElseIf rdoDescending.Checked Then
            ucrBase.clsRsyntax.AddParameter("decreasing", "TRUE")
        Else
            'This case should never happen if the dialog has been designed correctly,
            'but in case of problems it keeps the code stable
            ucrBase.clsRsyntax.RemoveParameter("decreasing")
        End If
    End Sub

    'Same here for this group of buttona
    Private Sub grpMissingValues_ChekedChanged(sender As Object, e As EventArgs) Handles rdoFirst.CheckedChanged, rdoLast.CheckedChanged
        SetMissingValue()
    End Sub

    Private Sub SetMissingValue()
        If rdoFirst.Checked Then
            ucrBase.clsRsyntax.AddParameter("na.last", "FALSE")
        ElseIf rdoLast.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("na.last", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("na.last")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("na.last")
        End If
    End Sub

    'When the reset button is clicked, set the defaults again
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectForSort_DataFrameChanged() Handles ucrSelectForSort.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectForSort.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34))
    End Sub
End Class