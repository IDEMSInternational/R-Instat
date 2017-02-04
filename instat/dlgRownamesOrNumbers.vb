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

Public Class dlgRowNamesOrNumbers
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Dim sort As RFunction

    Private Sub dlgRowNamesOrNumbers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        autoTranslate(Me)
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If

        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        ReopenDialog()

        TestOKEnabled()
    End Sub

    Private Sub TestOKEnabled()
        If (ucrSelectorRowNames.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "") OrElse (rdoCopyfromColumn.Checked AndAlso ucrReceiverRowNames.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 178

        ucrPnlOverallOptions.AddRadioButton(rdoCopytoFirstColumn)
        ucrPnlOverallOptions.AddRadioButton(rdoCopyfromColumn)
        ucrPnlOverallOptions.AddRadioButton(rdoResetintoPositiveIntegers)
        ucrPnlOverallOptions.AddRadioButton(rdoSortbyRowNames)

        ucrPnlOverallOptions.AddFunctionNamesCondition(rdoCopytoFirstColumn, frmMain.clsRLink.strInstatDataObject & "$get_row_names")
        ucrPnlOverallOptions.AddFunctionNamesCondition(rdoCopyfromColumn, frmMain.clsRLink.strInstatDataObject & "$set_row_names")
        ucrPnlOverallOptions.AddFunctionNamesCondition(rdoResetintoPositiveIntegers, frmMain.clsRLink.strInstatDataObject & "$set_row_names")
        ucrPnlOverallOptions.AddFunctionNamesCondition(rdoSortbyRowNames, frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")

        ucrPnlOverallOptions.AddToLinkedControls(ucrNewColumnName, {rdoCopytoFirstColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrReceiverRowNames, {rdoCopyfromColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrPnlSortOptions, {rdoSortbyRowNames}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrChkAsNumeric, {rdoSortbyRowNames}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ' i need to code these ucrs still

        ' selector
        ucrSelectorRowNames.SetParameter(New RParameter("data_name", 0))
        ucrSelectorRowNames.SetParameterIsString()
        '        ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers.strCurrentDataFrame & Chr(34))

        'ucrNewColumnName
        ucrNewColumnName.SetIsTextBox()
        ucrNewColumnName.SetPrefix("Row_names")
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorRowNames.ucrAvailableDataFrames)
        ucrNewColumnName.SetLabelText("Column Name:")

        'ucrReceiverSingle
        ucrReceiverRowNames.SetParameter(New RParameter("row_names", 1))
        ucrReceiverRowNames.SetParameterIsRFunction()
        ucrReceiverRowNames.Selector = ucrSelectorRowNames
        ucrReceiverRowNames.SetMeAsReceiver()

        'ucrPnlSortOptions
        ucrPnlSortOptions.SetParameter(New RParameter("decreasing", 3))
        ucrPnlSortOptions.AddRadioButton(rdoSortAscending, "FALSE")
        ucrPnlSortOptions.AddRadioButton(rdoSortDescending, "TRUE")
        ucrPnlSortOptions.SetRDefault(Chr(34) & "TRUE" & Chr(34)) ' check

        'ucrChkAsNumeric
        ucrChkAsNumeric.SetParameter(New RParameter("row_names_as_numeric"))
        ucrChkAsNumeric.SetText("Treat Row Names as Numeric")
        ucrChkAsNumeric.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAsNumeric.SetRDefault("TRUE")

        'If chkAsNumeric.Checked Then
        '  If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
        '      ucrBase.clsRsyntax.AddParameter("row_names_as_numeric", "TRUE")
        '   Else
        '      ucrBase.clsRsyntax.RemoveParameter("row_names_as_numeric")
        '   End If
        'Else
        '  ucrBase.clsRsyntax.AddParameter("row_names_as_numeric", "FALSE")
        'End If
    End Sub


    Private Sub SetDefaults()
        Dim clsDefaultFunction As New RFunction
        ucrNewColumnName.Reset()
        ucrSelectorRowNames.Reset()

        rdoSortAscending.Checked = True

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$remove_columns_in_data")
        clsDefaultFunction.SetAssignTo(strTemp:=ucrNewColumnName.GetText(), strTempDataframe:=ucrSelectorRowNames.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText())
        ' where do I do set assign to? I want it for just the first RDO button

        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())

        OptionSettings()
    End Sub

    Private Sub ReopenDialog()
        ' ToBeAssigned/IsAssigned values get reset after running script 
        ' so need to be redone here
        SetAssignment()
    End Sub

    '   Private Sub rdoOptionSettings_CheckedChanged(sender As Object, e As EventArgs) Handles rdoCopytoFirstColumn.CheckedChanged, rdoCopyfromColumn.CheckedChanged, rdoResetintoPositiveIntegers.CheckedChanged, rdoSortbyRowNames.CheckedChanged
    '       OptionSettings()
    '       TestOKEnabled()
    '   End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore)
        If rdoCopyfromColumn.Checked Then
            'ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "  ")
            ucrSelectorRowNames.SetVariablesEnabled(True)
        Else
            ucrSelectorRowNames.SetVariablesVisible(False)
        End If
    End Sub
    ' SetVariablesEnabled(True)/(False) - depending which rod.

    Private Sub OptionSettings()
        If rdoCopytoFirstColumn.Checked Then
            'ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_row_names")
            ucrBase.clsRsyntax.ClearParameters()
            'ucrSelectorRowNames.SetVariablesEnabled(False)
            'ucrReceiverRowNames.Visible = False
            'lblColumnName.Visible = True
            'ucrNewColumnName.Visible = True
        ElseIf rdoCopyfromColumn.Checked Then
            'ucrSelectorRowNames.SetVariablesEnabled(True)
            'ucrReceiverRowNames.Visible = True
            'ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrBase.clsRsyntax.ClearParameters()
            'lblColumnName.Visible = False
            'ucrNewColumnName.Visible = False
        ElseIf rdoResetintoPositiveIntegers.Checked Then
            'ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrBase.clsRsyntax.ClearParameters()
            'ucrReceiverRowNames.Visible = False
            'ucrSelectorRowNames.SetVariablesEnabled(False)
            'lblColumnName.Visible = False
            'ucrNewColumnName.Visible = False
        ElseIf rdoSortbyRowNames.Checked Then
            'ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
            ucrBase.clsRsyntax.ClearParameters()
            'ucrBase.clsRsyntax.AddParameter("by_row_names", "TRUE")
            'ucrReceiverRowNames.Visible = False
            'ucrSelectorRowNames.SetVariablesEnabled(False)
            'lblColumnName.Visible = False
            'ucrNewColumnName.Visible = False
        End If
        SetSortOrderParameter()
        'SetAsNumericParameter()
        SetAssignment()
        'SetRowNamesParameter()
        'ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorRowNames.strCurrentDataFrame & Chr(34))
    End Sub

    'Private Sub ucrSelectorByDataFrameAddRemoveforRownamesOrNumbers_DataFrameChanged() Handles ucrSelectorRowNames.DataFrameChanged
    'ucrBase.clsRsyntax.AddParameter("data_name", Chr(34) & ucrSelectorRowNames.strCurrentDataFrame & Chr(34))
    'SetAssignment()
    'TestOKEnabled()
    'End Sub

    Private Sub rdoSortAscendingDescending_CheckedChanged(sender As Object, e As EventArgs)
        SetSortOrderParameter()
    End Sub

    Private Sub SetSortOrderParameter()
        If rdoSortbyRowNames.Checked Then
            If rdoSortAscending.Checked Then
                If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
                    ucrBase.clsRsyntax.AddParameter("decreasing", "FALSE")
                Else
                    ucrBase.clsRsyntax.RemoveParameter("decreasing")
                End If
            ElseIf rdoSortDescending.Checked Then
                ucrBase.clsRsyntax.AddParameter("decreasing", "TRUE")
            End If
        Else
            ucrBase.clsRsyntax.RemoveParameter("decreasing")
        End If
    End Sub

    '   Private Sub SetAsNumericParameter()
    '  If rdoSortbyRowNames.Checked Then
    ' If chkAsNumeric.Checked Then
    'If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '               ucrBase.clsRsyntax.AddParameter("row_names_as_numeric", "TRUE")
    'Else
    '               ucrBase.clsRsyntax.RemoveParameter("row_names_as_numeric")
    'End If
    'Else
    '           ucrBase.clsRsyntax.AddParameter("row_names_as_numeric", "FALSE")
    'End If
    'Else
    '       ucrBase.clsRsyntax.RemoveParameter("row_names_as_numeric")
    'End If
    'End Sub

    Private Sub SetAssignment()
        If rdoCopytoFirstColumn.Checked AndAlso ucrNewColumnName.IsComplete() Then
            ucrBase.clsRsyntax.SetAssignTo(ucrNewColumnName.GetText(), strTempDataframe:=ucrSelectorRowNames.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText(), bInsertColumnBefore:=True)
        Else
            ucrBase.clsRsyntax.RemoveAssignTo()
        End If
    End Sub

    '  Private Sub ucrReceiverSingleRownamesOrNumbers_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverRowNames.SelectionChanged
    '     SetRowNamesParameter()
    '    TestOKEnabled()
    'End Sub

    'Private Sub SetRowNamesParameter()
    'If rdoCopyfromColumn.Checked Then
    'If ucrReceiverRowNames.IsEmpty Then
    '           ucrBase.clsRsyntax.RemoveParameter("row_names")
    'Else
    '           ucrBase.clsRsyntax.AddParameter("row_names", clsRFunctionParameter:=ucrReceiverRowNames.GetVariables())
    'End If
    'Else
    '       ucrBase.clsRsyntax.RemoveParameter("row_names")
    'End If
    'End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRowNames.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class