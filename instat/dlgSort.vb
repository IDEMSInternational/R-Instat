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
    Private clsDefaultFunction As New RFunction

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

    Private Sub SetDefaults()
        'Setting default Rfunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        ucrSelectForSort.Reset()
    End Sub

    Private Sub ReopenDialog()
        SetOrderValue()
        SetMissingValue()
    End Sub
    'Setting OKEnabled for the dialogue
    Private Sub TestOKEnabled()
        If ucrReceiverSort.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 339

        'Setting Parameter to the variable's Receiver(ucrReceiverSort)
        ucrReceiverSort.Selector = ucrSelectForSort
        ucrReceiverSort.SetMeAsReceiver()
        ucrReceiverSort.SetParameter(New RParameter("col_names"))
        ucrReceiverSort.SetParameterIsString()

        ucrSelectForSort.SetParameter(New RParameter("data_name"))
        ucrSelectForSort.SetParameterIsString()

        ucrPanelOrder.SetParameter(New RParameter("decreasing"))
        'ucrPanelMissingValues.SetParameter(New RParameter(""))
        ucrPanelOrder.AddRadioButton(rdoAscending, "FALSE")
        ucrPanelOrder.AddRadioButton(rdoDescending, "TRUE")
        'ucrPanelMissingValues.AddRadioButton(rdoFirst, "na.last")
        'ucrPanelMissingValues.AddRadioButton(rdoLast, "na.last")

        'Set Default Rfunction
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
        clsDefaultFunction.AddParameter(ucrSelectForSort.GetParameter(), 0)

    End Sub
    'When the reset button is clicked, set the defaults again
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub SetOrderValue()
        'If rdoAscending.Checked Then
        '    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
        '        ucrBase.clsRsyntax.AddParameter("decreasing", "FALSE")
        '    Else
        '        ucrBase.clsRsyntax.RemoveParameter("decreasing")
        '    End If
        'ElseIf rdoDescending.Checked Then
        '    ucrBase.clsRsyntax.AddParameter("decreasing", "TRUE")
        'Else
        '    'This case should never happen if the dialog has been designed correctly,
        '    'but in case of problems it keeps the code stable
        '    ucrBase.clsRsyntax.RemoveParameter("decreasing")
        'End If
    End Sub


    Private Sub SetMissingValue()
        'If rdoFirst.Checked Then
        '    ucrBase.clsRsyntax.AddParameter("na.last", "FALSE")
        'ElseIf rdoLast.Checked Then
        '    If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
        '        ucrBase.clsRsyntax.AddParameter("na.last", "TRUE")
        '    Else
        '        ucrBase.clsRsyntax.RemoveParameter("na.last")
        '    End If
        'Else
        '    ucrBase.clsRsyntax.RemoveParameter("na.last")
        'End If
    End Sub

    Private Sub xx(ucrcore As ucrCore) Handles ucrReceiverSort.ControlContentsChanged, ucrSelectForSort.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class