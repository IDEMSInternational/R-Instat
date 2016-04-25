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
Public Class dlgCombineText
    Private bFirstLoad As Boolean = True
    Private Sub dlgCombineText_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If ucrReceiverCombineText.IsEmpty() = False And (Not ucrInputSeparator.IsEmpty) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverCombineText.Selector = ucrSelectorForCombineText
        ucrReceiverCombineText.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("stringr::str_c")
        ucrInputColumnInto.SetName("CombineText")
        ucrReceiverCombineText.SetDataType("factor")
        ucrInputColumnInto.SetItemsTypeAsColumns()
        ucrInputColumnInto.SetDefaultTypeAsColumn()
        ucrInputColumnInto.SetDataFrameSelector(ucrSelectorForCombineText.ucrAvailableDataFrames)
        ucrBase.clsRsyntax.AddParameter("collapse", "NULL")
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForCombineText.Reset()
        ucrSelectorForCombineText.Focus()
        ucrInputSeparator.SetName("Whitespace")
        ucrInputColumnInto.cboInput.ResetText()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()

    End Sub

    Private Sub ucrInputSeparator_NameChanged() Handles ucrInputSeparator.NameChanged
        SeparatorParameter()
        TestOKEnabled()
    End Sub

    Private Sub SeparatorParameter()
        Select Case ucrInputSeparator.cboInput.SelectedItem
            Case "NULL"
                ucrBase.clsRsyntax.AddParameter("sep", "NULL")
            Case "WhiteSpace"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "" & Chr(34))
            Case "Hyphen"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "-" & Chr(34))
            Case "Underscore"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "_" & Chr(34))
            Case "Period"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "." & Chr(34))
        End Select
    End Sub

    Private Sub ucrInputColumnInto_NameChanged() Handles ucrInputColumnInto.NameChanged
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColumnInto.GetText, strTempDataframe:=ucrSelectorForCombineText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColumnInto.GetText)
    End Sub

    Private Sub ucrReceiverCombineText_SelectionChanged() Handles ucrReceiverCombineText.SelectionChanged
        If Not ucrReceiverCombineText.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverCombineText.GetVariables())
        Else
            ucrBase.clsRsyntax.RemoveParameter("x")
        End If
        TestOKEnabled()
    End Sub

End Class