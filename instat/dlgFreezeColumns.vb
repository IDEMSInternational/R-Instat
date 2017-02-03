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

Public Class dlgFreezeColumns
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Private Sub dlgFreezeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub SetDefaults()
        ' Set default RFunction as the base function
        ucrBaseforFreezeColumns.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorByDataFrameAddRemoveforFreezeColumns.Reset()
        SetRCode(Me, ucrBaseforFreezeColumns.clsRsyntax.clsBaseFunction, True)
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseforFreezeColumns.iHelpTopicID = 444
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_freeze_columns")

        'Setting up the multiple receiver
        ucrReceiverMultipleforFreezeColumns.Selector = ucrSelectorByDataFrameAddRemoveforFreezeColumns
        ucrReceiverMultipleforFreezeColumns.SetMeAsReceiver()
        ucrReceiverMultipleforFreezeColumns.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleforFreezeColumns.SetParameterIsString()

        'Set data frame parameter
        ucrSelectorByDataFrameAddRemoveforFreezeColumns.SetParameter(New RParameter("data_name", 0))
        ucrSelectorByDataFrameAddRemoveforFreezeColumns.SetParameterIsString()


    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverMultipleforFreezeColumns.IsEmpty Then
            ucrBaseforFreezeColumns.OKEnabled(True)
        Else
            ucrBaseforFreezeColumns.OKEnabled(False)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleforFreezeColumns.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseforFreezeColumns_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseforFreezeColumns.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub
End Class