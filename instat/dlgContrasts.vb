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
Imports RDotNet
Public Class dlgContrasts
    Public bFirstLoad As Boolean = True
    Private Sub dlgContrasts_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForContrasts.IsEmpty AndAlso ucrInputContrast.IsEmpty = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()

    End Sub
    Private Sub InitialiseDialog()
        ucrReceiverForContrasts.Selector = ucrSelectorForContrast
        ucrReceiverForContrasts.SetMeAsReceiver()
        ucrReceiverForContrasts.SetIncludedDataTypes({"factor"})
        ucrBase.iHelpTopicID = 353
        ucrInputContrast.SetItems({"Helmert", "Polynomials", "Treatment/Control", "Sum to Zero"})
        ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_contrasts_of_factor")

    End Sub
    Private Sub SetDefaults()
        ucrInputContrast.SetName("Treatment/Control")
        ucrSelectorForContrast.Reset()
        ucrInputContrast.Reset()
        chkOverwriteExistContrast.Checked = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub

    Private Sub ucrReceiverForContrasts_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForContrasts.SelectionChanged
        If Not ucrReceiverForContrasts.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("factor", ucrReceiverForContrasts.GetVariableNames)
        Else
            ucrBase.clsRsyntax.RemoveParameter("factor")
        End If
        TestOKEnabled()
    End Sub


    Private Sub ucrSelectorForContrast_DataFrameChanged() Handles ucrSelectorForContrast.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForContrast.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    End Sub

    Private Sub ucrInputContrast_NameChanged() Handles ucrInputContrast.NameChanged
        If Not ucrInputContrast.IsEmpty Then
            SelectContrast()
        Else
            ucrBase.clsRsyntax.RemoveParameter("new_contrasts")
        End If
        TestOKEnabled()
    End Sub

    Private Sub SelectContrast()
        Select Case ucrInputContrast.GetText
            Case "Treatment/Control"
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.treatment" & Chr(34))
            Case "Helmert"
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.helmert" & Chr(34))
            Case "Polynomials"
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.poly" & Chr(34))
            Case "Sum to Zero"
                ucrBase.clsRsyntax.AddParameter("new_contrasts", Chr(34) & "contr.sum" & Chr(34))
            Case Else
        End Select
    End Sub
End Class