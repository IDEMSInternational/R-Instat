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
Imports RDotNet

Public Class dlgModelMultipleComparisons
    Private bFirstLoad As Boolean = True
    Private bReset As Boolean = True
    Private lstModelFactorNames As New List(Of String)

    Private ReadOnly strModelTmpName As String = "model_tmp"
    Private ReadOnly strLastMctName As String = "last_mct"
    Private ReadOnly strLastGraphName As String = "last_graph"
    Private ReadOnly strDefaultGraphType As String = "Point"

    Private clsMultipleComparisonsFunction As New RFunction
    Private clsGetModelFunction As New RFunction
    Private clsAssignModelOperator As New ROperator
    Private clsRmFunction As New RFunction
    Private clsAutoplotFunction As New RFunction

    Private clsCheckGraphFunction As New RFunction
    Private clsAddPlotObjectFunction As New RFunction
    Private clsGetPlotObjectDataFunction As New RFunction
    Private Sub dlgModelMultipleComparisons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

        ucrReceiverMultipleMeanComparisonUseModel.SetItemType(RObjectTypeLabel.Model)
        ucrReceiverMultipleMeanComparisonUseModel.Selector = ucrSelectorModelMultipleComparisons
        ucrReceiverMultipleMeanComparisonUseModel.SetMeAsReceiver()
        ucrReceiverMultipleMeanComparisonUseModel.strSelectorHeading = "Models"

        ucrReceiverLabelVariable.Selector = ucrSelectorModelMultipleComparisons
        ucrReceiverLabelVariable.SetParameter(New RParameter("classify", 1))
        ucrReceiverLabelVariable.SetParameterIsString()
        ucrReceiverLabelVariable.SetIncludedDataTypes({"factor"})

        ucrReceiverBy.Selector = ucrSelectorModelMultipleComparisons
        ucrReceiverBy.SetParameter(New RParameter("by", 2))
        ucrReceiverBy.SetParameterIsString()
        ucrReceiverBy.SetIncludedDataTypes({"factor"})

        ucrChkByOptional.SetText("By (Optional):")
        ucrChkByOptional.AddToLinkedControls({ucrReceiverBy}, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrChkAlpha.SetText("Alpha")
        ucrInputComboBoxAlpha.SetItems({"0.001", "0.01", "0.02", "0.05", "0.1"})
        ucrInputComboBoxAlpha.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxAlpha.AddQuotesIfUnrecognised = False
        ucrInputComboBoxAlpha.SetParameter(New RParameter("sig", 3))
        ucrChkAlpha.AddToLinkedControls(ucrInputComboBoxAlpha, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="0.05")

        ucrChkDescending.SetText("Descending")
        ucrInputComboBoxDescending.SetItems({"TRUE", "FALSE"})
        ucrInputComboBoxDescending.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxDescending.AddQuotesIfUnrecognised = False
        ucrInputComboBoxDescending.SetParameter(New RParameter("descending", 5))
        ucrChkDescending.AddToLinkedControls(ucrInputComboBoxDescending, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")

        ucrChkAdjustment.SetText("Adjustment")
        ucrInputComboBoxAdjustment.SetItems({"tukey", "bonferroni", "holm", "hochberg", "hommel", "BH", "BY", "none"})
        ucrInputComboBoxAdjustment.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxAdjustment.AddQuotesIfUnrecognised = True
        ucrInputComboBoxAdjustment.SetParameter(New RParameter("adjust", 6))
        ucrChkAdjustment.AddToLinkedControls(ucrInputComboBoxAdjustment, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="tukey")

        ucrChkConfidenceInterval.SetText("Confidence Interval")
        ucrInputComboBoxConfidenceInterval.SetItems({"ci", "tukey", "1se", "2se", "none"})
        ucrInputComboBoxConfidenceInterval.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxConfidenceInterval.AddQuotesIfUnrecognised = True
        ucrInputComboBoxConfidenceInterval.SetParameter(New RParameter("int.type", 4))
        ucrChkConfidenceInterval.AddToLinkedControls(ucrInputComboBoxConfidenceInterval, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="ci")

        ucrChkDisplayLetters.SetText("Display Letters")
        ucrInputComboBoxDisplayLetters.SetItems({"TRUE", "FALSE"})
        ucrInputComboBoxDisplayLetters.SetDropDownStyleAsNonEditable()
        ucrInputComboBoxDisplayLetters.AddQuotesIfUnrecognised = False
        ucrInputComboBoxDisplayLetters.SetParameter(New RParameter("groups", 7))
        ucrChkDisplayLetters.AddToLinkedControls(ucrInputComboBoxDisplayLetters, {True}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:="TRUE")

        ucrSaveModelMultipleComparisons.SetPrefix("mct")
        ucrSaveModelMultipleComparisons.SetCheckBoxText("Store mct:")
        ucrSaveModelMultipleComparisons.SetIsComboBox()
        ucrSaveModelMultipleComparisons.SetSaveType(strRObjectType:=RObjectTypeLabel.Summary, strRObjectFormat:=RObjectFormat.Text)

        ucrChkGenerateMultipleComparisonPlot.SetText("Generate Plot")
        ucrInputGenerateMultipleComparisonGraphs.SetItems({strDefaultGraphType, "Line", "Bar"})
        ucrInputGenerateMultipleComparisonGraphs.SetDropDownStyleAsNonEditable()
        ucrInputGenerateMultipleComparisonGraphs.AddQuotesIfUnrecognised = True
        ucrInputGenerateMultipleComparisonGraphs.SetParameter(New RParameter("type", 1))
        ucrInputGenerateMultipleComparisonGraphs.SetRDefault(Chr(34) & strDefaultGraphType.ToLower() & Chr(34))
        ucrChkGenerateMultipleComparisonPlot.AddToLinkedControls(ucrInputGenerateMultipleComparisonGraphs, {True}, bNewLinkedHideIfParameterMissing:=False, bNewLinkedChangeToDefaultState:=True, objNewDefaultState:=strDefaultGraphType)
        ucrChkGenerateMultipleComparisonPlot.AddToLinkedControls(ucrSaveGraph, {True}, bNewLinkedHideIfParameterMissing:=False)

        ucrSaveGraph.SetIsComboBox()
        ucrSaveGraph.SetCheckBoxText("Store Graph")
        ucrSaveGraph.SetDataFrameSelector(ucrSelectorModelMultipleComparisons.ucrAvailableDataFrames)
        ucrSaveGraph.SetSaveTypeAsGraph()
        ucrSaveGraph.SetPrefix("mct_plot")
        ucrSaveGraph.SetAssignToIfUncheckedValue(strLastGraphName)
        ucrSaveGraph.Enabled = False
    End Sub

    Private Sub SetDefaults()

        clsGetModelFunction = New RFunction
        clsAssignModelOperator = New ROperator
        clsMultipleComparisonsFunction = New RFunction
        clsRmFunction = New RFunction
        clsAutoplotFunction = New RFunction
        clsCheckGraphFunction = New RFunction
        clsAddPlotObjectFunction = New RFunction
        clsGetPlotObjectDataFunction = New RFunction

        ucrSelectorModelMultipleComparisons.Reset()
        ucrSaveModelMultipleComparisons.Reset()
        ucrSaveModelMultipleComparisons.ucrChkSave.Checked = False
        ucrSaveGraph.Reset()
        ucrSaveGraph.ucrChkSave.Checked = False
        ucrSaveGraph.Enabled = False
        ucrChkByOptional.Checked = False
        ucrChkGenerateMultipleComparisonPlot.Checked = False
        ucrReceiverBy.Visible = False
        ucrInputGenerateMultipleComparisonGraphs.Visible = False

        lstModelFactorNames = New List(Of String)

        clsGetModelFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

        clsAssignModelOperator.SetOperation("<-")
        clsAssignModelOperator.AddParameter("left", strModelTmpName, iPosition:=0)
        clsAssignModelOperator.AddParameter("right", clsRFunctionParameter:=clsGetModelFunction, iPosition:=1)
        clsAssignModelOperator.bToScriptAsRString = False

        clsMultipleComparisonsFunction.SetPackageName("biometryassist")
        clsMultipleComparisonsFunction.SetRCommand("multiple_comparisons")
        clsMultipleComparisonsFunction.AddParameter("model.obj", strModelTmpName, iPosition:=0)

        clsRmFunction.SetRCommand("rm")
        clsRmFunction.bToScriptAsRString = False

        clsAutoplotFunction.SetPackageName("biometryassist")
        clsAutoplotFunction.SetRCommand("autoplot")

        clsCheckGraphFunction.SetPackageName("instatExtras")
        clsCheckGraphFunction.SetRCommand("check_graph")

        clsAddPlotObjectFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$add_object")
        clsGetPlotObjectDataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_object_data")

    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)

        ucrInputComboBoxDisplayLetters.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrInputComboBoxConfidenceInterval.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrInputComboBoxAlpha.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrInputComboBoxDescending.SetRCode(clsMultipleComparisonsFunction, bReset)
        ucrInputComboBoxAdjustment.SetRCode(clsMultipleComparisonsFunction, bReset)

        If bReset Then
            ucrChkAlpha.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkConfidenceInterval.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkDisplayLetters.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkDescending.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkAdjustment.SetRCode(clsMultipleComparisonsFunction, bReset)
            ucrChkGenerateMultipleComparisonPlot.SetRCode(clsMultipleComparisonsFunction, bReset)
        End If

        UpdateClassifyAndByParameters()
        UpdateAssignTo()
        UpdateGraphCode()
    End Sub


    ' Builds the classify (and, when By is in use, the by:classify interaction)
    ' and by arguments on clsMultipleComparisonsFunction from the current receiver selections.`
    Private Sub UpdateClassifyAndByParameters()
        Dim bByInUse As Boolean = ucrChkByOptional.Checked AndAlso Not ucrReceiverBy.IsEmpty()

        If Not ucrReceiverLabelVariable.IsEmpty() Then
            Dim strClassify As String = ucrReceiverLabelVariable.GetVariableNames(bWithQuotes:=False)
            If bByInUse Then
                Dim strBy As String = ucrReceiverBy.GetVariableNames(bWithQuotes:=False)
                clsMultipleComparisonsFunction.AddParameter("classify", Chr(34) & strBy & ":" & strClassify & Chr(34), iPosition:=1)
            Else
                clsMultipleComparisonsFunction.AddParameter("classify", Chr(34) & strClassify & Chr(34), iPosition:=1)
            End If
        Else
            clsMultipleComparisonsFunction.RemoveParameterByName("classify")
        End If

        If bByInUse Then
            clsMultipleComparisonsFunction.AddParameter("by", Chr(34) & ucrReceiverBy.GetVariableNames(bWithQuotes:=False) & Chr(34), iPosition:=2)
        Else
            clsMultipleComparisonsFunction.AddParameter("by", "NULL", iPosition:=2, bIncludeArgumentName:=True)
        End If
    End Sub

    Private Sub UpdateAssignTo()
        If ucrSaveModelMultipleComparisons.ucrChkSave.Checked AndAlso ucrSaveModelMultipleComparisons.GetText() <> "" AndAlso ucrSaveModelMultipleComparisons.IsComplete() Then
            clsMultipleComparisonsFunction.SetAssignToOutputObject(
                strRObjectToAssignTo:=ucrSaveModelMultipleComparisons.GetText(),
                strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Summary,
                strRObjectFormatToAssignTo:=RObjectFormat.Text,
                strRDataFrameNameToAddObjectTo:=ucrSelectorModelMultipleComparisons.strCurrentDataFrame,
                strObjectName:=ucrSaveModelMultipleComparisons.GetText())
        Else
            clsMultipleComparisonsFunction.RemoveAssignTo()
            clsMultipleComparisonsFunction.SetAssignTo(strLastMctName)
        End If
    End Sub


    ' Rebuilds the graph pipeline: produce the plot, validate it, register it in the object store,
    ' then pull it back out for display. Uses ClearCodes() and rebuilds everything from scratch
    ' rather than incrementally adding/removing pieces.
    Private Sub UpdateGraphCode()
        ucrBase.clsRsyntax.ClearCodes()
        ucrBase.clsRsyntax.AddToBeforeCodes(clsAssignModelOperator)
        ucrBase.clsRsyntax.SetBaseRFunction(clsMultipleComparisonsFunction)

        Dim strMctName As String = GetMctName()
        Dim strRmList As String = BuildRemovalList(strMctName)

        If ucrChkGenerateMultipleComparisonPlot.Checked Then
            Dim strGraphName As String = GetGraphName()
            BuildGraphPipeline(strMctName, strGraphName)

            If Not ucrSaveGraph.ucrChkSave.Checked Then
                strRmList &= ", " & Chr(34) & strLastGraphName & Chr(34)
            End If
        End If

        AddCleanupCode(strRmList)
    End Sub


    ' Name the current mct object will be assigned to (or the transient default if not saved).
    Private Function GetMctName() As String
        Return If(ucrSaveModelMultipleComparisons.ucrChkSave.Checked AndAlso ucrSaveModelMultipleComparisons.GetText() <> "",
                   ucrSaveModelMultipleComparisons.GetText(), strLastMctName)
    End Function


    ' Name the current graph object will be assigned to (or the transient default if not saved).
    Private Function GetGraphName() As String
        Return If(ucrSaveGraph.ucrChkSave.Checked AndAlso ucrSaveGraph.GetText() <> "",
                  ucrSaveGraph.GetText(), strLastGraphName)
    End Function


    ' Starts the rm list with the temporary model object, adding the mct object too if it wasn't saved.
    Private Function BuildRemovalList(strMctName As String) As String
        Dim strRmList As String = Chr(34) & strModelTmpName & Chr(34)
        If Not ucrSaveModelMultipleComparisons.ucrChkSave.Checked Then
            strRmList &= ", " & Chr(34) & strLastMctName & Chr(34)
        End If
        Return strRmList
    End Function


    ' Wires up autoplot() -> check_graph() -> add_object() -> get_object_data() and appends them
    ' to the after-codes so the graph is built, validated, stored, and pulled back out for display.
    Private Sub BuildGraphPipeline(strMctName As String, strGraphName As String)
        Dim strDataFrame As String = ucrSelectorModelMultipleComparisons.strCurrentDataFrame

        ' autoplot
        clsAutoplotFunction.ClearParameters()
        clsAutoplotFunction.AddParameter("object", strMctName, iPosition:=0, bIncludeArgumentName:=False)
        Dim strType As String = ucrInputGenerateMultipleComparisonGraphs.GetText()
        If strType = "" Then strType = strDefaultGraphType
        clsAutoplotFunction.AddParameter("type", Chr(34) & strType.ToLower() & Chr(34), iPosition:=1)
        clsAutoplotFunction.AddParameter("label_height", "0.1", iPosition:=2) ' fraction of plot height reserved for group letters
        clsAutoplotFunction.SetAssignTo(strGraphName)

        ' check_graph
        clsCheckGraphFunction.ClearParameters()
        clsCheckGraphFunction.AddParameter("graph_object", strGraphName, iPosition:=0)

        ' add_object
        clsAddPlotObjectFunction.ClearParameters()
        If Not String.IsNullOrEmpty(strDataFrame) Then
            clsAddPlotObjectFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        End If
        clsAddPlotObjectFunction.AddParameter("object_name", Chr(34) & strGraphName & Chr(34), iPosition:=1)
        clsAddPlotObjectFunction.AddParameter("object_type_label", Chr(34) & "graph" & Chr(34), iPosition:=2)
        clsAddPlotObjectFunction.AddParameter("object_format", Chr(34) & "image" & Chr(34), iPosition:=3)
        clsAddPlotObjectFunction.AddParameter("object", clsRFunctionParameter:=clsCheckGraphFunction, iPosition:=4)

        ' get_object_data
        clsGetPlotObjectDataFunction.ClearParameters()
        If Not String.IsNullOrEmpty(strDataFrame) Then
            clsGetPlotObjectDataFunction.AddParameter("data_name", Chr(34) & strDataFrame & Chr(34), iPosition:=0)
        End If
        clsGetPlotObjectDataFunction.AddParameter("object_name", Chr(34) & strGraphName & Chr(34), iPosition:=1)
        clsGetPlotObjectDataFunction.AddParameter("as_file", "TRUE", iPosition:=2)

        ucrBase.clsRsyntax.AddToAfterCodes(clsAutoplotFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsAddPlotObjectFunction)
        ucrBase.clsRsyntax.AddToAfterCodes(clsGetPlotObjectDataFunction)
    End Sub


    ' rm call that clears out unsaved objects at the end of the script.
    Private Sub AddCleanupCode(strRmList As String)
        clsRmFunction.ClearParameters()
        clsRmFunction.AddParameter("list", "c(" & strRmList & ")", bIncludeArgumentName:=True, iPosition:=0)
        ucrBase.clsRsyntax.AddToAfterCodes(clsRmFunction)
    End Sub

    Private Sub TestOkEnabled()
        Dim bByDuplicatesLabel As Boolean = ucrChkByOptional.Checked AndAlso Not ucrReceiverBy.IsEmpty() AndAlso
                                             ucrReceiverBy.GetVariableNames(bWithQuotes:=False) = ucrReceiverLabelVariable.GetVariableNames(bWithQuotes:=False)

        Dim bOKEnabled As Boolean = Not ucrReceiverMultipleMeanComparisonUseModel.IsEmpty() AndAlso
                                    Not ucrReceiverLabelVariable.IsEmpty() AndAlso
                                    Not bByDuplicatesLabel AndAlso
                                    ucrSaveModelMultipleComparisons.IsComplete() AndAlso
                                    (Not ucrChkGenerateMultipleComparisonPlot.Checked OrElse ucrSaveGraph.IsComplete())

        ucrBase.OKEnabled(bOKEnabled)
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverMultipleMeanComparisonUseModel_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverMultipleMeanComparisonUseModel.SelectionChanged
        If Not ucrReceiverMultipleMeanComparisonUseModel.IsEmpty() Then
            clsGetModelFunction.AddParameter("object_name", ucrReceiverMultipleMeanComparisonUseModel.GetVariableNames())
            UpdateSaveName()
        Else
            clsGetModelFunction.RemoveParameterByName("object_name")
        End If
        UpdateModelFactorNames()
        TestOkEnabled()
    End Sub

    Private Sub ucrSelectorModelMultipleComparisons_DataFrameChanged() Handles ucrSelectorModelMultipleComparisons.DataFrameChanged
        If Not String.IsNullOrEmpty(ucrSelectorModelMultipleComparisons.strCurrentDataFrame) Then
            clsGetModelFunction.AddParameter("data_name", Chr(34) & ucrSelectorModelMultipleComparisons.strCurrentDataFrame & Chr(34))
        End If
        UpdateAssignTo()
        UpdateGraphCode()
        UpdateModelFactorNames()
        TestOkEnabled()
    End Sub

    Private Sub ucrSaveModelMultipleComparisons_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveModelMultipleComparisons.ControlValueChanged
        UpdateAssignTo()
        UpdateGraphCode()
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverLabelVariable_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverLabelVariable.SelectionChanged
        UpdateClassifyAndByParameters()
        TestOkEnabled()
    End Sub

    Private Sub ucrReceiverBy_SelectionChanged(sender As Object, e As EventArgs) Handles ucrReceiverBy.SelectionChanged
        UpdateClassifyAndByParameters()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkByOptional_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkByOptional.ControlValueChanged
        If Not ucrChkByOptional.Checked Then
            ucrReceiverBy.Clear()
        End If
        ucrReceiverBy.Visible = ucrChkByOptional.Checked

        UpdateClassifyAndByParameters()
        TestOkEnabled()
    End Sub

    Private Sub ucrChkGenerateMultipleComparisonPlot_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkGenerateMultipleComparisonPlot.ControlValueChanged
        If ucrChkGenerateMultipleComparisonPlot.Checked Then
            ucrSaveModelMultipleComparisons.ucrChkSave.Checked = True
        Else
            ucrSaveGraph.ucrChkSave.Checked = False
        End If
        ucrSaveGraph.Enabled = ucrChkGenerateMultipleComparisonPlot.Checked
        ucrInputGenerateMultipleComparisonGraphs.Visible = ucrChkGenerateMultipleComparisonPlot.Checked
        UpdateAssignTo()
        UpdateGraphCode()
        TestOkEnabled()
    End Sub

    Private Sub ucrInputGenerateMultipleComparisonGraphs_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputGenerateMultipleComparisonGraphs.ControlValueChanged
        UpdateGraphCode()
    End Sub

    Private Sub ucrSaveGraph_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrSaveGraph.ControlValueChanged
        UpdateAssignTo()
        UpdateGraphCode()
        TestOkEnabled()
    End Sub

    Private Sub Controls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles _
        ucrReceiverLabelVariable.ControlContentsChanged,
        ucrReceiverBy.ControlContentsChanged,
        ucrSaveModelMultipleComparisons.ControlContentsChanged,
        ucrChkAlpha.ControlContentsChanged,
        ucrInputComboBoxAlpha.ControlContentsChanged,
        ucrChkConfidenceInterval.ControlContentsChanged,
        ucrChkDisplayLetters.ControlContentsChanged,
        ucrInputComboBoxConfidenceInterval.ControlContentsChanged,
        ucrChkDescending.ControlContentsChanged,
        ucrInputComboBoxDescending.ControlContentsChanged,
        ucrChkAdjustment.ControlContentsChanged,
        ucrInputComboBoxAdjustment.ControlContentsChanged,
        ucrChkByOptional.ControlContentsChanged,
        ucrChkGenerateMultipleComparisonPlot.ControlContentsChanged,
        ucrInputGenerateMultipleComparisonGraphs.ControlContentsChanged,
        ucrSaveGraph.ControlContentsChanged

        TestOkEnabled()
    End Sub


    'save name derived from the model name.
    Private Sub UpdateSaveName()
        Dim strModelName As String = ucrReceiverMultipleMeanComparisonUseModel.GetVariableNames(bWithQuotes:=False)
        Dim iUnderscoreIndex As Integer = strModelName.IndexOf("_"c)

        If iUnderscoreIndex >= 0 AndAlso iUnderscoreIndex < strModelName.Length - 1 Then
            ucrSaveModelMultipleComparisons.SetName("mct_" & strModelName.Substring(iUnderscoreIndex + 1))
        Else
            ucrSaveModelMultipleComparisons.SetName("mct_" & strModelName)
        End If
        UpdateAssignTo()
        UpdateGraphCode()
    End Sub


    'In the receivers we need to get the factors from the object and not from the data frame.
    Private Sub UpdateModelFactorNames()
        Dim strPrvLabelVariable As String = ucrReceiverLabelVariable.GetVariableNames(bWithQuotes:=False)
        Dim strPrvBy As String = ucrReceiverBy.GetVariableNames(bWithQuotes:=False)

        lstModelFactorNames = New List(Of String)

        If Not ucrReceiverMultipleMeanComparisonUseModel.IsEmpty() AndAlso Not String.IsNullOrEmpty(ucrSelectorModelMultipleComparisons.strCurrentDataFrame) Then
            Dim strModelName As String = ucrReceiverMultipleMeanComparisonUseModel.GetVariableNames(bWithQuotes:=False)
            Dim strScript As String = "all.vars(formula(" & frmMain.clsRLink.strInstatDataObject & "$get_object_data(data_name = " &
                Chr(34) & ucrSelectorModelMultipleComparisons.strCurrentDataFrame & Chr(34) & ", object_name = " &
                Chr(34) & strModelName & Chr(34) & ")))"

            Dim expModelVariables As SymbolicExpression = frmMain.clsRLink.RunInternalScriptGetValue(strScript, bSilent:=True)
            If expModelVariables IsNot Nothing AndAlso Not expModelVariables.Type = RDotNet.Internals.SymbolicExpressionType.Null Then
                lstModelFactorNames = expModelVariables.AsCharacter().ToList()
            End If
        End If

        ' If the receivers currently hold a factor that is no longer part of the newly selected model, clear them
        If Not String.IsNullOrEmpty(strPrvLabelVariable) AndAlso Not lstModelFactorNames.Contains(strPrvLabelVariable) Then
            ucrReceiverLabelVariable.Clear()
        End If
        If Not String.IsNullOrEmpty(strPrvBy) AndAlso Not lstModelFactorNames.Contains(strPrvBy) Then
            ucrReceiverBy.Clear()
        End If

        FilterFactorReceiverItems()
    End Sub


    ' Excludes the sibling factor receiver's currently selected variable from the available list,
    ' alongside the existing model-factor filtering,
    ' so the same variable can't be picked as both Label Variable and By.`
    Private Sub FilterFactorReceiverItems()
        If lstModelFactorNames.Count > 0 AndAlso
       (ucrSelectorModelMultipleComparisons.CurrentReceiver Is ucrReceiverLabelVariable OrElse
        ucrSelectorModelMultipleComparisons.CurrentReceiver Is ucrReceiverBy) Then

            ' same variable can't be both the Label Variable and the By variable at once.
            Dim strSiblingValue As String = If(ucrSelectorModelMultipleComparisons.CurrentReceiver Is ucrReceiverLabelVariable,
                                            ucrReceiverBy.GetVariableNames(bWithQuotes:=False),
                                            ucrReceiverLabelVariable.GetVariableNames(bWithQuotes:=False))

            For i As Integer = ucrSelectorModelMultipleComparisons.lstAvailableVariable.Items.Count - 1 To 0 Step -1
                Dim lviCurrent As ListViewItem = ucrSelectorModelMultipleComparisons.lstAvailableVariable.Items(i)
                If Not lstModelFactorNames.Contains(lviCurrent.Text) OrElse lviCurrent.Text = strSiblingValue Then
                    ucrSelectorModelMultipleComparisons.lstAvailableVariable.Items.RemoveAt(i)
                End If
            Next
        End If
    End Sub

    Private Sub ucrReceiverLabelVariable_Enter(sender As Object, e As EventArgs) Handles ucrReceiverLabelVariable.Enter
        FilterFactorReceiverItems()
    End Sub

    Private Sub ucrReceiverBy_Enter(sender As Object, e As EventArgs) Handles ucrReceiverBy.Enter
        FilterFactorReceiverItems()
    End Sub
End Class