
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
Public Class dlgIndicatorVariable
    Private bFirstLoad As Boolean = True

    Private Sub dlgIndicatorVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()

        End If
        autoTranslate(Me)
    End Sub
    Private Sub TestOkEnabled()
        If Not ucrReceiverFactor.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(True)
        End If

    End Sub
    Private Sub SetDefaults()
        ucrSelectorDummyVariable.Focus()
        ucrSelectorDummyVariable.Reset()
        ucrReceiverFactor.Selector = ucrSelectorDummyVariable
        ucrReceiverFactor.SetMeAsReceiver()
        ucrVariateReceiver.Visible = False
        lblVariate.Visible = False
        ucrInputColName.SetPrefix("Dummy")

        TestOkEnabled()
    End Sub

    Public Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("")
        ucrBase.clsRsyntax.iCallType = 2
        ucrReceiverFactor.Selector = ucrSelectorDummyVariable
        ucrVariateReceiver.Selector = ucrSelectorDummyVariable
        ucrReceiverFactor.SetMeAsReceiver()

        ucrReceiverFactor.SetDataType("factor")

        chkXvariable.Checked = False
        ucrVariateReceiver.Visible = False
        lblVariate.Visible = False

        ucrInputColName.SetPrefix("Dummy")
        ucrInputColName.SetItemsTypeAsColumns()
        ucrInputColName.SetDefaultTypeAsColumn()
        ucrInputColName.SetDataFrameSelector(ucrSelectorDummyVariable.ucrAvailableDataFrames)
    End Sub

    Private Sub ReopenDialog()
        ucrInputColName.SetPrefix("Dummy")
    End Sub

    Private Sub chkXvariable_CheckedChanged(sender As Object, e As EventArgs) Handles chkXvariable.CheckedChanged
        If chkXvariable.Checked Then
            ucrVariateReceiver.Visible = True
            lblVariate.Visible = True
            ucrVariateReceiver.SetMeAsReceiver()
        Else
            ucrVariateReceiver.Visible = False
            lblVariate.Visible = False
            ucrReceiverFactor.SetMeAsReceiver()
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrInputColName_NameChanged() Handles ucrInputColName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColName.GetText, strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColName.GetText)
    End Sub
End Class