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
    Private bResetRCode As Boolean = True
    Private clsScaleFunction, clsStatsNAOmitFunction, clsDummyFunction,
        clsStatsScaleFunction, clsMatrixDistFunction, clsDistFunction, clsMatrixFunction As New RFunction

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
        Dim dctMethod As New Dictionary(Of String, String)
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.iHelpTopicID = 599

        ucrReceiverPrepareData.SetParameterIsRFunction()
        ucrReceiverPrepareData.Selector = ucrSelectorPrepareData
        ucrReceiverPrepareData.SetMeAsReceiver()
        ucrReceiverPrepareData.SetDataType("numeric")

        ucrSelectorPrepareData.SetParameterIsrfunction()

        ucrPnlPrepareData.AddRadioButton(rdoScaleData)
        ucrPnlPrepareData.AddRadioButton(rdoDistanceData)
        ucrPnlPrepareData.AddFunctionNamesCondition(rdoScaleData, {"scale", "na.omit"})
        ucrPnlPrepareData.AddFunctionNamesCondition(rdoDistanceData, {"dist", "as.matrix"})

        ucrPnlSelectData.AddRadioButton(rdoWholeDataFrame)
        ucrPnlSelectData.AddRadioButton(rdoSelectedColumn)
        ucrPnlSelectData.AddParameterValuesCondition(rdoWholeDataFrame, "checked", "whole")
        ucrPnlSelectData.AddParameterValuesCondition(rdoSelectedColumn, "checked", "selected")

        ucrChkOmitMissingRows.SetText("Omit Missing Values")
        ucrChkOmitMissingRows.AddParameterValuesCondition(True, "omit", "False")
        ucrChkOmitMissingRows.AddParameterValuesCondition(False, "omit", "True")

        ucrChkCenterEachVariable.SetParameter(New RParameter("center", 1))
        ucrChkCenterEachVariable.SetText("Centre")
        ucrChkCenterEachVariable.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkCenterEachVariable.SetRDefault("TRUE")

        ucrChkScaleEachVariable.SetParameter(New RParameter("scale", 2))
        ucrChkScaleEachVariable.SetText("Scale")
        ucrChkScaleEachVariable.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkScaleEachVariable.SetRDefault("TRUE")

        ucrChkMatrix.SetText("Matrix")
        ucrChkMatrix.AddParameterValuesCondition(True, "matrix", "True")
        ucrChkMatrix.AddParameterValuesCondition(False, "matrix", "False")

        ucrInputMethod.SetLinkedDisplayControl(lblMethod)
        ucrInputMethod.SetParameter(New RParameter("method", 1))
        dctMethod.Add("euclidean", Chr(34) & "euclidean" & Chr(34))
        dctMethod.Add("maximum", Chr(34) & "maximum" & Chr(34))
        dctMethod.Add("manhattan", Chr(34) & "manhattan" & Chr(34))
        dctMethod.Add("canberra", Chr(34) & "canberra" & Chr(34))
        dctMethod.Add("binary", Chr(34) & "binary" & Chr(34))
        dctMethod.Add("minkowski", Chr(34) & "minkowski" & Chr(34))
        ucrInputMethod.SetItems(dctMethod)
        ucrInputMethod.SetRDefault(Chr(34) & "euclidean" & Chr(34))

        ucrPnlSelectData.AddToLinkedControls(ucrReceiverPrepareData, {rdoSelectedColumn}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPrepareData.AddToLinkedControls({ucrChkCenterEachVariable, ucrChkOmitMissingRows, ucrChkScaleEachVariable}, {rdoScaleData}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPrepareData.AddToLinkedControls({ucrInputMethod, ucrChkMatrix}, {rdoDistanceData}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrSaveNewDataFrame.SetSaveTypeAsDataFrame()
        ucrSaveNewDataFrame.SetDataFrameSelector(ucrSelectorPrepareData.ucrAvailableDataFrames)
        ucrSaveNewDataFrame.SetLabelText("New Data Frame Name:")
        ucrSaveNewDataFrame.SetPrefix("scale")
        ucrSaveNewDataFrame.SetIsTextBox()
    End Sub

    Private Sub SetDefaults()
        clsScaleFunction = New RFunction
        clsStatsNAOmitFunction = New RFunction
        clsStatsScaleFunction = New RFunction
        clsMatrixDistFunction = New RFunction
        clsMatrixFunction = New RFunction
        clsDummyFunction = New RFunction
        clsDistFunction = New RFunction

        ucrSaveNewDataFrame.SetPrefix("scale")
        ucrSelectorPrepareData.Reset()
        ucrSaveNewDataFrame.Reset()

        clsDummyFunction.AddParameter("checked", "selected", iPosition:=0)
        clsDummyFunction.AddParameter("omit", "True", iPosition:=1)
        clsDummyFunction.AddParameter("matrix", "True", iPosition:=2)

        clsScaleFunction.SetRCommand("scale")

        clsDistFunction.SetRCommand("dist")
        clsDistFunction.SetPackageName("stats")

        clsStatsScaleFunction.SetRCommand("scale")

        clsMatrixDistFunction.SetRCommand("dist")

        clsMatrixFunction.SetPackageName("base")
        clsMatrixFunction.SetRCommand("as.matrix")
        clsMatrixFunction.AddParameter("x", clsRFunctionParameter:=clsMatrixDistFunction, iPosition:=0)

        clsStatsNAOmitFunction.SetPackageName("stats")
        clsStatsNAOmitFunction.SetRCommand("na.omit")
        clsStatsNAOmitFunction.AddParameter("object", clsRFunctionParameter:=clsStatsScaleFunction, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseRFunction(clsScaleFunction)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        bResetRCode = False
        ucrChkCenterEachVariable.AddAdditionalCodeParameterPair(clsStatsScaleFunction, New RParameter("center", 1), iAdditionalPairNo:=1)
        ucrChkScaleEachVariable.AddAdditionalCodeParameterPair(clsStatsScaleFunction, New RParameter("scale", 2), iAdditionalPairNo:=1)
        ucrSaveNewDataFrame.AddAdditionalRCode(clsStatsNAOmitFunction, bReset)
        ucrSaveNewDataFrame.AddAdditionalRCode(clsMatrixFunction, bReset)
        ucrInputMethod.AddAdditionalCodeParameterPair(clsMatrixDistFunction, New RParameter("method", 1), iAdditionalPairNo:=1)
        ucrSaveNewDataFrame.SetRCode(clsDistFunction, bReset)
        ucrInputMethod.SetRCode(clsDistFunction, bReset)
        ucrChkCenterEachVariable.SetRCode(clsScaleFunction, bReset)
        ucrSaveNewDataFrame.SetRCode(clsScaleFunction, bReset)
        ucrChkScaleEachVariable.SetRCode(clsScaleFunction, bReset)
        ucrPnlSelectData.SetRCode(clsDummyFunction, bReset)
        ucrPnlPrepareData.SetRCode(ucrBase.clsRsyntax.clsBaseFunction, bReset)
        ucrChkOmitMissingRows.SetRCode(clsDummyFunction, bReset)
        ucrChkMatrix.SetRCode(clsDummyFunction, bReset)
        bResetRCode = True
    End Sub

    Private Sub TestOkEnabled()
        If ucrSelectorPrepareData.ucrAvailableDataFrames.cboAvailableDataFrames.Text = "" _
            OrElse (rdoSelectedColumn.Checked AndAlso ucrReceiverPrepareData.IsEmpty) _
            OrElse Not ucrSaveNewDataFrame.IsComplete() Then
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(True)
        End If
    End Sub

    Private Sub AddRemoveDataHideOptionsButtons()
        Dim bVisible As Boolean = rdoSelectedColumn.Checked
        ucrSelectorPrepareData.lstAvailableVariable.Visible = bVisible
        ucrSelectorPrepareData.btnAdd.Visible = bVisible
        ucrSelectorPrepareData.btnDataOptions.Visible = bVisible
    End Sub

    Private Sub SetBaseFunction()
        If bResetRCode Then
            If rdoScaleData.Checked Then
                If ucrChkOmitMissingRows.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsStatsNAOmitFunction)
                    clsDummyFunction.AddParameter("omit", "False", iPosition:=1)
                Else
                    clsDummyFunction.AddParameter("omit", "True", iPosition:=1)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsScaleFunction)
                End If
            ElseIf rdoDistanceData.Checked Then
                If ucrChkMatrix.Checked Then
                    ucrBase.clsRsyntax.SetBaseRFunction(clsMatrixFunction)
                    ucrBase.clsRsyntax.iCallType = 0
                    clsDummyFunction.AddParameter("matrix", "True", iPosition:=2)
                Else
                    clsDummyFunction.AddParameter("matrix", "False", iPosition:=2)
                    ucrBase.clsRsyntax.SetBaseRFunction(clsDistFunction)
                    ucrBase.clsRsyntax.RemoveAssignTo()
                    ucrBase.clsRsyntax.iCallType = 2
                End If
            End If
        End If
    End Sub

    Private Sub ChangeDataParameter()
        If bResetRCode Then
            If rdoScaleData.Checked Then
                If rdoWholeDataFrame.Checked Then
                    clsDummyFunction.AddParameter("checked", "whole", iPosition:=0)
                    clsScaleFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorPrepareData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                    clsStatsScaleFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorPrepareData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                Else
                    clsDummyFunction.AddParameter("checked", "selected", iPosition:=0)
                    clsScaleFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverPrepareData.GetVariables, iPosition:=0)
                    clsStatsScaleFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverPrepareData.GetVariables, iPosition:=0)
                End If
            ElseIf rdoDistanceData.Checked Then
                If rdoWholeDataFrame.Checked Then
                    clsDistFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorPrepareData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                    clsMatrixDistFunction.AddParameter("x", clsRFunctionParameter:=ucrSelectorPrepareData.ucrAvailableDataFrames.clsCurrDataFrame, iPosition:=0)
                Else
                    clsDistFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverPrepareData.GetVariables, iPosition:=0)
                    clsMatrixDistFunction.AddParameter("x", clsRFunctionParameter:=ucrReceiverPrepareData.GetVariables, iPosition:=0)
                End If
            End If
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlPrepareData_ContrlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPrepareData.ControlValueChanged, ucrInputMethod.ControlValueChanged
        ChangeDataParameter()
        SetBaseFunction()
        If rdoScaleData.Checked Then
            ucrSaveNewDataFrame.SetPrefix("scale")
        ElseIf rdoDistanceData.Checked Then
            ucrSaveNewDataFrame.SetPrefix("distance")
        End If
    End Sub

    Private Sub ucrCore_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPrepareData.ControlContentsChanged, ucrSelectorPrepareData.ControlContentsChanged, ucrPnlSelectData.ControlContentsChanged, ucrSaveNewDataFrame.ControlContentsChanged, ucrInputMethod.ControlContentsChanged
        TestOkEnabled()
    End Sub

    Private Sub ucrPnlSelectData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlSelectData.ControlValueChanged
        ChangeDataParameter()
        AddRemoveDataHideOptionsButtons()
    End Sub

    Private Sub ucrChkMatrix_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkMatrix.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrChkOmitMissingRows_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOmitMissingRows.ControlValueChanged
        SetBaseFunction()
    End Sub

    Private Sub ucrReceiverPrepareData_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverPrepareData.ControlValueChanged
        ChangeDataParameter()
    End Sub
End Class