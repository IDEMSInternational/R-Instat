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
Public Class dlgDummyVariables
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsDummyColsFunction As New RFunction
    Private clsDummyFunction As New RFunction
    Private Sub dlgIndicatorVariable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOkEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 41

        ucrSelectorDummyVariable.SetParameter(New RParameter(".data", 0))
        ucrSelectorDummyVariable.SetParameterIsrfunction()

        ucrReceiverFactor.SetParameter(New RParameter("select_columns", 1))
        ucrReceiverFactor.Selector = ucrSelectorDummyVariable
        ucrReceiverFactor.SetMeAsReceiver()
        ucrReceiverFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverFactor.strSelectorHeading = "Factors"
        ucrReceiverFactor.SetParameterIsString()

        ucrPnlLevelOmitted.AddRadioButton(rdoNone)
        ucrPnlLevelOmitted.AddRadioButton(rdoFirst)
        ucrPnlLevelOmitted.AddRadioButton(rdoMostFrequent)

        ucrPnlLevelOmitted.AddParameterValuesCondition(rdoNone, "checked", "none")
        ucrPnlLevelOmitted.AddParameterValuesCondition(rdoFirst, "checked", "first")
        ucrPnlLevelOmitted.AddParameterValuesCondition(rdoMostFrequent, "checked", "most")
    End Sub

    Private Sub SetDefaults()
        clsDummyColsFunction = New RFunction
        clsDummyFunction = New RFunction

        ucrReceiverFactor.SetMeAsReceiver()
        ucrSelectorDummyVariable.Reset()

        clsDummyFunction.AddParameter("checked", "none", iPosition:=0)

        clsDummyColsFunction.SetPackageName("fastDummies")
        clsDummyColsFunction.SetRCommand("dummy_cols")
        clsDummyColsFunction.AddParameter("remove_first_dummy", "FALSE", iPosition:=2)
        clsDummyColsFunction.AddParameter("remove_most_frequent_dummy", "FALSE", iPosition:=3)
        clsDummyColsFunction.AddParameter("ignore_na", "FALSE", iPosition:=4)
        clsDummyColsFunction.AddParameter("split", "NULL", iPosition:=5)
        clsDummyColsFunction.AddParameter("remove_selected_columns", "FALSE", iPosition:=6)
        ucrBase.clsRsyntax.SetBaseRFunction(clsDummyColsFunction)
        ucrBase.clsRsyntax.SetAssignTo(strAssignToName:="dummy", strTempDataframe:=ucrSelectorDummyVariable.ucrAvailableDataFrames.cboAvailableDataFrames.Text, bAssignToColumnWithoutNames:=True)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSelectorDummyVariable.SetRCode(clsDummyColsFunction, bReset)
        ucrReceiverFactor.SetRCode(clsDummyColsFunction, bReset)
        ucrPnlLevelOmitted.SetRCode(clsDummyFunction, bReset)
    End Sub

    Private Sub TestOkEnabled()
        If Not ucrReceiverFactor.IsEmpty Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlLevelOmitted_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlLevelOmitted.ControlValueChanged
        If rdoNone.Checked Then
            clsDummyFunction.AddParameter("checked", "none", iPosition:=0)
            clsDummyColsFunction.AddParameter("remove_first_dummy", "FALSE", iPosition:=2)
            clsDummyColsFunction.AddParameter("remove_most_frequent_dummy", "FALSE", iPosition:=3)
        ElseIf rdoFirst.Checked Then
            clsDummyFunction.AddParameter("checked", "first", iPosition:=0)
            clsDummyColsFunction.AddParameter("remove_first_dummy", "TRUE", iPosition:=2)
            clsDummyColsFunction.AddParameter("remove_most_frequent_dummy", "FALSE", iPosition:=3)
        ElseIf rdoMostFrequent.Checked Then
            clsDummyFunction.AddParameter("checked", "most", iPosition:=0)
            clsDummyColsFunction.AddParameter("remove_first_dummy", "FALSE", iPosition:=2)
            clsDummyColsFunction.AddParameter("remove_most_frequent_dummy", "TRUE", iPosition:=3)
        End If
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverFactor.ControlContentsChanged
        TestOkEnabled()
    End Sub
End Class