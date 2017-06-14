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

Public Class ucrAxes
    Public bIsX As Boolean
    Public clsXYlabTitleFunction As New RFunction
    Public clsXYScaleContinuousFunction As New RFunction
    Public clsLimitsFunction As New RFunction
    Public clsBaseOperator As New ROperator
    Public clsMajorBreaksSeqFunction As New RFunction
    Public clsMinorBreaksSeqFunction As New RFunction
    Public strAxis As String
    'e.g. discrete, continuous
    Public strAxisType As String
    Public bFirstLoad As Boolean = True
    Private bControlsInitialised As Boolean = False
    Private bRCodeSet As Boolean = False

    Public Sub InitialiseControl()
        Dim dctTickMarkers As New Dictionary(Of String, String)

        'Axis Section
        ucrPnlAxisTitle.AddRadioButton(rdoTitleAuto)
        ucrPnlAxisTitle.AddRadioButton(rdoNoTitle)
        ucrPnlAxisTitle.AddRadioButton(rdoSpecifyTitle)
        ucrPnlAxisTitle.AddParameterPresentCondition(rdoTitleAuto, "label", False)
        ucrPnlAxisTitle.AddParameterPresentCondition(rdoNoTitle, "label", True)
        ucrPnlAxisTitle.AddParameterValuesCondition(rdoNoTitle, "label", Chr(34) & Chr(34), True)
        ucrPnlAxisTitle.AddParameterPresentCondition(rdoSpecifyTitle, "label", True)
        ucrPnlAxisTitle.AddParameterValuesCondition(rdoSpecifyTitle, "label", Chr(34) & Chr(34), False)
        ucrPnlAxisTitle.AddToLinkedControls(ucrInputTitle, {rdoSpecifyTitle}, bNewLinkedHideIfParameterMissing:=True)

        ucrInputTitle.SetParameter(New RParameter("label"))
        ucrInputTitle.SetLinkedDisplayControl(lblTitle)

        'Tick Markers section
        ucrPnlMajorBreaks.AddRadioButton(rdoMajorBreaksAuto)
        ucrPnlMajorBreaks.AddRadioButton(rdoMajorBreaksNone)
        ucrPnlMajorBreaks.AddRadioButton(rdoMajorBreaksCustom)
        ucrPnlMajorBreaks.AddRadioButton(rdoMajorBreaksSeq)

        ucrPnlMajorBreaks.AddParameterPresentCondition(rdoMajorBreaksAuto, "breaks", bNewIsPositive:=False)
        ucrPnlMajorBreaks.AddParameterValuesCondition(rdoMajorBreaksNone, "breaks", "NULL")
        ucrPnlMajorBreaks.AddParameterValueFunctionNamesCondition(rdoMajorBreaksSeq, "breaks", "seq")
        ucrPnlMajorBreaks.AddParameterPresentCondition(rdoMajorBreaksCustom, "breaks")
        ucrPnlMajorBreaks.AddParameterValuesCondition(rdoMajorBreaksCustom, "breaks", "NULL", bNewIsPositive:=False)
        ucrPnlMajorBreaks.AddParameterIsStringCondition(rdoMajorBreaksCustom, "breaks")

        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksFrom, {rdoMajorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksTo, {rdoMajorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksInStepsOf, {rdoMajorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksInStepsOf, {rdoMajorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrInputMajorBreaksCustom, {rdoMajorBreaksCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMajorBreaks.AddToLinkedControls(ucrChkLabels, {rdoMajorBreaksSeq, rdoMajorBreaksCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=False)

        ucrChkLabels.SetText("Labels")
        ucrChkLabels.AddParameterPresentCondition(True, "labels")
        ucrChkLabels.AddParameterPresentCondition(False, "labels", False)
        ucrChkLabels.AddToLinkedControls(ucrInputMajorBreaksLabels, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")
        ucrInputMajorBreaksLabels.SetValidationTypeAsList()

        'ucrInputMajorBreaksCustom.SetParameter(New RParameter("breaks"))
        ucrInputMajorBreaksCustom.AddQuotesIfUnrecognised = False
        ucrInputMajorBreaksCustom.SetValidationTypeAsNumericList()

        ucrPnlMinorBreaks.AddRadioButton(rdoMinorBreaksAuto)
        ucrPnlMinorBreaks.AddRadioButton(rdoMinorBreaksCustom)
        ucrPnlMinorBreaks.AddRadioButton(rdoMinorBreaksSeq)
        ucrPnlMinorBreaks.AddRadioButton(rdoMinorBreaksNone)

        ucrPnlMinorBreaks.AddParameterPresentCondition(rdoMinorBreaksAuto, "minor_breaks", bNewIsPositive:=False)
        ucrPnlMinorBreaks.AddParameterValuesCondition(rdoMinorBreaksNone, "minor_breaks", "NULL")
        ucrPnlMinorBreaks.AddParameterValueFunctionNamesCondition(rdoMinorBreaksSeq, "minor_breaks", "seq")
        ucrPnlMinorBreaks.AddParameterPresentCondition(rdoMinorBreaksCustom, "minor_breaks")
        ucrPnlMinorBreaks.AddParameterIsRFunctionCondition(rdoMinorBreaksCustom, "minor_breaks")
        ucrPnlMinorBreaks.AddParameterValueFunctionNamesCondition(rdoMinorBreaksCustom, "minor_breaks", "seq", bNewIsPositive:=False)

        ucrPnlMinorBreaks.AddToLinkedControls(ucrInputMinorBreaksFrom, {rdoMinorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMinorBreaks.AddToLinkedControls(ucrInputMinorBreaksTo, {rdoMinorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMinorBreaks.AddToLinkedControls(ucrInputMinorBreaksInStepsOf, {rdoMinorBreaksSeq}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlMinorBreaks.AddToLinkedControls(ucrInputMinorBreaksCustom, {rdoMinorBreaksCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        'These add parameters to clsMajorBreaksSeqFunction
        ucrInputMajorBreaksInStepsOf.SetParameter(New RParameter("by"))
        ucrInputMajorBreaksInStepsOf.SetValidationTypeAsNumeric()
        ucrInputMajorBreaksInStepsOf.AddQuotesIfUnrecognised = False
        ucrInputMajorBreaksInStepsOf.SetLinkedDisplayControl(lblMajorBreaksInStepsOf)
        ucrInputMajorBreaksInStepsOf.SetLinkedDisplayControl(lblMajorBreaksInStepsOf)

        ucrInputMajorBreaksTo.SetParameter(New RParameter("to"))
        ucrInputMajorBreaksTo.SetValidationTypeAsNumeric()
        ucrInputMajorBreaksTo.AddQuotesIfUnrecognised = False
        ucrInputMajorBreaksTo.SetLinkedDisplayControl(lblMajorBreaksTo)

        ucrInputMajorBreaksFrom.SetParameter(New RParameter("from"))
        ucrInputMajorBreaksFrom.SetValidationTypeAsNumeric()
        ucrInputMajorBreaksFrom.AddQuotesIfUnrecognised = False
        ucrInputMajorBreaksFrom.SetLinkedDisplayControl(lblMajorBreaksFrom)

        'These add parameters to clsMinorBreaksSeqFunction
        ucrInputMinorBreaksInStepsOf.SetParameter(New RParameter("by"))
        ucrInputMinorBreaksInStepsOf.SetValidationTypeAsNumeric()
        ucrInputMinorBreaksInStepsOf.AddQuotesIfUnrecognised = False
        ucrInputMinorBreaksInStepsOf.SetLinkedDisplayControl(lblMinorBreaksInStepsOf)

        ucrInputMinorBreaksTo.SetParameter(New RParameter("to"))
        ucrInputMinorBreaksTo.SetValidationTypeAsNumeric()
        ucrInputMinorBreaksTo.AddQuotesIfUnrecognised = False
        ucrInputMinorBreaksTo.SetLinkedDisplayControl(lblMinorBreaksTo)

        ucrInputMinorBreaksFrom.SetParameter(New RParameter("from"))
        ucrInputMinorBreaksFrom.SetValidationTypeAsNumeric()
        ucrInputMinorBreaksFrom.AddQuotesIfUnrecognised = False
        ucrInputMinorBreaksFrom.SetLinkedDisplayControl(lblMinorBreaksFrom)

        'Scales section
        ucrPnlScales.AddRadioButton(rdoScalesAuto)
        ucrPnlScales.AddRadioButton(rdoScalesCustom)
        ucrPnlScales.AddParameterPresentCondition(rdoScalesAuto, "limits", False)
        ucrPnlScales.AddParameterPresentCondition(rdoScalesCustom, "limits", True)
        ucrPnlScales.AddToLinkedControls(ucrInputLowerLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlScales.AddToLinkedControls(ucrInputUpperLimit, {rdoScalesCustom}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrInputLowerLimit.SetParameter(New RParameter("lowerlimit", 0))
        ucrInputLowerLimit.SetParameterIncludeArgumentName(False)
        ucrInputLowerLimit.SetValidationTypeAsNumeric()
        ucrInputLowerLimit.AddQuotesIfUnrecognised = False
        ucrInputLowerLimit.SetLinkedDisplayControl(lblLowerLimit)

        ucrInputUpperLimit.SetParameter(New RParameter("upperlimit", 1))
        ucrInputUpperLimit.SetParameterIncludeArgumentName(False)
        ucrInputUpperLimit.SetValidationTypeAsNumeric()
        ucrInputUpperLimit.AddQuotesIfUnrecognised = False
        ucrInputUpperLimit.SetLinkedDisplayControl(lblUpperLimit)

        'Axis type - controls which options are available
        ucrInputAxisType.SetItems({"Continuous", "Discrete", "Date"})
        ucrInputAxisType.SetDropDownStyleAsNonEditable()

        ucrInputRelaceMissingvalues.SetParameter(New RParameter("na.value"))
        ucrInputRelaceMissingvalues.SetValidationTypeAsNumeric()
        ucrInputRelaceMissingvalues.bAddRemoveParameter = False
        ucrInputRelaceMissingvalues.AddQuotesIfUnrecognised = False

        ucrChkNaValue.SetText("Replace Missing Values")
        ucrChkNaValue.AddParameterPresentCondition(True, "na.value")
        ucrChkNaValue.AddParameterPresentCondition(False, "na.value", False)
        ucrChkNaValue.AddToLinkedControls(ucrInputRelaceMissingvalues, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="")

        ucrChkTransformation.SetText("Transformation")
        ucrInputTransformation.SetParameter(New RParameter("trans"))
        ucrChkTransformation.AddParameterPresentCondition(True, "trans")
        ucrChkTransformation.AddParameterPresentCondition(False, "trans", False)
        ucrChkTransformation.AddToLinkedControls(ucrInputTransformation, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="asn")
        ucrInputTransformation.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctTransformations))
        ucrInputTransformation.SetDropDownStyleAsNonEditable()

        ucrChkPosition.SetText("Position")
        ucrInputPosition.SetParameter(New RParameter("position"))
        ucrInputPosition.SetDropDownStyleAsNonEditable()
        ucrChkPosition.AddParameterPresentCondition(True, "position")
        ucrChkPosition.AddParameterPresentCondition(False, "position", False)
        ucrChkPosition.AddToLinkedControls(ucrInputPosition, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=Nothing)

        ucrChkExpand.SetText("Expand")
        ucrChkExpand.AddParameterPresentCondition(True, "expand")
        ucrChkExpand.AddParameterPresentCondition(False, "expand", False)
        ucrChkExpand.AddToLinkedControls(ucrInputExpand, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05,0")
        ucrInputExpand.SetValidationTypeAsNumericList()

        bControlsInitialised = True
    End Sub

    Public Sub SetRCodeForControl(bIsXAxis As Boolean, Optional strNewAxisType As String = "Continuous", Optional clsNewXYScaleContinuousFunction As RFunction = Nothing, Optional clsNewXYlabTitleFunction As RFunction = Nothing, Optional clsNewBaseOperator As ROperator = Nothing, Optional bReset As Boolean = False)
        Dim clsTempBreaksParam As RParameter
        Dim clsTempMinorBreaksParam As RParameter

        bRCodeSet = False
        If Not bControlsInitialised Then
            InitialiseControl()
        End If
        clsBaseOperator = clsNewBaseOperator
        bIsX = bIsXAxis
        strAxisType = strNewAxisType
        If bIsXAxis Then
            bIsX = True
            strAxis = "x"

        Else
            bIsX = False
            strAxis = "y"
        End If

        If bIsX Then
            ucrInputPosition.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctXPosition))
            ucrInputPosition.SetDefaultState("Bottom")
        ElseIf Not bIsX Then
            ucrInputPosition.SetItems(New Dictionary(Of String, String)(GgplotDefaults.dctYPosition))
            ucrInputPosition.SetDefaultState("Left")
        End If
        ucrInputAxisType.SetName(strAxisType)

        clsXYlabTitleFunction = clsNewXYlabTitleFunction
        clsXYScaleContinuousFunction = clsNewXYScaleContinuousFunction

        'TODO these could be passed through as a dictionary of scale functions instead of searched
        If clsXYScaleContinuousFunction.ContainsParameter("limits") AndAlso clsXYScaleContinuousFunction.GetParameter("limits").clsArgumentCodeStructure IsNot Nothing Then
            clsLimitsFunction = clsXYScaleContinuousFunction.GetParameter("limits").clsArgumentCodeStructure
        Else
            'TODO move to ggplot defaults
            clsLimitsFunction = New RFunction
            clsLimitsFunction.SetRCommand("c")
        End If

        If clsXYScaleContinuousFunction.ContainsParameter("breaks") Then
            clsTempBreaksParam = clsXYScaleContinuousFunction.GetParameter("breaks")
            If clsTempBreaksParam.clsArgumentCodeStructure IsNot Nothing Then
                clsMajorBreaksSeqFunction = clsTempBreaksParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsMajorBreaksSeqFunction = New RFunction
                clsMajorBreaksSeqFunction.SetRCommand("seq")
            End If
        Else
            clsMajorBreaksSeqFunction = New RFunction
            clsMajorBreaksSeqFunction.SetRCommand("seq")
        End If

        If clsXYScaleContinuousFunction.ContainsParameter("minor_breaks") Then
            clsTempMinorBreaksParam = clsXYScaleContinuousFunction.GetParameter("minor_breaks")
            If clsTempMinorBreaksParam.clsArgumentCodeStructure IsNot Nothing Then
                clsMinorBreaksSeqFunction = clsTempMinorBreaksParam.clsArgumentCodeStructure
            Else
                'TODO move to ggplot defaults
                clsMinorBreaksSeqFunction = New RFunction
                clsMinorBreaksSeqFunction.SetRCommand("seq")
            End If
        Else
            clsMinorBreaksSeqFunction = New RFunction
            clsMinorBreaksSeqFunction.SetRCommand("seq")
        End If

        ucrPnlAxisTitle.SetRCode(clsXYlabTitleFunction, bReset)
        ucrInputTitle.SetRCode(clsXYlabTitleFunction, bReset)

        'scales functions
        ucrPnlScales.SetRCode(clsXYScaleContinuousFunction, bReset)
        ucrInputLowerLimit.SetRCode(clsLimitsFunction, bReset)
        ucrInputUpperLimit.SetRCode(clsLimitsFunction, bReset)

        ucrInputPosition.SetRCode(clsXYScaleContinuousFunction, bReset)
        ucrChkPosition.SetRCode(clsXYScaleContinuousFunction, bReset)

        ucrChkNaValue.SetRCode(clsXYScaleContinuousFunction, bReset)
        ucrInputRelaceMissingvalues.SetRCode(clsXYScaleContinuousFunction, bReset)

        ucrChkTransformation.SetRCode(clsXYScaleContinuousFunction, bReset)
        ucrInputTransformation.SetRCode(clsXYScaleContinuousFunction, bReset)

        ucrChkExpand.SetRCode(clsXYScaleContinuousFunction, bReset)

        ucrPnlMajorBreaks.SetRCode(clsXYScaleContinuousFunction, bReset)
        ucrInputMajorBreaksCustom.SetRCode(clsXYScaleContinuousFunction, bReset)
        ucrInputMajorBreaksLabels.SetRCode(clsXYScaleContinuousFunction, bReset)

        'Temp disabled, not yet implemented
        ucrInputMajorBreaksInStepsOf.SetRCode(clsMajorBreaksSeqFunction, bReset)
        ucrInputMajorBreaksTo.SetRCode(clsMajorBreaksSeqFunction, bReset)
        ucrInputMajorBreaksFrom.SetRCode(clsMajorBreaksSeqFunction, bReset)

        ucrPnlMinorBreaks.SetRCode(clsXYScaleContinuousFunction, bReset)
        ucrInputMinorBreaksFrom.SetRCode(clsMinorBreaksSeqFunction, bReset)
        ucrInputMinorBreaksTo.SetRCode(clsMinorBreaksSeqFunction, bReset)
        ucrInputMinorBreaksInStepsOf.SetRCode(clsMinorBreaksSeqFunction, bReset)

        ucrChkLabels.SetRCode(clsXYScaleContinuousFunction, bReset)
        bRCodeSet = True
        SetLabel()
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub AddRemoveLabs()
        If bRCodeSet Then
            If rdoNoTitle.Checked OrElse (rdoSpecifyTitle.Checked AndAlso Not ucrInputTitle.IsEmpty) Then
                clsBaseOperator.AddParameter(strAxis & "lab", clsRFunctionParameter:=clsXYlabTitleFunction)
            Else
                clsBaseOperator.RemoveParameterByName(strAxis & "lab")
            End If
        End If
    End Sub

    Private Sub SetLabel()
        If bRCodeSet Then
            If rdoTitleAuto.Checked Then
                clsXYlabTitleFunction.RemoveParameterByName("label")
            ElseIf rdoNoTitle.Checked Then
                clsXYlabTitleFunction.AddParameter("label", Chr(34) & Chr(34))
            Else
                clsXYlabTitleFunction.AddParameter("label", Chr(34) & ucrInputTitle.GetText() & Chr(34))
            End If
            AddRemoveLabs()
        End If
    End Sub

    Private Sub ucrPnlAxisTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlAxisTitle.ControlValueChanged, ucrInputTitle.ControlValueChanged
        SetLabel()
    End Sub

    Private Sub AddRemoveContinuousXYScales()
        If clsXYScaleContinuousFunction.clsParameters.Count > 0 Then
            clsBaseOperator.AddParameter("scale" & "_" & strAxis & "_" & strAxisType, clsRFunctionParameter:=clsXYScaleContinuousFunction)
        Else
            clsBaseOperator.RemoveParameterByName("scale" & "_" & strAxis & "_" & strAxisType)
        End If
    End Sub

    Private Sub ucrInputAxisType_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputAxisType.ControlValueChanged
        SetAxisTypeControls()
    End Sub

    Private Sub SetAxisTypeControls()
        strAxisType = ucrInputAxisType.GetText()
        'hide all axis type lanels
        grpMajorBreaks.Hide()
        grpMinorBreaks.Hide()
        grpScales.Hide()
        If strAxisType = "Continuous" Then
            'show continous panels
            'TODO put controls in panels so group boxes can be used for multiple cases
            grpMajorBreaks.Show()
            grpMinorBreaks.Show()
            grpScales.Show()
        ElseIf strAxisType = "Discrete" Then
            'show discrete panels
        ElseIf strAxisType = "Date" Then
            'show date panels
        End If
    End Sub

    Private Sub BreaksControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMajorBreaks.ControlValueChanged, ucrInputMajorBreaksCustom.ControlValueChanged
        If rdoMajorBreaksAuto.Checked Then
            clsXYScaleContinuousFunction.RemoveParameterByName("breaks")
        ElseIf rdoMajorBreaksNone.Checked Then
            clsXYScaleContinuousFunction.AddParameter("breaks", "NULL")
        ElseIf rdoMajorBreaksSeq.Checked Then
            clsXYScaleContinuousFunction.AddParameter("breaks", clsRFunctionParameter:=clsMajorBreaksSeqFunction)
        ElseIf rdoMajorBreaksCustom.Checked Then
            clsXYScaleContinuousFunction.AddParameter("breaks", "c(" & ucrInputMajorBreaksCustom.GetText() & ")")
        End If
        SetLabelsParameter()
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub ucrPnlMinorBreaks_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlMinorBreaks.ControlValueChanged
        If rdoMinorBreaksAuto.Checked Then
            clsXYScaleContinuousFunction.RemoveParameterByName("minor_breaks")
        ElseIf rdoMinorBreaksNone.Checked Then
            clsXYScaleContinuousFunction.AddParameter("minor_breaks", "NULL")
        ElseIf rdoMinorBreaksSeq.Checked Then
            clsXYScaleContinuousFunction.AddParameter("minor_breaks", clsRFunctionParameter:=clsMinorBreaksSeqFunction)
        ElseIf rdoMinorBreaksCustom.Checked Then
            clsXYScaleContinuousFunction.AddParameter("minor_breaks", "c(" & ucrInputMinorBreaksCustom.GetText() & ")")
        End If
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub ucrPnlScales_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlScales.ControlValueChanged, ucrInputLowerLimit.ControlValueChanged, ucrInputUpperLimit.ControlValueChanged
        If rdoScalesCustom.Checked AndAlso (Not ucrInputLowerLimit.IsEmpty AndAlso Not ucrInputUpperLimit.IsEmpty) Then
            clsXYScaleContinuousFunction.AddParameter("limits", clsRFunctionParameter:=clsLimitsFunction)
        Else
            clsXYScaleContinuousFunction.RemoveParameterByName("limits")
        End If
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub ExpandControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExpand.ControlValueChanged, ucrInputExpand.ControlValueChanged
        If ucrChkExpand.Checked AndAlso Not ucrInputExpand.IsEmpty Then
            clsXYScaleContinuousFunction.AddParameter("expand", clsRFunctionParameter:=ucrInputExpand.clsRList)
        Else
            clsXYScaleContinuousFunction.RemoveParameterByName("expand")
        End If
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub ScalesCheckboxes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkExpand.ControlValueChanged, ucrChkPosition.ControlValueChanged, ucrChkTransformation.ControlValueChanged, ucrChkExpand.ControlValueChanged, ucrChkNaValue.ControlValueChanged
        AddRemoveContinuousXYScales()
    End Sub

    Private Sub LabelsControls_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkLabels.ControlValueChanged, ucrInputMajorBreaksLabels.ControlValueChanged
        SetLabelsParameter()
    End Sub

    Private Sub SetLabelsParameter()
        If (rdoMajorBreaksSeq.Checked OrElse rdoMajorBreaksCustom.Checked) AndAlso ucrChkLabels.Checked AndAlso Not ucrInputMajorBreaksLabels.IsEmpty() Then
            'TODO add functionality to input control to do this automatically for a list
            clsXYScaleContinuousFunction.AddParameter("labels", ucrInputMajorBreaksLabels.clsRList.ToScript())
        Else
            clsXYScaleContinuousFunction.RemoveParameterByName("labels")
        End If
        AddRemoveContinuousXYScales()
    End Sub
End Class