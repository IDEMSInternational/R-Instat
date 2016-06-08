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

Public Class dlgRowNamesOrNumbers
    Public bFirstLoad As Boolean = True
    Dim sort As RFunction

    Private Sub dlgRowNamesOrNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        autoTranslate(Me)

    End Sub

    Private Sub InitialiseDialog()

        ucrReceiverSingleRownamesOrNumbers.Selector = ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers
        ucrReceiverSingleRownamesOrNumbers.SetMeAsReceiver()
        ucrNewColumnNameforRownamesOrNumbers.Visible = False

    End Sub

    Private Sub SetDefaults()

        ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Enabled = False
        ucrReceiverSingleRownamesOrNumbers.Enabled = False
        rdoCopytoFirstColumn.Enabled = True
        rdoResetintoPositiveIntegers.Enabled = True
        chkDecreasingforRownamesOrNumbers.Visible = False
        ucrNewColumnNameforRownamesOrNumbers.Visible = False
        chkDecreasingforRownamesOrNumbers.Checked = False
    End Sub

    Private Sub ucrBaseRownamesOrNumbers_clickReset(sender As Object, e As EventArgs) Handles ucrBaseRownamesorNumbers.ClickReset

        SetDefaults()

    End Sub

    Private Sub rdoCopytoFirstColumn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCopytoFirstColumn.CheckedChanged, rdoCopyfromColumn.CheckedChanged, rdoResetintoPositiveIntegers.CheckedChanged, rdoSortbyRowNamesorNumbers.CheckedChanged


        ucrBaseRownamesorNumbers.clsRsyntax.SetAssignTo("")
        ucrBaseRownamesorNumbers.clsRsyntax.ClearParameters()

        If rdoCopyfromColumn.Checked Then
            ucrNewColumnNameforRownamesOrNumbers.Visible = False
            ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Enabled = True
            ucrReceiverSingleRownamesOrNumbers.Enabled = True
            ucrBaseRownamesorNumbers.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrBaseRownamesorNumbers.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame & Chr(34))

            'set parameters

        ElseIf rdoCopytoFirstColumn.Checked Then

            ucrNewColumnNameforRownamesOrNumbers.Visible = False
            ucrBaseRownamesorNumbers.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            'ucrBaseRownamesorNumbers.clsRsyntax.SetAssignTo("rownamesfromtextbox_temp", ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame, "rownamesfromtextbox")
            ucrBaseRownamesorNumbers.clsRsyntax.AddParameter("row_names", clsRFunctionParameter:=ucrReceiverSingleRownamesOrNumbers.GetVariables())
            ucrBaseRownamesorNumbers.clsRsyntax.ClearParameters()
            'set prefix parameter

        ElseIf rdoCopytoColumnsforRownamesOrNumbers.Checked Then

            ucrNewColumnNameforRownamesOrNumbers.Visible = True
            ucrBaseRownamesorNumbers.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrBaseRownamesorNumbers.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame & Chr(34))
            ucrBaseRownamesorNumbers.clsRsyntax.SetAssignTo("rownamesfromtextbox_temp", ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame, "rownamesfromtextbox")
            ucrBaseRownamesorNumbers.clsRsyntax.SetAssignTo(strAssignToName:=ucrNewColumnNameforRownamesOrNumbers.strCurrNewColumnText, strTempDataframe:=ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame, strTempColumn:=ucrNewColumnNameforRownamesOrNumbers.strCurrNewColumnText)
            ucrBaseRownamesorNumbers.clsRsyntax.AddParameter("row_names", clsRFunctionParameter:=ucrReceiverSingleRownamesOrNumbers.GetVariables())

        ElseIf rdoResetintoPositiveIntegers.Checked Then
            ucrBaseRownamesorNumbers.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrBaseRownamesorNumbers.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame & Chr(34))
            'set parameters 

        ElseIf rdoSortbyRowNamesorNumbers.Checked Then

            ucrNewColumnNameforRownamesOrNumbers.Visible = False
            ucrBaseRownamesorNumbers.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrBaseRownamesorNumbers.clsRsyntax.AddParameter(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
            chkDecreasingforRownamesOrNumbers.Visible = True

        Else

            ucrReceiverSingleRownamesOrNumbers.Enabled = False
            ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.Enabled = False


        End If


    End Sub

    Private Sub chkDecreasingforRownamesOrNumbers_CheckedChanged(sender As Object, e As EventArgs) Handles chkDecreasingforRownamesOrNumbers.CheckedChanged

        If chkDecreasingforRownamesOrNumbers.Checked Then
            ucrBaseRownamesorNumbers.clsRsyntax.AddParameter("decreasing", "TRUE")
        Else
            ucrBaseRownamesorNumbers.clsRsyntax.AddParameter("decreasing", "FALSE")
        End If

    End Sub

    Private Sub ucrReceiverSingleRownamesOrNumbers_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSingleRownamesOrNumbers.SelectionChanged
        ucrBaseRownamesorNumbers.clsRsyntax.AddParameter("row_names", clsRFunctionParameter:=ucrReceiverSingleRownamesOrNumbers.GetVariables())

    End Sub
End Class