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
Public Class dlgSplitText
    Public bFirstLoad As Boolean = True
    Private Sub dlgSplitText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        End If
    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverSplitTextColumn.IsEmpty() = False Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("stringr::str_split_fixed")
        ucrReceiverSplitTextColumn.SetDataType("factor")
        ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & Chr(34))
        ucrInputColumnsIntoText.SetPrefix("SplitText")
        ucrInputColumnsIntoText.SetItemsTypeAsColumns()
        ucrInputColumnsIntoText.SetDefaultTypeAsColumn()
        ucrInputColumnsIntoText.SetDataFrameSelector(ucrSelectorSplitTextColumn.ucrAvailableDataFrames)




    End Sub
    Private Sub SetDefaults()
        ucrSelectorSplitTextColumn.Reset()
        ucrSelectorSplitTextColumn.Focus()
        ucrInputColumnsIntoText.ResetText()
        cboPattern.Text = "Whitespace"
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        TestOKEnabled()
        SetDefaults()

    End Sub

    Private Sub cboPattern_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboPattern.SelectedIndexChanged
        Select Case cboPattern.SelectedItem
            Case "NULL"
                ucrBase.clsRsyntax.AddParameter("pattern", "NULL")
            Case "WhiteSpace"
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & "" & Chr(34))
            Case "Hyphen"
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & "-" & Chr(34))
            Case "Underscore"
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & "_" & Chr(34))
            Case "Period"
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & "." & Chr(34))
        End Select
    End Sub

    Private Sub ucrInputColumnIntText_NameChanged() Handles ucrInputColumnsIntoText.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColumnsIntoText.GetText, strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColumnsIntoText.GetText)
    End Sub

    Private Sub ucrReceiverSplitTextColumn_SelectionChanged() Handles ucrReceiverSplitTextColumn.SelectionChanged
        If Not ucrReceiverSplitTextColumn.IsEmpty Then

            ucrBase.clsRsyntax.AddParameter("string", clsRFunctionParameter:=ucrReceiverSplitTextColumn.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("string")
        End If
        TestOKEnabled()

    End Sub

    Private Sub nudN_ValueChanged(sender As Object, e As EventArgs) Handles nudN.ValueChanged
        ucrBase.clsRsyntax.AddParameter("n", nudN.Value)
    End Sub
End Class