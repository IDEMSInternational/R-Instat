' R- Instat
' Copyright (C) 2015-2017
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
' You should have received a copy of the GNU General Public License 
' along with this program.  If not, see <http://www.gnu.org/licenses/>.

Imports instat.Translations

Public Class dlgUnstack
    Public bFirstLoad As Boolean = True
    Private clsFormula As New ROperator
    Private clsIDColumns As New ROperator

    Private Sub dlgunstack_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)

        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        'Checks if Ok can be enabled.
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrFactorToUnstackReceiver.Selector = ucrSelectorForunstack
        ucrColumnToUnstackReceiver.Selector = ucrSelectorForunstack
        ucrBase.clsRsyntax.SetPackageName("reshape2")
        ucrBase.clsRsyntax.SetFunction("dcast")
        ucrFactorToUnstackReceiver.SetMeAsReceiver()
        ucrBase.iHelpTopicID = 58
        ucrFactorToUnstackReceiver.SetDataType("factor")
        ucrFactorToUnstackReceiver.strSelectorHeading = "Factors"
        ucrIDColumns.Selector = ucrSelectorForunstack
        clsFormula.SetOperation("~")
        clsFormula.bBrackets = False
        clsIDColumns.SetOperation("+")
        clsIDColumns.bForceIncludeOperation = False
        clsFormula.AddParameter(iPosition:=0, clsROperatorParameter:=clsIDColumns)
        ucrBase.clsRsyntax.AddParameter("formula", clsROperatorParameter:=clsFormula)
        ucrNewDataName.SetValidationTypeAsRVariable()
    End Sub

    Private Sub SetDefaults()
        chkDropMissingCombinations.Checked = True
        SetDropParameter()
        ucrNewDataName.Reset()
        ucrSelectorForunstack.Reset()
        SetDefaultDataName()
    End Sub

    Private Sub ReopenDialog()
    End Sub

    Private Sub TestOKEnabled()
        If Not ucrFactorToUnstackReceiver.IsEmpty() AndAlso Not ucrColumnToUnstackReceiver.IsEmpty() AndAlso Not ucrIDColumns.IsEmpty() AndAlso Not ucrNewDataName.IsEmpty() Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrSelectorForunstack_DataFrameChanged() Handles ucrSelectorForunstack.DataFrameChanged
        ucrBase.clsRsyntax.AddParameter("data", clsRFunctionParameter:=ucrSelectorForunstack.ucrAvailableDataFrames.clsCurrDataFrame)
        SetDefaultDataName()
    End Sub

    Private Sub SetDefaultDataName()
        If Not ucrNewDataName.UserTyped() AndAlso ucrSelectorForunstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" Then
            ucrNewDataName.SetName(ucrSelectorForunstack.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_unstacked")
        End If
    End Sub

    Private Sub ucrFactorToUnstackReceiver_SelectionChanged() Handles ucrFactorToUnstackReceiver.SelectionChanged
        If Not ucrFactorToUnstackReceiver.IsEmpty Then
            clsFormula.AddParameter(strParameterValue:=ucrFactorToUnstackReceiver.GetVariableNames(False))
        Else
            clsFormula.RemoveAllAdditionalParameters()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrColumnToUnstackReceiver_SelectionChanged() Handles ucrColumnToUnstackReceiver.SelectionChanged
        If Not ucrColumnToUnstackReceiver.IsEmpty() Then
            ucrBase.clsRsyntax.AddParameter("value.var", ucrColumnToUnstackReceiver.GetVariableNames())
        Else
            ucrBase.clsRsyntax.RemoveParameter("value.var")
        End If

        TestOKEnabled()
    End Sub

    Private Sub chkKeepUnusedFactorLevels_CheckedChanged(sender As Object, e As EventArgs) Handles chkDropMissingCombinations.CheckedChanged
        SetDropParameter()
        TestOKEnabled()
    End Sub

    Private Sub SetDropParameter()
        If chkDropMissingCombinations.Checked Then
            If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                ucrBase.clsRsyntax.AddParameter("drop", "TRUE")
            Else
                ucrBase.clsRsyntax.RemoveParameter("drop")
            End If
        Else
            ucrBase.clsRsyntax.AddParameter("drop", "FALSE")
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        TestOKEnabled()
    End Sub

    Private Sub ucrNewDataName_NameChanged() Handles ucrNewDataName.NameChanged
        If Not ucrNewDataName.IsEmpty Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewDataName.GetText(), strTempDataframe:=ucrNewDataName.GetText())
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
        TestOKEnabled()
    End Sub

    Private Sub ucrIDColumns_SelectionChanged() Handles ucrIDColumns.SelectionChanged
        Dim lstColumns As List(Of String)

        clsIDColumns.ClearParameters()
        lstColumns = ucrIDColumns.GetVariableNamesAsList()
        For i = 0 To lstColumns.Count - 1
            If i = 0 Then
                clsIDColumns.AddParameter(iPosition:=0, strParameterValue:=lstColumns(i))
            ElseIf i = 1 Then
                clsIDColumns.AddParameter(strParameterValue:=lstColumns(i))
            Else
                clsIDColumns.AddParameter("X" & i, lstColumns(i))
            End If
        Next
        TestOKEnabled()
    End Sub

End Class

