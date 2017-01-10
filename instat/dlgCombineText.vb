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
    Private iColumnsUsed As Integer

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
        ColumnOrder()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverCombineText.IsEmpty() AndAlso Not ucrInputColumnInto.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If

    End Sub

    Private Sub InitialiseDialog()
        ucrReceiverCombineText.Selector = ucrSelectorForCombineText
        ucrReceiverCombineText.SetMeAsReceiver()
        ucrBase.clsRsyntax.SetFunction("stringr::str_c")
        ucrReceiverCombineText.SetIncludedDataTypes({"factor", "character"})
        ucrReceiverCombineText.bUseFilteredData = False
        ucrInputColumnInto.SetItemsTypeAsColumns()
        ucrInputColumnInto.SetDefaultTypeAsColumn()
        ucrInputColumnInto.SetDataFrameSelector(ucrSelectorForCombineText.ucrAvailableDataFrames)
        iColumnsUsed = 0
        ucrInputSeparator.SetItems({"Space", "-", "_", "."})
        ucrBase.iHelpTopicID = 345
        ucrInputColumnInto.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForCombineText.Reset()
        ucrSelectorForCombineText.Focus()
        ucrInputColumnInto.SetPrefix("Combine")
        ucrInputSeparator.SetName("")
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrInputSeparator_NameChanged() Handles ucrInputSeparator.NameChanged
        SeparatorParameter()
    End Sub

    Private Sub SeparatorParameter()
        Select Case ucrInputSeparator.GetText()
            Case "Space"
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & " " & Chr(34))
            Case ""
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & "" & Chr(34))
                Else
                    ucrBase.clsRsyntax.RemoveParameter("sep")
                End If
            Case Else
                ucrBase.clsRsyntax.AddParameter("sep", Chr(34) & ucrInputSeparator.GetText() & Chr(34))
        End Select
    End Sub

    Private Sub ucrInputColumnInto_NameChanged() Handles ucrInputColumnInto.NameChanged
        If Not ucrInputColumnInto.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(strAssignToName:=ucrInputColumnInto.GetText, strTempDataframe:=ucrSelectorForCombineText.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColumnInto.GetText)
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverCombineText_SelectionChanged() Handles ucrReceiverCombineText.SelectionChanged
        ColumnOrder()
        TestOKEnabled()
    End Sub

    Private Sub ColumnOrder()
        Dim lstColumnFunction As List(Of RFunction)

        For i = 1 To iColumnsUsed
            ucrBase.clsRsyntax.RemoveParameter("X" & i)
        Next

        If Not ucrReceiverCombineText.IsEmpty Then
            lstColumnFunction = ucrReceiverCombineText.GetVariablesAsList()
            iColumnsUsed = lstColumnFunction.Count
            For i = 0 To lstColumnFunction.Count - 1
                ucrBase.clsRsyntax.AddParameter("X" & i + 1, clsRFunctionParameter:=lstColumnFunction(i))
            Next
        End If
    End Sub
End Class