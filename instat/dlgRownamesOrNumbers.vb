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

Public Class dlgRowNamesOrNumbers
    Public bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsRowNamesFunction As New RFunction

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
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 178

        ' selector
        ucrSelectorRowNames.SetParameter(New RParameter("data_name", 0))
        ucrSelectorRowNames.SetParameterIsString()

        'ucrReceiverSingle
        ucrReceiverRowNames.SetParameter(New RParameter("row_names", 1))
        ucrReceiverRowNames.SetParameterIsRFunction()
        ucrReceiverRowNames.Selector = ucrSelectorRowNames
        ucrReceiverRowNames.SetMeAsReceiver()

        ' main rdo options
        ucrPnlOverallOptions.AddRadioButton(rdoCopyRowNamesIntoFirstColumn)
        ucrPnlOverallOptions.AddRadioButton(rdoSetRowNamesFromColumn)
        ucrPnlOverallOptions.AddRadioButton(rdoResetintoPositiveIntegers)
        ucrPnlOverallOptions.AddRadioButton(rdoSortbyRowNames)

        ucrPnlOverallOptions.AddFunctionNamesCondition(rdoCopyRowNamesIntoFirstColumn, frmMain.clsRLink.strInstatDataObject & "$get_row_names")

        ucrPnlOverallOptions.AddFunctionNamesCondition(rdoSetRowNamesFromColumn, frmMain.clsRLink.strInstatDataObject & "$set_row_names")
        ucrPnlOverallOptions.AddParameterPresentCondition(rdoSetRowNamesFromColumn, "row_names")

        ucrPnlOverallOptions.AddFunctionNamesCondition(rdoResetintoPositiveIntegers, frmMain.clsRLink.strInstatDataObject & "$set_row_names")
        ucrPnlOverallOptions.AddParameterPresentCondition(rdoResetintoPositiveIntegers, "row_names", bNewIsPositive:=False)

        ucrPnlOverallOptions.AddFunctionNamesCondition(rdoSortbyRowNames, frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")

        ucrPnlOverallOptions.AddToLinkedControls(ucrNewColumnName, {rdoCopyRowNamesIntoFirstColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrReceiverRowNames, {rdoSetRowNamesFromColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrPnlSortOptions, {rdoSortbyRowNames}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOverallOptions.AddToLinkedControls(ucrChkAsNumeric, {rdoSortbyRowNames}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'temp hidden as not working
        rdoSortbyRowNames.Visible = False
        rdoSortAscending.Visible = False
        rdoSortDescending.Visible = False

        'ucrPnlSortOptions
        ucrPnlSortOptions.SetParameter(New RParameter("decreasing", 2))
        ucrPnlSortOptions.AddRadioButton(rdoSortAscending, "FALSE")
        ucrPnlSortOptions.AddRadioButton(rdoSortDescending, "TRUE")
        ucrPnlSortOptions.SetRDefault("TRUE")

        'ucrChkAsNumeric
        ucrChkAsNumeric.SetParameter(New RParameter("row_names_as_numeric", 5))
        ucrChkAsNumeric.SetText("Treat Row Names as Numeric")
        ucrChkAsNumeric.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkAsNumeric.SetRDefault("TRUE")

        'ucrNewColumnName
        ucrNewColumnName.SetIsTextBox()
        ucrNewColumnName.SetPrefix("row_names")
        ucrNewColumnName.SetSaveTypeAsColumn()
        ucrNewColumnName.SetDataFrameSelector(ucrSelectorRowNames.ucrAvailableDataFrames)
        ucrNewColumnName.SetLabelText("Column Name:")
        ucrNewColumnName.SetAssignToBooleans(bTempInsertColumnBefore:=True)
    End Sub

    Private Sub SetDefaults()
        clsRowNamesFunction = New RFunction

        ucrNewColumnName.Reset()
        ucrSelectorRowNames.Reset()

        clsRowNamesFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_row_names")
        clsRowNamesFunction.SetAssignTo(strTemp:=ucrNewColumnName.GetText(), strTempDataframe:=ucrSelectorRowNames.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempColumn:=ucrNewColumnName.GetText(), bInsertColumnBefore:=True)
        ucrBase.clsRsyntax.SetBaseRFunction(clsRowNamesFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, ucrBase.clsRsyntax.clsBaseFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (ucrSelectorRowNames.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "") OrElse (rdoSetRowNamesFromColumn.Checked AndAlso ucrReceiverRowNames.IsEmpty) OrElse (rdoCopyRowNamesIntoFirstColumn.Checked AndAlso Not ucrNewColumnName.IsComplete) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub ucrPnl_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOverallOptions.ControlValueChanged
        If rdoSetRowNamesFromColumn.Checked Then
            ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ucrSelectorRowNames.SetVariablesVisible(True)
        Else
            ucrSelectorRowNames.SetVariablesVisible(False)
            If rdoCopyRowNamesIntoFirstColumn.Checked Then
                ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$get_row_names")
            ElseIf rdoResetintoPositiveIntegers.Checked Then
                ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$set_row_names")
            ElseIf rdoSortbyRowNames.Checked Then
                ucrBase.clsRsyntax.SetFunction(frmMain.clsRLink.strInstatDataObject & "$sort_dataframe")
            End If
        End If
    End Sub

    Private Sub CoreControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorRowNames.ControlContentsChanged, ucrPnlOverallOptions.ControlContentsChanged, ucrReceiverRowNames.ControlContentsChanged, ucrNewColumnName.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class