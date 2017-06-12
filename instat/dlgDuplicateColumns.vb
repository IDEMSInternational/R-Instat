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

Imports instat.Translations
Public Class dlgDuplicateColumns
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDefaultFunction As New RFunction
    Dim bUseSelectedColumn As Boolean = False
    Dim strSelectedColumn As String = ""
    Dim strSelectedDataFrame As String = ""

    Private Sub dlgCopySheet_Load(sender As Object, e As EventArgs) Handles Me.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeforControls(bReset)
        bReset = False
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 512

        ' For ucrSelector
        ucrSelectorForDuplicateColumn.SetParameter(New RParameter("data_name", 0))
        ucrSelectorForDuplicateColumn.SetParameterIsString()

        ' For ucrReceiver
        ucrReceiverDuplicateColumns.SetParameter(New RParameter("col_data", 1))
        ucrReceiverDuplicateColumns.SetParameterIsRFunction()
        ucrReceiverDuplicateColumns.Selector = ucrSelectorForDuplicateColumn
        ucrReceiverDuplicateColumns.SetMeAsReceiver()
        ucrReceiverDuplicateColumns.bUseFilteredData = False

        ' radio buttons
        ucrPnlColPosition.SetParameter(New RParameter("before", 3))
        ucrPnlColPosition.AddRadioButton(rdoBefore, "TRUE")
        ucrPnlColPosition.AddRadioButton(rdoAfter, "FALSE")
        ucrPnlColPosition.AddRadioButton(rdoBeginning, "TRUE")
        ucrPnlColPosition.AddRadioButton(rdoEnd, "FALSE")
        ucrPnlColPosition.AddParameterPresentCondition(rdoBefore, "adjacent_column", True)
        ucrPnlColPosition.AddParameterPresentCondition(rdoAfter, "adjacent_column", True)
        ucrPnlColPosition.AddParameterPresentCondition(rdoBeginning, "adjacent_column", False)
        ucrPnlColPosition.AddParameterPresentCondition(rdoEnd, "adjacent_column", False)

        ' For ucrSaveColumn
        ucrInputColumnName.SetParameter(New RParameter("col_name", 2))
        ucrInputColumnName.SetDataFrameSelector(ucrSelectorForDuplicateColumn.ucrAvailableDataFrames)
        ucrInputColumnName.SetItemsTypeAsColumns()
        ucrInputColumnName.SetDefaultTypeAsColumn()
        ucrInputColumnName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction

        ucrSelectorForDuplicateColumn.Reset()
        ucrInputColumnName.bAllowNonConditionValues = True
        ucrInputColumnName.Reset()
        ucrInputColumnName.SetName("")

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_columns_to_data")
        clsDefaultFunction.AddParameter("before", "FALSE")
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
    End Sub

    Private Sub SetRCodeforControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrReceiverDuplicateColumns.IsEmpty AndAlso Not ucrInputColumnName.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ReopenDialog()
        ucrInputColumnName.bAllowNonConditionValues = True ' temporary fix
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeforControls(True)
        TestOKEnabled()
    End Sub

    Public Sub SetCurrentColumn(strColumn As String, strDataFrame As String)
        strSelectedColumn = strColumn
        strSelectedDataFrame = strDataFrame
        bUseSelectedColumn = True
    End Sub

    Private Sub SetDefaultColumn()
        ucrSelectorForDuplicateColumn.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem = strSelectedDataFrame
        ucrReceiverDuplicateColumns.Add(strSelectedColumn, strSelectedDataFrame)
        bUseSelectedColumn = False
    End Sub

    Private Sub PositionOfDuplicatedColumn()
        If rdoAfter.Checked Then
            If Not ucrReceiverDuplicateColumns.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("adjacent_column", ucrReceiverDuplicateColumns.GetVariableNames)
            Else
                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            End If
            ucrBase.clsRsyntax.AddParameter("before", "FALSE")
        ElseIf rdoBeginning.Checked Then
            ucrBase.clsRsyntax.AddParameter("before", "TRUE")
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
        ElseIf rdoBefore.Checked Then
            ucrBase.clsRsyntax.AddParameter("before", "TRUE")
            If Not ucrReceiverDuplicateColumns.IsEmpty Then
                ucrBase.clsRsyntax.AddParameter("adjacent_column", ucrReceiverDuplicateColumns.GetVariableNames)
            Else
                ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            End If
        ElseIf rdoEnd.Checked Then
            ucrBase.clsRsyntax.RemoveParameter("adjacent_column")
            ucrBase.clsRsyntax.AddParameter("before", "FALSE")
        End If
    End Sub

    Private Sub DefaultNewName()
        If Not ucrInputColumnName.bUserTyped AndAlso Not ucrReceiverDuplicateColumns.IsEmpty Then
            ucrInputColumnName.SetPrefix(ucrReceiverDuplicateColumns.GetVariableNames(False))
        End If
    End Sub

    Private Sub ucrPnlColPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlColPosition.ControlValueChanged
        ucrReceiverDuplicateColumns.UpdateControl()
        PositionOfDuplicatedColumn()
    End Sub

    Private Sub ucrReceiverForCopyColumns_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDuplicateColumns.ControlValueChanged
        DefaultNewName()
        PositionOfDuplicatedColumn()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverDuplicateColumns.ControlContentsChanged, ucrInputColumnName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class
