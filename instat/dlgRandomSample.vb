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

Public Class dlgRandomSample
    Public clsRSyntax As New RSyntax
    Private Sub dlgRandomSample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        'ucrBase.OKEnabled(False)
        ucrBase.iHelpTopicID = 31

        ' Setting distribution type and base function as distribution function
        ucrDistWithParameters.SetRDistributions()
        ucrBase.clsRsyntax.clsBaseFunction = ucrDistWithParameters.clsCurrRFunction
        ucrDistWithParameters.AddParameter("n", ucrSelectorRandomSamples.iDataFrameLength)
        ucrSampleSize.SetDataFrameSelector(ucrSelectorRandomSamples)

        ucrInputRandomSamples.SetPrefix("Rand")
        ucrInputRandomSamples.SetItemsTypeAsColumns()
        ucrInputRandomSamples.SetDefaultTypeAsColumn()
        ucrInputRandomSamples.SetDataFrameSelector(ucrSelectorRandomSamples)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputRandomSamples.GetText, strTempDataframe:=ucrSelectorRandomSamples.cboAvailableDataFrames.Text, strTempColumn:=ucrInputRandomSamples.GetText)

    End Sub

    Private Sub ucrDataFrameSelector_DataFrameChanged(sender As Object, e As EventArgs, strPrevDataFrame As String) Handles ucrSelectorRandomSamples.DataFrameChanged
        ucrDistWithParameters.AddParameter("n", ucrSelectorRandomSamples.iDataFrameLength)
    End Sub

End Class