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

Public Class dlgClimograph
    Private bFirstload As Boolean = True
    Private bReset As Boolean = True
    Private clsGgwalterliethFunction, clsDummyFunction As RFunction
    Private clsBaseOperator As New ROperator
    Private ReadOnly strFacetWrap As String = "Facet Wrap"
    Private ReadOnly strFacetRow As String = "Facet Row"
    Private ReadOnly strFacetCol As String = "Facet Column"
    Private ReadOnly strNone As String = "None"
    Private clsFacetFunction As New RFunction
    Private clsGroupByFunction As New RFunction
    Private clsFacetOperator As New ROperator
    Private clsFacetRowOp As New ROperator
    Private clsFacetColOp As New ROperator
    Private clsPipeOperator As New ROperator
    Private bUpdateComboOptions As Boolean = True
    Private bUpdatingParameters As Boolean = False

    Private Sub dlgClimograph_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            InitialiseDialog()
            bFirstload = False
        End If
        If bReset Then
            SetDefaults()
        End If
        SetRCodeForControls(bReset)
        bReset = False
        TestOKEnabled()
        autoTranslate(Me)
    End Sub

    Private Sub InitialiseDialog()
        ucrBase.iHelpTopicID = 432

        ucrSelectorClimograph.SetParameter(New RParameter("data", 0))
        ucrSelectorClimograph.SetParameterIsrfunction()

        ucrPnlClimograph.AddRadioButton(rdoClimograph)
        ucrPnlClimograph.AddRadioButton(rdoWalterLieth)
        ucrPnlClimograph.AddParameterValuesCondition(rdoWalterLieth, "checked", "WalterLieth")
        ucrPnlClimograph.AddParameterValuesCondition(rdoClimograph, "checked", "Climograph")

        ucrReceiverMonth.SetParameter(New RParameter("month", 1))
        ucrReceiverMonth.SetParameterIsString()
        ucrReceiverMonth.Selector = ucrSelectorClimograph
        ucrReceiverMonth.SetClimaticType("month")
        ucrReceiverMonth.bAutoFill = True
        ucrReceiverMonth.strSelectorHeading = "Month Variables"
        ucrReceiverMonth.SetLinkedDisplayControl(lblMonth)

        ucrReceiverRain.SetParameter(New RParameter("p_mes", 3))
        ucrReceiverRain.SetParameterIsString()
        ucrReceiverRain.Selector = ucrSelectorClimograph
        ucrReceiverRain.SetClimaticType("rain")
        ucrReceiverRain.bAutoFill = True
        ucrReceiverRain.strSelectorHeading = "Rain Variables"
        ucrReceiverRain.SetLinkedDisplayControl(lblRain)

        ucrReceiverMaxtem.SetParameter(New RParameter("tm_max", 4))
        ucrReceiverMaxtem.SetParameterIsString()
        ucrReceiverMaxtem.Selector = ucrSelectorClimograph
        ucrReceiverMaxtem.SetClimaticType("temp_max")
        ucrReceiverMaxtem.bAutoFill = True
        ucrReceiverMaxtem.strSelectorHeading = "Variables"
        ucrReceiverMaxtem.SetLinkedDisplayControl(lblMaxtem)

        ucrReceiverMintemp.SetParameter(New RParameter("tm_min", 5))
        ucrReceiverMintemp.SetParameterIsString()
        ucrReceiverMintemp.Selector = ucrSelectorClimograph
        ucrReceiverMintemp.SetClimaticType("temp_min")
        ucrReceiverMintemp.bAutoFill = True
        ucrReceiverMintemp.strSelectorHeading = "Variables"
        ucrReceiverMintemp.SetLinkedDisplayControl(lblMintem)

        ucr1stFactorReceiver.SetParameter(New RParameter("station"))
        ucr1stFactorReceiver.Selector = ucrSelectorClimograph
        ucr1stFactorReceiver.SetIncludedDataTypes({"factor"})
        ucr1stFactorReceiver.strSelectorHeading = "Factors"
        ucr1stFactorReceiver.bWithQuotes = False
        ucr1stFactorReceiver.SetParameterIsString()
        ucr1stFactorReceiver.SetValuesToIgnore({"."})

        ucrInputStation.SetItems({strFacetWrap, strFacetRow, strFacetCol, strNone})
        ucrInputStation.SetDropDownStyleAsNonEditable()

        ucrReceiverAbsolute.SetParameter(New RParameter("ta_min", 6))
        ucrReceiverAbsolute.SetParameterIsString()
        ucrReceiverAbsolute.Selector = ucrSelectorClimograph
        ucrReceiverAbsolute.strSelectorHeading = "Variables"
        ucrReceiverAbsolute.SetLinkedDisplayControl(lblAbsolute)

        ucrSave.SetPrefix("wl_graph")
        ucrSave.SetIsComboBox()
        ucrSave.SetSaveTypeAsGraph()
        ucrSave.SetCheckBoxText("Save")
        ucrSave.SetDataFrameSelector(ucrSelectorClimograph.ucrAvailableDataFrames)
        ucrSave.SetAssignToIfUncheckedValue("last_graph")
    End Sub

    Private Sub SetDefaults()
        clsGgwalterliethFunction = New RFunction
        clsBaseOperator = New ROperator
        clsDummyFunction = New RFunction
        clsGroupByFunction = New RFunction
        clsPipeOperator = New ROperator

        clsFacetFunction = New RFunction
        clsFacetOperator = New ROperator
        clsFacetRowOp = New ROperator
        clsFacetColOp = New ROperator

        ucrSelectorClimograph.Reset()
        ucrSave.Reset()

        ucrInputStation.SetName(strFacetWrap)
        ucrInputStation.bUpdateRCodeFromControl = True

        ucrReceiverMonth.SetMeAsReceiver()

        clsDummyFunction.AddParameter("checked", "WalterLieth", iPosition:=0)

        clsPipeOperator.SetOperation("%>%")
        SetPipeAssignTo()

        clsGgwalterliethFunction.SetRCommand("ggwalter_lieth")

        clsFacetFunction.SetPackageName("ggplot2")
        clsFacetRowOp.SetOperation("+")
        clsFacetRowOp.bBrackets = False
        clsFacetColOp.SetOperation("+")
        clsFacetColOp.bBrackets = False
        clsFacetOperator.SetOperation("~")
        clsFacetOperator.bForceIncludeOperation = True
        clsFacetOperator.bBrackets = False
        clsFacetFunction.AddParameter("facets", clsROperatorParameter:=clsFacetOperator, iPosition:=0)

        clsGroupByFunction.SetPackageName("dplyr")
        clsGroupByFunction.SetRCommand("group_by")

        clsBaseOperator.SetOperation("+")
        clsBaseOperator.AddParameter("ggwalter_lieth", clsRFunctionParameter:=clsGgwalterliethFunction, iPosition:=0)

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset)
        ucrSelectorClimograph.SetRCode(clsGgwalterliethFunction, bReset)
        ucrPnlClimograph.SetRCode(clsDummyFunction, bReset)
        ucrReceiverMonth.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverRain.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMintemp.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverMaxtem.SetRCode(clsGgwalterliethFunction, bReset)
        ucrReceiverAbsolute.SetRCode(clsGgwalterliethFunction, bReset)
        ucrSave.SetRCode(clsBaseOperator, bReset)
        If bReset Then
            AutoFacetStation()
        End If
    End Sub

    Private Sub TestOKEnabled()
        If rdoWalterLieth.Checked AndAlso ((Not ucrReceiverAbsolute.IsEmpty AndAlso Not ucrReceiverMaxtem.IsEmpty AndAlso Not ucrReceiverMintemp.IsEmpty AndAlso Not ucrReceiverMonth.IsEmpty AndAlso Not ucrReceiverRain.IsEmpty) OrElse Not ucrSave.IsComplete) Then
            ucrBase.OKEnabled(True)
        Else
            ucrBase.OKEnabled(False)
        End If
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        UpdateParameters()
        TestOKEnabled()
    End Sub

    Private Sub ucrInput_ControlValueChanged(ucrChangedControl As ucrInputComboBox) Handles ucrInputStation.ControlValueChanged
        If Not bUpdateComboOptions Then
            Exit Sub
        End If
        Dim strChangedText As String = ucrChangedControl.GetText()
        If strChangedText <> strNone Then
            If Not strChangedText = strFacetCol AndAlso Not strChangedText = strFacetRow AndAlso
                    Not ucrInputStation.Equals(ucrChangedControl) AndAlso ucrInputStation.GetText() = strChangedText Then
                bUpdateComboOptions = False
                ucrInputStation.SetName(strNone)
                bUpdateComboOptions = True
            End If
            If (strChangedText = strFacetWrap AndAlso ucrInputStation.GetText = strFacetRow) OrElse (strChangedText = strFacetRow AndAlso
                    ucrInputStation.GetText = strFacetWrap) OrElse (strChangedText = strFacetWrap AndAlso
                    ucrInputStation.GetText = strFacetCol) OrElse (strChangedText = strFacetCol AndAlso ucrInputStation.GetText = strFacetWrap) Then
                ucrInputStation.SetName(strNone)
            End If
        End If
        UpdateParameters()
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub UpdateParameters()
        clsFacetOperator.RemoveParameterByName("wrap" & ucrInputStation.Name)
        clsFacetColOp.RemoveParameterByName("col" & ucrInputStation.Name)
        clsFacetRowOp.RemoveParameterByName("row" & ucrInputStation.Name)

        clsBaseOperator.RemoveParameterByName("facets")
        bUpdatingParameters = True
        ucr1stFactorReceiver.SetRCode(Nothing)
        Select Case ucrInputStation.GetText()
            Case strFacetWrap
                ucr1stFactorReceiver.ChangeParameterName("wrap" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetOperator)
            Case strFacetCol
                ucr1stFactorReceiver.ChangeParameterName("col" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetColOp)
            Case strFacetRow
                ucr1stFactorReceiver.ChangeParameterName("row" & ucrInputStation.Name)
                ucr1stFactorReceiver.SetRCode(clsFacetRowOp)
        End Select
        bUpdatingParameters = False
    End Sub

    Private Sub AddRemoveFacets()
        Dim bWrap As Boolean = False
        Dim bCol As Boolean = False
        Dim bRow As Boolean = False

        If bUpdatingParameters Then
            Exit Sub
        End If

        clsBaseOperator.RemoveParameterByName("facets")
        If Not ucr1stFactorReceiver.IsEmpty Then
            Select Case ucrInputStation.GetText()
                Case strFacetWrap
                    bWrap = True
                Case strFacetCol
                    bCol = True
                Case strFacetRow
                    bRow = True
            End Select
        End If

        If bWrap OrElse bRow OrElse bCol Then
            clsBaseOperator.AddParameter("facets", clsRFunctionParameter:=clsFacetFunction)
        End If
        If bWrap Then
            clsFacetFunction.SetRCommand("facet_wrap")
        End If
        If bRow OrElse bCol Then
            clsFacetFunction.SetRCommand("facet_grid")
        End If
        If bRow Then
            clsFacetOperator.AddParameter("left", clsROperatorParameter:=clsFacetRowOp, iPosition:=0)
        ElseIf bCol AndAlso Not bWrap Then
            clsFacetOperator.AddParameter("left", ".", iPosition:=0)
        Else
            clsFacetOperator.RemoveParameterByName("left")
        End If
        If bCol Then
            clsFacetOperator.AddParameter("right", clsROperatorParameter:=clsFacetColOp, iPosition:=1)
        ElseIf bRow AndAlso Not bWrap Then
            clsFacetOperator.AddParameter("right", ".", iPosition:=1)
        Else
            clsFacetOperator.RemoveParameterByName("right")
        End If
    End Sub

    Private Sub ucr1stFactorReceiver_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucr1stFactorReceiver.ControlValueChanged
        If Not ucr1stFactorReceiver.IsEmpty Then
            clsGgwalterliethFunction.AddParameter("station", ucr1stFactorReceiver.GetVariableNames(), iPosition:=1)
        Else
            clsGgwalterliethFunction.RemoveParameterByName("station")
        End If
        AddRemoveFacets()
        AddRemoveGroupBy()
    End Sub

    Private Sub AutoFacetStation()
        Dim ucrCurrentReceiver As ucrReceiver = ucrSelectorClimograph.CurrentReceiver

        If ucrCurrentReceiver IsNot Nothing Then
            ucr1stFactorReceiver.AddItemsWithMetadataProperty(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text, "Climatic_Type", {"station_label"})
            ucrCurrentReceiver.SetMeAsReceiver()
            AddRemoveGroupBy()
        End If
    End Sub

    Private Sub ucrSelectorClimograph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSelectorClimograph.ControlValueChanged
        AutoFacetStation()
        SetPipeAssignTo()
    End Sub

    Private Sub GetParameterValue(clsOperator As ROperator)
        Dim i As Integer = 0
        For Each clsTempParam As RParameter In clsOperator.clsParameters
            If clsTempParam.strArgumentValue <> "" AndAlso clsTempParam.strArgumentValue <> "." Then
                clsGroupByFunction.AddParameter(i, clsTempParam.strArgumentValue, bIncludeArgumentName:=False, iPosition:=i)
                i = i + 1
            End If
        Next
    End Sub

    Private Sub AddRemoveGroupBy()

        If clsPipeOperator.ContainsParameter("mutate") Then
            clsGroupByFunction.ClearParameters()
            If clsBaseOperator.ContainsParameter("facets") Then
                Select Case ucrInputStation.GetText()
                    Case strFacetWrap
                        GetParameterValue(clsFacetOperator)
                    Case strFacetCol
                        GetParameterValue(clsFacetColOp)
                    Case strFacetRow
                        GetParameterValue(clsFacetRowOp)
                End Select
            End If

            If clsGroupByFunction.iParameterCount > 0 Then
                clsPipeOperator.AddParameter("group_by", clsRFunctionParameter:=clsGroupByFunction, iPosition:=1)
            Else
                clsPipeOperator.RemoveParameterByName("group_by")
            End If
        Else
            clsPipeOperator.RemoveParameterByName("group_by")
        End If

        SetPipeAssignTo()
    End Sub

    Private Sub SetPipeAssignTo()
        If ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text <> "" AndAlso clsPipeOperator.clsParameters.Count > 1 Then
            clsPipeOperator.SetAssignTo(ucrSelectorClimograph.ucrAvailableDataFrames.cboAvailableDataFrames.Text)
        Else
            clsPipeOperator.RemoveAssignTo()
        End If
    End Sub

    Private Sub AllControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrPnlClimograph.ControlContentsChanged, ucrReceiverRain.ControlContentsChanged, ucrReceiverAbsolute.ControlContentsChanged, ucrReceiverMonth.ControlContentsChanged, ucrReceiverMaxtem.ControlContentsChanged, ucrReceiverMintemp.ControlContentsChanged, ucrSave.ControlContentsChanged
        TestOKEnabled()
    End Sub
End Class