Imports instat.Translations

Public Class dlgGeneralTable
    Private clsBaseOperator As New ROperator
    Private clsGetdataFunction, clsGetdataMultipleFunction, clsGetdataSingleFunction, clsPivotWiderFunction, clsFormatTableFunction, clsHeadRFunction, clsHeaderRFunction, clsCellsTitleRFunction, clsTitleStyleRFunction, clsTitleFooterRFunction, clsGtRFunction, clsThemeRFunction, clsDummyFunction As New RFunction

    Private bFirstload As Boolean = True
    Private bReset As Boolean = True

    Private Sub dlgGeneralTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If bFirstload Then
            initialiseDialog()
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

    Private Sub btnMoreOptions_Click(sender As Object, e As EventArgs) Handles btnMoreOptions.Click
        sdgTableOptions.Setup(ucrSelectorCols.strCurrentDataFrame, clsBaseOperator)
        sdgTableOptions.ShowDialog(Me)
        ucrInputTitle.SetText(sdgTableOptions.ucrHeader.ucrInputTitle.GetText)
        ucrInputTitleFooter.SetText(sdgTableOptions.ucrHeader.ucrInputTitleFooter.GetText)
        ucrCboSelectThemes.SetText(sdgTableOptions.ucrCboSelectThemes.GetText)
        ucrChkSelectTheme.Checked = sdgTableOptions.ucrChkSelectTheme.Checked
        sdgTableStyles.GetNewUserInputAsRFunction()
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged, ucrReceiverMultipleColFactor.ControlContentsChanged, ucrReceiverMultipleRowFactors.ControlContentsChanged, ucrReceiverMultipleVariablesMul.ControlContentsChanged, ucrReceiverSingleVariable.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub

    Private Sub initialiseDialog()
        ucrBase.iHelpTopicID = 419

        ucrSelectorCols.SetParameter(New RParameter("data_name", 0))
        ucrSelectorCols.SetParameterIsString()

        ucrPnlOptions.AddRadioButton(rdoDataFrame)
        ucrPnlOptions.AddRadioButton(rdoMultiple)
        ucrPnlOptions.AddRadioButton(rdoSingle)

        ucrPnlOptions.AddParameterValuesCondition(rdoDataFrame, "checked", "Data Frame")
        ucrPnlOptions.AddParameterValuesCondition(rdoSingle, "checked", "Single")
        ucrPnlOptions.AddParameterValuesCondition(rdoMultiple, "checked", "Multiple")

        ucrPnlOptions.AddToLinkedControls({ucrChkPreview, ucrReceiverMultipleCols}, {rdoDataFrame}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSingleVariable}, {rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverMultipleVariablesMul}, {rdoMultiple}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverMultipleColFactor, ucrReceiverMultipleRowFactors}, {rdoMultiple, rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)

        ucrReceiverMultipleCols.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleCols.SetParameterIsString()
        ucrReceiverMultipleCols.Selector = ucrSelectorCols
        ucrReceiverMultipleCols.SetLinkedDisplayControl(lblColumns)

        ucrReceiverMultipleRowFactors.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleRowFactors.SetParameterIsString()
        ucrReceiverMultipleRowFactors.Selector = ucrSelectorCols
        ucrReceiverMultipleRowFactors.SetIncludedDataTypes({"factor"})
        ucrReceiverMultipleRowFactors.strSelectorHeading = "Factors"
        ucrReceiverMultipleRowFactors.SetLinkedDisplayControl(lblRowFactor)

        ucrReceiverMultipleColFactor.SetParameter(New RParameter("names_from", 0))
        ucrReceiverMultipleColFactor.SetParameterIsString()
        ucrReceiverMultipleColFactor.Selector = ucrSelectorCols
        ucrReceiverMultipleColFactor.SetIncludedDataTypes({"factor"})
        ucrReceiverMultipleColFactor.strSelectorHeading = "Factors"
        ucrReceiverMultipleColFactor.SetLinkedDisplayControl(lblColFactor)

        ucrReceiverSingleVariable.SetParameter(New RParameter("values_from", 1))
        ucrReceiverSingleVariable.SetParameterIsString()
        ucrReceiverSingleVariable.Selector = ucrSelectorCols
        ucrReceiverSingleVariable.SetLinkedDisplayControl(lblVariable)

        ucrReceiverMultipleVariablesMul.SetParameter(New RParameter("values_from", 1))
        ucrReceiverMultipleVariablesMul.SetParameterIsString()
        ucrReceiverMultipleVariablesMul.Selector = ucrSelectorCols
        ucrReceiverMultipleVariablesMul.SetLinkedDisplayControl(lblVariblesMul)

        ucrInputTitle.SetParameter(New RParameter("title", iNewPosition:=0))
        ucrInputTitleFooter.SetParameter(New RParameter("footnote", iNewPosition:=0))

        ucrChkPreview.SetText("Preview")
        ucrChkPreview.AddParameterPresentCondition(True, "head", bNewIsPositive:=True)
        ucrChkPreview.AddParameterPresentCondition(False, "head", bNewIsPositive:=False)
        ucrChkPreview.AddToLinkedControls(ucrNudPreview, {True}, bNewLinkedHideIfParameterMissing:=True)

        ucrNudPreview.SetParameter(New RParameter("x", 0, bNewIncludeArgumentName:=False))
        ucrNudPreview.Minimum = 6
        ucrNudPreview.Maximum = Decimal.MaxValue
        ucrNudPreview.SetRDefault(6)

        ucrNudPosition.SetParameter(New RParameter("position", 0))
        ucrNudPosition.SetMinMax(1, 4)
        ucrNudPosition.SetRDefault(4)
        ucrNudPosition.SetLinkedDisplayControl(lblposition)

        ucrSaveTable.SetPrefix("presentation_table")
        ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSaveTable.SetDataFrameSelector(ucrSelectorCols.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Store Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")

        ucrChkSelectTheme.SetText("Theme")
        ucrChkSelectTheme.AddParameterValuesCondition(True, "theme", "True")
        ucrChkSelectTheme.AddParameterValuesCondition(False, "theme", "False")
        ucrCboSelectThemes.SetItems({"None", "Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrCboSelectThemes.SetDropDownStyleAsNonEditable()

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
        SetDefaults()
    End Sub

    Private Sub SetDefaults()
        clsBaseOperator = New ROperator

        clsHeadRFunction = New RFunction
        clsGtRFunction = New RFunction
        clsHeaderRFunction = New RFunction
        clsCellsTitleRFunction = New RFunction
        clsTitleFooterRFunction = New RFunction
        clsTitleStyleRFunction = New RFunction
        clsDummyFunction = New RFunction
        clsPivotWiderFunction = New RFunction
        clsFormatTableFunction = New RFunction
        clsGetdataFunction = New RFunction
        clsGetdataSingleFunction = New RFunction
        clsGetdataMultipleFunction = New RFunction

        ucrSelectorCols.Reset()
        ucrSaveTable.Reset()
        ucrChkPreview.Checked = True
        ucrCboSelectThemes.SetText("Dark Theme")

        clsBaseOperator.SetOperation("%>%")
        clsBaseOperator.bBrackets = False

        clsGetdataFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetdataFunction.AddParameter("data_name", Chr(34) & ucrSelectorCols.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

        clsGetdataSingleFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetdataSingleFunction.AddParameter("data_name", Chr(34) & ucrSelectorCols.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

        clsGetdataMultipleFunction.SetRCommand(frmMain.clsRLink.strInstatDataObject & "$get_columns_from_data")
        clsGetdataMultipleFunction.AddParameter("data_name", Chr(34) & ucrSelectorCols.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)

        clsDummyFunction.AddParameter("checked", "Single", iPosition:=0)
        clsDummyFunction.AddParameter("theme", "False", iPosition:=1)

        clsHeadRFunction.SetPackageName("utils")
        clsHeadRFunction.SetRCommand("head")
        clsHeadRFunction.AddParameter(strParameterName:="x", strParameterValue:=10, iPosition:=0, bIncludeArgumentName:=False)
        clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)

        clsGtRFunction.SetPackageName("gt")
        clsGtRFunction.SetRCommand("gt")
        clsBaseOperator.AddParameter(strParameterName:="gt", clsRFunctionParameter:=clsGtRFunction, iPosition:=2, bIncludeArgumentName:=False)

        clsThemeRFunction.SetPackageName("gtExtras")
        clsThemeRFunction.SetRCommand("gt_theme_dark")
        clsBaseOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction, iPosition:=4)

        clsHeaderRFunction.SetPackageName("gt")
        clsHeaderRFunction.SetRCommand("tab_header")
        clsHeaderRFunction.AddParameter("title", ucrInputTitle.GetText, iPosition:=1)
        clsBaseOperator.AddParameter("theme_Header", clsRFunctionParameter:=clsHeaderRFunction)

        clsTitleFooterRFunction.SetPackageName("gt")
        clsTitleFooterRFunction.SetRCommand("tab_footnote")
        clsTitleFooterRFunction.AddParameter("footnote", ucrInputTitleFooter.GetText, iPosition:=1)
        clsTitleFooterRFunction.AddParameter("locations", clsRFunctionParameter:=clsCellsTitleRFunction, iPosition:=2)
        clsBaseOperator.AddParameter("theme_footer", clsRFunctionParameter:=clsTitleFooterRFunction)

        clsPivotWiderFunction.SetPackageName("tidyr")
        clsPivotWiderFunction.SetRCommand("pivot_wider")

        clsFormatTableFunction.SetRCommand("format_gt_table")

        Dim strGroupParamValue As String = "title"
        clsCellsTitleRFunction.SetPackageName("gt")
        clsCellsTitleRFunction.SetRCommand("cells_title")
        clsCellsTitleRFunction.AddParameter(strParameterName:="groups", strParameterValue:=Chr(34) & strGroupParamValue & Chr(34), iPosition:=0)

        clsBaseOperator.SetAssignToOutputObject(strRObjectToAssignTo:="last_table",
                                                  strRObjectTypeLabelToAssignTo:=RObjectTypeLabel.Table,
                                                  strRObjectFormatToAssignTo:=RObjectFormat.Html,
                                                  strRDataFrameNameToAddObjectTo:=ucrSelectorCols.strCurrentDataFrame,
                                                  strObjectName:="last_table")

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)
    End Sub

    Private Sub SetRCodeForControls(bReset As Boolean)
        ucrSaveTable.SetRCode(clsBaseOperator, bReset)
        ucrInputTitle.SetRCode(clsHeaderRFunction, True, bCloneIfNeeded:=True)
        ucrInputTitleFooter.SetRCode(clsTitleFooterRFunction, True, bCloneIfNeeded:=True)
        If bReset Then
            ucrChkSelectTheme.SetRCode(clsDummyFunction, bReset)
            ucrPnlOptions.SetRCode(clsDummyFunction, bReset)
            ucrChkPreview.SetRCode(clsBaseOperator, bReset)
            ucrNudPreview.SetRCode(clsHeadRFunction, bReset)
        End If
        ucrReceiverMultipleCols.SetRCode(clsGetdataFunction, bReset)
        Updateparameter()
        AddRemoveThemes()
    End Sub

    Private Sub TestOKEnabled()
        If rdoDataFrame.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverMultipleCols.IsEmpty AndAlso ucrSaveTable.IsComplete)
        ElseIf rdoSingle.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverSingleVariable.IsEmpty AndAlso ucrSaveTable.IsComplete AndAlso (Not ucrReceiverMultipleColFactor.IsEmpty OrElse Not ucrReceiverMultipleRowFactors.IsEmpty))
        Else
            ucrBase.OKEnabled(Not ucrReceiverMultipleColFactor.IsEmpty AndAlso Not ucrReceiverMultipleRowFactors.IsEmpty AndAlso ucrSaveTable.IsComplete)
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrReceiverSingleVariable.ControlValueChanged, ucrReceiverMultipleVariablesMul.ControlValueChanged
        AddRemovePivotwider()
        AddRemoveThemes()
        Updateparameter()
    End Sub

    Private Sub AddRemovePivotwider()
        clsBaseOperator.RemoveParameterByName("get_columns_from_data")
        clsBaseOperator.RemoveParameterByName("pivot_wider")
        clsBaseOperator.RemoveParameterByName("format_table")

        If rdoSingle.Checked Then
            clsBaseOperator.RemoveParameterByName("head")
            clsBaseOperator.RemoveParameterByName("gt")
            ucrReceiverMultipleRowFactors.SetMeAsReceiver()
            Updateparameter()
            clsPivotWiderFunction.AddParameter("values_from", ucrReceiverSingleVariable.GetVariableNames(False), iPosition:=1)
            clsBaseOperator.AddParameter("get_columns_from_data", clsRFunctionParameter:=clsGetdataSingleFunction, iPosition:=0, bIncludeArgumentName:=False)
            clsBaseOperator.AddParameter("pivot_wider", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            clsBaseOperator.AddParameter("format_table", clsRFunctionParameter:=clsFormatTableFunction, iPosition:=2)
        ElseIf rdoMultiple.Checked Then
            clsBaseOperator.RemoveParameterByName("head")
            clsBaseOperator.RemoveParameterByName("gt")
            ucrReceiverMultipleRowFactors.SetMeAsReceiver()
            Updateparameter()
            clsPivotWiderFunction.AddParameter("values_from", ucrReceiverMultipleVariablesMul.GetVariableNames(False), iPosition:=1)
            clsBaseOperator.AddParameter("get_columns_from_data", clsRFunctionParameter:=clsGetdataMultipleFunction, iPosition:=0, bIncludeArgumentName:=False)
            clsBaseOperator.AddParameter("pivot_wider", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=1)
            clsBaseOperator.AddParameter("format_table", clsRFunctionParameter:=clsFormatTableFunction, iPosition:=2)
        Else
            ucrChkPreview.Checked = True
            AddRemoveHead()
            ucrReceiverMultipleCols.SetMeAsReceiver()
            clsBaseOperator.RemoveParameterByName("pivot_wider")
            clsBaseOperator.RemoveParameterByName("format_table")
            clsBaseOperator.AddParameter("get_columns_from_data", clsRFunctionParameter:=clsGetdataFunction, iPosition:=0, bIncludeArgumentName:=False)
            clsBaseOperator.AddParameter("gt", clsRFunctionParameter:=clsGtRFunction, iPosition:=2, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub Updateparameter()
        ' Helper function to clean and split variable strings
        Dim cleanVars As Func(Of String, String()) = Function(varString)
                                                         If String.IsNullOrEmpty(varString) Then Return New String() {}
                                                         Dim cleaned As String = varString.Replace("c(", "").Replace(")", "").Trim()
                                                         Return cleaned.Split(","c).Select(Function(v) v.Trim()).ToArray()
                                                     End Function

        ' Remove pivot-related parameters by default
        clsBaseOperator.RemoveParameterByName("pivot_longer")
        clsBaseOperator.RemoveParameterByName("arrange")
        clsBaseOperator.RemoveParameterByName("pivot_wider")
        clsBaseOperator.RemoveParameterByName("format_table")
        clsGetdataSingleFunction.RemoveParameterByName("col_name")
        clsGetdataMultipleFunction.RemoveParameterByName("col_name")
        clsPivotWiderFunction.RemoveParameterByName("names_from")
        clsPivotWiderFunction.RemoveParameterByName("values_from")

        If rdoDataFrame.Checked Then
            ' For rdoDataFrame, no pivot functions are needed
            ' Just retrieve the selected columns using clsGetdataSingleFunction
            If Not ucrReceiverMultipleCols.IsEmpty Then
                Dim selectedCols As String = ucrReceiverMultipleCols.GetVariableNames(False)
                Dim colList As String() = cleanVars(selectedCols)
                Dim result As String = "c(" & String.Join(",", colList.Select(Function(v) """" & v.Trim() & """")) & ")"
                clsGetdataSingleFunction.AddParameter("col_name", result)
            End If
        ElseIf rdoSingle.Checked Then
            ' Logic for rdoSingle using clsGetdataSingleFunction
            Dim summaryVars As String() = cleanVars(ucrReceiverSingleVariable.GetVariableNames(False))

            ' Check receiver states
            Dim hasRowFactor As Boolean = Not ucrReceiverMultipleRowFactors.IsEmpty
            Dim hasColFactor As Boolean = Not ucrReceiverMultipleColFactor.IsEmpty

            ' Get the position of the summary variables
            Dim summaryPosition As Integer = ucrNudPosition.Value

            ' Create a new RFunction for pivot_longer
            Dim clsPivotLongerFunction As New RFunction
            clsPivotLongerFunction.SetPackageName("tidyr")
            clsPivotLongerFunction.SetRCommand("pivot_longer")
            clsPivotLongerFunction.AddParameter("cols", "c(" & String.Join(",", summaryVars.Select(Function(v) """" & v & """")) & ")", iPosition:=0)
            clsPivotLongerFunction.AddParameter("names_to", """summary_type""", iPosition:=1)
            clsPivotLongerFunction.AddParameter("values_to", """value""", iPosition:=2)

            ' Create a new RFunction for arrange
            Dim clsArrangeFunction As New RFunction
            clsArrangeFunction.SetPackageName("dplyr")
            clsArrangeFunction.SetRCommand("arrange")

            If hasColFactor Or hasRowFactor Then
                ' Get variable names from receivers (only if not empty)
                Dim rowFactorVars As String = If(hasRowFactor, ucrReceiverMultipleRowFactors.GetVariableNames(False), "")
                Dim colFactorVars As String = If(hasColFactor, ucrReceiverMultipleColFactor.GetVariableNames(False), "")

                ' Get cleaned variable arrays
                Dim colFactorList As String() = cleanVars(colFactorVars)
                Dim rowFactorList As String() = cleanVars(rowFactorVars)

                ' Define the factors in their default order (without summary variables)
                Dim rowFactors As New List(Of String)
                Dim colFactors As New List(Of String)(colFactorList)

                ' If row factors are empty, use column factors for row ordering
                If hasRowFactor Then
                    rowFactors.AddRange(rowFactorList)
                ElseIf hasColFactor Then
                    rowFactors.AddRange(colFactorList)
                End If

                ' Adjust the row and column factors based on the summary position
                Dim newRowFactors As New List(Of String)
                Dim newColFactors As New List(Of String)

                ' Position 1: Summary variables are the first row factor
                If summaryPosition = 1 Then
                    newRowFactors.Add("summary_type")
                    newRowFactors.AddRange(rowFactors)
                    newColFactors.AddRange(colFactors)
                    ' Position 2: Summary variables come after the first row factor
                ElseIf summaryPosition = 2 Then
                    If rowFactors.Count >= 1 Then newRowFactors.Add(rowFactors(0))
                    newRowFactors.Add("summary_type")
                    If rowFactors.Count > 1 Then newRowFactors.AddRange(rowFactors.Skip(1))
                    newColFactors.AddRange(colFactors)
                    ' Position 3: Summary variables come after all row factors
                ElseIf summaryPosition = 3 Then
                    newRowFactors.AddRange(rowFactors)
                    newRowFactors.Add("summary_type")
                    newColFactors.AddRange(colFactors)
                    ' Position 4: Summary variables act as a second column factor
                ElseIf summaryPosition = 4 Then
                    newRowFactors.AddRange(rowFactors)
                    newColFactors.AddRange(colFactors)
                    newColFactors.Add("summary_type")
                End If

                ' Combine all variables for col_name (all variables involved in the pivot)
                Dim allVars As New List(Of String)
                Dim uniqueVars As New HashSet(Of String)

                ' Add row factors and column factors (excluding summary_type, which is added by pivot_longer)
                For Each var In rowFactors
                    If uniqueVars.Add(var) Then allVars.Add(var)
                Next
                For Each var In colFactors
                    If uniqueVars.Add(var) Then allVars.Add(var)
                Next
                ' Add the summary variables
                For Each var In summaryVars
                    If uniqueVars.Add(var) Then allVars.Add(var)
                Next

                ' Format the col_name parameter as a flat c() vector
                Dim colNameResult As String = "c(" & String.Join(",", allVars.Select(Function(v) """" & v.Trim() & """")) & ")"
                clsGetdataSingleFunction.AddParameter("col_name", colNameResult)

                ' Add pivot_longer to the pipeline
                clsBaseOperator.AddParameter("pivot_longer", clsRFunctionParameter:=clsPivotLongerFunction, iPosition:=1)

                ' Add arrange to the pipeline to control row order
                If newRowFactors.Count > 0 Then
                    Dim arrangeVars As String = String.Join(",", newRowFactors.Select(Function(v) v))
                    clsArrangeFunction.AddParameter("vars", arrangeVars, iPosition:=0, bIncludeArgumentName:=False)
                    clsBaseOperator.AddParameter("arrange", clsRFunctionParameter:=clsArrangeFunction, iPosition:=2)
                End If

                ' Add pivot_wider to the pipeline
                If newColFactors.Count > 0 Then
                    Dim namesFrom As String = "c(" & String.Join(",", newColFactors.Select(Function(v) """" & v & """")) & ")"
                    clsPivotWiderFunction.AddParameter("names_from", namesFrom, iPosition:=0)
                End If
                clsPivotWiderFunction.AddParameter("values_from", """value""", iPosition:=1)
                clsBaseOperator.AddParameter("pivot_wider", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=3)

                ' Add format_gt_table to the pipeline
                clsBaseOperator.AddParameter("format_table", clsRFunctionParameter:=clsFormatTableFunction, iPosition:=4)
            End If
        ElseIf rdoMultiple.Checked Then
            ' Logic for rdoMultiple using clsGetdataMultipleFunction
            Dim summaryVars As String() = cleanVars(ucrReceiverMultipleVariablesMul.GetVariableNames(False))

            ' Check receiver states
            Dim hasRowFactor As Boolean = Not ucrReceiverMultipleRowFactors.IsEmpty
            Dim hasColFactor As Boolean = Not ucrReceiverMultipleColFactor.IsEmpty

            ' Get the position of the summary variables
            Dim summaryPosition As Integer = ucrNudPosition.Value

            ' Create a new RFunction for pivot_longer
            Dim clsPivotLongerFunction As New RFunction
            clsPivotLongerFunction.SetPackageName("tidyr")
            clsPivotLongerFunction.SetRCommand("pivot_longer")
            clsPivotLongerFunction.AddParameter("cols", "c(" & String.Join(",", summaryVars.Select(Function(v) """" & v & """")) & ")", iPosition:=0)
            clsPivotLongerFunction.AddParameter("names_to", """summary_type""", iPosition:=1)
            clsPivotLongerFunction.AddParameter("values_to", """value""", iPosition:=2)

            ' Create a new RFunction for arrange
            Dim clsArrangeFunction As New RFunction
            clsArrangeFunction.SetPackageName("dplyr")
            clsArrangeFunction.SetRCommand("arrange")

            If hasColFactor Or hasRowFactor Then
                ' Get variable names from receivers (only if not empty)
                Dim rowFactorVars As String = If(hasRowFactor, ucrReceiverMultipleRowFactors.GetVariableNames(False), "")
                Dim colFactorVars As String = If(hasColFactor, ucrReceiverMultipleColFactor.GetVariableNames(False), "")

                ' Get cleaned variable arrays
                Dim colFactorList As String() = cleanVars(colFactorVars)
                Dim rowFactorList As String() = cleanVars(rowFactorVars)

                ' Define the factors in their default order (without summary variables)
                Dim rowFactors As New List(Of String)
                Dim colFactors As New List(Of String)(colFactorList)

                ' If row factors are empty, use column factors for row ordering
                If hasRowFactor Then
                    rowFactors.AddRange(rowFactorList)
                ElseIf hasColFactor Then
                    rowFactors.AddRange(colFactorList)
                End If

                ' Adjust the row and column factors based on the summary position
                Dim newRowFactors As New List(Of String)
                Dim newColFactors As New List(Of String)

                ' Position 1: Summary variables are the first row factor
                If summaryPosition = 1 Then
                    newRowFactors.Add("summary_type")
                    newRowFactors.AddRange(rowFactors)
                    newColFactors.AddRange(colFactors)
                    ' Position 2: Summary variables come after the first row factor
                ElseIf summaryPosition = 2 Then
                    If rowFactors.Count >= 1 Then newRowFactors.Add(rowFactors(0))
                    newRowFactors.Add("summary_type")
                    If rowFactors.Count > 1 Then newRowFactors.AddRange(rowFactors.Skip(1))
                    newColFactors.AddRange(colFactors)
                    ' Position 3: Summary variables come after all row factors
                ElseIf summaryPosition = 3 Then
                    newRowFactors.AddRange(rowFactors)
                    newRowFactors.Add("summary_type")
                    newColFactors.AddRange(colFactors)
                    ' Position 4: Summary variables act as a second column factor
                ElseIf summaryPosition = 4 Then
                    newRowFactors.AddRange(rowFactors)
                    newColFactors.AddRange(colFactors)
                    newColFactors.Add("summary_type")
                End If

                ' Combine all variables for col_name (all variables involved in the pivot)
                Dim allVars As New List(Of String)
                Dim uniqueVars As New HashSet(Of String)

                ' Add row factors and column factors (excluding summary_type, which is added by pivot_longer)
                For Each var In rowFactors
                    If uniqueVars.Add(var) Then allVars.Add(var)
                Next
                For Each var In colFactors
                    If uniqueVars.Add(var) Then allVars.Add(var)
                Next
                ' Add the summary variables
                For Each var In summaryVars
                    If uniqueVars.Add(var) Then allVars.Add(var)
                Next

                ' Format the col_name parameter as a flat c() vector
                Dim colNameResult As String = "c(" & String.Join(",", allVars.Select(Function(v) """" & v.Trim() & """")) & ")"
                clsGetdataMultipleFunction.AddParameter("col_name", colNameResult)

                ' Add pivot_longer to the pipeline
                clsBaseOperator.AddParameter("pivot_longer", clsRFunctionParameter:=clsPivotLongerFunction, iPosition:=1)

                ' Add arrange to the pipeline to control row order
                If newRowFactors.Count > 0 Then
                    Dim arrangeVars As String = String.Join(",", newRowFactors.Select(Function(v) v))
                    clsArrangeFunction.AddParameter("vars", arrangeVars, iPosition:=0, bIncludeArgumentName:=False)
                    clsBaseOperator.AddParameter("arrange", clsRFunctionParameter:=clsArrangeFunction, iPosition:=2)
                End If

                ' Add pivot_wider to the pipeline
                If newColFactors.Count > 0 Then
                    Dim namesFrom As String = "c(" & String.Join(",", newColFactors.Select(Function(v) """" & v & """")) & ")"
                    clsPivotWiderFunction.AddParameter("names_from", namesFrom, iPosition:=0)
                End If
                clsPivotWiderFunction.AddParameter("values_from", """value""", iPosition:=1)
                clsBaseOperator.AddParameter("pivot_wider", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=3)

                ' Add format_gt_table to the pipeline
                clsBaseOperator.AddParameter("format_table", clsRFunctionParameter:=clsFormatTableFunction, iPosition:=4)
            End If
        End If
    End Sub

    'Private Sub Updateparameter()
    '    If rdoSingle.Checked Then
    '        clsGetdataFunction.RemoveParameterByName("col_name")
    '        ' Helper function to clean and split variable strings
    '        Dim cleanVars As Func(Of String, String()) = Function(varString)
    '                                                         If String.IsNullOrEmpty(varString) Then Return New String() {}
    '                                                         Dim cleaned As String = varString.Replace("c(", "").Replace(")", "").Trim()
    '                                                         Return cleaned.Split(","c).Select(Function(v) v.Trim()).ToArray()
    '                                                     End Function

    '        ' Check receiver states
    '        Dim hasRowFactor As Boolean = Not ucrReceiverMultipleColFactor.IsEmpty
    '        Dim hasColFactor As Boolean = Not ucrReceiverMultipleRowFactors.IsEmpty

    ' Get the position of the summary variables
    'Dim summaryPosition As Integer = ucrNudPosition.Value

    ' Define the summary variables (hard-coded for this example)
    '' Dim summaryVars As String() = {"min_yield", "mean_yield", "max_yield"}

    ' Create a new RFunction for pivot_longer
    ' Dim clsPivotLongerFunction As New RFunction
    'clsPivotLongerFunction.SetPackageName("tidyr")
    'clsPivotLongerFunction.SetRCommand("pivot_longer")
    'clsPivotLongerFunction.AddParameter("cols", ucrReceiverSingleVariable.GetVariableNames(False), iPosition:=0)
    'clsPivotLongerFunction.AddParameter("names_to", Chr(34) & "summary_type" & Chr(34), iPosition:=1)
    'clsPivotLongerFunction.AddParameter("values_to", Chr(34) & "value" & Chr(34), iPosition:=2)

    '        If hasColFactor Or hasRowFactor Then
    '            ' Get variable names from receivers (only if not empty)
    '            Dim rowFactorVars As String = If(hasRowFactor, ucrReceiverMultipleColFactor.GetVariableNames(False), "")
    '            Dim colFactorVars As String = If(hasColFactor, ucrReceiverMultipleRowFactors.GetVariableNames(False), "")
    '            Dim singleVar As String = ucrReceiverSingleVariable.GetVariableNames(False)

    '            ' Get cleaned variable arrays
    '            Dim colFactorList As String() = cleanVars(colFactorVars)
    '            Dim rowFactorList As String() = cleanVars(rowFactorVars)
    '            Dim singleVarList As String() = cleanVars(singleVar)

    '            ' Combine all variables into a list while preserving order and removing duplicates
    '            Dim allVars As New List(Of String)
    '            Dim uniqueVars As New HashSet(Of String)

    '            ' Add variables in order: colFactor, rowFactor, singleVar
    '            If hasColFactor Then
    '                For Each var In colFactorList
    '                    If uniqueVars.Add(var) Then allVars.Add(var)
    '                Next
    '            End If
    '            If hasRowFactor Then
    '                For Each var In rowFactorList
    '                    If uniqueVars.Add(var) Then allVars.Add(var)
    '                Next
    '            End If
    '            For Each var In singleVarList
    '                If uniqueVars.Add(var) Then allVars.Add(var)
    '            Next

    '            ' Format the final string as a flat c() vector
    '            Dim result As String = "c(" & String.Join(",", allVars.Select(Function(v) """" & v.Trim() & """")) & ")"
    '            clsGetdataSingleFunction.AddParameter("col_name", result)

    '            ' Set names_from parameter based on conditions
    '            If hasRowFactor Then
    '                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverMultipleColFactor.GetVariableNames(), iPosition:=0)
    '            ElseIf hasColFactor Then
    '                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverMultipleRowFactors.GetVariableNames(), iPosition:=0)
    '            End If
    '        Else
    '            ' Clear parameters if both colFactor and rowFactor are empty
    '            clsPivotWiderFunction.RemoveParameterByName("names_from")
    '            clsGetdataSingleFunction.RemoveParameterByName("col_name")
    '        End If
    '    ElseIf rdoMultiple.Checked Then
    '        clsGetdataFunction.RemoveParameterByName("col_name")
    '        ' Helper function to clean and split variable strings
    '        Dim cleanVars As Func(Of String, String()) = Function(varString)
    '                                                         If String.IsNullOrEmpty(varString) Then Return New String() {}
    '                                                         Dim cleaned As String = varString.Replace("c(", "").Replace(")", "").Trim()
    '                                                         Return cleaned.Split(","c).Select(Function(v) v.Trim()).ToArray()
    '                                                     End Function

    '        ' Check receiver states
    '        Dim hasRowFactor As Boolean = Not ucrReceiverMultipleColFactor.IsEmpty
    '        Dim hasColFactor As Boolean = Not ucrReceiverMultipleRowFactors.IsEmpty

    '        If hasColFactor Or hasRowFactor Then
    '            ' Get variable names from receivers (only if not empty)
    '            Dim rowFactorVars As String = If(hasRowFactor, ucrReceiverMultipleColFactor.GetVariableNames(False), "")
    '            Dim colFactorVars As String = If(hasColFactor, ucrReceiverMultipleRowFactors.GetVariableNames(False), "")
    '            Dim multiVar As String = ucrReceiverMultipleVariablesMul.GetVariableNames(False)

    '            ' Get cleaned variable arrays
    '            Dim colFactorList As String() = cleanVars(colFactorVars)
    '            Dim rowFactorList As String() = cleanVars(rowFactorVars)
    '            Dim multiVarList As String() = cleanVars(multiVar)

    '            ' Combine all variables into a list while preserving order and removing duplicates
    '            Dim allVars As New List(Of String)
    '            Dim uniqueVars As New HashSet(Of String)

    '            ' Add variables in order: colFactor, rowFactor, singleVar
    '            If hasColFactor Then
    '                For Each var In colFactorList
    '                    If uniqueVars.Add(var) Then allVars.Add(var)
    '                Next
    '            End If
    '            If hasRowFactor Then
    '                For Each var In rowFactorList
    '                    If uniqueVars.Add(var) Then allVars.Add(var)
    '                Next
    '            End If
    '            For Each var In multiVarList
    '                If uniqueVars.Add(var) Then allVars.Add(var)
    '            Next

    '            ' Format the final string as a flat c() vector
    '            Dim result As String = "c(" & String.Join(",", allVars.Select(Function(v) """" & v.Trim() & """")) & ")"
    '            clsGetdataMultipleFunction.AddParameter("col_name", result)

    '            ' Set names_from parameter based on conditions
    '            If hasRowFactor Then
    '                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverMultipleColFactor.GetVariableNames(), iPosition:=0)
    '            ElseIf hasColFactor Then
    '                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverMultipleRowFactors.GetVariableNames(), iPosition:=0)
    '            End If
    '        Else
    '            ' Clear parameters if both colFactor and rowFactor are empty
    '            clsPivotWiderFunction.RemoveParameterByName("names_from")
    '            clsGetdataMultipleFunction.RemoveParameterByName("col_name")
    '        End If
    '    Else
    '        clsGetdataSingleFunction.RemoveParameterByName("col_name")
    '        clsPivotWiderFunction.RemoveParameterByName("names_from")
    '        clsGetdataMultipleFunction.RemoveParameterByName("col_name")
    '    End If
    'End Sub

    Private Sub AddRemoveHead()
        If ucrChkPreview.Checked Then
            clsBaseOperator.AddParameter(strParameterName:="head", clsRFunctionParameter:=clsHeadRFunction, iPosition:=1, bIncludeArgumentName:=False)
        Else
            clsBaseOperator.RemoveParameterByName("head")
        End If
    End Sub

    Private Sub ucrChkPreview_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkPreview.ControlValueChanged
        AddRemoveHead()
    End Sub

    Private Sub btnTitleFormat_Click(sender As Object, e As EventArgs) Handles btnTitleStyle.Click
        Dim clsListStyleRFunction As RFunction = clsTablesUtils.ShowStyleSubDialog(Me.ParentForm, clsTitleStyleRFunction)
        If clsListStyleRFunction Is Nothing Then
            Exit Sub
        End If

        clsTitleStyleRFunction = clsTablesUtils.GetNewStyleRFunction(clsListStyleRFunction, clsCellsTitleRFunction)
        If clsTitleStyleRFunction IsNot Nothing Then
            clsBaseOperator.AddParameter(strParameterName:="tab_style_for_title_param", clsRFunctionParameter:=clsTitleStyleRFunction)
        End If
    End Sub

    Private Sub ucrInputControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputTitle.ControlContentsChanged, ucrInputTitleFooter.ControlContentsChanged
        ucrInputTitleFooter.Enabled = Not ucrInputTitle.IsEmpty()
        If Not ucrInputTitle.IsEmpty Then
            clsBaseOperator.AddParameter("theme_Header", clsRFunctionParameter:=clsHeaderRFunction)
        Else
            clsBaseOperator.RemoveParameterByName("theme_Header")
        End If
        If Not ucrInputTitleFooter.IsEmpty Then
            clsBaseOperator.AddParameter("theme_footer", clsRFunctionParameter:=clsTitleFooterRFunction)
        Else
            clsBaseOperator.RemoveParameterByName("theme_footer")
        End If
    End Sub

    Private Sub ucrChkSelectTheme_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrChkSelectTheme.ControlValueChanged
        AddRemoveThemes()
    End Sub

    Private Sub AddRemoveThemes()
        If ucrChkSelectTheme.Checked Then
            ucrCboSelectThemes.Visible = True
            clsBaseOperator.AddParameter("theme_format", clsRFunctionParameter:=clsThemeRFunction)
        Else
            clsBaseOperator.RemoveParameterByName("theme_format")
            ucrCboSelectThemes.Visible = False
            clsThemeRFunction.ClearParameters()
        End If
    End Sub

    Private Sub ucrCboSelectThemes_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrCboSelectThemes.ControlValueChanged
        AddRemoveThemes()
        If clsThemeRFunction Is Nothing Then
            Exit Sub
        End If
        Dim strCommand As String = ""
        Select Case ucrCboSelectThemes.GetText
            Case "Dark Theme"
                strCommand = "gt_theme_dark"
            Case "538 Theme"
                strCommand = "gt_theme_538"
            Case "Dot Matrix Theme"
                strCommand = "gt_theme_dot_matrix"
            Case "Espn Theme"
                strCommand = "gt_theme_espn"
            Case "Excel Theme"
                strCommand = "gt_theme_excel"
            Case "Guardian Theme"
                strCommand = "gt_theme_guardian"
            Case "NY Times Theme"
                strCommand = "gt_theme_nytimes"
            Case "PFF Theme"
                strCommand = "gt_theme_pff"
        End Select

        clsThemeRFunction.SetRCommand(strCommand)
    End Sub

    Private Sub ucrSelectorCols_DataFrameChanged() Handles ucrSelectorCols.DataFrameChanged
        clsGetdataFunction.AddParameter("data_name", Chr(34) & ucrSelectorCols.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetdataSingleFunction.AddParameter("data_name", Chr(34) & ucrSelectorCols.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
        clsGetdataMultipleFunction.AddParameter("data_name", Chr(34) & ucrSelectorCols.ucrAvailableDataFrames.cboAvailableDataFrames.Text & Chr(34), iPosition:=0)
    End Sub

    Private Sub ucrReceiverMultipleRowFactors_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleRowFactors.ControlValueChanged, ucrReceiverMultipleColFactor.ControlValueChanged
        Updateparameter()
    End Sub

    Private Sub ucrNudPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudPosition.ControlValueChanged
        Updateparameter()
    End Sub
End Class