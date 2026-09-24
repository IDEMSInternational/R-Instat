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

Public Class dlgResiduals
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True

    Private ReadOnly strModelTmpName As String = "model_tmp"
    Private ReadOnly strLastGraphName As String = "last_graph"

    Private clsGetModelFunction As New RFunction
    Private clsAssignModelOperator As New ROperator
    Private clsResplotFunction As New RFunction
    Private clsRmFunction As New RFunction

    Private Sub dlgResiduals_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
        ucrBase.iHelpTopicID = 0
        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        ucrBase.clsRsyntax.iCallType = 3

        ucrReceiverModel.SetItemType(RObjectTypeLabel.Model)
        ucrReceiverModel.Selector = ucrSelectorResiduals
        ucrReceiverModel.SetMeAsReceiver()
        ucrReceiverModel.strSelectorHeading = "Models"

        ucrChkShapiro.SetText("Shapiro")
        ucrChkShapiro.SetParameter(New RParameter("shapiro", 1), bNewAddRemoveParameter:=False, bNewChangeParameterValue:=True)
        ucrChkShapiro.SetValuesCheckedAndUnchecked("TRUE", "FALSE")
        ucrChkShapiro.SetRDefault("FALSE")

        ucrChkModel.SetText("Model")
        ucrChkModel.SetParameter(New RParameter("call", 2), bNewAddRemoveParameter:=False, bNewChangeParameterValue:=True)
        ucrNudCallSize.SetParameter(New RParameter("call.size", 5))
        ucrNudCallSize.SetMinMax(1, 20)
        ucrNudCallSize.DecimalPlaces = 0
        ucrNudCallSize.Increment = 1
        ucrNudCallSize.SetRDefault(9)
        ucrChkModel.AddToLinkedControls({ucrNudCallSize}, {True}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=9)

        ucrChkLabel.SetText("Label")
        ucrNudLabelSize.SetParameter(New RParameter("label.size", 3))
        ucrNudLabelSize.SetMinMax(1, 20)
        ucrNudLabelSize.DecimalPlaces = 0
        ucrNudLabelSize.Increment = 1
        ucrNudLabelSize.SetRDefault(10)
        ucrChkLabel.AddToLinkedControls({ucrNudLabelSize}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)

        ucrChkAxes.SetText("Axes")
        ucrNudAxesSize.SetParameter(New RParameter("axes.size", 4))
        ucrNudAxesSize.SetMinMax(1, 20)
        ucrNudAxesSize.DecimalPlaces = 0
        ucrNudAxesSize.Increment = 1
        ucrNudAxesSize.SetRDefault(10)
        ucrChkAxes.AddToLinkedControls({ucrNudAxesSize}, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=10)

        ucrChkOnePage.SetText("One Page")
        ucrChkOnePage.SetParameter(New RParameter("onepage", 6), bNewAddRemoveParameter:=False, bNewChangeParameterValue:=True)
        ucrNudOnePageCols.SetParameter(New RParameter("onepage_cols", 7))
        ucrNudOnePageCols.SetMinMax(1, 10)
        ucrNudOnePageCols.DecimalPlaces = 0
        ucrNudOnePageCols.Increment = 1
        ucrNudOnePageCols.SetRDefault(3)
        ucrChkOnePage.AddToLinkedControls({ucrNudOnePageCols}, {True}, bNewLinkedAddRemoveParameter:=False, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=3)

        ucrSaveResiduals.SetIsComboBox()
        ucrSaveResiduals.SetCheckBoxText("Store Plot:")
        ucrSaveResiduals.SetSaveTypeAsGraph()
        ucrSaveResiduals.SetPrefix("residual_plot")
        ucrSaveResiduals.SetDataFrameSelector(ucrSelectorResiduals.ucrAvailableDataFrames)
        ucrSaveResiduals.SetAssignToIfUncheckedValue(strLastGraphName)
    End Sub

    Private Sub SetDefaults()
        clsGetModelFunction = New RFunction
        clsAssignModelOperator = New ROperator
        clsResplotFunction = New RFunction
        clsRmFunction = New RFunction

        ucrSelectorResiduals.Reset()
        ucrSaveResiduals.Reset()
        ucrSaveResiduals.ucrChkSave.Checked = False

        clsGetModelFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

        clsAssignModelOperator.SetOperation("<-")
        clsAssignModelOperator.AddParameter("left", strModelTmpName, iPosition:=0)
        clsAssignModelOperator.AddParameter("right", clsRFunctionParameter:=clsGetModelFunction, iPosition:=1)
        clsAssignModelOperator.bToScriptAsRString = False

        clsResplotFunction.SetPackageName("biometryassist")
        clsResplotFunction.SetRCommand("resplot")
        clsResplotFunction.AddParameter("model.obj", strModelTmpName, iPosition:=0)
        clsResplotFunction.AddParameter("shapiro", "FALSE", iPosition:=1)
        clsResplotFunction.AddParameter("call", "FALSE", iPosition:=2)
        clsResplotFunction.AddParameter("onepage", "FALSE", iPosition:=6)

        clsRmFunction.SetRCommand("rm")
        clsRmFunction.bToScriptAsRString = False

        clsResplotFunction.SetAssignTo(strLastGraphName, strTempDataframe:=ucrSelectorResiduals.ucrAvailableDataFrames.cboAvailableDataFrames.Text, strTempGraph:=strLastGraphName)
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.SetBaseRFunction(clsResplotFunction)
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAssignModelOperator)

        TestOkEnabled()
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrChkShapiro.SetRCode(clsResplotFunction, bReset)
        ucrChkModel.SetRCode(clsResplotFunction, bReset)
        ucrNudCallSize.SetRCode(clsResplotFunction, bReset)
        ucrNudLabelSize.SetRCode(clsResplotFunction, bReset)
        ucrNudAxesSize.SetRCode(clsResplotFunction, bReset)
        ucrChkOnePage.SetRCode(clsResplotFunction, bReset)
        ucrNudOnePageCols.SetRCode(clsResplotFunction, bReset)
        ucrSaveResiduals.SetRCode(clsResplotFunction, bReset)

        If bReset Then
            ucrChkLabel.SetRCode(clsResplotFunction, bReset)
            ucrChkAxes.SetRCode(clsResplotFunction, bReset)
        End If

        AddCleanupCode()
    End Sub



    ' Cleans up the temporary model object once the plot has been produced.
    Private Sub AddCleanupCode()
        ucrBase.clsRsyntax.RemoveFromAfterCodes(clsRmFunction)
        clsRmFunction.ClearParameters()
        clsRmFunction.AddParameter("list", "c(" & Chr(34) & strModelTmpName & Chr(34) & ")", bIncludeArgumentName:=True, iPosition:=0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsRmFunction)
    End Sub

    Private Sub TestOkEnabled()
        Dim bOKEnabled As Boolean = Not ucrReceiverModel.IsEmpty() AndAlso
                                    (Not ucrSaveResiduals.ucrChkSave.Checked OrElse ucrSaveResiduals.IsComplete())

        ucrBase.OKEnabled(bOKEnabled)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverModel_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverModel.SelectionChanged
        If Not ucrReceiverModel.IsEmpty() Then
            clsGetModelFunction.AddParameter("object_name", ucrReceiverModel.GetVariableNames())
        Else
            clsGetModelFunction.RemoveParameterByName("object_name")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorResiduals_DataFrameChanged() Handles ucrSelectorResiduals.DataFrameChanged
        If Not String.IsNullOrEmpty(ucrSelectorResiduals.strCurrentDataFrame) Then
            clsGetModelFunction.AddParameter("data_name", Chr(34) & ucrSelectorResiduals.strCurrentDataFrame & Chr(34))
        Else
            clsGetModelFunction.RemoveParameterByName("data_name")
        End If
        TestOkEnabled()
    End Sub

    Private Sub ucrChkModel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkModel.ControlValueChanged
        If ucrChkModel.Checked Then
            clsResplotFunction.AddParameter("call.size", ucrNudCallSize.GetText(), iPosition:=5)
        Else
            clsResplotFunction.RemoveParameterByName("call.size")
        End If
    End Sub

    Private Sub ucrChkLabel_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabel.ControlValueChanged
        If ucrChkLabel.Checked Then
            clsResplotFunction.AddParameter("label.size", ucrNudLabelSize.GetText(), iPosition:=3)
        Else
            clsResplotFunction.RemoveParameterByName("label.size")
        End If
    End Sub

    Private Sub ucrChkAxes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkAxes.ControlValueChanged
        If ucrChkAxes.Checked Then
            clsResplotFunction.AddParameter("axes.size", ucrNudAxesSize.GetText(), iPosition:=4)
        Else
            clsResplotFunction.RemoveParameterByName("axes.size")
        End If
    End Sub

    Private Sub ucrChkOnePage_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkOnePage.ControlValueChanged
        If ucrChkOnePage.Checked Then
            clsResplotFunction.AddParameter("onepage_cols", ucrNudOnePageCols.GetText(), iPosition:=7)
        Else
            clsResplotFunction.RemoveParameterByName("onepage_cols")
        End If
    End Sub

    Private Sub ucrSaveResiduals_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveResiduals.ControlValueChanged
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles _
        ucrReceiverModel.ControlContentsChanged,
        ucrChkShapiro.ControlContentsChanged,
        ucrChkModel.ControlContentsChanged,
        ucrNudCallSize.ControlContentsChanged,
        ucrChkLabel.ControlContentsChanged,
        ucrNudLabelSize.ControlContentsChanged,
        ucrChkAxes.ControlContentsChanged,
        ucrNudAxesSize.ControlContentsChanged,
        ucrChkOnePage.ControlContentsChanged,
        ucrNudOnePageCols.ControlContentsChanged,
        ucrSaveResiduals.ControlContentsChanged

        TestOkEnabled()
    End Sub
End Class