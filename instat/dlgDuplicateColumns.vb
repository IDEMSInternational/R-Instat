' Instat-R
' Copyright (C) 2015

' This program is free software: you can redistribute it and/or modify
' it under the terms of the GNU General Public License as published by
' the Free Software Foundation, either version 3 of the License, or
' (at your option) any later version.
'
' This program is distributed in the hope that it will be useful,
' but WITHOUT ANY WARRANTY; without even the implied warranty of
' MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
' GNU General Public License for more details.

' You should have received a copy of the GNU General Public License k
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat
Imports instat.Translations
Public Class dlgDuplicateColumns
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""
    Private Sub dlgCopySheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub


    'Month <- InstatDataObject$get_columns_from_data(use_current_filter=FALSE,
    ''''' 'col_name="Month", data_name="Damango")
    'InstatDataObject$add_columns_to_data(col_data=UCRRECEIVERFORCOPYCOLUMNS, col_name="RECEIVERNAME1",
    ''''' 'data_name="DATASET NAME", before=TRUE, adjacent_column )

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 512

        ' For ucrSelector
        ucrSelectorForDuplicateColumn.SetParameter(New RParameter("data_name"))
        ucrSelectorForDuplicateColumn.SetParameterIsString()

        ' For ucrReceiver
        ucrReceiverForCopyColumns.SetParameter(New RParameter("col_data"))
        ucrReceiverForCopyColumns.SetParameterIsString()
        ucrReceiverForCopyColumns.Selector = ucrSelectorForDuplicateColumn
        ucrReceiverForCopyColumns.SetMeAsReceiver()
        ucrReceiverForCopyColumns.bUseFilteredData = False

        ' radio buttons
        ucrPnlColPosition.SetParameter(New RParameter("before"))
        ucrPnlColPosition.AddRadioButton(rdoBefore, "TRUE")
        ucrPnlColPosition.AddRadioButton(rdoAfter, "FALSE")
        ucrPnlColPosition.AddRadioButton(rdoBeginning, "TRUE")
        ucrPnlColPosition.AddRadioButton(rdoEnd, "FALSE")

        ' linked columns with radio buttons, After and Before have an extra parameter
        SetParameter({ucrPnlColPosition, ucrReceiverForCopyColumns}, New RParameter("adjacent_column"))
        ucrPnlColPosition.AddToLinkedControls(ucrLinked:=ucrReceiverForCopyColumns, objValues:={True}, bNewLinkedAddRemoveParameter:=True)
        ucrReceiverForCopyColumns.bAddRemoveParameter = False
        ' haven't said adjacent column = COLUMN NAME
        ' haven't specified which radio buttons this applies for.

        ' For ucrSaveColumn
        ucrInputColumnName.SetParameter(New RParameter("col_name"))
        ucrInputColumnName.SetDataFrameSelector(ucrSelectorForDuplicateColumn.ucrAvailableDataFrames)
        ucrInputColumnName.SetPrefix(ucrReceiverForCopyColumns.GetVariableNames(False))
        ucrInputColumnName.SetItemsTypeAsColumns()
        ucrInputColumnName.SetDefaultTypeAsColumn()
        ucrInputColumnName.SetValidationTypeAsRVariable()

    End Sub

    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrSelectorForDuplicateColumn.Reset()

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsDefaultFunction.AddParameter(ucrInputColumnName.GetParameter)
        clsDefaultFunction.AddParameter("before", "FALSE")

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorForDuplicateColumn.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverForCopyColumns.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverForCopyColumns.IsEmpty AndAlso Not ucrInputColumnName.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrReceiverForCopyColumns_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverForCopyColumns.ControlContentsChanged, ucrInputColumnName.ControlContentsChanged
        TestOKEnabled()
    End Sub







    Private Sub ucrReceiverForCopyColumns_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverForCopyColumns.SelectionChanged
        If Not ucrReceiverForCopyColumns.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_data", clsRFunctionParameter:=ucrReceiverForCopyColumns.GetVariables)
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_data")
        End If
        If Not ucrInputColumnName.bUserTyped Then
            ucrInputColumnName.SetPrefix(ucrReceiverForCopyColumns.GetVariableNames(False))
        End If
        PositionOfDuplicatedCols()
        TestOKEnabled()
    End Sub

    '   Private Sub ucrSelectorForDuplicateColumn_DataFrameChanged() Handles ucrSelectorForDuplicateColumn.DataFrameChanged
    '      ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorForDuplicateColumn.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    ' End Sub

    Private Sub ucrInputColumnName_NameChanged() Handles ucrInputColumnName.NameChanged
        ColName()
        TestOKEnabled()
    End Sub

    Private Sub ColName()
        If Not ucrInputColumnName.IsEmpty Then
            ucrBase.clsRsyntax.AddParameter("col_name", Chr(34) & ucrInputColumnName.GetText & Chr(34))
        Else
            ucrBase.clsRsyntax.RemoveParameter("col_name")
        End If
    End Sub

    Private Sub grpDuplicatedColumn_CheckedChanged(sender As Object, e As EventArgs) Handles rdoAfter.CheckedChanged, rdoBefore.CheckedChanged, rdoBeginning.CheckedChanged, rdoEnd.CheckedChanged
        PositionOfDuplicatedCols()
    End Sub

    Private Sub PositionOfDuplicatedCols()
        If rdoAfter.Checked Then
            If Not ucrReceiverForCopyColumns.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("adjacent_column", ucrReceiverForCopyColumns.GetVariableNames)
            Else
                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            End If
            ucrBase.clsRsyntax.AddParameter("before", "FALSE")
        ElseIf rdoBeginning.Checked Then
            ucrBase.clsRsyntax.AddParameter("before", "TRUE")
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
        ElseIf rdoBefore.Checked Then
            ucrBase.clsRsyntax.AddParameter("before", "TRUE")
            If Not ucrReceiverForCopyColumns.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("adjacent_column", ucrReceiverForCopyColumns.GetVariableNames)
            Else
                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            ucrBase.clsRsyntax.AddParameter("before", "FALSE")
        End If
    End Sub
End Class
