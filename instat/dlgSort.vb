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
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If

        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub SetDefaults()
        'Setting default Rfunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, True)
        ucrSelectForSort.Reset()
        grpMissingValues.Enabled = False
    End Sub

    'Setting OKEnabled
    Private Sub TestOKEnabled()
        If Not ucrReceiverSort.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 339
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")

        'Setting Parameters
        ucrReceiverSort.Selector = ucrSelectForSort
        ucrReceiverSort.SetMeAsReceiver()
        ucrReceiverSort.SetParameter(New RParameter("col_names"))
        ucrReceiverSort.SetParameterIsString()

        ucrSelectForSort.SetParameter(New RParameter("data_name"))
        ucrSelectForSort.SetParameterIsString()

        ucrPanelOrder.SetParameter(New RParameter("decreasing"))
        ucrPanelOrder.AddRadioButton(rdoAscending, "FALSE")
        ucrPanelOrder.AddRadioButton(rdoDescending, "TRUE")
        ucrPanelOrder.SetRDefault("FALSE")

        'Currently Disabled

        'ucrPanelMissingValues.SetParameter(New RParameter("na.last"))
        'ucrPanelMissingValues.AddRadioButton(rdoFirst, "FALSE")
        'ucrPanelMissingValues.AddRadioButton(rdoLast, "TRUE")
        'ucrPanelMissingValues.SetRDefault("TRUE")

        'Set Default Rfunction & Parameters
        clsDefaultFunction.AddParameter("decreasing", "FALSE")
        'clsDefaultFunction.AddParameter("na.last", "TRUE")
        clsDefaultFunction.AddParameter(ucrSelectForSort.GetParameter(), 0)
    End Sub

    'Setting Defaults on Reset 
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSort.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class