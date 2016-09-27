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
Public Class dlgMakeDate
    Public bFirstLoad As Boolean = True
    Private Sub ucrSeclectorMakeDate_Load(sender As Object, e As EventArgs) Handles ucrSeclectorMakeDate.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        autoTranslate(Me)

    End Sub
    Private Sub dlgMakeDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.SetFunction("make_datetime")
        ucrReceiverYear.Selector = ucrSeclectorMakeDate
        ucrReceiverMonth.Selector = ucrSeclectorMakeDate
        ucrReceiverDay.Selector = ucrSeclectorMakeDate
        ucrReceiverYear.SetIncludedDataTypes({"numeric"})
        ucrReceiverYear.SetMeAsReceiver()
        UcrInputNewColumnName.SetPrefix("Date")
        UcrInputNewColumnName.SetItemsTypeAsColumns()
        UcrInputNewColumnName.SetDefaultTypeAsColumn()
        UcrInputNewColumnName.SetDataFrameSelector(ucrSeclectorMakeDate.ucrAvailableDataFrames)
        UcrInputNewColumnName.SetValidationTypeAsRVariable()
    End Sub
    Private Sub SetDefaults()
        UcrInputNewColumnName.Reset()
        ucrSeclectorMakeDate.Reset()
        TestOkEnabled()

    End Sub
    Private Sub TestOkEnabled()
        If Not ucrReceiverYear.IsEmpty AndAlso Not ucrReceiverDay.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub ReopenDialog()
    End Sub

    Private Sub ucrReceiverYear_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverYear.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("year", clsRFunctionParameter:=ucrReceiverYear.GetVariables)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMonth_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverMonth.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("month", clsRFunctionParameter:=ucrReceiverMonth.GetVariables)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverDay_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDay.SelectionChanged
        ucrBase.clsRsyntax.AddParameter("day", clsRFunctionParameter:=ucrReceiverDay.GetVariables)

        TestOkEnabled()
    End Sub
    Private Sub UcrInputNewColumnName_NameChanged() Handles UcrInputNewColumnName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=UcrInputNewColumnName.GetText, strTempDataframe:=ucrSeclectorMakeDate.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=UcrInputNewColumnName.GetText, bAssignToIsPrefix:=True)
    End Sub


    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class