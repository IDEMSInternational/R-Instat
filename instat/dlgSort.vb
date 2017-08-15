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

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgSort
    'Define a boolean to check if the dialog is loading for the first time
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsSortFunction As New RFunction
    Public strSelectedDataFrame As String = ""
    Private bUseSelectedColumn As Boolean = False
    Private strSelectedColumn As String = ""
    Private Sub dlgSort_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        If bUseSelectedColumn Then
            SetDefaultColumn()
        End If
        SetRCodeForControls(bReset)
        bReset = False
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 339
        grpMissingValues.Enabled = False ' temporary

        'Add dataframe paramater
        ucrSelectForSort.SetParameter(New RParameter("data_name", 0))
        ucrSelectForSort.SetParameterIsString()

        'Setting Parameters
        ucrReceiverSort.SetParameter(New RParameter("col_names", 1))
        ucrReceiverSort.Selector = ucrSelectForSort
        ucrReceiverSort.SetMeAsReceiver()
        ucrReceiverSort.SetParameterIsString()

        'Set rdo parameters
        ucrPnlOrder.SetParameter(New RParameter("decreasing", 2))
        ucrPnlOrder.AddRadioButton(rdoAscending, "FALSE")
        ucrPnlOrder.AddRadioButton(rdoDescending, "TRUE")
        ucrPnlOrder.SetRDefault("FALSE")

        ''Currently Disabled
        'ucrPnlMissingValues.SetParameter(New RParameter("na.last", 3))
        'ucrPnlMissingValues.AddRadioButton(rdoFirst, "FALSE")
        'ucrPnlMissingValues.AddRadioButton(rdoLast, "TRUE")
        'ucrPnlMissingValues.SetRDefault("TRUE")
        ucrPnlMissingValues.bAllowNonConditionValues = True
    End Sub

    Private Sub SetDefaults()
        clsSortFunction = New RFunction

        'Reset
        ucrSelectForSort.Reset()

        'Setting default Rfunction as the base function
        clsSortFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")

        ' Set default RFunction as the base function
        ucrBase.clsRsyntax.SetBaseRFunction(clsSortFunction)
    End Sub

    Public Sub SetCurrentDataframe(strDataFrame As String)
        strSelectedDataFrame = strDataFrame
        ucrSelectForSort.SetDataframe(strSelectedDataFrame)
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectForSort.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverSort.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
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

    'Setting Defaults on Reset 
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverSort.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class