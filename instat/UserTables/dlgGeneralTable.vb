Imports instat.Translations

Public Class dlgGeneralTable
    Private clsBaseOperator As New ROperator
    Private clsSpannerFunction, clsEvererythingFunction, clsPivotLongerFunction, clsSelectFunction, clsGetdataFunction, clsGetdataMultipleFunction, clsGetdataSingleFunction, clsPivotWiderMulFunction, clsPivotWiderFunction, clsFormatTableFunction, clsHeadRFunction, clsHeaderRFunction, clsCellsTitleRFunction, clsTitleStyleRFunction, clsTitleFooterRFunction, clsGtRFunction, clsThemeRFunction, clsDummyFunction As New RFunction

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
        DialogueSize()
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

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged, ucrReceiverMultipleRowFactors.ControlContentsChanged, ucrReceiverMultipleVariablesMul.ControlContentsChanged, ucrReceiverSingleVariable.ControlContentsChanged, ucrPnlOptions.ControlContentsChanged, ucrReceiverMultipleColFactor.ControlContentsChanged
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

        ucrPnlPosition.AddRadioButton(rdoAscolumn)
        ucrPnlPosition.AddRadioButton(rdoAsrow)

        ucrPnlPosition.AddParameterValuesCondition(rdoAscolumn, "check", "column")
        ucrPnlPosition.AddParameterValuesCondition(rdoAsrow, "check", "row")

        ucrPnlPosition.AddToLinkedControls(ucrNudColumn, {rdoAscolumn}, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlPosition.AddToLinkedControls(ucrNudRow, {rdoAsrow}, bNewLinkedHideIfParameterMissing:=True)

        ucrPnlOptions.AddParameterValuesCondition(rdoDataFrame, "checked", "Data Frame")
        ucrPnlOptions.AddParameterValuesCondition(rdoSingle, "checked", "Single")
        ucrPnlOptions.AddParameterValuesCondition(rdoMultiple, "checked", "Multiple")

        ucrPnlOptions.AddToLinkedControls({ucrChkPreview, ucrReceiverMultipleCols}, {rdoDataFrame}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSingleVariable}, {rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverMultipleVariablesMul, ucrPnlPosition}, {rdoMultiple}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
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
        DialogueSize()
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
        clsPivotWiderMulFunction = New RFunction
        clsFormatTableFunction = New RFunction
        clsGetdataFunction = New RFunction
        clsGetdataSingleFunction = New RFunction
        clsGetdataMultipleFunction = New RFunction
        clsSelectFunction = New RFunction
        clsPivotLongerFunction = New RFunction
        clsEvererythingFunction = New RFunction
        clsSpannerFunction = New RFunction

        ucrSelectorCols.Reset()
        ucrSaveTable.Reset()
        ucrReceiverMultipleRowFactors.SetMeAsReceiver()
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
        clsDummyFunction.AddParameter("check", "column", iPosition:=2)

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
        clsPivotWiderFunction.AddParameter("names_sep", Chr(34) & "__" & Chr(34), iPosition:=2)

        clsPivotWiderMulFunction.SetPackageName("tidyr")
        clsPivotWiderMulFunction.SetRCommand("pivot_wider")
        clsPivotWiderMulFunction.AddParameter("names_sep", Chr(34) & "__" & Chr(34), iPosition:=2)

        clsFormatTableFunction.SetRCommand("format_gt_table")

        clsPivotLongerFunction.SetPackageName("tidyr")
        clsPivotLongerFunction.SetRCommand("pivot_longer")
        clsPivotLongerFunction.AddParameter("names_to", Chr(34) & "summary_type" & Chr(34), iPosition:=1)
        clsPivotLongerFunction.AddParameter(" values_to", Chr(34) & "value" & Chr(34), iPosition:=2)

        clsSelectFunction.SetPackageName("dplyr")
        clsSelectFunction.SetRCommand("select")
        clsSelectFunction.AddParameter("everything", clsRFunctionParameter:=clsEvererythingFunction, iPosition:=5, bIncludeArgumentName:=False)

        clsEvererythingFunction.SetPackageName("tidyselect")
        clsEvererythingFunction.SetRCommand("everything")

        clsSpannerFunction.SetPackageName("gt")
        clsSpannerFunction.SetRCommand("tab_spanner_delim")
        clsSpannerFunction.AddParameter("delim", Chr(34) & "__" & Chr(34), iPosition:=0)


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
        MinMaxValRowVariable()
        MinMaxValVariable()
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
            ucrNudRow.SetRCode(clsSelectFunction, bReset)
            ucrNudColumn.SetRCode(clsPivotWiderMulFunction, bReset)
            ucrPnlPosition.SetRCode(clsDummyFunction, bReset)
        End If
        ucrReceiverMultipleCols.SetRCode(clsGetdataFunction, bReset)
        Updateparameter()
        AddRemoveThemes()
        AddingSummaryType()
    End Sub

    Private Sub TestOKEnabled()
        If rdoDataFrame.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverMultipleCols.IsEmpty AndAlso ucrSaveTable.IsComplete)
        ElseIf rdoSingle.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverSingleVariable.IsEmpty AndAlso ucrSaveTable.IsComplete AndAlso (Not ucrReceiverMultipleColFactor.IsEmpty OrElse Not ucrReceiverMultipleRowFactors.IsEmpty))
        Else
            ucrBase.OKEnabled(Not ucrReceiverMultipleVariablesMul.IsEmpty AndAlso ucrSaveTable.IsComplete AndAlso (Not ucrReceiverMultipleColFactor.IsEmpty OrElse Not ucrReceiverMultipleRowFactors.IsEmpty))
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrReceiverSingleVariable.ControlValueChanged, ucrReceiverMultipleVariablesMul.ControlValueChanged, ucrReceiverMultipleCols.ControlValueChanged
        AddRemovePivotwider()
        AddRemoveThemes()
        AddingSummaryType()
        HidePosition()
        AddRemovespanner()
        AddRemoveSelect()
        DialogueSize()
    End Sub

    Private Sub AddRemovePivotwider()
        clsBaseOperator.RemoveParameterByName("get_columns_from_data")
        clsBaseOperator.RemoveParameterByName("pivot_wider")
        clsBaseOperator.RemoveParameterByName("pivot_wider_mul")
        clsBaseOperator.RemoveParameterByName("pivot_longer")
        clsBaseOperator.RemoveParameterByName("format_table")

        If rdoSingle.Checked Then
            clsBaseOperator.RemoveParameterByName("head")
            clsBaseOperator.RemoveParameterByName("gt")
            Updateparameter()
            clsPivotWiderFunction.AddParameter("values_from", ucrReceiverSingleVariable.GetVariableNames(False), iPosition:=1)
            clsBaseOperator.AddParameter("get_columns_from_data", clsRFunctionParameter:=clsGetdataSingleFunction, iPosition:=0, bIncludeArgumentName:=False)
            If Not ucrReceiverMultipleColFactor.IsEmpty Then
                clsBaseOperator.AddParameter("pivot_wider", clsRFunctionParameter:=clsPivotWiderFunction, iPosition:=3)
            Else
                clsBaseOperator.RemoveParameterByName("pivot_wider")
            End If
            clsBaseOperator.AddParameter("format_table", clsRFunctionParameter:=clsFormatTableFunction, iPosition:=4)
            ElseIf rdoMultiple.Checked Then
                clsBaseOperator.RemoveParameterByName("head")
                clsBaseOperator.RemoveParameterByName("gt")
                Updateparameter()
                clsPivotLongerFunction.AddParameter("cols", ucrReceiverMultipleVariablesMul.GetVariableNames(), iPosition:=0)
                clsPivotWiderMulFunction.AddParameter("values_from", Chr(34) & "value" & Chr(34), iPosition:=3)
                clsBaseOperator.AddParameter("get_columns_from_data", clsRFunctionParameter:=clsGetdataMultipleFunction, iPosition:=0, bIncludeArgumentName:=False)
                clsBaseOperator.AddParameter("pivot_longer", clsRFunctionParameter:=clsPivotLongerFunction, iPosition:=3)
                clsBaseOperator.AddParameter("pivot_wider_mul", clsRFunctionParameter:=clsPivotWiderMulFunction, iPosition:=7)
                clsBaseOperator.AddParameter("format_table", clsRFunctionParameter:=clsFormatTableFunction, iPosition:=8)
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

    Private Sub DialogueSize()
        If rdoDataFrame.Checked Then
            Me.Size = New Size(492, 614)
            Me.grpBoxTitle.Location = New Size(7, 364)
            Me.ucrSaveTable.Location = New Size(9, 480)
            Me.ucrBase.Location = New Point(9, 515)
        ElseIf rdoSingle.Checked Then
            Me.Size = New Size(492, 574)
            Me.grpBoxTitle.Location = New Size(7, 340)
            Me.ucrSaveTable.Location = New Size(9, 448)
            Me.ucrBase.Location = New Point(9, 478)
        Else
            Me.Size = New Size(492, 629)
            Me.grpBoxTitle.Location = New Size(7, 401)
            Me.ucrSaveTable.Location = New Size(9, 508)
            Me.ucrBase.Location = New Point(9, 536)
        End If
    End Sub

    Private Sub HidePosition()
        grpPosition.Visible = rdoMultiple.Checked
    End Sub

    Private Sub AddingSummaryType()
        Dim lstRowVars As List(Of String) = ucrReceiverMultipleRowFactors.GetVariableNamesAsList()
        Dim lstColVars As List(Of String) = ucrReceiverMultipleColFactor.GetVariableNamesAsList()
        Dim ipositionVarCols As Integer = ucrNudColumn.Value
        Dim ipositionVarRows As Integer = ucrNudRow.Value

        ' Ensure variables are wrapped in double quotes
        lstRowVars = lstRowVars.Select(Function(x) """" & x & """").ToList()
        lstColVars = lstColVars.Select(Function(x) """" & x & """").ToList()

        ' If rdoMultiple is checked, insert "variable" correctly based on rdoCols and rdoRows
        If rdoMultiple.Checked Then
            If rdoAscolumn.Checked Then
                ' "variable" should be added to cols at the specified position
                If ipositionVarCols <= lstColVars.Count Then
                    lstColVars.Insert(Math.Max(0, ipositionVarCols - 1), """summary_type""")
                Else
                    lstColVars.Add("""summary_type""")
                End If
            ElseIf rdoAsrow.Checked Then
                ' "variable" should be added to rows at the specified position
                If ipositionVarRows <= lstRowVars.Count Then
                    lstRowVars.Insert(Math.Max(0, ipositionVarRows - 1), """summary_type""")
                Else
                    lstRowVars.Add("""summary_type""")
                End If
            End If
        End If

        ' Ensure correct formatting for rows and cols
        Dim strRowVars As String = "c(" & String.Join(", ", lstRowVars) & ")"
        Dim strColVars As String = "c(" & String.Join(", ", lstColVars) & ")"

        ' Add parameters while preventing c(c(...))
        If rdoAsrow.Checked Then
            clsPivotWiderMulFunction.AddParameter("names_from", ucrReceiverMultipleColFactor.GetVariableNames(), iPosition:=0)
            If lstRowVars.Count > 0 Then clsSelectFunction.AddParameter("rows", strRowVars, iPosition:=0, bIncludeArgumentName:=False)
        Else
            If lstColVars.Count > 0 Then clsPivotWiderMulFunction.AddParameter("names_from", strColVars, iPosition:=0)
        End If
    End Sub

    Private Sub AddRemoveSelect()
        If rdoMultiple.Checked AndAlso rdoAsrow.Checked Then
            clsBaseOperator.AddParameter("select", clsRFunctionParameter:=clsSelectFunction, iPosition:=6)
        Else
            clsBaseOperator.RemoveParameterByName("select")
        End If
    End Sub

    Private Sub AddRemovespanner()
        If rdoMultiple.Checked OrElse rdoSingle.Checked Then
            clsBaseOperator.AddParameter("spanner", clsRFunctionParameter:=clsSpannerFunction, iPosition:=9)
        Else
            clsBaseOperator.RemoveParameterByName("spanner")
        End If
    End Sub

    Private Sub MinMaxValVariable()
        Dim lstselectedCols As List(Of String) = ucrReceiverMultipleColFactor.GetVariableNamesAsList()
        Dim itotalVars As Integer = lstselectedCols.Count
        Dim idefaultPosition As Integer = itotalVars + 1

        ' Set minimum and maximum values
        ucrNudColumn.Minimum = 1
        ucrNudColumn.Maximum = idefaultPosition
        ' Set default value to one more than total row + col factors
        ucrNudColumn.Value = idefaultPosition
    End Sub

    Private Sub MinMaxValRowVariable()
        Dim lstselectedRows As List(Of String) = ucrReceiverMultipleRowFactors.GetVariableNamesAsList()
        Dim itotalVars As Integer = lstselectedRows.Count
        Dim idefaultPosition As Integer = itotalVars + 1

        ' Set minimum and maximum values
        ucrNudRow.Minimum = 1
        ucrNudRow.Maximum = idefaultPosition
        ' Set default value to one more than total row + col factors
        ucrNudRow.Value = idefaultPosition
    End Sub

    Private Sub Updateparameter()
        If rdoSingle.Checked Then
            'Collect variables from receivers
            Dim strcolFactorVarsSingle As String = ucrReceiverMultipleColFactor.GetVariableNames()
            Dim strrowFactorVarsSingle As String = ucrReceiverMultipleRowFactors.GetVariableNames()
            Dim strsingleVarSingle As String = ucrReceiverSingleVariable.GetVariableNames()
            Dim strformattedstrcolFactorVarsSingle As String = strcolFactorVarsSingle.Replace("c(", "").Replace(")", "")
            Dim strformattedstrrowFactorVarsSingle As String = strrowFactorVarsSingle.Replace("c(", "").Replace(")", "")

            If Not ucrReceiverMultipleColFactor.IsEmpty Then
                If Not ucrReceiverMultipleRowFactors.IsEmpty Then
                    clsGetdataSingleFunction.AddParameter("col_name", "c(" & strformattedstrcolFactorVarsSingle & ", " & strformattedstrrowFactorVarsSingle & ", " & strsingleVarSingle & ")")
                Else
                    clsGetdataSingleFunction.AddParameter("col_name", "c(" & strformattedstrcolFactorVarsSingle & ", " & strsingleVarSingle & ")")
                End If
                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverMultipleColFactor.GetVariableNames(), iPosition:=0)
            Else
                clsGetdataSingleFunction.AddParameter("col_name", "c(" & strformattedstrrowFactorVarsSingle & ", " & strsingleVarSingle & ")")
                clsPivotWiderFunction.AddParameter("names_from", ucrReceiverMultipleRowFactors.GetVariableNames(), iPosition:=0)
            End If

        ElseIf rdoMultiple.Checked Then
            Dim strcolFactorVarsMul As String = ucrReceiverMultipleColFactor.GetVariableNames()
            Dim strrowFactorVarsMul As String = ucrReceiverMultipleRowFactors.GetVariableNames()
            Dim strVarMul As String = ucrReceiverMultipleVariablesMul.GetVariableNames()
            Dim strformattedstrcolFactorVarsMul As String = strcolFactorVarsMul.Replace("c(", "").Replace(")", "")
            Dim strformattedstrrowFactorVarsMul As String = strrowFactorVarsMul.Replace("c(", "").Replace(")", "")
            Dim strformattedstrVarMul As String = strVarMul.Replace("c(", "").Replace(")", "")

            ' Maintain original pivot and select function logic
            If Not ucrReceiverMultipleColFactor.IsEmpty Then
                If Not ucrReceiverMultipleRowFactors.IsEmpty Then
                    clsGetdataMultipleFunction.AddParameter("col_name", "c(" & strformattedstrcolFactorVarsMul & ", " & strformattedstrrowFactorVarsMul & ", " & strformattedstrVarMul & ")")
                Else
                    clsGetdataMultipleFunction.AddParameter("col_name", "c(" & strformattedstrcolFactorVarsMul & ", " & strformattedstrVarMul & ")")
                End If
                clsPivotWiderMulFunction.AddParameter("names_from", ucrReceiverMultipleColFactor.GetVariableNames(), iPosition:=0)
            Else
                clsGetdataMultipleFunction.AddParameter("col_name", "c(" & strformattedstrrowFactorVarsMul & ", " & strformattedstrVarMul & ")")
                clsPivotWiderMulFunction.AddParameter("names_from", ucrReceiverMultipleRowFactors.GetVariableNames(), iPosition:=0)
            End If
        Else
            ' Default case
            clsBaseOperator.RemoveParameterByName("pivot_wider")
            clsBaseOperator.RemoveParameterByName("pivot_wider_mul")
            clsGetdataSingleFunction.RemoveParameterByName("col_name")
            clsGetdataMultipleFunction.RemoveParameterByName("col_name")
            clsPivotWiderFunction.RemoveParameterByName("names_from")
            clsPivotWiderFunction.RemoveParameterByName("values_from")
            clsPivotWiderMulFunction.RemoveParameterByName("names_from")
            clsPivotWiderMulFunction.RemoveParameterByName("values_from")
        End If
    End Sub

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
        MinMaxValRowVariable()
        MinMaxValVariable()
        AddingSummaryType()
        AddRemovePivotwider()
    End Sub

    Private Sub ucrNudRow_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudRow.ControlValueChanged
        AddingSummaryType()
    End Sub

    Private Sub ucrPnlPosition_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlPosition.ControlValueChanged
        AddingSummaryType()
        MinMaxValRowVariable()
        MinMaxValVariable()
        HidePosition()
        AddRemovespanner()
        AddRemoveSelect()
    End Sub

    Private Sub ucrNudColumn_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrNudColumn.ControlValueChanged
        AddingSummaryType()
    End Sub
End Class