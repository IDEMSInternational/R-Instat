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

Public Class dlgRecodeFactor
    Public bFirstLoad As Boolean = True
    Private clsReplaceFunction As RFunction

    Private Sub dlgRecodeFactor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub InitialiseDialog()
        clsReplaceFunction = New RFunction

        ucrBase.clsRsyntax.SetFunction("revalue")
        ucrReceiverFactor.Selector = ucrSelectorForRecode
        ucrReceiverFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverFactor.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 37

        clsReplaceFunction.strRCommand = "c"
        ucrBase.clsRsyntax.AddParameter("replace", clsRFunctionParameter:=clsReplaceFunction)

        ucrInputColumnName.SetItemsTypeAsColumns()
        ucrInputColumnName.SetDefaultTypeAsColumn()
        ucrInputColumnName.SetDataFrameSelector(ucrSelectorForRecode.ucrAvailableDataFrames)

        ucrFactorGrid.SetReceiver(ucrReceiverFactor)
        ucrFactorGrid.SetAsViewerOnly()
        ucrFactorGrid.bIncludeCopyOfLevels = True
        ucrFactorGrid.AddEditableColumns({"New Label"})
        ucrFactorGrid.SetIncludeLevels(False)

        ucrInputColumnName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        ucrSelectorForRecode.Reset()
        ucrSelectorForRecode.Focus()
        ucrFactorGrid.ResetText()
        ucrInputColumnName.SetPrefix("Recode")
        TestOKEnabled()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverFactor.IsEmpty AndAlso ucrFactorGrid.IsColumnComplete("New Label") Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrFactorGrid_GridContentChanged() Handles ucrFactorGrid.GridContentChanged
        Dim strCurrentLabels As List(Of String)
        Dim strNewLabels As List(Of String)
        Dim strReplace As String = ""

        strCurrentLabels = ucrFactorGrid.GetColumnAsList(ucrFactorGrid.strLabelsName, False)
        strNewLabels = ucrFactorGrid.GetColumnAsList("New Label", True)
        clsReplaceFunction.ClearParameters()
        If ucrFactorGrid.IsColumnComplete(ucrFactorGrid.strLabelsName) AndAlso strCurrentLabels.Count = strNewLabels.Count Then
            For i = 0 To strCurrentLabels.Count - 1
                ' Backtick needed for names of the vector incase the levels are not valid R names
                clsReplaceFunction.AddParameter(Chr(96) & strCurrentLabels(i) & Chr(96), strNewLabels(i))
            Next
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrReceiverFactor_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverFactor.SelectionChanged
        If ucrReceiverFactor.IsEmpty Then
            ucrBase.clsRsyntax.RemoveParameter("x")
        Else
            ucrBase.clsRsyntax.AddParameter("x", clsRFunctionParameter:=ucrReceiverFactor.GetVariables())
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrInputColumnName_NameChanged() Handles ucrInputColumnName.NameChanged
        If ucrInputColumnName.IsEmpty Then
            ucrBase.clsRsyntax.RemoveAssignTo()
        Else
            ucrBase.clsRsyntax.SetAssignTo(ucrInputColumnName.GetText(), strTempDataframe:=ucrSelectorForRecode.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrInputColumnName.GetText())
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
    End Sub
End Class