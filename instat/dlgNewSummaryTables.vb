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
Public Class dlgNewSummaryTables
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsSummariesList As New RFunction
    Private bResetSubdialog As Boolean = False
    Private clsDefaultFunction As New RFunction
    Private clsStargazerFunction As New RFunction

    Private Sub dlgNewSummaryTables_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.iCallType = 2

        ucrSelectorSummaryTables.SetParameter(New RParameter("data_name", 0))
        ucrSelectorSummaryTables.SetParameterIsString()

        ucrReceiverNumeric.SetParameter(New RParameter("columns_to_summarise", 1))
        ucrReceiverNumeric.Selector = ucrSelectorSummaryTables
        ucrReceiverNumeric.SetDataType("numeric")
        ucrReceiverNumeric.SetParameterIsString()

        ucrReceiverFactor.SetParameter(New RParameter("row_factors", 3)) ' how to move row_factors to column_factors
        ucrReceiverFactor.SetParameterIsString()
        ucrReceiverFactor.Selector = ucrSelectorSummaryTables
        ucrReceiverFactor.SetDataType("factor")

        ucrReceiverColumnFactor.SetParameter(New RParameter("column_factors", 4)) ' how to move row_factors to column_factors
        ucrReceiverColumnFactor.SetParameterIsString()
        ucrReceiverColumnFactor.Selector = ucrSelectorSummaryTables
        ucrReceiverColumnFactor.SetDataType("factor")
        ' summary_name 7

        ucrChkStoreResults.Enabled = False ' why do we offer this on the code?
        'ucrChkStoreResults.SetParameter(New RParameter("store_results", 4))
        ucrChkStoreResults.SetText("Store Results in Data Frame")
        'ucrChkStoreResults.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        'ucrChkStoreResults.SetRDefault("TRUE")

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm", 6))
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        ucrChkDisplayMargins.SetParameter(New RParameter("include_margins", 8))
        ucrChkDisplayMargins.SetText("Display Margins")
        ucrChkDisplayMargins.SetRDefault("FALSE")

        ucrChkPrintOutput.SetParameter(New RParameter("return_output", 9))
        ucrChkPrintOutput.SetText("Print to Output Window")
        ucrChkPrintOutput.SetRDefault("FALSE")

        ucrChkSummaries.SetParameter(New RParameter("treat_columns_as_factor", 10))
        ucrChkSummaries.SetText("Treat Summary Columns as a Further Factor")
        ucrChkSummaries.SetRDefault("FALSE")

        '        ucrChkWeight.SetParameter(New RParameter("", ))
        ucrChkWeight.SetText("Weights")
        ucrChkWeight.AddToLinkedControls(ucrSingleReceiver, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrSingleReceiver.Selector = ucrSelectorSummaryTables
    End Sub

    Private Sub SetDefaults()
        clsDefaultFunction = New RFunction
        clsSummariesList = New RFunction
        clsStargazerFunction = New RFunction

        'clsStargazerFunction.SetPackageName("xtable")
        clsStargazerFunction.SetRCommand("print")
        clsStargazerFunction.AddParameter("x", clsRFunctionParameter:=clsDefaultFunction)
        clsStargazerFunction.AddParameter("type", Chr(34) & "html" & Chr(34))

        ucrReceiverFactor.SetMeAsReceiver()
        ucrSelectorSummaryTables.Reset()

        clsSummariesList.SetRCommand("c")
        clsSummariesList.AddParameter("summary_mean", Chr(34) & "summary_mean" & Chr(34), bIncludeArgumentName:=False) ' TODO decide which default(s) to use?

        clsDefaultFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary_table")
        clsDefaultFunction.AddParameter("summaries", clsRFunctionParameter:=clsSummariesList, iPosition:=2)
        clsDefaultFunction.AddParameter("return_output", "TRUE", iPosition:=9) ' we don't want it in the data frame?
        clsDefaultFunction.AddParameter("store_results", "FALSE", iPosition:=4)
        ucrBase.clsRsyntax.bHTMLOutput = True
        ucrBase.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
        ucrBase.clsRsyntax.iCallType = 1
        bResetSubdialog = True
    End Sub

    Public Sub SetRCodeForControls(bReset As Boolean)
        SetRCode(Me, clsDefaultFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If (Not ucrReceiverFactor.IsEmpty OrElse Not ucrReceiverNumeric.IsEmpty) AndAlso ucrNudColumnFactors.GetText <> "" AndAlso ucrNudDecimals.GetText <> "" AndAlso (Not ucrChkWeight.Checked OrElse (ucrChkWeight.Checked AndAlso Not ucrSingleReceiver.IsEmpty)) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub cmdSummaries_Click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsSummariesList, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub EnableCheckSummaries()
        If ucrReceiverNumeric.lstSelectedVariables.Items.Count > 1 Then
            ucrChkSummaries.Enabled = True
        Else
            ucrChkSummaries.Enabled = False
        End If
    End Sub

    Private Sub ColumnFactors()
        ' if ucrNudColumnFactors = 0 then 

        ' 
    End Sub

    Public Sub PageDisplay()
        If clsSummariesList.clsParameters.Count = 1 Then
            clsDefaultFunction.AddParameter("page_display", "FALSE", iPosition:=11)
        Else
            clsDefaultFunction.AddParameter("page_display", "TRUE", iPosition:=11)
        End If
    End Sub

    Private Sub ucrReceiverNumeric_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverNumeric.ControlValueChanged
        EnableCheckSummaries()
    End Sub

    Private Sub ucrReceiverFactor_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged, ucrChkWeight.ControlContentsChanged, ucrSingleReceiver.ControlContentsChanged, ucrNudColumnFactors.ControlContentsChanged, ucrNudDecimals.ControlContentsChanged, ucrReceiverNumeric.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class