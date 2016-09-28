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
Public Class dlgCountinFactor
    Private bFirstLoad As Boolean
    Private Sub dlgCountinFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
    End Sub
    Private Sub InitialiseDialog()
        ucrCountReceiver.Selector = ucrCountSelector
        ucrCountReceiver.SetIncludedDataTypes({"factor"})
        ucrCountReceiver.SetMeAsReceiver()

        ucrInputColumnName.SetPrefix("Count")
        ucrInputColumnName.SetItemsTypeAsColumns()
        ucrInputColumnName.SetDefaultTypeAsColumn()
        ucrInputColumnName.SetDataFrameSelector(ucrCountSelector.ucrAvailableDataFrames)
        ucrInputColumnName.SetValidationTypeAsRVariable()

    End Sub
    Private Sub SetDefaults()
        ucrCountSelector.Reset()
        ucrInputColumnName.Reset()
        TestOkEnabled()
    End Sub
    Private Sub ReopenDialog()

    End Sub
    Private Sub TestOkEnabled()
        If Not ucrCountReceiver.IsEmpty AndAlso Not ucrInputColumnName.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrInputColumnName_NameChanged() Handles ucrInputColumnName.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColumnName.GetText, strTempDataframe:=ucrCountSelector.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColumnName.GetText, bAssignToIsPrefix:=True)
        TestOkEnabled()
    End Sub
End Class