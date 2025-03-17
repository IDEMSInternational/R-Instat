Imports instat.Translations

Public Class dlgGeneralTable
    Private clsBaseOperator As New ROperator
    Private clsGetdataFunction, clsGetdataSingleFunction, clsPivotWiderFunction, clsFormatTableFunction, clsHeadRFunction, clsHeaderRFunction, clsCellsTitleRFunction, clsTitleStyleRFunction, clsTitleFooterRFunction, clsGtRFunction, clsThemeRFunction, clsDummyFunction As New RFunction

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

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrReceiverMultipleCols.ControlContentsChanged, ucrReceiverMultipleColFactor.ControlContentsChanged, ucrReceiverMultipleRowFactors.ControlContentsChanged, ucrReceiverMultipleVariablesMul.ControlContentsChanged, ucrReceiverSingleVariable.ControlContentsChanged
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

        ucrPnlOptions.AddToLinkedControls({ucrInputTitle, ucrInputTitleFooter, ucrSaveTable, ucrChkSelectTheme}, {rdoDataFrame, rdoSingle, rdoMultiple}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrChkPreview, ucrReceiverMultipleCols}, {rdoDataFrame}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverSingleVariable}, {rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverMultipleVariablesMul}, {rdoMultiple}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)
        ucrPnlOptions.AddToLinkedControls({ucrReceiverMultipleColFactor, ucrReceiverMultipleRowFactors}, {rdoMultiple, rdoSingle}, bNewLinkedAddRemoveParameter:=True, bNewLinkedHideIfParameterMissing:=True)


        ucrReceiverMultipleCols.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleCols.SetParameterIsString()
        ucrReceiverMultipleCols.Selector = ucrSelectorCols
        ucrReceiverMultipleCols.SetLinkedDisplayControl(lblColumns)

        ucrReceiverMultipleRowFactors.SetParameter(New RParameter("names_from", 0))
        ucrReceiverMultipleRowFactors.SetParameterIsString()
        ucrReceiverMultipleRowFactors.Selector = ucrSelectorCols
        ucrReceiverMultipleRowFactors.strSelectorHeading = "Factors"
        ucrReceiverMultipleRowFactors.SetIncludedDataTypes({"factor"}, bStrict:=True)
        ucrReceiverMultipleRowFactors.SetLinkedDisplayControl(lblRowFactor)

        ucrReceiverMultipleColFactor.SetParameter(New RParameter("col_names", 1))
        ucrReceiverMultipleColFactor.SetParameterIsString()
        ucrReceiverMultipleColFactor.Selector = ucrSelectorCols
        ucrReceiverMultipleColFactor.strSelectorHeading = "Factors"
        ucrReceiverMultipleColFactor.SetIncludedDataTypes({"factor"}, bStrict:=True)
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

        ucrChkSelectTheme.Checked = True
        ucrChkSelectTheme.SetText("Theme")
        ucrCboSelectThemes.SetItems({"None", "Dark Theme", "538 Theme", "Dot Matrix Theme", "Espn Theme", "Excel Theme", "Guardian Theme", "NY Times Theme", "PFF Theme"})
        ucrCboSelectThemes.SetDropDownStyleAsNonEditable()

        ucrBase.clsRsyntax.bExcludeAssignedFunctionOutput = False
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

        clsDummyFunction.AddParameter("checked", "Single", iPosition:=0)

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
        ucrReceiverMultipleCols.SetRCode(clsGetdataFunction, bReset)
        ucrSaveTable.SetRCode(clsBaseOperator, bReset)
        ucrInputTitle.SetRCode(clsHeaderRFunction, True, bCloneIfNeeded:=True)
        ucrInputTitleFooter.SetRCode(clsTitleFooterRFunction, True, bCloneIfNeeded:=True)
        If bReset Then
            ucrPnlOptions.SetRCode(clsDummyFunction, bReset)
            ucrChkPreview.SetRCode(clsBaseOperator, bReset)
            ucrNudPreview.SetRCode(clsHeadRFunction, bReset)
        End If
        ucrReceiverMultipleRowFactors.SetRCode(clsPivotWiderFunction, bReset)
        ucrReceiverSingleVariable.SetRCode(clsPivotWiderFunction, bReset)
        ucrReceiverMultipleColFactor.SetRCode(clsGetdataSingleFunction, bReset)
        ucrReceiverMultipleVariablesMul.SetRCode(clsPivotWiderFunction, bReset)
    End Sub

    Private Sub TestOKEnabled()
        If rdoDataFrame.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverMultipleCols.IsEmpty AndAlso ucrSaveTable.IsComplete)
        ElseIf rdoSingle.Checked Then
            ucrBase.OKEnabled(Not ucrReceiverMultipleColFactor.IsEmpty AndAlso Not ucrReceiverMultipleRowFactors.IsEmpty AndAlso Not ucrReceiverSingleVariable.IsEmpty AndAlso ucrSaveTable.IsComplete)
        Else
            ucrBase.OKEnabled(Not ucrReceiverMultipleColFactor.IsEmpty AndAlso Not ucrReceiverMultipleRowFactors.IsEmpty AndAlso ucrSaveTable.IsComplete)
        End If
    End Sub

    Private Sub ucrPnlOptions_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrPnlOptions.ControlValueChanged, ucrReceiverSingleVariable.ControlValueChanged
        AddRemovePivotwider()
    End Sub

    Private Sub AddRemovePivotwider()
        clsBaseOperator.RemoveParameterByName("get_columns_from_data")
        clsBaseOperator.RemoveParameterByName("pivot_wider")
        clsBaseOperator.RemoveParameterByName("format_table")

        If rdoSingle.Checked OrElse rdoMultiple.Checked Then
            clsBaseOperator.RemoveParameterByName("head")
            clsBaseOperator.RemoveParameterByName("gt")
            ucrReceiverMultipleRowFactors.SetMeAsReceiver()
            clsPivotWiderFunction.AddParameter("values_from", ucrReceiverSingleVariable.GetVariableNames(False), iPosition:=1)
            clsBaseOperator.AddParameter("get_columns_from_data", clsRFunctionParameter:=clsGetdataSingleFunction, iPosition:=0, bIncludeArgumentName:=False)
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
    End Sub
End Class