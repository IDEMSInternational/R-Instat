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
Imports instat
Imports instat.Translations

Public Class dlgDescribeOneVariable
    Public bFirstLoad As Boolean = True
    Private clsDefaultFunction As New RFunction
    Public clsRCustomFunction As New RFunction
    Private bResetSubdialog As Boolean = False
    Private Sub dlgDescriptiveStatistics_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            SetDefaults()
            bFirstLoad = False
        Else
            ReopenDialog()
        End If
        autoTranslate(Me)
    End Sub

    Private Sub SetDefaults()
        ' Set default RFunction as the base function
        ucrBaseDescribeOneVar.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorDescribeOneVar.Reset()
        'next line should go to the sub
        'SetRCode(Me, ucrBaseDescribeOneVar.clsRsyntax.clsBaseFunction, True)
        'ChooseFunction() 'this might go to the 
        ucrChkOmitMissing.SetRCode(clsDefaultFunction, True)
        ucrChkOmitMissing.SetRCode(clsRCustomFunction, True)
        ucrChkSaveResult.SetRCode(clsRCustomFunction, True)
        ucrReceiverDescribeOneVar.SetRCode(clsRCustomFunction, True)
        ucrReceiverDescribeOneVar.SetRCode(clsDefaultFunction, True)
        ucrSelectorDescribeOneVar.SetRCode(clsRCustomFunction, True)
        bResetSubdialog = True
        TestOKEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBaseDescribeOneVar.iHelpTopicID = 410
        ucrBaseDescribeOneVar.clsRsyntax.iCallType = 2
        ucrReceiverDescribeOneVar.Selector = ucrSelectorDescribeOneVar
        ucrReceiverDescribeOneVar.SetMeAsReceiver()
        clsRCustomFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$summary")


        ucrReceiverDescribeOneVar.SetParameter(New RParameter("columns_to_summarise"))
        ucrReceiverDescribeOneVar.SetParameterIsString()

        'ucrSelectorDescribeOneVar.SetParameter(New RParameter("data_name"))
        'ucrSelectorDescribeOneVar.SetParameterIsString()

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm"))
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        'SetParameter({ucrChkCustomise, ucrReceiverDescribeOneVar}, New RParameter("data_name"))
        'ucrChkCustomise.SetText("Customise")
        'ucrChkCustomise.bChangeParameterValue = False
        'ucrChkCustomise.AddToLinkedControls(ucrLinked:=ucrReceiverDescribeOneVar, objValues:={True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'Choose Function() should be called here

        ucrChkSaveResult.SetText("Save Result")
        ucrChkSaveResult.SetParameter(New RParameter("store_results"))
        ucrChkSaveResult.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkSaveResult.SetRDefault("FALSE")

        'default for the custom function
        clsRCustomFunction.AddParameter("return_output", "TRUE")

        'Define the default RFunction
        clsDefaultFunction.SetRCommand("summary")

    End Sub

    Public Sub TestOKEnabled()
        If ucrReceiverDescribeOneVar.IsEmpty() OrElse (chkCustomise.Checked AndAlso sdgSummaries.strSummariesParameter = "c()") Then
            ucrBaseDescribeOneVar.OKEnabled(False)
        Else
            ucrBaseDescribeOneVar.OKEnabled(True)
        End If
        'ChooseFunction()
    End Sub

    Private Sub ReopenDialog()

    End Sub

    'Private Sub SetDefaults()
    '    chkSaveResult.Checked = False
    '    sdgSummaries.SetMyRFunction(clsRCustomFunction)
    '    sdgSummaries.SetDefaults()
    '    ucrSelectorDescribeOneVar.Reset()
    '    chkSaveResult.Checked = False
    '    chkSaveResult.Enabled = False
    '    chkCustomise.Checked = False
    '    chkOmitMissing.Checked = False
    '    ChooseFunction()
    '    StoreResultsParamenter()
    '    OutputOption()
    '    TestOKEnabled()
    'End Sub



    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickReset
        SetDefaults()
    End Sub

    Private Sub ChooseFunction()
        If chkCustomise.Checked Then
            ucrBaseDescribeOneVar.clsRsyntax.SetBaseRFunction(clsRCustomFunction)
            ucrReceiverDescribeOneVar.SetParameter(New RParameter("columns_to_summarise"))
            ucrReceiverDescribeOneVar.SetParameterIsString()
            ucrSelectorDescribeOneVar.SetParameter(New RParameter("data_name"))
            ucrSelectorDescribeOneVar.SetParameterIsString()
            'cmdSummaries.Enabled = True
        Else
            ucrBaseDescribeOneVar.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
            ucrReceiverDescribeOneVar.SetParameter(New RParameter("object"))
            ucrReceiverDescribeOneVar.SetParameterIsRFunction()
            clsDefaultFunction.RemoveParameterByName("data_name")
            'cmdSummaries.Enabled = False
        End If
        SetRCode(Me, ucrBaseDescribeOneVar.clsRsyntax.clsBaseFunction, True)
    End Sub

    'Private Sub OutputOption()
    '    clsRCustomFunction.AddParameter("return_output", "TRUE")
    'End Sub

    'Private Sub ucrSelectorForColumnStatistics_DataFrameChanged() Handles ucrSelectorDescribeOneVar.DataFrameChanged
    '    clsRCustomFunction.AddParameter("data_name", Chr(34) & ucrSelectorDescribeOneVar.ucrAvailableDataFrames.cboAvailableDataFrames.SelectedItem & Chr(34))
    'End Sub

    'Private Sub ucrReceiverSelectedVariables_SelectionChanged() Handles ucrReceiverDescribeOneVar.SelectionChanged
    '    If Not ucrReceiverDescribeOneVar.IsEmpty Then
    '        clsRCustomFunction.AddParameter("columns_to_summarise", ucrReceiverDescribeOneVar.GetVariableNames())
    '        clsRBaseFunction.AddParameter("object", clsRFunctionParameter:=ucrReceiverDescribeOneVar.GetVariables())
    '    Else
    '        clsRCustomFunction.RemoveParameterByName("columns_to_summarise")
    '    End If
    '    TestOKEnabled()
    'End Sub

    'Private Sub chkSaveResult_CheckedChanged(sender As Object, e As EventArgs) Handles chkSaveResult.CheckedChanged
    '    StoreResultsParamenter()
    '    OutputOption()
    'End Sub

    'Private Sub chkDisplayResults_CheckedChanged(sender As Object, e As EventArgs)
    '    StoreResultsParamenter()
    '    OutputOption()
    'End Sub

    'Private Sub chkCustomise_CheckedChanged(sender As Object, e As EventArgs)
    '    ChooseFunction()
    '    TestOKEnabled()
    'End Sub

    'Private Sub StoreResultsParamenter()
    '    If chkSaveResult.Checked Then
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsRCustomFunction.AddParameter("store_results", "TRUE")
    '        Else
    '            clsRCustomFunction.RemoveParameterByName("store_results")
    '        End If
    '        clsRCustomFunction.AddParameter("store_results", "FALSE")
    '    End If
    '    clsRCustomFunction.AddParameter("drop", "TRUE")
    'End Sub

    Private Sub cmdSummaries_click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        'sdgSummaries.ShowDialog()
        'sdgSummaries.TestSummaries()
        'TestOKEnabled()
        ' sdgSummaries.SetMyRFunction(ucrBaseDescribeOneVar.clsRsyntax.clsBaseFunction, bResetSubdialog)
        sdgSummaries.SetRFunction(clsRCustomFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    'Private Sub chkExcludeMissing_CheckedChanged(sender As Object, e As EventArgs) Handles chkOmitMissing.CheckedChanged
    '    If chkOmitMissing.Checked Then
    '        clsRCustomFunction.AddParameter("na.rm", "TRUE")
    '        clsRBaseFunction.AddParameter("na.rm", "TRUE")
    '    Else
    '        If frmMain.clsInstatOptions.bIncludeRDefaultParameters Then
    '            clsRCustomFunction.AddParameter("na.rm", "FALSE")
    '            clsRBaseFunction.AddParameter("na.rm", "FALSE")
    '        Else
    '            clsRCustomFunction.RemoveParameterByName("na.rm")
    '            clsRBaseFunction.RemoveParameterByName("na.rm")
    '        End If
    '    End If
    'End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDescribeOneVar.ControlContentsChanged, ucrReceiverDescribeOneVar.ControlContentsChanged
        TestOKEnabled()
        ChooseFunction()
    End Sub

    Private Sub chkCustomise_CheckedChanged(sender As Object, e As EventArgs) Handles chkCustomise.CheckedChanged
        ChooseFunction()
    End Sub

    Private Sub AllControls_ControlValueChanged(ucrChangedControl As ucrCore)
        TestOKEnabled()
        ChooseFunction()
    End Sub
End Class
