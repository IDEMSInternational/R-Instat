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
    Private bReset As Boolean = True
    Private clsSortDataFrame As New RFunction
    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub SetDefaults()
        clsSortDataFrame = New RFunction
        'Setting default Rfunction as the base function
        clsSortDataFrame.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")

        'Reset
        ucrSelectForSort.Reset()

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsSortDataFrame)
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
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
        grpMissingValues.Enabled = False

        'Setting Parameters
        ucrReceiverSort.Selector = ucrSelectForSort
        ucrReceiverSort.SetMeAsReceiver()
        ucrReceiverSort.SetParameter(New RParameter("col_names", 1))
        ucrReceiverSort.SetParameterIsString()

        'Add dataframe paramater
        ucrSelectForSort.SetParameter(New RParameter("data_name", 0))
        ucrSelectForSort.SetParameterIsString()

        'Set radiobutton parameters
        ucrPnlOrder.SetParameter(New RParameter("decreasing", 2))
        ucrPnlOrder.AddRadioButton(rdoAscending, "FALSE")
        ucrPnlOrder.AddRadioButton(rdoDescending, "TRUE")
        ucrPnlOrder.SetRDefault("FALSE")

        'Currently Disabled
        'ucrPanelMissingValues.SetParameter(New RParameter("na.last", 3))
        'ucrPanelMissingValues.AddRadioButton(rdoFirst, "FALSE")
        'ucrPanelMissingValues.AddRadioButton(rdoLast, "TRUE")
        'ucrPanelMissingValues.SetRDefault("TRUE")
        ucrPnlMissingValues.bAllowNonConditionValues = True
    End Sub

    'Setting Defaults on Reset 
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSort.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class