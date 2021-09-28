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
Public Class dlgCluster
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private clsNaOmitFunction, clsScaleFunction, clsStatsFunction, clsStatsScaleFunction As New RFunction
    Private clsPipeOperator As New ROperator
    Private Sub dlgCluster_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstLoad Then
            InitialiseDialog()
            bFirstLoad = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        autoTranslate(Me)
        TestOkEnabled()
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrPnlPrepareData.AddRadioButton(rdoScaleData)
        ucrPnlPrepareData.AddRadioButton(rdoDistanceData)

        ucrPnlPrepareData.AddFunctionNamesCondition(rdoScaleData, "scale")
        ucrPnlPrepareData.AddToLinkedControls({ucrChkCenterEachVariable, ucrChkOmitMissingRows, ucrChkScaleEachVariable}, {rdoScaleData}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlSelectData.AddRadioButton(rdoWholeDataFrame)
        ucrPnlSelectData.AddRadioButton(rdoSelectedColumn)

        ucrPnlSelectData.AddParameterPresentCondition(rdoWholeDataFrame, "data")
        ucrPnlSelectData.AddParameterPresentCondition(rdoSelectedColumn, "x")

        ucrChkOmitMissingRows.SetParameter(New RParameter("object", 1))
        ucrChkOmitMissingRows.SetText("Omit Missing Values")
        'ucrChkOmitMissingRows.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkOmitMissingRows.SetRDefault("FALSE")

        ucrChkCenterEachVariable.SetParameter(New RParameter("center", 1))
        ucrChkCenterEachVariable.SetText("Center Each Variable")
        ucrChkCenterEachVariable.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCenterEachVariable.SetRDefault("TRUE")

        ucrChkScaleEachVariable.SetParameter(New RParameter("scale", 2))
        ucrChkScaleEachVariable.SetText("Scale Each Variable")
        ucrChkScaleEachVariable.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkScaleEachVariable.SetRDefault("TRUE")

        'ucrNewDataFrame
        ucrSaveNewDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrSelectorPrepareData.ucrAvailableDataFrames)
        ucrSaveNewDataFrame.SetLabelText("New Data Frame Name:")
        ucrSaveNewDataFrame.SetIsTextBox()

        ucrPnlSelectData.AddToLinkedControls(ucrSaveNewDataFrame, {rdoScaleData}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverPrepareData.SetParameter(New RParameter("x", 0))
        ucrReceiverPrepareData.SetParameterIsRFunction()
        ucrReceiverPrepareData.Selector = ucrSelectorPrepareData
        ucrReceiverPrepareData.bForceAsDataFrame = True
        ucrReceiverPrepareData.SetMeAsReceiver()

        ucrSelectorPrepareData.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrSelectorPrepareData.SetParameterIsrfunction()
        ucrPnlSelectData.AddToLinkedControls(ucrReceiverPrepareData, {rdoSelectedColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
    End Sub
    Private Sub SetDefaults()
        clsScaleFunction = New RFunction
        clsNaOmitFunction = New RFunction
        clsStatsFunction = New RFunction
        clsStatsScaleFunction = New RFunction
        clsPipeOperator = New ROperator

        rdoScaleData.Checked = True

        ucrSelectorPrepareData.Reset()
        ucrSaveNewDataFrame.Reset()
        SetDataFrameName()

        clsScaleFunction.SetRCommand("scale")

        clsStatsScaleFunction.SetRCommand("scale")

        clsStatsFunction.SetPackageName("stats")
        clsStatsFunction.SetRCommand("na.omit")
        clsStatsFunction.AddParameter("object", clsRFunctionParameter:=clsStatsScaleFunction, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsScaleFunction)

    End Sub
    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrReceiverPrepareData.AddAdditionalCodeParameterPair(clsScaleFunction, New RParameter("x", 0), 1)
        ucrSaveNewDataFrame.AddAdditionalRCode(clsStatsFunction, bReset)
        ucrChkCenterEachVariable.AddAdditionalCodeParameterPair(clsStatsScaleFunction, New RParameter("center", 1), iAdditionalPairNo:=1)
        ucrChkScaleEachVariable.AddAdditionalCodeParameterPair(clsStatsScaleFunction, New RParameter("scale", 2), iAdditionalPairNo:=1)

        ucrPnlSelectData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrPnlPrepareData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkCenterEachVariable.SetRCode(clsScaleFunction, bReset)
        ucrSaveNewDataFrame.SetRCode(clsScaleFunction, bReset)
        ucrChkScaleEachVariable.SetRCode(clsScaleFunction, bReset)
        ucrSelectorPrepareData.SetRCode(clsScaleFunction, bReset)
    End Sub

    Private Sub NewFunction()
        If rdoScaleData.Checked Then
            If ucrChkOmitMissingRows.Checked Then
                ucrBase.clsRsyntax.SetBaseRFunction(clsStatsFunction)
            Else
                ucrBase.clsRsyntax.SetBaseRFunction(clsScaleFunction)
            End If
        End If
    End Sub
    Private Sub TestOkEnabled()
        If ucrSelectorPrepareData.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "" OrElse (rdoSelectedColumn.Checked AndAlso ucrReceiverPrepareData.IsEmpty) Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub
    Private Sub AddRemoveDataHideOptionsButtons()
        If rdoWholeDataFrame.Checked Then
            clsScaleFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPrepareData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
            clsStatsScaleFunction.AddParameter("data", clsRFunctionParameter:=ucrSelectorPrepareData.ucrAvailableDataFrames.clsCurrDataFrame, bIncludeArgumentName:=False, iPosition:=0)
            ucrSelectorPrepareData.lstAvailableVariable.Visible = False
            ucrSelectorPrepareData.btnAdd.Visible = False
            ucrSelectorPrepareData.btnDataOptions.Visible = False
        ElseIf rdoSelectedColumn.Checked Then
            clsScaleFunction.RemoveParameterByName("data")
            clsStatsScaleFunction.RemoveParameterByName("data")
            ucrSelectorPrepareData.lstAvailableVariable.Visible = True
            ucrSelectorPrepareData.btnAdd.Visible = True
            ucrSelectorPrepareData.btnDataOptions.Visible = True
        End If
    End Sub
    Private Sub ucrControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSelectData.ControlValueChanged, ucrSelectorPrepareData.ControlValueChanged, ucrReceiverPrepareData.ControlValueChanged
        AddRemoveDataHideOptionsButtons()
        clsStatsScaleFunction.AddParameter("x", iPosition:=0, bIncludeArgumentName:=False, clsRFunctionParameter:=ucrSelectorPrepareData.ucrAvailableDataFrames.clsCurrDataFrame)
    End Sub
    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub
    Private Sub SetDataFrameName()
        If ucrSelectorPrepareData.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso (Not ucrSaveNewDataFrame.bUserTyped) Then
            ucrSaveNewDataFrame.SetName(ucrSelectorPrepareData.ucrAvailableDataFrames.cboAvailableDataFrames.Text & "_scale")
        End If
    End Sub

    Private Sub ucrSelectorPrepareData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorPrepareData.ControlValueChanged

    End Sub
    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPrepareData.ControlContentsChanged, ucrSelectorPrepareData.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged, ucrChkOmitMissingRows.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlPrepareData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPrepareData.ControlValueChanged
        AddRemoveDataHideOptionsButtons()
        SetDataFrameName()
        NewFunction()
    End Sub

    Private Sub ucrChkOmitMissingRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissingRows.ControlValueChanged
        NewFunction()
    End Sub
End Class