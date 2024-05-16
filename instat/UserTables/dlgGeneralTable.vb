Imports instat.Translations

Public Class dlgGeneralTable
    Private clsBaseOperator As New ROperator
    Private clsHeaderRFunction, clsTitleRFunction, clsSubtitleRFunction As New RFunction

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
    End Sub

    Private Sub ucrInputHeaderTitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderTitle.ControlValueChanged
        'If no title providded, then just remove the tab_header command from the operator
        If ucrInputHeaderTitle.IsEmpty() Then
            clsBaseOperator.RemoveParameterByName("tab_header_func_name")
        Else
            clsBaseOperator.AddParameter("tab_header_func_name", clsRFunctionParameter:=clsHeaderRFunction, iPosition:=2, bIncludeArgumentName:=False)
        End If
    End Sub

    Private Sub ucrInputHeaderSubtitle_ControlValueChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderSubtitle.ControlValueChanged
        ' Subtitle is optional, so remove the parameter when empty
        If ucrInputHeaderSubtitle.IsEmpty() Then
            clsHeaderRFunction.RemoveParameterByName("subtitle")
        Else
            clsHeaderRFunction.AddParameter("subtitle", clsRFunctionParameter:=clsSubtitleRFunction, iPosition:=1)
        End If
    End Sub

    Private Sub btnHeaderTitleFormat_Click(sender As Object, e As EventArgs) Handles btnHeaderTitleFormat.Click
        clsTablesUtils.ShowTextFormatSubDialog(Me, clsTitleRFunction)
    End Sub

    Private Sub btnHeaderSubtitleFormat_Click(sender As Object, e As EventArgs) Handles btnHeaderSubTitleFormat.Click
        clsTablesUtils.ShowTextFormatSubDialog(Me, clsSubtitleRFunction)
    End Sub

    Private Sub btnMoreOptions_Click(sender As Object, e As EventArgs) Handles btnMoreOptions.Click
        sdgTableOptions.Setup(clsBaseOperator)
        sdgTableOptions.ShowDialog(Me)
    End Sub

    Private Sub ucrControls_ControlContentsChanged(ucrChangedControl As ucrCore) Handles ucrInputHeaderTitle.ControlContentsChanged, ucrInputHeaderSubtitle.ControlContentsChanged, ucrReceiverMultipleCols.ControlContentsChanged
        TestOKEnabled()
    End Sub

    Private Sub ucrBase_ClickReset(sender As Object, e As EventArgs) Handles ucrBase.ClickReset
        SetDefaults()
        SetRCodeForControls(True)
        TestOKEnabled()
    End Sub


    Private Sub initialiseDialog()

        ucrInputHeaderTitle.SetParameter(New RParameter("title_text_param", 0, bNewIncludeArgumentName:=False))
        ucrInputHeaderTitle.SetLinkedDisplayControl(New List(Of Control)({lblHeaderTitle, btnHeaderTitleFormat}))

        ucrInputHeaderSubtitle.SetParameter(New RParameter("subtitle_text_param", 0, bNewIncludeArgumentName:=False))
        ucrInputHeaderSubtitle.SetLinkedDisplayControl(New List(Of Control)({lblHeaderSubtitle, btnHeaderSubTitleFormat}))

        ucrReceiverMultipleCols.SetParameter(New RParameter("df_columns_to_use_param", 0, bNewIncludeArgumentName:=False))
        ucrReceiverMultipleCols.SetParameterIsRFunction()
        ucrReceiverMultipleCols.Selector = ucrSelectorCols
        ucrReceiverMultipleCols.SetLinkedDisplayControl(lblColumns)

        ucrSaveTable.SetPrefix("table")
        ucrSaveTable.SetSaveType(RObjectTypeLabel.Table, strRObjectFormat:=RObjectFormat.Html)
        ucrSaveTable.SetDataFrameSelector(ucrSelectorCols.ucrAvailableDataFrames)
        ucrSaveTable.SetIsComboBox()
        ucrSaveTable.SetCheckBoxText("Save Table")
        ucrSaveTable.SetAssignToIfUncheckedValue("last_table")
    End Sub


    Private Sub SetDefaults()
        clsBaseOperator = New ROperator

        clsHeaderRFunction = New RFunction
        clsTitleRFunction = New RFunction
        clsSubtitleRFunction = New RFunction

        ucrSelectorCols.Reset()
        ucrReceiverMultipleCols.SetMeAsReceiver()
        ucrSaveTable.Reset()

        clsBaseOperator.SetOperation("%>%")
        clsBaseOperator.bBrackets = False

        Dim clsGtFunction As New RFunction
        clsGtFunction.SetPackageName("gt")
        clsGtFunction.SetRCommand("gt")
        clsBaseOperator.AddParameter(strParameterName:="gt_funct_param", clsRFunctionParameter:=clsGtFunction, iPosition:=1, bIncludeArgumentName:=False)

        '-----------------------------------------
        ' HEADER  
        clsHeaderRFunction.SetPackageName("gt")
        clsHeaderRFunction.SetRCommand("tab_header")

        ' Title related R functions
        clsTitleRFunction = clsTablesUtils.GetNewHtmlSpanRFunction()
        clsHeaderRFunction.AddParameter("title", clsRFunctionParameter:=clsTitleRFunction, iPosition:=0)

        ' Subtitle related R functions
        clsSubtitleRFunction = clsTablesUtils.GetNewHtmlSpanRFunction()

        '-----------------------------------------

        ucrBase.clsRsyntax.SetBaseROperator(clsBaseOperator)

    End Sub



    Private Sub SetRCodeForControls(bReset As Boolean)

        ucrInputHeaderTitle.SetRCode(clsTitleRFunction, bReset)
        ucrInputHeaderSubtitle.SetRCode(clsSubtitleRFunction, bReset)
        ucrReceiverMultipleCols.SetRCode(clsBaseOperator, bReset)
        ucrSaveTable.SetRCode(clsBaseOperator, bReset)

    End Sub

    Private Sub TestOKEnabled()
        If Not ucrInputHeaderSubtitle.IsEmpty AndAlso ucrInputHeaderTitle.IsEmpty Then
            'If title not provided then subtitle should not be provided
            ucrBase.OKEnabled(False)
        Else
            ucrBase.OKEnabled(Not ucrReceiverMultipleCols.IsEmpty AndAlso ucrSaveTable.IsComplete)
        End If
    End Sub


End Class