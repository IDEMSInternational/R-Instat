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
        ucrBaseDescribeOneVar.clsRsyntax.SetBaseRFunction(clsDefaultFunction.Clone())
        ucrSelectorDescribeOneVar.Reset()
        ucrReceiverDescribeOneVar.Clear()
        SetRCode(Me, ucrBaseDescribeOneVar.clsRsyntax.clsBaseFunction, True)
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

        ucrChkOmitMissing.SetText("Omit Missing Values")
        ucrChkOmitMissing.SetParameter(New RParameter("na.rm"))
        ucrChkOmitMissing.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissing.SetRDefault("FALSE")

        'this should enable the command button leading to the subdialog
        ucrChkCustomise.SetText("Customise")
        ucrChkCustomise.bChangeParameterValue = False


        ucrChkSaveResult.SetText("Save Result") 'this is disabled in the initial implementation
        'ucrChkSaveResult.SetParameter(New RParameter("store_results"))
        'ucrChkSaveResult.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        'ucrChkSaveResult.SetRDefault("FALSE")

        'setting controls to appropriate functions
        ucrChkOmitMissing.SetRCode(clsDefaultFunction, True)
        ucrChkOmitMissing.SetRCode(clsRCustomFunction, True)
        ucrChkSaveResult.SetRCode(clsRCustomFunction, True)
        ucrReceiverDescribeOneVar.SetRCode(clsRCustomFunction, True)
        ucrReceiverDescribeOneVar.SetRCode(clsDefaultFunction, True)
        ucrSelectorDescribeOneVar.SetRCode(clsRCustomFunction, True)

        clsDefaultFunction.SetRCommand("summary")
        clsRCustomFunction.AddParameter("return_output", "TRUE")
    End Sub

    Public Sub TestOKEnabled()
        If ucrReceiverDescribeOneVar.IsEmpty() OrElse (ucrChkCustomise.Checked AndAlso sdgSummaries.strSummariesParameter = "c()") Then
            ucrBaseDescribeOneVar.OKEnabled(False)
        Else
            ucrBaseDescribeOneVar.OKEnabled(True)
        End If
    End Sub

    Private Sub ReopenDialog()
        TestOKEnabled()
    End Sub

    Private Sub ucrBaseDescribeOneVar_ClickReset(sender As Object, e As EventArgs) Handles ucrBaseDescribeOneVar.ClickReset
        SetDefaults()
    End Sub

    Private Sub ChooseFunction()
        If ucrChkCustomise.Checked Then
            ucrBaseDescribeOneVar.clsRsyntax.SetBaseRFunction(clsRCustomFunction)
            ucrReceiverDescribeOneVar.SetParameter(New RParameter("columns_to_summarise"))
            ucrReceiverDescribeOneVar.SetParameterIsString()
            ucrSelectorDescribeOneVar.SetParameter(New RParameter("data_name"))
            ucrSelectorDescribeOneVar.SetParameterIsString()
            cmdSummaries.Enabled = True
        Else
            ucrBaseDescribeOneVar.clsRsyntax.SetBaseRFunction(clsDefaultFunction)
            ucrReceiverDescribeOneVar.SetParameter(New RParameter("object"))
            ucrReceiverDescribeOneVar.SetParameterIsRFunction()
            clsDefaultFunction.RemoveParameterByName("data_name")
            cmdSummaries.Enabled = False
        End If
        SetRCode(Me, ucrBaseDescribeOneVar.clsRsyntax.clsBaseFunction, True)
    End Sub


    Private Sub cmdSummaries_click(sender As Object, e As EventArgs) Handles cmdSummaries.Click
        sdgSummaries.SetRFunction(clsRCustomFunction, bResetSubdialog)
        bResetSubdialog = False
        sdgSummaries.ShowDialog()
        TestOKEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrSelectorDescribeOneVar.ControlContentsChanged, ucrReceiverDescribeOneVar.ControlContentsChanged, ucrChkCustomise.ControlContentsChanged
        ChooseFunction()
        TestOKEnabled()
    End Sub
End Class
