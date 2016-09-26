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
            SetDefaults()
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If

        autoTranslate(Me)

    End Sub
    Private Sub dlgMakeDate_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub InitialiseDialog()
        ucrReceiverYear.Selector = ucrSeclectorMakeDate
        ucrReceiverMonth.Selector = ucrSeclectorMakeDate
        ucrReceiverDay.Selector = ucrSeclectorMakeDate
        ucrReceiverYear.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverMonth.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverDay.SetIncludedDataTypes({"numeric", "factor"})
        ucrReceiverYear.SetMeAsReceiver()

        UcrInputNewColumnName.SetPrefix("Date")
        UcrInputNewColumnName.SetItemsTypeAsColumns()
        UcrInputNewColumnName.SetDefaultTypeAsColumn()
        UcrInputNewColumnName.SetDataFrameSelector(ucrSeclectorMakeDate.ucrAvailableDataFrames)
        UcrInputNewColumnName.SetValidationTypeAsRVariable()


    End Sub
    Private Sub SetDefaults()

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
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMonth_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverMonth.SelectionChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverDay_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDay.SelectionChanged
        TestOkEnabled()
    End Sub
End Class