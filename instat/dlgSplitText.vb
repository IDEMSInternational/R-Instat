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
        If ucrReceiverSplitTextColumn.IsEmpty() = False And nudN.Text <> "" Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverSplitTextColumn.Selector = ucrSelectorSplitTextColumn
        ucrReceiverSplitTextColumn.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("stringr::str_split_fixed")
        ucrReceiverSplitTextColumn.SetIncludedDataTypes({"factor", "character"})
        ucrInputColumnsIntoText.SetItemsTypeAsColumns()
        ucrInputColumnsIntoText.SetDefaultTypeAsColumn()
        ucrInputColumnsIntoText.SetDataFrameSelector(ucrSelectorSplitTextColumn.ucrAvailableDataFrames)
        ucrInputPattern.cboInput.Items.Add("Whitespace")
        ucrInputPattern.cboInput.Items.Add("Period")
        ucrInputPattern.cboInput.Items.Add("Hyphen")
        ucrInputPattern.cboInput.Items.Add("Underscore")


    End Sub

    Private Sub SetDefaults()
        ucrSelectorSplitTextColumn.Reset()
        ucrSelectorSplitTextColumn.Focus()
        ucrInputColumnsIntoText.Reset()
        ucrInputColumnsIntoText.SetName("SplitText")


    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        TestOKEnabled()
        SetDefaults()
    End Sub

    Private Sub cboInputPattern_Namechanged() Handles ucrInputPattern.NameChanged
        Select Case ucrInputPattern.GetText
            Case "Whitespace"
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & " " & Chr(34))
            Case "Hyphen"
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & "-" & Chr(34))
            Case "Underscore"
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & "_" & Chr(34))
            Case "Period"
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & "." & Chr(34))

            Case Else
                ucrBase.clsRsyntax.AddParameter("pattern", Chr(34) & ucrInputPattern.GetText & Chr(34))

        End Select

    End Sub

    Private Sub ucrInputColumnIntText_NameChanged() Handles ucrInputColumnsIntoText.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColumnsIntoText.GetText, strTempDataframe:=ucrSelectorSplitTextColumn.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColumnsIntoText.GetText)
    End Sub

    Private Sub ucrReceiverSplitTextColumn_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverSplitTextColumn.SelectionChanged
        If Not ucrReceiverSplitTextColumn.IsEmpty Then

            ucrBase.clsRsyntax.AddParameter("string", clsRFunctionParameter:=ucrReceiverSplitTextColumn.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("string")
        End If
        TestOKEnabled()

    End Sub

    Private Sub nudN_TextChanged(sender As Object, e As EventArgs) Handles nudN.TextChanged
        ucrBase.clsRsyntax.AddParameter("n", nudN.Value)
        TestOKEnabled()
    End Sub

End Class