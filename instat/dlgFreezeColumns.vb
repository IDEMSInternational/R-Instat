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

Public Class dlgFreezeColumns
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgFreezeColumns_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)

    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorByDataFrameAddRemoveforFreezeColumns.Reset()
        ' Set default RFunction as the base function
        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$set_freeze_columns")
        ucrBaseforFreezeColumns.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())

    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBaseforFreezeColumns.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseforFreezeColumns.iHelpTopicID = 444

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
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub
End Class