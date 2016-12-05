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
Public Class DlgDefineClimaticData
    Public bFirstLoad As Boolean = True
    Private Sub DlgDefineClimaticData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverDate.Selector = ucrSelectorDefineClimaticData
        ucrReceiverCloudCover.Selector = ucrSelectorDefineClimaticData
        ucrReceiverStation.Selector = ucrSelectorDefineClimaticData
        ucrReceiverMaxTemp.Selector = ucrSelectorDefineClimaticData
        ucrReceiverMinTemp.Selector = ucrSelectorDefineClimaticData
        ucrReceiverRadiation.Selector = ucrSelectorDefineClimaticData
        ucrReceiverRain.Selector = ucrSelectorDefineClimaticData
        ucrReceiverSunshine.Selector = ucrSelectorDefineClimaticData
        ucrReceiverWindDirection.Selector = ucrSelectorDefineClimaticData
        ucrReceiverWindSpeed.Selector = ucrSelectorDefineClimaticData
        ucrReceiverYear.Selector = ucrSelectorDefineClimaticData
        ucrReceiverMonth.Selector = ucrSelectorDefineClimaticData
        ucrReceiverDay.Selector = ucrSelectorDefineClimaticData

    End Sub

    Private Sub SetDefaults()
        ucrReceiverDate.SetMeAsReceiver()
        ucrSelectorDefineClimaticData.Reset()
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDate.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverDate_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverDate.SelectionChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrSelectorDefineClimaticData_DataFrameChanged() Handles ucrSelectorDefineClimaticData.DataFrameChanged

    End Sub


End Class